Public Class SplashFrom
    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        StansGroceryForm.Show()
        SplashTimer.Enabled = False
        Me.Close()
    End Sub
End Class