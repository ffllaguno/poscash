<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ManageProduct
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
        Panel1 = New Panel()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        DataGridView2 = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn7 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn9 = New DataGridViewTextBoxColumn()
        DataGridViewImageColumn1 = New DataGridViewImageColumn()
        Panel2 = New Panel()
        Label10 = New Label()
        txtSearch = New TextBox()
        TabPage2 = New TabPage()
        btnAddGroup = New Button()
        Label7 = New Label()
        Label9 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        label3 = New Label()
        label2 = New Label()
        Label1 = New Label()
        btnClear = New Button()
        btnDelete = New Button()
        btnEdit = New Button()
        btnSave = New Button()
        picBarCode = New PictureBox()
        txtPrice = New TextBox()
        cmbGroup = New ComboBox()
        txtLocation = New TextBox()
        txtProName = New TextBox()
        txtProCode = New TextBox()
        btnSearch = New Button()
        txtSearchProduct = New TextBox()
        MySqlDataAdapter1 = New MySqlConnector.MySqlDataAdapter()
        Label4 = New Label()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(picBarCode, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label4)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1200, 80)
        Panel1.TabIndex = 0
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 80)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1200, 560)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(DataGridView2)
        TabPage1.Controls.Add(Panel2)
        TabPage1.Location = New Point(4, 30)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1192, 526)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Product List"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn6, DataGridViewTextBoxColumn7, DataGridViewTextBoxColumn9, DataGridViewImageColumn1})
        DataGridView2.Dock = DockStyle.Fill
        DataGridView2.Location = New Point(3, 76)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersVisible = False
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 31
        DataGridView2.Size = New Size(1186, 447)
        DataGridView2.TabIndex = 2
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn1.HeaderText = "#"
        DataGridViewTextBoxColumn1.MinimumWidth = 6
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        DataGridViewTextBoxColumn1.Width = 48
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn2.HeaderText = "PRO CODE"
        DataGridViewTextBoxColumn2.MinimumWidth = 6
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        DataGridViewTextBoxColumn2.Width = 115
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn3.HeaderText = "PRODUCT NAME"
        DataGridViewTextBoxColumn3.MinimumWidth = 6
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn4.HeaderText = "GROUP"
        DataGridViewTextBoxColumn4.MinimumWidth = 6
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.ReadOnly = True
        DataGridViewTextBoxColumn4.Width = 92
        ' 
        ' DataGridViewTextBoxColumn6
        ' 
        DataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn6.HeaderText = "LOCATION"
        DataGridViewTextBoxColumn6.MinimumWidth = 6
        DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        DataGridViewTextBoxColumn6.ReadOnly = True
        DataGridViewTextBoxColumn6.Width = 113
        ' 
        ' DataGridViewTextBoxColumn7
        ' 
        DataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn7.HeaderText = "PRICE"
        DataGridViewTextBoxColumn7.MinimumWidth = 6
        DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        DataGridViewTextBoxColumn7.ReadOnly = True
        DataGridViewTextBoxColumn7.Width = 80
        ' 
        ' DataGridViewTextBoxColumn9
        ' 
        DataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn9.HeaderText = "STOCK"
        DataGridViewTextBoxColumn9.MinimumWidth = 6
        DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        DataGridViewTextBoxColumn9.ReadOnly = True
        DataGridViewTextBoxColumn9.Visible = False
        DataGridViewTextBoxColumn9.Width = 125
        ' 
        ' DataGridViewImageColumn1
        ' 
        DataGridViewImageColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewImageColumn1.HeaderText = "BARCODE"
        DataGridViewImageColumn1.MinimumWidth = 6
        DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        DataGridViewImageColumn1.ReadOnly = True
        DataGridViewImageColumn1.Resizable = DataGridViewTriState.True
        DataGridViewImageColumn1.SortMode = DataGridViewColumnSortMode.Automatic
        DataGridViewImageColumn1.Visible = False
        DataGridViewImageColumn1.Width = 125
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(txtSearch)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1186, 73)
        Panel2.TabIndex = 0
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(158, 34)
        Label10.Name = "Label10"
        Label10.Size = New Size(61, 21)
        Label10.TabIndex = 18
        Label10.Text = "Search "
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(245, 31)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(666, 29)
        txtSearch.TabIndex = 17
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btnAddGroup)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(label3)
        TabPage2.Controls.Add(label2)
        TabPage2.Controls.Add(Label1)
        TabPage2.Controls.Add(btnClear)
        TabPage2.Controls.Add(btnDelete)
        TabPage2.Controls.Add(btnEdit)
        TabPage2.Controls.Add(btnSave)
        TabPage2.Controls.Add(picBarCode)
        TabPage2.Controls.Add(txtPrice)
        TabPage2.Controls.Add(cmbGroup)
        TabPage2.Controls.Add(txtLocation)
        TabPage2.Controls.Add(txtProName)
        TabPage2.Controls.Add(txtProCode)
        TabPage2.Controls.Add(btnSearch)
        TabPage2.Controls.Add(txtSearchProduct)
        TabPage2.Location = New Point(4, 30)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1192, 526)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Manage Product"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnAddGroup
        ' 
        btnAddGroup.Location = New Point(321, 252)
        btnAddGroup.Name = "btnAddGroup"
        btnAddGroup.Size = New Size(64, 29)
        btnAddGroup.TabIndex = 17
        btnAddGroup.Text = "+"
        btnAddGroup.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(121, 7)
        Label7.Name = "Label7"
        Label7.Size = New Size(155, 21)
        Label7.TabIndex = 16
        Label7.Text = "Search Product Code"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(623, 288)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 21)
        Label9.TabIndex = 15
        Label9.Text = "Barcode"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(623, 111)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 21)
        Label6.TabIndex = 15
        Label6.Text = "Price"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(110, 384)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 21)
        Label5.TabIndex = 15
        Label5.Text = "Location"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(116, 224)
        label3.Name = "label3"
        label3.Size = New Size(112, 21)
        label3.TabIndex = 15
        label3.Text = "Product Group"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(121, 151)
        label2.Name = "label2"
        label2.Size = New Size(110, 21)
        label2.TabIndex = 15
        label2.Text = "Product Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(118, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 21)
        Label1.TabIndex = 15
        Label1.Text = "Product Code"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(558, 461)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 14
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(441, 461)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 13
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(291, 474)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(94, 29)
        btnEdit.TabIndex = 12
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(134, 474)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 11
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' picBarCode
        ' 
        picBarCode.BorderStyle = BorderStyle.FixedSingle
        picBarCode.Location = New Point(628, 310)
        picBarCode.Name = "picBarCode"
        picBarCode.Size = New Size(193, 62)
        picBarCode.SizeMode = PictureBoxSizeMode.StretchImage
        picBarCode.TabIndex = 9
        picBarCode.TabStop = False
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(623, 135)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(156, 29)
        txtPrice.TabIndex = 8
        ' 
        ' cmbGroup
        ' 
        cmbGroup.FormattingEnabled = True
        cmbGroup.Location = New Point(116, 252)
        cmbGroup.Name = "cmbGroup"
        cmbGroup.Size = New Size(183, 29)
        cmbGroup.TabIndex = 5
        ' 
        ' txtLocation
        ' 
        txtLocation.Location = New Point(110, 408)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(174, 29)
        txtLocation.TabIndex = 4
        ' 
        ' txtProName
        ' 
        txtProName.Location = New Point(117, 175)
        txtProName.Name = "txtProName"
        txtProName.Size = New Size(191, 29)
        txtProName.TabIndex = 3
        ' 
        ' txtProCode
        ' 
        txtProCode.Location = New Point(118, 103)
        txtProCode.Name = "txtProCode"
        txtProCode.Size = New Size(191, 29)
        txtProCode.TabIndex = 2
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(816, 38)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 29)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearchProduct
        ' 
        txtSearchProduct.Location = New Point(118, 31)
        txtSearchProduct.Name = "txtSearchProduct"
        txtSearchProduct.Size = New Size(666, 29)
        txtSearchProduct.TabIndex = 0
        ' 
        ' MySqlDataAdapter1
        ' 
        MySqlDataAdapter1.DeleteCommand = Nothing
        MySqlDataAdapter1.InsertCommand = Nothing
        MySqlDataAdapter1.SelectCommand = Nothing
        MySqlDataAdapter1.UpdateBatchSize = 0
        MySqlDataAdapter1.UpdateCommand = Nothing
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(32, 34)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 21)
        Label4.TabIndex = 0
        Label4.Text = "Manage Product"
        ' 
        ' frm_ManageProduct
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 640)
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        Name = "frm_ManageProduct"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManageProduct"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(picBarCode, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MySqlDataAdapter1 As MySqlConnector.MySqlDataAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cmbGroup As ComboBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtProName As TextBox
    Friend WithEvents txtProCode As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearchProduct As TextBox
    Friend WithEvents picBarCode As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAddGroup As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Label4 As Label
End Class
