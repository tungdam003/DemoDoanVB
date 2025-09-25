<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblRoomber = New System.Windows.Forms.Label()
        Me.txtRoomNumber = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtFloor = New System.Windows.Forms.TextBox()
        Me.lblFloor = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblRoomList = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvRooms = New System.Windows.Forms.DataGridView()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.btnOpenForm2 = New System.Windows.Forms.Button()
        Me.btnContracts = New System.Windows.Forms.Button()
        Me.btnInvoices = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(372, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quản lý phòng trọ"
        '
        'lblRoomber
        '
        Me.lblRoomber.AutoSize = True
        Me.lblRoomber.Location = New System.Drawing.Point(81, 64)
        Me.lblRoomber.Name = "lblRoomber"
        Me.lblRoomber.Size = New System.Drawing.Size(56, 13)
        Me.lblRoomber.TabIndex = 1
        Me.lblRoomber.Text = "Số phòng:"
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.Location = New System.Drawing.Point(137, 61)
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.Size = New System.Drawing.Size(67, 20)
        Me.txtRoomNumber.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(137, 92)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(132, 20)
        Me.txtPrice.TabIndex = 3
        '
        'txtFloor
        '
        Me.txtFloor.Location = New System.Drawing.Point(412, 57)
        Me.txtFloor.Name = "txtFloor"
        Me.txtFloor.Size = New System.Drawing.Size(66, 20)
        Me.txtFloor.TabIndex = 5
        '
        'lblFloor
        '
        Me.lblFloor.AutoSize = True
        Me.lblFloor.Location = New System.Drawing.Point(352, 61)
        Me.lblFloor.Name = "lblFloor"
        Me.lblFloor.Size = New System.Drawing.Size(35, 13)
        Me.lblFloor.TabIndex = 6
        Me.lblFloor.Text = "Tầng:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Giá thuê:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(329, 99)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(58, 13)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Trạng thái:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(81, 126)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(37, 13)
        Me.lblDescription.TabIndex = 9
        Me.lblDescription.Text = "Mô tả:"
        '
        'lblRoomList
        '
        Me.lblRoomList.AutoSize = True
        Me.lblRoomList.Location = New System.Drawing.Point(372, 169)
        Me.lblRoomList.Name = "lblRoomList"
        Me.lblRoomList.Size = New System.Drawing.Size(113, 13)
        Me.lblRoomList.TabIndex = 10
        Me.lblRoomList.Text = "Danh sách phòng       "
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(137, 126)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(603, 20)
        Me.txtDescription.TabIndex = 12
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(792, 21)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Thêm"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(792, 54)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Sửa"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(792, 88)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Xóa"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(792, 117)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dgvRooms
        '
        Me.dgvRooms.AccessibleName = "dgvRooms"
        Me.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRooms.Location = New System.Drawing.Point(30, 201)
        Me.dgvRooms.Name = "dgvRooms"
        Me.dgvRooms.Size = New System.Drawing.Size(722, 207)
        Me.dgvRooms.TabIndex = 17
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(412, 91)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(121, 21)
        Me.cboStatus.TabIndex = 18
        '
        'btnOpenForm2
        '
        Me.btnOpenForm2.Location = New System.Drawing.Point(782, 159)
        Me.btnOpenForm2.Name = "btnOpenForm2"
        Me.btnOpenForm2.Size = New System.Drawing.Size(99, 23)
        Me.btnOpenForm2.TabIndex = 19
        Me.btnOpenForm2.Text = "QL Khách thuê"
        Me.btnOpenForm2.UseVisualStyleBackColor = True
        '
        'btnContracts
        '
        Me.btnContracts.Location = New System.Drawing.Point(782, 188)
        Me.btnContracts.Name = "btnContracts"
        Me.btnContracts.Size = New System.Drawing.Size(99, 23)
        Me.btnContracts.TabIndex = 20
        Me.btnContracts.Text = "QL Hợp đồng"
        Me.btnContracts.UseVisualStyleBackColor = True
        '
        'btnInvoices
        '
        Me.btnInvoices.Location = New System.Drawing.Point(782, 217)
        Me.btnInvoices.Name = "btnInvoices"
        Me.btnInvoices.Size = New System.Drawing.Size(99, 23)
        Me.btnInvoices.TabIndex = 21
        Me.btnInvoices.Text = "QL Hóa đơn"
        Me.btnInvoices.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(782, 246)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(99, 23)
        Me.btnReport.TabIndex = 22
        Me.btnReport.Text = "Thống kê"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 420)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnInvoices)
        Me.Controls.Add(Me.btnContracts)
        Me.Controls.Add(Me.btnOpenForm2)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.dgvRooms)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblRoomList)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblFloor)
        Me.Controls.Add(Me.txtFloor)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtRoomNumber)
        Me.Controls.Add(Me.lblRoomber)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblRoomber As Label
    Friend WithEvents txtRoomNumber As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtFloor As TextBox
    Friend WithEvents lblFloor As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblRoomList As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvRooms As DataGridView
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btnOpenForm2 As Button
    Friend WithEvents btnContracts As Button
    Friend WithEvents btnInvoices As Button
    Friend WithEvents btnReport As Button
End Class
