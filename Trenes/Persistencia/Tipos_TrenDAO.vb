Public Class Tipos_TrenDAO
    Public ReadOnly Property Trenes As Collection

    Public Sub New()
        Me.Trenes = New Collection
    End Sub

    Public Sub LeerTodas(ruta As String) 'Lee los datos de la rutaBD'
        Dim t As Tipos_Tren
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente(ruta).Leer("SELECT * FROM Tipos_Tren ORDER BY IdTipoTren")
        For Each aux In col
            t = New Tipos_Tren(aux(1).ToString)
            t.DescTipoTren = aux(2).ToString
            t.CapacidadMax = aux(3).ToString
            Me.Trenes.Add(t)
        Next
    End Sub

    Public Sub Leer(ByRef t As Tipos_Tren)
        Dim col As Collection : Dim aux As Collection 'Lee un tren cuando pinchamos en la lista'
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Tipos_Tren WHERE IdTipoTren=" & t.IdTipoTren & ";")
        For Each aux In col
            t.DescTipoTren = aux(2).ToString
            t.CapacidadMax = aux(3).ToString
        Next
    End Sub

    'Insertar Tipo_Tren'
    Public Function InsertarTipoTren(ByVal t As Tipos_Tren) As String
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Tipos_Tren VALUES (" & t.IdTipoTren & ", '" & t.DescTipoTren & "', " & t.CapacidadMax & ");")
    End Function

    'Modificar Tipo_Tren'
    Public Function ModificarTipoTren(ByVal t As Tipos_Tren) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Tipos_Tren SET DescTipoTren='" & t.DescTipoTren & "', CapacidadMax=" & t.CapacidadMax & "  WHERE IdTipoTren=" & t.IdTipoTren & ";")
    End Function

    'Eliminar Tipo_Tren'
    Public Function BorrarTipoTren(ByVal t As Tipos_Tren) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Tipos_Tren WHERE IdTipoTren=" & t.IdTipoTren & ";")
    End Function
End Class
