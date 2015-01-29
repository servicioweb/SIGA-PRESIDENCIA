Imports System.ComponentModel
Imports System.Data.SqlClient
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.Comun.TiposDeDatos

Public Class Asistencias
    Inherits DSControlAsistencia
    Private conn As SqlConnection

    Public Sub New()
        MyBase.New()
        If conn Is Nothing Then
            conn = New SqlConnection
        End If
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
    End Sub

    Protected Overrides Sub Finalize()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn = Nothing
        MyBase.Finalize()
    End Sub
    Public Function recuperarAsistenciaDepartamento(ByVal fechaAsistencia As DateTime, ByVal deptoID As Integer) As DataView
        Try

            Dim ds As DataSet
            Dim da As New SqlDataAdapter("SELECT * FROM " & Vistas.VW_CONTROL_ASISTENCIA & " WHERE FECHA_ASISTENCIA=CONVERT(DATETIME,'" & fechaAsistencia & "',103) AND DEPTO_ID=" & deptoID, ArgoConfiguracion.ConnectionString)
            ds = New DataSet("SELECT * FROM " & Vistas.VW_CONTROL_ASISTENCIA & " WHERE FECHA_ASISTENCIA=" & fechaAsistencia & " AND DEPTO_ID=" & deptoID)
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(ds, Vistas.VW_CONTROL_ASISTENCIA)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_CONTROL_ASISTENCIA))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperarAsistenciaEmpleado(ByVal fechaAsistenciaInicial As DateTime, ByVal fechaAsistenciaFinal As DateTime, ByVal empleadoID As Integer) As DataView
        Try

            Dim ds As DataSet
            Dim da As New SqlDataAdapter("SELECT * FROM " & Vistas.VW_CONTROL_ASISTENCIA & " WHERE (FECHA_ASISTENCIA>=CONVERT(DATETIME,'" & fechaAsistenciaInicial & "',103) AND FECHA_ASISTENCIA<=CONVERT(DATETIME,'" & fechaAsistenciaFinal & "',103)) AND EMPLEADO_ID= " & empleadoID & " ORDER BY FECHA_ASISTENCIA", ArgoConfiguracion.ConnectionString)
            ds = New DataSet("SELECT * FROM " & Vistas.VW_CONTROL_ASISTENCIA & " WHERE (FECHA_ASISTENCIA>=CONVERT(DATETIME,'" & fechaAsistenciaInicial & "',103) AND FECHA_ASISTENCIA<=CONVERT(DATETIME,'" & fechaAsistenciaFinal & "',103)) AND EMPLEADO_ID=" & empleadoID & " ORDER BY FECHA_ASISTENCIA")
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(ds, Vistas.VW_CONTROL_ASISTENCIA)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_CONTROL_ASISTENCIA))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperarRatificacionHorasExtras(ByVal ano As Integer) As DataView
        Try
            Dim ds As DataSet
            Dim da As New SqlDataAdapter("SELECT * FROM " & Vistas.VW_CONTROL_ASISTENCIA_INFORME_DINAMICO & " WHERE YEAR(FECHA_ASISTENCIA)=" & CType(ano, String), ArgoConfiguracion.ConnectionString)
            ds = New DataSet("SELECT * FROM " & Vistas.VW_CONTROL_ASISTENCIA_INFORME_DINAMICO & " WHERE YEAR(FECHA_ASISTENCIA)=" & CType(ano, String))
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(ds, Vistas.VW_CONTROL_ASISTENCIA_INFORME_DINAMICO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_CONTROL_ASISTENCIA_INFORME_DINAMICO))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperarHorasAtraso(ByVal ano As Integer) As DataView
        Try
            Dim ds As DataSet
            Dim da As New SqlDataAdapter("SELECT * FROM " & Vistas.VW_CONTROL_ASISTENCIA_ATRASOS & " WHERE YEAR(FECHA_ASISTENCIA)=" & CType(ano, String), ArgoConfiguracion.ConnectionString)
            ds = New DataSet("SELECT * FROM " & Vistas.VW_CONTROL_ASISTENCIA_ATRASOS & " WHERE YEAR(FECHA_ASISTENCIA)=" & CType(ano, String))
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(ds, Vistas.VW_CONTROL_ASISTENCIA_ATRASOS)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_CONTROL_ASISTENCIA_ATRASOS))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperarHorasCompensadas(ByVal ano As Integer) As DataView
        Try
            Dim ds As DataSet
            Dim da As New SqlDataAdapter("SELECT * FROM " & Vistas.VW_HORAS_EXTRAS_AUTORIZA_PAGO & " WHERE ANO_REAL=" & CType(ano, String), ArgoConfiguracion.ConnectionString)
            ds = New DataSet("SELECT * FROM " & Vistas.VW_HORAS_EXTRAS_AUTORIZA_PAGO & " WHERE ANO_REAL=" & CType(ano, String))
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(ds, Vistas.VW_HORAS_EXTRAS_AUTORIZA_PAGO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_HORAS_EXTRAS_AUTORIZA_PAGO))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function actualizar(ByVal datosDetalleControlAsistencia As EDetalleControlAsistencia) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand("EXEC " & SQL.STORE_PROCEDURES.ACTUALIZA_DETALLE_CONTROL_ASISTENCIA & " @ASISTENCIA_ID," & _
                 "@EMPLEADO_ID," & _
                 "@PERIODO_ID," & _
                 "@FECHA_ASISTENCIA," & _
                 "@HORA_ENTRADA," & _
                 "@HORA_SALIDA," & _
                 "@HORAS_TRABAJADAS," & _
                 "@HORAS_EXTRAS_DIURNAS," & _
                 "@HORAS_EXTRAS_NOCTURNAS," & _
                 "@MEDIO_DIA," & _
                 "@HORAS_ATRASOS," & _
                 "@HORAS_EXTRAS_DIURNAS_AUTORIZADAS," & _
                 "@HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS," & _
                 "@MEDIO_DIA_AUTORIZADO," & _
                 "@TIPO_EVENTO_ADMIN_ID," & _
                 "@HORAS_ATRASOS_AUTORIZADOS," & _
                 "@ANO_REAL," & _
                 "@MES_REAL," & _
                 "@OBSERVACIONES," & _
                 "@HORAS_COMPENSADAS_DIURNAS," & _
                 "@HORAS_COMPENSADAS_NOCTURNAS," & _
                 "@ESTADO")

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ASISTENCIA_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = datosDetalleControlAsistencia.asistenciaID
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = datosDetalleControlAsistencia.empleadoID
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = datosDetalleControlAsistencia.periodoID
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_ASISTENCIA"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = datosDetalleControlAsistencia.fechaAsistencia
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@HORA_ENTRADA"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = datosDetalleControlAsistencia.horaEntrada
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@HORA_SALIDA"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = datosDetalleControlAsistencia.horaSalida
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@HORAS_TRABAJADAS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = datosDetalleControlAsistencia.horasTrabajadas
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@HORAS_EXTRAS_DIURNAS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = datosDetalleControlAsistencia.horasExtrasDiurnas
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@HORAS_EXTRAS_NOCTURNAS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = datosDetalleControlAsistencia.horasExtrasNocturnas
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MEDIO_DIA"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Bit
        prm.Value = datosDetalleControlAsistencia.medioDiaAsistencia
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@HORAS_ATRASOS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = datosDetalleControlAsistencia.horaAtraso
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@HORAS_EXTRAS_DIURNAS_AUTORIZADAS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = datosDetalleControlAsistencia.horasExtrasDiurnasAutorizadas
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = datosDetalleControlAsistencia.horasExtrasNocturnasAutorizadas
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MEDIO_DIA_AUTORIZADO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Bit
        prm.Value = datosDetalleControlAsistencia.autorizaDesctoMedioDia
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_EVENTO_ADMIN_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = datosDetalleControlAsistencia.tipoEventoAdminID
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@HORAS_ATRASOS_AUTORIZADOS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = datosDetalleControlAsistencia.horaAtrasoAutorizadas
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ANO_REAL"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = datosDetalleControlAsistencia.anoReal
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MES_REAL"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.TinyInt
        prm.Value = datosDetalleControlAsistencia.mesReal
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@OBSERVACIONES"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = datosDetalleControlAsistencia.observaciones
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@HORAS_COMPENSADAS_DIURNAS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = datosDetalleControlAsistencia.horasCompensadasDiurnas
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@HORAS_COMPENSADAS_NOCTURNAS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = datosDetalleControlAsistencia.horasCompensadasNocturnas
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ESTADO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = datosDetalleControlAsistencia.estado
        cmd.Parameters.Add(prm)
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
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
    Public Function sumarHorasDeptoFecha(ByVal fechaAsistencia As DateTime, ByVal deptoID As Integer, _
                                ByRef totalHrsExtDiurnas As String, ByRef totalHrsExtNocturnas As String, ByRef totalHrsAtraso As String, _
                                ByRef totalHrsExtDiurnasAutoriz As String, ByRef totalHrsExtNocturnasAutoriz As String, ByRef totalHrsAtrasoAutoriz As String) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As New SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd.CommandText = SQL.STORE_PROCEDURES.SUMA_HORAS_DEPTARTAMENTO
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@DEPTO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = deptoID
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_ASISTENCIA"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = fechaAsistencia
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TOT_HRS_EXT_DIURNAS"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.VarChar
        prm.Size = 6
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TOT_HRS_EXT_NOCTURNAS"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.VarChar
        prm.Size = 6
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TOT_HRS_ATRASO"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.VarChar
        prm.Size = 6
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TOT_HRS_EXT_DIURNAS_AUTORIZ"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.VarChar
        prm.Size = 6
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TOT_HRS_EXT_NOCTURNAS_AUTORIZ"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.VarChar
        prm.Size = 6
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TOT_HRS_ATRASO_AUTORIZ"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.VarChar
        prm.Size = 6
        cmd.Parameters.Add(prm)
        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            totalHrsExtDiurnas = cmd.Parameters("@TOT_HRS_EXT_DIURNAS").Value()
            totalHrsExtNocturnas = cmd.Parameters("@TOT_HRS_EXT_NOCTURNAS").Value()
            totalHrsAtraso = cmd.Parameters("@TOT_HRS_ATRASO").Value()
            totalHrsExtDiurnasAutoriz = cmd.Parameters("@TOT_HRS_EXT_DIURNAS_AUTORIZ").Value()
            totalHrsExtNocturnasAutoriz = cmd.Parameters("@TOT_HRS_EXT_NOCTURNAS_AUTORIZ").Value()
            totalHrsAtrasoAutoriz = cmd.Parameters("@TOT_HRS_ATRASO_AUTORIZ").Value()
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
    Public Function sumarHorasEmpleadoFecha(ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime, ByVal EmpleadoID As Integer, _
                                ByRef totalHrsExtDiurnas As String, ByRef totalHrsExtNocturnas As String, ByRef totalHrsAtraso As String, _
                                ByRef totalHrsExtDiurnasAutoriz As String, ByRef totalHrsExtNocturnasAutoriz As String, ByRef totalHrsAtrasoAutoriz As String) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.SUMA_HORAS_EMPLEADO
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = EmpleadoID
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_INICIAL"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = fechaInicial
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_FINAL"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = fechaFinal
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TOT_HRS_EXT_DIURNAS"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.VarChar
        prm.Size = 6
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TOT_HRS_EXT_NOCTURNAS"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.VarChar
        prm.Size = 6
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TOT_HRS_ATRASO"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.VarChar
        prm.Size = 6
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TOT_HRS_EXT_DIURNAS_AUTORIZ"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.VarChar
        prm.Size = 6
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TOT_HRS_EXT_NOCTURNAS_AUTORIZ"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.VarChar
        prm.Size = 6
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TOT_HRS_ATRASO_AUTORIZ"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.VarChar
        prm.Size = 6
        cmd.Parameters.Add(prm)
        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            totalHrsExtDiurnas = cmd.Parameters("@TOT_HRS_EXT_DIURNAS").Value()
            totalHrsExtNocturnas = cmd.Parameters("@TOT_HRS_EXT_NOCTURNAS").Value()
            totalHrsAtraso = cmd.Parameters("@TOT_HRS_ATRASO").Value()
            totalHrsExtDiurnasAutoriz = cmd.Parameters("@TOT_HRS_EXT_DIURNAS_AUTORIZ").Value()
            totalHrsExtNocturnasAutoriz = cmd.Parameters("@TOT_HRS_EXT_NOCTURNAS_AUTORIZ").Value()
            totalHrsAtrasoAutoriz = cmd.Parameters("@TOT_HRS_ATRASO_AUTORIZ").Value()
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
    Public Function Busca(ByVal ID As Long, ByVal NOMBRE_TABLA As String, ByVal SQL As String) As DataRow
        Dim da As New SqlDataAdapter(SQL, ArgoConfiguracion.ConnectionString)
        da.Fill(Me, NOMBRE_TABLA)
        Try
            Return (Me.Tables(NOMBRE_TABLA).Rows.Find(ID))
        Catch excepcion As Exception
            Return Nothing
        End Try
    End Function
End Class
