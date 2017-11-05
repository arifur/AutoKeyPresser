<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnSingleStart = New System.Windows.Forms.Button()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.main_menu = New System.Windows.Forms.MenuStrip()
        Me.btnFileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExitMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnMouseControllerMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnViewHelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAboutMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblKeytoPress = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comSingleKeys = New System.Windows.Forms.ComboBox()
        Me.comSingleInterval = New System.Windows.Forms.ComboBox()
        Me.singleKeyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.notifi_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowMainWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideMainWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSingleStop = New System.Windows.Forms.Button()
        Me.groKeyCombo = New System.Windows.Forms.GroupBox()
        Me.btnKeyComStop = New System.Windows.Forms.Button()
        Me.btnKeyComStart = New System.Windows.Forms.Button()
        Me.comInterval = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.comSecondKey = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.comFirstKey = New System.Windows.Forms.ComboBox()
        Me.combinedKeyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblAuthor = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.main_menu.SuspendLayout()
        Me.notifi_menu.SuspendLayout()
        Me.groKeyCombo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSingleStart
        '
        Me.btnSingleStart.Location = New System.Drawing.Point(166, 73)
        Me.btnSingleStart.Name = "btnSingleStart"
        Me.btnSingleStart.Size = New System.Drawing.Size(63, 23)
        Me.btnSingleStart.TabIndex = 0
        Me.btnSingleStart.Text = "Start"
        Me.btnSingleStart.UseVisualStyleBackColor = True
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
        Me.main_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFileMenu, Me.btnOptions, Me.btnHelpMenu})
        Me.main_menu.Location = New System.Drawing.Point(0, 0)
        Me.main_menu.Name = "main_menu"
        Me.main_menu.Size = New System.Drawing.Size(482, 24)
        Me.main_menu.TabIndex = 1
        Me.main_menu.Text = "MenuStrip1"
        '
        'btnFileMenu
        '
        Me.btnFileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExitMenu})
        Me.btnFileMenu.Name = "btnFileMenu"
        Me.btnFileMenu.Size = New System.Drawing.Size(37, 20)
        Me.btnFileMenu.Text = "File"
        '
        'btnExitMenu
        '
        Me.btnExitMenu.Name = "btnExitMenu"
        Me.btnExitMenu.Size = New System.Drawing.Size(92, 22)
        Me.btnExitMenu.Text = "Exit"
        '
        'btnOptions
        '
        Me.btnOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMouseControllerMenu})
        Me.btnOptions.Enabled = False
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(61, 20)
        Me.btnOptions.Text = "Options"
        Me.btnOptions.Visible = False
        '
        'btnMouseControllerMenu
        '
        Me.btnMouseControllerMenu.Name = "btnMouseControllerMenu"
        Me.btnMouseControllerMenu.Size = New System.Drawing.Size(166, 22)
        Me.btnMouseControllerMenu.Text = "Mouse Controller"
        '
        'btnHelpMenu
        '
        Me.btnHelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnViewHelpMenu, Me.btnAboutMenu})
        Me.btnHelpMenu.Name = "btnHelpMenu"
        Me.btnHelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.btnHelpMenu.Text = "&Help"
        '
        'btnViewHelpMenu
        '
        Me.btnViewHelpMenu.Name = "btnViewHelpMenu"
        Me.btnViewHelpMenu.Size = New System.Drawing.Size(127, 22)
        Me.btnViewHelpMenu.Text = "View Help"
        '
        'btnAboutMenu
        '
        Me.btnAboutMenu.Name = "btnAboutMenu"
        Me.btnAboutMenu.Size = New System.Drawing.Size(127, 22)
        Me.btnAboutMenu.Text = "About"
        '
        'lblKeytoPress
        '
        Me.lblKeytoPress.AutoSize = True
        Me.lblKeytoPress.Location = New System.Drawing.Point(6, 27)
        Me.lblKeytoPress.Name = "lblKeytoPress"
        Me.lblKeytoPress.Size = New System.Drawing.Size(65, 13)
        Me.lblKeytoPress.TabIndex = 2
        Me.lblKeytoPress.Text = "Key to press"
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
        'comSingleKeys
        '
        Me.comSingleKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comSingleKeys.FormattingEnabled = True
        Me.comSingleKeys.Location = New System.Drawing.Point(108, 19)
        Me.comSingleKeys.Name = "comSingleKeys"
        Me.comSingleKeys.Size = New System.Drawing.Size(121, 21)
        Me.comSingleKeys.TabIndex = 4
        '
        'comSingleInterval
        '
        Me.comSingleInterval.FormattingEnabled = True
        Me.comSingleInterval.ItemHeight = 13
        Me.comSingleInterval.Location = New System.Drawing.Point(108, 46)
        Me.comSingleInterval.MaxDropDownItems = 20
        Me.comSingleInterval.Name = "comSingleInterval"
        Me.comSingleInterval.Size = New System.Drawing.Size(121, 21)
        Me.comSingleInterval.TabIndex = 5
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
        'btnSingleStop
        '
        Me.btnSingleStop.Enabled = False
        Me.btnSingleStop.Location = New System.Drawing.Point(108, 73)
        Me.btnSingleStop.Name = "btnSingleStop"
        Me.btnSingleStop.Size = New System.Drawing.Size(52, 23)
        Me.btnSingleStop.TabIndex = 6
        Me.btnSingleStop.Text = "Stop"
        Me.btnSingleStop.UseVisualStyleBackColor = True
        '
        'groKeyCombo
        '
        Me.groKeyCombo.Controls.Add(Me.btnKeyComStop)
        Me.groKeyCombo.Controls.Add(Me.btnKeyComStart)
        Me.groKeyCombo.Controls.Add(Me.comInterval)
        Me.groKeyCombo.Controls.Add(Me.Label11)
        Me.groKeyCombo.Controls.Add(Me.comSecondKey)
        Me.groKeyCombo.Controls.Add(Me.Label10)
        Me.groKeyCombo.Controls.Add(Me.Label9)
        Me.groKeyCombo.Controls.Add(Me.comFirstKey)
        Me.groKeyCombo.Location = New System.Drawing.Point(260, 44)
        Me.groKeyCombo.Name = "groKeyCombo"
        Me.groKeyCombo.Size = New System.Drawing.Size(212, 124)
        Me.groKeyCombo.TabIndex = 10
        Me.groKeyCombo.TabStop = False
        Me.groKeyCombo.Text = "Key Combination"
        '
        'btnKeyComStop
        '
        Me.btnKeyComStop.Enabled = False
        Me.btnKeyComStop.Location = New System.Drawing.Point(72, 92)
        Me.btnKeyComStop.Name = "btnKeyComStop"
        Me.btnKeyComStop.Size = New System.Drawing.Size(52, 23)
        Me.btnKeyComStop.TabIndex = 7
        Me.btnKeyComStop.Text = "Stop"
        Me.btnKeyComStop.UseVisualStyleBackColor = True
        '
        'btnKeyComStart
        '
        Me.btnKeyComStart.Enabled = False
        Me.btnKeyComStart.Location = New System.Drawing.Point(130, 92)
        Me.btnKeyComStart.Name = "btnKeyComStart"
        Me.btnKeyComStart.Size = New System.Drawing.Size(63, 23)
        Me.btnKeyComStart.TabIndex = 6
        Me.btnKeyComStart.Text = "Start"
        Me.btnKeyComStart.UseVisualStyleBackColor = True
        '
        'comInterval
        '
        Me.comInterval.Enabled = False
        Me.comInterval.FormattingEnabled = True
        Me.comInterval.Location = New System.Drawing.Point(72, 65)
        Me.comInterval.MaxDropDownItems = 20
        Me.comInterval.Name = "comInterval"
        Me.comInterval.Size = New System.Drawing.Size(121, 21)
        Me.comInterval.TabIndex = 5
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
        'comSecondKey
        '
        Me.comSecondKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comSecondKey.Enabled = False
        Me.comSecondKey.FormattingEnabled = True
        Me.comSecondKey.Location = New System.Drawing.Point(72, 42)
        Me.comSecondKey.Name = "comSecondKey"
        Me.comSecondKey.Size = New System.Drawing.Size(121, 21)
        Me.comSecondKey.TabIndex = 3
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
        'comFirstKey
        '
        Me.comFirstKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comFirstKey.FormattingEnabled = True
        Me.comFirstKey.Location = New System.Drawing.Point(72, 19)
        Me.comFirstKey.Name = "comFirstKey"
        Me.comFirstKey.Size = New System.Drawing.Size(121, 21)
        Me.comFirstKey.TabIndex = 0
        '
        'combinedKeyTimer
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
        Me.GroupBox1.Controls.Add(Me.btnSingleStop)
        Me.GroupBox1.Controls.Add(Me.comSingleInterval)
        Me.GroupBox1.Controls.Add(Me.comSingleKeys)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblKeytoPress)
        Me.GroupBox1.Controls.Add(Me.btnSingleStart)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 124)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Single Key "
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(369, 174)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 21)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 200)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.main_menu)
        Me.Controls.Add(Me.groKeyCombo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.main_menu
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Auto Key Presser"
        Me.main_menu.ResumeLayout(False)
        Me.main_menu.PerformLayout()
        Me.notifi_menu.ResumeLayout(False)
        Me.groKeyCombo.ResumeLayout(False)
        Me.groKeyCombo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSingleStart As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents main_menu As System.Windows.Forms.MenuStrip
    Friend WithEvents btnFileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExitMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnHelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblKeytoPress As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comSingleKeys As System.Windows.Forms.ComboBox
    Friend WithEvents comSingleInterval As System.Windows.Forms.ComboBox
    Friend WithEvents singleKeyTimer As System.Windows.Forms.Timer
    Friend WithEvents notifi_menu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowMainWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideMainWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitAppToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSingleStop As System.Windows.Forms.Button
    Friend WithEvents btnOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents groKeyCombo As System.Windows.Forms.GroupBox
    Friend WithEvents btnKeyComStart As System.Windows.Forms.Button
    Friend WithEvents comInterval As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents comSecondKey As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents comFirstKey As System.Windows.Forms.ComboBox
    Friend WithEvents combinedKeyTimer As System.Windows.Forms.Timer
    Friend WithEvents btnKeyComStop As System.Windows.Forms.Button
    Friend WithEvents lblAuthor As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnMouseControllerMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnViewHelpMenu As ToolStripMenuItem
    Friend WithEvents btnAboutMenu As ToolStripMenuItem
End Class
