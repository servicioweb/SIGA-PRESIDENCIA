Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmNivelEstudio
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
    Friend WithEvents gdcEstudios As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalleNivelEstudio As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents dvTipoEstudio As System.Data.DataView
    Friend WithEvents gleTipoEstudio As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents colORGANIZACION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNIVEL_ESTUDIO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNIVEL_ESTUDIO_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_NIVEL_ESTUDIO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAPLICA_ANTECEDENTE_CURRICULAR As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNivelEstudio))
        Me.gdcEstudios = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleNivelEstudio = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colORGANIZACION_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNIVEL_ESTUDIO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNIVEL_ESTUDIO_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colTIPO_NIVEL_ESTUDIO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleTipoEstudio = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAPLICA_ANTECEDENTE_CURRICULAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dvTipoEstudio = New System.Data.DataView()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.gdcEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleNivelEstudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleTipoEstudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvTipoEstudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcEstudios
        '
        Me.gdcEstudios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcEstudios.Location = New System.Drawing.Point(24, 64)
        Me.gdcEstudios.MainView = Me.gdvDetalleNivelEstudio
        Me.gdcEstudios.Name = "gdcEstudios"
        Me.gdcEstudios.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtDescripcion, Me.gleTipoEstudio})
        Me.gdcEstudios.Size = New System.Drawing.Size(808, 424)
        Me.gdcEstudios.TabIndex = 0
        Me.gdcEstudios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleNivelEstudio})
        '
        'gdvDetalleNivelEstudio
        '
        Me.gdvDetalleNivelEstudio.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colORGANIZACION_ID, Me.colNIVEL_ESTUDIO_ID, Me.colNIVEL_ESTUDIO_ALIAS, Me.colDESCRIPCION, Me.colTIPO_NIVEL_ESTUDIO_ID, Me.colAPLICA_ANTECEDENTE_CURRICULAR})
        Me.gdvDetalleNivelEstudio.GridControl = Me.gdcEstudios
        Me.gdvDetalleNivelEstudio.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvDetalleNivelEstudio.Name = "gdvDetalleNivelEstudio"
        Me.gdvDetalleNivelEstudio.NewItemRowText = "Nuevo registro"
        Me.gdvDetalleNivelEstudio.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'colORGANIZACION_ID
        '
        Me.colORGANIZACION_ID.Caption = "ID ORGANIZACION"
        Me.colORGANIZACION_ID.FieldName = "ORGANIZACION_ID"
        Me.colORGANIZACION_ID.Name = "colORGANIZACION_ID"
        '
        'colNIVEL_ESTUDIO_ID
        '
        Me.colNIVEL_ESTUDIO_ID.Caption = "ID NIVEL ESTUDIO"
        Me.colNIVEL_ESTUDIO_ID.FieldName = "NIVEL_ESTUDIO_ID"
        Me.colNIVEL_ESTUDIO_ID.Name = "colNIVEL_ESTUDIO_ID"
        '
        'colNIVEL_ESTUDIO_ALIAS
        '
        Me.colNIVEL_ESTUDIO_ALIAS.Caption = "ALIAS NIVEL ESTUDIO"
        Me.colNIVEL_ESTUDIO_ALIAS.FieldName = "NIVEL_ESTUDIO_ALIAS"
        Me.colNIVEL_ESTUDIO_ALIAS.Name = "colNIVEL_ESTUDIO_ALIAS"
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "Descripción"
        Me.colDESCRIPCION.ColumnEdit = Me.txtDescripcion
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 0
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoHeight = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Name = "txtDescripcion"
        '
        'colTIPO_NIVEL_ESTUDIO_ID
        '
        Me.colTIPO_NIVEL_ESTUDIO_ID.Caption = "Tipo Nivel Estudio"
        Me.colTIPO_NIVEL_ESTUDIO_ID.ColumnEdit = Me.gleTipoEstudio
        Me.colTIPO_NIVEL_ESTUDIO_ID.FieldName = "TIPO_NIVEL_ESTUDIO_ID"
        Me.colTIPO_NIVEL_ESTUDIO_ID.Name = "colTIPO_NIVEL_ESTUDIO_ID"
        Me.colTIPO_NIVEL_ESTUDIO_ID.Visible = True
        Me.colTIPO_NIVEL_ESTUDIO_ID.VisibleIndex = 1
        '
        'gleTipoEstudio
        '
        Me.gleTipoEstudio.AutoHeight = False
        Me.gleTipoEstudio.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleTipoEstudio.Name = "gleTipoEstudio"
        Me.gleTipoEstudio.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colAPLICA_ANTECEDENTE_CURRICULAR
        '
        Me.colAPLICA_ANTECEDENTE_CURRICULAR.Caption = "Antecedente Curricular"
        Me.colAPLICA_ANTECEDENTE_CURRICULAR.FieldName = "APLICA_ANTECEDENTE_CURRICULAR"
        Me.colAPLICA_ANTECEDENTE_CURRICULAR.Name = "colAPLICA_ANTECEDENTE_CURRICULAR"
        Me.colAPLICA_ANTECEDENTE_CURRICULAR.Visible = True
        Me.colAPLICA_ANTECEDENTE_CURRICULAR.VisibleIndex = 2
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Location = New System.Drawing.Point(712, 16)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(112, 23)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir Reporte"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcEstudios
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de La República  ", "", "[Date Printed]"}, New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Sistema Integral de Gestión Administrativa (SIGA)", "", "Página Número  [Page #]"}, New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'frmNivelEstudio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 517)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.gdcEstudios)
        Me.Name = "frmNivelEstudio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Nivel de Estudios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleNivelEstudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleTipoEstudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvTipoEstudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Estudios As Mantenedor

    Private Sub frmNivelEstudio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Estudios = New Mantenedor
        GeneraDataViews()
        llenarEstudio()
        gdcEstudios.DataSource = Estudios.recuperarEstudios
    End Sub

    Public Sub llenarEstudio()
        gleTipoEstudio.ViewType = Repository.GridLookUpViewType.GridView
        gleTipoEstudio.View.OptionsBehavior.AutoPopulateColumns = False
        gleTipoEstudio.DataSource = dvTipoEstudio
        gleTipoEstudio.DisplayMember = "DESCRIPCION"

        Dim col1 As GridColumn = gleTipoEstudio.View.Columns.AddField("TIPO_NIVEL_ESTUDIO_ID")
        col1.VisibleIndex = 0
        col1.Caption = "ID Nivel de Estudio"
        col1.Visible = False

        Dim col2 As GridColumn = gleTipoEstudio.View.Columns.AddField("DESCRIPCION")
        col2.VisibleIndex = 1
        col2.Caption = "Descripción"

        gleTipoEstudio.ValueMember = "TIPO_NIVEL_ESTUDIO_ID"
        gleTipoEstudio.View.BestFitColumns()
        gleTipoEstudio.PopupFormWidth = 250
    End Sub

    Private Sub GeneraDataViews()
        Dim da As SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
        Dim ds1 As New DataSet



        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_NIVEL_ESTUDIOS, conn))
        da.Fill(ds1, Tablas.RH_PER_TIPO_NIVEL_ESTUDIO)
        Dim dvmNivelEstudio As New DataViewManager(ds1)
        dvTipoEstudio = dvmNivelEstudio.CreateDataView(ds1.Tables(Tablas.RH_PER_TIPO_NIVEL_ESTUDIO))


    End Sub

    Private Sub gdvDetalleNivelEstudio_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvDetalleNivelEstudio.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gdvDetalleNivelEstudio_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvDetalleNivelEstudio.RowUpdated
        If Estudios.actualizarEstudios Then
            gdcEstudios.Refresh()
            repositorio.RefreshDatos("NivelEstudio")
        End If
    End Sub

    Private Sub gdvDetalleNivelEstudio_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvDetalleNivelEstudio.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                Try
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                    view.DeleteRow(view.FocusedRowHandle)
                    Estudios.actualizarEstudios()
                    gdcEstudios.Refresh()
                    MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)
                    repositorio.RefreshDatos("NivelEstudio")
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al intentar eliminar el registro " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If

            gdcEstudios.DataSource = Estudios.recuperarEstudios
        End If
    End Sub

    Private Sub gdvDetalleNivelEstudio_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvDetalleNivelEstudio.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        view.SetRowCellValue(e.RowHandle, "ORGANIZACION_ID", Comun.ArgoConfiguracion.OrganizacionID)
        view.SetRowCellValue(e.RowHandle, "NIVEL_ESTUDIO_ALIAS", 0)
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
