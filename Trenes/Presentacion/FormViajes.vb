Public Class FormViajes
    Dim v As Viajes
    Dim vaux As Viajes
    Dim tr As Trenes
    Dim pr As Productos
    Dim t As Tipos_Tren

    'Cuando seleccionas un tren en la lista'
    Private Sub lstMatriculas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMatriculas.SelectedIndexChanged
        btnAnadir5.Enabled = True
        btnEliminar5.Enabled = False
        btnModificar5.Enabled = False
        btnLimpiar5.Enabled = True
        FechaViaje.Enabled = True
        TxtToneladas.Enabled = True
        CmbProductosViajes.Enabled = True
        Me.CmbMatTrenes.Enabled = False
        Me.FechaViaje.Text = String.Empty
        Me.CmbProductosViajes.Text = String.Empty
        Me.TxtToneladas.Text = String.Empty

        'Si lista no esta vacia, muestra atributos de Viajes'
        If Not Me.lstMatriculas.SelectedItem Is Nothing Then
            FormConectar.v.LeerTodosViajes(FormConectar.ofdRuta.FileName)
            Me.v = New Viajes((FormConectar.tr.TrDAO.Trenesp.Item(lstMatriculas.SelectedIndex + 1).Matricula).ToString)
            Me.tr = New Trenes((FormConectar.tr.TrDAO.Trenesp.Item(lstMatriculas.SelectedIndex + 1).Matricula).ToString)
            Try
                Me.v.LeerViaje()
                lstFechasViaje.Items.Clear()
                lstFechasViaje.Items.Clear()
                Me.tr.LeerTrenes()
                Me.t = New Tipos_Tren(tr.TipoTren)
                Me.t.LeerTipo_Tren()
                For Each vaux In Me.v.VDAO.Viajes
                    lstFechasViaje.Items.Add(vaux.FechaViaje)
                Next
                'Si no hay viaje o si falla bbdd'
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.CapTren.Text = t.CapacidadMax
            Me.CmbMatTrenes.Text = lstMatriculas.SelectedItem
        End If
    End Sub

    'Seleccionar una de las fechas que tiene una matricula'
    Private Sub lstFechasViaje_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFechasViaje.SelectedIndexChanged
        btnAnadir5.Enabled = False
        btnEliminar5.Enabled = True
        btnModificar5.Enabled = True
        FechaViaje.Enabled = False
        CmbMatTrenes.Enabled = False
        CmbProductosViajes.Enabled = False

        For Each vaux In Me.v.VDAO.Viajes
            If vaux.Tren = FormConectar.tr.TrDAO.Trenesp.Item(lstMatriculas.SelectedIndex + 1).Matricula And vaux.FechaViaje = lstFechasViaje.SelectedItem Then
                Me.pr = New Productos(Me.vaux.Producto)
                pr.LeerProducto()
                Me.FechaViaje.Text = lstFechasViaje.SelectedItem
                Me.CmbMatTrenes.Text = lstMatriculas.SelectedItem
                Me.CmbProductosViajes.Text = pr.DescripProducto
                Me.TxtToneladas.Text = vaux.ToneladasTransportadas
            End If
        Next
    End Sub

    'Añadir una fecha de viaje a una Matricula de trenes'
    Private Sub btnAnadir5_Click(sender As Object, e As EventArgs) Handles btnAnadir5.Click
        If Not v Is Nothing Then
            Me.v = New Viajes((FormConectar.tr.TrDAO.Trenesp.Item(lstMatriculas.SelectedIndex + 1).Matricula).ToString)
            Me.v.LeerViaje()
            Dim Valido As Boolean = True
            For Each vaux In Me.v.VDAO.Viajes
                If (vaux.FechaViaje = FechaViaje.Text) Then
                    Valido = False
                    MessageBox.Show("El tren no está disponible en esa fecha, elige otra")
                End If
            Next
            Me.v = New Viajes((FormConectar.tr.TrDAO.Trenesp.Item(lstMatriculas.SelectedIndex + 1).Matricula).ToString)
            Me.tr = New Trenes((FormConectar.tr.TrDAO.Trenesp.Item(lstMatriculas.SelectedIndex + 1).Matricula).ToString)
            Me.tr.LeerTrenes()
            Me.t = New Tipos_Tren(tr.TipoTren)
            Me.t.LeerTipo_Tren()
            v.FechaViaje = FechaViaje.Text
            Try
                v.ToneladasTransportadas = Convert.ToInt16(TxtToneladas.Text)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            If (String.IsNullOrEmpty(CmbProductosViajes.SelectedItem)) Then
                MessageBox.Show("Seleccione un producto")
            ElseIf (v.ToneladasTransportadas <= 0 Or v.ToneladasTransportadas > t.CapacidadMax) Then
                MessageBox.Show("Aseguresé de que las toneladas transportadas no superen la capacidad máxima del tren o que el número introducido es mayor que cero")
            ElseIf (Valido) Then
                    v.Producto = FormConectar.pr.PDAO.Producto.Item(CmbProductosViajes.SelectedIndex + 1).IdProducto
                Try
                    If v.InsertarViaje() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                    End Try
                    MessageBox.Show("Un viaje se ha añadido")
                    Me.v.LeerViaje()
                    lstFechasViaje.Items.Clear()
                    For Each vaux In Me.v.VDAO.Viajes
                        lstFechasViaje.Items.Add(vaux.FechaViaje)
                    Next
                    FormConectar.v.VDAO.Viajes.Clear()
                    FormConectar.v.LeerTodosViajes(FormConectar.ofdRuta.FileName)
                End If
            End If
    End Sub

    'Modifica las toneladas que se van a transportar en el viaje'
    Private Sub btnModificar5_Click(sender As Object, e As EventArgs) Handles btnModificar5.Click
        If Not lstFechasViaje.SelectedItem Is Nothing Then
            Me.tr = New Trenes((FormConectar.tr.TrDAO.Trenesp.Item(lstMatriculas.SelectedIndex + 1).Matricula).ToString)
            Me.tr.LeerTrenes()
            Me.t = New Tipos_Tren(tr.TipoTren)
            Me.t.LeerTipo_Tren()
            v.FechaViaje = lstFechasViaje.SelectedItem
            v.Tren = FormConectar.tr.TrDAO.Trenesp.Item(CmbMatTrenes.SelectedIndex + 1).Matricula
            v.Producto = FormConectar.pr.PDAO.Producto.Item(CmbProductosViajes.SelectedIndex + 1).IdProducto
            Try
                v.ToneladasTransportadas = Convert.ToInt16(TxtToneladas.Text)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            If (v.ToneladasTransportadas <= 0 Or TxtToneladas.Text = "" Or v.ToneladasTransportadas > t.CapacidadMax) Then
                MessageBox.Show("Aseguresé de que las toneladas transportadas no superen la capacidad máxima del tren o que el número introducido es mayor que 0")
            Else
                Try
                    If v.ModificarViaje() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                MessageBox.Show(v.Tren & " Actualizado correctamente")
                lstFechasViaje.Items.Clear()
                Me.v = New Viajes(v.Tren)
                Me.v.LeerViaje()
                For Each vaux In Me.v.VDAO.Viajes
                    lstFechasViaje.Items.Add(vaux.FechaViaje)
                Next
                FormConectar.v.VDAO.Viajes.Clear()
                FormConectar.v.LeerTodosViajes(FormConectar.ofdRuta.FileName)
            End If
        End If
    End Sub

    'Elimina una fecha de viaje'
    Private Sub btnEliminar5_Click(sender As Object, e As EventArgs) Handles btnEliminar5.Click
        If Not lstFechasViaje.SelectedItem Is Nothing Then
            Dim c As Integer = MsgBox("¿Estás seguro de querer eliminar este viaje?", vbOKCancel + vbInformation)
            Select Case c
                Case 1
                    v.FechaViaje = lstFechasViaje.SelectedItem
                    v.Tren = FormConectar.tr.TrDAO.Trenesp.Item(CmbMatTrenes.SelectedIndex + 1).Matricula
                    v.Producto = FormConectar.pr.PDAO.Producto.Item(CmbProductosViajes.SelectedIndex + 1).IdProducto
                    Try
                        If v.BorrarViaje() <> 1 Then
                            MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End Try
                    Me.lstFechasViaje.Items.Remove(v.FechaViaje)
                    FormConectar.v.VDAO.Viajes.Clear()
                    FormConectar.v.LeerTodosViajes(FormConectar.ofdRuta.FileName)
                    Me.btnLimpiar5.PerformClick()
                Case 2
            End Select
        End If
    End Sub

    'Limpiar los datos señalados previamente'
    Private Sub btnLimpiar5_Click(sender As Object, e As EventArgs) Handles btnLimpiar5.Click
        Me.FechaViaje.Enabled = True
        Me.CmbProductosViajes.Enabled = True
        Me.CmbMatTrenes.Enabled = False
        Me.FechaViaje.Text = String.Empty
        Me.CmbProductosViajes.Text = String.Empty
        Me.TxtToneladas.Text = String.Empty
        Me.btnEliminar5.Enabled = False
        Me.btnModificar5.Enabled = False
        Me.btnAnadir5.Enabled = True
    End Sub

End Class