Public NotInheritable Class SplashScreen

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Set up your timer settings
        Timer1.Interval = 20 ' Triggers every 20 milliseconds
        ProgressBar1.Value = 0 ' Start at 0
        Timer1.Start() ' Start the timer countdown
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Check if we haven't reached 100% yet
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 1 ' Increment progress
            lblLoading.Text = "Loading... " & ProgressBar1.Value & "%"
        Else
            ' Once it hits 100%, stop the timer and switch forms
            Timer1.Stop()
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

End Class