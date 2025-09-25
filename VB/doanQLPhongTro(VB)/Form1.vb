Imports System.Data.SqlClient

Public Class Form1

    Dim connectionString As String = "Data Source=DESKTOP-4H4Q216\SQLEXPRESS;Initial Catalog=DoanQLphongtro;Integrated Security=True"


    Dim conn As SqlConnection

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            conn = New SqlConnection(connectionString)
            LoadRooms()
            ' Thêm dữ liệu vào combobox trạng thái
            cboStatus.Items.Add("Trống")
            cboStatus.Items.Add("Đang thuê")
        End Sub

        ' Load danh sách phòng
        Private Sub LoadRooms()
            Dim query As String = "SELECT * FROM Rooms"
            Dim da As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvRooms.DataSource = dt
        End Sub

        ' Nút Thêm
        Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
            Dim query As String = "INSERT INTO Rooms(RoomNumber, Floor, Price, Status, Description) VALUES (@RoomNumber, @Floor, @Price, @Status, @Description)"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@RoomNumber", txtRoomNumber.Text)
            cmd.Parameters.AddWithValue("@Floor", txtFloor.Text)
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
            cmd.Parameters.AddWithValue("@Status", cboStatus.Text)
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Thêm phòng thành công!")
            LoadRooms()
        End Sub

        ' Nút Sửa
        Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
            Dim query As String = "UPDATE Rooms SET RoomNumber=@RoomNumber, Floor=@Floor, Price=@Price, Status=@Status, Description=@Description WHERE RoomID=@RoomID"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@RoomNumber", txtRoomNumber.Text)
            cmd.Parameters.AddWithValue("@Floor", txtFloor.Text)
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
            cmd.Parameters.AddWithValue("@Status", cboStatus.Text)
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text)
            cmd.Parameters.AddWithValue("@RoomID", dgvRooms.CurrentRow.Cells("RoomID").Value)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Cập nhật thành công!")
            LoadRooms()
        End Sub

        ' Nút Xóa
        Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
            Dim query As String = "DELETE FROM Rooms WHERE RoomID=@RoomID"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@RoomID", dgvRooms.CurrentRow.Cells("RoomID").Value)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Xóa thành công!")
            LoadRooms()
        End Sub

        ' Nút Tìm kiếm theo trạng thái
        Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
            Dim query As String = "SELECT * FROM Rooms WHERE Status=@Status"
            Dim da As New SqlDataAdapter(query, conn)
            da.SelectCommand.Parameters.AddWithValue("@Status", cboStatus.Text)

            Dim dt As New DataTable()
            da.Fill(dt)
            dgvRooms.DataSource = dt
        End Sub

        ' Click vào dòng trong DataGridView → hiện dữ liệu lên textbox
        Private Sub dgvRooms_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRooms.CellClick
            If e.RowIndex >= 0 Then
                txtRoomNumber.Text = dgvRooms.Rows(e.RowIndex).Cells("RoomNumber").Value.ToString()
                txtFloor.Text = dgvRooms.Rows(e.RowIndex).Cells("Floor").Value.ToString()
                txtPrice.Text = dgvRooms.Rows(e.RowIndex).Cells("Price").Value.ToString()
                cboStatus.Text = dgvRooms.Rows(e.RowIndex).Cells("Status").Value.ToString()
                txtDescription.Text = dgvRooms.Rows(e.RowIndex).Cells("Description").Value.ToString()
            End If
        End Sub

    ' Nút Quản lý khách thuê
    Private Sub btnOpenForm2_Click(sender As Object, e As EventArgs) Handles btnOpenForm2.Click
        Dim f2 As New Form2()
        f2.Show()

    End Sub
    ' Nút Quản lý hợp đồng
    Private Sub btnContracts_Click(sender As Object, e As EventArgs) Handles btnContracts.Click
        Dim f As New Form3()
        f.ShowDialog()
    End Sub

    ' Nút Quản lý Hóa đơn
    Private Sub btnInvoices_Click(sender As Object, e As EventArgs) Handles btnInvoices.Click
        Dim f As New Form4()
        f.ShowDialog()
    End Sub
    ' Nút Quản lý thông kê - báo cáo
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim f As New Form5()
        f.ShowDialog()
    End Sub




End Class





