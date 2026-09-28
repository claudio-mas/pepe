Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Text
Imports Microsoft.Office.Interop

Partial Public Class frmClientesDG
    Inherits System.Windows.Forms.Form

    ' Colunas de texto consideradas pela pesquisa (substitui o "find panel" do GridControl DevExpress).
    Private Shared ReadOnly CamposPesquisa As String() = {"Título", "Nome", "Cliente", "Endereço", "Bairro", "Telefone"}

    ' Mensagem do Windows que mostra o texto de dica ("Pesquisar...") no TextBox vazio.
    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Unicode)>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As IntPtr, lParam As String) As IntPtr
    End Function

    Public Sub New()
        InitializeComponent()
        ' As colunas estão definidas no designer; sem isto o DataGridView acrescentaria
        ' todas as colunas da tabela Clientes. Por isso o DataSource é ligado aqui, e não no designer.
        dgvClientes.AutoGenerateColumns = False
        dgvClientes.DataSource = ClientesBindingSource1
    End Sub

    Private Sub frmClientesDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientesTableAdapter1.Fill(Me.DsNovo.Clientes)
        'Me.ClientesTableAdapter.Fill(Me.DsPrincipal.Clientes)

        SendMessage(txtPesquisa.Handle, EM_SETCUEBANNER, New IntPtr(1), "Pesquisar...")
        AtualizarPosicao()

        frmDevPrincipal.Visible = False

    End Sub

    Private Sub frmClientesDG_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'fExecutarText("Update Clientes Set Imp = 0 where Imp = 1 Or Imp is NULL")
        ' incluir tratamento de erro
        Try
            Me.Validate()
            ClientesBindingSource1.EndEdit()
            ClientesTableAdapter1.Update(DsNovo)
        Catch ex As Exception
            'MsgBox(ex.Message)
            'e.Cancel = True
        Finally
            frmDevPrincipal.Visible = True
        End Try

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()

    End Sub

