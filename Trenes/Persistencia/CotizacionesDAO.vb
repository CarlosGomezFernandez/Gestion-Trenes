Public Class CotizacionesDAO
    Public Property _Producto As Collection
    Public Sub New()
        Me._Producto = New Collection
    End Sub
    Public Property Producto As Collection
        Get
            Return _Producto
        End Get
        Set(value As Collection)
            Me._Producto = value
        End Set
    End Property
    Public Sub LeerTodas(ruta As String) 'Lee los datos de la rutaBD'
        Dim c As Cotizaciones
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente(ruta).Leer("SELECT * FROM Cotizaciones ORDER BY Producto, Fecha")
        For Each aux In col
            c = New Cotizaciones(aux(1).ToString) 'Por cada fila de la base de datos crea un tren'
            c.Fecha = aux(2).ToString
            c.EurosPorTonelada = aux(3).ToString
            Me.Producto.Add(c)
        Next
    End Sub

    'Lee la cotizacion de un producto cuando pinchamos en la lista'
    Public Sub Leer(ByRef c As Cotizaciones)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Cotizaciones WHERE Producto=" & c.Producto & ";")
        For Each aux In col
            c = New Cotizaciones(aux(1).ToString)
            c.Fecha = aux(2).ToString
            c.EurosPorTonelada = aux(3).ToString
            Me.Producto.Add(c)
        Next
    End Sub

    'Insertar Cotizacion'
    Public Function InsertarCotizacion1(ByVal c As Cotizaciones) As String
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Cotizaciones VALUES (" & c.Producto & ", '" & c.Fecha & "', '" & c.EurosPorTonelada & "');")
    End Function

    'Modificar Cotizacion'
    Public Function ModificarCotizaciones(ByVal c As Cotizaciones) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Cotizaciones SET EurosPorTonelada='" & c.EurosPorTonelada & "' WHERE Producto=" & c.Producto & " AND Fecha=#" & Format(c.Fecha, "yyyy/MM/dd") & "#;")
    End Function

    'Eliminar Cotizacion'
    Public Function BorrarCotizacion(ByVal c As Cotizaciones) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Cotizaciones WHERE Producto=" & c.Producto & " AND Fecha=#" & Format(c.Fecha, "yyyy/MM/dd") & "#;")
    End Function
End Class
