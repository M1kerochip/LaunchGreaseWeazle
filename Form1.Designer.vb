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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cmbSerialPorts = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.SuspendLayout()
        '
        'cmbSerialPorts
        '
        Me.cmbSerialPorts.FormattingEnabled = True
        Me.cmbSerialPorts.Location = New System.Drawing.Point(432, 12)
        Me.cmbSerialPorts.Name = "cmbSerialPorts"
        Me.cmbSerialPorts.Size = New System.Drawing.Size(75, 21)
        Me.cmbSerialPorts.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(368, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "COM Ports"
        '
        'rtbOutput
        '
        Me.rtbOutput.Location = New System.Drawing.Point(513, 12)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.Size = New System.Drawing.Size(495, 408)
        Me.rtbOutput.TabIndex = 4
        Me.rtbOutput.Text = ""
        '
        'txtGWLocation
        '
        Me.txtGWLocation.Location = New System.Drawing.Point(12, 259)
        Me.txtGWLocation.Name = "txtGWLocation"
        Me.txtGWLocation.Size = New System.Drawing.Size(465, 20)
        Me.txtGWLocation.TabIndex = 9
        '
        'lblGWLocation
        '
        Me.lblGWLocation.AutoSize = True
        Me.lblGWLocation.Location = New System.Drawing.Point(9, 243)
        Me.lblGWLocation.Name = "lblGWLocation"
        Me.lblGWLocation.Size = New System.Drawing.Size(151, 13)
        Me.lblGWLocation.TabIndex = 8
        Me.lblGWLocation.Text = "GreaseWeazel Script Location"
        '
        'btnGWLocation
        '
        Me.btnGWLocation.Location = New System.Drawing.Point(483, 259)
        Me.btnGWLocation.Name = "btnGWLocation"
        Me.btnGWLocation.Size = New System.Drawing.Size(24, 20)
        Me.btnGWLocation.TabIndex = 7
        Me.btnGWLocation.Text = "..."
        Me.btnGWLocation.UseVisualStyleBackColor = True
        '
        'txtPythonLocation
        '
        Me.txtPythonLocation.Location = New System.Drawing.Point(12, 308)
        Me.txtPythonLocation.Name = "txtPythonLocation"
        Me.txtPythonLocation.Size = New System.Drawing.Size(465, 20)
        Me.txtPythonLocation.TabIndex = 12
        '
        'lblPythonLocation
        '
        Me.lblPythonLocation.AutoSize = True
        Me.lblPythonLocation.Location = New System.Drawing.Point(9, 292)
        Me.lblPythonLocation.Name = "lblPythonLocation"
        Me.lblPythonLocation.Size = New System.Drawing.Size(104, 13)
        Me.lblPythonLocation.TabIndex = 11
        Me.lblPythonLocation.Text = "Python.exe Location"
        '
        'btnPythonLocation
        '
        Me.btnPythonLocation.Location = New System.Drawing.Point(483, 308)
        Me.btnPythonLocation.Name = "btnPythonLocation"
        Me.btnPythonLocation.Size = New System.Drawing.Size(24, 20)
        Me.btnPythonLocation.TabIndex = 10
        Me.btnPythonLocation.Text = "..."
        Me.btnPythonLocation.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRead.Location = New System.Drawing.Point(12, 391)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(240, 29)
        Me.btnRead.TabIndex = 13
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(12, 57)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(240, 20)
        Me.txtTitle.TabIndex = 15
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 41)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(58, 13)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "Game Title"
        '
        'txtPublisher
        '
        Me.txtPublisher.Location = New System.Drawing.Point(267, 57)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(240, 20)
        Me.txtPublisher.TabIndex = 17
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Location = New System.Drawing.Point(264, 41)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(50, 13)
        Me.lblPublisher.TabIndex = 16
        Me.lblPublisher.Text = "Publisher"
        '
        'lblDiskRevision
        '
        Me.lblDiskRevision.AutoSize = True
        Me.lblDiskRevision.Location = New System.Drawing.Point(340, 86)
        Me.lblDiskRevision.Name = "lblDiskRevision"
        Me.lblDiskRevision.Size = New System.Drawing.Size(79, 13)
        Me.lblDiskRevision.TabIndex = 21
        Me.lblDiskRevision.Text = "Revision/Serial"
        '
        'cmbDiskRevision
        '
        Me.cmbDiskRevision.FormattingEnabled = True
        Me.cmbDiskRevision.Location = New System.Drawing.Point(343, 102)
        Me.cmbDiskRevision.Name = "cmbDiskRevision"
        Me.cmbDiskRevision.Size = New System.Drawing.Size(126, 21)
        Me.cmbDiskRevision.TabIndex = 20
        '
        'lblSystem
        '
        Me.lblSystem.AutoSize = True
        Me.lblSystem.Location = New System.Drawing.Point(12, 86)
        Me.lblSystem.Name = "lblSystem"
        Me.lblSystem.Size = New System.Drawing.Size(41, 13)
        Me.lblSystem.TabIndex = 23
        Me.lblSystem.Text = "System"
        '
        'cmbSystem
        '
        Me.cmbSystem.FormattingEnabled = True
        Me.cmbSystem.Items.AddRange(New Object() {"AtariST", "Amiga", "IBMPC", "Spectrum", "Commodore64", "Amstrad"})
        Me.cmbSystem.Location = New System.Drawing.Point(12, 102)
        Me.cmbSystem.Name = "cmbSystem"
        Me.cmbSystem.Size = New System.Drawing.Size(240, 21)
        Me.cmbSystem.TabIndex = 22
        '
        'lbloDump
        '
        Me.lbloDump.AutoSize = True
        Me.lbloDump.Location = New System.Drawing.Point(472, 86)
        Me.lbloDump.Name = "lbloDump"
        Me.lbloDump.Size = New System.Drawing.Size(35, 13)
        Me.lbloDump.TabIndex = 25
        Me.lbloDump.Text = "Dump"
        '
        'cmbDump
        '
        Me.cmbDump.FormattingEnabled = True
        Me.cmbDump.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cmbDump.Location = New System.Drawing.Point(475, 102)
        Me.cmbDump.Name = "cmbDump"
        Me.cmbDump.Size = New System.Drawing.Size(32, 21)
        Me.cmbDump.TabIndex = 24
        Me.cmbDump.Text = "0"
        '
        'lblDiskOf
        '
        Me.lblDiskOf.AutoSize = True
        Me.lblDiskOf.Location = New System.Drawing.Point(302, 86)
        Me.lblDiskOf.Name = "lblDiskOf"
        Me.lblDiskOf.Size = New System.Drawing.Size(16, 13)
        Me.lblDiskOf.TabIndex = 27
        Me.lblDiskOf.Text = "of"
        '
        'lblDisk
        '
        Me.lblDisk.AutoSize = True
        Me.lblDisk.Location = New System.Drawing.Point(264, 86)
        Me.lblDisk.Name = "lblDisk"
        Me.lblDisk.Size = New System.Drawing.Size(28, 13)
        Me.lblDisk.TabIndex = 29
        Me.lblDisk.Text = "Disk"
        '
        'cmbDisk
        '
        Me.cmbDisk.FormattingEnabled = True
        Me.cmbDisk.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbDisk.Location = New System.Drawing.Point(267, 102)
        Me.cmbDisk.Name = "cmbDisk"
        Me.cmbDisk.Size = New System.Drawing.Size(32, 21)
        Me.cmbDisk.TabIndex = 28
        Me.cmbDisk.Text = "1"
        '
        'cmbDiskOf
        '
        Me.cmbDiskOf.FormattingEnabled = True
        Me.cmbDiskOf.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbDiskOf.Location = New System.Drawing.Point(305, 102)
        Me.cmbDiskOf.Name = "cmbDiskOf"
        Me.cmbDiskOf.Size = New System.Drawing.Size(32, 21)
        Me.cmbDiskOf.TabIndex = 30
        Me.cmbDiskOf.Text = "1"
        '
        'LinkLabelProjectName
        '
        Me.LinkLabelProjectName.AutoSize = True
        Me.LinkLabelProjectName.Location = New System.Drawing.Point(12, 15)
        Me.LinkLabelProjectName.Name = "LinkLabelProjectName"
        Me.LinkLabelProjectName.Size = New System.Drawing.Size(192, 13)
        Me.LinkLabelProjectName.TabIndex = 31
        Me.LinkLabelProjectName.TabStop = True
        Me.LinkLabelProjectName.Text = "https://github.com/keirf/Greaseweazle"
        '
        'btnWrite
        '
        Me.btnWrite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWrite.Location = New System.Drawing.Point(267, 391)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(240, 29)
        Me.btnWrite.TabIndex = 32
        Me.btnWrite.Text = "Write"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'LinkLabelGWWiki
        '
        Me.LinkLabelGWWiki.AutoSize = True
        Me.LinkLabelGWWiki.Location = New System.Drawing.Point(267, 14)
        Me.LinkLabelGWWiki.Name = "LinkLabelGWWiki"
        Me.LinkLabelGWWiki.Size = New System.Drawing.Size(28, 13)
        Me.LinkLabelGWWiki.TabIndex = 33
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
        Me.chkF7.Location = New System.Drawing.Point(12, 150)
        Me.chkF7.Name = "chkF7"
        Me.chkF7.Size = New System.Drawing.Size(44, 17)
        Me.chkF7.TabIndex = 34
        Me.chkF7.Text = "F7 :"
        Me.chkF7.UseVisualStyleBackColor = True
        '
        'cmbDriveSelect
        '
        Me.cmbDriveSelect.FormattingEnabled = True
        Me.cmbDriveSelect.Items.AddRange(New Object() {"A", "B", "0", "1", "2"})
        Me.cmbDriveSelect.Location = New System.Drawing.Point(123, 148)
        Me.cmbDriveSelect.Name = "cmbDriveSelect"
        Me.cmbDriveSelect.Size = New System.Drawing.Size(40, 21)
        Me.cmbDriveSelect.TabIndex = 35
        '
        'LinkLabelDriveSelect
        '
        Me.LinkLabelDriveSelect.AutoSize = True
        Me.LinkLabelDriveSelect.Location = New System.Drawing.Point(54, 151)
        Me.LinkLabelDriveSelect.Name = "LinkLabelDriveSelect"
        Me.LinkLabelDriveSelect.Size = New System.Drawing.Size(65, 13)
        Me.LinkLabelDriveSelect.TabIndex = 36
        Me.LinkLabelDriveSelect.TabStop = True
        Me.LinkLabelDriveSelect.Text = "Drive Select"
        '
        'chkSaveLog
        '
        Me.chkSaveLog.AutoSize = True
        Me.chkSaveLog.Location = New System.Drawing.Point(205, 338)
        Me.chkSaveLog.Name = "chkSaveLog"
        Me.chkSaveLog.Size = New System.Drawing.Size(76, 17)
        Me.chkSaveLog.TabIndex = 37
        Me.chkSaveLog.Text = "Write LOG"
        Me.chkSaveLog.UseVisualStyleBackColor = True
        Me.chkSaveLog.Visible = False
        '
        'cmbEndTrack
        '
        Me.cmbEndTrack.FormattingEnabled = True
        Me.cmbEndTrack.Items.AddRange(New Object() {"79", "80", "81", "82", "83"})
        Me.cmbEndTrack.Location = New System.Drawing.Point(343, 148)
        Me.cmbEndTrack.Name = "cmbEndTrack"
        Me.cmbEndTrack.Size = New System.Drawing.Size(40, 21)
        Me.cmbEndTrack.TabIndex = 39
        '
        'chkEndTrack
        '
        Me.chkEndTrack.AutoSize = True
        Me.chkEndTrack.Location = New System.Drawing.Point(267, 150)
        Me.chkEndTrack.Name = "chkEndTrack"
        Me.chkEndTrack.Size = New System.Drawing.Size(76, 17)
        Me.chkEndTrack.TabIndex = 38
        Me.chkEndTrack.Text = "End Track"
        Me.chkEndTrack.UseVisualStyleBackColor = True
        '
        'chkSingleSided
        '
        Me.chkSingleSided.AutoSize = True
        Me.chkSingleSided.Location = New System.Drawing.Point(173, 150)
        Me.chkSingleSided.Name = "chkSingleSided"
        Me.chkSingleSided.Size = New System.Drawing.Size(79, 17)
        Me.chkSingleSided.TabIndex = 40
        Me.chkSingleSided.Text = "Single Side"
        Me.chkSingleSided.UseVisualStyleBackColor = True
        '
        'LinkLabelDLPython
        '
        Me.LinkLabelDLPython.AutoSize = True
        Me.LinkLabelDLPython.Location = New System.Drawing.Point(386, 292)
        Me.LinkLabelDLPython.Name = "LinkLabelDLPython"
        Me.LinkLabelDLPython.Size = New System.Drawing.Size(91, 13)
        Me.LinkLabelDLPython.TabIndex = 41
        Me.LinkLabelDLPython.TabStop = True
        Me.LinkLabelDLPython.Text = "Download Python"
        '
        'LinkLabelDLGW
        '
        Me.LinkLabelDLGW.AutoSize = True
        Me.LinkLabelDLGW.Location = New System.Drawing.Point(346, 243)
        Me.LinkLabelDLGW.Name = "LinkLabelDLGW"
        Me.LinkLabelDLGW.Size = New System.Drawing.Size(131, 13)
        Me.LinkLabelDLGW.TabIndex = 42
        Me.LinkLabelDLGW.TabStop = True
        Me.LinkLabelDLGW.Text = "Download Greeaseweazle"
        '
        'LinkLabelOpenLocation
        '
        Me.LinkLabelOpenLocation.AutoSize = True
        Me.LinkLabelOpenLocation.Location = New System.Drawing.Point(400, 192)
        Me.LinkLabelOpenLocation.Name = "LinkLabelOpenLocation"
        Me.LinkLabelOpenLocation.Size = New System.Drawing.Size(77, 13)
        Me.LinkLabelOpenLocation.TabIndex = 43
        Me.LinkLabelOpenLocation.TabStop = True
        Me.LinkLabelOpenLocation.Text = "Open Location"
        '
        'chkAdjustSpeed
        '
        Me.chkAdjustSpeed.AutoSize = True
        Me.chkAdjustSpeed.Checked = True
        Me.chkAdjustSpeed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAdjustSpeed.Location = New System.Drawing.Point(395, 150)
        Me.chkAdjustSpeed.Name = "chkAdjustSpeed"
        Me.chkAdjustSpeed.Size = New System.Drawing.Size(117, 17)
        Me.chkAdjustSpeed.TabIndex = 44
        Me.chkAdjustSpeed.Text = "Adjust Write Speed"
        Me.chkAdjustSpeed.UseVisualStyleBackColor = True
        '
        'btnSaveLocation
        '
        Me.btnSaveLocation.Location = New System.Drawing.Point(483, 208)
        Me.btnSaveLocation.Name = "btnSaveLocation"
        Me.btnSaveLocation.Size = New System.Drawing.Size(24, 20)
        Me.btnSaveLocation.TabIndex = 0
        Me.btnSaveLocation.Text = "..."
        Me.btnSaveLocation.UseVisualStyleBackColor = True
        '
        'lblSaveLocation
        '
        Me.lblSaveLocation.AutoSize = True
        Me.lblSaveLocation.Location = New System.Drawing.Point(9, 192)
        Me.lblSaveLocation.Name = "lblSaveLocation"
        Me.lblSaveLocation.Size = New System.Drawing.Size(76, 13)
        Me.lblSaveLocation.TabIndex = 2
        Me.lblSaveLocation.Text = "Save Location"
        '
        'txtSaveLocation
        '
        Me.txtSaveLocation.Location = New System.Drawing.Point(12, 208)
        Me.txtSaveLocation.Name = "txtSaveLocation"
        Me.txtSaveLocation.Size = New System.Drawing.Size(465, 20)
        Me.txtSaveLocation.TabIndex = 6
        '
        'txtExecuteScript
        '
        Me.txtExecuteScript.Location = New System.Drawing.Point(12, 355)
        Me.txtExecuteScript.Name = "txtExecuteScript"
        Me.txtExecuteScript.Size = New System.Drawing.Size(465, 20)
        Me.txtExecuteScript.TabIndex = 47
        '
        'lblExecuteScript
        '
        Me.lblExecuteScript.AutoSize = True
        Me.lblExecuteScript.Location = New System.Drawing.Point(9, 339)
        Me.lblExecuteScript.Name = "lblExecuteScript"
        Me.lblExecuteScript.Size = New System.Drawing.Size(102, 13)
        Me.lblExecuteScript.TabIndex = 46
        Me.lblExecuteScript.Text = "Execute Script/EXE"
        '
        'btnExecuteScript
        '
        Me.btnExecuteScript.Location = New System.Drawing.Point(483, 355)
        Me.btnExecuteScript.Name = "btnExecuteScript"
        Me.btnExecuteScript.Size = New System.Drawing.Size(24, 20)
        Me.btnExecuteScript.TabIndex = 45
        Me.btnExecuteScript.Text = "..."
        Me.btnExecuteScript.UseVisualStyleBackColor = True
        '
        'chkExecuteScript
        '
        Me.chkExecuteScript.AutoSize = True
        Me.chkExecuteScript.Location = New System.Drawing.Point(309, 338)
        Me.chkExecuteScript.Name = "chkExecuteScript"
        Me.chkExecuteScript.Size = New System.Drawing.Size(168, 17)
        Me.chkExecuteScript.TabIndex = 48
        Me.chkExecuteScript.Text = "Execute script after read/write"
        Me.chkExecuteScript.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 434)
        Me.Controls.Add(Me.chkExecuteScript)
        Me.Controls.Add(Me.txtExecuteScript)
        Me.Controls.Add(Me.lblExecuteScript)
        Me.Controls.Add(Me.btnExecuteScript)
        Me.Controls.Add(Me.chkAdjustSpeed)
        Me.Controls.Add(Me.LinkLabelOpenLocation)
        Me.Controls.Add(Me.LinkLabelDLGW)
        Me.Controls.Add(Me.LinkLabelDLPython)
        Me.Controls.Add(Me.chkSingleSided)
        Me.Controls.Add(Me.cmbEndTrack)
        Me.Controls.Add(Me.chkEndTrack)
        Me.Controls.Add(Me.chkSaveLog)
        Me.Controls.Add(Me.LinkLabelDriveSelect)
        Me.Controls.Add(Me.cmbDriveSelect)
        Me.Controls.Add(Me.chkF7)
        Me.Controls.Add(Me.LinkLabelGWWiki)
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
        Me.Controls.Add(Me.rtbOutput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSaveLocation)
        Me.Controls.Add(Me.cmbSerialPorts)
        Me.Controls.Add(Me.btnSaveLocation)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Run GreaseWeazle Script"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbSerialPorts As ComboBox
    Friend WithEvents Label2 As Label
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
End Class
