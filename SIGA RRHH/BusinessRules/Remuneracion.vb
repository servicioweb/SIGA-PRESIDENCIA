Imports cl.presidencia.Argo.Comun.Funciones

Public Class Remuneracion
    Private Const diasTrabajadosLEGAL As Integer = 30
    Private Const topeImponible60 As Integer = 60 'Unidades de Fomento
    Private Const topeImponible90 As Integer = 90 'Unidades de Fomento
    Private Const factorAtraso As Integer = 190
    Private Const factorInasistenciaMedioDia As Integer = 60
    Private Const factorInasistenciaDiaEntero As Integer = 30
    Private Shared valorUF As Double

    'Cálculo sueldo base
    Private Shared Function calculoProporcionDiasTrabajados(ByVal variable As Integer, ByVal diasTrabajados As Integer) As Integer
        If diasTrabajados < diasTrabajadosLEGAL Then
            variable = Math.Round(((variable / diasTrabajadosLEGAL) * diasTrabajados), 0)
        End If
        Return variable
    End Function

    Private Shared Function IniCalculoRegLiquidacion(ByVal idEmpleado As Integer, ByVal idPeriodo As Integer, ByVal tipoCalculo As String) As Integer
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        'Ejecución de limpieza de registros

        Try
            eliminaProcesoEmpleado(idEmpleado, idPeriodo, tipoCalculo)
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

        Try
            'Creacion Nuevo Encabezado
            If tipoCalculo = Comun.TipoProceso.SUPLEMENTARIA_HONORARIOS Then
                cmd = New SqlClient.SqlCommand("INSERT INTO RH_REM_LIQUIDACION_ENC_SUPLEMENTARIA (EMPLEADO_ID, PERIODO_ID, TIPO_CALCULO) values (@EMPLEADO_ID, @PERIODO_ID, @TIPO_CALCULO); SELECT @@IDENTITY")
            Else
                cmd = New SqlClient.SqlCommand("INSERT INTO RH_REM_LIQUIDACION_ENC (EMPLEADO_ID, PERIODO_ID, TIPO_CALCULO) values (@EMPLEADO_ID, @PERIODO_ID, @TIPO_CALCULO); SELECT @@IDENTITY")
            End If
            cmd.Connection = conn
            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@EMPLEADO_ID"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.Int
            prm.Value = idEmpleado
            cmd.Parameters.Add(prm)

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@PERIODO_ID"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.Int
            prm.Value = idPeriodo
            cmd.Parameters.Add(prm)

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@TIPO_CALCULO"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.VarChar
            prm.Value = tipoCalculo
            cmd.Parameters.Add(prm)

            Dim idLiquidacion As Integer = cmd.ExecuteScalar()

            Return idLiquidacion
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            conn.Close()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function

    Private Shared Function IniCalculoRegLiquidacionBono(ByVal idEmpleado As Integer, ByVal idPeriodo As Integer, ByVal tipoCalculo As String) As Integer
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        'Ejecución de limpieza de registros

        cmd = New SqlClient.SqlCommand("DELETE FROM RH_REM_LIQUIDACION_BONO WHERE EMPLEADO_ID=@EMPLEADO_ID AND TIPO_CALCULO=@TIPO_CALCULO AND PERIODO_ID=@PERIODO_ID; DELETE FROM RH_REM_LIQUIDACION_ENC_BONO WHERE EMPLEADO_ID=@EMPLEADO_ID AND TIPO_CALCULO=@TIPO_CALCULO AND PERIODO_ID=@PERIODO_ID")

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idEmpleado
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idPeriodo
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_CALCULO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = tipoCalculo
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

        Try
            'Creacion Nuevo Encabezado
            cmd = New SqlClient.SqlCommand("INSERT INTO RH_REM_LIQUIDACION_ENC_BONO (EMPLEADO_ID, PERIODO_ID, TIPO_CALCULO) values (@EMPLEADO_ID, @PERIODO_ID, @TIPO_CALCULO); SELECT @@IDENTITY")
            cmd.Connection = conn
            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@EMPLEADO_ID"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.Int
            prm.Value = idEmpleado
            cmd.Parameters.Add(prm)

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@PERIODO_ID"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.Int
            prm.Value = idPeriodo
            cmd.Parameters.Add(prm)

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@TIPO_CALCULO"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.VarChar
            prm.Value = tipoCalculo
            cmd.Parameters.Add(prm)

            Dim idLiquidacion As Integer = cmd.ExecuteScalar()

            Return idLiquidacion
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            conn.Close()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function
    Private Shared Sub actualizaTotal(ByVal liquidacionID_ENC As Integer, ByVal nombreCampoTotal As String, ByVal monto As Integer, ByVal tipoCalculo As String)
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        'Ejecución de registro de ítems de liquidación de sueldo
        If tipoCalculo = Comun.TipoProceso.SUPLEMENTARIA_HONORARIOS Then
            cmd = New SqlClient.SqlCommand("UPDATE RH_REM_LIQUIDACION_ENC_SUPLEMENTARIA SET " & nombreCampoTotal & "=@MONTO, TIPO_CALCULO=@TIPO_CALCULO WHERE ID_LIQUIDACION_ENC=@ID_LIQUIDACION_ENC")
        Else
            cmd = New SqlClient.SqlCommand("UPDATE RH_REM_LIQUIDACION_ENC SET " & nombreCampoTotal & "=@MONTO, TIPO_CALCULO=@TIPO_CALCULO WHERE ID_LIQUIDACION_ENC=@ID_LIQUIDACION_ENC")
        End If
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ID_LIQUIDACION_ENC"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = liquidacionID_ENC
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MONTO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = monto
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_CALCULO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = tipoCalculo
        cmd.Parameters.Add(prm)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Sub
    Private Shared Sub actualizaTotalBonos(ByVal liquidacionID_ENC As Integer, ByVal nombreCampoTotal As String, ByVal monto As Integer, ByVal tipoCalculo As String)
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        'Ejecución de registro de ítems de liquidación de sueldo
        cmd = New SqlClient.SqlCommand("UPDATE RH_REM_LIQUIDACION_ENC_BONO SET " & nombreCampoTotal & "=@MONTO, TIPO_CALCULO=@TIPO_CALCULO WHERE ID_LIQUIDACION_ENC=@ID_LIQUIDACION_ENC")
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ID_LIQUIDACION_ENC"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = liquidacionID_ENC
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MONTO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = monto
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_CALCULO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = tipoCalculo
        cmd.Parameters.Add(prm)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Sub

    Private Shared Sub insertaLiquidacion(ByVal liquidacionID_ENC As Integer, ByVal idEmpleado As Integer, ByVal periodo As Periodo, ByVal idItem As Integer, ByVal tipoItem As Comun.TiposDeDatos.TipoItem, ByVal horasExtras As Decimal, ByVal monto As Integer, ByVal descripcion As String, ByVal idAPV As Integer, ByVal tipoCalculo As String, Optional ByVal NO_CERO As Boolean = False)
        If NO_CERO Then
            If monto = 0 Then
                Exit Sub
            End If
        End If
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        'Ejecución de registro de ítems de liquidación de sueldo
        If tipoCalculo = Comun.TipoProceso.SUPLEMENTARIA_HONORARIOS Then
            cmd = New SqlClient.SqlCommand("INSERT INTO RH_REM_LIQUIDACION_SUPLEMENTARIA (ID_LIQUIDACION_ENC,EMPLEADO_ID, PERIODO_ID, ITEM_ID, TIPO_ITEM, NUMERO_HORAS_EXTRAS, TIPO_CALCULO, MONTO, DESCRIPCION, APV_ID ) values (@ID_LIQUIDACION_ENC,@EMPLEADO_ID, @PERIODO_ID, @ITEM_ID, @TIPO_ITEM, @NUMERO_HORAS_EXTRAS, @TIPO_CALCULO, @MONTO, @DESCRIPCION, @APV_ID )")
        Else
            cmd = New SqlClient.SqlCommand("INSERT INTO RH_REM_LIQUIDACION (ID_LIQUIDACION_ENC,EMPLEADO_ID, PERIODO_ID, ITEM_ID, TIPO_ITEM, NUMERO_HORAS_EXTRAS, TIPO_CALCULO, MONTO, DESCRIPCION, APV_ID ) values (@ID_LIQUIDACION_ENC,@EMPLEADO_ID, @PERIODO_ID, @ITEM_ID, @TIPO_ITEM, @NUMERO_HORAS_EXTRAS, @TIPO_CALCULO, @MONTO, @DESCRIPCION, @APV_ID )")
        End If

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ID_LIQUIDACION_ENC"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = liquidacionID_ENC
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idEmpleado
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = periodo.ID
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ITEM_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idItem
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_ITEM"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = tipoItem
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@NUMERO_HORAS_EXTRAS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Decimal
        prm.Precision = 6
        prm.Scale = 1
        prm.Value = horasExtras
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_CALCULO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = tipoCalculo
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MONTO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = monto
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@DESCRIPCION"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = descripcion
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@APV_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idAPV
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Sub

    Private Shared Sub copiarLiquidacionNormalASuplementaria(ByVal idEmpleado As Integer, ByVal idperiodo As Integer, ByVal tipoCalculo As String)
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand("EXEC sp_insertaCalculoSuplementaria @EMPLEADO_ID, @PERIODO_ID, @TIPO_CALCULO")
        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idEmpleado
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idperiodo
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_CALCULO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = tipoCalculo
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Sub

    Private Shared Sub insertaLiquidacionBonos(ByVal liquidacionID_ENC As Integer, ByVal idEmpleado As Integer, ByVal periodo As Periodo, ByVal idItem As Integer, ByVal tipoItem As Comun.TiposDeDatos.TipoItem, ByVal horasExtras As Decimal, ByVal monto As Integer, ByVal descripcion As String, ByVal idAPV As Integer, ByVal tipoCalculo As String, Optional ByVal NO_CERO As Boolean = False)
        If NO_CERO Then
            If monto = 0 Then
                Exit Sub
            End If
        End If
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        'Ejecución de registro de ítems de liquidación de sueldo
        cmd = New SqlClient.SqlCommand("INSERT INTO RH_REM_LIQUIDACION_BONO (ID_LIQUIDACION_ENC,EMPLEADO_ID, PERIODO_ID, ITEM_ID, TIPO_ITEM, NUMERO_HORAS_EXTRAS, TIPO_CALCULO, MONTO, DESCRIPCION, APV_ID ) values (@ID_LIQUIDACION_ENC,@EMPLEADO_ID, @PERIODO_ID, @ITEM_ID, @TIPO_ITEM, @NUMERO_HORAS_EXTRAS, @TIPO_CALCULO, @MONTO, @DESCRIPCION, @APV_ID )")

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ID_LIQUIDACION_ENC"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = liquidacionID_ENC
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idEmpleado
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = periodo.ID
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ITEM_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idItem
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_ITEM"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = tipoItem
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@NUMERO_HORAS_EXTRAS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Decimal
        prm.Precision = 6
        prm.Scale = 1
        prm.Value = horasExtras
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_CALCULO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = tipoCalculo
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MONTO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = monto
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@DESCRIPCION"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = descripcion
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@APV_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idAPV
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Sub
    Private Shared Function calculoPrevisionSALUD(ByVal empleado As Empleado, ByVal montoConvenio As Double, ByVal unidadMonetariaMC As Integer _
                                         , ByVal planComplementario As Double, ByVal unidadMonetariaPC As Integer _
                                         , ByVal planAUGE As Double, ByVal unidadMonetariaAUGE As Integer _
                                         , ByVal totalImponible As Integer, ByVal periodo As Periodo _
                                         , ByVal procesoReliquidacion As Boolean _
                                         , ByVal tipoSistemaPrevisionalSalud As String _
                                         , ByVal tipoSistemaPrevisional As String _
                                         , ByRef rtnMontoPlanAuge As Integer, ByRef rtnMontoSaludVoluntaria As Integer _
                                         , ByRef rtnPlanPactado As Integer) As Integer
        Dim montoPactado As Integer = 0
        Dim montoPactadoPlanComplementario As Integer = 0
        Dim montoPactadoPlanAUGE As Integer = 0

        If montoConvenio > 0 And empleado.datosLaborales.estadoEmpleadoID <> Comun.TiposDeDatos.TipoEstado.INACTIVO Then
            Select Case unidadMonetariaMC
                Case Is = Comun.TiposDeDatos.TipoUnidad.PORCENTAJE
                    montoPactado = Math.Round((totalImponible * montoConvenio) / 100, 0)
                Case Is = Comun.TiposDeDatos.TipoUnidad.UF
                    If procesoReliquidacion And tipoSistemaPrevisionalSalud = "ISA" And tipoSistemaPrevisional = "INP" Then
                        montoPactado = Math.Round(montoConvenio * periodo.UF, 0)
                    Else
                        montoPactado = Math.Round(montoConvenio * periodo.UF, 0)
                    End If
                Case Is = Comun.TiposDeDatos.TipoUnidad.PESOS
                    montoPactado = montoConvenio
            End Select
            rtnPlanPactado = montoPactado
            Select Case unidadMonetariaPC
                Case Is = Comun.TiposDeDatos.TipoUnidad.PORCENTAJE
                    montoPactadoPlanComplementario = Math.Round((totalImponible * planComplementario) / 100, 0)
                Case Is = Comun.TiposDeDatos.TipoUnidad.UF
                    If procesoReliquidacion And tipoSistemaPrevisionalSalud = "ISA" And tipoSistemaPrevisional = "INP" Then
                        montoPactadoPlanComplementario = Math.Round(planComplementario * periodo.UF, 0)
                    Else
                        montoPactadoPlanComplementario = Math.Round(planComplementario * periodo.UF, 0)
                    End If
                Case Is = Comun.TiposDeDatos.TipoUnidad.PESOS
                    montoPactadoPlanComplementario = planComplementario
            End Select
            rtnMontoSaludVoluntaria = montoPactadoPlanComplementario
            Select Case unidadMonetariaAUGE
                Case Is = Comun.TiposDeDatos.TipoUnidad.PORCENTAJE
                    montoPactadoPlanAUGE = Math.Round((totalImponible * planAUGE) / 100, 0)
                Case Is = Comun.TiposDeDatos.TipoUnidad.UF
                    If procesoReliquidacion And tipoSistemaPrevisionalSalud = "ISA" And tipoSistemaPrevisional = "INP" Then
                        montoPactadoPlanAUGE = Math.Round(planAUGE * periodo.UF, 0)
                    Else
                        montoPactadoPlanAUGE = Math.Round(planAUGE * periodo.UF, 0)
                    End If
                Case Is = Comun.TiposDeDatos.TipoUnidad.PESOS
                    montoPactadoPlanAUGE = planAUGE
            End Select
            rtnMontoPlanAuge = montoPactadoPlanAUGE
            Return (montoPactado + montoPactadoPlanComplementario + montoPactadoPlanAUGE)
        End If
    End Function

    Private Shared Sub calculoPrevisionAFP(ByVal empleado As Empleado, ByVal totalImponible As Integer, ByRef rtnDescuentoLegal As Integer, ByRef rtnAhorroAFP As Integer, ByRef rtnSeguroInvalidezSobr As Integer, ByVal parametros As Periodo, ByVal procesoRemun As String, ByVal idAfp As Integer)
        '1. Rescatar tasa de descuento de AFP / TABLA: RH_REM_AFP_DETALLE
        Dim filaDetalleAFP As DataRow
        Dim fechaVigencia As Date = CType("01-" + CType(parametros.mes, String) + "-" + CType(parametros.ano, String), Date)
        Dim da As New SqlClient.SqlDataAdapter("SELECT TOP 1 tasa_descuento, descuento_ley_19882, tasa_seguro_invalidez_sobrevivencia FROM RH_REM_AFP_DETALLE WHERE ESTADO_REGISTRO=1 AND AFP_ID=" & empleado.datosPrevisionales.institucionID, Comun.ArgoConfiguracion.ConnectionString)
        Dim ds As New DataSet

        da.Fill(ds, Comun.Tablas.RH_REM_AFP_DETALLE)
        Dim tb As DataTable = ds.Tables(Comun.Tablas.RH_REM_AFP_DETALLE)
        If tb.Rows.Count > 0 Then
            filaDetalleAFP = tb.Rows(0)
            da = Nothing
            ds = Nothing

            Dim tasaDescuento As Double
            Dim tasaSeguroSobrevivencia As Double = filaDetalleAFP("tasa_seguro_invalidez_sobrevivencia")

            If procesoRemun = "NORMAL" Then
                tasaDescuento = filaDetalleAFP("tasa_descuento")
            Else
                tasaDescuento = filaDetalleAFP("descuento_ley_19882")
            End If

            '1. Se calcula el monto legal a descontar
            rtnDescuentoLegal = Math.Round((totalImponible * tasaDescuento) / 100, 0)
            '2.- Para cuenta de ahorro se debe conocer el tipo de Moneda
            If empleado.datosLaborales.estadoEmpleadoID <> Comun.TiposDeDatos.TipoEstado.INACTIVO Then
                Select Case empleado.datosPrevisionales.unidadCuentaAhorroAFPId
                    Case Is = Comun.TiposDeDatos.TipoUnidad.PESOS
                        rtnAhorroAFP = empleado.datosPrevisionales.montoCuentaAhorroAFP
                    Case Is = Comun.TiposDeDatos.TipoUnidad.UF
                        rtnAhorroAFP = Math.Round(empleado.datosPrevisionales.montoCuentaAhorroAFP * valorUF, 0)
                End Select
            End If
            '3.- Se calcula seguro invalidez y sobrevivencia
            rtnSeguroInvalidezSobr = Math.Round((totalImponible * tasaSeguroSobrevivencia) / 100, 0)

        End If
    End Sub

    Private Shared Function montoCalculado(ByVal tipoSistemaPrevisional As String, ByVal diasTrabajados As Integer, ByVal wb As Microsoft.Office.Interop.Excel.Workbook, ByVal empleado As Empleado, ByVal periodo As Periodo, ByVal variable As String, Optional ByVal totalImponible As Integer = 0, Optional ByVal horasDiurnas As Integer = 0, Optional ByVal horasNocturnas As Integer = 0) As Integer
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet
        Dim rng As Microsoft.Office.Interop.Excel.Range
        'Dim tipoSistemaPrevisional As String = "INP"
        Try
            'INICIALIZACION
            ws = wb.ActiveSheet
            rng = ws.Range("IMPO_60UF")
            If tipoSistemaPrevisional = "INP" Then
                rng.Value = Math.Round(periodo.topeImponible1 * periodo.ufMesAnterior, 0)
            Else
                rng.Value = Math.Round(periodo.topeImponible1 * periodo.UF, 0)
            End If

            rng = ws.Range("SUELDO_BASE")
            If diasTrabajados >= 0 Then
                rng.Value = calculoProporcionDiasTrabajados(empleado.datosRemuneracion.sueldoBase, diasTrabajados)
            Else
                rng.Value = empleado.datosRemuneracion.sueldoBase
            End If

            rng = ws.Range("ASIGNACION_LEY19185_ART18")
            If diasTrabajados >= 0 Then
                rng.Value = calculoProporcionDiasTrabajados(empleado.datosRemuneracion.valorAsignacionLey19185Art18, diasTrabajados)
            Else
                rng.Value = empleado.datosRemuneracion.valorAsignacionLey19185Art18
            End If

            rng = ws.Range("PORCENTAJE_DESCTO_BIENESTAR")
            rng.Value = (periodo.porcentajeDesctoBienestar / 100)

            rng = ws.Range("CANTIDAD_BIENIOS")
            rng.Value = empleado.datosRemuneracion.numeroBienios
            rng = ws.Range("TOTAL_IMPONIBLE")
            rng.Value = totalImponible
            rng = ws.Range("HORAS_DIURNAS")
            rng.Value = horasDiurnas
            rng = ws.Range("HORAS_NOCTURNAS")
            rng.Value = horasNocturnas

            Dim fechaInicioMes, fechaFinalMes As Date
            Dim diasMes As Integer = Date.DaysInMonth(periodo.ano, periodo.mes)
            Dim diasAsignacion, montoAsigProfesional As Integer
            fechaInicioMes = New Date(CInt(periodo.ano), periodo.mes, 1)
            fechaFinalMes = New Date(CInt(periodo.ano), periodo.mes, diasMes)

            montoAsigProfesional = empleado.datosRemuneracion.valorAsignacionProfesional
            If empleado.datosLaborales.fechaIngresoInstitucion >= fechaInicioMes And empleado.datosLaborales.fechaIngresoInstitucion <= fechaFinalMes Then
                If empleado.datosLaborales.fechaIngresoInstitucion > fechaInicioMes Then
                    diasAsignacion = DateDiff(DateInterval.Day, empleado.datosLaborales.fechaIngresoInstitucion, fechaFinalMes) + 1
                    montoAsigProfesional = calculoProporcionDiasTrabajados(empleado.datosRemuneracion.valorAsignacionProfesional, diasAsignacion)

                    'En caso que dias trabajados sea ingresado como movimiento mensual, 
                    'este prevalece sobre el calculo dias trabajado según fecha ingreso del empleado
                    If diasTrabajados > 0 Then
                        montoAsigProfesional = empleado.datosRemuneracion.valorAsignacionProfesional
                    End If
                End If
            End If

            rng = ws.Range("ASIGNACION_PROFESIONAL")
            If diasTrabajados >= 0 Then
                If empleado.datosLaborales.fechaIngresoEstamento > fechaInicioMes And empleado.datosLaborales.fechaIngresoEstamento <= fechaFinalMes Then
                    diasAsignacion = DateDiff(DateInterval.Day, empleado.datosLaborales.fechaIngresoEstamento, fechaFinalMes) + 1
                    'montoAsigProfesional = calculoProporcionDiasTrabajados(empleado.datosRemuneracion.valorAsignacionProfesional, diasAsignacion)
                    montoAsigProfesional = calculoProporcionDiasTrabajados(empleado.datosRemuneracion.valorAsignacionProfesional, diasTrabajados)
                    rng.Value = montoAsigProfesional
                Else
                    rng.Value = calculoProporcionDiasTrabajados(montoAsigProfesional, diasTrabajados)
                End If
            Else
                rng.Value = montoAsigProfesional
            End If
            rng = ws.Range("APLICA_LEY_3551")
            If empleado.datosRemuneracion.valorLey3551 > 0 Then
                rng.Value = 1 'Verdadero
            Else
                rng.Value = 0
            End If
            rng = ws.Range(variable)
            Dim retorno As Integer = rng.Value
            wb.Saved = True
            Return (retorno)
        Catch ex As Exception
            Debug.WriteLine(ex.Message)

        End Try
    End Function

    Shared Sub cantidadHorasExtras(ByVal empleado As Empleado, ByVal periodo As Periodo, ByVal tipoProceso As String, _
            ByVal reliquidacionBono As Boolean, ByRef cantHorasDiurnas As Integer, ByRef cantHorasNocturnas As Integer, _
            ByRef cantHorasAtraso As Integer, ByRef cantMedioDiaInasistenca As Decimal, ByRef cantDiaInsistencia As Integer)
        Dim conn As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        conn.ConnectionString = Comun.ArgoConfiguracion.ConnectionString
        Try
            conn.Open()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        Try
            cmd.Connection = conn
            'Proceso horas extras NORMAL de remuneraciones
            If tipoProceso = "N" And Not reliquidacionBono Then
                cmd.CommandText = "SELECT ISNULL(SUM(HORAS_EXTRAS_MAXIMA_DIURNA),0) AS HORAS_EXTRAS_MAXIMA_DIURNA, " & _
                                    "ISNULL(SUM(HORAS_EXTRAS_MAXIMA_NOCTURNA),0) AS HORAS_EXTRAS_MAXIMA_NOCTURNA, " & _
                                    "ISNULL(SUM(HORAS_ATRASADAS),0) AS HORAS_ATRASADAS, " & _
                                    "ISNULL(SUM(TOTAL_DIAS_INASISTENCIAS),0) AS TOTAL_DIAS_INASISTENCIAS, " & _
                                    "ISNULL(SUM(TOTAL_MEDIO_DIAS_INASISTENCIA),0) AS TOTAL_MEDIO_DIAS_INASISTENCIA " & _
                                    "FROM RH_PER_HORAS_EXTRAS " & _
                                    "WHERE EMPLEADO_ID=@EMPLEADO_ID " & _
                                    "AND PERIODO_ID=@PERIODO_ID " & _
                                    "AND TIPO_PROCESO=@TIPO_PROCESO"
                prm = New SqlClient.SqlParameter
                prm.ParameterName = "@TIPO_PROCESO"
                prm.Direction = ParameterDirection.Input
                prm.SqlDbType = SqlDbType.VarChar
                prm.Value = tipoProceso
                cmd.Parameters.Add(prm)
            Else
                'Proceso horas extras NORMAL de remuneraciones
                If tipoProceso = "N" And reliquidacionBono Then
                    cmd.CommandText = "SELECT ISNULL(SUM(HORAS_EXTRAS_MAXIMA_DIURNA),0) AS HORAS_EXTRAS_MAXIMA_DIURNA, " & _
                                        "ISNULL(SUM(HORAS_EXTRAS_MAXIMA_NOCTURNA),0) AS HORAS_EXTRAS_MAXIMA_NOCTURNA, " & _
                                        "ISNULL(SUM(HORAS_ATRASADAS),0) AS HORAS_ATRASADAS, " & _
                                        "ISNULL(SUM(TOTAL_DIAS_INASISTENCIAS),0) AS TOTAL_DIAS_INASISTENCIAS, " & _
                                        "ISNULL(SUM(TOTAL_MEDIO_DIAS_INASISTENCIA),0) AS TOTAL_MEDIO_DIAS_INASISTENCIA " & _
                                        "FROM RH_PER_HORAS_EXTRAS " & _
                                        "WHERE EMPLEADO_ID=@EMPLEADO_ID " & _
                                        "AND PERIODO_ID=@PERIODO_ID " & _
                                        "AND (TIPO_PROCESO='N' OR TIPO_PROCESO='S')"
                Else
                    If tipoProceso = "S" Then
                        cmd.CommandText = "SELECT ISNULL(SUM(HORAS_EXTRAS_MAXIMA_DIURNA),0) AS HORAS_EXTRAS_MAXIMA_DIURNA, " & _
                                                           "ISNULL(SUM(HORAS_EXTRAS_MAXIMA_NOCTURNA),0) AS HORAS_EXTRAS_MAXIMA_NOCTURNA, " & _
                                                           "ISNULL(SUM(HORAS_ATRASADAS),0) AS HORAS_ATRASADAS, " & _
                                                           "ISNULL(SUM(TOTAL_DIAS_INASISTENCIAS),0) AS TOTAL_DIAS_INASISTENCIAS, " & _
                                                           "ISNULL(SUM(TOTAL_MEDIO_DIAS_INASISTENCIA),0) AS TOTAL_MEDIO_DIAS_INASISTENCIA " & _
                                                           "FROM RH_PER_HORAS_EXTRAS " & _
                                                           "WHERE EMPLEADO_ID=@EMPLEADO_ID " & _
                                                           "AND PERIODO_ID=@PERIODO_ID " & _
                                                           "AND (TIPO_PROCESO='N' OR TIPO_PROCESO='S')"
                    End If
                End If
            End If

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@EMPLEADO_ID"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.Int
            prm.Value = empleado.ID
            cmd.Parameters.Add(prm)

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@PERIODO_ID"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.Int
            prm.Value = periodo.ID
            cmd.Parameters.Add(prm)

            Dim dr As SqlClient.SqlDataReader = cmd.ExecuteReader()
            While dr.Read

                cantHorasDiurnas = (dr("HORAS_EXTRAS_MAXIMA_DIURNA"))
                cantHorasNocturnas = (dr("HORAS_EXTRAS_MAXIMA_NOCTURNA"))
                cantHorasAtraso = (dr("HORAS_ATRASADAS"))
                cantMedioDiaInasistenca = (dr("TOTAL_MEDIO_DIAS_INASISTENCIA"))
                cantDiaInsistencia = (dr("TOTAL_DIAS_INASISTENCIAS"))
            End While
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            conn.Close()
            cmd = Nothing
            conn = Nothing
        End Try

    End Sub


    Shared Function procesoCalculoAhorroAPV(ByVal empleado As Empleado, ByVal periodo As Periodo, ByVal liquidacionID_ENC As Integer, ByVal tipoProcesoRemun As String, ByVal imponible As Integer, ByVal reliquidacionBono As Boolean) As Integer
        Dim totalAhorro As Integer
        Dim conn As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        conn.ConnectionString = Comun.ArgoConfiguracion.ConnectionString
        Try
            conn.Open()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        If Not empleado.estado = Comun.TiposDeDatos.TipoEstado.INACTIVO Then
            Try
                cmd.Connection = conn
                If reliquidacionBono Then
                    cmd.CommandText = "SELECT MONTO_AHORRO, MONEDA_AHORRO_APV_ID, APV_ID FROM RH_PER_ANTECEDENTE_APV WHERE EMPLEADO_ID=@EMPLEADO_ID AND ESTADO_REGISTRO=5 AND PERIODO_ID=@PERIODO_ID"
                    prm = New SqlClient.SqlParameter
                    prm.ParameterName = "@EMPLEADO_ID"
                    prm.Direction = ParameterDirection.Input
                    prm.SqlDbType = SqlDbType.Int
                    prm.Value = empleado.ID
                    cmd.Parameters.Add(prm)

                    prm = New SqlClient.SqlParameter
                    prm.ParameterName = "@PERIODO_ID"
                    prm.Direction = ParameterDirection.Input
                    prm.SqlDbType = SqlDbType.Int
                    prm.Value = periodo.ID
                    cmd.Parameters.Add(prm)

                Else
                    cmd.CommandText = "SELECT MONTO_AHORRO, MONEDA_AHORRO_APV_ID, APV_ID FROM RH_PER_ANTECEDENTE_APV WHERE EMPLEADO_ID=@EMPLEADO_ID AND ESTADO_REGISTRO=1"
                    prm = New SqlClient.SqlParameter
                    prm.ParameterName = "@EMPLEADO_ID"
                    prm.Direction = ParameterDirection.Input
                    prm.SqlDbType = SqlDbType.Int
                    prm.Value = empleado.ID
                    cmd.Parameters.Add(prm)
                End If


                Dim dr As SqlClient.SqlDataReader = cmd.ExecuteReader()
                Dim MontoAhorro As Integer
                While dr.Read
                    If dr("MONEDA_AHORRO_APV_ID") = Comun.TiposDeDatos.TipoUnidad.PESOS And dr("MONTO_AHORRO") > 0 Then
                        MontoAhorro = dr("MONTO_AHORRO")
                    ElseIf dr("MONEDA_AHORRO_APV_ID") = Comun.TiposDeDatos.TipoUnidad.UF And dr("MONTO_AHORRO") > 0 Then
                        MontoAhorro = Math.Round(dr("MONTO_AHORRO") * periodo.UF, 0)
                    ElseIf dr("MONEDA_AHORRO_APV_ID") = Comun.TiposDeDatos.TipoUnidad.PORCENTAJE And dr("MONTO_AHORRO") > 0 Then
                        MontoAhorro = Math.Round((dr("MONTO_AHORRO") / 100) * imponible, 0)
                    End If
                    'Select Case dr("MONEDA_AHORRO_APV_ID")
                    '    Case Is = Comun.TiposDeDatos.TipoUnidad.PESOS
                    '        MontoAhorro = dr("MONTO_AHORRO")
                    '    Case Is = Comun.TiposDeDatos.TipoUnidad.UF
                    '        MontoAhorro = Math.Round(dr("MONTO_AHORRO") * periodo.UF, 0)
                    '    Case Is = Comun.TiposDeDatos.TipoUnidad.PORCENTAJE
                    '        MontoAhorro = Math.Round((dr("MONTO_AHORRO") / 100) * imponible, 0)
                    'End Select
                    Debug.WriteLine(periodo.itemMontoAPV & "AHORRO APV " & MontoAhorro)
                    If reliquidacionBono Then
                        insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemMontoAPV, Comun.TiposDeDatos.TipoItem.DEBERES, 0, MontoAhorro, "AHORRO APV", dr("APV_ID"), tipoProcesoRemun)
                    Else
                        insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemMontoAPV, Comun.TiposDeDatos.TipoItem.DEBERES, 0, MontoAhorro, "AHORRO APV", dr("APV_ID"), tipoProcesoRemun)
                    End If
                    totalAhorro += MontoAhorro
                End While
                Return (totalAhorro)
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            Finally
                conn.Close()
                cmd = Nothing
                conn = Nothing
            End Try
        End If
    End Function

    Shared Sub calculoHonorario(ByVal empleado As Empleado, ByVal periodo As Periodo, ByVal tipoProceso As String)
        'Dim periodo As New periodo
        Dim liquidacionID_ENC As Integer = IniCalculoRegLiquidacion(empleado.ID, periodo.ID, tipoProceso)
        Dim diasTrabajados As Short
        Dim rentaBase As Integer
        Dim retencion As Integer
        Dim liquido As Integer

        Dim fechaInicioMes, fechaFinMes As Date
        Dim diasMes As Integer = Date.DaysInMonth(periodo.ano, periodo.mes)
        fechaInicioMes = New Date(CInt(periodo.ano), periodo.mes, 1)
        fechaFinMes = New Date(CInt(periodo.ano), periodo.mes, diasMes)

        'Busca días trabajados en el mes, solo en caso que la FECHA DE RETIRO se encuentre
        'en el rango del mes de proceso
        If empleado.datosLaborales.motivoRetiroID > 0 And empleado.datosLaborales.fechaRetiro >= fechaInicioMes And empleado.datosLaborales.fechaRetiro <= fechaFinMes And empleado.datosLaborales.periodoID = periodo.ID Then
            If empleado.datosLaborales.fechaIngresoInstitucion <= fechaInicioMes Then
                diasTrabajados = DateDiff(DateInterval.Day, fechaInicioMes, empleado.datosLaborales.fechaRetiro) + 1
            Else
                diasTrabajados = DateDiff(DateInterval.Day, empleado.datosLaborales.fechaIngresoInstitucion, empleado.datosLaborales.fechaRetiro) + 1
            End If
            If diasTrabajados < diasTrabajadosLEGAL Then
                rentaBase = calculoProporcionDiasTrabajados(empleado.datosRemuneracion.rentaBase, diasTrabajados)
            Else
                rentaBase = empleado.datosRemuneracion.rentaBase
            End If
        Else
            diasTrabajados = diasTrabajadosLEGAL
            rentaBase = empleado.datosRemuneracion.rentaBase
        End If
        retencion = Math.Round(rentaBase * (0.10000000000000001), 0)
        liquido = Math.Round(rentaBase - retencion, 0)

        If tipoProceso = Comun.TipoProceso.SUPLEMENTARIA_HONORARIOS Then
            copiarLiquidacionNormalASuplementaria(empleado.ID, periodo.ID, Comun.TipoProceso.NORMAL_HONORARIOS)
        End If

        Dim institucionSaludActual As Integer = empleado.obtenerInstitucionSaludActual(empleado.ID)
        actualizaTotal(liquidacionID_ENC, "SUELDO_BASE", rentaBase, tipoProceso)
        actualizaTotal(liquidacionID_ENC, "LIQUIDO", liquido, tipoProceso)
        actualizaTotal(liquidacionID_ENC, "IMPUESTO_UNICO", retencion, tipoProceso)
        actualizaTotal(liquidacionID_ENC, "AFP_ID", empleado.datosPrevisionales.institucionID, tipoProceso)
        actualizaTotal(liquidacionID_ENC, "INSTITUCION_SALUD_ID", institucionSaludActual, tipoProceso)
        actualizaTotal(liquidacionID_ENC, "DIAS_TRABAJADOS", diasTrabajados, tipoProceso)
        insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemSueldoBase, Comun.TiposDeDatos.TipoItem.HABERES, 0, rentaBase, "RENTA BASE", 0, tipoProceso)
        insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalHaberes, Comun.TiposDeDatos.TipoItem.TOTAL, 0, rentaBase, "TOTAL HABERES", 0, tipoProceso)
        insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemRetencion10, Comun.TiposDeDatos.TipoItem.DEBERES, 0, retencion, "RETENCION 10%", 0, tipoProceso)
        insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalDeberes, Comun.TiposDeDatos.TipoItem.TOTAL, 0, retencion, "TOTAL DESCUENTOS", 0, tipoProceso)
        insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemLiquidoPago, Comun.TiposDeDatos.TipoItem.OTROS, 0, liquido, "LIQUIDO PAGO", 0, tipoProceso)

        If tipoProceso = Comun.TipoProceso.SUPLEMENTARIA_HONORARIOS Then
            empleado.CrearEmpleadoSuplementariaHonorario(periodo.ID, periodo.ID, empleado.ID, Comun.TipoProceso.SUPLEMENTARIA_HONORARIOS)
        End If
    End Sub

    Shared Sub calculaRemuneracion(ByVal empleado As Empleado, ByVal wb As Microsoft.Office.Interop.Excel.Workbook, ByVal tipoProcesoRemun As String, ByVal periodo As Periodo, ByVal reliquidacionBono As Boolean)

        Dim diasTrabajados As Short
        'Montos fijos del funcionario
        'Dependen del grado, la calidad jurídica y la clasificación
        Dim fechaInicoMes, fechaFinMes As Date
        Dim diasMes As Integer = Date.DaysInMonth(periodo.ano, periodo.mes)
        fechaInicoMes = New Date(CInt(periodo.ano), periodo.mes, 1)
        fechaFinMes = New Date(CInt(periodo.ano), periodo.mes, diasMes)

        Dim totalImponible60 As Integer = 0
        Dim totalImponible90 As Integer = 0
        Dim totalImponible As Integer = 0
        Dim totalHaberes As Integer = 0
        Dim totalDeberes As Integer = 0
        Dim totalExento As Integer = 0
        Dim totalTributable As Integer = 0
        Dim montoSalud As Integer = 0
        Dim montoAFP As Integer = 0
        Dim movPeriodo As DataTable
        Dim valorUF As Integer
        Dim valorUTM As Integer

        valorUF = periodo.UF
        valorUTM = periodo.UTM

        Dim liquidacionID_ENC As Integer
        If reliquidacionBono Then
            liquidacionID_ENC = IniCalculoRegLiquidacionBono(empleado.ID, periodo.ID, tipoProcesoRemun)
        Else
            liquidacionID_ENC = IniCalculoRegLiquidacion(empleado.ID, periodo.ID, tipoProcesoRemun)
        End If

        'En caso que dias trabajados sea ingresado como movimiento mensual, 
        'este prevalece sobre el calculo dias trabajado según fecha ingreso del empleado
        diasTrabajados = empleado.diasTrabajados(periodo, tipoProcesoRemun)

        'Busca días trabajados en el mes, solo en caso que la FECHA DE INGRESO se encuentre
        'en el rango del mes de proceso y el día ingreso sea mayor al primer día
        If empleado.datosLaborales.fechaIngresoInstitucion > fechaInicoMes And empleado.datosLaborales.fechaIngresoInstitucion <= fechaFinMes Then
            diasTrabajados = DateDiff(DateInterval.Day, empleado.datosLaborales.fechaIngresoInstitucion, fechaFinMes) + 1
            If diasMes = 31 Then
                diasTrabajados -= 1
            End If
        End If

        'Busca días trabajados en el mes, solo en caso que la FECHA DE RETIRO se encuentre
        'en el rango del mes de proceso
        If empleado.datosLaborales.motivoRetiroID > 0 And empleado.datosLaborales.fechaRetiro >= fechaInicoMes And empleado.datosLaborales.fechaRetiro <= fechaFinMes And empleado.datosLaborales.periodoID = periodo.ID And diasTrabajados > 0 Then
            If empleado.datosLaborales.fechaIngresoInstitucion <= fechaInicoMes Then
                diasTrabajados = DateDiff(DateInterval.Day, fechaInicoMes, empleado.datosLaborales.fechaRetiro) + 1
            Else
                diasTrabajados = DateDiff(DateInterval.Day, empleado.datosLaborales.fechaIngresoInstitucion, empleado.datosLaborales.fechaRetiro) + 1
            End If
        End If


        If reliquidacionBono Then
            actualizaTotalBonos(liquidacionID_ENC, "DIAS_TRABAJADOS", diasTrabajados, tipoProcesoRemun)
        Else
            actualizaTotal(liquidacionID_ENC, "DIAS_TRABAJADOS", diasTrabajados, tipoProcesoRemun)
        End If

        Dim tipoSistemaPrevisionalSalud As String
        Dim tipoSistemaPrevisional As String

        'Recupera tipo sistema de salud
        tipoSistemaPrevisionalSalud = empleado.recuperarTipoSistemaPrevisional("SELECT SISTEMA_PREV_ALIAS FROM VW_TABLA_ISAPRE WHERE ISAPRE_ID = " & empleado.datosSalud.institucionID)

        'Recupera tipo sistema previsional
        tipoSistemaPrevisional = empleado.recuperarTipoSistemaPrevisional("SELECT SISTEMA_PREV_ALIAS FROM VW_TABLA_AFP WHERE AFP_ID = " & empleado.datosPrevisionales.institucionID)


        'CALCULO DE HABERES
        '----------------------------------------------------
        'Rescatar los movimientos del empleado, relacionados al período y el tipo de proceso
        movPeriodo = empleado.movimientosDelPeriodo(periodo.ID, Comun.TiposDeDatos.TipoItem.HABERES, tipoProcesoRemun, Comun.TiposDeDatos.IncluyeCalculoRemuneracion.SI_INCLUYE)

        Dim totalleyesSocialesTope As Integer = 0
        Dim totalDescuentoTributable As Integer = 0
        Dim totalOtrosDescuentos As Integer = 0
        Dim totalHaberesAfectoDesctoAtrasoInasistencia As Integer = 0
        Dim filaMovimiento As Data.DataRow
        Dim montoCalculo As Integer = 0
        Dim descripcionItem As String
        Dim montoFila As Integer

        For Each filaMovimiento In movPeriodo.Rows
            montoCalculo = 0
            descripcionItem = filaMovimiento("ITEM_ALIAS") & " " & filaMovimiento("DESCRIPCION_LARGA") & " "
            Debug.Write(descripcionItem)

            'En caso en que el item corresponde a reliquidación de bono
            If filaMovimiento("ES_RELIQUIDACION_BONO") Then
                totalHaberes += filaMovimiento("CANTIDAD")
                If filaMovimiento("ES_CALCULABLE") = False Then
                    montoFila = filaMovimiento("CANTIDAD")
                Else
                    montoFila = montoCalculado(tipoSistemaPrevisional, diasTrabajados, wb, empleado, periodo, filaMovimiento("CELDA_CALCULO"))
                End If
                If reliquidacionBono Then
                    If filaMovimiento("ES_IMPONIBLE_MES_HISTORICO") = True Then
                        totalImponible += montoFila
                        Debug.WriteLine("IMPONIBLE " & montoFila.ToString("C"))
                    End If
                    'Si item es tributable
                    If filaMovimiento("ES_TRIBUTABLE_MES_HISTORICO") = True Then
                        totalTributable += montoFila
                        Debug.WriteLine("TRIBUTABLE " & montoFila.ToString("C"))
                    End If
                    insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, filaMovimiento("ITEM_ID"), Comun.TiposDeDatos.TipoItem.HABERES, 0, montoFila, descripcionItem, 0, tipoProcesoRemun)
                Else
                    insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, filaMovimiento("ITEM_ID"), Comun.TiposDeDatos.TipoItem.HABERES, 0, montoFila, descripcionItem, 0, tipoProcesoRemun)
                End If
            Else
                'En caso en que el item no es calculable
                If filaMovimiento("ES_CALCULABLE") = False Then
                    If filaMovimiento("ES_PROPORCIONAL_DIAS_TRABAJADOS") = True Then
                        montoFila = calculoProporcionDiasTrabajados((filaMovimiento("CANTIDAD")), diasTrabajados)
                    Else
                        montoFila = filaMovimiento("CANTIDAD")
                    End If
                    totalHaberes += montoFila
                    'Si item es imponible
                    If filaMovimiento("ES_IMPONIBLE") = True Then
                        totalImponible += montoFila
                        Debug.WriteLine("IMPONIBLE " & montoFila.ToString("C"))
                    End If
                    'Si item es tributable
                    If filaMovimiento("ES_TRIBUTABLE") = True Then
                        totalTributable += montoFila
                        Debug.WriteLine("TRIBUTABLE " & montoFila.ToString("C"))
                    End If
                    'Si Item es Exento
                    If filaMovimiento("ES_TRIBUTABLE") = False And filaMovimiento("ES_IMPONIBLE") = False Then
                        totalExento += montoFila
                        Debug.WriteLine("EXENTO " & montoFila.ToString("C"))
                    End If
                    If reliquidacionBono Then
                        insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, filaMovimiento("ITEM_ID"), Comun.TiposDeDatos.TipoItem.HABERES, 0, montoFila, descripcionItem, 0, tipoProcesoRemun)
                    Else
                        insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, filaMovimiento("ITEM_ID"), Comun.TiposDeDatos.TipoItem.HABERES, 0, montoFila, descripcionItem, 0, tipoProcesoRemun)
                    End If
                Else
                    'En caso en que el item sea calculable en planilla EXCEL
                    montoCalculo = montoCalculado(tipoSistemaPrevisional, diasTrabajados, wb, empleado, periodo, filaMovimiento("CELDA_CALCULO"))
                    totalHaberes += montoCalculo
                    'Si item es imponible
                    If filaMovimiento("ES_IMPONIBLE") = True Then
                        totalImponible += montoCalculo
                        Debug.WriteLine("IMPONIBLE CALCULADO " & montoCalculo.ToString("C"))
                    End If
                    'Si item es tributable
                    If filaMovimiento("ES_TRIBUTABLE") = True Then
                        totalTributable += montoCalculo
                        Debug.WriteLine("TRIBUTABLE CALCULADO " & montoCalculo.ToString("C"))
                    End If
                    If reliquidacionBono Then
                        insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, filaMovimiento("ITEM_ID"), Comun.TiposDeDatos.TipoItem.HABERES, 0, montoCalculo, descripcionItem, 0, tipoProcesoRemun)
                    Else
                        insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, filaMovimiento("ITEM_ID"), Comun.TiposDeDatos.TipoItem.HABERES, 0, montoCalculo, descripcionItem, 0, tipoProcesoRemun)
                    End If
                End If
            End If
            If filaMovimiento("ES_ATRASO_INASISTENCIA") Then
                totalHaberesAfectoDesctoAtrasoInasistencia += filaMovimiento("CANTIDAD")
            End If
        Next

        'Recupera horas extras, atrasos e inasistencia por empleado y periodo
        Dim cantHorasDiurnas, cantHorasNocturnas, cantHorasAtraso, cantDiaInsistencia As Integer
        Dim cantMedioDiaInasistenca As Decimal
        cantidadHorasExtras(empleado, periodo, tipoProcesoRemun, reliquidacionBono, cantHorasDiurnas, cantHorasNocturnas, cantHorasAtraso, cantMedioDiaInasistenca, cantDiaInsistencia)
        Dim montoHorasDiurnas, montoHorasNocturnas, montoHorasAtraso, montoInasistencias As Integer

        'Calcula monto horas extras diurnas
        If cantHorasDiurnas > 0 Then
            If periodo.calculoHorasExtrasMesAnterior Then
                Dim empleadoHorasExtras As Empleado
                Dim parametroMensual As Periodo
                parametroMensual = New Periodo(periodo.periodoIDHoraExtras)
                'Dim diastrabajadosMesAnterior As Short = empleado.diasTrabajados(parametroMensual, tipoProcesoRemun) 'Esta la linea original
                Dim diastrabajadosMesAnterior As Short = empleado.diasTrabajadosSegunLiquidacion(parametroMensual, "N")
                empleadoHorasExtras = New Empleado(empleado.ID, periodo.periodoIDHoraExtras)
                montoHorasDiurnas = montoCalculado("", diastrabajadosMesAnterior, wb, empleadoHorasExtras, parametroMensual, "MONTO_HORAS_DIURNAS", 0, cantHorasDiurnas, cantHorasNocturnas)
            Else
                montoHorasDiurnas = montoCalculado("", diasTrabajados, wb, empleado, periodo, "MONTO_HORAS_DIURNAS", 0, cantHorasDiurnas, cantHorasNocturnas)
            End If
            Debug.WriteLine("CANT HORAS EXTRAS DIURNAS " & cantHorasDiurnas & " MONTO: " & montoHorasDiurnas.ToString("C"))
            If reliquidacionBono Then
                insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemHorasExtrasDiurnas, Comun.TiposDeDatos.TipoItem.HABERES, cantHorasDiurnas, montoHorasDiurnas, "HORAS EXTRAS DIURNAS", 0, tipoProcesoRemun)
            Else
                insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemHorasExtrasDiurnas, Comun.TiposDeDatos.TipoItem.HABERES, cantHorasDiurnas, montoHorasDiurnas, "HORAS EXTRAS DIURNAS", 0, tipoProcesoRemun)
            End If
        End If

        'Calcula monto horas extras nocturnas
        If cantHorasNocturnas > 0 Then
            If periodo.calculoHorasExtrasMesAnterior Then
                Dim empleadoHorasExtras As Empleado
                Dim parametroMensual As Periodo
                parametroMensual = New Periodo(periodo.periodoIDHoraExtras)
                'Dim diastrabajadosMesAnterior As Short = empleado.diasTrabajados(parametroMensual, tipoProcesoRemun)
                Dim diastrabajadosMesAnterior As Short = empleado.diasTrabajadosSegunLiquidacion(parametroMensual, "N")
                empleadoHorasExtras = New Empleado(empleado.ID, periodo.periodoIDHoraExtras)
                montoHorasNocturnas = montoCalculado("", diastrabajadosMesAnterior, wb, empleadoHorasExtras, parametroMensual, "MONTO_HORAS_NOCTURNAS", 0, cantHorasDiurnas, cantHorasNocturnas)
            Else
                montoHorasNocturnas = montoCalculado("", diasTrabajados, wb, empleado, periodo, "MONTO_HORAS_NOCTURNAS", 0, cantHorasDiurnas, cantHorasNocturnas)
            End If
            Debug.WriteLine("CANT HORAS EXTRAS NOCTURNAS " & cantHorasDiurnas & " MONTO: " & montoHorasNocturnas.ToString("C"))
            If reliquidacionBono Then
                insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemHorasExtrasNocturnas, Comun.TiposDeDatos.TipoItem.HABERES, cantHorasNocturnas, montoHorasNocturnas, "HORAS EXTRAS NOCTURNAS", 0, tipoProcesoRemun)
            Else
                insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemHorasExtrasNocturnas, Comun.TiposDeDatos.TipoItem.HABERES, cantHorasNocturnas, montoHorasNocturnas, "HORAS EXTRAS NOCTURNAS", 0, tipoProcesoRemun)
            End If
        End If


        'Genera item base
        If periodo.procesaBonoModernizacion = False Then
            GeneraItemsBase(empleado, periodo, "N", liquidacionID_ENC, diasTrabajados)
        End If

        'Calcula monto horas atraso
        If cantHorasAtraso > 0 And periodo.aplicaDescuentoAtraso Then
            If periodo.calculoHorasExtrasMesAnterior Then
                montoHorasAtraso = Math.Round(((totalHaberesAfectoAtraso(empleado.ID, periodo.periodoIDHoraExtras) / factorAtraso) * cantHorasAtraso), 0)
            Else
                montoHorasAtraso = Math.Round(((totalHaberesAfectoAtraso(empleado.ID, periodo.ID) / factorAtraso) * cantHorasAtraso), 0)
            End If
            If reliquidacionBono Then
                insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemAtraso, Comun.TiposDeDatos.TipoItem.DEBERES, cantHorasAtraso, montoHorasAtraso, "HORAS ATRASO", 0, tipoProcesoRemun)
            Else
                insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemAtraso, Comun.TiposDeDatos.TipoItem.DEBERES, cantHorasAtraso, montoHorasAtraso, "HORAS ATRASO", 0, tipoProcesoRemun)
            End If
        End If

        'Calcula monto inasistencia medio día
        If cantMedioDiaInasistenca > 0 And periodo.aplicaDescuentoInasistenciaMedioDia Then
            Dim diasInsistenciaEntero As Integer = System.Math.Floor(cantMedioDiaInasistenca)
            Dim diasInsistenciaDecimal As Decimal = CType((cantMedioDiaInasistenca - diasInsistenciaEntero), Decimal)
            montoInasistencias = Math.Round(((totalHaberesAfectoDesctoAtrasoInasistencia / factorInasistenciaMedioDia) * diasInsistenciaDecimal), 0) + Math.Round(((totalHaberesAfectoDesctoAtrasoInasistencia / factorInasistenciaDiaEntero) * diasInsistenciaEntero), 0)
            If reliquidacionBono Then
                insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemInasistencia, Comun.TiposDeDatos.TipoItem.DEBERES, cantMedioDiaInasistenca, montoInasistencias, "DESCUENTO 1/2 DIA INASISTENCIA", 0, tipoProcesoRemun)
            Else
                insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemInasistencia, Comun.TiposDeDatos.TipoItem.DEBERES, cantMedioDiaInasistenca, montoInasistencias, "DESCUENTO 1/2 DIA INASISTENCIA", 0, tipoProcesoRemun)
            End If
        End If

        totalDeberes += montoHorasAtraso + montoInasistencias
        totalHaberes += montoHorasDiurnas + montoHorasNocturnas
        totalTributable += montoHorasDiurnas + montoHorasNocturnas

        Debug.WriteLine("TOTAL HABERES " & totalHaberes.ToString("C"))
        Debug.WriteLine("===============================================")

        'Calculo Imponible para efectos seguro cesantia y bono retiro
        If totalImponible > Math.Round(periodo.topeImponible2 * periodo.UF, 0) Then
            totalImponible90 = Math.Round(periodo.topeImponible2 * periodo.UF, 0)
        Else
            totalImponible90 = totalImponible
        End If

        'Calculo Imponible para efectos previsionales y de salud
        If tipoSistemaPrevisional = "INP" And tipoSistemaPrevisionalSalud = "ISA" Then
            If totalImponible > Math.Round(periodo.topeImponible1 * periodo.ufMesAnterior, 0) Then
                totalImponible60 = Math.Round(periodo.topeImponible1 * periodo.ufMesAnterior, 0)
            Else
                totalImponible60 = totalImponible
            End If
        Else
            If totalImponible > Math.Round(periodo.topeImponible1 * periodo.UF, 0) Then
                totalImponible60 = Math.Round(periodo.topeImponible1 * periodo.UF, 0)
            Else
                totalImponible60 = totalImponible
            End If
        End If

        'CALCULO DE DEBERES
        '-------------------------------
        movPeriodo = empleado.movimientosDelPeriodo(periodo.ID, Comun.TiposDeDatos.TipoItem.DEBERES, tipoProcesoRemun, Comun.TiposDeDatos.IncluyeCalculoRemuneracion.SI_INCLUYE)
        'Recorrer solo haberes
        filaMovimiento = Nothing
        For Each filaMovimiento In movPeriodo.Rows
            descripcionItem = filaMovimiento("ITEM_ALIAS") & " " & filaMovimiento("DESCRIPCION_LARGA") & " "
            Debug.Write(descripcionItem)
            montoCalculo = 0
            'En caso en que el item sea calculable en planilla EXCEL
            If filaMovimiento("ES_CALCULABLE") = True Then
                'If filaMovimiento("ITEM_ALIAS") = "D0001" Then
                'Dim A As Integer
                'A = 1
                'End If
                montoCalculo = montoCalculado(tipoSistemaPrevisional, diasTrabajados, wb, empleado, periodo, filaMovimiento("CELDA_CALCULO"), totalImponible60)
                If filaMovimiento("ES_TRIBUTABLE") = True Then
                    totalTributable -= montoCalculo
                    totalleyesSocialesTope += montoCalculo
                    totalDescuentoTributable += montoCalculo
                    Debug.WriteLine("DEBER TRIBUTABLE CALCULADO (" & montoCalculo.ToString("C") & ")")
                Else
                    Debug.WriteLine("DEBER CALCULADO (" & montoCalculo.ToString("C") & ")")
                    totalOtrosDescuentos += montoCalculo
                End If
            Else
                montoCalculo = filaMovimiento("CANTIDAD")
                totalOtrosDescuentos += montoCalculo
                Debug.WriteLine("DEBER " & montoCalculo.ToString("C"))
            End If
            If reliquidacionBono Then
                insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, filaMovimiento("ITEM_ID"), Comun.TiposDeDatos.TipoItem.DEBERES, 0, montoCalculo, descripcionItem, 0, tipoProcesoRemun)
            Else
                insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, filaMovimiento("ITEM_ID"), Comun.TiposDeDatos.TipoItem.DEBERES, 0, montoCalculo, descripcionItem, 0, tipoProcesoRemun)
            End If
            totalDeberes += montoCalculo
        Next

        'BUSCA ITEMES BASE CALCULO
        '-------------------------------
        movPeriodo = empleado.movimientosDelPeriodo(periodo.ID, Comun.TiposDeDatos.TipoItem.BASE_CALCULO, tipoProcesoRemun, Comun.TiposDeDatos.IncluyeCalculoRemuneracion.SI_INCLUYE)
        filaMovimiento = Nothing
        For Each filaMovimiento In movPeriodo.Rows
            montoCalculo = filaMovimiento("CANTIDAD")
            descripcionItem = filaMovimiento("ITEM_ALIAS") & " " & filaMovimiento("DESCRIPCION_LARGA") & " "
            If reliquidacionBono Then
                insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, filaMovimiento("ITEM_ID"), Comun.TiposDeDatos.TipoItem.BASE_CALCULO, 0, montoCalculo, descripcionItem, 0, tipoProcesoRemun)
            Else
                insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, filaMovimiento("ITEM_ID"), Comun.TiposDeDatos.TipoItem.BASE_CALCULO, 0, montoCalculo, descripcionItem, 0, tipoProcesoRemun)
            End If
        Next


        'Calcula monto mutual de seguridad. Este valor no es descontado al empleado lo paga la Presidencia 
        Dim montoMutualSeguridad As Integer = 0
        If totalImponible60 > 0 Then
            montoMutualSeguridad = Math.Round(totalImponible60 * (periodo.porcentajeMensualInstitucionMutualSeguridad / 100), 0)
            If reliquidacionBono Then
                insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemMontoInstitucionMutualSeguridad, Comun.TiposDeDatos.TipoItem.OTROS, 0, montoMutualSeguridad, "MONTO MUTUAL DE SEGURIDAD", 0, tipoProcesoRemun, True)
                actualizaTotalBonos(liquidacionID_ENC, "MONTO_COTIZACION_MUTUAL", montoMutualSeguridad, tipoProcesoRemun)
            Else
                insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemMontoInstitucionMutualSeguridad, Comun.TiposDeDatos.TipoItem.OTROS, 0, montoMutualSeguridad, "MONTO MUTUAL DE SEGURIDAD", 0, tipoProcesoRemun, True)
                actualizaTotal(liquidacionID_ENC, "MONTO_COTIZACION_MUTUAL", montoMutualSeguridad, tipoProcesoRemun)
            End If
        End If

        'Calcula monto bonificación por retiro. Este valor no es descontado al empleado lo paga la Presidencia
        Dim montoAportes As Decimal = 0
        If periodo.aplicaBonifRetiro Then
            montoAportes = Math.Round(totalImponible90 * (periodo.porcentajeBonifRetiro / 100), 0)
            If reliquidacionBono Then
                insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemBonifRetiro, Comun.TiposDeDatos.TipoItem.OTROS, 0, montoAportes, "MONTO BONIFICACION POR RETIRO", 0, tipoProcesoRemun, True)
                actualizaTotalBonos(liquidacionID_ENC, "MONTO_BONIF_RETIRO", montoAportes, tipoProcesoRemun)
                actualizaTotalBonos(liquidacionID_ENC, "IMPONIBLE_90UF", totalImponible90, tipoProcesoRemun)
            Else
                insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemBonifRetiro, Comun.TiposDeDatos.TipoItem.OTROS, 0, montoAportes, "MONTO BONIFICACION POR RETIRO", 0, tipoProcesoRemun, True)
                actualizaTotal(liquidacionID_ENC, "MONTO_BONIF_RETIRO", montoAportes, tipoProcesoRemun)
                actualizaTotal(liquidacionID_ENC, "IMPONIBLE_90UF", totalImponible90, tipoProcesoRemun)
            End If
        End If

        'Calcula monto aporte institucional. 
        If periodo.aplicaAporteInstitucional And empleado.datosRemuneracion.afiliadoBienestar Then
            montoAportes = periodo.montoAporteInstitucional
            If reliquidacionBono Then
                insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemAporteInstitucional, Comun.TiposDeDatos.TipoItem.OTROS, 0, montoAportes, "MONTO APORTE INSTITUCIONAL", 0, tipoProcesoRemun, True)
                actualizaTotalBonos(liquidacionID_ENC, "MONTO_APORTE_INSTI", montoAportes, tipoProcesoRemun)
            Else
                If empleado.estadoEmpleadoID <> Comun.TiposDeDatos.TipoEstado.INACTIVO Then
                    insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemAporteInstitucional, Comun.TiposDeDatos.TipoItem.OTROS, 0, montoAportes, "MONTO APORTE INSTITUCIONAL", 0, tipoProcesoRemun, True)
                    actualizaTotal(liquidacionID_ENC, "MONTO_APORTE_INSTI", montoAportes, tipoProcesoRemun)
                End If
            End If
        End If

        'CALCULO PREVISIONAL SALUD
        '-------------------------
        Dim rtnMontoPlanAuge, rtnMontoSaludVoluntaria, rtnPlanPactado As Integer
        Dim rtnMontoSaludLegal As Integer = Math.Round(totalImponible60 * (0.070000000000000007), 0)
        Dim montoAdicionalVoluntarioSalud As Integer

        montoSalud = calculoPrevisionSALUD(empleado, empleado.datosSalud.montoConvenio, empleado.datosSalud.unidadConvenioId _
                   , empleado.datosSalud.montoPlanComplementario, empleado.datosSalud.unidadPlanComplementarioId _
                   , empleado.datosSalud.montoplanAuge, empleado.datosSalud.unidadPlanAugeId _
                   , totalImponible60, periodo, reliquidacionBono, tipoSistemaPrevisionalSalud, tipoSistemaPrevisional, rtnMontoPlanAuge, rtnMontoSaludVoluntaria, rtnPlanPactado)

        If (rtnPlanPactado + rtnMontoSaludVoluntaria) < rtnMontoSaludLegal Then
            rtnMontoSaludVoluntaria = 0
        End If
        If (rtnPlanPactado + rtnMontoPlanAuge) < rtnMontoSaludLegal Then
            Dim montoSaludDiferencia As Integer = rtnMontoSaludLegal - rtnMontoPlanAuge

            If reliquidacionBono Then
                insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemMontoConvenioSalud, Comun.TiposDeDatos.TipoItem.DEBERES, 0, montoSaludDiferencia, "DESCUENTO PLAN PACTADO SALUD", 0, tipoProcesoRemun, True)
                insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemMontoConvenioSalud, Comun.TiposDeDatos.TipoItem.DEBERES, 0, rtnMontoPlanAuge, "DESCUENTO PLAN AUGE", 0, tipoProcesoRemun, True)
            Else
                insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemMontoConvenioSalud, Comun.TiposDeDatos.TipoItem.DEBERES, 0, montoSaludDiferencia, "DESCUENTO PLAN PACTADO SALUD", 0, tipoProcesoRemun, True)
                insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemMontoConvenioSalud, Comun.TiposDeDatos.TipoItem.DEBERES, 0, rtnMontoPlanAuge, "DESCUENTO PLAN AUGE", 0, tipoProcesoRemun, True)
            End If
        Else
            If reliquidacionBono Then
                insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemMontoConvenioSalud, Comun.TiposDeDatos.TipoItem.DEBERES, 0, rtnPlanPactado, "DESCUENTO PLAN PACTADO SALUD", 0, tipoProcesoRemun, True)
                insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemMontoConvenioSalud, Comun.TiposDeDatos.TipoItem.DEBERES, 0, rtnMontoPlanAuge, "DESCUENTO PLAN AUGE", 0, tipoProcesoRemun, True)
            Else
                insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemMontoConvenioSalud, Comun.TiposDeDatos.TipoItem.DEBERES, 0, rtnPlanPactado, "DESCUENTO PLAN PACTADO SALUD", 0, tipoProcesoRemun, True)
                insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemMontoConvenioSalud, Comun.TiposDeDatos.TipoItem.DEBERES, 0, rtnMontoPlanAuge, "DESCUENTO PLAN AUGE", 0, tipoProcesoRemun, True)
            End If
        End If
        If reliquidacionBono Then
            insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemMontoPlanComplementarioSalud, Comun.TiposDeDatos.TipoItem.DEBERES, 0, rtnMontoSaludVoluntaria, "DESCUENTO PLAN COMPLEMENTARIO SALUD", 0, tipoProcesoRemun, True)
            insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalDescuentoSalud, Comun.TiposDeDatos.TipoItem.TOTAL, 0, montoSalud, "TOTAL DESCUENTO SALUD", 0, tipoProcesoRemun, True)
        Else
            insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemMontoPlanComplementarioSalud, Comun.TiposDeDatos.TipoItem.DEBERES, 0, rtnMontoSaludVoluntaria, "DESCUENTO PLAN COMPLEMENTARIO SALUD", 0, tipoProcesoRemun, True)
            insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalDescuentoSalud, Comun.TiposDeDatos.TipoItem.TOTAL, 0, montoSalud, "TOTAL DESCUENTO SALUD", 0, tipoProcesoRemun, True)
        End If

        'ACTUALIZACION DATOS SALUD - CACULO MÁS VER ARRIBA
        'Se guardan los datos de salud en el encabezado de la liquidacion. 
        'El objetivo de esto es facilitar la generación de informes, por ejemplo: Planilla Pago Cotizaciones Salud.

        If reliquidacionBono Then
            Dim montoConvenioSaludHistorico As Integer = empleado.recuperarLiquidacionEmpleadoItem(empleado.ID, periodo.itemMontoConvenioSalud, periodo.ID, "N")
            Dim montoTotalDesctoSaludHistorico As Integer = empleado.recuperarLiquidacionEmpleadoItem(empleado.ID, periodo.itemTotalDescuentoSalud, periodo.ID, "N")
            Dim institucionSaludActual As Integer = empleado.obtenerInstitucionSaludActual(empleado.ID)
            If rtnMontoSaludLegal > montoConvenioSaludHistorico Then
                actualizaTotalBonos(liquidacionID_ENC, "COT_LEGAL_SALUD_RETROACTIVO", (rtnMontoSaludLegal - montoConvenioSaludHistorico), tipoProcesoRemun)
            End If
            If montoSalud > montoTotalDesctoSaludHistorico Then
                actualizaTotalBonos(liquidacionID_ENC, "COT_PACTADA_SALUD_RETROACTIVO", (montoSalud - montoTotalDesctoSaludHistorico), tipoProcesoRemun)
            End If
            If (rtnMontoSaludLegal - montoConvenioSaludHistorico) + (montoSalud - montoTotalDesctoSaludHistorico) > 0 Then
                actualizaTotalBonos(liquidacionID_ENC, "COT_PLAN_COMPLEMENTARIO_SALUD_RETROACTIVO", rtnMontoSaludVoluntaria, tipoProcesoRemun)
                actualizaTotalBonos(liquidacionID_ENC, "INSTITUCION_SALUD_ID_RETROACTIVO", institucionSaludActual, tipoProcesoRemun)
            Else
                actualizaTotalBonos(liquidacionID_ENC, "INSTITUCION_SALUD_ID", empleado.datosSalud.institucionID, tipoProcesoRemun)
                actualizaTotalBonos(liquidacionID_ENC, "INSTITUCION_SALUD_ID_RETROACTIVO", institucionSaludActual, tipoProcesoRemun)
            End If
        Else
            actualizaTotal(liquidacionID_ENC, "COT_PACTADA_SALUD", montoSalud, tipoProcesoRemun)
            actualizaTotal(liquidacionID_ENC, "COT_LEGAL_SALUD", rtnMontoSaludLegal, tipoProcesoRemun)
            actualizaTotal(liquidacionID_ENC, "COT_PLAN_COMPLEMENTARIO_SALUD", rtnMontoSaludVoluntaria, tipoProcesoRemun)
            actualizaTotal(liquidacionID_ENC, "INSTITUCION_SALUD_ID", empleado.datosSalud.institucionID, tipoProcesoRemun)
        End If


        If (rtnPlanPactado + rtnMontoPlanAuge) > rtnMontoSaludLegal Then
            'Constituye la diferencia entre el 7% obligatorio y el aporte del empleado. (De acuerdo a su plan)
            montoAdicionalVoluntarioSalud = (rtnPlanPactado - rtnMontoSaludLegal + rtnMontoPlanAuge)
            If reliquidacionBono Then
                actualizaTotalBonos(liquidacionID_ENC, "COT_ADICIONAL_VOLUNTARIO_SALUD", montoAdicionalVoluntarioSalud + rtnMontoPlanAuge, tipoProcesoRemun)
            Else
                actualizaTotal(liquidacionID_ENC, "COT_ADICIONAL_VOLUNTARIO_SALUD", montoAdicionalVoluntarioSalud + rtnMontoPlanAuge, tipoProcesoRemun)
            End If
        End If

        If tipoSistemaPrevisionalSalud = "FON" Then 'Empleado afiliado a fonasa
            If reliquidacionBono Then
                actualizaTotalBonos(liquidacionID_ENC, "COTIZACION_FONASA_INP", montoSalud, tipoProcesoRemun)
            Else
                actualizaTotal(liquidacionID_ENC, "COTIZACION_FONASA_INP", montoSalud, tipoProcesoRemun)
            End If
        End If

        'Evalua si monto salud es menor al 7% legal
        If montoSalud < rtnMontoSaludLegal Then
            totalDeberes += rtnMontoSaludLegal
        Else
            totalDeberes += montoSalud
        End If

        Debug.WriteLine("============================================")

        Debug.WriteLine("PREVISION SALUD " & Chr(9) & montoSalud)

        Dim totalLeyesSociales As Integer = montoSalud
        Dim rtnAhorroAFP As Integer
        Dim rtnDescuentoLegal As Integer
        Dim rtnSeguroInvalidezSobr As Integer

        'CALCULO APV
        '------------
        Dim montoAhorroAPV As Integer = procesoCalculoAhorroAPV(empleado, periodo, liquidacionID_ENC, tipoProcesoRemun, totalImponible60, reliquidacionBono)
        If reliquidacionBono Then
            insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalDescuentoAPV, Comun.TiposDeDatos.TipoItem.TOTAL, 0, montoAhorroAPV, "TOTAL DESCUENTO APV", 0, tipoProcesoRemun, True)
        Else
            insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalDescuentoAPV, Comun.TiposDeDatos.TipoItem.TOTAL, 0, montoAhorroAPV, "TOTAL DESCUENTO APV", 0, tipoProcesoRemun, True)
        End If

        If montoAhorroAPV > 0 Then
            totalLeyesSociales += montoAhorroAPV
            'Solamente identifica que el empleado tiene a lo menos una institución APV
            If reliquidacionBono Then
                actualizaTotalBonos(liquidacionID_ENC, "MONTO_APV", montoAhorroAPV, tipoProcesoRemun)
            Else
                actualizaTotal(liquidacionID_ENC, "MONTO_APV", montoAhorroAPV, tipoProcesoRemun)
            End If
        End If

        totalDeberes += montoAhorroAPV

        'CALCULO PREVISIONAL AFP
        '-----------------------

        calculoPrevisionAFP(empleado, totalImponible60, rtnDescuentoLegal, rtnAhorroAFP, rtnSeguroInvalidezSobr, periodo, "NORMAL", empleado.datosPrevisionales.institucionID)

        'Si empleado está inactivo y el total imponible es igual a cero, entonces no se 
        'debe calcular las cotizaciones previsionales AFP.
        If Not (empleado.datosLaborales.estadoEmpleadoID = Comun.TiposDeDatos.TipoEstado.INACTIVO And periodo.estadoPeriodo = True) Then
            totalDeberes += rtnDescuentoLegal + rtnAhorroAFP
            totalTributable = totalTributable + ItemEsTributable(periodo.itemMontoCuentaAhorroAfp, rtnAhorroAFP)
        Else
            rtnAhorroAFP = 0
            totalDeberes += rtnDescuentoLegal
        End If

        If reliquidacionBono Then
            insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemMontoCotizacionLegalPrevisional, Comun.TiposDeDatos.TipoItem.DEBERES, 0, rtnDescuentoLegal, "DESCUENTO PREVISIONAL LEGAL", 0, tipoProcesoRemun, True)
            insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemMontoCuentaAhorroAfp, Comun.TiposDeDatos.TipoItem.DEBERES, 0, rtnAhorroAFP, "DESCUENTO AHORRO PREVISIONAL", 0, tipoProcesoRemun, True)
            insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemSeguroInvalidezSobrevivencia, Comun.TiposDeDatos.TipoItem.BASE_CALCULO, 0, rtnSeguroInvalidezSobr, "SEGURO INVALIDEZ Y SOBREVIVENCIA", 0, tipoProcesoRemun, True)
        Else
            insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemMontoCotizacionLegalPrevisional, Comun.TiposDeDatos.TipoItem.DEBERES, 0, rtnDescuentoLegal, "DESCUENTO PREVISIONAL LEGAL", 0, tipoProcesoRemun, True)
            insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemMontoCuentaAhorroAfp, Comun.TiposDeDatos.TipoItem.DEBERES, 0, rtnAhorroAFP, "DESCUENTO AHORRO PREVISIONAL", 0, tipoProcesoRemun, True)
            insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemSeguroInvalidezSobrevivencia, Comun.TiposDeDatos.TipoItem.BASE_CALCULO, 0, rtnSeguroInvalidezSobr, "SEGURO INVALIDEZ Y SOBREVIVENCIA", 0, tipoProcesoRemun, True)
        End If

        If tipoSistemaPrevisional = "AFP" Then
            If reliquidacionBono Then
                actualizaTotalBonos(liquidacionID_ENC, "DESC_LEGAL_AFP", rtnDescuentoLegal, tipoProcesoRemun)
                actualizaTotalBonos(liquidacionID_ENC, "MONTO_AHORRO_AFP", rtnAhorroAFP, tipoProcesoRemun)
                actualizaTotalBonos(liquidacionID_ENC, "MONTO_SEGURO_INVALIDEZ_SOBR", rtnSeguroInvalidezSobr, tipoProcesoRemun)
            Else
                actualizaTotal(liquidacionID_ENC, "DESC_LEGAL_AFP", rtnDescuentoLegal, tipoProcesoRemun)
                actualizaTotal(liquidacionID_ENC, "MONTO_AHORRO_AFP", rtnAhorroAFP, tipoProcesoRemun)
                actualizaTotal(liquidacionID_ENC, "MONTO_SEGURO_INVALIDEZ_SOBR", rtnSeguroInvalidezSobr, tipoProcesoRemun)
            End If
        Else
            If tipoSistemaPrevisional = "INP" Then
                If reliquidacionBono Then
                    actualizaTotalBonos(liquidacionID_ENC, "COTIZACION_OBLIGATORIA_INP", rtnDescuentoLegal, tipoProcesoRemun)
                    actualizaTotalBonos(liquidacionID_ENC, "DESC_LEGAL_AFP", rtnDescuentoLegal, tipoProcesoRemun)
                Else
                    actualizaTotal(liquidacionID_ENC, "COTIZACION_OBLIGATORIA_INP", rtnDescuentoLegal, tipoProcesoRemun)
                    actualizaTotal(liquidacionID_ENC, "DESC_LEGAL_AFP", rtnDescuentoLegal, tipoProcesoRemun)
                End If
            End If
        End If

        'Evaluación tope legal salud
        Dim valorUFSalud As Decimal = 0
        If tipoSistemaPrevisional = "INP" And tipoSistemaPrevisionalSalud = "ISA" Then
            valorUFSalud = periodo.ufMesAnterior
        Else
            valorUFSalud = periodo.UF
        End If
        'If (montoSalud) > Math.Round(periodo.topeSalud * valorUFSalud, 0) Then
        '    If tipoSistemaPrevisional = "INP" And tipoSistemaPrevisionalSalud = "ISA" Then
        '        totalleyesSocialesTope += Math.Round(periodo.topeSalud * periodo.ufMesAnterior, 0)
        '        totalTributable -= Math.Round(periodo.topeSalud * periodo.ufMesAnterior, 0)
        '    Else
        '        totalleyesSocialesTope += Math.Round(periodo.topeSalud * periodo.UF, 0)
        '        totalTributable -= Math.Round(periodo.topeSalud * periodo.UF, 0)
        '    End If
        'Else
        '    If rtnMontoSaludLegal < montoSalud Then
        '        totalTributable -= (montoSalud)
        '        totalleyesSocialesTope += montoSalud
        '    Else
        '        totalTributable -= (rtnMontoSaludLegal)
        '        totalleyesSocialesTope += rtnMontoSaludLegal
        '    End If
        'End If

        If (montoSalud) > Math.Round(periodo.topeSalud * valorUFSalud, 0) Then
            If tipoSistemaPrevisional = "INP" And tipoSistemaPrevisionalSalud = "ISA" Then
                Dim periodoAnterior As New Periodo
                periodoAnterior = New Periodo(periodo.ano, periodo.mes)
                If totalImponible60 >= (Math.Round(periodoAnterior.topeImponible1 * periodoAnterior.UF, 0)) Then
                    totalleyesSocialesTope += Math.Round(periodoAnterior.topeImponible1 * periodoAnterior.UF, 0) * periodoAnterior.topeSalud
                    totalTributable -= Math.Round(periodoAnterior.topeImponible1 * periodoAnterior.UF, 0) * periodoAnterior.topeSalud
                Else
                    totalleyesSocialesTope += rtnMontoSaludLegal
                    totalTributable -= rtnMontoSaludLegal
                End If

            Else
                totalleyesSocialesTope += Math.Round(periodo.topeSalud * valorUFSalud, 0)
                totalTributable -= Math.Round(periodo.topeSalud * valorUFSalud, 0)
            End If
        Else
            If rtnMontoSaludLegal < montoSalud Then
                totalTributable -= (montoSalud)
                totalleyesSocialesTope += montoSalud
            Else
                totalTributable -= (rtnMontoSaludLegal)
                totalleyesSocialesTope += rtnMontoSaludLegal
            End If
        End If

        Dim montoPrevisional As Integer = rtnDescuentoLegal + rtnAhorroAFP
        totalLeyesSociales += rtnDescuentoLegal
        totalleyesSocialesTope += rtnDescuentoLegal
        If reliquidacionBono Then
            Dim institucionPrevisionalActual As Integer = empleado.obtenerInstitucionPrevisionalActual(empleado.ID)
            insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalDescuentoPrevisional, Comun.TiposDeDatos.TipoItem.TOTAL, 0, montoPrevisional, "TOTAL DESCUENTO PROVISIONAL", 0, tipoProcesoRemun, True)
            insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalDescuentoLeyesSociales, Comun.TiposDeDatos.TipoItem.TOTAL, 0, totalLeyesSociales, "TOTAL DESCUENTO PROVISIONAL", 0, tipoProcesoRemun, True)
            actualizaTotalBonos(liquidacionID_ENC, "LEYES_SOCIALES", totalLeyesSociales, tipoProcesoRemun)
            actualizaTotalBonos(liquidacionID_ENC, "LEYES_SOCIALES_TOPE", totalleyesSocialesTope, tipoProcesoRemun)
            actualizaTotalBonos(liquidacionID_ENC, "AFP_ID", institucionPrevisionalActual, tipoProcesoRemun)
        Else
            insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalDescuentoPrevisional, Comun.TiposDeDatos.TipoItem.TOTAL, 0, montoPrevisional, "TOTAL DESCUENTO PROVISIONAL", 0, tipoProcesoRemun, True)
            insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalDescuentoLeyesSociales, Comun.TiposDeDatos.TipoItem.TOTAL, 0, totalLeyesSociales, "TOTAL DESCUENTO PROVISIONAL", 0, tipoProcesoRemun, True)
            actualizaTotal(liquidacionID_ENC, "LEYES_SOCIALES", totalLeyesSociales, tipoProcesoRemun)
            actualizaTotal(liquidacionID_ENC, "LEYES_SOCIALES_TOPE", totalleyesSocialesTope, tipoProcesoRemun)
            actualizaTotal(liquidacionID_ENC, "AFP_ID", empleado.datosPrevisionales.institucionID, tipoProcesoRemun)
        End If

        Debug.WriteLine("PREVISION AFP AHORRO " & Chr(9) & rtnAhorroAFP)
        Debug.WriteLine("PREVISION AFP DESC. LEGAL " & Chr(9) & rtnDescuentoLegal)
        Debug.WriteLine("PREVISION AFP TOTAL  " & Chr(9) & rtnDescuentoLegal + rtnAhorroAFP)

        totalTributable -= (rtnDescuentoLegal + ItemEsTributable(periodo.itemMontoAPV, montoAhorroAPV))

        'Cálculo de Impuesto segunda Categoría
        Dim montoImpuesto As Decimal = calculoImpuesto(totalTributable, periodo)
        Debug.WriteLine("IMPUESTO SEGUNDA CATEGORIA " & Chr(9) & montoImpuesto.ToString("C"))
        totalDeberes += Math.Round(montoImpuesto, 0)
        If reliquidacionBono Then
            insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalHaberes, Comun.TiposDeDatos.TipoItem.TOTAL, 0, totalHaberes, "TOTAL HABERES", 0, tipoProcesoRemun, True)
            insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemImpuestoUnico, Comun.TiposDeDatos.TipoItem.DEBERES, 0, montoImpuesto, "IMP IMPUESTO UNICO 2ª CAT.", 0, tipoProcesoRemun, True)
            insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalDeberes, Comun.TiposDeDatos.TipoItem.TOTAL, 0, totalDeberes, "TOTAL DEBERES", 0, tipoProcesoRemun, True)
            insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalImponible1, Comun.TiposDeDatos.TipoItem.TOTAL, 0, totalImponible60, "TOTAL IMPONIBLE 60 UF", 0, tipoProcesoRemun, True)
            insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalImponible2, Comun.TiposDeDatos.TipoItem.TOTAL, 0, totalImponible90, "TOTAL IMPONIBLE 90 UF", 0, tipoProcesoRemun, True)
            insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalTributable, Comun.TiposDeDatos.TipoItem.TOTAL, 0, totalTributable, "TOTAL TRIBUTABLE", 0, tipoProcesoRemun, True)
            actualizaTotalBonos(liquidacionID_ENC, "IMPONIBLE", totalImponible60, tipoProcesoRemun)
            actualizaTotalBonos(liquidacionID_ENC, "TRIBUTABLE", totalTributable, tipoProcesoRemun)
            actualizaTotalBonos(liquidacionID_ENC, "IMPUESTO_UNICO", montoImpuesto, tipoProcesoRemun)
            actualizaTotalBonos(liquidacionID_ENC, "DESCUENTO_TRIBUTABLE", totalDescuentoTributable, tipoProcesoRemun)
            actualizaTotalBonos(liquidacionID_ENC, "OTROS_DESCUENTOS", totalOtrosDescuentos, tipoProcesoRemun)
        Else
            insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalHaberes, Comun.TiposDeDatos.TipoItem.TOTAL, 0, totalHaberes, "TOTAL HABERES", 0, tipoProcesoRemun, True)
            insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemImpuestoUnico, Comun.TiposDeDatos.TipoItem.DEBERES, 0, montoImpuesto, "IMP IMPUESTO UNICO 2ª CAT.", 0, tipoProcesoRemun, True)
            insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalDeberes, Comun.TiposDeDatos.TipoItem.TOTAL, 0, totalDeberes, "TOTAL DEBERES", 0, tipoProcesoRemun, True)
            insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalImponible1, Comun.TiposDeDatos.TipoItem.TOTAL, 0, totalImponible60, "TOTAL IMPONIBLE 60 UF", 0, tipoProcesoRemun, True)
            insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalImponible2, Comun.TiposDeDatos.TipoItem.TOTAL, 0, totalImponible90, "TOTAL IMPONIBLE 90 UF", 0, tipoProcesoRemun, True)
            insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemTotalTributable, Comun.TiposDeDatos.TipoItem.TOTAL, 0, totalTributable, "TOTAL TRIBUTABLE", 0, tipoProcesoRemun, True)
            actualizaTotal(liquidacionID_ENC, "IMPONIBLE", totalImponible60, tipoProcesoRemun)
            actualizaTotal(liquidacionID_ENC, "TRIBUTABLE", totalTributable, tipoProcesoRemun)
            actualizaTotal(liquidacionID_ENC, "IMPUESTO_UNICO", montoImpuesto, tipoProcesoRemun)
            actualizaTotal(liquidacionID_ENC, "DESCUENTO_TRIBUTABLE", totalDescuentoTributable, tipoProcesoRemun)
            actualizaTotal(liquidacionID_ENC, "OTROS_DESCUENTOS", totalOtrosDescuentos, tipoProcesoRemun)
        End If

        Debug.WriteLine("TOTAL IMPONIBLE 60 " & Chr(9) & totalImponible60)
        Debug.WriteLine("TOTAL IMPONIBLE 90 " & Chr(9) & totalImponible90)
        Debug.WriteLine("TOTAL TRIBUTABLE " & Chr(9) & totalTributable)

        Dim liquidoPago As Integer = totalHaberes - totalDeberes
        If reliquidacionBono Then
            insertaLiquidacionBonos(liquidacionID_ENC, empleado.ID, periodo, periodo.itemLiquidoPago, Comun.TiposDeDatos.TipoItem.ENCABEZADO, 0, liquidoPago, "LIQUIDO A PAGO", 0, tipoProcesoRemun, True)
            actualizaTotalBonos(liquidacionID_ENC, "LIQUIDO", liquidoPago, tipoProcesoRemun)
        Else
            insertaLiquidacion(liquidacionID_ENC, empleado.ID, periodo, periodo.itemLiquidoPago, Comun.TiposDeDatos.TipoItem.ENCABEZADO, 0, liquidoPago, "LIQUIDO A PAGO", 0, tipoProcesoRemun, True)
            actualizaTotal(liquidacionID_ENC, "LIQUIDO", liquidoPago, tipoProcesoRemun)
        End If

        Debug.WriteLine("================================")
        Debug.WriteLine("TOTAL HABERES " & Chr(9) & totalHaberes.ToString("C"))

        If reliquidacionBono Then
            actualizaTotalBonos(liquidacionID_ENC, "HABERES", totalHaberes, tipoProcesoRemun)
            actualizaTotalBonos(liquidacionID_ENC, "EXENTO", totalExento, tipoProcesoRemun)
        Else
            actualizaTotal(liquidacionID_ENC, "HABERES", totalHaberes, tipoProcesoRemun)
            actualizaTotal(liquidacionID_ENC, "EXENTO", totalExento, tipoProcesoRemun)
        End If

        Debug.WriteLine("TOTAL DEBERES " & Chr(9) & totalDeberes.ToString("C"))
        Debug.WriteLine("LIQUIDO  " & liquidoPago.ToString("C"))
        Debug.WriteLine("================================")

        If tipoProcesoRemun = "S" Then
            empleado.CrearEmpleadoSuplementaria(periodo.ID, periodo.ID, empleado.ID, tipoProcesoRemun)
        End If
    End Sub

    Private Shared Sub GeneraItemsBase(empleado As Empleado, paramMensual As Periodo, ByVal tipoCalculo As String, liquidacionID_ENC As Integer, diasTrabajados As Integer)
        Dim porcentajeBase As Decimal = paramMensual.porcentajeBaseBono
        Dim porcentajeInstitucional As Decimal = paramMensual.porcentajeInstitucional
        Dim porcentajeColectivo As Decimal = paramMensual.porcentajeColectivo
        Dim generaItemBase As Boolean = True
        Dim montoBonoDesempeno As Integer = 0
        Dim montoBonoLey19553Art8 As Integer = 0
        Dim tipoProcesoRemun As String = "G"
        Dim descripcionItem As String
        Dim MontoZonaExtrema40 As Integer = 0
        Dim MontoZonaExtrema60 As Integer = 0
        Dim MontoBonoZonaExtrema As Integer = 0

        If empleado.generaItemsBonoModernizacion(empleado.ID, paramMensual.ID, paramMensual.itemBonoDesempenoMesActual, paramMensual.itemBonoLey19553Art8MesActual, _
                                                porcentajeBase, porcentajeInstitucional, porcentajeColectivo, _
                                                paramMensual.topeImponible1, paramMensual.UF, _
                                                paramMensual.itemTotalImponible1, paramMensual.ID, _
                                                0, 0, 0, _
                                                paramMensual.ufMesAnterior, tipoCalculo, tipoCalculo, empleado.datosRemuneracion.porcentajeLey19863, paramMensual.itemAsigLey19863MesActual, _
                                                empleado, paramMensual, generaItemBase, montoBonoDesempeno, montoBonoLey19553Art8, _
                                                paramMensual.aplicaAsignacionZona, MontoZonaExtrema40, MontoZonaExtrema60, MontoBonoZonaExtrema) = True Then

            Dim Item As New Item
            If montoBonoDesempeno > 0 Then
                Dim ItemRow As DataRow = Item.recuperraRegistroItem(paramMensual.itemBonoDesempenoMesActual)
                descripcionItem = ItemRow("ITEM_ALIAS") & " " & ItemRow("DESCRIPCION_LARGA") & " "
                Dim monto As Integer = calculoProporcionDiasTrabajados(montoBonoDesempeno, diasTrabajados)
                insertaLiquidacion(liquidacionID_ENC, empleado.ID, paramMensual, paramMensual.itemBonoDesempenoMesActual, Comun.TiposDeDatos.TipoItem.HABERES, 0, monto, descripcionItem, 0, tipoProcesoRemun)
            End If

            If montoBonoLey19553Art8 > 0 Then
                Dim ItemRow As DataRow = Item.recuperraRegistroItem(paramMensual.itemAsigLey19863MesActual)
                descripcionItem = ItemRow("ITEM_ALIAS") & " " & ItemRow("DESCRIPCION_LARGA") & " "
                Dim monto As Integer = calculoProporcionDiasTrabajados(montoBonoLey19553Art8, diasTrabajados)
                insertaLiquidacion(liquidacionID_ENC, empleado.ID, paramMensual, paramMensual.itemAsigLey19863MesActual, Comun.TiposDeDatos.TipoItem.HABERES, 0, monto, descripcionItem, 0, tipoProcesoRemun)
            End If

            If MontoZonaExtrema40 > 0 Then
                Dim ItemRow As DataRow = Item.recuperraRegistroItem(paramMensual.itemZonaExtremaImponible)
                descripcionItem = ItemRow("ITEM_ALIAS") & " " & ItemRow("DESCRIPCION_LARGA") & " "
                Dim monto As Integer = MontoZonaExtrema40
                insertaLiquidacion(liquidacionID_ENC, empleado.ID, paramMensual, paramMensual.itemZonaExtremaImponible, Comun.TiposDeDatos.TipoItem.HABERES, 0, monto, descripcionItem, 0, tipoProcesoRemun)
            End If

            If MontoZonaExtrema60 > 0 Then
                Dim ItemRow As DataRow = Item.recuperraRegistroItem(paramMensual.itemzonaExtremaNoImponible)
                descripcionItem = ItemRow("ITEM_ALIAS") & " " & ItemRow("DESCRIPCION_LARGA") & " "
                Dim monto As Integer = MontoZonaExtrema60
                insertaLiquidacion(liquidacionID_ENC, empleado.ID, paramMensual, paramMensual.itemzonaExtremaNoImponible, Comun.TiposDeDatos.TipoItem.HABERES, 0, monto, descripcionItem, 0, tipoProcesoRemun)
            End If

            If MontoBonoZonaExtrema > 0 Then
                Dim ItemRow As DataRow = Item.recuperraRegistroItem(paramMensual.itemBonificacionZonaExtremaImponible)
                descripcionItem = ItemRow("ITEM_ALIAS") & " " & ItemRow("DESCRIPCION_LARGA") & " "
                Dim monto As Integer = MontoBonoZonaExtrema
                insertaLiquidacion(liquidacionID_ENC, empleado.ID, paramMensual, paramMensual.itemBonificacionZonaExtremaImponible, Comun.TiposDeDatos.TipoItem.HABERES, 0, monto, descripcionItem, 0, tipoProcesoRemun)
            End If

        End If

    End Sub

    Public Shared Function calculoImpuesto(ByVal totalTributable As Integer, ByVal periodo As Periodo) As Decimal
        Dim da As New Data.SqlClient.SqlDataAdapter("SELECT * FROM RH_REM_IMPUESTO_2CATEGORIA WHERE PERIODO_ID=" & periodo.ID, Comun.ArgoConfiguracion.ConnectionString)
        Dim ds As New DataSet
        Dim dt As DataTable
        Dim fila As DataRow
        Dim valorRetorno As Decimal

        da.Fill(ds, "RH_REM_IMPUESTO_2CATEGORIA")
        dt = ds.Tables("RH_REM_IMPUESTO_2CATEGORIA")
        For Each fila In dt.Rows
            If totalTributable >= fila("DESDE") * periodo.UTM And totalTributable <= fila("HASTA") * periodo.UTM Then
                valorRetorno = Math.Round(((totalTributable * fila("FACTOR")) - (fila("REBAJA") * periodo.UTM)), 1)
            End If
        Next
        dt = Nothing
        ds = Nothing
        da = Nothing
        Return (valorRetorno)
    End Function
    Public Shared Function ItemEsTributable(ByVal iditem As Integer, ByVal monto As Integer) As Integer
        Dim mySelectQuery As String = "SELECT ES_TRIBUTABLE FROM RH_REM_ITEM WHERE ITEM_ID=" & iditem
        Dim myConnection As New SqlClient.SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim myCommand As New SqlClient.SqlCommand(mySelectQuery, myConnection)
        Dim esTributable As Boolean

        Try
            myConnection.Open()
            Dim myReader As SqlClient.SqlDataReader
            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                esTributable = myReader.GetBoolean(0)
            End While
            myReader.Close()
            myConnection.Close()
            If esTributable Then
                Return monto
            Else
                Return 0
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Function eliminaProcesoEmpleado(ByVal idEmpleado As Integer, ByVal idPeriodo As Integer, ByVal tipoCalculo As String) As Object
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        'Ejecución de limpieza de registros

        'P=Suplementaria Honorarios
        If tipoCalculo = "P" Then
            cmd = New SqlClient.SqlCommand("DELETE FROM RH_REM_LIQUIDACION_SUPLEMENTARIA WHERE EMPLEADO_ID=@EMPLEADO_ID AND TIPO_CALCULO=@TIPO_CALCULO AND PERIODO_ID=@PERIODO_ID; DELETE FROM RH_REM_LIQUIDACION_ENC_SUPLEMENTARIA WHERE EMPLEADO_ID=@EMPLEADO_ID AND TIPO_CALCULO=@TIPO_CALCULO AND PERIODO_ID=@PERIODO_ID;DELETE FROM RH_REM_LIQUIDACION_SUPLEMENTARIA WHERE EMPLEADO_ID=@EMPLEADO_ID AND TIPO_CALCULO=@TIPO_CALCULO_NORMAL AND PERIODO_ID=@PERIODO_ID; DELETE FROM RH_REM_LIQUIDACION_ENC_SUPLEMENTARIA WHERE EMPLEADO_ID=@EMPLEADO_ID AND TIPO_CALCULO=@TIPO_CALCULO_NORMAL AND PERIODO_ID=@PERIODO_ID")
        Else
            cmd = New SqlClient.SqlCommand("DELETE FROM RH_REM_LIQUIDACION WHERE EMPLEADO_ID=@EMPLEADO_ID AND (TIPO_CALCULO=@TIPO_CALCULO OR TIPO_CALCULO='G') AND PERIODO_ID=@PERIODO_ID; DELETE FROM RH_REM_LIQUIDACION_ENC WHERE EMPLEADO_ID=@EMPLEADO_ID AND TIPO_CALCULO=@TIPO_CALCULO AND PERIODO_ID=@PERIODO_ID")
        End If

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idEmpleado
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idPeriodo
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_CALCULO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = tipoCalculo
        cmd.Parameters.Add(prm)

        If tipoCalculo = "P" Then
            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@TIPO_CALCULO_NORMAL"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.VarChar
            prm.Value = "H"
            cmd.Parameters.Add(prm)
        End If

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function
    Public Shared Function totalHaberesAfectoAtraso(ByVal idempleado As Integer, ByVal idperiodo As Integer) As Integer
        Dim mySelectQuery As String = "SELECT SUM(RH_REM_LIQUIDACION.MONTO) AS MONTO " & _
                                        " FROM         RH_REM_LIQUIDACION INNER JOIN " & _
                                        " RH_REM_ITEM ON RH_REM_LIQUIDACION.ITEM_ID = RH_REM_ITEM.ITEM_ID " & _
                                        " WHERE (RH_REM_ITEM.TIPO_ITEM = 0) " & _
                                        " AND (RH_REM_ITEM.ES_ATRASO_INASISTENCIA = 1) " & _
                                        " AND (RH_REM_LIQUIDACION.EMPLEADO_ID = " & CType(idempleado, String) & ")" & _
                                        " AND (RH_REM_LIQUIDACION.PERIODO_ID = " & CType(idperiodo, String) & ")" & _
                                        " AND (RH_REM_LIQUIDACION.TIPO_CALCULO = 'N' OR RH_REM_LIQUIDACION.TIPO_CALCULO = 'G')"
        Dim myConnection As New SqlClient.SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim myCommand As New SqlClient.SqlCommand(mySelectQuery, myConnection)

        Try
            myConnection.Open()
            Dim myReader As SqlClient.SqlDataReader
            Dim valor As Integer
            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                valor = myReader.GetValue(0)
            End While
            myReader.Close()
            myConnection.Close()
            Return valor
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
