Imports System.ComponentModel
Imports System.Data.SqlClient
Imports cl.presidencia.Argo.Comun

Public Class Cheques
    Inherits DSRegistroCheques

    Private dacHEQUE As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_EMISOR_CHEQUE, ArgoConfiguracion.ConnectionString)
    Dim connection As SqlConnection

    Public Sub New()
        MyBase.New()
        connection = New SqlConnection
        connection.ConnectionString = ArgoConfiguracion.ConnectionString
    End Sub

    Public Function Busca(ByVal ID As Long, ByVal NOMBRE_TABLA As String, ByVal SQL As String) As DataRow
        Dim da As New SqlDataAdapter(SQL, ArgoConfiguracion.ConnectionString)
        da.Fill(Me, NOMBRE_TABLA)
        Try
            Return Me.Tables(NOMBRE_TABLA).Rows.Find(ID)
        Catch excepcion As Exception
            Return Nothing
        End Try
    End Function

    Public Function Busca(ByVal NumeroCheque As Integer) As DataRow
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter("SELECT * FROM RH_PER_EMISOR_CHEQUE WHERE NUMERO_CHEQUE=" & CType(NumeroCheque, String), ArgoConfiguracion.ConnectionString)
        da.Fill(Me, "RH_PER_EMISOR_CHEQUE")
        Try
            Return Me.Tables("RH_PER_EMISOR_CHEQUE").Rows.Find(Busca("SELECT * FROM RH_PER_EMISOR_CHEQUE WHERE NUMERO_CHEQUE=" & CType(NumeroCheque, String), 0))
        Catch excepcion As Exception
            Return Nothing
        End Try
    End Function
    Public Function Busca(ByVal SQL As String, ByVal indiceColumnaID As Integer) As Integer
        Dim mySelectQuery As String = SQL
        Dim myConnection As New SqlConnection(ArgoConfiguracion.ConnectionString)
        Dim myCommand As New SqlCommand(mySelectQuery, myConnection)
        Dim valorID As Integer

        Try
            myConnection.Open()
            Dim myReader As SqlDataReader
            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                valorID = myReader.GetValue(indiceColumnaID)
            End While
            myReader.Close()
            myConnection.Close()
            Return valorID
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function InsertarEncabezado(ByVal dr As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_EMISOR_CHEQUE, ArgoConfiguracion.ConnectionString)
        da.Fill(Me, Tablas.RH_PER_EMISOR_CHEQUE)
        da.InsertCommand = Me.GetUpdateCmdEncabezado()
        da.InsertCommand.Parameters("@MOTIVO").Value = dr("MOTIVO")
        da.InsertCommand.Parameters("@NOMBRE_RAZON_SOCIAL").Value = dr("NOMBRE_RAZON_SOCIAL")
        da.InsertCommand.Parameters("@NUMERO_CHEQUE").Value = dr("NUMERO_CHEQUE")
        da.InsertCommand.Parameters("@FECHA_CHEQUE").Value = dr("FECHA_CHEQUE")
        da.InsertCommand.Parameters("@NUMERO_EGRESO").Value = dr("NUMERO_EGRESO")
        da.InsertCommand.Parameters("@ESTADO_REGISTRO").Value = dr("ESTADO_REGISTRO")
        da.InsertCommand.Parameters("@PERIODO_ID").Value = dr("PERIODO_ID")
        da.InsertCommand.Parameters("@ORGANIZACION_ID").Value = dr("ORGANIZACION_ID")
        da.InsertCommand.Parameters("@TOTAL_CHEQUE").Value = dr("TOTAL_CHEQUE")
        Me.Tables(Tablas.RH_PER_EMISOR_CHEQUE).Rows.Add(dr)
        Try
            da.Update(Me, Tablas.RH_PER_EMISOR_CHEQUE)
            Return (dr)
        Catch exSQL As SqlException
            Debug.WriteLine(exSQL.ToString)
            Throw New Exception(exSQL.Message)
        End Try
    End Function

    Public Function InsertarDetalle(ByVal dr As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_EMISOR_CHEQUE_DETALLE, ArgoConfiguracion.ConnectionString)
        da.Fill(Me, Tablas.RH_PER_EMISOR_CHEQUE_DETALLE)
        da.InsertCommand = Me.GetUpdateCmdDetalle()
        da.InsertCommand.Parameters("@EMISOR_CHEQUE_ID").Value = dr("EMISOR_CHEQUE_ID")
        da.InsertCommand.Parameters("@CONCEPTO").Value = dr("CONCEPTO")
        da.InsertCommand.Parameters("@MONTO").Value = dr("MONTO")
        Me.Tables(Tablas.RH_PER_EMISOR_CHEQUE_DETALLE).Rows.Add(dr)
        Try
            da.Update(Me, Tablas.RH_PER_EMISOR_CHEQUE_DETALLE)
            Return (dr)
        Catch exSQL As SqlException
            Debug.WriteLine(exSQL.ToString)
            Throw New Exception(exSQL.Message)
        End Try
    End Function

    Private Function GetUpdateCmdEncabezado() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_REGISTRO_CHEQUE_ENCABEZADO

        sqlParam = New SqlClient.SqlParameter("@MOTIVO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NOMBRE_RAZON_SOCIAL", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NUMERO_CHEQUE", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_CHEQUE", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NUMERO_EGRESO", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ESTADO_REGISTRO", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PERIODO_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ORGANIZACION_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@TOTAL_CHEQUE", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@Identity", SqlDbType.BigInt, 0, "EMISOR_CHEQUE_ID")
        sqlParam.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(sqlParam)

        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout
        Return (sqlCmd)
    End Function

    Private Function GetUpdateCmdDetalle() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_REGISTRO_CHEQUE_DETALLE

        sqlParam = New SqlClient.SqlParameter("@EMISOR_CHEQUE_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CONCEPTO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@Identity", SqlDbType.BigInt, 0, "DETALLE_EMISOR_CHEQUE_ID")
        sqlParam.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(sqlParam)

        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout
        Return (sqlCmd)
    End Function

    Public Function ActualizarEncabezado(ByVal dr As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_EMISOR_CHEQUE_ENCABEZADO, ArgoConfiguracion.ConnectionString)
        Me.Tables(Tablas.RH_PER_EMISOR_CHEQUE).LoadDataRow(dr.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand(da)
        da.Update(Me, Tablas.RH_PER_EMISOR_CHEQUE)
        Return (dr)
    End Function

    Public Function Actualizardetalle(ByVal dr As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_EMISOR_CHEQUE_DETALLE, ArgoConfiguracion.ConnectionString)
        Me.Tables(Tablas.RH_PER_EMISOR_CHEQUE_DETALLE).LoadDataRow(dr.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand(da)
        da.Update(Me, Tablas.RH_PER_EMISOR_CHEQUE_DETALLE)
        Return (dr)
    End Function
    Private Function GetUpdateCommand(ByVal da As SqlDataAdapter) As SqlCommand
        Dim cb As New SqlCommandBuilder(da)
        Return (cb.GetUpdateCommand())
        cb = Nothing
    End Function

    Public Function eliminaEncabezado(ByVal idCheque As Integer) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        Dim mensaje As String = ""

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.ELIMINA_ENCABEZADO_REGISTRO_CHEQUE
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMISOR_CHEQUE_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idCheque
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

    Public Function eliminaDetalle(ByVal idDetalleCheque As Integer) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        Dim mensaje As String = ""

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.ELIMINA_DETALLE_REGISTRO_CHEQUE
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@DETALLE_EMISOR_CHEQUE_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idDetalleCheque
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

    Public Function recuperarDetalleCheque(ByVal IDCheque As Long) As DataView
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_EMISOR_CHEQUE_DETALLE & " WHERE EMISOR_CHEQUE_ID=" & IDCheque, ArgoConfiguracion.ConnectionString)
            da.Fill(ds, Tablas.RH_PER_EMISOR_CHEQUE_DETALLE)
            Dim dv As New DataView
            dv = New DataView(ds.Tables(Tablas.RH_PER_EMISOR_CHEQUE_DETALLE), "", "", DataViewRowState.OriginalRows)
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperarChequesAEmitir(ByVal numeroFolio As Integer) As DataView
        Try
            Dim ds As New DataSet
            Dim da As SqlDataAdapter
            If numeroFolio = 0 Then
                'da = New SqlDataAdapter("SELECT * FROM " & Vistas.VW_REGISTRO_CHEQUES_A_EMITIR & " WHERE ESTADO_REGISTRO=1 ORDER BY NOMBRE_RAZON_SOCIAL, FECHA_CHEQUE", ArgoConfiguracion.ConnectionString)
                da = New SqlDataAdapter("SELECT * FROM " & Vistas.VW_REGISTRO_CHEQUES_A_EMITIR & " WHERE ESTADO_REGISTRO=1 ORDER BY EMISOR_CHEQUE_ID", ArgoConfiguracion.ConnectionString)
            Else
                da = New SqlDataAdapter("SELECT * FROM " & Vistas.VW_REGISTRO_CHEQUES_A_EMITIR & " WHERE ESTADO_REGISTRO=1 AND EMISOR_CHEQUE_ID=" & CType(numeroFolio, String) & " ORDER BY NOMBRE_RAZON_SOCIAL, FECHA_CHEQUE", ArgoConfiguracion.ConnectionString)
            End If
            da.Fill(ds, Vistas.VW_REGISTRO_CHEQUES_A_EMITIR)
            Dim dv As New DataView
            dv = New DataView(ds.Tables(Vistas.VW_REGISTRO_CHEQUES_A_EMITIR), "", "", DataViewRowState.OriginalRows)
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function buscarNumeroCheque(ByVal numeroCheque As Integer) As String
        Dim mySelectQuery As String = "SELECT 'Cheque: ' + CONVERT(VARCHAR(10), NUMERO_CHEQUE) + " & _
                        "' de fecha ' + CONVERT(VARCHAR(10), FECHA_CHEQUE, 103) + " & _
                        "' corresponde a ' + ORIGEN AS MENSAJE " & _
                        " FROM VW_CHEQUE WHERE NUMERO_CHEQUE = " & CType(numeroCheque, String)

        Dim myConnection As New SqlConnection(ArgoConfiguracion.ConnectionString)
        Dim myCommand As New SqlCommand(mySelectQuery, myConnection)
        Dim mensaje As String = ""

        Try
            myConnection.Open()
            Dim myReader As SqlDataReader
            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                mensaje = myReader.GetValue(0)
            End While
            myReader.Close()
            myConnection.Close()
            Return mensaje
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
