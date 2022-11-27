Public Class TrenesDAO
    Public ReadOnly Property Trenesp As Collection
    Public Sub New()
        Me.Trenesp = New Collection
    End Sub

    Public Sub LeerTodas(ruta As String) 'Lee los datos de la rutaBD'
        Dim tr As Trenes
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente(ruta).Leer("SELECT * FROM Trenes ORDER BY Matricula")
        For Each aux In col
            tr = New Trenes(aux(1).ToString)
            tr.TipoTren = aux(2).ToString
            Me.Trenesp.Add(tr)
        Next
    End Sub

    Public Sub Leer(ByRef tr As Trenes) 'Lee un tren cuando pinchamos en la lista'
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Trenes WHERE Matricula='" & tr.Matricula & "';")
        For Each aux In col
            tr.TipoTren = aux(2).ToString

        Next
    End Sub

    'Insertar Tren'
    Public Function InsertarTren(ByVal tr As Trenes) As String
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Trenes VALUES ('" & tr.Matricula & "', " & tr.TipoTren & ");")
    End Function

    'Modificar tren'
    Public Function ModificarTren(ByVal tr As Trenes) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Trenes SET TipoTren=" & tr.TipoTren & " WHERE Matricula='" & tr.Matricula & "';")
    End Function

    'Eliminar tren'
    Public Function BorrarTren(ByVal tr As Trenes) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Trenes WHERE Matricula='" & tr.Matricula & "';")
    End Function
End Class
