Public Class fmr_mainAdmin
    Private Sub fmr_mainAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnManageProduct_Click(sender As Object, e As EventArgs) Handles btnManageProduct.Click
        frm_ManageProduct.ShowDialog()

    End Sub

    Private Sub btnManageStock_Click(sender As Object, e As EventArgs) Handles btnManageStock.Click
        frm_ManageStock.ShowDialog()

    End Sub

    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click
        frm_ManageUser.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class