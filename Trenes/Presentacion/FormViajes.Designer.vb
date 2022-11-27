<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViajes
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
        Me.lstMatriculas = New System.Windows.Forms.ListBox()
        Me.btnAnadir5 = New System.Windows.Forms.Button()
        Me.btnModificar5 = New System.Windows.Forms.Button()
        Me.btnEliminar5 = New System.Windows.Forms.Button()
        Me.btnLimpiar5 = New System.Windows.Forms.Button()
        Me.FechaViaje = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbProductosViajes = New System.Windows.Forms.ComboBox()
        Me.CmbMatTrenes = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtToneladas = New System.Windows.Forms.TextBox()
        Me.lstFechasViaje = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CapTren = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstMatriculas
        '
        Me.lstMatriculas.FormattingEnabled = True
        Me.lstMatriculas.Location = New System.Drawing.Point(12, 38)
        Me.lstMatriculas.Name = "lstMatriculas"
        Me.lstMatriculas.Size = New System.Drawing.Size(92, 186)
        Me.lstMatriculas.TabIndex = 1
        '
        'btnAnadir5
        '
        Me.btnAnadir5.Enabled = False
        Me.btnAnadir5.Location = New System.Drawing.Point(250, 215)
        Me.btnAnadir5.Name = "btnAnadir5"
        Me.btnAnadir5.Size = New System.Drawing.Size(75, 23)
        Me.btnAnadir5.TabIndex = 2
        Me.btnAnadir5.Text = "Añadir"
        Me.btnAnadir5.UseVisualStyleBackColor = True
        '
        'btnModificar5
        '
        Me.btnModificar5.Enabled = False
        Me.btnModificar5.Location = New System.Drawing.Point(348, 216)
        Me.btnModificar5.Name = "btnModificar5"
        Me.btnModificar5.Size = New System.Drawing.Size(79, 23)
        Me.btnModificar5.TabIndex = 3
        Me.btnModificar5.Text = "Modificar"
        Me.btnModificar5.UseVisualStyleBackColor = True
        '
        'btnEliminar5
        '
        Me.btnEliminar5.Enabled = False
        Me.btnEliminar5.Location = New System.Drawing.Point(453, 216)
        Me.btnEliminar5.Name = "btnEliminar5"
        Me.btnEliminar5.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar5.TabIndex = 4
        Me.btnEliminar5.Text = "Eliminar"
        Me.btnEliminar5.UseVisualStyleBackColor = True
        '
        'btnLimpiar5
        '
        Me.btnLimpiar5.Enabled = False
        Me.btnLimpiar5.Location = New System.Drawing.Point(318, 268)
        Me.btnLimpiar5.Name = "btnLimpiar5"
        Me.btnLimpiar5.Size = New System.Drawing.Size(152, 23)
        Me.btnLimpiar5.TabIndex = 5
        Me.btnLimpiar5.Text = "Limpiar Campos"
        Me.btnLimpiar5.UseVisualStyleBackColor = True
        '
        'FechaViaje
        '
        Me.FechaViaje.Enabled = False
        Me.FechaViaje.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaViaje.Location = New System.Drawing.Point(381, 20)
        Me.FechaViaje.Name = "FechaViaje"
        Me.FechaViaje.Size = New System.Drawing.Size(105, 20)
        Me.FechaViaje.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(278, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha del viaje:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(282, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Matricula Tren:"
        '
        'CmbProductosViajes
        '
        Me.CmbProductosViajes.Enabled = False
        Me.CmbProductosViajes.FormattingEnabled = True
        Me.CmbProductosViajes.Location = New System.Drawing.Point(374, 104)
        Me.CmbProductosViajes.Name = "CmbProductosViajes"
        Me.CmbProductosViajes.Size = New System.Drawing.Size(126, 21)
        Me.CmbProductosViajes.TabIndex = 10
        '
        'CmbMatTrenes
        '
        Me.CmbMatTrenes.Enabled = False
        Me.CmbMatTrenes.FormattingEnabled = True
        Me.CmbMatTrenes.Location = New System.Drawing.Point(374, 63)
        Me.CmbMatTrenes.Name = "CmbMatTrenes"
        Me.CmbMatTrenes.Size = New System.Drawing.Size(126, 21)
        Me.CmbMatTrenes.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Productos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(229, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Toneladas Transportadas:"
        '
        'TxtToneladas
        '
        Me.TxtToneladas.Enabled = False
        Me.TxtToneladas.Location = New System.Drawing.Point(374, 163)
        Me.TxtToneladas.Name = "TxtToneladas"
        Me.TxtToneladas.Size = New System.Drawing.Size(96, 20)
        Me.TxtToneladas.TabIndex = 14
        '
        'lstFechasViaje
        '
        Me.lstFechasViaje.FormattingEnabled = True
        Me.lstFechasViaje.Location = New System.Drawing.Point(110, 38)
        Me.lstFechasViaje.Name = "lstFechasViaje"
        Me.lstFechasViaje.Size = New System.Drawing.Size(103, 186)
        Me.lstFechasViaje.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Matriculas:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(107, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Fechas de los viajes:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(490, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "<="
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(490, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Capacidad Tren:"
        '
        'CapTren
        '
        Me.CapTren.Enabled = False
        Me.CapTren.Location = New System.Drawing.Point(528, 163)
        Me.CapTren.Name = "CapTren"
        Me.CapTren.Size = New System.Drawing.Size(39, 20)
        Me.CapTren.TabIndex = 20
        '
        'FormViajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 329)
        Me.Controls.Add(Me.CapTren)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstFechasViaje)
        Me.Controls.Add(Me.TxtToneladas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbMatTrenes)
        Me.Controls.Add(Me.CmbProductosViajes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FechaViaje)
        Me.Controls.Add(Me.btnLimpiar5)
        Me.Controls.Add(Me.btnEliminar5)
        Me.Controls.Add(Me.btnModificar5)
        Me.Controls.Add(Me.btnAnadir5)
        Me.Controls.Add(Me.lstMatriculas)
        Me.Name = "FormViajes"
        Me.Text = "Form Viajes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstMatriculas As ListBox
    Friend WithEvents btnAnadir5 As Button
    Friend WithEvents btnModificar5 As Button
    Friend WithEvents btnEliminar5 As Button
    Friend WithEvents btnLimpiar5 As Button
    Friend WithEvents FechaViaje As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbProductosViajes As ComboBox
    Friend WithEvents CmbMatTrenes As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtToneladas As TextBox
    Friend WithEvents lstFechasViaje As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CapTren As TextBox
End Class
