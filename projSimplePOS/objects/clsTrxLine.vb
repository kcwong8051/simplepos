Imports System.Data.OleDb
Public Class clsTrxHeader
    Private filename As String
    Public Property trxid As String
    Public Property trxdt As String
    Public Property trxdt2 As DateTime
    Public Property children As Integer
    Public Property totalAmt As Decimal
    Public Property lstTrxLine As List(Of clsTrxLine)

    Private strConn As String

    Private objLog As clsLog

    Sub New()
        objLog = New clsLog
        If trxdt = String.Empty Then
            trxdt2 = DateTime.Now
            Dim format_1 As String = "yyyy/MM/dd HH:mm:ss"
            trxdt = trxdt2.ToString(format_1)
            filename = "Trx" & trxdt2.ToString("yyMMdd") & ".xls"
        End If
        If trxid = String.Empty Then
            Dim format_2 As String = "yyMMddHHmmss"
            trxid = "TX" & trxdt2.ToString(format_2)
        End If
        children = 0
        totalAmt = 0
        lstTrxLine = New List(Of clsTrxLine)
        strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" &
        "Data Source=" & System.Environment.CurrentDirectory & "\excelfiles\" & filename & ";" &
        "Extended Properties='Excel 8.0;HDR=Yes';"
    End Sub

    Public Function SaveIt()
        If CreateDailyTrxExcel() = False Then
            Return False
        End If
        If insertExcel() = False Then
            Return False
        End If
        Return True
    End Function

    'This function for testing of creating a excel file
    Private Sub CreateExcelTest()
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkbook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorksheet As Microsoft.Office.Interop.Excel.Worksheet
        Try
            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkbook = xlApp.Workbooks.Add()
            'sheets is one-based
            xlWorksheet = CType(xlWorkbook.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)
            xlWorksheet.Name = "Test1"
            xlWorksheet.Cells(1, 1) = "data in first cell"
            Dim svfileName As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & "Test.xls"
            xlWorksheet.SaveAs(svfileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing)
            xlWorkbook.Close()
            xlApp.Quit()
        Catch ex As Exception
            Dim err As String = "clsTrxHeader.CreateExcelTest" & vbCrLf & ex.Message
            objLog.Log2Text(err, 1)
            Diagnostics.Debug.WriteLine(err)
        Finally
            xlApp = Nothing
            xlWorkbook = Nothing
            xlWorksheet = Nothing
        End Try

    End Sub

    Private Function CreateDailyTrxExcel() As Boolean
        Dim pathOfFileToCreate As String = System.Environment.CurrentDirectory & "\excelfiles\" & filename
        If IO.File.Exists(pathOfFileToCreate) = True Then
            Return True
        End If
        Dim isCreated As Boolean = False
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkbook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorksheet1, xlWorksheet2 As Microsoft.Office.Interop.Excel.Worksheet
        Try
            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkbook = xlApp.Workbooks.Add()
            'sheets is one-based
            xlWorksheet1 = CType(xlWorkbook.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)
            xlWorksheet1.Name = "TrxLine"
            xlWorksheet1.Cells(1, 1) = "trxid"
            xlWorksheet1.Cells(1, 2) = "lineno"
            xlWorksheet1.Cells(1, 3) = "inputbarcode"
            xlWorksheet1.Cells(1, 4) = "itemno"
            xlWorksheet1.Cells(1, 5) = "itemdesc"
            xlWorksheet1.Cells(1, 6) = "inputqty"
            xlWorksheet1.Cells(1, 7) = "subtotal"
            'xlWorksheet1.SaveAs(pathOfFileToCreate, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing)
            xlWorksheet2 = xlWorkbook.Worksheets.Add 'CType(xlWorkbook.Sheets(2), Microsoft.Office.Interop.Excel.Worksheet)
            xlWorksheet2.Name = "TrxHeader"
            xlWorksheet2.Cells(1, 1) = "trxid"
            xlWorksheet2.Cells(1, 2) = "trxdt"
            xlWorksheet2.Cells(1, 3) = "children"
            xlWorksheet2.Cells(1, 4) = "totalAmt"
            xlWorksheet2.SaveAs(pathOfFileToCreate, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing)
            xlWorkbook.Close()
            xlApp.Quit()
            isCreated = True
        Catch ex As Exception
            Dim err As String = "clsTrxHeader.CreateDailyTrxExcel: " & vbCrLf & ex.Message
            Diagnostics.Debug.WriteLine(err)
            objLog.Log2Text(err, 1)
            isCreated = False
        Finally
            xlApp = Nothing
            xlWorkbook = Nothing
            xlWorksheet1 = Nothing
            xlWorksheet2 = Nothing
        End Try
        Return isCreated
    End Function

    Private Function insertExcel() As Boolean
        Dim pathOfFileToCreate As String = System.Environment.CurrentDirectory & "\excelfiles\" & filename
        If IO.File.Exists(pathOfFileToCreate) = False Then
            Return False
        End If
        Dim isInserted As Boolean = False
        Dim conn As System.Data.OleDb.OleDbConnection = New System.Data.OleDb.OleDbConnection()
        conn.ConnectionString = strConn
        'write data in EXCEL sheet (Insert data)
        Dim trx_1 As OleDbTransaction = Nothing
        Dim cmd As OleDbCommand
        Try
            conn.Open()
            trx_1 = conn.BeginTransaction
            Dim sqlHeader As String =
                "Insert into [TrxHeader$] (trxid,trxdt,children,totalAmt) VALUES " &
                    String.Format("('{0}','{1}',{2},{3});", trxid, trxdt, children, totalAmt)
            cmd = New OleDbCommand(sqlHeader, conn, trx_1)
            cmd.ExecuteNonQuery()
            For Each objLine As clsTrxLine In lstTrxLine
                Dim sqlLine As String =
                    "Insert into [TrxLine$] (trxid,lineno,inputbarcode,itemno,itemdesc,inputqty,subtotal) VALUES " &
                        String.Format("('{0}',{1},'{2}','{3}','{4}',{5},{6});",
                            trxid, objLine.lineno, objLine.inputbarcode, objLine.itemno, objLine.itemdesc, objLine.inputqty, objLine.subtotal)
                cmd = New OleDbCommand(sqlLine, conn, trx_1)
                cmd.ExecuteNonQuery()
            Next
            trx_1.Commit()
            isInserted = True
        Catch ex As Exception
            Dim err As String = "clsTrxHeader.insertExcel:" & vbCrLf & ex.Message
            Diagnostics.Debug.WriteLine(err)
            objLog.Log2Text(err, 1)
            isInserted = False
            trx_1.Rollback()
        Finally
            conn.Close()
            conn.Dispose()
        End Try
        Return isInserted
    End Function

    Private Function CreateExcel()
        Dim pathOfFileToCreate As String = System.Environment.CurrentDirectory & "\excelfiles\" & filename
        If IO.File.Exists(pathOfFileToCreate) = True Then
            Return True
        End If
        Dim isCreated As Boolean = False
        Dim conn As System.Data.OleDb.OleDbConnection = New System.Data.OleDb.OleDbConnection()
        Try
            conn.ConnectionString = strConn
            conn.Open()
            Dim cmd As System.Data.OleDb.OleDbCommand = conn.CreateCommand
            'Create Sheet With Name Sheet1
            cmd.CommandText = "CREATE TABLE trxheader (trxid NVARCHAR(14), trxdt NVARCHAR(19), children INTEGER, amount DECIMAL)"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "CREATE TABLE trxline (trxid NVARCHAR(14), lineno INTEGER, inputbarcode NVARCHAR(20), itemno NVARCHAR(6), " &
                    "itemdesc NVARCHAR(100), inputqty INTEGER, subtotal DECIMAL)"
            cmd.ExecuteNonQuery()
            isCreated = True
        Catch ex As Exception
            Dim err As String = "clsTrxHeader.CreateExcel:" & vbCrLf & ex.Message
            Diagnostics.Debug.WriteLine(err)
            objLog.Log2Text(err, 1)
            isCreated = False
        Finally
            If (conn.State = ConnectionState.Open) Then
                conn.Close()
            End If
        End Try
        Return isCreated
    End Function

