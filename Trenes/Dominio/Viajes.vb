Public Class Viajes
    Public Property FechaViaje As Date
    Public Property Tren As String
    Public Property Producto As Integer
    Public Property ToneladasTransportadas As Integer
    Public ReadOnly Property VDAO As ViajesDAO

    Public Sub New()
        Me.VDAO = New ViajesDAO
    End Sub

    Public Sub New(FechaViaje As Date)
        Me.VDAO = New ViajesDAO
        Me.FechaViaje = FechaViaje
    End Sub

    Public Sub New(Tren As String)
        Me.VDAO = New ViajesDAO
        Me.Tren = Tren
    End Sub

    Public Sub New(Producto As Integer)
        Me.VDAO = New ViajesDAO
        Me.Producto = Producto
    End Sub

    Public Sub New(ByVal FechaViaje As Date, Tren As String, Producto As Integer, ToneladasTransportadas As Integer)
        Me.VDAO = New ViajesDAO
        Me.FechaViaje = FechaViaje
        Me.Tren = Tren
        Me.Producto = Producto
        Me.ToneladasTransportadas = ToneladasTransportadas

    End Sub

    Public Sub LeerTodosViajes(ruta As String)
        Me.VDAO.LeerTodosViajes(ruta)
    End Sub

    Public Sub SeleccionarViajes(ruta As String, ByVal v As Viajes, ByVal vo As Viajes, ByVal vf As Viajes)
        Me.VDAO.SeleccionarViajes(ruta, v, vo, vf)
    End Sub

    Public Sub RankingTrenes(ruta As String, ByVal v As Viajes, ByVal vo2 As Viajes, ByVal vf2 As Viajes)
        Me.VDAO.RankingTrenes(ruta, v, vo2, vf2)
    End Sub

    Public Sub RankingProductos(ruta As String, ByVal v As Viajes, ByVal vo3 As Viajes, ByVal vf3 As Viajes)
        Me.VDAO.RankingProductos(ruta, v, vo3, vf3)
    End Sub

    Public Sub LeerViaje()
        Me.VDAO.LeerViaje(Me)
    End Sub

    Public Function InsertarViaje() As String
        Return Me.VDAO.InsertarViaje(Me)
    End Function

    Public Function ModificarViaje() As Integer
        Return Me.VDAO.ModificarViaje(Me)
    End Function

    Public Function BorrarViaje() As Integer
        Return Me.VDAO.BorrarViaje(Me)
    End Function
    Public Sub Beneficio(ruta As String)
        Me.VDAO.Beneficio(ruta)
    End Sub

End Class
