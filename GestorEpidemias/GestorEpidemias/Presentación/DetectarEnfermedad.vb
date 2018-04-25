Public Class DetectarEnfermedad

    Private empleados, enfermedades, paises As New Collection
    Private emp As New Empleado

    Private Sub DetectarEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        emp = New Empleado
        empleados = emp.readAll()

        For Each emp In empleados
            cbEmpleados.Items.Add(emp.Nombre + " " + emp.Apellidos)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btDetectar.Click
        Dim i As Integer
        Dim enf As Enfermedad = New Enfermedad()
        Dim p As Pais = New Pais()
        Dim nombres As Collection = getNombres(empleados)
        Dim sintomasEmpleado As New Collection

        For i = 0 To listSintomas.Items.Count - 1
            If listSintomas.GetItemChecked(i) Then
                sintomasEmpleado.Add(listSintomas.Items(i).ToString)
            End If
        Next

        enfermedades = enf.readAll()
        paises = p.readAll()

        For Each enf In enfermedades
            Dim j As Integer
            Dim sintomas As String() = enf._sintomas.Split(",")
            For j = 1 To sintomasEmpleado.Count
                If sintomas.Contains(sintomasEmpleado.Item(j)) Then

                    If nombres.Contains(cbEmpleados.SelectedItem) Then
                        MsgBox("OK")
                    End If

                End If
            Next
        Next
    End Sub

    Public Function getNombres(empleados As Collection) As Collection
        Dim i As Integer
        Dim nombres As New Collection
        Dim emp As New Empleado
        For i = 1 To empleados.Count
            emp = empleados.Item(i)
            nombres.Add(emp.Nombre + " " + emp.Apellidos)
        Next

        Return nombres
    End Function

End Class