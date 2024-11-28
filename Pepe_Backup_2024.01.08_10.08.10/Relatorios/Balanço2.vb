Imports DevExpress.XtraReports.UI
Public Class Balanço2
    Private Sub XrLabel15_PrintOnPage(sender As Object, e As PrintOnPageEventArgs) Handles XrLabel15.PrintOnPage

        If e.PageIndex = e.PageCount - 1 Then
            ' Set its text.
            'CType(sender, XRLabel).Text = "The last page!"
            'CType(sender, XRLabel).Visible = True
        Else
            ' Check if the label is printed on the odd page.
            'If e.PageIndex Mod 2 = 0 Then
            ' Cancel its printing.
            e.Cancel = True
            'End If
        End If
    End Sub

    Private Sub XrLabel16_PrintOnPage(sender As Object, e As PrintOnPageEventArgs) Handles XrLabel16.PrintOnPage

        If e.PageIndex <> e.PageCount - 1 Then
            'If XrLabel5.Text <> "PUL - OU" Then
            e.Cancel = True
            'End If
        End If
    End Sub

    Private Sub XrLabel17_PrintOnPage(sender As Object, e As PrintOnPageEventArgs) Handles XrLabel17.PrintOnPage

        If e.PageIndex <> e.PageCount - 1 Then
            e.Cancel = True
        End If

    End Sub
End Class