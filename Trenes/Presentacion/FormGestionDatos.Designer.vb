<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGestionDatos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLimpiar1 = New System.Windows.Forms.Button()
        Me.CmbDesc = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstTrenes = New System.Windows.Forms.ListBox()
        Me.btnEliminar1 = New System.Windows.Forms.Button()
        Me.btnModificar1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAnadir1 = New System.Windows.Forms.Button()
        Me.TxtMatricula = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnLimpiar2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCapacidadMax = New System.Windows.Forms.TextBox()
        Me.lstTiposTrenes = New System.Windows.Forms.ListBox()
        Me.btnEliminar2 = New System.Windows.Forms.Button()
        Me.btnModificar2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAnadir2 = New System.Windows.Forms.Button()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnLimpiar3 = New System.Windows.Forms.Button()
        Me.lstProducto = New System.Windows.Forms.ListBox()
        Me.btnEliminar3 = New System.Windows.Forms.Button()
        Me.btnModificar3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAnadir3 = New System.Windows.Forms.Button()
        Me.TxtIdProd = New System.Windows.Forms.TextBox()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lstFechas = New System.Windows.Forms.ListBox()
        Me.btnLimpiar4 = New System.Windows.Forms.Button()
        Me.TxtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtET = New System.Windows.Forms.TextBox()
        Me.lstCotizacion = New System.Windows.Forms.ListBox()
        Me.btnEliminar4 = New System.Windows.Forms.Button()
        Me.btnModificar4 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnAnadir4 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(-1, -2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(533, 309)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btnLimpiar1)
        Me.TabPage1.Controls.Add(Me.CmbDesc)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.lstTrenes)
        Me.TabPage1.Controls.Add(Me.btnEliminar1)
        Me.TabPage1.Controls.Add(Me.btnModificar1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnAnadir1)
        Me.TabPage1.Controls.Add(Me.TxtMatricula)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(525, 283)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Trenes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Matrículas de los trenes:"
        '
        'btnLimpiar1
        '
        Me.btnLimpiar1.Enabled = False
        Me.btnLimpiar1.Location = New System.Drawing.Point(227, 213)
        Me.btnLimpiar1.Name = "btnLimpiar1"
        Me.btnLimpiar1.Size = New System.Drawing.Size(175, 23)
        Me.btnLimpiar1.TabIndex = 21
        Me.btnLimpiar1.Text = "Limpiar Campos"
        Me.btnLimpiar1.UseVisualStyleBackColor = True
        '
        'CmbDesc
        '
        Me.CmbDesc.FormattingEnabled = True
        Me.CmbDesc.Location = New System.Drawing.Point(333, 86)
        Me.CmbDesc.Name = "CmbDesc"
        Me.CmbDesc.Size = New System.Drawing.Size(136, 21)
        Me.CmbDesc.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(224, 89)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Descripcion Tren:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 18
        '
        'lstTrenes
        '
        Me.lstTrenes.FormattingEnabled = True
        Me.lstTrenes.Location = New System.Drawing.Point(9, 37)
        Me.lstTrenes.Name = "lstTrenes"
        Me.lstTrenes.Size = New System.Drawing.Size(151, 199)
        Me.lstTrenes.TabIndex = 9
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Enabled = False
        Me.btnEliminar1.Location = New System.Drawing.Point(378, 163)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar1.TabIndex = 15
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.UseVisualStyleBackColor = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Enabled = False
        Me.btnModificar1.Location = New System.Drawing.Point(278, 163)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar1.TabIndex = 16
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(262, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Matricula:"
        '
        'btnAnadir1
        '
        Me.btnAnadir1.Location = New System.Drawing.Point(180, 163)
        Me.btnAnadir1.Name = "btnAnadir1"
        Me.btnAnadir1.Size = New System.Drawing.Size(75, 23)
        Me.btnAnadir1.TabIndex = 14
        Me.btnAnadir1.Text = "Añadir"
        Me.btnAnadir1.UseVisualStyleBackColor = True
        '
        'TxtMatricula
        '
        Me.TxtMatricula.Location = New System.Drawing.Point(333, 29)
        Me.TxtMatricula.Name = "TxtMatricula"
        Me.TxtMatricula.Size = New System.Drawing.Size(136, 20)
        Me.TxtMatricula.TabIndex = 12
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.btnLimpiar2)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TxtCapacidadMax)
        Me.TabPage2.Controls.Add(Me.lstTiposTrenes)
        Me.TabPage2.Controls.Add(Me.btnEliminar2)
        Me.TabPage2.Controls.Add(Me.btnModificar2)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.btnAnadir2)
        Me.TabPage2.Controls.Add(Me.TxtID)
        Me.TabPage2.Controls.Add(Me.TxtDescripcion)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(525, 283)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tipo_Trenes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Lista de los tipos de trenes:"
        '
        'btnLimpiar2
        '
        Me.btnLimpiar2.Enabled = False
        Me.btnLimpiar2.Location = New System.Drawing.Point(263, 227)
        Me.btnLimpiar2.Name = "btnLimpiar2"
        Me.btnLimpiar2.Size = New System.Drawing.Size(149, 23)
        Me.btnLimpiar2.TabIndex = 31
        Me.btnLimpiar2.Text = "Limpiar Campos"
        Me.btnLimpiar2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Capacidad Máxima:"
        '
        'TxtCapacidadMax
        '
        Me.TxtCapacidadMax.Location = New System.Drawing.Point(356, 112)
        Me.TxtCapacidadMax.Name = "TxtCapacidadMax"
        Me.TxtCapacidadMax.Size = New System.Drawing.Size(136, 20)
        Me.TxtCapacidadMax.TabIndex = 30
        '
        'lstTiposTrenes
        '
        Me.lstTiposTrenes.FormattingEnabled = True
        Me.lstTiposTrenes.Location = New System.Drawing.Point(19, 43)
        Me.lstTiposTrenes.Name = "lstTiposTrenes"
        Me.lstTiposTrenes.Size = New System.Drawing.Size(151, 199)
        Me.lstTiposTrenes.TabIndex = 20
        '
        'btnEliminar2
        '
        Me.btnEliminar2.Enabled = False
        Me.btnEliminar2.Location = New System.Drawing.Point(401, 177)
        Me.btnEliminar2.Name = "btnEliminar2"
        Me.btnEliminar2.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar2.TabIndex = 26
        Me.btnEliminar2.Text = "Eliminar"
        Me.btnEliminar2.UseVisualStyleBackColor = True
        '
        'btnModificar2
        '
        Me.btnModificar2.Enabled = False
        Me.btnModificar2.Location = New System.Drawing.Point(301, 177)
        Me.btnModificar2.Name = "btnModificar2"
        Me.btnModificar2.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar2.TabIndex = 27
        Me.btnModificar2.Text = "Modificar"
        Me.btnModificar2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(317, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(272, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Descripción:"
        '
        'btnAnadir2
        '
        Me.btnAnadir2.Location = New System.Drawing.Point(203, 177)
        Me.btnAnadir2.Name = "btnAnadir2"
        Me.btnAnadir2.Size = New System.Drawing.Size(75, 23)
        Me.btnAnadir2.TabIndex = 25
        Me.btnAnadir2.Text = "Añadir"
        Me.btnAnadir2.UseVisualStyleBackColor = True
        '
        'TxtID
        '
        Me.TxtID.Enabled = False
        Me.TxtID.Location = New System.Drawing.Point(356, 43)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(136, 20)
        Me.TxtID.TabIndex = 23
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(356, 79)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(136, 20)
        Me.TxtDescripcion.TabIndex = 24
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.btnLimpiar3)
        Me.TabPage3.Controls.Add(Me.lstProducto)
        Me.TabPage3.Controls.Add(Me.btnEliminar3)
        Me.TabPage3.Controls.Add(Me.btnModificar3)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.btnAnadir3)
        Me.TabPage3.Controls.Add(Me.TxtIdProd)
        Me.TabPage3.Controls.Add(Me.TxtDesc)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(525, 283)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Productos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 13)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Lista de productos:"
        '
        'btnLimpiar3
        '
        Me.btnLimpiar3.Enabled = False
        Me.btnLimpiar3.Location = New System.Drawing.Point(263, 199)
        Me.btnLimpiar3.Name = "btnLimpiar3"
        Me.btnLimpiar3.Size = New System.Drawing.Size(157, 23)
        Me.btnLimpiar3.TabIndex = 39
        Me.btnLimpiar3.Text = "Limpiar Campos"
        Me.btnLimpiar3.UseVisualStyleBackColor = True
        '
        'lstProducto
        '
        Me.lstProducto.FormattingEnabled = True
        Me.lstProducto.Location = New System.Drawing.Point(9, 43)
        Me.lstProducto.Name = "lstProducto"
        Me.lstProducto.Size = New System.Drawing.Size(151, 199)
        Me.lstProducto.TabIndex = 31
        '
        'btnEliminar3
        '
        Me.btnEliminar3.Enabled = False
        Me.btnEliminar3.Location = New System.Drawing.Point(402, 149)
        Me.btnEliminar3.Name = "btnEliminar3"
        Me.btnEliminar3.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar3.TabIndex = 37
        Me.btnEliminar3.Text = "Eliminar"
        Me.btnEliminar3.UseVisualStyleBackColor = True
        '
        'btnModificar3
        '
        Me.btnModificar3.Enabled = False
        Me.btnModificar3.Location = New System.Drawing.Point(305, 149)
        Me.btnModificar3.Name = "btnModificar3"
        Me.btnModificar3.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar3.TabIndex = 38
        Me.btnModificar3.Text = "Modificar"
        Me.btnModificar3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(271, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "ID Producto:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(272, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Descripción:"
        '
        'btnAnadir3
        '
        Me.btnAnadir3.Location = New System.Drawing.Point(209, 149)
        Me.btnAnadir3.Name = "btnAnadir3"
        Me.btnAnadir3.Size = New System.Drawing.Size(75, 23)
        Me.btnAnadir3.TabIndex = 36
        Me.btnAnadir3.Text = "Añadir"
        Me.btnAnadir3.UseVisualStyleBackColor = True
        '
        'TxtIdProd
        '
        Me.TxtIdProd.Enabled = False
        Me.TxtIdProd.Location = New System.Drawing.Point(356, 43)
        Me.TxtIdProd.Name = "TxtIdProd"
        Me.TxtIdProd.Size = New System.Drawing.Size(136, 20)
        Me.TxtIdProd.TabIndex = 34
        '
        'TxtDesc
        '
        Me.TxtDesc.Location = New System.Drawing.Point(356, 82)
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(136, 20)
        Me.TxtDesc.TabIndex = 35
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.lstFechas)
        Me.TabPage4.Controls.Add(Me.btnLimpiar4)
        Me.TabPage4.Controls.Add(Me.TxtFecha)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.TxtET)
        Me.TabPage4.Controls.Add(Me.lstCotizacion)
        Me.TabPage4.Controls.Add(Me.btnEliminar4)
        Me.TabPage4.Controls.Add(Me.btnModificar4)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.btnAnadir4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(525, 283)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Cotizaciones"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(125, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(138, 13)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Fechas de las cotizaciones:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 13)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Productos cotizados:"
        '
        'lstFechas
        '
        Me.lstFechas.FormattingEnabled = True
        Me.lstFechas.Location = New System.Drawing.Point(128, 45)
        Me.lstFechas.Name = "lstFechas"
        Me.lstFechas.Size = New System.Drawing.Size(107, 160)
        Me.lstFechas.TabIndex = 45
        '
        'btnLimpiar4
        '
        Me.btnLimpiar4.Enabled = False
        Me.btnLimpiar4.Location = New System.Drawing.Point(301, 250)
        Me.btnLimpiar4.Name = "btnLimpiar4"
        Me.btnLimpiar4.Size = New System.Drawing.Size(153, 23)
        Me.btnLimpiar4.TabIndex = 44
        Me.btnLimpiar4.Text = "Limpiar Campos"
        Me.btnLimpiar4.UseVisualStyleBackColor = True
        '
        'TxtFecha
        '
        Me.TxtFecha.Enabled = False
        Me.TxtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtFecha.Location = New System.Drawing.Point(367, 59)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(136, 20)
        Me.TxtFecha.TabIndex = 42
        Me.TxtFecha.Value = New Date(2020, 4, 5, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(262, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Euros/Tonelada:"
        '
        'TxtET
        '
        Me.TxtET.Enabled = False
        Me.TxtET.Location = New System.Drawing.Point(367, 107)
        Me.TxtET.Name = "TxtET"
        Me.TxtET.Size = New System.Drawing.Size(136, 20)
        Me.TxtET.TabIndex = 41
        '
        'lstCotizacion
        '
        Me.lstCotizacion.FormattingEnabled = True
        Me.lstCotizacion.Location = New System.Drawing.Point(6, 45)
        Me.lstCotizacion.Name = "lstCotizacion"
        Me.lstCotizacion.Size = New System.Drawing.Size(108, 199)
        Me.lstCotizacion.TabIndex = 31
        '
        'btnEliminar4
        '
        Me.btnEliminar4.Enabled = False
        Me.btnEliminar4.Location = New System.Drawing.Point(439, 202)
        Me.btnEliminar4.Name = "btnEliminar4"
        Me.btnEliminar4.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar4.TabIndex = 37
        Me.btnEliminar4.Text = "Eliminar"
        Me.btnEliminar4.UseVisualStyleBackColor = True
        '
        'btnModificar4
        '
        Me.btnModificar4.Enabled = False
        Me.btnModificar4.Location = New System.Drawing.Point(339, 202)
        Me.btnModificar4.Name = "btnModificar4"
        Me.btnModificar4.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar4.TabIndex = 38
        Me.btnModificar4.Text = "Modificar"
        Me.btnModificar4.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(293, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(309, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Fecha:"
        '
        'btnAnadir4
        '
        Me.btnAnadir4.Enabled = False
        Me.btnAnadir4.Location = New System.Drawing.Point(241, 202)
        Me.btnAnadir4.Name = "btnAnadir4"
        Me.btnAnadir4.Size = New System.Drawing.Size(75, 23)
        Me.btnAnadir4.TabIndex = 36
        Me.btnAnadir4.Text = "Añadir"
        Me.btnAnadir4.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormGestionDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 305)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormGestionDatos"
        Me.Text = "Form Gestion Datos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lstTrenes As ListBox
    Friend WithEvents btnEliminar1 As Button
    Friend WithEvents btnModificar1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAnadir1 As Button
    Friend WithEvents TxtMatricula As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCapacidadMax As TextBox
    Friend WithEvents lstTiposTrenes As ListBox
    Friend WithEvents btnEliminar2 As Button
    Friend WithEvents btnModificar2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAnadir2 As Button
    Friend WithEvents TxtID As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents lstProducto As ListBox
    Friend WithEvents btnEliminar3 As Button
    Friend WithEvents btnModificar3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAnadir3 As Button
    Friend WithEvents TxtIdProd As TextBox
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtET As TextBox
    Friend WithEvents lstCotizacion As ListBox
    Friend WithEvents btnEliminar4 As Button
    Friend WithEvents btnModificar4 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnAnadir4 As Button
    Friend WithEvents TxtFecha As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents CmbDesc As ComboBox
    Friend WithEvents btnLimpiar1 As Button
    Friend WithEvents btnLimpiar2 As Button
    Friend WithEvents btnLimpiar3 As Button
    Friend WithEvents btnLimpiar4 As Button
    Friend WithEvents lstFechas As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
End Class
