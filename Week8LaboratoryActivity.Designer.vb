<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week8LaboratoryActivity
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
        Panel2 = New Panel()
        Button4 = New Button()
        GroupBox1 = New GroupBox()
        Button3 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        BackBtn = New Button()
        ColorDialog1 = New ColorDialog()
        FontDialog1 = New FontDialog()
        Panel2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(GroupBox1)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(BackBtn)
        Panel2.Location = New Point(12, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1238, 649)
        Panel2.TabIndex = 22
        ' 
        ' Button4
        ' 
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(247, 56)
        Button4.Name = "Button4"
        Button4.Size = New Size(229, 44)
        Button4.TabIndex = 11
        Button4.Text = "Clear Text"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Location = New Point(12, 106)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1213, 471)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(896, 421)
        Button3.Name = "Button3"
        Button3.Size = New Size(311, 44)
        Button3.TabIndex = 11
        Button3.Text = "Change Text Color"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(579, 421)
        Button2.Name = "Button2"
        Button2.Size = New Size(311, 44)
        Button2.TabIndex = 10
        Button2.Text = "Change Font Style"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 81)
        Label1.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(12, 56)
        Button1.Name = "Button1"
        Button1.Size = New Size(229, 44)
        Button1.TabIndex = 8
        Button1.Text = "Enter Text"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(12, 16)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(464, 34)
        TextBox1.TabIndex = 7
        ' 
        ' BackBtn
        ' 
        BackBtn.FlatStyle = FlatStyle.Flat
        BackBtn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        BackBtn.Location = New Point(12, 583)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(1213, 46)
        BackBtn.TabIndex = 6
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = True
        ' 
        ' Week8LaboratoryActivity
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._2
        ClientSize = New Size(1262, 673)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Week8LaboratoryActivity"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week 8 - Laboratory Activity"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BackBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents Button4 As Button
End Class
