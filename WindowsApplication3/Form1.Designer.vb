<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.mlScrollD_Out = New System.Windows.Forms.TextBox()
        Me.mVolumeSWdown_Out = New System.Windows.Forms.TextBox()
        Me.mTrackSWR_Out = New System.Windows.Forms.TextBox()
        Me.mSourceSW_Out = New System.Windows.Forms.TextBox()
        Me.mHangBack_Out = New System.Windows.Forms.TextBox()
        Me.illumiState_button = New System.Windows.Forms.Button()
        Me.mLabelMeasurementStatus = New System.Windows.Forms.Label()
        Me.mGroupboxMeasurementControl = New System.Windows.Forms.GroupBox()
        Me.mButtonStartStop = New System.Windows.Forms.Button()
        Me.mVolumeSW_Out = New System.Windows.Forms.TextBox()
        Me.mMainSW_Out = New System.Windows.Forms.TextBox()
        Me.mCancelSW_Out = New System.Windows.Forms.TextBox()
        Me.mSetSW_Out = New System.Windows.Forms.TextBox()
        Me.mResSW_Out = New System.Windows.Forms.TextBox()
        Me.mLKASsw_Out = New System.Windows.Forms.TextBox()
        Me.mHudSW_Out = New System.Windows.Forms.TextBox()
        Me.mDistanceSW_Out = New System.Windows.Forms.TextBox()
        Me.mlScroll_Out = New System.Windows.Forms.TextBox()
        Me.mTrackSW_Out = New System.Windows.Forms.TextBox()
        Me.mMenu_Out = New System.Windows.Forms.TextBox()
        Me.mHangUpSW_Out = New System.Windows.Forms.TextBox()
        Me.mPickUpSW_Out = New System.Windows.Forms.TextBox()
        Me.mlScrollSW_Out = New System.Windows.Forms.TextBox()
        Me.mBackSW_Out = New System.Windows.Forms.TextBox()
        Me.mVRTalkSW_Out = New System.Windows.Forms.TextBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.mIllumiState_Out = New System.Windows.Forms.TextBox()
        Me.IllumiSW_Label = New System.Windows.Forms.Label()
        Me.mIllumiStep_Out = New System.Windows.Forms.TextBox()
        Me.IllumiStep_Label = New System.Windows.Forms.Label()
        Me.ArduinoPort = New System.IO.Ports.SerialPort(Me.components)
        Me.LINsendTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StatusError = New System.Windows.Forms.Label()
        Me.delayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.delayTimer50 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ArduinoStatus = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.mGroupboxMeasurementControl.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mlScrollD_Out
        '
        Me.mlScrollD_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mlScrollD_Out.Location = New System.Drawing.Point(106, 139)
        Me.mlScrollD_Out.Name = "mlScrollD_Out"
        Me.mlScrollD_Out.ReadOnly = True
        Me.mlScrollD_Out.Size = New System.Drawing.Size(66, 20)
        Me.mlScrollD_Out.TabIndex = 43
        '
        'mVolumeSWdown_Out
        '
        Me.mVolumeSWdown_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mVolumeSWdown_Out.Location = New System.Drawing.Point(12, 139)
        Me.mVolumeSWdown_Out.Name = "mVolumeSWdown_Out"
        Me.mVolumeSWdown_Out.ReadOnly = True
        Me.mVolumeSWdown_Out.Size = New System.Drawing.Size(66, 20)
        Me.mVolumeSWdown_Out.TabIndex = 40
        '
        'mTrackSWR_Out
        '
        Me.mTrackSWR_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mTrackSWR_Out.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mTrackSWR_Out.Location = New System.Drawing.Point(176, 204)
        Me.mTrackSWR_Out.Name = "mTrackSWR_Out"
        Me.mTrackSWR_Out.ReadOnly = True
        Me.mTrackSWR_Out.Size = New System.Drawing.Size(66, 20)
        Me.mTrackSWR_Out.TabIndex = 37
        '
        'mSourceSW_Out
        '
        Me.mSourceSW_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mSourceSW_Out.Location = New System.Drawing.Point(176, 270)
        Me.mSourceSW_Out.Name = "mSourceSW_Out"
        Me.mSourceSW_Out.ReadOnly = True
        Me.mSourceSW_Out.Size = New System.Drawing.Size(66, 20)
        Me.mSourceSW_Out.TabIndex = 36
        '
        'mHangBack_Out
        '
        Me.mHangBack_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mHangBack_Out.Location = New System.Drawing.Point(106, 358)
        Me.mHangBack_Out.Name = "mHangBack_Out"
        Me.mHangBack_Out.ReadOnly = True
        Me.mHangBack_Out.Size = New System.Drawing.Size(66, 20)
        Me.mHangBack_Out.TabIndex = 34
        '
        'illumiState_button
        '
        Me.illumiState_button.AutoSize = True
        Me.illumiState_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.illumiState_button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.illumiState_button.Location = New System.Drawing.Point(106, 76)
        Me.illumiState_button.Margin = New System.Windows.Forms.Padding(2)
        Me.illumiState_button.Name = "illumiState_button"
        Me.illumiState_button.Size = New System.Drawing.Size(50, 23)
        Me.illumiState_button.TabIndex = 30
        Me.illumiState_button.Text = "Toggle"
        Me.illumiState_button.UseVisualStyleBackColor = True
        '
        'mLabelMeasurementStatus
        '
        Me.mLabelMeasurementStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mLabelMeasurementStatus.Location = New System.Drawing.Point(177, 25)
        Me.mLabelMeasurementStatus.Name = "mLabelMeasurementStatus"
        Me.mLabelMeasurementStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mLabelMeasurementStatus.Size = New System.Drawing.Size(169, 34)
        Me.mLabelMeasurementStatus.TabIndex = 2
        Me.mLabelMeasurementStatus.Text = "Status: Measurement is running"
        '
        'mGroupboxMeasurementControl
        '
        Me.mGroupboxMeasurementControl.Controls.Add(Me.mLabelMeasurementStatus)
        Me.mGroupboxMeasurementControl.Controls.Add(Me.mButtonStartStop)
        Me.mGroupboxMeasurementControl.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.mGroupboxMeasurementControl.Location = New System.Drawing.Point(20, 10)
        Me.mGroupboxMeasurementControl.Name = "mGroupboxMeasurementControl"
        Me.mGroupboxMeasurementControl.Size = New System.Drawing.Size(361, 62)
        Me.mGroupboxMeasurementControl.TabIndex = 11
        Me.mGroupboxMeasurementControl.TabStop = False
        Me.mGroupboxMeasurementControl.Text = "Measurement Control"
        '
        'mButtonStartStop
        '
        Me.mButtonStartStop.AutoSize = True
        Me.mButtonStartStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mButtonStartStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mButtonStartStop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mButtonStartStop.Location = New System.Drawing.Point(10, 25)
        Me.mButtonStartStop.Name = "mButtonStartStop"
        Me.mButtonStartStop.Size = New System.Drawing.Size(105, 23)
        Me.mButtonStartStop.TabIndex = 1
        Me.mButtonStartStop.Text = "Stop measurement"
        Me.ToolTip1.SetToolTip(Me.mButtonStartStop, "Use this button to control when the system is awake/asleep. Use when recording cu" &
        "rrent measurements")
        Me.mButtonStartStop.UseVisualStyleBackColor = True
        '
        'mVolumeSW_Out
        '
        Me.mVolumeSW_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mVolumeSW_Out.Location = New System.Drawing.Point(12, 58)
        Me.mVolumeSW_Out.Name = "mVolumeSW_Out"
        Me.mVolumeSW_Out.ReadOnly = True
        Me.mVolumeSW_Out.Size = New System.Drawing.Size(66, 20)
        Me.mVolumeSW_Out.TabIndex = 23
        '
        'mMainSW_Out
        '
        Me.mMainSW_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mMainSW_Out.Location = New System.Drawing.Point(24, 137)
        Me.mMainSW_Out.Name = "mMainSW_Out"
        Me.mMainSW_Out.ReadOnly = True
        Me.mMainSW_Out.Size = New System.Drawing.Size(66, 20)
        Me.mMainSW_Out.TabIndex = 36
        '
        'mCancelSW_Out
        '
        Me.mCancelSW_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mCancelSW_Out.Location = New System.Drawing.Point(129, 139)
        Me.mCancelSW_Out.Name = "mCancelSW_Out"
        Me.mCancelSW_Out.ReadOnly = True
        Me.mCancelSW_Out.Size = New System.Drawing.Size(66, 20)
        Me.mCancelSW_Out.TabIndex = 35
        '
        'mSetSW_Out
        '
        Me.mSetSW_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mSetSW_Out.Location = New System.Drawing.Point(129, 204)
        Me.mSetSW_Out.Name = "mSetSW_Out"
        Me.mSetSW_Out.ReadOnly = True
        Me.mSetSW_Out.Size = New System.Drawing.Size(66, 20)
        Me.mSetSW_Out.TabIndex = 34
        '
        'mResSW_Out
        '
        Me.mResSW_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mResSW_Out.Location = New System.Drawing.Point(129, 58)
        Me.mResSW_Out.Name = "mResSW_Out"
        Me.mResSW_Out.ReadOnly = True
        Me.mResSW_Out.Size = New System.Drawing.Size(66, 20)
        Me.mResSW_Out.TabIndex = 32
        '
        'mLKASsw_Out
        '
        Me.mLKASsw_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mLKASsw_Out.Location = New System.Drawing.Point(129, 256)
        Me.mLKASsw_Out.Name = "mLKASsw_Out"
        Me.mLKASsw_Out.ReadOnly = True
        Me.mLKASsw_Out.Size = New System.Drawing.Size(66, 20)
        Me.mLKASsw_Out.TabIndex = 33
        '
        'mHudSW_Out
        '
        Me.mHudSW_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mHudSW_Out.Location = New System.Drawing.Point(24, 58)
        Me.mHudSW_Out.Name = "mHudSW_Out"
        Me.mHudSW_Out.ReadOnly = True
        Me.mHudSW_Out.Size = New System.Drawing.Size(66, 20)
        Me.mHudSW_Out.TabIndex = 3
        '
        'mDistanceSW_Out
        '
        Me.mDistanceSW_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mDistanceSW_Out.Location = New System.Drawing.Point(24, 256)
        Me.mDistanceSW_Out.Name = "mDistanceSW_Out"
        Me.mDistanceSW_Out.ReadOnly = True
        Me.mDistanceSW_Out.Size = New System.Drawing.Size(66, 20)
        Me.mDistanceSW_Out.TabIndex = 32
        '
        'mlScroll_Out
        '
        Me.mlScroll_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mlScroll_Out.Location = New System.Drawing.Point(106, 91)
        Me.mlScroll_Out.Name = "mlScroll_Out"
        Me.mlScroll_Out.ReadOnly = True
        Me.mlScroll_Out.Size = New System.Drawing.Size(66, 20)
        Me.mlScroll_Out.TabIndex = 11
        '
        'mTrackSW_Out
        '
        Me.mTrackSW_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mTrackSW_Out.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mTrackSW_Out.Location = New System.Drawing.Point(36, 204)
        Me.mTrackSW_Out.Name = "mTrackSW_Out"
        Me.mTrackSW_Out.ReadOnly = True
        Me.mTrackSW_Out.Size = New System.Drawing.Size(66, 20)
        Me.mTrackSW_Out.TabIndex = 5
        '
        'mMenu_Out
        '
        Me.mMenu_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mMenu_Out.Location = New System.Drawing.Point(208, 58)
        Me.mMenu_Out.Name = "mMenu_Out"
        Me.mMenu_Out.ReadOnly = True
        Me.mMenu_Out.Size = New System.Drawing.Size(66, 20)
        Me.mMenu_Out.TabIndex = 13
        '
        'mHangUpSW_Out
        '
        Me.mHangUpSW_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mHangUpSW_Out.Location = New System.Drawing.Point(106, 347)
        Me.mHangUpSW_Out.Name = "mHangUpSW_Out"
        Me.mHangUpSW_Out.ReadOnly = True
        Me.mHangUpSW_Out.Size = New System.Drawing.Size(66, 20)
        Me.mHangUpSW_Out.TabIndex = 19
        '
        'mPickUpSW_Out
        '
        Me.mPickUpSW_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mPickUpSW_Out.Location = New System.Drawing.Point(12, 347)
        Me.mPickUpSW_Out.Name = "mPickUpSW_Out"
        Me.mPickUpSW_Out.ReadOnly = True
        Me.mPickUpSW_Out.Size = New System.Drawing.Size(66, 20)
        Me.mPickUpSW_Out.TabIndex = 17
        '
        'mlScrollSW_Out
        '
        Me.mlScrollSW_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mlScrollSW_Out.Location = New System.Drawing.Point(106, 115)
        Me.mlScrollSW_Out.Name = "mlScrollSW_Out"
        Me.mlScrollSW_Out.ReadOnly = True
        Me.mlScrollSW_Out.Size = New System.Drawing.Size(66, 20)
        Me.mlScrollSW_Out.TabIndex = 15
        '
        'mBackSW_Out
        '
        Me.mBackSW_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mBackSW_Out.Location = New System.Drawing.Point(176, 256)
        Me.mBackSW_Out.Name = "mBackSW_Out"
        Me.mBackSW_Out.ReadOnly = True
        Me.mBackSW_Out.Size = New System.Drawing.Size(66, 20)
        Me.mBackSW_Out.TabIndex = 9
        '
        'mVRTalkSW_Out
        '
        Me.mVRTalkSW_Out.BackColor = System.Drawing.Color.GreenYellow
        Me.mVRTalkSW_Out.Location = New System.Drawing.Point(208, 347)
        Me.mVRTalkSW_Out.Name = "mVRTalkSW_Out"
        Me.mVRTalkSW_Out.ReadOnly = True
        Me.mVRTalkSW_Out.Size = New System.Drawing.Size(66, 20)
        Me.mVRTalkSW_Out.TabIndex = 7
        '
        'button2
        '
        Me.button2.AutoSize = True
        Me.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.button2.BackColor = System.Drawing.SystemColors.Control
        Me.button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.button2.Location = New System.Drawing.Point(106, 40)
        Me.button2.Margin = New System.Windows.Forms.Padding(2)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(45, 23)
        Me.button2.TabIndex = 29
        Me.button2.Text = "Down"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.AutoSize = True
        Me.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.button1.BackColor = System.Drawing.SystemColors.Control
        Me.button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.button1.Location = New System.Drawing.Point(106, 11)
        Me.button1.Margin = New System.Windows.Forms.Padding(2)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(31, 23)
        Me.button1.TabIndex = 28
        Me.button1.Text = "Up"
        Me.button1.UseVisualStyleBackColor = True
        '
        'mIllumiState_Out
        '
        Me.mIllumiState_Out.Location = New System.Drawing.Point(170, 83)
        Me.mIllumiState_Out.Name = "mIllumiState_Out"
        Me.mIllumiState_Out.ReadOnly = True
        Me.mIllumiState_Out.Size = New System.Drawing.Size(66, 20)
        Me.mIllumiState_Out.TabIndex = 27
        '
        'IllumiSW_Label
        '
        Me.IllumiSW_Label.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IllumiSW_Label.Location = New System.Drawing.Point(20, 83)
        Me.IllumiSW_Label.Name = "IllumiSW_Label"
        Me.IllumiSW_Label.Size = New System.Drawing.Size(80, 14)
        Me.IllumiSW_Label.TabIndex = 26
        Me.IllumiSW_Label.Text = "ILLUMI STATE"
        '
        'mIllumiStep_Out
        '
        Me.mIllumiStep_Out.Location = New System.Drawing.Point(170, 34)
        Me.mIllumiStep_Out.Name = "mIllumiStep_Out"
        Me.mIllumiStep_Out.ReadOnly = True
        Me.mIllumiStep_Out.Size = New System.Drawing.Size(66, 20)
        Me.mIllumiStep_Out.TabIndex = 24
        '
        'IllumiStep_Label
        '
        Me.IllumiStep_Label.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IllumiStep_Label.Location = New System.Drawing.Point(33, 34)
        Me.IllumiStep_Label.Name = "IllumiStep_Label"
        Me.IllumiStep_Label.Size = New System.Drawing.Size(67, 14)
        Me.IllumiStep_Label.TabIndex = 10
        Me.IllumiStep_Label.Text = "ILLUMI Step"
        '
        'ArduinoPort
        '
        Me.ArduinoPort.BaudRate = 4800
        Me.ArduinoPort.PortName = "COM4"
        '
        'LINsendTimer
        '
        Me.LINsendTimer.Interval = 10
        '
        'StatusError
        '
        Me.StatusError.AutoSize = True
        Me.StatusError.Location = New System.Drawing.Point(40, 83)
        Me.StatusError.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StatusError.Name = "StatusError"
        Me.StatusError.Size = New System.Drawing.Size(67, 13)
        Me.StatusError.TabIndex = 12
        Me.StatusError.Text = "No LIN Data"
        '
        'delayTimer
        '
        Me.delayTimer.Interval = 30
        '
        'delayTimer50
        '
        Me.delayTimer50.Interval = 50
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.button1)
        Me.GroupBox3.Controls.Add(Me.mIllumiStep_Out)
        Me.GroupBox3.Controls.Add(Me.button2)
        Me.GroupBox3.Controls.Add(Me.IllumiStep_Label)
        Me.GroupBox3.Controls.Add(Me.IllumiSW_Label)
        Me.GroupBox3.Controls.Add(Me.mIllumiState_Out)
        Me.GroupBox3.Controls.Add(Me.illumiState_button)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox3.Location = New System.Drawing.Point(404, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(276, 114)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Illumination Control"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.mVolumeSW_Out)
        Me.GroupBox1.Controls.Add(Me.mMenu_Out)
        Me.GroupBox1.Controls.Add(Me.mlScrollD_Out)
        Me.GroupBox1.Controls.Add(Me.mlScroll_Out)
        Me.GroupBox1.Controls.Add(Me.mSourceSW_Out)
        Me.GroupBox1.Controls.Add(Me.mVolumeSWdown_Out)
        Me.GroupBox1.Controls.Add(Me.mHangBack_Out)
        Me.GroupBox1.Controls.Add(Me.mlScrollSW_Out)
        Me.GroupBox1.Controls.Add(Me.mTrackSWR_Out)
        Me.GroupBox1.Controls.Add(Me.mTrackSW_Out)
        Me.GroupBox1.Controls.Add(Me.mPickUpSW_Out)
        Me.GroupBox1.Controls.Add(Me.mHangUpSW_Out)
        Me.GroupBox1.Controls.Add(Me.mVRTalkSW_Out)
        Me.GroupBox1.Controls.Add(Me.mBackSW_Out)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(42, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 406)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Audio SW"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(206, 330)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "VR Talk SW"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(218, 41)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Menu SW"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(10, 330)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Pick Up SW"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(92, 330)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Hang Up/Back SW"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(164, 239)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Back/Source SW"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(174, 180)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Track SW right"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(34, 180)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Track SW left"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(6, 122)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Volume Down"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(10, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Volume Up"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(94, 67)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(90, 103)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Scroll SW"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.mHudSW_Out)
        Me.GroupBox2.Controls.Add(Me.mMainSW_Out)
        Me.GroupBox2.Controls.Add(Me.mResSW_Out)
        Me.GroupBox2.Controls.Add(Me.mCancelSW_Out)
        Me.GroupBox2.Controls.Add(Me.mSetSW_Out)
        Me.GroupBox2.Controls.Add(Me.mLKASsw_Out)
        Me.GroupBox2.Controls.Add(Me.mDistanceSW_Out)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox2.Location = New System.Drawing.Point(366, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 406)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cruise SW"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(132, 122)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 13)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Cancel SW"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(126, 187)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Set SW"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(126, 239)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Lane Keep SW"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(139, 41)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Res SW"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(22, 239)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Distance SW"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(22, 122)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Main SW"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(22, 41)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "HUD SW"
        '
        'ArduinoStatus
        '
        Me.ArduinoStatus.AutoSize = True
        Me.ArduinoStatus.Location = New System.Drawing.Point(40, 106)
        Me.ArduinoStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ArduinoStatus.Name = "ArduinoStatus"
        Me.ArduinoStatus.Size = New System.Drawing.Size(93, 13)
        Me.ArduinoStatus.TabIndex = 44
        Me.ArduinoStatus.Text = "No Arduino Found"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"COM4"})
        Me.ComboBox1.Location = New System.Drawing.Point(158, 106)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(224, 21)
        Me.ComboBox1.TabIndex = 45
        Me.ComboBox1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(739, 564)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ArduinoStatus)
        Me.Controls.Add(Me.StatusError)
        Me.Controls.Add(Me.mGroupboxMeasurementControl)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "New Model - Steering Switch - LIN + AD Function Tester"
        Me.TransparencyKey = System.Drawing.Color.LawnGreen
        Me.mGroupboxMeasurementControl.ResumeLayout(False)
        Me.mGroupboxMeasurementControl.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents mlScrollD_Out As System.Windows.Forms.TextBox
    Private WithEvents mVolumeSWdown_Out As System.Windows.Forms.TextBox
    Private WithEvents mTrackSWR_Out As System.Windows.Forms.TextBox
    Private WithEvents mSourceSW_Out As System.Windows.Forms.TextBox
    Private WithEvents mHangBack_Out As System.Windows.Forms.TextBox
    Private WithEvents illumiState_button As System.Windows.Forms.Button
    Private WithEvents mLabelMeasurementStatus As System.Windows.Forms.Label
    Private WithEvents mGroupboxMeasurementControl As System.Windows.Forms.GroupBox
    Private WithEvents mButtonStartStop As System.Windows.Forms.Button
    Private WithEvents mVolumeSW_Out As System.Windows.Forms.TextBox
    Private WithEvents mHudSW_Out As System.Windows.Forms.TextBox
    Private WithEvents mMainSW_Out As System.Windows.Forms.TextBox
    Private WithEvents mCancelSW_Out As System.Windows.Forms.TextBox
    Private WithEvents mSetSW_Out As System.Windows.Forms.TextBox
    Private WithEvents mResSW_Out As System.Windows.Forms.TextBox
    Private WithEvents mLKASsw_Out As System.Windows.Forms.TextBox
    Private WithEvents mDistanceSW_Out As System.Windows.Forms.TextBox
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents mIllumiState_Out As System.Windows.Forms.TextBox
    Private WithEvents IllumiSW_Label As System.Windows.Forms.Label
    Private WithEvents mIllumiStep_Out As System.Windows.Forms.TextBox
    Private WithEvents IllumiStep_Label As System.Windows.Forms.Label
    Private WithEvents mlScroll_Out As System.Windows.Forms.TextBox
    Private WithEvents mTrackSW_Out As System.Windows.Forms.TextBox
    Private WithEvents mMenu_Out As System.Windows.Forms.TextBox
    Private WithEvents mHangUpSW_Out As System.Windows.Forms.TextBox
    Private WithEvents mPickUpSW_Out As System.Windows.Forms.TextBox
    Private WithEvents mlScrollSW_Out As System.Windows.Forms.TextBox
    Private WithEvents mBackSW_Out As System.Windows.Forms.TextBox
    Private WithEvents mVRTalkSW_Out As System.Windows.Forms.TextBox
    Friend WithEvents ArduinoPort As System.IO.Ports.SerialPort
    Friend WithEvents LINsendTimer As System.Windows.Forms.Timer
    Friend WithEvents StatusError As System.Windows.Forms.Label
    Private WithEvents delayTimer As System.Windows.Forms.Timer
    Private WithEvents delayTimer50 As System.Windows.Forms.Timer
    Private WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ArduinoStatus As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
