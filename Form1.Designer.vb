<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_form))
        Me.cmd_start = New System.Windows.Forms.Button()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.main_menu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.com_keys = New System.Windows.Forms.ComboBox()
        Me.com_time = New System.Windows.Forms.ComboBox()
        Me.press_timer = New System.Windows.Forms.Timer(Me.components)
        Me.notifi_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowMainWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideMainWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmd_stop = New System.Windows.Forms.Button()
        Me.main_menu.SuspendLayout()
        Me.notifi_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_start
        '
        Me.cmd_start.Location = New System.Drawing.Point(199, 88)
        Me.cmd_start.Name = "cmd_start"
        Me.cmd_start.Size = New System.Drawing.Size(52, 23)
        Me.cmd_start.TabIndex = 0
        Me.cmd_start.Text = "Start"
        Me.cmd_start.UseVisualStyleBackColor = True
        '
        'NotifyIcon
        '
        Me.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "ATP Notifications"
        Me.NotifyIcon.Visible = True
        '
        'main_menu
        '
        Me.main_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.main_menu.Location = New System.Drawing.Point(0, 0)
        Me.main_menu.Name = "main_menu"
        Me.main_menu.Size = New System.Drawing.Size(264, 24)
        Me.main_menu.TabIndex = 1
        Me.main_menu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Key to press"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Interval in seconds"
        '
        'com_keys
        '
        Me.com_keys.FormattingEnabled = True
        Me.com_keys.Location = New System.Drawing.Point(130, 34)
        Me.com_keys.Name = "com_keys"
        Me.com_keys.Size = New System.Drawing.Size(121, 21)
        Me.com_keys.TabIndex = 4
        '
        'com_time
        '
        Me.com_time.FormattingEnabled = True
        Me.com_time.Location = New System.Drawing.Point(130, 61)
        Me.com_time.Name = "com_time"
        Me.com_time.Size = New System.Drawing.Size(121, 21)
        Me.com_time.TabIndex = 5
        '
        'press_timer
        '
        '
        'notifi_menu
        '
        Me.notifi_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.StartToolStripMenuItem, Me.ShowMainWindowToolStripMenuItem, Me.HideMainWindowToolStripMenuItem, Me.ExitAppToolStripMenuItem})
        Me.notifi_menu.Name = "notifi_menu"
        Me.notifi_menu.Size = New System.Drawing.Size(181, 136)
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.FileToolStripMenuItem1.Text = "Stop"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'ShowMainWindowToolStripMenuItem
        '
        Me.ShowMainWindowToolStripMenuItem.Name = "ShowMainWindowToolStripMenuItem"
        Me.ShowMainWindowToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ShowMainWindowToolStripMenuItem.Text = "Show Main Window"
        '
        'HideMainWindowToolStripMenuItem
        '
        Me.HideMainWindowToolStripMenuItem.Name = "HideMainWindowToolStripMenuItem"
        Me.HideMainWindowToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HideMainWindowToolStripMenuItem.Text = "Hide Main Window"
        '
        'ExitAppToolStripMenuItem
        '
        Me.ExitAppToolStripMenuItem.Name = "ExitAppToolStripMenuItem"
        Me.ExitAppToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitAppToolStripMenuItem.Text = "Exit App"
        '
        'cmd_stop
        '
        Me.cmd_stop.Location = New System.Drawing.Point(130, 88)
        Me.cmd_stop.Name = "cmd_stop"
        Me.cmd_stop.Size = New System.Drawing.Size(52, 23)
        Me.cmd_stop.TabIndex = 6
        Me.cmd_stop.Text = "Stop"
        Me.cmd_stop.UseVisualStyleBackColor = True
        '
        'main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 127)
        Me.Controls.Add(Me.cmd_stop)
        Me.Controls.Add(Me.com_time)
        Me.Controls.Add(Me.com_keys)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_start)
        Me.Controls.Add(Me.main_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.main_menu
        Me.Name = "main_form"
        Me.Text = "Auto Key Presser"
        Me.main_menu.ResumeLayout(False)
        Me.main_menu.PerformLayout()
        Me.notifi_menu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_start As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents main_menu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents com_keys As System.Windows.Forms.ComboBox
    Friend WithEvents com_time As System.Windows.Forms.ComboBox
    Friend WithEvents press_timer As System.Windows.Forms.Timer
    Friend WithEvents notifi_menu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowMainWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideMainWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitAppToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmd_stop As System.Windows.Forms.Button

End Class
