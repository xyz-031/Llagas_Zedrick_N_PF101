Public Class UsingRelationalOperatorsWithMathOperators
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intA As Integer = 5
        Dim intB As Integer = 1
        Dim intC As Integer = 5
        Dim intD As Integer = 1

        If (intA + intB) > (intC - intD) Then
            MessageBox.Show("intA + intB is greater than intC - intD")
        End If

    End Sub

    Private Sub UsingRelationalOperatorsWithMathOperators_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Button1.BackColor = ColorTranslator.FromHtml("#687651")
        Button1.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(BackBtn)
        ButtonEffects.AddHoverEffect(Button1)
    End Sub
End Class