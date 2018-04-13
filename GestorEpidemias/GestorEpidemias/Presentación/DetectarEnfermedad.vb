Public Class DetectarEnfermedad
    Private Sub DetectarEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim emp As Empleado = New Empleado
        Dim c As Collection = emp.readAll()
        For Each emp In c
            cbEmpleados.Items.Add(emp.Nombre + " " + emp.Apellidos)
        Next
    End Sub

End Class