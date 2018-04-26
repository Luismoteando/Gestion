Imports MySql.Data.MySqlClient

Public Class DAOViaje
    Public Sub readViaje(ByRef viaje As Viaje)

        Dim reader As MySqlDataReader
        Dim sql As String = "SELECT * FROM viaje WHERE Empleado =" & viaje.Emp1.Dni & ";"
        reader = DBBroker.getDB.read(sql)

        While reader.Read()
            viaje.Id1 = Integer.Parse(reader(0).ToString)
            viaje.Destino1 = New Pais(reader(1).ToString)
            viaje.Emp1 = New Empleado(Integer.Parse(reader(4).ToString))
        End While
        reader.Close()
    End Sub
End Class
