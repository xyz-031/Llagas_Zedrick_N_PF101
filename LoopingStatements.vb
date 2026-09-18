Public Class LoopingStatements
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub LoopingStatements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(BackBtn)

        Timer1.Start()
    End Sub

    Dim intHours As Integer = 0
    Dim intMinutes As Integer = 0
    Dim intSeconds As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblSeconds.Text = intSeconds.ToString()

        intSeconds += 1

        If intSeconds = 60 Then
            intSeconds = 0
            intMinutes += 1
        End If

        If intMinutes = 60 Then
            intMinutes = 0
            intHours += 1
        End If

        lblMinutes.Text = intMinutes.ToString()
        lblHours.Text = intHours.ToString()
    End Sub
End Class