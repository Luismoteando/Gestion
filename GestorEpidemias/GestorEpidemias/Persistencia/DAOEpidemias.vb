Imports MySql.Data.MySqlClient

Public Class DAOEpidemias
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
        Dim sql As String = "SELECT * FROM enfermedad;"
        reader = DBBroker.getDB.read(sql)
        _lista = New Collection
        While reader.Read()
            Dim a As Enfermedad = New Enfermedad()
            a._id = Integer.Parse(reader(0).ToString)
            a._nombre = Convert.ToString(reader(1))
            a._sintomas = Convert.ToString(reader(2))
            a._nfocos = Integer.Parse(reader(3).ToString)
            a._localización = Convert.ToString(reader(4))
            a._incubacion = Convert.ToString(reader(5))
            a._radio = Integer.Parse(reader(6).ToString)
            a._contagiosa = Integer.Parse(reader(7).ToString)
            a._prevencion = Convert.ToString(reader(8))
            a._cura = Convert.ToString(reader(9))

            _lista.Add(a)
        End While
        reader.Close()
    End Sub
End Class
