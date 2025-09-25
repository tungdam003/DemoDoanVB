Imports System.Data.SqlClient

Public Class Form2
    Dim connectionString As String = "Data Source=DESKTOP-4H4Q216\SQLEXPRESS;Initial Catalog=DoanQLphongtro;Integrated Security=True"
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim dt As DataTable

    ' Load danh sách khách thuê
    Private Sub LoadTenants()
        conn = New SqlConnection(connectionString)
        da = New SqlDataAdapter("SELECT * FROM Tenants", conn)
        dt = New DataTable()
        da.Fill(dt)
        dgvTenants.DataSource = dt
    End Sub

    ' Khi mở Form
    Private Sub FormTenant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTenants()
    End Sub

    ' Nút Thêm
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim query As String = "INSERT INTO Tenants (FullName, IDNumber, Phone, Address, Email) 
                               VALUES (@FullName, @IDNumber, @Phone, @Address, @Email)"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text)
                cmd.Parameters.AddWithValue("@IDNumber", txtIDNumber.Text)
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        End Using
        LoadTenants()
        MessageBox.Show("Thêm khách thuê thành công!")
    End Sub

    ' Nút Sửa
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvTenants.CurrentRow Is Nothing Then Exit Sub
        Dim tenantID As Integer = dgvTenants.CurrentRow.Cells("TenantID").Value

        Dim query As String = "UPDATE Tenants SET FullName=@FullName, IDNumber=@IDNumber, Phone=@Phone, Address=@Address, Email=@Email 
                               WHERE TenantID=@TenantID"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@TenantID", tenantID)
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text)
                cmd.Parameters.AddWithValue("@IDNumber", txtIDNumber.Text)
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        End Using
        LoadTenants()
        MessageBox.Show("Cập nhật thông tin khách thuê thành công!")
    End Sub

    ' Nút Xóa
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvTenants.CurrentRow Is Nothing Then Exit Sub
        Dim tenantID As Integer = dgvTenants.CurrentRow.Cells("TenantID").Value

        Dim query As String = "DELETE FROM Tenants WHERE TenantID=@TenantID"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@TenantID", tenantID)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        End Using
        LoadTenants()
        MessageBox.Show("Xóa khách thuê thành công!")
    End Sub

    ' Nút Tìm kiếm
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim keyword As String = txtFullName.Text
        Dim query As String = "SELECT * FROM Tenants WHERE FullName LIKE @keyword OR IDNumber LIKE @keyword OR Phone LIKE @keyword"
        Using conn As New SqlConnection(connectionString)
            Using da As New SqlDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                dt = New DataTable()
                da.Fill(dt)
                dgvTenants.DataSource = dt
            End Using
        End Using
    End Sub
    ' Khi click vào 1 dòng trong DataGridView
    Private Sub dgvTenants_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTenants.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvTenants.Rows(e.RowIndex)
            txtFullName.Text = row.Cells("FullName").Value.ToString()
            txtIDNumber.Text = row.Cells("IDNumber").Value.ToString()
            txtPhone.Text = row.Cells("Phone").Value.ToString()
            txtAddress.Text = row.Cells("Address").Value.ToString()
            txtEmail.Text = row.Cells("Email").Value.ToString()
        End If
    End Sub




End Class
