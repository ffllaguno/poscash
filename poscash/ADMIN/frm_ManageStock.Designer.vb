<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ManageStock
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
        Label1 = New Label()
        Panel2 = New Panel()
        BTN_UpdateStock = New Button()
        Label10 = New Label()
        txtSearch = New TextBox()
        DataGridView2 = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn7 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn9 = New DataGridViewTextBoxColumn()
        DataGridViewImageColumn1 = New DataGridViewImageColumn()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 57)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 21)
        Label1.TabIndex = 0
        Label1.Text = "Manage Stock"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(BTN_UpdateStock)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(txtSearch)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 57)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(800, 64)
        Panel2.TabIndex = 1
        ' 
        ' BTN_UpdateStock
        ' 
        BTN_UpdateStock.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BTN_UpdateStock.BackColor = SystemColors.HotTrack
        BTN_UpdateStock.Cursor = Cursors.Hand
        BTN_UpdateStock.FlatAppearance.BorderSize = 0
        BTN_UpdateStock.FlatStyle = FlatStyle.Flat
        BTN_UpdateStock.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BTN_UpdateStock.ForeColor = Color.White
        BTN_UpdateStock.Location = New Point(628, 18)
        BTN_UpdateStock.Name = "BTN_UpdateStock"
        BTN_UpdateStock.Size = New Size(151, 29)
        BTN_UpdateStock.TabIndex = 21
        BTN_UpdateStock.Text = "UPDATE STOCK"
        BTN_UpdateStock.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(24, 21)
        Label10.Name = "Label10"
        Label10.Size = New Size(61, 21)
        Label10.TabIndex = 20
        Label10.Text = "Search "
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(111, 18)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(209, 29)
        txtSearch.TabIndex = 19
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn6, DataGridViewTextBoxColumn7, DataGridViewTextBoxColumn9, DataGridViewImageColumn1})
        DataGridView2.Dock = DockStyle.Fill
        DataGridView2.Location = New Point(0, 121)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersVisible = False
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 31
        DataGridView2.Size = New Size(800, 329)
        DataGridView2.TabIndex = 3
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn1.HeaderText = "#"
        DataGridViewTextBoxColumn1.MinimumWidth = 6
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.Width = 48
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn2.HeaderText = "PRO CODE"
        DataGridViewTextBoxColumn2.MinimumWidth = 6
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.Width = 106
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn3.HeaderText = "PRODUCT NAME"
        DataGridViewTextBoxColumn3.MinimumWidth = 6
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn4.HeaderText = "GROUP"
        DataGridViewTextBoxColumn4.MinimumWidth = 6
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.Width = 92
        ' 
        ' DataGridViewTextBoxColumn6
        ' 
        DataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn6.HeaderText = "LOCATION"
        DataGridViewTextBoxColumn6.MinimumWidth = 6
        DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        DataGridViewTextBoxColumn6.Width = 113
        ' 
        ' DataGridViewTextBoxColumn7
        ' 
        DataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn7.HeaderText = "PRICE"
        DataGridViewTextBoxColumn7.MinimumWidth = 6
        DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        DataGridViewTextBoxColumn7.Width = 80
        ' 
        ' DataGridViewTextBoxColumn9
        ' 
        DataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn9.HeaderText = "STOCK"
        DataGridViewTextBoxColumn9.MinimumWidth = 6
        DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        DataGridViewTextBoxColumn9.Width = 86
        ' 
        ' DataGridViewImageColumn1
        ' 
        DataGridViewImageColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewImageColumn1.HeaderText = "BARCODE"
        DataGridViewImageColumn1.MinimumWidth = 6
        DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        DataGridViewImageColumn1.Resizable = DataGridViewTriState.True
        DataGridViewImageColumn1.SortMode = DataGridViewColumnSortMode.Automatic
        DataGridViewImageColumn1.Visible = False
        DataGridViewImageColumn1.Width = 125
        ' 
        ' frm_ManageStock
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "frm_ManageStock"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manage Stock"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_UpdateStock As Button
End Class
