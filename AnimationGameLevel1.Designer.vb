<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnimationGameLevel1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        BackBtn = New Button()
        IslandB = New PictureBox()
        Raft = New PictureBox()
        Priest1 = New PictureBox()
        Priest2 = New PictureBox()
        Priest3 = New PictureBox()
        Devil1 = New PictureBox()
        Devil2 = New PictureBox()
        Devil3 = New PictureBox()
        MoveToRaftBtn = New Button()
        MoveRaftBtn = New Button()
        ResetBtn = New Button()
        Label1 = New Label()
        RemoveBtn = New Button()
        Timer1 = New Timer(components)
        IslandA = New PictureBox()
        CType(IslandB, ComponentModel.ISupportInitialize).BeginInit()
        CType(Raft, ComponentModel.ISupportInitialize).BeginInit()
        CType(Priest1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Priest2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Priest3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Devil1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Devil2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Devil3, ComponentModel.ISupportInitialize).BeginInit()
        CType(IslandA, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BackBtn
        ' 
        BackBtn.FlatStyle = FlatStyle.Flat
        BackBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        BackBtn.Location = New Point(12, 12)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(130, 44)
        BackBtn.TabIndex = 0
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = True
        ' 
        ' IslandB
        ' 
        IslandB.BackColor = Color.Transparent
        IslandB.Location = New Point(830, -2)
        IslandB.Name = "IslandB"
        IslandB.Size = New Size(432, 676)
        IslandB.TabIndex = 2
        IslandB.TabStop = False
        ' 
        ' Raft
        ' 
        Raft.BackColor = Color.BurlyWood
        Raft.Image = My.Resources.Resources.Raft2
        Raft.Location = New Point(677, 268)
        Raft.Name = "Raft"
        Raft.Size = New Size(144, 144)
        Raft.TabIndex = 3
        Raft.TabStop = False
        ' 
        ' Priest1
        ' 
        Priest1.BackColor = Color.Yellow
        Priest1.Image = My.Resources.Resources.Steve
        Priest1.Location = New Point(841, 293)
        Priest1.Name = "Priest1"
        Priest1.Size = New Size(32, 32)
        Priest1.SizeMode = PictureBoxSizeMode.AutoSize
        Priest1.TabIndex = 4
        Priest1.TabStop = False
        ' 
        ' Priest2
        ' 
        Priest2.BackColor = Color.Yellow
        Priest2.Image = My.Resources.Resources.Steve
        Priest2.Location = New Point(884, 293)
        Priest2.Name = "Priest2"
        Priest2.Size = New Size(32, 32)
        Priest2.SizeMode = PictureBoxSizeMode.AutoSize
        Priest2.TabIndex = 5
        Priest2.TabStop = False
        ' 
        ' Priest3
        ' 
        Priest3.BackColor = Color.White
        Priest3.Image = My.Resources.Resources.Steve
        Priest3.Location = New Point(927, 293)
        Priest3.Name = "Priest3"
        Priest3.Size = New Size(32, 32)
        Priest3.SizeMode = PictureBoxSizeMode.AutoSize
        Priest3.TabIndex = 6
        Priest3.TabStop = False
        ' 
        ' Devil1
        ' 
        Devil1.BackColor = Color.Red
        Devil1.Image = My.Resources.Resources.Creeper
        Devil1.Location = New Point(841, 361)
        Devil1.Name = "Devil1"
        Devil1.Size = New Size(32, 32)
        Devil1.SizeMode = PictureBoxSizeMode.AutoSize
        Devil1.TabIndex = 7
        Devil1.TabStop = False
        ' 
        ' Devil2
        ' 
        Devil2.BackColor = Color.Red
        Devil2.Image = My.Resources.Resources.Creeper
        Devil2.Location = New Point(884, 361)
        Devil2.Name = "Devil2"
        Devil2.Size = New Size(32, 32)
        Devil2.SizeMode = PictureBoxSizeMode.AutoSize
        Devil2.TabIndex = 8
        Devil2.TabStop = False
        ' 
        ' Devil3
        ' 
        Devil3.BackColor = Color.Red
        Devil3.Image = My.Resources.Resources.Creeper
        Devil3.Location = New Point(927, 361)
        Devil3.Name = "Devil3"
        Devil3.Size = New Size(32, 32)
        Devil3.SizeMode = PictureBoxSizeMode.AutoSize
        Devil3.TabIndex = 9
        Devil3.TabStop = False
        ' 
        ' MoveToRaftBtn
        ' 
        MoveToRaftBtn.FlatStyle = FlatStyle.Flat
        MoveToRaftBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        MoveToRaftBtn.Location = New Point(435, 580)
        MoveToRaftBtn.Name = "MoveToRaftBtn"
        MoveToRaftBtn.Size = New Size(93, 81)
        MoveToRaftBtn.TabIndex = 10
        MoveToRaftBtn.Text = "Move to Raft"
        MoveToRaftBtn.UseVisualStyleBackColor = True
        ' 
        ' MoveRaftBtn
        ' 
        MoveRaftBtn.FlatStyle = FlatStyle.Flat
        MoveRaftBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        MoveRaftBtn.Location = New Point(633, 580)
        MoveRaftBtn.Name = "MoveRaftBtn"
        MoveRaftBtn.Size = New Size(93, 81)
        MoveRaftBtn.TabIndex = 11
        MoveRaftBtn.Text = "Move Raft"
        MoveRaftBtn.UseVisualStyleBackColor = True
        ' 
        ' ResetBtn
        ' 
        ResetBtn.FlatStyle = FlatStyle.Flat
        ResetBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        ResetBtn.Location = New Point(732, 580)
        ResetBtn.Name = "ResetBtn"
        ResetBtn.Size = New Size(93, 81)
        ResetBtn.TabIndex = 12
        ResetBtn.Text = "Reset"
        ResetBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(1, 540)
        Label1.Name = "Label1"
        Label1.Size = New Size(1261, 24)
        Label1.TabIndex = 13
        Label1.Text = "Label1"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RemoveBtn
        ' 
        RemoveBtn.FlatStyle = FlatStyle.Flat
        RemoveBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        RemoveBtn.Location = New Point(534, 580)
        RemoveBtn.Name = "RemoveBtn"
        RemoveBtn.Size = New Size(93, 81)
        RemoveBtn.TabIndex = 14
        RemoveBtn.Text = "Remove from Raft"
        RemoveBtn.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' IslandA
        ' 
        IslandA.BackColor = Color.Transparent
        IslandA.Location = New Point(-109, -2)
        IslandA.Name = "IslandA"
        IslandA.Size = New Size(534, 676)
        IslandA.SizeMode = PictureBoxSizeMode.CenterImage
        IslandA.TabIndex = 1
        IslandA.TabStop = False
        ' 
        ' AnimationGameLevel1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        BackgroundImage = My.Resources.Resources.BG12
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1262, 673)
        Controls.Add(RemoveBtn)
        Controls.Add(BackBtn)
        Controls.Add(Label1)
        Controls.Add(ResetBtn)
        Controls.Add(MoveRaftBtn)
        Controls.Add(MoveToRaftBtn)
        Controls.Add(Devil3)
        Controls.Add(Devil2)
        Controls.Add(Devil1)
        Controls.Add(Priest3)
        Controls.Add(Priest2)
        Controls.Add(Priest1)
        Controls.Add(Raft)
        Controls.Add(IslandB)
        Controls.Add(IslandA)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "AnimationGameLevel1"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Animation - Game: Level 1"
        CType(IslandB, ComponentModel.ISupportInitialize).EndInit()
        CType(Raft, ComponentModel.ISupportInitialize).EndInit()
        CType(Priest1, ComponentModel.ISupportInitialize).EndInit()
        CType(Priest2, ComponentModel.ISupportInitialize).EndInit()
        CType(Priest3, ComponentModel.ISupportInitialize).EndInit()
        CType(Devil1, ComponentModel.ISupportInitialize).EndInit()
        CType(Devil2, ComponentModel.ISupportInitialize).EndInit()
        CType(Devil3, ComponentModel.ISupportInitialize).EndInit()
        CType(IslandA, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BackBtn As Button
    Friend WithEvents IslandB As PictureBox
    Friend WithEvents Raft As PictureBox
    Friend WithEvents Priest1 As PictureBox
    Friend WithEvents Priest2 As PictureBox
    Friend WithEvents Priest3 As PictureBox
    Friend WithEvents Devil1 As PictureBox
    Friend WithEvents Devil2 As PictureBox
    Friend WithEvents Devil3 As PictureBox
    Friend WithEvents MoveToRaftBtn As Button
    Friend WithEvents MoveRaftBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RemoveBtn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents IslandA As PictureBox
End Class
