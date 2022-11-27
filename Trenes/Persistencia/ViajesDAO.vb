Public Class ViajesDAO
    Public ReadOnly Property Viajes As Collection

    Public Sub New()
        Me.Viajes = New Collection
    End Sub

    Public Sub LeerTodosViajes(ruta As String) 'Lee los datos de la rutaBD'
        Dim v As Viajes
        Dim colec, vaux As Collection
        colec = AgenteBD.ObtenerAgente(ruta).Leer("SELECT * FROM Viajes ORDER BY FechaViaje, Tren, Producto")
        For Each vaux In colec
            v = New Viajes(vaux(1).ToString)
            v.Tren = vaux(2).ToString
            v.Producto = vaux(3).ToString
            v.ToneladasTransportadas = vaux(4).ToString
            Me.Viajes.Add(v)
        Next
    End Sub

    Public Sub LeerViaje(ByRef v As Viajes)  'Lee la fecha de un viaje cuando pinchamos en la lista'
        Dim colec As Collection : Dim vaux As Collection
        colec = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Viajes WHERE Tren='" & v.Tren & "';")
        For Each vaux In colec
            v = New Viajes(vaux(2).ToString)
            v.FechaViaje = vaux(1).ToString
            v.Producto = vaux(3).ToString
            v.ToneladasTransportadas = vaux(4).ToString
            Me.Viajes.Add(v)
        Next
    End Sub

    'Insertar viaje'
    Public Function InsertarViaje(ByVal v As Viajes) As String
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Viajes VALUES ('" & v.FechaViaje & "','" & v.Tren & "', " & v.Producto & ", " & v.ToneladasTransportadas & ");")
    End Function

    'Modificar viaje'
    Public Function ModificarViaje(ByVal v As Viajes) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Viajes SET ToneladasTransportadas=" & v.ToneladasTransportadas & " WHERE FechaViaje=#" & Format(v.FechaViaje, "yyyy/MM/dd") & "# AND Tren='" & v.Tren & "'AND Producto=" & v.Producto & ";")
    End Function

    'Eliminar Viaje'
    Public Function BorrarViaje(ByVal v As Viajes) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Viajes WHERE FechaViaje=#" & Format(v.FechaViaje, "yyyy/MM/dd") & "# AND Tren='" & v.Tren & "' AND Producto=" & v.Producto & ";")
    End Function

    'Seleccionar los viajes que hay solo entre dos fechas'
    Public Sub SeleccionarViajes(ruta As String, ByVal v As Viajes, ByVal vo As Viajes, ByVal vf As Viajes) 'Lee los datos de la rutaBD'
        Dim colec, vaux As Collection
        colec = AgenteBD.ObtenerAgente(ruta).Leer("SELECT * FROM Viajes WHERE Tren= '" & v.Tren & "' AND  FechaViaje BETWEEN #" & Format(vo.FechaViaje, "yyyy/MM/dd") & "# AND #" & Format(vf.FechaViaje, "yyyy/MM/dd") & "#;")
        For Each vaux In colec
            v = New Viajes(vaux(1).ToString)
            v.Tren = vaux(2).ToString
            v.Producto = vaux(3).ToString
            v.ToneladasTransportadas = vaux(4).ToString
            Me.Viajes.Add(v)
        Next
    End Sub

    'Seleccionar los trenes que se encuentran entre dos fechas'
    Public Sub RankingTrenes(ruta As String, ByVal v As Viajes, ByVal vo2 As Viajes, ByVal vf2 As Viajes)
        Dim colec, vaux As Collection
        colec = AgenteBD.ObtenerAgente(ruta).Leer("SELECT Tren, COUNT(*) FROM Viajes WHERE FechaViaje BETWEEN #" & Format(vo2.FechaViaje, "yyyy/MM/dd") & "# AND #" & Format(vf2.FechaViaje, "yyyy/MM/dd") & "# GROUP BY Tren ORDER BY COUNT(*) DESC;")
        For Each vaux In colec
            v = New Viajes(vaux(1).ToString)
            v.Producto = vaux(2)
            Me.Viajes.Add(v)
        Next
    End Sub

    'Seleccionar productos que se encuentran entre dos fechas'
    Public Sub RankingProductos(ruta As String, ByVal v As Viajes, ByVal vo3 As Viajes, ByVal vf3 As Viajes)
        Dim colec, vaux As Collection
        colec = AgenteBD.ObtenerAgente(ruta).Leer("SELECT Producto, COUNT(*) FROM Viajes WHERE FechaViaje BETWEEN #" & Format(vo3.FechaViaje, "yyyy/MM/dd") & "# AND #" & Format(vf3.FechaViaje, "yyyy/MM/dd") & "# GROUP BY Producto ORDER BY COUNT(*) DESC;")
        For Each vaux In colec
            v = New Viajes()
            v.Producto = vaux(1).ToString
            v.ToneladasTransportadas = vaux(2)
            Me.Viajes.Add(v)
        Next
    End Sub

    'Seleccionar el viajes que más beneficio ha tenido'
    Public Sub Beneficio(ruta As String)
        Dim colec, vaux As Collection
        colec = AgenteBD.ObtenerAgente(ruta).Leer("SELECT v.FechaViaje, v.Tren, tr.TipoTren, c.Producto, v.ToneladasTransportadas, c.EurosPorTonelada, v.ToneladasTransportadas * c.EurosPorTonelada As Beneficio FROM VIAJES v, Trenes tr, Cotizaciones c WHERE v.FechaViaje >= c.Fecha And v.Tren = tr.Matricula And v.Producto = c.Producto And v.ToneladasTransportadas * c.EurosPorTonelada = (Select MAX(v.ToneladasTransportadas * c.EurosPorTonelada) As Beneficio From VIAJES v, TRENES tr, COTIZACIONES c WHERE v.FechaViaje >= c.Fecha AND v.Tren = tr.Matricula AND v.Producto = c.producto);")
        Dim t As Tipos_Tren
        Dim tr As Trenes
        Dim c As Cotizaciones
        Dim v As Viajes
        For Each vaux In colec
            v = New Viajes(vaux(1).ToString)
            v.FechaViaje = (vaux(1).ToString)
            v.Tren = vaux(2).ToString
            v.Producto = vaux(4).ToString
            v.ToneladasTransportadas = vaux(5).ToString
            Me.Viajes.Add(v)

            tr = New Trenes(vaux(2).ToString)
            tr.Matricula = vaux(2).ToString
            tr.TipoTren = vaux(3).ToString
            Me.Viajes.Add(tr)

            c = New Cotizaciones(vaux(4).ToString)
            c.Producto = vaux(4).ToString
            c.Fecha = vaux(1).ToString
            c.EurosPorTonelada = vaux(6).ToString
            Me.Viajes.Add(c)
        Next


    End Sub

End Class

