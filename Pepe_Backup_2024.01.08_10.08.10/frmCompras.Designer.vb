<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DsCliente = New Pepe.dsCliente()
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasTableAdapter = New Pepe.dsClienteTableAdapters.ComprasTableAdapter()
        Me.TableAdapterManager = New Pepe.dsClienteTableAdapters.TableAdapterManager()
        Me.ComprasGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPeça = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMedidas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescrição = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DsCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsCliente
        '
        Me.DsCliente.DataSetName = "dsCliente"
        Me.DsCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.DataMember = "Compras"
        Me.ComprasBindingSource.DataSource = Me.DsCliente
        '
        'ComprasTableAdapter
        '
        Me.ComprasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CartõesTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Pepe.dsClienteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vencto_CartãoTableAdapter = Nothing
        '
        'ComprasGridControl
        '
        Me.ComprasGridControl.DataSource = Me.ComprasBindingSource
        Me.ComprasGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComprasGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ComprasGridControl.MainView = Me.GridView1
        Me.ComprasGridControl.Name = "ComprasGridControl"
        Me.ComprasGridControl.Size = New System.Drawing.Size(513, 341)
        Me.ComprasGridControl.TabIndex = 2
        Me.ComprasGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIDCliente, Me.colData, Me.colPeça, Me.colMedidas, Me.colDescrição})
        Me.GridView1.GridControl = Me.ComprasGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colData, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colIDCliente
        '
        Me.colIDCliente.FieldName = "ID Cliente"
        Me.colIDCliente.Name = "colIDCliente"
        '
        'colData
        '
        Me.colData.AppearanceCell.Options.UseTextOptions = True
        Me.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.AppearanceHeader.Options.UseTextOptions = True
        Me.colData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 0
        Me.colData.Width = 103
        '
        'colPeça
        '
        Me.colPeça.AppearanceCell.Options.UseTextOptions = True
        Me.colPeça.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPeça.AppearanceHeader.Options.UseTextOptions = True
        Me.colPeça.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPeça.Caption = "Ficha"
        Me.colPeça.FieldName = "Peça"
        Me.colPeça.Name = "colPeça"
        Me.colPeça.Visible = True
        Me.colPeça.VisibleIndex = 1
        Me.colPeça.Width = 120
        '
        'colMedidas
        '
        Me.colMedidas.AppearanceHeader.Options.UseTextOptions = True
        Me.colMedidas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMedidas.Caption = "Descrição"
        Me.colMedidas.FieldName = "Medidas"
        Me.colMedidas.Name = "colMedidas"
        Me.colMedidas.Visible = True
        Me.colMedidas.VisibleIndex = 2
        Me.colMedidas.Width = 266
        '
        'colDescrição
        '
        Me.colDescrição.FieldName = "Descrição"
        Me.colDescrição.Name = "colDescrição"
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 341)
        Me.Controls.Add(Me.ComprasGridControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMPRAS"
        Me.TopMost = True
        CType(Me.DsCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DsCliente As dsCliente
    Friend WithEvents ComprasBindingSource As BindingSource
    Friend WithEvents ComprasTableAdapter As dsClienteTableAdapters.ComprasTableAdapter
    Friend WithEvents TableAdapterManager As dsClienteTableAdapters.TableAdapterManager
    Friend WithEvents ComprasGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeça As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMedidas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescrição As DevExpress.XtraGrid.Columns.GridColumn
End Class
