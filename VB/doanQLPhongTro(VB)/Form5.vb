Imports System.Data.SqlClient

Public Class Form5
    Dim connectionString As String = "Data Source=DESKTOP-4H4Q216\SQLEXPRESS;Initial Catalog=DoanQLphongtro;Integrated Security=True"

    ' ======= XEM DANH SÁCH PHÒNG TRỐNG =======
    Private Sub btnViewEmptyRooms_Click(sender As Object, e As EventArgs) Handles btnViewEmptyRooms.Click
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT RoomID, RoomNumber, Floor, Price, Description 
                                   FROM Rooms WHERE Status = N'Trống'"
            Dim da As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvEmptyRooms.DataSource = dt
        End Using
    End Sub

    ' ======= XEM DOANH THU =======
    Private Sub btnViewRevenue_Click(sender As Object, e As EventArgs) Handles btnViewRevenue.Click
        If txtMonth.Text = "" Or txtYear.Text = "" Then
            MessageBox.Show("Vui lòng nhập Tháng và Năm!")
            Exit Sub
        End If

        Dim month As Integer = Integer.Parse(txtMonth.Text)
        Dim year As Integer = Integer.Parse(txtYear.Text)

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT ISNULL(SUM(TotalAmount),0) 
                                   FROM Invoices 
                                   WHERE Month=@Month AND Year=@Year"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Month", month)
                cmd.Parameters.AddWithValue("@Year", year)
                conn.Open()
                Dim revenue As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                conn.Close()

                lblRevenueValue.Text = revenue.ToString("N0") & " VNĐ"
            End Using
        End Using
    End Sub
End Class
