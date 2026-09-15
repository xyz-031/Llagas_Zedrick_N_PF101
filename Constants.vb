Public Class Constants
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub Constants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim index1 As Integer = RichTextBox1.Find("What are Constants?")
        RichTextBox1.Select(index1, "What are Constants?".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index2 As Integer = RichTextBox1.Find("There are two different types of constants in Visual Basic:")
        RichTextBox1.Select(index2, "There are two different types of constants in Visual Basic:".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index3 As Integer = RichTextBox1.Find("A. Intrinsic Constants")
        RichTextBox1.Select(index3, "A. Intrinsic Constants".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index4 As Integer = RichTextBox1.Find("B. Named Constants")
        RichTextBox1.Select(index4, "B. Named Constants".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        RichTextBox1.Select(0, 0)

        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(BackBtn)
    End Sub
End Class