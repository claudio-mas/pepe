CREATE VIEW [dbo].[ConsultaCC]
AS
SELECT        dbo.[Conta Corrente].ID, ISNULL(dbo.Clientes.Nome, dbo.Clientes.Cliente) AS N, dbo.[Conta Corrente].Banco, ISNULL(dbo.[Vencto Cheques].Vencto, dbo.[Conta Corrente].Data) AS Vencto, 
                         dbo.[Conta Corrente].Data
FROM            dbo.Clientes INNER JOIN
                         dbo.[Conta Corrente] ON dbo.Clientes.IDCliente = dbo.[Conta Corrente].Cliente LEFT OUTER JOIN
                         dbo.[Vencto Cheques] ON dbo.[Conta Corrente].ID = dbo.[Vencto Cheques].IdCC
