Imports System.ComponentModel
Imports System.Data.SqlClient
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.Comun.TiposDeDatos

Public Class Mantenedores
    Inherits DSMantenedores
    Dim conn As SqlConnection

    Public Sub New()
        MyBase.New()
        conn = New SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
    End Sub

    Public Function recuperaDepto() As DataView
        Try
            Dim daDeptos As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_DEPARTAMENTO & " ORDER BY DESCRIPCION", ArgoConfiguracion.ConnectionString)
            daDeptos.Fill(Me, Tablas.RH_PER_DEPARTAMENTO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_PER_DEPARTAMENTO))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperaIsapres() As DataView
        Try
            Dim daIsapres As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_REM_ISAPRE & " ORDER BY DESCRIPCION", ArgoConfiguracion.ConnectionString)
            daIsapres.Fill(Me, Tablas.RH_REM_ISAPRE)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_REM_ISAPRE))
            Return (dv)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function recuperaBancos() As DataView
        Try
            Dim daBancos As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_BANCO & " ORDER BY DESCRIPCION", ArgoConfiguracion.ConnectionString)
            daBancos.Fill(Me, Tablas.RH_PER_BANCO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_PER_BANCO))
            Return (dv)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function recuperaUbicacion() As DataView
        Try
            Dim daUbicacion As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_UBICACION_FISICA & " ORDER BY DESCRIPCION", ArgoConfiguracion.ConnectionString)
            daUbicacion.Fill(Me, Tablas.RH_PER_UBICACION_FISICA)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_PER_UBICACION_FISICA))
            Return (dv)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function recuperaCostoContable(ByVal Ano As Integer) As DataView
        Try
            Dim daCostoContable As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_REM_CENTRO_COSTO_CONTABLE & " WHERE ANO = " & Ano & " ORDER BY DESCRIPCION", ArgoConfiguracion.ConnectionString)
            daCostoContable.Fill(Me, Tablas.RH_REM_CENTRO_COSTO_CONTABLE)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_REM_CENTRO_COSTO_CONTABLE))
            Return (dv)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function recuperaCostoPresupuesto(ByVal Ano As Integer) As DataView
        Try
            Dim daCostoPresupuesto As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_REM_CENTRO_COSTO_PRESUPUESTO & " WHERE ANO = " & Ano & " ORDER BY DESCRIPCION", ArgoConfiguracion.ConnectionString)
            daCostoPresupuesto.Fill(Me, Tablas.RH_REM_CENTRO_COSTO_PRESUPUESTO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_REM_CENTRO_COSTO_PRESUPUESTO))
            Return (dv)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function recuperaRetiro() As DataView
        Try
            Dim daRetiro As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_MOTIVO_RETIRO & " ORDER BY DESCRIPCION", ArgoConfiguracion.ConnectionString)
            daRetiro.Fill(Me, Tablas.RH_PER_MOTIVO_RETIRO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_PER_MOTIVO_RETIRO))
            Return (dv)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function recuperaEstudios() As DataView
        Try
            Dim daEstudios As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_NIVEL_ESTUDIO & " ORDER BY DESCRIPCION", ArgoConfiguracion.ConnectionString)
            daEstudios.Fill(Me, Tablas.RH_PER_NIVEL_ESTUDIO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_PER_NIVEL_ESTUDIO))
            Return (dv)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function recuperaNivelEstudiosCurricular() As DataView
        Try
            Dim daEstudios As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_NIVEL_ESTUDIO & " WHERE APLICA_ANTECEDENTE_CURRICULAR = 1 ORDER BY DESCRIPCION", ArgoConfiguracion.ConnectionString)
            daEstudios.Fill(Me, Tablas.RH_PER_NIVEL_ESTUDIO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_PER_NIVEL_ESTUDIO))
            Return (dv)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function recuperaProfesionOficio() As DataView
        Try
            Dim daEstudios As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_PROFESION_OFICIO & " ORDER BY DESCRIPCION", ArgoConfiguracion.ConnectionString)
            daEstudios.Fill(Me, Tablas.RH_PER_PROFESION_OFICIO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_PER_PROFESION_OFICIO))
            Return (dv)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function recuperaProfesionOficio(ByVal nivelEstudioId As Integer) As DataView
        Try
            'Dim daEstudios As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_PROFESION_OFICIO & " WHERE NIVEL_ESTUDIO_ID = " + nivelEstudioId.ToString + " ORDER BY DESCRIPCION", ArgoConfiguracion.ConnectionString)
            'daEstudios.Fill(Me, Tablas.RH_PER_PROFESION_OFICIO)
            'Dim dv As DataView
            'Dim dvm As New DataViewManager(Me)
            'dv = dvm.CreateDataView(Me.Tables(Tablas.RH_PER_PROFESION_OFICIO))
            'Return (dv)

            '-------
            'Dim ds As DataSet
            'Dim cmdProceso, cmdSQL As String
            'cmdProceso = " AND TIPO_CALCULO" + "'" + TipoProceso + "'"

            'Dim daLiquidInactivas As New SqlDataAdapter("SELECT * FROM " & Vistas.VW_VALIDA_EMPLEADOS_INACTIVOS & " WHERE PERIODO_ID=" & idPeriodo & cmdSQL & " ORDER BY NOMBRE_COMPLETO_EMPLEADO", ArgoConfiguracion.ConnectionString)
            'ds = New DataSet(SQL.VISTAS.SELECT_EMPLEADOS_INACTIVOS_CON_LIQUIADCION)
            'daLiquidInactivas.Fill(ds, Vistas.VW_VALIDA_EMPLEADOS_INACTIVOS)
            'Dim dv As DataView
            'Dim dvm As New DataViewManager(ds)
            'dv = dvm.CreateDataView(ds.Tables(Vistas.VW_VALIDA_EMPLEADOS_INACTIVOS))
            'Return (dv)
            '-------

            Dim ds As DataSet
            Dim da As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_PROFESION_OFICIO & " WHERE NIVEL_ESTUDIO_ID = " + nivelEstudioId.ToString + " ORDER BY DESCRIPCION", ArgoConfiguracion.ConnectionString)
            ds = New DataSet(Tablas.RH_PER_PROFESION_OFICIO)
            da.Fill(ds, Tablas.RH_PER_PROFESION_OFICIO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Tablas.RH_PER_PROFESION_OFICIO))
            Return (dv)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function recuperaCarga() As DataView
        Try
            Dim daCarga As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_REM_TRAMO_ASIGNACION_FAMILIAR & " ORDER BY DESCRIPCION", ArgoConfiguracion.ConnectionString)
            daCarga.Fill(Me, Tablas.RH_REM_TRAMO_ASIGNACION_FAMILIAR)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_REM_TRAMO_ASIGNACION_FAMILIAR))
            Return (dv)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function recuperaAPV() As DataView
        Try
            Dim daEstudios As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_PROFESION_OFICIO & " ORDER BY DESCRIPCION", ArgoConfiguracion.ConnectionString)
            daEstudios.Fill(Me, Tablas.RH_PER_PROFESION_OFICIO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_PER_PROFESION_OFICIO))
            Return (dv)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function recuperaIpcAumulado() As DataView
        Try
            Dim da As New SqlDataAdapter("SELECT * FROM " & Tablas.GEN_IPC & " ORDER BY AÑO DESC, MES DESC", ArgoConfiguracion.ConnectionString)
            da.Fill(Me, Tablas.GEN_IPC)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.GEN_IPC))
            Return (dv)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function recuperaGrado(ByVal Ano As Integer) As DataView
        Try
            Dim daGrado As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_REM_GRADO & " ORDER BY ORDEN", ArgoConfiguracion.ConnectionString)
            daGrado.Fill(Me, Tablas.RH_REM_GRADO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_REM_GRADO))
            Return (dv)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function recuperaCalidad() As DataView
        Try
            Dim daCalidad As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_REM_CALIDAD_JURIDICA & " ORDER BY DESCRIPCION", ArgoConfiguracion.ConnectionString)
            daCalidad.Fill(Me, Tablas.RH_REM_CALIDAD_JURIDICA)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_REM_CALIDAD_JURIDICA))
            Return (dv)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function recuperaClasificacion() As DataView
        Try
            Dim daClasificacion As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_REM_CLASIFICACION_EMPLEADO & " ORDER BY DESCRIPCION", ArgoConfiguracion.ConnectionString)
            daClasificacion.Fill(Me, Tablas.RH_REM_CLASIFICACION_EMPLEADO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_REM_CLASIFICACION_EMPLEADO))
            Return (dv)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function recuperaDetalleAFP(ByVal ID_AFP As Integer) As DataView
        Try
            Dim daDetalleAFP As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_REM_AFP_DETALLE & "  where afp_id=" & ID_AFP & " ORDER BY AFP_ID", ArgoConfiguracion.ConnectionString)
            daDetalleAFP.Fill(Me, Tablas.RH_REM_AFP_DETALLE)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_REM_AFP_DETALLE))
            dv.RowFilter = "afp_id=" & ID_AFP
            Return (dv)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function recuperarEncabezado(ByVal ID_AFP As Integer) As DataRow

        Dim strSql As String

        Try

            strSql = "SELECT * FROM " & Tablas.RH_REM_AFP & " where AFP_ID=" & ID_AFP & " ORDER BY AFP_ID"

            ' If ID_AFP > 0 Then
            ' strSql = strSql & " AND AFP_ID = " & ID_AFP
            ' End If


            Dim da As New SqlDataAdapter(strSql, ArgoConfiguracion.ConnectionString)

            da.Fill(Me, Tablas.RH_REM_AFP)

            Dim EncabezadoAFP_DR As DataAccess.DSMantenedores.RH_REM_AFPRow

            EncabezadoAFP_DR = CType(RH_REM_AFP.Rows.Find(ID_AFP), DataAccess.DSMantenedores.RH_REM_AFPRow)

            Return EncabezadoAFP_DR
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function actualizarDatosDepto() As Boolean
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_DEPARTAMENTO)
        Try
            da.Update(Me, Tablas.RH_PER_DEPARTAMENTO)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function actualizarDatosIsapres() As Boolean
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_ISAPRES)
        Try
            da.Update(Me, Tablas.RH_REM_ISAPRE)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function actualizarDatosBancos() As Boolean
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_BANCOS)
        Try
            da.Update(Me, Tablas.RH_PER_BANCO)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function actualizarDatosUbicacion() As Boolean
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_UBICACION)
        Try
            da.Update(Me, Tablas.RH_PER_UBICACION_FISICA)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function actualizarDatosCostoContable() As Boolean
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_COSTOCONTABLE)
        Try
            da.Update(Me, Tablas.RH_REM_CENTRO_COSTO_CONTABLE)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function actualizarDatosCostoPresupuesto() As Boolean
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_COSTOPRESUPUESTO)
        Try
            da.Update(Me, Tablas.RH_REM_CENTRO_COSTO_PRESUPUESTO)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function actualizarDatosRetiros() As Boolean
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_RETIRO)
        Try
            da.Update(Me, Tablas.RH_PER_MOTIVO_RETIRO)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function actualizarDatosEstudios() As Boolean
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_ESTUDIOS)
        Try
            da.Update(Me, Tablas.RH_PER_NIVEL_ESTUDIO)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function actualizarDatosProfesionOficio(ByVal organizacionId As Integer, ByVal profesionOficioId As Integer, ByVal profesionAlias As Integer, ByVal nivelEstudioId As Integer, ByVal descripcion As String) As Boolean
        Dim SQLstr As String = "UPDATE RH_PER_PROFESION_OFICIO SET ORGANIZACION_ID=" + organizacionId.ToString + ", PROFESION_ALIAS=" + profesionAlias.ToString + ", NIVEL_ESTUDIO_ID=" + nivelEstudioId.ToString + ", DESCRIPCION='" + RTrim(UCase(descripcion)) + "' WHERE PROFESION_OFICIO_ID = " + profesionOficioId.ToString
        Try
            EjecutarQuery(SQLstr)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function insertarDatosProfesionOficio(ByVal organizacionId As Integer, ByVal profesionAlias As Integer, ByVal nivelEstudioId As Integer, ByVal descripcion As String) As Boolean
        Dim SQLstr As String = "INSERT INTO RH_PER_PROFESION_OFICIO (ORGANIZACION_ID , PROFESION_ALIAS, NIVEL_ESTUDIO_ID, DESCRIPCION) VALUES "
        SQLstr = SQLstr + "(" + organizacionId.ToString + ", " + profesionAlias.ToString + ", " + nivelEstudioId.ToString + ", '" + UCase(descripcion) + "')"
        Try
            EjecutarQuery(SQLstr)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function eliminarDatosProfesionOficio(ByVal profesionOficioId As Integer) As Boolean
        Dim SQLstr As String = "DELETE FROM  RH_PER_PROFESION_OFICIO WHERE PROFESION_OFICIO_ID = " + profesionOficioId.ToString
        Try
            EjecutarQuery(SQLstr)
        Catch ex As Exception
            Throw New Exception("Regisro no puede ser eliminado, aún existe relación hacia otras entidades")
        End Try
    End Function

    Public Function eliminarIpcAcumulado(ByVal IpcId As Integer) As Boolean
        Dim SQLstr As String = "DELETE FROM GEN_IPC WHERE IPC_ID = " + IpcId.ToString
        Try
            EjecutarQuery(SQLstr)
            Return True
        Catch ex As Exception
            Throw New Exception("Regisro no puede ser eliminado, aún existe relación hacia otras entidades")
            Return False
        End Try
    End Function

    Public Function ActualizarIpcAcumulado(ByVal IpcId As Integer, ByVal Año As Integer, ByVal Mes As Integer, Valor As Decimal) As Integer
        'Dim conn As SqlClient.SqlConnection
        'conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        'conn.Open()

        'Dim cmd As SqlClient.SqlCommand
        'Dim prm As SqlClient.SqlParameter
        'Dim id As Integer

        'cmd = New SqlClient.SqlCommand("EXEC " & SQL.STORE_PROCEDURES.ACTUALIZAR_IPC_ACUMULADO & " @IPC_ID, @AÑO, @MES, @VALOR, @IDENTITY")

        'prm = New SqlClient.SqlParameter
        'prm.ParameterName = "@IPC_ID"
        'prm.Direction = ParameterDirection.Input
        'prm.SqlDbType = SqlDbType.Int
        'prm.Value = IpcId
        'cmd.Parameters.Add(prm)

        'prm = New SqlClient.SqlParameter
        'prm.ParameterName = "@AÑO"
        'prm.Direction = ParameterDirection.Input
        'prm.SqlDbType = SqlDbType.Int
        'prm.Value = Año
        'cmd.Parameters.Add(prm)

        'prm = New SqlClient.SqlParameter
        'prm.ParameterName = "@MES"
        'prm.Direction = ParameterDirection.Input
        'prm.SqlDbType = SqlDbType.Int
        'prm.Value = Mes
        'cmd.Parameters.Add(prm)

        'prm = New SqlClient.SqlParameter
        'prm.ParameterName = "@VALOR"
        'prm.Direction = ParameterDirection.Input
        'prm.SqlDbType = SqlDbType.Decimal
        'prm.Precision = 18
        'prm.Scale = 5
        'prm.Value = Valor
        'cmd.Parameters.Add(prm)

        'prm = New SqlClient.SqlParameter
        'prm.ParameterName = "@IDENTITY"
        'prm.Direction = ParameterDirection.Output
        'prm.SqlDbType = SqlDbType.Int
        'cmd.Parameters.Add(prm)


        'cmd.Connection = conn
        'cmd.CommandType = CommandType.Text
        'Try
        '    cmd.ExecuteNonQuery()
        '    id = cmd.Parameters("@IDENTITY").Value()
        '    Return id
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        '    Debug.WriteLine(ex.Message)
        '    Return False
        'Finally
        '    cmd.Dispose()
        '    conn.Close()
        '    conn.Dispose()
        '    conn = Nothing
        '    cmd = Nothing
        'End Try



        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        Dim Id As Integer

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.ACTUALIZAR_IPC_ACUMULADO
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@IPC_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = IpcId
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@AÑO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = Año
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MES"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = Mes
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@VALOR"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Decimal
        prm.Precision = 18
        prm.Scale = 5
        prm.Value = Valor
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@IDENTITY"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.Int
        cmd.Parameters.Add(prm)

        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            Id = cmd.Parameters("@IDENTITY").Value()
            Return Id
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
    Public Function actualizarDatosCarga() As Boolean
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_CARGA)
        Try
            da.Update(Me, Tablas.RH_REM_TRAMO_ASIGNACION_FAMILIAR)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function actualizarDatosAPV() As Boolean
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_APV_MANT)
        Try
            da.Update(Me, Tablas.RH_REM_APV)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function actualizarDatosGrado() As Boolean
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_GRADO_MANT)
        Try
            da.Update(Me, Tablas.RH_REM_GRADO)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function actualizarDatosCalidad() As Boolean
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_CALIDAD_MANT)
        Try
            da.Update(Me, Tablas.RH_REM_CALIDAD_JURIDICA)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function actualizarDatosClasificacion() As Boolean
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_CLASIFICACION_MANT)
        Try
            da.Update(Me, Tablas.RH_REM_CLASIFICACION_EMPLEADO)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function actualizarDatosDetalleAFP() As Boolean
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_CLASIFICACION_DETALLE_AFP)
        Try
            da.Update(Me, Tablas.RH_REM_AFP_DETALLE)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Private Sub getCommands(ByRef da As SqlDataAdapter, ByVal strSQL As String)
        Dim cb As New SqlCommandBuilder(da)
        Try
            da.SelectCommand = New SqlCommand(strSQL)
            da.SelectCommand.Connection = conn
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(EX.Message)
        End Try
        Try
            da.InsertCommand = cb.GetInsertCommand
            da.InsertCommand.Connection = conn
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(EX.Message)
        End Try
        Try
            da.DeleteCommand = cb.GetDeleteCommand
            da.DeleteCommand.Connection = conn
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(EX.Message)
        End Try
        Try
            da.UpdateCommand = cb.GetUpdateCommand
            da.UpdateCommand.Connection = conn
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(EX.Message)
        End Try
        cb = Nothing
    End Sub
    Public Function recuperaDatosOrganizacion(ByVal organizacionID As Integer) As DataRow
        Try
            Dim da As New SqlDataAdapter("SELECT * FROM " & Tablas.GEN_ORGANIZACION & " WHERE ORGANIZACION_ID = " & organizacionID, ArgoConfiguracion.ConnectionString)
            da.Fill(Me, Tablas.GEN_ORGANIZACION)
            Dim dr As DataAccess.DSMantenedores.GEN_ORGANIZACIONRow
            dr = CType(GEN_ORGANIZACION.Rows.Find(organizacionID), DataAccess.DSMantenedores.GEN_ORGANIZACIONRow)
            Return dr
        Catch ex As Exception
            Return Nothing
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


    Public Function InsertarEncabezadoAFP(ByVal AFP As DataRow) As DataRow
        Dim daEncabezadoAFP As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ENCABEZADO_AFP, ArgoConfiguracion.ConnectionString)
        daEncabezadoAFP.Fill(Me, Tablas.RH_REM_AFP)
        daEncabezadoAFP.InsertCommand = Me.GetUpdateCmdAFPEncabezado()
        daEncabezadoAFP.InsertCommand.Parameters("@ORGANIZACION_ID").Value = AFP("ORGANIZACION_ID")
        daEncabezadoAFP.InsertCommand.Parameters("@DESCRIPCION").Value = AFP("DESCRIPCION")
        daEncabezadoAFP.InsertCommand.Parameters("@AFP_RUT").Value = AFP("AFP_RUT")
        daEncabezadoAFP.InsertCommand.Parameters("@AFP_DV").Value = AFP("AFP_DV")
        daEncabezadoAFP.InsertCommand.Parameters("@SISTEMA_PREV_ID").Value = AFP("SISTEMA_PREV_ID")
        daEncabezadoAFP.InsertCommand.Parameters("@DIRECCION").Value = AFP("DIRECCION")
        daEncabezadoAFP.InsertCommand.Parameters("@COMUNA_ID").Value = AFP("COMUNA_ID")
        daEncabezadoAFP.InsertCommand.Parameters("@CODIGO_EXCAJA").Value = AFP("CODIGO_EXCAJA")
        daEncabezadoAFP.InsertCommand.Parameters("@CODIGO_PREVIRED").Value = AFP("CODIGO_PREVIRED")

        Me.Tables(Tablas.RH_REM_AFP).Rows.Add(AFP)
        Try
            daEncabezadoAFP.Update(Me, Tablas.RH_REM_AFP)
            Return (AFP)
        Catch exSQL As SqlException
            Debug.WriteLine(exSQL.ToString)
            Throw New Exception(exSQL.Message)
        End Try
    End Function
    Public Function ActualizarEncabezadoAFP(ByVal afpDR As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ENCABEZADO_AFP, ArgoConfiguracion.ConnectionString)
        Me.Tables(Tablas.RH_REM_AFP).LoadDataRow(afpDR.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand(da)
        da.Update(Me, Tablas.RH_REM_AFP)
        Return (afpDR)
    End Function

    Private Function GetUpdateCommand(ByVal da As SqlDataAdapter) As SqlCommand
        Dim cb As New SqlCommandBuilder(da)
        Return (cb.GetUpdateCommand())
        cb = Nothing
    End Function
    Private Function GetUpdateCmdAFPEncabezado() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_AFP_ENCABEZADO

        sqlParam = New SqlClient.SqlParameter("@ORGANIZACION_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@DESCRIPCION", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@AFP_RUT", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@AFP_DV", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@SISTEMA_PREV_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@DIRECCION", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@COMUNA_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CODIGO_EXCAJA", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CODIGO_PREVIRED", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@Identity", SqlDbType.BigInt, 0, "AFP_ID")
        sqlParam.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(sqlParam)

        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout
        Return (sqlCmd)

    End Function

    Private Sub EjecutarQuery(ByVal sqlSTR As String)
        Dim objcommand As New SqlClient.SqlCommand(sqlSTR, New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString))
        Try
            objcommand.Connection.Open()
            objcommand.ExecuteNonQuery()
            objcommand.Connection.Close()
            objcommand.Dispose()
            objcommand = Nothing
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub
End Class
