Public Class GameLevel2Homescreen
    Private Sub GameLevel2Homescreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.BackColor = ColorTranslator.FromHtml("#687651")
        Button1.ForeColor = ColorTranslator.FromHtml("#ffffff")
        'Button2.BackColor = ColorTranslator.FromHtml("#687651")
        'Button2.ForeColor = ColorTranslator.FromHtml("#ffffff")
        'Button3.BackColor = ColorTranslator.FromHtml("#687651")
        'Button3.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(Button1)
        'ButtonEffects.AddHoverEffect(Button2)
        'ButtonEffects.AddHoverEffect(Button3)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AnimationGameLevel2.Show()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Catch the Green Leaves and avoid the Dried Leaves using your basket! " & vbCrLf & vbCrLf & "Controls: <- -> Arrow Keys", "How to Play")
    End Sub
End Class