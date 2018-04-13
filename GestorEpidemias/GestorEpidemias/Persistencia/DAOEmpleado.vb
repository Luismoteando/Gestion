Imports MySql.Data.MySqlClient

Public Class DAOEmpleado
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
        Dim sql As String = "SELECT * FROM empleado;"
        reader = DBBroker.getDB.read(sql)
        _lista = New Collection
        While reader.Read()
            Dim a As Empleado = New Empleado()
            a.Dni = Integer.Parse(reader(0).ToString)
            a.Nombre = Convert.ToString(reader(1))
            a.Apellidos = Convert.ToString(reader(2))
            a.Telefono = Integer.Parse(reader(3).ToString)
            a.Email = Convert.ToString(reader(4))
            a.Departamento = Convert.ToString(reader(5))

            _lista.Add(a)
        End While
        reader.Close()
    End Sub
End Class

