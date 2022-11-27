<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConectar
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
        Me.btnSeleccionarBD = New System.Windows.Forms.Button()
        Me.btnAbrirBD = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBDSeleccionada = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrarInfo = New System.Windows.Forms.Button()
        Me.btnGesViajes = New System.Windows.Forms.Button()
        Me.btnGesDatos = New System.Windows.Forms.Button()
        Me.ofdRuta = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSeleccionarBD
        '
        Me.btnSeleccionarBD.Location = New System.Drawing.Point(21, 31)
        Me.btnSeleccionarBD.Name = "btnSeleccionarBD"
        Me.btnSeleccionarBD.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccionarBD.TabIndex = 1
        Me.btnSeleccionarBD.Text = "Ruta BD"
        Me.btnSeleccionarBD.UseVisualStyleBackColor = True
        '
        'btnAbrirBD
        '
        Me.btnAbrirBD.Enabled = False
        Me.btnAbrirBD.Location = New System.Drawing.Point(21, 91)
        Me.btnAbrirBD.Name = "btnAbrirBD"
        Me.btnAbrirBD.Size = New System.Drawing.Size(75, 23)
        Me.btnAbrirBD.TabIndex = 2
        Me.btnAbrirBD.Text = "Conectar"
        Me.btnAbrirBD.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'txtBDSeleccionada
        '
        Me.txtBDSeleccionada.Enabled = False
        Me.txtBDSeleccionada.Location = New System.Drawing.Point(112, 19)
        Me.txtBDSeleccionada.Multiline = True
        Me.txtBDSeleccionada.Name = "txtBDSeleccionada"
        Me.txtBDSeleccionada.Size = New System.Drawing.Size(300, 41)
        Me.txtBDSeleccionada.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSeleccionarBD)
        Me.GroupBox1.Controls.Add(Me.txtBDSeleccionada)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnAbrirBD)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 141)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conectar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnMostrarInfo)
        Me.GroupBox2.Controls.Add(Me.btnGesViajes)
        Me.GroupBox2.Controls.Add(Me.btnGesDatos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 175)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 184)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Elegir Opcion"
        '
        'btnMostrarInfo
        '
        Me.btnMostrarInfo.Enabled = False
        Me.btnMostrarInfo.Location = New System.Drawing.Point(58, 131)
        Me.btnMostrarInfo.Name = "btnMostrarInfo"
        Me.btnMostrarInfo.Size = New System.Drawing.Size(337, 30)
        Me.btnMostrarInfo.TabIndex = 2
        Me.btnMostrarInfo.Text = "Mostrar información de viajes y productos"
        Me.btnMostrarInfo.UseVisualStyleBackColor = True
        '
        'btnGesViajes
        '
        Me.btnGesViajes.Enabled = False
        Me.btnGesViajes.Location = New System.Drawing.Point(58, 83)
        Me.btnGesViajes.Name = "btnGesViajes"
        Me.btnGesViajes.Size = New System.Drawing.Size(337, 30)
        Me.btnGesViajes.TabIndex = 1
        Me.btnGesViajes.Text = "Gestionar viajes"
        Me.btnGesViajes.UseVisualStyleBackColor = True
        '
        'btnGesDatos
        '
        Me.btnGesDatos.Enabled = False
        Me.btnGesDatos.Location = New System.Drawing.Point(58, 36)
        Me.btnGesDatos.Name = "btnGesDatos"
        Me.btnGesDatos.Size = New System.Drawing.Size(337, 28)
        Me.btnGesDatos.TabIndex = 0
        Me.btnGesDatos.Text = "Añadir / Modificar / Eliminar registros"
        Me.btnGesDatos.UseVisualStyleBackColor = True
        '
        'FormConectar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 376)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormConectar"
        Me.Text = "Form Conectar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSeleccionarBD As Button
    Friend WithEvents btnAbrirBD As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBDSeleccionada As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGesViajes As Button
    Friend WithEvents btnGesDatos As Button
    Friend WithEvents ofdRuta As OpenFileDialog
    Friend WithEvents btnMostrarInfo As Button
End Class
