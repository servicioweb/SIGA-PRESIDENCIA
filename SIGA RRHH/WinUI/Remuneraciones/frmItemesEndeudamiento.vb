Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmItemesEndeudamiento
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
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gdcItemEndeudamiento As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvItemEndeudamiento As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colITEM_ENDEUDAMIENTO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colITEM_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colITEM_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION_ITEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gpcDatosMovimiento As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gleItems As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents glvItems As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ITEM_ID_GV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ITEM_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION_LARGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TIPO_ITEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblTipoAgrupacion As System.Windows.Forms.Label
    Friend WithEvents lueAgrupacion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents colTIPO_ITEM_ENDEUDAMIENTO_ID As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton
        Me.gdcItemEndeudamiento = New DevExpress.XtraGrid.GridControl
        Me.gdvItemEndeudamiento = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colITEM_ENDEUDAMIENTO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colITEM_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDESCRIPCION_ITEM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colITEM_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gpcDatosMovimiento = New DevExpress.XtraEditors.GroupControl
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.lueAgrupacion = New DevExpress.XtraEditors.LookUpEdit
        Me.gleItems = New DevExpress.XtraEditors.GridLookUpEdit
        Me.glvItems = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ITEM_ID_GV = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ITEM_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DESCRIPCION_LARGA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TIPO_ITEM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.lblTipoAgrupacion = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.colTIPO_ITEM_ENDEUDAMIENTO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.gdcItemEndeudamiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvItemEndeudamiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDatosMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDatosMovimiento.SuspendLayout()
        CType(Me.lueAgrupacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleItems.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(224, 72)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(96, 23)
        Me.btnExportar.TabIndex = 6
        Me.btnExportar.Text = "Exoportar Excel"
        '
        'gdcItemEndeudamiento
        '
        Me.gdcItemEndeudamiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'gdcItemEndeudamiento.EmbeddedNavigator
        '
        Me.gdcItemEndeudamiento.EmbeddedNavigator.Name = ""
        Me.gdcItemEndeudamiento.Location = New System.Drawing.Point(8, 120)
        Me.gdcItemEndeudamiento.MainView = Me.gdvItemEndeudamiento
        Me.gdcItemEndeudamiento.Name = "gdcItemEndeudamiento"
        Me.gdcItemEndeudamiento.Size = New System.Drawing.Size(736, 200)
        Me.gdcItemEndeudamiento.TabIndex = 10
        Me.gdcItemEndeudamiento.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvItemEndeudamiento})
        '
        'gdvItemEndeudamiento
        '
        Me.gdvItemEndeudamiento.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colITEM_ENDEUDAMIENTO_ID, Me.colITEM_ID, Me.colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO, Me.colDESCRIPCION_ITEM, Me.colITEM_ALIAS, Me.colTIPO_ITEM_ENDEUDAMIENTO_ID})
        Me.gdvItemEndeudamiento.GridControl = Me.gdcItemEndeudamiento
        Me.gdvItemEndeudamiento.Name = "gdvItemEndeudamiento"
        Me.gdvItemEndeudamiento.OptionsView.ShowGroupPanel = False
        '
        'colITEM_ENDEUDAMIENTO_ID
        '
        Me.colITEM_ENDEUDAMIENTO_ID.Caption = "Id Endeudamiento"
        Me.colITEM_ENDEUDAMIENTO_ID.FieldName = "ITEM_ENDEUDAMIENTO_ID"
        Me.colITEM_ENDEUDAMIENTO_ID.Name = "colITEM_ENDEUDAMIENTO_ID"
        Me.colITEM_ENDEUDAMIENTO_ID.OptionsColumn.AllowEdit = False
        Me.colITEM_ENDEUDAMIENTO_ID.OptionsColumn.ReadOnly = True
        '
        'colITEM_ID
        '
        Me.colITEM_ID.Caption = "Item"
        Me.colITEM_ID.FieldName = "ITEM_ID"
        Me.colITEM_ID.Name = "colITEM_ID"
        Me.colITEM_ID.OptionsColumn.AllowEdit = False
        Me.colITEM_ID.OptionsColumn.ReadOnly = True
        '
        'colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO
        '
        Me.colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO.Caption = "Tipo Agrupación"
        Me.colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO.FieldName = "DESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO"
        Me.colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO.Name = "colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO"
        Me.colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO.OptionsColumn.AllowEdit = False
        Me.colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO.OptionsColumn.ReadOnly = True
        Me.colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO.Visible = True
        Me.colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO.VisibleIndex = 0
        Me.colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO.Width = 182
        '
        'colDESCRIPCION_ITEM
        '
        Me.colDESCRIPCION_ITEM.Caption = "Descripción Item"
        Me.colDESCRIPCION_ITEM.FieldName = "DESCRIPCION_ITEM"
        Me.colDESCRIPCION_ITEM.Name = "colDESCRIPCION_ITEM"
        Me.colDESCRIPCION_ITEM.OptionsColumn.AllowEdit = False
        Me.colDESCRIPCION_ITEM.OptionsColumn.ReadOnly = True
        Me.colDESCRIPCION_ITEM.Visible = True
        Me.colDESCRIPCION_ITEM.VisibleIndex = 1
        Me.colDESCRIPCION_ITEM.Width = 495
        '
        'colITEM_ALIAS
        '
        Me.colITEM_ALIAS.Caption = "Código"
        Me.colITEM_ALIAS.FieldName = "ITEM_ALIAS"
        Me.colITEM_ALIAS.Name = "colITEM_ALIAS"
        Me.colITEM_ALIAS.OptionsColumn.AllowEdit = False
        Me.colITEM_ALIAS.OptionsColumn.ReadOnly = True
        Me.colITEM_ALIAS.Visible = True
        Me.colITEM_ALIAS.VisibleIndex = 2
        Me.colITEM_ALIAS.Width = 497
        '
        'gpcDatosMovimiento
        '
        Me.gpcDatosMovimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcDatosMovimiento.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDatosMovimiento.AppearanceCaption.Options.UseFont = True
        Me.gpcDatosMovimiento.Controls.Add(Me.btnGuardar)
        Me.gpcDatosMovimiento.Controls.Add(Me.lueAgrupacion)
        Me.gpcDatosMovimiento.Controls.Add(Me.gleItems)
        Me.gpcDatosMovimiento.Controls.Add(Me.btnNuevo)
        Me.gpcDatosMovimiento.Controls.Add(Me.lblTipoAgrupacion)
        Me.gpcDatosMovimiento.Controls.Add(Me.Label1)
        Me.gpcDatosMovimiento.Controls.Add(Me.btnExportar)
        Me.gpcDatosMovimiento.Location = New System.Drawing.Point(8, 0)
        Me.gpcDatosMovimiento.Name = "gpcDatosMovimiento"
        Me.gpcDatosMovimiento.Size = New System.Drawing.Size(736, 120)
        Me.gpcDatosMovimiento.TabIndex = 8
        Me.gpcDatosMovimiento.Text = "Datos de Movimiento"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(120, 72)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(96, 23)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        '
        'lueAgrupacion
        '
        Me.lueAgrupacion.EditValue = -1
        Me.lueAgrupacion.EnterMoveNextControl = True
        Me.lueAgrupacion.Location = New System.Drawing.Point(360, 40)
        Me.lueAgrupacion.Name = "lueAgrupacion"
        '
        'lueAgrupacion.Properties
        '
        Me.lueAgrupacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAgrupacion.Properties.NullText = ""
        Me.lueAgrupacion.Size = New System.Drawing.Size(144, 20)
        Me.lueAgrupacion.TabIndex = 1
        '
        'gleItems
        '
        Me.gleItems.EditValue = -1
        Me.gleItems.EnterMoveNextControl = True
        Me.gleItems.Location = New System.Drawing.Point(16, 40)
        Me.gleItems.Name = "gleItems"
        '
        'gleItems.Properties
        '
        Me.gleItems.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleItems.Properties.NullText = ""
        Me.gleItems.Properties.PopupFormWidth = 470
        Me.gleItems.Properties.View = Me.glvItems
        Me.gleItems.Size = New System.Drawing.Size(336, 20)
        Me.gleItems.TabIndex = 0
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
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(16, 72)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(96, 23)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        '
        'lblTipoAgrupacion
        '
        Me.lblTipoAgrupacion.Location = New System.Drawing.Point(360, 24)
        Me.lblTipoAgrupacion.Name = "lblTipoAgrupacion"
        Me.lblTipoAgrupacion.Size = New System.Drawing.Size(88, 16)
        Me.lblTipoAgrupacion.TabIndex = 4
        Me.lblTipoAgrupacion.Text = "Agrupación"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ítem"
        '
        'colTIPO_ITEM_ENDEUDAMIENTO_ID
        '
        Me.colTIPO_ITEM_ENDEUDAMIENTO_ID.Caption = "Tipo Item"
        Me.colTIPO_ITEM_ENDEUDAMIENTO_ID.FieldName = "TIPO_ITEM_ENDEUDAMIENTO_ID"
        Me.colTIPO_ITEM_ENDEUDAMIENTO_ID.Name = "colTIPO_ITEM_ENDEUDAMIENTO_ID"
        Me.colTIPO_ITEM_ENDEUDAMIENTO_ID.OptionsColumn.AllowEdit = False
        Me.colTIPO_ITEM_ENDEUDAMIENTO_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Me.colTIPO_ITEM_ENDEUDAMIENTO_ID.OptionsColumn.ShowCaption = False
        '
        'frmItemesEndeudamiento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(752, 322)
        Me.Controls.Add(Me.gpcDatosMovimiento)
        Me.Controls.Add(Me.gdcItemEndeudamiento)
        Me.Name = "frmItemesEndeudamiento"
        Me.Text = "frmItemesEndeudamiento"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcItemEndeudamiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvItemEndeudamiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDatosMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatosMovimiento.ResumeLayout(False)
        CType(Me.lueAgrupacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleItems.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim connectionString As String = Comun.ArgoConfiguracion.ConnectionString
    Dim item As item

    Private Sub frmItemesEndeudamiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        item = New item
        repositorio.RefreshDatos("Item")
        llenarItems()
        llenarAgrupacion()
        gleItems.EditValue = -1
        lueAgrupacion.EditValue = -1
        llenarGrilla()
    End Sub

    Private Sub llenarItems()
        gleItems.Properties.DataSource = repositorio.dvItem
        gleItems.Properties.DisplayMember = "DESCRIPCION_LARGA"
        gleItems.Properties.ValueMember = "ITEM_ID"
        gleItems.Properties.View.BestFitColumns()
        gleItems.Properties.PopupFormWidth = 560
        gleItems.EditValue = -1
    End Sub

    Private Sub llenarAgrupacion()
        With lueAgrupacion
            With .Properties.Columns
                .Add(New LookUpColumnInfo("TIPO_ITEM_ENDEUDAMIENTO_ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO", "Descripción", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueAgrupacion.Properties.DataSource = repositorio.dvTipoItemEndeudamiento
        lueAgrupacion.Properties.DisplayMember = "DESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO"
        lueAgrupacion.Properties.NullText = ""
        lueAgrupacion.Properties.PopupWidth = 200
        lueAgrupacion.Properties.ValueMember = "TIPO_ITEM_ENDEUDAMIENTO_ID"
    End Sub

    Private Sub llenarGrilla()
        gdcItemEndeudamiento.DataSource = item.recuperaDetalleItemEndeudamiento
        If gdvItemEndeudamiento.RowCount <= 0 Then
            btnExportar.Enabled = False
        Else
            btnExportar.Enabled = True
        End If
        btnGuardar.Enabled = False
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        gleItems.EditValue = -1
        lueAgrupacion.EditValue = -1
    End Sub

    Private Sub gleItems_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gleItems.EditValueChanged, lueAgrupacion.EditValueChanged
        If gleItems.EditValue = Nothing Then 'Or lueAgrupacion.EditValue = Nothing Then
            btnGuardar.Enabled = False
            Exit Sub
        End If
        If gleItems.EditValue < 0 Or lueAgrupacion.EditValue < 0 Then
            btnGuardar.Enabled = False
        Else
            btnGuardar.Enabled = True
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        item.ActualizarItemEndeudamiento(gleItems.EditValue, lueAgrupacion.EditValue, True)
        llenarGrilla()
    End Sub

    Private Sub gdvItemEndeudamiento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvItemEndeudamiento.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
                Dim ItemId As Integer = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("ITEM_ID"))
                Dim TipoItemId As Integer = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("TIPO_ITEM_ENDEUDAMIENTO_ID"))
                item.ActualizarItemEndeudamiento(ItemId, TipoItemId, False)
                llenarGrilla()
            End If
        End If
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim rutaPlanillaExcel As String
        Try
            With SaveFileDialog1
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = SaveFileDialog1.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                gdcItemEndeudamiento.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
