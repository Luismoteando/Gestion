Public Class DetectarEnfermedad
    Private Sub DetectarEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim emp As Empleado = New Empleado
        Dim c As Collection = emp.readAll()

        For Each emp In c
            cbEmpleados.Items.Add(emp.Nombre + " " + emp.Apellidos)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class