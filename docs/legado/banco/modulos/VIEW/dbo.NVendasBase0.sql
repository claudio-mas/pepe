
CREATE VIEW [dbo].[NVendasBase0]
AS
SELECT        dbo.Clientes.Nome, MAX(dbo.Clientes.Endereço) AS MáxDeEndereço, MAX(dbo.Clientes.Bairro) AS MáxDeBairro, MAX(dbo.Clientes.Cidade) AS MáxDeCidade, MAX(dbo.Clientes.Estado) AS MáxDeEstado, MAX(dbo.Clientes.CEP) 
                         AS MáxDeCEP, MAX(dbo.Clientes.Telefone) AS MáxDeTelefone
FROM            dbo.Clientes INNER JOIN
                         dbo.VENDAS ON dbo.Clientes.IDCliente = dbo.VENDAS.IDCliente
GROUP BY dbo.Clientes.Nome
HAVING        (dbo.Clientes.Nome IS NOT NULL)
