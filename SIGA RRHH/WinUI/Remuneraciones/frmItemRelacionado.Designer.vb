<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemRelacionado
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
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAsignarHaberDescuentoAItem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.gleHaberDescuento = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemAlias = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcionLarga = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEsCalculable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleItems = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.glvItems = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ITEM_ID_GV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ITEM_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION_LARGA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TIPO_ITEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.gdcDetalle = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRELACION_CABECERA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colITEM_ID_RELACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colITEM_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colITEM_ID_CABECERA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRELACION_DETALLE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colITEM_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleItemes = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcEncabezado.SuspendLayout()
        CType(Me.gleHaberDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleItems.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleItemes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcEncabezado
        '
        Me.gpcEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcEncabezado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcEncabezado.AppearanceCaption.Options.UseFont = True
        Me.gpcEncabezado.Controls.Add(Me.btnCancelar)
        Me.gpcEncabezado.Controls.Add(Me.btnAsignarHaberDescuentoAItem)
        Me.gpcEncabezado.Controls.Add(Me.btnNuevo)
        Me.gpcEncabezado.Controls.Add(Me.LabelControl1)
        Me.gpcEncabezado.Controls.Add(Me.gleHaberDescuento)
        Me.gpcEncabezado.Controls.Add(Me.gleItems)
        Me.gpcEncabezado.Controls.Add(Me.lblItem)
        Me.gpcEncabezado.Location = New System.Drawing.Point(3, 3)
        Me.gpcEncabezado.Name = "gpcEncabezado"
        Me.gpcEncabezado.Size = New System.Drawing.Size(696, 124)
        Me.gpcEncabezado.TabIndex = 1
        Me.gpcEncabezado.Text = "Ítem"
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(211, 81)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAsignarHaberDescuentoAItem
        '
        Me.btnAsignarHaberDescuentoAItem.Enabled = False
        Me.btnAsignarHaberDescuentoAItem.Location = New System.Drawing.Point(357, 81)
        Me.btnAsignarHaberDescuentoAItem.Name = "btnAsignarHaberDescuentoAItem"
        Me.btnAsignarHaberDescuentoAItem.Size = New System.Drawing.Size(75, 23)
        Me.btnAsignarHaberDescuentoAItem.TabIndex = 5
        Me.btnAsignarHaberDescuentoAItem.Text = "Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(72, 81)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(412, 37)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Haber - Descuento"
        '
        'gleHaberDescuento
        '
        Me.gleHaberDescuento.Enabled = False
        Me.gleHaberDescuento.Location = New System.Drawing.Point(508, 34)
        Me.gleHaberDescuento.Name = "gleHaberDescuento"
        Me.gleHaberDescuento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleHaberDescuento.Properties.View = Me.GridLookUpEdit1View
        Me.gleHaberDescuento.Size = New System.Drawing.Size(181, 20)
        Me.gleHaberDescuento.TabIndex = 2
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemID, Me.colItemAlias, Me.colDescripcionLarga, Me.colEsCalculable})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colItemID
        '
        Me.colItemID.Caption = "Item ID"
        Me.colItemID.FieldName = "ITEM_ID"
        Me.colItemID.Name = "colItemID"
        Me.colItemID.OptionsColumn.ReadOnly = True
        '
        'colItemAlias
        '
        Me.colItemAlias.Caption = "Item Alias"
        Me.colItemAlias.FieldName = "ITEM_ALIAS"
        Me.colItemAlias.Name = "colItemAlias"
        Me.colItemAlias.OptionsColumn.ReadOnly = True
        Me.colItemAlias.Visible = True
        Me.colItemAlias.VisibleIndex = 0
        '
        'colDescripcionLarga
        '
        Me.colDescripcionLarga.Caption = "Descripcion Larga"
        Me.colDescripcionLarga.FieldName = "DESCRIPCION_LARGA"
        Me.colDescripcionLarga.Name = "colDescripcionLarga"
        Me.colDescripcionLarga.OptionsColumn.ReadOnly = True
        Me.colDescripcionLarga.Visible = True
        Me.colDescripcionLarga.VisibleIndex = 1
        '
        'colEsCalculable
        '
        Me.colEsCalculable.Caption = "Es Calculable"
        Me.colEsCalculable.FieldName = "ES_CALCULABLE"
        Me.colEsCalculable.Name = "colEsCalculable"
        Me.colEsCalculable.OptionsColumn.ReadOnly = True
        '
        'gleItems
        '
        Me.gleItems.EditValue = ""
        Me.gleItems.Location = New System.Drawing.Point(49, 34)
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
        Me.lblItem.Location = New System.Drawing.Point(9, 37)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(34, 17)
        Me.lblItem.TabIndex = 1
        Me.lblItem.Text = "Item"
        Me.lblItem.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gdcDetalle
        '
        Me.gdcDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcDetalle.Location = New System.Drawing.Point(3, 133)
        Me.gdcDetalle.MainView = Me.gdvDetalle
        Me.gdcDetalle.Name = "gdcDetalle"
        Me.gdcDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.gleItemes})
        Me.gdcDetalle.Size = New System.Drawing.Size(696, 409)
        Me.gdcDetalle.TabIndex = 2
        Me.gdcDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalle})
        '
        'gdvDetalle
        '
        Me.gdvDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRELACION_CABECERA_ID, Me.colITEM_ID_RELACION, Me.colITEM_ALIAS, Me.colDESCRIPCION, Me.colITEM_ID_CABECERA, Me.colRELACION_DETALLE_ID, Me.colITEM_ID})
        Me.gdvDetalle.GridControl = Me.gdcDetalle
        Me.gdvDetalle.Name = "gdvDetalle"
        Me.gdvDetalle.NewItemRowText = "Nuevo Registro"
        Me.gdvDetalle.OptionsNavigation.EnterMoveNextColumn = True
        Me.gdvDetalle.OptionsView.ShowGroupPanel = False
        '
        'colRELACION_CABECERA_ID
        '
        Me.colRELACION_CABECERA_ID.Caption = "Id Cabecera"
        Me.colRELACION_CABECERA_ID.FieldName = "RELACION_CABECERA_ID"
        Me.colRELACION_CABECERA_ID.Name = "colRELACION_CABECERA_ID"
        Me.colRELACION_CABECERA_ID.OptionsColumn.AllowEdit = False
        Me.colRELACION_CABECERA_ID.OptionsColumn.AllowMove = False
        Me.colRELACION_CABECERA_ID.OptionsColumn.ReadOnly = True
        '
        'colITEM_ID_RELACION
        '
        Me.colITEM_ID_RELACION.Caption = "Item"
        Me.colITEM_ID_RELACION.FieldName = "DESCRIPCION_LARGA"
        Me.colITEM_ID_RELACION.Name = "colITEM_ID_RELACION"
        Me.colITEM_ID_RELACION.OptionsColumn.AllowEdit = False
        Me.colITEM_ID_RELACION.OptionsColumn.AllowMove = False
        Me.colITEM_ID_RELACION.Visible = True
        Me.colITEM_ID_RELACION.VisibleIndex = 0
        Me.colITEM_ID_RELACION.Width = 500
        '
        'colITEM_ALIAS
        '
        Me.colITEM_ALIAS.Caption = "Código"
        Me.colITEM_ALIAS.FieldName = "ITEM_ALIAS"
        Me.colITEM_ALIAS.Name = "colITEM_ALIAS"
        Me.colITEM_ALIAS.OptionsColumn.AllowEdit = False
        Me.colITEM_ALIAS.OptionsColumn.AllowMove = False
        Me.colITEM_ALIAS.OptionsColumn.ReadOnly = True
        Me.colITEM_ALIAS.Visible = True
        Me.colITEM_ALIAS.VisibleIndex = 1
        Me.colITEM_ALIAS.Width = 87
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "Tipo Item"
        Me.colDESCRIPCION.FieldName = "TIPO_ITEM"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.OptionsColumn.AllowEdit = False
        Me.colDESCRIPCION.OptionsColumn.AllowMove = False
        Me.colDESCRIPCION.OptionsColumn.ReadOnly = True
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 2
        Me.colDESCRIPCION.Width = 88
        '
        'colITEM_ID_CABECERA
        '
        Me.colITEM_ID_CABECERA.Caption = "Id Item Cabecera"
        Me.colITEM_ID_CABECERA.FieldName = "ITEM_ID_CABECERA"
        Me.colITEM_ID_CABECERA.Name = "colITEM_ID_CABECERA"
        '
        'colRELACION_DETALLE_ID
        '
        Me.colRELACION_DETALLE_ID.Caption = "Id Detalle"
        Me.colRELACION_DETALLE_ID.FieldName = "RELACION_DETALLE_ID"
        Me.colRELACION_DETALLE_ID.Name = "colRELACION_DETALLE_ID"
        '
        'colITEM_ID
        '
        Me.colITEM_ID.Caption = "Item ID"
        Me.colITEM_ID.FieldName = "ITEM_ID"
        Me.colITEM_ID.Name = "colITEM_ID"
        '
        'gleItemes
        '
        Me.gleItemes.AutoHeight = False
        Me.gleItemes.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleItemes.Name = "gleItemes"
        Me.gleItemes.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'frmItemRelacionado
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(704, 554)
        Me.Controls.Add(Me.gdcDetalle)
        Me.Controls.Add(Me.gpcEncabezado)
        Me.Name = "frmItemRelacionado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Relacionado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcEncabezado.ResumeLayout(False)
        Me.gpcEncabezado.PerformLayout()
        CType(Me.gleHaberDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleItems.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glvItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleItemes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpcEncabezado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gleItems As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents glvItems As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ITEM_ID_GV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ITEM_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION_LARGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TIPO_ITEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents gdcDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRELACION_CABECERA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colITEM_ID_RELACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colITEM_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gleItemes As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colITEM_ID_CABECERA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRELACION_DETALLE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gleHaberDescuento As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemAlias As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcionLarga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEsCalculable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAsignarHaberDescuentoAItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colITEM_ID As DevExpress.XtraGrid.Columns.GridColumn
End Class
