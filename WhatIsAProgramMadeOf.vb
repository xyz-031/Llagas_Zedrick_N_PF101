Public Class WhatIsAProgramMadeOf
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub WhatIsAProgramMadeOf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim index1 As Integer = RichTextBox1.Find("Keywords")
        RichTextBox1.Select(index1, "Keywords".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index2 As Integer = RichTextBox1.Find("There are many components used to make a Program, these are the following:")
        RichTextBox1.Select(index2, "There are many components used to make a Program, these are the following:".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index3 As Integer = RichTextBox1.Find("Operators")
        RichTextBox1.Select(index3, "Operators".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index4 As Integer = RichTextBox1.Find("Variables")
        RichTextBox1.Select(index4, "Variables".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index5 As Integer = RichTextBox1.Find("Syntax")
        RichTextBox1.Select(index5, "Syntax".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index6 As Integer = RichTextBox1.Find("Statements")
        RichTextBox1.Select(index6, "Statements".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index7 As Integer = RichTextBox1.Find("Procedures")
        RichTextBox1.Select(index7, "Procedures".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index8 As Integer = RichTextBox1.Find("Comments")
        RichTextBox1.Select(index8, "Comments".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.Select(0, 0)

        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(BackBtn)
    End Sub
End Class