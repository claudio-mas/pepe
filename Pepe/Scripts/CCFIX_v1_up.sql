/* =============================================================================
   CCFIX_v1_up.sql

   Corrige os Débitos C/C do relatório gerencial para a cliente
   "Sonia Monçores Velloso" (IDCliente 6147).

   PROBLEMA
   --------
   A view dbo.CCNovoGer devolvia DUAS linhas para essa cliente, e tanto
   GerencialNovoDados.vb:325 quanto GerencialBase.vb:474 fazem
   "Where t.Saldo < 0 ... Sum()", somando o saldo devedor dela em dobro:

       Débitos C/C exibido : -34.542,00
       Débitos C/C correto : -33.408,00
       Erro                :  -1.134,00  (propagado ao SALDO LÍQUIDO C/C)

   CAUSA
   -----
   [Conta Corrente].Real é float. CCRpt1.Saldo e CCRpt2.Anterior são SUM() sobre
   float, que é NÃO-ASSOCIATIVO: a mesma soma devolve 1335,9999999999995 ou 1336
   conforme a ordem de agregação escolhida pelo plano. CCNovoGer faz
   GROUP BY ... CCRpt22.Anterior, CCRpt1.Saldo, então os dois bit-patterns viram
   grupos distintos e a linha duplica. Por depender do plano, o erro é
   INTERMITENTE — "às vezes bate".

   Só essa cliente é atingida porque só ela tem lançamentos fracionários com
   saldo diferente de zero. Os demais têm valores inteiros redondos, que float
   representa exatamente.

   Os dois lançamentos fracionários:

     ID 48498 (02/01/2019, Cash C/C)  Real =  470,003
              digitação errada: o débito correspondente (venda 0655/18,
              VENDAS.ID 17962) é CCDeb = 470,00.

     ID 51229 (27/04/2023, Cash C/C)  Real = -0,003000000000156433
              "Lançamento para zerar saldo" — resíduo binário criado só para
              anular os 0,003 acima. Sem eles, não tem função.

   O QUE ESTE SCRIPT FAZ
   ---------------------
   Salva os valores originais em dbo.CCFIX_v1_Backup (tabela nova, aditiva) e
   normaliza os dois lançamentos para valores exatos em float:

     ID 48498 :  470,003  ->  470
     ID 51229 : -0,003... ->    0

   O saldo consolidado da cliente NÃO muda de valor: continua -1.134,00, agora
   representado exatamente. Com todos os lançamentos inteiros, SUM(float) dá o
   mesmo resultado em qualquer ordem, CCNovoGer volta a devolver uma linha só e
   o relatório para de somar em dobro.

   EFEITO COLATERAL ESPERADO
   -------------------------
   A view dbo.CC exige "Real <> 0" no ramo Cash/C-C. Com Real = 0, o lançamento
   51229 deixa de aparecer no extrato de conta corrente da cliente
   (USP_CC_SALDO / rptExtratoCC). É o comportamento desejado: era uma linha de
   ajuste de 0,003 que não existe mais. O registro permanece na tabela
   [Conta Corrente] para auditoria.

   NÃO CORRIGE
   -----------
   A classe do bug (float em CC.VValor e nas views CCRpt*) continua de pé. Novos
   lançamentos com centavos fracionários podem reproduzi-lo. Também não corrige
   o caso "Lya Stallone" (cliente com saldo devedor de -888,00 que some do
   relatório porque o último lançamento dela é um "Lançamento para zerar saldo"
   que não zerou).

   RODAR PRIMEIRO NUMA CÓPIA DE BDTorras.
   Reversível por CCFIX_v1_down.sql.
   ============================================================================= */

SET NOCOUNT ON;
SET XACT_ABORT ON;

BEGIN TRANSACTION;

/* ---------------------------------------------------------------------------
   1. Backup dos valores originais (bit-exatos, em varbinary).
   --------------------------------------------------------------------------- */
