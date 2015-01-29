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

Public Class frmIngresoHorasExtrasAprobadasDepto
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
    Friend WithEvents gpcBotonesEncabezado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevoMemorandum As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminarMemorandum As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblDepartamento As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueDepartamento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueNumeroMemorandum As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblFechaMemorandum As System.Windows.Forms.Label
    Friend WithEvents dedFechaMemorando As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblNroMemorandum As System.Windows.Forms.Label
    Friend WithEvents txtNumeroMemo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpcInformacionMemoInterno As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblAño As System.Windows.Forms.Label
    Friend WithEvents txtAño As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMes As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents gdcDetalleAprobHorasExtras As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalleAprobHorasExtras As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colHORAS_APROBADAS_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAÑO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNRO_MEMO_INTERMO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_MEMO_INTERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPTO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO_REGISTRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHORAS_DIURNAS_APROB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHORAS_NOCTURNAS_APROB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtHrsAprobadasDiurnas As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtHrsAprobadasNocturnas As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents lblTipoProceso As System.Windows.Forms.Label
    Friend WithEvents rdgTipoProceso As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents gleRut As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnBuscarMemorandum As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gleEmpleado As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gpcDatosHoras As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblHrsDiurnas As System.Windows.Forms.Label
    Friend WithEvents txtHorasDiurnas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHorasNocturnas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblHorasNocturnas As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colHORAS_DIURNAS_PLANIFICADAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHORAS_NOCTURNAS_PLANIFICADAS As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpcBotonesEncabezado = New DevExpress.XtraEditors.GroupControl
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton
        Me.btnNuevoMemorandum = New DevExpress.XtraEditors.SimpleButton
        Me.btnEliminarMemorandum = New DevExpress.XtraEditors.SimpleButton
        Me.btnBuscarMemorandum = New DevExpress.XtraEditors.SimpleButton
        Me.gpcInformacionMemoInterno = New DevExpress.XtraEditors.GroupControl
        Me.lblTipoProceso = New System.Windows.Forms.Label
        Me.rdgTipoProceso = New DevExpress.XtraEditors.RadioGroup
        Me.lueNumeroMemorandum = New DevExpress.XtraEditors.LookUpEdit
        Me.lblMes = New System.Windows.Forms.Label
        Me.txtMes = New DevExpress.XtraEditors.TextEdit
        Me.lblDepartamento = New DevExpress.XtraEditors.LabelControl
        Me.lueDepartamento = New DevExpress.XtraEditors.LookUpEdit
        Me.lblFechaMemorandum = New System.Windows.Forms.Label
        Me.dedFechaMemorando = New DevExpress.XtraEditors.DateEdit
        Me.lblNroMemorandum = New System.Windows.Forms.Label
        Me.txtNumeroMemo = New DevExpress.XtraEditors.TextEdit
        Me.txtAño = New DevExpress.XtraEditors.TextEdit
        Me.lblAño = New System.Windows.Forms.Label
        Me.gdcDetalleAprobHorasExtras = New DevExpress.XtraGrid.GridControl
        Me.gdvDetalleAprobHorasExtras = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colHORAS_APROBADAS_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gleRut = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colAÑO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMES = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNRO_MEMO_INTERMO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_MEMO_INTERNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEPTO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colESTADO_REGISTRO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHORAS_DIURNAS_PLANIFICADAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHORAS_NOCTURNAS_PLANIFICADAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHORAS_DIURNAS_APROB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtHrsAprobadasDiurnas = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colHORAS_NOCTURNAS_APROB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtHrsAprobadasNocturnas = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gpcDatosHoras = New DevExpress.XtraEditors.GroupControl
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.lblHorasNocturnas = New System.Windows.Forms.Label
        Me.txtHorasNocturnas = New DevExpress.XtraEditors.TextEdit
        Me.txtHorasDiurnas = New DevExpress.XtraEditors.TextEdit
        Me.lblHrsDiurnas = New System.Windows.Forms.Label
        Me.gleEmpleado = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.lblEmpleado = New System.Windows.Forms.Label
        CType(Me.gpcBotonesEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBotonesEncabezado.SuspendLayout()
        CType(Me.gpcInformacionMemoInterno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcInformacionMemoInterno.SuspendLayout()
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueNumeroMemorandum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaMemorando.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroMemo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAño.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcDetalleAprobHorasExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleAprobHorasExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleRut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHrsAprobadasDiurnas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHrsAprobadasNocturnas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDatosHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDatosHoras.SuspendLayout()
        CType(Me.txtHorasNocturnas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHorasDiurnas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcBotonesEncabezado
        '
        Me.gpcBotonesEncabezado.Controls.Add(Me.btnVisualizar)
        Me.gpcBotonesEncabezado.Controls.Add(Me.btnNuevoMemorandum)
        Me.gpcBotonesEncabezado.Controls.Add(Me.btnEliminarMemorandum)
        Me.gpcBotonesEncabezado.Controls.Add(Me.btnBuscarMemorandum)
        Me.gpcBotonesEncabezado.Location = New System.Drawing.Point(8, 128)
        Me.gpcBotonesEncabezado.Name = "gpcBotonesEncabezado"
        Me.gpcBotonesEncabezado.ShowCaption = False
        Me.gpcBotonesEncabezado.Size = New System.Drawing.Size(992, 40)
        Me.gpcBotonesEncabezado.TabIndex = 5
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(496, 8)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(136, 23)
        Me.btnVisualizar.TabIndex = 11
        Me.btnVisualizar.Text = "Visualizar"
        '
        'btnNuevoMemorandum
        '
        Me.btnNuevoMemorandum.Location = New System.Drawing.Point(64, 8)
        Me.btnNuevoMemorandum.Name = "btnNuevoMemorandum"
        Me.btnNuevoMemorandum.Size = New System.Drawing.Size(136, 23)
        Me.btnNuevoMemorandum.TabIndex = 6
        Me.btnNuevoMemorandum.Text = "Nuevo Memorandum"
        '
        'btnEliminarMemorandum
        '
        Me.btnEliminarMemorandum.Location = New System.Drawing.Point(208, 8)
        Me.btnEliminarMemorandum.Name = "btnEliminarMemorandum"
        Me.btnEliminarMemorandum.Size = New System.Drawing.Size(136, 23)
        Me.btnEliminarMemorandum.TabIndex = 7
        Me.btnEliminarMemorandum.Text = "Eliminar Memorandum"
        '
        'btnBuscarMemorandum
        '
        Me.btnBuscarMemorandum.Location = New System.Drawing.Point(352, 8)
        Me.btnBuscarMemorandum.Name = "btnBuscarMemorandum"
        Me.btnBuscarMemorandum.Size = New System.Drawing.Size(136, 23)
        Me.btnBuscarMemorandum.TabIndex = 8
        Me.btnBuscarMemorandum.Text = "Buscar Memorandum"
        '
        'gpcInformacionMemoInterno
        '
        Me.gpcInformacionMemoInterno.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcInformacionMemoInterno.AppearanceCaption.Options.UseFont = True
        Me.gpcInformacionMemoInterno.Controls.Add(Me.lblTipoProceso)
        Me.gpcInformacionMemoInterno.Controls.Add(Me.rdgTipoProceso)
        Me.gpcInformacionMemoInterno.Controls.Add(Me.lueNumeroMemorandum)
        Me.gpcInformacionMemoInterno.Controls.Add(Me.lblMes)
        Me.gpcInformacionMemoInterno.Controls.Add(Me.txtMes)
        Me.gpcInformacionMemoInterno.Controls.Add(Me.lblDepartamento)
        Me.gpcInformacionMemoInterno.Controls.Add(Me.lueDepartamento)
        Me.gpcInformacionMemoInterno.Controls.Add(Me.lblFechaMemorandum)
        Me.gpcInformacionMemoInterno.Controls.Add(Me.dedFechaMemorando)
        Me.gpcInformacionMemoInterno.Controls.Add(Me.lblNroMemorandum)
        Me.gpcInformacionMemoInterno.Controls.Add(Me.txtNumeroMemo)
        Me.gpcInformacionMemoInterno.Controls.Add(Me.txtAño)
        Me.gpcInformacionMemoInterno.Controls.Add(Me.lblAño)
        Me.gpcInformacionMemoInterno.Location = New System.Drawing.Point(8, 8)
        Me.gpcInformacionMemoInterno.Name = "gpcInformacionMemoInterno"
        Me.gpcInformacionMemoInterno.Size = New System.Drawing.Size(992, 120)
        Me.gpcInformacionMemoInterno.TabIndex = 4
        Me.gpcInformacionMemoInterno.Text = "Información Memorandum Interno"
        '
        'lblTipoProceso
        '
        Me.lblTipoProceso.Location = New System.Drawing.Point(528, 88)
        Me.lblTipoProceso.Name = "lblTipoProceso"
        Me.lblTipoProceso.Size = New System.Drawing.Size(72, 16)
        Me.lblTipoProceso.TabIndex = 79
        Me.lblTipoProceso.Text = "Tipo Proceso"
        Me.lblTipoProceso.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'rdgTipoProceso
        '
        Me.rdgTipoProceso.EditValue = "N"
        Me.rdgTipoProceso.Location = New System.Drawing.Point(608, 80)
        Me.rdgTipoProceso.Name = "rdgTipoProceso"
        '
        'rdgTipoProceso.Properties
        '
        Me.rdgTipoProceso.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("N", "Normal"), New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Suplemetaria")})
        Me.rdgTipoProceso.Size = New System.Drawing.Size(224, 32)
        Me.rdgTipoProceso.TabIndex = 7
        '
        'lueNumeroMemorandum
        '
        Me.lueNumeroMemorandum.Location = New System.Drawing.Point(112, 80)
        Me.lueNumeroMemorandum.Name = "lueNumeroMemorandum"
        '
        'lueNumeroMemorandum.Properties
        '
        Me.lueNumeroMemorandum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueNumeroMemorandum.Properties.NullText = ""
        Me.lueNumeroMemorandum.Size = New System.Drawing.Size(96, 20)
        Me.lueNumeroMemorandum.TabIndex = 3
        '
        'lblMes
        '
        Me.lblMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.Location = New System.Drawing.Point(552, 36)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(48, 16)
        Me.lblMes.TabIndex = 77
        Me.lblMes.Text = "Mes"
        Me.lblMes.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMes
        '
        Me.txtMes.EnterMoveNextControl = True
        Me.txtMes.Location = New System.Drawing.Point(608, 32)
        Me.txtMes.Name = "txtMes"
        '
        'txtMes.Properties
        '
        Me.txtMes.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMes.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMes.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMes.Properties.Mask.EditMask = "n0"
        Me.txtMes.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMes.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMes.Properties.MaxLength = 7
        Me.txtMes.Size = New System.Drawing.Size(64, 20)
        Me.txtMes.TabIndex = 4
        Me.txtMes.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'lblDepartamento
        '
        Me.lblDepartamento.Location = New System.Drawing.Point(8, 62)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(96, 14)
        Me.lblDepartamento.TabIndex = 74
        Me.lblDepartamento.Text = "Sub-Departamento"
        '
        'lueDepartamento
        '
        Me.lueDepartamento.Location = New System.Drawing.Point(112, 56)
        Me.lueDepartamento.Name = "lueDepartamento"
        '
        'lueDepartamento.Properties
        '
        Me.lueDepartamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDepartamento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3")})
        Me.lueDepartamento.Properties.NullText = ""
        Me.lueDepartamento.Size = New System.Drawing.Size(304, 20)
        Me.lueDepartamento.TabIndex = 1
        '
        'lblFechaMemorandum
        '
        Me.lblFechaMemorandum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaMemorandum.Location = New System.Drawing.Point(480, 60)
        Me.lblFechaMemorandum.Name = "lblFechaMemorandum"
        Me.lblFechaMemorandum.Size = New System.Drawing.Size(120, 16)
        Me.lblFechaMemorandum.TabIndex = 66
        Me.lblFechaMemorandum.Text = "Fecha Memorandum"
        Me.lblFechaMemorandum.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dedFechaMemorando
        '
        Me.dedFechaMemorando.EditValue = Nothing
        Me.dedFechaMemorando.EnterMoveNextControl = True
        Me.dedFechaMemorando.Location = New System.Drawing.Point(608, 56)
        Me.dedFechaMemorando.Name = "dedFechaMemorando"
        '
        'dedFechaMemorando.Properties
        '
        Me.dedFechaMemorando.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaMemorando.Properties.Mask.EditMask = ""
        Me.dedFechaMemorando.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.dedFechaMemorando.Size = New System.Drawing.Size(96, 20)
        Me.dedFechaMemorando.TabIndex = 5
        '
        'lblNroMemorandum
        '
        Me.lblNroMemorandum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroMemorandum.Location = New System.Drawing.Point(0, 84)
        Me.lblNroMemorandum.Name = "lblNroMemorandum"
        Me.lblNroMemorandum.Size = New System.Drawing.Size(104, 16)
        Me.lblNroMemorandum.TabIndex = 64
        Me.lblNroMemorandum.Text = "Nº Memorandum"
        Me.lblNroMemorandum.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNumeroMemo
        '
        Me.txtNumeroMemo.EnterMoveNextControl = True
        Me.txtNumeroMemo.Location = New System.Drawing.Point(112, 80)
        Me.txtNumeroMemo.Name = "txtNumeroMemo"
        '
        'txtNumeroMemo.Properties
        '
        Me.txtNumeroMemo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroMemo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNumeroMemo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNumeroMemo.Properties.Mask.EditMask = "n0"
        Me.txtNumeroMemo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumeroMemo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNumeroMemo.Properties.MaxLength = 8
        Me.txtNumeroMemo.Size = New System.Drawing.Size(96, 20)
        Me.txtNumeroMemo.TabIndex = 2
        '
        'txtAño
        '
        Me.txtAño.EnterMoveNextControl = True
        Me.txtAño.Location = New System.Drawing.Point(112, 32)
        Me.txtAño.Name = "txtAño"
        '
        'txtAño.Properties
        '
        Me.txtAño.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAño.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAño.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAño.Properties.Mask.EditMask = "n0"
        Me.txtAño.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAño.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAño.Properties.MaxLength = 7
        Me.txtAño.Size = New System.Drawing.Size(64, 20)
        Me.txtAño.TabIndex = 0
        Me.txtAño.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'lblAño
        '
        Me.lblAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAño.Location = New System.Drawing.Point(56, 36)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(48, 16)
        Me.lblAño.TabIndex = 75
        Me.lblAño.Text = "Año"
        Me.lblAño.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gdcDetalleAprobHorasExtras
        '
        Me.gdcDetalleAprobHorasExtras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        'gdcDetalleAprobHorasExtras.EmbeddedNavigator
        '
        Me.gdcDetalleAprobHorasExtras.EmbeddedNavigator.Name = ""
        Me.gdcDetalleAprobHorasExtras.Location = New System.Drawing.Point(8, 288)
        Me.gdcDetalleAprobHorasExtras.MainView = Me.gdvDetalleAprobHorasExtras
        Me.gdcDetalleAprobHorasExtras.Name = "gdcDetalleAprobHorasExtras"
        Me.gdcDetalleAprobHorasExtras.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtHrsAprobadasDiurnas, Me.txtHrsAprobadasNocturnas, Me.gleRut})
        Me.gdcDetalleAprobHorasExtras.Size = New System.Drawing.Size(992, 128)
        Me.gdcDetalleAprobHorasExtras.TabIndex = 6
        Me.gdcDetalleAprobHorasExtras.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleAprobHorasExtras, Me.GridView2})
        '
        'gdvDetalleAprobHorasExtras
        '
        Me.gdvDetalleAprobHorasExtras.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHORAS_APROBADAS_ID, Me.colEMPLEADO_ID, Me.colAÑO, Me.colMES, Me.colNRO_MEMO_INTERMO, Me.colFECHA_MEMO_INTERNO, Me.colDEPTO_ID, Me.colESTADO_REGISTRO, Me.colHORAS_DIURNAS_PLANIFICADAS, Me.colHORAS_NOCTURNAS_PLANIFICADAS, Me.colHORAS_DIURNAS_APROB, Me.colHORAS_NOCTURNAS_APROB})
        Me.gdvDetalleAprobHorasExtras.GridControl = Me.gdcDetalleAprobHorasExtras
        Me.gdvDetalleAprobHorasExtras.Name = "gdvDetalleAprobHorasExtras"
        Me.gdvDetalleAprobHorasExtras.OptionsView.ShowGroupPanel = False
        '
        'colHORAS_APROBADAS_ID
        '
        Me.colHORAS_APROBADAS_ID.Caption = "ID Horas Aprobadas"
        Me.colHORAS_APROBADAS_ID.FieldName = "HORAS_APROBADAS_ID"
        Me.colHORAS_APROBADAS_ID.Name = "colHORAS_APROBADAS_ID"
        Me.colHORAS_APROBADAS_ID.OptionsColumn.AllowEdit = False
        Me.colHORAS_APROBADAS_ID.OptionsColumn.ReadOnly = True
        Me.colHORAS_APROBADAS_ID.OptionsColumn.ShowInCustomizationForm = False
        '
        'colEMPLEADO_ID
        '
        Me.colEMPLEADO_ID.Caption = "Empleado"
        Me.colEMPLEADO_ID.ColumnEdit = Me.gleRut
        Me.colEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.colEMPLEADO_ID.Name = "colEMPLEADO_ID"
        Me.colEMPLEADO_ID.OptionsColumn.AllowEdit = False
        Me.colEMPLEADO_ID.OptionsColumn.ReadOnly = True
        Me.colEMPLEADO_ID.OptionsColumn.ShowInCustomizationForm = False
        Me.colEMPLEADO_ID.Visible = True
        Me.colEMPLEADO_ID.VisibleIndex = 0
        '
        'gleRut
        '
        Me.gleRut.AutoHeight = False
        Me.gleRut.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleRut.Name = "gleRut"
        Me.gleRut.View = Me.GridView1
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colAÑO
        '
        Me.colAÑO.Caption = "Año"
        Me.colAÑO.FieldName = "AÑO"
        Me.colAÑO.Name = "colAÑO"
        Me.colAÑO.OptionsColumn.AllowEdit = False
        Me.colAÑO.OptionsColumn.ReadOnly = True
        Me.colAÑO.OptionsColumn.ShowInCustomizationForm = False
        '
        'colMES
        '
        Me.colMES.Caption = "Mes"
        Me.colMES.FieldName = "MES"
        Me.colMES.Name = "colMES"
        Me.colMES.OptionsColumn.AllowEdit = False
        Me.colMES.OptionsColumn.ReadOnly = True
        Me.colMES.OptionsColumn.ShowInCustomizationForm = False
        '
        'colNRO_MEMO_INTERMO
        '
        Me.colNRO_MEMO_INTERMO.Caption = "Nro.Memo Interno"
        Me.colNRO_MEMO_INTERMO.FieldName = "NRO_MEMO_INTERMO"
        Me.colNRO_MEMO_INTERMO.Name = "colNRO_MEMO_INTERMO"
        Me.colNRO_MEMO_INTERMO.OptionsColumn.AllowEdit = False
        Me.colNRO_MEMO_INTERMO.OptionsColumn.ReadOnly = True
        Me.colNRO_MEMO_INTERMO.OptionsColumn.ShowInCustomizationForm = False
        '
        'colFECHA_MEMO_INTERNO
        '
        Me.colFECHA_MEMO_INTERNO.Caption = "Fecha Memo Interno"
        Me.colFECHA_MEMO_INTERNO.FieldName = "FECHA_MEMO_INTERNO"
        Me.colFECHA_MEMO_INTERNO.Name = "colFECHA_MEMO_INTERNO"
        Me.colFECHA_MEMO_INTERNO.OptionsColumn.AllowEdit = False
        Me.colFECHA_MEMO_INTERNO.OptionsColumn.ReadOnly = True
        Me.colFECHA_MEMO_INTERNO.OptionsColumn.ShowInCustomizationForm = False
        '
        'colDEPTO_ID
        '
        Me.colDEPTO_ID.Caption = "Depto"
        Me.colDEPTO_ID.FieldName = "DEPTO_ID"
        Me.colDEPTO_ID.Name = "colDEPTO_ID"
        Me.colDEPTO_ID.OptionsColumn.AllowEdit = False
        Me.colDEPTO_ID.OptionsColumn.ReadOnly = True
        Me.colDEPTO_ID.OptionsColumn.ShowInCustomizationForm = False
        '
        'colESTADO_REGISTRO
        '
        Me.colESTADO_REGISTRO.Caption = "Estado Registro"
        Me.colESTADO_REGISTRO.FieldName = "ESTADO_REGISTRO"
        Me.colESTADO_REGISTRO.Name = "colESTADO_REGISTRO"
        Me.colESTADO_REGISTRO.OptionsColumn.AllowEdit = False
        Me.colESTADO_REGISTRO.OptionsColumn.ReadOnly = True
        Me.colESTADO_REGISTRO.OptionsColumn.ShowInCustomizationForm = False
        '
        'colHORAS_DIURNAS_PLANIFICADAS
        '
        Me.colHORAS_DIURNAS_PLANIFICADAS.Caption = "Hrs.Diurnas Planificadas"
        Me.colHORAS_DIURNAS_PLANIFICADAS.FieldName = "HORAS_DIURNAS_PLANIF"
        Me.colHORAS_DIURNAS_PLANIFICADAS.Name = "colHORAS_DIURNAS_PLANIFICADAS"
        Me.colHORAS_DIURNAS_PLANIFICADAS.OptionsColumn.AllowEdit = False
        Me.colHORAS_DIURNAS_PLANIFICADAS.Visible = True
        Me.colHORAS_DIURNAS_PLANIFICADAS.VisibleIndex = 1
        '
        'colHORAS_NOCTURNAS_PLANIFICADAS
        '
        Me.colHORAS_NOCTURNAS_PLANIFICADAS.Caption = "Hrs.Nocturnas Planificadas"
        Me.colHORAS_NOCTURNAS_PLANIFICADAS.FieldName = "HORAS_NOCTURNAS_PLANIF"
        Me.colHORAS_NOCTURNAS_PLANIFICADAS.Name = "colHORAS_NOCTURNAS_PLANIFICADAS"
        Me.colHORAS_NOCTURNAS_PLANIFICADAS.OptionsColumn.AllowEdit = False
        Me.colHORAS_NOCTURNAS_PLANIFICADAS.Visible = True
        Me.colHORAS_NOCTURNAS_PLANIFICADAS.VisibleIndex = 2
        '
        'colHORAS_DIURNAS_APROB
        '
        Me.colHORAS_DIURNAS_APROB.Caption = "Hrs.Diurnas Aprobadas"
        Me.colHORAS_DIURNAS_APROB.ColumnEdit = Me.txtHrsAprobadasDiurnas
        Me.colHORAS_DIURNAS_APROB.FieldName = "HORAS_DIURNAS_APROB"
        Me.colHORAS_DIURNAS_APROB.Name = "colHORAS_DIURNAS_APROB"
        Me.colHORAS_DIURNAS_APROB.OptionsColumn.ShowInCustomizationForm = False
        Me.colHORAS_DIURNAS_APROB.Visible = True
        Me.colHORAS_DIURNAS_APROB.VisibleIndex = 3
        '
        'txtHrsAprobadasDiurnas
        '
        Me.txtHrsAprobadasDiurnas.AutoHeight = False
        Me.txtHrsAprobadasDiurnas.DisplayFormat.FormatString = "n0"
        Me.txtHrsAprobadasDiurnas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHrsAprobadasDiurnas.EditFormat.FormatString = "n0"
        Me.txtHrsAprobadasDiurnas.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHrsAprobadasDiurnas.Mask.EditMask = "n0"
        Me.txtHrsAprobadasDiurnas.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtHrsAprobadasDiurnas.Mask.UseMaskAsDisplayFormat = True
        Me.txtHrsAprobadasDiurnas.Name = "txtHrsAprobadasDiurnas"
        '
        'colHORAS_NOCTURNAS_APROB
        '
        Me.colHORAS_NOCTURNAS_APROB.Caption = "Hrs.Nocturnas Aprobadas"
        Me.colHORAS_NOCTURNAS_APROB.ColumnEdit = Me.txtHrsAprobadasNocturnas
        Me.colHORAS_NOCTURNAS_APROB.FieldName = "HORAS_NOCTURNAS_APROB"
        Me.colHORAS_NOCTURNAS_APROB.Name = "colHORAS_NOCTURNAS_APROB"
        Me.colHORAS_NOCTURNAS_APROB.OptionsColumn.ShowInCustomizationForm = False
        Me.colHORAS_NOCTURNAS_APROB.Visible = True
        Me.colHORAS_NOCTURNAS_APROB.VisibleIndex = 4
        '
        'txtHrsAprobadasNocturnas
        '
        Me.txtHrsAprobadasNocturnas.AutoHeight = False
        Me.txtHrsAprobadasNocturnas.DisplayFormat.FormatString = "n0"
        Me.txtHrsAprobadasNocturnas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHrsAprobadasNocturnas.EditFormat.FormatString = "n0"
        Me.txtHrsAprobadasNocturnas.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHrsAprobadasNocturnas.Mask.UseMaskAsDisplayFormat = True
        Me.txtHrsAprobadasNocturnas.Name = "txtHrsAprobadasNocturnas"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.gdcDetalleAprobHorasExtras
        Me.GridView2.Name = "GridView2"
        '
        'gpcDatosHoras
        '
        Me.gpcDatosHoras.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDatosHoras.AppearanceCaption.Options.UseFont = True
        Me.gpcDatosHoras.Controls.Add(Me.btnGuardar)
        Me.gpcDatosHoras.Controls.Add(Me.lblHorasNocturnas)
        Me.gpcDatosHoras.Controls.Add(Me.txtHorasNocturnas)
        Me.gpcDatosHoras.Controls.Add(Me.txtHorasDiurnas)
        Me.gpcDatosHoras.Controls.Add(Me.lblHrsDiurnas)
        Me.gpcDatosHoras.Controls.Add(Me.gleEmpleado)
        Me.gpcDatosHoras.Controls.Add(Me.lblEmpleado)
        Me.gpcDatosHoras.Location = New System.Drawing.Point(8, 168)
        Me.gpcDatosHoras.Name = "gpcDatosHoras"
        Me.gpcDatosHoras.Size = New System.Drawing.Size(992, 120)
        Me.gpcDatosHoras.TabIndex = 7
        Me.gpcDatosHoras.Text = "Datos del Empleado"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(16, 72)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(144, 23)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar Registro Empleado"
        '
        'lblHorasNocturnas
        '
        Me.lblHorasNocturnas.Location = New System.Drawing.Point(680, 24)
        Me.lblHorasNocturnas.Name = "lblHorasNocturnas"
        Me.lblHorasNocturnas.Size = New System.Drawing.Size(160, 16)
        Me.lblHorasNocturnas.TabIndex = 10
        Me.lblHorasNocturnas.Text = "Horas Nocturnas Planificadas"
        '
        'txtHorasNocturnas
        '
        Me.txtHorasNocturnas.Location = New System.Drawing.Point(680, 40)
        Me.txtHorasNocturnas.Name = "txtHorasNocturnas"
        Me.txtHorasNocturnas.Size = New System.Drawing.Size(120, 20)
        Me.txtHorasNocturnas.TabIndex = 9
        '
        'txtHorasDiurnas
        '
        Me.txtHorasDiurnas.Location = New System.Drawing.Point(488, 40)
        Me.txtHorasDiurnas.Name = "txtHorasDiurnas"
        Me.txtHorasDiurnas.Size = New System.Drawing.Size(128, 20)
        Me.txtHorasDiurnas.TabIndex = 8
        '
        'lblHrsDiurnas
        '
        Me.lblHrsDiurnas.Location = New System.Drawing.Point(488, 24)
        Me.lblHrsDiurnas.Name = "lblHrsDiurnas"
        Me.lblHrsDiurnas.Size = New System.Drawing.Size(144, 16)
        Me.lblHrsDiurnas.TabIndex = 4
        Me.lblHrsDiurnas.Text = "Horas Diurnas Planificadas"
        '
        'gleEmpleado
        '
        Me.gleEmpleado.EditValue = ""
        Me.gleEmpleado.Location = New System.Drawing.Point(16, 40)
        Me.gleEmpleado.Name = "gleEmpleado"
        '
        'gleEmpleado.Properties
        '
        Me.gleEmpleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleEmpleado.Properties.View = Me.GridLookUpEdit1View
        Me.gleEmpleado.Size = New System.Drawing.Size(456, 20)
        Me.gleEmpleado.TabIndex = 3
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'lblEmpleado
        '
        Me.lblEmpleado.Location = New System.Drawing.Point(16, 24)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(80, 16)
        Me.lblEmpleado.TabIndex = 1
        Me.lblEmpleado.Text = "Empleado"
        '
        'frmIngresoHorasExtrasAprobadasDepto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1008, 420)
        Me.Controls.Add(Me.gpcDatosHoras)
        Me.Controls.Add(Me.gdcDetalleAprobHorasExtras)
        Me.Controls.Add(Me.gpcBotonesEncabezado)
        Me.Controls.Add(Me.gpcInformacionMemoInterno)
        Me.Name = "frmIngresoHorasExtrasAprobadasDepto"
        Me.Text = "Ingreso Horas Extras Aprobadas por Departamento"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcBotonesEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBotonesEncabezado.ResumeLayout(False)
        CType(Me.gpcInformacionMemoInterno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcInformacionMemoInterno.ResumeLayout(False)
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueNumeroMemorandum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaMemorando.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroMemo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAño.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcDetalleAprobHorasExtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleAprobHorasExtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleRut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHrsAprobadasDiurnas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHrsAprobadasNocturnas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDatosHoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatosHoras.ResumeLayout(False)
        CType(Me.txtHorasNocturnas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHorasDiurnas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim empleado As Empleado
    Dim botonActivo As String

  
    Private Sub asignarCampos(ByVal horas_aprobadas_id As Integer, ByVal horasDiurnasAprobadas As Decimal, ByVal horasNocturnasAprobadas As Decimal)

    End Sub
    Private Sub frmIngresoHorasExtrasAprobadasDepto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empleado = New empleado
        Botones("Nuevo")
        llenarDepto()
        llenarEmpleadoGrilla()
        llenarEmpleadoInput()
        gpcInformacionMemoInterno.Enabled = False
        gpcDatosHoras.Enabled = False
    End Sub

    Private Sub btnNuevoMemorandum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoMemorandum.Click
        Botones("Nuevo")
        Me.gpcDatosHoras.Enabled = True
        Me.gdcDetalleAprobHorasExtras.DataSource = Nothing
    End Sub

    Private Sub btnEliminarMemorandum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarMemorandum.Click
        If Me.gdvDetalleAprobHorasExtras.RowCount = 0 Then
            MsgBox("No puede eliminar sin detalle", MsgBoxStyle.Information)
            Exit Sub
        End If
        If (MessageBox.Show("¿Desea eliminar completamente el memorandum?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            empleado.eliminarHorasAprobadas(txtAño.EditValue, txtMes.EditValue, lueNumeroMemorandum.EditValue)
            empleado = New empleado
            Botones("Nuevo")
            llenarDepto()
            llenarEmpleadoGrilla()
            llenarEmpleadoInput()
            RefrescarGrilla()
            gpcInformacionMemoInterno.Enabled = False
            gpcDatosHoras.Enabled = False
        End If
    End Sub

    Private Sub btnEditarMemorandum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarMemorandum.Click
        Botones("Editar")
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click

    End Sub

    Private Sub InicializaControles()
        Me.txtAño.EditValue = 0
        Me.txtMes.EditValue = 0
        Me.lueDepartamento.EditValue = -1
        Me.lueNumeroMemorandum.Visible = False
        Me.lueNumeroMemorandum.EditValue = -1
        Me.txtNumeroMemo.Visible = True
        Me.txtNumeroMemo.EditValue = 0
        Me.gleEmpleado.EditValue = -1
        Me.txtHorasDiurnas.EditValue = 0
        Me.txtHorasNocturnas.EditValue = 0
    End Sub

    Private Sub Botones(ByVal Accion As String)
        Select Case Accion
            Case "Nuevo"
                btnNuevoMemorandum.Enabled = True
                btnEliminarMemorandum.Enabled = False
                btnBuscarMemorandum.Enabled = True
                'btnEmiteResolucion.Enabled = False
                btnVisualizar.Enabled = False
                InicializaControles()
                gpcInformacionMemoInterno.Enabled = True
                lueNumeroMemorandum.Visible = False
                txtNumeroMemo.Visible = True
                botonActivo = "Nuevo"
            Case "Editar"
                btnNuevoMemorandum.Enabled = True
                btnEliminarMemorandum.Enabled = True
                btnBuscarMemorandum.Enabled = False
                'btnEmiteResolucion.Enabled = False
                btnVisualizar.Enabled = False
                InicializaControles()
                gpcInformacionMemoInterno.Enabled = True
                lueNumeroMemorandum.Visible = True
                txtNumeroMemo.Visible = False
                botonActivo = "Editar"
            Case "Eliminar"
            Case "Guardar"
            Case "Emite Resolucion"
            Case "Visualizar"
        End Select

    End Sub

    Private Sub llenarDepto()
        lueDepartamento.Properties.Columns.Clear()
        With lueDepartamento
            With .Properties.Columns
                .Add(New LookUpColumnInfo("SUB_DEPTO_ID", "ID Depto", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Departamento", 300, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueDepartamento.Properties.DataSource = repositorio.dvSubDepto
        lueDepartamento.Properties.DisplayMember = "DESCRIPCION"
        lueDepartamento.Properties.NullText = ""
        lueDepartamento.Properties.PopupWidth = 200
        lueDepartamento.Properties.ValueMember = "SUB_DEPTO_ID"
    End Sub

    Private Sub llenarNumeroMemorandum(ByVal deptoId As Integer, ByVal Año As Integer)
        lueNumeroMemorandum.Properties.Columns.Clear()
        With lueNumeroMemorandum
            With .Properties.Columns
                .Add(New LookUpColumnInfo("NRO_MEMO_INTERMO", "Numero Memo", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("FECHA_MEMO_INTERNO", "Fecha Memo", 50, DevExpress.Utils.FormatType.DateTime, "d", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("TIPO_PROCESO", "Tipo Calculo", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION_PROCESO", "Tipo Proceso", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("MES", "Mes", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueNumeroMemorandum.Properties.DataSource = empleado.recuperarHorasAprobadasPorDepto(deptoId, Año)
        lueNumeroMemorandum.Properties.DisplayMember = "NRO_MEMO_INTERMO"
        lueNumeroMemorandum.Properties.NullText = ""
        lueNumeroMemorandum.Properties.PopupWidth = 400
        lueNumeroMemorandum.Properties.ValueMember = "NRO_MEMO_INTERMO"
    End Sub

    Public Sub llenarEmpleadoGrilla()
        gleRut.ViewType = Repository.GridLookUpViewType.GridView
        gleRut.View.OptionsBehavior.AutoPopulateColumns = False
        gleRut.DataSource = repositorio.dvEmpleadoVista
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

    Public Sub llenarEmpleadoInput()
        gleEmpleado.Properties.EditValueChangedFiringDelay = 1200
        gleEmpleado.Properties.EditValueChangedFiringMode = EditValueChangedFiringMode.Buffered
        'Dos segundos se espera antes de gatillar la búsqueda (EditValueChanged)

        gleEmpleado.Properties.ViewType = Repository.GridLookUpViewType.GridView
        gleEmpleado.Properties.View.OptionsBehavior.AutoPopulateColumns = False
        gleEmpleado.Properties.DataSource = repositorio.dvEmpleadosPlantaContrataActivos
        gleEmpleado.Properties.DisplayMember = "NOMBRE_COMPLETO"

        Dim col1 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("RUT")
        col1.VisibleIndex = 0
        col1.Caption = "RUT"
        col1.Visible = False

        Dim col2 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("APELLIDO_PATERNO")
        col2.VisibleIndex = 1
        col2.Caption = "Apellido Paterno"
        col2.Visible = False

        Dim col3 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("APELLIDO_MATERNO")
        col3.VisibleIndex = 2
        col3.Caption = "Apellido Materno"
        col3.Visible = False

        Dim col4 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("NOMBRES")
        col4.VisibleIndex = 3
        col4.Caption = "Nombres"
        col4.Visible = False

        Dim col5 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("DESC_CALIDAD_JURIDICA")
        col5.VisibleIndex = 5
        col5.Caption = "Calidad Jurídica"
        col5.Visible = True

        Dim col6 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("DESC_ESTADO")
        col6.VisibleIndex = 4
        col6.Caption = "Estado"

        Dim col7 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("NOMBRE_COMPLETO")
        col7.VisibleIndex = 0
        col7.Caption = "Nombre Completo"
        col7.Visible = True

        gleEmpleado.Properties.ValueMember = "EMPLEADO_ID"

        gleEmpleado.Properties.View.BestFitColumns()
        gleEmpleado.Properties.PopupFormWidth = 600

        gleEmpleado.Text = ""
        gleEmpleado.EditValue = -1
    End Sub

    Private Sub lueDepartamento_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueDepartamento.EditValueChanged, lueNumeroMemorandum.EditValueChanged, txtAño.EditValueChanged
        If Me.txtAño.EditValue > 0 And Me.lueDepartamento.EditValue > 0 Then
            If botonActivo = "Editar" Then
                llenarNumeroMemorandum(Me.lueDepartamento.EditValue, Me.txtAño.EditValue)
                If Me.lueNumeroMemorandum.EditValue > 0 Then
                    Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(lueNumeroMemorandum, DevExpress.XtraEditors.LookUpEdit)
                    Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
                    Me.dedFechaMemorando.EditValue = row("FECHA_MEMO_INTERNO")
                    Me.txtMes.EditValue = row("MES")
                    Me.rdgTipoProceso.EditValue = row("TIPO_PROCESO")
                    Me.gpcDatosHoras.Enabled = True
                End If
                RefrescarGrilla()
            End If
        End If
    End Sub

    Private Sub RefrescarGrilla()
        Dim numeroMemorandum As Integer
        If botonActivo = "Editar" Then
            numeroMemorandum = Me.lueNumeroMemorandum.EditValue
        Else
            numeroMemorandum = Me.txtNumeroMemo.EditValue
        End If
        Me.gdcDetalleAprobHorasExtras.DataSource = Nothing
        Me.gdcDetalleAprobHorasExtras.DataSource = empleado.recuperarHorasAprobadas(numeroMemorandum, Me.txtAño.EditValue, Me.txtMes.EditValue, Me.lueDepartamento.EditValue)
        Me.gdvDetalleAprobHorasExtras.RefreshData()
    End Sub

    Private Sub gdvDetalleAprobHorasExtras_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvDetalleAprobHorasExtras.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gdvDetalleAprobHorasExtras_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvDetalleAprobHorasExtras.RowUpdated
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetalleAprobHorasExtras
        Dim horasAprobadasId As Integer = view.GetRowCellValue(view.FocusedRowHandle, "HORAS_APROBADAS_ID")
        empleado.actualizaHorasExtrasAprobadas(horasAprobadasId, view.GetRowCellValue(view.FocusedRowHandle, "HORAS_DIURNAS_APROB"), view.GetRowCellValue(view.FocusedRowHandle, "HORAS_NOCTURNAS_APROB"))
        RefrescarGrilla()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If validaControlesEncabezado(botonActivo) Then
            Dim numeroMemorandum As Integer
            If botonActivo = "Editar" Then
                numeroMemorandum = Me.lueNumeroMemorandum.EditValue
            Else
                numeroMemorandum = Me.txtNumeroMemo.EditValue
            End If
            empleado.insertaHorasExtrasAprobadas(gleEmpleado.EditValue, _
                                               Me.txtAño.EditValue, _
                                               Me.txtMes.EditValue, _
                                               numeroMemorandum, _
                                               Me.dedFechaMemorando.EditValue, _
                                               Me.txtHorasDiurnas.EditValue, _
                                               Me.txtHorasNocturnas.EditValue, _
                                               Me.lueDepartamento.EditValue, 1, Me.rdgTipoProceso.EditValue)
            Me.gleEmpleado.EditValue = -1
            Me.txtHorasDiurnas.EditValue = 0
            Me.txtHorasNocturnas.EditValue = 0
            RefrescarGrilla()
        End If

    End Sub
    Function validaControlesEncabezado(ByVal botonRegistro As String) As Boolean
        Dim Continua As Boolean = True
        Dim mensaje As String

        If Me.txtAño.EditValue <= 0 Then
            txtAño.ErrorText = "Falta ingresar año"
            Continua = False
        End If
        If Me.lueDepartamento.EditValue <= 0 Then
            lueDepartamento.ErrorText = "Falta seleccionar departamento"
            Continua = False
        End If
        If botonRegistro = "Editar" Then
            If Me.lueNumeroMemorandum.EditValue <= 0 Then
                lueNumeroMemorandum.ErrorText = "Falta seleccionar numero memorandum"
                Continua = False
            End If
        ElseIf botonRegistro = "Nuevo" Then
            If Me.txtNumeroMemo.EditValue <= 0 Then
                txtNumeroMemo.ErrorText = "Falta seleccionar numero memorandum"
                Continua = False
            End If
        End If
        If Me.txtMes.EditValue <= 0 Then
            Me.txtMes.ErrorText = "Falta ingresar mes"
            Continua = False
        End If
        If CType(Me.dedFechaMemorando.EditValue, Date).Year < Me.txtAño.EditValue Then
            dedFechaMemorando.ErrorText = "Fecha memorandum es anterior al año ingresado"
            Continua = False
        End If
        If gleEmpleado.EditValue <= 0 Then
            gleEmpleado.ErrorText = "Falta seleccionar un empleado de la lista"
            Continua = False
        Else
            mensaje = empleado.recuperarHorasAprobadasPorEmpleado(gleEmpleado.EditValue, txtAño.EditValue, txtMes.EditValue)
            If mensaje.Length > 0 Then
                gleEmpleado.ErrorText = "No se puede agregar el empleado, ya existe en el " & mensaje
                Continua = False
            End If

        End If
        If Me.txtHorasDiurnas.EditValue = 0 And Me.txtHorasNocturnas.EditValue = 0 Then
            Me.txtHorasDiurnas.ErrorText = "Horas diurnas no puede ser cero"
            Me.txtHorasNocturnas.ErrorText = "Horas nocturnas no puede ser cero"
            Continua = False
        ElseIf (Me.txtHorasDiurnas.EditValue > 40) Then
            Me.txtHorasDiurnas.ErrorText = "Horas diurnas no puede supera las 40 horas permitidas legalmente"
            Continua = False
        End If
        Return Continua
    End Function

    Private Sub gdvDetalleAprobHorasExtras_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvDetalleAprobHorasExtras.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            Dim myview As DevExpress.XtraGrid.Views.Grid.GridView = sender
            If myview.IsNewItemRow(myview.FocusedRowHandle) Then
                MessageBox.Show("Para cancelar el nuevo registro debe presionar la tecla Esc (Escape)", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                    Dim iDHorasAprobadas As Integer = view.GetRowCellValue(view.FocusedRowHandle, "HORAS_APROBADAS_ID")
                    view.DeleteRow(view.FocusedRowHandle)
                    Try
                        empleado.eliminarDetalleHorasAprobadas(iDHorasAprobadas)
                        RefrescarGrilla()
                        MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Information)
                    Catch ex As Exception
                        MsgBox("Ha ocurrido un error al intentar eliminar el registro " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                End If
            End If
        End If
    End Sub

End Class
