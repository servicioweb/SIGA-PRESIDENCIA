Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Windows.Forms
Imports System.Drawing
Imports System

Public Class frmAnalisisCargasFamiliares
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
    Friend WithEvents pgcAnalisisCargasFamiliares As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldESTADO_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCALIDAD_JURIDICA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDEPARTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDIRECCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_CARGA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPARENTESCO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSEXO_CARGA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_NACIMIENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTADO_CARGA_FAM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEDAD_CARGA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_VIGENCIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_VENCIMIENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNIVEL_ESTUDIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCARGA_POR_ESTUDIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGRUPO_FAMILIAR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTIPO_CARGA_FAMILIAR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRETENSION_JUDICIAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRECIBE_REGALO_NAVIDAD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCANTIDAD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents sfdAnalisisCargasFamiliares As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents fieldTIPO_CAUSANTE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTIPO_BENEFICIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTIPO_BENEFICIARIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAFP As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldISAPRE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSISTEMA_PREVISIONAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSISTEMA_SALUD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRUT_CARGA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDIGITO_VER_CARGA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTRAMO_ASIGNACION_FAMILIAR_ID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMONTO_ASIGNACION_FAMILIAR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAPELLIDO_PAT_CARGA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAPELLIDO_MAT_CARGA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRES_CARGA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAPELLIDO_PATERNO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAPELLIDO_MATERNO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents gpcSeleccionDeAño As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblAno As DevExpress.XtraEditors.LabelControl
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtMesFinal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMesFinal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMesInicial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMesInicial As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkSoloEmpleadosActivos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents fieldAÑO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSUB_DEPTO As DevExpress.XtraPivotGrid.PivotGridField
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.pgcAnalisisCargasFamiliares = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldAÑO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldESTADO_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCALIDAD_JURIDICA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRE_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRUT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDV = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDIRECCION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDEPARTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSUB_DEPTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRE_CARGA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRUT_CARGA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDIGITO_VER_CARGA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPARENTESCO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSEXO_CARGA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHA_NACIMIENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEDAD_CARGA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldESTADO_CARGA_FAM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHA_VIGENCIA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHA_VENCIMIENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNIVEL_ESTUDIO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCARGA_POR_ESTUDIO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldGRUPO_FAMILIAR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTIPO_CARGA_FAMILIAR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRETENSION_JUDICIAL = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRECIBE_REGALO_NAVIDAD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTIPO_CAUSANTE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTIPO_BENEFICIO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTIPO_BENEFICIARIO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCANTIDAD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAFP = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldISAPRE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSISTEMA_PREVISIONAL = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSISTEMA_SALUD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTRAMO_ASIGNACION_FAMILIAR_ID = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMONTO_ASIGNACION_FAMILIAR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAPELLIDO_PAT_CARGA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAPELLIDO_MAT_CARGA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRES_CARGA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAPELLIDO_PATERNO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAPELLIDO_MATERNO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.sfdAnalisisCargasFamiliares = New System.Windows.Forms.SaveFileDialog()
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.gpcSeleccionDeAño = New DevExpress.XtraEditors.GroupControl()
        Me.btnGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.chkSoloEmpleadosActivos = New DevExpress.XtraEditors.CheckEdit()
        Me.txtMesFinal = New DevExpress.XtraEditors.TextEdit()
        Me.lblMesFinal = New DevExpress.XtraEditors.LabelControl()
        Me.txtMesInicial = New DevExpress.XtraEditors.TextEdit()
        Me.lblMesInicial = New DevExpress.XtraEditors.LabelControl()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblAno = New DevExpress.XtraEditors.LabelControl()
        CType(Me.pgcAnalisisCargasFamiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcSeleccionDeAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionDeAño.SuspendLayout()
        CType(Me.chkSoloEmpleadosActivos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMesFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMesInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pgcAnalisisCargasFamiliares
        '
        Me.pgcAnalisisCargasFamiliares.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgcAnalisisCargasFamiliares.Cursor = System.Windows.Forms.Cursors.Default
        Me.pgcAnalisisCargasFamiliares.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldAÑO, Me.fieldMES, Me.fieldESTADO_EMPLEADO, Me.fieldCALIDAD_JURIDICA, Me.fieldNOMBRE_EMPLEADO, Me.fieldRUT, Me.fieldDV, Me.fieldDIRECCION, Me.fieldDEPARTAMENTO, Me.fieldSUB_DEPTO, Me.fieldNOMBRE_CARGA, Me.fieldRUT_CARGA, Me.fieldDIGITO_VER_CARGA, Me.fieldPARENTESCO, Me.fieldSEXO_CARGA, Me.fieldFECHA_NACIMIENTO, Me.fieldEDAD_CARGA, Me.fieldESTADO_CARGA_FAM, Me.fieldFECHA_VIGENCIA, Me.fieldFECHA_VENCIMIENTO, Me.fieldNIVEL_ESTUDIO, Me.fieldCARGA_POR_ESTUDIO, Me.fieldGRUPO_FAMILIAR, Me.fieldTIPO_CARGA_FAMILIAR, Me.fieldRETENSION_JUDICIAL, Me.fieldRECIBE_REGALO_NAVIDAD, Me.fieldTIPO_CAUSANTE, Me.fieldTIPO_BENEFICIO, Me.fieldTIPO_BENEFICIARIO, Me.fieldCANTIDAD, Me.fieldAFP, Me.fieldISAPRE, Me.fieldSISTEMA_PREVISIONAL, Me.fieldSISTEMA_SALUD, Me.fieldTRAMO_ASIGNACION_FAMILIAR_ID, Me.fieldMONTO_ASIGNACION_FAMILIAR, Me.fieldAPELLIDO_PAT_CARGA, Me.fieldAPELLIDO_MAT_CARGA, Me.fieldNOMBRES_CARGA, Me.fieldAPELLIDO_PATERNO, Me.fieldAPELLIDO_MATERNO, Me.fieldNOMBRES})
        Me.pgcAnalisisCargasFamiliares.Location = New System.Drawing.Point(12, 150)
        Me.pgcAnalisisCargasFamiliares.Name = "pgcAnalisisCargasFamiliares"
        Me.pgcAnalisisCargasFamiliares.OptionsBehavior.HorizontalScrolling = DevExpress.XtraPivotGrid.PivotGridScrolling.Control
        Me.pgcAnalisisCargasFamiliares.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
        Me.pgcAnalisisCargasFamiliares.Size = New System.Drawing.Size(918, 416)
        Me.pgcAnalisisCargasFamiliares.TabIndex = 0
        '
        'fieldAÑO
        '
        Me.fieldAÑO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldAÑO.AreaIndex = 0
        Me.fieldAÑO.Caption = "Año"
        Me.fieldAÑO.FieldName = "ANO"
        Me.fieldAÑO.Name = "fieldAÑO"
        '
        'fieldMES
        '
        Me.fieldMES.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldMES.AreaIndex = 1
        Me.fieldMES.Caption = "Mes"
        Me.fieldMES.FieldName = "MES"
        Me.fieldMES.Name = "fieldMES"
        '
        'fieldESTADO_EMPLEADO
        '
        Me.fieldESTADO_EMPLEADO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldESTADO_EMPLEADO.AreaIndex = 2
        Me.fieldESTADO_EMPLEADO.Caption = "Estado Empleado"
        Me.fieldESTADO_EMPLEADO.FieldName = "ESTADO_EMPLEADO"
        Me.fieldESTADO_EMPLEADO.Name = "fieldESTADO_EMPLEADO"
        '
        'fieldCALIDAD_JURIDICA
        '
        Me.fieldCALIDAD_JURIDICA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCALIDAD_JURIDICA.AreaIndex = 3
        Me.fieldCALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.fieldCALIDAD_JURIDICA.FieldName = "CALIDAD_JURIDICA"
        Me.fieldCALIDAD_JURIDICA.Name = "fieldCALIDAD_JURIDICA"
        '
        'fieldNOMBRE_EMPLEADO
        '
        Me.fieldNOMBRE_EMPLEADO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNOMBRE_EMPLEADO.AreaIndex = 4
        Me.fieldNOMBRE_EMPLEADO.Caption = "Nombre Completo Empleado"
        Me.fieldNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.Name = "fieldNOMBRE_EMPLEADO"
        '
        'fieldRUT
        '
        Me.fieldRUT.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldRUT.AreaIndex = 5
        Me.fieldRUT.Caption = "Rut  Empleado"
        Me.fieldRUT.FieldName = "RUT"
        Me.fieldRUT.Name = "fieldRUT"
        '
        'fieldDV
        '
        Me.fieldDV.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldDV.AreaIndex = 6
        Me.fieldDV.Caption = "DV Empleado"
        Me.fieldDV.FieldName = "DV"
        Me.fieldDV.Name = "fieldDV"
        '
        'fieldDIRECCION
        '
        Me.fieldDIRECCION.AreaIndex = 0
        Me.fieldDIRECCION.Caption = "Dirección"
        Me.fieldDIRECCION.FieldName = "DIRECCION"
        Me.fieldDIRECCION.Name = "fieldDIRECCION"
        '
        'fieldDEPARTAMENTO
        '
        Me.fieldDEPARTAMENTO.AreaIndex = 1
        Me.fieldDEPARTAMENTO.Caption = "Departamento"
        Me.fieldDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.fieldDEPARTAMENTO.Name = "fieldDEPARTAMENTO"
        '
        'fieldSUB_DEPTO
        '
        Me.fieldSUB_DEPTO.AreaIndex = 2
        Me.fieldSUB_DEPTO.Caption = "Sub-Departamento"
        Me.fieldSUB_DEPTO.FieldName = "SUB_DEPTO"
        Me.fieldSUB_DEPTO.Name = "fieldSUB_DEPTO"
        '
        'fieldNOMBRE_CARGA
        '
        Me.fieldNOMBRE_CARGA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNOMBRE_CARGA.AreaIndex = 7
        Me.fieldNOMBRE_CARGA.Caption = "Nombre Completo Carga Familiar"
        Me.fieldNOMBRE_CARGA.FieldName = "NOMBRE_CARGA"
        Me.fieldNOMBRE_CARGA.Name = "fieldNOMBRE_CARGA"
        '
        'fieldRUT_CARGA
        '
        Me.fieldRUT_CARGA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldRUT_CARGA.AreaIndex = 8
        Me.fieldRUT_CARGA.Caption = "Rut Carga Fam."
        Me.fieldRUT_CARGA.FieldName = "RUT_CARGA"
        Me.fieldRUT_CARGA.Name = "fieldRUT_CARGA"
        '
        'fieldDIGITO_VER_CARGA
        '
        Me.fieldDIGITO_VER_CARGA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldDIGITO_VER_CARGA.AreaIndex = 9
        Me.fieldDIGITO_VER_CARGA.Caption = "DV Carga"
        Me.fieldDIGITO_VER_CARGA.FieldName = "DIGITO_VER_CARGA"
        Me.fieldDIGITO_VER_CARGA.Name = "fieldDIGITO_VER_CARGA"
        '
        'fieldPARENTESCO
        '
        Me.fieldPARENTESCO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldPARENTESCO.AreaIndex = 10
        Me.fieldPARENTESCO.Caption = "Parentesco"
        Me.fieldPARENTESCO.FieldName = "PARENTESCO"
        Me.fieldPARENTESCO.Name = "fieldPARENTESCO"
        '
        'fieldSEXO_CARGA
        '
        Me.fieldSEXO_CARGA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldSEXO_CARGA.AreaIndex = 11
        Me.fieldSEXO_CARGA.Caption = "Sexo"
        Me.fieldSEXO_CARGA.FieldName = "SEXO_CARGA"
        Me.fieldSEXO_CARGA.Name = "fieldSEXO_CARGA"
        '
        'fieldFECHA_NACIMIENTO
        '
        Me.fieldFECHA_NACIMIENTO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldFECHA_NACIMIENTO.AreaIndex = 12
        Me.fieldFECHA_NACIMIENTO.Caption = "Fecha Nacimiento Carga"
        Me.fieldFECHA_NACIMIENTO.FieldName = "FECHA_NACIMIENTO"
        Me.fieldFECHA_NACIMIENTO.Name = "fieldFECHA_NACIMIENTO"
        '
        'fieldEDAD_CARGA
        '
        Me.fieldEDAD_CARGA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldEDAD_CARGA.AreaIndex = 13
        Me.fieldEDAD_CARGA.Caption = "Edad Carga Fam"
        Me.fieldEDAD_CARGA.FieldName = "EDAD_CARGA"
        Me.fieldEDAD_CARGA.Name = "fieldEDAD_CARGA"
        '
        'fieldESTADO_CARGA_FAM
        '
        Me.fieldESTADO_CARGA_FAM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldESTADO_CARGA_FAM.AreaIndex = 14
        Me.fieldESTADO_CARGA_FAM.Caption = "Estado Carga Fam."
        Me.fieldESTADO_CARGA_FAM.FieldName = "ESTADO_CARGA_FAM"
        Me.fieldESTADO_CARGA_FAM.Name = "fieldESTADO_CARGA_FAM"
        '
        'fieldFECHA_VIGENCIA
        '
        Me.fieldFECHA_VIGENCIA.AreaIndex = 3
        Me.fieldFECHA_VIGENCIA.Caption = "Fecha Inicio Vigencia"
        Me.fieldFECHA_VIGENCIA.FieldName = "FECHA_VIGENCIA"
        Me.fieldFECHA_VIGENCIA.Name = "fieldFECHA_VIGENCIA"
        '
        'fieldFECHA_VENCIMIENTO
        '
        Me.fieldFECHA_VENCIMIENTO.AreaIndex = 4
        Me.fieldFECHA_VENCIMIENTO.Caption = "Fecha Vencimiento"
        Me.fieldFECHA_VENCIMIENTO.FieldName = "FECHA_VENCIMIENTO"
        Me.fieldFECHA_VENCIMIENTO.Name = "fieldFECHA_VENCIMIENTO"
        '
        'fieldNIVEL_ESTUDIO
        '
        Me.fieldNIVEL_ESTUDIO.AreaIndex = 5
        Me.fieldNIVEL_ESTUDIO.Caption = "Nivel Estudio"
        Me.fieldNIVEL_ESTUDIO.FieldName = "NIVEL_ESTUDIO"
        Me.fieldNIVEL_ESTUDIO.Name = "fieldNIVEL_ESTUDIO"
        '
        'fieldCARGA_POR_ESTUDIO
        '
        Me.fieldCARGA_POR_ESTUDIO.AreaIndex = 6
        Me.fieldCARGA_POR_ESTUDIO.Caption = "Carga por Estudio"
        Me.fieldCARGA_POR_ESTUDIO.FieldName = "CARGA_POR_ESTUDIO"
        Me.fieldCARGA_POR_ESTUDIO.Name = "fieldCARGA_POR_ESTUDIO"
        '
        'fieldGRUPO_FAMILIAR
        '
        Me.fieldGRUPO_FAMILIAR.AreaIndex = 7
        Me.fieldGRUPO_FAMILIAR.Caption = "Grupo Familiar"
        Me.fieldGRUPO_FAMILIAR.FieldName = "GRUPO_FAMILIAR"
        Me.fieldGRUPO_FAMILIAR.Name = "fieldGRUPO_FAMILIAR"
        '
        'fieldTIPO_CARGA_FAMILIAR
        '
        Me.fieldTIPO_CARGA_FAMILIAR.AreaIndex = 8
        Me.fieldTIPO_CARGA_FAMILIAR.Caption = "Tipo Carga Fam."
        Me.fieldTIPO_CARGA_FAMILIAR.FieldName = "TIPO_CARGA_FAMILIAR"
        Me.fieldTIPO_CARGA_FAMILIAR.Name = "fieldTIPO_CARGA_FAMILIAR"
        '
        'fieldRETENSION_JUDICIAL
        '
        Me.fieldRETENSION_JUDICIAL.AreaIndex = 9
        Me.fieldRETENSION_JUDICIAL.Caption = "Retensión Judicial"
        Me.fieldRETENSION_JUDICIAL.FieldName = "RETENSION_JUDICIAL"
        Me.fieldRETENSION_JUDICIAL.Name = "fieldRETENSION_JUDICIAL"
        '
        'fieldRECIBE_REGALO_NAVIDAD
        '
        Me.fieldRECIBE_REGALO_NAVIDAD.AreaIndex = 10
        Me.fieldRECIBE_REGALO_NAVIDAD.Caption = "Recibe Regalo Navidad"
        Me.fieldRECIBE_REGALO_NAVIDAD.FieldName = "RECIBE_REGALO_NAVIDAD"
        Me.fieldRECIBE_REGALO_NAVIDAD.Name = "fieldRECIBE_REGALO_NAVIDAD"
        '
        'fieldTIPO_CAUSANTE
        '
        Me.fieldTIPO_CAUSANTE.AreaIndex = 11
        Me.fieldTIPO_CAUSANTE.Caption = "Tipo Causante"
        Me.fieldTIPO_CAUSANTE.FieldName = "TIPO_CAUSANTE"
        Me.fieldTIPO_CAUSANTE.Name = "fieldTIPO_CAUSANTE"
        '
        'fieldTIPO_BENEFICIO
        '
        Me.fieldTIPO_BENEFICIO.AreaIndex = 12
        Me.fieldTIPO_BENEFICIO.Caption = "Tipo Beneficio"
        Me.fieldTIPO_BENEFICIO.FieldName = "TIPO_BENEFICIO"
        Me.fieldTIPO_BENEFICIO.Name = "fieldTIPO_BENEFICIO"
        '
        'fieldTIPO_BENEFICIARIO
        '
        Me.fieldTIPO_BENEFICIARIO.AreaIndex = 13
        Me.fieldTIPO_BENEFICIARIO.Caption = "Tipo Beneficiario"
        Me.fieldTIPO_BENEFICIARIO.FieldName = "TIPO_BENEFICIARIO"
        Me.fieldTIPO_BENEFICIARIO.Name = "fieldTIPO_BENEFICIARIO"
        '
        'fieldCANTIDAD
        '
        Me.fieldCANTIDAD.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCANTIDAD.AreaIndex = 0
        Me.fieldCANTIDAD.Caption = "Cantidad"
        Me.fieldCANTIDAD.FieldName = "CANTIDAD"
        Me.fieldCANTIDAD.Name = "fieldCANTIDAD"
        '
        'fieldAFP
        '
        Me.fieldAFP.AreaIndex = 14
        Me.fieldAFP.Caption = "AFP"
        Me.fieldAFP.FieldName = "AFP"
        Me.fieldAFP.Name = "fieldAFP"
        '
        'fieldISAPRE
        '
        Me.fieldISAPRE.AreaIndex = 15
        Me.fieldISAPRE.Caption = "Isapre"
        Me.fieldISAPRE.FieldName = "ISAPRE"
        Me.fieldISAPRE.Name = "fieldISAPRE"
        '
        'fieldSISTEMA_PREVISIONAL
        '
        Me.fieldSISTEMA_PREVISIONAL.AreaIndex = 16
        Me.fieldSISTEMA_PREVISIONAL.Caption = "Sistema Previsional"
        Me.fieldSISTEMA_PREVISIONAL.FieldName = "SISTEMA_PREVISIONAL"
        Me.fieldSISTEMA_PREVISIONAL.Name = "fieldSISTEMA_PREVISIONAL"
        '
        'fieldSISTEMA_SALUD
        '
        Me.fieldSISTEMA_SALUD.AreaIndex = 17
        Me.fieldSISTEMA_SALUD.Caption = "Sistema Salud"
        Me.fieldSISTEMA_SALUD.FieldName = "SISTEMA_SALUD"
        Me.fieldSISTEMA_SALUD.Name = "fieldSISTEMA_SALUD"
        '
        'fieldTRAMO_ASIGNACION_FAMILIAR_ID
        '
        Me.fieldTRAMO_ASIGNACION_FAMILIAR_ID.AreaIndex = 18
        Me.fieldTRAMO_ASIGNACION_FAMILIAR_ID.Caption = "Tramo Asig.Familiar"
        Me.fieldTRAMO_ASIGNACION_FAMILIAR_ID.FieldName = "TRAMO_ASIGNACION_FAMILIAR_ID"
        Me.fieldTRAMO_ASIGNACION_FAMILIAR_ID.Name = "fieldTRAMO_ASIGNACION_FAMILIAR_ID"
        '
        'fieldMONTO_ASIGNACION_FAMILIAR
        '
        Me.fieldMONTO_ASIGNACION_FAMILIAR.AreaIndex = 19
        Me.fieldMONTO_ASIGNACION_FAMILIAR.Caption = "Monto Asig.Familiar"
        Me.fieldMONTO_ASIGNACION_FAMILIAR.FieldName = "MONTO_ASIGNACION_FAMILIAR"
        Me.fieldMONTO_ASIGNACION_FAMILIAR.Name = "fieldMONTO_ASIGNACION_FAMILIAR"
        '
        'fieldAPELLIDO_PAT_CARGA
        '
        Me.fieldAPELLIDO_PAT_CARGA.AreaIndex = 20
        Me.fieldAPELLIDO_PAT_CARGA.Caption = "Ape.Paterno Carga"
        Me.fieldAPELLIDO_PAT_CARGA.FieldName = "APELLIDO_PAT_CARGA"
        Me.fieldAPELLIDO_PAT_CARGA.Name = "fieldAPELLIDO_PAT_CARGA"
        '
        'fieldAPELLIDO_MAT_CARGA
        '
        Me.fieldAPELLIDO_MAT_CARGA.AreaIndex = 21
        Me.fieldAPELLIDO_MAT_CARGA.Caption = "Ape.Materno Carga"
        Me.fieldAPELLIDO_MAT_CARGA.FieldName = "APELLIDO_MAT_CARGA"
        Me.fieldAPELLIDO_MAT_CARGA.Name = "fieldAPELLIDO_MAT_CARGA"
        '
        'fieldNOMBRES_CARGA
        '
        Me.fieldNOMBRES_CARGA.AreaIndex = 25
        Me.fieldNOMBRES_CARGA.Caption = "Nombre Carga"
        Me.fieldNOMBRES_CARGA.FieldName = "NOMBRES_CARGA"
        Me.fieldNOMBRES_CARGA.Name = "fieldNOMBRES_CARGA"
        '
        'fieldAPELLIDO_PATERNO
        '
        Me.fieldAPELLIDO_PATERNO.AreaIndex = 22
        Me.fieldAPELLIDO_PATERNO.Caption = "Ape.Paterno Empleado"
        Me.fieldAPELLIDO_PATERNO.FieldName = "APELLIDO_PATERNO"
        Me.fieldAPELLIDO_PATERNO.Name = "fieldAPELLIDO_PATERNO"
        '
        'fieldAPELLIDO_MATERNO
        '
        Me.fieldAPELLIDO_MATERNO.AreaIndex = 23
        Me.fieldAPELLIDO_MATERNO.Caption = "Ape.Materno Empleado"
        Me.fieldAPELLIDO_MATERNO.FieldName = "APELLIDO_MATERNO"
        Me.fieldAPELLIDO_MATERNO.Name = "fieldAPELLIDO_MATERNO"
        '
        'fieldNOMBRES
        '
        Me.fieldNOMBRES.AreaIndex = 24
        Me.fieldNOMBRES.Caption = "Nombre Empleado"
        Me.fieldNOMBRES.FieldName = "NOMBRES"
        Me.fieldNOMBRES.Name = "fieldNOMBRES"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Location = New System.Drawing.Point(499, 49)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(144, 23)
        Me.btnExportExcel.TabIndex = 6
        Me.btnExportExcel.Text = "Exportar a Excel"
        '
        'gpcSeleccionDeAño
        '
        Me.gpcSeleccionDeAño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionDeAño.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionDeAño.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionDeAño.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gpcSeleccionDeAño.Controls.Add(Me.btnGenerar)
        Me.gpcSeleccionDeAño.Controls.Add(Me.chkSoloEmpleadosActivos)
        Me.gpcSeleccionDeAño.Controls.Add(Me.btnExportExcel)
        Me.gpcSeleccionDeAño.Controls.Add(Me.txtMesFinal)
        Me.gpcSeleccionDeAño.Controls.Add(Me.lblMesFinal)
        Me.gpcSeleccionDeAño.Controls.Add(Me.txtMesInicial)
        Me.gpcSeleccionDeAño.Controls.Add(Me.lblMesInicial)
        Me.gpcSeleccionDeAño.Controls.Add(Me.luePeriodo)
        Me.gpcSeleccionDeAño.Controls.Add(Me.lblAno)
        Me.gpcSeleccionDeAño.Location = New System.Drawing.Point(12, 12)
        Me.gpcSeleccionDeAño.Name = "gpcSeleccionDeAño"
        Me.gpcSeleccionDeAño.Size = New System.Drawing.Size(918, 132)
        Me.gpcSeleccionDeAño.TabIndex = 7
        Me.gpcSeleccionDeAño.Text = "Selección de Año"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(329, 49)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(150, 23)
        Me.btnGenerar.TabIndex = 7
        Me.btnGenerar.Text = "Generar"
        '
        'chkSoloEmpleadosActivos
        '
        Me.chkSoloEmpleadosActivos.Location = New System.Drawing.Point(118, 105)
        Me.chkSoloEmpleadosActivos.Name = "chkSoloEmpleadosActivos"
        Me.chkSoloEmpleadosActivos.Properties.Caption = "Solo Empleados Activos"
        Me.chkSoloEmpleadosActivos.Size = New System.Drawing.Size(155, 19)
        Me.chkSoloEmpleadosActivos.TabIndex = 6
        '
        'txtMesFinal
        '
        Me.txtMesFinal.Location = New System.Drawing.Point(120, 79)
        Me.txtMesFinal.Name = "txtMesFinal"
        Me.txtMesFinal.Size = New System.Drawing.Size(50, 20)
        Me.txtMesFinal.TabIndex = 5
        '
        'lblMesFinal
        '
        Me.lblMesFinal.Location = New System.Drawing.Point(70, 82)
        Me.lblMesFinal.Name = "lblMesFinal"
        Me.lblMesFinal.Size = New System.Drawing.Size(44, 13)
        Me.lblMesFinal.TabIndex = 4
        Me.lblMesFinal.Text = "Mes Final"
        '
        'txtMesInicial
        '
        Me.txtMesInicial.Location = New System.Drawing.Point(120, 52)
        Me.txtMesInicial.Name = "txtMesInicial"
        Me.txtMesInicial.Size = New System.Drawing.Size(50, 20)
        Me.txtMesInicial.TabIndex = 3
        '
        'lblMesInicial
        '
        Me.lblMesInicial.Location = New System.Drawing.Point(65, 55)
        Me.lblMesInicial.Name = "lblMesInicial"
        Me.lblMesInicial.Size = New System.Drawing.Size(49, 13)
        Me.lblMesInicial.TabIndex = 2
        Me.lblMesInicial.Text = "Mes Inicial"
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(120, 25)
        Me.luePeriodo.Name = "luePeriodo"
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(153, 20)
        Me.luePeriodo.TabIndex = 1
        '
        'lblAno
        '
        Me.lblAno.Location = New System.Drawing.Point(95, 28)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(19, 13)
        Me.lblAno.TabIndex = 0
        Me.lblAno.Text = "Año"
        '
        'frmAnalisisCargasFamiliares
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(938, 578)
        Me.Controls.Add(Me.gpcSeleccionDeAño)
        Me.Controls.Add(Me.pgcAnalisisCargasFamiliares)
        Me.Name = "frmAnalisisCargasFamiliares"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Análisis Cargas Familiares"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pgcAnalisisCargasFamiliares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcSeleccionDeAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionDeAño.ResumeLayout(False)
        Me.gpcSeleccionDeAño.PerformLayout()
        CType(Me.chkSoloEmpleadosActivos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMesFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMesInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim empleado As Empleado

    Private Sub frmAnalisisCargasFamiliares_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarPeriodos()
        chkSoloEmpleadosActivos.Checked = True
        
    End Sub

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

    Private Function ValidaMeses() As Boolean
        Dim ValidacionMeses As Boolean = True
        If Me.txtMesInicial.EditValue <= 0 Then
            txtMesInicial.ErrorText = "Mes inicial debe estar entre 1 y 12"
            ValidacionMeses = False
        End If
        If Me.txtMesFinal.EditValue <= 0 Then
            txtMesFinal.ErrorText = "Mes final debe estar entre 1 y 12"
            ValidacionMeses = False
        End If
        If (Me.txtMesInicial.EditValue > 0 And Me.txtMesFinal.EditValue > 0) And (Me.txtMesFinal.EditValue < Me.txtMesInicial.EditValue) Then
            txtMesFinal.ErrorText = "Mes final no puede ser anterior al mes inicial"
            ValidacionMeses = False
        End If
        Return ValidacionMeses
    End Function

    Private Sub RefrescaDetalle()
        Cursor = Cursors.AppStarting
        empleado = New Empleado
        Try
            pgcAnalisisCargasFamiliares.DataSource = empleado.recuperaAnalisisCargasFamiliares(luePeriodo.EditValue, txtMesInicial.EditValue, txtMesFinal.EditValue, chkSoloEmpleadosActivos.Checked)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al leer datos cargas familiares." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        Dim rutaPlanillaExcel As String
        Try
            With sfdAnalisisCargasFamiliares
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = sfdAnalisisCargasFamiliares.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                pgcAnalisisCargasFamiliares.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

   
    Private Sub btnGenerar_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerar.Click
        If luePeriodo.EditValue <> Nothing Then
            If ValidaMeses() Then
                If MsgBoxResult.Yes = MessageBox.Show("El siguiente informe podría tardar varios minutos, ¿desea continuar?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                    Cursor.Current = Cursors.WaitCursor
                    ' TODO...
                    RefrescaDetalle()
                    Cursor.Current = Cursors.Default
                End If
            End If
        End If


    End Sub
End Class
