

CREATE PROCEDURE [dbo].[USP_UltimoReajuste] 
	
AS
BEGIN
	
	SET NOCOUNT ON;

	UPDATE [1TabPeçasHistórico] SET U = 1 FROM [1TabPeçasHistórico] T INNER JOIN (SELECT IdPeça, Max(Id) AS UiD FROM [1TabPeçasHistórico] GROUP BY IdPeça) ult
	ON T.Id = ult.UiD;

	UPDATE Reajustes SET U = 1 FROM Reajustes R inner join (SELECT Top 1 Id, U FROM Reajustes ORDER BY Id DESC)  R2
	on R.Id = R2.Id;

END
