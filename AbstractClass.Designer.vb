<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbstractClass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AbstractClass))
        Panel1 = New Panel()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        RichTextBox2 = New RichTextBox()
        TabPage2 = New TabPage()
        RichTextBox3 = New RichTextBox()
        TabPage3 = New TabPage()
        Button1 = New Button()
        RichTextBox4 = New RichTextBox()
        Panel2 = New Panel()
        BackBtn = New Button()
        RichTextBox1 = New RichTextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(TabControl1)
        Panel1.Location = New Point(522, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(728, 649)
        Panel1.TabIndex = 18
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(13, 16)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(701, 613)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BorderStyle = BorderStyle.FixedSingle
        TabPage1.Controls.Add(RichTextBox2)
        TabPage1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabPage1.Location = New Point(4, 37)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(693, 572)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Vehicle.vb"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.BorderStyle = BorderStyle.FixedSingle
        RichTextBox2.Location = New Point(-1, -1)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(693, 576)
        RichTextBox2.TabIndex = 0
        RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(RichTextBox3)
        TabPage2.Location = New Point(4, 37)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(693, 572)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Car.vb"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox3
        ' 
        RichTextBox3.BorderStyle = BorderStyle.FixedSingle
        RichTextBox3.Location = New Point(0, 0)
        RichTextBox3.Name = "RichTextBox3"
        RichTextBox3.Size = New Size(693, 576)
        RichTextBox3.TabIndex = 1
        RichTextBox3.Text = resources.GetString("RichTextBox3.Text")
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.White
        TabPage3.Controls.Add(Button1)
        TabPage3.Controls.Add(RichTextBox4)
        TabPage3.Location = New Point(4, 37)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(693, 572)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Form1.vb"
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Button1.Location = New Point(111, 396)
        Button1.Name = "Button1"
        Button1.Size = New Size(477, 46)
        Button1.TabIndex = 7
        Button1.Text = "Click Me!"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox4
        ' 
        RichTextBox4.BorderStyle = BorderStyle.None
        RichTextBox4.Location = New Point(6, 6)
        RichTextBox4.Name = "RichTextBox4"
        RichTextBox4.Size = New Size(681, 285)
        RichTextBox4.TabIndex = 2
        RichTextBox4.Text = resources.GetString("RichTextBox4.Text")
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
        Panel2.TabIndex = 17
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
        Label1.Size = New Size(145, 28)
        Label1.TabIndex = 3
        Label1.Text = "Abstract Class"
        ' 
        ' AbstractClass
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._2
        ClientSize = New Size(1262, 673)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "AbstractClass"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Abstract Class"
        Panel1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BackBtn As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents Button1 As Button
End Class
