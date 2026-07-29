<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCota
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

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.txtDolar = New DevExpress.XtraEditors.TextEdit()
        Me.txtOuro = New DevExpress.XtraEditors.TextEdit()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txtDolar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOuro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(112, 51)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(52, 13)
        Label2.TabIndex = 35
        Label2.Text = "Dólar"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(144, 136)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.TabStop = False
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.TabStop = False
        Me.Cancel_Button.Text = "Cancelar"
        '
        'txtDolar
        '
        Me.txtDolar.EditValue = ""
        Me.txtDolar.Location = New System.Drawing.Point(170, 47)
        Me.txtDolar.Name = "txtDolar"
        Me.txtDolar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDolar.Properties.Appearance.Options.UseFont = True
        Me.txtDolar.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDolar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDolar.Properties.AutoHeight = False
        Me.txtDolar.Properties.BeepOnError = True
        Me.txtDolar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDolar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDolar.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtDolar.Properties.MaskSettings.Set("mask", "n")
        Me.txtDolar.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDolar.Properties.MaskSettings.Set("autoHideDecimalSeparator", Nothing)
        Me.txtDolar.Properties.UseMaskAsDisplayFormat = True
        Me.txtDolar.Size = New System.Drawing.Size(95, 22)
        Me.txtDolar.TabIndex = 0
        '
        'txtOuro
        '
        Me.txtOuro.EditValue = ""
        Me.txtOuro.Location = New System.Drawing.Point(170, 77)
        Me.txtOuro.Name = "txtOuro"
        Me.txtOuro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOuro.Properties.Appearance.Options.UseFont = True
        Me.txtOuro.Properties.Appearance.Options.UseTextOptions = True
        Me.txtOuro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtOuro.Properties.AutoHeight = False
        Me.txtOuro.Properties.BeepOnError = True
        Me.txtOuro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtOuro.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOuro.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtOuro.Properties.MaskSettings.Set("mask", "n")
        Me.txtOuro.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtOuro.Properties.MaskSettings.Set("autoHideDecimalSeparator", Nothing)
        Me.txtOuro.Properties.UseMaskAsDisplayFormat = True
        Me.txtOuro.Size = New System.Drawing.Size(95, 22)
        Me.txtOuro.TabIndex = 36
        '
        'Label1
        '
        Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Location = New System.Drawing.Point(112, 82)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(52, 13)
        Label1.TabIndex = 37
        Label1.Text = "Ouro"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 177)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtOuro)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtDolar)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "High Contrast Classic"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCota"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "COTAÇÃO"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.txtDolar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOuro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents txtDolar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOuro As DevExpress.XtraEditors.TextEdit
End Class
