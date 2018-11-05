Imports MySql.Data.MySqlClient

Public Class RegisterCourses
    Dim db As New Databases()
    Dim adapter As New MySqlDataAdapter()
    Dim checkTable As New DataTable()
    Dim disTab As New DataTable()
    Dim adt As New MySqlDataAdapter
    Dim DCS As New DataTable()
    Dim adCS As New MySqlDataAdapter

    Dim command As New MySqlCommand("Select * from student where ID = @StuID", db.getConnection())



    Private Sub rdFSEM_CheckedChanged(sender As Object, e As EventArgs) Handles rdFSEM.CheckedChanged
        regCourses.Items.Clear()
        Dim item As String

        'For Level 100
        Dim command100 As New MySqlCommand("Select * from courses where Course_level = '100' and Semester = 'First'", db.getConnection())

        'For Level 200
        Dim command200 As New MySqlCommand("Select * from courses where Course_level = '200' and Semester = 'First'", db.getConnection())

        'For Level 300
        Dim command300 As New MySqlCommand("Select * from courses where Course_level = '300' and Semester = 'First'", db.getConnection())

        'For Level 400
        Dim command400 As New MySqlCommand("Select * from courses where Course_level = '400' and Semester = 'First'", db.getConnection())
        Dim reader As MySqlDataReader

        'Display Only Level 100 Courses
        If stdLvl.Text = "100" Then
            db.openConnection()
            reader = command100.ExecuteReader
            While reader.Read
                item = reader("Course_code") & " " & " " & reader("Course_Name")
                regCourses.Items.Add(item)
            End While

        ElseIf stdLvl.Text = "200" Then
            db.openConnection()
            reader = command200.ExecuteReader
            While reader.Read
                item = reader("Course_code") & " " & " " & reader("Course_Name")
                regCourses.Items.Add(item)
            End While

        ElseIf stdLvl.Text = "300" Then
            db.openConnection()
            reader = command300.ExecuteReader
            While reader.Read
                item = reader("Course_code") & " " & " " & reader("Course_Name")
                regCourses.Items.Add(item)
            End While

        Else
            db.openConnection()
            reader = command400.ExecuteReader
            While reader.Read
                item = reader("Course_code") & " " & " " & reader("Course_Name")
                regCourses.Items.Add(item)
            End While

        End If
        db.closeConnection()

    End Sub

    Private Sub rdSecSEM_CheckedChanged(sender As Object, e As EventArgs) Handles rdSecSEM.CheckedChanged
        regCourses.Items.Clear()
        Dim db As New Databases()
        Dim item As String

        'For Level 100
        Dim command100 As New MySqlCommand("Select * from courses where Course_level = '100' and Semester = 'Second'", db.getConnection())

        'For Level 200
        Dim command200 As New MySqlCommand("Select * from courses where Course_level = '200' and Semester = 'Second'", db.getConnection())

        'For Level 300
        Dim command300 As New MySqlCommand("Select * from courses where Course_level = '300' and Semester = 'Second'", db.getConnection())

        'For Level 400
        Dim command400 As New MySqlCommand("Select * from courses where Course_level = '400' and Semester = 'Second'", db.getConnection())
        Dim reader As MySqlDataReader

        'Display Only Level 100 Courses
        If stdLvl.Text = 100 Then
            db.openConnection()
            reader = command100.ExecuteReader
            While reader.Read
                item = reader("Course_code") & " " & " " & reader("Course_Name")
                regCourses.Items.Add(item)
            End While

        ElseIf stdLvl.Text = 200 Then
            db.openConnection()
            reader = command200.ExecuteReader
            While reader.Read
                item = reader("Course_code") & " " & " " & reader("Course_Name")
                regCourses.Items.Add(item)
            End While

        ElseIf stdLvl.Text = 300 Then
            db.openConnection()
            reader = command300.ExecuteReader
            While reader.Read
                item = reader("Course_code") & " " & " " & reader("Course_Name")
                regCourses.Items.Add(item)
            End While

        Else
            db.openConnection()
            reader = command400.ExecuteReader
            While reader.Read
                item = reader("Course_code") & " " & " " & reader("Course_Name")
                regCourses.Items.Add(item)
            End While
        End If
        db.closeConnection()
    End Sub

    Private Sub btnStdClose_Click(sender As Object, e As EventArgs) Handles btnStdClose.Click
        Me.Close()
    End Sub

    Private Sub btnStdReg_Click(sender As Object, e As EventArgs) Handles btnStdReg.Click
        Dim str As String = ""
        Dim Course_code As String = ""
        Dim Course_name As String = ""
        Dim i As Integer
        db.openConnection()

        If regCourses.CheckedItems.Count > 0 Then
            checkTable.Clear()

            For i = 0 To regCourses.CheckedItems.Count - 1
                str = regCourses.CheckedItems(i).ToString()
                Course_code = Microsoft.VisualBasic.Left(str, 8)
                Course_name = Mid(str, 9)

                Dim details As New MySqlCommand("Select * from registration_grade where StudentID = @ID and Course_Code = @Code ", db.getConnection())

                Dim getCS As New MySqlCommand("Select * from courses where Course_Code = @CSC", db.getConnection())
                details.Parameters.Add("@ID", MySqlDbType.VarChar).Value = stdID.Text
                details.Parameters.Add("@Code", MySqlDbType.VarChar).Value = Course_code
                getCS.Parameters.Add("@CSC", MySqlDbType.VarChar).Value = Course_code


                adCS.SelectCommand = getCS
                adCS.Fill(DCS)



                adapter.SelectCommand = details
                adapter.Fill(checkTable)
                db.openConnection()

                If checkTable.Rows.Count = 0 Then
                    Dim register As New MySqlCommand("Insert into registration_grade(StudentID, Course_Code, Course_Name, Credits) values(@StudID, @C_Code, @C_Name,@Credits)", db.getConnection())
                    db.openConnection()
                    register.Parameters.Add("@StudID", MySqlDbType.VarChar).Value = stdID.Text
                    register.Parameters.Add("@C_Code", MySqlDbType.VarChar).Value = Course_code
                    register.Parameters.Add("@C_Name", MySqlDbType.VarChar).Value = Course_name
                    register.Parameters.Add("@Credits", MySqlDbType.VarChar).Value = DCS.Rows.Item(i).Item("Credits")

                    adapter.SelectCommand = register
                    register.ExecuteNonQuery()

                    Dim reader As MySqlDataReader
                    Dim table As New DataTable()

                    command.Parameters.Add("@StuID", MySqlDbType.VarChar).Value = stdID.Text

                    adapter.SelectCommand = command
                    adapter.Fill(table)
                    db.openConnection()


                    reader = command.ExecuteReader()
                    While reader.Read()
                        Proof_of_registration.StdName.Text = reader("FirstName").ToString
                        Proof_of_registration.StdLName.Text = reader("LastName").ToString
                        Proof_of_registration.stdID.Text = reader("ID").ToString
                        Proof_of_registration.stdLvl.Text = reader("Level").ToString
                        Proof_of_registration.detailsID.Text = reader("ID").ToString
                        Proof_of_registration.detailsFName.Text = reader("FirstName").ToString
                        Proof_of_registration.detailsLName.Text = reader("LastName").ToString
                        Proof_of_registration.detailsMajor.Text = reader("Major").ToString
                        Proof_of_registration.detailsLevel.Text = reader("Level").ToString
                        Proof_of_registration.Noreg.Text = regCourses.CheckedItems.Count

                    End While

                    command.Parameters.Clear()
                    reader.Close()

                    Proof_of_registration.display.Items.Add(str)
                    Proof_of_registration.Show()


                Else
                    MsgBox("You have already registered for " & Course_code)
                End If


            Next






        Else
            MsgBox("Please Select Semester and Select Courses To Register")
            While (regCourses.CheckedItems.Count > 0)
                regCourses.SetItemChecked(regCourses.CheckedIndices(0), False)
            End While

        End If

    End Sub
End Class