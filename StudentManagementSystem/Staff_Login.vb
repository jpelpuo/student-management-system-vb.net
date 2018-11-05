Imports MySql.Data.MySqlClient

Public Class Staff_Login
    Dim reader As MySqlDataReader
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnStfClose.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If txtStfPIN.PasswordChar = "*" Then
            txtStfPIN.PasswordChar = ""

        Else
            txtStfPIN.PasswordChar = "*"
        End If
    End Sub


    Private Sub txtStfPIN_TextChanged(sender As Object, e As EventArgs) Handles txtStfPIN.TextChanged

    End Sub

    Private Sub btnStfLogin_Click(sender As Object, e As EventArgs) Handles btnStfLogin.Click
        ' Create variables for working with the database
        Dim database As New Databases()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("Select * from staff where ID = @ID and PIN = @PIN", database.getConnection())

        command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = txtStfID.Text
        command.Parameters.Add("@PIN", MySqlDbType.VarChar).Value = txtStfPIN.Text

        database.openConnection()
        adapter.SelectCommand = command
        adapter.Fill(table)

        'Check whether details entailed are present in the database 
        If table.Rows.Count = 0 Then
            If txtStfID.Text = "" And txtStfPIN.Text = "" Then
                MsgBox("Please Enter ID and PIN", MsgBoxStyle.Critical, "Login Error")

            ElseIf txtStfID.Text = "" Then
                MsgBox("Please Enter ID", MsgBoxStyle.Critical, "Login Error")

            ElseIf txtStfPIN.Text = "" Then
                MsgBox("Please Enter PIN", MsgBoxStyle.Critical, "Login Error")

            Else
                MsgBox("Invalid ID or PIN", MsgBoxStyle.Critical, "Login Error")
            End If
        Else
            Staff_Options.Show()
            reader = command.ExecuteReader()
            While reader.Read()
                Staff_Options.detailsID.Text = reader("ID").ToString
                Staff_Options.detailsFName.Text = reader("FirstName").ToString
                Staff_Options.detailsLName.Text = reader("LastName").ToString
                Staff_Options.detailsdept.Text = reader("Department").ToString
                Staff_Options.detailsPost.Text = reader("Position").ToString

            End While
            Me.Close()
        End If
    End Sub

    Private Sub Staff_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class