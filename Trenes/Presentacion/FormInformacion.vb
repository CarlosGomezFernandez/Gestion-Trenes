
Imports System.Data.OleDb
Public Class FormInformacion
    Dim paux As Tipos_Tren
    Dim t As Tipos_Tren
    Dim taux As Trenes
    Dim tr As Trenes
    Dim pr As Productos
    Dim prodAux As Productos
    Dim c As Cotizaciones
    Dim caux As Cotizaciones
    Dim v As Viajes
    Dim vaux As Viajes

    Private Sub cmbTrenInf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTrenInf.SelectedIndexChanged
        btnMostrar1.Enabled = True
    End Sub

    'Mostrar el número de viajes y productos transportados entre dos fechas por un tren'
    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        If Not Me.cmbTrenInf.SelectedItem Is Nothing Then
            FormConectar.tr.TrDAO.Trenesp.Clear()
            FormConectar.tr.LeerTodosTrenes(FormConectar.ofdRuta.FileName)
            Me.v = New Viajes((FormConectar.tr.TrDAO.Trenesp.Item(cmbTrenInf.SelectedIndex + 1).Matricula).ToString)
            Dim vo As Viajes = New Viajes(txtFechaInicInf.Value.Date)
            Dim vf As Viajes = New Viajes(txtFechaFinInf.Value.Date)
            If (DateTime.Compare(vo.FechaViaje, vf.FechaViaje) > 0 Or String.IsNullOrEmpty(cmbTrenInf.Text)) Then 'La fecha actual es mayor que la fecha insertada.
                MessageBox.Show("La fecha inicial tiene que ser menor o igual a la final")
            Else
                v.SeleccionarViajes(FormConectar.ofdRuta.FileName, v, vo, vf)
                txtViajesInf.Text = v.VDAO.Viajes.Count.ToString
                lstProdTransp.Items.Clear()
                For Each vaux In Me.v.VDAO.Viajes
                    Me.pr = New Productos(vaux.Producto)
                    Me.pr.LeerProducto()
                    If (lstProdTransp.Items.Contains(pr.DescripProducto)) Then

                    Else
                        lstProdTransp.Items.Add(pr.DescripProducto)
                    End If
                Next
            End If
        Else
            MessageBox.Show("Seleccione una matrícula")
        End If
    End Sub

    'Ranking tipos de tren entre dos fechas'
    Private Sub btnMostrar2_Click(sender As Object, e As EventArgs) Handles btnMostrar2.Click
        FormConectar.v.VDAO.Viajes.Clear()
        FormConectar.v.LeerTodosViajes(FormConectar.ofdRuta.FileName)
        Me.v = New Viajes((FormConectar.v.VDAO.Viajes).ToString)
        Dim vo2 As Viajes = New Viajes(txtFechaIInf.Value.Date)
        Dim vf2 As Viajes = New Viajes(txtFechaFInf.Value.Date)
        If (DateTime.Compare(vo2.FechaViaje, vf2.FechaViaje) > 0) Then 'La fecha actual es mayor que la fecha insertada'
            MessageBox.Show("La fecha inicial tiene que ser menor o igual a la final")
        Else
            v.RankingTrenes(FormConectar.ofdRuta.FileName, v, vo2, vf2)
            lstViajesRealizados.Items.Clear()
            For Each vaux In Me.v.VDAO.Viajes
                Me.tr = New Trenes(vaux.Tren)
                Me.tr.LeerTrenes()
                Me.t = New Tipos_Tren(Me.tr.TipoTren)
                Me.t.LeerTipo_Tren()
                lstViajesRealizados.Items.Add(t.DescTipoTren & " (" & vaux.Producto & ")")
            Next
        End If
    End Sub

    'Ranking productos entre dos fechas'
    Private Sub btnMostrar3_Click(sender As Object, e As EventArgs) Handles btnMostrar3.Click
        FormConectar.v.VDAO.Viajes.Clear()
        FormConectar.v.LeerTodosViajes(FormConectar.ofdRuta.FileName)
        Me.v = New Viajes((FormConectar.v.VDAO.Viajes).ToString)
        Dim vo3 As Viajes = New Viajes(txtFechaI3.Value.Date)
        Dim vf3 As Viajes = New Viajes(txtFechaF3.Value.Date)
        If (DateTime.Compare(vo3.FechaViaje, vf3.FechaViaje) > 0) Then 'La fecha actual es mayor que la fecha insertada.
            MessageBox.Show("La fecha inicial tiene que ser menor o igual a la final")
        Else
            v.RankingProductos(FormConectar.ofdRuta.FileName, v, vo3, vf3)
            lstProductosVend.Items.Clear()
            For Each vaux In Me.v.VDAO.Viajes
                Me.pr = New Productos(vaux.Producto)
                Me.pr.LeerProducto()
                lstProductosVend.Items.Add(pr.DescripProducto & " (" & vaux.ToneladasTransportadas & ")")
            Next
        End If
    End Sub

    'Mostrar datos del viaje que ha tenido mayor beneficio'
    Private Sub btnMostrar4_Click(sender As Object, e As EventArgs) Handles btnMostrar4.Click
        FormConectar.v.VDAO.Viajes.Clear()
        FormConectar.v.LeerTodosViajes(FormConectar.ofdRuta.FileName)
        Me.v = New Viajes((FormConectar.v.VDAO.Viajes).ToString)

        v.Beneficio(FormConectar.ofdRuta.FileName)

        Me.t = New Tipos_Tren(Me.v.VDAO.Viajes.Item(2).TipoTren.ToString)
        Me.t.LeerTipo_Tren()
        Me.pr = New Productos(Me.v.VDAO.Viajes.Item(3).Producto.ToString)
        Me.pr.LeerProducto()

        txtFecha4.Text = Me.v.VDAO.Viajes.Item(1).FechaViaje.ToString
        txtTrenInf.Text = Me.v.VDAO.Viajes.Item(1).Tren.ToString
        txtTipoTrenInf.Text = Me.t.DescTipoTren.ToString
        txtProdTrans4.Text = Me.pr.DescripProducto.ToString
        txtTonTransp4.Text = Me.v.VDAO.Viajes.Item(1).ToneladasTransportadas.ToString
        txtCotiz4.Text = Me.v.VDAO.Viajes.Item(3).EurosPorTonelada.ToString
        txtBeneficioTotal.Text = (Me.v.VDAO.Viajes.Item(1).ToneladasTransportadas * Me.v.VDAO.Viajes.Item(3).EurosPorTonelada).ToString
    End Sub

End Class