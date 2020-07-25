Public Class Form4
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        MainMenu.tampildashboard()
    End Sub

    Private Sub btnBEP_Click(sender As Object, e As EventArgs) Handles btnBEP.Click
        Dim jmlUnit As Integer
        jmlUnit = (Val(txtBiayaTetap.Text) + Val(txtLaba.Text)) / Val(txtHargaUnit.Text)

        lblJmlUnit.Text = (Val(txtBiayaTetap.Text) + Val(txtLaba.Text)) / (Val(txtHargaUnit.Text) - Val(txtBebanVariabel.Text))
        lblDetailJmlUnit.Visible = True
        lblDetailJmlRp.Visible = True
        lblDetailJmlUnit.Text = "Jumlah unit atau volume penjualan adalah sebesar " & lblJmlUnit.Text & " units."
        lblDetailJmlRp.Text = "Jumlah dalam rupiah adalah sebesar " & FormatCurrency(Val(lblJmlUnit.Text) * Val(txtHargaUnit.Text))

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtHargaUnit.Text = 0
        txtBebanVariabel.Text = 0
        txtBiayaTetap.Text = 0
        txtLaba.Text = 0
        lblDetailJmlUnit.Visible = False
        lblDetailJmlRp.Visible = False
    End Sub
End Class