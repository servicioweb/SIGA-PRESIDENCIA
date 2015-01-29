Imports cl.presidencia.Argo.Reportes
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun

Imports System.Data.SqlClient
Imports System.IO
Public Class frmHistoriaViaticosPorMemo
    Inherits System.Windows.Forms.Form
    Private empleado As New Empleado

    Dim connectionString As String = Comun.ArgoConfiguracion.ConnectionString

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
    Friend WithEvents GC1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents luePeriodos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents dvPeriodo As System.Data.DataView
    Friend WithEvents gcResultado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dgcViaticosAsociados As DevExpress.XtraGrid.GridControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumMemorandum As System.Windows.Forms.TextBox
    Friend WithEvents APELLIDO_PATERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APELLIDO_MATERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOMBRES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvViaticosAsociados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnGeneraCheque As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumCheque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGeneraBoucher As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtChequeHasta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtChequeDesde As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnImprimirListado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents prnListadoViaticos As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumResolucion As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarResolucion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMontoCheque As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistoriaViaticosPorMemo))
        Me.GC1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnBuscarResolucion = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumResolucion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumMemorandum = New System.Windows.Forms.TextBox()
        Me.luePeriodos = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dvPeriodo = New System.Data.DataView()
        Me.gcResultado = New DevExpress.XtraEditors.GroupControl()
        Me.btnImprimirListado = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAnular = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtChequeHasta = New DevExpress.XtraEditors.TextEdit()
        Me.txtChequeDesde = New DevExpress.XtraEditors.TextEdit()
        Me.btnGeneraBoucher = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumCheque = New DevExpress.XtraEditors.TextEdit()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnGeneraCheque = New DevExpress.XtraEditors.SimpleButton()
        Me.dgcViaticosAsociados = New DevExpress.XtraGrid.GridControl()
        Me.gvViaticosAsociados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.APELLIDO_PATERNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.APELLIDO_MATERNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NOMBRES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMontoCheque = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.prnListadoViaticos = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GC1.SuspendLayout()
        CType(Me.luePeriodos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcResultado.SuspendLayout()
        CType(Me.txtChequeHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChequeDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumCheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgcViaticosAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvViaticosAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prnListadoViaticos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GC1
        '
        Me.GC1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GC1.AppearanceCaption.Options.UseFont = True
        Me.GC1.Controls.Add(Me.btnBuscarResolucion)
        Me.GC1.Controls.Add(Me.Label1)
        Me.GC1.Controls.Add(Me.txtNumResolucion)
        Me.GC1.Controls.Add(Me.Label2)
        Me.GC1.Controls.Add(Me.txtNumMemorandum)
        Me.GC1.Controls.Add(Me.luePeriodos)
        Me.GC1.Controls.Add(Me.lblPeriodo)
        Me.GC1.Controls.Add(Me.btnBuscar)
        Me.GC1.Location = New System.Drawing.Point(0, 0)
        Me.GC1.Name = "GC1"
        Me.GC1.Size = New System.Drawing.Size(928, 80)
        Me.GC1.TabIndex = 49
        Me.GC1.Text = "Criterios de Búsqueda"
        '
        'btnBuscarResolucion
        '
        Me.btnBuscarResolucion.Location = New System.Drawing.Point(408, 32)
        Me.btnBuscarResolucion.Name = "btnBuscarResolucion"
        Me.btnBuscarResolucion.Size = New System.Drawing.Size(68, 23)
        Me.btnBuscarResolucion.TabIndex = 105
        Me.btnBuscarResolucion.Text = "Buscar"
        Me.btnBuscarResolucion.ToolTip = "Búsca todos los viáticos asociados al Memorandum"
        Me.btnBuscarResolucion.ToolTipTitle = "Buscar"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(192, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Nº Resolución"
        '
        'txtNumResolucion
        '
        Me.txtNumResolucion.Location = New System.Drawing.Point(288, 32)
        Me.txtNumResolucion.Name = "txtNumResolucion"
        Me.txtNumResolucion.Size = New System.Drawing.Size(100, 20)
        Me.txtNumResolucion.TabIndex = 103
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(592, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Nº MEMO"
        Me.Label2.Visible = False
        '
        'txtNumMemorandum
        '
        Me.txtNumMemorandum.Location = New System.Drawing.Point(688, 32)
        Me.txtNumMemorandum.Name = "txtNumMemorandum"
        Me.txtNumMemorandum.Size = New System.Drawing.Size(100, 20)
        Me.txtNumMemorandum.TabIndex = 100
        Me.txtNumMemorandum.Visible = False
        '
        'luePeriodos
        '
        Me.luePeriodos.Location = New System.Drawing.Point(56, 32)
        Me.luePeriodos.Name = "luePeriodos"
        Me.luePeriodos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ANO", "Año", 20, DevExpress.Utils.FormatType.DateTime, "d", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Descending)})
        Me.luePeriodos.Size = New System.Drawing.Size(96, 20)
        Me.luePeriodos.TabIndex = 1
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(18, 35)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(24, 16)
        Me.lblPeriodo.TabIndex = 99
        Me.lblPeriodo.Text = "Año"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(808, 32)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(68, 23)
        Me.btnBuscar.TabIndex = 98
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.ToolTip = "Búsca todos los viáticos asociados al Memorandum"
        Me.btnBuscar.ToolTipTitle = "Buscar"
        Me.btnBuscar.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'gcResultado
        '
        Me.gcResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcResultado.Controls.Add(Me.btnImprimirListado)
        Me.gcResultado.Controls.Add(Me.btnAnular)
        Me.gcResultado.Controls.Add(Me.LabelControl3)
        Me.gcResultado.Controls.Add(Me.LabelControl4)
        Me.gcResultado.Controls.Add(Me.txtChequeHasta)
        Me.gcResultado.Controls.Add(Me.txtChequeDesde)
        Me.gcResultado.Controls.Add(Me.btnGeneraBoucher)
        Me.gcResultado.Controls.Add(Me.LabelControl2)
        Me.gcResultado.Controls.Add(Me.LabelControl1)
        Me.gcResultado.Controls.Add(Me.txtNumCheque)
        Me.gcResultado.Controls.Add(Me.dtFecha)
        Me.gcResultado.Controls.Add(Me.btnGeneraCheque)
        Me.gcResultado.Controls.Add(Me.dgcViaticosAsociados)
        Me.gcResultado.Location = New System.Drawing.Point(0, 79)
        Me.gcResultado.Name = "gcResultado"
        Me.gcResultado.Size = New System.Drawing.Size(928, 367)
        Me.gcResultado.TabIndex = 50
        '
        'btnImprimirListado
        '
        Me.btnImprimirListado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirListado.Location = New System.Drawing.Point(800, 336)
        Me.btnImprimirListado.Name = "btnImprimirListado"
        Me.btnImprimirListado.Size = New System.Drawing.Size(112, 23)
        Me.btnImprimirListado.TabIndex = 23
        Me.btnImprimirListado.Text = "Imprimir Listado"
        '
        'btnAnular
        '
        Me.btnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAnular.Location = New System.Drawing.Point(656, 336)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(112, 23)
        Me.btnAnular.TabIndex = 22
        Me.btnAnular.Text = "Anular"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Location = New System.Drawing.Point(512, 336)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl3.TabIndex = 21
        Me.LabelControl3.Text = "y"
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Location = New System.Drawing.Point(280, 342)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl4.TabIndex = 20
        Me.LabelControl4.Text = "Anular cheques entre:"
        '
        'txtChequeHasta
        '
        Me.txtChequeHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtChequeHasta.Location = New System.Drawing.Point(528, 336)
        Me.txtChequeHasta.Name = "txtChequeHasta"
        Me.txtChequeHasta.Size = New System.Drawing.Size(100, 20)
        Me.txtChequeHasta.TabIndex = 19
        '
        'txtChequeDesde
        '
        Me.txtChequeDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtChequeDesde.Location = New System.Drawing.Point(400, 336)
        Me.txtChequeDesde.Name = "txtChequeDesde"
        Me.txtChequeDesde.Size = New System.Drawing.Size(100, 20)
        Me.txtChequeDesde.TabIndex = 18
        '
        'btnGeneraBoucher
        '
        Me.btnGeneraBoucher.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGeneraBoucher.Enabled = False
        Me.btnGeneraBoucher.Location = New System.Drawing.Point(800, 304)
        Me.btnGeneraBoucher.Name = "btnGeneraBoucher"
        Me.btnGeneraBoucher.Size = New System.Drawing.Size(112, 23)
        Me.btnGeneraBoucher.TabIndex = 6
        Me.btnGeneraBoucher.Text = "Emitir boucher"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Location = New System.Drawing.Point(400, 310)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Número de cheque inicial"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Location = New System.Drawing.Point(8, 304)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(135, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Fecha de emisión de cheque"
        '
        'txtNumCheque
        '
        Me.txtNumCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNumCheque.Location = New System.Drawing.Point(528, 304)
        Me.txtNumCheque.Name = "txtNumCheque"
        Me.txtNumCheque.Size = New System.Drawing.Size(100, 20)
        Me.txtNumCheque.TabIndex = 3
        '
        'dtFecha
        '
        Me.dtFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtFecha.Location = New System.Drawing.Point(152, 304)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtFecha.TabIndex = 2
        '
        'btnGeneraCheque
        '
        Me.btnGeneraCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGeneraCheque.Enabled = False
        Me.btnGeneraCheque.Location = New System.Drawing.Point(656, 304)
        Me.btnGeneraCheque.Name = "btnGeneraCheque"
        Me.btnGeneraCheque.Size = New System.Drawing.Size(112, 24)
        Me.btnGeneraCheque.TabIndex = 1
        Me.btnGeneraCheque.Text = "Generar Cheques"
        Me.btnGeneraCheque.ToolTip = "Generar cheques para registros pendientes de pago"
        '
        'dgcViaticosAsociados
        '
        Me.dgcViaticosAsociados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgcViaticosAsociados.Location = New System.Drawing.Point(0, 16)
        Me.dgcViaticosAsociados.MainView = Me.gvViaticosAsociados
        Me.dgcViaticosAsociados.Name = "dgcViaticosAsociados"
        Me.dgcViaticosAsociados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtMontoCheque})
        Me.dgcViaticosAsociados.Size = New System.Drawing.Size(912, 280)
        Me.dgcViaticosAsociados.TabIndex = 0
        Me.dgcViaticosAsociados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvViaticosAsociados, Me.GridView1})
        '
        'gvViaticosAsociados
        '
        Me.gvViaticosAsociados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.APELLIDO_PATERNO, Me.APELLIDO_MATERNO, Me.NOMBRES, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn3, Me.GridColumn11})
        Me.gvViaticosAsociados.GridControl = Me.dgcViaticosAsociados
        Me.gvViaticosAsociados.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas"
        Me.gvViaticosAsociados.Name = "gvViaticosAsociados"
        Me.gvViaticosAsociados.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvViaticosAsociados.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvViaticosAsociados.OptionsSelection.EnableAppearanceHideSelection = False
        Me.gvViaticosAsociados.OptionsSelection.InvertSelection = True
        Me.gvViaticosAsociados.OptionsSelection.MultiSelect = True
        Me.gvViaticosAsociados.OptionsSelection.UseIndicatorForSelection = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Id Viatico"
        Me.GridColumn1.FieldName = "VIATICO_ID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.GridColumn1.Width = 73
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "VIATICO_DETALLE_ID"
        Me.GridColumn2.FieldName = "VIATICO_DETALLE_ID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.GridColumn2.Width = 95
        '
        'APELLIDO_PATERNO
        '
        Me.APELLIDO_PATERNO.Caption = "Apellido Paterno"
        Me.APELLIDO_PATERNO.FieldName = "APELLIDO_PATERNO"
        Me.APELLIDO_PATERNO.Name = "APELLIDO_PATERNO"
        Me.APELLIDO_PATERNO.OptionsColumn.AllowEdit = False
        Me.APELLIDO_PATERNO.OptionsColumn.ReadOnly = True
        Me.APELLIDO_PATERNO.Visible = True
        Me.APELLIDO_PATERNO.VisibleIndex = 0
        Me.APELLIDO_PATERNO.Width = 147
        '
        'APELLIDO_MATERNO
        '
        Me.APELLIDO_MATERNO.Caption = "Apellido Materno"
        Me.APELLIDO_MATERNO.FieldName = "APELLIDO_MATERNO"
        Me.APELLIDO_MATERNO.Name = "APELLIDO_MATERNO"
        Me.APELLIDO_MATERNO.OptionsColumn.AllowEdit = False
        Me.APELLIDO_MATERNO.OptionsColumn.ReadOnly = True
        Me.APELLIDO_MATERNO.Visible = True
        Me.APELLIDO_MATERNO.VisibleIndex = 1
        Me.APELLIDO_MATERNO.Width = 131
        '
        'NOMBRES
        '
        Me.NOMBRES.Caption = "Nombres"
        Me.NOMBRES.FieldName = "NOMBRES"
        Me.NOMBRES.Name = "NOMBRES"
        Me.NOMBRES.OptionsColumn.AllowEdit = False
        Me.NOMBRES.OptionsColumn.ReadOnly = True
        Me.NOMBRES.Visible = True
        Me.NOMBRES.VisibleIndex = 2
        Me.NOMBRES.Width = 90
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Desde"
        Me.GridColumn4.FieldName = "FECHA_INICIO"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 56
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Hasta"
        Me.GridColumn5.FieldName = "FECHA_TERMINO"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 56
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Nº Días"
        Me.GridColumn6.FieldName = "CANTIDAD_DIAS"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        Me.GridColumn6.Width = 72
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "País"
        Me.GridColumn7.FieldName = "PAIS_DESTINO"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 76
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Región"
        Me.GridColumn8.FieldName = "REGION_DESTINO"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        Me.GridColumn8.Width = 125
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Monto"
        Me.GridColumn9.ColumnEdit = Me.txtMontoCheque
        Me.GridColumn9.FieldName = "MONTO"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        Me.GridColumn9.Width = 66
        '
        'txtMontoCheque
        '
        Me.txtMontoCheque.AutoHeight = False
        Me.txtMontoCheque.Mask.EditMask = "n0"
        Me.txtMontoCheque.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoCheque.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoCheque.Name = "txtMontoCheque"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Estado"
        Me.GridColumn10.FieldName = "STR_ESTADO_VIATICO"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 10
        Me.GridColumn10.Width = 182
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "MEMO"
        Me.GridColumn3.FieldName = "NRO_MEMORANDUM_INTERNO"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.GridColumn3.Width = 63
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Número Cheque"
        Me.GridColumn11.FieldName = "NUMERO_DOCUMENTO"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 9
        Me.GridColumn11.Width = 87
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.dgcViaticosAsociados
        Me.GridView1.Name = "GridView1"
        '
        'prnListadoViaticos
        '
        Me.prnListadoViaticos.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.dgcViaticosAsociados
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(40, 20, 20, 20)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Titulo1", "Titulo2", "Titulo3"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Pie1", "Pie2", "Pie3"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.prnListadoViaticos
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prnListadoViaticos
        '
        'frmHistoriaViaticosPorMemo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(928, 453)
        Me.Controls.Add(Me.gcResultado)
        Me.Controls.Add(Me.GC1)
        Me.Name = "frmHistoriaViaticosPorMemo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Viáticos .: Consulta de Viáticos Por Memorandum :."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GC1.ResumeLayout(False)
        Me.GC1.PerformLayout()
        CType(Me.luePeriodos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcResultado.ResumeLayout(False)
        Me.gcResultado.PerformLayout()
        CType(Me.txtChequeHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChequeDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumCheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgcViaticosAsociados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvViaticosAsociados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prnListadoViaticos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Funciones"
    Private Sub InitDataEmpleado()
        Dim ds As New DataAccess.Empleados
        repositorio.dvEmpleados = repositorio.dvEmpleados
    End Sub
    Private Sub BuscarResolucion()

        Try
            If CType(luePeriodos.EditValue, String) = "" Then
                ErrorProvider1.SetError(luePeriodos, "Debe seleccionar año.")
            Else
                ErrorProvider1.SetError(luePeriodos, "")
                recuperaViaticosResolucion(0, luePeriodos.EditValue, Me.txtNumResolucion.Text)
            End If
            If Me.txtNumResolucion.Text = "" Then
                btnGeneraCheque.Enabled = False
                btnGeneraBoucher.Enabled = False
            Else
                btnGeneraCheque.Enabled = True
                btnGeneraBoucher.Enabled = True
                Me.txtNumMemorandum.Text = NumeroMemorandumDeNumeroResolucion(txtNumResolucion.Text)
                CargarUltimoCheque()
                Me.dtFecha.MinDate = FechaMinimaChequeMemo(NumeroMemorandumDeNumeroResolucion(txtNumResolucion.Text))
            End If
        Catch exp As Exception
            MessageBox.Show(exp.Message, "Consulta Viáticos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BuscarMemo()
        Try
            If CType(luePeriodos.EditValue, String) = "" Then
                ErrorProvider1.SetError(luePeriodos, "Debe seleccionar año.")
            Else
                ErrorProvider1.SetError(luePeriodos, "")
                If Me.txtNumMemorandum.Text = "" Then
                    btnGeneraCheque.Enabled = False
                    btnGeneraBoucher.Enabled = False
                Else
                    btnGeneraCheque.Enabled = True
                    btnGeneraBoucher.Enabled = True
                    CargarUltimoCheque()
                    Me.txtNumResolucion.Text = NumeroResolucionDeNumeroMemorandum(txtNumMemorandum.Text)
                    Me.dtFecha.MinDate = FechaMinimaChequeMemo(txtNumMemorandum.Text)
                End If
                recuperaViaticos(0, luePeriodos.EditValue, txtNumMemorandum.Text)
            End If
        Catch exp As Exception
            MessageBox.Show(exp.Message, "Consulta Viáticos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function validaNumeroCheque(ByVal cheque As Integer) As String
        Dim conn As New SqlConnection(connectionString)
        Dim SQLStr As String = "SELECT * FROM RH_PER_CHEQUE WHERE NUMERO = " & cheque & " AND ESTADO = 0 "
        Dim da As New SqlDataAdapter(SQLStr, conn)
        Dim ds As New DataSet
        Dim res As String = ""
        da.Fill(ds, "RH_PER_CHEQUE")
        If ds.Tables(0).Rows.Count > 0 Then
            If (ds.Tables(0).Rows(0).Item("ESTADO")) = 0 Then
                res = "Pagado"
            ElseIf (ds.Tables(0).Rows(0).Item("ESTADO")) = 1 Then
                res = "Anulado"
            Else
                res = "Estado Desconocido"
            End If
        End If
        Return (res)
    End Function
    Private Function NumeroResolucionDeNumeroMemorandum(ByVal mem As Integer) As Integer
        Dim conn As New SqlConnection(connectionString)
        Dim SQLStr As String = "SELECT * FROM VW_RECIBO_EGRESO_VIATICO_DETALLE WHERE NRO_MEMORANDUM_INTERNO = " & mem
        Dim da As New SqlDataAdapter(SQLStr, conn)
        Dim ds As New DataSet
        Dim res As String
        da.Fill(ds, "VW_RECIBO_EGRESO_VIATICO_DETALLE")
        If ds.Tables(0).Rows.Count > 0 Then
            res = (ds.Tables(0).Rows(0).Item("NRO_RESOLUCION"))
        End If
        Return (res)
    End Function
    Private Function NumeroMemorandumDeNumeroResolucion(ByVal res As Integer) As Integer
        Dim conn As New SqlConnection(connectionString)
        Dim SQLStr As String = "SELECT * FROM VW_RECIBO_EGRESO_VIATICO_DETALLE WHERE NRO_RESOLUCION = " & res
        Dim da As New SqlDataAdapter(SQLStr, conn)
        Dim ds As New DataSet
        Dim mem As String
        da.Fill(ds, "VW_RECIBO_EGRESO_VIATICO_DETALLE")
        If ds.Tables(0).Rows.Count > 0 Then
            mem = (ds.Tables(0).Rows(0).Item("NRO_MEMORANDUM_INTERNO"))
        End If
        Return (mem)
    End Function
    Private Function FechaMinimaChequeMemo(ByVal memo As Integer) As String
        Dim conn As New SqlConnection(connectionString)
        Dim SQLStr As String = "SELECT * FROM VW_VIATICO_NUMERO_MEMORANDUM WHERE NRO_MEMORANDUM_INTERNO = " & memo
        Dim da As New SqlDataAdapter(SQLStr, conn)
        Dim ds As New DataSet
        Dim fecha As String
        da.Fill(ds, "VW_VIATICO_NUMERO_MEMORANDUM")
        If ds.Tables(0).Rows.Count > 0 Then
            fecha = (ds.Tables(0).Rows(0).Item("FECHA_MEMORANDUM"))
        Else
            fecha = "01/01/1900"
        End If
        Return (fecha)
    End Function

    Private Sub CargarUltimoCheque()
        Dim myConnection As SqlConnection
        Dim myCommand As SqlCommand
        Dim dr As SqlDataReader
        Dim StrSQL As String = "SELECT TOP 1 NUMERO FROM RH_PER_CHEQUE ORDER BY NUMERO DESC"
        myConnection = New SqlConnection(connectionString)
        myConnection.Open()
        myCommand = New SqlCommand(StrSQL, myConnection)
        dr = myCommand.ExecuteReader
        txtNumCheque.Text = ""
        Try
            Do
                While dr.Read()
                    txtNumCheque.Text = Trim(CType(1 + CType(dr.Item("NUMERO"), Integer), String))
                End While
            Loop While dr.NextResult()

        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub

    Private Sub EjecutarQuery(ByVal sqlSTR As String)
        Dim objcommand As New SqlClient.SqlCommand(sqlSTR, New SqlClient.SqlConnection(connectionString))
        objcommand.Connection.Open()
        objcommand.ExecuteNonQuery()
        objcommand.Connection.Close()
        objcommand.Dispose()
        objcommand = Nothing
    End Sub

    Private Sub ActualizarEstadoViatico(ByVal idRes As Integer, ByVal idEmpleado As Integer, ByVal numeroCheque As String, ByVal estado As Integer, ByVal fecha As String)
        Dim SQLstr As String = "UPDATE RH_PER_VIATICO_DETALLE SET ESTADO_VIATICO=" & estado & ", NUMERO_DOCUMENTO='" & numeroCheque & "', FECHA_DOCUMENTO=CONVERT(DATETIME,'" & fecha & "',103) WHERE VIATICO_ID IN (SELECT VIATICO_ID FROM RH_PER_VIATICO WHERE NRO_RESOLUCION = " & idRes & ") AND (EMPLEADO_ID = " & idEmpleado & ")"
        EjecutarQuery(SQLstr)
    End Sub

    Private Sub ActualizarEstadoCheque(ByVal numCheque As Integer, ByVal fecha As String, ByVal empleadoid As Integer, ByVal monto As Long)
        Dim SQLstr As String = "INSERT INTO RH_PER_CHEQUE (NUMERO, FECHA, BANCO_ID, MONTO, EMPLEADO_ID, ESTADO, ORIGEN) VALUES "
        SQLstr = SQLstr & "(" & numCheque & ",convert(datetime,'" & fecha & "',103),3," & monto & ", " & empleadoid & ", 0, 0)"
        EjecutarQuery(SQLstr)
    End Sub

    Private Sub initCampoRut()

    End Sub

    Private Sub InitPeriodos()
        GeneraDataViews()
        luePeriodos.Properties.DataSource = dvPeriodo
        luePeriodos.Properties.DisplayMember = "ANO"
        luePeriodos.Properties.NullText = ""
        luePeriodos.Properties.ValueMember = "ANO"
    End Sub
    Private Sub GeneraDataViews()
        Dim dad As SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
        Dim ds2 As New DataSet

        dad = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT DISTINCT ANO FROM RH_REM_PERIODO ORDER BY ANO DESC", conn))
        dad.Fill(ds2, Tablas.RH_REM_PERIODO)
        Dim dvmPeriodo As New DataViewManager(ds2)
        dvPeriodo = dvmPeriodo.CreateDataView(ds2.Tables(Tablas.RH_REM_PERIODO))
    End Sub
    'Obtiene todos los viáticos asigandos al empleado consultado, como también al número de documento.
    Private Sub recuperaViaticos(ByVal idempleado As Integer, ByVal año As Integer, Optional ByVal numMemo As String = "")
        dgcViaticosAsociados.DataSource = empleado.dvViativosAsignados(idempleado, año, numMemo)
        dgcViaticosAsociados.Show()
    End Sub
    Private Sub recuperaViaticosResolucion(ByVal idempleado As Integer, ByVal año As Integer, Optional ByVal numResolucion As String = "")
        dgcViaticosAsociados.DataSource = empleado.dvViativosAsignadosResolucion(idempleado, año, numResolucion)
        dgcViaticosAsociados.Show()
    End Sub
#End Region
    Private Sub frmHistoriaViaticosPorMemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        repositorio.Show()
        InitPeriodos()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'debo dejar sólo una función.

        BuscarMemo()

    End Sub

    Private Sub gvViaticosAsociados_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvViaticosAsociados.DoubleClick
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender

        'Carga formulario de registro de viáticos asignados.

        Cursor.Current = Cursors.WaitCursor
        'Dim frmMantencionViaticos As New frmMantencionViatico
        'frmMantencionViatico.DefInstance.Close()
        'frmMantencionViatico.DefInstance.VIATICO_ID = view.GetRowCellValue(view.FocusedRowHandle, view.Columns(0))
        'frmMantencionViatico.DefInstance.DETALLE_VIATICO_ID = 0
        'frmMantencionViatico.DefInstance.gcDetalleViatico.Visible = False
        'frmMantencionViatico.DefInstance.MdiParent = Me.ParentForm
        'frmMantencionViatico.DefInstance.Show()
        '  frmMantencionViaticos.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnGeneraCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneraCheque.Click
        Dim nombreCompleto, totalEgreso, valorEnLetrasParte1, valorEnLetrasParte2, Dia, Mes, Ano As String
        Dim app_PathFile As String = Path.GetFullPath("imprimec.txt")
        Dim app_PathFileBat As String = Path.GetFullPath("imprimec.bat")
        Dim myConnection As SqlConnection
        Dim myCommand As SqlCommand
        Dim dr As SqlDataReader
        Dim FECHA_CHEQUE As String = dtFecha.Value
        Dim NUMERO_DOCUMENTO As Integer = Me.txtNumResolucion.Text
        Dim NUM_CHEQUE As Integer = Me.txtNumCheque.Text
        Dim NUM_CHEQUE_INICIAL As Integer = NUM_CHEQUE
        Dim NUM_CHEQUE_FINAL As Integer
        Dim ID_EMPLEADO As Integer
        Dim largoNombreCompleto, LargoApellidos, LargoNombres As Integer
        Dim apellidos As String
        Dim Nombres As String
        Dim ChequesEmitidos As String = ""
        Dim FechaCheque, nombreComprobante, MontoEscrito As String
        Try
            If Trim(Me.txtNumCheque.Text) = "" And Me.txtNumMemorandum.Text = "" And Me.luePeriodos.Text = "" Then
            Else
                'SELECT RTRIM(NOMBRES) + ' ' + RTRIM(APELLIDO_PATERNO) + ' ' + RTRIM(APELLIDO_MATERNO) AS NOMBRE_COMPLETO, MONTO, MONTO_EN_LETRAS_PART1, MONTO_EN_LETRAS_PART2,DAY(CONVERT(DATETIME,'18/09/2007',103)) AS DIA, MONTH(CONVERT(DATETIME,'18/09/2007',103)) AS MES, YEAR(CONVERT(DATETIME,'18/09/2007',103)) AS ANO  FROM VW_VIATICO_DETALLE_CHEQUE WHERE NRO_MEMORANDUM_INTERNO=1 

                myConnection = New SqlConnection(connectionString)
                myConnection.Open()
                myCommand = New SqlCommand("SELECT EMPLEADO_ID, NOMBRES, (RTRIM(NOMBRES) + ' ' + RTRIM(APELLIDO_PATERNO) + ' ' + RTRIM(APELLIDO_MATERNO)) AS NOMBRE_COMPLETO, (RTRIM(APELLIDO_PATERNO) + ' ' + RTRIM(APELLIDO_MATERNO)) APELLIDOS, MONTO, MONTO_EN_LETRAS_PART1, MONTO_EN_LETRAS_PART2,DAY(CONVERT(DATETIME,'" & FECHA_CHEQUE & "',103)) AS DIA, DBO.MESENLETRA(CONVERT(DATETIME,'" & FECHA_CHEQUE & "',103)) AS MES, YEAR(CONVERT(DATETIME,'" & FECHA_CHEQUE & "',103)) AS ANO  FROM VW_VIATICO_DETALLE_CHEQUE WHERE NRO_RESOLUCION=" & NUMERO_DOCUMENTO, myConnection)
                dr = myCommand.ExecuteReader
                ' Abrir archivo. 
                FileOpen(1, app_PathFile, OpenMode.Output)
                Do
                    While dr.Read()
                        If validaNumeroCheque(NUM_CHEQUE) = "" Then
                            nombreCompleto = Replace(Trim(dr.Item("NOMBRE_COMPLETO")), "Ñ", "N")
                            apellidos = Replace(Trim(dr.Item("APELLIDOS")), "Ñ", "N")
                            Nombres = Replace(Trim(dr.Item("NOMBRES")), "Ñ", "N")
                            largoNombreCompleto = Len(nombreCompleto)
                            LargoApellidos = Len(apellidos)
                            LargoNombres = Len(Nombres)
                            totalEgreso = Trim(dr.Item("MONTO"))
                            valorEnLetrasParte1 = Trim(dr.Item("MONTO_EN_LETRAS_PART1"))
                            valorEnLetrasParte2 = Trim(dr.Item("MONTO_EN_LETRAS_PART2"))
                            MontoEscrito = valorEnLetrasParte1 + " " + valorEnLetrasParte2
                            Dia = Trim(dr.Item("DIA"))
                            Mes = Trim(dr.Item("MES"))
                            Ano = Trim(dr.Item("ANO"))
                            FechaCheque = Dia & " " & Mes & " " & Ano
                            ID_EMPLEADO = Trim(dr.Item("EMPLEADO_ID"))

                            Dim nombreLinea1 As String = ""
                            Dim nombreLinea2 As String = ""

                            If Len(nombreCompleto) <= 20 Then
                                nombreLinea1 = nombreCompleto
                                nombreLinea2 = ""
                                nombreComprobante = nombreCompleto
                            Else
                                nombreLinea1 = nombreCompleto.Substring(0, 20)
                                nombreLinea2 = nombreCompleto.Substring(20, Math.Abs(Len(nombreCompleto) - Len(nombreCompleto.Substring(0, 20))))
                                nombreComprobante = nombreCompleto.Substring(0, 20)
                            End If

                            'Crea archivo con información.

                            PrintLine(1, " ")   ' Linea en blanco.
                            PrintLine(1, TAB(102), (LTrim(Format(CInt(totalEgreso), "###,###,###")) + ".-")) 'Imprime monto del cheque.
                            PrintLine(1)   ' Linea en blanco.
                            PrintLine(1)   ' Linea en blanco.
                            PrintLine(1)   ' Linea en blanco.
                            PrintLine(1, TAB(10), FechaCheque, TAB(90), FechaCheque)  ' Imprime fecha.

                            PrintLine(1)   ' Linea en blanco.
                            PrintLine(1, TAB(50), nombreCompleto) ' Nombre completo de la persona en el cheque.
                            PrintLine(1, TAB(1), nombreComprobante) ' Nombre de la persona para comprobante.
                            If Len(MontoEscrito) > 70 Then
                                PrintLine(1, TAB(50), valorEnLetrasParte1)   ' Si el texto de la cifra sobrepasa los 70 char.
                                PrintLine(1, TAB(10), (LTrim(Format(CInt(totalEgreso), "###,###,###")) + ".-"), TAB(43), valorEnLetrasParte2)
                            Else
                                PrintLine(1, TAB(50), MontoEscrito)
                                PrintLine(1, TAB(10), (LTrim(Format(CInt(totalEgreso), "###,###,###")) + ".-"))
                            End If
                            PrintLine(1)   ' Linea en blanco.
                            PrintLine(1)   ' Linea en blanco.
                            PrintLine(1)   ' Linea en blanco.
                            PrintLine(1)   ' Linea en blanco.
                            PrintLine(1)   ' Linea en blanco.
                            PrintLine(1)   ' Linea en blanco.

                            ActualizarEstadoCheque(NUM_CHEQUE, FECHA_CHEQUE, ID_EMPLEADO, totalEgreso)
                            ActualizarEstadoViatico(NUMERO_DOCUMENTO, ID_EMPLEADO, NUM_CHEQUE, 1, FECHA_CHEQUE)

                        Else
                            ChequesEmitidos = ChequesEmitidos & NUM_CHEQUE & ", "
                        End If

                        NUM_CHEQUE_FINAL = NUM_CHEQUE
                        NUM_CHEQUE = NUM_CHEQUE + 1
                    End While
                Loop While dr.NextResult()
                FileClose(1) ' Close file.
            End If

        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
        dr.Close()
        myConnection.Close()
        BuscarResolucion()
        Dim frmChequesViatico As New frmChequesViatico
        If ChequesEmitidos <> "" Then
            MessageBox.Show("Los cheques, " & ChequesEmitidos & "se encuentran con estado Emitido o Anulado")
        End If
        If NUM_CHEQUE_FINAL < NUM_CHEQUE_INICIAL Then NUM_CHEQUE_FINAL = NUM_CHEQUE_FINAL
        frmChequesViatico.DefInstance.cheque_inicial_h = NUM_CHEQUE_INICIAL
        frmChequesViatico.DefInstance.cheque_final_h = NUM_CHEQUE_FINAL
        frmChequesViatico.DefInstance.Owner = Me
        If frmChequesViatico.DefInstance.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        End If

    End Sub

    Private Sub BKPbtnGeneraCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles btnGeneraCheque.Click
        Dim nombreCompleto, totalEgreso, valorEnLetrasParte1, valorEnLetrasParte2, Dia, Mes, Ano As String
        Dim app_PathFile As String = Path.GetFullPath("imprimec.txt")
        Dim app_PathFileBat As String = Path.GetFullPath("imprimec.bat")
        Dim myConnection As SqlConnection
        Dim myCommand As SqlCommand
        Dim dr As SqlDataReader
        Dim FECHA_CHEQUE As String = dtFecha.Value
        Dim NUMERO_DOCUMENTO As Integer = Me.txtNumResolucion.Text
        Dim NUM_CHEQUE As Integer = Me.txtNumCheque.Text
        Dim NUM_CHEQUE_INICIAL As Integer = NUM_CHEQUE
        Dim NUM_CHEQUE_FINAL As Integer
        Dim ID_EMPLEADO As Integer
        Dim largoNombreCompleto, LargoApellidos, LargoNombres As Integer
        Dim apellidos As String
        Dim Nombres As String
        Dim ChequesEmitidos As String = ""
        Try
            If Trim(Me.txtNumCheque.Text) = "" And Me.txtNumMemorandum.Text = "" And Me.luePeriodos.Text = "" Then
            Else
                'SELECT RTRIM(NOMBRES) + ' ' + RTRIM(APELLIDO_PATERNO) + ' ' + RTRIM(APELLIDO_MATERNO) AS NOMBRE_COMPLETO, MONTO, MONTO_EN_LETRAS_PART1, MONTO_EN_LETRAS_PART2,DAY(CONVERT(DATETIME,'18/09/2007',103)) AS DIA, MONTH(CONVERT(DATETIME,'18/09/2007',103)) AS MES, YEAR(CONVERT(DATETIME,'18/09/2007',103)) AS ANO  FROM VW_VIATICO_DETALLE_CHEQUE WHERE NRO_MEMORANDUM_INTERNO=1 

                myConnection = New SqlConnection(connectionString)
                myConnection.Open()
                myCommand = New SqlCommand("SELECT EMPLEADO_ID, NOMBRES, (RTRIM(NOMBRES) + ' ' + RTRIM(APELLIDO_PATERNO) + ' ' + RTRIM(APELLIDO_MATERNO)) AS NOMBRE_COMPLETO, (RTRIM(APELLIDO_PATERNO) + ' ' + RTRIM(APELLIDO_MATERNO)) APELLIDOS, MONTO, MONTO_EN_LETRAS_PART1, MONTO_EN_LETRAS_PART2,DAY(CONVERT(DATETIME,'" & FECHA_CHEQUE & "',103)) AS DIA, DBO.MESENLETRA(CONVERT(DATETIME,'" & FECHA_CHEQUE & "',103)) AS MES, YEAR(CONVERT(DATETIME,'" & FECHA_CHEQUE & "',103)) AS ANO  FROM VW_VIATICO_DETALLE_CHEQUE WHERE NRO_RESOLUCION=" & NUMERO_DOCUMENTO, myConnection)
                dr = myCommand.ExecuteReader
                ' Abrir archivo. 
                FileOpen(1, app_PathFile, OpenMode.Output)
                Do
                    While dr.Read()
                        If validaNumeroCheque(NUM_CHEQUE) = "" Then
                            nombreCompleto = Replace(Trim(dr.Item("NOMBRE_COMPLETO")), "Ñ", "N")
                            apellidos = Replace(Trim(dr.Item("APELLIDOS")), "Ñ", "N")
                            Nombres = Replace(Trim(dr.Item("NOMBRES")), "Ñ", "N")
                            largoNombreCompleto = Len(nombreCompleto)
                            LargoApellidos = Len(apellidos)
                            LargoNombres = Len(Nombres)
                            totalEgreso = Trim(dr.Item("MONTO"))
                            valorEnLetrasParte1 = Trim(dr.Item("MONTO_EN_LETRAS_PART1"))
                            valorEnLetrasParte2 = Trim(dr.Item("MONTO_EN_LETRAS_PART2"))
                            Dia = Trim(dr.Item("DIA"))
                            Mes = Trim(dr.Item("MES"))
                            Ano = Trim(dr.Item("ANO"))
                            ID_EMPLEADO = Trim(dr.Item("EMPLEADO_ID"))
                            'Crea archivo con información. 
                            ' Dim s As String = (RTrim(Format(totalEgreso, "currency")) + ".-") 

                            'Crea archivo con información.

                            PrintLine(1)   ' Linea en blanco.
                            PrintLine(1, TAB(70), (LTrim(Format(CInt(totalEgreso), "###,###,###")) + ".-")) 'Imprime monto del cheque.
                            PrintLine(1)   ' Linea en blanco.
                            PrintLine(1)   ' Linea en blanco.
                            PrintLine(1)   ' Linea en blanco.
                            PrintLine(1, TAB(0), Dia & " " & Mes & " " & Ano, TAB(63), Dia & " " & Mes & " " & Ano)  ' Imprime fecha.
                            PrintLine(1)   ' Linea en blanco.

                            If LargoApellidos < 16 Then
                                PrintLine(1, TAB(0), apellidos.Substring(0, LargoApellidos).ToLower, TAB(36), nombreCompleto) ' Nombre de la persona.
                            Else
                                PrintLine(1, TAB(0), apellidos.Substring(0, 16).ToLower, TAB(36), nombreCompleto) ' Nombre de la persona.
                            End If

                            If LargoNombres < 23 Then
                                PrintLine(1, TAB(1), Nombres.Substring(0, LargoNombres).ToLower) ' Nombre de la persona.
                            Else
                                PrintLine(1, TAB(1), Nombres.Substring(0, 22).ToLower) ' Nombre de la persona.
                            End If

                            ' Linea en blanco.
                            PrintLine(1, TAB(36), valorEnLetrasParte1)   ' Si el texto de la cifra sobrepasa los 50 char.
                            PrintLine(1, TAB(7), (LTrim(Format(CInt(totalEgreso), "###,###,###")) + ".-"), TAB(36), valorEnLetrasParte2)  ' continúa en la siguiente linea.
                            PrintLine(1)   ' Linea en blanco.
                            PrintLine(1)   ' Linea en blanco.
                            PrintLine(1)   ' Linea en blanco.
                            PrintLine(1)   ' Linea en blanco.
                            PrintLine(1)   ' Linea en blanco.
                            PrintLine(1)   ' Linea en blanco.
                            ActualizarEstadoCheque(NUM_CHEQUE, FECHA_CHEQUE, ID_EMPLEADO, totalEgreso)
                            ActualizarEstadoViatico(NUMERO_DOCUMENTO, ID_EMPLEADO, NUM_CHEQUE, 1, FECHA_CHEQUE)

                        Else
                            ChequesEmitidos = ChequesEmitidos & NUM_CHEQUE & ", "
                        End If

                        NUM_CHEQUE_FINAL = NUM_CHEQUE
                        NUM_CHEQUE = NUM_CHEQUE + 1
                    End While
                Loop While dr.NextResult()
                FileClose(1) ' Close file.
            End If

        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
        dr.Close()
        myConnection.Close()
        BuscarResolucion()
        Dim frmChequesViatico As New frmChequesViatico
        If ChequesEmitidos <> "" Then
            MessageBox.Show("Los cheques, " & ChequesEmitidos & "se encuentran con estado Emitido o Anulado")
        End If
        If NUM_CHEQUE_FINAL < NUM_CHEQUE_INICIAL Then NUM_CHEQUE_FINAL = NUM_CHEQUE_FINAL
        frmChequesViatico.DefInstance.cheque_inicial_h = NUM_CHEQUE_INICIAL
        frmChequesViatico.DefInstance.cheque_final_h = NUM_CHEQUE_FINAL
        frmChequesViatico.DefInstance.Owner = Me
        If frmChequesViatico.DefInstance.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        End If

    End Sub

    Private Sub btnGeneraBoucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneraBoucher.Click
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptEgresoViaticos
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        Dim strFormulaSeleccion As String
        strFormulaSeleccion = "{VW_VIATICOS.NRO_RESOLUCION}='" & CType(Me.txtNumResolucion.Text, Integer) & "'"
        strFormulaSeleccion &= " AND {VW_VIATICOS.ANO}= " + CType(luePeriodos.EditValue, String)
        reporte.SummaryInfo.ReportTitle = "Recibo de Egreso"
        ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
        ventanaReporte1.rptVisor.ShowParameterPanelButton = False
        ventanaReporte1.rptVisor.ShowCloseButton = False
        ventanaReporte1.rptVisor.ShowGroupTreeButton = False
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.Show()

        'If Me.txtNumResolucion.Text <> "" Then
        '    Dim ventanaReporte1 As New ventanaReporte
        '    Dim reporte As New rptEgresoViatico
        '    Dim numeroRes As Integer = Me.txtNumResolucion.Text
        '    If CType(numeroRes, String) <> "" Then
        '        If numeroRes > 0 Then
        '            WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        '            ventanaReporte1.rptVisor.SelectionFormula = "{VW_RECIBO_EGRESO_VIATICO.NRO_RESOLUCION}='" & numeroRes & "'"
        '            ventanaReporte1.rptVisor.SelectionFormula &= " AND {VW_RECIBO_EGRESO_VIATICO.ANO}= " + CType(luePeriodos.EditValue, String)
        '            ventanaReporte1.rptVisor.DisplayGroupTree = False
        '            reporte.SummaryInfo.ReportTitle = "RECIBO DE EGRESO"
        '            ventanaReporte1.rptVisor.ReportSource = reporte
        '            ventanaReporte1.Show()
        '        End If
        '    End If
        'Else
        '    MsgBox("Debe indicar le numero de resolución")
        'End If
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        Dim respuesta As Boolean = True
        If CType(txtChequeDesde.EditValue, Integer) = 0 Then
            txtChequeDesde.ErrorText = "Cheque inicial debe ser mayor a cero"
            respuesta = False
        End If
        If CType(txtChequeHasta.EditValue, Integer) = 0 Then
            txtChequeHasta.ErrorText = "Cheque final debe ser mayor a cero"
            respuesta = False
        End If
        If CType(txtChequeDesde.EditValue, Integer) > 0 And CType(txtChequeHasta.EditValue, Integer) > 0 And CType(txtChequeDesde.EditValue, Integer) > CType(txtChequeHasta.EditValue, Integer) Then
            txtChequeDesde.ErrorText = "Cheque inicial no puede ser mayor al cheque final"
            respuesta = False
        End If
        If respuesta Then
            Try
                If MessageBox.Show("¿Desea anular los cheques entre " & Me.txtChequeDesde.Text & " y " & Me.txtChequeHasta.Text & "?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    If Me.txtChequeDesde.Text <= Me.txtChequeHasta.Text Then
                        Dim strSQL As String = "exec sp_anular_cheque " & Me.txtChequeDesde.Text & ", " & Me.txtChequeHasta.Text
                        EjecutarQuery(strSQL)
                        BuscarResolucion()
                        txtChequeDesde.Text = ""
                        txtChequeHasta.Text = ""
                    Else
                        MsgBox("El número del cheque inicial tiene que ser menor o igual al numero de cheque final")
                    End If
                End If
            Catch exp As Exception
                MessageBox.Show("Debe llenar ambos campos.", "Consulta Viáticos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = ".: Consulta de Viáticos Por Memorandum :."
        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)
    End Sub

    Private Sub btnImprimirListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirListado.Click
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub btnBuscarResolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarResolucion.Click
        'debo dejar sólo una función.
        BuscarResolucion()
    End Sub


End Class
