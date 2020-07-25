Public Class Form3



    Private Sub txtBiayaVariabelPerUnit_TextChanged(sender As Object, e As EventArgs) Handles txtBiayaVariabelSaatIni.TextChanged
        txtMarginKontribusiSaatIni.Text = Val(txtSalesUnitPerUnit.Text) - Val(txtBiayaVariabelSaatIni.Text)
    End Sub

    Private Sub txtBiayaVariabelPerubahan_TextChanged(sender As Object, e As EventArgs) Handles txtBiayaVariabelPerubahan.TextChanged
        txtHasilBiayaVariabel.Text = Val(txtBiayaVariabelSaatIni.Text) + Val(txtBiayaVariabelPerubahan.Text)
        txtMarginKontribusiPerubahan.Text = Val(txtSalesUnitPerUnit.Text) - Val(txtHasilBiayaVariabel.Text)
    End Sub

    Private Sub txtBiayaTetapDiharapkan_TextChanged(sender As Object, e As EventArgs) Handles txtBiayaTetapPerubahan.TextChanged
        txtHasilBiayaTetap.Text = Val(txtBiayaTetapSaatIni.Text) + Val(txtBiayaTetapPerubahan.Text)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        MainMenu.tampildashboard()
    End Sub

    Private Sub btnBEP_Click(sender As Object, e As EventArgs) Handles btnBEP.Click
        lblPerubahanMarginKontribusi.Visible = True
        lblPerubahanMarginKontribusi.Text = "Perubahan Margin Kontribusi sebesar " & FormatCurrency((Val(txtSalesUnitDiharapkan.Text * txtMarginKontribusiPerubahan.Text)) - (Val(txtSalesUnitSaatIni.Text * txtMarginKontribusiSaatIni.Text)))
        label15.Visible = True
        Label11.Visible = True
        Dim pmk As Integer
        pmk = Val(txtSalesUnitDiharapkan.Text * txtMarginKontribusiPerubahan.Text) - Val(txtSalesUnitSaatIni.Text * txtMarginKontribusiSaatIni.Text)

        Label8.Text = pmk - Val(txtBiayaTetapPerubahan.Text)
        Label8.Visible = True
        If Label8.Text > txtBiayaTetapPerubahan.Text Then
            Label14.Text = "(>) Seharusnya perubahan dilakukan karena akan mendapatkan kenaikan laba sebesar " & FormatCurrency(Label8.Text)
        Else
            Label14.Text = "(<) Seharusnya perubahan tidak dilakukan karena akan mengurangi laba sebesar " & FormatCurrency(Label8.Text)
        End If
        Label14.Visible = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'saat ini
        txtSalesUnitPerUnit.Text = 0
        txtSalesUnitSaatIni.Text = 0
        txtBiayaVariabelSaatIni.Text = 0
        txtMarginKontribusiSaatIni.Text = 0
        txtBiayaTetapSaatIni.Text = 0

        'diharapkan
        txtSalesUnitDiharapkan.Text = 0
        txtBiayaVariabelPerubahan.Text = 0
        txtMarginKontribusiPerubahan.Text = 0
        txtBiayaTetapPerubahan.Text = 0

        'hasil'
        txtHasilBiayaVariabel.Text = 0
        txtHasilBiayaTetap.Text = 0

        lblPerubahanMarginKontribusi.Visible = False
        Label11.Visible = False
        Label8.Visible = False
        Label14.Visible = False
        label15.Visible = False
    End Sub

    Private Sub txtSalesUnitSaatIni_TextChanged(sender As Object, e As EventArgs) Handles txtSalesUnitSaatIni.TextChanged

    End Sub
End Class