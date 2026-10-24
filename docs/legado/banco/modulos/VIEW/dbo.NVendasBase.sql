
CREATE VIEW [dbo].[NVendasBase]
AS
SELECT        dbo.Clientes.Nome, dbo.NVendasBase0.MáxDeEndereço AS Endereço, dbo.NVendasBase0.MáxDeBairro AS Bairro, dbo.NVendasBase0.MáxDeCidade AS Cidade, dbo.NVendasBase0.MáxDeEstado AS Estado, 
                         dbo.NVendasBase0.MáxDeCEP AS CEP, dbo.NVendasBase0.MáxDeTelefone AS Telefone, MAX(dbo.VENDAS.DataVenda) AS Última
FROM            dbo.NVendasBase0 INNER JOIN
                         dbo.Clientes INNER JOIN
                         dbo.VENDAS ON dbo.Clientes.IDCliente = dbo.VENDAS.IDCliente ON dbo.NVendasBase0.Nome = dbo.Clientes.Nome
GROUP BY dbo.Clientes.Nome, dbo.NVendasBase0.MáxDeEndereço, dbo.NVendasBase0.MáxDeBairro, dbo.NVendasBase0.MáxDeCidade, dbo.NVendasBase0.MáxDeEstado, dbo.NVendasBase0.MáxDeCEP, 
                         dbo.NVendasBase0.MáxDeTelefone
HAVING        (dbo.Clientes.Nome IS NOT NULL)
