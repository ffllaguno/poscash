Imports System.Diagnostics.Eventing.Reader
Imports MySql.Data.MySqlClient
Public Class frm_mainCashier
    Private Sub frm_mainCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        txtSearchProductBarCode.Focus()
        total()
        btnPay.Enabled = False

        txtBillNo.Text = getbillno()
    End Sub

    Public Sub addlist()
        Dim exist As Boolean = False, numrow As Integer = 0, numtext As Integer
        For Each itm As DataGridViewRow In DataGridView1.Rows
            If itm.Cells(0).Value IsNot Nothing Then
                If itm.Cells(1).Value.ToString = txtSearchProductBarCode.Text Then
                    exist = True
                    numrow = itm.Index
                    numtext = CInt(itm.Cells(5).Value)
                    Exit For
                End If
            End If
        Next
        If exist = False Then
            Try
                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM `tblproduct` WHERE `procode`='" & txtSearchProductBarCode.Text & "'", conn)
                dr = cmd.ExecuteReader
                While dr.Read()
                    If txtSearchProductBarCode.Text = String.Empty Then
                        Return
                    Else
                        ' `procode`, `proname`, `progroup`, `location`, `price`'
                        Dim procode As String = dr.Item("procode")
                        Dim proname As String = dr.Item("proname")
                        Dim progroup As String = dr.Item("progroup")
                        Dim location As String = dr.Item("location")
                        Dim price As Decimal = dr.Item("price")

                        Dim totalqtyprice As Double
                        totalqtyprice = price

                        DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, procode, proname, progroup, price, 1, totalqtyprice)

                        txtSearchProductBarCode.Clear()
                        txtSearchProductBarCode.Focus()
                    End If
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            DataGridView1.Rows(numrow).Cells(5).Value = CInt("1") + numtext
            DataGridView1.Rows(numrow).Cells(6).Value = DataGridView1.Rows(numrow).Cells(4).Value + DataGridView1.Rows(numrow).Cells(6).Value
        End If


    End Sub


    Private Sub txtSearchProductBarcodeKeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchProductBarCode.KeyDown
        If txtSearchProductBarCode.Text = Nothing Then
        Else
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                addlist()

                txtSearchProductBarCode.Clear()
                txtSearchProductBarCode.Focus()
            End If
        End If
    End Sub

    Public Sub total()
        lblNoOfItems.Text = DataGridView1.Rows.Count - 1 + 1

        Dim sum As Double = 0
        Dim subtotal As Double = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(6).Value
            subtotal = subtotal + DataGridView1.Rows(i).Cells(4).Value * DataGridView1.Rows(i).Cells(5).Value
        Next
        Try
            lblTotalPrice.Text = Format(CDec(subtotal), "#,##0.00")

            lblOverAllGrandTotal.Text = Format(CDec(lblTotalPrice.Text), "#,##0.00")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        total()

    End Sub
    Private Sub txtAmountReceived_TextChanged(sender As Object, e As EventArgs) Handles txtAmountReceived.TextChanged
        Try
            lblChange.Text = Format(CDec(txtAmountReceived.Text - lblTotalPrice.Text), "#,##0.00")
        Catch ex As Exception

        End Try

        btnPay.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
        lblDate.Text = Date.Now.ToString("dd-MMMM-yyyy dddd")
    End Sub

    Sub savebill()
        If cmbPaymentMode.Text = String.Empty Then
            MsgBox("Please Select Payment Mode !", vbInformation)
            Return
        ElseIf txtAmountReceived.text = String.Empty Then
            MsgBox("Please Enter Received Amount !", vbInformation)
            Return
        ElseIf txtAmountReceived.text < lblTotalPrice.text Then
            MsgBox("Insufficient Amount !", vbExclamation)
            Return
        Else
            Try
                conn.Open()
                For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                    cmd = New MySqlCommand("INSERT INTO `tbl_pos`(`billno`, `billdate`, `bmonth`, `bmonthyear`, `procode`, `proname`, `progroup`, `price`,
                                                              `totalproductprice`,`qty`, `paymode`, `receiveamount`, `balance`) 
                                        VALUES (@billno, @billdate, @bmonth, @bmonthyear, @procode, @proname, @progroup, @price, @totalproductprice, @qty, 
                                         @paymode, @receiveamount, @balance)", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@billno", txtBillNo.Text)
                    cmd.Parameters.AddWithValue("@billdate", CDate(btpBillDate.Text))
                    cmd.Parameters.AddWithValue("@bmonth", Date.Now.ToString("MM"))
                    cmd.Parameters.AddWithValue("@bmonthyear", Date.Now.ToString("MMMM-yyyy"))

                    cmd.Parameters.AddWithValue("@procode", DataGridView1.Rows(j).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@proname", DataGridView1.Rows(j).Cells(2).Value)
                    cmd.Parameters.AddWithValue("@progroup", DataGridView1.Rows(j).Cells(3).Value)
                    cmd.Parameters.AddWithValue("@price", DataGridView1.Rows(j).Cells(4).Value)
                    cmd.Parameters.AddWithValue("@qty", DataGridView1.Rows(j).Cells(5).Value)
                    cmd.Parameters.AddWithValue("@totalproductprice", DataGridView1.Rows(j).Cells(6).Value)

                    cmd.Parameters.AddWithValue("@grandtotal", lblTotalPrice.Text)
                    cmd.Parameters.AddWithValue("@paymode", cmbPaymentMode.Text)
                    cmd.Parameters.AddWithValue("@receiveamount", txtAmountReceived.Text)
                    cmd.Parameters.AddWithValue("@balance", lblChange.Text)

                    i = cmd.ExecuteNonQuery
                Next
                If i > 0 Then
                    MsgBox("New Transaction Save Success !" & vbNewLine & "Bill no : " & txtBillNo.Text, vbInformation)
                    clear()
                Else
                    MsgBox("Last Transaction Failed !", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            txtBillNo.Text = getbillno()
        End If

    End Sub

    Sub clear()
        btpBillDate.Text = Now
        txtSearchProductBarCode.Clear()
        DataGridView1.Rows.Clear()
        lblChange.Text = "0.00"
        lblOverAllGrandTotal.Text = "0.00"
        lblTotalPrice.Text = "0.00"
        lblNoOfItems.Text = "0.00"
        cmbPaymentMode.SelectedIndex = -1
        txtAmountReceived.Clear()
    End Sub
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        savebill()

        txtSearchProductBarCode.Focus()

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        clear()
        txtBillNo.Text = getbillno()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        DataGridView1.Rows.Remove(DataGridView1.SelectedRows.Item(0))
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        frm_ChangePassword.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Form1.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frm_CancelOrder.ShowDialog()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click

    End Sub

    Private Sub lblTime_Click(sender As Object, e As EventArgs) Handles lblTime.Click

    End Sub
End Class