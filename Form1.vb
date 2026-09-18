Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Controls.Add(MenuStrip1)

        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.BackColor = Color.Transparent
        MenuStrip1.Renderer = New TransparentMenuRenderer()

        MenuStrip1.BringToFront()

        MenuStrip1.ForeColor = ColorTranslator.FromHtml(273728)


        LessonsToolStripMenuItem.DropDown.BackColor = Color.White
        LessonsToolStripMenuItem.DropDown.ForeColor = Color.Black

        AddHandler LessonsToolStripMenuItem.DropDown.Opening, AddressOf LessonsDropDown_Opening

    End Sub

    'This code is for the rounded corners of the dropdown menu
    Private Sub LessonsDropDown_Opening(sender As Object, e As CancelEventArgs)

        Dim menu As ToolStripDropDown = DirectCast(sender, ToolStripDropDown)

        Dim radius As Integer = 15

        Dim path As New GraphicsPath()

        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(menu.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(menu.Width - radius, menu.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, menu.Height - radius, radius, radius, 90, 90)

        path.CloseFigure()

        menu.Region = New Region(path)

    End Sub

    Private Sub AClassesAndObjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AClassesAndObjectsToolStripMenuItem.Click
        ClassesAndObjects.Show()
        Me.Hide()
    End Sub

    Private Sub BEncapsulationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BEncapsulationToolStripMenuItem.Click
        Encapsulation.Show()
        Me.Hide()
    End Sub

    Private Sub CInheritanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CInheritanceToolStripMenuItem.Click
        Inheritance.Show()
        Me.Hide()
    End Sub

    Private Sub DPolymorphismToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DPolymorphismToolStripMenuItem.Click
        Polymorphism.Show()
        Me.Hide()
    End Sub

    Private Sub GameLevel1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GameLevel1ToolStripMenuItem.Click
        AnimationGameLevel1.Show()
        Me.Hide()
    End Sub

    Private Sub DefiningComputerProgrammingAndTranslatorOfProgrammingLangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefiningComputerProgrammingAndTranslatorOfProgrammingLangToolStripMenuItem.Click
        DefiningComputerProgrammingAndTranslatorOfProgrammingLanguage.Show()
        Me.Hide()
    End Sub

    Private Sub WhatIsAProgramMadeOfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhatIsAProgramMadeOfToolStripMenuItem.Click
        WhatIsAProgramMadeOf.Show()
        Me.Hide()
    End Sub

    Private Sub VisualBasic2022IDEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualBasic2022IDEToolStripMenuItem.Click
        IntegratedDevelopmentEnvironment.Show()
        Me.Hide()
    End Sub

    Private Sub ClassOrientationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassOrientationToolStripMenuItem.Click
        Class_Orientation.Show()
        Me.Hide()
    End Sub

    Private Sub AVBNetBasicControlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AVBNetBasicControlsToolStripMenuItem.Click
        VBNetBasicControls.Show()
        Me.Hide()
    End Sub

    Private Sub BContrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BContrToolStripMenuItem.Click
        ControlProperties.Show()
        Me.Hide()
    End Sub

    Private Sub CControlMethodsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CControlMethodsToolStripMenuItem.Click
        ControlMethod.Show()
        Me.Hide()
    End Sub

    Private Sub DControlEventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DControlEventsToolStripMenuItem.Click
        ControlEvents.Show()
        Me.Hide()
    End Sub

    Private Sub EFormPropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EFormPropertiesToolStripMenuItem.Click
        FormProperties.Show()
        Me.Hide()
    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click
        Variables.Show()
        Me.Hide()
    End Sub

    Private Sub BConstantModifiersStatementAndDirectivesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BConstantModifiersStatementAndDirectivesToolStripMenuItem.Click
        Constants.Show()
        Me.Hide()
    End Sub

    Private Sub COperatorsAndDataTypesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COperatorsAndDataTypesToolStripMenuItem.Click
        DataTypesAndArithmeticOperators.Show()
        Me.Hide()
    End Sub

    Private Sub DConvertingDataTypesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DConvertingDataTypesToolStripMenuItem.Click
        ConvertingDataTypes.Show()
        Me.Hide()
    End Sub

    Private Sub ADecisionStatementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADecisionStatementsToolStripMenuItem.Click
        DecisionStatements.Show()
        Me.Hide()
    End Sub

    Private Sub BRelationalOperatorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BRelationalOperatorsToolStripMenuItem.Click
        RelationalOperators.Show()
        Me.Hide()
    End Sub

    Private Sub CBooleanExpressionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CBooleanExpressionsToolStripMenuItem.Click
        BooleanExpressions.Show()
        Me.Hide()
    End Sub

    Private Sub DUsingRelationalOperatorsWithMathOperatorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DUsingRelationalOperatorsWithMathOperatorsToolStripMenuItem.Click
        UsingRelationalOperatorsWithMathOperators.Show()
        Me.Hide()
    End Sub

    Private Sub ELogicalOperatorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELogicalOperatorsToolStripMenuItem.Click
        LogicalOperators.Show()
        Me.Hide()
    End Sub

    Private Sub FLoopingStatementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FLoopingStatementToolStripMenuItem.Click
        LoopingStatements.Show()
        Me.Hide()
    End Sub
End Class
