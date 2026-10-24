

CREATE PROCEDURE [dbo].[USP_VOLTA] @Id int, @ficha nvarchar(10)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @i int;

	INSERT INTO [dbo].[1TabPeças]
           ([Classe]
           ,[Modêlo]
           ,[Descrição]
           ,[Oficial]
           ,[Família]           
           ,[Origem]
           ,[DataIn]
           ,[Custo]
           ,[Dólar]
           ,[Posição]
           ,[Vendida]
           --,[DataVenda]
           ,[Comissão]
           ,[PC]
           ,[PCQtde]
           ,[MOExt]
           ,[MOInt]
           ,[Oficina]
           ,[DataReg]
           ,[Desenho]
           ,[Madeira]
           ,[Couro]
           ,[Cravação]
           ,[Outras]
           ,[Obs]
           ,[DataFabric]
           ,[PrVenda]
           ,[PrVendaAnt]
           ,[Volta]
           ,[IdPeçaOrigem])
     Select
           [Classe]
           ,@ficha
           ,[Descrição]
           ,[Oficial]
           ,[Família]           
           ,[Origem]
           ,[DataIn]
           ,[Custo]
           ,[Dólar]
           ,[Posição]
           ,0
           --,[DataVenda]
           ,[Comissão]
           ,[PC]
           ,[PCQtde]
           ,[MOExt]
           ,[MOInt]
           ,[Oficina]
           ,GETDATE()
           ,[Desenho]
           ,[Madeira]
           ,[Couro]
           ,[Cravação]
           ,[Outras]
           ,[Obs]
           ,[DataFabric]
           ,[PrVenda]
           ,[PrVendaAnt]
           ,1
           ,[IdPeça]
	FROM [1TabPeças]
	WHERE IDPeça = @Id;

	set @i = (Select max(IDPeça) From [BDTorras].dbo.[1TabPeças])

	INSERT INTO [dbo].[METAIS]
           ([Id]
           ,[OuroQtde]
           ,[PaladiumQtde]
           ,[PrataQtde]
           ,[PlatinaQtde]
           ,[PerdaPerc]
           ,[PerdaQtde]
           ,[SistemaQtde]
           ,[TotalQtde]
           ,[TotalValor]
           ,[SistemaValor]
           ,[OuroV]
           ,[PaladiumV]
           ,[PrataV]
           ,[PlatinaV])
     SELECT
           @i
           ,[OuroQtde]
           ,[PaladiumQtde]
           ,[PrataQtde]
           ,[PlatinaQtde]
           ,[PerdaPerc]
           ,[PerdaQtde]
           ,[SistemaQtde]
           ,[TotalQtde]
           ,[TotalValor]
           ,[SistemaValor]
           ,[OuroV]
           ,[PaladiumV]
           ,[PrataV]
           ,[PlatinaV]
	FROM METAIS
	WHERE Id = @Id;

	INSERT INTO [dbo].[PEDRAS]
           ([Id]
           ,[DiamantesQtde]
           ,[DiamantesValor]
           ,[RubiQtde]
           ,[RubiValor]
           ,[SafiraQtde]
           ,[SafiraValor]
           ,[EsmeraldaQtde]
           ,[EsmeraldaValor]
           ,[CitrinoQtde]
           ,[CitrinoValor]
           ,[PedrasBrasQtde]
           ,[PedrasBrasValor]
           ,[PerolasQtde]
           ,[PerolasValor]
           ,[DiamantesCT]
           ,[RubisCT]
           ,[SafirasCT]
           ,[EsmeraldasCT]
           ,[PedrasCT]
           ,[BrasCT]
           ,[PerolasCT]
           ,[Diamantes2Qtde]
           ,[Diamantes2Valor]
           ,[Diamantes2CT])
     SELECT
           @i
           ,[DiamantesQtde]
           ,[DiamantesValor]
           ,[RubiQtde]
           ,[RubiValor]
           ,[SafiraQtde]
           ,[SafiraValor]
           ,[EsmeraldaQtde]
           ,[EsmeraldaValor]
           ,[CitrinoQtde]
           ,[CitrinoValor]
           ,[PedrasBrasQtde]
           ,[PedrasBrasValor]
           ,[PerolasQtde]
           ,[PerolasValor]
           ,[DiamantesCT]
           ,[RubisCT]
           ,[SafirasCT]
           ,[EsmeraldasCT]
           ,[PedrasCT]
           ,[BrasCT]
           ,[PerolasCT]
           ,[Diamantes2Qtde]
           ,[Diamantes2Valor]
           ,[Diamantes2CT]
	FROM PEDRAS
	WHERE Id = @Id;

END

