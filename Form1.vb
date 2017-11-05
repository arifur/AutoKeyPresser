'Created by Arifur Rahman

Public Class main_form
    Dim SelectedKeys As String
    Dim SelectedTime As Integer



    Private Sub cmd_start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_start.Click

        press_timer.Interval = SelectedTime
        press_timer.Enabled = True
        cmd_start.Enabled = False
        com_time.Enabled = False

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
            'Notifications
            Me.NotifyIcon.BalloonTipText = "AKP is Running at the background"
            Me.NotifyIcon.BalloonTipIcon = ToolTipIcon.Info
            Me.NotifyIcon.ShowBalloonTip(5)
        End If
    End Sub
    Private Sub main_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        cmd_start.Enabled = False
        com_time.Enabled = False

        'Context Menu
        Me.NotifyIcon.Visible = True
        NotifyIcon.ContextMenuStrip = notifi_menu

        'Notifications
        Me.NotifyIcon.BalloonTipText = "Welcome~! AKP is Running"
        Me.NotifyIcon.BalloonTipIcon = ToolTipIcon.Info
        Me.NotifyIcon.ShowBalloonTip(5)

        'Combo Items Key name
        com_keys.Items.Add("Num Lock")
        com_keys.Items.Add("Caps Lock")
        com_keys.Items.Add("Scroll Lock")
        com_keys.Items.Add("TAB")
        com_keys.Items.Add("Return/Enter")

        'Combo Items Time
        com_time.Items.Add("1")
        com_time.Items.Add("5")
        com_time.Items.Add("10")
        com_time.Items.Add("20")
        com_time.Items.Add("30")
        com_time.Items.Add("60")
        com_time.Items.Add("120")




    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Created by Arifur Rahman. Visit http://www.arifur.net for more details", vbOKOnly, MsgBoxStyle.Information)
    End Sub

    Private Sub press_timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles press_timer.Tick
        Dim WshShell As Object = CreateObject("WScript.Shell")
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

    Private Sub com_keys_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles com_keys.SelectedIndexChanged

        com_time.Enabled = True

        If com_keys.Text = "Num Lock" Then
            SelectedKeys = "{NUMLOCK}"
        End If
        If com_keys.Text = "Caps Lock" Then
            SelectedKeys = "{CAPSLOCK}"
        End If
        If com_keys.Text = "Scroll Lock" Then
            SelectedKeys = "{SCROLLLOCK}"
        End If
        If com_keys.Text = "TAB" Then
            SelectedKeys = "{TAB}"
        End If
        If com_keys.Text = "Return/Enter" Then
            SelectedKeys = "{ENTER}"
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

    'Timer Functions
    Private Sub T1()
        press_timer.Interval = 1000
    End Sub
    Private Sub T5()
        press_timer.Interval = 5000
    End Sub
    Private Sub T10()
        press_timer.Interval = 10000
    End Sub
    Private Sub T20()
        press_timer.Interval = 20000
    End Sub
    Private Sub T30()
        press_timer.Interval = 30000
    End Sub
    Private Sub T60()
        press_timer.Interval = 60000
    End Sub
    Private Sub T120()
        press_timer.Interval = 120000
    End Sub



    Private Sub com_time_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles com_time.SelectedIndexChanged

        cmd_start.Enabled = True

        If com_time.Text = "1" Then
            SelectedTime = 1000
        End If
        If com_time.Text = "5" Then
            SelectedTime = 5000
        End If
        If com_time.Text = "10" Then
            SelectedTime = 10000
        End If
        If com_time.Text = "20" Then
            SelectedTime = 20000
        End If
        If com_time.Text = "30" Then
            SelectedTime = 30000
        End If
        If com_time.Text = "60" Then
            SelectedTime = 60000
        End If
        If com_time.Text = "120" Then
            SelectedTime = 120000
        End If
    End Sub

    Private Sub cmd_stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_stop.Click
        press_timer.Enabled = False
        cmd_start.Enabled = True
        com_time.Enabled = True
        com_keys.Enabled = True

    End Sub
End Class
