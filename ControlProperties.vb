Public Class ControlProperties
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub ControlProperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel3.Visible = False

        Dim index1 As Integer = RichTextBox1.Find("property")
        RichTextBox1.Select(index1, "property".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index2 As Integer = RichTextBox1.Find("Code Format:")
        RichTextBox1.Select(index2, "Code Format:".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index3 As Integer = RichTextBox1.Find("Where:")
        RichTextBox1.Select(index3, "Where:".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index4 As Integer = RichTextBox1.Find("Object:")
        RichTextBox1.Select(index4, "Object:".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index5 As Integer = RichTextBox1.Find("Property:")
        RichTextBox1.Select(index5, "Property:".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index6 As Integer = RichTextBox1.Find("Value:")
        RichTextBox1.Select(index6, "Value".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index7 As Integer = RichTextBox1.Find("Try it out yourself by interacting with the example --->")
        RichTextBox1.Select(index7, "Try it out yourself by interacting with the example --->".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        RichTextBox1.Select(0, 0)

        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Button2.BackColor = ColorTranslator.FromHtml("#687651")
        Button2.ForeColor = ColorTranslator.FromHtml("#ffffff")
        ButtonEffects.AddHoverEffect(BackBtn)
        ButtonEffects.AddHoverEffect(Button2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel3.Visible = True

        Label2.Text = TextBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel3.Visible = False
    End Sub
End Class