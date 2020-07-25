Public Class Loading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 2

        If ProgressBar1.Value <= 20 Then

            Label2.Text = "Running the application for the first time ..... (20%)"

        ElseIf ProgressBar1.Value <= 40 Then

            Label2.Text = "Connecting to Database .... (40%) "


        ElseIf ProgressBar1.Value <= 60 Then

            Label2.Text = "Synchronizing the application components with database ..... (60%)"

        ElseIf ProgressBar1.Value <= 80 Then
            Label2.Text = "Opening the application .....(80%)"

        ElseIf ProgressBar1.Value <= 100 Then

            Label2.Text = "Please Wait .... (100%)"
        End If

        If ProgressBar1.Value = 100 Then

            Timer1.Dispose()

            Me.Visible = False

            FormLogin.Show()


        End If

    End Sub
End Class