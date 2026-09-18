<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsingRelationalOperatorsWithMathOperators
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsingRelationalOperatorsWithMathOperators))
        Panel1 = New Panel()
        RichTextBox2 = New RichTextBox()
        Button1 = New Button()
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
        Panel1.Controls.Add(RichTextBox2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(522, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(728, 649)
        Panel1.TabIndex = 14
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.BackColor = SystemColors.Control
        RichTextBox2.BorderStyle = BorderStyle.FixedSingle
        RichTextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox2.Location = New Point(13, 145)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.ReadOnly = True
        RichTextBox2.Size = New Size(701, 190)
        RichTextBox2.TabIndex = 8
        RichTextBox2.Text = "intA = 5" & vbLf & "intB = 1" & vbLf & "intC = 5" & vbLf & "intD = 1" & vbLf & vbLf & "Is (intA + intB) greater than (intC - intD) ?"
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Button1.Location = New Point(13, 341)
        Button1.Name = "Button1"
        Button1.Size = New Size(701, 46)
        Button1.TabIndex = 7
        Button1.Text = "Execute"
        Button1.UseVisualStyleBackColor = True
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
        Panel2.TabIndex = 13
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
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(10, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(471, 28)
        Label1.TabIndex = 3
        Label1.Text = "Using Relational Operators with Math Operators"
        ' 
        ' UsingRelationalOperatorsWithMathOperators
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._2
        ClientSize = New Size(1262, 673)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "UsingRelationalOperatorsWithMathOperators"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Using Relational Operators with Math Operators"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BackBtn As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Button1 As Button
End Class
