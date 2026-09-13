Public Class Inheritance

    Private Sub Inheritance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False

        Button1.BackColor = ColorTranslator.FromHtml("#687651")
        Button1.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Button2.BackColor = ColorTranslator.FromHtml("#687651")
        Button2.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Button3.BackColor = ColorTranslator.FromHtml("#687651")
        Button3.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(Button1)
        ButtonEffects.AddHoverEffect(Button2)
        ButtonEffects.AddHoverEffect(Button3)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button2.Enabled = True

        Dim animal As New Animal()
        animal.Speak()

        Label3.Text = "The Sub Class named 'Dog' inherits Animal's ability to Speak, therefore:"

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dog As New Dog()
        dog.Speak()
    End Sub
End Class