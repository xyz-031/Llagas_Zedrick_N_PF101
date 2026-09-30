Public Class LaboratoryExercise
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub LaboratoryExercise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim months As String() = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
        ListBox1.Items.AddRange(months)

        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(BackBtn)
    End Sub
End Class