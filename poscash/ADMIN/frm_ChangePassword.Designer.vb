<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ChangePassword
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
        txtOldPassword = New TextBox()
        txtNewPassword = New TextBox()
        txtReEnterPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnChangePassword = New Button()
        SuspendLayout()
        ' 
        ' txtOldPassword
        ' 
        txtOldPassword.Location = New Point(233, 77)
        txtOldPassword.Name = "txtOldPassword"
        txtOldPassword.Size = New Size(125, 29)
        txtOldPassword.TabIndex = 0
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Location = New Point(233, 137)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.Size = New Size(125, 29)
        txtNewPassword.TabIndex = 1
        ' 
        ' txtReEnterPassword
        ' 
        txtReEnterPassword.Location = New Point(246, 208)
        txtReEnterPassword.Name = "txtReEnterPassword"
        txtReEnterPassword.Size = New Size(125, 29)
        txtReEnterPassword.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 21)
        Label1.TabIndex = 3
        Label1.Text = "enter your old password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(186, 21)
        Label2.TabIndex = 3
        Label2.Text = "enter your new password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(2, 216)
        Label3.Name = "Label3"
        Label3.Size = New Size(206, 21)
        Label3.TabIndex = 3
        Label3.Text = "re-enter your new password"
        ' 
        ' btnChangePassword
        ' 
        btnChangePassword.Location = New Point(222, 281)
        btnChangePassword.Name = "btnChangePassword"
        btnChangePassword.Size = New Size(187, 29)
        btnChangePassword.TabIndex = 4
        btnChangePassword.Text = "change password"
        btnChangePassword.UseVisualStyleBackColor = True
        ' 
        ' frm_ChangePassword
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnChangePassword)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtReEnterPassword)
        Controls.Add(txtNewPassword)
        Controls.Add(txtOldPassword)
        Name = "frm_ChangePassword"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ChangePassword"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtOldPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtReEnterPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnChangePassword As Button
End Class
