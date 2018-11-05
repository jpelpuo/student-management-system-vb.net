Imports MySql.Data.MySqlClient


Public Class Upload_grades
    Dim db As New Databases()
    Dim adapter As New MySqlDataAdapter()
    Dim Dtable As New DataTable
    Dim getCourse As New MySqlCommand("Select * from courses", db.getConnection())
    Dim DGrade As String = " "
    Dim DGradepoint As Double
    Dim DCredits As Integer
    Dim DMarks As Integer
    Dim Reg As Integer
    Dim i As Integer


    Private Sub Upload_grades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dTab As New DataTable
        db.openConnection()
        adapter.SelectCommand = getCourse
        adapter.Fill(dTab)

        crs.DataSource = dTab

        crs.DisplayMember = "Course_Code"
        crs.ValueMember = "Course_Code"
    End Sub

    Private Sub crs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles crs.SelectedIndexChanged
        Dtable.Clear()
        Dim details As New MySqlCommand("Select RegID,StudentID,Course_Code,Course_Name,Credits,Marks,Grade from registration_grade where Course_code = @Code", db.getConnection())

        details.Parameters.AddWithValue("@Code", crs.SelectedValue)



        db.openConnection()
        adapter.SelectCommand = details
        adapter.Fill(Dtable)

        datagrid.DataSource = Dtable
        datagrid.Columns("RegID").ReadOnly = True
        datagrid.Columns("StudentID").ReadOnly = True
        datagrid.Columns("Course_Code").ReadOnly = True
        datagrid.Columns("Course_Name").ReadOnly = True
        datagrid.Columns("Credits").ReadOnly = True
        datagrid.Columns("Grade").ReadOnly = True

        regNo.Text = Dtable.Rows.Count

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click

        If datagrid.Rows.Count = 0 Then
            MsgBox("No Grades Uploaded, Please Select Course And Type Grades")

        Else
            For i = 0 To datagrid.Rows.Count - 1
                DGrade = datagrid.Rows(i).Cells("Grade").Value
                DMarks = datagrid.Rows(i).Cells("Marks").Value
                Reg = datagrid.Rows(i).Cells("RegID").Value

                If DMarks >= 0 And DMarks <= 100 And DGrade = "" Then
                    MsgBox("Please Click Compute to Compute Grade for " & DMarks & " for Registration ID " & Reg)

                Else
                    Dim builder As New MySqlCommandBuilder(adapter)
                    adapter.Update(Dtable)

                    MsgBox("Grades Uploaded Successfully")
                End If
            Next

        End If

    End Sub

    Private Sub btnStdClose_Click(sender As Object, e As EventArgs) Handles btnStdClose.Click
        Me.Close()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        If datagrid.Rows.Count > 0 Then
            For i = 0 To datagrid.Rows.Count - 1
                DMarks = datagrid.Rows(i).Cells("Marks").Value

                If DMarks = 0 Then
                    DGrade = " "

                Else
                    If DMarks >= 80 And DMarks <= 100 Then
                        DGrade = "A"

                    ElseIf DMarks >= 75 And DMarks < 80 Then
                        DGrade = "B+"

                    ElseIf DMarks >= 70 And DMarks < 75 Then
                        DGrade = "B"

                    ElseIf DMarks >= 65 And DMarks < 70 Then
                        DGrade = "C+"

                    ElseIf DMarks >= 60 And DMarks < 65 Then
                        DGrade = "C"

                    ElseIf DMarks >= 55 And DMarks < 60 Then
                        DGrade = "D+"

                    ElseIf DMarks >= 50 And DMarks < 55 Then
                        DGrade = "D"

                    ElseIf DMarks >= 45 And DMarks < 50 Then
                        DGrade = "E"

                    ElseIf DMarks > 100 Or DMarks < 0 Then
                        MsgBox("Please Enter number between 0 and 100.")
                        DGrade = " "
                    Else
                        DGrade = "F"
                    End If

                End If

                datagrid.Rows(i).Cells("Grade").Value = DGrade
            Next
        End If
    End Sub
End Class