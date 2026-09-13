Public Class DefiningComputerProgrammingAndTranslatorOfProgrammingLanguage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub DefiningComputerProgrammingAndTranslatorOfProgrammingLanguage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.BackColor = ColorTranslator.FromHtml("#687651")
        Button1.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(Button1)

        Dim index1 As Integer = RichTextBox1.Find("What is Computer Programming?")
        RichTextBox1.Select(index1, "What is Computer Programming?".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.Select(0, 0)
    End Sub
End Class