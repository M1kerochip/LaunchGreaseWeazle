﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property SaveLoc() As String
            Get
                Return CType(Me("SaveLoc"),String)
            End Get
            Set
                Me("SaveLoc") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property GWExe() As String
            Get
                Return CType(Me("GWExe"),String)
            End Get
            Set
                Me("GWExe") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Title() As String
            Get
                Return CType(Me("Title"),String)
            End Get
            Set
                Me("Title") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Company() As String
            Get
                Return CType(Me("Company"),String)
            End Get
            Set
                Me("Company") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property System() As String
            Get
                Return CType(Me("System"),String)
            End Get
            Set
                Me("System") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property COM() As String
            Get
                Return CType(Me("COM"),String)
            End Get
            Set
                Me("COM") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("A")>  _
        Public Property Drive() As String
            Get
                Return CType(Me("Drive"),String)
            End Get
            Set
                Me("Drive") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property F7() As Boolean
            Get
                Return CType(Me("F7"),Boolean)
            End Get
            Set
                Me("F7") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Script() As String
            Get
                Return CType(Me("Script"),String)
            End Get
            Set
                Me("Script") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Disk() As String
            Get
                Return CType(Me("Disk"),String)
            End Get
            Set
                Me("Disk") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property DiskOf() As String
            Get
                Return CType(Me("DiskOf"),String)
            End Get
            Set
                Me("DiskOf") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Rev() As String
            Get
                Return CType(Me("Rev"),String)
            End Get
            Set
                Me("Rev") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Multi() As String
            Get
                Return CType(Me("Multi"),String)
            End Get
            Set
                Me("Multi") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property LoopDump() As Boolean
            Get
                Return CType(Me("LoopDump"),Boolean)
            End Get
            Set
                Me("LoopDump") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ExecuteScript() As Boolean
            Get
                Return CType(Me("ExecuteScript"),Boolean)
            End Get
            Set
                Me("ExecuteScript") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property LoopDumpCount() As String
            Get
                Return CType(Me("LoopDumpCount"),String)
            End Get
            Set
                Me("LoopDumpCount") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property WideForm() As Boolean
            Get
                Return CType(Me("WideForm"),Boolean)
            End Get
            Set
                Me("WideForm") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property StartTrack() As Boolean
            Get
                Return CType(Me("StartTrack"),Boolean)
            End Get
            Set
                Me("StartTrack") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property StartTrackNo() As Integer
            Get
                Return CType(Me("StartTrackNo"),Integer)
            End Get
            Set
                Me("StartTrackNo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property EndTrack() As Boolean
            Get
                Return CType(Me("EndTrack"),Boolean)
            End Get
            Set
                Me("EndTrack") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("79")>  _
        Public Property EndTrackNo() As Integer
            Get
                Return CType(Me("EndTrackNo"),Integer)
            End Get
            Set
                Me("EndTrackNo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property AdjustWriteSpeed() As Boolean
            Get
                Return CType(Me("AdjustWriteSpeed"),Boolean)
            End Get
            Set
                Me("AdjustWriteSpeed") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("250")>  _
        Public Property DataRate() As String
            Get
                Return CType(Me("DataRate"),String)
            End Get
            Set
                Me("DataRate") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property IncludeDataRate() As Boolean
            Get
                Return CType(Me("IncludeDataRate"),Boolean)
            End Get
            Set
                Me("IncludeDataRate") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300")>  _
        Public Property RPM() As String
            Get
                Return CType(Me("RPM"),String)
            End Get
            Set
                Me("RPM") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property IncludeRPM() As Boolean
            Get
                Return CType(Me("IncludeRPM"),Boolean)
            End Get
            Set
                Me("IncludeRPM") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property RunningLog() As Boolean
            Get
                Return CType(Me("RunningLog"),Boolean)
            End Get
            Set
                Me("RunningLog") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property UpdateSettings() As Boolean
            Get
                Return CType(Me("UpdateSettings"),Boolean)
            End Get
            Set
                Me("UpdateSettings") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property EraseEmpty() As Boolean
            Get
                Return CType(Me("EraseEmpty"),Boolean)
            End Get
            Set
                Me("EraseEmpty") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property SeekA() As Integer
            Get
                Return CType(Me("SeekA"),Integer)
            End Get
            Set
                Me("SeekA") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("83")>  _
        Public Property SeekB() As Integer
            Get
                Return CType(Me("SeekB"),Integer)
            End Get
            Set
                Me("SeekB") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0-1")>  _
        Public Property Sides() As String
            Get
                Return CType(Me("Sides"),String)
            End Get
            Set
                Me("Sides") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property Stepping() As Integer
            Get
                Return CType(Me("Stepping"),Integer)
            End Get
            Set
                Me("Stepping") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SeparateFolders() As Boolean
            Get
                Return CType(Me("SeparateFolders"),Boolean)
            End Get
            Set
                Me("SeparateFolders") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property PythonExe() As String
            Get
                Return CType(Me("PythonExe"),String)
            End Get
            Set
                Me("PythonExe") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UsePython() As Boolean
            Get
                Return CType(Me("UsePython"),Boolean)
            End Get
            Set
                Me("UsePython") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UseWritePreCompensate() As Boolean
            Get
                Return CType(Me("UseWritePreCompensate"),Boolean)
            End Get
            Set
                Me("UseWritePreCompensate") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("mfm")>  _
        Public Property WPCType() As String
            Get
                Return CType(Me("WPCType"),String)
            End Get
            Set
                Me("WPCType") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("40")>  _
        Public Property WPCTracks() As String
            Get
                Return CType(Me("WPCTracks"),String)
            End Get
            Set
                Me("WPCTracks") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute(">=")>  _
        Public Property WPCTrackRange() As String
            Get
                Return CType(Me("WPCTrackRange"),String)
            End Get
            Set
                Me("WPCTrackRange") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("125")>  _
        Public Property WPCTrackWidth() As String
            Get
                Return CType(Me("WPCTrackWidth"),String)
            End Get
            Set
                Me("WPCTrackWidth") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property HeadOffsetEnable() As Boolean
            Get
                Return CType(Me("HeadOffsetEnable"),Boolean)
            End Get
            Set
                Me("HeadOffsetEnable") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("-8")>  _
        Public Property HeadOffsetTrackCount() As Integer
            Get
                Return CType(Me("HeadOffsetTrackCount"),Integer)
            End Get
            Set
                Me("HeadOffsetTrackCount") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property DarkTheme() As Boolean
            Get
                Return CType(Me("DarkTheme"),Boolean)
            End Get
            Set
                Me("DarkTheme") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3")>  _
        Public Property Retries() As Integer
            Get
                Return CType(Me("Retries"),Integer)
            End Get
            Set
                Me("Retries") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property EnableRetries() As Boolean
            Get
                Return CType(Me("EnableRetries"),Boolean)
            End Get
            Set
                Me("EnableRetries") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("100")>  _
        Public Property CleanTimeMS() As Integer
            Get
                Return CType(Me("CleanTimeMS"),Integer)
            End Get
            Set
                Me("CleanTimeMS") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property EnableCleanTimeMS() As Boolean
            Get
                Return CType(Me("EnableCleanTimeMS"),Boolean)
            End Get
            Set
                Me("EnableCleanTimeMS") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3")>  _
        Public Property CleanPasses() As Integer
            Get
                Return CType(Me("CleanPasses"),Integer)
            End Get
            Set
                Me("CleanPasses") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property EnableCleanPasses() As Boolean
            Get
                Return CType(Me("EnableCleanPasses"),Boolean)
            End Get
            Set
                Me("EnableCleanPasses") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ShowTime() As Boolean
            Get
                Return CType(Me("ShowTime"),Boolean)
            End Get
            Set
                Me("ShowTime") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property Manufacturer() As Integer
            Get
                Return CType(Me("Manufacturer"),Integer)
            End Get
            Set
                Me("Manufacturer") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
        Public Property DiskType() As Integer
            Get
                Return CType(Me("DiskType"),Integer)
            End Get
            Set
                Me("DiskType") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SetManDisktype() As Boolean
            Get
                Return CType(Me("SetManDisktype"),Boolean)
            End Get
            Set
                Me("SetManDisktype") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ExtremeSeek() As Boolean
            Get
                Return CType(Me("ExtremeSeek"),Boolean)
            End Get
            Set
                Me("ExtremeSeek") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property DisableWriteVerify() As Boolean
            Get
                Return CType(Me("DisableWriteVerify"),Boolean)
            End Get
            Set
                Me("DisableWriteVerify") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SeekWithMotorOn() As Boolean
            Get
                Return CType(Me("SeekWithMotorOn"),Boolean)
            End Get
            Set
                Me("SeekWithMotorOn") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property HeadOffsetHead() As Integer
            Get
                Return CType(Me("HeadOffsetHead"),Integer)
            End Get
            Set
                Me("HeadOffsetHead") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.RunGreaseWeazel.My.MySettings
            Get
                Return Global.RunGreaseWeazel.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
