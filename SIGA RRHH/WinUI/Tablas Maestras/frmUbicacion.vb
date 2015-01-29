Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base


Public Class frmUbicacion
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
    Friend WithEvents gdcUbicacion As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gdvDetelleUbicacion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dvRegion As System.Data.DataView
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gleRegion As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents colORGANIZACION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUBICACION_FISICA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUBICACION_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREGION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUbicacion))
        Me.gdcUbicacion = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetelleUbicacion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colORGANIZACION_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUBICACION_FISICA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUBICACION_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colREGION_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleRegion = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dvRegion = New System.Data.DataView()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.gdcUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetelleUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleRegion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvRegion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcUbicacion
        '
        Me.gdcUbicacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcUbicacion.Location = New System.Drawing.Point(24, 64)
        Me.gdcUbicacion.MainView = Me.gdvDetelleUbicacion
        Me.gdcUbicacion.Name = "gdcUbicacion"
        Me.gdcUbicacion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.gleRegion})
        Me.gdcUbicacion.Size = New System.Drawing.Size(798, 332)
        Me.gdcUbicacion.TabIndex = 0
        Me.gdcUbicacion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetelleUbicacion, Me.GridView1})
        '
        'gdvDetelleUbicacion
        '
        Me.gdvDetelleUbicacion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colORGANIZACION_ID, Me.colUBICACION_FISICA_ID, Me.colUBICACION_ALIAS, Me.colREGION_ID, Me.colDESCRIPCION})
        Me.gdvDetelleUbicacion.GridControl = Me.gdcUbicacion
        Me.gdvDetelleUbicacion.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvDetelleUbicacion.Name = "gdvDetelleUbicacion"
        Me.gdvDetelleUbicacion.NewItemRowText = "Nuevo Registro"
        Me.gdvDetelleUbicacion.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'colORGANIZACION_ID
        '
        Me.colORGANIZACION_ID.Caption = "Id Organizacion"
        Me.colORGANIZACION_ID.FieldName = "ORGANIZACION_ID"
        Me.colORGANIZACION_ID.Name = "colORGANIZACION_ID"
        '
        'colUBICACION_FISICA_ID
        '
        Me.colUBICACION_FISICA_ID.Caption = "UBICACION FISICA ID"
        Me.colUBICACION_FISICA_ID.FieldName = "UBICACION_FISICA_ID"
        Me.colUBICACION_FISICA_ID.Name = "colUBICACION_FISICA_ID"
        '
        'colUBICACION_ALIAS
        '
        Me.colUBICACION_ALIAS.Caption = "UBICACION ALIAS"
        Me.colUBICACION_ALIAS.FieldName = "UBICACION_ALIAS"
        Me.colUBICACION_ALIAS.Name = "colUBICACION_ALIAS"
        '
        'colREGION_ID
        '
        Me.colREGION_ID.Caption = "ID REGION"
        Me.colREGION_ID.ColumnEdit = Me.gleRegion
        Me.colREGION_ID.FieldName = "REGION_ID"
        Me.colREGION_ID.Name = "colREGION_ID"
        Me.colREGION_ID.Visible = True
        Me.colREGION_ID.VisibleIndex = 0
        '
        'gleRegion
        '
        Me.gleRegion.AutoHeight = False
        Me.gleRegion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleRegion.Name = "gleRegion"
        Me.gleRegion.NullText = ""
        Me.gleRegion.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "Descripcion"
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 1
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcUbicacion
        Me.GridView1.Name = "GridView1"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Location = New System.Drawing.Point(712, 16)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(104, 23)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir Reporte"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcUbicacion
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de La República", "", "[Date Printed]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Sistema Integral de Gestión Administrativa (SIGA)", "", "Página Número [Page #]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'frmUbicacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(846, 433)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.gdcUbicacion)
        Me.Name = "frmUbicacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Ubicación Física"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetelleUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleRegion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvRegion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ubicacion As Mantenedor

    Private Sub frmUbicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ubicacion = New Mantenedor
        GeneraDataViews()
        llenarRegion()
        gdcUbicacion.DataSource = ubicacion.recuperarUbicacion
    End Sub

    Public Sub llenarRegion()
        gleRegion.ViewType = Repository.GridLookUpViewType.GridView
        gleRegion.View.OptionsBehavior.AutoPopulateColumns = False
        gleRegion.DataSource = dvRegion
        gleRegion.DisplayMember = "DESCRIPCION"

        Dim col1 As GridColumn = gleRegion.View.Columns.AddField("REGION_ID")
        col1.VisibleIndex = 0
        col1.Caption = "ID Region"
        col1.Visible = False

        Dim col2 As GridColumn = gleRegion.View.Columns.AddField("DESCRIPCION")
        col2.VisibleIndex = 1
        col2.Caption = "Descripcion"

        gleRegion.ValueMember = "REGION_ID"
        gleRegion.View.BestFitColumns()
        gleRegion.PopupFormWidth = 250
    End Sub

    Private Sub GeneraDataViews()
        Dim da As SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
        Dim ds1 As New DataSet


        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_REGIONES, conn))
        da.Fill(ds1, Tablas.GEN_REGION)
        Dim dvmregion As New DataViewManager(ds1)
        dvRegion = dvmregion.CreateDataView(ds1.Tables(Tablas.GEN_REGION))


    End Sub


    Private Sub gdvDetelleUbicacion_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvDetelleUbicacion.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gdvDetelleUbicacion_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvDetelleUbicacion.RowUpdated
        If ubicacion.actualizarUbicacion Then
            gdcUbicacion.Refresh()
            repositorio.RefreshDatos("UbicacionFisica")
        End If

    End Sub

    Private Sub gdvDetelleUbicacion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvDetelleUbicacion.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                Try
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                    view.DeleteRow(view.FocusedRowHandle)
                    ubicacion.actualizarUbicacion()
                    gdcUbicacion.Refresh()
                    MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)
                    repositorio.RefreshDatos("UbicacionFisica")
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al intentar eliminar el registro " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If

            gdcUbicacion.DataSource = ubicacion.recuperarUbicacion
        End If

    End Sub

    Private Sub gdvDetelleUbicacion_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvDetelleUbicacion.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        view.SetRowCellValue(e.RowHandle, "ORGANIZACION_ID", Comun.ArgoConfiguracion.OrganizacionID)
        view.SetRowCellValue(e.RowHandle, "UBICACION_ALIAS", 0)

    End Sub
    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "Departamentos"
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
