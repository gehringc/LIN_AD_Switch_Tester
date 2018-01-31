Imports System.IO.Ports

Public Class Form1

    Dim PID As UShort = &HA04                           'ID for connecting to LIN Analyzer
    Dim PKSAPID As UShort = &H36                     'Aditional ID for connecting to LIN Analyzer
    Private WithEvents OnAnswerSource As PICkitS.LIN    'Register 2 different classes with events to handle...
    Private WithEvents OnReceiveSource As PICkitS.LIN   '...answers and receptions on separate threads
    Dim byteArray As New List(Of Integer)            'List to read Arduino serial data from buffer
    Dim packet As New List(Of Integer)               'List to sort Arduino serial data
    Dim lkas As Integer                              'Value of LKAS bit sent from Arduino
    Dim cruise As Integer                            'Value of Cruise but sent from Arduino
    Dim illumiStep As Integer = 22                   'Value of illumination brightness              '
    Dim firstByte As Byte                               'First byte in byte array received on LIN
    Dim secondByte As Byte                              '2nd byte in byte array received on LIN
    Dim thirdByte As Byte                               '3rd received on LIN
    Dim lastByte As Byte                                '4th received on LIN
    'The following are bits that represent the switch enabled on LIN''''''''''
    Dim hudBit As Byte
    Dim backBit As Byte
    Dim volBits As Byte
    Dim hangBBit As Byte
    Dim vrBit As Byte
    Dim pickBit As Byte
    Dim hangBit As Byte
    Dim sourceBit As Byte
    Dim scrollSWBit As Byte
    Dim menuBit As Byte
    Dim trackBits As Byte
    Dim scrollBits As Byte
    '
    Dim scrollState As Byte = 0                                 'Used to determine in interface the direction of scroll
    Dim flagBeep As Boolean = False                             'Used to indicate a trigger of sound
    Dim flagBeep2 As Boolean = False                            'Used to inidcate when to trigger a sound
    Dim prevDirec As Boolean = False                            'Used to rememeber in interface direction of scroll
    Dim scrollInt As Integer = 0                                'Value of scroll ticks detected since last update
    Dim flagIllumiState As Boolean = False                       'Used for changing the illumination state
    Dim illumiBit As Byte = &H0                                  'Data sent for illumination state on LIN
    Dim flagRunning As Boolean = True                            'If the measurement is running or nah
    Const baudrate As UShort = 19200                             'Constant definition of LIN baudrate
    Dim serialPorts As String()                                  'COM ports retrieved when searching for arduino
    Dim linOK As Boolean                                         'Used to indicate whether LIN device is set up or nah

    'Called when application is opened for first time, so load the components
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadArduino()
        LoadLIN()
        BeginMainProcess()
    End Sub

    'Sets up the port to handle the SerialPort to handle the data from the Arduino
    'The user can select the correct port if more than one COM port is detected
    Private Sub LoadArduino()
        Dim portName As String = ""
        'Get all of COM ports available
        serialPorts = SerialPort.GetPortNames()
        'If there are no ports found, close the port and update the Form
        If serialPorts.Length() = 0 Then
            If ArduinoPort.IsOpen Then
                ArduinoPort.Close()
            End If
            ArduinoStatus.Text = "NO ARDUINO FOUND"
            ArduinoStatus.ForeColor = Color.Red
            portName = "VOID"
            'delayTimer50.Enabled = False
        Else
            'If 1 port found, automatically select it. If multiple, have the user select the port 
            If serialPorts.Length() = 1 Then
                ArduinoPort.PortName = serialPorts(0)
                portName = serialPorts(0)
                ArduinoStatus.Text = "Arduino found on " + portName
            Else
                ComboBox1.Visible = True
                ComboBox1.DataSource = serialPorts
                ArduinoStatus.Text = "Select Arduino Port:"
                ArduinoPort.PortName = ComboBox1.SelectedItem
            End If
            'Once the port is selected, open it and let the data flow!
            If ArduinoPort.IsOpen <> True Then
                ArduinoPort.Open()
            End If
        End If
    End Sub

    'Sets up the LIN Analyzer interface
    Private Sub LoadLIN()
        If (PICkitS.Basic.Initialize_MyDevice(0, PID)) Then
            If (PICkitS.LIN.Configure_PICkitSerial_For_LIN()) Then
                PICkitS.Device.Set_Buffer_Flush_Parameters(True, True, 10, 10)
                StatusError.Text = "APG LIN Analyser correctly configured for LIN"
                linOK = True
            Else
                StatusError.Text = "Error configuring APG Analyser for LIN"
                linOK = False
            End If
        ElseIf (PICkitS.Basic.Initialize_MyDevice(0, PKSAPID)) Then
            If (PICkitS.LIN.Configure_PICkitSerial_For_LIN()) Then
                PICkitS.Device.Set_Buffer_Flush_Parameters(True, True, 10, 10)
                StatusError.Text = "PICkit Serial correctly configured for LIN"
                linOK = True
            Else
                StatusError.Text = "Error configuring PICkit Serial for LIN"
                linOK = False
            End If

        Else
            StatusError.Text = "Error initializing LIN tool"
            linOK = False
        End If

        If linOK Then
            Dim OnAnswerTemp As New PICkitS.LIN
            'Initialize new LIN object to register events
            RegisterEvents(OnAnswerTemp)
            'Set both sources to the same LIN object to provide separate threads for different events
            PICkitS.LIN.Change_LIN_BAUD_Rate(19200)
            PICkitS.LIN.Set_LIN_Options(True, True, False)
            RegisterEvents(OnAnswerSource)
            'Confirm the LIN objects are set
            PICkitS.Device.ReEstablish_Comm_Threads()
        End If
    End Sub

    'The timers follow the LIN (LDF) schedule. Because the precision is not critical for this test, I
    'used Windows Forms timers. See my other examples for running System Timers outside of the GUI thread
    'Enable all timers and start the first one to begin main loop.
    Private Sub BeginMainProcess()
        delayTimer50.Enabled = True
        delayTimer50.Start()
        delayTimer.Enabled = True
        LINsendTimer.Enabled = True
    End Sub

    'Called when the application is exiting, make sure to dispose all potentially running processes
    Private Sub Form1_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        PICkitS.Device.Cleanup()
        UnregisterEvents()
        ArduinoPort.Close()
    End Sub
    
    'Creat two objects to handle two separate reception events, per the PICkitS.LIN API
    Private Sub RegisterEvents(ByVal s As PICkitS.LIN)
        OnAnswerSource = s
        OnReceiveSource = s
    End Sub

    'Clear the objects
    Private Sub UnregisterEvents()
        OnAnswerSource = Nothing
        OnReceiveSource = Nothing
    End Sub

    '30ms timer that sends the Master request to the slave Switch 
    Private Sub DelayTimer_Tick(sender As Object, e As EventArgs) Handles delayTimer.Tick
        delayTimer.Stop()
        delayTimer50.Start()
        Dim ErrorString As String = ""
        Dim strgData(10) As Byte
        If linOK Then
            PICkitS.LIN.Transmit(&H99, strgData, 0, ErrorString)
        End If
    End Sub

    '50ms timer that sends the Master request to the slave Switch and then Updates the Form GUI 
    Private Sub DelayTimer50_Tick(sender As Object, e As EventArgs) Handles delayTimer50.Tick
        delayTimer50.Stop()
        LINsendTimer.Start()
        Dim ErrorString As String = ""
        Dim strgData(10) As Byte
        If linOK Then
            PICkitS.LIN.Transmit(&H99, strgData, 0, ErrorString)
        End If
        UpdateForm()
    End Sub

    '50ms timer that sends the Master frame to the slave Switch and then Updates the Form GUI 
    Private Sub LINsendTimer_Tick(sender As Object, e As EventArgs) Handles LINsendTimer.Tick
        LINsendTimer.Stop()
        delayTimer.Start()
        Dim ErrorString As String = ""
        Dim ByteCount As Byte = &H6
        Dim masterID As Byte = &H45
        Dim firstBits = illumiBit << 5
        firstBits = firstBits And &H20
        Dim secondBits = CByte(illumiStep)
        Dim thisByte = firstBits Or secondBits
        Dim byteSum As Int64 = CInt(thisByte) + CInt(masterID)
        If byteSum > 255 Then
            byteSum = byteSum - 255
        End If
        Dim checksum As Byte = Not CByte(byteSum)
        Dim data As Byte() = {thisByte, &HFF, &HFF, &HFF, &HFF, checksum}
        If linOK Then
            PICkitS.LIN.Transmit(masterID, data, ByteCount, ErrorString)
        End If
        UpdateForm()
    End Sub

    Private Sub HandleOnAnswer(ByVal masterID As Byte, ByVal data As Byte(), ByVal length As Byte, ByVal ErrorCode As Byte, ByVal baudrate As UShort, ByVal timestamp As Double) Handles OnAnswerSource.OnAnswer

        firstByte = data(0)
        secondByte = data(1)
        thirdByte = data(2)
        lastByte = data(3)
        If masterID = &H99 Then
            volBits = lastByte And &H3
            hudBit = firstByte And &H4
            backBit = firstByte And &H8
            hangBBit = firstByte And &H10
            vrBit = firstByte And &H20
            pickBit = firstByte And &H40
            hangBit = firstByte And &H80
            sourceBit = secondByte And &H1
            scrollSWBit = thirdByte And &H40
            menuBit = thirdByte And &H80
            trackBits = thirdByte And &H3
            scrollBits = thirdByte And &H3C
        End If

        If scrollBits <> 0 Then
            flagBeep = True
            scrollInt = CInt(scrollBits >> 2)
            PlaySystemSound()
        Else
            flagBeep = False
        End If

    End Sub

    Private Sub HandleOnReceive(ByVal masterID As Byte, ByVal data As Byte(), ByVal length As Byte, ByVal ErrorCode As Byte, ByVal Baud As UShort, ByVal Time As Double) Handles OnReceiveSource.OnReceive
        firstByte = data(0)
        secondByte = data(1)
        thirdByte = data(2)
        lastByte = data(3)
        If masterID = &H99 Then
            volBits = lastByte And &H3
            hudBit = firstByte And &H4
            backBit = firstByte And &H8
            hangBBit = firstByte And &H10
            vrBit = firstByte And &H20
            pickBit = firstByte And &H40
            hangBit = firstByte And &H80
            sourceBit = secondByte And &H1
            scrollSWBit = thirdByte And &H1
            menuBit = thirdByte And &H2
            trackBits = thirdByte And &HC
            scrollBits = thirdByte And &H10
        End If

        If scrollBits <> 0 Then
            flagBeep2 = True
            scrollInt = CInt(scrollBits >> 2)
            PlaySystemSound()
        Else
            flagBeep2 = False
        End If
    End Sub

    Private Sub UpdateForm()
        If ArduinoPort.IsOpen Then
            ProcessSerialData()
        End If
        mIllumiStep_Out.Text = illumiStep.ToString()
        If flagIllumiState Then
            mIllumiState_Out.Text = "ON"
        Else
            mIllumiState_Out.Text = "OFF"
        End If
        DecideHudSW()
        DecideVolSW()
        DecideBackSW()
        DecideHangBackSW()
        DecideHangSW()
        DecideMenuSW()
        DecidePickSW()
        DecideScroll()
        DecideScrollSW()
        DecideSourceSW()
        DecideTrackSW()
        DecideVRtalkSW()

    End Sub

    Private Sub ProcessSerialData()
        ProcessBuffer()
        Select Case lkas
            Case 1
                mResSW_Out.Visible = True
                mSetSW_Out.Visible = False
                mCancelSW_Out.Visible = False
                mMainSW_Out.Visible = False
            Case 2
                mResSW_Out.Visible = False
                mSetSW_Out.Visible = True
                mCancelSW_Out.Visible = False
                mMainSW_Out.Visible = False
            Case 3
                mResSW_Out.Visible = False
                mSetSW_Out.Visible = False
                mCancelSW_Out.Visible = True
                mMainSW_Out.Visible = False
            Case 4
                mResSW_Out.Visible = False
                mSetSW_Out.Visible = False
                mCancelSW_Out.Visible = False
                mMainSW_Out.Visible = True
            Case Else
                mResSW_Out.Visible = False
                mSetSW_Out.Visible = False
                mCancelSW_Out.Visible = False
                mMainSW_Out.Visible = False
        End Select
        Select Case cruise
            Case 1
                mDistanceSW_Out.Visible = True
                mLKASsw_Out.Visible = False
                mDistanceSW_Out.BackColor = Color.GreenYellow
                mLKASsw_Out.BackColor = SystemColors.Control
            Case 2
                mDistanceSW_Out.Visible = False
                mLKASsw_Out.Visible = True
                mDistanceSW_Out.BackColor = SystemColors.Control
                mLKASsw_Out.BackColor = Color.GreenYellow
            Case Else
                mDistanceSW_Out.Visible = False
                mLKASsw_Out.Visible = False
                mDistanceSW_Out.BackColor = SystemColors.Control
                mLKASsw_Out.BackColor = SystemColors.Control
        End Select
    End Sub

    Private Sub ProcessBuffer()
        If ArduinoPort.BytesToRead > 0 Then
            For i As Integer = 0 To ArduinoPort.BytesToRead Step 1
                byteArray.Add(ArduinoPort.ReadByte())
            Next
            ParseBuffer()
        End If
    End Sub

    Private Sub ParseBuffer()
        FindFirstByte()
        If (byteArray.Count >= 3) Then
            RemovePacket()
            lkas = packet.Item(1)
            cruise = packet.Item(2)
        End If
        If (byteArray.Count >= 3) Then
            ParseBuffer()
        End If
        packet.Clear()
    End Sub

    Private Sub FindFirstByte()
        If byteArray.Count > 0 Then
            If byteArray.First <> 255 Then
                byteArray.RemoveAt(0)
                FindFirstByte()
            End If
        End If
    End Sub

    Private Sub RemovePacket()
        If byteArray.Count > 2 Then
            packet.Add(byteArray.Item(0))
            packet.Add(byteArray.Item(1))
            packet.Add(byteArray.Item(2))
            byteArray.RemoveAt(2)
            byteArray.RemoveAt(1)
            byteArray.RemoveAt(0)
        End If
    End Sub

    Private Sub DecideHudSW()
        If hudBit <> 0 Then
            mHudSW_Out.Visible = True
            mHudSW_Out.BackColor = Color.GreenYellow
        Else
            mHudSW_Out.Visible = False
            mHudSW_Out.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub DecideBackSW()
        If backBit <> 0 Then
            mBackSW_Out.Visible = True
            mBackSW_Out.BackColor = Color.GreenYellow
        Else
            mBackSW_Out.Visible = False
            mBackSW_Out.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub DecideHangBackSW()
        If hangBBit <> 0 Then
            mHangBack_Out.Visible = True
            mHangBack_Out.BackColor = Color.GreenYellow
        Else
            mHangBack_Out.Visible = False
            mHangBack_Out.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub DecideVRtalkSW()
        If vrBit <> 0 Then
            mVRTalkSW_Out.Visible = True
            mVRTalkSW_Out.BackColor = Color.GreenYellow
        Else
            mVRTalkSW_Out.Visible = False
            mVRTalkSW_Out.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub DecidePickSW()
        If pickBit <> 0 Then
            mPickUpSW_Out.Visible = True
            mPickUpSW_Out.BackColor = Color.GreenYellow
        Else
            mPickUpSW_Out.Visible = False
            mPickUpSW_Out.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub DecideHangSW()
        If hangBit <> 0 Then
            mHangUpSW_Out.Visible = True
            mHangUpSW_Out.BackColor = Color.GreenYellow
        Else
            mHangUpSW_Out.Visible = False
            mHangUpSW_Out.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub DecideSourceSW()
        If sourceBit <> 0 Then
            mSourceSW_Out.Visible = True
            mSourceSW_Out.BackColor = Color.GreenYellow
        Else
            mSourceSW_Out.Visible = False
            mSourceSW_Out.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub DecideScrollSW()
        If scrollSWBit <> 0 Then
            mlScrollSW_Out.Visible = True
            mlScrollSW_Out.BackColor = Color.GreenYellow
        Else
            mlScrollSW_Out.Visible = False
            mlScrollSW_Out.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub DecideMenuSW()
        If menuBit <> 0 Then
            mMenu_Out.Visible = True
            mMenu_Out.BackColor = Color.GreenYellow
        Else
            mMenu_Out.Visible = False
            mMenu_Out.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub DecideTrackSW()
        Select Case trackBits
            Case &H1
                mTrackSW_Out.Visible = True
                mTrackSWR_Out.Visible = False
                mTrackSW_Out.BackColor = Color.GreenYellow
                mTrackSWR_Out.BackColor = SystemColors.Control
            Case &H2
                mTrackSW_Out.Visible = False
                mTrackSWR_Out.Visible = True
                mTrackSW_Out.BackColor = SystemColors.Control
                mTrackSWR_Out.BackColor = Color.GreenYellow
            Case Else
                mTrackSW_Out.Visible = False
                mTrackSWR_Out.Visible = False
                mTrackSW_Out.BackColor = SystemColors.Control
                mTrackSWR_Out.BackColor = SystemColors.Control
        End Select
    End Sub

    Private Sub DecideVolSW()
        Select Case volBits
            Case &H1
                mVolumeSW_Out.Visible = True
                mVolumeSWdown_Out.Visible = False
                mVolumeSW_Out.BackColor = Color.GreenYellow
                mVolumeSWdown_Out.BackColor = SystemColors.Control
            Case &H2
                mVolumeSW_Out.Visible = False
                mVolumeSWdown_Out.Visible = True
                mVolumeSW_Out.BackColor = SystemColors.Control
                mVolumeSWdown_Out.BackColor = Color.GreenYellow
            Case Else
                mVolumeSW_Out.Visible = False
                mVolumeSWdown_Out.Visible = False
                mVolumeSW_Out.BackColor = SystemColors.Control
                mVolumeSWdown_Out.BackColor = SystemColors.Control
        End Select
    End Sub

    Private Sub DecideScroll()
        If scrollState = 0 Then
            mlScroll_Out.Visible = False
            mlScrollD_Out.Visible = False
            mlScroll_Out.Text = ""
            mlScrollD_Out.Text = ""
            mlScroll_Out.BackColor = SystemColors.Control
            mlScrollD_Out.BackColor = SystemColors.Control
            If flagBeep = True Or flagBeep2 = True Then
                scrollState = scrollState + 1
            End If
        ElseIf scrollState = 1 Then
            If scrollInt <= 8 Then
                mlScroll_Out.Visible = True
                mlScrollD_Out.Visible = False
                mlScroll_Out.Text = "UP" + scrollInt.ToString()
                mlScrollD_Out.Text = ""
                mlScroll_Out.BackColor = Color.GreenYellow
                mlScrollD_Out.BackColor = SystemColors.Control
                prevDirec = False
            ElseIf scrollInt > 8 Then
                mlScroll_Out.Visible = False
                mlScrollD_Out.Visible = True
                mlScrollD_Out.Text = "DOWN" + (16 - scrollInt).ToString()
                mlScroll_Out.Text = ""
                mlScroll_Out.BackColor = SystemColors.Control
                mlScrollD_Out.BackColor = Color.GreenYellow
                prevDirec = True
            End If
            scrollState = scrollState + 1
        ElseIf scrollState = 2 Then
            If prevDirec = False Then
                mlScroll_Out.Visible = True
                mlScrollD_Out.Visible = False
                mlScroll_Out.Text = "UP" + scrollInt.ToString()
                mlScrollD_Out.Text = ""
                mlScroll_Out.BackColor = Color.GreenYellow
                mlScrollD_Out.BackColor = SystemColors.Control
            Else
                mlScroll_Out.Visible = False
                mlScrollD_Out.Visible = True
                mlScrollD_Out.Text = "DOWN" + (16 - scrollInt).ToString()
                mlScroll_Out.Text = ""
                mlScroll_Out.BackColor = SystemColors.Control
                mlScrollD_Out.BackColor = Color.GreenYellow
            End If
            scrollState = 0
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If illumiStep < 22 Then
            illumiStep = illumiStep + 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        If illumiStep > 0 Then
            illumiStep = illumiStep - 1
        End If
    End Sub

    Private Sub IllumiState_button_Click(sender As Object, e As EventArgs) Handles illumiState_button.Click
        flagIllumiState = Not flagIllumiState
        illumiBit = Not illumiBit
    End Sub

    Private Sub ButtonStartStop_Click(sender As Object, e As EventArgs) Handles mButtonStartStop.Click
        flagRunning = Not flagRunning
        If Not flagRunning Then
            StopMeasurement()
        Else
            StartMeasurement()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        StopMeasurement()
        LoadArduino()
        StartMeasurement()
    End Sub

    Private Sub StopMeasurement()
        If ArduinoPort.IsOpen Then
            ArduinoPort.DiscardInBuffer()
            ArduinoPort.Close()
        End If
        LINsendTimer.Stop()
        delayTimer.Stop()
        delayTimer50.Stop()
        mLabelMeasurementStatus.Text = "Status: No measurement is currently running."
        mButtonStartStop.Text = "Start measurement."
    End Sub

    Private Sub StartMeasurement()
        LoadArduino()
        delayTimer50.Start()
        mLabelMeasurementStatus.Text = "Status: Measurement is running."
        mButtonStartStop.Text = "Stop measurement."
    End Sub

    Public Sub PlaySystemSound()
        My.Computer.Audio.PlaySystemSound(
         System.Media.SystemSounds.Asterisk)
    End Sub

End Class
