Imports cl.presidencia.Argo.Reportes
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Imports cl.presidencia.Seguridad

Public Class frmFichaEmpleado
    Inherits System.Windows.Forms.Form

    Public Property EsFichaHistorica As Boolean

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
    Friend WithEvents lblEstadoEmpleado As System.Windows.Forms.Label
    Friend WithEvents xtpDatosPersonales As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents rdgSexo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents dedFechaNacimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblApellidoMaterno As System.Windows.Forms.Label
    Friend WithEvents lblApellidoPaterno As System.Windows.Forms.Label
    Friend WithEvents lblRut As System.Windows.Forms.Label
    Friend WithEvents xtpDireccionParticular As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cbbEstadoCivil As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblEstadoCivil As System.Windows.Forms.Label
    Friend WithEvents lblNivelEstudio As System.Windows.Forms.Label
    Friend WithEvents lblNumeroMovil As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblCiudad As System.Windows.Forms.Label
    Friend WithEvents lblComuna As System.Windows.Forms.Label
    Friend WithEvents lblRegion As System.Windows.Forms.Label
    Friend WithEvents lblVillaPoblacion As System.Windows.Forms.Label
    Friend WithEvents cbbComuna As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbbCiudad As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents grpDomicilio As System.Windows.Forms.GroupBox
    Friend WithEvents xtpDatosGenerales As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblFonoOficina As System.Windows.Forms.Label
    Friend WithEvents lblNombreEnfernedadCronica As System.Windows.Forms.Label
    Friend WithEvents lblAlergia As System.Windows.Forms.Label
    Friend WithEvents lblGrupoSanguineo As System.Windows.Forms.Label
    Friend WithEvents lblNroMatriculaMilitar As System.Windows.Forms.Label
    Friend WithEvents lblSituacionMilitar As System.Windows.Forms.Label
    Friend WithEvents lblFonoNombreContacto As System.Windows.Forms.Label
    Friend WithEvents grpDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents lblNombres As System.Windows.Forms.Label
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents txtDV As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtApellidoPaterno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtApellidoMaterno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents leRut As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuListadoPersonal As System.Windows.Forms.MenuItem
    Friend WithEvents txtRut As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbbRegion As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblDomicilio As System.Windows.Forms.Label
    Friend WithEvents txtCodigoPostal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCalle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVillaPoblacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbbPais As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbbEstadoEmpleado As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtMedicamentosContraindicados As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtEnfermedadCronica As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAlergias As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGrupoSanguineo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMatriculaMilitar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtServicioMilitar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFonoAnexo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picEmpleado As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnConfirmarFotografia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gpcInformacionContractualGeneral As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblJefeDirecto As System.Windows.Forms.Label
    Friend WithEvents lblUbicacionFisica As System.Windows.Forms.Label
    Friend WithEvents lblHorarioTrabajo As System.Windows.Forms.Label
    Friend WithEvents gpcDatosResolucion As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtNroResolucionContrato As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dedFechaResolucion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFechaResolucion As System.Windows.Forms.Label
    Friend WithEvents lblResolucionContrato As System.Windows.Forms.Label
    Friend WithEvents gpcDatosRetiroEmpleado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dedFechaRetiro As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblMotivoRetiro As System.Windows.Forms.Label
    Friend WithEvents lblFechaRetiro As System.Windows.Forms.Label
    Friend WithEvents dedFechaIngInstitucion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dedFechaIngAdmPublica As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblEscalafon As System.Windows.Forms.Label
    Friend WithEvents lblfechaIngInstittucion As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngAdmPublica As System.Windows.Forms.Label
    Friend WithEvents lblGrado As System.Windows.Forms.Label
    Friend WithEvents lblCalidadJuridica As System.Windows.Forms.Label
    Friend WithEvents xtpDatosLaborales As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gpcDatosContractuales As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cbbGrado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbbEscalafon As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbbMotivoRetiro As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbbJefeDirecto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbbUbicacionFisica As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbbHorarioTrabajo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents xtpEstructuraOrganizacional As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcOrganigrama As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcCentrosCostos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblOrganizacion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDireccion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDepartamento As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueDireccion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueDepartamento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents xtpDatosPrevisionales As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gpcDatosFondoPenciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lueUnidadCotizacionVol As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueUnidadAhorroAfp As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueAfp As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblInsitucionPrevisional As System.Windows.Forms.Label
    Friend WithEvents txtMontoCotizacionVoluntaria As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMontoAhorroAfp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCotizacionVol As System.Windows.Forms.Label
    Friend WithEvents lblTipoMonedaCtaAhorro As System.Windows.Forms.Label
    Friend WithEvents lblMontoCtaAhorro As System.Windows.Forms.Label
    Friend WithEvents dedFechaAfiliacionPrevisional As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFechaAfiliacionAFP As System.Windows.Forms.Label
    Friend WithEvents dedFechaIngsistemaPrev As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFechaIngSistemaPrev As System.Windows.Forms.Label
    Friend WithEvents gpcDatosSaludPrevisional As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lueUnidadMontoPlanComplementario As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueUnidadMontoConvenio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueIsapre As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtMontoPlanComplementario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMontoConvenio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMontoPlanComplementario As System.Windows.Forms.Label
    Friend WithEvents lbllbTipoMonedaConvenioSalud As System.Windows.Forms.Label
    Friend WithEvents lblMontoConvenioSalud As System.Windows.Forms.Label
    Friend WithEvents dedFechaAfiliacionSalud As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFechaAfiliacionIsapreFonosa As System.Windows.Forms.Label
    Friend WithEvents lblInstitucionSalud As System.Windows.Forms.Label
    Friend WithEvents btnGuardaryConservar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardarRegistroActual As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gpcDetallePrevisional As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gdcPrevision As DevExpress.XtraGrid.GridControl
    Friend WithEvents colFECHA_ING_SISTEMA_PREVIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_AFP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTASA_DESCUENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCUENTO_LEY_19882 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_AFILIACION_AFP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_AHORRO_AFP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_COTIZACION_VOLUNTARIA_AFP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_ISAPRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_AFILIACION_ISAPRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_ISAPRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPLAN_COMPLEM_ISAPRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colANTECEDENTE_PREVIS_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents xtpDatosAPV As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dgAntecedenteAPV As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetalleAPV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NOMBRE_TIPO_APV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TIPO_AHORRO_PREVISIONAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOMBRE_APV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APV_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MONTO_AHORRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MONEDA_AHORRO_APV_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOMBRE_UNIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ANTECEDENTE_APV_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gpcDetalleAPV As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lueUnidadMontoAPV As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtMontoAPV As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMontoAPV As System.Windows.Forms.Label
    Friend WithEvents lueAPV As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblInstitucionAPV As System.Windows.Forms.Label
    Friend WithEvents lblTipoAhorro As System.Windows.Forms.Label
    Friend WithEvents rdgTipoAhorro As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtpDatosRemuneracion As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents rdgFondoBienestar As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtNumeroCuentaBanco As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpcDatosAsociacionGremial As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dteFechaIngBienestar As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteFechaIngAsocGremial As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lueTipoCuentaBanco As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueBanco As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents rdgFormaPago As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lueAsociacionGremial As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gpcCargasFamiliares As DevExpress.XtraEditors.GroupControl
    Friend WithEvents speCargaFamPreNatal As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblCargaFamPreNatal As System.Windows.Forms.Label
    Friend WithEvents speCargaFamInvalidez As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblCargaFamInvalidez As System.Windows.Forms.Label
    Friend WithEvents speCargaFamNormal As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lueTramoCargaFamiliar As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblCargaFamNormal As System.Windows.Forms.Label
    Friend WithEvents lblTramoAsignacionFam As System.Windows.Forms.Label
    Friend WithEvents gpcFormaPago As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gpcMontosRemuneraciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblLey19185 As System.Windows.Forms.Label
    Friend WithEvents txtMontoLey19185Art18 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMontoSueldoBase As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMontoRentaBase As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMontoRentaBase As System.Windows.Forms.Label
    Friend WithEvents lblMontoAsigRespon As System.Windows.Forms.Label
    Friend WithEvents lblMontoAsigProfesional As System.Windows.Forms.Label
    Friend WithEvents lblMontoSueldoBase As System.Windows.Forms.Label
    Friend WithEvents btnGuardarDatosRemuneracion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gpcDefinicionAsignaciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dteFechaCumplioBienio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFechaCimplioBienio As System.Windows.Forms.Label
    Friend WithEvents speNumeroBienios As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblNúmeroCuentaBanco As System.Windows.Forms.Label
    Friend WithEvents lblBanco As System.Windows.Forms.Label
    Friend WithEvents lblTipoCuentaBanco As System.Windows.Forms.Label
    Friend WithEvents lblFormaPago As System.Windows.Forms.Label
    Friend WithEvents lblAsociacionGremial As System.Windows.Forms.Label
    Friend WithEvents lblFondoBienestar As System.Windows.Forms.Label
    Friend WithEvents btnGuardarAPV As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTelefonoParticular As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCelular As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFechaAsignacionGrado As System.Windows.Forms.Label
    Friend WithEvents txtFechaAsignacionGrado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMultiFondoPrevisional As System.Windows.Forms.Label
    Friend WithEvents lueUnidadMontoPlanAuge As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtMontoPlanAuge As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkFondoA As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkFondoB As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkFondoC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkFondoE As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkFondoD As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblElCampoRut As System.Windows.Forms.Label
    Friend WithEvents lblCodigoPostal As System.Windows.Forms.Label
    Friend WithEvents lblNumeroDireccion As System.Windows.Forms.Label
    Friend WithEvents lblCalleAvda As System.Windows.Forms.Label
    Friend WithEvents lblPais As System.Windows.Forms.Label
    Friend WithEvents lblMedicamentosContraindicados As System.Windows.Forms.Label
    Friend WithEvents lblMontoPlanAuge As System.Windows.Forms.Label
    Friend WithEvents lblTipoUnidad As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngBienestar As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngAsocGremial As System.Windows.Forms.Label
    Friend WithEvents lblNumeroBienios As System.Windows.Forms.Label
    Friend WithEvents lblMontoFuncionCritica As System.Windows.Forms.Label
    Friend WithEvents txtMontoFuncionCritica As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mnuRptFichaEmpleado As System.Windows.Forms.MenuItem
    Friend WithEvents lueInstitucion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblClasifiaccionEmpleado As System.Windows.Forms.Label
    Friend WithEvents cbbEstamento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblEstamento As System.Windows.Forms.Label
    Friend WithEvents cbbClasificacionEmpleado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtMontoAsigResponsabilidadSuperior As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMontoLey19185Art19 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpbLineaHorizontal As System.Windows.Forms.GroupBox
    Friend WithEvents txtLey18675Art11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLey18675Art10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLey18717 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLey18717 As System.Windows.Forms.Label
    Friend WithEvents lblLey18675Art11 As System.Windows.Forms.Label
    Friend WithEvents lblLey18675Art10 As System.Windows.Forms.Label
    Friend WithEvents txtLey18566 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLey18566 As System.Windows.Forms.Label
    Friend WithEvents txtGastoRepresentacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblGastoRepresentacion As System.Windows.Forms.Label
    Friend WithEvents mnuLstAntiguedad As System.Windows.Forms.MenuItem
    Friend WithEvents lblLey3551 As System.Windows.Forms.Label
    Friend WithEvents txtMontoLey3551 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpcAntecedenteWeb As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gpcDatosEmpleado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblFuncionDesempeño As System.Windows.Forms.Label
    Friend WithEvents chkPublicaDatos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtFuncionDesempeno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTituloProfesionalExpertiz As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpbFotoEmpleado As System.Windows.Forms.GroupBox
    Friend WithEvents lblTituloProfesionalExpertiz As System.Windows.Forms.Label
    Friend WithEvents gdvDetallePrevision As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lueCalJur As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtIncrementoPrevisDL3501 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFonoContactoEmergencia As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cbbNivelEstudio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtEdad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents lblIncrementoPrevDL3501 As System.Windows.Forms.Label
    Friend WithEvents lueTipoTrabajadorPrevired As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblTipoTrabajadorPrevired As System.Windows.Forms.Label
    Friend WithEvents dvNivelEstudios As System.Data.DataView
    Friend WithEvents gdcEstructuraOrganica As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gdvEstructuraOrganica As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ESTRUCTURA_ORGANICA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EMPLEADO_ID_EO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESC_ORGANIZACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESC_DIRECCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESC_DEPTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnGuardarEstrucOrg As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminarEstrucOrg As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelarEstrucOrg As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gdcEstructuraContable As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalleEstructuraContable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ESTADO_REGISTRO_ORGANICA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESC_PERIODO_ORGANICA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ESTRUCTURA_CONTABLE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ESTADO_REGISTRO_CONTAB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESC_CENTRO_COSTO_CONTABLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESC_CENTRO_COSTO_PRESUP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PORCENTAJE_DISTRIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESC_PERIODO_CONTABLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gleRut As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents picEmpleadoCargarFotografia As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents picEmpleadoEliminarFotografia As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dvEmpleados As System.Data.DataView
    Friend WithEvents colNOMBRE_ESTADO_REGISTRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblResolucionRetiro As System.Windows.Forms.Label
    Friend WithEvents txtResolucionRetiro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGuardarDatosPrevisionales As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents picEmpleadoExportarFotografia As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents gpcComandos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gpcComandosDatosContacto As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnGuardarDatosContacto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardarDatosGenerales As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardarDatosLaborales As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gpcComandosDatosGenerales As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lueTipoBeneficiario As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblTipoBeneficiario As System.Windows.Forms.Label
    Friend WithEvents gpcComandosDatosLaborales As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtNumeroAcceso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNumeroAcceso As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gpcSeguridad As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblCargo As System.Windows.Forms.Label
    Friend WithEvents txtCargo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPorcentajeLey19863 As System.Windows.Forms.Label
    Friend WithEvents txtPorcentajeLey19863 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPorcentajeSign As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPorcentajeDistribucion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPorcentajeDistribucion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueCentroCostoPresupuesto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueCentroCostoContable As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblCentroDeCostoPresupuesto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCentroDeCostoContable As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGuardarEstructuraContable As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelarEstructuraContable As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminarEstructuraContable As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblEvaluadorDesempeño As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAutorizadorHorasExtras As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueEvaluadorDesempeno As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueAutorizadorHorasExtras As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtMontoAhorro As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents dedFechaIngresoCalidadJuridica As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents xtcFichaEmpleado As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents btnDetallePresupuestoAnualHonorario As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkEntregoBoletaHonorario As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lueSubDepto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblSubDepto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DESC_SUBDEPTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbbJefeEvalDesempeno As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkIncluirParaEvaluacionDesempeño As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents memObservacionesBienio As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents gpcDatosAsignacionZona As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblZona As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueEmpleado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblBuscarEmpleado As System.Windows.Forms.Label
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents lblMensajeContacto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMensajeGeneral As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMensajeLaboral As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMensajeEstruOrgannica As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMensajePrevisional As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMensajeAPV As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueZona As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtMontoAsignacionZona As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblAsignacionZona As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAsignaLey18675Art11 As System.Windows.Forms.CheckBox
    Friend WithEvents lblNombreDatosContacto As System.Windows.Forms.Label
    Friend WithEvents lblNombreDatosGenerales As System.Windows.Forms.Label
    Friend WithEvents lblNombreDatosLaborales As System.Windows.Forms.Label
    Friend WithEvents lblNombreEstructuraOrganizacional As System.Windows.Forms.Label
    Friend WithEvents lblNombreDatosPrevisionales As System.Windows.Forms.Label
    Friend WithEvents lblNombreDatosAPV As System.Windows.Forms.Label
    Friend WithEvents lblNombreDatosRemuneracion As System.Windows.Forms.Label
    Friend WithEvents deeAfpFechaFun As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtAfpNroFun As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblAfpFechaFun As System.Windows.Forms.Label
    Friend WithEvents lblApfNroFun As System.Windows.Forms.Label
    Friend WithEvents deeIsapreFechaFun As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtIsapreNroFun As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblIsapreFechaFun As System.Windows.Forms.Label
    Friend WithEvents lblIsapreNroFun As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblMensajeRemuneracion As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.lblEstadoEmpleado = New System.Windows.Forms.Label()
        Me.xtcFichaEmpleado = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpDatosPersonales = New DevExpress.XtraTab.XtraTabPage()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.txtDV = New DevExpress.XtraEditors.TextEdit()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblNivelEstudio = New System.Windows.Forms.Label()
        Me.cbbEstadoEmpleado = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.gpcComandos = New DevExpress.XtraEditors.GroupControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.gpbFotoEmpleado = New System.Windows.Forms.GroupBox()
        Me.btnConfirmarFotografia = New DevExpress.XtraEditors.SimpleButton()
        Me.picEmpleado = New DevExpress.XtraEditors.PictureEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.picEmpleadoCargarFotografia = New DevExpress.XtraBars.BarStaticItem()
        Me.picEmpleadoEliminarFotografia = New DevExpress.XtraBars.BarStaticItem()
        Me.picEmpleadoExportarFotografia = New DevExpress.XtraBars.BarStaticItem()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.gpcDatosEmpleado = New DevExpress.XtraEditors.GroupControl()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbbEstadoCivil = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.dedFechaNacimiento = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblBuscarEmpleado = New System.Windows.Forms.Label()
        Me.lueEmpleado = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbbNivelEstudio = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.txtEdad = New DevExpress.XtraEditors.TextEdit()
        Me.rdgSexo = New DevExpress.XtraEditors.RadioGroup()
        Me.lblApellidoPaterno = New System.Windows.Forms.Label()
        Me.lblApellidoMaterno = New System.Windows.Forms.Label()
        Me.txtApellidoMaterno = New DevExpress.XtraEditors.TextEdit()
        Me.leRut = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gleRut = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtRut = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombres = New DevExpress.XtraEditors.TextEdit()
        Me.txtApellidoPaterno = New DevExpress.XtraEditors.TextEdit()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblElCampoRut = New System.Windows.Forms.Label()
        Me.xtpDireccionParticular = New DevExpress.XtraTab.XtraTabPage()
        Me.lblNombreDatosContacto = New System.Windows.Forms.Label()
        Me.lblMensajeContacto = New DevExpress.XtraEditors.LabelControl()
        Me.gpcComandosDatosContacto = New DevExpress.XtraEditors.GroupControl()
        Me.btnGuardarDatosContacto = New DevExpress.XtraEditors.SimpleButton()
        Me.cbbPais = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblComuna = New System.Windows.Forms.Label()
        Me.grpDomicilio = New System.Windows.Forms.GroupBox()
        Me.txtCodigoPostal = New DevExpress.XtraEditors.TextEdit()
        Me.lblCodigoPostal = New System.Windows.Forms.Label()
        Me.txtNumero = New DevExpress.XtraEditors.TextEdit()
        Me.lblNumeroDireccion = New System.Windows.Forms.Label()
        Me.txtCalle = New DevExpress.XtraEditors.TextEdit()
        Me.cbbRegion = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtTelefonoParticular = New DevExpress.XtraEditors.TextEdit()
        Me.txtCelular = New DevExpress.XtraEditors.TextEdit()
        Me.txtVillaPoblacion = New DevExpress.XtraEditors.TextEdit()
        Me.cbbCiudad = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.lblCalleAvda = New System.Windows.Forms.Label()
        Me.lblVillaPoblacion = New System.Windows.Forms.Label()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNumeroMovil = New System.Windows.Forms.Label()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.cbbComuna = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.xtpDatosGenerales = New DevExpress.XtraTab.XtraTabPage()
        Me.lblNombreDatosGenerales = New System.Windows.Forms.Label()
        Me.lblMensajeGeneral = New DevExpress.XtraEditors.LabelControl()
        Me.gpcComandosDatosGenerales = New DevExpress.XtraEditors.GroupControl()
        Me.btnGuardarDatosGenerales = New DevExpress.XtraEditors.SimpleButton()
        Me.grpDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.txtFonoContactoEmergencia = New DevExpress.XtraEditors.MemoEdit()
        Me.txtMedicamentosContraindicados = New DevExpress.XtraEditors.MemoEdit()
        Me.txtEnfermedadCronica = New DevExpress.XtraEditors.TextEdit()
        Me.txtAlergias = New DevExpress.XtraEditors.TextEdit()
        Me.txtGrupoSanguineo = New DevExpress.XtraEditors.TextEdit()
        Me.txtMatriculaMilitar = New DevExpress.XtraEditors.TextEdit()
        Me.txtServicioMilitar = New DevExpress.XtraEditors.TextEdit()
        Me.txtFonoAnexo = New DevExpress.XtraEditors.TextEdit()
        Me.lblSituacionMilitar = New System.Windows.Forms.Label()
        Me.lblNroMatriculaMilitar = New System.Windows.Forms.Label()
        Me.lblGrupoSanguineo = New System.Windows.Forms.Label()
        Me.lblAlergia = New System.Windows.Forms.Label()
        Me.lblNombreEnfernedadCronica = New System.Windows.Forms.Label()
        Me.lblMedicamentosContraindicados = New System.Windows.Forms.Label()
        Me.lblFonoNombreContacto = New System.Windows.Forms.Label()
        Me.lblFonoOficina = New System.Windows.Forms.Label()
        Me.xtpDatosLaborales = New DevExpress.XtraTab.XtraTabPage()
        Me.lblNombreDatosLaborales = New System.Windows.Forms.Label()
        Me.lblMensajeLaboral = New DevExpress.XtraEditors.LabelControl()
        Me.gpcSeguridad = New DevExpress.XtraEditors.GroupControl()
        Me.lblNumeroAcceso = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumeroAcceso = New DevExpress.XtraEditors.TextEdit()
        Me.gpcComandosDatosLaborales = New DevExpress.XtraEditors.GroupControl()
        Me.btnGuardarDatosLaborales = New DevExpress.XtraEditors.SimpleButton()
        Me.gpcAntecedenteWeb = New DevExpress.XtraEditors.GroupControl()
        Me.txtTituloProfesionalExpertiz = New DevExpress.XtraEditors.TextEdit()
        Me.lblTituloProfesionalExpertiz = New System.Windows.Forms.Label()
        Me.txtFuncionDesempeno = New DevExpress.XtraEditors.TextEdit()
        Me.chkPublicaDatos = New DevExpress.XtraEditors.CheckEdit()
        Me.lblFuncionDesempeño = New System.Windows.Forms.Label()
        Me.gpcDatosContractuales = New DevExpress.XtraEditors.GroupControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dedFechaIngresoCalidadJuridica = New DevExpress.XtraEditors.DateEdit()
        Me.lueCalJur = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtFechaAsignacionGrado = New DevExpress.XtraEditors.TextEdit()
        Me.lblFechaAsignacionGrado = New System.Windows.Forms.Label()
        Me.cbbEscalafon = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbbGrado = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbbClasificacionEmpleado = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblCalidadJuridica = New System.Windows.Forms.Label()
        Me.lblfechaIngInstittucion = New System.Windows.Forms.Label()
        Me.lblEscalafon = New System.Windows.Forms.Label()
        Me.lblGrado = New System.Windows.Forms.Label()
        Me.lblFechaIngAdmPublica = New System.Windows.Forms.Label()
        Me.lblClasifiaccionEmpleado = New System.Windows.Forms.Label()
        Me.dedFechaIngInstitucion = New DevExpress.XtraEditors.DateEdit()
        Me.dedFechaIngAdmPublica = New DevExpress.XtraEditors.DateEdit()
        Me.gpcDatosRetiroEmpleado = New DevExpress.XtraEditors.GroupControl()
        Me.txtResolucionRetiro = New DevExpress.XtraEditors.TextEdit()
        Me.lblResolucionRetiro = New System.Windows.Forms.Label()
        Me.cbbMotivoRetiro = New DevExpress.XtraEditors.LookUpEdit()
        Me.dedFechaRetiro = New DevExpress.XtraEditors.DateEdit()
        Me.lblMotivoRetiro = New System.Windows.Forms.Label()
        Me.lblFechaRetiro = New System.Windows.Forms.Label()
        Me.gpcDatosResolucion = New DevExpress.XtraEditors.GroupControl()
        Me.txtNroResolucionContrato = New DevExpress.XtraEditors.TextEdit()
        Me.dedFechaResolucion = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaResolucion = New System.Windows.Forms.Label()
        Me.lblResolucionContrato = New System.Windows.Forms.Label()
        Me.gpcInformacionContractualGeneral = New DevExpress.XtraEditors.GroupControl()
        Me.chkIncluirParaEvaluacionDesempeño = New DevExpress.XtraEditors.CheckEdit()
        Me.cbbJefeEvalDesempeno = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lueTipoBeneficiario = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblTipoBeneficiario = New System.Windows.Forms.Label()
        Me.cbbEstamento = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblEstamento = New System.Windows.Forms.Label()
        Me.cbbHorarioTrabajo = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbbUbicacionFisica = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbbJefeDirecto = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblJefeDirecto = New System.Windows.Forms.Label()
        Me.lblUbicacionFisica = New System.Windows.Forms.Label()
        Me.lblHorarioTrabajo = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.txtCargo = New DevExpress.XtraEditors.TextEdit()
        Me.xtpEstructuraOrganizacional = New DevExpress.XtraTab.XtraTabPage()
        Me.lblNombreEstructuraOrganizacional = New System.Windows.Forms.Label()
        Me.lblMensajeEstruOrgannica = New DevExpress.XtraEditors.LabelControl()
        Me.gdcEstructuraContable = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleEstructuraContable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ESTRUCTURA_CONTABLE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ESTADO_REGISTRO_CONTAB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESC_CENTRO_COSTO_CONTABLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESC_CENTRO_COSTO_PRESUP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PORCENTAJE_DISTRIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESC_PERIODO_CONTABLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcOrganigrama = New DevExpress.XtraEditors.GroupControl()
        Me.lblSubDepto = New DevExpress.XtraEditors.LabelControl()
        Me.lueSubDepto = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueAutorizadorHorasExtras = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueEvaluadorDesempeno = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblAutorizadorHorasExtras = New DevExpress.XtraEditors.LabelControl()
        Me.lblEvaluadorDesempeño = New DevExpress.XtraEditors.LabelControl()
        Me.btnEliminarEstrucOrg = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardarEstrucOrg = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelarEstrucOrg = New DevExpress.XtraEditors.SimpleButton()
        Me.gdcEstructuraOrganica = New DevExpress.XtraGrid.GridControl()
        Me.gdvEstructuraOrganica = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ESTRUCTURA_ORGANICA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ESTADO_REGISTRO_ORGANICA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EMPLEADO_ID_EO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESC_ORGANIZACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESC_DIRECCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESC_DEPTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESC_PERIODO_ORGANICA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESC_SUBDEPTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lueInstitucion = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueDepartamento = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueDireccion = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblDepartamento = New DevExpress.XtraEditors.LabelControl()
        Me.lblDireccion = New DevExpress.XtraEditors.LabelControl()
        Me.lblOrganizacion = New DevExpress.XtraEditors.LabelControl()
        Me.gcCentrosCostos = New DevExpress.XtraEditors.GroupControl()
        Me.lblPorcentajeSign = New DevExpress.XtraEditors.LabelControl()
        Me.txtPorcentajeDistribucion = New DevExpress.XtraEditors.TextEdit()
        Me.lblPorcentajeDistribucion = New DevExpress.XtraEditors.LabelControl()
        Me.lueCentroCostoPresupuesto = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueCentroCostoContable = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblCentroDeCostoPresupuesto = New DevExpress.XtraEditors.LabelControl()
        Me.lblCentroDeCostoContable = New DevExpress.XtraEditors.LabelControl()
        Me.btnGuardarEstructuraContable = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelarEstructuraContable = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminarEstructuraContable = New DevExpress.XtraEditors.SimpleButton()
        Me.xtpDatosPrevisionales = New DevExpress.XtraTab.XtraTabPage()
        Me.lblNombreDatosPrevisionales = New System.Windows.Forms.Label()
        Me.lblMensajePrevisional = New DevExpress.XtraEditors.LabelControl()
        Me.btnGuardarDatosPrevisionales = New DevExpress.XtraEditors.SimpleButton()
        Me.gpcDatosFondoPenciones = New DevExpress.XtraEditors.GroupControl()
        Me.deeAfpFechaFun = New DevExpress.XtraEditors.DateEdit()
        Me.chkFondoE = New DevExpress.XtraEditors.CheckEdit()
        Me.txtAfpNroFun = New DevExpress.XtraEditors.TextEdit()
        Me.chkFondoD = New DevExpress.XtraEditors.CheckEdit()
        Me.chkFondoC = New DevExpress.XtraEditors.CheckEdit()
        Me.chkFondoB = New DevExpress.XtraEditors.CheckEdit()
        Me.chkFondoA = New DevExpress.XtraEditors.CheckEdit()
        Me.lblMultiFondoPrevisional = New System.Windows.Forms.Label()
        Me.lueUnidadCotizacionVol = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueUnidadAhorroAfp = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueAfp = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblInsitucionPrevisional = New System.Windows.Forms.Label()
        Me.txtMontoCotizacionVoluntaria = New DevExpress.XtraEditors.TextEdit()
        Me.txtMontoAhorroAfp = New DevExpress.XtraEditors.TextEdit()
        Me.lblAfpFechaFun = New System.Windows.Forms.Label()
        Me.lblApfNroFun = New System.Windows.Forms.Label()
        Me.lblCotizacionVol = New System.Windows.Forms.Label()
        Me.lblTipoMonedaCtaAhorro = New System.Windows.Forms.Label()
        Me.lblMontoCtaAhorro = New System.Windows.Forms.Label()
        Me.dedFechaAfiliacionPrevisional = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaAfiliacionAFP = New System.Windows.Forms.Label()
        Me.dedFechaIngsistemaPrev = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaIngSistemaPrev = New System.Windows.Forms.Label()
        Me.gpcDatosSaludPrevisional = New DevExpress.XtraEditors.GroupControl()
        Me.deeIsapreFechaFun = New DevExpress.XtraEditors.DateEdit()
        Me.txtIsapreNroFun = New DevExpress.XtraEditors.TextEdit()
        Me.lueTipoTrabajadorPrevired = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblIsapreFechaFun = New System.Windows.Forms.Label()
        Me.lblIsapreNroFun = New System.Windows.Forms.Label()
        Me.lblTipoTrabajadorPrevired = New System.Windows.Forms.Label()
        Me.lueUnidadMontoPlanAuge = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtMontoPlanAuge = New DevExpress.XtraEditors.TextEdit()
        Me.lblMontoPlanAuge = New System.Windows.Forms.Label()
        Me.lueUnidadMontoPlanComplementario = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueUnidadMontoConvenio = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueIsapre = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMontoPlanComplementario = New DevExpress.XtraEditors.TextEdit()
        Me.txtMontoConvenio = New DevExpress.XtraEditors.TextEdit()
        Me.lblMontoPlanComplementario = New System.Windows.Forms.Label()
        Me.lbllbTipoMonedaConvenioSalud = New System.Windows.Forms.Label()
        Me.lblMontoConvenioSalud = New System.Windows.Forms.Label()
        Me.dedFechaAfiliacionSalud = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaAfiliacionIsapreFonosa = New System.Windows.Forms.Label()
        Me.lblInstitucionSalud = New System.Windows.Forms.Label()
        Me.btnGuardaryConservar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardarRegistroActual = New DevExpress.XtraEditors.SimpleButton()
        Me.gpcDetallePrevisional = New DevExpress.XtraEditors.GroupControl()
        Me.gdcPrevision = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetallePrevision = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNOMBRE_ESTADO_REGISTRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_ING_SISTEMA_PREVIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_AFP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTASA_DESCUENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCUENTO_LEY_19882 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_AFILIACION_AFP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_AHORRO_AFP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_COTIZACION_VOLUNTARIA_AFP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_ISAPRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_AFILIACION_ISAPRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_ISAPRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPLAN_COMPLEM_ISAPRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colANTECEDENTE_PREVIS_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.xtpDatosAPV = New DevExpress.XtraTab.XtraTabPage()
        Me.lblNombreDatosAPV = New System.Windows.Forms.Label()
        Me.lblMensajeAPV = New DevExpress.XtraEditors.LabelControl()
        Me.dgAntecedenteAPV = New DevExpress.XtraGrid.GridControl()
        Me.gvDetalleAPV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NOMBRE_TIPO_APV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TIPO_AHORRO_PREVISIONAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NOMBRE_APV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.APV_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MONTO_AHORRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMontoAhorro = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.MONEDA_AHORRO_APV_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NOMBRE_UNIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ANTECEDENTE_APV_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gpcDetalleAPV = New DevExpress.XtraEditors.GroupControl()
        Me.lueUnidadMontoAPV = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblTipoUnidad = New System.Windows.Forms.Label()
        Me.txtMontoAPV = New DevExpress.XtraEditors.TextEdit()
        Me.lblMontoAPV = New System.Windows.Forms.Label()
        Me.lueAPV = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblInstitucionAPV = New System.Windows.Forms.Label()
        Me.lblTipoAhorro = New System.Windows.Forms.Label()
        Me.rdgTipoAhorro = New DevExpress.XtraEditors.RadioGroup()
        Me.btnGuardarAPV = New DevExpress.XtraEditors.SimpleButton()
        Me.xtpDatosRemuneracion = New DevExpress.XtraTab.XtraTabPage()
        Me.lblNombreDatosRemuneracion = New System.Windows.Forms.Label()
        Me.lblMensajeRemuneracion = New DevExpress.XtraEditors.LabelControl()
        Me.gpcDatosAsignacionZona = New DevExpress.XtraEditors.GroupControl()
        Me.lueZona = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblZona = New DevExpress.XtraEditors.LabelControl()
        Me.lblNúmeroCuentaBanco = New System.Windows.Forms.Label()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.lblTipoCuentaBanco = New System.Windows.Forms.Label()
        Me.lblFormaPago = New System.Windows.Forms.Label()
        Me.lblAsociacionGremial = New System.Windows.Forms.Label()
        Me.txtNumeroCuentaBanco = New DevExpress.XtraEditors.TextEdit()
        Me.gpcDatosAsociacionGremial = New DevExpress.XtraEditors.GroupControl()
        Me.dteFechaIngBienestar = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaIngBienestar = New System.Windows.Forms.Label()
        Me.dteFechaIngAsocGremial = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaIngAsocGremial = New System.Windows.Forms.Label()
        Me.lblFondoBienestar = New System.Windows.Forms.Label()
        Me.rdgFondoBienestar = New DevExpress.XtraEditors.RadioGroup()
        Me.lueAsociacionGremial = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueTipoCuentaBanco = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueBanco = New DevExpress.XtraEditors.LookUpEdit()
        Me.rdgFormaPago = New DevExpress.XtraEditors.RadioGroup()
        Me.gpcCargasFamiliares = New DevExpress.XtraEditors.GroupControl()
        Me.speCargaFamPreNatal = New DevExpress.XtraEditors.SpinEdit()
        Me.lblCargaFamPreNatal = New System.Windows.Forms.Label()
        Me.speCargaFamInvalidez = New DevExpress.XtraEditors.SpinEdit()
        Me.lblCargaFamInvalidez = New System.Windows.Forms.Label()
        Me.speCargaFamNormal = New DevExpress.XtraEditors.SpinEdit()
        Me.lueTramoCargaFamiliar = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblCargaFamNormal = New System.Windows.Forms.Label()
        Me.lblTramoAsignacionFam = New System.Windows.Forms.Label()
        Me.gpcFormaPago = New DevExpress.XtraEditors.GroupControl()
        Me.btnDetallePresupuestoAnualHonorario = New DevExpress.XtraEditors.SimpleButton()
        Me.gpcMontosRemuneraciones = New DevExpress.XtraEditors.GroupControl()
        Me.chkAsignaLey18675Art11 = New System.Windows.Forms.CheckBox()
        Me.txtMontoAsignacionZona = New DevExpress.XtraEditors.TextEdit()
        Me.lblAsignacionZona = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblIncrementoPrevDL3501 = New System.Windows.Forms.Label()
        Me.txtIncrementoPrevisDL3501 = New DevExpress.XtraEditors.TextEdit()
        Me.lblLey3551 = New System.Windows.Forms.Label()
        Me.txtMontoLey3551 = New DevExpress.XtraEditors.TextEdit()
        Me.lblGastoRepresentacion = New System.Windows.Forms.Label()
        Me.txtGastoRepresentacion = New DevExpress.XtraEditors.TextEdit()
        Me.txtLey18566 = New DevExpress.XtraEditors.TextEdit()
        Me.lblLey18566 = New System.Windows.Forms.Label()
        Me.txtLey18675Art11 = New DevExpress.XtraEditors.TextEdit()
        Me.txtLey18675Art10 = New DevExpress.XtraEditors.TextEdit()
        Me.txtLey18717 = New DevExpress.XtraEditors.TextEdit()
        Me.lblLey18717 = New System.Windows.Forms.Label()
        Me.lblLey18675Art11 = New System.Windows.Forms.Label()
        Me.lblLey18675Art10 = New System.Windows.Forms.Label()
        Me.gpbLineaHorizontal = New System.Windows.Forms.GroupBox()
        Me.lblLey19185 = New System.Windows.Forms.Label()
        Me.txtMontoLey19185Art18 = New DevExpress.XtraEditors.TextEdit()
        Me.txtMontoAsigResponsabilidadSuperior = New DevExpress.XtraEditors.TextEdit()
        Me.txtMontoLey19185Art19 = New DevExpress.XtraEditors.TextEdit()
        Me.txtMontoSueldoBase = New DevExpress.XtraEditors.TextEdit()
        Me.txtMontoRentaBase = New DevExpress.XtraEditors.TextEdit()
        Me.lblMontoRentaBase = New System.Windows.Forms.Label()
        Me.lblMontoAsigRespon = New System.Windows.Forms.Label()
        Me.lblMontoAsigProfesional = New System.Windows.Forms.Label()
        Me.lblMontoSueldoBase = New System.Windows.Forms.Label()
        Me.btnGuardarDatosRemuneracion = New DevExpress.XtraEditors.SimpleButton()
        Me.gpcDefinicionAsignaciones = New DevExpress.XtraEditors.GroupControl()
        Me.memObservacionesBienio = New DevExpress.XtraEditors.MemoEdit()
        Me.chkEntregoBoletaHonorario = New DevExpress.XtraEditors.CheckEdit()
        Me.txtPorcentajeLey19863 = New DevExpress.XtraEditors.TextEdit()
        Me.lblPorcentajeLey19863 = New System.Windows.Forms.Label()
        Me.txtMontoFuncionCritica = New DevExpress.XtraEditors.TextEdit()
        Me.lblMontoFuncionCritica = New System.Windows.Forms.Label()
        Me.dteFechaCumplioBienio = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaCimplioBienio = New System.Windows.Forms.Label()
        Me.speNumeroBienios = New DevExpress.XtraEditors.SpinEdit()
        Me.lblNumeroBienios = New System.Windows.Forms.Label()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.mnuListadoPersonal = New System.Windows.Forms.MenuItem()
        Me.mnuRptFichaEmpleado = New System.Windows.Forms.MenuItem()
        Me.mnuLstAntiguedad = New System.Windows.Forms.MenuItem()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dvNivelEstudios = New System.Data.DataView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dvEmpleados = New System.Data.DataView()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.xtcFichaEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcFichaEmpleado.SuspendLayout()
        Me.xtpDatosPersonales.SuspendLayout()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbEstadoEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcComandos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcComandos.SuspendLayout()
        Me.gpbFotoEmpleado.SuspendLayout()
        CType(Me.picEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDatosEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDatosEmpleado.SuspendLayout()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbEstadoCivil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaNacimiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaNacimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbNivelEstudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEdad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgSexo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoMaterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leRut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleRut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoPaterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpDireccionParticular.SuspendLayout()
        CType(Me.gpcComandosDatosContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcComandosDatosContacto.SuspendLayout()
        CType(Me.cbbPais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDomicilio.SuspendLayout()
        CType(Me.txtCodigoPostal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCalle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbRegion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefonoParticular.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCelular.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVillaPoblacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbCiudad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbComuna.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpDatosGenerales.SuspendLayout()
        CType(Me.gpcComandosDatosGenerales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcComandosDatosGenerales.SuspendLayout()
        Me.grpDatosGenerales.SuspendLayout()
        CType(Me.txtFonoContactoEmergencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMedicamentosContraindicados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEnfermedadCronica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlergias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGrupoSanguineo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMatriculaMilitar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServicioMilitar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFonoAnexo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpDatosLaborales.SuspendLayout()
        CType(Me.gpcSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeguridad.SuspendLayout()
        CType(Me.txtNumeroAcceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcComandosDatosLaborales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcComandosDatosLaborales.SuspendLayout()
        CType(Me.gpcAntecedenteWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcAntecedenteWeb.SuspendLayout()
        CType(Me.txtTituloProfesionalExpertiz.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFuncionDesempeno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPublicaDatos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDatosContractuales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDatosContractuales.SuspendLayout()
        CType(Me.dedFechaIngresoCalidadJuridica.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaIngresoCalidadJuridica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCalJur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaAsignacionGrado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbEscalafon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbGrado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbClasificacionEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaIngInstitucion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaIngInstitucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaIngAdmPublica.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaIngAdmPublica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDatosRetiroEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDatosRetiroEmpleado.SuspendLayout()
        CType(Me.txtResolucionRetiro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbMotivoRetiro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaRetiro.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaRetiro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDatosResolucion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDatosResolucion.SuspendLayout()
        CType(Me.txtNroResolucionContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaResolucion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaResolucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcInformacionContractualGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcInformacionContractualGeneral.SuspendLayout()
        CType(Me.chkIncluirParaEvaluacionDesempeño.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbJefeEvalDesempeno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTipoBeneficiario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbEstamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbHorarioTrabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbUbicacionFisica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbJefeDirecto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpEstructuraOrganizacional.SuspendLayout()
        CType(Me.gdcEstructuraContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleEstructuraContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcOrganigrama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcOrganigrama.SuspendLayout()
        CType(Me.lueSubDepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueAutorizadorHorasExtras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueEvaluadorDesempeno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcEstructuraOrganica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvEstructuraOrganica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueInstitucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCentrosCostos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcCentrosCostos.SuspendLayout()
        CType(Me.txtPorcentajeDistribucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCentroCostoPresupuesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCentroCostoContable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpDatosPrevisionales.SuspendLayout()
        CType(Me.gpcDatosFondoPenciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDatosFondoPenciones.SuspendLayout()
        CType(Me.deeAfpFechaFun.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deeAfpFechaFun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFondoE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAfpNroFun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFondoD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFondoC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFondoB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFondoA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueUnidadCotizacionVol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueUnidadAhorroAfp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueAfp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoCotizacionVoluntaria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoAhorroAfp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaAfiliacionPrevisional.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaAfiliacionPrevisional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaIngsistemaPrev.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaIngsistemaPrev.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDatosSaludPrevisional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDatosSaludPrevisional.SuspendLayout()
        CType(Me.deeIsapreFechaFun.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deeIsapreFechaFun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIsapreNroFun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTipoTrabajadorPrevired.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueUnidadMontoPlanAuge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoPlanAuge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueUnidadMontoPlanComplementario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueUnidadMontoConvenio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueIsapre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoPlanComplementario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoConvenio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaAfiliacionSalud.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaAfiliacionSalud.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDetallePrevisional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDetallePrevisional.SuspendLayout()
        CType(Me.gdcPrevision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetallePrevision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpDatosAPV.SuspendLayout()
        CType(Me.dgAntecedenteAPV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalleAPV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoAhorro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDetalleAPV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDetalleAPV.SuspendLayout()
        CType(Me.lueUnidadMontoAPV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoAPV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueAPV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgTipoAhorro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpDatosRemuneracion.SuspendLayout()
        CType(Me.gpcDatosAsignacionZona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDatosAsignacionZona.SuspendLayout()
        CType(Me.lueZona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroCuentaBanco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDatosAsociacionGremial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDatosAsociacionGremial.SuspendLayout()
        CType(Me.dteFechaIngBienestar.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaIngBienestar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaIngAsocGremial.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaIngAsocGremial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgFondoBienestar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueAsociacionGremial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTipoCuentaBanco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBanco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcCargasFamiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcCargasFamiliares.SuspendLayout()
        CType(Me.speCargaFamPreNatal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.speCargaFamInvalidez.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.speCargaFamNormal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTramoCargaFamiliar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcFormaPago.SuspendLayout()
        CType(Me.gpcMontosRemuneraciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcMontosRemuneraciones.SuspendLayout()
        CType(Me.txtMontoAsignacionZona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIncrementoPrevisDL3501.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoLey3551.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGastoRepresentacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLey18566.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLey18675Art11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLey18675Art10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLey18717.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoLey19185Art18.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoAsigResponsabilidadSuperior.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoLey19185Art19.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoSueldoBase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoRentaBase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDefinicionAsignaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDefinicionAsignaciones.SuspendLayout()
        CType(Me.memObservacionesBienio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEntregoBoletaHonorario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentajeLey19863.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoFuncionCritica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaCumplioBienio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaCumplioBienio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.speNumeroBienios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvNivelEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEstadoEmpleado
        '
        Me.lblEstadoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoEmpleado.Location = New System.Drawing.Point(560, 56)
        Me.lblEstadoEmpleado.Name = "lblEstadoEmpleado"
        Me.lblEstadoEmpleado.Size = New System.Drawing.Size(104, 16)
        Me.lblEstadoEmpleado.TabIndex = 31
        Me.lblEstadoEmpleado.Text = "Estado Empleado"
        Me.lblEstadoEmpleado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtcFichaEmpleado
        '
        Me.xtcFichaEmpleado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xtcFichaEmpleado.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtcFichaEmpleado.Appearance.Options.UseFont = True
        Me.xtcFichaEmpleado.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.xtcFichaEmpleado.Location = New System.Drawing.Point(0, 0)
        Me.xtcFichaEmpleado.Name = "xtcFichaEmpleado"
        Me.xtcFichaEmpleado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.xtcFichaEmpleado.SelectedTabPage = Me.xtpDatosPersonales
        Me.xtcFichaEmpleado.Size = New System.Drawing.Size(1008, 677)
        Me.xtcFichaEmpleado.TabIndex = 0
        Me.xtcFichaEmpleado.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpDatosPersonales, Me.xtpDireccionParticular, Me.xtpDatosGenerales, Me.xtpDatosLaborales, Me.xtpEstructuraOrganizacional, Me.xtpDatosPrevisionales, Me.xtpDatosAPV, Me.xtpDatosRemuneracion})
        '
        'xtpDatosPersonales
        '
        Me.xtpDatosPersonales.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtpDatosPersonales.Appearance.Header.Options.UseFont = True
        Me.xtpDatosPersonales.Controls.Add(Me.lblApellidos)
        Me.xtpDatosPersonales.Controls.Add(Me.lblRut)
        Me.xtpDatosPersonales.Controls.Add(Me.lblID)
        Me.xtpDatosPersonales.Controls.Add(Me.txtID)
        Me.xtpDatosPersonales.Controls.Add(Me.txtDV)
        Me.xtpDatosPersonales.Controls.Add(Me.lblNombres)
        Me.xtpDatosPersonales.Controls.Add(Me.lblNivelEstudio)
        Me.xtpDatosPersonales.Controls.Add(Me.cbbEstadoEmpleado)
        Me.xtpDatosPersonales.Controls.Add(Me.gpcComandos)
        Me.xtpDatosPersonales.Controls.Add(Me.gpbFotoEmpleado)
        Me.xtpDatosPersonales.Controls.Add(Me.lblEstadoEmpleado)
        Me.xtpDatosPersonales.Controls.Add(Me.gpcDatosEmpleado)
        Me.xtpDatosPersonales.Name = "xtpDatosPersonales"
        Me.xtpDatosPersonales.Size = New System.Drawing.Size(1001, 648)
        Me.xtpDatosPersonales.Text = "Datos Personales"
        '
        'lblApellidos
        '
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.Location = New System.Drawing.Point(104, 168)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(56, 16)
        Me.lblApellidos.TabIndex = 24
        Me.lblApellidos.Text = "Apellidos"
        Me.lblApellidos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRut
        '
        Me.lblRut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRut.Location = New System.Drawing.Point(131, 128)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(29, 16)
        Me.lblRut.TabIndex = 12
        Me.lblRut.Text = "Rut"
        Me.lblRut.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblID
        '
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(88, 75)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(72, 16)
        Me.lblID.TabIndex = 8
        Me.lblID.Text = "Identificador"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(168, 75)
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtID.Properties.Mask.EditMask = "n0"
        Me.txtID.Properties.Mask.IgnoreMaskBlank = False
        Me.txtID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtID.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtID.Properties.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(62, 20)
        Me.txtID.TabIndex = 2
        '
        'txtDV
        '
        Me.txtDV.EnterMoveNextControl = True
        Me.txtDV.Location = New System.Drawing.Point(320, 128)
        Me.txtDV.Name = "txtDV"
        Me.txtDV.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDV.Properties.MaxLength = 1
        Me.txtDV.Size = New System.Drawing.Size(32, 20)
        Me.txtDV.TabIndex = 10
        '
        'lblNombres
        '
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.Location = New System.Drawing.Point(107, 200)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(53, 16)
        Me.lblNombres.TabIndex = 25
        Me.lblNombres.Text = "Nombres"
        Me.lblNombres.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNivelEstudio
        '
        Me.lblNivelEstudio.Location = New System.Drawing.Point(64, 296)
        Me.lblNivelEstudio.Name = "lblNivelEstudio"
        Me.lblNivelEstudio.Size = New System.Drawing.Size(96, 16)
        Me.lblNivelEstudio.TabIndex = 28
        Me.lblNivelEstudio.Text = "Nivel de Estudio"
        Me.lblNivelEstudio.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbbEstadoEmpleado
        '
        Me.cbbEstadoEmpleado.Enabled = False
        Me.cbbEstadoEmpleado.Location = New System.Drawing.Point(672, 56)
        Me.cbbEstadoEmpleado.Name = "cbbEstadoEmpleado"
        Me.cbbEstadoEmpleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbEstadoEmpleado.Size = New System.Drawing.Size(136, 20)
        Me.cbbEstadoEmpleado.TabIndex = 10
        '
        'gpcComandos
        '
        Me.gpcComandos.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcComandos.AppearanceCaption.Options.UseFont = True
        Me.gpcComandos.Controls.Add(Me.btnCancelar)
        Me.gpcComandos.Controls.Add(Me.btnEliminar)
        Me.gpcComandos.Controls.Add(Me.btnGuardar)
        Me.gpcComandos.Controls.Add(Me.btnNuevo)
        Me.gpcComandos.Location = New System.Drawing.Point(16, 365)
        Me.gpcComandos.Name = "gpcComandos"
        Me.gpcComandos.Size = New System.Drawing.Size(808, 64)
        Me.gpcComandos.TabIndex = 32
        Me.gpcComandos.Text = "Operaciones"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(360, 32)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(104, 23)
        Me.btnCancelar.TabIndex = 38
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(248, 32)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(104, 23)
        Me.btnEliminar.TabIndex = 36
        Me.btnEliminar.Text = "&Eliminar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(136, 32)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(104, 23)
        Me.btnGuardar.TabIndex = 34
        Me.btnGuardar.Text = "&Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(16, 32)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(112, 23)
        Me.btnNuevo.TabIndex = 32
        Me.btnNuevo.Text = "&Nuevo"
        '
        'gpbFotoEmpleado
        '
        Me.gpbFotoEmpleado.Controls.Add(Me.btnConfirmarFotografia)
        Me.gpbFotoEmpleado.Controls.Add(Me.picEmpleado)
        Me.gpbFotoEmpleado.Location = New System.Drawing.Point(648, 88)
        Me.gpbFotoEmpleado.Name = "gpbFotoEmpleado"
        Me.gpbFotoEmpleado.Size = New System.Drawing.Size(160, 200)
        Me.gpbFotoEmpleado.TabIndex = 0
        Me.gpbFotoEmpleado.TabStop = False
        Me.gpbFotoEmpleado.Text = "Fotografía"
        '
        'btnConfirmarFotografia
        '
        Me.btnConfirmarFotografia.Location = New System.Drawing.Point(16, 160)
        Me.btnConfirmarFotografia.Name = "btnConfirmarFotografia"
        Me.btnConfirmarFotografia.Size = New System.Drawing.Size(128, 23)
        Me.btnConfirmarFotografia.TabIndex = 30
        Me.btnConfirmarFotografia.Text = "Confirmar Fotografía"
        '
        'picEmpleado
        '
        Me.picEmpleado.Location = New System.Drawing.Point(16, 24)
        Me.picEmpleado.MenuManager = Me.BarManager1
        Me.picEmpleado.Name = "picEmpleado"
        Me.BarManager1.SetPopupContextMenu(Me.picEmpleado, Me.PopupMenu1)
        Me.picEmpleado.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.picEmpleado.Size = New System.Drawing.Size(128, 128)
        Me.picEmpleado.TabIndex = 28
        Me.picEmpleado.TabStop = True
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.picEmpleadoCargarFotografia, Me.picEmpleadoEliminarFotografia, Me.picEmpleadoExportarFotografia})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.picEmpleadoCargarFotografia), New DevExpress.XtraBars.LinkPersistInfo(Me.picEmpleadoEliminarFotografia), New DevExpress.XtraBars.LinkPersistInfo(Me.picEmpleadoExportarFotografia)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.MenuCaption = "Fotografía"
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'picEmpleadoCargarFotografia
        '
        Me.picEmpleadoCargarFotografia.Caption = "Cargar Fotografía"
        Me.picEmpleadoCargarFotografia.Id = 0
        Me.picEmpleadoCargarFotografia.Name = "picEmpleadoCargarFotografia"
        Me.picEmpleadoCargarFotografia.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'picEmpleadoEliminarFotografia
        '
        Me.picEmpleadoEliminarFotografia.Caption = "Eliminar Fotografía"
        Me.picEmpleadoEliminarFotografia.Id = 1
        Me.picEmpleadoEliminarFotografia.Name = "picEmpleadoEliminarFotografia"
        Me.picEmpleadoEliminarFotografia.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'picEmpleadoExportarFotografia
        '
        Me.picEmpleadoExportarFotografia.Caption = "Guardar foto en archivo JPG"
        Me.picEmpleadoExportarFotografia.Id = 3
        Me.picEmpleadoExportarFotografia.Name = "picEmpleadoExportarFotografia"
        Me.picEmpleadoExportarFotografia.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 2"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 1
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Custom 2"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 3"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Custom 4"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Custom 4"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1008, 49)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 656)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1008, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 49)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 607)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1008, 49)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 607)
        '
        'gpcDatosEmpleado
        '
        Me.gpcDatosEmpleado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDatosEmpleado.AppearanceCaption.Options.UseFont = True
        Me.gpcDatosEmpleado.Controls.Add(Me.lblEstadoCivil)
        Me.gpcDatosEmpleado.Controls.Add(Me.luePeriodo)
        Me.gpcDatosEmpleado.Controls.Add(Me.cbbEstadoCivil)
        Me.gpcDatosEmpleado.Controls.Add(Me.lblPeriodo)
        Me.gpcDatosEmpleado.Controls.Add(Me.dedFechaNacimiento)
        Me.gpcDatosEmpleado.Controls.Add(Me.lblFechaNacimiento)
        Me.gpcDatosEmpleado.Controls.Add(Me.lblBuscarEmpleado)
        Me.gpcDatosEmpleado.Controls.Add(Me.lueEmpleado)
        Me.gpcDatosEmpleado.Controls.Add(Me.cbbNivelEstudio)
        Me.gpcDatosEmpleado.Controls.Add(Me.lblEdad)
        Me.gpcDatosEmpleado.Controls.Add(Me.txtEdad)
        Me.gpcDatosEmpleado.Controls.Add(Me.rdgSexo)
        Me.gpcDatosEmpleado.Controls.Add(Me.lblApellidoPaterno)
        Me.gpcDatosEmpleado.Controls.Add(Me.lblApellidoMaterno)
        Me.gpcDatosEmpleado.Controls.Add(Me.txtApellidoMaterno)
        Me.gpcDatosEmpleado.Controls.Add(Me.leRut)
        Me.gpcDatosEmpleado.Controls.Add(Me.txtRut)
        Me.gpcDatosEmpleado.Controls.Add(Me.txtNombres)
        Me.gpcDatosEmpleado.Controls.Add(Me.txtApellidoPaterno)
        Me.gpcDatosEmpleado.Controls.Add(Me.btnAceptar)
        Me.gpcDatosEmpleado.Controls.Add(Me.lblSexo)
        Me.gpcDatosEmpleado.Controls.Add(Me.lblElCampoRut)
        Me.gpcDatosEmpleado.Location = New System.Drawing.Point(16, 16)
        Me.gpcDatosEmpleado.Name = "gpcDatosEmpleado"
        Me.gpcDatosEmpleado.Size = New System.Drawing.Size(808, 343)
        Me.gpcDatosEmpleado.TabIndex = 1
        Me.gpcDatosEmpleado.Text = "Datos Personales del Empleado"
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCivil.Location = New System.Drawing.Point(70, 248)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(72, 16)
        Me.lblEstadoCivil.TabIndex = 2
        Me.lblEstadoCivil.Text = "Estado Civil"
        Me.lblEstadoCivil.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(150, 33)
        Me.luePeriodo.Name = "luePeriodo"
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(145, 20)
        Me.luePeriodo.TabIndex = 0
        '
        'cbbEstadoCivil
        '
        Me.cbbEstadoCivil.EnterMoveNextControl = True
        Me.cbbEstadoCivil.Location = New System.Drawing.Point(150, 248)
        Me.cbbEstadoCivil.Name = "cbbEstadoCivil"
        Me.cbbEstadoCivil.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbEstadoCivil.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbbEstadoCivil.Size = New System.Drawing.Size(256, 20)
        Me.cbbEstadoCivil.TabIndex = 21
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(35, 36)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(108, 16)
        Me.lblPeriodo.TabIndex = 1
        Me.lblPeriodo.Text = "Período Histórico"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dedFechaNacimiento
        '
        Me.dedFechaNacimiento.EditValue = Nothing
        Me.dedFechaNacimiento.EnterMoveNextControl = True
        Me.dedFechaNacimiento.Location = New System.Drawing.Point(150, 215)
        Me.dedFechaNacimiento.Name = "dedFechaNacimiento"
        Me.dedFechaNacimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaNacimiento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dedFechaNacimiento.Properties.MinValue = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.dedFechaNacimiento.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaNacimiento.Size = New System.Drawing.Size(256, 20)
        Me.dedFechaNacimiento.TabIndex = 19
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(30, 215)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(112, 16)
        Me.lblFechaNacimiento.TabIndex = 3
        Me.lblFechaNacimiento.Text = "Fecha Nacimiento"
        Me.lblFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblBuscarEmpleado
        '
        Me.lblBuscarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarEmpleado.Location = New System.Drawing.Point(32, 87)
        Me.lblBuscarEmpleado.Name = "lblBuscarEmpleado"
        Me.lblBuscarEmpleado.Size = New System.Drawing.Size(112, 16)
        Me.lblBuscarEmpleado.TabIndex = 9
        Me.lblBuscarEmpleado.Text = "Buscar Empleado"
        Me.lblBuscarEmpleado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lueEmpleado
        '
        Me.lueEmpleado.Location = New System.Drawing.Point(152, 86)
        Me.lueEmpleado.Name = "lueEmpleado"
        Me.lueEmpleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueEmpleado.Size = New System.Drawing.Size(256, 20)
        Me.lueEmpleado.TabIndex = 0
        '
        'cbbNivelEstudio
        '
        Me.cbbNivelEstudio.EnterMoveNextControl = True
        Me.cbbNivelEstudio.Location = New System.Drawing.Point(152, 280)
        Me.cbbNivelEstudio.Name = "cbbNivelEstudio"
        Me.cbbNivelEstudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbNivelEstudio.Properties.NullText = ""
        Me.cbbNivelEstudio.Size = New System.Drawing.Size(256, 20)
        Me.cbbNivelEstudio.TabIndex = 24
        '
        'lblEdad
        '
        Me.lblEdad.Location = New System.Drawing.Point(48, 316)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(96, 16)
        Me.lblEdad.TabIndex = 29
        Me.lblEdad.Text = "Edad"
        Me.lblEdad.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtEdad
        '
        Me.txtEdad.Enabled = False
        Me.txtEdad.Location = New System.Drawing.Point(152, 312)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEdad.Properties.MaxLength = 20
        Me.txtEdad.Size = New System.Drawing.Size(256, 20)
        Me.txtEdad.TabIndex = 26
        '
        'rdgSexo
        '
        Me.rdgSexo.Location = New System.Drawing.Point(424, 232)
        Me.rdgSexo.Name = "rdgSexo"
        Me.rdgSexo.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.rdgSexo.Properties.Appearance.Options.UseFont = True
        Me.rdgSexo.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.rdgSexo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Masculino"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Femenino")})
        Me.rdgSexo.Size = New System.Drawing.Size(117, 64)
        Me.rdgSexo.TabIndex = 27
        '
        'lblApellidoPaterno
        '
        Me.lblApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoPaterno.Location = New System.Drawing.Point(152, 136)
        Me.lblApellidoPaterno.Name = "lblApellidoPaterno"
        Me.lblApellidoPaterno.Size = New System.Drawing.Size(40, 16)
        Me.lblApellidoPaterno.TabIndex = 22
        Me.lblApellidoPaterno.Text = "Paterno"
        '
        'lblApellidoMaterno
        '
        Me.lblApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoMaterno.Location = New System.Drawing.Point(352, 136)
        Me.lblApellidoMaterno.Name = "lblApellidoMaterno"
        Me.lblApellidoMaterno.Size = New System.Drawing.Size(48, 16)
        Me.lblApellidoMaterno.TabIndex = 23
        Me.lblApellidoMaterno.Text = "Materno"
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.EnterMoveNextControl = True
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(350, 152)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoMaterno.Properties.MaxLength = 20
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(184, 20)
        Me.txtApellidoMaterno.TabIndex = 16
        '
        'leRut
        '
        Me.leRut.Cursor = System.Windows.Forms.Cursors.Default
        Me.leRut.EditValue = ""
        Me.leRut.EnterMoveNextControl = True
        Me.leRut.Location = New System.Drawing.Point(151, 112)
        Me.leRut.Name = "leRut"
        Me.leRut.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.leRut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leRut.Properties.HideSelection = False
        Me.leRut.Properties.NullText = ""
        Me.leRut.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.leRut.Properties.ValidateOnEnterKey = True
        Me.leRut.Properties.View = Me.gleRut
        Me.leRut.Size = New System.Drawing.Size(144, 20)
        Me.leRut.TabIndex = 12
        '
        'gleRut
        '
        Me.gleRut.AppearancePrint.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gleRut.AppearancePrint.OddRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gleRut.AppearancePrint.OddRow.Options.UseBackColor = True
        Me.gleRut.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gleRut.Name = "gleRut"
        Me.gleRut.OptionsBehavior.Editable = False
        Me.gleRut.OptionsCustomization.AllowFilter = False
        Me.gleRut.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gleRut.OptionsView.ShowGroupPanel = False
        '
        'txtRut
        '
        Me.txtRut.EnterMoveNextControl = True
        Me.txtRut.Location = New System.Drawing.Point(152, 112)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRut.Properties.Mask.EditMask = "n0"
        Me.txtRut.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRut.Properties.MaxLength = 8
        Me.txtRut.Size = New System.Drawing.Size(144, 20)
        Me.txtRut.TabIndex = 8
        '
        'txtNombres
        '
        Me.txtNombres.EnterMoveNextControl = True
        Me.txtNombres.Location = New System.Drawing.Point(150, 183)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombres.Properties.MaxLength = 30
        Me.txtNombres.Size = New System.Drawing.Size(384, 20)
        Me.txtNombres.TabIndex = 18
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.EnterMoveNextControl = True
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(151, 152)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoPaterno.Properties.MaxLength = 20
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(184, 20)
        Me.txtApellidoPaterno.TabIndex = 14
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(414, 85)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(56, 23)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.Visible = False
        '
        'lblSexo
        '
        Me.lblSexo.Location = New System.Drawing.Point(424, 216)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblSexo.Size = New System.Drawing.Size(48, 16)
        Me.lblSexo.TabIndex = 30
        Me.lblSexo.Text = "Sexo"
        Me.lblSexo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblElCampoRut
        '
        Me.lblElCampoRut.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblElCampoRut.Location = New System.Drawing.Point(500, 72)
        Me.lblElCampoRut.Name = "lblElCampoRut"
        Me.lblElCampoRut.Size = New System.Drawing.Size(101, 36)
        Me.lblElCampoRut.TabIndex = 17
        Me.lblElCampoRut.Text = "El campo Rut consta de un txtRut y un leRut, leRut es para edición y txtRut para " & _
    "un empleado nuevo"
        Me.lblElCampoRut.Visible = False
        '
        'xtpDireccionParticular
        '
        Me.xtpDireccionParticular.Controls.Add(Me.lblNombreDatosContacto)
        Me.xtpDireccionParticular.Controls.Add(Me.lblMensajeContacto)
        Me.xtpDireccionParticular.Controls.Add(Me.gpcComandosDatosContacto)
        Me.xtpDireccionParticular.Controls.Add(Me.cbbPais)
        Me.xtpDireccionParticular.Controls.Add(Me.lblComuna)
        Me.xtpDireccionParticular.Controls.Add(Me.grpDomicilio)
        Me.xtpDireccionParticular.Name = "xtpDireccionParticular"
        Me.xtpDireccionParticular.Size = New System.Drawing.Size(1001, 648)
        Me.xtpDireccionParticular.Text = "Datos de Contacto"
        '
        'lblNombreDatosContacto
        '
        Me.lblNombreDatosContacto.AutoSize = True
        Me.lblNombreDatosContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDatosContacto.Location = New System.Drawing.Point(10, 10)
        Me.lblNombreDatosContacto.Name = "lblNombreDatosContacto"
        Me.lblNombreDatosContacto.Size = New System.Drawing.Size(90, 15)
        Me.lblNombreDatosContacto.TabIndex = 49
        Me.lblNombreDatosContacto.Text = "EMPLEADO: "
        '
        'lblMensajeContacto
        '
        Me.lblMensajeContacto.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMensajeContacto.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblMensajeContacto.Appearance.Options.UseFont = True
        Me.lblMensajeContacto.Appearance.Options.UseForeColor = True
        Me.lblMensajeContacto.Location = New System.Drawing.Point(723, 46)
        Me.lblMensajeContacto.Name = "lblMensajeContacto"
        Me.lblMensajeContacto.Size = New System.Drawing.Size(112, 13)
        Me.lblMensajeContacto.TabIndex = 48
        Me.lblMensajeContacto.Text = "lblMensajeContacto"
        '
        'gpcComandosDatosContacto
        '
        Me.gpcComandosDatosContacto.Controls.Add(Me.btnGuardarDatosContacto)
        Me.gpcComandosDatosContacto.Location = New System.Drawing.Point(13, 335)
        Me.gpcComandosDatosContacto.Name = "gpcComandosDatosContacto"
        Me.gpcComandosDatosContacto.Size = New System.Drawing.Size(704, 80)
        Me.gpcComandosDatosContacto.TabIndex = 47
        Me.gpcComandosDatosContacto.Text = "Operaciones"
        '
        'btnGuardarDatosContacto
        '
        Me.btnGuardarDatosContacto.Location = New System.Drawing.Point(48, 39)
        Me.btnGuardarDatosContacto.Name = "btnGuardarDatosContacto"
        Me.btnGuardarDatosContacto.Size = New System.Drawing.Size(104, 23)
        Me.btnGuardarDatosContacto.TabIndex = 1
        Me.btnGuardarDatosContacto.Text = "&Guardar"
        '
        'cbbPais
        '
        Me.cbbPais.Location = New System.Drawing.Point(205, 159)
        Me.cbbPais.Name = "cbbPais"
        Me.cbbPais.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbPais.Size = New System.Drawing.Size(176, 20)
        Me.cbbPais.TabIndex = 46
        '
        'lblComuna
        '
        Me.lblComuna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComuna.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblComuna.Location = New System.Drawing.Point(93, 231)
        Me.lblComuna.Name = "lblComuna"
        Me.lblComuna.Size = New System.Drawing.Size(100, 16)
        Me.lblComuna.TabIndex = 19
        Me.lblComuna.Text = "Comuna"
        Me.lblComuna.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grpDomicilio
        '
        Me.grpDomicilio.Controls.Add(Me.txtCodigoPostal)
        Me.grpDomicilio.Controls.Add(Me.lblCodigoPostal)
        Me.grpDomicilio.Controls.Add(Me.txtNumero)
        Me.grpDomicilio.Controls.Add(Me.lblNumeroDireccion)
        Me.grpDomicilio.Controls.Add(Me.txtCalle)
        Me.grpDomicilio.Controls.Add(Me.cbbRegion)
        Me.grpDomicilio.Controls.Add(Me.txtTelefonoParticular)
        Me.grpDomicilio.Controls.Add(Me.txtCelular)
        Me.grpDomicilio.Controls.Add(Me.txtVillaPoblacion)
        Me.grpDomicilio.Controls.Add(Me.cbbCiudad)
        Me.grpDomicilio.Controls.Add(Me.lblCiudad)
        Me.grpDomicilio.Controls.Add(Me.lblCalleAvda)
        Me.grpDomicilio.Controls.Add(Me.lblVillaPoblacion)
        Me.grpDomicilio.Controls.Add(Me.lblPais)
        Me.grpDomicilio.Controls.Add(Me.lblTelefono)
        Me.grpDomicilio.Controls.Add(Me.lblNumeroMovil)
        Me.grpDomicilio.Controls.Add(Me.lblRegion)
        Me.grpDomicilio.Controls.Add(Me.cbbComuna)
        Me.grpDomicilio.Location = New System.Drawing.Point(13, 31)
        Me.grpDomicilio.Name = "grpDomicilio"
        Me.grpDomicilio.Size = New System.Drawing.Size(704, 296)
        Me.grpDomicilio.TabIndex = 44
        Me.grpDomicilio.TabStop = False
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.Location = New System.Drawing.Point(192, 104)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(112, 20)
        Me.txtCodigoPostal.TabIndex = 49
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoPostal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCodigoPostal.Location = New System.Drawing.Point(80, 104)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(100, 16)
        Me.lblCodigoPostal.TabIndex = 48
        Me.lblCodigoPostal.Text = "Código Postal"
        Me.lblCodigoPostal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(192, 80)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(112, 20)
        Me.txtNumero.TabIndex = 47
        '
        'lblNumeroDireccion
        '
        Me.lblNumeroDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroDireccion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNumeroDireccion.Location = New System.Drawing.Point(80, 80)
        Me.lblNumeroDireccion.Name = "lblNumeroDireccion"
        Me.lblNumeroDireccion.Size = New System.Drawing.Size(100, 16)
        Me.lblNumeroDireccion.TabIndex = 46
        Me.lblNumeroDireccion.Text = "Nº"
        Me.lblNumeroDireccion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(192, 32)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(344, 20)
        Me.txtCalle.TabIndex = 27
        '
        'cbbRegion
        '
        Me.cbbRegion.Location = New System.Drawing.Point(192, 152)
        Me.cbbRegion.Name = "cbbRegion"
        Me.cbbRegion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbRegion.Size = New System.Drawing.Size(176, 20)
        Me.cbbRegion.TabIndex = 26
        '
        'txtTelefonoParticular
        '
        Me.txtTelefonoParticular.Location = New System.Drawing.Point(192, 248)
        Me.txtTelefonoParticular.Name = "txtTelefonoParticular"
        Me.txtTelefonoParticular.Size = New System.Drawing.Size(176, 20)
        Me.txtTelefonoParticular.TabIndex = 25
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(192, 224)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(176, 20)
        Me.txtCelular.TabIndex = 24
        '
        'txtVillaPoblacion
        '
        Me.txtVillaPoblacion.Location = New System.Drawing.Point(192, 56)
        Me.txtVillaPoblacion.Name = "txtVillaPoblacion"
        Me.txtVillaPoblacion.Size = New System.Drawing.Size(344, 20)
        Me.txtVillaPoblacion.TabIndex = 23
        '
        'cbbCiudad
        '
        Me.cbbCiudad.Location = New System.Drawing.Point(192, 176)
        Me.cbbCiudad.Name = "cbbCiudad"
        Me.cbbCiudad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbCiudad.Size = New System.Drawing.Size(176, 20)
        Me.cbbCiudad.TabIndex = 27
        '
        'lblCiudad
        '
        Me.lblCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiudad.Location = New System.Drawing.Point(80, 176)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(100, 16)
        Me.lblCiudad.TabIndex = 20
        Me.lblCiudad.Text = "Ciudad"
        Me.lblCiudad.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCalleAvda
        '
        Me.lblCalleAvda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalleAvda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCalleAvda.Location = New System.Drawing.Point(80, 32)
        Me.lblCalleAvda.Name = "lblCalleAvda"
        Me.lblCalleAvda.Size = New System.Drawing.Size(100, 16)
        Me.lblCalleAvda.TabIndex = 45
        Me.lblCalleAvda.Text = "Calle o Avenida"
        Me.lblCalleAvda.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVillaPoblacion
        '
        Me.lblVillaPoblacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVillaPoblacion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblVillaPoblacion.Location = New System.Drawing.Point(80, 56)
        Me.lblVillaPoblacion.Name = "lblVillaPoblacion"
        Me.lblVillaPoblacion.Size = New System.Drawing.Size(100, 16)
        Me.lblVillaPoblacion.TabIndex = 17
        Me.lblVillaPoblacion.Text = "Villa o Población"
        Me.lblVillaPoblacion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPais
        '
        Me.lblPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPais.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPais.Location = New System.Drawing.Point(80, 128)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(100, 16)
        Me.lblPais.TabIndex = 45
        Me.lblPais.Text = "País"
        Me.lblPais.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTelefono
        '
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTelefono.Location = New System.Drawing.Point(72, 248)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(112, 16)
        Me.lblTelefono.TabIndex = 21
        Me.lblTelefono.Text = "Teléfono Particular"
        Me.lblTelefono.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNumeroMovil
        '
        Me.lblNumeroMovil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroMovil.Location = New System.Drawing.Point(80, 224)
        Me.lblNumeroMovil.Name = "lblNumeroMovil"
        Me.lblNumeroMovil.Size = New System.Drawing.Size(100, 16)
        Me.lblNumeroMovil.TabIndex = 22
        Me.lblNumeroMovil.Text = "Número Móvil"
        Me.lblNumeroMovil.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRegion
        '
        Me.lblRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblRegion.Location = New System.Drawing.Point(80, 152)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(100, 16)
        Me.lblRegion.TabIndex = 18
        Me.lblRegion.Text = "Región"
        Me.lblRegion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbbComuna
        '
        Me.cbbComuna.Location = New System.Drawing.Point(192, 200)
        Me.cbbComuna.Name = "cbbComuna"
        Me.cbbComuna.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbComuna.Size = New System.Drawing.Size(176, 20)
        Me.cbbComuna.TabIndex = 28
        '
        'xtpDatosGenerales
        '
        Me.xtpDatosGenerales.Controls.Add(Me.lblNombreDatosGenerales)
        Me.xtpDatosGenerales.Controls.Add(Me.lblMensajeGeneral)
        Me.xtpDatosGenerales.Controls.Add(Me.gpcComandosDatosGenerales)
        Me.xtpDatosGenerales.Controls.Add(Me.grpDatosGenerales)
        Me.xtpDatosGenerales.Name = "xtpDatosGenerales"
        Me.xtpDatosGenerales.Size = New System.Drawing.Size(1001, 648)
        Me.xtpDatosGenerales.Text = "Datos Generales"
        '
        'lblNombreDatosGenerales
        '
        Me.lblNombreDatosGenerales.AutoSize = True
        Me.lblNombreDatosGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDatosGenerales.Location = New System.Drawing.Point(10, 10)
        Me.lblNombreDatosGenerales.Name = "lblNombreDatosGenerales"
        Me.lblNombreDatosGenerales.Size = New System.Drawing.Size(90, 15)
        Me.lblNombreDatosGenerales.TabIndex = 50
        Me.lblNombreDatosGenerales.Text = "EMPLEADO: "
        '
        'lblMensajeGeneral
        '
        Me.lblMensajeGeneral.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMensajeGeneral.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblMensajeGeneral.Appearance.Options.UseFont = True
        Me.lblMensajeGeneral.Appearance.Options.UseForeColor = True
        Me.lblMensajeGeneral.Location = New System.Drawing.Point(731, 40)
        Me.lblMensajeGeneral.Name = "lblMensajeGeneral"
        Me.lblMensajeGeneral.Size = New System.Drawing.Size(78, 13)
        Me.lblMensajeGeneral.TabIndex = 49
        Me.lblMensajeGeneral.Text = "LabelControl1"
        '
        'gpcComandosDatosGenerales
        '
        Me.gpcComandosDatosGenerales.Controls.Add(Me.btnGuardarDatosGenerales)
        Me.gpcComandosDatosGenerales.Location = New System.Drawing.Point(13, 407)
        Me.gpcComandosDatosGenerales.Name = "gpcComandosDatosGenerales"
        Me.gpcComandosDatosGenerales.Size = New System.Drawing.Size(704, 80)
        Me.gpcComandosDatosGenerales.TabIndex = 48
        Me.gpcComandosDatosGenerales.Text = "Operaciones"
        '
        'btnGuardarDatosGenerales
        '
        Me.btnGuardarDatosGenerales.Location = New System.Drawing.Point(300, 29)
        Me.btnGuardarDatosGenerales.Name = "btnGuardarDatosGenerales"
        Me.btnGuardarDatosGenerales.Size = New System.Drawing.Size(104, 23)
        Me.btnGuardarDatosGenerales.TabIndex = 27
        Me.btnGuardarDatosGenerales.Text = "&Guardar"
        '
        'grpDatosGenerales
        '
        Me.grpDatosGenerales.Controls.Add(Me.txtFonoContactoEmergencia)
        Me.grpDatosGenerales.Controls.Add(Me.txtMedicamentosContraindicados)
        Me.grpDatosGenerales.Controls.Add(Me.txtEnfermedadCronica)
        Me.grpDatosGenerales.Controls.Add(Me.txtAlergias)
        Me.grpDatosGenerales.Controls.Add(Me.txtGrupoSanguineo)
        Me.grpDatosGenerales.Controls.Add(Me.txtMatriculaMilitar)
        Me.grpDatosGenerales.Controls.Add(Me.txtServicioMilitar)
        Me.grpDatosGenerales.Controls.Add(Me.txtFonoAnexo)
        Me.grpDatosGenerales.Controls.Add(Me.lblSituacionMilitar)
        Me.grpDatosGenerales.Controls.Add(Me.lblNroMatriculaMilitar)
        Me.grpDatosGenerales.Controls.Add(Me.lblGrupoSanguineo)
        Me.grpDatosGenerales.Controls.Add(Me.lblAlergia)
        Me.grpDatosGenerales.Controls.Add(Me.lblNombreEnfernedadCronica)
        Me.grpDatosGenerales.Controls.Add(Me.lblMedicamentosContraindicados)
        Me.grpDatosGenerales.Controls.Add(Me.lblFonoNombreContacto)
        Me.grpDatosGenerales.Controls.Add(Me.lblFonoOficina)
        Me.grpDatosGenerales.Location = New System.Drawing.Point(13, 31)
        Me.grpDatosGenerales.Name = "grpDatosGenerales"
        Me.grpDatosGenerales.Size = New System.Drawing.Size(712, 368)
        Me.grpDatosGenerales.TabIndex = 25
        Me.grpDatosGenerales.TabStop = False
        '
        'txtFonoContactoEmergencia
        '
        Me.txtFonoContactoEmergencia.Location = New System.Drawing.Point(240, 80)
        Me.txtFonoContactoEmergencia.Name = "txtFonoContactoEmergencia"
        Me.txtFonoContactoEmergencia.Size = New System.Drawing.Size(320, 56)
        Me.txtFonoContactoEmergencia.TabIndex = 24
        '
        'txtMedicamentosContraindicados
        '
        Me.txtMedicamentosContraindicados.Location = New System.Drawing.Point(240, 264)
        Me.txtMedicamentosContraindicados.Name = "txtMedicamentosContraindicados"
        Me.txtMedicamentosContraindicados.Size = New System.Drawing.Size(320, 56)
        Me.txtMedicamentosContraindicados.TabIndex = 7
        '
        'txtEnfermedadCronica
        '
        Me.txtEnfermedadCronica.Location = New System.Drawing.Point(240, 240)
        Me.txtEnfermedadCronica.Name = "txtEnfermedadCronica"
        Me.txtEnfermedadCronica.Size = New System.Drawing.Size(320, 20)
        Me.txtEnfermedadCronica.TabIndex = 6
        '
        'txtAlergias
        '
        Me.txtAlergias.Location = New System.Drawing.Point(240, 216)
        Me.txtAlergias.Name = "txtAlergias"
        Me.txtAlergias.Size = New System.Drawing.Size(320, 20)
        Me.txtAlergias.TabIndex = 5
        '
        'txtGrupoSanguineo
        '
        Me.txtGrupoSanguineo.Location = New System.Drawing.Point(240, 192)
        Me.txtGrupoSanguineo.Name = "txtGrupoSanguineo"
        Me.txtGrupoSanguineo.Size = New System.Drawing.Size(320, 20)
        Me.txtGrupoSanguineo.TabIndex = 4
        '
        'txtMatriculaMilitar
        '
        Me.txtMatriculaMilitar.Location = New System.Drawing.Point(240, 168)
        Me.txtMatriculaMilitar.Name = "txtMatriculaMilitar"
        Me.txtMatriculaMilitar.Size = New System.Drawing.Size(320, 20)
        Me.txtMatriculaMilitar.TabIndex = 3
        '
        'txtServicioMilitar
        '
        Me.txtServicioMilitar.Location = New System.Drawing.Point(240, 144)
        Me.txtServicioMilitar.Name = "txtServicioMilitar"
        Me.txtServicioMilitar.Size = New System.Drawing.Size(320, 20)
        Me.txtServicioMilitar.TabIndex = 2
        '
        'txtFonoAnexo
        '
        Me.txtFonoAnexo.Location = New System.Drawing.Point(240, 56)
        Me.txtFonoAnexo.Name = "txtFonoAnexo"
        Me.txtFonoAnexo.Size = New System.Drawing.Size(320, 20)
        Me.txtFonoAnexo.TabIndex = 0
        '
        'lblSituacionMilitar
        '
        Me.lblSituacionMilitar.Location = New System.Drawing.Point(136, 144)
        Me.lblSituacionMilitar.Name = "lblSituacionMilitar"
        Me.lblSituacionMilitar.Size = New System.Drawing.Size(100, 16)
        Me.lblSituacionMilitar.TabIndex = 11
        Me.lblSituacionMilitar.Text = "Situación Militar"
        Me.lblSituacionMilitar.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNroMatriculaMilitar
        '
        Me.lblNroMatriculaMilitar.Location = New System.Drawing.Point(104, 168)
        Me.lblNroMatriculaMilitar.Name = "lblNroMatriculaMilitar"
        Me.lblNroMatriculaMilitar.Size = New System.Drawing.Size(133, 16)
        Me.lblNroMatriculaMilitar.TabIndex = 13
        Me.lblNroMatriculaMilitar.Text = "Nº Matrícula Militar"
        Me.lblNroMatriculaMilitar.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblGrupoSanguineo
        '
        Me.lblGrupoSanguineo.Location = New System.Drawing.Point(136, 192)
        Me.lblGrupoSanguineo.Name = "lblGrupoSanguineo"
        Me.lblGrupoSanguineo.Size = New System.Drawing.Size(105, 16)
        Me.lblGrupoSanguineo.TabIndex = 14
        Me.lblGrupoSanguineo.Text = "Grupo Sanguíneo"
        Me.lblGrupoSanguineo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAlergia
        '
        Me.lblAlergia.Location = New System.Drawing.Point(136, 216)
        Me.lblAlergia.Name = "lblAlergia"
        Me.lblAlergia.Size = New System.Drawing.Size(100, 16)
        Me.lblAlergia.TabIndex = 16
        Me.lblAlergia.Text = "Alergia(s)"
        Me.lblAlergia.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNombreEnfernedadCronica
        '
        Me.lblNombreEnfernedadCronica.Location = New System.Drawing.Point(72, 240)
        Me.lblNombreEnfernedadCronica.Name = "lblNombreEnfernedadCronica"
        Me.lblNombreEnfernedadCronica.Size = New System.Drawing.Size(165, 16)
        Me.lblNombreEnfernedadCronica.TabIndex = 18
        Me.lblNombreEnfernedadCronica.Text = "Enfermedad Crónica"
        Me.lblNombreEnfernedadCronica.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMedicamentosContraindicados
        '
        Me.lblMedicamentosContraindicados.Location = New System.Drawing.Point(56, 264)
        Me.lblMedicamentosContraindicados.Name = "lblMedicamentosContraindicados"
        Me.lblMedicamentosContraindicados.Size = New System.Drawing.Size(181, 16)
        Me.lblMedicamentosContraindicados.TabIndex = 21
        Me.lblMedicamentosContraindicados.Text = "Medicamentos Contraindicados"
        Me.lblMedicamentosContraindicados.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFonoNombreContacto
        '
        Me.lblFonoNombreContacto.Location = New System.Drawing.Point(24, 80)
        Me.lblFonoNombreContacto.Name = "lblFonoNombreContacto"
        Me.lblFonoNombreContacto.Size = New System.Drawing.Size(213, 16)
        Me.lblFonoNombreContacto.TabIndex = 9
        Me.lblFonoNombreContacto.Text = "Nombre y Fono Contacto Emergencia"
        Me.lblFonoNombreContacto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFonoOficina
        '
        Me.lblFonoOficina.Location = New System.Drawing.Point(112, 56)
        Me.lblFonoOficina.Name = "lblFonoOficina"
        Me.lblFonoOficina.Size = New System.Drawing.Size(125, 16)
        Me.lblFonoOficina.TabIndex = 23
        Me.lblFonoOficina.Text = "Fono y Anexo Oficina"
        Me.lblFonoOficina.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'xtpDatosLaborales
        '
        Me.xtpDatosLaborales.Controls.Add(Me.lblNombreDatosLaborales)
        Me.xtpDatosLaborales.Controls.Add(Me.lblMensajeLaboral)
        Me.xtpDatosLaborales.Controls.Add(Me.gpcSeguridad)
        Me.xtpDatosLaborales.Controls.Add(Me.gpcComandosDatosLaborales)
        Me.xtpDatosLaborales.Controls.Add(Me.gpcAntecedenteWeb)
        Me.xtpDatosLaborales.Controls.Add(Me.gpcDatosContractuales)
        Me.xtpDatosLaborales.Controls.Add(Me.gpcDatosRetiroEmpleado)
        Me.xtpDatosLaborales.Controls.Add(Me.gpcDatosResolucion)
        Me.xtpDatosLaborales.Controls.Add(Me.gpcInformacionContractualGeneral)
        Me.xtpDatosLaborales.Name = "xtpDatosLaborales"
        Me.xtpDatosLaborales.Size = New System.Drawing.Size(1001, 648)
        Me.xtpDatosLaborales.Text = "Datos Laborales"
        '
        'lblNombreDatosLaborales
        '
        Me.lblNombreDatosLaborales.AutoSize = True
        Me.lblNombreDatosLaborales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDatosLaborales.Location = New System.Drawing.Point(10, 10)
        Me.lblNombreDatosLaborales.Name = "lblNombreDatosLaborales"
        Me.lblNombreDatosLaborales.Size = New System.Drawing.Size(90, 15)
        Me.lblNombreDatosLaborales.TabIndex = 93
        Me.lblNombreDatosLaborales.Text = "EMPLEADO: "
        '
        'lblMensajeLaboral
        '
        Me.lblMensajeLaboral.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMensajeLaboral.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblMensajeLaboral.Appearance.Options.UseFont = True
        Me.lblMensajeLaboral.Appearance.Options.UseForeColor = True
        Me.lblMensajeLaboral.Location = New System.Drawing.Point(747, 31)
        Me.lblMensajeLaboral.Name = "lblMensajeLaboral"
        Me.lblMensajeLaboral.Size = New System.Drawing.Size(78, 13)
        Me.lblMensajeLaboral.TabIndex = 92
        Me.lblMensajeLaboral.Text = "LabelControl1"
        '
        'gpcSeguridad
        '
        Me.gpcSeguridad.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeguridad.AppearanceCaption.Options.UseFont = True
        Me.gpcSeguridad.Controls.Add(Me.lblNumeroAcceso)
        Me.gpcSeguridad.Controls.Add(Me.txtNumeroAcceso)
        Me.gpcSeguridad.Location = New System.Drawing.Point(549, 477)
        Me.gpcSeguridad.Name = "gpcSeguridad"
        Me.gpcSeguridad.Size = New System.Drawing.Size(192, 108)
        Me.gpcSeguridad.TabIndex = 91
        Me.gpcSeguridad.Text = "Seguridad"
        '
        'lblNumeroAcceso
        '
        Me.lblNumeroAcceso.Location = New System.Drawing.Point(30, 56)
        Me.lblNumeroAcceso.Name = "lblNumeroAcceso"
        Me.lblNumeroAcceso.Size = New System.Drawing.Size(49, 13)
        Me.lblNumeroAcceso.TabIndex = 91
        Me.lblNumeroAcceso.Text = "Nº Acceso"
        '
        'txtNumeroAcceso
        '
        Me.txtNumeroAcceso.Location = New System.Drawing.Point(24, 78)
        Me.txtNumeroAcceso.Name = "txtNumeroAcceso"
        Me.txtNumeroAcceso.Properties.Mask.EditMask = "n0"
        Me.txtNumeroAcceso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumeroAcceso.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNumeroAcceso.Properties.MaxLength = 2
        Me.txtNumeroAcceso.Size = New System.Drawing.Size(150, 20)
        Me.txtNumeroAcceso.TabIndex = 90
        '
        'gpcComandosDatosLaborales
        '
        Me.gpcComandosDatosLaborales.Controls.Add(Me.btnGuardarDatosLaborales)
        Me.gpcComandosDatosLaborales.Location = New System.Drawing.Point(17, 587)
        Me.gpcComandosDatosLaborales.Name = "gpcComandosDatosLaborales"
        Me.gpcComandosDatosLaborales.ShowCaption = False
        Me.gpcComandosDatosLaborales.Size = New System.Drawing.Size(724, 40)
        Me.gpcComandosDatosLaborales.TabIndex = 90
        Me.gpcComandosDatosLaborales.Text = "GroupControl1"
        '
        'btnGuardarDatosLaborales
        '
        Me.btnGuardarDatosLaborales.Location = New System.Drawing.Point(302, 6)
        Me.btnGuardarDatosLaborales.Name = "btnGuardarDatosLaborales"
        Me.btnGuardarDatosLaborales.Size = New System.Drawing.Size(112, 23)
        Me.btnGuardarDatosLaborales.TabIndex = 89
        Me.btnGuardarDatosLaborales.Text = "&Guardar"
        '
        'gpcAntecedenteWeb
        '
        Me.gpcAntecedenteWeb.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcAntecedenteWeb.AppearanceCaption.Options.UseFont = True
        Me.gpcAntecedenteWeb.Controls.Add(Me.txtTituloProfesionalExpertiz)
        Me.gpcAntecedenteWeb.Controls.Add(Me.lblTituloProfesionalExpertiz)
        Me.gpcAntecedenteWeb.Controls.Add(Me.txtFuncionDesempeno)
        Me.gpcAntecedenteWeb.Controls.Add(Me.chkPublicaDatos)
        Me.gpcAntecedenteWeb.Controls.Add(Me.lblFuncionDesempeño)
        Me.gpcAntecedenteWeb.Location = New System.Drawing.Point(17, 477)
        Me.gpcAntecedenteWeb.Name = "gpcAntecedenteWeb"
        Me.gpcAntecedenteWeb.Size = New System.Drawing.Size(528, 108)
        Me.gpcAntecedenteWeb.TabIndex = 86
        Me.gpcAntecedenteWeb.Text = "Información Web Gubernamental"
        '
        'txtTituloProfesionalExpertiz
        '
        Me.txtTituloProfesionalExpertiz.Location = New System.Drawing.Point(162, 80)
        Me.txtTituloProfesionalExpertiz.Name = "txtTituloProfesionalExpertiz"
        Me.txtTituloProfesionalExpertiz.Size = New System.Drawing.Size(350, 20)
        Me.txtTituloProfesionalExpertiz.TabIndex = 86
        '
        'lblTituloProfesionalExpertiz
        '
        Me.lblTituloProfesionalExpertiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloProfesionalExpertiz.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTituloProfesionalExpertiz.Location = New System.Drawing.Point(6, 84)
        Me.lblTituloProfesionalExpertiz.Name = "lblTituloProfesionalExpertiz"
        Me.lblTituloProfesionalExpertiz.Size = New System.Drawing.Size(152, 16)
        Me.lblTituloProfesionalExpertiz.TabIndex = 88
        Me.lblTituloProfesionalExpertiz.Text = "Título Profesional/Expertiz"
        Me.lblTituloProfesionalExpertiz.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtFuncionDesempeno
        '
        Me.txtFuncionDesempeno.Location = New System.Drawing.Point(162, 54)
        Me.txtFuncionDesempeno.Name = "txtFuncionDesempeno"
        Me.txtFuncionDesempeno.Size = New System.Drawing.Size(350, 20)
        Me.txtFuncionDesempeno.TabIndex = 85
        '
        'chkPublicaDatos
        '
        Me.chkPublicaDatos.Location = New System.Drawing.Point(164, 28)
        Me.chkPublicaDatos.Name = "chkPublicaDatos"
        Me.chkPublicaDatos.Properties.Caption = "Pubica datos en la web"
        Me.chkPublicaDatos.Size = New System.Drawing.Size(144, 19)
        Me.chkPublicaDatos.TabIndex = 84
        '
        'lblFuncionDesempeño
        '
        Me.lblFuncionDesempeño.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuncionDesempeño.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFuncionDesempeño.Location = New System.Drawing.Point(24, 56)
        Me.lblFuncionDesempeño.Name = "lblFuncionDesempeño"
        Me.lblFuncionDesempeño.Size = New System.Drawing.Size(132, 16)
        Me.lblFuncionDesempeño.TabIndex = 85
        Me.lblFuncionDesempeño.Text = "Función o Desempeño"
        Me.lblFuncionDesempeño.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gpcDatosContractuales
        '
        Me.gpcDatosContractuales.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDatosContractuales.AppearanceCaption.Options.UseFont = True
        Me.gpcDatosContractuales.Controls.Add(Me.Label1)
        Me.gpcDatosContractuales.Controls.Add(Me.dedFechaIngresoCalidadJuridica)
        Me.gpcDatosContractuales.Controls.Add(Me.lueCalJur)
        Me.gpcDatosContractuales.Controls.Add(Me.txtFechaAsignacionGrado)
        Me.gpcDatosContractuales.Controls.Add(Me.lblFechaAsignacionGrado)
        Me.gpcDatosContractuales.Controls.Add(Me.cbbEscalafon)
        Me.gpcDatosContractuales.Controls.Add(Me.cbbGrado)
        Me.gpcDatosContractuales.Controls.Add(Me.cbbClasificacionEmpleado)
        Me.gpcDatosContractuales.Controls.Add(Me.lblCalidadJuridica)
        Me.gpcDatosContractuales.Controls.Add(Me.lblfechaIngInstittucion)
        Me.gpcDatosContractuales.Controls.Add(Me.lblEscalafon)
        Me.gpcDatosContractuales.Controls.Add(Me.lblGrado)
        Me.gpcDatosContractuales.Controls.Add(Me.lblFechaIngAdmPublica)
        Me.gpcDatosContractuales.Controls.Add(Me.lblClasifiaccionEmpleado)
        Me.gpcDatosContractuales.Controls.Add(Me.dedFechaIngInstitucion)
        Me.gpcDatosContractuales.Controls.Add(Me.dedFechaIngAdmPublica)
        Me.gpcDatosContractuales.Location = New System.Drawing.Point(13, 31)
        Me.gpcDatosContractuales.Name = "gpcDatosContractuales"
        Me.gpcDatosContractuales.Size = New System.Drawing.Size(392, 220)
        Me.gpcDatosContractuales.TabIndex = 81
        Me.gpcDatosContractuales.Text = "Datos Contractuales"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 16)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Fecha Ing.Cal.Jurídica"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dedFechaIngresoCalidadJuridica
        '
        Me.dedFechaIngresoCalidadJuridica.EditValue = Nothing
        Me.dedFechaIngresoCalidadJuridica.Enabled = False
        Me.dedFechaIngresoCalidadJuridica.Location = New System.Drawing.Point(164, 192)
        Me.dedFechaIngresoCalidadJuridica.Name = "dedFechaIngresoCalidadJuridica"
        Me.dedFechaIngresoCalidadJuridica.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, False)})
        Me.dedFechaIngresoCalidadJuridica.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaIngresoCalidadJuridica.Size = New System.Drawing.Size(206, 20)
        Me.dedFechaIngresoCalidadJuridica.TabIndex = 84
        '
        'lueCalJur
        '
        Me.lueCalJur.Location = New System.Drawing.Point(164, 26)
        Me.lueCalJur.Name = "lueCalJur"
        Me.lueCalJur.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCalJur.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.lueCalJur.Size = New System.Drawing.Size(206, 20)
        Me.lueCalJur.TabIndex = 83
        '
        'txtFechaAsignacionGrado
        '
        Me.txtFechaAsignacionGrado.Enabled = False
        Me.txtFechaAsignacionGrado.Location = New System.Drawing.Point(164, 96)
        Me.txtFechaAsignacionGrado.Name = "txtFechaAsignacionGrado"
        Me.txtFechaAsignacionGrado.Properties.ReadOnly = True
        Me.txtFechaAsignacionGrado.Size = New System.Drawing.Size(206, 20)
        Me.txtFechaAsignacionGrado.TabIndex = 82
        '
        'lblFechaAsignacionGrado
        '
        Me.lblFechaAsignacionGrado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFechaAsignacionGrado.Location = New System.Drawing.Point(6, 100)
        Me.lblFechaAsignacionGrado.Name = "lblFechaAsignacionGrado"
        Me.lblFechaAsignacionGrado.Size = New System.Drawing.Size(150, 16)
        Me.lblFechaAsignacionGrado.TabIndex = 81
        Me.lblFechaAsignacionGrado.Text = "Fecha asignación grado"
        Me.lblFechaAsignacionGrado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbbEscalafon
        '
        Me.cbbEscalafon.Location = New System.Drawing.Point(164, 120)
        Me.cbbEscalafon.Name = "cbbEscalafon"
        Me.cbbEscalafon.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbEscalafon.Size = New System.Drawing.Size(206, 20)
        Me.cbbEscalafon.TabIndex = 80
        '
        'cbbGrado
        '
        Me.cbbGrado.Location = New System.Drawing.Point(164, 72)
        Me.cbbGrado.Name = "cbbGrado"
        Me.cbbGrado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbGrado.Size = New System.Drawing.Size(206, 20)
        Me.cbbGrado.TabIndex = 79
        '
        'cbbClasificacionEmpleado
        '
        Me.cbbClasificacionEmpleado.Location = New System.Drawing.Point(164, 48)
        Me.cbbClasificacionEmpleado.Name = "cbbClasificacionEmpleado"
        Me.cbbClasificacionEmpleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbClasificacionEmpleado.Size = New System.Drawing.Size(206, 20)
        Me.cbbClasificacionEmpleado.TabIndex = 77
        '
        'lblCalidadJuridica
        '
        Me.lblCalidadJuridica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalidadJuridica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCalidadJuridica.Location = New System.Drawing.Point(48, 28)
        Me.lblCalidadJuridica.Name = "lblCalidadJuridica"
        Me.lblCalidadJuridica.Size = New System.Drawing.Size(108, 16)
        Me.lblCalidadJuridica.TabIndex = 56
        Me.lblCalidadJuridica.Text = "Calidad Jurídica"
        Me.lblCalidadJuridica.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblfechaIngInstittucion
        '
        Me.lblfechaIngInstittucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechaIngInstittucion.Location = New System.Drawing.Point(18, 172)
        Me.lblfechaIngInstittucion.Name = "lblfechaIngInstittucion"
        Me.lblfechaIngInstittucion.Size = New System.Drawing.Size(140, 16)
        Me.lblfechaIngInstittucion.TabIndex = 61
        Me.lblfechaIngInstittucion.Text = "Fecha Ing.Presidencia"
        Me.lblfechaIngInstittucion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEscalafon
        '
        Me.lblEscalafon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEscalafon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblEscalafon.Location = New System.Drawing.Point(84, 124)
        Me.lblEscalafon.Name = "lblEscalafon"
        Me.lblEscalafon.Size = New System.Drawing.Size(72, 16)
        Me.lblEscalafon.TabIndex = 62
        Me.lblEscalafon.Text = "Escalafón"
        Me.lblEscalafon.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblGrado
        '
        Me.lblGrado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblGrado.Location = New System.Drawing.Point(86, 76)
        Me.lblGrado.Name = "lblGrado"
        Me.lblGrado.Size = New System.Drawing.Size(70, 16)
        Me.lblGrado.TabIndex = 58
        Me.lblGrado.Text = "Grado"
        Me.lblGrado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFechaIngAdmPublica
        '
        Me.lblFechaIngAdmPublica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngAdmPublica.Location = New System.Drawing.Point(10, 148)
        Me.lblFechaIngAdmPublica.Name = "lblFechaIngAdmPublica"
        Me.lblFechaIngAdmPublica.Size = New System.Drawing.Size(148, 16)
        Me.lblFechaIngAdmPublica.TabIndex = 60
        Me.lblFechaIngAdmPublica.Text = "Fecha Ing. Adm.Pública"
        Me.lblFechaIngAdmPublica.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblClasifiaccionEmpleado
        '
        Me.lblClasifiaccionEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClasifiaccionEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblClasifiaccionEmpleado.Location = New System.Drawing.Point(22, 52)
        Me.lblClasifiaccionEmpleado.Name = "lblClasifiaccionEmpleado"
        Me.lblClasifiaccionEmpleado.Size = New System.Drawing.Size(134, 16)
        Me.lblClasifiaccionEmpleado.TabIndex = 57
        Me.lblClasifiaccionEmpleado.Text = "Clasificación Empleado"
        Me.lblClasifiaccionEmpleado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dedFechaIngInstitucion
        '
        Me.dedFechaIngInstitucion.EditValue = Nothing
        Me.dedFechaIngInstitucion.Location = New System.Drawing.Point(164, 168)
        Me.dedFechaIngInstitucion.Name = "dedFechaIngInstitucion"
        Me.dedFechaIngInstitucion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaIngInstitucion.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaIngInstitucion.Size = New System.Drawing.Size(206, 20)
        Me.dedFechaIngInstitucion.TabIndex = 75
        '
        'dedFechaIngAdmPublica
        '
        Me.dedFechaIngAdmPublica.EditValue = Nothing
        Me.dedFechaIngAdmPublica.Location = New System.Drawing.Point(164, 144)
        Me.dedFechaIngAdmPublica.Name = "dedFechaIngAdmPublica"
        Me.dedFechaIngAdmPublica.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaIngAdmPublica.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaIngAdmPublica.Size = New System.Drawing.Size(206, 20)
        Me.dedFechaIngAdmPublica.TabIndex = 74
        '
        'gpcDatosRetiroEmpleado
        '
        Me.gpcDatosRetiroEmpleado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDatosRetiroEmpleado.AppearanceCaption.Options.UseFont = True
        Me.gpcDatosRetiroEmpleado.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.gpcDatosRetiroEmpleado.Controls.Add(Me.txtResolucionRetiro)
        Me.gpcDatosRetiroEmpleado.Controls.Add(Me.lblResolucionRetiro)
        Me.gpcDatosRetiroEmpleado.Controls.Add(Me.cbbMotivoRetiro)
        Me.gpcDatosRetiroEmpleado.Controls.Add(Me.dedFechaRetiro)
        Me.gpcDatosRetiroEmpleado.Controls.Add(Me.lblMotivoRetiro)
        Me.gpcDatosRetiroEmpleado.Controls.Add(Me.lblFechaRetiro)
        Me.gpcDatosRetiroEmpleado.Location = New System.Drawing.Point(421, 31)
        Me.gpcDatosRetiroEmpleado.Name = "gpcDatosRetiroEmpleado"
        Me.gpcDatosRetiroEmpleado.Size = New System.Drawing.Size(320, 102)
        Me.gpcDatosRetiroEmpleado.TabIndex = 79
        Me.gpcDatosRetiroEmpleado.Text = "Datos Retiro Empleado"
        '
        'txtResolucionRetiro
        '
        Me.txtResolucionRetiro.Location = New System.Drawing.Point(154, 74)
        Me.txtResolucionRetiro.Name = "txtResolucionRetiro"
        Me.txtResolucionRetiro.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtResolucionRetiro.Properties.Mask.EditMask = "n0"
        Me.txtResolucionRetiro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtResolucionRetiro.Size = New System.Drawing.Size(148, 20)
        Me.txtResolucionRetiro.TabIndex = 87
        '
        'lblResolucionRetiro
        '
        Me.lblResolucionRetiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResolucionRetiro.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblResolucionRetiro.Location = New System.Drawing.Point(10, 76)
        Me.lblResolucionRetiro.Name = "lblResolucionRetiro"
        Me.lblResolucionRetiro.Size = New System.Drawing.Size(138, 16)
        Me.lblResolucionRetiro.TabIndex = 81
        Me.lblResolucionRetiro.Text = "Nro.Resolución Retiro"
        '
        'cbbMotivoRetiro
        '
        Me.cbbMotivoRetiro.Location = New System.Drawing.Point(98, 28)
        Me.cbbMotivoRetiro.Name = "cbbMotivoRetiro"
        Me.cbbMotivoRetiro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbMotivoRetiro.Size = New System.Drawing.Size(206, 20)
        Me.cbbMotivoRetiro.TabIndex = 85
        '
        'dedFechaRetiro
        '
        Me.dedFechaRetiro.EditValue = Nothing
        Me.dedFechaRetiro.Location = New System.Drawing.Point(98, 52)
        Me.dedFechaRetiro.Name = "dedFechaRetiro"
        Me.dedFechaRetiro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaRetiro.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaRetiro.Size = New System.Drawing.Size(206, 20)
        Me.dedFechaRetiro.TabIndex = 86
        '
        'lblMotivoRetiro
        '
        Me.lblMotivoRetiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivoRetiro.Location = New System.Drawing.Point(10, 30)
        Me.lblMotivoRetiro.Name = "lblMotivoRetiro"
        Me.lblMotivoRetiro.Size = New System.Drawing.Size(80, 16)
        Me.lblMotivoRetiro.TabIndex = 65
        Me.lblMotivoRetiro.Text = "Motivo Retiro"
        '
        'lblFechaRetiro
        '
        Me.lblFechaRetiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaRetiro.Location = New System.Drawing.Point(10, 54)
        Me.lblFechaRetiro.Name = "lblFechaRetiro"
        Me.lblFechaRetiro.Size = New System.Drawing.Size(80, 16)
        Me.lblFechaRetiro.TabIndex = 64
        Me.lblFechaRetiro.Text = "Fecha Retiro"
        '
        'gpcDatosResolucion
        '
        Me.gpcDatosResolucion.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcDatosResolucion.Appearance.Options.UseFont = True
        Me.gpcDatosResolucion.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDatosResolucion.AppearanceCaption.Options.UseFont = True
        Me.gpcDatosResolucion.Controls.Add(Me.txtNroResolucionContrato)
        Me.gpcDatosResolucion.Controls.Add(Me.dedFechaResolucion)
        Me.gpcDatosResolucion.Controls.Add(Me.lblFechaResolucion)
        Me.gpcDatosResolucion.Controls.Add(Me.lblResolucionContrato)
        Me.gpcDatosResolucion.Location = New System.Drawing.Point(421, 137)
        Me.gpcDatosResolucion.Name = "gpcDatosResolucion"
        Me.gpcDatosResolucion.Size = New System.Drawing.Size(320, 114)
        Me.gpcDatosResolucion.TabIndex = 81
        Me.gpcDatosResolucion.Text = "Datos Resolución Ingreso"
        '
        'txtNroResolucionContrato
        '
        Me.txtNroResolucionContrato.Location = New System.Drawing.Point(156, 32)
        Me.txtNroResolucionContrato.Name = "txtNroResolucionContrato"
        Me.txtNroResolucionContrato.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNroResolucionContrato.Properties.Mask.EditMask = "n0"
        Me.txtNroResolucionContrato.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNroResolucionContrato.Properties.ReadOnly = True
        Me.txtNroResolucionContrato.Size = New System.Drawing.Size(148, 20)
        Me.txtNroResolucionContrato.TabIndex = 88
        '
        'dedFechaResolucion
        '
        Me.dedFechaResolucion.EditValue = Nothing
        Me.dedFechaResolucion.Location = New System.Drawing.Point(156, 56)
        Me.dedFechaResolucion.Name = "dedFechaResolucion"
        Me.dedFechaResolucion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaResolucion.Properties.ReadOnly = True
        Me.dedFechaResolucion.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaResolucion.Size = New System.Drawing.Size(148, 20)
        Me.dedFechaResolucion.TabIndex = 89
        '
        'lblFechaResolucion
        '
        Me.lblFechaResolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaResolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFechaResolucion.Location = New System.Drawing.Point(29, 60)
        Me.lblFechaResolucion.Name = "lblFechaResolucion"
        Me.lblFechaResolucion.Size = New System.Drawing.Size(117, 16)
        Me.lblFechaResolucion.TabIndex = 63
        Me.lblFechaResolucion.Text = "Fecha Resolución"
        Me.lblFechaResolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblResolucionContrato
        '
        Me.lblResolucionContrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResolucionContrato.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblResolucionContrato.Location = New System.Drawing.Point(4, 34)
        Me.lblResolucionContrato.Name = "lblResolucionContrato"
        Me.lblResolucionContrato.Size = New System.Drawing.Size(144, 16)
        Me.lblResolucionContrato.TabIndex = 59
        Me.lblResolucionContrato.Text = "Nro.Resolución Contrato"
        Me.lblResolucionContrato.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gpcInformacionContractualGeneral
        '
        Me.gpcInformacionContractualGeneral.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcInformacionContractualGeneral.AppearanceCaption.Options.UseFont = True
        Me.gpcInformacionContractualGeneral.Controls.Add(Me.chkIncluirParaEvaluacionDesempeño)
        Me.gpcInformacionContractualGeneral.Controls.Add(Me.cbbJefeEvalDesempeno)
        Me.gpcInformacionContractualGeneral.Controls.Add(Me.Label2)
        Me.gpcInformacionContractualGeneral.Controls.Add(Me.lueTipoBeneficiario)
        Me.gpcInformacionContractualGeneral.Controls.Add(Me.lblTipoBeneficiario)
        Me.gpcInformacionContractualGeneral.Controls.Add(Me.cbbEstamento)
        Me.gpcInformacionContractualGeneral.Controls.Add(Me.lblEstamento)
        Me.gpcInformacionContractualGeneral.Controls.Add(Me.cbbHorarioTrabajo)
        Me.gpcInformacionContractualGeneral.Controls.Add(Me.cbbUbicacionFisica)
        Me.gpcInformacionContractualGeneral.Controls.Add(Me.cbbJefeDirecto)
        Me.gpcInformacionContractualGeneral.Controls.Add(Me.lblJefeDirecto)
        Me.gpcInformacionContractualGeneral.Controls.Add(Me.lblUbicacionFisica)
        Me.gpcInformacionContractualGeneral.Controls.Add(Me.lblHorarioTrabajo)
        Me.gpcInformacionContractualGeneral.Controls.Add(Me.lblCargo)
        Me.gpcInformacionContractualGeneral.Controls.Add(Me.txtCargo)
        Me.gpcInformacionContractualGeneral.Location = New System.Drawing.Point(15, 255)
        Me.gpcInformacionContractualGeneral.Name = "gpcInformacionContractualGeneral"
        Me.gpcInformacionContractualGeneral.Size = New System.Drawing.Size(726, 216)
        Me.gpcInformacionContractualGeneral.TabIndex = 82
        Me.gpcInformacionContractualGeneral.Text = "Información Contractual General"
        '
        'chkIncluirParaEvaluacionDesempeño
        '
        Me.chkIncluirParaEvaluacionDesempeño.Location = New System.Drawing.Point(166, 194)
        Me.chkIncluirParaEvaluacionDesempeño.Name = "chkIncluirParaEvaluacionDesempeño"
        Me.chkIncluirParaEvaluacionDesempeño.Properties.Caption = "Incluir en Evaluación Desempeño"
        Me.chkIncluirParaEvaluacionDesempeño.Size = New System.Drawing.Size(188, 19)
        Me.chkIncluirParaEvaluacionDesempeño.TabIndex = 83
        '
        'cbbJefeEvalDesempeno
        '
        Me.cbbJefeEvalDesempeno.Location = New System.Drawing.Point(162, 72)
        Me.cbbJefeEvalDesempeno.Name = "cbbJefeEvalDesempeno"
        Me.cbbJefeEvalDesempeno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbJefeEvalDesempeno.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("(None)", "(None)")})
        Me.cbbJefeEvalDesempeno.Size = New System.Drawing.Size(454, 20)
        Me.cbbJefeEvalDesempeno.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Label2.Location = New System.Drawing.Point(28, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 16)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Jefe Eval.Desempeño"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lueTipoBeneficiario
        '
        Me.lueTipoBeneficiario.Location = New System.Drawing.Point(162, 168)
        Me.lueTipoBeneficiario.Name = "lueTipoBeneficiario"
        Me.lueTipoBeneficiario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTipoBeneficiario.Size = New System.Drawing.Size(454, 20)
        Me.lueTipoBeneficiario.TabIndex = 82
        '
        'lblTipoBeneficiario
        '
        Me.lblTipoBeneficiario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTipoBeneficiario.Location = New System.Drawing.Point(56, 170)
        Me.lblTipoBeneficiario.Name = "lblTipoBeneficiario"
        Me.lblTipoBeneficiario.Size = New System.Drawing.Size(100, 16)
        Me.lblTipoBeneficiario.TabIndex = 86
        Me.lblTipoBeneficiario.Text = "Tipo Beneficiario"
        Me.lblTipoBeneficiario.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbbEstamento
        '
        Me.cbbEstamento.Location = New System.Drawing.Point(162, 96)
        Me.cbbEstamento.Name = "cbbEstamento"
        Me.cbbEstamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbEstamento.Size = New System.Drawing.Size(454, 20)
        Me.cbbEstamento.TabIndex = 79
        '
        'lblEstamento
        '
        Me.lblEstamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstamento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblEstamento.Location = New System.Drawing.Point(78, 98)
        Me.lblEstamento.Name = "lblEstamento"
        Me.lblEstamento.Size = New System.Drawing.Size(76, 16)
        Me.lblEstamento.TabIndex = 84
        Me.lblEstamento.Text = "Estamento"
        Me.lblEstamento.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbbHorarioTrabajo
        '
        Me.cbbHorarioTrabajo.Location = New System.Drawing.Point(162, 144)
        Me.cbbHorarioTrabajo.Name = "cbbHorarioTrabajo"
        Me.cbbHorarioTrabajo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbHorarioTrabajo.Size = New System.Drawing.Size(454, 20)
        Me.cbbHorarioTrabajo.TabIndex = 81
        '
        'cbbUbicacionFisica
        '
        Me.cbbUbicacionFisica.Location = New System.Drawing.Point(162, 120)
        Me.cbbUbicacionFisica.Name = "cbbUbicacionFisica"
        Me.cbbUbicacionFisica.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbUbicacionFisica.Size = New System.Drawing.Size(454, 20)
        Me.cbbUbicacionFisica.TabIndex = 80
        '
        'cbbJefeDirecto
        '
        Me.cbbJefeDirecto.Location = New System.Drawing.Point(162, 48)
        Me.cbbJefeDirecto.Name = "cbbJefeDirecto"
        Me.cbbJefeDirecto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbJefeDirecto.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("(None)", "(None)")})
        Me.cbbJefeDirecto.Size = New System.Drawing.Size(454, 20)
        Me.cbbJefeDirecto.TabIndex = 77
        '
        'lblJefeDirecto
        '
        Me.lblJefeDirecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJefeDirecto.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblJefeDirecto.Location = New System.Drawing.Point(56, 50)
        Me.lblJefeDirecto.Name = "lblJefeDirecto"
        Me.lblJefeDirecto.Size = New System.Drawing.Size(100, 16)
        Me.lblJefeDirecto.TabIndex = 77
        Me.lblJefeDirecto.Text = "Jefe Directo"
        Me.lblJefeDirecto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblUbicacionFisica
        '
        Me.lblUbicacionFisica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUbicacionFisica.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblUbicacionFisica.Location = New System.Drawing.Point(56, 122)
        Me.lblUbicacionFisica.Name = "lblUbicacionFisica"
        Me.lblUbicacionFisica.Size = New System.Drawing.Size(100, 16)
        Me.lblUbicacionFisica.TabIndex = 76
        Me.lblUbicacionFisica.Text = "Ubicación Física"
        '
        'lblHorarioTrabajo
        '
        Me.lblHorarioTrabajo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblHorarioTrabajo.Location = New System.Drawing.Point(56, 146)
        Me.lblHorarioTrabajo.Name = "lblHorarioTrabajo"
        Me.lblHorarioTrabajo.Size = New System.Drawing.Size(100, 16)
        Me.lblHorarioTrabajo.TabIndex = 78
        Me.lblHorarioTrabajo.Text = "Horario Trabajo"
        Me.lblHorarioTrabajo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCargo
        '
        Me.lblCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCargo.Location = New System.Drawing.Point(58, 26)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(100, 16)
        Me.lblCargo.TabIndex = 87
        Me.lblCargo.Text = "Cargo"
        Me.lblCargo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(162, 24)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCargo.Properties.MaxLength = 50
        Me.txtCargo.Size = New System.Drawing.Size(454, 20)
        Me.txtCargo.TabIndex = 76
        '
        'xtpEstructuraOrganizacional
        '
        Me.xtpEstructuraOrganizacional.Controls.Add(Me.lblNombreEstructuraOrganizacional)
        Me.xtpEstructuraOrganizacional.Controls.Add(Me.lblMensajeEstruOrgannica)
        Me.xtpEstructuraOrganizacional.Controls.Add(Me.gdcEstructuraContable)
        Me.xtpEstructuraOrganizacional.Controls.Add(Me.gcOrganigrama)
        Me.xtpEstructuraOrganizacional.Controls.Add(Me.gcCentrosCostos)
        Me.xtpEstructuraOrganizacional.Name = "xtpEstructuraOrganizacional"
        Me.xtpEstructuraOrganizacional.Size = New System.Drawing.Size(1001, 648)
        Me.xtpEstructuraOrganizacional.Text = "Estructura Organizacional"
        '
        'lblNombreEstructuraOrganizacional
        '
        Me.lblNombreEstructuraOrganizacional.AutoSize = True
        Me.lblNombreEstructuraOrganizacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEstructuraOrganizacional.Location = New System.Drawing.Point(10, 10)
        Me.lblNombreEstructuraOrganizacional.Name = "lblNombreEstructuraOrganizacional"
        Me.lblNombreEstructuraOrganizacional.Size = New System.Drawing.Size(90, 15)
        Me.lblNombreEstructuraOrganizacional.TabIndex = 50
        Me.lblNombreEstructuraOrganizacional.Text = "EMPLEADO: "
        '
        'lblMensajeEstruOrgannica
        '
        Me.lblMensajeEstruOrgannica.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMensajeEstruOrgannica.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblMensajeEstruOrgannica.Appearance.Options.UseFont = True
        Me.lblMensajeEstruOrgannica.Appearance.Options.UseForeColor = True
        Me.lblMensajeEstruOrgannica.Location = New System.Drawing.Point(754, 31)
        Me.lblMensajeEstruOrgannica.Name = "lblMensajeEstruOrgannica"
        Me.lblMensajeEstruOrgannica.Size = New System.Drawing.Size(78, 13)
        Me.lblMensajeEstruOrgannica.TabIndex = 49
        Me.lblMensajeEstruOrgannica.Text = "LabelControl1"
        '
        'gdcEstructuraContable
        '
        Me.gdcEstructuraContable.Location = New System.Drawing.Point(13, 455)
        Me.gdcEstructuraContable.MainView = Me.gdvDetalleEstructuraContable
        Me.gdcEstructuraContable.Name = "gdcEstructuraContable"
        Me.gdcEstructuraContable.Size = New System.Drawing.Size(704, 88)
        Me.gdcEstructuraContable.TabIndex = 2
        Me.gdcEstructuraContable.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleEstructuraContable, Me.GridView2})
        '
        'gdvDetalleEstructuraContable
        '
        Me.gdvDetalleEstructuraContable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ESTRUCTURA_CONTABLE_ID, Me.ESTADO_REGISTRO_CONTAB, Me.DESC_CENTRO_COSTO_CONTABLE, Me.DESC_CENTRO_COSTO_PRESUP, Me.PORCENTAJE_DISTRIB, Me.DESC_PERIODO_CONTABLE})
        Me.gdvDetalleEstructuraContable.GridControl = Me.gdcEstructuraContable
        Me.gdvDetalleEstructuraContable.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas"
        Me.gdvDetalleEstructuraContable.Name = "gdvDetalleEstructuraContable"
        Me.gdvDetalleEstructuraContable.OptionsView.ShowGroupPanel = False
        '
        'ESTRUCTURA_CONTABLE_ID
        '
        Me.ESTRUCTURA_CONTABLE_ID.Caption = "ID Estructura Contab."
        Me.ESTRUCTURA_CONTABLE_ID.FieldName = "ESTRUCTURA_CONTABLE_ID"
        Me.ESTRUCTURA_CONTABLE_ID.Name = "ESTRUCTURA_CONTABLE_ID"
        Me.ESTRUCTURA_CONTABLE_ID.OptionsColumn.ReadOnly = True
        '
        'ESTADO_REGISTRO_CONTAB
        '
        Me.ESTADO_REGISTRO_CONTAB.Caption = "Estado Registro"
        Me.ESTADO_REGISTRO_CONTAB.FieldName = "ESTADO_REGISTRO"
        Me.ESTADO_REGISTRO_CONTAB.Name = "ESTADO_REGISTRO_CONTAB"
        Me.ESTADO_REGISTRO_CONTAB.OptionsColumn.ReadOnly = True
        '
        'DESC_CENTRO_COSTO_CONTABLE
        '
        Me.DESC_CENTRO_COSTO_CONTABLE.Caption = "Centro Costo Contab."
        Me.DESC_CENTRO_COSTO_CONTABLE.FieldName = "DESC_CENTRO_COSTO_CONTABLE"
        Me.DESC_CENTRO_COSTO_CONTABLE.Name = "DESC_CENTRO_COSTO_CONTABLE"
        Me.DESC_CENTRO_COSTO_CONTABLE.OptionsColumn.ReadOnly = True
        Me.DESC_CENTRO_COSTO_CONTABLE.Visible = True
        Me.DESC_CENTRO_COSTO_CONTABLE.VisibleIndex = 0
        Me.DESC_CENTRO_COSTO_CONTABLE.Width = 350
        '
        'DESC_CENTRO_COSTO_PRESUP
        '
        Me.DESC_CENTRO_COSTO_PRESUP.Caption = "Centro Costo Presup."
        Me.DESC_CENTRO_COSTO_PRESUP.FieldName = "DESC_CENTRO_COSTO_PRESUP"
        Me.DESC_CENTRO_COSTO_PRESUP.Name = "DESC_CENTRO_COSTO_PRESUP"
        Me.DESC_CENTRO_COSTO_PRESUP.OptionsColumn.ReadOnly = True
        Me.DESC_CENTRO_COSTO_PRESUP.Visible = True
        Me.DESC_CENTRO_COSTO_PRESUP.VisibleIndex = 1
        Me.DESC_CENTRO_COSTO_PRESUP.Width = 307
        '
        'PORCENTAJE_DISTRIB
        '
        Me.PORCENTAJE_DISTRIB.Caption = "% Distribución"
        Me.PORCENTAJE_DISTRIB.FieldName = "PORCENTAJE_DISTRIB"
        Me.PORCENTAJE_DISTRIB.Name = "PORCENTAJE_DISTRIB"
        Me.PORCENTAJE_DISTRIB.OptionsColumn.ReadOnly = True
        Me.PORCENTAJE_DISTRIB.Visible = True
        Me.PORCENTAJE_DISTRIB.VisibleIndex = 2
        Me.PORCENTAJE_DISTRIB.Width = 175
        '
        'DESC_PERIODO_CONTABLE
        '
        Me.DESC_PERIODO_CONTABLE.Caption = "Período"
        Me.DESC_PERIODO_CONTABLE.FieldName = "DESC_PERIODO"
        Me.DESC_PERIODO_CONTABLE.Name = "DESC_PERIODO_CONTABLE"
        Me.DESC_PERIODO_CONTABLE.OptionsColumn.ReadOnly = True
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.gdcEstructuraContable
        Me.GridView2.Name = "GridView2"
        '
        'gcOrganigrama
        '
        Me.gcOrganigrama.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gcOrganigrama.AppearanceCaption.Options.UseFont = True
        Me.gcOrganigrama.Controls.Add(Me.lblSubDepto)
        Me.gcOrganigrama.Controls.Add(Me.lueSubDepto)
        Me.gcOrganigrama.Controls.Add(Me.lueAutorizadorHorasExtras)
        Me.gcOrganigrama.Controls.Add(Me.lueEvaluadorDesempeno)
        Me.gcOrganigrama.Controls.Add(Me.lblAutorizadorHorasExtras)
        Me.gcOrganigrama.Controls.Add(Me.lblEvaluadorDesempeño)
        Me.gcOrganigrama.Controls.Add(Me.btnEliminarEstrucOrg)
        Me.gcOrganigrama.Controls.Add(Me.btnGuardarEstrucOrg)
        Me.gcOrganigrama.Controls.Add(Me.btnCancelarEstrucOrg)
        Me.gcOrganigrama.Controls.Add(Me.gdcEstructuraOrganica)
        Me.gcOrganigrama.Controls.Add(Me.lueInstitucion)
        Me.gcOrganigrama.Controls.Add(Me.lueDepartamento)
        Me.gcOrganigrama.Controls.Add(Me.lueDireccion)
        Me.gcOrganigrama.Controls.Add(Me.lblDepartamento)
        Me.gcOrganigrama.Controls.Add(Me.lblDireccion)
        Me.gcOrganigrama.Controls.Add(Me.lblOrganizacion)
        Me.gcOrganigrama.Location = New System.Drawing.Point(13, 31)
        Me.gcOrganigrama.Name = "gcOrganigrama"
        Me.gcOrganigrama.Size = New System.Drawing.Size(735, 312)
        Me.gcOrganigrama.TabIndex = 0
        Me.gcOrganigrama.Text = "Estructura Orgánica"
        '
        'lblSubDepto
        '
        Me.lblSubDepto.Location = New System.Drawing.Point(32, 104)
        Me.lblSubDepto.Name = "lblSubDepto"
        Me.lblSubDepto.Size = New System.Drawing.Size(86, 13)
        Me.lblSubDepto.TabIndex = 18
        Me.lblSubDepto.Text = "Subdepartamento"
        '
        'lueSubDepto
        '
        Me.lueSubDepto.Location = New System.Drawing.Point(136, 96)
        Me.lueSubDepto.Name = "lueSubDepto"
        Me.lueSubDepto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueSubDepto.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueSubDepto.Size = New System.Drawing.Size(568, 20)
        Me.lueSubDepto.TabIndex = 6
        '
        'lueAutorizadorHorasExtras
        '
        Me.lueAutorizadorHorasExtras.Location = New System.Drawing.Point(136, 144)
        Me.lueAutorizadorHorasExtras.Name = "lueAutorizadorHorasExtras"
        Me.lueAutorizadorHorasExtras.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAutorizadorHorasExtras.Size = New System.Drawing.Size(568, 20)
        Me.lueAutorizadorHorasExtras.TabIndex = 8
        '
        'lueEvaluadorDesempeno
        '
        Me.lueEvaluadorDesempeno.Location = New System.Drawing.Point(136, 120)
        Me.lueEvaluadorDesempeno.Name = "lueEvaluadorDesempeno"
        Me.lueEvaluadorDesempeno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueEvaluadorDesempeno.Size = New System.Drawing.Size(568, 20)
        Me.lueEvaluadorDesempeno.TabIndex = 7
        '
        'lblAutorizadorHorasExtras
        '
        Me.lblAutorizadorHorasExtras.Location = New System.Drawing.Point(16, 152)
        Me.lblAutorizadorHorasExtras.Name = "lblAutorizadorHorasExtras"
        Me.lblAutorizadorHorasExtras.Size = New System.Drawing.Size(110, 13)
        Me.lblAutorizadorHorasExtras.TabIndex = 13
        Me.lblAutorizadorHorasExtras.Text = "Autorizador Hrs.Extras"
        '
        'lblEvaluadorDesempeño
        '
        Me.lblEvaluadorDesempeño.Location = New System.Drawing.Point(16, 128)
        Me.lblEvaluadorDesempeño.Name = "lblEvaluadorDesempeño"
        Me.lblEvaluadorDesempeño.Size = New System.Drawing.Size(107, 13)
        Me.lblEvaluadorDesempeño.TabIndex = 11
        Me.lblEvaluadorDesempeño.Text = "Evaluador Desempeño"
        '
        'btnEliminarEstrucOrg
        '
        Me.btnEliminarEstrucOrg.Location = New System.Drawing.Point(400, 176)
        Me.btnEliminarEstrucOrg.Name = "btnEliminarEstrucOrg"
        Me.btnEliminarEstrucOrg.Size = New System.Drawing.Size(112, 23)
        Me.btnEliminarEstrucOrg.TabIndex = 10
        Me.btnEliminarEstrucOrg.Text = "&Eliminar"
        '
        'btnGuardarEstrucOrg
        '
        Me.btnGuardarEstrucOrg.Location = New System.Drawing.Point(280, 176)
        Me.btnGuardarEstrucOrg.Name = "btnGuardarEstrucOrg"
        Me.btnGuardarEstrucOrg.Size = New System.Drawing.Size(112, 23)
        Me.btnGuardarEstrucOrg.TabIndex = 9
        Me.btnGuardarEstrucOrg.Text = "&Guardar"
        '
        'btnCancelarEstrucOrg
        '
        Me.btnCancelarEstrucOrg.Location = New System.Drawing.Point(160, 176)
        Me.btnCancelarEstrucOrg.Name = "btnCancelarEstrucOrg"
        Me.btnCancelarEstrucOrg.Size = New System.Drawing.Size(112, 23)
        Me.btnCancelarEstrucOrg.TabIndex = 8
        Me.btnCancelarEstrucOrg.Text = "&Cancelar"
        '
        'gdcEstructuraOrganica
        '
        Me.gdcEstructuraOrganica.Location = New System.Drawing.Point(8, 216)
        Me.gdcEstructuraOrganica.MainView = Me.gdvEstructuraOrganica
        Me.gdcEstructuraOrganica.Name = "gdcEstructuraOrganica"
        Me.gdcEstructuraOrganica.Size = New System.Drawing.Size(696, 88)
        Me.gdcEstructuraOrganica.TabIndex = 7
        Me.gdcEstructuraOrganica.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvEstructuraOrganica, Me.GridView1})
        '
        'gdvEstructuraOrganica
        '
        Me.gdvEstructuraOrganica.ActiveFilterEnabled = False
        Me.gdvEstructuraOrganica.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ESTRUCTURA_ORGANICA_ID, Me.ESTADO_REGISTRO_ORGANICA, Me.EMPLEADO_ID_EO, Me.DESC_ORGANIZACION, Me.DESC_DIRECCION, Me.DESC_DEPTO, Me.DESC_PERIODO_ORGANICA, Me.DESC_SUBDEPTO})
        Me.gdvEstructuraOrganica.GridControl = Me.gdcEstructuraOrganica
        Me.gdvEstructuraOrganica.Name = "gdvEstructuraOrganica"
        Me.gdvEstructuraOrganica.OptionsView.ShowGroupPanel = False
        '
        'ESTRUCTURA_ORGANICA_ID
        '
        Me.ESTRUCTURA_ORGANICA_ID.Caption = "ID Estruc.Orgánica"
        Me.ESTRUCTURA_ORGANICA_ID.FieldName = "ESTRUCTURA_ORGANICA_ID"
        Me.ESTRUCTURA_ORGANICA_ID.Name = "ESTRUCTURA_ORGANICA_ID"
        Me.ESTRUCTURA_ORGANICA_ID.OptionsColumn.AllowEdit = False
        Me.ESTRUCTURA_ORGANICA_ID.OptionsColumn.ReadOnly = True
        '
        'ESTADO_REGISTRO_ORGANICA
        '
        Me.ESTADO_REGISTRO_ORGANICA.Caption = "Estado Registro"
        Me.ESTADO_REGISTRO_ORGANICA.FieldName = "ESTADO_REGISTRO"
        Me.ESTADO_REGISTRO_ORGANICA.Name = "ESTADO_REGISTRO_ORGANICA"
        Me.ESTADO_REGISTRO_ORGANICA.OptionsColumn.AllowEdit = False
        Me.ESTADO_REGISTRO_ORGANICA.OptionsColumn.ReadOnly = True
        '
        'EMPLEADO_ID_EO
        '
        Me.EMPLEADO_ID_EO.Caption = "ID Empleado"
        Me.EMPLEADO_ID_EO.FieldName = "EMPLEADO_ID"
        Me.EMPLEADO_ID_EO.Name = "EMPLEADO_ID_EO"
        Me.EMPLEADO_ID_EO.OptionsColumn.AllowEdit = False
        Me.EMPLEADO_ID_EO.OptionsColumn.ReadOnly = True
        '
        'DESC_ORGANIZACION
        '
        Me.DESC_ORGANIZACION.Caption = "Organización"
        Me.DESC_ORGANIZACION.FieldName = "DESC_ORGANIZACION"
        Me.DESC_ORGANIZACION.Name = "DESC_ORGANIZACION"
        Me.DESC_ORGANIZACION.OptionsColumn.AllowEdit = False
        Me.DESC_ORGANIZACION.OptionsColumn.ReadOnly = True
        Me.DESC_ORGANIZACION.Visible = True
        Me.DESC_ORGANIZACION.VisibleIndex = 0
        Me.DESC_ORGANIZACION.Width = 153
        '
        'DESC_DIRECCION
        '
        Me.DESC_DIRECCION.Caption = "Dirección"
        Me.DESC_DIRECCION.FieldName = "DESC_DIRECCION"
        Me.DESC_DIRECCION.Name = "DESC_DIRECCION"
        Me.DESC_DIRECCION.OptionsColumn.AllowEdit = False
        Me.DESC_DIRECCION.OptionsColumn.ReadOnly = True
        Me.DESC_DIRECCION.Visible = True
        Me.DESC_DIRECCION.VisibleIndex = 1
        Me.DESC_DIRECCION.Width = 331
        '
        'DESC_DEPTO
        '
        Me.DESC_DEPTO.Caption = "Departamento"
        Me.DESC_DEPTO.FieldName = "DESC_DEPTO"
        Me.DESC_DEPTO.Name = "DESC_DEPTO"
        Me.DESC_DEPTO.OptionsColumn.AllowEdit = False
        Me.DESC_DEPTO.OptionsColumn.ReadOnly = True
        Me.DESC_DEPTO.Visible = True
        Me.DESC_DEPTO.VisibleIndex = 2
        Me.DESC_DEPTO.Width = 308
        '
        'DESC_PERIODO_ORGANICA
        '
        Me.DESC_PERIODO_ORGANICA.Caption = "Período"
        Me.DESC_PERIODO_ORGANICA.FieldName = "DESC_PERIODO"
        Me.DESC_PERIODO_ORGANICA.Name = "DESC_PERIODO_ORGANICA"
        Me.DESC_PERIODO_ORGANICA.OptionsColumn.AllowEdit = False
        Me.DESC_PERIODO_ORGANICA.OptionsColumn.ReadOnly = True
        '
        'DESC_SUBDEPTO
        '
        Me.DESC_SUBDEPTO.Caption = "SubDepartamento"
        Me.DESC_SUBDEPTO.FieldName = "DESC_SUBDEPTO"
        Me.DESC_SUBDEPTO.Name = "DESC_SUBDEPTO"
        Me.DESC_SUBDEPTO.OptionsColumn.AllowEdit = False
        Me.DESC_SUBDEPTO.OptionsColumn.ReadOnly = True
        Me.DESC_SUBDEPTO.Visible = True
        Me.DESC_SUBDEPTO.VisibleIndex = 3
        Me.DESC_SUBDEPTO.Width = 296
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcEstructuraOrganica
        Me.GridView1.Name = "GridView1"
        '
        'lueInstitucion
        '
        Me.lueInstitucion.Location = New System.Drawing.Point(136, 24)
        Me.lueInstitucion.Name = "lueInstitucion"
        Me.lueInstitucion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueInstitucion.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name2", "Name2")})
        Me.lueInstitucion.Size = New System.Drawing.Size(568, 20)
        Me.lueInstitucion.TabIndex = 6
        '
        'lueDepartamento
        '
        Me.lueDepartamento.Location = New System.Drawing.Point(136, 72)
        Me.lueDepartamento.Name = "lueDepartamento"
        Me.lueDepartamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDepartamento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueDepartamento.Size = New System.Drawing.Size(568, 20)
        Me.lueDepartamento.TabIndex = 5
        '
        'lueDireccion
        '
        Me.lueDireccion.Location = New System.Drawing.Point(136, 48)
        Me.lueDireccion.Name = "lueDireccion"
        Me.lueDireccion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDireccion.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name2", "Name2")})
        Me.lueDireccion.Size = New System.Drawing.Size(568, 20)
        Me.lueDireccion.TabIndex = 4
        '
        'lblDepartamento
        '
        Me.lblDepartamento.Location = New System.Drawing.Point(53, 78)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(69, 13)
        Me.lblDepartamento.TabIndex = 2
        Me.lblDepartamento.Text = "Departamento"
        '
        'lblDireccion
        '
        Me.lblDireccion.Location = New System.Drawing.Point(80, 54)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(43, 13)
        Me.lblDireccion.TabIndex = 1
        Me.lblDireccion.Text = "Dirección"
        '
        'lblOrganizacion
        '
        Me.lblOrganizacion.Location = New System.Drawing.Point(64, 30)
        Me.lblOrganizacion.Name = "lblOrganizacion"
        Me.lblOrganizacion.Size = New System.Drawing.Size(62, 13)
        Me.lblOrganizacion.TabIndex = 0
        Me.lblOrganizacion.Text = "Organización"
        '
        'gcCentrosCostos
        '
        Me.gcCentrosCostos.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gcCentrosCostos.AppearanceCaption.Options.UseFont = True
        Me.gcCentrosCostos.Controls.Add(Me.lblPorcentajeSign)
        Me.gcCentrosCostos.Controls.Add(Me.txtPorcentajeDistribucion)
        Me.gcCentrosCostos.Controls.Add(Me.lblPorcentajeDistribucion)
        Me.gcCentrosCostos.Controls.Add(Me.lueCentroCostoPresupuesto)
        Me.gcCentrosCostos.Controls.Add(Me.lueCentroCostoContable)
        Me.gcCentrosCostos.Controls.Add(Me.lblCentroDeCostoPresupuesto)
        Me.gcCentrosCostos.Controls.Add(Me.lblCentroDeCostoContable)
        Me.gcCentrosCostos.Controls.Add(Me.btnGuardarEstructuraContable)
        Me.gcCentrosCostos.Controls.Add(Me.btnCancelarEstructuraContable)
        Me.gcCentrosCostos.Controls.Add(Me.btnEliminarEstructuraContable)
        Me.gcCentrosCostos.Location = New System.Drawing.Point(13, 359)
        Me.gcCentrosCostos.Name = "gcCentrosCostos"
        Me.gcCentrosCostos.Size = New System.Drawing.Size(735, 232)
        Me.gcCentrosCostos.TabIndex = 1
        Me.gcCentrosCostos.Text = "Centralización Contable y Presupuesto"
        '
        'lblPorcentajeSign
        '
        Me.lblPorcentajeSign.Location = New System.Drawing.Point(240, 72)
        Me.lblPorcentajeSign.Name = "lblPorcentajeSign"
        Me.lblPorcentajeSign.Size = New System.Drawing.Size(11, 13)
        Me.lblPorcentajeSign.TabIndex = 21
        Me.lblPorcentajeSign.Text = "%"
        '
        'txtPorcentajeDistribucion
        '
        Me.txtPorcentajeDistribucion.Enabled = False
        Me.txtPorcentajeDistribucion.Location = New System.Drawing.Point(152, 72)
        Me.txtPorcentajeDistribucion.Name = "txtPorcentajeDistribucion"
        Me.txtPorcentajeDistribucion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorcentajeDistribucion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorcentajeDistribucion.Properties.Mask.EditMask = "n0"
        Me.txtPorcentajeDistribucion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPorcentajeDistribucion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPorcentajeDistribucion.Properties.MaxLength = 3
        Me.txtPorcentajeDistribucion.Size = New System.Drawing.Size(80, 20)
        Me.txtPorcentajeDistribucion.TabIndex = 20
        '
        'lblPorcentajeDistribucion
        '
        Me.lblPorcentajeDistribucion.Location = New System.Drawing.Point(8, 78)
        Me.lblPorcentajeDistribucion.Name = "lblPorcentajeDistribucion"
        Me.lblPorcentajeDistribucion.Size = New System.Drawing.Size(110, 13)
        Me.lblPorcentajeDistribucion.TabIndex = 19
        Me.lblPorcentajeDistribucion.Text = "Porcentaje Distribución"
        '
        'lueCentroCostoPresupuesto
        '
        Me.lueCentroCostoPresupuesto.Location = New System.Drawing.Point(152, 48)
        Me.lueCentroCostoPresupuesto.Name = "lueCentroCostoPresupuesto"
        Me.lueCentroCostoPresupuesto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCentroCostoPresupuesto.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name5", "Name5")})
        Me.lueCentroCostoPresupuesto.Size = New System.Drawing.Size(560, 20)
        Me.lueCentroCostoPresupuesto.TabIndex = 18
        '
        'lueCentroCostoContable
        '
        Me.lueCentroCostoContable.Location = New System.Drawing.Point(152, 24)
        Me.lueCentroCostoContable.Name = "lueCentroCostoContable"
        Me.lueCentroCostoContable.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCentroCostoContable.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name4", "Name4")})
        Me.lueCentroCostoContable.Size = New System.Drawing.Size(560, 20)
        Me.lueCentroCostoContable.TabIndex = 17
        '
        'lblCentroDeCostoPresupuesto
        '
        Me.lblCentroDeCostoPresupuesto.Location = New System.Drawing.Point(8, 54)
        Me.lblCentroDeCostoPresupuesto.Name = "lblCentroDeCostoPresupuesto"
        Me.lblCentroDeCostoPresupuesto.Size = New System.Drawing.Size(127, 13)
        Me.lblCentroDeCostoPresupuesto.TabIndex = 16
        Me.lblCentroDeCostoPresupuesto.Text = "Centro Costo Presupuesto"
        '
        'lblCentroDeCostoContable
        '
        Me.lblCentroDeCostoContable.Location = New System.Drawing.Point(8, 30)
        Me.lblCentroDeCostoContable.Name = "lblCentroDeCostoContable"
        Me.lblCentroDeCostoContable.Size = New System.Drawing.Size(125, 13)
        Me.lblCentroDeCostoContable.TabIndex = 14
        Me.lblCentroDeCostoContable.Text = "Centro de Costo Contable"
        '
        'btnGuardarEstructuraContable
        '
        Me.btnGuardarEstructuraContable.Location = New System.Drawing.Point(336, 192)
        Me.btnGuardarEstructuraContable.Name = "btnGuardarEstructuraContable"
        Me.btnGuardarEstructuraContable.Size = New System.Drawing.Size(112, 23)
        Me.btnGuardarEstructuraContable.TabIndex = 13
        Me.btnGuardarEstructuraContable.Text = "&Guardar"
        '
        'btnCancelarEstructuraContable
        '
        Me.btnCancelarEstructuraContable.Location = New System.Drawing.Point(216, 192)
        Me.btnCancelarEstructuraContable.Name = "btnCancelarEstructuraContable"
        Me.btnCancelarEstructuraContable.Size = New System.Drawing.Size(112, 23)
        Me.btnCancelarEstructuraContable.TabIndex = 12
        Me.btnCancelarEstructuraContable.Text = "&Cancelar"
        '
        'btnEliminarEstructuraContable
        '
        Me.btnEliminarEstructuraContable.Location = New System.Drawing.Point(456, 192)
        Me.btnEliminarEstructuraContable.Name = "btnEliminarEstructuraContable"
        Me.btnEliminarEstructuraContable.Size = New System.Drawing.Size(112, 23)
        Me.btnEliminarEstructuraContable.TabIndex = 15
        Me.btnEliminarEstructuraContable.Text = "&Eliminar"
        '
        'xtpDatosPrevisionales
        '
        Me.xtpDatosPrevisionales.Controls.Add(Me.lblNombreDatosPrevisionales)
        Me.xtpDatosPrevisionales.Controls.Add(Me.lblMensajePrevisional)
        Me.xtpDatosPrevisionales.Controls.Add(Me.btnGuardarDatosPrevisionales)
        Me.xtpDatosPrevisionales.Controls.Add(Me.gpcDatosFondoPenciones)
        Me.xtpDatosPrevisionales.Controls.Add(Me.gpcDatosSaludPrevisional)
        Me.xtpDatosPrevisionales.Controls.Add(Me.btnGuardaryConservar)
        Me.xtpDatosPrevisionales.Controls.Add(Me.btnGuardarRegistroActual)
        Me.xtpDatosPrevisionales.Controls.Add(Me.gpcDetallePrevisional)
        Me.xtpDatosPrevisionales.Name = "xtpDatosPrevisionales"
        Me.xtpDatosPrevisionales.Size = New System.Drawing.Size(1001, 648)
        Me.xtpDatosPrevisionales.Text = "Datos Previsionales"
        '
        'lblNombreDatosPrevisionales
        '
        Me.lblNombreDatosPrevisionales.AutoSize = True
        Me.lblNombreDatosPrevisionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDatosPrevisionales.Location = New System.Drawing.Point(10, 10)
        Me.lblNombreDatosPrevisionales.Name = "lblNombreDatosPrevisionales"
        Me.lblNombreDatosPrevisionales.Size = New System.Drawing.Size(90, 15)
        Me.lblNombreDatosPrevisionales.TabIndex = 92
        Me.lblNombreDatosPrevisionales.Text = "EMPLEADO: "
        '
        'lblMensajePrevisional
        '
        Me.lblMensajePrevisional.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMensajePrevisional.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblMensajePrevisional.Appearance.Options.UseFont = True
        Me.lblMensajePrevisional.Appearance.Options.UseForeColor = True
        Me.lblMensajePrevisional.Location = New System.Drawing.Point(930, 31)
        Me.lblMensajePrevisional.Name = "lblMensajePrevisional"
        Me.lblMensajePrevisional.Size = New System.Drawing.Size(78, 13)
        Me.lblMensajePrevisional.TabIndex = 49
        Me.lblMensajePrevisional.Text = "LabelControl1"
        '
        'btnGuardarDatosPrevisionales
        '
        Me.btnGuardarDatosPrevisionales.Location = New System.Drawing.Point(417, 279)
        Me.btnGuardarDatosPrevisionales.Name = "btnGuardarDatosPrevisionales"
        Me.btnGuardarDatosPrevisionales.Size = New System.Drawing.Size(120, 23)
        Me.btnGuardarDatosPrevisionales.TabIndex = 91
        Me.btnGuardarDatosPrevisionales.Text = "Guardar"
        '
        'gpcDatosFondoPenciones
        '
        Me.gpcDatosFondoPenciones.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDatosFondoPenciones.AppearanceCaption.Options.UseFont = True
        Me.gpcDatosFondoPenciones.Controls.Add(Me.deeAfpFechaFun)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.chkFondoE)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.txtAfpNroFun)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.chkFondoD)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.chkFondoC)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.chkFondoB)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.chkFondoA)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.lblMultiFondoPrevisional)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.lueUnidadCotizacionVol)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.lueUnidadAhorroAfp)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.lueAfp)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.lblInsitucionPrevisional)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.txtMontoCotizacionVoluntaria)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.txtMontoAhorroAfp)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.lblAfpFechaFun)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.lblApfNroFun)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.lblCotizacionVol)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.lblTipoMonedaCtaAhorro)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.lblMontoCtaAhorro)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.dedFechaAfiliacionPrevisional)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.lblFechaAfiliacionAFP)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.dedFechaIngsistemaPrev)
        Me.gpcDatosFondoPenciones.Controls.Add(Me.lblFechaIngSistemaPrev)
        Me.gpcDatosFondoPenciones.Location = New System.Drawing.Point(13, 31)
        Me.gpcDatosFondoPenciones.Name = "gpcDatosFondoPenciones"
        Me.gpcDatosFondoPenciones.Size = New System.Drawing.Size(458, 244)
        Me.gpcDatosFondoPenciones.TabIndex = 81
        Me.gpcDatosFondoPenciones.Text = "Datos Fondo de Pensiones"
        '
        'deeAfpFechaFun
        '
        Me.deeAfpFechaFun.EditValue = Nothing
        Me.deeAfpFechaFun.Location = New System.Drawing.Point(214, 207)
        Me.deeAfpFechaFun.Name = "deeAfpFechaFun"
        Me.deeAfpFechaFun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deeAfpFechaFun.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deeAfpFechaFun.Size = New System.Drawing.Size(120, 20)
        Me.deeAfpFechaFun.TabIndex = 37
        '
        'chkFondoE
        '
        Me.chkFondoE.Location = New System.Drawing.Point(388, 156)
        Me.chkFondoE.Name = "chkFondoE"
        Me.chkFondoE.Properties.Caption = "Fondo E"
        Me.chkFondoE.Size = New System.Drawing.Size(62, 19)
        Me.chkFondoE.TabIndex = 24
        '
        'txtAfpNroFun
        '
        Me.txtAfpNroFun.Location = New System.Drawing.Point(214, 181)
        Me.txtAfpNroFun.Name = "txtAfpNroFun"
        Me.txtAfpNroFun.Size = New System.Drawing.Size(120, 20)
        Me.txtAfpNroFun.TabIndex = 36
        '
        'chkFondoD
        '
        Me.chkFondoD.Location = New System.Drawing.Point(324, 156)
        Me.chkFondoD.Name = "chkFondoD"
        Me.chkFondoD.Properties.Caption = "Fondo D"
        Me.chkFondoD.Size = New System.Drawing.Size(62, 19)
        Me.chkFondoD.TabIndex = 23
        '
        'chkFondoC
        '
        Me.chkFondoC.Location = New System.Drawing.Point(260, 156)
        Me.chkFondoC.Name = "chkFondoC"
        Me.chkFondoC.Properties.Caption = "Fondo C"
        Me.chkFondoC.Size = New System.Drawing.Size(62, 19)
        Me.chkFondoC.TabIndex = 22
        '
        'chkFondoB
        '
        Me.chkFondoB.Location = New System.Drawing.Point(196, 156)
        Me.chkFondoB.Name = "chkFondoB"
        Me.chkFondoB.Properties.Caption = "Fondo B"
        Me.chkFondoB.Size = New System.Drawing.Size(62, 19)
        Me.chkFondoB.TabIndex = 21
        '
        'chkFondoA
        '
        Me.chkFondoA.Location = New System.Drawing.Point(132, 156)
        Me.chkFondoA.Name = "chkFondoA"
        Me.chkFondoA.Properties.Caption = "Fondo A"
        Me.chkFondoA.Size = New System.Drawing.Size(62, 19)
        Me.chkFondoA.TabIndex = 20
        '
        'lblMultiFondoPrevisional
        '
        Me.lblMultiFondoPrevisional.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMultiFondoPrevisional.Location = New System.Drawing.Point(14, 158)
        Me.lblMultiFondoPrevisional.Name = "lblMultiFondoPrevisional"
        Me.lblMultiFondoPrevisional.Size = New System.Drawing.Size(110, 16)
        Me.lblMultiFondoPrevisional.TabIndex = 19
        Me.lblMultiFondoPrevisional.Text = "Multi Fondos Prev."
        Me.lblMultiFondoPrevisional.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lueUnidadCotizacionVol
        '
        Me.lueUnidadCotizacionVol.EnterMoveNextControl = True
        Me.lueUnidadCotizacionVol.Location = New System.Drawing.Point(336, 128)
        Me.lueUnidadCotizacionVol.Name = "lueUnidadCotizacionVol"
        Me.lueUnidadCotizacionVol.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueUnidadCotizacionVol.Properties.NullText = ""
        Me.lueUnidadCotizacionVol.Size = New System.Drawing.Size(116, 20)
        Me.lueUnidadCotizacionVol.TabIndex = 18
        Me.lueUnidadCotizacionVol.Visible = False
        '
        'lueUnidadAhorroAfp
        '
        Me.lueUnidadAhorroAfp.EnterMoveNextControl = True
        Me.lueUnidadAhorroAfp.Location = New System.Drawing.Point(336, 104)
        Me.lueUnidadAhorroAfp.Name = "lueUnidadAhorroAfp"
        Me.lueUnidadAhorroAfp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueUnidadAhorroAfp.Properties.NullText = ""
        Me.lueUnidadAhorroAfp.Size = New System.Drawing.Size(116, 20)
        Me.lueUnidadAhorroAfp.TabIndex = 14
        '
        'lueAfp
        '
        Me.lueAfp.EnterMoveNextControl = True
        Me.lueAfp.Location = New System.Drawing.Point(214, 32)
        Me.lueAfp.Name = "lueAfp"
        Me.lueAfp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAfp.Properties.NullText = ""
        Me.lueAfp.Properties.PopupWidth = 400
        Me.lueAfp.Size = New System.Drawing.Size(240, 20)
        Me.lueAfp.TabIndex = 6
        '
        'lblInsitucionPrevisional
        '
        Me.lblInsitucionPrevisional.Location = New System.Drawing.Point(24, 36)
        Me.lblInsitucionPrevisional.Name = "lblInsitucionPrevisional"
        Me.lblInsitucionPrevisional.Size = New System.Drawing.Size(184, 16)
        Me.lblInsitucionPrevisional.TabIndex = 5
        Me.lblInsitucionPrevisional.Text = "Institución Previsional"
        Me.lblInsitucionPrevisional.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMontoCotizacionVoluntaria
        '
        Me.txtMontoCotizacionVoluntaria.EnterMoveNextControl = True
        Me.txtMontoCotizacionVoluntaria.Location = New System.Drawing.Point(214, 128)
        Me.txtMontoCotizacionVoluntaria.Name = "txtMontoCotizacionVoluntaria"
        Me.txtMontoCotizacionVoluntaria.Properties.Mask.EditMask = "n3"
        Me.txtMontoCotizacionVoluntaria.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoCotizacionVoluntaria.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoCotizacionVoluntaria.Size = New System.Drawing.Size(120, 20)
        Me.txtMontoCotizacionVoluntaria.TabIndex = 16
        Me.txtMontoCotizacionVoluntaria.Visible = False
        '
        'txtMontoAhorroAfp
        '
        Me.txtMontoAhorroAfp.EnterMoveNextControl = True
        Me.txtMontoAhorroAfp.Location = New System.Drawing.Point(214, 104)
        Me.txtMontoAhorroAfp.Name = "txtMontoAhorroAfp"
        Me.txtMontoAhorroAfp.Properties.Mask.EditMask = "n3"
        Me.txtMontoAhorroAfp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoAhorroAfp.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoAhorroAfp.Size = New System.Drawing.Size(120, 20)
        Me.txtMontoAhorroAfp.TabIndex = 12
        '
        'lblAfpFechaFun
        '
        Me.lblAfpFechaFun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAfpFechaFun.Location = New System.Drawing.Point(32, 208)
        Me.lblAfpFechaFun.Name = "lblAfpFechaFun"
        Me.lblAfpFechaFun.Size = New System.Drawing.Size(176, 16)
        Me.lblAfpFechaFun.TabIndex = 15
        Me.lblAfpFechaFun.Text = "Fecha Fun"
        Me.lblAfpFechaFun.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblApfNroFun
        '
        Me.lblApfNroFun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApfNroFun.Location = New System.Drawing.Point(32, 185)
        Me.lblApfNroFun.Name = "lblApfNroFun"
        Me.lblApfNroFun.Size = New System.Drawing.Size(176, 16)
        Me.lblApfNroFun.TabIndex = 15
        Me.lblApfNroFun.Text = "Número de Fun"
        Me.lblApfNroFun.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCotizacionVol
        '
        Me.lblCotizacionVol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCotizacionVol.Location = New System.Drawing.Point(32, 128)
        Me.lblCotizacionVol.Name = "lblCotizacionVol"
        Me.lblCotizacionVol.Size = New System.Drawing.Size(176, 16)
        Me.lblCotizacionVol.TabIndex = 15
        Me.lblCotizacionVol.Text = "Monto Cotización Voluntaria"
        Me.lblCotizacionVol.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblCotizacionVol.Visible = False
        '
        'lblTipoMonedaCtaAhorro
        '
        Me.lblTipoMonedaCtaAhorro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoMonedaCtaAhorro.Location = New System.Drawing.Point(338, 86)
        Me.lblTipoMonedaCtaAhorro.Name = "lblTipoMonedaCtaAhorro"
        Me.lblTipoMonedaCtaAhorro.Size = New System.Drawing.Size(112, 16)
        Me.lblTipoMonedaCtaAhorro.TabIndex = 13
        Me.lblTipoMonedaCtaAhorro.Text = "Unidad Monetaria"
        Me.lblTipoMonedaCtaAhorro.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMontoCtaAhorro
        '
        Me.lblMontoCtaAhorro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoCtaAhorro.Location = New System.Drawing.Point(72, 104)
        Me.lblMontoCtaAhorro.Name = "lblMontoCtaAhorro"
        Me.lblMontoCtaAhorro.Size = New System.Drawing.Size(136, 16)
        Me.lblMontoCtaAhorro.TabIndex = 11
        Me.lblMontoCtaAhorro.Text = "Monto Cuenta Ahorro"
        Me.lblMontoCtaAhorro.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dedFechaAfiliacionPrevisional
        '
        Me.dedFechaAfiliacionPrevisional.EditValue = Nothing
        Me.dedFechaAfiliacionPrevisional.EnterMoveNextControl = True
        Me.dedFechaAfiliacionPrevisional.Location = New System.Drawing.Point(214, 80)
        Me.dedFechaAfiliacionPrevisional.Name = "dedFechaAfiliacionPrevisional"
        Me.dedFechaAfiliacionPrevisional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaAfiliacionPrevisional.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaAfiliacionPrevisional.Size = New System.Drawing.Size(120, 20)
        Me.dedFechaAfiliacionPrevisional.TabIndex = 10
        '
        'lblFechaAfiliacionAFP
        '
        Me.lblFechaAfiliacionAFP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaAfiliacionAFP.Location = New System.Drawing.Point(112, 80)
        Me.lblFechaAfiliacionAFP.Name = "lblFechaAfiliacionAFP"
        Me.lblFechaAfiliacionAFP.Size = New System.Drawing.Size(96, 16)
        Me.lblFechaAfiliacionAFP.TabIndex = 9
        Me.lblFechaAfiliacionAFP.Text = "Fecha Afiliación"
        Me.lblFechaAfiliacionAFP.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dedFechaIngsistemaPrev
        '
        Me.dedFechaIngsistemaPrev.EditValue = New Date(2006, 11, 20, 15, 12, 2, 900)
        Me.dedFechaIngsistemaPrev.EnterMoveNextControl = True
        Me.dedFechaIngsistemaPrev.Location = New System.Drawing.Point(214, 56)
        Me.dedFechaIngsistemaPrev.Name = "dedFechaIngsistemaPrev"
        Me.dedFechaIngsistemaPrev.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaIngsistemaPrev.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaIngsistemaPrev.Size = New System.Drawing.Size(120, 20)
        Me.dedFechaIngsistemaPrev.TabIndex = 8
        '
        'lblFechaIngSistemaPrev
        '
        Me.lblFechaIngSistemaPrev.Location = New System.Drawing.Point(8, 58)
        Me.lblFechaIngSistemaPrev.Name = "lblFechaIngSistemaPrev"
        Me.lblFechaIngSistemaPrev.Size = New System.Drawing.Size(200, 16)
        Me.lblFechaIngSistemaPrev.TabIndex = 7
        Me.lblFechaIngSistemaPrev.Text = "Fecha Ingreso Sistema Previsional"
        Me.lblFechaIngSistemaPrev.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gpcDatosSaludPrevisional
        '
        Me.gpcDatosSaludPrevisional.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDatosSaludPrevisional.AppearanceCaption.Options.UseFont = True
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.deeIsapreFechaFun)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.txtIsapreNroFun)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.lueTipoTrabajadorPrevired)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.lblIsapreFechaFun)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.lblIsapreNroFun)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.lblTipoTrabajadorPrevired)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.lueUnidadMontoPlanAuge)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.txtMontoPlanAuge)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.lblMontoPlanAuge)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.lueUnidadMontoPlanComplementario)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.lueUnidadMontoConvenio)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.lueIsapre)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.Label3)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.txtMontoPlanComplementario)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.txtMontoConvenio)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.lblMontoPlanComplementario)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.lbllbTipoMonedaConvenioSalud)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.lblMontoConvenioSalud)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.dedFechaAfiliacionSalud)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.lblFechaAfiliacionIsapreFonosa)
        Me.gpcDatosSaludPrevisional.Controls.Add(Me.lblInstitucionSalud)
        Me.gpcDatosSaludPrevisional.Location = New System.Drawing.Point(477, 31)
        Me.gpcDatosSaludPrevisional.Name = "gpcDatosSaludPrevisional"
        Me.gpcDatosSaludPrevisional.Size = New System.Drawing.Size(454, 244)
        Me.gpcDatosSaludPrevisional.TabIndex = 82
        Me.gpcDatosSaludPrevisional.Text = "Datos Salud Previsional"
        '
        'deeIsapreFechaFun
        '
        Me.deeIsapreFechaFun.EditValue = Nothing
        Me.deeIsapreFechaFun.Location = New System.Drawing.Point(200, 215)
        Me.deeIsapreFechaFun.MenuManager = Me.BarManager1
        Me.deeIsapreFechaFun.Name = "deeIsapreFechaFun"
        Me.deeIsapreFechaFun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deeIsapreFechaFun.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deeIsapreFechaFun.Size = New System.Drawing.Size(120, 20)
        Me.deeIsapreFechaFun.TabIndex = 37
        '
        'txtIsapreNroFun
        '
        Me.txtIsapreNroFun.Location = New System.Drawing.Point(200, 188)
        Me.txtIsapreNroFun.MenuManager = Me.BarManager1
        Me.txtIsapreNroFun.Name = "txtIsapreNroFun"
        Me.txtIsapreNroFun.Size = New System.Drawing.Size(120, 20)
        Me.txtIsapreNroFun.TabIndex = 36
        '
        'lueTipoTrabajadorPrevired
        '
        Me.lueTipoTrabajadorPrevired.EnterMoveNextControl = True
        Me.lueTipoTrabajadorPrevired.Location = New System.Drawing.Point(200, 162)
        Me.lueTipoTrabajadorPrevired.Name = "lueTipoTrabajadorPrevired"
        Me.lueTipoTrabajadorPrevired.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTipoTrabajadorPrevired.Properties.NullText = ""
        Me.lueTipoTrabajadorPrevired.Size = New System.Drawing.Size(244, 20)
        Me.lueTipoTrabajadorPrevired.TabIndex = 35
        '
        'lblIsapreFechaFun
        '
        Me.lblIsapreFechaFun.Location = New System.Drawing.Point(50, 219)
        Me.lblIsapreFechaFun.Name = "lblIsapreFechaFun"
        Me.lblIsapreFechaFun.Size = New System.Drawing.Size(142, 16)
        Me.lblIsapreFechaFun.TabIndex = 34
        Me.lblIsapreFechaFun.Text = "Fecha Fun"
        Me.lblIsapreFechaFun.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblIsapreNroFun
        '
        Me.lblIsapreNroFun.Location = New System.Drawing.Point(52, 192)
        Me.lblIsapreNroFun.Name = "lblIsapreNroFun"
        Me.lblIsapreNroFun.Size = New System.Drawing.Size(142, 16)
        Me.lblIsapreNroFun.TabIndex = 34
        Me.lblIsapreNroFun.Text = "Número de Fun"
        Me.lblIsapreNroFun.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTipoTrabajadorPrevired
        '
        Me.lblTipoTrabajadorPrevired.Location = New System.Drawing.Point(50, 166)
        Me.lblTipoTrabajadorPrevired.Name = "lblTipoTrabajadorPrevired"
        Me.lblTipoTrabajadorPrevired.Size = New System.Drawing.Size(142, 16)
        Me.lblTipoTrabajadorPrevired.TabIndex = 34
        Me.lblTipoTrabajadorPrevired.Text = "Tipo Trabajador Previred"
        Me.lblTipoTrabajadorPrevired.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lueUnidadMontoPlanAuge
        '
        Me.lueUnidadMontoPlanAuge.EnterMoveNextControl = True
        Me.lueUnidadMontoPlanAuge.Location = New System.Drawing.Point(324, 134)
        Me.lueUnidadMontoPlanAuge.Name = "lueUnidadMontoPlanAuge"
        Me.lueUnidadMontoPlanAuge.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueUnidadMontoPlanAuge.Properties.NullText = ""
        Me.lueUnidadMontoPlanAuge.Size = New System.Drawing.Size(120, 20)
        Me.lueUnidadMontoPlanAuge.TabIndex = 33
        Me.lueUnidadMontoPlanAuge.Visible = False
        '
        'txtMontoPlanAuge
        '
        Me.txtMontoPlanAuge.EnterMoveNextControl = True
        Me.txtMontoPlanAuge.Location = New System.Drawing.Point(200, 134)
        Me.txtMontoPlanAuge.Name = "txtMontoPlanAuge"
        Me.txtMontoPlanAuge.Properties.Mask.EditMask = "n3"
        Me.txtMontoPlanAuge.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoPlanAuge.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoPlanAuge.Size = New System.Drawing.Size(120, 20)
        Me.txtMontoPlanAuge.TabIndex = 32
        Me.txtMontoPlanAuge.Visible = False
        '
        'lblMontoPlanAuge
        '
        Me.lblMontoPlanAuge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoPlanAuge.Location = New System.Drawing.Point(16, 138)
        Me.lblMontoPlanAuge.Name = "lblMontoPlanAuge"
        Me.lblMontoPlanAuge.Size = New System.Drawing.Size(176, 16)
        Me.lblMontoPlanAuge.TabIndex = 31
        Me.lblMontoPlanAuge.Text = "Monto Plan AUGE"
        Me.lblMontoPlanAuge.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblMontoPlanAuge.Visible = False
        '
        'lueUnidadMontoPlanComplementario
        '
        Me.lueUnidadMontoPlanComplementario.EnterMoveNextControl = True
        Me.lueUnidadMontoPlanComplementario.Location = New System.Drawing.Point(324, 106)
        Me.lueUnidadMontoPlanComplementario.Name = "lueUnidadMontoPlanComplementario"
        Me.lueUnidadMontoPlanComplementario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueUnidadMontoPlanComplementario.Properties.NullText = ""
        Me.lueUnidadMontoPlanComplementario.Size = New System.Drawing.Size(120, 20)
        Me.lueUnidadMontoPlanComplementario.TabIndex = 30
        '
        'lueUnidadMontoConvenio
        '
        Me.lueUnidadMontoConvenio.EnterMoveNextControl = True
        Me.lueUnidadMontoConvenio.Location = New System.Drawing.Point(324, 80)
        Me.lueUnidadMontoConvenio.Name = "lueUnidadMontoConvenio"
        Me.lueUnidadMontoConvenio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueUnidadMontoConvenio.Properties.NullText = ""
        Me.lueUnidadMontoConvenio.Size = New System.Drawing.Size(120, 20)
        Me.lueUnidadMontoConvenio.TabIndex = 26
        '
        'lueIsapre
        '
        Me.lueIsapre.EnterMoveNextControl = True
        Me.lueIsapre.Location = New System.Drawing.Point(200, 32)
        Me.lueIsapre.Name = "lueIsapre"
        Me.lueIsapre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueIsapre.Properties.NullText = ""
        Me.lueIsapre.Size = New System.Drawing.Size(244, 20)
        Me.lueIsapre.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-467, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Fecha Fun"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label3.Visible = False
        '
        'txtMontoPlanComplementario
        '
        Me.txtMontoPlanComplementario.EnterMoveNextControl = True
        Me.txtMontoPlanComplementario.Location = New System.Drawing.Point(200, 106)
        Me.txtMontoPlanComplementario.Name = "txtMontoPlanComplementario"
        Me.txtMontoPlanComplementario.Properties.Mask.EditMask = "n3"
        Me.txtMontoPlanComplementario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoPlanComplementario.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoPlanComplementario.Size = New System.Drawing.Size(120, 20)
        Me.txtMontoPlanComplementario.TabIndex = 28
        '
        'txtMontoConvenio
        '
        Me.txtMontoConvenio.EnterMoveNextControl = True
        Me.txtMontoConvenio.Location = New System.Drawing.Point(200, 80)
        Me.txtMontoConvenio.Name = "txtMontoConvenio"
        Me.txtMontoConvenio.Properties.Mask.EditMask = "n3"
        Me.txtMontoConvenio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoConvenio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoConvenio.Size = New System.Drawing.Size(120, 20)
        Me.txtMontoConvenio.TabIndex = 24
        '
        'lblMontoPlanComplementario
        '
        Me.lblMontoPlanComplementario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoPlanComplementario.Location = New System.Drawing.Point(16, 110)
        Me.lblMontoPlanComplementario.Name = "lblMontoPlanComplementario"
        Me.lblMontoPlanComplementario.Size = New System.Drawing.Size(176, 16)
        Me.lblMontoPlanComplementario.TabIndex = 27
        Me.lblMontoPlanComplementario.Text = "Monto Plan Complementario"
        Me.lblMontoPlanComplementario.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbllbTipoMonedaConvenioSalud
        '
        Me.lbllbTipoMonedaConvenioSalud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllbTipoMonedaConvenioSalud.Location = New System.Drawing.Point(326, 60)
        Me.lbllbTipoMonedaConvenioSalud.Name = "lbllbTipoMonedaConvenioSalud"
        Me.lbllbTipoMonedaConvenioSalud.Size = New System.Drawing.Size(108, 16)
        Me.lbllbTipoMonedaConvenioSalud.TabIndex = 25
        Me.lbllbTipoMonedaConvenioSalud.Text = "Unidad Monetaria"
        Me.lbllbTipoMonedaConvenioSalud.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMontoConvenioSalud
        '
        Me.lblMontoConvenioSalud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoConvenioSalud.Location = New System.Drawing.Point(56, 84)
        Me.lblMontoConvenioSalud.Name = "lblMontoConvenioSalud"
        Me.lblMontoConvenioSalud.Size = New System.Drawing.Size(136, 16)
        Me.lblMontoConvenioSalud.TabIndex = 23
        Me.lblMontoConvenioSalud.Text = "Monto Convenio"
        Me.lblMontoConvenioSalud.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dedFechaAfiliacionSalud
        '
        Me.dedFechaAfiliacionSalud.EditValue = Nothing
        Me.dedFechaAfiliacionSalud.EnterMoveNextControl = True
        Me.dedFechaAfiliacionSalud.Location = New System.Drawing.Point(200, 56)
        Me.dedFechaAfiliacionSalud.Name = "dedFechaAfiliacionSalud"
        Me.dedFechaAfiliacionSalud.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaAfiliacionSalud.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaAfiliacionSalud.Size = New System.Drawing.Size(120, 20)
        Me.dedFechaAfiliacionSalud.TabIndex = 22
        '
        'lblFechaAfiliacionIsapreFonosa
        '
        Me.lblFechaAfiliacionIsapreFonosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaAfiliacionIsapreFonosa.Location = New System.Drawing.Point(96, 60)
        Me.lblFechaAfiliacionIsapreFonosa.Name = "lblFechaAfiliacionIsapreFonosa"
        Me.lblFechaAfiliacionIsapreFonosa.Size = New System.Drawing.Size(96, 16)
        Me.lblFechaAfiliacionIsapreFonosa.TabIndex = 21
        Me.lblFechaAfiliacionIsapreFonosa.Text = "Fecha Afiliación"
        Me.lblFechaAfiliacionIsapreFonosa.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblInstitucionSalud
        '
        Me.lblInstitucionSalud.Location = New System.Drawing.Point(72, 36)
        Me.lblInstitucionSalud.Name = "lblInstitucionSalud"
        Me.lblInstitucionSalud.Size = New System.Drawing.Size(120, 16)
        Me.lblInstitucionSalud.TabIndex = 19
        Me.lblInstitucionSalud.Text = "Institución de Salud"
        Me.lblInstitucionSalud.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnGuardaryConservar
        '
        Me.btnGuardaryConservar.Location = New System.Drawing.Point(97, 279)
        Me.btnGuardaryConservar.Name = "btnGuardaryConservar"
        Me.btnGuardaryConservar.Size = New System.Drawing.Size(240, 23)
        Me.btnGuardaryConservar.TabIndex = 31
        Me.btnGuardaryConservar.Text = "Guardar y &Conservar Registro Anterior"
        Me.btnGuardaryConservar.Visible = False
        '
        'btnGuardarRegistroActual
        '
        Me.btnGuardarRegistroActual.Location = New System.Drawing.Point(613, 281)
        Me.btnGuardarRegistroActual.Name = "btnGuardarRegistroActual"
        Me.btnGuardarRegistroActual.Size = New System.Drawing.Size(240, 23)
        Me.btnGuardarRegistroActual.TabIndex = 32
        Me.btnGuardarRegistroActual.Text = "&Guardar Registro Actual"
        Me.btnGuardarRegistroActual.Visible = False
        '
        'gpcDetallePrevisional
        '
        Me.gpcDetallePrevisional.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gpcDetallePrevisional.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDetallePrevisional.AppearanceCaption.Options.UseFont = True
        Me.gpcDetallePrevisional.Controls.Add(Me.gdcPrevision)
        Me.gpcDetallePrevisional.Location = New System.Drawing.Point(13, 309)
        Me.gpcDetallePrevisional.Name = "gpcDetallePrevisional"
        Me.gpcDetallePrevisional.Size = New System.Drawing.Size(922, 333)
        Me.gpcDetallePrevisional.TabIndex = 90
        Me.gpcDetallePrevisional.Text = "Detalle Histórico Previsional y de Salud"
        '
        'gdcPrevision
        '
        Me.gdcPrevision.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcPrevision.EmbeddedNavigator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcPrevision.Location = New System.Drawing.Point(16, 32)
        Me.gdcPrevision.MainView = Me.gdvDetallePrevision
        Me.gdcPrevision.Name = "gdcPrevision"
        Me.gdcPrevision.Size = New System.Drawing.Size(890, 295)
        Me.gdcPrevision.TabIndex = 33
        Me.gdcPrevision.Tag = "74"
        Me.gdcPrevision.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetallePrevision, Me.GridView4})
        '
        'gdvDetallePrevision
        '
        Me.gdvDetallePrevision.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNOMBRE_ESTADO_REGISTRO, Me.colFECHA_ING_SISTEMA_PREVIS, Me.colNOMBRE_AFP, Me.colTASA_DESCUENTO, Me.colDESCUENTO_LEY_19882, Me.colFECHA_AFILIACION_AFP, Me.colMONTO_AHORRO_AFP, Me.colMONTO_COTIZACION_VOLUNTARIA_AFP, Me.colNOMBRE_ISAPRE, Me.colFECHA_AFILIACION_ISAPRE, Me.colMONTO_ISAPRE, Me.colPLAN_COMPLEM_ISAPRE, Me.colANTECEDENTE_PREVIS_ID, Me.colEMPLEADO_ID})
        Me.gdvDetallePrevision.GridControl = Me.gdcPrevision
        Me.gdvDetallePrevision.GroupPanelText = "Historia y Detalle Previsional"
        Me.gdvDetallePrevision.Name = "gdvDetallePrevision"
        Me.gdvDetallePrevision.OptionsBehavior.Editable = False
        Me.gdvDetallePrevision.OptionsFilter.AllowColumnMRUFilterList = False
        Me.gdvDetallePrevision.OptionsFilter.AllowFilterEditor = False
        Me.gdvDetallePrevision.OptionsFilter.AllowMRUFilterList = False
        Me.gdvDetallePrevision.OptionsView.ColumnAutoWidth = False
        Me.gdvDetallePrevision.OptionsView.ShowGroupPanel = False
        '
        'colNOMBRE_ESTADO_REGISTRO
        '
        Me.colNOMBRE_ESTADO_REGISTRO.Caption = "Estado"
        Me.colNOMBRE_ESTADO_REGISTRO.FieldName = "NOMBRE_ESTADO_REGISTRO"
        Me.colNOMBRE_ESTADO_REGISTRO.Name = "colNOMBRE_ESTADO_REGISTRO"
        Me.colNOMBRE_ESTADO_REGISTRO.OptionsColumn.AllowEdit = False
        Me.colNOMBRE_ESTADO_REGISTRO.Visible = True
        Me.colNOMBRE_ESTADO_REGISTRO.VisibleIndex = 0
        Me.colNOMBRE_ESTADO_REGISTRO.Width = 62
        '
        'colFECHA_ING_SISTEMA_PREVIS
        '
        Me.colFECHA_ING_SISTEMA_PREVIS.Caption = "Ing.Sistema Prev"
        Me.colFECHA_ING_SISTEMA_PREVIS.FieldName = "FECHA_ING_SISTEMA_PREVIS"
        Me.colFECHA_ING_SISTEMA_PREVIS.Name = "colFECHA_ING_SISTEMA_PREVIS"
        Me.colFECHA_ING_SISTEMA_PREVIS.OptionsColumn.AllowEdit = False
        Me.colFECHA_ING_SISTEMA_PREVIS.Visible = True
        Me.colFECHA_ING_SISTEMA_PREVIS.VisibleIndex = 1
        Me.colFECHA_ING_SISTEMA_PREVIS.Width = 112
        '
        'colNOMBRE_AFP
        '
        Me.colNOMBRE_AFP.Caption = "AFP"
        Me.colNOMBRE_AFP.FieldName = "NOMBRE_AFP"
        Me.colNOMBRE_AFP.Name = "colNOMBRE_AFP"
        Me.colNOMBRE_AFP.OptionsColumn.AllowEdit = False
        Me.colNOMBRE_AFP.Visible = True
        Me.colNOMBRE_AFP.VisibleIndex = 2
        Me.colNOMBRE_AFP.Width = 98
        '
        'colTASA_DESCUENTO
        '
        Me.colTASA_DESCUENTO.Caption = "Tasa Descto."
        Me.colTASA_DESCUENTO.DisplayFormat.FormatString = "n3"
        Me.colTASA_DESCUENTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTASA_DESCUENTO.FieldName = "TASA_DESCUENTO"
        Me.colTASA_DESCUENTO.Name = "colTASA_DESCUENTO"
        Me.colTASA_DESCUENTO.OptionsColumn.AllowEdit = False
        Me.colTASA_DESCUENTO.Visible = True
        Me.colTASA_DESCUENTO.VisibleIndex = 3
        Me.colTASA_DESCUENTO.Width = 76
        '
        'colDESCUENTO_LEY_19882
        '
        Me.colDESCUENTO_LEY_19882.Caption = "Ley 19882"
        Me.colDESCUENTO_LEY_19882.DisplayFormat.FormatString = "n3"
        Me.colDESCUENTO_LEY_19882.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDESCUENTO_LEY_19882.FieldName = "DESCUENTO_LEY_19882"
        Me.colDESCUENTO_LEY_19882.GroupFormat.FormatString = "n3"
        Me.colDESCUENTO_LEY_19882.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDESCUENTO_LEY_19882.Name = "colDESCUENTO_LEY_19882"
        Me.colDESCUENTO_LEY_19882.OptionsColumn.AllowEdit = False
        Me.colDESCUENTO_LEY_19882.Visible = True
        Me.colDESCUENTO_LEY_19882.VisibleIndex = 4
        Me.colDESCUENTO_LEY_19882.Width = 76
        '
        'colFECHA_AFILIACION_AFP
        '
        Me.colFECHA_AFILIACION_AFP.Caption = "Afiliación AFP"
        Me.colFECHA_AFILIACION_AFP.FieldName = "FECHA_AFILIACION_AFP"
        Me.colFECHA_AFILIACION_AFP.Name = "colFECHA_AFILIACION_AFP"
        Me.colFECHA_AFILIACION_AFP.OptionsColumn.AllowEdit = False
        Me.colFECHA_AFILIACION_AFP.Visible = True
        Me.colFECHA_AFILIACION_AFP.VisibleIndex = 5
        Me.colFECHA_AFILIACION_AFP.Width = 86
        '
        'colMONTO_AHORRO_AFP
        '
        Me.colMONTO_AHORRO_AFP.Caption = "Ahorro AFP"
        Me.colMONTO_AHORRO_AFP.DisplayFormat.FormatString = "n3"
        Me.colMONTO_AHORRO_AFP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_AHORRO_AFP.FieldName = "MONTO_AHORRO_AFP"
        Me.colMONTO_AHORRO_AFP.Name = "colMONTO_AHORRO_AFP"
        Me.colMONTO_AHORRO_AFP.OptionsColumn.AllowEdit = False
        Me.colMONTO_AHORRO_AFP.Visible = True
        Me.colMONTO_AHORRO_AFP.VisibleIndex = 6
        Me.colMONTO_AHORRO_AFP.Width = 88
        '
        'colMONTO_COTIZACION_VOLUNTARIA_AFP
        '
        Me.colMONTO_COTIZACION_VOLUNTARIA_AFP.Caption = "Cotiz.Vol.AFP"
        Me.colMONTO_COTIZACION_VOLUNTARIA_AFP.DisplayFormat.FormatString = "n3"
        Me.colMONTO_COTIZACION_VOLUNTARIA_AFP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_COTIZACION_VOLUNTARIA_AFP.FieldName = "MONTO_COTIZACION_VOLUNTARIA_AFP"
        Me.colMONTO_COTIZACION_VOLUNTARIA_AFP.Name = "colMONTO_COTIZACION_VOLUNTARIA_AFP"
        Me.colMONTO_COTIZACION_VOLUNTARIA_AFP.OptionsColumn.AllowEdit = False
        Me.colMONTO_COTIZACION_VOLUNTARIA_AFP.Visible = True
        Me.colMONTO_COTIZACION_VOLUNTARIA_AFP.VisibleIndex = 7
        Me.colMONTO_COTIZACION_VOLUNTARIA_AFP.Width = 77
        '
        'colNOMBRE_ISAPRE
        '
        Me.colNOMBRE_ISAPRE.Caption = "Isapre"
        Me.colNOMBRE_ISAPRE.FieldName = "NOMBRE_ISAPRE"
        Me.colNOMBRE_ISAPRE.Name = "colNOMBRE_ISAPRE"
        Me.colNOMBRE_ISAPRE.OptionsColumn.AllowEdit = False
        Me.colNOMBRE_ISAPRE.Visible = True
        Me.colNOMBRE_ISAPRE.VisibleIndex = 8
        Me.colNOMBRE_ISAPRE.Width = 86
        '
        'colFECHA_AFILIACION_ISAPRE
        '
        Me.colFECHA_AFILIACION_ISAPRE.Caption = "Afiliación Isapre"
        Me.colFECHA_AFILIACION_ISAPRE.FieldName = "FECHA_AFILIACION_ISAPRE"
        Me.colFECHA_AFILIACION_ISAPRE.Name = "colFECHA_AFILIACION_ISAPRE"
        Me.colFECHA_AFILIACION_ISAPRE.OptionsColumn.AllowEdit = False
        Me.colFECHA_AFILIACION_ISAPRE.Visible = True
        Me.colFECHA_AFILIACION_ISAPRE.VisibleIndex = 9
        Me.colFECHA_AFILIACION_ISAPRE.Width = 98
        '
        'colMONTO_ISAPRE
        '
        Me.colMONTO_ISAPRE.Caption = "Monto Pactado"
        Me.colMONTO_ISAPRE.DisplayFormat.FormatString = "n3"
        Me.colMONTO_ISAPRE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_ISAPRE.FieldName = "MONTO_ISAPRE"
        Me.colMONTO_ISAPRE.Name = "colMONTO_ISAPRE"
        Me.colMONTO_ISAPRE.OptionsColumn.AllowEdit = False
        Me.colMONTO_ISAPRE.Visible = True
        Me.colMONTO_ISAPRE.VisibleIndex = 10
        Me.colMONTO_ISAPRE.Width = 94
        '
        'colPLAN_COMPLEM_ISAPRE
        '
        Me.colPLAN_COMPLEM_ISAPRE.Caption = "Monto Complemen."
        Me.colPLAN_COMPLEM_ISAPRE.DisplayFormat.FormatString = "n3"
        Me.colPLAN_COMPLEM_ISAPRE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPLAN_COMPLEM_ISAPRE.FieldName = "PLAN_COMPLEM_ISAPRE"
        Me.colPLAN_COMPLEM_ISAPRE.Name = "colPLAN_COMPLEM_ISAPRE"
        Me.colPLAN_COMPLEM_ISAPRE.OptionsColumn.AllowEdit = False
        Me.colPLAN_COMPLEM_ISAPRE.Visible = True
        Me.colPLAN_COMPLEM_ISAPRE.VisibleIndex = 11
        Me.colPLAN_COMPLEM_ISAPRE.Width = 114
        '
        'colANTECEDENTE_PREVIS_ID
        '
        Me.colANTECEDENTE_PREVIS_ID.Caption = "Antecedente ID"
        Me.colANTECEDENTE_PREVIS_ID.FieldName = "ANTECEDENTE_PREVIS_ID"
        Me.colANTECEDENTE_PREVIS_ID.Name = "colANTECEDENTE_PREVIS_ID"
        Me.colANTECEDENTE_PREVIS_ID.OptionsColumn.AllowEdit = False
        Me.colANTECEDENTE_PREVIS_ID.OptionsColumn.ReadOnly = True
        '
        'colEMPLEADO_ID
        '
        Me.colEMPLEADO_ID.Caption = "Empleado ID"
        Me.colEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.colEMPLEADO_ID.Name = "colEMPLEADO_ID"
        Me.colEMPLEADO_ID.OptionsColumn.AllowEdit = False
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.gdcPrevision
        Me.GridView4.Name = "GridView4"
        '
        'xtpDatosAPV
        '
        Me.xtpDatosAPV.Controls.Add(Me.lblNombreDatosAPV)
        Me.xtpDatosAPV.Controls.Add(Me.lblMensajeAPV)
        Me.xtpDatosAPV.Controls.Add(Me.dgAntecedenteAPV)
        Me.xtpDatosAPV.Controls.Add(Me.gpcDetalleAPV)
        Me.xtpDatosAPV.Controls.Add(Me.btnGuardarAPV)
        Me.xtpDatosAPV.Name = "xtpDatosAPV"
        Me.xtpDatosAPV.Size = New System.Drawing.Size(1001, 648)
        Me.xtpDatosAPV.Text = "Datos APV"
        '
        'lblNombreDatosAPV
        '
        Me.lblNombreDatosAPV.AutoSize = True
        Me.lblNombreDatosAPV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDatosAPV.Location = New System.Drawing.Point(10, 10)
        Me.lblNombreDatosAPV.Name = "lblNombreDatosAPV"
        Me.lblNombreDatosAPV.Size = New System.Drawing.Size(90, 15)
        Me.lblNombreDatosAPV.TabIndex = 95
        Me.lblNombreDatosAPV.Text = "EMPLEADO: "
        '
        'lblMensajeAPV
        '
        Me.lblMensajeAPV.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMensajeAPV.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblMensajeAPV.Appearance.Options.UseFont = True
        Me.lblMensajeAPV.Appearance.Options.UseForeColor = True
        Me.lblMensajeAPV.Location = New System.Drawing.Point(907, 31)
        Me.lblMensajeAPV.Name = "lblMensajeAPV"
        Me.lblMensajeAPV.Size = New System.Drawing.Size(78, 13)
        Me.lblMensajeAPV.TabIndex = 49
        Me.lblMensajeAPV.Text = "LabelControl1"
        '
        'dgAntecedenteAPV
        '
        Me.dgAntecedenteAPV.EmbeddedNavigator.Enabled = False
        Me.dgAntecedenteAPV.Location = New System.Drawing.Point(15, 209)
        Me.dgAntecedenteAPV.MainView = Me.gvDetalleAPV
        Me.dgAntecedenteAPV.Name = "dgAntecedenteAPV"
        Me.dgAntecedenteAPV.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtMontoAhorro})
        Me.dgAntecedenteAPV.Size = New System.Drawing.Size(884, 198)
        Me.dgAntecedenteAPV.TabIndex = 0
        Me.dgAntecedenteAPV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetalleAPV, Me.GridView5})
        '
        'gvDetalleAPV
        '
        Me.gvDetalleAPV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NOMBRE_TIPO_APV, Me.EMPLEADO_ID, Me.TIPO_AHORRO_PREVISIONAL, Me.NOMBRE_APV, Me.APV_ID, Me.MONTO_AHORRO, Me.MONEDA_AHORRO_APV_ID, Me.NOMBRE_UNIDAD, Me.ANTECEDENTE_APV_ID})
        Me.gvDetalleAPV.CustomizationFormBounds = New System.Drawing.Rectangle(806, 469, 208, 170)
        Me.gvDetalleAPV.DetailHeight = 500
        Me.gvDetalleAPV.GridControl = Me.dgAntecedenteAPV
        Me.gvDetalleAPV.Name = "gvDetalleAPV"
        Me.gvDetalleAPV.NewItemRowText = "Nuevo Registro"
        Me.gvDetalleAPV.OptionsBehavior.SmartVertScrollBar = False
        Me.gvDetalleAPV.OptionsCustomization.AllowGroup = False
        Me.gvDetalleAPV.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvDetalleAPV.OptionsView.ColumnAutoWidth = False
        Me.gvDetalleAPV.OptionsView.ShowGroupPanel = False
        Me.gvDetalleAPV.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'NOMBRE_TIPO_APV
        '
        Me.NOMBRE_TIPO_APV.Caption = "Tipo Ahorro"
        Me.NOMBRE_TIPO_APV.FieldName = "NOMBRE_TIPO_APV"
        Me.NOMBRE_TIPO_APV.Name = "NOMBRE_TIPO_APV"
        Me.NOMBRE_TIPO_APV.OptionsColumn.AllowEdit = False
        Me.NOMBRE_TIPO_APV.OptionsColumn.ReadOnly = True
        Me.NOMBRE_TIPO_APV.Visible = True
        Me.NOMBRE_TIPO_APV.VisibleIndex = 0
        Me.NOMBRE_TIPO_APV.Width = 135
        '
        'EMPLEADO_ID
        '
        Me.EMPLEADO_ID.Caption = "Empleado ID"
        Me.EMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.EMPLEADO_ID.Name = "EMPLEADO_ID"
        Me.EMPLEADO_ID.OptionsColumn.AllowEdit = False
        Me.EMPLEADO_ID.OptionsColumn.ReadOnly = True
        '
        'TIPO_AHORRO_PREVISIONAL
        '
        Me.TIPO_AHORRO_PREVISIONAL.Caption = "ID Tipo AHorro"
        Me.TIPO_AHORRO_PREVISIONAL.DisplayFormat.FormatString = "n0"
        Me.TIPO_AHORRO_PREVISIONAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TIPO_AHORRO_PREVISIONAL.FieldName = "TIPO_AHORRO_PREVISIONAL"
        Me.TIPO_AHORRO_PREVISIONAL.Name = "TIPO_AHORRO_PREVISIONAL"
        Me.TIPO_AHORRO_PREVISIONAL.OptionsColumn.AllowEdit = False
        Me.TIPO_AHORRO_PREVISIONAL.OptionsColumn.ReadOnly = True
        Me.TIPO_AHORRO_PREVISIONAL.Width = 138
        '
        'NOMBRE_APV
        '
        Me.NOMBRE_APV.Caption = "Institución APV"
        Me.NOMBRE_APV.FieldName = "NOMBRE_APV"
        Me.NOMBRE_APV.Name = "NOMBRE_APV"
        Me.NOMBRE_APV.OptionsColumn.AllowEdit = False
        Me.NOMBRE_APV.OptionsColumn.ReadOnly = True
        Me.NOMBRE_APV.Visible = True
        Me.NOMBRE_APV.VisibleIndex = 1
        Me.NOMBRE_APV.Width = 135
        '
        'APV_ID
        '
        Me.APV_ID.Caption = "ID APV"
        Me.APV_ID.DisplayFormat.FormatString = "n0"
        Me.APV_ID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.APV_ID.FieldName = "APV_ID"
        Me.APV_ID.Name = "APV_ID"
        Me.APV_ID.OptionsColumn.AllowEdit = False
        Me.APV_ID.OptionsColumn.ReadOnly = True
        Me.APV_ID.Width = 171
        '
        'MONTO_AHORRO
        '
        Me.MONTO_AHORRO.Caption = "Monto Ahorro"
        Me.MONTO_AHORRO.ColumnEdit = Me.txtMontoAhorro
        Me.MONTO_AHORRO.DisplayFormat.FormatString = "n3"
        Me.MONTO_AHORRO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MONTO_AHORRO.FieldName = "MONTO_AHORRO"
        Me.MONTO_AHORRO.Name = "MONTO_AHORRO"
        Me.MONTO_AHORRO.OptionsColumn.AllowEdit = False
        Me.MONTO_AHORRO.OptionsColumn.ReadOnly = True
        Me.MONTO_AHORRO.Visible = True
        Me.MONTO_AHORRO.VisibleIndex = 2
        Me.MONTO_AHORRO.Width = 136
        '
        'txtMontoAhorro
        '
        Me.txtMontoAhorro.AutoHeight = False
        Me.txtMontoAhorro.DisplayFormat.FormatString = "n4"
        Me.txtMontoAhorro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoAhorro.EditFormat.FormatString = "n4"
        Me.txtMontoAhorro.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoAhorro.Mask.EditMask = "n4"
        Me.txtMontoAhorro.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoAhorro.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoAhorro.Name = "txtMontoAhorro"
        '
        'MONEDA_AHORRO_APV_ID
        '
        Me.MONEDA_AHORRO_APV_ID.Caption = "ID Tipo Unidad"
        Me.MONEDA_AHORRO_APV_ID.DisplayFormat.FormatString = "n0"
        Me.MONEDA_AHORRO_APV_ID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MONEDA_AHORRO_APV_ID.FieldName = "MONEDA_AHORRO_APV_ID"
        Me.MONEDA_AHORRO_APV_ID.Name = "MONEDA_AHORRO_APV_ID"
        Me.MONEDA_AHORRO_APV_ID.OptionsColumn.AllowEdit = False
        Me.MONEDA_AHORRO_APV_ID.OptionsColumn.ReadOnly = True
        Me.MONEDA_AHORRO_APV_ID.Width = 190
        '
        'NOMBRE_UNIDAD
        '
        Me.NOMBRE_UNIDAD.Caption = "Tipo Unidad"
        Me.NOMBRE_UNIDAD.FieldName = "NOMBRE_UNIDAD"
        Me.NOMBRE_UNIDAD.Name = "NOMBRE_UNIDAD"
        Me.NOMBRE_UNIDAD.OptionsColumn.AllowEdit = False
        Me.NOMBRE_UNIDAD.OptionsColumn.ReadOnly = True
        Me.NOMBRE_UNIDAD.Visible = True
        Me.NOMBRE_UNIDAD.VisibleIndex = 3
        Me.NOMBRE_UNIDAD.Width = 168
        '
        'ANTECEDENTE_APV_ID
        '
        Me.ANTECEDENTE_APV_ID.Caption = "ID Antecedente APV"
        Me.ANTECEDENTE_APV_ID.FieldName = "ANTECEDENTE_APV_ID"
        Me.ANTECEDENTE_APV_ID.Name = "ANTECEDENTE_APV_ID"
        Me.ANTECEDENTE_APV_ID.OptionsColumn.AllowEdit = False
        Me.ANTECEDENTE_APV_ID.OptionsColumn.ReadOnly = True
        '
        'GridView5
        '
        Me.GridView5.GridControl = Me.dgAntecedenteAPV
        Me.GridView5.Name = "GridView5"
        '
        'gpcDetalleAPV
        '
        Me.gpcDetalleAPV.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDetalleAPV.AppearanceCaption.Options.UseFont = True
        Me.gpcDetalleAPV.Controls.Add(Me.lueUnidadMontoAPV)
        Me.gpcDetalleAPV.Controls.Add(Me.lblTipoUnidad)
        Me.gpcDetalleAPV.Controls.Add(Me.txtMontoAPV)
        Me.gpcDetalleAPV.Controls.Add(Me.lblMontoAPV)
        Me.gpcDetalleAPV.Controls.Add(Me.lueAPV)
        Me.gpcDetalleAPV.Controls.Add(Me.lblInstitucionAPV)
        Me.gpcDetalleAPV.Controls.Add(Me.lblTipoAhorro)
        Me.gpcDetalleAPV.Controls.Add(Me.rdgTipoAhorro)
        Me.gpcDetalleAPV.Location = New System.Drawing.Point(13, 31)
        Me.gpcDetalleAPV.Name = "gpcDetalleAPV"
        Me.gpcDetalleAPV.Size = New System.Drawing.Size(888, 120)
        Me.gpcDetalleAPV.TabIndex = 92
        Me.gpcDetalleAPV.Text = "Detalle Ahorro Previsional Voluntario"
        '
        'lueUnidadMontoAPV
        '
        Me.lueUnidadMontoAPV.Location = New System.Drawing.Point(560, 80)
        Me.lueUnidadMontoAPV.Name = "lueUnidadMontoAPV"
        Me.lueUnidadMontoAPV.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueUnidadMontoAPV.Properties.NullText = ""
        Me.lueUnidadMontoAPV.Size = New System.Drawing.Size(120, 20)
        Me.lueUnidadMontoAPV.TabIndex = 12
        '
        'lblTipoUnidad
        '
        Me.lblTipoUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoUnidad.Location = New System.Drawing.Point(464, 80)
        Me.lblTipoUnidad.Name = "lblTipoUnidad"
        Me.lblTipoUnidad.Size = New System.Drawing.Size(88, 16)
        Me.lblTipoUnidad.TabIndex = 11
        Me.lblTipoUnidad.Text = "Tipo Unidad"
        Me.lblTipoUnidad.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMontoAPV
        '
        Me.txtMontoAPV.Location = New System.Drawing.Point(560, 40)
        Me.txtMontoAPV.Name = "txtMontoAPV"
        Me.txtMontoAPV.Properties.DisplayFormat.FormatString = "n4"
        Me.txtMontoAPV.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoAPV.Properties.EditFormat.FormatString = "n4"
        Me.txtMontoAPV.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoAPV.Properties.Mask.EditMask = "n4"
        Me.txtMontoAPV.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoAPV.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoAPV.Size = New System.Drawing.Size(120, 20)
        Me.txtMontoAPV.TabIndex = 10
        '
        'lblMontoAPV
        '
        Me.lblMontoAPV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoAPV.Location = New System.Drawing.Point(440, 40)
        Me.lblMontoAPV.Name = "lblMontoAPV"
        Me.lblMontoAPV.Size = New System.Drawing.Size(112, 16)
        Me.lblMontoAPV.TabIndex = 9
        Me.lblMontoAPV.Text = "Monto APV"
        Me.lblMontoAPV.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lueAPV
        '
        Me.lueAPV.Location = New System.Drawing.Point(152, 80)
        Me.lueAPV.Name = "lueAPV"
        Me.lueAPV.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAPV.Properties.NullText = ""
        Me.lueAPV.Size = New System.Drawing.Size(136, 20)
        Me.lueAPV.TabIndex = 8
        '
        'lblInstitucionAPV
        '
        Me.lblInstitucionAPV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstitucionAPV.Location = New System.Drawing.Point(8, 80)
        Me.lblInstitucionAPV.Name = "lblInstitucionAPV"
        Me.lblInstitucionAPV.Size = New System.Drawing.Size(136, 16)
        Me.lblInstitucionAPV.TabIndex = 7
        Me.lblInstitucionAPV.Text = "Institución APV"
        Me.lblInstitucionAPV.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTipoAhorro
        '
        Me.lblTipoAhorro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoAhorro.Location = New System.Drawing.Point(8, 40)
        Me.lblTipoAhorro.Name = "lblTipoAhorro"
        Me.lblTipoAhorro.Size = New System.Drawing.Size(136, 16)
        Me.lblTipoAhorro.TabIndex = 5
        Me.lblTipoAhorro.Text = "Tipo Ahorro"
        Me.lblTipoAhorro.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'rdgTipoAhorro
        '
        Me.rdgTipoAhorro.Location = New System.Drawing.Point(152, 32)
        Me.rdgTipoAhorro.Name = "rdgTipoAhorro"
        Me.rdgTipoAhorro.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.rdgTipoAhorro.Properties.Appearance.Options.UseFont = True
        Me.rdgTipoAhorro.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Ahorro Voluntario"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Depósito Convenido")})
        Me.rdgTipoAhorro.Size = New System.Drawing.Size(264, 32)
        Me.rdgTipoAhorro.TabIndex = 6
        '
        'btnGuardarAPV
        '
        Me.btnGuardarAPV.Location = New System.Drawing.Point(355, 163)
        Me.btnGuardarAPV.Name = "btnGuardarAPV"
        Me.btnGuardarAPV.Size = New System.Drawing.Size(112, 23)
        Me.btnGuardarAPV.TabIndex = 94
        Me.btnGuardarAPV.Text = "&Guardar"
        '
        'xtpDatosRemuneracion
        '
        Me.xtpDatosRemuneracion.Controls.Add(Me.lblNombreDatosRemuneracion)
        Me.xtpDatosRemuneracion.Controls.Add(Me.lblMensajeRemuneracion)
        Me.xtpDatosRemuneracion.Controls.Add(Me.gpcDatosAsignacionZona)
        Me.xtpDatosRemuneracion.Controls.Add(Me.lblNúmeroCuentaBanco)
        Me.xtpDatosRemuneracion.Controls.Add(Me.lblBanco)
        Me.xtpDatosRemuneracion.Controls.Add(Me.lblTipoCuentaBanco)
        Me.xtpDatosRemuneracion.Controls.Add(Me.lblFormaPago)
        Me.xtpDatosRemuneracion.Controls.Add(Me.lblAsociacionGremial)
        Me.xtpDatosRemuneracion.Controls.Add(Me.txtNumeroCuentaBanco)
        Me.xtpDatosRemuneracion.Controls.Add(Me.gpcDatosAsociacionGremial)
        Me.xtpDatosRemuneracion.Controls.Add(Me.lueTipoCuentaBanco)
        Me.xtpDatosRemuneracion.Controls.Add(Me.lueBanco)
        Me.xtpDatosRemuneracion.Controls.Add(Me.rdgFormaPago)
        Me.xtpDatosRemuneracion.Controls.Add(Me.gpcCargasFamiliares)
        Me.xtpDatosRemuneracion.Controls.Add(Me.gpcFormaPago)
        Me.xtpDatosRemuneracion.Controls.Add(Me.gpcMontosRemuneraciones)
        Me.xtpDatosRemuneracion.Controls.Add(Me.btnGuardarDatosRemuneracion)
        Me.xtpDatosRemuneracion.Controls.Add(Me.gpcDefinicionAsignaciones)
        Me.xtpDatosRemuneracion.Name = "xtpDatosRemuneracion"
        Me.xtpDatosRemuneracion.Size = New System.Drawing.Size(1001, 648)
        Me.xtpDatosRemuneracion.Text = "Datos Remuneración"
        '
        'lblNombreDatosRemuneracion
        '
        Me.lblNombreDatosRemuneracion.AutoSize = True
        Me.lblNombreDatosRemuneracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDatosRemuneracion.Location = New System.Drawing.Point(10, 10)
        Me.lblNombreDatosRemuneracion.Name = "lblNombreDatosRemuneracion"
        Me.lblNombreDatosRemuneracion.Size = New System.Drawing.Size(90, 15)
        Me.lblNombreDatosRemuneracion.TabIndex = 30
        Me.lblNombreDatosRemuneracion.Text = "EMPLEADO: "
        '
        'lblMensajeRemuneracion
        '
        Me.lblMensajeRemuneracion.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMensajeRemuneracion.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblMensajeRemuneracion.Appearance.Options.UseFont = True
        Me.lblMensajeRemuneracion.Appearance.Options.UseForeColor = True
        Me.lblMensajeRemuneracion.Location = New System.Drawing.Point(829, 31)
        Me.lblMensajeRemuneracion.Name = "lblMensajeRemuneracion"
        Me.lblMensajeRemuneracion.Size = New System.Drawing.Size(103, 13)
        Me.lblMensajeRemuneracion.TabIndex = 29
        Me.lblMensajeRemuneracion.Text = "lblMensajeLaboral"
        '
        'gpcDatosAsignacionZona
        '
        Me.gpcDatosAsignacionZona.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDatosAsignacionZona.AppearanceCaption.Options.UseFont = True
        Me.gpcDatosAsignacionZona.Controls.Add(Me.lueZona)
        Me.gpcDatosAsignacionZona.Controls.Add(Me.lblZona)
        Me.gpcDatosAsignacionZona.Location = New System.Drawing.Point(239, 31)
        Me.gpcDatosAsignacionZona.Name = "gpcDatosAsignacionZona"
        Me.gpcDatosAsignacionZona.Size = New System.Drawing.Size(174, 198)
        Me.gpcDatosAsignacionZona.TabIndex = 28
        Me.gpcDatosAsignacionZona.Text = "Asignación Zona"
        Me.gpcDatosAsignacionZona.Visible = False
        '
        'lueZona
        '
        Me.lueZona.Location = New System.Drawing.Point(5, 40)
        Me.lueZona.Name = "lueZona"
        Me.lueZona.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueZona.Properties.NullText = ""
        Me.lueZona.Size = New System.Drawing.Size(161, 20)
        Me.lueZona.TabIndex = 6
        '
        'lblZona
        '
        Me.lblZona.Location = New System.Drawing.Point(5, 25)
        Me.lblZona.Name = "lblZona"
        Me.lblZona.Size = New System.Drawing.Size(24, 13)
        Me.lblZona.TabIndex = 2
        Me.lblZona.Text = "Zona"
        '
        'lblNúmeroCuentaBanco
        '
        Me.lblNúmeroCuentaBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNúmeroCuentaBanco.Location = New System.Drawing.Point(437, 177)
        Me.lblNúmeroCuentaBanco.Name = "lblNúmeroCuentaBanco"
        Me.lblNúmeroCuentaBanco.Size = New System.Drawing.Size(136, 16)
        Me.lblNúmeroCuentaBanco.TabIndex = 21
        Me.lblNúmeroCuentaBanco.Text = "Número Cuenta Banco"
        Me.lblNúmeroCuentaBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBanco
        '
        Me.lblBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanco.Location = New System.Drawing.Point(525, 133)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(48, 16)
        Me.lblBanco.TabIndex = 20
        Me.lblBanco.Text = "Banco"
        Me.lblBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTipoCuentaBanco
        '
        Me.lblTipoCuentaBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoCuentaBanco.Location = New System.Drawing.Point(461, 155)
        Me.lblTipoCuentaBanco.Name = "lblTipoCuentaBanco"
        Me.lblTipoCuentaBanco.Size = New System.Drawing.Size(112, 16)
        Me.lblTipoCuentaBanco.TabIndex = 19
        Me.lblTipoCuentaBanco.Text = "Tipo Cuenta Banco"
        Me.lblTipoCuentaBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFormaPago
        '
        Me.lblFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormaPago.Location = New System.Drawing.Point(477, 63)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(100, 16)
        Me.lblFormaPago.TabIndex = 18
        Me.lblFormaPago.Text = "Forma de Pago"
        Me.lblFormaPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAsociacionGremial
        '
        Me.lblAsociacionGremial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsociacionGremial.Location = New System.Drawing.Point(19, 53)
        Me.lblAsociacionGremial.Name = "lblAsociacionGremial"
        Me.lblAsociacionGremial.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblAsociacionGremial.Size = New System.Drawing.Size(120, 16)
        Me.lblAsociacionGremial.TabIndex = 17
        Me.lblAsociacionGremial.Text = "Asociación Gremial"
        Me.lblAsociacionGremial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumeroCuentaBanco
        '
        Me.txtNumeroCuentaBanco.Location = New System.Drawing.Point(589, 173)
        Me.txtNumeroCuentaBanco.Name = "txtNumeroCuentaBanco"
        Me.txtNumeroCuentaBanco.Size = New System.Drawing.Size(202, 20)
        Me.txtNumeroCuentaBanco.TabIndex = 14
        '
        'gpcDatosAsociacionGremial
        '
        Me.gpcDatosAsociacionGremial.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDatosAsociacionGremial.AppearanceCaption.Options.UseFont = True
        Me.gpcDatosAsociacionGremial.Controls.Add(Me.dteFechaIngBienestar)
        Me.gpcDatosAsociacionGremial.Controls.Add(Me.lblFechaIngBienestar)
        Me.gpcDatosAsociacionGremial.Controls.Add(Me.dteFechaIngAsocGremial)
        Me.gpcDatosAsociacionGremial.Controls.Add(Me.lblFechaIngAsocGremial)
        Me.gpcDatosAsociacionGremial.Controls.Add(Me.lblFondoBienestar)
        Me.gpcDatosAsociacionGremial.Controls.Add(Me.rdgFondoBienestar)
        Me.gpcDatosAsociacionGremial.Controls.Add(Me.lueAsociacionGremial)
        Me.gpcDatosAsociacionGremial.Location = New System.Drawing.Point(13, 31)
        Me.gpcDatosAsociacionGremial.Name = "gpcDatosAsociacionGremial"
        Me.gpcDatosAsociacionGremial.Size = New System.Drawing.Size(220, 198)
        Me.gpcDatosAsociacionGremial.TabIndex = 23
        Me.gpcDatosAsociacionGremial.Text = "Datos Asociación Gremial"
        '
        'dteFechaIngBienestar
        '
        Me.dteFechaIngBienestar.EditValue = Nothing
        Me.dteFechaIngBienestar.Location = New System.Drawing.Point(8, 170)
        Me.dteFechaIngBienestar.Name = "dteFechaIngBienestar"
        Me.dteFechaIngBienestar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaIngBienestar.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteFechaIngBienestar.Size = New System.Drawing.Size(172, 20)
        Me.dteFechaIngBienestar.TabIndex = 21
        '
        'lblFechaIngBienestar
        '
        Me.lblFechaIngBienestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngBienestar.Location = New System.Drawing.Point(8, 154)
        Me.lblFechaIngBienestar.Name = "lblFechaIngBienestar"
        Me.lblFechaIngBienestar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFechaIngBienestar.Size = New System.Drawing.Size(168, 16)
        Me.lblFechaIngBienestar.TabIndex = 20
        Me.lblFechaIngBienestar.Text = "Fecha Ingreso a Bienestar"
        Me.lblFechaIngBienestar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dteFechaIngAsocGremial
        '
        Me.dteFechaIngAsocGremial.EditValue = Nothing
        Me.dteFechaIngAsocGremial.Location = New System.Drawing.Point(8, 78)
        Me.dteFechaIngAsocGremial.Name = "dteFechaIngAsocGremial"
        Me.dteFechaIngAsocGremial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaIngAsocGremial.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteFechaIngAsocGremial.Size = New System.Drawing.Size(176, 20)
        Me.dteFechaIngAsocGremial.TabIndex = 19
        '
        'lblFechaIngAsocGremial
        '
        Me.lblFechaIngAsocGremial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngAsocGremial.Location = New System.Drawing.Point(6, 60)
        Me.lblFechaIngAsocGremial.Name = "lblFechaIngAsocGremial"
        Me.lblFechaIngAsocGremial.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFechaIngAsocGremial.Size = New System.Drawing.Size(168, 16)
        Me.lblFechaIngAsocGremial.TabIndex = 18
        Me.lblFechaIngAsocGremial.Text = "Fecha Ingreso Asoc.Gremial"
        Me.lblFechaIngAsocGremial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFondoBienestar
        '
        Me.lblFondoBienestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFondoBienestar.Location = New System.Drawing.Point(8, 104)
        Me.lblFondoBienestar.Name = "lblFondoBienestar"
        Me.lblFondoBienestar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFondoBienestar.Size = New System.Drawing.Size(96, 16)
        Me.lblFondoBienestar.TabIndex = 16
        Me.lblFondoBienestar.Text = "Fondo Bienestar"
        Me.lblFondoBienestar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rdgFondoBienestar
        '
        Me.rdgFondoBienestar.Location = New System.Drawing.Point(8, 122)
        Me.rdgFondoBienestar.Name = "rdgFondoBienestar"
        Me.rdgFondoBienestar.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "No Afiliado"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Afiliado")})
        Me.rdgFondoBienestar.Size = New System.Drawing.Size(172, 28)
        Me.rdgFondoBienestar.TabIndex = 15
        '
        'lueAsociacionGremial
        '
        Me.lueAsociacionGremial.Location = New System.Drawing.Point(6, 40)
        Me.lueAsociacionGremial.Name = "lueAsociacionGremial"
        Me.lueAsociacionGremial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAsociacionGremial.Properties.NullText = ""
        Me.lueAsociacionGremial.Size = New System.Drawing.Size(178, 20)
        Me.lueAsociacionGremial.TabIndex = 5
        '
        'lueTipoCuentaBanco
        '
        Me.lueTipoCuentaBanco.Location = New System.Drawing.Point(589, 151)
        Me.lueTipoCuentaBanco.Name = "lueTipoCuentaBanco"
        Me.lueTipoCuentaBanco.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTipoCuentaBanco.Properties.NullText = ""
        Me.lueTipoCuentaBanco.Size = New System.Drawing.Size(202, 20)
        Me.lueTipoCuentaBanco.TabIndex = 12
        '
        'lueBanco
        '
        Me.lueBanco.Location = New System.Drawing.Point(589, 129)
        Me.lueBanco.Name = "lueBanco"
        Me.lueBanco.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueBanco.Properties.NullText = ""
        Me.lueBanco.Size = New System.Drawing.Size(202, 20)
        Me.lueBanco.TabIndex = 10
        '
        'rdgFormaPago
        '
        Me.rdgFormaPago.Location = New System.Drawing.Point(589, 63)
        Me.rdgFormaPago.Name = "rdgFormaPago"
        Me.rdgFormaPago.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Cheque"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Efectivo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Depósito Cuenta Banco")})
        Me.rdgFormaPago.Size = New System.Drawing.Size(204, 64)
        Me.rdgFormaPago.TabIndex = 8
        '
        'gpcCargasFamiliares
        '
        Me.gpcCargasFamiliares.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcCargasFamiliares.AppearanceCaption.Options.UseFont = True
        Me.gpcCargasFamiliares.Controls.Add(Me.speCargaFamPreNatal)
        Me.gpcCargasFamiliares.Controls.Add(Me.lblCargaFamPreNatal)
        Me.gpcCargasFamiliares.Controls.Add(Me.speCargaFamInvalidez)
        Me.gpcCargasFamiliares.Controls.Add(Me.lblCargaFamInvalidez)
        Me.gpcCargasFamiliares.Controls.Add(Me.speCargaFamNormal)
        Me.gpcCargasFamiliares.Controls.Add(Me.lueTramoCargaFamiliar)
        Me.gpcCargasFamiliares.Controls.Add(Me.lblCargaFamNormal)
        Me.gpcCargasFamiliares.Controls.Add(Me.lblTramoAsignacionFam)
        Me.gpcCargasFamiliares.Location = New System.Drawing.Point(421, 233)
        Me.gpcCargasFamiliares.Name = "gpcCargasFamiliares"
        Me.gpcCargasFamiliares.Size = New System.Drawing.Size(402, 126)
        Me.gpcCargasFamiliares.TabIndex = 25
        Me.gpcCargasFamiliares.Text = "Cargas Familiares"
        '
        'speCargaFamPreNatal
        '
        Me.speCargaFamPreNatal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.speCargaFamPreNatal.Enabled = False
        Me.speCargaFamPreNatal.Location = New System.Drawing.Point(176, 98)
        Me.speCargaFamPreNatal.Name = "speCargaFamPreNatal"
        Me.speCargaFamPreNatal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.speCargaFamPreNatal.Properties.MaxLength = 2
        Me.speCargaFamPreNatal.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.speCargaFamPreNatal.Size = New System.Drawing.Size(48, 20)
        Me.speCargaFamPreNatal.TabIndex = 34
        '
        'lblCargaFamPreNatal
        '
        Me.lblCargaFamPreNatal.BackColor = System.Drawing.Color.Transparent
        Me.lblCargaFamPreNatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargaFamPreNatal.ForeColor = System.Drawing.Color.Black
        Me.lblCargaFamPreNatal.Location = New System.Drawing.Point(168, 76)
        Me.lblCargaFamPreNatal.Name = "lblCargaFamPreNatal"
        Me.lblCargaFamPreNatal.Size = New System.Drawing.Size(72, 16)
        Me.lblCargaFamPreNatal.TabIndex = 33
        Me.lblCargaFamPreNatal.Text = "Pre-Natales"
        Me.lblCargaFamPreNatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'speCargaFamInvalidez
        '
        Me.speCargaFamInvalidez.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.speCargaFamInvalidez.Enabled = False
        Me.speCargaFamInvalidez.Location = New System.Drawing.Point(90, 98)
        Me.speCargaFamInvalidez.Name = "speCargaFamInvalidez"
        Me.speCargaFamInvalidez.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.speCargaFamInvalidez.Properties.MaxLength = 2
        Me.speCargaFamInvalidez.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.speCargaFamInvalidez.Size = New System.Drawing.Size(48, 20)
        Me.speCargaFamInvalidez.TabIndex = 32
        '
        'lblCargaFamInvalidez
        '
        Me.lblCargaFamInvalidez.BackColor = System.Drawing.Color.Transparent
        Me.lblCargaFamInvalidez.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargaFamInvalidez.ForeColor = System.Drawing.Color.Black
        Me.lblCargaFamInvalidez.Location = New System.Drawing.Point(84, 76)
        Me.lblCargaFamInvalidez.Name = "lblCargaFamInvalidez"
        Me.lblCargaFamInvalidez.Size = New System.Drawing.Size(60, 16)
        Me.lblCargaFamInvalidez.TabIndex = 31
        Me.lblCargaFamInvalidez.Text = "Invalidez"
        Me.lblCargaFamInvalidez.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'speCargaFamNormal
        '
        Me.speCargaFamNormal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.speCargaFamNormal.Enabled = False
        Me.speCargaFamNormal.Location = New System.Drawing.Point(14, 98)
        Me.speCargaFamNormal.Name = "speCargaFamNormal"
        Me.speCargaFamNormal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.speCargaFamNormal.Properties.MaxLength = 2
        Me.speCargaFamNormal.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.speCargaFamNormal.Size = New System.Drawing.Size(48, 20)
        Me.speCargaFamNormal.TabIndex = 30
        '
        'lueTramoCargaFamiliar
        '
        Me.lueTramoCargaFamiliar.Location = New System.Drawing.Point(8, 46)
        Me.lueTramoCargaFamiliar.Name = "lueTramoCargaFamiliar"
        Me.lueTramoCargaFamiliar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTramoCargaFamiliar.Properties.NullText = ""
        Me.lueTramoCargaFamiliar.Size = New System.Drawing.Size(310, 20)
        Me.lueTramoCargaFamiliar.TabIndex = 28
        '
        'lblCargaFamNormal
        '
        Me.lblCargaFamNormal.BackColor = System.Drawing.Color.Transparent
        Me.lblCargaFamNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargaFamNormal.ForeColor = System.Drawing.Color.Black
        Me.lblCargaFamNormal.Location = New System.Drawing.Point(10, 76)
        Me.lblCargaFamNormal.Name = "lblCargaFamNormal"
        Me.lblCargaFamNormal.Size = New System.Drawing.Size(58, 16)
        Me.lblCargaFamNormal.TabIndex = 29
        Me.lblCargaFamNormal.Text = "Normales"
        Me.lblCargaFamNormal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTramoAsignacionFam
        '
        Me.lblTramoAsignacionFam.BackColor = System.Drawing.Color.Transparent
        Me.lblTramoAsignacionFam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTramoAsignacionFam.ForeColor = System.Drawing.Color.Black
        Me.lblTramoAsignacionFam.Location = New System.Drawing.Point(8, 24)
        Me.lblTramoAsignacionFam.Name = "lblTramoAsignacionFam"
        Me.lblTramoAsignacionFam.Size = New System.Drawing.Size(152, 16)
        Me.lblTramoAsignacionFam.TabIndex = 27
        Me.lblTramoAsignacionFam.Text = "Tramo Asignación Familiar"
        Me.lblTramoAsignacionFam.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gpcFormaPago
        '
        Me.gpcFormaPago.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcFormaPago.AppearanceCaption.Options.UseFont = True
        Me.gpcFormaPago.Controls.Add(Me.btnDetallePresupuestoAnualHonorario)
        Me.gpcFormaPago.Location = New System.Drawing.Point(423, 31)
        Me.gpcFormaPago.Name = "gpcFormaPago"
        Me.gpcFormaPago.Size = New System.Drawing.Size(400, 198)
        Me.gpcFormaPago.TabIndex = 22
        Me.gpcFormaPago.Text = "Condiciones de Pago"
        '
        'btnDetallePresupuestoAnualHonorario
        '
        Me.btnDetallePresupuestoAnualHonorario.Location = New System.Drawing.Point(72, 166)
        Me.btnDetallePresupuestoAnualHonorario.Name = "btnDetallePresupuestoAnualHonorario"
        Me.btnDetallePresupuestoAnualHonorario.Size = New System.Drawing.Size(226, 23)
        Me.btnDetallePresupuestoAnualHonorario.TabIndex = 28
        Me.btnDetallePresupuestoAnualHonorario.Text = "&Detalle Presupuesto Anual Honorario"
        '
        'gpcMontosRemuneraciones
        '
        Me.gpcMontosRemuneraciones.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcMontosRemuneraciones.AppearanceCaption.Options.UseFont = True
        Me.gpcMontosRemuneraciones.Controls.Add(Me.chkAsignaLey18675Art11)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.txtMontoAsignacionZona)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.lblAsignacionZona)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.GroupBox1)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.lblIncrementoPrevDL3501)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.txtIncrementoPrevisDL3501)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.lblLey3551)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.txtMontoLey3551)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.lblGastoRepresentacion)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.txtGastoRepresentacion)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.txtLey18566)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.lblLey18566)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.txtLey18675Art11)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.txtLey18675Art10)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.txtLey18717)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.lblLey18717)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.lblLey18675Art11)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.lblLey18675Art10)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.gpbLineaHorizontal)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.lblLey19185)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.txtMontoLey19185Art18)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.txtMontoAsigResponsabilidadSuperior)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.txtMontoLey19185Art19)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.txtMontoSueldoBase)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.txtMontoRentaBase)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.lblMontoRentaBase)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.lblMontoAsigRespon)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.lblMontoAsigProfesional)
        Me.gpcMontosRemuneraciones.Controls.Add(Me.lblMontoSueldoBase)
        Me.gpcMontosRemuneraciones.Location = New System.Drawing.Point(13, 361)
        Me.gpcMontosRemuneraciones.Name = "gpcMontosRemuneraciones"
        Me.gpcMontosRemuneraciones.Size = New System.Drawing.Size(810, 226)
        Me.gpcMontosRemuneraciones.TabIndex = 26
        Me.gpcMontosRemuneraciones.Text = "Montos Remuneraciones"
        '
        'chkAsignaLey18675Art11
        '
        Me.chkAsignaLey18675Art11.AutoSize = True
        Me.chkAsignaLey18675Art11.Location = New System.Drawing.Point(272, 136)
        Me.chkAsignaLey18675Art11.Name = "chkAsignaLey18675Art11"
        Me.chkAsignaLey18675Art11.Size = New System.Drawing.Size(67, 19)
        Me.chkAsignaLey18675Art11.TabIndex = 39
        Me.chkAsignaLey18675Art11.Text = "Asignar"
        Me.chkAsignaLey18675Art11.UseVisualStyleBackColor = True
        '
        'txtMontoAsignacionZona
        '
        Me.txtMontoAsignacionZona.Location = New System.Drawing.Point(40, 188)
        Me.txtMontoAsignacionZona.Name = "txtMontoAsignacionZona"
        Me.txtMontoAsignacionZona.Properties.Mask.EditMask = "n0"
        Me.txtMontoAsignacionZona.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoAsignacionZona.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoAsignacionZona.Properties.ReadOnly = True
        Me.txtMontoAsignacionZona.Size = New System.Drawing.Size(96, 20)
        Me.txtMontoAsignacionZona.TabIndex = 38
        Me.txtMontoAsignacionZona.ToolTip = "Asignación zona extrema"
        Me.txtMontoAsignacionZona.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'lblAsignacionZona
        '
        Me.lblAsignacionZona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsignacionZona.Location = New System.Drawing.Point(37, 169)
        Me.lblAsignacionZona.Name = "lblAsignacionZona"
        Me.lblAsignacionZona.Size = New System.Drawing.Size(102, 16)
        Me.lblAsignacionZona.TabIndex = 37
        Me.lblAsignacionZona.Text = "Asignación Zona"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(5, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 10)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'lblIncrementoPrevDL3501
        '
        Me.lblIncrementoPrevDL3501.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncrementoPrevDL3501.Location = New System.Drawing.Point(630, 92)
        Me.lblIncrementoPrevDL3501.Name = "lblIncrementoPrevDL3501"
        Me.lblIncrementoPrevDL3501.Size = New System.Drawing.Size(136, 16)
        Me.lblIncrementoPrevDL3501.TabIndex = 35
        Me.lblIncrementoPrevDL3501.Text = "Increm.Previs.DL 3501"
        '
        'txtIncrementoPrevisDL3501
        '
        Me.txtIncrementoPrevisDL3501.Location = New System.Drawing.Point(644, 110)
        Me.txtIncrementoPrevisDL3501.Name = "txtIncrementoPrevisDL3501"
        Me.txtIncrementoPrevisDL3501.Properties.Mask.EditMask = "n0"
        Me.txtIncrementoPrevisDL3501.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIncrementoPrevisDL3501.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtIncrementoPrevisDL3501.Properties.ReadOnly = True
        Me.txtIncrementoPrevisDL3501.Size = New System.Drawing.Size(96, 20)
        Me.txtIncrementoPrevisDL3501.TabIndex = 34
        Me.txtIncrementoPrevisDL3501.ToolTip = "Asignación Incremento Previsional DL 3501"
        Me.txtIncrementoPrevisDL3501.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'lblLey3551
        '
        Me.lblLey3551.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLey3551.Location = New System.Drawing.Point(524, 90)
        Me.lblLey3551.Name = "lblLey3551"
        Me.lblLey3551.Size = New System.Drawing.Size(70, 16)
        Me.lblLey3551.TabIndex = 33
        Me.lblLey3551.Text = "Ley 3.551"
        '
        'txtMontoLey3551
        '
        Me.txtMontoLey3551.Location = New System.Drawing.Point(514, 110)
        Me.txtMontoLey3551.Name = "txtMontoLey3551"
        Me.txtMontoLey3551.Properties.Mask.EditMask = "n0"
        Me.txtMontoLey3551.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoLey3551.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoLey3551.Properties.ReadOnly = True
        Me.txtMontoLey3551.Size = New System.Drawing.Size(96, 20)
        Me.txtMontoLey3551.TabIndex = 32
        Me.txtMontoLey3551.ToolTip = "Asignación Ley 3551"
        Me.txtMontoLey3551.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'lblGastoRepresentacion
        '
        Me.lblGastoRepresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGastoRepresentacion.Location = New System.Drawing.Point(630, 32)
        Me.lblGastoRepresentacion.Name = "lblGastoRepresentacion"
        Me.lblGastoRepresentacion.Size = New System.Drawing.Size(128, 16)
        Me.lblGastoRepresentacion.TabIndex = 31
        Me.lblGastoRepresentacion.Text = "Gasto Representación"
        '
        'txtGastoRepresentacion
        '
        Me.txtGastoRepresentacion.Location = New System.Drawing.Point(644, 50)
        Me.txtGastoRepresentacion.Name = "txtGastoRepresentacion"
        Me.txtGastoRepresentacion.Properties.Mask.EditMask = "n0"
        Me.txtGastoRepresentacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtGastoRepresentacion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtGastoRepresentacion.Properties.ReadOnly = True
        Me.txtGastoRepresentacion.Size = New System.Drawing.Size(96, 20)
        Me.txtGastoRepresentacion.TabIndex = 30
        Me.txtGastoRepresentacion.ToolTip = "Asignación por gasto de representación"
        Me.txtGastoRepresentacion.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'txtLey18566
        '
        Me.txtLey18566.Location = New System.Drawing.Point(394, 110)
        Me.txtLey18566.Name = "txtLey18566"
        Me.txtLey18566.Properties.Mask.EditMask = "n0"
        Me.txtLey18566.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtLey18566.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtLey18566.Properties.ReadOnly = True
        Me.txtLey18566.Size = New System.Drawing.Size(96, 20)
        Me.txtLey18566.TabIndex = 29
        Me.txtLey18566.ToolTip = "Bonoficación compensatoria salud"
        Me.txtLey18566.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'lblLey18566
        '
        Me.lblLey18566.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLey18566.Location = New System.Drawing.Point(408, 92)
        Me.lblLey18566.Name = "lblLey18566"
        Me.lblLey18566.Size = New System.Drawing.Size(70, 16)
        Me.lblLey18566.TabIndex = 28
        Me.lblLey18566.Text = "Ley 18.566"
        '
        'txtLey18675Art11
        '
        Me.txtLey18675Art11.Location = New System.Drawing.Point(272, 110)
        Me.txtLey18675Art11.Name = "txtLey18675Art11"
        Me.txtLey18675Art11.Properties.Mask.EditMask = "n0"
        Me.txtLey18675Art11.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtLey18675Art11.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtLey18675Art11.Properties.ReadOnly = True
        Me.txtLey18675Art11.Size = New System.Drawing.Size(96, 20)
        Me.txtLey18675Art11.TabIndex = 27
        Me.txtLey18675Art11.ToolTip = "Bonoficación compensatoria pensiones en INP"
        Me.txtLey18675Art11.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'txtLey18675Art10
        '
        Me.txtLey18675Art10.Location = New System.Drawing.Point(152, 110)
        Me.txtLey18675Art10.Name = "txtLey18675Art10"
        Me.txtLey18675Art10.Properties.Mask.EditMask = "n0"
        Me.txtLey18675Art10.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtLey18675Art10.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtLey18675Art10.Properties.ReadOnly = True
        Me.txtLey18675Art10.Size = New System.Drawing.Size(96, 20)
        Me.txtLey18675Art10.TabIndex = 26
        Me.txtLey18675Art10.ToolTip = "Bonoficación compensatoria pensiones en AFP"
        Me.txtLey18675Art10.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'txtLey18717
        '
        Me.txtLey18717.Location = New System.Drawing.Point(40, 110)
        Me.txtLey18717.Name = "txtLey18717"
        Me.txtLey18717.Properties.Mask.EditMask = "n0"
        Me.txtLey18717.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtLey18717.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtLey18717.Properties.ReadOnly = True
        Me.txtLey18717.Size = New System.Drawing.Size(96, 20)
        Me.txtLey18717.TabIndex = 25
        Me.txtLey18717.ToolTip = "Asignación ley 18.717"
        Me.txtLey18717.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'lblLey18717
        '
        Me.lblLey18717.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLey18717.Location = New System.Drawing.Point(54, 90)
        Me.lblLey18717.Name = "lblLey18717"
        Me.lblLey18717.Size = New System.Drawing.Size(74, 16)
        Me.lblLey18717.TabIndex = 24
        Me.lblLey18717.Text = "Ley 18.717"
        '
        'lblLey18675Art11
        '
        Me.lblLey18675Art11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLey18675Art11.Location = New System.Drawing.Point(272, 90)
        Me.lblLey18675Art11.Name = "lblLey18675Art11"
        Me.lblLey18675Art11.Size = New System.Drawing.Size(102, 16)
        Me.lblLey18675Art11.TabIndex = 23
        Me.lblLey18675Art11.Text = "Ley 18.675 Art.11"
        '
        'lblLey18675Art10
        '
        Me.lblLey18675Art10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLey18675Art10.Location = New System.Drawing.Point(154, 90)
        Me.lblLey18675Art10.Name = "lblLey18675Art10"
        Me.lblLey18675Art10.Size = New System.Drawing.Size(102, 16)
        Me.lblLey18675Art10.TabIndex = 22
        Me.lblLey18675Art10.Text = "Ley 18.675 Art.10"
        '
        'gpbLineaHorizontal
        '
        Me.gpbLineaHorizontal.Location = New System.Drawing.Point(2, 76)
        Me.gpbLineaHorizontal.Name = "gpbLineaHorizontal"
        Me.gpbLineaHorizontal.Size = New System.Drawing.Size(804, 4)
        Me.gpbLineaHorizontal.TabIndex = 21
        Me.gpbLineaHorizontal.TabStop = False
        '
        'lblLey19185
        '
        Me.lblLey19185.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLey19185.Location = New System.Drawing.Point(514, 30)
        Me.lblLey19185.Name = "lblLey19185"
        Me.lblLey19185.Size = New System.Drawing.Size(102, 16)
        Me.lblLey19185.TabIndex = 20
        Me.lblLey19185.Text = "Ley 19.185 Art.18"
        '
        'txtMontoLey19185Art18
        '
        Me.txtMontoLey19185Art18.Location = New System.Drawing.Point(514, 50)
        Me.txtMontoLey19185Art18.Name = "txtMontoLey19185Art18"
        Me.txtMontoLey19185Art18.Properties.Mask.EditMask = "n0"
        Me.txtMontoLey19185Art18.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoLey19185Art18.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoLey19185Art18.Properties.ReadOnly = True
        Me.txtMontoLey19185Art18.Size = New System.Drawing.Size(96, 20)
        Me.txtMontoLey19185Art18.TabIndex = 19
        Me.txtMontoLey19185Art18.ToolTip = "Asignación según clasificación empleado"
        Me.txtMontoLey19185Art18.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'txtMontoAsigResponsabilidadSuperior
        '
        Me.txtMontoAsigResponsabilidadSuperior.Location = New System.Drawing.Point(394, 50)
        Me.txtMontoAsigResponsabilidadSuperior.Name = "txtMontoAsigResponsabilidadSuperior"
        Me.txtMontoAsigResponsabilidadSuperior.Properties.Mask.EditMask = "n0"
        Me.txtMontoAsigResponsabilidadSuperior.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoAsigResponsabilidadSuperior.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoAsigResponsabilidadSuperior.Properties.ReadOnly = True
        Me.txtMontoAsigResponsabilidadSuperior.Size = New System.Drawing.Size(96, 20)
        Me.txtMontoAsigResponsabilidadSuperior.TabIndex = 18
        Me.txtMontoAsigResponsabilidadSuperior.ToolTip = "Asignación de responsabilidad superior"
        Me.txtMontoAsigResponsabilidadSuperior.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'txtMontoLey19185Art19
        '
        Me.txtMontoLey19185Art19.Location = New System.Drawing.Point(272, 50)
        Me.txtMontoLey19185Art19.Name = "txtMontoLey19185Art19"
        Me.txtMontoLey19185Art19.Properties.Mask.EditMask = "n0"
        Me.txtMontoLey19185Art19.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoLey19185Art19.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoLey19185Art19.Properties.ReadOnly = True
        Me.txtMontoLey19185Art19.Size = New System.Drawing.Size(96, 20)
        Me.txtMontoLey19185Art19.TabIndex = 17
        Me.txtMontoLey19185Art19.ToolTip = "Asignación profesional"
        Me.txtMontoLey19185Art19.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'txtMontoSueldoBase
        '
        Me.txtMontoSueldoBase.Location = New System.Drawing.Point(152, 50)
        Me.txtMontoSueldoBase.Name = "txtMontoSueldoBase"
        Me.txtMontoSueldoBase.Properties.Mask.EditMask = "n0"
        Me.txtMontoSueldoBase.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoSueldoBase.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoSueldoBase.Properties.ReadOnly = True
        Me.txtMontoSueldoBase.Size = New System.Drawing.Size(96, 20)
        Me.txtMontoSueldoBase.TabIndex = 16
        Me.txtMontoSueldoBase.ToolTip = "Sueldo base empleado según grado"
        Me.txtMontoSueldoBase.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'txtMontoRentaBase
        '
        Me.txtMontoRentaBase.Location = New System.Drawing.Point(40, 50)
        Me.txtMontoRentaBase.Name = "txtMontoRentaBase"
        Me.txtMontoRentaBase.Properties.Mask.EditMask = "n0"
        Me.txtMontoRentaBase.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoRentaBase.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoRentaBase.Properties.ReadOnly = True
        Me.txtMontoRentaBase.Size = New System.Drawing.Size(96, 20)
        Me.txtMontoRentaBase.TabIndex = 35
        Me.txtMontoRentaBase.ToolTip = "Renta bruta honorarios"
        Me.txtMontoRentaBase.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'lblMontoRentaBase
        '
        Me.lblMontoRentaBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoRentaBase.Location = New System.Drawing.Point(54, 30)
        Me.lblMontoRentaBase.Name = "lblMontoRentaBase"
        Me.lblMontoRentaBase.Size = New System.Drawing.Size(74, 16)
        Me.lblMontoRentaBase.TabIndex = 8
        Me.lblMontoRentaBase.Text = "Renta Base"
        '
        'lblMontoAsigRespon
        '
        Me.lblMontoAsigRespon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoAsigRespon.Location = New System.Drawing.Point(394, 30)
        Me.lblMontoAsigRespon.Name = "lblMontoAsigRespon"
        Me.lblMontoAsigRespon.Size = New System.Drawing.Size(96, 16)
        Me.lblMontoAsigRespon.TabIndex = 7
        Me.lblMontoAsigRespon.Text = "Responsab.Sup."
        '
        'lblMontoAsigProfesional
        '
        Me.lblMontoAsigProfesional.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoAsigProfesional.Location = New System.Drawing.Point(270, 30)
        Me.lblMontoAsigProfesional.Name = "lblMontoAsigProfesional"
        Me.lblMontoAsigProfesional.Size = New System.Drawing.Size(102, 16)
        Me.lblMontoAsigProfesional.TabIndex = 6
        Me.lblMontoAsigProfesional.Text = "Ley 19.185 Art.19"
        '
        'lblMontoSueldoBase
        '
        Me.lblMontoSueldoBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoSueldoBase.Location = New System.Drawing.Point(162, 30)
        Me.lblMontoSueldoBase.Name = "lblMontoSueldoBase"
        Me.lblMontoSueldoBase.Size = New System.Drawing.Size(78, 16)
        Me.lblMontoSueldoBase.TabIndex = 5
        Me.lblMontoSueldoBase.Text = "Sueldo Base"
        '
        'btnGuardarDatosRemuneracion
        '
        Me.btnGuardarDatosRemuneracion.Location = New System.Drawing.Point(391, 593)
        Me.btnGuardarDatosRemuneracion.Name = "btnGuardarDatosRemuneracion"
        Me.btnGuardarDatosRemuneracion.Size = New System.Drawing.Size(112, 23)
        Me.btnGuardarDatosRemuneracion.TabIndex = 27
        Me.btnGuardarDatosRemuneracion.Text = "&Guardar"
        '
        'gpcDefinicionAsignaciones
        '
        Me.gpcDefinicionAsignaciones.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDefinicionAsignaciones.AppearanceCaption.Options.UseFont = True
        Me.gpcDefinicionAsignaciones.Controls.Add(Me.memObservacionesBienio)
        Me.gpcDefinicionAsignaciones.Controls.Add(Me.chkEntregoBoletaHonorario)
        Me.gpcDefinicionAsignaciones.Controls.Add(Me.txtPorcentajeLey19863)
        Me.gpcDefinicionAsignaciones.Controls.Add(Me.lblPorcentajeLey19863)
        Me.gpcDefinicionAsignaciones.Controls.Add(Me.txtMontoFuncionCritica)
        Me.gpcDefinicionAsignaciones.Controls.Add(Me.lblMontoFuncionCritica)
        Me.gpcDefinicionAsignaciones.Controls.Add(Me.dteFechaCumplioBienio)
        Me.gpcDefinicionAsignaciones.Controls.Add(Me.lblFechaCimplioBienio)
        Me.gpcDefinicionAsignaciones.Controls.Add(Me.speNumeroBienios)
        Me.gpcDefinicionAsignaciones.Controls.Add(Me.lblNumeroBienios)
        Me.gpcDefinicionAsignaciones.Location = New System.Drawing.Point(13, 233)
        Me.gpcDefinicionAsignaciones.Name = "gpcDefinicionAsignaciones"
        Me.gpcDefinicionAsignaciones.Size = New System.Drawing.Size(400, 126)
        Me.gpcDefinicionAsignaciones.TabIndex = 24
        Me.gpcDefinicionAsignaciones.Text = "Definiciones de asignaciones"
        '
        'memObservacionesBienio
        '
        Me.memObservacionesBienio.Location = New System.Drawing.Point(240, 30)
        Me.memObservacionesBienio.Name = "memObservacionesBienio"
        Me.memObservacionesBienio.Properties.ReadOnly = True
        Me.memObservacionesBienio.Size = New System.Drawing.Size(152, 64)
        Me.memObservacionesBienio.TabIndex = 28
        '
        'chkEntregoBoletaHonorario
        '
        Me.chkEntregoBoletaHonorario.EditValue = True
        Me.chkEntregoBoletaHonorario.Location = New System.Drawing.Point(242, 100)
        Me.chkEntregoBoletaHonorario.Name = "chkEntregoBoletaHonorario"
        Me.chkEntregoBoletaHonorario.Properties.Caption = "Entregó Boleta Honorario"
        Me.chkEntregoBoletaHonorario.Size = New System.Drawing.Size(144, 19)
        Me.chkEntregoBoletaHonorario.TabIndex = 27
        '
        'txtPorcentajeLey19863
        '
        Me.txtPorcentajeLey19863.EnterMoveNextControl = True
        Me.txtPorcentajeLey19863.Location = New System.Drawing.Point(120, 100)
        Me.txtPorcentajeLey19863.Name = "txtPorcentajeLey19863"
        Me.txtPorcentajeLey19863.Properties.DisplayFormat.FormatString = "P0"
        Me.txtPorcentajeLey19863.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorcentajeLey19863.Properties.EditFormat.FormatString = "P0"
        Me.txtPorcentajeLey19863.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorcentajeLey19863.Properties.Mask.EditMask = "P0"
        Me.txtPorcentajeLey19863.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPorcentajeLey19863.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPorcentajeLey19863.Properties.MaxLength = 3
        Me.txtPorcentajeLey19863.Properties.ValidateOnEnterKey = True
        Me.txtPorcentajeLey19863.Size = New System.Drawing.Size(100, 20)
        Me.txtPorcentajeLey19863.TabIndex = 26
        '
        'lblPorcentajeLey19863
        '
        Me.lblPorcentajeLey19863.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentajeLey19863.Location = New System.Drawing.Point(16, 104)
        Me.lblPorcentajeLey19863.Name = "lblPorcentajeLey19863"
        Me.lblPorcentajeLey19863.Size = New System.Drawing.Size(96, 14)
        Me.lblPorcentajeLey19863.TabIndex = 25
        Me.lblPorcentajeLey19863.Text = "% Ley 19.863"
        Me.lblPorcentajeLey19863.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMontoFuncionCritica
        '
        Me.txtMontoFuncionCritica.Location = New System.Drawing.Point(120, 74)
        Me.txtMontoFuncionCritica.Name = "txtMontoFuncionCritica"
        Me.txtMontoFuncionCritica.Properties.DisplayFormat.FormatString = "n0"
        Me.txtMontoFuncionCritica.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoFuncionCritica.Properties.EditFormat.FormatString = "n0"
        Me.txtMontoFuncionCritica.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoFuncionCritica.Properties.Mask.EditMask = "n0"
        Me.txtMontoFuncionCritica.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoFuncionCritica.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoFuncionCritica.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoFuncionCritica.TabIndex = 24
        '
        'lblMontoFuncionCritica
        '
        Me.lblMontoFuncionCritica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoFuncionCritica.Location = New System.Drawing.Point(12, 78)
        Me.lblMontoFuncionCritica.Name = "lblMontoFuncionCritica"
        Me.lblMontoFuncionCritica.Size = New System.Drawing.Size(100, 14)
        Me.lblMontoFuncionCritica.TabIndex = 23
        Me.lblMontoFuncionCritica.Text = "$ Función Crítica"
        Me.lblMontoFuncionCritica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dteFechaCumplioBienio
        '
        Me.dteFechaCumplioBienio.EditValue = Nothing
        Me.dteFechaCumplioBienio.Location = New System.Drawing.Point(120, 50)
        Me.dteFechaCumplioBienio.Name = "dteFechaCumplioBienio"
        Me.dteFechaCumplioBienio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaCumplioBienio.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteFechaCumplioBienio.Size = New System.Drawing.Size(100, 20)
        Me.dteFechaCumplioBienio.TabIndex = 22
        '
        'lblFechaCimplioBienio
        '
        Me.lblFechaCimplioBienio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaCimplioBienio.Location = New System.Drawing.Point(14, 54)
        Me.lblFechaCimplioBienio.Name = "lblFechaCimplioBienio"
        Me.lblFechaCimplioBienio.Size = New System.Drawing.Size(98, 14)
        Me.lblFechaCimplioBienio.TabIndex = 21
        Me.lblFechaCimplioBienio.Text = "Fecha Bienio"
        Me.lblFechaCimplioBienio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'speNumeroBienios
        '
        Me.speNumeroBienios.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.speNumeroBienios.Location = New System.Drawing.Point(120, 26)
        Me.speNumeroBienios.Name = "speNumeroBienios"
        Me.speNumeroBienios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.speNumeroBienios.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.speNumeroBienios.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.speNumeroBienios.Properties.MaxLength = 2
        Me.speNumeroBienios.Properties.MaxValue = New Decimal(New Integer() {15, 0, 0, 0})
        Me.speNumeroBienios.Size = New System.Drawing.Size(48, 20)
        Me.speNumeroBienios.TabIndex = 20
        '
        'lblNumeroBienios
        '
        Me.lblNumeroBienios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroBienios.Location = New System.Drawing.Point(16, 30)
        Me.lblNumeroBienios.Name = "lblNumeroBienios"
        Me.lblNumeroBienios.Size = New System.Drawing.Size(96, 14)
        Me.lblNumeroBienios.TabIndex = 19
        Me.lblNumeroBienios.Text = "# Bienios"
        Me.lblNumeroBienios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3})
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuListadoPersonal, Me.mnuRptFichaEmpleado, Me.mnuLstAntiguedad})
        Me.MenuItem3.Text = "Informes"
        '
        'mnuListadoPersonal
        '
        Me.mnuListadoPersonal.Index = 0
        Me.mnuListadoPersonal.Text = "Listado de Empleados"
        '
        'mnuRptFichaEmpleado
        '
        Me.mnuRptFichaEmpleado.Index = 1
        Me.mnuRptFichaEmpleado.Text = "Ficha del Empleado"
        '
        'mnuLstAntiguedad
        '
        Me.mnuLstAntiguedad.Index = 2
        Me.mnuLstAntiguedad.Text = "Listado de Empleados Años de Antigüedad"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Estado"
        Me.GridColumn1.FieldName = "ESTADO_REGISTRO"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 62
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Ing.Sistema Prev"
        Me.GridColumn2.FieldName = "FECHA_ING_SISTEMA_PREVIS"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 112
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "AFP"
        Me.GridColumn3.FieldName = "NOMBRE_AFP"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 98
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Tasa Descto."
        Me.GridColumn4.DisplayFormat.FormatString = "n3"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "TASA_DESCUENTO"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 76
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Ley 19882"
        Me.GridColumn5.DisplayFormat.FormatString = "n3"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "DESCUENTO_LEY_19882"
        Me.GridColumn5.GroupFormat.FormatString = "n3"
        Me.GridColumn5.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 76
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Afiliación AFP"
        Me.GridColumn6.FieldName = "FECHA_AFILIACION_AFP"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 86
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Ahorro AFP"
        Me.GridColumn7.DisplayFormat.FormatString = "n3"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "MONTO_AHORRO_AFP"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 88
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Cotiz.Vol.AFP"
        Me.GridColumn8.DisplayFormat.FormatString = "n3"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "MONTO_COTIZACION_VOLUNTARIA_AFP"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        Me.GridColumn8.Width = 77
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Isapre"
        Me.GridColumn9.FieldName = "NOMBRE_ISAPRE"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        Me.GridColumn9.Width = 86
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Afiliación Isapre"
        Me.GridColumn10.FieldName = "FECHA_AFILIACION_ISAPRE"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        Me.GridColumn10.Width = 98
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Monto Pactado"
        Me.GridColumn11.DisplayFormat.FormatString = "n3"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "MONTO_ISAPRE"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 10
        Me.GridColumn11.Width = 94
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Monto Complemen."
        Me.GridColumn12.DisplayFormat.FormatString = "n3"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "PLAN_COMPLEM_ISAPRE"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 11
        Me.GridColumn12.Width = 114
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Antecedente ID"
        Me.GridColumn13.FieldName = "ANTECEDENTE_PREVIS_ID"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Empleado ID"
        Me.GridColumn14.FieldName = "EMPLEADO_ID"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        '
        'frmFichaEmpleado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1008, 678)
        Me.Controls.Add(Me.xtcFichaEmpleado)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu = Me.MainMenu1
        Me.Name = "frmFichaEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.xtcFichaEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcFichaEmpleado.ResumeLayout(False)
        Me.xtpDatosPersonales.ResumeLayout(False)
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbEstadoEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcComandos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcComandos.ResumeLayout(False)
        Me.gpbFotoEmpleado.ResumeLayout(False)
        CType(Me.picEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDatosEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatosEmpleado.ResumeLayout(False)
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbEstadoCivil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaNacimiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaNacimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbNivelEstudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEdad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgSexo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoMaterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leRut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleRut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoPaterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpDireccionParticular.ResumeLayout(False)
        Me.xtpDireccionParticular.PerformLayout()
        CType(Me.gpcComandosDatosContacto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcComandosDatosContacto.ResumeLayout(False)
        CType(Me.cbbPais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDomicilio.ResumeLayout(False)
        CType(Me.txtCodigoPostal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCalle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbRegion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefonoParticular.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCelular.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVillaPoblacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbCiudad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbComuna.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpDatosGenerales.ResumeLayout(False)
        Me.xtpDatosGenerales.PerformLayout()
        CType(Me.gpcComandosDatosGenerales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcComandosDatosGenerales.ResumeLayout(False)
        Me.grpDatosGenerales.ResumeLayout(False)
        CType(Me.txtFonoContactoEmergencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMedicamentosContraindicados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEnfermedadCronica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlergias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGrupoSanguineo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMatriculaMilitar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServicioMilitar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFonoAnexo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpDatosLaborales.ResumeLayout(False)
        Me.xtpDatosLaborales.PerformLayout()
        CType(Me.gpcSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeguridad.ResumeLayout(False)
        Me.gpcSeguridad.PerformLayout()
        CType(Me.txtNumeroAcceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcComandosDatosLaborales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcComandosDatosLaborales.ResumeLayout(False)
        CType(Me.gpcAntecedenteWeb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcAntecedenteWeb.ResumeLayout(False)
        CType(Me.txtTituloProfesionalExpertiz.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFuncionDesempeno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPublicaDatos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDatosContractuales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatosContractuales.ResumeLayout(False)
        CType(Me.dedFechaIngresoCalidadJuridica.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaIngresoCalidadJuridica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCalJur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaAsignacionGrado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbEscalafon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbGrado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbClasificacionEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaIngInstitucion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaIngInstitucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaIngAdmPublica.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaIngAdmPublica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDatosRetiroEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatosRetiroEmpleado.ResumeLayout(False)
        CType(Me.txtResolucionRetiro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbMotivoRetiro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaRetiro.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaRetiro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDatosResolucion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatosResolucion.ResumeLayout(False)
        CType(Me.txtNroResolucionContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaResolucion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaResolucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcInformacionContractualGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcInformacionContractualGeneral.ResumeLayout(False)
        CType(Me.chkIncluirParaEvaluacionDesempeño.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbJefeEvalDesempeno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTipoBeneficiario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbEstamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbHorarioTrabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbUbicacionFisica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbJefeDirecto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpEstructuraOrganizacional.ResumeLayout(False)
        Me.xtpEstructuraOrganizacional.PerformLayout()
        CType(Me.gdcEstructuraContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleEstructuraContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcOrganigrama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcOrganigrama.ResumeLayout(False)
        Me.gcOrganigrama.PerformLayout()
        CType(Me.lueSubDepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueAutorizadorHorasExtras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueEvaluadorDesempeno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcEstructuraOrganica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvEstructuraOrganica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueInstitucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCentrosCostos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcCentrosCostos.ResumeLayout(False)
        Me.gcCentrosCostos.PerformLayout()
        CType(Me.txtPorcentajeDistribucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCentroCostoPresupuesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCentroCostoContable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpDatosPrevisionales.ResumeLayout(False)
        Me.xtpDatosPrevisionales.PerformLayout()
        CType(Me.gpcDatosFondoPenciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatosFondoPenciones.ResumeLayout(False)
        CType(Me.deeAfpFechaFun.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deeAfpFechaFun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFondoE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAfpNroFun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFondoD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFondoC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFondoB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFondoA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueUnidadCotizacionVol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueUnidadAhorroAfp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueAfp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoCotizacionVoluntaria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoAhorroAfp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaAfiliacionPrevisional.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaAfiliacionPrevisional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaIngsistemaPrev.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaIngsistemaPrev.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDatosSaludPrevisional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatosSaludPrevisional.ResumeLayout(False)
        CType(Me.deeIsapreFechaFun.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deeIsapreFechaFun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIsapreNroFun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTipoTrabajadorPrevired.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueUnidadMontoPlanAuge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoPlanAuge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueUnidadMontoPlanComplementario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueUnidadMontoConvenio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueIsapre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoPlanComplementario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoConvenio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaAfiliacionSalud.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaAfiliacionSalud.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDetallePrevisional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDetallePrevisional.ResumeLayout(False)
        CType(Me.gdcPrevision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetallePrevision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpDatosAPV.ResumeLayout(False)
        Me.xtpDatosAPV.PerformLayout()
        CType(Me.dgAntecedenteAPV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalleAPV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoAhorro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDetalleAPV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDetalleAPV.ResumeLayout(False)
        CType(Me.lueUnidadMontoAPV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoAPV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueAPV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgTipoAhorro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpDatosRemuneracion.ResumeLayout(False)
        Me.xtpDatosRemuneracion.PerformLayout()
        CType(Me.gpcDatosAsignacionZona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatosAsignacionZona.ResumeLayout(False)
        Me.gpcDatosAsignacionZona.PerformLayout()
        CType(Me.lueZona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroCuentaBanco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDatosAsociacionGremial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatosAsociacionGremial.ResumeLayout(False)
        CType(Me.dteFechaIngBienestar.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaIngBienestar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaIngAsocGremial.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaIngAsocGremial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgFondoBienestar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueAsociacionGremial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTipoCuentaBanco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBanco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcCargasFamiliares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcCargasFamiliares.ResumeLayout(False)
        CType(Me.speCargaFamPreNatal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.speCargaFamInvalidez.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.speCargaFamNormal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTramoCargaFamiliar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcFormaPago.ResumeLayout(False)
        CType(Me.gpcMontosRemuneraciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcMontosRemuneraciones.ResumeLayout(False)
        Me.gpcMontosRemuneraciones.PerformLayout()
        CType(Me.txtMontoAsignacionZona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIncrementoPrevisDL3501.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoLey3551.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGastoRepresentacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLey18566.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLey18675Art11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLey18675Art10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLey18717.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoLey19185Art18.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoAsigResponsabilidadSuperior.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoLey19185Art19.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoSueldoBase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoRentaBase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDefinicionAsignaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDefinicionAsignaciones.ResumeLayout(False)
        CType(Me.memObservacionesBienio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEntregoBoletaHonorario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentajeLey19863.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoFuncionCritica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaCumplioBienio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaCumplioBienio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.speNumeroBienios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvNivelEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private empleado As Empleado
    Private parametroMensual As Periodo
    Private edicion As Boolean = False
    Private generaAsignaciones As Boolean = True
    Private numeroBieniosOld As Integer

#Region "Llenado Controles"
    Private Sub frmAntecedentePersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Debe limpiar los controles en pantalla y establecer empleado en nueva instancia
        If EsFichaHistorica Then
            lblPeriodo.Visible = True
            luePeriodo.Visible = True
        Else
            lblPeriodo.Visible = False
            luePeriodo.Visible = False
            lblMensajeContacto.Visible = False
            lblMensajeGeneral.Visible = False
            lblMensajeLaboral.Visible = False
            lblMensajeEstruOrgannica.Visible = False
            lblMensajeEstruOrgannica.Visible = False
            lblMensajeAPV.Visible = False
            lblMensajePrevisional.Visible = False
            lblMensajeRemuneracion.Visible = False
        End If
        repositorio.Show()
        desactivaTabsAntecedentesAdicionales()
        empleado = New Empleado
        parametroMensual = New Periodo
        empleado.organizacion = Comun.ArgoConfiguracion.OrganizacionID
        btnGuardar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnGuardaryConservar.Enabled = False
        txtDV.Enabled = False
        txtPorcentajeDistribucion.Text = 100
        LlenadoDeControles()
        repositorio.RefreshDatos()
        initCampoRut()
        estableceControlesSegunPermisos()

        'agregado por segegob
        gpcDatosAsignacionZona.Visible = parametroMensual.aplicaAsignacionZona

    End Sub

    Private Sub estableceControlesSegunPermisos()
        '****************************************************
        'Establecimiento de Permisos
        '****************************************************
        If cl.presidencia.Argo.Comun.ArgoConfiguracion.tieneActiveDirectory = "False" Then
            Exit Sub
        End If
        'Por defecto ningún grupo tiene acceso al TAB de Remuneraciones
        gpcMontosRemuneraciones.Visible = False
        gpcMontosRemuneraciones.Visible = Seguridad.TienePermiso("PER-Ficha de Empleados-Con Montos")
        'El Número de Acceso lo define exclusivamente Control de Acceso (Seguridad)
        gpcSeguridad.Enabled = False

        'Si tienePermiso es verdad entonces pertenece al grupo de solo lectura 
        'de datos de personal, por lo tanto, no se le permite guardar datos.
        If Seguridad.TienePermiso("PER-Solo Lectura - Consulta Personal") Then
            'Se ocultan todos los botones que permiten operaciones
            gpcComandos.Visible = False
            gpcComandosDatosContacto.Visible = False
            gpcComandosDatosLaborales.Visible = False
            gpcComandosDatosGenerales.Visible = False
            btnConfirmarFotografia.Visible = False

            xtcFichaEmpleado.TabPages(0).PageEnabled = True
            xtcFichaEmpleado.TabPages(1).PageEnabled = True
            xtcFichaEmpleado.TabPages(2).PageEnabled = True
            xtcFichaEmpleado.TabPages(3).PageEnabled = True
            xtcFichaEmpleado.TabPages(4).PageEnabled = False
            xtcFichaEmpleado.TabPages(5).PageEnabled = False
            xtcFichaEmpleado.TabPages(6).PageEnabled = False
            xtcFichaEmpleado.TabPages(7).PageEnabled = False
        End If

        'Definición de Accesos para grupo de Control de Acceso (Seguridad)
        If Seguridad.TienePermiso("PER-Seguridad") Then
            'Se ocultan todos los botones que permiten operaciones
            gpcComandos.Visible = False
            gpcComandosDatosContacto.Visible = False
            gpcComandosDatosLaborales.Visible = True
            gpcComandosDatosGenerales.Visible = False
            btnConfirmarFotografia.Visible = False

            xtcFichaEmpleado.TabPages(0).PageEnabled = True
            xtcFichaEmpleado.TabPages(1).PageEnabled = True
            xtcFichaEmpleado.TabPages(2).PageEnabled = True
            xtcFichaEmpleado.TabPages(3).PageEnabled = True
            'Datos Laborales
            gpcDatosContractuales.Enabled = False
            gpcDatosRetiroEmpleado.Enabled = False
            gpcDatosResolucion.Enabled = False
            gpcInformacionContractualGeneral.Enabled = False
            gpcAntecedenteWeb.Enabled = False
            gpcSeguridad.Enabled = True

            xtcFichaEmpleado.TabPages(4).PageEnabled = False
            xtcFichaEmpleado.TabPages(5).PageEnabled = False
            xtcFichaEmpleado.TabPages(6).PageEnabled = False
            xtcFichaEmpleado.TabPages(7).PageEnabled = False

            generaAsignaciones = False
        End If

        '***************************************************
        'Fin Establecimiento de Permisos
        '***************************************************
        If EsFichaHistorica Then
            btnGuardar.Enabled = False
            btnGuardarAPV.Enabled = False
            btnGuardarDatosContacto.Enabled = False
            btnGuardarDatosGenerales.Enabled = False
            btnGuardarDatosLaborales.Enabled = False
            btnGuardarDatosPrevisionales.Enabled = False
            btnGuardarDatosRemuneracion.Enabled = False
            btnGuardarEstrucOrg.Enabled = False
            btnGuardarEstructuraContable.Enabled = False
            btnNuevo.Enabled = False
            btnEliminar.Enabled = False
        End If
    End Sub

    Sub ResetControls(ByVal ParamArray ctls() As Control)
        ' clear input control
        Dim ctl As Control
        Try
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
                ElseIf TypeOf (ctl) Is DevExpress.XtraEditors.RadioGroup Then
                    CType(ctl, DevExpress.XtraEditors.RadioGroup).SelectedIndex = -1
                ElseIf TypeOf (ctl) Is DevExpress.XtraEditors.LookUpEdit Then
                    CType(ctl, DevExpress.XtraEditors.LookUpEdit).EditValue = -1
                ElseIf TypeOf (ctl) Is DevExpress.XtraEditors.DateEdit Then
                    CType(ctl, DevExpress.XtraEditors.DateEdit).DateTime = Now()
                ElseIf TypeOf (ctl) Is DevExpress.XtraEditors.TextEdit Then
                    CType(ctl, DevExpress.XtraEditors.TextEdit).Text = ""
                ElseIf TypeOf (ctl) Is DevExpress.XtraEditors.CheckEdit Then
                    CType(ctl, DevExpress.XtraEditors.CheckEdit).Checked = False
                ElseIf TypeOf (ctl) Is DevExpress.XtraGrid.GridControl Then
                    CType(ctl, DevExpress.XtraGrid.GridControl).DataSource = Nothing

                    ' Note: to add support for more controls just add more ElseIf blocks
                End If
                ' clear all child controls, if any
                Dim c As Control
                For Each c In ctl.Controls
                    ResetControls(c)
                Next
            Next
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try

    End Sub


    Private Sub BloquearComandos()
        Dim Estado As Boolean
        If (empleado.estado = Comun.TiposDeDatos.TipoEstado.INACTIVO) Then
            Estado = False
        Else
            Estado = True
        End If

        btnGuardarDatosContacto.Enabled = Estado

        btnGuardar.Enabled = Estado
        btnEliminar.Enabled = Estado

        btnGuardarDatosGenerales.Enabled = Estado

        btnGuardaryConservar.Enabled = Estado
        btnGuardarRegistroActual.Enabled = Estado

        btnGuardarDatosRemuneracion.Enabled = Estado

    End Sub
    Private Sub llenarOrganizacion()
        Comun.Utiles.fillLookUpEdit(Me.lueInstitucion, _
                                    (cl.presidencia.Argo.Comun.Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_ORGANIZACION, _
                                    Comun.Tablas.RH_PER_DIRECCION, "DESCRIPCION", "ORGANIZACION_ID", _
                                    cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)), "DESCRIPCION", "ORGANIZACION_ID")
    End Sub
    Private Sub llenarDireccion()
        Comun.Utiles.fillLookUpEdit(lueDireccion, _
                                    (cl.presidencia.Argo.Comun.Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_DIRECCION, _
                                    Comun.Tablas.RH_PER_DIRECCION, "DESCRIPCION", "DIRECCION_ID", _
                                    cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)), "DESCRIPCION", "DIRECCION_ID")
    End Sub
    Private Sub llenarDepartamento()
        Comun.Utiles.fillLookUpEdit(lueDepartamento, _
                                    (cl.presidencia.Argo.Comun.Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_DEPARTAMENTO, _
                                    Comun.Tablas.RH_PER_DEPARTAMENTO, "DESCRIPCION", "DEPTO_ID", _
                                    cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)), "DESCRIPCION", "DEPTO_ID")
    End Sub
    Private Sub llenarSubDepartamento()
        Comun.Utiles.fillLookUpEdit(lueSubDepto, _
                                    (cl.presidencia.Argo.Comun.Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_SUB_DEPARTAMENTO, _
                                    Comun.Tablas.RH_PER_SUB_DEPARTAMENTO, "DESCRIPCION", "SUB_DEPTO_ID", _
                                    cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)), "DESCRIPCION", "SUB_DEPTO_ID")
    End Sub

    Private Sub llenarCentroCostoContable()
        Comun.Utiles.fillLookUpEdit(lueCentroCostoContable, _
                                    (cl.presidencia.Argo.Comun.Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_CENTRO_COSTO_CONTABLE, _
                                    Comun.Tablas.RH_REM_CENTRO_COSTO_CONTABLE, "DESCRIPCION", "CENTRO_COSTO_CONTAB_ID", _
                                    cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)), "DESCRIPCION", "CENTRO_COSTO_CONTAB_ID")
    End Sub
    Private Sub llenarCentroCostoPresupuesto()
        Comun.Utiles.fillLookUpEdit(lueCentroCostoPresupuesto, _
                                    (cl.presidencia.Argo.Comun.Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_CENTRO_COSTO_PRESUPUESTO, _
                                    Comun.Tablas.RH_REM_CENTRO_COSTO_PRESUPUESTO, "DESCRIPCION", "CENTRO_COSTO_PRESUP_ID", _
                                    cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)), "DESCRIPCION", "CENTRO_COSTO_PRESUP_ID")
    End Sub

    Private Sub LlenarEmpleados()
        If EsFichaHistorica = True And luePeriodo.EditValue = Nothing Then
            Exit Sub
        End If
        lueEmpleado.Properties.Columns.Clear()
        With lueEmpleado
            With .Properties.Columns
                .Add(New LookUpColumnInfo("EMPLEADO_ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("NOMBRE_COMPLETO", "Nombre Empleado", 400, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        If EsFichaHistorica = True Then
            lueEmpleado.Properties.DataSource = empleado.recuperaEmpleadoFichaHistorica(luePeriodo.EditValue) 'leRut.Properties.DataSource 'empleado.recuperaEmpleadoFichaHistorica(luePeriodo.EditValue)
        Else
            lueEmpleado.Properties.DataSource = repositorio.dvEmpleadoFichaHistorica 'repositorio.dvEmpleadoVista
        End If
        'lueEmpleado.Properties.DataSource = repositorio.dvPeriodoFichaHistorica
        lueEmpleado.Properties.DisplayMember = "NOMBRE_COMPLETO"
        lueEmpleado.Properties.NullText = ""
        lueEmpleado.Properties.PopupWidth = 600
        lueEmpleado.Properties.ValueMember = "EMPLEADO_ID"
    End Sub

    Private Sub llenarPeriodos()
        With luePeriodo
            With .Properties.Columns
                .Add(New LookUpColumnInfo("PERIODO_ID", "ID Periodo", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ANO", "Año", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("MES", "Mes", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ESTADO_PERIODO", "Estado Periodo", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION_PERIODO", "Periodo", 40, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        luePeriodo.Properties.DataSource = repositorio.dvPeriodoFichaHistorica
        luePeriodo.Properties.DisplayMember = "DESCRIPCION_PERIODO"
        luePeriodo.Properties.NullText = ""
        luePeriodo.Properties.PopupWidth = 150
        luePeriodo.Properties.ValueMember = "PERIODO_ID"
    End Sub

    Private Sub llenarEstructuraOrganica()
        llenarOrganizacion()
        llenarDireccion()
        llenarDepartamento()
        llenarSubDepartamento()
        llenarCentroCostoContable()
        llenarCentroCostoPresupuesto()
        llenarAutorizadorHorasExtras()
        llenarEvaluadorDesempeno()
    End Sub
    Private Sub llenarDatosLaborales()
        llenarCalidadJuridica()
        llenarEstamento()
        llenarGrado()
        llenarEscalafon()
        llenarMotivoRetiro()
        llenarJefeDirecto()
        llenarJefeEvaluador()
        llenarUbicacionFisica()
        llenarHorarioTrabrajo()
        llenarClasificacionEmpleado()
        llenarTipoBeneficiario()
        'agregado por segegob
        llenarZonas()
    End Sub
    Private Sub llenarEstadoCivil()
        Dim Coll As ComboBoxItemCollection = Me.cbbEstadoCivil.Properties.Items
        Coll.BeginUpdate()
        Try
            Coll.Add(New Comun.DatoLista("SOLTERO", 1))
            Coll.Add(New Comun.DatoLista("CASADO", 2))
            Coll.Add(New Comun.DatoLista("VIUDO", 3))
            Coll.Add(New Comun.DatoLista("DIVORCIADO", 4))
        Finally
            Coll.EndUpdate()
        End Try
        Me.cbbEstadoCivil.SelectedIndex = -1
    End Sub

    Private Sub llenarNivelEstudios()
        Dim da As SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
        Dim ds As New DataSet

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT NIVEL_ESTUDIO_ID,NIVEL_ESTUDIO_ALIAS,DESCRIPCION FROM RH_PER_NIVEL_ESTUDIO WHERE APLICA_ANTECEDENTE_CURRICULAR=1 ORDER BY DESCRIPCION", conn))
        da.Fill(ds, Tablas.RH_PER_NIVEL_ESTUDIO)
        Dim dvmNivelEstudio As New DataViewManager(ds)
        dvNivelEstudios = dvmNivelEstudio.CreateDataView(ds.Tables(Tablas.RH_PER_NIVEL_ESTUDIO))

        cbbNivelEstudio.Properties.DataSource = dvNivelEstudios
        cbbNivelEstudio.Properties.DisplayMember = "DESCRIPCION"
        cbbNivelEstudio.Properties.NullText = ""
        cbbNivelEstudio.Properties.PopupWidth = 200
        cbbNivelEstudio.Properties.ValueMember = "NIVEL_ESTUDIO_ID"
        cbbNivelEstudio.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        With cbbNivelEstudio
            With .Properties.Columns
                .Add(New LookUpColumnInfo("NIVEL_ESTUDIO_ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
            .EditValue = Convert.ToInt32(0)
        End With
    End Sub

    Private Sub llenarLocalidad()
        Comun.Utiles.fillComboBoxEdit(cbbPais, repositorio.dvPaises, "DESCRIPCION", "PAIS_ID")
        Comun.Utiles.fillComboBoxEdit(cbbRegion, repositorio.dvRegiones, "DESCRIPCION", "REGION_ID")
        Comun.Utiles.fillComboBoxEdit(cbbComuna, repositorio.dvComunas, "DESCRIPCION", "COMUNA_ID")
        Comun.Utiles.fillComboBoxEdit(cbbCiudad, repositorio.dvCiudades, "DESCRIPCION", "CIUDAD_ID")

    End Sub

    Public Sub llenarEstadoEmpleado()
        Comun.Utiles.fillComboBoxEdit(cbbEstadoEmpleado, repositorio.dvEstadoEmpleados, "DESCRIPCION", "ESTADO_EMPLEADO_ID")
    End Sub
    Public Sub llenarCalidadJuridica()
        lueCalJur.Properties.DataSource = repositorio.dvCalidadJuridica
        lueCalJur.Properties.DisplayMember = "DESCRIPCION"
        lueCalJur.Properties.NullText = ""
        lueCalJur.Properties.PopupWidth = 200
        lueCalJur.Properties.ValueMember = "CALIDAD_JURIDICA_ID"
        lueCalJur.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        With lueCalJur
            With .Properties.Columns
                .Add(New LookUpColumnInfo("CALIDAD_JURIDICA_ID", "ID", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
            .EditValue = Convert.ToInt32(0)
        End With
    End Sub
    Public Sub llenarEstamento()
        With cbbEstamento
            With .Properties.Columns
                .Add(New LookUpColumnInfo("ESTAMENTO_ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        cbbEstamento.Properties.DataSource = repositorio.dvEstamento
        cbbEstamento.Properties.DisplayMember = "DESCRIPCION"
        cbbEstamento.Properties.NullText = ""
        cbbEstamento.Properties.PopupWidth = 200
        cbbEstamento.Properties.ValueMember = "ESTAMENTO_ID"
    End Sub
    Public Sub llenarGrado()
        With cbbGrado
            With .Properties.Columns
                .Add(New LookUpColumnInfo("GRADO_ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("GRADO_ALIAS", "Grado", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        cbbGrado.Properties.DataSource = repositorio.dvGrado
        cbbGrado.Properties.DisplayMember = "GRADO_ALIAS"
        cbbGrado.Properties.NullText = ""
        cbbGrado.Properties.PopupWidth = 200
        cbbGrado.Properties.ValueMember = "GRADO_ID"
    End Sub
    Private Sub llenarEvaluadorDesempeno()
        With lueEvaluadorDesempeno
            With .Properties.Columns
                .Add(New LookUpColumnInfo("EVALUADOR_DESEMPENO_ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("NOMBRE_EVALUADOR", "Nombre Evaluador", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueEvaluadorDesempeno.Properties.DataSource = repositorio.dvEvaluadorDesempeno
        lueEvaluadorDesempeno.Properties.DisplayMember = "NOMBRE_EVALUADOR"
        lueEvaluadorDesempeno.Properties.NullText = ""
        lueEvaluadorDesempeno.Properties.PopupWidth = 200
        lueEvaluadorDesempeno.Properties.ValueMember = "EVALUADOR_DESEMPENO_ID"
    End Sub
    Private Sub llenarAutorizadorHorasExtras()
        With lueAutorizadorHorasExtras
            With .Properties.Columns
                .Add(New LookUpColumnInfo("AUTORIZADOR_HORAS_EXTRAS_ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("NOMBRE_AUTORIZADOR", "Nombre Autorizador Horas Extras", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueAutorizadorHorasExtras.Properties.DataSource = repositorio.dvAutorizadorHorasExtras
        lueAutorizadorHorasExtras.Properties.DisplayMember = "NOMBRE_AUTORIZADOR"
        lueAutorizadorHorasExtras.Properties.NullText = ""
        lueAutorizadorHorasExtras.Properties.PopupWidth = 200
        lueAutorizadorHorasExtras.Properties.ValueMember = "AUTORIZADOR_HORAS_EXTRAS_ID"

    End Sub
    Public Sub llenarEscalafon()
        With cbbEscalafon
            With .Properties.Columns
                .Add(New LookUpColumnInfo("ESCALAFON_ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        cbbEscalafon.Properties.DataSource = repositorio.dvEscalafon
        cbbEscalafon.Properties.DisplayMember = "DESCRIPCION"
        cbbEscalafon.Properties.NullText = ""
        cbbEscalafon.Properties.PopupWidth = 200
        cbbEscalafon.Properties.ValueMember = "ESCALAFON_ID"
    End Sub
    Public Sub llenarMotivoRetiro()
        With cbbMotivoRetiro
            With .Properties.Columns
                .Add(New LookUpColumnInfo("MOTIVO_RETIRO_ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        cbbMotivoRetiro.Properties.DataSource = repositorio.dvMotivoRetiro
        cbbMotivoRetiro.Properties.DisplayMember = "DESCRIPCION"
        cbbMotivoRetiro.Properties.NullText = ""
        cbbMotivoRetiro.Properties.PopupWidth = 200
        cbbMotivoRetiro.Properties.ValueMember = "MOTIVO_RETIRO_ID"
    End Sub
    Public Sub llenarJefeDirecto()
        With cbbJefeDirecto
            With .Properties
                .DataSource = repositorio.dvJefesDepto
                .DisplayMember = "NOMBRE_JEFE"
                .ValueMember = "JEFE_DEPTO_ID"
                .Columns.Item(0).FieldName = "NOMBRE_JEFE"
                .Columns.Item(0).Caption = "Nombre Jefe"
            End With
            .EditValue = "JEFE_DEPTO_ID"
        End With
    End Sub
    Public Sub llenarJefeEvaluador()
        With cbbJefeEvalDesempeno
            With .Properties
                .DataSource = repositorio.dvJefesDepto
                .DisplayMember = "NOMBRE_JEFE"
                .ValueMember = "JEFE_DEPTO_ID"
                .Columns.Item(0).FieldName = "NOMBRE_JEFE"
                .Columns.Item(0).Caption = "Nombre Jefe Evaluador"
            End With
            .EditValue = "JEFE_DEPTO_ID"
        End With
    End Sub
    Public Sub llenarUbicacionFisica()
        With cbbUbicacionFisica
            With .Properties.Columns
                .Add(New LookUpColumnInfo("UBICACION_FISICA_ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        cbbUbicacionFisica.Properties.DataSource = repositorio.dvUbicacionFisica
        cbbUbicacionFisica.Properties.DisplayMember = "DESCRIPCION"
        cbbUbicacionFisica.Properties.NullText = ""
        cbbUbicacionFisica.Properties.PopupWidth = 200
        cbbUbicacionFisica.Properties.ValueMember = "UBICACION_FISICA_ID"
    End Sub
    Public Sub llenarHorarioTrabrajo()
        With cbbHorarioTrabajo
            With .Properties.Columns
                .Add(New LookUpColumnInfo("HORARIO_ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        cbbHorarioTrabajo.Properties.DataSource = repositorio.dvHorario
        cbbHorarioTrabajo.Properties.DisplayMember = "DESCRIPCION"
        cbbHorarioTrabajo.Properties.NullText = ""
        cbbHorarioTrabajo.Properties.PopupWidth = 200
        cbbHorarioTrabajo.Properties.ValueMember = "HORARIO_ID"
    End Sub
    Public Sub llenarClasificacionEmpleado()
        With cbbClasificacionEmpleado
            With .Properties.Columns
                .Add(New LookUpColumnInfo("CLASIFICACION_EMPLEADO_ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        cbbClasificacionEmpleado.Properties.DataSource = repositorio.dvClasificacionEmpleado
        cbbClasificacionEmpleado.Properties.DisplayMember = "DESCRIPCION"
        cbbClasificacionEmpleado.Properties.NullText = ""
        cbbClasificacionEmpleado.Properties.PopupWidth = 200
        cbbClasificacionEmpleado.Properties.ValueMember = "CLASIFICACION_EMPLEADO_ID"
    End Sub
    Public Sub llenarTipoBeneficiario()
        With lueTipoBeneficiario
            With .Properties.Columns
                .Add(New LookUpColumnInfo("TIPO_BENEFICIARIO_ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueTipoBeneficiario.Properties.DataSource = repositorio.dvTipoBeneficiario
        lueTipoBeneficiario.Properties.DisplayMember = "DESCRIPCION"
        lueTipoBeneficiario.Properties.NullText = ""
        lueTipoBeneficiario.Properties.PopupWidth = 200
        lueTipoBeneficiario.Properties.ValueMember = "TIPO_BENEFICIARIO_ID"
    End Sub

    'agregado por segegob
    Public Sub llenarZonas()
        With lueZona
            With .Properties.Columns
                .Add(New LookUpColumnInfo("ZONA_ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ALIAS_ZONA", "Zona", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION_ZONA", "Descripción", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
            .Properties.DataSource = empleado.recuperarRegionesAsigcacionZonas(parametroMensual.ID)  'repositorio.dvZonas
            .Properties.DisplayMember = "DESCRIPCION_ZONA"
            .Properties.NullText = ""
            .Properties.PopupWidth = 200
            .Properties.ValueMember = "ZONA_ID"

        End With
    End Sub
#End Region

    Private Sub LlenadoDeControles()
        'Llenado de Controles
        llenarEstadoEmpleado()
        llenarEstadoCivil()
        llenarLocalidad()
        llenarNivelEstudios()
        inicializarControles()
        llenarDatosLaborales()
        llenarEstructuraOrganica()
        LlenarEmpleados()
        llenarPeriodos()

        'Llenado TAB de Datos Previsionales
        llenarAfp()
        llenarApv()
        llenarIsapre()
        llenarTipoTrabajadorPrevired()
        llenarTipoUnidades(lueUnidadAhorroAfp)
        llenarTipoUnidades(lueUnidadCotizacionVol)
        llenarTipoUnidades(lueUnidadMontoConvenio)
        llenarTipoUnidades(lueUnidadMontoPlanComplementario)
        llenarTipoUnidades(lueUnidadMontoAPV())
        llenarTipoUnidades(lueUnidadMontoPlanAuge)

        'Llenado TAB Datos Remuneracion
        llenarAsocGremial()
        llenarBanco()
        llenarTipoCuentaBanco()
        llenarTramoCargaFam()
        If empleado.datosRemuneracion.antecedenteRemunID = 0 Then
            valoresPorDefaultRemun()
        Else
            refrescarControles()
        End If
    End Sub

    Private Sub initCampoRut()
        'leRut.Properties.EditValueChangedFiringDelay = 1200
        Repository.RepositoryItem.EditValueChangedFiringDelay = 1200
        leRut.Properties.View.Columns.Clear()
        leRut.Properties.EditValueChangedFiringMode = EditValueChangedFiringMode.Buffered
        'Dos segundos se espera antes de gatillar la búsqueda (EditValueChanged)

        leRut.Properties.ViewType = Repository.GridLookUpViewType.GridView
        leRut.Properties.View.OptionsBehavior.AutoPopulateColumns = False

        If EsFichaHistorica = True Then
            leRut.Properties.DataSource = empleado.recuperaEmpleadoFichaHistorica(luePeriodo.EditValue)
        Else
            leRut.Properties.DataSource = repositorio.dvEmpleadoFichaHistorica 'repositorio.dvEmpleadoVista
        End If

        leRut.Properties.DisplayMember = "RUT"

        Dim col1 As GridColumn = leRut.Properties.View.Columns.AddField("RUT")
        col1.VisibleIndex = 0
        col1.Caption = "RUT"

        Dim col2 As GridColumn = leRut.Properties.View.Columns.AddField("APELLIDO_PATERNO")
        col2.VisibleIndex = 1
        col2.Caption = "Apellido Paterno"

        Dim col3 As GridColumn = leRut.Properties.View.Columns.AddField("APELLIDO_MATERNO")
        col3.VisibleIndex = 2
        col3.Caption = "Apellido Materno"

        Dim col4 As GridColumn = leRut.Properties.View.Columns.AddField("NOMBRES")
        col4.VisibleIndex = 3
        col4.Caption = "Nombres"

        Dim col5 As GridColumn = leRut.Properties.View.Columns.AddField("DESC_ESTADO")
        col5.VisibleIndex = 4
        col5.Caption = "Estado"

        Dim col6 As GridColumn = leRut.Properties.View.Columns.AddField("DESC_CALIDAD_JURIDICA")
        col6.VisibleIndex = 5
        col6.Caption = "Calidad Jurídica"

        Dim col7 As GridColumn = leRut.Properties.View.Columns.AddField("EMPLEADO_ID")
        col7.VisibleIndex = 6
        col7.Caption = "ID Empleado"
        col7.Visible = False

        leRut.Properties.ValueMember = "EMPLEADO_ID"
        leRut.Properties.View.BestFitColumns()
        leRut.Properties.PopupFormWidth = 600
    End Sub

    Private Function DescripcionEstado(ByVal idEstado As Comun.TiposDeDatos.TipoEstado) As String
        Dim estado As String = ""
        Select Case idEstado
            Case Comun.TiposDeDatos.TipoEstado.ACTIVO
                estado = "ACTIVO"
            Case Comun.TiposDeDatos.TipoEstado.EX_EMPLEADO
                estado = "EX-EMPLEADO"
            Case Comun.TiposDeDatos.TipoEstado.INACTIVO
                estado = "INACTIVO"
            Case Comun.TiposDeDatos.TipoEstado.POR_ACTIVAR
                estado = "POR ACTIVAR"
            Case Comun.TiposDeDatos.TipoEstado.COMISION_SERVICIO_EN_PRESIDENCIA
                estado = "COM.SERVICIO EN LA PRESIDENCIA"
            Case Comun.TiposDeDatos.TipoEstado.COMISION_SERVICIO_A_OTRA_INSTITUCION
                estado = "COM.SERVICIO A OTRA INSTITUCION "
        End Select
        Return estado
    End Function

    Private Sub refrescarControles()
        txtID.Text = empleado.ID
        cbbEstadoEmpleado.Text = DescripcionEstado(empleado.estado)
        txtApellidoPaterno.Text = empleado.apellidoPaterno
        txtApellidoMaterno.Text = empleado.apellidoMaterno
        txtNombres.Text = empleado.nombres
        txtDV.Text = empleado.rut.dv
        dedFechaNacimiento.EditValue = empleado.fechaNacimiento  '.ToShortDateString
        txtEdad.Text = Math.Round(Comun.Funciones.FechaFinal.Edad(dedFechaNacimiento.EditValue), 1)
        cbbEstadoCivil.SelectedIndex = empleado.estadoCivil - 1
        cbbNivelEstudio.EditValue = empleado.nivelEducacional
        If empleado.sexo = Persona.ESexo.MASCULINO Then
            rdgSexo.SelectedIndex = 0
        Else
            rdgSexo.SelectedIndex = 1
        End If
        cbbPais.Text = empleado.direccion.pais
        cbbComuna.Text = empleado.direccion.comuna
        cbbRegion.Text = empleado.direccion.region
        cbbCiudad.Text = empleado.direccion.ciudad
        txtCalle.Text = empleado.direccion.calle
        txtVillaPoblacion.Text = empleado.direccion.villaPoblacion
        txtNumero.Text = empleado.direccion.numero
        txtCodigoPostal.Text = empleado.direccion.codigoPostal

        txtFonoAnexo.Text = empleado.FonoAnexo
        txtFonoContactoEmergencia.Text = empleado.ContactoEmergencia
        txtServicioMilitar.Text = empleado.servicioMilitar
        txtMatriculaMilitar.Text = empleado.matriculaMilitar
        txtGrupoSanguineo.Text = empleado.grupoSanguineo
        txtAlergias.Text = empleado.alergias
        txtEnfermedadCronica.Text = empleado.enfermedadCronica
        txtMedicamentosContraindicados.Text = empleado.medicamentosContraindicados
        txtCelular.Text = empleado.celular
        txtTelefonoParticular.Text = empleado.telefono

        'Datos Laborales
        cbbClasificacionEmpleado.EditValue = empleado.datosLaborales.clasificacionEmpleadoID
        lueCalJur.EditValue = empleado.datosLaborales.calidadJuridicaID
        cbbEstamento.EditValue = CType(empleado.datosLaborales.estamentoID, Integer)
        cbbGrado.EditValue = CType(empleado.datosLaborales.gradoID, Integer)
        cbbEscalafon.EditValue = empleado.datosLaborales.escalafonID
        dedFechaIngAdmPublica.EditValue = empleado.datosLaborales.fechaIngresoAdministracionPublica
        dedFechaIngInstitucion.EditValue = empleado.datosLaborales.fechaIngresoInstitucion
        cbbMotivoRetiro.EditValue = CType(empleado.datosLaborales.motivoRetiroID, Integer)
        If empleado.datosLaborales.motivoRetiroID > 0 Then
            dedFechaRetiro.EditValue = empleado.datosLaborales.fechaRetiro
            txtResolucionRetiro.Text = empleado.datosLaborales.resolucionRetiro
        Else
            'dedFechaRetiro.EditValue = ""
            txtResolucionRetiro.Text = ""
        End If
        If dedFechaRetiro.EditValue <= CType("01-01-1900", Date) Or dedFechaRetiro.EditValue = Nothing Then
            dedFechaRetiro.EditValue = CType("01-01-1900", Date)
        Else
            dedFechaRetiro.EditValue = empleado.datosLaborales.fechaRetiro
        End If
        txtNroResolucionContrato.Text = empleado.datosLaborales.resolucionContrato
        If empleado.datosLaborales.resolucionFecha <= CType("01-01-1900", Date) Then
            dedFechaResolucion.EditValue = ""
        Else
            dedFechaResolucion.EditValue = empleado.datosLaborales.resolucionFecha
        End If
        cbbJefeDirecto.EditValue = CType(empleado.datosLaborales.jefeID, Integer)
        cbbUbicacionFisica.EditValue = empleado.datosLaborales.ubicaconFisicaID
        cbbHorarioTrabajo.EditValue = empleado.datosLaborales.horarioID
        txtFechaAsignacionGrado.EditValue = Format(empleado.datosLaborales.fechaIngresoGrado, "Short Date")
        dedFechaIngresoCalidadJuridica.EditValue = empleado.datosLaborales.fechaIngresoCalidadJuridica
        txtFuncionDesempeno.Text = empleado.datosLaborales.funcionDesempeño
        txtTituloProfesionalExpertiz.Text = empleado.datosLaborales.tituloProfesionalExpertiz
        chkPublicaDatos.Checked = empleado.datosLaborales.publicaDatosWeb
        lueTipoBeneficiario.EditValue = empleado.datosLaborales.tipoBeneficiarioID
        txtNumeroAcceso.Text = empleado.datosLaborales.numeroAcceso
        txtCargo.Text = empleado.datosLaborales.cargo
        cbbJefeEvalDesempeno.EditValue = CType(empleado.datosLaborales.jefeEvaluadorId, Integer)
        If empleado.datosLaborales.incluirEvalDesempeno = True Then
            chkIncluirParaEvaluacionDesempeño.Checked = True
        Else
            chkIncluirParaEvaluacionDesempeño.Checked = False
        End If

        'Datos previsionales AFP/Regimen antiguo
        lueAfp.EditValue = empleado.datosPrevisionales.institucionID
        dedFechaIngsistemaPrev.EditValue = empleado.datosPrevisionales.fechaIngresoSistemaPrevisional.ToShortDateString
        dedFechaAfiliacionPrevisional.EditValue = empleado.datosPrevisionales.fechaAfiliacion.ToShortDateString
        txtMontoAhorroAfp.Text = empleado.datosPrevisionales.montoCuentaAhorroAFP
        lueUnidadAhorroAfp.EditValue = CType(empleado.datosPrevisionales.unidadCuentaAhorroAFPId, Integer)
        txtMontoCotizacionVoluntaria.Text = empleado.datosPrevisionales.montoCotizacionVoluntaria
        lueUnidadCotizacionVol.EditValue = CType(empleado.datosPrevisionales.unidadCotizacionVoluntariaId, Integer)
        chkFondoA.Checked = empleado.datosPrevisionales.fondoPensionA
        chkFondoB.Checked = empleado.datosPrevisionales.fondoPensionB
        chkFondoC.Checked = empleado.datosPrevisionales.fondoPensionC
        chkFondoD.Checked = empleado.datosPrevisionales.fondoPensionD
        chkFondoE.Checked = empleado.datosPrevisionales.fondoPensionE
        txtAfpNroFun.Text = empleado.datosPrevisionales.afpNroFun
        deeAfpFechaFun.Text = empleado.datosPrevisionales.afpFechaFun

        'Datos de salud Isapre/Fonasa
        lueIsapre.EditValue = empleado.datosSalud.institucionID
        dedFechaAfiliacionSalud.EditValue = empleado.datosSalud.fechaAfiliacion
        txtMontoConvenio.Text = empleado.datosSalud.montoConvenio
        lueUnidadMontoConvenio.EditValue = CType(empleado.datosSalud.unidadConvenioId, Integer)
        txtMontoPlanComplementario.Text = empleado.datosSalud.montoPlanComplementario
        lueUnidadMontoPlanComplementario.EditValue = CType(empleado.datosSalud.unidadPlanComplementarioId, Integer)
        txtMontoPlanAuge.Text = empleado.datosSalud.montoplanAuge
        lueUnidadMontoPlanAuge.EditValue = CType(empleado.datosSalud.unidadPlanAugeId, Integer)
        lueTipoTrabajadorPrevired.EditValue = empleado.datosPrevisionales.tipoTrabajadorPrevidredID
        txtIsapreNroFun.Text = empleado.datosSalud.isapreNroFun
        deeIsapreFechaFun.Text = empleado.datosSalud.isapreFechaFun

        'Detalle antecedente previsional y de salud
        gdcPrevision.DataSource = empleado.dvDatosPrevisionales
        'Detalle antecedente ahorro previsional voluntario
        dgAntecedenteAPV.DataSource = empleado.dvDatosAPV

        'Datos de Remuneracion
        lueAsociacionGremial.EditValue = CType(empleado.datosRemuneracion.asociacionGremialID, Integer)
        If empleado.datosRemuneracion.fechaAfiliacionGremial <= "01-01-1900" Then
            dteFechaIngAsocGremial.EditValue = ""
        Else
            dteFechaIngAsocGremial.EditValue = empleado.datosRemuneracion.fechaAfiliacionGremial.ToShortDateString
        End If

        If empleado.datosRemuneracion.afiliadoBienestar = True Then
            rdgFondoBienestar.SelectedIndex = 1
        Else
            rdgFondoBienestar.SelectedIndex = 0
        End If
        If empleado.datosRemuneracion.fechaAfiliacionBienestar <= "01-01-1900" Then
            dteFechaIngBienestar.EditValue = ""
        Else
            dteFechaIngBienestar.EditValue = empleado.datosRemuneracion.fechaAfiliacionBienestar.ToShortDateString
        End If
        rdgFormaPago.SelectedIndex = empleado.datosRemuneracion.formaPago
        lueBanco.EditValue = CType(empleado.datosRemuneracion.bancoID, Integer)
        lueTipoCuentaBanco.EditValue = CType(empleado.datosRemuneracion.tipoCuentaDestinoID, Integer)
        txtNumeroCuentaBanco.Text = empleado.datosRemuneracion.numeroCuenta
        speNumeroBienios.EditValue = empleado.datosRemuneracion.numeroBienios
        If empleado.datosRemuneracion.fechaCumplioBienios <= "01-01-1900" Then
            dteFechaCumplioBienio.EditValue = ""
        Else
            dteFechaCumplioBienio.EditValue = empleado.datosRemuneracion.fechaCumplioBienios.ToShortDateString
        End If
        memObservacionesBienio.Text = empleado.datosRemuneracion.observacionAutorizaPago

        lueTramoCargaFamiliar.EditValue = CType(empleado.datosRemuneracion.tramoAsignacionFamiliarID, Integer)
        speCargaFamNormal.EditValue = empleado.datosRemuneracion.cargaFamiliarNormal
        speCargaFamInvalidez.EditValue = empleado.datosRemuneracion.cargaFamiliarInvalida
        speCargaFamPreNatal.EditValue = empleado.datosRemuneracion.cargaFamiliarPrenatal
        txtMontoRentaBase.Text = empleado.datosRemuneracion.rentaBase
        txtMontoSueldoBase.Text = empleado.datosRemuneracion.sueldoBase
        txtMontoLey19185Art19.Text = empleado.datosRemuneracion.valorAsignacionProfesional
        txtMontoAsigResponsabilidadSuperior.Text = empleado.datosRemuneracion.valorAsignacionResposabilidad
        txtMontoLey19185Art18.Text = empleado.datosRemuneracion.valorAsignacionLey19185Art18
        txtMontoFuncionCritica.Text = empleado.datosRemuneracion.valorFuncionCritica
        txtGastoRepresentacion.Text = empleado.datosRemuneracion.valorGastoRepresentacion
        txtLey18717.Text = empleado.datosRemuneracion.valorAsignacionLey18717
        txtLey18675Art10.Text = empleado.datosRemuneracion.valorAsignacionLey18675Art10
        txtLey18675Art11.Text = empleado.datosRemuneracion.valorAsignacionLey18675Art11
        txtLey18566.Text = empleado.datosRemuneracion.valorAsignacionLey18566
        txtMontoLey3551.Text = empleado.datosRemuneracion.valorLey3551
        txtIncrementoPrevisDL3501.Text = empleado.datosRemuneracion.valorIncrementoPrevisionalDL3501
        txtPorcentajeLey19863.EditValue = empleado.datosRemuneracion.porcentajeLey19863
        If empleado.datosLaborales.calidadJuridicaID = Comun.TiposDeDatos.TipoCalidadJuridica.HONORARIOS Then
            If empleado.datosRemuneracion.entregoBoletaHonorario = True Then
                Me.chkEntregoBoletaHonorario.Checked = True
            Else
                Me.chkEntregoBoletaHonorario.Checked = False
            End If
        Else
            Me.chkEntregoBoletaHonorario.Checked = False
        End If

        'If empleado.datosRemuneracion.enviarHaciaDexon = False Then
        '    Me.chkEnviarHaciaDexon.Checked = False
        'Else
        '    Me.chkEnviarHaciaDexon.Checked = True
        'End If

        'Me.txtNumeroCompromiso.Text = empleado.datosRemuneracion.numeroCompromisoDexon
        'Datos estructura organica
        lueInstitucion.EditValue = empleado.datosEstructuraOrganica.organizacionID
        lueDireccion.EditValue = empleado.datosEstructuraOrganica.direccionID
        lueDepartamento.EditValue = empleado.datosEstructuraOrganica.deptoID
        gdcEstructuraOrganica.DataSource = empleado.dvEstructuraOrganicaEmpleado
        If empleado.datosEstructuraOrganica.estructuraOrganicaId > 0 And empleado.datosEstructuraOrganica.estadoRegistro = 1 Then
            btnCancelarEstrucOrg.Enabled = False
            btnEliminarEstrucOrg.Enabled = True
        Else
            btnCancelarEstrucOrg.Enabled = True
            btnEliminarEstrucOrg.Enabled = False
        End If

        lueEvaluadorDesempeno.EditValue = empleado.datosEstructuraOrganica.evaluadorDesempenoID
        lueAutorizadorHorasExtras.EditValue = CType(empleado.datosEstructuraOrganica.autorizadorHorasExtrasID, Integer)
        lueSubDepto.EditValue = empleado.datosEstructuraOrganica.subDeptoId

        'Datos estructura contable
        lueCentroCostoContable.EditValue = empleado.datosEstructuraContable.centroCostoContab
        lueCentroCostoPresupuesto.EditValue = empleado.datosEstructuraContable.centroCostoPresup
        'txtPorcentajeDistribucion.Text = empleado.datosEstructuraContable.procentajeDistribucion
        txtPorcentajeDistribucion.Text = 100
        gdcEstructuraContable.DataSource = empleado.dvEstructuraContableEmpleado
        BloquearComandos()
        If empleado.datosEstructuraContable.estructuraContableId > 0 Then
            btnEliminarEstructuraContable.Enabled = True
        Else
            btnEliminarEstructuraContable.Enabled = False
        End If

        If empleado.datosPrevisionales.antecedentePrevisID > 0 Then
            btnGuardaryConservar.Enabled = True
        Else
            btnGuardaryConservar.Enabled = False
        End If

        'agregado segegob
        lueZona.EditValue = empleado.datosRemuneracion.zonaID
        chkAsignaLey18675Art11.Checked = empleado.datosRemuneracion.AsignaLey18675Art11
        CambiaMontoLey18675Art11(empleado.datosRemuneracion.valorAsignacionLey18675Art11)


        Try
            'AGREGADO SEGEGOB
            repositorio.dvZonas.RowFilter = "ZONA_ID = " & empleado.datosRemuneracion.zonaID
            Dim montoAsignacionZona As Integer = empleado.datosRemuneracion.sueldoBase * (CDec(repositorio.dvZonas(0)("PORCENTAJE_ZONA")) / 100)
            txtMontoAsignacionZona.Text = montoAsignacionZona
        Catch ex As Exception

        End Try

        If empleado.datosRemuneracion.antecedenteRemunID = 0 Then
            valoresPorDefaultRemun()
        End If
        LlenaNombreEmpleado("EMPLEADO: " + empleado.nombreCompleto)
    End Sub

    Private Sub LlenaNombreEmpleado(ByVal nombre As String)
        lblNombreDatosContacto.Text = nombre
        lblNombreDatosGenerales.Text = nombre
        lblNombreDatosLaborales.Text = nombre
        lblNombreEstructuraOrganizacional.Text = nombre
        lblNombreDatosPrevisionales.Text = nombre
        lblNombreDatosAPV.Text = nombre
        lblNombreDatosRemuneracion.Text = nombre
    End Sub

    Private Sub inicializarControles()
        'linkCodigoPostal.Links.Add(1, 20, "http://cp.dmapas.com/correos_cp/soporte_web/Consulta_Web/VersionPHp2006/pagina_interior/codigo_postal/Consulta_Web/pgn_modulo_codigopostal.asp?szTipo=d")

        'Tab antecedentes personales
        txtID.Text = 0
        txtApellidoPaterno.Text = ""
        txtApellidoMaterno.Text = ""
        txtNombres.Text = ""
        leRut.Text = ""
        txtDV.Text = ""
        dedFechaNacimiento.EditValue = ""
        cbbEstadoCivil.SelectedIndex = -1
        cbbNivelEstudio.EditValue = -1
        rdgSexo.SelectedIndex = -1

        'Tab datos contacto
        txtCalle.Text = ""
        txtNumero.Text = ""
        txtVillaPoblacion.Text = ""
        txtCelular.Text = ""
        txtTelefonoParticular.Text = ""
        txtCodigoPostal.Text = ""
        cbbPais.Text = ""
        cbbRegion.Text = ""
        cbbComuna.Text = ""
        cbbCiudad.Text = ""

        'Tab datos generales
        txtFonoAnexo.Text = ""
        txtFonoContactoEmergencia.Text = ""
        txtServicioMilitar.Text = ""
        txtMatriculaMilitar.Text = ""
        txtGrupoSanguineo.Text = ""
        txtAlergias.Text = ""
        txtEnfermedadCronica.Text = ""
        txtMedicamentosContraindicados.Text = ""

        txtRut.Visible = False
        leRut.Visible = True

        inicializaFotografia()

        'tab Datos Laborales
        txtCargo.Text = ""

        'tab Estructura Organica
        lueInstitucion.EditValue = CType(Comun.ArgoConfiguracion.OrganizacionID, Short)
        lueDireccion.EditValue = CType(-1, Short)
        lueDepartamento.EditValue = CType(-1, Integer)
        lueEvaluadorDesempeno.EditValue = CType(-1, Integer)
        lueAutorizadorHorasExtras.EditValue = CType(-1, Integer)
        dedFechaIngresoCalidadJuridica.EditValue = ""
        lueSubDepto.EditValue = 0

        'tab estructura Contable
        lueCentroCostoContable.EditValue = CType(-1, Short)
        lueCentroCostoPresupuesto.EditValue = CType(-1, Short)
        txtPorcentajeDistribucion.Text = 100

        Me.memObservacionesBienio.Text = ""
        Me.speNumeroBienios.Value = 0

    End Sub

    Private Sub inicializaFotografia()
        Dim bm As Bitmap = Nothing
        bm = New Bitmap(117, 115, Imaging.PixelFormat.Format24bppRgb)
        Dim graphicImage As Graphics = Graphics.FromImage(bm)
        graphicImage.Clear(System.Drawing.Color.White)
        graphicImage.DrawString("No Disponible", New Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 17, 50)
        picEmpleado.Image = bm
        picEmpleado.Refresh()
    End Sub

    Private Sub mnuListadoPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuListadoPersonal.Click
        Dim frmFiltro As New frmFiltroRptNominaEmpleados
        frmFiltro.Show()
    End Sub

    Private Sub txtDV_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDV.Validating
        If txtDV.Text <> "" Then
            If (txtDV.Text) <> Comun.Funciones.Rut.Valida(txtRut.Text) Then
                txtDV.Text = ""
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub asignacionCampos(ByVal empleado As BusinessRules.Empleado)
        'Asignar los datos de los controles del formulario al objeto empleado
        With empleado 'reemplaza a empleado.apellidoPaterno
            'PRIMER TAB "Datos Personales"
            If empleado.ID = 0 Then
                .organizacion = Comun.ArgoConfiguracion.OrganizacionID
                .rut.rut = txtRut.Text
            End If

            .rut.dv = txtDV.Text
            .apellidoPaterno = txtApellidoPaterno.Text
            .apellidoMaterno = txtApellidoMaterno.Text
            .nombres = txtNombres.Text
            .fechaNacimiento = dedFechaNacimiento.Text
            .estadoCivil = CType(cbbEstadoCivil.SelectedItem, Comun.DatoLista).valor
            .sexo = rdgSexo.EditValue
            .nivelEducacional = cbbNivelEstudio.EditValue

            'SEGUNDO TAB "Domicilio"
            .direccion.nombre = "Particular"
            .direccion.villaPoblacion = txtVillaPoblacion.Text
            .direccion.numero = txtNumero.Text
            .direccion.calle = txtCalle.Text
            .direccion.codigoPostal = txtCodigoPostal.Text
            .direccion.pais = valorCombo(cbbPais)
            .direccion.region = valorCombo(cbbRegion)
            .direccion.ciudad = valorCombo(cbbCiudad)
            .direccion.comuna = valorCombo(cbbComuna)
            .telefono = txtTelefonoParticular.Text
            .celular = txtCelular.Text
            'TERCER TAB ''Datos Adicionales

            .FonoAnexo = txtFonoAnexo.Text
            .ContactoEmergencia = txtFonoContactoEmergencia.Text
            .servicioMilitar = txtServicioMilitar.Text
            .matriculaMilitar = txtMatriculaMilitar.Text
            .grupoSanguineo = txtGrupoSanguineo.Text
            .alergias = txtAlergias.Text
            .enfermedadCronica = txtEnfermedadCronica.Text
            .medicamentosContraindicados = txtMedicamentosContraindicados.Text
            'If Expression Then

            'End If
        End With
    End Sub
    Private Function valorCombo(ByVal cbb As ComboBoxEdit) As String
        If Not cbb.SelectedItem Is Nothing Then
            If TypeOf cbb.SelectedItem Is Comun.DatoLista Then
                Return (Trim(CType(cbb.SelectedItem, Comun.DatoLista).descripcion))
            Else
                Return (Trim(cbb.SelectedItem))
            End If
        Else
            Return ("")
        End If
    End Function
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtRut.Visible = False
        leRut.Visible = True
        btnNuevo.Enabled = True
        btnGuardar.Enabled = True
        empleado = New Empleado
    End Sub
    Private Sub txtMontoAhorroAfp_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMontoAhorroAfp.Validating
        If CType(txtMontoAhorroAfp.Text, Double) < 0 Then
            txtMontoAhorroAfp.ErrorText = "Monto ahorrp AFP no puede ser negativo"
            txtMontoAhorroAfp.Text = ""
            e.Cancel = True
        End If
    End Sub

    Private Sub txtMontoCotizacionVoluntaria_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMontoCotizacionVoluntaria.Validating
        If CType(txtMontoCotizacionVoluntaria.Text, Double) < 0 Then
            txtMontoCotizacionVoluntaria.ErrorText = "Monto cotización voluntartia no puede ser negativo"
            txtMontoCotizacionVoluntaria.Text = ""
            e.Cancel = True
        End If
    End Sub

    Private Sub txtMontoConvenio_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMontoConvenio.Validating
        If (txtMontoConvenio.Text) < 0 Then
            txtMontoConvenio.ErrorText = "Monto convenio de salud no puede ser negativo"
            txtMontoConvenio.Text = ""
            e.Cancel = True
        End If
    End Sub

    Private Sub txtMontoPlanComplementario_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMontoPlanComplementario.Validating
        If (txtMontoPlanComplementario.Text) < 0 Then
            txtMontoPlanComplementario.ErrorText = "Monto plan complementario de salud no puede ser negativo"
            txtMontoPlanComplementario.Text = ""
            e.Cancel = True
        End If
    End Sub

    Private Sub btnGuardarDatosPrevisionales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarDatosPrevisionales.Click
        If validacionesPrevisionales() Then
            If empleado.datosPrevisionales.antecedentePrevisID = 0 Then
                Try
                    'Crear un nuevo registro
                    asignacionCamposPrevisional(empleado)
                    If EsFichaHistorica Then
                        empleado.datosPrevisionales.varEstadoRegistro = Comun.TiposDeDatos.EstadoRegistro.HISTORICO
                    Else
                        empleado.datosPrevisionales.varEstadoRegistro = Comun.TiposDeDatos.EstadoRegistro.ACTIVO
                    End If

                    empleado.datosPrevisionales.antecedentePrevisID = empleado.CrearEmpleadoPrevisional(empleado.datosPrevisionales.antecedentePrevisID)
                    gdcPrevision.DataSource = empleado.dvDatosPrevisionales
                    gdcPrevision.Show()
                    MsgBox("El registro fue creado satisfactoriamente", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al crear el registro " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            Else
                Try
                    'Cambia el estado a intactivo y crea un nuevo registro con estado activo
                    empleado.datosPrevisionales.varEstadoRegistro = Comun.TiposDeDatos.EstadoRegistro.INACTIVO
                    empleado.actualizarDatosPrevisionales(empleado.datosPrevisionales)
                    If EsFichaHistorica Then
                        empleado.datosPrevisionales.varEstadoRegistro = Comun.TiposDeDatos.EstadoRegistro.HISTORICO
                    Else
                        empleado.datosPrevisionales.varEstadoRegistro = Comun.TiposDeDatos.EstadoRegistro.ACTIVO
                    End If
                    asignacionCamposPrevisional(empleado)
                    empleado.datosPrevisionales.antecedentePrevisID = 0
                    empleado.datosPrevisionales.antecedentePrevisID = empleado.CrearEmpleadoPrevisional(empleado.datosPrevisionales.antecedentePrevisID)
                    gdcPrevision.DataSource = empleado.dvDatosPrevisionales
                    gdcPrevision.Show()
                    MsgBox("El registro fue actualizado correctamente", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al actualuzar el registro " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
        End If
    End Sub

    Private Sub btnGuardaryConservar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardaryConservar.Click
        If validacionesPrevisionales() Then
            GuardarDatosPrevisionales(Comun.TiposDeDatos.TipoActualizacion.GUARDAR_Y_CONSERVAR_REGISTRO_ANTERIOR)
            gdcPrevision.DataSource = empleado.dvDatosPrevisionales
            gdcPrevision.Show()
        End If
    End Sub

    Private Sub btnGuardarRegistroActual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarRegistroActual.Click
        If validacionesPrevisionales() Then
            GuardarDatosPrevisionales(Comun.TiposDeDatos.TipoActualizacion.GUARDAR_REGISTRO_ACTUAL_O_NUEVO)
            gdcPrevision.DataSource = empleado.dvDatosPrevisionales
            gdcPrevision.Show()
        End If
    End Sub

    Private Sub GuardarDatosPrevisionales(ByVal accion As String)
        If accion = Comun.TiposDeDatos.TipoActualizacion.GUARDAR_Y_CONSERVAR_REGISTRO_ANTERIOR Then
            Try
                'Cambia el estado a intactivo y crea un nuevo registro con estado activo
                empleado.datosPrevisionales.varEstadoRegistro = Comun.TiposDeDatos.EstadoRegistro.INACTIVO
                empleado.actualizarDatosPrevisionales(empleado.datosPrevisionales)
                empleado.datosPrevisionales.varEstadoRegistro = Comun.TiposDeDatos.EstadoRegistro.ACTIVO
                asignacionCamposPrevisional(empleado)
                empleado.datosPrevisionales.antecedentePrevisID = 1
                empleado.datosPrevisionales.antecedentePrevisID = empleado.CrearEmpleadoPrevisional(empleado.datosPrevisionales.antecedentePrevisID)
                If empleado.datosPrevisionales.antecedentePrevisID > 0 Then
                    btnGuardaryConservar.Enabled = True
                Else
                    btnGuardaryConservar.Enabled = False
                End If
                MsgBox("El registro fue creado satisfactoriamente", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al crear el registro " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        Else
            If accion = Comun.TiposDeDatos.TipoActualizacion.GUARDAR_REGISTRO_ACTUAL_O_NUEVO Then
                asignacionCamposPrevisional(empleado)
                If empleado.datosPrevisionales.antecedentePrevisID = 0 Then
                    Try
                        'Crear un nuevo registro
                        empleado.datosPrevisionales.varEstadoRegistro = Comun.TiposDeDatos.EstadoRegistro.ACTIVO
                        empleado.datosPrevisionales.antecedentePrevisID = empleado.CrearEmpleadoPrevisional(empleado.datosPrevisionales.antecedentePrevisID)
                        If empleado.datosPrevisionales.antecedentePrevisID > 0 Then
                            btnGuardaryConservar.Enabled = True
                        Else
                            btnGuardaryConservar.Enabled = False
                        End If
                        MsgBox("El registro fue creado satisfactoriamente", MsgBoxStyle.Information)
                    Catch ex As Exception
                        MsgBox("Ha ocurrido un error al crear el registro " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                Else
                    Try
                        'Actualizar un registro
                        empleado.actualizarDatosPrevisionales(empleado.datosPrevisionales)
                        MsgBox("Los datos han sido actualizados correctamente", MsgBoxStyle.Information)
                    Catch ex As Exception
                        MsgBox("Ha ocurrido un error al actualizar " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                End If
            End If
        End If
    End Sub
    Private Sub asignacionCamposPrevisional(ByVal empleado As BusinessRules.Empleado)
        'ANTECEDENTE PREVISIONAL Y DE SALUD
        With empleado
            .datosPrevisionales.institucionID = RTrim(lueAfp.EditValue)
            If dedFechaIngsistemaPrev.Text <> "" Then
                .datosPrevisionales.fechaIngresoSistemaPrevisional = dedFechaIngsistemaPrev.Text
            End If
            If dedFechaAfiliacionPrevisional.Text <> "" Then
                .datosPrevisionales.fechaAfiliacion = dedFechaAfiliacionPrevisional.Text
            End If
            If txtMontoAhorroAfp.Text <> "" Then
                .datosPrevisionales.montoCuentaAhorroAFP = txtMontoAhorroAfp.Text
            Else
                .datosPrevisionales.montoCuentaAhorroAFP = 0
            End If
            If Not lueUnidadAhorroAfp.EditValue Is Nothing Then
                .datosPrevisionales.unidadCuentaAhorroAFPId = RTrim(lueUnidadAhorroAfp.EditValue)
            End If
            If Not lueUnidadCotizacionVol.EditValue Is Nothing Then
                .datosPrevisionales.unidadCotizacionVoluntariaId = RTrim(lueUnidadCotizacionVol.EditValue)
            End If
            If txtMontoCotizacionVoluntaria.Text <> "" Then
                .datosPrevisionales.montoCotizacionVoluntaria = txtMontoCotizacionVoluntaria.Text
            Else
                .datosPrevisionales.montoCotizacionVoluntaria = 0
            End If
            If Not lueIsapre.EditValue Is Nothing Then
                .datosSalud.institucionID = RTrim(lueIsapre.EditValue)
            End If
            If chkFondoA.Checked Then
                .datosPrevisionales.fondoPensionA = True
            Else
                .datosPrevisionales.fondoPensionA = False
            End If
            If chkFondoB.Checked Then
                .datosPrevisionales.fondoPensionB = True
            Else
                .datosPrevisionales.fondoPensionB = False
            End If
            If chkFondoC.Checked Then
                .datosPrevisionales.fondoPensionC = True
            Else
                .datosPrevisionales.fondoPensionC = False
            End If
            If chkFondoD.Checked Then
                .datosPrevisionales.fondoPensionD = True
            Else
                .datosPrevisionales.fondoPensionD = False
            End If
            If chkFondoE.Checked Then
                .datosPrevisionales.fondoPensionE = True
            Else
                .datosPrevisionales.fondoPensionE = False
            End If

            If dedFechaAfiliacionSalud.Text <> "" Then
                .datosSalud.fechaAfiliacion = dedFechaAfiliacionSalud.Text
            End If

            If txtMontoConvenio.Text <> "" Then
                .datosSalud.montoConvenio = txtMontoConvenio.Text
            Else
                .datosSalud.montoConvenio = 0
            End If

            If Not lueUnidadMontoConvenio.EditValue Is Nothing Then
                .datosSalud.unidadConvenioId = RTrim(lueUnidadMontoConvenio.EditValue)
            End If

            If txtMontoPlanComplementario.Text <> "" Then
                .datosSalud.montoPlanComplementario = txtMontoPlanComplementario.Text
            Else
                .datosSalud.montoPlanComplementario = 0
            End If

            If Not lueUnidadMontoPlanComplementario.EditValue Is Nothing Then
                .datosSalud.unidadPlanComplementarioId = RTrim(lueUnidadMontoPlanComplementario.EditValue)
            End If

            If txtMontoPlanAuge.Text <> "" Then
                .datosSalud.montoplanAuge = txtMontoPlanAuge.Text
            Else
                .datosSalud.montoplanAuge = 0
            End If

            If Not lueUnidadMontoPlanAuge.EditValue Is Nothing Then
                .datosSalud.unidadPlanAugeId = RTrim(lueUnidadMontoPlanAuge.EditValue)
            End If

            If txtAfpNroFun.Text.Trim <> "" Then
                .datosPrevisionales.afpNroFun = txtAfpNroFun.Text.Trim
            End If

            If deeAfpFechaFun.Text.Trim <> "" Then
                .datosPrevisionales.afpFechaFun = deeAfpFechaFun.Text.Trim
            End If

            If txtIsapreNroFun.Text.Trim <> "" Then
                .datosSalud.isapreNroFun = txtIsapreNroFun.Text.Trim
            End If

            If deeIsapreFechaFun.Text.Trim <> "" Then
                .datosSalud.isapreFechaFun = deeIsapreFechaFun.Text.Trim
            End If

            .datosPrevisionales.periodoID = parametroMensual.ID
            .datosPrevisionales.tipoTrabajadorPrevidredID = lueTipoTrabajadorPrevired.EditValue
        End With
    End Sub
    Private Sub asignacionCamposAPV(ByVal empleado As BusinessRules.Empleado)
        With empleado
            .datosAPV.estadoregistro = Comun.TiposDeDatos.EstadoRegistro.ACTIVO
            .datosAPV.tipoAPV = rdgTipoAhorro.EditValue
            If lueAPV.Text <> "" Then
                .datosAPV.institucionAPVID = RTrim(lueAPV.EditValue)
            End If
            If lueUnidadMontoAPV.Text <> "" Then
                .datosAPV.unidadCuentaAhorroAPVId = RTrim(lueUnidadMontoAPV.EditValue)
            End If
            .datosAPV.montoCuentaAhorroAPV = txtMontoAPV.EditValue
            If .datosAPV.antecedenteApvID = 0 Then
                .datosAPV.periodoID = parametroMensual.ID
            End If
        End With
    End Sub
    Private Function validacionesPrevisionales() As Boolean
        Dim respuesta As Boolean
        respuesta = True
        If lueAfp.EditValue <= 0 Or lueAfp.EditValue = Nothing Then
            lueAfp.ErrorText = "Falta ingresar institución previsional"
            respuesta = False
        Else
            If (lueAfp.EditValue <= 0 Or lueAfp.EditValue = Nothing) And txtMontoAhorroAfp.EditValue > 0 Then
                lueAfp.ErrorText = "Falta ingresar institución previsional para poder asignar el monto de ahorro AFP"
                respuesta = False
            Else
                If lueAfp.EditValue > 0 And txtMontoAhorroAfp.EditValue > 0 And (lueUnidadAhorroAfp.EditValue <= 0 Or lueUnidadAhorroAfp.EditValue = Nothing) Then
                    lueUnidadAhorroAfp.ErrorText = "Falta ingresar tipo unidad para monto ahorro AFP"
                    respuesta = False
                End If
            End If
        End If
        If lueIsapre.EditValue <= 0 Or lueIsapre.EditValue = Nothing Then
            lueIsapre.ErrorText = "Falta ingresar institución de salud"
            respuesta = False
        Else
            If lueIsapre.EditValue > 0 And txtMontoConvenio.EditValue <= 0 Then
                txtMontoConvenio.ErrorText = "Falta ingresar monto convenio con intitución de salud"
                respuesta = False
            Else
                If lueIsapre.EditValue > 0 And txtMontoConvenio.EditValue > 0 And lueUnidadMontoConvenio.EditValue <= 0 Then
                    lueUnidadMontoConvenio.ErrorText = "Falta ingresar tipo unidad para monto convenio con intitución de salud"
                    respuesta = False
                End If
            End If
        End If
        If lueTipoTrabajadorPrevired.EditValue <= 0 Or lueTipoTrabajadorPrevired.EditValue = Nothing Then
            lueTipoTrabajadorPrevired.ErrorText = "Falta ingresar tipo trabajador previred"
            respuesta = False
        End If
        If dedFechaIngsistemaPrev.Text < "01-01-1950" Then
            dedFechaIngsistemaPrev.ErrorText = "Fecha de ingreso al sistema previsional esta fuera de rango"
            respuesta = False
        End If
        If dedFechaAfiliacionPrevisional.Text < "01-01-1950" Then
            dedFechaAfiliacionPrevisional.ErrorText = "Fecha de afiliación a la institución previsional esta fuera de rango"
            respuesta = False
        End If
        If dedFechaAfiliacionSalud.Text < "01-01-1950" Then
            dedFechaAfiliacionSalud.ErrorText = "Fecha de afiliación a Isapre esta fuera de rango"
            respuesta = False
        End If
        Return respuesta
    End Function
    Private Sub dedFechaIngsistemaPrev_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dedFechaIngsistemaPrev.Validating
        If dedFechaIngsistemaPrev.DateTime < empleado.fechaNacimiento Then
            dedFechaIngsistemaPrev.ErrorText = "Fecha de ingreso al sistema previsional no puede ser anterior a la fecha de nacimiento (" & empleado.fechaNacimiento & ")"
            e.Cancel = True
        End If
    End Sub
    Private Sub dedFechaAfiliacionPrevisional_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dedFechaAfiliacionPrevisional.Validating
        If dedFechaAfiliacionPrevisional.DateTime < dedFechaIngsistemaPrev.DateTime Then
            dedFechaAfiliacionPrevisional.ErrorText = "Fecha de afiliación previsional debe ser igual o mayor " & Chr(13) _
            & "a fecha de ingreso al sistema previsional"
            e.Cancel = True
        End If
    End Sub
    Public Sub llenarAfp()
        With lueAfp
            With .Properties.Columns
                .Add(New LookUpColumnInfo("AFP_ID", "Afp ID", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Nombre AFP", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("TASA_DESCUENTO", "Tasa Descto.", 40, DevExpress.Utils.FormatType.Numeric, "n3", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None))
                .Add(New LookUpColumnInfo("DESCUENTO_LEY_19882", "Ley 19.882", 40, DevExpress.Utils.FormatType.Numeric, "n3", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None))
                .Add(New LookUpColumnInfo("SISTEMA_PREV_ALIAS", "Regimen Previsional", 40, DevExpress.Utils.FormatType.Numeric, "n0", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None))
            End With
        End With
        lueAfp.Properties.DataSource = repositorio.dvAfp
        lueAfp.Properties.DisplayMember = "DESCRIPCION"
        lueAfp.Properties.NullText = ""
        lueAfp.Properties.PopupWidth = 400
        lueAfp.Properties.ValueMember = "AFP_ID"
    End Sub
    Public Sub llenarIsapre()
        With lueIsapre
            With .Properties.Columns
                .Add(New LookUpColumnInfo("ISAPRE_ID", "ID Isapre", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Nombre Isapre", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueIsapre.Properties.DataSource = repositorio.dvIsapre
        lueIsapre.Properties.DisplayMember = "DESCRIPCION"
        lueIsapre.Properties.NullText = ""
        lueIsapre.Properties.PopupWidth = 400
        lueIsapre.Properties.ValueMember = "ISAPRE_ID"
    End Sub
    Public Sub llenarTipoTrabajadorPrevired()
        With lueTipoTrabajadorPrevired
            With .Properties.Columns
                .Add(New LookUpColumnInfo("TIPO_TRABAJADOR_PREVIRED_ID", "ID Tipo Trab.Previred", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Tipo Trabajador", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueTipoTrabajadorPrevired.Properties.DataSource = repositorio.dvTipoTrabPrevired
        lueTipoTrabajadorPrevired.Properties.DisplayMember = "DESCRIPCION"
        lueTipoTrabajadorPrevired.Properties.NullText = ""
        lueTipoTrabajadorPrevired.Properties.PopupWidth = 400
        lueTipoTrabajadorPrevired.Properties.ValueMember = "TIPO_TRABAJADOR_PREVIRED_ID"
    End Sub

    Public Sub llenarApv()
        With lueAPV
            With .Properties.Columns
                .Add(New LookUpColumnInfo("APV_ID", "Apv ID", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Institución APV", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueAPV.Properties.DataSource = repositorio.dvApv
        lueAPV.Properties.DisplayMember = "DESCRIPCION"
        lueAPV.Properties.NullText = ""
        lueAPV.Properties.PopupWidth = 180
        lueAPV.Properties.ValueMember = "APV_ID"
    End Sub
    Public Sub llenarTipoUnidades(ByVal controLookUp As DevExpress.XtraEditors.LookUpEdit)
        With controLookUp
            With .Properties.Columns
                .Add(New LookUpColumnInfo("TIPO_UNIDAD_ID", "ID Unidad", 40, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("TIPO_UNIDAD_ALIAS", "Descripción", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        controLookUp.Properties.DataSource = repositorio.DvTipoUnidad
        controLookUp.Properties.DisplayMember = "TIPO_UNIDAD_ALIAS"
        controLookUp.Properties.NullText = ""
        controLookUp.Properties.PopupWidth = 180
        controLookUp.Properties.ValueMember = "TIPO_UNIDAD_ID"
    End Sub

    Private Sub gvDetalleAPV_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvDetalleAPV.DoubleClick
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        'traspasa hacia radio group tipo ahorro
        If view.GetRowCellValue(view.FocusedRowHandle, view.Columns(2)) = 1 Then
            rdgTipoAhorro.SelectedIndex = 0
        End If
        If view.GetRowCellValue(view.FocusedRowHandle, view.Columns(2)) = 2 Then
            rdgTipoAhorro.SelectedIndex = 1
        End If
        'traspasa hacia lookup edit id insitución apv
        lueAPV.EditValue = view.GetRowCellValue(view.FocusedRowHandle, view.Columns(4))
        'traspasa hacia monto apv
        txtMontoAPV.Text = view.GetRowCellValue(view.FocusedRowHandle, view.Columns(5))
        'traspasa hacia lookup edit id tipo unidad
        lueUnidadMontoAPV.EditValue = view.GetRowCellValue(view.FocusedRowHandle, view.Columns(6))
        empleado.datosAPV.antecedenteApvID = view.GetRowCellValue(view.FocusedRowHandle, view.Columns(8))
    End Sub
    Private Sub gvDetalleAPV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gvDetalleAPV.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
                Dim valor_id As Integer
                Try
                    valor_id = view.GetRowCellValue(view.FocusedRowHandle, view.Columns(8))
                    If empleado.EliminarEmpleadoAPV(valor_id) = False Then
                        MsgBox("Registro no puede ser eliminado", MsgBoxStyle.Exclamation)
                    Else
                        dgAntecedenteAPV.DataSource = empleado.dvDatosAPV

                    End If
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al intentar eliminar el registro " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
        End If
    End Sub

    Private Sub desactivaTabsAntecedentesAdicionales()
        xtcFichaEmpleado.TabPages(1).PageEnabled = False
        xtcFichaEmpleado.TabPages(2).PageEnabled = False
        xtcFichaEmpleado.TabPages(3).PageEnabled = False
        xtcFichaEmpleado.TabPages(4).PageEnabled = False
        xtcFichaEmpleado.TabPages(5).PageEnabled = False
        xtcFichaEmpleado.TabPages(6).PageEnabled = False
        xtcFichaEmpleado.TabPages(7).PageEnabled = False
    End Sub

    Private Sub activaTabsAntecedentesAdicionales()
        xtcFichaEmpleado.TabPages(1).PageEnabled = True
        xtcFichaEmpleado.TabPages(2).PageEnabled = True
        xtcFichaEmpleado.TabPages(3).PageEnabled = True
        xtcFichaEmpleado.TabPages(4).PageEnabled = True
        xtcFichaEmpleado.TabPages(5).PageEnabled = True
        xtcFichaEmpleado.TabPages(6).PageEnabled = True
        xtcFichaEmpleado.TabPages(7).PageEnabled = True
    End Sub

    'Este evento controla los eventos de varios botones, mirar Handles
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        ResetControls(Me)
        inicializarControles()
        'LlenadoDeControles()
        txtDV.Enabled = True
        txtRut.Visible = True
        leRut.Visible = False
        btnNuevo.Enabled = False
        btnGuardar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True
        edicion = True
        lueEmpleado.Enabled = False
        lueEmpleado.EditValue = -1
        txtRut.Focus()
        empleado = New Empleado
        desactivaTabsAntecedentesAdicionales()
        valoresPorDefaultRemun()
        valoresPorDefaultLaboral()
        empleado.estadoEmpleadoID = Comun.TiposDeDatos.TipoEstado.POR_ACTIVAR
        cbbEstadoEmpleado.Text = DescripcionEstado(Comun.TiposDeDatos.TipoEstado.POR_ACTIVAR)
        txtRut.TabIndex = 1
        txtDV.TabIndex = 2
        dedFechaAfiliacionSalud.EditValue = "01-01-1900"
        dedFechaIngsistemaPrev.EditValue = "01-01-1900"
        dedFechaAfiliacionPrevisional.EditValue = "01-01-1900"
        empleado.datosRemuneracion.antecedenteRemunID = 0
        empleado.datosPrevisionales.antecedentePrevisID = 0
    End Sub
    'Este evento controla los eventos de varios botones, mirar Handles
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If Not empleado Is Nothing Then
            If empleado.buscaIdentificadorLiquidacion(empleado.ID) = 0 Then
                Try
                    If MsgBox("¿Está usted seguro(a) que desea eliminar este registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                        If empleado.Eliminar() Then
                            txtRut.Visible = False
                            leRut.Visible = True
                            btnNuevo.Enabled = True
                            btnGuardar.Enabled = False
                            btnEliminar.Enabled = False
                            empleado = New Empleado
                            inicializarControles()
                            btnCancelar.Enabled = False
                            edicion = False
                            dvEmpleados.RowFilter = ""
                            desactivaTabsAntecedentesAdicionales()
                            refrescarMaestroEmpleado()
                            MsgBox("Se ha eliminado el registro solicitado", MsgBoxStyle.Exclamation)
                        Else
                            MsgBox("No ha sido posible eliminar el registro solicitado", MsgBoxStyle.Exclamation)
                        End If
                    End If
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al eliminar " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            Else
                MsgBox("No puede eliminar el registro, existe a lo menos un proceso de liquidación en el histórico", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Previamente, debe seleccionar un registro", MsgBoxStyle.Information)
        End If
    End Sub
    'Este evento controla los eventos de varios botones, mirar Handles
    'Handles btnGuardar.Click, btnGuardarDatosContacto.Click, btnGuardarDatosGenerales.Click
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnGuardar.Click, btnGuardarDatosContacto.Click, btnGuardarDatosGenerales.Click
        'Cursor.Current = Cursors.WaitCursor
        asignacionCampos(empleado)
        'A continuación se llama a Crear()
        'para que se adicione a la base de datos
        If empleado.ID = 0 Then
            Try
                empleado = empleado.Crear()
                txtID.Text = empleado.ID
                MsgBox("Los datos de " & empleado.nombreCompleto & " han sido actualizados", MsgBoxStyle.Information)
                'leRut.Text = empleado.rut.rut
                btnGuardar.Enabled = True
                btnEliminar.Enabled = True
                btnNuevo.Enabled = True
                btnCancelar.Enabled = False
                'NOTA:
                'El funcionario debe ser creado independiente de que cuente o no con sus datos laborales.
                'Estos podrían quedar pendientes de ingreso si el usuario lo desea así.
                activaTabsAntecedentesAdicionales()

                controlesClaveDatosLaborales()
                txtRut.Visible = False
                txtDV.Visible = False
                leRut.Visible = True

                asignacionCamposDatosLaborales(empleado)
                inicializaDatosBasicosAntecedenteLaboral()
                empleado.datosLaborales.periodoIDCambioSituacionLaboral = 0
                empleado.datosLaborales.antecedenteLaboralID = empleado.CrearEmpleadoLaboral()


                refrescarMaestroEmpleado()
                leRut.EditValue = CType(empleado.ID, Integer)
                lueEmpleado.Enabled = True
                lueEmpleado.EditValue = CType(empleado.ID, Integer)
            Catch excepcion As Exception
                MsgBox("Ha ocurrido un error al actualizar " & empleado.nombreCompleto & " " & excepcion.Message, MsgBoxStyle.Exclamation)
            End Try
        Else
            Try
                controlesClaveDatosLaborales()
                empleado = empleado.Actualizar()
                refrescarMaestroEmpleado()
                txtID.Text = empleado.ID
                MsgBox("Los datos de " & empleado.nombreCompleto & " han sido actualizados", MsgBoxStyle.Information)
                txtRut.Visible = False
                txtDV.Visible = False
                leRut.Visible = True
                btnGuardar.Enabled = True
                btnEliminar.Enabled = True
                btnNuevo.Enabled = True
                btnCancelar.Enabled = False
            Catch excepcion As Exception
                MsgBox("Ha ocurrido un error al actualizar " & empleado.nombreCompleto & " " & excepcion.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
        'Cursor.Current = Cursors.Default
    End Sub
    'Este evento controla los eventos de varios botones, mirar Handles
    Private Sub btnCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtRut.Visible = False
        leRut.Visible = True
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnEliminar.Enabled = False
        edicion = False
        empleado = New Empleado

        inicializarControles()

        btnCancelar.Enabled = False
        desactivaTabsAntecedentesAdicionales()
    End Sub


    Public Sub llenarAsocGremial()
        With lueAsociacionGremial
            With .Properties.Columns
                .Add(New LookUpColumnInfo("ASOCIACION_GREMIAL_ID", "ID Asoc.Gremial", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Nombre Asoc.", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueAsociacionGremial.Properties.DataSource = repositorio.dvAsocGremial
        lueAsociacionGremial.Properties.DisplayMember = "DESCRIPCION"
        lueAsociacionGremial.Properties.NullText = ""
        lueAsociacionGremial.Properties.PopupWidth = 400
        lueAsociacionGremial.Properties.ValueMember = "ASOCIACION_GREMIAL_ID"
        lueAsociacionGremial.EditValue = "ASOCIACION_GREMIAL_ID"
    End Sub
    Public Sub llenarBanco()
        With lueBanco
            With .Properties.Columns
                .Add(New LookUpColumnInfo("BANCO_ID", "ID Banco", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Nombre Banco", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueBanco.Properties.DataSource = repositorio.dvBanco
        lueBanco.Properties.DisplayMember = "DESCRIPCION"
        lueBanco.Properties.NullText = ""
        lueBanco.Properties.PopupWidth = 400
        lueBanco.Properties.ValueMember = "BANCO_ID"
    End Sub
    Public Sub llenarTipoCuentaBanco()
        With lueTipoCuentaBanco
            With .Properties.Columns
                .Add(New LookUpColumnInfo("TIPO_CUENTA_BANCO_ID", "ID Tipo Cta.", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Nombre Cuenta", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueTipoCuentaBanco.Properties.DataSource = repositorio.dvTipoCuentaBanco
        lueTipoCuentaBanco.Properties.DisplayMember = "DESCRIPCION"
        lueTipoCuentaBanco.Properties.NullText = ""
        lueTipoCuentaBanco.Properties.PopupWidth = 400
        lueTipoCuentaBanco.Properties.ValueMember = "TIPO_CUENTA_BANCO_ID"
    End Sub
    Public Sub llenarTramoCargaFam()
        With lueTramoCargaFamiliar
            With .Properties.Columns
                .Add(New LookUpColumnInfo("TRAMO_ASIGNACION_FAMILIAR_ID", "ID Tramo", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Nombre Cuenta", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("MONTO", "Valor", 30, DevExpress.Utils.FormatType.Numeric, "c0", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueTramoCargaFamiliar.Properties.DataSource = repositorio.dvTramoCargaFam
        lueTramoCargaFamiliar.Properties.DisplayMember = "DESCRIPCION"
        lueTramoCargaFamiliar.Properties.NullText = ""
        lueTramoCargaFamiliar.Properties.PopupWidth = 400
        lueTramoCargaFamiliar.Properties.ValueMember = "TRAMO_ASIGNACION_FAMILIAR_ID"
    End Sub
    Private Sub btnGuardarDatosRemuneracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarDatosRemuneracion.Click
        Dim validaUpdate As Boolean = False
        numeroBieniosOld = empleado.datosRemuneracion.numeroBienios
        If validacionesRemun() Then
            asignacionCamposDatosRemuneracion(empleado)
            If empleado.datosRemuneracion.antecedenteRemunID = 0 Then
                Try
                    'Crear un nuevo registro
                    empleado.datosRemuneracion.antecedenteRemunID = empleado.CrearEmpleadoRemun()
                    MsgBox("El registro fue creado satisfactoriamente", MsgBoxStyle.Information)
                    validaUpdate = True
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al crear el registro " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            Else
                Try
                    'Actualizar un registro
                    empleado.actualizarDatosRemun(empleado.datosRemuneracion)
                    MsgBox("Los datos han sido actualizados correctamente", MsgBoxStyle.Information)
                    validaUpdate = True
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al actualizar " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
        End If
        If validaUpdate Then
            Dim origen As Integer = Comun.TiposDeDatos.TipoOrigenItem.FICHA_EMPLEADO
            Dim tipoProceso As String = "N"
            Try
                empleado.CrearItemEmpleado(empleado, parametroMensual, origen, tipoProceso)
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al intentar crear el items para el empleado " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub
    Private Sub asignacionCamposDatosRemuneracion(ByVal empleado As BusinessRules.Empleado)
        With empleado.datosRemuneracion
            .estadoRegistroRemun = Comun.TiposDeDatos.EstadoRegistro.ACTIVO
            .asociacionGremialID = lueAsociacionGremial.EditValue
            If dteFechaIngAsocGremial.Text <> "" Then
                .fechaAfiliacionGremial = dteFechaIngAsocGremial.Text
            Else
                .fechaAfiliacionGremial = "01-01-1900"
            End If
            If rdgFondoBienestar.EditValue = 0 Then
                .afiliadoBienestar = False
            Else
                .afiliadoBienestar = True
            End If
            If dteFechaIngBienestar.Text <> "" Then
                .fechaAfiliacionBienestar = dteFechaIngBienestar.Text
            Else
                .fechaAfiliacionBienestar = "01-01-1900"
            End If
            .formaPago = rdgFormaPago.EditValue
            .bancoID = lueBanco.EditValue
            .tipoCuentaDestinoID = lueTipoCuentaBanco.EditValue
            .numeroCuenta = txtNumeroCuentaBanco.Text
            .asignacionProfesional = empleado.datosEUS.esProfesional
            .aplicaLey3551 = empleado.datosEUS.aplicaLey3551
            .numeroBienios = speNumeroBienios.EditValue
            If dteFechaCumplioBienio.Text <> "" Then
                .fechaCumplioBienios = dteFechaCumplioBienio.Text
            Else
                .fechaCumplioBienios = "01-01-1900"
            End If
            .tramoAsignacionFamiliarID = lueTramoCargaFamiliar.EditValue
            .cargaFamiliarNormal = speCargaFamNormal.EditValue
            .cargaFamiliarInvalida = speCargaFamInvalidez.EditValue
            .cargaFamiliarPrenatal = speCargaFamPreNatal.EditValue
            .rentaBase = CType(txtMontoRentaBase.Text, Integer)
            .sueldoBase = CType(txtMontoSueldoBase.Text, Integer)
            .valorAsignacionProfesional = CType(txtMontoLey19185Art19.Text, Integer)
            .valorAsignacionResposabilidad = CType(txtMontoAsigResponsabilidadSuperior.Text, Integer)
            .valorAsignacionLey19185Art18 = CType(txtMontoLey19185Art18.Text, Integer)
            .valorFuncionCritica = CType(txtMontoFuncionCritica.Text, Integer)
            If empleado.datosEUS.aplicaGastoRepresentacion = 1 Then
                .asignaGastoRepresentacion = True
            Else
                .asignaGastoRepresentacion = False
            End If

            .valorGastoRepresentacion = CType(txtGastoRepresentacion.Text, Integer)
            .valorAsignacionLey18717 = CType(txtLey18717.Text, Integer)
            .valorAsignacionLey18675Art10 = CType(txtLey18675Art10.Text, Integer)
            .valorAsignacionLey18675Art11 = CType(txtLey18675Art11.Text, Integer)
            .valorAsignacionLey18566 = CType(txtLey18566.Text, Integer)
            .valorLey3551 = CType(txtMontoLey3551.Text, Integer)
            .valorIncrementoPrevisionalDL3501 = CType(txtIncrementoPrevisDL3501.Text, Integer)
            .periodo = parametroMensual.ID
            If .antecedenteRemunID = 0 Then
                .ultimoPeriodoLiquidacion = ""
            End If
            .anno = CType(parametroMensual.ano, String)
            .porcentajeLey19863 = txtPorcentajeLey19863.EditValue
            If empleado.datosLaborales.calidadJuridicaID = Comun.TiposDeDatos.TipoCalidadJuridica.HONORARIOS Then
                .entregoBoletaHonorario = Me.chkEntregoBoletaHonorario.Checked
            Else
                .entregoBoletaHonorario = False
            End If
            If empleado.datosRemuneracion.antecedenteRemunID = 0 And empleado.datosRemuneracion.numeroBienios > 0 Then
                .autorizaPagoBienio = False
                .observacionAutorizaPago = "PENDIENTE APROBACION JEFATURA RRHH"
            ElseIf empleado.datosRemuneracion.antecedenteRemunID = 0 And empleado.datosRemuneracion.numeroBienios = 0 Then
                .autorizaPagoBienio = False
                .observacionAutorizaPago = ""
            ElseIf empleado.datosRemuneracion.antecedenteRemunID > 0 And empleado.datosRemuneracion.numeroBienios <> numeroBieniosOld And empleado.datosRemuneracion.autorizaPagoBienio = False And empleado.datosRemuneracion.numeroBienios > 0 Then
                .autorizaPagoBienio = False
                .observacionAutorizaPago = "PENDIENTE APROBACION JEFATURA RRHH"
            ElseIf empleado.datosRemuneracion.antecedenteRemunID > 0 And empleado.datosRemuneracion.numeroBienios <> numeroBieniosOld And empleado.datosRemuneracion.autorizaPagoBienio = True And empleado.datosRemuneracion.numeroBienios > 0 Then
                .autorizaPagoBienio = False
                .observacionAutorizaPago = "PENDIENTE APROBACION JEFATURA RRHH"
            ElseIf empleado.datosRemuneracion.antecedenteRemunID > 0 And empleado.datosRemuneracion.numeroBienios = 0 Then
                .autorizaPagoBienio = False
                .observacionAutorizaPago = ""
            End If
            Me.memObservacionesBienio.Text = .observacionAutorizaPago
            '.enviarHaciaDexon = chkEnviarHaciaDexon.Checked
            '.numeroCompromisoDexon = txtNumeroCompromiso.Text

            'agregado por segegob
            .zonaID = lueZona.EditValue
            .montoAsignacionZona = txtMontoAsignacionZona.EditValue
            .AsignaLey18675Art11 = chkAsignaLey18675Art11.Checked

        End With
    End Sub
    Function validacionesRemun() As Boolean
        Dim respuesta As Boolean = True
        'Afiliado a asociación gremial
        If (lueAsociacionGremial.EditValue = 1 Or lueAsociacionGremial.EditValue = 2) Then
            If dteFechaIngAsocGremial.Text = "" Or dteFechaIngAsocGremial.Text < empleado.fechaIngresoInstitucion.ToShortDateString Then
                MsgBox("Fecha ingreso asociación gremial no puede ser anterior a fecha ingreso institución (" & empleado.fechaIngresoInstitucion & ")", MsgBoxStyle.Exclamation)
                respuesta = False
            End If
        End If
        'Afiliado a fondo bienestar
        If rdgFondoBienestar.EditValue = 1 Then
            If dteFechaIngBienestar.Text = "" Or dteFechaIngBienestar.Text < empleado.fechaIngresoInstitucion.ToShortDateString Then
                MsgBox("Fecha afiliación bienestar no puede ser anterior a fecha ingreso institución (" & empleado.fechaIngresoInstitucion & ")", MsgBoxStyle.Exclamation)
                respuesta = False
            End If
        End If
        'Bienios mayor a cero
        If speNumeroBienios.EditValue > 0 Then
            If dteFechaCumplioBienio.Text = "" Or dteFechaCumplioBienio.Text < empleado.fechaIngresoInstitucion.ToShortDateString Then
                MsgBox("Fecha cumplio bienios no puede ser anterior a fecha ingreso institución (" & empleado.fechaIngresoInstitucion & ")", MsgBoxStyle.Exclamation)
                respuesta = False
            End If
        End If
        Return respuesta
    End Function
    Function validacionesLaboral() As Boolean
        Dim respuesta As Boolean = True
        If lueCalJur.EditValue = Nothing Or CType(lueCalJur.EditValue, Integer) <= 0 Then
            lueCalJur.ErrorText = "Falta ingresar calidad jurídica"
            respuesta = False
        End If
        If cbbClasificacionEmpleado.EditValue = Nothing Or CType(cbbClasificacionEmpleado.EditValue, Integer) <= 0 Then
            cbbClasificacionEmpleado.ErrorText = "Falta ingresar clasificación del empleado"
            respuesta = False
        End If
        If cbbGrado.EditValue = Nothing Or CType(cbbGrado.EditValue, Integer) <= 0 Then
            cbbGrado.ErrorText = "Falta ingresar grado"
            respuesta = False
        End If
        If cbbEscalafon.EditValue = Nothing Or CType(cbbEscalafon.EditValue, Integer) <= 0 Then
            cbbEscalafon.ErrorText = "Falta ingresar escalafón"
            respuesta = False
        End If
        If dedFechaIngAdmPublica.Text = "" Or dedFechaIngAdmPublica.EditValue = Nothing Then
            dedFechaIngAdmPublica.ErrorText = "Fecha ingreso a administración pública es incorrecta"
            respuesta = False
        Else
            If dedFechaIngAdmPublica.EditValue < dedFechaNacimiento.EditValue Then
                dedFechaIngAdmPublica.ErrorText = "Fecha ingreso a administración pública es anterior a fecha de nacimiento"
                respuesta = False
            End If
        End If
        If dedFechaIngInstitucion.Text = "" Or dedFechaIngInstitucion.EditValue = Nothing Then
            dedFechaIngInstitucion.ErrorText = "Fecha ingreso a la institución es incorrecta"
            respuesta = False
        Else
            If dedFechaIngInstitucion.EditValue < dedFechaNacimiento.EditValue Then
                dedFechaIngInstitucion.ErrorText = "Fecha ingreso a la institución es anterior a fecha de nacimiento"
                respuesta = False
            Else
                If dedFechaIngInstitucion.EditValue < dedFechaIngAdmPublica.EditValue Then
                    dedFechaIngInstitucion.ErrorText = "Fecha ingreso a la institución es anterior a fecha de ingreso a la administración pública"
                    respuesta = False
                End If
            End If
        End If
        If cbbEstamento.EditValue = Nothing Or CType(cbbEstamento.EditValue, Integer) <= 0 Then
            cbbEstamento.ErrorText = "Falta ingresar estamento"
            respuesta = False
        End If
        If cbbJefeDirecto.EditValue = Nothing Or CType(cbbJefeDirecto.EditValue, Integer) <= 0 Then
            cbbJefeDirecto.ErrorText = "Falta ingresar jefe"
            respuesta = False
        End If
        If cbbUbicacionFisica.EditValue = Nothing Or CType(cbbUbicacionFisica.EditValue, Integer) <= 0 Then
            cbbUbicacionFisica.ErrorText = "Falta ingresar ubicación del lugar de trabajo"
            respuesta = False
        End If
        If cbbHorarioTrabajo.EditValue = Nothing Or CType(cbbHorarioTrabajo.EditValue, Integer) <= 0 Then
            cbbHorarioTrabajo.ErrorText = "Falta ingresar horario de trabajo"
            respuesta = False
        End If
        Return respuesta
    End Function
    Private Sub dteFechaIngAsocGremial_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If dteFechaIngAsocGremial.Text < empleado.fechaNacimiento And (lueAsociacionGremial.EditValue = 1 Or lueAsociacionGremial.EditValue = 2) Then
            MsgBox("Fecha de ingreso asociación gremial no puede ser anterior a la fecha de nacimiento (" & empleado.fechaNacimiento & ")", MsgBoxStyle.Exclamation)
            e.Cancel = True
        End If
        If rdgFondoBienestar.EditValue = 0 Then
            If dteFechaIngBienestar.Text < empleado.fechaNacimiento Then

            End If
        End If
    End Sub
    Private Sub inicializaDatosBasicosAntecedenteLaboral()
        'Estos valores solo se deben aplicar cuando es un nuevo registro en antecedente laboral
        If EsFichaHistorica Then
            empleado.datosLaborales.estadoRegistro = Comun.TiposDeDatos.EstadoRegistro.HISTORICO
        Else
            empleado.datosLaborales.estadoRegistro = Comun.TiposDeDatos.EstadoRegistro.ACTIVO   'Activo
        End If

        empleado.datosLaborales.tipoMovimientoID = Comun.TiposDeDatos.TipoMovimientoLaboral.CONTRATADO  'Contratado
        empleado.datosLaborales.diasGrado = 0
        If empleado.estadoEmpleadoID = Comun.TiposDeDatos.TipoEstado.POR_ACTIVAR Then
            empleado.datosLaborales.descripcionMovimiento = "Ingresado"
        End If
        empleado.datosLaborales.fechaMovimiento = Date.Today
        empleado.datosLaborales.fechaIngresoCalidadJuridica = empleado.datosLaborales.fechaIngresoInstitucion
        empleado.datosLaborales.fechaIngresoEstamento = empleado.datosLaborales.fechaIngresoInstitucion
        empleado.datosLaborales.fechaIngresoGrado = empleado.datosLaborales.fechaIngresoInstitucion
        empleado.datosLaborales.fechaIngresoEscalafon = empleado.datosLaborales.fechaIngresoInstitucion
        empleado.datosLaborales.fechaIngresoDepartamento = empleado.datosLaborales.fechaIngresoInstitucion
        empleado.datosLaborales.tipoBeneficiarioID = 0
    End Sub

    Private Sub btnGuardarAPV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarAPV.Click
        asignacionCamposAPV(empleado)
        If empleado.datosAPV.antecedenteApvID = 0 Then
            empleado.CrearEmpleadoAPV()
            dgAntecedenteAPV.DataSource = empleado.dvDatosAPV
            empleado.datosAPV.antecedenteApvID = 0
        Else
            Try
                'Actualiza registro
                empleado.actualizarDatosAPV(empleado.datosAPV)
                dgAntecedenteAPV.DataSource = empleado.dvDatosAPV
                rdgTipoAhorro.SelectedIndex = -1
                lueAPV.EditValue = 0
                txtMontoAPV.Text = ""
                lueUnidadMontoAPV.EditValue = 0
                empleado.datosAPV.antecedenteApvID = 0
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al actualizar el registro " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If

    End Sub
    Private Sub btnGuardarDatosLaborales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarDatosLaborales.Click
        If validacionesLaboral() Then
            asignacionCamposDatosLaborales(empleado)
            If empleado.datosLaborales.antecedenteLaboralID = 0 Then
                Try
                    'Asigna los valores por defecto solo cuando es un nuevo resgistro laboral
                    inicializaDatosBasicosAntecedenteLaboral()
                    empleado.datosLaborales.periodoIDCambioSituacionLaboral = 0
                    empleado.datosLaborales.antecedenteLaboralID = empleado.CrearEmpleadoLaboral()
                    refrescarMaestroEmpleado()
                    generaMontosAsignaciones()
                    MsgBox("Los datos laborales de " & empleado.nombreCompleto & " han sido actualizados", MsgBoxStyle.Information)
                Catch excepcion As Exception
                    MsgBox("Ha ocurrido un error al actualizar " & empleado.nombreCompleto & " " & excepcion.Message, MsgBoxStyle.Exclamation)
                End Try
            Else
                Try
                    empleado.actualizarDatosLaboral(empleado.datosLaborales)
                    refrescarMaestroEmpleado()
                    If generaAsignaciones Then
                        generaMontosAsignaciones()
                    End If
                    MsgBox("Los datos laborales de " & empleado.nombreCompleto & " han sido actualizados", MsgBoxStyle.Information)
                Catch excepcion As Exception
                    MsgBox("Ha ocurrido un error al actualizar " & empleado.nombreCompleto & " " & excepcion.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
        End If
    End Sub
    Private Sub asignacionCamposDatosLaborales(ByVal empleado As BusinessRules.Empleado)
        With empleado
            ' Valores de Datos Laborales
            .datosLaborales.calidadJuridicaID = lueCalJur.EditValue
            .datosLaborales.clasificacionEmpleadoID = cbbClasificacionEmpleado.EditValue
            .datosLaborales.estamentoID = cbbEstamento.EditValue
            .datosLaborales.gradoID = cbbGrado.EditValue
            .datosLaborales.jefeID = cbbJefeDirecto.EditValue
            .datosLaborales.escalafonID = cbbEscalafon.EditValue
            .datosLaborales.ubicaconFisicaID = cbbUbicacionFisica.EditValue
            .datosLaborales.numeroTarjetaMagnetica = 0
            .datosLaborales.horarioID = cbbHorarioTrabajo.EditValue
            .datosLaborales.resolucionContrato = txtNroResolucionContrato.Text
            .datosLaborales.fechaIngresoInstitucion = dedFechaIngInstitucion.Text
            .datosLaborales.fechaIngresoAdministracionPublica = dedFechaIngAdmPublica.Text
            .datosLaborales.tituloProfesionalExpertiz = txtTituloProfesionalExpertiz.Text
            .datosLaborales.funcionDesempeño = txtFuncionDesempeno.Text
            .datosLaborales.publicaDatosWeb = chkPublicaDatos.Checked
            .datosLaborales.estadoEmpleadoID = empleado.estadoEmpleadoID
            .datosLaborales.numeroAcceso = txtNumeroAcceso.Text
            If .datosLaborales.antecedenteLaboralID = 0 Then
                .datosLaborales.periodoID = parametroMensual.ID
            Else
                .datosLaborales.fechaRetiro = dedFechaRetiro.EditValue
                .datosLaborales.motivoRetiroID = cbbMotivoRetiro.EditValue
                .datosLaborales.resolucionRetiro = txtResolucionRetiro.Text
                .datosLaborales.periodoID = parametroMensual.ID
            End If
            .datosLaborales.tipoBeneficiarioID = lueTipoBeneficiario.EditValue
            .datosLaborales.cargo = txtCargo.Text
            .datosLaborales.jefeEvaluadorId = cbbJefeEvalDesempeno.EditValue
            .datosLaborales.incluirEvalDesempeno = Me.chkIncluirParaEvaluacionDesempeño.Checked
            ' Fin Valores Datos Laborales
        End With
    End Sub

    Private Sub mnuRptFichaEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRptFichaEmpleado.Click
        If Not empleado Is Nothing Then
            Dim ventanaReporte1 As New ventanaReporte
            Dim reporte As New rptFichaDelEmpleado
            reporte.RecordSelectionFormula = "{VW_MAESTRO_EMPLEADO_COMPLETO.EMPLEADO_ID}= " & empleado.ID
            ventanaReporte1.rptVisor.ShowParameterPanelButton = False
            ventanaReporte1.rptVisor.ShowCloseButton = False
            ventanaReporte1.rptVisor.ShowGroupTreeButton = False
            ventanaReporte1.rptVisor.ReportSource = reporte
            ventanaReporte1.Show()
            Me.Close()
        End If
    End Sub
    Private Sub mnuLstAntiguedad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLstAntiguedad.Click
        Dim frmFiltro As New frmFiltroRptAntiguedadEmpleados
        frmFiltro.Show()
    End Sub
    Private Sub frmFichaEmpleado_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Not empleado Is Nothing Then
            If empleado.datosLaborales.antecedenteLaboralID = 0 And empleado.ID > 0 Then
                MsgBox("Obligadamente debe ingresar los datos laborales de " & empleado.nombreCompleto, MsgBoxStyle.Information)
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub valoresPorDefaultRemun()
        lueAsociacionGremial.EditValue = CType(3, Integer)
        dteFechaIngAsocGremial.EditValue = ""
        rdgFondoBienestar.EditValue = 0           'No afiliado
        dteFechaIngBienestar.EditValue = ""
        rdgFormaPago.EditValue = 1                'Efectivo
        lueBanco.EditValue = CType(0, Integer)
        lueTipoCuentaBanco.EditValue = CType(0, Integer)
        txtNumeroCuentaBanco.Text = ""
        speNumeroBienios.EditValue = 0
        dteFechaCumplioBienio.EditValue = ""
        lueTramoCargaFamiliar.EditValue = CType(4, Byte)
        speCargaFamNormal.EditValue = 0
        speCargaFamInvalidez.EditValue = 0
        speCargaFamPreNatal.EditValue = 0
        txtMontoRentaBase.Text = 0
        txtMontoSueldoBase.Text = 0
        txtMontoLey19185Art19.Text = 0
        txtMontoLey3551.Text = 0
        txtMontoAsigResponsabilidadSuperior.Text = 0
        txtMontoLey19185Art18.Text = 0
        txtMontoFuncionCritica.Text = 0
        txtGastoRepresentacion.Text = 0
        txtLey18717.Text = 0
        txtLey18675Art10.Text = 0
        txtLey18675Art11.Text = 0
        txtLey18566.Text = 0
        txtIncrementoPrevisDL3501.Text = 0
        txtPorcentajeLey19863.EditValue = 0
    End Sub
    Private Sub valoresPorDefaultLaboral()
        lueCalJur.EditValue = 1
        cbbClasificacionEmpleado.EditValue = 1
        cbbGrado.EditValue = 39
        cbbEscalafon.EditValue = 1
        cbbEstamento.EditValue = 1
        cbbJefeDirecto.EditValue = 1
        cbbJefeEvalDesempeno.EditValue = 1
        cbbUbicacionFisica.EditValue = 1
        cbbHorarioTrabajo.EditValue = 1
        chkIncluirParaEvaluacionDesempeño.Checked = False
        txtCargo.Text = ""
    End Sub

    Private Sub txtRut_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRut.Validating
        If txtRut.Text <> "" And txtRut.Text <> "0" And txtRut.Text <> Nothing Then
            repositorio.dvEmpleadoVista.RowFilter = "RUT='" & txtRut.EditValue & "'"
            If repositorio.dvEmpleadoVista.Count = 1 Then
                btnGuardar.Enabled = False
                If MsgBox("Error, ya existe el rut ingresado", MsgBoxStyle.Information) Then
                    e.Cancel = True
                End If
            End If
            dvEmpleados.RowFilter = ""
        Else
            validaControlesDatosPersonales()
        End If
    End Sub
    Private Sub validaControlesDatosPersonales()
        Dim botonGuardar As Boolean = True
        If txtApellidoPaterno.Text = Nothing Or txtApellidoPaterno.Text = "" Then
            botonGuardar = False
        End If
        If txtApellidoMaterno.Text = Nothing Or txtApellidoMaterno.Text = "" Then
            botonGuardar = False
        End If
        If txtNombres.Text = Nothing Or txtNombres.Text = "" Then
            botonGuardar = False
        End If
        If txtDV.Text = Nothing Or txtDV.Text = "" Then
            botonGuardar = False
        End If
        If dedFechaNacimiento.EditValue = Nothing Or dedFechaNacimiento.Text = "" Then
            botonGuardar = False
        End If
        If cbbEstadoCivil.SelectedIndex = -1 Then
            botonGuardar = False
        End If
        If cbbNivelEstudio.EditValue = -1 Then
            botonGuardar = False
        End If
        If rdgSexo.EditValue = Nothing Or rdgSexo.SelectedIndex = -1 Then
            botonGuardar = False
        End If
        btnGuardar.Enabled = botonGuardar
    End Sub
    Private Sub validaControlesDatosApv()
        Dim botonGuardar As Boolean = True
        If rdgTipoAhorro.SelectedIndex = -1 Then
            botonGuardar = False
        End If
        If txtMontoAPV.Text = "" Then
            botonGuardar = False
        End If
        If lueAPV.EditValue = Nothing Then
            botonGuardar = False
        End If
        If lueUnidadMontoAPV.EditValue = Nothing Then
            botonGuardar = False
        End If
        btnGuardarAPV.Enabled = botonGuardar

    End Sub

    Private Sub validaControlesEstructuraOrganizacional()
        Dim botonGuardar As Boolean = True
        If lueInstitucion.EditValue = Nothing Then
            botonGuardar = False
        End If
        If lueDireccion.EditValue = Nothing Then
            botonGuardar = False
        End If
        If lueDepartamento.EditValue = Nothing Then
            botonGuardar = False
        End If
        If lueCentroCostoContable.EditValue = Nothing Then
            botonGuardar = False
        End If
        If lueCentroCostoPresupuesto.EditValue = Nothing Then
            botonGuardar = False
        End If
        If txtPorcentajeDistribucion.EditValue = Nothing Then
            botonGuardar = False
        End If
    End Sub
    Private Sub txtNombres_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombres.Validating, txtApellidoPaterno.Validating, txtApellidoMaterno.Validating, txtRut.Validating, txtDV.Validating, dedFechaNacimiento.Validating, cbbEstadoCivil.Validating
        validaControlesDatosPersonales()
    End Sub
    Private Sub rdgSexo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdgSexo.EditValueChanged
        validaControlesDatosPersonales()
    End Sub
    Private Sub generaMontosAsignaciones()
        Dim idCalJuridica, idGrado, idClasEmpleado, idAfp, idIsapre, numBienios As Integer

        If lueCalJur.EditValue <> Nothing Then
            idCalJuridica = lueCalJur.EditValue
        Else
            idCalJuridica = 0
        End If
        If cbbGrado.EditValue <> Nothing Then
            idGrado = cbbGrado.EditValue
        Else
            idGrado = 0
        End If
        If cbbClasificacionEmpleado.EditValue <> Nothing Then
            idClasEmpleado = cbbClasificacionEmpleado.EditValue
        Else
            idClasEmpleado = 0
        End If
        If lueAfp.EditValue <> Nothing Then
            idAfp = lueAfp.EditValue
        Else
            idAfp = 0
        End If
        If lueIsapre.EditValue <> Nothing Then
            idIsapre = lueIsapre.EditValue
        Else
            idIsapre = 0
        End If
        If speNumeroBienios.EditValue <> Nothing Then
            numBienios = speNumeroBienios.EditValue
        Else
            numBienios = 0
        End If
        If empleado.recuperarDatosEUSEmpleado(empleado, idCalJuridica, idGrado, _
                                              idClasEmpleado, numBienios, idAfp, idIsapre, parametroMensual) Then
            empleado.datosRemuneracion.anno = empleado.datosEUS.anno
            'Monto sueldo base
            txtMontoSueldoBase.Text = empleado.datosRemuneracion.sueldoBase
            'Monto resposabilidad superior
            txtMontoAsigResponsabilidadSuperior.Text = empleado.datosRemuneracion.valorAsignacionResposabilidad
            'Monto por concepto según función desempeñada
            txtMontoLey19185Art18.Text = empleado.datosRemuneracion.valorAsignacionLey19185Art18
            'Monto bonificación ley 18.675 art.10 compensatoria pensiones AFP
            txtLey18675Art10.Text = empleado.datosRemuneracion.valorAsignacionLey18675Art10
            'Monto bonificación ley 18.675 art.11 compensatoria pensiones INP
            txtLey18675Art11.Text = empleado.datosRemuneracion.valorAsignacionLey18675Art11
            'Monto bonificación ley 18.566 compensatria salud
            txtLey18566.Text = empleado.datosRemuneracion.valorAsignacionLey18566
            'Monto ley 18.717 
            txtLey18717.Text = empleado.datosRemuneracion.valorAsignacionLey18717
            'Monto asignación para profesional ley 19.185 art.19
            txtMontoLey19185Art19.Text = empleado.datosRemuneracion.valorAsignacionProfesional
            'Monto gasto representación
            txtGastoRepresentacion.Text = empleado.datosRemuneracion.valorGastoRepresentacion
            'Monto ley 3.551
            txtMontoLey3551.Text = empleado.datosRemuneracion.valorLey3551
            'Monto incrememto previsional DL 3501
            txtIncrementoPrevisDL3501.Text = empleado.datosRemuneracion.valorIncrementoPrevisionalDL3501
            generaMontoAsignacionZona()
        End If
    End Sub

    Private Sub generaMontoAsignacionZona()
        If parametroMensual.aplicaAsignacionZona = False Then
            txtMontoAsignacionZona.Text = 0
        Else
            txtMontoAsignacionZona.Text = empleado.recuperarMontosAsignacionesZona(lueZona.EditValue, parametroMensual.ID, txtMontoSueldoBase.EditValue)
        End If
    End Sub

    Private Sub lueAfp_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueAfp.EditValueChanged
        'Si el empleado pertenece al regimen previsional AFP o INP se le asigna
        'los valores según corresponda.
        Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
        Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
        If Not IsNothing(row) Then
            generaMontosAsignaciones()
        End If
    End Sub

    Private Sub lueIsapre_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueIsapre.EditValueChanged
        If lueIsapre.EditValue <> Nothing Then
            generaMontosAsignaciones()
        End If
    End Sub

    Private Sub lueCalJur_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueCalJur.EditValueChanged
        If lueCalJur.EditValue <> Nothing Then
            If edicion Then
                generaMontosAsignaciones()
            End If
        End If
    End Sub

    Private Sub cbbClasificacionEmpleado_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbClasificacionEmpleado.EditValueChanged
        If cbbClasificacionEmpleado.EditValue <> Nothing Then
            If edicion Then
                generaMontosAsignaciones()
            End If
        End If
    End Sub

    Private Sub cbbGrado_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbGrado.EditValueChanged
        If cbbGrado.EditValue <> Nothing Then
            If edicion Then
                generaMontosAsignaciones()
            End If
        End If
    End Sub

    Private Sub speNumeroBienios_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles speNumeroBienios.EditValueChanged
        If edicion Then
            generaMontosAsignaciones()
        End If
    End Sub

    Private Sub btnConfirmarFotografia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmarFotografia.Click
        ' Se valida si se ha creado o seleccionado un empleado.
        If empleado.ID = 0 Then
            MessageBox.Show("Para guardar la fotografía debe primero guardar los datos del empleado. La fotografía no ha sido confirmada.", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Not picEmpleado.Image Is Nothing Then
            Dim con As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
            Dim da As New SqlDataAdapter("Select * From RH_PER_EMPLEADO WHERE EMPLEADO_ID=" & empleado.ID, con)
            Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(da)
            Dim ds As New DataSet

            da.MissingSchemaAction = MissingSchemaAction.AddWithKey

            con.Open()
            da.Fill(ds, "Empleados")
            Dim myRow As DataRow
            myRow = ds.Tables("Empleados").Rows.Find(empleado.ID)
            myRow("FOTO_EMPLEADO") = Comun.Funciones.Imagenes.Image2Bytes(picEmpleado.Image)
            da.Update(ds, "Empleados")

            MyCB = Nothing
            ds = Nothing
            da = Nothing

            con.Close()
            con = Nothing
        End If
    End Sub

    Private Function fotografiaEmpleado(ByVal empleadoID As Long) As System.Drawing.Image
        Dim retornoImagen As System.Drawing.Image
        Dim con As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim da As New SqlDataAdapter("Select EMPLEADO_ID, FOTO_EMPLEADO From RH_PER_EMPLEADO WHERE EMPLEADO_ID=" & empleado.ID, con)
        Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(da)
        Dim ds As New DataSet
        Try
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey
            con.Open()
            da.Fill(ds, "Empleados")
            Dim myRow As DataRow
            myRow = ds.Tables("Empleados").Rows.Find(empleado.ID)
            If Not TypeOf myRow("FOTO_EMPLEADO") Is System.DBNull Then 'And CType(myRow("FOTO_EMPLEADO")(0), Integer) <> 32 Then
                retornoImagen = Comun.Funciones.Imagenes.Bytes2Image(myRow("FOTO_EMPLEADO"))
            Else
                Dim bm As Bitmap = Nothing
                bm = New Bitmap(117, 115, Imaging.PixelFormat.Format24bppRgb)
                Dim graphicImage As Graphics = Graphics.FromImage(bm)
                graphicImage.Clear(System.Drawing.Color.White)
                graphicImage.DrawString("No Disponible", New Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 17, 50)
                retornoImagen = bm
            End If
        Catch e As InvalidCastException
            Return retornoImagen
        Finally
            MyCB = Nothing
            ds = Nothing
            da = Nothing

            con.Close()
            con = Nothing

        End Try
        Return retornoImagen

    End Function

    Private Sub rdgTipoAhorro_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdgTipoAhorro.EditValueChanged
        validaControlesDatosApv()
    End Sub


    Private Sub lueAPV_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueAPV.EditValueChanged
        validaControlesDatosApv()
    End Sub

    Private Sub lueUnidadMontoAPV_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueUnidadMontoAPV.EditValueChanged
        validaControlesDatosApv()
    End Sub

    Private Sub txtMontoAPV_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMontoAPV.Validating
        validaControlesDatosApv()
    End Sub

    Private Sub lueInstitucion_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueInstitucion.EditValueChanged
        validaControlesEstructuraOrganizacional()
    End Sub

    Private Sub lueDireccion_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueDireccion.EditValueChanged
        validaControlesEstructuraOrganizacional()
    End Sub

    Private Sub lueDepartamento_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueDepartamento.EditValueChanged
        validaControlesEstructuraOrganizacional()
    End Sub

    Private Sub cbbNivelEstudio_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbNivelEstudio.EditValueChanged
        validaControlesDatosPersonales()
    End Sub

    Private Sub dedFechaNacimiento_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dedFechaNacimiento.EditValueChanged
        If dedFechaNacimiento.EditValue <> Nothing Then
            validaControlesDatosPersonales()
            txtEdad.Text = Math.Round(Comun.Funciones.FechaFinal.Edad(dedFechaNacimiento.EditValue), 1)
        End If
    End Sub

    Private Sub btnGuardarEstrucOrg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarEstrucOrg.Click
        If lueInstitucion.EditValue > 0 And lueDireccion.EditValue > 0 And lueDepartamento.EditValue > 0 And lueEvaluadorDesempeno.EditValue > 0 And lueAutorizadorHorasExtras.EditValue > 0 Then
            Dim autorizador As Empleado
            autorizador = New Empleado(CType(lueAutorizadorHorasExtras.EditValue, Long))
            If empleado.datosEstructuraOrganica.estructuraOrganicaId = 0 Then
                'If autorizador.datosEstructuraOrganica.deptoID = lueDepartamento.EditValue Then
                Try
                    asignacionCamposEstructuraOrg()
                    If EsFichaHistorica Then
                        empleado.datosEstructuraOrganica.estadoRegistro = Comun.TiposDeDatos.EstadoRegistro.HISTORICO
                    Else
                        empleado.datosEstructuraOrganica.estadoRegistro = Comun.TiposDeDatos.EstadoRegistro.ACTIVO
                    End If

                    empleado.datosEstructuraOrganica.empleadoID = empleado.ID
                    empleado.datosEstructuraOrganica.estructuraOrganicaId = empleado.CrearEmpleadoEstructuraOrganica()
                    gdcEstructuraOrganica.DataSource = empleado.dvEstructuraOrganicaEmpleado
                    MsgBox("Los datos han sido actualizados correctamente", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al crear la estructura orgánica " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
                'Else
                'MsgBox("El autorizador de horas extras debe pertenecer al mismo departamento", MsgBoxStyle.Information, "SIGA")
                'End If
            Else
                'If autorizador.datosEstructuraOrganica.deptoID = lueDepartamento.EditValue Then
                Try
                    If lueInstitucion.EditValue <> empleado.datosEstructuraOrganica.organizacionID Or lueDireccion.EditValue <> empleado.datosEstructuraOrganica.direccionID Or lueDepartamento.EditValue <> empleado.datosEstructuraOrganica.deptoID Or lueEvaluadorDesempeno.EditValue <> empleado.datosEstructuraOrganica.evaluadorDesempenoID Or lueAutorizadorHorasExtras.EditValue <> empleado.datosEstructuraOrganica.autorizadorHorasExtrasID Or Me.lueSubDepto.EditValue <> empleado.datosEstructuraOrganica.subDeptoId Then
                        asignacionCamposEstructuraOrg()
                        empleado.actualizarDatosEstructuraOrganica(empleado.datosEstructuraOrganica)
                        gdcEstructuraOrganica.DataSource = empleado.dvEstructuraOrganicaEmpleado
                        MsgBox("Los datos han sido actualizados correctamente", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al actualizar la estructura orgánica " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
                'Else
                'MsgBox("El autorizador de horas extras debe pertenecer al mismo departamento", MsgBoxStyle.Information, "SIGA")
                'lueAutorizadorHorasExtras.ErrorText = "El autorizador de horas extras debe pertenecer al mismo departamento"
                'End If
            End If
            If empleado.datosEstructuraOrganica.estructuraOrganicaId > 0 And empleado.datosEstructuraOrganica.estadoRegistro = 1 Then
                btnCancelarEstrucOrg.Enabled = False
                btnEliminarEstrucOrg.Enabled = True
            Else
                btnCancelarEstrucOrg.Enabled = True
                btnEliminarEstrucOrg.Enabled = False
            End If
        Else
            If lueInstitucion.EditValue <= 0 Then
                lueInstitucion.ErrorText = "Falta ingresar institución"
            End If
            If lueDireccion.EditValue <= 0 Then
                lueDireccion.ErrorText = "Falta ingresar dirección"
            End If
            If lueDepartamento.EditValue <= 0 Then
                lueDepartamento.ErrorText = "Falta ingresar departamento"
            End If
            If lueEvaluadorDesempeno.EditValue <= 0 Then
                lueEvaluadorDesempeno.ErrorText = "Falta ingresar evaluador de desempeño"
            End If
            If lueAutorizadorHorasExtras.EditValue <= 0 Then
                lueAutorizadorHorasExtras.ErrorText = "Falta ingresar autorizador horas extras"
            End If
        End If
    End Sub

    Private Sub btnEliminarEstrucOrg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarEstrucOrg.Click
        If lueInstitucion.EditValue > 0 And lueDireccion.EditValue > 0 And lueDepartamento.EditValue > 0 Then
            If MsgBox("¿Está usted seguro(a) que desea eliminar este registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                empleado.EliminarEmpleadoEstructuraOrganica(empleado.datosEstructuraOrganica.estructuraOrganicaId)
                lueInstitucion.EditValue = CType(-1, Integer)
                lueDireccion.EditValue = CType(-1, Integer)
                lueDepartamento.EditValue = CType(-1, Integer)
                lueEvaluadorDesempeno.EditValue = CType(-1, Integer)
                lueAutorizadorHorasExtras.EditValue = CType(-1, Integer)
                gdcEstructuraOrganica.DataSource = empleado.dvEstructuraOrganicaEmpleado
                empleado.datosEstructuraOrganica.estructuraOrganicaId = 0
                If empleado.datosEstructuraOrganica.estructuraOrganicaId > 0 And empleado.datosEstructuraOrganica.estadoRegistro = 1 Then
                    btnCancelarEstrucOrg.Enabled = False
                    btnEliminarEstrucOrg.Enabled = True
                Else
                    btnCancelarEstrucOrg.Enabled = True
                    btnEliminarEstrucOrg.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub asignacionCamposEstructuraOrg()
        empleado.datosEstructuraOrganica.organizacionID = lueInstitucion.EditValue
        empleado.datosEstructuraOrganica.direccionID = lueDireccion.EditValue
        empleado.datosEstructuraOrganica.deptoID = lueDepartamento.EditValue
        empleado.datosEstructuraOrganica.periodoID = parametroMensual.ID
        empleado.datosEstructuraOrganica.evaluadorDesempenoID = lueEvaluadorDesempeno.EditValue
        empleado.datosEstructuraOrganica.autorizadorHorasExtrasID = lueAutorizadorHorasExtras.EditValue
        empleado.datosEstructuraOrganica.subDeptoId = lueSubDepto.EditValue
    End Sub

    Private Sub asignacionCamposEstructuraContable()
        empleado.datosEstructuraContable.centroCostoContab = lueCentroCostoContable.EditValue
        empleado.datosEstructuraContable.centroCostoPresup = lueCentroCostoPresupuesto.EditValue
        empleado.datosEstructuraContable.procentajeDistribucion = txtPorcentajeDistribucion.Text
        empleado.datosEstructuraContable.periodoID = parametroMensual.ID
        empleado.datosEstructuraContable.organizacionID = Comun.ArgoConfiguracion.OrganizacionID
    End Sub

    Private Sub btnGuardarEstructuraContable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarEstructuraContable.Click
        If lueCentroCostoContable.EditValue > 0 And lueCentroCostoPresupuesto.EditValue > 0 And CType(txtPorcentajeDistribucion.Text, Integer) > 0 Then
            If empleado.datosEstructuraContable.estructuraContableId = 0 Then
                asignacionCamposEstructuraContable()
                empleado.datosEstructuraContable.empleadoID = empleado.ID
                If EsFichaHistorica Then
                    empleado.datosEstructuraContable.estadoRegistro = Comun.TiposDeDatos.EstadoRegistro.HISTORICO
                Else
                    empleado.datosEstructuraContable.estadoRegistro = Comun.TiposDeDatos.EstadoRegistro.ACTIVO
                End If
                empleado.datosEstructuraContable.estructuraContableId = empleado.CrearEmpleadoEstructuraContable()
                gdcEstructuraContable.DataSource = empleado.dvEstructuraContableEmpleado
                btnEliminarEstructuraContable.Enabled = True
                MsgBox("Los datos han sido actualizados correctamente", MsgBoxStyle.Information)
            Else
                If lueCentroCostoContable.EditValue <> empleado.datosEstructuraContable.centroCostoContab Or lueCentroCostoPresupuesto.EditValue <> empleado.datosEstructuraContable.centroCostoPresup Or CType(txtPorcentajeDistribucion.Text, Integer) <> empleado.datosEstructuraContable.procentajeDistribucion Then
                    asignacionCamposEstructuraContable()
                    empleado.actualizarDatosEstructuraContable(empleado.datosEstructuraContable)
                    gdcEstructuraContable.DataSource = empleado.dvEstructuraContableEmpleado
                    btnEliminarEstructuraContable.Enabled = True
                    MsgBox("Los datos han sido actualizados correctamente", MsgBoxStyle.Information)
                End If
            End If
        Else
            If lueCentroCostoContable.EditValue <= 0 Then
                lueCentroCostoContable.ErrorText = "Falta ingresar centro de costo contable"
            End If
            If lueCentroCostoPresupuesto.EditValue <= 0 Then
                lueCentroCostoPresupuesto.ErrorText = "Falta ingresar centro de costo presupuestario"
            End If
        End If
    End Sub

    Private Sub btnEliminarEstructuraContable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarEstructuraContable.Click
        If lueCentroCostoContable.EditValue > 0 And lueCentroCostoPresupuesto.EditValue > 0 And CType(txtPorcentajeDistribucion.Text, Integer) > 0 Then
            If MsgBox("¿Está usted seguro(a) que desea eliminar este registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                empleado.EliminarEmpleadoEstructuraContable(empleado.datosEstructuraContable.estructuraContableId)
                lueCentroCostoContable.EditValue = CType(-1, Integer)
                lueCentroCostoPresupuesto.EditValue = CType(-1, Integer)
                empleado.datosEstructuraContable.estructuraContableId = 0
                gdcEstructuraContable.DataSource = empleado.dvEstructuraContableEmpleado
                btnEliminarEstructuraContable.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnCancelarEstrucOrg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarEstrucOrg.Click
        If empleado.ID > 0 Then
            lueInstitucion.EditValue = CType(Comun.ArgoConfiguracion.OrganizacionID, Short)
            lueDireccion.EditValue = CType(-1, Integer)
            lueDepartamento.EditValue = CType(-1, Integer)
            lueAutorizadorHorasExtras.EditValue = CType(-1, Integer)
            lueEvaluadorDesempeno.EditValue = CType(-1, Integer)
        End If
    End Sub

    Private Sub btnCancelarEstructuraContable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarEstructuraContable.Click
        If empleado.ID > 0 Then
            lueCentroCostoContable.EditValue = CType(-1, Integer)
            lueCentroCostoPresupuesto.EditValue = CType(-1, Integer)
            'txtPorcentajeDistribucion.Text = ""
        End If
    End Sub
    Private Sub refrescarMaestroEmpleado()
        repositorio.RefreshDatos("Empleado")
        dvEmpleados = repositorio.dvEmpleadoFichaHistorica    'repositorio.dvEmpleadoVista
        leRut.Properties.DataSource = dvEmpleados
        lueEmpleado.Properties.DataSource = repositorio.dvEmpleadoFichaHistorica   'empleado.recuperarEmpleadoLiquidacion
    End Sub

    Private Sub leRut_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles leRut.EditValueChanged
        Cursor.Current = Cursors.WaitCursor
        If IsNumeric(leRut.EditValue) Then
            Try
                If Not EsFichaHistorica Then
                    empleado = New Empleado(CType(leRut.EditValue, Long))
                Else
                    empleado = New Empleado(CType(leRut.EditValue, Long), CType(luePeriodo.EditValue, Integer))
                End If

                If empleado.ID > 0 Then
                    activaTabsAntecedentesAdicionales()
                    btnGuardaryConservar.Enabled = True
                    btnGuardarRegistroActual.Enabled = True
                    btnNuevo.Enabled = True
                    btnGuardar.Enabled = True
                    btnEliminar.Enabled = True
                    btnCancelar.Enabled = False
                    edicion = True
                    btnGuardarAPV.Enabled = False
                    controlesClaveDatosLaborales()
                    lueEmpleado.EditValue = empleado.ID
                    'Esta función debe mejorarse y ser incorporada dentro del empleado.
                    If Not fotografiaEmpleado(empleado.ID) Is Nothing Then
                        picEmpleado.Image = fotografiaEmpleado(empleado.ID)
                    End If
                Else
                    lueAfp.Text = ""
                    lueIsapre.Text = ""
                    lueAfp.EditValue = 1
                    btnGuardaryConservar.Enabled = False
                    desactivaTabsAntecedentesAdicionales()
                End If
                refrescarControles()
                estableceControlesSegunPermisos()
            Catch exp As Exception
                MessageBox.Show(exp.Message, "Ficha Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                estableceControlesSinDatosDeEmpleado()
            Finally

            End Try
        End If
        Cursor.Current = Cursors.Default

    End Sub
    Private Sub estableceControlesSinDatosDeEmpleado()
        empleado = New Empleado
        ResetControls(Me)
        inicializarControles()
        txtDV.Enabled = True
        leRut.Visible = True
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        edicion = True
        txtRut.Focus()
        desactivaTabsAntecedentesAdicionales()
        valoresPorDefaultRemun()
        valoresPorDefaultLaboral()
        empleado.estadoEmpleadoID = Comun.TiposDeDatos.TipoEstado.POR_ACTIVAR
        cbbEstadoEmpleado.Text = DescripcionEstado(Comun.TiposDeDatos.TipoEstado.POR_ACTIVAR)
    End Sub


    Private Sub picEmpleadoCargarFotografia_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles picEmpleadoCargarFotografia.ItemClick
        Try
            With OpenFileDialog1
                .Title = "Selección archivo de Fotografía"
                .DefaultExt = ".jpg"
                .Filter = "Archivo de imágen|*.jpg"
                .FilterIndex = 0
                .ShowDialog()
                If .FileName <> "" Then
                    picEmpleado.Image = picEmpleado.Image.FromFile(.FileName)
                End If
            End With
        Catch exp As Exception
            MsgBox(exp.Message)
        End Try
    End Sub


    Private Sub picEmpleadoExportarFotografia_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles picEmpleadoExportarFotografia.ItemClick
        Try
            With SaveFileDialog1
                .Title = "Guardar archivo de Fotografía"
                .DefaultExt = ".jpg"
                .Filter = "Archivo de imágen|*.jpg"
                .FilterIndex = 0
                .AddExtension = True
                .ShowDialog()
                If .FileName <> "" Then
                    picEmpleado.Image.Save(.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                End If
            End With
        Catch exp As Exception
            MsgBox(exp.Message)
        End Try
    End Sub

    Private Sub picEmpleadoEliminarFotografia_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles picEmpleadoEliminarFotografia.ItemClick
        inicializaFotografia()
    End Sub

    Private Sub controlesClaveDatosLaborales()
        If empleado.datosLaborales.antecedenteLaboralID = 0 Or empleado.estado = TiposDeDatos.TipoEstado.POR_ACTIVAR Then
            lueCalJur.Enabled = True
            cbbClasificacionEmpleado.Enabled = True
            cbbGrado.Enabled = True
        Else
            lueCalJur.Enabled = False
            cbbClasificacionEmpleado.Enabled = False
            cbbGrado.Enabled = False
        End If
    End Sub

    Private Sub rdgFormaPago_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdgFormaPago.EditValueChanged
        If rdgFormaPago.EditValue <> Not Nothing Then
            If rdgFormaPago.EditValue = 0 Or rdgFormaPago.EditValue = 1 Then
                'lueBanco.EditValue = CType(0, Integer)
                'lueTipoCuentaBanco.EditValue = CType(0, Integer)
                'txtNumeroCuentaBanco.Text = ""
            End If
        End If
    End Sub

    Private Sub txtPorcentajeLey19863_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPorcentajeLey19863.Validating
        If txtPorcentajeLey19863.EditValue < 0 Then
            txtPorcentajeLey19863.ErrorText = "Porcentaje no pueder menor de cero"
            e.Cancel = True
        Else
            If txtPorcentajeLey19863.EditValue > 200 Then
                txtPorcentajeLey19863.ErrorText = "Porcentaje no pueder mayor al 200%"
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        txtRut.Visible = False
        leRut.Visible = True
        lueEmpleado.Enabled = True
        btnNuevo.Enabled = True
        btnGuardar.Enabled = True
        empleado = New Empleado
    End Sub

    Private Sub xtcFichaEmpleado_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtcFichaEmpleado.SelectedPageChanged
        If e.Page.Name = "xtpDatosRemuneracion" Then
            If Me.lueCalJur.EditValue = Comun.TiposDeDatos.TipoCalidadJuridica.HONORARIOS Then
                Me.btnDetallePresupuestoAnualHonorario.Visible = True
                Me.chkEntregoBoletaHonorario.Visible = True
                Me.speNumeroBienios.Enabled = False
                Me.dteFechaCumplioBienio.Enabled = False
            Else
                Me.btnDetallePresupuestoAnualHonorario.Visible = False
                Me.chkEntregoBoletaHonorario.Visible = False
                Me.speNumeroBienios.Enabled = True
                Me.dteFechaCumplioBienio.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnDetallePresupuestoAnualHonorario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetallePresupuestoAnualHonorario.Click
        Try
            If empleado.datosRemuneracion.antecedenteRemunID <= 0 Then
                MsgBox("No puede visualizar presupuesto anual honorarios mientras no exista registro de remuneración." + Chr(13) + "Presione el botón guardar y luego botón detalle presupuesto anual.", MsgBoxStyle.Information, "SIGA")
                Exit Sub
            End If
            frmDatosAnualHonorarios.DefInstance.empleado = empleado
            frmDatosAnualHonorarios.DefInstance.Owner = Me
            If frmDatosAnualHonorarios.DefInstance.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            End If

            If CType(txtMontoRentaBase.Text, Integer) <> empleado.datosPresupuestoHonorario.montoVigente Then
                txtMontoRentaBase.Text = empleado.datosPresupuestoHonorario.montoVigente.ToString
                empleado.datosRemuneracion.rentaBase = CType(txtMontoRentaBase.Text, Integer)
                Dim origen As Integer = Comun.TiposDeDatos.TipoOrigenItem.FICHA_EMPLEADO
                Dim tipoProceso As String = Comun.TipoProceso.NORNAL_PLANTA_CONTRATA
                Try
                    empleado.CrearItemEmpleado(empleado, parametroMensual, origen, tipoProceso)
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al intentar crear el items para el empleado " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
                empleado.actualizarDatosRemun(empleado.datosRemuneracion)
            End If

        Catch ex As Exception
            MsgBox("Ha ocurrido al intentar cargae el formulario presupuesto anual honorarios" & " " & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            'If frmDatosAnualHonorarios.DefInstance.retorno Then
            'gdcLicenciasMedicas.DataSource = empleado.dvDatosLicenciaMedica(empleado.ID)
            'limpiarControles()
            'End If
        End Try
    End Sub

    Private Sub chkEntregoBoletaHonorario_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkEntregoBoletaHonorario.CheckedChanged
        Dim idLiquidacion As Integer = 0
        If Me.chkEntregoBoletaHonorario.Checked = False Then
            idLiquidacion = empleado.recuperaValorNumerico("SELECT ID_LIQUIDACION_ENC FROM RH_REM_LIQUIDACION_ENC WHERE EMPLEADO_ID = " & empleado.ID & " AND PERIODO_ID = " & Me.parametroMensual.ID & " AND TIPO_CALCULO = 'H'")
        End If
        If idLiquidacion > 0 Then
            If MsgBox("El empleado " + RTrim(empleado.apellidoPaterno) + " " + RTrim(empleado.apellidoMaterno) + " " + RTrim(empleado.nombres) + " tiene una liquidación procesada para el periodo " + Me.parametroMensual.nombrePeriodo + "¿Desea eliminar la liquidación?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Remuneracion.eliminaProcesoEmpleado(empleado.ID, Me.parametroMensual.ID, "H")
            End If
        End If
    End Sub



    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If lueEmpleado.EditValue = Nothing Or lueEmpleado.EditValue <= 0 Then
            Exit Sub
        End If
        leRut.EditValue = lueEmpleado.EditValue
    End Sub

    Private Sub lueEmpleado_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles lueEmpleado.EditValueChanged
        If lueEmpleado.EditValue = Nothing Or lueEmpleado.EditValue <= 0 Then
            Exit Sub
        End If
        leRut.EditValue = lueEmpleado.EditValue
    End Sub

    Private Sub luePeriodo_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles luePeriodo.EditValueChanged
        If luePeriodo.EditValue = Nothing Or luePeriodo.EditValue <= 0 Then
            Exit Sub
        End If
        initCampoRut()
        LlenarEmpleados()
        If EsFichaHistorica Then
            lblMensajeContacto.Visible = True
            lblMensajeGeneral.Visible = True
            lblMensajeLaboral.Visible = True
            lblMensajeEstruOrgannica.Visible = True
            lblMensajeEstruOrgannica.Visible = True
            lblMensajeAPV.Visible = True
            lblMensajePrevisional.Visible = True
            lblMensajeRemuneracion.Visible = True
            lblMensajeContacto.Text = "Registro empleado histórico a " & luePeriodo.Text
            lblMensajeGeneral.Text = "Registro empleado histórico a " & luePeriodo.Text
            lblMensajeLaboral.Text = "Registro empleado histórico a " & luePeriodo.Text
            lblMensajeEstruOrgannica.Text = "Registro empleado histórico a " & luePeriodo.Text
            lblMensajeEstruOrgannica.Text = "Registro empleado histórico a " & luePeriodo.Text
            lblMensajeAPV.Text = "Registro empleado histórico a " & luePeriodo.Text
            lblMensajePrevisional.Text = "Registro empleado histórico a " & luePeriodo.Text
            lblMensajeRemuneracion.Text = "Registro empleado histórico a " & luePeriodo.Text
        End If

    End Sub

    Private Sub lueZona_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles lueZona.EditValueChanged
        If lueZona.EditValue = Nothing Then
            Exit Sub
        End If
        generaMontoAsignacionZona()
    End Sub

    Private Sub chkAsignaLey18675Art11_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAsignaLey18675Art11.CheckedChanged
        CambiaMontoLey18675Art11(empleado.datosRemuneracion.valorAsignacionLey18675Art11)
    End Sub

    Private Sub CambiaMontoLey18675Art11(ByVal monto As Integer)
        If Not chkAsignaLey18675Art11.Checked Then
            txtLey18675Art11.EditValue = 0
        Else
            txtLey18675Art11.EditValue = monto
        End If
    End Sub


End Class