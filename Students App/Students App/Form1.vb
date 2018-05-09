Public Class Form1


    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Application.Exit()
    End Sub



    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class
