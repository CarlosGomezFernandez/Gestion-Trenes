Public Class ProductosDAO
    Public ReadOnly Property Producto As Collection

    Public Sub New()
        Me.Producto = New Collection
    End Sub

    Public Sub LeerTodas(ruta As String) 'Lee los datos de la rutaBD'
        Dim p As Productos
        Dim col, aux As Collection
        'Lee todos los Productos de la tabla'
        col = AgenteBD.ObtenerAgente(ruta).Leer("SELECT * FROM Productos ORDER BY IdProducto")
        For Each aux In col
            p = New Productos(aux(1).ToString) 'Por cada fila de la base de datos crea un producto'
            p.DescripProducto = aux(2).ToString
            Me.Producto.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Productos)  'Lee un producto del que sabemos IdProducto, cuando pinchamos en la lista'
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Productos WHERE IdProducto=" & p.IdProducto & ";")
        For Each aux In col
            p.DescripProducto = aux(2).ToString
        Next
    End Sub

    'Añadir Producto'
    Public Function InsertarProducto(ByVal p As Productos) As String
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Productos VALUES (" & p.IdProducto & ", '" & p.DescripProducto & "');")
    End Function

    'Modificar Producto'
    Public Function ModificarProducto(ByVal p As Productos) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Productos SET DescripProducto='" & p.DescripProducto & "' WHERE IdProducto=" & p.IdProducto & ";")
    End Function

    'Eliminar Producto'
    Public Function BorrarProducto(ByVal p As Productos) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Productos WHERE IdProducto=" & p.IdProducto & ";")
    End Function

End Class