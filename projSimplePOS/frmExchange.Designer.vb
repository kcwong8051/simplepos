<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExchange
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReceive = New System.Windows.Forms.TextBox()
        Me.txtAmout = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtChanged = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnComplete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("PMingLiU", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "收取："
        '
        'txtReceive
        '
        Me.txtReceive.Font = New System.Drawing.Font("PMingLiU", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtReceive.Location = New System.Drawing.Point(161, 88)
        Me.txtReceive.Name = "txtReceive"
        Me.txtReceive.Size = New System.Drawing.Size(246, 65)
        Me.txtReceive.TabIndex = 1
        '
        'txtAmout
        '
        Me.txtAmout.Font = New System.Drawing.Font("PMingLiU", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtAmout.Location = New System.Drawing.Point(161, 12)
        Me.txtAmout.Name = "txtAmout"
        Me.txtAmout.Size = New System.Drawing.Size(246, 65)
        Me.txtAmout.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("PMingLiU", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 48)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "應收："
        '
        'txtChanged
        '
        Me.txtChanged.Font = New System.Drawing.Font("PMingLiU", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtChanged.Location = New System.Drawing.Point(161, 165)
        Me.txtChanged.Name = "txtChanged"
        Me.txtChanged.Size = New System.Drawing.Size(246, 65)
        Me.txtChanged.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("PMingLiU", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 48)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "找牘："
        '
        'BtnComplete
        '
        Me.BtnComplete.Font = New System.Drawing.Font("PMingLiU", 48.0!)
        Me.BtnComplete.Location = New System.Drawing.Point(161, 261)
        Me.BtnComplete.Name = "BtnComplete"
        Me.BtnComplete.Size = New System.Drawing.Size(246, 95)
        Me.BtnComplete.TabIndex = 6
        Me.BtnComplete.Text = "完成"
        Me.BtnComplete.UseVisualStyleBackColor = True
        '
        'frmExchange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 375)
        Me.Controls.Add(Me.BtnComplete)
        Me.Controls.Add(Me.txtChanged)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAmout)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtReceive)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmExchange"
        Me.Text = "frmExchange"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtReceive As TextBox
    Friend WithEvents txtAmout As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtChanged As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnComplete As Button
End Class
