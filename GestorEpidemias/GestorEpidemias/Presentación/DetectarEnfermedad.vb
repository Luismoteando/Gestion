Public Class DetectarEnfermedad

    Private empleados, enfermedades, paises As New Collection
    Private emp As New Empleado

    Private Sub DetectarEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        emp = New Empleado
        empleados = emp.readAll()

        For Each emp In empleados
            cbEmpleados.Items.Add(emp.Nombre)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub listSintomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listSintomas.SelectedIndexChanged
        Dim index As Integer = listSintomas.SelectedIndex
        Dim i As Integer

        For i = 0 To listSintomas.Items.Count - 1
            If i.Equals(index) Then
                listSintomas.SetItemChecked(i, True)
            Else
                listSintomas.SetItemChecked(i, False)
            End If
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btDetectar.Click
        Dim i As Integer
        Dim enf As Enfermedad = New Enfermedad()
        Dim p As Pais = New Pais()
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
                For i = 0 To sintomas.Length - 1
                    If sintomasEmpleado.Item(j).Equals(sintomas.GetValue(i)) Then
                        Dim emp As Empleado = New Empleado()
                        emp.Nombre = cbEmpleados.SelectedItem
                        emp.read()
                        Dim v As Viaje = New Viaje(emp)
                        v.read()

                        If v.Destino1.Codigo1.Equals(enf._localización) Then
                            RichTextBox1.Text = "De acuerdo a los síntomas introducidos, los viajes realizados por el empleado y la información de las distintas enfermedades registradas, el empleado puede sufrir: " + vbNewLine + vbNewLine + enf._nombre.ToUpper + vbNewLine + vbNewLine + "Una posible cura para esta enfermedad es: " + enf._cura
                        Else
                            RichTextBox1.Text = "Los síntomas del empleado no coinciden con ninguna enfermedad grave localizada en los países que ha visitado."
                        End If
                    End If
                Next
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