''' <summary>
''' Class to call the Greaseweazle hardware and action the results.
''' </summary>
Public Class GreaseWeazle
    Public ReadOnly Property Version As String = "v0.1, for GW 0.24"

    Public ReadOnly Property GWMinAction As Integer = 0
    Public ReadOnly Property GWMaxAction As Integer = 10

    ''' <summary>
    ''' GWRead: Instructs the GW to read tracks from the floppy disk, using the floppy drive.
    ''' </summary>
    ''' <returns>Integer, 0</returns>
    Public ReadOnly Property GWRead As Integer = 0       'call gw.py read
    ''' <summary>
    ''' GWWrite: Instructs the GW to write tracks to the floppy disk, using the floppy drive from the selected File. (several formats supported for writing)
    ''' </summary>
    ''' <returns>Integer, 1</returns>
    Public ReadOnly Property GWWrite As Integer = 1      'call gw.py write
    Public ReadOnly Property GWErase As Integer = 2      'call gw.py erase
    Public ReadOnly Property GWReset As Integer = 3      'call gw.py reset
    Public ReadOnly Property GWUpdate As Integer = 4     'call gw.py update
    Public ReadOnly Property GWSetPin As Integer = 5     'call gw.py pin
    Public ReadOnly Property GWFirmware As Integer = 6   'call gw.py update --bootloader
    Public ReadOnly Property GWInfo As Integer = 7       'call gw.py info
    Public ReadOnly Property GWBandwidth As Integer = 8  'call gw.py bandwidth
    Public ReadOnly Property GWDelays As Integer = 9     'call gw.py delays
    Public ReadOnly Property GWSeek As Integer = 10      'call gw.py seek

    Public ReadOnly Property PinLow As Integer = 0
    Public ReadOnly Property PinHigh As Integer = 1

    Public Property MinTrack As Integer = 0
    Public Property MaxTrack As Integer = 85

    Public Property MinOffset As Integer = -9
    Public Property MaxOffset As Integer = 9

    Private Const WPC_FormatSTR As String = "mfm,fm,gcr"
    Private WPC_Formats As String() = WPC_FormatSTR.Split(CChar(","))

    Private Const DriveSTR As String = "A,B,0,1,2"
    Private Drives As String() = DriveSTR.Split(CChar(","))

    Private P_RPM As Integer = 300
    Private P_BitCellDataRate As Integer = 250
    Private P_Filename As String
    Private P_StartTrack As Integer = 0
    Private P_EndTrack As Integer = 83
    Private P_TrackGroup As String
    Private P_F7Device As Boolean = False
    Private P_Drive As String = "A"
    Private P_Revolutions As Integer = 5
    Private P_COMPort As String
    Private P_Sides As String = "0-1"
    Private P_Step As Integer = 1
    Private P_HeadOffsetEnable As Boolean = False
    Private P_HeadOffsetTrackCount As Integer = -8  'For 5.25" FDD flippy drives only!! (C64/Atari XE .. ?)
    Private P_WritePreCompensate As Boolean = False
    Private P_WPC_Type As String = "mfm"
    Private P_WPC_TrackRange As String = ">="
    Private P_WPC_Tracks As Integer = 40
    Private P_WPC_Width_NanoSeconds As Integer = 125
    Private P_EraseEmptyTracks As Boolean = False
    Private P_ScriptLocation As String
    Private P_ExcuteScript As Boolean = False
    Private P_ExecuteScriptHidden As Integer = 0
    Private P_ExecuteScriptOnGWRead_Only As Boolean = False
    Private P_Action As Integer = -1
    Private P_Pin As Integer = 2
    Private P_PinVoltage As Integer = 0
    Private P_PinVoltageLetter As Char = CChar("L")
    Private P_SeekTrack As Integer = 0
    Private P_PythonEXE As String
    Private P_PythonScript As String
    Private P_ErrorString As String = "No Error!"
    Private P_ResultString As String
    Private P_SaveLogFile As Boolean = False

    ''' <summary>
    ''' Clears the ErrorString
    ''' </summary>
    Public Sub ClearError()
        P_ErrorString = ""
    End Sub

    ''' <summary>
    ''' Holds the results of the GW action.
    ''' </summary>
    ''' <returns>String, containing GW action output.</returns>
    Public ReadOnly Property Results As String
        Get
            Return P_ResultString
        End Get
    End Property

    ''' <summary>
    ''' Runs an exe or batch file, with the given arguments, with window shown, minimized or hidden.
    ''' </summary>
    ''' <param name="fileToRun">Batch file or EXE to run</param>
    ''' <param name="Arguments">Argument for the batch/exe</param>
    ''' <param name="WinState">Windows state of the launched program</param>
    ''' <returns></returns>
    Private Function ExecuteCommand(ByVal fileToRun As String, ByVal Arguments As String, ByVal WinState As Integer) As Boolean
        Dim CMD As New Process
        Try
            CMD.StartInfo.FileName = fileToRun
            CMD.StartInfo.Arguments = Arguments
            Select Case WinState
                Case 0, 1   'Execute With normal cmd window (ie chkbox onscreen ticked or unticked)
                    CMD.StartInfo.UseShellExecute = True
                    CMD.StartInfo.WindowStyle = ProcessWindowStyle.Normal

                Case 2      'Execute With hidden cmd window (ie chkbox onscreen is third state/half checked)
                    CMD.StartInfo.UseShellExecute = True
                    CMD.StartInfo.WindowStyle = ProcessWindowStyle.Minimized

                Case 3      'Execute With no cmd window
                    CMD.StartInfo.UseShellExecute = False
                    CMD.StartInfo.CreateNoWindow = True
            End Select

            CMD.StartInfo.WorkingDirectory = IO.Path.GetDirectoryName(fileToRun)
            CMD.Start()
            Return True
        Catch
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Override the default list of disk formats for WPC
    ''' </summary>
    ''' <param name="NewFormats">CSV list of strings representing disk formats</param>
    ''' <returns>String, containing a list of comma separated strings representing disk formats</returns>
    Public Function UpdateWPC_Formats(ByVal NewFormats As String) As Boolean
        Try
            WPC_Formats = NewFormats.Split(",".ToCharArray())
            Return True
        Catch
            WPC_Formats = WPC_FormatSTR.Split(",".ToCharArray())
            P_ErrorString = "Unable to add new formats"
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Override the default list of F7 drives
    ''' </summary>
    ''' <param name="NewDrives">CSV list of characters representing F7 drives it can access</param>
    ''' <returns></returns>
    Public Function UpdateDriveSTR(ByVal NewDrives As String) As Boolean
        Try
            Drives = NewDrives.Split(CChar(","))
            Return True
        Catch
            Drives = DriveSTR.Split(CChar(","))
            P_ErrorString = "Unable to add new drives"
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Save a summery log file to filename.log
    ''' </summary>
    ''' <returns>True to save log</returns>
    Public Property SaveLogFile As Boolean
        Get
            Return P_SaveLogFile
        End Get
        Set(value As Boolean)
            P_SaveLogFile = value
        End Set
    End Property

    ''' <summary>
    ''' Disk Revolution Per Minute. Default is 300.
    ''' </summary>
    ''' <returns>Integer, rpm count.</returns>
    Public Property RPM As Integer
        Get
            Return P_RPM
        End Get
        Set(value As Integer)
            P_RPM = value
        End Set
    End Property

    ''' <summary>
    ''' Number of times to read each track. Default for GW is 3, default for archiving is 5.
    ''' </summary>
    ''' <returns>Integer, 5, unless previously set.</returns>
    Public Property Revolutions As Integer
        Get
            Return P_Revolutions
        End Get
        Set(value As Integer)
            If value < 1 Then
                P_Revolutions = 1
            Else
                P_Revolutions = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' Drive heads to use in the GW Action. 0, bottom, 1, top or both (0-1).
    ''' </summary>
    ''' <returns>String: Set of sides to use. 0,1 or 0-1</returns>
    Public Property Sides As String
        Get
            Return P_Sides
        End Get
        Set(value As String)
            If (value = "") Then
                P_Sides = "0"
                P_ErrorString = "Disk sides cannot be blank. Default to side 0"
            Else
                If (value = "0") Or (value = "1") Or (value = "0-1") Or (value = "0,1") Then
                    P_Sides = value
                Else
                    P_Sides = "0"
                    P_ErrorString = "Invalid disk side (head) selection. Can only be 0, 1 or both. Defaulting to side 0"
                End If
            End If
        End Set
    End Property

    ''' <summary>
    ''' Number of tracks to move for each head step. Default is 1. Set to 2, to read a 40 track disk in an 80 track drive.
    ''' </summary>
    ''' <returns>Integer. Default is to move 1 track at a time.</returns>
    Public Property TrackStep As Integer
        Get
            Return P_Step
        End Get
        Set(value As Integer)
            If (value < MinOffset) Or (value > MaxOffset) Then
                P_Step = 1
                P_ErrorString = "Invalid Step Value"
            Else
                P_Step = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The bitcell data read rate.
    ''' </summary>
    ''' <returns>250 for DD disks, 500 for HD disks.</returns>
    Public Property BitCellDataRate As Integer
        Get
            Return P_BitCellDataRate
        End Get
        Set(value As Integer)
            P_BitCellDataRate = value
        End Set
    End Property

    ''' <summary>
    ''' Enable to use 5.25" drives, to read 'Flippy' disks. eg C64 etc. Requires an offset set, to be effective.
    ''' </summary>
    ''' <returns></returns>
    Private Property HeadOffsetEnable As Boolean
        Get
            Return P_HeadOffsetEnable
        End Get
        Set(value As Boolean)
            P_HeadOffsetEnable = value
        End Set
    End Property

    ''' <summary>
    ''' Number of tracks to offset head, for reading (and writing?)
    ''' </summary>
    ''' <returns>Integer, -8 as default, for 5.25" drives with flippy disks</returns>
    Public Property HeadOffsetTrackCount As Integer
        Get
            Return P_HeadOffsetTrackCount
        End Get
        Set(value As Integer)
            If (value < MinOffset) Or (value > MaxOffset) Then     'Offset can only be -9 to 9
                P_HeadOffsetTrackCount = -8         'Default flippy C64 value
                P_ErrorString = "Invalid offset. Defaulting to -8. Values can only be -9 to 9"
            Else
                P_HeadOffsetTrackCount = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' Enable Write Precompensate. Prevent tracks from overlapping. Useful for later tracks, which are closer together. See Wiki: https://github.com/keirf/Greaseweazle/wiki/Write-Precompensation
    ''' </summary>
    ''' <returns>True to enable.</returns>
    Public Property WritePreCompensate As Boolean
        Get
            Return P_WritePreCompensate
        End Get
        Set(value As Boolean)
            P_WritePreCompensate = value
        End Set
    End Property

    ''' <summary>
    ''' The type of disk format to calculate Write PreCompensation. Supported formats: MFM, FM, GRC.
    ''' </summary>
    ''' <returns>String. mfm by default.</returns>
    Public Property WPC_Type As String
        Get
            Return P_WPC_Type
        End Get
        Set(value As String)
            If WPC_Formats.Contains(value.ToLower) Then
                P_WPC_Type = value.ToLower
            Else
                P_WPC_Type = WPC_Formats(0)
                P_ErrorString = "Invalid WPC Type. Values can only be mfm, fm or gcr. Defaulting to " + WPC_Formats(0)
            End If
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property WPC_Width_NanoSeconds As Integer
        Get
            Return P_WPC_Width_NanoSeconds
        End Get
        Set(value As Integer)
            P_WPC_Width_NanoSeconds = value
        End Set
    End Property

    ''' <summary>
    ''' Apply Write PreCompensation only on tracks, starting with this track. (Only useful on later tracks)
    ''' </summary>
    ''' <returns>Integer, default 40</returns>
    Public Property WPC_Tracks As Integer
        Get
            Return P_WPC_Tracks
        End Get
        Set(value As Integer)
            If (value >= MinTrack) Or (value <= MaxTrack) Then
                P_WPC_Tracks = value
            Else
                P_WPC_Tracks = 40
                P_ErrorString = "Invalid track selection"
            End If
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property WPC_TrackRange As String
        Get
            Return P_WPC_TrackRange
        End Get
        Set(value As String)
            If (value = ">") Or (value = ">=") Or (value = "<") Or (value = "<=") Or (value = "=") Then
                P_WPC_TrackRange = value
            Else
                P_WPC_TrackRange = ">="
                P_ErrorString = "Invalid track range assignment"
            End If
        End Set
    End Property

    ''' <summary>
    ''' File to write, or to read to. File must exist to perform write. (.Upd file, for GWFirmware also)
    ''' </summary>
    ''' <returns></returns>
    Public Property FileName As String
        Get
            Return P_Filename
        End Get
        Set(value As String)
            P_Filename = value
        End Set
    End Property

    ''' <summary>
    ''' Path to the GW.exe or to Python.exe, if using the GW script directly
    ''' </summary>
    ''' <returns>Path to the exe.</returns>
    Public Property PythonEXE As String
        Get
            Return P_PythonEXE
        End Get
        Set(value As String)
            If System.IO.File.Exists(value) Then
                P_PythonEXE = value
            Else
                P_PythonEXE = ""
                P_ErrorString = "Cannot Find exe to run."
            End If
        End Set
    End Property

    ''' <summary>
    ''' If using python.exe, this is the path to the GW python script (gw.py) or (gw)
    ''' </summary>
    ''' <returns>Path to the python script</returns>
    Public Property PythonScript As String
        Get
            Return P_PythonScript
        End Get
        Set(value As String)
            If System.IO.File.Exists(value) Then
                P_PythonScript = value
            Else
                P_PythonScript = ""
                P_ErrorString = "Python script cannot be found"
            End If
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property COMPort As String
        Get
            Return P_COMPort
        End Get
        Set(value As String)
            If value.Trim <> "" Then
                Dim found As Boolean = False
                For Each sp As String In My.Computer.Ports.SerialPortNames      'Check detected serial ports against value
                    If value = sp Then
                        P_COMPort = value
                        found = True
                    End If
                Next
                If found <> True Then
                    P_COMPort = ""
                    P_ErrorString = "Com port not found"
                End If
            End If
        End Set
    End Property

    ''' <summary>
    ''' The action to make the Greaseweazle perform. Read, write, erase, etc. 11 Commands supported so far.
    ''' </summary>
    ''' <returns>Integer, the GW action.</returns>
    Public Property Action As Integer
        Get
            Return P_Action
        End Get
        Set(value As Integer)
            If (value < GWMinAction) Or (value > GWMaxAction) Then
                P_Action = -1
                P_ErrorString = "Invalid action selected"
            Else
                P_Action = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' Track to Start reading/writing from, if not using a track set
    ''' </summary>
    ''' <returns>Start Track (Default is 0)</returns>
    Public Property StartTrack As Integer
        Get
            Return P_StartTrack
        End Get
        Set(value As Integer)
            If (value < MinTrack) Or (value > MaxTrack) Then
                P_StartTrack = 0
                P_ErrorString = "Invalid start track"
            Else
                P_StartTrack = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' Track to end reading/writing etc on, if not using a track set
    ''' </summary>
    ''' <returns>End Track. (default to 83 if track is invalid)</returns>
    Public Property EndTrack As Integer
        Get
            Return P_EndTrack
        End Get
        Set(value As Integer)
            If (value < MinTrack) Or (value > MaxTrack) Then
                P_EndTrack = 83
                P_ErrorString = "Invalid end track"
            Else
                P_EndTrack = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' Set of tracks to read/write/erase etc. Can be single tracks, or a range. Values are comma separated.
    ''' </summary>
    ''' <returns></returns>
    Public Property TrackGroup As String
        Get
            Return P_TrackGroup
        End Get
        Set(value As String)
            P_TrackGroup = value
        End Set
    End Property

    ''' <summary>
    ''' When writing, perform an erase on empty tracks.
    ''' </summary>
    ''' <returns></returns>
    Public Property EraseEmptyTracks As Boolean
        Get
            Return P_EraseEmptyTracks
        End Get
        Set(value As Boolean)
            P_EraseEmptyTracks = value
        End Set
    End Property

    ''' <summary>
    ''' Runs a windows exe or batch file with the path to the filename as the first argument, after GW process finishes
    ''' </summary>
    ''' <returns>Path to script/exe (If it exists. Blank, otherwise)</returns>
    Public Property ScriptFile As String
        Get
            Return P_ScriptLocation
        End Get
        Set(value As String)
            If System.IO.File.Exists(value) Then
                P_ScriptLocation = value
            Else
                P_ScriptLocation = ""
                P_ErrorString = "Cannot find script/exe to run after GW Action."
            End If
        End Set
    End Property

    ''' <summary>
    ''' Execute Script/EXE in the Scriptfile property.
    ''' </summary>
    ''' <returns>True to execute</returns>
    Public Property ExcuteScript As Boolean
        Get
            Return P_ExcuteScript
        End Get
        Set(value As Boolean)
            P_ExcuteScript = value
        End Set
    End Property

    ''' <summary>
    ''' Runs Script/EXE visible, minimized, or hidden.
    ''' </summary>
    ''' <returns>0: Normal, 1: Minimized, 2: Hidden</returns>
    Public Property ExecuteScriptHiddenLevel As Integer
        Get
            Return P_ExecuteScriptHidden
        End Get
        Set(value As Integer)
            If (value >= 0) And (value <= 2) Then
                P_ExecuteScriptHidden = value
            Else
                P_ExecuteScriptHidden = 0
            End If
        End Set
    End Property

    ''' <summary>
    ''' Only run script/exe on 'READ' command
    ''' </summary>
    ''' <returns>True to run on Read, false to run on all actions.</returns>
    Public Property ExecuteScriptOnGWRead_Only As Boolean
        Get
            Return P_ExecuteScriptOnGWRead_Only
        End Get
        Set(value As Boolean)
            P_ExecuteScriptOnGWRead_Only = value
        End Set
    End Property

    ''' <summary>
    ''' Is the Greaseweazle an STM32F703 (F7) or STM32F103 (F1)
    ''' </summary>
    ''' <returns>True for F7 device, false for F1 'bluepill' device</returns>
    Public Property F7Device As Boolean
        Get
            Return P_F7Device
        End Get
        Set(value As Boolean)
            P_F7Device = value
        End Set
    End Property

    ''' <summary>
    ''' F7 drive selection. 'A' (PC Drive, with cable twist), 'B' (with no twist), or DS0-2 Shugart drives
    ''' </summary>
    ''' <returns>Returns PC Drive letter (A/B) or Shugart drive number (0-2)</returns>
    Public Property F7_Drive As String
        Get
            Return P_Drive
        End Get
        Set(value As String)
            If Drives.Contains(value.ToUpper) Then
                P_Drive = value.ToUpper
            Else
                P_Drive = Drives(0)
                P_ErrorString = "Invalid drive selection. Defaulting to drive " + Drives(0)
            End If
        End Set
    End Property

    ''' <summary>
    ''' The cylinder/track to find using the 'Seek' command. Track numbers are zero based.
    ''' </summary>
    ''' <returns></returns>
    Public Property SeekTrack As Integer
        Get
            Return P_SeekTrack
        End Get
        Set(value As Integer)
            If ((value < MinTrack) Or (value > MaxTrack)) Then
                P_SeekTrack = MinTrack
                P_ErrorString = "Track cannot be greater than " + MaxTrack.ToString + " or less than " + MinTrack.ToString + ". Defaulting to " + MinTrack.ToString
            Else
                P_SeekTrack = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' Pin to change voltage on.
    ''' </summary>
    ''' <returns>Integer, Pin Number.</returns>
    Public Property Pin As Integer
        Get
            Return P_Pin
        End Get
        Set(value As Integer)
            If value <> 2 Then
                P_Pin = 2
                P_ErrorString = "Invalid pin selected"
            Else
                P_Pin = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' Pin voltage. Either On (Pin (H)igh), or off (Pin (L)ow).
    ''' </summary>
    ''' <returns></returns>
    Public Property PinVoltage As Integer
        Get
            Return P_PinVoltage
        End Get
        Set(value As Integer)
            If (value < PinLow) Or (value > PinHigh) Then
                P_PinVoltage = PinLow
                P_PinVoltageLetter = CChar("L")
                P_ErrorString = "Pin Voltage outside range"
            Else
                P_PinVoltage = value
                Select Case P_PinVoltage
                    Case 0 : P_PinVoltageLetter = CChar("L")
                    Case 1 : P_PinVoltageLetter = CChar("H")
                End Select
            End If
        End Set
    End Property

    ''' <summary>
    ''' Last Error string as readable text.
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property ErrorString As String
        Get
            Return P_ErrorString
        End Get
    End Property

    ''' <summary>
    ''' Main function. Make the GW perform an action
    ''' </summary>
    ''' <returns>True if GW performed action, false if there was an error. Check ErrorString.</returns>
    Public Function ExecuteGW() As Boolean
        Dim CMD As New Process
        Dim SW As IO.StreamWriter
        Dim SR As IO.StreamReader
        Dim str As String = ""

        If PythonEXE <> "" Then
            CMD.StartInfo.FileName = PythonEXE                                      'Path to and including Python.exe
            If (Action >= GWMinAction) And (Action <= GWMaxAction) Then             'Valid action found
                If PythonScript <> "" Then
                    str = ControlChars.Quote + PythonScript + ControlChars.Quote    'Add script location (If using python scripts. Otherwise, blank)
                End If

                Dim COMStr As String = ""                                           'Define Com Port string
                If COMPort <> "" Then                                               'If valid COM port found
                    COMStr = "--device " + COMPort + " "
                End If

                If ((Action = GWReset) Or (Action = GWInfo) Or (Action = GWBandwidth) Or (Action = GWDelays) Or (Action = GWSeek)) Then
                    Select Case Action
                        Case GWReset
                            str += " reset "                                        'Reset Device
                        Case GWInfo
                            str += " info "                                         'Get Device Info
                        Case GWBandwidth
                            str += " bandwidth "                                    'Get device bandwidth between GW and pc.
                        Case GWDelays
                            str += " delays "                                       'Get device delays.
                        Case GWSeek
                            str += " seek " + CStr(SeekTrack)                       'Move drive head to this cylender/track
                    End Select
                    str += COMStr                                                   'Add com port to the string
                Else
                    If Action = GWSetPin Then                                       'Set a pin level, 0v or 5v.
                        str += " pin " + Pin.ToString + " " + P_PinVoltageLetter + " "  'Voltage is a char: H or L
                        str += COMStr                                               'Add com port to the string
                    Else
                        If ((Action = GWUpdate) Or (Action = GWFirmware)) Then      'Update the firmware. (Main or bootloader) GW must have update pins joined for main update only. Booloader update in normal operational mode.
                            str += " update "
                            If Action = GWFirmware Then str += " --bootloader "
                        Else
                            If Action = GWErase Then                                'Erase the disk. can combine with: Adjust speed, RPM, Sides, Start and End Cylenders
                                str += " erase "
                            Else
                                If Action = GWRead Then                             'Read from Disk to image in a supported format (determined by extension)
                                    str += " read "
                                Else
                                    str += " write "                                'Write image to floppy disk (from a supported format)
                                    If EraseEmptyTracks Then                        'Erase empty sectors: only applies to write
                                        str += "--erase-empty "
                                    End If
                                End If
                                'If chkAdjustSpeed.Checked Then                      'Removed in Greaseweazle 0.13
                                '    str += "--adjust-speed "
                                'End If
                            End If

                            str += COMStr                                           'Add com port to the string

                            'Changed track command in v0.23
                            str += "--tracks=""c="                                  'Add tracks section: double quotes and Cylinder start
                            If Not IsNothing(TrackGroup) Then
                                If TrackGroup.Trim <> "" Then                           'If using a track set, add this
                                    str += TrackGroup
                                Else
                                    str += CStr(StartTrack)                             'If not using a set, use the standard start and finish track
                                    str += "-"
                                    str += CStr(EndTrack)                               'end on that track
                                End If
                            Else
                                str += CStr(StartTrack)                             'If not using a set, use the standard start and finish track
                                str += "-"
                                str += CStr(EndTrack)                               'end on that track
                            End If

                            str += ":h="                                            'Heads (sides of the disk) to use in this operation
                            If Sides.Trim <> "" Then                                'if non default sides are to be used,
                                str += Sides                                        'use heads selected in drop down
                            Else
                                str += "0-1"                                        'else use both heads (top and bottom)
                            End If

                            str += ":step="
                            str += CStr(TrackStep)                                  'Step X tracks for every read: Useful for 40 track disks, in 80 track drives, etc.

                            str += """ "                                            'add a double quote and a spce to the end of the --tracks section

                            If Action = GWRead Then
                                str += "--revs=" + CStr(Revolutions) + " "          'number of revolutions of each track to store in the image (if supported). 5 is the archival norm. used to find weak sectors, etc
                                str += " "                                          'Finish with a space, to leave room for the next switch
                                str += "--rate=" + CStr(BitCellDataRate) + " "      'rate of reading cells. 250= DS disk, 500= HD disk.
                                str += " "                                          'Finish with a space, to leave room for the next switch
                                str += "--rpm=" + CStr(RPM)                         'Sets drive rpm rate
                                str += " "                                          'Finish with a space, to leave room for the next switch
                            End If

                            If Action = GWWrite Then                                'Only check WPC for Write Action
                                If WritePreCompensate Then                          'Enable Write PreCompensate
                                    str += "--precomp="                             'Add WPC switch
                                    str += "type=" + WPC_Type                       'Add WPC disk format type
                                    str += ":" + WPC_Tracks.ToString + "="          'Add track to apply to, after this one:
                                    str += WPC_Width_NanoSeconds.ToString           'WPC width to adjust tracks by
                                    str += " "                                      'Finish with a space, to leave room for the next switch
                                End If
                            End If

                            If F7Device Then
                                str += "--drive " + F7_Drive                        'For F7 devices, a drive can be selected. A/B etc.
                            End If
                        End If
                        If Not IsNothing(FileName) Then                             'Check filename is initialised before we examine it.
                            If (FileName.Trim <> "") Then                           'If we do an action that requires a file add quotes around filename to save. (Otherewise fname is blank, no need for quotes)
                                str += ControlChars.Quote + FileName + ControlChars.Quote + " "
                            End If
                        End If
                    End If
                End If

                CMD.StartInfo.Arguments = str
                CMD.StartInfo.UseShellExecute = False
                CMD.StartInfo.RedirectStandardInput = True
                CMD.StartInfo.RedirectStandardOutput = True
                CMD.StartInfo.CreateNoWindow = True

                Try
                    CMD.Start()
                    SW = CMD.StandardInput
                    SR = CMD.StandardOutput

                Catch ex As Exception
                    P_ErrorString = "Unable to start GW command."
                    Return False
                End Try

                CMD.Dispose()
                P_ResultString = ""

                Do Until SR.EndOfStream = True
                    P_ResultString &= SR.ReadLine
                    P_ResultString &= Environment.NewLine
                Loop

                SW.Dispose()
                SR.Dispose()

                If ExcuteScript And Not ((Action = GWReset) Or
                                         (Action = GWSetPin) Or
                                         (Action = GWErase) Or
                                         (Action = GWUpdate) Or
                                         (Action = GWFirmware) Or
                                         (Action = GWInfo) Or
                                         (Action = GWBandwidth) Or
                                         (Action = GWDelays) Or
                                         (Action = GWSeek)) Then                                'Only execute script on read/write, not update/set pin/reset
                    If Not ((ExecuteScriptOnGWRead_Only = True) And (Action = GWWrite)) Then    'If NOT Only Execute batch/exe on GWRead commands:
                        If System.IO.File.Exists(FileName) Then                                 'Check file exists (or has been created, if reading from GW)
                            If Not IsNothing(ScriptFile) Then                                   'Check script file is initialised 
                                If System.IO.File.Exists(ScriptFile) Then                       'Check script batch/exe file exists, before we try to run it.
                                    ExecuteCommand(ScriptFile, FileName, ExecuteScriptHiddenLevel)  'Execute batch/program, with the resulting filename as the first argument.
                                End If
                            End If
                        End If
                    End If
                End If

                If SaveLogFile = True Then
                    If Not IsNothing(FileName) Then                                     'Check filename is initialised before we examine it
                        If System.IO.File.Exists(FileName) Then                         'Check file exists
                            Dim StreamWriter As New IO.StreamWriter(System.IO.Path.ChangeExtension(FileName, ".log")) 'Export log text to a .log file.
                            StreamWriter.Write(Results)
                            StreamWriter.Close()
                        End If
                    End If
                End If
                Return True
            Else
                P_ErrorString = "Invalid action to perform"
                Return False
            End If
        Else
            P_ErrorString = "Cannot Find exe to run."
            Return False
        End If
        Return True
    End Function
End Class
