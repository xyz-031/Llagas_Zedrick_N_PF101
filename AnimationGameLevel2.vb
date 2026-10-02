Imports System.Reflection.Emit

Public Class AnimationGameLevel2
    Dim score As Integer = 0
    Dim fallingSpeed As Integer = 5
    Dim random As New Random()

    Dim fallingItem As PictureBox
    Dim gameEnded As Boolean = False
    Private Sub AnimationGameLevel2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button1.BackColor = ColorTranslator.FromHtml("#687651")
        Button1.ForeColor = ColorTranslator.FromHtml("#ffffff")
        ButtonEffects.AddHoverEffect(Button1)

        Me.KeyPreview = True

        Label1.Text = "Score: 0"


        PictureBox1.Size = New Size(64, 64)
        PictureBox2.Size = New Size(64, 64)

        PictureBox1.Location = New Point(0, -64)
        PictureBox2.Location = New Point(0, -64)

        'Losing line: across the form, near the bottom.
        'PictureBox3.Size = New Size(Me.ClientSize.Width, 10)
        'PictureBox3.Location =
        'New Point(0, Me.ClientSize.Height - 30)

        PictureBox4.Location = New Point(
        (Me.ClientSize.Width - PictureBox4.Width) \ 2,
        PictureBox3.Top - PictureBox4.Height - 10)

        Timer1.Interval = 20

        NewItem()
        Timer1.Start()


    End Sub

    Private Sub NewItem()

        'Hide both items before choosing one.
        PictureBox1.Visible = False
        PictureBox2.Visible = False

        '0 means good item; 1 means bad item.
        If random.Next(0, 2) = 0 Then
            fallingItem = PictureBox1
        Else
            fallingItem = PictureBox2
        End If

        'Choose a random horizontal position.
        fallingItem.Left = random.Next(
            0,
            Me.ClientSize.Width - fallingItem.Width + 1)

        'Start just above the screen.
        fallingItem.Top = -fallingItem.Height
        fallingItem.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) _
        Handles Timer1.Tick

        If gameEnded Then Exit Sub

        fallingItem.Top += fallingSpeed

        If fallingItem.Bounds.IntersectsWith(PictureBox4.Bounds) Then

            If fallingItem Is PictureBox1 Then
                score += 1
                fallingSpeed += 1
                Label1.Text = "Score: " & score

                NewItem()
            Else
                GameOver("You caught a Dried Leaf!")
            End If

            Exit Sub
        End If

        If fallingItem Is PictureBox1 Then

            If fallingItem.Bottom >= PictureBox3.Top Then
                GameOver("You missed a Green Leaf!")
                Exit Sub
            End If

        End If

        If fallingItem.Top >= Me.ClientSize.Height Then
            NewItem()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(
    ByRef msg As Message,
    keyData As Keys) As Boolean

        If keyData = Keys.Left OrElse keyData = Keys.Right Then

            If Not gameEnded Then
                If keyData = Keys.Left Then
                    PictureBox4.Left -= 15
                Else
                    PictureBox4.Left += 15
                End If

                'Keep the player inside the form.
                If PictureBox4.Left < 0 Then
                    PictureBox4.Left = 0
                End If

                If PictureBox4.Right > Me.ClientSize.Width Then
                    PictureBox4.Left =
                    Me.ClientSize.Width - PictureBox4.Width
                End If
            End If

            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub GameOver(reason As String)

        gameEnded = True
        Timer1.Stop()

        Dim answer As DialogResult = MessageBox.Show(
        reason & vbCrLf &
        "Your score: " & score & vbCrLf & vbCrLf &
        "Would you like to retry?",
        "Game Over",
        MessageBoxButtons.YesNo)

        If answer = DialogResult.Yes Then
            score = 0
            Label1.Text = "Score: 0"
            fallingSpeed = 5

            'Return the player to its starting position.
            PictureBox4.Location = New Point(
            (Me.ClientSize.Width - PictureBox4.Width) \ 2,
            PictureBox3.Top - PictureBox4.Height - 10)

            gameEnded = False
            NewItem()
            Timer1.Start()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GameLevel2Homescreen.Show()
        Close()
    End Sub
End Class