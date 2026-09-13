Public Class VBNetBasicControls
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub VBNetBasicControls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim index1 As Integer = RichTextBox1.Find("What are the basic controls in VB.Net?")
        RichTextBox1.Select(index1, "What are the basic controls in VB.Net?".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index2 As Integer = RichTextBox1.Find("Object")
        RichTextBox1.Select(index2, "Object".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index3 As Integer = RichTextBox1.Find("In every Visual Basic Control, it consists of three important elements:")
        RichTextBox1.Select(index3, "In every Visual Basic Control, it consists of three important elements:".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index4 As Integer = RichTextBox1.Find("A. Properties:")
        RichTextBox1.Select(index4, "A. Properties:".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index5 As Integer = RichTextBox1.Find("B. Methods:")
        RichTextBox1.Select(index5, "B. Methods:".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index6 As Integer = RichTextBox1.Find("C. Events:")
        RichTextBox1.Select(index6, "C. Events:".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index7 As Integer = RichTextBox1.Find("The following lists some of the commonly used controls:")
        RichTextBox1.Select(index7, "The following lists some of the commonly used controls:".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        RichTextBox1.Select(0, 0)

        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")
        ButtonEffects.AddHoverEffect(BackBtn)


    End Sub
End Class