Imports MySql.Data.MySqlClient


Public Class Check_Grades
    Dim db As New Databases()
    Dim adapter As New MySqlDataAdapter()
    Dim command As New MySqlCommand("Select * from student where ID = @ID", db.getConnection())
    Dim details As New MySqlCommand("Select * from registration_grade where ID = @ID", db.getConnection())
    Dim tab As New DataTable()

    Private Sub btnStdClose_Click(sender As Object, e As EventArgs) Handles btnStdClose.Click
        Me.Close()
    End Sub

    Private Sub rdFSEM_CheckedChanged(sender As Object, e As EventArgs) Handles rdFSEM.CheckedChanged
        tab.Clear()
        Dim grade As New MySqlCommand("Select Course_Code, Course_Name, Credits, Grade from registration_grade where StudentID = @ID and (Course_Code like '%0' or Course_Code like '%1' or Course_Code like '%3' or Course_Code like '%5' or Course_Code like '%7' or Course_code like '%9')", db.getConnection())

        grade.Parameters.AddWithValue("@ID", Student_Options.stdID.Text)
        adapter.SelectCommand = grade
        adapter.Fill(tab)

        db.openConnection()

        gradesview.DataSource = tab


    End Sub

    Private Sub rdSecSEM_CheckedChanged(sender As Object, e As EventArgs) Handles rdSecSEM.CheckedChanged
        tab.Clear()
        Dim grade As New MySqlCommand("Select Course_Code, Course_Name, Credits, Grade from registration_grade where StudentID = @ID and (Course_Code like '%0' or Course_Code like '%2' or Course_Code like '%4' or Course_Code like '%6' or Course_Code like '%8')", db.getConnection())



        grade.Parameters.Add("@ID", MySqlDbType.VarChar).Value = stdID.Text

        adapter.SelectCommand = grade
        adapter.Fill(tab)

        db.openConnection()

        gradesview.DataSource = tab
    End Sub

    Private Sub allSems_CheckedChanged(sender As Object, e As EventArgs) Handles allSems.CheckedChanged
        tab.Clear()
        Dim grade As New MySqlCommand("Select Course_Code, Course_Name, Credits, Grade from registration_grade where StudentID = @SID", db.getConnection())



        grade.Parameters.Add("@SID", MySqlDbType.VarChar).Value = stdID.Text

        adapter.SelectCommand = grade
        adapter.Fill(tab)

        db.openConnection()

        gradesview.DataSource = tab
    End Sub
End Class