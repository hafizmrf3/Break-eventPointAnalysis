Public Class Form6
    Private Sub btnBEP_Click(sender As Object, e As EventArgs) Handles btnBEP.Click
        lblHargaJualBaru.Text = Val(txtBiayaVariabel.Text) + Val(Val(txtLabaAkhir.Text) / Val(txtBiayaVariabel.Text))
        lblDetailHargaJualBaru.Visible = True
        lblDetailHargaJualBaru.Text = "Harga jual reguler per unit yang baru adalah " & FormatCurrency(lblHargaJualBaru.Text)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBiayaVariabel.Text = 0
        txtLabaAkhir.Text = 0
        lblHargaJualBaru.Visible = False
        lblDetailHargaJualBaru.Visible = False

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        MainMenu.tampildashboard()
    End Sub
End Class