﻿Public Class SplashFrom
    Private Sub SplashFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashTimer.Start()
    End Sub

    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        StansGroceryForm.Show()
        Me.Close()
    End Sub

End Class