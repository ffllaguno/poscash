Imports MySql.Data.MySqlClient
Module dbconnection
    Public conn As New MySqlConnection
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public dr As MySqlDataReader
    Public i As Integer

    Public Function dbconn() As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=localhost;username=root;password=;port=3306;database=db_pos"
                result = True
            End If
        Catch ex As Exception
            result = False
            MsgBox("Server Not Connected ! ", vbExclamation)
        End Try
        Return result
    End Function

    Public Function getbillno() As String
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbl_pos` WHERE `billno` order by id desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                getbillno = CLng(dr.Item("billno").ToString) + 1
            Else
                getbillno = Date.Now.ToString("yyyy") & "1"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Function
End Module
