<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class x
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

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(x))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.C1Report1 = New C1.C1Report.C1Report()
        Me.C1Report2 = New C1.C1Report.C1Report()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(273, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Pumpkin"
        '
        'C1Report1
        '
        Me.C1Report1.DisposeC1Document = True
        Me.C1Report1.EditContext = Nothing
        Me.C1Report1.ReportDefinition = resources.GetString("C1Report1.ReportDefinition")
        Me.C1Report1.ReportName = "C1Report1"
        '
        'C1Report2
        '
        Me.C1Report2.DisposeC1Document = True
        Me.C1Report2.EditContext = Nothing
        Me.C1Report2.ReportDefinition = resources.GetString("C1Report2.ReportDefinition")
        Me.C1Report2.ReportName = "C1Report2"
        '
        'x
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 262)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
        Me.Name = "x"
        Me.Text = "x"
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents C1Report1 As C1.C1Report.C1Report
    Friend WithEvents C1Report2 As C1.C1Report.C1Report
End Class
