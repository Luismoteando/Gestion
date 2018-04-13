<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualizarTabla
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VisualizarTabla))
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sintomas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contagiosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prevencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nombre, Me.sintomas, Me.localizacion, Me.contagiosa, Me.prevencion, Me.cura})
        Me.grid.Location = New System.Drawing.Point(12, 12)
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(844, 327)
        Me.grid.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Width = 50
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre Enfermedad"
        Me.nombre.Name = "nombre"
        '
        'sintomas
        '
        Me.sintomas.HeaderText = "Sintomas"
        Me.sintomas.Name = "sintomas"
        Me.sintomas.Width = 150
        '
        'localizacion
        '
        Me.localizacion.HeaderText = "Localización de focos"
        Me.localizacion.Name = "localizacion"
        '
        'contagiosa
        '
        Me.contagiosa.HeaderText = "Contagiosa"
        Me.contagiosa.Name = "contagiosa"
        '
        'prevencion
        '
        Me.prevencion.HeaderText = "Prevención"
        Me.prevencion.Name = "prevencion"
        Me.prevencion.Width = 150
        '
        'cura
        '
        Me.cura.HeaderText = "Cura"
        Me.cura.Name = "cura"
        Me.cura.Width = 150
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(358, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VisualizarTabla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 400)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VisualizarTabla"
        Me.Text = "Visualizar Enfermedades en Tabla"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents sintomas As DataGridViewTextBoxColumn
    Friend WithEvents localizacion As DataGridViewTextBoxColumn
    Friend WithEvents contagiosa As DataGridViewTextBoxColumn
    Friend WithEvents prevencion As DataGridViewTextBoxColumn
    Friend WithEvents cura As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
