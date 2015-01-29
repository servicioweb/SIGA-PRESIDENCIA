Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmAPV
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
    Friend WithEvents gdcAPV As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalleAPV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ORGANIZACION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APV_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APV_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APV_RUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APV_DV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CODIGO_PREVIRED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtRut As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAPV))
        Me.gdcAPV = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleAPV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ORGANIZACION_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.APV_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.APV_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.APV_RUT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtRut = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.APV_DV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CODIGO_PREVIRED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCodigo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.gdcAPV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleAPV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcAPV
        '
        Me.gdcAPV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcAPV.Location = New System.Drawing.Point(24, 56)
        Me.gdcAPV.MainView = Me.gdvDetalleAPV
        Me.gdcAPV.Name = "gdcAPV"
        Me.gdcAPV.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtDescripcion, Me.txtRut, Me.txtCodigo})
        Me.gdcAPV.Size = New System.Drawing.Size(808, 400)
        Me.gdcAPV.TabIndex = 0
        Me.gdcAPV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleAPV, Me.GridView1})
        '
        'gdvDetalleAPV
        '
        Me.gdvDetalleAPV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ORGANIZACION_ID, Me.APV_ID, Me.APV_ALIAS, Me.DESCRIPCION, Me.APV_RUT, Me.APV_DV, Me.CODIGO_PREVIRED})
        Me.gdvDetalleAPV.GridControl = Me.gdcAPV
        Me.gdvDetalleAPV.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvDetalleAPV.Name = "gdvDetalleAPV"
        Me.gdvDetalleAPV.NewItemRowText = "Nuevo Registro"
        Me.gdvDetalleAPV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'ORGANIZACION_ID
        '
        Me.ORGANIZACION_ID.Caption = "ID ORGANIZACION"
        Me.ORGANIZACION_ID.FieldName = "ORGANIZACION_ID"
        Me.ORGANIZACION_ID.Name = "ORGANIZACION_ID"
        '
        'APV_ID
        '
        Me.APV_ID.Caption = "Id APV"
        Me.APV_ID.FieldName = "APV_ID"
        Me.APV_ID.Name = "APV_ID"
        '
        'APV_ALIAS
        '
        Me.APV_ALIAS.Caption = "Alias APV"
        Me.APV_ALIAS.FieldName = "APV_ALIAS"
        Me.APV_ALIAS.Name = "APV_ALIAS"
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.Caption = "Descripción"
        Me.DESCRIPCION.ColumnEdit = Me.txtDescripcion
        Me.DESCRIPCION.FieldName = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.Visible = True
        Me.DESCRIPCION.VisibleIndex = 0
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoHeight = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Name = "txtDescripcion"
        '
        'APV_RUT
        '
        Me.APV_RUT.Caption = "RUT APV"
        Me.APV_RUT.ColumnEdit = Me.txtRut
        Me.APV_RUT.FieldName = "APV_RUT"
        Me.APV_RUT.Name = "APV_RUT"
        Me.APV_RUT.Visible = True
        Me.APV_RUT.VisibleIndex = 1
        '
        'txtRut
        '
        Me.txtRut.AutoHeight = False
        Me.txtRut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRut.Name = "txtRut"
        '
        'APV_DV
        '
        Me.APV_DV.Caption = "APV DV"
        Me.APV_DV.FieldName = "APV_DV"
        Me.APV_DV.Name = "APV_DV"
        Me.APV_DV.Visible = True
        Me.APV_DV.VisibleIndex = 2
        '
        'CODIGO_PREVIRED
        '
        Me.CODIGO_PREVIRED.Caption = "Código PREVIRED"
        Me.CODIGO_PREVIRED.ColumnEdit = Me.txtCodigo
        Me.CODIGO_PREVIRED.FieldName = "CODIGO_PREVIRED"
        Me.CODIGO_PREVIRED.Name = "CODIGO_PREVIRED"
        Me.CODIGO_PREVIRED.Visible = True
        Me.CODIGO_PREVIRED.VisibleIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.AutoHeight = False
        Me.txtCodigo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigo.Name = "txtCodigo"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcAPV
        Me.GridView1.Name = "GridView1"
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
        Me.PrintableComponentLink1.Component = Me.gdcAPV
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de La República", "", "[Date Printed]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Sistema Integral de Gestión Administrativa (SIGA)", "", "Página Número  [Page #]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'frmAPV
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 517)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.gdcAPV)
        Me.Name = "frmAPV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de APV"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcAPV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleAPV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private APV As Mantenedor

    '''<remarks>
    ''' frmAPV_Load iniclializa la instacia del DataSet y establece el acceso a la fuente de origen del control gdcAPV.
    ''' </remarks>

    Private Sub frmAPV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        APV = New Mantenedor
        gdcAPV.DataSource = APV.recuperarAPV
    End Sub

    Private Sub gdvDetalleAPV_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvDetalleAPV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gdvDetalleAPV_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvDetalleAPV.RowUpdated
        If APV.actualizarAPV Then
            gdcAPV.Refresh()
            repositorio.RefreshDatos("APV")
        End If
    End Sub

    Private Sub gdvDetalleAPV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvDetalleAPV.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                Try
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                    view.DeleteRow(view.FocusedRowHandle)
                    APV.actualizarAPV()
                    gdcAPV.Refresh()
                    MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)
                    repositorio.RefreshDatos("APV")
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al intentar eliminar el registro " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If

            gdcAPV.DataSource = APV.recuperarAPV
        End If
    End Sub

    Private Sub gdvDetalleAPV_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvDetalleAPV.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        view.SetRowCellValue(e.RowHandle, "ORGANIZACION_ID", Comun.ArgoConfiguracion.OrganizacionID)
        view.SetRowCellValue(e.RowHandle, "APV_ALIAS", 0)
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
