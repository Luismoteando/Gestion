Imports MySql.Data.MySqlClient
Imports MySql.Data.Types

Public Class DAOEnfermedad
    Private _lista As Collection

    Public Property lista As Collection
        Get
            Return _lista
        End Get
        Set(value As Collection)
            _lista = value
        End Set
    End Property

    Public Function readLatLon(ByVal enf As Enfermedad) As MySqlGeometry
        Dim reader As MySqlDataReader
        Dim latlon As MySqlGeometry
        Dim sql As String = "SELECT X(LatLon), Y(LatLon) FROM pais WHERE Nombre=(SELECT `Localización de focos` FROM enfermedad WHERE ID=" & enf._id & ");"
        reader = DBBroker.getDB.read(sql)

        reader.Read()
        latlon = New MySqlGeometry(Double.Parse(reader(0).ToString), Double.Parse(reader(1).ToString))
        reader.Close()

        Return latlon
    End Function

    Public Sub readByName(ByRef enf As Enfermedad)
        Dim reader As MySqlDataReader
        Dim sql As String = "SELECT * FROM enfermedad WHERE Nombre='" & enf._nombre & "';"
        reader = DBBroker.getDB.read(sql)

        reader.Read()
        enf._id = Integer.Parse(reader(0).ToString)
        enf._nombre = Convert.ToString(reader(1))
        enf._sintomas = Convert.ToString(reader(2))
        enf._nfocos = Integer.Parse(reader(3).ToString)
        enf._localización = Convert.ToString(reader(4))
        enf._incubacion = Convert.ToString(reader(5))
        enf._radio = Integer.Parse(reader(6).ToString)
        enf._contagiosa = Integer.Parse(reader(7).ToString)
        enf._prevencion = Convert.ToString(reader(8))
        enf._cura = Convert.ToString(reader(9))
        reader.Close()
    End Sub

    Public Sub readAllByCountry(ByVal pais As Pais)
        Dim reader As MySqlDataReader
        Dim sql As String = "SELECT * FROM enfermedad WHERE `Localización de focos`='" & pais.Nombre1 & "';"
        reader = DBBroker.getDB.read(sql)
        _lista = New Collection

        While reader.Read()
            Dim enf As Enfermedad = New Enfermedad()
            enf._id = Integer.Parse(reader(0).ToString)
            enf._nombre = Convert.ToString(reader(1))
            enf._sintomas = Convert.ToString(reader(2))
            enf._nfocos = Integer.Parse(reader(3).ToString)
            enf._localización = Convert.ToString(reader(4))
            enf._incubacion = Convert.ToString(reader(5))
            enf._radio = Integer.Parse(reader(6).ToString)
            enf._contagiosa = Integer.Parse(reader(7).ToString)
            enf._prevencion = Convert.ToString(reader(8))
            enf._cura = Convert.ToString(reader(9))

            _lista.Add(enf)
        End While
        reader.Close()
    End Sub

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
