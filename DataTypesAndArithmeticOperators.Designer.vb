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
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(RichTextBox1)
        Panel1.Controls.Add(BackBtn)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1238, 649)
        Panel1.TabIndex = 3
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = SystemColors.Control
        RichTextBox1.BorderStyle = BorderStyle.FixedSingle
        RichTextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(13, 15)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(1212, 569)
        RichTextBox1.TabIndex = 8
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' BackBtn
        ' 
        BackBtn.FlatStyle = FlatStyle.Flat
        BackBtn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        BackBtn.Location = New Point(13, 590)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(1212, 46)
        BackBtn.TabIndex = 7
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = True
        ' 
        ' DataTypesAndArithmeticOperators
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._2
        ClientSize = New Size(1262, 673)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "DataTypesAndArithmeticOperators"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Data Types and Arithmetic Operators"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents BackBtn As Button
End Class
