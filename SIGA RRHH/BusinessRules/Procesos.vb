Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Comun
Imports System.Data.SqlClient

Public Class Procesos
    Public Shared Function CierreMensual(ByVal idPeriodo As Integer) As Object
        Dim conn As SqlClient.SqlConnection
        conn = New SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)

        Dim cmd As SqlClient.SqlCommand = New SqlCommand("sp_cierreMensual", conn)
        Dim prm As SqlClient.SqlParameter

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 10000

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idPeriodo
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@DATABASE"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = cl.presidencia.Argo.Comun.ArgoConfiguracion.databaseName
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Function

    Public Shared Function CierreMensual1(ByVal idPeriodo As Integer) As Object
        Dim conn As New SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)
        Dim sqlCmd As SqlCommand = New SqlCommand("SalesByCategory", conn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "sp_cierreMensual"

        Dim sqlParam As SqlParameter = sqlCmd.Parameters.Add("@PERIODO_ID", SqlDbType.SmallInt)
        sqlParam.Value = idPeriodo

        Try
            conn.Open()
            sqlCmd.ExecuteScalar()
            Return True
        Catch ex As SqlException
            Debug.WriteLine(ex.ToString)
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Shared Function coneccionesActivasBaseDatos() As DataView
        Dim conn As SqlClient.SqlConnection
        conn = New SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)

        Dim cmd As SqlClient.SqlCommand = New SqlCommand("sp_conexionesActivas", conn)
        Dim prm As SqlClient.SqlParameter

        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@BASE_DE_DATOS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = cl.presidencia.Argo.Comun.ArgoConfiguracion.databaseName
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@NOMBRE_APLICACION"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = cl.presidencia.Argo.Comun.ArgoConfiguracion.applicationName
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        Try
            conn.Open()
            cmd.ExecuteNonQuery()

            Try
                Dim cmdSQL As String
                cmdSQL = "SELECT * FROM RH_REM_CONEXIONES_ACTIVAS"
                Dim ds As DataSet
                Dim daDetalleCargasFam As New SqlDataAdapter(cmdSQL, Comun.ArgoConfiguracion.ConnectionString)
                ds = New DataSet(cmdSQL)
                daDetalleCargasFam.Fill(ds, "RH_REM_CONEXIONES_ACTIVAS")
                Dim dv As DataView
                Dim dvm As New DataViewManager(ds)
                dv = dvm.CreateDataView(ds.Tables("RH_REM_CONEXIONES_ACTIVAS"))
                Return (dv)

            Catch ex As Exception
                Return Nothing
            End Try
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Function
    Public Shared Function CierreProcesoSuplementario(ByVal idperiodo As Integer) As Object
        Dim conn As SqlClient.SqlConnection
        conn = New SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)

        Dim cmd As SqlClient.SqlCommand = New SqlCommand("sp_cierreSuplementario", conn)
        Dim prm As SqlClient.SqlParameter

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 20

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idperiodo
        cmd.Parameters.Add(prm)


        cmd.Connection = conn
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function
    Public Shared Function reajusteRevisionMovimientos(ByVal organizacionID As Integer, ByVal periodoID As Integer, ByVal porcentaje As Decimal, ByVal idReajuste As Integer) As Object
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand = New SqlCommand("sp_reajusteRevisionMovimientos", conn)
        Dim prm As SqlClient.SqlParameter

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 20

        Dim reajusteID As Integer

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ORGANIZACION_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = organizacionID
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = periodoID
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PORCENTAJE"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Decimal
        prm.Precision = 18
        prm.Scale = 3
        prm.Value = porcentaje
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@IDENTIFICADOR_REAJUSTE"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idReajuste
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@REAJUSTE_ID_ENCAB"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.Int
        cmd.Parameters.Add(prm)

        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            reajusteID = cmd.Parameters("@REAJUSTE_ID_ENCAB").Value()
            Return reajusteID
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return Nothing
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function
    Public Shared Function reajusteRevisionEUS(ByVal periodoID As Integer, ByVal porcentaje As Decimal) As Object
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand = New SqlCommand("sp_reajusteRevisionEUS", conn)
        Dim prm As SqlClient.SqlParameter
        Dim eusId As Integer

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 20


        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = periodoID
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PORCENTAJE"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Decimal
        prm.Precision = 18
        prm.Scale = 3
        prm.Value = porcentaje
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EUS_ID"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.Int
        'prm.Value = periodoID
        cmd.Parameters.Add(prm)

        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            eusId = cmd.Parameters("@EUS_ID").Value()
            Return eusId
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return 0
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function
    Public Shared Function reajusteDefinitivo(ByVal porcentaje As Decimal, ByVal ano As String, ByVal mes As String) As Object
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand = New SqlCommand("sp_reajusteDefinitivo", conn)
        Dim prm As SqlClient.SqlParameter

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 20

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PORCENTAJE"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Decimal
        prm.Precision = 18
        prm.Scale = 3
        prm.Value = porcentaje
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ANO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = ano
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MES"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = mes
        cmd.Parameters.Add(prm)

        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function

    Public Shared Function reajusteEliminaRegistros(ByVal reajusteID As Integer) As Object
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand = New SqlCommand("sp_reajusteEliminaRegistros", conn)
        Dim prm As SqlClient.SqlParameter

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 20


        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@REAJUSTE_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = reajusteID
        cmd.Parameters.Add(prm)

        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function
    Public Shared Function reajusteRecuperarDetalle(ByVal organizacionID As Integer, ByVal periodoID As Integer) As DataView
        Try
            Dim ds As New DataSet
            Dim daReajuste As New SqlDataAdapter("SELECT * FROM " & Vistas.VW_REAJUSTES_DETALLADO & " WHERE ORGANIZACION_ID=" & organizacionID & " AND PERIODO_ID=" & periodoID, ArgoConfiguracion.ConnectionString)
            daReajuste.Fill(ds, Vistas.VW_REAJUSTES_DETALLADO)
            Dim dv As New DataView
            dv = New DataView(ds.Tables(0), "", "", DataViewRowState.OriginalRows)
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Shared Function reajusteRecuperarEmpleados(ByVal organizacionID As Integer, ByVal periodoID As Integer) As DataTable
        Try
            Dim ds As New DataSet
            Dim mySelectQuery As String = "SELECT DISTINCT EMPLEADO_ID FROM " & Vistas.VW_REAJUSTES_DETALLADO & " WHERE ORGANIZACION_ID=" & organizacionID & " AND PERIODO_ID=" & periodoID
            Dim da As New SqlDataAdapter(mySelectQuery, ArgoConfiguracion.ConnectionString)
            da.Fill(ds, "VW_REAJUSTES_DETALLADO")
            Return (ds.Tables("VW_REAJUSTES_DETALLADO"))
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

End Class
