Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraPivotGrid
Imports DevExpress

Imports System.Windows.Forms
Imports System.Drawing
Imports System

Public Class frmLicenciaMedicaInformeGestion
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
    Friend WithEvents gpcSeleccionAño As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents fieldNOMBRE_COMPLETO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRUT_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNUMERO_LICENCIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDIAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCLASIFICACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sfdLicenciaInformeGestion As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pgcLicenciasMedicasInformeGestion As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents gleRut As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gleRutGrid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConsultar2 As System.Windows.Forms.Button
    Friend WithEvents fieldDEPARTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_INICIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_TERMINO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNUMERO_FILIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_RECEPCION_ISAPRE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTADO_LICENCIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMONTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents fieldMES_LICENCIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_ISAPRE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDIAS_ANTIGUEDAD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDIAS_REDUCCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents fieldSUB_DEPTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim PivotGridCustomTotal1 As DevExpress.XtraPivotGrid.PivotGridCustomTotal = New DevExpress.XtraPivotGrid.PivotGridCustomTotal
        Me.pgcLicenciasMedicasInformeGestion = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.fieldMES_LICENCIA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldRUT_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOMBRE_COMPLETO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDEPARTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNUMERO_LICENCIA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNUMERO_FILIO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFECHA_INICIO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFECHA_TERMINO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDIAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDIAS_REDUCCION = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOMBRE_ISAPRE = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFECHA_RECEPCION_ISAPRE = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDIAS_ANTIGUEDAD = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCLASIFICACION = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldESTADO_LICENCIA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMONTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.gpcSeleccionAño = New DevExpress.XtraEditors.GroupControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.gleRut = New DevExpress.XtraEditors.GridLookUpEdit
        Me.gleRutGrid = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.btnConsultar2 = New System.Windows.Forms.Button
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton
        Me.sfdLicenciaInformeGestion = New System.Windows.Forms.SaveFileDialog
        Me.fieldSUB_DEPTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField
        CType(Me.pgcLicenciasMedicasInformeGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionAño.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleRutGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pgcLicenciasMedicasInformeGestion
        '
        Me.pgcLicenciasMedicasInformeGestion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgcLicenciasMedicasInformeGestion.Cursor = System.Windows.Forms.Cursors.Default
        Me.pgcLicenciasMedicasInformeGestion.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldMES_LICENCIA, Me.fieldRUT_EMPLEADO, Me.fieldNOMBRE_COMPLETO, Me.fieldDEPARTAMENTO, Me.fieldNUMERO_LICENCIA, Me.fieldNUMERO_FILIO, Me.fieldFECHA_INICIO, Me.fieldFECHA_TERMINO, Me.fieldDIAS, Me.fieldDIAS_REDUCCION, Me.fieldNOMBRE_ISAPRE, Me.fieldFECHA_RECEPCION_ISAPRE, Me.fieldDIAS_ANTIGUEDAD, Me.fieldCLASIFICACION, Me.fieldESTADO_LICENCIA, Me.fieldMONTO, Me.fieldSUB_DEPTO, Me.PivotGridField1})
        Me.pgcLicenciasMedicasInformeGestion.Location = New System.Drawing.Point(8, 192)
        Me.pgcLicenciasMedicasInformeGestion.Name = "pgcLicenciasMedicasInformeGestion"
        Me.pgcLicenciasMedicasInformeGestion.OptionsBehavior.HorizontalScrolling = DevExpress.XtraPivotGrid.PivotGridScrolling.Control
        Me.pgcLicenciasMedicasInformeGestion.Size = New System.Drawing.Size(704, 440)
        Me.pgcLicenciasMedicasInformeGestion.TabIndex = 2
        '
        'fieldMES_LICENCIA
        '
        Me.fieldMES_LICENCIA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldMES_LICENCIA.AreaIndex = 0
        Me.fieldMES_LICENCIA.Caption = "Mes"
        Me.fieldMES_LICENCIA.FieldName = "MES_LICENCIA"
        Me.fieldMES_LICENCIA.Name = "fieldMES_LICENCIA"
        '
        'fieldRUT_EMPLEADO
        '
        Me.fieldRUT_EMPLEADO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldRUT_EMPLEADO.AreaIndex = 1
        Me.fieldRUT_EMPLEADO.Caption = "RUT"
        Me.fieldRUT_EMPLEADO.FieldName = "RUT_EMPLEADO"
        Me.fieldRUT_EMPLEADO.Name = "fieldRUT_EMPLEADO"
        Me.fieldRUT_EMPLEADO.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldNOMBRE_COMPLETO
        '
        Me.fieldNOMBRE_COMPLETO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNOMBRE_COMPLETO.AreaIndex = 2
        Me.fieldNOMBRE_COMPLETO.Caption = "Nombre Funcionario"
        Me.fieldNOMBRE_COMPLETO.FieldName = "NOMBRE_COMPLETO"
        Me.fieldNOMBRE_COMPLETO.Name = "fieldNOMBRE_COMPLETO"
        Me.fieldNOMBRE_COMPLETO.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldDEPARTAMENTO
        '
        Me.fieldDEPARTAMENTO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldDEPARTAMENTO.AreaIndex = 0
        Me.fieldDEPARTAMENTO.Caption = "Departamento"
        Me.fieldDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.fieldDEPARTAMENTO.Name = "fieldDEPARTAMENTO"
        Me.fieldDEPARTAMENTO.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldNUMERO_LICENCIA
        '
        Me.fieldNUMERO_LICENCIA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNUMERO_LICENCIA.AreaIndex = 3
        Me.fieldNUMERO_LICENCIA.Caption = "N° de Licencia"
        Me.fieldNUMERO_LICENCIA.FieldName = "NUMERO_LICENCIA"
        Me.fieldNUMERO_LICENCIA.Name = "fieldNUMERO_LICENCIA"
        Me.fieldNUMERO_LICENCIA.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldNUMERO_FILIO
        '
        Me.fieldNUMERO_FILIO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNUMERO_FILIO.AreaIndex = 7
        Me.fieldNUMERO_FILIO.Caption = "Número Folio"
        Me.fieldNUMERO_FILIO.FieldName = "NUMERO_FILIO"
        Me.fieldNUMERO_FILIO.Name = "fieldNUMERO_FILIO"
        Me.fieldNUMERO_FILIO.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldFECHA_INICIO
        '
        Me.fieldFECHA_INICIO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldFECHA_INICIO.AreaIndex = 5
        Me.fieldFECHA_INICIO.Caption = "Fecha Inicio"
        Me.fieldFECHA_INICIO.FieldName = "FECHA_INICIO"
        Me.fieldFECHA_INICIO.Name = "fieldFECHA_INICIO"
        Me.fieldFECHA_INICIO.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldFECHA_TERMINO
        '
        Me.fieldFECHA_TERMINO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldFECHA_TERMINO.AreaIndex = 6
        Me.fieldFECHA_TERMINO.Caption = "Fecha Termino"
        Me.fieldFECHA_TERMINO.FieldName = "FECHA_TERMINO"
        Me.fieldFECHA_TERMINO.Name = "fieldFECHA_TERMINO"
        Me.fieldFECHA_TERMINO.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldDIAS
        '
        Me.fieldDIAS.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldDIAS.AreaIndex = 0
        Me.fieldDIAS.Caption = "Días de Licencia"
        Me.fieldDIAS.FieldName = "DIAS"
        Me.fieldDIAS.Name = "fieldDIAS"
        '
        'fieldDIAS_REDUCCION
        '
        Me.fieldDIAS_REDUCCION.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldDIAS_REDUCCION.AreaIndex = 8
        Me.fieldDIAS_REDUCCION.Caption = "Días de Reducción"
        Me.fieldDIAS_REDUCCION.FieldName = "DIAS_REDUCCION"
        Me.fieldDIAS_REDUCCION.Name = "fieldDIAS_REDUCCION"
        '
        'fieldNOMBRE_ISAPRE
        '
        Me.fieldNOMBRE_ISAPRE.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNOMBRE_ISAPRE.AreaIndex = 9
        Me.fieldNOMBRE_ISAPRE.Caption = "Nombre Isapre"
        Me.fieldNOMBRE_ISAPRE.FieldName = "NOMBRE_ISAPRE"
        Me.fieldNOMBRE_ISAPRE.Name = "fieldNOMBRE_ISAPRE"
        '
        'fieldFECHA_RECEPCION_ISAPRE
        '
        Me.fieldFECHA_RECEPCION_ISAPRE.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldFECHA_RECEPCION_ISAPRE.AreaIndex = 10
        Me.fieldFECHA_RECEPCION_ISAPRE.Caption = "Fecha Recepción Isapre"
        Me.fieldFECHA_RECEPCION_ISAPRE.FieldName = "FECHA_RECEPCION_ISAPRE"
        Me.fieldFECHA_RECEPCION_ISAPRE.Name = "fieldFECHA_RECEPCION_ISAPRE"
        Me.fieldFECHA_RECEPCION_ISAPRE.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldDIAS_ANTIGUEDAD
        '
        Me.fieldDIAS_ANTIGUEDAD.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldDIAS_ANTIGUEDAD.AreaIndex = 11
        Me.fieldDIAS_ANTIGUEDAD.Caption = "Días Antiguedad"
        Me.fieldDIAS_ANTIGUEDAD.FieldName = "DIAS_ANTIGUEDAD"
        Me.fieldDIAS_ANTIGUEDAD.Name = "fieldDIAS_ANTIGUEDAD"
        '
        'fieldCLASIFICACION
        '
        Me.fieldCLASIFICACION.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCLASIFICACION.AreaIndex = 4
        Me.fieldCLASIFICACION.Caption = "Entidad de Salud"
        Me.fieldCLASIFICACION.FieldName = "CLASIFICACION"
        Me.fieldCLASIFICACION.Name = "fieldCLASIFICACION"
        Me.fieldCLASIFICACION.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldESTADO_LICENCIA
        '
        Me.fieldESTADO_LICENCIA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldESTADO_LICENCIA.AreaIndex = 12
        Me.fieldESTADO_LICENCIA.Caption = "Estado de Recuperación"
        Me.fieldESTADO_LICENCIA.FieldName = "ESTADO_LICENCIA"
        Me.fieldESTADO_LICENCIA.Name = "fieldESTADO_LICENCIA"
        Me.fieldESTADO_LICENCIA.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldMONTO
        '
        Me.fieldMONTO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldMONTO.AreaIndex = 1
        Me.fieldMONTO.Caption = "Subsidio a Pagar"
        Me.fieldMONTO.CellFormat.FormatString = "n0"
        Me.fieldMONTO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldMONTO.CustomTotals.AddRange(New DevExpress.XtraPivotGrid.PivotGridCustomTotal() {PivotGridCustomTotal1})
        Me.fieldMONTO.FieldName = "MONTO"
        Me.fieldMONTO.Name = "fieldMONTO"
        Me.fieldMONTO.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.CustomTotals
        Me.fieldMONTO.ValueFormat.FormatString = "n0"
        Me.fieldMONTO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'gpcSeleccionAño
        '
        Me.gpcSeleccionAño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionAño.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionAño.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionAño.Controls.Add(Me.Panel1)
        Me.gpcSeleccionAño.Controls.Add(Me.Panel2)
        Me.gpcSeleccionAño.Location = New System.Drawing.Point(8, 16)
        Me.gpcSeleccionAño.Name = "gpcSeleccionAño"
        Me.gpcSeleccionAño.Size = New System.Drawing.Size(704, 160)
        Me.gpcSeleccionAño.TabIndex = 7
        Me.gpcSeleccionAño.Text = "Selección de Año"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnConsultar)
        Me.Panel1.Controls.Add(Me.gleRut)
        Me.Panel1.Controls.Add(Me.lblPeriodo)
        Me.Panel1.Location = New System.Drawing.Point(32, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 48)
        Me.Panel1.TabIndex = 17
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(248, 16)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(120, 23)
        Me.btnConsultar.TabIndex = 7
        Me.btnConsultar.Text = "Consultar Empleado"
        '
        'gleRut
        '
        Me.gleRut.Cursor = System.Windows.Forms.Cursors.Default
        Me.gleRut.EditValue = ""
        Me.gleRut.EnterMoveNextControl = True
        Me.gleRut.Location = New System.Drawing.Point(112, 16)
        Me.gleRut.Name = "gleRut"
        '
        'gleRut.Properties
        '
        Me.gleRut.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        Me.gleRut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleRut.Properties.HideSelection = False
        Me.gleRut.Properties.NullText = ""
        Me.gleRut.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.gleRut.Properties.ValidateOnEnterKey = True
        Me.gleRut.Properties.View = Me.gleRutGrid
        Me.gleRut.Size = New System.Drawing.Size(120, 20)
        Me.gleRut.TabIndex = 10
        '
        'gleRutGrid
        '
        Me.gleRutGrid.AppearancePrint.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.gleRutGrid.AppearancePrint.OddRow.BackColor2 = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.gleRutGrid.AppearancePrint.OddRow.Options.UseBackColor = True
        Me.gleRutGrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gleRutGrid.Name = "gleRutGrid"
        Me.gleRutGrid.OptionsBehavior.Editable = False
        Me.gleRutGrid.OptionsCustomization.AllowFilter = False
        Me.gleRutGrid.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gleRutGrid.OptionsView.ShowGroupPanel = False
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(16, 19)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(88, 16)
        Me.lblPeriodo.TabIndex = 3
        Me.lblPeriodo.Text = "RUT Empleado"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.luePeriodo)
        Me.Panel2.Controls.Add(Me.btnConsultar2)
        Me.Panel2.Location = New System.Drawing.Point(32, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(408, 48)
        Me.Panel2.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Año (Ej: 2010)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(112, 13)
        Me.luePeriodo.Name = "luePeriodo"
        '
        'luePeriodo.Properties
        '
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(120, 20)
        Me.luePeriodo.TabIndex = 16
        '
        'btnConsultar2
        '
        Me.btnConsultar2.Location = New System.Drawing.Point(250, 10)
        Me.btnConsultar2.Name = "btnConsultar2"
        Me.btnConsultar2.Size = New System.Drawing.Size(120, 24)
        Me.btnConsultar2.TabIndex = 15
        Me.btnConsultar2.Text = "Consultar Periodo"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportExcel.Location = New System.Drawing.Point(560, 648)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(144, 23)
        Me.btnExportExcel.TabIndex = 9
        Me.btnExportExcel.Text = "Exportar a Excel"
        '
        'fieldSUB_DEPTO
        '
        Me.fieldSUB_DEPTO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldSUB_DEPTO.AreaIndex = 1
        Me.fieldSUB_DEPTO.Caption = "Sub-Departamento"
        Me.fieldSUB_DEPTO.FieldName = "SUB_DEPTO"
        Me.fieldSUB_DEPTO.Name = "fieldSUB_DEPTO"
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'frmLicenciaMedicaInformeGestion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(720, 692)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.gpcSeleccionAño)
        Me.Controls.Add(Me.pgcLicenciasMedicasInformeGestion)
        Me.Name = "frmLicenciaMedicaInformeGestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Licencias Médicas - Informe de Gestión"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pgcLicenciasMedicasInformeGestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionAño.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleRutGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private empleado As New Empleado
    Private parametroMensual As Periodo

#Region "Funciones"
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
        If IsNumeric(gleRut.EditValue) Then
            If IsNumeric(gleRut.EditValue) Then
                Try

                    pgcLicenciasMedicasInformeGestion.DataSource = empleado.recuperarLicenciaMedicaInformeGestion(empleado.ID)

                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al leer datos personal fuera de dotación." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub refrescaDetalle2()
        Cursor.Current = Cursors.WaitCursor
        If luePeriodo.EditValue <> Nothing Then
            Try
                pgcLicenciasMedicasInformeGestion.DataSource = empleado.recuperarLicenciaMedicaInformeGestionPeriodo(luePeriodo.EditValue)
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al leer datos personal fuera de dotación." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
        Cursor.Current = Cursors.Default
    End Sub
#End Region

    Private Sub frmLicenciaMedicaInformeGestion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarRutEmpleado()
        llenarPeriodos()

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        refrescaDetalle()
        luePeriodo.EditValue = ""


    End Sub

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        Dim rutaPlanillaExcel As String
        Try
            With sfdLicenciaInformeGestion
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = sfdLicenciaInformeGestion.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                pgcLicenciasMedicasInformeGestion.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub gleRut_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gleRut.EditValueChanged
        Cursor.Current = Cursors.WaitCursor
        If IsNumeric(gleRut.EditValue) Then
            Try
                If IsNumeric(gleRut.EditValue) Then
                    parametroMensual = New Periodo
                    empleado = New empleado(CType(gleRut.EditValue, Long))
                    pgcLicenciasMedicasInformeGestion.DataSource = empleado.recuperarLicenciaMedicaInformeGestion(empleado.ID)
                End If
            Catch exp As Exception
                MessageBox.Show("Atención: " & exp.Message, "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
        Cursor.Current = Cursors.Default
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

    Private Sub btnConsultar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar2.Click
        refrescaDetalle2()
        gleRut.Text = ""
    End Sub

    Private Sub luePeriodo_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles luePeriodo.EditValueChanging

    End Sub
End Class
