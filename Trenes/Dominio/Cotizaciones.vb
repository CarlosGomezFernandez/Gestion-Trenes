
Public Class Cotizaciones
    Public Property Producto As Integer
    Public Property Fecha As Date
    Public Property EurosPorTonelada As Double
    Public ReadOnly Property CDAO As CotizacionesDAO

    Public Sub New()
        Me.CDAO = New CotizacionesDAO
    End Sub

    Sub New(Producto As Integer)
        Me.CDAO = New CotizacionesDAO
        Me.Producto = Producto
        Me.Fecha = Fecha
        Me.EurosPorTonelada = EurosPorTonelada
    End Sub

    Public Sub New(ByVal Producto As Integer, EurosPorTonelada As Double, Fecha As Date)
        Me.CDAO = New CotizacionesDAO
        Me.Producto = Producto
        Me.EurosPorTonelada = EurosPorTonelada
        Me.Fecha = Fecha
    End Sub

    Public Sub LeerTodosCotizacion(ruta As String)
        Me.CDAO.LeerTodas(ruta)
    End Sub

    Public Sub LeerCotizacion()
        Me.CDAO.Leer(Me)
    End Sub

    Public Function InsertarCotizacion1() As String
        Return Me.CDAO.InsertarCotizacion1(Me)
    End Function

    Public Function ModificarCotizaciones() As Integer
        Return Me.CDAO.ModificarCotizaciones(Me)
    End Function

    Public Function BorrarCotizacion() As Integer
        Return Me.CDAO.BorrarCotizacion(Me)
    End Function
End Class