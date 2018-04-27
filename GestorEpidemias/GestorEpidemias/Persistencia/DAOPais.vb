Imports MySql.Data.MySqlClient
Imports MySql.Data.Types

Public Class DAOPais
    Private _lista As Collection

    Public Property lista As Collection
        Get
            Return _lista
        End Get
        Set(value As Collection)
            _lista = value
        End Set
    End Property

    Public Sub readAll()
        Dim reader As MySqlDataReader
        Dim sql As String = "SELECT * FROM pais;"
        reader = DBBroker.getDB.read(sql)
        _lista = New Collection
        While reader.Read()
            Try
                Dim pais As Pais = New Pais()
                pais.Codigo1 = Convert.ToString(reader(0))
                Pais.Nombre1 = Convert.ToString(reader(1))
                pais.Capital1 = Convert.ToString(reader(2))
                pais.Habitantes1 = Integer.Parse(reader(3).ToString)
                pais.Latlon1 = reader.GetMySqlGeometry(4)
                pais.Superficie1 = Convert.ToString(reader(5))
                _lista.Add(pais)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End While

        reader.Close()
    End Sub


    Public Sub readByName(ByRef p As Pais)
        Dim reader As MySqlDataReader
        Dim sql As String = "SELECT * FROM pais WHERE Nombre='" & p.Nombre1 & "';"
        reader = DBBroker.getDB.read(sql)

        While reader.Read()
            p.Codigo1 = Convert.ToString(reader(0))
            p.Capital1 = Convert.ToString(reader(2))
            p.Habitantes1 = Integer.Parse(reader(3).ToString)
            p.Latlon1 = reader.GetMySqlGeometry(4)
            p.Superficie1 = Convert.ToString(reader(5))
        End While
        reader.Close()
    End Sub


End Class
