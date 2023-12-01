Imports MySql.Data.MySqlClient
Public Class frm_CancelOrder
    Private Sub frm_CancelOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        loadCancelOrder()
    End Sub

    Sub loadCancelOrder()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbl_pos` group by billno", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("billno"), dr.Item("billdate"), dr.Item("totalproductprice"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbl_pos` WHERE billno '%" & txtSearch.Text & "%' group by billno", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("billno"), dr.Item("billdate"), dr.Item("totalproductprice"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "ColDel" Then
            If MsgBox("Are You Sure Want Delete This Bill !", vbQuestion + vbYesNo) = vbYes Then
                Try
                    conn.Open()
                    cmd = New MySqlCommand("Delete From tbl_pos where billno='" & DataGridView1.CurrentRow.Cells(1).Value & "'", conn)
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MsgBox("Bill Delete Success !", vbInformation)
                    Else
                        MsgBox("Bill Delete Failed !", vbExclamation)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                conn.Close()
            Else
                Return
            End If

        End If
        loadCancelOrder()
    End Sub
End Class