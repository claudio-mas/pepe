<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVolta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVolta))
        Me.lbTexto = New DevExpress.XtraEditors.LabelControl()
        Me.nFicha = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNOk = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.nFicha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbTexto
        '
        Me.lbTexto.Appearance.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTexto.Appearance.Options.UseFont = True
        Me.lbTexto.Location = New System.Drawing.Point(12, 12)
        Me.lbTexto.Name = "lbTexto"
        Me.lbTexto.Size = New System.Drawing.Size(435, 20)
        Me.lbTexto.TabIndex = 0
        Me.lbTexto.Text = "A ficha nº será duplicada com o novo nº informado abaixo:"
        '
        'nFicha
        '
        Me.nFicha.EditValue = ""
        Me.nFicha.Location = New System.Drawing.Point(249, 60)
        Me.nFicha.Name = "nFicha"
        Me.nFicha.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nFicha.Properties.Appearance.Options.UseFont = True
        Me.nFicha.Properties.Appearance.Options.UseTextOptions = True
        Me.nFicha.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nFicha.Size = New System.Drawing.Size(79, 24)
        Me.nFicha.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(186, 63)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 18)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Ficha nº"
        '
        'btnOk
        '
        Me.btnOk.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Appearance.Options.UseFont = True
        Me.btnOk.ImageOptions.Image = CType(resources.GetObject("btnOk.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOk.Location = New System.Drawing.Point(141, 122)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(113, 45)
        Me.btnOk.TabIndex = 3
        Me.btnOk.TabStop = False
        Me.btnOk.Text = "Confirmar"
        '
        'btnNOk
        '
        Me.btnNOk.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNOk.Appearance.Options.UseFont = True
        Me.btnNOk.ImageOptions.Image = CType(resources.GetObject("btnNOk.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNOk.Location = New System.Drawing.Point(260, 122)
        Me.btnNOk.Name = "btnNOk"
        Me.btnNOk.Size = New System.Drawing.Size(113, 45)
        Me.btnNOk.TabIndex = 4
        Me.btnNOk.TabStop = False
        Me.btnNOk.Text = "Cancelar"
        '
        'frmVolta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 179)
        Me.Controls.Add(Me.btnNOk)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.nFicha)
        Me.Controls.Add(Me.lbTexto)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVolta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ESTOQUE"
        Me.TopMost = True
        CType(Me.nFicha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbTexto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nFicha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNOk As DevExpress.XtraEditors.SimpleButton
End Class
