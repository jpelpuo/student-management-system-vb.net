Imports MySql.Data.MySqlClient

Public Class Databases
    ' Create new mysql connection
    Private MySQLConnect As New MySqlConnection("host = localhost; user = root; database = VBProject")

    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return MySQLConnect
        End Get
    End Property

    ' Open connection if connection is closed
    Sub openConnection()
        If MySQLConnect.State = ConnectionState.Closed Then
            MySQLConnect.Open()
        End If
    End Sub

    ' Close connection if connection is open
    Sub closeConnection()
        If MySQLConnect.State = ConnectionState.Open Then
            MySQLConnect.Close()
        End If
    End Sub
End Class
