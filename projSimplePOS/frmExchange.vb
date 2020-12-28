Public Class frmExchange

    Private decAmount As Decimal
    Private decReceive As Decimal
    Private decChanged As Decimal
    Private isValid As Boolean = False

    Sub New(i_amt As Decimal)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        decAmount = i_amt
    End Sub

    Private Sub txtReceiveAmt_TextChanged(sender As Object, e As EventArgs) Handles txtReceive.TextChanged
        If IsNumeric(txtReceive.Text) = False Then
            Return
        End If
        Dim received_1 As Decimal = CType(txtReceive.Text, Decimal)
        Dim delta_1 As Decimal = received_1 - decAmount
        If delta_1 < 0 Then
            txtChanged.Text = delta_1.ToString("0.00")
            isValid = False
            BtnComplete.ForeColor = Color.Red
            Return
        End If
        txtChanged.Text = delta_1.ToString("0.00")
        isValid = True
        BtnComplete.ForeColor = Color.Black
    End Sub

    Private Sub frmExchange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtAmout.Text = decAmount.ToString("0.00")
        Me.txtReceive.Text = decAmount.ToString("0.00")
        Me.txtChanged.Text = "0"
        Me.Text = "現金找牘計算器"
    End Sub

    Private Sub BtnComplete_Click(sender As Object, e As EventArgs) Handles BtnComplete.Click
        If isValid = False Then
            Return
        End If
        Me.DialogResult = DialogResult.OK

    End Sub
End Class