Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmGeneraEmpleadoBonoModernizacion
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
    Friend WithEvents txtEstadoPeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents dvPeriodo As System.Data.DataView
    Friend WithEvents gdcBonoModernizacion As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gdvDetalleBonos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BONO_MODERNIZACION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BASE_BONO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents INSTITUCIONAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COLECTIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gleRut As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnGenera As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dvEmpleadoVista As System.Data.DataView
    Friend WithEvents FECHA_ING_INSTITUCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ANO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnGeneraAsignaciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Progreso As System.Windows.Forms.ProgressBar
    Friend WithEvents txtBase As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtInstitucional As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtColectivo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtTotal As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents USUARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_MODIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpcEncabezado = New DevExpress.XtraEditors.GroupControl
        Me.Progreso = New System.Windows.Forms.ProgressBar
        Me.btnGeneraAsignaciones = New DevExpress.XtraEditors.SimpleButton
        Me.btnGenera = New DevExpress.XtraEditors.SimpleButton
        Me.txtEstadoPeriodo = New DevExpress.XtraEditors.TextEdit
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.dvPeriodo = New System.Data.DataView
        Me.gdcBonoModernizacion = New DevExpress.XtraGrid.GridControl
        Me.gdvDetalleBonos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.BONO_MODERNIZACION_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.EMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gleRut = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ANO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FECHA_ING_INSTITUCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DIAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BASE_BONO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtBase = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.INSTITUCIONAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtInstitucional = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.COLECTIVO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtColectivo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.TOTAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtTotal = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.USUARIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FECHA_MODIFICACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.dvEmpleadoVista = New System.Data.DataView
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcEncabezado.SuspendLayout()
        CType(Me.txtEstadoPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcBonoModernizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleBonos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleRut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInstitucional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtColectivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEmpleadoVista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcEncabezado
        '
        Me.gpcEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcEncabezado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcEncabezado.AppearanceCaption.Options.UseFont = True
        Me.gpcEncabezado.Controls.Add(Me.Progreso)
        Me.gpcEncabezado.Controls.Add(Me.btnGeneraAsignaciones)
        Me.gpcEncabezado.Controls.Add(Me.btnGenera)
        Me.gpcEncabezado.Controls.Add(Me.txtEstadoPeriodo)
        Me.gpcEncabezado.Controls.Add(Me.luePeriodo)
        Me.gpcEncabezado.Controls.Add(Me.lblPeriodo)
        Me.gpcEncabezado.Location = New System.Drawing.Point(8, 16)
        Me.gpcEncabezado.Name = "gpcEncabezado"
        Me.gpcEncabezado.Size = New System.Drawing.Size(704, 128)
        Me.gpcEncabezado.TabIndex = 1
        Me.gpcEncabezado.Text = "Período"
        '
        'Progreso
        '
        Me.Progreso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Progreso.Location = New System.Drawing.Point(24, 88)
        Me.Progreso.Name = "Progreso"
        Me.Progreso.Size = New System.Drawing.Size(616, 23)
        Me.Progreso.TabIndex = 7
        '
        'btnGeneraAsignaciones
        '
        Me.btnGeneraAsignaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGeneraAsignaciones.Location = New System.Drawing.Point(384, 56)
        Me.btnGeneraAsignaciones.Name = "btnGeneraAsignaciones"
        Me.btnGeneraAsignaciones.Size = New System.Drawing.Size(256, 23)
        Me.btnGeneraAsignaciones.TabIndex = 6
        Me.btnGeneraAsignaciones.Text = "Generar &Asignaciones Base Bono Modernización"
        '
        'btnGenera
        '
        Me.btnGenera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenera.Location = New System.Drawing.Point(384, 24)
        Me.btnGenera.Name = "btnGenera"
        Me.btnGenera.Size = New System.Drawing.Size(256, 23)
        Me.btnGenera.TabIndex = 5
        Me.btnGenera.Text = "&Generar Factores Anuales"
        '
        'txtEstadoPeriodo
        '
        Me.txtEstadoPeriodo.Enabled = False
        Me.txtEstadoPeriodo.Location = New System.Drawing.Point(240, 40)
        Me.txtEstadoPeriodo.Name = "txtEstadoPeriodo"
        '
        'txtEstadoPeriodo.Properties
        '
        Me.txtEstadoPeriodo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtEstadoPeriodo.Properties.Appearance.Options.UseFont = True
        Me.txtEstadoPeriodo.Size = New System.Drawing.Size(96, 20)
        Me.txtEstadoPeriodo.TabIndex = 4
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(120, 40)
        Me.luePeriodo.Name = "luePeriodo"
        '
        'luePeriodo.Properties
        '
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(112, 20)
        Me.luePeriodo.TabIndex = 2
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(32, 44)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(72, 16)
        Me.lblPeriodo.TabIndex = 0
        Me.lblPeriodo.Text = "Año Proceso"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gdcBonoModernizacion
        '
        Me.gdcBonoModernizacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'gdcBonoModernizacion.EmbeddedNavigator
        '
        Me.gdcBonoModernizacion.EmbeddedNavigator.Name = ""
        Me.gdcBonoModernizacion.Location = New System.Drawing.Point(8, 152)
        Me.gdcBonoModernizacion.MainView = Me.gdvDetalleBonos
        Me.gdcBonoModernizacion.Name = "gdcBonoModernizacion"
        Me.gdcBonoModernizacion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.gleRut, Me.txtBase, Me.txtInstitucional, Me.txtColectivo, Me.txtTotal})
        Me.gdcBonoModernizacion.Size = New System.Drawing.Size(704, 304)
        Me.gdcBonoModernizacion.TabIndex = 2
        Me.gdcBonoModernizacion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleBonos, Me.GridView1})
        '
        'gdvDetalleBonos
        '
        Me.gdvDetalleBonos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.BONO_MODERNIZACION_ID, Me.EMPLEADO_ID, Me.ANO, Me.FECHA_ING_INSTITUCION, Me.DIAS, Me.BASE_BONO, Me.INSTITUCIONAL, Me.COLECTIVO, Me.TOTAL, Me.USUARIO, Me.FECHA_MODIFICACION})
        Me.gdvDetalleBonos.GridControl = Me.gdcBonoModernizacion
        Me.gdvDetalleBonos.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvDetalleBonos.Name = "gdvDetalleBonos"
        Me.gdvDetalleBonos.NewItemRowText = "Nuevo Registro"
        Me.gdvDetalleBonos.OptionsNavigation.EnterMoveNextColumn = True
        Me.gdvDetalleBonos.OptionsSelection.MultiSelect = True
        Me.gdvDetalleBonos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'BONO_MODERNIZACION_ID
        '
        Me.BONO_MODERNIZACION_ID.Caption = "ID Bono"
        Me.BONO_MODERNIZACION_ID.FieldName = "BONO_MODERNIZACION_ID"
        Me.BONO_MODERNIZACION_ID.Name = "BONO_MODERNIZACION_ID"
        '
        'EMPLEADO_ID
        '
        Me.EMPLEADO_ID.Caption = "Empleado"
        Me.EMPLEADO_ID.ColumnEdit = Me.gleRut
        Me.EMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.EMPLEADO_ID.Name = "EMPLEADO_ID"
        Me.EMPLEADO_ID.Visible = True
        Me.EMPLEADO_ID.VisibleIndex = 0
        Me.EMPLEADO_ID.Width = 286
        '
        'gleRut
        '
        Me.gleRut.AutoHeight = False
        Me.gleRut.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleRut.Name = "gleRut"
        Me.gleRut.NullText = ""
        Me.gleRut.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'ANO
        '
        Me.ANO.Caption = "Año Proceso"
        Me.ANO.FieldName = "ANO"
        Me.ANO.Name = "ANO"
        '
        'FECHA_ING_INSTITUCION
        '
        Me.FECHA_ING_INSTITUCION.Caption = "Fecha Ing.Institución"
        Me.FECHA_ING_INSTITUCION.FieldName = "FECHA_ING_INSTITUCION"
        Me.FECHA_ING_INSTITUCION.Name = "FECHA_ING_INSTITUCION"
        Me.FECHA_ING_INSTITUCION.OptionsColumn.ReadOnly = True
        Me.FECHA_ING_INSTITUCION.Visible = True
        Me.FECHA_ING_INSTITUCION.VisibleIndex = 1
        Me.FECHA_ING_INSTITUCION.Width = 125
        '
        'DIAS
        '
        Me.DIAS.Caption = "Días"
        Me.DIAS.FieldName = "DIAS"
        Me.DIAS.Name = "DIAS"
        Me.DIAS.OptionsColumn.ReadOnly = True
        Me.DIAS.Visible = True
        Me.DIAS.VisibleIndex = 2
        Me.DIAS.Width = 57
        '
        'BASE_BONO
        '
        Me.BASE_BONO.Caption = "Base Bono"
        Me.BASE_BONO.ColumnEdit = Me.txtBase
        Me.BASE_BONO.FieldName = "BASE_BONO"
        Me.BASE_BONO.Name = "BASE_BONO"
        Me.BASE_BONO.Visible = True
        Me.BASE_BONO.VisibleIndex = 3
        Me.BASE_BONO.Width = 118
        '
        'txtBase
        '
        Me.txtBase.AutoHeight = False
        Me.txtBase.DisplayFormat.FormatString = "n3"
        Me.txtBase.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBase.EditFormat.FormatString = "n3"
        Me.txtBase.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBase.Name = "txtBase"
        '
        'INSTITUCIONAL
        '
        Me.INSTITUCIONAL.Caption = "Institucional"
        Me.INSTITUCIONAL.ColumnEdit = Me.txtInstitucional
        Me.INSTITUCIONAL.FieldName = "INSTITUCIONAL"
        Me.INSTITUCIONAL.Name = "INSTITUCIONAL"
        Me.INSTITUCIONAL.Visible = True
        Me.INSTITUCIONAL.VisibleIndex = 4
        Me.INSTITUCIONAL.Width = 118
        '
        'txtInstitucional
        '
        Me.txtInstitucional.AutoHeight = False
        Me.txtInstitucional.DisplayFormat.FormatString = "n3"
        Me.txtInstitucional.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInstitucional.EditFormat.FormatString = "n3"
        Me.txtInstitucional.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInstitucional.Name = "txtInstitucional"
        '
        'COLECTIVO
        '
        Me.COLECTIVO.Caption = "Colectivo"
        Me.COLECTIVO.ColumnEdit = Me.txtColectivo
        Me.COLECTIVO.FieldName = "COLECTIVO"
        Me.COLECTIVO.Name = "COLECTIVO"
        Me.COLECTIVO.Visible = True
        Me.COLECTIVO.VisibleIndex = 5
        Me.COLECTIVO.Width = 128
        '
        'txtColectivo
        '
        Me.txtColectivo.AutoHeight = False
        Me.txtColectivo.DisplayFormat.FormatString = "n3"
        Me.txtColectivo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtColectivo.EditFormat.FormatString = "n3"
        Me.txtColectivo.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtColectivo.Name = "txtColectivo"
        '
        'TOTAL
        '
        Me.TOTAL.Caption = "Total"
        Me.TOTAL.ColumnEdit = Me.txtTotal
        Me.TOTAL.FieldName = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.OptionsColumn.ReadOnly = True
        Me.TOTAL.Visible = True
        Me.TOTAL.VisibleIndex = 6
        '
        'txtTotal
        '
        Me.txtTotal.AutoHeight = False
        Me.txtTotal.DisplayFormat.FormatString = "n3"
        Me.txtTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotal.EditFormat.FormatString = "n3"
        Me.txtTotal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotal.Name = "txtTotal"
        '
        'USUARIO
        '
        Me.USUARIO.Caption = "Usuario"
        Me.USUARIO.FieldName = "USUARIO"
        Me.USUARIO.Name = "USUARIO"
        Me.USUARIO.OptionsColumn.ReadOnly = True
        '
        'FECHA_MODIFICACION
        '
        Me.FECHA_MODIFICACION.Caption = "Fecha Actualización"
        Me.FECHA_MODIFICACION.FieldName = "FECHA_MODIFICACION"
        Me.FECHA_MODIFICACION.Name = "FECHA_MODIFICACION"
        Me.FECHA_MODIFICACION.OptionsColumn.ReadOnly = True
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcBonoModernizacion
        Me.GridView1.Name = "GridView1"
        '
        'frmGeneraEmpleadoBonoModernizacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 462)
        Me.Controls.Add(Me.gdcBonoModernizacion)
        Me.Controls.Add(Me.gpcEncabezado)
        Me.Name = "frmGeneraEmpleadoBonoModernizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Genera Asignaciones Base"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcEncabezado.ResumeLayout(False)
        CType(Me.txtEstadoPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcBonoModernizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleBonos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleRut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInstitucional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtColectivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEmpleadoVista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim empleado As Empleado
    Dim parametroMensual, periodoHistorico As Periodo
    Dim estadoPeriodo As Boolean
    Dim filaSinError As Boolean


    Private Sub frmGeneraEmpleadoBonoModernizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'repositorio.Show()
        GeneraDataViews()
        llenarEmpleado()
        llenarPeriodos()
        empleado = New Empleado
        parametroMensual = New Periodo
        estadoPeriodo = parametroMensual.estadoPeriodo
        Progreso.Visible = False
        Dim fechaFinalIngreso As Date
        Dim diasMes As Integer = fechaFinalIngreso.DaysInMonth(parametroMensual.ano, parametroMensual.mes)
        fechaFinalIngreso = New Date(CInt(parametroMensual.ano), parametroMensual.mes, diasMes)

        btnGenera.Enabled = False
        btnGeneraAsignaciones.Enabled = False
    End Sub
    Private Sub llenarPeriodos()
        With luePeriodo
            With .Properties.Columns
                .Add(New LookUpColumnInfo("ANO", "Año Proceso", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        luePeriodo.Properties.DataSource = dvPeriodo
        luePeriodo.Properties.DisplayMember = "ANO"
        luePeriodo.Properties.NullText = ""
        luePeriodo.Properties.PopupWidth = 100
        luePeriodo.Properties.ValueMember = "ANO"
    End Sub
    Public Sub llenarEmpleado()
        gleRut.ViewType = Repository.GridLookUpViewType.GridView
        gleRut.View.OptionsBehavior.AutoPopulateColumns = False
        gleRut.DataSource = dvEmpleadoVista
        gleRut.DisplayMember = "NOMBRE_COMPLETO"

        Dim col1 As GridColumn = gleRut.View.Columns.AddField("RUT")
        col1.VisibleIndex = 0
        col1.Caption = "RUT"

        Dim col2 As GridColumn = gleRut.View.Columns.AddField("APELLIDO_PATERNO")
        col2.VisibleIndex = 1
        col2.Caption = "Apellido Paterno"

        Dim col3 As GridColumn = gleRut.View.Columns.AddField("APELLIDO_MATERNO")
        col3.VisibleIndex = 2
        col3.Caption = "Apellido Materno"

        Dim col4 As GridColumn = gleRut.View.Columns.AddField("NOMBRES")
        col4.VisibleIndex = 3
        col4.Caption = "Nombres"

        Dim col5 As GridColumn = gleRut.View.Columns.AddField("EMPLEADO_ID")
        col5.VisibleIndex = 4
        col5.Caption = "ID"
        col5.Visible = False

        Dim col6 As GridColumn = gleRut.View.Columns.AddField("NOMBRE_COMPLETO")
        col6.VisibleIndex = 5
        col6.Caption = "Nombre Completo"
        col6.Visible = False

        Dim col7 As GridColumn = gleRut.View.Columns.AddField("DESC_CALIDAD_JURIDICA")
        col7.VisibleIndex = 5
        col7.Caption = "Calidad Jurídica"
        col7.Visible = True

        Dim col8 As GridColumn = gleRut.View.Columns.AddField("DESC_ESTADO")
        col8.VisibleIndex = 5
        col8.Caption = "Estado"
        col8.Visible = True

        gleRut.ValueMember = "EMPLEADO_ID"
        gleRut.View.BestFitColumns()
        gleRut.PopupFormWidth = 600
    End Sub
    Private Sub GeneraDataViews()
        Dim dad As SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
        Dim ds1 As New DataSet
        Dim ds2 As New DataSet

        dad = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.VISTAS.SELECT_EMPLEADOS_TODOS_PLANTA_CONTRATA, conn))
        dad.Fill(ds1, "VW_MAESTRO_EMPLEADO")
        Dim dvmEmpleadosVista As New DataViewManager(ds1)
        dvEmpleadoVista = dvmEmpleadosVista.CreateDataView(ds1.Tables("VW_MAESTRO_EMPLEADO"))


        dad = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT DISTINCT ANO FROM RH_REM_PERIODO ORDER BY ANO DESC", conn))
        dad.Fill(ds2, Tablas.RH_REM_PERIODO)
        Dim dvmPeriodo As New DataViewManager(ds2)
        dvPeriodo = dvmPeriodo.CreateDataView(ds2.Tables(Tablas.RH_REM_PERIODO))
    End Sub
    Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
        Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
        refrescaDetalle(luePeriodo.EditValue)
        If Not IsNothing(row) Then
            'Si el estado del periodo es 0 (No Activo) deshabilita la grilla
            If estadoPeriodo = False Then
                gdcBonoModernizacion.Enabled = False
                txtEstadoPeriodo.Text = "INACTIVO"
                btnGenera.Enabled = False
                btnGeneraAsignaciones.Enabled = False
            Else
                gdcBonoModernizacion.Enabled = True
                txtEstadoPeriodo.Text = "ACTIVO"
                btnGenera.Enabled = True
                If gdvDetalleBonos.RowCount > 0 And parametroMensual.procesaBonoModernizacion Then
                    btnGeneraAsignaciones.Enabled = True
                Else
                    btnGeneraAsignaciones.Enabled = False
                End If
            End If
        End If
    End Sub
    Private Sub refrescaDetalle(ByVal ano As Integer)
        If luePeriodo.EditValue <> Nothing Then
            Try
                'gdcBonoModernizacion.DataSource = empleado.dvBonoModernizacion(CType(luePeriodo.EditValue, Integer))
                gdcBonoModernizacion.DataSource = Nothing
                gdcBonoModernizacion.DataSource = empleado.dvBonoModernizacion(ano)
                gdcBonoModernizacion.Refresh()
                gdcBonoModernizacion.Enabled = True
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al leer los datos de los bonos. ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub btnGenera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenera.Click
        Cursor.Current = Cursors.WaitCursor
        Dim respuesta As Boolean
        Try
            If gdvDetalleBonos.RowCount > 0 Then
                respuesta = MessageBox.Show("Este proceso elimina los factores actuales y los vuelve a generar. ¿Está seguro de continuar?", "Remuneraciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
            Else
                respuesta = True
            End If
            If respuesta Then
                refrescaDetalle(0)
                If empleado.generarPorcentajesBonoModernizacion(luePeriodo.EditValue, parametroMensual.porcentajeBaseBono, parametroMensual.porcentajeInstitucional, parametroMensual.porcentajeColectivo) Then
                    refrescaDetalle(luePeriodo.EditValue)
                    If gdvDetalleBonos.RowCount > 0 And parametroMensual.procesaBonoModernizacion Then
                        btnGeneraAsignaciones.Enabled = True
                    Else
                        btnGeneraAsignaciones.Enabled = False
                    End If

                    System.Windows.Forms.MessageBox.Show("Se generaron " + CType(gdvDetalleBonos.RowCount, String) + " registros para bono modernización", "Sistema de Remuneraciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Cursor.Current = Cursors.Default
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al generar los bonos." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub btnGeneraAsignaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneraAsignaciones.Click
        Dim meses() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
        Dim nombrePeriodo As String
        Dim inicio As Integer = parametroMensual.mes - 2
        Dim final As Integer = parametroMensual.mes - 1
        nombrePeriodo = meses(inicio - 1) + " " + CType(parametroMensual.ano, String)
        nombrePeriodo += " y " + meses(final - 1) + " " + CType(parametroMensual.ano, String)

        Dim cantidadRegistros As Integer = gdvDetalleBonos.GetSelectedRows().Length
        Dim excel As New Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook
        Dim thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        If cantidadRegistros <= 0 Then
            MessageBox.Show("Debe seleccionar a lo menos una fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Try
            If MessageBox.Show("¿Está seguro que desea iniciar el reproceso para mes " & nombrePeriodo & "?", "Remuneraciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Cursor.Current = Cursors.WaitCursor
                btnGeneraAsignaciones.Enabled = False
                If Not System.IO.File.Exists(Application.StartupPath & "\baseCalculo.xls") Then
                    MessageBox.Show("Archivo de cálculo no está instalado. Solicite asistencia.", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    thisThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
                    Exit Sub
                End If
                wb = excel.Workbooks.Open(Application.StartupPath & "\baseCalculo.xls")
                wb.Activate()
                Progreso.Visible = True
                Progreso.Minimum = 0
                Dim filas() As Integer = gdvDetalleBonos.GetSelectedRows()
                Dim anoProceso, mesProceso As Integer
                Progreso.Maximum = filas.Length - 1
                Dim reliquidaBonos As Boolean
                Dim origen As Integer = Comun.TiposDeDatos.TipoOrigenItem.BONO_MODERNIZACION
                Dim tipoProceso As String = Comun.TipoProceso.BONO_MODERNIZACION
                Dim empleado As empleado
                Dim i, j, k As Integer
                Dim tipoProcesoRemuneracionActual As String
                If parametroMensual.esProcesoSuplementario Then
                    tipoProcesoRemuneracionActual = Comun.TipoProceso.SUPLEMENTARIA_PLANTA_CONTRATA
                Else
                    tipoProcesoRemuneracionActual = Comun.TipoProceso.NORNAL_PLANTA_CONTRATA
                End If
                'excel.Visible = True
                For i = 0 To filas.Length - 1
                    Dim row As DataRow = gdvDetalleBonos.GetDataRow(filas(i))
                    Debug.WriteLine(row("EMPLEADO_ID"))
                    empleado = New empleado(row("EMPLEADO_ID"), True)
                    Try
                        reliquidaBonos = False
                        'Elimina las asignaciones correspondiente al proceso activo
                        empleado.EliminarMovimientoMensualEmpleado(parametroMensual.ID, empleado.ID, origen, tipoProceso)
                        Try
                            'Si empleado tiene factores para bono modernización y se encuentra inactivo, se genera 
                            'registro laboral con el periodo actual en caso que no tenga registro activo del periodo vigente
                            If empleado.estado = TiposDeDatos.TipoEstado.INACTIVO Then
                                empleado.crearAntecedenteLaboralParaBonoModernizacion(parametroMensual.ID, empleado.ID)
                            End If
                        Catch ex As Exception
                            Cursor.Current = Cursors.Default
                            MsgBox("Ha ocurrido un error al crear el nuevo registro laboral para el empleado " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                            thisThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
                            Exit Sub
                        End Try
                        'Realiza calculo para determinar montos de asignaciones que corresponden al periodo vigente
                        Remuneracion.calculaRemuneracion(empleado, wb, tipoProcesoRemuneracionActual, parametroMensual, reliquidaBonos)

                        'Genera los ítems para los dos meses históricos mas el actual
                        Dim generaItemBase As Boolean = False
                        Dim montoBonoDesempeno As Integer = 0
                        Dim montoBonoLey19553Art8 As Integer = 0
                        Dim MontoZonaExtrema40 As Integer = 0
                        Dim MontoZonaExtrema60 As Integer = 0
                        Dim MontoBonoZonaExtrema As Integer = 0
                        If empleado.generarItemsBonoModernizacion(row("EMPLEADO_ID"), parametroMensual.ID, parametroMensual.ano, parametroMensual.mes, _
                                            parametroMensual.itemBonoDesempenoMesActual, parametroMensual.itemBonoDesempenoMes1, _
                                            parametroMensual.itemBonoDesempenoMes2, parametroMensual.itemBonoLey19553Art8MesActual, _
                                            parametroMensual.itemBonoLey19553Art8Mes1, parametroMensual.itemBonoLey19553Art8Mes2, _
                                            parametroMensual.itemBonoDesctoBienestarMes1, parametroMensual.itemBonoDesctoBienestarMes2, _
                                            parametroMensual.porcentajeDesctoBienestar, empleado.datosPrevisionales.institucionID, empleado.datosSalud.institucionID, _
                                            row("BASE_BONO"), row("INSTITUCIONAL"), row("COLECTIVO"), row("TOTAL"), _
                                            parametroMensual.itemBonoDistribucionBase, parametroMensual.itemBonoDistribucionInstitucional, _
                                            parametroMensual.itemBonoDistribucionColectivo, empleado, tipoProceso, tipoProcesoRemuneracionActual, _
                                            parametroMensual.itemAsigLey19863Mes1, parametroMensual.itemAsigLey19863Mes2, parametroMensual.itemAsigLey19863MesActual, _
                                            generaItemBase, montoBonoDesempeno, montoBonoLey19553Art8, parametroMensual.aplicaAsignacionZona, _
                                            MontoZonaExtrema40, MontoZonaExtrema60, MontoBonoZonaExtrema) Then

                            mesProceso = parametroMensual.mes - 2
                            anoProceso = parametroMensual.ano
                            For j = 1 To 1
                                For k = 0 To 1
                                    reliquidaBonos = True
                                    periodoHistorico = New Periodo(anoProceso, mesProceso)
                                    empleado = New Empleado(row("EMPLEADO_ID"), periodoHistorico.ID)

                                    'Realiza calculo de los meses históricos para generar diferencias
                                    If empleado.validaEstadoEmpleadoBonoModernizacion(empleado, periodoHistorico) Then
                                        'If empleado.buscaInteger("SELECT DIAS_TRABAJADOS FROM  RH_REM_LIQUIDACION_ENC WHERE EMPLEADO_ID = " & row("EMPLEADO_ID") & " AND PERIODO_ID =" & periodoHistorico.ID) = 30 Then
                                        Remuneracion.calculaRemuneracion(empleado, wb, Comun.TipoProceso.NORNAL_PLANTA_CONTRATA, periodoHistorico, reliquidaBonos)
                                        empleado.CrearEmpleadoReliquidado(parametroMensual.ID, periodoHistorico.ID, empleado.ID, tipoProceso)
                                    End If
                                    mesProceso += 1
                                Next k
                                Windows.Forms.Application.DoEvents()
                            Next j
                        End If
                        Progreso.Value = i
                    Catch ex As Exception
                        Cursor.Current = Cursors.Default
                        MsgBox("Ha ocurrido un error al intentar grabar ítem para el empleado " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                Next i
                empleado.elimnaLiquidacionSinDetalle(parametroMensual.ID)
                Progreso.Visible = False
                System.Windows.Forms.MessageBox.Show("Cálculo Finalizado. Se han procesado " & cantidadRegistros & " de remuneraciones.", "Sistema de Remuneraciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
                excel.Quit()
                excel = Nothing
                btnGeneraAsignaciones.Enabled = True
                Cursor.Current = Cursors.Default
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            thisThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        End Try
    End Sub

    Private Sub gdvDetalleBonos_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvDetalleBonos.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gdvDetalleBonos_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvDetalleBonos.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        Dim nombreUsuario As String = empleado.buscaString("SELECT USER AS USUARIO")
        view.SetRowCellValue(e.RowHandle, "ANO", luePeriodo.EditValue)
        view.SetRowCellValue(e.RowHandle, "DIAS", 0)
        view.SetRowCellValue(e.RowHandle, "BASE_BONO", 0)
        view.SetRowCellValue(e.RowHandle, "INSTITUCIONAL", 0)
        view.SetRowCellValue(e.RowHandle, "COLECTIVO", 0)
        view.SetRowCellValue(e.RowHandle, "TOTAL", 0)
        view.SetRowCellValue(e.RowHandle, "USUARIO", nombreUsuario)
        view.SetRowCellValue(e.RowHandle, "FECHA_MODIFICACION", Date.UtcNow)
    End Sub

    Private Sub txtColectivo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtColectivo.Validating
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetalleBonos
        Dim total As Decimal
        total = view.GetRowCellValue(view.FocusedRowHandle, "BASE_BONO") + _
                view.GetRowCellValue(view.FocusedRowHandle, "INSTITUCIONAL") + _
                CType(view.EditingValue, Decimal)
        view.SetRowCellValue(view.FocusedRowHandle, "TOTAL", total)
    End Sub

    Private Sub txtBase_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtBase.Validating
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetalleBonos
        Dim total As Decimal
        total = view.GetRowCellValue(view.FocusedRowHandle, "COLECTIVO") + _
                view.GetRowCellValue(view.FocusedRowHandle, "INSTITUCIONAL") + _
                CType(view.EditingValue, Decimal)
        view.SetRowCellValue(view.FocusedRowHandle, "TOTAL", total)
    End Sub
    Private Sub txtInstitucional_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtInstitucional.Validating
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetalleBonos
        Dim total As Decimal
        total = view.GetRowCellValue(view.FocusedRowHandle, "COLECTIVO") + _
                view.GetRowCellValue(view.FocusedRowHandle, "BASE_BONO") + _
                CType(view.EditingValue, Decimal)
        view.SetRowCellValue(view.FocusedRowHandle, "TOTAL", total)
    End Sub
    Private Sub gdvDetalleBonos_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvDetalleBonos.RowUpdated
        Dim rows As System.Data.DataRowView = e.Row
        If rows.Row.RowState = DataRowState.Added And filaSinError Then
            Try
                empleado.crearEmpleadoBonoModernizacion(rows.Item("EMPLEADO_ID"), _
                                                        rows.Item("ANO"), _
                                                        rows.Item("DIAS"), _
                                                        rows.Item("BASE_BONO"), _
                                                        rows.Item("INSTITUCIONAL"), _
                                                        rows.Item("COLECTIVO"), _
                                                        rows.Item("FECHA_ING_INSTITUCION"), _
                                                        rows.Item("TOTAL"))
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al guardar el registro." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        Else
            If rows.Row.RowState = DataRowState.Modified And filaSinError Then
                empleado.actualizarDatosBonoModernizacion()
                gdcBonoModernizacion.Refresh()
            End If
        End If
    End Sub
    Private Sub gleRut_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gleRut.Validating
        Dim edit As DevExpress.XtraEditors.GridLookUpEdit = CType(sender, DevExpress.XtraEditors.GridLookUpEdit)
        Dim row As DataRow = edit.Properties.View.GetDataRow(edit.Properties.View.FocusedRowHandle)
        empleado = New empleado(CType(row("EMPLEADO_ID"), Long))

        If empleado.buscaInteger("SELECT BONO_MODERNIZACION_ID FROM RH_REM_BONO_MODERNIZACION WHERE EMPLEADO_ID=" & empleado.ID & " AND ANO=" & luePeriodo.EditValue) Then
            System.Windows.Forms.MessageBox.Show("Ya existe empleado " & empleado.nombreCompleto & " en tabla porcentaje de bono modernización para año " & luePeriodo.EditValue, "Sistema de Remuneraciones", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
            filaSinError = False
        Else
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetalleBonos
            view.SetRowCellValue(view.FocusedRowHandle, "FECHA_ING_INSTITUCION", empleado.datosLaborales.fechaIngresoInstitucion)
            'view.SetRowCellValue(view.FocusedRowHandle, "EMPLEADO_ID", CType(empleado.ID, Byte))
            Dim dias As Integer
            Dim base, institucional, colectivo As Decimal
            Try
                filaSinError = True
                empleado.generarEmpleadoPorcentajesBonoModernizacion(empleado.ID, luePeriodo.EditValue, parametroMensual.porcentajeBaseBono, parametroMensual.porcentajeInstitucional, parametroMensual.porcentajeColectivo, dias, base, institucional, colectivo)
                view.SetRowCellValue(view.FocusedRowHandle, "DIAS", dias)
                view.SetRowCellValue(view.FocusedRowHandle, "BASE_BONO", base)
                view.SetRowCellValue(view.FocusedRowHandle, "INSTITUCIONAL", institucional)
                view.SetRowCellValue(view.FocusedRowHandle, "COLECTIVO", colectivo)
                view.SetRowCellValue(view.FocusedRowHandle, "TOTAL", (colectivo + base + institucional))
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al generar los porcentajes para bono modernización." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub gdvDetalleBonos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvDetalleBonos.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                view.DeleteRow(view.FocusedRowHandle)
                Try
                    empleado.actualizarDatosBonoModernizacion()
                    gdcBonoModernizacion.Refresh()
                    MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al intentar eliminar el registro " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
        End If
    End Sub

    Private Sub gdvDetalleBonos_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gdvDetalleBonos.ValidateRow
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        Dim totalFactor As Integer = view.GetRowCellValue(e.RowHandle, view.Columns("TOTAL"))
        If totalFactor > 0 Then
            filaSinError = True
        Else
            filaSinError = False
            e.ErrorText = "Falta ingresar valores a las columnas"
            e.Valid = False
        End If
    End Sub
End Class
