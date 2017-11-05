'Author: Arifur Rahman
'You are welcome to edit and redistribute this code as long as you mention the authors name on the main applications about page and somewhere on the code

Public Class frmMain
    Dim SelectedKeys As String
    Dim SelectedTime As Integer
    Dim WshShell As Object = CreateObject("WScript.Shell")
    Dim hotkey As New HotKeyRegistryClass(Me.Handle)

    Private Sub NotifyIcon_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseClick
        If e.Button = MouseButtons.Left Then
            If Me.Visible = False Then
                Me.Visible = True
                Me.WindowState = FormWindowState.Normal
            ElseIf Me.Visible = True Then
                Me.Visible = False
            End If
            'Show right click menu
        ElseIf e.Button = MouseButtons.Right Then
            NotifyIcon.ContextMenuStrip.Show()
        End If

    End Sub
    Private Sub main_form_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Visible = False
            'Notifications
            Me.NotifyIcon.BalloonTipText = "AKP is Running in the background"
            Me.NotifyIcon.BalloonTipIcon = ToolTipIcon.Info
            Me.NotifyIcon.ShowBalloonTip(5)
        End If
    End Sub
    Private Sub main_form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Visible = False
            'Notifications for minimizing AKP
            Me.NotifyIcon.BalloonTipText = "AKP is Running in the background"
            Me.NotifyIcon.BalloonTipIcon = ToolTipIcon.Info
            Me.NotifyIcon.ShowBalloonTip(5)
        End If
    End Sub
    Private Sub main_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comSingleKeys.Items.AddRange(funcAddKeys)
        comSingleInterval.Items.AddRange(funcAddIntervals)

        comFirstKey.Items.AddRange(funcAddKeys)
        comSecondKey.Items.AddRange(funcAddKeys)
        comInterval.Items.AddRange(funcAddIntervals)

        btnSingleStart.Enabled = False
        comSingleInterval.Enabled = False
        combinedKeyTimer.Enabled = False
        'Form Width and height
        'Me.Width = 270
        'Me.Height = 181

        'Notification area Context Menu (right click)
        Me.NotifyIcon.Visible = True
        NotifyIcon.ContextMenuStrip = notifi_menu

        'Notifications for running AKP
        Me.NotifyIcon.BalloonTipText = "Welcome~! AKP is Running"
        Me.NotifyIcon.BalloonTipIcon = ToolTipIcon.Info
        Me.NotifyIcon.ShowBalloonTip(5)

        'hotkeys
        hotkey.Register(HotKeyRegistryClass.Modifiers.MOD_CTRL, Keys.F3).ToString() 'case 0
        hotkey.Register(HotKeyRegistryClass.Modifiers.MOD_CTRL, Keys.F4).ToString() 'case 1
        hotkey.Register(HotKeyRegistryClass.Modifiers.MOD_CTRL, Keys.F5).ToString() 'case 2
        hotkey.Register(HotKeyRegistryClass.Modifiers.MOD_CTRL, Keys.F6).ToString() 'case 3
        hotkey.Register(HotKeyRegistryClass.Modifiers.MOD_CTRL, Keys.F7).ToString() 'case 4
        hotkey.Register(HotKeyRegistryClass.Modifiers.MOD_CTRL, Keys.F8).ToString() 'case 5
        hotkey.Register(HotKeyRegistryClass.Modifiers.MOD_CTRL, Keys.F9).ToString() 'case 6
    End Sub
    ''Hotkey actions
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = HotKeyRegistryClass.Messages.WM_HOTKEY Then 'NOT THE ACTUAL WINDOWS NAMESPACE
            Dim ID As String = m.WParam.ToString()
            Select Case ID
                Case 0
                    'Starts Single Key - F3
                    If btnSingleStart.Enabled = True Then
                        btnSingleStart.PerformClick()
                    End If
                Case 1
                    'Stops Single Key - F4
                    If btnSingleStop.Enabled = True Then
                        btnSingleStop.PerformClick()
                    End If
                Case 2
                    'Starts multikey - F5
                    If btnKeyComStart.Enabled = True Then
                        btnKeyComStart.PerformClick()
                    End If
                Case 3
                    'Stops multikey - F6
                    If btnKeyComStop.Enabled = True Then
                        btnKeyComStop.PerformClick()
                    End If
                Case 4
                    'Starts both - F7
                    If btnSingleStart.Enabled = True And btnKeyComStart.Enabled = True Then
                        btnSingleStart.PerformClick()
                        btnKeyComStart.PerformClick()
                    End If
                Case 5
                    'Stops both -F8
                    btnSingleStop.PerformClick()
                    btnKeyComStop.PerformClick()
                Case 6
            End Select
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitMenu.Click
        End
    End Sub
    Private Sub ExitAppToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitAppToolStripMenuItem.Click
        End
    End Sub

    Private Sub ShowMainWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowMainWindowToolStripMenuItem.Click
        Me.Visible = True
    End Sub

    Private Sub HideMainWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideMainWindowToolStripMenuItem.Click
        Me.Visible = False
    End Sub


    Private Sub cmd_stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSingleStop.Click
        'Stop Button
        singleKeyTimer.Enabled = False
        btnSingleStart.Enabled = True
        comSingleKeys.Enabled = True
        btnSingleStop.Enabled = False
        comSingleKeys.Enabled = True
    End Sub

    Private Sub cmdKeyComStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyComStart.Click
        'Start button for the key combination
        combinedKeyTimer.Interval = funcInterval(comInterval.Text)
        combinedKeyTimer.Enabled = True
        btnKeyComStart.Enabled = False
        btnKeyComStop.Enabled = True
        comInterval.Enabled = False
        'Turns of press timer
        singleKeyTimer.Enabled = False
        comFirstKey.Enabled = False
        comSecondKey.Enabled = False
    End Sub

    Private Sub comInterval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comInterval.KeyPress
        '' this combo box only accepts numbers
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub keyComInterval_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comInterval.SelectedIndexChanged
        btnKeyComStart.Enabled = True
    End Sub

    Private Sub keyComFirstKey_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comFirstKey.SelectedIndexChanged
        'Combo box value for first key selection in key combination
        If comFirstKey.Text = "-----Numbers-----" Then
            comSecondKey.Enabled = False
            btnKeyComStart.Enabled = False
        ElseIf comFirstKey.Text = "-----Alphabets-----" Then
            comSecondKey.Enabled = False
            btnKeyComStart.Enabled = False
        ElseIf comFirstKey.Text = "-----Function Keys-----" Then
            comSecondKey.Enabled = False
            btnKeyComStart.Enabled = False
        ElseIf comFirstKey.Text = "-----Special Keys-----" Then
            comSecondKey.Enabled = False
            btnKeyComStart.Enabled = False
        Else : comSecondKey.Enabled = True
        End If
    End Sub
    Private Sub keyComSecondKey_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comSecondKey.SelectedIndexChanged

        'This enable the interval selection combobox only when the stop button is disabled
        If btnKeyComStop.Enabled = False Then
            comInterval.Enabled = True
        Else
            comInterval.Enabled = False
        End If
        If comSecondKey.Text = "-----Numbers-----" Then
            comInterval.Enabled = False
            btnKeyComStart.Enabled = False
        ElseIf comSecondKey.Text = "-----Alphabets-----" Then
            comInterval.Enabled = False
            btnKeyComStart.Enabled = False
        ElseIf comSecondKey.Text = "-----Function Keys-----" Then
            comInterval.Enabled = False
            btnKeyComStart.Enabled = False
        ElseIf comSecondKey.Text = "-----Special Keys-----" Then
            comInterval.Enabled = False
            btnKeyComStart.Enabled = False
        Else : comInterval.Enabled = True
        End If
        'Combo box value for second key selection in key combination

    End Sub




    Private Sub lblAuthor_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblAuthor.LinkClicked
        System.Diagnostics.Process.Start("http://www.arifur.net")
    End Sub

    Private Sub cmdKeyComStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyComStop.Click
        combinedKeyTimer.Enabled = False
        btnKeyComStop.Enabled = False
        btnKeyComStart.Enabled = True
        comInterval.Enabled = True
        comFirstKey.Enabled = True

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    ''Function to convert user selected interval value to seconds
    Public Function funcInterval(ByVal UserSelectedTime As Double)
        Dim varInterval As Integer
        SelectedTime = UserSelectedTime * 1000
        varInterval = SelectedTime
        Return varInterval
    End Function

    ''Function to press keys
    Public Function funcPressKeys(ByVal UserSelectedKey As String)
        Dim varKey As String
        varKey = "{" & UserSelectedKey & "}"

        'Lock Keys
        If UserSelectedKey = "Num Lock" Then
            varKey = "{NUMLOCK}"
        ElseIf UserSelectedKey = "Caps Lock" Then
            varKey = "{CAPSLOCK}"
        ElseIf UserSelectedKey = "Scroll Lock" Then
            varKey = "{SCROLLLOCK}"
        ElseIf UserSelectedKey = "TAB" Then
            varKey = "{TAB}"
        ElseIf UserSelectedKey = "Return/Enter" Then
            varKey = "{ENTER}"
        ElseIf UserSelectedKey = "Spacebar" Then
            varKey = " "
            'Control, Alt and Shift
        ElseIf UserSelectedKey = "Ctrl" Then
            varKey = "^"
        ElseIf UserSelectedKey = "Alt" Then
            varKey = "%"
        ElseIf UserSelectedKey = "Shift" Then
            varKey = "+"
        ElseIf UserSelectedKey = "ESC" Then
            varKey = "{ESC}"
            'If UserSelectedKey = "Windows" Then
            '    varKey = "{WINDOWS}"
            'End If
        ElseIf UserSelectedKey = "Delete" Then
            varKey = "{DELETE}"
        ElseIf UserSelectedKey = "Backspace" Then
            varKey = "{BKSP}"
            'Arrow Keys
        ElseIf UserSelectedKey = "Down Arrow" Then
            varKey = "{DOWN}"
        ElseIf UserSelectedKey = "Up Arrow" Then
            varKey = "{UP}"
        ElseIf UserSelectedKey = "Left Arrow" Then
            varKey = "{LEFT}"
        ElseIf UserSelectedKey = "Right Arrow" Then
            varKey = "{RIGHT}"
            'Home End Insert
        ElseIf UserSelectedKey = "Home" Then
            varKey = "{Home}"
        ElseIf UserSelectedKey = "End" Then
            varKey = "{End}"
        ElseIf UserSelectedKey = "Insert" Then
            varKey = "{INSERT}"
            'Page up and page down
        ElseIf UserSelectedKey = "Page Up" Then
            varKey = "{PGUP}"
        ElseIf UserSelectedKey = "Page Down" Then
            varKey = "{PGDN}"
        ElseIf UserSelectedKey = "Print Screen" Then
            varKey = "{PRTSC}"
        End If
        Return varKey

    End Function


    Function funcAddKeys()
        Dim KeyList() As String = {"-----Numbers-----", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-----Alphabets-----", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "-----Function Keys-----", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "-----Special Keys-----", "NumLock", "CapsLock", "ScrollLock", "TAB", "Return/Enter", "Spacebar", "Ctrl", "Alt", "Shift", "ESC", "Delete", "Backspace", "DownArrow", "UpArrow", "LeftArrow", "RightArrow", "Home", "End", "Insert", "PageUp", "PageDown", "PrintScreen"}
        Return KeyList
    End Function
    Function funcAddIntervals()
        Dim IntervalList() As String = {"0.1", "0.5", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "20", "40", "60", "120", "180", "240", "300", "360", "420", "500", "1000", "2000", "3000", "4000", "5000", "10000"}
        Return IntervalList
    End Function

    Private Sub comKeys_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSingleKeys.SelectedIndexChanged

        If comSingleKeys.Text = "-----Numbers-----" Then
            comSingleInterval.Enabled = False
        ElseIf comSingleKeys.Text = "-----Alphabets-----" Then
            comSingleInterval.Enabled = False
        ElseIf comSingleKeys.Text = "-----Function Keys-----" Then
            comSingleInterval.Enabled = False
        ElseIf comSingleKeys.Text = "-----Special Keys-----" Then
            comSingleInterval.Enabled = False
        Else : comSingleInterval.Enabled = True
        End If

    End Sub

    Private Sub comSingleInterval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comSingleInterval.KeyPress
        '' this combo box only accepts numbers
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub comTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSingleInterval.SelectedIndexChanged
        btnSingleStart.Enabled = True
    End Sub

    Private Sub cmdSingleStart_Click(sender As Object, e As EventArgs) Handles btnSingleStart.Click
        If comSingleInterval.Text = "" Then
            singleKeyTimer.Enabled = False
        Else
            singleKeyTimer.Enabled = True
            singleKeyTimer.Interval = funcInterval(comSingleInterval.Text)
            btnSingleStop.Enabled = True
            comSingleInterval.Enabled = False
            comSingleKeys.Enabled = False
            btnSingleStart.Enabled = False
        End If
        lblKeytoPress.Focus()

    End Sub

    Private Sub singleKeyTimer_Tick(sender As Object, e As EventArgs) Handles singleKeyTimer.Tick
        WshShell.SendKeys(funcPressKeys(comSingleKeys.Text))
    End Sub

    Private Sub combinedKeyTimer_Tick(sender As Object, e As EventArgs) Handles combinedKeyTimer.Tick
        WshShell.SendKeys(funcPressKeys(comFirstKey.Text))
        WshShell.SendKeys(funcPressKeys(comSecondKey.Text))
    End Sub

    Private Sub btnAboutMenu_Click(sender As Object, e As EventArgs) Handles btnAboutMenu.Click
        'About Menu (Please do not remove it)
        'MsgBox("Created by Arifur Rahman. Visit http://www.arifur.net for more details", vbOKOnly, "About")
        frmAbout.Show()
    End Sub

    Private Sub btnViewHelpMenu_Click(sender As Object, e As EventArgs) Handles btnViewHelpMenu.Click
        MsgBox("    CTRL + F3 - Starts Single Key Presser
    CTRL + F4 - Stops Single Key Presser
    CTRL + F5 - Starts Multi Key Presser
    CTRL + F6 - Stops Multi Key Presser
    CTRL + F7 - Starts Both Key Presser
    CTRL + F8 - Stops Both Key Presser", vbInformation, "Hotkeys")
    End Sub
End Class
