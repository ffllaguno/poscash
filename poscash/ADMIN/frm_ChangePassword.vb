Imports MySql.Data.MySqlClient
Public Class frm_ChangePassword
    Private Sub frm_ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        If txtOldPassword.Text = String.Empty Then
            MsgBox("Pls Enter Your Old Password !", vbExclamation)
            Return

        ElseIf txtnewpassword.text = String.empty Or txtReEnterpassword.text = String.Empty Then
            MsgBox("Pls Enter Your New Password !", vbExclamation)
            Return

        ElseIf strComp(txtnewpassword.text, txtreenterpassword.text, comparemethod.binary) Then
            MsgBox("Password Does not Match !", vbExclamation)
            Return
        Else
            Try
                conn.Open()
                cmd = New MySqlCommand("UPDATE `tbluser` SET `password`=@password WHERE `password`=@password1", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@password", txtReEnterPassword.Text)
                cmd.Parameters.AddWithValue("@password1", txtOldPassword.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Password Change Success !", vbInformation)
                Else
                    MsgBox("Password Change Failed !", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        End If
        txtNewPassword.Clear()
        txtOldPassword.Clear()
        txtReEnterPassword.Clear()
        Me.Close()
        Form1.Show()


    End Sub
End Class