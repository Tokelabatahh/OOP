<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.opt50 = New System.Windows.Forms.RadioButton()
        Me.opt40 = New System.Windows.Forms.RadioButton()
        Me.opt30 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsalary = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnprocess = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lblbonus = New System.Windows.Forms.Label()
        Me.lblpay = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.opt50)
        Me.GroupBox1.Controls.Add(Me.opt40)
        Me.GroupBox1.Controls.Add(Me.opt30)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 124)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(302, 230)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bonus Percentage "
        '
        'opt50
        '
        Me.opt50.AutoSize = True
        Me.opt50.Enabled = False
        Me.opt50.Location = New System.Drawing.Point(45, 175)
        Me.opt50.Margin = New System.Windows.Forms.Padding(5)
        Me.opt50.Name = "opt50"
        Me.opt50.Size = New System.Drawing.Size(62, 24)
        Me.opt50.TabIndex = 2
        Me.opt50.TabStop = True
        Me.opt50.Text = "50%"
        Me.opt50.UseVisualStyleBackColor = True
        '
        'opt40
        '
        Me.opt40.AutoSize = True
        Me.opt40.Enabled = False
        Me.opt40.Location = New System.Drawing.Point(45, 109)
        Me.opt40.Margin = New System.Windows.Forms.Padding(5)
        Me.opt40.Name = "opt40"
        Me.opt40.Size = New System.Drawing.Size(62, 24)
        Me.opt40.TabIndex = 1
        Me.opt40.TabStop = True
        Me.opt40.Text = "40%"
        Me.opt40.UseVisualStyleBackColor = True
        '
        'opt30
        '
        Me.opt30.AutoSize = True
        Me.opt30.Enabled = False
        Me.opt30.Location = New System.Drawing.Point(45, 48)
        Me.opt30.Margin = New System.Windows.Forms.Padding(5)
        Me.opt30.Name = "opt30"
        Me.opt30.Size = New System.Drawing.Size(62, 24)
        Me.opt30.TabIndex = 0
        Me.opt30.TabStop = True
        Me.opt30.Text = "30%"
        Me.opt30.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(306, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bonus Calculator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(399, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Salary:"
        '
        'txtsalary
        '
        Me.txtsalary.Location = New System.Drawing.Point(495, 128)
        Me.txtsalary.Margin = New System.Windows.Forms.Padding(5)
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.Size = New System.Drawing.Size(164, 26)
        Me.txtsalary.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(399, 181)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Bonus:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(375, 237)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Total Pay:"
        '
        'btnprocess
        '
        Me.btnprocess.Location = New System.Drawing.Point(197, 411)
        Me.btnprocess.Name = "btnprocess"
        Me.btnprocess.Size = New System.Drawing.Size(93, 34)
        Me.btnprocess.TabIndex = 6
        Me.btnprocess.Text = "&Process"
        Me.btnprocess.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(403, 411)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 34)
        Me.btnclose.TabIndex = 7
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lblbonus
        '
        Me.lblbonus.AutoSize = True
        Me.lblbonus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblbonus.Location = New System.Drawing.Point(495, 181)
        Me.lblbonus.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblbonus.Name = "lblbonus"
        Me.lblbonus.Size = New System.Drawing.Size(36, 22)
        Me.lblbonus.TabIndex = 8
        Me.lblbonus.Text = "0.0"
        '
        'lblpay
        '
        Me.lblpay.AutoSize = True
        Me.lblpay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblpay.Location = New System.Drawing.Point(495, 233)
        Me.lblpay.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblpay.Name = "lblpay"
        Me.lblpay.Size = New System.Drawing.Size(36, 22)
        Me.lblpay.TabIndex = 9
        Me.lblpay.Text = "0.0"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 511)
        Me.Controls.Add(Me.lblpay)
        Me.Controls.Add(Me.lblbonus)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnprocess)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtsalary)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form2"
        Me.Text = "Bonus Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents opt50 As RadioButton
    Friend WithEvents opt40 As RadioButton
    Friend WithEvents opt30 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsalary As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnprocess As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents lblbonus As Label
    Friend WithEvents lblpay As Label
End Class
