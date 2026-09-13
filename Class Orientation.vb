Public Class Class_Orientation
    Private Sub Class_Orientation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")
        ButtonEffects.AddHoverEffect(BackBtn)

        Dim index1 As Integer = RichTextBox1.Find("(PF101) OBJECT-ORIENTED PROGRAMMING CLASS ORIENTATION")
        RichTextBox1.Select(index1, "(PF101) OBJECT-ORIENTED PROGRAMMING CLASS ORIENTATION".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index2 As Integer = RichTextBox1.Find("Quezon City University - Mission")
        RichTextBox1.Select(index2, "Quezon City University - Mission".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index3 As Integer = RichTextBox1.Find("Quezon City University - Vision")
        RichTextBox1.Select(index3, "Quezon City University - Vision".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index4 As Integer = RichTextBox1.Find("Quezon City University Values:")
        RichTextBox1.Select(index4, "Quezon City University Values:".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index5 As Integer = RichTextBox1.Find("Classroom Regulations:")
        RichTextBox1.Select(index5, "Classroom Regulations:".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Close()
    End Sub
End Class