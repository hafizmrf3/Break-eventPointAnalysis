Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        MainMenu.tampildashboard()
    End Sub
    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnitSaatIni.TextChanged
        Label7.Text = "Sales (" & txtUnitSaatIni.Text & " units):"
    End Sub
    Private Sub txtUnitPenjualan_TextChanged(sender As Object, e As EventArgs) Handles txtPenjualanUnit.TextChanged
        txtTotalPenjualanSaatIni.Text = Val(txtUnitSaatIni.Text) * Val(txtPenjualanUnit.Text)


    End Sub

    Private Sub txtBiayaVariabelUnit_TextChanged(sender As Object, e As EventArgs) Handles txtBiayaVariabelUnit.TextChanged
        txtBiayaVariabelSaatIni.Text = Val(txtBiayaVariabelUnit.Text) * Val(txtUnitSaatIni.Text)

        'marginkontribusi
        txtMarginKontribusiUnit.Text = Val(txtPenjualanUnit.Text) - Val(txtBiayaVariabelUnit.Text)

        'totalmarginpenjualansaatini
        txtMarginKontribusiSaatIni.Text = Val(txtTotalPenjualanSaatIni.Text) - Val(txtBiayaVariabelSaatIni.Text)

        'biayavariabel yang diharapkan
        '        txtBiayaVariabelDiharapkan.Text = Val(txtBiayaVariabelUnit.Text) * Val(txtUnitDiharapkan.Text)


    End Sub

    Private Sub txtBiayaTetapSaatIni_TextChanged(sender As Object, e As EventArgs) Handles txtBiayaTetapSaatIni.TextChanged
        'txtBiayaTetapDiharapkan.Text = Val(txtBiayaTetapSaatIni.Text) + Val(txt)
        txtPeningkatanBiayaTetap.Text = Val(txtBiayaTetapDiharapkan.Text) - Val(txtBiayaTetapSaatIni.Text)
    End Sub

    Private Sub txtUnitDiharapkan_TextChanged(sender As Object, e As EventArgs) Handles txtUnitDiharapkan.TextChanged
        txtTotalPenjualanDiharapkan.Text = Val(txtPenjualanUnit.Text) * Val(txtUnitDiharapkan.Text)


        'txtBiayaVariabelSaatIni.Text = Val(txtBiayaVariabelUnit.Text) * Val(txtUnitDiharapkan.Text)
        'biayavariabel yang diharapkan
        txtBiayaVariabelDiharapkan.Text = Val(txtBiayaVariabelUnit.Text) * Val(txtUnitDiharapkan.Text)

        'totalmarginpenjualandiharapkan
        txtMarginKontribusiDiharapkan.Text = Val(txtTotalPenjualanDiharapkan.Text) - Val(txtBiayaVariabelDiharapkan.Text)

        txtBiayaTetapDiharapkan.Text = Val(txtBiayaTetapSaatIni.Text) + Val(txtPerubahanBiayaTetap.Text)
        txtLabaBersihDiharapkan.Text = Val(txtMarginKontribusiDiharapkan.Text) - Val(txtBiayaTetapDiharapkan.Text)

        txtPeningkatanSales.Text = Val(txtTotalPenjualanDiharapkan.Text) - Val(txtTotalPenjualanSaatIni.Text)
        txtPeningkatanBiayaVariabel.Text = Val(txtBiayaVariabelDiharapkan.Text) - Val(txtBiayaVariabelSaatIni.Text)
        txtPeningkatanMarginKontribusi.Text = Val(txtMarginKontribusiDiharapkan.Text) - Val(txtMarginKontribusiSaatIni.Text)
        txtPeningkatanBiayaTetap.Text = Val(txtBiayaTetapDiharapkan.Text) - Val(txtBiayaTetapSaatIni.Text)
        txtPeningkatanLabaBersih.Text = Val(txtLabaBersihDiharapkan.Text) - Val(txtLabaBersihSaatIni.Text)



    End Sub

    Private Sub txtLabaBersihSaatIni_TextChanged(sender As Object, e As EventArgs) Handles txtLabaBersihSaatIni.TextChanged
        txtLabaBersihDiharapkan.Text = Val(txtMarginKontribusiDiharapkan.Text) - Val(txtBiayaTetapDiharapkan.Text)

        txtPeningkatanLabaBersih.Text = Val(txtLabaBersihDiharapkan.Text) - Val(txtLabaBersihSaatIni.Text)
    End Sub

    Private Sub btnBEP_Click(sender As Object, e As EventArgs) Handles btnBEP.Click
        Dim peningkatanlaba As Integer
        peningkatanlaba = Val(txtPeningkatanLabaBersih.Text)
        If txtPeningkatanLabaBersih.Text > txtLabaBersihSaatIni.Text Then
            lblDetailKesimpulan.Text = "(Peningkatan laba / >) seharusnya perubahan dilakukan, karena menaikkan keuntungan perusahaan sebesar " & FormatCurrency(Math.Abs(peningkatanlaba))
        Else
            lblDetailKesimpulan.Text = "(Peningkatan laba / <) seharusnya perubahan tidak dilakukan, karena merugikan perusahaan sebesar " & FormatCurrency(Math.Abs(peningkatanlaba))
        End If
        Label13.Visible = True
        lblDetailKesimpulan.Visible = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'saat ini
        txtUnitSaatIni.Text = 0
        txtPenjualanUnit.Text = 0
        txtBiayaVariabelUnit.Text = 0
        txtMarginKontribusiSaatIni.Text = 0
        txtTotalPenjualanSaatIni.Text = 0
        txtBiayaVariabelSaatIni.Text = 0
        txtMarginKontribusiSaatIni.Text = 0
        txtBiayaTetapSaatIni.Text = 0
        txtPerubahanBiayaTetap.Text = 0
        txtLabaBersihSaatIni.Text = 0

        'diharapkan
        txtUnitDiharapkan.Text = 0
        txtTotalPenjualanDiharapkan.Text = 0
        txtBiayaVariabelDiharapkan.Text = 0
        txtMarginKontribusiDiharapkan.Text = 0
        txtBiayaTetapDiharapkan.Text = 0
        txtLabaBersihDiharapkan.Text = 0

        'Peningkatan
        txtPeningkatanSales.Text = 0
        txtPeningkatanBiayaVariabel.Text = 0
        txtPeningkatanMarginKontribusi.Text = 0
        txtPeningkatanBiayaTetap.Text = 0
        txtPeningkatanLabaBersih.Text = 0

        'Kesimpulan
        lblDetailKesimpulan.Visible = False

    End Sub
End Class