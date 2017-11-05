<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.main_menu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comKeys = New System.Windows.Forms.ComboBox()
        Me.comTime = New System.Windows.Forms.ComboBox()
        Me.singleKeyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.notifi_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowMainWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideMainWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HelloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.groKeyCombo = New System.Windows.Forms.GroupBox()
        Me.cmdKeyComStop = New System.Windows.Forms.Button()
        Me.cmdKeyComStart = New System.Windows.Forms.Button()
        Me.keyComInterval = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.keyComSecondKey = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.keyComFirstKey = New System.Windows.Forms.ComboBox()
        Me.keyComTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblAuthor = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.main_menu.SuspendLayout()
        Me.notifi_menu.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.groKeyCombo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(166, 73)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(63, 23)
        Me.cmdStart.TabIndex = 0
        Me.cmdStart.Text = "Start"
        Me.cmdStart.UseVisualStyleBackColor = True
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
        Me.main_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.main_menu.Location = New System.Drawing.Point(0, 0)
        Me.main_menu.Name = "main_menu"
        Me.main_menu.Size = New System.Drawing.Size(482, 24)
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
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
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
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Key to press"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Interval in seconds"
        '
        'comKeys
        '
        Me.comKeys.FormattingEnabled = True
        Me.comKeys.Location = New System.Drawing.Point(108, 19)
        Me.comKeys.Name = "comKeys"
        Me.comKeys.Size = New System.Drawing.Size(121, 21)
        Me.comKeys.TabIndex = 4
        '
        'comTime
        '
        Me.comTime.FormattingEnabled = True
        Me.comTime.Location = New System.Drawing.Point(108, 46)
        Me.comTime.Name = "comTime"
        Me.comTime.Size = New System.Drawing.Size(121, 21)
        Me.comTime.TabIndex = 5
        '
        'singleKeyTimer
        '
        '
        'notifi_menu
        '
        Me.notifi_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.StartToolStripMenuItem, Me.ShowMainWindowToolStripMenuItem, Me.HideMainWindowToolStripMenuItem, Me.ExitAppToolStripMenuItem})
        Me.notifi_menu.Name = "notifi_menu"
        Me.notifi_menu.Size = New System.Drawing.Size(181, 114)
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
        'cmdStop
        '
        Me.cmdStop.Enabled = False
        Me.cmdStop.Location = New System.Drawing.Point(108, 73)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(52, 23)
        Me.cmdStop.TabIndex = 6
        Me.cmdStop.Text = "Stop"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelloToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(103, 26)
        '
        'HelloToolStripMenuItem
        '
        Me.HelloToolStripMenuItem.Name = "HelloToolStripMenuItem"
        Me.HelloToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.HelloToolStripMenuItem.Text = "Hello"
        '
        'groKeyCombo
        '
        Me.groKeyCombo.Controls.Add(Me.cmdKeyComStop)
        Me.groKeyCombo.Controls.Add(Me.cmdKeyComStart)
        Me.groKeyCombo.Controls.Add(Me.keyComInterval)
        Me.groKeyCombo.Controls.Add(Me.Label11)
        Me.groKeyCombo.Controls.Add(Me.keyComSecondKey)
        Me.groKeyCombo.Controls.Add(Me.Label10)
        Me.groKeyCombo.Controls.Add(Me.Label9)
        Me.groKeyCombo.Controls.Add(Me.keyComFirstKey)
        Me.groKeyCombo.Location = New System.Drawing.Point(260, 44)
        Me.groKeyCombo.Name = "groKeyCombo"
        Me.groKeyCombo.Size = New System.Drawing.Size(212, 124)
        Me.groKeyCombo.TabIndex = 10
        Me.groKeyCombo.TabStop = False
        Me.groKeyCombo.Text = "Key Combination"
        '
        'cmdKeyComStop
        '
        Me.cmdKeyComStop.Enabled = False
        Me.cmdKeyComStop.Location = New System.Drawing.Point(72, 92)
        Me.cmdKeyComStop.Name = "cmdKeyComStop"
        Me.cmdKeyComStop.Size = New System.Drawing.Size(52, 23)
        Me.cmdKeyComStop.TabIndex = 7
        Me.cmdKeyComStop.Text = "Stop"
        Me.cmdKeyComStop.UseVisualStyleBackColor = True
        '
        'cmdKeyComStart
        '
        Me.cmdKeyComStart.Enabled = False
        Me.cmdKeyComStart.Location = New System.Drawing.Point(130, 92)
        Me.cmdKeyComStart.Name = "cmdKeyComStart"
        Me.cmdKeyComStart.Size = New System.Drawing.Size(63, 23)
        Me.cmdKeyComStart.TabIndex = 6
        Me.cmdKeyComStart.Text = "Start"
        Me.cmdKeyComStart.UseVisualStyleBackColor = True
        '
        'keyComInterval
        '
        Me.keyComInterval.Enabled = False
        Me.keyComInterval.FormattingEnabled = True
        Me.keyComInterval.Location = New System.Drawing.Point(72, 65)
        Me.keyComInterval.Name = "keyComInterval"
        Me.keyComInterval.Size = New System.Drawing.Size(121, 21)
        Me.keyComInterval.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Interval"
        '
        'keyComSecondKey
        '
        Me.keyComSecondKey.Enabled = False
        Me.keyComSecondKey.FormattingEnabled = True
        Me.keyComSecondKey.Location = New System.Drawing.Point(72, 42)
        Me.keyComSecondKey.Name = "keyComSecondKey"
        Me.keyComSecondKey.Size = New System.Drawing.Size(121, 21)
        Me.keyComSecondKey.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Second"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "First Key"
        '
        'keyComFirstKey
        '
        Me.keyComFirstKey.FormattingEnabled = True
        Me.keyComFirstKey.Location = New System.Drawing.Point(72, 19)
        Me.keyComFirstKey.Name = "keyComFirstKey"
        Me.keyComFirstKey.Size = New System.Drawing.Size(121, 21)
        Me.keyComFirstKey.TabIndex = 0
        '
        'keyComTimer
        '
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.LinkColor = System.Drawing.Color.DimGray
        Me.lblAuthor.Location = New System.Drawing.Point(12, 182)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(128, 13)
        Me.lblAuthor.TabIndex = 11
        Me.lblAuthor.TabStop = True
        Me.lblAuthor.Text = "Created by Arifur Rahman"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdStop)
        Me.GroupBox1.Controls.Add(Me.comTime)
        Me.GroupBox1.Controls.Add(Me.comKeys)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdStart)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 124)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Single Key "
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(369, 174)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(84, 21)
        Me.cmdExit.TabIndex = 13
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 200)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.main_menu)
        Me.Controls.Add(Me.groKeyCombo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.main_menu
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Auto Key Presser"
        Me.main_menu.ResumeLayout(False)
        Me.main_menu.PerformLayout()
        Me.notifi_menu.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.groKeyCombo.ResumeLayout(False)
        Me.groKeyCombo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents main_menu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comKeys As System.Windows.Forms.ComboBox
    Friend WithEvents comTime As System.Windows.Forms.ComboBox
    Friend WithEvents singleKeyTimer As System.Windows.Forms.Timer
    Friend WithEvents notifi_menu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowMainWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideMainWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitAppToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HelloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents groKeyCombo As System.Windows.Forms.GroupBox
    Friend WithEvents cmdKeyComStart As System.Windows.Forms.Button
    Friend WithEvents keyComInterval As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents keyComSecondKey As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents keyComFirstKey As System.Windows.Forms.ComboBox
    Friend WithEvents keyComTimer As System.Windows.Forms.Timer
    Friend WithEvents cmdKeyComStop As System.Windows.Forms.Button
    Friend WithEvents lblAuthor As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button

End Class
