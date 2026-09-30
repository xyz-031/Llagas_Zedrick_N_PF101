<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaboratoryExercise
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
        Panel1 = New Panel()
        ListBox1 = New ListBox()
        lblSeconds = New Label()
        lblMinutes = New Label()
        lblHours = New Label()
        Panel2 = New Panel()
        BackBtn = New Button()
        RichTextBox1 = New RichTextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(ListBox1)
        Panel1.Controls.Add(lblSeconds)
        Panel1.Controls.Add(lblMinutes)
        Panel1.Controls.Add(lblHours)
        Panel1.Location = New Point(522, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(728, 649)
        Panel1.TabIndex = 20
        ' 
        ' ListBox1
        ' 
        ListBox1.BorderStyle = BorderStyle.FixedSingle
        ListBox1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 28
        ListBox1.Location = New Point(52, 42)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(621, 534)
        ListBox1.TabIndex = 3
        ' 
        ' lblSeconds
        ' 
        lblSeconds.AutoSize = True
        lblSeconds.Font = New Font("Segoe UI Semibold", 36F, FontStyle.Bold)
        lblSeconds.Location = New Point(532, 288)
        lblSeconds.Name = "lblSeconds"
        lblSeconds.Size = New Size(0, 81)
        lblSeconds.TabIndex = 2
        ' 
        ' lblMinutes
        ' 
        lblMinutes.AutoSize = True
        lblMinutes.Font = New Font("Segoe UI Semibold", 36F, FontStyle.Bold)
        lblMinutes.Location = New Point(371, 288)
        lblMinutes.Name = "lblMinutes"
        lblMinutes.Size = New Size(0, 81)
        lblMinutes.TabIndex = 1
        ' 
        ' lblHours
        ' 
        lblHours.AutoSize = True
        lblHours.Font = New Font("Segoe UI Semibold", 36F, FontStyle.Bold)
        lblHours.Location = New Point(202, 288)
        lblHours.Name = "lblHours"
        lblHours.Size = New Size(0, 81)
        lblHours.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(BackBtn)
        Panel2.Controls.Add(RichTextBox1)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(12, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(504, 649)
        Panel2.TabIndex = 19
        ' 
        ' BackBtn
        ' 
        BackBtn.FlatStyle = FlatStyle.Flat
        BackBtn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        BackBtn.Location = New Point(12, 583)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(477, 46)
        BackBtn.TabIndex = 6
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.FixedSingle
        RichTextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(12, 42)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(477, 535)
        RichTextBox1.TabIndex = 2
        RichTextBox1.Text = "Create an array program that output the months in a listbox."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(10, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 28)
        Label1.TabIndex = 3
        Label1.Text = "Laboratory Exercise"
        ' 
        ' LaboratoryExercise
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._2
        ClientSize = New Size(1262, 673)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "LaboratoryExercise"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Laboratory Exercise"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSeconds As Label
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BackBtn As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
End Class
