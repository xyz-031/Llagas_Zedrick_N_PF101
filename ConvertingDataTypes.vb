Public Class ConvertingDataTypes
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub BoldText(textToBold As String)
        Dim index As Integer = RichTextBox1.Find(textToBold)

        If index >= 0 Then
            RichTextBox1.Select(index, textToBold.Length)
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        End If
    End Sub
    Private Sub ConvertingDataTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(BackBtn)

        BoldText("Converting Output Data Types")
        BoldText("Implicit Conversion")
        BoldText("Explicit Conversion")
    End Sub
End Class