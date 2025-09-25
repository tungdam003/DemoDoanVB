Imports System.Data.SqlClient

Public Class Form3
    Dim connectionString As String = "Data Source=DESKTOP-4H4Q216\SQLEXPRESS;Initial Catalog=DoanQLphongtro;Integrated Security=True"

    ' Khi form load
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRooms()
        LoadTenants()
        LoadContracts()
    End Sub

    ' ================= LOAD DỮ LIỆU =================
    Private Sub LoadRooms()
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT RoomID, RoomNumber FROM Rooms", conn)
            conn.Open()
            Dim dt As New DataTable()
            dt.Load(cmd.ExecuteReader())
            cboRoom.DataSource = dt
            cboRoom.DisplayMember = "RoomNumber"
            cboRoom.ValueMember = "RoomID"
        End Using
    End Sub

    Private Sub LoadTenants()
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT TenantID, FullName FROM Tenants", conn)
            conn.Open()
            Dim dt As New DataTable()
            dt.Load(cmd.ExecuteReader())
            cboTenant.DataSource = dt
            cboTenant.DisplayMember = "FullName"
            cboTenant.ValueMember = "TenantID"
        End Using
    End Sub

    Private Sub LoadContracts()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT c.ContractID, r.RoomNumber, t.FullName, c.StartDate, c.EndDate, c.Deposit, c.MonthlyRent, c.Notes
                                   FROM Contracts c
                                   INNER JOIN Rooms r ON c.RoomID = r.RoomID
                                   INNER JOIN Tenants t ON c.TenantID = t.TenantID"
            Dim da As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvContracts.DataSource = dt
        End Using
    End Sub

    ' ================= THÊM =================
    Private Sub btnAddContract_Click(sender As Object, e As EventArgs) Handles btnAddContract.Click
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO Contracts (RoomID, TenantID, StartDate, EndDate, Deposit, MonthlyRent, Notes, Status)
                                   VALUES (@RoomID, @TenantID, @StartDate, @EndDate, @Deposit, @MonthlyRent, @Notes, N'Còn hiệu lực')"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@RoomID", cboRoom.SelectedValue)
            cmd.Parameters.AddWithValue("@TenantID", cboTenant.SelectedValue)
            cmd.Parameters.AddWithValue("@StartDate", dtpStart.Value)
            cmd.Parameters.AddWithValue("@EndDate", dtpEnd.Value)
            cmd.Parameters.AddWithValue("@Deposit", txtDeposit.Text)
            cmd.Parameters.AddWithValue("@MonthlyRent", txtMonthlyRent.Text)
            cmd.Parameters.AddWithValue("@Notes", txtNotes.Text)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using
        LoadContracts()
        MessageBox.Show("Thêm hợp đồng thành công!")
    End Sub

    ' ================= SỬA =================
    Private Sub btnUpdateContract_Click(sender As Object, e As EventArgs) Handles btnUpdateContract.Click
        If dgvContracts.CurrentRow Is Nothing Then Return
        Dim id As Integer = dgvContracts.CurrentRow.Cells("ContractID").Value

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "UPDATE Contracts SET RoomID=@RoomID, TenantID=@TenantID, StartDate=@StartDate, EndDate=@EndDate,
                                   Deposit=@Deposit, MonthlyRent=@MonthlyRent, Notes=@Notes WHERE ContractID=@ContractID"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@RoomID", cboRoom.SelectedValue)
            cmd.Parameters.AddWithValue("@TenantID", cboTenant.SelectedValue)
            cmd.Parameters.AddWithValue("@StartDate", dtpStart.Value)
            cmd.Parameters.AddWithValue("@EndDate", dtpEnd.Value)
            cmd.Parameters.AddWithValue("@Deposit", txtDeposit.Text)
            cmd.Parameters.AddWithValue("@MonthlyRent", txtMonthlyRent.Text)
            cmd.Parameters.AddWithValue("@Notes", txtNotes.Text)
            cmd.Parameters.AddWithValue("@ContractID", id)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using
        LoadContracts()
        MessageBox.Show("Cập nhật hợp đồng thành công!")
    End Sub

    ' ================= XÓA =================
    Private Sub btnDeleteContract_Click(sender As Object, e As EventArgs) Handles btnDeleteContract.Click
        If dgvContracts.CurrentRow Is Nothing Then Return
        Dim id As Integer = dgvContracts.CurrentRow.Cells("ContractID").Value

        If MessageBox.Show("Bạn có chắc muốn xóa hợp đồng này?", "Xóa", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "DELETE FROM Contracts WHERE ContractID=@ContractID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ContractID", id)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
            LoadContracts()
            MessageBox.Show("Xóa hợp đồng thành công!")
        End If
    End Sub

    ' ================= CLICK dgv -> load lên textbox =================
    Private Sub dgvContracts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContracts.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvContracts.Rows(e.RowIndex)

            cboRoom.Text = row.Cells("RoomNumber").Value.ToString()
            cboTenant.Text = row.Cells("FullName").Value.ToString()
            dtpStart.Value = row.Cells("StartDate").Value
            dtpEnd.Value = row.Cells("EndDate").Value
            txtDeposit.Text = row.Cells("Deposit").Value.ToString()
            txtMonthlyRent.Text = row.Cells("MonthlyRent").Value.ToString()
            txtNotes.Text = row.Cells("Notes").Value.ToString()
        End If
    End Sub
End Class
