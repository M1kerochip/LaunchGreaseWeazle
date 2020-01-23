Imports System.ComponentModel

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

        cmbSystem.Text = My.Settings.System
        txtTitle.Text = My.Settings.Title
        txtPublisher.Text = My.Settings.Company
        txtExecuteScript.Text = My.Settings.Script

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
        My.Settings.Save()
    End Sub

    Function CreateFileName() As String
        Dim filen As String
        filen = txtTitle.Text.Trim + "_" + txtPublisher.Text.Trim + "_"

        If cmbDisk.Text.Trim <> "" Then
            filen = filen + "Disk" + cmbDisk.Text.Trim
        End If
        If cmbDiskOf.Text.Trim <> "" Then
            filen = filen + "of" + cmbDiskOf.Text.Trim + "_"
        End If
        If cmbDiskRevision.Text.Trim <> "" Then
            filen = filen + "Rev_" + cmbDiskRevision.Text.Trim + "_"
        End If
        If cmbSystem.Text.Trim <> "" Then
            filen = filen + cmbSystem.Text.Trim + "_"
        End If
        If cmbDump.Text.Trim <> "" Then
            filen = filen + "Dump" + cmbDump.Text.Trim
        End If
        filen = filen + ".scp"
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
                    errstr &= "Save directory does not exist!" + Environment.NewLine
                End If
            End If
            If Not IO.File.Exists(txtGWLocation.Text.Trim) Then
                errstr &= "Greaseweazel script not found!" + Environment.NewLine
            End If
            If Not IO.File.Exists(txtPythonLocation.Text.Trim) Then
                errstr &= "Python.exe not found!" + Environment.NewLine
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

    Private Function CallGreaseWeazel(ByVal PythonEXE As String, ByVal gwLoc As String, ByVal ReadFromGW As Boolean, ByVal fName As String, ByVal ComPort As String) As Boolean
        Dim CMD As New Process

        Dim SW As System.IO.StreamWriter

        Dim SR As System.IO.StreamReader

        CMD.StartInfo.FileName = PythonEXE

        Dim str As String = gwLoc

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

        If chkRevolutions.Checked Then
            str = str + "--revs=" + cmbRevolutions.Text + " "
        End If

        If chkF7.Checked Then
            str = str + "--drive " + cmbDriveSelect.Text
        End If
        str = str + fName + " " + ComPort


        CMD.StartInfo.Arguments = str

        CMD.StartInfo.UseShellExecute = False

        CMD.StartInfo.RedirectStandardInput = True

        CMD.StartInfo.RedirectStandardOutput = True

        CMD.StartInfo.CreateNoWindow = True

        CMD.Start()

        SW = CMD.StandardInput

        SR = CMD.StandardOutput

        CMD.Dispose()

        SW.Dispose()

        Do Until SR.EndOfStream = True

            rtbOutput.Text &= SR.ReadLine

            rtbOutput.Text &= Environment.NewLine

        Loop

        SR.Dispose()

        If chkExecuteScript.Checked Then
            If txtExecuteScript.Text.Trim <> "" Then
                System.Diagnostics.Process.Start(txtExecuteScript.Text.Trim, fName)
            End If
        End If

        If chkSaveLog.Checked = True Then
            Dim StreamWriter As New IO.StreamWriter(fName + ".log")
            StreamWriter.Write(rtbOutput.Text)
            StreamWriter.Close()
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
            If chkLoop.Checked Then
                Dim loopc As Integer
                For loopc = 0 To CInt(cmbDump.Text)
                    cmbDump.Text = CStr(loopc)
                    Dim fileGW As String = CreateFileName()
                    rtbOutput.Clear()
                    rtbOutput.Text &= "Reading from Greaseweazel on " + cmbSerialPorts.Text
                    rtbOutput.Text &= Environment.NewLine
                    rtbOutput.Text &= "to file: " + fileGW
                    rtbOutput.Text &= Environment.NewLine + Environment.NewLine
                    CallGreaseWeazel(txtPythonLocation.Text, txtGWLocation.Text, True, txtSaveLocation.Text + fileGW, cmbSerialPorts.Text)
                Next
            Else
                Dim fileGW As String = CreateFileName()
                rtbOutput.Clear()
                rtbOutput.Text &= "Reading from Greaseweazel on " + cmbSerialPorts.Text
                rtbOutput.Text &= Environment.NewLine
                rtbOutput.Text &= "to file: " + fileGW
                rtbOutput.Text &= Environment.NewLine + Environment.NewLine
                CallGreaseWeazel(txtPythonLocation.Text, txtGWLocation.Text, True, txtSaveLocation.Text + fileGW, cmbSerialPorts.Text)
            End If
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

        If (OpenFileDialogMain.ShowDialog() = DialogResult.OK) Then
            txtGWLocation.Text = OpenFileDialogMain.FileName
        End If
    End Sub

    Private Sub BtnPythonLocation_Click(sender As Object, e As EventArgs) Handles btnPythonLocation.Click
        OpenFileDialogMain.Title = "Select 'python.exe' in Python Directory"
        OpenFileDialogMain.Multiselect = False
        OpenFileDialogMain.FileName = "python.exe"

        If (OpenFileDialogMain.ShowDialog() = DialogResult.OK) Then
            txtPythonLocation.Text = OpenFileDialogMain.FileName
        End If
    End Sub

    Private Sub BtnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        If CheckForErrors() = False
            OpenFileDialogMain.Title = "Select SuperCard Pro file to write to floppy"
            OpenFileDialogMain.Multiselect = False
            OpenFileDialogMain.FileName = ""
            Dim fileGW As String
            If (OpenFileDialogMain.ShowDialog() = DialogResult.OK) Then
                fileGW = OpenFileDialogMain.FileName
                rtbOutput.Clear()
                rtbOutput.Text &= "Writing to Greaseweazel on " + cmbSerialPorts.Text
                rtbOutput.Text &= Environment.NewLine
                rtbOutput.Text &= "using: " + fileGW
                rtbOutput.Text &= Environment.NewLine + Environment.NewLine
                CallGreaseWeazel(txtPythonLocation.Text, txtGWLocation.Text, False, fileGW, cmbSerialPorts.Text)
            Else

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

        If (OpenFileDialogMain.ShowDialog() = DialogResult.OK) Then
            txtExecuteScript.Text = OpenFileDialogMain.FileName
        End If
    End Sub

    Private Sub LinkLabelLaunchNow_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelLaunchNow.LinkClicked
        System.Diagnostics.Process.Start(txtExecuteScript.Text.Trim, txtSaveLocation.Text.Trim + CreateFileName())
    End Sub

    Private Sub ChkStartCyl_CheckedChanged(sender As Object, e As EventArgs) Handles ChkStartTrack.CheckedChanged
        cmbStartTrack.Enabled = ChkStartTrack.Checked
    End Sub

    Private Sub ChkSaveLog_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveLog.CheckedChanged

    End Sub
End Class
