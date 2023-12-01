Imports MySql.Data.MySqlClient
Public Class frm_ManageUser
    Private Sub frm_ManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub
    Sub clear()
        txtName.Clear()
        txtPassword.Clear()
        txtUsername.Clear()
        cmbRole.SelectedIndex = -1

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        fmr_mainAdmin.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("INSERT INTO `tbluser`(`name`, `username`, `password`, `role`) VALUES (@name,@username,@password,@role)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@name", txtName.Text)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@role", cmbRole.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New User Register Success !", vbInformation)
            Else
                MsgBox("New User Register Failed !", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
    End Sub
End Class