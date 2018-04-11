Public Class VentanaInicial
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim a As Enfermedad = New Enfermedad()
        Dim c As Collection = a.readAll()
        For Each a In c
            MsgBox(a._nombre)
        Next
    End Sub
End Class
