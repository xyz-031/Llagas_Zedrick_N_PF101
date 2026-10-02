Public Class GameLevel1Homescreen
    Private Sub GameLevel1Homescreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.BackColor = ColorTranslator.FromHtml("#687651")
        Button1.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(Button1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AnimationGameLevel1.Show()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Transfer Steve to the other island without getting outnumbered by the Creepers." & vbCrLf & vbCrLf & "Click a character to select them and click the buttons to do a certain action.", "How to Play")
    End Sub
End Class