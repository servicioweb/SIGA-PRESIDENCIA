Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmGrado
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
    Friend WithEvents gdvGrado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ORGANIZACION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ANO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GRADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GRADO_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ORDEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SUELDO_BASE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ASIG_PROFESIONAL_LEY19185_ART19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gdcGrado As DevExpress.XtraGrid.GridControl
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblAno As System.Windows.Forms.Label
    Friend WithEvents dvPeriodo As System.Data.DataView
    Friend WithEvents PROCENTAJE_VIATICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VALOR_VIATICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GRADO_VIATICO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gleGrado As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents txtPorcentajeViatico As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents iglGrado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtSueldoBase As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtMontoViatico As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtMontoAsignacionProfesional As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrado))
        Me.gdcGrado = New DevExpress.XtraGrid.GridControl()
        Me.gdvGrado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ORGANIZACION_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ANO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GRADO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GRADO_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SUELDO_BASE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtSueldoBase = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ORDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ASIG_PROFESIONAL_LEY19185_ART19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMontoAsignacionProfesional = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GRADO_VIATICO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleGrado = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.iglGrado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PROCENTAJE_VIATICO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPorcentajeViatico = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.VALOR_VIATICO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMontoViatico = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.dvPeriodo = New System.Data.DataView()
        CType(Me.gdcGrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvGrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSueldoBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoAsignacionProfesional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleGrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iglGrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentajeViatico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoViatico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcGrado
        '
        Me.gdcGrado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcGrado.Location = New System.Drawing.Point(16, 96)
        Me.gdcGrado.MainView = Me.gdvGrado
        Me.gdcGrado.Name = "gdcGrado"
        Me.gdcGrado.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtPorcentajeViatico, Me.gleGrado, Me.txtSueldoBase, Me.txtMontoViatico, Me.txtMontoAsignacionProfesional})
        Me.gdcGrado.Size = New System.Drawing.Size(824, 392)
        Me.gdcGrado.TabIndex = 0
        Me.gdcGrado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvGrado, Me.GridView1})
        '
        'gdvGrado
        '
        Me.gdvGrado.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ORGANIZACION_ID, Me.ANO, Me.GRADO_ID, Me.GRADO_ALIAS, Me.SUELDO_BASE, Me.ORDEN, Me.ASIG_PROFESIONAL_LEY19185_ART19, Me.GRADO_VIATICO_ID, Me.PROCENTAJE_VIATICO, Me.VALOR_VIATICO})
        Me.gdvGrado.GridControl = Me.gdcGrado
        Me.gdvGrado.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvGrado.Name = "gdvGrado"
        Me.gdvGrado.NewItemRowText = "Nuevo Registro"
        Me.gdvGrado.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'ORGANIZACION_ID
        '
        Me.ORGANIZACION_ID.Caption = "Id ORGANIZACION"
        Me.ORGANIZACION_ID.FieldName = "ORGANIZACION_ID"
        Me.ORGANIZACION_ID.Name = "ORGANIZACION_ID"
        '
        'ANO
        '
        Me.ANO.Caption = "Año"
        Me.ANO.FieldName = "ANO"
        Me.ANO.Name = "ANO"
        '
        'GRADO_ID
        '
        Me.GRADO_ID.Caption = "ID Grado"
        Me.GRADO_ID.FieldName = "GRADO_ID"
        Me.GRADO_ID.Name = "GRADO_ID"
        '
        'GRADO_ALIAS
        '
        Me.GRADO_ALIAS.Caption = "Grado Alias"
        Me.GRADO_ALIAS.FieldName = "GRADO_ALIAS"
        Me.GRADO_ALIAS.Name = "GRADO_ALIAS"
        Me.GRADO_ALIAS.Visible = True
        Me.GRADO_ALIAS.VisibleIndex = 0
        Me.GRADO_ALIAS.Width = 101
        '
        'SUELDO_BASE
        '
        Me.SUELDO_BASE.Caption = "Sueldo Base"
        Me.SUELDO_BASE.ColumnEdit = Me.txtSueldoBase
        Me.SUELDO_BASE.FieldName = "SUELDO_BASE"
        Me.SUELDO_BASE.Name = "SUELDO_BASE"
        Me.SUELDO_BASE.Visible = True
        Me.SUELDO_BASE.VisibleIndex = 1
        Me.SUELDO_BASE.Width = 114
        '
        'txtSueldoBase
        '
        Me.txtSueldoBase.AutoHeight = False
        Me.txtSueldoBase.DisplayFormat.FormatString = "n0"
        Me.txtSueldoBase.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSueldoBase.EditFormat.FormatString = "n0"
        Me.txtSueldoBase.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSueldoBase.Mask.EditMask = "n0"
        Me.txtSueldoBase.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSueldoBase.Mask.UseMaskAsDisplayFormat = True
        Me.txtSueldoBase.Name = "txtSueldoBase"
        '
        'ORDEN
        '
        Me.ORDEN.Caption = "Orden"
        Me.ORDEN.FieldName = "ORDEN"
        Me.ORDEN.Name = "ORDEN"
        Me.ORDEN.Visible = True
        Me.ORDEN.VisibleIndex = 2
        Me.ORDEN.Width = 118
        '
        'ASIG_PROFESIONAL_LEY19185_ART19
        '
        Me.ASIG_PROFESIONAL_LEY19185_ART19.Caption = "Asignación Profesional"
        Me.ASIG_PROFESIONAL_LEY19185_ART19.ColumnEdit = Me.txtMontoAsignacionProfesional
        Me.ASIG_PROFESIONAL_LEY19185_ART19.FieldName = "ASIG_PROFESIONAL_LEY19185_ART19"
        Me.ASIG_PROFESIONAL_LEY19185_ART19.Name = "ASIG_PROFESIONAL_LEY19185_ART19"
        Me.ASIG_PROFESIONAL_LEY19185_ART19.Visible = True
        Me.ASIG_PROFESIONAL_LEY19185_ART19.VisibleIndex = 3
        Me.ASIG_PROFESIONAL_LEY19185_ART19.Width = 150
        '
        'txtMontoAsignacionProfesional
        '
        Me.txtMontoAsignacionProfesional.AutoHeight = False
        Me.txtMontoAsignacionProfesional.DisplayFormat.FormatString = "n0"
        Me.txtMontoAsignacionProfesional.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoAsignacionProfesional.EditFormat.FormatString = "n0"
        Me.txtMontoAsignacionProfesional.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoAsignacionProfesional.Mask.EditMask = "n0"
        Me.txtMontoAsignacionProfesional.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoAsignacionProfesional.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoAsignacionProfesional.Name = "txtMontoAsignacionProfesional"
        '
        'GRADO_VIATICO_ID
        '
        Me.GRADO_VIATICO_ID.Caption = "Viático Según Grado"
        Me.GRADO_VIATICO_ID.ColumnEdit = Me.gleGrado
        Me.GRADO_VIATICO_ID.FieldName = "GRADO_VIATICO_ID"
        Me.GRADO_VIATICO_ID.Name = "GRADO_VIATICO_ID"
        Me.GRADO_VIATICO_ID.Visible = True
        Me.GRADO_VIATICO_ID.VisibleIndex = 4
        Me.GRADO_VIATICO_ID.Width = 230
        '
        'gleGrado
        '
        Me.gleGrado.AutoHeight = False
        Me.gleGrado.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleGrado.Name = "gleGrado"
        Me.gleGrado.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.gleGrado.View = Me.iglGrado
        '
        'iglGrado
        '
        Me.iglGrado.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.iglGrado.Name = "iglGrado"
        Me.iglGrado.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.iglGrado.OptionsView.ShowGroupPanel = False
        '
        'PROCENTAJE_VIATICO
        '
        Me.PROCENTAJE_VIATICO.Caption = "Porcentaje Viatico"
        Me.PROCENTAJE_VIATICO.ColumnEdit = Me.txtPorcentajeViatico
        Me.PROCENTAJE_VIATICO.FieldName = "PROCENTAJE_VIATICO"
        Me.PROCENTAJE_VIATICO.Name = "PROCENTAJE_VIATICO"
        Me.PROCENTAJE_VIATICO.Visible = True
        Me.PROCENTAJE_VIATICO.VisibleIndex = 5
        Me.PROCENTAJE_VIATICO.Width = 144
        '
        'txtPorcentajeViatico
        '
        Me.txtPorcentajeViatico.AutoHeight = False
        Me.txtPorcentajeViatico.DisplayFormat.FormatString = "P2"
        Me.txtPorcentajeViatico.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorcentajeViatico.EditFormat.FormatString = "P2"
        Me.txtPorcentajeViatico.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorcentajeViatico.Mask.EditMask = "P2"
        Me.txtPorcentajeViatico.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPorcentajeViatico.Mask.UseMaskAsDisplayFormat = True
        Me.txtPorcentajeViatico.Name = "txtPorcentajeViatico"
        '
        'VALOR_VIATICO
        '
        Me.VALOR_VIATICO.Caption = "Valor Viatico"
        Me.VALOR_VIATICO.ColumnEdit = Me.txtMontoViatico
        Me.VALOR_VIATICO.FieldName = "VALOR_VIATICO"
        Me.VALOR_VIATICO.Name = "VALOR_VIATICO"
        Me.VALOR_VIATICO.OptionsColumn.ReadOnly = True
        Me.VALOR_VIATICO.Visible = True
        Me.VALOR_VIATICO.VisibleIndex = 6
        Me.VALOR_VIATICO.Width = 391
        '
        'txtMontoViatico
        '
        Me.txtMontoViatico.AutoHeight = False
        Me.txtMontoViatico.DisplayFormat.FormatString = "n0"
        Me.txtMontoViatico.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoViatico.EditFormat.FormatString = "n0"
        Me.txtMontoViatico.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoViatico.Mask.EditMask = "n0"
        Me.txtMontoViatico.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoViatico.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoViatico.Name = "txtMontoViatico"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcGrado
        Me.GridView1.Name = "GridView1"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Location = New System.Drawing.Point(688, 24)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(120, 23)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir Reporte"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcGrado
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de La República", "", "[Date Printed]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Sistema Integral de Gestión Administrativa (SIGA)", "", "Página Número  [Page #]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.luePeriodo)
        Me.GroupControl1.Controls.Add(Me.lblAno)
        Me.GroupControl1.Controls.Add(Me.btnImprimir)
        Me.GroupControl1.Location = New System.Drawing.Point(16, 16)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(824, 72)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Periodo"
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(104, 32)
        Me.luePeriodo.Name = "luePeriodo"
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(160, 20)
        Me.luePeriodo.TabIndex = 6
        '
        'lblAno
        '
        Me.lblAno.Location = New System.Drawing.Point(40, 32)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(48, 16)
        Me.lblAno.TabIndex = 5
        Me.lblAno.Text = "Año"
        Me.lblAno.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmGrado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 517)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gdcGrado)
        Me.Name = "frmGrado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Grados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcGrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvGrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSueldoBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoAsignacionProfesional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleGrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iglGrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentajeViatico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoViatico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Grado As Mantenedor
    Dim sueldoBase As Integer

    Private Sub frmGrado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Grado = New Mantenedor
        ' gdcGrado.DataSource = Grado.recuperarGrado
        llenarPeriodos()
        llenarGrado()
    End Sub


    Private Sub llenarPeriodos()
        Dim da As SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
        Dim ds As New DataSet

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT DISTINCT ANO FROM " & Tablas.RH_REM_PERIODO & " ORDER BY ANO DESC", conn))
        da.Fill(ds, Tablas.RH_REM_PERIODO)
        Dim dvmPeriodo As New DataViewManager(ds)
        dvPeriodo = dvmPeriodo.CreateDataView(ds.Tables(Tablas.RH_REM_PERIODO))

        With luePeriodo
            With .Properties.Columns
                .Add(New LookUpColumnInfo("ANO", "Año", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        luePeriodo.Properties.DataSource = dvPeriodo
        luePeriodo.Properties.DisplayMember = "ANO"
        luePeriodo.Properties.NullText = ""
        luePeriodo.Properties.PopupWidth = 150
        luePeriodo.Properties.ValueMember = "ANO"
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

        gleGrado.ValueMember = "GRADO_ID"
        gleGrado.View.BestFitColumns()
        gleGrado.PopupFormWidth = 100
    End Sub

    Private Sub gdvGrado_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvGrado.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gdvGrado_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvGrado.RowUpdated
        If Grado.actualizarGrado Then
            gdcGrado.Refresh()
            repositorio.RefreshDatos("Grado")
        End If
    End Sub

    Private Sub gdvGrado_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvGrado.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                Try
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                    view.DeleteRow(view.FocusedRowHandle)
                    Grado.actualizarGrado()
                    gdcGrado.Refresh()
                    MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)
                    repositorio.RefreshDatos("Grado")
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al intentar eliminar el registro " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If

            gdcGrado.DataSource = Grado.recuperarGrado(luePeriodo.EditValue)
        End If
    End Sub

    Private Sub gdvGrado_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvGrado.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        view.SetRowCellValue(e.RowHandle, "ORGANIZACION_ID", Comun.ArgoConfiguracion.OrganizacionID)
        view.SetRowCellValue(e.RowHandle, "ANO", luePeriodo.EditValue)
        view.SetRowCellValue(e.RowHandle, "ESTADO_REGISTRO", 1)
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

    Private Sub luePeriodo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        If luePeriodo.EditValue <> Nothing Then
            gdcGrado.DataSource = Grado.recuperarGrado(luePeriodo.EditValue)
        End If
    End Sub

    Private Sub txtPorcentajeViatico_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPorcentajeViatico.Validating
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvGrado
        Dim porcentajeViatico As DevExpress.XtraEditors.TextEdit = sender
        Dim montoViatico As Integer

        If porcentajeViatico.EditValue > 0 Then
            montoViatico = sueldoBase * (porcentajeViatico.EditValue / 100)
        Else
            montoViatico = 0
        End If
        view.SetRowCellValue(view.FocusedRowHandle, "VALOR_VIATICO", montoViatico)
    End Sub

    Private Sub gleGrado_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gleGrado.EditValueChanged
        Dim editor As DevExpress.XtraEditors.GridLookUpEdit = CType(sender, DevExpress.XtraEditors.GridLookUpEdit)
        Dim row As DataRow = CType(editor.Properties.View.GetDataRow(editor.Properties.View.FocusedRowHandle), DataRow)
        sueldoBase = row("SUELDO_BASE")
    End Sub
End Class
