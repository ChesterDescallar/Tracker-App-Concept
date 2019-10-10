Public Class Signin
    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If txtUser.Text = "belinda" Then
            If txtPass.Text = "password" Then
                Me.Hide()
                HomePage.Show()
            End If
        Else
            Label1.Show()
        End If
    End Sub

    Private Sub Signin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Hide()
    End Sub
End Class
