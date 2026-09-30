<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataTypesAndArithmeticOperators
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataTypesAndArithmeticOperators))
        Panel1 = New Panel()
        RichTextBox1 = New RichTextBox()
        BackBtn = New Button()
        Panel2 = New Panel()
        GroupBox1 = New GroupBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        Label1 = New Label()
        RadioButton1 = New RadioButton()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(RichTextBox1)
        Panel1.Controls.Add(BackBtn)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(504, 649)
        Panel1.TabIndex = 3
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = SystemColors.Control
        RichTextBox1.BorderStyle = BorderStyle.FixedSingle
        RichTextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(13, 15)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(478, 569)
        RichTextBox1.TabIndex = 8
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' BackBtn
        ' 
        BackBtn.FlatStyle = FlatStyle.Flat
        BackBtn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        BackBtn.Location = New Point(13, 590)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(478, 46)
        BackBtn.TabIndex = 7
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(GroupBox1)
        Panel2.Location = New Point(522, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(728, 649)
        Panel2.TabIndex = 10
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(27, 34)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(669, 558)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Simple Calculator"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(440, 121)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 28)
        Label5.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(372, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 28)
        Label4.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(294, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 28)
        Label3.TabIndex = 9
        Label3.Text = "Result:"
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(294, 236)
        Button1.Name = "Button1"
        Button1.Size = New Size(308, 46)
        Button1.TabIndex = 8
        Button1.Text = "Solve"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(294, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 28)
        Label2.TabIndex = 7
        Label2.Text = "Enter 2 Numbers:"
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(477, 119)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 34)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(294, 119)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 34)
        TextBox1.TabIndex = 5
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(72, 250)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(103, 32)
        RadioButton4.TabIndex = 4
        RadioButton4.TabStop = True
        RadioButton4.Text = "Division"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(72, 212)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(155, 32)
        RadioButton3.TabIndex = 3
        RadioButton3.TabStop = True
        RadioButton3.Text = "Multiplication"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(72, 174)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(135, 32)
        RadioButton2.TabIndex = 2
        RadioButton2.TabStop = True
        RadioButton2.Text = "Subtraction"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(54, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 28)
        Label1.TabIndex = 1
        Label1.Text = "Select Operator:"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(72, 136)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(110, 32)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Addition"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' DataTypesAndArithmeticOperators
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._2
        ClientSize = New Size(1262, 673)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "DataTypesAndArithmeticOperators"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Data Types and Arithmetic Operators"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents BackBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
