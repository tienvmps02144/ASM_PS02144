<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuanLySP
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
        Me.txtMSP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Them = New System.Windows.Forms.Button()
        Me.txtTSP = New System.Windows.Forms.TextBox()
        Me.txtGSP = New System.Windows.Forms.TextBox()
        Me.txtSL = New System.Windows.Forms.TextBox()
        Me.txtTT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Sua = New System.Windows.Forms.Button()
        Me.Xoa = New System.Windows.Forms.Button()
        Me.Thoat = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMSP
        '
        Me.txtMSP.Location = New System.Drawing.Point(134, 42)
        Me.txtMSP.Name = "txtMSP"
        Me.txtMSP.Size = New System.Drawing.Size(138, 20)
        Me.txtMSP.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Sản Phẩm:"
        '
        'Them
        '
        Me.Them.Location = New System.Drawing.Point(43, 182)
        Me.Them.Name = "Them"
        Me.Them.Size = New System.Drawing.Size(57, 23)
        Me.Them.TabIndex = 2
        Me.Them.Text = "Thêm"
        Me.Them.UseVisualStyleBackColor = True
        '
        'txtTSP
        '
        Me.txtTSP.Location = New System.Drawing.Point(134, 71)
        Me.txtTSP.Name = "txtTSP"
        Me.txtTSP.Size = New System.Drawing.Size(138, 20)
        Me.txtTSP.TabIndex = 3
        '
        'txtGSP
        '
        Me.txtGSP.Location = New System.Drawing.Point(134, 94)
        Me.txtGSP.Name = "txtGSP"
        Me.txtGSP.Size = New System.Drawing.Size(96, 20)
        Me.txtGSP.TabIndex = 4
        '
        'txtSL
        '
        Me.txtSL.Location = New System.Drawing.Point(134, 123)
        Me.txtSL.Name = "txtSL"
        Me.txtSL.Size = New System.Drawing.Size(71, 20)
        Me.txtSL.TabIndex = 5
        '
        'txtTT
        '
        Me.txtTT.Location = New System.Drawing.Point(134, 149)
        Me.txtTT.Name = "txtTT"
        Me.txtTT.Size = New System.Drawing.Size(71, 20)
        Me.txtTT.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tên Sản Phẩm:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Giá Sản Phẩm:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Số Lượng:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tình Trạng:"
        '
        'Sua
        '
        Me.Sua.Location = New System.Drawing.Point(120, 182)
        Me.Sua.Name = "Sua"
        Me.Sua.Size = New System.Drawing.Size(57, 23)
        Me.Sua.TabIndex = 11
        Me.Sua.Text = "Sửa"
        Me.Sua.UseVisualStyleBackColor = True
        '
        'Xoa
        '
        Me.Xoa.Location = New System.Drawing.Point(201, 182)
        Me.Xoa.Name = "Xoa"
        Me.Xoa.Size = New System.Drawing.Size(57, 23)
        Me.Xoa.TabIndex = 12
        Me.Xoa.Text = "Xóa"
        Me.Xoa.UseVisualStyleBackColor = True
        '
        'Thoat
        '
        Me.Thoat.Location = New System.Drawing.Point(276, 182)
        Me.Thoat.Name = "Thoat"
        Me.Thoat.Size = New System.Drawing.Size(57, 23)
        Me.Thoat.TabIndex = 13
        Me.Thoat.Text = "Thoát"
        Me.Thoat.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 211)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(415, 197)
        Me.DataGridView1.TabIndex = 14
        '
        'QuanLySP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 420)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Thoat)
        Me.Controls.Add(Me.Xoa)
        Me.Controls.Add(Me.Sua)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTT)
        Me.Controls.Add(Me.txtSL)
        Me.Controls.Add(Me.txtGSP)
        Me.Controls.Add(Me.txtTSP)
        Me.Controls.Add(Me.Them)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMSP)
        Me.Name = "QuanLySP"
        Me.Text = "Quản Lý Sản Phẩm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMSP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Them As System.Windows.Forms.Button
    Friend WithEvents txtTSP As System.Windows.Forms.TextBox
    Friend WithEvents txtGSP As System.Windows.Forms.TextBox
    Friend WithEvents txtSL As System.Windows.Forms.TextBox
    Friend WithEvents txtTT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Sua As System.Windows.Forms.Button
    Friend WithEvents Xoa As System.Windows.Forms.Button
    Friend WithEvents Thoat As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
