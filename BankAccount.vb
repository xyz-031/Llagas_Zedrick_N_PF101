Public Class BankAccount

    Private balance As Decimal

    Public Sub New()
        balance = 500
    End Sub

    Public Function GetBalance() As Decimal
        Return balance
    End Function

    Public Sub Deposit(amount As Decimal)
        balance = balance + amount
    End Sub

    Public Sub Withdraw(amount As Decimal)
        If amount <= balance Then
            balance = balance - amount
            MessageBox.Show("Successfully Withdrawn.")
        Else
            MessageBox.Show("Insufficient funds.")
        End If
    End Sub

End Class
