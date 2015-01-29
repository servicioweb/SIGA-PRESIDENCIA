Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmHistoriaEventosAdministrativos
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
    Friend WithEvents gpcEncabezado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gleRut As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblAno As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dvPeriodo As System.Data.DataView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gdcHistoriaEventoAdmin As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalleHistoriaEventoAdmin As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnEmiteDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents prsHistoriaEventosAdmin As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents colEMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEVENTO_ADMINISTRATIVO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_EVENTO_ADMIN_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_TERMINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMOTIVO_SOLICITUD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRESOLUCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSUARIO As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistoriaEventosAdministrativos))
        Me.gpcEncabezado = New DevExpress.XtraEditors.GroupControl()
        Me.btnEmiteDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.gleRut = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.dvPeriodo = New System.Data.DataView()
        Me.gdcHistoriaEventoAdmin = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleHistoriaEventoAdmin = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEVENTO_ADMINISTRATIVO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPO_EVENTO_ADMIN_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_INICIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_TERMINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMOTIVO_SOLICITUD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRESOLUCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSUARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.prsHistoriaEventosAdmin = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcEncabezado.SuspendLayout()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcHistoriaEventoAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleHistoriaEventoAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prsHistoriaEventosAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcEncabezado
        '
        Me.gpcEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcEncabezado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcEncabezado.AppearanceCaption.Options.UseFont = True
        Me.gpcEncabezado.Controls.Add(Me.btnEmiteDetalle)
        Me.gpcEncabezado.Controls.Add(Me.gleRut)
        Me.gpcEncabezado.Controls.Add(Me.luePeriodo)
        Me.gpcEncabezado.Controls.Add(Me.lblEmpleado)
        Me.gpcEncabezado.Controls.Add(Me.lblAno)
        Me.gpcEncabezado.Location = New System.Drawing.Point(8, 16)
        Me.gpcEncabezado.Name = "gpcEncabezado"
        Me.gpcEncabezado.Size = New System.Drawing.Size(800, 104)
        Me.gpcEncabezado.TabIndex = 1
        Me.gpcEncabezado.Text = "Identificación Empleado"
        '
        'btnEmiteDetalle
        '
        Me.btnEmiteDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEmiteDetalle.Location = New System.Drawing.Point(512, 48)
        Me.btnEmiteDetalle.Name = "btnEmiteDetalle"
        Me.btnEmiteDetalle.Size = New System.Drawing.Size(240, 23)
        Me.btnEmiteDetalle.TabIndex = 12
        Me.btnEmiteDetalle.Text = "Emite Detalle"
        '
        'gleRut
        '
        Me.gleRut.EditValue = ""
        Me.gleRut.Location = New System.Drawing.Point(120, 64)
        Me.gleRut.Name = "gleRut"
        Me.gleRut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleRut.Properties.View = Me.GridLookUpEdit1View
        Me.gleRut.Size = New System.Drawing.Size(352, 20)
        Me.gleRut.TabIndex = 5
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(120, 40)
        Me.luePeriodo.Name = "luePeriodo"
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(160, 20)
        Me.luePeriodo.TabIndex = 2
        '
        'lblEmpleado
        '
        Me.lblEmpleado.Location = New System.Drawing.Point(40, 68)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(64, 16)
        Me.lblEmpleado.TabIndex = 1
        Me.lblEmpleado.Text = "Empleado"
        Me.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAno
        '
        Me.lblAno.Location = New System.Drawing.Point(56, 44)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(48, 16)
        Me.lblAno.TabIndex = 0
        Me.lblAno.Text = "Año"
        Me.lblAno.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gdcHistoriaEventoAdmin
        '
        Me.gdcHistoriaEventoAdmin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcHistoriaEventoAdmin.Location = New System.Drawing.Point(8, 128)
        Me.gdcHistoriaEventoAdmin.MainView = Me.gdvDetalleHistoriaEventoAdmin
        Me.gdcHistoriaEventoAdmin.Name = "gdcHistoriaEventoAdmin"
        Me.gdcHistoriaEventoAdmin.Size = New System.Drawing.Size(800, 304)
        Me.gdcHistoriaEventoAdmin.TabIndex = 2
        Me.gdcHistoriaEventoAdmin.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleHistoriaEventoAdmin, Me.GridView1})
        '
        'gdvDetalleHistoriaEventoAdmin
        '
        Me.gdvDetalleHistoriaEventoAdmin.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvDetalleHistoriaEventoAdmin.Appearance.FooterPanel.Options.UseFont = True
        Me.gdvDetalleHistoriaEventoAdmin.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEMPLEADO_ID, Me.colEVENTO_ADMINISTRATIVO_ID, Me.colTIPO_EVENTO_ADMIN_ID, Me.colDESCRIPCION, Me.colFECHA_INICIO, Me.colFECHA_TERMINO, Me.colDIAS, Me.colMOTIVO_SOLICITUD, Me.colRESOLUCION, Me.colUSUARIO})
        Me.gdvDetalleHistoriaEventoAdmin.GridControl = Me.gdcHistoriaEventoAdmin
        Me.gdvDetalleHistoriaEventoAdmin.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvDetalleHistoriaEventoAdmin.Name = "gdvDetalleHistoriaEventoAdmin"
        Me.gdvDetalleHistoriaEventoAdmin.OptionsView.ColumnAutoWidth = False
        Me.gdvDetalleHistoriaEventoAdmin.OptionsView.ShowFooter = True
        '
        'colEMPLEADO_ID
        '
        Me.colEMPLEADO_ID.Caption = "Id Empleado"
        Me.colEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.colEMPLEADO_ID.Name = "colEMPLEADO_ID"
        Me.colEMPLEADO_ID.OptionsColumn.ReadOnly = True
        '
        'colEVENTO_ADMINISTRATIVO_ID
        '
        Me.colEVENTO_ADMINISTRATIVO_ID.Caption = "ID Evento Admin"
        Me.colEVENTO_ADMINISTRATIVO_ID.FieldName = "EVENTO_ADMINISTRATIVO_ID"
        Me.colEVENTO_ADMINISTRATIVO_ID.Name = "colEVENTO_ADMINISTRATIVO_ID"
        Me.colEVENTO_ADMINISTRATIVO_ID.OptionsColumn.ReadOnly = True
        '
        'colTIPO_EVENTO_ADMIN_ID
        '
        Me.colTIPO_EVENTO_ADMIN_ID.Caption = "ID Tipo Evento"
        Me.colTIPO_EVENTO_ADMIN_ID.FieldName = "TIPO_EVENTO_ADMIN_ID"
        Me.colTIPO_EVENTO_ADMIN_ID.Name = "colTIPO_EVENTO_ADMIN_ID"
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "Evento Administrativo"
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.OptionsColumn.ReadOnly = True
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 0
        Me.colDESCRIPCION.Width = 192
        '
        'colFECHA_INICIO
        '
        Me.colFECHA_INICIO.Caption = "Fecha Inicio"
        Me.colFECHA_INICIO.FieldName = "FECHA_INICIO"
        Me.colFECHA_INICIO.Name = "colFECHA_INICIO"
        Me.colFECHA_INICIO.OptionsColumn.ReadOnly = True
        Me.colFECHA_INICIO.Visible = True
        Me.colFECHA_INICIO.VisibleIndex = 1
        Me.colFECHA_INICIO.Width = 89
        '
        'colFECHA_TERMINO
        '
        Me.colFECHA_TERMINO.Caption = "Fecha Término"
        Me.colFECHA_TERMINO.FieldName = "FECHA_TERMINO"
        Me.colFECHA_TERMINO.Name = "colFECHA_TERMINO"
        Me.colFECHA_TERMINO.OptionsColumn.ReadOnly = True
        Me.colFECHA_TERMINO.Visible = True
        Me.colFECHA_TERMINO.VisibleIndex = 2
        Me.colFECHA_TERMINO.Width = 92
        '
        'colDIAS
        '
        Me.colDIAS.Caption = "Días"
        Me.colDIAS.FieldName = "DIAS"
        Me.colDIAS.Name = "colDIAS"
        Me.colDIAS.OptionsColumn.ReadOnly = True
        Me.colDIAS.SummaryItem.DisplayFormat = "Total Días: {0:n1}"
        Me.colDIAS.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colDIAS.Visible = True
        Me.colDIAS.VisibleIndex = 3
        Me.colDIAS.Width = 110
        '
        'colMOTIVO_SOLICITUD
        '
        Me.colMOTIVO_SOLICITUD.Caption = "Motivo Solicitud"
        Me.colMOTIVO_SOLICITUD.FieldName = "MOTIVO_SOLICITUD"
        Me.colMOTIVO_SOLICITUD.Name = "colMOTIVO_SOLICITUD"
        Me.colMOTIVO_SOLICITUD.OptionsColumn.ReadOnly = True
        Me.colMOTIVO_SOLICITUD.Visible = True
        Me.colMOTIVO_SOLICITUD.VisibleIndex = 4
        Me.colMOTIVO_SOLICITUD.Width = 192
        '
        'colRESOLUCION
        '
        Me.colRESOLUCION.Caption = "Resolución"
        Me.colRESOLUCION.FieldName = "RESOLUCION"
        Me.colRESOLUCION.Name = "colRESOLUCION"
        Me.colRESOLUCION.Visible = True
        Me.colRESOLUCION.VisibleIndex = 5
        Me.colRESOLUCION.Width = 199
        '
        'colUSUARIO
        '
        Me.colUSUARIO.Caption = "Emitido Por"
        Me.colUSUARIO.FieldName = "USUARIO"
        Me.colUSUARIO.Name = "colUSUARIO"
        Me.colUSUARIO.Visible = True
        Me.colUSUARIO.VisibleIndex = 6
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcHistoriaEventoAdmin
        Me.GridView1.Name = "GridView1"
        '
        'prsHistoriaEventosAdmin
        '
        Me.prsHistoriaEventosAdmin.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcHistoriaEventoAdmin
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de la República", "Historia de Eventos Administrativos", "Fecha Emisiòn:[Date Printed]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Emitido Por:[User Name]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"", "", "Página: [Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.prsHistoriaEventosAdmin
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prsHistoriaEventosAdmin
        '
        'frmHistoriaEventosAdministrativos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(824, 446)
        Me.Controls.Add(Me.gdcHistoriaEventoAdmin)
        Me.Controls.Add(Me.gpcEncabezado)
        Me.Name = "frmHistoriaEventosAdministrativos"
        Me.Text = "Hstoria Eventos Administrativos del Empleado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcEncabezado.ResumeLayout(False)
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcHistoriaEventoAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleHistoriaEventoAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prsHistoriaEventosAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private empleado As empleado

    Private Sub frmHistoriaEventosAdministrativos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        repositorio.Show()
        llenarEmpleado()
        llenarPeriodos()
        empleado = New Empleado
    End Sub
    Public Sub llenarEmpleado()
        'gleRut.DataBindings.Add("EditValue", repositorio.dvEmpleadoVista, "EMPLEADO_ID")
        gleRut.Properties.ViewType = Repository.GridLookUpViewType.GridView
        gleRut.Properties.View.OptionsBehavior.AutoPopulateColumns = False
        gleRut.Properties.DataSource = repositorio.dvEmpleadoVista
        gleRut.Properties.DisplayMember = "NOMBRE_COMPLETO"

        Dim col1 As GridColumn = gleRut.Properties.View.Columns.AddField("RUT")
        col1.VisibleIndex = 0
        col1.Caption = "RUT"

        Dim col2 As GridColumn = gleRut.Properties.View.Columns.AddField("APELLIDO_PATERNO")
        col2.VisibleIndex = 1
        col2.Caption = "Apellido Paterno"

        Dim col3 As GridColumn = gleRut.Properties.View.Columns.AddField("APELLIDO_MATERNO")
        col3.VisibleIndex = 2
        col3.Caption = "Apellido Materno"

        Dim col4 As GridColumn = gleRut.Properties.View.Columns.AddField("NOMBRES")
        col4.VisibleIndex = 3
        col4.Caption = "Nombres"

        Dim col5 As GridColumn = gleRut.Properties.View.Columns.AddField("DESC_CALIDAD_JURIDICA")
        col5.VisibleIndex = 5
        col5.Caption = "Calidad Jurídica"
        col5.Visible = True

        Dim col6 As GridColumn = gleRut.Properties.View.Columns.AddField("DESC_ESTADO")
        col6.VisibleIndex = 4
        col6.Caption = "Estado"

        Dim col7 As GridColumn = gleRut.Properties.View.Columns.AddField("NOMBRE_COMPLETO")
        col7.VisibleIndex = 6
        col7.Caption = "Nombre Completo"
        col7.Visible = False

        gleRut.Properties.ValueMember = "EMPLEADO_ID"

        gleRut.Properties.View.BestFitColumns()
        gleRut.Properties.PopupFormWidth = 600

        gleRut.Text = ""
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
    Private Sub gleRut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gleRut.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                empleado = New Empleado(CType(gleRut.EditValue, Long))
                refrescarGrilla()
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al cargar datos de historia eventos administrativos. ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub
    Private Sub refrescarGrilla()
        gdcHistoriaEventoAdmin.DataSource = empleado.dvHistoriaEventosAdminEmpleado(empleado.ID, luePeriodo.EditValue)
    End Sub

    Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        refrescarGrilla()
    End Sub
    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "Empleado: " & empleado.nombreCompleto & "(Año " & luePeriodo.EditValue & ") "
        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)
    End Sub

    Private Sub btnEmiteDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmiteDetalle.Click
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
    End Sub
End Class
