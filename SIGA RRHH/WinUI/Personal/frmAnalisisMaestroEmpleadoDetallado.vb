Imports cl.presidencia.Argo.BusinessRules
Imports DevExpress.XtraEditors.Controls


Public Class frmAnalisisMaestroEmpleadoDetallado
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
    Friend WithEvents pgcAnalisisMaestroEmpleado As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldNOMBRE_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents filedMES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTADO_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDOMICILIO_PARTICULAR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldVILLA_POBLACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTELEFONO_PARTICULAR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCELULAR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldREGION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCIUDAD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCOMUNA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_NACIMIENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMES_NACIMIENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEDAD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSEXO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTADO_CIVIL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNIVEL_ESTUDIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCONTACTO_EMERGENCIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGRUPO_SANGUINEO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldALERGICO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSUFRE_ENFERMEDAD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMEDICAMENTOS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCALIDAD_JURIDICA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCLASIFICACION_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGRADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTAMENTO_RRHH As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTAMENTO_DIPRES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESCALAFON As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDEPARTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDIRECCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTIPO_MOVIMIENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANO_ING_INSTITUCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMES_ING_INSTITUCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANOS_SERVICIO_EN_INSTITUCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_ING_INSTITUCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_ING_ADMIN_PUBLICA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_ING_CALIDAD_JURIDICA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_ING_ESTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_ING_GRADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_ING_ESCALAFON As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_ING_DEPTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCANTIDAD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sfdAnalisisMaestroEmpleadoDetallado As System.Windows.Forms.SaveFileDialog
    Friend WithEvents fieldFUNCIONES_DESEMPENADAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTITULO_PROFESIONAL_EXPERTIZ As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_ING_SISTEMA_PREVIS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_SISTEMA_PREVISIONAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAFP As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_AFILIACION_AFP As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMONTO_AHORRO_AFP As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldUNIDAD_MONTO_AHORRO_AFP As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldISAPRE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_SISTEMA_SALUD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_AFILIACION_ISAPRE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPLAN_PACTADO_SALUD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldUNIDAD_PLAN_PACTADO_SALUD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPLAN_COMPLEMENTARIO_ISAPRE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldUNIDAD_PLAN_COMPLEMENTARIO_ISAPRE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMONTO_PLAN_AUGE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldUNIDAD_MONTO_PLAN_AUGE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTIPO_TRABAJADOR_PREVIRED As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFONDO_BIENESTAR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldASOCIACION_GREMIAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFORMA_PAGO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTIPO_CUENTA_BANCO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBANCO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNRO_CUENTA_BANCO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNUMERO_BIENIOS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_CUMPLIO_BIENIOS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTRAMO_ASIGNACION_FAMILIAR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCARGAS_FAM_NORMALES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCARGAS_FAM_INVALIDAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCARGAS_FAM_PRENATAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAPELLIDO_PATERNO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAPELLIDO_MATERNO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRUT_DV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRENTA_BRUTA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents gpcSeleccionAño As DevExpress.XtraEditors.GroupControl
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents fieldSUB_DEPTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_JEFE_EVALUADOR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_EVALUADOR_DESEMPENO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_JEFE_DIRECTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldASIGNA_EVALUACION_DESEMPENO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents txtMesInicial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMesFinal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMesInicio As System.Windows.Forms.Label
    Friend WithEvents lblMesFinal As System.Windows.Forms.Label
    Friend WithEvents chkSoloEmpleadoActivos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents fieldTIENE_ASIGNACION_PROFESIONAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents btnGenerar As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.pgcAnalisisMaestroEmpleado = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldANO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.filedMES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldESTADO_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRE_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRUT_DV = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDOMICILIO_PARTICULAR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldVILLA_POBLACION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTELEFONO_PARTICULAR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCELULAR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldREGION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCIUDAD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCOMUNA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHA_NACIMIENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMES_NACIMIENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEDAD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSEXO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldESTADO_CIVIL = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNIVEL_ESTUDIO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCONTACTO_EMERGENCIA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldGRUPO_SANGUINEO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldALERGICO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSUFRE_ENFERMEDAD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMEDICAMENTOS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAPELLIDO_PATERNO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAPELLIDO_MATERNO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRUT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDV = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCALIDAD_JURIDICA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCLASIFICACION_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldGRADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldESTAMENTO_RRHH = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldESTAMENTO_DIPRES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldESCALAFON = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDEPARTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDIRECCION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTIPO_MOVIMIENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldANO_ING_INSTITUCION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMES_ING_INSTITUCION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldANOS_SERVICIO_EN_INSTITUCION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHA_ING_INSTITUCION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHA_ING_ADMIN_PUBLICA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHA_ING_CALIDAD_JURIDICA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHA_ING_ESTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHA_ING_GRADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHA_ING_ESCALAFON = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHA_ING_DEPTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCANTIDAD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFUNCIONES_DESEMPENADAS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTITULO_PROFESIONAL_EXPERTIZ = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRE_JEFE_DIRECTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRE_EVALUADOR_DESEMPENO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRE_JEFE_EVALUADOR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldASIGNA_EVALUACION_DESEMPENO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHA_ING_SISTEMA_PREVIS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRE_SISTEMA_PREVISIONAL = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAFP = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHA_AFILIACION_AFP = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMONTO_AHORRO_AFP = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldUNIDAD_MONTO_AHORRO_AFP = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldISAPRE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRE_SISTEMA_SALUD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHA_AFILIACION_ISAPRE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPLAN_PACTADO_SALUD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldUNIDAD_PLAN_PACTADO_SALUD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPLAN_COMPLEMENTARIO_ISAPRE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldUNIDAD_PLAN_COMPLEMENTARIO_ISAPRE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMONTO_PLAN_AUGE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldUNIDAD_MONTO_PLAN_AUGE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTIPO_TRABAJADOR_PREVIRED = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFONDO_BIENESTAR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldASOCIACION_GREMIAL = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFORMA_PAGO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTIPO_CUENTA_BANCO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBANCO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNRO_CUENTA_BANCO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNUMERO_BIENIOS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHA_CUMPLIO_BIENIOS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTRAMO_ASIGNACION_FAMILIAR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCARGAS_FAM_NORMALES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCARGAS_FAM_INVALIDAS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCARGAS_FAM_PRENATAL = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRENTA_BRUTA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSUB_DEPTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.sfdAnalisisMaestroEmpleadoDetallado = New System.Windows.Forms.SaveFileDialog()
        Me.gpcSeleccionAño = New DevExpress.XtraEditors.GroupControl()
        Me.chkSoloEmpleadoActivos = New DevExpress.XtraEditors.CheckEdit()
        Me.btnGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.lblMesFinal = New System.Windows.Forms.Label()
        Me.lblMesInicio = New System.Windows.Forms.Label()
        Me.txtMesFinal = New DevExpress.XtraEditors.TextEdit()
        Me.txtMesInicial = New DevExpress.XtraEditors.TextEdit()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.fieldTIENE_ASIGNACION_PROFESIONAL = New DevExpress.XtraPivotGrid.PivotGridField()
        CType(Me.pgcAnalisisMaestroEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionAño.SuspendLayout()
        CType(Me.chkSoloEmpleadoActivos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMesFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMesInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pgcAnalisisMaestroEmpleado
        '
        Me.pgcAnalisisMaestroEmpleado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgcAnalisisMaestroEmpleado.Cursor = System.Windows.Forms.Cursors.Default
        Me.pgcAnalisisMaestroEmpleado.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldANO, Me.filedMES, Me.fieldESTADO_EMPLEADO, Me.fieldNOMBRE_EMPLEADO, Me.fieldRUT_DV, Me.fieldDOMICILIO_PARTICULAR, Me.fieldVILLA_POBLACION, Me.fieldTELEFONO_PARTICULAR, Me.fieldCELULAR, Me.fieldREGION, Me.fieldCIUDAD, Me.fieldCOMUNA, Me.fieldFECHA_NACIMIENTO, Me.fieldMES_NACIMIENTO, Me.fieldEDAD, Me.fieldSEXO, Me.fieldESTADO_CIVIL, Me.fieldNIVEL_ESTUDIO, Me.fieldCONTACTO_EMERGENCIA, Me.fieldGRUPO_SANGUINEO, Me.fieldALERGICO, Me.fieldSUFRE_ENFERMEDAD, Me.fieldMEDICAMENTOS, Me.fieldAPELLIDO_PATERNO, Me.fieldAPELLIDO_MATERNO, Me.fieldNOMBRES, Me.fieldRUT, Me.fieldDV, Me.fieldCALIDAD_JURIDICA, Me.fieldCLASIFICACION_EMPLEADO, Me.fieldGRADO, Me.fieldESTAMENTO_RRHH, Me.fieldESTAMENTO_DIPRES, Me.fieldESCALAFON, Me.fieldDEPARTAMENTO, Me.fieldDIRECCION, Me.fieldTIPO_MOVIMIENTO, Me.fieldANO_ING_INSTITUCION, Me.fieldMES_ING_INSTITUCION, Me.fieldANOS_SERVICIO_EN_INSTITUCION, Me.fieldFECHA_ING_INSTITUCION, Me.fieldFECHA_ING_ADMIN_PUBLICA, Me.fieldFECHA_ING_CALIDAD_JURIDICA, Me.fieldFECHA_ING_ESTAMENTO, Me.fieldFECHA_ING_GRADO, Me.fieldFECHA_ING_ESCALAFON, Me.fieldFECHA_ING_DEPTO, Me.fieldCANTIDAD, Me.fieldFUNCIONES_DESEMPENADAS, Me.fieldTITULO_PROFESIONAL_EXPERTIZ, Me.fieldNOMBRE_JEFE_DIRECTO, Me.fieldNOMBRE_EVALUADOR_DESEMPENO, Me.fieldNOMBRE_JEFE_EVALUADOR, Me.fieldASIGNA_EVALUACION_DESEMPENO, Me.fieldFECHA_ING_SISTEMA_PREVIS, Me.fieldNOMBRE_SISTEMA_PREVISIONAL, Me.fieldAFP, Me.fieldFECHA_AFILIACION_AFP, Me.fieldMONTO_AHORRO_AFP, Me.fieldUNIDAD_MONTO_AHORRO_AFP, Me.fieldISAPRE, Me.fieldNOMBRE_SISTEMA_SALUD, Me.fieldFECHA_AFILIACION_ISAPRE, Me.fieldPLAN_PACTADO_SALUD, Me.fieldUNIDAD_PLAN_PACTADO_SALUD, Me.fieldPLAN_COMPLEMENTARIO_ISAPRE, Me.fieldUNIDAD_PLAN_COMPLEMENTARIO_ISAPRE, Me.fieldMONTO_PLAN_AUGE, Me.fieldUNIDAD_MONTO_PLAN_AUGE, Me.fieldTIPO_TRABAJADOR_PREVIRED, Me.fieldFONDO_BIENESTAR, Me.fieldASOCIACION_GREMIAL, Me.fieldFORMA_PAGO, Me.fieldTIPO_CUENTA_BANCO, Me.fieldBANCO, Me.fieldNRO_CUENTA_BANCO, Me.fieldNUMERO_BIENIOS, Me.fieldFECHA_CUMPLIO_BIENIOS, Me.fieldTRAMO_ASIGNACION_FAMILIAR, Me.fieldCARGAS_FAM_NORMALES, Me.fieldCARGAS_FAM_INVALIDAS, Me.fieldCARGAS_FAM_PRENATAL, Me.fieldRENTA_BRUTA, Me.fieldSUB_DEPTO, Me.fieldTIENE_ASIGNACION_PROFESIONAL})
        Me.pgcAnalisisMaestroEmpleado.Location = New System.Drawing.Point(8, 147)
        Me.pgcAnalisisMaestroEmpleado.Name = "pgcAnalisisMaestroEmpleado"
        Me.pgcAnalisisMaestroEmpleado.OptionsBehavior.HorizontalScrolling = DevExpress.XtraPivotGrid.PivotGridScrolling.Control
        Me.pgcAnalisisMaestroEmpleado.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
        Me.pgcAnalisisMaestroEmpleado.OptionsSelection.EnableAppearanceFocusedCell = True
        Me.pgcAnalisisMaestroEmpleado.Size = New System.Drawing.Size(832, 429)
        Me.pgcAnalisisMaestroEmpleado.TabIndex = 12
        '
        'fieldANO
        '
        Me.fieldANO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldANO.AreaIndex = 0
        Me.fieldANO.Caption = "Año Proceso"
        Me.fieldANO.FieldName = "ANO"
        Me.fieldANO.Name = "fieldANO"
        Me.fieldANO.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'filedMES
        '
        Me.filedMES.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.filedMES.AreaIndex = 1
        Me.filedMES.Caption = "Mes Proceso"
        Me.filedMES.FieldName = "MES"
        Me.filedMES.Name = "filedMES"
        Me.filedMES.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'fieldESTADO_EMPLEADO
        '
        Me.fieldESTADO_EMPLEADO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldESTADO_EMPLEADO.AreaIndex = 2
        Me.fieldESTADO_EMPLEADO.Caption = "Estado Empleado"
        Me.fieldESTADO_EMPLEADO.FieldName = "ESTADO_EMPLEADO"
        Me.fieldESTADO_EMPLEADO.Name = "fieldESTADO_EMPLEADO"
        '
        'fieldNOMBRE_EMPLEADO
        '
        Me.fieldNOMBRE_EMPLEADO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNOMBRE_EMPLEADO.AreaIndex = 4
        Me.fieldNOMBRE_EMPLEADO.Caption = "Nombre Empleado"
        Me.fieldNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.Name = "fieldNOMBRE_EMPLEADO"
        '
        'fieldRUT_DV
        '
        Me.fieldRUT_DV.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldRUT_DV.AreaIndex = 5
        Me.fieldRUT_DV.Caption = "RUT y DV"
        Me.fieldRUT_DV.FieldName = "RUT_DV"
        Me.fieldRUT_DV.Name = "fieldRUT_DV"
        '
        'fieldDOMICILIO_PARTICULAR
        '
        Me.fieldDOMICILIO_PARTICULAR.AreaIndex = 0
        Me.fieldDOMICILIO_PARTICULAR.Caption = "Domicilio Particular"
        Me.fieldDOMICILIO_PARTICULAR.FieldName = "DOMICILIO_PARTICULAR"
        Me.fieldDOMICILIO_PARTICULAR.Name = "fieldDOMICILIO_PARTICULAR"
        '
        'fieldVILLA_POBLACION
        '
        Me.fieldVILLA_POBLACION.AreaIndex = 1
        Me.fieldVILLA_POBLACION.Caption = "Villa o Población"
        Me.fieldVILLA_POBLACION.FieldName = "VILLA_POBLACION"
        Me.fieldVILLA_POBLACION.Name = "fieldVILLA_POBLACION"
        '
        'fieldTELEFONO_PARTICULAR
        '
        Me.fieldTELEFONO_PARTICULAR.AreaIndex = 2
        Me.fieldTELEFONO_PARTICULAR.Caption = "Teléfono Particular"
        Me.fieldTELEFONO_PARTICULAR.FieldName = "TELEFONO_PARTICULAR"
        Me.fieldTELEFONO_PARTICULAR.Name = "fieldTELEFONO_PARTICULAR"
        '
        'fieldCELULAR
        '
        Me.fieldCELULAR.AreaIndex = 3
        Me.fieldCELULAR.Caption = "Celular"
        Me.fieldCELULAR.FieldName = "CELULAR"
        Me.fieldCELULAR.Name = "fieldCELULAR"
        '
        'fieldREGION
        '
        Me.fieldREGION.AreaIndex = 4
        Me.fieldREGION.Caption = "Región"
        Me.fieldREGION.FieldName = "REGION"
        Me.fieldREGION.Name = "fieldREGION"
        '
        'fieldCIUDAD
        '
        Me.fieldCIUDAD.AreaIndex = 6
        Me.fieldCIUDAD.Caption = "Ciudad"
        Me.fieldCIUDAD.FieldName = "CIUDAD"
        Me.fieldCIUDAD.Name = "fieldCIUDAD"
        '
        'fieldCOMUNA
        '
        Me.fieldCOMUNA.AreaIndex = 5
        Me.fieldCOMUNA.Caption = "Comuna"
        Me.fieldCOMUNA.FieldName = "COMUNA"
        Me.fieldCOMUNA.Name = "fieldCOMUNA"
        '
        'fieldFECHA_NACIMIENTO
        '
        Me.fieldFECHA_NACIMIENTO.AreaIndex = 7
        Me.fieldFECHA_NACIMIENTO.Caption = "Fecha Nacimiento"
        Me.fieldFECHA_NACIMIENTO.FieldName = "FECHA_NACIMIENTO"
        Me.fieldFECHA_NACIMIENTO.Name = "fieldFECHA_NACIMIENTO"
        '
        'fieldMES_NACIMIENTO
        '
        Me.fieldMES_NACIMIENTO.AreaIndex = 8
        Me.fieldMES_NACIMIENTO.Caption = "Mes Nacimiento"
        Me.fieldMES_NACIMIENTO.FieldName = "MES_NACIMIENTO"
        Me.fieldMES_NACIMIENTO.Name = "fieldMES_NACIMIENTO"
        '
        'fieldEDAD
        '
        Me.fieldEDAD.AreaIndex = 9
        Me.fieldEDAD.Caption = "Edad"
        Me.fieldEDAD.FieldName = "EDAD"
        Me.fieldEDAD.Name = "fieldEDAD"
        '
        'fieldSEXO
        '
        Me.fieldSEXO.AreaIndex = 11
        Me.fieldSEXO.Caption = "Sexo"
        Me.fieldSEXO.FieldName = "SEXO"
        Me.fieldSEXO.Name = "fieldSEXO"
        '
        'fieldESTADO_CIVIL
        '
        Me.fieldESTADO_CIVIL.AreaIndex = 10
        Me.fieldESTADO_CIVIL.Caption = "Estado Civil"
        Me.fieldESTADO_CIVIL.FieldName = "ESTADO_CIVIL"
        Me.fieldESTADO_CIVIL.Name = "fieldESTADO_CIVIL"
        '
        'fieldNIVEL_ESTUDIO
        '
        Me.fieldNIVEL_ESTUDIO.AreaIndex = 12
        Me.fieldNIVEL_ESTUDIO.Caption = "Nivel de Estudio"
        Me.fieldNIVEL_ESTUDIO.FieldName = "NIVEL_ESTUDIO"
        Me.fieldNIVEL_ESTUDIO.Name = "fieldNIVEL_ESTUDIO"
        '
        'fieldCONTACTO_EMERGENCIA
        '
        Me.fieldCONTACTO_EMERGENCIA.AreaIndex = 13
        Me.fieldCONTACTO_EMERGENCIA.Caption = "Contacto Emergencia"
        Me.fieldCONTACTO_EMERGENCIA.FieldName = "CONTACTO_EMERGENCIA"
        Me.fieldCONTACTO_EMERGENCIA.Name = "fieldCONTACTO_EMERGENCIA"
        '
        'fieldGRUPO_SANGUINEO
        '
        Me.fieldGRUPO_SANGUINEO.AreaIndex = 14
        Me.fieldGRUPO_SANGUINEO.Caption = "Grupo Sanguíneo"
        Me.fieldGRUPO_SANGUINEO.FieldName = "GRUPO_SANGUINEO"
        Me.fieldGRUPO_SANGUINEO.Name = "fieldGRUPO_SANGUINEO"
        '
        'fieldALERGICO
        '
        Me.fieldALERGICO.AreaIndex = 15
        Me.fieldALERGICO.Caption = "Alérgico"
        Me.fieldALERGICO.FieldName = "ALERGICO"
        Me.fieldALERGICO.Name = "fieldALERGICO"
        '
        'fieldSUFRE_ENFERMEDAD
        '
        Me.fieldSUFRE_ENFERMEDAD.AreaIndex = 16
        Me.fieldSUFRE_ENFERMEDAD.Caption = "Sufre Enfermedad"
        Me.fieldSUFRE_ENFERMEDAD.FieldName = "SUFRE_ENFERMEDAD"
        Me.fieldSUFRE_ENFERMEDAD.Name = "fieldSUFRE_ENFERMEDAD"
        '
        'fieldMEDICAMENTOS
        '
        Me.fieldMEDICAMENTOS.AreaIndex = 17
        Me.fieldMEDICAMENTOS.Caption = "Medicamentos"
        Me.fieldMEDICAMENTOS.FieldName = "MEDICAMENTOS"
        Me.fieldMEDICAMENTOS.Name = "fieldMEDICAMENTOS"
        '
        'fieldAPELLIDO_PATERNO
        '
        Me.fieldAPELLIDO_PATERNO.AreaIndex = 18
        Me.fieldAPELLIDO_PATERNO.Caption = "Apellido Paterno"
        Me.fieldAPELLIDO_PATERNO.FieldName = "APELLIDO_PATERNO"
        Me.fieldAPELLIDO_PATERNO.Name = "fieldAPELLIDO_PATERNO"
        '
        'fieldAPELLIDO_MATERNO
        '
        Me.fieldAPELLIDO_MATERNO.AreaIndex = 19
        Me.fieldAPELLIDO_MATERNO.Caption = "Apellido Materno"
        Me.fieldAPELLIDO_MATERNO.FieldName = "APELLIDO_MATERNO"
        Me.fieldAPELLIDO_MATERNO.Name = "fieldAPELLIDO_MATERNO"
        '
        'fieldNOMBRES
        '
        Me.fieldNOMBRES.AreaIndex = 20
        Me.fieldNOMBRES.Caption = "Nombre"
        Me.fieldNOMBRES.FieldName = "NOMBRES"
        Me.fieldNOMBRES.Name = "fieldNOMBRES"
        '
        'fieldRUT
        '
        Me.fieldRUT.AreaIndex = 21
        Me.fieldRUT.Caption = "Rut"
        Me.fieldRUT.FieldName = "RUT"
        Me.fieldRUT.Name = "fieldRUT"
        '
        'fieldDV
        '
        Me.fieldDV.AreaIndex = 22
        Me.fieldDV.Caption = "Dv"
        Me.fieldDV.FieldName = "DV"
        Me.fieldDV.Name = "fieldDV"
        '
        'fieldCALIDAD_JURIDICA
        '
        Me.fieldCALIDAD_JURIDICA.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldCALIDAD_JURIDICA.Appearance.Header.Options.UseForeColor = True
        Me.fieldCALIDAD_JURIDICA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCALIDAD_JURIDICA.AreaIndex = 3
        Me.fieldCALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.fieldCALIDAD_JURIDICA.FieldName = "CALIDAD_JURIDICA"
        Me.fieldCALIDAD_JURIDICA.Name = "fieldCALIDAD_JURIDICA"
        '
        'fieldCLASIFICACION_EMPLEADO
        '
        Me.fieldCLASIFICACION_EMPLEADO.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldCLASIFICACION_EMPLEADO.Appearance.Header.Options.UseForeColor = True
        Me.fieldCLASIFICACION_EMPLEADO.AreaIndex = 23
        Me.fieldCLASIFICACION_EMPLEADO.Caption = "Clasificación Empleado"
        Me.fieldCLASIFICACION_EMPLEADO.FieldName = "CLASIFICACION_EMPLEADO"
        Me.fieldCLASIFICACION_EMPLEADO.Name = "fieldCLASIFICACION_EMPLEADO"
        '
        'fieldGRADO
        '
        Me.fieldGRADO.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldGRADO.Appearance.Header.Options.UseForeColor = True
        Me.fieldGRADO.AreaIndex = 24
        Me.fieldGRADO.Caption = "Grado"
        Me.fieldGRADO.FieldName = "GRADO"
        Me.fieldGRADO.Name = "fieldGRADO"
        '
        'fieldESTAMENTO_RRHH
        '
        Me.fieldESTAMENTO_RRHH.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldESTAMENTO_RRHH.Appearance.Header.Options.UseForeColor = True
        Me.fieldESTAMENTO_RRHH.AreaIndex = 25
        Me.fieldESTAMENTO_RRHH.Caption = "Estamento RRHH"
        Me.fieldESTAMENTO_RRHH.FieldName = "ESTAMENTO_RRHH"
        Me.fieldESTAMENTO_RRHH.Name = "fieldESTAMENTO_RRHH"
        '
        'fieldESTAMENTO_DIPRES
        '
        Me.fieldESTAMENTO_DIPRES.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldESTAMENTO_DIPRES.Appearance.Header.Options.UseForeColor = True
        Me.fieldESTAMENTO_DIPRES.AreaIndex = 26
        Me.fieldESTAMENTO_DIPRES.Caption = "Estamento DIPRES"
        Me.fieldESTAMENTO_DIPRES.FieldName = "ESTAMENTO_DIPRES"
        Me.fieldESTAMENTO_DIPRES.Name = "fieldESTAMENTO_DIPRES"
        '
        'fieldESCALAFON
        '
        Me.fieldESCALAFON.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldESCALAFON.Appearance.Header.Options.UseForeColor = True
        Me.fieldESCALAFON.AreaIndex = 27
        Me.fieldESCALAFON.Caption = "Escalafón"
        Me.fieldESCALAFON.FieldName = "ESCALAFON"
        Me.fieldESCALAFON.Name = "fieldESCALAFON"
        '
        'fieldDEPARTAMENTO
        '
        Me.fieldDEPARTAMENTO.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldDEPARTAMENTO.Appearance.Header.Options.UseForeColor = True
        Me.fieldDEPARTAMENTO.AreaIndex = 29
        Me.fieldDEPARTAMENTO.Caption = "Departamento"
        Me.fieldDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.fieldDEPARTAMENTO.Name = "fieldDEPARTAMENTO"
        '
        'fieldDIRECCION
        '
        Me.fieldDIRECCION.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldDIRECCION.Appearance.Header.Options.UseForeColor = True
        Me.fieldDIRECCION.AreaIndex = 28
        Me.fieldDIRECCION.Caption = "Dirección"
        Me.fieldDIRECCION.FieldName = "DIRECCION"
        Me.fieldDIRECCION.Name = "fieldDIRECCION"
        '
        'fieldTIPO_MOVIMIENTO
        '
        Me.fieldTIPO_MOVIMIENTO.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldTIPO_MOVIMIENTO.Appearance.Header.Options.UseForeColor = True
        Me.fieldTIPO_MOVIMIENTO.AreaIndex = 31
        Me.fieldTIPO_MOVIMIENTO.Caption = "Tipo Movimiento"
        Me.fieldTIPO_MOVIMIENTO.FieldName = "TIPO_MOVIMIENTO"
        Me.fieldTIPO_MOVIMIENTO.Name = "fieldTIPO_MOVIMIENTO"
        '
        'fieldANO_ING_INSTITUCION
        '
        Me.fieldANO_ING_INSTITUCION.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldANO_ING_INSTITUCION.Appearance.Header.Options.UseForeColor = True
        Me.fieldANO_ING_INSTITUCION.AreaIndex = 32
        Me.fieldANO_ING_INSTITUCION.Caption = "Año Ing.Institución"
        Me.fieldANO_ING_INSTITUCION.FieldName = "ANO_ING_INSTITUCION"
        Me.fieldANO_ING_INSTITUCION.Name = "fieldANO_ING_INSTITUCION"
        '
        'fieldMES_ING_INSTITUCION
        '
        Me.fieldMES_ING_INSTITUCION.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldMES_ING_INSTITUCION.Appearance.Header.Options.UseForeColor = True
        Me.fieldMES_ING_INSTITUCION.AreaIndex = 33
        Me.fieldMES_ING_INSTITUCION.Caption = "Mes Ing.Institución"
        Me.fieldMES_ING_INSTITUCION.FieldName = "MES_ING_INSTITUCION"
        Me.fieldMES_ING_INSTITUCION.Name = "fieldMES_ING_INSTITUCION"
        '
        'fieldANOS_SERVICIO_EN_INSTITUCION
        '
        Me.fieldANOS_SERVICIO_EN_INSTITUCION.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldANOS_SERVICIO_EN_INSTITUCION.Appearance.Header.Options.UseForeColor = True
        Me.fieldANOS_SERVICIO_EN_INSTITUCION.AreaIndex = 34
        Me.fieldANOS_SERVICIO_EN_INSTITUCION.Caption = "Años de Servicio"
        Me.fieldANOS_SERVICIO_EN_INSTITUCION.FieldName = "ANOS_SERVICIO_EN_INSTITUCION"
        Me.fieldANOS_SERVICIO_EN_INSTITUCION.Name = "fieldANOS_SERVICIO_EN_INSTITUCION"
        '
        'fieldFECHA_ING_INSTITUCION
        '
        Me.fieldFECHA_ING_INSTITUCION.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldFECHA_ING_INSTITUCION.Appearance.Header.Options.UseForeColor = True
        Me.fieldFECHA_ING_INSTITUCION.AreaIndex = 35
        Me.fieldFECHA_ING_INSTITUCION.Caption = "Fecha Ing.Institución"
        Me.fieldFECHA_ING_INSTITUCION.CellFormat.FormatString = "d"
        Me.fieldFECHA_ING_INSTITUCION.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldFECHA_ING_INSTITUCION.FieldName = "FECHA_ING_INSTITUCION"
        Me.fieldFECHA_ING_INSTITUCION.Name = "fieldFECHA_ING_INSTITUCION"
        '
        'fieldFECHA_ING_ADMIN_PUBLICA
        '
        Me.fieldFECHA_ING_ADMIN_PUBLICA.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldFECHA_ING_ADMIN_PUBLICA.Appearance.Header.Options.UseForeColor = True
        Me.fieldFECHA_ING_ADMIN_PUBLICA.AreaIndex = 36
        Me.fieldFECHA_ING_ADMIN_PUBLICA.Caption = "Fecha Ing.Adm.Pública"
        Me.fieldFECHA_ING_ADMIN_PUBLICA.FieldName = "FECHA_ING_ADMIN_PUBLICA"
        Me.fieldFECHA_ING_ADMIN_PUBLICA.Name = "fieldFECHA_ING_ADMIN_PUBLICA"
        '
        'fieldFECHA_ING_CALIDAD_JURIDICA
        '
        Me.fieldFECHA_ING_CALIDAD_JURIDICA.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldFECHA_ING_CALIDAD_JURIDICA.Appearance.Header.Options.UseForeColor = True
        Me.fieldFECHA_ING_CALIDAD_JURIDICA.AreaIndex = 37
        Me.fieldFECHA_ING_CALIDAD_JURIDICA.Caption = "Fecha Ing.Calidad Jurídica"
        Me.fieldFECHA_ING_CALIDAD_JURIDICA.FieldName = "FECHA_ING_CALIDAD_JURIDICA"
        Me.fieldFECHA_ING_CALIDAD_JURIDICA.Name = "fieldFECHA_ING_CALIDAD_JURIDICA"
        '
        'fieldFECHA_ING_ESTAMENTO
        '
        Me.fieldFECHA_ING_ESTAMENTO.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldFECHA_ING_ESTAMENTO.Appearance.Header.Options.UseForeColor = True
        Me.fieldFECHA_ING_ESTAMENTO.AreaIndex = 38
        Me.fieldFECHA_ING_ESTAMENTO.Caption = "Fecha Ing.Estamento"
        Me.fieldFECHA_ING_ESTAMENTO.FieldName = "FECHA_ING_ESTAMENTO"
        Me.fieldFECHA_ING_ESTAMENTO.Name = "fieldFECHA_ING_ESTAMENTO"
        '
        'fieldFECHA_ING_GRADO
        '
        Me.fieldFECHA_ING_GRADO.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldFECHA_ING_GRADO.Appearance.Header.Options.UseForeColor = True
        Me.fieldFECHA_ING_GRADO.AreaIndex = 39
        Me.fieldFECHA_ING_GRADO.Caption = "Fecha Ing.Grado"
        Me.fieldFECHA_ING_GRADO.FieldName = "FECHA_ING_GRADO"
        Me.fieldFECHA_ING_GRADO.Name = "fieldFECHA_ING_GRADO"
        '
        'fieldFECHA_ING_ESCALAFON
        '
        Me.fieldFECHA_ING_ESCALAFON.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldFECHA_ING_ESCALAFON.Appearance.Header.Options.UseForeColor = True
        Me.fieldFECHA_ING_ESCALAFON.AreaIndex = 40
        Me.fieldFECHA_ING_ESCALAFON.Caption = "Fecha Ing.Escalafon"
        Me.fieldFECHA_ING_ESCALAFON.FieldName = "FECHA_ING_ESCALAFON"
        Me.fieldFECHA_ING_ESCALAFON.Name = "fieldFECHA_ING_ESCALAFON"
        '
        'fieldFECHA_ING_DEPTO
        '
        Me.fieldFECHA_ING_DEPTO.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldFECHA_ING_DEPTO.Appearance.Header.Options.UseForeColor = True
        Me.fieldFECHA_ING_DEPTO.AreaIndex = 41
        Me.fieldFECHA_ING_DEPTO.Caption = "Fecha Ing.Departamento"
        Me.fieldFECHA_ING_DEPTO.FieldName = "FECHA_ING_DEPTO"
        Me.fieldFECHA_ING_DEPTO.Name = "fieldFECHA_ING_DEPTO"
        '
        'fieldCANTIDAD
        '
        Me.fieldCANTIDAD.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCANTIDAD.AreaIndex = 0
        Me.fieldCANTIDAD.Caption = "Cantidad"
        Me.fieldCANTIDAD.FieldName = "CANTIDAD"
        Me.fieldCANTIDAD.Name = "fieldCANTIDAD"
        '
        'fieldFUNCIONES_DESEMPENADAS
        '
        Me.fieldFUNCIONES_DESEMPENADAS.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldFUNCIONES_DESEMPENADAS.Appearance.Header.Options.UseForeColor = True
        Me.fieldFUNCIONES_DESEMPENADAS.AreaIndex = 42
        Me.fieldFUNCIONES_DESEMPENADAS.Caption = "Funciiones Desempeñadas"
        Me.fieldFUNCIONES_DESEMPENADAS.FieldName = "FUNCIONES_DESEMPENADAS"
        Me.fieldFUNCIONES_DESEMPENADAS.Name = "fieldFUNCIONES_DESEMPENADAS"
        '
        'fieldTITULO_PROFESIONAL_EXPERTIZ
        '
        Me.fieldTITULO_PROFESIONAL_EXPERTIZ.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldTITULO_PROFESIONAL_EXPERTIZ.Appearance.Header.Options.UseForeColor = True
        Me.fieldTITULO_PROFESIONAL_EXPERTIZ.AreaIndex = 43
        Me.fieldTITULO_PROFESIONAL_EXPERTIZ.Caption = "Título Profesional/Expertiz"
        Me.fieldTITULO_PROFESIONAL_EXPERTIZ.FieldName = "TITULO_PROFESIONAL_EXPERTIZ"
        Me.fieldTITULO_PROFESIONAL_EXPERTIZ.Name = "fieldTITULO_PROFESIONAL_EXPERTIZ"
        '
        'fieldNOMBRE_JEFE_DIRECTO
        '
        Me.fieldNOMBRE_JEFE_DIRECTO.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldNOMBRE_JEFE_DIRECTO.Appearance.Header.Options.UseForeColor = True
        Me.fieldNOMBRE_JEFE_DIRECTO.AreaIndex = 44
        Me.fieldNOMBRE_JEFE_DIRECTO.Caption = "Nombre Jefe Directo"
        Me.fieldNOMBRE_JEFE_DIRECTO.FieldName = "NOMBRE_JEFE_DIRECTO"
        Me.fieldNOMBRE_JEFE_DIRECTO.Name = "fieldNOMBRE_JEFE_DIRECTO"
        '
        'fieldNOMBRE_EVALUADOR_DESEMPENO
        '
        Me.fieldNOMBRE_EVALUADOR_DESEMPENO.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldNOMBRE_EVALUADOR_DESEMPENO.Appearance.Header.Options.UseForeColor = True
        Me.fieldNOMBRE_EVALUADOR_DESEMPENO.AreaIndex = 46
        Me.fieldNOMBRE_EVALUADOR_DESEMPENO.Caption = "Nombre Evaluador Desempeño"
        Me.fieldNOMBRE_EVALUADOR_DESEMPENO.FieldName = "NOMBRE_EVALUADOR_DESEMPENO"
        Me.fieldNOMBRE_EVALUADOR_DESEMPENO.Name = "fieldNOMBRE_EVALUADOR_DESEMPENO"
        '
        'fieldNOMBRE_JEFE_EVALUADOR
        '
        Me.fieldNOMBRE_JEFE_EVALUADOR.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldNOMBRE_JEFE_EVALUADOR.Appearance.Header.Options.UseForeColor = True
        Me.fieldNOMBRE_JEFE_EVALUADOR.AreaIndex = 45
        Me.fieldNOMBRE_JEFE_EVALUADOR.Caption = "Nombre Jefe Evaluador"
        Me.fieldNOMBRE_JEFE_EVALUADOR.FieldName = "NOMBRE_JEFE_EVALUADOR"
        Me.fieldNOMBRE_JEFE_EVALUADOR.Name = "fieldNOMBRE_JEFE_EVALUADOR"
        '
        'fieldASIGNA_EVALUACION_DESEMPENO
        '
        Me.fieldASIGNA_EVALUACION_DESEMPENO.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldASIGNA_EVALUACION_DESEMPENO.Appearance.Header.Options.UseForeColor = True
        Me.fieldASIGNA_EVALUACION_DESEMPENO.AreaIndex = 47
        Me.fieldASIGNA_EVALUACION_DESEMPENO.Caption = "Incluir en Evaluación Desempeño"
        Me.fieldASIGNA_EVALUACION_DESEMPENO.FieldName = "ASIGNA_EVALUACION_DESEMPENO"
        Me.fieldASIGNA_EVALUACION_DESEMPENO.Name = "fieldASIGNA_EVALUACION_DESEMPENO"
        '
        'fieldFECHA_ING_SISTEMA_PREVIS
        '
        Me.fieldFECHA_ING_SISTEMA_PREVIS.Appearance.Header.ForeColor = System.Drawing.Color.Blue
        Me.fieldFECHA_ING_SISTEMA_PREVIS.Appearance.Header.Options.UseForeColor = True
        Me.fieldFECHA_ING_SISTEMA_PREVIS.AreaIndex = 48
        Me.fieldFECHA_ING_SISTEMA_PREVIS.Caption = "Fecha Ing.Sistema Prev."
        Me.fieldFECHA_ING_SISTEMA_PREVIS.FieldName = "FECHA_ING_SISTEMA_PREVIS"
        Me.fieldFECHA_ING_SISTEMA_PREVIS.Name = "fieldFECHA_ING_SISTEMA_PREVIS"
        '
        'fieldNOMBRE_SISTEMA_PREVISIONAL
        '
        Me.fieldNOMBRE_SISTEMA_PREVISIONAL.Appearance.Header.ForeColor = System.Drawing.Color.Blue
        Me.fieldNOMBRE_SISTEMA_PREVISIONAL.Appearance.Header.Options.UseForeColor = True
        Me.fieldNOMBRE_SISTEMA_PREVISIONAL.AreaIndex = 49
        Me.fieldNOMBRE_SISTEMA_PREVISIONAL.Caption = "Sistema Previsional"
        Me.fieldNOMBRE_SISTEMA_PREVISIONAL.FieldName = "NOMBRE_SISTEMA_PREVISIONAL"
        Me.fieldNOMBRE_SISTEMA_PREVISIONAL.Name = "fieldNOMBRE_SISTEMA_PREVISIONAL"
        '
        'fieldAFP
        '
        Me.fieldAFP.Appearance.Header.ForeColor = System.Drawing.Color.Blue
        Me.fieldAFP.Appearance.Header.Options.UseForeColor = True
        Me.fieldAFP.AreaIndex = 50
        Me.fieldAFP.Caption = "AFP/INP"
        Me.fieldAFP.FieldName = "AFP"
        Me.fieldAFP.Name = "fieldAFP"
        '
        'fieldFECHA_AFILIACION_AFP
        '
        Me.fieldFECHA_AFILIACION_AFP.Appearance.Header.ForeColor = System.Drawing.Color.Blue
        Me.fieldFECHA_AFILIACION_AFP.Appearance.Header.Options.UseForeColor = True
        Me.fieldFECHA_AFILIACION_AFP.AreaIndex = 51
        Me.fieldFECHA_AFILIACION_AFP.Caption = "Fecha Afiliación AFP/INP"
        Me.fieldFECHA_AFILIACION_AFP.FieldName = "FECHA_AFILIACION_AFP"
        Me.fieldFECHA_AFILIACION_AFP.Name = "fieldFECHA_AFILIACION_AFP"
        '
        'fieldMONTO_AHORRO_AFP
        '
        Me.fieldMONTO_AHORRO_AFP.Appearance.Header.ForeColor = System.Drawing.Color.Blue
        Me.fieldMONTO_AHORRO_AFP.Appearance.Header.Options.UseForeColor = True
        Me.fieldMONTO_AHORRO_AFP.AreaIndex = 52
        Me.fieldMONTO_AHORRO_AFP.Caption = "Monto Ahorro AFP"
        Me.fieldMONTO_AHORRO_AFP.FieldName = "MONTO_AHORRO_AFP"
        Me.fieldMONTO_AHORRO_AFP.Name = "fieldMONTO_AHORRO_AFP"
        '
        'fieldUNIDAD_MONTO_AHORRO_AFP
        '
        Me.fieldUNIDAD_MONTO_AHORRO_AFP.Appearance.Header.ForeColor = System.Drawing.Color.Blue
        Me.fieldUNIDAD_MONTO_AHORRO_AFP.Appearance.Header.Options.UseForeColor = True
        Me.fieldUNIDAD_MONTO_AHORRO_AFP.AreaIndex = 53
        Me.fieldUNIDAD_MONTO_AHORRO_AFP.Caption = "Unidad Ahorro AFP"
        Me.fieldUNIDAD_MONTO_AHORRO_AFP.FieldName = "UNIDAD_MONTO_AHORRO_AFP"
        Me.fieldUNIDAD_MONTO_AHORRO_AFP.Name = "fieldUNIDAD_MONTO_AHORRO_AFP"
        '
        'fieldISAPRE
        '
        Me.fieldISAPRE.Appearance.Header.ForeColor = System.Drawing.Color.Blue
        Me.fieldISAPRE.Appearance.Header.Options.UseForeColor = True
        Me.fieldISAPRE.AreaIndex = 54
        Me.fieldISAPRE.Caption = "Isapre"
        Me.fieldISAPRE.FieldName = "ISAPRE"
        Me.fieldISAPRE.Name = "fieldISAPRE"
        '
        'fieldNOMBRE_SISTEMA_SALUD
        '
        Me.fieldNOMBRE_SISTEMA_SALUD.Appearance.Header.ForeColor = System.Drawing.Color.Blue
        Me.fieldNOMBRE_SISTEMA_SALUD.Appearance.Header.Options.UseForeColor = True
        Me.fieldNOMBRE_SISTEMA_SALUD.AreaIndex = 55
        Me.fieldNOMBRE_SISTEMA_SALUD.Caption = "Sistema Salud"
        Me.fieldNOMBRE_SISTEMA_SALUD.FieldName = "NOMBRE_SISTEMA_SALUD"
        Me.fieldNOMBRE_SISTEMA_SALUD.Name = "fieldNOMBRE_SISTEMA_SALUD"
        '
        'fieldFECHA_AFILIACION_ISAPRE
        '
        Me.fieldFECHA_AFILIACION_ISAPRE.Appearance.Header.ForeColor = System.Drawing.Color.Blue
        Me.fieldFECHA_AFILIACION_ISAPRE.Appearance.Header.Options.UseForeColor = True
        Me.fieldFECHA_AFILIACION_ISAPRE.AreaIndex = 56
        Me.fieldFECHA_AFILIACION_ISAPRE.Caption = "Fecha Afiliación Isapre"
        Me.fieldFECHA_AFILIACION_ISAPRE.FieldName = "FECHA_AFILIACION_ISAPRE"
        Me.fieldFECHA_AFILIACION_ISAPRE.Name = "fieldFECHA_AFILIACION_ISAPRE"
        '
        'fieldPLAN_PACTADO_SALUD
        '
        Me.fieldPLAN_PACTADO_SALUD.Appearance.Header.ForeColor = System.Drawing.Color.Blue
        Me.fieldPLAN_PACTADO_SALUD.Appearance.Header.Options.UseForeColor = True
        Me.fieldPLAN_PACTADO_SALUD.AreaIndex = 57
        Me.fieldPLAN_PACTADO_SALUD.Caption = "Plan Pactado Salud"
        Me.fieldPLAN_PACTADO_SALUD.FieldName = "PLAN_PACTADO_SALUD"
        Me.fieldPLAN_PACTADO_SALUD.Name = "fieldPLAN_PACTADO_SALUD"
        '
        'fieldUNIDAD_PLAN_PACTADO_SALUD
        '
        Me.fieldUNIDAD_PLAN_PACTADO_SALUD.Appearance.Header.ForeColor = System.Drawing.Color.Blue
        Me.fieldUNIDAD_PLAN_PACTADO_SALUD.Appearance.Header.Options.UseForeColor = True
        Me.fieldUNIDAD_PLAN_PACTADO_SALUD.AreaIndex = 58
        Me.fieldUNIDAD_PLAN_PACTADO_SALUD.Caption = "Unidad Plan Pactado Salud"
        Me.fieldUNIDAD_PLAN_PACTADO_SALUD.FieldName = "UNIDAD_PLAN_PACTADO_SALUD"
        Me.fieldUNIDAD_PLAN_PACTADO_SALUD.Name = "fieldUNIDAD_PLAN_PACTADO_SALUD"
        '
        'fieldPLAN_COMPLEMENTARIO_ISAPRE
        '
        Me.fieldPLAN_COMPLEMENTARIO_ISAPRE.Appearance.Header.ForeColor = System.Drawing.Color.Blue
        Me.fieldPLAN_COMPLEMENTARIO_ISAPRE.Appearance.Header.Options.UseForeColor = True
        Me.fieldPLAN_COMPLEMENTARIO_ISAPRE.AreaIndex = 59
        Me.fieldPLAN_COMPLEMENTARIO_ISAPRE.Caption = "Plan Complementario Salud"
        Me.fieldPLAN_COMPLEMENTARIO_ISAPRE.FieldName = "PLAN_COMPLEMENTARIO_ISAPRE"
        Me.fieldPLAN_COMPLEMENTARIO_ISAPRE.Name = "fieldPLAN_COMPLEMENTARIO_ISAPRE"
        '
        'fieldUNIDAD_PLAN_COMPLEMENTARIO_ISAPRE
        '
        Me.fieldUNIDAD_PLAN_COMPLEMENTARIO_ISAPRE.Appearance.Header.ForeColor = System.Drawing.Color.Blue
        Me.fieldUNIDAD_PLAN_COMPLEMENTARIO_ISAPRE.Appearance.Header.Options.UseForeColor = True
        Me.fieldUNIDAD_PLAN_COMPLEMENTARIO_ISAPRE.AreaIndex = 60
        Me.fieldUNIDAD_PLAN_COMPLEMENTARIO_ISAPRE.Caption = "Unidad Plan Comple.Salud"
        Me.fieldUNIDAD_PLAN_COMPLEMENTARIO_ISAPRE.FieldName = "UNIDAD_PLAN_COMPLEMENTARIO_ISAPRE"
        Me.fieldUNIDAD_PLAN_COMPLEMENTARIO_ISAPRE.Name = "fieldUNIDAD_PLAN_COMPLEMENTARIO_ISAPRE"
        '
        'fieldMONTO_PLAN_AUGE
        '
        Me.fieldMONTO_PLAN_AUGE.Appearance.Header.ForeColor = System.Drawing.Color.Blue
        Me.fieldMONTO_PLAN_AUGE.Appearance.Header.Options.UseForeColor = True
        Me.fieldMONTO_PLAN_AUGE.AreaIndex = 61
        Me.fieldMONTO_PLAN_AUGE.Caption = "Monto Plan Auge"
        Me.fieldMONTO_PLAN_AUGE.FieldName = "MONTO_PLAN_AUGE"
        Me.fieldMONTO_PLAN_AUGE.Name = "fieldMONTO_PLAN_AUGE"
        '
        'fieldUNIDAD_MONTO_PLAN_AUGE
        '
        Me.fieldUNIDAD_MONTO_PLAN_AUGE.Appearance.Header.ForeColor = System.Drawing.Color.Blue
        Me.fieldUNIDAD_MONTO_PLAN_AUGE.Appearance.Header.Options.UseForeColor = True
        Me.fieldUNIDAD_MONTO_PLAN_AUGE.AreaIndex = 62
        Me.fieldUNIDAD_MONTO_PLAN_AUGE.Caption = "Unidad Monto Plan Auge"
        Me.fieldUNIDAD_MONTO_PLAN_AUGE.FieldName = "UNIDAD_MONTO_PLAN_AUGE"
        Me.fieldUNIDAD_MONTO_PLAN_AUGE.Name = "fieldUNIDAD_MONTO_PLAN_AUGE"
        '
        'fieldTIPO_TRABAJADOR_PREVIRED
        '
        Me.fieldTIPO_TRABAJADOR_PREVIRED.Appearance.Header.ForeColor = System.Drawing.Color.Blue
        Me.fieldTIPO_TRABAJADOR_PREVIRED.Appearance.Header.Options.UseForeColor = True
        Me.fieldTIPO_TRABAJADOR_PREVIRED.AreaIndex = 63
        Me.fieldTIPO_TRABAJADOR_PREVIRED.Caption = "Tipo Trabajador Previred"
        Me.fieldTIPO_TRABAJADOR_PREVIRED.FieldName = "TIPO_TRABAJADOR_PREVIRED"
        Me.fieldTIPO_TRABAJADOR_PREVIRED.Name = "fieldTIPO_TRABAJADOR_PREVIRED"
        '
        'fieldFONDO_BIENESTAR
        '
        Me.fieldFONDO_BIENESTAR.Appearance.Header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fieldFONDO_BIENESTAR.Appearance.Header.Options.UseForeColor = True
        Me.fieldFONDO_BIENESTAR.AreaIndex = 64
        Me.fieldFONDO_BIENESTAR.Caption = "Fondo Bienestar"
        Me.fieldFONDO_BIENESTAR.FieldName = "FONDO_BIENESTAR"
        Me.fieldFONDO_BIENESTAR.Name = "fieldFONDO_BIENESTAR"
        '
        'fieldASOCIACION_GREMIAL
        '
        Me.fieldASOCIACION_GREMIAL.Appearance.Header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fieldASOCIACION_GREMIAL.Appearance.Header.Options.UseForeColor = True
        Me.fieldASOCIACION_GREMIAL.AreaIndex = 65
        Me.fieldASOCIACION_GREMIAL.Caption = "Asociación Gremial"
        Me.fieldASOCIACION_GREMIAL.FieldName = "ASOCIACION_GREMIAL"
        Me.fieldASOCIACION_GREMIAL.Name = "fieldASOCIACION_GREMIAL"
        '
        'fieldFORMA_PAGO
        '
        Me.fieldFORMA_PAGO.Appearance.Header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fieldFORMA_PAGO.Appearance.Header.Options.UseForeColor = True
        Me.fieldFORMA_PAGO.AreaIndex = 66
        Me.fieldFORMA_PAGO.Caption = "Forma Pago"
        Me.fieldFORMA_PAGO.FieldName = "FORMA_PAGO"
        Me.fieldFORMA_PAGO.Name = "fieldFORMA_PAGO"
        '
        'fieldTIPO_CUENTA_BANCO
        '
        Me.fieldTIPO_CUENTA_BANCO.Appearance.Header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fieldTIPO_CUENTA_BANCO.Appearance.Header.Options.UseForeColor = True
        Me.fieldTIPO_CUENTA_BANCO.AreaIndex = 67
        Me.fieldTIPO_CUENTA_BANCO.Caption = "Tipo Cuenta Banco"
        Me.fieldTIPO_CUENTA_BANCO.FieldName = "TIPO_CUENTA_BANCO"
        Me.fieldTIPO_CUENTA_BANCO.Name = "fieldTIPO_CUENTA_BANCO"
        '
        'fieldBANCO
        '
        Me.fieldBANCO.Appearance.Header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fieldBANCO.Appearance.Header.Options.UseForeColor = True
        Me.fieldBANCO.AreaIndex = 68
        Me.fieldBANCO.Caption = "Banco"
        Me.fieldBANCO.FieldName = "BANCO"
        Me.fieldBANCO.Name = "fieldBANCO"
        '
        'fieldNRO_CUENTA_BANCO
        '
        Me.fieldNRO_CUENTA_BANCO.Appearance.Header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fieldNRO_CUENTA_BANCO.Appearance.Header.Options.UseForeColor = True
        Me.fieldNRO_CUENTA_BANCO.AreaIndex = 69
        Me.fieldNRO_CUENTA_BANCO.Caption = "Numero Cuenta Banco"
        Me.fieldNRO_CUENTA_BANCO.FieldName = "NRO_CUENTA_BANCO"
        Me.fieldNRO_CUENTA_BANCO.Name = "fieldNRO_CUENTA_BANCO"
        '
        'fieldNUMERO_BIENIOS
        '
        Me.fieldNUMERO_BIENIOS.Appearance.Header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fieldNUMERO_BIENIOS.Appearance.Header.Options.UseForeColor = True
        Me.fieldNUMERO_BIENIOS.AreaIndex = 70
        Me.fieldNUMERO_BIENIOS.Caption = "Número Bienios"
        Me.fieldNUMERO_BIENIOS.FieldName = "NUMERO_BIENIOS"
        Me.fieldNUMERO_BIENIOS.Name = "fieldNUMERO_BIENIOS"
        '
        'fieldFECHA_CUMPLIO_BIENIOS
        '
        Me.fieldFECHA_CUMPLIO_BIENIOS.Appearance.Header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fieldFECHA_CUMPLIO_BIENIOS.Appearance.Header.Options.UseForeColor = True
        Me.fieldFECHA_CUMPLIO_BIENIOS.AreaIndex = 71
        Me.fieldFECHA_CUMPLIO_BIENIOS.Caption = "Fecha Cumplio Bienio"
        Me.fieldFECHA_CUMPLIO_BIENIOS.FieldName = "FECHA_CUMPLIO_BIENIOS"
        Me.fieldFECHA_CUMPLIO_BIENIOS.Name = "fieldFECHA_CUMPLIO_BIENIOS"
        '
        'fieldTRAMO_ASIGNACION_FAMILIAR
        '
        Me.fieldTRAMO_ASIGNACION_FAMILIAR.Appearance.Header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fieldTRAMO_ASIGNACION_FAMILIAR.Appearance.Header.Options.UseForeColor = True
        Me.fieldTRAMO_ASIGNACION_FAMILIAR.AreaIndex = 72
        Me.fieldTRAMO_ASIGNACION_FAMILIAR.Caption = "Tramo Asignación Familiar"
        Me.fieldTRAMO_ASIGNACION_FAMILIAR.FieldName = "TRAMO_ASIGNACION_FAMILIAR"
        Me.fieldTRAMO_ASIGNACION_FAMILIAR.Name = "fieldTRAMO_ASIGNACION_FAMILIAR"
        '
        'fieldCARGAS_FAM_NORMALES
        '
        Me.fieldCARGAS_FAM_NORMALES.Appearance.Header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fieldCARGAS_FAM_NORMALES.Appearance.Header.Options.UseForeColor = True
        Me.fieldCARGAS_FAM_NORMALES.AreaIndex = 73
        Me.fieldCARGAS_FAM_NORMALES.Caption = "Cargas Fam.Normales"
        Me.fieldCARGAS_FAM_NORMALES.FieldName = "CARGAS_FAM_NORMALES"
        Me.fieldCARGAS_FAM_NORMALES.Name = "fieldCARGAS_FAM_NORMALES"
        '
        'fieldCARGAS_FAM_INVALIDAS
        '
        Me.fieldCARGAS_FAM_INVALIDAS.Appearance.Header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fieldCARGAS_FAM_INVALIDAS.Appearance.Header.Options.UseForeColor = True
        Me.fieldCARGAS_FAM_INVALIDAS.AreaIndex = 74
        Me.fieldCARGAS_FAM_INVALIDAS.Caption = "Cargas Fam.Inválidas"
        Me.fieldCARGAS_FAM_INVALIDAS.FieldName = "CARGAS_FAM_INVALIDAS"
        Me.fieldCARGAS_FAM_INVALIDAS.Name = "fieldCARGAS_FAM_INVALIDAS"
        '
        'fieldCARGAS_FAM_PRENATAL
        '
        Me.fieldCARGAS_FAM_PRENATAL.Appearance.Header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fieldCARGAS_FAM_PRENATAL.Appearance.Header.Options.UseForeColor = True
        Me.fieldCARGAS_FAM_PRENATAL.AreaIndex = 75
        Me.fieldCARGAS_FAM_PRENATAL.Caption = "Cargas Fam.Prenatal"
        Me.fieldCARGAS_FAM_PRENATAL.FieldName = "CARGAS_FAM_PRENATAL"
        Me.fieldCARGAS_FAM_PRENATAL.Name = "fieldCARGAS_FAM_PRENATAL"
        '
        'fieldRENTA_BRUTA
        '
        Me.fieldRENTA_BRUTA.Appearance.Header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fieldRENTA_BRUTA.Appearance.Header.Options.UseForeColor = True
        Me.fieldRENTA_BRUTA.AreaIndex = 76
        Me.fieldRENTA_BRUTA.Caption = "Renta Bruta"
        Me.fieldRENTA_BRUTA.FieldName = "RENTA_BRUTA"
        Me.fieldRENTA_BRUTA.Name = "fieldRENTA_BRUTA"
        '
        'fieldSUB_DEPTO
        '
        Me.fieldSUB_DEPTO.Appearance.Header.ForeColor = System.Drawing.Color.Red
        Me.fieldSUB_DEPTO.Appearance.Header.Options.UseForeColor = True
        Me.fieldSUB_DEPTO.AreaIndex = 30
        Me.fieldSUB_DEPTO.Caption = "Sub-Departamento"
        Me.fieldSUB_DEPTO.FieldName = "SUB_DEPTO"
        Me.fieldSUB_DEPTO.Name = "fieldSUB_DEPTO"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Location = New System.Drawing.Point(496, 56)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(144, 23)
        Me.btnExportExcel.TabIndex = 8
        Me.btnExportExcel.Text = "Exportar a Excel"
        '
        'gpcSeleccionAño
        '
        Me.gpcSeleccionAño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionAño.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionAño.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionAño.Controls.Add(Me.chkSoloEmpleadoActivos)
        Me.gpcSeleccionAño.Controls.Add(Me.btnGenerar)
        Me.gpcSeleccionAño.Controls.Add(Me.lblMesFinal)
        Me.gpcSeleccionAño.Controls.Add(Me.lblMesInicio)
        Me.gpcSeleccionAño.Controls.Add(Me.txtMesFinal)
        Me.gpcSeleccionAño.Controls.Add(Me.txtMesInicial)
        Me.gpcSeleccionAño.Controls.Add(Me.luePeriodo)
        Me.gpcSeleccionAño.Controls.Add(Me.lblPeriodo)
        Me.gpcSeleccionAño.Controls.Add(Me.btnExportExcel)
        Me.gpcSeleccionAño.Location = New System.Drawing.Point(8, 0)
        Me.gpcSeleccionAño.Name = "gpcSeleccionAño"
        Me.gpcSeleccionAño.Size = New System.Drawing.Size(832, 141)
        Me.gpcSeleccionAño.TabIndex = 6
        Me.gpcSeleccionAño.Text = "Selección de Año"
        '
        'chkSoloEmpleadoActivos
        '
        Me.chkSoloEmpleadoActivos.Location = New System.Drawing.Point(126, 109)
        Me.chkSoloEmpleadoActivos.Name = "chkSoloEmpleadoActivos"
        Me.chkSoloEmpleadoActivos.Properties.Caption = "Solo Empleados Activos"
        Me.chkSoloEmpleadoActivos.Size = New System.Drawing.Size(146, 19)
        Me.chkSoloEmpleadoActivos.TabIndex = 26
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(344, 56)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(144, 23)
        Me.btnGenerar.TabIndex = 5
        Me.btnGenerar.Text = "Generar"
        '
        'lblMesFinal
        '
        Me.lblMesFinal.Location = New System.Drawing.Point(48, 80)
        Me.lblMesFinal.Name = "lblMesFinal"
        Me.lblMesFinal.Size = New System.Drawing.Size(64, 16)
        Me.lblMesFinal.TabIndex = 25
        Me.lblMesFinal.Text = "Mes Final"
        Me.lblMesFinal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMesInicio
        '
        Me.lblMesInicio.Location = New System.Drawing.Point(48, 56)
        Me.lblMesInicio.Name = "lblMesInicio"
        Me.lblMesInicio.Size = New System.Drawing.Size(64, 16)
        Me.lblMesInicio.TabIndex = 24
        Me.lblMesInicio.Text = "Mes Inicial"
        Me.lblMesInicio.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMesFinal
        '
        Me.txtMesFinal.Location = New System.Drawing.Point(128, 80)
        Me.txtMesFinal.Name = "txtMesFinal"
        Me.txtMesFinal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMesFinal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMesFinal.Properties.Mask.EditMask = "n0"
        Me.txtMesFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMesFinal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMesFinal.Properties.MaxLength = 2
        Me.txtMesFinal.Size = New System.Drawing.Size(48, 20)
        Me.txtMesFinal.TabIndex = 2
        '
        'txtMesInicial
        '
        Me.txtMesInicial.Location = New System.Drawing.Point(128, 56)
        Me.txtMesInicial.Name = "txtMesInicial"
        Me.txtMesInicial.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMesInicial.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMesInicial.Properties.Mask.EditMask = "n0"
        Me.txtMesInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMesInicial.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMesInicial.Properties.MaxLength = 2
        Me.txtMesInicial.Size = New System.Drawing.Size(48, 20)
        Me.txtMesInicial.TabIndex = 1
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(128, 32)
        Me.luePeriodo.Name = "luePeriodo"
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(144, 20)
        Me.luePeriodo.TabIndex = 0
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(64, 36)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 16)
        Me.lblPeriodo.TabIndex = 3
        Me.lblPeriodo.Text = "Año"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'fieldTIENE_ASIGNACION_PROFESIONAL
        '
        Me.fieldTIENE_ASIGNACION_PROFESIONAL.Appearance.Header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fieldTIENE_ASIGNACION_PROFESIONAL.Appearance.Header.Options.UseForeColor = True
        Me.fieldTIENE_ASIGNACION_PROFESIONAL.AreaIndex = 77
        Me.fieldTIENE_ASIGNACION_PROFESIONAL.Caption = "Tiene Asignación Profesional"
        Me.fieldTIENE_ASIGNACION_PROFESIONAL.FieldName = "TIENE_ASIGNACION_PROFESIONAL"
        Me.fieldTIENE_ASIGNACION_PROFESIONAL.Name = "fieldTIENE_ASIGNACION_PROFESIONAL"
        '
        'frmAnalisisMaestroEmpleadoDetallado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(848, 580)
        Me.Controls.Add(Me.gpcSeleccionAño)
        Me.Controls.Add(Me.pgcAnalisisMaestroEmpleado)
        Me.Name = "frmAnalisisMaestroEmpleadoDetallado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Análisis Maestro Empleado Detallado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pgcAnalisisMaestroEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionAño.ResumeLayout(False)
        CType(Me.chkSoloEmpleadoActivos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMesFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMesInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private empleado As empleado
    Private parametroMensual As Periodo

    Private Sub frmAnalisisMaestroEmpleadoDetallado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empleado = New empleado
        parametroMensual = New Periodo
        repositorio.RefreshDatos("PeriodoAño")
        llenarPeriodos()
        chkSoloEmpleadoActivos.Checked = True
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        If luePeriodo.EditValue <> Nothing Then
            If ValidaMeses() Then
                If MsgBoxResult.Yes = MessageBox.Show("El siguiente informe podría tardar varios minutos, ¿desea continuar?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                    refrescaDetalle()
                End If
            End If
        End If
    End Sub

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        Dim rutaPlanillaExcel As String
        Try
            With sfdAnalisisMaestroEmpleadoDetallado
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = sfdAnalisisMaestroEmpleadoDetallado.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                pgcAnalisisMaestroEmpleado.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function ValidaMeses() As Boolean
        Dim ValidacionMeses As Boolean = True
        If Me.txtMesInicial.EditValue <= 0 Then
            txtMesInicial.ErrorText = "Mes inicial debe estar entre 1 y 12"
            ValidacionMeses = False
        End If
        If Me.txtMesFinal.EditValue <= 0 Then
            txtMesInicial.ErrorText = "Mes final debe estar entre 1 y 12"
            ValidacionMeses = False
        End If
        If (Me.txtMesInicial.EditValue > 0 And Me.txtMesFinal.EditValue > 0) And (Me.txtMesFinal.EditValue < Me.txtMesInicial.EditValue) Then
            txtMesFinal.ErrorText = "Mes final no puede ser anterior al mes inicial"
            ValidacionMeses = False
        End If
        Return ValidacionMeses
    End Function

    Private Sub llenarPeriodos()
        With luePeriodo
            With .Properties.Columns
                .Add(New LookUpColumnInfo("ANO", "Año Proceso", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        repositorio.Show()
        luePeriodo.Properties.DataSource = repositorio.dvPeriodoAño
        luePeriodo.Properties.DisplayMember = "ANO"
        luePeriodo.Properties.NullText = ""
        luePeriodo.Properties.PopupWidth = 100
        luePeriodo.Properties.ValueMember = "ANO"
    End Sub

    'Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
    '    If luePeriodo.EditValue <> Nothing Then
    '        If MsgBoxResult.Yes = MessageBox.Show("El siguiente informe podría tardar varios minutos, ¿desea continuar?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
    '            refrescaDetalle()
    '        End If
    '    End If
    'End Sub

    Private Sub refrescaDetalle()
        Cursor.Current = Cursors.WaitCursor
        If luePeriodo.EditValue <> Nothing Then
            Try
                pgcAnalisisMaestroEmpleado.DataSource = empleado.recuperaAnalisisMaestroEmpleadoDetallado(luePeriodo.EditValue, txtMesInicial.EditValue, txtMesFinal.EditValue, chkSoloEmpleadoActivos.Checked)
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al leer datos maestro empleado detallado." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub chkSoloEmpleadoActivos_EditValueChanged(sender As Object, e As System.EventArgs) Handles chkSoloEmpleadoActivos.EditValueChanged
        If (Me.txtMesInicial.EditValue > 0 And Me.txtMesFinal.EditValue > 0) And (Me.txtMesFinal.EditValue >= Me.txtMesInicial.EditValue) Then
            refrescaDetalle()
        End If
    End Sub
End Class
