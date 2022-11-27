Public Class FormGestionDatos
    Dim paux As Tipos_Tren
    Dim t As Tipos_Tren
    Dim taux As Trenes
    Dim tr As Trenes
    Dim pr As Productos
    Dim prodAux As Productos
    Dim c As Cotizaciones
    Dim caux As Cotizaciones

    'INTERFAZ DE TRENES'
    'Cuando seleccionas un tren en la lista'
    Private Sub lstTrenes_SelectedIndexChnaged(sender As Object, e As EventArgs) Handles lstTrenes.Click
        btnAnadir1.Enabled = False
        btnEliminar1.Enabled = True
        btnModificar1.Enabled = True
        btnLimpiar1.Enabled = True
        Me.TxtMatricula.Enabled = False
        'Si lista no esta vacia, muestra atributos de trenes'
        If Not Me.lstTrenes.SelectedItem Is Nothing Then
            FormConectar.tr.TrDAO.Trenesp.Clear()
            FormConectar.tr.LeerTodosTrenes(FormConectar.ofdRuta.FileName)
            Me.tr = New Trenes(Me.lstTrenes.SelectedItem.ToString)
            Try
                Me.tr.LeerTrenes()
                Me.t = New Tipos_Tren(Me.tr.TipoTren)
                Me.t.LeerTipo_Tren()
                'Si no hay tren o si falla bbdd'
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.TxtMatricula.Text = Me.tr.Matricula.ToString
            Me.CmbDesc.Text = Me.t.DescTipoTren.ToString
        End If
    End Sub

    'Añadir un tren'
    Private Sub btnAnadir1_Click(sender As Object, e As EventArgs) Handles btnAnadir1.Click
        If Not Me.CmbDesc.SelectedItem Is Nothing Then
            Me.tr = New Trenes
            Me.tr.Matricula = TxtMatricula.Text
            Me.tr.TipoTren = FormConectar.t.TiposDAO.Trenes.Item(CmbDesc.SelectedIndex + 1).IdTipoTren
            If (String.IsNullOrEmpty(CmbDesc.Text)) Then
                MessageBox.Show("Selecciona un tipo de tren de la lista")
            Else
                Try
                    If tr.InsertarTren() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                MessageBox.Show(tr.Matricula & " Se ha añadido")
                lstTrenes.Items.Clear()
                Me.tr = New Trenes
                Me.tr.LeerTodosTrenes(FormConectar.ofdRuta.FileName)

                For Each taux In Me.tr.TrDAO.Trenesp
                    lstTrenes.Items.Add(taux.Matricula)
                Next
            End If
            FormConectar.tr.TrDAO.Trenesp.Clear()
            FormConectar.tr.LeerTodosTrenes(FormConectar.ofdRuta.FileName)
            btnLimpiar1.Enabled = True
        Else
            MessageBox.Show("Selecciona un tipo de tren de la lista")
        End If
    End Sub

    'Modificar la descripcion de un tren'
    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        If Not CmbDesc.SelectedItem Is Nothing Then
            tr.TipoTren = FormConectar.t.TiposDAO.Trenes.Item(CmbDesc.SelectedIndex + 1).IdTipoTren
            Try
                If tr.ModificarTren() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show(tr.Matricula & " Actualizado correctamente")
        Else
            MessageBox.Show("Selecciona un tipo de tren")
        End If
    End Sub

    'Eliminar un tren de la base de datos'
    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        If Not tr Is Nothing Then
            Dim c As Integer = MsgBox("¿Estás seguro de querer eliminar el tren con mátricula " & tr.Matricula & "?", vbOKCancel + vbInformation)
            Select Case c
                Case 1
                    Try
                        If tr.BorrarTren() <> 1 Then
                            MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End Try
                    Me.lstTrenes.Items.Remove(tr.Matricula)
                    FormConectar.tr.TrDAO.Trenesp.Clear()
                    FormConectar.tr.LeerTodosTrenes(FormConectar.ofdRuta.FileName)
                    Me.btnLimpiar1.PerformClick()
                Case 2
            End Select
        End If
    End Sub

    'Limpiar todos los campos de trenes'
    Private Sub btnLimpiar1_Click(sender As Object, e As EventArgs) Handles btnLimpiar1.Click
        Me.TxtMatricula.Text = String.Empty
        Me.CmbDesc.Text = String.Empty
        Me.btnEliminar1.Enabled = False
        Me.btnModificar1.Enabled = False
        Me.btnAnadir1.Enabled = True
        Me.TxtMatricula.Enabled = True
    End Sub


    'INTERFAZ DE TIPO_TRENES'
    'Cuando seleccionas un tipo de tren en la lista'
    Private Sub lstTipoTrenes_SelectedIndexChnaged(sender As Object, e As EventArgs) Handles lstTiposTrenes.Click
        btnAnadir2.Enabled = False
        btnEliminar2.Enabled = True
        btnModificar2.Enabled = True
        btnLimpiar2.Enabled = True
        Me.TxtID.Enabled = False
        'Si lista no esta vacia, muestra atributos de tipos de trenes'
        If Not Me.lstTiposTrenes.SelectedItem Is Nothing Then
            FormConectar.t.TiposDAO.Trenes.Clear()
            FormConectar.t.LeerTodosTiposTrenes(FormConectar.ofdRuta.FileName)
            Me.t = New Tipos_Tren((FormConectar.t.TiposDAO.Trenes.Item(lstTiposTrenes.SelectedIndex + 1).IdTipoTren).ToString)
            Try
                Me.t.LeerTipo_Tren()
                'Si no hay tren o si falla bbdd'
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.TxtID.Text = Me.t.IdTipoTren.ToString
            Me.TxtDescripcion.Text = Me.t.DescTipoTren.ToString
            Me.TxtCapacidadMax.Text = Me.t.CapacidadMax.ToString
        End If
    End Sub

    'Añadir un tipo de tren'
    Private Sub btnAnadir2_Click(sender As Object, e As EventArgs) Handles btnAnadir2.Click
        Me.t = New Tipos_Tren
        If Not t Is Nothing Then
            Me.t.IdTipoTren = FormConectar.t.TiposDAO.Trenes.Item(FormConectar.t.TiposDAO.Trenes.Count).IdTipoTren + 1
            Me.t.DescTipoTren = TxtDescripcion.Text
            Me.t.CapacidadMax = TxtCapacidadMax.Text
            Dim Valido As Boolean = True
            If (String.IsNullOrEmpty(TxtDescripcion.Text) Or String.IsNullOrEmpty(TxtCapacidadMax.Text)) Then
                MessageBox.Show("Rellena todas las casillas correctamente")
            Else
                'No se pueden introducir dos tipos de trenes iguales'
                For i As Integer = 0 To lstTiposTrenes.Items.Count - 1
                    If (lstTiposTrenes.Items(i).ToString.Equals(TxtDescripcion.Text.ToString)) Then
                        MessageBox.Show("Este tipo de tren ya existe")
                        Valido = False
                        Exit For
                    End If
                Next
                If (Not IsNumeric(t.CapacidadMax)) Then
                    MessageBox.Show("Añade una cantidad de capacidad máxima correcta")
                ElseIf (t.CapacidadMax <= 0) Then
                    MessageBox.Show("Añade una cantidad de capacidad máxima mayor que cero")
                ElseIf (Valido) Then
                    Try
                        If t.InsertarTipoTren() <> 1 Then
                            MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End Try
                    MessageBox.Show(t.DescTipoTren & " se ha añadido")
                        Me.t.LeerTipo_Tren()
                        Me.lstTiposTrenes.Items.Add(t.DescTipoTren)
                        Me.CmbDesc.Items.Add(t.DescTipoTren)
                        FormConectar.t.TiposDAO.Trenes.Clear()
                        FormConectar.t.LeerTodosTiposTrenes(FormConectar.ofdRuta.FileName)
                        btnLimpiar2.Enabled = True
                    End If
                End If
        End If
    End Sub

    'Modificar un tipo de tren'
    Private Sub btnModificar2_Click(sender As Object, e As EventArgs) Handles btnModificar2.Click
        If Not lstTiposTrenes.SelectedItem Is Nothing Then
            t.IdTipoTren = TxtID.Text
            t.DescTipoTren = TxtDescripcion.Text
            t.CapacidadMax = TxtCapacidadMax.Text
            Dim Valido As Boolean = True
            If (String.IsNullOrEmpty(TxtDescripcion.Text) Or String.IsNullOrEmpty(TxtCapacidadMax.Text)) Then
                MessageBox.Show("Rellena todas las casillas correctamente")
            Else
                'No se pueden introducir dos tipos de trenes iguales'
                For i As Integer = 0 To lstTiposTrenes.Items.Count - 1
                    If (lstTiposTrenes.Items(i).ToString.Equals(TxtDescripcion.Text.ToString)) Then
                        If (lstTiposTrenes.Items(lstTiposTrenes.SelectedIndex).ToString.Equals(TxtDescripcion.Text.ToString)) Then
                        Else
                            MessageBox.Show("Este tipo de tren ya existe")
                            Valido = False
                            Exit For
                        End If
                    End If
                Next
                If (Not IsNumeric(t.CapacidadMax)) Then
                    MessageBox.Show("Añade una cantidad de capacidad máxima correcta")
                ElseIf (t.CapacidadMax <= 0) Then
                    MessageBox.Show("Añade una cantidad de capacidad máxima mayor que cero")
                ElseIf (Valido) Then
                    Try
                        If t.ModificarTipoTren() <> 1 Then
                            MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End Try
                    MessageBox.Show(t.DescTipoTren & " Actualizado correctamente")
                    Me.t.LeerTipo_Tren()
                    lstTiposTrenes.Items.Clear()
                    CmbDesc.Items.Clear()
                    Me.t = New Tipos_Tren
                    Me.t.LeerTodosTiposTrenes(FormConectar.ofdRuta.FileName)
                    For Each paux In Me.t.TiposDAO.Trenes
                        lstTiposTrenes.Items.Add(paux.DescTipoTren)
                        CmbDesc.Items.Add(paux.DescTipoTren)
                    Next
                    FormConectar.t.TiposDAO.Trenes.Clear()
                    FormConectar.t.LeerTodosTiposTrenes(FormConectar.ofdRuta.FileName)
                    TxtID.Text = String.Empty
                    TxtDescripcion.Text = String.Empty
                    TxtCapacidadMax.Text = String.Empty
                    btnAnadir2.Enabled = True
                    btnModificar2.Enabled = False
                    btnEliminar2.Enabled = False
                End If
            End If
        End If
    End Sub

    'Eliminar un tipo de tren'
    Private Sub btnEliminar2_Click(sender As Object, e As EventArgs) Handles btnEliminar2.Click
        If Not t Is Nothing Then
            Dim c As Integer = MsgBox("¿Estás seguro de querer eliminar el " & t.DescTipoTren & "?", vbOKCancel + vbInformation)
            Select Case c
                Case 1
                    Try
                        If t.BorrarTipoTren() <> 1 Then
                            MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End Try
                    Me.lstTiposTrenes.Items.Remove(t.DescTipoTren)
                    Me.CmbDesc.Items.Remove(t.DescTipoTren)
                    FormConectar.t.TiposDAO.Trenes.Clear()
                    FormConectar.t.LeerTodosTiposTrenes(FormConectar.ofdRuta.FileName)
                    Me.btnLimpiar2.PerformClick()
                Case 2
            End Select
        End If


    End Sub

    'Limpiar todos los campos de tipo trenes'
    Private Sub btnLimpiar2_Click(sender As Object, e As EventArgs) Handles btnLimpiar2.Click
        Me.TxtID.Text = String.Empty
        Me.TxtDescripcion.Text = String.Empty
        Me.TxtCapacidadMax.Text = String.Empty
        Me.btnEliminar2.Enabled = False
        Me.btnModificar2.Enabled = False
        Me.btnAnadir2.Enabled = True
    End Sub


    'INTERFAZ PRODUCTOS'
    'Cuando seleccionas un producto en la lista'
    Private Sub lstProducto_SelectedIndexChnaged(sender As Object, e As EventArgs) Handles lstProducto.Click
        btnAnadir3.Enabled = False
        btnEliminar3.Enabled = True
        btnModificar3.Enabled = True
        btnLimpiar3.Enabled = True
        Me.TxtIdProd.Enabled = False
        'Si lista no esta vacia, muestra atributos de Producto'
        If Not Me.lstProducto.SelectedItem Is Nothing Then
            FormConectar.pr.PDAO.Producto.Clear()
            FormConectar.pr.LeerTodosProductos(FormConectar.ofdRuta.FileName)
            Me.pr = New Productos((FormConectar.pr.PDAO.Producto.Item(lstProducto.SelectedIndex + 1).IdProducto).ToString)
            Try
                Me.pr.LeerProducto()
                'Si no hay producto o si falla bbdd'
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.TxtIdProd.Text = Me.pr.IdProducto.ToString
            Me.TxtDesc.Text = Me.pr.DescripProducto.ToString
        End If
    End Sub

    'Añadir nuevo producto'
    Private Sub btnAnadir3_Click(sender As Object, e As EventArgs) Handles btnAnadir3.Click
        Me.pr = New Productos
        If Not pr Is Nothing Then
            Me.pr.IdProducto = FormConectar.pr.PDAO.Producto.Item(FormConectar.pr.PDAO.Producto.Count).IdProducto + 1
            Me.pr.DescripProducto = TxtDesc.Text
            If (String.IsNullOrEmpty(TxtDesc.Text)) Then
                MessageBox.Show("Rellena corectamente los datos")
            Else
                Try
                    If pr.InsertarProducto() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                MessageBox.Show(pr.DescripProducto & " Se ha añadido")
                Me.lstProducto.Items.Add(pr.DescripProducto)
                Me.lstCotizacion.Items.Add(pr.DescripProducto)
                FormConectar.pr.PDAO.Producto.Clear()
                FormConectar.pr.LeerTodosProductos(FormConectar.ofdRuta.FileName)
                btnLimpiar3.Enabled = True
            End If
        End If
    End Sub

    'Modificar la descripcion de un producto'
    Private Sub btnModificar3_Click(sender As Object, e As EventArgs) Handles btnModificar3.Click
        If Not pr Is Nothing Then
            pr.DescripProducto = TxtDesc.Text
            If (String.IsNullOrEmpty(TxtDesc.Text)) Then
                MessageBox.Show("Rellena correctamente los datos")
            Else
                Try
                    If pr.ModificarProducto() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                MessageBox.Show(pr.DescripProducto & " Actualizado correctamente")
                lstProducto.Items.Clear()
                Me.pr = New Productos
                Me.pr.LeerTodosProductos(FormConectar.ofdRuta.FileName)
                For Each prodAux In Me.pr.PDAO.Producto
                    lstProducto.Items.Add(prodAux.DescripProducto)
                Next
                FormConectar.pr.PDAO.Producto.Clear()
                FormConectar.pr.LeerTodosProductos(FormConectar.ofdRuta.FileName)
            End If
        End If
    End Sub

    'Eliminar un producto de la base de datos'
    Private Sub btnEliminar3_Click(sender As Object, e As EventArgs) Handles btnEliminar3.Click
        If Not pr Is Nothing Then
            Dim c As Integer = MsgBox("¿Estás seguro de querer eliminar este producto " & pr.DescripProducto & "?", vbOKCancel + vbInformation)
            Select Case c
                Case 1
                    Try
                        If pr.BorrarProducto() <> 1 Then
                            MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End Try
                    Me.lstProducto.Items.Remove(pr.DescripProducto)
                    Me.lstCotizacion.Items.Remove(pr.DescripProducto)
                    FormConectar.pr.PDAO.Producto.Clear()
                    FormConectar.pr.LeerTodosProductos(FormConectar.ofdRuta.FileName)
                    Me.btnLimpiar3.PerformClick()
                Case 2
            End Select
        End If

    End Sub

    'Limpiar todos los campos de producto'
    Private Sub btnLimpiar3_Click(sender As Object, e As EventArgs) Handles btnLimpiar3.Click
        Me.TxtIdProd.Text = String.Empty
        Me.TxtDesc.Text = String.Empty
        Me.btnEliminar3.Enabled = False
        Me.btnModificar3.Enabled = False
        Me.btnAnadir3.Enabled = True
        Me.TxtIdProd.Enabled = False
    End Sub


    'INTERFAZ COTIZACIONES'
    'Cuando seleccionas una cotizacion de un producto en la lista'
    Private Sub lstCotizacion_SelectedIndexChnaged(sender As Object, e As EventArgs) Handles lstCotizacion.Click
        btnAnadir4.Enabled = True
        btnEliminar4.Enabled = False
        btnModificar4.Enabled = False
        btnLimpiar4.Enabled = False
        TxtFecha.Enabled = True
        Me.TxtFecha.Text = String.Empty
        Me.TxtET.Text = String.Empty
        Me.TxtFecha.Enabled = True
        Me.TxtET.Enabled = True

        'Si lista no esta vacia, muestra atributos de cotizaciones'
        If Not Me.lstCotizacion.SelectedItem Is Nothing Then
            FormConectar.pr.PDAO.Producto.Clear()
            FormConectar.pr.LeerTodosProductos(FormConectar.ofdRuta.FileName)
            Me.c = New Cotizaciones((FormConectar.pr.PDAO.Producto.Item(lstCotizacion.SelectedIndex + 1).IdProducto).ToString)
            Try
                Me.c.LeerCotizacion()
                Me.pr = New Productos(Me.c.Producto)
                Me.pr.LeerProducto()
                lstFechas.Items.Clear()
                For Each caux In Me.c.CDAO.Producto
                    lstFechas.Items.Add(caux.Fecha)
                Next
                'Si no hay producto o si falla bbdd'
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        End If
    End Sub

    'Seleccionar una de las fechas que tiene una cotizacion'
    Private Sub lstFechas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFechas.SelectedIndexChanged
        btnAnadir4.Enabled = False
        btnEliminar4.Enabled = True
        btnModificar4.Enabled = True
        btnLimpiar4.Enabled = True
        TxtFecha.Enabled = False
        For Each caux In Me.c.CDAO.Producto
            If caux.Producto = FormConectar.pr.PDAO.Producto.Item(lstCotizacion.SelectedIndex + 1).IdProducto And caux.Fecha = lstFechas.SelectedItem Then
                Me.TxtET.Text = caux.EurosPorTonelada
                Me.TxtFecha.Text = lstFechas.SelectedItem
            End If
        Next
    End Sub

    'Añadir una nueva cotizacion a un producto'
    Private Sub btnAnadir4_Click(sender As Object, e As EventArgs) Handles btnAnadir4.Click
        If Not c Is Nothing Then
            Me.c = New Cotizaciones((FormConectar.pr.PDAO.Producto.Item(lstCotizacion.SelectedIndex + 1).IdProducto).ToString)
            c.Fecha = TxtFecha.Text
            Try
                c.EurosPorTonelada = Convert.ToDouble(Replace(TxtET.Text, ".", ","))
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            If (c.EurosPorTonelada <= 0 Or TxtET.Text = "") Then
                MessageBox.Show("Añade una cantidad de Euros correcta, mayor que cero")
            Else
                Try
                    If c.InsertarCotizacion1() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                MessageBox.Show("Una cotizacion de " & pr.DescripProducto & " se ha añadido")
                Me.c.LeerCotizacion()
                lstFechas.Items.Clear()
                For Each caux In Me.c.CDAO.Producto
                    lstFechas.Items.Add(caux.Fecha)
                Next
                FormConectar.c.CDAO.Producto.Clear()
                FormConectar.c.LeerTodosCotizacion(FormConectar.ofdRuta.FileName)
                btnLimpiar4.Enabled = True
            End If
        End If
    End Sub

    'Modificar la cotizacion de un producto'
    Private Sub btnModificar4_Click(sender As Object, e As EventArgs) Handles btnModificar4.Click
        If Not c Is Nothing Then
            c.Fecha = TxtFecha.Text
            Try
                c.EurosPorTonelada = Convert.ToDouble(Replace(TxtET.Text, ".", ","))
            Catch ex As FormatException
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            If (c.EurosPorTonelada <= 0 Or TxtET.Text = "") Then
                MessageBox.Show("Añade una cantidad de Euros correcta, mayor que cero")
            Else
                Try
                    If c.ModificarCotizaciones() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                MessageBox.Show(pr.DescripProducto & " Actualizado correctamente")
                lstFechas.Items.Clear()
                Me.c = New Cotizaciones(c.Producto)
                Me.c.LeerCotizacion()
                For Each caux In Me.c.CDAO.Producto
                    lstFechas.Items.Add(caux.Fecha)
                Next
                FormConectar.c.CDAO.Producto.Clear()
                FormConectar.c.LeerTodosCotizacion(FormConectar.ofdRuta.FileName)
            End If
        End If
    End Sub

    'Eliminar una cotizacion'
    Private Sub btnEliminar4_Click(sender As Object, e As EventArgs) Handles btnEliminar4.Click
        If Not c Is Nothing Then
            c.Fecha = TxtFecha.Text
            Dim r As Integer = MsgBox("¿Estás seguro de querer eliminar esta cotizacion?", vbOKCancel + vbInformation)
            Select Case r
                Case 1
                    Try
                        If c.BorrarCotizacion() <> 1 Then
                            MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End Try
                    Me.lstFechas.Items.Remove(c.Fecha)
                    FormConectar.c.CDAO.Producto.Clear()
                    FormConectar.c.LeerTodosCotizacion(FormConectar.ofdRuta.FileName)
                    Me.btnLimpiar4.PerformClick()
                Case 2
            End Select
        End If


    End Sub

    'Limpiar los datos de cotizaciones'
    Private Sub btnLimpiar4_Click(sender As Object, e As EventArgs) Handles btnLimpiar4.Click 'Limpiar Campos'
        Me.TxtFecha.Enabled = True
        Me.TxtFecha.Text = String.Empty
        Me.TxtET.Text = String.Empty
        Me.CmbDesc.Items().Clear()
        Me.btnEliminar4.Enabled = False
        Me.btnModificar4.Enabled = False
        Me.btnAnadir4.Enabled = True
    End Sub
End Class