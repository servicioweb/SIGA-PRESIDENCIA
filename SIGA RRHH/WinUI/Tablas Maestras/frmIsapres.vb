Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base



Public Class frmIsapres
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
    Friend WithEvents gdvDetalleIsapres As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ORGANIZACION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ISAPRE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ISAPRE_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RUT_ISAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DV_ISAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SISTEMA_PREV_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIRECCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COMUNA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CODIGO_PREVIRED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gdcIsapres As DevExpress.XtraGrid.GridControl
    Friend WithEvents dvComuna As System.Data.DataView
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gleComuna As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents txtRut As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents dvSistema As System.Data.DataView
    Friend WithEvents gleSistema As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIsapres))
        Me.gdcIsapres = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleIsapres = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ORGANIZACION_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ISAPRE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ISAPRE_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RUT_ISAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtRut = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DV_ISAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SISTEMA_PREV_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleSistema = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DIRECCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COMUNA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleComuna = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CODIGO_PREVIRED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dvComuna = New System.Data.DataView()
        Me.dvSistema = New System.Data.DataView()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.gdcIsapres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleIsapres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleComuna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvComuna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcIsapres
        '
        Me.gdcIsapres.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcIsapres.Location = New System.Drawing.Point(16, 64)
        Me.gdcIsapres.MainView = Me.gdvDetalleIsapres
        Me.gdcIsapres.Name = "gdcIsapres"
        Me.gdcIsapres.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.gleComuna, Me.txtRut, Me.gleSistema})
        Me.gdcIsapres.Size = New System.Drawing.Size(824, 360)
        Me.gdcIsapres.TabIndex = 0
        Me.gdcIsapres.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleIsapres, Me.GridView1})
        '
        'gdvDetalleIsapres
        '
        Me.gdvDetalleIsapres.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleIsapres.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.gdvDetalleIsapres.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleIsapres.Appearance.FocusedRow.Options.UseFont = True
        Me.gdvDetalleIsapres.Appearance.GroupFooter.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleIsapres.Appearance.GroupFooter.Options.UseFont = True
        Me.gdvDetalleIsapres.Appearance.GroupRow.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleIsapres.Appearance.GroupRow.Options.UseFont = True
        Me.gdvDetalleIsapres.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleIsapres.Appearance.HeaderPanel.Options.UseFont = True
        Me.gdvDetalleIsapres.Appearance.Preview.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleIsapres.Appearance.Preview.Options.UseFont = True
        Me.gdvDetalleIsapres.Appearance.Row.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.gdvDetalleIsapres.Appearance.Row.Options.UseFont = True
        Me.gdvDetalleIsapres.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ORGANIZACION_ID, Me.ISAPRE_ID, Me.ISAPRE_ALIAS, Me.DESCRIPCION, Me.RUT_ISAP, Me.DV_ISAP, Me.SISTEMA_PREV_ID, Me.DIRECCION, Me.COMUNA_ID, Me.CODIGO_PREVIRED})
        Me.gdvDetalleIsapres.GridControl = Me.gdcIsapres
        Me.gdvDetalleIsapres.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvDetalleIsapres.Name = "gdvDetalleIsapres"
        Me.gdvDetalleIsapres.NewItemRowText = "Nuevo Registro"
        Me.gdvDetalleIsapres.OptionsNavigation.EnterMoveNextColumn = True
        Me.gdvDetalleIsapres.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'ORGANIZACION_ID
        '
        Me.ORGANIZACION_ID.Caption = "Id Organizacion"
        Me.ORGANIZACION_ID.FieldName = "ORGANIZACION_ID"
        Me.ORGANIZACION_ID.Name = "ORGANIZACION_ID"
        '
        'ISAPRE_ID
        '
        Me.ISAPRE_ID.Caption = "ID Isapre"
        Me.ISAPRE_ID.FieldName = "ISAPRE_ID"
        Me.ISAPRE_ID.Name = "ISAPRE_ID"
        '
        'ISAPRE_ALIAS
        '
        Me.ISAPRE_ALIAS.Caption = "ALIAS ISAPRE"
        Me.ISAPRE_ALIAS.FieldName = "ISAPRE_ALIAS"
        Me.ISAPRE_ALIAS.Name = "ISAPRE_ALIAS"
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.Caption = "Descripción"
        Me.DESCRIPCION.FieldName = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.Visible = True
        Me.DESCRIPCION.VisibleIndex = 0
        Me.DESCRIPCION.Width = 195
        '
        'RUT_ISAP
        '
        Me.RUT_ISAP.Caption = "RUT"
        Me.RUT_ISAP.ColumnEdit = Me.txtRut
        Me.RUT_ISAP.FieldName = "RUT_ISAP"
        Me.RUT_ISAP.Name = "RUT_ISAP"
        Me.RUT_ISAP.Visible = True
        Me.RUT_ISAP.VisibleIndex = 1
        Me.RUT_ISAP.Width = 66
        '
        'txtRut
        '
        Me.txtRut.AutoHeight = False
        Me.txtRut.DisplayFormat.FormatString = "n0"
        Me.txtRut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRut.Name = "txtRut"
        '
        'DV_ISAP
        '
        Me.DV_ISAP.Caption = "DV"
        Me.DV_ISAP.FieldName = "DV_ISAP"
        Me.DV_ISAP.Name = "DV_ISAP"
        Me.DV_ISAP.Visible = True
        Me.DV_ISAP.VisibleIndex = 2
        Me.DV_ISAP.Width = 30
        '
        'SISTEMA_PREV_ID
        '
        Me.SISTEMA_PREV_ID.Caption = "Sistema Previsional"
        Me.SISTEMA_PREV_ID.ColumnEdit = Me.gleSistema
        Me.SISTEMA_PREV_ID.FieldName = "SISTEMA_PREV_ID"
        Me.SISTEMA_PREV_ID.Name = "SISTEMA_PREV_ID"
        Me.SISTEMA_PREV_ID.Visible = True
        Me.SISTEMA_PREV_ID.VisibleIndex = 6
        Me.SISTEMA_PREV_ID.Width = 131
        '
        'gleSistema
        '
        Me.gleSistema.AutoHeight = False
        Me.gleSistema.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleSistema.Name = "gleSistema"
        Me.gleSistema.NullText = ""
        Me.gleSistema.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'DIRECCION
        '
        Me.DIRECCION.Caption = "Dirección"
        Me.DIRECCION.FieldName = "DIRECCION"
        Me.DIRECCION.Name = "DIRECCION"
        Me.DIRECCION.Visible = True
        Me.DIRECCION.VisibleIndex = 3
        Me.DIRECCION.Width = 187
        '
        'COMUNA_ID
        '
        Me.COMUNA_ID.Caption = "Comuna"
        Me.COMUNA_ID.ColumnEdit = Me.gleComuna
        Me.COMUNA_ID.FieldName = "COMUNA_ID"
        Me.COMUNA_ID.Name = "COMUNA_ID"
        Me.COMUNA_ID.Visible = True
        Me.COMUNA_ID.VisibleIndex = 4
        Me.COMUNA_ID.Width = 130
        '
        'gleComuna
        '
        Me.gleComuna.AutoHeight = False
        Me.gleComuna.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleComuna.Name = "gleComuna"
        Me.gleComuna.NullText = ""
        Me.gleComuna.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'CODIGO_PREVIRED
        '
        Me.CODIGO_PREVIRED.Caption = "Codigo PREVIRED"
        Me.CODIGO_PREVIRED.FieldName = "CODIGO_PREVIRED"
        Me.CODIGO_PREVIRED.Name = "CODIGO_PREVIRED"
        Me.CODIGO_PREVIRED.Visible = True
        Me.CODIGO_PREVIRED.VisibleIndex = 5
        Me.CODIGO_PREVIRED.Width = 93
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcIsapres
        Me.GridView1.Name = "GridView1"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Location = New System.Drawing.Point(728, 8)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(96, 24)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir Reporte"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcIsapres
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(10, 10, 100, 100)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de La República", "ISAPRES", "[Date Printed]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Sistema Integral de Gestión Administrativa (SIGA)", "", "Página número [Page #]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'frmIsapres
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 453)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.gdcIsapres)
        Me.Name = "frmIsapres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de ISAPRES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcIsapres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleIsapres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleComuna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvComuna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim isapres As Mantenedor

    Private Sub frmIsapres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isapres = New Mantenedor
        GeneraDataViews()
        llenarComuna()
        llenarSistema()
        gdcIsapres.DataSource = isapres.recuperarIsapres

    End Sub

    Public Sub llenarComuna()
        gleComuna.ViewType = Repository.GridLookUpViewType.GridView
        gleComuna.View.OptionsBehavior.AutoPopulateColumns = False
        gleComuna.DataSource = dvComuna
        gleComuna.DisplayMember = "DESCRIPCION"

        Dim col1 As GridColumn = gleComuna.View.Columns.AddField("COMUNA_ID")
        col1.VisibleIndex = 0
        col1.Caption = "ID Comuna"
        col1.Visible = False

        Dim col2 As GridColumn = gleComuna.View.Columns.AddField("DESCRIPCION")
        col2.VisibleIndex = 1
        col2.Caption = "Dirección"

        gleComuna.ValueMember = "COMUNA_ID"
        gleComuna.View.BestFitColumns()
        gleComuna.PopupFormWidth = 250
    End Sub

    Public Sub llenarSistema()
        gleSistema.ViewType = Repository.GridLookUpViewType.GridView
        gleSistema.View.OptionsBehavior.AutoPopulateColumns = False
        gleSistema.DataSource = dvSistema
        gleSistema.DisplayMember = "DESCRIPCION"

        Dim col1 As GridColumn = gleSistema.View.Columns.AddField("SISTEMA_PREV_ID")
        col1.VisibleIndex = 0
        col1.Caption = "ID Sistema"
        col1.Visible = False

        Dim col2 As GridColumn = gleSistema.View.Columns.AddField("DESCRIPCION")
        col2.VisibleIndex = 1
        col2.Caption = "Descripcion"

        gleSistema.ValueMember = "SISTEMA_PREV_ID"
        gleSistema.View.BestFitColumns()
        gleSistema.PopupFormWidth = 250
    End Sub

    Private Sub GeneraDataViews()
        Dim da As SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
        Dim ds1 As New DataSet
        Dim ds2 As New DataSet


        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_COMUNA, conn))
        da.Fill(ds1, Tablas.GEN_COMUNA)
        Dim dvmComuna As New DataViewManager(ds1)
        dvComuna = dvmComuna.CreateDataView(ds1.Tables(Tablas.GEN_COMUNA))

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_SISTEMA, conn))
        da.Fill(ds2, Tablas.RH_REM_SISTEMA_PREVISIONAL)
        Dim dvmsistema As New DataViewManager(ds2)
        dvSistema = dvmsistema.CreateDataView(ds2.Tables(Tablas.RH_REM_SISTEMA_PREVISIONAL))


    End Sub

    Private Sub gdvDetalleIsapres_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvDetalleIsapres.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gdvDetalleIsapres_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvDetalleIsapres.RowUpdated
        If isapres.actualizarIsapres Then
            gdcIsapres.Refresh()
            repositorio.RefreshDatos("ISAPRE")
        End If
    End Sub

    Private Sub gdvDetalleIsapres_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvDetalleIsapres.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        view.SetRowCellValue(e.RowHandle, "ORGANIZACION_ID", Comun.ArgoConfiguracion.OrganizacionID)
        view.SetRowCellValue(e.RowHandle, "ISAPRE_ALIAS", 0)
    End Sub




    Private Sub gdvDetalleIsapres_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvDetalleIsapres.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                Try
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                    view.DeleteRow(view.FocusedRowHandle)
                    isapres.actualizarIsapres()
                    gdcIsapres.Refresh()
                    MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)
                    repositorio.RefreshDatos("ISAPRE")
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al intentar eliminar el registro " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If

            gdcIsapres.DataSource = isapres.recuperarIsapres
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
