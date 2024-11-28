<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim VendaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DsPrincipal = New Pepe.dsPrincipal()
        Me.VENDASBindingSource = New System.Windows.Forms.BindingSource()
        Me.VENDASTableAdapter = New Pepe.dsPrincipalTableAdapters.VENDASTableAdapter()
        Me.TableAdapterManager = New Pepe.dsPrincipalTableAdapters.TableAdapterManager()
        Me.VENDASBindingNavigator = New System.Windows.Forms.BindingNavigator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VENDASBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.IdVToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.IdVToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.VendaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendasDetBindingSource = New System.Windows.Forms.BindingSource()
        Me.VendasDetTableAdapter = New Pepe.dsPrincipalTableAdapters.VendasDetTableAdapter()
        Me.FillToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.IdVToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.IdVToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.VendasDetGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPeça = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValorVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComissão = New DevExpress.XtraGrid.Columns.GridColumn()
        VendaLabel = New System.Windows.Forms.Label()
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDASBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VENDASBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.VendaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasDetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillToolStrip1.SuspendLayout()
        CType(Me.VendasDetGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VendaLabel
        '
        VendaLabel.AutoSize = True
        VendaLabel.Location = New System.Drawing.Point(454, 110)
        VendaLabel.Name = "VendaLabel"
        VendaLabel.Size = New System.Drawing.Size(41, 13)
        VendaLabel.TabIndex = 2
        VendaLabel.Text = "Venda:"
        '
        'DsPrincipal
        '
        Me.DsPrincipal.DataSetName = "dsPrincipal"
        Me.DsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VENDASBindingSource
        '
        Me.VENDASBindingSource.DataMember = "VENDAS"
        Me.VENDASBindingSource.DataSource = Me.DsPrincipal
        '
        'VENDASTableAdapter
        '
        Me.VENDASTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._1TabPeçasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cboVendedorasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pepe.dsPrincipalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vencto_CartãoTableAdapter = Nothing
        Me.TableAdapterManager.Vencto_ChequesTableAdapter = Nothing
        Me.TableAdapterManager.VENDAS_DETTableAdapter = Nothing
        Me.TableAdapterManager.VendasDetTableAdapter = Me.VendasDetTableAdapter
        Me.TableAdapterManager.VENDASTableAdapter = Me.VENDASTableAdapter
        '
        'VENDASBindingNavigator
        '
        Me.VENDASBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VENDASBindingNavigator.BindingSource = Me.VENDASBindingSource
        Me.VENDASBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VENDASBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VENDASBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VENDASBindingNavigatorSaveItem})
        Me.VENDASBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VENDASBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VENDASBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VENDASBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VENDASBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VENDASBindingNavigator.Name = "VENDASBindingNavigator"
        Me.VENDASBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VENDASBindingNavigator.Size = New System.Drawing.Size(1026, 25)
        Me.VENDASBindingNavigator.TabIndex = 0
        Me.VENDASBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'VENDASBindingNavigatorSaveItem
        '
        Me.VENDASBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VENDASBindingNavigatorSaveItem.Image = CType(resources.GetObject("VENDASBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VENDASBindingNavigatorSaveItem.Name = "VENDASBindingNavigatorSaveItem"
        Me.VENDASBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VENDASBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdVToolStripLabel, Me.IdVToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(1026, 25)
        Me.FillToolStrip.TabIndex = 1
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'IdVToolStripLabel
        '
        Me.IdVToolStripLabel.Name = "IdVToolStripLabel"
        Me.IdVToolStripLabel.Size = New System.Drawing.Size(27, 22)
        Me.IdVToolStripLabel.Text = "IdV:"
        '
        'IdVToolStripTextBox
        '
        Me.IdVToolStripTextBox.Name = "IdVToolStripTextBox"
        Me.IdVToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 22)
        Me.FillToolStripButton.Text = "Fill"
        '
        'VendaTextEdit
        '
        Me.VendaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.VENDASBindingSource, "Venda", True))
        Me.VendaTextEdit.Location = New System.Drawing.Point(501, 107)
        Me.VendaTextEdit.Name = "VendaTextEdit"
        Me.VendaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.VendaTextEdit.TabIndex = 3
        '
        'VendasDetBindingSource
        '
        Me.VendasDetBindingSource.DataMember = "FK_VENDAS_VendasDet"
        Me.VendasDetBindingSource.DataSource = Me.VENDASBindingSource
        '
        'VendasDetTableAdapter
        '
        Me.VendasDetTableAdapter.ClearBeforeFill = True
        '
        'FillToolStrip1
        '
        Me.FillToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdVToolStripLabel1, Me.IdVToolStripTextBox1, Me.FillToolStripButton1})
        Me.FillToolStrip1.Location = New System.Drawing.Point(0, 50)
        Me.FillToolStrip1.Name = "FillToolStrip1"
        Me.FillToolStrip1.Size = New System.Drawing.Size(1026, 25)
        Me.FillToolStrip1.TabIndex = 4
        Me.FillToolStrip1.Text = "FillToolStrip1"
        '
        'IdVToolStripLabel1
        '
        Me.IdVToolStripLabel1.Name = "IdVToolStripLabel1"
        Me.IdVToolStripLabel1.Size = New System.Drawing.Size(27, 22)
        Me.IdVToolStripLabel1.Text = "IdV:"
        '
        'IdVToolStripTextBox1
        '
        Me.IdVToolStripTextBox1.Name = "IdVToolStripTextBox1"
        Me.IdVToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'FillToolStripButton1
        '
        Me.FillToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton1.Name = "FillToolStripButton1"
        Me.FillToolStripButton1.Size = New System.Drawing.Size(26, 19)
        Me.FillToolStripButton1.Text = "Fill"
        '
        'VendasDetGridControl
        '
        Me.VendasDetGridControl.DataSource = Me.VendasDetBindingSource
        Me.VendasDetGridControl.Location = New System.Drawing.Point(447, 232)
        Me.VendasDetGridControl.MainView = Me.GridView1
        Me.VendasDetGridControl.Name = "VendasDetGridControl"
        Me.VendasDetGridControl.Size = New System.Drawing.Size(300, 220)
        Me.VendasDetGridControl.TabIndex = 5
        Me.VendasDetGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colVenda, Me.colPeça, Me.colValorVenda, Me.colComissão})
        Me.GridView1.GridControl = Me.VendasDetGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        '
        'colVenda
        '
        Me.colVenda.FieldName = "Venda"
        Me.colVenda.Name = "colVenda"
        Me.colVenda.Visible = True
        Me.colVenda.VisibleIndex = 1
        '
        'colPeça
        '
        Me.colPeça.FieldName = "Peça"
        Me.colPeça.Name = "colPeça"
        Me.colPeça.Visible = True
        Me.colPeça.VisibleIndex = 2
        '
        'colValorVenda
        '
        Me.colValorVenda.FieldName = "ValorVenda"
        Me.colValorVenda.Name = "colValorVenda"
        Me.colValorVenda.Visible = True
        Me.colValorVenda.VisibleIndex = 3
        '
        'colComissão
        '
        Me.colComissão.FieldName = "Comissão"
        Me.colComissão.Name = "colComissão"
        Me.colComissão.Visible = True
        Me.colComissão.VisibleIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 511)
        Me.Controls.Add(Me.VendasDetGridControl)
        Me.Controls.Add(Me.FillToolStrip1)
        Me.Controls.Add(VendaLabel)
        Me.Controls.Add(Me.VendaTextEdit)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.VENDASBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DsPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDASBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VENDASBindingNavigator.ResumeLayout(False)
        Me.VENDASBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.VendaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasDetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillToolStrip1.ResumeLayout(False)
        Me.FillToolStrip1.PerformLayout()
        CType(Me.VendasDetGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsPrincipal As Pepe.dsPrincipal
    Friend WithEvents VENDASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VENDASTableAdapter As Pepe.dsPrincipalTableAdapters.VENDASTableAdapter
    Friend WithEvents TableAdapterManager As Pepe.dsPrincipalTableAdapters.TableAdapterManager
    Friend WithEvents VENDASBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VENDASBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents IdVToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents IdVToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents VendaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendasDetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VendasDetTableAdapter As Pepe.dsPrincipalTableAdapters.VendasDetTableAdapter
    Friend WithEvents FillToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents IdVToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents IdVToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents VendasDetGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeça As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComissão As DevExpress.XtraGrid.Columns.GridColumn
End Class
