Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmItemes
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
    Friend WithEvents txtItemAlias As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCodigoHaberDescuento As System.Windows.Forms.Label
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblDescripcionLarga As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionCorta As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionLarga As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcionCorta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSecuenciaImpresión As System.Windows.Forms.Label
    Friend WithEvents txtSecuenciaImpresion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpcCentralizacionContable As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gdcItem As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvItemes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dvItem As System.Data.DataView
    Friend WithEvents dvLibroAuditoria As System.Data.DataView
    Friend WithEvents dvLibroOficial As System.Data.DataView
    Friend WithEvents ITEM_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TIPO_ITEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ITEM_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION_LARGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION_CORTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ES_IMPONIBLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ES_TRIBUTABLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ES_CALCULABLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ES_COSTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SECUENCIA_IMPRESION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ITEM_ASOCIADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COLUMNA_LIBRO_AUDITORIA_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COLUMNA_LIBRO_AUDITORIA_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COLUMNA_LIBRO_OFICIAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gpcDefinicionItem As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblTipoItem As System.Windows.Forms.Label
    Friend WithEvents rdgTipoItem As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents ES_PERMANENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ES_IMPRIMIBLE_EN_LIQUIDACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkEstadoRegistro As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ES_ITEM_BIENESTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ESTADO_REGISTRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lycDefinicionItem As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents chkEsCosto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEsCalculable As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEsTributable As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEsPermanente As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEsImprimible As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEsImponible As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lcgDefinicionItem As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents tcgItem As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents lcgAcercaItem As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciEsImponible As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciEsImprimible As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciEsPermanente As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciEsTributable As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciEsCalculable As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciEsCosto As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lygBonoModernidad As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciEsProporcinarDiasTrabajados As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkCorrespondeaBonoModernizacion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEsImponibleMesHistorico As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lciEsImponibleMesHistorico As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciCorrespondeaBonoModernizacion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkEsTributableMesHistorico As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lciEsTributableMesHistorico As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkTraspasaDiferenciaMovtoMensual As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lciTraspasaDiferenciaMovtoMensual As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcgImportacion As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtProcedencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciProcedencia As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCodigoItemExterno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciCodigoItemExterno As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCodigoAplicacionExterna As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciCodigoAplicacionExterna As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkProporcinalDiasTrabajados As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lcgCalculoExcel As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtNombreCeldaExcel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciCalculoExcel As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ES_PROPORCIONAL_DIAS_TRABAJADOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CELDA_CALCULO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CODIGO_EXTERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APLICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CODIGO_APLICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ES_RELIQUIDACION_BONO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ES_IMPONIBLE_MES_HISTORICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ES_TRIBUTABLE_MES_HISTORICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TRASPASA_DIFERENCIA_MOVTO_MENSUAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gdcCentralizacion As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalleCentralizacion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CENTRALIZACION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ITEM_ID_CENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PERIODO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CALIDAD_JURIDICA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CUENTA_CONTABLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CUENTA_PRESUPUESTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvCalidadJuridica As System.Data.DataView
    Friend WithEvents lueImputacion As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents dvImputacion As System.Data.DataView
    Friend WithEvents lueCalidadJuridica As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GLOSA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ESTADO_REGISTRO_CENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IMPUTACION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkEsItemBienestar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEsAfectoAtrasoInsistencia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ES_ATRASO_INASISTENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvTipoItem As System.Data.DataView
    Friend WithEvents gleTipoItem As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chkEsCostoPresupuesto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lciEsItemBienestar As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciEsAfectoAtrasoInsistencia As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciEsCostoPresupuesto As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkEsAplicadoAHonorario As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lciEsAplicadoAHonorario As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ES_APLICABLE_HONORARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkPermiteGeneracionMasiva As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lciGeneracionMasiva As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PERMITE_GENERACION_MASIVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ES_COSTO_PRESUP As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtItemAlias = New DevExpress.XtraEditors.TextEdit()
        Me.lblCodigoHaberDescuento = New System.Windows.Forms.Label()
        Me.gdcItem = New DevExpress.XtraGrid.GridControl()
        Me.gdvItemes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ITEM_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TIPO_ITEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleTipoItem = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ITEM_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION_LARGA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION_CORTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ES_IMPONIBLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ES_TRIBUTABLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ES_CALCULABLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ES_COSTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SECUENCIA_IMPRESION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ITEM_ASOCIADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COLUMNA_LIBRO_AUDITORIA_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COLUMNA_LIBRO_AUDITORIA_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COLUMNA_LIBRO_OFICIAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ES_PERMANENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ES_IMPRIMIBLE_EN_LIQUIDACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ES_ITEM_BIENESTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ESTADO_REGISTRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ES_PROPORCIONAL_DIAS_TRABAJADOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CELDA_CALCULO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CODIGO_EXTERNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.APLICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CODIGO_APLICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ES_RELIQUIDACION_BONO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ES_IMPONIBLE_MES_HISTORICO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ES_TRIBUTABLE_MES_HISTORICO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TRASPASA_DIFERENCIA_MOVTO_MENSUAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ES_ATRASO_INASISTENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ES_APLICABLE_HONORARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ES_COSTO_PRESUP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gpcDefinicionItem = New DevExpress.XtraEditors.GroupControl()
        Me.chkEstadoRegistro = New DevExpress.XtraEditors.CheckEdit()
        Me.rdgTipoItem = New DevExpress.XtraEditors.RadioGroup()
        Me.lblTipoItem = New System.Windows.Forms.Label()
        Me.txtSecuenciaImpresion = New DevExpress.XtraEditors.TextEdit()
        Me.lblSecuenciaImpresión = New System.Windows.Forms.Label()
        Me.txtDescripcionCorta = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescripcionLarga = New DevExpress.XtraEditors.TextEdit()
        Me.lblDescripcionCorta = New System.Windows.Forms.Label()
        Me.lblDescripcionLarga = New System.Windows.Forms.Label()
        Me.gpcCentralizacionContable = New DevExpress.XtraEditors.GroupControl()
        Me.gdcCentralizacion = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleCentralizacion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CENTRALIZACION_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ITEM_ID_CENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PERIODO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CALIDAD_JURIDICA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lueCalidadJuridica = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.IMPUTACION_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lueImputacion = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.CUENTA_CONTABLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CUENTA_PRESUPUESTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GLOSA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ESTADO_REGISTRO_CENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.dvItem = New System.Data.DataView()
        Me.dvLibroAuditoria = New System.Data.DataView()
        Me.dvLibroOficial = New System.Data.DataView()
        Me.dvCalidadJuridica = New System.Data.DataView()
        Me.lycDefinicionItem = New DevExpress.XtraLayout.LayoutControl()
        Me.chkEsAplicadoAHonorario = New DevExpress.XtraEditors.CheckEdit()
        Me.chkEsCostoPresupuesto = New DevExpress.XtraEditors.CheckEdit()
        Me.chkEsAfectoAtrasoInsistencia = New DevExpress.XtraEditors.CheckEdit()
        Me.chkEsItemBienestar = New DevExpress.XtraEditors.CheckEdit()
        Me.chkEsImprimible = New DevExpress.XtraEditors.CheckEdit()
        Me.chkEsPermanente = New DevExpress.XtraEditors.CheckEdit()
        Me.chkEsTributable = New DevExpress.XtraEditors.CheckEdit()
        Me.chkEsCalculable = New DevExpress.XtraEditors.CheckEdit()
        Me.chkEsCosto = New DevExpress.XtraEditors.CheckEdit()
        Me.chkProporcinalDiasTrabajados = New DevExpress.XtraEditors.CheckEdit()
        Me.chkEsImponibleMesHistorico = New DevExpress.XtraEditors.CheckEdit()
        Me.chkCorrespondeaBonoModernizacion = New DevExpress.XtraEditors.CheckEdit()
        Me.chkEsTributableMesHistorico = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTraspasaDiferenciaMovtoMensual = New DevExpress.XtraEditors.CheckEdit()
        Me.txtProcedencia = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoItemExterno = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoAplicacionExterna = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreCeldaExcel = New DevExpress.XtraEditors.TextEdit()
        Me.chkEsImponible = New DevExpress.XtraEditors.CheckEdit()
        Me.lcgDefinicionItem = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.tcgItem = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.lcgAcercaItem = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciEsImponible = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciEsImprimible = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciEsPermanente = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciEsTributable = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciEsCalculable = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciEsCosto = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciEsProporcinarDiasTrabajados = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciEsItemBienestar = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciEsAfectoAtrasoInsistencia = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciEsCostoPresupuesto = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciEsAplicadoAHonorario = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lygBonoModernidad = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciEsImponibleMesHistorico = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciCorrespondeaBonoModernizacion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciEsTributableMesHistorico = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciTraspasaDiferenciaMovtoMensual = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcgImportacion = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciProcedencia = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciCodigoItemExterno = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciCodigoAplicacionExterna = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcgCalculoExcel = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciCalculoExcel = New DevExpress.XtraLayout.LayoutControlItem()
        Me.dvImputacion = New System.Data.DataView()
        Me.dvTipoItem = New System.Data.DataView()
        Me.chkPermiteGeneracionMasiva = New DevExpress.XtraEditors.CheckEdit()
        Me.lciGeneracionMasiva = New DevExpress.XtraLayout.LayoutControlItem()
        Me.PERMITE_GENERACION_MASIVA = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.txtItemAlias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvItemes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleTipoItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDefinicionItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDefinicionItem.SuspendLayout()
        CType(Me.chkEstadoRegistro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgTipoItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSecuenciaImpresion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionCorta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionLarga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcCentralizacionContable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcCentralizacionContable.SuspendLayout()
        CType(Me.gdcCentralizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleCentralizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCalidadJuridica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueImputacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvLibroAuditoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvLibroOficial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvCalidadJuridica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycDefinicionItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycDefinicionItem.SuspendLayout()
        CType(Me.chkEsAplicadoAHonorario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEsCostoPresupuesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEsAfectoAtrasoInsistencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEsItemBienestar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEsImprimible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEsPermanente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEsTributable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEsCalculable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEsCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkProporcinalDiasTrabajados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEsImponibleMesHistorico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCorrespondeaBonoModernizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEsTributableMesHistorico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTraspasaDiferenciaMovtoMensual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcedencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoItemExterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoAplicacionExterna.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreCeldaExcel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEsImponible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgDefinicionItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcgItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgAcercaItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEsImponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEsImprimible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEsPermanente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEsTributable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEsCalculable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEsCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEsProporcinarDiasTrabajados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEsItemBienestar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEsAfectoAtrasoInsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEsCostoPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEsAplicadoAHonorario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lygBonoModernidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEsImponibleMesHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciCorrespondeaBonoModernizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEsTributableMesHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciTraspasaDiferenciaMovtoMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgImportacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciProcedencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciCodigoItemExterno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciCodigoAplicacionExterna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgCalculoExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciCalculoExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvImputacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvTipoItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPermiteGeneracionMasiva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciGeneracionMasiva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtItemAlias
        '
        Me.txtItemAlias.Location = New System.Drawing.Point(168, 72)
        Me.txtItemAlias.Name = "txtItemAlias"
        Me.txtItemAlias.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemAlias.Properties.Mask.IgnoreMaskBlank = False
        Me.txtItemAlias.Properties.MaxLength = 10
        Me.txtItemAlias.Size = New System.Drawing.Size(64, 20)
        Me.txtItemAlias.TabIndex = 0
        '
        'lblCodigoHaberDescuento
        '
        Me.lblCodigoHaberDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoHaberDescuento.Location = New System.Drawing.Point(16, 76)
        Me.lblCodigoHaberDescuento.Name = "lblCodigoHaberDescuento"
        Me.lblCodigoHaberDescuento.Size = New System.Drawing.Size(144, 16)
        Me.lblCodigoHaberDescuento.TabIndex = 28
        Me.lblCodigoHaberDescuento.Text = "Código Haber/Descuento"
        Me.lblCodigoHaberDescuento.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gdcItem
        '
        Me.gdcItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gdcItem.Location = New System.Drawing.Point(8, 16)
        Me.gdcItem.MainView = Me.gdvItemes
        Me.gdcItem.Name = "gdcItem"
        Me.gdcItem.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.gleTipoItem})
        Me.gdcItem.Size = New System.Drawing.Size(384, 576)
        Me.gdcItem.TabIndex = 31
        Me.gdcItem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvItemes, Me.GridView1})
        '
        'gdvItemes
        '
        Me.gdvItemes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ITEM_ID, Me.TIPO_ITEM, Me.ITEM_ALIAS, Me.DESCRIPCION_LARGA, Me.DESCRIPCION_CORTA, Me.ES_IMPONIBLE, Me.ES_TRIBUTABLE, Me.ES_CALCULABLE, Me.ES_COSTO, Me.SECUENCIA_IMPRESION, Me.ITEM_ASOCIADO, Me.COLUMNA_LIBRO_AUDITORIA_1, Me.COLUMNA_LIBRO_AUDITORIA_2, Me.COLUMNA_LIBRO_OFICIAL, Me.ES_PERMANENTE, Me.ES_IMPRIMIBLE_EN_LIQUIDACION, Me.ES_ITEM_BIENESTAR, Me.ESTADO_REGISTRO, Me.ES_PROPORCIONAL_DIAS_TRABAJADOS, Me.CELDA_CALCULO, Me.CODIGO_EXTERNO, Me.APLICACION, Me.CODIGO_APLICACION, Me.ES_RELIQUIDACION_BONO, Me.ES_IMPONIBLE_MES_HISTORICO, Me.ES_TRIBUTABLE_MES_HISTORICO, Me.TRASPASA_DIFERENCIA_MOVTO_MENSUAL, Me.ES_ATRASO_INASISTENCIA, Me.ES_APLICABLE_HONORARIO, Me.ES_COSTO_PRESUP, Me.PERMITE_GENERACION_MASIVA})
        Me.gdvItemes.GridControl = Me.gdcItem
        Me.gdvItemes.GroupCount = 1
        Me.gdvItemes.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvItemes.Name = "gdvItemes"
        Me.gdvItemes.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.TIPO_ITEM, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'ITEM_ID
        '
        Me.ITEM_ID.Caption = "ID Item"
        Me.ITEM_ID.FieldName = "ITEM_ID"
        Me.ITEM_ID.Name = "ITEM_ID"
        Me.ITEM_ID.OptionsColumn.ReadOnly = True
        Me.ITEM_ID.Visible = True
        Me.ITEM_ID.VisibleIndex = 2
        '
        'TIPO_ITEM
        '
        Me.TIPO_ITEM.Caption = "Tipo Item"
        Me.TIPO_ITEM.ColumnEdit = Me.gleTipoItem
        Me.TIPO_ITEM.FieldName = "TIPO_ITEM"
        Me.TIPO_ITEM.Name = "TIPO_ITEM"
        Me.TIPO_ITEM.OptionsColumn.ReadOnly = True
        '
        'gleTipoItem
        '
        Me.gleTipoItem.AutoHeight = False
        Me.gleTipoItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleTipoItem.Name = "gleTipoItem"
        Me.gleTipoItem.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'ITEM_ALIAS
        '
        Me.ITEM_ALIAS.Caption = "Código"
        Me.ITEM_ALIAS.FieldName = "ITEM_ALIAS"
        Me.ITEM_ALIAS.Name = "ITEM_ALIAS"
        Me.ITEM_ALIAS.OptionsColumn.AllowEdit = False
        Me.ITEM_ALIAS.OptionsColumn.ReadOnly = True
        Me.ITEM_ALIAS.Visible = True
        Me.ITEM_ALIAS.VisibleIndex = 0
        Me.ITEM_ALIAS.Width = 70
        '
        'DESCRIPCION_LARGA
        '
        Me.DESCRIPCION_LARGA.Caption = "Descripción"
        Me.DESCRIPCION_LARGA.FieldName = "DESCRIPCION_LARGA"
        Me.DESCRIPCION_LARGA.Name = "DESCRIPCION_LARGA"
        Me.DESCRIPCION_LARGA.OptionsColumn.AllowEdit = False
        Me.DESCRIPCION_LARGA.OptionsColumn.ReadOnly = True
        Me.DESCRIPCION_LARGA.Visible = True
        Me.DESCRIPCION_LARGA.VisibleIndex = 1
        Me.DESCRIPCION_LARGA.Width = 280
        '
        'DESCRIPCION_CORTA
        '
        Me.DESCRIPCION_CORTA.Caption = "Descripción Corta"
        Me.DESCRIPCION_CORTA.FieldName = "DESCRIPCION_CORTA"
        Me.DESCRIPCION_CORTA.Name = "DESCRIPCION_CORTA"
        Me.DESCRIPCION_CORTA.OptionsColumn.ReadOnly = True
        '
        'ES_IMPONIBLE
        '
        Me.ES_IMPONIBLE.Caption = "Es Imponible"
        Me.ES_IMPONIBLE.FieldName = "ES_IMPONIBLE"
        Me.ES_IMPONIBLE.Name = "ES_IMPONIBLE"
        Me.ES_IMPONIBLE.OptionsColumn.ReadOnly = True
        '
        'ES_TRIBUTABLE
        '
        Me.ES_TRIBUTABLE.Caption = "Es Tributable"
        Me.ES_TRIBUTABLE.FieldName = "ES_TRIBUTABLE"
        Me.ES_TRIBUTABLE.Name = "ES_TRIBUTABLE"
        Me.ES_TRIBUTABLE.OptionsColumn.ReadOnly = True
        '
        'ES_CALCULABLE
        '
        Me.ES_CALCULABLE.Caption = "Es Calculable"
        Me.ES_CALCULABLE.FieldName = "ES_CALCULABLE"
        Me.ES_CALCULABLE.Name = "ES_CALCULABLE"
        Me.ES_CALCULABLE.OptionsColumn.ReadOnly = True
        '
        'ES_COSTO
        '
        Me.ES_COSTO.Caption = "Es Costo"
        Me.ES_COSTO.FieldName = "ES_COSTO"
        Me.ES_COSTO.Name = "ES_COSTO"
        Me.ES_COSTO.OptionsColumn.ReadOnly = True
        '
        'SECUENCIA_IMPRESION
        '
        Me.SECUENCIA_IMPRESION.Caption = "Secuencia Impresión"
        Me.SECUENCIA_IMPRESION.FieldName = "SECUENCIA_IMPRESION"
        Me.SECUENCIA_IMPRESION.Name = "SECUENCIA_IMPRESION"
        Me.SECUENCIA_IMPRESION.OptionsColumn.ReadOnly = True
        '
        'ITEM_ASOCIADO
        '
        Me.ITEM_ASOCIADO.Caption = "Item Asociado"
        Me.ITEM_ASOCIADO.FieldName = "ITEM_ASOCIADO"
        Me.ITEM_ASOCIADO.Name = "ITEM_ASOCIADO"
        Me.ITEM_ASOCIADO.OptionsColumn.ReadOnly = True
        '
        'COLUMNA_LIBRO_AUDITORIA_1
        '
        Me.COLUMNA_LIBRO_AUDITORIA_1.Caption = "Columna Libro Audit.1"
        Me.COLUMNA_LIBRO_AUDITORIA_1.FieldName = "COLUMNA_LIBRO_AUDITORIA_1"
        Me.COLUMNA_LIBRO_AUDITORIA_1.Name = "COLUMNA_LIBRO_AUDITORIA_1"
        Me.COLUMNA_LIBRO_AUDITORIA_1.OptionsColumn.ReadOnly = True
        '
        'COLUMNA_LIBRO_AUDITORIA_2
        '
        Me.COLUMNA_LIBRO_AUDITORIA_2.Caption = "Columna Libro Audit.2"
        Me.COLUMNA_LIBRO_AUDITORIA_2.FieldName = "COLUMNA_LIBRO_AUDITORIA_2"
        Me.COLUMNA_LIBRO_AUDITORIA_2.Name = "COLUMNA_LIBRO_AUDITORIA_2"
        Me.COLUMNA_LIBRO_AUDITORIA_2.OptionsColumn.ReadOnly = True
        '
        'COLUMNA_LIBRO_OFICIAL
        '
        Me.COLUMNA_LIBRO_OFICIAL.Caption = "Columna Libro Oficial"
        Me.COLUMNA_LIBRO_OFICIAL.FieldName = "COLUMNA_LIBRO_OFICIAL"
        Me.COLUMNA_LIBRO_OFICIAL.Name = "COLUMNA_LIBRO_OFICIAL"
        Me.COLUMNA_LIBRO_OFICIAL.OptionsColumn.ReadOnly = True
        '
        'ES_PERMANENTE
        '
        Me.ES_PERMANENTE.Caption = "Es Permanente"
        Me.ES_PERMANENTE.FieldName = "ES_PERMANENTE"
        Me.ES_PERMANENTE.Name = "ES_PERMANENTE"
        Me.ES_PERMANENTE.OptionsColumn.ReadOnly = True
        '
        'ES_IMPRIMIBLE_EN_LIQUIDACION
        '
        Me.ES_IMPRIMIBLE_EN_LIQUIDACION.Caption = "Es Imprimible"
        Me.ES_IMPRIMIBLE_EN_LIQUIDACION.FieldName = "ES_IMPRIMIBLE_EN_LIQUIDACION"
        Me.ES_IMPRIMIBLE_EN_LIQUIDACION.Name = "ES_IMPRIMIBLE_EN_LIQUIDACION"
        Me.ES_IMPRIMIBLE_EN_LIQUIDACION.OptionsColumn.ReadOnly = True
        '
        'ES_ITEM_BIENESTAR
        '
        Me.ES_ITEM_BIENESTAR.Caption = "Es Item Bienestar"
        Me.ES_ITEM_BIENESTAR.FieldName = "ES_ITEM_BIENESTAR"
        Me.ES_ITEM_BIENESTAR.Name = "ES_ITEM_BIENESTAR"
        Me.ES_ITEM_BIENESTAR.OptionsColumn.ReadOnly = True
        '
        'ESTADO_REGISTRO
        '
        Me.ESTADO_REGISTRO.Caption = "Estado"
        Me.ESTADO_REGISTRO.FieldName = "ESTADO_REGISTRO"
        Me.ESTADO_REGISTRO.Name = "ESTADO_REGISTRO"
        Me.ESTADO_REGISTRO.OptionsColumn.ReadOnly = True
        '
        'ES_PROPORCIONAL_DIAS_TRABAJADOS
        '
        Me.ES_PROPORCIONAL_DIAS_TRABAJADOS.Caption = "Es Prop.Días Trab."
        Me.ES_PROPORCIONAL_DIAS_TRABAJADOS.FieldName = "ES_PROPORCIONAL_DIAS_TRABAJADOS"
        Me.ES_PROPORCIONAL_DIAS_TRABAJADOS.Name = "ES_PROPORCIONAL_DIAS_TRABAJADOS"
        Me.ES_PROPORCIONAL_DIAS_TRABAJADOS.OptionsColumn.ReadOnly = True
        '
        'CELDA_CALCULO
        '
        Me.CELDA_CALCULO.Caption = "Celda Cálculo"
        Me.CELDA_CALCULO.FieldName = "CELDA_CALCULO"
        Me.CELDA_CALCULO.Name = "CELDA_CALCULO"
        Me.CELDA_CALCULO.OptionsColumn.ReadOnly = True
        '
        'CODIGO_EXTERNO
        '
        Me.CODIGO_EXTERNO.Caption = "Código Externo"
        Me.CODIGO_EXTERNO.FieldName = "CODIGO_EXTERNO"
        Me.CODIGO_EXTERNO.Name = "CODIGO_EXTERNO"
        Me.CODIGO_EXTERNO.OptionsColumn.ReadOnly = True
        '
        'APLICACION
        '
        Me.APLICACION.Caption = "Aplicación"
        Me.APLICACION.FieldName = "APLICACION"
        Me.APLICACION.Name = "APLICACION"
        Me.APLICACION.OptionsColumn.ReadOnly = True
        '
        'CODIGO_APLICACION
        '
        Me.CODIGO_APLICACION.Caption = "Código Aplicación"
        Me.CODIGO_APLICACION.FieldName = "CODIGO_APLICACION"
        Me.CODIGO_APLICACION.Name = "CODIGO_APLICACION"
        Me.CODIGO_APLICACION.OptionsColumn.ReadOnly = True
        '
        'ES_RELIQUIDACION_BONO
        '
        Me.ES_RELIQUIDACION_BONO.Caption = "Es Reliq.Bono"
        Me.ES_RELIQUIDACION_BONO.FieldName = "ES_RELIQUIDACION_BONO"
        Me.ES_RELIQUIDACION_BONO.Name = "ES_RELIQUIDACION_BONO"
        Me.ES_RELIQUIDACION_BONO.OptionsColumn.ReadOnly = True
        '
        'ES_IMPONIBLE_MES_HISTORICO
        '
        Me.ES_IMPONIBLE_MES_HISTORICO.Caption = "Es Imponib.Mes Histórico"
        Me.ES_IMPONIBLE_MES_HISTORICO.FieldName = "ES_IMPONIBLE_MES_HISTORICO"
        Me.ES_IMPONIBLE_MES_HISTORICO.Name = "ES_IMPONIBLE_MES_HISTORICO"
        Me.ES_IMPONIBLE_MES_HISTORICO.OptionsColumn.ReadOnly = True
        '
        'ES_TRIBUTABLE_MES_HISTORICO
        '
        Me.ES_TRIBUTABLE_MES_HISTORICO.Caption = "Es Tribut.Mes Histórico"
        Me.ES_TRIBUTABLE_MES_HISTORICO.FieldName = "ES_TRIBUTABLE_MES_HISTORICO"
        Me.ES_TRIBUTABLE_MES_HISTORICO.Name = "ES_TRIBUTABLE_MES_HISTORICO"
        Me.ES_TRIBUTABLE_MES_HISTORICO.OptionsColumn.ReadOnly = True
        '
        'TRASPASA_DIFERENCIA_MOVTO_MENSUAL
        '
        Me.TRASPASA_DIFERENCIA_MOVTO_MENSUAL.Caption = "Traspasa Dif.Movto.Mensual"
        Me.TRASPASA_DIFERENCIA_MOVTO_MENSUAL.FieldName = "TRASPASA_DIFERENCIA_MOVTO_MENSUAL"
        Me.TRASPASA_DIFERENCIA_MOVTO_MENSUAL.Name = "TRASPASA_DIFERENCIA_MOVTO_MENSUAL"
        Me.TRASPASA_DIFERENCIA_MOVTO_MENSUAL.OptionsColumn.ReadOnly = True
        '
        'ES_ATRASO_INASISTENCIA
        '
        Me.ES_ATRASO_INASISTENCIA.Caption = "Es Afecro Atraso Inasistencia"
        Me.ES_ATRASO_INASISTENCIA.FieldName = "ES_ATRASO_INASISTENCIA"
        Me.ES_ATRASO_INASISTENCIA.Name = "ES_ATRASO_INASISTENCIA"
        Me.ES_ATRASO_INASISTENCIA.OptionsColumn.ReadOnly = True
        '
        'ES_APLICABLE_HONORARIO
        '
        Me.ES_APLICABLE_HONORARIO.Caption = "Es Aplicable a Honorario"
        Me.ES_APLICABLE_HONORARIO.FieldName = "ES_APLICABLE_HONORARIO"
        Me.ES_APLICABLE_HONORARIO.Name = "ES_APLICABLE_HONORARIO"
        Me.ES_APLICABLE_HONORARIO.OptionsColumn.ShowInCustomizationForm = False
        '
        'ES_COSTO_PRESUP
        '
        Me.ES_COSTO_PRESUP.Caption = "Es Costo Presupuesto"
        Me.ES_COSTO_PRESUP.FieldName = "ES_COSTO_PRESUP"
        Me.ES_COSTO_PRESUP.Name = "ES_COSTO_PRESUP"
        Me.ES_COSTO_PRESUP.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcItem
        Me.GridView1.Name = "GridView1"
        '
        'gpcDefinicionItem
        '
        Me.gpcDefinicionItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcDefinicionItem.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDefinicionItem.AppearanceCaption.Options.UseFont = True
        Me.gpcDefinicionItem.Controls.Add(Me.chkEstadoRegistro)
        Me.gpcDefinicionItem.Controls.Add(Me.rdgTipoItem)
        Me.gpcDefinicionItem.Controls.Add(Me.lblTipoItem)
        Me.gpcDefinicionItem.Controls.Add(Me.txtSecuenciaImpresion)
        Me.gpcDefinicionItem.Controls.Add(Me.lblSecuenciaImpresión)
        Me.gpcDefinicionItem.Controls.Add(Me.txtDescripcionCorta)
        Me.gpcDefinicionItem.Controls.Add(Me.txtDescripcionLarga)
        Me.gpcDefinicionItem.Controls.Add(Me.lblDescripcionCorta)
        Me.gpcDefinicionItem.Controls.Add(Me.lblDescripcionLarga)
        Me.gpcDefinicionItem.Controls.Add(Me.txtItemAlias)
        Me.gpcDefinicionItem.Controls.Add(Me.lblCodigoHaberDescuento)
        Me.gpcDefinicionItem.Location = New System.Drawing.Point(400, 16)
        Me.gpcDefinicionItem.Name = "gpcDefinicionItem"
        Me.gpcDefinicionItem.Size = New System.Drawing.Size(640, 168)
        Me.gpcDefinicionItem.TabIndex = 32
        Me.gpcDefinicionItem.Text = "Definición Item"
        '
        'chkEstadoRegistro
        '
        Me.chkEstadoRegistro.Location = New System.Drawing.Point(296, 72)
        Me.chkEstadoRegistro.Name = "chkEstadoRegistro"
        Me.chkEstadoRegistro.Properties.Caption = "Ítem Activo"
        Me.chkEstadoRegistro.Size = New System.Drawing.Size(96, 19)
        Me.chkEstadoRegistro.TabIndex = 43
        '
        'rdgTipoItem
        '
        Me.rdgTipoItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdgTipoItem.Location = New System.Drawing.Point(168, 32)
        Me.rdgTipoItem.Name = "rdgTipoItem"
        Me.rdgTipoItem.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Haber"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Descuento"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Otro"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Base Cálculo")})
        Me.rdgTipoItem.Size = New System.Drawing.Size(432, 32)
        Me.rdgTipoItem.TabIndex = 42
        '
        'lblTipoItem
        '
        Me.lblTipoItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoItem.Location = New System.Drawing.Point(104, 48)
        Me.lblTipoItem.Name = "lblTipoItem"
        Me.lblTipoItem.Size = New System.Drawing.Size(56, 16)
        Me.lblTipoItem.TabIndex = 41
        Me.lblTipoItem.Text = "Tipo Ítem"
        Me.lblTipoItem.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSecuenciaImpresion
        '
        Me.txtSecuenciaImpresion.Location = New System.Drawing.Point(168, 144)
        Me.txtSecuenciaImpresion.Name = "txtSecuenciaImpresion"
        Me.txtSecuenciaImpresion.Properties.DisplayFormat.FormatString = "n0"
        Me.txtSecuenciaImpresion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSecuenciaImpresion.Properties.EditFormat.FormatString = "n0"
        Me.txtSecuenciaImpresion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSecuenciaImpresion.Properties.Mask.EditMask = "n0"
        Me.txtSecuenciaImpresion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSecuenciaImpresion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSecuenciaImpresion.Properties.MaxLength = 5
        Me.txtSecuenciaImpresion.Size = New System.Drawing.Size(64, 20)
        Me.txtSecuenciaImpresion.TabIndex = 34
        '
        'lblSecuenciaImpresión
        '
        Me.lblSecuenciaImpresión.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecuenciaImpresión.Location = New System.Drawing.Point(16, 148)
        Me.lblSecuenciaImpresión.Name = "lblSecuenciaImpresión"
        Me.lblSecuenciaImpresión.Size = New System.Drawing.Size(144, 16)
        Me.lblSecuenciaImpresión.TabIndex = 33
        Me.lblSecuenciaImpresión.Text = "Secuencia Impresión"
        Me.lblSecuenciaImpresión.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDescripcionCorta
        '
        Me.txtDescripcionCorta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionCorta.Location = New System.Drawing.Point(168, 120)
        Me.txtDescripcionCorta.Name = "txtDescripcionCorta"
        Me.txtDescripcionCorta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionCorta.Properties.MaxLength = 20
        Me.txtDescripcionCorta.Size = New System.Drawing.Size(432, 20)
        Me.txtDescripcionCorta.TabIndex = 32
        '
        'txtDescripcionLarga
        '
        Me.txtDescripcionLarga.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionLarga.Location = New System.Drawing.Point(168, 96)
        Me.txtDescripcionLarga.Name = "txtDescripcionLarga"
        Me.txtDescripcionLarga.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionLarga.Properties.MaxLength = 50
        Me.txtDescripcionLarga.Size = New System.Drawing.Size(432, 20)
        Me.txtDescripcionLarga.TabIndex = 31
        '
        'lblDescripcionCorta
        '
        Me.lblDescripcionCorta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionCorta.Location = New System.Drawing.Point(16, 124)
        Me.lblDescripcionCorta.Name = "lblDescripcionCorta"
        Me.lblDescripcionCorta.Size = New System.Drawing.Size(144, 16)
        Me.lblDescripcionCorta.TabIndex = 30
        Me.lblDescripcionCorta.Text = "Descripción Corta"
        Me.lblDescripcionCorta.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDescripcionLarga
        '
        Me.lblDescripcionLarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionLarga.Location = New System.Drawing.Point(16, 100)
        Me.lblDescripcionLarga.Name = "lblDescripcionLarga"
        Me.lblDescripcionLarga.Size = New System.Drawing.Size(144, 16)
        Me.lblDescripcionLarga.TabIndex = 29
        Me.lblDescripcionLarga.Text = "Descripción Larga"
        Me.lblDescripcionLarga.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gpcCentralizacionContable
        '
        Me.gpcCentralizacionContable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcCentralizacionContable.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcCentralizacionContable.AppearanceCaption.Options.UseFont = True
        Me.gpcCentralizacionContable.Controls.Add(Me.gdcCentralizacion)
        Me.gpcCentralizacionContable.Location = New System.Drawing.Point(400, 394)
        Me.gpcCentralizacionContable.Name = "gpcCentralizacionContable"
        Me.gpcCentralizacionContable.Size = New System.Drawing.Size(640, 198)
        Me.gpcCentralizacionContable.TabIndex = 34
        Me.gpcCentralizacionContable.Text = "Centralización Contable"
        '
        'gdcCentralizacion
        '
        Me.gdcCentralizacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcCentralizacion.Location = New System.Drawing.Point(16, 25)
        Me.gdcCentralizacion.MainView = Me.gdvDetalleCentralizacion
        Me.gdcCentralizacion.Name = "gdcCentralizacion"
        Me.gdcCentralizacion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lueImputacion, Me.lueCalidadJuridica})
        Me.gdcCentralizacion.Size = New System.Drawing.Size(608, 165)
        Me.gdcCentralizacion.TabIndex = 42
        Me.gdcCentralizacion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleCentralizacion})
        '
        'gdvDetalleCentralizacion
        '
        Me.gdvDetalleCentralizacion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.CENTRALIZACION_ID, Me.ITEM_ID_CENT, Me.PERIODO_ID, Me.CALIDAD_JURIDICA_ID, Me.IMPUTACION_ID, Me.CUENTA_CONTABLE, Me.CUENTA_PRESUPUESTO, Me.GLOSA, Me.ESTADO_REGISTRO_CENT})
        Me.gdvDetalleCentralizacion.GridControl = Me.gdcCentralizacion
        Me.gdvDetalleCentralizacion.Name = "gdvDetalleCentralizacion"
        Me.gdvDetalleCentralizacion.NewItemRowText = "Nuevo Registro en Centralización"
        Me.gdvDetalleCentralizacion.OptionsNavigation.EnterMoveNextColumn = True
        Me.gdvDetalleCentralizacion.OptionsView.ColumnAutoWidth = False
        Me.gdvDetalleCentralizacion.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gdvDetalleCentralizacion.OptionsView.ShowGroupPanel = False
        '
        'CENTRALIZACION_ID
        '
        Me.CENTRALIZACION_ID.Caption = "ID Centralización"
        Me.CENTRALIZACION_ID.FieldName = "CENTRALIZACION_ID"
        Me.CENTRALIZACION_ID.Name = "CENTRALIZACION_ID"
        '
        'ITEM_ID_CENT
        '
        Me.ITEM_ID_CENT.Caption = "ID Ítem"
        Me.ITEM_ID_CENT.FieldName = "ITEM_ID"
        Me.ITEM_ID_CENT.Name = "ITEM_ID_CENT"
        '
        'PERIODO_ID
        '
        Me.PERIODO_ID.Caption = "Período"
        Me.PERIODO_ID.FieldName = "PERIODO_ID"
        Me.PERIODO_ID.Name = "PERIODO_ID"
        '
        'CALIDAD_JURIDICA_ID
        '
        Me.CALIDAD_JURIDICA_ID.Caption = "Calidad Jurídica"
        Me.CALIDAD_JURIDICA_ID.ColumnEdit = Me.lueCalidadJuridica
        Me.CALIDAD_JURIDICA_ID.FieldName = "CALIDAD_JURIDICA_ID"
        Me.CALIDAD_JURIDICA_ID.Name = "CALIDAD_JURIDICA_ID"
        Me.CALIDAD_JURIDICA_ID.Visible = True
        Me.CALIDAD_JURIDICA_ID.VisibleIndex = 0
        Me.CALIDAD_JURIDICA_ID.Width = 145
        '
        'lueCalidadJuridica
        '
        Me.lueCalidadJuridica.AutoHeight = False
        Me.lueCalidadJuridica.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCalidadJuridica.Name = "lueCalidadJuridica"
        '
        'IMPUTACION_ID
        '
        Me.IMPUTACION_ID.Caption = "Imputación"
        Me.IMPUTACION_ID.ColumnEdit = Me.lueImputacion
        Me.IMPUTACION_ID.FieldName = "IMPUTACION_ID"
        Me.IMPUTACION_ID.Name = "IMPUTACION_ID"
        Me.IMPUTACION_ID.Visible = True
        Me.IMPUTACION_ID.VisibleIndex = 1
        Me.IMPUTACION_ID.Width = 114
        '
        'lueImputacion
        '
        Me.lueImputacion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueImputacion.Name = "lueImputacion"
        Me.lueImputacion.NullText = ""
        '
        'CUENTA_CONTABLE
        '
        Me.CUENTA_CONTABLE.Caption = "Cuenta Contable"
        Me.CUENTA_CONTABLE.FieldName = "CUENTA_CONTABLE"
        Me.CUENTA_CONTABLE.Name = "CUENTA_CONTABLE"
        Me.CUENTA_CONTABLE.Visible = True
        Me.CUENTA_CONTABLE.VisibleIndex = 2
        Me.CUENTA_CONTABLE.Width = 99
        '
        'CUENTA_PRESUPUESTO
        '
        Me.CUENTA_PRESUPUESTO.Caption = "Cuenta Presup."
        Me.CUENTA_PRESUPUESTO.FieldName = "CUENTA_PRESUPUESTO"
        Me.CUENTA_PRESUPUESTO.Name = "CUENTA_PRESUPUESTO"
        Me.CUENTA_PRESUPUESTO.Visible = True
        Me.CUENTA_PRESUPUESTO.VisibleIndex = 3
        Me.CUENTA_PRESUPUESTO.Width = 98
        '
        'GLOSA
        '
        Me.GLOSA.Caption = "Glosa"
        Me.GLOSA.FieldName = "GLOSA"
        Me.GLOSA.Name = "GLOSA"
        Me.GLOSA.Visible = True
        Me.GLOSA.VisibleIndex = 4
        Me.GLOSA.Width = 188
        '
        'ESTADO_REGISTRO_CENT
        '
        Me.ESTADO_REGISTRO_CENT.Caption = "Estado Registro"
        Me.ESTADO_REGISTRO_CENT.FieldName = "ESTADO_REGISTRO"
        Me.ESTADO_REGISTRO_CENT.Name = "ESTADO_REGISTRO_CENT"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Location = New System.Drawing.Point(480, 600)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 48
        Me.btnEliminar.Text = "&Eliminar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(392, 600)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 47
        Me.btnGuardar.Text = "&Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.Location = New System.Drawing.Point(304, 600)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 46
        Me.btnNuevo.Text = "&Nuevo"
        '
        'lycDefinicionItem
        '
        Me.lycDefinicionItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lycDefinicionItem.Controls.Add(Me.chkPermiteGeneracionMasiva)
        Me.lycDefinicionItem.Controls.Add(Me.chkEsAplicadoAHonorario)
        Me.lycDefinicionItem.Controls.Add(Me.chkEsCostoPresupuesto)
        Me.lycDefinicionItem.Controls.Add(Me.chkEsAfectoAtrasoInsistencia)
        Me.lycDefinicionItem.Controls.Add(Me.chkEsItemBienestar)
        Me.lycDefinicionItem.Controls.Add(Me.chkEsImprimible)
        Me.lycDefinicionItem.Controls.Add(Me.chkEsPermanente)
        Me.lycDefinicionItem.Controls.Add(Me.chkEsTributable)
        Me.lycDefinicionItem.Controls.Add(Me.chkEsCalculable)
        Me.lycDefinicionItem.Controls.Add(Me.chkEsCosto)
        Me.lycDefinicionItem.Controls.Add(Me.chkProporcinalDiasTrabajados)
        Me.lycDefinicionItem.Controls.Add(Me.chkEsImponibleMesHistorico)
        Me.lycDefinicionItem.Controls.Add(Me.chkCorrespondeaBonoModernizacion)
        Me.lycDefinicionItem.Controls.Add(Me.chkEsTributableMesHistorico)
        Me.lycDefinicionItem.Controls.Add(Me.chkTraspasaDiferenciaMovtoMensual)
        Me.lycDefinicionItem.Controls.Add(Me.txtProcedencia)
        Me.lycDefinicionItem.Controls.Add(Me.txtCodigoItemExterno)
        Me.lycDefinicionItem.Controls.Add(Me.txtCodigoAplicacionExterna)
        Me.lycDefinicionItem.Controls.Add(Me.txtNombreCeldaExcel)
        Me.lycDefinicionItem.Controls.Add(Me.chkEsImponible)
        Me.lycDefinicionItem.Location = New System.Drawing.Point(400, 184)
        Me.lycDefinicionItem.Name = "lycDefinicionItem"
        Me.lycDefinicionItem.Root = Me.lcgDefinicionItem
        Me.lycDefinicionItem.Size = New System.Drawing.Size(640, 208)
        Me.lycDefinicionItem.TabIndex = 49
        Me.lycDefinicionItem.Text = "Definicion Item"
        '
        'chkEsAplicadoAHonorario
        '
        Me.chkEsAplicadoAHonorario.Location = New System.Drawing.Point(475, 86)
        Me.chkEsAplicadoAHonorario.Name = "chkEsAplicadoAHonorario"
        Me.chkEsAplicadoAHonorario.Properties.Caption = "Es Aplicado a Honorario"
        Me.chkEsAplicadoAHonorario.Size = New System.Drawing.Size(150, 19)
        Me.chkEsAplicadoAHonorario.StyleController = Me.lycDefinicionItem
        Me.chkEsAplicadoAHonorario.TabIndex = 25
        '
        'chkEsCostoPresupuesto
        '
        Me.chkEsCostoPresupuesto.Location = New System.Drawing.Point(475, 57)
        Me.chkEsCostoPresupuesto.Name = "chkEsCostoPresupuesto"
        Me.chkEsCostoPresupuesto.Properties.Caption = "Es Costo Presupuesto"
        Me.chkEsCostoPresupuesto.Size = New System.Drawing.Size(150, 19)
        Me.chkEsCostoPresupuesto.StyleController = Me.lycDefinicionItem
        Me.chkEsCostoPresupuesto.TabIndex = 24
        '
        'chkEsAfectoAtrasoInsistencia
        '
        Me.chkEsAfectoAtrasoInsistencia.Location = New System.Drawing.Point(280, 115)
        Me.chkEsAfectoAtrasoInsistencia.Name = "chkEsAfectoAtrasoInsistencia"
        Me.chkEsAfectoAtrasoInsistencia.Properties.Caption = "Es Afecto Atraso o Inasistencia"
        Me.chkEsAfectoAtrasoInsistencia.Size = New System.Drawing.Size(185, 19)
        Me.chkEsAfectoAtrasoInsistencia.StyleController = Me.lycDefinicionItem
        Me.chkEsAfectoAtrasoInsistencia.TabIndex = 23
        '
        'chkEsItemBienestar
        '
        Me.chkEsItemBienestar.Location = New System.Drawing.Point(139, 115)
        Me.chkEsItemBienestar.Name = "chkEsItemBienestar"
        Me.chkEsItemBienestar.Properties.Caption = "Es Item Bienestar"
        Me.chkEsItemBienestar.Size = New System.Drawing.Size(131, 19)
        Me.chkEsItemBienestar.StyleController = Me.lycDefinicionItem
        Me.chkEsItemBienestar.TabIndex = 22
        '
        'chkEsImprimible
        '
        Me.chkEsImprimible.Location = New System.Drawing.Point(139, 86)
        Me.chkEsImprimible.Name = "chkEsImprimible"
        Me.chkEsImprimible.Properties.Caption = "Es Imprimible en Colilla"
        Me.chkEsImprimible.Size = New System.Drawing.Size(131, 19)
        Me.chkEsImprimible.StyleController = Me.lycDefinicionItem
        Me.chkEsImprimible.TabIndex = 6
        '
        'chkEsPermanente
        '
        Me.chkEsPermanente.Location = New System.Drawing.Point(15, 115)
        Me.chkEsPermanente.Name = "chkEsPermanente"
        Me.chkEsPermanente.Properties.Caption = "Es Permanente"
        Me.chkEsPermanente.Size = New System.Drawing.Size(114, 19)
        Me.chkEsPermanente.StyleController = Me.lycDefinicionItem
        Me.chkEsPermanente.TabIndex = 8
        '
        'chkEsTributable
        '
        Me.chkEsTributable.Location = New System.Drawing.Point(139, 57)
        Me.chkEsTributable.Name = "chkEsTributable"
        Me.chkEsTributable.Properties.Caption = "Es Tributable"
        Me.chkEsTributable.Size = New System.Drawing.Size(131, 19)
        Me.chkEsTributable.StyleController = Me.lycDefinicionItem
        Me.chkEsTributable.TabIndex = 9
        '
        'chkEsCalculable
        '
        Me.chkEsCalculable.Location = New System.Drawing.Point(280, 57)
        Me.chkEsCalculable.Name = "chkEsCalculable"
        Me.chkEsCalculable.Properties.Caption = "Es Calculable"
        Me.chkEsCalculable.Size = New System.Drawing.Size(185, 19)
        Me.chkEsCalculable.StyleController = Me.lycDefinicionItem
        Me.chkEsCalculable.TabIndex = 10
        '
        'chkEsCosto
        '
        Me.chkEsCosto.Location = New System.Drawing.Point(15, 86)
        Me.chkEsCosto.Name = "chkEsCosto"
        Me.chkEsCosto.Properties.Caption = "Es Costo Contable"
        Me.chkEsCosto.Size = New System.Drawing.Size(114, 19)
        Me.chkEsCosto.StyleController = Me.lycDefinicionItem
        Me.chkEsCosto.TabIndex = 11
        '
        'chkProporcinalDiasTrabajados
        '
        Me.chkProporcinalDiasTrabajados.Location = New System.Drawing.Point(280, 86)
        Me.chkProporcinalDiasTrabajados.Name = "chkProporcinalDiasTrabajados"
        Me.chkProporcinalDiasTrabajados.Properties.Caption = "Es Proporcional a Días Trabajados"
        Me.chkProporcinalDiasTrabajados.Size = New System.Drawing.Size(185, 19)
        Me.chkProporcinalDiasTrabajados.StyleController = Me.lycDefinicionItem
        Me.chkProporcinalDiasTrabajados.TabIndex = 13
        '
        'chkEsImponibleMesHistorico
        '
        Me.chkEsImponibleMesHistorico.Location = New System.Drawing.Point(15, 86)
        Me.chkEsImponibleMesHistorico.Name = "chkEsImponibleMesHistorico"
        Me.chkEsImponibleMesHistorico.Properties.Caption = "Es Imponible en Mes Histórico"
        Me.chkEsImponibleMesHistorico.Size = New System.Drawing.Size(610, 19)
        Me.chkEsImponibleMesHistorico.StyleController = Me.lycDefinicionItem
        Me.chkEsImponibleMesHistorico.TabIndex = 15
        '
        'chkCorrespondeaBonoModernizacion
        '
        Me.chkCorrespondeaBonoModernizacion.Location = New System.Drawing.Point(15, 57)
        Me.chkCorrespondeaBonoModernizacion.Name = "chkCorrespondeaBonoModernizacion"
        Me.chkCorrespondeaBonoModernizacion.Properties.Caption = "Corresponde a Bono Modernización"
        Me.chkCorrespondeaBonoModernizacion.Size = New System.Drawing.Size(365, 19)
        Me.chkCorrespondeaBonoModernizacion.StyleController = Me.lycDefinicionItem
        Me.chkCorrespondeaBonoModernizacion.TabIndex = 14
        '
        'chkEsTributableMesHistorico
        '
        Me.chkEsTributableMesHistorico.Location = New System.Drawing.Point(15, 115)
        Me.chkEsTributableMesHistorico.Name = "chkEsTributableMesHistorico"
        Me.chkEsTributableMesHistorico.Properties.Caption = "Es Tributable en Mes Histórico"
        Me.chkEsTributableMesHistorico.Size = New System.Drawing.Size(610, 19)
        Me.chkEsTributableMesHistorico.StyleController = Me.lycDefinicionItem
        Me.chkEsTributableMesHistorico.TabIndex = 16
        '
        'chkTraspasaDiferenciaMovtoMensual
        '
        Me.chkTraspasaDiferenciaMovtoMensual.Location = New System.Drawing.Point(390, 57)
        Me.chkTraspasaDiferenciaMovtoMensual.Name = "chkTraspasaDiferenciaMovtoMensual"
        Me.chkTraspasaDiferenciaMovtoMensual.Properties.Caption = "Traspasa Diferencia a Movimiento Mensual"
        Me.chkTraspasaDiferenciaMovtoMensual.Size = New System.Drawing.Size(235, 19)
        Me.chkTraspasaDiferenciaMovtoMensual.StyleController = Me.lycDefinicionItem
        Me.chkTraspasaDiferenciaMovtoMensual.TabIndex = 17
        '
        'txtProcedencia
        '
        Me.txtProcedencia.Location = New System.Drawing.Point(570, 57)
        Me.txtProcedencia.Name = "txtProcedencia"
        Me.txtProcedencia.Size = New System.Drawing.Size(55, 20)
        Me.txtProcedencia.StyleController = Me.lycDefinicionItem
        Me.txtProcedencia.TabIndex = 18
        '
        'txtCodigoItemExterno
        '
        Me.txtCodigoItemExterno.Location = New System.Drawing.Point(184, 57)
        Me.txtCodigoItemExterno.Name = "txtCodigoItemExterno"
        Me.txtCodigoItemExterno.Properties.DisplayFormat.FormatString = "n0"
        Me.txtCodigoItemExterno.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigoItemExterno.Properties.EditFormat.FormatString = "n0"
        Me.txtCodigoItemExterno.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigoItemExterno.Properties.Mask.EditMask = "n0"
        Me.txtCodigoItemExterno.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCodigoItemExterno.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCodigoItemExterno.Properties.MaxLength = 3
        Me.txtCodigoItemExterno.Size = New System.Drawing.Size(207, 20)
        Me.txtCodigoItemExterno.StyleController = Me.lycDefinicionItem
        Me.txtCodigoItemExterno.TabIndex = 19
        '
        'txtCodigoAplicacionExterna
        '
        Me.txtCodigoAplicacionExterna.Location = New System.Drawing.Point(184, 87)
        Me.txtCodigoAplicacionExterna.Name = "txtCodigoAplicacionExterna"
        Me.txtCodigoAplicacionExterna.Properties.DisplayFormat.FormatString = "n0"
        Me.txtCodigoAplicacionExterna.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigoAplicacionExterna.Properties.EditFormat.FormatString = "0"
        Me.txtCodigoAplicacionExterna.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigoAplicacionExterna.Properties.Mask.EditMask = "n0"
        Me.txtCodigoAplicacionExterna.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCodigoAplicacionExterna.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCodigoAplicacionExterna.Properties.MaxLength = 3
        Me.txtCodigoAplicacionExterna.Size = New System.Drawing.Size(207, 20)
        Me.txtCodigoAplicacionExterna.StyleController = Me.lycDefinicionItem
        Me.txtCodigoAplicacionExterna.TabIndex = 20
        '
        'txtNombreCeldaExcel
        '
        Me.txtNombreCeldaExcel.Location = New System.Drawing.Point(184, 57)
        Me.txtNombreCeldaExcel.Name = "txtNombreCeldaExcel"
        Me.txtNombreCeldaExcel.Size = New System.Drawing.Size(441, 20)
        Me.txtNombreCeldaExcel.StyleController = Me.lycDefinicionItem
        Me.txtNombreCeldaExcel.TabIndex = 21
        '
        'chkEsImponible
        '
        Me.chkEsImponible.Location = New System.Drawing.Point(15, 57)
        Me.chkEsImponible.Name = "chkEsImponible"
        Me.chkEsImponible.Properties.Caption = "Es Imponible"
        Me.chkEsImponible.Size = New System.Drawing.Size(114, 19)
        Me.chkEsImponible.StyleController = Me.lycDefinicionItem
        Me.chkEsImponible.TabIndex = 5
        '
        'lcgDefinicionItem
        '
        Me.lcgDefinicionItem.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lcgDefinicionItem.AppearanceGroup.Options.UseFont = True
        Me.lcgDefinicionItem.CustomizationFormText = "Definición de Atributos "
        Me.lcgDefinicionItem.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.tcgItem})
        Me.lcgDefinicionItem.Location = New System.Drawing.Point(0, 0)
        Me.lcgDefinicionItem.Name = "lcgDefinicionItem"
        Me.lcgDefinicionItem.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lcgDefinicionItem.Size = New System.Drawing.Size(640, 208)
        Me.lcgDefinicionItem.Text = "Definición de Atributos "
        '
        'tcgItem
        '
        Me.tcgItem.CustomizationFormText = "Item"
        Me.tcgItem.Location = New System.Drawing.Point(0, 0)
        Me.tcgItem.Name = "tcgItem"
        Me.tcgItem.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.tcgItem.SelectedTabPage = Me.lcgAcercaItem
        Me.tcgItem.SelectedTabPageIndex = 0
        Me.tcgItem.Size = New System.Drawing.Size(638, 186)
        Me.tcgItem.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcgAcercaItem, Me.lygBonoModernidad, Me.lcgImportacion, Me.lcgCalculoExcel})
        Me.tcgItem.Text = "Item"
        '
        'lcgAcercaItem
        '
        Me.lcgAcercaItem.CustomizationFormText = "Acerca del Ítem"
        Me.lcgAcercaItem.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciEsImponible, Me.lciEsImprimible, Me.lciEsPermanente, Me.lciEsTributable, Me.lciEsCalculable, Me.lciEsCosto, Me.lciEsProporcinarDiasTrabajados, Me.lciEsItemBienestar, Me.lciEsAfectoAtrasoInsistencia, Me.lciEsCostoPresupuesto, Me.lciEsAplicadoAHonorario, Me.lciGeneracionMasiva})
        Me.lcgAcercaItem.Location = New System.Drawing.Point(0, 0)
        Me.lcgAcercaItem.Name = "lcgAcercaItem"
        Me.lcgAcercaItem.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lcgAcercaItem.Size = New System.Drawing.Size(620, 146)
        Me.lcgAcercaItem.Text = "Acerca del Ítem"
        '
        'lciEsImponible
        '
        Me.lciEsImponible.Control = Me.chkEsImponible
        Me.lciEsImponible.CustomizationFormText = "Es Imponible"
        Me.lciEsImponible.Location = New System.Drawing.Point(0, 0)
        Me.lciEsImponible.Name = "lciEsImponible"
        Me.lciEsImponible.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciEsImponible.Size = New System.Drawing.Size(124, 29)
        Me.lciEsImponible.Text = "Es Imponible"
        Me.lciEsImponible.TextSize = New System.Drawing.Size(0, 0)
        Me.lciEsImponible.TextToControlDistance = 0
        Me.lciEsImponible.TextVisible = False
        '
        'lciEsImprimible
        '
        Me.lciEsImprimible.Control = Me.chkEsImprimible
        Me.lciEsImprimible.CustomizationFormText = "Es Imprimible"
        Me.lciEsImprimible.Location = New System.Drawing.Point(124, 29)
        Me.lciEsImprimible.Name = "lciEsImprimible"
        Me.lciEsImprimible.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciEsImprimible.Size = New System.Drawing.Size(141, 29)
        Me.lciEsImprimible.Text = "Es Imprimible"
        Me.lciEsImprimible.TextSize = New System.Drawing.Size(0, 0)
        Me.lciEsImprimible.TextToControlDistance = 0
        Me.lciEsImprimible.TextVisible = False
        '
        'lciEsPermanente
        '
        Me.lciEsPermanente.Control = Me.chkEsPermanente
        Me.lciEsPermanente.CustomizationFormText = "Es Permanente"
        Me.lciEsPermanente.Location = New System.Drawing.Point(0, 58)
        Me.lciEsPermanente.Name = "lciEsPermanente"
        Me.lciEsPermanente.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciEsPermanente.Size = New System.Drawing.Size(124, 88)
        Me.lciEsPermanente.Text = "Es Permanente"
        Me.lciEsPermanente.TextSize = New System.Drawing.Size(0, 0)
        Me.lciEsPermanente.TextToControlDistance = 0
        Me.lciEsPermanente.TextVisible = False
        '
        'lciEsTributable
        '
        Me.lciEsTributable.Control = Me.chkEsTributable
        Me.lciEsTributable.CustomizationFormText = "Es Tributable"
        Me.lciEsTributable.Location = New System.Drawing.Point(124, 0)
        Me.lciEsTributable.Name = "lciEsTributable"
        Me.lciEsTributable.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciEsTributable.Size = New System.Drawing.Size(141, 29)
        Me.lciEsTributable.Text = "Es Tributable"
        Me.lciEsTributable.TextSize = New System.Drawing.Size(0, 0)
        Me.lciEsTributable.TextToControlDistance = 0
        Me.lciEsTributable.TextVisible = False
        '
        'lciEsCalculable
        '
        Me.lciEsCalculable.Control = Me.chkEsCalculable
        Me.lciEsCalculable.CustomizationFormText = "Es Calculable"
        Me.lciEsCalculable.Location = New System.Drawing.Point(265, 0)
        Me.lciEsCalculable.Name = "lciEsCalculable"
        Me.lciEsCalculable.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciEsCalculable.Size = New System.Drawing.Size(195, 29)
        Me.lciEsCalculable.Text = "Es Calculable"
        Me.lciEsCalculable.TextSize = New System.Drawing.Size(0, 0)
        Me.lciEsCalculable.TextToControlDistance = 0
        Me.lciEsCalculable.TextVisible = False
        '
        'lciEsCosto
        '
        Me.lciEsCosto.Control = Me.chkEsCosto
        Me.lciEsCosto.CustomizationFormText = "Es Costo"
        Me.lciEsCosto.Location = New System.Drawing.Point(0, 29)
        Me.lciEsCosto.Name = "lciEsCosto"
        Me.lciEsCosto.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciEsCosto.Size = New System.Drawing.Size(124, 29)
        Me.lciEsCosto.Text = "Es Costo"
        Me.lciEsCosto.TextSize = New System.Drawing.Size(0, 0)
        Me.lciEsCosto.TextToControlDistance = 0
        Me.lciEsCosto.TextVisible = False
        '
        'lciEsProporcinarDiasTrabajados
        '
        Me.lciEsProporcinarDiasTrabajados.Control = Me.chkProporcinalDiasTrabajados
        Me.lciEsProporcinarDiasTrabajados.CustomizationFormText = "Es Proporcinar a Dias Trabajados"
        Me.lciEsProporcinarDiasTrabajados.Location = New System.Drawing.Point(265, 29)
        Me.lciEsProporcinarDiasTrabajados.Name = "lciEsProporcinarDiasTrabajados"
        Me.lciEsProporcinarDiasTrabajados.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciEsProporcinarDiasTrabajados.Size = New System.Drawing.Size(195, 29)
        Me.lciEsProporcinarDiasTrabajados.Text = "Es Proporcinar a Dias Trabajados"
        Me.lciEsProporcinarDiasTrabajados.TextSize = New System.Drawing.Size(0, 0)
        Me.lciEsProporcinarDiasTrabajados.TextToControlDistance = 0
        Me.lciEsProporcinarDiasTrabajados.TextVisible = False
        '
        'lciEsItemBienestar
        '
        Me.lciEsItemBienestar.Control = Me.chkEsItemBienestar
        Me.lciEsItemBienestar.CustomizationFormText = "Es Item Bienestar"
        Me.lciEsItemBienestar.Location = New System.Drawing.Point(124, 58)
        Me.lciEsItemBienestar.Name = "lciEsItemBienestar"
        Me.lciEsItemBienestar.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciEsItemBienestar.Size = New System.Drawing.Size(141, 88)
        Me.lciEsItemBienestar.Text = "Es Item Bienestar"
        Me.lciEsItemBienestar.TextSize = New System.Drawing.Size(0, 0)
        Me.lciEsItemBienestar.TextToControlDistance = 0
        Me.lciEsItemBienestar.TextVisible = False
        '
        'lciEsAfectoAtrasoInsistencia
        '
        Me.lciEsAfectoAtrasoInsistencia.Control = Me.chkEsAfectoAtrasoInsistencia
        Me.lciEsAfectoAtrasoInsistencia.CustomizationFormText = "Es Afecto Atraso Insistencia"
        Me.lciEsAfectoAtrasoInsistencia.Location = New System.Drawing.Point(265, 58)
        Me.lciEsAfectoAtrasoInsistencia.Name = "lciEsAfectoAtrasoInsistencia"
        Me.lciEsAfectoAtrasoInsistencia.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciEsAfectoAtrasoInsistencia.Size = New System.Drawing.Size(195, 88)
        Me.lciEsAfectoAtrasoInsistencia.Text = "Es Afecto Atraso Insistencia"
        Me.lciEsAfectoAtrasoInsistencia.TextSize = New System.Drawing.Size(0, 0)
        Me.lciEsAfectoAtrasoInsistencia.TextToControlDistance = 0
        Me.lciEsAfectoAtrasoInsistencia.TextVisible = False
        '
        'lciEsCostoPresupuesto
        '
        Me.lciEsCostoPresupuesto.Control = Me.chkEsCostoPresupuesto
        Me.lciEsCostoPresupuesto.CustomizationFormText = "Es Costo Presupuesto"
        Me.lciEsCostoPresupuesto.Location = New System.Drawing.Point(460, 0)
        Me.lciEsCostoPresupuesto.Name = "lciEsCostoPresupuesto"
        Me.lciEsCostoPresupuesto.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciEsCostoPresupuesto.Size = New System.Drawing.Size(160, 29)
        Me.lciEsCostoPresupuesto.Text = "Es Costo Presupuesto"
        Me.lciEsCostoPresupuesto.TextSize = New System.Drawing.Size(0, 0)
        Me.lciEsCostoPresupuesto.TextToControlDistance = 0
        Me.lciEsCostoPresupuesto.TextVisible = False
        '
        'lciEsAplicadoAHonorario
        '
        Me.lciEsAplicadoAHonorario.Control = Me.chkEsAplicadoAHonorario
        Me.lciEsAplicadoAHonorario.CustomizationFormText = "Es Aplicado a Honorario"
        Me.lciEsAplicadoAHonorario.Location = New System.Drawing.Point(460, 29)
        Me.lciEsAplicadoAHonorario.Name = "lciEsAplicadoAHonorario"
        Me.lciEsAplicadoAHonorario.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciEsAplicadoAHonorario.Size = New System.Drawing.Size(160, 29)
        Me.lciEsAplicadoAHonorario.Text = "Es Aplicado a Honorario"
        Me.lciEsAplicadoAHonorario.TextSize = New System.Drawing.Size(0, 0)
        Me.lciEsAplicadoAHonorario.TextToControlDistance = 0
        Me.lciEsAplicadoAHonorario.TextVisible = False
        '
        'lygBonoModernidad
        '
        Me.lygBonoModernidad.CustomizationFormText = "Bono Modernidad"
        Me.lygBonoModernidad.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciEsImponibleMesHistorico, Me.lciCorrespondeaBonoModernizacion, Me.lciEsTributableMesHistorico, Me.lciTraspasaDiferenciaMovtoMensual})
        Me.lygBonoModernidad.Location = New System.Drawing.Point(0, 0)
        Me.lygBonoModernidad.Name = "lygBonoModernidad"
        Me.lygBonoModernidad.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lygBonoModernidad.Size = New System.Drawing.Size(620, 146)
        Me.lygBonoModernidad.Text = "Bono Modernidad"
        '
        'lciEsImponibleMesHistorico
        '
        Me.lciEsImponibleMesHistorico.Control = Me.chkEsImponibleMesHistorico
        Me.lciEsImponibleMesHistorico.CustomizationFormText = "Es Imponible en Mes Historico"
        Me.lciEsImponibleMesHistorico.Location = New System.Drawing.Point(0, 29)
        Me.lciEsImponibleMesHistorico.Name = "lciEsImponibleMesHistorico"
        Me.lciEsImponibleMesHistorico.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciEsImponibleMesHistorico.Size = New System.Drawing.Size(620, 29)
        Me.lciEsImponibleMesHistorico.Text = "Es Imponible en Mes Historico"
        Me.lciEsImponibleMesHistorico.TextSize = New System.Drawing.Size(0, 0)
        Me.lciEsImponibleMesHistorico.TextToControlDistance = 0
        Me.lciEsImponibleMesHistorico.TextVisible = False
        '
        'lciCorrespondeaBonoModernizacion
        '
        Me.lciCorrespondeaBonoModernizacion.Control = Me.chkCorrespondeaBonoModernizacion
        Me.lciCorrespondeaBonoModernizacion.CustomizationFormText = "Correspondea a Bono Modernizacion"
        Me.lciCorrespondeaBonoModernizacion.Location = New System.Drawing.Point(0, 0)
        Me.lciCorrespondeaBonoModernizacion.Name = "lciCorrespondeaBonoModernizacion"
        Me.lciCorrespondeaBonoModernizacion.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciCorrespondeaBonoModernizacion.Size = New System.Drawing.Size(375, 29)
        Me.lciCorrespondeaBonoModernizacion.Text = "Correspondea a Bono Modernizacion"
        Me.lciCorrespondeaBonoModernizacion.TextSize = New System.Drawing.Size(0, 0)
        Me.lciCorrespondeaBonoModernizacion.TextToControlDistance = 0
        Me.lciCorrespondeaBonoModernizacion.TextVisible = False
        '
        'lciEsTributableMesHistorico
        '
        Me.lciEsTributableMesHistorico.Control = Me.chkEsTributableMesHistorico
        Me.lciEsTributableMesHistorico.CustomizationFormText = "Es Tributable en Mes Historico"
        Me.lciEsTributableMesHistorico.Location = New System.Drawing.Point(0, 58)
        Me.lciEsTributableMesHistorico.Name = "lciEsTributableMesHistorico"
        Me.lciEsTributableMesHistorico.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciEsTributableMesHistorico.Size = New System.Drawing.Size(620, 88)
        Me.lciEsTributableMesHistorico.Text = "Es Tributable en Mes Historico"
        Me.lciEsTributableMesHistorico.TextSize = New System.Drawing.Size(0, 0)
        Me.lciEsTributableMesHistorico.TextToControlDistance = 0
        Me.lciEsTributableMesHistorico.TextVisible = False
        '
        'lciTraspasaDiferenciaMovtoMensual
        '
        Me.lciTraspasaDiferenciaMovtoMensual.Control = Me.chkTraspasaDiferenciaMovtoMensual
        Me.lciTraspasaDiferenciaMovtoMensual.CustomizationFormText = "Traspasa Diferencia Movto Mensual"
        Me.lciTraspasaDiferenciaMovtoMensual.Location = New System.Drawing.Point(375, 0)
        Me.lciTraspasaDiferenciaMovtoMensual.Name = "lciTraspasaDiferenciaMovtoMensual"
        Me.lciTraspasaDiferenciaMovtoMensual.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciTraspasaDiferenciaMovtoMensual.Size = New System.Drawing.Size(245, 29)
        Me.lciTraspasaDiferenciaMovtoMensual.Text = "Traspasa Diferencia Movto Mensual"
        Me.lciTraspasaDiferenciaMovtoMensual.TextSize = New System.Drawing.Size(0, 0)
        Me.lciTraspasaDiferenciaMovtoMensual.TextToControlDistance = 0
        Me.lciTraspasaDiferenciaMovtoMensual.TextVisible = False
        '
        'lcgImportacion
        '
        Me.lcgImportacion.CustomizationFormText = "Importación"
        Me.lcgImportacion.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciProcedencia, Me.lciCodigoItemExterno, Me.lciCodigoAplicacionExterna})
        Me.lcgImportacion.Location = New System.Drawing.Point(0, 0)
        Me.lcgImportacion.Name = "lcgImportacion"
        Me.lcgImportacion.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lcgImportacion.Size = New System.Drawing.Size(620, 146)
        Me.lcgImportacion.Text = "Importación"
        '
        'lciProcedencia
        '
        Me.lciProcedencia.Control = Me.txtProcedencia
        Me.lciProcedencia.CustomizationFormText = "Nombre Procedencia"
        Me.lciProcedencia.Location = New System.Drawing.Point(386, 0)
        Me.lciProcedencia.Name = "lciProcedencia"
        Me.lciProcedencia.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciProcedencia.Size = New System.Drawing.Size(234, 146)
        Me.lciProcedencia.Text = "Nombre Procedencia"
        Me.lciProcedencia.TextSize = New System.Drawing.Size(166, 13)
        '
        'lciCodigoItemExterno
        '
        Me.lciCodigoItemExterno.Control = Me.txtCodigoItemExterno
        Me.lciCodigoItemExterno.CustomizationFormText = "Código Ítem Externo"
        Me.lciCodigoItemExterno.Location = New System.Drawing.Point(0, 0)
        Me.lciCodigoItemExterno.Name = "lciCodigoItemExterno"
        Me.lciCodigoItemExterno.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciCodigoItemExterno.Size = New System.Drawing.Size(386, 30)
        Me.lciCodigoItemExterno.Text = "Código Ítem Externo"
        Me.lciCodigoItemExterno.TextSize = New System.Drawing.Size(166, 13)
        '
        'lciCodigoAplicacionExterna
        '
        Me.lciCodigoAplicacionExterna.Control = Me.txtCodigoAplicacionExterna
        Me.lciCodigoAplicacionExterna.CustomizationFormText = "Código Aplicación Externa"
        Me.lciCodigoAplicacionExterna.Location = New System.Drawing.Point(0, 30)
        Me.lciCodigoAplicacionExterna.Name = "lciCodigoAplicacionExterna"
        Me.lciCodigoAplicacionExterna.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciCodigoAplicacionExterna.Size = New System.Drawing.Size(386, 116)
        Me.lciCodigoAplicacionExterna.Text = "Código Aplicación Externa"
        Me.lciCodigoAplicacionExterna.TextSize = New System.Drawing.Size(166, 13)
        '
        'lcgCalculoExcel
        '
        Me.lcgCalculoExcel.CustomizationFormText = "Cálculo Excel"
        Me.lcgCalculoExcel.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciCalculoExcel})
        Me.lcgCalculoExcel.Location = New System.Drawing.Point(0, 0)
        Me.lcgCalculoExcel.Name = "lcgCalculoExcel"
        Me.lcgCalculoExcel.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lcgCalculoExcel.Size = New System.Drawing.Size(620, 146)
        Me.lcgCalculoExcel.Text = "Cálculo Excel"
        '
        'lciCalculoExcel
        '
        Me.lciCalculoExcel.Control = Me.txtNombreCeldaExcel
        Me.lciCalculoExcel.CustomizationFormText = "Nombre Celda para Ítem Calculado"
        Me.lciCalculoExcel.Location = New System.Drawing.Point(0, 0)
        Me.lciCalculoExcel.Name = "lciCalculoExcel"
        Me.lciCalculoExcel.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciCalculoExcel.Size = New System.Drawing.Size(620, 146)
        Me.lciCalculoExcel.Text = "Nombre Celda para Ítem Calculado"
        Me.lciCalculoExcel.TextSize = New System.Drawing.Size(166, 13)
        '
        'chkPermiteGeneracionMasiva
        '
        Me.chkPermiteGeneracionMasiva.Location = New System.Drawing.Point(472, 112)
        Me.chkPermiteGeneracionMasiva.Name = "chkPermiteGeneracionMasiva"
        Me.chkPermiteGeneracionMasiva.Properties.Caption = "Permite Generación Masiva"
        Me.chkPermiteGeneracionMasiva.Size = New System.Drawing.Size(156, 19)
        Me.chkPermiteGeneracionMasiva.StyleController = Me.lycDefinicionItem
        Me.chkPermiteGeneracionMasiva.TabIndex = 26
        '
        'lciGeneracionMasiva
        '
        Me.lciGeneracionMasiva.Control = Me.chkPermiteGeneracionMasiva
        Me.lciGeneracionMasiva.CustomizationFormText = "lciGeneracionMasiva"
        Me.lciGeneracionMasiva.Location = New System.Drawing.Point(460, 58)
        Me.lciGeneracionMasiva.Name = "lciGeneracionMasiva"
        Me.lciGeneracionMasiva.Size = New System.Drawing.Size(160, 88)
        Me.lciGeneracionMasiva.Text = "lciGeneracionMasiva"
        Me.lciGeneracionMasiva.TextSize = New System.Drawing.Size(0, 0)
        Me.lciGeneracionMasiva.TextToControlDistance = 0
        Me.lciGeneracionMasiva.TextVisible = False
        '
        'PERMITE_GENERACION_MASIVA
        '
        Me.PERMITE_GENERACION_MASIVA.Caption = "Permite Generacion Masiva"
        Me.PERMITE_GENERACION_MASIVA.FieldName = "PERMITE_GENERACION_MASIVA"
        Me.PERMITE_GENERACION_MASIVA.Name = "PERMITE_GENERACION_MASIVA"
        Me.PERMITE_GENERACION_MASIVA.OptionsColumn.ShowInCustomizationForm = False
        '
        'frmItemes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1048, 637)
        Me.Controls.Add(Me.lycDefinicionItem)
        Me.Controls.Add(Me.gpcCentralizacionContable)
        Me.Controls.Add(Me.gdcItem)
        Me.Controls.Add(Me.gpcDefinicionItem)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Name = "frmItemes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Definición de Itemes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txtItemAlias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvItemes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleTipoItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDefinicionItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDefinicionItem.ResumeLayout(False)
        CType(Me.chkEstadoRegistro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgTipoItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSecuenciaImpresion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionCorta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionLarga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcCentralizacionContable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcCentralizacionContable.ResumeLayout(False)
        CType(Me.gdcCentralizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleCentralizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCalidadJuridica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueImputacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvLibroAuditoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvLibroOficial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvCalidadJuridica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycDefinicionItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycDefinicionItem.ResumeLayout(False)
        CType(Me.chkEsAplicadoAHonorario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEsCostoPresupuesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEsAfectoAtrasoInsistencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEsItemBienestar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEsImprimible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEsPermanente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEsTributable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEsCalculable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEsCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkProporcinalDiasTrabajados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEsImponibleMesHistorico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCorrespondeaBonoModernizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEsTributableMesHistorico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTraspasaDiferenciaMovtoMensual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcedencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoItemExterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoAplicacionExterna.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreCeldaExcel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEsImponible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgDefinicionItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcgItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgAcercaItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEsImponible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEsImprimible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEsPermanente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEsTributable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEsCalculable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEsCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEsProporcinarDiasTrabajados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEsItemBienestar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEsAfectoAtrasoInsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEsCostoPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEsAplicadoAHonorario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lygBonoModernidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEsImponibleMesHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciCorrespondeaBonoModernizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEsTributableMesHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciTraspasaDiferenciaMovtoMensual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgImportacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciProcedencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciCodigoItemExterno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciCodigoAplicacionExterna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgCalculoExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciCalculoExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvImputacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvTipoItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPermiteGeneracionMasiva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciGeneracionMasiva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim da As SqlClient.SqlDataAdapter
    Dim item As item
    Dim periodo As Periodo

    Private Sub frmItemes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        item = New Item
        periodo = New Periodo
        GeneraDataViews()
        llenarCalidadJuridica()
        llenarImputacion()
        llenarTipoItemGrilla()
        gdcItem.DataSource = item.dvDatosItemes()
        lycDefinicionItem.Enabled = False
        gpcDefinicionItem.Enabled = False
        gpcCentralizacionContable.Enabled = False
        btnGuardar.Enabled = False
        btnEliminar.Enabled = False
        btnNuevo.Enabled = True
    End Sub
    Private Sub GeneraDataViews()
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
        Dim ds1 As New DataSet
        Dim ds2 As New DataSet
        Dim ds3 As New DataSet
        Dim ds4 As New DataSet
        Dim ds5 As New DataSet

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_ITEM, conn))
        da.Fill(ds1, Tablas.RH_REM_ITEM)
        Dim dvmItem As New DataViewManager(ds1)
        dvItem = dvmItem.CreateDataView(ds1.Tables(Tablas.RH_REM_ITEM))

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_CALIDAD_JURIDICA, conn))
        da.Fill(ds3, Tablas.RH_REM_CALIDAD_JURIDICA)
        Dim dvmCalJur As New DataViewManager(ds3)
        dvCalidadJuridica = dvmCalJur.CreateDataView(ds3.Tables(Tablas.RH_REM_CALIDAD_JURIDICA))

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_IMPUTACION, conn))
        da.Fill(ds4, Tablas.RH_REM_CENTRALIZACION_IMPUTACION)
        Dim dvmImputacion As New DataViewManager(ds4)
        dvImputacion = dvmImputacion.CreateDataView(ds4.Tables(Tablas.RH_REM_CENTRALIZACION_IMPUTACION))

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_TIPO_ITEM, conn))
        da.Fill(ds5, Tablas.RH_REM_TIPO_ITEM)
        Dim dvmTipoItem As New DataViewManager(ds5)
        dvTipoItem = dvmTipoItem.CreateDataView(ds5.Tables(Tablas.RH_REM_TIPO_ITEM))

    End Sub
    Private Sub llenarImputacion()
        With lueImputacion.Columns
            .Add(New LookUpColumnInfo("IMPUTACION_ID", "ID Columna", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
            .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
        End With
        lueImputacion.DataSource = dvImputacion
        lueImputacion.DisplayMember = "DESCRIPCION"
        lueImputacion.NullText = ""
        lueImputacion.PopupWidth = 120
        lueImputacion.ValueMember = "IMPUTACION_ID"
    End Sub
    Private Sub llenarCalidadJuridica()
        With lueCalidadJuridica.Columns
            .Add(New LookUpColumnInfo("CALIDAD_JURIDICA_ID", "ID Columna", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
            .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
        End With
        lueCalidadJuridica.DataSource = dvCalidadJuridica
        lueCalidadJuridica.DisplayMember = "DESCRIPCION"
        lueCalidadJuridica.NullText = ""
        lueCalidadJuridica.PopupWidth = 150
        lueCalidadJuridica.ValueMember = "CALIDAD_JURIDICA_ID"
    End Sub
    Public Sub llenarTipoItemGrilla()
        gleTipoItem.ViewType = Repository.GridLookUpViewType.GridView
        gleTipoItem.View.OptionsBehavior.AutoPopulateColumns = False
        gleTipoItem.DataSource = dvTipoItem
        gleTipoItem.DisplayMember = "DESCRIPCION"

        Dim col1 As GridColumn = gleTipoItem.View.Columns.AddField("TIPO_ITEM")
        col1.VisibleIndex = 0
        col1.Caption = "Tipo Item ID"
        col1.Visible = False

        Dim col2 As GridColumn = gleTipoItem.View.Columns.AddField("DESCRIPCION")
        col2.VisibleIndex = 1
        col2.Caption = "Descripción"

        gleTipoItem.ValueMember = "TIPO_ITEM"
        gleTipoItem.View.BestFitColumns()
        gleTipoItem.PopupFormWidth = 100
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        item = New item
        seteaDefault()
        lycDefinicionItem.Enabled = True
        gpcDefinicionItem.Enabled = True
        gpcCentralizacionContable.Enabled = False
        btnGuardar.Enabled = True
        txtItemAlias.Focus()
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If validaciones() Then
            asignaCampos()
            If item.Id = 0 Then
                Try
                    item.Crear()
                    repositorio.RefreshDatos("Item")
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al crear el item " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            Else
                Try
                    item.Actualizar()
                    repositorio.RefreshDatos("Item")
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al actualizar el item " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
            inicializaConatroles()
            gdcItem.DataSource = item.dvDatosItemes()
            lycDefinicionItem.Enabled = False
            gpcDefinicionItem.Enabled = False
            gpcCentralizacionContable.Enabled = False
        End If
    End Sub
    Private Sub asignaCampos()
        item.tipoItem = rdgTipoItem.SelectedIndex
        item.codigo = UCase(txtItemAlias.Text)
        item.descripcionLarga = txtDescripcionLarga.Text
        item.descripcionCorta = txtDescripcionCorta.Text
        item.esImponible = chkEsImponible.Checked
        item.esTributable = chkEsTributable.Checked
        item.esCalculable = chkEsCalculable.Checked
        item.esPermanente = chkEsPermanente.Checked
        item.esImprimible = chkEsImprimible.Checked
        item.esCosto = chkEsCosto.Checked
        If txtSecuenciaImpresion.Text = "" Then
            item.secuenciaImpresion = 0
        Else
            item.secuenciaImpresion = txtSecuenciaImpresion.Text
        End If
        item.columnaLibroAudit1 = 0
        item.columnaLibroAudit2 = 0
        item.columnaLibroOficial = 0
        item.esItemBienestar = chkEsItemBienestar.Checked
        If chkProporcinalDiasTrabajados.Checked Then
            item.esProporcinalDiasTrabajados = True
        Else
            item.esProporcinalDiasTrabajados = False
        End If
        item.correspondeBonoModernidad = chkCorrespondeaBonoModernizacion.Checked
        item.esImponibleMesHistorico = chkEsImponibleMesHistorico.Checked
        item.esTributableMesHistorico = chkEsTributableMesHistorico.Checked
        item.traspasaDiferenciaMovtoMensual = chkTraspasaDiferenciaMovtoMensual.Checked
        If item.esCalculable = chkEsCalculable.Checked = False Then
            item.nombreCeldaExcel = ""
        Else
            item.nombreCeldaExcel = txtNombreCeldaExcel.Text
        End If
        If txtCodigoAplicacionExterna.Text = "" Then
            item.codigoAplicacionExterna = -1
        Else
            item.codigoAplicacionExterna = CType(txtCodigoAplicacionExterna.Text, Integer)
        End If
        If txtCodigoItemExterno.Text = "" Then
            item.codigoItemExterno = 0
        Else
            item.codigoItemExterno = CType(txtCodigoItemExterno.Text, Integer)
        End If
        If chkEsAfectoAtrasoInsistencia.Checked Then
            item.esAtrasoInasistencia = True
        Else
            item.esAtrasoInasistencia = False
        End If
        item.nombreProcedencia = txtProcedencia.Text
        item.esAtrasoInasistencia = chkEsAfectoAtrasoInsistencia.Checked
        item.esCostoPresupuesto = chkEsCostoPresupuesto.EditValue
        item.esAplicableAHonorario = chkEsAplicadoAHonorario.EditValue
        item.permiteGeneracionMasiva = chkPermiteGeneracionMasiva.EditValue
    End Sub
    Private Sub gdvItemes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gdvItemes.DoubleClick
        'Traspasa desde la grilla a hacia los controles
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        item.Id = view.GetRowCellValue(view.FocusedRowHandle, "ITEM_ID")
        rdgTipoItem.SelectedIndex = view.GetRowCellValue(view.FocusedRowHandle, "TIPO_ITEM")
        txtItemAlias.Text = view.GetRowCellValue(view.FocusedRowHandle, "ITEM_ALIAS")
        txtDescripcionLarga.Text = view.GetRowCellValue(view.FocusedRowHandle, "DESCRIPCION_LARGA")
        txtDescripcionCorta.Text = view.GetRowCellValue(view.FocusedRowHandle, "DESCRIPCION_CORTA")

        If view.GetRowCellValue(view.FocusedRowHandle, "ES_IMPONIBLE") Then
            chkEsImponible.Checked = True
        Else
            chkEsImponible.Checked = False
        End If

        If view.GetRowCellValue(view.FocusedRowHandle, "ES_TRIBUTABLE") Then
            chkEsTributable.Checked = True
        Else
            chkEsTributable.Checked = False
        End If

        If view.GetRowCellValue(view.FocusedRowHandle, "ES_CALCULABLE") Then
            chkEsCalculable.Checked = True
        Else
            chkEsCalculable.Checked = False
        End If

        If view.GetRowCellValue(view.FocusedRowHandle, "ES_COSTO") Then
            chkEsCosto.Checked = True
        Else
            chkEsCosto.Checked = False
        End If

        txtSecuenciaImpresion.Text = view.GetRowCellValue(view.FocusedRowHandle, "SECUENCIA_IMPRESION")
        If view.GetRowCellValue(view.FocusedRowHandle, "ES_PERMANENTE") Then
            chkEsPermanente.Checked = True
        Else
            chkEsPermanente.Checked = False
        End If
        If view.GetRowCellValue(view.FocusedRowHandle, "ES_IMPRIMIBLE_EN_LIQUIDACION") Then
            chkEsImprimible.Checked = True
        Else
            chkEsImprimible.Checked = False
        End If
        If view.GetRowCellValue(view.FocusedRowHandle, "ESTADO_REGISTRO") Then
            chkEstadoRegistro.Checked = True
        Else
            chkEstadoRegistro.Checked = False
        End If
        If view.GetRowCellValue(view.FocusedRowHandle, "ES_PROPORCIONAL_DIAS_TRABAJADOS") Then
            chkProporcinalDiasTrabajados.Checked = True
        Else
            chkProporcinalDiasTrabajados.Checked = False
        End If
        If view.GetRowCellValue(view.FocusedRowHandle, "ES_RELIQUIDACION_BONO") Then
            chkCorrespondeaBonoModernizacion.Checked = True
        Else
            chkCorrespondeaBonoModernizacion.Checked = False
        End If
        If view.GetRowCellValue(view.FocusedRowHandle, "ES_IMPONIBLE_MES_HISTORICO") Then
            chkEsImponibleMesHistorico.Checked = True
        Else
            chkEsImponibleMesHistorico.Checked = False
        End If
        If view.GetRowCellValue(view.FocusedRowHandle, "ES_TRIBUTABLE_MES_HISTORICO") Then
            chkEsTributableMesHistorico.Checked = True
        Else
            chkEsTributableMesHistorico.Checked = False
        End If
        If view.GetRowCellValue(view.FocusedRowHandle, "TRASPASA_DIFERENCIA_MOVTO_MENSUAL") Then
            chkTraspasaDiferenciaMovtoMensual.Checked = True
        Else
            chkTraspasaDiferenciaMovtoMensual.Checked = False
        End If
        txtNombreCeldaExcel.Text = view.GetRowCellValue(view.FocusedRowHandle, "CELDA_CALCULO")
        Try
            txtCodigoItemExterno.Text = view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_EXTERNO")
        Catch ex As Exception
            txtCodigoItemExterno.Text = ""
        End Try
        txtProcedencia.Text = view.GetRowCellValue(view.FocusedRowHandle, "APLICACION")
        Try
            txtCodigoAplicacionExterna.Text = view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_APLICACION")
        Catch ex As Exception
            txtCodigoAplicacionExterna.Text = ""
        End Try

        If view.GetRowCellValue(view.FocusedRowHandle, "ES_ITEM_BIENESTAR") Then
            chkEsItemBienestar.Checked = True
        Else
            chkEsItemBienestar.Checked = False
        End If

        If item.Id > 0 Then
            btnGuardar.Enabled = True
            btnEliminar.Enabled = True
            lycDefinicionItem.Enabled = True
            gpcDefinicionItem.Enabled = True
            gpcCentralizacionContable.Enabled = True
        Else
            lycDefinicionItem.Enabled = False
            gpcDefinicionItem.Enabled = False
            gpcCentralizacionContable.Enabled = False
        End If

        If view.GetRowCellValue(view.FocusedRowHandle, "ES_ATRASO_INASISTENCIA") Then
            chkEsAfectoAtrasoInsistencia.Checked = True
        Else
            chkEsAfectoAtrasoInsistencia.Checked = False
        End If

        If view.GetRowCellValue(view.FocusedRowHandle, "ES_APLICABLE_HONORARIO") Then
            chkEsAplicadoAHonorario.Checked = True
        Else
            chkEsAplicadoAHonorario.Checked = False
        End If

        If view.GetRowCellValue(view.FocusedRowHandle, "ES_COSTO_PRESUP") Then
            chkEsCostoPresupuesto.Checked = True
        Else
            chkEsCostoPresupuesto.Checked = False
        End If

        If view.GetRowCellValue(view.FocusedRowHandle, "PERMITE_GENERACION_MASIVA") Then
            chkPermiteGeneracionMasiva.Checked = True
        Else
            chkPermiteGeneracionMasiva.Checked = False
        End If

        'Buscar item en tabla centralización
        If item.Id > 0 Then
            gdcCentralizacion.DataSource = item.recuperaItemesCentralizacion(item.Id, periodo.ID)
        End If

    End Sub
    Private Sub seteaDefault()
        rdgTipoItem.SelectedIndex = 2
        txtItemAlias.Text = ""
        txtDescripcionLarga.Text = ""
        txtDescripcionCorta.Text = ""
        txtSecuenciaImpresion.Text = ""
        chkEsImponible.Checked = False
        chkEsCalculable.Checked = False
        chkEsPermanente.Checked = False
        chkEsTributable.Checked = False
        chkEsCosto.Checked = False
        chkEsImprimible.Checked = False
        chkEstadoRegistro.Checked = False
        chkProporcinalDiasTrabajados.Checked = False
        chkCorrespondeaBonoModernizacion.Checked = False
        chkEsImponibleMesHistorico.Checked = False
        chkEsTributableMesHistorico.Checked = False
        chkTraspasaDiferenciaMovtoMensual.Checked = False
        chkEsItemBienestar.Checked = False
        txtNombreCeldaExcel.Text = ""
        txtCodigoItemExterno.Text = ""
        txtProcedencia.Text = ""
        txtCodigoAplicacionExterna.Text = Nothing
        chkEsAfectoAtrasoInsistencia.Checked = False
        chkEsCostoPresupuesto.Checked = False
        chkEsAplicadoAHonorario.Checked = False
        chkPermiteGeneracionMasiva.Checked = False
    End Sub
    Private Sub inicializaConatroles()
        rdgTipoItem.SelectedIndex = -1
        txtItemAlias.Text = ""
        txtDescripcionLarga.Text = ""
        txtDescripcionCorta.Text = ""
        txtSecuenciaImpresion.Text = ""
        chkEsImponible.Checked = False
        chkEsCalculable.Checked = False
        chkEsPermanente.Checked = False
        chkEsTributable.Checked = False
        chkEsCosto.Checked = False
        chkEsImprimible.Checked = False
        chkEstadoRegistro.Checked = False
        chkEsItemBienestar.Checked = False
        btnGuardar.Enabled = False
        btnEliminar.Enabled = False
        chkEsAfectoAtrasoInsistencia.Checked = False
        chkEsCostoPresupuesto.Checked = False
        chkEsAplicadoAHonorario.Checked = False
        chkPermiteGeneracionMasiva.Checked = False
    End Sub
    Private Function validaciones() As Boolean
        Dim respuesta As Boolean = True
        If txtItemAlias.Text = "" Then
            MsgBox("No ha ingresado código haber o descuento", MsgBoxStyle.Exclamation)
            respuesta = False
        End If
        If txtDescripcionLarga.Text = "" Then
            MsgBox("No ha ingresado la descripción larga del ítem", MsgBoxStyle.Exclamation)
            respuesta = False
        End If
        If txtDescripcionCorta.Text = "" Then
            MsgBox("No ha ingresado la descripción corta del ítem", MsgBoxStyle.Exclamation)
            respuesta = False
        End If
        Return respuesta
    End Function
    Private Sub txtItemAlias_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtItemAlias.Validating
        Dim codigo As String
        codigo = "'" & UCase(txtItemAlias.Text) & "'"
        If DataAccess.Utiles.buscaID(Tablas.RH_REM_ITEM, "NN", "ITEM_ALIAS", codigo, "ITEM_ID") > 0 Then
            MsgBox("Ya existe código de ítem", MsgBoxStyle.Exclamation)
            e.Cancel = True
        End If
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        EliminaItem(item.Id, txtItemAlias.Text)
    End Sub

    Private Sub gdvItemes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvItemes.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
            Dim valor_id As Integer
            Dim codigo As String
            valor_id = view.GetRowCellValue(view.FocusedRowHandle, view.Columns(0))
            codigo = view.GetRowCellValue(view.FocusedRowHandle, view.Columns(2))
            EliminaItem(valor_id, codigo)
        End If
    End Sub
    Private Sub EliminaItem(ByVal idItem As Integer, ByVal CodigoItem As String)
        If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
            Try
                If item.Eliminar(idItem) = True Then
                    gdcItem.DataSource = item.dvDatosItemes()
                    inicializaConatroles()
                    MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Registro no pudo ser eliminado", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al intentar eliminar el ítem " & CodigoItem & ". ERROR : " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub gdvDetalleCentralizacion_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvDetalleCentralizacion.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gdvDetalleCentralizacion_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvDetalleCentralizacion.RowUpdated
        If item.actualizarItemesCentralizacion() Then
            gdcCentralizacion.Refresh()
        End If
    End Sub

    Private Sub gdvDetalleCentralizacion_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvDetalleCentralizacion.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        view.SetRowCellValue(e.RowHandle, "ITEM_ID", CType(item.Id, Integer))
        view.SetRowCellValue(e.RowHandle, "PERIODO_ID", CType(periodo.ID, Integer))
        view.SetRowCellValue(e.RowHandle, "ESTADO_REGISTRO", 1)
        view.SetRowCellValue(e.RowHandle, "IMPUTACION_ID", 1)
        view.SetRowCellValue(e.RowHandle, "CUENTA_CONTABLE", "")
        view.SetRowCellValue(e.RowHandle, "CUENTA_PRESUPUESTO", "")
        view.SetRowCellValue(e.RowHandle, "GLOSA", txtDescripcionLarga.Text)
    End Sub

    Private Sub gdvDetalleCentralizacion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvDetalleCentralizacion.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                view.DeleteRow(view.FocusedRowHandle)
                Try
                    item.actualizarItemesCentralizacion()
                    MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al intentar eliminar el registro " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
        End If
    End Sub

    Private Sub gdvDetalleCentralizacion_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gdvDetalleCentralizacion.ValidateRow
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        Dim respuesta As Boolean = True
        If view.GetRowCellValue(view.FocusedRowHandle, view.Columns("CALIDAD_JURIDICA_ID")) = Nothing Then
            respuesta = False
        End If
        If view.GetRowCellValue(view.FocusedRowHandle, view.Columns("IMPUTACION_ID")) = Nothing Then
            respuesta = False
        End If
        If view.GetRowCellValue(view.FocusedRowHandle, view.Columns("CUENTA_CONTABLE")) = "" Then
            respuesta = False
        End If
        If view.GetRowCellValue(view.FocusedRowHandle, view.Columns("CUENTA_PRESUPUESTO")) = "" Then
            respuesta = False
        End If

        If Not respuesta Then
            MsgBox("Faltan campos por completar en el detalle de la centralización", MsgBoxStyle.Information)
            e.Valid = False
        End If
    End Sub

End Class
