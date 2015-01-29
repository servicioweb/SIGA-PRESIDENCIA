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

Public Class frmInformeDetalladoHonorario
    Inherits System.Windows.Forms.Form
    Private empleado As New Empleado
    Private parametroMensual As Periodo

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
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pgcDetalle As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents colNOMBRES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colFECHA_CONTRATO_DESDE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colFECHA_CONTRATO_HASTA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_ENERO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_FEBRERO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_MARZO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_ABRIL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_MAYO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_JUNIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_JULIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_AGOSTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_SEPTIEMBRE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_OCTUBRE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_NOVIEMBRE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_DICIEMBRE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDIRECCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDEPARTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colSUB_DEPTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colTOTAL_ANUAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents btnExportarExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sfdDetalleHonorarios As System.Windows.Forms.SaveFileDialog
    Friend WithEvents colNRO_SOLUCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colFECHA_RESOLUCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colES_RETIRO_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMOTIVO_RETIRO As DevExpress.XtraPivotGrid.PivotGridField
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpcSeleccionAño = New DevExpress.XtraEditors.GroupControl
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.pgcDetalle = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.colNOMBRES = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colRUT = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colDV = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colFECHA_CONTRATO_DESDE = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colFECHA_CONTRATO_HASTA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_ENERO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_FEBRERO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_MARZO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_ABRIL = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_MAYO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_JUNIO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_JULIO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_AGOSTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_SEPTIEMBRE = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_OCTUBRE = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_NOVIEMBRE = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_DICIEMBRE = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colDIRECCION = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colDEPARTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colSUB_DEPTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colTOTAL_ANUAL = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colNRO_SOLUCION = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colFECHA_RESOLUCION = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colES_RETIRO_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.btnExportarExcel = New DevExpress.XtraEditors.SimpleButton
        Me.sfdDetalleHonorarios = New System.Windows.Forms.SaveFileDialog
        Me.colMOTIVO_RETIRO = New DevExpress.XtraPivotGrid.PivotGridField
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionAño.SuspendLayout()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgcDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcSeleccionAño
        '
        Me.gpcSeleccionAño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionAño.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionAño.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionAño.Controls.Add(Me.luePeriodo)
        Me.gpcSeleccionAño.Controls.Add(Me.Label1)
        Me.gpcSeleccionAño.Location = New System.Drawing.Point(0, 8)
        Me.gpcSeleccionAño.Name = "gpcSeleccionAño"
        Me.gpcSeleccionAño.Size = New System.Drawing.Size(1024, 88)
        Me.gpcSeleccionAño.TabIndex = 24
        Me.gpcSeleccionAño.Text = "Selección de Año"
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(56, 32)
        Me.luePeriodo.Name = "luePeriodo"
        '
        'luePeriodo.Properties
        '
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(144, 20)
        Me.luePeriodo.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Año"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pgcDetalle
        '
        Me.pgcDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgcDetalle.Cursor = System.Windows.Forms.Cursors.Default
        Me.pgcDetalle.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.colNOMBRES, Me.colRUT, Me.colDV, Me.colFECHA_CONTRATO_DESDE, Me.colFECHA_CONTRATO_HASTA, Me.colMONTO_ENERO, Me.colMONTO_FEBRERO, Me.colMONTO_MARZO, Me.colMONTO_ABRIL, Me.colMONTO_MAYO, Me.colMONTO_JUNIO, Me.colMONTO_JULIO, Me.colMONTO_AGOSTO, Me.colMONTO_SEPTIEMBRE, Me.colMONTO_OCTUBRE, Me.colMONTO_NOVIEMBRE, Me.colMONTO_DICIEMBRE, Me.colDIRECCION, Me.colDEPARTAMENTO, Me.colSUB_DEPTO, Me.colTOTAL_ANUAL, Me.colNRO_SOLUCION, Me.colFECHA_RESOLUCION, Me.colES_RETIRO_EMPLEADO, Me.colMOTIVO_RETIRO})
        Me.pgcDetalle.Location = New System.Drawing.Point(4, 104)
        Me.pgcDetalle.Name = "pgcDetalle"
        Me.pgcDetalle.Size = New System.Drawing.Size(1024, 232)
        Me.pgcDetalle.TabIndex = 25
        '
        'colNOMBRES
        '
        Me.colNOMBRES.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colNOMBRES.AreaIndex = 0
        Me.colNOMBRES.Caption = "Nombre Funcionario"
        Me.colNOMBRES.FieldName = "NOMBRE_EMPLEADO"
        Me.colNOMBRES.Name = "colNOMBRES"
        Me.colNOMBRES.Width = 200
        '
        'colRUT
        '
        Me.colRUT.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colRUT.AreaIndex = 1
        Me.colRUT.Caption = "Rut"
        Me.colRUT.FieldName = "RUT"
        Me.colRUT.Name = "colRUT"
        Me.colRUT.Width = 80
        '
        'colDV
        '
        Me.colDV.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colDV.AreaIndex = 2
        Me.colDV.Caption = "Dv"
        Me.colDV.FieldName = "DV"
        Me.colDV.Name = "colDV"
        Me.colDV.Width = 50
        '
        'colFECHA_CONTRATO_DESDE
        '
        Me.colFECHA_CONTRATO_DESDE.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colFECHA_CONTRATO_DESDE.AreaIndex = 3
        Me.colFECHA_CONTRATO_DESDE.Caption = "Fecha Inicio"
        Me.colFECHA_CONTRATO_DESDE.CellFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_DESDE.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFECHA_CONTRATO_DESDE.FieldName = "FECHA_CONTRATO_DESDE"
        Me.colFECHA_CONTRATO_DESDE.GrandTotalCellFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_DESDE.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFECHA_CONTRATO_DESDE.Name = "colFECHA_CONTRATO_DESDE"
        Me.colFECHA_CONTRATO_DESDE.TotalCellFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_DESDE.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFECHA_CONTRATO_DESDE.TotalValueFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_DESDE.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFECHA_CONTRATO_DESDE.ValueFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_DESDE.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'colFECHA_CONTRATO_HASTA
        '
        Me.colFECHA_CONTRATO_HASTA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colFECHA_CONTRATO_HASTA.AreaIndex = 4
        Me.colFECHA_CONTRATO_HASTA.Caption = "Fecha Término"
        Me.colFECHA_CONTRATO_HASTA.CellFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_HASTA.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFECHA_CONTRATO_HASTA.FieldName = "FECHA_CONTRATO_HASTA"
        Me.colFECHA_CONTRATO_HASTA.GrandTotalCellFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_HASTA.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFECHA_CONTRATO_HASTA.Name = "colFECHA_CONTRATO_HASTA"
        Me.colFECHA_CONTRATO_HASTA.TotalCellFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_HASTA.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFECHA_CONTRATO_HASTA.TotalValueFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_HASTA.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFECHA_CONTRATO_HASTA.ValueFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_HASTA.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'colMONTO_ENERO
        '
        Me.colMONTO_ENERO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_ENERO.AreaIndex = 0
        Me.colMONTO_ENERO.Caption = "Enero"
        Me.colMONTO_ENERO.CellFormat.FormatString = "n0"
        Me.colMONTO_ENERO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_ENERO.FieldName = "MONTO_ENERO"
        Me.colMONTO_ENERO.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO_ENERO.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_ENERO.Name = "colMONTO_ENERO"
        Me.colMONTO_ENERO.TotalCellFormat.FormatString = "n0"
        Me.colMONTO_ENERO.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_ENERO.TotalValueFormat.FormatString = "n0"
        Me.colMONTO_ENERO.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_ENERO.ValueFormat.FormatString = "n0"
        Me.colMONTO_ENERO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_ENERO.Width = 80
        '
        'colMONTO_FEBRERO
        '
        Me.colMONTO_FEBRERO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_FEBRERO.AreaIndex = 1
        Me.colMONTO_FEBRERO.Caption = "Febrero"
        Me.colMONTO_FEBRERO.CellFormat.FormatString = "n0"
        Me.colMONTO_FEBRERO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_FEBRERO.FieldName = "MONTO_FEBRERO"
        Me.colMONTO_FEBRERO.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO_FEBRERO.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_FEBRERO.Name = "colMONTO_FEBRERO"
        Me.colMONTO_FEBRERO.TotalCellFormat.FormatString = "n0"
        Me.colMONTO_FEBRERO.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_FEBRERO.TotalValueFormat.FormatString = "n0"
        Me.colMONTO_FEBRERO.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_FEBRERO.ValueFormat.FormatString = "n0"
        Me.colMONTO_FEBRERO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_FEBRERO.Width = 80
        '
        'colMONTO_MARZO
        '
        Me.colMONTO_MARZO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_MARZO.AreaIndex = 2
        Me.colMONTO_MARZO.Caption = "Marzo"
        Me.colMONTO_MARZO.CellFormat.FormatString = "n0"
        Me.colMONTO_MARZO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_MARZO.FieldName = "MONTO_MARZO"
        Me.colMONTO_MARZO.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO_MARZO.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_MARZO.Name = "colMONTO_MARZO"
        Me.colMONTO_MARZO.TotalCellFormat.FormatString = "n0"
        Me.colMONTO_MARZO.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_MARZO.TotalValueFormat.FormatString = "n0"
        Me.colMONTO_MARZO.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_MARZO.ValueFormat.FormatString = "n0"
        Me.colMONTO_MARZO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_MARZO.Width = 80
        '
        'colMONTO_ABRIL
        '
        Me.colMONTO_ABRIL.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_ABRIL.AreaIndex = 3
        Me.colMONTO_ABRIL.Caption = "Abril"
        Me.colMONTO_ABRIL.CellFormat.FormatString = "n0"
        Me.colMONTO_ABRIL.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_ABRIL.FieldName = "MONTO_ABRIL"
        Me.colMONTO_ABRIL.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO_ABRIL.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_ABRIL.Name = "colMONTO_ABRIL"
        Me.colMONTO_ABRIL.TotalCellFormat.FormatString = "n0"
        Me.colMONTO_ABRIL.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_ABRIL.TotalValueFormat.FormatString = "n0"
        Me.colMONTO_ABRIL.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_ABRIL.ValueFormat.FormatString = "n0"
        Me.colMONTO_ABRIL.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_ABRIL.Width = 80
        '
        'colMONTO_MAYO
        '
        Me.colMONTO_MAYO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_MAYO.AreaIndex = 4
        Me.colMONTO_MAYO.Caption = "Mayo"
        Me.colMONTO_MAYO.CellFormat.FormatString = "n0"
        Me.colMONTO_MAYO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_MAYO.FieldName = "MONTO_MAYO"
        Me.colMONTO_MAYO.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO_MAYO.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_MAYO.Name = "colMONTO_MAYO"
        Me.colMONTO_MAYO.TotalCellFormat.FormatString = "n0"
        Me.colMONTO_MAYO.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_MAYO.TotalValueFormat.FormatString = "n0"
        Me.colMONTO_MAYO.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_MAYO.ValueFormat.FormatString = "n0"
        Me.colMONTO_MAYO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_MAYO.Width = 80
        '
        'colMONTO_JUNIO
        '
        Me.colMONTO_JUNIO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_JUNIO.AreaIndex = 5
        Me.colMONTO_JUNIO.Caption = "Junio"
        Me.colMONTO_JUNIO.CellFormat.FormatString = "n0"
        Me.colMONTO_JUNIO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_JUNIO.FieldName = "MONTO_JUNIO"
        Me.colMONTO_JUNIO.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO_JUNIO.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_JUNIO.Name = "colMONTO_JUNIO"
        Me.colMONTO_JUNIO.TotalCellFormat.FormatString = "n0"
        Me.colMONTO_JUNIO.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_JUNIO.TotalValueFormat.FormatString = "n0"
        Me.colMONTO_JUNIO.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_JUNIO.ValueFormat.FormatString = "n0"
        Me.colMONTO_JUNIO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_JUNIO.Width = 80
        '
        'colMONTO_JULIO
        '
        Me.colMONTO_JULIO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_JULIO.AreaIndex = 6
        Me.colMONTO_JULIO.Caption = "Julio"
        Me.colMONTO_JULIO.CellFormat.FormatString = "n0"
        Me.colMONTO_JULIO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_JULIO.FieldName = "MONTO_JULIO"
        Me.colMONTO_JULIO.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO_JULIO.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_JULIO.Name = "colMONTO_JULIO"
        Me.colMONTO_JULIO.TotalCellFormat.FormatString = "n0"
        Me.colMONTO_JULIO.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_JULIO.TotalValueFormat.FormatString = "n0"
        Me.colMONTO_JULIO.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_JULIO.ValueFormat.FormatString = "n0"
        Me.colMONTO_JULIO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_JULIO.Width = 80
        '
        'colMONTO_AGOSTO
        '
        Me.colMONTO_AGOSTO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_AGOSTO.AreaIndex = 7
        Me.colMONTO_AGOSTO.Caption = "Agosto"
        Me.colMONTO_AGOSTO.CellFormat.FormatString = "n0"
        Me.colMONTO_AGOSTO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_AGOSTO.FieldName = "MONTO_AGOSTO"
        Me.colMONTO_AGOSTO.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO_AGOSTO.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_AGOSTO.Name = "colMONTO_AGOSTO"
        Me.colMONTO_AGOSTO.TotalCellFormat.FormatString = "n0"
        Me.colMONTO_AGOSTO.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_AGOSTO.TotalValueFormat.FormatString = "n0"
        Me.colMONTO_AGOSTO.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_AGOSTO.ValueFormat.FormatString = "n0"
        Me.colMONTO_AGOSTO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_AGOSTO.Width = 80
        '
        'colMONTO_SEPTIEMBRE
        '
        Me.colMONTO_SEPTIEMBRE.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_SEPTIEMBRE.AreaIndex = 8
        Me.colMONTO_SEPTIEMBRE.Caption = "Septiembre"
        Me.colMONTO_SEPTIEMBRE.CellFormat.FormatString = "n0"
        Me.colMONTO_SEPTIEMBRE.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_SEPTIEMBRE.FieldName = "MONTO_SEPTIEMBRE"
        Me.colMONTO_SEPTIEMBRE.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO_SEPTIEMBRE.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_SEPTIEMBRE.Name = "colMONTO_SEPTIEMBRE"
        Me.colMONTO_SEPTIEMBRE.TotalCellFormat.FormatString = "n0"
        Me.colMONTO_SEPTIEMBRE.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_SEPTIEMBRE.TotalValueFormat.FormatString = "n0"
        Me.colMONTO_SEPTIEMBRE.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_SEPTIEMBRE.ValueFormat.FormatString = "n0"
        Me.colMONTO_SEPTIEMBRE.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_SEPTIEMBRE.Width = 80
        '
        'colMONTO_OCTUBRE
        '
        Me.colMONTO_OCTUBRE.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_OCTUBRE.AreaIndex = 9
        Me.colMONTO_OCTUBRE.Caption = "Octubre"
        Me.colMONTO_OCTUBRE.CellFormat.FormatString = "n0"
        Me.colMONTO_OCTUBRE.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_OCTUBRE.FieldName = "MONTO_OCTUBRE"
        Me.colMONTO_OCTUBRE.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO_OCTUBRE.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_OCTUBRE.Name = "colMONTO_OCTUBRE"
        Me.colMONTO_OCTUBRE.TotalCellFormat.FormatString = "n0"
        Me.colMONTO_OCTUBRE.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_OCTUBRE.TotalValueFormat.FormatString = "n0"
        Me.colMONTO_OCTUBRE.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_OCTUBRE.ValueFormat.FormatString = "n0"
        Me.colMONTO_OCTUBRE.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_OCTUBRE.Width = 80
        '
        'colMONTO_NOVIEMBRE
        '
        Me.colMONTO_NOVIEMBRE.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_NOVIEMBRE.AreaIndex = 10
        Me.colMONTO_NOVIEMBRE.Caption = "Noviembre"
        Me.colMONTO_NOVIEMBRE.CellFormat.FormatString = "n0"
        Me.colMONTO_NOVIEMBRE.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_NOVIEMBRE.FieldName = "MONTO_NOVIEMBRE"
        Me.colMONTO_NOVIEMBRE.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO_NOVIEMBRE.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_NOVIEMBRE.Name = "colMONTO_NOVIEMBRE"
        Me.colMONTO_NOVIEMBRE.TotalCellFormat.FormatString = "n0"
        Me.colMONTO_NOVIEMBRE.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_NOVIEMBRE.TotalValueFormat.FormatString = "n0"
        Me.colMONTO_NOVIEMBRE.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_NOVIEMBRE.ValueFormat.FormatString = "n0"
        Me.colMONTO_NOVIEMBRE.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_NOVIEMBRE.Width = 80
        '
        'colMONTO_DICIEMBRE
        '
        Me.colMONTO_DICIEMBRE.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_DICIEMBRE.AreaIndex = 11
        Me.colMONTO_DICIEMBRE.Caption = "Diciembre"
        Me.colMONTO_DICIEMBRE.CellFormat.FormatString = "n0"
        Me.colMONTO_DICIEMBRE.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_DICIEMBRE.FieldName = "MONTO_DICIEMBRE"
        Me.colMONTO_DICIEMBRE.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO_DICIEMBRE.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_DICIEMBRE.Name = "colMONTO_DICIEMBRE"
        Me.colMONTO_DICIEMBRE.TotalCellFormat.FormatString = "n0"
        Me.colMONTO_DICIEMBRE.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_DICIEMBRE.TotalValueFormat.FormatString = "n0"
        Me.colMONTO_DICIEMBRE.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_DICIEMBRE.ValueFormat.FormatString = "n0"
        Me.colMONTO_DICIEMBRE.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_DICIEMBRE.Width = 80
        '
        'colDIRECCION
        '
        Me.colDIRECCION.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colDIRECCION.AreaIndex = 0
        Me.colDIRECCION.Caption = "Dirección"
        Me.colDIRECCION.FieldName = "DIRECCION"
        Me.colDIRECCION.Name = "colDIRECCION"
        '
        'colDEPARTAMENTO
        '
        Me.colDEPARTAMENTO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colDEPARTAMENTO.AreaIndex = 1
        Me.colDEPARTAMENTO.Caption = "Departamento"
        Me.colDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.colDEPARTAMENTO.Name = "colDEPARTAMENTO"
        '
        'colSUB_DEPTO
        '
        Me.colSUB_DEPTO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colSUB_DEPTO.AreaIndex = 2
        Me.colSUB_DEPTO.Caption = "Sub-Departamento"
        Me.colSUB_DEPTO.FieldName = "SUB_DEPTO"
        Me.colSUB_DEPTO.Name = "colSUB_DEPTO"
        '
        'colTOTAL_ANUAL
        '
        Me.colTOTAL_ANUAL.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.colTOTAL_ANUAL.AreaIndex = 0
        Me.colTOTAL_ANUAL.Caption = "Total Anual"
        Me.colTOTAL_ANUAL.CellFormat.FormatString = "n0"
        Me.colTOTAL_ANUAL.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTOTAL_ANUAL.FieldName = "TOTAL_ANUAL"
        Me.colTOTAL_ANUAL.Name = "colTOTAL_ANUAL"
        Me.colTOTAL_ANUAL.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        '
        'colNRO_SOLUCION
        '
        Me.colNRO_SOLUCION.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colNRO_SOLUCION.AreaIndex = 3
        Me.colNRO_SOLUCION.Caption = "Nro.Resolución"
        Me.colNRO_SOLUCION.FieldName = "NRO_SOLUCION"
        Me.colNRO_SOLUCION.Name = "colNRO_SOLUCION"
        '
        'colFECHA_RESOLUCION
        '
        Me.colFECHA_RESOLUCION.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colFECHA_RESOLUCION.AreaIndex = 4
        Me.colFECHA_RESOLUCION.Caption = "Fecha Resolución"
        Me.colFECHA_RESOLUCION.FieldName = "FECHA_RESOLUCION"
        Me.colFECHA_RESOLUCION.Name = "colFECHA_RESOLUCION"
        '
        'colES_RETIRO_EMPLEADO
        '
        Me.colES_RETIRO_EMPLEADO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colES_RETIRO_EMPLEADO.AreaIndex = 5
        Me.colES_RETIRO_EMPLEADO.Caption = "Es Retiro Funcionario"
        Me.colES_RETIRO_EMPLEADO.FieldName = "ES_RETIRO_EMPLEADO"
        Me.colES_RETIRO_EMPLEADO.Name = "colES_RETIRO_EMPLEADO"
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportarExcel.Location = New System.Drawing.Point(880, 344)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(144, 23)
        Me.btnExportarExcel.TabIndex = 26
        Me.btnExportarExcel.Text = "Exportar a Excel"
        '
        'colMOTIVO_RETIRO
        '
        Me.colMOTIVO_RETIRO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colMOTIVO_RETIRO.AreaIndex = 6
        Me.colMOTIVO_RETIRO.Caption = "Motivo Retiro"
        Me.colMOTIVO_RETIRO.FieldName = "MOTIVO_RETIRO"
        Me.colMOTIVO_RETIRO.Name = "colMOTIVO_RETIRO"
        '
        'frmInformeDetalladoHonorario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1032, 372)
        Me.Controls.Add(Me.btnExportarExcel)
        Me.Controls.Add(Me.pgcDetalle)
        Me.Controls.Add(Me.gpcSeleccionAño)
        Me.Name = "frmInformeDetalladoHonorario"
        Me.Text = "Informe Detallado de Honorario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionAño.ResumeLayout(False)
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgcDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmInformeDetalladoHonorario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        parametroMensual = New Periodo
        repositorio.RefreshDatos("PeriodoAño")
        llenarPeriodos()
    End Sub

    Private Sub refrescaDetalle()
        Cursor.Current = Cursors.WaitCursor
        If luePeriodo.EditValue <> Nothing Then
            Try
                pgcDetalle.DataSource = Nothing
                pgcDetalle.DataSource = empleado.recuperaPresupuestoDetalladoHonorarios(luePeriodo.EditValue)

            Catch ex As Exception
                MsgBox("Ha ocurrido un error al leer datos personal fuera de dotación." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
        Cursor.Current = Cursors.Default
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

    Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        refrescaDetalle()
    End Sub

    Private Sub pgcDetalle_CustomSummary(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs) Handles pgcDetalle.CustomSummary
        If Not e.DataField Is Me.colTOTAL_ANUAL Then Return

        Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
        Dim i As Integer
        Dim totalAnual As Integer = 0
        For i = 0 To ds.RowCount - 1
            Dim row As PivotDrillDownDataRow = ds(i)
            totalAnual += row(Me.colMONTO_ENERO) + row(Me.colMONTO_FEBRERO) + row(Me.colMONTO_MARZO) + row(Me.colMONTO_ABRIL) + row(Me.colMONTO_MAYO) + row(Me.colMONTO_JUNIO) + row(Me.colMONTO_JULIO) + row(Me.colMONTO_AGOSTO) + row(Me.colMONTO_SEPTIEMBRE) + row(Me.colMONTO_OCTUBRE) + row(Me.colMONTO_NOVIEMBRE) + row(Me.colMONTO_DICIEMBRE)
        Next
        e.CustomValue = totalAnual
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Dim rutaPlanillaExcel As String
        Try
            With sfdDetalleHonorarios
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = sfdDetalleHonorarios.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                pgcDetalle.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
