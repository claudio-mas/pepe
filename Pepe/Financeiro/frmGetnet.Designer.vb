<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetnet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGetnet))
        Me.SpreadsheetControl = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SpreadsheetCommandBarButtonItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.SpreadsheetCommandBarButtonItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.btnImp = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.FileRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.FileRibbonPage()
        Me.CommonRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup()
        Me.InfoRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.SpreadsheetBarController1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController(Me.components)
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpreadsheetBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpreadsheetControl
        '
        Me.SpreadsheetControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpreadsheetControl.Location = New System.Drawing.Point(0, 144)
        Me.SpreadsheetControl.MenuManager = Me.RibbonControl1
        Me.SpreadsheetControl.Name = "SpreadsheetControl"
        Me.SpreadsheetControl.ReadOnly = True
        Me.SpreadsheetControl.Size = New System.Drawing.Size(1340, 550)
        Me.SpreadsheetControl.TabIndex = 0
        '
        'RibbonControl1
        '
        Me.RibbonControl1.AllowMinimizeRibbon = False
        Me.RibbonControl1.AutoHideEmptyItems = True
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.SpreadsheetCommandBarButtonItem1, Me.SpreadsheetCommandBarButtonItem2, Me.SpreadsheetCommandBarButtonItem3, Me.SpreadsheetCommandBarButtonItem4, Me.SpreadsheetCommandBarButtonItem5, Me.SpreadsheetCommandBarButtonItem6, Me.SpreadsheetCommandBarButtonItem7, Me.SpreadsheetCommandBarButtonItem8, Me.SpreadsheetCommandBarButtonItem9, Me.SpreadsheetCommandBarButtonItem10, Me.SpreadsheetCommandBarButtonItem11, Me.btnImp, Me.btnFechar})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 14
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.FileRibbonPage1})
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1340, 144)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'SpreadsheetCommandBarButtonItem1
        '
        Me.SpreadsheetCommandBarButtonItem1.CommandName = "FileNew"
        Me.SpreadsheetCommandBarButtonItem1.Id = 1
        Me.SpreadsheetCommandBarButtonItem1.Name = "SpreadsheetCommandBarButtonItem1"
        Me.SpreadsheetCommandBarButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
        '
        'SpreadsheetCommandBarButtonItem2
        '
        Me.SpreadsheetCommandBarButtonItem2.Caption = "Abrir planilha de recebimentos"
        Me.SpreadsheetCommandBarButtonItem2.CommandName = "FileOpen"
        Me.SpreadsheetCommandBarButtonItem2.Id = 2
        Me.SpreadsheetCommandBarButtonItem2.Name = "SpreadsheetCommandBarButtonItem2"
        '
        'SpreadsheetCommandBarButtonItem3
        '
        Me.SpreadsheetCommandBarButtonItem3.CommandName = "FileSave"
        Me.SpreadsheetCommandBarButtonItem3.Id = 3
        Me.SpreadsheetCommandBarButtonItem3.Name = "SpreadsheetCommandBarButtonItem3"
        Me.SpreadsheetCommandBarButtonItem3.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
        '
        'SpreadsheetCommandBarButtonItem4
        '
        Me.SpreadsheetCommandBarButtonItem4.CommandName = "FileSaveAs"
        Me.SpreadsheetCommandBarButtonItem4.Id = 4
        Me.SpreadsheetCommandBarButtonItem4.Name = "SpreadsheetCommandBarButtonItem4"
        Me.SpreadsheetCommandBarButtonItem4.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
        '
        'SpreadsheetCommandBarButtonItem5
        '
        Me.SpreadsheetCommandBarButtonItem5.CommandName = "FileQuickPrint"
        Me.SpreadsheetCommandBarButtonItem5.Id = 5
        Me.SpreadsheetCommandBarButtonItem5.Name = "SpreadsheetCommandBarButtonItem5"
        Me.SpreadsheetCommandBarButtonItem5.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
        '
        'SpreadsheetCommandBarButtonItem6
        '
        Me.SpreadsheetCommandBarButtonItem6.CommandName = "FilePrint"
        Me.SpreadsheetCommandBarButtonItem6.Id = 6
        Me.SpreadsheetCommandBarButtonItem6.Name = "SpreadsheetCommandBarButtonItem6"
        Me.SpreadsheetCommandBarButtonItem6.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
        '
        'SpreadsheetCommandBarButtonItem7
        '
        Me.SpreadsheetCommandBarButtonItem7.CommandName = "FilePrintPreview"
        Me.SpreadsheetCommandBarButtonItem7.Id = 7
        Me.SpreadsheetCommandBarButtonItem7.Name = "SpreadsheetCommandBarButtonItem7"
        Me.SpreadsheetCommandBarButtonItem7.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
        '
        'SpreadsheetCommandBarButtonItem8
        '
        Me.SpreadsheetCommandBarButtonItem8.CommandName = "FileUndo"
        Me.SpreadsheetCommandBarButtonItem8.Id = 8
        Me.SpreadsheetCommandBarButtonItem8.Name = "SpreadsheetCommandBarButtonItem8"
        Me.SpreadsheetCommandBarButtonItem8.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
        '
        'SpreadsheetCommandBarButtonItem9
        '
        Me.SpreadsheetCommandBarButtonItem9.CommandName = "FileRedo"
        Me.SpreadsheetCommandBarButtonItem9.Id = 9
        Me.SpreadsheetCommandBarButtonItem9.Name = "SpreadsheetCommandBarButtonItem9"
        Me.SpreadsheetCommandBarButtonItem9.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
        '
        'SpreadsheetCommandBarButtonItem10
        '
        Me.SpreadsheetCommandBarButtonItem10.CommandName = "FileEncrypt"
        Me.SpreadsheetCommandBarButtonItem10.Id = 10
        Me.SpreadsheetCommandBarButtonItem10.Name = "SpreadsheetCommandBarButtonItem10"
        '
        'SpreadsheetCommandBarButtonItem11
        '
        Me.SpreadsheetCommandBarButtonItem11.CommandName = "FileShowDocumentProperties"
        Me.SpreadsheetCommandBarButtonItem11.Id = 11
        Me.SpreadsheetCommandBarButtonItem11.Name = "SpreadsheetCommandBarButtonItem11"
        '
        'btnImp
        '
        Me.btnImp.Caption = "Importar dados p/ sistema"
        Me.btnImp.Id = 12
        Me.btnImp.ImageOptions.Image = CType(resources.GetObject("btnImp.ImageOptions.Image"), System.Drawing.Image)
        Me.btnImp.ImageOptions.LargeImage = CType(resources.GetObject("btnImp.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnImp.Name = "btnImp"
        '
        'btnFechar
        '
        Me.btnFechar.Caption = "Fechar"
        Me.btnFechar.Id = 13
        Me.btnFechar.ImageOptions.Image = CType(resources.GetObject("btnFechar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFechar.ImageOptions.LargeImage = CType(resources.GetObject("btnFechar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnFechar.Name = "btnFechar"
        '
        'FileRibbonPage1
        '
        Me.FileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.CommonRibbonPageGroup1, Me.InfoRibbonPageGroup1, Me.RibbonPageGroup1})
        Me.FileRibbonPage1.Name = "FileRibbonPage1"
        Me.FileRibbonPage1.Text = "Arquivo"
        '
        'CommonRibbonPageGroup1
        '
        Me.CommonRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem1)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem3)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem4)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem5)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem6)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem7)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem8)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem9)
        Me.CommonRibbonPageGroup1.Name = "CommonRibbonPageGroup1"
        Me.CommonRibbonPageGroup1.Visible = False
        '
        'InfoRibbonPageGroup1
        '
        Me.InfoRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.InfoRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem10)
        Me.InfoRibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem11)
        Me.InfoRibbonPageGroup1.Name = "InfoRibbonPageGroup1"
        Me.InfoRibbonPageGroup1.Visible = False
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.SpreadsheetCommandBarButtonItem2)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnImp)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnFechar, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'SpreadsheetBarController1
        '
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem1)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem2)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem3)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem4)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem5)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem6)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem7)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem8)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem9)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem10)
        Me.SpreadsheetBarController1.BarItems.Add(Me.SpreadsheetCommandBarButtonItem11)
        Me.SpreadsheetBarController1.Control = Me.SpreadsheetControl
        '
        'frmGetnet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 694)
        Me.ControlBox = False
        Me.Controls.Add(Me.SpreadsheetControl)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "frmGetnet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Getnet"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpreadsheetBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SpreadsheetControl As DevExpress.XtraSpreadsheet.SpreadsheetControl
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents SpreadsheetCommandBarButtonItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem7 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents SpreadsheetCommandBarButtonItem11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents FileRibbonPage1 As DevExpress.XtraSpreadsheet.UI.FileRibbonPage
    Friend WithEvents CommonRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup
    Friend WithEvents InfoRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup
    Friend WithEvents SpreadsheetBarController1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController
    Friend WithEvents btnImp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
End Class