IF OBJECT_ID('dbo.CCFIX_v1_Backup', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.CCFIX_v1_Backup
    (
        ID          int             NOT NULL PRIMARY KEY,
        Cliente     int             NULL,
        Data        datetime2(7)    NULL,
        RealBin     varbinary(8)    NULL,   -- representação bit-exata do float
        RealValor   float           NULL,   -- só para leitura humana
        Obs         nvarchar(255)   NULL,
        GravadoEm   datetime2(7)    NOT NULL CONSTRAINT DF_CCFIX_v1_Backup_GravadoEm DEFAULT SYSDATETIME()
    );
END

INSERT INTO dbo.CCFIX_v1_Backup (ID, Cliente, Data, RealBin, RealValor, Obs)
SELECT  cc.ID,
        cc.Cliente,
        cc.Data,
        CONVERT(varbinary(8), cc.Real),
        cc.Real,
        cc.Obs
FROM    dbo.[Conta Corrente] AS cc
WHERE   cc.ID IN (48498, 51229)
  AND   NOT EXISTS (SELECT 1 FROM dbo.CCFIX_v1_Backup b WHERE b.ID = cc.ID);

/* ---------------------------------------------------------------------------
   2. Guarda de segurança: só altera se os valores forem os esperados.
      Se alguém já mexeu nesses lançamentos, o script aborta sem tocar em nada.
   --------------------------------------------------------------------------- */
DECLARE @conferidos int;

SELECT  @conferidos = COUNT(*)
FROM    dbo.[Conta Corrente]
WHERE  (ID = 48498 AND Cliente = 6147 AND CONVERT(varbinary(8), Real) = 0x407D600C49BA5E35)
    OR (ID = 51229 AND Cliente = 6147 AND CONVERT(varbinary(8), Real) = 0xBF689374BC700000);

IF @conferidos <> 2
BEGIN
    ROLLBACK TRANSACTION;
    RAISERROR('CCFIX_v1_up: lançamentos 48498/51229 não estão no estado esperado (encontrados %d de 2). Nada foi alterado.', 16, 1, @conferidos);
    RETURN;
END

/* ---------------------------------------------------------------------------
   3. Normalização.
   --------------------------------------------------------------------------- */
UPDATE dbo.[Conta Corrente]
SET    Real = 470
WHERE  ID = 48498 AND Cliente = 6147;

UPDATE dbo.[Conta Corrente]
SET    Real = 0
WHERE  ID = 51229 AND Cliente = 6147;

/* ---------------------------------------------------------------------------
   4. Verificação: saldo tem que ser -1134 exato e CCNovoGer tem que devolver
      uma linha só para a cliente.
   --------------------------------------------------------------------------- */
DECLARE @saldo float, @linhas int;

SELECT @saldo  = SUM(VValor) FROM dbo.CC WHERE CLIENTE = 6147;
SELECT @linhas = COUNT(*)    FROM dbo.CCNovoGer WHERE Saldo < 0 AND Cliente = N'Sonia Monçores Velloso';

IF @saldo <> -1134 OR @linhas <> 1
BEGIN
    ROLLBACK TRANSACTION;
    DECLARE @msg nvarchar(400) =
        N'CCFIX_v1_up: verificação falhou (saldo = ' + CONVERT(nvarchar(50), @saldo, 2)
      + N', linhas em CCNovoGer = ' + CONVERT(nvarchar(10), @linhas)
      + N'; esperado -1134 e 1). Alterações revertidas.';
    RAISERROR(@msg, 16, 1);
    RETURN;
END

COMMIT TRANSACTION;

PRINT 'CCFIX_v1_up: OK. Saldo da cliente = -1134,00 exato; CCNovoGer devolve 1 linha.';

/* ---------------------------------------------------------------------------
   5. Relatório final (fora da transação).
   --------------------------------------------------------------------------- */
SELECT  'Débitos C/C (WHERE Saldo < 0, forma usada pelo relatório)' AS Metrica,
        SUM(Saldo) AS Valor
FROM    dbo.CCNovoGer
WHERE   Saldo < 0
UNION ALL
SELECT  'Débitos C/C (sem duplicidade, referência)',
        SUM(Saldo)
FROM    (SELECT DISTINCT Cliente, Saldo FROM dbo.CCNovoGer WHERE Saldo < 0) AS x;
