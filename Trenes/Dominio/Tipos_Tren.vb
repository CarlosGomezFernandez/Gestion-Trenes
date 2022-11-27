
Public Class Tipos_Tren
    Public Property IdTipoTren As Integer
    Public Property DescTipoTren As String
    Public Property CapacidadMax As String
    Public ReadOnly Property TiposDAO As Tipos_TrenDAO

    Public Sub New()
        Me.TiposDAO = New Tipos_TrenDAO
    End Sub

    Public Sub New(IdTipoTren As Integer)
        Me.TiposDAO = New Tipos_TrenDAO
        Me.IdTipoTren = IdTipoTren
        Me.DescTipoTren = DescTipoTren
        Me.CapacidadMax = CapacidadMax
    End Sub

    Sub New(ByVal IdTipoTren As String, ByVal DescTipoTren As String, ByVal CapacidadMax As String)
        Me.TiposDAO = New Tipos_TrenDAO
        Me.IdTipoTren = IdTipoTren
        Me.DescTipoTren = DescTipoTren
        Me.CapacidadMax = CapacidadMax
    End Sub

    Public Sub LeerTodosTiposTrenes(ruta As String)
        Me.TiposDAO.LeerTodas(ruta)
    End Sub

    Public Sub LeerTipo_Tren()
        Me.TiposDAO.Leer(Me)
    End Sub

    Public Function InsertarTipoTren() As String
        Return Me.TiposDAO.InsertarTipoTren(Me)
    End Function

    Public Function ModificarTipoTren() As Integer
        Return Me.TiposDAO.ModificarTipoTren(Me)
    End Function

    Public Function BorrarTipoTren() As Integer
        Return Me.TiposDAO.BorrarTipoTren(Me)
    End Function

End Class
