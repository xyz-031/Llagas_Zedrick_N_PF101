Imports System.Security.Authentication.ExtendedProtection

Public Class AnimationGameLevel1
    Private Sub AnimationGameLevel1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BackBtn.BackColor = ColorTranslator.FromHtml("#687651")
        BackBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")
        MoveToRaftBtn.BackColor = ColorTranslator.FromHtml("#687651")
        MoveToRaftBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")
        RemoveBtn.BackColor = ColorTranslator.FromHtml("#687651")
        RemoveBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")
        MoveRaftBtn.BackColor = ColorTranslator.FromHtml("#687651")
        MoveRaftBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")
        ResetBtn.BackColor = ColorTranslator.FromHtml("#687651")
        ResetBtn.ForeColor = ColorTranslator.FromHtml("#ffffff")

        ButtonEffects.AddHoverEffect(BackBtn)
        ButtonEffects.AddHoverEffect(MoveToRaftBtn)
        ButtonEffects.AddHoverEffect(RemoveBtn)
        ButtonEffects.AddHoverEffect(MoveRaftBtn)
        ButtonEffects.AddHoverEffect(ResetBtn)

        Priest1.Location = defaultLocationOfPriest1
        Priest2.Location = defaultLocationOfPriest2
        Priest3.Location = defaultLocationOfPriest3

        Devil1.Location = defaultLocationOfDevil1
        Devil2.Location = defaultLocationOfDevil2
        Devil3.Location = defaultLocationOfDevil3

        Raft.Location = defaultLocationOfRaft

        numbersOfCharacterOnTheRaft = 0
        Label1.Text = ""

        Raft.Location = raftPositionA
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Me.Close()
    End Sub

    'Default Locations of the Assets.
    Dim defaultLocationOfPriest1 = New Point(266, 293)
    Dim defaultLocationOfPriest2 = New Point(309, 293)
    Dim defaultLocationOfPriest3 = New Point(352, 293)

    Dim defaultLocationOfDevil1 = New Point(266, 361)
    Dim defaultLocationOfDevil2 = New Point(309, 361)
    Dim defaultLocationOfDevil3 = New Point(352, 361)

    Dim defaultLocationOfRaft = New Point(442, 268)
    '---------------------------------------------------

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Timer1.Stop()
        raftIsMoving = False
        raftMovingTo = 0
        gameEnded = False

        If selectedCharacter IsNot Nothing Then
            selectedCharacter.BorderStyle = BorderStyle.None
        End If

        selectedCharacter = Nothing

        MoveToRaftBtn.Enabled = True
        RemoveBtn.Enabled = True
        MoveRaftBtn.Enabled = True

        Priest1.Location = defaultLocationOfPriest1
        Priest2.Location = defaultLocationOfPriest2
        Priest3.Location = defaultLocationOfPriest3

        Devil1.Location = defaultLocationOfDevil1
        Devil2.Location = defaultLocationOfDevil2
        Devil3.Location = defaultLocationOfDevil3

        Raft.Location = defaultLocationOfRaft

        numbersOfCharacterOnTheRaft = 0
        Label1.Text = ""
        priest1OnRaft = False
        priest2OnRaft = False
        priest3OnRaft = False
        devil1OnRaft = False
        devil2OnRaft = False
        devil3OnRaft = False

        Raft.Location = raftPositionA
    End Sub

    'This is for setting my selected character.
    Dim selectedCharacter As PictureBox
    '---------------------------------------------------

    'This is for setting each character's position in the raft.
    Dim raftPositionOfPriest1 = New Point(454, 293)
    Dim raftPositionOfPriest2 = New Point(497, 293)
    Dim raftPositionOfPriest3 = New Point(540, 293)

    Dim raftPositionOfDevil1 = New Point(454, 361)
    Dim raftPositionOfDevil2 = New Point(497, 361)
    Dim raftPositionOfDevil3 = New Point(540, 361)
    '---------------------------------------------------
    Private Sub Character_Click(sender As Object, e As EventArgs) _
    Handles Priest1.Click, Priest2.Click, Priest3.Click,
            Devil1.Click, Devil2.Click, Devil3.Click

        'Remove the previous character's highlight.
        If selectedCharacter IsNot Nothing Then
            selectedCharacter.BorderStyle = BorderStyle.None
        End If

        'Select and highlight the clicked character.
        selectedCharacter = DirectCast(sender, PictureBox)
        selectedCharacter.BorderStyle = BorderStyle.FixedSingle

    End Sub

    'This is to know if how many characters are already on the raft.
    Dim numbersOfCharacterOnTheRaft As Integer
    '---------------------------------------------------

    'This is to know that, that character is already on the raft.
    Dim priest1OnRaft, priest2OnRaft, priest3OnRaft,
        devil1OnRaft, devil2OnRaft, devil3OnRaft As Boolean
    '---------------------------------------------------
    Private Sub MoveToRaftBtn_Click(sender As Object, e As EventArgs) Handles MoveToRaftBtn.Click
        If gameEnded OrElse raftIsMoving Then Exit Sub

        If numbersOfCharacterOnTheRaft < 3 Then
            '--------------------------------------------------
            If selectedCharacter Is Priest1 Then
                If priest1OnRaft = False Then

                    If Raft.Location = raftPositionC Then
                        If Priest1.Location = priest1LocationC Then
                            Priest1.Location = positionCOfPriest1WhenOnRaft
                            numbersOfCharacterOnTheRaft += 1
                            priest1OnRaft = True
                        End If

                    ElseIf Raft.Location = raftPositionA Then

                        If Priest1.Location = defaultLocationOfPriest1 Then
                            Priest1.Location = raftPositionOfPriest1
                            numbersOfCharacterOnTheRaft += 1
                            priest1OnRaft = True
                        End If

                    End If
                End If
            End If


            If selectedCharacter Is Priest2 Then
                If priest2OnRaft = False Then

                    If Raft.Location = raftPositionC Then
                        If Priest2.Location = priest2LocationC Then
                            Priest2.Location = positionCOfPriest2WhenOnRaft
                            numbersOfCharacterOnTheRaft += 1
                            priest2OnRaft = True
                        End If

                    ElseIf Raft.Location = raftPositionA Then

                        If Priest2.Location = defaultLocationOfPriest2 Then
                            Priest2.Location = raftPositionOfPriest2
                            numbersOfCharacterOnTheRaft += 1
                            priest2OnRaft = True
                        End If


                    End If
                End If
            End If

            If selectedCharacter Is Priest3 Then
                If priest3OnRaft = False Then

                    If Raft.Location = raftPositionC Then
                        If Priest3.Location = priest3LocationC Then
                            Priest3.Location = positionCOfPriest3WhenOnRaft
                            numbersOfCharacterOnTheRaft += 1
                            priest3OnRaft = True
                        End If

                    ElseIf Raft.Location = raftPositionA Then

                        If Priest3.Location = defaultLocationOfPriest3 Then
                            Priest3.Location = raftPositionOfPriest3
                            numbersOfCharacterOnTheRaft += 1
                            priest3OnRaft = True
                        End If

                    End If
                End If
            End If

            If selectedCharacter Is Devil1 Then
                If devil1OnRaft = False Then

                    If Raft.Location = raftPositionC Then
                        If Devil1.Location = devil1LocationC Then
                            Devil1.Location = positionCOfDevil1WhenOnRaft
                            numbersOfCharacterOnTheRaft += 1
                            devil1OnRaft = True
                        End If

                    ElseIf Raft.Location = raftPositionA Then

                        If Devil1.Location = defaultLocationOfDevil1 Then
                            Devil1.Location = raftPositionOfDevil1
                            numbersOfCharacterOnTheRaft += 1
                            devil1OnRaft = True
                        End If

                    End If
                End If
            End If

            If selectedCharacter Is Devil2 Then
                If devil2OnRaft = False Then

                    If Raft.Location = raftPositionC Then
                        If Devil2.Location = devil2LocationC Then
                            Devil2.Location = positionCOfDevil2WhenOnRaft
                            numbersOfCharacterOnTheRaft += 1
                            devil2OnRaft = True
                        End If

                    ElseIf Raft.Location = raftPositionA Then

                        If Devil2.Location = defaultLocationOfDevil2 Then
                            Devil2.Location = raftPositionOfDevil2
                            numbersOfCharacterOnTheRaft += 1
                            devil2OnRaft = True
                        End If

                    End If
                End If
            End If

            If selectedCharacter Is Devil3 Then
                If devil3OnRaft = False Then

                    If Raft.Location = raftPositionC Then
                        If Devil3.Location = devil3LocationC Then
                            Devil3.Location = positionCOfDevil3WhenOnRaft
                            numbersOfCharacterOnTheRaft += 1
                            devil3OnRaft = True
                        End If

                    ElseIf Raft.Location = raftPositionA Then

                        If Devil3.Location = defaultLocationOfDevil3 Then
                            Devil3.Location = raftPositionOfDevil3
                            numbersOfCharacterOnTheRaft += 1
                            devil3OnRaft = True
                        End If

                    End If
                End If
            End If

        Else
            Label1.Text = "It seems the raft is not sturdy enough to accommodate more than 3 passengers."
        End If
    End Sub

    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click
        If gameEnded OrElse raftIsMoving Then Exit Sub

        If selectedCharacter Is Priest1 Then
            If priest1OnRaft = True Then

                If Raft.Location = raftPositionC Then
                    Priest1.Location = priest1LocationC
                Else
                    Priest1.Location = defaultLocationOfPriest1
                End If

                numbersOfCharacterOnTheRaft -= 1
                priest1OnRaft = False
            End If
        End If

        If selectedCharacter Is Priest2 Then
            If priest2OnRaft = True Then

                If Raft.Location = raftPositionC Then
                    Priest2.Location = priest2LocationC
                Else
                    Priest2.Location = defaultLocationOfPriest2
                End If

                numbersOfCharacterOnTheRaft -= 1
                priest2OnRaft = False
            End If
        End If

        If selectedCharacter Is Priest3 Then
            If priest3OnRaft = True Then

                If Raft.Location = raftPositionC Then
                    Priest3.Location = priest3LocationC
                Else
                    Priest3.Location = defaultLocationOfPriest3
                End If

                numbersOfCharacterOnTheRaft -= 1
                priest3OnRaft = False
            End If
        End If

        If selectedCharacter Is Devil1 Then
            If devil1OnRaft = True Then

                If Raft.Location = raftPositionC Then
                    Devil1.Location = devil1LocationC
                Else
                    Devil1.Location = defaultLocationOfDevil1
                End If

                numbersOfCharacterOnTheRaft -= 1
                devil1OnRaft = False
            End If
        End If

        If selectedCharacter Is Devil2 Then
            If devil2OnRaft = True Then

                If Raft.Location = raftPositionC Then
                    Devil2.Location = devil2LocationC
                Else
                    Devil2.Location = defaultLocationOfDevil2
                End If

                numbersOfCharacterOnTheRaft -= 1
                devil2OnRaft = False
            End If
        End If

        If selectedCharacter Is Devil3 Then
            If devil3OnRaft = True Then

                If Raft.Location = raftPositionC Then
                    Devil3.Location = devil3LocationC
                Else
                    Devil3.Location = defaultLocationOfDevil3
                End If

                numbersOfCharacterOnTheRaft -= 1
                devil3OnRaft = False
            End If
        End If

        CheckGame(True)

    End Sub

    'These are the location C of the characters.
    Dim priest1LocationC As New Point(841, 293)
    Dim priest2LocationC As New Point(884, 293)
    Dim priest3LocationC As New Point(927, 293)

    Dim devil1LocationC As New Point(841, 361)
    Dim devil2LocationC As New Point(884, 361)
    Dim devil3LocationC As New Point(927, 361)
    '-------------------------------------------

    'This is for the two location of the raft.
    Dim raftPositionA As New Point(442, 268)
    Dim raftPositionC As New Point(677, 268)

    Dim raftMovingTo As Integer
    '-------------------------------------------

    'This is for the position of each character when the raft is in its position C.
    Dim positionCOfPriest1WhenOnRaft As New Point(690, 293)
    Dim positionCOfPriest2WhenOnRaft As New Point(733, 293)
    Dim positionCOfPriest3WhenOnRaft As New Point(776, 293)

    Dim positionCOfDevil1WhenOnRaft As New Point(689, 361)
    Dim positionCOfDevil2WhenOnRaft As New Point(732, 361)
    Dim positionCOfDevil3WhenOnRaft As New Point(775, 361)
    '-------------------------------------------

    'This is to know if the raft is moving, in order to prevent moving a character when the raft is moving.
    Dim raftIsMoving As Boolean = False
    '-------------------------------------------
    Private Sub MoveRaftBtn_Click(sender As Object, e As EventArgs) Handles MoveRaftBtn.Click

        If gameEnded OrElse raftIsMoving Then Exit Sub

        If numbersOfCharacterOnTheRaft = 0 Then
            Label1.Text = "The raft needs at least one passenger."
            Exit Sub
        End If

        'Check the banks without the departing passengers.
        CheckGame(False)

        If gameEnded Then Exit Sub

        Label1.Text = ""

        If Raft.Location = raftPositionA Then
            raftMovingTo = 1
        ElseIf Raft.Location = raftPositionC Then
            raftMovingTo = 2
        Else
            Exit Sub
        End If

        raftIsMoving = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If raftMovingTo = 1 Then
            Raft.Left += 15
            If priest1OnRaft = True Then
                Priest1.Left += 15
            End If

            If priest2OnRaft = True Then
                Priest2.Left += 15
            End If

            If priest3OnRaft = True Then
                Priest3.Left += 15
            End If

            If devil1OnRaft = True Then
                Devil1.Left += 15
            End If

            If devil2OnRaft = True Then
                Devil2.Left += 15
            End If

            If devil3OnRaft = True Then
                Devil3.Left += 15
            End If

            If Raft.Left >= raftPositionC.X Then
                Raft.Left = raftPositionC.X

                If priest1OnRaft = True Then
                    Priest1.Location = positionCOfPriest1WhenOnRaft
                End If

                If priest2OnRaft = True Then
                    Priest2.Location = positionCOfPriest2WhenOnRaft
                End If

                If priest3OnRaft = True Then
                    Priest3.Location = positionCOfPriest3WhenOnRaft
                End If

                If devil1OnRaft = True Then
                    Devil1.Location = positionCOfDevil1WhenOnRaft
                End If

                If devil2OnRaft = True Then
                    Devil2.Location = positionCOfDevil2WhenOnRaft
                End If

                If devil3OnRaft = True Then
                    Devil3.Location = positionCOfDevil3WhenOnRaft
                End If

                raftIsMoving = False
                Timer1.Stop()
                CheckGame(True)
            End If
        End If

        If raftMovingTo = 2 Then
            Raft.Left -= 15
            If priest1OnRaft = True Then
                Priest1.Left -= 15
            End If

            If priest2OnRaft = True Then
                Priest2.Left -= 15
            End If

            If priest3OnRaft = True Then
                Priest3.Left -= 15
            End If

            If devil1OnRaft = True Then
                Devil1.Left -= 15
            End If

            If devil2OnRaft = True Then
                Devil2.Left -= 15
            End If

            If devil3OnRaft = True Then
                Devil3.Left -= 15
            End If

            If Raft.Left <= raftPositionA.X Then
                Raft.Left = raftPositionA.X

                If priest1OnRaft = True Then
                    Priest1.Location = raftPositionOfPriest1
                End If

                If priest2OnRaft = True Then
                    Priest2.Location = raftPositionOfPriest2
                End If

                If priest3OnRaft = True Then
                    Priest3.Location = raftPositionOfPriest3
                End If

                If devil1OnRaft = True Then
                    Devil1.Location = raftPositionOfDevil1
                End If

                If devil2OnRaft = True Then
                    Devil2.Location = raftPositionOfDevil2
                End If

                If devil3OnRaft = True Then
                    Devil3.Location = raftPositionOfDevil3
                End If

                raftIsMoving = False
                Timer1.Stop()
                CheckGame(True)
            End If
        End If
    End Sub

    Private gameEnded As Boolean = False

    Private Function BankIsUnsafe(priests As Integer,
                                  demons As Integer) As Boolean
        Return priests > 0 AndAlso demons > priests
    End Function

    Private Sub EndGame(message As String)
        gameEnded = True
        Timer1.Stop()
        raftIsMoving = False

        MoveToRaftBtn.Enabled = False
        RemoveBtn.Enabled = False
        MoveRaftBtn.Enabled = False

        Label1.Text = message
        If message.StartsWith("You win!") Then
            Dim answer As DialogResult = MessageBox.Show(
        message & vbCrLf & vbCrLf & "Exit game?",
        "3 Steves and 3 Creepers",
        MessageBoxButtons.YesNo)

            If answer = DialogResult.Yes Then
                Form1.Show()
                Me.Close()
            End If
        Else
            MessageBox.Show(message, "3 Steves and 3 Creepers")
        End If
    End Sub

    Private Sub CheckGame(includeRaftPassengers As Boolean)
        Dim priestsLeft As Integer = 0
        Dim demonsLeft As Integer = 0
        Dim priestsRight As Integer = 0
        Dim demonsRight As Integer = 0

        Dim priests() As PictureBox = {Priest1, Priest2, Priest3}
        Dim demons() As PictureBox = {Devil1, Devil2, Devil3}

        Dim priestLeftPositions() As Point = {
            defaultLocationOfPriest1,
            defaultLocationOfPriest2,
            defaultLocationOfPriest3
        }

        Dim priestRightPositions() As Point = {
            priest1LocationC,
            priest2LocationC,
            priest3LocationC
        }

        Dim demonLeftPositions() As Point = {
            defaultLocationOfDevil1,
            defaultLocationOfDevil2,
            defaultLocationOfDevil3
        }

        Dim demonRightPositions() As Point = {
            devil1LocationC,
            devil2LocationC,
            devil3LocationC
        }

        Dim priestsOnRaft() As Boolean = {
            priest1OnRaft, priest2OnRaft, priest3OnRaft
        }

        Dim demonsOnRaft() As Boolean = {
            devil1OnRaft, devil2OnRaft, devil3OnRaft
        }

        For i As Integer = 0 To 2
            If Not priestsOnRaft(i) Then
                If priests(i).Location = priestLeftPositions(i) Then
                    priestsLeft += 1
                ElseIf priests(i).Location = priestRightPositions(i) Then
                    priestsRight += 1
                End If
            ElseIf includeRaftPassengers Then
                If Raft.Location = raftPositionA Then
                    priestsLeft += 1
                ElseIf Raft.Location = raftPositionC Then
                    priestsRight += 1
                End If
            End If

            If Not demonsOnRaft(i) Then
                If demons(i).Location = demonLeftPositions(i) Then
                    demonsLeft += 1
                ElseIf demons(i).Location = demonRightPositions(i) Then
                    demonsRight += 1
                End If
            ElseIf includeRaftPassengers Then
                If Raft.Location = raftPositionA Then
                    demonsLeft += 1
                ElseIf Raft.Location = raftPositionC Then
                    demonsRight += 1
                End If
            End If
        Next

        If BankIsUnsafe(priestsLeft, demonsLeft) OrElse
           BankIsUnsafe(priestsRight, demonsRight) Then

            EndGame("Game over! Creepers outnumbered Steve on an island.")
            Exit Sub
        End If

        If priestsRight = 3 AndAlso demonsRight = 3 AndAlso
           numbersOfCharacterOnTheRaft = 0 Then

            EndGame("You win! All characters crossed safely.")
        End If
    End Sub

End Class