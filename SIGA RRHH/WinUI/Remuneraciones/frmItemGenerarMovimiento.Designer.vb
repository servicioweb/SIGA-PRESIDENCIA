<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemGenerarMovimiento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gpcEncabezado = New DevExpress.XtraEditors.GroupControl()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnIncluirProcesoRemun = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.gleItems = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.glvItems = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RELACION_CABECERA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ITEM_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION_LARGA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnCalcular = New DevExpress.XtraEditors.SimpleButton()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.gpcEmpleados = New DevExpress.XtraEditors.GroupControl()
        Me.gdcEmpleados = New DevExpress.XtraGrid.GridControl()
        Me.gdvEmpleados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colITEM_RELACIONADO_DETALLE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRELACION_TRAMO_ID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEMPLEADO_ID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleRut = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMONTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMontoDetalle = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colMONTO_ASIGNADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gpcTramos = New DevExpress.XtraEditors.GroupControl()
        Me.gdcTramos = New DevExpress.XtraGrid.GridControl()
        Me.gdvTramos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRELACION_TRAMO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_TRAMO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_DESDE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMonto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colMONTO_HASTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_PARA_ASIGNAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRELACION_CABECERA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPERIODO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcEncabezado.SuspendLayout()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleItems.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcEmpleados.SuspendLayout()
        CType(Me.gdcEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleRut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcTramos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcTramos.SuspendLayout()
        CType(Me.gdcTramos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvTramos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcEncabezado
        '
        Me.gpcEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcEncabezado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcEncabezado.AppearanceCaption.Options.UseFont = True
        Me.gpcEncabezado.Controls.Add(Me.luePeriodo)
        Me.gpcEncabezado.Controls.Add(Me.btnIncluirProcesoRemun)
        Me.gpcEncabezado.Controls.Add(Me.btnExcel)
        Me.gpcEncabezado.Controls.Add(Me.LabelControl1)
        Me.gpcEncabezado.Controls.Add(Me.gleItems)
        Me.gpcEncabezado.Controls.Add(Me.btnCalcular)
        Me.gpcEncabezado.Controls.Add(Me.lblItem)
        Me.gpcEncabezado.Location = New System.Drawing.Point(2, 1)
        Me.gpcEncabezado.Name = "gpcEncabezado"
        Me.gpcEncabezado.Size = New System.Drawing.Size(755, 99)
        Me.gpcEncabezado.TabIndex = 3
        Me.gpcEncabezado.Text = "Ítem"
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(49, 60)
        Me.luePeriodo.Name = "luePeriodo"
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(181, 20)
        Me.luePeriodo.TabIndex = 7
        '
        'btnIncluirProcesoRemun
        '
        Me.btnIncluirProcesoRemun.Location = New System.Drawing.Point(532, 53)
        Me.btnIncluirProcesoRemun.Name = "btnIncluirProcesoRemun"
        Me.btnIncluirProcesoRemun.Size = New System.Drawing.Size(179, 23)
        Me.btnIncluirProcesoRemun.TabIndex = 5
        Me.btnIncluirProcesoRemun.Text = "Incluir en Proceso Remuneración"
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(342, 53)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(179, 23)
        Me.btnExcel.TabIndex = 6
        Me.btnExcel.Text = "Exportar a Excel"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 63)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Periodo "
        '
        'gleItems
        '
        Me.gleItems.EditValue = ""
        Me.gleItems.Location = New System.Drawing.Point(49, 34)
        Me.gleItems.Name = "gleItems"
        Me.gleItems.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleItems.Properties.PopupFormSize = New System.Drawing.Size(470, 0)
        Me.gleItems.Properties.View = Me.glvItems
        Me.gleItems.Size = New System.Drawing.Size(181, 20)
        Me.gleItems.TabIndex = 1
        '
        'glvItems
        '
        Me.glvItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.RELACION_CABECERA_ID, Me.ITEM_ALIAS, Me.DESCRIPCION_LARGA})
        Me.glvItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.glvItems.Name = "glvItems"
        Me.glvItems.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.glvItems.OptionsView.ColumnAutoWidth = False
        Me.glvItems.OptionsView.ShowGroupPanel = False
        '
        'RELACION_CABECERA_ID
        '
        Me.RELACION_CABECERA_ID.Caption = "ID Relacion Cabecera"
        Me.RELACION_CABECERA_ID.FieldName = "RELACION_CABECERA_ID"
        Me.RELACION_CABECERA_ID.Name = "RELACION_CABECERA_ID"
        Me.RELACION_CABECERA_ID.OptionsColumn.ReadOnly = True
        '
        'ITEM_ALIAS
        '
        Me.ITEM_ALIAS.Caption = "Item"
        Me.ITEM_ALIAS.FieldName = "ITEM_ALIAS"
        Me.ITEM_ALIAS.Name = "ITEM_ALIAS"
        Me.ITEM_ALIAS.OptionsColumn.ReadOnly = True
        Me.ITEM_ALIAS.Visible = True
        Me.ITEM_ALIAS.VisibleIndex = 0
        Me.ITEM_ALIAS.Width = 78
        '
        'DESCRIPCION_LARGA
        '
        Me.DESCRIPCION_LARGA.Caption = "Descripción"
        Me.DESCRIPCION_LARGA.FieldName = "DESCRIPCION_LARGA"
        Me.DESCRIPCION_LARGA.Name = "DESCRIPCION_LARGA"
        Me.DESCRIPCION_LARGA.OptionsColumn.ReadOnly = True
        Me.DESCRIPCION_LARGA.Visible = True
        Me.DESCRIPCION_LARGA.VisibleIndex = 1
        Me.DESCRIPCION_LARGA.Width = 300
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(255, 53)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(81, 23)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular"
        '
        'lblItem
        '
        Me.lblItem.Location = New System.Drawing.Point(11, 37)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(34, 17)
        Me.lblItem.TabIndex = 1
        Me.lblItem.Text = "Item"
        Me.lblItem.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gpcEmpleados
        '
        Me.gpcEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcEmpleados.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcEmpleados.AppearanceCaption.Options.UseFont = True
        Me.gpcEmpleados.Controls.Add(Me.gdcEmpleados)
        Me.gpcEmpleados.Location = New System.Drawing.Point(2, 303)
        Me.gpcEmpleados.Name = "gpcEmpleados"
        Me.gpcEmpleados.Size = New System.Drawing.Size(755, 243)
        Me.gpcEmpleados.TabIndex = 6
        Me.gpcEmpleados.Text = "Detalle Empleados"
        '
        'gdcEmpleados
        '
        Me.gdcEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcEmpleados.Location = New System.Drawing.Point(5, 25)
        Me.gdcEmpleados.MainView = Me.gdvEmpleados
        Me.gdcEmpleados.Name = "gdcEmpleados"
        Me.gdcEmpleados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtMontoDetalle, Me.gleRut})
        Me.gdcEmpleados.Size = New System.Drawing.Size(745, 213)
        Me.gdcEmpleados.TabIndex = 0
        Me.gdcEmpleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvEmpleados})
        '
        'gdvEmpleados
        '
        Me.gdvEmpleados.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvEmpleados.Appearance.FooterPanel.Options.UseFont = True
        Me.gdvEmpleados.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvEmpleados.Appearance.GroupFooter.Options.UseFont = True
        Me.gdvEmpleados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colITEM_RELACIONADO_DETALLE_ID, Me.colRELACION_TRAMO_ID1, Me.colEMPLEADO_ID1, Me.colEMPLEADO_ID, Me.colMONTO, Me.colMONTO_ASIGNADO})
        Me.gdvEmpleados.GridControl = Me.gdcEmpleados
        Me.gdvEmpleados.Name = "gdvEmpleados"
        Me.gdvEmpleados.OptionsView.ShowFooter = True
        Me.gdvEmpleados.OptionsView.ShowGroupPanel = False
        Me.gdvEmpleados.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colEMPLEADO_ID, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colITEM_RELACIONADO_DETALLE_ID
        '
        Me.colITEM_RELACIONADO_DETALLE_ID.Caption = "ID Detalle"
        Me.colITEM_RELACIONADO_DETALLE_ID.FieldName = "ITEM_RELACIONADO_DETALLE_ID"
        Me.colITEM_RELACIONADO_DETALLE_ID.Name = "colITEM_RELACIONADO_DETALLE_ID"
        '
        'colRELACION_TRAMO_ID1
        '
        Me.colRELACION_TRAMO_ID1.Caption = "ID Tramo Relacion"
        Me.colRELACION_TRAMO_ID1.FieldName = "RELACION_TRAMO_ID"
        Me.colRELACION_TRAMO_ID1.Name = "colRELACION_TRAMO_ID1"
        '
        'colEMPLEADO_ID1
        '
        Me.colEMPLEADO_ID1.Caption = "Id Empleado"
        Me.colEMPLEADO_ID1.FieldName = "EMPLEADO_ID"
        Me.colEMPLEADO_ID1.Name = "colEMPLEADO_ID1"
        Me.colEMPLEADO_ID1.OptionsColumn.AllowEdit = False
        Me.colEMPLEADO_ID1.OptionsColumn.ReadOnly = True
        '
        'colEMPLEADO_ID
        '
        Me.colEMPLEADO_ID.Caption = "Empleado"
        Me.colEMPLEADO_ID.ColumnEdit = Me.gleRut
        Me.colEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.colEMPLEADO_ID.Name = "colEMPLEADO_ID"
        Me.colEMPLEADO_ID.OptionsColumn.AllowEdit = False
        Me.colEMPLEADO_ID.OptionsColumn.AllowFocus = False
        Me.colEMPLEADO_ID.OptionsColumn.AllowMove = False
        Me.colEMPLEADO_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colEMPLEADO_ID.OptionsColumn.ReadOnly = True
        Me.colEMPLEADO_ID.Visible = True
        Me.colEMPLEADO_ID.VisibleIndex = 0
        '
        'gleRut
        '
        Me.gleRut.AutoHeight = False
        Me.gleRut.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleRut.Name = "gleRut"
        Me.gleRut.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colMONTO
        '
        Me.colMONTO.Caption = "Monto Base"
        Me.colMONTO.ColumnEdit = Me.txtMontoDetalle
        Me.colMONTO.FieldName = "MONTO_BASE"
        Me.colMONTO.Name = "colMONTO"
        Me.colMONTO.OptionsColumn.AllowEdit = False
        Me.colMONTO.OptionsColumn.AllowFocus = False
        Me.colMONTO.OptionsColumn.AllowMove = False
        Me.colMONTO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMONTO.OptionsColumn.ReadOnly = True
        Me.colMONTO.Visible = True
        Me.colMONTO.VisibleIndex = 1
        '
        'txtMontoDetalle
        '
        Me.txtMontoDetalle.AutoHeight = False
        Me.txtMontoDetalle.DisplayFormat.FormatString = "n0"
        Me.txtMontoDetalle.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoDetalle.EditFormat.FormatString = "n0"
        Me.txtMontoDetalle.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoDetalle.Mask.EditMask = "n0"
        Me.txtMontoDetalle.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoDetalle.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoDetalle.Name = "txtMontoDetalle"
        '
        'colMONTO_ASIGNADO
        '
        Me.colMONTO_ASIGNADO.Caption = "Monto Asignado"
        Me.colMONTO_ASIGNADO.ColumnEdit = Me.txtMontoDetalle
        Me.colMONTO_ASIGNADO.FieldName = "MONTO_ASIGNADO"
        Me.colMONTO_ASIGNADO.Name = "colMONTO_ASIGNADO"
        Me.colMONTO_ASIGNADO.OptionsColumn.AllowFocus = False
        Me.colMONTO_ASIGNADO.OptionsColumn.AllowMove = False
        Me.colMONTO_ASIGNADO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMONTO_ASIGNADO.OptionsColumn.ReadOnly = True
        Me.colMONTO_ASIGNADO.SummaryItem.DisplayFormat = "Total General: {0:n0}"
        Me.colMONTO_ASIGNADO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colMONTO_ASIGNADO.Visible = True
        Me.colMONTO_ASIGNADO.VisibleIndex = 2
        '
        'gpcTramos
        '
        Me.gpcTramos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcTramos.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcTramos.AppearanceCaption.Options.UseFont = True
        Me.gpcTramos.Controls.Add(Me.gdcTramos)
        Me.gpcTramos.Location = New System.Drawing.Point(2, 106)
        Me.gpcTramos.Name = "gpcTramos"
        Me.gpcTramos.Size = New System.Drawing.Size(755, 191)
        Me.gpcTramos.TabIndex = 5
        Me.gpcTramos.Text = "Tabla de Tramos"
        '
        'gdcTramos
        '
        Me.gdcTramos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcTramos.Location = New System.Drawing.Point(5, 25)
        Me.gdcTramos.MainView = Me.gdvTramos
        Me.gdcTramos.Name = "gdcTramos"
        Me.gdcTramos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtMonto})
        Me.gdcTramos.Size = New System.Drawing.Size(745, 161)
        Me.gdcTramos.TabIndex = 0
        Me.gdcTramos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvTramos})
        '
        'gdvTramos
        '
        Me.gdvTramos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRELACION_TRAMO_ID, Me.colNOMBRE_TRAMO, Me.colMONTO_DESDE, Me.colMONTO_HASTA, Me.colMONTO_PARA_ASIGNAR, Me.colRELACION_CABECERA_ID, Me.colPERIODO_ID})
        Me.gdvTramos.GridControl = Me.gdcTramos
        Me.gdvTramos.Name = "gdvTramos"
        Me.gdvTramos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gdvTramos.OptionsView.ShowGroupPanel = False
        '
        'colRELACION_TRAMO_ID
        '
        Me.colRELACION_TRAMO_ID.Caption = "ID Tramo"
        Me.colRELACION_TRAMO_ID.FieldName = "RELACION_TRAMO_ID"
        Me.colRELACION_TRAMO_ID.Name = "colRELACION_TRAMO_ID"
        Me.colRELACION_TRAMO_ID.OptionsColumn.AllowEdit = False
        Me.colRELACION_TRAMO_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colRELACION_TRAMO_ID.OptionsColumn.AllowMove = False
        Me.colRELACION_TRAMO_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colRELACION_TRAMO_ID.OptionsColumn.ReadOnly = True
        '
        'colNOMBRE_TRAMO
        '
        Me.colNOMBRE_TRAMO.Caption = "Nombre Tramo"
        Me.colNOMBRE_TRAMO.FieldName = "NOMBRE_TRAMO"
        Me.colNOMBRE_TRAMO.Name = "colNOMBRE_TRAMO"
        Me.colNOMBRE_TRAMO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNOMBRE_TRAMO.OptionsColumn.AllowMove = False
        Me.colNOMBRE_TRAMO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNOMBRE_TRAMO.Visible = True
        Me.colNOMBRE_TRAMO.VisibleIndex = 0
        '
        'colMONTO_DESDE
        '
        Me.colMONTO_DESDE.Caption = "Monto Desde"
        Me.colMONTO_DESDE.ColumnEdit = Me.txtMonto
        Me.colMONTO_DESDE.FieldName = "MONTO_DESDE"
        Me.colMONTO_DESDE.Name = "colMONTO_DESDE"
        Me.colMONTO_DESDE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMONTO_DESDE.OptionsColumn.AllowMove = False
        Me.colMONTO_DESDE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMONTO_DESDE.Visible = True
        Me.colMONTO_DESDE.VisibleIndex = 1
        '
        'txtMonto
        '
        Me.txtMonto.AutoHeight = False
        Me.txtMonto.DisplayFormat.FormatString = "n0"
        Me.txtMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.EditFormat.FormatString = "n0"
        Me.txtMonto.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.Mask.EditMask = "n0"
        Me.txtMonto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMonto.Mask.UseMaskAsDisplayFormat = True
        Me.txtMonto.MaxLength = 8
        Me.txtMonto.Name = "txtMonto"
        '
        'colMONTO_HASTA
        '
        Me.colMONTO_HASTA.Caption = "Monto Hasta"
        Me.colMONTO_HASTA.ColumnEdit = Me.txtMonto
        Me.colMONTO_HASTA.FieldName = "MONTO_HASTA"
        Me.colMONTO_HASTA.Name = "colMONTO_HASTA"
        Me.colMONTO_HASTA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMONTO_HASTA.OptionsColumn.AllowMove = False
        Me.colMONTO_HASTA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMONTO_HASTA.Visible = True
        Me.colMONTO_HASTA.VisibleIndex = 2
        '
        'colMONTO_PARA_ASIGNAR
        '
        Me.colMONTO_PARA_ASIGNAR.Caption = "Monto a Asignar"
        Me.colMONTO_PARA_ASIGNAR.ColumnEdit = Me.txtMonto
        Me.colMONTO_PARA_ASIGNAR.FieldName = "MONTO_PARA_ASIGNAR"
        Me.colMONTO_PARA_ASIGNAR.Name = "colMONTO_PARA_ASIGNAR"
        Me.colMONTO_PARA_ASIGNAR.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMONTO_PARA_ASIGNAR.OptionsColumn.AllowMove = False
        Me.colMONTO_PARA_ASIGNAR.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMONTO_PARA_ASIGNAR.Visible = True
        Me.colMONTO_PARA_ASIGNAR.VisibleIndex = 3
        '
        'colRELACION_CABECERA_ID
        '
        Me.colRELACION_CABECERA_ID.Caption = "ID Relacion Cabecera"
        Me.colRELACION_CABECERA_ID.FieldName = "RELACION_CABECERA_ID"
        Me.colRELACION_CABECERA_ID.Name = "colRELACION_CABECERA_ID"
        Me.colRELACION_CABECERA_ID.OptionsColumn.AllowEdit = False
        Me.colRELACION_CABECERA_ID.OptionsColumn.ShowInCustomizationForm = False
        '
        'colPERIODO_ID
        '
        Me.colPERIODO_ID.Caption = "ID Periodo"
        Me.colPERIODO_ID.FieldName = "PERIODO_ID"
        Me.colPERIODO_ID.Name = "colPERIODO_ID"
        Me.colPERIODO_ID.OptionsColumn.AllowEdit = False
        Me.colPERIODO_ID.OptionsColumn.ReadOnly = True
        '
        'frmItemGenerarMovimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 544)
        Me.Controls.Add(Me.gpcEmpleados)
        Me.Controls.Add(Me.gpcTramos)
        Me.Controls.Add(Me.gpcEncabezado)
        Me.Name = "frmItemGenerarMovimiento"
        Me.Text = "Generar Item Masivo"
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcEncabezado.ResumeLayout(False)
        Me.gpcEncabezado.PerformLayout()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleItems.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glvItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcEmpleados.ResumeLayout(False)
        CType(Me.gdcEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleRut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcTramos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcTramos.ResumeLayout(False)
        CType(Me.gdcTramos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvTramos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpcEncabezado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnIncluirProcesoRemun As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gleItems As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents glvItems As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RELACION_CABECERA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ITEM_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION_LARGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCalcular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents gpcEmpleados As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gdcEmpleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvEmpleados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gpcTramos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gdcTramos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvTramos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRELACION_TRAMO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_TRAMO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_DESDE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMonto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colMONTO_HASTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_PARA_ASIGNAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRELACION_CABECERA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPERIODO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colITEM_RELACIONADO_DETALLE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRELACION_TRAMO_ID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMontoDetalle As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents gleRut As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMONTO_ASIGNADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents colEMPLEADO_ID1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
