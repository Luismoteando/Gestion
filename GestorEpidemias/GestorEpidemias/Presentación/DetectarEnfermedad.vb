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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btDetectar.Click
        Dim i As Integer
        Dim sintomasEmpleado As New Collection
        For i = 0 To listSintomas.Items.Count - 1
            If listSintomas.GetItemChecked(i) Then
                sintomasEmpleado.Add(listSintomas.Items(i).ToString)
            End If
        Next
        MsgBox(sintomasEmpleado.Item(1))
    End Sub

End Class