Public Class AbstractClass
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub AbstractClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Button1.BackColor = ColorTranslator.FromHtml("#687651")
        Button1.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(BackBtn)
        ButtonEffects.AddHoverEffect(Button1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Number of Wheels: 4" & vbCrLf & "Engine SIze: 1500")
    End Sub
End Class