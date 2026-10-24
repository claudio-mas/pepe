


CREATE PROCEDURE [dbo].[USP_CC_SALDO] @cliente nvarchar(200)
AS
BEGIN
	SET NOCOUNT ON;

;with cte_dados as 
(SELECT      ISNULL(dbo.Clientes.Nome, dbo.Clientes.Cliente) AS Cliente, dbo.CC.Data,
case CC.Op	when 'Conserto' then dbo.CC.Op + ' (' + CC.Tp + ')'
			when 'Venda' then dbo.CC.Op + ' ' + Vendas.Venda + ' (' + CC.Tp + ')'
			when 'C/C' then dbo.CC.Op + ' (' + CC.Tp + ')' end as Historico,
			iif(dbo.CC.VValor < 0, dbo.CC.VValor, 0) as Debito,
			iif(dbo.CC.VValor >= 0, dbo.CC.VValor, 0) as Credito, dbo.CC.VValor
FROM            dbo.Clientes INNER JOIN
                         dbo.CC ON dbo.Clientes.IDCliente = dbo.CC.CLIENTE LEFT OUTER JOIN
                         dbo.VENDAS ON dbo.CC.ID = dbo.VENDAS.Id
where ISNULL(dbo.Clientes.Nome, dbo.Clientes.Cliente)=@cliente
), cte_dados2 as
(select row_number() over(order by Cliente, Data) as numerador, Cliente, cte_dados.[Data], Historico, Debito, cte_dados.Credito, VValor from cte_dados
)

select *, abs(Debito) as Deb, iif(Credito>0,'C', 'D') as CD,
 isnull((select a.VValor + sum(b.VValor) from cte_dados2 b where numerador <= a.numerador-1),a.VValor) as SaldoAcumulado
from cte_dados2 a;

END

