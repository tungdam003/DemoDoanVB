<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.lblRevenueTitle = New System.Windows.Forms.Label()
        Me.lblRevenueValue = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnViewRevenue = New System.Windows.Forms.Button()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.grpEmptyRooms = New System.Windows.Forms.GroupBox()
        Me.btnViewEmptyRooms = New System.Windows.Forms.Button()
        Me.dgvEmptyRooms = New System.Windows.Forms.DataGridView()
        Me.grpRevenue = New System.Windows.Forms.GroupBox()
        CType(Me.dgvEmptyRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 329)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tháng:"
        '
        'lblRevenueTitle
        '
        Me.lblRevenueTitle.AutoSize = True
        Me.lblRevenueTitle.Location = New System.Drawing.Point(31, 390)
        Me.lblRevenueTitle.Name = "lblRevenueTitle"
        Me.lblRevenueTitle.Size = New System.Drawing.Size(86, 13)
        Me.lblRevenueTitle.TabIndex = 1
        Me.lblRevenueTitle.Text = "Tổng doanh thu:"
        '
        'lblRevenueValue
        '
        Me.lblRevenueValue.AutoSize = True
        Me.lblRevenueValue.Location = New System.Drawing.Point(219, 390)
        Me.lblRevenueValue.Name = "lblRevenueValue"
        Me.lblRevenueValue.Size = New System.Drawing.Size(30, 13)
        Me.lblRevenueValue.TabIndex = 2
        Me.lblRevenueValue.Text = "VNĐ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(310, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = " Thống kê – Báo cáo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(204, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Năm:"
        '
        'btnViewRevenue
        '
        Me.btnViewRevenue.Location = New System.Drawing.Point(379, 324)
        Me.btnViewRevenue.Name = "btnViewRevenue"
        Me.btnViewRevenue.Size = New System.Drawing.Size(116, 23)
        Me.btnViewRevenue.TabIndex = 5
        Me.btnViewRevenue.Text = "Xem"
        Me.btnViewRevenue.UseVisualStyleBackColor = True
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(242, 325)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 8
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(79, 328)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(100, 20)
        Me.txtMonth.TabIndex = 9
        '
        'grpEmptyRooms
        '
        Me.grpEmptyRooms.Location = New System.Drawing.Point(25, 56)
        Me.grpEmptyRooms.Name = "grpEmptyRooms"
        Me.grpEmptyRooms.Size = New System.Drawing.Size(599, 173)
        Me.grpEmptyRooms.TabIndex = 11
        Me.grpEmptyRooms.TabStop = False
        Me.grpEmptyRooms.Text = "DANH SÁCH PHÒNG TRỐNG"
        '
        'btnViewEmptyRooms
        '
        Me.btnViewEmptyRooms.Location = New System.Drawing.Point(25, 127)
        Me.btnViewEmptyRooms.Name = "btnViewEmptyRooms"
        Me.btnViewEmptyRooms.Size = New System.Drawing.Size(117, 23)
        Me.btnViewEmptyRooms.TabIndex = 12
        Me.btnViewEmptyRooms.Text = "Xem phòng trống"
        Me.btnViewEmptyRooms.UseVisualStyleBackColor = True
        '
        'dgvEmptyRooms
        '
        Me.dgvEmptyRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmptyRooms.Location = New System.Drawing.Point(134, 127)
        Me.dgvEmptyRooms.Name = "dgvEmptyRooms"
        Me.dgvEmptyRooms.Size = New System.Drawing.Size(490, 102)
        Me.dgvEmptyRooms.TabIndex = 13
        '
        'grpRevenue
        '
        Me.grpRevenue.Location = New System.Drawing.Point(25, 277)
        Me.grpRevenue.Name = "grpRevenue"
        Me.grpRevenue.Size = New System.Drawing.Size(590, 42)
        Me.grpRevenue.TabIndex = 14
        Me.grpRevenue.TabStop = False
        Me.grpRevenue.Text = "Doanh thu"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 450)
        Me.Controls.Add(Me.grpRevenue)
        Me.Controls.Add(Me.dgvEmptyRooms)
        Me.Controls.Add(Me.btnViewEmptyRooms)
        Me.Controls.Add(Me.grpEmptyRooms)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.btnViewRevenue)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblRevenueValue)
        Me.Controls.Add(Me.lblRevenueTitle)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.dgvEmptyRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblRevenueTitle As Label
    Friend WithEvents lblRevenueValue As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnViewRevenue As Button
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents grpEmptyRooms As GroupBox
    Friend WithEvents btnViewEmptyRooms As Button
    Friend WithEvents dgvEmptyRooms As DataGridView
    Friend WithEvents grpRevenue As GroupBox
End Class
