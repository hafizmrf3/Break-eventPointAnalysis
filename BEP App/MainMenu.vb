Public Class MainMenu

    Sub tampildashboard()
        lblDA.Show()
        PanelItem.Show()
        Panel5.Show()
        Panel6.Show()
        Label1.Visible = True
        Form1.Close()
        Form2.Close()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
    End Sub
    Sub sembunyikandashboard()
        lblDA.Hide()
        Panel5.Hide()
        Panel6.Hide()
        PanelItem.Hide()
        Label1.Visible = False
    End Sub


    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Call tampildashboard()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Call tampildashboard()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Anda yakin ingin menutup aplikasi?", "BEP App", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            End
        End If
    End Sub
    Private Sub btnForm1_Click(sender As Object, e As EventArgs) Handles btnForm1.Click
        Call sembunyikandashboard()
        Form1.Show()
        Form1.MdiParent = Me
        btnForm1.BackColor = Color.LightSeaGreen
        btnForm2.BackColor = Color.DarkGoldenrod
        btnForm3.BackColor = Color.DarkGoldenrod
        btnForm4.BackColor = Color.DarkGoldenrod
        btnForm5.BackColor = Color.DarkGoldenrod
        btnForm6.BackColor = Color.DarkGoldenrod
        btnForm7.BackColor = Color.DarkGoldenrod
    End Sub
    Private Sub btnForm2_Click(sender As Object, e As EventArgs) Handles btnForm2.Click
        Call sembunyikandashboard()
        Form2.Show()
        Form2.MdiParent = Me
        btnForm2.BackColor = Color.LightSeaGreen
        btnForm1.BackColor = Color.DarkGoldenrod
        btnForm3.BackColor = Color.DarkGoldenrod
        btnForm4.BackColor = Color.DarkGoldenrod
        btnForm5.BackColor = Color.DarkGoldenrod
        btnForm6.BackColor = Color.DarkGoldenrod
        btnForm7.BackColor = Color.DarkGoldenrod
    End Sub
    Private Sub btnForm3_Click(sender As Object, e As EventArgs) Handles btnForm3.Click
        Call sembunyikandashboard()
        Form3.Show()
        Form3.MdiParent = Me
        btnForm3.BackColor = Color.LightSeaGreen
        btnForm1.BackColor = Color.DarkGoldenrod
        btnForm2.BackColor = Color.DarkGoldenrod
        btnForm4.BackColor = Color.DarkGoldenrod
        btnForm5.BackColor = Color.DarkGoldenrod
        btnForm6.BackColor = Color.DarkGoldenrod
        btnForm7.BackColor = Color.DarkGoldenrod
    End Sub
    Private Sub btnForm4_Click(sender As Object, e As EventArgs) Handles btnForm4.Click
        Call sembunyikandashboard()
        Form4.Show()
        Form4.MdiParent = Me
        btnForm4.BackColor = Color.LightSeaGreen
        btnForm2.BackColor = Color.DarkGoldenrod
        btnForm1.BackColor = Color.DarkGoldenrod
        btnForm3.BackColor = Color.DarkGoldenrod
        btnForm5.BackColor = Color.DarkGoldenrod
        btnForm6.BackColor = Color.DarkGoldenrod
        btnForm7.BackColor = Color.DarkGoldenrod
    End Sub

    Private Sub btnForm5_Click(sender As Object, e As EventArgs) Handles btnForm5.Click
        Call sembunyikandashboard()
        Form5.Show()
        Form5.MdiParent = Me
        btnForm5.BackColor = Color.LightSeaGreen
        btnForm2.BackColor = Color.DarkGoldenrod
        btnForm1.BackColor = Color.DarkGoldenrod
        btnForm3.BackColor = Color.DarkGoldenrod
        btnForm4.BackColor = Color.DarkGoldenrod
        btnForm6.BackColor = Color.DarkGoldenrod
        btnForm7.BackColor = Color.DarkGoldenrod
    End Sub

    Private Sub btnForm6_Click(sender As Object, e As EventArgs) Handles btnForm6.Click
        Call sembunyikandashboard()
        Form6.Show()
        Form6.MdiParent = Me
        btnForm6.BackColor = Color.LightSeaGreen
        btnForm2.BackColor = Color.DarkGoldenrod
        btnForm1.BackColor = Color.DarkGoldenrod
        btnForm3.BackColor = Color.DarkGoldenrod
        btnForm4.BackColor = Color.DarkGoldenrod
        btnForm5.BackColor = Color.DarkGoldenrod
        btnForm7.BackColor = Color.DarkGoldenrod
    End Sub

    Private Sub btnForm7_Click(sender As Object, e As EventArgs) Handles btnForm7.Click
        Call sembunyikandashboard()
        Form7.Show()
        Form7.MdiParent = Me
        btnForm7.BackColor = Color.LightSeaGreen
        btnForm2.BackColor = Color.DarkGoldenrod
        btnForm1.BackColor = Color.DarkGoldenrod
        btnForm3.BackColor = Color.DarkGoldenrod
        btnForm4.BackColor = Color.DarkGoldenrod
        btnForm5.BackColor = Color.DarkGoldenrod
        btnForm6.BackColor = Color.DarkGoldenrod
    End Sub

    Private Sub btnManualUser_Click(sender As Object, e As EventArgs) Handles btnManualUser.Click
        Process.Start(Application.StartupPath & "\manualbook\ManualBook.pdf")
    End Sub

    Private Sub btnAboutApp_Click(sender As Object, e As EventArgs) Handles btnAboutApp.Click
        MsgBox("Aplikasi ini dibuat untuk sebagai bahan penilaian ujian akhir mata kuliah Komputerisasi Akuntansi Keuangan Manajemen" & vbNewLine &
           "Berikut mahasiswa-mahasiswa kelas 57A222 yang terlibat dalam pembuatan aplikasi BEP ini:" & vbNewLine &
           "1. Aditia Arga Pratama 92219108" & vbNewLine &
           "2. Cut Cherryl Aulia      92219114" & vbNewLine &
           "3. Hafiz Ma'ruf              92219117" & vbNewLine &
           "4. Novilia Angraini        92219120")
    End Sub
End Class