Public Class vervoerslog_form

    Private Sub Print_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print_but.Click
        WebBrowser1.ShowPrintDialog()

    End Sub
End Class