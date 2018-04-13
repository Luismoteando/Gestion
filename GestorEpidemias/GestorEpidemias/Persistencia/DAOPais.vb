Imports MySql.Data.MySqlClient

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
            Dim a As Pais = New Pais()
            a.Codigo1 = Convert.ToString(reader(0))
            a.Nombre1 = Convert.ToString(reader(1))
            a.Capital1 = Convert.ToString(reader(2))
            a.Habitantes1 = Integer.Parse(reader(3).ToString)
            a.Superficie1 = Convert.ToString(reader(5))

            _lista.Add(a)
        End While
        reader.Close()
    End Sub
End Class
