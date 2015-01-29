Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Reportes
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmHorasExtrasPagadasVSRatificadas
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
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents rdgFiltro As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lblFiltro As System.Windows.Forms.Label
    Friend WithEvents gdcDetalleHoras As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents colAÑO_PROCESO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMES_PROCESO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDIRECCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDEPARTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colSUB_DEPTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colCALIDAD_JURIDICA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colNOMBRE_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colAÑO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colNUMERO_HORAS_DIURNAS_PAGADAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_HORAS_DIURNAS_PAGADAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colNUMERO_HORAS_EXTRAS_DIURNAS_RATIFICADAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_HORAS_EXTRAS_DIURNAS_RATIF As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colNUMERO_HORAS_DIURNAS_SUP As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_HORAS_DIURNAS_SUP As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colNUMERO_HORAS_NOCTURNAS_PAGADAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_HORAS_NOCTURNAS_PAGADAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colNUMERO_HORAS_EXTRAS_NOCTURNAS_RATIFICADAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_HORAS_EXTRAS_NOCTURNAS_RATIF As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colNUMERO_HORAS_NOCTURNAS_SUP As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_HORAS_NOCTURNAS_SUP As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents lueAnoProceso As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.colNUMERO_HORAS_DIURNAS_PAGADAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_HORAS_DIURNAS_PAGADAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colNUMERO_HORAS_EXTRAS_DIURNAS_RATIFICADAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_HORAS_EXTRAS_DIURNAS_RATIF = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colNUMERO_HORAS_DIURNAS_SUP = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_HORAS_DIURNAS_SUP = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colNUMERO_HORAS_NOCTURNAS_PAGADAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.gpcSeleccionAño = New DevExpress.XtraEditors.GroupControl
        Me.lueAnoProceso = New DevExpress.XtraEditors.LookUpEdit
        Me.lblFiltro = New System.Windows.Forms.Label
        Me.rdgFiltro = New DevExpress.XtraEditors.RadioGroup
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton
        Me.gdcDetalleHoras = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.colAÑO_PROCESO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMES_PROCESO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colDIRECCION = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colDEPARTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colSUB_DEPTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colCALIDAD_JURIDICA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colNOMBRE_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colRUT = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colDV = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colAÑO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMES = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_HORAS_NOCTURNAS_PAGADAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colNUMERO_HORAS_EXTRAS_NOCTURNAS_RATIFICADAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_HORAS_EXTRAS_NOCTURNAS_RATIF = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colNUMERO_HORAS_NOCTURNAS_SUP = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_HORAS_NOCTURNAS_SUP = New DevExpress.XtraPivotGrid.PivotGridField
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionAño.SuspendLayout()
        CType(Me.lueAnoProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgFiltro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcDetalleHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colNUMERO_HORAS_DIURNAS_PAGADAS
        '
        Me.colNUMERO_HORAS_DIURNAS_PAGADAS.Appearance.Header.Options.UseTextOptions = True
        Me.colNUMERO_HORAS_DIURNAS_PAGADAS.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colNUMERO_HORAS_DIURNAS_PAGADAS.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colNUMERO_HORAS_DIURNAS_PAGADAS.AreaIndex = 0
        Me.colNUMERO_HORAS_DIURNAS_PAGADAS.Caption = "# Diurnas Pagadas"
        Me.colNUMERO_HORAS_DIURNAS_PAGADAS.CellFormat.FormatString = "n0"
        Me.colNUMERO_HORAS_DIURNAS_PAGADAS.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNUMERO_HORAS_DIURNAS_PAGADAS.FieldName = "NUMERO_HORAS_DIURNAS_PAGADAS"
        Me.colNUMERO_HORAS_DIURNAS_PAGADAS.GrandTotalCellFormat.FormatString = "n0"
        Me.colNUMERO_HORAS_DIURNAS_PAGADAS.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNUMERO_HORAS_DIURNAS_PAGADAS.Name = "colNUMERO_HORAS_DIURNAS_PAGADAS"
        '
        'colMONTO_HORAS_DIURNAS_PAGADAS
        '
        Me.colMONTO_HORAS_DIURNAS_PAGADAS.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_HORAS_DIURNAS_PAGADAS.AreaIndex = 1
        Me.colMONTO_HORAS_DIURNAS_PAGADAS.Caption = "$ Diurnas Pagadas"
        Me.colMONTO_HORAS_DIURNAS_PAGADAS.CellFormat.FormatString = "n0"
        Me.colMONTO_HORAS_DIURNAS_PAGADAS.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_HORAS_DIURNAS_PAGADAS.FieldName = "MONTO_HORAS_DIURNAS_PAGADAS"
        Me.colMONTO_HORAS_DIURNAS_PAGADAS.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO_HORAS_DIURNAS_PAGADAS.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_HORAS_DIURNAS_PAGADAS.Name = "colMONTO_HORAS_DIURNAS_PAGADAS"
        '
        'colNUMERO_HORAS_EXTRAS_DIURNAS_RATIFICADAS
        '
        Me.colNUMERO_HORAS_EXTRAS_DIURNAS_RATIFICADAS.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colNUMERO_HORAS_EXTRAS_DIURNAS_RATIFICADAS.AreaIndex = 2
        Me.colNUMERO_HORAS_EXTRAS_DIURNAS_RATIFICADAS.Caption = "# Diurnas Ratif."
        Me.colNUMERO_HORAS_EXTRAS_DIURNAS_RATIFICADAS.CellFormat.FormatString = "n0"
        Me.colNUMERO_HORAS_EXTRAS_DIURNAS_RATIFICADAS.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNUMERO_HORAS_EXTRAS_DIURNAS_RATIFICADAS.FieldName = "NUMERO_HORAS_EXTRAS_DIURNAS_RATIFICADAS"
        Me.colNUMERO_HORAS_EXTRAS_DIURNAS_RATIFICADAS.GrandTotalCellFormat.FormatString = "n0"
        Me.colNUMERO_HORAS_EXTRAS_DIURNAS_RATIFICADAS.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNUMERO_HORAS_EXTRAS_DIURNAS_RATIFICADAS.Name = "colNUMERO_HORAS_EXTRAS_DIURNAS_RATIFICADAS"
        '
        'colMONTO_HORAS_EXTRAS_DIURNAS_RATIF
        '
        Me.colMONTO_HORAS_EXTRAS_DIURNAS_RATIF.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_HORAS_EXTRAS_DIURNAS_RATIF.AreaIndex = 3
        Me.colMONTO_HORAS_EXTRAS_DIURNAS_RATIF.Caption = "$ Diurnas Ratif."
        Me.colMONTO_HORAS_EXTRAS_DIURNAS_RATIF.CellFormat.FormatString = "n0"
        Me.colMONTO_HORAS_EXTRAS_DIURNAS_RATIF.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_HORAS_EXTRAS_DIURNAS_RATIF.FieldName = "MONTO_HORAS_EXTRAS_DIURNAS_RATIF"
        Me.colMONTO_HORAS_EXTRAS_DIURNAS_RATIF.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO_HORAS_EXTRAS_DIURNAS_RATIF.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_HORAS_EXTRAS_DIURNAS_RATIF.Name = "colMONTO_HORAS_EXTRAS_DIURNAS_RATIF"
        '
        'colNUMERO_HORAS_DIURNAS_SUP
        '
        Me.colNUMERO_HORAS_DIURNAS_SUP.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colNUMERO_HORAS_DIURNAS_SUP.AreaIndex = 4
        Me.colNUMERO_HORAS_DIURNAS_SUP.Caption = "# Diurnas Dif."
        Me.colNUMERO_HORAS_DIURNAS_SUP.CellFormat.FormatString = "n0"
        Me.colNUMERO_HORAS_DIURNAS_SUP.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNUMERO_HORAS_DIURNAS_SUP.FieldName = "NUMERO_HORAS_DIURNAS_SUP"
        Me.colNUMERO_HORAS_DIURNAS_SUP.GrandTotalCellFormat.FormatString = "n0"
        Me.colNUMERO_HORAS_DIURNAS_SUP.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNUMERO_HORAS_DIURNAS_SUP.Name = "colNUMERO_HORAS_DIURNAS_SUP"
        '
        'colMONTO_HORAS_DIURNAS_SUP
        '
        Me.colMONTO_HORAS_DIURNAS_SUP.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_HORAS_DIURNAS_SUP.AreaIndex = 5
        Me.colMONTO_HORAS_DIURNAS_SUP.Caption = "$ Diurnas Dif."
        Me.colMONTO_HORAS_DIURNAS_SUP.CellFormat.FormatString = "n0"
        Me.colMONTO_HORAS_DIURNAS_SUP.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_HORAS_DIURNAS_SUP.FieldName = "MONTO_HORAS_DIURNAS_SUP"
        Me.colMONTO_HORAS_DIURNAS_SUP.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO_HORAS_DIURNAS_SUP.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_HORAS_DIURNAS_SUP.Name = "colMONTO_HORAS_DIURNAS_SUP"
        '
        'colNUMERO_HORAS_NOCTURNAS_PAGADAS
        '
        Me.colNUMERO_HORAS_NOCTURNAS_PAGADAS.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colNUMERO_HORAS_NOCTURNAS_PAGADAS.AreaIndex = 6
        Me.colNUMERO_HORAS_NOCTURNAS_PAGADAS.Caption = "# Noct.Pagadas"
        Me.colNUMERO_HORAS_NOCTURNAS_PAGADAS.CellFormat.FormatString = "n0"
        Me.colNUMERO_HORAS_NOCTURNAS_PAGADAS.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNUMERO_HORAS_NOCTURNAS_PAGADAS.FieldName = "NUMERO_HORAS_NOCTURNAS_PAGADAS"
        Me.colNUMERO_HORAS_NOCTURNAS_PAGADAS.GrandTotalCellFormat.FormatString = "n0"
        Me.colNUMERO_HORAS_NOCTURNAS_PAGADAS.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNUMERO_HORAS_NOCTURNAS_PAGADAS.Name = "colNUMERO_HORAS_NOCTURNAS_PAGADAS"
        '
        'gpcSeleccionAño
        '
        Me.gpcSeleccionAño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionAño.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionAño.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionAño.Controls.Add(Me.lueAnoProceso)
        Me.gpcSeleccionAño.Controls.Add(Me.lblFiltro)
        Me.gpcSeleccionAño.Controls.Add(Me.rdgFiltro)
        Me.gpcSeleccionAño.Controls.Add(Me.lblPeriodo)
        Me.gpcSeleccionAño.Controls.Add(Me.luePeriodo)
        Me.gpcSeleccionAño.Controls.Add(Me.btnVisualizar)
        Me.gpcSeleccionAño.Location = New System.Drawing.Point(0, 0)
        Me.gpcSeleccionAño.Name = "gpcSeleccionAño"
        Me.gpcSeleccionAño.Size = New System.Drawing.Size(888, 112)
        Me.gpcSeleccionAño.TabIndex = 8
        Me.gpcSeleccionAño.Text = "Selección de Periodo"
        '
        'lueAnoProceso
        '
        Me.lueAnoProceso.Location = New System.Drawing.Point(128, 64)
        Me.lueAnoProceso.Name = "lueAnoProceso"
        '
        'lueAnoProceso.Properties
        '
        Me.lueAnoProceso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAnoProceso.Size = New System.Drawing.Size(160, 20)
        Me.lueAnoProceso.TabIndex = 10
        '
        'lblFiltro
        '
        Me.lblFiltro.Location = New System.Drawing.Point(72, 32)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(48, 16)
        Me.lblFiltro.TabIndex = 9
        Me.lblFiltro.Text = "Filtro"
        Me.lblFiltro.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'rdgFiltro
        '
        Me.rdgFiltro.Location = New System.Drawing.Point(128, 24)
        Me.rdgFiltro.Name = "rdgFiltro"
        '
        'rdgFiltro.Properties
        '
        Me.rdgFiltro.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Por Año"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Por Periodo")})
        Me.rdgFiltro.Size = New System.Drawing.Size(160, 32)
        Me.rdgFiltro.TabIndex = 0
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(72, 64)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 16)
        Me.lblPeriodo.TabIndex = 7
        Me.lblPeriodo.Text = "Periodo"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(128, 64)
        Me.luePeriodo.Name = "luePeriodo"
        '
        'luePeriodo.Properties
        '
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(160, 20)
        Me.luePeriodo.TabIndex = 6
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(336, 32)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(168, 23)
        Me.btnVisualizar.TabIndex = 5
        Me.btnVisualizar.Text = "Visualizar"
        '
        'gdcDetalleHoras
        '
        Me.gdcDetalleHoras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcDetalleHoras.Cursor = System.Windows.Forms.Cursors.Default
        Me.gdcDetalleHoras.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.colAÑO_PROCESO, Me.colMES_PROCESO, Me.colDIRECCION, Me.colDEPARTAMENTO, Me.colSUB_DEPTO, Me.colCALIDAD_JURIDICA, Me.colNOMBRE_EMPLEADO, Me.colRUT, Me.colDV, Me.colAÑO, Me.colMES, Me.colNUMERO_HORAS_DIURNAS_PAGADAS, Me.colMONTO_HORAS_DIURNAS_PAGADAS, Me.colNUMERO_HORAS_EXTRAS_DIURNAS_RATIFICADAS, Me.colMONTO_HORAS_EXTRAS_DIURNAS_RATIF, Me.colNUMERO_HORAS_DIURNAS_SUP, Me.colMONTO_HORAS_DIURNAS_SUP, Me.colNUMERO_HORAS_NOCTURNAS_PAGADAS, Me.colMONTO_HORAS_NOCTURNAS_PAGADAS, Me.colNUMERO_HORAS_EXTRAS_NOCTURNAS_RATIFICADAS, Me.colMONTO_HORAS_EXTRAS_NOCTURNAS_RATIF, Me.colNUMERO_HORAS_NOCTURNAS_SUP, Me.colMONTO_HORAS_NOCTURNAS_SUP})
        Me.gdcDetalleHoras.Location = New System.Drawing.Point(0, 112)
        Me.gdcDetalleHoras.Name = "gdcDetalleHoras"
        Me.gdcDetalleHoras.OptionsView.ShowDataHeaders = False
        Me.gdcDetalleHoras.Size = New System.Drawing.Size(888, 232)
        Me.gdcDetalleHoras.TabIndex = 9
        '
        'colAÑO_PROCESO
        '
        Me.colAÑO_PROCESO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colAÑO_PROCESO.AreaIndex = 0
        Me.colAÑO_PROCESO.Caption = "Año Proceso"
        Me.colAÑO_PROCESO.FieldName = "AÑO_PROCESO"
        Me.colAÑO_PROCESO.Name = "colAÑO_PROCESO"
        '
        'colMES_PROCESO
        '
        Me.colMES_PROCESO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colMES_PROCESO.AreaIndex = 1
        Me.colMES_PROCESO.Caption = "Mes Proceso"
        Me.colMES_PROCESO.FieldName = "MES_PROCESO"
        Me.colMES_PROCESO.Name = "colMES_PROCESO"
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
        Me.colSUB_DEPTO.Caption = "SubDepto"
        Me.colSUB_DEPTO.FieldName = "SUB_DEPTO"
        Me.colSUB_DEPTO.Name = "colSUB_DEPTO"
        '
        'colCALIDAD_JURIDICA
        '
        Me.colCALIDAD_JURIDICA.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colCALIDAD_JURIDICA.AreaIndex = 3
        Me.colCALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.colCALIDAD_JURIDICA.FieldName = "CALIDAD_JURIDICA"
        Me.colCALIDAD_JURIDICA.Name = "colCALIDAD_JURIDICA"
        '
        'colNOMBRE_EMPLEADO
        '
        Me.colNOMBRE_EMPLEADO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colNOMBRE_EMPLEADO.AreaIndex = 2
        Me.colNOMBRE_EMPLEADO.Caption = "Empleado"
        Me.colNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.colNOMBRE_EMPLEADO.Name = "colNOMBRE_EMPLEADO"
        Me.colNOMBRE_EMPLEADO.Width = 250
        '
        'colRUT
        '
        Me.colRUT.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colRUT.AreaIndex = 4
        Me.colRUT.Caption = "Rut"
        Me.colRUT.FieldName = "RUT"
        Me.colRUT.Name = "colRUT"
        '
        'colDV
        '
        Me.colDV.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colDV.AreaIndex = 5
        Me.colDV.Caption = "Dv"
        Me.colDV.FieldName = "DV"
        Me.colDV.Name = "colDV"
        '
        'colAÑO
        '
        Me.colAÑO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colAÑO.AreaIndex = 6
        Me.colAÑO.Caption = "Año Horas"
        Me.colAÑO.FieldName = "AÑO"
        Me.colAÑO.Name = "colAÑO"
        '
        'colMES
        '
        Me.colMES.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colMES.AreaIndex = 7
        Me.colMES.Caption = "Mes Horas"
        Me.colMES.FieldName = "MES"
        Me.colMES.Name = "colMES"
        '
        'colMONTO_HORAS_NOCTURNAS_PAGADAS
        '
        Me.colMONTO_HORAS_NOCTURNAS_PAGADAS.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_HORAS_NOCTURNAS_PAGADAS.AreaIndex = 7
        Me.colMONTO_HORAS_NOCTURNAS_PAGADAS.Caption = "$ Noct.Pagadas"
        Me.colMONTO_HORAS_NOCTURNAS_PAGADAS.CellFormat.FormatString = "n0"
        Me.colMONTO_HORAS_NOCTURNAS_PAGADAS.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_HORAS_NOCTURNAS_PAGADAS.FieldName = "MONTO_HORAS_NOCTURNAS_PAGADAS"
        Me.colMONTO_HORAS_NOCTURNAS_PAGADAS.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO_HORAS_NOCTURNAS_PAGADAS.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_HORAS_NOCTURNAS_PAGADAS.Name = "colMONTO_HORAS_NOCTURNAS_PAGADAS"
        '
        'colNUMERO_HORAS_EXTRAS_NOCTURNAS_RATIFICADAS
        '
        Me.colNUMERO_HORAS_EXTRAS_NOCTURNAS_RATIFICADAS.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colNUMERO_HORAS_EXTRAS_NOCTURNAS_RATIFICADAS.AreaIndex = 8
        Me.colNUMERO_HORAS_EXTRAS_NOCTURNAS_RATIFICADAS.Caption = "# Noct.Ratif."
        Me.colNUMERO_HORAS_EXTRAS_NOCTURNAS_RATIFICADAS.CellFormat.FormatString = "n0"
        Me.colNUMERO_HORAS_EXTRAS_NOCTURNAS_RATIFICADAS.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNUMERO_HORAS_EXTRAS_NOCTURNAS_RATIFICADAS.FieldName = "NUMERO_HORAS_EXTRAS_NOCTURNAS_RATIFICADAS"
        Me.colNUMERO_HORAS_EXTRAS_NOCTURNAS_RATIFICADAS.GrandTotalCellFormat.FormatString = "n0"
        Me.colNUMERO_HORAS_EXTRAS_NOCTURNAS_RATIFICADAS.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNUMERO_HORAS_EXTRAS_NOCTURNAS_RATIFICADAS.Name = "colNUMERO_HORAS_EXTRAS_NOCTURNAS_RATIFICADAS"
        '
        'colMONTO_HORAS_EXTRAS_NOCTURNAS_RATIF
        '
        Me.colMONTO_HORAS_EXTRAS_NOCTURNAS_RATIF.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_HORAS_EXTRAS_NOCTURNAS_RATIF.AreaIndex = 9
        Me.colMONTO_HORAS_EXTRAS_NOCTURNAS_RATIF.Caption = "$ Noct.Ratif"
        Me.colMONTO_HORAS_EXTRAS_NOCTURNAS_RATIF.CellFormat.FormatString = "n0"
        Me.colMONTO_HORAS_EXTRAS_NOCTURNAS_RATIF.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_HORAS_EXTRAS_NOCTURNAS_RATIF.FieldName = "MONTO_HORAS_EXTRAS_NOCTURNAS_RATIF"
        Me.colMONTO_HORAS_EXTRAS_NOCTURNAS_RATIF.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO_HORAS_EXTRAS_NOCTURNAS_RATIF.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_HORAS_EXTRAS_NOCTURNAS_RATIF.Name = "colMONTO_HORAS_EXTRAS_NOCTURNAS_RATIF"
        '
        'colNUMERO_HORAS_NOCTURNAS_SUP
        '
        Me.colNUMERO_HORAS_NOCTURNAS_SUP.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colNUMERO_HORAS_NOCTURNAS_SUP.AreaIndex = 10
        Me.colNUMERO_HORAS_NOCTURNAS_SUP.Caption = "# Noct.Dif."
        Me.colNUMERO_HORAS_NOCTURNAS_SUP.CellFormat.FormatString = "n0"
        Me.colNUMERO_HORAS_NOCTURNAS_SUP.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNUMERO_HORAS_NOCTURNAS_SUP.FieldName = "NUMERO_HORAS_NOCTURNAS_SUP"
        Me.colNUMERO_HORAS_NOCTURNAS_SUP.GrandTotalCellFormat.FormatString = "n0"
        Me.colNUMERO_HORAS_NOCTURNAS_SUP.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNUMERO_HORAS_NOCTURNAS_SUP.Name = "colNUMERO_HORAS_NOCTURNAS_SUP"
        '
        'colMONTO_HORAS_NOCTURNAS_SUP
        '
        Me.colMONTO_HORAS_NOCTURNAS_SUP.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_HORAS_NOCTURNAS_SUP.AreaIndex = 11
        Me.colMONTO_HORAS_NOCTURNAS_SUP.Caption = "$ Noct.Dif."
        Me.colMONTO_HORAS_NOCTURNAS_SUP.CellFormat.FormatString = "n0"
        Me.colMONTO_HORAS_NOCTURNAS_SUP.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_HORAS_NOCTURNAS_SUP.FieldName = "MONTO_HORAS_NOCTURNAS_SUP"
        Me.colMONTO_HORAS_NOCTURNAS_SUP.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO_HORAS_NOCTURNAS_SUP.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_HORAS_NOCTURNAS_SUP.Name = "colMONTO_HORAS_NOCTURNAS_SUP"
        '
        'frmHorasExtrasPagadasVSRatificadas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(888, 348)
        Me.Controls.Add(Me.gdcDetalleHoras)
        Me.Controls.Add(Me.gpcSeleccionAño)
        Me.Name = "frmHorasExtrasPagadasVSRatificadas"
        Me.Text = "frmHorasExtrasPagadasVSRatificadas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionAño.ResumeLayout(False)
        CType(Me.lueAnoProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgFiltro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcDetalleHoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private empleado As New Empleado
    Private periodo As Periodo

    Private Sub frmHorasExtrasPagadasVSRatificadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.luePeriodo.Visible = False
        Me.lueAnoProceso.Visible = False
        Me.lblPeriodo.Visible = False
        Me.btnVisualizar.Enabled = False
        repositorio.RefreshDatos("PeriodoAño")
        llenarPeriodos()
        llenarAnos()
    End Sub

    Private Sub llenarPeriodos()
        With luePeriodo
            With .Properties.Columns
                .Add(New LookUpColumnInfo("PERIODO_ID", "ID Periodo", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ANO", "Año", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("MES", "Mes", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ESTADO_PERIODO", "Estado Periodo", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION_PERIODO", "Periodo", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        luePeriodo.Properties.DataSource = repositorio.dvPeriodo
        luePeriodo.Properties.DisplayMember = "DESCRIPCION_PERIODO"
        luePeriodo.Properties.NullText = ""
        luePeriodo.Properties.PopupWidth = 150
        luePeriodo.Properties.ValueMember = "PERIODO_ID"
    End Sub

    Private Sub llenarAnos()
        With lueAnoProceso
            With .Properties.Columns
                .Add(New LookUpColumnInfo("ANO", "Año Proceso", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        repositorio.Show()
        lueAnoProceso.Properties.DataSource = repositorio.dvPeriodoAño
        lueAnoProceso.Properties.DisplayMember = "ANO"
        lueAnoProceso.Properties.NullText = ""
        lueAnoProceso.Properties.PopupWidth = 100
        lueAnoProceso.Properties.ValueMember = "ANO"
    End Sub

    Private Sub luePeriodo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        If luePeriodo.EditValue <> Nothing Then
            Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
            Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
            Dim Año As Integer = CType(row("ANO"), Integer) 'CInt(CType(row("Periodo"), String).Substring(0, 4))
            Dim Mes As Integer = CType(row("MES"), Integer) 'CInt(CType(row("Periodo"), String).Substring(5, 2))
            periodo = New periodo(CType(row("PERIODO_ID"), Integer))
            Cursor.Current = Cursors.WaitCursor
            Try
                If periodo.estadoPeriodo = True Then
                    empleado.generaHorasExtrasPagadasVsRatificadas(periodo.ID, "N")
                End If
                gdcDetalleHoras.DataSource = empleado.recuperaPeriodoHorasRatificadasVsPagadas(Año, Mes)
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Debug.WriteLine(ex.Message)
            End Try
            Cursor.Current = Cursors.Default
        End If
    End Sub

    Private Sub rdgFiltro_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdgFiltro.EditValueChanged
        If Me.rdgFiltro.EditValue = 1 Then
            Me.lblPeriodo.Visible = True
            Me.lueAnoProceso.Visible = True
            Me.lblPeriodo.Text = "Año"
            Me.luePeriodo.Visible = False
            Me.btnVisualizar.Enabled = False
        ElseIf (Me.rdgFiltro.EditValue = 2) Then
            Me.lblPeriodo.Visible = True
            Me.lueAnoProceso.Visible = False
            Me.lblPeriodo.Text = "Periodo"
            Me.luePeriodo.Visible = True
            Me.btnVisualizar.Enabled = True
        End If
    End Sub

    Private Sub lueAnoProceso_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueAnoProceso.EditValueChanged
        If lueAnoProceso.EditValue <> Nothing Then
            gdcDetalleHoras.DataSource = empleado.recuperaPeriodoHorasRatificadasVsPagadas(Me.lueAnoProceso.EditValue)
        End If
    End Sub


    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(luePeriodo, DevExpress.XtraEditors.LookUpEdit)
        Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
        Dim Año As Integer = CType(row("ANO"), String)
        Dim Mes As Integer = CType(row("MES"), String)
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptHorasExtrasPagadasVsRatificadas
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        Dim strFormulaSeleccion As String = "{VW_HORAS_EXTRAS_PAGADAS_VS_RATIFICADAS.AÑO_PROCESO}=" & Año.ToString
        strFormulaSeleccion &= " AND {VW_HORAS_EXTRAS_PAGADAS_VS_RATIFICADAS.MES_PROCESO}=" & Mes.ToString
        reporte.SummaryInfo.ReportTitle = "Diferencia Horas Extras Pagadas vs Ratificadas a " + Me.luePeriodo.Text
        ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
        ventanaReporte1.rptVisor.ShowParameterPanelButton = False
        ventanaReporte1.rptVisor.ShowCloseButton = False
        ventanaReporte1.rptVisor.ShowGroupTreeButton = False
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.Show()
    End Sub
End Class
