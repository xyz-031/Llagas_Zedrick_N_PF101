Public Class LogicalOperators
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Close()
    End Sub


    Private Sub LogicalOperators_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(BackBtn)


    End Sub

    Private Sub results() Handles _
    a1.SelectedIndexChanged, b1.SelectedIndexChanged,
    a2.SelectedIndexChanged, b2.SelectedIndexChanged,
    a3.SelectedIndexChanged, b3.SelectedIndexChanged,
    a4.SelectedIndexChanged, b4.SelectedIndexChanged,
    orA1.SelectedIndexChanged, orB1.SelectedIndexChanged,
    orA2.SelectedIndexChanged, orB2.SelectedIndexChanged,
    orA3.SelectedIndexChanged, orB3.SelectedIndexChanged,
    orA4.SelectedIndexChanged, orB4.SelectedIndexChanged,
    xorA1.SelectedIndexChanged, xorB1.SelectedIndexChanged,
    xorA2.SelectedIndexChanged, xorB2.SelectedIndexChanged,
    xorA3.SelectedIndexChanged, xorB3.SelectedIndexChanged,
    xorA4.SelectedIndexChanged, xorB4.SelectedIndexChanged,
    notA1.SelectedIndexChanged,
    notA2.SelectedIndexChanged

        ' AND
        If a1.Text = "" OrElse b1.Text = "" Then
            c1.Text = ""
        ElseIf a1.Text = "True" AndAlso b1.Text = "True" Then
            c1.Text = "True"
        Else
            c1.Text = "False"
        End If

        If a2.Text = "" OrElse b2.Text = "" Then
            c2.Text = ""
        ElseIf a2.Text = "True" AndAlso b2.Text = "True" Then
            c2.Text = "True"
        Else
            c2.Text = "False"
        End If

        If a3.Text = "" OrElse b3.Text = "" Then
            c3.Text = ""
        ElseIf a3.Text = "True" AndAlso b3.Text = "True" Then
            c3.Text = "True"
        Else
            c3.Text = "False"
        End If

        If a4.Text = "" OrElse b4.Text = "" Then
            c4.Text = ""
        ElseIf a4.Text = "True" AndAlso b4.Text = "True" Then
            c4.Text = "True"
        Else
            c4.Text = "False"
        End If


        ' OR
        If orA1.Text = "" OrElse orB1.Text = "" Then
            orC1.Text = ""
        ElseIf orA1.Text = "True" OrElse orB1.Text = "True" Then
            orC1.Text = "True"
        Else
            orC1.Text = "False"
        End If

        If orA2.Text = "" OrElse orB2.Text = "" Then
            orC2.Text = ""
        ElseIf orA2.Text = "True" OrElse orB2.Text = "True" Then
            orC2.Text = "True"
        Else
            orC2.Text = "False"
        End If

        If orA3.Text = "" OrElse orB3.Text = "" Then
            orC3.Text = ""
        ElseIf orA3.Text = "True" OrElse orB3.Text = "True" Then
            orC3.Text = "True"
        Else
            orC3.Text = "False"
        End If

        If orA4.Text = "" OrElse orB4.Text = "" Then
            orC4.Text = ""
        ElseIf orA4.Text = "True" OrElse orB4.Text = "True" Then
            orC4.Text = "True"
        Else
            orC4.Text = "False"
        End If


        ' XOR
        If xorA1.Text = "" OrElse xorB1.Text = "" Then
            xorC1.Text = ""
        ElseIf xorA1.Text <> xorB1.Text Then
            xorC1.Text = "True"
        Else
            xorC1.Text = "False"
        End If

        If xorA2.Text = "" OrElse xorB2.Text = "" Then
            xorC2.Text = ""
        ElseIf xorA2.Text <> xorB2.Text Then
            xorC2.Text = "True"
        Else
            xorC2.Text = "False"
        End If

        If xorA3.Text = "" OrElse xorB3.Text = "" Then
            xorC3.Text = ""
        ElseIf xorA3.Text <> xorB3.Text Then
            xorC3.Text = "True"
        Else
            xorC3.Text = "False"
        End If

        If xorA4.Text = "" OrElse xorB4.Text = "" Then
            xorC4.Text = ""
        ElseIf xorA4.Text <> xorB4.Text Then
            xorC4.Text = "True"
        Else
            xorC4.Text = "False"
        End If


        ' NOT
        If notA1.Text = "" Then
            notC1.Text = ""
        ElseIf notA1.Text = "True" Then
            notC1.Text = "False"
        Else
            notC1.Text = "True"
        End If

        If notA2.Text = "" Then
            notC2.Text = ""
        ElseIf notA2.Text = "True" Then
            notC2.Text = "False"
        Else
            notC2.Text = "True"
        End If

    End Sub

End Class