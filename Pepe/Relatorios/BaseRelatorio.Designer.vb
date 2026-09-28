<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BaseRelatorio
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlFiltro = New System.Windows.Forms.Panel()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnOk2 = New System.Windows.Forms.Button()
        Me.txtData2 = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl2 = New System.Windows.Forms.Label()
        Me.txtData1 = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl1 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnlFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFiltro
        '
        Me.pnlFiltro.Controls.Add(Me.btnFechar)
        Me.pnlFiltro.Controls.Add(Me.btnOk2)
        Me.pnlFiltro.Controls.Add(Me.txtData2)
        Me.pnlFiltro.Controls.Add(Me.LabelControl2)
        Me.pnlFiltro.Controls.Add(Me.txtData1)
        Me.pnlFiltro.Controls.Add(Me.LabelControl1)
        Me.pnlFiltro.Controls.Add(Me.lblTitulo)
        Me.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFiltro.Location = New System.Drawing.Point(0, 0)
        Me.pnlFiltro.Name = "pnlFiltro"
        Me.pnlFiltro.Size = New System.Drawing.Size(1334, 42)
        Me.pnlFiltro.TabIndex = 0
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnFechar.Location = New System.Drawing.Point(1242, 8)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(84, 27)
        Me.btnFechar.TabIndex = 4
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnOk2
        '
        Me.btnOk2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnOk2.Location = New System.Drawing.Point(804, 8)
        Me.btnOk2.Name = "btnOk2"
        Me.btnOk2.Size = New System.Drawing.Size(84, 27)
        Me.btnOk2.TabIndex = 3
        Me.btnOk2.Text = "Gerar"
        Me.btnOk2.UseVisualStyleBackColor = True
        '
        'txtData2
        '
        Me.txtData2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.txtData2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtData2.Location = New System.Drawing.Point(691, 9)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(105, 23)
        Me.txtData2.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl2.Location = New System.Drawing.Point(664, 11)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(24, 19)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "a"
        Me.LabelControl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtData1
        '
        Me.txtData1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.txtData1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtData1.Location = New System.Drawing.Point(556, 9)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(105, 23)
        Me.txtData1.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl1.Location = New System.Drawing.Point(465, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(88, 19)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Período: de"
        Me.LabelControl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblTitulo.Location = New System.Drawing.Point(8, 7)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(440, 28)
        Me.lblTitulo.TabIndex = 7
        Me.lblTitulo.Text = "TÍTULO DO RELATÓRIO"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 42)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1334, 634)
        Me.ReportViewer1.TabIndex = 1
        '
        'BaseRelatorio
        '
        Me.AcceptButton = Me.btnOk2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1334, 676)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.pnlFiltro)
        Me.Name = "BaseRelatorio"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEPE TORRAS DESIGN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlFiltro.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFiltro As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents LabelControl1 As System.Windows.Forms.Label
    Friend WithEvents txtData1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl2 As System.Windows.Forms.Label
    Friend WithEvents txtData2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnOk2 As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
