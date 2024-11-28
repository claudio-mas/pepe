Imports System.Windows.Forms

Public Class frmSenha

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        Dim y As String = DLookUp("Senha", "Senha", "[Senha]<>'Golfe' And [Senha]<>'Canon'", 1)
        If y <> Me.txtSenha.Text Then
            MsgBox("Senha incorreta", vbCritical, "Atenção!")
            Exit Sub
        End If

        If varBtn = 1 Then
            Dim ok1 As Boolean, ok2 As Boolean, msg As String
            ok1 = False
            ok2 = False

            If var1 > 0 Then
                ok1 = True
            End If
            If var2 > 0 Then
                ok2 = True
            End If

            If ok1 And ok2 Then
                msg = "Confirma o reajuste de " & var1 & " sobre o custo das peças em estoque?" & Chr(10) & Chr(10) & "Confirma o reajuste de " & var2 & " sobre o preço de venda das peças em estoque?"
            ElseIf ok1 Then
                msg = "Confirma o reajuste de " & var1 & " sobre o custo das peças em estoque?"
            Else
                msg = "Confirma o reajuste de " & var2 & " sobre o preço de venda das peças em estoque?"
            End If

            If MsgBox(msg, vbQuestion + vbOKCancel, "Atenção!") = vbOK Then
                fExecutarText("Update Reajustes Set U = 0; Update [1TabPeçasHistórico] Set U = 0")

                If ok1 And ok2 Then
                    fExecutarText("INSERT INTO Reajustes ( DataReaj, FatorCusto, FatorVenda, U) SELECT '" & varData & "' AS Expr1, " & Replace(var1, ",", ".") & " AS Expr2, " & Replace(var2, ",", ".") & " AS Expr3, 1 AS x")
                    fExecutarText("INSERT INTO [1TabPeçasHistórico] (IDPeça, DataReajuste, CustoAnt, FatorC, Custo, PrVendaAnt, FatorV, PrVenda, U ) SELECT [1TabPeças].IDPeça, r.DataReaj, [1TabPeças].Custo, r.FatorCusto, [1TabPeças].[Custo]*[FatorCusto] AS Expr1, [1TabPeças].PrVenda, r.FatorVenda, [1TabPeças].[PrVenda]*[FatorVenda] AS Expr2, 1 AS x FROM [1TabPeças], (SELECT top 1 Id, DataReaj, FatorCusto, FatorVenda FROM Reajustes ORDER BY Id DESC)  AS r WHERE isnull([1TabPeças].Vendida,0)=0")
                    fExecutarText("UPDATE [1TabPeças] SET CustoAnt = [Custo], PrVendaAnt = [PrVenda] WHERE isnull(Vendida,0) = 0")
                    fExecutarText("UPDATE [1TabPeças] SET Custo = [CustoAnt] * (SELECT top 1 FatorCusto FROM Reajustes ORDER BY Id DESC), PrVenda = [PrVendaAnt] * (SELECT top 1 FatorVenda FROM Reajustes ORDER BY Id DESC) WHERE isnull(Vendida,0)=0")
                ElseIf ok1 Then
                    fExecutarText("INSERT INTO Reajustes (DataReaj, FatorCusto, FatorVenda, U) SELECT '" & varData & "' AS Expr1, " & Replace(var1, ",", ".") & " AS Expr2, " & Replace(var2, ",", ".") & " AS Expr3, 1 AS x")
                    fExecutarText("INSERT INTO [1TabPeçasHistórico] (IDPeça, DataReajuste, CustoAnt, FatorC, Custo, U) SELECT [1TabPeças].IDPeça, r.DataReaj, [1TabPeças].Custo, r.FatorCusto, [1TabPeças].[Custo]*[FatorCusto] AS Expr1, 1 AS x FROM [1TabPeças], (SELECT top 1 Id, DataReaj, FatorCusto, FatorVenda FROM Reajustes ORDER BY Id DESC)  AS r WHERE isnull([1TabPeças].Vendida,0)=0")
                    fExecutarText("UPDATE [1TabPeças] SET CustoAnt = [Custo] WHERE isnull(Vendida,0) = 0")
                    fExecutarText("UPDATE [1TabPeças] SET Custo = [CustoAnt] * (SELECT top 1 FatorCusto FROM Reajustes ORDER BY Id DESC) WHERE isnull(Vendida,0)=0")
                Else
                    fExecutarText("INSERT INTO Reajustes ( DataReaj, FatorCusto, FatorVenda, U ) SELECT '" & varData & "' AS Expr1, " & Replace(var1, ",", ".") & " AS Expr2, " & Replace(var2, ",", ".") & " AS Expr3, 1 AS x")
                    fExecutarText("INSERT INTO [1TabPeçasHistórico] ( IDPeça, DataReajuste, PrVendaAnt, FatorV, PrVenda, U ) SELECT [1TabPeças].IDPeça, r.DataReaj, [1TabPeças].PrVenda, r.FatorVenda, [1TabPeças].[PrVenda]*[FatorVenda] AS Expr2, 1 AS x FROM [1TabPeças], (SELECT top 1 Id, DataReaj, FatorCusto, FatorVenda FROM Reajustes ORDER BY Id DESC)  AS r WHERE isnull([1TabPeças].Vendida,0)=0")
                    fExecutarText("UPDATE [1TabPeças] SET PrVendaAnt = [PrVenda] WHERE isnull(Vendida,0)=0")
                    'fExecutarText("UPDATE [1TabPeças], (SELECT top 1 Id, DataReaj, FatorCusto, FatorVenda FROM Reajustes ORDER BY Id DESC)  AS r SET [1TabPeças].PrVenda = [PrVendaAnt]*[FatorVenda] WHERE isnull([1TabPeças].Vendida,0)=0")
                    fExecutarText("UPDATE [1TabPeças] SET [1TabPeças].PrVenda = [PrVendaAnt] * (SELECT top 1 FatorVenda FROM Reajustes ORDER BY Id DESC) WHERE isnull([1TabPeças].Vendida,0)=0")
                End If

                MsgBox("Reajuste aplicado com sucesso", vbInformation)
                frmReajuste.ReajustesTableAdapter.Fill(frmReajuste.DsNovoEstoque.Reajustes)
                var1 = 0
                var2 = 0

            End If
        Else
            Dim ok1 As Boolean, ok2 As Boolean
            ok1 = (DLookUp("FatorCusto", "Reajustes", "U = 1", 1) > 0)
            ok2 = (DLookUp("FatorVenda", "Reajustes", "U = 1", 1) > 0)

            If MsgBox("Confirma desfazer o último reajuste?", vbQuestion + vbYesNo, "Atenção!") = vbYes Then
                If ok1 And ok2 Then
                    'fExecutarText("UPDATE P SET P.Custo = [H].[CustoAnt], P.PrVenda = [H].[PrVendaAnt] from [1TabPeças] as P INNER JOIN (Select * From [1TabPeçasHistórico] Where U = 1) as H ON P.IDPeça = H.IdPeça WHERE (((P.Vendida)=0))")
                    fExecutarText("UPDATE [1TabPeças] SET Custo=CustoAnt, PrVenda=PrVendaAnt WHERE ISNULL(Vendida,0) = 0")
                    'fExecutarText("UPDATE p SET p.PrVenda = [H].[PrVendaAnt] from [1TabPeças] as p INNER JOIN (Select * From [1TabPeçasHistórico] Where U = 1)  AS H ON P.IDPeça = H.IdPeça  WHERE isnull(p.Vendida,0)=0")
                ElseIf ok1 Then
                    'fExecutarText("UPDATE P SET P.Custo = [H].[CustoAnt] from [1TabPeças] as P INNER JOIN (Select * From [1TabPeçasHistórico] Where U = 1)  AS H ON P.IDPeça = H.IdPeça  WHERE isnull(P.Vendida,0)=0")
                    fExecutarText("UPDATE [1TabPeças] SET Custo=CustoAnt WHERE ISNULL(Vendida,0) = 0")
                Else
                    'fExecutarText("UPDATE p SET p.PrVenda = [H].[PrVendaAnt] from [1TabPeças] as p INNER JOIN (Select * From [1TabPeçasHistórico] Where U = 1)  AS H ON P.IDPeça = H.IdPeça  WHERE isnull(p.Vendida,0)=0")
                    fExecutarText("UPDATE [1TabPeças] SET PrVenda=PrVendaAnt WHERE ISNULL(Vendida,0) = 0")
                End If
                fExecutarText("Delete From Reajustes Where U = 1")
                fExecutarText("Delete From [1TabPeçasHistórico] Where U = 1")
                fExecutarSP("USP_UltimoReajuste")

                MsgBox("O último reajuste foi desfeito com sucesso", vbInformation)
                frmReajuste.ReajustesTableAdapter.Fill(frmReajuste.DsNovoEstoque.Reajustes)

            End If
        End If

        Me.txtSenha.Text = ""
        Me.txtSenha.Focus()
        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.txtSenha.Text = ""
        Me.txtSenha.Focus()
        Me.Close()
    End Sub

End Class
