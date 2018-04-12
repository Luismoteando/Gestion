Public Class VentanaInicial
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim a As Enfermedad = New Enfermedad()
        Dim c As Collection = a.readAll()
        For Each a In c
            MsgBox(a._nombre)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBox1.SelectedIndex = 0) Then
            DetectarEnfermedad.Show()
        ElseIf (ComboBox1.SelectedIndex = 1) Then
            VisualizarMapa.Show()
        ElseIf (ComboBox1.SelectedIndex = 2) Then
            VisualizarTabla.Show()
        ElseIf (ComboBox1.SelectedIndex = 3) Then
            LocalizarEnfermedad.Show()
        End If
    End Sub

End Class
