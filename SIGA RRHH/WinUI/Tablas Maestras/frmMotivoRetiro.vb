Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmMotivoRetiro
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
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents gdcRetiro As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalleRetiro As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents checkClasifica As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colMOTIVO_RETIRO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMOTIVO_RETIRO_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCLASIFICACION_DIRPES As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMotivoRetiro))
        Me.gdcRetiro = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleRetiro = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMOTIVO_RETIRO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMOTIVO_RETIRO_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colCLASIFICACION_DIRPES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.checkClasifica = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.gdcRetiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleRetiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkClasifica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcRetiro
        '
        Me.gdcRetiro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcRetiro.Location = New System.Drawing.Point(16, 72)
        Me.gdcRetiro.MainView = Me.gdvDetalleRetiro
        Me.gdcRetiro.Name = "gdcRetiro"
        Me.gdcRetiro.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtDescripcion, Me.checkClasifica})
        Me.gdcRetiro.Size = New System.Drawing.Size(824, 352)
        Me.gdcRetiro.TabIndex = 0
        Me.gdcRetiro.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleRetiro, Me.GridView1})
        '
        'gdvDetalleRetiro
        '
        Me.gdvDetalleRetiro.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMOTIVO_RETIRO_ID, Me.colMOTIVO_RETIRO_ALIAS, Me.colDESCRIPCION, Me.colCLASIFICACION_DIRPES})
        Me.gdvDetalleRetiro.GridControl = Me.gdcRetiro
        Me.gdvDetalleRetiro.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvDetalleRetiro.Name = "gdvDetalleRetiro"
        Me.gdvDetalleRetiro.NewItemRowText = "Nuevo Registro"
        Me.gdvDetalleRetiro.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'colMOTIVO_RETIRO_ID
        '
        Me.colMOTIVO_RETIRO_ID.Caption = "Id MOTIVO RETIRO"
        Me.colMOTIVO_RETIRO_ID.FieldName = "MOTIVO_RETIRO_ID"
        Me.colMOTIVO_RETIRO_ID.Name = "colMOTIVO_RETIRO_ID"
        '
        'colMOTIVO_RETIRO_ALIAS
        '
        Me.colMOTIVO_RETIRO_ALIAS.Caption = "ALIAS MOTIVO RETIRO"
        Me.colMOTIVO_RETIRO_ALIAS.FieldName = "MOTIVO_RETIRO_ALIAS"
        Me.colMOTIVO_RETIRO_ALIAS.Name = "colMOTIVO_RETIRO_ALIAS"
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "Descripción"
        Me.colDESCRIPCION.ColumnEdit = Me.txtDescripcion
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 0
        Me.colDESCRIPCION.Width = 529
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoHeight = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Name = "txtDescripcion"
        '
        'colCLASIFICACION_DIRPES
        '
        Me.colCLASIFICACION_DIRPES.Caption = "Clasificación DIRPES"
        Me.colCLASIFICACION_DIRPES.ColumnEdit = Me.checkClasifica
        Me.colCLASIFICACION_DIRPES.FieldName = "CLASIFICACION_DIRPES"
        Me.colCLASIFICACION_DIRPES.Name = "colCLASIFICACION_DIRPES"
        Me.colCLASIFICACION_DIRPES.Visible = True
        Me.colCLASIFICACION_DIRPES.VisibleIndex = 1
        Me.colCLASIFICACION_DIRPES.Width = 274
        '
        'checkClasifica
        '
        Me.checkClasifica.AutoHeight = False
        Me.checkClasifica.Name = "checkClasifica"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcRetiro
        Me.GridView1.Name = "GridView1"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Location = New System.Drawing.Point(696, 16)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(128, 23)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir Reporte"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcRetiro
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de La República", "", "[Date Printed]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Sistema Integral de Gestión Administrativa (SIGA)", "", "Página Número  [Page #]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'frmMotivoRetiro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 446)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.gdcRetiro)
        Me.Name = "frmMotivoRetiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Motivo de Retiro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcRetiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleRetiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkClasifica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Retiro As Mantenedor

    Private Sub MotivoRetiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Retiro = New Mantenedor
        gdcRetiro.DataSource = Retiro.recuperarRetiro()
    End Sub


    Private Sub gdvDetalleRetiro_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvDetalleRetiro.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub



    Private Sub gdvDetalleRetiro_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvDetalleRetiro.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                Try
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                    view.DeleteRow(view.FocusedRowHandle)
                    Retiro.actualizarRetiros()
                    gdcRetiro.Refresh()
                    MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)
                    repositorio.RefreshDatos("MotivoRetiro")
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al intentar eliminar el registro " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If

            gdcRetiro.DataSource = Retiro.recuperarRetiro
        End If
    End Sub

    Private Sub gdvDetalleRetiro_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvDetalleRetiro.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        'view.SetRowCellValue(e.RowHandle, "ORGANIZACION_ID", Comun.ArgoConfiguracion.OrganizacionID)
        view.SetRowCellValue(e.RowHandle, "MOTIVO_RETIRO_ALIAS", 1)
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


    Private Sub gdvDetalleRetiro_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvDetalleRetiro.RowUpdated
        If Retiro.actualizarRetiros Then
            gdcRetiro.Refresh()
            repositorio.RefreshDatos("MotivoRetiro")
        End If
    End Sub
End Class
