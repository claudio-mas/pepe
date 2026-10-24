

CREATE PROCEDURE [dbo].[USP_MATPRIMA]
	@i int,
	@aAno INT
AS
BEGIN
SET NOCOUNT ON;

DECLARE @Diamantes FLOAT, @Diamantes2 FLOAT, @Rubis FLOAT, @Safiras FLOAT, @Esmeraldas FLOAT, @Citrino FLOAT, @PedrasBras FLOAT, @Perolas FLOAT
DECLARE @Ouro FLOAT, @Prata FLOAT

DECLARE cursor1 CURSOR FOR
SELECT Sum(PEDRAS.DiamantesQtde) AS SomaDeDiamantesQtde, Sum(PEDRAS.Diamantes2Qtde) AS SomaDeDiamantes2Qtde, Sum(PEDRAS.RubiQtde) AS SomaDeRubiQtde, Sum(PEDRAS.SafiraQtde) AS SomaDeSafiraQtde, Sum(PEDRAS.EsmeraldaQtde) AS SomaDeEsmeraldaQtde, Sum(PEDRAS.CitrinoQtde) AS SomaDeCitrinoQtde, Sum(PEDRAS.PedrasBrasQtde) AS SomaDePedrasBrasQtde, Sum(PEDRAS.PerolasQtde) AS SomaDePerolasQtde
FROM [1TabPeças] INNER JOIN PEDRAS ON [1TabPeças].IDPeça = PEDRAS.Id
WHERE ((([1TabPeças].Modêlo) Is Not Null) AND ((Month([DataReg]))=@i) AND ((Year([DataReg]))=@aAno));

OPEN cursor1;
FETCH NEXT FROM cursor1 INTO @Diamantes, @Diamantes2, @Rubis, @Safiras, @Esmeraldas, @Citrino, @PedrasBras, @Perolas;
WHILE @@FETCH_STATUS = 0
BEGIN
	UPDATE tabMatPrima SET QtSai = @Diamantes + @Diamantes2 WHERE mMes = @i AND aAno = @aAno AND IdMatPrima = 1;
	UPDATE tabMatPrima SET QtSai = @PedrasBras WHERE mMes = @i AND aAno = @aAno AND IdMatPrima = 2;
	UPDATE tabMatPrima SET QtSai = @Perolas WHERE mMes = @i AND aAno = @aAno AND IdMatPrima = 3;
	UPDATE tabMatPrima SET QtSai = @Rubis WHERE mMes = @i AND aAno = @aAno AND IdMatPrima = 4;
	UPDATE tabMatPrima SET QtSai = @Safiras WHERE mMes = @i AND aAno = @aAno AND IdMatPrima = 5;
	UPDATE tabMatPrima SET QtSai = @Esmeraldas WHERE mMes = @i AND aAno = @aAno AND IdMatPrima = 6;
	UPDATE tabMatPrima SET QtSai = @Citrino WHERE mMes = @i AND aAno = @aAno AND IdMatPrima = 7;	
	FETCH NEXT FROM cursor1 INTO @Diamantes, @Diamantes2, @Rubis, @Safiras, @Esmeraldas, @Citrino, @PedrasBras, @Perolas;
END

CLOSE cursor1;
DEALLOCATE cursor1;

DECLARE cursor2 CURSOR FOR
SELECT Sum(METAIS.OuroQtde) AS SomaDeOuroQtde, Sum(METAIS.PrataQtde) AS SomaDePrataQtde
FROM [1TabPeças] INNER JOIN METAIS ON [1TabPeças].IDPeça = METAIS.Id
WHERE ((([1TabPeças].Modêlo) Is Not Null) AND ((Month([DataReg]))=@i) AND ((Year([DataReg]))=@aAno));
	
OPEN cursor2;
FETCH NEXT FROM cursor2 INTO @Ouro, @Prata;
WHILE @@FETCH_STATUS = 0
BEGIN
	UPDATE tabMatPrima SET QtSai = @Ouro WHERE mMes = @i AND aAno = @aAno AND IdMatPrima = 8;
	UPDATE tabMatPrima SET QtSai = @Prata WHERE mMes = @i AND aAno = @aAno AND IdMatPrima = 9;
	FETCH NEXT FROM cursor2 INTO @Ouro, @Prata;
END;
CLOSE cursor2;
DEALLOCATE cursor2;

UPDATE tabMatPrima SET Total = ISNULL(PrUnit, 0) * ISNULL(QtEnt, 0), QtSaldo = ISNULL(QtEnt, 0) - ISNULL(QtSai, 0),
	ValSaldo = ISNULL(QtSaldo, 0) * ISNULL(PrUnit, 0) WHERE mMes = @i AND aAno = @aAno

END
