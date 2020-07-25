'Imports System.Data.OleDb
Public Class Form7
    Private Sub FormBEP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call koneksi()
    End Sub

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        Label1.Text = "Sales (" & txtUnit.Text & " units):"
    End Sub


    Private Sub txtUnitPenjualan_TextChanged(sender As Object, e As EventArgs) Handles txtUnitPenjualan.TextChanged
        txtTotalPenjualan.Text = Val(txtUnitPenjualan.Text) * Val(txtUnit.Text)
        'txtTotalPenjualan.Text = FormatCurrency(txtTotalPenjualan.Text)
        If txtUnitPenjualan.Text = "" Then
            txtUnitPenjualan.Text = "0"
        End If
    End Sub

    Private Sub txtBebanVariabelUnit_TextChanged(sender As Object, e As EventArgs) Handles txtBebanVariabelUnit.TextChanged

        txtBebanVariabelTotal.Text = Val(txtBebanVariabelUnit.Text) * Val(txtUnit.Text)
        'txtBebanVariabelTotal.Text = FormatCurrency(txtBebanVariabelTotal.Text)
        '"If txtBebanVariabelUnit.Text = "" Then
        '"txtBebanVariabelUnit.Text = "0"
        '"End If

        txtMarginKontribusiUnit.Text = Val(txtUnitPenjualan.Text) - Val(txtBebanVariabelUnit.Text)
        'txtMarginKontribusiUnit.Text = FormatCurrency(txtMarginKontribusiUnit.Text)
        '"If txtMarginKontribusiUnit.Text = "" Then
        '"txtMarginKontribusiUnit.Text = "0"
        '"End If

        txtMarginKontribusiTotal.Text = Val(txtTotalPenjualan.Text) - Val(txtBebanVariabelTotal.Text)
        'txtMarginKontribusiTotal.Text = FormatCurrency(txtMarginKontribusiTotal.Text)

        txtRasioMCunit.Text = Math.Round(Val(txtMarginKontribusiUnit.Text / txtUnitPenjualan.Text), 2)
        txtRasioMCtotal.Text = Math.Round(Val(txtMarginKontribusiTotal.Text / txtTotalPenjualan.Text), 2)
        'txtRasioMCunit.Text = Math.Round(Convert.ToDecimal(Val(txtMarginKontribusiUnit.Text / txtUnitPenjualan.Text)), 2) '* 100 & " %"
        'txtRasioMCtotal.Text = Math.Round(Convert.ToDecimal(Val(txtMarginKontribusiTotal.Text / txtTotalPenjualan.Text)), 2) '* 100 & " %"

    End Sub

    Private Sub txtBebanVariabelTotal_TextChanged(sender As Object, e As EventArgs) Handles txtBebanVariabelTotal.TextChanged
        txtMarginKontribusiTotal.Text = Val(txtTotalPenjualan.Text) - Val(txtBebanVariabelTotal.Text)
        ''txtMarginKontribusiTotal.Text = FormatCurrency(txtMarginKontribusiTotal.Text)

    End Sub

    Private Sub btnBEP_Click(sender As Object, e As EventArgs) Handles btnBEP.Click
        'Show Result
        Label13.Visible = True
        Label11.Visible = True
        lblBEPunit.Visible = True
        lblDetailBEPunit.Visible = True
        label15.Visible = True
        lblBEPrp.Visible = True
        lblDetailBEPrp.Visible = True
        ''BEP Unit
        lblBEPunit.Text = Convert.ToDecimal(txtBebanTetap.Text / txtMarginKontribusiUnit.Text)
        lblDetailBEPunit.Text = "Ini berarti perusahaan harus menjual sebanyak " & lblBEPunit.Text & " unit untuk menerapkan Break Even Point. " & vbNewLine &
                                 "Pada " & Val(lblBEPunit.Text + 1) & " unit penjualan, perusahaan baru mendapatkan keuntungan."

        ''BEP Rp
        lblBEPrp.Text = Convert.ToDecimal(txtBebanTetap.Text / txtRasioMCtotal.Text)
        lblBEPrp.Text = FormatCurrency(lblBEPrp.Text)
        lblDetailBEPrp.Text = "Ini berarti perusahaan harus mendapatkan pendapatan sebesar Rp" & lblBEPrp.Text & " untuk menerapkan Break Even Point. " & vbNewLine &
            "Pada saat pendapatan melebihi  " & lblBEPrp.Text & ", perusahaan baru mendapatkan keuntungan."
    End Sub


    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Process.Start(Application.StartupPath & "\manualbook\ManualBook.pdf")
    End Sub

    Private Sub AboutAppToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        MsgBox("Aplikasi ini dibuat untuk sebagai bahan penilaian ujian akhir mata kuliah Komputerisasi Akuntansi Keuangan Manajemen" & vbNewLine &
            "Berikut mahasiswa-mahasiswa kelas 57A222 yang terlibat dalam pembuatan aplikasi BEP ini:" & vbNewLine &
            "1. Aditia Arga Pratama 92219108" & vbNewLine &
            "2. Cut Cherryl Aulia      92219114" & vbNewLine &
            "3. Hafiz Ma'ruf              92219117" & vbNewLine &
            "4. Novilia Angraini        92219120")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtUnit.Text = 0
        txtUnitPenjualan.Text = 0
        txtTotalPenjualan.Text = 0
        txtBebanVariabelUnit.Text = 0
        txtBebanVariabelTotal.Text = 0
        txtMarginKontribusiUnit.Text = 0
        txtMarginKontribusiTotal.Text = 0
        txtBebanTetap.Text = 0
        txtRasioMCunit.Text = 0.00
        txtRasioMCtotal.Text = 0.00

        'txtNamaPerusahaan.Clear()
        'txtUnit.Clear()
        'txtUnitPenjualan.Clear()
        'txtTotalPenjualan.Clear()
        'txtBebanVariabelUnit.Clear()
        'txtBebanVariabelTotal.Clear()
        'txtMarginKontribusiUnit.Clear()
        'txtMarginKontribusiTotal.Clear()
        'txtBebanTetap.Clear()
        'txtLabaBersih.Clear()
        'txtRasioMCunit.Clear()
        'txtRasioMCtotal.Clear()



        'Result

        Label13.Visible = False
        Label11.Visible = False
        lblBEPunit.Visible = False
        lblDetailBEPunit.Visible = False
        label15.Visible = False
        lblBEPrp.Visible = False
        lblDetailBEPrp.Visible = False

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) 
        If MessageBox.Show("Are you sure to close the application?", "BEP App", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            End

        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        MainMenu.tampildashboard()
    End Sub
End Class