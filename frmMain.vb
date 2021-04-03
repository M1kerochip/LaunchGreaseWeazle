Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class FrmMain
    Public Manufacturers(16) As String
    Public DiskArray(16, 16) As String

    ''' <summary>
    ''' Sets the title of the Form with the form name plus exe version number
    ''' </summary>
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim GW As New GreaseWeazle
        Me.Text = "Run GreaseWeazle v" + My.Application.Info.Version.ToString + " (GWHelper: " + GW.Version + ")"

        'Load or create and load the .xml file with the manufacturers / disk types
        Dim fl As String = System.IO.Path.ChangeExtension(Application.ExecutablePath, ".Disks.xml")
        If System.IO.File.Exists(fl) Then
            ReadDefaultDiskXML(fl)
        Else
            WriteDefaultDiskTypesXML(fl)
            ReadDefaultDiskXML(fl)
        End If
        Try
            If Manufacturers.Length > 0 Then
                Dim x As Integer
                cmbManufacturer.Items.Clear()
                For x = 0 To Manufacturers.Length - 1
                    cmbManufacturer.Items.Add(Manufacturers(x))
                Next
            End If
        Catch ex As Exception

        End Try

        SetUpScreen()
    End Sub

    Public Sub DoLOG()
        If chkLOG.Checked Then
            If rtbOutput.Text.Trim <> "" Then
                Dim l As New LogFileClass
                l.WriteToLog(rtbOutput.Lines)
            End If
        End If
    End Sub

    Public Function FillComPorts(ByVal cmb As ComboBox) As Boolean
        cmb.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames      'Add detected serial ports to combo box drop down
            cmb.Items.Add(sp)
        Next
        Return True
    End Function

    ''' <summary>
    ''' Loads settings from VB My.Settings (local) and sets the variables onscreen. Also sets up tooltips.
    ''' </summary>
    Public Function SetUpScreen() As Boolean
        FillComPorts(cmbSerialPorts)

        If My.Settings.UpdateSettings = True Then                       'Copy user settings from previous application version if necessary
            My.Settings.Upgrade()
            My.Settings.UpdateSettings = False
            My.Settings.Save()
        End If

        txtSaveLocation.Text = My.Settings.SaveLoc
        txtGWLocation.Text = My.Settings.GWExe
        chkF7.Checked = My.Settings.F7
        cmbDriveSelect.Text = My.Settings.Drive
        cmbDriveSelect.Enabled = chkF7.Checked
        cmbEndTrack.Enabled = chkEndTrack.Checked
        cmbStartTrack.Enabled = ChkStartTrack.Checked
        cmbRevolutions.Enabled = chkRevolutions.Checked
        cmbRPM.Enabled = chkRPM.Checked
        cmbRate.Enabled = chkRate.Checked
        cmbDisk.Text = My.Settings.Disk
        cmbDiskOf.Text = My.Settings.DiskOf
        chkExecuteScriptAfterRead.Checked = My.Settings.ExecuteScript
        chkLoop.Checked = My.Settings.LoopDump
        cmbDump.Text = My.Settings.LoopDumpCount
        cmbSystem.Text = My.Settings.System
        txtTitle.Text = My.Settings.Title
        txtPublisher.Text = My.Settings.Company
        txtExecuteScript.Text = My.Settings.Script
        cmbSides.Text = My.Settings.Sides
        cmbStepping.Text = CStr(My.Settings.Stepping)
        ChkStartTrack.Checked = My.Settings.StartTrack
        cmbStartTrack.Text = CStr(My.Settings.StartTrackNo)
        chkEndTrack.Checked = My.Settings.EndTrack
        cmbEndTrack.Text = CStr(My.Settings.EndTrackNo)
        cmbSeekA.Text = CStr(My.Settings.SeekA)
        cmbSeekB.Text = CStr(My.Settings.SeekB)
        'chkAdjustSpeed.Checked = My.Settings.AdjustWriteSpeed
        chkRate.Checked = My.Settings.IncludeDataRate
        chkRPM.Checked = My.Settings.IncludeRPM
        cmbRPM.Text = My.Settings.RPM
        cmbRate.Text = My.Settings.DataRate
        chkLOG.Checked = My.Settings.RunningLog
        chkEraseEmpty.Checked = My.Settings.EraseEmpty
        chkSeparateFolders.Checked = My.Settings.SeparateFolders
        txtPythonLocation.Text = My.Settings.PythonExe
        chkUsePython.Checked = My.Settings.UsePython
        chkWritePreCompensate.Checked = My.Settings.UseWritePreCompensate
        cmbWPCTrackRange.Text = My.Settings.WPCTrackRange
        cmbWPCTracks.Text = My.Settings.WPCTracks
        cmbWPCType.Text = My.Settings.WPCType
        txtWPCWidth.Text = My.Settings.WPCTrackWidth
        chkOffsetHead.Checked = My.Settings.HeadOffsetEnable
        cmbOffsetHeadBy.Text = CStr(My.Settings.HeadOffsetTrackCount)
        chkSetManDiskType.Checked = My.Settings.SetManDisktype
        cmbManufacturer.SelectedIndex = My.Settings.Manufacturer
        cmbDiskTypes.SelectedIndex = My.Settings.DiskType
        cmbManufacturer.Enabled = chkSetManDiskType.Checked
        cmbDiskTypes.Enabled = chkSetManDiskType.Checked


        EnableProgramLOGToolStripMenuItem.CheckOnClick = True
        EnableProgramLOGToolStripMenuItem.Checked = chkLOG.Checked
        WriteLOGWithEachReadWriteToolStripMenuItem.CheckOnClick = True
        WriteLOGWithEachReadWriteToolStripMenuItem.Checked = chkSaveLog.Checked
        cmbOffsetHeadBy.Enabled = chkOffsetHead.Checked

        cmbRetries.Text = CStr(My.Settings.Retries)
        chkRetries.Checked = My.Settings.EnableRetries
        cmbRetries.Enabled = chkRetries.Checked

        cmbCleanMS.Text = CStr(My.Settings.CleanTimeMS)
        chkLingerCleaning.Checked = My.Settings.EnableCleanTimeMS
        cmbCleanMS.Enabled = chkLingerCleaning.Checked

        cmbCleanPasses.Text = CStr(My.Settings.CleanPasses)
        chkCleanPasses.Checked = My.Settings.EnableCleanPasses
        cmbCleanPasses.Enabled = chkCleanPasses.Checked

        chkTime.Checked = My.Settings.ShowTime

        If My.Settings.DarkTheme = True Then
            EnableDarkTheme(True)
        End If

        rtbOutput.Visible = False
        Me.Size = New Size(534, Me.Size.Height)
        btnResize.Text = ">"

        If My.Settings.WideForm = True Then
            rtbOutput.Visible = True
            Me.Size = New Size(924, Me.Size.Height)
            btnResize.Text = "<"
        End If

        If My.Settings.UsePython = True Then
            txtPythonLocation.Enabled = True
            btnPython_EXE.Enabled = True
            txtPythonLocation.Visible = True
            lblPythonLocation.Visible = True
            btnPython_EXE.Visible = True
        Else
            txtPythonLocation.Enabled = False
            btnPython_EXE.Enabled = False
            txtPythonLocation.Visible = False
            lblPythonLocation.Visible = False
            btnPython_EXE.Visible = False
        End If

        If chkWritePreCompensate.Checked = True Then
            cmbWPCType.Enabled = True
            cmbWPCTrackRange.Enabled = True
            cmbWPCTracks.Enabled = True
            txtWPCWidth.Enabled = True
        Else
            cmbWPCType.Enabled = False
            cmbWPCTrackRange.Enabled = False
            cmbWPCTracks.Enabled = False
            txtWPCWidth.Enabled = False
        End If

        If chkLOG.Checked Then
            rtbOutput.AppendText("Started on: " + DateTime.Today.ToString("yyyy-MM-dd") + " at " + DateTime.Now.ToString("HH:mm:ss") + vbCrLf)
        End If

        CheckVisible()

        ToolTipMainForm.SetToolTip(btnRead, "Begin GreaseWeazle read process. Creates a flux level copy of a floppy disk to a file.")
        ToolTipMainForm.SetToolTip(btnWrite, "Begin GreaseWeazle write process. Writes a supported file format to a physical floppy disk.")
        ToolTipMainForm.SetToolTip(btnExecuteScript, "Select the program or batch file to run. Path to disk image is passed as first argument.")
        ToolTipMainForm.SetToolTip(btnGW_EXE, "Select the location of the gw.exe (or gw.py for Python).")
        ToolTipMainForm.SetToolTip(btnSaveLocation, "Select the location to save Disk images to.")
        ToolTipMainForm.SetToolTip(btnResize, "Show/hide log. Not very useful though!")
        ToolTipMainForm.SetToolTip(chkExecuteScriptAfterRead, "Executes script after each read attempt. Check twice to execute script minimized.")
        ToolTipMainForm.SetToolTip(chkExecuteScriptAfterWrite, "Executes script after each write attempt.")
        ToolTipMainForm.SetToolTip(chkSaveLog, "Writes the log to a file after each read/write attempt. Log file matches image name.")
        ToolTipMainForm.SetToolTip(txtExecuteScript, "Location of program or batch file to execute")
        ToolTipMainForm.SetToolTip(txtGWLocation, "Location of python.exe. Python must be installed. Exe is in main python install folder.")
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
        ToolTipMainForm.SetToolTip(LinkLabelDownloadPython, "Opens main Python download page")
        ToolTipMainForm.SetToolTip(LinkLabelLaunchNow, "Executes exe/script from location below, with current disk image name.")
        ToolTipMainForm.SetToolTip(chkF7, "Check this if you are writing to a STM32F7 device (rather than the 'Bluepill' STM32 F1 device.")
        ToolTipMainForm.SetToolTip(cmbDriveSelect, "If using an F7 device, select the drive you want to read to/write from. Multiple drives may be connected at once. (F7 device only!!).")
        ToolTipMainForm.SetToolTip(LinkLabelDriveSelect, "Opens the 'Drive Select' page of the Wiki.")
        ToolTipMainForm.SetToolTip(ChkStartTrack, "Check to select a default start track other than track 0.")
        ToolTipMainForm.SetToolTip(chkEndTrack, "Check to select a default end track. Number of tracks that a drive can read/write depends on the drive itself. Consult disk drive manual if unsure.")
        ToolTipMainForm.SetToolTip(cmbSides, "Select disk sides to read / write / erase. Side 0 is the bottom of a double sided disk drive disk, side 1 is the top of a double sided drive disk. Single sided drives should use side 0 only")
        ToolTipMainForm.SetToolTip(lblDiskSides, "Select disk sides to read / write / erase. Side 0 is the bottom of a double sided disk drive disk, side 1 is the top of a double sided drive disk. Single sided drives should use side 0 only")
        'ToolTipMainForm.SetToolTip(chkAdjustSpeed, "Removed in v0.13 of Greaseweazle. Maps to --adjust-speed argument. Adjust write-flux times for drive speed.")
        ToolTipMainForm.SetToolTip(cmbStartTrack, "Track to start read/write process on. Tracks are zero indexed. Actual number of tracks a drive supports varies. Consult disk drive manual if unsure.")
        ToolTipMainForm.SetToolTip(cmbEndTrack, "Track to end read/write process on. Tracks are zero indexed. Actual number of tracks a drive supports varies. Consult disk drive manual if unsure.")
        ToolTipMainForm.SetToolTip(chkRevolutions, "Check this to change the revolutions per read from the default 3. (Note, 5 revolutions is the norm for archival purposes).")
        ToolTipMainForm.SetToolTip(cmbRevolutions, "Set the revolutions per read here. 5 is recommended.")
        ToolTipMainForm.SetToolTip(btnUpdateFirmware, "Begin GreaseWeazle firmware upgrade process. Bridge the two pins: DCLK + DCIO and select update file.")
        ToolTipMainForm.SetToolTip(LinkLabelLaunchGW, "The Github repository for this program. Get the latest versions here.")
        ToolTipMainForm.SetToolTip(btnResetDevice, "Resets the Greaseweazle device to power-on settings: Motors off, drives deselected, power-on pin levels and delay values. GW 0.12+ required.")
        ToolTipMainForm.SetToolTip(cmbStepping, "Makes the Greaseweazle move the head x tracks at a time. Used to read (GW 0.12+) or write (GW 0.20+) 40 track disks on an 80 track device. EG C64 (SD) disk in an IBM PC (DD) drive. Default is 1 (GW 0.23)")
        ToolTipMainForm.SetToolTip(lblHeadStep, "Makes the Greaseweazle move the head x tracks at a time. Used to read (GW 0.12+) or write (GW 0.20+) 40 track disks on an 80 track device. EG C64 (SD) disk in an IBM PC (DD) drive. Default is 1 (GW 0.23)")
        ToolTipMainForm.SetToolTip(btnSetPin, "Set the pin in the dropdown list to either Low (0v) or Hight (5v). GW v0.12+ required.")
        ToolTipMainForm.SetToolTip(cmbPIN, "The floppy drive pin whos value will be set either high or low. (Cannot be blank) GW 0.12+ required.")
        ToolTipMainForm.SetToolTip(cmbLowHigh, "Force a Low or High value on a given pin. (Cannot be blank) GW 0.12+ required.")
        ToolTipMainForm.SetToolTip(cmbReadFormat, "GreaseWeazle read format. Supercard Pro (.scp), KryoFlux (.raw), HxC (.hfe) or Extended Disk image format (.dsk). Alternatively specify your own extension including period. GW 0.14+ required. (0.23+ for Kryoflux, 0.25+ for EDSK)")
        ToolTipMainForm.SetToolTip(btnEraseDisk, "**WARNING** Erases the contents of a physical floppy disk. Write protect tab must be off/closed.")
        ToolTipMainForm.SetToolTip(btnInfo, "Displays Greaseweazle device information. Also displays the device bootloader info, on an F7 device.")
        ToolTipMainForm.SetToolTip(btnGWBandwidth, "Display bandwidth between Greasweazle and PC")
        ToolTipMainForm.SetToolTip(btnGWDelays, "Displays Greaseweazle device delays information.")
        ToolTipMainForm.SetToolTip(chkRate, "Enable drive read rate. 250 for DD disks, 500 for HD disks and HD drives.")
        ToolTipMainForm.SetToolTip(cmbRPM, "Set the disk RPM to this rate. This setting is set before all others.")
        ToolTipMainForm.SetToolTip(chkRPM, "Enable changing the drive RPM setting. Changing this will take precedence over other settings. Default for DD drives is 300 RPM. Default for Amiga HD drives, is 150 RPM.")
        ToolTipMainForm.SetToolTip(cmbRate, "Set read rate. 250 for DD disks, 500 for HD disks.")
        ToolTipMainForm.SetToolTip(chkLOG, "Save an audit log of actions to a programname.log file")
        ToolTipMainForm.SetToolTip(chkEraseEmpty, "Erases empty tracks on write. Off by default.")
        ToolTipMainForm.SetToolTip(btnSeekA, "Move the disk drive head to this track")
        ToolTipMainForm.SetToolTip(btnSeekB, "Move the disk drive head to this track")
        ToolTipMainForm.SetToolTip(chkTrackGroup, "Tick to use a group of tracks. Must be a valid set of tracks. eg 0-83 or 0-5,10-15 to read tracks 0 to 5 and then also 10-15.")
        ToolTipMainForm.SetToolTip(txtTrackGroup, "Create a group of tracks to read/write/erase. Tracks are in the format <startTrack>-<endtrack>. To add more ranges of tracks to the group, separate them with a comma")
        ToolTipMainForm.SetToolTip(chkSeparateFolders, "Check to create disk images inside their own folder. Useful for KryoFlux dumps, where each track is it's own file.")
        ToolTipMainForm.SetToolTip(lblAddTrackList, "Add the start and end track to the group below.")
        ToolTipMainForm.SetToolTip(lblClearTrackList, "Clear track group.")
        ToolTipMainForm.SetToolTip(btnPython_EXE, "Click to pick the location of the python.exe")
        ToolTipMainForm.SetToolTip(txtPythonLocation, "The location of the Python.exe, if using greaseweazle python scripts.")
        ToolTipMainForm.SetToolTip(chkUsePython, "Check this to use the python version of Greaseweazle. Python must be installed with required libraries (bitarray crcmod pyserial")
        ToolTipMainForm.SetToolTip(lblComPort, "Click to refresh the COM port list in the drop down box")
        ToolTipMainForm.SetToolTip(cmbSerialPorts, "Serial port the Greaseweazle is connected to. Leave blank to auto detect. Select the correct COM port, if multiple GWs are connected at the same time")
        ToolTipMainForm.SetToolTip(chkWritePreCompensate, "Check this to enable Write Precompensation. Click the WritePreComepensate link to read the Wiki entry.")
        ToolTipMainForm.SetToolTip(llabelPreCompensate, "Launches the browser to read the WPC Wiki entry")
        ToolTipMainForm.SetToolTip(cmbWPCType, "The format of the disk to be written: Modified Frequency Modulation, Frequency Modulation, or Group Coded Recording.")
        ToolTipMainForm.SetToolTip(cmbWPCTracks, "Apply WPC to all subsequent tracks, starting with this track:")
        ToolTipMainForm.SetToolTip(txtWPCWidth, "The width in nanoseconds, to shift the tracks by.")
        ToolTipMainForm.SetToolTip(txtTitle, "Title of the disk to read. May not be blank.")
        ToolTipMainForm.SetToolTip(lblSystem, "Click to enable my (awful) attempt at a dark theme :)")
        ToolTipMainForm.SetToolTip(chkFilenameRreplaceSpaceWithUnderscore, "For the title of the image, replace spaces with an underscore character. Helpful to avoid problems with spaces in paths, etc.")
        ToolTipMainForm.SetToolTip(chkOffsetHead, "Offset the head movement by -9 to 9 tracks. Only for 5.25"" drives and C64 flippy disks!!")
        ToolTipMainForm.SetToolTip(cmbOffsetHeadBy, "Track count to offset the head by. (Only for 5.25"" drives and C64 flippy disks)")
        ToolTipMainForm.SetToolTip(chkCleanPasses, "Check to change the number of passes the heads will move over the cleaning disk. Default is 3.")
        ToolTipMainForm.SetToolTip(cmbCleanPasses, "The number of times the drive heads will be cleaned, on each track.")
        ToolTipMainForm.SetToolTip(chkLingerCleaning, "Check to enable changin the length of time the heads spend cleaning each track. Default is 100ms.")
        ToolTipMainForm.SetToolTip(cmbCleanMS, "The number of milliseconds a the drive head will stay on each track")
        ToolTipMainForm.SetToolTip(chkRetries, "If an error occurs during read/write, retry the action a number of times.")
        ToolTipMainForm.SetToolTip(cmbRetries, "This is the number of times to retry read/write, in the case of an error occuring.")
        ToolTipMainForm.SetToolTip(chkTime, "Show the time taken to complete GW actions.")
        ToolTipMainForm.SetToolTip(btnClean, "Clean drive heads using a floppy cleaning disk. (Usually a sponge or cloth like material, with IPA or similar liquid drops.")
        ToolTipMainForm.SetToolTip(chkSetManDiskType, "Set the Supercard Pro (.scp) file disk type. Has no effect on other disk formats.")
        ToolTipMainForm.SetToolTip(cmbManufacturer, "The Supercard Pro (.scp) file manufacturer. Has no effect on other disk formats")
        ToolTipMainForm.SetToolTip(cmbDiskTypes, "The Supercard Pro (.scp) file disk type. Each manufacturer can have multiple disk types. Has no effect on other disk formats")
        Return True
    End Function

    ''' <summary>
    ''' Simple attempt to create an easier to use night mode.
    ''' </summary>
    ''' <param name="EnableDark">If true, set the program to dark, if not set to default</param>
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

        GroupBoxGWOptions.ForeColor = rtbOutput.ForeColor
        GroupBoxGWOptions.BackColor = rtbOutput.BackColor
        gbProgramOptions.ForeColor = rtbOutput.ForeColor
        gbProgramOptions.BackColor = rtbOutput.BackColor

        txtTitle.ForeColor = rtbOutput.ForeColor
        txtTitle.BackColor = rtbOutput.BackColor
        txtPublisher.ForeColor = rtbOutput.ForeColor
        txtPublisher.BackColor = rtbOutput.BackColor
        txtSaveLocation.ForeColor = rtbOutput.ForeColor
        txtSaveLocation.BackColor = rtbOutput.BackColor
        txtGWLocation.ForeColor = rtbOutput.ForeColor
        txtGWLocation.BackColor = rtbOutput.BackColor
        txtExecuteScript.ForeColor = rtbOutput.ForeColor
        txtExecuteScript.BackColor = rtbOutput.BackColor
        txtPythonLocation.ForeColor = rtbOutput.ForeColor
        txtPythonLocation.BackColor = rtbOutput.BackColor
        txtWPCWidth.ForeColor = rtbOutput.ForeColor
        txtWPCWidth.BackColor = rtbOutput.BackColor
        txtTrackGroup.ForeColor = rtbOutput.ForeColor
        txtTrackGroup.BackColor = rtbOutput.BackColor

        cmbRate.ForeColor = cmbSerialPorts.ForeColor
        cmbRate.BackColor = cmbSerialPorts.BackColor
        cmbSeekA.ForeColor = cmbSerialPorts.ForeColor
        cmbSeekA.BackColor = cmbSerialPorts.BackColor
        cmbSeekB.ForeColor = cmbSerialPorts.ForeColor
        cmbSeekB.BackColor = cmbSerialPorts.BackColor
        cmbRPM.ForeColor = cmbSerialPorts.ForeColor
        cmbRPM.BackColor = cmbSerialPorts.BackColor
        cmbReadFormat.ForeColor = cmbSerialPorts.ForeColor
        cmbReadFormat.BackColor = cmbSerialPorts.BackColor
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
        cmbWPCType.ForeColor = cmbSerialPorts.ForeColor
        cmbWPCType.BackColor = cmbSerialPorts.BackColor
        cmbWPCTrackRange.ForeColor = cmbSerialPorts.ForeColor
        cmbWPCTrackRange.BackColor = cmbSerialPorts.BackColor
        cmbWPCTracks.ForeColor = cmbSerialPorts.ForeColor
        cmbWPCTracks.BackColor = cmbSerialPorts.BackColor
        cmbSides.ForeColor = cmbSerialPorts.ForeColor
        cmbSides.BackColor = cmbSerialPorts.BackColor
        cmbStepping.ForeColor = cmbSerialPorts.ForeColor
        cmbStepping.BackColor = cmbSerialPorts.BackColor
        cmbOffsetHeadBy.ForeColor = cmbSerialPorts.ForeColor
        cmbOffsetHeadBy.BackColor = cmbSerialPorts.BackColor
        cmbRetries.ForeColor = cmbSerialPorts.ForeColor
        cmbRetries.BackColor = cmbSerialPorts.BackColor
        cmbCleanMS.ForeColor = cmbSerialPorts.ForeColor
        cmbCleanMS.BackColor = cmbSerialPorts.BackColor
        cmbCleanPasses.ForeColor = cmbSerialPorts.ForeColor
        cmbCleanPasses.BackColor = cmbSerialPorts.BackColor
        cmbManufacturer.BackColor = cmbSerialPorts.BackColor
        cmbManufacturer.ForeColor = cmbSerialPorts.ForeColor
        cmbDiskTypes.BackColor = cmbSerialPorts.BackColor
        cmbDiskTypes.ForeColor = cmbSerialPorts.ForeColor

        LinkLabelGWWiki.ForeColor = LinkLabelProjectName.ForeColor
        LinkLabelGWWiki.LinkColor = LinkLabelProjectName.LinkColor
        LinkLabelGWWiki.VisitedLinkColor = LinkLabelProjectName.VisitedLinkColor
        LinkLabelLaunchGW.ForeColor = LinkLabelProjectName.ForeColor
        LinkLabelLaunchGW.LinkColor = LinkLabelProjectName.LinkColor
        LinkLabelLaunchGW.VisitedLinkColor = LinkLabelProjectName.VisitedLinkColor
        LinkLabelDriveSelect.ForeColor = LinkLabelProjectName.ForeColor
        LinkLabelDriveSelect.LinkColor = LinkLabelProjectName.LinkColor
        LinkLabelDriveSelect.VisitedLinkColor = LinkLabelProjectName.VisitedLinkColor
        llabelPreCompensate.ForeColor = LinkLabelProjectName.ForeColor
        llabelPreCompensate.LinkColor = LinkLabelProjectName.LinkColor
        llabelPreCompensate.VisitedLinkColor = LinkLabelProjectName.VisitedLinkColor
        LinkLabelOpenLocation.ForeColor = LinkLabelProjectName.ForeColor
        LinkLabelOpenLocation.LinkColor = LinkLabelProjectName.LinkColor
        LinkLabelOpenLocation.VisitedLinkColor = LinkLabelProjectName.VisitedLinkColor
        LinkLabelDLGW.ForeColor = LinkLabelProjectName.ForeColor
        LinkLabelDLGW.LinkColor = LinkLabelProjectName.LinkColor
        LinkLabelDLGW.VisitedLinkColor = LinkLabelProjectName.VisitedLinkColor
        LinkLabelDownloadPython.ForeColor = LinkLabelProjectName.ForeColor
        LinkLabelDownloadPython.LinkColor = LinkLabelProjectName.LinkColor
        LinkLabelDownloadPython.VisitedLinkColor = LinkLabelProjectName.VisitedLinkColor
        LinkLabelLaunchNow.ForeColor = LinkLabelProjectName.ForeColor
        LinkLabelLaunchNow.LinkColor = LinkLabelProjectName.LinkColor
        LinkLabelLaunchNow.VisitedLinkColor = LinkLabelProjectName.VisitedLinkColor

        btnInfo.ForeColor = btnWrite.ForeColor
        btnInfo.BackColor = btnWrite.BackColor
        btnEraseDisk.ForeColor = btnWrite.ForeColor
        btnEraseDisk.BackColor = btnWrite.BackColor
        btnGWBandwidth.ForeColor = btnWrite.ForeColor
        btnGWBandwidth.BackColor = btnWrite.BackColor
        btnGWDelays.ForeColor = btnWrite.ForeColor
        btnGWDelays.BackColor = btnWrite.BackColor
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
        btnGW_EXE.ForeColor = btnWrite.ForeColor
        btnGW_EXE.BackColor = btnWrite.BackColor
        btnSaveLocation.ForeColor = btnWrite.ForeColor
        btnSaveLocation.BackColor = btnWrite.BackColor
        btnResize.ForeColor = btnWrite.ForeColor
        btnResize.BackColor = btnWrite.BackColor
        btnSeekA.ForeColor = btnWrite.ForeColor
        btnSeekA.BackColor = btnWrite.BackColor
        btnSeekB.ForeColor = btnWrite.ForeColor
        btnSeekB.BackColor = btnWrite.BackColor
        btnPython_EXE.ForeColor = btnWrite.ForeColor
        btnPython_EXE.BackColor = btnWrite.BackColor
        btnClean.ForeColor = btnWrite.ForeColor
        btnClean.BackColor = btnWrite.BackColor
        btnHidePaths.ForeColor = btnWrite.ForeColor
        btnHidePaths.BackColor = btnWrite.BackColor

        ContextMenuStripMainCommands.BackColor = Me.BackColor
        ContextMenuStripMainCommands.ForeColor = Me.ForeColor
        Return True
    End Function

    ''' <summary>
    ''' Write Settings out to VB.NET My.Settings section (All settings are per user)
    ''' </summary>
    Public Sub SaveSettings()
        My.Settings.SaveLoc = txtSaveLocation.Text.Trim
        My.Settings.GWExe = txtGWLocation.Text.Trim
        My.Settings.F7 = chkF7.Checked
        My.Settings.Drive = cmbDriveSelect.Text.Trim
        My.Settings.COM = cmbSerialPorts.Text.Trim
        My.Settings.Title = txtTitle.Text.Trim
        My.Settings.Company = txtPublisher.Text.Trim
        My.Settings.System = cmbSystem.Text.Trim
        My.Settings.Script = txtExecuteScript.Text.Trim
        My.Settings.Disk = cmbDisk.Text
        My.Settings.DiskOf = cmbDiskOf.Text
        My.Settings.ExecuteScript = chkExecuteScriptAfterRead.Checked
        My.Settings.LoopDump = chkLoop.Checked
        My.Settings.LoopDumpCount = cmbDump.Text
        My.Settings.Stepping = CInt(cmbStepping.Text)
        My.Settings.StartTrack = ChkStartTrack.Checked
        My.Settings.RunningLog = chkLOG.Checked
        My.Settings.EraseEmpty = chkEraseEmpty.Checked
        My.Settings.UsePython = chkUsePython.Checked
        My.Settings.PythonExe = txtPythonLocation.Text
        My.Settings.UseWritePreCompensate = chkWritePreCompensate.Checked
        My.Settings.WPCTrackRange = cmbWPCTrackRange.Text
        My.Settings.WPCTracks = cmbWPCTracks.Text
        My.Settings.WPCType = cmbWPCType.Text
        My.Settings.WPCTrackWidth = txtWPCWidth.Text
        My.Settings.HeadOffsetEnable = chkOffsetHead.Checked
        My.Settings.HeadOffsetTrackCount = CInt(cmbOffsetHeadBy.Text)
        My.Settings.SetManDisktype = chkSetManDiskType.Checked
        My.Settings.Manufacturer = cmbManufacturer.SelectedIndex
        My.Settings.DiskType = cmbDiskTypes.SelectedIndex

        If IsNumeric(cmbRetries.Text) Then
            My.Settings.Retries = CInt(cmbRetries.Text)
        End If
        My.Settings.EnableRetries = chkRetries.Checked

        If IsNumeric(cmbCleanMS.Text) Then
            My.Settings.CleanTimeMS = CInt(cmbCleanMS.Text)
        End If
        My.Settings.EnableCleanTimeMS = chkLingerCleaning.Checked

        If IsNumeric(cmbCleanPasses.Text) Then
            My.Settings.CleanPasses = CInt(cmbCleanPasses.Text)
        End If
        My.Settings.EnableCleanPasses = chkCleanPasses.Checked

        My.Settings.ShowTime = chkTime.Checked

        If Me.BackColor = System.Drawing.SystemColors.Control Then
            My.Settings.DarkTheme = False
        Else
            My.Settings.DarkTheme = True
        End If

        If IsNumeric(cmbSeekA.Text) Then
            My.Settings.SeekA = CInt(cmbSeekA.Text)
        Else
            My.Settings.SeekA = 0
        End If
        If IsNumeric(cmbSeekB.Text) Then
            My.Settings.SeekB = CInt(cmbSeekB.Text)
        Else
            My.Settings.SeekB = 83
        End If
        If IsNumeric(cmbStartTrack.Text) Then
            My.Settings.StartTrackNo = CInt(cmbStartTrack.Text)
        Else
            My.Settings.StartTrackNo = 0
        End If
        My.Settings.EndTrack = chkEndTrack.Checked
        If IsNumeric(cmbEndTrack.Text) Then
            My.Settings.EndTrackNo = CInt(cmbEndTrack.Text)
        Else
            My.Settings.EndTrackNo = 83
        End If
        My.Settings.Sides = cmbSides.Text
        'My.Settings.AdjustWriteSpeed = chkAdjustSpeed.Checked
        My.Settings.IncludeDataRate = chkRate.Checked
        My.Settings.IncludeRPM = chkRPM.Checked
        My.Settings.RPM = cmbRPM.Text
        My.Settings.DataRate = cmbRate.Text
        If btnResize.Text = "<" Then My.Settings.WideForm = True Else My.Settings.WideForm = False
        My.Settings.SeparateFolders = chkSeparateFolders.Checked
        My.Settings.Save()
    End Sub

    ''' <summary>
    ''' Creates an XML file with the v2.2 SCP file format list of manufacturers and disk types. (Used in the onscreen combo boxes (ie just give the combo box index a name)
    ''' </summary>
    ''' <param name="XMLFile">Full Path to the XML file to create</param>
    ''' <returns></returns>
    Private Function WriteDefaultDiskTypesXML(ByVal XMLFile As String) As Boolean
        Try
            Dim writer As New System.Xml.XmlTextWriter(XMLFile, System.Text.Encoding.UTF8)
            writer.WriteStartDocument(True)
            writer.Formatting = System.Xml.Formatting.Indented
            writer.Indentation = 4
            writer.WriteStartElement("Disks")

            writer.WriteStartElement("Manufacturer")        'Manufacturer
            writer.WriteStartElement("Name")                'Name
            writer.WriteString("Commodore")
            writer.WriteEndElement()                        '/Name
            writer.WriteStartElement("DiskTypes")           'DiskTypes
            writer.WriteStartElement("Name")
            writer.WriteString("C64")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("Unused")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("Unused")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("Unused")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("Amiga")
            writer.WriteEndElement()
            writer.WriteEndElement()                        '/DiskTypes
            writer.WriteEndElement()                        '/Manufacturer

            writer.WriteStartElement("Manufacturer")
            writer.WriteStartElement("Name")
            writer.WriteString("Atari")
            writer.WriteEndElement()
            writer.WriteStartElement("DiskTypes")
            writer.WriteStartElement("Name")
            writer.WriteString("Atari 8-bit (FM) Single Density")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("Atari 8-bit (FM) Double Density")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("Atari 8-bit (FM) Enhanced Density")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("Unused")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("Atari ST (Single Sided) (Double Density)")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("Atari ST (Double Sided) (Double Density)")
            writer.WriteEndElement()
            writer.WriteEndElement()                        '/DiskTypes
            writer.WriteEndElement()                        '/Manufacturer

            writer.WriteStartElement("Manufacturer")
            writer.WriteStartElement("Name")
            writer.WriteString("Apple")
            writer.WriteEndElement()
            writer.WriteStartElement("DiskTypes")
            writer.WriteStartElement("Name")
            writer.WriteString("Apple II")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("Apple II Pro")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("Unused")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("Unused")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("Apple 400Kb (Double Density) (Single Sided)")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("Apple 800Kb (Double Density) (Double Sided)")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("Apple 1.44Mb (High Density) (Double Sided)")
            writer.WriteEndElement()
            writer.WriteEndElement()                        '/DiskTypes
            writer.WriteEndElement()                        '/Manufacturer

            writer.WriteStartElement("Manufacturer")
            writer.WriteStartElement("Name")
            writer.WriteString("IBM PC")
            writer.WriteEndElement()
            writer.WriteStartElement("DiskTypes")
            writer.WriteStartElement("Name")
            writer.WriteString("360Kb (5.25"") (Double Density) (Double Sided) [40 Track]")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("720Kb (3.5"") (Double Density) (Double Sided)")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("1.2Mb (5.25"") (High Density) (Double Sided)")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("1.44Mb (3.5"") (High Density) (Double Sided)")
            writer.WriteEndElement()
            writer.WriteEndElement()                        '/DiskTypes
            writer.WriteEndElement()                        '/Manufacturer

            writer.WriteStartElement("Manufacturer")
            writer.WriteStartElement("Name")
            writer.WriteString("Tandy")
            writer.WriteEndElement()
            writer.WriteStartElement("DiskTypes")
            writer.WriteStartElement("Name")
            writer.WriteString("TRS80 (Single Density) (Single Sided)")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("TRS80 (Double Density) (Single Sided)")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("TRS80 (Single Density) (Double Sided)")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("TRS80 (Double Density) (Double Sided)")
            writer.WriteEndElement()
            writer.WriteEndElement()                        '/DiskTypes
            writer.WriteEndElement()                        '/Manufacturer

            writer.WriteStartElement("Manufacturer")
            writer.WriteStartElement("Name")
            writer.WriteString("Texas Instruments")
            writer.WriteEndElement()
            writer.WriteStartElement("DiskTypes")
            writer.WriteStartElement("Name")
            writer.WriteString("TI-99/4A")
            writer.WriteEndElement()
            writer.WriteEndElement()                        '/DiskTypes
            writer.WriteEndElement()                        '/Manufacturer

            writer.WriteStartElement("Manufacturer")
            writer.WriteStartElement("Name")
            writer.WriteString("Roland")
            writer.WriteEndElement()
            writer.WriteStartElement("DiskTypes")
            writer.WriteStartElement("Name")
            writer.WriteString("D20")
            writer.WriteEndElement()
            writer.WriteEndElement()                        '/DiskTypes
            writer.WriteEndElement()                        '/Manufacturer

            writer.WriteStartElement("Manufacturer")
            writer.WriteStartElement("Name")
            writer.WriteString("Amstrad")
            writer.WriteEndElement()
            writer.WriteStartElement("DiskTypes")
            writer.WriteStartElement("Name")
            writer.WriteString("CPC")
            writer.WriteEndElement()
            writer.WriteEndElement()                        '/DiskTypes
            writer.WriteEndElement()                        '/Manufacturer

            writer.WriteStartElement("Manufacturer")
            writer.WriteStartElement("Name")
            writer.WriteString("Other")
            writer.WriteEndElement()
            writer.WriteStartElement("DiskTypes")
            writer.WriteStartElement("Name")
            writer.WriteString("360Kb (5.25"") (Double Density) (Double Sided) [40 Track]")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("1.2Mb (5.25"") (High Density) (Double Sided)")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("Reserved (1)")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("Reserved (2)")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("720Kb (3.5"") (Double Density) (Double Sided)")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("1.44Mb (3.5"") (High Density) (Double Sided)")
            writer.WriteEndElement()
            writer.WriteEndElement()                        '/DiskTypes
            writer.WriteEndElement()                        '/Manufacturer

            writer.WriteStartElement("Manufacturer")
            writer.WriteStartElement("Name")
            writer.WriteString("Unused")
            writer.WriteEndElement()
            writer.WriteStartElement("DiskTypes")
            writer.WriteEndElement()                        '/DiskTypes
            writer.WriteEndElement()                        '/Manufacturer

            writer.WriteStartElement("Manufacturer")
            writer.WriteStartElement("Name")
            writer.WriteString("Unused")
            writer.WriteEndElement()
            writer.WriteStartElement("DiskTypes")
            writer.WriteEndElement()                        '/DiskTypes
            writer.WriteEndElement()                        '/Manufacturer

            writer.WriteStartElement("Manufacturer")
            writer.WriteStartElement("Name")
            writer.WriteString("Unused")
            writer.WriteEndElement()
            writer.WriteStartElement("DiskTypes")
            writer.WriteEndElement()                        '/DiskTypes
            writer.WriteEndElement()                        '/Manufacturer

            writer.WriteStartElement("Manufacturer")
            writer.WriteStartElement("Name")
            writer.WriteString("Unused")
            writer.WriteEndElement()
            writer.WriteStartElement("DiskTypes")
            writer.WriteEndElement()                        '/DiskTypes
            writer.WriteEndElement()                        '/Manufacturer

            writer.WriteStartElement("Manufacturer")
            writer.WriteStartElement("Name")
            writer.WriteString("Unused")
            writer.WriteEndElement()
            writer.WriteStartElement("DiskTypes")
            writer.WriteEndElement()                        '/DiskTypes
            writer.WriteEndElement()                        '/Manufacturer

            writer.WriteStartElement("Manufacturer")
            writer.WriteStartElement("Name")
            writer.WriteString("Tape Drive")
            writer.WriteEndElement()
            writer.WriteStartElement("DiskTypes")
            writer.WriteStartElement("Name")
            writer.WriteString("GCR (1)")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("GCR (2)")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("MFM")
            writer.WriteEndElement()
            writer.WriteEndElement()                        '/DiskTypes
            writer.WriteEndElement()                        '/Manufacturer

            writer.WriteStartElement("Manufacturer")
            writer.WriteStartElement("Name")
            writer.WriteString("Hard Drive")
            writer.WriteEndElement()
            writer.WriteStartElement("DiskTypes")
            writer.WriteStartElement("Name")
            writer.WriteString("MFM")
            writer.WriteEndElement()
            writer.WriteStartElement("Name")
            writer.WriteString("RLL")
            writer.WriteEndElement()
            writer.WriteEndElement()                        '/DiskTypes
            writer.WriteEndElement()                        '/Manufacturer


            writer.WriteEndDocument()
            writer.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="XMLFile"></param>
    ''' <returns></returns>
    Private Function ReadDefaultDiskXML(ByVal XMLFile As String) As Boolean
        Dim xd As New Xml.XmlDocument           'Create new XML Document. for the disks xml
        Dim xn As Xml.XmlNodeList               'Create a new XML Node, for reading disks xml nodes
        Dim xn2 As Xml.XmlNodeList               'Create a new XML Node, for reading disks xml nodes
        xd.Load(XMLFile)                        'Load disks xml into xml document
        Dim i As Integer                        'Count of number of manufacturer elements in the .xml file
        Dim x As Integer

        xn = xd.GetElementsByTagName("Manufacturer")
        For i = 0 To xn.Count - 1
            ReDim Preserve Manufacturers(xn.Count - 1)
            Try
                Manufacturers(i) = xn(i).FirstChild.InnerText.Trim

                xn2 = xn(i).ChildNodes.Item(1).ChildNodes
                If Not xn2 Is Nothing Then
                    'ReDim Preserve DiskArray(i, xn2.Count - 1)
                    For x = 0 To xn2.Count - 1
                        DiskArray(i, x) = xn2(x).InnerText.Trim 'Attributes.GetNamedItem("Name").InnerText.Trim
                    Next
                End If
            Catch ex As Exception
                Return False
            End Try
        Next
        Return True
    End Function

    ''' <summary>
    ''' Create a filename from the attributes onscreen. (Including checking if file exists, if necessary)
    ''' </summary>
    ''' <param name="CheckExists">Check to see if the file exists on the disk. If so, append an integer to prevent GreaseSeazle from overwriting.</param>
    ''' <returns>Filename as a string.</returns>
    Function CreateFileName(ByVal CheckExists As Boolean, ByVal UseFolders As Boolean) As String
        Dim regWhitespace As New Regex("\s")

        Dim filen As String
        filen = txtTitle.Text                                                               'Set initial name to Title
        If txtPublisher.Text.Trim <> "" Then
            filen += "_" + txtPublisher.Text                                                'Add publisher if txt field not blank
        End If
        If cmbDiskOf.Text.Trim <> "" Then                                                   'If "DiskOf" field not blank,
            cmbDisk.Text = cmbDisk.Text.Trim.PadLeft(cmbDiskOf.Text.Length, CChar("0"))            'Pad "Disk" number to length of "DiskOf" field with preceding zeros
        End If
        If ((cmbDisk.Text.Trim <> "") Or (cmbDiskOf.Text.Trim <> "")) Then                  'If Disk or disk of fields are not blank, include _
            filen += "_"
        End If
        If cmbDisk.Text.Trim <> "" Then
            filen += "Disk" + cmbDisk.Text.Trim                                             'Add "disk" if txt field not blank
        End If
        If cmbDiskOf.Text.Trim <> "" Then
            filen += "Of" + cmbDiskOf.Text.Trim                                             'Add "disk of" if txt field not blank
        End If
        If cmbDiskRevision.Text.Trim <> "" Then
            filen += "_" + cmbDiskRevision.Text.Trim                                        'Add revision, if txt field not blank
        End If
        If cmbSystem.Text.Trim <> "" Then
            filen += "_" + cmbSystem.Text.Trim                                              'Add system, if txt field not blank
        End If
        If UseFolders = True Then
            filen += "\"
        Else
            filen += "_"
        End If
        If cmbDump.Text.Trim <> "" Then
            filen += "Dump" + cmbDump.Text.Trim                                       'Add 'Dump+DumpNumber' field, if dump field not blank
        End If

        Dim extst As String = ".scp"                                                        'Set file extension (defaulting to SuperCard Pro)

        Select Case cmbReadFormat.Text
            Case "Supercard Pro"                                                            'Set file extension for SuperCard Pro "SCP"
                extst = ".scp"
            Case "HxC Floppy Disk Emulator"                                                 'Set file extension for HxC Floppy format "HFE"
                extst = ".hfe"
            Case "EDSK (Extended Disk Image)"                                               'Set file extension for Extended Disk Image format (Spectrum +3, Amstrad CPC, Sam Coupe, PC)
                extst = ".dsk"
            Case "KryoFlux"                                                                 'Set file extension for KryoFlux heavy dump format "RAW"
                If UseFolders = True Then
                    extst = "\Track_.raw"
                Else
                    extst = ".raw"
                End If
            Case Else                                                                       'If a different unknown extension is typed in, use that!
                extst = cmbReadFormat.Text
        End Select

        If chkFilenameRreplaceSpaceWithUnderscore.Checked Then
            filen = regWhitespace.Replace(filen, "_")                                       'Replace all spaces with underscores, if check "replace with underscores" checked.
        End If
        If CheckExists = True Then                                                          'Check to see if file exists already. If so, get next available filename by appending "_X" where x is an ascending integer.
            Dim l As Integer = 0
            If My.Computer.FileSystem.FileExists(txtSaveLocation.Text.Trim + filen + extst) Then
                l = 1
                While My.Computer.FileSystem.FileExists(txtSaveLocation.Text.Trim + filen + "_" + CStr(l) + extst) = True
                    l += 1
                End While
            End If
            If l > 0 Then filen += "_" + CStr(l)
        End If
        filen += extst                                                                      'Finally, add the extension to the filename
        Return filen
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Function CheckForErrors() As Boolean
        If chkFilenameRreplaceSpaceWithUnderscore.Checked Then
            Cleanfields()
        End If
        If txtGWLocation.Text.Trim <> "" And txtSaveLocation.Text.Trim <> "" Then  'And cmbSerialPorts.Text.Trim <> "" 
            Return False
        Else
            Dim errstr As String = ""
            DoLOG()
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

            If chkUsePython.Checked Then
                If Not IO.File.Exists(txtPythonLocation.Text.Trim) Then
                    errstr &= "Python.exe Not found!" + Environment.NewLine
                End If
                If Not IO.File.Exists(txtGWLocation.Text.Trim) Then
                    errstr &= "GW script Not found!" + Environment.NewLine
                End If
            Else
                If Not IO.File.Exists(txtGWLocation.Text.Trim) Then
                    errstr &= "gw.exe Not found!" + Environment.NewLine
                End If
            End If
            rtbOutput.Text &= errstr
            Return True
        End If
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    Public Sub Cleanfields()
        Replace(txtTitle.Text, " ", "_")
        Replace(txtPublisher.Text, " ", "_")
        Replace(cmbSystem.Text, " ", "_")
        Replace(cmbDiskRevision.Text, " ", "_")
    End Sub

    ''' <summary>
    ''' Runs an exe or batch file, with the given arguments, with window shown, minimized or hidden.
    ''' </summary>
    ''' <param name="fileToRun">Batch file or EXE to run</param>
    ''' <param name="Arguments">Arguments for the batch/exe</param>
    ''' <param name="WinState">Windows state of the launched program</param>
    ''' <returns>True, if successfully launched.</returns>
    Function ExecuteCommand(ByVal fileToRun As String, ByVal Arguments As String, ByVal WinState As Integer) As Boolean
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
    ''' Add the GW.ErrorString to the Onscreen Memo text box
    ''' </summary>
    ''' <param name="GW">Greaseweazle instance</param>
    ''' <returns>True, if successful</returns>
    Function AddErrorToMemo(ByVal GW As GreaseWeazle) As Boolean
        Try
            If GW.ErrorString.Trim <> "" Then
                rtbOutput.Text += GW.ErrorString
                GW.ClearError()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Fills in the GW class instance from the main form
    ''' </summary>
    ''' <param name="GW">Greaseweazle class instance to fill in</param>
    ''' <returns>True if successful</returns>
    Function FillGWFromScreen(ByVal GW As GreaseWeazle) As Boolean
        Try
            If chkUsePython.Checked Then
                GW.PythonEXE = txtPythonLocation.Text
                AddErrorToMemo(GW)

                GW.PythonScript = txtGWLocation.Text
                AddErrorToMemo(GW)
            Else
                GW.PythonEXE = txtGWLocation.Text
                AddErrorToMemo(GW)
            End If

            GW.COMPort = cmbSerialPorts.Text
            AddErrorToMemo(GW)

            If chkRPM.Checked Then
                GW.RPM = CInt(cmbRPM.Text)
                AddErrorToMemo(GW)
            End If

            If chkRate.Checked Then
                GW.BitCellDataRate = CInt(cmbRate.Text)
                AddErrorToMemo(GW)
            End If

            If ChkStartTrack.Checked Then
                GW.StartTrack = CInt(cmbStartTrack.Text)
                AddErrorToMemo(GW)
            End If

            If chkEndTrack.Checked Then
                GW.EndTrack = CInt(cmbEndTrack.Text)
                AddErrorToMemo(GW)
            End If

            If chkTrackGroup.Checked Then
                If txtTrackGroup.Text.StartsWith(",") Then
                    txtTrackGroup.Text = txtTrackGroup.Text.Remove(0, 1)
                End If
                GW.TrackGroup = txtTrackGroup.Text
                AddErrorToMemo(GW)
            End If

            GW.Sides = cmbSides.Text
            AddErrorToMemo(GW)

            GW.TrackStep = CInt(cmbStepping.Text)
            AddErrorToMemo(GW)

            If chkWritePreCompensate.Checked Then
                GW.WritePreCompensate = True
                GW.WPC_Tracks = CInt(cmbWPCTracks.Text)
                AddErrorToMemo(GW)

                GW.WPC_Type = cmbWPCType.Text
                AddErrorToMemo(GW)

                GW.WPC_Width_NanoSeconds = CInt(txtWPCWidth.Text)
                AddErrorToMemo(GW)
            End If

            GW.EraseEmptyTracks = chkEraseEmpty.Checked

            If chkF7.Checked Then
                GW.F7Device = True

                GW.F7_Drive = cmbDriveSelect.Text
                AddErrorToMemo(GW)
            End If

            If chkSaveLog.Checked Then
                GW.SaveLogFile = True
            End If

            If chkExecuteScriptAfterRead.Checked Then
                GW.ExcuteScript = True

                GW.ExecuteScriptHiddenLevel = chkExecuteScriptAfterRead.CheckState
                AddErrorToMemo(GW)

                GW.ScriptFile = txtExecuteScript.Text
                AddErrorToMemo(GW)
            End If

            GW.SeekTrack = CInt(cmbSeekA.Text)
            AddErrorToMemo(GW)

            If cmbPIN.Text <> "" Then
                GW.Pin = CInt(cmbPIN.Text)
                AddErrorToMemo(GW)
            End If

            GW.HeadOffsetEnable = chkOffsetHead.Checked
            AddErrorToMemo(GW)

            GW.HeadOffsetTrackCount = CInt(cmbOffsetHeadBy.Text)
            AddErrorToMemo(GW)

            If cmbLowHigh.SelectedIndex > -1 Then
                GW.PinVoltage = CInt(cmbLowHigh.SelectedIndex)
                AddErrorToMemo(GW)
            End If

            If chkCleanPasses.Checked = True Then
                If IsNumeric(cmbCleanPasses.Text) Then
                    GW.CleanPasses = CInt(cmbCleanPasses.Text)
                End If
            End If

            If chkLingerCleaning.Checked = True Then
                If IsNumeric(cmbCleanMS.Text) Then
                    GW.CleanLingerMS = CInt(cmbCleanMS.Text)
                End If
            End If

            If chkRetries.Checked = True Then
                If IsNumeric(cmbRetries.Text) Then
                    GW.Retries = CInt(cmbRetries.Text)
                End If
            End If

            If chkTime.Checked = True Then
                GW.ShowTime = True
            End If

            If ((cmbReadFormat.Text.ToUpper = ".scp".ToUpper) Or (cmbReadFormat.Text.ToUpper = "Supercard Pro".ToUpper)) Then
                'this is an scp file, set SCP disk type details
                If cmbSystem.Text.ToUpper.Contains("Amiga".ToUpper) Then
                    GW.Manufacturer = 0
                    GW.DiskType = 4
                    GW.UseManufacturerAndDiskTypeCombined = False
                End If

                If chkSetManDiskType.Checked = True Then
                    GW.Manufacturer = cmbManufacturer.SelectedIndex
                    GW.DiskType = cmbDiskTypes.SelectedIndex
                    GW.UseManufacturerAndDiskTypeCombined = True
                End If
            Else
                'do nothing with SCP
            End If

            Return True
        Catch
            Return False
        End Try
    End Function

    Private Sub LinkLabelProjectName_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelProjectName.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/keirf/Greaseweazle")
    End Sub

    Private Sub LinkLabelGWWiki_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelGWWiki.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/keirf/Greaseweazle/wiki")
    End Sub

    Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click, READDiskToolStripMenuItem.Click
        If CheckForErrors() = False Then
            Dim GW As New GreaseWeazle
            GW.ClearError()
            FillGWFromScreen(GW)

            If chkLoop.Checked Then     'If running gw.py on a loop, to dump a disk multiple times
                Dim loopc As Integer
                For loopc = 0 To CInt(cmbDump.Text)
                    cmbDump.Text = CStr(loopc)
                    Dim fileGW As String = CreateFileName(True, chkSeparateFolders.Checked)
                    DoLOG()
                    rtbOutput.Clear()
                    rtbOutput.Text += "Reading from Greaseweazel on port " + cmbSerialPorts.Text + Environment.NewLine
                    rtbOutput.Text += "Start: " + cmbStartTrack.Text + "  End: " + cmbEndTrack.Text + "  Revolutions: " + cmbRevolutions.Text
                    rtbOutput.Text += "  Sides: " + cmbSides.Text
                    rtbOutput.Text += Environment.NewLine
                    If chkRate.Checked Then
                        rtbOutput.Text += "Bitcell Data Rate (kbit/s): " + cmbRate.Text
                    Else
                        rtbOutput.Text += "Bitcell Data Rate (kbit/s): 250 (Double Density)"
                    End If
                    rtbOutput.Text += Environment.NewLine
                    rtbOutput.Text &= "to file: " + fileGW + Environment.NewLine + Environment.NewLine
                    Me.Refresh()

                    If chkSeparateFolders.Checked = True Then
                        If (Not System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(txtSaveLocation.Text + fileGW))) Then
                            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(txtSaveLocation.Text + fileGW))
                        End If
                    End If

                    GW.FileName = txtSaveLocation.Text + fileGW
                    rtbOutput.Text += GW.ErrorString
                    GW.ClearError()

                    GW.Action = GW.GWRead

                    If GW.ExecuteGW() = False Then
                        rtbOutput.Text += GW.ErrorString
                    End If
                    rtbOutput.Text += GW.Results

                    Me.Refresh()
                Next                    'If running gw.py on a loop, to dump a disk multiple times
            Else    'Run gw.py once only
                Dim fileGW As String = CreateFileName(True, chkSeparateFolders.Checked)
                DoLOG()
                rtbOutput.Clear()
                rtbOutput.Text &= "Reading from Greaseweazel on port " + cmbSerialPorts.Text + Environment.NewLine
                rtbOutput.Text &= "Start: " + cmbStartTrack.Text + "  End: " + cmbEndTrack.Text + "  Revolutions: " + cmbRevolutions.Text
                rtbOutput.Text += "Sides: " + cmbSides.Text
                rtbOutput.Text &= Environment.NewLine
                If chkRate.Checked Then
                    rtbOutput.Text += "Bitcell Data Rate (kbit/s): " + cmbRate.Text
                Else
                    rtbOutput.Text += "Bitcell Data Rate (kbit/s): 250 (Double Density)"
                End If
                rtbOutput.Text += Environment.NewLine
                rtbOutput.Text &= "to file: " + fileGW + Environment.NewLine + Environment.NewLine
                Me.Refresh()

                If chkSeparateFolders.Checked = True Then
                    If (Not System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(txtSaveLocation.Text + fileGW))) Then
                        System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(txtSaveLocation.Text + fileGW))
                    End If
                End If

                GW.FileName = txtSaveLocation.Text + fileGW
                rtbOutput.Text += GW.ErrorString
                GW.ClearError()

                GW.Action = GW.GWRead

                If GW.ExecuteGW() = False Then
                    rtbOutput.Text += GW.ErrorString
                End If
                rtbOutput.Text += GW.Results

                Me.Refresh()

            End If  'Run gw.py once only
        Else
        End If
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveSettings()
        rtbOutput.AppendText(vbCrLf + "Closed on " + DateTime.Today.ToString("yyyy-MM-dd") + " at " + DateTime.Now.ToString("HH:mm:ss") + vbCrLf)
        DoLOG()
    End Sub

    Private Sub BtnSaveLocation_Click(sender As Object, e As EventArgs) Handles btnSaveLocation.Click
        If (FolderBrowserDialogSave.ShowDialog() = DialogResult.OK) Then
            txtSaveLocation.Text = FolderBrowserDialogSave.SelectedPath
            If Not txtSaveLocation.Text.EndsWith(IO.Path.DirectorySeparatorChar) Then
                txtSaveLocation.Text = txtSaveLocation.Text + IO.Path.DirectorySeparatorChar
            End If
        End If
    End Sub

    Private Sub BtnPythonLocation_Click(sender As Object, e As EventArgs) Handles btnGW_EXE.Click
        If chkUsePython.Checked Then 'Use python.exe, and python script
            OpenFileDialogMain.Title = "Select 'gw.py' or 'gw' in GreaseWeazle Directory"
            OpenFileDialogMain.Multiselect = False
            OpenFileDialogMain.FileName = "gw.py"
            OpenFileDialogMain.DefaultExt = "py"
            OpenFileDialogMain.Filter = "All files (*.*)|*.*|Python Scripts (*.py)|*.py|Program files (*.exe)|*.exe"
        Else 'Call gw.exe directly
            OpenFileDialogMain.Title = "Select 'gw.exe' in GreaseWeazle Directory"
            OpenFileDialogMain.Multiselect = False
            OpenFileDialogMain.FileName = "gw.exe"
            OpenFileDialogMain.DefaultExt = "exe"
            OpenFileDialogMain.Filter = "Program files (*.exe)|*.exe|All files (*.*)|*.*"
        End If

        If (OpenFileDialogMain.ShowDialog() = DialogResult.OK) Then
            txtGWLocation.Text = OpenFileDialogMain.FileName
        End If
    End Sub

    Private Sub BtnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click, WRITEDiskToolStripMenuItem.Click
        If CheckForErrors() = False Then
            OpenFileDialogMain.Title = "Select SuperCard Pro / HxC Floppy Emulator / Amiga ADF / PC 1.44MB IMG / Software Preservation Society IPF file to write to floppy"
            OpenFileDialogMain.Multiselect = False
            OpenFileDialogMain.FileName = ""
            OpenFileDialogMain.Filter = "Supported files|*.scp;*.hfe;*.adf;*.ipf;*.img;*.ima;*.dsk;*.raw|Supercard Pro files|*.scp|HxC Floppy Emulator HFE files|*.hfe|Commodore Amiga ADF files|*.adf| IBM 1.44MB image files|*.img;*.ima|Extended Disk Image files (EDSK)|*.dsk|Kryoflux files|*.raw|Software Preservation Society IPF files|*.ipf|All files (*.*)|*.*"
            Dim fileGW As String
            If (OpenFileDialogMain.ShowDialog() = DialogResult.OK) Then
                fileGW = OpenFileDialogMain.FileName
                DoLOG()
                rtbOutput.Clear()
                rtbOutput.Text &= "Writing to Greaseweazel on port " + cmbSerialPorts.Text + Environment.NewLine
                rtbOutput.Text &= "Start: " + cmbStartTrack.Text + "  End: " + cmbEndTrack.Text + "  Revolutions: " + cmbRevolutions.Text
                rtbOutput.Text &= "  Sides: " + cmbSides.Text
                rtbOutput.Text &= Environment.NewLine
                rtbOutput.Text &= "using file: " + fileGW + Environment.NewLine + Environment.NewLine

                Dim GW As New GreaseWeazle
                GW.ClearError()
                FillGWFromScreen(GW)

                GW.FileName = fileGW

                GW.Action = GW.GWWrite

                If GW.ExecuteGW() = False Then
                    rtbOutput.Text += GW.ErrorString
                End If
                rtbOutput.Text += GW.Results
            Else
                rtbOutput.Text &= Environment.NewLine + "Write image cancelled" + Environment.NewLine
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

    Private Sub ChkEndTrack_CheckedChanged(sender As Object, e As EventArgs) Handles chkEndTrack.CheckedChanged
        cmbEndTrack.Enabled = chkEndTrack.Checked
    End Sub

    Private Sub LinkLabelOpenLocation_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelOpenLocation.LinkClicked
        System.Diagnostics.Process.Start("explorer.exe", "/n,/e," + txtSaveLocation.Text)
    End Sub

    Private Sub BtnExecuteScript_Click(sender As Object, e As EventArgs) Handles btnExecuteScript.Click
        'TODO: set correct button width on window resize
        OpenFileDialogMain.Title = "Select script/exe to execute after read/write"
        OpenFileDialogMain.Multiselect = False
        OpenFileDialogMain.FileName = ""
        OpenFileDialogMain.DefaultExt = ""
        OpenFileDialogMain.Filter = "All files (*.*)|*.*|Program files|*.exe|Batch files/scripts|*.bat;*.cmd;*.ps1"

        If (OpenFileDialogMain.ShowDialog() = DialogResult.OK) Then
            txtExecuteScript.Text = OpenFileDialogMain.FileName
        End If
    End Sub

    Private Sub LinkLabelLaunchNow_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelLaunchNow.LinkClicked
        ExecuteCommand(txtExecuteScript.Text.Trim, txtSaveLocation.Text.Trim + CreateFileName(False, chkSeparateFolders.Checked), chkExecuteScriptAfterRead.CheckState)
    End Sub

    Private Sub ChkStartCyl_CheckedChanged(sender As Object, e As EventArgs) Handles ChkStartTrack.CheckedChanged
        cmbStartTrack.Enabled = ChkStartTrack.Checked
    End Sub

    Private Sub BtnResize_Click(sender As Object, e As EventArgs) Handles btnResize.Click
        If rtbOutput.Visible Then
            rtbOutput.Visible = False
            Me.MinimumSize = New Size(534, Me.Height)
            Me.Width = 534
            btnResize.Text = ">"
        Else
            rtbOutput.Visible = True
            Me.MinimumSize = New Size(924, Me.Height)
            Me.Width = 924
            btnResize.Text = "<"
        End If
        CheckVisible()
    End Sub

    Private Sub BtnUpdateFirmware_Click(sender As Object, e As EventArgs) Handles btnUpdateFirmware.Click, UpdateFirmwareToolStripMenuItem.Click
        Dim GW As New GreaseWeazle
        GW.ClearError()
        FillGWFromScreen(GW)

        rtbOutput.Text &= Environment.NewLine + Environment.NewLine
        If chkUsePython.Checked Then
            rtbOutput.Text &= "Remember to select the new gw.py in the 'Greaseweazle Location' before you start, if updating to a new version of Greasweazle"
        Else
            rtbOutput.Text &= "Remember to select the new gw.exe in the 'Greaseweazle Location' before you start, if updating to a new version of Greasweazle"
        End If
        rtbOutput.Text &= Environment.NewLine + Environment.NewLine
        rtbOutput.Text &= "Please ensure GND + DCLK are bridged with a jumper before the process starts."
        rtbOutput.Text &= Environment.NewLine + Environment.NewLine

        If Not My.Computer.Keyboard.CtrlKeyDown Then
            OpenFileDialogMain.Title = "Select 'Greaseweazle-v????.upd' in Greaseweazel Directory"
            OpenFileDialogMain.Multiselect = False
            OpenFileDialogMain.FileName = ""
            OpenFileDialogMain.DefaultExt = "upd"
            OpenFileDialogMain.Filter = "Update files (*.upd)|*.upd|All files (*.*)|*.*"

            Dim fileGW As String
            If (OpenFileDialogMain.ShowDialog() = DialogResult.OK) Then
                fileGW = OpenFileDialogMain.FileName
                DoLOG()
                rtbOutput.Clear()
                rtbOutput.Text &= "Updating Greaseweazel firmware on com port " + cmbSerialPorts.Text
                rtbOutput.Text &= Environment.NewLine
                rtbOutput.Text &= "using: " + fileGW
                rtbOutput.Text &= Environment.NewLine + Environment.NewLine

                If MessageBox.Show("Continue with flashing process?" + vbNewLine + vbNewLine + "Are GND + DCLK are bridged with a jumper also?", "Flash Greaseweazle", MessageBoxButtons.OKCancel) = DialogResult.OK Then

                    GW.FileName = fileGW

                    GW.Action = GW.GWUpdate

                    If GW.ExecuteGW() = False Then
                        rtbOutput.Text += GW.ErrorString
                    End If
                    rtbOutput.Text += GW.Results
                End If
            End If
        Else
            DoLOG()
            rtbOutput.Clear()
            rtbOutput.Text &= "Updating Greaseweazel Bootloader on com port " + cmbSerialPorts.Text
            rtbOutput.Text &= Environment.NewLine
            rtbOutput.Text &= "Warning: If unsuccessful, you may need to flash the firmware hex file to use the Greaseweazle again"
            rtbOutput.Text &= Environment.NewLine + Environment.NewLine
            If MessageBox.Show("Continue with Bootloader flashing?", "Flash Greaseweazle", MessageBoxButtons.OKCancel) = DialogResult.OK Then

                GW.Action = GW.GWFirmware

                If GW.ExecuteGW() = False Then
                    rtbOutput.Text += GW.ErrorString
                End If
                rtbOutput.Text += GW.Results

                rtbOutput.Text &= Environment.NewLine + Environment.NewLine
            End If
        End If
    End Sub

    Private Sub LinkLabelLaunchGW_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelLaunchGW.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/M1kerochip/LaunchGreaseWeazle")
    End Sub

    Private Sub BtnSetPin_Click(sender As Object, e As EventArgs) Handles btnSetPin.Click, SetPinLevelToolStripMenuItem.Click
        If IsNumeric(cmbPIN.Text) = True Then
            rtbOutput.Text &= "Setting pin level:"
            rtbOutput.Text &= Environment.NewLine + Environment.NewLine

            Dim GW As New GreaseWeazle
            GW.ClearError()
            FillGWFromScreen(GW)
            GW.Action = GW.GWSetPin

            If GW.ExecuteGW() = False Then
                rtbOutput.Text += GW.ErrorString
            End If
            rtbOutput.Text += GW.Results
        Else
            rtbOutput.Text &= Environment.NewLine + Environment.NewLine
            rtbOutput.Text &= "Pin to change must be selected in the Pin dropdown box."
        End If
    End Sub

    Private Sub BtnResetDevice_Click(sender As Object, e As EventArgs) Handles btnResetDevice.Click, RESETGreaseweazleToolStripMenuItem.Click
        rtbOutput.Text &= Environment.NewLine
        rtbOutput.Text &= "Issuing device reset:"
        rtbOutput.Text &= Environment.NewLine + Environment.NewLine

        Dim GW As New GreaseWeazle
        GW.ClearError()
        FillGWFromScreen(GW)
        GW.Action = GW.GWReset

        If GW.ExecuteGW() = False Then
            rtbOutput.Text += GW.ErrorString
        End If
        rtbOutput.Text += GW.Results
    End Sub

    Private Sub cmbDiskOf_LostFocus(sender As Object, e As EventArgs)
        If cmbDiskOf.Text.Trim <> "" Then
            If cmbDisk.Text.Length < cmbDiskOf.Text.Length Then
                cmbDisk.Text = cmbDisk.Text.Trim.PadLeft(cmbDiskOf.Text.Length, CChar("0"))                'Pad disk number to length of "diskof" field with leading zeros
            End If
            If cmbDisk.Text.Length > cmbDiskOf.Text.Length Then
                cmbDisk.Text = Microsoft.VisualBasic.Right(cmbDisk.Text, cmbDiskOf.Text.Length)     'Trim disk number to length of "diskof" field
            End If
        End If
    End Sub

    Private Sub lblSystem_Click(sender As Object, e As EventArgs) Handles lblSystem.Click
        If Me.BackColor = System.Drawing.SystemColors.Control Then
            EnableDarkTheme(True)
        Else
            EnableDarkTheme(False)
        End If
    End Sub

    Private Sub BtnEraseDisk_Click(sender As Object, e As EventArgs) Handles btnEraseDisk.Click
        rtbOutput.Text &= Environment.NewLine + "Erasing Disk:" + Environment.NewLine
        If MessageBox.Show("Erase floppy disk?", "Warning: Erase disk and wipe all contents from it.", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Dim GW As New GreaseWeazle
            GW.ClearError()
            FillGWFromScreen(GW)
            GW.Action = GW.GWErase

            If GW.ExecuteGW() = False Then
                rtbOutput.Text += GW.ErrorString
            End If
            rtbOutput.Text += GW.Results
        Else
            rtbOutput.Text &= Environment.NewLine + "Erasing Disk: Cancelled" + Environment.NewLine
        End If
    End Sub

    Private Sub BtnHidePaths_Click(sender As Object, e As EventArgs) Handles btnHidePaths.Click
        If lblSaveLocation.Visible Then
            lblSaveLocation.Visible = False
            Me.Size = New Size(Me.Size.Width, Me.Size.Height - 110)
            btnHidePaths.Text = "V"
        Else
            lblSaveLocation.Visible = True
            Me.Size = New Size(Me.Size.Width, Me.Size.Height + 110)
            btnHidePaths.Text = "^"
        End If
        CheckVisible()
    End Sub

    ''' <summary>
    ''' Check to see which buttons, text boxes etc should be visible
    ''' </summary>
    Private Sub CheckVisible()
        LinkLabelOpenLocation.TabStop = lblSaveLocation.Visible
        txtSaveLocation.TabStop = lblSaveLocation.Visible
        btnSaveLocation.TabStop = lblSaveLocation.Visible
        lblGWLocation.TabStop = lblSaveLocation.Visible
        LinkLabelDLGW.TabStop = lblSaveLocation.Visible
        LinkLabelDownloadPython.TabStop = lblSaveLocation.Visible
        txtGWLocation.TabStop = lblSaveLocation.Visible
        btnGW_EXE.TabStop = lblSaveLocation.Visible

        LinkLabelOpenLocation.Visible = lblSaveLocation.Visible
        txtSaveLocation.Visible = lblSaveLocation.Visible
        btnSaveLocation.Visible = lblSaveLocation.Visible
        lblGWLocation.Visible = lblSaveLocation.Visible
        LinkLabelDLGW.Visible = lblSaveLocation.Visible
        LinkLabelDownloadPython.Visible = lblSaveLocation.Visible
        txtGWLocation.Visible = lblSaveLocation.Visible
        btnGW_EXE.Visible = lblSaveLocation.Visible
        chkUsePython.Visible = lblSaveLocation.Visible

        If chkUsePython.Checked Then
            lblPythonLocation.Visible = chkUsePython.Visible
            txtPythonLocation.Visible = chkUsePython.Visible
        Else
            lblPythonLocation.Visible = False
            txtPythonLocation.Visible = False
        End If

        rtbOutput.TabStop = rtbOutput.Visible
        btnSetPin.TabStop = rtbOutput.Visible
        cmbPIN.TabStop = rtbOutput.Visible
        cmbLowHigh.TabStop = rtbOutput.Visible
        btnEraseDisk.TabStop = rtbOutput.Visible
        btnResetDevice.TabStop = rtbOutput.Visible
        btnUpdateFirmware.TabStop = rtbOutput.Visible
        rtbOutput.Visible = rtbOutput.Visible
        btnSetPin.Visible = rtbOutput.Visible
        cmbPIN.Visible = rtbOutput.Visible
        cmbLowHigh.Visible = rtbOutput.Visible
        btnEraseDisk.Visible = rtbOutput.Visible
        btnResetDevice.Visible = rtbOutput.Visible
        btnUpdateFirmware.Visible = rtbOutput.Visible
        lblPin.Visible = rtbOutput.Visible
        lblState.Visible = rtbOutput.Visible
        chkLOG.Visible = rtbOutput.Visible
        btnSeekA.Visible = rtbOutput.Visible
        btnSeekB.Visible = rtbOutput.Visible
        cmbSeekA.Visible = rtbOutput.Visible
        cmbSeekB.Visible = rtbOutput.Visible
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click, GreaseweazleINFOToolStripMenuItem.Click
        rtbOutput.Text &= Environment.NewLine

        Dim GW As New GreaseWeazle

        GW.ClearError()
        FillGWFromScreen(GW)
        GW.Action = GW.GWInfo

        'Dim mea As MouseEventArgs = DirectCast(e, MouseEventArgs)
        'If mea.Button <> MouseButtons.Left Then
        '    GW.InfoBootloader = True            ' Set the GW info --bootloader flag
        'End If

        If GW.ExecuteGW() = False Then
            rtbOutput.Text += GW.ErrorString
        End If
        rtbOutput.Text &= Environment.NewLine
        rtbOutput.Text += GW.Results
        rtbOutput.Text &= Environment.NewLine

        If chkF7.Checked Then
            GW.InfoBootloader = True            ' Set the GW info --bootloader flag
            If GW.ExecuteGW() = False Then
                rtbOutput.Text += GW.ErrorString
            End If
            rtbOutput.Text += GW.Results
        End If
    End Sub

    Private Sub btnGWBandwidth_Click(sender As Object, e As EventArgs) Handles btnGWBandwidth.Click, GreaswweazleDToolStripMenuItem.Click
        rtbOutput.Text &= Environment.NewLine

        Dim GW As New GreaseWeazle
        GW.ClearError()
        FillGWFromScreen(GW)

        GW.Action = GW.GWBandwidth

        If GW.ExecuteGW() = False Then
            rtbOutput.Text += GW.ErrorString
        End If
        rtbOutput.Text += GW.Results
    End Sub

    Private Sub btnGWDelays_Click(sender As Object, e As EventArgs) Handles btnGWDelays.Click, GreaseweazleDelaysToolStripMenuItem.Click
        rtbOutput.Text &= Environment.NewLine

        Dim GW As New GreaseWeazle
        GW.ClearError()
        FillGWFromScreen(GW)

        GW.Action = GW.GWDelays

        If GW.ExecuteGW() = False Then
            rtbOutput.Text += GW.ErrorString
        End If
        rtbOutput.Text += GW.Results
    End Sub

    Private Sub chkRate_CheckedChanged(sender As Object, e As EventArgs) Handles chkRate.CheckedChanged
        cmbRate.Enabled = chkRate.Checked
    End Sub

    Private Sub chkRPM_CheckedChanged(sender As Object, e As EventArgs) Handles chkRPM.CheckedChanged
        cmbRPM.Enabled = chkRPM.Checked
    End Sub

    Private Sub chkRevolutions_CheckedChanged(sender As Object, e As EventArgs) Handles chkRevolutions.CheckedChanged
        cmbRevolutions.Enabled = chkRevolutions.Checked
    End Sub

    Private Sub EnableProgramLOGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableProgramLOGToolStripMenuItem.Click
        'Checks or unchecks the "Log" checkbox.
        EnableProgramLOGToolStripMenuItem.Checked = Not (chkLOG.Checked)
        chkLOG.Checked = EnableProgramLOGToolStripMenuItem.Checked
    End Sub

    Private Sub btnExecuteScript_Move(sender As Object, e As EventArgs) Handles btnExecuteScript.Move
        btnExecuteScript.Left = txtExecuteScript.Width + 12
        btnExecuteScript.Top = txtExecuteScript.Top
    End Sub

    Private Sub txtExecuteScript_Resize(sender As Object, e As EventArgs) Handles txtExecuteScript.Resize
        btnExecuteScript.Left = txtExecuteScript.Width + 12
        btnExecuteScript.Top = txtExecuteScript.Top
    End Sub

    Private Sub WriteLOGWithEachReadWriteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WriteLOGWithEachReadWriteToolStripMenuItem.Click
        'Checks or unchecks the "Write LOG" checkbox.
        WriteLOGWithEachReadWriteToolStripMenuItem.Checked = Not (chkSaveLog.Checked)
        chkSaveLog.Checked = WriteLOGWithEachReadWriteToolStripMenuItem.Checked
    End Sub

    Private Sub btnSeekA_Click(sender As Object, e As EventArgs) Handles btnSeekA.Click
        rtbOutput.Text &= Environment.NewLine
        If IsNumeric(cmbSeekA.Text) = True Then
            rtbOutput.Text &= "Moving floppy head to track: " + cmbSeekA.Text + Environment.NewLine

            Dim GW As New GreaseWeazle
            GW.ClearError()
            FillGWFromScreen(GW)

            GW.SeekTrack = CInt(cmbSeekA.Text)
            AddErrorToMemo(GW)

            GW.Action = GW.GWSeek

            If GW.ExecuteGW() = False Then
                rtbOutput.Text += GW.ErrorString
            End If
            rtbOutput.Text += GW.Results
        Else
            rtbOutput.Text &= "SeekA value '" + cmbSeekA.Text + "' isn't a number. Track number must be between 0 and 85."
        End If
    End Sub

    Private Sub btnSeekB_Click(sender As Object, e As EventArgs) Handles btnSeekB.Click
        rtbOutput.Text &= Environment.NewLine
        If IsNumeric(cmbSeekB.Text) = True Then
            rtbOutput.Text &= "Moving floppy head to track: " + cmbSeekB.Text + Environment.NewLine

            Dim GW As New GreaseWeazle
            GW.ClearError()
            FillGWFromScreen(GW)

            GW.SeekTrack = CInt(cmbSeekB.Text)
            AddErrorToMemo(GW)

            GW.Action = GW.GWSeek

            If GW.ExecuteGW() = False Then
                rtbOutput.Text += GW.ErrorString
            End If
            rtbOutput.Text += GW.Results
        Else
            rtbOutput.Text &= "SeekB value '" + cmbSeekB.Text + "' isn't a number. Track number must be between 0 and 85."
        End If
    End Sub

    Private Sub lblAddTrackList_Click(sender As Object, e As EventArgs) Handles lblAddTrackList.Click
        chkTrackGroup.Checked = True
        txtTrackGroup.Text += "," + cmbStartTrack.Text + "-" + cmbEndTrack.Text
        If txtTrackGroup.Text.StartsWith(",") Then
            txtTrackGroup.Text = txtTrackGroup.Text.Remove(0, 1)
        End If
    End Sub

    Private Sub lblClearTrackList_Click(sender As Object, e As EventArgs) Handles lblClearTrackList.Click
        txtTrackGroup.Text = ""
        chkTrackGroup.Checked = False
    End Sub

    Private Sub llabelPreCompensate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llabelPreCompensate.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/keirf/Greaseweazle/wiki/Write-Precompensation")
    End Sub

    Private Sub chkUsePython_CheckedChanged(sender As Object, e As EventArgs) Handles chkUsePython.CheckedChanged
        txtPythonLocation.Enabled = chkUsePython.Checked
        btnPython_EXE.Enabled = chkUsePython.Checked
        txtPythonLocation.Visible = chkUsePython.Checked
        lblPythonLocation.Visible = chkUsePython.Checked
        btnPython_EXE.Visible = chkUsePython.Checked
    End Sub

    Private Sub LinkLabelDownloadPython_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelDownloadPython.LinkClicked
        System.Diagnostics.Process.Start("https://www.python.org/downloads/windows/")
        rtbOutput.Text &= Environment.NewLine + Environment.NewLine
        rtbOutput.Text &= "After downloading and installing Python (Remember to add it to the PATH variable), please run the following from a command prompt:" + Environment.NewLine + Environment.NewLine
        rtbOutput.Text &= "pip3 install crcmod pyserial" + Environment.NewLine + Environment.NewLine + "pip3 install bitarray" + Environment.NewLine + Environment.NewLine
    End Sub

    Private Sub btnPython_EXE_Click(sender As Object, e As EventArgs) Handles btnPython_EXE.Click
        OpenFileDialogMain.Title = "Select 'python.exe' in Python install Directory"
        OpenFileDialogMain.Multiselect = False
        OpenFileDialogMain.FileName = "python.exe"
        OpenFileDialogMain.DefaultExt = "exe"
        OpenFileDialogMain.Filter = "Program files (*.exe)|*.exe|All files (*.*)|*.*"

        If (OpenFileDialogMain.ShowDialog() = DialogResult.OK) Then
            txtPythonLocation.Text = OpenFileDialogMain.FileName
        End If
    End Sub

    Private Sub lblComPort_Click(sender As Object, e As EventArgs) Handles lblComPort.Click
        FillComPorts(cmbSerialPorts)
    End Sub

    Private Sub chkWritePreCompensate_CheckedChanged(sender As Object, e As EventArgs) Handles chkWritePreCompensate.CheckedChanged
        cmbWPCType.Enabled = chkWritePreCompensate.Checked
        cmbWPCTrackRange.Enabled = chkWritePreCompensate.Checked
        cmbWPCTracks.Enabled = chkWritePreCompensate.Checked
        txtWPCWidth.Enabled = chkWritePreCompensate.Checked
    End Sub

    Private Sub chkOffsetHead_CheckedChanged(sender As Object, e As EventArgs) Handles chkOffsetHead.CheckedChanged
        cmbOffsetHeadBy.Enabled = chkOffsetHead.Checked
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        If MessageBox.Show("Clean the disk drive, using a cleaning floppy?", "Clean drive heads using cleaning disk.", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            rtbOutput.Text &= Environment.NewLine

            Dim GW As New GreaseWeazle

            GW.ClearError()
            FillGWFromScreen(GW)
            GW.Action = GW.GWClean

            If GW.ExecuteGW() = False Then
                rtbOutput.Text += GW.ErrorString
            End If
            rtbOutput.Text += GW.Results
        Else
            rtbOutput.Text &= Environment.NewLine
            rtbOutput.Text &= "Drive clean canceled."
            rtbOutput.Text &= Environment.NewLine
        End If
    End Sub

    Private Sub chkCleanPasses_CheckedChanged(sender As Object, e As EventArgs) Handles chkCleanPasses.CheckedChanged
        cmbCleanPasses.Enabled = chkCleanPasses.Checked
    End Sub

    Private Sub chkLingerCleaning_CheckedChanged(sender As Object, e As EventArgs) Handles chkLingerCleaning.CheckedChanged
        cmbCleanMS.Enabled = chkLingerCleaning.Checked
    End Sub

    Private Sub chkRetries_CheckedChanged(sender As Object, e As EventArgs) Handles chkRetries.CheckedChanged
        cmbRetries.Enabled = chkRetries.Checked
    End Sub

    Private Sub cmbManufacturer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbManufacturer.SelectedIndexChanged
        If Not cmbManufacturer.SelectedIndex = -1 Then
            cmbDiskTypes.Items.Clear()
            cmbDiskTypes.Text = ""
            cmbDiskTypes.SelectedIndex = -1
            Dim x As Integer
            For x = 0 To 15
                If Not IsNothing(DiskArray(cmbManufacturer.SelectedIndex, x)) Then
                    If DiskArray(cmbManufacturer.SelectedIndex, x).Trim <> "" Then
                        cmbDiskTypes.Items.Add(DiskArray(cmbManufacturer.SelectedIndex, x))
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub chkSetManDiskType_CheckedChanged(sender As Object, e As EventArgs) Handles chkSetManDiskType.CheckedChanged
        cmbDiskTypes.Enabled = chkSetManDiskType.Checked
        cmbManufacturer.Enabled = chkSetManDiskType.Checked
    End Sub

    Private Sub LLabelSCP_Format_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLabelSCP_Format.LinkClicked
        System.Diagnostics.Process.Start("https://www.cbmstuff.com/downloads/scp/scp_image_specs.txt")
    End Sub

    Private Sub txtTitle_GotFocus(sender As Object, e As EventArgs) Handles txtTitle.GotFocus
        txtTitle.SelectAll()
    End Sub

    Private Sub txtPublisher_GotFocus(sender As Object, e As EventArgs) Handles txtPublisher.GotFocus
        txtPublisher.SelectAll()
    End Sub
End Class
