<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInformacion
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
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnMostrar1 = New System.Windows.Forms.Button()
        Me.lstProdTransp = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtViajesInf = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFechaFinInf = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFechaInicInf = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTrenInf = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lstViajesRealizados = New System.Windows.Forms.ListBox()
        Me.btnMostrar2 = New System.Windows.Forms.Button()
        Me.txtFechaFInf = New System.Windows.Forms.DateTimePicker()
        Me.txtFechaIInf = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lstProductosVend = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFechaF3 = New System.Windows.Forms.DateTimePicker()
        Me.txtFechaI3 = New System.Windows.Forms.DateTimePicker()
        Me.btnMostrar3 = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.txtCotiz4 = New System.Windows.Forms.TextBox()
        Me.txtTonTransp4 = New System.Windows.Forms.TextBox()
        Me.txtProdTrans4 = New System.Windows.Forms.TextBox()
        Me.btnMostrar4 = New System.Windows.Forms.Button()
        Me.txtBeneficioTotal = New System.Windows.Forms.TextBox()
        Me.txtTipoTrenInf = New System.Windows.Forms.TextBox()
        Me.txtTrenInf = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFecha4 = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(-2, -1)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(550, 365)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnMostrar1)
        Me.TabPage1.Controls.Add(Me.lstProdTransp)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtViajesInf)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtFechaFinInf)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtFechaInicInf)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.cmbTrenInf)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(542, 339)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Viaje/Productos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Enabled = False
        Me.btnMostrar1.Location = New System.Drawing.Point(88, 255)
        Me.btnMostrar1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(150, 19)
        Me.btnMostrar1.TabIndex = 10
        Me.btnMostrar1.Text = "Mostrar Listado"
        Me.btnMostrar1.UseVisualStyleBackColor = True
        '
        'lstProdTransp
        '
        Me.lstProdTransp.FormattingEnabled = True
        Me.lstProdTransp.Location = New System.Drawing.Point(403, 98)
        Me.lstProdTransp.Margin = New System.Windows.Forms.Padding(2)
        Me.lstProdTransp.Name = "lstProdTransp"
        Me.lstProdTransp.Size = New System.Drawing.Size(110, 173)
        Me.lstProdTransp.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(268, 102)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Productos Transportados:"
        '
        'txtViajesInf
        '
        Me.txtViajesInf.Location = New System.Drawing.Point(403, 34)
        Me.txtViajesInf.Margin = New System.Windows.Forms.Padding(2)
        Me.txtViajesInf.Name = "txtViajesInf"
        Me.txtViajesInf.ReadOnly = True
        Me.txtViajesInf.Size = New System.Drawing.Size(90, 20)
        Me.txtViajesInf.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(266, 37)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Numeros de viajes totales:"
        '
        'txtFechaFinInf
        '
        Me.txtFechaFinInf.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaFinInf.Location = New System.Drawing.Point(88, 159)
        Me.txtFechaFinInf.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFechaFinInf.Name = "txtFechaFinInf"
        Me.txtFechaFinInf.Size = New System.Drawing.Size(151, 20)
        Me.txtFechaFinInf.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 163)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Fin:"
        '
        'txtFechaInicInf
        '
        Me.txtFechaInicInf.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaInicInf.Location = New System.Drawing.Point(88, 98)
        Me.txtFechaInicInf.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFechaInicInf.Name = "txtFechaInicInf"
        Me.txtFechaInicInf.Size = New System.Drawing.Size(151, 20)
        Me.txtFechaInicInf.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Inicio:"
        '
        'cmbTrenInf
        '
        Me.cmbTrenInf.FormattingEnabled = True
        Me.cmbTrenInf.Location = New System.Drawing.Point(88, 34)
        Me.cmbTrenInf.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTrenInf.Name = "cmbTrenInf"
        Me.cmbTrenInf.Size = New System.Drawing.Size(151, 21)
        Me.cmbTrenInf.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tren Elegido:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.lstViajesRealizados)
        Me.TabPage2.Controls.Add(Me.btnMostrar2)
        Me.TabPage2.Controls.Add(Me.txtFechaFInf)
        Me.TabPage2.Controls.Add(Me.txtFechaIInf)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(542, 339)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Viajes Realizados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lstViajesRealizados
        '
        Me.lstViajesRealizados.FormattingEnabled = True
        Me.lstViajesRealizados.Location = New System.Drawing.Point(284, 50)
        Me.lstViajesRealizados.Margin = New System.Windows.Forms.Padding(2)
        Me.lstViajesRealizados.Name = "lstViajesRealizados"
        Me.lstViajesRealizados.Size = New System.Drawing.Size(122, 199)
        Me.lstViajesRealizados.TabIndex = 5
        '
        'btnMostrar2
        '
        Me.btnMostrar2.Location = New System.Drawing.Point(76, 169)
        Me.btnMostrar2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMostrar2.Name = "btnMostrar2"
        Me.btnMostrar2.Size = New System.Drawing.Size(150, 19)
        Me.btnMostrar2.TabIndex = 4
        Me.btnMostrar2.Text = "Mostrar Listado"
        Me.btnMostrar2.UseVisualStyleBackColor = True
        '
        'txtFechaFInf
        '
        Me.txtFechaFInf.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaFInf.Location = New System.Drawing.Point(150, 88)
        Me.txtFechaFInf.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFechaFInf.Name = "txtFechaFInf"
        Me.txtFechaFInf.Size = New System.Drawing.Size(95, 20)
        Me.txtFechaFInf.TabIndex = 3
        '
        'txtFechaIInf
        '
        Me.txtFechaIInf.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaIInf.Location = New System.Drawing.Point(150, 50)
        Me.txtFechaIInf.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFechaIInf.Name = "txtFechaIInf"
        Me.txtFechaIInf.Size = New System.Drawing.Size(95, 20)
        Me.txtFechaIInf.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 93)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Fecha Fin:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 54)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Fecha Inicio:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.lstProductosVend)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.txtFechaF3)
        Me.TabPage3.Controls.Add(Me.txtFechaI3)
        Me.TabPage3.Controls.Add(Me.btnMostrar3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Size = New System.Drawing.Size(542, 339)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Ventas Productos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lstProductosVend
        '
        Me.lstProductosVend.FormattingEnabled = True
        Me.lstProductosVend.Location = New System.Drawing.Point(306, 54)
        Me.lstProductosVend.Margin = New System.Windows.Forms.Padding(2)
        Me.lstProductosVend.Name = "lstProductosVend"
        Me.lstProductosVend.Size = New System.Drawing.Size(142, 199)
        Me.lstProductosVend.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(87, 97)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Fecha Fin:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(77, 58)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Fecha Inicio:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(77, 104)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 11
        '
        'txtFechaF3
        '
        Me.txtFechaF3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaF3.Location = New System.Drawing.Point(165, 93)
        Me.txtFechaF3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFechaF3.Name = "txtFechaF3"
        Me.txtFechaF3.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaF3.TabIndex = 9
        '
        'txtFechaI3
        '
        Me.txtFechaI3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaI3.Location = New System.Drawing.Point(165, 54)
        Me.txtFechaI3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFechaI3.Name = "txtFechaI3"
        Me.txtFechaI3.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaI3.TabIndex = 8
        '
        'btnMostrar3
        '
        Me.btnMostrar3.Location = New System.Drawing.Point(104, 171)
        Me.btnMostrar3.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMostrar3.Name = "btnMostrar3"
        Me.btnMostrar3.Size = New System.Drawing.Size(152, 19)
        Me.btnMostrar3.TabIndex = 7
        Me.btnMostrar3.Text = "Mostrar Listado"
        Me.btnMostrar3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txtCotiz4)
        Me.TabPage4.Controls.Add(Me.txtTonTransp4)
        Me.TabPage4.Controls.Add(Me.txtProdTrans4)
        Me.TabPage4.Controls.Add(Me.btnMostrar4)
        Me.TabPage4.Controls.Add(Me.txtBeneficioTotal)
        Me.TabPage4.Controls.Add(Me.txtTipoTrenInf)
        Me.TabPage4.Controls.Add(Me.txtTrenInf)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.txtFecha4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Size = New System.Drawing.Size(542, 339)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "MayorBeneficio"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'txtCotiz4
        '
        Me.txtCotiz4.Enabled = False
        Me.txtCotiz4.Location = New System.Drawing.Point(243, 214)
        Me.txtCotiz4.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCotiz4.Name = "txtCotiz4"
        Me.txtCotiz4.Size = New System.Drawing.Size(121, 20)
        Me.txtCotiz4.TabIndex = 19
        '
        'txtTonTransp4
        '
        Me.txtTonTransp4.Enabled = False
        Me.txtTonTransp4.Location = New System.Drawing.Point(243, 176)
        Me.txtTonTransp4.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTonTransp4.Name = "txtTonTransp4"
        Me.txtTonTransp4.Size = New System.Drawing.Size(121, 20)
        Me.txtTonTransp4.TabIndex = 18
        '
        'txtProdTrans4
        '
        Me.txtProdTrans4.Enabled = False
        Me.txtProdTrans4.Location = New System.Drawing.Point(243, 136)
        Me.txtProdTrans4.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProdTrans4.Name = "txtProdTrans4"
        Me.txtProdTrans4.Size = New System.Drawing.Size(121, 20)
        Me.txtProdTrans4.TabIndex = 17
        '
        'btnMostrar4
        '
        Me.btnMostrar4.Location = New System.Drawing.Point(243, 288)
        Me.btnMostrar4.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMostrar4.Name = "btnMostrar4"
        Me.btnMostrar4.Size = New System.Drawing.Size(121, 19)
        Me.btnMostrar4.TabIndex = 16
        Me.btnMostrar4.Text = "Mostrar información"
        Me.btnMostrar4.UseVisualStyleBackColor = True
        '
        'txtBeneficioTotal
        '
        Me.txtBeneficioTotal.Enabled = False
        Me.txtBeneficioTotal.Location = New System.Drawing.Point(243, 252)
        Me.txtBeneficioTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBeneficioTotal.Name = "txtBeneficioTotal"
        Me.txtBeneficioTotal.Size = New System.Drawing.Size(121, 20)
        Me.txtBeneficioTotal.TabIndex = 15
        '
        'txtTipoTrenInf
        '
        Me.txtTipoTrenInf.Enabled = False
        Me.txtTipoTrenInf.Location = New System.Drawing.Point(243, 96)
        Me.txtTipoTrenInf.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTipoTrenInf.Name = "txtTipoTrenInf"
        Me.txtTipoTrenInf.Size = New System.Drawing.Size(121, 20)
        Me.txtTipoTrenInf.TabIndex = 14
        '
        'txtTrenInf
        '
        Me.txtTrenInf.Enabled = False
        Me.txtTrenInf.Location = New System.Drawing.Point(243, 57)
        Me.txtTrenInf.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTrenInf.Name = "txtTrenInf"
        Me.txtTrenInf.Size = New System.Drawing.Size(121, 20)
        Me.txtTrenInf.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(133, 256)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Beneficio Total:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(92, 141)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(122, 13)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Producto Transportado: "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(82, 180)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Toneladas Transportadas:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(92, 218)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(121, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Cotizacion del producto:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(182, 61)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Tren:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(144, 100)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Tipo de Tren:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(176, 26)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Fecha:"
        '
        'txtFecha4
        '
        Me.txtFecha4.Enabled = False
        Me.txtFecha4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha4.Location = New System.Drawing.Point(243, 22)
        Me.txtFecha4.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFecha4.Name = "txtFecha4"
        Me.txtFecha4.Size = New System.Drawing.Size(121, 20)
        Me.txtFecha4.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(281, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Ranking de viajes:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(303, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(115, 13)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Ranking de productos:"
        '
        'FormInformacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 362)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "FormInformacion"
        Me.Text = "Form Información"
        Me.TabControl2.ResumeLayout(False)
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

    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTrenInf As ComboBox
    Friend WithEvents txtFechaInicInf As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFechaFinInf As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtViajesInf As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnMostrar1 As Button
    Friend WithEvents lstProdTransp As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFechaFInf As DateTimePicker
    Friend WithEvents txtFechaIInf As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lstViajesRealizados As ListBox
    Friend WithEvents btnMostrar2 As Button
    Friend WithEvents btnMostrar3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFechaF3 As DateTimePicker
    Friend WithEvents txtFechaI3 As DateTimePicker
    Friend WithEvents lstProductosVend As ListBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFecha4 As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents txtBeneficioTotal As TextBox
    Friend WithEvents txtTipoTrenInf As TextBox
    Friend WithEvents txtTrenInf As TextBox
    Friend WithEvents btnMostrar4 As Button

    Private Sub FormInformacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents txtCotiz4 As TextBox
    Friend WithEvents txtTonTransp4 As TextBox
    Friend WithEvents txtProdTrans4 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
End Class
