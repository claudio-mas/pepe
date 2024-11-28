<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPastaFotos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPastaFotos))
        Me.ProgBar = New System.Windows.Forms.ProgressBar()
        Me.txtPasta = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnTeste = New System.Windows.Forms.Button()
        Me.txtArqs = New System.Windows.Forms.TextBox()
        Me.btnPDFs = New System.Windows.Forms.Button()
        Me.btnPasta = New System.Windows.Forms.Button()
        Me.RadioGroup = New DevExpress.XtraEditors.RadioGroup()
        CType(Me.RadioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgBar
        '
        Me.ProgBar.Location = New System.Drawing.Point(195, 141)
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.Size = New System.Drawing.Size(377, 23)
        Me.ProgBar.TabIndex = 31
        Me.ProgBar.Visible = False
        '
        'txtPasta
        '
        Me.txtPasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasta.Location = New System.Drawing.Point(195, 84)
        Me.txtPasta.Multiline = True
        Me.txtPasta.Name = "txtPasta"
        Me.txtPasta.Size = New System.Drawing.Size(377, 54)
        Me.txtPasta.TabIndex = 28
        '
        'btnTeste
        '
        Me.btnTeste.Location = New System.Drawing.Point(480, 22)
        Me.btnTeste.Name = "btnTeste"
        Me.btnTeste.Size = New System.Drawing.Size(75, 23)
        Me.btnTeste.TabIndex = 32
        Me.btnTeste.Text = "Button1"
        Me.btnTeste.UseVisualStyleBackColor = True
        Me.btnTeste.Visible = False
        '
        'txtArqs
        '
        Me.txtArqs.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtArqs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtArqs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArqs.ForeColor = System.Drawing.Color.DarkRed
        Me.txtArqs.Location = New System.Drawing.Point(12, 170)
        Me.txtArqs.Name = "txtArqs"
        Me.txtArqs.Size = New System.Drawing.Size(588, 14)
        Me.txtArqs.TabIndex = 33
        Me.txtArqs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPDFs
        '
        Me.btnPDFs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPDFs.Image = CType(resources.GetObject("btnPDFs.Image"), System.Drawing.Image)
        Me.btnPDFs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPDFs.Location = New System.Drawing.Point(41, 135)
        Me.btnPDFs.Name = "btnPDFs"
        Me.btnPDFs.Size = New System.Drawing.Size(148, 34)
        Me.btnPDFs.TabIndex = 30
        Me.btnPDFs.Text = "Importar arquivos"
        Me.btnPDFs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPDFs.UseVisualStyleBackColor = True
        Me.btnPDFs.Visible = False
        '
        'btnPasta
        '
        Me.btnPasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPasta.Image = CType(resources.GetObject("btnPasta.Image"), System.Drawing.Image)
        Me.btnPasta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPasta.Location = New System.Drawing.Point(41, 84)
        Me.btnPasta.Name = "btnPasta"
        Me.btnPasta.Size = New System.Drawing.Size(148, 54)
        Me.btnPasta.TabIndex = 29
        Me.btnPasta.Text = "Selecionar pasta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de fotos das peças"
        Me.btnPasta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPasta.UseVisualStyleBackColor = True
        '
        'RadioGroup
        '
        Me.RadioGroup.EditValue = "jpg"
        Me.RadioGroup.Location = New System.Drawing.Point(246, 206)
        Me.RadioGroup.Name = "RadioGroup"
        Me.RadioGroup.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioGroup.Properties.Appearance.Options.UseFont = True
        Me.RadioGroup.Properties.Columns = 2
        Me.RadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("jpg", "Jpg"), New DevExpress.XtraEditors.Controls.RadioGroupItem("bmp", "BMP")})
        Me.RadioGroup.Size = New System.Drawing.Size(120, 31)
        Me.RadioGroup.TabIndex = 34
        Me.RadioGroup.Visible = False
        '
        'frmPastaFotos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(612, 258)
        Me.Controls.Add(Me.RadioGroup)
        Me.Controls.Add(Me.txtArqs)
        Me.Controls.Add(Me.btnTeste)
        Me.Controls.Add(Me.ProgBar)
        Me.Controls.Add(Me.btnPDFs)
        Me.Controls.Add(Me.btnPasta)
        Me.Controls.Add(Me.txtPasta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPastaFotos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurações"
        Me.TopMost = True
        CType(Me.RadioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgBar As System.Windows.Forms.ProgressBar
    Friend WithEvents btnPDFs As System.Windows.Forms.Button
    Friend WithEvents btnPasta As System.Windows.Forms.Button
    Friend WithEvents txtPasta As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnTeste As System.Windows.Forms.Button
    Friend WithEvents txtArqs As System.Windows.Forms.TextBox
    Friend WithEvents RadioGroup As DevExpress.XtraEditors.RadioGroup
End Class
