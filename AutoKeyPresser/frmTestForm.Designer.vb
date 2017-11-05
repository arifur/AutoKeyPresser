<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
        Me.comKeys = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdPress = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.txtPreview = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdAKP = New System.Windows.Forms.Button()
        Me.keyComTimer = New System.Windows.Forms.Timer(Me.components)
        Me.comInterval = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblIndicator = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpMultiKey = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.comNumberofKeys = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblTick = New System.Windows.Forms.Label()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.hotkeyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.grpMultiKey.SuspendLayout()
        Me.SuspendLayout()
        '
        'comKeys
        '
        Me.comKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comKeys.FormattingEnabled = True
        Me.comKeys.Location = New System.Drawing.Point(105, 24)
        Me.comKeys.Name = "comKeys"
        Me.comKeys.Size = New System.Drawing.Size(150, 21)
        Me.comKeys.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Keys to Press"
        '
        'cmdPress
        '
        Me.cmdPress.Location = New System.Drawing.Point(180, 132)
        Me.cmdPress.Name = "cmdPress"
        Me.cmdPress.Size = New System.Drawing.Size(75, 23)
        Me.cmdPress.TabIndex = 2
        Me.cmdPress.Text = "Press"
        Me.cmdPress.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(180, 161)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'txtPreview
        '
        Me.txtPreview.Location = New System.Drawing.Point(105, 75)
        Me.txtPreview.Multiline = True
        Me.txtPreview.Name = "txtPreview"
        Me.txtPreview.Size = New System.Drawing.Size(150, 51)
        Me.txtPreview.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Preview Window"
        '
        'cmdAKP
        '
        Me.cmdAKP.Location = New System.Drawing.Point(99, 161)
        Me.cmdAKP.Name = "cmdAKP"
        Me.cmdAKP.Size = New System.Drawing.Size(75, 23)
        Me.cmdAKP.TabIndex = 6
        Me.cmdAKP.Text = "AKP"
        Me.cmdAKP.UseVisualStyleBackColor = True
        '
        'keyComTimer
        '
        '
        'comInterval
        '
        Me.comInterval.FormattingEnabled = True
        Me.comInterval.Location = New System.Drawing.Point(105, 48)
        Me.comInterval.MaxLength = 7
        Me.comInterval.Name = "comInterval"
        Me.comInterval.Size = New System.Drawing.Size(150, 21)
        Me.comInterval.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Interval"
        '
        'cmdStop
        '
        Me.cmdStop.Location = New System.Drawing.Point(99, 132)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(75, 23)
        Me.cmdStop.TabIndex = 9
        Me.cmdStop.Text = "Stop"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Status:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(61, 197)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(39, 13)
        Me.lblStatus.TabIndex = 12
        Me.lblStatus.Text = "Label5"
        '
        'lblIndicator
        '
        Me.lblIndicator.AutoSize = True
        Me.lblIndicator.Location = New System.Drawing.Point(15, 221)
        Me.lblIndicator.Name = "lblIndicator"
        Me.lblIndicator.Size = New System.Drawing.Size(39, 13)
        Me.lblIndicator.TabIndex = 13
        Me.lblIndicator.Text = "Label5"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(661, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 205)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mouse Controller"
        '
        'grpMultiKey
        '
        Me.grpMultiKey.Controls.Add(Me.FlowLayoutPanel)
        Me.grpMultiKey.Controls.Add(Me.Label6)
        Me.grpMultiKey.Controls.Add(Me.comNumberofKeys)
        Me.grpMultiKey.Location = New System.Drawing.Point(290, 24)
        Me.grpMultiKey.Name = "grpMultiKey"
        Me.grpMultiKey.Size = New System.Drawing.Size(339, 268)
        Me.grpMultiKey.TabIndex = 15
        Me.grpMultiKey.TabStop = False
        Me.grpMultiKey.Text = "Multi Key"
        '
        'FlowLayoutPanel
        '
        Me.FlowLayoutPanel.Location = New System.Drawing.Point(9, 43)
        Me.FlowLayoutPanel.Name = "FlowLayoutPanel"
        Me.FlowLayoutPanel.Size = New System.Drawing.Size(316, 199)
        Me.FlowLayoutPanel.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Number of Keys"
        '
        'comNumberofKeys
        '
        Me.comNumberofKeys.FormattingEnabled = True
        Me.comNumberofKeys.Location = New System.Drawing.Point(94, 13)
        Me.comNumberofKeys.Name = "comNumberofKeys"
        Me.comNumberofKeys.Size = New System.Drawing.Size(121, 21)
        Me.comNumberofKeys.TabIndex = 16
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(8, 330)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "V Keyboard"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblTick
        '
        Me.lblTick.AutoSize = True
        Me.lblTick.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTick.Location = New System.Drawing.Point(11, 292)
        Me.lblTick.Name = "lblTick"
        Me.lblTick.Size = New System.Drawing.Size(55, 24)
        Me.lblTick.TabIndex = 0
        Me.lblTick.Text = "Tick:"
        Me.lblTick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTemp
        '
        Me.txtTemp.Location = New System.Drawing.Point(290, 347)
        Me.txtTemp.Multiline = True
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(145, 68)
        Me.txtTemp.TabIndex = 19
        '
        'hotkeyTimer
        '
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 549)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.lblTick)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.grpMultiKey)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblIndicator)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.comInterval)
        Me.Controls.Add(Me.cmdAKP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPreview)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdPress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comKeys)
        Me.Name = "frmTest"
        Me.Text = "TestForm"
        Me.grpMultiKey.ResumeLayout(False)
        Me.grpMultiKey.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comKeys As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdPress As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents txtPreview As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdAKP As System.Windows.Forms.Button
    Friend WithEvents keyComTimer As System.Windows.Forms.Timer
    Friend WithEvents comInterval As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblIndicator As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpMultiKey As System.Windows.Forms.GroupBox
    Friend WithEvents comNumberofKeys As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lblTick As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtTemp As TextBox
    Friend WithEvents hotkeyTimer As Timer
End Class
