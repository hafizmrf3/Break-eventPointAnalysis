Public Class Form2
    Private Sub txtSalesUnitSaatIni_TextChanged(sender As Object, e As EventArgs) Handles txtSalesUnitSaatIni.TextChanged
        Label7.Text = "Sales (" & txtSalesUnitSaatIni.Text & " units):"
    End Sub

    Private Sub txtBiayaVariabelSaatIni_TextChanged(sender As Object, e As EventArgs) Handles txtBiayaVariabelSaatIni.TextChanged
        txtMarginKontribusiSaatIni.Text = Val(txtSalesUnitPerUnit.Text) - Val(txtBiayaVariabelSaatIni.Text)
    End Sub

    Private Sub txtBiayaVariabelPerubahan_TextChanged(sender As Object, e As EventArgs) Handles txtBiayaVariabelPerubahan.TextChanged
        txtHasilBiayaVariabel.Text = Val(txtBiayaVariabelSaatIni.Text) + Val(txtBiayaVariabelPerubahan.Text)
        txtMarginKontribusiPerubahan.Text = Val(txtSalesUnitPerUnit.Text) - Val(txtHasilBiayaVariabel.Text)
    End Sub

    Private Sub btnBEP_Click(sender As Object, e As EventArgs) Handles btnBEP.Click
        lblPerubahanMarginKontribusi.Visible = True
        lblPerubahanMarginKontribusi.Text = "Perubahan Margin Kontribusi sebesar " & FormatCurrency(Val(txtSalesUnitDiharapkan.Text * txtMarginKontribusiPerubahan.Text) - Val(txtSalesUnitSaatIni.Text * txtMarginKontribusiSaatIni.Text))
        Dim pmk As Integer
        pmk = Val(txtSalesUnitDiharapkan.Text * txtMarginKontribusiPerubahan.Text) - Val(txtSalesUnitSaatIni.Text * txtMarginKontribusiSaatIni.Text)
        'Label8.Text = Val(lblPerubahanMarginKontribusi.Text) - Val(txtBiayaVariabelPerubahan.Text)
        'Label8.Visible = True

        If pmk > txtMarginKontribusiSaatIni.Text Then
            Label14.Text = "(>) Seharusnya perubahan dilakukan karena variabel tetap tidak berubah dan " & vbNewLine & " peningkatan margin kontribusi sebesar " & FormatCurrency(Val(txtSalesUnitDiharapkan.Text * txtMarginKontribusiPerubahan.Text) - Val(txtSalesUnitSaatIni.Text * txtMarginKontribusiSaatIni.Text))
        Else
            Label14.Text = "(<) Seharusnya perubahan tidak dilakukan karena terjadi penurunan margin kontribusi sebesar " & FormatCurrency(Val(txtSalesUnitDiharapkan.Text * txtMarginKontribusiPerubahan.Text) - Val(txtSalesUnitSaatIni.Text * txtMarginKontribusiSaatIni.Text))
        End If
        Label14.Visible = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'saat ini
        txtSalesUnitPerUnit.Text = 0
        txtSalesUnitSaatIni.Text = 0
        txtBiayaVariabelSaatIni.Text = 0
        txtMarginKontribusiSaatIni.Text = 0


        'diharapkan
        txtSalesUnitDiharapkan.Text = 0
        txtBiayaVariabelPerubahan.Text = 0
        txtMarginKontribusiPerubahan.Text = 0


        'hasil'
        txtHasilBiayaVariabel.Text = 0


        lblPerubahanMarginKontribusi.Visible = False
        Label14.Visible = False

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        MainMenu.tampildashboard()
    End Sub
End Class