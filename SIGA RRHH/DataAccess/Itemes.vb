Imports System.Data.SqlClient
Imports cl.presidencia.Argo.Comun

Public Class Itemes
    Inherits DSParametroMensual

    Private daItem As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_REM_ITEM, ArgoConfiguracion.ConnectionString)
    Private connection As SqlConnection

    Public Sub New()
        MyBase.New()
        connection = New SqlConnection
        connection.ConnectionString = ArgoConfiguracion.ConnectionString
    End Sub
    Protected Overrides Sub Finalize()
        daItem = Nothing
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        connection = Nothing
        MyBase.Finalize()
    End Sub
    Public Function Busca(ByVal SQL As String) As Integer
        Dim mySelectQuery As String = SQL
        Dim myConnection As New SqlConnection(connection.ConnectionString)
        Dim myCommand As New SqlCommand(mySelectQuery, myConnection)
        Dim valorID As Integer

        Try
            myConnection.Open()
            Dim myReader As SqlDataReader
            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                'Lee identificador de Item (ITEM_ID)
                valorID = myReader.GetValue(0)
            End While
            myReader.Close()
            myConnection.Close()
            Return valorID
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
    Public Function recuperaRegistroItem(ByVal ID_Item As Long) As DataRow
        Dim valorID As Integer
        valorID = Busca("SELECT ITEM_ID FROM " & Tablas.RH_REM_ITEM & " WHERE ITEM_ID = " & ID_Item)

        Try
            Dim daItem As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_REM_ITEM & " WHERE ITEM_ID = " & ID_Item, ArgoConfiguracion.ConnectionString)
            daItem.Fill(Me, Tablas.RH_REM_ITEM)

            Dim ItemDR As DataAccess.ParametrosMensuales.RH_REM_ITEMRow
            ItemDR = CType(RH_REM_ITEM.Rows.Find(valorID), DataAccess.ParametrosMensuales.RH_REM_ITEMRow)

            Return ItemDR
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperarItemes() As DataView
        Try
            daItem.Fill(Me, Tablas.RH_REM_ITEM)
            Dim ds As DataSet
            Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ITEM, ArgoConfiguracion.ConnectionString)
            ds = New DataSet(SQL.INSTRUCCIONES_SQL.SELECT_ITEM)
            da.Fill(ds, Tablas.RH_REM_ITEM)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Tablas.RH_REM_ITEM))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperaItemsRelacionado() As DataView
        Try
            Dim ds As DataSet = New DataSet("SELECT * FROM VW_ITEM_RELACIONADO ORDER BY DESCRIPCION_LARGA")
            Using da As New SqlDataAdapter("SELECT * FROM VW_ITEM_RELACIONADO ORDER BY DESCRIPCION_LARGA", ArgoConfiguracion.ConnectionString)
                da.Fill(ds, "VW_ITEM_RELACIONADO")
            End Using
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables("VW_ITEM_RELACIONADO"))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperaItemsTramosRelacionado(RelacionCabeceraId As Integer, PeriodoId As Integer) As DataView
        Try
            Dim cmdSQL As String = "SELECT * FROM RH_REM_ITEM_RELACIONADO_TRAMOS WHERE RELACION_CABECERA_ID = " + RelacionCabeceraId.ToString + " AND PERIODO_ID = " + PeriodoId.ToString + " ORDER BY RELACION_TRAMO_ID"
            Dim ds As DataSet = New DataSet(cmdSQL)
            Using da As New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
                da.Fill(ds, "RH_REM_ITEM_RELACIONADO_TRAMOS")
            End Using
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables("RH_REM_ITEM_RELACIONADO_TRAMOS"))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperaMontosAsignadosSegunTramos(RelacionCabeceraId As Integer, PeriodoId As Integer) As DataView
        Try
            Dim cmdSQL As String = "SELECT * FROM RH_REM_ITEM_RELACIONADO_MOVIMIENTO_EMPLEADO WHERE RELACION_CABECERA_ID = " + RelacionCabeceraId.ToString + " AND PERIODO_ID = " + PeriodoId.ToString
            Dim ds As DataSet = New DataSet(cmdSQL)
            Using da As New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
                da.Fill(ds, "RH_REM_ITEM_RELACIONADO_MOVIMIENTO_EMPLEADO")
            End Using
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables("RH_REM_ITEM_RELACIONADO_MOVIMIENTO_EMPLEADO"))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperarItemesCentralizacion(ByVal itemID As Integer, ByVal periodoId As Integer) As DataView
        Try
            Dim da As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_REM_CENTRALIZACION & " WHERE ITEM_ID=" & itemID & " AND PERIODO_ID=" & periodoId & " AND ESTADO_REGISTRO=1", ArgoConfiguracion.ConnectionString)
            da.Fill(Me, Tablas.RH_REM_CENTRALIZACION)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_REM_CENTRALIZACION))
            dv.RowFilter = "ITEM_ID=" & itemID & " AND PERIODO_ID=" & periodoId
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function actualizaItemesCentralizacion() As Boolean
        Dim da As New SqlDataAdapter
        getCommands(da, "SELECT * FROM RH_REM_CENTRALIZACION")
        Try
            da.Update(Me, Tablas.RH_REM_CENTRALIZACION)
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function
    Public Function Insertar(ByVal Item As DataRow) As DataRow
        Dim daItem As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ITEM, ArgoConfiguracion.ConnectionString)
        daItem.Fill(Me, Tablas.RH_REM_ITEM)
        daItem.InsertCommand = Me.GetUpdateCmdItem()
        daItem.InsertCommand.Parameters("@ORGANIZACION_ID").Value = Item("ORGANIZACION_ID")
        daItem.InsertCommand.Parameters("@TIPO_ITEM").Value = Item("TIPO_ITEM")
        daItem.InsertCommand.Parameters("@ESTADO_REGISTRO").Value = Item("ESTADO_REGISTRO")
        daItem.InsertCommand.Parameters("@ITEM_ALIAS").Value = Item("ITEM_ALIAS")
        daItem.InsertCommand.Parameters("@DESCRIPCION_LARGA").Value = Item("DESCRIPCION_LARGA")
        daItem.InsertCommand.Parameters("@DESCRIPCION_CORTA").Value = Item("DESCRIPCION_CORTA")
        daItem.InsertCommand.Parameters("@ES_IMPONIBLE").Value = Item("ES_IMPONIBLE")
        daItem.InsertCommand.Parameters("@ES_TRIBUTABLE").Value = Item("ES_TRIBUTABLE")
        daItem.InsertCommand.Parameters("@ES_CALCULABLE").Value = Item("ES_CALCULABLE")
        daItem.InsertCommand.Parameters("@ES_COSTO").Value = Item("ES_COSTO")
        daItem.InsertCommand.Parameters("@SECUENCIA_IMPRESION").Value = Item("SECUENCIA_IMPRESION")
        daItem.InsertCommand.Parameters("@COLUMNA_LIBRO_AUDITORIA_1").Value = Item("COLUMNA_LIBRO_AUDITORIA_1")
        daItem.InsertCommand.Parameters("@COLUMNA_LIBRO_AUDITORIA_2").Value = Item("COLUMNA_LIBRO_AUDITORIA_2")
        daItem.InsertCommand.Parameters("@COLUMNA_LIBRO_OFICIAL").Value = Item("COLUMNA_LIBRO_OFICIAL")
        daItem.InsertCommand.Parameters("@ES_PERMANENTE").Value = Item("ES_PERMANENTE")
        daItem.InsertCommand.Parameters("@ES_IMPRIMIBLE_EN_LIQUIDACION").Value = Item("ES_IMPRIMIBLE_EN_LIQUIDACION")
        daItem.InsertCommand.Parameters("@ES_ITEM_BIENESTAR").Value = Item("ES_ITEM_BIENESTAR")
        daItem.InsertCommand.Parameters("@ES_PROPORCIONAL_DIAS_TRABAJADOS").Value = Item("ES_PROPORCIONAL_DIAS_TRABAJADOS")
        daItem.InsertCommand.Parameters("@ES_RELIQUIDACION_BONO").Value = Item("ES_RELIQUIDACION_BONO")
        daItem.InsertCommand.Parameters("@ES_IMPONIBLE_MES_HISTORICO").Value = Item("ES_IMPONIBLE_MES_HISTORICO")
        daItem.InsertCommand.Parameters("@ES_TRIBUTABLE_MES_HISTORICO").Value = Item("ES_TRIBUTABLE_MES_HISTORICO")
        daItem.InsertCommand.Parameters("@TRASPASA_DIFERENCIA_MOVTO_MENSUAL").Value = Item("TRASPASA_DIFERENCIA_MOVTO_MENSUAL")
        daItem.InsertCommand.Parameters("@CODIGO_EXTERNO").Value = Item("CODIGO_EXTERNO")
        daItem.InsertCommand.Parameters("@CODIGO_APLICACION").Value = Item("CODIGO_APLICACION")
        daItem.InsertCommand.Parameters("@APLICACION").Value = Item("APLICACION")
        daItem.InsertCommand.Parameters("@CELDA_CALCULO").Value = Item("CELDA_CALCULO")
        daItem.InsertCommand.Parameters("@ES_ATRASO_INASISTENCIA").Value = Item("ES_ATRASO_INASISTENCIA")
        daItem.InsertCommand.Parameters("@ES_APLICABLE_HONORARIO").Value = Item("ES_APLICABLE_HONORARIO")
        daItem.InsertCommand.Parameters("@ES_COSTO_PRESUP").Value = Item("ES_COSTO_PRESUP")
        daItem.InsertCommand.Parameters("@PERMITE_GENERACION_MASIVA").Value = Item("PERMITE_GENERACION_MASIVA")

        Me.Tables(Tablas.RH_REM_ITEM).Rows.Add(Item)
        Try
            daItem.Update(Me, Tablas.RH_REM_ITEM)
            Return (Item)
        Catch exSQL As SqlException
            Debug.WriteLine(exSQL.ToString)
            Throw New Exception(exSQL.Message)
            'Se destruye el objeto DataAdapter
        End Try
    End Function

    Public Function Actualizar(ByVal ItemDR As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ITEM, ArgoConfiguracion.ConnectionString)
        Try
            Me.Tables(Tablas.RH_REM_ITEM).LoadDataRow(ItemDR.ItemArray, False)
            da.UpdateCommand = Me.GetUpdateCommand(da)
            da.Update(Me, Tablas.RH_REM_ITEM)
            Return (ItemDR)
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub Elimina(ByVal myExecuteQuery As String)
        Dim myConnection As New SqlConnection
        myConnection.ConnectionString = ArgoConfiguracion.ConnectionString
        Dim myCommand As New SqlCommand(myExecuteQuery, myConnection)
        myCommand.Connection.Open()
        myCommand.ExecuteNonQuery()
        myConnection.Close()
    End Sub
    Private Function GetUpdateCommand(ByVal da As SqlDataAdapter) As SqlCommand
        Dim cb As New SqlCommandBuilder(da)
        Return (cb.GetUpdateCommand())
        cb = Nothing
    End Function
    Private Function GetUpdateCmdItem() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_DEFINICION_ITEM

        sqlParam = New SqlClient.SqlParameter("@ORGANIZACION_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@TIPO_ITEM", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ESTADO_REGISTRO", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ITEM_ALIAS", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@DESCRIPCION_LARGA", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@DESCRIPCION_CORTA", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ES_IMPONIBLE", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ES_TRIBUTABLE", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ES_CALCULABLE", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ES_COSTO", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        'sqlParam = New SqlClient.SqlParameter("@ES_CUENTA_CONTABLE_FINANZAS", SqlDbType.Bit)
        'sqlCmd.Parameters.Add(sqlParam)

        'sqlParam = New SqlClient.SqlParameter("@ES_CUENTA_CONTABLE_PRESUPUESTO", SqlDbType.Bit)
        'sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@SECUENCIA_IMPRESION", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        'sqlParam = New SqlClient.SqlParameter("@ITEM_ASOCIADO", SqlDbType.Int)
        'sqlCmd.Parameters.Add(sqlParam)

        'sqlParam = New SqlClient.SqlParameter("@GLOSA", SqlDbType.VarChar)
        'sqlCmd.Parameters.Add(sqlParam)

        'sqlParam = New SqlClient.SqlParameter("@CUENTA_CONTABLE_FINANZAS", SqlDbType.VarChar)
        'sqlCmd.Parameters.Add(sqlParam)

        'sqlParam = New SqlClient.SqlParameter("@CUENTA_CONTABLE_PRESUPUESTO", SqlDbType.VarChar)
        'sqlCmd.Parameters.Add(sqlParam)

        'sqlParam = New SqlClient.SqlParameter("@IMPUTACION", SqlDbType.Bit)
        'sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@COLUMNA_LIBRO_AUDITORIA_1", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@COLUMNA_LIBRO_AUDITORIA_2", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@COLUMNA_LIBRO_OFICIAL", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ES_PERMANENTE", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ES_IMPRIMIBLE_EN_LIQUIDACION", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ES_ITEM_BIENESTAR", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ES_PROPORCIONAL_DIAS_TRABAJADOS", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ES_RELIQUIDACION_BONO", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ES_IMPONIBLE_MES_HISTORICO", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ES_TRIBUTABLE_MES_HISTORICO", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@TRASPASA_DIFERENCIA_MOVTO_MENSUAL", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CODIGO_EXTERNO", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CODIGO_APLICACION", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@APLICACION", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CELDA_CALCULO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ES_ATRASO_INASISTENCIA", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ES_APLICABLE_HONORARIO", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ES_COSTO_PRESUP", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PERMITE_GENERACION_MASIVA", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@Identity", SqlDbType.BigInt, 0, "ITEM_ID")
        sqlParam.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(sqlParam)

        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout
        Return (sqlCmd)
    End Function
    Private Sub getCommands(ByRef da As SqlDataAdapter, ByVal strSQL As String)
        Dim cb As New SqlCommandBuilder(da)
        Try
            da.SelectCommand = New SqlCommand(strSQL)
            da.SelectCommand.Connection = connection
        Catch ex As Exception
            Debug.WriteLine(EX.Message)
        End Try
        Try
            da.InsertCommand = cb.GetInsertCommand
            da.InsertCommand.Connection = connection
        Catch ex As Exception
            Debug.WriteLine(EX.Message)
        End Try
        Try
            da.DeleteCommand = cb.GetDeleteCommand
            da.DeleteCommand.Connection = connection
        Catch ex As Exception
            Debug.WriteLine(EX.Message)
        End Try
        Try
            da.UpdateCommand = cb.GetUpdateCommand
            da.UpdateCommand.Connection = connection
        Catch ex As Exception
            Debug.WriteLine(EX.Message)
        End Try
        cb = Nothing
    End Sub

    Public Function ActualizarItemTramos(ByVal idRelacionCabecera As Integer, idPeriodo As Integer, NombreTramo As String, MontoDesde As Integer, MontoHasta As Integer, MontoAsignado As Integer, iDRelacionTramo As Integer) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand("EXEC sp_actualizarTramosItemGenerado " & "@RELACION_CABECERA_ID, @PERIODO_ID, @NOMBRE_TRAMO, @MONTO_DESDE, @MONTO_HASTA, @MONTO_PARA_ASIGNAR, @RELACION_TRAMO_ID")

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@RELACION_CABECERA_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idRelacionCabecera
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idPeriodo
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@NOMBRE_TRAMO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = NombreTramo
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MONTO_DESDE"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = MontoDesde
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MONTO_HASTA"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = MontoHasta
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MONTO_PARA_ASIGNAR"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = MontoAsignado
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@RELACION_TRAMO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = iDRelacionTramo
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

    Public Function ActualizarItemEndeudamiento(ByVal ItemId As Integer, ByVal TipoEndeudamientoId As Integer, ByVal Vigente As Boolean) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand("EXEC " & SQL.STORE_PROCEDURES.INSERTA_ITEM_ENDEUDAMIENTO & " @ITEM_ID, @TIPO_ITEM_ENDEUDAMIENTO_ID, @VIGENTE")

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ITEM_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = ItemId
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_ITEM_ENDEUDAMIENTO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = TipoEndeudamientoId
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@VIGENTE"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Bit
        prm.Value = Vigente
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


    Public Function recuperarDetalleItemEndeudamiento() As DataView
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter("SELECT * FROM " & Vistas.VW_ITEM_ENDEUDAMIENTO & " WHERE VIGENTE = 1 ORDER BY TIPO_ITEM_ENDEUDAMIENTO_ID, DESCRIPCION_ITEM", ArgoConfiguracion.ConnectionString)
            da.Fill(ds, Vistas.VW_ITEM_ENDEUDAMIENTO)
            Dim dv As New DataView
            dv = New DataView(ds.Tables(0), "", "", DataViewRowState.OriginalRows)
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class

