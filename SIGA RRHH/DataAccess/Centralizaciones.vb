Imports System.ComponentModel
Imports System.Data.SqlClient
Imports cl.presidencia.Argo.Comun

Public Class Centralizaciones
    Inherits DSAsientoContable

   
    Public Sub New()
        MyBase.New()
    End Sub

    Public Shared Function recuperaAsientoContable(ByVal periodoID As Integer, ByVal tipoProceso As String, ByVal cuentasSoloCosto As Boolean, ByVal estadoPeriodo As Boolean, ByRef asientoContableID As Integer) As DataView
        Try
            Dim clausulaWhere As String = ""
            Dim procesoRemun As String = ""

            'Si tipo proceso es sueldos (planta, contrata y honorarios)
            If tipoProceso = "S" Then
                clausulaWhere = " AND (TIPO_PROCESO='S')"
                procesoRemun = " AND (PROCESO_REMUNERACION='SUELDOS')"
            Else
                'Si tipo proceso es viático
                If tipoProceso = "V" Then
                    clausulaWhere = " AND (TIPO_PROCESO='V')"
                    procesoRemun = " AND PROCESO_REMUNERACION='VIATICOS'"
                End If
            End If

            If cuentasSoloCosto Then
                procesoRemun = procesoRemun & " AND ES_COSTO=1"
            End If

            Dim numeroID As Integer
            Dim cmdSQL As String
            Dim dv As DataView = Nothing

            numeroID = Comun.Utiles.Busca("SELECT ASIENTO_CONTABLE_ID FROM " & Tablas.RH_REM_ASIENTO_CONTABLE & " WHERE PERIODO_ID = " & periodoID & clausulaWhere)
            'Si encuentra registro en tabla RH_REM_ASIENTO_CONTABLE significa que ya se ha generado
            'el asiento contable y lo carga a la grilla
            If numeroID > 0 Then
                cmdSQL = "SELECT * FROM " & Vistas.VW_ASIENTO_CONTABLE & " WHERE ASIENTO_CONTABLE_ID=" & numeroID
                Dim ds As DataSet
                Dim da As New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
                ds = New DataSet(cmdSQL)
                da.Fill(ds, Vistas.VW_ASIENTO_CONTABLE)
                Dim dvm As New DataViewManager(ds)
                dv = dvm.CreateDataView(ds.Tables(Vistas.VW_ASIENTO_CONTABLE))
            Else
                'Si estado de periodo es verdadero indica que el periodo (año/mes) se encuentra vigente y se puede 
                'generar el asiento contable desde la vista VW_CENTRALIZACION_SUELDOS_HONORARIOS
                If estadoPeriodo Then
                    cmdSQL = "SELECT CENTRO_COSTO_ALIAS, CENTRO_COSTO_CONTAB_DESC, CUENTA_CONTABLE, GLOSA, SUM(MONTO) AS MONTO" & _
                             " FROM VW_CENTRALIZACION_CONTABLE WHERE PERIODO_ID=" & periodoID & procesoRemun & _
                             " GROUP BY CENTRO_COSTO_ALIAS, CENTRO_COSTO_CONTAB_DESC, CUENTA_CONTABLE, GLOSA"
                    Dim ds As DataSet
                    Dim da As New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
                    ds = New DataSet(cmdSQL)
                    da.Fill(ds, "VW_CENTRALIZACION_CONTABLE")
                    Dim dvm As New DataViewManager(ds)
                    dv = dvm.CreateDataView(ds.Tables("VW_CENTRALIZACION_CONTABLE"))
                End If
            End If
            asientoContableID = numeroID
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function recuperaAsientoPresupuesto(ByVal periodoID As Integer, ByVal tipoCalculo As String, ByVal estadoPeriodo As Boolean, ByRef asientoContableID As Integer) As DataView
        Try

            Dim numeroID As Integer
            Dim cmdSQL As String = ""
            Dim dv As DataView

            numeroID = Comun.Utiles.Busca("SELECT TOP 1 ASIENTO_PRESUP_ID FROM RH_REM_ASIENTO_PRESUP" & " WHERE PERIODO_ID = " & periodoID & " AND TIPO_CALCULO = '" & tipoCalculo & "'")
            'Si encuentra registro en tabla RH_REM_ASIENTO_PRESUP significa que ya se ha generado
            'el asiento contable y lo carga a la grilla
            If numeroID > 0 Then
                cmdSQL = "SELECT ANO, MES, CALIDAD_JURIDICA_DESC, CENTRO_COSTO_CONTAB_DESC, CUENTA_PRESUPUESTO, MONTO, CENTRO_COSTO_ALIAS" & _
                         " FROM RH_REM_ASIENTO_PRESUP WHERE PERIODO_ID = " & periodoID & " AND TIPO_CALCULO = '" & tipoCalculo & "'"

                Dim ds As DataSet
                Dim da As New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
                ds = New DataSet(cmdSQL)
                da.Fill(ds, "RH_REM_ASIENTO_PRESUP")
                Dim dvm As New DataViewManager(ds)
                dv = dvm.CreateDataView(ds.Tables("RH_REM_ASIENTO_PRESUP"))
            Else
                'Si estado de periodo es verdadero indica que el periodo (año/mes) se encuentra vigente y se puede 
                'generar el asiento contable desde la vista VW_CENTRALIZACION_SUELDOS_HONORARIOS
                If estadoPeriodo And (tipoCalculo = "N" Or tipoCalculo = "V") Then
                    cmdSQL = "SELECT ANO, MES, CALIDAD_JURIDICA_DESC, CENTRO_COSTO_CONTAB_DESC, CUENTA_PRESUPUESTO, SUM(MONTO) AS MONTO, CENTRO_COSTO_ALIAS" & _
                             " FROM VW_CENTRALIZACION_CONTABLE WHERE PERIODO_ID = " & periodoID & " AND ES_COSTO_PRESUP = 1 AND TIPO_CALCULO = '" & tipoCalculo & "'" & _
                             " GROUP BY ANO, MES, CALIDAD_JURIDICA_DESC, CENTRO_COSTO_ALIAS, CENTRO_COSTO_CONTAB_DESC, CUENTA_PRESUPUESTO"
                ElseIf estadoPeriodo And tipoCalculo = "H" Then
                    cmdSQL = "SELECT ANO, MES, CALIDAD_JURIDICA_DESC, CENTRO_COSTO_CONTAB_DESC+' '+CONVERT(VARCHAR(10),NUMERO_TICKET_DEXON)+' '+NOMBRE_EMPLEADO AS CENTRO_COSTO_CONTAB_DESC, CUENTA_PRESUPUESTO, SUM(MONTO) AS MONTO, CENTRO_COSTO_ALIAS" & _
                             " FROM VW_CENTRALIZACION_CONTABLE WHERE PERIODO_ID = " & periodoID & " AND ES_COSTO_PRESUP = 1 AND TIPO_CALCULO = '" & tipoCalculo & "'" & _
                             " GROUP BY ANO, MES, CALIDAD_JURIDICA_DESC, CENTRO_COSTO_ALIAS, CENTRO_COSTO_CONTAB_DESC+' '+CONVERT(VARCHAR(10),NUMERO_TICKET_DEXON)+' '+NOMBRE_EMPLEADO, CUENTA_PRESUPUESTO"
                End If
                Dim ds As DataSet
                Dim da As New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
                ds = New DataSet(cmdSQL)
                da.Fill(ds, "VW_CENTRALIZACION_CONTABLE")
                Dim dvm As New DataViewManager(ds)
                dv = dvm.CreateDataView(ds.Tables("VW_CENTRALIZACION_CONTABLE"))

            End If
            asientoContableID = numeroID
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function procesarAsientoPresupuesto(ByVal periodoID As Integer, ByVal tipoCalculo As String, ByVal estadoPeriodo As Boolean, ByVal usuario As String) As Boolean
        Dim cmdSQL As String
        If tipoCalculo = "H" Then
            cmdSQL = "INSERT INTO RH_REM_ASIENTO_PRESUP (ANO, MES, CALIDAD_JURIDICA_DESC, CENTRO_COSTO_ALIAS, CENTRO_COSTO_CONTAB_DESC, CUENTA_PRESUPUESTO, MONTO, PERIODO_ID, TIPO_CALCULO, USUARIO, FECHA_ACTUALIZACION, COMPROMISO_PRESUPUESTARIO_ID) " & _
                     "SELECT ANO, MES, CALIDAD_JURIDICA_DESC, CENTRO_COSTO_ALIAS, CENTRO_COSTO_CONTAB_DESC+' '+CONVERT(VARCHAR(10),NUMERO_TICKET_DEXON)+' '+NOMBRE_EMPLEADO, CUENTA_PRESUPUESTO, SUM(MONTO) AS MONTO, " & CType(periodoID, String) & ", '" & tipoCalculo & "', '" & usuario + "', GETDATE(), COMPROMISO_PRESUPUESTARIO_ID" & _
                     " FROM VW_CENTRALIZACION_CONTABLE WHERE PERIODO_ID = " & periodoID & " AND ES_COSTO_PRESUP = 1 AND TIPO_CALCULO = '" & tipoCalculo & "'" & _
                     " GROUP BY ANO, MES, CALIDAD_JURIDICA_DESC, CENTRO_COSTO_ALIAS, CENTRO_COSTO_CONTAB_DESC+' '+CONVERT(VARCHAR(10),NUMERO_TICKET_DEXON)+' '+NOMBRE_EMPLEADO, CUENTA_PRESUPUESTO, COMPROMISO_PRESUPUESTARIO_ID"
        Else
            cmdSQL = "INSERT INTO RH_REM_ASIENTO_PRESUP (ANO, MES, CALIDAD_JURIDICA_DESC, CENTRO_COSTO_ALIAS, CENTRO_COSTO_CONTAB_DESC, CUENTA_PRESUPUESTO, MONTO, PERIODO_ID, TIPO_CALCULO, USUARIO, FECHA_ACTUALIZACION, COMPROMISO_PRESUPUESTARIO_ID) " & _
                      "SELECT ANO, MES, CALIDAD_JURIDICA_DESC, CENTRO_COSTO_ALIAS, CENTRO_COSTO_CONTAB_DESC, CUENTA_PRESUPUESTO, SUM(MONTO) AS MONTO, " & CType(periodoID, String) & ", '" & tipoCalculo & "', '" & usuario + "', GETDATE(), 0" & _
                      " FROM VW_CENTRALIZACION_CONTABLE WHERE PERIODO_ID = " & periodoID & " AND ES_COSTO_PRESUP = 1 AND TIPO_CALCULO = '" & tipoCalculo & "'" & _
                      " GROUP BY ANO, MES, CALIDAD_JURIDICA_DESC, CENTRO_COSTO_ALIAS, CENTRO_COSTO_CONTAB_DESC, CUENTA_PRESUPUESTO"
        End If
        Try
            EjecutaSQL(cmdSQL)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function
    Public Shared Function ActualizarTicketDexon(ByVal periodoID As Integer, ByVal tipoCalculo As String, ByVal ticketDexon As String) As String
        Dim cmdSQL As String
        cmdSQL = "UPDATE RH_REM_ASIENTO_PRESUP SET TICKET_DEXON = '" + RTrim(ticketDexon) + "' WHERE PERIODO_ID = " & periodoID & " AND TIPO_CALCULO = '" & tipoCalculo & "'"
        Try
            EjecutaSQL(cmdSQL)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function

    Public Shared Function ValidarNumeroCompromisoDexon(ByVal periodoID As Integer, ByVal tipoCalculo As String) As String
        Dim mySelectQuery As String = "SELECT NUMERO_TICKET_DEXON, NOMBRE_EMPLEADO, PERIODO_ID, EMPLEADO_ID FROM VW_CENTRALIZACION_CONTABLE " & _
                                       " WHERE PERIODO_ID = " & periodoID & _
                                       " AND ITEM_ID = 1 " & _
                                       " AND TIPO_CALCULO = '" & tipoCalculo & "'"


        Try
            Dim detalle As DataTable
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(mySelectQuery, ArgoConfiguracion.ConnectionString)
            da.Fill(ds, "VW_CENTRALIZACION_CONTABLE")
            detalle = ds.Tables("VW_CENTRALIZACION_CONTABLE")

            Dim mensaje As String = ""
            Dim fila As Data.DataRow
            Dim numeroCompromisoDexon As String
            Dim nombreEmpleado As String
            Dim idCompromisoDexon As Integer
            For Each fila In detalle.Rows
                numeroCompromisoDexon = CType(fila("NUMERO_TICKET_DEXON"), String)
                nombreEmpleado = fila("NOMBRE_EMPLEADO")

                buscarCompromisoPresupuestioDexon(numeroCompromisoDexon, fila("EMPLEADO_ID"), fila("PERIODO_ID"), idCompromisoDexon)
                If idCompromisoDexon = 0 Then
                    mensaje = mensaje + Chr(13) + "Compromiso: " + numeroCompromisoDexon + " no existe en Dexon (" + nombreEmpleado + ")"
                End If
            Next
            Return mensaje
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Shared Function BuscarTicketDexon(ByVal periodoID As Integer, ByVal tipoCalculo As String) As String
        Dim cmdSQL As String
        cmdSQL = "SELECT TICKET_DEXON FROM RH_REM_ASIENTO_PRESUP WHERE PERIODO_ID = " & periodoID & " AND TIPO_CALCULO = '" & tipoCalculo & "'"
        Try
            Return BuscaString(cmdSQL)
        Catch ex As Exception
            Throw ex
            Return (False)
        End Try
    End Function
    Public Shared Function generarAsientoPresupuestoHaciaDexon(ByVal periodoId As Integer, ByVal tipoCalculo As String, ByVal mensajeDevuelto As String) As String
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        Dim mensaje As String = ""

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.ASIENTO_PRESUPUESTARIO_DEXON
        cmd.CommandTimeout = 200
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = periodoId
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_CALCULO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = tipoCalculo
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MENSAJE"
        prm.Direction = ParameterDirection.Output
        prm.Size = 100
        prm.SqlDbType = SqlDbType.VarChar
        cmd.Parameters.Add(prm)


        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            mensajeDevuelto = cmd.Parameters("@MENSAJE").Value
            Return mensajeDevuelto
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return -1
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function

    Public Shared Function enviaHonorarioDexon(ByVal empleadoId As Integer, ByVal año As Integer) As Object
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        Dim mensaje As String = ""

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.ENVIA_HONORARIO_DEXON
        cmd.CommandTimeout = 200
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = empleadoId
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@AÑO_PROCESO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = año
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

    Public Shared Function buscarCompromisoPresupuestioDexon(ByVal NumeroCompromisoDexon As String, ByVal empleadoId As Integer, ByVal periodoId As Integer, ByRef idCompromisoDexon As Integer) As Integer
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        Dim mensaje As String = ""

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = "sp_BuscarCompromisoPresupuearioDexon"
        cmd.CommandTimeout = 200
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ID_SIGFE_PRESUPUESTO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = NumeroCompromisoDexon
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = empleadoid
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIOD_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = periodoId
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@COMPROMISO_PRESUPUESTARIO_ID"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.Int
        cmd.Parameters.Add(prm)

        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            idCompromisoDexon = prm.Value
            Return idCompromisoDexon
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return -1
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function

    Public Shared Function recuperarDetalleAsientoContable(ByVal asientoContableID As Integer, ByVal ano As Integer, ByVal mes As Integer) As DataSet
        Dim ds As New DataAccess.DSAsientoContable
        Dim dt As DataAccess.DSAsientoContable.RH_REM_ASIENTO_CONTABLE_DETALLEDataTable

        Dim cmdSQL As String = "SELECT ASIENTO_CONTABLE_ID, CODIGO_CENTRO_COSTO_CONTABLE, DESCRIPCION_CENTRO_COSTO, CUENTA_CONTABLE, GLOSA, MONTO, USUARIO, FECHA_MODIFICACION " & _
                               "FROM RH_REM_ASIENTO_CONTABLE_DETALLE WHERE ASIENTO_CONTABLE_ID=" & asientoContableID

        Dim da As SqlDataAdapter = New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
        da.Fill(ds, Tablas.RH_REM_ASIENTO_CONTABLE_DETALLE)
        dt = ds.Tables("RH_REM_ASIENTO_CONTABLE_DETALLE")

        Dim drAsientoContable As DataAccess.DSAsientoContable.ASIENTO_CONTABLERow
        Dim row As DataAccess.DSAsientoContable.RH_REM_ASIENTO_CONTABLE_DETALLERow

        'Para cada fila existente en la tabla RH_REM_ASIENTO_CONTABLE_DETALLE se comienza a llenar
        'tabla ASIENTO_CONTABLE del dataset DSAsientoContable
        For Each row In dt.Rows
            With row
                drAsientoContable = ds.Tables("ASIENTO_CONTABLE").NewRow
                drAsientoContable.NUMERO_ASIENTO_CONTABLE = .ASIENTO_CONTABLE_ID
                drAsientoContable.ANO = ano
                drAsientoContable.MES = mes
                drAsientoContable.CODIGO_CENTRO_COSTO = .CODIGO_CENTRO_COSTO_CONTABLE
                drAsientoContable.CUENTA_CONTABLE = .CUENTA_CONTABLE
                drAsientoContable.GLOSA = .GLOSA
                drAsientoContable.MONTO = .MONTO
                drAsientoContable.FECHA_CREACION = .FECHA_MODIFICACION
                drAsientoContable.USUARIO = .USUARIO
                ds.ASIENTO_CONTABLE.AddASIENTO_CONTABLERow(drAsientoContable)
            End With
        Next
        Return ds.Tables("ASIENTO_CONTABLE").DataSet
    End Function
    Public Function InsertarEncabezado(ByVal dr As DataRow, ByVal asientoContableID As Integer) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ASIENTO_CONTABLE, ArgoConfiguracion.ConnectionString)
        da.Fill(Me, Tablas.RH_REM_ASIENTO_CONTABLE)
        da.InsertCommand = Me.GetUpdateCmdViaticoDetalle()
        da.InsertCommand.Parameters("@PERIODO_ID").Value = dr("PERIODO_ID")
        da.InsertCommand.Parameters("@ESTADO_REGISTRO").Value = dr("ESTADO_REGISTRO")
        da.InsertCommand.Parameters("@TIPO_PROCESO").Value = dr("TIPO_PROCESO")
        da.InsertCommand.Parameters("@ES_COSTO").Value = dr("ES_COSTO")
        da.InsertCommand.Parameters("@ASIENTO_CONTABLE_ID").Value = asientoContableID
        Me.Tables(Tablas.RH_REM_ASIENTO_CONTABLE).Rows.Add(dr)
        Try
            da.Update(Me, Tablas.RH_REM_ASIENTO_CONTABLE)
            Return (dr)
        Catch exSQL As SqlException
            Debug.WriteLine(exSQL.ToString)
            Throw New Exception(exSQL.Message)
        End Try

    End Function
    Private Function GetUpdateCmdViaticoDetalle() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandTimeout = 40
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_ENCABEZADO_ASIENTO_CONTAB

        sqlParam = New SqlClient.SqlParameter("@PERIODO_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ESTADO_REGISTRO", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@TIPO_PROCESO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ES_COSTO", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ASIENTO_CONTABLE_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@Identity", SqlDbType.BigInt, 0, "ASIENTO_CONTABLE_ID")
        sqlParam.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(sqlParam)

        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout
        Return (sqlCmd)
    End Function

    Private Shared Sub EjecutaSQL(ByVal myExecuteQuery As String)
        Try
            Dim myConnection As New SqlConnection
            myConnection.ConnectionString = ArgoConfiguracion.ConnectionString
            Dim myCommand As New SqlCommand(myExecuteQuery, myConnection)
            myCommand.CommandTimeout = ArgoConfiguracion.CommandTimeout
            myCommand.Connection.Open()
            myCommand.ExecuteNonQuery()
            myConnection.Close()
        Catch exSQL As Exception
            Throw New Exception(exSQL.Message)
        End Try
    End Sub
    Private Shared Function BuscaString(ByVal SQL As String) As String
        Dim mySelectQuery As String = SQL
        Dim myConnection As New SqlConnection(ArgoConfiguracion.ConnectionString)
        Dim myCommand As New SqlCommand(mySelectQuery, myConnection)
        Dim valorString As String = ""

        Try
            myConnection.Open()
            Dim myReader As SqlDataReader
            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                valorString = myReader.GetString(0)
            End While
            myReader.Close()
            myConnection.Close()
            Return valorString
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
