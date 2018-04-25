Public Class LocalizarEnfermedad
    Private Sub LocalizarEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pais As Pais = New Pais
        Dim c As Collection = pais.readAll()
        For Each emp In c
            cbPais.Items.Add(emp.Nombre1)
        Next
    End Sub
End Class