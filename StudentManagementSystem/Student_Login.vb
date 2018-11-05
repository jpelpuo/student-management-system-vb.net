Imports MySql.Data.MySqlClient

Public Class Student_Login
    Dim reader As MySqlDataReader
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Create variables for working with the database
        Dim database As New Databases()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("Select * from student where ID = @ID and PIN = @PIN", database.getConnection())

        command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = txtID.Text
        command.Parameters.Add("@PIN", MySqlDbType.VarChar).Value = txtPIN.Text

        adapter.SelectCommand = command
        adapter.Fill(table)
        database.openConnection()

        'Check whether details entailed are present in the database 
        If table.Rows.Count = 0 Then
            If txtID.Text = "" And txtPIN.Text = "" Then
                MsgBox("Please Enter ID and PIN", MsgBoxStyle.Critical, "Login Error")

            ElseIf txtID.Text = "" Then
                MsgBox("Please Enter ID", MsgBoxStyle.Critical, "Login Error")

            ElseIf txtPIN.Text = "" Then
                MsgBox("Please Enter PIN", MsgBoxStyle.Critical, "Login Error")

            Else
                MsgBox("Invalid ID or PIN", MsgBoxStyle.Critical, "Login Error")
            End If


        Else
            'Display the details of the student in the next form
            Student_Options.Show()
            reader = command.ExecuteReader()
            While reader.Read()
                Student_Options.StdName.Text = reader("FirstName").ToString
                Student_Options.stdLName.Text = reader("LastName").ToString
                Student_Options.stdID.Text = reader("ID").ToString
                Student_Options.stdLvl.Text = reader("Level").ToString

            End While
            Me.Close()
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If txtPIN.PasswordChar = "*" Then
            txtPIN.PasswordChar = ""

        Else
            txtPIN.PasswordChar = "*"
        End If
    End Sub

End Class