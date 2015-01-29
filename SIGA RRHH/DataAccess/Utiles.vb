Imports System.Data.SqlClient
Imports cl.presidencia.Argo.Comun

Public Class Utiles

    Private _conn As SqlClient.SqlConnection

    Public Sub New()
        _conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        Try
            _conn.Open()
        Catch ex As Exception
            _conn = Nothing
        End Try
    End Sub

    Public Shared Function buscaID(ByVal nombreTabla As String, ByVal campo As String, ByVal campoCondicion As String, ByVal valorCondicion As String, ByVal campoRetorno As String) As Object
        Dim conn As New SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()
        Dim sqlCmd As New SqlCommand("SELECT " & campoRetorno & " FROM " & nombreTabla & " WHERE " & campoCondicion & "=" & valorCondicion, conn)
        sqlCmd.CommandTimeout = 30
        Dim datar As SqlDataReader = sqlCmd.ExecuteReader
        If datar.HasRows Then
            datar.Read()
            Return (datar(campoRetorno))
        Else
            Return (Nothing)
        End If
        conn.Close()
        conn = Nothing
    End Function

    'Miembros del Objeto
    Public Function buscaID_(ByVal nombreTabla As String, ByVal campo As String, ByVal campoCondicion As String, ByVal valorCondicion As String, ByVal campoRetorno As String) As Object
        Dim retorno As Object = Nothing
        Dim datar As SqlDataReader = Nothing
        If _conn.State = ConnectionState.Open Then
            _conn.Close()
        End If
        If _conn.State = ConnectionState.Closed Then
            _conn.Open()
        End If
        Try

            Dim sqlCmd As New SqlCommand("SELECT " & campoRetorno & " FROM " & nombreTabla & " WHERE " & campoCondicion & "=" & valorCondicion, _conn)
            sqlCmd.CommandTimeout = 30
            datar = sqlCmd.ExecuteReader
            If datar.HasRows Then
                datar.Read()
                retorno = datar(campoRetorno)

            End If
        Catch ex As Exception

        Finally
            datar.Close()
            datar = Nothing
        End Try
        Return (retorno)
    End Function

    Protected Overridable Overloads Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            _conn.Close()
            _conn = Nothing
        End If
    End Sub

End Class
