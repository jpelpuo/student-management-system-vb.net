Imports MySql.Data.MySqlClient

Public Class Proof_of_registration
    Dim data As New Databases()
    Dim adapter As New MySqlDataAdapter()
    Dim command As New MySqlCommand("Select * from student where ID = @ID", data.getConnection())
    Dim details As New MySqlCommand("Select * from registration_grade where ID = @ID", data.getConnection())
    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnStdClose_Click(sender As Object, e As EventArgs) Handles btnStdClose.Click
        Me.Close()
    End Sub
End Class