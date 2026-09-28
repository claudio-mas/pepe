<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AForm1
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

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim ExcluirLabel As System.Windows.Forms.Label
        Dim VendaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AForm1))
        Me.DsInconsist = New Pepe.dsInconsist()
        Me.Inconsist4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inconsist4TableAdapter = New Pepe.dsInconsistTableAdapters.Inconsist4TableAdapter()
        Me.TableAdapterManager = New Pepe.dsInconsistTableAdapters.TableAdapterManager()
        Me.Inconsist4BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Inconsist4BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ExcluirCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.VendaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.XtraUserControl = New DevExpress.XtraEditors.XtraUserControl()
        Me.DocumentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.NativeMdiView1 = New DevExpress.XtraBars.Docking2010.Views.NativeMdi.NativeMdiView(Me.components)
        Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.NativeMdi.Document(Me.components)
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        IdLabel = New System.Windows.Forms.Label()
        ExcluirLabel = New System.Windows.Forms.Label()
        VendaLabel = New System.Windows.Forms.Label()
        CType(Me.DsInconsist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inconsist4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inconsist4BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Inconsist4BindingNavigator.SuspendLayout()
        CType(Me.IdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExcluirCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NativeMdiView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(381, 46)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'ExcluirLabel
        '
        ExcluirLabel.AutoSize = True
        ExcluirLabel.Location = New System.Drawing.Point(397, 151)
        ExcluirLabel.Name = "ExcluirLabel"
        ExcluirLabel.Size = New System.Drawing.Size(41, 13)
        ExcluirLabel.TabIndex = 3
        ExcluirLabel.Text = "Excluir:"
        '
        'VendaLabel
        '
        VendaLabel.AutoSize = True
        VendaLabel.Location = New System.Drawing.Point(328, 95)
        VendaLabel.Name = "VendaLabel"
        VendaLabel.Size = New System.Drawing.Size(41, 13)
        VendaLabel.TabIndex = 5
        VendaLabel.Text = "Venda:"
        '
        'DsInconsist
        '
        Me.DsInconsist.DataSetName = "dsInconsist"
        Me.DsInconsist.EnforceConstraints = False
        Me.DsInconsist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Inconsist4BindingSource
        '
        Me.Inconsist4BindingSource.DataMember = "Inconsist4"
        Me.Inconsist4BindingSource.DataSource = Me.DsInconsist
        '
        'Inconsist4TableAdapter
        '
        Me.Inconsist4TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Inconsist1TableAdapter = Nothing
        Me.TableAdapterManager.Inconsist4TableAdapter = Me.Inconsist4TableAdapter
        Me.TableAdapterManager.UpdateOrder = Pepe.dsInconsistTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Inconsist4BindingNavigator
        '
        Me.Inconsist4BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Inconsist4BindingNavigator.BindingSource = Me.Inconsist4BindingSource
        Me.Inconsist4BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Inconsist4BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Inconsist4BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Inconsist4BindingNavigatorSaveItem})
        Me.Inconsist4BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Inconsist4BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Inconsist4BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Inconsist4BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Inconsist4BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Inconsist4BindingNavigator.Name = "Inconsist4BindingNavigator"
        Me.Inconsist4BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Inconsist4BindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Inconsist4BindingNavigator.TabIndex = 0
        Me.Inconsist4BindingNavigator.Text = "BindingNavigator1"
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
        'Inconsist4BindingNavigatorSaveItem
        '
        Me.Inconsist4BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Inconsist4BindingNavigatorSaveItem.Image = CType(resources.GetObject("Inconsist4BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Inconsist4BindingNavigatorSaveItem.Name = "Inconsist4BindingNavigatorSaveItem"
        Me.Inconsist4BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Inconsist4BindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'IdSpinEdit
        '
        Me.IdSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Inconsist4BindingSource, "Id", True))
        Me.IdSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IdSpinEdit.Location = New System.Drawing.Point(406, 43)
        Me.IdSpinEdit.Name = "IdSpinEdit"
        Me.IdSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.IdSpinEdit.TabIndex = 2
        '
        'ExcluirCheckEdit
        '
        Me.ExcluirCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Inconsist4BindingSource, "Excluir", True))
        Me.ExcluirCheckEdit.Location = New System.Drawing.Point(417, 227)
        Me.ExcluirCheckEdit.Name = "ExcluirCheckEdit"
        Me.ExcluirCheckEdit.Properties.Caption = "CheckEdit1"
        Me.ExcluirCheckEdit.Size = New System.Drawing.Size(75, 20)
        Me.ExcluirCheckEdit.TabIndex = 4
        '
        'VendaTextEdit
        '
        Me.VendaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Inconsist4BindingSource, "Venda", True))
        Me.VendaTextEdit.Location = New System.Drawing.Point(375, 92)
        Me.VendaTextEdit.Name = "VendaTextEdit"
        Me.VendaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.VendaTextEdit.TabIndex = 6
        '
        'XtraUserControl
        '
        Me.XtraUserControl.Location = New System.Drawing.Point(4, 344)
        Me.XtraUserControl.Name = "XtraUserControl"
        Me.XtraUserControl.Size = New System.Drawing.Size(141, 69)
        Me.XtraUserControl.TabIndex = 7
        '
        'DocumentManager
        '
        Me.DocumentManager.ContainerControl = Me.XtraUserControl
        Me.DocumentManager.View = Me.NativeMdiView1
        Me.DocumentManager.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.NativeMdiView1})
        '
        'NativeMdiView1
        '
        Me.NativeMdiView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.Document1})
        '
        'Document1
        '
        Me.Document1.Caption = "document1"
        Me.Document1.ControlName = "document1"
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me.XtraUserControl
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
        Me.DockPanel1.FloatSize = New System.Drawing.Size(571, 359)
        Me.DockPanel1.ID = New System.Guid("ddc070b3-6da8-473a-90e4-c28598ece3fc")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 162)
        Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.SavedIndex = 0
        Me.DockPanel1.Size = New System.Drawing.Size(571, 359)
        Me.DockPanel1.Text = "DockPanel1"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(563, 330)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'AForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExcluirCheckEdit)
        Me.Controls.Add(Me.XtraUserControl)
        Me.Controls.Add(VendaLabel)
        Me.Controls.Add(Me.VendaTextEdit)
        Me.Controls.Add(ExcluirLabel)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdSpinEdit)
        Me.Controls.Add(Me.Inconsist4BindingNavigator)
        Me.Name = "AForm1"
        Me.Text = "AForm1"
        CType(Me.DsInconsist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inconsist4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inconsist4BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Inconsist4BindingNavigator.ResumeLayout(False)
        Me.Inconsist4BindingNavigator.PerformLayout()
        CType(Me.IdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExcluirCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NativeMdiView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Document1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsInconsist As dsInconsist
    Friend WithEvents Inconsist4BindingSource As BindingSource
    Friend WithEvents Inconsist4TableAdapter As dsInconsistTableAdapters.Inconsist4TableAdapter
    Friend WithEvents TableAdapterManager As dsInconsistTableAdapters.TableAdapterManager
    Friend WithEvents Inconsist4BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Inconsist4BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ExcluirCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents VendaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraUserControl As DevExpress.XtraEditors.XtraUserControl
    Friend WithEvents DocumentManager As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents NativeMdiView1 As DevExpress.XtraBars.Docking2010.Views.NativeMdi.NativeMdiView
    Friend WithEvents Document1 As DevExpress.XtraBars.Docking2010.Views.NativeMdi.Document
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
End Class
