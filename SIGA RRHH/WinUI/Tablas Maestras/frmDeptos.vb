Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmDeptos
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
    Friend WithEvents gdcDeptos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gdvDetalleDeptos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ORGANIZACION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DEPTO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DEPTO_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIRECCION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JEFE_DEPTO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JEFE_SUBROG_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gleDireccion As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dvDireccion As System.Data.DataView
    Friend WithEvents txtDescripcionDepto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents dvJefe As System.Data.DataView
    Friend WithEvents gleJefe As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dvSubrrogante As System.Data.DataView
    Friend WithEvents gleSubrrogante As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents AUTORIZADOR_HORAS_EXTRAS_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gleAutorizadorHrsExtras As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gleEvaluadorDesempeno As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EVALUADOR_DESEMPENO_ID As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeptos))
        Me.gdcDeptos = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleDeptos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ORGANIZACION_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DEPTO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DEPTO_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescripcionDepto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DIRECCION_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleDireccion = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.JEFE_DEPTO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleJefe = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.JEFE_SUBROG_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleSubrrogante = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.AUTORIZADOR_HORAS_EXTRAS_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleAutorizadorHrsExtras = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.EVALUADOR_DESEMPENO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleEvaluadorDesempeno = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dvDireccion = New System.Data.DataView()
        Me.dvJefe = New System.Data.DataView()
        Me.dvSubrrogante = New System.Data.DataView()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.gdcDeptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleDeptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionDepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleJefe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleSubrrogante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleAutorizadorHrsExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleEvaluadorDesempeno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvJefe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvSubrrogante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcDeptos
        '
        Me.gdcDeptos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcDeptos.Location = New System.Drawing.Point(16, 56)
        Me.gdcDeptos.MainView = Me.gdvDetalleDeptos
        Me.gdcDeptos.Name = "gdcDeptos"
        Me.gdcDeptos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.gleDireccion, Me.txtDescripcionDepto, Me.gleJefe, Me.gleSubrrogante, Me.gleAutorizadorHrsExtras, Me.gleEvaluadorDesempeno})
        Me.gdcDeptos.Size = New System.Drawing.Size(824, 360)
        Me.gdcDeptos.TabIndex = 0
        Me.gdcDeptos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleDeptos, Me.GridView1})
        '
        'gdvDetalleDeptos
        '
        Me.gdvDetalleDeptos.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.ColumnFilterButtonActive.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.ColumnFilterButtonActive.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.DetailTip.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.DetailTip.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.Empty.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.Empty.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.EvenRow.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.FilterCloseButton.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.FilterCloseButton.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.FilterPanel.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.FilterPanel.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.FixedLine.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.FixedLine.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.FocusedCell.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.FocusedRow.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.FooterPanel.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.FooterPanel.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.GroupButton.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.GroupButton.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.GroupFooter.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.GroupFooter.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.GroupPanel.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.GroupPanel.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.GroupRow.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.GroupRow.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.HeaderPanel.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.HideSelectionRow.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.HorzLine.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.HorzLine.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.OddRow.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.Preview.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.Preview.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.Row.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.Row.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.RowSeparator.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.RowSeparator.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.SelectedRow.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.SelectedRow.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.TopNewRow.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.TopNewRow.Options.UseFont = True
        Me.gdvDetalleDeptos.Appearance.VertLine.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleDeptos.Appearance.VertLine.Options.UseFont = True
        Me.gdvDetalleDeptos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ORGANIZACION_ID, Me.DEPTO_ID, Me.DEPTO_ALIAS, Me.DESCRIPCION, Me.DIRECCION_ID, Me.JEFE_DEPTO_ID, Me.JEFE_SUBROG_ID, Me.AUTORIZADOR_HORAS_EXTRAS_ID, Me.EVALUADOR_DESEMPENO_ID})
        Me.gdvDetalleDeptos.GridControl = Me.gdcDeptos
        Me.gdvDetalleDeptos.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvDetalleDeptos.Name = "gdvDetalleDeptos"
        Me.gdvDetalleDeptos.NewItemRowText = "Nuevo Registro"
        Me.gdvDetalleDeptos.OptionsNavigation.EnterMoveNextColumn = True
        Me.gdvDetalleDeptos.OptionsView.ColumnAutoWidth = False
        Me.gdvDetalleDeptos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'ORGANIZACION_ID
        '
        Me.ORGANIZACION_ID.Caption = "Id Organizacion"
        Me.ORGANIZACION_ID.FieldName = "ORGANIZACION_ID"
        Me.ORGANIZACION_ID.Name = "ORGANIZACION_ID"
        '
        'DEPTO_ID
        '
        Me.DEPTO_ID.Caption = "ID Depto."
        Me.DEPTO_ID.FieldName = "DEPTO_ID"
        Me.DEPTO_ID.Name = "DEPTO_ID"
        '
        'DEPTO_ALIAS
        '
        Me.DEPTO_ALIAS.Caption = "Alias Depto."
        Me.DEPTO_ALIAS.FieldName = "DEPTO_ALIAS"
        Me.DEPTO_ALIAS.Name = "DEPTO_ALIAS"
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.Caption = "Descripción"
        Me.DESCRIPCION.ColumnEdit = Me.txtDescripcionDepto
        Me.DESCRIPCION.FieldName = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.DESCRIPCION.Visible = True
        Me.DESCRIPCION.VisibleIndex = 0
        Me.DESCRIPCION.Width = 249
        '
        'txtDescripcionDepto
        '
        Me.txtDescripcionDepto.AutoHeight = False
        Me.txtDescripcionDepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionDepto.Name = "txtDescripcionDepto"
        '
        'DIRECCION_ID
        '
        Me.DIRECCION_ID.Caption = "Dirección"
        Me.DIRECCION_ID.ColumnEdit = Me.gleDireccion
        Me.DIRECCION_ID.FieldName = "DIRECCION_ID"
        Me.DIRECCION_ID.Name = "DIRECCION_ID"
        Me.DIRECCION_ID.Visible = True
        Me.DIRECCION_ID.VisibleIndex = 1
        Me.DIRECCION_ID.Width = 224
        '
        'gleDireccion
        '
        Me.gleDireccion.AutoHeight = False
        Me.gleDireccion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleDireccion.Name = "gleDireccion"
        Me.gleDireccion.NullText = ""
        Me.gleDireccion.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'JEFE_DEPTO_ID
        '
        Me.JEFE_DEPTO_ID.Caption = "Jefe Depto."
        Me.JEFE_DEPTO_ID.ColumnEdit = Me.gleJefe
        Me.JEFE_DEPTO_ID.FieldName = "JEFE_DEPTO_ID"
        Me.JEFE_DEPTO_ID.Name = "JEFE_DEPTO_ID"
        Me.JEFE_DEPTO_ID.Visible = True
        Me.JEFE_DEPTO_ID.VisibleIndex = 2
        Me.JEFE_DEPTO_ID.Width = 260
        '
        'gleJefe
        '
        Me.gleJefe.AutoHeight = False
        Me.gleJefe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleJefe.Name = "gleJefe"
        Me.gleJefe.NullText = ""
        Me.gleJefe.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'JEFE_SUBROG_ID
        '
        Me.JEFE_SUBROG_ID.Caption = "Jefe Subrogante"
        Me.JEFE_SUBROG_ID.ColumnEdit = Me.gleSubrrogante
        Me.JEFE_SUBROG_ID.FieldName = "JEFE_SUBROG_ID"
        Me.JEFE_SUBROG_ID.Name = "JEFE_SUBROG_ID"
        Me.JEFE_SUBROG_ID.Visible = True
        Me.JEFE_SUBROG_ID.VisibleIndex = 3
        Me.JEFE_SUBROG_ID.Width = 247
        '
        'gleSubrrogante
        '
        Me.gleSubrrogante.AutoHeight = False
        Me.gleSubrrogante.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleSubrrogante.Name = "gleSubrrogante"
        Me.gleSubrrogante.NullText = ""
        Me.gleSubrrogante.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'AUTORIZADOR_HORAS_EXTRAS_ID
        '
        Me.AUTORIZADOR_HORAS_EXTRAS_ID.Caption = "Autorizador Horas Extras"
        Me.AUTORIZADOR_HORAS_EXTRAS_ID.ColumnEdit = Me.gleAutorizadorHrsExtras
        Me.AUTORIZADOR_HORAS_EXTRAS_ID.FieldName = "AUTORIZADOR_HORAS_EXTRAS_ID"
        Me.AUTORIZADOR_HORAS_EXTRAS_ID.Name = "AUTORIZADOR_HORAS_EXTRAS_ID"
        Me.AUTORIZADOR_HORAS_EXTRAS_ID.OptionsColumn.AllowEdit = False
        Me.AUTORIZADOR_HORAS_EXTRAS_ID.OptionsColumn.ReadOnly = True
        Me.AUTORIZADOR_HORAS_EXTRAS_ID.Width = 247
        '
        'gleAutorizadorHrsExtras
        '
        Me.gleAutorizadorHrsExtras.AutoHeight = False
        Me.gleAutorizadorHrsExtras.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleAutorizadorHrsExtras.Name = "gleAutorizadorHrsExtras"
        Me.gleAutorizadorHrsExtras.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'EVALUADOR_DESEMPENO_ID
        '
        Me.EVALUADOR_DESEMPENO_ID.Caption = "Evaluador Desempeño"
        Me.EVALUADOR_DESEMPENO_ID.ColumnEdit = Me.gleEvaluadorDesempeno
        Me.EVALUADOR_DESEMPENO_ID.FieldName = "EVALUADOR_DESEMPENO_ID"
        Me.EVALUADOR_DESEMPENO_ID.Name = "EVALUADOR_DESEMPENO_ID"
        Me.EVALUADOR_DESEMPENO_ID.OptionsColumn.AllowEdit = False
        Me.EVALUADOR_DESEMPENO_ID.OptionsColumn.ReadOnly = True
        Me.EVALUADOR_DESEMPENO_ID.Width = 229
        '
        'gleEvaluadorDesempeno
        '
        Me.gleEvaluadorDesempeno.AutoHeight = False
        Me.gleEvaluadorDesempeno.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleEvaluadorDesempeno.Name = "gleEvaluadorDesempeno"
        Me.gleEvaluadorDesempeno.View = Me.GridView5
        '
        'GridView5
        '
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcDeptos
        Me.GridView1.Name = "GridView1"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Location = New System.Drawing.Point(736, 8)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(96, 32)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir Reporte"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcDeptos
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(10, 10, 100, 100)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de La República", "Departamentos", "[Date Printed]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Sistema Integral de Gestión Administrativa (SIGA)", "", "Página Número [Page #]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'frmDeptos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 453)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.gdcDeptos)
        Me.Name = "frmDeptos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Departamento"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcDeptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleDeptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionDepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleJefe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleSubrrogante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleAutorizadorHrsExtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleEvaluadorDesempeno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvJefe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvSubrrogante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim depto As Mantenedor
    Private Sub frmDeptos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        depto = New Mantenedor
        repositorio.RefreshDatos("Empleado")
        repositorio.RefreshDatos("Direccion")
        'GeneraDataViews()
        llenarDireccion()
        llenarJefe()
        llenarSubrrogante()
        llenarAutorizadorHrsExtras()
        llenarEvaluadorDesempeno()
        gdcDeptos.DataSource = depto.recuperarDepartamentos
    End Sub

    Private Sub gdvDetalleDeptos_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvDetalleDeptos.RowUpdated
        If depto.actualizarDatosDeptos() Then
            gdcDeptos.Refresh()
            repositorio.RefreshDatos("ClasificacionEmpleado")
            repositorio.RefreshDatos("Departamentos")
            repositorio.RefreshDatos("Direccion")
            repositorio.RefreshDatos("JefeDepartamento")
        End If
    End Sub

    Private Sub gdvDetalleDeptos_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvDetalleDeptos.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gdvDetalleDeptos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvDetalleDeptos.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                Try
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                    view.DeleteRow(view.FocusedRowHandle)
                    depto.actualizarDatosDeptos()
                    gdcDeptos.Refresh()
                    MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)

                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al intentar eliminar el registro " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
            gdcDeptos.DataSource = depto.recuperarDepartamentos
        End If
    End Sub

    Private Sub gdvDetalleDeptos_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvDetalleDeptos.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        view.SetRowCellValue(e.RowHandle, "ORGANIZACION_ID", Comun.ArgoConfiguracion.OrganizacionID)
    End Sub
    Public Sub llenarDireccion()
        gleDireccion.ViewType = Repository.GridLookUpViewType.GridView
        gleDireccion.View.OptionsBehavior.AutoPopulateColumns = False
        gleDireccion.DataSource = repositorio.dvDireccion
        gleDireccion.DisplayMember = "DESCRIPCION"

        Dim col1 As GridColumn = gleDireccion.View.Columns.AddField("DIRECCION_ID")
        col1.VisibleIndex = 0
        col1.Caption = "ID Dirección"
        col1.Visible = False

        Dim col2 As GridColumn = gleDireccion.View.Columns.AddField("DESCRIPCION")
        col2.VisibleIndex = 1
        col2.Caption = "Dirección"

        gleDireccion.ValueMember = "DIRECCION_ID"
        gleDireccion.View.BestFitColumns()
        gleDireccion.PopupFormWidth = 250
    End Sub
    Public Sub llenarJefe()
        gleJefe.ViewType = Repository.GridLookUpViewType.GridView
        gleJefe.View.OptionsBehavior.AutoPopulateColumns = False
        repositorio.dvEmpleados.Sort = "NOMBRE_COMPLETO_EMPLEADO"
        gleJefe.DataSource = repositorio.dvEmpleados
        gleJefe.DisplayMember = "NOMBRE_COMPLETO_EMPLEADO"

        Dim col1 As GridColumn = gleJefe.View.Columns.AddField("EMPLEADO_ID")
        col1.VisibleIndex = 0
        col1.Caption = "EMPLEADO_ID"
        col1.Visible = False

        Dim col3 As GridColumn = gleJefe.View.Columns.AddField("NOMBRE_COMPLETO_EMPLEADO")
        col3.VisibleIndex = 1
        col3.Caption = "Nombre Empleado"

        gleJefe.ValueMember = "EMPLEADO_ID"
        gleJefe.View.BestFitColumns()
        gleJefe.PopupFormWidth = 250
    End Sub

    Public Sub llenarSubrrogante()
        gleSubrrogante.ViewType = Repository.GridLookUpViewType.GridView
        gleSubrrogante.View.OptionsBehavior.AutoPopulateColumns = False
        repositorio.dvEmpleados.Sort = "NOMBRE_COMPLETO_EMPLEADO"
        gleSubrrogante.DataSource = repositorio.dvEmpleados

        gleSubrrogante.DisplayMember = "NOMBRE_COMPLETO_EMPLEADO"

        Dim col1 As GridColumn = gleSubrrogante.View.Columns.AddField("EMPLEADO_ID")
        col1.VisibleIndex = 0
        col1.Caption = "EMPLEADO_ID"
        col1.Visible = False

        Dim col3 As GridColumn = gleSubrrogante.View.Columns.AddField("NOMBRE_COMPLETO_EMPLEADO")
        col3.VisibleIndex = 1
        col3.Caption = "Nombre Empleado"

        gleSubrrogante.ValueMember = "EMPLEADO_ID"
        gleSubrrogante.View.BestFitColumns()
        gleSubrrogante.PopupFormWidth = 250
    End Sub
    Public Sub llenarEvaluadorDesempeno()
        gleEvaluadorDesempeno.ViewType = Repository.GridLookUpViewType.GridView
        gleEvaluadorDesempeno.View.OptionsBehavior.AutoPopulateColumns = False
        repositorio.dvEmpleados.Sort = "NOMBRE_COMPLETO_EMPLEADO"
        gleEvaluadorDesempeno.DataSource = repositorio.dvEmpleados

        gleEvaluadorDesempeno.DisplayMember = "NOMBRE_COMPLETO_EMPLEADO"

        Dim col1 As GridColumn = gleEvaluadorDesempeno.View.Columns.AddField("EMPLEADO_ID")
        col1.VisibleIndex = 0
        col1.Caption = "EMPLEADO_ID"
        col1.Visible = False

        Dim col3 As GridColumn = gleEvaluadorDesempeno.View.Columns.AddField("NOMBRE_COMPLETO_EMPLEADO")
        col3.VisibleIndex = 1
        col3.Caption = "Nombre Empleado"

        gleEvaluadorDesempeno.ValueMember = "EMPLEADO_ID"
        gleEvaluadorDesempeno.View.BestFitColumns()
        gleEvaluadorDesempeno.PopupFormWidth = 250
    End Sub
    Public Sub llenarAutorizadorHrsExtras()
        gleAutorizadorHrsExtras.ViewType = Repository.GridLookUpViewType.GridView
        gleAutorizadorHrsExtras.View.OptionsBehavior.AutoPopulateColumns = False
        repositorio.dvEmpleados.Sort = "NOMBRE_COMPLETO_EMPLEADO"
        gleAutorizadorHrsExtras.DataSource = repositorio.dvEmpleados

        gleAutorizadorHrsExtras.DisplayMember = "NOMBRE_COMPLETO_EMPLEADO"

        Dim col1 As GridColumn = gleAutorizadorHrsExtras.View.Columns.AddField("EMPLEADO_ID")
        col1.VisibleIndex = 0
        col1.Caption = "EMPLEADO_ID"
        col1.Visible = False

        Dim col3 As GridColumn = gleAutorizadorHrsExtras.View.Columns.AddField("NOMBRE_COMPLETO_EMPLEADO")
        col3.VisibleIndex = 1
        col3.Caption = "Nombre Empleado"

        gleAutorizadorHrsExtras.ValueMember = "EMPLEADO_ID"
        gleAutorizadorHrsExtras.View.BestFitColumns()
        gleAutorizadorHrsExtras.PopupFormWidth = 250
    End Sub
    Private Sub GeneraDataViews()
        Dim da As SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString

        Dim ds1 As New DataSet

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_DIRECCION, conn))
        da.Fill(ds1, Tablas.RH_PER_DIRECCION)
        Dim dvmDireccion As New DataViewManager(ds1)
        dvDireccion = dvmDireccion.CreateDataView(ds1.Tables(Tablas.RH_PER_DIRECCION))

    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = ""
        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 14, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
    End Sub


    Private Sub gdvDetalleDeptos_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gdvDetalleDeptos.ValidateRow
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        Dim IDmovto As Integer = view.GetRowCellValue(view.FocusedRowHandle, view.Columns(0))

    End Sub
End Class
