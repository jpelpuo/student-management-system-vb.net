Imports MySql.Data.MySqlClient

Public Class Staff_Options
    Dim data As New Databases()
    Dim adapter As New MySqlDataAdapter()
    Dim command As New MySqlCommand("Select * from staff where ID = @ID", data.getConnection())
    Private Sub btnGrades_Click(sender As Object, e As EventArgs) Handles btnGrades.Click

        Dim reader As MySqlDataReader
        Dim table As New DataTable()

        command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = detailsID.Text

        adapter.SelectCommand = command
        adapter.Fill(table)
        data.openConnection()

        Upload_grades.Show()
        reader = command.ExecuteReader()
        While reader.Read()
            Upload_grades.stfID.Text = reader("ID").ToString
            Upload_grades.stfFName.Text = reader("FirstName").ToString
            Upload_grades.stfLName.Text = reader("LastName").ToString
            Upload_grades.stfPost.Text = reader("Position").ToString
            Upload_grades.stfDept.Text = reader("Department").ToString

        End While

        command.Parameters.Clear()
        reader.Close()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim reader As MySqlDataReader
        Dim table As New DataTable()

        command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = detailsID.Text

        adapter.SelectCommand = command
        adapter.Fill(table)
        data.openConnection()

        Registered_Students.Show()
        reader = command.ExecuteReader()
        While reader.Read()
            Registered_Students.stfID.Text = reader("ID").ToString
            Registered_Students.stfFName.Text = reader("FirstName").ToString
            Registered_Students.stfLName.Text = reader("LastName").ToString
            Registered_Students.stfPost.Text = reader("Position").ToString
            Registered_Students.stfDept.Text = reader("Department").ToString

        End While

        command.Parameters.Clear()
        reader.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        data.closeConnection()
        Me.Close()
    End Sub
End Class