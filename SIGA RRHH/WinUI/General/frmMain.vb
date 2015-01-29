Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Reportes
Imports System.Security.Principal
Imports System.Security
Imports System.Threading
Imports cl.presidencia.Seguridad


Public Class frmMain
    Inherits System.Windows.Forms.Form
  

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents MnuModuloPersonal As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCargaGrupoFamiliar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEventosAdministrativos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCapacitación As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCalificacion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRemuneracion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuControlViaticos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHojaVidaLaboral As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSalir As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLicenciaMedica As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFeriadoLegal As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPermisoAdministrativoConGoce As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPermisoAdministrativoSinGoce As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPermisoPaternal As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHorasExtras As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCambiaSituacionLaboral As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMaestroEmpleado As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFichaEmpleado As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAntecedenteCurricular As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAntecedenteAcademico As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDefinicionItem As System.Windows.Forms.MenuItem
    Friend WithEvents mnuParametrosMensuales As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMovimientoMensual As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMantencionItem As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMantencionEmpleado As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuListadoPersonal As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLstAntiguedad As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCalculoSueldo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCalculoHonorarios As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCalculoContrataPlanta As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAcercaDe As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGeneraArchivos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuNominaBanco As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrevired As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRemInformes As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCierreMensual As System.Windows.Forms.MenuItem
    Friend WithEvents mnuItemRelacionado As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHistoriaEventoAdmin As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEUS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBonoModernizacion As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCalculoBonoModernizacion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDetalleBonoModernización As System.Windows.Forms.MenuItem
    Friend WithEvents mnuImportarTransacciones As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRptResoluciones As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRptResHorasExtras As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLiquidacionPlantaContrata As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuResumenes As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLstFuncionarios As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCargaFamiliar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGrupoFamiliar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRptResumenPagoPrevisional As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLstCargasFamiliaresVencen As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBienestar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBeneficiosMedicos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrestamos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCasaComerciales As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInformes As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRptResumenPagoPrevisionalAPV As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBarPrincipal As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanelServer As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanelBaseDato As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanelPeriodoVigente As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanelBlanco1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanelUserName As System.Windows.Forms.StatusBarPanel
    Friend WithEvents mnuMantenedor As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDepto As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSuplementaria As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCalculoSuplementaria As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDiferenicaSuplementaria As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRptAporteBienestar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRptBonificacionRetiro As System.Windows.Forms.MenuItem
    Friend WithEvents mnuIsapres As System.Windows.Forms.MenuItem
    Friend WithEvents mnuVentanas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCascada As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMHorizontal As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMVertical As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBarVentanaActiva As System.Windows.Forms.StatusBarPanel
    Friend WithEvents mnuRptInformeValorizadoCargasFam As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRegHorasExtras As System.Windows.Forms.MenuItem
    Friend WithEvents mnuResHorasExtras As System.Windows.Forms.MenuItem
    Friend WithEvents mnuActualizaCargasFamHaciaFichaEmpleado As System.Windows.Forms.MenuItem
    Friend WithEvents MnuBancos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuUbicacion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuContable As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPresupuesto As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRetiro As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEstudio As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCarga As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAPV As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGrado As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCalidadJuridica As System.Windows.Forms.MenuItem
    Friend WithEvents mnuClasificacion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAFP As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCentralizacionContable As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCierreProcesos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCierreSuplementario As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRetiroEmpleado As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRemInformesDinamicos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAnalisisLiquidaciones As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMovimientoMensualBienestar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMantencionItemBienestar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMantencionMovEmpleadoBienestar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRecalculoBono As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDiferenciaBono As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInformesDinamicosPersonal As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAnalisisMaestroEmpleadoDIPRES As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInformeDinámicoSaldosEventosAdm As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAnalisisMovimientosEventosAdministrativos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAnalisisMaestroEmpleadoDetallado As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAnalisisCargasFamiliares As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLstFuncionariosFoto As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPerInformes As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRentaAnual As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReajusteAnual As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEmisionCertificadoRentaAnual As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReajusteEUS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReajusteMovimientos As System.Windows.Forms.MenuItem
    Friend WithEvents menuAnalisisMovimientoMensual As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCompraDatosIntranevsFichaEmpleado As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOrganizacion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGeneraAsientoContable As System.Windows.Forms.MenuItem
    Friend WithEvents mnuControlAsistenciaDepartamento As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGeneraResumenPagoMensualHorasExttras As System.Windows.Forms.MenuItem
    Friend WithEvents mnuControlAsistenciaEmpleado As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRegistrarMarcasFaltantes As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTraspasarMarcasyHorasExtras As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInformeDinamicoRatificacionHorasExtras As System.Windows.Forms.MenuItem
    Friend WithEvents mnuControlAsistencia As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSeguroInvalidezSobrev As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAnalisisDinamicoViaticos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRegistroCheques As System.Windows.Forms.MenuItem
    Friend WithEvents mnuChequeEmision As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInformeDinamicoAtraso As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAnalisisHorasExtrasCompensadas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuIngresoHorasAprobadasPorDepto As System.Windows.Forms.MenuItem
    Friend WithEvents mnuResHorasExtrasAprobadas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHorasExtrasRatificadasLiquidadas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPermisoDuelo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAnalisisPersonalFueraDotacion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCuadroComparativoHonorarios As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInformeCurricular As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPresupuestoAnualHonorarios As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPersonalFueraDotacion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCuadroComparativoHono As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPresupuestoAnualHonorario As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInformeCurri As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLicenciaInformeGestion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHonorarios As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMantencionMovEmpleadoHonorario As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSuplementariaHonorario As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCalculoSuplementarioHonorario As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSuplementariaHonorarioDiferenciaPagar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGestionLicenciasMedicas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTesoreria As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEmisionMemorandumViatico As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRendicionViatico As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEnviarTesoreria As System.Windows.Forms.MenuItem
    Friend WithEvents mnuChequesHonorarios As System.Windows.Forms.MenuItem
    Friend WithEvents mnuProfesionOficio As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAprobaciones As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAprobarPagoBienio As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInformeHonorarioDetallado As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGeneraAsientoPresupuesto As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEnviarEmpleadoHonorarioDexon As System.Windows.Forms.MenuItem
    Friend WithEvents mnuItemsEndeudamiento As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEndeudamientoEmpleado As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMantenedorFestivos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuControlCapacitacion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCrearCapacitacion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAsignarParticipantes As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGeneraMovimiento As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGeneraItemMasivo As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCapacitacionesPorEmpleado As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCapacitacionesPorAno As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLiquidacionPorEmpleado As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFichaHistoricaEmpleado As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGeneraAsignaciones As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFirmaLiquidacion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInformeCalculoLicenciaMedica As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInformeHorasAtraso As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInformeHorasExtrasNoRatificadas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEndeudamientoEmpleadoRem As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.MnuModuloPersonal = New System.Windows.Forms.MenuItem()
        Me.mnuMaestroEmpleado = New System.Windows.Forms.MenuItem()
        Me.mnuFichaEmpleado = New System.Windows.Forms.MenuItem()
        Me.mnuFichaHistoricaEmpleado = New System.Windows.Forms.MenuItem()
        Me.mnuAntecedenteCurricular = New System.Windows.Forms.MenuItem()
        Me.mnuAntecedenteAcademico = New System.Windows.Forms.MenuItem()
        Me.mnuCompraDatosIntranevsFichaEmpleado = New System.Windows.Forms.MenuItem()
        Me.mnuEnviarEmpleadoHonorarioDexon = New System.Windows.Forms.MenuItem()
        Me.mnuCargaGrupoFamiliar = New System.Windows.Forms.MenuItem()
        Me.mnuCargaFamiliar = New System.Windows.Forms.MenuItem()
        Me.mnuGrupoFamiliar = New System.Windows.Forms.MenuItem()
        Me.mnuRptInformeValorizadoCargasFam = New System.Windows.Forms.MenuItem()
        Me.mnuActualizaCargasFamHaciaFichaEmpleado = New System.Windows.Forms.MenuItem()
        Me.mnuEventosAdministrativos = New System.Windows.Forms.MenuItem()
        Me.mnuFeriadoLegal = New System.Windows.Forms.MenuItem()
        Me.mnuPermisoAdministrativoConGoce = New System.Windows.Forms.MenuItem()
        Me.mnuPermisoAdministrativoSinGoce = New System.Windows.Forms.MenuItem()
        Me.mnuPermisoPaternal = New System.Windows.Forms.MenuItem()
        Me.mnuPermisoDuelo = New System.Windows.Forms.MenuItem()
        Me.mnuHistoriaEventoAdmin = New System.Windows.Forms.MenuItem()
        Me.mnuHorasExtras = New System.Windows.Forms.MenuItem()
        Me.mnuGeneraResumenPagoMensualHorasExttras = New System.Windows.Forms.MenuItem()
        Me.mnuRegHorasExtras = New System.Windows.Forms.MenuItem()
        Me.mnuAnalisisHorasExtrasCompensadas = New System.Windows.Forms.MenuItem()
        Me.mnuIngresoHorasAprobadasPorDepto = New System.Windows.Forms.MenuItem()
        Me.mnuResHorasExtras = New System.Windows.Forms.MenuItem()
        Me.mnuResHorasExtrasAprobadas = New System.Windows.Forms.MenuItem()
        Me.mnuInformeHorasAtraso = New System.Windows.Forms.MenuItem()
        Me.mnuInformeHorasExtrasNoRatificadas = New System.Windows.Forms.MenuItem()
        Me.mnuHorasExtrasRatificadasLiquidadas = New System.Windows.Forms.MenuItem()
        Me.mnuControlViaticos = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.mnuRegistroCheques = New System.Windows.Forms.MenuItem()
        Me.mnuAnalisisDinamicoViaticos = New System.Windows.Forms.MenuItem()
        Me.mnuControlCapacitacion = New System.Windows.Forms.MenuItem()
        Me.mnuCrearCapacitacion = New System.Windows.Forms.MenuItem()
        Me.mnuAsignarParticipantes = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.mnuCapacitacionesPorEmpleado = New System.Windows.Forms.MenuItem()
        Me.mnuCapacitacionesPorAno = New System.Windows.Forms.MenuItem()
        Me.mnuHojaVidaLaboral = New System.Windows.Forms.MenuItem()
        Me.mnuCambiaSituacionLaboral = New System.Windows.Forms.MenuItem()
        Me.mnuRetiroEmpleado = New System.Windows.Forms.MenuItem()
        Me.mnuPerInformes = New System.Windows.Forms.MenuItem()
        Me.mnuListadoPersonal = New System.Windows.Forms.MenuItem()
        Me.mnuLstAntiguedad = New System.Windows.Forms.MenuItem()
        Me.mnuLstFuncionarios = New System.Windows.Forms.MenuItem()
        Me.mnuLstFuncionariosFoto = New System.Windows.Forms.MenuItem()
        Me.mnuLstCargasFamiliaresVencen = New System.Windows.Forms.MenuItem()
        Me.mnuEmisionCertificadoRentaAnual = New System.Windows.Forms.MenuItem()
        Me.mnuInformesDinamicosPersonal = New System.Windows.Forms.MenuItem()
        Me.mnuAnalisisMaestroEmpleadoDIPRES = New System.Windows.Forms.MenuItem()
        Me.mnuInformeDinámicoSaldosEventosAdm = New System.Windows.Forms.MenuItem()
        Me.mnuAnalisisMovimientosEventosAdministrativos = New System.Windows.Forms.MenuItem()
        Me.mnuAnalisisMaestroEmpleadoDetallado = New System.Windows.Forms.MenuItem()
        Me.mnuAnalisisCargasFamiliares = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.mnuPersonalFueraDotacion = New System.Windows.Forms.MenuItem()
        Me.mnuCuadroComparativoHono = New System.Windows.Forms.MenuItem()
        Me.mnuPresupuestoAnualHonorario = New System.Windows.Forms.MenuItem()
        Me.mnuInformeHonorarioDetallado = New System.Windows.Forms.MenuItem()
        Me.mnuInformeCurri = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.mnuSalir = New System.Windows.Forms.MenuItem()
        Me.mnuRemuneracion = New System.Windows.Forms.MenuItem()
        Me.mnuDefinicionItem = New System.Windows.Forms.MenuItem()
        Me.mnuParametrosMensuales = New System.Windows.Forms.MenuItem()
        Me.mnuMovimientoMensual = New System.Windows.Forms.MenuItem()
        Me.mnuMantencionItem = New System.Windows.Forms.MenuItem()
        Me.mnuMantencionEmpleado = New System.Windows.Forms.MenuItem()
        Me.menuAnalisisMovimientoMensual = New System.Windows.Forms.MenuItem()
        Me.mnuGeneraMovimiento = New System.Windows.Forms.MenuItem()
        Me.mnuItemRelacionado = New System.Windows.Forms.MenuItem()
        Me.mnuGeneraItemMasivo = New System.Windows.Forms.MenuItem()
        Me.mnuCalculoSueldo = New System.Windows.Forms.MenuItem()
        Me.mnuCalculoContrataPlanta = New System.Windows.Forms.MenuItem()
        Me.mnuSuplementaria = New System.Windows.Forms.MenuItem()
        Me.mnuCalculoSuplementaria = New System.Windows.Forms.MenuItem()
        Me.mnuDiferenicaSuplementaria = New System.Windows.Forms.MenuItem()
        Me.mnuBonoModernizacion = New System.Windows.Forms.MenuItem()
        Me.mnuCalculoBonoModernizacion = New System.Windows.Forms.MenuItem()
        Me.mnuDetalleBonoModernización = New System.Windows.Forms.MenuItem()
        Me.mnuRecalculoBono = New System.Windows.Forms.MenuItem()
        Me.mnuDiferenciaBono = New System.Windows.Forms.MenuItem()
        Me.mnuReajusteAnual = New System.Windows.Forms.MenuItem()
        Me.mnuReajusteEUS = New System.Windows.Forms.MenuItem()
        Me.mnuReajusteMovimientos = New System.Windows.Forms.MenuItem()
        Me.mnuHonorarios = New System.Windows.Forms.MenuItem()
        Me.mnuCalculoHonorarios = New System.Windows.Forms.MenuItem()
        Me.mnuSuplementariaHonorario = New System.Windows.Forms.MenuItem()
        Me.mnuMantencionMovEmpleadoHonorario = New System.Windows.Forms.MenuItem()
        Me.mnuCalculoSuplementarioHonorario = New System.Windows.Forms.MenuItem()
        Me.mnuSuplementariaHonorarioDiferenciaPagar = New System.Windows.Forms.MenuItem()
        Me.mnuEnviarTesoreria = New System.Windows.Forms.MenuItem()
        Me.mnuGeneraAsignaciones = New System.Windows.Forms.MenuItem()
        Me.mnuGeneraArchivos = New System.Windows.Forms.MenuItem()
        Me.mnuNominaBanco = New System.Windows.Forms.MenuItem()
        Me.mnuPrevired = New System.Windows.Forms.MenuItem()
        Me.mnuRemInformes = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.mnuLiquidacionPlantaContrata = New System.Windows.Forms.MenuItem()
        Me.mnuLiquidacionPorEmpleado = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.mnuSeguroInvalidezSobrev = New System.Windows.Forms.MenuItem()
        Me.mnuRptBonificacionRetiro = New System.Windows.Forms.MenuItem()
        Me.mnuRptAporteBienestar = New System.Windows.Forms.MenuItem()
        Me.mnuRptResoluciones = New System.Windows.Forms.MenuItem()
        Me.mnuRptResHorasExtras = New System.Windows.Forms.MenuItem()
        Me.mnuResumenes = New System.Windows.Forms.MenuItem()
        Me.mnuRptResumenPagoPrevisional = New System.Windows.Forms.MenuItem()
        Me.mnuRptResumenPagoPrevisionalAPV = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.mnuRemInformesDinamicos = New System.Windows.Forms.MenuItem()
        Me.mnuCentralizacionContable = New System.Windows.Forms.MenuItem()
        Me.mnuAnalisisLiquidaciones = New System.Windows.Forms.MenuItem()
        Me.mnuCierreProcesos = New System.Windows.Forms.MenuItem()
        Me.mnuCierreMensual = New System.Windows.Forms.MenuItem()
        Me.mnuCierreSuplementario = New System.Windows.Forms.MenuItem()
        Me.mnuGeneraAsientoContable = New System.Windows.Forms.MenuItem()
        Me.mnuGeneraAsientoPresupuesto = New System.Windows.Forms.MenuItem()
        Me.mnuEUS = New System.Windows.Forms.MenuItem()
        Me.mnuImportarTransacciones = New System.Windows.Forms.MenuItem()
        Me.mnuRentaAnual = New System.Windows.Forms.MenuItem()
        Me.mnuItemsEndeudamiento = New System.Windows.Forms.MenuItem()
        Me.mnuEndeudamientoEmpleadoRem = New System.Windows.Forms.MenuItem()
        Me.mnuBienestar = New System.Windows.Forms.MenuItem()
        Me.mnuBeneficiosMedicos = New System.Windows.Forms.MenuItem()
        Me.mnuPrestamos = New System.Windows.Forms.MenuItem()
        Me.mnuCasaComerciales = New System.Windows.Forms.MenuItem()
        Me.mnuInformes = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.mnuMovimientoMensualBienestar = New System.Windows.Forms.MenuItem()
        Me.mnuMantencionItemBienestar = New System.Windows.Forms.MenuItem()
        Me.mnuMantencionMovEmpleadoBienestar = New System.Windows.Forms.MenuItem()
        Me.mnuEndeudamientoEmpleado = New System.Windows.Forms.MenuItem()
        Me.mnuMantenedor = New System.Windows.Forms.MenuItem()
        Me.mnuDepto = New System.Windows.Forms.MenuItem()
        Me.mnuIsapres = New System.Windows.Forms.MenuItem()
        Me.MnuBancos = New System.Windows.Forms.MenuItem()
        Me.mnuUbicacion = New System.Windows.Forms.MenuItem()
        Me.mnuContable = New System.Windows.Forms.MenuItem()
        Me.mnuPresupuesto = New System.Windows.Forms.MenuItem()
        Me.mnuRetiro = New System.Windows.Forms.MenuItem()
        Me.mnuEstudio = New System.Windows.Forms.MenuItem()
        Me.mnuProfesionOficio = New System.Windows.Forms.MenuItem()
        Me.mnuCarga = New System.Windows.Forms.MenuItem()
        Me.mnuAPV = New System.Windows.Forms.MenuItem()
        Me.mnuGrado = New System.Windows.Forms.MenuItem()
        Me.mnuCalidadJuridica = New System.Windows.Forms.MenuItem()
        Me.mnuClasificacion = New System.Windows.Forms.MenuItem()
        Me.mnuAFP = New System.Windows.Forms.MenuItem()
        Me.mnuOrganizacion = New System.Windows.Forms.MenuItem()
        Me.mnuMantenedorFestivos = New System.Windows.Forms.MenuItem()
        Me.mnuControlAsistencia = New System.Windows.Forms.MenuItem()
        Me.mnuTraspasarMarcasyHorasExtras = New System.Windows.Forms.MenuItem()
        Me.mnuRegistrarMarcasFaltantes = New System.Windows.Forms.MenuItem()
        Me.mnuControlAsistenciaDepartamento = New System.Windows.Forms.MenuItem()
        Me.mnuControlAsistenciaEmpleado = New System.Windows.Forms.MenuItem()
        Me.mnuInformeDinamicoRatificacionHorasExtras = New System.Windows.Forms.MenuItem()
        Me.mnuInformeDinamicoAtraso = New System.Windows.Forms.MenuItem()
        Me.mnuGestionLicenciasMedicas = New System.Windows.Forms.MenuItem()
        Me.mnuLicenciaMedica = New System.Windows.Forms.MenuItem()
        Me.mnuLicenciaInformeGestion = New System.Windows.Forms.MenuItem()
        Me.mnuInformeCalculoLicenciaMedica = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.mnuVentanas = New System.Windows.Forms.MenuItem()
        Me.mnuCascada = New System.Windows.Forms.MenuItem()
        Me.mnuMHorizontal = New System.Windows.Forms.MenuItem()
        Me.mnuMVertical = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.mnuAcercaDe = New System.Windows.Forms.MenuItem()
        Me.mnuCalificacion = New System.Windows.Forms.MenuItem()
        Me.mnuCapacitación = New System.Windows.Forms.MenuItem()
        Me.mnuTesoreria = New System.Windows.Forms.MenuItem()
        Me.mnuEmisionMemorandumViatico = New System.Windows.Forms.MenuItem()
        Me.mnuRendicionViatico = New System.Windows.Forms.MenuItem()
        Me.mnuChequeEmision = New System.Windows.Forms.MenuItem()
        Me.mnuChequesHonorarios = New System.Windows.Forms.MenuItem()
        Me.mnuAprobaciones = New System.Windows.Forms.MenuItem()
        Me.mnuAprobarPagoBienio = New System.Windows.Forms.MenuItem()
        Me.mnuFirmaLiquidacion = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.mnuAnalisisPersonalFueraDotacion = New System.Windows.Forms.MenuItem()
        Me.mnuCuadroComparativoHonorarios = New System.Windows.Forms.MenuItem()
        Me.StatusBarPrincipal = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanelUserName = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanelServer = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanelBaseDato = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanelBlanco1 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanelPeriodoVigente = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarVentanaActiva = New System.Windows.Forms.StatusBarPanel()
        Me.mnuInformeCurricular = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        CType(Me.StatusBarPanelUserName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanelServer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanelBaseDato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanelBlanco1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanelPeriodoVigente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarVentanaActiva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuModuloPersonal, Me.mnuRemuneracion, Me.mnuBienestar, Me.mnuMantenedor, Me.mnuControlAsistencia, Me.mnuGestionLicenciasMedicas, Me.mnuVentanas, Me.MenuItem1, Me.mnuCalificacion, Me.mnuCapacitación, Me.mnuTesoreria, Me.mnuAprobaciones})
        '
        'MnuModuloPersonal
        '
        Me.MnuModuloPersonal.Index = 0
        Me.MnuModuloPersonal.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMaestroEmpleado, Me.mnuCargaGrupoFamiliar, Me.mnuEventosAdministrativos, Me.mnuHorasExtras, Me.mnuControlViaticos, Me.mnuControlCapacitacion, Me.mnuHojaVidaLaboral, Me.mnuCambiaSituacionLaboral, Me.mnuRetiroEmpleado, Me.mnuPerInformes, Me.mnuInformesDinamicosPersonal, Me.MenuItem5, Me.mnuSalir})
        Me.MnuModuloPersonal.Text = "&Personal"
        '
        'mnuMaestroEmpleado
        '
        Me.mnuMaestroEmpleado.Index = 0
        Me.mnuMaestroEmpleado.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFichaEmpleado, Me.mnuFichaHistoricaEmpleado, Me.mnuAntecedenteCurricular, Me.mnuAntecedenteAcademico, Me.mnuCompraDatosIntranevsFichaEmpleado, Me.mnuEnviarEmpleadoHonorarioDexon})
        Me.mnuMaestroEmpleado.Text = "Empleados"
        '
        'mnuFichaEmpleado
        '
        Me.mnuFichaEmpleado.Index = 0
        Me.mnuFichaEmpleado.Text = "Ficha del Empleado"
        '
        'mnuFichaHistoricaEmpleado
        '
        Me.mnuFichaHistoricaEmpleado.Index = 1
        Me.mnuFichaHistoricaEmpleado.Text = "Ficha Histórica del Empleado"
        '
        'mnuAntecedenteCurricular
        '
        Me.mnuAntecedenteCurricular.Index = 2
        Me.mnuAntecedenteCurricular.Text = "Antecedentes Curriculares"
        '
        'mnuAntecedenteAcademico
        '
        Me.mnuAntecedenteAcademico.Index = 3
        Me.mnuAntecedenteAcademico.Text = "Antecedentes Académicos"
        '
        'mnuCompraDatosIntranevsFichaEmpleado
        '
        Me.mnuCompraDatosIntranevsFichaEmpleado.Index = 4
        Me.mnuCompraDatosIntranevsFichaEmpleado.Text = "Compara Datos Intranet vs Ficha Empleado"
        '
        'mnuEnviarEmpleadoHonorarioDexon
        '
        Me.mnuEnviarEmpleadoHonorarioDexon.Index = 5
        Me.mnuEnviarEmpleadoHonorarioDexon.Text = "Enviar Empleado Honorario a Dexon"
        '
        'mnuCargaGrupoFamiliar
        '
        Me.mnuCargaGrupoFamiliar.Index = 1
        Me.mnuCargaGrupoFamiliar.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCargaFamiliar, Me.mnuGrupoFamiliar, Me.mnuRptInformeValorizadoCargasFam, Me.mnuActualizaCargasFamHaciaFichaEmpleado})
        Me.mnuCargaGrupoFamiliar.Text = "&Cargas Familiares y Grupo"
        '
        'mnuCargaFamiliar
        '
        Me.mnuCargaFamiliar.Index = 0
        Me.mnuCargaFamiliar.Text = "Carga Familiar"
        '
        'mnuGrupoFamiliar
        '
        Me.mnuGrupoFamiliar.Index = 1
        Me.mnuGrupoFamiliar.Text = "Grupo Familiar"
        '
        'mnuRptInformeValorizadoCargasFam
        '
        Me.mnuRptInformeValorizadoCargasFam.Index = 2
        Me.mnuRptInformeValorizadoCargasFam.Text = "Informe Valorizado Cargas Familiares"
        '
        'mnuActualizaCargasFamHaciaFichaEmpleado
        '
        Me.mnuActualizaCargasFamHaciaFichaEmpleado.Index = 3
        Me.mnuActualizaCargasFamHaciaFichaEmpleado.Text = "Actualiza Cargas Familiares en Ficha Empleado"
        '
        'mnuEventosAdministrativos
        '
        Me.mnuEventosAdministrativos.Index = 2
        Me.mnuEventosAdministrativos.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFeriadoLegal, Me.mnuPermisoAdministrativoConGoce, Me.mnuPermisoAdministrativoSinGoce, Me.mnuPermisoPaternal, Me.mnuPermisoDuelo, Me.mnuHistoriaEventoAdmin})
        Me.mnuEventosAdministrativos.Text = "&Eventos Administrativos"
        '
        'mnuFeriadoLegal
        '
        Me.mnuFeriadoLegal.Index = 0
        Me.mnuFeriadoLegal.Text = "&Feriado Legal"
        '
        'mnuPermisoAdministrativoConGoce
        '
        Me.mnuPermisoAdministrativoConGoce.Index = 1
        Me.mnuPermisoAdministrativoConGoce.Text = "&Permiso Días Administrativo"
        '
        'mnuPermisoAdministrativoSinGoce
        '
        Me.mnuPermisoAdministrativoSinGoce.Index = 2
        Me.mnuPermisoAdministrativoSinGoce.Text = "Permiso Sin &Goce Sueldo"
        '
        'mnuPermisoPaternal
        '
        Me.mnuPermisoPaternal.Index = 3
        Me.mnuPermisoPaternal.Text = "P&ermiso Paternal"
        '
        'mnuPermisoDuelo
        '
        Me.mnuPermisoDuelo.Index = 4
        Me.mnuPermisoDuelo.Text = "Permiso por Duelo"
        '
        'mnuHistoriaEventoAdmin
        '
        Me.mnuHistoriaEventoAdmin.Index = 5
        Me.mnuHistoriaEventoAdmin.Text = "&Hoja de Vida Eventos Administrativos"
        '
        'mnuHorasExtras
        '
        Me.mnuHorasExtras.Index = 3
        Me.mnuHorasExtras.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuGeneraResumenPagoMensualHorasExttras, Me.mnuRegHorasExtras, Me.mnuAnalisisHorasExtrasCompensadas, Me.mnuIngresoHorasAprobadasPorDepto, Me.mnuResHorasExtras, Me.mnuResHorasExtrasAprobadas, Me.mnuInformeHorasAtraso, Me.mnuInformeHorasExtrasNoRatificadas, Me.mnuHorasExtrasRatificadasLiquidadas})
        Me.mnuHorasExtras.Text = "Control H&oras Extras"
        '
        'mnuGeneraResumenPagoMensualHorasExttras
        '
        Me.mnuGeneraResumenPagoMensualHorasExttras.Index = 0
        Me.mnuGeneraResumenPagoMensualHorasExttras.Text = "Genera Resumen Pago Mensual Horas Exttras"
        '
        'mnuRegHorasExtras
        '
        Me.mnuRegHorasExtras.Index = 1
        Me.mnuRegHorasExtras.Text = "Registro/Consulta Horas Extras"
        '
        'mnuAnalisisHorasExtrasCompensadas
        '
        Me.mnuAnalisisHorasExtrasCompensadas.Index = 2
        Me.mnuAnalisisHorasExtrasCompensadas.Text = "Análisis Horas Extras y Compensadas"
        '
        'mnuIngresoHorasAprobadasPorDepto
        '
        Me.mnuIngresoHorasAprobadasPorDepto.Index = 3
        Me.mnuIngresoHorasAprobadasPorDepto.Text = "Ingreso Horas Extras Planificadas por Departamento"
        '
        'mnuResHorasExtras
        '
        Me.mnuResHorasExtras.Index = 4
        Me.mnuResHorasExtras.Text = "Informe Resolución Horas Extras"
        '
        'mnuResHorasExtrasAprobadas
        '
        Me.mnuResHorasExtrasAprobadas.Index = 5
        Me.mnuResHorasExtrasAprobadas.Text = "Informe Resolución Horas Extras Aprobadas"
        '
        'mnuInformeHorasAtraso
        '
        Me.mnuInformeHorasAtraso.Index = 6
        Me.mnuInformeHorasAtraso.Text = "Informe Horas Atraso por Rango Fecha"
        '
        'mnuInformeHorasExtrasNoRatificadas
        '
        Me.mnuInformeHorasExtrasNoRatificadas.Index = 7
        Me.mnuInformeHorasExtrasNoRatificadas.Text = "Informe Horas Extras No Ratificadas"
        '
        'mnuHorasExtrasRatificadasLiquidadas
        '
        Me.mnuHorasExtrasRatificadasLiquidadas.Index = 8
        Me.mnuHorasExtrasRatificadasLiquidadas.Text = "Horas Extras Ratificadas vs Liquidadas"
        '
        'mnuControlViaticos
        '
        Me.mnuControlViaticos.Index = 4
        Me.mnuControlViaticos.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem23, Me.mnuRegistroCheques, Me.mnuAnalisisDinamicoViaticos})
        Me.mnuControlViaticos.Text = "Control de &Viáticos"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 0
        Me.MenuItem21.Text = "Registro de Viáticos"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 1
        Me.MenuItem23.Text = "Emisión de Cheque"
        Me.MenuItem23.Visible = False
        '
        'mnuRegistroCheques
        '
        Me.mnuRegistroCheques.Index = 2
        Me.mnuRegistroCheques.Text = "Registro de Cheques"
        '
        'mnuAnalisisDinamicoViaticos
        '
        Me.mnuAnalisisDinamicoViaticos.Index = 3
        Me.mnuAnalisisDinamicoViaticos.Text = "Análisis Dinámico de Viáticos"
        '
        'mnuControlCapacitacion
        '
        Me.mnuControlCapacitacion.Index = 5
        Me.mnuControlCapacitacion.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCrearCapacitacion, Me.mnuAsignarParticipantes, Me.MenuItem17})
        Me.mnuControlCapacitacion.Text = "Control Capacitación"
        '
        'mnuCrearCapacitacion
        '
        Me.mnuCrearCapacitacion.Index = 0
        Me.mnuCrearCapacitacion.Text = "Crear Capacitación"
        '
        'mnuAsignarParticipantes
        '
        Me.mnuAsignarParticipantes.Index = 1
        Me.mnuAsignarParticipantes.Text = "Asignar Participantes"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 2
        Me.MenuItem17.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCapacitacionesPorEmpleado, Me.mnuCapacitacionesPorAno})
        Me.MenuItem17.Text = "Reportes"
        '
        'mnuCapacitacionesPorEmpleado
        '
        Me.mnuCapacitacionesPorEmpleado.Index = 0
        Me.mnuCapacitacionesPorEmpleado.Text = "Capacitaciones por Empleado"
        '
        'mnuCapacitacionesPorAno
        '
        Me.mnuCapacitacionesPorAno.Index = 1
        Me.mnuCapacitacionesPorAno.Text = "Capacitaciones por Año"
        '
        'mnuHojaVidaLaboral
        '
        Me.mnuHojaVidaLaboral.Index = 6
        Me.mnuHojaVidaLaboral.Text = "&Hoja de Vida Laboral"
        '
        'mnuCambiaSituacionLaboral
        '
        Me.mnuCambiaSituacionLaboral.Index = 7
        Me.mnuCambiaSituacionLaboral.Text = "Cambio &Situación Laboral"
        '
        'mnuRetiroEmpleado
        '
        Me.mnuRetiroEmpleado.Index = 8
        Me.mnuRetiroEmpleado.Text = "&Retiro Empleado"
        '
        'mnuPerInformes
        '
        Me.mnuPerInformes.Index = 9
        Me.mnuPerInformes.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuListadoPersonal, Me.mnuLstAntiguedad, Me.mnuLstFuncionarios, Me.mnuLstFuncionariosFoto, Me.mnuLstCargasFamiliaresVencen, Me.mnuEmisionCertificadoRentaAnual})
        Me.mnuPerInformes.Text = "Informes"
        '
        'mnuListadoPersonal
        '
        Me.mnuListadoPersonal.Index = 0
        Me.mnuListadoPersonal.Text = "Listado de Empleados"
        Me.mnuListadoPersonal.Visible = False
        '
        'mnuLstAntiguedad
        '
        Me.mnuLstAntiguedad.Index = 1
        Me.mnuLstAntiguedad.Text = "Listado de Empleados Años de Antigüedad"
        '
        'mnuLstFuncionarios
        '
        Me.mnuLstFuncionarios.Index = 2
        Me.mnuLstFuncionarios.Text = "Listado de Funcionarios"
        '
        'mnuLstFuncionariosFoto
        '
        Me.mnuLstFuncionariosFoto.Index = 3
        Me.mnuLstFuncionariosFoto.Text = "Listado de Funcionarios (con Fotografía)"
        '
        'mnuLstCargasFamiliaresVencen
        '
        Me.mnuLstCargasFamiliaresVencen.Index = 4
        Me.mnuLstCargasFamiliaresVencen.Text = "Cargas Familiares por vencer"
        '
        'mnuEmisionCertificadoRentaAnual
        '
        Me.mnuEmisionCertificadoRentaAnual.Index = 5
        Me.mnuEmisionCertificadoRentaAnual.Text = "Emisión certificado de renta anual"
        Me.mnuEmisionCertificadoRentaAnual.Visible = False
        '
        'mnuInformesDinamicosPersonal
        '
        Me.mnuInformesDinamicosPersonal.Index = 10
        Me.mnuInformesDinamicosPersonal.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAnalisisMaestroEmpleadoDIPRES, Me.mnuInformeDinámicoSaldosEventosAdm, Me.mnuAnalisisMovimientosEventosAdministrativos, Me.mnuAnalisisMaestroEmpleadoDetallado, Me.mnuAnalisisCargasFamiliares, Me.MenuItem15})
        Me.mnuInformesDinamicosPersonal.Text = "Informes Dinámicos"
        '
        'mnuAnalisisMaestroEmpleadoDIPRES
        '
        Me.mnuAnalisisMaestroEmpleadoDIPRES.Index = 0
        Me.mnuAnalisisMaestroEmpleadoDIPRES.Text = "Análisis Maestro Empleados (DIPRES)"
        '
        'mnuInformeDinámicoSaldosEventosAdm
        '
        Me.mnuInformeDinámicoSaldosEventosAdm.Index = 1
        Me.mnuInformeDinámicoSaldosEventosAdm.Text = "Análisis Saldos Días Eventos Administrativos"
        '
        'mnuAnalisisMovimientosEventosAdministrativos
        '
        Me.mnuAnalisisMovimientosEventosAdministrativos.Index = 2
        Me.mnuAnalisisMovimientosEventosAdministrativos.Text = "Análisis Movimientos Eventos Administrativos"
        '
        'mnuAnalisisMaestroEmpleadoDetallado
        '
        Me.mnuAnalisisMaestroEmpleadoDetallado.Index = 3
        Me.mnuAnalisisMaestroEmpleadoDetallado.Text = "Análisis Maestro Empleado Detallado"
        '
        'mnuAnalisisCargasFamiliares
        '
        Me.mnuAnalisisCargasFamiliares.Index = 4
        Me.mnuAnalisisCargasFamiliares.Text = "Análisis Cargas Familiares"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 5
        Me.MenuItem15.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuPersonalFueraDotacion, Me.mnuCuadroComparativoHono, Me.mnuPresupuestoAnualHonorario, Me.mnuInformeHonorarioDetallado, Me.mnuInformeCurri})
        Me.MenuItem15.Text = "Informes Honorarios"
        '
        'mnuPersonalFueraDotacion
        '
        Me.mnuPersonalFueraDotacion.Index = 0
        Me.mnuPersonalFueraDotacion.Text = "Informe Personal Fuera Dotación"
        '
        'mnuCuadroComparativoHono
        '
        Me.mnuCuadroComparativoHono.Index = 1
        Me.mnuCuadroComparativoHono.Text = "Informe Cuadro Comparativo Propuesta Honorarios"
        '
        'mnuPresupuestoAnualHonorario
        '
        Me.mnuPresupuestoAnualHonorario.Index = 2
        Me.mnuPresupuestoAnualHonorario.Text = "Informe Honorarios Presupuesto Anual"
        '
        'mnuInformeHonorarioDetallado
        '
        Me.mnuInformeHonorarioDetallado.Index = 3
        Me.mnuInformeHonorarioDetallado.Text = "Informe Honorarios Detallado"
        '
        'mnuInformeCurri
        '
        Me.mnuInformeCurri.Index = 4
        Me.mnuInformeCurri.Text = "Informe Curricular"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 11
        Me.MenuItem5.Text = "-"
        '
        'mnuSalir
        '
        Me.mnuSalir.Index = 12
        Me.mnuSalir.Text = "&Salir"
        '
        'mnuRemuneracion
        '
        Me.mnuRemuneracion.Index = 1
        Me.mnuRemuneracion.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuDefinicionItem, Me.mnuParametrosMensuales, Me.mnuMovimientoMensual, Me.mnuCalculoSueldo, Me.mnuGeneraArchivos, Me.mnuRemInformes, Me.mnuRemInformesDinamicos, Me.mnuCierreProcesos, Me.mnuEUS, Me.mnuImportarTransacciones, Me.mnuRentaAnual, Me.mnuItemsEndeudamiento, Me.mnuEndeudamientoEmpleadoRem})
        Me.mnuRemuneracion.Text = "&Remuneraciones"
        '
        'mnuDefinicionItem
        '
        Me.mnuDefinicionItem.Index = 0
        Me.mnuDefinicionItem.Text = "&Definición de Item"
        '
        'mnuParametrosMensuales
        '
        Me.mnuParametrosMensuales.Index = 1
        Me.mnuParametrosMensuales.Text = "&Parámetros Mensuales"
        '
        'mnuMovimientoMensual
        '
        Me.mnuMovimientoMensual.Index = 2
        Me.mnuMovimientoMensual.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMantencionItem, Me.mnuMantencionEmpleado, Me.menuAnalisisMovimientoMensual, Me.mnuGeneraMovimiento})
        Me.mnuMovimientoMensual.Text = "&Movimiento Mensual"
        '
        'mnuMantencionItem
        '
        Me.mnuMantencionItem.Index = 0
        Me.mnuMantencionItem.Text = "Mantención por &Ítem"
        '
        'mnuMantencionEmpleado
        '
        Me.mnuMantencionEmpleado.Index = 1
        Me.mnuMantencionEmpleado.Text = "Mantención por &Empleado"
        '
        'menuAnalisisMovimientoMensual
        '
        Me.menuAnalisisMovimientoMensual.Index = 2
        Me.menuAnalisisMovimientoMensual.Text = "&Análisis Movimiento Mensual"
        '
        'mnuGeneraMovimiento
        '
        Me.mnuGeneraMovimiento.Index = 3
        Me.mnuGeneraMovimiento.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuItemRelacionado, Me.mnuGeneraItemMasivo})
        Me.mnuGeneraMovimiento.Text = "Genera Movimiento"
        '
        'mnuItemRelacionado
        '
        Me.mnuItemRelacionado.Index = 0
        Me.mnuItemRelacionado.Text = "&Item Relacionado"
        '
        'mnuGeneraItemMasivo
        '
        Me.mnuGeneraItemMasivo.Index = 1
        Me.mnuGeneraItemMasivo.Text = "&Genera Item Masivo"
        '
        'mnuCalculoSueldo
        '
        Me.mnuCalculoSueldo.Index = 3
        Me.mnuCalculoSueldo.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCalculoContrataPlanta, Me.mnuSuplementaria, Me.mnuBonoModernizacion, Me.mnuReajusteAnual, Me.mnuHonorarios, Me.mnuGeneraAsignaciones})
        Me.mnuCalculoSueldo.Text = "&Cálculo Remuneraciones"
        '
        'mnuCalculoContrataPlanta
        '
        Me.mnuCalculoContrataPlanta.Index = 0
        Me.mnuCalculoContrataPlanta.Text = "&Contrata / Planta"
        '
        'mnuSuplementaria
        '
        Me.mnuSuplementaria.Index = 1
        Me.mnuSuplementaria.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCalculoSuplementaria, Me.mnuDiferenicaSuplementaria})
        Me.mnuSuplementaria.Text = "&Suplementaria"
        '
        'mnuCalculoSuplementaria
        '
        Me.mnuCalculoSuplementaria.Index = 0
        Me.mnuCalculoSuplementaria.Text = "&Cálculo Suplementaria"
        '
        'mnuDiferenicaSuplementaria
        '
        Me.mnuDiferenicaSuplementaria.Index = 1
        Me.mnuDiferenicaSuplementaria.Text = "&Diferencia a Pagar"
        '
        'mnuBonoModernizacion
        '
        Me.mnuBonoModernizacion.Index = 2
        Me.mnuBonoModernizacion.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCalculoBonoModernizacion, Me.mnuDetalleBonoModernización, Me.mnuRecalculoBono, Me.mnuDiferenciaBono})
        Me.mnuBonoModernizacion.Text = "&Bono Modernización"
        '
        'mnuCalculoBonoModernizacion
        '
        Me.mnuCalculoBonoModernizacion.Index = 0
        Me.mnuCalculoBonoModernizacion.Text = "&Genera Asignaciones Base"
        '
        'mnuDetalleBonoModernización
        '
        Me.mnuDetalleBonoModernización.Index = 1
        Me.mnuDetalleBonoModernización.Text = "&Reliquidación Bono Modernidad"
        '
        'mnuRecalculoBono
        '
        Me.mnuRecalculoBono.Index = 2
        Me.mnuRecalculoBono.Text = "Recalculo Bono"
        Me.mnuRecalculoBono.Visible = False
        '
        'mnuDiferenciaBono
        '
        Me.mnuDiferenciaBono.Index = 3
        Me.mnuDiferenciaBono.Text = "Diferencia Bono"
        Me.mnuDiferenciaBono.Visible = False
        '
        'mnuReajusteAnual
        '
        Me.mnuReajusteAnual.Index = 3
        Me.mnuReajusteAnual.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuReajusteEUS, Me.mnuReajusteMovimientos})
        Me.mnuReajusteAnual.Text = "Proceso de Reajuste"
        '
        'mnuReajusteEUS
        '
        Me.mnuReajusteEUS.Index = 0
        Me.mnuReajusteEUS.Text = "Revisón Planilla EUS"
        '
        'mnuReajusteMovimientos
        '
        Me.mnuReajusteMovimientos.Index = 1
        Me.mnuReajusteMovimientos.Text = "Reajuste de Movimientos"
        '
        'mnuHonorarios
        '
        Me.mnuHonorarios.Index = 4
        Me.mnuHonorarios.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCalculoHonorarios, Me.mnuSuplementariaHonorario, Me.mnuEnviarTesoreria})
        Me.mnuHonorarios.Text = "&Honorarios"
        '
        'mnuCalculoHonorarios
        '
        Me.mnuCalculoHonorarios.Index = 0
        Me.mnuCalculoHonorarios.Text = "Procesar &Honorarios"
        '
        'mnuSuplementariaHonorario
        '
        Me.mnuSuplementariaHonorario.Index = 1
        Me.mnuSuplementariaHonorario.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMantencionMovEmpleadoHonorario, Me.mnuCalculoSuplementarioHonorario, Me.mnuSuplementariaHonorarioDiferenciaPagar})
        Me.mnuSuplementariaHonorario.Text = "Suplementaria"
        '
        'mnuMantencionMovEmpleadoHonorario
        '
        Me.mnuMantencionMovEmpleadoHonorario.Index = 0
        Me.mnuMantencionMovEmpleadoHonorario.Text = "Mantención por &Empleado"
        '
        'mnuCalculoSuplementarioHonorario
        '
        Me.mnuCalculoSuplementarioHonorario.Index = 1
        Me.mnuCalculoSuplementarioHonorario.Text = "Cálculo Suplementario &Honorario"
        '
        'mnuSuplementariaHonorarioDiferenciaPagar
        '
        Me.mnuSuplementariaHonorarioDiferenciaPagar.Index = 2
        Me.mnuSuplementariaHonorarioDiferenciaPagar.Text = "Diferencia a Pagar"
        '
        'mnuEnviarTesoreria
        '
        Me.mnuEnviarTesoreria.Index = 2
        Me.mnuEnviarTesoreria.Text = "Enviar a Tesoreria"
        '
        'mnuGeneraAsignaciones
        '
        Me.mnuGeneraAsignaciones.Index = 5
        Me.mnuGeneraAsignaciones.Text = "Generera Asignaciones"
        '
        'mnuGeneraArchivos
        '
        Me.mnuGeneraArchivos.Index = 4
        Me.mnuGeneraArchivos.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuNominaBanco, Me.mnuPrevired})
        Me.mnuGeneraArchivos.Text = "&Generación de  Archivos"
        '
        'mnuNominaBanco
        '
        Me.mnuNominaBanco.Index = 0
        Me.mnuNominaBanco.Text = "&Nómina al Banco"
        '
        'mnuPrevired
        '
        Me.mnuPrevired.Index = 1
        Me.mnuPrevired.Text = "&Previred"
        '
        'mnuRemInformes
        '
        Me.mnuRemInformes.Index = 5
        Me.mnuRemInformes.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7, Me.MenuItem8, Me.MenuItem9, Me.MenuItem12, Me.MenuItem13, Me.MenuItem14, Me.mnuSeguroInvalidezSobrev, Me.mnuRptBonificacionRetiro, Me.mnuRptAporteBienestar, Me.mnuRptResoluciones, Me.mnuResumenes, Me.mnuRptResumenPagoPrevisional, Me.mnuRptResumenPagoPrevisionalAPV, Me.MenuItem24})
        Me.mnuRemInformes.Text = "&Informes"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 0
        Me.MenuItem7.Text = "Planilla de Cotizaciones de Salud"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 1
        Me.MenuItem8.Text = "Planilla de Cotizaciones Previsonales"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 2
        Me.MenuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem11, Me.mnuLiquidacionPlantaContrata, Me.mnuLiquidacionPorEmpleado, Me.MenuItem3})
        Me.MenuItem9.Text = "Libro de Remuneraciones"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 0
        Me.MenuItem10.Text = "Contrata/Planta"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "Honorarios"
        '
        'mnuLiquidacionPlantaContrata
        '
        Me.mnuLiquidacionPlantaContrata.Index = 2
        Me.mnuLiquidacionPlantaContrata.Text = "Liquidaciones de Sueldo (Planta y Contrata)"
        '
        'mnuLiquidacionPorEmpleado
        '
        Me.mnuLiquidacionPorEmpleado.Index = 3
        Me.mnuLiquidacionPorEmpleado.Text = "Liquidaciones de Sueldo por Empleado"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 4
        Me.MenuItem3.Text = "Líquidos a Pago"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 3
        Me.MenuItem12.Text = "Anexo Trabajadores INP"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 4
        Me.MenuItem13.Text = "Anexo Trabajadores AFP"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 5
        Me.MenuItem14.Text = "Aporte Mutual Seguridad"
        '
        'mnuSeguroInvalidezSobrev
        '
        Me.mnuSeguroInvalidezSobrev.Index = 6
        Me.mnuSeguroInvalidezSobrev.Text = "Aporte Seguro de Invaldidez y Sobrevivencia"
        '
        'mnuRptBonificacionRetiro
        '
        Me.mnuRptBonificacionRetiro.Index = 7
        Me.mnuRptBonificacionRetiro.Text = "Bonificación por Retiro"
        '
        'mnuRptAporteBienestar
        '
        Me.mnuRptAporteBienestar.Index = 8
        Me.mnuRptAporteBienestar.Text = "Aporte Institucional Bienestar"
        '
        'mnuRptResoluciones
        '
        Me.mnuRptResoluciones.Index = 9
        Me.mnuRptResoluciones.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRptResHorasExtras})
        Me.mnuRptResoluciones.Text = "Emisión Resoluciones"
        '
        'mnuRptResHorasExtras
        '
        Me.mnuRptResHorasExtras.Index = 0
        Me.mnuRptResHorasExtras.Text = "Resolución de Autorización Horas Extraordinarias"
        '
        'mnuResumenes
        '
        Me.mnuResumenes.Index = 10
        Me.mnuResumenes.Text = "Informes de Resumen (Haberes/ Descuentos)"
        '
        'mnuRptResumenPagoPrevisional
        '
        Me.mnuRptResumenPagoPrevisional.Index = 11
        Me.mnuRptResumenPagoPrevisional.Text = "Resumen Pago Previsional"
        '
        'mnuRptResumenPagoPrevisionalAPV
        '
        Me.mnuRptResumenPagoPrevisionalAPV.Index = 12
        Me.mnuRptResumenPagoPrevisionalAPV.Text = "Resumen Pago Previsional APV"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 13
        Me.MenuItem24.Text = "Resumen Pago Salud"
        '
        'mnuRemInformesDinamicos
        '
        Me.mnuRemInformesDinamicos.Index = 6
        Me.mnuRemInformesDinamicos.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCentralizacionContable, Me.mnuAnalisisLiquidaciones})
        Me.mnuRemInformesDinamicos.Text = "Informes Dinámicos"
        '
        'mnuCentralizacionContable
        '
        Me.mnuCentralizacionContable.Index = 0
        Me.mnuCentralizacionContable.Text = "Centralización Contable"
        '
        'mnuAnalisisLiquidaciones
        '
        Me.mnuAnalisisLiquidaciones.Index = 1
        Me.mnuAnalisisLiquidaciones.Text = "Análisis Liquidaciones"
        '
        'mnuCierreProcesos
        '
        Me.mnuCierreProcesos.Index = 7
        Me.mnuCierreProcesos.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCierreMensual, Me.mnuCierreSuplementario, Me.mnuGeneraAsientoContable, Me.mnuGeneraAsientoPresupuesto})
        Me.mnuCierreProcesos.Text = "Cierre de Procesos"
        '
        'mnuCierreMensual
        '
        Me.mnuCierreMensual.Index = 0
        Me.mnuCierreMensual.Text = "Cier&re Mensual"
        '
        'mnuCierreSuplementario
        '
        Me.mnuCierreSuplementario.Index = 1
        Me.mnuCierreSuplementario.Text = "Cierre Suplementario"
        '
        'mnuGeneraAsientoContable
        '
        Me.mnuGeneraAsientoContable.Index = 2
        Me.mnuGeneraAsientoContable.Text = "Genera Asiento Contable"
        '
        'mnuGeneraAsientoPresupuesto
        '
        Me.mnuGeneraAsientoPresupuesto.Index = 3
        Me.mnuGeneraAsientoPresupuesto.Text = "Genera Asiento Presupuesto"
        '
        'mnuEUS
        '
        Me.mnuEUS.Index = 8
        Me.mnuEUS.Text = "&Escala Única de Sueldos"
        '
        'mnuImportarTransacciones
        '
        Me.mnuImportarTransacciones.Index = 9
        Me.mnuImportarTransacciones.Text = "Importar Transacciones"
        Me.mnuImportarTransacciones.Visible = False
        '
        'mnuRentaAnual
        '
        Me.mnuRentaAnual.Index = 10
        Me.mnuRentaAnual.Text = "Proceso de renta anual"
        Me.mnuRentaAnual.Visible = False
        '
        'mnuItemsEndeudamiento
        '
        Me.mnuItemsEndeudamiento.Index = 11
        Me.mnuItemsEndeudamiento.Text = "Items Endeudamiento"
        '
        'mnuEndeudamientoEmpleadoRem
        '
        Me.mnuEndeudamientoEmpleadoRem.Index = 12
        Me.mnuEndeudamientoEmpleadoRem.Text = "Endeudamiento Empleado"
        '
        'mnuBienestar
        '
        Me.mnuBienestar.Index = 2
        Me.mnuBienestar.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuBeneficiosMedicos, Me.mnuPrestamos, Me.mnuCasaComerciales, Me.mnuInformes, Me.MenuItem6, Me.mnuMovimientoMensualBienestar, Me.mnuEndeudamientoEmpleado})
        Me.mnuBienestar.Text = "Bienestar"
        '
        'mnuBeneficiosMedicos
        '
        Me.mnuBeneficiosMedicos.Index = 0
        Me.mnuBeneficiosMedicos.Text = "Beneficios Médicos"
        Me.mnuBeneficiosMedicos.Visible = False
        '
        'mnuPrestamos
        '
        Me.mnuPrestamos.Index = 1
        Me.mnuPrestamos.Text = "Préstamos"
        Me.mnuPrestamos.Visible = False
        '
        'mnuCasaComerciales
        '
        Me.mnuCasaComerciales.Index = 2
        Me.mnuCasaComerciales.Text = "Casa Comerciales"
        Me.mnuCasaComerciales.Visible = False
        '
        'mnuInformes
        '
        Me.mnuInformes.Index = 3
        Me.mnuInformes.Text = "Informes"
        Me.mnuInformes.Visible = False
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 4
        Me.MenuItem6.Text = ""
        Me.MenuItem6.Visible = False
        '
        'mnuMovimientoMensualBienestar
        '
        Me.mnuMovimientoMensualBienestar.Index = 5
        Me.mnuMovimientoMensualBienestar.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMantencionItemBienestar, Me.mnuMantencionMovEmpleadoBienestar})
        Me.mnuMovimientoMensualBienestar.Text = "Movimiento Mensual"
        '
        'mnuMantencionItemBienestar
        '
        Me.mnuMantencionItemBienestar.Index = 0
        Me.mnuMantencionItemBienestar.Text = "Mantención por Ítem"
        '
        'mnuMantencionMovEmpleadoBienestar
        '
        Me.mnuMantencionMovEmpleadoBienestar.Index = 1
        Me.mnuMantencionMovEmpleadoBienestar.Text = "Mantención por Empleado"
        '
        'mnuEndeudamientoEmpleado
        '
        Me.mnuEndeudamientoEmpleado.Index = 6
        Me.mnuEndeudamientoEmpleado.Text = "Endeudamiento Empleado"
        '
        'mnuMantenedor
        '
        Me.mnuMantenedor.Index = 3
        Me.mnuMantenedor.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuDepto, Me.mnuIsapres, Me.MnuBancos, Me.mnuUbicacion, Me.mnuContable, Me.mnuPresupuesto, Me.mnuRetiro, Me.mnuEstudio, Me.mnuProfesionOficio, Me.mnuCarga, Me.mnuAPV, Me.mnuGrado, Me.mnuCalidadJuridica, Me.mnuClasificacion, Me.mnuAFP, Me.mnuOrganizacion, Me.mnuMantenedorFestivos})
        Me.mnuMantenedor.Text = "Tablas Maestras"
        '
        'mnuDepto
        '
        Me.mnuDepto.Index = 0
        Me.mnuDepto.Text = "&Departamento"
        '
        'mnuIsapres
        '
        Me.mnuIsapres.Index = 1
        Me.mnuIsapres.Text = "&Isapres"
        '
        'MnuBancos
        '
        Me.MnuBancos.Index = 2
        Me.MnuBancos.Text = "&Bancos"
        '
        'mnuUbicacion
        '
        Me.mnuUbicacion.Index = 3
        Me.mnuUbicacion.Text = "&Ubicación Física"
        '
        'mnuContable
        '
        Me.mnuContable.Index = 4
        Me.mnuContable.Text = "Centro Costo &Contable"
        '
        'mnuPresupuesto
        '
        Me.mnuPresupuesto.Index = 5
        Me.mnuPresupuesto.Text = "Centro Costo &Presupuesto"
        '
        'mnuRetiro
        '
        Me.mnuRetiro.Index = 6
        Me.mnuRetiro.Text = "Motivo de &Retiro"
        '
        'mnuEstudio
        '
        Me.mnuEstudio.Index = 7
        Me.mnuEstudio.Text = "&Nivel de Estudio"
        '
        'mnuProfesionOficio
        '
        Me.mnuProfesionOficio.Index = 8
        Me.mnuProfesionOficio.Text = "Profesión/Oficio"
        '
        'mnuCarga
        '
        Me.mnuCarga.Index = 9
        Me.mnuCarga.Text = "Asignación Carga &Familiar"
        '
        'mnuAPV
        '
        Me.mnuAPV.Index = 10
        Me.mnuAPV.Text = "Ins&titución APV"
        '
        'mnuGrado
        '
        Me.mnuGrado.Index = 11
        Me.mnuGrado.Text = "&Grado"
        '
        'mnuCalidadJuridica
        '
        Me.mnuCalidadJuridica.Index = 12
        Me.mnuCalidadJuridica.Text = "Calidad &Jurídica"
        '
        'mnuClasificacion
        '
        Me.mnuClasificacion.Index = 13
        Me.mnuClasificacion.Text = "Clasificación &Empleado"
        '
        'mnuAFP
        '
        Me.mnuAFP.Index = 14
        Me.mnuAFP.Text = "Institución Previsional"
        '
        'mnuOrganizacion
        '
        Me.mnuOrganizacion.Index = 15
        Me.mnuOrganizacion.Text = "Organización"
        '
        'mnuMantenedorFestivos
        '
        Me.mnuMantenedorFestivos.Index = 16
        Me.mnuMantenedorFestivos.Text = "Festivos"
        '
        'mnuControlAsistencia
        '
        Me.mnuControlAsistencia.Index = 4
        Me.mnuControlAsistencia.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTraspasarMarcasyHorasExtras, Me.mnuRegistrarMarcasFaltantes, Me.mnuControlAsistenciaDepartamento, Me.mnuControlAsistenciaEmpleado, Me.mnuInformeDinamicoRatificacionHorasExtras, Me.mnuInformeDinamicoAtraso})
        Me.mnuControlAsistencia.Text = "Control Asistencia"
        '
        'mnuTraspasarMarcasyHorasExtras
        '
        Me.mnuTraspasarMarcasyHorasExtras.Index = 0
        Me.mnuTraspasarMarcasyHorasExtras.Text = "Transferir Marcas y Horas Extras"
        '
        'mnuRegistrarMarcasFaltantes
        '
        Me.mnuRegistrarMarcasFaltantes.Index = 1
        Me.mnuRegistrarMarcasFaltantes.Text = "Registrar/Consultar Marcas Asistencia"
        Me.mnuRegistrarMarcasFaltantes.Visible = False
        '
        'mnuControlAsistenciaDepartamento
        '
        Me.mnuControlAsistenciaDepartamento.Index = 2
        Me.mnuControlAsistenciaDepartamento.Text = "Control Asistencia por Departamento"
        '
        'mnuControlAsistenciaEmpleado
        '
        Me.mnuControlAsistenciaEmpleado.Index = 3
        Me.mnuControlAsistenciaEmpleado.Text = "Control Asistencia por Empleado"
        '
        'mnuInformeDinamicoRatificacionHorasExtras
        '
        Me.mnuInformeDinamicoRatificacionHorasExtras.Index = 4
        Me.mnuInformeDinamicoRatificacionHorasExtras.Text = "Informe Dinámico Ratificación Horas Extras"
        '
        'mnuInformeDinamicoAtraso
        '
        Me.mnuInformeDinamicoAtraso.Index = 5
        Me.mnuInformeDinamicoAtraso.Text = "Informe Dinámico Atraso"
        '
        'mnuGestionLicenciasMedicas
        '
        Me.mnuGestionLicenciasMedicas.Index = 5
        Me.mnuGestionLicenciasMedicas.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuLicenciaMedica, Me.mnuLicenciaInformeGestion, Me.mnuInformeCalculoLicenciaMedica, Me.MenuItem18})
        Me.mnuGestionLicenciasMedicas.Text = "Licencias Médicas"
        '
        'mnuLicenciaMedica
        '
        Me.mnuLicenciaMedica.Index = 0
        Me.mnuLicenciaMedica.Text = "&Registro y Consulta Licencias Médicas"
        '
        'mnuLicenciaInformeGestion
        '
        Me.mnuLicenciaInformeGestion.Index = 1
        Me.mnuLicenciaInformeGestion.Text = "&Informe de Gestión"
        '
        'mnuInformeCalculoLicenciaMedica
        '
        Me.mnuInformeCalculoLicenciaMedica.Index = 2
        Me.mnuInformeCalculoLicenciaMedica.Text = "Informe &Cálculo Licencia Médica"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 3
        Me.MenuItem18.Text = "Mantenedor Variación IPC"
        '
        'mnuVentanas
        '
        Me.mnuVentanas.Index = 6
        Me.mnuVentanas.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCascada, Me.mnuMHorizontal, Me.mnuMVertical})
        Me.mnuVentanas.Text = "&Ventanas"
        '
        'mnuCascada
        '
        Me.mnuCascada.Index = 0
        Me.mnuCascada.Text = "Cascada"
        '
        'mnuMHorizontal
        '
        Me.mnuMHorizontal.Index = 1
        Me.mnuMHorizontal.Text = "Mosaico Horizontal"
        '
        'mnuMVertical
        '
        Me.mnuMVertical.Index = 2
        Me.mnuMVertical.Text = "Mosaico Vertical"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 7
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.mnuAcercaDe})
        Me.MenuItem1.Text = "&Ayuda"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Manual de Usuario"
        '
        'mnuAcercaDe
        '
        Me.mnuAcercaDe.Index = 1
        Me.mnuAcercaDe.Text = "Acerca de..."
        '
        'mnuCalificacion
        '
        Me.mnuCalificacion.Index = 8
        Me.mnuCalificacion.Text = "Calificación"
        Me.mnuCalificacion.Visible = False
        '
        'mnuCapacitación
        '
        Me.mnuCapacitación.Index = 9
        Me.mnuCapacitación.Text = "Capacitación"
        Me.mnuCapacitación.Visible = False
        '
        'mnuTesoreria
        '
        Me.mnuTesoreria.Index = 10
        Me.mnuTesoreria.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuEmisionMemorandumViatico, Me.mnuRendicionViatico, Me.mnuChequeEmision, Me.mnuChequesHonorarios})
        Me.mnuTesoreria.Text = "Tesorería"
        '
        'mnuEmisionMemorandumViatico
        '
        Me.mnuEmisionMemorandumViatico.Index = 0
        Me.mnuEmisionMemorandumViatico.Text = "Emisión de Memoradum"
        '
        'mnuRendicionViatico
        '
        Me.mnuRendicionViatico.Index = 1
        Me.mnuRendicionViatico.Text = "Rendición de Viático"
        '
        'mnuChequeEmision
        '
        Me.mnuChequeEmision.Index = 2
        Me.mnuChequeEmision.Text = "Emisión de Cheques"
        '
        'mnuChequesHonorarios
        '
        Me.mnuChequesHonorarios.Index = 3
        Me.mnuChequesHonorarios.Text = "Cheques Honorarios"
        '
        'mnuAprobaciones
        '
        Me.mnuAprobaciones.Index = 11
        Me.mnuAprobaciones.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAprobarPagoBienio, Me.mnuFirmaLiquidacion})
        Me.mnuAprobaciones.Text = "Aprobaciones"
        '
        'mnuAprobarPagoBienio
        '
        Me.mnuAprobarPagoBienio.Index = 0
        Me.mnuAprobarPagoBienio.Text = "Aprobar Pago Bienio"
        '
        'mnuFirmaLiquidacion
        '
        Me.mnuFirmaLiquidacion.Index = 1
        Me.mnuFirmaLiquidacion.Text = "Firma Liquidación"
        Me.mnuFirmaLiquidacion.Visible = False
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = -1
        Me.MenuItem4.Text = ""
        '
        'mnuAnalisisPersonalFueraDotacion
        '
        Me.mnuAnalisisPersonalFueraDotacion.Index = -1
        Me.mnuAnalisisPersonalFueraDotacion.Text = "Análisis Personal Fuera de Dotación"
        '
        'mnuCuadroComparativoHonorarios
        '
        Me.mnuCuadroComparativoHonorarios.Index = -1
        Me.mnuCuadroComparativoHonorarios.Text = "Análisis Cuadro Comparativo Honorarios"
        '
        'StatusBarPrincipal
        '
        Me.StatusBarPrincipal.Location = New System.Drawing.Point(0, -31)
        Me.StatusBarPrincipal.Name = "StatusBarPrincipal"
        Me.StatusBarPrincipal.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanelUserName, Me.StatusBarPanelServer, Me.StatusBarPanelBaseDato, Me.StatusBarPanelBlanco1, Me.StatusBarPanelPeriodoVigente, Me.StatusBarVentanaActiva})
        Me.StatusBarPrincipal.ShowPanels = True
        Me.StatusBarPrincipal.Size = New System.Drawing.Size(664, 31)
        Me.StatusBarPrincipal.TabIndex = 1
        Me.StatusBarPrincipal.Text = "StatusBarPrincipal"
        '
        'StatusBarPanelUserName
        '
        Me.StatusBarPanelUserName.Name = "StatusBarPanelUserName"
        Me.StatusBarPanelUserName.Text = "Usuario:"
        '
        'StatusBarPanelServer
        '
        Me.StatusBarPanelServer.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanelServer.Name = "StatusBarPanelServer"
        Me.StatusBarPanelServer.Text = "Servidor :"
        Me.StatusBarPanelServer.Width = 63
        '
        'StatusBarPanelBaseDato
        '
        Me.StatusBarPanelBaseDato.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanelBaseDato.Name = "StatusBarPanelBaseDato"
        Me.StatusBarPanelBaseDato.Text = "Base de Datos:"
        Me.StatusBarPanelBaseDato.Width = 91
        '
        'StatusBarPanelBlanco1
        '
        Me.StatusBarPanelBlanco1.Name = "StatusBarPanelBlanco1"
        '
        'StatusBarPanelPeriodoVigente
        '
        Me.StatusBarPanelPeriodoVigente.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanelPeriodoVigente.Name = "StatusBarPanelPeriodoVigente"
        Me.StatusBarPanelPeriodoVigente.Text = "PERIODO VIGENTE :"
        Me.StatusBarPanelPeriodoVigente.Width = 125
        '
        'StatusBarVentanaActiva
        '
        Me.StatusBarVentanaActiva.Name = "StatusBarVentanaActiva"
        Me.StatusBarVentanaActiva.Width = 300
        '
        'mnuInformeCurricular
        '
        Me.mnuInformeCurricular.Index = -1
        Me.mnuInformeCurricular.Text = ""
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = -1
        Me.MenuItem16.Text = "Festivos"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(664, 0)
        Me.Controls.Add(Me.StatusBarPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Integral de Gestión Administrativa (SIGA)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanelUserName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanelServer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanelBaseDato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanelBlanco1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanelPeriodoVigente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarVentanaActiva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim parametroMensual As Periodo

    'Formularios que se deben ejecutar con una instancia
    Dim frmFichaEmpleado As frmFichaEmpleado
    Dim frmCalculoSueldo As frmCalculoSueldo
    Dim frmCalculoSuplementaria As frmCalculoSuplementaria
    Dim frmGeneraEmpleadoBonoModernizacion As frmGeneraEmpleadoBonoModernizacion
    Dim frmBonoModernizacionDetalle As frmBonoModernizacionDetalle

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        parametroMensual = New Periodo

        Cursor.Current = Cursors.WaitCursor

        'Asigna a la función MDIChildActivated el control del evento MDIChildActivate
        AddHandler Me.MdiChildActivate, AddressOf Me.MdiChildActivated

        'Establecimiento de Acceso, según permisos.
        StatusBarPanelUserName.Text = "Usuario:" + cl.presidencia.Seguridad.NombreUsuario
        StatusBarPanelUserName.Width = 150
        'IMPORTANTE establecerNivelesDeAcceso()
        'Siempre debe estar presente en la carga de este formulario.
        establecerNivelesDeAcceso()
        'Datos del Producto, Conexión y Sesión de Usuario
        Me.Text = Me.Text & " Versión: " & Application.ProductVersion
        StatusBarPanelServer.Text = "Servidor: " + cl.presidencia.Argo.Comun.ArgoConfiguracion.hostName
        StatusBarPanelBaseDato.Text = "Base de Datos: " + cl.presidencia.Argo.Comun.ArgoConfiguracion.databaseName
        StatusBarPanelPeriodoVigente.Text = "Período Vigente: " + UCase(parametroMensual.nombrePeriodo)
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuCargaGrupoFamiliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuCargaGrupoFamiliar.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmCargaFamiliar As New frmCargaFamiliar
        frmCargaFamiliar.MdiParent = Me
        frmCargaFamiliar.Show()
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub mnuLicenciaMedica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuLicenciaMedica.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmLicenciaMedicaDetalle As New frmLicenciaMedicaDetalle
        frmLicenciaMedicaDetalle.MdiParent = Me
        frmLicenciaMedicaDetalle.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuLicenciaInformeGestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuLicenciaInformeGestion.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmLicenciaMedicaInformeGestion As New frmLicenciaMedicaInformeGestion
        frmLicenciaMedicaInformeGestion.MdiParent = Me
        frmLicenciaMedicaInformeGestion.Show()
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub mnuFeriadoLegal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuFeriadoLegal.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFeriadoLegal As New frmFeriadoLegalEmpleado
        frmFeriadoLegal.MdiParent = Me
        frmFeriadoLegal.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuPermisoAdministrativoConGoce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuPermisoAdministrativoConGoce.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmPermisoAdministrativo As New frmPermisoAdministrativo
        frmPermisoAdministrativo.MdiParent = Me
        frmPermisoAdministrativo.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuPermisoAdministrativoSinGoce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuPermisoAdministrativoSinGoce.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmPermisoAdministrativoSGS As New frmPermisoAdministrativoSinGoceSueldo
        frmPermisoAdministrativoSGS.MdiParent = Me
        frmPermisoAdministrativoSGS.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuPermisoPaternal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuPermisoPaternal.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmPermisoPaternal As New frmPermisoPaternal
        frmPermisoPaternal.MdiParent = Me
        frmPermisoPaternal.Show()
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub mnuHojaVidaLaboral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuHojaVidaLaboral.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmHojaVidaLaboral As New frmHojaVidaLaboral
        frmHojaVidaLaboral.MdiParent = Me
        frmHojaVidaLaboral.Show()
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub mnuCambiaSituacionLaboral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuCambiaSituacionLaboral.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmCambioSituacionLaboral As New frmCambioSituacionLaboral
        frmCambioSituacionLaboral.MdiParent = Me
        frmCambioSituacionLaboral.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuFichaEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuFichaEmpleado.Click
        Cursor.Current = Cursors.WaitCursor
        If IsNothing(frmFichaEmpleado) Then
            frmFichaEmpleado = New frmFichaEmpleado
            frmFichaEmpleado.EsFichaHistorica = False
            frmFichaEmpleado.MdiParent = Me
            frmFichaEmpleado.Show()
        Else
            If frmFichaEmpleado.IsDisposed Then
                frmFichaEmpleado = New frmFichaEmpleado
                frmFichaEmpleado.EsFichaHistorica = False
                frmFichaEmpleado.MdiParent = Me
                frmFichaEmpleado.Show()
            Else
                frmFichaEmpleado.EsFichaHistorica = False
                frmFichaEmpleado.Show()
            End If
        End If
        Cursor.Current = Cursors.Default
    End Sub
    'mnuFichaHistoricaEmpleado

    Private Sub mnuFichaHistoricaEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
 Handles mnuFichaHistoricaEmpleado.Click
        Cursor.Current = Cursors.WaitCursor
        If IsNothing(frmFichaEmpleado) Then
            frmFichaEmpleado = New frmFichaEmpleado
            frmFichaEmpleado.EsFichaHistorica = True
            frmFichaEmpleado.MdiParent = Me
            frmFichaEmpleado.Show()
        Else
            If frmFichaEmpleado.IsDisposed Then
                frmFichaEmpleado = New frmFichaEmpleado
                frmFichaEmpleado.EsFichaHistorica = True
                frmFichaEmpleado.MdiParent = Me
                frmFichaEmpleado.Show()
            Else
                frmFichaEmpleado.EsFichaHistorica = True
                frmFichaEmpleado.Show()
            End If
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuAntecedenteCurricular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuAntecedenteCurricular.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmAntecedenteCurricular
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuAntecedenteAcademico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuAntecedenteAcademico.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmAntecedentesAcademicos
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuDefinicionItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuDefinicionItem.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmItemes
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuParametrosMensuales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuParametrosMensuales.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmAjusteValoresPeriodicos
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MdiChildActivated(ByVal send As Object, ByVal e As System.EventArgs)
        'Si no existe ninguna ventana MDI activa
        If (Not Me.ActiveMdiChild Is Nothing) Then
            'Poner el título de la ventana activa en la barra de estado.
            StatusBarVentanaActiva.Text = Me.ActiveMdiChild.Text
        Else
            StatusBarVentanaActiva.Text = ""
        End If
    End Sub

    Private Sub establecerNivelesDeAcceso()
        '************************************************************************************
        'EstablecerNivelesDeAcceso
        'Función: Habilitar o deshabilitar de acuerdo al nivel de acceso definido 
        'para el usuario según corresponda los controles del menú principal
        '************************************************************************************
        If Not Seguridad.TienePermiso("REM-Acceso Total") Then
            mnuDefinicionItem.Enabled = Seguridad.TienePermiso("REM-Definición Item")
            mnuParametrosMensuales.Enabled = Seguridad.TienePermiso("REM-Parámetros Mensuales")
            mnuMovimientoMensual.Enabled = Seguridad.TienePermiso("REM-Movimiento Mensual")
            mnuCalculoSueldo.Enabled = Seguridad.TienePermiso("REM-Cálculo Remuneraciones")
            mnuDefinicionItem.Enabled = Seguridad.TienePermiso("REM-Cálculo Remuneraciones")
            mnuGeneraArchivos.Enabled = Seguridad.TienePermiso("REM-Cálculo Remuneraciones")
            mnuCierreProcesos.Enabled = Seguridad.TienePermiso("REM-Cierre Procesos")
            mnuRemInformes.Enabled = Seguridad.TienePermiso("REM-Consulta Informes")
            mnuRemInformesDinamicos.Enabled = Seguridad.TienePermiso("REM-Consulta Informes")
            mnuEUS.Enabled = Seguridad.TienePermiso("REM-Escala Unica de Sueldos")
            mnuRemuneracion.Enabled = True
        Else
            mnuRemuneracion.Enabled = Seguridad.TienePermiso("REM-Acceso Total")
        End If
        Me.mnuRemuneracion.Enabled = Me.mnuDefinicionItem.Enabled Or Me.mnuParametrosMensuales.Enabled _
        Or Me.mnuMovimientoMensual.Enabled Or Me.mnuCalculoSueldo.Enabled Or Me.mnuCalculoSueldo.Enabled _
        Or Me.mnuDefinicionItem.Enabled Or Me.mnuGeneraArchivos.Enabled Or Me.mnuCierreProcesos.Enabled _
        Or Me.mnuRemInformes.Enabled Or Me.mnuRemInformesDinamicos.Enabled Or Me.mnuEUS.Enabled

        'Si no tiene acceso total, entonces se revisan uno a uno los grupos a los cuales pertenece.
        If Not Seguridad.TienePermiso("PER-Acceso Total") Then
            If Seguridad.TienePermiso("PER-Ficha de Empleados") Or Seguridad.TienePermiso("PER-Solo Lectura - Consulta Personal") Then
                mnuMaestroEmpleado.Enabled = True
            End If
            mnuFichaEmpleado.Enabled = Seguridad.TienePermiso("PER-Ficha de Empleados") Or Seguridad.TienePermiso("PER-Solo Lectura - Consulta Personal")
            mnuCompraDatosIntranevsFichaEmpleado.Enabled = Seguridad.TienePermiso("PER-Ficha de Empleados")
            mnuRetiroEmpleado.Enabled = Seguridad.TienePermiso("PER-Ficha de Empleados")
            mnuAntecedenteCurricular.Enabled = Seguridad.TienePermiso("PER-Ficha de Empleados")
            mnuAntecedenteAcademico.Enabled = Seguridad.TienePermiso("PER-Ficha de Empleados")
            'If mnuFichaEmpleado.Enabled = False And mnuCompraDatosIntranevsFichaEmpleado.Enabled = False And mnuAntecedenteCurricular.Enabled = False And mnuAntecedenteAcademico.Enabled Then
            'mnuMaestroEmpleado.Enabled = False
            'End If
            mnuCargaGrupoFamiliar.Enabled = Seguridad.TienePermiso("PER-Cargas Familiares y Grupo")
            mnuEventosAdministrativos.Enabled = Seguridad.TienePermiso("PER-Eventos Administrativos")
            mnuHorasExtras.Enabled = Seguridad.TienePermiso("PER-Control Horas Extras")
            mnuControlViaticos.Enabled = Seguridad.TienePermiso("PER-Control de Viaticos")
            mnuHojaVidaLaboral.Enabled = Seguridad.TienePermiso("PER-Hoja de Vida Laboral")
            mnuCambiaSituacionLaboral.Enabled = Seguridad.TienePermiso("PER-Cambio Situación Laboral")
            mnuRetiroEmpleado.Enabled = Seguridad.TienePermiso("PER-Cambio Situación Laboral")
            mnuHorasExtras.Enabled = Seguridad.TienePermiso("PER-Horas Extras")
            mnuPerInformes.Enabled = Seguridad.TienePermiso("PER-Informes")
            mnuInformesDinamicosPersonal.Enabled = Seguridad.TienePermiso("PER-Informes Dinámicos")
            MnuModuloPersonal.Enabled = True
        Else
            MnuModuloPersonal.Enabled = Seguridad.TienePermiso("PER-Acceso Total")
        End If
        MnuModuloPersonal.Enabled = mnuMaestroEmpleado.Enabled Or mnuRetiroEmpleado.Enabled _
        Or mnuAntecedenteCurricular.Enabled Or mnuAntecedenteAcademico.Enabled _
        Or mnuCargaGrupoFamiliar.Enabled Or mnuEventosAdministrativos.Enabled _
        Or mnuHorasExtras.Enabled Or mnuControlViaticos.Enabled _
        Or mnuHojaVidaLaboral.Enabled Or mnuCambiaSituacionLaboral.Enabled _
        Or mnuRetiroEmpleado.Enabled Or mnuHorasExtras.Enabled _
        Or mnuPerInformes.Enabled Or mnuInformesDinamicosPersonal.Enabled _
        Or mnuCompraDatosIntranevsFichaEmpleado.Enabled


        If Not Seguridad.TienePermiso("BIE-Acceso Total") Then
            mnuBienestar.Enabled = False
        Else
            mnuBienestar.Enabled = Seguridad.TienePermiso("BIE-Acceso Total")
        End If

        If Not Seguridad.TienePermiso("COM-Mantencion Tablas Maestras Personal") Then
            mnuDepto.Enabled = False
            mnuUbicacion.Enabled = False
            mnuRetiro.Enabled = False
            mnuEstudio.Enabled = False

        Else
            mnuDepto.Enabled = True
            mnuUbicacion.Enabled = True
            mnuRetiro.Enabled = True
            mnuEstudio.Enabled = True
        End If
        mnuMantenedor.Enabled = (mnuDepto.Enabled Or mnuUbicacion.Enabled Or mnuRetiro.Enabled Or mnuEstudio.Enabled)

        If Not Seguridad.TienePermiso("COM-Mantencion Tablas Maestras Remuneraciones") Then
            mnuIsapres.Enabled = False
            MnuBancos.Enabled = False
            mnuContable.Enabled = False
            mnuPresupuesto.Enabled = False
            mnuCarga.Enabled = False
            mnuAPV.Enabled = False
            mnuGrado.Enabled = False
            mnuCalidadJuridica.Enabled = False
            mnuClasificacion.Enabled = False
            mnuAFP.Enabled = False
        Else
            mnuIsapres.Enabled = True
            MnuBancos.Enabled = True
            mnuContable.Enabled = True
            mnuPresupuesto.Enabled = True
            mnuCarga.Enabled = True
            mnuAPV.Enabled = True
            mnuGrado.Enabled = True
            mnuCalidadJuridica.Enabled = True
            mnuClasificacion.Enabled = True
            mnuAFP.Enabled = True
        End If
        mnuMantenedor.Enabled = mnuIsapres.Enabled Or MnuBancos.Enabled Or mnuContable.Enabled Or mnuPresupuesto.Enabled _
        Or mnuCarga.Enabled Or mnuAPV.Enabled Or mnuAPV.Enabled Or mnuGrado.Enabled Or mnuCalidadJuridica.Enabled _
        Or mnuClasificacion.Enabled Or mnuAFP.Enabled

        If Seguridad.TienePermiso("PER-Control Asistencia-Transfiere Marcas y Horas Extras") Then
            mnuTraspasarMarcasyHorasExtras.Enabled = True
        Else
            mnuTraspasarMarcasyHorasExtras.Enabled = False
        End If
        If Seguridad.TienePermiso("PER-Control Asistencia-Registrar Consultar Marcas (Acceso Total)") Or Seguridad.TienePermiso("PER-Control Asistencia-Registrar Consultar Marcas (Solo Lectura)") Then
            mnuRegistrarMarcasFaltantes.Enabled = True
        Else
            mnuRegistrarMarcasFaltantes.Enabled = False
        End If
        mnuControlAsistencia.Enabled = Seguridad.TienePermiso("PER-Control Asistencia")

        If Seguridad.TienePermiso("PER-Licencias Medicas (Solo Lectura)") Or Seguridad.TienePermiso("PER-Licencias Medicas (Acceso Total)") Then
            mnuGestionLicenciasMedicas.Enabled = True
        Else
            mnuGestionLicenciasMedicas.Enabled = False
        End If

        If Seguridad.TienePermiso("PER-Tesoreria") Then
            mnuTesoreria.Enabled = True
        Else
            mnuTesoreria.Enabled = False
        End If

        If Seguridad.TienePermiso("REM-Jefe RRHH") Then
            mnuAprobaciones.Enabled = True
        Else
            mnuAprobaciones.Enabled = False
        End If
    End Sub


    Private Sub mnuMantencionItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuMantencionItem.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmMantencionItemPeriodo
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuListadoPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuListadoPersonal.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltro As New frmFiltroRptNominaEmpleados
        frmFiltro.DefInstance.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuLstAntiguedad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuLstAntiguedad.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltro As New frmFiltroRptAntiguedadEmpleados
        frmFiltro.DefInstance.Show()
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub mnuCalculoContrataPlanta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuCalculoContrataPlanta.Click
        Cursor.Current = Cursors.WaitCursor
        If IsNothing(frmCalculoSueldo) Then
            frmCalculoSueldo = New frmCalculoSueldo
            frmCalculoSueldo.MdiParent = Me
            frmCalculoSueldo.Show()
        Else
            If frmCalculoSueldo.IsDisposed Then
                frmCalculoSueldo = New frmCalculoSueldo
                frmCalculoSueldo.MdiParent = Me
                frmCalculoSueldo.Show()
            Else
                frmCalculoSueldo.Show()
            End If
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuCalculoHonorarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuCalculoHonorarios.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmCalculoSueldo As New frmCalculoSueldoHonorarios
        frmCalculoSueldo.MdiParent = Me
        frmCalculoSueldo.Show()
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub mnuItemRelacionado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuItemRelacionado.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmItemRelacionado As New frmItemRelacionado
        frmItemRelacionado.MdiParent = Me
        frmItemRelacionado.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuMantencionEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuMantencionEmpleado.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmMantencionItemEmpleado
        frm1.tipoProceso = "N"
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles MenuItem7.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltroPlanillaCotSalud As New frmFiltroPlanillaCotSalud
        frmFiltroPlanillaCotSalud.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuNominaBanco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuNominaBanco.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmGeneraArchivoPlanoBancoRemuneracion
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default

        'Cursor.Current = Cursors.WaitCursor
        'Dim frmArchivoBanco As New frmArchivoBanco
        'frmArchivoBanco.MdiParent = Me
        'frmArchivoBanco.DefInstance.Show()
        'frmArchivoBanco.Show()
        'Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuCierreMensual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuCierreMensual.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmCierreMensual
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuHistoriaEventoAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuHistoriaEventoAdmin.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmHistoriaEventosAdministrativos
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuEUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuEUS.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmEUS
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuPrevired_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles mnuPrevired.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmGeneraArchivoPlanoImposiciones
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltroPlanillaCotPrev As New frmFiltroPlanillaCotPrev
        frmFiltroPlanillaCotPrev.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltroLibroRemu As New frmFiltroLibroRemunera
        frmFiltroLibroRemu.ShowDialog(Me)
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltroLibroHonorarios As New frmFiltroLibroHonorarios
        frmFiltroLibroHonorarios.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltroAnexoTrabajadoresINP As New frmFiltroAnexoTrabajadoresINP
        frmFiltroAnexoTrabajadoresINP.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        'Dim frmFiltroAnexoTrabajadoresAFP As New frmFiltroAnexoTrabajadoresAFP
        'frmFiltroAnexoTrabajadoresAFP.Show()
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltroMutualDeSeguridad As New frmFiltroMutualDeSeguridad
        frmFiltroMutualDeSeguridad.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuCalculoBonoModernizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCalculoBonoModernizacion.Click
        Cursor.Current = Cursors.WaitCursor
        If IsNothing(frmGeneraEmpleadoBonoModernizacion) Then
            frmGeneraEmpleadoBonoModernizacion = New frmGeneraEmpleadoBonoModernizacion
            frmGeneraEmpleadoBonoModernizacion.MdiParent = Me
            frmGeneraEmpleadoBonoModernizacion.Show()
        Else
            If frmGeneraEmpleadoBonoModernizacion.IsDisposed Then
                frmGeneraEmpleadoBonoModernizacion = New frmGeneraEmpleadoBonoModernizacion
                frmGeneraEmpleadoBonoModernizacion.MdiParent = Me
                frmGeneraEmpleadoBonoModernizacion.Show()
            Else
                frmGeneraEmpleadoBonoModernizacion.Show()
            End If
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuDetalleBonoModernización_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDetalleBonoModernización.Click
        Cursor.Current = Cursors.WaitCursor
        If IsNothing(frmBonoModernizacionDetalle) Then
            frmBonoModernizacionDetalle = New frmBonoModernizacionDetalle
            frmBonoModernizacionDetalle.MdiParent = Me
            frmBonoModernizacionDetalle.Show()
        Else
            If frmBonoModernizacionDetalle.IsDisposed Then
                frmBonoModernizacionDetalle = New frmBonoModernizacionDetalle
                frmBonoModernizacionDetalle.MdiParent = Me
                frmBonoModernizacionDetalle.Show()
            Else
                frmBonoModernizacionDetalle.Show()
            End If
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmTablaImpuestos
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuLiquidacionPlantaContrata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLiquidacionPlantaContrata.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltroLiquidaciones As New frmFiltroLiquidaciones
        frmFiltroLiquidaciones.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mmnuLiquidacionPorEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLiquidacionPorEmpleado.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltroLiquidacionesPorEmpleado As New frmFiltroLiquidacionesPorEmpleado
        frmFiltroLiquidacionesPorEmpleado.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuAcercaDe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAcercaDe.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmBienvenida As New frmBienvenida
        frmBienvenida.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmMantencionViaticos As New frmViatico
        frmMantencionViaticos.MdiParent = Me
        frmMantencionViaticos.Show()
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmControlViaticos As New frmHistoriaViaticosPorMemo
        frmControlViaticos.MdiParent = Me
        frmControlViaticos.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuResumenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuResumenes.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmResumenItems As New frmResumenItems
        frmResumenItems.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLstFuncionarios.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltroNominaFuncionarios As New frmFiltroNominaFucnionarios
        frmFiltroNominaFuncionarios.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem24_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCargaFamiliar.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmCargaFamiliar
        frm1.MdiParent = Me
        frm1.tipoEdicion = cl.presidencia.Argo.Comun.TiposDeDatos.TipoEdicionCargaFAM.EDICION_COMO_CARGA_FAMILIAR
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGrupoFamiliar.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmCargaFamiliar
        With frm1
            .MdiParent = Me
            .tipoEdicion = cl.presidencia.Argo.Comun.TiposDeDatos.TipoEdicionCargaFAM.EDICION_COMO_MIEMBRO_GRUPO_FAMILIAR
            .Text = "Grupo Familiar"
            .lueTipoBeneficio.Visible = False
            .lblTipoBeneficio.Visible = False
            .lueTipoBeneficiario.Visible = False
            .lblTipoBeneficiario.Visible = False
            .pnlDatosCargaFAM.Visible = False
            .pnlDatosCargaFAM.Location = New System.Drawing.Point(376, 192)
            .pnlAcciones.Location = New System.Drawing.Point(272, 168)
            .GCEditorDatos.Text = "Datos Miembro del Grupo Familiar"
            .GCDetalle.Location = New System.Drawing.Point(8, 215)
            .GCDetalle.Text = "Pertenecen al Grupo Familiar"
            .Show()
        End With
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuRptResumenPagoPrevisional_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRptResumenPagoPrevisional.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltroResumenPrevisional As New frmFiltroResumenPrevisional
        frmFiltroResumenPrevisional.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem24_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltroResumensalud As New frmFiltroResumenSalud
        frmFiltroResumensalud.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuLstCargasFamiliaresVencen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLstCargasFamiliaresVencen.Click
        Cursor.Current = Cursors.WaitCursor
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptInfCargasFamiliaresVenc
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        reporte.RecordSelectionFormula = ""
        reporte.SummaryInfo.ReportTitle = "NÓMINA DE CARGAS FAMILIARES POR VENCER " & Now.Year
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuRptResumenPagoPrevisionalAPV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRptResumenPagoPrevisionalAPV.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltroResumenPrevisionaAPV As New frmFiltroRptResumenPrevisionalAPV
        frmFiltroResumenPrevisionaAPV.Show()
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub mnuDepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDepto.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmDeptos
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuCalculoSuplementaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCalculoSuplementaria.Click
        Cursor.Current = Cursors.WaitCursor
        If IsNothing(frmCalculoSuplementaria) Then
            frmCalculoSuplementaria = New frmCalculoSuplementaria
            frmCalculoSuplementaria.MdiParent = Me
            frmCalculoSuplementaria.Show()
        Else
            If frmCalculoSuplementaria.IsDisposed Then
                frmCalculoSuplementaria = New frmCalculoSuplementaria
                frmCalculoSuplementaria.MdiParent = Me
                frmCalculoSuplementaria.Show()
            Else
                frmCalculoSuplementaria.Show()
            End If
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuRptAporteBienestar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRptAporteBienestar.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltroAporteBienestar As New frmFiltroAporteBienestar
        frmFiltroAporteBienestar.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuRptBonificacionRetiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRptBonificacionRetiro.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltroBonificacionRetiro As New frmFiltroBonificacionRetiro
        frmFiltroBonificacionRetiro.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIsapres.Click
        Cursor.Current = Cursors.WaitCursor
        'Dim frm1 As New frmIsapres
        Dim frm1 As New frmIsapres
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub MenuItem18_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuBancos.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmBancos
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem25_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUbicacion.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmUbicacion
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub mnuRptResHorasExtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRptResHorasExtras.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm As New frmFiltroResolucionHorasExtras
        frm.Show()
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuContable.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New FrmCostoContable
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPresupuesto.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New FrmCostoPresupuesto
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub


#Region "Menu Ventanas"
    Private Sub mnuCascada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCascada.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnuMHorizontal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnuMVertical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
#End Region

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRetiro.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmMotivoRetiro
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuRptInformeValorizadoCargasFam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRptInformeValorizadoCargasFam.Click
        Dim frmFiltroCargaFamiliarValorizado As New frmFiltroRptCargaFamiliarValorizado
        frmFiltroCargaFamiliarValorizado.Show()
    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEstudio.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmNivelEstudio
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuDiferenicaSuplementaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDiferenicaSuplementaria.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmSuplementariaDiferecias
        frm1.MdiParent = Me
        frm1.tipoProceso = Comun.TipoProceso.SUPLEMENTARIA_PLANTA_CONTRATA
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCarga.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmAsignacionFamiliar
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuResHorasExtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuResHorasExtras.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm As New frmFiltroResolucionHorasExtras
        frm.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuRegHorasExtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegHorasExtras.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmHorasExtrasEmpleado
        frm1.WindowState = FormWindowState.Maximized
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub mnuActualizaCargasFamHaciaFichaEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuActualizaCargasFamHaciaFichaEmpleado.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmCargaFamiliarActualizaFichaEmpleado
        frm1.WindowState = FormWindowState.Maximized
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltroLiquidaciones As New frmFiltroLiquidaciones
        frmFiltroLiquidaciones.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAPV.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmAPV
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGrado.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmGrado
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuCalidadJuridica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCalidadJuridica.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmCalidadJuridica
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuClasificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClasificacion.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmClasificacionEmpleado
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub mnuAFP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAFP.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmAFP
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmFiltroRptLiquidosAPago
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuCentralizacionContable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCentralizacionContable.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmCentralizacionContable
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuCierreSuplementario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCierreSuplementario.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmCierreProcesoSuplementario
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuRetiroEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRetiroEmpleado.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmRetiroEmpleado As New frmRetiroEmpleado
        frmRetiroEmpleado.MdiParent = Me
        frmRetiroEmpleado.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuAnalisisLiquidaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnalisisLiquidaciones.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmAnalisisLiquidaciones
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If MsgBoxResult.No = MessageBox.Show("¿Está seguro(a) que desea salir de la aplicación?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub mnuMantencionItemBienestar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMantencionItemBienestar.Click
        Cursor.Current = Cursors.WaitCursor
        'Los items en cuestion deben ser obtenidos 
        'desde los parámetros generales del sistema.
        Dim empleado As Empleado = New Empleado
        Dim itemsID() As Integer = empleado.recuperarItemes
        Dim frm1 As New frmMantencionItemPeriodo(itemsID)
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuMantencionMovEmpleadoBienestar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMantencionMovEmpleadoBienestar.Click
        Cursor.Current = Cursors.WaitCursor
        'Los items en cuestion deben ser obtenidos 
        'desde los parámetros generales del sistema.
        Dim empleado As Empleado = New Empleado
        Dim itemsID() As Integer = empleado.recuperarItemes
        Dim frm1 As New frmMantencionItemEmpleado(itemsID)
        frm1.tipoProceso = "N"
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub mnuRecalculoBono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRecalculoBono.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmRecalcularEmpleadoBonoModernizacion As New frmRecalcularEmpleadoBonoModernizacion
        frmRecalcularEmpleadoBonoModernizacion.MdiParent = Me
        frmRecalcularEmpleadoBonoModernizacion.Show()
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub mnuDiferenciaBono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDiferenciaBono.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmDiferenciaRecalculoBonoModernizacion As New frmDiferenciaRecalculoBonoModernizacion
        frmDiferenciaRecalculoBonoModernizacion.MdiParent = Me
        frmDiferenciaRecalculoBonoModernizacion.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuAnalisisMaestroEmpleadoDIPRES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnalisisMaestroEmpleadoDIPRES.Click
        'If MsgBoxResult.Yes = MessageBox.Show("El siguiente informe podría tardar varios minutos, ¿desea continuar?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmAnalisisEmpleadosDIPRES
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
        'End If
    End Sub

    Private Sub mnuInformeDinámicoSaldosEventosAdm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInformeDinámicoSaldosEventosAdm.Click
        If MsgBoxResult.Yes = MessageBox.Show("El siguiente informe podría tardar varios minutos, ¿desea continuar?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            Cursor.Current = Cursors.WaitCursor
            Dim frmSaldoDiasEventosAdministrativos As New frmSaldoDiasEventosAdministrativos
            frmSaldoDiasEventosAdministrativos.MdiParent = Me
            frmSaldoDiasEventosAdministrativos.Show()
            Cursor.Current = Cursors.Default
        End If
    End Sub

    Private Sub mnuAnalisisMovimientosEventosAdministrativos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnalisisMovimientosEventosAdministrativos.Click
        'If MsgBoxResult.Yes = MessageBox.Show("El siguiente informe podría tardar varios minutos, ¿desea continuar?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
        Cursor.Current = Cursors.WaitCursor
        Dim frmAnalisisEventosAdministrativos As New frmAnalisisEventosAdministrativos
        frmAnalisisEventosAdministrativos.MdiParent = Me
        frmAnalisisEventosAdministrativos.Show()
        Cursor.Current = Cursors.Default
        'End If
    End Sub

    Private Sub mnuAnalisisMaestroEmpleadoDetallado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnalisisMaestroEmpleadoDetallado.Click
        'If MsgBoxResult.Yes = MessageBox.Show("El siguiente informe podría tardar varios minutos, ¿desea continuar?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
        Cursor.Current = Cursors.WaitCursor
        Dim frmAnalisisMaestroEmpleadoDetallado As New frmAnalisisMaestroEmpleadoDetallado
        frmAnalisisMaestroEmpleadoDetallado.MdiParent = Me
        frmAnalisisMaestroEmpleadoDetallado.Show()
        Cursor.Current = Cursors.Default
        'End If
    End Sub

    Private Sub mnuAnalisisCargasFamiliares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnalisisCargasFamiliares.Click
        'If MsgBoxResult.Yes = MessageBox.Show("El siguiente informe podría tardar varios minutos, ¿desea continuar?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
        Cursor.Current = Cursors.WaitCursor
        Dim frmAnalisisCargasFamiliares As New frmAnalisisCargasFamiliares
        frmAnalisisCargasFamiliares.MdiParent = Me
        frmAnalisisCargasFamiliares.Show()
        Cursor.Current = Cursors.Default
        'End If

    End Sub

    Private Sub mnuLstFuncionariosFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLstFuncionariosFoto.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltroNominaFotoFuncionarios As New frmFiltroNominaFotoFucnionarios
        frmFiltroNominaFotoFuncionarios.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuReajusteEUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReajusteEUS.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmReajusteEUS
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuReajusteMovimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReajusteMovimientos.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmReajuste
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub menuAnalisisMovimientoMensual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAnalisisMovimientoMensual.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmResumenMovimientoMensual
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuCompraDatosIntranevsFichaEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCompraDatosIntranevsFichaEmpleado.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmComparaDatosIntranetConDatoFichaEmpleado
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuOrganizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOrganizacion.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmOrganizacion
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub mnuGeneraAsientoContable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGeneraAsientoContable.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmAsientoContable
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuControlAsistenciaDepartamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuControlAsistenciaDepartamento.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmControlAsistenciaDepartamento
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuGeneraResumenPagoMensualHorasExttras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGeneraResumenPagoMensualHorasExttras.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmGenerarResumenMensualHrsExtrasAtraso
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuRegistrarMarcasFaltantes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegistrarMarcasFaltantes.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmMarcasFaltantes
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuControlAsistenciaEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuControlAsistenciaEmpleado.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmControlAsistenciaEmpleado
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuTraspasarMarcasyHorasExtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTraspasarMarcasyHorasExtras.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmTraspasaMarcasyHorasExtras
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuInformeDinamicoRatificacionHorasExtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInformeDinamicoRatificacionHorasExtras.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmAnalisisRatificacionHorasExtras
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuSeguroInvalidezSobrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSeguroInvalidezSobrev.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltroSeguroInvalidezSobrev As New frmFiltroSeguroInvalidezSobrev
        frmFiltroSeguroInvalidezSobrev.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuAnalisisDinamicoViaticos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnalisisDinamicoViaticos.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmAnalisisViaticos As New frmAnalisisViaticos
        frmAnalisisViaticos.MdiParent = Me
        frmAnalisisViaticos.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuRegistroCheques_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegistroCheques.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmChequeRegistro As New frmChequeRegistro
        frmChequeRegistro.MdiParent = Me
        frmChequeRegistro.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuChequeEmision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChequeEmision.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmChequeEmision As New frmChequeEmision
        frmChequeEmision.MdiParent = Me
        frmChequeEmision.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuInformeDinamicoAtraso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInformeDinamicoAtraso.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmAnalisisAtrasos
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuAnalisisHorasExtrasCompensadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnalisisHorasExtrasCompensadas.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmAnalisisHorasCompensadas
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuHorasAprobadasPorDepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIngresoHorasAprobadasPorDepto.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmIngresoHorasExtrasAprobadasDepto
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuValidacionHorasExtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmValidacionHorasExtrasRatificadas
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuResHorasExtrasAprobadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuResHorasExtrasAprobadas.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm As New frmFiltroResolucionHorasExtrasAprobadas
        frm.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuHorasExtrasRatificadasLiquidadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHorasExtrasRatificadasLiquidadas.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmHorasExtrasPagadasVSRatificadas
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuPermisoDuelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPermisoDuelo.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmPermisoPorDuelo
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub mnuPersonalFueraDotacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPersonalFueraDotacion.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmAnalisisPersonalFueraDotacion As New frmAnalisisPersonalFueraDotacion
        frmAnalisisPersonalFueraDotacion.MdiParent = Me
        frmAnalisisPersonalFueraDotacion.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuCuadroComparativoHono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCuadroComparativoHono.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmCuadroComparativoHonorarios As New frmCuadroComparativoHonorarios
        frmCuadroComparativoHonorarios.MdiParent = Me
        frmCuadroComparativoHonorarios.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuPresupuestoAnualHonorario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPresupuestoAnualHonorario.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmPresupuestoAnualHonorarios As New frmPresupuestoAnualHonorarios
        frmPresupuestoAnualHonorarios.MdiParent = Me
        frmPresupuestoAnualHonorarios.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuInformeCurri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInformeCurri.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmFiltroInformeCurricular As New frmFiltroInformeCurri
        frmFiltroInformeCurricular.MdiParent = Me
        frmFiltroInformeCurricular.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuMantencionMovEmpleadoHonorario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMantencionMovEmpleadoHonorario.Click
        Cursor.Current = Cursors.WaitCursor
        'Los items en cuestion deben ser obtenidos 
        'desde los parámetros generales del sistema.
        Dim empleado As Empleado = New Empleado
        Dim itemsID() As Integer = empleado.recuperarItemes
        Dim frm1 As New frmMantencionItemEmpleado(itemsID)
        frm1.tipoProceso = "H"
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuCalculoSuplementarioHonorario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCalculoSuplementarioHonorario.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmCalculoSuplementariaHonorarios As New frmCalculoSuplementariaHonorarios
        frmCalculoSuplementariaHonorarios.MdiParent = Me
        frmCalculoSuplementariaHonorarios.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuSuplementariaHonorarioDiferenciaPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSuplementariaHonorarioDiferenciaPagar.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmSuplementariaDiferecias
        frm1.MdiParent = Me
        frm1.tipoProceso = Comun.TipoProceso.SUPLEMENTARIA_HONORARIOS
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuEmisionMemorandumViatico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEmisionMemorandumViatico.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmEmisionMemorandumViatico As New frmEmisionMemorandumViatico
        frmEmisionMemorandumViatico.MdiParent = Me
        frmEmisionMemorandumViatico.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuRendicionViatico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRendicionViatico.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmRendicionViaticoPorMemo As New frmRendicionViaticoPorMemo
        frmRendicionViaticoPorMemo.MdiParent = Me
        frmRendicionViaticoPorMemo.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuEnviarTesoreria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEnviarTesoreria.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmEnviarTesoreria As New frmEnviarTesoreria
        frmEnviarTesoreria.MdiParent = Me
        frmEnviarTesoreria.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuChequesHonorarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChequesHonorarios.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmEmisionChequeHonorario As New frmEmisionChequeHonorario
        frmEmisionChequeHonorario.MdiParent = Me
        frmEmisionChequeHonorario.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuProfesionOficio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProfesionOficio.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmProfesiones As New frmProfesiones
        frmProfesiones.MdiParent = Me
        frmProfesiones.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuAprobarPagoBienio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAprobarPagoBienio.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmAprobarAsignacionRemuneracion As New frmAprobarAsignacionRemuneracion
        frmAprobarAsignacionRemuneracion.MdiParent = Me
        frmAprobarAsignacionRemuneracion.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuInformeHonorarioDetallado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInformeHonorarioDetallado.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmInformeDetalladoHonorario As New frmInformeDetalladoHonorario
        frmInformeDetalladoHonorario.MdiParent = Me
        frmInformeDetalladoHonorario.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuGeneraAsientoPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGeneraAsientoPresupuesto.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmAsientoPresupuesto
        frm1.MdiParent = Me
        frm1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuEnviarEmpleadoHonorarioDexon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEnviarEmpleadoHonorarioDexon.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmEnviarHonorariosADexon As New frmEnviarHonorariosADexon
        frmEnviarHonorariosADexon.MdiParent = Me
        frmEnviarHonorariosADexon.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuItemsEndeudamiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemsEndeudamiento.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmItemesEndeudamiento As New frmItemesEndeudamiento
        frmItemesEndeudamiento.MdiParent = Me
        frmItemesEndeudamiento.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuEndeudamientoEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEndeudamientoEmpleado.Click, mnuEndeudamientoEmpleadoRem.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmEndeudamientoEmpleado As New frmEndeudamientoEmpleado
        frmEndeudamientoEmpleado.MdiParent = Me
        frmEndeudamientoEmpleado.Show()
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub mnuMantenedorOrganizacion_Click(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub mnuMantenedorFestivos_Click(sender As System.Object, e As System.EventArgs) Handles mnuMantenedorFestivos.Click
        Cursor = Cursors.WaitCursor
        Dim frmFestivos As New frmFestivos
        frmFestivos.MdiParent = Me
        frmFestivos.Show()
        Cursor = Cursors.Default
    End Sub

    Private Sub mnuCrearCapacitacion_Click(sender As System.Object, e As System.EventArgs) Handles mnuCrearCapacitacion.Click
        Cursor = Cursors.WaitCursor
        Dim frmCrearCapacitacion As New frmCrearCapacitacion
        frmCrearCapacitacion.MdiParent = Me
        frmCrearCapacitacion.Show()
        Cursor = Cursors.Default
    End Sub

    Private Sub mnuAsignarParticipantes_Click(sender As System.Object, e As System.EventArgs) Handles mnuAsignarParticipantes.Click
        Cursor = Cursors.WaitCursor
        Dim frmAsignarParticipantesCapacitacion As New frmAsignarParticipantesCapacitacion
        frmAsignarParticipantesCapacitacion.MdiParent = Me
        frmAsignarParticipantesCapacitacion.Show()
        Cursor = Cursors.Default
    End Sub


    Private Sub mnuGeneraItemMasivo_Click(sender As System.Object, e As System.EventArgs) Handles mnuGeneraItemMasivo.Click
        'Cursor.Current = Cursors.WaitCursor
        'Dim frmItemGenerarMovimiento As New frmItemGenerarMovimiento
        'frmItemGenerarMovimiento.MdiParent = Me
        'frmItemGenerarMovimiento.Show()
        'Cursor.Current = Cursors.Default

        Cursor.Current = Cursors.WaitCursor
        Dim frm1 As New frmItemGenerarMovimiento
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub mnuCapacitacionesPorEmpleado_Click(sender As System.Object, e As System.EventArgs) Handles mnuCapacitacionesPorEmpleado.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmCapacitacionesPorEmpleado As New frmCapacitacionesPorEmpleado
        frmCapacitacionesPorEmpleado.MdiParent = Me
        frmCapacitacionesPorEmpleado.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuCapacitacionesPorAno_Click(sender As System.Object, e As System.EventArgs) Handles mnuCapacitacionesPorAno.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmCapacitacionesPorAnoYEstamento As New frmCapacitacionesPorAnoYEstamento
        frmCapacitacionesPorAnoYEstamento.MdiParent = Me
        frmCapacitacionesPorAnoYEstamento.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuGeneraAsignaciones_Click(sender As System.Object, e As System.EventArgs) Handles mnuGeneraAsignaciones.Click
        Cursor.Current = Cursors.WaitCursor
        Dim frmGeneraAsignaciones As New frmGeneraAsignaciones
        frmGeneraAsignaciones.MdiParent = Me
        frmGeneraAsignaciones.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuFirmaLiquidacion_Click(sender As System.Object, e As System.EventArgs) Handles mnuFirmaLiquidacion.Click
        Cursor.Current = Cursors.WaitCursor
        'Dim frmFirmaLiquidacion As New frmFirmaLiquidacion
        'frmFirmaLiquidacion.MdiParent = Me
        'frmFirmaLiquidacion.Show()
        Dim frmFiltroLiquidaciones As New frmFiltroLiquidaciones
        frmFiltroLiquidaciones.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuInformeCalculoLicenciaMedica_Click(sender As System.Object, e As System.EventArgs) Handles mnuInformeCalculoLicenciaMedica.Click
        Cursor.Current = Cursors.WaitCursor
        Dim form As New frmLicenciaMedicaInformeCalculo
        form.WindowState = FormWindowState.Maximized
        form.MdiParent = Me
        form.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MenuItem18_Click_3(sender As System.Object, e As System.EventArgs) Handles MenuItem18.Click
        Cursor.Current = Cursors.WaitCursor
        Dim form As New frmImpuestoAcumulado
        form.WindowState = FormWindowState.Maximized
        form.MdiParent = Me
        form.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuInformeHorasAtraso_Click(sender As System.Object, e As System.EventArgs) Handles mnuInformeHorasAtraso.Click
        Cursor.Current = Cursors.WaitCursor
        Dim form As New frmInformeAtrasos
        form.WindowState = FormWindowState.Maximized
        form.MdiParent = Me
        form.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub mnuInformeHorasExtrasNoRatificadas_Click(sender As System.Object, e As System.EventArgs) Handles mnuInformeHorasExtrasNoRatificadas.Click
        Cursor.Current = Cursors.WaitCursor
        Dim form As New frmInformeHorasNoRatificadas
        form.WindowState = FormWindowState.Maximized
        form.MdiParent = Me
        form.Show()
        Cursor.Current = Cursors.Default
    End Sub
End Class
