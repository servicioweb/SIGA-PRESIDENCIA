Imports cl.presidencia.Argo.BusinessRules
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmAnalisisLiquidaciones
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
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents fieldRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCALIDAD_JURIDICA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGRADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDEPARTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldITEM_ALIAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMONTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTIPO_CALCULO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNUMERO_HORAS_EXTRAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents gridAnalisisLiquidaciones As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldTIPO_ITEM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents gpcSeleccionAño As DevExpress.XtraEditors.GroupControl
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents fieldFUNCIONES_DESEMPENADAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEMPLEADO_ID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSUB_DEPTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDIRECCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAPELLIDO_PATERNO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAPELLIDO_MATERNO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents txtMesFinal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMesInicial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMesFinal As System.Windows.Forms.Label
    Friend WithEvents lblMesInicial As System.Windows.Forms.Label
    Friend WithEvents btnGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents fieldFORMA_PAGO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBANCO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNRO_CUENTA_BANCO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNRO_BIENIOS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRES As DevExpress.XtraPivotGrid.PivotGridField
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalisisLiquidaciones))
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.gridAnalisisLiquidaciones = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldRUT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRE_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldANO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCALIDAD_JURIDICA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldGRADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldESTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDEPARTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldITEM_ALIAS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMONTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTIPO_CALCULO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNUMERO_HORAS_EXTRAS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTIPO_ITEM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFUNCIONES_DESEMPENADAS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEMPLEADO_ID = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSUB_DEPTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDIRECCION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDV = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAPELLIDO_PATERNO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAPELLIDO_MATERNO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFORMA_PAGO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBANCO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNRO_CUENTA_BANCO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNRO_BIENIOS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.gpcSeleccionAño = New DevExpress.XtraEditors.GroupControl()
        Me.btnGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtMesFinal = New DevExpress.XtraEditors.TextEdit()
        Me.txtMesInicial = New DevExpress.XtraEditors.TextEdit()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblMesFinal = New System.Windows.Forms.Label()
        Me.lblMesInicial = New System.Windows.Forms.Label()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        CType(Me.gridAnalisisLiquidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionAño.SuspendLayout()
        CType(Me.txtMesFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMesInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Location = New System.Drawing.Point(451, 49)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(144, 23)
        Me.btnExportExcel.TabIndex = 1
        Me.btnExportExcel.Text = "Exportar a Excel"
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "VW_ANALISIS_LIQUIDACIONES", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RUT", "RUT"), New System.Data.Common.DataColumnMapping("NOMBRE_EMPLEADO", "NOMBRE_EMPLEADO"), New System.Data.Common.DataColumnMapping("ANO", "ANO"), New System.Data.Common.DataColumnMapping("MES", "MES"), New System.Data.Common.DataColumnMapping("CALIDAD_JURIDICA", "CALIDAD_JURIDICA"), New System.Data.Common.DataColumnMapping("GRADO", "GRADO"), New System.Data.Common.DataColumnMapping("ESTAMENTO", "ESTAMENTO"), New System.Data.Common.DataColumnMapping("DEPARTAMENTO", "DEPARTAMENTO"), New System.Data.Common.DataColumnMapping("ITEM_ALIAS", "ITEM_ALIAS"), New System.Data.Common.DataColumnMapping("MONTO", "MONTO"), New System.Data.Common.DataColumnMapping("TIPO_CALCULO", "TIPO_CALCULO"), New System.Data.Common.DataColumnMapping("NUMERO_HORAS_EXTRAS", "NUMERO_HORAS_EXTRAS")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        '
        'gridAnalisisLiquidaciones
        '
        Me.gridAnalisisLiquidaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridAnalisisLiquidaciones.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridAnalisisLiquidaciones.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldRUT, Me.fieldNOMBRE_EMPLEADO, Me.fieldANO, Me.fieldMES, Me.fieldCALIDAD_JURIDICA, Me.fieldGRADO, Me.fieldESTAMENTO, Me.fieldDEPARTAMENTO, Me.fieldITEM_ALIAS, Me.fieldMONTO, Me.fieldTIPO_CALCULO, Me.fieldNUMERO_HORAS_EXTRAS, Me.fieldTIPO_ITEM, Me.fieldFUNCIONES_DESEMPENADAS, Me.fieldEMPLEADO_ID, Me.fieldSUB_DEPTO, Me.fieldDIRECCION, Me.fieldDV, Me.fieldAPELLIDO_PATERNO, Me.fieldAPELLIDO_MATERNO, Me.fieldNOMBRES, Me.fieldFORMA_PAGO, Me.fieldBANCO, Me.fieldNRO_CUENTA_BANCO, Me.fieldNRO_BIENIOS})
        Me.gridAnalisisLiquidaciones.Location = New System.Drawing.Point(8, 131)
        Me.gridAnalisisLiquidaciones.Name = "gridAnalisisLiquidaciones"
        Me.gridAnalisisLiquidaciones.OptionsPrint.MergeRowFieldValues = False
        Me.gridAnalisisLiquidaciones.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridAnalisisLiquidaciones.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridAnalisisLiquidaciones.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridAnalisisLiquidaciones.Size = New System.Drawing.Size(640, 447)
        Me.gridAnalisisLiquidaciones.TabIndex = 2
        '
        'fieldRUT
        '
        Me.fieldRUT.AreaIndex = 0
        Me.fieldRUT.FieldName = "RUT"
        Me.fieldRUT.Name = "fieldRUT"
        '
        'fieldNOMBRE_EMPLEADO
        '
        Me.fieldNOMBRE_EMPLEADO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNOMBRE_EMPLEADO.AreaIndex = 0
        Me.fieldNOMBRE_EMPLEADO.Caption = "Empleado"
        Me.fieldNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.Name = "fieldNOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.Width = 200
        '
        'fieldANO
        '
        Me.fieldANO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldANO.AreaIndex = 1
        Me.fieldANO.Caption = "Año"
        Me.fieldANO.FieldName = "ANO"
        Me.fieldANO.Name = "fieldANO"
        Me.fieldANO.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.fieldANO.Width = 60
        '
        'fieldMES
        '
        Me.fieldMES.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldMES.AreaIndex = 2
        Me.fieldMES.Caption = "Mes"
        Me.fieldMES.FieldName = "MES"
        Me.fieldMES.Name = "fieldMES"
        Me.fieldMES.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.fieldMES.Width = 60
        '
        'fieldCALIDAD_JURIDICA
        '
        Me.fieldCALIDAD_JURIDICA.AreaIndex = 2
        Me.fieldCALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.fieldCALIDAD_JURIDICA.FieldName = "CALIDAD_JURIDICA"
        Me.fieldCALIDAD_JURIDICA.Name = "fieldCALIDAD_JURIDICA"
        '
        'fieldGRADO
        '
        Me.fieldGRADO.AreaIndex = 3
        Me.fieldGRADO.Caption = "Grado"
        Me.fieldGRADO.FieldName = "GRADO"
        Me.fieldGRADO.Name = "fieldGRADO"
        '
        'fieldESTAMENTO
        '
        Me.fieldESTAMENTO.AreaIndex = 4
        Me.fieldESTAMENTO.Caption = "Estamento"
        Me.fieldESTAMENTO.FieldName = "ESTAMENTO"
        Me.fieldESTAMENTO.Name = "fieldESTAMENTO"
        '
        'fieldDEPARTAMENTO
        '
        Me.fieldDEPARTAMENTO.AreaIndex = 5
        Me.fieldDEPARTAMENTO.Caption = "Departamento"
        Me.fieldDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.fieldDEPARTAMENTO.Name = "fieldDEPARTAMENTO"
        '
        'fieldITEM_ALIAS
        '
        Me.fieldITEM_ALIAS.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldITEM_ALIAS.AreaIndex = 0
        Me.fieldITEM_ALIAS.Caption = "Ítem"
        Me.fieldITEM_ALIAS.FieldName = "ITEM_ALIAS"
        Me.fieldITEM_ALIAS.Name = "fieldITEM_ALIAS"
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
        '
        'fieldTIPO_CALCULO
        '
        Me.fieldTIPO_CALCULO.AreaIndex = 6
        Me.fieldTIPO_CALCULO.Caption = "Tipo Cálculo"
        Me.fieldTIPO_CALCULO.FieldName = "TIPO_CALCULO"
        Me.fieldTIPO_CALCULO.Name = "fieldTIPO_CALCULO"
        '
        'fieldNUMERO_HORAS_EXTRAS
        '
        Me.fieldNUMERO_HORAS_EXTRAS.AreaIndex = 8
        Me.fieldNUMERO_HORAS_EXTRAS.Caption = "Horas extras"
        Me.fieldNUMERO_HORAS_EXTRAS.FieldName = "NUMERO_HORAS_EXTRAS"
        Me.fieldNUMERO_HORAS_EXTRAS.Name = "fieldNUMERO_HORAS_EXTRAS"
        '
        'fieldTIPO_ITEM
        '
        Me.fieldTIPO_ITEM.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldTIPO_ITEM.AreaIndex = 1
        Me.fieldTIPO_ITEM.Caption = "Tipo Ítem"
        Me.fieldTIPO_ITEM.FieldName = "TIPO_ITEM"
        Me.fieldTIPO_ITEM.Name = "fieldTIPO_ITEM"
        '
        'fieldFUNCIONES_DESEMPENADAS
        '
        Me.fieldFUNCIONES_DESEMPENADAS.AreaIndex = 9
        Me.fieldFUNCIONES_DESEMPENADAS.Caption = "Funciones Desempeñadas"
        Me.fieldFUNCIONES_DESEMPENADAS.FieldName = "FUNCIONES_DESEMPENADAS"
        Me.fieldFUNCIONES_DESEMPENADAS.Name = "fieldFUNCIONES_DESEMPENADAS"
        '
        'fieldEMPLEADO_ID
        '
        Me.fieldEMPLEADO_ID.AreaIndex = 10
        Me.fieldEMPLEADO_ID.Caption = "ID Empleado"
        Me.fieldEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.fieldEMPLEADO_ID.Name = "fieldEMPLEADO_ID"
        '
        'fieldSUB_DEPTO
        '
        Me.fieldSUB_DEPTO.AreaIndex = 11
        Me.fieldSUB_DEPTO.Caption = "Sub Departamento"
        Me.fieldSUB_DEPTO.FieldName = "SUB_DEPTO"
        Me.fieldSUB_DEPTO.Name = "fieldSUB_DEPTO"
        '
        'fieldDIRECCION
        '
        Me.fieldDIRECCION.AreaIndex = 7
        Me.fieldDIRECCION.Caption = "Dirección"
        Me.fieldDIRECCION.FieldName = "DIRECCION"
        Me.fieldDIRECCION.Name = "fieldDIRECCION"
        '
        'fieldDV
        '
        Me.fieldDV.AreaIndex = 1
        Me.fieldDV.Caption = "DV"
        Me.fieldDV.FieldName = "DV"
        Me.fieldDV.Name = "fieldDV"
        '
        'fieldAPELLIDO_PATERNO
        '
        Me.fieldAPELLIDO_PATERNO.AreaIndex = 12
        Me.fieldAPELLIDO_PATERNO.Caption = "Apellido Paterno"
        Me.fieldAPELLIDO_PATERNO.FieldName = "APELLIDO_PATERNO"
        Me.fieldAPELLIDO_PATERNO.Name = "fieldAPELLIDO_PATERNO"
        '
        'fieldAPELLIDO_MATERNO
        '
        Me.fieldAPELLIDO_MATERNO.AreaIndex = 13
        Me.fieldAPELLIDO_MATERNO.Caption = "Apellido Materno"
        Me.fieldAPELLIDO_MATERNO.FieldName = "APELLIDO_MATERNO"
        Me.fieldAPELLIDO_MATERNO.Name = "fieldAPELLIDO_MATERNO"
        '
        'fieldNOMBRES
        '
        Me.fieldNOMBRES.AreaIndex = 14
        Me.fieldNOMBRES.Caption = "Nombres"
        Me.fieldNOMBRES.FieldName = "NOMBRES"
        Me.fieldNOMBRES.Name = "fieldNOMBRES"
        '
        'fieldFORMA_PAGO
        '
        Me.fieldFORMA_PAGO.AreaIndex = 15
        Me.fieldFORMA_PAGO.Caption = "Forma Pago"
        Me.fieldFORMA_PAGO.FieldName = "FORMA_PAGO"
        Me.fieldFORMA_PAGO.Name = "fieldFORMA_PAGO"
        '
        'fieldBANCO
        '
        Me.fieldBANCO.AreaIndex = 16
        Me.fieldBANCO.Caption = "Banco"
        Me.fieldBANCO.FieldName = "BANCO"
        Me.fieldBANCO.Name = "fieldBANCO"
        '
        'fieldNRO_CUENTA_BANCO
        '
        Me.fieldNRO_CUENTA_BANCO.AreaIndex = 17
        Me.fieldNRO_CUENTA_BANCO.Caption = "Nro. Cuenta Bancaria"
        Me.fieldNRO_CUENTA_BANCO.FieldName = "NRO_CUENTA_BANCO"
        Me.fieldNRO_CUENTA_BANCO.Name = "fieldNRO_CUENTA_BANCO"
        '
        'fieldNRO_BIENIOS
        '
        Me.fieldNRO_BIENIOS.AreaIndex = 18
        Me.fieldNRO_BIENIOS.Caption = "Nro. Bienios"
        Me.fieldNRO_BIENIOS.FieldName = "NUMERO_BIENIOS"
        Me.fieldNRO_BIENIOS.Name = "fieldNRO_BIENIOS"
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
        Me.gpcSeleccionAño.Controls.Add(Me.btnExportExcel)
        Me.gpcSeleccionAño.Controls.Add(Me.luePeriodo)
        Me.gpcSeleccionAño.Controls.Add(Me.lblMesFinal)
        Me.gpcSeleccionAño.Controls.Add(Me.lblMesInicial)
        Me.gpcSeleccionAño.Controls.Add(Me.lblPeriodo)
        Me.gpcSeleccionAño.Location = New System.Drawing.Point(8, 8)
        Me.gpcSeleccionAño.Name = "gpcSeleccionAño"
        Me.gpcSeleccionAño.Size = New System.Drawing.Size(640, 117)
        Me.gpcSeleccionAño.TabIndex = 4
        Me.gpcSeleccionAño.Text = "Selección de Año"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(300, 49)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(145, 23)
        Me.btnGenerar.TabIndex = 6
        Me.btnGenerar.Text = "Generar"
        '
        'txtMesFinal
        '
        Me.txtMesFinal.Location = New System.Drawing.Point(128, 85)
        Me.txtMesFinal.Name = "txtMesFinal"
        Me.txtMesFinal.Properties.Mask.EditMask = "n0"
        Me.txtMesFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMesFinal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMesFinal.Properties.MaxLength = 2
        Me.txtMesFinal.Size = New System.Drawing.Size(53, 20)
        Me.txtMesFinal.TabIndex = 5
        '
        'txtMesInicial
        '
        Me.txtMesInicial.Location = New System.Drawing.Point(128, 59)
        Me.txtMesInicial.Name = "txtMesInicial"
        Me.txtMesInicial.Properties.Mask.EditMask = "n0"
        Me.txtMesInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMesInicial.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMesInicial.Properties.MaxLength = 2
        Me.txtMesInicial.Size = New System.Drawing.Size(53, 20)
        Me.txtMesInicial.TabIndex = 5
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(128, 32)
        Me.luePeriodo.Name = "luePeriodo"
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(144, 20)
        Me.luePeriodo.TabIndex = 4
        '
        'lblMesFinal
        '
        Me.lblMesFinal.Location = New System.Drawing.Point(49, 88)
        Me.lblMesFinal.Name = "lblMesFinal"
        Me.lblMesFinal.Size = New System.Drawing.Size(63, 17)
        Me.lblMesFinal.TabIndex = 3
        Me.lblMesFinal.Text = "Mes Final"
        Me.lblMesFinal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMesInicial
        '
        Me.lblMesInicial.Location = New System.Drawing.Point(49, 62)
        Me.lblMesInicial.Name = "lblMesInicial"
        Me.lblMesInicial.Size = New System.Drawing.Size(63, 15)
        Me.lblMesInicial.TabIndex = 3
        Me.lblMesInicial.Text = "Mes Inicial"
        Me.lblMesInicial.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        'frmAnalisisLiquidaciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(656, 590)
        Me.Controls.Add(Me.gpcSeleccionAño)
        Me.Controls.Add(Me.gridAnalisisLiquidaciones)
        Me.Name = "frmAnalisisLiquidaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Análisis de Liquidaciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridAnalisisLiquidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionAño.ResumeLayout(False)
        CType(Me.txtMesFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMesInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private empleado As Empleado
    Private parametroMensual As Periodo

    Private Sub frmAnalisisLiquidaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empleado = New Empleado
        parametroMensual = New Periodo
        repositorio.RefreshDatos("PeriodoAño")
        llenarPeriodos()
        AddHandler luePeriodo.MouseWheel, AddressOf luePeriodo_Properties_MouseWheel
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
                gridAnalisisLiquidaciones.OptionsView.ShowRowTotals = False
                gridAnalisisLiquidaciones.ExportToXls(rutaPlanillaExcel)
                gridAnalisisLiquidaciones.OptionsView.ShowRowTotals = True
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub refrescaDetalle()
        Cursor.Current = Cursors.WaitCursor
        If luePeriodo.EditValue <> Nothing Then
            Try
                gridAnalisisLiquidaciones.DataSource = empleado.recuperaAnalisisDinamicoLiquidaciones(luePeriodo.EditValue, txtMesInicial.EditValue, txtMesFinal.EditValue)
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al leer datos analisis de liquidaciones." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
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

    Private Sub gpcSeleccionAño_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles gpcSeleccionAño.Paint

    End Sub

    Private Sub btnGenerar_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerar.Click
        If luePeriodo.EditValue <> Nothing Then
            If ValidaMeses() Then
                If MsgBoxResult.Yes = MessageBox.Show("El siguiente informe podría tardar varios minutos, ¿desea continuar?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                    refrescaDetalle()
                End If
            End If

        End If
    End Sub

    Private Sub luePeriodo_Properties_MouseWheel(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles luePeriodo.Properties.MouseWheel
        DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = True
    End Sub
End Class
