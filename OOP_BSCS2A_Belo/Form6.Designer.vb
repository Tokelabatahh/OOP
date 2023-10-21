<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Option1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Option2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Option3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Option1ToolStripMenuItem, Me.Option2ToolStripMenuItem, Me.Option3ToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'Option1ToolStripMenuItem
        '
        Me.Option1ToolStripMenuItem.Name = "Option1ToolStripMenuItem"
        Me.Option1ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Option1ToolStripMenuItem.Text = "Option1"
        '
        'Option2ToolStripMenuItem
        '
        Me.Option2ToolStripMenuItem.Name = "Option2ToolStripMenuItem"
        Me.Option2ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Option2ToolStripMenuItem.Text = "Option2"
        '
        'Option3ToolStripMenuItem
        '
        Me.Option3ToolStripMenuItem.Name = "Option3ToolStripMenuItem"
        Me.Option3ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Option3ToolStripMenuItem.Text = "Option3"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Option1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Option2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Option3ToolStripMenuItem As ToolStripMenuItem
End Class
