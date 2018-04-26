Imports GMap.NET.MapProviders
Imports GMap.NET
Imports MySql.Data.Types

Public Class VisualizarMapa
    Private Sub VisualizarMapa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim enf As New Enfermedad
        Dim enfs As New Collection

        Try
            enfs = enf.readAll()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        For Each i In enfs
            ComboBox1.Items.Add(i._nombre)
        Next

        GMapControl1.DragButton = MouseButtons.Left
        GMapControl1.CanDragMap = True
        GMapControl1.MapProvider = GMapProviders.GoogleMap
        GMapControl1.SetPositionByKeywords("Spain")
        GMapControl1.MinZoom = 0
        GMapControl1.MaxZoom = 24
        GMapControl1.Zoom = 9
        GMapControl1.AutoScroll = True
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Dim enf As New Enfermedad
        Dim latlon As New MySqlGeometry

        enf._nombre = ComboBox1.SelectedItem.ToString

        'Try
        enf.readByName(enf)
        latlon = enf.readLatLon(enf)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString())
        'End Try

        GMapControl1.Position = New PointLatLng(latlon.XCoordinate, latlon.YCoordinate)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class