'Author: Arifur Rahman
'You can welcome to edit and redistribute this code as long as you mention the authors name on the main applications about page and somewhere on the code

Public Class frm_main
    Dim SelectedKeys As String
    Dim SelectedTime As Integer

    Dim keyComSelectedFirstKey As String
    Dim keyComSelectedSecondKey As String
    Dim keyComSelectedTime As Integer
    Dim WshShell As Object = CreateObject("WScript.Shell")
    Private Sub cmd_start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click

        cmdStop.Enabled = True
        singleKeyTimer.Interval = SelectedTime
        singleKeyTimer.Enabled = True
        cmdStart.Enabled = False
        comTime.Enabled = False
        comKeys.Enabled = False
        'Turns off Key combination timer
        keyComTimer.Enabled = False

    End Sub
    Private Sub NotifyIcon_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseClick
        If Me.Visible = False Then
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
        End If

        'Show right click menu
        If e.Button = MouseButtons.Right Then NotifyIcon.ContextMenuStrip.Show()

    End Sub
    Private Sub main_form_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Visible = False
            'Notifications
            Me.NotifyIcon.BalloonTipText = "AKP is Running at the background"
            Me.NotifyIcon.BalloonTipIcon = ToolTipIcon.Info
            Me.NotifyIcon.ShowBalloonTip(5)
        End If
    End Sub
    Private Sub main_form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Visible = False
            'Notifications for minimizing AKP
            Me.NotifyIcon.BalloonTipText = "AKP is Running at the background"
            Me.NotifyIcon.BalloonTipIcon = ToolTipIcon.Info
            Me.NotifyIcon.ShowBalloonTip(5)
        End If
    End Sub
    Private Sub main_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        cmdStart.Enabled = False
        comTime.Enabled = False
        keyComTimer.Enabled = False
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

        'Combo Items Key name
        comKeys.Items.Add("Num Lock")
        comKeys.Items.Add("Caps Lock")
        comKeys.Items.Add("Scroll Lock")
        comKeys.Items.Add("TAB")
        comKeys.Items.Add("Return/Enter")

        comKeys.Items.Add("Ctrl")
        comKeys.Items.Add("Alt")
        comKeys.Items.Add("Shift")

        comKeys.Items.Add("ESC")
        'comkeys.Items.Add("Windows")

        comKeys.Items.Add("Delete")
        comKeys.Items.Add("Backspace")
        'Arrow Keys
        comKeys.Items.Add("Up Arrow")
        comKeys.Items.Add("Down Arrow")
        comKeys.Items.Add("Left Arrow")
        comKeys.Items.Add("Right Arrow")

        comKeys.Items.Add("Home")
        comKeys.Items.Add("End")
        comKeys.Items.Add("Insert")
        comKeys.Items.Add("Page Up")
        comKeys.Items.Add("Page Down")

        'Function Keys
        comKeys.Items.Add("F1")
        comKeys.Items.Add("F2")
        comKeys.Items.Add("F3")
        comKeys.Items.Add("F4")
        comKeys.Items.Add("F5")
        comKeys.Items.Add("F6")
        comKeys.Items.Add("F7")
        comKeys.Items.Add("F8")
        comKeys.Items.Add("F9")
        comKeys.Items.Add("F10")
        comKeys.Items.Add("F11")
        comKeys.Items.Add("F12")


        'Combo Items Time
        comTime.Items.Add("0.1")
        comTime.Items.Add("0.5")
        comTime.Items.Add("1")
        comTime.Items.Add("2")
        comTime.Items.Add("3")
        comTime.Items.Add("4")
        comTime.Items.Add("5")
        comTime.Items.Add("6")
        comTime.Items.Add("7")
        comTime.Items.Add("8")
        comTime.Items.Add("9")
        comTime.Items.Add("10")
        comTime.Items.Add("20")
        comTime.Items.Add("30")
        comTime.Items.Add("60")
        comTime.Items.Add("120")






        '########################## Key Combination Options ##########################
        keyComFirstKey.Items.Add("Num Lock")
        keyComFirstKey.Items.Add("Caps Lock")
        keyComFirstKey.Items.Add("Scroll Lock")
        keyComFirstKey.Items.Add("TAB")
        keyComFirstKey.Items.Add("Return/Enter")

        keyComSecondKey.Items.Add("Num Lock")
        keyComSecondKey.Items.Add("Caps Lock")
        keyComSecondKey.Items.Add("Scroll Lock")
        keyComSecondKey.Items.Add("TAB")
        keyComSecondKey.Items.Add("Return/Enter")

        'Combo Items Time
        keyComInterval.Items.Add("0.5")
        keyComInterval.Items.Add("1")
        keyComInterval.Items.Add("2")
        keyComInterval.Items.Add("3")
        keyComInterval.Items.Add("4")
        keyComInterval.Items.Add("5")
        keyComInterval.Items.Add("6")
        keyComInterval.Items.Add("7")
        keyComInterval.Items.Add("8")
        keyComInterval.Items.Add("9")
        keyComInterval.Items.Add("10")
        keyComInterval.Items.Add("20")
        keyComInterval.Items.Add("30")
        keyComInterval.Items.Add("60")
        keyComInterval.Items.Add("120")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'About Menu (Please do not remove it)
        MsgBox("Created by Arifur Rahman. Visit http://www.arifur.net for more details", vbOKOnly, "About")
    End Sub

    Private Sub singleKeyTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles singleKeyTimer.Tick

        WshShell.SendKeys(SelectedKeys)

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

    Private Sub com_keys_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comKeys.SelectedIndexChanged

        comTime.Enabled = True

        'Lock Keys
        If comKeys.Text = "Num Lock" Then
            SelectedKeys = "{NUMLOCK}"
        End If
        If comKeys.Text = "Caps Lock" Then
            SelectedKeys = "{CAPSLOCK}"
        End If
        If comKeys.Text = "Scroll Lock" Then
            SelectedKeys = "{SCROLLLOCK}"
        End If

        If comKeys.Text = "TAB" Then
            SelectedKeys = "{TAB}"
        End If
        If comKeys.Text = "Return/Enter" Then
            SelectedKeys = "{ENTER}"
        End If

        'Control, Alt and Shift
        If comKeys.Text = "Ctrl" Then
            SelectedKeys = "^"
        End If
        If comKeys.Text = "Alt" Then
            SelectedKeys = "%"
        End If
        If comKeys.Text = "Shift" Then
            SelectedKeys = "+"
        End If

        If comKeys.Text = "ESC" Then
            SelectedKeys = "{ESC}"
        End If
        'If comkeys.Text = "Windows" Then
        '    SelectedKeys = "{WINDOWS}"
        'End If
        If comKeys.Text = "Delete" Then
            SelectedKeys = "{DELETE}"
        End If
        If comKeys.Text = "Backspace" Then
            SelectedKeys = "{BKSP}"
        End If
        'Arrow Keys
        If comKeys.Text = "Down Arrow" Then
            SelectedKeys = "{DOWN}"
        End If
        If comKeys.Text = "Up Arrow" Then
            SelectedKeys = "{UP}"
        End If
        If comKeys.Text = "Left Arrow" Then
            SelectedKeys = "{LEFT}"
        End If
        If comKeys.Text = "Right Arrow" Then
            SelectedKeys = "{RIGHT}"
        End If
        'Home End Insert
        If comKeys.Text = "Home" Then
            SelectedKeys = "{Home}"
        End If
        If comKeys.Text = "End" Then
            SelectedKeys = "{End}"
        End If
        If comKeys.Text = "Insert" Then
            SelectedKeys = "{INSERT}"
        End If
        'Page up and page down
        If comKeys.Text = "Page Up" Then
            SelectedKeys = "{PGUP}"
        End If
        If comKeys.Text = "Page Down" Then
            SelectedKeys = "{PGDN}"
        End If
        If comKeys.Text = "Print Screen" Then
            SelectedKeys = "{PRTSC}"
        End If
        'Function Keys F1 to F12
        If comKeys.Text = "F1" Then
            SelectedKeys = "{F1}"
        End If
        If comKeys.Text = "F2" Then
            SelectedKeys = "{F2}"
        End If
        If comKeys.Text = "F3" Then
            SelectedKeys = "{F3}"
        End If
        If comKeys.Text = "F4" Then
            SelectedKeys = "{F4}"
        End If
        If comKeys.Text = "F5" Then
            SelectedKeys = "{F5}"
        End If
        If comKeys.Text = "F6" Then
            SelectedKeys = "{F6}"
        End If
        If comKeys.Text = "F7" Then
            SelectedKeys = "{F7}"
        End If
        If comKeys.Text = "F8" Then
            SelectedKeys = "{F8}"
        End If
        If comKeys.Text = "F9" Then
            SelectedKeys = "{F9}"
        End If
        If comKeys.Text = "F10" Then
            SelectedKeys = "{F10}"
        End If
        If comKeys.Text = "F11" Then
            SelectedKeys = "{F11}"
        End If
        If comKeys.Text = "F12" Then
            SelectedKeys = "{F12}"
        End If
    End Sub
    'Key Select Functions
    Private Sub NumLockKey()
        Dim WshShell As Object = CreateObject("WScript.Shell")
        WshShell.SendKeys("{NUMLOCK}")
    End Sub
    Private Sub ScrollLockKey()
        Dim WshShell As Object = CreateObject("WScript.Shell")
        WshShell.SendKeys("{SCROLLLOCK}")
    End Sub
    Private Sub CapsLockKey()
        Dim WshShell As Object = CreateObject("WScript.Shell")
        WshShell.SendKeys("{CAPSLOCK}")
    End Sub
    Private Sub TabKey()
        Dim WshShell As Object = CreateObject("WScript.Shell")
        WshShell.SendKeys("{TAB}")
    End Sub
    Private Sub ReturnKey()
        Dim WshShell As Object = CreateObject("WScript.Shell")
        WshShell.SendKeys("{ENTER}")
    End Sub
    Private Sub AltKey()
        Dim WshShell As Object = CreateObject("WScript.Shell")
        WshShell.SendKeys("{ALT}")
    End Sub

    'Timer Functions
    Private Sub com_time_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comTime.SelectedIndexChanged

        'Time selection values 
        cmdStart.Enabled = True
        If comTime.Text = "" Then
            singleKeyTimer.Enabled = False
            SelectedTime = 0

        End If
        If comTime.Text = "0.1" Then
            SelectedTime = 100
        End If
        If comTime.Text = "0.5" Then
            SelectedTime = 500
        End If
        If comTime.Text = "1" Then
            SelectedTime = 1000
        End If
        If comTime.Text = "2" Then
            SelectedTime = 2000
        End If
        If comTime.Text = "3" Then
            SelectedTime = 3000
        End If
        If comTime.Text = "4" Then
            SelectedTime = 4000
        End If
        If comTime.Text = "5" Then
            SelectedTime = 5000
        End If
        If comTime.Text = "6" Then
            SelectedTime = 6000
        End If
        If comTime.Text = "7" Then
            SelectedTime = 7000
        End If
        If comTime.Text = "8" Then
            SelectedTime = 8000
        End If
        If comTime.Text = "9" Then
            SelectedTime = 9000
        End If
        If comTime.Text = "10" Then
            SelectedTime = 10000
        End If
        If comTime.Text = "20" Then
            SelectedTime = 20000
        End If
        If comTime.Text = "30" Then
            SelectedTime = 30000
        End If
        If comTime.Text = "60" Then
            SelectedTime = 60000
        End If
        If comTime.Text = "120" Then
            SelectedTime = 120000
        End If
    End Sub

    Private Sub cmd_stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        'Stop Button
        singleKeyTimer.Enabled = False
        cmdStart.Enabled = True
        comKeys.Enabled = True
        cmdStop.Enabled = False
        comKeys.Enabled = True

    End Sub

    Private Sub cmdKeyComStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKeyComStart.Click
        'Start button for the key combination
        keyComTimer.Interval = keyComSelectedTime
        keyComTimer.Enabled = True
        cmdKeyComStart.Enabled = False
        cmdKeyComStop.Enabled = True
        keyComInterval.Enabled = False
        'Turns of press timer
        singleKeyTimer.Enabled = False
    End Sub

    


    Private Sub keyComInterval_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keyComInterval.SelectedIndexChanged
        cmdKeyComStart.Enabled = True


        'Time selection values 

        If keyComInterval.Text = "" Then
            keyComTimer.Enabled = False
            keyComSelectedTime = 0

        End If
        If keyComInterval.Text = "0.1" Then
            keyComSelectedTime = 100
        End If
        If keyComInterval.Text = "0.5" Then
            keyComSelectedTime = 500
        End If
        If keyComInterval.Text = "1" Then
            keyComSelectedTime = 1000
        End If
        If keyComInterval.Text = "2" Then
            keyComSelectedTime = 2000
        End If
        If keyComInterval.Text = "3" Then
            keyComSelectedTime = 3000
        End If
        If keyComInterval.Text = "4" Then
            keyComSelectedTime = 4000
        End If
        If keyComInterval.Text = "5" Then
            keyComSelectedTime = 5000
        End If
        If keyComInterval.Text = "6" Then
            keyComSelectedTime = 6000
        End If
        If keyComInterval.Text = "7" Then
            keyComSelectedTime = 7000
        End If
        If keyComInterval.Text = "8" Then
            keyComSelectedTime = 8000
        End If
        If keyComInterval.Text = "9" Then
            keyComSelectedTime = 9000
        End If
        If keyComInterval.Text = "10" Then
            keyComSelectedTime = 10000
        End If
        If keyComInterval.Text = "20" Then
            keyComSelectedTime = 20000
        End If
        If keyComInterval.Text = "30" Then
            keyComSelectedTime = 30000
        End If
        If keyComInterval.Text = "60" Then
            keyComSelectedTime = 60000
        End If
        If keyComInterval.Text = "120" Then
            keyComSelectedTime = 120000
        End If
    End Sub

    Private Sub keyComFirstKey_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keyComFirstKey.SelectedIndexChanged
        'Combo box value for first key selection in key combination

        keyComSecondKey.Enabled = True
        If keyComFirstKey.Text = "Num Lock" Then
            keyComSelectedFirstKey = "{NUMLOCK}"
        End If
        If keyComFirstKey.Text = "Caps Lock" Then
            keyComSelectedFirstKey = "{CAPSLOCK}"
        End If
        If keyComFirstKey.Text = "Scroll Lock" Then
            keyComSelectedFirstKey = "{SCROLLLOCK}"
        End If
        If keyComFirstKey.Text = "TAB" Then
            keyComSelectedFirstKey = "{TAB}"
        End If
        If keyComFirstKey.Text = "Return/Enter" Then
            keyComSelectedFirstKey = "{ENTER}"
        End If
    End Sub
    Private Sub keyComSecondKey_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keyComSecondKey.SelectedIndexChanged

        'This enable the interval selection combobox only when the stop button is disabled
        If cmdKeyComStop.Enabled = False Then
            keyComInterval.Enabled = True
        Else
            keyComInterval.Enabled = False
        End If


        'Combo box value for second key selection in key combination

        If keyComSecondKey.Text = "Num Lock" Then
            keyComSelectedSecondKey = "{NUMLOCK}"
        End If
        If keyComSecondKey.Text = "Caps Lock" Then
            keyComSelectedSecondKey = "{CAPSLOCK}"
        End If
        If keyComSecondKey.Text = "Scroll Lock" Then
            keyComSelectedSecondKey = "{SCROLLLOCK}"
        End If
        If keyComSecondKey.Text = "TAB" Then
            keyComSelectedSecondKey = "{TAB}"
        End If
        If keyComSecondKey.Text = "Return/Enter" Then
            keyComSelectedSecondKey = "{ENTER}"
        End If
    End Sub

    Private Sub keyComTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keyComTimer.Tick
        'Key combination presser timer
        WshShell.SendKeys(keyComSelectedFirstKey)
        WshShell.SendKeys(keyComSelectedSecondKey)
    End Sub


    Private Sub lblAuthor_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblAuthor.LinkClicked
        System.Diagnostics.Process.Start("http://www.arifur.net")
    End Sub

    Private Sub cmdKeyComStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKeyComStop.Click
        keyComTimer.Enabled = False
        cmdKeyComStop.Enabled = False
        cmdKeyComStart.Enabled = True
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        End
    End Sub
End Class
