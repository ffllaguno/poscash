Imports MySql.Data.MySqlClient
Imports System.IO
Imports MessagingToolkit.Barcode

Public Class frm_ManageProduct
    Private Sub frm_ManageProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

        DataGridView2.RowTemplate.Height = 30

        load_ProductGroup()
        load_product()
    End Sub
    Private Sub btnAddGroup_Click(sender As Object, e As EventArgs) Handles btnAddGroup.Click
        frm_addGroup.ShowDialog()
    End Sub

    Sub load_ProductGroup()
        cmbGroup.Items.Clear()
        Try

            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tblgroup`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                cmbGroup.Items.Add(dr.Item("progroup").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub

    Sub load_product()
        DataGridView2.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT  `procode`, `proname`, `progroup`,`location`, `price`, `stock`, `barcode` FROM `tblproduct`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView2.Rows.Add(DataGridView2.Rows.Count + 1, dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"),
                                       dr.Item("location"), dr.Item("price"), dr.Item("stock"), dr.Item("barcode"))

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub clear()
        txtLocation.Clear()
        txtPrice.Clear()
        txtProCode.Clear()
        txtProName.Clear()
        cmbGroup.SelectedIndex = -1

        picBarCode.Image = Nothing
    End Sub

    Private Sub txtProCode_TextChanged(sender As Object, e As EventArgs) Handles txtProCode.TextChanged

        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.BackColor = Color.White
        Try
            picBarCode.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, txtProCode.Text))

        Catch ex As Exception
            picBarCode.Image = Nothing
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            conn.Open()

            Dim filesize As UInt32
            Dim mstream As New System.IO.MemoryStream
            picBarCode.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            filesize = mstream.Length
            mstream.Close()

            cmd = New MySqlCommand("INSERT INTO `tblproduct`(`procode`, `proname`, `progroup`, `location`, `price`,`barcode`)  VALUES (@procode,@proname,@progroup,@location,@price,@barcode)", conn)

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("procode", txtProCode.Text)
            cmd.Parameters.AddWithValue("proname", txtProName.Text)
            cmd.Parameters.AddWithValue("progroup", cmbGroup.Text)
            cmd.Parameters.AddWithValue("location", txtLocation.Text)
            cmd.Parameters.AddWithValue("price", CDec(txtPrice.Text))
            cmd.Parameters.AddWithValue("barcode", arrImage)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Product Save Success !", vbInformation)
            Else
                MsgBox("New Product Save Failed !", vbInformation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
        load_product()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        DataGridView2.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tblproduct` WHERE procode like '%" & txtSearch.Text & "%' or proname like '%" & txtSearch.Text & "%' or progroup like '%" & txtSearch.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView2.Rows.Add(DataGridView2.Rows.Count + 1, dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"),
                                       dr.Item("location"), dr.Item("price"), dr.Item("stock"), dr.Item("barcode"))

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        txtProCode.ReadOnly = True
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT  `procode`, `proname`, `progroup`,`location`, `price`, `stock`, `barcode` FROM `tblproduct` WHERE procode like '%" & txtSearchProduct.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read

                txtProCode.Text = dr.Item("procode")
                txtProName.Text = dr.Item("proname")
                cmbGroup.Text = dr.Item("progroup")
                txtLocation.Text = dr.Item("location")
                txtPrice.Text = dr.Item("price")

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("UPDATE `tblproduct` SET `proname`=@proname,`progroup`=@progroup,`location`=@location,`price`=@price WHERE `procode`=@procode", conn)
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("proname", txtProName.Text)
            cmd.Parameters.AddWithValue("progroup", cmbGroup.Text)
            cmd.Parameters.AddWithValue("location", txtLocation.Text)
            cmd.Parameters.AddWithValue("price", CDec(txtPrice.Text))
            cmd.Parameters.AddWithValue("procode", txtProCode.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Product Update Success !", vbInformation)
            Else
                MsgBox("Product Update Failed !", vbInformation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
        txtSearchProduct.Clear()
        load_product()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are You Sure You Want To Delete This Product", vbExclamation + vbYesNo) = vbYes Then
            Try
                conn.Open()
                cmd = New MySqlCommand("DELETE FROM `tblproduct` WHERE `procode` = @procode", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@procode", txtProCode.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Product Delete Success !", vbInformation)
                Else
                    MsgBox("Product Delete Failed !", vbInformation)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            clear()
            txtSearchProduct.Clear()
            load_product()

        Else
            Return
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
        txtSearchProduct.Clear()

    End Sub

End Class