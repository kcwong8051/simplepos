Public Class clsLog
    Sub New()

        If IO.Directory.Exists("C:\Temp") = False Then
            Try
                IO.Directory.CreateDirectory("C:\Temp")
            Catch ex As Exception
                Return
            End Try
        End If
        If IO.Directory.Exists("C:\Temp\projSimplePOS_Log") = False Then
            Try
                IO.Directory.CreateDirectory("C:\Temp\projSimplePOS_Log")
            Catch ex As Exception
                Return
            End Try
        End If
    End Sub

    Private Function datetimeInString() As String
        Dim dttime As DateTime = DateTime.Now
        Dim strformat As String = "yyMMddHHmmdd"
        Return dttime.ToString(strformat)
    End Function

    Public Sub Log2Text(ByVal str As String, ByVal intType As Integer)
        Dim objSB As New System.Text.StringBuilder
        objSB.AppendLine(str)
        Dim logfile As String
        Select Case intType
            Case 0
                logfile = "Log_" & datetimeInString() & ".txt"
                Console.WriteLine("Log" & vbCrLf & str)
            Case 1
                logfile = "Err_" & datetimeInString() & ".txt"
                Console.WriteLine("Error" & vbCrLf & str)
            Case 2
                logfile = "Warn_" & datetimeInString() & ".txt"
                Console.WriteLine("Warning" & vbCrLf & str)
            Case 3
                logfile = "Msg_" & datetimeInString() & ".txt"
                Console.WriteLine("Message" & vbCrLf & str)
            Case 4
                logfile = "Debug_" & datetimeInString() & ".txt"
                Console.WriteLine("Debug" & vbCrLf & str)
            Case 5
                logfile = "Cir_" & datetimeInString() & ".txt"
                Console.WriteLine("Circular" & vbCrLf & str)
            Case Else
                logfile = "Unknown_" & datetimeInString() & ".txt"
                Console.WriteLine("Unknown" & vbCrLf & str)
        End Select
        If IO.File.Exists("C:\Temp\projSimplePOS_Log\" & logfile) = False Then
            IO.File.Create("C:\Temp\projSimplePOS_Log\" & logfile).Dispose()
        End If
        System.IO.File.AppendAllText("C:\Temp\projSimplePOS_Log\" & logfile, objSB.ToString)
    End Sub
End Class
