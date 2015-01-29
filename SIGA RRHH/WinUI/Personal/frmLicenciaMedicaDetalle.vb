Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Reportes
Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns

Public Class frmLicenciaMedicaDetalle
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
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblRut As System.Windows.Forms.Label
    Friend WithEvents lueTipoLicencia As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dteFechaRecepcion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lycDatosLicenciaMedica As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents dteFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDiasLicencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dteFechaTerminoLicencia As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents rdgLugarReposo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lycLugarReposo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycTipoDia As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rdgContinuidad As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents gdcLicenciasMedicas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gdvDetalleLicenciasMedicas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dteFechaTerminoContinuidad As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteFechaInicioContinuidad As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDiasContinuidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblEstadoLicenciaMedica As System.Windows.Forms.Label
    Friend WithEvents btnDetalldelPago As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRentaUltimosTresMeses As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lycReposo As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents dteFechaEnvIsapre As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteFechaConcepcion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents rdgEstadoLicencia As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtNumeroLicenciaContinuidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dteFechaAccidente As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LICENCIA_MEDICA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PERIODO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TIPO_LICENCIA_MEDICA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_INICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIAS_LICENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_TERMINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NUMERO_LICENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_RECEPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_ACCIDENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_EMISION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TIPO_REPOSO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LUGAR_REPOSO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_ENVIO_ISAPRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CONTINUIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NUMERO_LICENCIA_CONTINUIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_INICIO_CONTINUIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIAS_CONTINUIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_TERMINO_CONTINUIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_CONCEPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents txtPeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rdgTipoReposo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lycFechasVarias As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents lycLicenciaMedicaContinuidad As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents rluTipoLicencia As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rdgEstadoLicenciaMedica As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents lycDatosDoctor As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ESTADO_LICENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNombreDoctor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEspecialidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NOMBRE_DOCTOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ESPECIALIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNumeroLicencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NUMERO_CHEQUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MONTO_CHEQUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MEMORANDUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OBSERVACIONES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_DIGITACION_PAGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gpcNombreEmpleado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PERIODO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNombreEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gleRut As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gleRutGrid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RENTA_PROMEDIO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dteFechaRecepIsapre As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lycTipoClasificacion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rdgClasificacion As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents FECHA_RECEPCION_ISAPRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NUMERO_FILIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLASIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lycTipoLicencia As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycInicioLicencia As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDiasReduccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lycDiasReduccion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcgLicenciaContinuidad As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lycContinuidadLicencia As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycNumeroLicenciaContinuidad As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycFechaInicioContinuidad As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycDiasContinuidad As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycTerminoContinuidad As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycFechaAccidente As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycFechaConcepcion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycFechaRecepcionIsapre As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciNumeroFolio As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNumeroFolio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rdgTipoProfesional As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lciTipoProfesional As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycFechaRecepcion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycFechaTerminoLicencia As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lueCausaRechazo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lciCausaRechazo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dteFechaEstimadaPago As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lciFechaEstimadaPago As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciFechaEnvioIsapre As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciNombreDoctor As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciEspecialidad As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciFechaInicioLicencia As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciNumeroLicencia As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciDiasLicencia As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colFECHA_ESTIMADA_PAGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCAUSA_RECHAZO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_PROFESIONAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIAS_REDUCCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_SUBSIDIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOTIZACION_PREVISIONAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOTIZACION_SALUD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIAS_PAGADOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIAS_PREV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gpcBotones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtMonto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.ESTADO_LICENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rdgEstadoLicenciaMedica = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.txtNombreEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gpcNombreEmpleado = New DevExpress.XtraEditors.GroupControl()
        Me.gleRut = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gleRutGrid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rdgEstadoLicencia = New DevExpress.XtraEditors.RadioGroup()
        Me.txtPeriodo = New DevExpress.XtraEditors.TextEdit()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.lblEstadoLicenciaMedica = New System.Windows.Forms.Label()
        Me.lycLicenciaMedicaContinuidad = New DevExpress.XtraLayout.LayoutControl()
        Me.dteFechaTerminoContinuidad = New DevExpress.XtraEditors.DateEdit()
        Me.dteFechaInicioContinuidad = New DevExpress.XtraEditors.DateEdit()
        Me.txtNumeroLicenciaContinuidad = New DevExpress.XtraEditors.TextEdit()
        Me.rdgContinuidad = New DevExpress.XtraEditors.RadioGroup()
        Me.txtDiasContinuidad = New DevExpress.XtraEditors.TextEdit()
        Me.lcgLicenciaContinuidad = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lycContinuidadLicencia = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycNumeroLicenciaContinuidad = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycFechaInicioContinuidad = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycDiasContinuidad = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycTerminoContinuidad = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lueTipoLicencia = New DevExpress.XtraEditors.LookUpEdit()
        Me.lycDatosLicenciaMedica = New DevExpress.XtraLayout.LayoutControl()
        Me.lueCausaRechazo = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDiasReduccion = New DevExpress.XtraEditors.TextEdit()
        Me.txtNumeroLicencia = New DevExpress.XtraEditors.TextEdit()
        Me.dteFechaTerminoLicencia = New DevExpress.XtraEditors.DateEdit()
        Me.dteFechaRecepcion = New DevExpress.XtraEditors.DateEdit()
        Me.dteFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.txtDiasLicencia = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lycTipoLicencia = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycInicioLicencia = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycDiasReduccion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciNumeroLicencia = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycFechaRecepcion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciDiasLicencia = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycFechaTerminoLicencia = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciCausaRechazo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycReposo = New DevExpress.XtraLayout.LayoutControl()
        Me.rdgClasificacion = New DevExpress.XtraEditors.RadioGroup()
        Me.rdgTipoReposo = New DevExpress.XtraEditors.RadioGroup()
        Me.rdgLugarReposo = New DevExpress.XtraEditors.RadioGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lycLugarReposo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycTipoDia = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycTipoClasificacion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycFechasVarias = New DevExpress.XtraLayout.LayoutControl()
        Me.txtNumeroFolio = New DevExpress.XtraEditors.TextEdit()
        Me.dteFechaRecepIsapre = New DevExpress.XtraEditors.DateEdit()
        Me.dteFechaEnvIsapre = New DevExpress.XtraEditors.DateEdit()
        Me.dteFechaConcepcion = New DevExpress.XtraEditors.DateEdit()
        Me.dteFechaEstimadaPago = New DevExpress.XtraEditors.DateEdit()
        Me.dteFechaAccidente = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lycFechaAccidente = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciFechaEstimadaPago = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycFechaConcepcion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciFechaEnvioIsapre = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycFechaRecepcionIsapre = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciNumeroFolio = New DevExpress.XtraLayout.LayoutControlItem()
        Me.gdcLicenciasMedicas = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleLicenciasMedicas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LICENCIA_MEDICA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PERIODO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TIPO_LICENCIA_MEDICA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rluTipoLicencia = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_INICIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIAS_LICENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_TERMINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NUMERO_LICENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_RECEPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_ACCIDENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_EMISION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TIPO_REPOSO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LUGAR_REPOSO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_ENVIO_ISAPRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CONTINUIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NUMERO_LICENCIA_CONTINUIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_INICIO_CONTINUIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIAS_CONTINUIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_TERMINO_CONTINUIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_CONCEPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NOMBRE_DOCTOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ESPECIALIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NUMERO_CHEQUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MONTO_CHEQUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MEMORANDUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OBSERVACIONES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_DIGITACION_PAGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PERIODO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RENTA_PROMEDIO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_RECEPCION_ISAPRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NUMERO_FILIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDIAS_REDUCCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLASIFICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_ESTIMADA_PAGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCAUSA_RECHAZO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPO_PROFESIONAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_SUBSIDIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMonto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colCOTIZACION_PREVISIONAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOTIZACION_SALUD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDIAS_PAGADOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDIAS_PREV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnDetalldelPago = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRentaUltimosTresMeses = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.lycDatosDoctor = New DevExpress.XtraLayout.LayoutControl()
        Me.rdgTipoProfesional = New DevExpress.XtraEditors.RadioGroup()
        Me.txtEspecialidad = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreDoctor = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciNombreDoctor = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciEspecialidad = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciTipoProfesional = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciFechaInicioLicencia = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.gpcBotones = New DevExpress.XtraEditors.GroupControl()
        CType(Me.rdgEstadoLicenciaMedica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcNombreEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcNombreEmpleado.SuspendLayout()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleRutGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgEstadoLicencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycLicenciaMedicaContinuidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycLicenciaMedicaContinuidad.SuspendLayout()
        CType(Me.dteFechaTerminoContinuidad.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaTerminoContinuidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaInicioContinuidad.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaInicioContinuidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroLicenciaContinuidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgContinuidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiasContinuidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgLicenciaContinuidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycContinuidadLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycNumeroLicenciaContinuidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycFechaInicioContinuidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycDiasContinuidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycTerminoContinuidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTipoLicencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycDatosLicenciaMedica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycDatosLicenciaMedica.SuspendLayout()
        CType(Me.lueCausaRechazo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiasReduccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroLicencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaTerminoLicencia.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaTerminoLicencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaRecepcion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaRecepcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiasLicencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycTipoLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycInicioLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycDiasReduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciNumeroLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycFechaRecepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciDiasLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycFechaTerminoLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciCausaRechazo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycReposo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycReposo.SuspendLayout()
        CType(Me.rdgClasificacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgTipoReposo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgLugarReposo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycLugarReposo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycTipoDia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycTipoClasificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycFechasVarias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycFechasVarias.SuspendLayout()
        CType(Me.txtNumeroFolio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaRecepIsapre.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaRecepIsapre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaEnvIsapre.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaEnvIsapre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaConcepcion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaConcepcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaEstimadaPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaEstimadaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaAccidente.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaAccidente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycFechaAccidente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciFechaEstimadaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycFechaConcepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciFechaEnvioIsapre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycFechaRecepcionIsapre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciNumeroFolio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcLicenciasMedicas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleLicenciasMedicas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rluTipoLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycDatosDoctor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycDatosDoctor.SuspendLayout()
        CType(Me.rdgTipoProfesional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEspecialidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreDoctor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciNombreDoctor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEspecialidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciTipoProfesional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciFechaInicioLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'ESTADO_LICENCIA
        '
        Me.ESTADO_LICENCIA.Caption = "Estado Licencia"
        Me.ESTADO_LICENCIA.ColumnEdit = Me.rdgEstadoLicenciaMedica
        Me.ESTADO_LICENCIA.FieldName = "ESTADO_LICENCIA"
        Me.ESTADO_LICENCIA.Name = "ESTADO_LICENCIA"
        Me.ESTADO_LICENCIA.OptionsColumn.AllowEdit = False
        Me.ESTADO_LICENCIA.OptionsFilter.AllowAutoFilter = False
        Me.ESTADO_LICENCIA.Width = 106
        '
        'rdgEstadoLicenciaMedica
        '
        Me.rdgEstadoLicenciaMedica.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Pendiente"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Pagada")})
        Me.rdgEstadoLicenciaMedica.Name = "rdgEstadoLicenciaMedica"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Enabled = False
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(232, 24)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreEmpleado.Properties.MaxLength = 30
        Me.txtNombreEmpleado.Properties.ReadOnly = True
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(392, 20)
        Me.txtNombreEmpleado.TabIndex = 4
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'gpcNombreEmpleado
        '
        Me.gpcNombreEmpleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcNombreEmpleado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcNombreEmpleado.AppearanceCaption.Options.UseFont = True
        Me.gpcNombreEmpleado.Controls.Add(Me.gleRut)
        Me.gpcNombreEmpleado.Controls.Add(Me.rdgEstadoLicencia)
        Me.gpcNombreEmpleado.Controls.Add(Me.txtPeriodo)
        Me.gpcNombreEmpleado.Controls.Add(Me.lblPeriodo)
        Me.gpcNombreEmpleado.Controls.Add(Me.lblRut)
        Me.gpcNombreEmpleado.Controls.Add(Me.txtNombreEmpleado)
        Me.gpcNombreEmpleado.Controls.Add(Me.lblEstadoLicenciaMedica)
        Me.gpcNombreEmpleado.Controls.Add(Me.lycLicenciaMedicaContinuidad)
        Me.gpcNombreEmpleado.Location = New System.Drawing.Point(2, 3)
        Me.gpcNombreEmpleado.Name = "gpcNombreEmpleado"
        Me.gpcNombreEmpleado.Size = New System.Drawing.Size(853, 99)
        Me.gpcNombreEmpleado.TabIndex = 55
        Me.gpcNombreEmpleado.Text = "Nombre Empleado"
        '
        'gleRut
        '
        Me.gleRut.Cursor = System.Windows.Forms.Cursors.Default
        Me.gleRut.EditValue = ""
        Me.gleRut.EnterMoveNextControl = True
        Me.gleRut.Location = New System.Drawing.Point(104, 24)
        Me.gleRut.Name = "gleRut"
        Me.gleRut.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.gleRut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleRut.Properties.HideSelection = False
        Me.gleRut.Properties.NullText = ""
        Me.gleRut.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.gleRut.Properties.ValidateOnEnterKey = True
        Me.gleRut.Properties.View = Me.gleRutGrid
        Me.gleRut.Size = New System.Drawing.Size(120, 20)
        Me.gleRut.TabIndex = 0
        '
        'gleRutGrid
        '
        Me.gleRutGrid.AppearancePrint.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gleRutGrid.AppearancePrint.OddRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gleRutGrid.AppearancePrint.OddRow.Options.UseBackColor = True
        Me.gleRutGrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gleRutGrid.Name = "gleRutGrid"
        Me.gleRutGrid.OptionsBehavior.Editable = False
        Me.gleRutGrid.OptionsCustomization.AllowFilter = False
        Me.gleRutGrid.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gleRutGrid.OptionsView.ShowGroupPanel = False
        '
        'rdgEstadoLicencia
        '
        Me.rdgEstadoLicencia.EditValue = 0
        Me.rdgEstadoLicencia.Location = New System.Drawing.Point(144, 56)
        Me.rdgEstadoLicencia.Name = "rdgEstadoLicencia"
        Me.rdgEstadoLicencia.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Pendiente"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Pagada"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Rechazada"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Reducida"), New DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Autorizada")})
        Me.rdgEstadoLicencia.Size = New System.Drawing.Size(408, 32)
        Me.rdgEstadoLicencia.TabIndex = 6
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Location = New System.Drawing.Point(720, 64)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Properties.ReadOnly = True
        Me.txtPeriodo.Size = New System.Drawing.Size(88, 20)
        Me.txtPeriodo.TabIndex = 8
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(608, 64)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(104, 16)
        Me.lblPeriodo.TabIndex = 7
        Me.lblPeriodo.Text = "Periodo (aaaa-mm)"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRut
        '
        Me.lblRut.Location = New System.Drawing.Point(16, 28)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(80, 16)
        Me.lblRut.TabIndex = 1
        Me.lblRut.Text = "Rut Empleado"
        Me.lblRut.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEstadoLicenciaMedica
        '
        Me.lblEstadoLicenciaMedica.Location = New System.Drawing.Point(8, 64)
        Me.lblEstadoLicenciaMedica.Name = "lblEstadoLicenciaMedica"
        Me.lblEstadoLicenciaMedica.Size = New System.Drawing.Size(128, 16)
        Me.lblEstadoLicenciaMedica.TabIndex = 5
        Me.lblEstadoLicenciaMedica.Text = "Estado Licencia Médica"
        Me.lblEstadoLicenciaMedica.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lycLicenciaMedicaContinuidad
        '
        Me.lycLicenciaMedicaContinuidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lycLicenciaMedicaContinuidad.Controls.Add(Me.dteFechaTerminoContinuidad)
        Me.lycLicenciaMedicaContinuidad.Controls.Add(Me.dteFechaInicioContinuidad)
        Me.lycLicenciaMedicaContinuidad.Controls.Add(Me.txtNumeroLicenciaContinuidad)
        Me.lycLicenciaMedicaContinuidad.Controls.Add(Me.rdgContinuidad)
        Me.lycLicenciaMedicaContinuidad.Controls.Add(Me.txtDiasContinuidad)
        Me.lycLicenciaMedicaContinuidad.Location = New System.Drawing.Point(672, 24)
        Me.lycLicenciaMedicaContinuidad.Name = "lycLicenciaMedicaContinuidad"
        Me.lycLicenciaMedicaContinuidad.OptionsView.AllowHotTrack = True
        Me.lycLicenciaMedicaContinuidad.Root = Me.lcgLicenciaContinuidad
        Me.lycLicenciaMedicaContinuidad.Size = New System.Drawing.Size(141, 32)
        Me.lycLicenciaMedicaContinuidad.TabIndex = 0
        Me.lycLicenciaMedicaContinuidad.Text = "LayoutControl2"
        Me.lycLicenciaMedicaContinuidad.Visible = False
        '
        'dteFechaTerminoContinuidad
        '
        Me.dteFechaTerminoContinuidad.EditValue = Nothing
        Me.dteFechaTerminoContinuidad.Location = New System.Drawing.Point(106, 151)
        Me.dteFechaTerminoContinuidad.Name = "dteFechaTerminoContinuidad"
        Me.dteFechaTerminoContinuidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaTerminoContinuidad.Properties.ReadOnly = True
        Me.dteFechaTerminoContinuidad.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteFechaTerminoContinuidad.Size = New System.Drawing.Size(50, 20)
        Me.dteFechaTerminoContinuidad.StyleController = Me.lycLicenciaMedicaContinuidad
        Me.dteFechaTerminoContinuidad.TabIndex = 17
        '
        'dteFechaInicioContinuidad
        '
        Me.dteFechaInicioContinuidad.EditValue = Nothing
        Me.dteFechaInicioContinuidad.Location = New System.Drawing.Point(106, 91)
        Me.dteFechaInicioContinuidad.Name = "dteFechaInicioContinuidad"
        Me.dteFechaInicioContinuidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaInicioContinuidad.Properties.ReadOnly = True
        Me.dteFechaInicioContinuidad.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteFechaInicioContinuidad.Size = New System.Drawing.Size(50, 20)
        Me.dteFechaInicioContinuidad.StyleController = Me.lycLicenciaMedicaContinuidad
        Me.dteFechaInicioContinuidad.TabIndex = 15
        '
        'txtNumeroLicenciaContinuidad
        '
        Me.txtNumeroLicenciaContinuidad.EnterMoveNextControl = True
        Me.txtNumeroLicenciaContinuidad.Location = New System.Drawing.Point(106, 61)
        Me.txtNumeroLicenciaContinuidad.Name = "txtNumeroLicenciaContinuidad"
        Me.txtNumeroLicenciaContinuidad.Properties.DisplayFormat.FormatString = "n0"
        Me.txtNumeroLicenciaContinuidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNumeroLicenciaContinuidad.Properties.EditFormat.FormatString = "n0"
        Me.txtNumeroLicenciaContinuidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNumeroLicenciaContinuidad.Properties.Mask.EditMask = "n0"
        Me.txtNumeroLicenciaContinuidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumeroLicenciaContinuidad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNumeroLicenciaContinuidad.Size = New System.Drawing.Size(50, 20)
        Me.txtNumeroLicenciaContinuidad.StyleController = Me.lycLicenciaMedicaContinuidad
        Me.txtNumeroLicenciaContinuidad.TabIndex = 14
        '
        'rdgContinuidad
        '
        Me.rdgContinuidad.Location = New System.Drawing.Point(106, 26)
        Me.rdgContinuidad.Name = "rdgContinuidad"
        Me.rdgContinuidad.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Si"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "No")})
        Me.rdgContinuidad.Size = New System.Drawing.Size(50, 25)
        Me.rdgContinuidad.StyleController = Me.lycLicenciaMedicaContinuidad
        Me.rdgContinuidad.TabIndex = 13
        '
        'txtDiasContinuidad
        '
        Me.txtDiasContinuidad.Location = New System.Drawing.Point(106, 121)
        Me.txtDiasContinuidad.Name = "txtDiasContinuidad"
        Me.txtDiasContinuidad.Properties.ReadOnly = True
        Me.txtDiasContinuidad.Size = New System.Drawing.Size(50, 20)
        Me.txtDiasContinuidad.StyleController = Me.lycLicenciaMedicaContinuidad
        Me.txtDiasContinuidad.TabIndex = 16
        '
        'lcgLicenciaContinuidad
        '
        Me.lcgLicenciaContinuidad.CustomizationFormText = "lcgLicenciaMedica3"
        Me.lcgLicenciaContinuidad.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lycContinuidadLicencia, Me.lycNumeroLicenciaContinuidad, Me.lycFechaInicioContinuidad, Me.lycDiasContinuidad, Me.lycTerminoContinuidad})
        Me.lcgLicenciaContinuidad.Location = New System.Drawing.Point(0, 0)
        Me.lcgLicenciaContinuidad.Name = "lcgLicenciaContinuidad"
        Me.lcgLicenciaContinuidad.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lcgLicenciaContinuidad.Size = New System.Drawing.Size(162, 177)
        Me.lcgLicenciaContinuidad.Text = "lcgLicenciaMedica3"
        '
        'lycContinuidadLicencia
        '
        Me.lycContinuidadLicencia.Control = Me.rdgContinuidad
        Me.lycContinuidadLicencia.CustomizationFormText = "Continuidad Licencia"
        Me.lycContinuidadLicencia.Location = New System.Drawing.Point(0, 0)
        Me.lycContinuidadLicencia.Name = "lycContinuidadLicencia"
        Me.lycContinuidadLicencia.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lycContinuidadLicencia.Size = New System.Drawing.Size(160, 35)
        Me.lycContinuidadLicencia.Text = "Continuidad Licencia"
        Me.lycContinuidadLicencia.TextSize = New System.Drawing.Size(97, 13)
        '
        'lycNumeroLicenciaContinuidad
        '
        Me.lycNumeroLicenciaContinuidad.Control = Me.txtNumeroLicenciaContinuidad
        Me.lycNumeroLicenciaContinuidad.CustomizationFormText = "Licencia Continuidad"
        Me.lycNumeroLicenciaContinuidad.Location = New System.Drawing.Point(0, 35)
        Me.lycNumeroLicenciaContinuidad.Name = "lycNumeroLicenciaContinuidad"
        Me.lycNumeroLicenciaContinuidad.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lycNumeroLicenciaContinuidad.Size = New System.Drawing.Size(160, 30)
        Me.lycNumeroLicenciaContinuidad.Text = "Licencia Continuidad"
        Me.lycNumeroLicenciaContinuidad.TextSize = New System.Drawing.Size(97, 13)
        '
        'lycFechaInicioContinuidad
        '
        Me.lycFechaInicioContinuidad.Control = Me.dteFechaInicioContinuidad
        Me.lycFechaInicioContinuidad.CustomizationFormText = "Fecha Inicio"
        Me.lycFechaInicioContinuidad.Location = New System.Drawing.Point(0, 65)
        Me.lycFechaInicioContinuidad.Name = "lycFechaInicioContinuidad"
        Me.lycFechaInicioContinuidad.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lycFechaInicioContinuidad.Size = New System.Drawing.Size(160, 30)
        Me.lycFechaInicioContinuidad.Text = "Fecha Inicio"
        Me.lycFechaInicioContinuidad.TextSize = New System.Drawing.Size(97, 13)
        '
        'lycDiasContinuidad
        '
        Me.lycDiasContinuidad.Control = Me.txtDiasContinuidad
        Me.lycDiasContinuidad.CustomizationFormText = "Días Continuidad"
        Me.lycDiasContinuidad.Location = New System.Drawing.Point(0, 95)
        Me.lycDiasContinuidad.Name = "lycDiasContinuidad"
        Me.lycDiasContinuidad.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lycDiasContinuidad.Size = New System.Drawing.Size(160, 30)
        Me.lycDiasContinuidad.Text = "Días Continuidad"
        Me.lycDiasContinuidad.TextSize = New System.Drawing.Size(97, 13)
        '
        'lycTerminoContinuidad
        '
        Me.lycTerminoContinuidad.Control = Me.dteFechaTerminoContinuidad
        Me.lycTerminoContinuidad.CustomizationFormText = "Fecha Término"
        Me.lycTerminoContinuidad.Location = New System.Drawing.Point(0, 125)
        Me.lycTerminoContinuidad.Name = "lycTerminoContinuidad"
        Me.lycTerminoContinuidad.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lycTerminoContinuidad.Size = New System.Drawing.Size(160, 30)
        Me.lycTerminoContinuidad.Text = "Fecha Término"
        Me.lycTerminoContinuidad.TextSize = New System.Drawing.Size(97, 13)
        '
        'lueTipoLicencia
        '
        Me.lueTipoLicencia.EnterMoveNextControl = True
        Me.lueTipoLicencia.Location = New System.Drawing.Point(6, 22)
        Me.lueTipoLicencia.Name = "lueTipoLicencia"
        Me.lueTipoLicencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTipoLicencia.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.lueTipoLicencia.Size = New System.Drawing.Size(315, 20)
        Me.lueTipoLicencia.StyleController = Me.lycDatosLicenciaMedica
        Me.lueTipoLicencia.TabIndex = 1
        '
        'lycDatosLicenciaMedica
        '
        Me.lycDatosLicenciaMedica.Controls.Add(Me.lueCausaRechazo)
        Me.lycDatosLicenciaMedica.Controls.Add(Me.txtDiasReduccion)
        Me.lycDatosLicenciaMedica.Controls.Add(Me.txtNumeroLicencia)
        Me.lycDatosLicenciaMedica.Controls.Add(Me.dteFechaTerminoLicencia)
        Me.lycDatosLicenciaMedica.Controls.Add(Me.lueTipoLicencia)
        Me.lycDatosLicenciaMedica.Controls.Add(Me.dteFechaRecepcion)
        Me.lycDatosLicenciaMedica.Controls.Add(Me.dteFechaInicio)
        Me.lycDatosLicenciaMedica.Controls.Add(Me.txtDiasLicencia)
        Me.lycDatosLicenciaMedica.Location = New System.Drawing.Point(1, 104)
        Me.lycDatosLicenciaMedica.Name = "lycDatosLicenciaMedica"
        Me.lycDatosLicenciaMedica.OptionsView.AllowHotTrack = True
        Me.lycDatosLicenciaMedica.Root = Me.LayoutControlGroup1
        Me.lycDatosLicenciaMedica.Size = New System.Drawing.Size(327, 272)
        Me.lycDatosLicenciaMedica.TabIndex = 58
        Me.lycDatosLicenciaMedica.Text = "Datos Licencia Médica"
        '
        'lueCausaRechazo
        '
        Me.lueCausaRechazo.Location = New System.Drawing.Point(85, 190)
        Me.lueCausaRechazo.Name = "lueCausaRechazo"
        Me.lueCausaRechazo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCausaRechazo.Size = New System.Drawing.Size(236, 20)
        Me.lueCausaRechazo.StyleController = Me.lycDatosLicenciaMedica
        Me.lueCausaRechazo.TabIndex = 8
        '
        'txtDiasReduccion
        '
        Me.txtDiasReduccion.Location = New System.Drawing.Point(6, 160)
        Me.txtDiasReduccion.Name = "txtDiasReduccion"
        Me.txtDiasReduccion.Properties.DisplayFormat.FormatString = "n0"
        Me.txtDiasReduccion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiasReduccion.Properties.EditFormat.FormatString = "n0"
        Me.txtDiasReduccion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiasReduccion.Properties.Mask.EditMask = "n0"
        Me.txtDiasReduccion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDiasReduccion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDiasReduccion.Properties.MaxLength = 2
        Me.txtDiasReduccion.Size = New System.Drawing.Size(152, 20)
        Me.txtDiasReduccion.StyleController = Me.lycDatosLicenciaMedica
        Me.txtDiasReduccion.TabIndex = 6
        '
        'txtNumeroLicencia
        '
        Me.txtNumeroLicencia.EnterMoveNextControl = True
        Me.txtNumeroLicencia.Location = New System.Drawing.Point(6, 68)
        Me.txtNumeroLicencia.Name = "txtNumeroLicencia"
        Me.txtNumeroLicencia.Properties.Mask.EditMask = "f0"
        Me.txtNumeroLicencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumeroLicencia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNumeroLicencia.Size = New System.Drawing.Size(152, 20)
        Me.txtNumeroLicencia.StyleController = Me.lycDatosLicenciaMedica
        Me.txtNumeroLicencia.TabIndex = 2
        '
        'dteFechaTerminoLicencia
        '
        Me.dteFechaTerminoLicencia.EditValue = Nothing
        Me.dteFechaTerminoLicencia.Location = New System.Drawing.Point(168, 160)
        Me.dteFechaTerminoLicencia.Name = "dteFechaTerminoLicencia"
        Me.dteFechaTerminoLicencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaTerminoLicencia.Properties.ReadOnly = True
        Me.dteFechaTerminoLicencia.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteFechaTerminoLicencia.Size = New System.Drawing.Size(153, 20)
        Me.dteFechaTerminoLicencia.StyleController = Me.lycDatosLicenciaMedica
        Me.dteFechaTerminoLicencia.TabIndex = 7
        '
        'dteFechaRecepcion
        '
        Me.dteFechaRecepcion.EditValue = Nothing
        Me.dteFechaRecepcion.EnterMoveNextControl = True
        Me.dteFechaRecepcion.Location = New System.Drawing.Point(168, 68)
        Me.dteFechaRecepcion.Name = "dteFechaRecepcion"
        Me.dteFechaRecepcion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaRecepcion.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteFechaRecepcion.Size = New System.Drawing.Size(153, 20)
        Me.dteFechaRecepcion.StyleController = Me.lycDatosLicenciaMedica
        Me.dteFechaRecepcion.TabIndex = 3
        '
        'dteFechaInicio
        '
        Me.dteFechaInicio.EditValue = Nothing
        Me.dteFechaInicio.EnterMoveNextControl = True
        Me.dteFechaInicio.Location = New System.Drawing.Point(6, 114)
        Me.dteFechaInicio.Name = "dteFechaInicio"
        Me.dteFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaInicio.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteFechaInicio.Size = New System.Drawing.Size(152, 20)
        Me.dteFechaInicio.StyleController = Me.lycDatosLicenciaMedica
        Me.dteFechaInicio.TabIndex = 4
        '
        'txtDiasLicencia
        '
        Me.txtDiasLicencia.EnterMoveNextControl = True
        Me.txtDiasLicencia.Location = New System.Drawing.Point(168, 114)
        Me.txtDiasLicencia.Name = "txtDiasLicencia"
        Me.txtDiasLicencia.Properties.Mask.EditMask = "n0"
        Me.txtDiasLicencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDiasLicencia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDiasLicencia.Properties.MaxLength = 2
        Me.txtDiasLicencia.Size = New System.Drawing.Size(153, 20)
        Me.txtDiasLicencia.StyleController = Me.lycDatosLicenciaMedica
        Me.txtDiasLicencia.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Detalle Licencia"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lycTipoLicencia, Me.lycInicioLicencia, Me.lycDiasReduccion, Me.lciNumeroLicencia, Me.lycFechaRecepcion, Me.lciDiasLicencia, Me.lycFechaTerminoLicencia, Me.lciCausaRechazo})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(327, 272)
        Me.LayoutControlGroup1.Text = "Detalle Licencia"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lycTipoLicencia
        '
        Me.lycTipoLicencia.Control = Me.lueTipoLicencia
        Me.lycTipoLicencia.CustomizationFormText = "Tipo Licencia"
        Me.lycTipoLicencia.Location = New System.Drawing.Point(0, 0)
        Me.lycTipoLicencia.Name = "lycTipoLicencia"
        Me.lycTipoLicencia.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lycTipoLicencia.Size = New System.Drawing.Size(325, 46)
        Me.lycTipoLicencia.Text = "Tipo Licencia"
        Me.lycTipoLicencia.TextLocation = DevExpress.Utils.Locations.Top
        Me.lycTipoLicencia.TextSize = New System.Drawing.Size(139, 13)
        '
        'lycInicioLicencia
        '
        Me.lycInicioLicencia.Control = Me.dteFechaInicio
        Me.lycInicioLicencia.CustomizationFormText = "Fecha Inicio Reposo"
        Me.lycInicioLicencia.Location = New System.Drawing.Point(0, 92)
        Me.lycInicioLicencia.Name = "lycInicioLicencia"
        Me.lycInicioLicencia.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lycInicioLicencia.Size = New System.Drawing.Size(162, 46)
        Me.lycInicioLicencia.Text = "Fecha Inicio Reposo"
        Me.lycInicioLicencia.TextLocation = DevExpress.Utils.Locations.Top
        Me.lycInicioLicencia.TextSize = New System.Drawing.Size(139, 13)
        '
        'lycDiasReduccion
        '
        Me.lycDiasReduccion.Control = Me.txtDiasReduccion
        Me.lycDiasReduccion.CustomizationFormText = "Días Reducción"
        Me.lycDiasReduccion.Location = New System.Drawing.Point(0, 138)
        Me.lycDiasReduccion.Name = "lycDiasReduccion"
        Me.lycDiasReduccion.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lycDiasReduccion.Size = New System.Drawing.Size(162, 46)
        Me.lycDiasReduccion.Text = "Días Reducción"
        Me.lycDiasReduccion.TextLocation = DevExpress.Utils.Locations.Top
        Me.lycDiasReduccion.TextSize = New System.Drawing.Size(139, 13)
        '
        'lciNumeroLicencia
        '
        Me.lciNumeroLicencia.Control = Me.txtNumeroLicencia
        Me.lciNumeroLicencia.CustomizationFormText = "Número Licencia"
        Me.lciNumeroLicencia.Location = New System.Drawing.Point(0, 46)
        Me.lciNumeroLicencia.Name = "lciNumeroLicencia"
        Me.lciNumeroLicencia.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciNumeroLicencia.Size = New System.Drawing.Size(162, 46)
        Me.lciNumeroLicencia.Text = "Número Licencia"
        Me.lciNumeroLicencia.TextLocation = DevExpress.Utils.Locations.Top
        Me.lciNumeroLicencia.TextSize = New System.Drawing.Size(139, 13)
        '
        'lycFechaRecepcion
        '
        Me.lycFechaRecepcion.Control = Me.dteFechaRecepcion
        Me.lycFechaRecepcion.CustomizationFormText = "Fecha de emisión de Licencia"
        Me.lycFechaRecepcion.Location = New System.Drawing.Point(162, 46)
        Me.lycFechaRecepcion.Name = "lycFechaRecepcion"
        Me.lycFechaRecepcion.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lycFechaRecepcion.Size = New System.Drawing.Size(163, 46)
        Me.lycFechaRecepcion.Text = "Fecha de emisión de Licencia"
        Me.lycFechaRecepcion.TextLocation = DevExpress.Utils.Locations.Top
        Me.lycFechaRecepcion.TextSize = New System.Drawing.Size(139, 13)
        '
        'lciDiasLicencia
        '
        Me.lciDiasLicencia.Control = Me.txtDiasLicencia
        Me.lciDiasLicencia.CustomizationFormText = "N° días Licencia Médica"
        Me.lciDiasLicencia.Location = New System.Drawing.Point(162, 92)
        Me.lciDiasLicencia.Name = "lciDiasLicencia"
        Me.lciDiasLicencia.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciDiasLicencia.Size = New System.Drawing.Size(163, 46)
        Me.lciDiasLicencia.Text = "N° días Licencia Médica"
        Me.lciDiasLicencia.TextLocation = DevExpress.Utils.Locations.Top
        Me.lciDiasLicencia.TextSize = New System.Drawing.Size(139, 13)
        '
        'lycFechaTerminoLicencia
        '
        Me.lycFechaTerminoLicencia.Control = Me.dteFechaTerminoLicencia
        Me.lycFechaTerminoLicencia.CustomizationFormText = "Fecha de término del Reposo"
        Me.lycFechaTerminoLicencia.Location = New System.Drawing.Point(162, 138)
        Me.lycFechaTerminoLicencia.Name = "lycFechaTerminoLicencia"
        Me.lycFechaTerminoLicencia.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lycFechaTerminoLicencia.Size = New System.Drawing.Size(163, 46)
        Me.lycFechaTerminoLicencia.Text = "Fecha de término del Reposo"
        Me.lycFechaTerminoLicencia.TextLocation = DevExpress.Utils.Locations.Top
        Me.lycFechaTerminoLicencia.TextSize = New System.Drawing.Size(139, 13)
        '
        'lciCausaRechazo
        '
        Me.lciCausaRechazo.Control = Me.lueCausaRechazo
        Me.lciCausaRechazo.CustomizationFormText = "Causa Rechazo"
        Me.lciCausaRechazo.Location = New System.Drawing.Point(0, 184)
        Me.lciCausaRechazo.Name = "lciCausaRechazo"
        Me.lciCausaRechazo.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciCausaRechazo.Size = New System.Drawing.Size(325, 86)
        Me.lciCausaRechazo.Text = "Causa Rechazo"
        Me.lciCausaRechazo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.lciCausaRechazo.TextSize = New System.Drawing.Size(74, 13)
        Me.lciCausaRechazo.TextToControlDistance = 5
        '
        'lycReposo
        '
        Me.lycReposo.Controls.Add(Me.rdgClasificacion)
        Me.lycReposo.Controls.Add(Me.rdgTipoReposo)
        Me.lycReposo.Controls.Add(Me.rdgLugarReposo)
        Me.lycReposo.Location = New System.Drawing.Point(330, 104)
        Me.lycReposo.Name = "lycReposo"
        Me.lycReposo.OptionsView.AllowHotTrack = True
        Me.lycReposo.Root = Me.LayoutControlGroup2
        Me.lycReposo.Size = New System.Drawing.Size(206, 272)
        Me.lycReposo.TabIndex = 59
        Me.lycReposo.Text = "LayoutControl1"
        '
        'rdgClasificacion
        '
        Me.rdgClasificacion.EditValue = 0
        Me.rdgClasificacion.Location = New System.Drawing.Point(6, 197)
        Me.rdgClasificacion.Name = "rdgClasificacion"
        Me.rdgClasificacion.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Isapre"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Fonasa"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Mutual")})
        Me.rdgClasificacion.Size = New System.Drawing.Size(194, 69)
        Me.rdgClasificacion.StyleController = Me.lycReposo
        Me.rdgClasificacion.TabIndex = 10
        '
        'rdgTipoReposo
        '
        Me.rdgTipoReposo.EditValue = 0
        Me.rdgTipoReposo.Location = New System.Drawing.Point(6, 113)
        Me.rdgTipoReposo.Name = "rdgTipoReposo"
        Me.rdgTipoReposo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Reposo Laboral Total"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Reposo Laboral Parcial")})
        Me.rdgTipoReposo.Size = New System.Drawing.Size(194, 58)
        Me.rdgTipoReposo.StyleController = Me.lycReposo
        Me.rdgTipoReposo.TabIndex = 9
        '
        'rdgLugarReposo
        '
        Me.rdgLugarReposo.EditValue = 0
        Me.rdgLugarReposo.Location = New System.Drawing.Point(6, 22)
        Me.rdgLugarReposo.Name = "rdgLugarReposo"
        Me.rdgLugarReposo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Domicilio"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Hospital o Clínica"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Otro Domicilio")})
        Me.rdgLugarReposo.Size = New System.Drawing.Size(194, 65)
        Me.rdgLugarReposo.StyleController = Me.lycReposo
        Me.rdgLugarReposo.TabIndex = 8
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Reposo"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lycLugarReposo, Me.lycTipoDia, Me.lycTipoClasificacion})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(206, 272)
        Me.LayoutControlGroup2.Text = "Reposo"
        Me.LayoutControlGroup2.TextVisible = False
        '
        'lycLugarReposo
        '
        Me.lycLugarReposo.Control = Me.rdgLugarReposo
        Me.lycLugarReposo.CustomizationFormText = "Lugar de Reposo"
        Me.lycLugarReposo.Location = New System.Drawing.Point(0, 0)
        Me.lycLugarReposo.Name = "lycLugarReposo"
        Me.lycLugarReposo.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lycLugarReposo.Size = New System.Drawing.Size(204, 91)
        Me.lycLugarReposo.Text = "Lugar de Reposo"
        Me.lycLugarReposo.TextLocation = DevExpress.Utils.Locations.Top
        Me.lycLugarReposo.TextSize = New System.Drawing.Size(127, 13)
        '
        'lycTipoDia
        '
        Me.lycTipoDia.AllowHide = False
        Me.lycTipoDia.Control = Me.rdgTipoReposo
        Me.lycTipoDia.CustomizationFormText = "Características del Reposo"
        Me.lycTipoDia.Location = New System.Drawing.Point(0, 91)
        Me.lycTipoDia.Name = "lycTipoDia"
        Me.lycTipoDia.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lycTipoDia.Size = New System.Drawing.Size(204, 84)
        Me.lycTipoDia.Text = "Características del Reposo"
        Me.lycTipoDia.TextLocation = DevExpress.Utils.Locations.Top
        Me.lycTipoDia.TextSize = New System.Drawing.Size(127, 13)
        '
        'lycTipoClasificacion
        '
        Me.lycTipoClasificacion.Control = Me.rdgClasificacion
        Me.lycTipoClasificacion.CustomizationFormText = "Tipo Entidad de Salud"
        Me.lycTipoClasificacion.Location = New System.Drawing.Point(0, 175)
        Me.lycTipoClasificacion.Name = "lycTipoClasificacion"
        Me.lycTipoClasificacion.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lycTipoClasificacion.Size = New System.Drawing.Size(204, 95)
        Me.lycTipoClasificacion.Text = "Tipo Entidad de Salud"
        Me.lycTipoClasificacion.TextLocation = DevExpress.Utils.Locations.Top
        Me.lycTipoClasificacion.TextSize = New System.Drawing.Size(127, 13)
        '
        'lycFechasVarias
        '
        Me.lycFechasVarias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lycFechasVarias.Controls.Add(Me.txtNumeroFolio)
        Me.lycFechasVarias.Controls.Add(Me.dteFechaRecepIsapre)
        Me.lycFechasVarias.Controls.Add(Me.dteFechaEnvIsapre)
        Me.lycFechasVarias.Controls.Add(Me.dteFechaConcepcion)
        Me.lycFechasVarias.Controls.Add(Me.dteFechaEstimadaPago)
        Me.lycFechasVarias.Controls.Add(Me.dteFechaAccidente)
        Me.lycFechasVarias.Location = New System.Drawing.Point(538, 104)
        Me.lycFechasVarias.Name = "lycFechasVarias"
        Me.lycFechasVarias.OptionsView.AllowHotTrack = True
        Me.lycFechasVarias.Root = Me.LayoutControlGroup4
        Me.lycFechasVarias.Size = New System.Drawing.Size(317, 272)
        Me.lycFechasVarias.TabIndex = 1
        Me.lycFechasVarias.Text = "LayoutControl3"
        '
        'txtNumeroFolio
        '
        Me.txtNumeroFolio.Location = New System.Drawing.Point(164, 116)
        Me.txtNumeroFolio.Name = "txtNumeroFolio"
        Me.txtNumeroFolio.Size = New System.Drawing.Size(147, 20)
        Me.txtNumeroFolio.StyleController = Me.lycFechasVarias
        Me.txtNumeroFolio.TabIndex = 16
        '
        'dteFechaRecepIsapre
        '
        Me.dteFechaRecepIsapre.EditValue = Nothing
        Me.dteFechaRecepIsapre.Location = New System.Drawing.Point(6, 116)
        Me.dteFechaRecepIsapre.Name = "dteFechaRecepIsapre"
        Me.dteFechaRecepIsapre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaRecepIsapre.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteFechaRecepIsapre.Size = New System.Drawing.Size(148, 20)
        Me.dteFechaRecepIsapre.StyleController = Me.lycFechasVarias
        Me.dteFechaRecepIsapre.TabIndex = 15
        '
        'dteFechaEnvIsapre
        '
        Me.dteFechaEnvIsapre.EditValue = Nothing
        Me.dteFechaEnvIsapre.EnterMoveNextControl = True
        Me.dteFechaEnvIsapre.Location = New System.Drawing.Point(164, 70)
        Me.dteFechaEnvIsapre.Name = "dteFechaEnvIsapre"
        Me.dteFechaEnvIsapre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaEnvIsapre.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteFechaEnvIsapre.Size = New System.Drawing.Size(147, 20)
        Me.dteFechaEnvIsapre.StyleController = Me.lycFechasVarias
        Me.dteFechaEnvIsapre.TabIndex = 14
        '
        'dteFechaConcepcion
        '
        Me.dteFechaConcepcion.EditValue = Nothing
        Me.dteFechaConcepcion.EnterMoveNextControl = True
        Me.dteFechaConcepcion.Location = New System.Drawing.Point(6, 68)
        Me.dteFechaConcepcion.Name = "dteFechaConcepcion"
        Me.dteFechaConcepcion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaConcepcion.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteFechaConcepcion.Size = New System.Drawing.Size(148, 20)
        Me.dteFechaConcepcion.StyleController = Me.lycFechasVarias
        Me.dteFechaConcepcion.TabIndex = 13
        '
        'dteFechaEstimadaPago
        '
        Me.dteFechaEstimadaPago.EditValue = Nothing
        Me.dteFechaEstimadaPago.EnterMoveNextControl = True
        Me.dteFechaEstimadaPago.Location = New System.Drawing.Point(164, 22)
        Me.dteFechaEstimadaPago.Name = "dteFechaEstimadaPago"
        Me.dteFechaEstimadaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaEstimadaPago.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteFechaEstimadaPago.Size = New System.Drawing.Size(147, 20)
        Me.dteFechaEstimadaPago.StyleController = Me.lycFechasVarias
        Me.dteFechaEstimadaPago.TabIndex = 12
        '
        'dteFechaAccidente
        '
        Me.dteFechaAccidente.EditValue = Nothing
        Me.dteFechaAccidente.EnterMoveNextControl = True
        Me.dteFechaAccidente.Location = New System.Drawing.Point(6, 22)
        Me.dteFechaAccidente.Name = "dteFechaAccidente"
        Me.dteFechaAccidente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaAccidente.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteFechaAccidente.Size = New System.Drawing.Size(148, 20)
        Me.dteFechaAccidente.StyleController = Me.lycFechasVarias
        Me.dteFechaAccidente.TabIndex = 11
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lycFechaAccidente, Me.lciFechaEstimadaPago, Me.lycFechaConcepcion, Me.lciFechaEnvioIsapre, Me.lycFechaRecepcionIsapre, Me.lciNumeroFolio})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(317, 272)
        Me.LayoutControlGroup4.Text = "LayoutControlGroup4"
        Me.LayoutControlGroup4.TextVisible = False
        '
        'lycFechaAccidente
        '
        Me.lycFechaAccidente.Control = Me.dteFechaAccidente
        Me.lycFechaAccidente.CustomizationFormText = "Fecha Accidente"
        Me.lycFechaAccidente.Location = New System.Drawing.Point(0, 0)
        Me.lycFechaAccidente.Name = "lycFechaAccidente"
        Me.lycFechaAccidente.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lycFechaAccidente.Size = New System.Drawing.Size(158, 46)
        Me.lycFechaAccidente.Text = "Fecha Accidente"
        Me.lycFechaAccidente.TextLocation = DevExpress.Utils.Locations.Top
        Me.lycFechaAccidente.TextSize = New System.Drawing.Size(139, 13)
        '
        'lciFechaEstimadaPago
        '
        Me.lciFechaEstimadaPago.Control = Me.dteFechaEstimadaPago
        Me.lciFechaEstimadaPago.CustomizationFormText = "Fecha Estimada Pago"
        Me.lciFechaEstimadaPago.Location = New System.Drawing.Point(158, 0)
        Me.lciFechaEstimadaPago.Name = "lciFechaEstimadaPago"
        Me.lciFechaEstimadaPago.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciFechaEstimadaPago.Size = New System.Drawing.Size(157, 46)
        Me.lciFechaEstimadaPago.Text = "Fecha Estimada Pago"
        Me.lciFechaEstimadaPago.TextLocation = DevExpress.Utils.Locations.Top
        Me.lciFechaEstimadaPago.TextSize = New System.Drawing.Size(139, 13)
        '
        'lycFechaConcepcion
        '
        Me.lycFechaConcepcion.Control = Me.dteFechaConcepcion
        Me.lycFechaConcepcion.CustomizationFormText = "Fecha Concepción"
        Me.lycFechaConcepcion.Location = New System.Drawing.Point(0, 46)
        Me.lycFechaConcepcion.Name = "lycFechaConcepcion"
        Me.lycFechaConcepcion.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lycFechaConcepcion.Size = New System.Drawing.Size(158, 48)
        Me.lycFechaConcepcion.Text = "Fecha Concepción"
        Me.lycFechaConcepcion.TextLocation = DevExpress.Utils.Locations.Top
        Me.lycFechaConcepcion.TextSize = New System.Drawing.Size(139, 13)
        '
        'lciFechaEnvioIsapre
        '
        Me.lciFechaEnvioIsapre.Control = Me.dteFechaEnvIsapre
        Me.lciFechaEnvioIsapre.CustomizationFormText = "Fecha Envío Isapre"
        Me.lciFechaEnvioIsapre.Location = New System.Drawing.Point(158, 46)
        Me.lciFechaEnvioIsapre.Name = "lciFechaEnvioIsapre"
        Me.lciFechaEnvioIsapre.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciFechaEnvioIsapre.Size = New System.Drawing.Size(157, 48)
        Me.lciFechaEnvioIsapre.Text = "Fecha Envío Isapre"
        Me.lciFechaEnvioIsapre.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.lciFechaEnvioIsapre.TextLocation = DevExpress.Utils.Locations.Top
        Me.lciFechaEnvioIsapre.TextSize = New System.Drawing.Size(92, 13)
        Me.lciFechaEnvioIsapre.TextToControlDistance = 5
        '
        'lycFechaRecepcionIsapre
        '
        Me.lycFechaRecepcionIsapre.Control = Me.dteFechaRecepIsapre
        Me.lycFechaRecepcionIsapre.CustomizationFormText = "Fecha Recepción Isapre"
        Me.lycFechaRecepcionIsapre.Location = New System.Drawing.Point(0, 94)
        Me.lycFechaRecepcionIsapre.Name = "lycFechaRecepcionIsapre"
        Me.lycFechaRecepcionIsapre.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lycFechaRecepcionIsapre.Size = New System.Drawing.Size(158, 176)
        Me.lycFechaRecepcionIsapre.Text = "Fecha Recepción Isapre"
        Me.lycFechaRecepcionIsapre.TextLocation = DevExpress.Utils.Locations.Top
        Me.lycFechaRecepcionIsapre.TextSize = New System.Drawing.Size(139, 13)
        '
        'lciNumeroFolio
        '
        Me.lciNumeroFolio.Control = Me.txtNumeroFolio
        Me.lciNumeroFolio.CustomizationFormText = "Nº Resolución Isapre/Fonasa"
        Me.lciNumeroFolio.Location = New System.Drawing.Point(158, 94)
        Me.lciNumeroFolio.Name = "lciNumeroFolio"
        Me.lciNumeroFolio.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciNumeroFolio.Size = New System.Drawing.Size(157, 176)
        Me.lciNumeroFolio.Text = "Nº Resolución Isapre/Fonasa"
        Me.lciNumeroFolio.TextLocation = DevExpress.Utils.Locations.Top
        Me.lciNumeroFolio.TextSize = New System.Drawing.Size(139, 13)
        '
        'gdcLicenciasMedicas
        '
        Me.gdcLicenciasMedicas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcLicenciasMedicas.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gdcLicenciasMedicas.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gdcLicenciasMedicas.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gdcLicenciasMedicas.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gdcLicenciasMedicas.EmbeddedNavigator.Buttons.First.Visible = False
        Me.gdcLicenciasMedicas.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.gdcLicenciasMedicas.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.gdcLicenciasMedicas.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.gdcLicenciasMedicas.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.gdcLicenciasMedicas.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.gdcLicenciasMedicas.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gdcLicenciasMedicas.Location = New System.Drawing.Point(2, 454)
        Me.gdcLicenciasMedicas.MainView = Me.gdvDetalleLicenciasMedicas
        Me.gdcLicenciasMedicas.Name = "gdcLicenciasMedicas"
        Me.gdcLicenciasMedicas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rluTipoLicencia, Me.rdgEstadoLicenciaMedica, Me.txtMonto})
        Me.gdcLicenciasMedicas.Size = New System.Drawing.Size(853, 144)
        Me.gdcLicenciasMedicas.TabIndex = 61
        Me.gdcLicenciasMedicas.UseEmbeddedNavigator = True
        Me.gdcLicenciasMedicas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleLicenciasMedicas, Me.GridView1})
        '
        'gdvDetalleLicenciasMedicas
        '
        Me.gdvDetalleLicenciasMedicas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.LICENCIA_MEDICA_ID, Me.EMPLEADO_ID, Me.PERIODO, Me.TIPO_LICENCIA_MEDICA_ID, Me.DESCRIPCION, Me.FECHA_INICIO, Me.DIAS_LICENCIA, Me.FECHA_TERMINO, Me.NUMERO_LICENCIA, Me.FECHA_RECEPCION, Me.ESTADO_LICENCIA, Me.FECHA_ACCIDENTE, Me.FECHA_EMISION, Me.TIPO_REPOSO, Me.LUGAR_REPOSO, Me.FECHA_ENVIO_ISAPRE, Me.CONTINUIDAD, Me.NUMERO_LICENCIA_CONTINUIDAD, Me.FECHA_INICIO_CONTINUIDAD, Me.DIAS_CONTINUIDAD, Me.FECHA_TERMINO_CONTINUIDAD, Me.FECHA_CONCEPCION, Me.NOMBRE_DOCTOR, Me.ESPECIALIDAD, Me.NUMERO_CHEQUE, Me.MONTO_CHEQUE, Me.MEMORANDUM, Me.OBSERVACIONES, Me.FECHA_DIGITACION_PAGO, Me.PERIODO_ID, Me.RENTA_PROMEDIO_ID, Me.FECHA_RECEPCION_ISAPRE, Me.NUMERO_FILIO, Me.colDIAS_REDUCCION, Me.CLASIFICACION, Me.colFECHA_ESTIMADA_PAGO, Me.colCAUSA_RECHAZO_ID, Me.colTIPO_PROFESIONAL, Me.colMONTO_SUBSIDIO, Me.colCOTIZACION_PREVISIONAL, Me.colCOTIZACION_SALUD, Me.colDIAS_PAGADOS, Me.colDIAS_PREV})
        Me.gdvDetalleLicenciasMedicas.DetailHeight = 500
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.BorderColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseBorderColor = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.ESTADO_LICENCIA
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = 0
        Me.gdvDetalleLicenciasMedicas.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.gdvDetalleLicenciasMedicas.GridControl = Me.gdcLicenciasMedicas
        Me.gdvDetalleLicenciasMedicas.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvDetalleLicenciasMedicas.Name = "gdvDetalleLicenciasMedicas"
        Me.gdvDetalleLicenciasMedicas.OptionsView.ColumnAutoWidth = False
        Me.gdvDetalleLicenciasMedicas.OptionsView.ShowGroupPanel = False
        '
        'LICENCIA_MEDICA_ID
        '
        Me.LICENCIA_MEDICA_ID.Caption = "ID Licencia Médica"
        Me.LICENCIA_MEDICA_ID.FieldName = "LICENCIA_MEDICA_ID"
        Me.LICENCIA_MEDICA_ID.Name = "LICENCIA_MEDICA_ID"
        Me.LICENCIA_MEDICA_ID.OptionsColumn.AllowEdit = False
        Me.LICENCIA_MEDICA_ID.OptionsFilter.AllowAutoFilter = False
        '
        'EMPLEADO_ID
        '
        Me.EMPLEADO_ID.Caption = "ID Empleado"
        Me.EMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.EMPLEADO_ID.Name = "EMPLEADO_ID"
        Me.EMPLEADO_ID.OptionsColumn.AllowEdit = False
        Me.EMPLEADO_ID.OptionsFilter.AllowAutoFilter = False
        '
        'PERIODO
        '
        Me.PERIODO.Caption = "Período"
        Me.PERIODO.FieldName = "PERIODO"
        Me.PERIODO.Name = "PERIODO"
        Me.PERIODO.OptionsColumn.AllowEdit = False
        Me.PERIODO.OptionsFilter.AllowAutoFilter = False
        Me.PERIODO.Visible = True
        Me.PERIODO.VisibleIndex = 0
        Me.PERIODO.Width = 86
        '
        'TIPO_LICENCIA_MEDICA_ID
        '
        Me.TIPO_LICENCIA_MEDICA_ID.Caption = "Tipo Licencia"
        Me.TIPO_LICENCIA_MEDICA_ID.ColumnEdit = Me.rluTipoLicencia
        Me.TIPO_LICENCIA_MEDICA_ID.FieldName = "TIPO_LICENCIA_MEDICA_ID"
        Me.TIPO_LICENCIA_MEDICA_ID.Name = "TIPO_LICENCIA_MEDICA_ID"
        Me.TIPO_LICENCIA_MEDICA_ID.OptionsColumn.AllowEdit = False
        Me.TIPO_LICENCIA_MEDICA_ID.OptionsFilter.AllowAutoFilter = False
        Me.TIPO_LICENCIA_MEDICA_ID.Width = 188
        '
        'rluTipoLicencia
        '
        Me.rluTipoLicencia.AutoHeight = False
        Me.rluTipoLicencia.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rluTipoLicencia.Name = "rluTipoLicencia"
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.Caption = "Descripción"
        Me.DESCRIPCION.FieldName = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.OptionsColumn.AllowEdit = False
        Me.DESCRIPCION.OptionsFilter.AllowAutoFilter = False
        Me.DESCRIPCION.Width = 173
        '
        'FECHA_INICIO
        '
        Me.FECHA_INICIO.Caption = "Fecha Inicio"
        Me.FECHA_INICIO.FieldName = "FECHA_INICIO"
        Me.FECHA_INICIO.Name = "FECHA_INICIO"
        Me.FECHA_INICIO.OptionsColumn.AllowEdit = False
        Me.FECHA_INICIO.OptionsFilter.AllowAutoFilter = False
        Me.FECHA_INICIO.Visible = True
        Me.FECHA_INICIO.VisibleIndex = 1
        Me.FECHA_INICIO.Width = 84
        '
        'DIAS_LICENCIA
        '
        Me.DIAS_LICENCIA.Caption = "Días"
        Me.DIAS_LICENCIA.FieldName = "DIAS_LICENCIA"
        Me.DIAS_LICENCIA.Name = "DIAS_LICENCIA"
        Me.DIAS_LICENCIA.OptionsColumn.AllowEdit = False
        Me.DIAS_LICENCIA.OptionsFilter.AllowAutoFilter = False
        Me.DIAS_LICENCIA.Visible = True
        Me.DIAS_LICENCIA.VisibleIndex = 2
        Me.DIAS_LICENCIA.Width = 81
        '
        'FECHA_TERMINO
        '
        Me.FECHA_TERMINO.Caption = "Fecha Término"
        Me.FECHA_TERMINO.FieldName = "FECHA_TERMINO"
        Me.FECHA_TERMINO.Name = "FECHA_TERMINO"
        Me.FECHA_TERMINO.OptionsColumn.AllowEdit = False
        Me.FECHA_TERMINO.OptionsFilter.AllowAutoFilter = False
        Me.FECHA_TERMINO.Visible = True
        Me.FECHA_TERMINO.VisibleIndex = 3
        Me.FECHA_TERMINO.Width = 93
        '
        'NUMERO_LICENCIA
        '
        Me.NUMERO_LICENCIA.Caption = "Número Licencia"
        Me.NUMERO_LICENCIA.FieldName = "NUMERO_LICENCIA"
        Me.NUMERO_LICENCIA.Name = "NUMERO_LICENCIA"
        Me.NUMERO_LICENCIA.OptionsColumn.AllowEdit = False
        Me.NUMERO_LICENCIA.OptionsFilter.AllowAutoFilter = False
        Me.NUMERO_LICENCIA.Visible = True
        Me.NUMERO_LICENCIA.VisibleIndex = 4
        Me.NUMERO_LICENCIA.Width = 105
        '
        'FECHA_RECEPCION
        '
        Me.FECHA_RECEPCION.Caption = "Fecha Recepción"
        Me.FECHA_RECEPCION.FieldName = "FECHA_RECEPCION"
        Me.FECHA_RECEPCION.Name = "FECHA_RECEPCION"
        Me.FECHA_RECEPCION.OptionsColumn.AllowEdit = False
        Me.FECHA_RECEPCION.OptionsFilter.AllowAutoFilter = False
        Me.FECHA_RECEPCION.Visible = True
        Me.FECHA_RECEPCION.VisibleIndex = 5
        Me.FECHA_RECEPCION.Width = 100
        '
        'FECHA_ACCIDENTE
        '
        Me.FECHA_ACCIDENTE.Caption = "Fecha Accidente"
        Me.FECHA_ACCIDENTE.FieldName = "FECHA_ACCIDENTE"
        Me.FECHA_ACCIDENTE.Name = "FECHA_ACCIDENTE"
        Me.FECHA_ACCIDENTE.OptionsColumn.AllowEdit = False
        Me.FECHA_ACCIDENTE.OptionsFilter.AllowAutoFilter = False
        '
        'FECHA_EMISION
        '
        Me.FECHA_EMISION.Caption = "Fecha Emisión"
        Me.FECHA_EMISION.FieldName = "FECHA_EMISION"
        Me.FECHA_EMISION.Name = "FECHA_EMISION"
        Me.FECHA_EMISION.OptionsColumn.AllowEdit = False
        Me.FECHA_EMISION.OptionsFilter.AllowAutoFilter = False
        '
        'TIPO_REPOSO
        '
        Me.TIPO_REPOSO.Caption = "Tipo Reposo"
        Me.TIPO_REPOSO.FieldName = "TIPO_REPOSO"
        Me.TIPO_REPOSO.Name = "TIPO_REPOSO"
        Me.TIPO_REPOSO.OptionsColumn.AllowEdit = False
        Me.TIPO_REPOSO.OptionsFilter.AllowAutoFilter = False
        '
        'LUGAR_REPOSO
        '
        Me.LUGAR_REPOSO.Caption = "Lugar Reposo"
        Me.LUGAR_REPOSO.FieldName = "LUGAR_REPOSO"
        Me.LUGAR_REPOSO.Name = "LUGAR_REPOSO"
        Me.LUGAR_REPOSO.OptionsColumn.AllowEdit = False
        Me.LUGAR_REPOSO.OptionsFilter.AllowAutoFilter = False
        '
        'FECHA_ENVIO_ISAPRE
        '
        Me.FECHA_ENVIO_ISAPRE.Caption = "Fecha Env.Isapre"
        Me.FECHA_ENVIO_ISAPRE.FieldName = "FECHA_ENVIO_ISAPRE"
        Me.FECHA_ENVIO_ISAPRE.Name = "FECHA_ENVIO_ISAPRE"
        Me.FECHA_ENVIO_ISAPRE.OptionsColumn.AllowEdit = False
        Me.FECHA_ENVIO_ISAPRE.OptionsFilter.AllowAutoFilter = False
        '
        'CONTINUIDAD
        '
        Me.CONTINUIDAD.Caption = "Continuidad"
        Me.CONTINUIDAD.FieldName = "CONTINUIDAD"
        Me.CONTINUIDAD.Name = "CONTINUIDAD"
        Me.CONTINUIDAD.OptionsColumn.AllowEdit = False
        Me.CONTINUIDAD.OptionsFilter.AllowAutoFilter = False
        '
        'NUMERO_LICENCIA_CONTINUIDAD
        '
        Me.NUMERO_LICENCIA_CONTINUIDAD.Caption = "Número Licencia Continuidad"
        Me.NUMERO_LICENCIA_CONTINUIDAD.FieldName = "NUMERO_LICENCIA_CONTINUIDAD"
        Me.NUMERO_LICENCIA_CONTINUIDAD.Name = "NUMERO_LICENCIA_CONTINUIDAD"
        Me.NUMERO_LICENCIA_CONTINUIDAD.OptionsColumn.AllowEdit = False
        Me.NUMERO_LICENCIA_CONTINUIDAD.OptionsFilter.AllowAutoFilter = False
        '
        'FECHA_INICIO_CONTINUIDAD
        '
        Me.FECHA_INICIO_CONTINUIDAD.Caption = "Fecha Inicio Continuidad"
        Me.FECHA_INICIO_CONTINUIDAD.FieldName = "FECHA_INICIO_CONTINUIDAD"
        Me.FECHA_INICIO_CONTINUIDAD.Name = "FECHA_INICIO_CONTINUIDAD"
        Me.FECHA_INICIO_CONTINUIDAD.OptionsColumn.AllowEdit = False
        Me.FECHA_INICIO_CONTINUIDAD.OptionsFilter.AllowAutoFilter = False
        '
        'DIAS_CONTINUIDAD
        '
        Me.DIAS_CONTINUIDAD.Caption = "Días Continuidad"
        Me.DIAS_CONTINUIDAD.FieldName = "DIAS_CONTINUIDAD"
        Me.DIAS_CONTINUIDAD.Name = "DIAS_CONTINUIDAD"
        Me.DIAS_CONTINUIDAD.OptionsColumn.AllowEdit = False
        Me.DIAS_CONTINUIDAD.OptionsFilter.AllowAutoFilter = False
        '
        'FECHA_TERMINO_CONTINUIDAD
        '
        Me.FECHA_TERMINO_CONTINUIDAD.Caption = "Fecha término Continuidad"
        Me.FECHA_TERMINO_CONTINUIDAD.FieldName = "FECHA_TERMINO_CONTINUIDAD"
        Me.FECHA_TERMINO_CONTINUIDAD.Name = "FECHA_TERMINO_CONTINUIDAD"
        Me.FECHA_TERMINO_CONTINUIDAD.OptionsColumn.AllowEdit = False
        Me.FECHA_TERMINO_CONTINUIDAD.OptionsFilter.AllowAutoFilter = False
        '
        'FECHA_CONCEPCION
        '
        Me.FECHA_CONCEPCION.Caption = "Fecha Concepción"
        Me.FECHA_CONCEPCION.FieldName = "FECHA_CONCEPCION"
        Me.FECHA_CONCEPCION.Name = "FECHA_CONCEPCION"
        Me.FECHA_CONCEPCION.OptionsColumn.AllowEdit = False
        Me.FECHA_CONCEPCION.OptionsFilter.AllowAutoFilter = False
        '
        'NOMBRE_DOCTOR
        '
        Me.NOMBRE_DOCTOR.Caption = "Nombre Doctor"
        Me.NOMBRE_DOCTOR.FieldName = "NOMBRE_DOCTOR"
        Me.NOMBRE_DOCTOR.Name = "NOMBRE_DOCTOR"
        '
        'ESPECIALIDAD
        '
        Me.ESPECIALIDAD.Caption = "Especialidad"
        Me.ESPECIALIDAD.FieldName = "ESPECIALIDAD"
        Me.ESPECIALIDAD.Name = "ESPECIALIDAD"
        '
        'NUMERO_CHEQUE
        '
        Me.NUMERO_CHEQUE.Caption = "Número Cheque"
        Me.NUMERO_CHEQUE.FieldName = "NUMERO_CHEQUE"
        Me.NUMERO_CHEQUE.Name = "NUMERO_CHEQUE"
        '
        'MONTO_CHEQUE
        '
        Me.MONTO_CHEQUE.Caption = "Monto Cheque"
        Me.MONTO_CHEQUE.FieldName = "MONTO_CHEQUE"
        Me.MONTO_CHEQUE.Name = "MONTO_CHEQUE"
        '
        'MEMORANDUM
        '
        Me.MEMORANDUM.Caption = "Memorandum"
        Me.MEMORANDUM.FieldName = "MEMORANDUM"
        Me.MEMORANDUM.Name = "MEMORANDUM"
        '
        'OBSERVACIONES
        '
        Me.OBSERVACIONES.Caption = "Observaciones"
        Me.OBSERVACIONES.FieldName = "OBSERVACIONES"
        Me.OBSERVACIONES.Name = "OBSERVACIONES"
        '
        'FECHA_DIGITACION_PAGO
        '
        Me.FECHA_DIGITACION_PAGO.Caption = "Fecha Dig.Pago"
        Me.FECHA_DIGITACION_PAGO.FieldName = "FECHA_DIGITACION_PAGO"
        Me.FECHA_DIGITACION_PAGO.Name = "FECHA_DIGITACION_PAGO"
        '
        'PERIODO_ID
        '
        Me.PERIODO_ID.Caption = "ID Periodo"
        Me.PERIODO_ID.FieldName = "PERIODO_ID"
        Me.PERIODO_ID.Name = "PERIODO_ID"
        '
        'RENTA_PROMEDIO_ID
        '
        Me.RENTA_PROMEDIO_ID.Caption = "ID Renta Promedio"
        Me.RENTA_PROMEDIO_ID.FieldName = "RENTA_PROMEDIO_ID"
        Me.RENTA_PROMEDIO_ID.Name = "RENTA_PROMEDIO_ID"
        Me.RENTA_PROMEDIO_ID.OptionsColumn.ReadOnly = True
        '
        'FECHA_RECEPCION_ISAPRE
        '
        Me.FECHA_RECEPCION_ISAPRE.Caption = "Fecha Recepción Isapre"
        Me.FECHA_RECEPCION_ISAPRE.FieldName = "FECHA_RECEPCION_ISAPRE"
        Me.FECHA_RECEPCION_ISAPRE.Name = "FECHA_RECEPCION_ISAPRE"
        '
        'NUMERO_FILIO
        '
        Me.NUMERO_FILIO.Caption = "Número Folio"
        Me.NUMERO_FILIO.FieldName = "NUMERO_FILIO"
        Me.NUMERO_FILIO.Name = "NUMERO_FILIO"
        '
        'colDIAS_REDUCCION
        '
        Me.colDIAS_REDUCCION.Caption = "Dias reducción"
        Me.colDIAS_REDUCCION.FieldName = "DIAS_REDUCCION"
        Me.colDIAS_REDUCCION.Name = "colDIAS_REDUCCION"
        Me.colDIAS_REDUCCION.OptionsColumn.AllowEdit = False
        Me.colDIAS_REDUCCION.OptionsColumn.ReadOnly = True
        Me.colDIAS_REDUCCION.OptionsColumn.ShowInCustomizationForm = False
        '
        'CLASIFICACION
        '
        Me.CLASIFICACION.Caption = "Clasificación"
        Me.CLASIFICACION.FieldName = "CLASIFICACION"
        Me.CLASIFICACION.Name = "CLASIFICACION"
        '
        'colFECHA_ESTIMADA_PAGO
        '
        Me.colFECHA_ESTIMADA_PAGO.Caption = "Fecha Estimada"
        Me.colFECHA_ESTIMADA_PAGO.FieldName = "FECHA_ESTIMADA_PAGO"
        Me.colFECHA_ESTIMADA_PAGO.Name = "colFECHA_ESTIMADA_PAGO"
        Me.colFECHA_ESTIMADA_PAGO.OptionsColumn.AllowEdit = False
        Me.colFECHA_ESTIMADA_PAGO.OptionsColumn.ReadOnly = True
        Me.colFECHA_ESTIMADA_PAGO.OptionsColumn.ShowInCustomizationForm = False
        '
        'colCAUSA_RECHAZO_ID
        '
        Me.colCAUSA_RECHAZO_ID.Caption = "Causa Rechazo"
        Me.colCAUSA_RECHAZO_ID.FieldName = "CAUSA_RECHAZO_ID"
        Me.colCAUSA_RECHAZO_ID.Name = "colCAUSA_RECHAZO_ID"
        Me.colCAUSA_RECHAZO_ID.OptionsColumn.AllowEdit = False
        Me.colCAUSA_RECHAZO_ID.OptionsColumn.ReadOnly = True
        Me.colCAUSA_RECHAZO_ID.OptionsColumn.ShowInCustomizationForm = False
        '
        'colTIPO_PROFESIONAL
        '
        Me.colTIPO_PROFESIONAL.Caption = "Tipo Profesional"
        Me.colTIPO_PROFESIONAL.FieldName = "TIPO_PROFESIONAL"
        Me.colTIPO_PROFESIONAL.Name = "colTIPO_PROFESIONAL"
        Me.colTIPO_PROFESIONAL.OptionsColumn.AllowEdit = False
        Me.colTIPO_PROFESIONAL.OptionsColumn.ReadOnly = True
        Me.colTIPO_PROFESIONAL.OptionsColumn.ShowInCustomizationForm = False
        '
        'colMONTO_SUBSIDIO
        '
        Me.colMONTO_SUBSIDIO.Caption = "Monto Subsidio"
        Me.colMONTO_SUBSIDIO.ColumnEdit = Me.txtMonto
        Me.colMONTO_SUBSIDIO.FieldName = "MONTO_SUBSIDIO"
        Me.colMONTO_SUBSIDIO.Name = "colMONTO_SUBSIDIO"
        Me.colMONTO_SUBSIDIO.OptionsColumn.AllowEdit = False
        Me.colMONTO_SUBSIDIO.OptionsColumn.ReadOnly = True
        Me.colMONTO_SUBSIDIO.Visible = True
        Me.colMONTO_SUBSIDIO.VisibleIndex = 6
        Me.colMONTO_SUBSIDIO.Width = 96
        '
        'txtMonto
        '
        Me.txtMonto.AutoHeight = False
        Me.txtMonto.DisplayFormat.FormatString = "n0"
        Me.txtMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.EditFormat.FormatString = "n0"
        Me.txtMonto.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.Name = "txtMonto"
        '
        'colCOTIZACION_PREVISIONAL
        '
        Me.colCOTIZACION_PREVISIONAL.Caption = "Monto Cot.Previs"
        Me.colCOTIZACION_PREVISIONAL.ColumnEdit = Me.txtMonto
        Me.colCOTIZACION_PREVISIONAL.FieldName = "COTIZACION_PREVISIONAL"
        Me.colCOTIZACION_PREVISIONAL.Name = "colCOTIZACION_PREVISIONAL"
        Me.colCOTIZACION_PREVISIONAL.OptionsColumn.AllowEdit = False
        Me.colCOTIZACION_PREVISIONAL.OptionsColumn.ReadOnly = True
        Me.colCOTIZACION_PREVISIONAL.Visible = True
        Me.colCOTIZACION_PREVISIONAL.VisibleIndex = 7
        Me.colCOTIZACION_PREVISIONAL.Width = 108
        '
        'colCOTIZACION_SALUD
        '
        Me.colCOTIZACION_SALUD.Caption = "Monto Cot.Salud"
        Me.colCOTIZACION_SALUD.ColumnEdit = Me.txtMonto
        Me.colCOTIZACION_SALUD.FieldName = "COTIZACION_SALUD"
        Me.colCOTIZACION_SALUD.Name = "colCOTIZACION_SALUD"
        Me.colCOTIZACION_SALUD.OptionsColumn.AllowEdit = False
        Me.colCOTIZACION_SALUD.OptionsColumn.ReadOnly = True
        Me.colCOTIZACION_SALUD.Visible = True
        Me.colCOTIZACION_SALUD.VisibleIndex = 8
        Me.colCOTIZACION_SALUD.Width = 111
        '
        'colDIAS_PAGADOS
        '
        Me.colDIAS_PAGADOS.Caption = "Días Pagados"
        Me.colDIAS_PAGADOS.ColumnEdit = Me.txtMonto
        Me.colDIAS_PAGADOS.FieldName = "DIAS_PAGADOS"
        Me.colDIAS_PAGADOS.Name = "colDIAS_PAGADOS"
        Me.colDIAS_PAGADOS.OptionsColumn.AllowEdit = False
        Me.colDIAS_PAGADOS.OptionsColumn.ReadOnly = True
        Me.colDIAS_PAGADOS.Visible = True
        Me.colDIAS_PAGADOS.VisibleIndex = 9
        Me.colDIAS_PAGADOS.Width = 94
        '
        'colDIAS_PREV
        '
        Me.colDIAS_PREV.Caption = "Dìas Prev."
        Me.colDIAS_PREV.ColumnEdit = Me.txtMonto
        Me.colDIAS_PREV.FieldName = "DIAS_PREV"
        Me.colDIAS_PREV.Name = "colDIAS_PREV"
        Me.colDIAS_PREV.OptionsColumn.AllowEdit = False
        Me.colDIAS_PREV.OptionsColumn.ReadOnly = True
        Me.colDIAS_PREV.Visible = True
        Me.colDIAS_PREV.VisibleIndex = 10
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcLicenciasMedicas
        Me.GridView1.Name = "GridView1"
        '
        'btnDetalldelPago
        '
        Me.btnDetalldelPago.Location = New System.Drawing.Point(514, 8)
        Me.btnDetalldelPago.Name = "btnDetalldelPago"
        Me.btnDetalldelPago.Size = New System.Drawing.Size(129, 23)
        Me.btnDetalldelPago.TabIndex = 27
        Me.btnDetalldelPago.Text = "&Detalle del pago"
        '
        'btnRentaUltimosTresMeses
        '
        Me.btnRentaUltimosTresMeses.Location = New System.Drawing.Point(370, 8)
        Me.btnRentaUltimosTresMeses.Name = "btnRentaUltimosTresMeses"
        Me.btnRentaUltimosTresMeses.Size = New System.Drawing.Size(129, 23)
        Me.btnRentaUltimosTresMeses.TabIndex = 25
        Me.btnRentaUltimosTresMeses.Text = "&Renta últimos meses"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(226, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(129, 23)
        Me.btnGuardar.TabIndex = 24
        Me.btnGuardar.Text = "&Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(82, 8)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(129, 23)
        Me.btnNuevo.TabIndex = 23
        Me.btnNuevo.Text = "&Nuevo"
        '
        'lycDatosDoctor
        '
        Me.lycDatosDoctor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lycDatosDoctor.Controls.Add(Me.rdgTipoProfesional)
        Me.lycDatosDoctor.Controls.Add(Me.txtEspecialidad)
        Me.lycDatosDoctor.Controls.Add(Me.txtNombreDoctor)
        Me.lycDatosDoctor.Location = New System.Drawing.Point(2, 376)
        Me.lycDatosDoctor.Name = "lycDatosDoctor"
        Me.lycDatosDoctor.Root = Me.LayoutControlGroup5
        Me.lycDatosDoctor.Size = New System.Drawing.Size(854, 72)
        Me.lycDatosDoctor.TabIndex = 62
        Me.lycDatosDoctor.Text = "LayoutControl1"
        '
        'rdgTipoProfesional
        '
        Me.rdgTipoProfesional.EditValue = 0
        Me.rdgTipoProfesional.Location = New System.Drawing.Point(85, 6)
        Me.rdgTipoProfesional.Name = "rdgTipoProfesional"
        Me.rdgTipoProfesional.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Médico"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Dentista"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Matrona")})
        Me.rdgTipoProfesional.Size = New System.Drawing.Size(185, 60)
        Me.rdgTipoProfesional.StyleController = Me.lycDatosDoctor
        Me.rdgTipoProfesional.TabIndex = 17
        '
        'txtEspecialidad
        '
        Me.txtEspecialidad.EnterMoveNextControl = True
        Me.txtEspecialidad.Location = New System.Drawing.Point(359, 36)
        Me.txtEspecialidad.Name = "txtEspecialidad"
        Me.txtEspecialidad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEspecialidad.Properties.MaxLength = 50
        Me.txtEspecialidad.Size = New System.Drawing.Size(489, 20)
        Me.txtEspecialidad.StyleController = Me.lycDatosDoctor
        Me.txtEspecialidad.TabIndex = 19
        '
        'txtNombreDoctor
        '
        Me.txtNombreDoctor.EnterMoveNextControl = True
        Me.txtNombreDoctor.Location = New System.Drawing.Point(359, 6)
        Me.txtNombreDoctor.Name = "txtNombreDoctor"
        Me.txtNombreDoctor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreDoctor.Properties.MaxLength = 50
        Me.txtNombreDoctor.Size = New System.Drawing.Size(489, 20)
        Me.txtNombreDoctor.StyleController = Me.lycDatosDoctor
        Me.txtNombreDoctor.TabIndex = 18
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CustomizationFormText = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciNombreDoctor, Me.lciEspecialidad, Me.lciTipoProfesional})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(854, 72)
        Me.LayoutControlGroup5.Text = "LayoutControlGroup5"
        Me.LayoutControlGroup5.TextVisible = False
        '
        'lciNombreDoctor
        '
        Me.lciNombreDoctor.Control = Me.txtNombreDoctor
        Me.lciNombreDoctor.CustomizationFormText = "Nombre Doctor"
        Me.lciNombreDoctor.Location = New System.Drawing.Point(274, 0)
        Me.lciNombreDoctor.Name = "lciNombreDoctor"
        Me.lciNombreDoctor.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciNombreDoctor.Size = New System.Drawing.Size(578, 30)
        Me.lciNombreDoctor.Text = "Nombre Doctor"
        Me.lciNombreDoctor.TextSize = New System.Drawing.Size(76, 13)
        '
        'lciEspecialidad
        '
        Me.lciEspecialidad.Control = Me.txtEspecialidad
        Me.lciEspecialidad.CustomizationFormText = "Especialidad"
        Me.lciEspecialidad.Location = New System.Drawing.Point(274, 30)
        Me.lciEspecialidad.Name = "lciEspecialidad"
        Me.lciEspecialidad.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciEspecialidad.Size = New System.Drawing.Size(578, 40)
        Me.lciEspecialidad.Text = "Especialidad"
        Me.lciEspecialidad.TextSize = New System.Drawing.Size(76, 13)
        '
        'lciTipoProfesional
        '
        Me.lciTipoProfesional.Control = Me.rdgTipoProfesional
        Me.lciTipoProfesional.CustomizationFormText = "Tipo Profesional"
        Me.lciTipoProfesional.Location = New System.Drawing.Point(0, 0)
        Me.lciTipoProfesional.Name = "lciTipoProfesional"
        Me.lciTipoProfesional.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciTipoProfesional.Size = New System.Drawing.Size(274, 70)
        Me.lciTipoProfesional.Text = "Tipo Profesional"
        Me.lciTipoProfesional.TextSize = New System.Drawing.Size(76, 13)
        '
        'lciFechaInicioLicencia
        '
        Me.lciFechaInicioLicencia.CustomizationFormText = "Fecha Inicio Licencia"
        Me.lciFechaInicioLicencia.Location = New System.Drawing.Point(0, 108)
        Me.lciFechaInicioLicencia.Name = "lciFechaInicioLicencia"
        Me.lciFechaInicioLicencia.Size = New System.Drawing.Size(238, 54)
        Me.lciFechaInicioLicencia.Text = "Fecha Inicio Licencia"
        Me.lciFechaInicioLicencia.TextSize = New System.Drawing.Size(97, 20)
        Me.lciFechaInicioLicencia.TextToControlDistance = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.CustomizationFormText = "Numero Folio"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 216)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(238, 54)
        Me.LayoutControlItem4.Text = "Numero Folio"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(97, 20)
        Me.LayoutControlItem4.TextToControlDistance = 5
        '
        'gpcBotones
        '
        Me.gpcBotones.Controls.Add(Me.btnDetalldelPago)
        Me.gpcBotones.Controls.Add(Me.btnRentaUltimosTresMeses)
        Me.gpcBotones.Controls.Add(Me.btnGuardar)
        Me.gpcBotones.Controls.Add(Me.btnNuevo)
        Me.gpcBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gpcBotones.Location = New System.Drawing.Point(0, 604)
        Me.gpcBotones.Name = "gpcBotones"
        Me.gpcBotones.ShowCaption = False
        Me.gpcBotones.Size = New System.Drawing.Size(856, 38)
        Me.gpcBotones.TabIndex = 63
        Me.gpcBotones.Text = "GroupControl1"
        '
        'frmLicenciaMedicaDetalle
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 642)
        Me.Controls.Add(Me.lycDatosDoctor)
        Me.Controls.Add(Me.gdcLicenciasMedicas)
        Me.Controls.Add(Me.lycReposo)
        Me.Controls.Add(Me.lycDatosLicenciaMedica)
        Me.Controls.Add(Me.gpcNombreEmpleado)
        Me.Controls.Add(Me.lycFechasVarias)
        Me.Controls.Add(Me.gpcBotones)
        Me.Name = "frmLicenciaMedicaDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Licencias Médicas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.rdgEstadoLicenciaMedica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcNombreEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcNombreEmpleado.ResumeLayout(False)
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleRutGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgEstadoLicencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycLicenciaMedicaContinuidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycLicenciaMedicaContinuidad.ResumeLayout(False)
        CType(Me.dteFechaTerminoContinuidad.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaTerminoContinuidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaInicioContinuidad.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaInicioContinuidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroLicenciaContinuidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgContinuidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiasContinuidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgLicenciaContinuidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycContinuidadLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycNumeroLicenciaContinuidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycFechaInicioContinuidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycDiasContinuidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycTerminoContinuidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTipoLicencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycDatosLicenciaMedica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycDatosLicenciaMedica.ResumeLayout(False)
        CType(Me.lueCausaRechazo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiasReduccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroLicencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaTerminoLicencia.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaTerminoLicencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaRecepcion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaRecepcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiasLicencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycTipoLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycInicioLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycDiasReduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciNumeroLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycFechaRecepcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciDiasLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycFechaTerminoLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciCausaRechazo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycReposo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycReposo.ResumeLayout(False)
        CType(Me.rdgClasificacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgTipoReposo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgLugarReposo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycLugarReposo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycTipoDia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycTipoClasificacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycFechasVarias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycFechasVarias.ResumeLayout(False)
        CType(Me.txtNumeroFolio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaRecepIsapre.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaRecepIsapre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaEnvIsapre.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaEnvIsapre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaConcepcion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaConcepcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaEstimadaPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaEstimadaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaAccidente.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaAccidente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycFechaAccidente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciFechaEstimadaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycFechaConcepcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciFechaEnvioIsapre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycFechaRecepcionIsapre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciNumeroFolio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcLicenciasMedicas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleLicenciasMedicas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rluTipoLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycDatosDoctor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycDatosDoctor.ResumeLayout(False)
        CType(Me.rdgTipoProfesional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEspecialidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreDoctor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciNombreDoctor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEspecialidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciTipoProfesional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciFechaInicioLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim empleado As Empleado
    Dim parametroMensual As PERIODO
    Dim idRentaPromedio As Integer
    Dim myEmpleadoID, idPeriodo As Integer

    Private Sub frmLicenciaMedicaDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        parametroMensual = New Periodo
        myEmpleadoID = 0
        repositorio.Show()
        llenarRutEmpleado()
        llenarTipoLicencia()
        llenarCausaRechazoLicencia()
        habilitaBotones()
        btnNuevo.Enabled = False
        deshabilitaGrupoControles()
    End Sub

    Public Sub llenarCausaRechazoLicencia()
        With lueCausaRechazo
            With .Properties.Columns
                .Add(New LookUpColumnInfo("CAUSA_RECHAZO_ID", "ID Tipo Licencia", 80, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueCausaRechazo.Properties.DataSource = repositorio.dvCausaRechazoLicencia
        lueCausaRechazo.Properties.DisplayMember = "DESCRIPCION"
        lueCausaRechazo.Properties.NullText = ""
        lueCausaRechazo.Properties.PopupWidth = 400
        lueCausaRechazo.Properties.ValueMember = "CAUSA_RECHAZO_ID"
    End Sub

    Public Sub llenarTipoLicencia()
        With lueTipoLicencia
            With .Properties.Columns
                .Add(New LookUpColumnInfo("TIPO_LICENCIA_MEDICA_ID", "ID Tipo Licencia", 80, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueTipoLicencia.Properties.DataSource = repositorio.dvTipoLicencia
        lueTipoLicencia.Properties.DisplayMember = "DESCRIPCION"
        lueTipoLicencia.Properties.NullText = ""
        lueTipoLicencia.Properties.PopupWidth = 400
        lueTipoLicencia.Properties.ValueMember = "TIPO_LICENCIA_MEDICA_ID"

        With rluTipoLicencia
            With .Columns
                .Add(New LookUpColumnInfo("TIPO_LICENCIA_MEDICA_ID", "ID Tipo Licencia", 80, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        rluTipoLicencia.DataSource = repositorio.dvTipoLicencia
        rluTipoLicencia.DisplayMember = "DESCRIPCION"
        rluTipoLicencia.NullText = ""
        rluTipoLicencia.PopupWidth = 400
        rluTipoLicencia.ValueMember = "TIPO_LICENCIA_MEDICA_ID"
    End Sub

    Public Sub llenarRutEmpleado()
        gleRut.Properties.EditValueChangedFiringDelay = 1200
        gleRut.Properties.EditValueChangedFiringMode = EditValueChangedFiringMode.Buffered
        gleRut.Properties.ViewType = Repository.GridLookUpViewType.GridView
        gleRut.Properties.View.OptionsBehavior.AutoPopulateColumns = False
        gleRut.Properties.DataSource = repositorio.dvEmpleadoVista
        gleRut.Properties.DisplayMember = "RUT"

        Dim col1 As GridColumn = gleRut.Properties.View.Columns.AddField("RUT")
        col1.VisibleIndex = 0
        col1.Caption = "RUT"

        Dim col2 As GridColumn = gleRut.Properties.View.Columns.AddField("APELLIDO_PATERNO")
        col2.VisibleIndex = 1
        col2.Caption = "Apellido Paterno"

        Dim col3 As GridColumn = gleRut.Properties.View.Columns.AddField("APELLIDO_MATERNO")
        col3.VisibleIndex = 2
        col3.Caption = "Apellido Materno"

        Dim col4 As GridColumn = gleRut.Properties.View.Columns.AddField("NOMBRES")
        col4.VisibleIndex = 3
        col4.Caption = "Nombres"

        Dim col5 As GridColumn = gleRut.Properties.View.Columns.AddField("DESC_ESTADO")
        col5.VisibleIndex = 4
        col5.Caption = "Estado"

        Dim col6 As GridColumn = gleRut.Properties.View.Columns.AddField("DESC_CALIDAD_JURIDICA")
        col6.VisibleIndex = 5
        col6.Caption = "Calidad Jurídica"

        Dim col7 As GridColumn = gleRut.Properties.View.Columns.AddField("NOMBRE_COMPLETO")
        col7.VisibleIndex = 6
        col7.Caption = "Nombre Completo"
        col7.Visible = False

        gleRut.Properties.ValueMember = "EMPLEADO_ID"

        gleRut.Properties.View.BestFitColumns()
        gleRut.Properties.PopupFormWidth = 600

        gleRut.Text = ""
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim respuesta As Boolean = True
        If CType(txtNumeroLicencia.Text, Integer) = 0 Then
            txtNumeroLicencia.ErrorText = "Falta ingresar número de licencia"
            respuesta = False
        End If
        If CType(txtDiasLicencia.Text, Integer) = 0 Then
            txtDiasLicencia.ErrorText = "Falta ingresar cantidad de días que corresponde a licencia médica"
            respuesta = False
        End If
        If respuesta Then
            asignacionCampos()
            If empleado.datosLicenciaMedica.licenciaMedicaID = 0 Then
                Try
                    'Crear un nuevo registro de licencia medica
                    empleado.datosLicenciaMedica.periodoID = parametroMensual.ID
                    empleado.datosLicenciaMedica.rentaPromedioID = 0
                    empleado.datosLicenciaMedica.licenciaMedicaID = empleado.CrearEmpleadoLicenciaMedica()
                    gdcLicenciasMedicas.DataSource = empleado.dvDatosLicenciaMedica(empleado.ID)
                    limpiarControles()
                    MsgBox("El registro fue creado satisfactoriamente", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al crear el registro " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            Else
                Try
                    'Actualizar registro
                    empleado.datosLicenciaMedica.periodoID = idPeriodo
                    empleado.actualizarDatosLicenciaMedica(empleado.datosLicenciaMedica)
                    gdcLicenciasMedicas.DataSource = empleado.dvDatosLicenciaMedica(empleado.ID)
                    MsgBox("El registro fue actualizado satisfactoriamente", MsgBoxStyle.Information)
                    limpiarControles()
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al actualizar el registro " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
        End If
    End Sub
    Private Sub asignacionCampos()
        empleado.datosLicenciaMedica.numeroLicencia = txtNumeroLicencia.Text
        empleado.datosLicenciaMedica.tipoLicenciaID = lueTipoLicencia.EditValue
        empleado.datosLicenciaMedica.estadoLicencia = rdgEstadoLicencia.EditValue
        empleado.datosLicenciaMedica.fechaRecepcion = dteFechaRecepcion.Text
        empleado.datosLicenciaMedica.diasLicencia = CType(txtDiasLicencia.Text, Integer)
        empleado.datosLicenciaMedica.fechaInicio = dteFechaInicio.Text
        empleado.datosLicenciaMedica.fechaTermino = dteFechaTerminoLicencia.Text
        empleado.datosLicenciaMedica.tipoReposo = rdgTipoReposo.EditValue
        empleado.datosLicenciaMedica.lugarResposo = rdgLugarReposo.EditValue
        empleado.datosLicenciaMedica.continuidad = rdgContinuidad.EditValue
        empleado.datosLicenciaMedica.periodoID = 0
        If txtNumeroLicenciaContinuidad.Text = "" Then
            empleado.datosLicenciaMedica.numeroLicenciaContinuidad = ""
        Else
            empleado.datosLicenciaMedica.numeroLicenciaContinuidad = txtNumeroLicenciaContinuidad.Text
        End If

        If txtDiasContinuidad.Text = "" Then
            empleado.datosLicenciaMedica.diasContinuidad = 0
        Else
            empleado.datosLicenciaMedica.diasContinuidad = CType(txtDiasContinuidad.Text, Integer)
        End If

        empleado.datosLicenciaMedica.periodo = txtPeriodo.Text
        If dteFechaInicioContinuidad.Text = "" Then
            empleado.datosLicenciaMedica.fechaInicioContinuidad = CType("01-01-1900", Date)
        Else
            empleado.datosLicenciaMedica.fechaInicioContinuidad = dteFechaInicioContinuidad.Text
        End If
        If dteFechaTerminoContinuidad.Text = "" Then
            empleado.datosLicenciaMedica.fechaTerminoContinuidad = CType("01-01-1900", Date)
        Else
            empleado.datosLicenciaMedica.fechaTerminoContinuidad = dteFechaTerminoContinuidad.Text
        End If
        If dteFechaConcepcion.Text = "" Then
            empleado.datosLicenciaMedica.fechaConcepcion = CType("01-01-1900", Date)
        Else
            empleado.datosLicenciaMedica.fechaConcepcion = dteFechaConcepcion.Text
        End If

        empleado.datosLicenciaMedica.fechaEmision = CType("01-01-1900", Date)
     
        If dteFechaAccidente.Text = "" Then
            empleado.datosLicenciaMedica.fechaAccidente = CType("01-01-1900", Date)
        Else
            empleado.datosLicenciaMedica.fechaAccidente = dteFechaAccidente.Text
        End If
        If dteFechaEnvIsapre.Text = "" Then
            empleado.datosLicenciaMedica.fechaEnvioIsapre = CType("01-01-1900", Date)
        Else
            empleado.datosLicenciaMedica.fechaEnvioIsapre = dteFechaEnvIsapre.Text
        End If
        empleado.datosLicenciaMedica.nombreDoctor = txtNombreDoctor.Text
        empleado.datosLicenciaMedica.especialidad = txtEspecialidad.Text
        'If rdgEstadoLicencia.SelectedIndex = 0 Then
        empleado.datosLicenciaMedica.numeroCheque = ""
        empleado.datosLicenciaMedica.montoCheque = 0
        empleado.datosLicenciaMedica.momorandum = ""
        empleado.datosLicenciaMedica.observaciones = ""
        empleado.datosLicenciaMedica.fechaDigitacionPago = CType("01-01-1900", Date)
        'End If

        If dteFechaRecepIsapre.Text = "" Then
            empleado.datosLicenciaMedica.fechaRecepcionIsapre = CType("01-01-1900", Date)
        Else
            empleado.datosLicenciaMedica.fechaRecepcionIsapre = dteFechaRecepIsapre.Text
        End If

        empleado.datosLicenciaMedica.numeroFolio = Me.txtNumeroFolio.EditValue

        If rdgClasificacion.EditValue = 0 Then
            empleado.datosLicenciaMedica.clasificacion = 1
        ElseIf rdgClasificacion.EditValue = 1 Then
            empleado.datosLicenciaMedica.clasificacion = 2
        ElseIf rdgClasificacion.EditValue = 2 Then
            empleado.datosLicenciaMedica.clasificacion = 3
        End If

        empleado.datosLicenciaMedica.diasReduccion = CType(txtDiasReduccion.Text, Integer)

        If Me.dteFechaEstimadaPago.Text = "" Then
            empleado.datosLicenciaMedica.fechaEstimadaPago = CType("01-01-1900", Date)
        Else
            empleado.datosLicenciaMedica.fechaEstimadaPago = dteFechaEstimadaPago.Text
        End If
        empleado.datosLicenciaMedica.causaRechaziId = Me.lueCausaRechazo.EditValue
        empleado.datosLicenciaMedica.tipoProfesional = Me.rdgTipoProfesional.EditValue

    End Sub

    Private Sub gdvDetalleLicenciasMedicas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gdvDetalleLicenciasMedicas.DoubleClick
        'Traspasa desde la grilla a hacia los controles
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        empleado.datosLicenciaMedica.licenciaMedicaID = view.GetRowCellValue(view.FocusedRowHandle, "LICENCIA_MEDICA_ID")
        txtPeriodo.Text = view.GetRowCellValue(view.FocusedRowHandle, "PERIODO")
        lueTipoLicencia.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "TIPO_LICENCIA_MEDICA_ID")
        dteFechaInicio.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_INICIO")
        txtDiasLicencia.Text = view.GetRowCellValue(view.FocusedRowHandle, "DIAS_LICENCIA")
        dteFechaTerminoLicencia.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_TERMINO")
        txtNumeroLicencia.Text = view.GetRowCellValue(view.FocusedRowHandle, "NUMERO_LICENCIA")
        dteFechaRecepcion.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_RECEPCION")
        rdgEstadoLicencia.SelectedIndex = view.GetRowCellValue(view.FocusedRowHandle, "ESTADO_LICENCIA")
        If view.GetRowCellValue(view.FocusedRowHandle, "FECHA_ACCIDENTE") = "01-01-1900" Then
            dteFechaAccidente.EditValue = ""
        Else
            dteFechaAccidente.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_ACCIDENTE")
        End If
        If view.GetRowCellValue(view.FocusedRowHandle, "FECHA_EMISION") = "01-01-1900" Then
            dteFechaEstimadaPago.EditValue = ""
        Else
            dteFechaEstimadaPago.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_EMISION")
        End If
        If view.GetRowCellValue(view.FocusedRowHandle, "TIPO_REPOSO") Then
            rdgTipoReposo.EditValue = 1
        Else
            rdgTipoReposo.EditValue = 0
        End If
        rdgLugarReposo.SelectedIndex = view.GetRowCellValue(view.FocusedRowHandle, "LUGAR_REPOSO")
        If view.GetRowCellValue(view.FocusedRowHandle, "FECHA_ENVIO_ISAPRE") = "01-01-1900" Then
            dteFechaEnvIsapre.EditValue = ""
        Else
            dteFechaEnvIsapre.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_ENVIO_ISAPRE")
        End If
        If view.GetRowCellValue(view.FocusedRowHandle, "CONTINUIDAD") Then
            rdgContinuidad.EditValue = 1
        Else
            rdgContinuidad.EditValue = 0
        End If
        txtNumeroLicenciaContinuidad.Text = view.GetRowCellValue(view.FocusedRowHandle, "NUMERO_LICENCIA_CONTINUIDAD")
        If view.GetRowCellValue(view.FocusedRowHandle, "FECHA_INICIO_CONTINUIDAD") = "01-01-1900" Then
            dteFechaInicioContinuidad.EditValue = ""
        Else
            dteFechaInicioContinuidad.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_INICIO_CONTINUIDAD")
        End If
        txtDiasContinuidad.Text = view.GetRowCellValue(view.FocusedRowHandle, "DIAS_CONTINUIDAD")
        If view.GetRowCellValue(view.FocusedRowHandle, "FECHA_TERMINO_CONTINUIDAD") = "01-01-1900" Then
            dteFechaTerminoContinuidad.EditValue = ""
        Else
            dteFechaTerminoContinuidad.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_TERMINO_CONTINUIDAD")
        End If
        If view.GetRowCellValue(view.FocusedRowHandle, "FECHA_CONCEPCION") = "01-01-1900" Then
            dteFechaConcepcion.EditValue = ""
        Else
            dteFechaConcepcion.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_CONCEPCION")
        End If
        txtNombreDoctor.Text = view.GetRowCellValue(view.FocusedRowHandle, "NOMBRE_DOCTOR")
        txtEspecialidad.Text = view.GetRowCellValue(view.FocusedRowHandle, "ESPECIALIDAD")

        If view.GetRowCellValue(view.FocusedRowHandle, "FECHA_RECEPCION_ISAPRE") = "01-01-1900" Then
            dteFechaRecepIsapre.EditValue = ""
        Else
            dteFechaRecepIsapre.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_RECEPCION_ISAPRE")
        End If

        txtNumeroFolio.Text = view.GetRowCellValue(view.FocusedRowHandle, "NUMERO_FILIO")
        txtDiasReduccion.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "DIAS_REDUCCION")

        If view.GetRowCellValue(view.FocusedRowHandle, "FECHA_ESTIMADA_PAGO") = "01-01-1900" Then
            dteFechaEstimadaPago.EditValue = ""
        Else
            dteFechaEstimadaPago.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_ESTIMADA_PAGO")
        End If

        Me.lueCausaRechazo.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "CAUSA_RECHAZO_ID")
        Me.rdgTipoProfesional.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "TIPO_PROFESIONAL")

        If view.GetRowCellValue(view.FocusedRowHandle, "CLASIFICACION") = 1 Then
            rdgClasificacion.SelectedIndex = 0
        ElseIf view.GetRowCellValue(view.FocusedRowHandle, "CLASIFICACION") = 2 Then
            rdgClasificacion.SelectedIndex = 1
        ElseIf view.GetRowCellValue(view.FocusedRowHandle, "CLASIFICACION") = 3 Then
            rdgClasificacion.SelectedIndex = 2
        End If

        If view.GetRowCellValue(view.FocusedRowHandle, "ESTADO_LICENCIA") = 1 Then
            btnGuardar.Enabled = True
            empleado.datosLicenciaMedica.numeroCheque = view.GetRowCellValue(view.FocusedRowHandle, "NUMERO_CHEQUE")
            empleado.datosLicenciaMedica.montoCheque = view.GetRowCellValue(view.FocusedRowHandle, "MONTO_CHEQUE")
            empleado.datosLicenciaMedica.momorandum = view.GetRowCellValue(view.FocusedRowHandle, "MEMORANDUM")
            empleado.datosLicenciaMedica.observaciones = view.GetRowCellValue(view.FocusedRowHandle, "OBSERVACIONES")
            empleado.datosLicenciaMedica.fechaDigitacionPago = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_DIGITACION_PAGO")
        Else
            btnGuardar.Enabled = True
        End If
        idPeriodo = view.GetRowCellValue(view.FocusedRowHandle, "PERIODO_ID")
        idRentaPromedio = view.GetRowCellValue(view.FocusedRowHandle, "RENTA_PROMEDIO_ID")
        btnNuevo.Enabled = False
        btnDetalldelPago.Enabled = True
        btnRentaUltimosTresMeses.Enabled = True
        habilitaGrupoControles()
    End Sub
    Public Sub limpiarControles()
        txtPeriodo.Text = ""
        lueTipoLicencia.ItemIndex = -1
        dteFechaInicio.EditValue = ""
        txtDiasLicencia.EditValue = 0
        dteFechaTerminoLicencia.EditValue = ""
        txtNumeroLicencia.Text = ""
        dteFechaRecepcion.EditValue = ""
        rdgEstadoLicencia.SelectedIndex = -1
        dteFechaAccidente.EditValue = ""
        dteFechaEstimadaPago.EditValue = ""
        rdgTipoReposo.EditValue = -1
        rdgLugarReposo.SelectedIndex = -1
        dteFechaEnvIsapre.EditValue = ""
        rdgContinuidad.EditValue = -1
        txtNumeroLicenciaContinuidad.Text = ""
        dteFechaInicioContinuidad.EditValue = ""
        txtDiasContinuidad.Text = ""
        dteFechaTerminoContinuidad.EditValue = ""
        dteFechaConcepcion.EditValue = ""
        txtNombreDoctor.Text = ""
        txtEspecialidad.Text = ""
        btnGuardar.Enabled = False
        btnNuevo.Enabled = True
        btnDetalldelPago.Enabled = False
        deshabilitaGrupoControles()
        gdcLicenciasMedicas.Enabled = True
        btnRentaUltimosTresMeses.Enabled = False
        txtNumeroFolio.EditValue = ""
        dteFechaRecepIsapre.EditValue = ""
        rdgClasificacion.EditValue = 0
        txtDiasReduccion.EditValue = 0

    End Sub
    Private Sub txtDiasLicencia_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDiasLicencia.Validating
        If txtDiasLicencia.Text <> "" Then
            Dim fechaTermino As Date
            Dim mensaje As String
            Dim respuesta As Boolean = True
            fechaTermino = Comun.Funciones.FechaFinal.Valida(dteFechaInicio.EditValue, txtDiasLicencia.Text)
            mensaje = Funciones.FechaFinal.ValidaFechaDisponible(empleado.ID, dteFechaInicio.EditValue, fechaTermino)
            If Len(mensaje) > 3 Then
                If MsgBox(mensaje & "¿Desea continuar?", MsgBoxStyle.YesNo, "Advertencia") = MsgBoxResult.No Then
                    respuesta = True
                End If
            End If
            If respuesta Then
                dteFechaTerminoLicencia.EditValue = Comun.Funciones.FechaFinal.Valida(dteFechaInicio.EditValue, txtDiasLicencia.Text)
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub dteFechaInicio_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dteFechaInicio.Validating
        If txtDiasLicencia.Text <> "" Then
            dteFechaTerminoLicencia.EditValue = Comun.Funciones.FechaFinal.Valida(dteFechaInicio.EditValue, txtDiasLicencia.Text)
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        limpiarControles()
        habilitaBotones()
        rdgEstadoLicencia.SelectedIndex = 0
        rdgContinuidad.SelectedIndex = 1
        rdgLugarReposo.SelectedIndex = 0
        rdgTipoReposo.SelectedIndex = 0
        empleado.datosLicenciaMedica.licenciaMedicaID = 0
        dteFechaRecepcion.EditValue = Date.Today
        dteFechaInicio.EditValue = Date.Today
        txtPeriodo.Text = parametroMensual.anoMes
        btnGuardar.Enabled = True
        txtNumeroLicenciaContinuidad.Properties.ReadOnly = True
        habilitaGrupoControles()
        btnRentaUltimosTresMeses.Enabled = False
        txtNumeroLicencia.Focus()
    End Sub
    Private Sub habilitaBotones()
        btnGuardar.Enabled = False
        btnDetalldelPago.Enabled = False
        If gdvDetalleLicenciasMedicas.RowCount = 0 Then
            btnRentaUltimosTresMeses.Enabled = False
        Else
            gdcLicenciasMedicas.Enabled = True
            btnRentaUltimosTresMeses.Enabled = False
        End If
    End Sub

    Private Sub gdvDetalleLicenciasMedicas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvDetalleLicenciasMedicas.KeyDown
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        If (e.KeyCode = Keys.Delete) Then
            If view.GetRowCellValue(view.FocusedRowHandle, view.Columns(10)) = 1 Then
                MessageBox.Show("No puede eliminar el registro seleccionado. El estado es pagado", "Aviso", MessageBoxButtons.OK)
            Else
                If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    Dim valor_id As Integer
                    Try
                        valor_id = view.GetRowCellValue(view.FocusedRowHandle, view.Columns(0))
                        If empleado.EliminarEmpleadoLicenciaMedica(valor_id) = True Then
                            gdcLicenciasMedicas.DataSource = empleado.dvDatosLicenciaMedica(empleado.ID)
                            habilitaBotones()
                            limpiarControles()
                            MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)
                        Else
                            MsgBox("Registro no pudo ser eliminado", MsgBoxStyle.Exclamation)
                        End If
                    Catch ex As Exception
                        MsgBox("Ha ocurrido un error al intentar eliminar el registro " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                End If
            End If
        End If

    End Sub
    Private Sub deshabilitaGrupoControles()
        lycDatosLicenciaMedica.Enabled = False
        lycReposo.Enabled = False
        lycFechasVarias.Enabled = False
        lycLicenciaMedicaContinuidad.Enabled = False
        lycDatosDoctor.Enabled = False
        gdcLicenciasMedicas.Enabled = False
    End Sub
    Private Sub habilitaGrupoControles()
        lycDatosLicenciaMedica.Enabled = True
        lycReposo.Enabled = True
        lycFechasVarias.Enabled = True
        lycLicenciaMedicaContinuidad.Enabled = True
        lycDatosDoctor.Enabled = True
        gdcLicenciasMedicas.Enabled = True
    End Sub
    Private Sub rdgContinuidad_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdgContinuidad.EditValueChanged
        If rdgContinuidad.SelectedIndex = 0 Then
            txtNumeroLicenciaContinuidad.Properties.ReadOnly = False
            txtNumeroLicenciaContinuidad.Focus()
        Else
            txtNumeroLicenciaContinuidad.Text = ""
            dteFechaInicioContinuidad.EditValue = ""
            txtDiasContinuidad.Text = ""
            dteFechaTerminoContinuidad.EditValue = ""
            txtNumeroLicenciaContinuidad.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub txtNumeroLicenciaContinuidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNumeroLicenciaContinuidad.Validating
        If txtNumeroLicenciaContinuidad.Text = "" Then
            txtNumeroLicenciaContinuidad.ErrorText = "No ha ingresado número de licencia médica continuidad"
            e.Cancel = False
        Else
            If txtNumeroLicenciaContinuidad.Text = txtNumeroLicencia.Text Then
                txtNumeroLicenciaContinuidad.ErrorText = "Licencia médica continuidad no puede ser igual al número de licencia actual"
                e.Cancel = False
            Else
                If empleado.recuperarNumeroLicenciaEmpleado(txtNumeroLicenciaContinuidad.Text) Then
                    dteFechaInicioContinuidad.EditValue = empleado.datosLicenciaMedica.fechaInicioContinuidad
                    txtDiasContinuidad.Text = empleado.datosLicenciaMedica.diasContinuidad
                    dteFechaTerminoContinuidad.EditValue = empleado.datosLicenciaMedica.fechaTerminoContinuidad
                Else
                    txtNumeroLicenciaContinuidad.ErrorText = "No existe número de licencia médica continuidad"
                    e.Cancel = False
                    'rdgContinuidad.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub txtNumeroLicencia_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNumeroLicencia.Validating
        If CType(txtNumeroLicencia.Text, Integer) > 0 Then
            If empleado.recuperarNumeroLicenciaEmpleado(txtNumeroLicencia.Text) And empleado.datosLicenciaMedica.licenciaMedicaID <> empleado.datosLicenciaMedica.licenciaMedicaIDOld Then
                txtNumeroLicencia.ErrorText = "Ya existe número de licencia médica"
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnDetalldelPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalldelPago.Click
        'En las siguientes tres líneas se obtiene el valor de una columna del control lookupedit 
        Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(lueTipoLicencia, DevExpress.XtraEditors.LookUpEdit)
        Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
        Dim nombreTipoLicencia As Object = row("DESCRIPCION")

        Try
            asignacionCampos()
            frmPagoLicenciaMedica.DefInstance.tipoLicencia = nombreTipoLicencia
            frmPagoLicenciaMedica.DefInstance.empleadoLicMed = empleado
            frmPagoLicenciaMedica.DefInstance.Owner = Me
            If frmPagoLicenciaMedica.DefInstance.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido al intentar carga el formulario pago licencia" & " " & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            If frmPagoLicenciaMedica.DefInstance.retorno Then
                gdcLicenciasMedicas.DataSource = empleado.dvDatosLicenciaMedica(empleado.ID)
                limpiarControles()
            End If
        End Try

    End Sub
    Private Sub gleRut_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gleRut.EditValueChanged
        Cursor.Current = Cursors.WaitCursor
        If IsNumeric(gleRut.EditValue) Then
            Try
                If IsNumeric(gleRut.EditValue) Then
                    parametroMensual = New PERIODO
                    empleado = New empleado(CType(gleRut.EditValue, Long))
                    txtNombreEmpleado.Text = empleado.nombreCompleto
                    gdcLicenciasMedicas.DataSource = empleado.dvDatosLicenciaMedica(empleado.ID)
                    habilitaBotones()
                    btnNuevo.Enabled = True
                End If
            Catch exp As Exception
                MessageBox.Show("Atención: " & exp.Message, "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub btnRentaUltimosTresMeses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRentaUltimosTresMeses.Click
        ProcesaUltimasRentas()
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptInformeCalculoLicenciaMedica
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        Dim strFormulaSeleccion As String = "{VW_RENTA_PROMEDIO_LICENCIA_MEDICA_DETALLE.LICENCIA_MEDICA_ID}=" & empleado.datosLicenciaMedica.licenciaMedicaID
        ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
        ventanaReporte1.rptVisor.ShowParameterPanelButton = False
        ventanaReporte1.rptVisor.ShowCloseButton = False
        ventanaReporte1.rptVisor.ShowGroupTreeButton = True
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.Show()
    End Sub

    Private Sub btnRentaUltimosSeisMeses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ProcesaUltimasRentas()
    End Sub

    Private Sub txtDiasReduccion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDiasReduccion.Validating
        If CType(txtDiasReduccion.EditValue, Integer) > CType(txtDiasLicencia.EditValue, Integer) Then
            txtDiasReduccion.ErrorText = "El valor NO puede ser mayor a Días Licencia Médica"
            e.Cancel = True
        End If
    End Sub

    Private Sub ProcesaUltimasRentas()
        Try
            asignacionCampos()
            empleado.datosLicenciaMedica.periodoID = idPeriodo
            empleado.CrearRentaPromedioEmpleadoLicMedica(empleado.datosLicenciaMedica.licenciaMedicaID)
            empleado.datosLicenciaMedica.rentaPromedioID = idRentaPromedio
            empleado.actualizarDatosLicenciaMedica(empleado.datosLicenciaMedica)
            gdcLicenciasMedicas.DataSource = empleado.dvDatosLicenciaMedica(empleado.ID)
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al generar renta promedio." & Chr(13) & ex.Message, "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



End Class
