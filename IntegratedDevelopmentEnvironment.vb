Public Class IntegratedDevelopmentEnvironment
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub IntegratedDevelopmentEnvironment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")
        PreviousPageBtn.BackColor = ColorTranslator.FromHtml("#687651")
        PreviousPageBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")
        NextPageBtn.BackColor = ColorTranslator.FromHtml("#687651")
        NextPageBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(BackBtn)
        ButtonEffects.AddHoverEffect(PreviousPageBtn)
        ButtonEffects.AddHoverEffect(NextPageBtn)

        Dim index1 As Integer = RichTextBox1.Find("The Output, Error List, and Command Window:")
        RichTextBox1.Select(index1, "The Output, Error List, and Command Window:".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index2 As Integer = RichTextBox1.Find("Output Window")
        RichTextBox1.Select(index2, "Output Window".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index3 As Integer = RichTextBox1.Find("Error List Window")
        RichTextBox1.Select(index3, "Error List Window".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim secondIndex4 As Integer = RichTextBox1.Find("Command Window")
        Dim index4 As Integer = RichTextBox1.Find("Command Window", secondIndex4 + "Command Window".Length, RichTextBoxFinds.None)
        RichTextBox1.Select(index4, "Command Window".Length)
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)

        Dim index5 As Integer = RichTextBox2.Find("Form Designer Window")
        RichTextBox2.Select(index5, "Form Designer Window".Length)
        RichTextBox2.SelectionFont = New Font(RichTextBox2.Font, FontStyle.Bold)

        Dim index6 As Integer = RichTextBox3.Find("Properties Window")
        RichTextBox3.Select(index6, "Properties Window".Length)
        RichTextBox3.SelectionFont = New Font(RichTextBox3.Font, FontStyle.Bold)

        Dim index7 As Integer = RichTextBox4.Find("Solution Explorer Window")
        RichTextBox4.Select(index7, "Solution Explorer Window".Length)
        RichTextBox4.SelectionFont = New Font(RichTextBox4.Font, FontStyle.Bold)

        Dim index8 As Integer = RichTextBox5.Find("Toolbox Window")
        RichTextBox5.Select(index8, "Toolbox Window".Length)
        RichTextBox5.SelectionFont = New Font(RichTextBox5.Font, FontStyle.Bold)

        Dim index9 As Integer = RichTextBox6.Find("Menu Bar")
        RichTextBox6.Select(index9, "Menu Bar".Length)
        RichTextBox6.SelectionFont = New Font(RichTextBox6.Font, FontStyle.Bold)

        Dim secondIndex10 As Integer = RichTextBox6.Find("Tool Bar")
        Dim index10 As Integer = RichTextBox6.Find("Tool Bar", secondIndex10 + "Tool Bar".Length, RichTextBoxFinds.None)
        RichTextBox6.Select(index10, "Tool Bar".Length)
        RichTextBox6.SelectionFont = New Font(RichTextBox6.Font, FontStyle.Bold)

        Dim index11 As Integer = RichTextBox6.Find("Menu and Tool Bar")
        RichTextBox6.Select(index11, "Menu and Tool Bar".Length)
        RichTextBox6.SelectionFont = New Font(RichTextBox6.Font, FontStyle.Bold)

        RichTextBox1.Select(0, 0)
    End Sub

    Private Sub NextPageBtn_Click(sender As Object, e As EventArgs) Handles NextPageBtn.Click
        If currentPage = 1 Then
            Panel8.Visible = False
            Panel7.Visible = True
            currentPage = 2

        ElseIf currentPage = 2 Then
            Panel7.Visible = False
            Panel6.Visible = True
            currentPage = 3

        ElseIf currentPage = 3 Then
            Panel6.Visible = False
            Panel5.Visible = True
            currentPage = 4

        ElseIf currentPage = 4 Then
            Panel5.Visible = False
            Panel4.Visible = True
            currentPage = 5

        ElseIf currentPage = 5 Then
            Panel4.Visible = False
            Panel3.Visible = True
            currentPage = 6

        ElseIf currentPage = 6 Then
            Panel3.Visible = False
            Panel1.Visible = True
            currentPage = 7

        ElseIf currentPage = 7 Then
            Panel1.Visible = False
            Panel2.Visible = True
            currentPage = 8
        End If

    End Sub

    Dim currentPage As Integer = 1
    Private Sub PreviousPageBtn_Click(sender As Object, e As EventArgs) Handles PreviousPageBtn.Click

        If currentPage = 8 Then
            Panel1.Visible = True
            currentPage = 7

        ElseIf currentPage = 7 Then
            Panel3.Visible = True
            currentPage = 6

        ElseIf currentPage = 6 Then
            Panel4.Visible = True
            currentPage = 5

        ElseIf currentPage = 5 Then
            Panel5.Visible = True
            currentPage = 4

        ElseIf currentPage = 4 Then
            Panel6.Visible = True
            currentPage = 3

        ElseIf currentPage = 3 Then
            Panel7.Visible = True
            currentPage = 2

        ElseIf currentPage = 2 Then
            Panel8.Visible = True
            currentPage = 1
        End If

    End Sub
End Class