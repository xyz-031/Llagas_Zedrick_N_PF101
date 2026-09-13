Public Class Polymorphism
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Animal = New Dog()
        a.Speak()

        Label2.Visible = True
    End Sub

    Private Sub Polymorphism_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Visible = False

        Button1.BackColor = ColorTranslator.FromHtml("#687651")
        Button1.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Button2.BackColor = ColorTranslator.FromHtml("#687651")
        Button2.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(Button1)
        ButtonEffects.AddHoverEffect(Button2)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.Visible = False
    End Sub
End Class