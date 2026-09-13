Public Class ControlEvents
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub ControlEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim index1 As Integer = RichTextBox1.Find("The following is a default structure of a Form Load event handler subroutine. You can see this code by double clicking the code which will give you a complete list of all the events associated with Form control:")
        RichTextBox1.Select(index1, "The following is a default structure of a Form Load event handler subroutine. You can see this code by double clicking the code which will give you a complete list of all the events associated with Form control:".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        RichTextBox1.Select(0, 0)

        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")
        ButtonEffects.AddHoverEffect(BackBtn)
    End Sub
End Class