Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base


Public Class FrmCostoContable
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
    Friend WithEvents gdcCostoContable As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalleCostoContable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gpcPeriodo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblAno As System.Windows.Forms.Label
    Friend WithEvents dvPeriodo As System.Data.DataView
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents colORGANIZACION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCENTRO_COSTO_CONTAB_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCENTRO_COSTO_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO_REGISTRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colANO As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCostoContable))
        Me.gdcCostoContable = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleCostoContable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colORGANIZACION_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCENTRO_COSTO_CONTAB_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCENTRO_COSTO_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colESTADO_REGISTRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colANO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gpcPeriodo = New DevExpress.XtraEditors.GroupControl()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.dvPeriodo = New System.Data.DataView()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.gdcCostoContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleCostoContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcPeriodo.SuspendLayout()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcCostoContable
        '
        Me.gdcCostoContable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcCostoContable.Location = New System.Drawing.Point(16, 112)
        Me.gdcCostoContable.MainView = Me.gdvDetalleCostoContable
        Me.gdcCostoContable.Name = "gdcCostoContable"
        Me.gdcCostoContable.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtDescripcion})
        Me.gdcCostoContable.Size = New System.Drawing.Size(824, 300)
        Me.gdcCostoContable.TabIndex = 0
        Me.gdcCostoContable.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleCostoContable, Me.GridView1})
        '
        'gdvDetalleCostoContable
        '
        Me.gdvDetalleCostoContable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colORGANIZACION_ID, Me.colCENTRO_COSTO_CONTAB_ID, Me.colCENTRO_COSTO_ALIAS, Me.colDESCRIPCION, Me.colESTADO_REGISTRO, Me.colANO})
        Me.gdvDetalleCostoContable.GridControl = Me.gdcCostoContable
        Me.gdvDetalleCostoContable.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvDetalleCostoContable.Name = "gdvDetalleCostoContable"
        Me.gdvDetalleCostoContable.NewItemRowText = "Nuevo Registro"
        Me.gdvDetalleCostoContable.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'colORGANIZACION_ID
        '
        Me.colORGANIZACION_ID.Caption = "Id ORGANIZACION"
        Me.colORGANIZACION_ID.FieldName = "ORGANIZACION_ID"
        Me.colORGANIZACION_ID.Name = "colORGANIZACION_ID"
        '
        'colCENTRO_COSTO_CONTAB_ID
        '
        Me.colCENTRO_COSTO_CONTAB_ID.Caption = "ID CENTRO COSTO CONTABLE"
        Me.colCENTRO_COSTO_CONTAB_ID.FieldName = "CENTRO_COSTO_CONTAB_ID"
        Me.colCENTRO_COSTO_CONTAB_ID.Name = "colCENTRO_COSTO_CONTAB_ID"
        '
        'colCENTRO_COSTO_ALIAS
        '
        Me.colCENTRO_COSTO_ALIAS.Caption = "CENTRO COSTO ALIAS"
        Me.colCENTRO_COSTO_ALIAS.FieldName = "CENTRO_COSTO_ALIAS"
        Me.colCENTRO_COSTO_ALIAS.Name = "colCENTRO_COSTO_ALIAS"
        Me.colCENTRO_COSTO_ALIAS.Visible = True
        Me.colCENTRO_COSTO_ALIAS.VisibleIndex = 0
        Me.colCENTRO_COSTO_ALIAS.Width = 178
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "Descripción"
        Me.colDESCRIPCION.ColumnEdit = Me.txtDescripcion
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 1
        Me.colDESCRIPCION.Width = 414
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoHeight = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Name = "txtDescripcion"
        '
        'colESTADO_REGISTRO
        '
        Me.colESTADO_REGISTRO.Caption = "ESTADO REGISTRO"
        Me.colESTADO_REGISTRO.FieldName = "ESTADO_REGISTRO"
        Me.colESTADO_REGISTRO.Name = "colESTADO_REGISTRO"
        Me.colESTADO_REGISTRO.Width = 179
        '
        'colANO
        '
        Me.colANO.Caption = "Año"
        Me.colANO.FieldName = "ANO"
        Me.colANO.Name = "colANO"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcCostoContable
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
        Me.gpcPeriodo.TabIndex = 2
        Me.gpcPeriodo.Text = "Periodo"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Location = New System.Drawing.Point(704, 32)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(104, 23)
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
        Me.PrintableComponentLink1.Component = Me.gdcCostoContable
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de La República", "", "[Date Printed]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Sistema Integral de Gestión Administrativa (SIGA)", "", "Página Número  [Page #]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'FrmCostoContable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 441)
        Me.Controls.Add(Me.gpcPeriodo)
        Me.Controls.Add(Me.gdcCostoContable)
        Me.Name = "FrmCostoContable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Centro de Costo Contable"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcCostoContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleCostoContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private CostoContable As Mantenedor

    Private Sub FrmCostoContable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CostoContable = New Mantenedor
        llenarPeriodos()
        'gdcCostoContable.DataSource = CostoContable.recuperarCostoContable

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

    Private Sub gdvDetalleCostoContable_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvDetalleCostoContable.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction

    End Sub

    Private Sub gdvDetalleCostoContable_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvDetalleCostoContable.RowUpdated
        If CostoContable.actualizarCostoContable Then
            gdcCostoContable.Refresh()
        End If

    End Sub

    Private Sub gdvDetalleCostoContable_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvDetalleCostoContable.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                Try
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                    view.DeleteRow(view.FocusedRowHandle)
                    CostoContable.actualizarCostoContable()
                    gdcCostoContable.Refresh()
                    MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al intentar eliminar el registro " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If

            gdcCostoContable.DataSource = CostoContable.recuperarCostoContable(luePeriodo.EditValue)

        End If

    End Sub

    Private Sub gdvDetalleCostoContable_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvDetalleCostoContable.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        view.SetRowCellValue(e.RowHandle, "ORGANIZACION_ID", Comun.ArgoConfiguracion.OrganizacionID)
        view.SetRowCellValue(e.RowHandle, "ANO", luePeriodo.EditValue)
        view.SetRowCellValue(e.RowHandle, "ESTADO_REGISTRO", 1)


    End Sub

    Private Sub luePeriodo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        If luePeriodo.EditValue <> Nothing Then
            gdcCostoContable.DataSource = CostoContable.recuperarCostoContable(luePeriodo.EditValue)
        End If
    End Sub
    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = " "
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
