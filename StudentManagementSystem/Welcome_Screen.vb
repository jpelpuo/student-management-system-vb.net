Public Class Welcome_Screen
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub StdLogBtn_Click(sender As Object, e As EventArgs) Handles StdLogBtn.Click
        Student_Login.Show()

    End Sub

    Private Sub StfLogBtn_Click(sender As Object, e As EventArgs) Handles StfLogBtn.Click
        Staff_Login.Show()

    End Sub
End Class
