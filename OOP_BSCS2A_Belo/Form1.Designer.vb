<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optsolo = New System.Windows.Forms.RadioButton()
        Me.optdouble = New System.Windows.Forms.RadioButton()
        Me.optfamily = New System.Windows.Forms.RadioButton()
        Me.chkpineapple = New System.Windows.Forms.CheckBox()
        Me.chkcheese = New System.Windows.Forms.CheckBox()
        Me.chkbacon = New System.Windows.Forms.CheckBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optfamily)
        Me.GroupBox1.Controls.Add(Me.optdouble)
        Me.GroupBox1.Controls.Add(Me.optsolo)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 150)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pizza Size"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkbacon)
        Me.GroupBox2.Controls.Add(Me.chkcheese)
        Me.GroupBox2.Controls.Add(Me.chkpineapple)
        Me.GroupBox2.Location = New System.Drawing.Point(285, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 150)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Toppings"
        '
        'optsolo
        '
        Me.optsolo.AutoSize = True
        Me.optsolo.Location = New System.Drawing.Point(17, 40)
        Me.optsolo.Name = "optsolo"
        Me.optsolo.Size = New System.Drawing.Size(70, 28)
        Me.optsolo.TabIndex = 0
        Me.optsolo.TabStop = True
        Me.optsolo.Text = "Solo"
        Me.optsolo.UseVisualStyleBackColor = True
        '
        'optdouble
        '
        Me.optdouble.AutoSize = True
        Me.optdouble.Location = New System.Drawing.Point(17, 70)
        Me.optdouble.Name = "optdouble"
        Me.optdouble.Size = New System.Drawing.Size(95, 28)
        Me.optdouble.TabIndex = 1
        Me.optdouble.TabStop = True
        Me.optdouble.Text = "Double"
        Me.optdouble.UseVisualStyleBackColor = True
        '
        'optfamily
        '
        Me.optfamily.AutoSize = True
        Me.optfamily.Location = New System.Drawing.Point(17, 104)
        Me.optfamily.Name = "optfamily"
        Me.optfamily.Size = New System.Drawing.Size(89, 28)
        Me.optfamily.TabIndex = 2
        Me.optfamily.TabStop = True
        Me.optfamily.Text = "Family"
        Me.optfamily.UseVisualStyleBackColor = True
        '
        'chkpineapple
        '
        Me.chkpineapple.AutoSize = True
        Me.chkpineapple.Location = New System.Drawing.Point(33, 40)
        Me.chkpineapple.Name = "chkpineapple"
        Me.chkpineapple.Size = New System.Drawing.Size(123, 28)
        Me.chkpineapple.TabIndex = 0
        Me.chkpineapple.Text = "Pineapple"
        Me.chkpineapple.UseVisualStyleBackColor = True
        '
        'chkcheese
        '
        Me.chkcheese.AutoSize = True
        Me.chkcheese.Location = New System.Drawing.Point(33, 70)
        Me.chkcheese.Name = "chkcheese"
        Me.chkcheese.Size = New System.Drawing.Size(101, 28)
        Me.chkcheese.TabIndex = 1
        Me.chkcheese.Text = "Cheese"
        Me.chkcheese.UseVisualStyleBackColor = True
        '
        'chkbacon
        '
        Me.chkbacon.AutoSize = True
        Me.chkbacon.Location = New System.Drawing.Point(33, 104)
        Me.chkbacon.Name = "chkbacon"
        Me.chkbacon.Size = New System.Drawing.Size(88, 28)
        Me.chkbacon.TabIndex = 2
        Me.chkbacon.Text = "Bacon"
        Me.chkbacon.UseVisualStyleBackColor = True
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(81, 296)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(88, 31)
        Me.btnsubmit.TabIndex = 2
        Me.btnsubmit.Text = "&Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(285, 296)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(92, 30)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 411)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form1"
        Me.Text = "PIZZA PROGRAM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optfamily As RadioButton
    Friend WithEvents optdouble As RadioButton
    Friend WithEvents optsolo As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkbacon As CheckBox
    Friend WithEvents chkcheese As CheckBox
    Friend WithEvents chkpineapple As CheckBox
    Friend WithEvents btnsubmit As Button
    Friend WithEvents btnclose As Button
End Class
