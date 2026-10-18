Public Class DebuggingMode
    Private Sub DebuggingMode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(BackBtn)
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Close()
    End Sub
End Class