'Option Strict On
Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun


Public Class Periodo
    Public ID As Short
    Public estadoPeriodo As Boolean
    Public ano As Short
    Public mes As Byte
    Public anoMes As String
    Public UF As Decimal
    Public UTM As Decimal
    Public nombrePeriodo As String
    Public cantidadDiasMes As Short
    Public edadMinimaTrabajo As Byte
    Public anoInicialNacimento As Short
    Public horasTrabajadasDiasCompensados As Short
    Public numHrsExtrasDiarias As Short
    Public numHrsExtrasLegalDiurnas As Integer
    Public NumHrsExtrasLegalNocturnas As Integer
    Public porcentajeRecargaHrsExtDiurnas As Byte
    Public porcentajeRecargaHrsExtNocturnas As Byte
    Public porcentajeViatico As Integer
    Public porcentajeGastoRepresentacion As Byte
    Public descripcionPeriodo As String
    Public fechaPagoSueldo As Date
    Public itemDiasTrabajados As Integer
    Public topeSalud As Decimal
    Public topeImponible1 As Decimal
    Public topeImponible2 As Decimal
    Public observaciones As String
    Public nombreInstitucionMutualSeguridad As String
    Public codigoPreviredInstitucionMutualSeguridad As String
    Public porcentajeMensualInstitucionMutualSeguridad As Decimal
    Public itemMontoInstitucionMutualSeguridad As Integer
    Public nombreEmpresaSeguradora As String
    Public porcentajeSeguro1 As Decimal
    Public porcentajeSeguro2 As Decimal
    Public itemSeguro1 As Integer
    Public itemseguro2 As Integer
    Public itemSueldoBase As Integer
    Public itemResponsabilidadSuperior As Integer
    Public itemAsignacionFamiliar As Integer
    Public itemRetencionJudicial As Integer
    Public itemIncrementoPrevisional As Integer
    Public itemLey18566Salud As Integer
    Public itemLey18675Art10 As Integer
    Public itemLey18675Art11 As Integer
    Public itemLey19185Art18 As Integer
    Public itemLey19185Art19 As Integer
    Public itemLey3551 As Integer
    Public itemGastoRepresentacion As Integer
    Public itemLey18717 As Integer
    Public itemMontoFuncionCritica As Integer
    Public itemMontoCotizacionLegalPrevisional As Integer
    Public itemMontoCuentaAhorroAfp As Integer
    Public itemMontoCotizacionVoluntariaAFP As Integer
    Public itemTotalDescuentoPrevisional As Integer
    Public itemMontoConvenioSalud As Integer
    Public itemMontoPlanComplementarioSalud As Integer
    Public itemMontoPlanAuge As Integer
    Public itemTotalDescuentoSalud As Integer
    Public itemMontoAPV As Integer
    Public itemTotalDescuentoAPV As Integer
    Public itemTotalDescuentoLeyesSociales As Integer
    Public itemTotalTributable As Integer
    Public itemImpuestoUnico As Integer
    Public itemRetencion10 As Integer
    Public itemTotalImponible1 As Integer
    Public itemTotalImponible2 As Integer
    Public itemTotalHaberes As Integer
    Public itemTotalDeberes As Integer
    Public itemLiquidoPago As Integer
    Public itemHorasExtrasDiurnas As Integer
    Public itemHorasExtrasNocturnas As Integer
    Public itemAsignacionAntiguedad As Integer
    Public itemFondoBienestar As Integer
    Public porcentajeBaseBono As Decimal
    Public porcentajeInstitucional As Decimal
    Public porcentajeColectivo As Decimal
    Public procesaBonoModernizacion As Boolean
    Public itemBonoDesempenoMesActual As Integer
    Public itemBonoDesempenoMes1 As Integer
    Public itemBonoDesempenoMes2 As Integer
    Public itemBonoLey19553Art8MesActual As Integer
    Public itemBonoLey19553Art8Mes1 As Integer
    Public itemBonoLey19553Art8Mes2 As Integer
    Public itemBonoDesctoPrevisMes1 As Integer
    Public itemBonoDesctoPrevisMes2 As Integer
    Public itemBonoDesctoSaludMes1 As Integer
    Public itemBonoDesctoSaludMes2 As Integer
    Public itemBonoDesctoBienestarMes1 As Integer
    Public itemBonoDesctoBienestarMes2 As Integer
    Public itemBonoImpuestoUnicoMes1 As Integer
    Public itemBonoImpuestoUnicoMes2 As Integer
    Public porcentajeDesctoBienestar As Decimal
    Public porcentajeIncrementoPrevDL3501 As Decimal
    Public aplicaBonifRetiro As Boolean
    Public porcentajeBonifRetiro As Decimal
    Public itemBonifRetiro As Integer
    Public aplicaAporteInstitucional As Boolean
    Public montoAporteInstitucional As Decimal
    Public itemAporteInstitucional As Integer
    Public ufMesAnterior As Decimal
    Public itemBonoDistribucionBase As Integer
    Public itemBonoDistribucionInstitucional As Integer
    Public itemBonoDistribucionColectivo As Integer
    Public procesoSuplementarioCerrado As Boolean
    Public esProcesoSuplementario As Boolean
    Public itemAsociadoProcesoSuplementario As Integer
    Public copiasResolucion As String
    Public quienFirmaResolucion As Short
    Public itemAsigLey19863Mes1 As Integer
    Public itemAsigLey19863Mes2 As Integer
    Public itemAsigLey19863MesActual As Integer
    Public itemAtraso As Integer
    Public itemInasistencia As Integer
    Public calculoHorasExtrasMesAnterior As Boolean
    Public periodoIDHoraExtras As Integer
    Public fechaCierreRatificacionHoraExtras As Date
    Public calculoViaticoMesAnterior As Boolean
    Public periodoIDViatico As Integer
    Public aplicaDescuentoAtraso As Boolean
    Public aplicaDescuentoInasistenciaMedioDia As Boolean
    Public itemSeguroInvalidezSobrevivencia As Integer
    Public itemSeguroInvalidezSobrevivenciaMes1 As Integer
    Public itemSeguroInvalidezSobrevivenciaMes2 As Integer
    Public honorariosEnviadoTesoreria As Boolean
    Public porcentajeLegalEndeudamiento As Decimal
    Public procesoDefinitivoHorasExtras As Boolean
    Public itemAsignacionZona As Integer
    Public aplicaAsignacionZona As Boolean
    Public porcetnajeZonaExtremaNoImponible As Decimal
    Public itemZonaExtremaImponible As Integer
    Public itemzonaExtremaNoImponible As Integer
    Public itemBonificacionZonaExtremaImponible As Integer
    Public porcentajeBonoZonaExtrema As Decimal
    Public ItemDesahucio As Integer

    Private periodoDS As New DataAccess.ParametrosMensuales

    Public Sub New()
        MyBase.new()

        Dim periodoDR As DataAccess.DSParametroMensual.RH_REM_PERIODORow
        Me.ID = CType(periodoDS.BuscaIDPeriodoActivo(), Short)

        periodoDR = CType(periodoDS.Busca(Me.ID, Tablas.RH_REM_PERIODO), DataAccess.DSParametroMensual.RH_REM_PERIODORow)
        asignacionCampos(periodoDR)

        aplicaAsignacionZona = periodoDS.AplicaAsignacionZona()
    End Sub
    Public Sub New(ByVal anoProceso As Integer, ByVal mesProceso As Integer)
        MyBase.new()

        Dim periodoDR As DataAccess.DSParametroMensual.RH_REM_PERIODORow
        Me.ID = CType(periodoDS.BuscaIDOtrosPeriodos(anoProceso, mesProceso), Short)

        periodoDR = CType(periodoDS.Busca(Me.ID, Tablas.RH_REM_PERIODO), DataAccess.DSParametroMensual.RH_REM_PERIODORow)
        asignacionCampos(periodoDR)

        aplicaAsignacionZona = periodoDS.AplicaAsignacionZona()
    End Sub
    Public Sub New(ByVal idPeriodo As Integer)
        MyBase.new()

        Dim periodoDR As DataAccess.DSParametroMensual.RH_REM_PERIODORow
        Me.ID = CType(idPeriodo, Short)

        periodoDR = CType(periodoDS.Busca(Me.ID, Tablas.RH_REM_PERIODO), DataAccess.DSParametroMensual.RH_REM_PERIODORow)
        asignacionCampos(periodoDR)

        aplicaAsignacionZona = periodoDS.AplicaAsignacionZona()
    End Sub
    Private Sub asignacionCampos(ByVal dr As DataAccess.DSParametroMensual.RH_REM_PERIODORow)
        Dim meses() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
        If Not dr Is Nothing Then
            Me.estadoPeriodo = CType(dr("ESTADO_PERIODO"), Boolean)
            Me.ano = CType(dr("ANO"), Short)
            Me.mes = CType(dr("MES"), Byte)
            If Len(CType(dr("MES"), String)) = 1 Then
                Me.anoMes = CType(dr("ANO"), Short) & "-" & "0" & CType(CType(dr("MES"), Byte), String)
            Else
                Me.anoMes = CType(dr("ANO"), Short) & "-" & CType(dr("MES"), String)
            End If
            Me.nombrePeriodo = meses(CType(dr("MES"), Short) - 1) + " " + CType(dr("ANO"), String)
            Me.descripcionPeriodo = CType(dr("DESCRIPCION_PERIODO"), String)
            Me.UF = CType(dr("VALOR_UF"), Decimal)
            Me.UTM = CType(dr("VALOR_UTM"), Decimal)
            Me.fechaPagoSueldo = CType(dr("FECHA_PAGO_SUELDO"), Date)
            Me.topeImponible1 = CType(dr("TOPE_IMPONIBLE1"), Decimal)
            Me.topeImponible2 = CType(dr("TOPE_IMPONIBLE2"), Decimal)
            Me.topeSalud = CType(dr("PORCENTAJE_TOPE_SALUD"), Decimal)
            Me.itemSeguro1 = CType(dr("ITEM_SEGURO1_ID"), Integer)
            Me.itemseguro2 = CType(dr("ITEM_SEGURO2_ID"), Integer)
            Me.cantidadDiasMes = CType(dr("CANTIDAD_DIAS_MES"), Short)
            Me.nombreInstitucionMutualSeguridad = CType(dr("NOMBRE_INSTITUCION_MUTUAL_SEGURIDAD"), String)
            Me.porcentajeMensualInstitucionMutualSeguridad = CType(dr("PORCENTAJE_MENSUAL_INSTITUCION_SEGURIDAD"), Decimal)
            Me.porcentajeGastoRepresentacion = CType(dr("PORCENTAJE_GASTO_REPRESENTACION"), Byte)
            Me.itemMontoInstitucionMutualSeguridad = CType(dr("ITEM_MONTO_MUTUAL_SEGURIDAD_ID"), Integer)
            Me.itemDiasTrabajados = CType(dr("ITEM_DIAS_TRABAJADOS_ID"), Integer)
            Me.itemSueldoBase = CType(dr("ITEM_SUELDO_BASE_ID"), Integer)
            Me.itemResponsabilidadSuperior = CType(dr("ITEM_RESPONSABILIDAD_SUPERIOR_ID"), Integer)
            Me.itemAsignacionFamiliar = CType(dr("ITEM_ASIGNACION_FAMILIAR_ID"), Integer)
            Me.itemRetencionJudicial = CType(dr("ITEM_RETENCION_JUDICIAL_ID"), Integer)
            Me.itemIncrementoPrevisional = CType(dr("ITEM_INCREMENTO_PREVISIONAL_ID"), Integer)
            Me.itemLey18566Salud = CType(dr("ITEM_LEY_18566_SALUD_ID"), Integer)
            Me.itemLey18675Art10 = CType(dr("ITEM_LEY_18675_ART10_ID"), Integer)
            Me.itemLey18675Art11 = CType(dr("ITEM_LEY_18675_ART11_ID"), Integer)
            Me.itemLey19185Art18 = CType(dr("ITEM_LEY_19185_ART18_ID"), Integer)
            Me.itemLey19185Art19 = CType(dr("ITEM_LEY_19185_ART19_ID"), Integer)
            Me.itemGastoRepresentacion = CType(dr("ITEM_GASTO_REPRESENTACION_ID"), Integer)
            Me.itemLey18717 = CType(dr("ITEM_LEY18717_ID"), Integer)
            Me.itemMontoFuncionCritica = CType(dr("ITEM_MONTO_FUNCION_CRITICA_ID"), Integer)
            Me.itemMontoCotizacionLegalPrevisional = CType(dr("ITEM_MONTO_COTIZACION_LEGAL_PREVISIONAL_ID"), Integer)
            Me.itemMontoCuentaAhorroAfp = CType(dr("ITEM_MONTO_CUENTA_AHORRO_AFP_ID"), Integer)
            Me.itemMontoCotizacionVoluntariaAFP = CType(dr("ITEM_MONTO_COTIZACION_VOLUNATARIA_AFP_ID"), Integer)
            Me.itemTotalDescuentoPrevisional = CType(dr("ITEM_TOTAL_DESCUENTO_PREVISIONAL_ID"), Integer)
            Me.itemMontoConvenioSalud = CType(dr("ITEM_MONTO_CONVENIO_SALUD_ID"), Integer)
            Me.itemMontoPlanComplementarioSalud = CType(dr("ITEM_MONTO_PLAN_COMPLEMENTARIO_SALUD_ID"), Integer)
            Me.itemLey3551 = CType(dr("ITEM_LEY_3551"), Integer)
            Me.itemMontoPlanAuge = CType(dr("ITEM_MONTO_PLAN_AUGE_ID"), Integer)
            Me.itemTotalDescuentoSalud = CType(dr("ITEM_TOTAL_DESCUENTO_SALUD_ID"), Integer)
            Me.itemMontoAPV = CType(dr("ITEM_MONTO_APV_ID"), Integer)
            Me.itemTotalDescuentoAPV = CType(dr("ITEM_TOTAL_DESCUENTO_APV_ID"), Integer)
            Me.itemTotalDescuentoLeyesSociales = CType(dr("ITEM_TOTAL_DESCUENTO_LEYES_SOCIALES_ID"), Integer)
            Me.itemTotalTributable = CType(dr("ITEM_TOTAL_TRIBUTABLE_ID"), Integer)
            Me.itemImpuestoUnico = CType(dr("ITEM_IMPUESTO_UNICO_ID"), Integer)
            Me.itemRetencion10 = CType(dr("ITEM_RETENCION_10_ID"), Integer)
            Me.itemTotalImponible1 = CType(dr("ITEM_TOTAL_IMPONIBLE1_ID"), Integer)
            Me.itemTotalImponible2 = CType(dr("ITEM_TOTAL_IMPONIBLE2_ID"), Integer)
            Me.itemTotalHaberes = CType(dr("ITEM_TOTAL_HABERES_ID"), Integer)
            Me.itemTotalDeberes = CType(dr("ITEM_TOTAL_DEBERES_ID"), Integer)
            Me.itemLiquidoPago = CType(dr("ITEM_LIQUIDO_PAGO_ID"), Integer)
            Me.itemHorasExtrasDiurnas = CType(dr("ITEM_HORAS_EXTRAS_DIURNAS_ID"), Integer)
            Me.itemHorasExtrasNocturnas = CType(dr("ITEM_HORAS_EXTRAS_NOCTURNAS_ID"), Integer)
            Me.itemAsignacionAntiguedad = CType(dr("ITEM_ASIGNACION_ANTIGUEDAD_ID"), Integer)
            Me.itemFondoBienestar = CType(dr("ITEM_FONDO_BIENESTAR_ID"), Integer)
            Me.porcentajeBaseBono = CType(dr("PORCENTAJE_BASE_BONO"), Decimal)
            Me.porcentajeInstitucional = CType(dr("PORCENTAJE_INSTITUCIONAL_BONO"), Decimal)
            Me.porcentajeColectivo = CType(dr("PORCENTAJE_COLECTIVO_BONO"), Decimal)
            Me.procesaBonoModernizacion = CType(dr("PROCESO_BONO_MODERNIZACION"), Boolean)
            Me.itemBonoDesempenoMesActual = CType(dr("ITEM_ASIG_DESEMPENO_MES_ACTUAL"), Integer)
            Me.itemBonoDesempenoMes1 = CType(dr("ITEM_ASIG_DESEMPENO_MES1"), Integer)
            Me.itemBonoDesempenoMes2 = CType(dr("ITEM_ASIG_DESEMPENO_MES2"), Integer)
            Me.itemBonoLey19553Art8MesActual = CType(dr("ITEM_ASIG_LEY19553_ART8_MES_ACTUAL"), Integer)
            Me.itemBonoLey19553Art8Mes1 = CType(dr("ITEM_ASIG_LEY19553_ART8_MES1"), Integer)
            Me.itemBonoLey19553Art8Mes2 = CType(dr("ITEM_ASIG_LEY19553_ART8_MES2"), Integer)
            Me.itemBonoDesctoPrevisMes1 = CType(dr("ITEM_DESCTO_PREVIS_DESEMPENO_MES1"), Integer)
            Me.itemBonoDesctoPrevisMes2 = CType(dr("ITEM_DESCTO_PREVIS_DESEMPENO_MES2"), Integer)
            Me.itemBonoDesctoSaludMes1 = CType(dr("ITEM_DESCTO_SALUD_DESEMPENO_MES1"), Integer)
            Me.itemBonoDesctoSaludMes2 = CType(dr("ITEM_DESCTO_SALUD_DESEMPENO_MES2"), Integer)
            Me.itemBonoDesctoBienestarMes1 = CType(dr("ITEM_DESCTO_BIENESTAR_MES1"), Integer)
            Me.itemBonoDesctoBienestarMes2 = CType(dr("ITEM_DESCTO_BIENESTAR_MES2"), Integer)
            Me.itemBonoImpuestoUnicoMes1 = CType(dr("ITEM_IMPTO_UNICO_DESEMPENO_MES1"), Integer)
            Me.itemBonoImpuestoUnicoMes2 = CType(dr("ITEM_IMPTO_UNICO_DESEMPENO_MES2"), Integer)
            Me.porcentajeDesctoBienestar = CType(dr("PORCENTAJE_DESCTO_BIENESTAR"), Decimal)
            Me.porcentajeIncrementoPrevDL3501 = CType(dr("PORCENTAJE_INCREMENTO_PREVIS_DL3501"), Decimal)
            Me.aplicaBonifRetiro = CType(dr("APLICA_BONIFICACION_RETIRO"), Boolean)
            Me.porcentajeBonifRetiro = CType(dr("PORCENTAJE_BONIF_RETIRO"), Decimal)
            Me.itemBonifRetiro = CType(dr("ITEM_BONIFICACION_RETIRO"), Integer)
            Me.aplicaAporteInstitucional = CType(dr("APLICA_APORTE_INSTITUCIONAL"), Boolean)
            Me.montoAporteInstitucional = CType(dr("MONTO_APORTE_INSTITUCIONAL"), Decimal)
            Me.itemAporteInstitucional = CType(dr("ITEM_APORTE_INSTITUCIONAL"), Integer)
            Me.ufMesAnterior = CType(dr("UF_MES_ANTERIOR"), Decimal)
            Me.itemBonoDistribucionBase = CType(dr("ITEM_BASE_BONO_MODERNIZ"), Integer)
            Me.itemBonoDistribucionInstitucional = CType(dr("ITEM_INSTITUCIONAL_BONO_MODERNIZ"), Integer)
            Me.itemBonoDistribucionColectivo = CType(dr("ITEM_COLECTIVO_BONO_MODERNIZ"), Integer)
            Me.numHrsExtrasLegalDiurnas = CType(dr("HORAS_EXTRAS_LEGAL_DIURNAS"), Integer)
            If CType(dr("CIERRE_SUPLEMENTARIO"), Integer) = 0 Then
                Me.procesoSuplementarioCerrado = False
            Else
                Me.procesoSuplementarioCerrado = True
            End If
            Me.porcentajeViatico = CType(dr("PORCENTAJE_VIATICO"), Integer)
            Me.esProcesoSuplementario = CType(dr("ES_PROCESO_SUPLEMENTARIO"), Boolean)
            Me.itemAsociadoProcesoSuplementario = CType(dr("ITEM_ASOCIADO_PROCESO_SUPLEMENTARIO"), Integer)
            Me.copiasResolucion = CType(dr("COPIAS_RESOLUCION"), String)
            Me.quienFirmaResolucion = CType(dr("QUIEN_FIRMA_RESOLUCION"), Short)
            Me.itemAsigLey19863Mes1 = CType(dr("ITEM_ASIG_LEY19863_MES1"), Integer)
            Me.itemAsigLey19863Mes2 = CType(dr("ITEM_ASIG_LEY19863_MES2"), Integer)
            Me.itemAsigLey19863MesActual = CType(dr("ITEM_ASIG_LEY19863_MES_ACTUAL"), Integer)
            Me.itemAtraso = CType(dr("ITEM_ATRASO"), Integer)
            Me.itemInasistencia = CType(dr("ITEM_INASISTENCIA"), Integer)
            Me.calculoHorasExtrasMesAnterior = CType(dr("CALCULO_HORAS_EXTRAS_MES_ANTERIOR"), Boolean)
            Me.periodoIDHoraExtras = CType(dr("PERIODO_ID_HORA_EXTRA"), Integer)
            Me.fechaCierreRatificacionHoraExtras = CType(dr("FECHA_CIERRE_RATIFICACION_HORA_EXTRA"), Date)
            Me.calculoViaticoMesAnterior = CType(dr("CALCULO_VIATICO_MES_ANTERIOR"), Boolean)
            Me.periodoIDViatico = CType(dr("PERIODO_ID_VIATICO"), Integer)
            Me.aplicaDescuentoAtraso = CType(dr("APLICA_DESCUENTO_ATRASO"), Boolean)
            Me.aplicaDescuentoInasistenciaMedioDia = CType(dr("APLICA_DESCUENTO_INASISTENCIA_MEDIO_DIA"), Boolean)
            Me.porcentajeLegalEndeudamiento = CType(dr("PORCENTAJE_LEGAL_ENDEUDAMIENTO"), Decimal)
            Try
                Me.itemSeguroInvalidezSobrevivencia = CType(dr("ITEM_DESCUENTO_SIS"), Integer)
            Catch ex As Exception
                Me.itemSeguroInvalidezSobrevivencia = 0
            End Try
            Try
                Me.itemSeguroInvalidezSobrevivenciaMes1 = CType(dr("ITEM_DESCUENTO_SIS_MES1"), Integer)
            Catch ex As Exception
                Me.itemSeguroInvalidezSobrevivenciaMes1 = 0
            End Try
            Try
                Me.itemSeguroInvalidezSobrevivenciaMes2 = CType(dr("ITEM_DESCUENTO_SIS_MES2"), Integer)
            Catch ex As Exception
                Me.itemSeguroInvalidezSobrevivenciaMes2 = 0
            End Try
            Try
                Me.honorariosEnviadoTesoreria = CType(dr("HONORARIOS_ENVIADO_TESORERIA"), Boolean)
            Catch ex As Exception
                Me.honorariosEnviadoTesoreria = 0
            End Try

            Try
                Me.itemZonaExtremaImponible = CType(dr("ITEM_ZONA_EXTREMA_IMPONIBLE"), Integer)
            Catch ex As Exception
                Me.itemZonaExtremaImponible = 0
            End Try

            Try
                Me.itemzonaExtremaNoImponible = CType(dr("ITEM_ZONA_EXTREMA_NO_IMPONIBLE"), Integer)
            Catch ex As Exception
                Me.itemzonaExtremaNoImponible = 0
            End Try

            Try
                Me.itemBonificacionZonaExtremaImponible = CType(dr("ITEM_BONIFICACION_ZONA_EXTREMA_IMPONIBLE"), Integer)
            Catch ex As Exception
                Me.itemBonificacionZonaExtremaImponible = 0
            End Try

            Try
                Me.porcentajeBonoZonaExtrema = CType(dr("PORCENTAJE_BONO_ZONA_EXTREMA"), Decimal)
            Catch ex As Exception
                Me.porcentajeBonoZonaExtrema = 0
            End Try

            'agregado por segegob
            Try
                Me.procesoDefinitivoHorasExtras = CType(dr("PROCESO_DEFINITIVO_HORAS_EXTRAS"), Boolean)
            Catch ex As Exception
            End Try

            Me.itemAsignacionZona = CType(dr("ITEM_ID_ASIGNACION_ZONA"), Integer)

            Try
                Me.ItemDesahucio = CType(dr("ITEM_DESAHUCIO"), Integer)
            Catch ex As Exception
            End Try

        End If
    End Sub

End Class