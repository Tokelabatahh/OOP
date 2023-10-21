<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFunctions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRef = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSub = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuFunctions})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuFile.Size = New System.Drawing.Size(40, 20)
        Me.mnuFile.Text = "File "
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuClose.Size = New System.Drawing.Size(145, 22)
        Me.mnuClose.Text = "Close"
        '
        'mnuFunctions
        '
        Me.mnuFunctions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRef, Me.mnuVal, Me.mnuSub})
        Me.mnuFunctions.Name = "mnuFunctions"
        Me.mnuFunctions.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuFunctions.Size = New System.Drawing.Size(71, 20)
        Me.mnuFunctions.Text = "Functions"
        '
        'mnuRef
        '
        Me.mnuRef.Name = "mnuRef"
        Me.mnuRef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuRef.Size = New System.Drawing.Size(209, 22)
        Me.mnuRef.Text = "Pass by Reference"
        '
        'mnuVal
        '
        Me.mnuVal.Name = "mnuVal"
        Me.mnuVal.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuVal.Size = New System.Drawing.Size(209, 22)
        Me.mnuVal.Text = "Pass by Value "
        '
        'mnuSub
        '
        Me.mnuSub.Name = "mnuSub"
        Me.mnuSub.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSub.Size = New System.Drawing.Size(209, 22)
        Me.mnuSub.Text = "Sub Procedure "
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Private WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents mnuFunctions As ToolStripMenuItem
    Friend WithEvents mnuRef As ToolStripMenuItem
    Friend WithEvents mnuVal As ToolStripMenuItem
    Friend WithEvents mnuSub As ToolStripMenuItem
End Class
