
Public Class FormConectar
    Dim paux As Tipos_Tren
    Dim taux As Trenes
    Public t As Tipos_Tren
    Public tr As Trenes
    Public pr As Productos
    Dim prodAux As Productos
    Public c As Cotizaciones
    Dim caux As Cotizaciones
    Public v As Viajes
    Dim vaux As Viajes
    Dim _instancia As AgenteBD

    Private Sub btnSeleccionarBD_Click(sender As Object, e As EventArgs) Handles btnSeleccionarBD.Click 'Elegir rutaBD'
        Me.ofdRuta.InitialDirectory = Application.StartupPath
        If (Me.ofdRuta.ShowDialog() = DialogResult.OK) Then
            Me.txtBDSeleccionada.Text = Me.ofdRuta.FileName
            btnAbrirBD.Enabled = True
        End If
    End Sub

    Private Sub btnAbrirBD_Click(sender As Object, e As EventArgs) Handles btnAbrirBD.Click 'Conectar rutaBD'
        Me.t = New Tipos_Tren
        Me.tr = New Trenes
        Me.pr = New Productos
        Me.c = New Cotizaciones
        Me.v = New Viajes

        Try ' Mensaje de Seleccion de ruta incorrecta'
            Me.tr.LeerTodosTrenes(ofdRuta.FileName)
            Me.t.LeerTodosTiposTrenes(ofdRuta.FileName)
            Me.pr.LeerTodosProductos(ofdRuta.FileName)
            Me.c.LeerTodosCotizacion(ofdRuta.FileName)
            Me.v.LeerTodosViajes(ofdRuta.FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtBDSeleccionada.Clear()
            btnAbrirBD.Enabled = False
            AgenteBD._instancia = Nothing
            Exit Sub
        End Try
        Label2.ForeColor = Color.Green
        Label2.Visible = True
        Label2.Text = "OK"
        btnGesDatos.Enabled = True
        btnGesViajes.Enabled = True
        btnMostrarInfo.Enabled = True
        btnSeleccionarBD.Enabled = False
    End Sub


    Private Sub btnGesDatos_Click(sender As Object, e As EventArgs) Handles btnGesDatos.Click
        Dim frm As New FormGestionDatos()

        For Each taux In Me.tr.TrDAO.Trenesp 'Muesta lista trenes'
            frm.lstTrenes.Items.Add(taux.Matricula)
        Next
        For Each paux In Me.t.TiposDAO.Trenes 'Muesta lista tipo trenes'
            frm.lstTiposTrenes.Items.Add(paux.DescTipoTren)
            frm.CmbDesc.Items.Add(paux.DescTipoTren)
        Next
        For Each prodAux In Me.pr.PDAO.Producto 'Muesta lista productos'
            frm.lstProducto.Items.Add(prodAux.DescripProducto)
            frm.lstCotizacion.Items.Add(prodAux.DescripProducto)
        Next
        frm.Show()

    End Sub

    Private Sub btnGesViajes_Click(sender As Object, e As EventArgs) Handles btnGesViajes.Click
        Dim frm1 As New FormViajes()
        For Each taux In Me.tr.TrDAO.Trenesp 'Muesta lista trenes'

            frm1.lstMatriculas.Items.Add(taux.Matricula)
            frm1.CmbMatTrenes.Items.Add(taux.Matricula)
        Next
        For Each prodAux In Me.pr.PDAO.Producto 'Muesta lista productos'
            frm1.CmbProductosViajes.Items.Add(prodAux.DescripProducto)
        Next
        frm1.Show()
    End Sub

    Private Sub btnMostrarInfo_Click(sender As Object, e As EventArgs) Handles btnMostrarInfo.Click
        Dim frm2 As New FormInformacion()

        For Each taux In Me.tr.TrDAO.Trenesp 'Muesta lista trenes'
            frm2.cmbTrenInf.Items.Add(taux.Matricula)
        Next
        frm2.Show()

    End Sub

End Class
