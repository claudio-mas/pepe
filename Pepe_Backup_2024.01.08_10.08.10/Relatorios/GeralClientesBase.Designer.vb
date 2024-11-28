<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeralClientesBase
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
        Me.txtMeses = New DevExpress.XtraEditors.TextEdit()
        CType(Me.btnOk2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentViewerRibbonController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMeses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk2
        '
        Me.btnOk2.Location = New System.Drawing.Point(836, 146)
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Appearance.Options.UseFont = True
        Me.lblTitulo.Appearance.Options.UseForeColor = True
        Me.lblTitulo.Appearance.Options.UseTextOptions = True
        Me.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblTitulo.Location = New System.Drawing.Point(464, 150)
        Me.lblTitulo.Size = New System.Drawing.Size(280, 19)
        Me.lblTitulo.Text = "Clientes que compraram nos últimos"
        '
        'txtData1
        '
        Me.txtData1.EditValue = Nothing
        Me.txtData1.Location = New System.Drawing.Point(0, 145)
        Me.txtData1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData1.Properties.Appearance.Options.UseFont = True
        Me.txtData1.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl1.Location = New System.Drawing.Point(785, 150)
        Me.LabelControl1.Size = New System.Drawing.Size(49, 19)
        Me.LabelControl1.Text = "meses"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(136, 145)
        Me.LabelControl2.Visible = False
        '
        'txtData2
        '
        Me.txtData2.EditValue = Nothing
        Me.txtData2.Location = New System.Drawing.Point(180, 143)
        Me.txtData2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData2.Properties.Appearance.Options.UseFont = True
        Me.txtData2.Visible = False
        '
        'txtMeses
        '
        Me.txtMeses.EditValue = ""
        Me.txtMeses.Location = New System.Drawing.Point(748, 148)
        Me.txtMeses.MenuManager = Me.RibbonControl1
        Me.txtMeses.Name = "txtMeses"
        Me.txtMeses.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMeses.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMeses.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtMeses.Properties.Mask.EditMask = "\d?\d?"
        Me.txtMeses.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtMeses.Properties.MaxLength = 3
        Me.txtMeses.Size = New System.Drawing.Size(33, 22)
        Me.txtMeses.TabIndex = 14
        '
        'GeralClientesBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1334, 676)
        Me.Controls.Add(Me.txtMeses)
        Me.IconOptions.ShowIcon = False
        Me.Name = "GeralClientesBase"
        Me.Controls.SetChildIndex(Me.DocumentViewer1, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.txtData1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.txtData2, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.btnOk2, 0)
        Me.Controls.SetChildIndex(Me.txtMeses, 0)
        CType(Me.btnOk2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentViewerRibbonController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMeses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMeses As DevExpress.XtraEditors.TextEdit
End Class