#Region "Grade"

    ''' <summary>Linha de dados (DataRowView) por trás de uma linha da grade.</summary>
    Private Function LinhaDaGrade(rowIndex As Integer) As DataRowView
        If rowIndex < 0 OrElse rowIndex >= dgvClientes.Rows.Count Then Return Nothing
        Return TryCast(dgvClientes.Rows(rowIndex).DataBoundItem, DataRowView)
    End Function

    ' Os dois botões da grade (abrir cadastro / registrar venda) são colunas de imagem.
    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        Dim drv = LinhaDaGrade(e.RowIndex)
        If drv Is Nothing Then Return

        If e.ColumnIndex = colAbrir.Index Then
            AbrirCadastro(drv)
        ElseIf e.ColumnIndex = colVenda.Index Then
            AbrirVenda(drv)
        End If
    End Sub

    Private Sub dgvClientes_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvClientes.CellFormatting
        ' Colunas de imagem não vinculadas: sempre mostram o ícone do botão (sem isto aparece o "X" vermelho).
        If e.ColumnIndex = colAbrir.Index Then
            e.Value = colAbrir.Image
        ElseIf e.ColumnIndex = colVenda.Index Then
            e.Value = colVenda.Image
        End If
    End Sub

    Private Sub dgvClientes_CellToolTipTextNeeded(sender As Object, e As DataGridViewCellToolTipTextNeededEventArgs) Handles dgvClientes.CellToolTipTextNeeded
        If e.RowIndex < 0 Then Return
        If e.ColumnIndex = colAbrir.Index Then
            e.ToolTipText = "Abre o cadastro do cliente"
        ElseIf e.ColumnIndex = colVenda.Index Then
            e.ToolTipText = "Registra venda para o cliente"
        End If
    End Sub

    Private Sub dgvClientes_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellMouseEnter
        Dim ehBotao = e.RowIndex >= 0 AndAlso (e.ColumnIndex = colAbrir.Index OrElse e.ColumnIndex = colVenda.Index)
        dgvClientes.Cursor = If(ehBotao, Cursors.Hand, Cursors.Default)
    End Sub

    Private Sub dgvClientes_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellMouseLeave
        dgvClientes.Cursor = Cursors.Default
    End Sub

    ' O DataGridView só grava o valor do checkbox ao sair da célula; aqui ele é gravado no clique,
    ' como fazia o CheckEdit do GridControl.
    Private Sub dgvClientes_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvClientes.CurrentCellDirtyStateChanged
        If dgvClientes.IsCurrentCellDirty AndAlso TypeOf dgvClientes.CurrentCell Is DataGridViewCheckBoxCell Then
            dgvClientes.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvClientes_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvClientes.DataError
        ' Evita a caixa de diálogo padrão do DataGridView para erros de formatação.
        e.ThrowException = False
    End Sub

    Private Sub ClientesBindingSource1_PositionChanged(sender As Object, e As EventArgs) Handles ClientesBindingSource1.PositionChanged, ClientesBindingSource1.ListChanged
        AtualizarPosicao()
    End Sub

    ' Substitui o navegador embutido do GridControl ("{0} / {1}").
    Private Sub AtualizarPosicao()
        lblPosicao.Text = String.Format("{0} / {1}", ClientesBindingSource1.Position + 1, ClientesBindingSource1.Count)
    End Sub

#End Region

#Region "Pesquisa"

    Private Sub txtPesquisa_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisa.TextChanged
        ' Espera o usuário parar de digitar antes de filtrar.
        tmrPesquisa.Stop()
        tmrPesquisa.Start()
    End Sub

    Private Sub tmrPesquisa_Tick(sender As Object, e As EventArgs) Handles tmrPesquisa.Tick
        tmrPesquisa.Stop()
        AplicarFiltro()
    End Sub

    Private Sub txtPesquisa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPesquisa.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                tmrPesquisa.Stop()
                AplicarFiltro()
                e.SuppressKeyPress = True
            Case Keys.Escape
                txtPesquisa.Clear()
                e.SuppressKeyPress = True
            Case Keys.Down
                dgvClientes.Focus()
                e.Handled = True
        End Select
    End Sub

    ''' <summary>
    ''' Filtra a grade como o "find panel" do DevExpress: cada palavra digitada precisa aparecer
    ''' em pelo menos uma das colunas (inclusive a data de aniversário).
    ''' </summary>
    Private Sub AplicarFiltro()
        Dim palavras = txtPesquisa.Text.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)

        dgvClientes.EndEdit()
        If palavras.Length = 0 Then
            ClientesBindingSource1.RemoveFilter()
        Else
            Dim condicoes As New List(Of String)
            For Each palavra In palavras
                Dim valor = EscaparLike(palavra)
                Dim alternativas As New List(Of String)
                For Each campo In CamposPesquisa
                    alternativas.Add(String.Format("[{0}] LIKE '%{1}%'", campo, valor))
                Next
                alternativas.Add(String.Format("CONVERT([Aniv], 'System.String') LIKE '%{0}%'", valor))
                condicoes.Add("(" & String.Join(" OR ", alternativas) & ")")
            Next
            ClientesBindingSource1.Filter = String.Join(" AND ", condicoes)
        End If
        AtualizarPosicao()
    End Sub

    ''' <summary>Escapa os caracteres especiais do LIKE do DataView (', [, ], *, %).</summary>
    Private Shared Function EscaparLike(texto As String) As String
        Dim sb As New StringBuilder()
        For Each ch In texto
            Select Case ch
                Case "["c, "]"c, "*"c, "%"c
                    sb.Append("[").Append(ch).Append("]")
                Case "'"c
                    sb.Append("''")
                Case Else
                    sb.Append(ch)
            End Select
        Next
        Return sb.ToString()
    End Function

#End Region

    Private Sub AbrirCadastro(drv As DataRowView)
        varIdCliente = drv("IDCliente")
        frmClientes.Show()

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        varIdCliente = 0
        frmClientes.Show()

    End Sub

    Private Sub ckTodas_CheckedChanged(sender As Object, e As EventArgs) Handles ckTodas.CheckedChanged

        Me.Cursor = Cursors.AppStarting
        ckTodas.Text = If(ckTodas.Checked, "Desmarcar todas", "Marcar todas")

        ' Marca/desmarca só as linhas visíveis (respeita a pesquisa), como o GridView1.DataRowCount fazia.
        ' Grava direto no DataRow e só redesenha a grade no fim, para não ficar lento com o cadastro inteiro.
        dgvClientes.EndEdit()
        Dim linhas = ClientesBindingSource1.List.Cast(Of DataRowView)().Select(Function(v) v.Row).ToList()
        ClientesBindingSource1.RaiseListChangedEvents = False
        Try
            For Each linha In linhas
                linha("Imp") = ckTodas.Checked
            Next
        Finally
            ClientesBindingSource1.RaiseListChangedEvents = True
            ClientesBindingSource1.ResetBindings(False)
        End Try

        Me.Validate()
        ClientesBindingSource1.EndEdit()
        ClientesTableAdapter1.Update(DsNovo)

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub btnEtiqMalaDireta_Click(sender As Object, e As EventArgs) Handles btnEtiqMalaDireta.Click
        Me.Validate()
        ClientesBindingSource1.EndEdit()
        ClientesTableAdapter1.Update(DsNovo)

        Dim x As String = DLookUp("Imp", "Clientes", "Imp = 1", 0)
        If x = "" Then
            MessageBox.Show("Nenhum cliente selecionado para impressão de etiquetas", "Atenção!")
        Else
            frmEtiquetas.Show()
        End If

    End Sub

    Private Sub AbrirVenda(drv As DataRowView)
        Try
            varIdCliente = drv("IDCliente")
            If Not IsDBNull(drv("Nome")) Then varNomeCli = drv("Nome")
            If Not IsDBNull(drv("Cliente")) Then varNomeMD = drv("Cliente")

            Dim rs As New ADODB.Recordset()
            Dim cnStr As String = strAdoConnection()
            rs.Open("SELECT Max(Venda) AS V FROM VENDAS WHERE Venda Is Not Null GROUP BY Year([DataVenda]) HAVING Year([DataVenda])=Year(GetDate())", cnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            If rs.EOF Then
                varNovaVenda = "0001" & "/" & Format(Date.Today, "yy")
            Else
                varNovaVenda = String.Format("{0,4:D4}", CInt(Microsoft.VisualBasic.Left(rs("V").Value, 4)) + 1) & "/" & Format(Date.Today, "yy")
            End If
            rs.Close()

            fExecutarText("Insert into VENDAS (IdCliente, DataVenda, Venda, Tipo) Values (" & varIdCliente & ", '" & Format(Date.Today, "yyyy-MM-dd") & "', '" & varNovaVenda & "', 'Interna')")

            varIdVenda = DLookUp("Id", "SELECT TOP 1 Id FROM VENDAS ORDER BY Id DESC", "", 1)

            frmNewVenda.Show()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnEtiqAniv_Click(sender As Object, e As EventArgs) Handles btnEtiqAniv.Click
        frmEtiqAniv.Show()

    End Sub

    Private Sub btnEmails_Click(sender As Object, e As EventArgs) Handles btnEmails.Click

        Dim conn As New SqlConnection(My.Settings.Pepe_ConnString)   ' conexão central (ver modConexao)
        conn.Open()
        Dim ds As DataSet
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = "SELECT Email FROM Clientes WHERE (((Clientes.Nome) Is Not Null) AND (([Email]) Is Not Null) AND ((CHARINDEX('@',[Email]))>0)) ORDER BY Clientes.Email"
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds)
        dt = ds.Tables(0)
        cmd.Dispose()
        da.Dispose()
        conn.Dispose()

        Dim objExcel As Microsoft.Office.Interop.Excel.Application
        Dim Pasta1 As Microsoft.Office.Interop.Excel.Workbook
        Dim Plan1 As Microsoft.Office.Interop.Excel.Worksheet

        objExcel = New Microsoft.Office.Interop.Excel.Application()
        Pasta1 = objExcel.Workbooks.Add()
        Plan1 = objExcel.Worksheets.Add()
        Plan1.Name = "E-mails do Sistema"
        Plan1.Activate()

        Dim i As Integer
        Dim linha As Integer = 1

        'objExcel.ActiveSheet.Range("A1:D1").merge()
        objExcel.ActiveSheet.Cells(1, 1).Font.Bold = True
        objExcel.ActiveSheet.Cells(1, 1).Value = "E-mail"
        objExcel.ActiveSheet.cells(1, 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter

        For i = 0 To dt.Rows.Count - 1
            linha += 1
            objExcel.ActiveSheet.Cells(linha, 1).Value = dt.Rows(i).Item("Email")
        Next

        objExcel.ActiveSheet.Columns(1).EntireColumn.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft
        'objExcel.ActiveSheet.Cells(3, 1).Font.Bold = True
        objExcel.ActiveSheet.Columns(1).EntireColumn.AutoFit()

        With objExcel.ActiveSheet.Cells.Font
            .Name = "Arial"
            .Size = 10
        End With

        objExcel.Application.Visible = True
        objExcel = Nothing
        Pasta1 = Nothing
        Plan1 = Nothing

    End Sub

    Private Sub btnEndereços_Click(sender As Object, e As EventArgs) Handles btnEndereços.Click
        EndereçosClientesBase.Show()

    End Sub

    Private Sub btnTelefones_Click(sender As Object, e As EventArgs) Handles btnTelefones.Click
        TelefonesClientesBase.Show()

    End Sub
End Class
