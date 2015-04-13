Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class QuanLySP
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=DBps02144.mssql.somee.com;packet size=4096;user id=tienvmps02144;pwd=qwer#1234A;data source=DBps02144.mssql.somee.com;persist security info=False;initial catalog=DBps02144"
    Dim ketnoi As New SqlConnection(connectstr)
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtMSP.Text = DataGridView1.Item(0, index).Value
        txtTSP.Text = DataGridView1.Item(1, index).Value
        txtGSP.Text = DataGridView1.Item(2, index).Value
        txtSL.Text = DataGridView1.Item(3, index).Value
        txtTT.Text = DataGridView1.Item(4, index).Value
    End Sub

    Public Sub LoadData()
        Dim ketnoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from San_Pham", ketnoi)

        Try
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        ketnoi.Close()

    End Sub

    Private Sub QuanLySP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ketnoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from San_Pham", ketnoi)

        Try
            ketnoi.Open()
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub Them_Click(sender As Object, e As EventArgs) Handles Them.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()

        Dim stradd As String = "insert into San_Pham Values(@Ma_SanPham,@Ten_SanPham,@Gia_SanPham,@So_Luong,@TinhTrang_SanPham)"
        Dim com As SqlCommand = New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@Ma_SanPham", txtMSP.Text)
            com.Parameters.AddWithValue("@Ten_SanPham", txtTSP.Text)
            com.Parameters.AddWithValue("@Gia_SanPham", txtGSP.Text)
            com.Parameters.AddWithValue("@So_Luong", txtSL.Text)
            com.Parameters.AddWithValue("@Tinh_SanPham", txtTT.Text)
            com.ExecuteNonQuery()

            ketnoi.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()

    End Sub

    Private Sub Sua_Click(sender As Object, e As EventArgs) Handles Sua.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stadd As String = "UPDATE San_Pham SET Ten_SanPham=@Ten_SanPham, Gia_SanPham=@Gia_SanPham, So_Luong=@So_Luong, TinhTrang_SanPham=@TinhTrang_SanPham Where Ma_SanPham=@Ma_SanPham"
        Dim com As SqlCommand = New SqlCommand(stadd, ketnoi)
        Try
            com.Parameters.AddWithValue("@Ma_SanPham", txtMSP.Text)
            com.Parameters.AddWithValue("@Ten_SanPham", txtTSP.Text)
            com.Parameters.AddWithValue("@Gia_SanPham", txtGSP.Text)
            com.Parameters.AddWithValue("@So_Luong", txtSL.Text)
            com.Parameters.AddWithValue("@TinhTrang_SanPham", txtTT.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub Xoa_Click(sender As Object, e As EventArgs) Handles Xoa.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stadd As String = "Delete From San_Pham Where Ma_SanPham=@Ma_SanPham"
        Dim com As SqlCommand = New SqlCommand(stadd, ketnoi)
        Try
            com.Parameters.AddWithValue("@Ma_SanPham", txtMSP.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Application.Exit()
    End Sub
End Class
