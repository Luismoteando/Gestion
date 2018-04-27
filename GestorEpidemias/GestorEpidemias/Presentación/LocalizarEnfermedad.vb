Public Class LocalizarEnfermedad
    Private Sub LocalizarEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pais As New Pais
        Dim paises As New Collection

        Try
            paises = pais.readAll()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        For Each i In paises
            cbPais.Items.Add(i.Nombre1)
        Next
    End Sub

    Private Sub cbPais_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbPais.SelectionChangeCommitted
        Dim pais As New Pais
        Dim enf As New Enfermedad
        Dim enfs As New Collection

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        pais.Nombre1 = cbPais.SelectedItem.ToString
        pais.readByName()

        Try
            enfs = enf.readAllByCountry(pais)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        For Each i In enfs
            ListBox1.Items.Add(i._nombre)
            ListBox2.Items.Add(i._prevencion)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class