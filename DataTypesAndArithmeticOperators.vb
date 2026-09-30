Imports System.Reflection.Emit

Public Class DataTypesAndArithmeticOperators
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
    Private Sub DataTypesAndArithmeticOperators_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BoldText("Types of Data")
        BoldText("A. String")
        BoldText("B. Char")
        BoldText("C. Decimal")
        BoldText("D. Double")
        BoldText("E. Single")
        BoldText("F. Short")
        BoldText("G. Integer")
        BoldText("H. Long")
        BoldText("I. Boolean")
        BoldText("J. Byte")
        BoldText("K. Date")
        BoldText("L. Object")
        BoldText("Arithmetic Operators")
        BoldText("Addition")
        BoldText("Subtraction")
        BoldText("Multiplication")
        BoldText("Division")
        BoldText("Integer Division")
        BoldText("Exponentiation")
        BoldText("Modulus Division")
        BoldText("order of precedence")

        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Button1.BackColor = ColorTranslator.FromHtml("#687651")
        Button1.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(BackBtn)
        ButtonEffects.AddHoverEffect(Button1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
        Dim num2 As Integer
        num1 = TextBox1.Text
        num2 = TextBox2.Text

        If RadioButton1.Checked Then
            Label5.Text = "+"
            Label4.Text = num1 + num2

        ElseIf RadioButton2.Checked Then
            Label5.Text = "-"
            Label4.Text = num1 - num2

        ElseIf RadioButton3.Checked Then
            Label5.Text = "*"
            Label4.Text = num1 * num2

        Else
            Label5.Text = "/"
            Label4.Text = num1 / num2

        End If
    End Sub

End Class