Imports MySql.Data.MySqlClient


Public Class Check_Class
    Dim db As New Databases()
    Dim adapter As New MySqlDataAdapter()
    Dim command As New MySqlCommand("Select * from student where ID = @ID", db.getConnection())
    Dim details As New MySqlCommand("Select * from registration_grade where ID = @ID", db.getConnection())
    Dim tab As New DataTable()
    Dim i As Integer
    Dim DGrade As String = " "
    Dim DGradepoint As Double
    Dim DCredits As Integer
    Dim GPA As Double
    Dim SumG As Integer = 0
    Dim SumC As Integer = 0

    Private Sub btnStdClose_Click(sender As Object, e As EventArgs) Handles btnStdClose.Click
        Me.Close()
    End Sub

    Private Sub rdFSEM_CheckedChanged(sender As Object, e As EventArgs) Handles rdFSEM.CheckedChanged
        tab.Clear()
        Dim grade As New MySqlCommand("Select Course_Code, Course_Name, Credits, Grade, Gradepoint from registration_grade where StudentID = @ID and (Course_Code like '%0' or Course_Code like '%1' or Course_Code like '%3' or Course_Code like '%5' or Course_Code like '%7' or Course_code like '%9')", db.getConnection())

        grade.Parameters.AddWithValue("@ID", Student_Options.stdID.Text)
        adapter.SelectCommand = grade
        adapter.Fill(tab)

        db.openConnection()

        gradesview.DataSource = tab
        If gradesview.Rows.Count > 0 Then
            For i = 0 To gradesview.Rows.Count - 1
                DGrade = gradesview.Rows(i).Cells("Grade").Value
                DCredits = gradesview.Rows(i).Cells("Credits").Value

                If DGrade = "A" And DCredits = 3 Then
                    DGradepoint = 4 * 3

                    If DGrade = "A" And DCredits = 2 Then
                        DGradepoint = 4 * 2
                    End If

                    If DGrade = "A" And DCredits = 1 Then
                        DGradepoint = 4 * 1
                    End If

                ElseIf DGrade = "B+" And DCredits = 3 Then
                    DGradepoint = 3.5 * 3

                    If DGrade = "B+" And DCredits = 2 Then
                        DGradepoint = 3.5 * 2
                    End If

                    If DGrade = "B+" And DCredits = 1 Then
                        DGradepoint = 3.5 * 1
                    End If

                ElseIf DGrade = "B" And DCredits = 3 Then
                    DGradepoint = 3 * 3

                    If DGrade = "B" And DCredits = 2 Then
                        DGradepoint = 3 * 2
                    End If

                    If DGrade = "B" And DCredits = 1 Then
                        DGradepoint = 3 * 1
                    End If

                ElseIf DGrade = "C+" And DCredits = 3 Then
                    DGradepoint = 2.5 * 3

                    If DGrade = "C+" And DCredits = 2 Then
                        DGradepoint = 2.5 * 2
                    End If

                    If DGrade = "C+" And DCredits = 1 Then
                        DGradepoint = 2.5 * 1
                    End If

                ElseIf DGrade = "C" And DCredits = 3 Then
                    DGradepoint = 2 * 3

                    If DGrade = "C" And DCredits = 2 Then
                        DGradepoint = 2 * 2
                    End If

                    If DGrade = "C" And DCredits = 1 Then
                        DGradepoint = 2 * 1
                    End If

                ElseIf DGrade = "D+" And DCredits = 3 Then
                    DGradepoint = 1.5 * 3

                    If DGrade = "D+" And DCredits = 2 Then
                        DGradepoint = 1.5 * 2
                    End If

                    If DGrade = "D+" And DCredits = 1 Then
                        DGradepoint = 1.5 * 1
                    End If

                ElseIf DGrade = "D" And DCredits = 3 Then
                    DGradepoint = 1 * 3

                    If DGrade = "D+" And DCredits = 2 Then
                        DGradepoint = 1 * 2
                    End If

                    If DGrade = "D+" And DCredits = 1 Then
                        DGradepoint = 1 * 1
                    End If

                ElseIf DGrade = "E" And DCredits = 3 Then
                    DGradepoint = 0.5 * 3

                    If DGrade = "E" And DCredits = 2 Then
                        DGradepoint = 0.5 * 2
                    End If

                    If DGrade = "E" And DCredits = 1 Then
                        DGradepoint = 0.5 * 1
                    End If

                ElseIf DGrade = "F" And DCredits = 3 Then
                    DGradepoint = 0 * 3

                    If DGrade = "F" And DCredits = 2 Then
                        DGradepoint = 0 * 2
                    End If

                    If DGrade = "F" And DCredits = 1 Then
                        DGradepoint = 0 * 1
                    End If

                ElseIf DGrade = "" And DCredits = 3 Then
                    DGradepoint = 0

                    If DGrade = "" And DCredits = 2 Then
                        DGradepoint = 0
                    End If

                    If DGrade = "" And DCredits = 1 Then
                        DGradepoint = 0
                    End If
                End If
                gradesview.Rows(i).Cells("Gradepoint").Value = DGradepoint
            Next
        End If
    End Sub

    Private Sub rdSecSEM_CheckedChanged(sender As Object, e As EventArgs) Handles rdSecSEM.CheckedChanged
        tab.Clear()
        Dim grade As New MySqlCommand("Select Course_Code, Course_Name, Credits, Grade, Gradepoint from registration_grade where StudentID = @ID and (Course_Code like '%0' or Course_Code like '%2' or Course_Code like '%4' or Course_Code like '%6' or Course_Code like '%8')", db.getConnection())



        grade.Parameters.Add("@ID", MySqlDbType.VarChar).Value = stdID.Text

        adapter.SelectCommand = grade
        adapter.Fill(tab)

        db.openConnection()

        gradesview.DataSource = tab

        If gradesview.Rows.Count > 0 Then
            For i = 0 To gradesview.Rows.Count - 1
                DGrade = gradesview.Rows(i).Cells("Grade").Value
                DCredits = gradesview.Rows(i).Cells("Credits").Value
                If DGrade = "A" And DCredits = 3 Then
                    DGradepoint = 4 * 3

                    If DGrade = "A" And DCredits = 2 Then
                        DGradepoint = 4 * 2
                    End If

                    If DGrade = "A" And DCredits = 1 Then
                        DGradepoint = 4 * 1
                    End If

                ElseIf DGrade = "B+" And DCredits = 3 Then
                    DGradepoint = 3.5 * 3

                    If DGrade = "B+" And DCredits = 2 Then
                        DGradepoint = 3.5 * 2
                    End If

                    If DGrade = "B+" And DCredits = 1 Then
                        DGradepoint = 3.5 * 1
                    End If

                ElseIf DGrade = "B" And DCredits = 3 Then
                    DGradepoint = 3 * 3

                    If DGrade = "B" And DCredits = 2 Then
                        DGradepoint = 3 * 2
                    End If

                    If DGrade = "B" And DCredits = 1 Then
                        DGradepoint = 3 * 1
                    End If

                ElseIf DGrade = "C+" And DCredits = 3 Then
                    DGradepoint = 2.5 * 3

                    If DGrade = "C+" And DCredits = 2 Then
                        DGradepoint = 2.5 * 2
                    End If

                    If DGrade = "C+" And DCredits = 1 Then
                        DGradepoint = 2.5 * 1
                    End If

                ElseIf DGrade = "C" And DCredits = 3 Then
                    DGradepoint = 2 * 3

                    If DGrade = "C" And DCredits = 2 Then
                        DGradepoint = 2 * 2
                    End If

                    If DGrade = "C" And DCredits = 1 Then
                        DGradepoint = 2 * 1
                    End If

                ElseIf DGrade = "D+" And DCredits = 3 Then
                    DGradepoint = 1.5 * 3

                    If DGrade = "D+" And DCredits = 2 Then
                        DGradepoint = 1.5 * 2
                    End If

                    If DGrade = "D+" And DCredits = 1 Then
                        DGradepoint = 1.5 * 1
                    End If

                ElseIf DGrade = "D" And DCredits = 3 Then
                    DGradepoint = 1 * 3

                    If DGrade = "D+" And DCredits = 2 Then
                        DGradepoint = 1 * 2
                    End If

                    If DGrade = "D+" And DCredits = 1 Then
                        DGradepoint = 1 * 1
                    End If

                ElseIf DGrade = "E" And DCredits = 3 Then
                    DGradepoint = 0.5 * 3

                    If DGrade = "E" And DCredits = 2 Then
                        DGradepoint = 0.5 * 2
                    End If

                    If DGrade = "E" And DCredits = 1 Then
                        DGradepoint = 0.5 * 1
                    End If

                ElseIf DGrade = "F" And DCredits = 3 Then
                    DGradepoint = 0 * 3

                    If DGrade = "F" And DCredits = 2 Then
                        DGradepoint = 0 * 2
                    End If

                    If DGrade = "F" And DCredits = 1 Then
                        DGradepoint = 0 * 1
                    End If

                ElseIf DGrade = "" And DCredits = 3 Then
                    DGradepoint = 0

                    If DGrade = "" And DCredits = 2 Then
                        DGradepoint = 0
                    End If

                    If DGrade = "" And DCredits = 1 Then
                        DGradepoint = 0
                    End If
                End If

                gradesview.Rows(i).Cells("Gradepoint").Value = DGradepoint
            Next
        End If
    End Sub

    Private Sub allSems_CheckedChanged(sender As Object, e As EventArgs) Handles allSems.CheckedChanged
        tab.Clear()
        Dim grade As New MySqlCommand("Select Course_Code, Course_Name, Credits, Grade, Gradepoint from registration_grade where StudentID = @SID", db.getConnection())



        grade.Parameters.Add("@SID", MySqlDbType.VarChar).Value = stdID.Text

        adapter.SelectCommand = grade
        adapter.Fill(tab)

        db.openConnection()

        gradesview.DataSource = tab
        If gradesview.Rows.Count > 0 Then
            For i = 0 To gradesview.Rows.Count - 1
                DGrade = gradesview.Rows(i).Cells("Grade").Value
                DCredits = gradesview.Rows(i).Cells("Credits").Value

                If DGrade = "A" And DCredits = 3 Then
                    DGradepoint = 4 * 3

                    If DGrade = "A" And DCredits = 2 Then
                        DGradepoint = 4 * 2
                    End If

                    If DGrade = "A" And DCredits = 1 Then
                        DGradepoint = 4 * 1
                    End If

                ElseIf DGrade = "B+" And DCredits = 3 Then
                    DGradepoint = 3.5 * 3

                    If DGrade = "B+" And DCredits = 2 Then
                        DGradepoint = 3.5 * 2
                    End If

                    If DGrade = "B+" And DCredits = 1 Then
                        DGradepoint = 3.5 * 1
                    End If

                ElseIf DGrade = "B" And DCredits = 3 Then
                    DGradepoint = 3 * 3

                    If DGrade = "B" And DCredits = 2 Then
                        DGradepoint = 3 * 2
                    End If

                    If DGrade = "B" And DCredits = 1 Then
                        DGradepoint = 3 * 1
                    End If

                ElseIf DGrade = "C+" And DCredits = 3 Then
                    DGradepoint = 2.5 * 3

                    If DGrade = "C+" And DCredits = 2 Then
                        DGradepoint = 2.5 * 2
                    End If

                    If DGrade = "C+" And DCredits = 1 Then
                        DGradepoint = 2.5 * 1
                    End If

                ElseIf DGrade = "C" And DCredits = 3 Then
                    DGradepoint = 2 * 3

                    If DGrade = "C" And DCredits = 2 Then
                        DGradepoint = 2 * 2
                    End If

                    If DGrade = "C" And DCredits = 1 Then
                        DGradepoint = 2 * 1
                    End If

                ElseIf DGrade = "D+" And DCredits = 3 Then
                    DGradepoint = 1.5 * 3

                    If DGrade = "D+" And DCredits = 2 Then
                        DGradepoint = 1.5 * 2
                    End If

                    If DGrade = "D+" And DCredits = 1 Then
                        DGradepoint = 1.5 * 1
                    End If

                ElseIf DGrade = "D" And DCredits = 3 Then
                    DGradepoint = 1 * 3

                    If DGrade = "D+" And DCredits = 2 Then
                        DGradepoint = 1 * 2
                    End If

                    If DGrade = "D+" And DCredits = 1 Then
                        DGradepoint = 1 * 1
                    End If

                ElseIf DGrade = "E" And DCredits = 3 Then
                    DGradepoint = 0.5 * 3

                    If DGrade = "E" And DCredits = 2 Then
                        DGradepoint = 0.5 * 2
                    End If

                    If DGrade = "E" And DCredits = 1 Then
                        DGradepoint = 0.5 * 1
                    End If

                ElseIf DGrade = "F" And DCredits = 3 Then
                    DGradepoint = 0 * 3

                    If DGrade = "F" And DCredits = 2 Then
                        DGradepoint = 0 * 2
                    End If

                    If DGrade = "F" And DCredits = 1 Then
                        DGradepoint = 0 * 1
                    End If

                ElseIf DGrade = "" And DCredits = 3 Then
                    DGradepoint = 0

                    If DGrade = "" And DCredits = 2 Then
                        DGradepoint = 0
                    End If

                    If DGrade = "" And DCredits = 1 Then
                        DGradepoint = 0
                    End If
                End If

                gradesview.Rows(i).Cells("Gradepoint").Value = DGradepoint
            Next
        End If
    End Sub

    Private Sub btnStdReg_Click(sender As Object, e As EventArgs) Handles btnStdReg.Click
        If gradesview.Rows.Count = 0 Then
            MsgBox("Please Select Semester Before Clicking Class To see Class")

        Else
            If gradesview.Rows.Count > 0 Then
                For i = 0 To gradesview.Rows.Count - 1
                    DGradepoint = gradesview.Rows(i).Cells("Gradepoint").Value
                    DCredits = gradesview.Rows(i).Cells("Credits").Value

                    SumG += DGradepoint
                    SumC += DCredits

                Next

                GPA = (SumG / SumC)

                Sgpa.Visible = True

                Sgpa.Text = Math.Round(GPA, 2, MidpointRounding.AwayFromZero)


                If GPA > 3.6 Then
                    SClass.Visible = True
                    SClass.Text = "First Class"

                ElseIf GPA >= 3 And GPA < 3.6 Then
                    SClass.Visible = True
                    SClass.Text = "Second Class Upper"

                ElseIf GPA >= 2 And GPA < 3.0 Then
                    SClass.Visible = True
                    SClass.Text = "Second Class Lower"

                ElseIf GPA >= 1.5 And GPA < 2.0 Then
                    SClass.Visible = True
                    SClass.Text = "Third Class"

                ElseIf GPA >= 1.0 And GPA < 1.5 Then
                    SClass.Visible = True
                    SClass.Text = "Pass"

                Else
                    SClass.Visible = True
                    SClass.Text = "Fail"
                End If
            End If
        End If

    End Sub
End Class