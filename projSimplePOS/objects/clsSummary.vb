Imports System.Data.OleDb
Public Class clsSummary

    Private queryDate As String
    Private filename As String
    Private strConn As String
    Private objLog As clsLog

    Public Property queryDate2 As DateTime
        Get
            If queryDate = String.Empty Or queryDate.Length <> 10 Then
                Return New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0)
            End If
            Return New DateTime(queryDate.Substring(0, 4), queryDate.Substring(5, 2), queryDate.Substring(8, 2), 0, 0, 0)
        End Get
        Set(value As DateTime)
            queryDate = value.ToString("yyyy/MM/dd")
            filename = "Trx" & value.ToString("yyMMdd") & ".xls"
            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" &
                "Data Source=" & System.Environment.CurrentDirectory & "\excelfiles\" & filename & ";" &
                "Extended Properties='Excel 8.0;HDR=Yes;IMEX=1';"
        End Set
    End Property

    Sub New()
        objLog = New clsLog
        filename = ""
        queryDate = ""
        strConn = ""
    End Sub

    Public Function querySummary() As Dictionary(Of String, String)
        If filename = "" OrElse queryDate = "" OrElse strConn = "" Then
            Return Nothing
        End If
        Dim pathOfFileToCreate As String = System.Environment.CurrentDirectory & "\excelfiles\" & filename
        If IO.File.Exists(pathOfFileToCreate) = False Then
            Return Nothing
        End If
        Dim numoftrx As Integer = getTrxCount()
        Dim numofitemsold As Integer = getItemCount()
        Dim sumofamt As Decimal = getSumAmt()
        Return New Dictionary(Of String, String) From
            {{"numoftrx", numoftrx.ToString()},
             {"numofitemsold", numofitemsold.ToString()},
             {"sumofamt", sumofamt.ToString("0.00")}}
    End Function

    Private Function getTrxCount() As Integer
        'this function load master data into dgvItem and 2 maps
        'Connect EXCEL sheet with OLEDB using connection string
        Using conn = New OleDbConnection
            Try
                conn.ConnectionString = strConn
                conn.Open()
                Dim cmd As OleDbCommand = New OleDbCommand("select Count(*) from [TrxHeader$] where trxid<>null;", conn)
                Dim intCount As Integer = cmd.ExecuteScalar
                Return intCount
            Catch ex As Exception
                Dim err As String = "clsSummary.getTrxCount:" & vbCrLf & ex.Message
                Diagnostics.Debug.WriteLine(err)
                objLog.Log2Text(err, 1)
                Return -1
            End Try
        End Using
    End Function
    Private Function getItemCount() As Integer
        'this function load master data into dgvItem and 2 maps
        'Connect EXCEL sheet with OLEDB using connection string
        Using conn = New OleDbConnection
            Try
                conn.ConnectionString = strConn
                conn.Open()
                Dim cmd As OleDbCommand = New OleDbCommand("select Sum(children) from [TrxHeader$] where trxid<>null;", conn)
                Dim intCount As Integer = cmd.ExecuteScalar
                Return intCount
            Catch ex As Exception
                Dim err As String = "clsSummary.getItemCount:" & vbCrLf & ex.Message
                Diagnostics.Debug.WriteLine(err)
                objLog.Log2Text(err, 1)
                Return -1
            End Try
        End Using
    End Function
    Private Function getSumAmt() As Decimal
        'this function load master data into dgvItem and 2 maps
        'Connect EXCEL sheet with OLEDB using connection string
        Using conn = New OleDbConnection
            Try
                conn.ConnectionString = strConn
                conn.Open()
                Dim cmd As OleDbCommand = New OleDbCommand("select Sum(totalAmt) from [TrxHeader$] where trxid<>null;", conn)
                Dim intCount As Integer = cmd.ExecuteScalar
                Return intCount
            Catch ex As Exception
                Dim err As String = "clsSummary.getSumAmt:" & vbCrLf & ex.Message
                Diagnostics.Debug.WriteLine(err)
                objLog.Log2Text(err, 1)
                Return -1
            End Try
        End Using
    End Function

End Class
