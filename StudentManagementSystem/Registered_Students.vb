Imports MySql.Data.MySqlClient


Public Class Registered_Students
    Dim db As New Databases()
    Dim adapter As New MySqlDataAdapter()
    Dim Dtable As New DataTable
    Dim getCourse As New MySqlCommand("Select * from courses", db.getConnection())

    Private Sub crs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles regCrs.SelectedIndexChanged
        Dtable.Clear()
        Dim details As New MySqlCommand("Select RegID, StudentID, Course_Code, Course_Name from registration_grade where Course_code = @Code", db.getConnection())

        details.Parameters.AddWithValue("@Code", regCrs.SelectedValue)



        db.openConnection()
        adapter.SelectCommand = details
        adapter.Fill(Dtable)


        datagrid.DataSource = Dtable

        regNo.Text = Dtable.Rows.Count
    End Sub

    Private Sub Registered_Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dTab As New DataTable
        db.openConnection()
        adapter.SelectCommand = getCourse
        adapter.Fill(dTab)

        regCrs.DataSource = dTab

        regCrs.DisplayMember = "Course_Code"
        regCrs.ValueMember = "Course_Code"
    End Sub

    Private Sub btnStdClose_Click(sender As Object, e As EventArgs) Handles btnStdClose.Click
        Me.Close()
    End Sub
End Class