Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns


Public Class frmFeriadoLegalEmpleado
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
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents gpcSaldoDiasFestivos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDiasPendientes As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDiasPendientes As System.Windows.Forms.Label
    Friend WithEvents txtTotalDiasSolicitados As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTotalDiasSoliciatdos As System.Windows.Forms.Label
    Friend WithEvents txtTotalDiasAnual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDiasTotalAnual As System.Windows.Forms.Label
    Friend WithEvents txtDiasPeriodoAnterior As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDiasPeriodoAnterior As System.Windows.Forms.Label
    Friend WithEvents txtDiasAdicionales As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDiasAdicionales As System.Windows.Forms.Label
    Friend WithEvents lblDiasLegalFeriado As System.Windows.Forms.Label
    Friend WithEvents dvPeriodo As System.Data.DataView
    Friend WithEvents txtDiasLegalFeriado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gdcFeriadoLegal As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalleFeriadoLegal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EVENTO_ADMINISTRATIVO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_NACIMIENTO_HIJO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JORNADA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIAS_HABILES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_INICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_TERMINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIAS_RECORRIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_REGRESO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RESOLUCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OBSERVACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFechaIngreso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FECHA_DIGITACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EVENTO_ADMINISTRATIVO_DET_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dedFechaInicio As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents txtdiasHabiles As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PERIODO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSaldoDiasFeriadoLegal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEstadoEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblEstadoEmpleado As System.Windows.Forms.Label
    Friend WithEvents USUARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents prsFeriadoLegal As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents btnEmiteDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNombres As System.Windows.Forms.Label
    Friend WithEvents lblRut As System.Windows.Forms.Label
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gleRut As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents TIPO_FALLECIMIENTO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFeriadoLegalEmpleado))
        Me.gpcEncabezado = New DevExpress.XtraEditors.GroupControl()
        Me.txtNombres = New DevExpress.XtraEditors.TextEdit()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.gleRut = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnEmiteDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.txtEstadoEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.lblEstadoEmpleado = New System.Windows.Forms.Label()
        Me.btnSaldoDiasFeriadoLegal = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFechaIngreso = New DevExpress.XtraEditors.TextEdit()
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.gpcSaldoDiasFestivos = New DevExpress.XtraEditors.GroupControl()
        Me.txtDiasLegalFeriado = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiasPendientes = New DevExpress.XtraEditors.TextEdit()
        Me.lblDiasPendientes = New System.Windows.Forms.Label()
        Me.txtTotalDiasSolicitados = New DevExpress.XtraEditors.TextEdit()
        Me.lblTotalDiasSoliciatdos = New System.Windows.Forms.Label()
        Me.txtTotalDiasAnual = New DevExpress.XtraEditors.TextEdit()
        Me.lblDiasTotalAnual = New System.Windows.Forms.Label()
        Me.txtDiasPeriodoAnterior = New DevExpress.XtraEditors.TextEdit()
        Me.lblDiasPeriodoAnterior = New System.Windows.Forms.Label()
        Me.txtDiasAdicionales = New DevExpress.XtraEditors.TextEdit()
        Me.lblDiasAdicionales = New System.Windows.Forms.Label()
        Me.lblDiasLegalFeriado = New System.Windows.Forms.Label()
        Me.dvPeriodo = New System.Data.DataView()
        Me.gdcFeriadoLegal = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleFeriadoLegal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.EVENTO_ADMINISTRATIVO_DET_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EVENTO_ADMINISTRATIVO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_NACIMIENTO_HIJO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.JORNADA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIAS_HABILES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtdiasHabiles = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.FECHA_INICIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dedFechaInicio = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.FECHA_TERMINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIAS_RECORRIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_REGRESO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RESOLUCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OBSERVACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_DIGITACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PERIODO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.USUARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TIPO_FALLECIMIENTO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.prsFeriadoLegal = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcEncabezado.SuspendLayout()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstadoEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcSaldoDiasFestivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSaldoDiasFestivos.SuspendLayout()
        CType(Me.txtDiasLegalFeriado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiasPendientes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDiasSolicitados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDiasAnual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiasPeriodoAnterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiasAdicionales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcFeriadoLegal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleFeriadoLegal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdiasHabiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaInicio.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prsFeriadoLegal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcEncabezado
        '
        Me.gpcEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcEncabezado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcEncabezado.AppearanceCaption.Options.UseFont = True
        Me.gpcEncabezado.Controls.Add(Me.txtNombres)
        Me.gpcEncabezado.Controls.Add(Me.lblNombres)
        Me.gpcEncabezado.Controls.Add(Me.lblRut)
        Me.gpcEncabezado.Controls.Add(Me.gleRut)
        Me.gpcEncabezado.Controls.Add(Me.btnEmiteDetalle)
        Me.gpcEncabezado.Controls.Add(Me.txtEstadoEmpleado)
        Me.gpcEncabezado.Controls.Add(Me.lblEstadoEmpleado)
        Me.gpcEncabezado.Controls.Add(Me.btnSaldoDiasFeriadoLegal)
        Me.gpcEncabezado.Controls.Add(Me.txtFechaIngreso)
        Me.gpcEncabezado.Controls.Add(Me.lblFechaIngreso)
        Me.gpcEncabezado.Controls.Add(Me.luePeriodo)
        Me.gpcEncabezado.Controls.Add(Me.lblPeriodo)
        Me.gpcEncabezado.Location = New System.Drawing.Point(8, 8)
        Me.gpcEncabezado.Name = "gpcEncabezado"
        Me.gpcEncabezado.Size = New System.Drawing.Size(816, 136)
        Me.gpcEncabezado.TabIndex = 1
        Me.gpcEncabezado.Text = "Empleado"
        '
        'txtNombres
        '
        Me.txtNombres.Enabled = False
        Me.txtNombres.EnterMoveNextControl = True
        Me.txtNombres.Location = New System.Drawing.Point(120, 76)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombres.Properties.MaxLength = 30
        Me.txtNombres.Size = New System.Drawing.Size(328, 20)
        Me.txtNombres.TabIndex = 53
        '
        'lblNombres
        '
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.Location = New System.Drawing.Point(8, 80)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(96, 16)
        Me.lblNombres.TabIndex = 54
        Me.lblNombres.Text = "Nombres"
        Me.lblNombres.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRut
        '
        Me.lblRut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRut.Location = New System.Drawing.Point(7, 53)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(96, 16)
        Me.lblRut.TabIndex = 52
        Me.lblRut.Text = "Rut"
        Me.lblRut.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gleRut
        '
        Me.gleRut.Cursor = System.Windows.Forms.Cursors.Default
        Me.gleRut.EditValue = ""
        Me.gleRut.Location = New System.Drawing.Point(120, 53)
        Me.gleRut.Name = "gleRut"
        Me.gleRut.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.gleRut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleRut.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.gleRut.Properties.View = Me.GridView1
        Me.gleRut.Size = New System.Drawing.Size(144, 20)
        Me.gleRut.TabIndex = 51
        '
        'GridView1
        '
        Me.GridView1.AppearancePrint.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridView1.AppearancePrint.OddRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridView1.AppearancePrint.OddRow.Options.UseBackColor = True
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'btnEmiteDetalle
        '
        Me.btnEmiteDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEmiteDetalle.Location = New System.Drawing.Point(512, 75)
        Me.btnEmiteDetalle.Name = "btnEmiteDetalle"
        Me.btnEmiteDetalle.Size = New System.Drawing.Size(208, 23)
        Me.btnEmiteDetalle.TabIndex = 11
        Me.btnEmiteDetalle.Text = "Emite Detalle"
        '
        'txtEstadoEmpleado
        '
        Me.txtEstadoEmpleado.Enabled = False
        Me.txtEstadoEmpleado.Location = New System.Drawing.Point(350, 103)
        Me.txtEstadoEmpleado.Name = "txtEstadoEmpleado"
        Me.txtEstadoEmpleado.Size = New System.Drawing.Size(96, 20)
        Me.txtEstadoEmpleado.TabIndex = 10
        '
        'lblEstadoEmpleado
        '
        Me.lblEstadoEmpleado.Location = New System.Drawing.Point(240, 108)
        Me.lblEstadoEmpleado.Name = "lblEstadoEmpleado"
        Me.lblEstadoEmpleado.Size = New System.Drawing.Size(96, 16)
        Me.lblEstadoEmpleado.TabIndex = 9
        Me.lblEstadoEmpleado.Text = "Estado Empleado"
        Me.lblEstadoEmpleado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnSaldoDiasFeriadoLegal
        '
        Me.btnSaldoDiasFeriadoLegal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaldoDiasFeriadoLegal.Location = New System.Drawing.Point(512, 48)
        Me.btnSaldoDiasFeriadoLegal.Name = "btnSaldoDiasFeriadoLegal"
        Me.btnSaldoDiasFeriadoLegal.Size = New System.Drawing.Size(208, 23)
        Me.btnSaldoDiasFeriadoLegal.TabIndex = 8
        Me.btnSaldoDiasFeriadoLegal.Text = "Genera Saldo Dias Feriado Legal"
        '
        'txtFechaIngreso
        '
        Me.txtFechaIngreso.Enabled = False
        Me.txtFechaIngreso.Location = New System.Drawing.Point(120, 104)
        Me.txtFechaIngreso.Name = "txtFechaIngreso"
        Me.txtFechaIngreso.Size = New System.Drawing.Size(96, 20)
        Me.txtFechaIngreso.TabIndex = 7
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.Location = New System.Drawing.Point(24, 108)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(80, 16)
        Me.lblFechaIngreso.TabIndex = 6
        Me.lblFechaIngreso.Text = "Fecha Ingreso"
        Me.lblFechaIngreso.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(120, 28)
        Me.luePeriodo.Name = "luePeriodo"
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(144, 20)
        Me.luePeriodo.TabIndex = 2
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(56, 32)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 16)
        Me.lblPeriodo.TabIndex = 0
        Me.lblPeriodo.Text = "Año"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gpcSaldoDiasFestivos
        '
        Me.gpcSaldoDiasFestivos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSaldoDiasFestivos.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSaldoDiasFestivos.AppearanceCaption.Options.UseFont = True
        Me.gpcSaldoDiasFestivos.Controls.Add(Me.txtDiasLegalFeriado)
        Me.gpcSaldoDiasFestivos.Controls.Add(Me.txtDiasPendientes)
        Me.gpcSaldoDiasFestivos.Controls.Add(Me.lblDiasPendientes)
        Me.gpcSaldoDiasFestivos.Controls.Add(Me.txtTotalDiasSolicitados)
        Me.gpcSaldoDiasFestivos.Controls.Add(Me.lblTotalDiasSoliciatdos)
        Me.gpcSaldoDiasFestivos.Controls.Add(Me.txtTotalDiasAnual)
        Me.gpcSaldoDiasFestivos.Controls.Add(Me.lblDiasTotalAnual)
        Me.gpcSaldoDiasFestivos.Controls.Add(Me.txtDiasPeriodoAnterior)
        Me.gpcSaldoDiasFestivos.Controls.Add(Me.lblDiasPeriodoAnterior)
        Me.gpcSaldoDiasFestivos.Controls.Add(Me.txtDiasAdicionales)
        Me.gpcSaldoDiasFestivos.Controls.Add(Me.lblDiasAdicionales)
        Me.gpcSaldoDiasFestivos.Controls.Add(Me.lblDiasLegalFeriado)
        Me.gpcSaldoDiasFestivos.Location = New System.Drawing.Point(8, 144)
        Me.gpcSaldoDiasFestivos.Name = "gpcSaldoDiasFestivos"
        Me.gpcSaldoDiasFestivos.Size = New System.Drawing.Size(816, 104)
        Me.gpcSaldoDiasFestivos.TabIndex = 54
        Me.gpcSaldoDiasFestivos.Text = "Saldos Días Feriado Legal"
        '
        'txtDiasLegalFeriado
        '
        Me.txtDiasLegalFeriado.Enabled = False
        Me.txtDiasLegalFeriado.Location = New System.Drawing.Point(48, 56)
        Me.txtDiasLegalFeriado.Name = "txtDiasLegalFeriado"
        Me.txtDiasLegalFeriado.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDiasLegalFeriado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDiasLegalFeriado.Size = New System.Drawing.Size(32, 20)
        Me.txtDiasLegalFeriado.TabIndex = 60
        '
        'txtDiasPendientes
        '
        Me.txtDiasPendientes.Enabled = False
        Me.txtDiasPendientes.Location = New System.Drawing.Point(744, 56)
        Me.txtDiasPendientes.Name = "txtDiasPendientes"
        Me.txtDiasPendientes.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDiasPendientes.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDiasPendientes.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiasPendientes.Properties.MaxLength = 1
        Me.txtDiasPendientes.Size = New System.Drawing.Size(32, 20)
        Me.txtDiasPendientes.TabIndex = 59
        '
        'lblDiasPendientes
        '
        Me.lblDiasPendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiasPendientes.Location = New System.Drawing.Point(712, 32)
        Me.lblDiasPendientes.Name = "lblDiasPendientes"
        Me.lblDiasPendientes.Size = New System.Drawing.Size(96, 16)
        Me.lblDiasPendientes.TabIndex = 58
        Me.lblDiasPendientes.Text = "Días Pendientes"
        Me.lblDiasPendientes.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTotalDiasSolicitados
        '
        Me.txtTotalDiasSolicitados.Enabled = False
        Me.txtTotalDiasSolicitados.Location = New System.Drawing.Point(616, 56)
        Me.txtTotalDiasSolicitados.Name = "txtTotalDiasSolicitados"
        Me.txtTotalDiasSolicitados.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalDiasSolicitados.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTotalDiasSolicitados.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalDiasSolicitados.Properties.MaxLength = 1
        Me.txtTotalDiasSolicitados.Size = New System.Drawing.Size(32, 20)
        Me.txtTotalDiasSolicitados.TabIndex = 57
        '
        'lblTotalDiasSoliciatdos
        '
        Me.lblTotalDiasSoliciatdos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDiasSoliciatdos.Location = New System.Drawing.Point(560, 32)
        Me.lblTotalDiasSoliciatdos.Name = "lblTotalDiasSoliciatdos"
        Me.lblTotalDiasSoliciatdos.Size = New System.Drawing.Size(128, 16)
        Me.lblTotalDiasSoliciatdos.TabIndex = 56
        Me.lblTotalDiasSoliciatdos.Text = "Total Días Solicitados"
        Me.lblTotalDiasSoliciatdos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTotalDiasAnual
        '
        Me.txtTotalDiasAnual.Enabled = False
        Me.txtTotalDiasAnual.Location = New System.Drawing.Point(472, 56)
        Me.txtTotalDiasAnual.Name = "txtTotalDiasAnual"
        Me.txtTotalDiasAnual.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalDiasAnual.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTotalDiasAnual.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalDiasAnual.Properties.MaxLength = 1
        Me.txtTotalDiasAnual.Size = New System.Drawing.Size(32, 20)
        Me.txtTotalDiasAnual.TabIndex = 55
        '
        'lblDiasTotalAnual
        '
        Me.lblDiasTotalAnual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiasTotalAnual.Location = New System.Drawing.Point(432, 32)
        Me.lblDiasTotalAnual.Name = "lblDiasTotalAnual"
        Me.lblDiasTotalAnual.Size = New System.Drawing.Size(96, 16)
        Me.lblDiasTotalAnual.TabIndex = 54
        Me.lblDiasTotalAnual.Text = "Total Días Anual"
        Me.lblDiasTotalAnual.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDiasPeriodoAnterior
        '
        Me.txtDiasPeriodoAnterior.Enabled = False
        Me.txtDiasPeriodoAnterior.Location = New System.Drawing.Point(320, 56)
        Me.txtDiasPeriodoAnterior.Name = "txtDiasPeriodoAnterior"
        Me.txtDiasPeriodoAnterior.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDiasPeriodoAnterior.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDiasPeriodoAnterior.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiasPeriodoAnterior.Properties.MaxLength = 1
        Me.txtDiasPeriodoAnterior.Size = New System.Drawing.Size(32, 20)
        Me.txtDiasPeriodoAnterior.TabIndex = 53
        '
        'lblDiasPeriodoAnterior
        '
        Me.lblDiasPeriodoAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiasPeriodoAnterior.Location = New System.Drawing.Point(272, 32)
        Me.lblDiasPeriodoAnterior.Name = "lblDiasPeriodoAnterior"
        Me.lblDiasPeriodoAnterior.Size = New System.Drawing.Size(128, 16)
        Me.lblDiasPeriodoAnterior.TabIndex = 52
        Me.lblDiasPeriodoAnterior.Text = "Días Período Anterior"
        Me.lblDiasPeriodoAnterior.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDiasAdicionales
        '
        Me.txtDiasAdicionales.Enabled = False
        Me.txtDiasAdicionales.Location = New System.Drawing.Point(176, 56)
        Me.txtDiasAdicionales.Name = "txtDiasAdicionales"
        Me.txtDiasAdicionales.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDiasAdicionales.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDiasAdicionales.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiasAdicionales.Properties.MaxLength = 1
        Me.txtDiasAdicionales.Size = New System.Drawing.Size(32, 20)
        Me.txtDiasAdicionales.TabIndex = 51
        '
        'lblDiasAdicionales
        '
        Me.lblDiasAdicionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiasAdicionales.Location = New System.Drawing.Point(152, 32)
        Me.lblDiasAdicionales.Name = "lblDiasAdicionales"
        Me.lblDiasAdicionales.Size = New System.Drawing.Size(96, 16)
        Me.lblDiasAdicionales.TabIndex = 50
        Me.lblDiasAdicionales.Text = "Días Adicionales"
        Me.lblDiasAdicionales.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDiasLegalFeriado
        '
        Me.lblDiasLegalFeriado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiasLegalFeriado.Location = New System.Drawing.Point(8, 32)
        Me.lblDiasLegalFeriado.Name = "lblDiasLegalFeriado"
        Me.lblDiasLegalFeriado.Size = New System.Drawing.Size(112, 16)
        Me.lblDiasLegalFeriado.TabIndex = 48
        Me.lblDiasLegalFeriado.Text = "Días Legal Feriado"
        Me.lblDiasLegalFeriado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gdcFeriadoLegal
        '
        Me.gdcFeriadoLegal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcFeriadoLegal.Location = New System.Drawing.Point(8, 248)
        Me.gdcFeriadoLegal.MainView = Me.gdvDetalleFeriadoLegal
        Me.gdcFeriadoLegal.Name = "gdcFeriadoLegal"
        Me.gdcFeriadoLegal.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.dedFechaInicio, Me.txtdiasHabiles})
        Me.gdcFeriadoLegal.Size = New System.Drawing.Size(816, 232)
        Me.gdcFeriadoLegal.TabIndex = 55
        Me.gdcFeriadoLegal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleFeriadoLegal})
        '
        'gdvDetalleFeriadoLegal
        '
        Me.gdvDetalleFeriadoLegal.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvDetalleFeriadoLegal.Appearance.FooterPanel.Options.UseFont = True
        Me.gdvDetalleFeriadoLegal.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.EVENTO_ADMINISTRATIVO_DET_ID, Me.EVENTO_ADMINISTRATIVO_ID, Me.FECHA_NACIMIENTO_HIJO, Me.JORNADA_ID, Me.DIAS_HABILES, Me.FECHA_INICIO, Me.FECHA_TERMINO, Me.DIAS_RECORRIDO, Me.FECHA_REGRESO, Me.RESOLUCION, Me.OBSERVACION, Me.FECHA_DIGITACION, Me.PERIODO_ID, Me.USUARIO, Me.TIPO_FALLECIMIENTO_ID})
        Me.gdvDetalleFeriadoLegal.GridControl = Me.gdcFeriadoLegal
        Me.gdvDetalleFeriadoLegal.Name = "gdvDetalleFeriadoLegal"
        Me.gdvDetalleFeriadoLegal.NewItemRowText = "Nuevo Registro"
        Me.gdvDetalleFeriadoLegal.OptionsNavigation.EnterMoveNextColumn = True
        Me.gdvDetalleFeriadoLegal.OptionsPrint.UsePrintStyles = True
        Me.gdvDetalleFeriadoLegal.OptionsView.ColumnAutoWidth = False
        Me.gdvDetalleFeriadoLegal.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gdvDetalleFeriadoLegal.OptionsView.ShowFooter = True
        Me.gdvDetalleFeriadoLegal.OptionsView.ShowGroupPanel = False
        '
        'EVENTO_ADMINISTRATIVO_DET_ID
        '
        Me.EVENTO_ADMINISTRATIVO_DET_ID.Caption = "Id Evento Admin Det"
        Me.EVENTO_ADMINISTRATIVO_DET_ID.FieldName = "EVENTO_ADMINISTRATIVO_DET_ID"
        Me.EVENTO_ADMINISTRATIVO_DET_ID.Name = "EVENTO_ADMINISTRATIVO_DET_ID"
        '
        'EVENTO_ADMINISTRATIVO_ID
        '
        Me.EVENTO_ADMINISTRATIVO_ID.Caption = "ID Evento Admin Header"
        Me.EVENTO_ADMINISTRATIVO_ID.FieldName = "EVENTO_ADMINISTRATIVO_ID"
        Me.EVENTO_ADMINISTRATIVO_ID.Name = "EVENTO_ADMINISTRATIVO_ID"
        Me.EVENTO_ADMINISTRATIVO_ID.Width = 85
        '
        'FECHA_NACIMIENTO_HIJO
        '
        Me.FECHA_NACIMIENTO_HIJO.Caption = "Fecha Nac.Hijo"
        Me.FECHA_NACIMIENTO_HIJO.FieldName = "FECHA_NACIMIENTO_HIJO"
        Me.FECHA_NACIMIENTO_HIJO.Name = "FECHA_NACIMIENTO_HIJO"
        '
        'JORNADA_ID
        '
        Me.JORNADA_ID.Caption = "ID Jornada"
        Me.JORNADA_ID.FieldName = "JORNADA_ID"
        Me.JORNADA_ID.Name = "JORNADA_ID"
        '
        'DIAS_HABILES
        '
        Me.DIAS_HABILES.Caption = "Días Hábiles"
        Me.DIAS_HABILES.ColumnEdit = Me.txtdiasHabiles
        Me.DIAS_HABILES.FieldName = "DIAS_HABILES"
        Me.DIAS_HABILES.Name = "DIAS_HABILES"
        Me.DIAS_HABILES.SummaryItem.DisplayFormat = "Total Días: {0:n0}"
        Me.DIAS_HABILES.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.DIAS_HABILES.Visible = True
        Me.DIAS_HABILES.VisibleIndex = 0
        Me.DIAS_HABILES.Width = 110
        '
        'txtdiasHabiles
        '
        Me.txtdiasHabiles.AutoHeight = False
        Me.txtdiasHabiles.DisplayFormat.FormatString = "n0"
        Me.txtdiasHabiles.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtdiasHabiles.EditFormat.FormatString = "n0"
        Me.txtdiasHabiles.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtdiasHabiles.Mask.EditMask = "n0"
        Me.txtdiasHabiles.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtdiasHabiles.Mask.UseMaskAsDisplayFormat = True
        Me.txtdiasHabiles.Name = "txtdiasHabiles"
        '
        'FECHA_INICIO
        '
        Me.FECHA_INICIO.Caption = "Fecha Inicio"
        Me.FECHA_INICIO.ColumnEdit = Me.dedFechaInicio
        Me.FECHA_INICIO.FieldName = "FECHA_INICIO"
        Me.FECHA_INICIO.Name = "FECHA_INICIO"
        Me.FECHA_INICIO.Visible = True
        Me.FECHA_INICIO.VisibleIndex = 1
        Me.FECHA_INICIO.Width = 117
        '
        'dedFechaInicio
        '
        Me.dedFechaInicio.AutoHeight = False
        Me.dedFechaInicio.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaInicio.Name = "dedFechaInicio"
        Me.dedFechaInicio.ValidateOnEnterKey = CType(configurationAppSettings.GetValue("dedFechaInicio.ValidateOnEnterKey", GetType(Boolean)), Boolean)
        Me.dedFechaInicio.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'FECHA_TERMINO
        '
        Me.FECHA_TERMINO.Caption = "Fecha Término"
        Me.FECHA_TERMINO.FieldName = "FECHA_TERMINO"
        Me.FECHA_TERMINO.Name = "FECHA_TERMINO"
        Me.FECHA_TERMINO.OptionsColumn.ReadOnly = True
        Me.FECHA_TERMINO.Visible = True
        Me.FECHA_TERMINO.VisibleIndex = 2
        Me.FECHA_TERMINO.Width = 90
        '
        'DIAS_RECORRIDO
        '
        Me.DIAS_RECORRIDO.Caption = "Días Total"
        Me.DIAS_RECORRIDO.FieldName = "DIAS_RECORRIDO"
        Me.DIAS_RECORRIDO.Name = "DIAS_RECORRIDO"
        Me.DIAS_RECORRIDO.OptionsColumn.ReadOnly = True
        Me.DIAS_RECORRIDO.Visible = True
        Me.DIAS_RECORRIDO.VisibleIndex = 3
        '
        'FECHA_REGRESO
        '
        Me.FECHA_REGRESO.Caption = "Fecha Regreso"
        Me.FECHA_REGRESO.FieldName = "FECHA_REGRESO"
        Me.FECHA_REGRESO.Name = "FECHA_REGRESO"
        Me.FECHA_REGRESO.OptionsColumn.ReadOnly = True
        Me.FECHA_REGRESO.Visible = True
        Me.FECHA_REGRESO.VisibleIndex = 4
        Me.FECHA_REGRESO.Width = 92
        '
        'RESOLUCION
        '
        Me.RESOLUCION.Caption = "Resolución"
        Me.RESOLUCION.FieldName = "RESOLUCION"
        Me.RESOLUCION.Name = "RESOLUCION"
        Me.RESOLUCION.Visible = True
        Me.RESOLUCION.VisibleIndex = 5
        Me.RESOLUCION.Width = 184
        '
        'OBSERVACION
        '
        Me.OBSERVACION.Caption = "Observación"
        Me.OBSERVACION.FieldName = "OBSERVACION"
        Me.OBSERVACION.Name = "OBSERVACION"
        Me.OBSERVACION.Visible = True
        Me.OBSERVACION.VisibleIndex = 6
        Me.OBSERVACION.Width = 193
        '
        'FECHA_DIGITACION
        '
        Me.FECHA_DIGITACION.Caption = "Fecha Digitación"
        Me.FECHA_DIGITACION.FieldName = "FECHA_DIGITACION"
        Me.FECHA_DIGITACION.Name = "FECHA_DIGITACION"
        Me.FECHA_DIGITACION.OptionsColumn.ReadOnly = True
        Me.FECHA_DIGITACION.Visible = True
        Me.FECHA_DIGITACION.VisibleIndex = 7
        Me.FECHA_DIGITACION.Width = 153
        '
        'PERIODO_ID
        '
        Me.PERIODO_ID.Caption = "ID Periodo"
        Me.PERIODO_ID.FieldName = "PERIODO_ID"
        Me.PERIODO_ID.Name = "PERIODO_ID"
        Me.PERIODO_ID.OptionsColumn.ReadOnly = True
        '
        'USUARIO
        '
        Me.USUARIO.Caption = "Emitida por"
        Me.USUARIO.FieldName = "USUARIO"
        Me.USUARIO.Name = "USUARIO"
        Me.USUARIO.OptionsColumn.ReadOnly = True
        Me.USUARIO.Visible = True
        Me.USUARIO.VisibleIndex = 8
        Me.USUARIO.Width = 86
        '
        'TIPO_FALLECIMIENTO_ID
        '
        Me.TIPO_FALLECIMIENTO_ID.Caption = "ID Tipo Fallecimiento"
        Me.TIPO_FALLECIMIENTO_ID.FieldName = "TIPO_FALLECIMIENTO_ID"
        Me.TIPO_FALLECIMIENTO_ID.Name = "TIPO_FALLECIMIENTO_ID"
        Me.TIPO_FALLECIMIENTO_ID.OptionsColumn.ReadOnly = True
        '
        'prsFeriadoLegal
        '
        Me.prsFeriadoLegal.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcFeriadoLegal
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(85, 100, 100, 100)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de La República" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10), "Detalle Feriado Legal", "Fecha Emisiòn:[Date Printed]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Emitido Por:[User Name]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"", "", "Página [Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PaperName = "Carta (8,5 x 11 pulg.)"
        Me.PrintableComponentLink1.PrintingSystem = Me.prsFeriadoLegal
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prsFeriadoLegal
        '
        'frmFeriadoLegalEmpleado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(832, 486)
        Me.Controls.Add(Me.gdcFeriadoLegal)
        Me.Controls.Add(Me.gpcSaldoDiasFestivos)
        Me.Controls.Add(Me.gpcEncabezado)
        Me.Name = "frmFeriadoLegalEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Feriado Legal Empleado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcEncabezado.ResumeLayout(False)
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstadoEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcSaldoDiasFestivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSaldoDiasFestivos.ResumeLayout(False)
        CType(Me.txtDiasLegalFeriado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiasPendientes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDiasSolicitados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDiasAnual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiasPeriodoAnterior.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiasAdicionales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcFeriadoLegal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleFeriadoLegal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdiasHabiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaInicio.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prsFeriadoLegal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private empleado As Empleado
    Private parametroMensual As Periodo
    Private estadoPeriodo As Boolean
    Private sumaDiasHabiles As Integer = 0
    Private mensajeDias As String = ""
    Private eventoAdmin As Integer = Comun.TiposDeDatos.TipoEventoAdmin.FERIADO_LEGAL

    Private Sub frmFeriadoLegalEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        repositorio.Show()
        empleado = New empleado
        parametroMensual = New Periodo
        GeneraDataViews()
        llenarEmpleado()
        llenarPeriodos()
        btnSaldoDiasFeriadoLegal.Enabled = False
        btnEmiteDetalle.Enabled = False

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
        'gleRut.Properties.EditValueChangedFiringDelay = 1200
        Repository.RepositoryItem.EditValueChangedFiringDelay = 1200
        gleRut.Properties.EditValueChangedFiringMode = EditValueChangedFiringMode.Buffered
        'Dos segundos se espera antes de gatillar la búsqueda (EditValueChanged)

        gleRut.Properties.ViewType = Repository.GridLookUpViewType.GridView
        gleRut.Properties.View.OptionsBehavior.AutoPopulateColumns = False
        gleRut.Properties.DataSource = repositorio.dvEmpleadoVista
        gleRut.Properties.DisplayMember = "RUT"

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

        Dim col5 As GridColumn = gleRut.Properties.View.Columns.AddField("DESC_ESTADO")
        col5.VisibleIndex = 4
        col5.Caption = "Estado"

        Dim col6 As GridColumn = gleRut.Properties.View.Columns.AddField("DESC_CALIDAD_JURIDICA")
        col6.VisibleIndex = 5
        col6.Caption = "Calidad Jurídica"

        Dim col7 As GridColumn = gleRut.Properties.View.Columns.AddField("EMPLEADO_ID")
        col7.VisibleIndex = 6
        col7.Caption = "ID Empleado"
        col7.Visible = False

        gleRut.Properties.ValueMember = "EMPLEADO_ID"
        gleRut.Properties.View.BestFitColumns()
        gleRut.Properties.PopupFormWidth = 600

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
    Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        If luePeriodo.EditValue <> Nothing Then
            refrescaDetalle()
        End If
    End Sub

    Private Sub refrescaDetalle()
        If luePeriodo.EditValue <> Nothing And gleRut.EditValue <> Nothing Then
            Try
                empleado = New empleado(CType(gleRut.EditValue, Long))
                buscaSaldosDias()
                gleRut.EditValue = empleado.ID
                txtNombres.Text = empleado.nombreCompleto
                txtFechaIngreso.Text = empleado.datosLaborales.fechaIngresoInstitucion
                txtEstadoEmpleado.Text = empleado.buscaString("SELECT DESCRIPCION FROM RH_PER_ESTADO_EMPLEADO WHERE ESTADO_EMPLEADO_ID=" & empleado.estadoEmpleadoID)
                gdcFeriadoLegal.DataSource = empleado.dvEventosAdministrativos(gleRut.EditValue, eventoAdmin, luePeriodo.EditValue)

                If empleado.estadoEmpleadoID = Comun.TiposDeDatos.TipoEstado.INACTIVO Or empleado.estadoEmpleadoID = Comun.TiposDeDatos.TipoEstado.POR_ACTIVAR Then
                    gdcFeriadoLegal.Enabled = False
                Else
                    gdcFeriadoLegal.Enabled = True
                End If
                If CType(txtDiasLegalFeriado.Text, Decimal) > 0 Then
                    btnSaldoDiasFeriadoLegal.Enabled = True
                Else
                    btnSaldoDiasFeriadoLegal.Enabled = True
                End If
                btnEmiteDetalle.Enabled = True
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al leer datos feriado legal. ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub buscaSaldosDias()
        Dim dv As DataView = Nothing
        Try
            dv = empleado.recuperaSaldoDiasEventoAdmin(gleRut.EditValue, eventoAdmin, luePeriodo.EditValue)
        Finally
            If dv.Count > 0 Then
                'Asigna los datos de la tabla (BD) a las caja de texto
                txtDiasLegalFeriado.Text = dv.Table.Rows(0).Item("DIAS_PERIODO")
                txtDiasPeriodoAnterior.Text = dv.Table.Rows(0).Item("DIAS_PERIODO_ANT")
                txtDiasAdicionales.Text = dv.Table.Rows(0).Item("DIAS_ADICIONALES")
                txtTotalDiasAnual.Text = dv.Table.Rows(0).Item("TOTAL_DIAS_ANUAL")
                txtTotalDiasSolicitados.Text = dv.Table.Rows(0).Item("TOTAL_DIAS_SOLICITADOS")
                txtDiasPendientes.Text = dv.Table.Rows(0).Item("DIAS_PENDIENTE")
            Else
                'Asigna valores 0 al no encontrar información
                txtDiasLegalFeriado.Text = 0
                txtDiasPeriodoAnterior.Text = 0
                txtDiasAdicionales.Text = 0
                txtTotalDiasAnual.Text = 0
                txtTotalDiasSolicitados.Text = 0
                txtDiasPendientes.Text = 0
            End If
        End Try
    End Sub

    Private Sub gdvDetalleFeriadoLegal_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvDetalleFeriadoLegal.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        Dim nombreUsuario As String = empleado.buscaString("SELECT USER AS USUARIO")
        asignarCampos(Comun.TiposDeDatos.EstadoEventoAdmin.INGRESADO, 0)
        empleado.datosEventoAdmin.Evento_Administrativo_ID = empleado.CrearEmpleadoEventoAdmin(eventoAdmin)
        view.SetRowCellValue(e.RowHandle, "EVENTO_ADMINISTRATIVO_ID", empleado.datosEventoAdmin.Evento_Administrativo_ID)
        view.SetRowCellValue(e.RowHandle, "FECHA_NACIMIENTO_HIJO", Date.Parse("01-01-1900"))
        'view.SetRowCellValue(e.RowHandle, "FECHA_INICIO", Date.Now)
        view.SetRowCellValue(e.RowHandle, "JORNADA_ID", Comun.TiposDeDatos.TipoJornada.DIA_COMPLETO)
        view.SetRowCellValue(e.RowHandle, "FECHA_DIGITACION", Date.Now)
        view.SetRowCellValue(e.RowHandle, "RESOLUCION", "")
        view.SetRowCellValue(e.RowHandle, "OBSERVACION", "")
        view.SetRowCellValue(e.RowHandle, "DIAS_HABILES", 0)
        view.SetRowCellValue(e.RowHandle, "PERIODO_ID", parametroMensual.ID)
        view.SetRowCellValue(e.RowHandle, "USUARIO", nombreUsuario)
        view.SetRowCellValue(e.RowHandle, "TIPO_FALLECIMIENTO_ID", 0)
    End Sub

    Private Sub gdvDetalleFeriadoLegal_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvDetalleFeriadoLegal.RowUpdated
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetalleFeriadoLegal
        If empleado.actualizarDetalleEventoAdmin() Then
            asignarCampos(Comun.TiposDeDatos.EstadoEventoAdmin.ACTUALIZADO, view.GetRowCellValue(view.FocusedRowHandle, "DIAS_HABILES"))
            empleado.actualizarEventoAdmin(empleado.datosEventoAdmin)
            'gdcFeriadoLegal.DataSource = empleado.dvEventosAdministrativos(gleRut.EditValue, eventoAdmin, luePeriodo.EditValue)
            'buscaSaldosDias()
            refrescaDetalle()
        End If
    End Sub
    Private Sub gdvDetalleFeriadoLegal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvDetalleFeriadoLegal.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            Dim myview As DevExpress.XtraGrid.Views.Grid.GridView = sender
            If myview.IsNewItemRow(myview.FocusedRowHandle) Then
                MessageBox.Show("Para cancelar el nuevo registro debe presionar la tecla Esc (Escape)", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If parametroMensual.ano <> luePeriodo.EditValue = 2 Then
                    MsgBox("Este registro no puede ser eliminado, corresponde a año cerrado", MsgBoxStyle.Information)
                Else
                    If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                        Dim idEventoAdmin As Integer = view.GetRowCellValue(view.FocusedRowHandle, "EVENTO_ADMINISTRATIVO_ID")
                        view.DeleteRow(view.FocusedRowHandle)
                        Try
                            empleado.eliminarDetalleEventoAdmin(idEventoAdmin)
                            empleado.eliminarHeaderEventoAdmin(idEventoAdmin)
                            buscaSaldosDias()
                            gdcFeriadoLegal.DataSource = empleado.dvEventosAdministrativos(gleRut.EditValue, eventoAdmin, luePeriodo.EditValue)
                            MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Information)
                        Catch ex As Exception
                            MsgBox("Ha ocurrido un error al intentar eliminar el registro " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                        End Try
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub asignarCampos(ByVal estadoEventoAdmin As Integer, ByVal diasHabiles As Decimal)
        empleado.datosEventoAdmin.Año = luePeriodo.EditValue
        empleado.datosEventoAdmin.Dias_Solicitados = diasHabiles
        empleado.datosEventoAdmin.Empleado_ID = empleado.ID
        empleado.datosEventoAdmin.Estado_Evento_Administrativo_ID = estadoEventoAdmin
        empleado.datosEventoAdmin.Fecha_Digitacion = Date.Now
        empleado.datosEventoAdmin.Motivo_Solicitud = ""
        empleado.datosEventoAdmin.Tipo_Evento_Admin_ID = eventoAdmin
        empleado.datosEventoAdmin.periodoId = parametroMensual.ID
    End Sub

    Private Sub gdvDetalleFeriadoLegal_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gdvDetalleFeriadoLegal.ValidateRow
        Dim respuesta As Boolean = True
        If empleado.estadoEmpleadoID = Comun.TiposDeDatos.TipoEstado.INACTIVO Or empleado.estadoEmpleadoID = Comun.TiposDeDatos.TipoEstado.POR_ACTIVAR Then
            If (MessageBox.Show("El estado del empleado se encuentra inactivo o por activar. ¿Desea continuar?", "Atención", MessageBoxButtons.YesNo) = DialogResult.No) Then
                respuesta = False
                e.Valid = False
            End If
        End If

        If respuesta Then
            Dim View As DevExpress.XtraGrid.Views.Grid.GridView = sender
            Dim view1 As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetalleFeriadoLegal
            Dim row As System.Data.DataRowView = e.Row
            Dim idEmpleado As Integer
            Dim FechaInicio As Date
            Dim FechaTermino As Date
            Dim diasHabiles As Decimal = row("DIAS_HABILES")
            Dim idEventoAdmin As Integer = row("EVENTO_ADMINISTRATIVO_ID")
            Dim fechaInicialProceso As Date = CType("01-01-" + CType(luePeriodo.EditValue, String), Date)
            Dim fechaFinalProceso As Date = CType("31-12-" + CType(luePeriodo.EditValue, String), Date)
            Dim FechaDateEditControl As Date = row("FECHA_INICIO")
            If diasHabiles <= 0 Then
                e.Valid = False
                MessageBox.Show("Falta ingresar días hábiles", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If row("FECHA_INICIO").GetType.ToString = "System.DBNull" Then
                MessageBox.Show("No ha ingresado fecha inicial", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Valid = False
                Exit Sub
            End If

            If FechaDateEditControl < fechaInicialProceso Or FechaDateEditControl > fechaFinalProceso Then
                MessageBox.Show("Fecha no corresponde al año de proceso", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Valid = False
                Exit Sub
            End If

            If diasHabiles > txtDiasPendientes.Text And view1.IsNewItemRow(view1.FocusedRowHandle) Then
                e.Valid = False
                MessageBox.Show("No puede solictar mas días de los pendientes", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            idEmpleado = empleado.ID
            FechaInicio = row("FECHA_INICIO")
            FechaTermino = row("FECHA_TERMINO")
            mensajeDias = Funciones.FechaFinal.ValidaFechaDisponible(idEmpleado, FechaInicio, FechaTermino)
            If Len(mensajeDias) > 3 Then
                If MessageBox.Show(mensajeDias & Chr(13) & Chr(13) & "¿Desea continuar?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                    e.Valid = False
                    'Exit Sub
                End If
            End If
        End If
    End Sub
    Private Sub gdvDetalleFeriadoLegal_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvDetalleFeriadoLegal.InvalidRowException
        'Suprimir el mensaje de error al validar la fila
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub dedFechaInicio_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dedFechaInicio.Validating
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetalleFeriadoLegal
        Dim diasHabilesSolicitados As Integer = view.GetRowCellValue(view.FocusedRowHandle, "DIAS_HABILES")
        Dim FechaDateEditControl As DevExpress.XtraEditors.DateEdit = sender
        Dim tipoMensaje As Integer = empleado.buscaFechaFestivo(FechaDateEditControl.EditValue)

        If tipoMensaje = Comun.TiposDeDatos.TipoDiaSemana.HABIL Then
            Dim fechaFinalFeriado As Date
            Dim fechaRetornoFeriado As Date
            Try
                fechaFinalFeriado = empleado.calculaFechaTerminoEventoAdministrativo(diasHabilesSolicitados, FechaDateEditControl.EditValue)
                fechaRetornoFeriado = empleado.calculaFechaRetornoEventoAdministrativo(fechaFinalFeriado)
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al calcular fecha término evento administrativo " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
            view.SetRowCellValue(view.FocusedRowHandle, "FECHA_TERMINO", fechaFinalFeriado)
            view.SetRowCellValue(view.FocusedRowHandle, "FECHA_REGRESO", fechaRetornoFeriado)
            view.SetRowCellValue(view.FocusedRowHandle, "DIAS_RECORRIDO", DateDiff(DateInterval.Day, FechaDateEditControl.EditValue, fechaFinalFeriado.AddDays(1)))
        Else
            If tipoMensaje = Comun.TiposDeDatos.TipoDiaSemana.FESTIVO Then
                e.Cancel = True
                gdvDetalleFeriadoLegal.SetColumnError(gdvDetalleFeriadoLegal.Columns("FECHA_INICIO"), "Fecha incial no puede corresponder a día festivo")
                MsgBox("Fecha incial no puede corresponder a día festivo.", MsgBoxStyle.Critical, "SIGA")
            Else
                If tipoMensaje = Comun.TiposDeDatos.TipoDiaSemana.SABADO Then
                    e.Cancel = True
                    gdvDetalleFeriadoLegal.SetColumnError(gdvDetalleFeriadoLegal.Columns("FECHA_INICIO"), "Fecha incial no puede corresponder a día sábado")
                    MsgBox("Fecha incial no puede corresponder a día sábado.", MsgBoxStyle.Critical, "SIGA")
                Else
                    If tipoMensaje = Comun.TiposDeDatos.TipoDiaSemana.DOMINGO Then
                        e.Cancel = True
                        gdvDetalleFeriadoLegal.SetColumnError(gdvDetalleFeriadoLegal.Columns("FECHA_INICIO"), "Fecha incial no puede corresponder a día domingo")
                        MsgBox("Fecha incial no puede corresponder a día domingo.", MsgBoxStyle.Critical, "SIGA")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnSaldoDiasFeriadoLegal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaldoDiasFeriadoLegal.Click
        Try
            frmSaldoDiasFeriadoLegal.DefInstance.empleado = empleado
            frmSaldoDiasFeriadoLegal.DefInstance.txtAnno.Text = luePeriodo.EditValue
            frmSaldoDiasFeriadoLegal.DefInstance.tipoEventoAdmin = eventoAdmin
            frmSaldoDiasFeriadoLegal.DefInstance.totalDiasAnual = CType(txtTotalDiasAnual.Text, Integer)
            frmSaldoDiasFeriadoLegal.DefInstance.Owner = Me
            If frmSaldoDiasFeriadoLegal.DefInstance.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido al intentar carga el formulario saldo días feriado legal." & Chr(13) & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            buscaSaldosDias()
            If CType(txtDiasLegalFeriado.Text, Decimal) > 0 Then
                btnSaldoDiasFeriadoLegal.Enabled = True
            Else
                btnSaldoDiasFeriadoLegal.Enabled = True
            End If
        End Try
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

    Private Sub gleRut_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gleRut.EditValueChanged
        If gleRut.EditValue <> Nothing Then
            refrescaDetalle()
        End If
    End Sub

    Private Sub txtdiasHabiles_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtdiasHabiles.Validating
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetalleFeriadoLegal
        Dim edicion As DevExpress.XtraEditors.BaseEdit = view.ActiveEditor
        Dim FechaDateEditControl As Date
        Dim diasHabilesSolicitados As Decimal = edicion.EditValue
        Dim idEventoAdmin As Integer = view.GetRowCellValue(view.FocusedRowHandle, "EVENTO_ADMINISTRATIVO_DET_ID")
        If diasHabilesSolicitados > 0 And Not view.IsNewItemRow(view.FocusedRowHandle) Then
            e.Cancel = True
            gdvDetalleFeriadoLegal.SetColumnError(gdvDetalleFeriadoLegal.Columns("DIAS_HABILES"), "Para modificar los días, debe eliminar el registro y volver a ingresarlo")
            MessageBox.Show("Para modificar días, debe eliminar el registro y volver a ingresarlo", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If view.GetRowCellValue(view.FocusedRowHandle, "FECHA_INICIO").GetType.ToString = "System.DBNull" Then
                FechaDateEditControl = Date.Now
            Else
                FechaDateEditControl = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_INICIO")
            End If
            If FechaDateEditControl <> Nothing Then
                Dim fechaFinalFeriado As Date
                Dim fechaRetornoFeriado As Date
                Try
                    fechaFinalFeriado = empleado.calculaFechaTerminoEventoAdministrativo(diasHabilesSolicitados, FechaDateEditControl)
                    fechaRetornoFeriado = empleado.calculaFechaRetornoEventoAdministrativo(CType(fechaFinalFeriado, Date))
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al calcular fecha término evento administrativo " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
                view.SetRowCellValue(view.FocusedRowHandle, "FECHA_TERMINO", fechaFinalFeriado)
                view.SetRowCellValue(view.FocusedRowHandle, "FECHA_REGRESO", fechaRetornoFeriado)
                view.SetRowCellValue(view.FocusedRowHandle, "DIAS_RECORRIDO", DateDiff(DateInterval.Day, FechaDateEditControl, fechaFinalFeriado.AddDays(1)))
            End If
        End If
    End Sub
End Class
