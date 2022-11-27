Public Class Trenes
    Public Property Matricula As String
    Public Property TipoTren As Integer
    Public ReadOnly Property TrDAO As TrenesDAO

    Public Sub New()
        Me.TrDAO = New TrenesDAO
    End Sub

    Public Sub New(Matricula As String)
        Me.TrDAO = New TrenesDAO
        Me.Matricula = Matricula
        Me.TipoTren = TipoTren
    End Sub


    Public Sub LeerTodosTrenes(ruta As String)
        Me.TrDAO.LeerTodas(ruta)
    End Sub

    Public Sub LeerTrenes()
        Me.TrDAO.Leer(Me)
    End Sub

    Public Function InsertarTren() As String
        Return Me.TrDAO.InsertarTren(Me)
    End Function

    Public Function ModificarTren() As Integer
        Return Me.TrDAO.ModificarTren(Me)
    End Function

    Public Function BorrarTren() As Integer
        Return Me.TrDAO.BorrarTren(Me)
    End Function
End Class
