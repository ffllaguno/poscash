Imports MySql.Data.MySqlClient
Public Class frm_addGroup
    Private Sub frm_addGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("INSERT INTO `tblgroup`(`progroup`) VALUES (@progroup)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@progroup", txtGroup.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Product Group Save Success !", vbInformation)
            Else
                MsgBox("New Product Group Save Failed !", vbInformation)
            End If
            txtGroup.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        frm_ManageProduct.load_ProductGroup()
    End Sub
End Class