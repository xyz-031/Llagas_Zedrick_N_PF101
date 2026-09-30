Public Class Week8LaboratoryActivity
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub Week8LaboratoryActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Button1.BackColor = ColorTranslator.FromHtml("#687651")
        Button1.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Button2.ForeColor = ColorTranslator.FromHtml("#687651")
        Button3.ForeColor = ColorTranslator.FromHtml("#687651")
        Button4.BackColor = ColorTranslator.FromHtml("#687651")
        Button4.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(BackBtn)
        ButtonEffects.AddHoverEffect(Button1)
        ButtonEffects.AddHoverEffect(Button4)

        Label1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter a value in the TextBox.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            Label1.Text = TextBox1.Text
            Label1.Visible = True
            Button2.Visible = True
            Button3.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            Label1.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            Label1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.Text = ""
        TextBox1.Text = ""
        Label1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
    End Sub
End Class