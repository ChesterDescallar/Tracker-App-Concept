Public Class AddorEdit
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Child.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Number.Text = ""
    End Sub

    Private Sub distance_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Slider_Scroll(sender As Object, e As EventArgs) Handles Slider.Scroll
        distance.Text = Slider.Value
    End Sub
End Class