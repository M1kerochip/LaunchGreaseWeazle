﻿Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class frmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Run GreaseWeazle Script v" + My.Application.Info.Version.ToString
        SetUpScreen()
    End Sub

    Public Function SetUpScreen()
        cmbSerialPorts.Items.Clear()

        For Each sp As String In My.Computer.Ports.SerialPortNames
            cmbSerialPorts.Items.Add(sp)
        Next

        txtGWLocation.Text = My.Settings.GW
        txtSaveLocation.Text = My.Settings.SaveLoc
        txtPythonLocation.Text = My.Settings.Python
        chkF7.Checked = My.Settings.F7
        cmbDriveSelect.Text = My.Settings.Drive
        cmbDriveSelect.Enabled = chkF7.Checked
        cmbEndTrack.Enabled = chkEndTrack.Checked
        cmbStartTrack.Enabled = ChkStartTrack.Checked
        cmbDisk.Text = My.Settings.Disk
        cmbDiskOf.Text = My.Settings.DiskOf
        chkExecuteScript.Checked = My.Settings.ExecuteScript
        chkLoop.Checked = My.Settings.LoopDump
        cmbDump.Text = My.Settings.LoopDumpCount
        cmbSystem.Text = My.Settings.System
        txtTitle.Text = My.Settings.Title
        txtPublisher.Text = My.Settings.Company
        txtExecuteScript.Text = My.Settings.Script
        chkDoubleStep.Checked = My.Settings.DoubleStep
        chkSingleSided.Checked = My.Settings.SingleSided
        ChkStartTrack.Checked = My.Settings.StartTrack
        cmbStartTrack.Text = My.Settings.StartTrackNo
        chkEndTrack.Checked = My.Settings.EndTrack
        cmbEndTrack.Text = My.Settings.EndTrackNo

        rtbOutput.Visible = False
        Me.Size = New Size(534, Me.Size.Height)
        btnResize.Text = ">"

        If My.Settings.WideForm = True Then
            rtbOutput.Visible = True
            Me.Size = New Size(924, Me.Size.Height)
            btnResize.Text = "<"
        End If

        ToolTipMainForm.SetToolTip(btnRead, "Begin GreaseWeazle read process.")
        ToolTipMainForm.SetToolTip(btnWrite, "Begin GreaseWeazle write process.")
        ToolTipMainForm.SetToolTip(btnExecuteScript, "Select the program or batch file to run. Path to disk image is passed as first argument.")
        ToolTipMainForm.SetToolTip(btnPythonLocation, "Select the location of the python.exe.")
        ToolTipMainForm.SetToolTip(btnGWLocation, "Select the location of the gw.py script.")
        ToolTipMainForm.SetToolTip(btnSaveLocation, "Select the location to save Disk images to.")
        ToolTipMainForm.SetToolTip(btnResize, "Show log. Not very useful though!")
        ToolTipMainForm.SetToolTip(chkExecuteScript, "Executes script after each read attempt.")
        ToolTipMainForm.SetToolTip(chkSaveLog, "Writes the log to a file after each read/write attempt.")
        ToolTipMainForm.SetToolTip(txtExecuteScript, "Location of program or batch file to execute")
        ToolTipMainForm.SetToolTip(txtPythonLocation, "Location of python.exe. Python must be installed. Exe is in main python install folder.")
        ToolTipMainForm.SetToolTip(txtGWLocation, "Location of gw.py. This is the script python.exe executes.")
        ToolTipMainForm.SetToolTip(txtSaveLocation, "Location to save disk images to.")
        ToolTipMainForm.SetToolTip(txtTitle, "Title of floppy disk image. This should not be blank.")
        ToolTipMainForm.SetToolTip(txtPublisher, "Publisher of disk image. Seperated from title by underscore. May be blank if desired.")
        ToolTipMainForm.SetToolTip(cmbSystem, "Computer system that the disk images belong to. eg PC, Amiga, ST etc.")
        ToolTipMainForm.SetToolTip(cmbDisk, "Used to set the disk number in a set.")
        ToolTipMainForm.SetToolTip(cmbDiskOf, "The total number of disks in a set. May be blank, if unknown. Useful to leave as 1 for single disks, to avoid confusion.")
        ToolTipMainForm.SetToolTip(cmbDiskRevision, "Adds a revision string to a disk image. Usually blank.")
        ToolTipMainForm.SetToolTip(cmbDump, "Disk read/write attempt number. Useful for read attempts. Many disks may need 2-5 attempts if there is dirt on the surface. (Or may need cleaning)")
        ToolTipMainForm.SetToolTip(chkLoop, "Check this, and set the dump number dropdown list to automatically make this number of read attempts.")
        ToolTipMainForm.SetToolTip(cmbSerialPorts, "Serial port GreaseWeazle is connected to. Should show all currently connected COM ports. Try removing old hidden ports if yours is not shown. Can type directly into this field. eg COM2. As of v0.11, auto is supported.")
        ToolTipMainForm.SetToolTip(LinkLabelProjectName, "Opens main GreaseWeazle Github page")
        ToolTipMainForm.SetToolTip(LinkLabelGWWiki, "Start here! Opens GreaseWeazle Wiki page. Setup and other usage documentation.")
        ToolTipMainForm.SetToolTip(LinkLabelOpenLocation, "Opens Explorer in the Save folder on the HDD.")
        ToolTipMainForm.SetToolTip(LinkLabelDLGW, "Opens the GreaseWeazle Github download page")
        ToolTipMainForm.SetToolTip(LinkLabelDLPython, "Opens main Python download page")
        ToolTipMainForm.SetToolTip(LinkLabelLaunchNow, "Executes exe/script from location below, with current disk image name.")
        ToolTipMainForm.SetToolTip(chkF7, "Check this if you are writing to a STM32F7 device (rather than the usual 'Bluepill'.")
        ToolTipMainForm.SetToolTip(cmbDriveSelect, "If using an F7 device, select the drive you want to read to/write from. Multiple drives may be connected at once. (F7 device only!!).")
        ToolTipMainForm.SetToolTip(LinkLabelDriveSelect, "Opens the 'Drive Select' page of the Wiki.")
        ToolTipMainForm.SetToolTip(ChkStartTrack, "Check to select a default start track other than track 0.")
        ToolTipMainForm.SetToolTip(chkEndTrack, "Check to select a default end track. Number of tracks that a drive can read/write depends on the drive itself. Consult disk drive manual if unsure.")
        ToolTipMainForm.SetToolTip(chkSingleSided, "Select this to read/write only on disk side 0 (the bottom on most drives)/ If unsure, leave unchecked. Maps to --single-sided argument.")
        ToolTipMainForm.SetToolTip(chkAdjustSpeed, "If unsure, leave checked. Maps to --adjust-speed argument. Adjust write-flux times for drive speed.")
        ToolTipMainForm.SetToolTip(cmbStartTrack, "Track to start read/write process on. Tracks are zero indexed. Actual number of tracks a drive supports varies. Consult disk drive manual if unsure.")
        ToolTipMainForm.SetToolTip(cmbEndTrack, "Track to end read/write process on. Tracks are zero indexed. Actual number of tracks a drive supports varies. Consult disk drive manual if unsure.")
        ToolTipMainForm.SetToolTip(chkRevolutions, "Check this to change the revolutions per read from the default 3. (Note, 5 revolutions is the norm for archival purposes).")
        ToolTipMainForm.SetToolTip(cmbRevolutions, "Set the revolutions per read here. 5 is recommended.")
        ToolTipMainForm.SetToolTip(btnUpdateFirmware, "Begin GreaseWeazle read process. Bridge the two pins: DCLK + DCIO and select update file.")
        ToolTipMainForm.SetToolTip(LinkLabelLaunchGW, "The Github repository for this program. Get the latest versions here.")
        ToolTipMainForm.SetToolTip(btnResetDevice, "Resets the Greaseweazle device to power-on settings: Motors off, drives deselected, power-on pin levels and delay values. GW 0.12+ required.")
        ToolTipMainForm.SetToolTip(chkDoubleStep, "Makes the Greaseweazle move the head two tracks at a time. Used to read 40 track disks on an 80 track device. EG C64 (SD) disk in an IBM PC (DD) drive. GW 0.12+ required.")
        ToolTipMainForm.SetToolTip(btnSetPin, "Set the pin in the dropdown list to either Low (0v) or Hight (5v). GW v0.12+ required.")
        ToolTipMainForm.SetToolTip(cmbPIN, "The floppy drive pin whos value will be set either high or low. (Cannot be blank) GW 0.12+ required.")
        ToolTipMainForm.SetToolTip(cmbLowHigh, "Force a Low or High value on a given pin. (Cannot be blank) GW 0.12+ required.")

        Return True
    End Function

    Public Function EnableDarkTheme(ByVal EnableDark As Boolean) As Boolean
        Dim w1 As Color = Color.FromArgb(244, 244, 244)
        Dim w2 As Color = Color.FromArgb(232, 232, 232)
        Dim w3 As Color = Color.FromArgb(220, 220, 220)

        Dim b1 As Color = Color.FromArgb(12, 12, 12)
        Dim b2 As Color = Color.FromArgb(24, 24, 24)
        Dim b3 As Color = Color.FromArgb(36, 36, 36)

        Dim hl As Color = Color.FromArgb(140, 140, 254)
        Dim hll As Color = Color.FromArgb(24, 232, 24)

        If EnableDark = True Then
            Me.ForeColor = w1
            Me.BackColor = b1

            rtbOutput.ForeColor = w3
            rtbOutput.BackColor = b2

            'lblComPort.ForeColor = w2
            'lblTitle.ForeColor = w2

            cmbSerialPorts.ForeColor = w2
            cmbSerialPorts.BackColor = b2

            LinkLabelProjectName.ForeColor = w2
            LinkLabelProjectName.LinkColor = hl
            LinkLabelProjectName.VisitedLinkColor = hll

            btnWrite.ForeColor = w2
            btnWrite.BackColor = b2
        Else
            Me.ForeColor = System.Drawing.SystemColors.ControlText
            Me.BackColor = System.Drawing.SystemColors.Control

            rtbOutput.ForeColor = System.Drawing.SystemColors.WindowText
            rtbOutput.BackColor = System.Drawing.SystemColors.Window

            'lblComPort.ForeColor = System.Drawing.SystemColors.ControlText
            'lblTitle.ForeColor = System.Drawing.SystemColors.ControlText

            cmbSerialPorts.ForeColor = System.Drawing.SystemColors.WindowText
            cmbSerialPorts.BackColor = System.Drawing.SystemColors.Window

            LinkLabelProjectName.ForeColor = System.Drawing.SystemColors.ControlText
            LinkLabelProjectName.LinkColor = hl
            LinkLabelProjectName.VisitedLinkColor = hll

            btnWrite.ForeColor = System.Drawing.SystemColors.ControlText
            btnWrite.BackColor = System.Drawing.SystemColors.Control
        End If

        txtTitle.ForeColor = rtbOutput.ForeColor
        txtTitle.BackColor = rtbOutput.BackColor
        txtPublisher.ForeColor = rtbOutput.ForeColor
        txtPublisher.BackColor = rtbOutput.BackColor
        txtSaveLocation.ForeColor = rtbOutput.ForeColor
        txtSaveLocation.BackColor = rtbOutput.BackColor
        txtGWLocation.ForeColor = rtbOutput.ForeColor
        txtGWLocation.BackColor = rtbOutput.BackColor
        txtPythonLocation.ForeColor = rtbOutput.ForeColor
        txtPythonLocation.BackColor = rtbOutput.BackColor
        txtExecuteScript.ForeColor = rtbOutput.ForeColor
        txtExecuteScript.BackColor = rtbOutput.BackColor

        cmbDisk.ForeColor = cmbSerialPorts.ForeColor
        cmbDisk.BackColor = cmbSerialPorts.BackColor
        cmbDiskOf.ForeColor = cmbSerialPorts.ForeColor
        cmbDiskOf.BackColor = cmbSerialPorts.BackColor
        cmbDiskRevision.ForeColor = cmbSerialPorts.ForeColor
        cmbDiskRevision.BackColor = cmbSerialPorts.BackColor
        cmbDiskRevision.ForeColor = cmbSerialPorts.ForeColor
        cmbDiskRevision.BackColor = cmbSerialPorts.BackColor
        cmbDump.ForeColor = cmbSerialPorts.ForeColor
        cmbDump.BackColor = cmbSerialPorts.BackColor
        cmbSystem.ForeColor = cmbSerialPorts.ForeColor
        cmbSystem.BackColor = cmbSerialPorts.BackColor
        cmbPIN.ForeColor = cmbSerialPorts.ForeColor
        cmbPIN.BackColor = cmbSerialPorts.BackColor
        cmbDriveSelect.ForeColor = cmbSerialPorts.ForeColor
        cmbDriveSelect.BackColor = cmbSerialPorts.BackColor
        cmbRevolutions.ForeColor = cmbSerialPorts.ForeColor
        cmbRevolutions.BackColor = cmbSerialPorts.BackColor
        cmbStartTrack.ForeColor = cmbSerialPorts.ForeColor
        cmbStartTrack.BackColor = cmbSerialPorts.BackColor
        cmbEndTrack.ForeColor = cmbSerialPorts.ForeColor
        cmbEndTrack.BackColor = cmbSerialPorts.BackColor

        LinkLabelGWWiki.ForeColor = LinkLabelProjectName.ForeColor
        LinkLabelGWWiki.LinkColor = LinkLabelProjectName.LinkColor
        LinkLabelGWWiki.VisitedLinkColor = LinkLabelProjectName.VisitedLinkColor
        LinkLabelLaunchGW.ForeColor = LinkLabelProjectName.ForeColor
        LinkLabelLaunchGW.LinkColor = LinkLabelProjectName.LinkColor
        LinkLabelLaunchGW.VisitedLinkColor = LinkLabelProjectName.VisitedLinkColor
        LinkLabelDriveSelect.ForeColor = LinkLabelProjectName.ForeColor
        LinkLabelDriveSelect.LinkColor = LinkLabelProjectName.LinkColor
        LinkLabelDriveSelect.VisitedLinkColor = LinkLabelProjectName.VisitedLinkColor
        LinkLabelOpenLocation.ForeColor = LinkLabelProjectName.ForeColor
        LinkLabelOpenLocation.LinkColor = LinkLabelProjectName.LinkColor
        LinkLabelOpenLocation.VisitedLinkColor = LinkLabelProjectName.VisitedLinkColor
        LinkLabelDLGW.ForeColor = LinkLabelProjectName.ForeColor
        LinkLabelDLGW.LinkColor = LinkLabelProjectName.LinkColor
        LinkLabelDLGW.VisitedLinkColor = LinkLabelProjectName.VisitedLinkColor
        LinkLabelDLPython.ForeColor = LinkLabelProjectName.ForeColor
        LinkLabelDLPython.LinkColor = LinkLabelProjectName.LinkColor
        LinkLabelDLPython.VisitedLinkColor = LinkLabelProjectName.VisitedLinkColor
        LinkLabelLaunchNow.ForeColor = LinkLabelProjectName.ForeColor
        LinkLabelLaunchNow.LinkColor = LinkLabelProjectName.LinkColor
        LinkLabelLaunchNow.VisitedLinkColor = LinkLabelProjectName.VisitedLinkColor

        btnRead.ForeColor = btnWrite.ForeColor
        btnRead.BackColor = btnWrite.BackColor
        btnResetDevice.ForeColor = btnWrite.ForeColor
        btnResetDevice.BackColor = btnWrite.BackColor
        btnUpdateFirmware.ForeColor = btnWrite.ForeColor
        btnUpdateFirmware.BackColor = btnWrite.BackColor
        btnSetPin.ForeColor = btnWrite.ForeColor
        btnSetPin.BackColor = btnWrite.BackColor
        btnExecuteScript.ForeColor = btnWrite.ForeColor
        btnExecuteScript.BackColor = btnWrite.BackColor
        btnPythonLocation.ForeColor = btnWrite.ForeColor
        btnPythonLocation.BackColor = btnWrite.BackColor
        btnGWLocation.ForeColor = btnWrite.ForeColor
        btnGWLocation.BackColor = btnWrite.BackColor
        btnSaveLocation.ForeColor = btnWrite.ForeColor
        btnSaveLocation.BackColor = btnWrite.BackColor
        btnResize.ForeColor = btnWrite.ForeColor
        btnResize.BackColor = btnWrite.BackColor
        Return True
    End Function

    Public Sub SaveSettings()
        My.Settings.SaveLoc = txtSaveLocation.Text.Trim
        My.Settings.GW = txtGWLocation.Text.Trim
        My.Settings.Python = txtPythonLocation.Text.Trim
        My.Settings.F7 = chkF7.Checked
        My.Settings.Drive = cmbDriveSelect.Text.Trim
        My.Settings.COM = cmbSerialPorts.Text.Trim
        My.Settings.Title = txtTitle.Text.Trim
        My.Settings.Company = txtPublisher.Text.Trim
        My.Settings.System = cmbSystem.Text.Trim
        My.Settings.Script = txtExecuteScript.Text.Trim
        My.Settings.Disk = cmbDisk.Text
        My.Settings.DiskOf = cmbDiskOf.Text
        My.Settings.ExecuteScript = chkExecuteScript.Checked
        My.Settings.LoopDump = chkLoop.Checked
        My.Settings.LoopDumpCount = cmbDump.Text
        My.Settings.DoubleStep = chkDoubleStep.Checked
        My.Settings.StartTrack = ChkStartTrack.Checked
        My.Settings.StartTrackNo = cmbStartTrack.Text
        My.Settings.EndTrack = chkEndTrack.Checked
        My.Settings.EndTrackNo = cmbEndTrack.Text
        My.Settings.SingleSided = chkSingleSided.Checked
        If btnResize.Text = "<" Then My.Settings.WideForm = True Else My.Settings.WideForm = False
        My.Settings.Save()
    End Sub

    ''' <summary>
    ''' Create a filename from the attributes onscreen. (Including checking if file exists, if necessary)
    ''' </summary>
    ''' <param name="CheckExists">Check to see if the file exists on the disk. If so, append an integer to prevent GreaseSeazle from overwriting.</param>
    ''' <returns>Filename as a string.</returns>
    Function CreateFileName(ByVal CheckExists As Boolean) As String
        Dim regWhitespace As New Regex("\s")

        Dim filen As String
        filen = txtTitle.Text                                                               'Set initial name to Title
        If txtPublisher.Text.Trim <> "" Then
            filen += txtPublisher.Text                                                      'Add publisher if txt field not blank
        End If
        If cmbDiskOf.Text.Trim <> "" Then
            cmbDisk.Text = cmbDisk.Text.Trim.PadLeft(cmbDiskOf.Text.Length, "0")            'Pad disk number to length of "diskof" field
        End If
        If cmbDisk.Text.Trim <> "" Then
            filen += "Disk" + cmbDisk.Text.Trim                                             'Add disk if disk field not blank
        End If
        If cmbDiskOf.Text.Trim <> "" Then
            filen += "Of" + cmbDiskOf.Text.Trim                                             'Add disk of if disk of field not blank
        End If
        If ((cmbDisk.Text.Trim <> "") Or (cmbDiskOf.Text.Trim <> "")) Then
            filen += "_"                                                                    'If either disk or disk of field added, include trailing underscore
        End If
        If cmbDiskRevision.Text.Trim <> "" Then
            filen += cmbDiskRevision.Text.Trim + "_"                                        'Add revision, if revision field not blank
        End If
        If cmbSystem.Text.Trim <> "" Then
            filen += cmbSystem.Text.Trim + "_"                                              'Add system, if system field not blank
        End If
        If cmbDump.Text.Trim <> "" Then
            filen += "Dump" + cmbDump.Text.Trim                                             'Add 'Dump+DumpNumber' field, if dump field not blank
        End If

        Dim extst As String = ".scp"                                                        'Add file extension for SuperCard Pro "SCP"

        If chkFilenameRreplaceSpaceWithUnderscore.Checked Then
            filen = regWhitespace.Replace(filen, String.Empty)                              'Replace all spaces with underscores, if check "replace with underscores" checked.
        End If

        If CheckExists = True Then
            'Check to see if file exists already. If so, get next available filename by appending "_X" where x is an ascending integer.
            Dim l As Integer = 0
            If My.Computer.FileSystem.FileExists(txtSaveLocation.Text.Trim + filen + extst) Then
                l = 1
                While My.Computer.FileSystem.FileExists(txtSaveLocation.Text.Trim + filen + "_" + CStr(l) + extst) = True
                    l += 1
                End While
            End If
            If l > 0 Then filen += "_" + CStr(l)
        End If
        filen += extst
        Return filen
    End Function

    Function CheckForErrors() As Boolean
        Cleanfields()
        If txtPythonLocation.Text.Trim <> "" And txtGWLocation.Text.Trim <> "" And txtSaveLocation.Text.Trim <> "" And cmbSerialPorts.Text.Trim <> "" Then
            Return False
        Else
            Dim errstr As String = ""
            rtbOutput.Clear()
            If cmbSerialPorts.Text.Trim = "" Then
                errstr = "No COM port selected!" + Environment.NewLine
            End If
            If txtSaveLocation.Text.Trim = "" Then
                errstr &= "Save directory cannot be blank!" + Environment.NewLine
            Else
                If Not IO.Directory.Exists(txtSaveLocation.Text.Trim) Then
                    errstr &= "Save directory does Not exist!" + Environment.NewLine
                End If
            End If
            If Not IO.File.Exists(txtGWLocation.Text.Trim) Then
                errstr &= "Greaseweazel script Not found!" + Environment.NewLine
            End If
            If Not IO.File.Exists(txtPythonLocation.Text.Trim) Then
                errstr &= "Python.exe Not found!" + Environment.NewLine
            End If
            rtbOutput.Text &= errstr
            Return True
        End If
    End Function

    Public Sub Cleanfields()
        Replace(txtTitle.Text, " ", "_")
        Replace(txtPublisher.Text, " ", "_")
        Replace(cmbSystem.Text, " ", "_")
        Replace(cmbDiskRevision.Text, " ", "_")
    End Sub

    ''' <summary>
    ''' Calls python.exe to run the gw.py script
    ''' </summary>
    ''' <param name="PythonEXE">Path to the python.exe. Python install folder must be in PATH variable.</param>
    ''' <param name="gwLoc">Path to gw.py</param>
    ''' <param name="ReadFromGW">Set to true to read to disk image, false writes disk image.</param>
    ''' <param name="UpdateGWFirmware">Set to true to update GreaseWeazle hardware. Must have jumper set on [DCLK] + [DCIO]</param>
    ''' <param name="fName">Path to file to read/write</param>
    ''' <param name="ComPort">COM port to talk to GreaseWeazle hardware on. v0.11+ supports 'auto'.</param>
    ''' <param name="ResetGW">Reset the Greaseweazle device to power-on settings: Motors off, drives deselected, power-on pin levels And delay values</param>
    ''' <param name="DoubleStep">Move the head twice for every track move indicated. Allows usage of a 40 track disk on an 80 track drive</param>
    ''' <param name="SetPinLevel">If true, change the value of the pin (PinToSet) to a the set level (PinLevel)- On or off.</param>
    ''' <param name="PinToSet">The pin number (on the back of the floppy drive) to change value</param>
    ''' <param name="PinLevel">Char: L or H denotes (L)ow 0v, or (H)igh 5v</param>
    ''' <returns></returns>
    Private Function CallGreaseWeazel(ByVal PythonEXE As String, ByVal gwLoc As String, ByVal ReadFromGW As Boolean,
                                      ByVal UpdateGWFirmware As Boolean, ByVal fName As String, ByVal ComPort As String,
                                      ByVal ResetGW As Boolean, ByVal DoubleStep As Boolean,
                                      ByVal SetPinLevel As Boolean, ByVal PinToSet As Integer, ByVal PinLevel As Char) As Boolean
        Dim CMD As New Process

        Dim SW As IO.StreamWriter

        Dim SR As IO.StreamReader

        CMD.StartInfo.FileName = PythonEXE

        Dim str As String = ControlChars.Quote + gwLoc + ControlChars.Quote

        If ResetGW = True Then
            str = str + " reset "
        Else
            If SetPinLevel = True Then
                str = str + " pin " + PinToSet.ToString + " " + PinLevel + " "
            Else
                If UpdateGWFirmware = True Then
                    str = str + " update "
                Else
                    If ReadFromGW = True Then
                        str = str + " read "
                    Else
                        str = str + " write "
                        If chkAdjustSpeed.Checked Then
                            str = str + "--adjust-speed "
                        End If
                    End If

                    If chkSingleSided.Checked Then
                        str = str + "--single-sided "
                    End If

                    If ChkStartTrack.Checked Then
                        str = str + "--scyl=" + cmbStartTrack.Text + " "
                    End If

                    If chkEndTrack.Checked Then
                        str = str + "--ecyl=" + cmbEndTrack.Text + " "
                    End If

                    If ReadFromGW = True Then
                        If chkRevolutions.Checked Then
                            str = str + "--revs=" + cmbRevolutions.Text + " "
                        End If
                    End If

                    If DoubleStep = True Then
                        str = str + "--double-step "
                    End If

                    If chkF7.Checked Then
                        str = str + "--drive " + cmbDriveSelect.Text
                    End If
                End If
                str = str + ControlChars.Quote + fName + ControlChars.Quote + " "
            End If
        End If

        str = str + ComPort

        CMD.StartInfo.Arguments = str

        CMD.StartInfo.UseShellExecute = False

        CMD.StartInfo.RedirectStandardInput = True

        CMD.StartInfo.RedirectStandardOutput = True

        CMD.StartInfo.CreateNoWindow = True

        CMD.Start()

        SW = CMD.StandardInput

        SR = CMD.StandardOutput

        CMD.Dispose()

        Do Until SR.EndOfStream = True
            rtbOutput.Text &= SR.ReadLine
            rtbOutput.Text &= Environment.NewLine
        Loop

        SW.Dispose()

        SR.Dispose()

        If chkExecuteScript.Checked And Not (ResetGW = True Or SetPinLevel = True Or UpdateGWFirmware = True) Then  'Only execute script on read/write, not update/set pin/reset
            If System.IO.File.Exists(fName) Then    'Check file exists (or has been created, if reading from GW)
                If txtExecuteScript.Text.Trim <> "" Then    'Check script exists
                    System.Diagnostics.Process.Start(txtExecuteScript.Text.Trim, fName)
                End If
            End If
        End If

        If chkSaveLog.Checked = True Then
            If System.IO.File.Exists(fName) Then    'Check file exists
                Dim StreamWriter As New IO.StreamWriter(System.IO.Path.ChangeExtension(fName, ".log")) 'Export rich text box as a .log file.
                StreamWriter.Write(rtbOutput.Text)
                StreamWriter.Close()
            End If
        End If
        Return True
    End Function

    Private Sub LinkLabelProjectName_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelProjectName.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/keirf/Greaseweazle")
    End Sub

    Private Sub LinkLabelGWWiki_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelGWWiki.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/keirf/Greaseweazle/wiki")
    End Sub

    Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        If CheckForErrors() = False Then
            If chkLoop.Checked Then     'If running gw.py on a loop, to dump a disk multiple times
                Dim loopc As Integer
                For loopc = 0 To CInt(cmbDump.Text)
                    cmbDump.Text = CStr(loopc)
                    Dim fileGW As String = CreateFileName(True)
                    rtbOutput.Clear()
                    rtbOutput.Text &= "Reading from Greaseweazel on port " + cmbSerialPorts.Text
                    rtbOutput.Text &= Environment.NewLine
                    rtbOutput.Text &= "Start: " + cmbStartTrack.Text + "  End: " + cmbEndTrack.Text + "  Revolutions: " + cmbRevolutions.Text + "  Sided: " + IIf(chkSingleSided.Checked, "Single", "Double")
                    rtbOutput.Text &= Environment.NewLine
                    rtbOutput.Text &= "to file: " + fileGW
                    rtbOutput.Text &= Environment.NewLine + Environment.NewLine
                    Me.Refresh()
                    CallGreaseWeazel(txtPythonLocation.Text, txtGWLocation.Text, True, False, txtSaveLocation.Text + fileGW, cmbSerialPorts.Text, False, chkDoubleStep.Checked, False, 0, "")
                Next                    'If running gw.py on a loop, to dump a disk multiple times
            Else    'Run gw.py once only
                Dim fileGW As String = CreateFileName(True)
                rtbOutput.Clear()
                rtbOutput.Text &= "Reading from Greaseweazel on port " + cmbSerialPorts.Text
                rtbOutput.Text &= Environment.NewLine
                rtbOutput.Text &= "Start: " + cmbStartTrack.Text + "  End: " + cmbEndTrack.Text + "  Revolutions: " + cmbRevolutions.Text + "  Sided: " + IIf(chkSingleSided.Checked, "Single", "Double")
                rtbOutput.Text &= Environment.NewLine
                rtbOutput.Text &= "to file: " + fileGW
                rtbOutput.Text &= Environment.NewLine + Environment.NewLine
                Me.Refresh()
                CallGreaseWeazel(txtPythonLocation.Text, txtGWLocation.Text, True, False, txtSaveLocation.Text + fileGW, cmbSerialPorts.Text, False, chkDoubleStep.Checked, False, 0, "")
            End If  'Run gw.py once only
        Else
        End If
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveSettings()
    End Sub

    Private Sub BtnSaveLocation_Click(sender As Object, e As EventArgs) Handles btnSaveLocation.Click
        If (FolderBrowserDialogSave.ShowDialog() = DialogResult.OK) Then
            txtSaveLocation.Text = FolderBrowserDialogSave.SelectedPath
            If Not txtSaveLocation.Text.EndsWith(IO.Path.DirectorySeparatorChar) Then
                txtSaveLocation.Text = txtSaveLocation.Text + IO.Path.DirectorySeparatorChar
            End If
        End If
    End Sub

    Private Sub BtnGWLocation_Click(sender As Object, e As EventArgs) Handles btnGWLocation.Click
        OpenFileDialogMain.Title = "Select 'gw.py' in Greaseweazel Directory"
        OpenFileDialogMain.Multiselect = False
        OpenFileDialogMain.FileName = "gw.py"
        OpenFileDialogMain.DefaultExt = "py"
        OpenFileDialogMain.Filter = "Python files (*.py)|*.py|All files (*.*)|*.*"

        If (OpenFileDialogMain.ShowDialog() = DialogResult.OK) Then
            txtGWLocation.Text = OpenFileDialogMain.FileName
        End If
    End Sub

    Private Sub BtnPythonLocation_Click(sender As Object, e As EventArgs) Handles btnPythonLocation.Click
        OpenFileDialogMain.Title = "Select 'python.exe' in Python Directory"
        OpenFileDialogMain.Multiselect = False
        OpenFileDialogMain.FileName = "python.exe"
        OpenFileDialogMain.DefaultExt = "exe"
        OpenFileDialogMain.Filter = "Program files (*.exe)|*.exe|All files (*.*)|*.*"

        If (OpenFileDialogMain.ShowDialog() = DialogResult.OK) Then
            txtPythonLocation.Text = OpenFileDialogMain.FileName
        End If
    End Sub

    Private Sub BtnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        If CheckForErrors() = False Then
            OpenFileDialogMain.Title = "Select SuperCard Pro file to write to floppy"
            OpenFileDialogMain.Multiselect = False
            OpenFileDialogMain.FileName = ""
            Dim fileGW As String
            If (OpenFileDialogMain.ShowDialog() = DialogResult.OK) Then
                fileGW = OpenFileDialogMain.FileName
                rtbOutput.Clear()
                rtbOutput.Text &= "Writing to Greaseweazel on port " + cmbSerialPorts.Text
                rtbOutput.Text &= Environment.NewLine
                rtbOutput.Text &= "Start: " + cmbStartTrack.Text + "  End: " + cmbEndTrack.Text + "  Revolutions: " + cmbRevolutions.Text + "  Sided: " + IIf(chkSingleSided.Checked, "Single", "Double")
                rtbOutput.Text &= Environment.NewLine
                rtbOutput.Text &= "using file: " + fileGW
                rtbOutput.Text &= Environment.NewLine + Environment.NewLine
                CallGreaseWeazel(txtPythonLocation.Text, txtGWLocation.Text, False, False, fileGW, cmbSerialPorts.Text, False, chkDoubleStep.Checked, False, 0, "")
            Else
                rtbOutput.Text &= Environment.NewLine
                rtbOutput.Text &= "Write image cancelled"
                rtbOutput.Text &= Environment.NewLine
            End If
        End If
    End Sub

    Private Sub ChkF7_CheckedChanged(sender As Object, e As EventArgs) Handles chkF7.CheckedChanged
        cmbDriveSelect.Enabled = chkF7.Checked
    End Sub

    Private Sub LinkLabelDriveSelect_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelDriveSelect.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/keirf/Greaseweazle/wiki/Drive-Select")
    End Sub

    Private Sub LinkLabelDLGW_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelDLGW.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/keirf/Greaseweazle/wiki/Downloads")
    End Sub

    Private Sub LinkLabelDLPython_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelDLPython.LinkClicked
        System.Diagnostics.Process.Start("https://www.python.org/downloads/windows/")
    End Sub

    Private Sub ChkEndTrack_CheckedChanged(sender As Object, e As EventArgs) Handles chkEndTrack.CheckedChanged
        cmbEndTrack.Enabled = chkEndTrack.Checked
    End Sub

    Private Sub LinkLabelOpenLocation_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelOpenLocation.LinkClicked
        System.Diagnostics.Process.Start("explorer.exe", "/n,/e," + txtSaveLocation.Text)
    End Sub

    Private Sub BtnExecuteScript_Click(sender As Object, e As EventArgs) Handles btnExecuteScript.Click
        OpenFileDialogMain.Title = "Select script/exe to execute after read/write"
        OpenFileDialogMain.Multiselect = False
        OpenFileDialogMain.FileName = ""
        OpenFileDialogMain.DefaultExt = ""
        OpenFileDialogMain.Filter = "All files (*.*)|*.*"

        If (OpenFileDialogMain.ShowDialog() = DialogResult.OK) Then
            txtExecuteScript.Text = OpenFileDialogMain.FileName
        End If
    End Sub

    Private Sub LinkLabelLaunchNow_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelLaunchNow.LinkClicked
        System.Diagnostics.Process.Start(txtExecuteScript.Text.Trim, txtSaveLocation.Text.Trim + CreateFileName(False))
    End Sub

    Private Sub ChkStartCyl_CheckedChanged(sender As Object, e As EventArgs) Handles ChkStartTrack.CheckedChanged
        cmbStartTrack.Enabled = ChkStartTrack.Checked
    End Sub

    Private Sub BtnResize_Click(sender As Object, e As EventArgs) Handles btnResize.Click
        If rtbOutput.Visible Then
            rtbOutput.Visible = False
            Me.Size = New Size(534, Me.Size.Height)
            btnResize.Text = ">"
        Else
            rtbOutput.Visible = True
            Me.Size = New Size(924, Me.Size.Height)
            btnResize.Text = "<"
        End If
    End Sub

    Private Sub BtnUpdateFirmware_Click(sender As Object, e As EventArgs) Handles btnUpdateFirmware.Click
        OpenFileDialogMain.Title = "Select 'Greaseweazle-v????.upd' in Greaseweazel Directory"
        OpenFileDialogMain.Multiselect = False
        OpenFileDialogMain.FileName = ""
        OpenFileDialogMain.DefaultExt = "upd"
        OpenFileDialogMain.Filter = "Update files (*.upd)|*.upd|All files (*.*)|*.*"

        Dim fileGW As String
        If (OpenFileDialogMain.ShowDialog() = DialogResult.OK) Then
            fileGW = OpenFileDialogMain.FileName
            rtbOutput.Clear()
            rtbOutput.Text &= "Updating Greaseweazel firmware on port " + cmbSerialPorts.Text
            rtbOutput.Text &= Environment.NewLine
            rtbOutput.Text &= "using: " + fileGW
            rtbOutput.Text &= Environment.NewLine + Environment.NewLine
            rtbOutput.Text &= "Please ensure GND + DCLK are bridged with a jumper before the process starts."
            rtbOutput.Text &= Environment.NewLine + Environment.NewLine
            If MessageBox.Show("Continue with flashing process?" + vbNewLine + vbNewLine + "Are GND + DCLK are bridged with a jumper also?", "Flash Greaseweazle", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                CallGreaseWeazel(txtPythonLocation.Text, txtGWLocation.Text, False, True, fileGW, cmbSerialPorts.Text, False, chkDoubleStep.Checked, False, 0, "")
                rtbOutput.Text &= Environment.NewLine + Environment.NewLine
                rtbOutput.Text &= "Remember to select the updated gw.py in the 'Greaseweazle Script Location'"
                rtbOutput.Text &= Environment.NewLine + Environment.NewLine
            End If
        End If
    End Sub

    Private Sub LinkLabelLaunchGW_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelLaunchGW.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/M1kerochip/LaunchGreaseWeazle")
    End Sub

    Private Sub BtnSetPin_Click(sender As Object, e As EventArgs) Handles btnSetPin.Click
        If IsNumeric(cmbPIN.Text) = True Then
            rtbOutput.Text &= "Setting pin level:"
            rtbOutput.Text &= Environment.NewLine + Environment.NewLine
            CallGreaseWeazel(txtPythonLocation.Text, txtGWLocation.Text, False, False, "", cmbSerialPorts.Text, False, False, True, CInt(cmbPIN.Text), cmbLowHigh.Text.Chars(0))
        Else
            rtbOutput.Text &= Environment.NewLine + Environment.NewLine
            rtbOutput.Text &= "Pin to change must be selected in the Pin dropdown box."
        End If
    End Sub

    Private Sub BtnResetDevice_Click(sender As Object, e As EventArgs) Handles btnResetDevice.Click
        rtbOutput.Text &= Environment.NewLine
        rtbOutput.Text &= "Issuing device reset:"
        rtbOutput.Text &= Environment.NewLine + Environment.NewLine
        CallGreaseWeazel(txtPythonLocation.Text, txtGWLocation.Text, False, False, "", cmbSerialPorts.Text, True, False, False, 0, "")
    End Sub

    Private Sub cmbDiskOf_LostFocus(sender As Object, e As EventArgs) Handles cmbDiskOf.LostFocus
        If cmbDiskOf.Text.Trim <> "" Then
            If cmbDisk.Text.Length < cmbDiskOf.Text.Length Then
                cmbDisk.Text = cmbDisk.Text.Trim.PadLeft(cmbDiskOf.Text.Length, "0")                'Pad disk number to length of "diskof" field with leading zeros
            End If
            If cmbDisk.Text.Length > cmbDiskOf.Text.Length Then
                cmbDisk.Text = Microsoft.VisualBasic.Right(cmbDisk.Text, cmbDiskOf.Text.Length)     'Trim disk number to length of "diskof" field
            End If
        End If
    End Sub

    Private Sub txtTitle_GotFocus(sender As Object, e As EventArgs) Handles txtTitle.GotFocus
        txtTitle.SelectAll()
    End Sub

    Private Sub txtPublisher_GotFocus(sender As Object, e As EventArgs) Handles txtPublisher.GotFocus
        txtPublisher.SelectAll()
    End Sub

    Private Sub lblSystem_Click(sender As Object, e As EventArgs) Handles lblSystem.Click
        If Me.BackColor = System.Drawing.SystemColors.Control Then
            EnableDarkTheme(True)
        Else
            EnableDarkTheme(False)
        End If

    End Sub
End Class
