<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemGenerado
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
        Me.btnInlcuirEnRemuneracion = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCalcularMontos = New DevExpress.XtraEditors.SimpleButton()
        Me.gleItems = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.glvItems = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ITEM_ID_GV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ITEM_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION_LARGA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TIPO_ITEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.gpcTramos = New DevExpress.XtraEditors.GroupControl()
        Me.gdcTramos = New DevExpress.XtraGrid.GridControl()
        Me.gdvTramos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRELACION_TRAMO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_TRAMO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_DESDE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_HASTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_PARA_ASIGNAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gpcEmpleados = New DevExpress.XtraEditors.GroupControl()
        Me.gdcEmpleados = New DevExpress.XtraGrid.GridControl()
        Me.gdvEmpleados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.EMPELADO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_COMPLETO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_HABER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_ASIGNADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_INGRESO = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcEncabezado.SuspendLayout()
        CType(Me.gleItems.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcTramos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcTramos.SuspendLayout()
        CType(Me.gdcTramos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvTramos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcEmpleados.SuspendLayout()
        CType(Me.gdcEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcEncabezado
        '
        Me.gpcEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcEncabezado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcEncabezado.AppearanceCaption.Options.UseFont = True
        Me.gpcEncabezado.Controls.Add(Me.btnInlcuirEnRemuneracion)
        Me.gpcEncabezado.Controls.Add(Me.btnExportar)
        Me.gpcEncabezado.Controls.Add(Me.btnCalcularMontos)
        Me.gpcEncabezado.Controls.Add(Me.gleItems)
        Me.gpcEncabezado.Controls.Add(Me.lblItem)
        Me.gpcEncabezado.Location = New System.Drawing.Point(1, 1)
        Me.gpcEncabezado.Name = "gpcEncabezado"
        Me.gpcEncabezado.Size = New System.Drawing.Size(888, 78)
        Me.gpcEncabezado.TabIndex = 2
        Me.gpcEncabezado.Text = "Ítem"
        '
        'btnInlcuirEnRemuneracion
        '
        Me.btnInlcuirEnRemuneracion.Location = New System.Drawing.Point(696, 31)
        Me.btnInlcuirEnRemuneracion.Name = "btnInlcuirEnRemuneracion"
        Me.btnInlcuirEnRemuneracion.Size = New System.Drawing.Size(175, 23)
        Me.btnInlcuirEnRemuneracion.TabIndex = 4
        Me.btnInlcuirEnRemuneracion.Text = "Incluir en Proceso Remuneración"
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(572, 31)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(106, 23)
        Me.btnExportar.TabIndex = 3
        Me.btnExportar.Text = "Exportar a Excel"
        '
        'btnCalcularMontos
        '
        Me.btnCalcularMontos.Location = New System.Drawing.Point(450, 31)
        Me.btnCalcularMontos.Name = "btnCalcularMontos"
        Me.btnCalcularMontos.Size = New System.Drawing.Size(106, 23)
        Me.btnCalcularMontos.TabIndex = 2
        Me.btnCalcularMontos.Text = "Calcular Montos"
        '
        'gleItems
        '
        Me.gleItems.EditValue = ""
        Me.gleItems.Location = New System.Drawing.Point(81, 34)
        Me.gleItems.Name = "gleItems"
        Me.gleItems.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleItems.Properties.PopupFormSize = New System.Drawing.Size(470, 0)
        Me.gleItems.Properties.View = Me.glvItems
        Me.gleItems.Size = New System.Drawing.Size(328, 20)
        Me.gleItems.TabIndex = 1
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
        'lblItem
        '
        Me.lblItem.Location = New System.Drawing.Point(17, 38)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(48, 16)
        Me.lblItem.TabIndex = 1
        Me.lblItem.Text = "Item"
        Me.lblItem.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gpcTramos
        '
        Me.gpcTramos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcTramos.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcTramos.AppearanceCaption.Options.UseFont = True
        Me.gpcTramos.Controls.Add(Me.gdcTramos)
        Me.gpcTramos.Location = New System.Drawing.Point(1, 83)
        Me.gpcTramos.Name = "gpcTramos"
        Me.gpcTramos.Size = New System.Drawing.Size(888, 161)
        Me.gpcTramos.TabIndex = 3
        Me.gpcTramos.Text = "Definición de Tramos para Asignar"
        '
        'gdcTramos
        '
        Me.gdcTramos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcTramos.Location = New System.Drawing.Point(0, 17)
        Me.gdcTramos.MainView = Me.gdvTramos
        Me.gdcTramos.Name = "gdcTramos"
        Me.gdcTramos.Size = New System.Drawing.Size(883, 140)
        Me.gdcTramos.TabIndex = 0
        Me.gdcTramos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvTramos})
        '
        'gdvTramos
        '
        Me.gdvTramos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRELACION_TRAMO_ID, Me.colNOMBRE_TRAMO, Me.colMONTO_DESDE, Me.colMONTO_HASTA, Me.colMONTO_PARA_ASIGNAR})
        Me.gdvTramos.GridControl = Me.gdcTramos
        Me.gdvTramos.Name = "gdvTramos"
        Me.gdvTramos.OptionsView.ShowGroupPanel = False
        '
        'colRELACION_TRAMO_ID
        '
        Me.colRELACION_TRAMO_ID.Caption = "Tramo id"
        Me.colRELACION_TRAMO_ID.FieldName = "RELACION_TRAMO_ID"
        Me.colRELACION_TRAMO_ID.Name = "colRELACION_TRAMO_ID"
        Me.colRELACION_TRAMO_ID.OptionsColumn.AllowEdit = False
        Me.colRELACION_TRAMO_ID.OptionsColumn.ShowCaption = False
        Me.colRELACION_TRAMO_ID.OptionsColumn.ShowInCustomizationForm = False
        '
        'colNOMBRE_TRAMO
        '
        Me.colNOMBRE_TRAMO.Caption = "Nombre Tramo"
        Me.colNOMBRE_TRAMO.FieldName = "NOMBRE_TRAMO"
        Me.colNOMBRE_TRAMO.Name = "colNOMBRE_TRAMO"
        Me.colNOMBRE_TRAMO.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNOMBRE_TRAMO.OptionsColumn.AllowMove = False
        Me.colNOMBRE_TRAMO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNOMBRE_TRAMO.Visible = True
        Me.colNOMBRE_TRAMO.VisibleIndex = 0
        '
        'colMONTO_DESDE
        '
        Me.colMONTO_DESDE.Caption = "Monto Desde"
        Me.colMONTO_DESDE.FieldName = "MONTO_DESDE"
        Me.colMONTO_DESDE.Name = "colMONTO_DESDE"
        Me.colMONTO_DESDE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMONTO_DESDE.OptionsColumn.AllowMove = False
        Me.colMONTO_DESDE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMONTO_DESDE.Visible = True
        Me.colMONTO_DESDE.VisibleIndex = 1
        '
        'colMONTO_HASTA
        '
        Me.colMONTO_HASTA.Caption = "Monto Hasta"
        Me.colMONTO_HASTA.FieldName = "MONTO_HASTA"
        Me.colMONTO_HASTA.Name = "colMONTO_HASTA"
        Me.colMONTO_HASTA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMONTO_HASTA.OptionsColumn.AllowMove = False
        Me.colMONTO_HASTA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMONTO_HASTA.Visible = True
        Me.colMONTO_HASTA.VisibleIndex = 2
        '
        'colMONTO_PARA_ASIGNAR
        '
        Me.colMONTO_PARA_ASIGNAR.Caption = "Monto a Asignar"
        Me.colMONTO_PARA_ASIGNAR.FieldName = "MONTO_PARA_ASIGNAR"
        Me.colMONTO_PARA_ASIGNAR.Name = "colMONTO_PARA_ASIGNAR"
        Me.colMONTO_PARA_ASIGNAR.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMONTO_PARA_ASIGNAR.OptionsColumn.AllowMove = False
        Me.colMONTO_PARA_ASIGNAR.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMONTO_PARA_ASIGNAR.Visible = True
        Me.colMONTO_PARA_ASIGNAR.VisibleIndex = 3
        '
        'gpcEmpleados
        '
        Me.gpcEmpleados.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcEmpleados.AppearanceCaption.Options.UseFont = True
        Me.gpcEmpleados.Controls.Add(Me.gdcEmpleados)
        Me.gpcEmpleados.Location = New System.Drawing.Point(1, 246)
        Me.gpcEmpleados.Name = "gpcEmpleados"
        Me.gpcEmpleados.Size = New System.Drawing.Size(888, 190)
        Me.gpcEmpleados.TabIndex = 4
        Me.gpcEmpleados.Text = "Empleados"
        '
        'gdcEmpleados
        '
        Me.gdcEmpleados.Location = New System.Drawing.Point(0, 26)
        Me.gdcEmpleados.MainView = Me.gdvEmpleados
        Me.gdcEmpleados.Name = "gdcEmpleados"
        Me.gdcEmpleados.Size = New System.Drawing.Size(883, 164)
        Me.gdcEmpleados.TabIndex = 0
        Me.gdcEmpleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvEmpleados})
        '
        'gdvEmpleados
        '
        Me.gdvEmpleados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.EMPELADO_ID, Me.colNOMBRE_COMPLETO, Me.colFECHA_INGRESO, Me.colMONTO_HABER, Me.colMONTO_ASIGNADO})
        Me.gdvEmpleados.GridControl = Me.gdcEmpleados
        Me.gdvEmpleados.Name = "gdvEmpleados"
        Me.gdvEmpleados.OptionsView.ShowGroupPanel = False
        '
        'EMPELADO_ID
        '
        Me.EMPELADO_ID.Caption = "Empleado Id"
        Me.EMPELADO_ID.FieldName = "EMPELADO_ID"
        Me.EMPELADO_ID.Name = "EMPELADO_ID"
        '
        'colNOMBRE_COMPLETO
        '
        Me.colNOMBRE_COMPLETO.Caption = "Nombre Empleado"
        Me.colNOMBRE_COMPLETO.FieldName = "NOMBRE_COMPLETO"
        Me.colNOMBRE_COMPLETO.Name = "colNOMBRE_COMPLETO"
        Me.colNOMBRE_COMPLETO.OptionsColumn.AllowEdit = False
        Me.colNOMBRE_COMPLETO.OptionsColumn.AllowMove = False
        Me.colNOMBRE_COMPLETO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNOMBRE_COMPLETO.Visible = True
        Me.colNOMBRE_COMPLETO.VisibleIndex = 0
        Me.colNOMBRE_COMPLETO.Width = 368
        '
        'colMONTO_HABER
        '
        Me.colMONTO_HABER.Caption = "Monto Haber"
        Me.colMONTO_HABER.FieldName = "MONTO_HABER"
        Me.colMONTO_HABER.Name = "colMONTO_HABER"
        Me.colMONTO_HABER.OptionsColumn.AllowEdit = False
        Me.colMONTO_HABER.OptionsColumn.AllowMove = False
        Me.colMONTO_HABER.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMONTO_HABER.Visible = True
        Me.colMONTO_HABER.VisibleIndex = 2
        Me.colMONTO_HABER.Width = 146
        '
        'colMONTO_ASIGNADO
        '
        Me.colMONTO_ASIGNADO.Caption = "Monto Calculado"
        Me.colMONTO_ASIGNADO.FieldName = "MONTO_ASIGNADO"
        Me.colMONTO_ASIGNADO.Name = "colMONTO_ASIGNADO"
        Me.colMONTO_ASIGNADO.OptionsColumn.AllowEdit = False
        Me.colMONTO_ASIGNADO.OptionsColumn.AllowMove = False
        Me.colMONTO_ASIGNADO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMONTO_ASIGNADO.Visible = True
        Me.colMONTO_ASIGNADO.VisibleIndex = 3
        Me.colMONTO_ASIGNADO.Width = 194
        '
        'colFECHA_INGRESO
        '
        Me.colFECHA_INGRESO.Caption = "Fecha Ingreso"
        Me.colFECHA_INGRESO.FieldName = "FECHA_INGRESO"
        Me.colFECHA_INGRESO.Name = "colFECHA_INGRESO"
        Me.colFECHA_INGRESO.OptionsColumn.AllowEdit = False
        Me.colFECHA_INGRESO.OptionsColumn.AllowMove = False
        Me.colFECHA_INGRESO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colFECHA_INGRESO.Visible = True
        Me.colFECHA_INGRESO.VisibleIndex = 1
        Me.colFECHA_INGRESO.Width = 154
        '
        'frmItemGenerado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 438)
        Me.Controls.Add(Me.gpcEmpleados)
        Me.Controls.Add(Me.gpcTramos)
        Me.Controls.Add(Me.gpcEncabezado)
        Me.Name = "frmItemGenerado"
        Me.Text = "frmItemGenerado"
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcEncabezado.ResumeLayout(False)
        CType(Me.gleItems.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glvItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcTramos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcTramos.ResumeLayout(False)
        CType(Me.gdcTramos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvTramos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcEmpleados.ResumeLayout(False)
        CType(Me.gdcEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpcEncabezado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnInlcuirEnRemuneracion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCalcularMontos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gleItems As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents glvItems As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ITEM_ID_GV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ITEM_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION_LARGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TIPO_ITEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents gpcTramos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gdcTramos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvTramos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRELACION_TRAMO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_TRAMO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_DESDE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_HASTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_PARA_ASIGNAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gpcEmpleados As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gdcEmpleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvEmpleados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EMPELADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_COMPLETO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_HABER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_ASIGNADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INGRESO As DevExpress.XtraGrid.Columns.GridColumn
End Class
