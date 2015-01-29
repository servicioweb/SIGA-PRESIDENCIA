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

Public Class frmAnalisisRatificacionHorasExtras
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
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents pgcAnalisisRatificacionHorasExtras As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldNOMBRE_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANO_REAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMES_REAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_ASISTENCIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORA_ENTRADA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORA_SALIDA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORAS_TRABAJADAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORAS_EXTRAS_DIURNAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORAS_EXTRAS_DIURNAS_AUTORIZADAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORAS_EXTRAS_NOCTURNAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORAS_EXTRAS_NOCTURNAS_AUTORIZADAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORAS_ATRASOS_AUTORIZADOS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCANTIDAD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_AUTORIZADOR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEVENTO_ADMINISTRATIVO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDEPARTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDIA_SEMANA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sfdRatificacionHorasExtras As System.Windows.Forms.SaveFileDialog
    Friend WithEvents fieldHORAS_COMPENSADAS_DIURNAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORAS_COMPENSADAS_NOCTURNAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSEXO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCALIDAD_JURIDICA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpcSeleccionAño = New DevExpress.XtraEditors.GroupControl
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.pgcAnalisisRatificacionHorasExtras = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.fieldNOMBRE_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldANO_REAL = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMES_REAL = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldRUT = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDV = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFECHA_ASISTENCIA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHORA_ENTRADA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHORA_SALIDA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHORAS_TRABAJADAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHORAS_EXTRAS_DIURNAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHORAS_EXTRAS_DIURNAS_AUTORIZADAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHORAS_EXTRAS_NOCTURNAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHORAS_EXTRAS_NOCTURNAS_AUTORIZADAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHORAS_ATRASOS_AUTORIZADOS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHORAS_COMPENSADAS_DIURNAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHORAS_COMPENSADAS_NOCTURNAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCANTIDAD = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOMBRE_AUTORIZADOR = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldEVENTO_ADMINISTRATIVO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDEPARTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDIA_SEMANA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton
        Me.sfdRatificacionHorasExtras = New System.Windows.Forms.SaveFileDialog
        Me.fieldSEXO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCALIDAD_JURIDICA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldESTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionAño.SuspendLayout()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgcAnalisisRatificacionHorasExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcSeleccionAño
        '
        Me.gpcSeleccionAño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionAño.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionAño.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionAño.Controls.Add(Me.luePeriodo)
        Me.gpcSeleccionAño.Controls.Add(Me.lblPeriodo)
        Me.gpcSeleccionAño.Location = New System.Drawing.Point(8, 8)
        Me.gpcSeleccionAño.Name = "gpcSeleccionAño"
        Me.gpcSeleccionAño.Size = New System.Drawing.Size(768, 80)
        Me.gpcSeleccionAño.TabIndex = 5
        Me.gpcSeleccionAño.Text = "Selección de Año"
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(128, 32)
        Me.luePeriodo.Name = "luePeriodo"
        '
        'luePeriodo.Properties
        '
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
        'pgcAnalisisRatificacionHorasExtras
        '
        Me.pgcAnalisisRatificacionHorasExtras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgcAnalisisRatificacionHorasExtras.Cursor = System.Windows.Forms.Cursors.Default
        Me.pgcAnalisisRatificacionHorasExtras.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldNOMBRE_EMPLEADO, Me.fieldANO_REAL, Me.fieldMES_REAL, Me.fieldRUT, Me.fieldDV, Me.fieldFECHA_ASISTENCIA, Me.fieldHORA_ENTRADA, Me.fieldHORA_SALIDA, Me.fieldHORAS_TRABAJADAS, Me.fieldHORAS_EXTRAS_DIURNAS, Me.fieldHORAS_EXTRAS_DIURNAS_AUTORIZADAS, Me.fieldHORAS_EXTRAS_NOCTURNAS, Me.fieldHORAS_EXTRAS_NOCTURNAS_AUTORIZADAS, Me.fieldHORAS_ATRASOS_AUTORIZADOS, Me.fieldHORAS_COMPENSADAS_DIURNAS, Me.fieldHORAS_COMPENSADAS_NOCTURNAS, Me.fieldCANTIDAD, Me.fieldNOMBRE_AUTORIZADOR, Me.fieldEVENTO_ADMINISTRATIVO, Me.fieldDEPARTAMENTO, Me.fieldDIA_SEMANA, Me.fieldSEXO, Me.fieldCALIDAD_JURIDICA, Me.fieldESTAMENTO})
        Me.pgcAnalisisRatificacionHorasExtras.Location = New System.Drawing.Point(8, 88)
        Me.pgcAnalisisRatificacionHorasExtras.Name = "pgcAnalisisRatificacionHorasExtras"
        Me.pgcAnalisisRatificacionHorasExtras.OptionsBehavior.HorizontalScrolling = DevExpress.XtraPivotGrid.PivotGridScrolling.Control
        Me.pgcAnalisisRatificacionHorasExtras.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
        Me.pgcAnalisisRatificacionHorasExtras.Size = New System.Drawing.Size(768, 280)
        Me.pgcAnalisisRatificacionHorasExtras.TabIndex = 6
        '
        'fieldNOMBRE_EMPLEADO
        '
        Me.fieldNOMBRE_EMPLEADO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNOMBRE_EMPLEADO.AreaIndex = 1
        Me.fieldNOMBRE_EMPLEADO.Caption = "Empleado"
        Me.fieldNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.Name = "fieldNOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.Width = 300
        '
        'fieldANO_REAL
        '
        Me.fieldANO_REAL.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldANO_REAL.AreaIndex = 0
        Me.fieldANO_REAL.Caption = "Año"
        Me.fieldANO_REAL.FieldName = "ANO_REAL"
        Me.fieldANO_REAL.Name = "fieldANO_REAL"
        '
        'fieldMES_REAL
        '
        Me.fieldMES_REAL.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldMES_REAL.AreaIndex = 1
        Me.fieldMES_REAL.Caption = "Mes"
        Me.fieldMES_REAL.FieldName = "MES_REAL"
        Me.fieldMES_REAL.Name = "fieldMES_REAL"
        '
        'fieldRUT
        '
        Me.fieldRUT.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldRUT.AreaIndex = 2
        Me.fieldRUT.Caption = "Rut"
        Me.fieldRUT.FieldName = "RUT"
        Me.fieldRUT.Name = "fieldRUT"
        '
        'fieldDV
        '
        Me.fieldDV.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldDV.AreaIndex = 7
        Me.fieldDV.Caption = "DV"
        Me.fieldDV.FieldName = "DV"
        Me.fieldDV.Name = "fieldDV"
        '
        'fieldFECHA_ASISTENCIA
        '
        Me.fieldFECHA_ASISTENCIA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldFECHA_ASISTENCIA.AreaIndex = 0
        Me.fieldFECHA_ASISTENCIA.Caption = "Fecha Asistencia"
        Me.fieldFECHA_ASISTENCIA.FieldName = "FECHA_ASISTENCIA"
        Me.fieldFECHA_ASISTENCIA.Name = "fieldFECHA_ASISTENCIA"
        Me.fieldFECHA_ASISTENCIA.TotalCellFormat.FormatString = "d"
        Me.fieldFECHA_ASISTENCIA.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldFECHA_ASISTENCIA.TotalValueFormat.FormatString = "d"
        Me.fieldFECHA_ASISTENCIA.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldFECHA_ASISTENCIA.ValueFormat.FormatString = "d"
        Me.fieldFECHA_ASISTENCIA.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'fieldHORA_ENTRADA
        '
        Me.fieldHORA_ENTRADA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHORA_ENTRADA.AreaIndex = 2
        Me.fieldHORA_ENTRADA.Caption = "Hr. Entrada"
        Me.fieldHORA_ENTRADA.CellFormat.FormatString = "t"
        Me.fieldHORA_ENTRADA.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORA_ENTRADA.FieldName = "HORA_ENTRADA"
        Me.fieldHORA_ENTRADA.GrandTotalCellFormat.FormatString = "t"
        Me.fieldHORA_ENTRADA.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORA_ENTRADA.Name = "fieldHORA_ENTRADA"
        Me.fieldHORA_ENTRADA.TotalCellFormat.FormatString = "t"
        Me.fieldHORA_ENTRADA.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORA_ENTRADA.TotalValueFormat.FormatString = "t"
        Me.fieldHORA_ENTRADA.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORA_ENTRADA.ValueFormat.FormatString = "t"
        Me.fieldHORA_ENTRADA.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORA_ENTRADA.Width = 150
        '
        'fieldHORA_SALIDA
        '
        Me.fieldHORA_SALIDA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHORA_SALIDA.AreaIndex = 3
        Me.fieldHORA_SALIDA.Caption = "Hr.Salida"
        Me.fieldHORA_SALIDA.FieldName = "HORA_SALIDA"
        Me.fieldHORA_SALIDA.Name = "fieldHORA_SALIDA"
        Me.fieldHORA_SALIDA.TotalCellFormat.FormatString = "t"
        Me.fieldHORA_SALIDA.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORA_SALIDA.TotalValueFormat.FormatString = "t"
        Me.fieldHORA_SALIDA.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORA_SALIDA.ValueFormat.FormatString = "t"
        Me.fieldHORA_SALIDA.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORA_SALIDA.Width = 150
        '
        'fieldHORAS_TRABAJADAS
        '
        Me.fieldHORAS_TRABAJADAS.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHORAS_TRABAJADAS.AreaIndex = 4
        Me.fieldHORAS_TRABAJADAS.Caption = "Hrs.Trabajadas"
        Me.fieldHORAS_TRABAJADAS.CellFormat.FormatString = "t"
        Me.fieldHORAS_TRABAJADAS.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_TRABAJADAS.FieldName = "HORAS_TRABAJADAS"
        Me.fieldHORAS_TRABAJADAS.Name = "fieldHORAS_TRABAJADAS"
        Me.fieldHORAS_TRABAJADAS.TotalCellFormat.FormatString = "t"
        Me.fieldHORAS_TRABAJADAS.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_TRABAJADAS.TotalValueFormat.FormatString = "t"
        Me.fieldHORAS_TRABAJADAS.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_TRABAJADAS.ValueFormat.FormatString = "t"
        Me.fieldHORAS_TRABAJADAS.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_TRABAJADAS.Width = 150
        '
        'fieldHORAS_EXTRAS_DIURNAS
        '
        Me.fieldHORAS_EXTRAS_DIURNAS.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHORAS_EXTRAS_DIURNAS.AreaIndex = 5
        Me.fieldHORAS_EXTRAS_DIURNAS.Caption = "Hrs.Ext.Diunas Real"
        Me.fieldHORAS_EXTRAS_DIURNAS.FieldName = "HORAS_EXTRAS_DIURNAS"
        Me.fieldHORAS_EXTRAS_DIURNAS.Name = "fieldHORAS_EXTRAS_DIURNAS"
        Me.fieldHORAS_EXTRAS_DIURNAS.TotalValueFormat.FormatString = "t"
        Me.fieldHORAS_EXTRAS_DIURNAS.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_EXTRAS_DIURNAS.ValueFormat.FormatString = "t"
        Me.fieldHORAS_EXTRAS_DIURNAS.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_EXTRAS_DIURNAS.Width = 150
        '
        'fieldHORAS_EXTRAS_DIURNAS_AUTORIZADAS
        '
        Me.fieldHORAS_EXTRAS_DIURNAS_AUTORIZADAS.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHORAS_EXTRAS_DIURNAS_AUTORIZADAS.AreaIndex = 6
        Me.fieldHORAS_EXTRAS_DIURNAS_AUTORIZADAS.Caption = "Hrs.Ext.Diurnas Ratif."
        Me.fieldHORAS_EXTRAS_DIURNAS_AUTORIZADAS.FieldName = "HORAS_EXTRAS_DIURNAS_AUTORIZADAS"
        Me.fieldHORAS_EXTRAS_DIURNAS_AUTORIZADAS.Name = "fieldHORAS_EXTRAS_DIURNAS_AUTORIZADAS"
        Me.fieldHORAS_EXTRAS_DIURNAS_AUTORIZADAS.TotalCellFormat.FormatString = "t"
        Me.fieldHORAS_EXTRAS_DIURNAS_AUTORIZADAS.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_EXTRAS_DIURNAS_AUTORIZADAS.TotalValueFormat.FormatString = "t"
        Me.fieldHORAS_EXTRAS_DIURNAS_AUTORIZADAS.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_EXTRAS_DIURNAS_AUTORIZADAS.ValueFormat.FormatString = "t"
        Me.fieldHORAS_EXTRAS_DIURNAS_AUTORIZADAS.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_EXTRAS_DIURNAS_AUTORIZADAS.Width = 150
        '
        'fieldHORAS_EXTRAS_NOCTURNAS
        '
        Me.fieldHORAS_EXTRAS_NOCTURNAS.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHORAS_EXTRAS_NOCTURNAS.AreaIndex = 7
        Me.fieldHORAS_EXTRAS_NOCTURNAS.Caption = "Hrs.Ext.Nocturnas Real"
        Me.fieldHORAS_EXTRAS_NOCTURNAS.FieldName = "HORAS_EXTRAS_NOCTURNAS"
        Me.fieldHORAS_EXTRAS_NOCTURNAS.Name = "fieldHORAS_EXTRAS_NOCTURNAS"
        Me.fieldHORAS_EXTRAS_NOCTURNAS.TotalCellFormat.FormatString = "t"
        Me.fieldHORAS_EXTRAS_NOCTURNAS.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_EXTRAS_NOCTURNAS.TotalValueFormat.FormatString = "t"
        Me.fieldHORAS_EXTRAS_NOCTURNAS.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_EXTRAS_NOCTURNAS.ValueFormat.FormatString = "t"
        Me.fieldHORAS_EXTRAS_NOCTURNAS.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_EXTRAS_NOCTURNAS.Width = 150
        '
        'fieldHORAS_EXTRAS_NOCTURNAS_AUTORIZADAS
        '
        Me.fieldHORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.AreaIndex = 8
        Me.fieldHORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.Caption = "Hrs.Ext.Nocturnas Ratif."
        Me.fieldHORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.FieldName = "HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS"
        Me.fieldHORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.Name = "fieldHORAS_EXTRAS_NOCTURNAS_AUTORIZADAS"
        Me.fieldHORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.TotalCellFormat.FormatString = "t"
        Me.fieldHORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.TotalValueFormat.FormatString = "t"
        Me.fieldHORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.ValueFormat.FormatString = "t"
        Me.fieldHORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.Width = 150
        '
        'fieldHORAS_ATRASOS_AUTORIZADOS
        '
        Me.fieldHORAS_ATRASOS_AUTORIZADOS.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHORAS_ATRASOS_AUTORIZADOS.AreaIndex = 9
        Me.fieldHORAS_ATRASOS_AUTORIZADOS.Caption = "Atrasos"
        Me.fieldHORAS_ATRASOS_AUTORIZADOS.FieldName = "HORAS_ATRASOS_AUTORIZADOS"
        Me.fieldHORAS_ATRASOS_AUTORIZADOS.Name = "fieldHORAS_ATRASOS_AUTORIZADOS"
        Me.fieldHORAS_ATRASOS_AUTORIZADOS.TotalCellFormat.FormatString = "t"
        Me.fieldHORAS_ATRASOS_AUTORIZADOS.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_ATRASOS_AUTORIZADOS.TotalValueFormat.FormatString = "t"
        Me.fieldHORAS_ATRASOS_AUTORIZADOS.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_ATRASOS_AUTORIZADOS.ValueFormat.FormatString = "t"
        Me.fieldHORAS_ATRASOS_AUTORIZADOS.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_ATRASOS_AUTORIZADOS.Width = 150
        '
        'fieldHORAS_COMPENSADAS_DIURNAS
        '
        Me.fieldHORAS_COMPENSADAS_DIURNAS.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHORAS_COMPENSADAS_DIURNAS.AreaIndex = 10
        Me.fieldHORAS_COMPENSADAS_DIURNAS.Caption = "Hrs.Comp.Diurnas"
        Me.fieldHORAS_COMPENSADAS_DIURNAS.FieldName = "HORAS_COMPENSADAS_DIURNAS"
        Me.fieldHORAS_COMPENSADAS_DIURNAS.Name = "fieldHORAS_COMPENSADAS_DIURNAS"
        Me.fieldHORAS_COMPENSADAS_DIURNAS.TotalValueFormat.FormatString = "t"
        Me.fieldHORAS_COMPENSADAS_DIURNAS.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_COMPENSADAS_DIURNAS.ValueFormat.FormatString = "t"
        Me.fieldHORAS_COMPENSADAS_DIURNAS.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'fieldHORAS_COMPENSADAS_NOCTURNAS
        '
        Me.fieldHORAS_COMPENSADAS_NOCTURNAS.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHORAS_COMPENSADAS_NOCTURNAS.AreaIndex = 11
        Me.fieldHORAS_COMPENSADAS_NOCTURNAS.Caption = "Hrs.Comp.Nocturnas"
        Me.fieldHORAS_COMPENSADAS_NOCTURNAS.FieldName = "HORAS_COMPENSADAS_NOCTURNAS"
        Me.fieldHORAS_COMPENSADAS_NOCTURNAS.Name = "fieldHORAS_COMPENSADAS_NOCTURNAS"
        Me.fieldHORAS_COMPENSADAS_NOCTURNAS.TotalValueFormat.FormatString = "t"
        Me.fieldHORAS_COMPENSADAS_NOCTURNAS.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldHORAS_COMPENSADAS_NOCTURNAS.ValueFormat.FormatString = "t"
        Me.fieldHORAS_COMPENSADAS_NOCTURNAS.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'fieldCANTIDAD
        '
        Me.fieldCANTIDAD.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCANTIDAD.AreaIndex = 0
        Me.fieldCANTIDAD.Caption = "Cantidad"
        Me.fieldCANTIDAD.FieldName = "CANTIDAD_REAL"
        Me.fieldCANTIDAD.Name = "fieldCANTIDAD"
        '
        'fieldNOMBRE_AUTORIZADOR
        '
        Me.fieldNOMBRE_AUTORIZADOR.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldNOMBRE_AUTORIZADOR.AreaIndex = 3
        Me.fieldNOMBRE_AUTORIZADOR.Caption = "Autorizador Hra.Extra"
        Me.fieldNOMBRE_AUTORIZADOR.FieldName = "NOMBRE_AUTORIZADOR"
        Me.fieldNOMBRE_AUTORIZADOR.Name = "fieldNOMBRE_AUTORIZADOR"
        '
        'fieldEVENTO_ADMINISTRATIVO
        '
        Me.fieldEVENTO_ADMINISTRATIVO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldEVENTO_ADMINISTRATIVO.AreaIndex = 4
        Me.fieldEVENTO_ADMINISTRATIVO.Caption = "Evento Admin."
        Me.fieldEVENTO_ADMINISTRATIVO.FieldName = "EVENTO_ADMINISTRATIVO"
        Me.fieldEVENTO_ADMINISTRATIVO.Name = "fieldEVENTO_ADMINISTRATIVO"
        '
        'fieldDEPARTAMENTO
        '
        Me.fieldDEPARTAMENTO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldDEPARTAMENTO.AreaIndex = 5
        Me.fieldDEPARTAMENTO.Caption = "Departamento"
        Me.fieldDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.fieldDEPARTAMENTO.Name = "fieldDEPARTAMENTO"
        '
        'fieldDIA_SEMANA
        '
        Me.fieldDIA_SEMANA.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldDIA_SEMANA.AreaIndex = 6
        Me.fieldDIA_SEMANA.Caption = "Día Semana"
        Me.fieldDIA_SEMANA.FieldName = "DIA_SEMANA"
        Me.fieldDIA_SEMANA.Name = "fieldDIA_SEMANA"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportExcel.Location = New System.Drawing.Point(624, 376)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(144, 23)
        Me.btnExportExcel.TabIndex = 7
        Me.btnExportExcel.Text = "Exportar a Excel"
        '
        'fieldSEXO
        '
        Me.fieldSEXO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldSEXO.AreaIndex = 8
        Me.fieldSEXO.Caption = "Sexo"
        Me.fieldSEXO.FieldName = "SEXO"
        Me.fieldSEXO.Name = "fieldSEXO"
        '
        'fieldCALIDAD_JURIDICA
        '
        Me.fieldCALIDAD_JURIDICA.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldCALIDAD_JURIDICA.AreaIndex = 9
        Me.fieldCALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.fieldCALIDAD_JURIDICA.FieldName = "CALIDAD_JURIDICA"
        Me.fieldCALIDAD_JURIDICA.Name = "fieldCALIDAD_JURIDICA"
        '
        'fieldESTAMENTO
        '
        Me.fieldESTAMENTO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldESTAMENTO.AreaIndex = 10
        Me.fieldESTAMENTO.Caption = "Estamento"
        Me.fieldESTAMENTO.FieldName = "ESTAMENTO"
        Me.fieldESTAMENTO.Name = "fieldESTAMENTO"
        '
        'frmAnalisisRatificacionHorasExtras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(784, 404)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.pgcAnalisisRatificacionHorasExtras)
        Me.Controls.Add(Me.gpcSeleccionAño)
        Me.Name = "frmAnalisisRatificacionHorasExtras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAnalisisRatificacionHorasExtras"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionAño.ResumeLayout(False)
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgcAnalisisRatificacionHorasExtras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private parametroMensual As Periodo
    Private asistencia As Asistencia

    Private Sub frmAnalisisRatificacionHorasExtras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        asistencia = New asistencia
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

    Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        If luePeriodo.EditValue <> Nothing Then
            refrescaDetalle()
        End If
    End Sub
    Private Sub refrescaDetalle()
        Cursor.Current = Cursors.WaitCursor
        If luePeriodo.EditValue <> Nothing Then
            Try
                pgcAnalisisRatificacionHorasExtras.DataSource = asistencia.dvRatificacionHorasExtras(luePeriodo.EditValue)
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al leer datos ratificación horas extras." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        Dim rutaPlanillaExcel As String
        Try
            With sfdRatificacionHorasExtras
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = sfdRatificacionHorasExtras.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                pgcAnalisisRatificacionHorasExtras.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
