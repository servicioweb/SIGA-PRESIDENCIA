Imports System.ComponentModel
Imports System.Data.SqlClient
Imports cl.presidencia.Argo.Comun

Public Class ParametrosMensuales
    Inherits DSParametroMensual

    Private daPeriodo As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_REM_PERIODO, ArgoConfiguracion.ConnectionString)
    Dim connection As SqlConnection
    Public Sub New()
        MyBase.New()
        connection = New SqlConnection
        connection.ConnectionString = ArgoConfiguracion.ConnectionString
    End Sub
    Protected Overrides Sub Finalize()
        daPeriodo = Nothing
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        connection = Nothing
        MyBase.Finalize()
    End Sub
    Public Function BuscaIDPeriodoActivo() As Integer
        'Busca ID periodo activo
        Dim mySelectQuery As String
        mySelectQuery = "SELECT PERIODO_ID FROM RH_REM_PERIODO WHERE ORGANIZACION_ID = " & ArgoConfiguracion.OrganizacionID & " AND ESTADO_PERIODO = 1"

        Dim myConnection As New SqlConnection(connection.ConnectionString)
        Dim myCommand As New SqlCommand(mySelectQuery, myConnection)
        Dim valorID As Integer
        Try
            myConnection.Open()
            Dim myReader As SqlDataReader
            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                'Lee identificador de periodo (PERIODO_ID)
                'valorID = myReader.GetInt16(0)
                valorID = myReader.GetValue(0)
            End While
            myReader.Close()
            myConnection.Close()
            Return valorID
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function BuscaAnoMesPeriodoActivo() As String
        Dim mySelectQuery As String
        mySelectQuery = "SELECT (ANO +'-'+ MES) AS PERIODO   FROM RH_REM_PERIODO WHERE ORGANIZACION_ID = " & ArgoConfiguracion.OrganizacionID & " AND ESTADO_PERIODO = 1"

        Dim myConnection As New SqlConnection(connection.ConnectionString)
        Dim myCommand As New SqlCommand(mySelectQuery, myConnection)
        Dim valor As String = ""
        Try
            myConnection.Open()
            Dim myReader As SqlDataReader
            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                'Lee identificador de periodo (PERIODO_ID)
                valor = myReader.GetString(0)
            End While
            myReader.Close()
            myConnection.Close()
            Return valor
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function BuscaIDOtrosPeriodos(ByVal anoProceso As Integer, ByVal mesProceso As Integer) As Integer
        Dim mySelectQuery As String
        mySelectQuery = "SELECT PERIODO_ID FROM RH_REM_PERIODO" & _
                        " WHERE ORGANIZACION_ID = " & ArgoConfiguracion.OrganizacionID & _
                        " AND ANO=" & anoProceso & _
                        " AND MES=" & mesProceso

        Dim myConnection As New SqlConnection(connection.ConnectionString)
        Dim myCommand As New SqlCommand(mySelectQuery, myConnection)
        Dim valorID As Integer
        Try
            myConnection.Open()
            Dim myReader As SqlDataReader
            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                'Lee identificador de periodo (PERIODO_ID)
                valorID = myReader.GetInt32(0)
            End While
            myReader.Close()
            myConnection.Close()
            Return valorID
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Busca(ByVal ID As Long, ByVal NOMBRE_TABLA As String) As DataRow
        daPeriodo.Fill(Me, NOMBRE_TABLA)
        Try
            Return Me.Tables(NOMBRE_TABLA).Rows.Find(ID)
        Catch excepcion As Exception
            Return Nothing
        End Try
    End Function


    'agregado segegob
    Public Function AplicaAsignacionZona() As Boolean
        Dim mySelectQuery As String
        mySelectQuery = "SELECT APLICA_ASIGNACION_ZONA FROM RH_GEN_CONFIGURACION" & _
                        " WHERE ORGANIZACION_ID = " & ArgoConfiguracion.OrganizacionID

        Dim myConnection As New SqlConnection(connection.ConnectionString)
        Dim myCommand As New SqlCommand(mySelectQuery, myConnection)
        Dim resultado As Boolean
        Try
            myConnection.Open()
            Dim myReader As SqlDataReader
            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                resultado = myReader.GetBoolean(0)
            End While
            myReader.Close()
            myConnection.Close()
            Return resultado
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
