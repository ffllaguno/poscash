Imports MySql.Data.MySqlClient
Public Class frm_ManageStock

    Dim j As Integer
    Private Sub frm_ManageStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView2.RowTemplate.Height = 30
        Load_Stock()
    End Sub

    Sub Load_Stock()
        DataGridView2.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `procode`, `proname`, `progroup`, `location`, `price`, `stock` FROM `tblproduct`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView2.Rows.Add(DataGridView2.Rows.Count + 1, dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("location"), dr.Item("price"), dr.Item("stock"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        DataGridView2.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `procode`, `proname`, `progroup`, `location`, `price`, `stock` FROM `tblproduct` WHERE procode like '%" & txtSearch.Text & "%' or proname like '%" & txtSearch.Text & "%' or progroup like '%" & txtSearch.Text & "%' or location like '%" & txtSearch.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView2.Rows.Add(DataGridView2.Rows.Count + 1, dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("location"), dr.Item("price"), dr.Item("stock"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub BTN_UpdateStock_Click(sender As Object, e As EventArgs) Handles BTN_UpdateStock.Click
        Try
            conn.Open()



            For j As Integer = 0 To DataGridView2.Rows.Count - 1 Step +1
                cmd = New MySqlCommand("UPDATE `tblproduct` SET `stock`=@stock WHERE `procode`=@procode", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@stock", DataGridView2.Rows(j).Cells(6).Value.ToString)
                cmd.Parameters.AddWithValue("@procode", DataGridView2.Rows(j).Cells(1).Value.ToString)
                i = cmd.ExecuteNonQuery

            Next
            If i > 0 Then
                MsgBox("Stock Update Successfully!", vbInformation)
            Else
                MsgBox("Stock Update Failed!", vbCritical)


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        Load_Stock()
    End Sub
End Class