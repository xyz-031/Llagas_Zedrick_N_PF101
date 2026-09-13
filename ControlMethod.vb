Public Class ControlMethod
    Private Sub ControlMethod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim index1 As Integer = RichTextBox1.Find("For example, the MessageBox control has a method named Show, which is called in the code snippet below:")
        RichTextBox1.Select(index1, "For example, the MessageBox control has a method named Show, which is called in the code snippet below:".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        RichTextBox1.Select(0, 0)

        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Button2.BackColor = ColorTranslator.FromHtml("#687651")
        Button2.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(BackBtn)
        ButtonEffects.AddHoverEffect(Button2)
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("This message box was created using the Show method (MessageBox.Show) of the MessageBox control.", "Message Box Example")
    End Sub
End Class