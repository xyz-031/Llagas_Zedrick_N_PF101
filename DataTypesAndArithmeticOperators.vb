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

        ButtonEffects.AddHoverEffect(BackBtn)

    End Sub
End Class