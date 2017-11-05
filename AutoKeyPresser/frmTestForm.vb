Public Class frmTest

    Dim SelectedKeys As String
    Dim SelectedTime As Integer

    Dim WshShell As Object = CreateObject("WScript.Shell")

    Dim hotkey As New HotKeyRegistryClass(Me.Handle)



    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        End
    End Sub

    Private Sub cmdAKP_Click(sender As Object, e As EventArgs) Handles cmdAKP.Click
        frmMain.Show()

    End Sub





    Private Sub frmTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        comKeys.Items.AddRange(funcAddKeysTest)
        comInterval.Items.AddRange(funcAddIntervalsTest)




        comNumberofKeys.Items.Add("1")
        comNumberofKeys.Items.Add("2")
        comNumberofKeys.Items.Add("3")
        comNumberofKeys.Items.Add("4")
        comNumberofKeys.Items.Add("5")
        comNumberofKeys.Items.Add("6")
        comNumberofKeys.Items.Add("7")
        comNumberofKeys.Items.Add("8")
        comNumberofKeys.Items.Add("9")
        comNumberofKeys.Items.Add("10")


        ''Hot key

        hotkey.Register(HotKeyRegistryClass.Modifiers.MOD_CTRL, Keys.F4).ToString()
        hotkey.Register(HotKeyRegistryClass.Modifiers.MOD_CTRL, Keys.S).ToString()
        hotkey.Register(HotKeyRegistryClass.Modifiers.MOD_CTRL, Keys.D).ToString()
        hotkey.Register(HotKeyRegistryClass.Modifiers.MOD_CTRL, Keys.F).ToString()










    End Sub
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = HotKeyRegistryClass.Messages.WM_HOTKEY Then 'NOT THE ACTUAL WINDOWS NAMESPACE
            Dim ID As String = m.WParam.ToString()
            Select Case ID
                Case 0 : MessageBox.Show("ctrl f4")
                Case 1 : MessageBox.Show("S")
                Case 2 : MessageBox.Show("D")
                Case 3 : MessageBox.Show("F")
            End Select
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub cmdPress_Click(sender As Object, e As EventArgs) Handles cmdPress.Click
        If comInterval.Text = "" Then

            keyComTimer.Enabled = False
        Else
            keyComTimer.Interval = funcInterval(comInterval.Text)
            keyComTimer.Enabled = True

        End If

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




    Private Sub cmdStop_Click(sender As Object, e As EventArgs) Handles cmdStop.Click
        keyComTimer.Enabled = False
    End Sub



    Private Sub keyComTimer_Tick(sender As Object, e As EventArgs) Handles keyComTimer.Tick

        WshShell.SendKeys(funcPressKeys(comKeys.Text))
        lblTick.ForeColor = Color.Coral

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

        ElseIf UserSelectedKey = "Spacebar" Then
            varKey = " "

        End If


        Return varKey

    End Function


    Function funcAddKeysTest()


        Dim KeyList() As String = {"-----Numbers-----", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-----Alphabets-----", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "-----Function Keys-----", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "-----Special Keys-----", "NumLock", "CapsLock", "ScrollLock", "TAB", "Return/Enter", "Ctrl", "Alt", "Shift", "ESC", "Delete", "Backspace", "DownArrow", "UpArrow", "LeftArrow", "RightArrow", "Home", "End", "Insert", "PageUp", "PageDown", "PrintScreen", "Spacebar"}

        Return KeyList
    End Function


    Function funcAddIntervalsTest()

        Dim IntervalList() As String = {"0.5", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "20", "40", "60", "120", "180", "360"}

        Return IntervalList
    End Function


    Private Sub comKeys_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comKeys.SelectedIndexChanged
        If comKeys.Text = "--Numbers--" Or comKeys.Text = "--Alphabets--" Or comKeys.Text = "--Function Keys--" Or comKeys.Text = "--Special Keys--" Then
            cmdPress.Enabled = False

        Else
            cmdPress.Enabled = True
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ' create new combo using code
        Dim newCombo As New ComboBox
        With newCombo
            .Left = 10
            .Top = 10
            .Name = "MyNewComboBox"

            ' add some items
            .Items.Add("Cool Bizs Inc.")
            .Items.Add("CodeGuru.com")



            .Visible = True
        End With

        ' add into the form
        Me.Controls.Add(newCombo)
    End Sub


    Private Sub comNumberofKeys_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comNumberofKeys.SelectedIndexChanged

        FlowLayoutPanel.Controls.Clear()
        ' create new buttons using code

        Dim I As Integer
        '' button parameters
        For I = 1 To comNumberofKeys.SelectedItem
            Dim btnDynamic As New Button
            Dim btnHeight As Integer = 21
            Dim btnWidth As Integer = 100
            Dim btnLeft As Integer = 30
            Dim btnTop As Integer = 30
            Dim btnName As String = "btnDynamic"
            Dim btnText As String = "Select A Key"

            With btnDynamic
                ''A event handler for the created button, which calls btnArrayButtonClick
                AddHandler btnDynamic.Click, AddressOf btnDynamicClick
                .Left = btnLeft
                .Top = btnTop
                .Name = btnName & I
                .Text = btnText
                .Height = btnHeight
                .Width = btnWidth
                .Enabled = True
                .Visible = True
                .Tag = btnText & I
            End With

            ' add into the form
            FlowLayoutPanel.Controls.Add(btnDynamic)

        Next

        If FlowLayoutPanel.Controls.Count < 0 Then
            Dim numberofButtons = FlowLayoutPanel.Controls(0)
            FlowLayoutPanel.Controls.Remove(numberofButtons)
            numberofButtons.Dispose()
        End If
    End Sub


    ''Assigning events to the dynamic buttons
    Public Sub btnDynamicClick(ByVal Sendr As Object, ByVal e As EventArgs)
        Dim btnEvent As Button
        btnEvent = CType(Sendr, Button)

        Dim btnDymanicName As String = btnEvent.Name
        ''MessageBox.Show(Str)

        frmKeyboard.Show()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmKeyboard.Show()
    End Sub

End Class