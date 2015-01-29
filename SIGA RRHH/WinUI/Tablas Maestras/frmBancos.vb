Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmBancos
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
    Friend WithEvents gdcBancos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetelleBancos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ORGANIZACION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BANCO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BANCO_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CODIGO_ASOCIADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ES_PRINCIPAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkPrincipal As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBancos))
        Me.gdcBancos = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetelleBancos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ORGANIZACION_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BANCO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BANCO_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CODIGO_ASOCIADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ES_PRINCIPAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkPrincipal = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.gdcBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetelleBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcBancos
        '
        Me.gdcBancos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcBancos.Location = New System.Drawing.Point(24, 64)
        Me.gdcBancos.MainView = Me.gdvDetelleBancos
        Me.gdcBancos.Name = "gdcBancos"
        Me.gdcBancos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkPrincipal})
        Me.gdcBancos.Size = New System.Drawing.Size(808, 440)
        Me.gdcBancos.TabIndex = 0
        Me.gdcBancos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetelleBancos, Me.GridView1})
        '
        'gdvDetelleBancos
        '
        Me.gdvDetelleBancos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ORGANIZACION_ID, Me.BANCO_ID, Me.BANCO_ALIAS, Me.DESCRIPCION, Me.CODIGO_ASOCIADO, Me.ES_PRINCIPAL})
        Me.gdvDetelleBancos.GridControl = Me.gdcBancos
        Me.gdvDetelleBancos.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvDetelleBancos.Name = "gdvDetelleBancos"
        Me.gdvDetelleBancos.NewItemRowText = "Nuevo Registro"
        Me.gdvDetelleBancos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'ORGANIZACION_ID
        '
        Me.ORGANIZACION_ID.Caption = "Id Organización"
        Me.ORGANIZACION_ID.FieldName = "ORGANIZACION_ID"
        Me.ORGANIZACION_ID.Name = "ORGANIZACION_ID"
        '
        'BANCO_ID
        '
        Me.BANCO_ID.Caption = "ID Banco"
        Me.BANCO_ID.FieldName = "BANCO_ID"
        Me.BANCO_ID.Name = "BANCO_ID"
        '
        'BANCO_ALIAS
        '
        Me.BANCO_ALIAS.Caption = "Banco Alias"
        Me.BANCO_ALIAS.FieldName = "BANCO_ALIAS"
        Me.BANCO_ALIAS.Name = "BANCO_ALIAS"
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.Caption = "Descripción"
        Me.DESCRIPCION.FieldName = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.Visible = True
        Me.DESCRIPCION.VisibleIndex = 0
        Me.DESCRIPCION.Width = 340
        '
        'CODIGO_ASOCIADO
        '
        Me.CODIGO_ASOCIADO.Caption = "Código Revired"
        Me.CODIGO_ASOCIADO.FieldName = "CODIGO_ASOCIADO"
        Me.CODIGO_ASOCIADO.Name = "CODIGO_ASOCIADO"
        Me.CODIGO_ASOCIADO.Visible = True
        Me.CODIGO_ASOCIADO.VisibleIndex = 1
        Me.CODIGO_ASOCIADO.Width = 216
        '
        'ES_PRINCIPAL
        '
        Me.ES_PRINCIPAL.Caption = "Convenio Depósito"
        Me.ES_PRINCIPAL.ColumnEdit = Me.chkPrincipal
        Me.ES_PRINCIPAL.FieldName = "ES_PRINCIPAL"
        Me.ES_PRINCIPAL.Name = "ES_PRINCIPAL"
        Me.ES_PRINCIPAL.Visible = True
        Me.ES_PRINCIPAL.VisibleIndex = 2
        Me.ES_PRINCIPAL.Width = 231
        '
        'chkPrincipal
        '
        Me.chkPrincipal.AutoHeight = False
        Me.chkPrincipal.Name = "chkPrincipal"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcBancos
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
        Me.btnImprimir.Text = "Imprmir Reporte"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcBancos
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de La República", "", "[Date Printed]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Sistema Integral de Gestión Administrativa (SIGA)", "", "Página Número  [Page #]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'frmBancos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 517)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.gdcBancos)
        Me.Name = "frmBancos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Bancos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcBancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetelleBancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private bancos As Mantenedor

    Private Sub frmBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bancos = New Mantenedor
        gdcBancos.DataSource = bancos.recuperarBancos
    End Sub

    Private Sub gdvDetelleBancos_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvDetelleBancos.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gdvDetelleBancos_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvDetelleBancos.RowUpdated
        If bancos.actualizarBancos Then
            gdcBancos.Refresh()
            repositorio.RefreshDatos("Banco")
        End If

    End Sub

    Private Sub gdvDetelleBancos_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvDetelleBancos.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        view.SetRowCellValue(e.RowHandle, "ORGANIZACION_ID", Comun.ArgoConfiguracion.OrganizacionID)
        view.SetRowCellValue(e.RowHandle, "BANCO_ALIAS", 0)

    End Sub

    Private Sub gdvDetelleBancos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvDetelleBancos.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                Try
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                    view.DeleteRow(view.FocusedRowHandle)
                    bancos.actualizarBancos()
                    gdcBancos.Refresh()
                    MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)
                    repositorio.RefreshDatos("Banco")
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al intentar eliminar el registro " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If

            gdcBancos.DataSource = bancos.recuperarBancos
        End If
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "Bancos"
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
