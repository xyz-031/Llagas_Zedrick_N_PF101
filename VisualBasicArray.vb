Public Class VisualBasicArray

    Private Sub BoldText(textToBold As String)
        Dim index As Integer = RichTextBox1.Find(textToBold)

        If index >= 0 Then
            RichTextBox1.Select(index, textToBold.Length)
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        End If
    End Sub
    Private Sub VisualBasicArray_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(BackBtn)

        BoldText("Characteristics of an Array")
        BoldText("Declaring an Array")
        BoldText("One Dimension Array")
        BoldText("Two-DImensional Array")
        BoldText("Three-Dimensional Arrays and Beyond")

        RichTextBox1.Select(0, 0)
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Close()
    End Sub
End Class