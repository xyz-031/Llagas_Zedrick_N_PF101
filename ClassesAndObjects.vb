Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Public Class ClassesAndObjects
    Private Sub ClassesAndObjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml("#e6e3dc")
        Button1.BackColor = ColorTranslator.FromHtml("#687651")
        Button1.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Button2.BackColor = ColorTranslator.FromHtml("#687651")
        Button2.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(Button1)
        ButtonEffects.AddHoverEffect(Button2)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim p As New Person
        p.Name = "Alice"
        p.Age = 30

        TextBox1.Text = p.Name
        TextBox2.Text = p.Age
    End Sub
    Public Class Person
        Public Name As String
        Public Age As Integer
    End Class

    'Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
    'Dim menu As Panel = DirectCast(sender, Panel)

    'Dim radius As Integer = 15

    'Dim path As New GraphicsPath()

    'path.AddArc(0, 0, radius, radius, 180, 90)
    'path.AddArc(menu.Width - radius, 0, radius, radius, 270, 90)
    'path.AddArc(menu.Width - radius, menu.Height - radius, radius, radius, 0, 90)
    'path.AddArc(0, menu.Height - radius, radius, radius, 90, 90)

    'path.CloseFigure()

    'menu.Region = New Region(path)
    'End Sub
End Class
