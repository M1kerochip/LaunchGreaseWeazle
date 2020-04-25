<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cmbSerialPorts = New System.Windows.Forms.ComboBox()
        Me.lblComPort = New System.Windows.Forms.Label()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.txtGWLocation = New System.Windows.Forms.TextBox()
        Me.lblGWLocation = New System.Windows.Forms.Label()
        Me.btnGWLocation = New System.Windows.Forms.Button()
        Me.txtPythonLocation = New System.Windows.Forms.TextBox()
        Me.lblPythonLocation = New System.Windows.Forms.Label()
        Me.btnPythonLocation = New System.Windows.Forms.Button()
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
        Me.chkSingleSided = New System.Windows.Forms.CheckBox()
        Me.LinkLabelDLPython = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelDLGW = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelOpenLocation = New System.Windows.Forms.LinkLabel()
        Me.chkAdjustSpeed = New System.Windows.Forms.CheckBox()
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
        Me.chkDoubleStep = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkFilenameRreplaceSpaceWithUnderscore = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbSerialPorts
        '
        Me.cmbSerialPorts.FormattingEnabled = True
        Me.cmbSerialPorts.Location = New System.Drawing.Point(432, 12)
        Me.cmbSerialPorts.Name = "cmbSerialPorts"
        Me.cmbSerialPorts.Size = New System.Drawing.Size(75, 21)
        Me.cmbSerialPorts.TabIndex = 6
        Me.cmbSerialPorts.Text = "auto"
        '
        'lblComPort
        '
        Me.lblComPort.AutoSize = True
        Me.lblComPort.Location = New System.Drawing.Point(368, 15)
        Me.lblComPort.Name = "lblComPort"
        Me.lblComPort.Size = New System.Drawing.Size(58, 13)
        Me.lblComPort.TabIndex = 4
        Me.lblComPort.Text = "COM Ports"
        '
        'rtbOutput
        '
        Me.rtbOutput.Location = New System.Drawing.Point(513, 12)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.Size = New System.Drawing.Size(386, 381)
        Me.rtbOutput.TabIndex = 100
        Me.rtbOutput.Text = ""
        '
        'txtGWLocation
        '
        Me.txtGWLocation.Location = New System.Drawing.Point(12, 305)
        Me.txtGWLocation.Name = "txtGWLocation"
        Me.txtGWLocation.Size = New System.Drawing.Size(465, 20)
        Me.txtGWLocation.TabIndex = 70
        '
        'lblGWLocation
        '
        Me.lblGWLocation.AutoSize = True
        Me.lblGWLocation.Location = New System.Drawing.Point(9, 289)
        Me.lblGWLocation.Name = "lblGWLocation"
        Me.lblGWLocation.Size = New System.Drawing.Size(151, 13)
        Me.lblGWLocation.TabIndex = 68
        Me.lblGWLocation.Text = "GreaseWeazel Script Location"
        '
        'btnGWLocation
        '
        Me.btnGWLocation.Location = New System.Drawing.Point(483, 305)
        Me.btnGWLocation.Name = "btnGWLocation"
        Me.btnGWLocation.Size = New System.Drawing.Size(24, 20)
        Me.btnGWLocation.TabIndex = 74
        Me.btnGWLocation.Text = "..."
        Me.btnGWLocation.UseVisualStyleBackColor = True
        '
        'txtPythonLocation
        '
        Me.txtPythonLocation.Location = New System.Drawing.Point(12, 354)
        Me.txtPythonLocation.Name = "txtPythonLocation"
        Me.txtPythonLocation.Size = New System.Drawing.Size(465, 20)
        Me.txtPythonLocation.TabIndex = 78
        '
        'lblPythonLocation
        '
        Me.lblPythonLocation.AutoSize = True
        Me.lblPythonLocation.Location = New System.Drawing.Point(9, 338)
        Me.lblPythonLocation.Name = "lblPythonLocation"
        Me.lblPythonLocation.Size = New System.Drawing.Size(104, 13)
        Me.lblPythonLocation.TabIndex = 76
        Me.lblPythonLocation.Text = "Python.exe Location"
        '
        'btnPythonLocation
        '
        Me.btnPythonLocation.Location = New System.Drawing.Point(483, 354)
        Me.btnPythonLocation.Name = "btnPythonLocation"
        Me.btnPythonLocation.Size = New System.Drawing.Size(24, 20)
        Me.btnPythonLocation.TabIndex = 82
        Me.btnPythonLocation.Text = "..."
        Me.btnPythonLocation.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRead.Location = New System.Drawing.Point(12, 437)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(240, 29)
        Me.btnRead.TabIndex = 96
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
        Me.lblTitle.TabIndex = 8
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
        Me.lbloDump.Location = New System.Drawing.Point(472, 86)
        Me.lbloDump.Name = "lbloDump"
        Me.lbloDump.Size = New System.Drawing.Size(35, 13)
        Me.lbloDump.TabIndex = 34
        Me.lbloDump.Text = "Dump"
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
        Me.btnWrite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWrite.Location = New System.Drawing.Point(267, 437)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(240, 29)
        Me.btnWrite.TabIndex = 98
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
        Me.chkF7.Location = New System.Drawing.Point(5, 18)
        Me.chkF7.Name = "chkF7"
        Me.chkF7.Size = New System.Drawing.Size(44, 17)
        Me.chkF7.TabIndex = 38
        Me.chkF7.Text = "F7 :"
        Me.chkF7.UseVisualStyleBackColor = True
        '
        'cmbDriveSelect
        '
        Me.cmbDriveSelect.FormattingEnabled = True
        Me.cmbDriveSelect.Items.AddRange(New Object() {"A", "B", "0", "1", "2"})
        Me.cmbDriveSelect.Location = New System.Drawing.Point(115, 16)
        Me.cmbDriveSelect.Name = "cmbDriveSelect"
        Me.cmbDriveSelect.Size = New System.Drawing.Size(40, 21)
        Me.cmbDriveSelect.TabIndex = 42
        '
        'LinkLabelDriveSelect
        '
        Me.LinkLabelDriveSelect.AutoSize = True
        Me.LinkLabelDriveSelect.Location = New System.Drawing.Point(44, 19)
        Me.LinkLabelDriveSelect.Name = "LinkLabelDriveSelect"
        Me.LinkLabelDriveSelect.Size = New System.Drawing.Size(65, 13)
        Me.LinkLabelDriveSelect.TabIndex = 40
        Me.LinkLabelDriveSelect.TabStop = True
        Me.LinkLabelDriveSelect.Text = "Drive Select"
        '
        'chkSaveLog
        '
        Me.chkSaveLog.AutoSize = True
        Me.chkSaveLog.Checked = True
        Me.chkSaveLog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSaveLog.Location = New System.Drawing.Point(176, 384)
        Me.chkSaveLog.Name = "chkSaveLog"
        Me.chkSaveLog.Size = New System.Drawing.Size(76, 17)
        Me.chkSaveLog.TabIndex = 88
        Me.chkSaveLog.Text = "Write LOG"
        Me.chkSaveLog.UseVisualStyleBackColor = True
        '
        'cmbEndTrack
        '
        Me.cmbEndTrack.FormattingEnabled = True
        Me.cmbEndTrack.Items.AddRange(New Object() {"79", "80", "81", "82", "83", "37", "38", "39", "40", "41", "42", "43"})
        Me.cmbEndTrack.Location = New System.Drawing.Point(255, 46)
        Me.cmbEndTrack.Name = "cmbEndTrack"
        Me.cmbEndTrack.Size = New System.Drawing.Size(42, 21)
        Me.cmbEndTrack.TabIndex = 56
        Me.cmbEndTrack.Text = "83"
        '
        'chkEndTrack
        '
        Me.chkEndTrack.AutoSize = True
        Me.chkEndTrack.Location = New System.Drawing.Point(172, 48)
        Me.chkEndTrack.Name = "chkEndTrack"
        Me.chkEndTrack.Size = New System.Drawing.Size(76, 17)
        Me.chkEndTrack.TabIndex = 54
        Me.chkEndTrack.Text = "End Track"
        Me.chkEndTrack.UseVisualStyleBackColor = True
        '
        'chkSingleSided
        '
        Me.chkSingleSided.AutoSize = True
        Me.chkSingleSided.Location = New System.Drawing.Point(332, 18)
        Me.chkSingleSided.Name = "chkSingleSided"
        Me.chkSingleSided.Size = New System.Drawing.Size(109, 17)
        Me.chkSingleSided.TabIndex = 48
        Me.chkSingleSided.Text = "Single Sided Disk"
        Me.chkSingleSided.UseVisualStyleBackColor = True
        '
        'LinkLabelDLPython
        '
        Me.LinkLabelDLPython.AutoSize = True
        Me.LinkLabelDLPython.Location = New System.Drawing.Point(386, 338)
        Me.LinkLabelDLPython.Name = "LinkLabelDLPython"
        Me.LinkLabelDLPython.Size = New System.Drawing.Size(91, 13)
        Me.LinkLabelDLPython.TabIndex = 80
        Me.LinkLabelDLPython.TabStop = True
        Me.LinkLabelDLPython.Text = "Download Python"
        '
        'LinkLabelDLGW
        '
        Me.LinkLabelDLGW.AutoSize = True
        Me.LinkLabelDLGW.Location = New System.Drawing.Point(346, 289)
        Me.LinkLabelDLGW.Name = "LinkLabelDLGW"
        Me.LinkLabelDLGW.Size = New System.Drawing.Size(131, 13)
        Me.LinkLabelDLGW.TabIndex = 72
        Me.LinkLabelDLGW.TabStop = True
        Me.LinkLabelDLGW.Text = "Download Greeaseweazle"
        '
        'LinkLabelOpenLocation
        '
        Me.LinkLabelOpenLocation.AutoSize = True
        Me.LinkLabelOpenLocation.Location = New System.Drawing.Point(400, 238)
        Me.LinkLabelOpenLocation.Name = "LinkLabelOpenLocation"
        Me.LinkLabelOpenLocation.Size = New System.Drawing.Size(77, 13)
        Me.LinkLabelOpenLocation.TabIndex = 64
        Me.LinkLabelOpenLocation.TabStop = True
        Me.LinkLabelOpenLocation.Text = "Open Location"
        '
        'chkAdjustSpeed
        '
        Me.chkAdjustSpeed.AutoSize = True
        Me.chkAdjustSpeed.Location = New System.Drawing.Point(332, 78)
        Me.chkAdjustSpeed.Name = "chkAdjustSpeed"
        Me.chkAdjustSpeed.Size = New System.Drawing.Size(117, 17)
        Me.chkAdjustSpeed.TabIndex = 60
        Me.chkAdjustSpeed.Text = "Adjust Write Speed"
        Me.chkAdjustSpeed.UseVisualStyleBackColor = True
        '
        'btnSaveLocation
        '
        Me.btnSaveLocation.Location = New System.Drawing.Point(483, 254)
        Me.btnSaveLocation.Name = "btnSaveLocation"
        Me.btnSaveLocation.Size = New System.Drawing.Size(24, 20)
        Me.btnSaveLocation.TabIndex = 66
        Me.btnSaveLocation.Text = "..."
        Me.btnSaveLocation.UseVisualStyleBackColor = True
        '
        'lblSaveLocation
        '
        Me.lblSaveLocation.AutoSize = True
        Me.lblSaveLocation.Location = New System.Drawing.Point(9, 238)
        Me.lblSaveLocation.Name = "lblSaveLocation"
        Me.lblSaveLocation.Size = New System.Drawing.Size(76, 13)
        Me.lblSaveLocation.TabIndex = 61
        Me.lblSaveLocation.Text = "Save Location"
        '
        'txtSaveLocation
        '
        Me.txtSaveLocation.Location = New System.Drawing.Point(12, 254)
        Me.txtSaveLocation.Name = "txtSaveLocation"
        Me.txtSaveLocation.Size = New System.Drawing.Size(465, 20)
        Me.txtSaveLocation.TabIndex = 62
        '
        'txtExecuteScript
        '
        Me.txtExecuteScript.Location = New System.Drawing.Point(12, 401)
        Me.txtExecuteScript.Name = "txtExecuteScript"
        Me.txtExecuteScript.Size = New System.Drawing.Size(465, 20)
        Me.txtExecuteScript.TabIndex = 86
        '
        'lblExecuteScript
        '
        Me.lblExecuteScript.AutoSize = True
        Me.lblExecuteScript.Location = New System.Drawing.Point(9, 385)
        Me.lblExecuteScript.Name = "lblExecuteScript"
        Me.lblExecuteScript.Size = New System.Drawing.Size(102, 13)
        Me.lblExecuteScript.TabIndex = 84
        Me.lblExecuteScript.Text = "Execute Script/EXE"
        '
        'btnExecuteScript
        '
        Me.btnExecuteScript.Location = New System.Drawing.Point(483, 401)
        Me.btnExecuteScript.Name = "btnExecuteScript"
        Me.btnExecuteScript.Size = New System.Drawing.Size(24, 20)
        Me.btnExecuteScript.TabIndex = 94
        Me.btnExecuteScript.Text = "..."
        Me.btnExecuteScript.UseVisualStyleBackColor = True
        '
        'chkExecuteScript
        '
        Me.chkExecuteScript.AutoSize = True
        Me.chkExecuteScript.Location = New System.Drawing.Point(267, 384)
        Me.chkExecuteScript.Name = "chkExecuteScript"
        Me.chkExecuteScript.Size = New System.Drawing.Size(144, 17)
        Me.chkExecuteScript.TabIndex = 90
        Me.chkExecuteScript.Text = "Execute script after R/W"
        Me.chkExecuteScript.UseVisualStyleBackColor = True
        '
        'LinkLabelLaunchNow
        '
        Me.LinkLabelLaunchNow.AutoSize = True
        Me.LinkLabelLaunchNow.Location = New System.Drawing.Point(406, 385)
        Me.LinkLabelLaunchNow.Name = "LinkLabelLaunchNow"
        Me.LinkLabelLaunchNow.Size = New System.Drawing.Size(71, 13)
        Me.LinkLabelLaunchNow.TabIndex = 92
        Me.LinkLabelLaunchNow.TabStop = True
        Me.LinkLabelLaunchNow.Text = "Execute Now"
        '
        'chkLoop
        '
        Me.chkLoop.AutoSize = True
        Me.chkLoop.Location = New System.Drawing.Point(451, 85)
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
        Me.chkRevolutions.TabIndex = 50
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
        Me.cmbRevolutions.TabIndex = 52
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
        Me.cmbStartTrack.TabIndex = 46
        Me.cmbStartTrack.Tag = ""
        Me.cmbStartTrack.Text = "0"
        '
        'ChkStartTrack
        '
        Me.ChkStartTrack.AutoSize = True
        Me.ChkStartTrack.Location = New System.Drawing.Point(172, 18)
        Me.ChkStartTrack.Name = "ChkStartTrack"
        Me.ChkStartTrack.Size = New System.Drawing.Size(79, 17)
        Me.ChkStartTrack.TabIndex = 44
        Me.ChkStartTrack.Text = "Start Track"
        Me.ChkStartTrack.UseVisualStyleBackColor = True
        '
        'btnResize
        '
        Me.btnResize.Location = New System.Drawing.Point(465, 29)
        Me.btnResize.Name = "btnResize"
        Me.btnResize.Size = New System.Drawing.Size(24, 53)
        Me.btnResize.TabIndex = 58
        Me.btnResize.Text = "<"
        Me.btnResize.UseVisualStyleBackColor = True
        '
        'btnUpdateFirmware
        '
        Me.btnUpdateFirmware.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateFirmware.Location = New System.Drawing.Point(656, 437)
        Me.btnUpdateFirmware.Name = "btnUpdateFirmware"
        Me.btnUpdateFirmware.Size = New System.Drawing.Size(240, 29)
        Me.btnUpdateFirmware.TabIndex = 98
        Me.btnUpdateFirmware.Text = "Update Firmware"
        Me.btnUpdateFirmware.UseVisualStyleBackColor = True
        '
        'LinkLabelLaunchGW
        '
        Me.LinkLabelLaunchGW.AutoSize = True
        Me.LinkLabelLaunchGW.Location = New System.Drawing.Point(264, 15)
        Me.LinkLabelLaunchGW.Name = "LinkLabelLaunchGW"
        Me.LinkLabelLaunchGW.Size = New System.Drawing.Size(62, 13)
        Me.LinkLabelLaunchGW.TabIndex = 101
        Me.LinkLabelLaunchGW.TabStop = True
        Me.LinkLabelLaunchGW.Text = "LaunchGW"
        '
        'btnResetDevice
        '
        Me.btnResetDevice.Location = New System.Drawing.Point(528, 437)
        Me.btnResetDevice.Name = "btnResetDevice"
        Me.btnResetDevice.Size = New System.Drawing.Size(109, 29)
        Me.btnResetDevice.TabIndex = 102
        Me.btnResetDevice.Text = "Reset Device"
        Me.btnResetDevice.UseVisualStyleBackColor = True
        '
        'cmbLowHigh
        '
        Me.cmbLowHigh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLowHigh.FormattingEnabled = True
        Me.cmbLowHigh.Items.AddRange(New Object() {"Low (0v)", "High (5v)"})
        Me.cmbLowHigh.Location = New System.Drawing.Point(808, 402)
        Me.cmbLowHigh.Name = "cmbLowHigh"
        Me.cmbLowHigh.Size = New System.Drawing.Size(88, 21)
        Me.cmbLowHigh.TabIndex = 103
        '
        'cmbPIN
        '
        Me.cmbPIN.FormattingEnabled = True
        Me.cmbPIN.Items.AddRange(New Object() {"2"})
        Me.cmbPIN.Location = New System.Drawing.Point(684, 402)
        Me.cmbPIN.Name = "cmbPIN"
        Me.cmbPIN.Size = New System.Drawing.Size(40, 21)
        Me.cmbPIN.TabIndex = 104
        '
        'btnSetPin
        '
        Me.btnSetPin.Location = New System.Drawing.Point(528, 401)
        Me.btnSetPin.Name = "btnSetPin"
        Me.btnSetPin.Size = New System.Drawing.Size(109, 20)
        Me.btnSetPin.TabIndex = 105
        Me.btnSetPin.Text = "Set Pin Level"
        Me.btnSetPin.UseVisualStyleBackColor = True
        '
        'lblPin
        '
        Me.lblPin.AutoSize = True
        Me.lblPin.Location = New System.Drawing.Point(653, 405)
        Me.lblPin.Name = "lblPin"
        Me.lblPin.Size = New System.Drawing.Size(25, 13)
        Me.lblPin.TabIndex = 106
        Me.lblPin.Text = "Pin:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(730, 405)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(75, 13)
        Me.lblState.TabIndex = 107
        Me.lblState.Text = "Voltage Level:"
        '
        'chkDoubleStep
        '
        Me.chkDoubleStep.AutoSize = True
        Me.chkDoubleStep.Location = New System.Drawing.Point(332, 48)
        Me.chkDoubleStep.Name = "chkDoubleStep"
        Me.chkDoubleStep.Size = New System.Drawing.Size(85, 17)
        Me.chkDoubleStep.TabIndex = 57
        Me.chkDoubleStep.Text = "Double Step"
        Me.chkDoubleStep.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkFilenameRreplaceSpaceWithUnderscore)
        Me.GroupBox1.Controls.Add(Me.chkDoubleStep)
        Me.GroupBox1.Controls.Add(Me.cmbStartTrack)
        Me.GroupBox1.Controls.Add(Me.ChkStartTrack)
        Me.GroupBox1.Controls.Add(Me.cmbRevolutions)
        Me.GroupBox1.Controls.Add(Me.chkRevolutions)
        Me.GroupBox1.Controls.Add(Me.chkAdjustSpeed)
        Me.GroupBox1.Controls.Add(Me.chkSingleSided)
        Me.GroupBox1.Controls.Add(Me.cmbEndTrack)
        Me.GroupBox1.Controls.Add(Me.btnResize)
        Me.GroupBox1.Controls.Add(Me.chkEndTrack)
        Me.GroupBox1.Controls.Add(Me.LinkLabelDriveSelect)
        Me.GroupBox1.Controls.Add(Me.cmbDriveSelect)
        Me.GroupBox1.Controls.Add(Me.chkF7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 105)
        Me.GroupBox1.TabIndex = 109
        Me.GroupBox1.TabStop = False
        '
        'chkFilenameRreplaceSpaceWithUnderscore
        '
        Me.chkFilenameRreplaceSpaceWithUnderscore.AutoSize = True
        Me.chkFilenameRreplaceSpaceWithUnderscore.Checked = True
        Me.chkFilenameRreplaceSpaceWithUnderscore.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFilenameRreplaceSpaceWithUnderscore.Location = New System.Drawing.Point(172, 78)
        Me.chkFilenameRreplaceSpaceWithUnderscore.Name = "chkFilenameRreplaceSpaceWithUnderscore"
        Me.chkFilenameRreplaceSpaceWithUnderscore.Size = New System.Drawing.Size(129, 17)
        Me.chkFilenameRreplaceSpaceWithUnderscore.TabIndex = 59
        Me.chkFilenameRreplaceSpaceWithUnderscore.Text = "Replace space with _"
        Me.chkFilenameRreplaceSpaceWithUnderscore.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 473)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.Controls.Add(Me.btnExecuteScript)
        Me.Controls.Add(Me.LinkLabelOpenLocation)
        Me.Controls.Add(Me.LinkLabelDLGW)
        Me.Controls.Add(Me.LinkLabelDLPython)
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
        Me.Controls.Add(Me.txtPythonLocation)
        Me.Controls.Add(Me.lblPythonLocation)
        Me.Controls.Add(Me.btnPythonLocation)
        Me.Controls.Add(Me.txtGWLocation)
        Me.Controls.Add(Me.lblGWLocation)
        Me.Controls.Add(Me.btnGWLocation)
        Me.Controls.Add(Me.txtSaveLocation)
        Me.Controls.Add(Me.lblComPort)
        Me.Controls.Add(Me.lblSaveLocation)
        Me.Controls.Add(Me.cmbSerialPorts)
        Me.Controls.Add(Me.btnSaveLocation)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Run GreaseWeazle Script"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbSerialPorts As ComboBox
    Friend WithEvents lblComPort As Label
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents txtGWLocation As TextBox
    Friend WithEvents lblGWLocation As Label
    Friend WithEvents btnGWLocation As Button
    Friend WithEvents txtPythonLocation As TextBox
    Friend WithEvents lblPythonLocation As Label
    Friend WithEvents btnPythonLocation As Button
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
    Friend WithEvents chkSingleSided As CheckBox
    Friend WithEvents LinkLabelDLPython As LinkLabel
    Friend WithEvents LinkLabelDLGW As LinkLabel
    Friend WithEvents LinkLabelOpenLocation As LinkLabel
    Friend WithEvents chkAdjustSpeed As CheckBox
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
    Friend WithEvents chkDoubleStep As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkFilenameRreplaceSpaceWithUnderscore As CheckBox
End Class
