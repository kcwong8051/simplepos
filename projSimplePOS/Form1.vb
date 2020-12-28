Public Class Form1

    Dim objItems As New clsItems
    Dim objTrx As clsTrxHeader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "簡易收銀系統"
        Me.dgvTrxLine.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        objItems.loadItem()
        If TabControl1.SelectedIndex = 0 Then
            Me.txtInput.Text = ""
            Me.txtInput.Select()
        End If
        lblAmount.Text = "0.00"
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

    End Sub

    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar <> ChrW(Keys.Enter) Then
            Return
        End If
        txtInput.SelectionStart = 0
        txtInput.SelectionLength = txtInput.Text.Length
        txtInput.SelectAll()
        'MessageBox.Show("Enter key")

        Dim objFound As clsItem = Nothing
        If objItems.mapBarcode.ContainsKey(txtInput.Text) Then
            objItems.mapBarcode.TryGetValue(txtInput.Text, objFound)
        End If
        If objFound Is Nothing AndAlso objItems.mapItem.ContainsKey(txtInput.Text) Then
            objItems.mapItem.TryGetValue(txtInput.Text, objFound)
        End If
        Dim NumOfRowBeforeAdd As Integer = Me.dgvTrxLine.Rows.Count
        If objFound IsNot Nothing Then
            Dim datarow_1 As DSTrx.dtTransactionRow
            datarow_1 = DsTrx1.dtTransaction.NewRow
            datarow_1.Barcode = objFound.barcode
            datarow_1.ItemNum = objFound.itemnum
            datarow_1.LineNum = NumOfRowBeforeAdd + 1
            datarow_1.Qty = 1
            Me.txtQty.Text = 1
            datarow_1.ItemDesc = objFound.itemdesc
            datarow_1.UnitPrice = objFound.price
            datarow_1.SubTotal = objFound.getSubTotal(1)
            Me.DsTrx1.dtTransaction.AdddtTransactionRow(datarow_1)
            calTotal()
        End If
        'In case if you want to scroll down as well.
        'dgvTrxLine.FirstDisplayedScrollingRowIndex = dgvTrxLine.Rows.Count - 1
        If dgvTrxLine.Rows.Count > 0 Then
            dgvTrxLine.Rows(dgvTrxLine.Rows.Count - 1).Selected = True
        End If
    End Sub

    Private Sub calTotal()
        Dim i As Integer = 0
        Dim _total As Decimal = 0
        For i = 0 To dgvTrxLine.Rows.Count - 1
            Dim _subtotal As Decimal = dgvTrxLine.Rows(i).Cells(6).Value
            _total += _subtotal
        Next
        lblAmount.Text = _total.ToString("0.00")
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            Me.txtInput.Text = ""
            Me.txtInput.Select()
        End If
    End Sub

    Private Sub btnQtyPlus_Click(sender As Object, e As EventArgs) Handles btnQtyPlus.Click
        If dgvTrxLine.SelectedRows.Count <> 1 Then
            Return
        End If
        Dim _qty As Integer = dgvTrxLine.SelectedRows(0).Cells(4).Value
        _qty += 1
        dgvTrxLine.SelectedRows(0).Cells(4).Value = _qty.ToString
        dgvTrxLine.SelectedRows(0).Cells(6).Value = _qty * dgvTrxLine.SelectedRows(0).Cells(5).Value
        txtQty.Text = _qty.ToString
        calTotal()
    End Sub

    Private Sub btnQtyMinus_Click(sender As Object, e As EventArgs) Handles btnQtyMinus.Click
        If dgvTrxLine.SelectedRows.Count <> 1 Then
            Return
        End If
        Dim _qty As Integer = dgvTrxLine.SelectedRows(0).Cells(4).Value
        If _qty = 0 Then
            Return
        End If
        _qty -= 1
        dgvTrxLine.SelectedRows(0).Cells(4).Value = _qty.ToString
        dgvTrxLine.SelectedRows(0).Cells(6).Value = _qty * dgvTrxLine.SelectedRows(0).Cells(5).Value
        txtQty.Text = _qty.ToString
        calTotal()
    End Sub

    Private Sub btnCommon1_Click(sender As Object, e As EventArgs) Handles btnCommon1.Click
        Dim datarow_1 As DSTrx.dtTransactionRow
        datarow_1 = DsTrx1.dtTransaction.NewRow
        datarow_1.Barcode = "999000"
        datarow_1.ItemNum = "999000"
        datarow_1.LineNum = Me.dgvTrxLine.Rows.Count + 1
        datarow_1.Qty = 1
        Me.txtQty.Text = 1
        datarow_1.ItemDesc = "膠袋"
        datarow_1.UnitPrice = 0.5
        datarow_1.SubTotal = 0.5
        Me.DsTrx1.dtTransaction.AdddtTransactionRow(datarow_1)
        calTotal()
        'In case if you want to scroll down as well.
        'dgvTrxLine.FirstDisplayedScrollingRowIndex = dgvTrxLine.Rows.Count - 1
        dgvTrxLine.Rows(dgvTrxLine.Rows.Count - 1).Selected = True
        txtInput.SelectionStart = 0
        txtInput.SelectionLength = txtInput.Text.Length
        txtInput.Select()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If DsTrx1.dtTransaction.Rows.Count = 0 Then
            Return
        End If
        If IsNumeric(lblAmount.Text) = False Then
            Return
        End If

        Dim dlgExchange As Form = New frmExchange(CType(lblAmount.Text, Decimal))
        dlgExchange.StartPosition = FormStartPosition.CenterParent
        Dim response = dlgExchange.ShowDialog(Me)

        If response = DialogResult.OK Then
            Dim objHeader As New clsTrxHeader
            For Each row_1 As DSTrx.dtTransactionRow In DsTrx1.dtTransaction.Rows
                Dim mapRow As New Dictionary(Of String, String)
                mapRow.Add("trxid", objHeader.trxid)
                mapRow.Add("lineno", row_1.LineNum.ToString)
                mapRow.Add("inputbarcode", row_1.Barcode)
                mapRow.Add("itemno", row_1.ItemNum)
                mapRow.Add("itemdesc", row_1.ItemDesc)
                mapRow.Add("inputqty", row_1.Qty.ToString)
                mapRow.Add("subtotal", row_1.SubTotal.ToString)
                Dim objLine As New clsTrxLine(mapRow)
                objHeader.lstTrxLine.Add(objLine)
            Next
            objHeader.children = objHeader.lstTrxLine.Count
            objHeader.totalAmt = CType(lblAmount.Text, Decimal)
            Dim isSaved As Boolean = objHeader.SaveIt()
            If isSaved = True Then
                DsTrx1.dtTransaction.Clear()
                dgvTrxLine.Refresh()
                lblAmount.Text = "0.00"
                txtInput.Text = ""
                txtQty.Text = "1"
                txtInput.Select()
            Else
                MsgBox("結賬失敗，請聯絡技術支援。", vbOKOnly, "結賬未能成功")
            End If
        End If

    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        Dim objSummary As New clsSummary
        objSummary.queryDate2 = DateTimePicker1.Value
        Dim mapSummary As Dictionary(Of String, String) = objSummary.querySummary
        Dim reportmsg As String = ""
        If mapSummary Is Nothing Then
            reportmsg = String.Format("這天 {0} 並無任何交易記錄!", DateTimePicker1.Value.ToString("yyyy/MM/dd"))
            MsgBox(reportmsg, vbOKOnly, "交易總結")
            Return
        End If
        Dim numoftrx_1 As String = ""
        Dim numofitemsold_1 As String = ""
        Dim sumofamt_1 As String = ""
        mapSummary.TryGetValue("numoftrx", numoftrx_1)
        mapSummary.TryGetValue("numofitemsold", numofitemsold_1)
        mapSummary.TryGetValue("sumofamt", sumofamt_1)
        reportmsg = String.Format("交易次數：{0} 單，{1}貨物銷售： {2} 件，{3}交易總額：{4} 元",
                                                numoftrx_1, vbCrLf, numofitemsold_1, vbCrLf, sumofamt_1)
        MsgBox(reportmsg, vbOKOnly, "交易總結")
    End Sub
End Class
