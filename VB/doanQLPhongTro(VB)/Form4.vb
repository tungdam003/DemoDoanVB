Imports System.Data.SqlClient

Public Class Form4
    Dim connectionString As String = "Data Source=DESKTOP-4H4Q216\SQLEXPRESS;Initial Catalog=DoanQLphongtro;Integrated Security=True"
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim dt As DataTable

    ' Load danh sách hóa đơn
    Private Sub LoadInvoices()
        conn = New SqlConnection(connectionString)
        Dim query As String = "SELECT i.InvoiceID, c.ContractID, t.FullName, i.Month, i.Year, 
                                      i.RoomPrice, i.Electricity, i.Water, i.Internet, i.TotalAmount, i.CreatedDate
                               FROM Invoices i
                               INNER JOIN Contracts c ON i.ContractID = c.ContractID
                               INNER JOIN Tenants t ON c.TenantID = t.TenantID"
        da = New SqlDataAdapter(query, conn)
        dt = New DataTable()
        da.Fill(dt)
        dgvInvoices.DataSource = dt
    End Sub

    ' Load danh sách hợp đồng vào combobox
    Private Sub LoadContracts()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT ContractID FROM Contracts"
            Dim da As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            cboContract.DataSource = dt
            cboContract.DisplayMember = "ContractID"
            cboContract.ValueMember = "ContractID"
        End Using
    End Sub

    ' Khi mở form
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadContracts()
        LoadInvoices()
    End Sub

    ' Nút Thêm
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim query As String = "INSERT INTO Invoices (ContractID, Month, Year, RoomPrice, Electricity, Water, Internet) 
                               VALUES (@ContractID, @Month, @Year, @RoomPrice, @Electricity, @Water, @Internet)"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ContractID", cboContract.SelectedValue)
                cmd.Parameters.AddWithValue("@Month", txtMonth.Text)
                cmd.Parameters.AddWithValue("@Year", txtYear.Text)
                cmd.Parameters.AddWithValue("@RoomPrice", txtRoomPrice.Text)
                cmd.Parameters.AddWithValue("@Electricity", txtElectricity.Text)
                cmd.Parameters.AddWithValue("@Water", txtWater.Text)
                cmd.Parameters.AddWithValue("@Internet", txtInternet.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
        LoadInvoices()
        MessageBox.Show("Thêm hóa đơn thành công!")
    End Sub

    ' Nút Sửa
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvInvoices.CurrentRow Is Nothing Then Exit Sub
        Dim invoiceID As Integer = dgvInvoices.CurrentRow.Cells("InvoiceID").Value

        Dim query As String = "UPDATE Invoices 
                               SET ContractID=@ContractID, Month=@Month, Year=@Year, 
                                   RoomPrice=@RoomPrice, Electricity=@Electricity, 
                                   Water=@Water, Internet=@Internet
                               WHERE InvoiceID=@InvoiceID"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@InvoiceID", invoiceID)
                cmd.Parameters.AddWithValue("@ContractID", cboContract.SelectedValue)
                cmd.Parameters.AddWithValue("@Month", txtMonth.Text)
                cmd.Parameters.AddWithValue("@Year", txtYear.Text)
                cmd.Parameters.AddWithValue("@RoomPrice", txtRoomPrice.Text)
                cmd.Parameters.AddWithValue("@Electricity", txtElectricity.Text)
                cmd.Parameters.AddWithValue("@Water", txtWater.Text)
                cmd.Parameters.AddWithValue("@Internet", txtInternet.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
        LoadInvoices()
        MessageBox.Show("Cập nhật hóa đơn thành công!")
    End Sub

    ' Nút Xóa
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvInvoices.CurrentRow Is Nothing Then Exit Sub
        Dim invoiceID As Integer = dgvInvoices.CurrentRow.Cells("InvoiceID").Value

        Dim query As String = "DELETE FROM Invoices WHERE InvoiceID=@InvoiceID"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@InvoiceID", invoiceID)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
        LoadInvoices()
        MessageBox.Show("Xóa hóa đơn thành công!")
    End Sub

    ' Khi click vào dgvInvoices → load lên textbox
    Private Sub dgvInvoices_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvoices.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvInvoices.Rows(e.RowIndex)
            cboContract.SelectedValue = row.Cells("ContractID").Value
            txtMonth.Text = row.Cells("Month").Value.ToString()
            txtYear.Text = row.Cells("Year").Value.ToString()
            txtRoomPrice.Text = row.Cells("RoomPrice").Value.ToString()
            txtElectricity.Text = row.Cells("Electricity").Value.ToString()
            txtWater.Text = row.Cells("Water").Value.ToString()
            txtInternet.Text = row.Cells("Internet").Value.ToString()
            txtTotal.Text = row.Cells("TotalAmount").Value.ToString()
        End If
    End Sub

    ' Hàm tính tổng
    Private Sub CalculateTotal()
        Dim room As Decimal = If(Decimal.TryParse(txtRoomPrice.Text, Nothing), Decimal.Parse(txtRoomPrice.Text), 0)
        Dim elec As Decimal = If(Decimal.TryParse(txtElectricity.Text, Nothing), Decimal.Parse(txtElectricity.Text), 0)
        Dim water As Decimal = If(Decimal.TryParse(txtWater.Text, Nothing), Decimal.Parse(txtWater.Text), 0)
        Dim internet As Decimal = If(Decimal.TryParse(txtInternet.Text, Nothing), Decimal.Parse(txtInternet.Text), 0)

        Dim total As Decimal = room + elec + water + internet
        txtTotal.Text = total.ToString("N0") ' hiển thị có dấu phân cách
    End Sub



End Class
