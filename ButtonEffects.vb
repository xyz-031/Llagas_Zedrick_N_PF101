Public Class ButtonEffects
    Public Shared Sub AddHoverEffect(btn As Button)

        Dim normalColor As Color = btn.BackColor
        Dim normalForeColor As Color = ColorTranslator.FromHtml("#ffffff")
        Dim hoverColor As Color = ColorTranslator.FromHtml("#8a9a5b")
        Dim foreColorHover As Color = ColorTranslator.FromHtml("#fff6a3")

        AddHandler btn.MouseEnter,
            Sub()
                btn.BackColor = hoverColor
                btn.ForeColor = foreColorHover
            End Sub

        AddHandler btn.MouseLeave,
            Sub()
                btn.BackColor = normalColor
                btn.ForeColor = normalForeColor
            End Sub

    End Sub

End Class
