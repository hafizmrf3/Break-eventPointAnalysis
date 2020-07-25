Public Class Form5
    Private Sub btnBEP_Click(sender As Object, e As EventArgs) Handles btnBEP.Click
        lblMoS.Text = Val(txtPenjSaatIni.Text) - Val(txtPenjTitikImpas.Text)
        lblDetailMoS.Visible = True
        lblPersentaseMoS.Visible = True
        lblDetailMoS.Text = "Margin of Safety dalam Rp adalah sebesar " & FormatCurrency(lblMoS.Text)
        lblPersentaseMoS.Text = "Atau dengan besarnya persentase sebesar " & Val(Val(lblMoS.Text) / Val(txtPenjSaatIni.Text)) * 100 & "%"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPenjSaatIni.Text = 0
        txtPenjTitikImpas.Text = 0
        lblMoS.Visible = False
        lblDetailMoS.Visible = False
        lblPersentaseMoS.Visible = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        MainMenu.tampildashboard()
    End Sub
End Class