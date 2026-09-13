Public Class Encapsulation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Close()
    End Sub

    Dim account As New BankAccount()
    Dim amount As Decimal
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Your Current Account Balance is: " + account.GetBalance().ToString())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If TextBox1.Text Is String.Empty Then
            MessageBox.Show("Please enter an amount to deposit.")
        ElseIf IsNumeric(TextBox1.Text) Then
            amount = TextBox1.Text
            account.Deposit(amount)
            MessageBox.Show("Successfully Deposited.")
            TextBox1.Clear()
            Return
        Else
            MessageBox.Show("Please enter a valid number.")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text Is String.Empty Then
            MessageBox.Show("Please enter an amount to withdraw.")
        ElseIf IsNumeric(TextBox1.Text) Then
            amount = TextBox1.Text
            account.Withdraw(amount)
            TextBox1.Clear()
        Else
            MessageBox.Show("Please enter a valid number.")
        End If
    End Sub

    Private Sub Encapsulation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.BackColor = ColorTranslator.FromHtml("#687651")
        Button1.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Button2.BackColor = ColorTranslator.FromHtml("#687651")
        Button2.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Button3.BackColor = ColorTranslator.FromHtml("#687651")
        Button3.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Button4.BackColor = ColorTranslator.FromHtml("#687651")
        Button4.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(Button1)
        ButtonEffects.AddHoverEffect(Button2)
        ButtonEffects.AddHoverEffect(Button3)
        ButtonEffects.AddHoverEffect(Button4)
    End Sub
End Class