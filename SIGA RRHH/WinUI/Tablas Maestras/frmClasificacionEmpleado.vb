Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmClasificacionEmpleado
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
    Friend WithEvents gdcClasificacion As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalleClasificacion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents colORGANIZACION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCLASIFICACION_EMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCLASIFICACION_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTAMENTO_DIPRES_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTAMENTO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAPLICA_LEY3551 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colES_PROFESIONAL As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClasificacionEmpleado))
        Me.gdcClasificacion = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleClasificacion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colORGANIZACION_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCLASIFICACION_EMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCLASIFICACION_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colESTAMENTO_DIPRES_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTAMENTO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAPLICA_LEY3551 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colES_PROFESIONAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.gdcClasificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleClasificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcClasificacion
        '
        Me.gdcClasificacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcClasificacion.Location = New System.Drawing.Point(16, 64)
        Me.gdcClasificacion.MainView = Me.gdvDetalleClasificacion
        Me.gdcClasificacion.Name = "gdcClasificacion"
        Me.gdcClasificacion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtDescripcion})
        Me.gdcClasificacion.Size = New System.Drawing.Size(824, 424)
        Me.gdcClasificacion.TabIndex = 0
        Me.gdcClasificacion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleClasificacion, Me.GridView1})
        '
        'gdvDetalleClasificacion
        '
        Me.gdvDetalleClasificacion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colORGANIZACION_ID, Me.colCLASIFICACION_EMPLEADO_ID, Me.colCLASIFICACION_ALIAS, Me.colDESCRIPCION, Me.colESTAMENTO_DIPRES_ID, Me.colESTAMENTO_ID, Me.colAPLICA_LEY3551, Me.colES_PROFESIONAL})
        Me.gdvDetalleClasificacion.GridControl = Me.gdcClasificacion
        Me.gdvDetalleClasificacion.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvDetalleClasificacion.Name = "gdvDetalleClasificacion"
        Me.gdvDetalleClasificacion.NewItemRowText = "Nuevo Registro"
        Me.gdvDetalleClasificacion.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'colORGANIZACION_ID
        '
        Me.colORGANIZACION_ID.Caption = "Id ORGANIZACION"
        Me.colORGANIZACION_ID.FieldName = "ORGANIZACION_ID"
        Me.colORGANIZACION_ID.Name = "colORGANIZACION_ID"
        '
        'colCLASIFICACION_EMPLEADO_ID
        '
        Me.colCLASIFICACION_EMPLEADO_ID.Caption = "ID CLASIFICACION_EMPLEADO"
        Me.colCLASIFICACION_EMPLEADO_ID.FieldName = "CLASIFICACION_EMPLEADO_ID"
        Me.colCLASIFICACION_EMPLEADO_ID.Name = "colCLASIFICACION_EMPLEADO_ID"
        '
        'colCLASIFICACION_ALIAS
        '
        Me.colCLASIFICACION_ALIAS.Caption = "CLASIFICACION ALIAS"
        Me.colCLASIFICACION_ALIAS.FieldName = "CLASIFICACION_ALIAS"
        Me.colCLASIFICACION_ALIAS.Name = "colCLASIFICACION_ALIAS"
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "Descripción"
        Me.colDESCRIPCION.ColumnEdit = Me.txtDescripcion
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 0
        Me.colDESCRIPCION.Width = 256
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoHeight = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Name = "txtDescripcion"
        '
        'colESTAMENTO_DIPRES_ID
        '
        Me.colESTAMENTO_DIPRES_ID.Caption = "ID Estamento DIPRES"
        Me.colESTAMENTO_DIPRES_ID.FieldName = "ESTAMENTO_DIPRES_ID"
        Me.colESTAMENTO_DIPRES_ID.Name = "colESTAMENTO_DIPRES_ID"
        Me.colESTAMENTO_DIPRES_ID.Visible = True
        Me.colESTAMENTO_DIPRES_ID.VisibleIndex = 1
        Me.colESTAMENTO_DIPRES_ID.Width = 136
        '
        'colESTAMENTO_ID
        '
        Me.colESTAMENTO_ID.Caption = "ID Estamento"
        Me.colESTAMENTO_ID.FieldName = "ESTAMENTO_ID"
        Me.colESTAMENTO_ID.Name = "colESTAMENTO_ID"
        Me.colESTAMENTO_ID.Visible = True
        Me.colESTAMENTO_ID.VisibleIndex = 2
        Me.colESTAMENTO_ID.Width = 117
        '
        'colAPLICA_LEY3551
        '
        Me.colAPLICA_LEY3551.Caption = "Ley 3551"
        Me.colAPLICA_LEY3551.FieldName = "APLICA_LEY3551"
        Me.colAPLICA_LEY3551.Name = "colAPLICA_LEY3551"
        Me.colAPLICA_LEY3551.Visible = True
        Me.colAPLICA_LEY3551.VisibleIndex = 3
        Me.colAPLICA_LEY3551.Width = 100
        '
        'colES_PROFESIONAL
        '
        Me.colES_PROFESIONAL.Caption = "Profesional"
        Me.colES_PROFESIONAL.FieldName = "ES_PROFESIONAL"
        Me.colES_PROFESIONAL.Name = "colES_PROFESIONAL"
        Me.colES_PROFESIONAL.Visible = True
        Me.colES_PROFESIONAL.VisibleIndex = 4
        Me.colES_PROFESIONAL.Width = 223
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcClasificacion
        Me.GridView1.Name = "GridView1"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Location = New System.Drawing.Point(720, 16)
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
        Me.PrintableComponentLink1.Component = Me.gdcClasificacion
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de La República", "", "[Date Printed]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Sistema Integral de Gestión Administrativa (SIGA)", "", "Página Número  [Page #]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'frmClasificacionEmpleado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 517)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.gdcClasificacion)
        Me.Name = "frmClasificacionEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Clasificación Empleado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcClasificacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleClasificacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Clasificacion As Mantenedor

    Private Sub frmClasificacionEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clasificacion = New Mantenedor
        gdcClasificacion.DataSource = Clasificacion.recuperarClasificacion
    End Sub

    Private Sub gdvDetalleClasificacion_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvDetalleClasificacion.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gdvDetalleClasificacion_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvDetalleClasificacion.RowUpdated
        If Clasificacion.actualizarClasificacion Then
            gdcClasificacion.Refresh()
            repositorio.RefreshDatos("ClasificacionEmpleado")
        End If
    End Sub

    Private Sub gdvDetalleClasificacion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvDetalleClasificacion.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                Try
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                    view.DeleteRow(view.FocusedRowHandle)
                    Clasificacion.actualizarClasificacion()
                    gdcClasificacion.Refresh()
                    MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)
                    repositorio.RefreshDatos("ClasificacionEmpleado")
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al intentar eliminar el registro " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If

            gdcClasificacion.DataSource = Clasificacion.recuperarClasificacion
        End If
    End Sub

    Private Sub gdvDetalleClasificacion_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvDetalleClasificacion.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        view.SetRowCellValue(e.RowHandle, "ORGANIZACION_ID", Comun.ArgoConfiguracion.OrganizacionID)
        view.SetRowCellValue(e.RowHandle, "CLASIFICACION_ALIAS", 0)
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
