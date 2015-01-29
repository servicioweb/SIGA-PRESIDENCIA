Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.SqlClient

Public Class frmAjusteValoresPeriodicos
    Inherits System.Windows.Forms.Form
    Dim connectionString As String = Comun.ArgoConfiguracion.ConnectionString
    Dim idPeriodo As Integer
    Dim RegistroID As Integer
    Friend WithEvents btnImpuestoSegundaCategoria As DevExpress.XtraEditors.SimpleButton
    Dim periodoIDAnterior As Integer

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
    Friend WithEvents lblCodigoConvenioAbonoPrevired As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents txtPorcentajeIncrementoPrevisionalDL3501 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPorcentajeIncrementoPrevisionalDL3501 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoConvenioAbonoPrevired As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMensajeColillaPago As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblMensajeColillaPago As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTopeImponibleOtrosCalculos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTopeImponibleOtrosCalculos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTopeImponiblePrevisional As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPorcentajeTopeSalud As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPorcentajeGastoRepresentacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPorcentajeMaximoViatico As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEdadLegal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValorUTM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblValorUTM As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValorUF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblValorUF As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFechaPago As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaPago As DevExpress.XtraEditors.DateEdit
    Friend WithEvents gcMesAno As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblCodigoConvenioRemuneracionPrevired As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPorcentajeRecargaHorasExtrasNocturnas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPorcentajeRecargaHorasExtrasNocturnas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPorcentajeRecargaHorasEstrasDiurnas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPorcentajeRecargaHorasExtrasDiurnas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblIdentificadorItemHorasExtrasNocturnas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblIdentificadorItemHorasExtrasDiurnas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHorasExtrasNocturnasLegalPermitidas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblHorasExtrasNocturnasLegalPermitidas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHorasExtrasDiurnasLegalPermitidas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblHorasEstrasDiurnasLegalesPermitidas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHorasLegalTrabajadasDiarias As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblHorasLegalTrabajadasDiarias As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblIdentificadorItemMutualSeguridad As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFactorMensualMutualSeguridad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFactorMensualDeSeguridad As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoPreviredInstitucion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCodigoPreviredInstitucion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreInstitucionSeguridad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNombreInstitucionDeSeguridad As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblIdentificadorItemSeguroTrabajador2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblIdentificadorItemSeguroTrabajador1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPorcentaleMensualDescuento2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPorcentaleMensualDescuento2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPorcentaleMensualDescuento1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPorcentaleMensualDescuento1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreEmpresaAseguradora As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNombreEmpresaAseguradora As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPorcentajeDescuentoBienestar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueIdentificadorItemHorasExtrasDiurnas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueIdentificadorItemHorasExtrasNocturnas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueIdentificadorItemMutualSeguridad As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueIdentificadorItemSeguroTrabajador1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueIdentificadorItemSeguroTrabajador2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueMes As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueAño As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gcValoresPeriodicos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ParametrosMensuales As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ControlHorasExtras As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents MutualSeguridad As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SeguroEmpleados As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ItemsBaseCalculo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ItemsPrevisionalesSalud As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BonoModernizacion As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lueLey18675Art11 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueLey18675Art10 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueLey18566 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueIncrementoPrevisional As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueRetencionJudicial As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents luelAsignacionFamiliar As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueResponsabilidadSuperior As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueSueldoBase As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueDiasTrabajados As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblLey18675Art10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLey18566 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblIncrementoPrevisional As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRetencionJudicial As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblResponsabilidadSuperior As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSualdoBase As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDiasTrabajados As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lueDl3551 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueAsociacionGremial As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueFuncionCritica As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueLey18171 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueGastoRepresentacion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueFondoBienestar As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueAsignacionAntiguedad As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueLey19185Art19 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueLey19185Art18 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblFuncionCritica As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLey18171 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblGastoRepresentacion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDl3551 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAsociacionGremial As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFondoBienestar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAsignacionAntiguedad As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLey19185Art19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLey19185Art18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueLiquidoAPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueTotalDeberes As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueTotalHaberes As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueImponible90uf As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueImponible60uf As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueRetencion10 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueImpuesto2Categoria As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueTotalTributable As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblLiquidoAPago As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalDeberes As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalHaberes As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblImponible90uf As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblImponible60uf As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRetencion10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblImpuesto2Categoria As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalTributable As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAsignacionFamiliar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLey18675Art11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl3 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents luePlanComplementarioSalud As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueCotizacionLegalSalud As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueTotalDescuentoLegalPrevisional As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueCotizacionVoluntariaAFP As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueCuentaAhorroAFP As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueCotizacionLegalPrevisional As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPlanComplementarioSalud As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCotizacionLegalSalud As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalDescuentoLegalPrevisional As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCotizacionVoluntariaAFP As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCuentaAhorroAFP As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCotizacionLegalPrevisional As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueTotalDescuentoLeyesSociales As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueTotalDescuentoAPV As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueAhorroAPV As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueTotalDescuentoSalud As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents luePlanAUGE As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblTotalDescuentoLeyesSociales As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalDescuentoAPV As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAhorroAPV As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalDescuentoSalud As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPlanAUGE As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl4 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage7 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtPorcentajeColectivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPorcentajeInstitucionalBono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPorcentajeBaseBono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueLey19553Art8Mes1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueLey19553Art8MesActual As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueAsignacionDesempeñoMes2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueAsignacionDesempeñoMes1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueAsignacinDesempeñoMesActual As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkRealizaProcesoModernizacion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblLey19553Art8Mes1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLey19553Art8MesActual As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAsignacionDesempeñoMes2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAsignacionDesempeñoMes1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAsignacinDesempeñoMesActual As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPorcentajeColectivo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPorcentajeInstitucionalBono As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPorcentajeBaseBono As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRealizaProcesoModernizacion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueDescuentoImpuestoSegundaCatergoriaMes2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueDescuentoImpuestoSegundaCatergoriaMes1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueDescuentoBienestarMes2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueDescuentoBienestarMes1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueDescuentoSaludMes2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueDescuentoSaludMes1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueDescuentoPrevisionalMes2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueDescuentoPrevisionalMes1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueLey19553Art8Mes2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblDescuentoImpuestoSegundaCatergoriaMes2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDescuentoImpuestoSegundaCatergoriaMes1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDescuentoBienestarMes2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDescuentoBienestarMes1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDescuentoSaludMes2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDescuentoSaludMes1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDescuentoPrevisionalMes2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDescuentoPrevisionalMes1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLey19553Art8Mes2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage8 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcRelacionItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblRelacionItems As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueItem As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueItemAsociado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblFlechas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGuardarRelacion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardarRelacionNueva As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminarRelacion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCopiaPiePagina As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCopiasResolucion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUFMesAnterior As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblValorUfMesAnterior As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAporteInstitucional As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAporteInstitucional As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPorcentajeDescuentoBienestar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblQuienFirmaResoluciones As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rdgQuienFirmaResolucion As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lueItemHorasAtraso As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblIdentificadorÍtemHorasAtraso As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueIdentificadorItemDescuentoInasistenciaMedioDía As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblIdentificadorItemDescuentoInasistenciaMedioDía As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkAplicaDescuentoAtraso As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAplicaDescuentoInasistenciaMedioDia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAplicaCalculoHrsExtrasMesAnterior As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkAplicaViaticoValoresAntiguos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dedFechaCierreRatifHorasExtras As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblSisMes1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSisMes2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueSisMes1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueSisMes2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueSis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblSis As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPorcentajeEndeudamiento As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPordentajeEndeudamiento As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblCodigoConvenioAbonoPrevired = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.ParametrosMensuales = New DevExpress.XtraTab.XtraTabPage()
        Me.txtPordentajeEndeudamiento = New DevExpress.XtraEditors.TextEdit()
        Me.lblPorcentajeEndeudamiento = New DevExpress.XtraEditors.LabelControl()
        Me.rdgQuienFirmaResolucion = New DevExpress.XtraEditors.RadioGroup()
        Me.lblQuienFirmaResoluciones = New DevExpress.XtraEditors.LabelControl()
        Me.lblPorcentajeDescuentoBienestar = New DevExpress.XtraEditors.LabelControl()
        Me.txtAporteInstitucional = New DevExpress.XtraEditors.TextEdit()
        Me.lblAporteInstitucional = New DevExpress.XtraEditors.LabelControl()
        Me.txtUFMesAnterior = New DevExpress.XtraEditors.TextEdit()
        Me.lblValorUfMesAnterior = New DevExpress.XtraEditors.LabelControl()
        Me.txtCopiasResolucion = New DevExpress.XtraEditors.TextEdit()
        Me.lblCopiaPiePagina = New DevExpress.XtraEditors.LabelControl()
        Me.lblCodigoConvenioRemuneracionPrevired = New DevExpress.XtraEditors.LabelControl()
        Me.txtPorcentajeIncrementoPrevisionalDL3501 = New DevExpress.XtraEditors.TextEdit()
        Me.lblPorcentajeIncrementoPrevisionalDL3501 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPorcentajeDescuentoBienestar = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoConvenioAbonoPrevired = New DevExpress.XtraEditors.TextEdit()
        Me.txtMensajeColillaPago = New DevExpress.XtraEditors.MemoEdit()
        Me.lblMensajeColillaPago = New DevExpress.XtraEditors.LabelControl()
        Me.txtTopeImponibleOtrosCalculos = New DevExpress.XtraEditors.TextEdit()
        Me.lblTopeImponibleOtrosCalculos = New DevExpress.XtraEditors.LabelControl()
        Me.txtTopeImponiblePrevisional = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPorcentajeTopeSalud = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPorcentajeGastoRepresentacion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPorcentajeMaximoViatico = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEdadLegal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtValorUTM = New DevExpress.XtraEditors.TextEdit()
        Me.lblValorUTM = New DevExpress.XtraEditors.LabelControl()
        Me.txtValorUF = New DevExpress.XtraEditors.TextEdit()
        Me.lblValorUF = New DevExpress.XtraEditors.LabelControl()
        Me.lblFechaPago = New DevExpress.XtraEditors.LabelControl()
        Me.deFechaPago = New DevExpress.XtraEditors.DateEdit()
        Me.ControlHorasExtras = New DevExpress.XtraTab.XtraTabPage()
        Me.dedFechaCierreRatifHorasExtras = New DevExpress.XtraEditors.DateEdit()
        Me.chkAplicaViaticoValoresAntiguos = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.chkAplicaCalculoHrsExtrasMesAnterior = New DevExpress.XtraEditors.CheckEdit()
        Me.chkAplicaDescuentoInasistenciaMedioDia = New DevExpress.XtraEditors.CheckEdit()
        Me.chkAplicaDescuentoAtraso = New DevExpress.XtraEditors.CheckEdit()
        Me.lueIdentificadorItemDescuentoInasistenciaMedioDía = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblIdentificadorItemDescuentoInasistenciaMedioDía = New DevExpress.XtraEditors.LabelControl()
        Me.lueItemHorasAtraso = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblIdentificadorÍtemHorasAtraso = New DevExpress.XtraEditors.LabelControl()
        Me.lueIdentificadorItemHorasExtrasNocturnas = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueIdentificadorItemHorasExtrasDiurnas = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtPorcentajeRecargaHorasExtrasNocturnas = New DevExpress.XtraEditors.TextEdit()
        Me.lblPorcentajeRecargaHorasExtrasNocturnas = New DevExpress.XtraEditors.LabelControl()
        Me.txtPorcentajeRecargaHorasEstrasDiurnas = New DevExpress.XtraEditors.TextEdit()
        Me.lblPorcentajeRecargaHorasExtrasDiurnas = New DevExpress.XtraEditors.LabelControl()
        Me.lblIdentificadorItemHorasExtrasNocturnas = New DevExpress.XtraEditors.LabelControl()
        Me.lblIdentificadorItemHorasExtrasDiurnas = New DevExpress.XtraEditors.LabelControl()
        Me.txtHorasExtrasNocturnasLegalPermitidas = New DevExpress.XtraEditors.TextEdit()
        Me.lblHorasExtrasNocturnasLegalPermitidas = New DevExpress.XtraEditors.LabelControl()
        Me.txtHorasExtrasDiurnasLegalPermitidas = New DevExpress.XtraEditors.TextEdit()
        Me.lblHorasEstrasDiurnasLegalesPermitidas = New DevExpress.XtraEditors.LabelControl()
        Me.txtHorasLegalTrabajadasDiarias = New DevExpress.XtraEditors.TextEdit()
        Me.lblHorasLegalTrabajadasDiarias = New DevExpress.XtraEditors.LabelControl()
        Me.MutualSeguridad = New DevExpress.XtraTab.XtraTabPage()
        Me.lueIdentificadorItemMutualSeguridad = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblIdentificadorItemMutualSeguridad = New DevExpress.XtraEditors.LabelControl()
        Me.txtFactorMensualMutualSeguridad = New DevExpress.XtraEditors.TextEdit()
        Me.lblFactorMensualDeSeguridad = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoPreviredInstitucion = New DevExpress.XtraEditors.TextEdit()
        Me.lblCodigoPreviredInstitucion = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombreInstitucionSeguridad = New DevExpress.XtraEditors.TextEdit()
        Me.lblNombreInstitucionDeSeguridad = New DevExpress.XtraEditors.LabelControl()
        Me.SeguroEmpleados = New DevExpress.XtraTab.XtraTabPage()
        Me.lueIdentificadorItemSeguroTrabajador2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueIdentificadorItemSeguroTrabajador1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblIdentificadorItemSeguroTrabajador2 = New DevExpress.XtraEditors.LabelControl()
        Me.lblIdentificadorItemSeguroTrabajador1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPorcentaleMensualDescuento2 = New DevExpress.XtraEditors.TextEdit()
        Me.lblPorcentaleMensualDescuento2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPorcentaleMensualDescuento1 = New DevExpress.XtraEditors.TextEdit()
        Me.lblPorcentaleMensualDescuento1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombreEmpresaAseguradora = New DevExpress.XtraEditors.TextEdit()
        Me.lblNombreEmpresaAseguradora = New DevExpress.XtraEditors.LabelControl()
        Me.ItemsBaseCalculo = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.lblLey18675Art11 = New DevExpress.XtraEditors.LabelControl()
        Me.lblAsignacionFamiliar = New DevExpress.XtraEditors.LabelControl()
        Me.lueLey18675Art11 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueLey18675Art10 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueLey18566 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueIncrementoPrevisional = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueRetencionJudicial = New DevExpress.XtraEditors.LookUpEdit()
        Me.luelAsignacionFamiliar = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueResponsabilidadSuperior = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueSueldoBase = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueDiasTrabajados = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblLey18675Art10 = New DevExpress.XtraEditors.LabelControl()
        Me.lblLey18566 = New DevExpress.XtraEditors.LabelControl()
        Me.lblIncrementoPrevisional = New DevExpress.XtraEditors.LabelControl()
        Me.lblRetencionJudicial = New DevExpress.XtraEditors.LabelControl()
        Me.lblResponsabilidadSuperior = New DevExpress.XtraEditors.LabelControl()
        Me.lblSualdoBase = New DevExpress.XtraEditors.LabelControl()
        Me.lblDiasTrabajados = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.lueDl3551 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueAsociacionGremial = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueFuncionCritica = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueLey18171 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueGastoRepresentacion = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueFondoBienestar = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueAsignacionAntiguedad = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueLey19185Art19 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueLey19185Art18 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblFuncionCritica = New DevExpress.XtraEditors.LabelControl()
        Me.lblLey18171 = New DevExpress.XtraEditors.LabelControl()
        Me.lblGastoRepresentacion = New DevExpress.XtraEditors.LabelControl()
        Me.lblDl3551 = New DevExpress.XtraEditors.LabelControl()
        Me.lblAsociacionGremial = New DevExpress.XtraEditors.LabelControl()
        Me.lblFondoBienestar = New DevExpress.XtraEditors.LabelControl()
        Me.lblAsignacionAntiguedad = New DevExpress.XtraEditors.LabelControl()
        Me.lblLey19185Art19 = New DevExpress.XtraEditors.LabelControl()
        Me.lblLey19185Art18 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.lueLiquidoAPago = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueTotalDeberes = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueTotalHaberes = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueImponible90uf = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueImponible60uf = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueRetencion10 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueImpuesto2Categoria = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueTotalTributable = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblLiquidoAPago = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalDeberes = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalHaberes = New DevExpress.XtraEditors.LabelControl()
        Me.lblImponible90uf = New DevExpress.XtraEditors.LabelControl()
        Me.lblImponible60uf = New DevExpress.XtraEditors.LabelControl()
        Me.lblRetencion10 = New DevExpress.XtraEditors.LabelControl()
        Me.lblImpuesto2Categoria = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalTributable = New DevExpress.XtraEditors.LabelControl()
        Me.ItemsPrevisionalesSalud = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabControl3 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.lueSis = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblSis = New DevExpress.XtraEditors.LabelControl()
        Me.luePlanComplementarioSalud = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueCotizacionLegalSalud = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueTotalDescuentoLegalPrevisional = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueCotizacionVoluntariaAFP = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueCuentaAhorroAFP = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueCotizacionLegalPrevisional = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPlanComplementarioSalud = New DevExpress.XtraEditors.LabelControl()
        Me.lblCotizacionLegalSalud = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalDescuentoLegalPrevisional = New DevExpress.XtraEditors.LabelControl()
        Me.lblCotizacionVoluntariaAFP = New DevExpress.XtraEditors.LabelControl()
        Me.lblCuentaAhorroAFP = New DevExpress.XtraEditors.LabelControl()
        Me.lblCotizacionLegalPrevisional = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.lueTotalDescuentoLeyesSociales = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueTotalDescuentoAPV = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueAhorroAPV = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueTotalDescuentoSalud = New DevExpress.XtraEditors.LookUpEdit()
        Me.luePlanAUGE = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblTotalDescuentoLeyesSociales = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalDescuentoAPV = New DevExpress.XtraEditors.LabelControl()
        Me.lblAhorroAPV = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalDescuentoSalud = New DevExpress.XtraEditors.LabelControl()
        Me.lblPlanAUGE = New DevExpress.XtraEditors.LabelControl()
        Me.BonoModernizacion = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabControl4 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        Me.lueSisMes2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueSisMes1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblSisMes2 = New DevExpress.XtraEditors.LabelControl()
        Me.lblSisMes1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPorcentajeColectivo = New DevExpress.XtraEditors.TextEdit()
        Me.txtPorcentajeInstitucionalBono = New DevExpress.XtraEditors.TextEdit()
        Me.txtPorcentajeBaseBono = New DevExpress.XtraEditors.TextEdit()
        Me.lueLey19553Art8Mes1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueLey19553Art8MesActual = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueAsignacionDesempeñoMes2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueAsignacionDesempeñoMes1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueAsignacinDesempeñoMesActual = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkRealizaProcesoModernizacion = New DevExpress.XtraEditors.CheckEdit()
        Me.lblLey19553Art8Mes1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblLey19553Art8MesActual = New DevExpress.XtraEditors.LabelControl()
        Me.lblAsignacionDesempeñoMes2 = New DevExpress.XtraEditors.LabelControl()
        Me.lblAsignacionDesempeñoMes1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblAsignacinDesempeñoMesActual = New DevExpress.XtraEditors.LabelControl()
        Me.lblPorcentajeColectivo = New DevExpress.XtraEditors.LabelControl()
        Me.lblPorcentajeInstitucionalBono = New DevExpress.XtraEditors.LabelControl()
        Me.lblPorcentajeBaseBono = New DevExpress.XtraEditors.LabelControl()
        Me.lblRealizaProcesoModernizacion = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage7 = New DevExpress.XtraTab.XtraTabPage()
        Me.lueDescuentoImpuestoSegundaCatergoriaMes2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueDescuentoImpuestoSegundaCatergoriaMes1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueDescuentoBienestarMes2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueDescuentoBienestarMes1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueDescuentoSaludMes2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueDescuentoSaludMes1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueDescuentoPrevisionalMes2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueDescuentoPrevisionalMes1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueLey19553Art8Mes2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblDescuentoImpuestoSegundaCatergoriaMes2 = New DevExpress.XtraEditors.LabelControl()
        Me.lblDescuentoImpuestoSegundaCatergoriaMes1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblDescuentoBienestarMes2 = New DevExpress.XtraEditors.LabelControl()
        Me.lblDescuentoBienestarMes1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblDescuentoSaludMes2 = New DevExpress.XtraEditors.LabelControl()
        Me.lblDescuentoSaludMes1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblDescuentoPrevisionalMes2 = New DevExpress.XtraEditors.LabelControl()
        Me.lblDescuentoPrevisionalMes1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblLey19553Art8Mes2 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage8 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnEliminarRelacion = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardarRelacionNueva = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardarRelacion = New DevExpress.XtraEditors.SimpleButton()
        Me.lblFlechas = New DevExpress.XtraEditors.LabelControl()
        Me.lueItemAsociado = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueItem = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblRelacionItems = New DevExpress.XtraEditors.LabelControl()
        Me.gcRelacionItems = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcMesAno = New DevExpress.XtraEditors.GroupControl()
        Me.lueAño = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueMes = New DevExpress.XtraEditors.LookUpEdit()
        Me.gcValoresPeriodicos = New DevExpress.XtraEditors.GroupControl()
        Me.btnImpuestoSegundaCategoria = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.ParametrosMensuales.SuspendLayout()
        CType(Me.txtPordentajeEndeudamiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgQuienFirmaResolucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAporteInstitucional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUFMesAnterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCopiasResolucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentajeIncrementoPrevisionalDL3501.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentajeDescuentoBienestar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoConvenioAbonoPrevired.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMensajeColillaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTopeImponibleOtrosCalculos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTopeImponiblePrevisional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentajeTopeSalud.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentajeGastoRepresentacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentajeMaximoViatico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEdadLegal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorUTM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorUF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ControlHorasExtras.SuspendLayout()
        CType(Me.dedFechaCierreRatifHorasExtras.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaCierreRatifHorasExtras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAplicaViaticoValoresAntiguos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAplicaCalculoHrsExtrasMesAnterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAplicaDescuentoInasistenciaMedioDia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAplicaDescuentoAtraso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueIdentificadorItemDescuentoInasistenciaMedioDía.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueItemHorasAtraso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueIdentificadorItemHorasExtrasNocturnas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueIdentificadorItemHorasExtrasDiurnas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentajeRecargaHorasExtrasNocturnas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentajeRecargaHorasEstrasDiurnas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHorasExtrasNocturnasLegalPermitidas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHorasExtrasDiurnasLegalPermitidas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHorasLegalTrabajadasDiarias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MutualSeguridad.SuspendLayout()
        CType(Me.lueIdentificadorItemMutualSeguridad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFactorMensualMutualSeguridad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoPreviredInstitucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreInstitucionSeguridad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SeguroEmpleados.SuspendLayout()
        CType(Me.lueIdentificadorItemSeguroTrabajador2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueIdentificadorItemSeguroTrabajador1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentaleMensualDescuento2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentaleMensualDescuento1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreEmpresaAseguradora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemsBaseCalculo.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.lueLey18675Art11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLey18675Art10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLey18566.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueIncrementoPrevisional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueRetencionJudicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luelAsignacionFamiliar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueResponsabilidadSuperior.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueSueldoBase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDiasTrabajados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.lueDl3551.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueAsociacionGremial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFuncionCritica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLey18171.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueGastoRepresentacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFondoBienestar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueAsignacionAntiguedad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLey19185Art19.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLey19185Art18.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.lueLiquidoAPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTotalDeberes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTotalHaberes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueImponible90uf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueImponible60uf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueRetencion10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueImpuesto2Categoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTotalTributable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemsPrevisionalesSalud.SuspendLayout()
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl3.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.lueSis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePlanComplementarioSalud.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCotizacionLegalSalud.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTotalDescuentoLegalPrevisional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCotizacionVoluntariaAFP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCuentaAhorroAFP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCotizacionLegalPrevisional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.lueTotalDescuentoLeyesSociales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTotalDescuentoAPV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueAhorroAPV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTotalDescuentoSalud.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePlanAUGE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BonoModernizacion.SuspendLayout()
        CType(Me.XtraTabControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl4.SuspendLayout()
        Me.XtraTabPage6.SuspendLayout()
        CType(Me.lueSisMes2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueSisMes1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentajeColectivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentajeInstitucionalBono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentajeBaseBono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLey19553Art8Mes1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLey19553Art8MesActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueAsignacionDesempeñoMes2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueAsignacionDesempeñoMes1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueAsignacinDesempeñoMesActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRealizaProcesoModernizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage7.SuspendLayout()
        CType(Me.lueDescuentoImpuestoSegundaCatergoriaMes2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDescuentoImpuestoSegundaCatergoriaMes1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDescuentoBienestarMes2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDescuentoBienestarMes1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDescuentoSaludMes2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDescuentoSaludMes1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDescuentoPrevisionalMes2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDescuentoPrevisionalMes1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLey19553Art8Mes2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage8.SuspendLayout()
        CType(Me.lueItemAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcRelacionItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcMesAno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcMesAno.SuspendLayout()
        CType(Me.lueAño.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcValoresPeriodicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcValoresPeriodicos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCodigoConvenioAbonoPrevired
        '
        Me.lblCodigoConvenioAbonoPrevired.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCodigoConvenioAbonoPrevired.Location = New System.Drawing.Point(352, 176)
        Me.lblCodigoConvenioAbonoPrevired.Name = "lblCodigoConvenioAbonoPrevired"
        Me.lblCodigoConvenioAbonoPrevired.Size = New System.Drawing.Size(224, 14)
        Me.lblCodigoConvenioAbonoPrevired.TabIndex = 33
        Me.lblCodigoConvenioAbonoPrevired.Text = "Código convenio abono remuneración previred"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 72)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.ParametrosMensuales
        Me.XtraTabControl2.Size = New System.Drawing.Size(968, 512)
        Me.XtraTabControl2.TabIndex = 38
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.ParametrosMensuales, Me.ControlHorasExtras, Me.MutualSeguridad, Me.SeguroEmpleados, Me.ItemsBaseCalculo, Me.ItemsPrevisionalesSalud, Me.BonoModernizacion})
        '
        'ParametrosMensuales
        '
        Me.ParametrosMensuales.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ParametrosMensuales.Appearance.Header.Options.UseFont = True
        Me.ParametrosMensuales.Controls.Add(Me.txtPordentajeEndeudamiento)
        Me.ParametrosMensuales.Controls.Add(Me.lblPorcentajeEndeudamiento)
        Me.ParametrosMensuales.Controls.Add(Me.rdgQuienFirmaResolucion)
        Me.ParametrosMensuales.Controls.Add(Me.lblQuienFirmaResoluciones)
        Me.ParametrosMensuales.Controls.Add(Me.lblPorcentajeDescuentoBienestar)
        Me.ParametrosMensuales.Controls.Add(Me.txtAporteInstitucional)
        Me.ParametrosMensuales.Controls.Add(Me.lblAporteInstitucional)
        Me.ParametrosMensuales.Controls.Add(Me.txtUFMesAnterior)
        Me.ParametrosMensuales.Controls.Add(Me.lblValorUfMesAnterior)
        Me.ParametrosMensuales.Controls.Add(Me.txtCopiasResolucion)
        Me.ParametrosMensuales.Controls.Add(Me.lblCopiaPiePagina)
        Me.ParametrosMensuales.Controls.Add(Me.lblCodigoConvenioRemuneracionPrevired)
        Me.ParametrosMensuales.Controls.Add(Me.txtPorcentajeIncrementoPrevisionalDL3501)
        Me.ParametrosMensuales.Controls.Add(Me.lblPorcentajeIncrementoPrevisionalDL3501)
        Me.ParametrosMensuales.Controls.Add(Me.txtPorcentajeDescuentoBienestar)
        Me.ParametrosMensuales.Controls.Add(Me.txtCodigoConvenioAbonoPrevired)
        Me.ParametrosMensuales.Controls.Add(Me.txtMensajeColillaPago)
        Me.ParametrosMensuales.Controls.Add(Me.lblMensajeColillaPago)
        Me.ParametrosMensuales.Controls.Add(Me.txtTopeImponibleOtrosCalculos)
        Me.ParametrosMensuales.Controls.Add(Me.lblTopeImponibleOtrosCalculos)
        Me.ParametrosMensuales.Controls.Add(Me.txtTopeImponiblePrevisional)
        Me.ParametrosMensuales.Controls.Add(Me.LabelControl5)
        Me.ParametrosMensuales.Controls.Add(Me.txtPorcentajeTopeSalud)
        Me.ParametrosMensuales.Controls.Add(Me.LabelControl4)
        Me.ParametrosMensuales.Controls.Add(Me.txtPorcentajeGastoRepresentacion)
        Me.ParametrosMensuales.Controls.Add(Me.LabelControl3)
        Me.ParametrosMensuales.Controls.Add(Me.txtPorcentajeMaximoViatico)
        Me.ParametrosMensuales.Controls.Add(Me.LabelControl2)
        Me.ParametrosMensuales.Controls.Add(Me.txtEdadLegal)
        Me.ParametrosMensuales.Controls.Add(Me.LabelControl1)
        Me.ParametrosMensuales.Controls.Add(Me.txtValorUTM)
        Me.ParametrosMensuales.Controls.Add(Me.lblValorUTM)
        Me.ParametrosMensuales.Controls.Add(Me.txtValorUF)
        Me.ParametrosMensuales.Controls.Add(Me.lblValorUF)
        Me.ParametrosMensuales.Controls.Add(Me.lblFechaPago)
        Me.ParametrosMensuales.Controls.Add(Me.deFechaPago)
        Me.ParametrosMensuales.Name = "ParametrosMensuales"
        Me.ParametrosMensuales.Size = New System.Drawing.Size(961, 483)
        Me.ParametrosMensuales.Text = "Parámetros mensuales"
        '
        'txtPordentajeEndeudamiento
        '
        Me.txtPordentajeEndeudamiento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPordentajeEndeudamiento.Location = New System.Drawing.Point(721, 321)
        Me.txtPordentajeEndeudamiento.Name = "txtPordentajeEndeudamiento"
        Me.txtPordentajeEndeudamiento.Properties.DisplayFormat.FormatString = "n1"
        Me.txtPordentajeEndeudamiento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPordentajeEndeudamiento.Properties.EditFormat.FormatString = "n1"
        Me.txtPordentajeEndeudamiento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPordentajeEndeudamiento.Properties.Mask.EditMask = "n1"
        Me.txtPordentajeEndeudamiento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPordentajeEndeudamiento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPordentajeEndeudamiento.Properties.MaxLength = 5
        Me.txtPordentajeEndeudamiento.Size = New System.Drawing.Size(88, 20)
        Me.txtPordentajeEndeudamiento.TabIndex = 76
        '
        'lblPorcentajeEndeudamiento
        '
        Me.lblPorcentajeEndeudamiento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPorcentajeEndeudamiento.Location = New System.Drawing.Point(488, 328)
        Me.lblPorcentajeEndeudamiento.Name = "lblPorcentajeEndeudamiento"
        Me.lblPorcentajeEndeudamiento.Size = New System.Drawing.Size(157, 13)
        Me.lblPorcentajeEndeudamiento.TabIndex = 75
        Me.lblPorcentajeEndeudamiento.Text = "Porcentaje Legal Endeudamiento"
        '
        'rdgQuienFirmaResolucion
        '
        Me.rdgQuienFirmaResolucion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rdgQuienFirmaResolucion.EditValue = 0
        Me.rdgQuienFirmaResolucion.Location = New System.Drawing.Point(369, 353)
        Me.rdgQuienFirmaResolucion.Name = "rdgQuienFirmaResolucion"
        Me.rdgQuienFirmaResolucion.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Director Administrativo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Subrogante")})
        Me.rdgQuienFirmaResolucion.Size = New System.Drawing.Size(288, 32)
        Me.rdgQuienFirmaResolucion.TabIndex = 19
        Me.rdgQuienFirmaResolucion.ToolTip = "Seleccione quien firma las resoluciones"
        '
        'lblQuienFirmaResoluciones
        '
        Me.lblQuienFirmaResoluciones.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblQuienFirmaResoluciones.Location = New System.Drawing.Point(152, 360)
        Me.lblQuienFirmaResoluciones.Name = "lblQuienFirmaResoluciones"
        Me.lblQuienFirmaResoluciones.Size = New System.Drawing.Size(122, 13)
        Me.lblQuienFirmaResoluciones.TabIndex = 74
        Me.lblQuienFirmaResoluciones.Text = "Quien Firma Resoluciones"
        '
        'lblPorcentajeDescuentoBienestar
        '
        Me.lblPorcentajeDescuentoBienestar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPorcentajeDescuentoBienestar.Location = New System.Drawing.Point(488, 254)
        Me.lblPorcentajeDescuentoBienestar.Name = "lblPorcentajeDescuentoBienestar"
        Me.lblPorcentajeDescuentoBienestar.Size = New System.Drawing.Size(154, 13)
        Me.lblPorcentajeDescuentoBienestar.TabIndex = 72
        Me.lblPorcentajeDescuentoBienestar.Text = "Porcentaje Descuento Bienestar"
        '
        'txtAporteInstitucional
        '
        Me.txtAporteInstitucional.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAporteInstitucional.Location = New System.Drawing.Point(721, 297)
        Me.txtAporteInstitucional.Name = "txtAporteInstitucional"
        Me.txtAporteInstitucional.Properties.DisplayFormat.FormatString = "n0"
        Me.txtAporteInstitucional.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAporteInstitucional.Properties.EditFormat.FormatString = "n0"
        Me.txtAporteInstitucional.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAporteInstitucional.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAporteInstitucional.Properties.MaxLength = 6
        Me.txtAporteInstitucional.Size = New System.Drawing.Size(88, 20)
        Me.txtAporteInstitucional.TabIndex = 17
        '
        'lblAporteInstitucional
        '
        Me.lblAporteInstitucional.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAporteInstitucional.Location = New System.Drawing.Point(488, 302)
        Me.lblAporteInstitucional.Name = "lblAporteInstitucional"
        Me.lblAporteInstitucional.Size = New System.Drawing.Size(127, 13)
        Me.lblAporteInstitucional.TabIndex = 70
        Me.lblAporteInstitucional.Text = "Monto Aporte Institucional"
        '
        'txtUFMesAnterior
        '
        Me.txtUFMesAnterior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUFMesAnterior.Location = New System.Drawing.Point(369, 297)
        Me.txtUFMesAnterior.Name = "txtUFMesAnterior"
        Me.txtUFMesAnterior.Size = New System.Drawing.Size(96, 20)
        Me.txtUFMesAnterior.TabIndex = 16
        '
        'lblValorUfMesAnterior
        '
        Me.lblValorUfMesAnterior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblValorUfMesAnterior.Location = New System.Drawing.Point(152, 302)
        Me.lblValorUfMesAnterior.Name = "lblValorUfMesAnterior"
        Me.lblValorUfMesAnterior.Size = New System.Drawing.Size(112, 13)
        Me.lblValorUfMesAnterior.TabIndex = 69
        Me.lblValorUfMesAnterior.Text = "Valor U.F. Mes Anterior"
        '
        'txtCopiasResolucion
        '
        Me.txtCopiasResolucion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCopiasResolucion.Location = New System.Drawing.Point(369, 321)
        Me.txtCopiasResolucion.Name = "txtCopiasResolucion"
        Me.txtCopiasResolucion.Size = New System.Drawing.Size(96, 20)
        Me.txtCopiasResolucion.TabIndex = 18
        '
        'lblCopiaPiePagina
        '
        Me.lblCopiaPiePagina.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCopiaPiePagina.Location = New System.Drawing.Point(152, 326)
        Me.lblCopiaPiePagina.Name = "lblCopiaPiePagina"
        Me.lblCopiaPiePagina.Size = New System.Drawing.Size(156, 13)
        Me.lblCopiaPiePagina.TabIndex = 67
        Me.lblCopiaPiePagina.Text = "Copia Resolución (Pie de Página)"
        '
        'lblCodigoConvenioRemuneracionPrevired
        '
        Me.lblCodigoConvenioRemuneracionPrevired.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCodigoConvenioRemuneracionPrevired.Location = New System.Drawing.Point(488, 230)
        Me.lblCodigoConvenioRemuneracionPrevired.Name = "lblCodigoConvenioRemuneracionPrevired"
        Me.lblCodigoConvenioRemuneracionPrevired.Size = New System.Drawing.Size(223, 13)
        Me.lblCodigoConvenioRemuneracionPrevired.TabIndex = 66
        Me.lblCodigoConvenioRemuneracionPrevired.Text = "Código convenio abono remuneración previred"
        '
        'txtPorcentajeIncrementoPrevisionalDL3501
        '
        Me.txtPorcentajeIncrementoPrevisionalDL3501.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPorcentajeIncrementoPrevisionalDL3501.Location = New System.Drawing.Point(721, 273)
        Me.txtPorcentajeIncrementoPrevisionalDL3501.Name = "txtPorcentajeIncrementoPrevisionalDL3501"
        Me.txtPorcentajeIncrementoPrevisionalDL3501.Size = New System.Drawing.Size(88, 20)
        Me.txtPorcentajeIncrementoPrevisionalDL3501.TabIndex = 15
        '
        'lblPorcentajeIncrementoPrevisionalDL3501
        '
        Me.lblPorcentajeIncrementoPrevisionalDL3501.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPorcentajeIncrementoPrevisionalDL3501.Location = New System.Drawing.Point(488, 278)
        Me.lblPorcentajeIncrementoPrevisionalDL3501.Name = "lblPorcentajeIncrementoPrevisionalDL3501"
        Me.lblPorcentajeIncrementoPrevisionalDL3501.Size = New System.Drawing.Size(204, 13)
        Me.lblPorcentajeIncrementoPrevisionalDL3501.TabIndex = 64
        Me.lblPorcentajeIncrementoPrevisionalDL3501.Text = "Porcentaje incremento previsional DL 3501"
        '
        'txtPorcentajeDescuentoBienestar
        '
        Me.txtPorcentajeDescuentoBienestar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPorcentajeDescuentoBienestar.Location = New System.Drawing.Point(721, 249)
        Me.txtPorcentajeDescuentoBienestar.Name = "txtPorcentajeDescuentoBienestar"
        Me.txtPorcentajeDescuentoBienestar.Size = New System.Drawing.Size(88, 20)
        Me.txtPorcentajeDescuentoBienestar.TabIndex = 14
        '
        'txtCodigoConvenioAbonoPrevired
        '
        Me.txtCodigoConvenioAbonoPrevired.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCodigoConvenioAbonoPrevired.Location = New System.Drawing.Point(721, 225)
        Me.txtCodigoConvenioAbonoPrevired.Name = "txtCodigoConvenioAbonoPrevired"
        Me.txtCodigoConvenioAbonoPrevired.Size = New System.Drawing.Size(88, 20)
        Me.txtCodigoConvenioAbonoPrevired.TabIndex = 13
        '
        'txtMensajeColillaPago
        '
        Me.txtMensajeColillaPago.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMensajeColillaPago.Location = New System.Drawing.Point(489, 145)
        Me.txtMensajeColillaPago.Name = "txtMensajeColillaPago"
        Me.txtMensajeColillaPago.Size = New System.Drawing.Size(320, 72)
        Me.txtMensajeColillaPago.TabIndex = 12
        '
        'lblMensajeColillaPago
        '
        Me.lblMensajeColillaPago.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMensajeColillaPago.Location = New System.Drawing.Point(488, 128)
        Me.lblMensajeColillaPago.Name = "lblMensajeColillaPago"
        Me.lblMensajeColillaPago.Size = New System.Drawing.Size(136, 13)
        Me.lblMensajeColillaPago.TabIndex = 59
        Me.lblMensajeColillaPago.Text = "Mensaje en la colilla de pago"
        '
        'txtTopeImponibleOtrosCalculos
        '
        Me.txtTopeImponibleOtrosCalculos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTopeImponibleOtrosCalculos.Location = New System.Drawing.Point(705, 105)
        Me.txtTopeImponibleOtrosCalculos.Name = "txtTopeImponibleOtrosCalculos"
        Me.txtTopeImponibleOtrosCalculos.Size = New System.Drawing.Size(101, 20)
        Me.txtTopeImponibleOtrosCalculos.TabIndex = 11
        '
        'lblTopeImponibleOtrosCalculos
        '
        Me.lblTopeImponibleOtrosCalculos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTopeImponibleOtrosCalculos.Location = New System.Drawing.Point(488, 110)
        Me.lblTopeImponibleOtrosCalculos.Name = "lblTopeImponibleOtrosCalculos"
        Me.lblTopeImponibleOtrosCalculos.Size = New System.Drawing.Size(178, 13)
        Me.lblTopeImponibleOtrosCalculos.TabIndex = 57
        Me.lblTopeImponibleOtrosCalculos.Text = "Tope imponible en U.F. otros cálculos"
        '
        'txtTopeImponiblePrevisional
        '
        Me.txtTopeImponiblePrevisional.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTopeImponiblePrevisional.Location = New System.Drawing.Point(369, 273)
        Me.txtTopeImponiblePrevisional.Name = "txtTopeImponiblePrevisional"
        Me.txtTopeImponiblePrevisional.Size = New System.Drawing.Size(96, 20)
        Me.txtTopeImponiblePrevisional.TabIndex = 10
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelControl5.Location = New System.Drawing.Point(152, 278)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(164, 13)
        Me.LabelControl5.TabIndex = 55
        Me.LabelControl5.Text = "Tope imponible en U.F. previsional"
        '
        'txtPorcentajeTopeSalud
        '
        Me.txtPorcentajeTopeSalud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPorcentajeTopeSalud.Location = New System.Drawing.Point(369, 249)
        Me.txtPorcentajeTopeSalud.Name = "txtPorcentajeTopeSalud"
        Me.txtPorcentajeTopeSalud.Size = New System.Drawing.Size(96, 20)
        Me.txtPorcentajeTopeSalud.TabIndex = 9
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelControl4.Location = New System.Drawing.Point(152, 254)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(105, 13)
        Me.LabelControl4.TabIndex = 53
        Me.LabelControl4.Text = "Porcentaje tope salud"
        '
        'txtPorcentajeGastoRepresentacion
        '
        Me.txtPorcentajeGastoRepresentacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPorcentajeGastoRepresentacion.Location = New System.Drawing.Point(369, 225)
        Me.txtPorcentajeGastoRepresentacion.Name = "txtPorcentajeGastoRepresentacion"
        Me.txtPorcentajeGastoRepresentacion.Size = New System.Drawing.Size(96, 20)
        Me.txtPorcentajeGastoRepresentacion.TabIndex = 8
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelControl3.Location = New System.Drawing.Point(152, 230)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(157, 13)
        Me.LabelControl3.TabIndex = 51
        Me.LabelControl3.Text = "Porcentaje gasto representación"
        '
        'txtPorcentajeMaximoViatico
        '
        Me.txtPorcentajeMaximoViatico.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPorcentajeMaximoViatico.Location = New System.Drawing.Point(369, 201)
        Me.txtPorcentajeMaximoViatico.Name = "txtPorcentajeMaximoViatico"
        Me.txtPorcentajeMaximoViatico.Size = New System.Drawing.Size(96, 20)
        Me.txtPorcentajeMaximoViatico.TabIndex = 7
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelControl2.Location = New System.Drawing.Point(152, 206)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(125, 13)
        Me.LabelControl2.TabIndex = 49
        Me.LabelControl2.Text = "Porcentaje máximo viático"
        '
        'txtEdadLegal
        '
        Me.txtEdadLegal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEdadLegal.Location = New System.Drawing.Point(369, 177)
        Me.txtEdadLegal.Name = "txtEdadLegal"
        Me.txtEdadLegal.Size = New System.Drawing.Size(96, 20)
        Me.txtEdadLegal.TabIndex = 6
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelControl1.Location = New System.Drawing.Point(152, 182)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl1.TabIndex = 47
        Me.LabelControl1.Text = "Edad legal mínima"
        '
        'txtValorUTM
        '
        Me.txtValorUTM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtValorUTM.Location = New System.Drawing.Point(369, 153)
        Me.txtValorUTM.Name = "txtValorUTM"
        Me.txtValorUTM.Size = New System.Drawing.Size(96, 20)
        Me.txtValorUTM.TabIndex = 5
        '
        'lblValorUTM
        '
        Me.lblValorUTM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblValorUTM.Location = New System.Drawing.Point(152, 158)
        Me.lblValorUTM.Name = "lblValorUTM"
        Me.lblValorUTM.Size = New System.Drawing.Size(60, 13)
        Me.lblValorUTM.TabIndex = 45
        Me.lblValorUTM.Text = "Valor U.T.M."
        '
        'txtValorUF
        '
        Me.txtValorUF.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtValorUF.Location = New System.Drawing.Point(369, 129)
        Me.txtValorUF.Name = "txtValorUF"
        Me.txtValorUF.Size = New System.Drawing.Size(96, 20)
        Me.txtValorUF.TabIndex = 4
        '
        'lblValorUF
        '
        Me.lblValorUF.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblValorUF.Location = New System.Drawing.Point(152, 134)
        Me.lblValorUF.Name = "lblValorUF"
        Me.lblValorUF.Size = New System.Drawing.Size(48, 13)
        Me.lblValorUF.TabIndex = 43
        Me.lblValorUF.Text = "Valor U.F."
        '
        'lblFechaPago
        '
        Me.lblFechaPago.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFechaPago.Location = New System.Drawing.Point(152, 110)
        Me.lblFechaPago.Name = "lblFechaPago"
        Me.lblFechaPago.Size = New System.Drawing.Size(71, 13)
        Me.lblFechaPago.TabIndex = 42
        Me.lblFechaPago.Text = "Fecha de pago"
        '
        'deFechaPago
        '
        Me.deFechaPago.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.deFechaPago.EditValue = Nothing
        Me.deFechaPago.Location = New System.Drawing.Point(369, 105)
        Me.deFechaPago.Name = "deFechaPago"
        Me.deFechaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaPago.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deFechaPago.Size = New System.Drawing.Size(96, 20)
        Me.deFechaPago.TabIndex = 3
        '
        'ControlHorasExtras
        '
        Me.ControlHorasExtras.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ControlHorasExtras.Appearance.Header.Options.UseFont = True
        Me.ControlHorasExtras.Controls.Add(Me.dedFechaCierreRatifHorasExtras)
        Me.ControlHorasExtras.Controls.Add(Me.chkAplicaViaticoValoresAntiguos)
        Me.ControlHorasExtras.Controls.Add(Me.LabelControl7)
        Me.ControlHorasExtras.Controls.Add(Me.chkAplicaCalculoHrsExtrasMesAnterior)
        Me.ControlHorasExtras.Controls.Add(Me.chkAplicaDescuentoInasistenciaMedioDia)
        Me.ControlHorasExtras.Controls.Add(Me.chkAplicaDescuentoAtraso)
        Me.ControlHorasExtras.Controls.Add(Me.lueIdentificadorItemDescuentoInasistenciaMedioDía)
        Me.ControlHorasExtras.Controls.Add(Me.lblIdentificadorItemDescuentoInasistenciaMedioDía)
        Me.ControlHorasExtras.Controls.Add(Me.lueItemHorasAtraso)
        Me.ControlHorasExtras.Controls.Add(Me.lblIdentificadorÍtemHorasAtraso)
        Me.ControlHorasExtras.Controls.Add(Me.lueIdentificadorItemHorasExtrasNocturnas)
        Me.ControlHorasExtras.Controls.Add(Me.lueIdentificadorItemHorasExtrasDiurnas)
        Me.ControlHorasExtras.Controls.Add(Me.txtPorcentajeRecargaHorasExtrasNocturnas)
        Me.ControlHorasExtras.Controls.Add(Me.lblPorcentajeRecargaHorasExtrasNocturnas)
        Me.ControlHorasExtras.Controls.Add(Me.txtPorcentajeRecargaHorasEstrasDiurnas)
        Me.ControlHorasExtras.Controls.Add(Me.lblPorcentajeRecargaHorasExtrasDiurnas)
        Me.ControlHorasExtras.Controls.Add(Me.lblIdentificadorItemHorasExtrasNocturnas)
        Me.ControlHorasExtras.Controls.Add(Me.lblIdentificadorItemHorasExtrasDiurnas)
        Me.ControlHorasExtras.Controls.Add(Me.txtHorasExtrasNocturnasLegalPermitidas)
        Me.ControlHorasExtras.Controls.Add(Me.lblHorasExtrasNocturnasLegalPermitidas)
        Me.ControlHorasExtras.Controls.Add(Me.txtHorasExtrasDiurnasLegalPermitidas)
        Me.ControlHorasExtras.Controls.Add(Me.lblHorasEstrasDiurnasLegalesPermitidas)
        Me.ControlHorasExtras.Controls.Add(Me.txtHorasLegalTrabajadasDiarias)
        Me.ControlHorasExtras.Controls.Add(Me.lblHorasLegalTrabajadasDiarias)
        Me.ControlHorasExtras.Name = "ControlHorasExtras"
        Me.ControlHorasExtras.Size = New System.Drawing.Size(961, 483)
        Me.ControlHorasExtras.Text = "Control de horas extras"
        '
        'dedFechaCierreRatifHorasExtras
        '
        Me.dedFechaCierreRatifHorasExtras.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dedFechaCierreRatifHorasExtras.EditValue = Nothing
        Me.dedFechaCierreRatifHorasExtras.Location = New System.Drawing.Point(449, 337)
        Me.dedFechaCierreRatifHorasExtras.Name = "dedFechaCierreRatifHorasExtras"
        Me.dedFechaCierreRatifHorasExtras.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaCierreRatifHorasExtras.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaCierreRatifHorasExtras.Size = New System.Drawing.Size(176, 20)
        Me.dedFechaCierreRatifHorasExtras.TabIndex = 27
        '
        'chkAplicaViaticoValoresAntiguos
        '
        Me.chkAplicaViaticoValoresAntiguos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkAplicaViaticoValoresAntiguos.Location = New System.Drawing.Point(177, 409)
        Me.chkAplicaViaticoValoresAntiguos.Name = "chkAplicaViaticoValoresAntiguos"
        Me.chkAplicaViaticoValoresAntiguos.Properties.Caption = "Aplica Víaticos con Valores Antes del Reajuste"
        Me.chkAplicaViaticoValoresAntiguos.Size = New System.Drawing.Size(312, 19)
        Me.chkAplicaViaticoValoresAntiguos.TabIndex = 29
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelControl7.Location = New System.Drawing.Point(177, 345)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(227, 13)
        Me.LabelControl7.TabIndex = 96
        Me.LabelControl7.Text = "Fecha Cierre Ratificación Horas Extras Intranet"
        '
        'chkAplicaCalculoHrsExtrasMesAnterior
        '
        Me.chkAplicaCalculoHrsExtrasMesAnterior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkAplicaCalculoHrsExtrasMesAnterior.Location = New System.Drawing.Point(177, 377)
        Me.chkAplicaCalculoHrsExtrasMesAnterior.Name = "chkAplicaCalculoHrsExtrasMesAnterior"
        Me.chkAplicaCalculoHrsExtrasMesAnterior.Properties.Caption = "Aplica Calculo Horas Extras con Asignaciones Mes Anterior"
        Me.chkAplicaCalculoHrsExtrasMesAnterior.Size = New System.Drawing.Size(312, 19)
        Me.chkAplicaCalculoHrsExtrasMesAnterior.TabIndex = 28
        '
        'chkAplicaDescuentoInasistenciaMedioDia
        '
        Me.chkAplicaDescuentoInasistenciaMedioDia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkAplicaDescuentoInasistenciaMedioDia.Location = New System.Drawing.Point(645, 305)
        Me.chkAplicaDescuentoInasistenciaMedioDia.Name = "chkAplicaDescuentoInasistenciaMedioDia"
        Me.chkAplicaDescuentoInasistenciaMedioDia.Properties.Caption = "Aplica Descuento Inasistencia por 1/2 Día"
        Me.chkAplicaDescuentoInasistenciaMedioDia.Size = New System.Drawing.Size(240, 19)
        Me.chkAplicaDescuentoInasistenciaMedioDia.TabIndex = 26
        '
        'chkAplicaDescuentoAtraso
        '
        Me.chkAplicaDescuentoAtraso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkAplicaDescuentoAtraso.Location = New System.Drawing.Point(645, 273)
        Me.chkAplicaDescuentoAtraso.Name = "chkAplicaDescuentoAtraso"
        Me.chkAplicaDescuentoAtraso.Properties.Caption = "Aplica Descuento por Atraso"
        Me.chkAplicaDescuentoAtraso.Size = New System.Drawing.Size(176, 19)
        Me.chkAplicaDescuentoAtraso.TabIndex = 24
        '
        'lueIdentificadorItemDescuentoInasistenciaMedioDía
        '
        Me.lueIdentificadorItemDescuentoInasistenciaMedioDía.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueIdentificadorItemDescuentoInasistenciaMedioDía.Location = New System.Drawing.Point(448, 305)
        Me.lueIdentificadorItemDescuentoInasistenciaMedioDía.Name = "lueIdentificadorItemDescuentoInasistenciaMedioDía"
        Me.lueIdentificadorItemDescuentoInasistenciaMedioDía.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueIdentificadorItemDescuentoInasistenciaMedioDía.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueIdentificadorItemDescuentoInasistenciaMedioDía.Size = New System.Drawing.Size(177, 20)
        Me.lueIdentificadorItemDescuentoInasistenciaMedioDía.TabIndex = 25
        '
        'lblIdentificadorItemDescuentoInasistenciaMedioDía
        '
        Me.lblIdentificadorItemDescuentoInasistenciaMedioDía.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIdentificadorItemDescuentoInasistenciaMedioDía.Location = New System.Drawing.Point(176, 313)
        Me.lblIdentificadorItemDescuentoInasistenciaMedioDía.Name = "lblIdentificadorItemDescuentoInasistenciaMedioDía"
        Me.lblIdentificadorItemDescuentoInasistenciaMedioDía.Size = New System.Drawing.Size(237, 13)
        Me.lblIdentificadorItemDescuentoInasistenciaMedioDía.TabIndex = 89
        Me.lblIdentificadorItemDescuentoInasistenciaMedioDía.Text = "Identificador Ítem Descuento Inasistencia 1/2 Día"
        '
        'lueItemHorasAtraso
        '
        Me.lueItemHorasAtraso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueItemHorasAtraso.Location = New System.Drawing.Point(449, 273)
        Me.lueItemHorasAtraso.Name = "lueItemHorasAtraso"
        Me.lueItemHorasAtraso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueItemHorasAtraso.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueItemHorasAtraso.Size = New System.Drawing.Size(176, 20)
        Me.lueItemHorasAtraso.TabIndex = 23
        '
        'lblIdentificadorÍtemHorasAtraso
        '
        Me.lblIdentificadorÍtemHorasAtraso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIdentificadorÍtemHorasAtraso.Location = New System.Drawing.Point(177, 279)
        Me.lblIdentificadorÍtemHorasAtraso.Name = "lblIdentificadorÍtemHorasAtraso"
        Me.lblIdentificadorÍtemHorasAtraso.Size = New System.Drawing.Size(206, 13)
        Me.lblIdentificadorÍtemHorasAtraso.TabIndex = 87
        Me.lblIdentificadorÍtemHorasAtraso.Text = "Identificador Ítem Descuento Horas Atraso"
        '
        'lueIdentificadorItemHorasExtrasNocturnas
        '
        Me.lueIdentificadorItemHorasExtrasNocturnas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueIdentificadorItemHorasExtrasNocturnas.Location = New System.Drawing.Point(449, 177)
        Me.lueIdentificadorItemHorasExtrasNocturnas.Name = "lueIdentificadorItemHorasExtrasNocturnas"
        Me.lueIdentificadorItemHorasExtrasNocturnas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueIdentificadorItemHorasExtrasNocturnas.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueIdentificadorItemHorasExtrasNocturnas.Size = New System.Drawing.Size(336, 20)
        Me.lueIdentificadorItemHorasExtrasNocturnas.TabIndex = 86
        '
        'lueIdentificadorItemHorasExtrasDiurnas
        '
        Me.lueIdentificadorItemHorasExtrasDiurnas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueIdentificadorItemHorasExtrasDiurnas.Location = New System.Drawing.Point(449, 145)
        Me.lueIdentificadorItemHorasExtrasDiurnas.Name = "lueIdentificadorItemHorasExtrasDiurnas"
        Me.lueIdentificadorItemHorasExtrasDiurnas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueIdentificadorItemHorasExtrasDiurnas.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueIdentificadorItemHorasExtrasDiurnas.Size = New System.Drawing.Size(336, 20)
        Me.lueIdentificadorItemHorasExtrasDiurnas.TabIndex = 85
        '
        'txtPorcentajeRecargaHorasExtrasNocturnas
        '
        Me.txtPorcentajeRecargaHorasExtrasNocturnas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPorcentajeRecargaHorasExtrasNocturnas.Location = New System.Drawing.Point(448, 241)
        Me.txtPorcentajeRecargaHorasExtrasNocturnas.Name = "txtPorcentajeRecargaHorasExtrasNocturnas"
        Me.txtPorcentajeRecargaHorasExtrasNocturnas.Size = New System.Drawing.Size(336, 20)
        Me.txtPorcentajeRecargaHorasExtrasNocturnas.TabIndex = 22
        '
        'lblPorcentajeRecargaHorasExtrasNocturnas
        '
        Me.lblPorcentajeRecargaHorasExtrasNocturnas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPorcentajeRecargaHorasExtrasNocturnas.Location = New System.Drawing.Point(176, 247)
        Me.lblPorcentajeRecargaHorasExtrasNocturnas.Name = "lblPorcentajeRecargaHorasExtrasNocturnas"
        Me.lblPorcentajeRecargaHorasExtrasNocturnas.Size = New System.Drawing.Size(212, 13)
        Me.lblPorcentajeRecargaHorasExtrasNocturnas.TabIndex = 66
        Me.lblPorcentajeRecargaHorasExtrasNocturnas.Text = "Porcentaje Recarga Horas Extras Nocturnas"
        '
        'txtPorcentajeRecargaHorasEstrasDiurnas
        '
        Me.txtPorcentajeRecargaHorasEstrasDiurnas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPorcentajeRecargaHorasEstrasDiurnas.Location = New System.Drawing.Point(448, 209)
        Me.txtPorcentajeRecargaHorasEstrasDiurnas.Name = "txtPorcentajeRecargaHorasEstrasDiurnas"
        Me.txtPorcentajeRecargaHorasEstrasDiurnas.Size = New System.Drawing.Size(336, 20)
        Me.txtPorcentajeRecargaHorasEstrasDiurnas.TabIndex = 21
        '
        'lblPorcentajeRecargaHorasExtrasDiurnas
        '
        Me.lblPorcentajeRecargaHorasExtrasDiurnas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPorcentajeRecargaHorasExtrasDiurnas.Location = New System.Drawing.Point(176, 215)
        Me.lblPorcentajeRecargaHorasExtrasDiurnas.Name = "lblPorcentajeRecargaHorasExtrasDiurnas"
        Me.lblPorcentajeRecargaHorasExtrasDiurnas.Size = New System.Drawing.Size(199, 13)
        Me.lblPorcentajeRecargaHorasExtrasDiurnas.TabIndex = 64
        Me.lblPorcentajeRecargaHorasExtrasDiurnas.Text = "Porcentaje Recarga Horas Extras Diurnas"
        '
        'lblIdentificadorItemHorasExtrasNocturnas
        '
        Me.lblIdentificadorItemHorasExtrasNocturnas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIdentificadorItemHorasExtrasNocturnas.Location = New System.Drawing.Point(176, 183)
        Me.lblIdentificadorItemHorasExtrasNocturnas.Name = "lblIdentificadorItemHorasExtrasNocturnas"
        Me.lblIdentificadorItemHorasExtrasNocturnas.Size = New System.Drawing.Size(203, 13)
        Me.lblIdentificadorItemHorasExtrasNocturnas.TabIndex = 62
        Me.lblIdentificadorItemHorasExtrasNocturnas.Text = "Identificador Ítem Horas Extras Nocturnas"
        '
        'lblIdentificadorItemHorasExtrasDiurnas
        '
        Me.lblIdentificadorItemHorasExtrasDiurnas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIdentificadorItemHorasExtrasDiurnas.Location = New System.Drawing.Point(176, 151)
        Me.lblIdentificadorItemHorasExtrasDiurnas.Name = "lblIdentificadorItemHorasExtrasDiurnas"
        Me.lblIdentificadorItemHorasExtrasDiurnas.Size = New System.Drawing.Size(190, 13)
        Me.lblIdentificadorItemHorasExtrasDiurnas.TabIndex = 60
        Me.lblIdentificadorItemHorasExtrasDiurnas.Text = "Identificador Ítem Horas Extras Diurnas"
        '
        'txtHorasExtrasNocturnasLegalPermitidas
        '
        Me.txtHorasExtrasNocturnasLegalPermitidas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHorasExtrasNocturnasLegalPermitidas.Location = New System.Drawing.Point(448, 113)
        Me.txtHorasExtrasNocturnasLegalPermitidas.Name = "txtHorasExtrasNocturnasLegalPermitidas"
        Me.txtHorasExtrasNocturnasLegalPermitidas.Size = New System.Drawing.Size(336, 20)
        Me.txtHorasExtrasNocturnasLegalPermitidas.TabIndex = 18
        '
        'lblHorasExtrasNocturnasLegalPermitidas
        '
        Me.lblHorasExtrasNocturnasLegalPermitidas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHorasExtrasNocturnasLegalPermitidas.Location = New System.Drawing.Point(176, 119)
        Me.lblHorasExtrasNocturnasLegalPermitidas.Name = "lblHorasExtrasNocturnasLegalPermitidas"
        Me.lblHorasExtrasNocturnasLegalPermitidas.Size = New System.Drawing.Size(194, 13)
        Me.lblHorasExtrasNocturnasLegalPermitidas.TabIndex = 58
        Me.lblHorasExtrasNocturnasLegalPermitidas.Text = "Horas Extras Nocturnas Legal Permitidas"
        '
        'txtHorasExtrasDiurnasLegalPermitidas
        '
        Me.txtHorasExtrasDiurnasLegalPermitidas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHorasExtrasDiurnasLegalPermitidas.Location = New System.Drawing.Point(448, 81)
        Me.txtHorasExtrasDiurnasLegalPermitidas.Name = "txtHorasExtrasDiurnasLegalPermitidas"
        Me.txtHorasExtrasDiurnasLegalPermitidas.Size = New System.Drawing.Size(336, 20)
        Me.txtHorasExtrasDiurnasLegalPermitidas.TabIndex = 17
        '
        'lblHorasEstrasDiurnasLegalesPermitidas
        '
        Me.lblHorasEstrasDiurnasLegalesPermitidas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHorasEstrasDiurnasLegalesPermitidas.Location = New System.Drawing.Point(176, 87)
        Me.lblHorasEstrasDiurnasLegalesPermitidas.Name = "lblHorasEstrasDiurnasLegalesPermitidas"
        Me.lblHorasEstrasDiurnasLegalesPermitidas.Size = New System.Drawing.Size(181, 13)
        Me.lblHorasEstrasDiurnasLegalesPermitidas.TabIndex = 56
        Me.lblHorasEstrasDiurnasLegalesPermitidas.Text = "Horas Extras Diurnas Legal Permitidas"
        '
        'txtHorasLegalTrabajadasDiarias
        '
        Me.txtHorasLegalTrabajadasDiarias.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHorasLegalTrabajadasDiarias.Location = New System.Drawing.Point(449, 49)
        Me.txtHorasLegalTrabajadasDiarias.Name = "txtHorasLegalTrabajadasDiarias"
        Me.txtHorasLegalTrabajadasDiarias.Size = New System.Drawing.Size(336, 20)
        Me.txtHorasLegalTrabajadasDiarias.TabIndex = 16
        '
        'lblHorasLegalTrabajadasDiarias
        '
        Me.lblHorasLegalTrabajadasDiarias.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHorasLegalTrabajadasDiarias.Location = New System.Drawing.Point(176, 55)
        Me.lblHorasLegalTrabajadasDiarias.Name = "lblHorasLegalTrabajadasDiarias"
        Me.lblHorasLegalTrabajadasDiarias.Size = New System.Drawing.Size(142, 13)
        Me.lblHorasLegalTrabajadasDiarias.TabIndex = 54
        Me.lblHorasLegalTrabajadasDiarias.Text = "Horas legal trabajadas diarias"
        '
        'MutualSeguridad
        '
        Me.MutualSeguridad.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MutualSeguridad.Appearance.Header.Options.UseFont = True
        Me.MutualSeguridad.Controls.Add(Me.lueIdentificadorItemMutualSeguridad)
        Me.MutualSeguridad.Controls.Add(Me.lblIdentificadorItemMutualSeguridad)
        Me.MutualSeguridad.Controls.Add(Me.txtFactorMensualMutualSeguridad)
        Me.MutualSeguridad.Controls.Add(Me.lblFactorMensualDeSeguridad)
        Me.MutualSeguridad.Controls.Add(Me.txtCodigoPreviredInstitucion)
        Me.MutualSeguridad.Controls.Add(Me.lblCodigoPreviredInstitucion)
        Me.MutualSeguridad.Controls.Add(Me.txtNombreInstitucionSeguridad)
        Me.MutualSeguridad.Controls.Add(Me.lblNombreInstitucionDeSeguridad)
        Me.MutualSeguridad.Name = "MutualSeguridad"
        Me.MutualSeguridad.Size = New System.Drawing.Size(961, 483)
        Me.MutualSeguridad.Text = "Mutual de seguridad"
        '
        'lueIdentificadorItemMutualSeguridad
        '
        Me.lueIdentificadorItemMutualSeguridad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueIdentificadorItemMutualSeguridad.Location = New System.Drawing.Point(449, 281)
        Me.lueIdentificadorItemMutualSeguridad.Name = "lueIdentificadorItemMutualSeguridad"
        Me.lueIdentificadorItemMutualSeguridad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueIdentificadorItemMutualSeguridad.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueIdentificadorItemMutualSeguridad.Size = New System.Drawing.Size(336, 20)
        Me.lueIdentificadorItemMutualSeguridad.TabIndex = 87
        '
        'lblIdentificadorItemMutualSeguridad
        '
        Me.lblIdentificadorItemMutualSeguridad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIdentificadorItemMutualSeguridad.Location = New System.Drawing.Point(176, 279)
        Me.lblIdentificadorItemMutualSeguridad.Name = "lblIdentificadorItemMutualSeguridad"
        Me.lblIdentificadorItemMutualSeguridad.Size = New System.Drawing.Size(169, 13)
        Me.lblIdentificadorItemMutualSeguridad.TabIndex = 62
        Me.lblIdentificadorItemMutualSeguridad.Text = "Identificador ítem mutual seguridad"
        '
        'txtFactorMensualMutualSeguridad
        '
        Me.txtFactorMensualMutualSeguridad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFactorMensualMutualSeguridad.Location = New System.Drawing.Point(449, 249)
        Me.txtFactorMensualMutualSeguridad.Name = "txtFactorMensualMutualSeguridad"
        Me.txtFactorMensualMutualSeguridad.Size = New System.Drawing.Size(336, 20)
        Me.txtFactorMensualMutualSeguridad.TabIndex = 25
        '
        'lblFactorMensualDeSeguridad
        '
        Me.lblFactorMensualDeSeguridad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFactorMensualDeSeguridad.Location = New System.Drawing.Point(176, 247)
        Me.lblFactorMensualDeSeguridad.Name = "lblFactorMensualDeSeguridad"
        Me.lblFactorMensualDeSeguridad.Size = New System.Drawing.Size(173, 13)
        Me.lblFactorMensualDeSeguridad.TabIndex = 60
        Me.lblFactorMensualDeSeguridad.Text = "Factor mensual mutual de seguridad"
        '
        'txtCodigoPreviredInstitucion
        '
        Me.txtCodigoPreviredInstitucion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCodigoPreviredInstitucion.Location = New System.Drawing.Point(448, 217)
        Me.txtCodigoPreviredInstitucion.Name = "txtCodigoPreviredInstitucion"
        Me.txtCodigoPreviredInstitucion.Size = New System.Drawing.Size(336, 20)
        Me.txtCodigoPreviredInstitucion.TabIndex = 24
        '
        'lblCodigoPreviredInstitucion
        '
        Me.lblCodigoPreviredInstitucion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCodigoPreviredInstitucion.Location = New System.Drawing.Point(176, 215)
        Me.lblCodigoPreviredInstitucion.Name = "lblCodigoPreviredInstitucion"
        Me.lblCodigoPreviredInstitucion.Size = New System.Drawing.Size(136, 13)
        Me.lblCodigoPreviredInstitucion.TabIndex = 58
        Me.lblCodigoPreviredInstitucion.Text = "Código PREVIRED institución"
        '
        'txtNombreInstitucionSeguridad
        '
        Me.txtNombreInstitucionSeguridad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombreInstitucionSeguridad.Location = New System.Drawing.Point(448, 185)
        Me.txtNombreInstitucionSeguridad.Name = "txtNombreInstitucionSeguridad"
        Me.txtNombreInstitucionSeguridad.Size = New System.Drawing.Size(336, 20)
        Me.txtNombreInstitucionSeguridad.TabIndex = 23
        '
        'lblNombreInstitucionDeSeguridad
        '
        Me.lblNombreInstitucionDeSeguridad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNombreInstitucionDeSeguridad.Location = New System.Drawing.Point(176, 183)
        Me.lblNombreInstitucionDeSeguridad.Name = "lblNombreInstitucionDeSeguridad"
        Me.lblNombreInstitucionDeSeguridad.Size = New System.Drawing.Size(153, 13)
        Me.lblNombreInstitucionDeSeguridad.TabIndex = 56
        Me.lblNombreInstitucionDeSeguridad.Text = "Nombre institución de seguridad"
        '
        'SeguroEmpleados
        '
        Me.SeguroEmpleados.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SeguroEmpleados.Appearance.Header.Options.UseFont = True
        Me.SeguroEmpleados.Controls.Add(Me.lueIdentificadorItemSeguroTrabajador2)
        Me.SeguroEmpleados.Controls.Add(Me.lueIdentificadorItemSeguroTrabajador1)
        Me.SeguroEmpleados.Controls.Add(Me.lblIdentificadorItemSeguroTrabajador2)
        Me.SeguroEmpleados.Controls.Add(Me.lblIdentificadorItemSeguroTrabajador1)
        Me.SeguroEmpleados.Controls.Add(Me.txtPorcentaleMensualDescuento2)
        Me.SeguroEmpleados.Controls.Add(Me.lblPorcentaleMensualDescuento2)
        Me.SeguroEmpleados.Controls.Add(Me.txtPorcentaleMensualDescuento1)
        Me.SeguroEmpleados.Controls.Add(Me.lblPorcentaleMensualDescuento1)
        Me.SeguroEmpleados.Controls.Add(Me.txtNombreEmpresaAseguradora)
        Me.SeguroEmpleados.Controls.Add(Me.lblNombreEmpresaAseguradora)
        Me.SeguroEmpleados.Name = "SeguroEmpleados"
        Me.SeguroEmpleados.Size = New System.Drawing.Size(961, 483)
        Me.SeguroEmpleados.Text = "Seguro Empleados"
        '
        'lueIdentificadorItemSeguroTrabajador2
        '
        Me.lueIdentificadorItemSeguroTrabajador2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueIdentificadorItemSeguroTrabajador2.Location = New System.Drawing.Point(449, 297)
        Me.lueIdentificadorItemSeguroTrabajador2.Name = "lueIdentificadorItemSeguroTrabajador2"
        Me.lueIdentificadorItemSeguroTrabajador2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueIdentificadorItemSeguroTrabajador2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueIdentificadorItemSeguroTrabajador2.Size = New System.Drawing.Size(336, 20)
        Me.lueIdentificadorItemSeguroTrabajador2.TabIndex = 89
        '
        'lueIdentificadorItemSeguroTrabajador1
        '
        Me.lueIdentificadorItemSeguroTrabajador1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueIdentificadorItemSeguroTrabajador1.Location = New System.Drawing.Point(449, 265)
        Me.lueIdentificadorItemSeguroTrabajador1.Name = "lueIdentificadorItemSeguroTrabajador1"
        Me.lueIdentificadorItemSeguroTrabajador1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueIdentificadorItemSeguroTrabajador1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueIdentificadorItemSeguroTrabajador1.Size = New System.Drawing.Size(336, 20)
        Me.lueIdentificadorItemSeguroTrabajador1.TabIndex = 88
        '
        'lblIdentificadorItemSeguroTrabajador2
        '
        Me.lblIdentificadorItemSeguroTrabajador2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIdentificadorItemSeguroTrabajador2.Location = New System.Drawing.Point(176, 295)
        Me.lblIdentificadorItemSeguroTrabajador2.Name = "lblIdentificadorItemSeguroTrabajador2"
        Me.lblIdentificadorItemSeguroTrabajador2.Size = New System.Drawing.Size(183, 13)
        Me.lblIdentificadorItemSeguroTrabajador2.TabIndex = 68
        Me.lblIdentificadorItemSeguroTrabajador2.Text = "Identificador ítem seguro trabajador 2"
        '
        'lblIdentificadorItemSeguroTrabajador1
        '
        Me.lblIdentificadorItemSeguroTrabajador1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIdentificadorItemSeguroTrabajador1.Location = New System.Drawing.Point(176, 263)
        Me.lblIdentificadorItemSeguroTrabajador1.Name = "lblIdentificadorItemSeguroTrabajador1"
        Me.lblIdentificadorItemSeguroTrabajador1.Size = New System.Drawing.Size(183, 13)
        Me.lblIdentificadorItemSeguroTrabajador1.TabIndex = 66
        Me.lblIdentificadorItemSeguroTrabajador1.Text = "Identificador ítem seguro trabajador 1"
        '
        'txtPorcentaleMensualDescuento2
        '
        Me.txtPorcentaleMensualDescuento2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPorcentaleMensualDescuento2.Location = New System.Drawing.Point(449, 233)
        Me.txtPorcentaleMensualDescuento2.Name = "txtPorcentaleMensualDescuento2"
        Me.txtPorcentaleMensualDescuento2.Size = New System.Drawing.Size(336, 20)
        Me.txtPorcentaleMensualDescuento2.TabIndex = 29
        '
        'lblPorcentaleMensualDescuento2
        '
        Me.lblPorcentaleMensualDescuento2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPorcentaleMensualDescuento2.Location = New System.Drawing.Point(176, 231)
        Me.lblPorcentaleMensualDescuento2.Name = "lblPorcentaleMensualDescuento2"
        Me.lblPorcentaleMensualDescuento2.Size = New System.Drawing.Size(157, 13)
        Me.lblPorcentaleMensualDescuento2.TabIndex = 64
        Me.lblPorcentaleMensualDescuento2.Text = "Porcentaje Mensual Descuento 2"
        '
        'txtPorcentaleMensualDescuento1
        '
        Me.txtPorcentaleMensualDescuento1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPorcentaleMensualDescuento1.Location = New System.Drawing.Point(449, 201)
        Me.txtPorcentaleMensualDescuento1.Name = "txtPorcentaleMensualDescuento1"
        Me.txtPorcentaleMensualDescuento1.Size = New System.Drawing.Size(336, 20)
        Me.txtPorcentaleMensualDescuento1.TabIndex = 28
        '
        'lblPorcentaleMensualDescuento1
        '
        Me.lblPorcentaleMensualDescuento1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPorcentaleMensualDescuento1.Location = New System.Drawing.Point(176, 199)
        Me.lblPorcentaleMensualDescuento1.Name = "lblPorcentaleMensualDescuento1"
        Me.lblPorcentaleMensualDescuento1.Size = New System.Drawing.Size(157, 13)
        Me.lblPorcentaleMensualDescuento1.TabIndex = 62
        Me.lblPorcentaleMensualDescuento1.Text = "Porcentaje Mensual Descuento 1"
        '
        'txtNombreEmpresaAseguradora
        '
        Me.txtNombreEmpresaAseguradora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombreEmpresaAseguradora.Location = New System.Drawing.Point(448, 169)
        Me.txtNombreEmpresaAseguradora.Name = "txtNombreEmpresaAseguradora"
        Me.txtNombreEmpresaAseguradora.Size = New System.Drawing.Size(336, 20)
        Me.txtNombreEmpresaAseguradora.TabIndex = 27
        '
        'lblNombreEmpresaAseguradora
        '
        Me.lblNombreEmpresaAseguradora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNombreEmpresaAseguradora.Location = New System.Drawing.Point(176, 167)
        Me.lblNombreEmpresaAseguradora.Name = "lblNombreEmpresaAseguradora"
        Me.lblNombreEmpresaAseguradora.Size = New System.Drawing.Size(146, 13)
        Me.lblNombreEmpresaAseguradora.TabIndex = 60
        Me.lblNombreEmpresaAseguradora.Text = "Nombre Empresa Aseguradora"
        '
        'ItemsBaseCalculo
        '
        Me.ItemsBaseCalculo.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ItemsBaseCalculo.Appearance.Header.Options.UseFont = True
        Me.ItemsBaseCalculo.Controls.Add(Me.XtraTabControl1)
        Me.ItemsBaseCalculo.Name = "ItemsBaseCalculo"
        Me.ItemsBaseCalculo.Size = New System.Drawing.Size(961, 483)
        Me.ItemsBaseCalculo.Text = "Ítems base cálculo"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(16, 24)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(938, 450)
        Me.XtraTabControl1.TabIndex = 128
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.lblLey18675Art11)
        Me.XtraTabPage1.Controls.Add(Me.lblAsignacionFamiliar)
        Me.XtraTabPage1.Controls.Add(Me.lueLey18675Art11)
        Me.XtraTabPage1.Controls.Add(Me.lueLey18675Art10)
        Me.XtraTabPage1.Controls.Add(Me.lueLey18566)
        Me.XtraTabPage1.Controls.Add(Me.lueIncrementoPrevisional)
        Me.XtraTabPage1.Controls.Add(Me.lueRetencionJudicial)
        Me.XtraTabPage1.Controls.Add(Me.luelAsignacionFamiliar)
        Me.XtraTabPage1.Controls.Add(Me.lueResponsabilidadSuperior)
        Me.XtraTabPage1.Controls.Add(Me.lueSueldoBase)
        Me.XtraTabPage1.Controls.Add(Me.lueDiasTrabajados)
        Me.XtraTabPage1.Controls.Add(Me.lblLey18675Art10)
        Me.XtraTabPage1.Controls.Add(Me.lblLey18566)
        Me.XtraTabPage1.Controls.Add(Me.lblIncrementoPrevisional)
        Me.XtraTabPage1.Controls.Add(Me.lblRetencionJudicial)
        Me.XtraTabPage1.Controls.Add(Me.lblResponsabilidadSuperior)
        Me.XtraTabPage1.Controls.Add(Me.lblSualdoBase)
        Me.XtraTabPage1.Controls.Add(Me.lblDiasTrabajados)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(931, 421)
        Me.XtraTabPage1.Text = "Página 1 de 3"
        '
        'lblLey18675Art11
        '
        Me.lblLey18675Art11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLey18675Art11.Location = New System.Drawing.Point(242, 298)
        Me.lblLey18675Art11.Name = "lblLey18675Art11"
        Me.lblLey18675Art11.Size = New System.Drawing.Size(91, 13)
        Me.lblLey18675Art11.TabIndex = 129
        Me.lblLey18675Art11.Text = "Ley 18.675 Art. 11"
        '
        'lblAsignacionFamiliar
        '
        Me.lblAsignacionFamiliar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsignacionFamiliar.Location = New System.Drawing.Point(242, 178)
        Me.lblAsignacionFamiliar.Name = "lblAsignacionFamiliar"
        Me.lblAsignacionFamiliar.Size = New System.Drawing.Size(90, 13)
        Me.lblAsignacionFamiliar.TabIndex = 128
        Me.lblAsignacionFamiliar.Text = "Asignación Familiar"
        '
        'lueLey18675Art11
        '
        Me.lueLey18675Art11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueLey18675Art11.Location = New System.Drawing.Point(354, 298)
        Me.lueLey18675Art11.Name = "lueLey18675Art11"
        Me.lueLey18675Art11.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLey18675Art11.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueLey18675Art11.Size = New System.Drawing.Size(336, 20)
        Me.lueLey18675Art11.TabIndex = 127
        '
        'lueLey18675Art10
        '
        Me.lueLey18675Art10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueLey18675Art10.Location = New System.Drawing.Point(354, 274)
        Me.lueLey18675Art10.Name = "lueLey18675Art10"
        Me.lueLey18675Art10.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLey18675Art10.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueLey18675Art10.Size = New System.Drawing.Size(336, 20)
        Me.lueLey18675Art10.TabIndex = 126
        '
        'lueLey18566
        '
        Me.lueLey18566.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueLey18566.Location = New System.Drawing.Point(354, 250)
        Me.lueLey18566.Name = "lueLey18566"
        Me.lueLey18566.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLey18566.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueLey18566.Size = New System.Drawing.Size(336, 20)
        Me.lueLey18566.TabIndex = 125
        '
        'lueIncrementoPrevisional
        '
        Me.lueIncrementoPrevisional.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueIncrementoPrevisional.Location = New System.Drawing.Point(354, 226)
        Me.lueIncrementoPrevisional.Name = "lueIncrementoPrevisional"
        Me.lueIncrementoPrevisional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueIncrementoPrevisional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueIncrementoPrevisional.Size = New System.Drawing.Size(336, 20)
        Me.lueIncrementoPrevisional.TabIndex = 124
        '
        'lueRetencionJudicial
        '
        Me.lueRetencionJudicial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueRetencionJudicial.Location = New System.Drawing.Point(354, 202)
        Me.lueRetencionJudicial.Name = "lueRetencionJudicial"
        Me.lueRetencionJudicial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueRetencionJudicial.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueRetencionJudicial.Size = New System.Drawing.Size(336, 20)
        Me.lueRetencionJudicial.TabIndex = 123
        '
        'luelAsignacionFamiliar
        '
        Me.luelAsignacionFamiliar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.luelAsignacionFamiliar.Location = New System.Drawing.Point(354, 178)
        Me.luelAsignacionFamiliar.Name = "luelAsignacionFamiliar"
        Me.luelAsignacionFamiliar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luelAsignacionFamiliar.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.luelAsignacionFamiliar.Size = New System.Drawing.Size(336, 20)
        Me.luelAsignacionFamiliar.TabIndex = 122
        '
        'lueResponsabilidadSuperior
        '
        Me.lueResponsabilidadSuperior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueResponsabilidadSuperior.Location = New System.Drawing.Point(354, 154)
        Me.lueResponsabilidadSuperior.Name = "lueResponsabilidadSuperior"
        Me.lueResponsabilidadSuperior.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueResponsabilidadSuperior.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueResponsabilidadSuperior.Size = New System.Drawing.Size(336, 20)
        Me.lueResponsabilidadSuperior.TabIndex = 121
        '
        'lueSueldoBase
        '
        Me.lueSueldoBase.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueSueldoBase.Location = New System.Drawing.Point(354, 130)
        Me.lueSueldoBase.Name = "lueSueldoBase"
        Me.lueSueldoBase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueSueldoBase.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueSueldoBase.Size = New System.Drawing.Size(336, 20)
        Me.lueSueldoBase.TabIndex = 120
        '
        'lueDiasTrabajados
        '
        Me.lueDiasTrabajados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueDiasTrabajados.Location = New System.Drawing.Point(354, 106)
        Me.lueDiasTrabajados.Name = "lueDiasTrabajados"
        Me.lueDiasTrabajados.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDiasTrabajados.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueDiasTrabajados.Size = New System.Drawing.Size(336, 20)
        Me.lueDiasTrabajados.TabIndex = 119
        '
        'lblLey18675Art10
        '
        Me.lblLey18675Art10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLey18675Art10.Location = New System.Drawing.Point(242, 274)
        Me.lblLey18675Art10.Name = "lblLey18675Art10"
        Me.lblLey18675Art10.Size = New System.Drawing.Size(88, 13)
        Me.lblLey18675Art10.TabIndex = 118
        Me.lblLey18675Art10.Text = "Ley 18.675 Art.10"
        '
        'lblLey18566
        '
        Me.lblLey18566.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLey18566.Location = New System.Drawing.Point(242, 250)
        Me.lblLey18566.Name = "lblLey18566"
        Me.lblLey18566.Size = New System.Drawing.Size(54, 13)
        Me.lblLey18566.TabIndex = 117
        Me.lblLey18566.Text = "Ley 18.566"
        '
        'lblIncrementoPrevisional
        '
        Me.lblIncrementoPrevisional.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIncrementoPrevisional.Location = New System.Drawing.Point(242, 226)
        Me.lblIncrementoPrevisional.Name = "lblIncrementoPrevisional"
        Me.lblIncrementoPrevisional.Size = New System.Drawing.Size(73, 13)
        Me.lblIncrementoPrevisional.TabIndex = 116
        Me.lblIncrementoPrevisional.Text = "Inc. Previsional"
        '
        'lblRetencionJudicial
        '
        Me.lblRetencionJudicial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRetencionJudicial.Location = New System.Drawing.Point(242, 202)
        Me.lblRetencionJudicial.Name = "lblRetencionJudicial"
        Me.lblRetencionJudicial.Size = New System.Drawing.Size(56, 13)
        Me.lblRetencionJudicial.TabIndex = 115
        Me.lblRetencionJudicial.Text = "Ret. judicial"
        '
        'lblResponsabilidadSuperior
        '
        Me.lblResponsabilidadSuperior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblResponsabilidadSuperior.Location = New System.Drawing.Point(242, 154)
        Me.lblResponsabilidadSuperior.Name = "lblResponsabilidadSuperior"
        Me.lblResponsabilidadSuperior.Size = New System.Drawing.Size(70, 13)
        Me.lblResponsabilidadSuperior.TabIndex = 113
        Me.lblResponsabilidadSuperior.Text = "Resp. superior"
        '
        'lblSualdoBase
        '
        Me.lblSualdoBase.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSualdoBase.Location = New System.Drawing.Point(242, 130)
        Me.lblSualdoBase.Name = "lblSualdoBase"
        Me.lblSualdoBase.Size = New System.Drawing.Size(58, 13)
        Me.lblSualdoBase.TabIndex = 112
        Me.lblSualdoBase.Text = "Sueldo base"
        '
        'lblDiasTrabajados
        '
        Me.lblDiasTrabajados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDiasTrabajados.Location = New System.Drawing.Point(242, 106)
        Me.lblDiasTrabajados.Name = "lblDiasTrabajados"
        Me.lblDiasTrabajados.Size = New System.Drawing.Size(75, 13)
        Me.lblDiasTrabajados.TabIndex = 111
        Me.lblDiasTrabajados.Text = "Días trabajados"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.lueDl3551)
        Me.XtraTabPage2.Controls.Add(Me.lueAsociacionGremial)
        Me.XtraTabPage2.Controls.Add(Me.lueFuncionCritica)
        Me.XtraTabPage2.Controls.Add(Me.lueLey18171)
        Me.XtraTabPage2.Controls.Add(Me.lueGastoRepresentacion)
        Me.XtraTabPage2.Controls.Add(Me.lueFondoBienestar)
        Me.XtraTabPage2.Controls.Add(Me.lueAsignacionAntiguedad)
        Me.XtraTabPage2.Controls.Add(Me.lueLey19185Art19)
        Me.XtraTabPage2.Controls.Add(Me.lueLey19185Art18)
        Me.XtraTabPage2.Controls.Add(Me.lblFuncionCritica)
        Me.XtraTabPage2.Controls.Add(Me.lblLey18171)
        Me.XtraTabPage2.Controls.Add(Me.lblGastoRepresentacion)
        Me.XtraTabPage2.Controls.Add(Me.lblDl3551)
        Me.XtraTabPage2.Controls.Add(Me.lblAsociacionGremial)
        Me.XtraTabPage2.Controls.Add(Me.lblFondoBienestar)
        Me.XtraTabPage2.Controls.Add(Me.lblAsignacionAntiguedad)
        Me.XtraTabPage2.Controls.Add(Me.lblLey19185Art19)
        Me.XtraTabPage2.Controls.Add(Me.lblLey19185Art18)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(931, 421)
        Me.XtraTabPage2.Text = "Página 2 de 3"
        '
        'lueDl3551
        '
        Me.lueDl3551.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueDl3551.Location = New System.Drawing.Point(354, 226)
        Me.lueDl3551.Name = "lueDl3551"
        Me.lueDl3551.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDl3551.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueDl3551.Size = New System.Drawing.Size(336, 20)
        Me.lueDl3551.TabIndex = 145
        '
        'lueAsociacionGremial
        '
        Me.lueAsociacionGremial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueAsociacionGremial.Location = New System.Drawing.Point(354, 202)
        Me.lueAsociacionGremial.Name = "lueAsociacionGremial"
        Me.lueAsociacionGremial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAsociacionGremial.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueAsociacionGremial.Size = New System.Drawing.Size(336, 20)
        Me.lueAsociacionGremial.TabIndex = 144
        '
        'lueFuncionCritica
        '
        Me.lueFuncionCritica.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueFuncionCritica.Location = New System.Drawing.Point(354, 298)
        Me.lueFuncionCritica.Name = "lueFuncionCritica"
        Me.lueFuncionCritica.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFuncionCritica.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueFuncionCritica.Size = New System.Drawing.Size(336, 20)
        Me.lueFuncionCritica.TabIndex = 143
        '
        'lueLey18171
        '
        Me.lueLey18171.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueLey18171.Location = New System.Drawing.Point(354, 274)
        Me.lueLey18171.Name = "lueLey18171"
        Me.lueLey18171.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLey18171.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueLey18171.Size = New System.Drawing.Size(336, 20)
        Me.lueLey18171.TabIndex = 142
        '
        'lueGastoRepresentacion
        '
        Me.lueGastoRepresentacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueGastoRepresentacion.Location = New System.Drawing.Point(354, 250)
        Me.lueGastoRepresentacion.Name = "lueGastoRepresentacion"
        Me.lueGastoRepresentacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueGastoRepresentacion.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueGastoRepresentacion.Size = New System.Drawing.Size(336, 20)
        Me.lueGastoRepresentacion.TabIndex = 141
        '
        'lueFondoBienestar
        '
        Me.lueFondoBienestar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueFondoBienestar.Location = New System.Drawing.Point(354, 178)
        Me.lueFondoBienestar.Name = "lueFondoBienestar"
        Me.lueFondoBienestar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFondoBienestar.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueFondoBienestar.Size = New System.Drawing.Size(336, 20)
        Me.lueFondoBienestar.TabIndex = 140
        '
        'lueAsignacionAntiguedad
        '
        Me.lueAsignacionAntiguedad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueAsignacionAntiguedad.Location = New System.Drawing.Point(354, 154)
        Me.lueAsignacionAntiguedad.Name = "lueAsignacionAntiguedad"
        Me.lueAsignacionAntiguedad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAsignacionAntiguedad.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueAsignacionAntiguedad.Size = New System.Drawing.Size(336, 20)
        Me.lueAsignacionAntiguedad.TabIndex = 139
        '
        'lueLey19185Art19
        '
        Me.lueLey19185Art19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueLey19185Art19.Location = New System.Drawing.Point(354, 130)
        Me.lueLey19185Art19.Name = "lueLey19185Art19"
        Me.lueLey19185Art19.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLey19185Art19.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueLey19185Art19.Size = New System.Drawing.Size(336, 20)
        Me.lueLey19185Art19.TabIndex = 138
        '
        'lueLey19185Art18
        '
        Me.lueLey19185Art18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueLey19185Art18.Location = New System.Drawing.Point(354, 106)
        Me.lueLey19185Art18.Name = "lueLey19185Art18"
        Me.lueLey19185Art18.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLey19185Art18.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueLey19185Art18.Size = New System.Drawing.Size(336, 20)
        Me.lueLey19185Art18.TabIndex = 137
        '
        'lblFuncionCritica
        '
        Me.lblFuncionCritica.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFuncionCritica.Location = New System.Drawing.Point(242, 298)
        Me.lblFuncionCritica.Name = "lblFuncionCritica"
        Me.lblFuncionCritica.Size = New System.Drawing.Size(68, 13)
        Me.lblFuncionCritica.TabIndex = 136
        Me.lblFuncionCritica.Text = "Funcíón crítica"
        '
        'lblLey18171
        '
        Me.lblLey18171.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLey18171.Location = New System.Drawing.Point(242, 274)
        Me.lblLey18171.Name = "lblLey18171"
        Me.lblLey18171.Size = New System.Drawing.Size(54, 13)
        Me.lblLey18171.TabIndex = 135
        Me.lblLey18171.Text = "Ley 18.717"
        '
        'lblGastoRepresentacion
        '
        Me.lblGastoRepresentacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGastoRepresentacion.Location = New System.Drawing.Point(242, 250)
        Me.lblGastoRepresentacion.Name = "lblGastoRepresentacion"
        Me.lblGastoRepresentacion.Size = New System.Drawing.Size(103, 13)
        Me.lblGastoRepresentacion.TabIndex = 134
        Me.lblGastoRepresentacion.Text = "Gasto representación"
        '
        'lblDl3551
        '
        Me.lblDl3551.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDl3551.Location = New System.Drawing.Point(242, 226)
        Me.lblDl3551.Name = "lblDl3551"
        Me.lblDl3551.Size = New System.Drawing.Size(39, 13)
        Me.lblDl3551.TabIndex = 133
        Me.lblDl3551.Text = "DL 3551"
        '
        'lblAsociacionGremial
        '
        Me.lblAsociacionGremial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsociacionGremial.Location = New System.Drawing.Point(242, 202)
        Me.lblAsociacionGremial.Name = "lblAsociacionGremial"
        Me.lblAsociacionGremial.Size = New System.Drawing.Size(87, 13)
        Me.lblAsociacionGremial.TabIndex = 132
        Me.lblAsociacionGremial.Text = "Asociación gremial"
        '
        'lblFondoBienestar
        '
        Me.lblFondoBienestar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFondoBienestar.Location = New System.Drawing.Point(242, 178)
        Me.lblFondoBienestar.Name = "lblFondoBienestar"
        Me.lblFondoBienestar.Size = New System.Drawing.Size(78, 13)
        Me.lblFondoBienestar.TabIndex = 131
        Me.lblFondoBienestar.Text = "Fondo bienestar"
        '
        'lblAsignacionAntiguedad
        '
        Me.lblAsignacionAntiguedad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsignacionAntiguedad.Location = New System.Drawing.Point(242, 154)
        Me.lblAsignacionAntiguedad.Name = "lblAsignacionAntiguedad"
        Me.lblAsignacionAntiguedad.Size = New System.Drawing.Size(81, 13)
        Me.lblAsignacionAntiguedad.TabIndex = 130
        Me.lblAsignacionAntiguedad.Text = "Asig. antigüedad"
        '
        'lblLey19185Art19
        '
        Me.lblLey19185Art19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLey19185Art19.Location = New System.Drawing.Point(242, 130)
        Me.lblLey19185Art19.Name = "lblLey19185Art19"
        Me.lblLey19185Art19.Size = New System.Drawing.Size(88, 13)
        Me.lblLey19185Art19.TabIndex = 129
        Me.lblLey19185Art19.Text = "Ley 19.185 Art.19"
        '
        'lblLey19185Art18
        '
        Me.lblLey19185Art18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLey19185Art18.Location = New System.Drawing.Point(242, 106)
        Me.lblLey19185Art18.Name = "lblLey19185Art18"
        Me.lblLey19185Art18.Size = New System.Drawing.Size(88, 13)
        Me.lblLey19185Art18.TabIndex = 128
        Me.lblLey19185Art18.Text = "Ley 19.185 Art.18"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.lueLiquidoAPago)
        Me.XtraTabPage3.Controls.Add(Me.lueTotalDeberes)
        Me.XtraTabPage3.Controls.Add(Me.lueTotalHaberes)
        Me.XtraTabPage3.Controls.Add(Me.lueImponible90uf)
        Me.XtraTabPage3.Controls.Add(Me.lueImponible60uf)
        Me.XtraTabPage3.Controls.Add(Me.lueRetencion10)
        Me.XtraTabPage3.Controls.Add(Me.lueImpuesto2Categoria)
        Me.XtraTabPage3.Controls.Add(Me.lueTotalTributable)
        Me.XtraTabPage3.Controls.Add(Me.lblLiquidoAPago)
        Me.XtraTabPage3.Controls.Add(Me.lblTotalDeberes)
        Me.XtraTabPage3.Controls.Add(Me.lblTotalHaberes)
        Me.XtraTabPage3.Controls.Add(Me.lblImponible90uf)
        Me.XtraTabPage3.Controls.Add(Me.lblImponible60uf)
        Me.XtraTabPage3.Controls.Add(Me.lblRetencion10)
        Me.XtraTabPage3.Controls.Add(Me.lblImpuesto2Categoria)
        Me.XtraTabPage3.Controls.Add(Me.lblTotalTributable)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(931, 421)
        Me.XtraTabPage3.Text = "Página 3 de 3"
        '
        'lueLiquidoAPago
        '
        Me.lueLiquidoAPago.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueLiquidoAPago.Location = New System.Drawing.Point(354, 274)
        Me.lueLiquidoAPago.Name = "lueLiquidoAPago"
        Me.lueLiquidoAPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLiquidoAPago.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueLiquidoAPago.Size = New System.Drawing.Size(336, 20)
        Me.lueLiquidoAPago.TabIndex = 141
        '
        'lueTotalDeberes
        '
        Me.lueTotalDeberes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueTotalDeberes.Location = New System.Drawing.Point(354, 250)
        Me.lueTotalDeberes.Name = "lueTotalDeberes"
        Me.lueTotalDeberes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTotalDeberes.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueTotalDeberes.Size = New System.Drawing.Size(336, 20)
        Me.lueTotalDeberes.TabIndex = 140
        '
        'lueTotalHaberes
        '
        Me.lueTotalHaberes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueTotalHaberes.Location = New System.Drawing.Point(354, 226)
        Me.lueTotalHaberes.Name = "lueTotalHaberes"
        Me.lueTotalHaberes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTotalHaberes.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueTotalHaberes.Size = New System.Drawing.Size(336, 20)
        Me.lueTotalHaberes.TabIndex = 139
        '
        'lueImponible90uf
        '
        Me.lueImponible90uf.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueImponible90uf.Location = New System.Drawing.Point(354, 202)
        Me.lueImponible90uf.Name = "lueImponible90uf"
        Me.lueImponible90uf.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueImponible90uf.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueImponible90uf.Size = New System.Drawing.Size(336, 20)
        Me.lueImponible90uf.TabIndex = 138
        '
        'lueImponible60uf
        '
        Me.lueImponible60uf.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueImponible60uf.Location = New System.Drawing.Point(354, 178)
        Me.lueImponible60uf.Name = "lueImponible60uf"
        Me.lueImponible60uf.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueImponible60uf.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueImponible60uf.Size = New System.Drawing.Size(336, 20)
        Me.lueImponible60uf.TabIndex = 137
        '
        'lueRetencion10
        '
        Me.lueRetencion10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueRetencion10.Location = New System.Drawing.Point(354, 154)
        Me.lueRetencion10.Name = "lueRetencion10"
        Me.lueRetencion10.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueRetencion10.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueRetencion10.Size = New System.Drawing.Size(336, 20)
        Me.lueRetencion10.TabIndex = 136
        '
        'lueImpuesto2Categoria
        '
        Me.lueImpuesto2Categoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueImpuesto2Categoria.Location = New System.Drawing.Point(354, 130)
        Me.lueImpuesto2Categoria.Name = "lueImpuesto2Categoria"
        Me.lueImpuesto2Categoria.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueImpuesto2Categoria.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueImpuesto2Categoria.Size = New System.Drawing.Size(336, 20)
        Me.lueImpuesto2Categoria.TabIndex = 135
        '
        'lueTotalTributable
        '
        Me.lueTotalTributable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueTotalTributable.Location = New System.Drawing.Point(354, 106)
        Me.lueTotalTributable.Name = "lueTotalTributable"
        Me.lueTotalTributable.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTotalTributable.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueTotalTributable.Size = New System.Drawing.Size(336, 20)
        Me.lueTotalTributable.TabIndex = 134
        '
        'lblLiquidoAPago
        '
        Me.lblLiquidoAPago.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLiquidoAPago.Location = New System.Drawing.Point(242, 274)
        Me.lblLiquidoAPago.Name = "lblLiquidoAPago"
        Me.lblLiquidoAPago.Size = New System.Drawing.Size(69, 13)
        Me.lblLiquidoAPago.TabIndex = 133
        Me.lblLiquidoAPago.Text = "Líquido a pago"
        '
        'lblTotalDeberes
        '
        Me.lblTotalDeberes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalDeberes.Location = New System.Drawing.Point(242, 250)
        Me.lblTotalDeberes.Name = "lblTotalDeberes"
        Me.lblTotalDeberes.Size = New System.Drawing.Size(66, 13)
        Me.lblTotalDeberes.TabIndex = 132
        Me.lblTotalDeberes.Text = "Total deberes"
        '
        'lblTotalHaberes
        '
        Me.lblTotalHaberes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalHaberes.Location = New System.Drawing.Point(242, 226)
        Me.lblTotalHaberes.Name = "lblTotalHaberes"
        Me.lblTotalHaberes.Size = New System.Drawing.Size(66, 13)
        Me.lblTotalHaberes.TabIndex = 131
        Me.lblTotalHaberes.Text = "Total haberes"
        '
        'lblImponible90uf
        '
        Me.lblImponible90uf.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblImponible90uf.Location = New System.Drawing.Point(242, 202)
        Me.lblImponible90uf.Name = "lblImponible90uf"
        Me.lblImponible90uf.Size = New System.Drawing.Size(85, 13)
        Me.lblImponible90uf.TabIndex = 130
        Me.lblImponible90uf.Text = "Imponible 90 U.F."
        '
        'lblImponible60uf
        '
        Me.lblImponible60uf.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblImponible60uf.Location = New System.Drawing.Point(242, 178)
        Me.lblImponible60uf.Name = "lblImponible60uf"
        Me.lblImponible60uf.Size = New System.Drawing.Size(85, 13)
        Me.lblImponible60uf.TabIndex = 129
        Me.lblImponible60uf.Text = "Imponible 60 U.F."
        '
        'lblRetencion10
        '
        Me.lblRetencion10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRetencion10.Location = New System.Drawing.Point(242, 154)
        Me.lblRetencion10.Name = "lblRetencion10"
        Me.lblRetencion10.Size = New System.Drawing.Size(74, 13)
        Me.lblRetencion10.TabIndex = 128
        Me.lblRetencion10.Text = "Retencion 10%"
        '
        'lblImpuesto2Categoria
        '
        Me.lblImpuesto2Categoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblImpuesto2Categoria.Location = New System.Drawing.Point(242, 130)
        Me.lblImpuesto2Categoria.Name = "lblImpuesto2Categoria"
        Me.lblImpuesto2Categoria.Size = New System.Drawing.Size(81, 13)
        Me.lblImpuesto2Categoria.TabIndex = 127
        Me.lblImpuesto2Categoria.Text = "Impuesto 2ª cat."
        '
        'lblTotalTributable
        '
        Me.lblTotalTributable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalTributable.Location = New System.Drawing.Point(242, 106)
        Me.lblTotalTributable.Name = "lblTotalTributable"
        Me.lblTotalTributable.Size = New System.Drawing.Size(73, 13)
        Me.lblTotalTributable.TabIndex = 126
        Me.lblTotalTributable.Text = "Total tributable"
        '
        'ItemsPrevisionalesSalud
        '
        Me.ItemsPrevisionalesSalud.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ItemsPrevisionalesSalud.Appearance.Header.Options.UseFont = True
        Me.ItemsPrevisionalesSalud.Controls.Add(Me.XtraTabControl3)
        Me.ItemsPrevisionalesSalud.Name = "ItemsPrevisionalesSalud"
        Me.ItemsPrevisionalesSalud.Size = New System.Drawing.Size(961, 483)
        Me.ItemsPrevisionalesSalud.Text = "Ítems previsionales y de salud"
        '
        'XtraTabControl3
        '
        Me.XtraTabControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl3.Location = New System.Drawing.Point(16, 24)
        Me.XtraTabControl3.Name = "XtraTabControl3"
        Me.XtraTabControl3.SelectedTabPage = Me.XtraTabPage4
        Me.XtraTabControl3.Size = New System.Drawing.Size(938, 450)
        Me.XtraTabControl3.TabIndex = 114
        Me.XtraTabControl3.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage4, Me.XtraTabPage5})
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.lueSis)
        Me.XtraTabPage4.Controls.Add(Me.lblSis)
        Me.XtraTabPage4.Controls.Add(Me.luePlanComplementarioSalud)
        Me.XtraTabPage4.Controls.Add(Me.lueCotizacionLegalSalud)
        Me.XtraTabPage4.Controls.Add(Me.lueTotalDescuentoLegalPrevisional)
        Me.XtraTabPage4.Controls.Add(Me.lueCotizacionVoluntariaAFP)
        Me.XtraTabPage4.Controls.Add(Me.lueCuentaAhorroAFP)
        Me.XtraTabPage4.Controls.Add(Me.lueCotizacionLegalPrevisional)
        Me.XtraTabPage4.Controls.Add(Me.lblPlanComplementarioSalud)
        Me.XtraTabPage4.Controls.Add(Me.lblCotizacionLegalSalud)
        Me.XtraTabPage4.Controls.Add(Me.lblTotalDescuentoLegalPrevisional)
        Me.XtraTabPage4.Controls.Add(Me.lblCotizacionVoluntariaAFP)
        Me.XtraTabPage4.Controls.Add(Me.lblCuentaAhorroAFP)
        Me.XtraTabPage4.Controls.Add(Me.lblCotizacionLegalPrevisional)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(931, 421)
        Me.XtraTabPage4.Text = "Página 1 de 2"
        '
        'lueSis
        '
        Me.lueSis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueSis.Location = New System.Drawing.Point(354, 274)
        Me.lueSis.Name = "lueSis"
        Me.lueSis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueSis.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name9", "Name9")})
        Me.lueSis.Size = New System.Drawing.Size(408, 20)
        Me.lueSis.TabIndex = 129
        '
        'lblSis
        '
        Me.lblSis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSis.Location = New System.Drawing.Point(174, 282)
        Me.lblSis.Name = "lblSis"
        Me.lblSis.Size = New System.Drawing.Size(152, 13)
        Me.lblSis.TabIndex = 128
        Me.lblSis.Text = "Descto.Seg,Invalidez y Sobrev."
        '
        'luePlanComplementarioSalud
        '
        Me.luePlanComplementarioSalud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.luePlanComplementarioSalud.Location = New System.Drawing.Point(354, 252)
        Me.luePlanComplementarioSalud.Name = "luePlanComplementarioSalud"
        Me.luePlanComplementarioSalud.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePlanComplementarioSalud.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.luePlanComplementarioSalud.Size = New System.Drawing.Size(408, 20)
        Me.luePlanComplementarioSalud.TabIndex = 120
        '
        'lueCotizacionLegalSalud
        '
        Me.lueCotizacionLegalSalud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueCotizacionLegalSalud.Location = New System.Drawing.Point(354, 228)
        Me.lueCotizacionLegalSalud.Name = "lueCotizacionLegalSalud"
        Me.lueCotizacionLegalSalud.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCotizacionLegalSalud.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueCotizacionLegalSalud.Size = New System.Drawing.Size(408, 20)
        Me.lueCotizacionLegalSalud.TabIndex = 119
        '
        'lueTotalDescuentoLegalPrevisional
        '
        Me.lueTotalDescuentoLegalPrevisional.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueTotalDescuentoLegalPrevisional.Location = New System.Drawing.Point(354, 204)
        Me.lueTotalDescuentoLegalPrevisional.Name = "lueTotalDescuentoLegalPrevisional"
        Me.lueTotalDescuentoLegalPrevisional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTotalDescuentoLegalPrevisional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueTotalDescuentoLegalPrevisional.Size = New System.Drawing.Size(408, 20)
        Me.lueTotalDescuentoLegalPrevisional.TabIndex = 118
        '
        'lueCotizacionVoluntariaAFP
        '
        Me.lueCotizacionVoluntariaAFP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueCotizacionVoluntariaAFP.Location = New System.Drawing.Point(354, 180)
        Me.lueCotizacionVoluntariaAFP.Name = "lueCotizacionVoluntariaAFP"
        Me.lueCotizacionVoluntariaAFP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCotizacionVoluntariaAFP.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueCotizacionVoluntariaAFP.Size = New System.Drawing.Size(408, 20)
        Me.lueCotizacionVoluntariaAFP.TabIndex = 117
        '
        'lueCuentaAhorroAFP
        '
        Me.lueCuentaAhorroAFP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueCuentaAhorroAFP.Location = New System.Drawing.Point(354, 156)
        Me.lueCuentaAhorroAFP.Name = "lueCuentaAhorroAFP"
        Me.lueCuentaAhorroAFP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCuentaAhorroAFP.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueCuentaAhorroAFP.Size = New System.Drawing.Size(408, 20)
        Me.lueCuentaAhorroAFP.TabIndex = 116
        '
        'lueCotizacionLegalPrevisional
        '
        Me.lueCotizacionLegalPrevisional.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueCotizacionLegalPrevisional.Location = New System.Drawing.Point(354, 132)
        Me.lueCotizacionLegalPrevisional.Name = "lueCotizacionLegalPrevisional"
        Me.lueCotizacionLegalPrevisional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCotizacionLegalPrevisional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueCotizacionLegalPrevisional.Size = New System.Drawing.Size(408, 20)
        Me.lueCotizacionLegalPrevisional.TabIndex = 115
        '
        'lblPlanComplementarioSalud
        '
        Me.lblPlanComplementarioSalud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPlanComplementarioSalud.Location = New System.Drawing.Point(174, 258)
        Me.lblPlanComplementarioSalud.Name = "lblPlanComplementarioSalud"
        Me.lblPlanComplementarioSalud.Size = New System.Drawing.Size(126, 13)
        Me.lblPlanComplementarioSalud.TabIndex = 114
        Me.lblPlanComplementarioSalud.Text = "Plan complementario salud"
        '
        'lblCotizacionLegalSalud
        '
        Me.lblCotizacionLegalSalud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCotizacionLegalSalud.Location = New System.Drawing.Point(174, 234)
        Me.lblCotizacionLegalSalud.Name = "lblCotizacionLegalSalud"
        Me.lblCotizacionLegalSalud.Size = New System.Drawing.Size(102, 13)
        Me.lblCotizacionLegalSalud.TabIndex = 113
        Me.lblCotizacionLegalSalud.Text = "Cotización legal salud"
        '
        'lblTotalDescuentoLegalPrevisional
        '
        Me.lblTotalDescuentoLegalPrevisional.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalDescuentoLegalPrevisional.Location = New System.Drawing.Point(174, 210)
        Me.lblTotalDescuentoLegalPrevisional.Name = "lblTotalDescuentoLegalPrevisional"
        Me.lblTotalDescuentoLegalPrevisional.Size = New System.Drawing.Size(156, 13)
        Me.lblTotalDescuentoLegalPrevisional.TabIndex = 112
        Me.lblTotalDescuentoLegalPrevisional.Text = "Total descuento legal previsional"
        '
        'lblCotizacionVoluntariaAFP
        '
        Me.lblCotizacionVoluntariaAFP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCotizacionVoluntariaAFP.Location = New System.Drawing.Point(174, 186)
        Me.lblCotizacionVoluntariaAFP.Name = "lblCotizacionVoluntariaAFP"
        Me.lblCotizacionVoluntariaAFP.Size = New System.Drawing.Size(134, 13)
        Me.lblCotizacionVoluntariaAFP.TabIndex = 111
        Me.lblCotizacionVoluntariaAFP.Text = "Cotización voluntaria A.F.P."
        '
        'lblCuentaAhorroAFP
        '
        Me.lblCuentaAhorroAFP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCuentaAhorroAFP.Location = New System.Drawing.Point(174, 162)
        Me.lblCuentaAhorroAFP.Name = "lblCuentaAhorroAFP"
        Me.lblCuentaAhorroAFP.Size = New System.Drawing.Size(104, 13)
        Me.lblCuentaAhorroAFP.TabIndex = 110
        Me.lblCuentaAhorroAFP.Text = "Cuenta ahorro A.F.P."
        '
        'lblCotizacionLegalPrevisional
        '
        Me.lblCotizacionLegalPrevisional.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCotizacionLegalPrevisional.Location = New System.Drawing.Point(174, 138)
        Me.lblCotizacionLegalPrevisional.Name = "lblCotizacionLegalPrevisional"
        Me.lblCotizacionLegalPrevisional.Size = New System.Drawing.Size(128, 13)
        Me.lblCotizacionLegalPrevisional.TabIndex = 109
        Me.lblCotizacionLegalPrevisional.Text = "Cotización legal previsional"
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.lueTotalDescuentoLeyesSociales)
        Me.XtraTabPage5.Controls.Add(Me.lueTotalDescuentoAPV)
        Me.XtraTabPage5.Controls.Add(Me.lueAhorroAPV)
        Me.XtraTabPage5.Controls.Add(Me.lueTotalDescuentoSalud)
        Me.XtraTabPage5.Controls.Add(Me.luePlanAUGE)
        Me.XtraTabPage5.Controls.Add(Me.lblTotalDescuentoLeyesSociales)
        Me.XtraTabPage5.Controls.Add(Me.lblTotalDescuentoAPV)
        Me.XtraTabPage5.Controls.Add(Me.lblAhorroAPV)
        Me.XtraTabPage5.Controls.Add(Me.lblTotalDescuentoSalud)
        Me.XtraTabPage5.Controls.Add(Me.lblPlanAUGE)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(931, 421)
        Me.XtraTabPage5.Text = "Página 2 de 2"
        '
        'lueTotalDescuentoLeyesSociales
        '
        Me.lueTotalDescuentoLeyesSociales.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueTotalDescuentoLeyesSociales.Location = New System.Drawing.Point(350, 228)
        Me.lueTotalDescuentoLeyesSociales.Name = "lueTotalDescuentoLeyesSociales"
        Me.lueTotalDescuentoLeyesSociales.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTotalDescuentoLeyesSociales.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueTotalDescuentoLeyesSociales.Size = New System.Drawing.Size(408, 20)
        Me.lueTotalDescuentoLeyesSociales.TabIndex = 123
        '
        'lueTotalDescuentoAPV
        '
        Me.lueTotalDescuentoAPV.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueTotalDescuentoAPV.Location = New System.Drawing.Point(350, 204)
        Me.lueTotalDescuentoAPV.Name = "lueTotalDescuentoAPV"
        Me.lueTotalDescuentoAPV.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTotalDescuentoAPV.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueTotalDescuentoAPV.Size = New System.Drawing.Size(408, 20)
        Me.lueTotalDescuentoAPV.TabIndex = 122
        '
        'lueAhorroAPV
        '
        Me.lueAhorroAPV.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueAhorroAPV.Location = New System.Drawing.Point(350, 180)
        Me.lueAhorroAPV.Name = "lueAhorroAPV"
        Me.lueAhorroAPV.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAhorroAPV.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueAhorroAPV.Size = New System.Drawing.Size(408, 20)
        Me.lueAhorroAPV.TabIndex = 121
        '
        'lueTotalDescuentoSalud
        '
        Me.lueTotalDescuentoSalud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueTotalDescuentoSalud.Location = New System.Drawing.Point(350, 156)
        Me.lueTotalDescuentoSalud.Name = "lueTotalDescuentoSalud"
        Me.lueTotalDescuentoSalud.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTotalDescuentoSalud.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueTotalDescuentoSalud.Size = New System.Drawing.Size(408, 20)
        Me.lueTotalDescuentoSalud.TabIndex = 120
        '
        'luePlanAUGE
        '
        Me.luePlanAUGE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.luePlanAUGE.Location = New System.Drawing.Point(350, 132)
        Me.luePlanAUGE.Name = "luePlanAUGE"
        Me.luePlanAUGE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePlanAUGE.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.luePlanAUGE.Size = New System.Drawing.Size(408, 20)
        Me.luePlanAUGE.TabIndex = 119
        '
        'lblTotalDescuentoLeyesSociales
        '
        Me.lblTotalDescuentoLeyesSociales.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalDescuentoLeyesSociales.Location = New System.Drawing.Point(174, 228)
        Me.lblTotalDescuentoLeyesSociales.Name = "lblTotalDescuentoLeyesSociales"
        Me.lblTotalDescuentoLeyesSociales.Size = New System.Drawing.Size(125, 13)
        Me.lblTotalDescuentoLeyesSociales.TabIndex = 118
        Me.lblTotalDescuentoLeyesSociales.Text = "Total dscto. leyes sociales"
        '
        'lblTotalDescuentoAPV
        '
        Me.lblTotalDescuentoAPV.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalDescuentoAPV.Location = New System.Drawing.Point(174, 204)
        Me.lblTotalDescuentoAPV.Name = "lblTotalDescuentoAPV"
        Me.lblTotalDescuentoAPV.Size = New System.Drawing.Size(111, 13)
        Me.lblTotalDescuentoAPV.TabIndex = 117
        Me.lblTotalDescuentoAPV.Text = "Total descuento A.P.V."
        '
        'lblAhorroAPV
        '
        Me.lblAhorroAPV.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAhorroAPV.Location = New System.Drawing.Point(174, 180)
        Me.lblAhorroAPV.Name = "lblAhorroAPV"
        Me.lblAhorroAPV.Size = New System.Drawing.Size(67, 13)
        Me.lblAhorroAPV.TabIndex = 116
        Me.lblAhorroAPV.Text = "Ahorro A.P.V."
        '
        'lblTotalDescuentoSalud
        '
        Me.lblTotalDescuentoSalud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalDescuentoSalud.Location = New System.Drawing.Point(174, 156)
        Me.lblTotalDescuentoSalud.Name = "lblTotalDescuentoSalud"
        Me.lblTotalDescuentoSalud.Size = New System.Drawing.Size(105, 13)
        Me.lblTotalDescuentoSalud.TabIndex = 115
        Me.lblTotalDescuentoSalud.Text = "Total descuento salud"
        '
        'lblPlanAUGE
        '
        Me.lblPlanAUGE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPlanAUGE.Location = New System.Drawing.Point(174, 132)
        Me.lblPlanAUGE.Name = "lblPlanAUGE"
        Me.lblPlanAUGE.Size = New System.Drawing.Size(66, 13)
        Me.lblPlanAUGE.TabIndex = 114
        Me.lblPlanAUGE.Text = "Plan A.U.G.E."
        '
        'BonoModernizacion
        '
        Me.BonoModernizacion.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BonoModernizacion.Appearance.Header.Options.UseFont = True
        Me.BonoModernizacion.Controls.Add(Me.XtraTabControl4)
        Me.BonoModernizacion.Name = "BonoModernizacion"
        Me.BonoModernizacion.Size = New System.Drawing.Size(961, 483)
        Me.BonoModernizacion.Text = "Bono modernización"
        '
        'XtraTabControl4
        '
        Me.XtraTabControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl4.Location = New System.Drawing.Point(16, 24)
        Me.XtraTabControl4.Name = "XtraTabControl4"
        Me.XtraTabControl4.SelectedTabPage = Me.XtraTabPage6
        Me.XtraTabControl4.Size = New System.Drawing.Size(938, 450)
        Me.XtraTabControl4.TabIndex = 108
        Me.XtraTabControl4.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage6, Me.XtraTabPage7, Me.XtraTabPage8})
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.lueSisMes2)
        Me.XtraTabPage6.Controls.Add(Me.lueSisMes1)
        Me.XtraTabPage6.Controls.Add(Me.lblSisMes2)
        Me.XtraTabPage6.Controls.Add(Me.lblSisMes1)
        Me.XtraTabPage6.Controls.Add(Me.txtPorcentajeColectivo)
        Me.XtraTabPage6.Controls.Add(Me.txtPorcentajeInstitucionalBono)
        Me.XtraTabPage6.Controls.Add(Me.txtPorcentajeBaseBono)
        Me.XtraTabPage6.Controls.Add(Me.lueLey19553Art8Mes1)
        Me.XtraTabPage6.Controls.Add(Me.lueLey19553Art8MesActual)
        Me.XtraTabPage6.Controls.Add(Me.lueAsignacionDesempeñoMes2)
        Me.XtraTabPage6.Controls.Add(Me.lueAsignacionDesempeñoMes1)
        Me.XtraTabPage6.Controls.Add(Me.lueAsignacinDesempeñoMesActual)
        Me.XtraTabPage6.Controls.Add(Me.chkRealizaProcesoModernizacion)
        Me.XtraTabPage6.Controls.Add(Me.lblLey19553Art8Mes1)
        Me.XtraTabPage6.Controls.Add(Me.lblLey19553Art8MesActual)
        Me.XtraTabPage6.Controls.Add(Me.lblAsignacionDesempeñoMes2)
        Me.XtraTabPage6.Controls.Add(Me.lblAsignacionDesempeñoMes1)
        Me.XtraTabPage6.Controls.Add(Me.lblAsignacinDesempeñoMesActual)
        Me.XtraTabPage6.Controls.Add(Me.lblPorcentajeColectivo)
        Me.XtraTabPage6.Controls.Add(Me.lblPorcentajeInstitucionalBono)
        Me.XtraTabPage6.Controls.Add(Me.lblPorcentajeBaseBono)
        Me.XtraTabPage6.Controls.Add(Me.lblRealizaProcesoModernizacion)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(931, 421)
        Me.XtraTabPage6.Text = "Página 1 de 3"
        '
        'lueSisMes2
        '
        Me.lueSisMes2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueSisMes2.Location = New System.Drawing.Point(354, 338)
        Me.lueSisMes2.Name = "lueSisMes2"
        Me.lueSisMes2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueSisMes2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name9", "Name9")})
        Me.lueSisMes2.Size = New System.Drawing.Size(392, 20)
        Me.lueSisMes2.TabIndex = 128
        '
        'lueSisMes1
        '
        Me.lueSisMes1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueSisMes1.Location = New System.Drawing.Point(354, 314)
        Me.lueSisMes1.Name = "lueSisMes1"
        Me.lueSisMes1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueSisMes1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name9", "Name9")})
        Me.lueSisMes1.Size = New System.Drawing.Size(392, 20)
        Me.lueSisMes1.TabIndex = 127
        '
        'lblSisMes2
        '
        Me.lblSisMes2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSisMes2.Location = New System.Drawing.Point(178, 344)
        Me.lblSisMes2.Name = "lblSisMes2"
        Me.lblSisMes2.Size = New System.Drawing.Size(171, 13)
        Me.lblSisMes2.TabIndex = 126
        Me.lblSisMes2.Text = "Descto.Seg,Invalidez y Sobr. mes 2"
        '
        'lblSisMes1
        '
        Me.lblSisMes1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSisMes1.Location = New System.Drawing.Point(178, 320)
        Me.lblSisMes1.Name = "lblSisMes1"
        Me.lblSisMes1.Size = New System.Drawing.Size(171, 13)
        Me.lblSisMes1.TabIndex = 125
        Me.lblSisMes1.Text = "Descto.Seg,Invalidez y Sobr. mes 1"
        '
        'txtPorcentajeColectivo
        '
        Me.txtPorcentajeColectivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPorcentajeColectivo.Location = New System.Drawing.Point(354, 170)
        Me.txtPorcentajeColectivo.Name = "txtPorcentajeColectivo"
        Me.txtPorcentajeColectivo.Size = New System.Drawing.Size(392, 20)
        Me.txtPorcentajeColectivo.TabIndex = 124
        '
        'txtPorcentajeInstitucionalBono
        '
        Me.txtPorcentajeInstitucionalBono.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPorcentajeInstitucionalBono.Location = New System.Drawing.Point(354, 146)
        Me.txtPorcentajeInstitucionalBono.Name = "txtPorcentajeInstitucionalBono"
        Me.txtPorcentajeInstitucionalBono.Size = New System.Drawing.Size(392, 20)
        Me.txtPorcentajeInstitucionalBono.TabIndex = 123
        '
        'txtPorcentajeBaseBono
        '
        Me.txtPorcentajeBaseBono.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPorcentajeBaseBono.Location = New System.Drawing.Point(354, 122)
        Me.txtPorcentajeBaseBono.Name = "txtPorcentajeBaseBono"
        Me.txtPorcentajeBaseBono.Size = New System.Drawing.Size(392, 20)
        Me.txtPorcentajeBaseBono.TabIndex = 122
        '
        'lueLey19553Art8Mes1
        '
        Me.lueLey19553Art8Mes1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueLey19553Art8Mes1.Location = New System.Drawing.Point(354, 290)
        Me.lueLey19553Art8Mes1.Name = "lueLey19553Art8Mes1"
        Me.lueLey19553Art8Mes1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLey19553Art8Mes1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name9", "Name9")})
        Me.lueLey19553Art8Mes1.Size = New System.Drawing.Size(392, 20)
        Me.lueLey19553Art8Mes1.TabIndex = 121
        '
        'lueLey19553Art8MesActual
        '
        Me.lueLey19553Art8MesActual.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueLey19553Art8MesActual.Location = New System.Drawing.Point(354, 266)
        Me.lueLey19553Art8MesActual.Name = "lueLey19553Art8MesActual"
        Me.lueLey19553Art8MesActual.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLey19553Art8MesActual.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name8", "Name8")})
        Me.lueLey19553Art8MesActual.Size = New System.Drawing.Size(392, 20)
        Me.lueLey19553Art8MesActual.TabIndex = 120
        '
        'lueAsignacionDesempeñoMes2
        '
        Me.lueAsignacionDesempeñoMes2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueAsignacionDesempeñoMes2.Location = New System.Drawing.Point(354, 242)
        Me.lueAsignacionDesempeñoMes2.Name = "lueAsignacionDesempeñoMes2"
        Me.lueAsignacionDesempeñoMes2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAsignacionDesempeñoMes2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name7", "Name7")})
        Me.lueAsignacionDesempeñoMes2.Size = New System.Drawing.Size(392, 20)
        Me.lueAsignacionDesempeñoMes2.TabIndex = 119
        '
        'lueAsignacionDesempeñoMes1
        '
        Me.lueAsignacionDesempeñoMes1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueAsignacionDesempeñoMes1.Location = New System.Drawing.Point(354, 218)
        Me.lueAsignacionDesempeñoMes1.Name = "lueAsignacionDesempeñoMes1"
        Me.lueAsignacionDesempeñoMes1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAsignacionDesempeñoMes1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name6", "Name6")})
        Me.lueAsignacionDesempeñoMes1.Size = New System.Drawing.Size(392, 20)
        Me.lueAsignacionDesempeñoMes1.TabIndex = 118
        '
        'lueAsignacinDesempeñoMesActual
        '
        Me.lueAsignacinDesempeñoMesActual.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueAsignacinDesempeñoMesActual.Location = New System.Drawing.Point(354, 194)
        Me.lueAsignacinDesempeñoMesActual.Name = "lueAsignacinDesempeñoMesActual"
        Me.lueAsignacinDesempeñoMesActual.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAsignacinDesempeñoMesActual.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name5", "Name5")})
        Me.lueAsignacinDesempeñoMesActual.Size = New System.Drawing.Size(392, 20)
        Me.lueAsignacinDesempeñoMesActual.TabIndex = 117
        '
        'chkRealizaProcesoModernizacion
        '
        Me.chkRealizaProcesoModernizacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkRealizaProcesoModernizacion.Location = New System.Drawing.Point(354, 98)
        Me.chkRealizaProcesoModernizacion.Name = "chkRealizaProcesoModernizacion"
        Me.chkRealizaProcesoModernizacion.Properties.Caption = "Marque si realiza."
        Me.chkRealizaProcesoModernizacion.Size = New System.Drawing.Size(392, 19)
        Me.chkRealizaProcesoModernizacion.TabIndex = 116
        '
        'lblLey19553Art8Mes1
        '
        Me.lblLey19553Art8Mes1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLey19553Art8Mes1.Location = New System.Drawing.Point(178, 298)
        Me.lblLey19553Art8Mes1.Name = "lblLey19553Art8Mes1"
        Me.lblLey19553Art8Mes1.Size = New System.Drawing.Size(116, 13)
        Me.lblLey19553Art8Mes1.TabIndex = 115
        Me.lblLey19553Art8Mes1.Text = "Ley 19.553 Art. 8 mes 1"
        '
        'lblLey19553Art8MesActual
        '
        Me.lblLey19553Art8MesActual.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLey19553Art8MesActual.Location = New System.Drawing.Point(178, 274)
        Me.lblLey19553Art8MesActual.Name = "lblLey19553Art8MesActual"
        Me.lblLey19553Art8MesActual.Size = New System.Drawing.Size(139, 13)
        Me.lblLey19553Art8MesActual.TabIndex = 114
        Me.lblLey19553Art8MesActual.Text = "Ley 19.553 Art. 8 mes actual"
        '
        'lblAsignacionDesempeñoMes2
        '
        Me.lblAsignacionDesempeñoMes2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsignacionDesempeñoMes2.Location = New System.Drawing.Point(178, 250)
        Me.lblAsignacionDesempeñoMes2.Name = "lblAsignacionDesempeñoMes2"
        Me.lblAsignacionDesempeñoMes2.Size = New System.Drawing.Size(140, 13)
        Me.lblAsignacionDesempeñoMes2.TabIndex = 113
        Me.lblAsignacionDesempeñoMes2.Text = "Asignación desempeño mes 2"
        '
        'lblAsignacionDesempeñoMes1
        '
        Me.lblAsignacionDesempeñoMes1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsignacionDesempeñoMes1.Location = New System.Drawing.Point(178, 226)
        Me.lblAsignacionDesempeñoMes1.Name = "lblAsignacionDesempeñoMes1"
        Me.lblAsignacionDesempeñoMes1.Size = New System.Drawing.Size(140, 13)
        Me.lblAsignacionDesempeñoMes1.TabIndex = 112
        Me.lblAsignacionDesempeñoMes1.Text = "Asignación desempeño mes 1"
        '
        'lblAsignacinDesempeñoMesActual
        '
        Me.lblAsignacinDesempeñoMesActual.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsignacinDesempeñoMesActual.Location = New System.Drawing.Point(178, 202)
        Me.lblAsignacinDesempeñoMesActual.Name = "lblAsignacinDesempeñoMesActual"
        Me.lblAsignacinDesempeñoMesActual.Size = New System.Drawing.Size(163, 13)
        Me.lblAsignacinDesempeñoMesActual.TabIndex = 111
        Me.lblAsignacinDesempeñoMesActual.Text = "Asignacion desempeño mes actual"
        '
        'lblPorcentajeColectivo
        '
        Me.lblPorcentajeColectivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPorcentajeColectivo.Location = New System.Drawing.Point(178, 178)
        Me.lblPorcentajeColectivo.Name = "lblPorcentajeColectivo"
        Me.lblPorcentajeColectivo.Size = New System.Drawing.Size(97, 13)
        Me.lblPorcentajeColectivo.TabIndex = 110
        Me.lblPorcentajeColectivo.Text = "Porcentaje colectivo"
        '
        'lblPorcentajeInstitucionalBono
        '
        Me.lblPorcentajeInstitucionalBono.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPorcentajeInstitucionalBono.Location = New System.Drawing.Point(178, 154)
        Me.lblPorcentajeInstitucionalBono.Name = "lblPorcentajeInstitucionalBono"
        Me.lblPorcentajeInstitucionalBono.Size = New System.Drawing.Size(134, 13)
        Me.lblPorcentajeInstitucionalBono.TabIndex = 109
        Me.lblPorcentajeInstitucionalBono.Text = "Porcentaje insitucional bono"
        '
        'lblPorcentajeBaseBono
        '
        Me.lblPorcentajeBaseBono.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPorcentajeBaseBono.Location = New System.Drawing.Point(178, 130)
        Me.lblPorcentajeBaseBono.Name = "lblPorcentajeBaseBono"
        Me.lblPorcentajeBaseBono.Size = New System.Drawing.Size(105, 13)
        Me.lblPorcentajeBaseBono.TabIndex = 108
        Me.lblPorcentajeBaseBono.Text = "Porcentaje base bono"
        '
        'lblRealizaProcesoModernizacion
        '
        Me.lblRealizaProcesoModernizacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRealizaProcesoModernizacion.Location = New System.Drawing.Point(178, 106)
        Me.lblRealizaProcesoModernizacion.Name = "lblRealizaProcesoModernizacion"
        Me.lblRealizaProcesoModernizacion.Size = New System.Drawing.Size(133, 13)
        Me.lblRealizaProcesoModernizacion.TabIndex = 107
        Me.lblRealizaProcesoModernizacion.Text = "Realiza proc. modernizacion"
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.Controls.Add(Me.lueDescuentoImpuestoSegundaCatergoriaMes2)
        Me.XtraTabPage7.Controls.Add(Me.lueDescuentoImpuestoSegundaCatergoriaMes1)
        Me.XtraTabPage7.Controls.Add(Me.lueDescuentoBienestarMes2)
        Me.XtraTabPage7.Controls.Add(Me.lueDescuentoBienestarMes1)
        Me.XtraTabPage7.Controls.Add(Me.lueDescuentoSaludMes2)
        Me.XtraTabPage7.Controls.Add(Me.lueDescuentoSaludMes1)
        Me.XtraTabPage7.Controls.Add(Me.lueDescuentoPrevisionalMes2)
        Me.XtraTabPage7.Controls.Add(Me.lueDescuentoPrevisionalMes1)
        Me.XtraTabPage7.Controls.Add(Me.lueLey19553Art8Mes2)
        Me.XtraTabPage7.Controls.Add(Me.lblDescuentoImpuestoSegundaCatergoriaMes2)
        Me.XtraTabPage7.Controls.Add(Me.lblDescuentoImpuestoSegundaCatergoriaMes1)
        Me.XtraTabPage7.Controls.Add(Me.lblDescuentoBienestarMes2)
        Me.XtraTabPage7.Controls.Add(Me.lblDescuentoBienestarMes1)
        Me.XtraTabPage7.Controls.Add(Me.lblDescuentoSaludMes2)
        Me.XtraTabPage7.Controls.Add(Me.lblDescuentoSaludMes1)
        Me.XtraTabPage7.Controls.Add(Me.lblDescuentoPrevisionalMes2)
        Me.XtraTabPage7.Controls.Add(Me.lblDescuentoPrevisionalMes1)
        Me.XtraTabPage7.Controls.Add(Me.lblLey19553Art8Mes2)
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.Size = New System.Drawing.Size(931, 421)
        Me.XtraTabPage7.Text = "Página 2 de 3"
        '
        'lueDescuentoImpuestoSegundaCatergoriaMes2
        '
        Me.lueDescuentoImpuestoSegundaCatergoriaMes2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueDescuentoImpuestoSegundaCatergoriaMes2.Location = New System.Drawing.Point(354, 290)
        Me.lueDescuentoImpuestoSegundaCatergoriaMes2.Name = "lueDescuentoImpuestoSegundaCatergoriaMes2"
        Me.lueDescuentoImpuestoSegundaCatergoriaMes2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDescuentoImpuestoSegundaCatergoriaMes2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name18", "Name18")})
        Me.lueDescuentoImpuestoSegundaCatergoriaMes2.Size = New System.Drawing.Size(392, 20)
        Me.lueDescuentoImpuestoSegundaCatergoriaMes2.TabIndex = 125
        '
        'lueDescuentoImpuestoSegundaCatergoriaMes1
        '
        Me.lueDescuentoImpuestoSegundaCatergoriaMes1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueDescuentoImpuestoSegundaCatergoriaMes1.Location = New System.Drawing.Point(354, 266)
        Me.lueDescuentoImpuestoSegundaCatergoriaMes1.Name = "lueDescuentoImpuestoSegundaCatergoriaMes1"
        Me.lueDescuentoImpuestoSegundaCatergoriaMes1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDescuentoImpuestoSegundaCatergoriaMes1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name17", "Name17")})
        Me.lueDescuentoImpuestoSegundaCatergoriaMes1.Size = New System.Drawing.Size(392, 20)
        Me.lueDescuentoImpuestoSegundaCatergoriaMes1.TabIndex = 124
        '
        'lueDescuentoBienestarMes2
        '
        Me.lueDescuentoBienestarMes2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueDescuentoBienestarMes2.Location = New System.Drawing.Point(354, 242)
        Me.lueDescuentoBienestarMes2.Name = "lueDescuentoBienestarMes2"
        Me.lueDescuentoBienestarMes2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDescuentoBienestarMes2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name16", "Name16")})
        Me.lueDescuentoBienestarMes2.Size = New System.Drawing.Size(392, 20)
        Me.lueDescuentoBienestarMes2.TabIndex = 123
        '
        'lueDescuentoBienestarMes1
        '
        Me.lueDescuentoBienestarMes1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueDescuentoBienestarMes1.Location = New System.Drawing.Point(354, 218)
        Me.lueDescuentoBienestarMes1.Name = "lueDescuentoBienestarMes1"
        Me.lueDescuentoBienestarMes1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDescuentoBienestarMes1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name15", "Name15")})
        Me.lueDescuentoBienestarMes1.Size = New System.Drawing.Size(392, 20)
        Me.lueDescuentoBienestarMes1.TabIndex = 122
        '
        'lueDescuentoSaludMes2
        '
        Me.lueDescuentoSaludMes2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueDescuentoSaludMes2.Location = New System.Drawing.Point(354, 194)
        Me.lueDescuentoSaludMes2.Name = "lueDescuentoSaludMes2"
        Me.lueDescuentoSaludMes2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDescuentoSaludMes2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name14", "Name14")})
        Me.lueDescuentoSaludMes2.Size = New System.Drawing.Size(392, 20)
        Me.lueDescuentoSaludMes2.TabIndex = 121
        '
        'lueDescuentoSaludMes1
        '
        Me.lueDescuentoSaludMes1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueDescuentoSaludMes1.Location = New System.Drawing.Point(354, 170)
        Me.lueDescuentoSaludMes1.Name = "lueDescuentoSaludMes1"
        Me.lueDescuentoSaludMes1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDescuentoSaludMes1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name13", "Name13")})
        Me.lueDescuentoSaludMes1.Size = New System.Drawing.Size(392, 20)
        Me.lueDescuentoSaludMes1.TabIndex = 120
        '
        'lueDescuentoPrevisionalMes2
        '
        Me.lueDescuentoPrevisionalMes2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueDescuentoPrevisionalMes2.Location = New System.Drawing.Point(354, 146)
        Me.lueDescuentoPrevisionalMes2.Name = "lueDescuentoPrevisionalMes2"
        Me.lueDescuentoPrevisionalMes2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDescuentoPrevisionalMes2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name12", "Name12")})
        Me.lueDescuentoPrevisionalMes2.Size = New System.Drawing.Size(392, 20)
        Me.lueDescuentoPrevisionalMes2.TabIndex = 119
        '
        'lueDescuentoPrevisionalMes1
        '
        Me.lueDescuentoPrevisionalMes1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueDescuentoPrevisionalMes1.Location = New System.Drawing.Point(354, 122)
        Me.lueDescuentoPrevisionalMes1.Name = "lueDescuentoPrevisionalMes1"
        Me.lueDescuentoPrevisionalMes1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDescuentoPrevisionalMes1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name11", "Name11")})
        Me.lueDescuentoPrevisionalMes1.Size = New System.Drawing.Size(392, 20)
        Me.lueDescuentoPrevisionalMes1.TabIndex = 118
        '
        'lueLey19553Art8Mes2
        '
        Me.lueLey19553Art8Mes2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueLey19553Art8Mes2.Location = New System.Drawing.Point(354, 98)
        Me.lueLey19553Art8Mes2.Name = "lueLey19553Art8Mes2"
        Me.lueLey19553Art8Mes2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLey19553Art8Mes2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name10", "Name10")})
        Me.lueLey19553Art8Mes2.Size = New System.Drawing.Size(392, 20)
        Me.lueLey19553Art8Mes2.TabIndex = 117
        '
        'lblDescuentoImpuestoSegundaCatergoriaMes2
        '
        Me.lblDescuentoImpuestoSegundaCatergoriaMes2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDescuentoImpuestoSegundaCatergoriaMes2.Location = New System.Drawing.Point(178, 298)
        Me.lblDescuentoImpuestoSegundaCatergoriaMes2.Name = "lblDescuentoImpuestoSegundaCatergoriaMes2"
        Me.lblDescuentoImpuestoSegundaCatergoriaMes2.Size = New System.Drawing.Size(166, 13)
        Me.lblDescuentoImpuestoSegundaCatergoriaMes2.TabIndex = 116
        Me.lblDescuentoImpuestoSegundaCatergoriaMes2.Text = "Dscto. impsto. segunda cat. mes 2"
        '
        'lblDescuentoImpuestoSegundaCatergoriaMes1
        '
        Me.lblDescuentoImpuestoSegundaCatergoriaMes1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDescuentoImpuestoSegundaCatergoriaMes1.Location = New System.Drawing.Point(178, 274)
        Me.lblDescuentoImpuestoSegundaCatergoriaMes1.Name = "lblDescuentoImpuestoSegundaCatergoriaMes1"
        Me.lblDescuentoImpuestoSegundaCatergoriaMes1.Size = New System.Drawing.Size(166, 13)
        Me.lblDescuentoImpuestoSegundaCatergoriaMes1.TabIndex = 115
        Me.lblDescuentoImpuestoSegundaCatergoriaMes1.Text = "Dscto. impsto. segunda cat. mes 1"
        '
        'lblDescuentoBienestarMes2
        '
        Me.lblDescuentoBienestarMes2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDescuentoBienestarMes2.Location = New System.Drawing.Point(178, 250)
        Me.lblDescuentoBienestarMes2.Name = "lblDescuentoBienestarMes2"
        Me.lblDescuentoBienestarMes2.Size = New System.Drawing.Size(110, 13)
        Me.lblDescuentoBienestarMes2.TabIndex = 114
        Me.lblDescuentoBienestarMes2.Text = "Dscto. bienestar mes 2"
        '
        'lblDescuentoBienestarMes1
        '
        Me.lblDescuentoBienestarMes1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDescuentoBienestarMes1.Location = New System.Drawing.Point(178, 226)
        Me.lblDescuentoBienestarMes1.Name = "lblDescuentoBienestarMes1"
        Me.lblDescuentoBienestarMes1.Size = New System.Drawing.Size(110, 13)
        Me.lblDescuentoBienestarMes1.TabIndex = 113
        Me.lblDescuentoBienestarMes1.Text = "Dscto. bienestar mes 1"
        '
        'lblDescuentoSaludMes2
        '
        Me.lblDescuentoSaludMes2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDescuentoSaludMes2.Location = New System.Drawing.Point(178, 202)
        Me.lblDescuentoSaludMes2.Name = "lblDescuentoSaludMes2"
        Me.lblDescuentoSaludMes2.Size = New System.Drawing.Size(90, 13)
        Me.lblDescuentoSaludMes2.TabIndex = 112
        Me.lblDescuentoSaludMes2.Text = "Dscto. salud mes 2"
        '
        'lblDescuentoSaludMes1
        '
        Me.lblDescuentoSaludMes1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDescuentoSaludMes1.Location = New System.Drawing.Point(178, 178)
        Me.lblDescuentoSaludMes1.Name = "lblDescuentoSaludMes1"
        Me.lblDescuentoSaludMes1.Size = New System.Drawing.Size(90, 13)
        Me.lblDescuentoSaludMes1.TabIndex = 111
        Me.lblDescuentoSaludMes1.Text = "Dscto. salud mes 1"
        '
        'lblDescuentoPrevisionalMes2
        '
        Me.lblDescuentoPrevisionalMes2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDescuentoPrevisionalMes2.Location = New System.Drawing.Point(178, 154)
        Me.lblDescuentoPrevisionalMes2.Name = "lblDescuentoPrevisionalMes2"
        Me.lblDescuentoPrevisionalMes2.Size = New System.Drawing.Size(116, 13)
        Me.lblDescuentoPrevisionalMes2.TabIndex = 110
        Me.lblDescuentoPrevisionalMes2.Text = "Dscto. previsional mes 2"
        '
        'lblDescuentoPrevisionalMes1
        '
        Me.lblDescuentoPrevisionalMes1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDescuentoPrevisionalMes1.Location = New System.Drawing.Point(178, 130)
        Me.lblDescuentoPrevisionalMes1.Name = "lblDescuentoPrevisionalMes1"
        Me.lblDescuentoPrevisionalMes1.Size = New System.Drawing.Size(116, 13)
        Me.lblDescuentoPrevisionalMes1.TabIndex = 109
        Me.lblDescuentoPrevisionalMes1.Text = "Dscto. previsional mes 1"
        '
        'lblLey19553Art8Mes2
        '
        Me.lblLey19553Art8Mes2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLey19553Art8Mes2.Location = New System.Drawing.Point(178, 106)
        Me.lblLey19553Art8Mes2.Name = "lblLey19553Art8Mes2"
        Me.lblLey19553Art8Mes2.Size = New System.Drawing.Size(116, 13)
        Me.lblLey19553Art8Mes2.TabIndex = 108
        Me.lblLey19553Art8Mes2.Text = "Ley 19.553 Art. 8 mes 2"
        '
        'XtraTabPage8
        '
        Me.XtraTabPage8.Controls.Add(Me.btnEliminarRelacion)
        Me.XtraTabPage8.Controls.Add(Me.btnGuardarRelacionNueva)
        Me.XtraTabPage8.Controls.Add(Me.btnGuardarRelacion)
        Me.XtraTabPage8.Controls.Add(Me.lblFlechas)
        Me.XtraTabPage8.Controls.Add(Me.lueItemAsociado)
        Me.XtraTabPage8.Controls.Add(Me.lueItem)
        Me.XtraTabPage8.Controls.Add(Me.lblRelacionItems)
        Me.XtraTabPage8.Controls.Add(Me.gcRelacionItems)
        Me.XtraTabPage8.Name = "XtraTabPage8"
        Me.XtraTabPage8.Size = New System.Drawing.Size(931, 421)
        Me.XtraTabPage8.Text = "Página 3 de 3"
        '
        'btnEliminarRelacion
        '
        Me.btnEliminarRelacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEliminarRelacion.Location = New System.Drawing.Point(506, 66)
        Me.btnEliminarRelacion.Name = "btnEliminarRelacion"
        Me.btnEliminarRelacion.Size = New System.Drawing.Size(184, 23)
        Me.btnEliminarRelacion.TabIndex = 133
        Me.btnEliminarRelacion.Text = "Eliminar relación seleccionada"
        '
        'btnGuardarRelacionNueva
        '
        Me.btnGuardarRelacionNueva.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGuardarRelacionNueva.Location = New System.Drawing.Point(282, 66)
        Me.btnGuardarRelacionNueva.Name = "btnGuardarRelacionNueva"
        Me.btnGuardarRelacionNueva.Size = New System.Drawing.Size(184, 23)
        Me.btnGuardarRelacionNueva.TabIndex = 132
        Me.btnGuardarRelacionNueva.Text = "Guardar como relación nueva"
        '
        'btnGuardarRelacion
        '
        Me.btnGuardarRelacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGuardarRelacion.Location = New System.Drawing.Point(90, 66)
        Me.btnGuardarRelacion.Name = "btnGuardarRelacion"
        Me.btnGuardarRelacion.Size = New System.Drawing.Size(184, 23)
        Me.btnGuardarRelacion.TabIndex = 131
        Me.btnGuardarRelacion.Text = "Guardar relación"
        '
        'lblFlechas
        '
        Me.lblFlechas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFlechas.Appearance.Options.UseTextOptions = True
        Me.lblFlechas.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblFlechas.Location = New System.Drawing.Point(466, 34)
        Me.lblFlechas.Name = "lblFlechas"
        Me.lblFlechas.Size = New System.Drawing.Size(20, 13)
        Me.lblFlechas.TabIndex = 130
        Me.lblFlechas.Text = "<->"
        '
        'lueItemAsociado
        '
        Me.lueItemAsociado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueItemAsociado.Location = New System.Drawing.Point(530, 34)
        Me.lueItemAsociado.Name = "lueItemAsociado"
        Me.lueItemAsociado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueItemAsociado.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name10", "Name10")})
        Me.lueItemAsociado.Size = New System.Drawing.Size(304, 20)
        Me.lueItemAsociado.TabIndex = 129
        '
        'lueItem
        '
        Me.lueItem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lueItem.Location = New System.Drawing.Point(162, 34)
        Me.lueItem.Name = "lueItem"
        Me.lueItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueItem.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name10", "Name10")})
        Me.lueItem.Size = New System.Drawing.Size(304, 20)
        Me.lueItem.TabIndex = 128
        '
        'lblRelacionItems
        '
        Me.lblRelacionItems.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRelacionItems.Location = New System.Drawing.Point(90, 34)
        Me.lblRelacionItems.Name = "lblRelacionItems"
        Me.lblRelacionItems.Size = New System.Drawing.Size(68, 13)
        Me.lblRelacionItems.TabIndex = 127
        Me.lblRelacionItems.Text = "Relación items"
        '
        'gcRelacionItems
        '
        Me.gcRelacionItems.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gcRelacionItems.Location = New System.Drawing.Point(90, 98)
        Me.gcRelacionItems.MainView = Me.GridView1
        Me.gcRelacionItems.Name = "gcRelacionItems"
        Me.gcRelacionItems.Size = New System.Drawing.Size(752, 304)
        Me.gcRelacionItems.TabIndex = 126
        Me.gcRelacionItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gcRelacionItems
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'gcMesAno
        '
        Me.gcMesAno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcMesAno.Controls.Add(Me.lueAño)
        Me.gcMesAno.Controls.Add(Me.lueMes)
        Me.gcMesAno.Location = New System.Drawing.Point(656, 24)
        Me.gcMesAno.Name = "gcMesAno"
        Me.gcMesAno.Size = New System.Drawing.Size(312, 48)
        Me.gcMesAno.TabIndex = 40
        Me.gcMesAno.Text = "Periodo mes/año"
        '
        'lueAño
        '
        Me.lueAño.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueAño.Location = New System.Drawing.Point(208, 24)
        Me.lueAño.Name = "lueAño"
        Me.lueAño.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAño.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueAño.Size = New System.Drawing.Size(96, 20)
        Me.lueAño.TabIndex = 89
        '
        'lueMes
        '
        Me.lueMes.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueMes.Location = New System.Drawing.Point(56, 24)
        Me.lueMes.Name = "lueMes"
        Me.lueMes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueMes.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueMes.Size = New System.Drawing.Size(96, 20)
        Me.lueMes.TabIndex = 88
        '
        'gcValoresPeriodicos
        '
        Me.gcValoresPeriodicos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcValoresPeriodicos.Controls.Add(Me.btnImpuestoSegundaCategoria)
        Me.gcValoresPeriodicos.Controls.Add(Me.btnGuardar)
        Me.gcValoresPeriodicos.Controls.Add(Me.gcMesAno)
        Me.gcValoresPeriodicos.Controls.Add(Me.XtraTabControl2)
        Me.gcValoresPeriodicos.Location = New System.Drawing.Point(0, 0)
        Me.gcValoresPeriodicos.Name = "gcValoresPeriodicos"
        Me.gcValoresPeriodicos.Size = New System.Drawing.Size(968, 624)
        Me.gcValoresPeriodicos.TabIndex = 41
        Me.gcValoresPeriodicos.Text = "Valores periodicos"
        '
        'btnImpuestoSegundaCategoria
        '
        Me.btnImpuestoSegundaCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImpuestoSegundaCategoria.Location = New System.Drawing.Point(656, 592)
        Me.btnImpuestoSegundaCategoria.Name = "btnImpuestoSegundaCategoria"
        Me.btnImpuestoSegundaCategoria.Size = New System.Drawing.Size(154, 23)
        Me.btnImpuestoSegundaCategoria.TabIndex = 42
        Me.btnImpuestoSegundaCategoria.Text = "Impuesto 2da Categoría"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(816, 592)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(136, 23)
        Me.btnGuardar.TabIndex = 41
        Me.btnGuardar.Text = "Actualizar datos"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(296, 304)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(75, 14)
        Me.LabelControl6.TabIndex = 128
        Me.LabelControl6.Text = "LabelControl6"
        '
        'frmAjusteValoresPeriodicos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(968, 621)
        Me.Controls.Add(Me.gcValoresPeriodicos)
        Me.Name = "frmAjusteValoresPeriodicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajuste de valores periodicos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.ParametrosMensuales.ResumeLayout(False)
        Me.ParametrosMensuales.PerformLayout()
        CType(Me.txtPordentajeEndeudamiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgQuienFirmaResolucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAporteInstitucional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUFMesAnterior.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCopiasResolucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentajeIncrementoPrevisionalDL3501.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentajeDescuentoBienestar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoConvenioAbonoPrevired.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMensajeColillaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTopeImponibleOtrosCalculos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTopeImponiblePrevisional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentajeTopeSalud.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentajeGastoRepresentacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentajeMaximoViatico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEdadLegal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorUTM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorUF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ControlHorasExtras.ResumeLayout(False)
        Me.ControlHorasExtras.PerformLayout()
        CType(Me.dedFechaCierreRatifHorasExtras.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaCierreRatifHorasExtras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAplicaViaticoValoresAntiguos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAplicaCalculoHrsExtrasMesAnterior.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAplicaDescuentoInasistenciaMedioDia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAplicaDescuentoAtraso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueIdentificadorItemDescuentoInasistenciaMedioDía.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueItemHorasAtraso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueIdentificadorItemHorasExtrasNocturnas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueIdentificadorItemHorasExtrasDiurnas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentajeRecargaHorasExtrasNocturnas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentajeRecargaHorasEstrasDiurnas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHorasExtrasNocturnasLegalPermitidas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHorasExtrasDiurnasLegalPermitidas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHorasLegalTrabajadasDiarias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MutualSeguridad.ResumeLayout(False)
        Me.MutualSeguridad.PerformLayout()
        CType(Me.lueIdentificadorItemMutualSeguridad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFactorMensualMutualSeguridad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoPreviredInstitucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreInstitucionSeguridad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SeguroEmpleados.ResumeLayout(False)
        Me.SeguroEmpleados.PerformLayout()
        CType(Me.lueIdentificadorItemSeguroTrabajador2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueIdentificadorItemSeguroTrabajador1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentaleMensualDescuento2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentaleMensualDescuento1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreEmpresaAseguradora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemsBaseCalculo.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.lueLey18675Art11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLey18675Art10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLey18566.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueIncrementoPrevisional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueRetencionJudicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luelAsignacionFamiliar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueResponsabilidadSuperior.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueSueldoBase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDiasTrabajados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.lueDl3551.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueAsociacionGremial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFuncionCritica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLey18171.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueGastoRepresentacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFondoBienestar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueAsignacionAntiguedad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLey19185Art19.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLey19185Art18.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.lueLiquidoAPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTotalDeberes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTotalHaberes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueImponible90uf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueImponible60uf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueRetencion10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueImpuesto2Categoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTotalTributable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemsPrevisionalesSalud.ResumeLayout(False)
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl3.ResumeLayout(False)
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        CType(Me.lueSis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePlanComplementarioSalud.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCotizacionLegalSalud.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTotalDescuentoLegalPrevisional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCotizacionVoluntariaAFP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCuentaAhorroAFP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCotizacionLegalPrevisional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        Me.XtraTabPage5.PerformLayout()
        CType(Me.lueTotalDescuentoLeyesSociales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTotalDescuentoAPV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueAhorroAPV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTotalDescuentoSalud.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePlanAUGE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BonoModernizacion.ResumeLayout(False)
        CType(Me.XtraTabControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl4.ResumeLayout(False)
        Me.XtraTabPage6.ResumeLayout(False)
        Me.XtraTabPage6.PerformLayout()
        CType(Me.lueSisMes2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueSisMes1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentajeColectivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentajeInstitucionalBono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentajeBaseBono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLey19553Art8Mes1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLey19553Art8MesActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueAsignacionDesempeñoMes2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueAsignacionDesempeñoMes1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueAsignacinDesempeñoMesActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRealizaProcesoModernizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage7.ResumeLayout(False)
        Me.XtraTabPage7.PerformLayout()
        CType(Me.lueDescuentoImpuestoSegundaCatergoriaMes2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDescuentoImpuestoSegundaCatergoriaMes1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDescuentoBienestarMes2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDescuentoBienestarMes1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDescuentoSaludMes2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDescuentoSaludMes1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDescuentoPrevisionalMes2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDescuentoPrevisionalMes1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLey19553Art8Mes2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage8.ResumeLayout(False)
        Me.XtraTabPage8.PerformLayout()
        CType(Me.lueItemAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcRelacionItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcMesAno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcMesAno.ResumeLayout(False)
        CType(Me.lueAño.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcValoresPeriodicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcValoresPeriodicos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Sub ResetControls(ByVal ParamArray ctls() As Control)
        ' clear input control
        Dim ctl As Control
        For Each ctl In ctls
            If TypeOf (ctl) Is TextBoxBase Then
                CType(ctl, TextBoxBase).Text = ""
            ElseIf TypeOf (ctl) Is CheckBox Then
                CType(ctl, CheckBox).Checked = False
            ElseIf TypeOf (ctl) Is RadioButton Then
                CType(ctl, RadioButton).Checked = False
            ElseIf TypeOf (ctl) Is ListView Then
                CType(ctl, ListView).Items.Clear()
            ElseIf TypeOf (ctl) Is TreeView Then
                CType(ctl, TreeView).Nodes.Clear()
            ElseIf TypeOf (ctl) Is ListBox Then
                CType(ctl, ListBox).Items.Clear()
            ElseIf TypeOf (ctl) Is DevExpress.XtraEditors.LookUpEdit Then
                CType(ctl, DevExpress.XtraEditors.LookUpEdit).EditValue = 1
                ' Note: to add support for more controls just add more ElseIf blocks
            End If
            ' clear all child controls, if any
            Dim c As Control
            For Each c In ctl.Controls
                ResetControls(c)
            Next
        Next
    End Sub
    Private Function ValidaExistente(ByVal idItem As Integer, ByVal idperiodo As Integer, ByVal RegistroActual As Integer) As Integer
        Dim myConnection As SqlConnection
        Dim myCommand As SqlCommand
        Dim dr As SqlDataReader
        Dim Errores As Integer = 0
        Try
            myConnection = New SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)
            myConnection.Open()
            myCommand = New SqlCommand("SELECT * FROM RH_REM_ITEM_RELIQUIDADO WHERE (PERIODO_ID = " & idperiodo & ") AND (ITEM_ID = " & idItem & ") AND (ITEM_RELIQUIDADO_ID <> " & RegistroActual & ") OR (PERIODO_ID = " & idperiodo & ") AND (ITEM_ASOCIADO_ID = " & idItem & ") AND (PERIODO_ID = " & idperiodo & ") AND (ITEM_RELIQUIDADO_ID <> " & RegistroActual & ")", myConnection)
            dr = myCommand.ExecuteReader
            Do
                While dr.Read()
                    Errores = 1
                End While
            Loop While dr.NextResult()
        Catch
        End Try
        dr.Close()
        myConnection.Close()
        ValidaExistente = Errores
    End Function
    Private Function ValidaExistente(ByVal idItem As Integer, ByVal idperiodo As Integer) As Integer
        Dim myConnection As SqlConnection
        Dim myCommand As SqlCommand
        Dim dr As SqlDataReader
        Dim Errores As Integer = 0
        Try
            myConnection = New SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)
            myConnection.Open()
            myCommand = New SqlCommand("SELECT * FROM RH_REM_ITEM_RELIQUIDADO WHERE (PERIODO_ID = " & idperiodo & ") AND (ITEM_ID = " & idItem & ") OR (PERIODO_ID = " & idperiodo & ") AND (ITEM_ASOCIADO_ID = " & idItem & ") AND (PERIODO_ID = " & idperiodo & ")", myConnection)
            dr = myCommand.ExecuteReader
            Do
                While dr.Read()
                    Errores = 1
                End While
            Loop While dr.NextResult()
        Catch
        End Try
        dr.Close()
        myConnection.Close()
        ValidaExistente = Errores
    End Function

    Private Sub GuardarRelacionNueva()
        Dim Errores As Integer = 0
        If ValidaExistente(lueItem.EditValue, idPeriodo) = 1 And Errores = 0 Then
            MessageBox.Show("El ítem ya fué asignado en este periodo")
            Errores = 1
        End If
        If ValidaExistente(lueItemAsociado.EditValue, idPeriodo) = 1 And Errores = 0 Then
            MessageBox.Show("El ítem ya fué asignado en este periodo")
            Errores = 1
        End If
        If lueItem.EditValue = lueItemAsociado.EditValue And Errores = 0 Then
            MessageBox.Show("No se puede crear esta relacion, el ítem y el ítem asociados son los mismos")
            Errores = 1
        End If
        If Errores = 0 Then
            Dim SQLStr As String = "INSERT INTO RH_REM_ITEM_RELIQUIDADO (ITEM_ID, PERIODO_ID, ITEM_ASOCIADO_ID) " & _
            "VALUES (" & lueItem.EditValue & "," & idPeriodo & "," & lueItemAsociado.EditValue & ")"
            EjecutarQuery(SQLStr)
            refrescaGrillaValoresMensuales(idPeriodo)
            MessageBox.Show("Se actualizaron los datos del registro")
        End If
    End Sub
    Private Sub GuardaRelacionExistente(ByVal id As Integer)
        Dim Errores As Integer = 0
        If ValidaExistente(lueItem.EditValue, idPeriodo, id) = 1 And Errores = 0 Then
            MessageBox.Show("El ítem ya fué asignado en este periodo")
            Errores = 1
        End If
        If ValidaExistente(lueItemAsociado.EditValue, idPeriodo, id) = 1 And Errores = 0 Then
            MessageBox.Show("El ítem ya fué asignado en este periodo")
            Errores = 1
        End If
        If lueItem.EditValue = lueItemAsociado.EditValue And Errores = 0 Then
            MessageBox.Show("No se puede crear esta relacion, el ítem y el ítem asociados son los mismos")
            Errores = 1
        End If
        If Errores = 0 Then
            Dim SQLStr As String = "UPDATE RH_REM_ITEM_RELIQUIDADO SET ITEM_ID=" & Me.lueItem.EditValue & ", PERIODO_ID=" & idPeriodo & ", ITEM_ASOCIADO_ID=" & Me.lueItemAsociado.EditValue & " " & _
            "WHERE ITEM_RELIQUIDADO_ID = " & id
            EjecutarQuery(SQLStr)
            refrescaGrillaValoresMensuales(idPeriodo)
            MessageBox.Show("Se actualizaron los datos del registro")
        End If
    End Sub
    Private Sub EliminarRelacionExistente(ByVal id As Integer)
        Dim SQLStr As String = "DELETE FROM RH_REM_ITEM_RELIQUIDADO WHERE ITEM_RELIQUIDADO_ID = " & id
        EjecutarQuery(SQLStr)
        refrescaGrillaValoresMensuales(idPeriodo)
        MessageBox.Show("Se actualizaron los datos del registro")
    End Sub
    Private Sub ActualizaTabla()
        If chkAplicaCalculoHrsExtrasMesAnterior.Checked Then
            BuscaPeriodoAnterior()
        Else
            periodoIDAnterior = idPeriodo
        End If

        Dim SQLStr As String = " UPDATE RH_REM_PERIODO SET" & _
        " FECHA_PAGO_SUELDO=CONVERT(DATETIME,'" & Me.deFechaPago.DateTime & "',103)," & _
        " VALOR_UF=" & Replace(Me.txtValorUF.Text, ",", ".") & "," & _
        " VALOR_UTM=" & Replace(Me.txtValorUTM.Text, ",", ".") & "," & _
        " EDAD_MINIMA_TRABAJO=" & Replace(Me.txtEdadLegal.Text, ",", ".") & "," & _
        " PORCENTAJE_VIATICO=" & Replace(Me.txtPorcentajeMaximoViatico.Text, ",", ".") & "," & _
        " PORCENTAJE_GASTO_REPRESENTACION=" & Replace(Me.txtPorcentajeGastoRepresentacion.Text, ",", ".") & "," & _
        " PORCENTAJE_TOPE_SALUD=" & Replace(Me.txtPorcentajeTopeSalud.Text, ",", ".") & "," & _
        " TOPE_IMPONIBLE1=" & Replace(Me.txtTopeImponiblePrevisional.Text, ",", ".") & "," & _
        " TOPE_IMPONIBLE2=" & Replace(Me.txtTopeImponibleOtrosCalculos.Text, ",", ".") & "," & _
        " OBSERVACIONES='" & Me.txtMensajeColillaPago.Text & "'," & _
        " CODIGO_CONVENIO_ABONO_REMUNERACION=" & Replace(Me.txtCodigoConvenioAbonoPrevired.Text, ",", ".") & "," & _
        " PORCENTAJE_DESCTO_BIENESTAR=" & Replace(Me.txtPorcentajeDescuentoBienestar.Text, ",", ".") & "," & _
        " PORCENTAJE_INCREMENTO_PREVIS_DL3501=" & Replace(Me.txtPorcentajeIncrementoPrevisionalDL3501.Text, ",", ".") & "," & _
        " HORAS_TRABAJADAS_DIA=" & Replace(Me.txtHorasLegalTrabajadasDiarias.Text, ",", ".") & "," & _
        " HORAS_EXTRAS_LEGAL_DIURNAS=" & Replace(Me.txtHorasExtrasDiurnasLegalPermitidas.Text, ",", ".") & "," & _
        " HORAS_EXTRAS_LEGAL_NOCTURNAS=" & Replace(Me.txtHorasExtrasNocturnasLegalPermitidas.Text, ",", ".") & "," & _
        " ITEM_HORAS_EXTRAS_DIURNAS_ID=" & Me.lueIdentificadorItemHorasExtrasDiurnas.EditValue & "," & _
        " ITEM_HORAS_EXTRAS_NOCTURNAS_ID=" & Me.lueIdentificadorItemHorasExtrasNocturnas.EditValue & "," & _
        " RECARGA_HRS_EXTRAS_DIURNAS=" & Replace(Me.txtPorcentajeRecargaHorasEstrasDiurnas.Text, ",", ".") & "," & _
        " RECARGA_HRS_EXTRAS_NOCTURNAS=" & Replace(Me.txtPorcentajeRecargaHorasExtrasNocturnas.Text, ",", ".") & "," & _
        " NOMBRE_INSTITUCION_MUTUAL_SEGURIDAD='" & Me.txtNombreInstitucionSeguridad.Text & "'," & _
        " CODIGO_PREVIRED_INSTITUCION_SEGURIDAD=" & "'" & Me.txtCodigoPreviredInstitucion.Text & "'" & "," & _
        " PORCENTAJE_MENSUAL_INSTITUCION_SEGURIDAD=" & Replace(Me.txtFactorMensualMutualSeguridad.Text, ",", ".") & "," & _
        " ITEM_MONTO_MUTUAL_SEGURIDAD_ID=" & Me.lueIdentificadorItemMutualSeguridad.EditValue & "," & _
        " NOMBRE_INSTITUCION_SEGURO='" & Me.txtNombreEmpresaAseguradora.Text & "'," & _
        " PORCETANJE_MESUAL_DESCUENTO_SEGURO1=" & Replace(Me.txtPorcentaleMensualDescuento1.Text, ",", ".") & "," & _
        " PORCETANJE_MESUAL_DESCUENTO_SEGURO2=" & Replace(Me.txtPorcentaleMensualDescuento2.Text, ",", ".") & "," & _
        " ITEM_SEGURO1_ID=" & Me.lueIdentificadorItemSeguroTrabajador1.EditValue & "," & _
        " ITEM_SEGURO2_ID=" & Me.lueIdentificadorItemSeguroTrabajador2.EditValue & "," & _
        " ITEM_DIAS_TRABAJADOS_ID=" & Me.lueDiasTrabajados.EditValue & "," & _
        " ITEM_SUELDO_BASE_ID=" & Me.lueSueldoBase.EditValue & "," & _
        " ITEM_RESPONSABILIDAD_SUPERIOR_ID=" & Me.lueResponsabilidadSuperior.EditValue & "," & _
        " ITEM_ASIGNACION_FAMILIAR_ID=" & Me.luelAsignacionFamiliar.EditValue & "," & _
        " ITEM_RETENCION_JUDICIAL_ID=" & Me.lueRetencionJudicial.EditValue & "," & _
        " ITEM_INCREMENTO_PREVISIONAL_ID=" & Me.lueIncrementoPrevisional.EditValue & "," & _
        " ITEM_LEY_18566_SALUD_ID=" & Me.lueLey18566.EditValue & "," & _
        " ITEM_LEY_18675_ART10_ID=" & Me.lueLey18675Art10.EditValue & "," & _
        " ITEM_LEY_18675_ART11_ID=" & Me.lueLey18675Art11.EditValue & "," & _
        " ITEM_LEY_19185_ART18_ID=" & Me.lueLey19185Art18.EditValue & "," & _
        " ITEM_LEY_19185_ART19_ID=" & Me.lueLey19185Art19.EditValue & "," & _
        " ITEM_ASIGNACION_ANTIGUEDAD_ID=" & Me.lueAsignacionAntiguedad.EditValue & "," & _
        " ITEM_FONDO_BIENESTAR_ID=" & Me.lueFondoBienestar.EditValue & "," & _
        " ITEM_ASOCIACION1_ID=" & Me.lueAsociacionGremial.EditValue & "," & _
        " ITEM_LEY_3551=" & Me.lueDl3551.EditValue & "," & _
        " ITEM_GASTO_REPRESENTACION_ID=" & Me.lueGastoRepresentacion.EditValue & "," & _
        " ITEM_LEY18717_ID=" & Me.lueLey18171.EditValue & "," & _
        " ITEM_MONTO_FUNCION_CRITICA_ID=" & Me.lueFuncionCritica.EditValue & "," & _
        " ITEM_TOTAL_TRIBUTABLE_ID=" & Me.lueTotalTributable.EditValue & "," & _
        " ITEM_IMPUESTO_UNICO_ID=" & Me.lueImpuesto2Categoria.EditValue & "," & _
        " ITEM_RETENCION_10_ID=" & Me.lueRetencion10.EditValue & "," & _
        " ITEM_TOTAL_IMPONIBLE1_ID=" & Me.lueImponible60uf.EditValue & "," & _
        " ITEM_TOTAL_IMPONIBLE2_ID=" & Me.lueImponible90uf.EditValue & "," & _
        " ITEM_TOTAL_HABERES_ID=" & Me.lueTotalHaberes.EditValue & "," & _
        " ITEM_TOTAL_DEBERES_ID=" & Me.lueTotalDeberes.EditValue & "," & _
        " ITEM_LIQUIDO_PAGO_ID=" & Me.lueLiquidoAPago.EditValue & "," & _
        " ITEM_MONTO_COTIZACION_LEGAL_PREVISIONAL_ID=" & Me.lueCotizacionLegalPrevisional.EditValue & "," & _
        " ITEM_MONTO_CUENTA_AHORRO_AFP_ID=" & Me.lueCuentaAhorroAFP.EditValue & "," & _
        " ITEM_MONTO_COTIZACION_VOLUNATARIA_AFP_ID=" & Me.lueCotizacionVoluntariaAFP.EditValue & "," & _
        " ITEM_TOTAL_DESCUENTO_PREVISIONAL_ID=" & Me.lueTotalDescuentoLegalPrevisional.EditValue & "," & _
        " ITEM_MONTO_CONVENIO_SALUD_ID=" & Me.lueCotizacionLegalSalud.EditValue & "," & _
        " ITEM_MONTO_PLAN_COMPLEMENTARIO_SALUD_ID=" & Me.luePlanComplementarioSalud.EditValue & "," & _
        " ITEM_MONTO_PLAN_AUGE_ID=" & Me.luePlanAUGE.EditValue & "," & _
        " ITEM_TOTAL_DESCUENTO_SALUD_ID=" & Me.lueTotalDescuentoSalud.EditValue & "," & _
        " ITEM_MONTO_APV_ID=" & Me.lueAhorroAPV.EditValue & "," & _
        " ITEM_TOTAL_DESCUENTO_APV_ID=" & Me.lueTotalDescuentoAPV.EditValue & "," & _
        " ITEM_TOTAL_DESCUENTO_LEYES_SOCIALES_ID=" & Me.lueTotalDescuentoLeyesSociales.EditValue & "," & _
        " PROCESO_BONO_MODERNIZACION=" & Replace(Replace(Me.chkRealizaProcesoModernizacion.EditValue, "False", "0"), "True", "1") & "," & _
        " PORCENTAJE_BASE_BONO=" & Replace(Me.txtPorcentajeBaseBono.Text, ",", ".") & "," & _
        " PORCENTAJE_INSTITUCIONAL_BONO=" & Replace(Me.txtPorcentajeInstitucionalBono.Text, ",", ".") & "," & _
        " PORCENTAJE_COLECTIVO_BONO=" & Replace(Me.txtPorcentajeColectivo.Text, ",", ".") & "," & _
        " ITEM_ASIG_DESEMPENO_MES_ACTUAL=" & Me.lueAsignacinDesempeñoMesActual.EditValue & "," & _
        " ITEM_ASIG_DESEMPENO_MES1=" & Me.lueAsignacionDesempeñoMes1.EditValue & "," & _
        " ITEM_ASIG_DESEMPENO_MES2=" & Me.lueAsignacionDesempeñoMes2.EditValue & "," & _
        " ITEM_ASIG_LEY19553_ART8_MES_ACTUAL=" & Me.lueLey19553Art8MesActual.EditValue & "," & _
        " ITEM_ASIG_LEY19553_ART8_MES1=" & Me.lueLey19553Art8Mes1.EditValue & "," & _
        " ITEM_ASIG_LEY19553_ART8_MES2=" & Me.lueLey19553Art8Mes2.EditValue & "," & _
        " ITEM_DESCTO_PREVIS_DESEMPENO_MES1=" & Me.lueDescuentoPrevisionalMes1.EditValue & "," & _
        " ITEM_DESCTO_PREVIS_DESEMPENO_MES2=" & Me.lueDescuentoPrevisionalMes2.EditValue & "," & _
        " ITEM_DESCTO_SALUD_DESEMPENO_MES1=" & Me.lueDescuentoSaludMes1.EditValue & "," & _
        " ITEM_DESCTO_SALUD_DESEMPENO_MES2=" & Me.lueDescuentoSaludMes2.EditValue & "," & _
        " ITEM_DESCTO_BIENESTAR_MES1=" & Me.lueDescuentoBienestarMes1.EditValue & "," & _
        " ITEM_DESCTO_BIENESTAR_MES2=" & Me.lueDescuentoBienestarMes2.EditValue & "," & _
        " ITEM_IMPTO_UNICO_DESEMPENO_MES1=" & Me.lueDescuentoImpuestoSegundaCatergoriaMes1.EditValue & "," & _
        " ITEM_IMPTO_UNICO_DESEMPENO_MES2=" & Me.lueDescuentoImpuestoSegundaCatergoriaMes2.EditValue & "," & _
        " COPIAS_RESOLUCION=" & "'" & Me.txtCopiasResolucion.Text & "'" & "," & _
        " UF_MES_ANTERIOR=" & Replace(Me.txtUFMesAnterior.Text, ",", ".") & "," & _
        " MONTO_APORTE_INSTITUCIONAL=" & Replace(Me.txtAporteInstitucional.Text, ",", ".") & "," & _
        " QUIEN_FIRMA_RESOLUCION=" & rdgQuienFirmaResolucion.SelectedIndex & "," & _
        " ITEM_ATRASO=" & Me.lueItemHorasAtraso.EditValue & "," & _
        " ITEM_INASISTENCIA=" & Me.lueIdentificadorItemDescuentoInasistenciaMedioDía.EditValue & "," & _
        " CALCULO_HORAS_EXTRAS_MES_ANTERIOR=" & Replace(Replace(Me.chkAplicaCalculoHrsExtrasMesAnterior.EditValue, "False", "0"), "True", "1") & "," & _
        " FECHA_CIERRE_RATIFICACION_HORA_EXTRA=CONVERT(DATETIME,'" & Me.dedFechaCierreRatifHorasExtras.DateTime & "',103)," & _
        " CALCULO_VIATICO_MES_ANTERIOR=" & Replace(Replace(Me.chkAplicaViaticoValoresAntiguos.EditValue, "False", "0"), "True", "1") & "," & _
        " APLICA_DESCUENTO_ATRASO=" & Replace(Replace(chkAplicaDescuentoAtraso.EditValue, "False", "0"), "True", "1") & "," & _
        " PERIODO_ID_HORA_EXTRA=" & periodoIDAnterior & "," & _
        " APLICA_DESCUENTO_INASISTENCIA_MEDIO_DIA=" & Replace(Replace(chkAplicaDescuentoInasistenciaMedioDia.EditValue, "False", "0"), "True", "1") & "," & _
        " ITEM_DESCUENTO_SIS=" & Me.lueSis.EditValue & "," & _
        " ITEM_DESCUENTO_SIS_MES1=" & Me.lueSisMes1.EditValue & "," & _
        " PORCENTAJE_LEGAL_ENDEUDAMIENTO=" & Replace(Me.txtPordentajeEndeudamiento.Text, ",", ".") & "," & _
        " ITEM_DESCUENTO_SIS_MES2=" & Me.lueSisMes2.EditValue & _
        " WHERE PERIODO_ID = " & idPeriodo
        EjecutarQuery(SQLStr)
        MessageBox.Show("Se actualizaron los datos del registro")
    End Sub
    Private Sub EjecutarQuery(ByVal sqlSTR As String)
        Dim objcommand As New SqlClient.SqlCommand(sqlSTR, New SqlClient.SqlConnection(connectionString))
        objcommand.Connection.Open()
        objcommand.ExecuteNonQuery()
        objcommand.Connection.Close()
        objcommand.Dispose()
        objcommand = Nothing
    End Sub
    Private Sub LlenaLUES(ByVal lue As DevExpress.XtraEditors.LookUpEdit)
        Comun.Utiles.fillLookUpEdit(lue, _
                    (Utiles.fillDataview("SELECT ITEM_ID, ITEM_ALIAS + ' : ' + DESCRIPCION_LARGA AS TEXTO FROM RH_REM_ITEM ORDER BY ITEM_ALIAS", _
                    "RH_REM_ITEM", "TEXTO", "ITEM_ID", _
                    connectionString)), "TEXTO", "ITEM_ID")
    End Sub
    Private Sub LlenadoCombos()
        LlenaLUES(lueIdentificadorItemHorasExtrasDiurnas)
        LlenaLUES(lueIdentificadorItemHorasExtrasDiurnas)
        LlenaLUES(lueIdentificadorItemHorasExtrasNocturnas)
        LlenaLUES(lueIdentificadorItemMutualSeguridad)
        LlenaLUES(lueIdentificadorItemSeguroTrabajador1)
        LlenaLUES(lueIdentificadorItemSeguroTrabajador2)
        LlenaLUES(lueDiasTrabajados)
        LlenaLUES(lueSueldoBase)
        LlenaLUES(lueResponsabilidadSuperior)
        LlenaLUES(luelAsignacionFamiliar)
        LlenaLUES(lueRetencionJudicial)
        LlenaLUES(lueIncrementoPrevisional)
        LlenaLUES(lueLey18566)
        LlenaLUES(lueLey18675Art10)
        LlenaLUES(lueLey18675Art11)
        LlenaLUES(lueLey19185Art18)
        LlenaLUES(lueLey19185Art19)
        LlenaLUES(lueAsignacionAntiguedad)
        LlenaLUES(lueFondoBienestar)
        LlenaLUES(lueAsociacionGremial)
        LlenaLUES(lueDl3551)
        LlenaLUES(lueGastoRepresentacion)
        LlenaLUES(lueLey18171)
        LlenaLUES(lueFuncionCritica)
        LlenaLUES(lueTotalTributable)
        LlenaLUES(lueImpuesto2Categoria)
        LlenaLUES(lueRetencion10)
        LlenaLUES(lueImponible60uf)
        LlenaLUES(lueImponible90uf)
        LlenaLUES(lueTotalHaberes)
        LlenaLUES(lueTotalDeberes)
        LlenaLUES(lueLiquidoAPago)
        LlenaLUES(lueCotizacionLegalPrevisional)
        LlenaLUES(lueCuentaAhorroAFP)
        LlenaLUES(lueCotizacionVoluntariaAFP)
        LlenaLUES(lueTotalDescuentoLegalPrevisional)
        LlenaLUES(lueCotizacionLegalSalud)
        LlenaLUES(luePlanComplementarioSalud)
        LlenaLUES(luePlanAUGE)
        LlenaLUES(lueTotalDescuentoSalud)
        LlenaLUES(lueAhorroAPV)
        LlenaLUES(lueTotalDescuentoAPV)
        LlenaLUES(lueTotalDescuentoLeyesSociales)
        LlenaLUES(lueAsignacinDesempeñoMesActual)
        LlenaLUES(lueAsignacionDesempeñoMes1)
        LlenaLUES(lueAsignacionDesempeñoMes2)
        LlenaLUES(lueLey19553Art8MesActual)
        LlenaLUES(lueLey19553Art8Mes1)
        LlenaLUES(lueLey19553Art8Mes2)
        LlenaLUES(lueDescuentoPrevisionalMes1)
        LlenaLUES(lueDescuentoPrevisionalMes2)
        LlenaLUES(lueDescuentoSaludMes1)
        LlenaLUES(lueDescuentoSaludMes2)
        LlenaLUES(lueDescuentoBienestarMes1)
        LlenaLUES(lueDescuentoBienestarMes2)
        LlenaLUES(lueDescuentoImpuestoSegundaCatergoriaMes1)
        LlenaLUES(lueDescuentoImpuestoSegundaCatergoriaMes2)
        LlenaLUES(lueItem)
        LlenaLUES(lueItemAsociado)
        LlenaLUES(lueItemHorasAtraso)
        LlenaLUES(lueIdentificadorItemDescuentoInasistenciaMedioDía)
        LlenaLUES(lueSis)
        LlenaLUES(lueSisMes1)
        LlenaLUES(lueSisMes2)
        lueItem.EditValue = 1
        lueItemAsociado.EditValue = 1
    End Sub

    Private Sub CargaMesAno()
        Comun.Utiles.fillLookUpEdit(lueAño, (Utiles.fillDataview("SELECT DISTINCT ANO FROM RH_REM_PERIODO", "RH_REM_PERIODO", "ANO", "ANO", connectionString)), "ANO", "ANO")
        Comun.Utiles.fillLookUpEdit(lueMes, (Utiles.fillDataview("SELECT DISTINCT MES FROM RH_REM_PERIODO", "RH_REM_PERIODO", "MES", "MES", connectionString)), "MES", "MES")
        Dim myConnection As SqlConnection
        Dim myCommand As SqlCommand
        Dim dr As SqlDataReader
        Try
            myConnection = New SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)
            myConnection.Open()
            myCommand = New SqlCommand("SELECT TOP 1 * FROM RH_REM_PERIODO ORDER BY ANO DESC, MES DESC", myConnection)
            dr = myCommand.ExecuteReader
            Do
                While dr.Read()
                    Me.lueAño.EditValue = dr("ANO")
                    Me.lueMes.EditValue = dr("MES")
                End While
            Loop While dr.NextResult()
        Catch
        End Try
        dr.Close()
        myConnection.Close()
        DatosUltimoPeriodo(lueMes.EditValue, lueAño.EditValue)
    End Sub

    Private Sub DatosUltimoPeriodo(ByVal mes As Integer, ByVal ano As Integer)
        LlenadoCombos()
        'SELECT * FROM RH_REM_PERIODO ORDER BY ANO, MES
        Dim myConnection As SqlConnection
        Dim myCommand As SqlCommand
        Dim dr As SqlDataReader
        Dim myCommand2 As SqlCommand
        Dim dr2 As SqlDataReader
        Try
            myConnection = New SqlConnection(connectionString)
            myConnection.Open()
            myCommand = New SqlCommand("SELECT * FROM RH_REM_PERIODO WHERE ANO=" & ano & " AND MES=" & mes & " ORDER BY ANO DESC, MES DESC", myConnection)
            dr = myCommand.ExecuteReader
            Do
                While dr.Read()
                    'HOJA 1
                    Me.lueAño.EditValue = dr("ANO")
                    Me.lueMes.EditValue = dr("MES")
                    Me.deFechaPago.DateTime = dr("FECHA_PAGO_SUELDO")
                    Me.txtValorUF.Text = Math.Round(dr("VALOR_UF"), 2)
                    Me.txtValorUTM.Text = Math.Round(dr("VALOR_UTM"), 2)
                    Me.txtEdadLegal.Text = dr("EDAD_MINIMA_TRABAJO")
                    Me.txtPorcentajeMaximoViatico.Text = dr("PORCENTAJE_VIATICO")
                    Me.txtPorcentajeGastoRepresentacion.Text = dr("PORCENTAJE_GASTO_REPRESENTACION")
                    Me.txtPorcentajeTopeSalud.Text = Math.Round(dr("PORCENTAJE_TOPE_SALUD"), 3)
                    Me.txtTopeImponiblePrevisional.Text = dr("TOPE_IMPONIBLE1")
                    Me.txtTopeImponibleOtrosCalculos.Text = dr("TOPE_IMPONIBLE2")
                    Me.txtMensajeColillaPago.Text = dr("OBSERVACIONES")
                    Me.txtCodigoConvenioAbonoPrevired.Text = dr("CODIGO_CONVENIO_ABONO_REMUNERACION")
                    Me.txtPorcentajeDescuentoBienestar.Text = dr("PORCENTAJE_DESCTO_BIENESTAR")
                    Me.txtPorcentajeIncrementoPrevisionalDL3501.Text = dr("PORCENTAJE_INCREMENTO_PREVIS_DL3501")
                    Me.txtCopiasResolucion.Text = dr("COPIAS_RESOLUCION")
                    Me.txtUFMesAnterior.Text = Math.Round(dr("UF_MES_ANTERIOR"), 2)
                    Me.txtAporteInstitucional.Text = Math.Round(dr("MONTO_APORTE_INSTITUCIONAL"), 0)
                    Me.rdgQuienFirmaResolucion.SelectedIndex = dr("QUIEN_FIRMA_RESOLUCION")
                    Me.txtPordentajeEndeudamiento.Text = dr("PORCENTAJE_LEGAL_ENDEUDAMIENTO")
                    'HOJA2
                    Me.txtHorasLegalTrabajadasDiarias.Text = dr("HORAS_TRABAJADAS_DIA")
                    Me.txtHorasExtrasDiurnasLegalPermitidas.Text = dr("HORAS_EXTRAS_LEGAL_DIURNAS")
                    Me.txtHorasExtrasNocturnasLegalPermitidas.Text = dr("HORAS_EXTRAS_LEGAL_NOCTURNAS")
                    Me.lueIdentificadorItemHorasExtrasDiurnas.EditValue = dr("ITEM_HORAS_EXTRAS_DIURNAS_ID")
                    Me.lueIdentificadorItemHorasExtrasNocturnas.EditValue = dr("ITEM_HORAS_EXTRAS_NOCTURNAS_ID")
                    Me.txtPorcentajeRecargaHorasEstrasDiurnas.Text = dr("RECARGA_HRS_EXTRAS_DIURNAS")
                    Me.txtPorcentajeRecargaHorasExtrasNocturnas.Text = dr("RECARGA_HRS_EXTRAS_NOCTURNAS")
                    Me.lueItemHorasAtraso.EditValue = dr("ITEM_ATRASO")
                    Me.lueIdentificadorItemDescuentoInasistenciaMedioDía.EditValue = dr("ITEM_INASISTENCIA")
                    If dr("APLICA_DESCUENTO_ATRASO") Then
                        Me.chkAplicaDescuentoAtraso.Checked = True
                    Else
                        Me.chkAplicaDescuentoAtraso.Checked = False
                    End If
                    If dr("APLICA_DESCUENTO_INASISTENCIA_MEDIO_DIA") Then
                        chkAplicaDescuentoInasistenciaMedioDia.Checked = True
                    Else
                        chkAplicaDescuentoInasistenciaMedioDia.Checked = False
                    End If
                    Me.dedFechaCierreRatifHorasExtras.EditValue = dr("FECHA_CIERRE_RATIFICACION_HORA_EXTRA")
                    If dr("CALCULO_HORAS_EXTRAS_MES_ANTERIOR") Then
                        chkAplicaCalculoHrsExtrasMesAnterior.Checked = True
                    Else
                        chkAplicaCalculoHrsExtrasMesAnterior.Checked = False
                    End If
                    If dr("CALCULO_VIATICO_MES_ANTERIOR") Then
                        chkAplicaViaticoValoresAntiguos.Checked = True
                    Else
                        chkAplicaViaticoValoresAntiguos.Checked = False
                    End If
                    'HOJA3
                    Me.txtNombreInstitucionSeguridad.Text = dr("NOMBRE_INSTITUCION_MUTUAL_SEGURIDAD")
                    Me.txtCodigoPreviredInstitucion.Text = dr("CODIGO_PREVIRED_INSTITUCION_SEGURIDAD")
                    Me.txtFactorMensualMutualSeguridad.Text = dr("PORCENTAJE_MENSUAL_INSTITUCION_SEGURIDAD")
                    Me.lueIdentificadorItemMutualSeguridad.EditValue = dr("ITEM_MONTO_MUTUAL_SEGURIDAD_ID")
                    'HOJA4
                    Me.txtNombreEmpresaAseguradora.Text = dr("NOMBRE_INSTITUCION_SEGURO")
                    Me.txtPorcentaleMensualDescuento1.Text = dr("PORCETANJE_MESUAL_DESCUENTO_SEGURO1")
                    Me.txtPorcentaleMensualDescuento2.Text = dr("PORCETANJE_MESUAL_DESCUENTO_SEGURO2")
                    Me.lueIdentificadorItemSeguroTrabajador1.EditValue = dr("ITEM_SEGURO1_ID")
                    Me.lueIdentificadorItemSeguroTrabajador2.EditValue = dr("ITEM_SEGURO2_ID")
                    'HOJA5
                    Me.lueDiasTrabajados.EditValue = dr("ITEM_DIAS_TRABAJADOS_ID")
                    Me.lueSueldoBase.EditValue = dr("ITEM_SUELDO_BASE_ID")
                    Me.lueResponsabilidadSuperior.EditValue = dr("ITEM_RESPONSABILIDAD_SUPERIOR_ID")
                    Me.luelAsignacionFamiliar.EditValue = dr("ITEM_ASIGNACION_FAMILIAR_ID")
                    Me.lueRetencionJudicial.EditValue = dr("ITEM_RETENCION_JUDICIAL_ID")
                    Me.lueIncrementoPrevisional.EditValue = dr("ITEM_INCREMENTO_PREVISIONAL_ID")
                    Me.lueLey18566.EditValue = dr("ITEM_LEY_18566_SALUD_ID")
                    Me.lueLey18675Art10.EditValue = dr("ITEM_LEY_18675_ART10_ID")
                    Me.lueLey18675Art11.EditValue = dr("ITEM_LEY_18675_ART11_ID")
                    Me.lueLey19185Art18.EditValue = dr("ITEM_LEY_19185_ART18_ID")
                    Me.lueLey19185Art19.EditValue = dr("ITEM_LEY_19185_ART19_ID")
                    Me.lueAsignacionAntiguedad.EditValue = dr("ITEM_ASIGNACION_ANTIGUEDAD_ID")
                    Me.lueFondoBienestar.EditValue = dr("ITEM_FONDO_BIENESTAR_ID")
                    Me.lueAsociacionGremial.EditValue = dr("ITEM_ASOCIACION1_ID")
                    Me.lueDl3551.EditValue = dr("ITEM_LEY_3551")
                    Me.lueGastoRepresentacion.EditValue = dr("ITEM_GASTO_REPRESENTACION_ID")
                    Me.lueLey18171.EditValue = dr("ITEM_LEY18717_ID")
                    Me.lueFuncionCritica.EditValue = dr("ITEM_MONTO_FUNCION_CRITICA_ID")
                    Me.lueTotalTributable.EditValue = dr("ITEM_TOTAL_TRIBUTABLE_ID")
                    Me.lueImpuesto2Categoria.EditValue = dr("ITEM_IMPUESTO_UNICO_ID")
                    Me.lueRetencion10.EditValue = dr("ITEM_RETENCION_10_ID")
                    Me.lueImponible60uf.EditValue = dr("ITEM_TOTAL_IMPONIBLE1_ID")
                    Me.lueImponible90uf.EditValue = dr("ITEM_TOTAL_IMPONIBLE2_ID")
                    Me.lueTotalHaberes.EditValue = dr("ITEM_TOTAL_HABERES_ID")
                    Me.lueTotalDeberes.EditValue = dr("ITEM_TOTAL_DEBERES_ID")
                    Me.lueLiquidoAPago.EditValue = dr("ITEM_LIQUIDO_PAGO_ID")
                    'HOJA6
                    Me.lueCotizacionLegalPrevisional.EditValue = dr("ITEM_MONTO_COTIZACION_LEGAL_PREVISIONAL_ID")
                    Me.lueCuentaAhorroAFP.EditValue = dr("ITEM_MONTO_CUENTA_AHORRO_AFP_ID")
                    Me.lueCotizacionVoluntariaAFP.EditValue = dr("ITEM_MONTO_COTIZACION_VOLUNATARIA_AFP_ID")
                    Me.lueTotalDescuentoLegalPrevisional.EditValue = dr("ITEM_TOTAL_DESCUENTO_PREVISIONAL_ID")
                    Me.lueCotizacionLegalSalud.EditValue = dr("ITEM_MONTO_CONVENIO_SALUD_ID")
                    Me.luePlanComplementarioSalud.EditValue = dr("ITEM_MONTO_PLAN_COMPLEMENTARIO_SALUD_ID")
                    Me.luePlanAUGE.EditValue = dr("ITEM_MONTO_PLAN_AUGE_ID")
                    Me.lueTotalDescuentoSalud.EditValue = dr("ITEM_TOTAL_DESCUENTO_SALUD_ID")
                    Me.lueAhorroAPV.EditValue = dr("ITEM_MONTO_APV_ID")
                    Me.lueTotalDescuentoAPV.EditValue = dr("ITEM_TOTAL_DESCUENTO_APV_ID")
                    Me.lueTotalDescuentoLeyesSociales.EditValue = dr("ITEM_TOTAL_DESCUENTO_LEYES_SOCIALES_ID")
                    Me.lueSis.EditValue = dr("ITEM_DESCUENTO_SIS")
                    Me.lueSisMes1.EditValue = dr("ITEM_DESCUENTO_SIS_MES1")
                    Me.lueSisMes2.EditValue = dr("ITEM_DESCUENTO_SIS_MES2")
                    'HOJA7
                    Me.chkRealizaProcesoModernizacion.EditValue = dr("PROCESO_BONO_MODERNIZACION")
                    Me.txtPorcentajeBaseBono.Text = dr("PORCENTAJE_BASE_BONO")
                    Me.txtPorcentajeInstitucionalBono.Text = dr("PORCENTAJE_INSTITUCIONAL_BONO")
                    Me.txtPorcentajeColectivo.Text = dr("PORCENTAJE_COLECTIVO_BONO")
                    Me.lueAsignacinDesempeñoMesActual.EditValue = dr("ITEM_ASIG_DESEMPENO_MES_ACTUAL")
                    Me.lueAsignacionDesempeñoMes1.EditValue = dr("ITEM_ASIG_DESEMPENO_MES1")
                    Me.lueAsignacionDesempeñoMes2.EditValue = dr("ITEM_ASIG_DESEMPENO_MES2")
                    Me.lueLey19553Art8MesActual.EditValue = dr("ITEM_ASIG_LEY19553_ART8_MES_ACTUAL")
                    Me.lueLey19553Art8Mes1.EditValue = dr("ITEM_ASIG_LEY19553_ART8_MES1")
                    Me.lueLey19553Art8Mes2.EditValue = dr("ITEM_ASIG_LEY19553_ART8_MES2")
                    Me.lueDescuentoPrevisionalMes1.EditValue = dr("ITEM_DESCTO_PREVIS_DESEMPENO_MES1")
                    Me.lueDescuentoPrevisionalMes2.EditValue = dr("ITEM_DESCTO_PREVIS_DESEMPENO_MES2")
                    Me.lueDescuentoSaludMes1.EditValue = dr("ITEM_DESCTO_SALUD_DESEMPENO_MES1")
                    Me.lueDescuentoSaludMes2.EditValue = dr("ITEM_DESCTO_SALUD_DESEMPENO_MES2")
                    Me.lueDescuentoBienestarMes1.EditValue = dr("ITEM_DESCTO_BIENESTAR_MES1")
                    Me.lueDescuentoBienestarMes2.EditValue = dr("ITEM_DESCTO_BIENESTAR_MES2")
                    Me.lueDescuentoImpuestoSegundaCatergoriaMes1.EditValue = dr("ITEM_IMPTO_UNICO_DESEMPENO_MES1")
                    Me.lueDescuentoImpuestoSegundaCatergoriaMes2.EditValue = dr("ITEM_IMPTO_UNICO_DESEMPENO_MES2")
                    idPeriodo = dr("PERIODO_ID")
                    refrescaGrillaValoresMensuales(idPeriodo)
                    If dr("ESTADO_PERIODO") = 0 Then
                        Me.btnGuardar.Enabled = False
                        Me.btnGuardarRelacion.Enabled = False
                        Me.btnGuardarRelacionNueva.Enabled = False
                        Me.btnEliminarRelacion.Enabled = False
                        btnImpuestoSegundaCategoria.Enabled = False
                    Else
                        Me.btnGuardar.Enabled = True
                        Me.btnGuardarRelacionNueva.Enabled = True
                        btnImpuestoSegundaCategoria.Enabled = True
                        If GridView1.RowCount = 0 Then
                            Me.btnGuardarRelacion.Enabled = False
                            Me.btnEliminarRelacion.Enabled = False
                        Else
                            Me.btnGuardarRelacion.Enabled = True
                            Me.btnEliminarRelacion.Enabled = True
                        End If
                        RegistroID = 0
                    End If
                End While
            Loop While dr.NextResult()
        Catch
        End Try
        dr.Close()
        myConnection.Close()
    End Sub
    Private Sub refrescaGrillaValoresMensuales(ByVal id As Integer)
        Dim i As Integer
        Dim thisConnection As New SqlConnection(connectionString)
        Dim sql As String = "SELECT * FROM VW_REM_ITEM_RELIQUIDADO WHERE (PERIODO = " & id & ")"
        Try
            Dim da As New SqlDataAdapter
            da.SelectCommand = New SqlCommand(sql, thisConnection)
            Dim ds As New DataSet
            da.Fill(ds, cl.presidencia.Argo.Comun.Tablas.VW_REM_ITEM_RELIQUIDADO)
            Dim dt As DataTable = ds.Tables(cl.presidencia.Argo.Comun.Tablas.VW_REM_ITEM_RELIQUIDADO)
            Dim dv As New DataView(dt)
            Me.gcRelacionItems.DataSource = dv
        Catch ex As SqlException
            Console.WriteLine("Error: " & ex.ToString())
        Finally
            For i = 0 To 3
                GridView1.Columns(i).Visible = False
            Next
            thisConnection.Close()
        End Try
        Me.gcRelacionItems.Refresh()
        If GridView1.RowCount = 0 Then
            Me.btnGuardarRelacion.Enabled = False
            Me.btnEliminarRelacion.Enabled = False
        Else
            Me.btnGuardarRelacion.Enabled = True
            Me.btnEliminarRelacion.Enabled = True
        End If
    End Sub

    Private Sub ActualizaMontoTramosConNuevaUTM()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_remuneracion_actualizar_montos_de_tramos", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@periodo_id", idPeriodo)
            conn.Open()

            command.ExecuteNonQuery()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmAjusteValoresPeriodicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'chkAplicaDescuentoAtraso.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        CargaMesAno()
    End Sub

    Private Sub lueMes_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueMes.EditValueChanged
        DatosUltimoPeriodo(lueMes.EditValue, lueAño.EditValue)
    End Sub

    Private Sub lueAño_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueAño.EditValueChanged
        DatosUltimoPeriodo(lueMes.EditValue, lueAño.EditValue)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        ActualizaTabla()
        ActualizaMontoTramosConNuevaUTM()
        DatosUltimoPeriodo(lueMes.EditValue, lueAño.EditValue)
    End Sub

    Private Sub btnGuardarRelacionNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarRelacionNueva.Click
        GuardarRelacionNueva()
    End Sub

    Private Sub btnGuardarRelacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarRelacion.Click
        If RegistroID > 0 Then
            GuardaRelacionExistente(RegistroID)
            RegistroID = 0
        Else
            MessageBox.Show("Debe seleccionar un registro")
        End If
    End Sub

    Private Sub btnEliminarRelacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarRelacion.Click
        If MsgBox("¿Desea eliminar esta relación?", MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            If RegistroID > 0 Then
                EliminarRelacionExistente(RegistroID)
                RegistroID = 0
            Else
                MessageBox.Show("Debe seleccionar un registro")
            End If
        End If
    End Sub

    Private Sub gcRelacionItems_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gcRelacionItems.Click
        If GridView1.RowCount > 0 Then
            RegistroID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0))
            Me.lueItem.EditValue = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(2))
            Me.lueItemAsociado.EditValue = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(3))
            '            lueItem.EditValue = 1
            '            lueItemAsociado.EditValue = 1
        End If
    End Sub
    Private Sub BuscaPeriodoAnterior()
        'Comun.Utiles.fillLookUpEdit(lueAño, (Utiles.fillDataview("SELECT DISTINCT ANO FROM RH_REM_PERIODO", "RH_REM_PERIODO", "ANO", "ANO", connectionString)), "ANO", "ANO")
        'Comun.Utiles.fillLookUpEdit(lueMes, (Utiles.fillDataview("SELECT DISTINCT MES FROM RH_REM_PERIODO", "RH_REM_PERIODO", "MES", "MES", connectionString)), "MES", "MES")
        Dim myConnection As SqlConnection
        Dim myCommand As SqlCommand
        Dim dr As SqlDataReader
        Dim mes, ano As Integer
        mes = lueMes.EditValue
        ano = lueAño.EditValue

        If mes = 1 Then
            mes = 12
            ano = ano - 1
        Else
            mes = mes - 1
        End If

        Try
            myConnection = New SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)
            myConnection.Open()
            myCommand = New SqlCommand("SELECT PERIODO_ID FROM RH_REM_PERIODO WHERE ANO=" & CType(ano, String) & " AND MES=" & CType(mes, String), myConnection)
            dr = myCommand.ExecuteReader
            Do
                While dr.Read()
                    periodoIDAnterior = dr("PERIODO_ID")
                End While
            Loop While dr.NextResult()
        Catch
        End Try
        dr.Close()
        myConnection.Close()
    End Sub

    Private Sub btnImpuestoSegundaCategoria_Click(sender As System.Object, e As System.EventArgs) Handles btnImpuestoSegundaCategoria.Click
        Dim frmImpuestoSegundaCategoria As New frmImpuestoSegundaCategoria(idPeriodo)
        frmImpuestoSegundaCategoria.ShowDialog()
    End Sub
End Class
