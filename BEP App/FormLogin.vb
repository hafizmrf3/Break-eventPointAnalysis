Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call koneksi()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "user" And txtPass.Text = "ujianakhir" Then
            MainMenu.Show()
            Me.Close()
        Else
            MsgBox("Username atau Password anda salah." & vbNewLine & "Isi dengan benar!")
            txtUser.Text = ""
            txtPass.Text = ""

        End If
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        End
    End Sub
End Class
