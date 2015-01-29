Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmEUS
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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblAno As System.Windows.Forms.Label
    Friend WithEvents dvPeriodo As System.Data.DataView
    Friend WithEvents gdcEUS As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalleEUS As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gpcPeriodo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents EUS_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ORGANIZACION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ESTADO_REGISTRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ANO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GRADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CALIDAD_JURIDICA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLASIFICACION_EMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ASIG_RESPONSABILIDAD_SUPERIOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ASIG_LEY19185_ART18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ASIG_LEY18717_CON_ASIG_PROFESIONAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ASIG_LEY18717_SIN_ASIG_PROFESIONAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BONO_LEY18675_ART10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BONO_LEY18675_ART11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BONO_LEY18566 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gleGrado As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents gleCalidadJuridica As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents gleClasificacionEmpleado As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents SUELDO_BASE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ASIG_PROFESIONAL_LEY19185_ART19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ASIG_LEY3551 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GASTO_REPRESENTACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gleAplicagtoRepre As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents APLICA_GASTO_REPRESENTACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents EUS_DETALLE_ID As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEUS))
        Me.gdcEUS = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleEUS = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.EUS_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ORGANIZACION_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ESTADO_REGISTRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ANO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GRADO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleGrado = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CALIDAD_JURIDICA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleCalidadJuridica = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CLASIFICACION_EMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleClasificacionEmpleado = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SUELDO_BASE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ASIG_PROFESIONAL_LEY19185_ART19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ASIG_RESPONSABILIDAD_SUPERIOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ASIG_LEY19185_ART18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ASIG_LEY18717_CON_ASIG_PROFESIONAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ASIG_LEY18717_SIN_ASIG_PROFESIONAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BONO_LEY18675_ART10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BONO_LEY18675_ART11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BONO_LEY18566 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ASIG_LEY3551 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.APLICA_GASTO_REPRESENTACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleAplicagtoRepre = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GASTO_REPRESENTACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EUS_DETALLE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gpcPeriodo = New DevExpress.XtraEditors.GroupControl()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.dvPeriodo = New System.Data.DataView()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.gdcEUS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleEUS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleGrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleCalidadJuridica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleClasificacionEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleAplicagtoRepre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcPeriodo.SuspendLayout()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcEUS
        '
        Me.gdcEUS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcEUS.Location = New System.Drawing.Point(16, 96)
        Me.gdcEUS.MainView = Me.gdvDetalleEUS
        Me.gdcEUS.Name = "gdcEUS"
        Me.gdcEUS.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.gleGrado, Me.gleCalidadJuridica, Me.gleClasificacionEmpleado, Me.gleAplicagtoRepre})
        Me.gdcEUS.Size = New System.Drawing.Size(824, 344)
        Me.gdcEUS.TabIndex = 0
        Me.gdcEUS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleEUS, Me.GridView1})
        '
        'gdvDetalleEUS
        '
        Me.gdvDetalleEUS.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.EUS_ID, Me.ORGANIZACION_ID, Me.ESTADO_REGISTRO, Me.ANO, Me.GRADO_ID, Me.CALIDAD_JURIDICA_ID, Me.CLASIFICACION_EMPLEADO_ID, Me.SUELDO_BASE, Me.ASIG_PROFESIONAL_LEY19185_ART19, Me.ASIG_RESPONSABILIDAD_SUPERIOR, Me.ASIG_LEY19185_ART18, Me.ASIG_LEY18717_CON_ASIG_PROFESIONAL, Me.ASIG_LEY18717_SIN_ASIG_PROFESIONAL, Me.BONO_LEY18675_ART10, Me.BONO_LEY18675_ART11, Me.BONO_LEY18566, Me.ASIG_LEY3551, Me.APLICA_GASTO_REPRESENTACION, Me.GASTO_REPRESENTACION, Me.EUS_DETALLE_ID})
        Me.gdvDetalleEUS.GridControl = Me.gdcEUS
        Me.gdvDetalleEUS.GroupPanelText = "Detalle escala única de sueldos con las respectivas asignaciones"
        Me.gdvDetalleEUS.Name = "gdvDetalleEUS"
        Me.gdvDetalleEUS.OptionsNavigation.EnterMoveNextColumn = True
        Me.gdvDetalleEUS.OptionsView.ColumnAutoWidth = False
        '
        'EUS_ID
        '
        Me.EUS_ID.Caption = "Id EUS"
        Me.EUS_ID.FieldName = "EUS_ID"
        Me.EUS_ID.Name = "EUS_ID"
        '
        'ORGANIZACION_ID
        '
        Me.ORGANIZACION_ID.Caption = "ID Organización"
        Me.ORGANIZACION_ID.FieldName = "ORGANIZACION_ID"
        Me.ORGANIZACION_ID.Name = "ORGANIZACION_ID"
        '
        'ESTADO_REGISTRO
        '
        Me.ESTADO_REGISTRO.Caption = "Estado Registro"
        Me.ESTADO_REGISTRO.FieldName = "ESTADO_REGISTRO"
        Me.ESTADO_REGISTRO.Name = "ESTADO_REGISTRO"
        '
        'ANO
        '
        Me.ANO.Caption = "Año"
        Me.ANO.FieldName = "ANO"
        Me.ANO.Name = "ANO"
        '
        'GRADO_ID
        '
        Me.GRADO_ID.Caption = "Grado"
        Me.GRADO_ID.ColumnEdit = Me.gleGrado
        Me.GRADO_ID.FieldName = "GRADO_ID"
        Me.GRADO_ID.Name = "GRADO_ID"
        Me.GRADO_ID.Visible = True
        Me.GRADO_ID.VisibleIndex = 0
        '
        'gleGrado
        '
        Me.gleGrado.AutoHeight = False
        Me.gleGrado.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleGrado.Name = "gleGrado"
        Me.gleGrado.NullText = ""
        Me.gleGrado.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'CALIDAD_JURIDICA_ID
        '
        Me.CALIDAD_JURIDICA_ID.Caption = "Calidad Jurídica"
        Me.CALIDAD_JURIDICA_ID.ColumnEdit = Me.gleCalidadJuridica
        Me.CALIDAD_JURIDICA_ID.FieldName = "CALIDAD_JURIDICA_ID"
        Me.CALIDAD_JURIDICA_ID.Name = "CALIDAD_JURIDICA_ID"
        Me.CALIDAD_JURIDICA_ID.Visible = True
        Me.CALIDAD_JURIDICA_ID.VisibleIndex = 1
        Me.CALIDAD_JURIDICA_ID.Width = 95
        '
        'gleCalidadJuridica
        '
        Me.gleCalidadJuridica.AutoHeight = False
        Me.gleCalidadJuridica.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleCalidadJuridica.Name = "gleCalidadJuridica"
        Me.gleCalidadJuridica.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'CLASIFICACION_EMPLEADO_ID
        '
        Me.CLASIFICACION_EMPLEADO_ID.Caption = "Clasificación Empleado"
        Me.CLASIFICACION_EMPLEADO_ID.ColumnEdit = Me.gleClasificacionEmpleado
        Me.CLASIFICACION_EMPLEADO_ID.FieldName = "CLASIFICACION_EMPLEADO_ID"
        Me.CLASIFICACION_EMPLEADO_ID.Name = "CLASIFICACION_EMPLEADO_ID"
        Me.CLASIFICACION_EMPLEADO_ID.Visible = True
        Me.CLASIFICACION_EMPLEADO_ID.VisibleIndex = 2
        Me.CLASIFICACION_EMPLEADO_ID.Width = 128
        '
        'gleClasificacionEmpleado
        '
        Me.gleClasificacionEmpleado.AutoHeight = False
        Me.gleClasificacionEmpleado.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleClasificacionEmpleado.Name = "gleClasificacionEmpleado"
        Me.gleClasificacionEmpleado.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'SUELDO_BASE
        '
        Me.SUELDO_BASE.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.SUELDO_BASE.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.SUELDO_BASE.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SUELDO_BASE.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.SUELDO_BASE.AppearanceCell.Options.UseBackColor = True
        Me.SUELDO_BASE.AppearanceCell.Options.UseBorderColor = True
        Me.SUELDO_BASE.AppearanceCell.Options.UseFont = True
        Me.SUELDO_BASE.AppearanceCell.Options.UseForeColor = True
        Me.SUELDO_BASE.Caption = "Sueldo Base"
        Me.SUELDO_BASE.DisplayFormat.FormatString = "n0"
        Me.SUELDO_BASE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SUELDO_BASE.FieldName = "SUELDO_BASE"
        Me.SUELDO_BASE.Name = "SUELDO_BASE"
        Me.SUELDO_BASE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.SUELDO_BASE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.SUELDO_BASE.OptionsColumn.ReadOnly = True
        Me.SUELDO_BASE.OptionsFilter.AllowAutoFilter = False
        Me.SUELDO_BASE.OptionsFilter.AllowFilter = False
        Me.SUELDO_BASE.Visible = True
        Me.SUELDO_BASE.VisibleIndex = 3
        '
        'ASIG_PROFESIONAL_LEY19185_ART19
        '
        Me.ASIG_PROFESIONAL_LEY19185_ART19.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ASIG_PROFESIONAL_LEY19185_ART19.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.ASIG_PROFESIONAL_LEY19185_ART19.AppearanceCell.Options.UseFont = True
        Me.ASIG_PROFESIONAL_LEY19185_ART19.AppearanceCell.Options.UseForeColor = True
        Me.ASIG_PROFESIONAL_LEY19185_ART19.Caption = "LEY 19.185 Art.19"
        Me.ASIG_PROFESIONAL_LEY19185_ART19.DisplayFormat.FormatString = "n0"
        Me.ASIG_PROFESIONAL_LEY19185_ART19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ASIG_PROFESIONAL_LEY19185_ART19.FieldName = "ASIG_PROFESIONAL_LEY19185_ART19"
        Me.ASIG_PROFESIONAL_LEY19185_ART19.Name = "ASIG_PROFESIONAL_LEY19185_ART19"
        Me.ASIG_PROFESIONAL_LEY19185_ART19.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.ASIG_PROFESIONAL_LEY19185_ART19.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.ASIG_PROFESIONAL_LEY19185_ART19.OptionsColumn.ReadOnly = True
        Me.ASIG_PROFESIONAL_LEY19185_ART19.OptionsFilter.AllowAutoFilter = False
        Me.ASIG_PROFESIONAL_LEY19185_ART19.OptionsFilter.AllowFilter = False
        Me.ASIG_PROFESIONAL_LEY19185_ART19.Visible = True
        Me.ASIG_PROFESIONAL_LEY19185_ART19.VisibleIndex = 4
        '
        'ASIG_RESPONSABILIDAD_SUPERIOR
        '
        Me.ASIG_RESPONSABILIDAD_SUPERIOR.Caption = "Asig.Resp.Superior"
        Me.ASIG_RESPONSABILIDAD_SUPERIOR.DisplayFormat.FormatString = "n0"
        Me.ASIG_RESPONSABILIDAD_SUPERIOR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ASIG_RESPONSABILIDAD_SUPERIOR.FieldName = "ASIG_RESPONSABILIDAD_SUPERIOR"
        Me.ASIG_RESPONSABILIDAD_SUPERIOR.Name = "ASIG_RESPONSABILIDAD_SUPERIOR"
        Me.ASIG_RESPONSABILIDAD_SUPERIOR.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.ASIG_RESPONSABILIDAD_SUPERIOR.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.ASIG_RESPONSABILIDAD_SUPERIOR.OptionsFilter.AllowAutoFilter = False
        Me.ASIG_RESPONSABILIDAD_SUPERIOR.OptionsFilter.AllowFilter = False
        Me.ASIG_RESPONSABILIDAD_SUPERIOR.Visible = True
        Me.ASIG_RESPONSABILIDAD_SUPERIOR.VisibleIndex = 5
        Me.ASIG_RESPONSABILIDAD_SUPERIOR.Width = 100
        '
        'ASIG_LEY19185_ART18
        '
        Me.ASIG_LEY19185_ART18.Caption = "Ley 19.185 Art.18"
        Me.ASIG_LEY19185_ART18.DisplayFormat.FormatString = "n0"
        Me.ASIG_LEY19185_ART18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ASIG_LEY19185_ART18.FieldName = "ASIG_LEY19185_ART18"
        Me.ASIG_LEY19185_ART18.Name = "ASIG_LEY19185_ART18"
        Me.ASIG_LEY19185_ART18.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.ASIG_LEY19185_ART18.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.ASIG_LEY19185_ART18.OptionsFilter.AllowAutoFilter = False
        Me.ASIG_LEY19185_ART18.OptionsFilter.AllowFilter = False
        Me.ASIG_LEY19185_ART18.Visible = True
        Me.ASIG_LEY19185_ART18.VisibleIndex = 6
        Me.ASIG_LEY19185_ART18.Width = 88
        '
        'ASIG_LEY18717_CON_ASIG_PROFESIONAL
        '
        Me.ASIG_LEY18717_CON_ASIG_PROFESIONAL.Caption = "Ley 18.717 Profesional"
        Me.ASIG_LEY18717_CON_ASIG_PROFESIONAL.DisplayFormat.FormatString = "n0"
        Me.ASIG_LEY18717_CON_ASIG_PROFESIONAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ASIG_LEY18717_CON_ASIG_PROFESIONAL.FieldName = "ASIG_LEY18717_CON_ASIG_PROFESIONAL"
        Me.ASIG_LEY18717_CON_ASIG_PROFESIONAL.Name = "ASIG_LEY18717_CON_ASIG_PROFESIONAL"
        Me.ASIG_LEY18717_CON_ASIG_PROFESIONAL.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.ASIG_LEY18717_CON_ASIG_PROFESIONAL.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.ASIG_LEY18717_CON_ASIG_PROFESIONAL.OptionsFilter.AllowAutoFilter = False
        Me.ASIG_LEY18717_CON_ASIG_PROFESIONAL.OptionsFilter.AllowFilter = False
        Me.ASIG_LEY18717_CON_ASIG_PROFESIONAL.Visible = True
        Me.ASIG_LEY18717_CON_ASIG_PROFESIONAL.VisibleIndex = 7
        Me.ASIG_LEY18717_CON_ASIG_PROFESIONAL.Width = 82
        '
        'ASIG_LEY18717_SIN_ASIG_PROFESIONAL
        '
        Me.ASIG_LEY18717_SIN_ASIG_PROFESIONAL.Caption = "Ley 18.717 No Profesional"
        Me.ASIG_LEY18717_SIN_ASIG_PROFESIONAL.DisplayFormat.FormatString = "n0"
        Me.ASIG_LEY18717_SIN_ASIG_PROFESIONAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ASIG_LEY18717_SIN_ASIG_PROFESIONAL.FieldName = "ASIG_LEY18717_SIN_ASIG_PROFESIONAL"
        Me.ASIG_LEY18717_SIN_ASIG_PROFESIONAL.Name = "ASIG_LEY18717_SIN_ASIG_PROFESIONAL"
        Me.ASIG_LEY18717_SIN_ASIG_PROFESIONAL.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.ASIG_LEY18717_SIN_ASIG_PROFESIONAL.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.ASIG_LEY18717_SIN_ASIG_PROFESIONAL.OptionsFilter.AllowAutoFilter = False
        Me.ASIG_LEY18717_SIN_ASIG_PROFESIONAL.OptionsFilter.AllowFilter = False
        Me.ASIG_LEY18717_SIN_ASIG_PROFESIONAL.Visible = True
        Me.ASIG_LEY18717_SIN_ASIG_PROFESIONAL.VisibleIndex = 8
        '
        'BONO_LEY18675_ART10
        '
        Me.BONO_LEY18675_ART10.Caption = "Ley 18.675 Art.10"
        Me.BONO_LEY18675_ART10.DisplayFormat.FormatString = "n0"
        Me.BONO_LEY18675_ART10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BONO_LEY18675_ART10.FieldName = "BONO_LEY18675_ART10"
        Me.BONO_LEY18675_ART10.Name = "BONO_LEY18675_ART10"
        Me.BONO_LEY18675_ART10.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.BONO_LEY18675_ART10.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.BONO_LEY18675_ART10.OptionsFilter.AllowAutoFilter = False
        Me.BONO_LEY18675_ART10.OptionsFilter.AllowFilter = False
        Me.BONO_LEY18675_ART10.Visible = True
        Me.BONO_LEY18675_ART10.VisibleIndex = 9
        '
        'BONO_LEY18675_ART11
        '
        Me.BONO_LEY18675_ART11.Caption = "Ley 18.675 Art.11"
        Me.BONO_LEY18675_ART11.DisplayFormat.FormatString = "n0"
        Me.BONO_LEY18675_ART11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BONO_LEY18675_ART11.FieldName = "BONO_LEY18675_ART11"
        Me.BONO_LEY18675_ART11.Name = "BONO_LEY18675_ART11"
        Me.BONO_LEY18675_ART11.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.BONO_LEY18675_ART11.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.BONO_LEY18675_ART11.OptionsFilter.AllowAutoFilter = False
        Me.BONO_LEY18675_ART11.OptionsFilter.AllowFilter = False
        Me.BONO_LEY18675_ART11.Visible = True
        Me.BONO_LEY18675_ART11.VisibleIndex = 10
        '
        'BONO_LEY18566
        '
        Me.BONO_LEY18566.Caption = "Ley 18.566"
        Me.BONO_LEY18566.DisplayFormat.FormatString = "n0"
        Me.BONO_LEY18566.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BONO_LEY18566.FieldName = "BONO_LEY18566"
        Me.BONO_LEY18566.Name = "BONO_LEY18566"
        Me.BONO_LEY18566.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.BONO_LEY18566.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.BONO_LEY18566.OptionsFilter.AllowAutoFilter = False
        Me.BONO_LEY18566.OptionsFilter.AllowFilter = False
        Me.BONO_LEY18566.Visible = True
        Me.BONO_LEY18566.VisibleIndex = 11
        '
        'ASIG_LEY3551
        '
        Me.ASIG_LEY3551.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ASIG_LEY3551.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.ASIG_LEY3551.AppearanceCell.Options.UseFont = True
        Me.ASIG_LEY3551.AppearanceCell.Options.UseForeColor = True
        Me.ASIG_LEY3551.Caption = "Ley 3551"
        Me.ASIG_LEY3551.DisplayFormat.FormatString = "n0"
        Me.ASIG_LEY3551.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ASIG_LEY3551.FieldName = "ASIG_LEY3551"
        Me.ASIG_LEY3551.Name = "ASIG_LEY3551"
        Me.ASIG_LEY3551.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.ASIG_LEY3551.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.ASIG_LEY3551.OptionsColumn.ReadOnly = True
        Me.ASIG_LEY3551.Visible = True
        Me.ASIG_LEY3551.VisibleIndex = 12
        '
        'APLICA_GASTO_REPRESENTACION
        '
        Me.APLICA_GASTO_REPRESENTACION.Caption = "Es Gasto Repres."
        Me.APLICA_GASTO_REPRESENTACION.ColumnEdit = Me.gleAplicagtoRepre
        Me.APLICA_GASTO_REPRESENTACION.FieldName = "APLICA_GASTO_REPRESENTACION"
        Me.APLICA_GASTO_REPRESENTACION.Name = "APLICA_GASTO_REPRESENTACION"
        Me.APLICA_GASTO_REPRESENTACION.Visible = True
        Me.APLICA_GASTO_REPRESENTACION.VisibleIndex = 13
        '
        'gleAplicagtoRepre
        '
        Me.gleAplicagtoRepre.AutoHeight = False
        Me.gleAplicagtoRepre.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleAplicagtoRepre.Name = "gleAplicagtoRepre"
        Me.gleAplicagtoRepre.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.RowAutoHeight = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.RowHeight = 5
        '
        'GASTO_REPRESENTACION
        '
        Me.GASTO_REPRESENTACION.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GASTO_REPRESENTACION.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.GASTO_REPRESENTACION.AppearanceCell.Options.UseFont = True
        Me.GASTO_REPRESENTACION.AppearanceCell.Options.UseForeColor = True
        Me.GASTO_REPRESENTACION.Caption = "Gasto Representación"
        Me.GASTO_REPRESENTACION.DisplayFormat.FormatString = "n0"
        Me.GASTO_REPRESENTACION.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GASTO_REPRESENTACION.FieldName = "GASTO_REPRESENTACION"
        Me.GASTO_REPRESENTACION.Name = "GASTO_REPRESENTACION"
        Me.GASTO_REPRESENTACION.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.GASTO_REPRESENTACION.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.GASTO_REPRESENTACION.OptionsColumn.ReadOnly = True
        Me.GASTO_REPRESENTACION.Visible = True
        Me.GASTO_REPRESENTACION.VisibleIndex = 14
        '
        'EUS_DETALLE_ID
        '
        Me.EUS_DETALLE_ID.Caption = "Detalle EUS ID"
        Me.EUS_DETALLE_ID.FieldName = "EUS_DETALLE_ID"
        Me.EUS_DETALLE_ID.Name = "EUS_DETALLE_ID"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcEUS
        Me.GridView1.Name = "GridView1"
        '
        'gpcPeriodo
        '
        Me.gpcPeriodo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcPeriodo.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcPeriodo.AppearanceCaption.Options.UseFont = True
        Me.gpcPeriodo.Controls.Add(Me.btnImprimir)
        Me.gpcPeriodo.Controls.Add(Me.luePeriodo)
        Me.gpcPeriodo.Controls.Add(Me.lblAno)
        Me.gpcPeriodo.Location = New System.Drawing.Point(16, 16)
        Me.gpcPeriodo.Name = "gpcPeriodo"
        Me.gpcPeriodo.Size = New System.Drawing.Size(824, 72)
        Me.gpcPeriodo.TabIndex = 1
        Me.gpcPeriodo.Text = "Periodo"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Location = New System.Drawing.Point(704, 32)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(112, 23)
        Me.btnImprimir.TabIndex = 5
        Me.btnImprimir.Text = "Imprimir Reporte"
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(104, 32)
        Me.luePeriodo.Name = "luePeriodo"
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(160, 20)
        Me.luePeriodo.TabIndex = 4
        '
        'lblAno
        '
        Me.lblAno.Location = New System.Drawing.Point(40, 36)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(48, 16)
        Me.lblAno.TabIndex = 3
        Me.lblAno.Text = "Año"
        Me.lblAno.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcEUS
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de La República", "", "[Date Printed]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Sistema Integral de Gestión Administrativa (SIGA)", "", "Página Número  [Page #]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'frmEUS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 446)
        Me.Controls.Add(Me.gpcPeriodo)
        Me.Controls.Add(Me.gdcEUS)
        Me.Name = "frmEUS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Escala Única de Sueldos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcEUS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleEUS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleGrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleCalidadJuridica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleClasificacionEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleAplicagtoRepre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcPeriodo.ResumeLayout(False)
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim empleado As empleado
    Dim parametroMensual As Periodo

    Private Sub frmEUS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        repositorio.Show()
        llenarPeriodos()
        llenarGrado()
        llenarCalidadJuridica()
        llenarClasificacionEmpleado()
        llenarAplicaGastoRepresentacion()
        empleado = New Empleado
        parametroMensual = New Periodo
    End Sub
    Private Sub llenarPeriodos()
        Dim da As SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
        Dim ds As New DataSet

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT * FROM " & Tablas.RH_REM_EUS_ENC & " ORDER BY ANO DESC, MES DESC", conn))
        da.Fill(ds, Tablas.RH_REM_EUS_ENC)
        Dim dvmPeriodo As New DataViewManager(ds)
        dvPeriodo = dvmPeriodo.CreateDataView(ds.Tables(Tablas.RH_REM_EUS_ENC))

        With luePeriodo
            With .Properties.Columns
                .Add(New LookUpColumnInfo("ANO", "Año", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("MES", "Mes", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Periodo", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("EUS_ID", "ID EUS", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        luePeriodo.Properties.DataSource = dvPeriodo
        luePeriodo.Properties.DisplayMember = "DESCRIPCION"
        luePeriodo.Properties.NullText = ""
        luePeriodo.Properties.PopupWidth = 150
        luePeriodo.Properties.ValueMember = "EUS_ID"
    End Sub
    Public Sub llenarGrado()
        gleGrado.ViewType = Repository.GridLookUpViewType.GridView
        gleGrado.View.OptionsBehavior.AutoPopulateColumns = False
        gleGrado.DataSource = repositorio.dvGrado
        gleGrado.DisplayMember = "GRADO_ALIAS"

        Dim col1 As GridColumn = gleGrado.View.Columns.AddField("GRADO_ID")
        col1.VisibleIndex = 0
        col1.Caption = "ID Grado"
        col1.Visible = False

        Dim col2 As GridColumn = gleGrado.View.Columns.AddField("GRADO_ALIAS")
        col2.VisibleIndex = 1
        col2.Caption = "Grado"

        Dim col3 As GridColumn = gleGrado.View.Columns.AddField("SUELDO_BASE")
        col3.VisibleIndex = 2
        col3.Caption = "Sueldo Base"
        col3.Visible = False

        Dim col4 As GridColumn = gleGrado.View.Columns.AddField("ASIG_PROFESIONAL_LEY19185_ART19")
        col4.VisibleIndex = 3
        col4.Caption = "Ley 19.185 Art.19"
        col4.Visible = False

        gleGrado.ValueMember = "GRADO_ID"
        gleGrado.View.BestFitColumns()
        gleGrado.PopupFormWidth = 100
    End Sub
    Public Sub llenarCalidadJuridica()
        gleCalidadJuridica.ViewType = Repository.GridLookUpViewType.GridView
        gleCalidadJuridica.View.OptionsBehavior.AutoPopulateColumns = False
        gleCalidadJuridica.DataSource = repositorio.dvCalidadJuridica
        gleCalidadJuridica.DisplayMember = "DESCRIPCION"

        Dim col1 As GridColumn = gleCalidadJuridica.View.Columns.AddField("CALIDAD_JURIDICA_ID")
        col1.VisibleIndex = 0
        col1.Caption = "ID Calidad Jurídica"
        col1.Visible = False

        Dim col2 As GridColumn = gleCalidadJuridica.View.Columns.AddField("DESCRIPCION")
        col2.VisibleIndex = 1
        col2.Caption = "Descripción"

        gleCalidadJuridica.ValueMember = "CALIDAD_JURIDICA_ID"
        gleCalidadJuridica.View.BestFitColumns()
        gleCalidadJuridica.PopupFormWidth = 200
    End Sub
    Public Sub llenarAplicaGastoRepresentacion()
        gleAplicagtoRepre.ViewType = Repository.GridLookUpViewType.GridView
        gleAplicagtoRepre.View.OptionsBehavior.AutoPopulateColumns = False
        gleAplicagtoRepre.DataSource = repositorio.dvRespuesta
        gleAplicagtoRepre.DisplayMember = "DESCRIPCION"

        Dim col1 As GridColumn = gleAplicagtoRepre.View.Columns.AddField("RESPUESTA_ID")
        col1.VisibleIndex = 0
        col1.Caption = "ID Respuesta"
        col1.Visible = False

        Dim col2 As GridColumn = gleAplicagtoRepre.View.Columns.AddField("DESCRIPCION")
        col2.VisibleIndex = 1
        col2.Caption = "Descripción"

        gleAplicagtoRepre.ValueMember = "RESPUESTA_ID"
        gleAplicagtoRepre.View.BestFitColumns()
        gleAplicagtoRepre.PopupFormWidth = 100
    End Sub
    Public Sub llenarClasificacionEmpleado()
        gleClasificacionEmpleado.ViewType = Repository.GridLookUpViewType.GridView
        gleClasificacionEmpleado.View.OptionsBehavior.AutoPopulateColumns = False
        gleClasificacionEmpleado.DataSource = repositorio.dvClasificacionEmpleado
        gleClasificacionEmpleado.DisplayMember = "DESCRIPCION"

        Dim col1 As GridColumn = gleClasificacionEmpleado.View.Columns.AddField("CLASIFICACION_EMPLEADO_ID")
        col1.VisibleIndex = 0
        col1.Caption = "ID Clasif.Empleado"
        col1.Visible = False

        Dim col2 As GridColumn = gleClasificacionEmpleado.View.Columns.AddField("DESCRIPCION")
        col2.VisibleIndex = 1
        col2.Caption = "Descripción"

        Dim col3 As GridColumn = gleClasificacionEmpleado.View.Columns.AddField("APLICA_LEY3551")
        col3.VisibleIndex = 1
        col3.Caption = "Aplica Ley 3551"
        col3.Visible = False

        gleClasificacionEmpleado.ValueMember = "CLASIFICACION_EMPLEADO_ID"
        gleClasificacionEmpleado.View.BestFitColumns()
        gleClasificacionEmpleado.PopupFormWidth = 350
    End Sub

    Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        If luePeriodo.EditValue <> Nothing Then
            gdcEUS.DataSource = empleado.dvEUS(luePeriodo.EditValue)
        End If
    End Sub

    Private Sub gdvDetalleEUS_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvDetalleEUS.RowUpdated
        If empleado.actualizarEUS() Then
            gdcEUS.Refresh()
        End If
    End Sub

    Private Sub gdvDetalleEUS_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvDetalleEUS.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub gleGrado_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gleGrado.EditValueChanged
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetalleEUS
        Dim idGrado As Integer = view.EditingValue
        Dim idClasEmpleado As Integer = view.GetRowCellValue(view.FocusedRowHandle, "CLASIFICACION_EMPLEADO_ID")
        Dim valor, esProfesional As Integer
        valor = empleado.recuperaValorNumerico("SELECT SUELDO_BASE FROM RH_REM_GRADO WHERE GRADO_ID=" & idGrado & " AND ANO=" & luePeriodo.EditValue & " AND ESTADO_REGISTRO=1")
        view.SetRowCellValue(view.FocusedRowHandle, "SUELDO_BASE", valor)
        esProfesional = empleado.recuperaValorNumerico("SELECT ES_PROFESIONAL FROM RH_REM_CLASIFICACION_EMPLEADO WHERE CLASIFICACION_EMPLEADO_ID=" & idClasEmpleado & " AND ORGANIZACION_ID=1")
        If esProfesional = -1 Then
            valor = empleado.recuperaValorNumerico("SELECT ASIG_PROFESIONAL_LEY19185_ART19 FROM RH_REM_GRADO WHERE GRADO_ID=" & idGrado & " AND ANO=" & luePeriodo.EditValue & " AND ESTADO_REGISTRO=1")
        Else
            valor = 0
        End If
        view.SetRowCellValue(view.FocusedRowHandle, "ASIG_PROFESIONAL_LEY19185_ART19", valor)
        generaMontoLey3551(idClasEmpleado)
        gdcEUS.Refresh()
    End Sub

    Private Sub gleClasificacionEmpleado_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gleClasificacionEmpleado.EditValueChanged
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetalleEUS
        Dim idClasEmpleado As Integer = view.EditingValue
        generaMontoLey3551(idClasEmpleado)
    End Sub
    Private Sub generaMontoLey3551(ByVal idClasEmpleado As Integer)
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetalleEUS
        Dim aplicaLey3551 As Integer
        aplicaLey3551 = empleado.recuperaValorNumerico("SELECT APLICA_LEY3551 FROM RH_REM_CLASIFICACION_EMPLEADO WHERE CLASIFICACION_EMPLEADO_ID=" & idClasEmpleado & " AND ORGANIZACION_ID=1")
        If aplicaLey3551 = -1 Then
            Dim sueldoBase As Integer = view.GetRowCellValue(view.FocusedRowHandle, "SUELDO_BASE")
            Dim asigLey19185Art19 As Integer = view.GetRowCellValue(view.FocusedRowHandle, "ASIG_PROFESIONAL_LEY19185_ART19")
            Dim montoLey3551 As Integer = Math.Round((sueldoBase + asigLey19185Art19) * (90 / 100), 0)
            view.SetRowCellValue(view.FocusedRowHandle, "ASIG_LEY3551", montoLey3551)
        Else
            view.SetRowCellValue(view.FocusedRowHandle, "ASIG_LEY3551", 0)
        End If
    End Sub

    Private Sub gleAplicagtoRepre_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gleAplicagtoRepre.EditValueChanged
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetalleEUS
        Dim calculaGtoRepresentacion As Integer = view.EditingValue
        'valor = view.EditingValue
        'valor = view.GetRowCellValue(view.FocusedRowHandle, "APLICA_GASTO_REPRESENTACION")
        If calculaGtoRepresentacion = 1 Then
            Dim sueldoBase As Integer = view.GetRowCellValue(view.FocusedRowHandle, "SUELDO_BASE")
            Dim montoGtoRepresentacion As Decimal
            Dim pctGastoRepresentacion As Decimal = (parametroMensual.porcentajeGastoRepresentacion / 100)
            Dim total As Decimal = sueldoBase * pctGastoRepresentacion
            montoGtoRepresentacion = Math.Round(total, 1)
            view.SetRowCellValue(view.FocusedRowHandle, "GASTO_REPRESENTACION", montoGtoRepresentacion)
        Else
            view.SetRowCellValue(view.FocusedRowHandle, "GASTO_REPRESENTACION", 0)
        End If
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
End Class
