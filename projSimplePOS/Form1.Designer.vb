<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPOS = New System.Windows.Forms.TabPage()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnCommon1 = New System.Windows.Forms.Button()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvTrxLine = New System.Windows.Forms.DataGridView()
        Me.LineNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSTrx1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTrx1 = New projSimplePOS.DSTrx()
        Me.btnQtyMinus = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.btnQtyPlus = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabItem = New System.Windows.Forms.TabPage()
        Me.dgvItem = New System.Windows.Forms.DataGridView()
        Me.tabSalesReport = New System.Windows.Forms.TabPage()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabPOS.SuspendLayout()
        CType(Me.dgvTrxLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSTrx1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrx1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabItem.SuspendLayout()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSalesReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPOS)
        Me.TabControl1.Controls.Add(Me.tabItem)
        Me.TabControl1.Controls.Add(Me.tabSalesReport)
        Me.TabControl1.Location = New System.Drawing.Point(13, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(810, 390)
        Me.TabControl1.TabIndex = 0
        '
        'tabPOS
        '
        Me.tabPOS.Controls.Add(Me.btnCheck)
        Me.tabPOS.Controls.Add(Me.btnCommon1)
        Me.tabPOS.Controls.Add(Me.lblAmount)
        Me.tabPOS.Controls.Add(Me.Label2)
        Me.tabPOS.Controls.Add(Me.dgvTrxLine)
        Me.tabPOS.Controls.Add(Me.btnQtyMinus)
        Me.tabPOS.Controls.Add(Me.txtQty)
        Me.tabPOS.Controls.Add(Me.btnQtyPlus)
        Me.tabPOS.Controls.Add(Me.txtInput)
        Me.tabPOS.Controls.Add(Me.Label1)
        Me.tabPOS.Location = New System.Drawing.Point(4, 26)
        Me.tabPOS.Name = "tabPOS"
        Me.tabPOS.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPOS.Size = New System.Drawing.Size(802, 360)
        Me.tabPOS.TabIndex = 0
        Me.tabPOS.Text = "收銀頁面"
        Me.tabPOS.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCheck.Font = New System.Drawing.Font("PMingLiU", 28.0!)
        Me.btnCheck.Location = New System.Drawing.Point(640, 175)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(155, 67)
        Me.btnCheck.TabIndex = 9
        Me.btnCheck.Text = "結賬"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'btnCommon1
        '
        Me.btnCommon1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCommon1.Font = New System.Drawing.Font("PMingLiU", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnCommon1.Location = New System.Drawing.Point(640, 56)
        Me.btnCommon1.Name = "btnCommon1"
        Me.btnCommon1.Size = New System.Drawing.Size(155, 67)
        Me.btnCommon1.TabIndex = 8
        Me.btnCommon1.Text = "膠袋"
        Me.btnCommon1.UseVisualStyleBackColor = False
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("PMingLiU", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(649, 293)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAmount.Size = New System.Drawing.Size(146, 48)
        Me.lblAmount.TabIndex = 7
        Me.lblAmount.Text = "999.99"
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("PMingLiU", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(639, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 27)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "總數："
        '
        'dgvTrxLine
        '
        Me.dgvTrxLine.AllowUserToAddRows = False
        Me.dgvTrxLine.AutoGenerateColumns = False
        Me.dgvTrxLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrxLine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LineNumDataGridViewTextBoxColumn, Me.BarcodeDataGridViewTextBoxColumn, Me.ItemNumDataGridViewTextBoxColumn, Me.ItemDescDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.SubTotalDataGridViewTextBoxColumn, Me.DiscountDataGridViewTextBoxColumn})
        Me.dgvTrxLine.DataSource = Me.BSTrx1
        Me.dgvTrxLine.Location = New System.Drawing.Point(20, 56)
        Me.dgvTrxLine.MultiSelect = False
        Me.dgvTrxLine.Name = "dgvTrxLine"
        Me.dgvTrxLine.RowTemplate.Height = 24
        Me.dgvTrxLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTrxLine.Size = New System.Drawing.Size(613, 285)
        Me.dgvTrxLine.TabIndex = 5
        '
        'LineNumDataGridViewTextBoxColumn
        '
        Me.LineNumDataGridViewTextBoxColumn.DataPropertyName = "LineNum"
        Me.LineNumDataGridViewTextBoxColumn.HeaderText = "行數"
        Me.LineNumDataGridViewTextBoxColumn.Name = "LineNumDataGridViewTextBoxColumn"
        Me.LineNumDataGridViewTextBoxColumn.Width = 70
        '
        'BarcodeDataGridViewTextBoxColumn
        '
        Me.BarcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode"
        Me.BarcodeDataGridViewTextBoxColumn.HeaderText = "條碼"
        Me.BarcodeDataGridViewTextBoxColumn.Name = "BarcodeDataGridViewTextBoxColumn"
        Me.BarcodeDataGridViewTextBoxColumn.Visible = False
        '
        'ItemNumDataGridViewTextBoxColumn
        '
        Me.ItemNumDataGridViewTextBoxColumn.DataPropertyName = "ItemNum"
        Me.ItemNumDataGridViewTextBoxColumn.HeaderText = "貨號"
        Me.ItemNumDataGridViewTextBoxColumn.Name = "ItemNumDataGridViewTextBoxColumn"
        '
        'ItemDescDataGridViewTextBoxColumn
        '
        Me.ItemDescDataGridViewTextBoxColumn.DataPropertyName = "ItemDesc"
        Me.ItemDescDataGridViewTextBoxColumn.HeaderText = "貨名"
        Me.ItemDescDataGridViewTextBoxColumn.Name = "ItemDescDataGridViewTextBoxColumn"
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "Qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "件數"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "單價"
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        '
        'SubTotalDataGridViewTextBoxColumn
        '
        Me.SubTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal"
        Me.SubTotalDataGridViewTextBoxColumn.HeaderText = "小計"
        Me.SubTotalDataGridViewTextBoxColumn.Name = "SubTotalDataGridViewTextBoxColumn"
        '
        'DiscountDataGridViewTextBoxColumn
        '
        Me.DiscountDataGridViewTextBoxColumn.DataPropertyName = "Discount"
        Me.DiscountDataGridViewTextBoxColumn.HeaderText = "Discount"
        Me.DiscountDataGridViewTextBoxColumn.Name = "DiscountDataGridViewTextBoxColumn"
        Me.DiscountDataGridViewTextBoxColumn.Visible = False
        '
        'BSTrx1
        '
        Me.BSTrx1.DataMember = "dtTransaction"
        Me.BSTrx1.DataSource = Me.DsTrx1
        '
        'DsTrx1
        '
        Me.DsTrx1.DataSetName = "DSTrx"
        Me.DsTrx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnQtyMinus
        '
        Me.btnQtyMinus.Font = New System.Drawing.Font("PMingLiU", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnQtyMinus.Location = New System.Drawing.Point(598, 17)
        Me.btnQtyMinus.Name = "btnQtyMinus"
        Me.btnQtyMinus.Size = New System.Drawing.Size(35, 35)
        Me.btnQtyMinus.TabIndex = 4
        Me.btnQtyMinus.Text = "-"
        Me.btnQtyMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnQtyMinus.UseVisualStyleBackColor = True
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("PMingLiU", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtQty.Location = New System.Drawing.Point(489, 19)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(103, 33)
        Me.txtQty.TabIndex = 3
        '
        'btnQtyPlus
        '
        Me.btnQtyPlus.Font = New System.Drawing.Font("PMingLiU", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnQtyPlus.Location = New System.Drawing.Point(448, 18)
        Me.btnQtyPlus.Name = "btnQtyPlus"
        Me.btnQtyPlus.Size = New System.Drawing.Size(35, 35)
        Me.btnQtyPlus.TabIndex = 2
        Me.btnQtyPlus.Text = "+"
        Me.btnQtyPlus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnQtyPlus.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("PMingLiU", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtInput.Location = New System.Drawing.Point(171, 17)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(248, 33)
        Me.txtInput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("PMingLiU", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "輸入條碼/貨號："
        '
        'tabItem
        '
        Me.tabItem.Controls.Add(Me.dgvItem)
        Me.tabItem.Location = New System.Drawing.Point(4, 26)
        Me.tabItem.Name = "tabItem"
        Me.tabItem.Padding = New System.Windows.Forms.Padding(3)
        Me.tabItem.Size = New System.Drawing.Size(802, 360)
        Me.tabItem.TabIndex = 1
        Me.tabItem.Text = "貨物頁面"
        Me.tabItem.UseVisualStyleBackColor = True
        '
        'dgvItem
        '
        Me.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItem.Location = New System.Drawing.Point(18, 13)
        Me.dgvItem.Name = "dgvItem"
        Me.dgvItem.RowTemplate.Height = 24
        Me.dgvItem.Size = New System.Drawing.Size(772, 279)
        Me.dgvItem.TabIndex = 0
        '
        'tabSalesReport
        '
        Me.tabSalesReport.Controls.Add(Me.btnSummary)
        Me.tabSalesReport.Controls.Add(Me.Label3)
        Me.tabSalesReport.Controls.Add(Me.DateTimePicker1)
        Me.tabSalesReport.Location = New System.Drawing.Point(4, 26)
        Me.tabSalesReport.Name = "tabSalesReport"
        Me.tabSalesReport.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSalesReport.Size = New System.Drawing.Size(802, 360)
        Me.tabSalesReport.TabIndex = 2
        Me.tabSalesReport.Text = "營業報表"
        Me.tabSalesReport.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(147, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(154, 27)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("PMingLiU", 16.0!)
        Me.Label3.Location = New System.Drawing.Point(21, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "查詢日期："
        '
        'btnSummary
        '
        Me.btnSummary.Location = New System.Drawing.Point(334, 16)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(112, 37)
        Me.btnSummary.TabIndex = 2
        Me.btnSummary.Text = "交易總結"
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 432)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("PMingLiU", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.tabPOS.ResumeLayout(False)
        Me.tabPOS.PerformLayout()
        CType(Me.dgvTrxLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSTrx1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrx1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabItem.ResumeLayout(False)
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSalesReport.ResumeLayout(False)
        Me.tabSalesReport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabPOS As TabPage
    Friend WithEvents tabItem As TabPage
    Friend WithEvents dgvItem As DataGridView
    Friend WithEvents dgvTrxLine As DataGridView
    Friend WithEvents btnQtyMinus As Button
    Friend WithEvents txtQty As TextBox
    Friend WithEvents btnQtyPlus As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DsTrx1 As DSTrx
    Friend WithEvents BSTrx1 As BindingSource
    Friend WithEvents btnCommon1 As Button
    Friend WithEvents lblAmount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LineNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BarcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemDescDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnCheck As Button
    Friend WithEvents tabSalesReport As TabPage
    Friend WithEvents btnSummary As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
