Public Class Variables
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub Variables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim index1 As Integer = RichTextBox1.Find("What are Variables?")
        RichTextBox1.Select(index1, "What are Variables?".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index2 As Integer = RichTextBox1.Find("When you name a variable, there are rules you should consider:")
        RichTextBox1.Select(index2, "When you name a variable, there are rules you should consider:".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index3 As Integer = RichTextBox1.Find("Declaring Variables")
        RichTextBox1.Select(index3, "Declaring Variables".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        RichTextBox1.Select(0, 0)

        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(BackBtn)
    End Sub
End Class