Imports System.Data.OleDb
Public Class clsItems
    Public Property mapBarcode As Dictionary(Of String, clsItem)
    Public Property mapItem As Dictionary(Of String, clsItem)

    Private strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;" &
        "Data Source=" & System.Environment.CurrentDirectory & "\excelfiles\itemmaster.xls;" &
        "Extended Properties='Excel 8.0;HDR=Yes;IMEX=1';"

    Private objLog As clsLog

    Sub New()
        objLog = New clsLog
        If mapItem Is Nothing Then
            mapItem = New Dictionary(Of String, clsItem)
        Else
            mapItem.Clear()
        End If
        If mapBarcode Is Nothing Then
            mapBarcode = New Dictionary(Of String, clsItem)
        Else
            mapBarcode.Clear()
        End If
    End Sub

    Public Function loadItem() As Boolean
        'this function load master data into dgvItem and 2 maps
        'Connect EXCEL sheet with OLEDB using connection string
        Using conn = New OleDbConnection
            Try
                conn.ConnectionString = strConn
                conn.Open()
                Dim objDA As OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("select * from [item$] where barcode<>null;", conn)
                Dim excelDataSet As DataSet = New DataSet()
                objDA.Fill(excelDataSet)
                Form1.dgvItem.DataSource = excelDataSet.Tables(0)
                Form1.dgvItem.Columns(0).HeaderText = "條碼"
                Form1.dgvItem.Columns(0).Width = 150
                Form1.dgvItem.Columns(1).HeaderText = "貨號"
                Form1.dgvItem.Columns(1).Width = 150
                Form1.dgvItem.Columns(2).HeaderText = "貨名"
                Form1.dgvItem.Columns(2).Width = 300
                Form1.dgvItem.Columns(3).HeaderText = "價格"
                Form1.dgvItem.Columns(3).Width = 100
                For Each dr As DataRow In excelDataSet.Tables(0).Rows
                    If mapItem.ContainsKey(dr(0)) = False Then
                        mapItem.Add(dr(0), New clsItem(dr(0), dr(1), dr(2), dr(3)))
                    End If
                    If mapBarcode.ContainsKey(dr(1)) = False Then
                        mapBarcode.Add(dr(1), New clsItem(dr(0), dr(1), dr(2), dr(3)))
                    End If
                Next
            Catch ex As Exception
                Dim err As String = "clsItem.loadItem:" & vbCrLf & ex.Message
                Diagnostics.Debug.WriteLine(err)
                objLog.Log2Text(err, 1)
                Return False
            End Try

        End Using
        Return True
    End Function
End Class
Public Class clsItem
    Public Property barcode As String
    Public Property itemnum As String
    Public Property itemdesc As String
    Public Property price As Decimal

    Sub New(i_bcode As String, i_item As String, i_desc As String, i_prc As Decimal)
        barcode = i_bcode
        itemnum = i_item
        itemdesc = i_desc
        price = i_prc
    End Sub

    Public Function getSubTotal(i_qty As Integer) As Decimal
        Return price * i_qty
    End Function

End Class
