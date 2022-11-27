Public Class AgenteBD
    Public Shared _instancia As AgenteBD
    Private Shared conexion As OleDb.OleDbConnection
    Private Const cadenaConexionBase As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
    Private Shared cadenaConexion As String

    Private Sub New() 'Crea conexion'
        AgenteBD.conexion = New OleDb.OleDbConnection(AgenteBD.cadenaConexion)
        AgenteBD.conexion.Open()
    End Sub

    Public Shared Function ObtenerAgente() As AgenteBD 'Obtener conexion'
        If AgenteBD._instancia Is Nothing Then
            AgenteBD._instancia = New AgenteBD
        End If
        Return AgenteBD._instancia
    End Function

    Public Shared Function ObtenerAgente(ruta As String) As AgenteBD 'Seleccionar ruta'
        AgenteBD.cadenaConexion = AgenteBD.cadenaConexionBase & ruta
        Return AgenteBD.ObtenerAgente
    End Function

    Public Function Leer(sql As String) As Collection 'Lee el fichero'
        Dim result As New Collection
        Dim fila As Collection
        Dim i As Integer
        Dim reader As OleDb.OleDbDataReader
        Dim com As New OleDb.OleDbCommand(sql, AgenteBD.conexion)
        Conectar()
        reader = com.ExecuteReader
        While reader.Read
            fila = New Collection
            For i = 0 To reader.FieldCount - 1
                fila.Add(reader(i).ToString)
            Next
            result.Add(fila)
        End While
        Desconectar()
        Return result
    End Function

    Public Function Modificar(sql As String) As Integer 'Modifica fichero -> actualizar'
        Dim com As New OleDb.OleDbCommand(sql, AgenteBD.conexion)
        Dim result As Integer
        Conectar()
        result = com.ExecuteNonQuery
        Desconectar()
        Return result
    End Function

    Private Sub Conectar()
        If AgenteBD.conexion.State = ConnectionState.Closed Then
            AgenteBD.conexion.Open()
        End If
    End Sub

    Public Sub Desconectar()
        If AgenteBD.conexion.State = ConnectionState.Open Then
            AgenteBD.conexion.Close()
        End If
    End Sub
End Class
