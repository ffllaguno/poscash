Imports MySql.Data.MySqlClient

Public Class Form1
    Dim name As String
    Dim username As String
    Dim password As String
    Dim role As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            conn.Open()
            Dim found As Boolean = False
            cmd = New MySqlCommand("SELECT * FROM `tbluser` WHERE `username`='" & txtUsername.Text & "' AND `password`='" & txtPassword.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                found = True
                name = dr.Item("name").ToString
                username = dr.Item("username").ToString
                password = dr.Item("password").ToString
                role = dr.Item("role").ToString
            Else
                found = False
                name = ""
                username = ""
                password = ""
                role = ""

            End If
            If found = True Then
                If StrComp(txtUsername.Text, username, CompareMethod.Binary) Or StrComp(txtPassword.Text, password, CompareMethod.Binary) Then
                    MsgBox("Warning: Wrong Username or Password !", vbExclamation)
                    Return
                Else
                    If UCase(role) = "ADMIN" Then
                        Me.Hide()
                        fmr_mainAdmin.Show()
                    ElseIf UCase(role) = "CASHIER" Then
                        Me.Hide()
                        frm_mainCashier.Show()
                    End If
                End If
            Else

                MsgBox("Warning: Wrong Username or Password !", vbExclamation)

            End If
            txtPassword.Clear()
            txtUsername.Clear()
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure you want to Exit?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub
End Class
