Public Class Productos
    Public Property IdProducto As Integer
    Public Property DescripProducto As String
    Public ReadOnly Property PDAO As ProductosDAO

    Public Sub New()
        Me.PDAO = New ProductosDAO
    End Sub

    Public Sub New(IdProducto As Integer)
        Me.PDAO = New ProductosDAO
        Me.IdProducto = IdProducto
    End Sub

    Public Sub LeerTodosProductos(ruta As String)
        Me.PDAO.LeerTodas(ruta)
    End Sub

    Public Sub LeerProducto()
        Me.PDAO.Leer(Me)
    End Sub

    Public Function InsertarProducto() As String
        Return Me.PDAO.InsertarProducto(Me)
    End Function

    Public Function ModificarProducto() As Integer
        Return Me.PDAO.ModificarProducto(Me)
    End Function

    Public Function BorrarProducto() As Integer
        Return Me.PDAO.BorrarProducto(Me)
    End Function

End Class
