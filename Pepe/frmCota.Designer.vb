<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCota
    Inherits DevExpress.XtraEditors.XtraForm

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

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.txtData = New DevExpress.XtraEditors.TextEdit()
        Me.txtDolar = New DevExpress.XtraEditors.TextEdit()
        Me.txtOuro = New DevExpress.XtraEditors.TextEdit()
        Me.txtPrata = New DevExpress.XtraEditors.TextEdit()
        Me.grdCotacoes = New DevExpress.XtraGrid.GridControl()
        Me.bsCotacao = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvCotacoes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValDolar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValOuro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValPrata = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataCot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExcluir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riBtnExcluir = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txtData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDolar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOuro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrata.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCotacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCotacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCotacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riBtnExcluir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(124, 64)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(52, 13)
        Label2.TabIndex = 35
        Label2.Text = "Dólar"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Location = New System.Drawing.Point(124, 95)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(52, 13)
        Label1.TabIndex = 37
        Label1.Text = "Ouro"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(110, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Prata 925"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(124, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Data"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(104, 391)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.TabStop = False
        Me.Cancel_Button.Text = "Fechar"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(304, 120)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.TabStop = False
        Me.OK_Button.Text = "Salvar"
        '
        'txtData
        '
        Me.txtData.EditValue = New Date(2026, 7, 29, 0, 0, 0, 0)
        Me.txtData.Location = New System.Drawing.Point(182, 30)
        Me.txtData.Name = "txtData"
        Me.txtData.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.Properties.Appearance.Options.UseFont = True
        Me.txtData.Properties.Appearance.Options.UseTextOptions = True
        Me.txtData.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtData.Properties.AutoHeight = False
        Me.txtData.Properties.BeepOnError = True
        Me.txtData.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtData.Properties.DisplayFormat.FormatString = "d"
        Me.txtData.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtData.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtData.Properties.MaskSettings.Set("mask", "d")
        Me.txtData.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.DateTimeMaskManager))
        Me.txtData.Properties.UseMaskAsDisplayFormat = True
        Me.txtData.Size = New System.Drawing.Size(95, 22)
        Me.txtData.TabIndex = 42
        '
        'txtDolar
        '
        Me.txtDolar.EditValue = ""
        Me.txtDolar.Location = New System.Drawing.Point(182, 60)
        Me.txtDolar.Name = "txtDolar"
        Me.txtDolar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDolar.Properties.Appearance.Options.UseFont = True
        Me.txtDolar.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDolar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDolar.Properties.AutoHeight = False
        Me.txtDolar.Properties.BeepOnError = True
        Me.txtDolar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDolar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDolar.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtDolar.Properties.MaskSettings.Set("mask", "n")
        Me.txtDolar.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDolar.Properties.MaskSettings.Set("autoHideDecimalSeparator", Nothing)
        Me.txtDolar.Properties.UseMaskAsDisplayFormat = True
        Me.txtDolar.Size = New System.Drawing.Size(95, 22)
        Me.txtDolar.TabIndex = 0
        '
        'txtOuro
        '
        Me.txtOuro.EditValue = ""
        Me.txtOuro.Location = New System.Drawing.Point(182, 90)
        Me.txtOuro.Name = "txtOuro"
        Me.txtOuro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOuro.Properties.Appearance.Options.UseFont = True
        Me.txtOuro.Properties.Appearance.Options.UseTextOptions = True
        Me.txtOuro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtOuro.Properties.AutoHeight = False
        Me.txtOuro.Properties.BeepOnError = True
        Me.txtOuro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtOuro.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOuro.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtOuro.Properties.MaskSettings.Set("mask", "n")
        Me.txtOuro.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtOuro.Properties.MaskSettings.Set("autoHideDecimalSeparator", Nothing)
        Me.txtOuro.Properties.UseMaskAsDisplayFormat = True
        Me.txtOuro.Size = New System.Drawing.Size(95, 22)
        Me.txtOuro.TabIndex = 36
        '
        'txtPrata
        '
        Me.txtPrata.EditValue = ""
        Me.txtPrata.Location = New System.Drawing.Point(182, 120)
        Me.txtPrata.Name = "txtPrata"
        Me.txtPrata.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrata.Properties.Appearance.Options.UseFont = True
        Me.txtPrata.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrata.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPrata.Properties.AutoHeight = False
        Me.txtPrata.Properties.BeepOnError = True
        Me.txtPrata.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtPrata.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrata.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtPrata.Properties.MaskSettings.Set("mask", "n")
        Me.txtPrata.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtPrata.Properties.MaskSettings.Set("autoHideDecimalSeparator", Nothing)
        Me.txtPrata.Properties.UseMaskAsDisplayFormat = True
        Me.txtPrata.Size = New System.Drawing.Size(95, 22)
        Me.txtPrata.TabIndex = 38
        '
        'grdCotacoes
        '
        Me.grdCotacoes.DataSource = Me.bsCotacao
        Me.grdCotacoes.Location = New System.Drawing.Point(12, 169)
        Me.grdCotacoes.MainView = Me.gvCotacoes
        Me.grdCotacoes.Name = "grdCotacoes"
        Me.grdCotacoes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riBtnExcluir})
        Me.grdCotacoes.Size = New System.Drawing.Size(411, 210)
        Me.grdCotacoes.TabIndex = 40
        Me.grdCotacoes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCotacoes})
        '
        'gvCotacoes
        '
        Me.gvCotacoes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colValDolar, Me.colValOuro, Me.colValPrata, Me.colDataCot, Me.colExcluir})
        Me.gvCotacoes.GridControl = Me.grdCotacoes
        Me.gvCotacoes.Name = "gvCotacoes"
        Me.gvCotacoes.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvCotacoes.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvCotacoes.OptionsCustomization.AllowGroup = False
        Me.gvCotacoes.OptionsView.ShowGroupPanel = False
        '
        'colId
        '
        Me.colId.Caption = "Id"
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.AllowEdit = False
        Me.colId.Width = 40
        '
        'colValDolar
        '
        Me.colValDolar.Caption = "Dólar"
        Me.colValDolar.DisplayFormat.FormatString = "n2"
        Me.colValDolar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValDolar.FieldName = "ValDolar"
        Me.colValDolar.Name = "colValDolar"
        Me.colValDolar.Visible = True
        Me.colValDolar.VisibleIndex = 1
        Me.colValDolar.Width = 90
        '
        'colValOuro
        '
        Me.colValOuro.Caption = "Ouro"
        Me.colValOuro.DisplayFormat.FormatString = "n2"
        Me.colValOuro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValOuro.FieldName = "ValOuro"
        Me.colValOuro.Name = "colValOuro"
        Me.colValOuro.Visible = True
        Me.colValOuro.VisibleIndex = 2
        Me.colValOuro.Width = 90
        '
        'colValPrata
        '
        Me.colValPrata.Caption = "Prata 925"
        Me.colValPrata.DisplayFormat.FormatString = "n2"
        Me.colValPrata.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValPrata.FieldName = "ValPrata"
        Me.colValPrata.Name = "colValPrata"
        Me.colValPrata.Visible = True
        Me.colValPrata.VisibleIndex = 3
        Me.colValPrata.Width = 90
        '
        'colDataCot
        '
        Me.colDataCot.AppearanceCell.Options.UseTextOptions = True
        Me.colDataCot.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataCot.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colDataCot.Caption = "Data"
        Me.colDataCot.DisplayFormat.FormatString = "d"
        Me.colDataCot.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDataCot.FieldName = "DataCot"
        Me.colDataCot.Name = "colDataCot"
        Me.colDataCot.Visible = True
        Me.colDataCot.VisibleIndex = 0
        Me.colDataCot.Width = 95
        '
        'colExcluir
        '
        Me.colExcluir.Caption = " "
        Me.colExcluir.ColumnEdit = Me.riBtnExcluir
        Me.colExcluir.FieldName = "Excluir"
        Me.colExcluir.Name = "colExcluir"
        Me.colExcluir.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.colExcluir.Visible = True
        Me.colExcluir.VisibleIndex = 4
        Me.colExcluir.Width = 32
        '
        'riBtnExcluir
        '
        Me.riBtnExcluir.AutoHeight = False
        Me.riBtnExcluir.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.riBtnExcluir.Name = "riBtnExcluir"
        Me.riBtnExcluir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'frmCota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 432)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.grdCotacoes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrata)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtOuro)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtDolar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "High Contrast Classic"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCota"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "COTAÇÃO"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.txtData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDolar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOuro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrata.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCotacoes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCotacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCotacoes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riBtnExcluir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents txtData As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDolar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOuro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPrata As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grdCotacoes As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCotacoes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bsCotacao As System.Windows.Forms.BindingSource
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValDolar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValOuro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValPrata As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataCot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExcluir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riBtnExcluir As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
