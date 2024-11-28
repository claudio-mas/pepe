<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendaPeça
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.cboPeça = New DevExpress.XtraEditors.LookUpEdit()
        Me.VENDASDETBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCheques = New Pepe.dsCheques()
        Me.CboPeçasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CboPeçasTableAdapter = New Pepe.dsChequesTableAdapters.cboPeçasTableAdapter()
        Me.VENDAS_DETTableAdapter = New Pepe.dsChequesTableAdapters.VENDAS_DETTableAdapter()
        Me.txtValor = New DevExpress.XtraEditors.TextEdit()
        Me.txtCom = New DevExpress.XtraEditors.TextEdit()
        Me.TableAdapterManager2 = New Pepe.dsChequesTableAdapters.TableAdapterManager()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.cboPeça.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDASDETBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboPeçasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(81, 48)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(30, 17)
        Label2.TabIndex = 10
        Label2.Text = "Ref."
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(73, 77)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(38, 17)
        Label1.TabIndex = 11
        Label1.Text = "Valor"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(46, 105)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(65, 17)
        Label3.TabIndex = 12
        Label3.Text = "Comissão"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(61, 162)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'cboPeça
        '
        Me.cboPeça.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASDETBindingSource, "Peça", True))
        Me.cboPeça.Location = New System.Drawing.Point(115, 45)
        Me.cboPeça.Name = "cboPeça"
        Me.cboPeça.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeça.Properties.Appearance.Options.UseFont = True
        Me.cboPeça.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPeça.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDPeça", "ID Peça", 60, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modêlo", "Modêlo", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Comissão", "Comissão", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.cboPeça.Properties.DataSource = Me.CboPeçasBindingSource
        Me.cboPeça.Properties.DisplayMember = "Modêlo"
        Me.cboPeça.Properties.DropDownRows = 12
        Me.cboPeça.Properties.NullText = ""
        Me.cboPeça.Properties.ValueMember = "IDPeça"
        Me.cboPeça.Size = New System.Drawing.Size(108, 24)
        Me.cboPeça.TabIndex = 1
        '
        'VENDASDETBindingSource
        '
        Me.VENDASDETBindingSource.DataMember = "VENDAS DET"
        Me.VENDASDETBindingSource.DataSource = Me.DsCheques
        '
        'DsCheques
        '
        Me.DsCheques.DataSetName = "dsCheques"
        Me.DsCheques.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CboPeçasBindingSource
        '
        Me.CboPeçasBindingSource.DataMember = "cboPeças"
        Me.CboPeçasBindingSource.DataSource = Me.DsCheques
        '
        'CboPeçasTableAdapter
        '
        Me.CboPeçasTableAdapter.ClearBeforeFill = True
        '
        'VENDAS_DETTableAdapter
        '
        Me.VENDAS_DETTableAdapter.ClearBeforeFill = True
        '
        'txtValor
        '
        Me.txtValor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASDETBindingSource, "ValorVenda", True))
        Me.txtValor.Location = New System.Drawing.Point(115, 74)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Properties.Appearance.Options.UseFont = True
        Me.txtValor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValor.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValor.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtValor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValor.Properties.Mask.EditMask = "n2"
        Me.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValor.Size = New System.Drawing.Size(108, 24)
        Me.txtValor.TabIndex = 8
        '
        'txtCom
        '
        Me.txtCom.Location = New System.Drawing.Point(115, 102)
        Me.txtCom.Name = "txtCom"
        Me.txtCom.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCom.Properties.Appearance.Options.UseFont = True
        Me.txtCom.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCom.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCom.Properties.DisplayFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtCom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCom.Properties.EditFormat.FormatString = "{0:#,###0.00;-#,###0.00}"
        Me.txtCom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCom.Properties.Mask.EditMask = "n2"
        Me.txtCom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCom.Size = New System.Drawing.Size(108, 24)
        Me.txtCom.TabIndex = 9
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.CartõesTodosTableAdapter = Nothing
        Me.TableAdapterManager2.cboPeçasTableAdapter = Me.CboPeçasTableAdapter
        Me.TableAdapterManager2.ChequesTodosTableAdapter = Nothing
        Me.TableAdapterManager2.UpdateOrder = Pepe.dsChequesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager2.VENDAS_DETTableAdapter = Me.VENDAS_DETTableAdapter
        '
        'frmVendaPeça
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(269, 218)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtCom)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.cboPeça)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVendaPeça"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmVendaPeça"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.cboPeça.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDASDETBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboPeçasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents cboPeça As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DsCheques As Pepe.dsCheques
    Friend WithEvents CboPeçasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CboPeçasTableAdapter As Pepe.dsChequesTableAdapters.cboPeçasTableAdapter
    Friend WithEvents VENDASDETBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VENDAS_DETTableAdapter As Pepe.dsChequesTableAdapters.VENDAS_DETTableAdapter
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TableAdapterManager2 As Pepe.dsChequesTableAdapters.TableAdapterManager

End Class
