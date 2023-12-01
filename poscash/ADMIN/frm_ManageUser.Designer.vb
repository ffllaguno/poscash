<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ManageUser
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
        txtName = New TextBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        cmbRole = New ComboBox()
        btnRegister = New Button()
        btnCancel = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(284, 74)
        txtName.Name = "txtName"
        txtName.Size = New Size(151, 29)
        txtName.TabIndex = 0
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(284, 135)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(151, 29)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(284, 199)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(151, 29)
        txtPassword.TabIndex = 2
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"ADMIN", "CASHIER"})
        cmbRole.Location = New Point(284, 246)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(151, 29)
        cmbRole.TabIndex = 4
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(240, 332)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(94, 29)
        btnRegister.TabIndex = 5
        btnRegister.Text = "register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(382, 332)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 29)
        btnCancel.TabIndex = 6
        btnCancel.Text = "cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(199, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 21)
        Label1.TabIndex = 7
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(199, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 21)
        Label2.TabIndex = 7
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(199, 199)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 21)
        Label3.TabIndex = 7
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(199, 249)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 21)
        Label4.TabIndex = 7
        Label4.Text = "Role"
        ' 
        ' frm_ManageUser
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCancel)
        Controls.Add(btnRegister)
        Controls.Add(cmbRole)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(txtName)
        Name = "frm_ManageUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frm_ManageUser"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
