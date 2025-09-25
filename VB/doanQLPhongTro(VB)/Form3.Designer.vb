<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTenant = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.lblMonthlyRent = New System.Windows.Forms.Label()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.cboTenant = New System.Windows.Forms.ComboBox()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.txtMonthlyRent = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.btnAddContract = New System.Windows.Forms.Button()
        Me.btnUpdateContract = New System.Windows.Forms.Button()
        Me.btnDeleteContract = New System.Windows.Forms.Button()
        Me.dgvContracts = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboRoom = New System.Windows.Forms.ComboBox()
        CType(Me.dgvContracts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(324, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "   Quản lý hợp đồng thuê  "
        '
        'lblTenant
        '
        Me.lblTenant.AutoSize = True
        Me.lblTenant.Location = New System.Drawing.Point(48, 37)
        Me.lblTenant.Name = "lblTenant"
        Me.lblTenant.Size = New System.Drawing.Size(65, 13)
        Me.lblTenant.TabIndex = 1
        Me.lblTenant.Text = "Khách thuê:"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(38, 67)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(75, 13)
        Me.lblStartDate.TabIndex = 2
        Me.lblStartDate.Text = "Ngày bắt đầu:"
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Location = New System.Drawing.Point(36, 99)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(77, 13)
        Me.lblEndDate.TabIndex = 3
        Me.lblEndDate.Text = "Ngày kết thúc:"
        '
        'lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.Location = New System.Drawing.Point(48, 129)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(55, 13)
        Me.lblDeposit.TabIndex = 4
        Me.lblDeposit.Text = "Tiền cọc: "
        '
        'lblMonthlyRent
        '
        Me.lblMonthlyRent.AutoSize = True
        Me.lblMonthlyRent.Location = New System.Drawing.Point(31, 162)
        Me.lblMonthlyRent.Name = "lblMonthlyRent"
        Me.lblMonthlyRent.Size = New System.Drawing.Size(82, 13)
        Me.lblMonthlyRent.TabIndex = 5
        Me.lblMonthlyRent.Text = "Giá thuê/tháng:"
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(56, 198)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(47, 13)
        Me.lblNotes.TabIndex = 6
        Me.lblNotes.Text = "Ghi chú:"
        '
        'cboTenant
        '
        Me.cboTenant.FormattingEnabled = True
        Me.cboTenant.Location = New System.Drawing.Point(112, 34)
        Me.cboTenant.Name = "cboTenant"
        Me.cboTenant.Size = New System.Drawing.Size(193, 21)
        Me.cboTenant.TabIndex = 7
        '
        'dtpStart
        '
        Me.dtpStart.Location = New System.Drawing.Point(112, 61)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(200, 20)
        Me.dtpStart.TabIndex = 8
        '
        'dtpEnd
        '
        Me.dtpEnd.Location = New System.Drawing.Point(112, 93)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(200, 20)
        Me.dtpEnd.TabIndex = 9
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(112, 126)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(100, 20)
        Me.txtDeposit.TabIndex = 10
        '
        'txtMonthlyRent
        '
        Me.txtMonthlyRent.Location = New System.Drawing.Point(112, 159)
        Me.txtMonthlyRent.Name = "txtMonthlyRent"
        Me.txtMonthlyRent.Size = New System.Drawing.Size(100, 20)
        Me.txtMonthlyRent.TabIndex = 11
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(112, 198)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(517, 20)
        Me.txtNotes.TabIndex = 12
        '
        'btnAddContract
        '
        Me.btnAddContract.Location = New System.Drawing.Point(686, 37)
        Me.btnAddContract.Name = "btnAddContract"
        Me.btnAddContract.Size = New System.Drawing.Size(75, 23)
        Me.btnAddContract.TabIndex = 13
        Me.btnAddContract.Text = "Thêm"
        Me.btnAddContract.UseVisualStyleBackColor = True
        '
        'btnUpdateContract
        '
        Me.btnUpdateContract.Location = New System.Drawing.Point(686, 72)
        Me.btnUpdateContract.Name = "btnUpdateContract"
        Me.btnUpdateContract.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateContract.TabIndex = 14
        Me.btnUpdateContract.Text = "Sửa"
        Me.btnUpdateContract.UseVisualStyleBackColor = True
        '
        'btnDeleteContract
        '
        Me.btnDeleteContract.Location = New System.Drawing.Point(686, 104)
        Me.btnDeleteContract.Name = "btnDeleteContract"
        Me.btnDeleteContract.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteContract.TabIndex = 15
        Me.btnDeleteContract.Text = "Xóa"
        Me.btnDeleteContract.UseVisualStyleBackColor = True
        '
        'dgvContracts
        '
        Me.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContracts.Location = New System.Drawing.Point(34, 258)
        Me.dgvContracts.Name = "dgvContracts"
        Me.dgvContracts.Size = New System.Drawing.Size(727, 180)
        Me.dgvContracts.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(324, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Danh sách hợp đông"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(355, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Phòng:"
        '
        'cboRoom
        '
        Me.cboRoom.FormattingEnabled = True
        Me.cboRoom.Location = New System.Drawing.Point(400, 34)
        Me.cboRoom.Name = "cboRoom"
        Me.cboRoom.Size = New System.Drawing.Size(121, 21)
        Me.cboRoom.TabIndex = 19
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 450)
        Me.Controls.Add(Me.cboRoom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvContracts)
        Me.Controls.Add(Me.btnDeleteContract)
        Me.Controls.Add(Me.btnUpdateContract)
        Me.Controls.Add(Me.btnAddContract)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtMonthlyRent)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.dtpStart)
        Me.Controls.Add(Me.cboTenant)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.lblMonthlyRent)
        Me.Controls.Add(Me.lblDeposit)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.lblTenant)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.dgvContracts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblTenant As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lblDeposit As Label
    Friend WithEvents lblMonthlyRent As Label
    Friend WithEvents lblNotes As Label
    Friend WithEvents cboTenant As ComboBox
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents txtMonthlyRent As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnAddContract As Button
    Friend WithEvents btnUpdateContract As Button
    Friend WithEvents btnDeleteContract As Button
    Friend WithEvents dgvContracts As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboRoom As ComboBox
End Class
