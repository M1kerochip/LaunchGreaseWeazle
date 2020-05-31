Public Class LogFileClass

    Private p_logfilename As String = ""

    Public Property LogFileName As String
        Get
            If p_logfilename <> "" Then
                Return p_logfilename
            Else
                p_logfilename = IO.Path.ChangeExtension(Application.ExecutablePath, ".log")
                Return p_logfilename
            End If
        End Get
        Set(value As String)
            p_logfilename = value
        End Set
    End Property

    Private Function LogFileExists() As Boolean
        If LogFileName <> "" Then
            If IO.File.Exists(LogFileName) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
        Return True
    End Function

    Public Function CreateLogFile() As Boolean
        If LogFileName <> "" Then
            Try
                Dim sw As IO.StreamWriter
                sw = IO.File.CreateText(LogFileName)
                sw.WriteLine(" Run Greaseweazle Log File")
                sw.WriteLine("-============================-")
                sw.WriteLine("")
                sw.WriteLine("Create on " + DateTime.Today.ToString("yyyy-MM-dd") + " at " + DateTime.Now.ToString("HH:mm:ss"))
                sw.WriteLine("")
                sw.Flush()
                sw.Close()
                Return True
            Catch ex As Exception
                Return False
            End Try
        Else
            Return False
        End If
        Return True
    End Function

    Private Function AppendToLog(ByVal StringToWrite As String) As Boolean
        Try
            Dim sw As IO.StreamWriter
            sw = IO.File.AppendText(LogFileName)
            sw.WriteLine(StringToWrite)
            sw.Flush()
            sw.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function WriteToLog(ByVal StringToWrite As String) As Boolean
        If LogFileName <> "" Then
            If LogFileExists() = True Then
                If AppendToLog(StringToWrite) = True Then
                    Return True
                Else
                    Return False
                End If
            Else
                If CreateLogFile() = True Then
                    AppendToLog(StringToWrite)
                    Return True
                Else
                    Return False
                End If
            End If
        Else
            Return False
        End If
        Return True
    End Function

    Private Function AppendToLog(ByVal StringsToWrite As String()) As Boolean
        Try
            IO.File.AppendAllLines(LogFileName, StringsToWrite)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function WriteToLog(ByVal StringsToWrite As String()) As Boolean
        If LogFileName <> "" Then
            If LogFileExists() = True Then
                If AppendToLog(StringsToWrite) = True Then
                    Return True
                Else
                    Return False
                End If
            Else
                If CreateLogFile() = True Then
                    AppendToLog(StringsToWrite)
                    Return True
                Else
                    Return False
                End If
            End If
        Else
            Return False
        End If
        Return True
    End Function
End Class
