Public Class VisualizarTabla
    Private Sub VisualizarTabla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As Enfermedad = New Enfermedad()
        Dim c As Collection = a.readAll()


        For Each a In c
            Dim contagiosa As String
            If a._contagiosa = 1 Then
                contagiosa = "Sí"
            Else
                contagiosa = "No"
            End If
            grid.Rows.Add(a._id, a._nombre, a._sintomas, a._localización, contagiosa, a._prevencion, a._cura)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class