Imports MySql.Data.MySqlClient

Public Class Student_Options
    Dim data As New Databases()
    Dim adapter As New MySqlDataAdapter()
    Dim command As New MySqlCommand("Select * from student where ID = @ID", data.getConnection())

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        data.closeConnection()
        Me.Close()

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim reader As MySqlDataReader
        Dim table As New DataTable()

        command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = stdID.Text

            adapter.SelectCommand = command
            adapter.Fill(table)
            data.openConnection()

            RegisterCourses.Show()
            reader = command.ExecuteReader()
            While reader.Read()
                RegisterCourses.StdName.Text = reader("FirstName").ToString
                RegisterCourses.StdLName.Text = reader("LastName").ToString
                RegisterCourses.stdID.Text = reader("ID").ToString
                RegisterCourses.stdLvl.Text = reader("Level").ToString

        End While

        command.Parameters.Clear()
        reader.Close()


    End Sub


    Private Sub btnGrades_Click(sender As Object, e As EventArgs) Handles btnGrades.Click


        Dim reader As MySqlDataReader
        Dim table As New DataTable()

        command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = stdID.Text

        adapter.SelectCommand = command
        adapter.Fill(table)
        data.openConnection()

        Check_Grades.Show()
        reader = command.ExecuteReader()
        While reader.Read()
            Check_Grades.StdName.Text = reader("FirstName").ToString
            Check_Grades.StdLName.Text = reader("LastName").ToString
            Check_Grades.stdID.Text = reader("ID").ToString
            Check_Grades.stdLvl.Text = reader("Level").ToString

        End While

        command.Parameters.Clear()
        reader.Close()
    End Sub

    Private Sub btnGPA_Click(sender As Object, e As EventArgs) Handles btnGPA.Click


        Dim reader As MySqlDataReader
        Dim table As New DataTable()

        command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = stdID.Text

        adapter.SelectCommand = command
        adapter.Fill(table)
        data.openConnection()

        Calculate_GPA.Show()
        reader = command.ExecuteReader()
        While reader.Read()
            Calculate_GPA.StdName.Text = reader("FirstName").ToString
            Calculate_GPA.StdLName.Text = reader("LastName").ToString
            Calculate_GPA.stdID.Text = reader("ID").ToString
            Calculate_GPA.stdLvl.Text = reader("Level").ToString

        End While

        command.Parameters.Clear()
        reader.Close()

    End Sub

    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click


        Dim reader As MySqlDataReader
        Dim table As New DataTable()

        command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = stdID.Text

        adapter.SelectCommand = command
        adapter.Fill(table)
        data.openConnection()

        Check_Class.Show()
        reader = command.ExecuteReader()
        While reader.Read()
            Check_Class.StdName.Text = reader("FirstName").ToString
            Check_Class.StdLName.Text = reader("LastName").ToString
            Check_Class.stdID.Text = reader("ID").ToString
            Check_Class.stdLvl.Text = reader("Level").ToString

        End While

        command.Parameters.Clear()
        reader.Close()

    End Sub
End Class