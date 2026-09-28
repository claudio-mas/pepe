<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaxasCartão
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
        Me.DsGeral = New Pepe.dsGeral()
        Me.CartõesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CartõesTableAdapter = New Pepe.dsGeralTableAdapters.CartõesTableAdapter()
        Me.TableAdapterManager = New Pepe.dsGeralTableAdapters.TableAdapterManager()
        Me.CartõesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNcartao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPerc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPerc2 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DsGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartõesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartõesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsGeral
        '
        Me.DsGeral.DataSetName = "dsGeral"
        Me.DsGeral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CartõesBindingSource
        '
        Me.CartõesBindingSource.DataMember = "Cartões"
        Me.CartõesBindingSource.DataSource = Me.DsGeral
        '
        'CartõesTableAdapter
        '
        Me.CartõesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CartõesTableAdapter = Me.CartõesTableAdapter
        Me.TableAdapterManager.cboClientesTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CONSERTOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pepe.dsGeralTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vencto_CartãoTableAdapter = Nothing
        Me.TableAdapterManager.Vencto_ChequesTableAdapter = Nothing
        Me.TableAdapterManager.VendedorasTableAdapter = Nothing
        '
        'CartõesGridControl
        '
        Me.CartõesGridControl.DataSource = Me.CartõesBindingSource
        Me.CartõesGridControl.Location = New System.Drawing.Point(4, 7)
        Me.CartõesGridControl.MainView = Me.GridView1
        Me.CartõesGridControl.Name = "CartõesGridControl"
        Me.CartõesGridControl.Size = New System.Drawing.Size(444, 517)
        Me.CartõesGridControl.TabIndex = 1
        Me.CartõesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNcartao, Me.colPerc, Me.colPerc2})
        Me.GridView1.GridControl = Me.CartõesGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.NewItemRowText = "Clique aqui para adicionar"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colNcartao
        '
        Me.colNcartao.Caption = "Cartão"
        Me.colNcartao.FieldName = "Ncartao"
        Me.colNcartao.Name = "colNcartao"
        Me.colNcartao.Visible = True
        Me.colNcartao.VisibleIndex = 0
        Me.colNcartao.Width = 170
        '
        'colPerc
        '
        Me.colPerc.Caption = "% Adm. até 6x"
        Me.colPerc.FieldName = "Perc"
        Me.colPerc.Name = "colPerc"
        Me.colPerc.Visible = True
        Me.colPerc.VisibleIndex = 1
        Me.colPerc.Width = 101
        '
        'colPerc2
        '
        Me.colPerc2.Caption = "% Adm. acima de 6x"
        Me.colPerc2.FieldName = "Perc2"
        Me.colPerc2.Name = "colPerc2"
        Me.colPerc2.Visible = True
        Me.colPerc2.VisibleIndex = 2
        Me.colPerc2.Width = 133
        '
        'frmTaxasCartão
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 528)
        Me.Controls.Add(Me.CartõesGridControl)
        Me.Name = "frmTaxasCartão"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Taxas Adm. "
        Me.TopMost = True
        CType(Me.DsGeral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartõesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartõesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DsGeral As dsGeral
    Friend WithEvents CartõesBindingSource As BindingSource
    Friend WithEvents CartõesTableAdapter As dsGeralTableAdapters.CartõesTableAdapter
    Friend WithEvents TableAdapterManager As dsGeralTableAdapters.TableAdapterManager
    Friend WithEvents CartõesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNcartao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPerc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPerc2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
