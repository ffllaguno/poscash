<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmr_mainAdmin
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
        TableLayoutPanel1 = New TableLayoutPanel()
        btnLogout = New Button()
        btnManageProduct = New Button()
        btnReport = New Button()
        btnManageStock = New Button()
        btnManageUsers = New Button()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1311, 125)
        Panel1.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Controls.Add(btnLogout, 4, 0)
        TableLayoutPanel1.Controls.Add(btnManageProduct, 0, 0)
        TableLayoutPanel1.Controls.Add(btnReport, 3, 0)
        TableLayoutPanel1.Controls.Add(btnManageStock, 1, 0)
        TableLayoutPanel1.Controls.Add(btnManageUsers, 2, 0)
        TableLayoutPanel1.Location = New Point(608, 12)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(691, 103)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' btnLogout
        ' 
        btnLogout.Dock = DockStyle.Fill
        btnLogout.Location = New Point(555, 3)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(133, 97)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnManageProduct
        ' 
        btnManageProduct.Cursor = Cursors.Hand
        btnManageProduct.Dock = DockStyle.Fill
        btnManageProduct.Location = New Point(3, 3)
        btnManageProduct.Name = "btnManageProduct"
        btnManageProduct.Size = New Size(132, 97)
        btnManageProduct.TabIndex = 1
        btnManageProduct.Text = "Manage Product"
        btnManageProduct.UseVisualStyleBackColor = True
        ' 
        ' btnReport
        ' 
        btnReport.Dock = DockStyle.Fill
        btnReport.Location = New Point(417, 3)
        btnReport.Name = "btnReport"
        btnReport.Size = New Size(132, 97)
        btnReport.TabIndex = 3
        btnReport.Text = "Report"
        btnReport.UseVisualStyleBackColor = True
        ' 
        ' btnManageStock
        ' 
        btnManageStock.Dock = DockStyle.Fill
        btnManageStock.Location = New Point(141, 3)
        btnManageStock.Name = "btnManageStock"
        btnManageStock.Size = New Size(132, 97)
        btnManageStock.TabIndex = 1
        btnManageStock.Text = "Manage Stock"
        btnManageStock.TextAlign = ContentAlignment.MiddleRight
        btnManageStock.UseVisualStyleBackColor = True
        ' 
        ' btnManageUsers
        ' 
        btnManageUsers.Dock = DockStyle.Fill
        btnManageUsers.Location = New Point(279, 3)
        btnManageUsers.Name = "btnManageUsers"
        btnManageUsers.Size = New Size(132, 97)
        btnManageUsers.TabIndex = 2
        btnManageUsers.Text = "Manage Users"
        btnManageUsers.UseVisualStyleBackColor = True
        ' 
        ' fmr_mainAdmin
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1311, 720)
        Controls.Add(Panel1)
        Name = "fmr_mainAdmin"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "POS and Inventory System"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnManageProduct As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnManageStock As Button
    Friend WithEvents btnManageUsers As Button
End Class
