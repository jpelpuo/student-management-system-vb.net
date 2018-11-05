Imports MySql.Data.MySqlClient
Public Class CourseRegistration
    Dim db As New Databases()
    Dim item As String
    ' Function to get the first semester courses 
    Function getFSemCourse() As String
        Dim command As New MySqlCommand("Select * from fsem_course", db.getConnection())
        Dim reader As MySqlDataReader

        db.openConnection()
        reader = command.ExecuteReader
        While reader.Read
            item = reader("Course_code") & " " & reader("Course_Name")
        End While


        db.closeConnection()
        Return item
    End Function

    ' Function to get second semester courses
    Function getSecCourse() As Boolean
        Dim command As New MySqlCommand("Select * from fsem_course", db.getConnection())
        Return True
    End Function
End Class