End Class

Public Class clsTrxLine
    Public Property trxid As String
    Public Property lineno As Integer
    Public Property inputbarcode As String
    Public Property itemno As String
    Public Property itemdesc As String
    Public Property inputqty As Integer
    Public Property subtotal As Decimal

    Sub New(mapLine As Dictionary(Of String, String))
        If mapLine.ContainsKey("trxid") Then
            mapLine.TryGetValue("trxid", trxid)
        End If
        If mapLine.ContainsKey("lineno") Then
            Dim lineno_1 As String = ""
            mapLine.TryGetValue("lineno", lineno_1)
            lineno = CType(lineno_1, Integer)
        End If
        If mapLine.ContainsKey("inputbarcode") Then
            mapLine.TryGetValue("inputbarcode", inputbarcode)
        End If
        If mapLine.ContainsKey("itemno") Then
            mapLine.TryGetValue("itemno", itemno)
        End If
        If mapLine.ContainsKey("itemdesc") Then
            mapLine.TryGetValue("itemdesc", itemdesc)
        End If
        If mapLine.ContainsKey("inputqty") Then
            Dim inputqty_1 As String = ""
            mapLine.TryGetValue("inputqty", inputqty_1)
            inputqty = CType(inputqty_1, Integer)
        End If
        If mapLine.ContainsKey("subtotal") Then
            Dim subtotal_1 As String = ""
            mapLine.TryGetValue("subtotal", subtotal_1)
            subtotal = CType(subtotal_1, Decimal)
        End If

    End Sub

End Class
