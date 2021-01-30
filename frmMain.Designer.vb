<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.cmbSerialPorts = New System.Windows.Forms.ComboBox()
        Me.lblComPort = New System.Windows.Forms.Label()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStripMainCommands = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.READDiskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GreaseweazleINFOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.WRITEDiskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RESETGreaseweazleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateFirmwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SetPinLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.GreaswweazleDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.GreaseweazleDelaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableProgramLOGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator()
        Me.WriteLOGWithEachReadWriteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblGWLocation = New System.Windows.Forms.Label()
        Me.txtGWLocation = New System.Windows.Forms.TextBox()
        Me.btnGW_EXE = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.lblDiskRevision = New System.Windows.Forms.Label()
        Me.cmbDiskRevision = New System.Windows.Forms.ComboBox()
        Me.lblSystem = New System.Windows.Forms.Label()
        Me.cmbSystem = New System.Windows.Forms.ComboBox()
        Me.lbloDump = New System.Windows.Forms.Label()
        Me.cmbDump = New System.Windows.Forms.ComboBox()
        Me.lblDiskOf = New System.Windows.Forms.Label()
        Me.lblDisk = New System.Windows.Forms.Label()
        Me.cmbDisk = New System.Windows.Forms.ComboBox()
        Me.cmbDiskOf = New System.Windows.Forms.ComboBox()
        Me.LinkLabelProjectName = New System.Windows.Forms.LinkLabel()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.LinkLabelGWWiki = New System.Windows.Forms.LinkLabel()
        Me.FolderBrowserDialogSave = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialogMain = New System.Windows.Forms.OpenFileDialog()
        Me.chkF7 = New System.Windows.Forms.CheckBox()
        Me.cmbDriveSelect = New System.Windows.Forms.ComboBox()
        Me.LinkLabelDriveSelect = New System.Windows.Forms.LinkLabel()
        Me.chkSaveLog = New System.Windows.Forms.CheckBox()
        Me.cmbEndTrack = New System.Windows.Forms.ComboBox()
        Me.chkEndTrack = New System.Windows.Forms.CheckBox()
        Me.LinkLabelDLGW = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelOpenLocation = New System.Windows.Forms.LinkLabel()
        Me.btnSaveLocation = New System.Windows.Forms.Button()
        Me.lblSaveLocation = New System.Windows.Forms.Label()
        Me.txtSaveLocation = New System.Windows.Forms.TextBox()
        Me.txtExecuteScript = New System.Windows.Forms.TextBox()
        Me.lblExecuteScript = New System.Windows.Forms.Label()
        Me.btnExecuteScript = New System.Windows.Forms.Button()
        Me.chkExecuteScript = New System.Windows.Forms.CheckBox()
        Me.LinkLabelLaunchNow = New System.Windows.Forms.LinkLabel()
        Me.chkLoop = New System.Windows.Forms.CheckBox()
        Me.chkRevolutions = New System.Windows.Forms.CheckBox()
        Me.cmbRevolutions = New System.Windows.Forms.ComboBox()
        Me.cmbStartTrack = New System.Windows.Forms.ComboBox()
        Me.ChkStartTrack = New System.Windows.Forms.CheckBox()
        Me.btnResize = New System.Windows.Forms.Button()
        Me.ToolTipMainForm = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnUpdateFirmware = New System.Windows.Forms.Button()
        Me.LinkLabelLaunchGW = New System.Windows.Forms.LinkLabel()
        Me.btnResetDevice = New System.Windows.Forms.Button()
        Me.cmbLowHigh = New System.Windows.Forms.ComboBox()
        Me.cmbPIN = New System.Windows.Forms.ComboBox()
        Me.btnSetPin = New System.Windows.Forms.Button()
        Me.lblPin = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.GroupBoxGWOptions = New System.Windows.Forms.GroupBox()
        Me.lblWPCNanoSeconds = New System.Windows.Forms.Label()
        Me.lblWPCTracks = New System.Windows.Forms.Label()
        Me.lblWPCBy = New System.Windows.Forms.Label()
        Me.cmbWPCTracks = New System.Windows.Forms.ComboBox()
        Me.cmbWPCTrackRange = New System.Windows.Forms.ComboBox()
        Me.cmbWPCType = New System.Windows.Forms.ComboBox()
        Me.chkWritePreCompensate = New System.Windows.Forms.CheckBox()
        Me.txtWPCWidth = New System.Windows.Forms.TextBox()
        Me.lblHeadStep = New System.Windows.Forms.Label()
        Me.lblDiskSides = New System.Windows.Forms.Label()
        Me.chkTrackGroup = New System.Windows.Forms.CheckBox()
        Me.cmbSides = New System.Windows.Forms.ComboBox()
        Me.chkSeparateFolders = New System.Windows.Forms.CheckBox()
        Me.lblClearTrackList = New System.Windows.Forms.Label()
        Me.lblAddTrackList = New System.Windows.Forms.Label()
        Me.txtTrackGroup = New System.Windows.Forms.TextBox()
        Me.cmbStepping = New System.Windows.Forms.ComboBox()
        Me.chkEraseEmpty = New System.Windows.Forms.CheckBox()
        Me.cmbRPM = New System.Windows.Forms.ComboBox()
        Me.chkRPM = New System.Windows.Forms.CheckBox()
        Me.cmbRate = New System.Windows.Forms.ComboBox()
        Me.chkRate = New System.Windows.Forms.CheckBox()
        Me.btnHidePaths = New System.Windows.Forms.Button()
        Me.cmbReadFormat = New System.Windows.Forms.ComboBox()
        Me.chkFilenameRreplaceSpaceWithUnderscore = New System.Windows.Forms.CheckBox()
        Me.llabelPreCompensate = New System.Windows.Forms.LinkLabel()
        Me.btnEraseDisk = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnGWBandwidth = New System.Windows.Forms.Button()
        Me.btnGWDelays = New System.Windows.Forms.Button()
        Me.chkLOG = New System.Windows.Forms.CheckBox()
        Me.btnSeekA = New System.Windows.Forms.Button()
        Me.btnSeekB = New System.Windows.Forms.Button()
        Me.cmbSeekA = New System.Windows.Forms.ComboBox()
        Me.cmbSeekB = New System.Windows.Forms.ComboBox()
        Me.chkUsePython = New System.Windows.Forms.CheckBox()
        Me.txtPythonLocation = New System.Windows.Forms.TextBox()
        Me.LinkLabelDownloadPython = New System.Windows.Forms.LinkLabel()
        Me.btnPython_EXE = New System.Windows.Forms.Button()
        Me.lblPythonLocation = New System.Windows.Forms.Label()
        Me.ContextMenuStripMainCommands.SuspendLayout()
        Me.GroupBoxGWOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbSerialPorts
        '
        Me.cmbSerialPorts.FormattingEnabled = True
        Me.cmbSerialPorts.Location = New System.Drawing.Point(432, 12)
        Me.cmbSerialPorts.Name = "cmbSerialPorts"
        Me.cmbSerialPorts.Size = New System.Drawing.Size(75, 21)
        Me.cmbSerialPorts.TabIndex = 8
        '
        'lblComPort
        '
        Me.lblComPort.AutoSize = True
        Me.lblComPort.Location = New System.Drawing.Point(368, 15)
        Me.lblComPort.Name = "lblComPort"
        Me.lblComPort.Size = New System.Drawing.Size(58, 13)
        Me.lblComPort.TabIndex = 6
        Me.lblComPort.Text = "COM Ports"
        '
        'rtbOutput
        '
        Me.rtbOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbOutput.ContextMenuStrip = Me.ContextMenuStripMainCommands
        Me.rtbOutput.Location = New System.Drawing.Point(513, 12)
        Me.rtbOutput.MinimumSize = New System.Drawing.Size(386, 4)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.Size = New System.Drawing.Size(386, 466)
        Me.rtbOutput.TabIndex = 9
        Me.rtbOutput.Text = ""
        '
        'ContextMenuStripMainCommands
        '
        Me.ContextMenuStripMainCommands.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.READDiskToolStripMenuItem, Me.ToolStripMenuItem1, Me.GreaseweazleINFOToolStripMenuItem, Me.ToolStripMenuItem2, Me.WRITEDiskToolStripMenuItem, Me.ToolStripMenuItem3, Me.RESETGreaseweazleToolStripMenuItem, Me.ToolStripMenuItem4, Me.UpdateFirmwareToolStripMenuItem, Me.ToolStripMenuItem5, Me.SetPinLevelToolStripMenuItem, Me.ToolStripMenuItem6, Me.GreaswweazleDToolStripMenuItem, Me.ToolStripMenuItem7, Me.GreaseweazleDelaysToolStripMenuItem, Me.ToolStripMenuItem8, Me.LogOptionsToolStripMenuItem})
        Me.ContextMenuStripMainCommands.Name = "ContextMenuStripMainCommands"
        Me.ContextMenuStripMainCommands.Size = New System.Drawing.Size(278, 250)
        '
        'READDiskToolStripMenuItem
        '
        Me.READDiskToolStripMenuItem.Name = "READDiskToolStripMenuItem"
        Me.READDiskToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.READDiskToolStripMenuItem.Text = "READ Disk"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(274, 6)
        '
        'GreaseweazleINFOToolStripMenuItem
        '
        Me.GreaseweazleINFOToolStripMenuItem.Name = "GreaseweazleINFOToolStripMenuItem"
        Me.GreaseweazleINFOToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.GreaseweazleINFOToolStripMenuItem.Text = "Greaseweazle INFO"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(274, 6)
        '
        'WRITEDiskToolStripMenuItem
        '
        Me.WRITEDiskToolStripMenuItem.Name = "WRITEDiskToolStripMenuItem"
        Me.WRITEDiskToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.WRITEDiskToolStripMenuItem.Text = "WRITE Disk"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(274, 6)
        '
        'RESETGreaseweazleToolStripMenuItem
        '
        Me.RESETGreaseweazleToolStripMenuItem.Name = "RESETGreaseweazleToolStripMenuItem"
        Me.RESETGreaseweazleToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.RESETGreaseweazleToolStripMenuItem.Text = "RESET Greaseweazle"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(274, 6)
        '
        'UpdateFirmwareToolStripMenuItem
        '
        Me.UpdateFirmwareToolStripMenuItem.Name = "UpdateFirmwareToolStripMenuItem"
        Me.UpdateFirmwareToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.UpdateFirmwareToolStripMenuItem.Text = "Update Firmware"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(274, 6)
        '
        'SetPinLevelToolStripMenuItem
        '
        Me.SetPinLevelToolStripMenuItem.Name = "SetPinLevelToolStripMenuItem"
        Me.SetPinLevelToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.SetPinLevelToolStripMenuItem.Text = "Set Pin Level"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(274, 6)
        '
        'GreaswweazleDToolStripMenuItem
        '
        Me.GreaswweazleDToolStripMenuItem.Name = "GreaswweazleDToolStripMenuItem"
        Me.GreaswweazleDToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.GreaswweazleDToolStripMenuItem.Text = "Greaseweazle: Show Device Bandwidth"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(274, 6)
        '
        'GreaseweazleDelaysToolStripMenuItem
        '
        Me.GreaseweazleDelaysToolStripMenuItem.Name = "GreaseweazleDelaysToolStripMenuItem"
        Me.GreaseweazleDelaysToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.GreaseweazleDelaysToolStripMenuItem.Text = "Greaseweazle: Show Delays"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(274, 6)
        '
        'LogOptionsToolStripMenuItem
        '
        Me.LogOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableProgramLOGToolStripMenuItem, Me.ToolStripMenuItem9, Me.WriteLOGWithEachReadWriteToolStripMenuItem})
        Me.LogOptionsToolStripMenuItem.Name = "LogOptionsToolStripMenuItem"
        Me.LogOptionsToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.LogOptionsToolStripMenuItem.Text = "Log options:"
        '
        'EnableProgramLOGToolStripMenuItem
        '
        Me.EnableProgramLOGToolStripMenuItem.Name = "EnableProgramLOGToolStripMenuItem"
        Me.EnableProgramLOGToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.EnableProgramLOGToolStripMenuItem.Text = "Enable Program .LOG"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(241, 6)
        '
        'WriteLOGWithEachReadWriteToolStripMenuItem
        '
        Me.WriteLOGWithEachReadWriteToolStripMenuItem.Name = "WriteLOGWithEachReadWriteToolStripMenuItem"
        Me.WriteLOGWithEachReadWriteToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.WriteLOGWithEachReadWriteToolStripMenuItem.Text = "Write LOG with each Read/Write"
        '
        'lblGWLocation
        '
        Me.lblGWLocation.AutoSize = True
        Me.lblGWLocation.Location = New System.Drawing.Point(5, 386)
        Me.lblGWLocation.Name = "lblGWLocation"
        Me.lblGWLocation.Size = New System.Drawing.Size(121, 13)
        Me.lblGWLocation.TabIndex = 76
        Me.lblGWLocation.Text = "GreaseWeazel Location"
        '
        'txtGWLocation
        '
        Me.txtGWLocation.Location = New System.Drawing.Point(8, 402)
        Me.txtGWLocation.MinimumSize = New System.Drawing.Size(471, 20)
        Me.txtGWLocation.Name = "txtGWLocation"
        Me.txtGWLocation.Size = New System.Drawing.Size(471, 20)
        Me.txtGWLocation.TabIndex = 88
        '
        'btnGW_EXE
        '
        Me.btnGW_EXE.Location = New System.Drawing.Point(479, 402)
        Me.btnGW_EXE.Name = "btnGW_EXE"
        Me.btnGW_EXE.Size = New System.Drawing.Size(24, 20)
        Me.btnGW_EXE.TabIndex = 90
        Me.btnGW_EXE.Text = "..."
        Me.btnGW_EXE.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRead.Location = New System.Drawing.Point(12, 539)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(204, 29)
        Me.btnRead.TabIndex = 104
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(12, 57)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(240, 20)
        Me.txtTitle.TabIndex = 10
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 41)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(58, 13)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Game Title"
        '
        'txtPublisher
        '
        Me.txtPublisher.Location = New System.Drawing.Point(267, 57)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(240, 20)
        Me.txtPublisher.TabIndex = 14
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Location = New System.Drawing.Point(264, 41)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(50, 13)
        Me.lblPublisher.TabIndex = 12
        Me.lblPublisher.Text = "Publisher"
        '
        'lblDiskRevision
        '
        Me.lblDiskRevision.AutoSize = True
        Me.lblDiskRevision.Location = New System.Drawing.Point(357, 86)
        Me.lblDiskRevision.Name = "lblDiskRevision"
        Me.lblDiskRevision.Size = New System.Drawing.Size(79, 13)
        Me.lblDiskRevision.TabIndex = 28
        Me.lblDiskRevision.Text = "Revision/Serial"
        '
        'cmbDiskRevision
        '
        Me.cmbDiskRevision.FormattingEnabled = True
        Me.cmbDiskRevision.Location = New System.Drawing.Point(360, 102)
        Me.cmbDiskRevision.Name = "cmbDiskRevision"
        Me.cmbDiskRevision.Size = New System.Drawing.Size(106, 21)
        Me.cmbDiskRevision.TabIndex = 30
        '
        'lblSystem
        '
        Me.lblSystem.AutoSize = True
        Me.lblSystem.Location = New System.Drawing.Point(12, 86)
        Me.lblSystem.Name = "lblSystem"
        Me.lblSystem.Size = New System.Drawing.Size(41, 13)
        Me.lblSystem.TabIndex = 16
        Me.lblSystem.Text = "System"
        '
        'cmbSystem
        '
        Me.cmbSystem.FormattingEnabled = True
        Me.cmbSystem.Items.AddRange(New Object() {"AtariST", "Amiga", "IBMPC", "Spectrum", "Commodore64", "Amstrad", "AtariST-Amiga", "AtariST-IBMPC", "Amiga-IBMPC", "AtariST-Amiga-IBMPC"})
        Me.cmbSystem.Location = New System.Drawing.Point(12, 102)
        Me.cmbSystem.Name = "cmbSystem"
        Me.cmbSystem.Size = New System.Drawing.Size(240, 21)
        Me.cmbSystem.TabIndex = 18
        '
        'lbloDump
        '
        Me.lbloDump.AutoSize = True
        Me.lbloDump.Location = New System.Drawing.Point(468, 86)
        Me.lbloDump.Name = "lbloDump"
        Me.lbloDump.Size = New System.Drawing.Size(39, 13)
        Me.lbloDump.TabIndex = 34
        Me.lbloDump.Text = "Copies"
        '
        'cmbDump
        '
        Me.cmbDump.FormattingEnabled = True
        Me.cmbDump.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmbDump.Location = New System.Drawing.Point(470, 102)
        Me.cmbDump.Name = "cmbDump"
        Me.cmbDump.Size = New System.Drawing.Size(37, 21)
        Me.cmbDump.TabIndex = 36
        Me.cmbDump.Text = "0"
        '
        'lblDiskOf
        '
        Me.lblDiskOf.AutoSize = True
        Me.lblDiskOf.Location = New System.Drawing.Point(309, 86)
        Me.lblDiskOf.Name = "lblDiskOf"
        Me.lblDiskOf.Size = New System.Drawing.Size(16, 13)
        Me.lblDiskOf.TabIndex = 24
        Me.lblDiskOf.Text = "of"
        '
        'lblDisk
        '
        Me.lblDisk.AutoSize = True
        Me.lblDisk.Location = New System.Drawing.Point(264, 86)
        Me.lblDisk.Name = "lblDisk"
        Me.lblDisk.Size = New System.Drawing.Size(28, 13)
        Me.lblDisk.TabIndex = 20
        Me.lblDisk.Text = "Disk"
        '
        'cmbDisk
        '
        Me.cmbDisk.FormattingEnabled = True
        Me.cmbDisk.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbDisk.Location = New System.Drawing.Point(267, 102)
        Me.cmbDisk.Name = "cmbDisk"
        Me.cmbDisk.Size = New System.Drawing.Size(41, 21)
        Me.cmbDisk.TabIndex = 22
        Me.cmbDisk.Text = "1"
        '
        'cmbDiskOf
        '
        Me.cmbDiskOf.FormattingEnabled = True
        Me.cmbDiskOf.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "30", "40", "50", "60", "70", "80", "90", "100", "150", "200"})
        Me.cmbDiskOf.Location = New System.Drawing.Point(312, 102)
        Me.cmbDiskOf.Name = "cmbDiskOf"
        Me.cmbDiskOf.Size = New System.Drawing.Size(41, 21)
        Me.cmbDiskOf.TabIndex = 26
        Me.cmbDiskOf.Text = "1"
        '
        'LinkLabelProjectName
        '
        Me.LinkLabelProjectName.AutoSize = True
        Me.LinkLabelProjectName.Location = New System.Drawing.Point(12, 15)
        Me.LinkLabelProjectName.Name = "LinkLabelProjectName"
        Me.LinkLabelProjectName.Size = New System.Drawing.Size(192, 13)
        Me.LinkLabelProjectName.TabIndex = 0
        Me.LinkLabelProjectName.TabStop = True
        Me.LinkLabelProjectName.Text = "https://github.com/keirf/Greaseweazle"
        '
        'btnWrite
        '
        Me.btnWrite.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnWrite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWrite.Location = New System.Drawing.Point(297, 539)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(204, 29)
        Me.btnWrite.TabIndex = 106
        Me.btnWrite.Text = "Write"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'LinkLabelGWWiki
        '
        Me.LinkLabelGWWiki.AutoSize = True
        Me.LinkLabelGWWiki.Location = New System.Drawing.Point(224, 15)
        Me.LinkLabelGWWiki.Name = "LinkLabelGWWiki"
        Me.LinkLabelGWWiki.Size = New System.Drawing.Size(28, 13)
        Me.LinkLabelGWWiki.TabIndex = 2
        Me.LinkLabelGWWiki.TabStop = True
        Me.LinkLabelGWWiki.Text = "Wiki"
        '
        'OpenFileDialogMain
        '
        Me.OpenFileDialogMain.FileName = "OpenFileDialog1"
        '
        'chkF7
        '
        Me.chkF7.AutoSize = True
        Me.chkF7.Location = New System.Drawing.Point(5, 78)
        Me.chkF7.Name = "chkF7"
        Me.chkF7.Size = New System.Drawing.Size(44, 17)
        Me.chkF7.TabIndex = 58
        Me.chkF7.Text = "F7 :"
        Me.chkF7.UseVisualStyleBackColor = True
        '
        'cmbDriveSelect
        '
        Me.cmbDriveSelect.FormattingEnabled = True
        Me.cmbDriveSelect.Items.AddRange(New Object() {"A", "B", "0", "1", "2"})
        Me.cmbDriveSelect.Location = New System.Drawing.Point(115, 76)
        Me.cmbDriveSelect.Name = "cmbDriveSelect"
        Me.cmbDriveSelect.Size = New System.Drawing.Size(40, 21)
        Me.cmbDriveSelect.TabIndex = 62
        '
        'LinkLabelDriveSelect
        '
        Me.LinkLabelDriveSelect.AutoSize = True
        Me.LinkLabelDriveSelect.Location = New System.Drawing.Point(44, 79)
        Me.LinkLabelDriveSelect.Name = "LinkLabelDriveSelect"
        Me.LinkLabelDriveSelect.Size = New System.Drawing.Size(65, 13)
        Me.LinkLabelDriveSelect.TabIndex = 60
        Me.LinkLabelDriveSelect.TabStop = True
        Me.LinkLabelDriveSelect.Text = "Drive Select"
        '
        'chkSaveLog
        '
        Me.chkSaveLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkSaveLog.AutoSize = True
        Me.chkSaveLog.Checked = True
        Me.chkSaveLog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSaveLog.Location = New System.Drawing.Point(176, 486)
        Me.chkSaveLog.Name = "chkSaveLog"
        Me.chkSaveLog.Size = New System.Drawing.Size(76, 17)
        Me.chkSaveLog.TabIndex = 94
        Me.chkSaveLog.Text = "Write LOG"
        Me.chkSaveLog.UseVisualStyleBackColor = True
        '
        'cmbEndTrack
        '
        Me.cmbEndTrack.FormattingEnabled = True
        Me.cmbEndTrack.Items.AddRange(New Object() {"37", "38", "39", "40", "41", "42", "79", "80", "81", "82", "83", "84", "85"})
        Me.cmbEndTrack.Location = New System.Drawing.Point(255, 46)
        Me.cmbEndTrack.Name = "cmbEndTrack"
        Me.cmbEndTrack.Size = New System.Drawing.Size(42, 21)
        Me.cmbEndTrack.TabIndex = 52
        Me.cmbEndTrack.Text = "83"
        '
        'chkEndTrack
        '
        Me.chkEndTrack.AutoSize = True
        Me.chkEndTrack.Location = New System.Drawing.Point(177, 48)
        Me.chkEndTrack.Name = "chkEndTrack"
        Me.chkEndTrack.Size = New System.Drawing.Size(76, 17)
        Me.chkEndTrack.TabIndex = 50
        Me.chkEndTrack.Text = "End Track"
        Me.chkEndTrack.UseVisualStyleBackColor = True
        '
        'LinkLabelDLGW
        '
        Me.LinkLabelDLGW.AutoSize = True
        Me.LinkLabelDLGW.Location = New System.Drawing.Point(351, 386)
        Me.LinkLabelDLGW.Name = "LinkLabelDLGW"
        Me.LinkLabelDLGW.Size = New System.Drawing.Size(131, 13)
        Me.LinkLabelDLGW.TabIndex = 78
        Me.LinkLabelDLGW.TabStop = True
        Me.LinkLabelDLGW.Text = "Download Greeaseweazle"
        '
        'LinkLabelOpenLocation
        '
        Me.LinkLabelOpenLocation.AutoSize = True
        Me.LinkLabelOpenLocation.Location = New System.Drawing.Point(405, 336)
        Me.LinkLabelOpenLocation.Name = "LinkLabelOpenLocation"
        Me.LinkLabelOpenLocation.Size = New System.Drawing.Size(77, 13)
        Me.LinkLabelOpenLocation.TabIndex = 70
        Me.LinkLabelOpenLocation.TabStop = True
        Me.LinkLabelOpenLocation.Text = "Open Location"
        '
        'btnSaveLocation
        '
        Me.btnSaveLocation.Location = New System.Drawing.Point(479, 352)
        Me.btnSaveLocation.Name = "btnSaveLocation"
        Me.btnSaveLocation.Size = New System.Drawing.Size(24, 20)
        Me.btnSaveLocation.TabIndex = 74
        Me.btnSaveLocation.Text = "..."
        Me.btnSaveLocation.UseVisualStyleBackColor = True
        '
        'lblSaveLocation
        '
        Me.lblSaveLocation.AutoSize = True
        Me.lblSaveLocation.Location = New System.Drawing.Point(5, 336)
        Me.lblSaveLocation.Name = "lblSaveLocation"
        Me.lblSaveLocation.Size = New System.Drawing.Size(76, 13)
        Me.lblSaveLocation.TabIndex = 68
        Me.lblSaveLocation.Text = "Save Location"
        '
        'txtSaveLocation
        '
        Me.txtSaveLocation.Location = New System.Drawing.Point(8, 352)
        Me.txtSaveLocation.MinimumSize = New System.Drawing.Size(471, 20)
        Me.txtSaveLocation.Name = "txtSaveLocation"
        Me.txtSaveLocation.Size = New System.Drawing.Size(471, 20)
        Me.txtSaveLocation.TabIndex = 72
        '
        'txtExecuteScript
        '
        Me.txtExecuteScript.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExecuteScript.Location = New System.Drawing.Point(8, 503)
        Me.txtExecuteScript.MinimumSize = New System.Drawing.Size(471, 20)
        Me.txtExecuteScript.Name = "txtExecuteScript"
        Me.txtExecuteScript.Size = New System.Drawing.Size(475, 20)
        Me.txtExecuteScript.TabIndex = 100
        '
        'lblExecuteScript
        '
        Me.lblExecuteScript.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblExecuteScript.AutoSize = True
        Me.lblExecuteScript.Location = New System.Drawing.Point(5, 486)
        Me.lblExecuteScript.Name = "lblExecuteScript"
        Me.lblExecuteScript.Size = New System.Drawing.Size(102, 13)
        Me.lblExecuteScript.TabIndex = 92
        Me.lblExecuteScript.Text = "Execute Script/EXE"
        '
        'btnExecuteScript
        '
        Me.btnExecuteScript.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExecuteScript.Location = New System.Drawing.Point(483, 503)
        Me.btnExecuteScript.Name = "btnExecuteScript"
        Me.btnExecuteScript.Size = New System.Drawing.Size(24, 20)
        Me.btnExecuteScript.TabIndex = 102
        Me.btnExecuteScript.Text = "..."
        Me.btnExecuteScript.UseVisualStyleBackColor = True
        '
        'chkExecuteScript
        '
        Me.chkExecuteScript.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkExecuteScript.AutoSize = True
        Me.chkExecuteScript.Location = New System.Drawing.Point(267, 486)
        Me.chkExecuteScript.Name = "chkExecuteScript"
        Me.chkExecuteScript.Size = New System.Drawing.Size(144, 17)
        Me.chkExecuteScript.TabIndex = 96
        Me.chkExecuteScript.Text = "Execute script after R/W"
        Me.chkExecuteScript.ThreeState = True
        Me.chkExecuteScript.UseVisualStyleBackColor = True
        '
        'LinkLabelLaunchNow
        '
        Me.LinkLabelLaunchNow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabelLaunchNow.AutoSize = True
        Me.LinkLabelLaunchNow.Location = New System.Drawing.Point(414, 487)
        Me.LinkLabelLaunchNow.Name = "LinkLabelLaunchNow"
        Me.LinkLabelLaunchNow.Size = New System.Drawing.Size(71, 13)
        Me.LinkLabelLaunchNow.TabIndex = 98
        Me.LinkLabelLaunchNow.TabStop = True
        Me.LinkLabelLaunchNow.Text = "Execute Now"
        '
        'chkLoop
        '
        Me.chkLoop.AutoSize = True
        Me.chkLoop.Location = New System.Drawing.Point(451, 86)
        Me.chkLoop.Name = "chkLoop"
        Me.chkLoop.Size = New System.Drawing.Size(15, 14)
        Me.chkLoop.TabIndex = 32
        Me.chkLoop.UseVisualStyleBackColor = True
        '
        'chkRevolutions
        '
        Me.chkRevolutions.AutoSize = True
        Me.chkRevolutions.Checked = True
        Me.chkRevolutions.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRevolutions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRevolutions.Location = New System.Drawing.Point(6, 48)
        Me.chkRevolutions.Name = "chkRevolutions"
        Me.chkRevolutions.Size = New System.Drawing.Size(97, 17)
        Me.chkRevolutions.TabIndex = 46
        Me.chkRevolutions.Text = "Revolutions:"
        Me.chkRevolutions.UseVisualStyleBackColor = True
        '
        'cmbRevolutions
        '
        Me.cmbRevolutions.FormattingEnabled = True
        Me.cmbRevolutions.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cmbRevolutions.Location = New System.Drawing.Point(115, 46)
        Me.cmbRevolutions.Name = "cmbRevolutions"
        Me.cmbRevolutions.Size = New System.Drawing.Size(40, 21)
        Me.cmbRevolutions.TabIndex = 48
        Me.cmbRevolutions.Tag = ""
        Me.cmbRevolutions.Text = "5"
        '
        'cmbStartTrack
        '
        Me.cmbStartTrack.FormattingEnabled = True
        Me.cmbStartTrack.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmbStartTrack.Location = New System.Drawing.Point(255, 16)
        Me.cmbStartTrack.Name = "cmbStartTrack"
        Me.cmbStartTrack.Size = New System.Drawing.Size(42, 21)
        Me.cmbStartTrack.TabIndex = 42
        Me.cmbStartTrack.Tag = ""
        Me.cmbStartTrack.Text = "0"
        '
        'ChkStartTrack
        '
        Me.ChkStartTrack.AutoSize = True
        Me.ChkStartTrack.Location = New System.Drawing.Point(177, 18)
        Me.ChkStartTrack.Name = "ChkStartTrack"
        Me.ChkStartTrack.Size = New System.Drawing.Size(79, 17)
        Me.ChkStartTrack.TabIndex = 40
        Me.ChkStartTrack.Text = "Start Track"
        Me.ChkStartTrack.UseVisualStyleBackColor = True
        '
        'btnResize
        '
        Me.btnResize.Location = New System.Drawing.Point(465, 12)
        Me.btnResize.Name = "btnResize"
        Me.btnResize.Size = New System.Drawing.Size(24, 53)
        Me.btnResize.TabIndex = 56
        Me.btnResize.Text = "<"
        Me.btnResize.UseVisualStyleBackColor = True
        '
        'btnUpdateFirmware
        '
        Me.btnUpdateFirmware.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateFirmware.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateFirmware.Location = New System.Drawing.Point(733, 539)
        Me.btnUpdateFirmware.Name = "btnUpdateFirmware"
        Me.btnUpdateFirmware.Size = New System.Drawing.Size(163, 29)
        Me.btnUpdateFirmware.TabIndex = 122
        Me.btnUpdateFirmware.Text = "Update Firmware"
        Me.btnUpdateFirmware.UseVisualStyleBackColor = True
        '
        'LinkLabelLaunchGW
        '
        Me.LinkLabelLaunchGW.AutoSize = True
        Me.LinkLabelLaunchGW.Location = New System.Drawing.Point(264, 15)
        Me.LinkLabelLaunchGW.Name = "LinkLabelLaunchGW"
        Me.LinkLabelLaunchGW.Size = New System.Drawing.Size(62, 13)
        Me.LinkLabelLaunchGW.TabIndex = 4
        Me.LinkLabelLaunchGW.TabStop = True
        Me.LinkLabelLaunchGW.Text = "LaunchGW"
        '
        'btnResetDevice
        '
        Me.btnResetDevice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResetDevice.Location = New System.Drawing.Point(528, 539)
        Me.btnResetDevice.Name = "btnResetDevice"
        Me.btnResetDevice.Size = New System.Drawing.Size(93, 29)
        Me.btnResetDevice.TabIndex = 120
        Me.btnResetDevice.Text = "Reset Device"
        Me.btnResetDevice.UseVisualStyleBackColor = True
        '
        'cmbLowHigh
        '
        Me.cmbLowHigh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLowHigh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLowHigh.FormattingEnabled = True
        Me.cmbLowHigh.Items.AddRange(New Object() {"Low (0v)", "High (5v)"})
        Me.cmbLowHigh.Location = New System.Drawing.Point(808, 512)
        Me.cmbLowHigh.Name = "cmbLowHigh"
        Me.cmbLowHigh.Size = New System.Drawing.Size(88, 21)
        Me.cmbLowHigh.TabIndex = 116
        '
        'cmbPIN
        '
        Me.cmbPIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPIN.FormattingEnabled = True
        Me.cmbPIN.Items.AddRange(New Object() {"2"})
        Me.cmbPIN.Location = New System.Drawing.Point(684, 512)
        Me.cmbPIN.Name = "cmbPIN"
        Me.cmbPIN.Size = New System.Drawing.Size(40, 21)
        Me.cmbPIN.TabIndex = 112
        '
        'btnSetPin
        '
        Me.btnSetPin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSetPin.Location = New System.Drawing.Point(528, 511)
        Me.btnSetPin.Name = "btnSetPin"
        Me.btnSetPin.Size = New System.Drawing.Size(93, 21)
        Me.btnSetPin.TabIndex = 108
        Me.btnSetPin.Text = "Set Pin Level"
        Me.btnSetPin.UseVisualStyleBackColor = True
        '
        'lblPin
        '
        Me.lblPin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPin.AutoSize = True
        Me.lblPin.Location = New System.Drawing.Point(653, 516)
        Me.lblPin.Name = "lblPin"
        Me.lblPin.Size = New System.Drawing.Size(25, 13)
        Me.lblPin.TabIndex = 110
        Me.lblPin.Text = "Pin:"
        '
        'lblState
        '
        Me.lblState.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(730, 515)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(75, 13)
        Me.lblState.TabIndex = 114
        Me.lblState.Text = "Voltage Level:"
        '
        'GroupBoxGWOptions
        '
        Me.GroupBoxGWOptions.Controls.Add(Me.lblWPCNanoSeconds)
        Me.GroupBoxGWOptions.Controls.Add(Me.lblWPCTracks)
        Me.GroupBoxGWOptions.Controls.Add(Me.lblWPCBy)
        Me.GroupBoxGWOptions.Controls.Add(Me.cmbWPCTracks)
        Me.GroupBoxGWOptions.Controls.Add(Me.cmbWPCTrackRange)
        Me.GroupBoxGWOptions.Controls.Add(Me.cmbWPCType)
        Me.GroupBoxGWOptions.Controls.Add(Me.chkWritePreCompensate)
        Me.GroupBoxGWOptions.Controls.Add(Me.txtWPCWidth)
        Me.GroupBoxGWOptions.Controls.Add(Me.lblHeadStep)
        Me.GroupBoxGWOptions.Controls.Add(Me.lblDiskSides)
        Me.GroupBoxGWOptions.Controls.Add(Me.chkTrackGroup)
        Me.GroupBoxGWOptions.Controls.Add(Me.cmbSides)
        Me.GroupBoxGWOptions.Controls.Add(Me.chkSeparateFolders)
        Me.GroupBoxGWOptions.Controls.Add(Me.lblClearTrackList)
        Me.GroupBoxGWOptions.Controls.Add(Me.lblAddTrackList)
        Me.GroupBoxGWOptions.Controls.Add(Me.txtTrackGroup)
        Me.GroupBoxGWOptions.Controls.Add(Me.cmbStepping)
        Me.GroupBoxGWOptions.Controls.Add(Me.chkEraseEmpty)
        Me.GroupBoxGWOptions.Controls.Add(Me.cmbRPM)
        Me.GroupBoxGWOptions.Controls.Add(Me.chkRPM)
        Me.GroupBoxGWOptions.Controls.Add(Me.cmbRate)
        Me.GroupBoxGWOptions.Controls.Add(Me.chkRate)
        Me.GroupBoxGWOptions.Controls.Add(Me.btnHidePaths)
        Me.GroupBoxGWOptions.Controls.Add(Me.cmbReadFormat)
        Me.GroupBoxGWOptions.Controls.Add(Me.chkFilenameRreplaceSpaceWithUnderscore)
        Me.GroupBoxGWOptions.Controls.Add(Me.cmbStartTrack)
        Me.GroupBoxGWOptions.Controls.Add(Me.ChkStartTrack)
        Me.GroupBoxGWOptions.Controls.Add(Me.cmbRevolutions)
        Me.GroupBoxGWOptions.Controls.Add(Me.chkRevolutions)
        Me.GroupBoxGWOptions.Controls.Add(Me.cmbEndTrack)
        Me.GroupBoxGWOptions.Controls.Add(Me.btnResize)
        Me.GroupBoxGWOptions.Controls.Add(Me.chkEndTrack)
        Me.GroupBoxGWOptions.Controls.Add(Me.llabelPreCompensate)
        Me.GroupBoxGWOptions.Controls.Add(Me.LinkLabelDriveSelect)
        Me.GroupBoxGWOptions.Controls.Add(Me.cmbDriveSelect)
        Me.GroupBoxGWOptions.Controls.Add(Me.chkF7)
        Me.GroupBoxGWOptions.Location = New System.Drawing.Point(12, 128)
        Me.GroupBoxGWOptions.Name = "GroupBoxGWOptions"
        Me.GroupBoxGWOptions.Size = New System.Drawing.Size(495, 199)
        Me.GroupBoxGWOptions.TabIndex = 37
        Me.GroupBoxGWOptions.TabStop = False
        '
        'lblWPCNanoSeconds
        '
        Me.lblWPCNanoSeconds.AutoSize = True
        Me.lblWPCNanoSeconds.Location = New System.Drawing.Point(399, 109)
        Me.lblWPCNanoSeconds.Name = "lblWPCNanoSeconds"
        Me.lblWPCNanoSeconds.Size = New System.Drawing.Size(71, 13)
        Me.lblWPCNanoSeconds.TabIndex = 136
        Me.lblWPCNanoSeconds.Text = "nanoseconds"
        '
        'lblWPCTracks
        '
        Me.lblWPCTracks.AutoSize = True
        Me.lblWPCTracks.Location = New System.Drawing.Point(195, 109)
        Me.lblWPCTracks.Name = "lblWPCTracks"
        Me.lblWPCTracks.Size = New System.Drawing.Size(36, 13)
        Me.lblWPCTracks.TabIndex = 136
        Me.lblWPCTracks.Text = "tracks"
        '
        'lblWPCBy
        '
        Me.lblWPCBy.AutoSize = True
        Me.lblWPCBy.Location = New System.Drawing.Point(329, 109)
        Me.lblWPCBy.Name = "lblWPCBy"
        Me.lblWPCBy.Size = New System.Drawing.Size(18, 13)
        Me.lblWPCBy.TabIndex = 136
        Me.lblWPCBy.Text = "by"
        '
        'cmbWPCTracks
        '
        Me.cmbWPCTracks.FormattingEnabled = True
        Me.cmbWPCTracks.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40"})
        Me.cmbWPCTracks.Location = New System.Drawing.Point(281, 106)
        Me.cmbWPCTracks.Name = "cmbWPCTracks"
        Me.cmbWPCTracks.Size = New System.Drawing.Size(42, 21)
        Me.cmbWPCTracks.TabIndex = 135
        Me.cmbWPCTracks.Tag = ""
        Me.cmbWPCTracks.Text = "40"
        '
        'cmbWPCTrackRange
        '
        Me.cmbWPCTrackRange.FormattingEnabled = True
        Me.cmbWPCTrackRange.Items.AddRange(New Object() {"<=", "<", ">", ">="})
        Me.cmbWPCTrackRange.Location = New System.Drawing.Point(237, 106)
        Me.cmbWPCTrackRange.Name = "cmbWPCTrackRange"
        Me.cmbWPCTrackRange.Size = New System.Drawing.Size(38, 21)
        Me.cmbWPCTrackRange.TabIndex = 134
        Me.cmbWPCTrackRange.Tag = ""
        Me.cmbWPCTrackRange.Text = ">="
        '
        'cmbWPCType
        '
        Me.cmbWPCType.FormattingEnabled = True
        Me.cmbWPCType.Items.AddRange(New Object() {"mfm", "fm", "gcr"})
        Me.cmbWPCType.Location = New System.Drawing.Point(147, 106)
        Me.cmbWPCType.Name = "cmbWPCType"
        Me.cmbWPCType.Size = New System.Drawing.Size(42, 21)
        Me.cmbWPCType.TabIndex = 132
        Me.cmbWPCType.Tag = ""
        Me.cmbWPCType.Text = "mfm"
        '
        'chkWritePreCompensate
        '
        Me.chkWritePreCompensate.AutoSize = True
        Me.chkWritePreCompensate.Location = New System.Drawing.Point(5, 108)
        Me.chkWritePreCompensate.Name = "chkWritePreCompensate"
        Me.chkWritePreCompensate.Size = New System.Drawing.Size(15, 14)
        Me.chkWritePreCompensate.TabIndex = 131
        Me.chkWritePreCompensate.UseVisualStyleBackColor = True
        '
        'txtWPCWidth
        '
        Me.txtWPCWidth.Location = New System.Drawing.Point(353, 106)
        Me.txtWPCWidth.Name = "txtWPCWidth"
        Me.txtWPCWidth.Size = New System.Drawing.Size(40, 20)
        Me.txtWPCWidth.TabIndex = 130
        Me.txtWPCWidth.Text = "125"
        '
        'lblHeadStep
        '
        Me.lblHeadStep.AutoSize = True
        Me.lblHeadStep.Location = New System.Drawing.Point(345, 49)
        Me.lblHeadStep.Name = "lblHeadStep"
        Me.lblHeadStep.Size = New System.Drawing.Size(61, 13)
        Me.lblHeadStep.TabIndex = 129
        Me.lblHeadStep.Text = "Head Step:"
        '
        'lblDiskSides
        '
        Me.lblDiskSides.AutoSize = True
        Me.lblDiskSides.Location = New System.Drawing.Point(345, 19)
        Me.lblDiskSides.Name = "lblDiskSides"
        Me.lblDiskSides.Size = New System.Drawing.Size(60, 13)
        Me.lblDiskSides.TabIndex = 129
        Me.lblDiskSides.Text = "Disk Sides:"
        '
        'chkTrackGroup
        '
        Me.chkTrackGroup.AutoSize = True
        Me.chkTrackGroup.Location = New System.Drawing.Point(177, 78)
        Me.chkTrackGroup.Name = "chkTrackGroup"
        Me.chkTrackGroup.Size = New System.Drawing.Size(82, 17)
        Me.chkTrackGroup.TabIndex = 79
        Me.chkTrackGroup.Text = "Track set(s)"
        Me.chkTrackGroup.UseVisualStyleBackColor = True
        '
        'cmbSides
        '
        Me.cmbSides.FormattingEnabled = True
        Me.cmbSides.Items.AddRange(New Object() {"0-1", "0", "1"})
        Me.cmbSides.Location = New System.Drawing.Point(412, 16)
        Me.cmbSides.Name = "cmbSides"
        Me.cmbSides.Size = New System.Drawing.Size(42, 21)
        Me.cmbSides.TabIndex = 78
        Me.cmbSides.Tag = ""
        Me.cmbSides.Text = "0-1"
        '
        'chkSeparateFolders
        '
        Me.chkSeparateFolders.AutoSize = True
        Me.chkSeparateFolders.Location = New System.Drawing.Point(6, 138)
        Me.chkSeparateFolders.Name = "chkSeparateFolders"
        Me.chkSeparateFolders.Size = New System.Drawing.Size(135, 17)
        Me.chkSeparateFolders.TabIndex = 77
        Me.chkSeparateFolders.Text = "Create separate folders"
        Me.chkSeparateFolders.UseVisualStyleBackColor = True
        '
        'lblClearTrackList
        '
        Me.lblClearTrackList.AutoSize = True
        Me.lblClearTrackList.Location = New System.Drawing.Point(302, 49)
        Me.lblClearTrackList.Name = "lblClearTrackList"
        Me.lblClearTrackList.Size = New System.Drawing.Size(13, 13)
        Me.lblClearTrackList.TabIndex = 76
        Me.lblClearTrackList.Text = "c"
        '
        'lblAddTrackList
        '
        Me.lblAddTrackList.AutoSize = True
        Me.lblAddTrackList.Location = New System.Drawing.Point(302, 19)
        Me.lblAddTrackList.Name = "lblAddTrackList"
        Me.lblAddTrackList.Size = New System.Drawing.Size(13, 13)
        Me.lblAddTrackList.TabIndex = 75
        Me.lblAddTrackList.Text = "+"
        '
        'txtTrackGroup
        '
        Me.txtTrackGroup.Location = New System.Drawing.Point(265, 76)
        Me.txtTrackGroup.Name = "txtTrackGroup"
        Me.txtTrackGroup.Size = New System.Drawing.Size(189, 20)
        Me.txtTrackGroup.TabIndex = 74
        '
        'cmbStepping
        '
        Me.cmbStepping.FormattingEnabled = True
        Me.cmbStepping.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmbStepping.Location = New System.Drawing.Point(412, 46)
        Me.cmbStepping.Name = "cmbStepping"
        Me.cmbStepping.Size = New System.Drawing.Size(42, 21)
        Me.cmbStepping.TabIndex = 73
        Me.cmbStepping.Tag = ""
        Me.cmbStepping.Text = "1"
        '
        'chkEraseEmpty
        '
        Me.chkEraseEmpty.AutoSize = True
        Me.chkEraseEmpty.Location = New System.Drawing.Point(332, 138)
        Me.chkEraseEmpty.Name = "chkEraseEmpty"
        Me.chkEraseEmpty.Size = New System.Drawing.Size(156, 17)
        Me.chkEraseEmpty.TabIndex = 72
        Me.chkEraseEmpty.Text = "Erase empty tracks on write"
        Me.chkEraseEmpty.UseVisualStyleBackColor = True
        '
        'cmbRPM
        '
        Me.cmbRPM.FormattingEnabled = True
        Me.cmbRPM.Items.AddRange(New Object() {"300"})
        Me.cmbRPM.Location = New System.Drawing.Point(425, 166)
        Me.cmbRPM.Name = "cmbRPM"
        Me.cmbRPM.Size = New System.Drawing.Size(42, 21)
        Me.cmbRPM.TabIndex = 71
        Me.cmbRPM.Text = "300"
        '
        'chkRPM
        '
        Me.chkRPM.AutoSize = True
        Me.chkRPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRPM.Location = New System.Drawing.Point(332, 168)
        Me.chkRPM.Name = "chkRPM"
        Me.chkRPM.Size = New System.Drawing.Size(87, 17)
        Me.chkRPM.TabIndex = 70
        Me.chkRPM.Text = "Drive RPM"
        Me.chkRPM.UseVisualStyleBackColor = True
        '
        'cmbRate
        '
        Me.cmbRate.FormattingEnabled = True
        Me.cmbRate.Items.AddRange(New Object() {"250", "500"})
        Me.cmbRate.Location = New System.Drawing.Point(260, 166)
        Me.cmbRate.Name = "cmbRate"
        Me.cmbRate.Size = New System.Drawing.Size(42, 21)
        Me.cmbRate.TabIndex = 69
        Me.cmbRate.Text = "250"
        '
        'chkRate
        '
        Me.chkRate.AutoSize = True
        Me.chkRate.Location = New System.Drawing.Point(6, 168)
        Me.chkRate.Name = "chkRate"
        Me.chkRate.Size = New System.Drawing.Size(232, 17)
        Me.chkRate.TabIndex = 68
        Me.chkRate.Text = "Bitcell data rate in kbit/s (250=DD 500=HD)"
        Me.chkRate.UseVisualStyleBackColor = True
        '
        'btnHidePaths
        '
        Me.btnHidePaths.Location = New System.Drawing.Point(465, 79)
        Me.btnHidePaths.Name = "btnHidePaths"
        Me.btnHidePaths.Size = New System.Drawing.Size(24, 21)
        Me.btnHidePaths.TabIndex = 67
        Me.btnHidePaths.Text = "^"
        Me.btnHidePaths.UseVisualStyleBackColor = True
        '
        'cmbReadFormat
        '
        Me.cmbReadFormat.FormattingEnabled = True
        Me.cmbReadFormat.Items.AddRange(New Object() {"Supercard Pro", "KryoFlux", "HxC Floppy Disk Emulator"})
        Me.cmbReadFormat.Location = New System.Drawing.Point(6, 16)
        Me.cmbReadFormat.Name = "cmbReadFormat"
        Me.cmbReadFormat.Size = New System.Drawing.Size(149, 21)
        Me.cmbReadFormat.TabIndex = 38
        Me.cmbReadFormat.Tag = ""
        Me.cmbReadFormat.Text = "Supercard Pro"
        '
        'chkFilenameRreplaceSpaceWithUnderscore
        '
        Me.chkFilenameRreplaceSpaceWithUnderscore.AutoSize = True
        Me.chkFilenameRreplaceSpaceWithUnderscore.Checked = True
        Me.chkFilenameRreplaceSpaceWithUnderscore.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFilenameRreplaceSpaceWithUnderscore.Location = New System.Drawing.Point(177, 138)
        Me.chkFilenameRreplaceSpaceWithUnderscore.Name = "chkFilenameRreplaceSpaceWithUnderscore"
        Me.chkFilenameRreplaceSpaceWithUnderscore.Size = New System.Drawing.Size(129, 17)
        Me.chkFilenameRreplaceSpaceWithUnderscore.TabIndex = 64
        Me.chkFilenameRreplaceSpaceWithUnderscore.Text = "Replace space with _"
        Me.chkFilenameRreplaceSpaceWithUnderscore.UseVisualStyleBackColor = True
        '
        'llabelPreCompensate
        '
        Me.llabelPreCompensate.AutoSize = True
        Me.llabelPreCompensate.Location = New System.Drawing.Point(26, 109)
        Me.llabelPreCompensate.Name = "llabelPreCompensate"
        Me.llabelPreCompensate.Size = New System.Drawing.Size(109, 13)
        Me.llabelPreCompensate.TabIndex = 60
        Me.llabelPreCompensate.TabStop = True
        Me.llabelPreCompensate.Text = "Write Precompensate"
        '
        'btnEraseDisk
        '
        Me.btnEraseDisk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEraseDisk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEraseDisk.Location = New System.Drawing.Point(627, 539)
        Me.btnEraseDisk.Name = "btnEraseDisk"
        Me.btnEraseDisk.Size = New System.Drawing.Size(97, 29)
        Me.btnEraseDisk.TabIndex = 118
        Me.btnEraseDisk.Text = "Erase Disk"
        Me.btnEraseDisk.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.Location = New System.Drawing.Point(235, 539)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(43, 29)
        Me.btnInfo.TabIndex = 123
        Me.btnInfo.Text = "Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'btnGWBandwidth
        '
        Me.btnGWBandwidth.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGWBandwidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGWBandwidth.Location = New System.Drawing.Point(799, 324)
        Me.btnGWBandwidth.Name = "btnGWBandwidth"
        Me.btnGWBandwidth.Size = New System.Drawing.Size(68, 29)
        Me.btnGWBandwidth.TabIndex = 124
        Me.btnGWBandwidth.Text = "Bandwidth"
        Me.btnGWBandwidth.UseVisualStyleBackColor = True
        Me.btnGWBandwidth.Visible = False
        '
        'btnGWDelays
        '
        Me.btnGWDelays.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGWDelays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGWDelays.Location = New System.Drawing.Point(799, 279)
        Me.btnGWDelays.Name = "btnGWDelays"
        Me.btnGWDelays.Size = New System.Drawing.Size(68, 29)
        Me.btnGWDelays.TabIndex = 125
        Me.btnGWDelays.Text = "Delays"
        Me.btnGWDelays.UseVisualStyleBackColor = True
        Me.btnGWDelays.Visible = False
        '
        'chkLOG
        '
        Me.chkLOG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkLOG.AutoSize = True
        Me.chkLOG.Location = New System.Drawing.Point(808, 487)
        Me.chkLOG.Name = "chkLOG"
        Me.chkLOG.Size = New System.Drawing.Size(95, 17)
        Me.chkLOG.TabIndex = 126
        Me.chkLOG.Text = "Save LOG File"
        Me.chkLOG.UseVisualStyleBackColor = True
        '
        'btnSeekA
        '
        Me.btnSeekA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeekA.Location = New System.Drawing.Point(528, 484)
        Me.btnSeekA.Name = "btnSeekA"
        Me.btnSeekA.Size = New System.Drawing.Size(61, 21)
        Me.btnSeekA.TabIndex = 127
        Me.btnSeekA.Text = "Seek (A)"
        Me.btnSeekA.UseVisualStyleBackColor = True
        '
        'btnSeekB
        '
        Me.btnSeekB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeekB.Location = New System.Drawing.Point(663, 484)
        Me.btnSeekB.Name = "btnSeekB"
        Me.btnSeekB.Size = New System.Drawing.Size(61, 21)
        Me.btnSeekB.TabIndex = 128
        Me.btnSeekB.Text = "Seek (B)"
        Me.btnSeekB.UseVisualStyleBackColor = True
        '
        'cmbSeekA
        '
        Me.cmbSeekA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSeekA.FormattingEnabled = True
        Me.cmbSeekA.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmbSeekA.Location = New System.Drawing.Point(595, 485)
        Me.cmbSeekA.Name = "cmbSeekA"
        Me.cmbSeekA.Size = New System.Drawing.Size(42, 21)
        Me.cmbSeekA.TabIndex = 73
        Me.cmbSeekA.Tag = ""
        Me.cmbSeekA.Text = "0"
        '
        'cmbSeekB
        '
        Me.cmbSeekB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSeekB.FormattingEnabled = True
        Me.cmbSeekB.Items.AddRange(New Object() {"37", "38", "39", "40", "41", "42", "79", "80", "81", "82", "83", "84", "85"})
        Me.cmbSeekB.Location = New System.Drawing.Point(733, 484)
        Me.cmbSeekB.Name = "cmbSeekB"
        Me.cmbSeekB.Size = New System.Drawing.Size(42, 21)
        Me.cmbSeekB.TabIndex = 73
        Me.cmbSeekB.Text = "83"
        '
        'chkUsePython
        '
        Me.chkUsePython.AutoSize = True
        Me.chkUsePython.Location = New System.Drawing.Point(176, 435)
        Me.chkUsePython.Name = "chkUsePython"
        Me.chkUsePython.Size = New System.Drawing.Size(101, 17)
        Me.chkUsePython.TabIndex = 129
        Me.chkUsePython.Text = "Use Python.exe"
        Me.chkUsePython.UseVisualStyleBackColor = True
        '
        'txtPythonLocation
        '
        Me.txtPythonLocation.Location = New System.Drawing.Point(8, 452)
        Me.txtPythonLocation.MinimumSize = New System.Drawing.Size(471, 20)
        Me.txtPythonLocation.Name = "txtPythonLocation"
        Me.txtPythonLocation.Size = New System.Drawing.Size(471, 20)
        Me.txtPythonLocation.TabIndex = 130
        '
        'LinkLabelDownloadPython
        '
        Me.LinkLabelDownloadPython.AutoSize = True
        Me.LinkLabelDownloadPython.Location = New System.Drawing.Point(388, 436)
        Me.LinkLabelDownloadPython.Name = "LinkLabelDownloadPython"
        Me.LinkLabelDownloadPython.Size = New System.Drawing.Size(91, 13)
        Me.LinkLabelDownloadPython.TabIndex = 131
        Me.LinkLabelDownloadPython.TabStop = True
        Me.LinkLabelDownloadPython.Text = "Download Python"
        '
        'btnPython_EXE
        '
        Me.btnPython_EXE.Location = New System.Drawing.Point(479, 452)
        Me.btnPython_EXE.Name = "btnPython_EXE"
        Me.btnPython_EXE.Size = New System.Drawing.Size(24, 20)
        Me.btnPython_EXE.TabIndex = 132
        Me.btnPython_EXE.Text = "..."
        Me.btnPython_EXE.UseVisualStyleBackColor = True
        '
        'lblPythonLocation
        '
        Me.lblPythonLocation.AutoSize = True
        Me.lblPythonLocation.Location = New System.Drawing.Point(5, 436)
        Me.lblPythonLocation.Name = "lblPythonLocation"
        Me.lblPythonLocation.Size = New System.Drawing.Size(104, 13)
        Me.lblPythonLocation.TabIndex = 133
        Me.lblPythonLocation.Text = "Python.exe Location"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 575)
        Me.ContextMenuStrip = Me.ContextMenuStripMainCommands
        Me.Controls.Add(Me.lblPythonLocation)
        Me.Controls.Add(Me.btnPython_EXE)
        Me.Controls.Add(Me.LinkLabelDownloadPython)
        Me.Controls.Add(Me.txtPythonLocation)
        Me.Controls.Add(Me.chkUsePython)
        Me.Controls.Add(Me.cmbSeekB)
        Me.Controls.Add(Me.cmbSeekA)
        Me.Controls.Add(Me.btnSeekB)
        Me.Controls.Add(Me.btnSeekA)
        Me.Controls.Add(Me.chkLOG)
        Me.Controls.Add(Me.btnGWDelays)
        Me.Controls.Add(Me.btnGWBandwidth)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnExecuteScript)
        Me.Controls.Add(Me.btnEraseDisk)
        Me.Controls.Add(Me.GroupBoxGWOptions)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblPin)
        Me.Controls.Add(Me.btnSetPin)
        Me.Controls.Add(Me.cmbPIN)
        Me.Controls.Add(Me.cmbLowHigh)
        Me.Controls.Add(Me.btnResetDevice)
        Me.Controls.Add(Me.LinkLabelLaunchGW)
        Me.Controls.Add(Me.rtbOutput)
        Me.Controls.Add(Me.chkLoop)
        Me.Controls.Add(Me.LinkLabelLaunchNow)
        Me.Controls.Add(Me.chkExecuteScript)
        Me.Controls.Add(Me.txtExecuteScript)
        Me.Controls.Add(Me.lblExecuteScript)
        Me.Controls.Add(Me.LinkLabelOpenLocation)
        Me.Controls.Add(Me.LinkLabelDLGW)
        Me.Controls.Add(Me.chkSaveLog)
        Me.Controls.Add(Me.LinkLabelGWWiki)
        Me.Controls.Add(Me.btnUpdateFirmware)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.LinkLabelProjectName)
        Me.Controls.Add(Me.cmbDiskOf)
        Me.Controls.Add(Me.lblDisk)
        Me.Controls.Add(Me.cmbDisk)
        Me.Controls.Add(Me.lblDiskOf)
        Me.Controls.Add(Me.lbloDump)
        Me.Controls.Add(Me.cmbDump)
        Me.Controls.Add(Me.lblSystem)
        Me.Controls.Add(Me.cmbSystem)
        Me.Controls.Add(Me.lblDiskRevision)
        Me.Controls.Add(Me.cmbDiskRevision)
        Me.Controls.Add(Me.txtPublisher)
        Me.Controls.Add(Me.lblPublisher)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnGW_EXE)
        Me.Controls.Add(Me.lblGWLocation)
        Me.Controls.Add(Me.lblComPort)
        Me.Controls.Add(Me.lblSaveLocation)
        Me.Controls.Add(Me.cmbSerialPorts)
        Me.Controls.Add(Me.btnSaveLocation)
        Me.Controls.Add(Me.txtGWLocation)
        Me.Controls.Add(Me.txtSaveLocation)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(924, 39)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Run GreaseWeazle Script"
        Me.ContextMenuStripMainCommands.ResumeLayout(False)
        Me.GroupBoxGWOptions.ResumeLayout(False)
        Me.GroupBoxGWOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbSerialPorts As ComboBox
    Friend WithEvents lblComPort As Label
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents lblGWLocation As Label
    Friend WithEvents txtGWLocation As TextBox
    Friend WithEvents btnGW_EXE As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents lblPublisher As Label
    Friend WithEvents lblDiskRevision As Label
    Friend WithEvents cmbDiskRevision As ComboBox
    Friend WithEvents lblSystem As Label
    Friend WithEvents cmbSystem As ComboBox
    Friend WithEvents lbloDump As Label
    Friend WithEvents cmbDump As ComboBox
    Friend WithEvents lblDiskOf As Label
    Friend WithEvents lblDisk As Label
    Friend WithEvents cmbDisk As ComboBox
    Friend WithEvents cmbDiskOf As ComboBox
    Friend WithEvents LinkLabelProjectName As LinkLabel
    Friend WithEvents btnWrite As Button
    Friend WithEvents LinkLabelGWWiki As LinkLabel
    Friend WithEvents FolderBrowserDialogSave As FolderBrowserDialog
    Friend WithEvents OpenFileDialogMain As OpenFileDialog
    Friend WithEvents chkF7 As CheckBox
    Friend WithEvents cmbDriveSelect As ComboBox
    Friend WithEvents LinkLabelDriveSelect As LinkLabel
    Friend WithEvents chkSaveLog As CheckBox
    Friend WithEvents cmbEndTrack As ComboBox
    Friend WithEvents chkEndTrack As CheckBox
    Friend WithEvents LinkLabelDLGW As LinkLabel
    Friend WithEvents LinkLabelOpenLocation As LinkLabel
    Friend WithEvents btnSaveLocation As Button
    Friend WithEvents lblSaveLocation As Label
    Friend WithEvents txtSaveLocation As TextBox
    Friend WithEvents txtExecuteScript As TextBox
    Friend WithEvents lblExecuteScript As Label
    Friend WithEvents btnExecuteScript As Button
    Friend WithEvents chkExecuteScript As CheckBox
    Friend WithEvents LinkLabelLaunchNow As LinkLabel
    Friend WithEvents chkLoop As CheckBox
    Friend WithEvents chkRevolutions As CheckBox
    Friend WithEvents cmbRevolutions As ComboBox
    Friend WithEvents cmbStartTrack As ComboBox
    Friend WithEvents ChkStartTrack As CheckBox
    Friend WithEvents btnResize As Button
    Friend WithEvents ToolTipMainForm As ToolTip
    Friend WithEvents btnUpdateFirmware As Button
    Friend WithEvents LinkLabelLaunchGW As LinkLabel
    Friend WithEvents btnResetDevice As Button
    Friend WithEvents cmbLowHigh As ComboBox
    Friend WithEvents cmbPIN As ComboBox
    Friend WithEvents btnSetPin As Button
    Friend WithEvents lblPin As Label
    Friend WithEvents lblState As Label
    Friend WithEvents GroupBoxGWOptions As GroupBox
    Friend WithEvents chkFilenameRreplaceSpaceWithUnderscore As CheckBox
    Friend WithEvents btnEraseDisk As Button
    Friend WithEvents cmbReadFormat As ComboBox
    Friend WithEvents btnHidePaths As Button
    Friend WithEvents cmbRPM As ComboBox
    Friend WithEvents chkRPM As CheckBox
    Friend WithEvents cmbRate As ComboBox
    Friend WithEvents chkRate As CheckBox
    Friend WithEvents btnInfo As Button
    Friend WithEvents ContextMenuStripMainCommands As ContextMenuStrip
    Friend WithEvents READDiskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents GreaseweazleINFOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents WRITEDiskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents RESETGreaseweazleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents UpdateFirmwareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents SetPinLevelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripSeparator
    Friend WithEvents GreaswweazleDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripSeparator
    Friend WithEvents GreaseweazleDelaysToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnGWBandwidth As Button
    Friend WithEvents btnGWDelays As Button
    Friend WithEvents ToolStripMenuItem8 As ToolStripSeparator
    Friend WithEvents chkLOG As CheckBox
    Friend WithEvents LogOptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnableProgramLOGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripSeparator
    Friend WithEvents WriteLOGWithEachReadWriteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents chkEraseEmpty As CheckBox
    Friend WithEvents btnSeekA As Button
    Friend WithEvents btnSeekB As Button
    Friend WithEvents cmbSeekA As ComboBox
    Friend WithEvents cmbSeekB As ComboBox
    Friend WithEvents cmbStepping As ComboBox
    Friend WithEvents cmbSides As ComboBox
    Friend WithEvents chkSeparateFolders As CheckBox
    Friend WithEvents lblClearTrackList As Label
    Friend WithEvents lblAddTrackList As Label
    Friend WithEvents txtTrackGroup As TextBox
    Friend WithEvents chkTrackGroup As CheckBox
    Friend WithEvents lblHeadStep As Label
    Friend WithEvents lblDiskSides As Label
    Friend WithEvents lblWPCNanoSeconds As Label
    Friend WithEvents lblWPCTracks As Label
    Friend WithEvents lblWPCBy As Label
    Friend WithEvents cmbWPCTracks As ComboBox
    Friend WithEvents cmbWPCTrackRange As ComboBox
    Friend WithEvents cmbWPCType As ComboBox
    Friend WithEvents chkWritePreCompensate As CheckBox
    Friend WithEvents txtWPCWidth As TextBox
    Friend WithEvents llabelPreCompensate As LinkLabel
    Friend WithEvents chkUsePython As CheckBox
    Friend WithEvents txtPythonLocation As TextBox
    Friend WithEvents LinkLabelDownloadPython As LinkLabel
    Friend WithEvents btnPython_EXE As Button
    Friend WithEvents lblPythonLocation As Label
End Class
