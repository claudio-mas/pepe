<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesCadastrados
    Inherits Pepe.BaseRpts

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientesCadastrados))
        Me.chk1 = New DevExpress.XtraEditors.CheckEdit()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.ClientesCadastradosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCliente1 = New Pepe.dsCliente()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAniversário = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEndereço = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBairro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataCadastro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DsCliente = New Pepe.dsCliente()
        Me.ClientesCadastradosTableAdapter = New Pepe.dsClienteTableAdapters.ClientesCadastradosTableAdapter()
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.btnOk2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentViewerRibbonController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesCadastradosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCliente1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk2
        '
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Appearance.Options.UseFont = True
        Me.lblTitulo.Appearance.Options.UseForeColor = True
        Me.lblTitulo.Text = "CLIENTES CADASTRADOS"
        '
        'txtData1
        '
        Me.txtData1.EditValue = Nothing
        Me.txtData1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData1.Properties.Appearance.Options.UseFont = True
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        '
        'txtData2
        '
        Me.txtData2.EditValue = Nothing
        Me.txtData2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData2.Properties.Appearance.Options.UseFont = True
        '
        'chk1
        '
        Me.chk1.Location = New System.Drawing.Point(853, 150)
        Me.chk1.MenuManager = Me.RibbonControl1
        Me.chk1.Name = "chk1"
        Me.chk1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk1.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.chk1.Properties.Appearance.Options.UseFont = True
        Me.chk1.Properties.Appearance.Options.UseForeColor = True
        Me.chk1.Properties.Caption = "Sem período"
        Me.chk1.Size = New System.Drawing.Size(111, 19)
        Me.chk1.TabIndex = 14
        '
        'GridControl
        '
        Me.GridControl.DataSource = Me.ClientesCadastradosBindingSource
        Me.GridControl.Location = New System.Drawing.Point(146, 187)
        Me.GridControl.MainView = Me.GridView1
        Me.GridControl.MenuManager = Me.RibbonControl1
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(385, 213)
        Me.GridControl.TabIndex = 15
        Me.GridControl.TabStop = False
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ClientesCadastradosBindingSource
        '
        Me.ClientesCadastradosBindingSource.DataMember = "ClientesCadastrados"
        Me.ClientesCadastradosBindingSource.DataSource = Me.DsCliente1
        '
        'DsCliente1
        '
        Me.DsCliente1.DataSetName = "dsCliente"
        Me.DsCliente1.EnforceConstraints = False
        Me.DsCliente1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCliente, Me.colAniversário, Me.colEndereço, Me.colBairro, Me.colTelefone, Me.colEmail, Me.colDataCadastro, Me.colIDCliente})
        Me.GridView1.GridControl = Me.GridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'colCliente
        '
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 0
        Me.colCliente.Width = 200
        '
        'colAniversário
        '
        Me.colAniversário.AppearanceCell.Options.UseTextOptions = True
        Me.colAniversário.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAniversário.AppearanceHeader.Options.UseTextOptions = True
        Me.colAniversário.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAniversário.FieldName = "Aniversário"
        Me.colAniversário.Name = "colAniversário"
        Me.colAniversário.Visible = True
        Me.colAniversário.VisibleIndex = 5
        Me.colAniversário.Width = 100
        '
        'colEndereço
        '
        Me.colEndereço.FieldName = "Endereço"
        Me.colEndereço.Name = "colEndereço"
        Me.colEndereço.Visible = True
        Me.colEndereço.VisibleIndex = 1
        Me.colEndereço.Width = 242
        '
        'colBairro
        '
        Me.colBairro.FieldName = "Bairro"
        Me.colBairro.Name = "colBairro"
        Me.colBairro.Visible = True
        Me.colBairro.VisibleIndex = 2
        Me.colBairro.Width = 120
        '
        'colTelefone
        '
        Me.colTelefone.FieldName = "Telefone"
        Me.colTelefone.Name = "colTelefone"
        Me.colTelefone.Visible = True
        Me.colTelefone.VisibleIndex = 3
        Me.colTelefone.Width = 210
        '
        'colEmail
        '
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 4
        Me.colEmail.Width = 159
        '
        'colDataCadastro
        '
        Me.colDataCadastro.AppearanceCell.Options.UseTextOptions = True
        Me.colDataCadastro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataCadastro.AppearanceHeader.Options.UseTextOptions = True
        Me.colDataCadastro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataCadastro.FieldName = "Data de Cadastro"
        Me.colDataCadastro.Name = "colDataCadastro"
        Me.colDataCadastro.Visible = True
        Me.colDataCadastro.VisibleIndex = 6
        Me.colDataCadastro.Width = 100
        '
        'colIDCliente
        '
        Me.colIDCliente.FieldName = "IDCliente"
        Me.colIDCliente.Name = "colIDCliente"
        '
        'DsCliente
        '
        Me.DsCliente.DataSetName = "dsCliente"
        Me.DsCliente.EnforceConstraints = False
        Me.DsCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesCadastradosTableAdapter
        '
        Me.ClientesCadastradosTableAdapter.ClearBeforeFill = True
        '
        'btnExcel
        '
        Me.btnExcel.Enabled = False
        Me.btnExcel.ImageOptions.Image = CType(resources.GetObject("btnExcel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExcel.Location = New System.Drawing.Point(968, 148)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(115, 23)
        Me.btnExcel.TabIndex = 16
        Me.btnExcel.TabStop = False
        Me.btnExcel.Text = "Exportar p/ Excel"
        '
        'ClientesCadastrados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1334, 676)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.chk1)
        Me.Controls.Add(Me.GridControl)
        Me.IconOptions.ShowIcon = False
        Me.Name = "ClientesCadastrados"
        Me.Controls.SetChildIndex(Me.GridControl, 0)
        Me.Controls.SetChildIndex(Me.DocumentViewer1, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.txtData1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.txtData2, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.btnOk2, 0)
        Me.Controls.SetChildIndex(Me.chk1, 0)
        Me.Controls.SetChildIndex(Me.btnExcel, 0)
        CType(Me.btnOk2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentViewerRibbonController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesCadastradosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCliente1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chk1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents DsCliente As dsCliente
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsCliente1 As dsCliente
    Friend WithEvents ClientesCadastradosBindingSource As BindingSource
    Friend WithEvents ClientesCadastradosTableAdapter As dsClienteTableAdapters.ClientesCadastradosTableAdapter
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAniversário As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndereço As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBairro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataCadastro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
End Class
