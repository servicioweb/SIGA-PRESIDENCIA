Option Strict On
Imports System.ComponentModel
Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.Comun.TiposDeDatos

Public Class Item
    Public Id As Integer
    Public tipoItem As Short
    Public estado As Boolean
    Public codigo As String
    Public descripcionLarga As String
    Public descripcionCorta As String
    Public esImponible As Boolean
    Public esTributable As Boolean
    Public esCalculable As Boolean
    Public esCosto As Boolean
    Public esCuentaContabFinanzas As Boolean
    Public esCuentaContabPresupuesto As Boolean
    Public esPermanente As Boolean
    Public esImprimible As Boolean
    Public esItemBienestar As Boolean
    Public secuenciaImpresion As Integer
    Public itemAsociado As Integer
    Public glosa As String
    Public numeroCuentaContabFinanzas As String
    Public numeroCuentaContabPresupuesto As String
    Public imputacion As Boolean
    Public columnaLibroAudit1 As Byte
    Public columnaLibroAudit2 As Byte
    Public columnaLibroOficial As Byte
    Public esProporcinalDiasTrabajados As Boolean
    Public correspondeBonoModernidad As Boolean
    Public esImponibleMesHistorico As Boolean
    Public esTributableMesHistorico As Boolean
    Public traspasaDiferenciaMovtoMensual As Boolean
    Public codigoItemExterno As Integer
    Public codigoAplicacionExterna As Integer
    Public nombreProcedencia As String
    Public nombreCeldaExcel As String
    Public esAtrasoInasistencia As Boolean
    Public esCostoPresupuesto As Boolean
    Public esAplicableAHonorario As Boolean
    Public permiteGeneracionMasiva As Boolean

    Dim dsItem As New DataAccess.Itemes

    Public Sub New()
        MyBase.new()
    End Sub

    Public ReadOnly Property dvDatosItemes() As DataView
        Get
            Return recuperaItemes()
        End Get
    End Property
    Private Function recuperaItemes() As DataView
        'Se rescatan todas las definiciones de los itemes
        Return (dsItem.recuperarItemes())
    End Function
    Public Function recuperaItemRelacionado() As DataView
        'Se rescatan todas las definiciones de los itemes
        Return (dsItem.recuperaItemsRelacionado())
    End Function
    Public Function recuperaItemsTramosRelacionado(RelacionCabeceraId As Integer, PeriodoId As Integer) As DataView
        'Se rescatan todas las definiciones de los itemes
        Return (dsItem.recuperaItemsTramosRelacionado(RelacionCabeceraId, PeriodoId))
    End Function
    Public Function recuperaMontosAsignadosSegunTramos(RelacionCabeceraId As Integer, PeriodoId As Integer) As DataView
        'Se rescatan todas las definiciones de los itemes
        Return (dsItem.recuperaMontosAsignadosSegunTramos(RelacionCabeceraId, PeriodoId))
    End Function
    Public Function recuperaItemesCentralizacion(ByVal itemID As Integer, ByVal periodoID As Integer) As DataView
        'Se rescatan desde centralización itemes
        Return (dsItem.recuperarItemesCentralizacion(itemID, periodoID))
    End Function
    Public Function recuperaDetalleItemEndeudamiento() As DataView
        Return (dsItem.recuperarDetalleItemEndeudamiento)
    End Function
    Public Function BuscaCodigoItem(ByVal codigo As String) As Boolean
        If dsItem.Busca("SELECT ITEM_ID FROM " & Tablas.RH_REM_ITEM & " WHERE RTRIM(ITEM_ALIAS)=" & CType(RTrim(codigo), String)) > 0 Then
            Return False
        End If
        Return True
    End Function
    Public Function Crear() As Long
        Dim ItemDR As DataAccess.ParametrosMensuales.RH_REM_ITEMRow
        ItemDR = CType(dsItem.Tables(Tablas.RH_REM_ITEM).NewRow, DataAccess.ParametrosMensuales.RH_REM_ITEMRow)
        asignacionCampos(Me, ItemDR)
        ItemDR = CType(dsItem.Insertar(ItemDR), DataAccess.ParametrosMensuales.RH_REM_ITEMRow)
        Return (ItemDR.ITEM_ID)
    End Function
    Public Function actualizarItemesCentralizacion() As Boolean
        Return (dsItem.actualizaItemesCentralizacion())
    End Function
    Public Function Actualizar() As Boolean
        Dim ItemDR As DataAccess.ParametrosMensuales.RH_REM_ITEMRow
        ItemDR = CType(dsItem.Busca(Me.Id, Tablas.RH_REM_ITEM, "SELECT * FROM " & Tablas.RH_REM_ITEM), DataAccess.ParametrosMensuales.RH_REM_ITEMRow)
        Try
            asignacionCampos(Me, ItemDR)
            ItemDR = CType(dsItem.Actualizar(ItemDR), DataAccess.ParametrosMensuales.RH_REM_ITEMRow)
            Return True
        Catch ex As Exception
            Return (False)
        End Try
    End Function
    Public Function ActualizarItemEndeudamiento(ByVal ItemId As Integer, ByVal TipoEndeudamientoId As Integer, ByVal Vigente As Boolean) As Boolean
        Try
            Return dsItem.ActualizarItemEndeudamiento(ItemId, TipoEndeudamientoId, Vigente)
        Catch ex As Exception
            Return (False)
        End Try
    End Function
    Public Function ActualizarItemTramos(ByVal idRelacionCabecera As Integer, idPeriodo As Integer, NombreTramo As String, MontoDesde As Integer, MontoHasta As Integer, MontoAsignado As Integer, iDRelacionTramo As Integer) As Boolean
        Try
            Return dsItem.ActualizarItemTramos(idRelacionCabecera, idPeriodo, NombreTramo, MontoDesde, MontoHasta, MontoAsignado, iDRelacionTramo)
        Catch ex As Exception
            Return (False)
        End Try
    End Function
    Public Function Eliminar(ByVal Valor_id As Integer) As Boolean
        Try
            dsItem.Elimina(SQL.STORE_PROCEDURES.ELIMINA_DEFINICION_ITEM & " " & Valor_id)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function

    Public Function recuperraRegistroItem(ByVal ID_Item As Long) As DataRow
        Return dsItem.recuperaRegistroItem(ID_Item)
    End Function

    Private Sub asignacionCampos(ByVal item As BusinessRules.Item, ByRef ItemDR As DataAccess.ParametrosMensuales.RH_REM_ITEMRow)
        With ItemDR
            .ORGANIZACION_ID = CType(Comun.ArgoConfiguracion.OrganizacionID, Byte)
            .TIPO_ITEM = CType(item.tipoItem, Byte)
            .ITEM_ALIAS = item.codigo
            .ESTADO_REGISTRO = item.estado
            .DESCRIPCION_LARGA = item.descripcionLarga
            .DESCRIPCION_CORTA = item.descripcionCorta
            .ES_IMPONIBLE = item.esImponible
            .ES_TRIBUTABLE = item.esTributable
            .ES_CALCULABLE = item.esCalculable
            .ES_COSTO = item.esCosto
            '.ES_CUENTA_CONTABLE_FINANZAS = item.esCuentaContabFinanzas
            '.ES_CUENTA_CONTABLE_PRESUPUESTO = item.esCuentaContabPresupuesto
            .ES_PERMANENTE = item.esPermanente
            .ES_IMPRIMIBLE_EN_LIQUIDACION = item.esImprimible
            .ES_ITEM_BIENESTAR = item.esItemBienestar
            .SECUENCIA_IMPRESION = CType(item.secuenciaImpresion, Short)
            '.ITEM_ASOCIADO = CType(item.itemAsociado, Integer)
            '.GLOSA = item.glosa
            '.CUENTA_CONTABLE_FINANZAS = item.numeroCuentaContabFinanzas
            '.CUENTA_CONTABLE_PRESUPUESTO = item.numeroCuentaContabPresupuesto
            '.IMPUTACION = item.imputacion
            .COLUMNA_LIBRO_AUDITORIA_1 = item.columnaLibroAudit1
            .COLUMNA_LIBRO_AUDITORIA_2 = item.columnaLibroAudit2
            .COLUMNA_LIBRO_OFICIAL = item.columnaLibroOficial
            .ES_PROPORCIONAL_DIAS_TRABAJADOS = item.esProporcinalDiasTrabajados
            .ES_RELIQUIDACION_BONO = item.correspondeBonoModernidad
            .ES_IMPONIBLE_MES_HISTORICO = item.esImponibleMesHistorico
            .ES_TRIBUTABLE_MES_HISTORICO = item.esTributableMesHistorico
            .TRASPASA_DIFERENCIA_MOVTO_MENSUAL = item.traspasaDiferenciaMovtoMensual
            .CODIGO_EXTERNO = item.codigoItemExterno
            If item.codigoAplicacionExterna = Nothing Or item.codigoAplicacionExterna = -1 Then
                '.CODIGO_APLICACION = Nothing
            Else
                .CODIGO_APLICACION = item.codigoAplicacionExterna
            End If

            .APLICACION = item.nombreProcedencia
            .CELDA_CALCULO = item.nombreCeldaExcel
            .ES_ATRASO_INASISTENCIA = item.esAtrasoInasistencia
            .ES_APLICABLE_HONORARIO = item.esAplicableAHonorario
            .ES_COSTO_PRESUP = item.esCostoPresupuesto
            .PERMITE_GENERACION_MASIVA = item.permiteGeneracionMasiva
        End With
    End Sub

End Class
