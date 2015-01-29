Imports cl.presidencia.Argo.BusinessRules
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data.SqlClient
Imports System.IO

Public Class frmCentralizacionContable
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
    Friend WithEvents fieldORGANIZACION_ID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCENTRALIZACION_ID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldITEM_ID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTIPO_ITEM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldITEM_ALIAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDESCRIPCION_LARGA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPERIODO_ID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDESCRIPCION_PERIODO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCALIDAD_JURIDICA_ID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCALIDAD_JURIDICA_DESC As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCUENTA_CONTABLE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCUENTA_PRESUPUESTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIMPUTACION_ID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGLOSA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTADO_REGISTRO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTIPO_CALCULO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMONTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEMPLEADO_ID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTADO_REGISTRO_ESTRUC_CONTABLE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPORCENTAJE_DISTRIB As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCENTRO_COSTO_CONTAB_ID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCENTRO_COSTO_CONTAB_DESC As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCENTRO_COSTO_PRESUP_ID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCENTRO_COSTO_PRESUP_DESC As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents gridCentralizacion As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPROCESO_REMUNERACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCENTRO_COSTO_ALIAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents gpcSeleccionAño As DevExpress.XtraEditors.GroupControl
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents fieldNOMBRE_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDIRECCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDEPARTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents btnGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMesFinal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMesInicial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMesFinal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMesInicial As DevExpress.XtraEditors.LabelControl
    Friend WithEvents fieldSUB_DEPTO As DevExpress.XtraPivotGrid.PivotGridField
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gridCentralizacion = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldORGANIZACION_ID = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCENTRALIZACION_ID = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldITEM_ID = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTIPO_ITEM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldITEM_ALIAS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDESCRIPCION_LARGA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPERIODO_ID = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldANO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDESCRIPCION_PERIODO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCALIDAD_JURIDICA_ID = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCALIDAD_JURIDICA_DESC = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCUENTA_CONTABLE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCUENTA_PRESUPUESTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldIMPUTACION_ID = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldGLOSA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldESTADO_REGISTRO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTIPO_CALCULO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMONTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEMPLEADO_ID = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldESTADO_REGISTRO_ESTRUC_CONTABLE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPORCENTAJE_DISTRIB = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCENTRO_COSTO_CONTAB_ID = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCENTRO_COSTO_CONTAB_DESC = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCENTRO_COSTO_PRESUP_ID = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCENTRO_COSTO_PRESUP_DESC = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRUT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRE_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPROCESO_REMUNERACION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCENTRO_COSTO_ALIAS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDIRECCION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDEPARTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSUB_DEPTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.gpcSeleccionAño = New DevExpress.XtraEditors.GroupControl()
        Me.btnGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtMesFinal = New DevExpress.XtraEditors.TextEdit()
        Me.txtMesInicial = New DevExpress.XtraEditors.TextEdit()
        Me.lblMesFinal = New DevExpress.XtraEditors.LabelControl()
        Me.lblMesInicial = New DevExpress.XtraEditors.LabelControl()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        CType(Me.gridCentralizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionAño.SuspendLayout()
        CType(Me.txtMesFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMesInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridCentralizacion
        '
        Me.gridCentralizacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridCentralizacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridCentralizacion.DataMember = Nothing
        Me.gridCentralizacion.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldORGANIZACION_ID, Me.fieldCENTRALIZACION_ID, Me.fieldITEM_ID, Me.fieldTIPO_ITEM, Me.fieldITEM_ALIAS, Me.fieldDESCRIPCION_LARGA, Me.fieldPERIODO_ID, Me.fieldANO, Me.fieldMES, Me.fieldDESCRIPCION_PERIODO, Me.fieldCALIDAD_JURIDICA_ID, Me.fieldCALIDAD_JURIDICA_DESC, Me.fieldCUENTA_CONTABLE, Me.fieldCUENTA_PRESUPUESTO, Me.fieldIMPUTACION_ID, Me.fieldGLOSA, Me.fieldESTADO_REGISTRO, Me.fieldTIPO_CALCULO, Me.fieldMONTO, Me.fieldEMPLEADO_ID, Me.fieldESTADO_REGISTRO_ESTRUC_CONTABLE, Me.fieldPORCENTAJE_DISTRIB, Me.fieldCENTRO_COSTO_CONTAB_ID, Me.fieldCENTRO_COSTO_CONTAB_DESC, Me.fieldCENTRO_COSTO_PRESUP_ID, Me.fieldCENTRO_COSTO_PRESUP_DESC, Me.fieldRUT, Me.fieldNOMBRE_EMPLEADO, Me.fieldPROCESO_REMUNERACION, Me.fieldCENTRO_COSTO_ALIAS, Me.fieldDIRECCION, Me.fieldDEPARTAMENTO, Me.fieldSUB_DEPTO})
        Me.gridCentralizacion.Location = New System.Drawing.Point(8, 130)
        Me.gridCentralizacion.LookAndFeel.UseWindowsXPTheme = True
        Me.gridCentralizacion.Name = "gridCentralizacion"
        Me.gridCentralizacion.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
        Me.gridCentralizacion.OptionsPrint.MergeRowFieldValues = False
        Me.gridCentralizacion.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridCentralizacion.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridCentralizacion.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridCentralizacion.Size = New System.Drawing.Size(792, 429)
        Me.gridCentralizacion.TabIndex = 0
        '
        'fieldORGANIZACION_ID
        '
        Me.fieldORGANIZACION_ID.AreaIndex = 0
        Me.fieldORGANIZACION_ID.FieldName = "ORGANIZACION_ID"
        Me.fieldORGANIZACION_ID.Name = "fieldORGANIZACION_ID"
        Me.fieldORGANIZACION_ID.Visible = False
        '
        'fieldCENTRALIZACION_ID
        '
        Me.fieldCENTRALIZACION_ID.AreaIndex = 1
        Me.fieldCENTRALIZACION_ID.FieldName = "CENTRALIZACION_ID"
        Me.fieldCENTRALIZACION_ID.Name = "fieldCENTRALIZACION_ID"
        Me.fieldCENTRALIZACION_ID.Visible = False
        '
        'fieldITEM_ID
        '
        Me.fieldITEM_ID.AreaIndex = 1
        Me.fieldITEM_ID.FieldName = "ITEM_ID"
        Me.fieldITEM_ID.Name = "fieldITEM_ID"
        Me.fieldITEM_ID.Visible = False
        '
        'fieldTIPO_ITEM
        '
        Me.fieldTIPO_ITEM.AreaIndex = 1
        Me.fieldTIPO_ITEM.FieldName = "TIPO_ITEM"
        Me.fieldTIPO_ITEM.Name = "fieldTIPO_ITEM"
        Me.fieldTIPO_ITEM.Visible = False
        '
        'fieldITEM_ALIAS
        '
        Me.fieldITEM_ALIAS.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldITEM_ALIAS.AreaIndex = 3
        Me.fieldITEM_ALIAS.Caption = "Ítem"
        Me.fieldITEM_ALIAS.CellFormat.FormatString = "n0"
        Me.fieldITEM_ALIAS.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldITEM_ALIAS.FieldName = "ITEM_ALIAS"
        Me.fieldITEM_ALIAS.Name = "fieldITEM_ALIAS"
        Me.fieldITEM_ALIAS.TotalCellFormat.FormatString = "n0"
        Me.fieldITEM_ALIAS.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldITEM_ALIAS.TotalValueFormat.FormatString = "n0"
        Me.fieldITEM_ALIAS.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldDESCRIPCION_LARGA
        '
        Me.fieldDESCRIPCION_LARGA.AreaIndex = 1
        Me.fieldDESCRIPCION_LARGA.FieldName = "DESCRIPCION_LARGA"
        Me.fieldDESCRIPCION_LARGA.Name = "fieldDESCRIPCION_LARGA"
        Me.fieldDESCRIPCION_LARGA.Visible = False
        '
        'fieldPERIODO_ID
        '
        Me.fieldPERIODO_ID.AreaIndex = 1
        Me.fieldPERIODO_ID.FieldName = "PERIODO_ID"
        Me.fieldPERIODO_ID.Name = "fieldPERIODO_ID"
        Me.fieldPERIODO_ID.Visible = False
        '
        'fieldANO
        '
        Me.fieldANO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldANO.AreaIndex = 0
        Me.fieldANO.Caption = "Año"
        Me.fieldANO.FieldName = "ANO"
        Me.fieldANO.Name = "fieldANO"
        Me.fieldANO.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'fieldMES
        '
        Me.fieldMES.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldMES.AreaIndex = 1
        Me.fieldMES.Caption = "Mes"
        Me.fieldMES.FieldName = "MES"
        Me.fieldMES.Name = "fieldMES"
        Me.fieldMES.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'fieldDESCRIPCION_PERIODO
        '
        Me.fieldDESCRIPCION_PERIODO.AreaIndex = 0
        Me.fieldDESCRIPCION_PERIODO.FieldName = "DESCRIPCION_PERIODO"
        Me.fieldDESCRIPCION_PERIODO.Name = "fieldDESCRIPCION_PERIODO"
        Me.fieldDESCRIPCION_PERIODO.Visible = False
        '
        'fieldCALIDAD_JURIDICA_ID
        '
        Me.fieldCALIDAD_JURIDICA_ID.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCALIDAD_JURIDICA_ID.AreaIndex = 3
        Me.fieldCALIDAD_JURIDICA_ID.FieldName = "CALIDAD_JURIDICA_ID"
        Me.fieldCALIDAD_JURIDICA_ID.Name = "fieldCALIDAD_JURIDICA_ID"
        Me.fieldCALIDAD_JURIDICA_ID.Visible = False
        '
        'fieldCALIDAD_JURIDICA_DESC
        '
        Me.fieldCALIDAD_JURIDICA_DESC.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCALIDAD_JURIDICA_DESC.AreaIndex = 2
        Me.fieldCALIDAD_JURIDICA_DESC.Caption = "Calidad Jurídica"
        Me.fieldCALIDAD_JURIDICA_DESC.FieldName = "CALIDAD_JURIDICA_DESC"
        Me.fieldCALIDAD_JURIDICA_DESC.Name = "fieldCALIDAD_JURIDICA_DESC"
        '
        'fieldCUENTA_CONTABLE
        '
        Me.fieldCUENTA_CONTABLE.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCUENTA_CONTABLE.AreaIndex = 4
        Me.fieldCUENTA_CONTABLE.Caption = "Cuenta Contable"
        Me.fieldCUENTA_CONTABLE.FieldName = "CUENTA_CONTABLE"
        Me.fieldCUENTA_CONTABLE.Name = "fieldCUENTA_CONTABLE"
        '
        'fieldCUENTA_PRESUPUESTO
        '
        Me.fieldCUENTA_PRESUPUESTO.AreaIndex = 1
        Me.fieldCUENTA_PRESUPUESTO.Caption = "Cuenta Contable Presupuestaria"
        Me.fieldCUENTA_PRESUPUESTO.FieldName = "CUENTA_PRESUPUESTO"
        Me.fieldCUENTA_PRESUPUESTO.Name = "fieldCUENTA_PRESUPUESTO"
        '
        'fieldIMPUTACION_ID
        '
        Me.fieldIMPUTACION_ID.AreaIndex = 1
        Me.fieldIMPUTACION_ID.FieldName = "IMPUTACION_ID"
        Me.fieldIMPUTACION_ID.Name = "fieldIMPUTACION_ID"
        Me.fieldIMPUTACION_ID.Visible = False
        '
        'fieldGLOSA
        '
        Me.fieldGLOSA.AreaIndex = 1
        Me.fieldGLOSA.FieldName = "GLOSA"
        Me.fieldGLOSA.Name = "fieldGLOSA"
        Me.fieldGLOSA.Visible = False
        '
        'fieldESTADO_REGISTRO
        '
        Me.fieldESTADO_REGISTRO.AreaIndex = 1
        Me.fieldESTADO_REGISTRO.FieldName = "ESTADO_REGISTRO"
        Me.fieldESTADO_REGISTRO.Name = "fieldESTADO_REGISTRO"
        Me.fieldESTADO_REGISTRO.Visible = False
        '
        'fieldTIPO_CALCULO
        '
        Me.fieldTIPO_CALCULO.AreaIndex = 1
        Me.fieldTIPO_CALCULO.FieldName = "TIPO_CALCULO"
        Me.fieldTIPO_CALCULO.Name = "fieldTIPO_CALCULO"
        Me.fieldTIPO_CALCULO.Visible = False
        '
        'fieldMONTO
        '
        Me.fieldMONTO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldMONTO.AreaIndex = 0
        Me.fieldMONTO.Caption = "Monto"
        Me.fieldMONTO.CellFormat.FormatString = "n0"
        Me.fieldMONTO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldMONTO.FieldName = "MONTO"
        Me.fieldMONTO.Name = "fieldMONTO"
        Me.fieldMONTO.TotalCellFormat.FormatString = "n0"
        Me.fieldMONTO.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldEMPLEADO_ID
        '
        Me.fieldEMPLEADO_ID.AreaIndex = 2
        Me.fieldEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.fieldEMPLEADO_ID.Name = "fieldEMPLEADO_ID"
        Me.fieldEMPLEADO_ID.Visible = False
        '
        'fieldESTADO_REGISTRO_ESTRUC_CONTABLE
        '
        Me.fieldESTADO_REGISTRO_ESTRUC_CONTABLE.AreaIndex = 0
        Me.fieldESTADO_REGISTRO_ESTRUC_CONTABLE.FieldName = "ESTADO_REGISTRO_ESTRUC_CONTABLE"
        Me.fieldESTADO_REGISTRO_ESTRUC_CONTABLE.Name = "fieldESTADO_REGISTRO_ESTRUC_CONTABLE"
        Me.fieldESTADO_REGISTRO_ESTRUC_CONTABLE.Visible = False
        '
        'fieldPORCENTAJE_DISTRIB
        '
        Me.fieldPORCENTAJE_DISTRIB.AreaIndex = 0
        Me.fieldPORCENTAJE_DISTRIB.FieldName = "PORCENTAJE_DISTRIB"
        Me.fieldPORCENTAJE_DISTRIB.Name = "fieldPORCENTAJE_DISTRIB"
        Me.fieldPORCENTAJE_DISTRIB.Visible = False
        '
        'fieldCENTRO_COSTO_CONTAB_ID
        '
        Me.fieldCENTRO_COSTO_CONTAB_ID.AreaIndex = 0
        Me.fieldCENTRO_COSTO_CONTAB_ID.FieldName = "CENTRO_COSTO_CONTAB_ID"
        Me.fieldCENTRO_COSTO_CONTAB_ID.Name = "fieldCENTRO_COSTO_CONTAB_ID"
        Me.fieldCENTRO_COSTO_CONTAB_ID.Visible = False
        '
        'fieldCENTRO_COSTO_CONTAB_DESC
        '
        Me.fieldCENTRO_COSTO_CONTAB_DESC.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldCENTRO_COSTO_CONTAB_DESC.AreaIndex = 0
        Me.fieldCENTRO_COSTO_CONTAB_DESC.Caption = "Centro de Costo Contable"
        Me.fieldCENTRO_COSTO_CONTAB_DESC.FieldName = "CENTRO_COSTO_CONTAB_DESC"
        Me.fieldCENTRO_COSTO_CONTAB_DESC.Name = "fieldCENTRO_COSTO_CONTAB_DESC"
        Me.fieldCENTRO_COSTO_CONTAB_DESC.Visible = False
        '
        'fieldCENTRO_COSTO_PRESUP_ID
        '
        Me.fieldCENTRO_COSTO_PRESUP_ID.AreaIndex = 0
        Me.fieldCENTRO_COSTO_PRESUP_ID.FieldName = "CENTRO_COSTO_PRESUP_ID"
        Me.fieldCENTRO_COSTO_PRESUP_ID.Name = "fieldCENTRO_COSTO_PRESUP_ID"
        Me.fieldCENTRO_COSTO_PRESUP_ID.Visible = False
        '
        'fieldCENTRO_COSTO_PRESUP_DESC
        '
        Me.fieldCENTRO_COSTO_PRESUP_DESC.AreaIndex = 0
        Me.fieldCENTRO_COSTO_PRESUP_DESC.Caption = "Centro de Costo Presupuestario"
        Me.fieldCENTRO_COSTO_PRESUP_DESC.FieldName = "CENTRO_COSTO_PRESUP_DESC"
        Me.fieldCENTRO_COSTO_PRESUP_DESC.Name = "fieldCENTRO_COSTO_PRESUP_DESC"
        '
        'fieldRUT
        '
        Me.fieldRUT.AreaIndex = 2
        Me.fieldRUT.Caption = "RUT"
        Me.fieldRUT.FieldName = "RUT"
        Me.fieldRUT.Name = "fieldRUT"
        Me.fieldRUT.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.DisplayText
        Me.fieldRUT.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
        '
        'fieldNOMBRE_EMPLEADO
        '
        Me.fieldNOMBRE_EMPLEADO.AreaIndex = 5
        Me.fieldNOMBRE_EMPLEADO.Caption = "Empleado"
        Me.fieldNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.Name = "fieldNOMBRE_EMPLEADO"
        '
        'fieldPROCESO_REMUNERACION
        '
        Me.fieldPROCESO_REMUNERACION.AreaIndex = 3
        Me.fieldPROCESO_REMUNERACION.Caption = "Proceso Remuneración"
        Me.fieldPROCESO_REMUNERACION.FieldName = "PROCESO_REMUNERACION"
        Me.fieldPROCESO_REMUNERACION.Name = "fieldPROCESO_REMUNERACION"
        '
        'fieldCENTRO_COSTO_ALIAS
        '
        Me.fieldCENTRO_COSTO_ALIAS.AreaIndex = 4
        Me.fieldCENTRO_COSTO_ALIAS.Caption = "Código Centro Costo"
        Me.fieldCENTRO_COSTO_ALIAS.FieldName = "CENTRO_COSTO_ALIAS"
        Me.fieldCENTRO_COSTO_ALIAS.Name = "fieldCENTRO_COSTO_ALIAS"
        '
        'fieldDIRECCION
        '
        Me.fieldDIRECCION.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldDIRECCION.AreaIndex = 0
        Me.fieldDIRECCION.Caption = "Dirección"
        Me.fieldDIRECCION.FieldName = "DIRECCION"
        Me.fieldDIRECCION.Name = "fieldDIRECCION"
        '
        'fieldDEPARTAMENTO
        '
        Me.fieldDEPARTAMENTO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldDEPARTAMENTO.AreaIndex = 1
        Me.fieldDEPARTAMENTO.Caption = "Departamento"
        Me.fieldDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.fieldDEPARTAMENTO.Name = "fieldDEPARTAMENTO"
        '
        'fieldSUB_DEPTO
        '
        Me.fieldSUB_DEPTO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldSUB_DEPTO.AreaIndex = 2
        Me.fieldSUB_DEPTO.Caption = "Sub-Departamento"
        Me.fieldSUB_DEPTO.FieldName = "SUB_DEPTO"
        Me.fieldSUB_DEPTO.Name = "fieldSUB_DEPTO"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Location = New System.Drawing.Point(459, 61)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(144, 23)
        Me.btnExportExcel.TabIndex = 1
        Me.btnExportExcel.Text = "Exportar a Excel"
        '
        'gpcSeleccionAño
        '
        Me.gpcSeleccionAño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionAño.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionAño.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionAño.Controls.Add(Me.btnGenerar)
        Me.gpcSeleccionAño.Controls.Add(Me.txtMesFinal)
        Me.gpcSeleccionAño.Controls.Add(Me.txtMesInicial)
        Me.gpcSeleccionAño.Controls.Add(Me.lblMesFinal)
        Me.gpcSeleccionAño.Controls.Add(Me.lblMesInicial)
        Me.gpcSeleccionAño.Controls.Add(Me.luePeriodo)
        Me.gpcSeleccionAño.Controls.Add(Me.btnExportExcel)
        Me.gpcSeleccionAño.Controls.Add(Me.lblPeriodo)
        Me.gpcSeleccionAño.Location = New System.Drawing.Point(8, 8)
        Me.gpcSeleccionAño.Name = "gpcSeleccionAño"
        Me.gpcSeleccionAño.Size = New System.Drawing.Size(792, 116)
        Me.gpcSeleccionAño.TabIndex = 5
        Me.gpcSeleccionAño.Text = "Selección de Año"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(307, 61)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(146, 23)
        Me.btnGenerar.TabIndex = 7
        Me.btnGenerar.Text = "Generar"
        '
        'txtMesFinal
        '
        Me.txtMesFinal.Location = New System.Drawing.Point(128, 84)
        Me.txtMesFinal.Name = "txtMesFinal"
        Me.txtMesFinal.Size = New System.Drawing.Size(54, 20)
        Me.txtMesFinal.TabIndex = 6
        '
        'txtMesInicial
        '
        Me.txtMesInicial.Location = New System.Drawing.Point(128, 58)
        Me.txtMesInicial.Name = "txtMesInicial"
        Me.txtMesInicial.Size = New System.Drawing.Size(54, 20)
        Me.txtMesInicial.TabIndex = 6
        '
        'lblMesFinal
        '
        Me.lblMesFinal.Location = New System.Drawing.Point(68, 87)
        Me.lblMesFinal.Name = "lblMesFinal"
        Me.lblMesFinal.Size = New System.Drawing.Size(44, 13)
        Me.lblMesFinal.TabIndex = 5
        Me.lblMesFinal.Text = "Mes Final"
        '
        'lblMesInicial
        '
        Me.lblMesInicial.Location = New System.Drawing.Point(63, 61)
        Me.lblMesInicial.Name = "lblMesInicial"
        Me.lblMesInicial.Size = New System.Drawing.Size(49, 13)
        Me.lblMesInicial.TabIndex = 5
        Me.lblMesInicial.Text = "Mes Inicial"
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(128, 32)
        Me.luePeriodo.Name = "luePeriodo"
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(144, 20)
        Me.luePeriodo.TabIndex = 4
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
        'frmCentralizacionContable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(808, 571)
        Me.Controls.Add(Me.gpcSeleccionAño)
        Me.Controls.Add(Me.gridCentralizacion)
        Me.Name = "frmCentralizacionContable"
        Me.Text = "Centralización Contable / Presupuestaria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridCentralizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionAño.ResumeLayout(False)
        Me.gpcSeleccionAño.PerformLayout()
        CType(Me.txtMesFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMesInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private empleado As Empleado
    Private parametroMensual As Periodo

    Private Sub frmCentralizacionContable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empleado = New Empleado
        parametroMensual = New Periodo
        repositorio.RefreshDatos("PeriodoAño")
        llenarPeriodos()
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

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click

        Dim rutaPlanillaExcel As String

        Try
            With SaveFileDialog1
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = SaveFileDialog1.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                gridCentralizacion.OptionsView.ShowRowTotals = False
                gridCentralizacion.ExportToXls(rutaPlanillaExcel)
                gridCentralizacion.OptionsView.ShowRowTotals = True
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub refrescaDetalle()
        Cursor.Current = Cursors.WaitCursor
        If luePeriodo.EditValue <> Nothing Then
            Try
                gridCentralizacion.DataSource = empleado.recuperaCentralizacionContable(luePeriodo.EditValue, txtMesInicial.EditValue, txtMesFinal.EditValue)
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al leer datos centralización contable." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Function ValidaMeses() As Boolean
        Dim ValidacionMeses As Boolean = True
        If txtMesInicial.EditValue <= 0 Then
            txtMesInicial.ErrorText = "Mes inicial debe estar entre 1 y 12"
            ValidacionMeses = False
        End If
        If txtMesFinal.EditValue <= 0 Then
            txtMesFinal.ErrorText = "Mes final debe estar entre 1 y 12"
            ValidacionMeses = False
        End If
        If (txtMesInicial.EditValue > 0 And txtMesFinal.EditValue > 0) And (txtMesFinal.EditValue < txtMesInicial.EditValue) Then
            txtMesFinal.ErrorText = "Mes final no puede ser anterior al mes inicial"
            ValidacionMeses = False
        End If
        Return ValidacionMeses
    End Function

    Private Sub btnGenerar_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerar.Click
        If luePeriodo.EditValue <> Nothing Then
            If ValidaMeses() Then
                If MsgBoxResult.Yes = MessageBox.Show("El siguiente informe podría tardar varios minutos, ¿desea continuar?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                    refrescaDetalle()
                End If
            End If

        End If
    End Sub
End Class
