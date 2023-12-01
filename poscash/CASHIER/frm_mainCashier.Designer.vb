<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainCashier
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        lblLoginUser = New Label()
        lblTime = New Label()
        lblLoginTime = New Label()
        Panel2 = New Panel()
        lblDate = New Label()
        txtSearchProductBarCode = New TextBox()
        txtBillNo = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        btpBillDate = New DateTimePicker()
        TableLayoutPanel1 = New TableLayoutPanel()
        btnNew = New Button()
        btnCancel = New Button()
        btnReport = New Button()
        btnRemove = New Button()
        btnChangePass = New Button()
        btnLogout = New Button()
        Panel3 = New Panel()
        lblChange = New Label()
        cmbPaymentMode = New ComboBox()
        lblTotalPrice = New Label()
        lblNoOfItems = New Label()
        txtAmountReceived = New TextBox()
        Label7 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        btnPay = New Button()
        lblOverAllGrandTotal = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblLoginUser)
        Panel1.Controls.Add(lblTime)
        Panel1.Controls.Add(lblLoginTime)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1401, 109)
        Panel1.TabIndex = 0
        ' 
        ' lblLoginUser
        ' 
        lblLoginUser.AutoSize = True
        lblLoginUser.Location = New Point(873, 37)
        lblLoginUser.Name = "lblLoginUser"
        lblLoginUser.Size = New Size(56, 21)
        lblLoginUser.TabIndex = 4
        lblLoginUser.Text = "Label4"
        ' 
        ' lblTime
        ' 
        lblTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTime.ForeColor = Color.Red
        lblTime.Location = New Point(1099, 37)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(290, 26)
        lblTime.TabIndex = 20
        lblTime.Text = "00.00"
        lblTime.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblLoginTime
        ' 
        lblLoginTime.AutoSize = True
        lblLoginTime.Location = New Point(873, 70)
        lblLoginTime.Name = "lblLoginTime"
        lblLoginTime.Size = New Size(56, 21)
        lblLoginTime.TabIndex = 5
        lblLoginTime.Text = "Label8"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lblDate)
        Panel2.Controls.Add(txtSearchProductBarCode)
        Panel2.Controls.Add(txtBillNo)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(btpBillDate)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 109)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1401, 118)
        Panel2.TabIndex = 1
        ' 
        ' lblDate
        ' 
        lblDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDate.ForeColor = Color.Blue
        lblDate.Location = New Point(1099, 26)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(290, 26)
        lblDate.TabIndex = 20
        lblDate.Text = "00.00"
        lblDate.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtSearchProductBarCode
        ' 
        txtSearchProductBarCode.Location = New Point(169, 73)
        txtSearchProductBarCode.Name = "txtSearchProductBarCode"
        txtSearchProductBarCode.Size = New Size(659, 29)
        txtSearchProductBarCode.TabIndex = 3
        ' 
        ' txtBillNo
        ' 
        txtBillNo.Location = New Point(169, 22)
        txtBillNo.Name = "txtBillNo"
        txtBillNo.Size = New Size(241, 29)
        txtBillNo.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 21)
        Label2.TabIndex = 1
        Label2.Text = "Product / Barcode"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(447, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 21)
        Label3.TabIndex = 1
        Label3.Text = "Bill Date:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(88, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 21)
        Label1.TabIndex = 1
        Label1.Text = "Bill NO:"
        ' 
        ' btpBillDate
        ' 
        btpBillDate.Format = DateTimePickerFormat.Short
        btpBillDate.Location = New Point(523, 22)
        btpBillDate.Name = "btpBillDate"
        btpBillDate.Size = New Size(176, 29)
        btpBillDate.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 6
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.6666641F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.6666641F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Controls.Add(btnNew, 0, 0)
        TableLayoutPanel1.Controls.Add(btnCancel, 1, 0)
        TableLayoutPanel1.Controls.Add(btnReport, 2, 0)
        TableLayoutPanel1.Controls.Add(btnRemove, 3, 0)
        TableLayoutPanel1.Controls.Add(btnChangePass, 4, 0)
        TableLayoutPanel1.Controls.Add(btnLogout, 5, 0)
        TableLayoutPanel1.Dock = DockStyle.Bottom
        TableLayoutPanel1.Location = New Point(0, 629)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1401, 59)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' btnNew
        ' 
        btnNew.Cursor = Cursors.Hand
        btnNew.Dock = DockStyle.Fill
        btnNew.Location = New Point(3, 3)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(227, 53)
        btnNew.TabIndex = 4
        btnNew.Text = " [ F1 - NEW ]"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Dock = DockStyle.Fill
        btnCancel.Location = New Point(236, 3)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(227, 53)
        btnCancel.TabIndex = 5
        btnCancel.Text = "[ F2 - CANCEL]"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnReport
        ' 
        btnReport.Dock = DockStyle.Fill
        btnReport.Location = New Point(469, 3)
        btnReport.Name = "btnReport"
        btnReport.Size = New Size(227, 53)
        btnReport.TabIndex = 7
        btnReport.Text = "[ F4 - REPORT]"
        btnReport.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Dock = DockStyle.Fill
        btnRemove.Location = New Point(702, 3)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(227, 53)
        btnRemove.TabIndex = 8
        btnRemove.Text = "[ F5 - REMOVE]"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnChangePass
        ' 
        btnChangePass.Dock = DockStyle.Fill
        btnChangePass.Location = New Point(935, 3)
        btnChangePass.Name = "btnChangePass"
        btnChangePass.Size = New Size(227, 53)
        btnChangePass.TabIndex = 9
        btnChangePass.Text = "[ F6 - CHANGE PASSWORD]"
        btnChangePass.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Dock = DockStyle.Fill
        btnLogout.Location = New Point(1168, 3)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(230, 53)
        btnLogout.TabIndex = 10
        btnLogout.Text = "[ F7 - LOGOUT]"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(lblChange)
        Panel3.Controls.Add(cmbPaymentMode)
        Panel3.Controls.Add(lblTotalPrice)
        Panel3.Controls.Add(lblNoOfItems)
        Panel3.Controls.Add(txtAmountReceived)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(btnPay)
        Panel3.Controls.Add(lblOverAllGrandTotal)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(1074, 227)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(327, 402)
        Panel3.TabIndex = 3
        ' 
        ' lblChange
        ' 
        lblChange.ForeColor = Color.Black
        lblChange.Location = New Point(164, 307)
        lblChange.Name = "lblChange"
        lblChange.Size = New Size(147, 26)
        lblChange.TabIndex = 19
        lblChange.Text = "00.00"
        lblChange.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' cmbPaymentMode
        ' 
        cmbPaymentMode.FormattingEnabled = True
        cmbPaymentMode.Items.AddRange(New Object() {"CASH", "DIGITAL WALLET"})
        cmbPaymentMode.Location = New Point(164, 199)
        cmbPaymentMode.Name = "cmbPaymentMode"
        cmbPaymentMode.Size = New Size(151, 29)
        cmbPaymentMode.TabIndex = 18
        ' 
        ' lblTotalPrice
        ' 
        lblTotalPrice.ForeColor = Color.Black
        lblTotalPrice.Location = New Point(168, 119)
        lblTotalPrice.Name = "lblTotalPrice"
        lblTotalPrice.Size = New Size(147, 26)
        lblTotalPrice.TabIndex = 17
        lblTotalPrice.Text = "00.00"
        lblTotalPrice.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblNoOfItems
        ' 
        lblNoOfItems.ForeColor = Color.Black
        lblNoOfItems.Location = New Point(168, 71)
        lblNoOfItems.Name = "lblNoOfItems"
        lblNoOfItems.Size = New Size(147, 26)
        lblNoOfItems.TabIndex = 16
        lblNoOfItems.Text = "00.00"
        lblNoOfItems.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtAmountReceived
        ' 
        txtAmountReceived.Location = New Point(165, 250)
        txtAmountReceived.Name = "txtAmountReceived"
        txtAmountReceived.Size = New Size(125, 29)
        txtAmountReceived.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(33, 307)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 21)
        Label7.TabIndex = 9
        Label7.Text = "Change"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(24, 253)
        Label11.Name = "Label11"
        Label11.Size = New Size(132, 21)
        Label11.TabIndex = 8
        Label11.Text = "Amount Received"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(33, 199)
        Label10.Name = "Label10"
        Label10.Size = New Size(114, 21)
        Label10.TabIndex = 7
        Label10.Text = "Payment Mode"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(33, 124)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 21)
        Label6.TabIndex = 3
        Label6.Text = "Total Price"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(33, 76)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 21)
        Label5.TabIndex = 2
        Label5.Text = "No of items"
        ' 
        ' btnPay
        ' 
        btnPay.Dock = DockStyle.Bottom
        btnPay.Location = New Point(0, 357)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(327, 45)
        btnPay.TabIndex = 1
        btnPay.Text = "[ F9 - PAY]"
        btnPay.UseVisualStyleBackColor = True
        ' 
        ' lblOverAllGrandTotal
        ' 
        lblOverAllGrandTotal.ForeColor = Color.Blue
        lblOverAllGrandTotal.Location = New Point(25, 13)
        lblOverAllGrandTotal.Name = "lblOverAllGrandTotal"
        lblOverAllGrandTotal.Size = New Size(290, 26)
        lblOverAllGrandTotal.TabIndex = 0
        lblOverAllGrandTotal.Text = "00.00"
        lblOverAllGrandTotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Price, Column5, Column6})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 227)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 31
        DataGridView1.Size = New Size(1074, 402)
        DataGridView1.TabIndex = 4
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "#"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 48
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "Product Code"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 122
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Product Name"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Product Group"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 129
        ' 
        ' Price
        ' 
        Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Price.HeaderText = "Product Price"
        Price.MinimumWidth = 6
        Price.Name = "Price"
        Price.ReadOnly = True
        Price.Width = 120
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Qty"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 64
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Total Price"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 101
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        ' 
        ' frm_mainCashier
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1401, 688)
        Controls.Add(DataGridView1)
        Controls.Add(Panel3)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "frm_mainCashier"
        StartPosition = FormStartPosition.CenterScreen
        Text = "POS and Inventory Management System"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btpBillDate As DateTimePicker
    Friend WithEvents txtSearchProductBarCode As TextBox
    Friend WithEvents txtBillNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnChangePass As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblOverAllGrandTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtAmountReceived As TextBox
    Friend WithEvents lblNoOfItems As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents cmbPaymentMode As ComboBox
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents lblLoginTime As Label
    Friend WithEvents lblLoginUser As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Timer2 As Timer
End Class
