Imports System.Data.SqlClient
Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim chuoiketnoi As String = "workstation id=DBps02144.mssql.somee.com;packet size=4096;user id=tienvmps02144;pwd=qwer#1234A;data source=DBps02144.mssql.somee.com;persist security info=False;initial catalog=DBps02144"
        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from Nhan_Vien where Ma_NhanVien='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Kết nối thành công")
                Main.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai Tai Khoan hoac Mat Khau")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
