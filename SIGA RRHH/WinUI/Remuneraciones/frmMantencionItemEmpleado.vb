Imports cl.presidencia.Argo.Reportes
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns

Public Class frmMantencionItemEmpleado
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
    Friend WithEvents gpcEncabezado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents gdcDetalleItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvitems As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MOVIMIENTO_MENSUAL_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PERIODO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ITEM_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ORIGEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueItems As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents CUOTA_INICIAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CUOTA_FINAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtEstadoPeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rdgOrigen As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents gleItemes As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents gleRut As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rdgTipoProceso As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lblTipoProceso As System.Windows.Forms.Label
    Friend WithEvents TIPO_PROCESO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEmiteDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents prsEmpleadoItem As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents calcCantidad As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents ID_EXTERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents USUARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_MODIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMonto As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gleItems As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents glvItems As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ITEM_ID_GV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ITEM_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION_LARGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TIPO_ITEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gpcDatosMovimiento As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtNombreEmpleado As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantencionItemEmpleado))
        Me.gpcEncabezado = New DevExpress.XtraEditors.GroupControl()
        Me.txtNombreEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.btnEmiteDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTipoProceso = New System.Windows.Forms.Label()
        Me.rdgTipoProceso = New DevExpress.XtraEditors.RadioGroup()
        Me.gleRut = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtEstadoPeriodo = New DevExpress.XtraEditors.TextEdit()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.gdcDetalleItems = New DevExpress.XtraGrid.GridControl()
        Me.gdvitems = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MOVIMIENTO_MENSUAL_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PERIODO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ITEM_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleItemes = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.EMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.calcCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.ORIGEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rdgOrigen = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.CUOTA_INICIAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CUOTA_FINAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TIPO_PROCESO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ID_EXTERNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.USUARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_MODIFICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.prsEmpleadoItem = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.gpcDatosMovimiento = New DevExpress.XtraEditors.GroupControl()
        Me.gleItems = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.glvItems = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ITEM_ID_GV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ITEM_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION_LARGA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TIPO_ITEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMonto = New DevExpress.XtraEditors.CalcEdit()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcEncabezado.SuspendLayout()
        CType(Me.txtNombreEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstadoPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcDetalleItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvitems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleItemes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.calcCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prsEmpleadoItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDatosMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDatosMovimiento.SuspendLayout()
        CType(Me.gleItems.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcEncabezado
        '
        Me.gpcEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcEncabezado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcEncabezado.AppearanceCaption.Options.UseFont = True
        Me.gpcEncabezado.Controls.Add(Me.txtNombreEmpleado)
        Me.gpcEncabezado.Controls.Add(Me.btnEmiteDetalle)
        Me.gpcEncabezado.Controls.Add(Me.lblTipoProceso)
        Me.gpcEncabezado.Controls.Add(Me.rdgTipoProceso)
        Me.gpcEncabezado.Controls.Add(Me.gleRut)
        Me.gpcEncabezado.Controls.Add(Me.txtEstadoPeriodo)
        Me.gpcEncabezado.Controls.Add(Me.luePeriodo)
        Me.gpcEncabezado.Controls.Add(Me.lblEmpleado)
        Me.gpcEncabezado.Controls.Add(Me.lblPeriodo)
        Me.gpcEncabezado.Location = New System.Drawing.Point(16, 8)
        Me.gpcEncabezado.Name = "gpcEncabezado"
        Me.gpcEncabezado.Size = New System.Drawing.Size(664, 144)
        Me.gpcEncabezado.TabIndex = 0
        Me.gpcEncabezado.Text = "Período e Ítem"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreEmpleado.Enabled = False
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(240, 56)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNombreEmpleado.Properties.Appearance.Options.UseFont = True
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(288, 20)
        Me.txtNombreEmpleado.TabIndex = 8
        '
        'btnEmiteDetalle
        '
        Me.btnEmiteDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEmiteDetalle.Location = New System.Drawing.Point(456, 24)
        Me.btnEmiteDetalle.Name = "btnEmiteDetalle"
        Me.btnEmiteDetalle.Size = New System.Drawing.Size(160, 23)
        Me.btnEmiteDetalle.TabIndex = 3
        Me.btnEmiteDetalle.Text = "Visualizar"
        '
        'lblTipoProceso
        '
        Me.lblTipoProceso.Location = New System.Drawing.Point(32, 80)
        Me.lblTipoProceso.Name = "lblTipoProceso"
        Me.lblTipoProceso.Size = New System.Drawing.Size(72, 16)
        Me.lblTipoProceso.TabIndex = 7
        Me.lblTipoProceso.Text = "Tipo Proceso"
        Me.lblTipoProceso.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'rdgTipoProceso
        '
        Me.rdgTipoProceso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdgTipoProceso.Location = New System.Drawing.Point(120, 80)
        Me.rdgTipoProceso.Name = "rdgTipoProceso"
        Me.rdgTipoProceso.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Cambio de Grado"), New DevExpress.XtraEditors.Controls.RadioGroupItem("N", "Normal"), New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Suplementaria"), New DevExpress.XtraEditors.Controls.RadioGroupItem("B", "Bono Modernización")})
        Me.rdgTipoProceso.Size = New System.Drawing.Size(408, 48)
        Me.rdgTipoProceso.TabIndex = 2
        '
        'gleRut
        '
        Me.gleRut.EditValue = ""
        Me.gleRut.EnterMoveNextControl = True
        Me.gleRut.Location = New System.Drawing.Point(120, 56)
        Me.gleRut.Name = "gleRut"
        Me.gleRut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleRut.Properties.View = Me.GridLookUpEdit1View
        Me.gleRut.Size = New System.Drawing.Size(112, 20)
        Me.gleRut.TabIndex = 1
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtEstadoPeriodo
        '
        Me.txtEstadoPeriodo.Enabled = False
        Me.txtEstadoPeriodo.Location = New System.Drawing.Point(240, 32)
        Me.txtEstadoPeriodo.Name = "txtEstadoPeriodo"
        Me.txtEstadoPeriodo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtEstadoPeriodo.Properties.Appearance.Options.UseFont = True
        Me.txtEstadoPeriodo.Size = New System.Drawing.Size(112, 20)
        Me.txtEstadoPeriodo.TabIndex = 4
        '
        'luePeriodo
        '
        Me.luePeriodo.EnterMoveNextControl = True
        Me.luePeriodo.Location = New System.Drawing.Point(120, 32)
        Me.luePeriodo.Name = "luePeriodo"
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(112, 20)
        Me.luePeriodo.TabIndex = 0
        '
        'lblEmpleado
        '
        Me.lblEmpleado.Location = New System.Drawing.Point(24, 60)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(80, 16)
        Me.lblEmpleado.TabIndex = 1
        Me.lblEmpleado.Text = "Rut Empleado"
        Me.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(56, 36)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 16)
        Me.lblPeriodo.TabIndex = 0
        Me.lblPeriodo.Text = "Período"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gdcDetalleItems
        '
        Me.gdcDetalleItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcDetalleItems.Location = New System.Drawing.Point(16, 272)
        Me.gdcDetalleItems.MainView = Me.gdvitems
        Me.gdcDetalleItems.Name = "gdcDetalleItems"
        Me.gdcDetalleItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.gleItemes, Me.txtCantidad, Me.rdgOrigen, Me.calcCantidad})
        Me.gdcDetalleItems.Size = New System.Drawing.Size(664, 280)
        Me.gdcDetalleItems.TabIndex = 4
        Me.gdcDetalleItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvitems})
        '
        'gdvitems
        '
        Me.gdvitems.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvitems.Appearance.FooterPanel.Options.UseFont = True
        Me.gdvitems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MOVIMIENTO_MENSUAL_ID, Me.PERIODO_ID, Me.ITEM_ID, Me.EMPLEADO_ID, Me.CANTIDAD, Me.ORIGEN, Me.CUOTA_INICIAL, Me.CUOTA_FINAL, Me.TIPO_PROCESO, Me.ID_EXTERNO, Me.USUARIO, Me.FECHA_MODIFICACION})
        Me.gdvitems.GridControl = Me.gdcDetalleItems
        Me.gdvitems.Name = "gdvitems"
        Me.gdvitems.NewItemRowText = "Nuevo Registro"
        Me.gdvitems.OptionsNavigation.EnterMoveNextColumn = True
        Me.gdvitems.OptionsView.ShowFooter = True
        Me.gdvitems.OptionsView.ShowGroupPanel = False
        '
        'MOVIMIENTO_MENSUAL_ID
        '
        Me.MOVIMIENTO_MENSUAL_ID.Caption = "Id Movto.Mensual"
        Me.MOVIMIENTO_MENSUAL_ID.FieldName = "MOVIMIENTO_MENSUAL_ID"
        Me.MOVIMIENTO_MENSUAL_ID.Name = "MOVIMIENTO_MENSUAL_ID"
        Me.MOVIMIENTO_MENSUAL_ID.OptionsColumn.ReadOnly = True
        '
        'PERIODO_ID
        '
        Me.PERIODO_ID.Caption = "Id Período"
        Me.PERIODO_ID.FieldName = "PERIODO_ID"
        Me.PERIODO_ID.Name = "PERIODO_ID"
        Me.PERIODO_ID.OptionsColumn.ReadOnly = True
        '
        'ITEM_ID
        '
        Me.ITEM_ID.Caption = "Ítem"
        Me.ITEM_ID.ColumnEdit = Me.gleItemes
        Me.ITEM_ID.FieldName = "ITEM_ID"
        Me.ITEM_ID.Name = "ITEM_ID"
        Me.ITEM_ID.OptionsColumn.ReadOnly = True
        Me.ITEM_ID.Visible = True
        Me.ITEM_ID.VisibleIndex = 0
        Me.ITEM_ID.Width = 388
        '
        'gleItemes
        '
        Me.gleItemes.AutoHeight = False
        Me.gleItemes.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleItemes.Name = "gleItemes"
        Me.gleItemes.NullText = ""
        Me.gleItemes.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'EMPLEADO_ID
        '
        Me.EMPLEADO_ID.Caption = "Empleado"
        Me.EMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.EMPLEADO_ID.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.EMPLEADO_ID.Name = "EMPLEADO_ID"
        Me.EMPLEADO_ID.OptionsColumn.ReadOnly = True
        Me.EMPLEADO_ID.Width = 581
        '
        'CANTIDAD
        '
        Me.CANTIDAD.Caption = "Cantidad"
        Me.CANTIDAD.ColumnEdit = Me.calcCantidad
        Me.CANTIDAD.FieldName = "CANTIDAD"
        Me.CANTIDAD.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.SummaryItem.DisplayFormat = "Total General: {0:n0}"
        Me.CANTIDAD.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.CANTIDAD.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.CANTIDAD.Visible = True
        Me.CANTIDAD.VisibleIndex = 1
        Me.CANTIDAD.Width = 444
        '
        'calcCantidad
        '
        Me.calcCantidad.AutoHeight = False
        Me.calcCantidad.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.calcCantidad.DisplayFormat.FormatString = "n0"
        Me.calcCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.calcCantidad.EditFormat.FormatString = "n0"
        Me.calcCantidad.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.calcCantidad.Mask.EditMask = "n0"
        Me.calcCantidad.Mask.UseMaskAsDisplayFormat = True
        Me.calcCantidad.MaxLength = 8
        Me.calcCantidad.Name = "calcCantidad"
        Me.calcCantidad.Precision = 0
        '
        'ORIGEN
        '
        Me.ORIGEN.Caption = "Origen del Dato"
        Me.ORIGEN.ColumnEdit = Me.rdgOrigen
        Me.ORIGEN.FieldName = "ORIGEN"
        Me.ORIGEN.Name = "ORIGEN"
        Me.ORIGEN.OptionsColumn.ReadOnly = True
        Me.ORIGEN.Width = 329
        '
        'rdgOrigen
        '
        Me.rdgOrigen.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Bienestar"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Remuneración"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Ficha Empleado")})
        Me.rdgOrigen.Name = "rdgOrigen"
        '
        'CUOTA_INICIAL
        '
        Me.CUOTA_INICIAL.Caption = "Cuota Inicial"
        Me.CUOTA_INICIAL.FieldName = "CUOTA_INICIAL"
        Me.CUOTA_INICIAL.Name = "CUOTA_INICIAL"
        Me.CUOTA_INICIAL.OptionsColumn.ReadOnly = True
        '
        'CUOTA_FINAL
        '
        Me.CUOTA_FINAL.Caption = "Cuota Final"
        Me.CUOTA_FINAL.FieldName = "CUOTA_FINAL"
        Me.CUOTA_FINAL.Name = "CUOTA_FINAL"
        Me.CUOTA_FINAL.OptionsColumn.ReadOnly = True
        '
        'TIPO_PROCESO
        '
        Me.TIPO_PROCESO.Caption = "Tipo Proceso"
        Me.TIPO_PROCESO.FieldName = "TIPO_PROCESO"
        Me.TIPO_PROCESO.Name = "TIPO_PROCESO"
        Me.TIPO_PROCESO.OptionsColumn.ReadOnly = True
        '
        'ID_EXTERNO
        '
        Me.ID_EXTERNO.Caption = "ID Externo"
        Me.ID_EXTERNO.FieldName = "ID_EXTERNO"
        Me.ID_EXTERNO.Name = "ID_EXTERNO"
        Me.ID_EXTERNO.OptionsColumn.ReadOnly = True
        '
        'USUARIO
        '
        Me.USUARIO.Caption = "Usuario"
        Me.USUARIO.FieldName = "USUARIO"
        Me.USUARIO.Name = "USUARIO"
        Me.USUARIO.OptionsColumn.ReadOnly = True
        '
        'FECHA_MODIFICACION
        '
        Me.FECHA_MODIFICACION.Caption = "Fecha Modificación"
        Me.FECHA_MODIFICACION.FieldName = "FECHA_MODIFICACION"
        Me.FECHA_MODIFICACION.Name = "FECHA_MODIFICACION"
        Me.FECHA_MODIFICACION.OptionsColumn.ReadOnly = True
        '
        'txtCantidad
        '
        Me.txtCantidad.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCantidad.Mask.EditMask = "n0"
        Me.txtCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantidad.Mask.UseMaskAsDisplayFormat = True
        Me.txtCantidad.Name = "txtCantidad"
        '
        'prsEmpleadoItem
        '
        Me.prsEmpleadoItem.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcDetalleItems
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de la República", "Movimiento Mensual por Empleado", "Fecha Emisión:[Date Printed]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Emitido por:[User Name]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"", "", "Página:[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.prsEmpleadoItem
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prsEmpleadoItem
        '
        'gpcDatosMovimiento
        '
        Me.gpcDatosMovimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcDatosMovimiento.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDatosMovimiento.AppearanceCaption.Options.UseFont = True
        Me.gpcDatosMovimiento.Controls.Add(Me.gleItems)
        Me.gpcDatosMovimiento.Controls.Add(Me.txtMonto)
        Me.gpcDatosMovimiento.Controls.Add(Me.btnCancelar)
        Me.gpcDatosMovimiento.Controls.Add(Me.btnNuevo)
        Me.gpcDatosMovimiento.Controls.Add(Me.lblCantidad)
        Me.gpcDatosMovimiento.Controls.Add(Me.Label1)
        Me.gpcDatosMovimiento.Location = New System.Drawing.Point(16, 152)
        Me.gpcDatosMovimiento.Name = "gpcDatosMovimiento"
        Me.gpcDatosMovimiento.Size = New System.Drawing.Size(664, 120)
        Me.gpcDatosMovimiento.TabIndex = 7
        Me.gpcDatosMovimiento.Text = "Datos de Movimiento"
        '
        'gleItems
        '
        Me.gleItems.EditValue = ""
        Me.gleItems.EnterMoveNextControl = True
        Me.gleItems.Location = New System.Drawing.Point(16, 40)
        Me.gleItems.Name = "gleItems"
        Me.gleItems.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleItems.Properties.PopupFormSize = New System.Drawing.Size(470, 0)
        Me.gleItems.Properties.View = Me.glvItems
        Me.gleItems.Size = New System.Drawing.Size(368, 20)
        Me.gleItems.TabIndex = 3
        '
        'glvItems
        '
        Me.glvItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ITEM_ID_GV, Me.ITEM_ALIAS, Me.DESCRIPCION_LARGA, Me.TIPO_ITEM})
        Me.glvItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.glvItems.Name = "glvItems"
        Me.glvItems.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.glvItems.OptionsView.ColumnAutoWidth = False
        Me.glvItems.OptionsView.ShowGroupPanel = False
        '
        'ITEM_ID_GV
        '
        Me.ITEM_ID_GV.Caption = "ID Item"
        Me.ITEM_ID_GV.FieldName = "ITEM_ID"
        Me.ITEM_ID_GV.Name = "ITEM_ID_GV"
        Me.ITEM_ID_GV.OptionsColumn.ReadOnly = True
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
        Me.DESCRIPCION_LARGA.Width = 239
        '
        'TIPO_ITEM
        '
        Me.TIPO_ITEM.Caption = "Tipo Item"
        Me.TIPO_ITEM.FieldName = "TIPO_ITEM"
        Me.TIPO_ITEM.Name = "TIPO_ITEM"
        Me.TIPO_ITEM.OptionsColumn.ReadOnly = True
        Me.TIPO_ITEM.Visible = True
        Me.TIPO_ITEM.VisibleIndex = 2
        '
        'txtMonto
        '
        Me.txtMonto.EnterMoveNextControl = True
        Me.txtMonto.Location = New System.Drawing.Point(408, 40)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMonto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.Properties.Mask.EditMask = "n0"
        Me.txtMonto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMonto.Properties.MaxLength = 8
        Me.txtMonto.Properties.Precision = 0
        Me.txtMonto.Size = New System.Drawing.Size(128, 20)
        Me.txtMonto.TabIndex = 4
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(160, 72)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(128, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(16, 72)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(128, 23)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "Nuevo"
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(408, 24)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(64, 16)
        Me.lblCantidad.TabIndex = 4
        Me.lblCantidad.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ítem"
        '
        'frmMantencionItemEmpleado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 558)
        Me.Controls.Add(Me.gpcDatosMovimiento)
        Me.Controls.Add(Me.gdcDetalleItems)
        Me.Controls.Add(Me.gpcEncabezado)
        Me.Name = "frmMantencionItemEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento Mensual por Empleado Ítem"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcEncabezado.ResumeLayout(False)
        CType(Me.txtNombreEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstadoPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcDetalleItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvitems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleItemes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.calcCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prsEmpleadoItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDatosMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatosMovimiento.ResumeLayout(False)
        CType(Me.gleItems.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glvItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim empleado As empleado
    Dim estadoPeriodo As Boolean
    Dim Periodo As Periodo
    Dim filtroItems() As Integer
    Public tipoProceso As String

    Public Sub New(ByVal items As Array)
        Me.New()
        'El propósito de la siguiente pregunta es establecer 
        'un filtro por defecto en caso que no existan items definidos. (-1 no debe existir como ID de Item)
        If Not items Is Nothing Then
            filtroItems = items
        Else
            ReDim filtroItems(1)
            filtroItems(0) = -1
        End If
        rdgTipoProceso.Visible = False
        rdgTipoProceso.EditValue = "N"
        lblTipoProceso.Visible = False
    End Sub

    Private Function ArrayToString(ByVal items As Array, ByVal separador As String) As String
        Dim i As Integer
        Dim rtnStr As String
        While (i <= items.Length - 1)
            If i > 0 Then
                rtnStr = rtnStr + separador
            End If
            rtnStr = rtnStr + items(i).ToString

            i += 1
        End While
        Return rtnStr
    End Function

    Private Sub frmMantencionItemPeriodo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        repositorio.RefreshDatos("Empleado")
        repositorio.RefreshDatos("Periodo")

        llenarEmpleado()
        llenarItems()

        If tipoProceso = "N" Then
            If Not filtroItems Is Nothing Then
                repositorio.dvItem.RowFilter = " ITEM_ID IN (" & ArrayToString(filtroItems, ",") & ")"
            Else
                repositorio.dvItem.RowFilter = ""
            End If
        ElseIf tipoProceso = "H" Then
            rdgTipoProceso.EditValue = "S"
            repositorio.dvItem.RowFilter = " ES_APLICABLE_HONORARIO=1 "
        End If


        empleado = New empleado

        gleItems.Properties.DataSource = repositorio.dvItem
        gleItems.Properties.DisplayMember = "DESCRIPCION_LARGA"
        gleItems.Properties.ValueMember = "ITEM_ID"
        gleItems.Properties.View.BestFitColumns()
        gleItems.Properties.PopupFormWidth = 460
        gleItems.Text = ""

        llenarPeriodos()
        gdcDetalleItems.Enabled = False
        btnNuevo.Enabled = False
        btnCancelar.Enabled = False
        btnEmiteDetalle.Enabled = False
        gleItems.Enabled = False
        txtMonto.Enabled = False


    End Sub
    Public Sub llenarEmpleado()
        gleRut.Properties.EditValueChangedFiringDelay = 1200
        gleRut.Properties.EditValueChangedFiringMode = EditValueChangedFiringMode.Buffered
        'Dos segundos se espera antes de gatillar la búsqueda (EditValueChanged)

        gleRut.Properties.ViewType = Repository.GridLookUpViewType.GridView
        gleRut.Properties.View.OptionsBehavior.AutoPopulateColumns = False

        If Me.tipoProceso = "H" Then
            gleRut.Properties.DataSource = repositorio.dvEmpleadosActivosInactivosSoloHonorario
        Else
            gleRut.Properties.DataSource = repositorio.dvEmpleadosPlantaContrataActivosInactivos
        End If

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

        Dim col5 As GridColumn = gleRut.Properties.View.Columns.AddField("DESC_CALIDAD_JURIDICA")
        col5.VisibleIndex = 5
        col5.Caption = "Calidad Jurídica"
        col5.Visible = True

        Dim col6 As GridColumn = gleRut.Properties.View.Columns.AddField("DESC_ESTADO")
        col6.VisibleIndex = 4
        col6.Caption = "Estado"

        Dim col7 As GridColumn = gleRut.Properties.View.Columns.AddField("NOMBRE_COMPLETO")
        col7.VisibleIndex = 6
        col7.Caption = "Nombre Completo"
        col7.Visible = False

        gleRut.Properties.ValueMember = "EMPLEADO_ID"

        gleRut.Properties.View.BestFitColumns()
        gleRut.Properties.PopupFormWidth = 600

        gleRut.Text = ""
    End Sub
    Public Sub llenarItems()
        gleItemes.ViewType = Repository.GridLookUpViewType.GridView
        gleItemes.View.OptionsBehavior.AutoPopulateColumns = False
        gleItemes.DataSource = repositorio.dvItem
        gleItemes.DisplayMember = "DESCRIPCION_LARGA"

        Dim col1 As GridColumn = gleItemes.View.Columns.AddField("ITEM_ID")
        col1.VisibleIndex = 0
        col1.Caption = "RUT"
        col1.Visible = False

        Dim col2 As GridColumn = gleItemes.View.Columns.AddField("ITEM_ALIAS")
        col2.VisibleIndex = 1
        col2.Caption = "Código"

        Dim col3 As GridColumn = gleItemes.View.Columns.AddField("DESCRIPCION_LARGA")
        col3.VisibleIndex = 2
        col3.Caption = "Descripción"

        Dim col4 As GridColumn = gleItemes.View.Columns.AddField("ES_CALCULABLE")
        col4.VisibleIndex = 3
        col4.Caption = "Es Calculable"
        col4.Visible = False

        gleItemes.ValueMember = "ITEM_ID"
        gleItemes.View.BestFitColumns()
        gleItemes.PopupFormWidth = 600

        If Not filtroItems Is Nothing Then
            repositorio.dvItem.RowFilter = " ITEM_ID IN (" & ArrayToString(filtroItems, ",") & ")"
        Else
            repositorio.dvItem.RowFilter = ""
        End If

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
    Private Sub gdvitems_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvitems.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        view.SetRowCellValue(e.RowHandle, "EMPLEADO_ID", gleRut.EditValue)
        view.SetRowCellValue(e.RowHandle, "PERIODO_ID", luePeriodo.EditValue)
        view.SetRowCellValue(e.RowHandle, "ORIGEN", 1)
        view.SetRowCellValue(e.RowHandle, "CUOTA_INICIAL", 0)
        view.SetRowCellValue(e.RowHandle, "CUOTA_FINAL", 0)
        view.SetRowCellValue(e.RowHandle, "TIPO_PROCESO", rdgTipoProceso.EditValue)
    End Sub
    Private Sub gdvitems_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvitems.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
        Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
        refrescaDetalle()
        If Not IsNothing(row) Then
            Periodo = New Periodo(CType(row("PERIODO_ID"), Integer))
            estadoPeriodo = Periodo.estadoPeriodo
            If Periodo.procesoSuplementarioCerrado And Me.rdgTipoProceso.EditValue = "S" Then
                gdcDetalleItems.Enabled = False
                gpcDatosMovimiento.Enabled = False
            End If
            'Si el estado del periodo es 0 (No Activo) deshabilita la grilla
            If estadoPeriodo = False Then
                gdcDetalleItems.Enabled = False
                gpcDatosMovimiento.Enabled = False
                txtEstadoPeriodo.Text = "INACTIVO"
            Else
                gdcDetalleItems.Enabled = True
                gpcDatosMovimiento.Enabled = True
                txtEstadoPeriodo.Text = "ACTIVO"
            End If
        End If
    End Sub
    Private Sub gleRut_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gleRut.EditValueChanged
        Cursor.Current = Cursors.WaitCursor
        If IsNumeric(gleRut.EditValue) Then
            empleado = New empleado(CType(gleRut.EditValue, Long))
            refrescaDetalle()
        End If
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub rdgTipoProceso_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdgTipoProceso.EditValueChanged
        refrescaDetalle()
    End Sub
    Private Sub refrescaDetalle()
        If gleRut.EditValue <> Nothing And luePeriodo.EditValue <> Nothing And rdgTipoProceso.EditValue <> Nothing Then
            If Me.tipoProceso = "H" Then
                gdcDetalleItems.DataSource = empleado.dvItemesEmpleadoPeriodo(CType(gleRut.EditValue, Integer), CType(luePeriodo.EditValue, Integer), rdgTipoProceso.EditValue)
            Else
                If Not filtroItems Is Nothing Then
                    gdcDetalleItems.DataSource = empleado.dvItemesEmpleadoPeriodo(CType(gleRut.EditValue, Integer), CType(luePeriodo.EditValue, Integer), rdgTipoProceso.EditValue, filtroItems)
                Else
                    gdcDetalleItems.DataSource = empleado.dvItemesEmpleadoPeriodo(CType(gleRut.EditValue, Integer), CType(luePeriodo.EditValue, Integer), rdgTipoProceso.EditValue)
                End If
            End If
            btnNuevo.Enabled = True
            gdcDetalleItems.Enabled = True
            gpcDatosMovimiento.Enabled = True
            txtNombreEmpleado.Text = empleado.nombreCompleto

            If estadoPeriodo = False Then
                gdcDetalleItems.Enabled = False
                txtEstadoPeriodo.Text = "INACTIVO"
            Else
                gdcDetalleItems.Enabled = True
                txtEstadoPeriodo.Text = "ACTIVO"
            End If
            If gdvitems.RowCount > 0 Then
                btnEmiteDetalle.Enabled = True
            Else
                btnEmiteDetalle.Enabled = False
            End If
            If Periodo.procesoSuplementarioCerrado And Me.rdgTipoProceso.EditValue = "S" Then
                btnNuevo.Enabled = False
                gdcDetalleItems.Enabled = False
                gpcDatosMovimiento.Enabled = False
            End If
        Else
            btnNuevo.Enabled = False
            btnCancelar.Enabled = False
            btnEmiteDetalle.Enabled = False
        End If
    End Sub
    Private Sub gdvitems_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvitems.RowUpdated
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim idPeriodo, idItem, idEmpleado, origen, cantidad As Integer
        Dim cuotaIni, cuotaFin As Short
        Dim tipoProceso As String

        idPeriodo = view.GetRowCellValue(e.RowHandle, view.Columns("PERIODO_ID"))
        idItem = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("ITEM_ID"))
        idEmpleado = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("EMPLEADO_ID"))
        cuotaIni = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("CUOTA_INICIAL"))
        cuotaFin = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("CUOTA_FINAL"))
        origen = cuotaFin = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("ORIGEN"))
        cantidad = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("CANTIDAD"))
        tipoProceso = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("TIPO_PROCESO"))
        If empleado.actualizarMovimientoMensual() Then
            gdcDetalleItems.DataSource = empleado.dvItemesEmpleadoPeriodo(CType(gleRut.EditValue, Integer), CType(luePeriodo.EditValue, Integer), rdgTipoProceso.EditValue)
            gdcDetalleItems.Refresh()
        End If
    End Sub
    Private Sub gdvitems_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvitems.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            Dim myview As DevExpress.XtraGrid.Views.Grid.GridView = sender
            Dim OrigenDato As Integer = myview.GetRowCellValue(myview.FocusedRowHandle, myview.Columns("ORIGEN"))
            Dim idEmpleado As Integer = myview.GetRowCellValue(myview.FocusedRowHandle, myview.Columns("EMPLEADO_ID"))
            Dim tipoProceso As String = myview.GetRowCellValue(myview.FocusedRowHandle, myview.Columns("TIPO_PROCESO"))
            Dim idItem As String = myview.GetRowCellValue(myview.FocusedRowHandle, myview.Columns("ITEM_ID"))

            If OrigenDato = 2 Then
                MsgBox("Este registro no puede ser eliminado, es base para cálculo de liquidación", MsgBoxStyle.Information)
            Else
                If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                    view.DeleteRow(view.FocusedRowHandle)
                    Try
                        empleado.EliminarMovimientoMensualItemEmpleado(luePeriodo.EditValue, idEmpleado, OrigenDato, tipoProceso, idItem)
                        gdcDetalleItems.DataSource = Nothing
                        gdcDetalleItems.DataSource = empleado.dvItemesEmpleadoPeriodo(CType(gleRut.EditValue, Integer), CType(luePeriodo.EditValue, Integer), rdgTipoProceso.EditValue)
                        gdvitems.RefreshData()
                        MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)
                    Catch ex As Exception
                        MsgBox("Ha ocurrido un error al intentar eliminar el registro " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                End If
            End If
        End If
    End Sub
    Private Sub gdvitems_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gdvitems.ValidateRow
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        Dim IDmovto As Integer = view.GetRowCellValue(view.FocusedRowHandle, view.Columns(0))
        Dim IDItem As Integer = view.GetRowCellValue(view.FocusedRowHandle, view.Columns(2))
        Dim OrigenDato As Integer = view.GetRowCellValue(view.FocusedRowHandle, view.Columns(5))

        Dim codigo As String = CType(IDItem, String) + " AND EMPLEADO_ID=" + CType(gleRut.EditValue, String) + " AND PERIODO_ID=" + CType(luePeriodo.EditValue, String)
        Dim idemple As Integer

        If OrigenDato = 2 Then
            MsgBox("Este registro no puede ser modificado, es base para cálculo de liquidación", MsgBoxStyle.Information)
            e.Valid = False
        Else
            idemple = DataAccess.Utiles.buscaID(Tablas.RH_REM_MOVIMIENTO_MENSUAL, "NN", "ITEM_ID", codigo, "MOVIMIENTO_MENSUAL_ID")
            If idemple > 0 And idemple <> IDmovto Then
                If MsgBox("Ya existe registro del empleado para el periodo y el ítem", MsgBoxStyle.OKCancel) = MsgBoxResult.OK Then
                    e.Valid = True
                Else
                    e.Valid = False
                End If
            Else
                If view.GetRowCellValue(view.FocusedRowHandle, view.Columns("CANTIDAD")) = 0 Then
                    If MsgBox("¿Esta usted seguro de ingresar el valor del registro en cero?", MsgBoxStyle.OKCancel) = MsgBoxResult.OK Then
                        e.Valid = True
                    Else
                        e.Valid = False
                    End If
                Else
                    If view.GetRowCellValue(view.FocusedRowHandle, view.Columns("CANTIDAD")) < 0 Then
                        MsgBox("Cantidad no puede ser menor a cero", MsgBoxStyle.Exclamation)
                        e.Valid = False
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        'empleado = New Empleado(CType(gleRut.EditValue, Long))
        Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(luePeriodo, DevExpress.XtraEditors.LookUpEdit)
        Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
        Dim nombreProceso As String
        If rdgTipoProceso.EditValue = "N" Then
            nombreProceso = "NORMAL"
        Else
            If rdgTipoProceso.EditValue = "S" Then
                nombreProceso = "SUPLEMENTARIA"
            Else
                If rdgTipoProceso.EditValue = "C" Then
                    nombreProceso = "CAMBIO GRADO"
                Else
                    nombreProceso = "BONO MODERNIZACION"
                End If
            End If
        End If
        Dim reportHeader As String = "EMPLEADO : " & empleado.nombreCompleto & " - " & "PERIODO : " & row("DESCRIPCION_PERIODO") & " - " & "PROCESO : " & nombreProceso
        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)
    End Sub
    Private Sub btnEmiteDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmiteDetalle.Click
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptMovimientoMensualporEmpleado
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        Dim strFormulaSeleccion As String = "{VW_MOVIMIENTO_MENSUAL.PERIODO_ID}=" & luePeriodo.EditValue
        strFormulaSeleccion &= " AND {VW_MOVIMIENTO_MENSUAL.TIPO_PROCESO}=" & """" & CType(rdgTipoProceso.EditValue, String).ToString & """"
        strFormulaSeleccion &= " AND {VW_MOVIMIENTO_MENSUAL.EMPLEADO_ID}=" & gleRut.EditValue
        With ventanaReporte1
            .rptVisor.ShowGroupTreeButton = False
            .rptVisor.SelectionFormula = strFormulaSeleccion
            .rptVisor.ReportSource = reporte
            .Show()
        End With

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim respuesta As Boolean = True
        If btnNuevo.Text = "Nuevo" Then
            gleItems.Enabled = True
            txtMonto.Enabled = True
            btnNuevo.Text = "Guardar"
            btnCancelar.Enabled = True
        Else
            Dim idEmple As Integer
            idEmple = empleado.recuperaIdentificador(comandosSQL())
            If idEmple > 0 Then
                If MsgBox("Ya existe registro del empleado para el periodo y el ítem", MsgBoxStyle.OKOnly) = MsgBoxResult.OK Then
                    respuesta = False
                End If
            Else
                If txtMonto.EditValue = 0 Then
                    If MsgBox("¿Esta usted seguro de ingresar el valor del registro en cero?", MsgBoxStyle.OKCancel) = MsgBoxResult.OK Then
                        respuesta = True
                    Else
                        respuesta = False
                    End If
                Else
                    If txtMonto.EditValue < 0 Then
                        MsgBox("Cantidad no puede ser menor a cero", MsgBoxStyle.Exclamation)
                        respuesta = False
                    Else
                        respuesta = True
                    End If
                End If
            End If
            If respuesta Then
                Dim idPeriodo As Integer = luePeriodo.EditValue
                Dim idItem As Integer = gleItems.EditValue
                Dim idEmpleado As Integer = gleRut.EditValue
                Dim cuotaIni As Integer = 0
                Dim cuotaFIn As Integer = 0
                Dim origen As Integer = 1
                Dim cantidad As Integer = txtMonto.EditValue
                Dim tipoProceso As String = rdgTipoProceso.EditValue

                If empleado.insertarDatoMovimientoMensual(idPeriodo, idItem, idEmpleado, cuotaIni, cuotaFIn, origen, cantidad, tipoProceso) Then
                    gdcDetalleItems.DataSource = Nothing
                    gdcDetalleItems.DataSource = empleado.dvItemesEmpleadoPeriodo(CType(gleRut.EditValue, Integer), CType(luePeriodo.EditValue, Integer), rdgTipoProceso.EditValue)
                    gdvitems.RefreshData()
                End If

                txtMonto.EditValue = 0
                gleItems.Text = ""
                refrescaDetalle()
                btnNuevo.Text = "Nuevo"
                btnCancelar.Enabled = False
                gleItems.Enabled = False
                txtMonto.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        txtMonto.EditValue = 0
        gleItems.Text = ""
        refrescaDetalle()
        btnNuevo.Text = "Nuevo"
        btnCancelar.Enabled = False
        gleItems.Enabled = False
        txtMonto.Enabled = False
    End Sub
    Private Function comandosSQL() As String
        Dim cmdProceso, cmdSQL As String
        cmdProceso = " AND TIPO_PROCESO=" + "'" + rdgTipoProceso.EditValue + "'"
        cmdSQL = "SELECT MOVIMIENTO_MENSUAL_ID FROM " & Tablas.RH_REM_MOVIMIENTO_MENSUAL & " WHERE ITEM_ID=" & gleItems.EditValue & " AND PERIODO_ID=" & luePeriodo.EditValue & cmdProceso & " AND EMPLEADO_ID=" & gleRut.EditValue
        Return cmdSQL
    End Function

    Private Sub frmMantencionItemEmpleado_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Disposed
        Periodo = Nothing
    End Sub
End Class
