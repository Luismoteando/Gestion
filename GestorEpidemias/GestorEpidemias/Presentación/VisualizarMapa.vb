Imports GMap.NET.MapProviders
Imports GMap.NET

Public Class VisualizarMapa
    Private Sub VisualizarMapa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GMapControl1.DragButton = MouseButtons.Left
        GMapControl1.CanDragMap = True
        GMapControl1.MapProvider = GMapProviders.GoogleMap
        GMapControl1.SetPositionByKeywords("Spain")
        'GMapControl1.Position New PointLatLng()
        GMapControl1.MinZoom = 0
        GMapControl1.MaxZoom = 24
        GMapControl1.Zoom = 9
        GMapControl1.AutoScroll = True

    End Sub
End Class