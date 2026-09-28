Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI



Partial Public Class frmMatPrimaDG
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()

    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Me.MesesTableAdapter.Fill(Me.DsMatPrima.Meses)
            Me.TabMatPrimaTableAdapter.Fill(Me.DsMatPrima.tabMatPrima)
            Me.TabMateriaPrimaTableAdapter.Fill(Me.DsMatPrima.tabMateriaPrima)

            Me.cboAno.Text = Year(Date.Now).ToString
            Me.cboMes.EditValue = Month(Date.Now)

            Me.cboAno1.Text = Year(Date.Now).ToString
            Me.cboMes1.EditValue = Month(Date.Now)
            Me.cboAno2.Text = Year(Date.Now).ToString
            Me.cboMes2.EditValue = Month(Date.Now)

            fExecutarText("exec USP_MATPRIMA " & Me.cboMes.EditValue & ", " & CInt(Me.cboAno.Text))
            Me.TabMatPrimaBindingSource.Filter = "mMes = " & Me.cboMes.EditValue & " And aAno = " & CInt(Me.cboAno.Text)

            Me.Tag = "1"

            'Dim myLine As New Line()
            'myLine.Stroke = Brushes.LightSteelBlue
            'myLine.X1 = 1
            'myLine.X2 = 50
            'myLine.Y1 = 1
            'myLine.Y2 = 50
            'myLine.HorizontalAlignment = HorizontalAlignment.Left
            'myLine.VerticalAlignment = VerticalAlignment.Center
            'myLine.StrokeThickness = 2

            frmDevPrincipal.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub frmClientes_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Try
            Me.Validate()
            Me.TabMatPrimaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsMatPrima)

        Catch ex As Exception

        Finally
            frmDevPrincipal.Visible = True

        End Try

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub botoes()
        If Me.Tag = "1" Then
            Me.ribbonPageGroup1.Visible = False
            Me.RibbonPageGroup2.Visible = True
            '    'If frmPedidosDG.RadGridView1.Tag <> "1" Then Me.ControlBox = False
            'Me.RibbonPageGroup3.Visible = False : Me.btnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.ControlBox = False
        End If

    End Sub


    Private Sub frmClientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        On Error Resume Next

        'Select Case e.KeyCode
        '    Case Keys.Enter
        '        SendKeys.Send("{Tab}")
        'End Select

    End Sub

    Private Sub CONSERTOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        'Me.CONSERTOSBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.DsGeral)

    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        varIdCon = GridView1.GetFocusedRowCellValue("ID")
        'frmConsertosfrm.Show()

    End Sub

    Private Sub btnNovo_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        varIdCon = 0
        'frmConsertosfrm.Show()

    End Sub

    Private Sub cboMes_EditValueChanged(sender As Object, e As EventArgs) Handles cboMes.EditValueChanged
        If Me.Tag = "1" Then
            fExecutarText("exec USP_MATPRIMA " & Me.cboMes.EditValue & ", " & CInt(Me.cboAno.Text))
            Me.TabMatPrimaBindingSource.Filter = "mMes = " & Me.cboMes.EditValue & " And aAno = " & CInt(Me.cboAno.Text)
        End If

    End Sub

    Private Sub cboAno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAno.SelectedIndexChanged
        If Me.Tag = "1" Then
            fExecutarText("exec USP_MATPRIMA " & Me.cboMes.EditValue & ", " & CInt(Me.cboAno.Text))
            Me.TabMatPrimaBindingSource.Filter = "mMes = " & Me.cboMes.EditValue & " And aAno = " & CInt(Me.cboAno.Text)
        End If

    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanged

        RemoveHandler GridView1.CellValueChanged, AddressOf GridView1_CellValueChanged

        Dim qtEnt As Double = ConvertToDouble(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "QtEnt"))
        Dim prUnit As Double = ConvertToDouble(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "PrUnit"))
        Dim qtSai As Double = ConvertToDouble(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "QtSai"))
        Dim saldoQt As Double = qtEnt - qtSai

        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Total", qtEnt * prUnit)
        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "ValSaldo", saldoQt * prUnit)
        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "QtSaldo", saldoQt)

        AddHandler GridView1.CellValueChanged, AddressOf GridView1_CellValueChanged

    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click

        Dim report As New rptMatPrima()

        report.SqlDataSource1.Queries(0).Parameters(0).Value = CDate("01/" & Format(Me.cboMes1.EditValue, "00") & "/" & Me.cboAno1.Text) 'CInt(Nz(cboAno.Text, System.DateTime.Today.ToString("yyyy")))
        report.SqlDataSource1.Queries(0).Parameters(1).Value = CDate("02/" & Format(Me.cboMes2.EditValue, "00") & "/" & Me.cboAno2.Text)
        'report.txtPeriodo.Text = Me.txtData1.Text & " a " & Me.txtData2.Text

        report.SqlDataSource1.Fill()

        If Me.cboMes1.Text = Me.cboMes2.Text And Me.cboAno1.Text = Me.cboAno2.Text Then
            report.txtPeriodo.Text = Me.cboMes1.Text & "/" & cboAno1.Text
        Else
            report.txtPeriodo.Text = Me.cboMes1.Text & "/" & cboAno1.Text & " a " & Me.cboMes2.Text & "/" & cboAno2.Text
        End If

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowRibbonPreview()

    End Sub

End Class
