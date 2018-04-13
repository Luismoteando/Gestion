
Imports MySql.Data.MySqlClient

Public Class DBBroker

    Public Shared mConexion As MySqlConnection
    Private Shared instancia As DBBroker

    Public Sub New()
        Try
            mConexion = New MySqlConnection()
            mConexion.ConnectionString = "Server=localhost; Port=3306; Database=epidemias; Uid ='root'; pwd ='';"
            mConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function read(ByVal sql As String) As MySqlDataReader
        Dim cmd = New MySqlCommand(sql, mConexion)
        Return cmd.ExecuteReader()
    End Function

    Public Shared Function getDB() As DBBroker
        If instancia Is Nothing Then
            instancia = New DBBroker()
        End If
        Return instancia
    End Function
End Class

