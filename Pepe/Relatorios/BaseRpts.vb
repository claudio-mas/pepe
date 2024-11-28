Imports DevExpress.DataAccess
Imports DevExpress.DataAccess.Sql
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI

Public Class BaseRpts

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()

        DevExpress.LookAndFeel.UserLookAndFeel.Default.UseDefaultLookAndFeel = True
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Dark Side"

    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

End Class