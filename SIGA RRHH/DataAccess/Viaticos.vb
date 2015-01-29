Imports System.ComponentModel
Imports System.Data.SqlClient
Imports cl.presidencia.Argo.Comun

Public Class Viaticos
    Inherits DSViatico

    Private daViatico As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_VIATICO, ArgoConfiguracion.ConnectionString)
    Dim connection As SqlConnection

    Public Sub New()
        MyBase.New()
        connection = New SqlConnection
        connection.ConnectionString = ArgoConfiguracion.ConnectionString
    End Sub
    Protected Overrides Sub Finalize()
        daViatico = Nothing
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        connection = Nothing
        MyBase.Finalize()
    End Sub
    Public Function InsertarEncabezado(ByVal Viatico As DataRow) As DataRow
        Dim daViatico As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_VIATICO, ArgoConfiguracion.ConnectionString)
        daViatico.Fill(Me, Tablas.RH_PER_VIATICO)
        daViatico.InsertCommand = Me.GetUpdateCmdViaticoEncabezado()
        daViatico.InsertCommand.Parameters("@TIPO_RESOLUCION").Value = Viatico("TIPO_RESOLUCION")
        daViatico.InsertCommand.Parameters("@NRO_MEMORANDUM_INTERNO").Value = Viatico("NRO_MEMORANDUM_INTERNO")
        daViatico.InsertCommand.Parameters("@FECHA_MEMORANDUM").Value = Viatico("FECHA_MEMORANDUM")
        daViatico.InsertCommand.Parameters("@MOTIVO").Value = Viatico("MOTIVO")
        daViatico.InsertCommand.Parameters("@NRO_RESOLUCION").Value = Viatico("NRO_RESOLUCION")
        daViatico.InsertCommand.Parameters("@FECHA_RESOLUCION").Value = Viatico("FECHA_RESOLUCION")
        daViatico.InsertCommand.Parameters("@PERIODO_ID").Value = Viatico("PERIODO_ID")
        daViatico.InsertCommand.Parameters("@ESTADO_REGISTRO").Value = Viatico("ESTADO_REGISTRO")
        daViatico.InsertCommand.Parameters("@TIPO_EVENTO_ADMIN_ID").Value = Viatico("TIPO_EVENTO_ADMIN_ID")
        daViatico.InsertCommand.Parameters("@DEPTO_ID").Value = Viatico("DEPTO_ID")
        Me.Tables(Tablas.RH_PER_VIATICO).Rows.Add(Viatico)
        Try
            daViatico.Update(Me, Tablas.RH_PER_VIATICO)
            Return (Viatico)
        Catch exSQL As SqlException
            Debug.WriteLine(exSQL.ToString)
            Throw New Exception(exSQL.Message)
        End Try
    End Function
    Public Function ActualizarEncabezado(ByVal ViaticoDR As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_VIATICO, ArgoConfiguracion.ConnectionString)
        Me.Tables(Tablas.RH_PER_VIATICO).LoadDataRow(ViaticoDR.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand(da)
        da.Update(Me, Tablas.RH_PER_VIATICO)
        Return (ViaticoDR)
    End Function
    Public Function ActualizarDetalle(ByVal ViaticoDetDR As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_DETALLE_VIATICO, ArgoConfiguracion.ConnectionString)
        Me.Tables(Tablas.RH_PER_VIATICO_DETALLE).LoadDataRow(ViaticoDetDR.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand(da)
        da.Update(Me, Tablas.RH_PER_VIATICO_DETALLE)
        Return (ViaticoDetDR)
    End Function
    Public Function InsertarDetalle(ByVal ViaticoDet As DataRow) As DataRow
        Dim daViaticoDet As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_DETALLE_VIATICO, ArgoConfiguracion.ConnectionString)
        daViaticoDet.Fill(Me, Tablas.RH_PER_VIATICO_DETALLE)
        daViaticoDet.InsertCommand = Me.GetUpdateCmdViaticoDetalle()
        daViaticoDet.InsertCommand.Parameters("@VIATICO_ID").Value = ViaticoDet("VIATICO_ID")
        daViaticoDet.InsertCommand.Parameters("@CANTIDAD_DIAS").Value = ViaticoDet("CANTIDAD_DIAS")
        daViaticoDet.InsertCommand.Parameters("@FECHA_INICIO").Value = ViaticoDet("FECHA_INICIO")
        daViaticoDet.InsertCommand.Parameters("@FECHA_TERMINO").Value = ViaticoDet("FECHA_TERMINO")
        daViaticoDet.InsertCommand.Parameters("@MOTIVO").Value = ViaticoDet("MOTIVO")
        daViaticoDet.InsertCommand.Parameters("@PAIS_ID").Value = ViaticoDet("PAIS_ID")
        daViaticoDet.InsertCommand.Parameters("@COMUNA_ID").Value = ViaticoDet("COMUNA_ID")
        daViaticoDet.InsertCommand.Parameters("@MONTO").Value = ViaticoDet("MONTO")
        daViaticoDet.InsertCommand.Parameters("@EMPLEADO_ID").Value = ViaticoDet("EMPLEADO_ID")
        daViaticoDet.InsertCommand.Parameters("@NUMERO_DOCUMENTO").Value = ViaticoDet("NUMERO_DOCUMENTO")
        daViaticoDet.InsertCommand.Parameters("@FECHA_DOCUMENTO").Value = ViaticoDet("FECHA_DOCUMENTO")
        daViaticoDet.InsertCommand.Parameters("@REGION_ID").Value = ViaticoDet("REGION_ID")
        daViaticoDet.InsertCommand.Parameters("@DESTINO").Value = ViaticoDet("DESTINO")
        daViaticoDet.InsertCommand.Parameters("@ESTADO_VIATICO").Value = ViaticoDet("ESTADO_VIATICO")
        daViaticoDet.InsertCommand.Parameters("@NUMERO_EGRESO").Value = ViaticoDet("NUMERO_EGRESO")
        daViaticoDet.InsertCommand.Parameters("@PATENTE_VEHICULO").Value = ViaticoDet("PATENTE_VEHICULO")
        Me.Tables(Tablas.RH_PER_VIATICO_DETALLE).Rows.Add(ViaticoDet)
        Try
            daViaticoDet.Update(Me, Tablas.RH_PER_VIATICO_DETALLE)
            Return (ViaticoDet)
        Catch exSQL As SqlException
            Debug.WriteLine(exSQL.ToString)
            Throw New Exception(exSQL.Message)
        End Try
    End Function
    Private Function GetUpdateCommand(ByVal da As SqlDataAdapter) As SqlCommand
        Dim cb As New SqlCommandBuilder(da)
        Return (cb.GetUpdateCommand())
        cb = Nothing
    End Function

    Private Function GetUpdateCmdViaticoEncabezado() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_VIATICO_ENCABEZADO

        sqlParam = New SqlClient.SqlParameter("@TIPO_RESOLUCION", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NRO_MEMORANDUM_INTERNO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_MEMORANDUM", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MOTIVO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NRO_RESOLUCION", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_RESOLUCION", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PERIODO_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ESTADO_REGISTRO", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@TIPO_EVENTO_ADMIN_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@DEPTO_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@Identity", SqlDbType.BigInt, 0, "VIATICO_ID")
        sqlParam.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(sqlParam)

        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout
        Return (sqlCmd)
    End Function
    Private Function GetUpdateCmdViaticoDetalle() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandTimeout = 40
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_VIATICO_DETALLE

        sqlParam = New SqlClient.SqlParameter("@VIATICO_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CANTIDAD_DIAS", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_INICIO", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_TERMINO", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MOTIVO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PAIS_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@COMUNA_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@EMPLEADO_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NUMERO_DOCUMENTO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_DOCUMENTO", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@REGION_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ESTADO_VIATICO", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@DESTINO", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NUMERO_EGRESO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PATENTE_VEHICULO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@Identity", SqlDbType.BigInt, 0, "VIATICO_DETALLE_ID")
        sqlParam.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(sqlParam)

        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout
        Return (sqlCmd)
    End Function
    Public Function validaRangoFechaViatico(ByVal fechaInicio As Date, ByVal idEmpleado As Integer, ByVal cantidadDias As Integer, ByVal idDetalleEventoAdmin As Integer, ByVal idTipoEventoAdmin As Integer) As String
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        Dim mensaje As String

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.VALIDA_RANGO_FECHA_VIATICO
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 40

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_INICIO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = fechaInicio
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idEmpleado
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@CANTIDAD_DIAS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = cantidadDias
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@DETALLE_EVENTO_ADMIN_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idDetalleEventoAdmin
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_EVENTO_ADMIN_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idTipoEventoAdmin
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MENSAJE"
        prm.Direction = ParameterDirection.Output
        prm.Size = 200
        prm.SqlDbType = SqlDbType.VarChar
        cmd.Parameters.Add(prm)


        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            mensaje = cmd.Parameters("@MENSAJE").Value()
            Return mensaje
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
    Public Function eliminaViaticoMaestro(ByVal idViatico As Integer) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.ELIMINA_VIATICO_MAESTRO
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@VIATICO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idViatico
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

    Public Function eliminaDetalle(ByVal idViaticoDetalle As Integer) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.ELIMINA_VIATICO_DETALLE
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@VIATICO_DETALLE_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idViaticoDetalle
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
    Public Function Busca(ByVal ID As Long, ByVal NOMBRE_TABLA As String, ByVal SQL As String) As DataRow
        Dim da As New SqlDataAdapter(SQL, ArgoConfiguracion.ConnectionString)
        da.Fill(Me, NOMBRE_TABLA)
        Try
            Return Me.Tables(NOMBRE_TABLA).Rows.Find(ID)
        Catch excepcion As Exception
            Return Nothing
        End Try
    End Function
    Public Function Busca(ByVal gradoID As Integer, ByVal calculaViativoMesAnterior As Boolean) As Integer
        Dim mySelectQuery As String

        If calculaViativoMesAnterior Then
            mySelectQuery = "SELECT VALOR_VIATICO_OLD FROM RH_REM_GRADO WHERE GRADO_ID=" & gradoID & " AND ESTADO_REGISTRO=1"
        Else
            mySelectQuery = "SELECT VALOR_VIATICO FROM RH_REM_GRADO WHERE GRADO_ID=" & gradoID & " AND ESTADO_REGISTRO=1"
        End If


        Dim myConnection As New SqlConnection(ArgoConfiguracion.ConnectionString)
        Dim myCommand As New SqlCommand(mySelectQuery, myConnection)
        Dim valorID As Integer

        Try
            myConnection.Open()
            Dim myReader As SqlDataReader
            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                valorID = myReader.GetValue(0)
            End While
            myReader.Close()
            myConnection.Close()
            Return valorID
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function buscaIDNumeroMemorandum(ByVal numeroMemorandum As String, ByVal anoProceso As Integer, ByVal deptoID As Integer) As Integer
        Dim mySelectQuery As String
        mySelectQuery = "SELECT  RH_PER_VIATICO.VIATICO_ID " & _
                        "FROM RH_PER_VIATICO INNER JOIN " & _
                        "RH_REM_PERIODO ON RH_PER_VIATICO.PERIODO_ID = RH_REM_PERIODO.PERIODO_ID " & _
                        "WHERE RH_REM_PERIODO.ANO = " & anoProceso & _
                        " AND CONVERT(INTEGER,NRO_MEMORANDUM_INTERNO)=" & numeroMemorandum & _
                        " AND DEPTO_ID=" & deptoID

        Dim myConnection As New SqlConnection(ArgoConfiguracion.ConnectionString)
        Dim myCommand As New SqlCommand(mySelectQuery, myConnection)
        Dim valorID As Integer

        Try
            myConnection.Open()
            Dim myReader As SqlDataReader
            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                valorID = myReader.GetValue(0)
            End While
            myReader.Close()
            myConnection.Close()
            Return valorID
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function buscaIDNumeroResolucion(ByVal numeroResolucion As String, ByVal anoProceso As Integer) As Integer
        Dim mySelectQuery As String
        mySelectQuery = "SELECT  RH_PER_VIATICO.VIATICO_ID " & _
                        "FROM RH_PER_VIATICO INNER JOIN " & _
                        "RH_REM_PERIODO ON RH_PER_VIATICO.PERIODO_ID = RH_REM_PERIODO.PERIODO_ID " & _
                        "WHERE RH_REM_PERIODO.ANO = " & anoProceso & _
                        " AND CONVERT(INTEGER,NRO_RESOLUCION)=" & numeroResolucion

        Dim myConnection As New SqlConnection(ArgoConfiguracion.ConnectionString)
        Dim myCommand As New SqlCommand(mySelectQuery, myConnection)
        Dim valorID As Integer

        Try
            myConnection.Open()
            Dim myReader As SqlDataReader
            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                valorID = myReader.GetValue(0)
            End While
            myReader.Close()
            myConnection.Close()
            Return valorID
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function estadoViatico(ByVal viaticoID As Integer) As Integer
        Dim mySelectQuery As String
        mySelectQuery = "SELECT DISTINCT ESTADO_VIATICO " & _
                        "FROM RH_PER_VIATICO_DETALLE " & _
                        "WHERE VIATICO_ID = " & viaticoID
        '" AND ESTADO_VIATICO <>0"

        Dim myConnection As New SqlConnection(ArgoConfiguracion.ConnectionString)
        Dim myCommand As New SqlCommand(mySelectQuery, myConnection)
        Dim valorID As Integer

        Try
            myConnection.Open()
            Dim myReader As SqlDataReader
            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                valorID = myReader.GetValue(0)
            End While
            myReader.Close()
            myConnection.Close()
            Return valorID
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperarViaticoDetalle(ByVal IDViatico As Long) As DataView
        Try
            Dim ds As New DataSet
            Dim daViaticosAsignados As New SqlDataAdapter("SELECT * FROM " & Vistas.VW_RH_PER_VIATICOS & " WHERE VIATICO_ID=" & IDViatico & " ORDER BY DEPARTAMENTO, CONVERT(INTEGER, NRO_MEMORANDUM_INTERNO)", ArgoConfiguracion.ConnectionString)
            daViaticosAsignados.Fill(ds, Vistas.VW_RH_PER_VIATICOS)
            Dim dv As New DataView
            dv = New DataView(ds.Tables(0), "", "", DataViewRowState.OriginalRows)
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperarViaticoPorMemo(ByVal Año As Integer, ByVal soloPendientes As Boolean) As DataView
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter("SELECT * FROM VW_VIATICO_NUMERO_MEMORANDUM WHERE ANO = " & Año.ToString & IIf(soloPendientes = True, " AND ESTADO_VIATICO=0", ""), ArgoConfiguracion.ConnectionString)
            da.Fill(ds, Vistas.VW_VIATICO_NUMERO_MEMORANDUM)
            Dim dv As New DataView
            dv = New DataView(ds.Tables(0), "", "", DataViewRowState.OriginalRows)
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function recuperarResolucionViaticoCabecera(ByVal ViaticoId As Integer) As DataView
        Try
            Dim ds As New DataSet
            Dim cmdSQL As String = "SELECT NRO_MEMORANDUM_INTERNO, CONVERT(VARCHAR(10),FECHA_MEMORANDUM, 103) AS FECHA_MEMORANDUM, DEPARTAMENTO, VIATICO_ID, ANO AS AÑO, MES " & _
                                   "FROM VW_VIATICO_NUMERO_MEMORANDUM WHERE VIATICO_ID = " + ViaticoId.ToString
            Dim da As New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
            da.Fill(ds, "VW_VIATICO_NUMERO_MEMORANDUM")
            Dim dv As New DataView
            dv = New DataView(ds.Tables(0), "", "", DataViewRowState.OriginalRows)
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function recuperarResolucionViatico(ByVal ViaticoId As Integer) As DataTable
        Dim mySelectQuery As String = "SELECT NOMBRE_EMPLEADO AS NOMBRE, GRADO AS GRADO, CALIDAD_JURIDICA AS [CALIDAD JURIDICA], REGION_DESTINO AS DESTINO, DIAS AS [Nº DIAS], " & _
                                      "CONVERT(VARCHAR(10),FECHA_INICIO, 103) AS DESDE, CONVERT(VARCHAR(10),FECHA_TERMINO, 103) AS HASTA, PATENTE_VEHICULO AS [PATENTE VEHIC] " & _
                                      "FROM VW_VIATICOS WHERE VIATICO_ID = " + ViaticoId.ToString + " ORDER BY NOMBRE_EMPLEADO, FECHA_INICIO"

        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(mySelectQuery, ArgoConfiguracion.ConnectionString)
            da.Fill(ds, "VW_VIATICOS")
            Return (ds.Tables("VW_VIATICOS"))
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
