CREATE VIEW dbo.VI_Pecas_Web
AS
WITH PedrasAgg AS (
    SELECT 
        Id, 
        SUM(DiamantesQtde) AS DiamantesQtde, 
        SUM(DiamantesCT) AS DiamantesCT
    FROM dbo.PEDRAS
    GROUP BY Id
), 
MetaisAgg AS (
    SELECT 
        Id, 
        SUM(OuroQtde) AS OuroQtde
    FROM dbo.METAIS
    GROUP BY Id
), 
UltimaVenda AS (
    SELECT 
        VD.Peça, 
        V.Id, 
        V.DataVenda, 
        V.IDCliente, 
        ROW_NUMBER() OVER (PARTITION BY VD.Peça ORDER BY V.DataVenda DESC, V.Id DESC) AS rn
    FROM dbo.[VENDAS DET] VD 
    INNER JOIN dbo.VENDAS V ON V.Id = VD.Venda
)
SELECT 
    P.IDPeça, 
    P.Classe, 
    P.Modêlo, 
    P.Obs, 
    P.PrVenda, 
    P.Foto, 
    PE.DiamantesQtde, 
    PE.DiamantesCT, 
    M.OuroQtde, 
    V.DataVenda, 
    C.Nome AS NomeCliente, 
    P.Vendida, 
    V.Id, 
    CASE 
        WHEN P.Local IS NOT NULL AND P.Classe IS NOT NULL 
        THEN P.Classe + P.Local 
        ELSE NULL 
    END AS cLocal, 
    P.Local, 
    P.Saida
FROM dbo.[1TabPeças] P 
LEFT JOIN PedrasAgg PE ON PE.Id = P.IDPeça 
LEFT JOIN MetaisAgg M ON M.Id = P.IDPeça 
LEFT JOIN UltimaVenda V ON V.Peça = P.IDPeça AND V.rn = 1 
LEFT JOIN dbo.Clientes C ON C.IDCliente = V.IDCliente
WHERE P.Modêlo IS NOT NULL;
