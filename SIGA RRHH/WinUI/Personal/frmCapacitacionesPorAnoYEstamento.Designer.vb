<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapacitacionesPorAnoYEstamento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.rogTipoInforme = New DevExpress.XtraEditors.RadioGroup()
        Me.btnExportarExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.chkIncluirEstamento = New DevExpress.XtraEditors.CheckEdit()
        Me.btnVisualizarCapacitaciones = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.lueEstamento = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtMesTermino = New DevExpress.XtraEditors.TextEdit()
        Me.txtInicioMes = New DevExpress.XtraEditors.TextEdit()
        Me.txtAno = New DevExpress.XtraEditors.TextEdit()
        Me.lcgCapacitaciones = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciAno = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciMesInicio = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciTerminoMes = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciEstamento = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciTipoInforme = New DevExpress.XtraLayout.LayoutControlItem()
        Me.gpcCapacitacionesPorAno = New DevExpress.XtraEditors.GroupControl()
        Me.gdcCapacitaciones = New DevExpress.XtraGrid.GridControl()
        Me.gdvCapacitaciones = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApellidoPaterno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApellidoMaterno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombres = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstamento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartamento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCapacitacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstadoEvaluacionAprendizaje = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaInicio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostoCapacitacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidadParticipantes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaTermino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInsitucionImpartidora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHorasEjecucion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpleadoId = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.rogTipoInforme.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIncluirEstamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueEstamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMesTermino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInicioMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgCapacitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciAno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciMesInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciTerminoMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEstamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciTipoInforme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcCapacitacionesPorAno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcCapacitacionesPorAno.SuspendLayout()
        CType(Me.gdcCapacitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvCapacitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.rogTipoInforme)
        Me.LayoutControl1.Controls.Add(Me.btnExportarExcel)
        Me.LayoutControl1.Controls.Add(Me.chkIncluirEstamento)
        Me.LayoutControl1.Controls.Add(Me.btnVisualizarCapacitaciones)
        Me.LayoutControl1.Controls.Add(Me.btnLimpiar)
        Me.LayoutControl1.Controls.Add(Me.lueEstamento)
        Me.LayoutControl1.Controls.Add(Me.txtMesTermino)
        Me.LayoutControl1.Controls.Add(Me.txtInicioMes)
        Me.LayoutControl1.Controls.Add(Me.txtAno)
        Me.LayoutControl1.Location = New System.Drawing.Point(12, 12)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.lcgCapacitaciones
        Me.LayoutControl1.Size = New System.Drawing.Size(354, 192)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'rogTipoInforme
        '
        Me.rogTipoInforme.Location = New System.Drawing.Point(76, 104)
        Me.rogTipoInforme.Name = "rogTipoInforme"
        Me.rogTipoInforme.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Por Año"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Por Empleados")})
        Me.rogTipoInforme.Size = New System.Drawing.Size(266, 26)
        Me.rogTipoInforme.StyleController = Me.LayoutControl1
        Me.rogTipoInforme.TabIndex = 7
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Location = New System.Drawing.Point(241, 158)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(101, 22)
        Me.btnExportarExcel.StyleController = Me.LayoutControl1
        Me.btnExportarExcel.TabIndex = 11
        Me.btnExportarExcel.Text = "Exportar Excel"
        '
        'chkIncluirEstamento
        '
        Me.chkIncluirEstamento.Enabled = False
        Me.chkIncluirEstamento.Location = New System.Drawing.Point(236, 134)
        Me.chkIncluirEstamento.Name = "chkIncluirEstamento"
        Me.chkIncluirEstamento.Properties.Caption = "Incluir Estamento"
        Me.chkIncluirEstamento.Size = New System.Drawing.Size(106, 19)
        Me.chkIncluirEstamento.StyleController = Me.LayoutControl1
        Me.chkIncluirEstamento.TabIndex = 8
        '
        'btnVisualizarCapacitaciones
        '
        Me.btnVisualizarCapacitaciones.Location = New System.Drawing.Point(124, 158)
        Me.btnVisualizarCapacitaciones.Name = "btnVisualizarCapacitaciones"
        Me.btnVisualizarCapacitaciones.Size = New System.Drawing.Size(113, 22)
        Me.btnVisualizarCapacitaciones.StyleController = Me.LayoutControl1
        Me.btnVisualizarCapacitaciones.TabIndex = 9
        Me.btnVisualizarCapacitaciones.Text = "Visualizar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(12, 158)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(108, 22)
        Me.btnLimpiar.StyleController = Me.LayoutControl1
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "Limpiar"
        '
        'lueEstamento
        '
        Me.lueEstamento.Enabled = False
        Me.lueEstamento.Location = New System.Drawing.Point(76, 134)
        Me.lueEstamento.Name = "lueEstamento"
        Me.lueEstamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueEstamento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ESTAMENTO_ID", "Estamento ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "ESTAMENTO")})
        Me.lueEstamento.Properties.NullText = ""
        Me.lueEstamento.Size = New System.Drawing.Size(156, 20)
        Me.lueEstamento.StyleController = Me.LayoutControl1
        Me.lueEstamento.TabIndex = 9
        '
        'txtMesTermino
        '
        Me.txtMesTermino.Location = New System.Drawing.Point(76, 80)
        Me.txtMesTermino.Name = "txtMesTermino"
        Me.txtMesTermino.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMesTermino.Size = New System.Drawing.Size(266, 20)
        Me.txtMesTermino.StyleController = Me.LayoutControl1
        Me.txtMesTermino.TabIndex = 6
        '
        'txtInicioMes
        '
        Me.txtInicioMes.Location = New System.Drawing.Point(76, 56)
        Me.txtInicioMes.Name = "txtInicioMes"
        Me.txtInicioMes.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtInicioMes.Size = New System.Drawing.Size(266, 20)
        Me.txtInicioMes.StyleController = Me.LayoutControl1
        Me.txtInicioMes.TabIndex = 5
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(76, 32)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAno.Size = New System.Drawing.Size(266, 20)
        Me.txtAno.StyleController = Me.LayoutControl1
        Me.txtAno.TabIndex = 4
        '
        'lcgCapacitaciones
        '
        Me.lcgCapacitaciones.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lcgCapacitaciones.AppearanceGroup.Options.UseFont = True
        Me.lcgCapacitaciones.CustomizationFormText = "Capacitaciones"
        Me.lcgCapacitaciones.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.lcgCapacitaciones.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciAno, Me.lciMesInicio, Me.lciTerminoMes, Me.lciEstamento, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.lciTipoInforme})
        Me.lcgCapacitaciones.Location = New System.Drawing.Point(0, 0)
        Me.lcgCapacitaciones.Name = "lcgCapacitaciones"
        Me.lcgCapacitaciones.Size = New System.Drawing.Size(354, 192)
        Me.lcgCapacitaciones.Text = "Capacitaciones"
        '
        'lciAno
        '
        Me.lciAno.Control = Me.txtAno
        Me.lciAno.CustomizationFormText = "Año"
        Me.lciAno.Location = New System.Drawing.Point(0, 0)
        Me.lciAno.Name = "lciAno"
        Me.lciAno.Size = New System.Drawing.Size(334, 24)
        Me.lciAno.Text = "Año"
        Me.lciAno.TextSize = New System.Drawing.Size(61, 13)
        '
        'lciMesInicio
        '
        Me.lciMesInicio.Control = Me.txtInicioMes
        Me.lciMesInicio.CustomizationFormText = "Mes Inicio"
        Me.lciMesInicio.Location = New System.Drawing.Point(0, 24)
        Me.lciMesInicio.Name = "lciMesInicio"
        Me.lciMesInicio.Size = New System.Drawing.Size(334, 24)
        Me.lciMesInicio.Text = "Mes Inicio"
        Me.lciMesInicio.TextSize = New System.Drawing.Size(61, 13)
        '
        'lciTerminoMes
        '
        Me.lciTerminoMes.Control = Me.txtMesTermino
        Me.lciTerminoMes.CustomizationFormText = "Mes Término"
        Me.lciTerminoMes.Location = New System.Drawing.Point(0, 48)
        Me.lciTerminoMes.Name = "lciTerminoMes"
        Me.lciTerminoMes.Size = New System.Drawing.Size(334, 24)
        Me.lciTerminoMes.Text = "Mes Término"
        Me.lciTerminoMes.TextSize = New System.Drawing.Size(61, 13)
        '
        'lciEstamento
        '
        Me.lciEstamento.Control = Me.lueEstamento
        Me.lciEstamento.CustomizationFormText = "Estamento"
        Me.lciEstamento.Location = New System.Drawing.Point(0, 102)
        Me.lciEstamento.Name = "lciEstamento"
        Me.lciEstamento.Size = New System.Drawing.Size(224, 24)
        Me.lciEstamento.Text = "Estamento"
        Me.lciEstamento.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnLimpiar
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(112, 26)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnVisualizarCapacitaciones
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(112, 126)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(117, 26)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.chkIncluirEstamento
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(224, 102)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(110, 24)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnExportarExcel
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(229, 126)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(105, 26)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'lciTipoInforme
        '
        Me.lciTipoInforme.Control = Me.rogTipoInforme
        Me.lciTipoInforme.CustomizationFormText = "Tipo Informe"
        Me.lciTipoInforme.Location = New System.Drawing.Point(0, 72)
        Me.lciTipoInforme.Name = "lciTipoInforme"
        Me.lciTipoInforme.Size = New System.Drawing.Size(334, 30)
        Me.lciTipoInforme.Text = "Tipo Informe"
        Me.lciTipoInforme.TextSize = New System.Drawing.Size(61, 13)
        '
        'gpcCapacitacionesPorAno
        '
        Me.gpcCapacitacionesPorAno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcCapacitacionesPorAno.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcCapacitacionesPorAno.AppearanceCaption.Options.UseFont = True
        Me.gpcCapacitacionesPorAno.Controls.Add(Me.gdcCapacitaciones)
        Me.gpcCapacitacionesPorAno.Location = New System.Drawing.Point(12, 210)
        Me.gpcCapacitacionesPorAno.Name = "gpcCapacitacionesPorAno"
        Me.gpcCapacitacionesPorAno.Size = New System.Drawing.Size(919, 302)
        Me.gpcCapacitacionesPorAno.TabIndex = 1
        Me.gpcCapacitacionesPorAno.Text = "Capacitaciones"
        '
        'gdcCapacitaciones
        '
        Me.gdcCapacitaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gdcCapacitaciones.Location = New System.Drawing.Point(2, 22)
        Me.gdcCapacitaciones.MainView = Me.gdvCapacitaciones
        Me.gdcCapacitaciones.Name = "gdcCapacitaciones"
        Me.gdcCapacitaciones.Size = New System.Drawing.Size(915, 278)
        Me.gdcCapacitaciones.TabIndex = 0
        Me.gdcCapacitaciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvCapacitaciones})
        '
        'gdvCapacitaciones
        '
        Me.gdvCapacitaciones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRut, Me.colApellidoPaterno, Me.colApellidoMaterno, Me.colNombres, Me.colEstamento, Me.colDepartamento, Me.colNombreCapacitacion, Me.colEstadoEvaluacionAprendizaje, Me.colFechaInicio, Me.colCostoCapacitacion, Me.colCantidadParticipantes, Me.colFechaTermino, Me.colInsitucionImpartidora, Me.colHorasEjecucion, Me.colEmpleadoId})
        Me.gdvCapacitaciones.GridControl = Me.gdcCapacitaciones
        Me.gdvCapacitaciones.Name = "gdvCapacitaciones"
        Me.gdvCapacitaciones.OptionsView.ShowGroupPanel = False
        '
        'colRut
        '
        Me.colRut.Caption = "RUT"
        Me.colRut.FieldName = "RUT"
        Me.colRut.Name = "colRut"
        Me.colRut.OptionsColumn.AllowEdit = False
        Me.colRut.OptionsColumn.ReadOnly = True
        Me.colRut.Visible = True
        Me.colRut.VisibleIndex = 0
        '
        'colApellidoPaterno
        '
        Me.colApellidoPaterno.Caption = "APELLIDO PATERNO"
        Me.colApellidoPaterno.FieldName = "APELLIDO_PATERNO"
        Me.colApellidoPaterno.Name = "colApellidoPaterno"
        Me.colApellidoPaterno.OptionsColumn.AllowEdit = False
        Me.colApellidoPaterno.OptionsColumn.ReadOnly = True
        Me.colApellidoPaterno.Visible = True
        Me.colApellidoPaterno.VisibleIndex = 1
        '
        'colApellidoMaterno
        '
        Me.colApellidoMaterno.Caption = "APELLIDO MATERNO"
        Me.colApellidoMaterno.FieldName = "APELLIDO_MATERNO"
        Me.colApellidoMaterno.Name = "colApellidoMaterno"
        Me.colApellidoMaterno.OptionsColumn.AllowEdit = False
        Me.colApellidoMaterno.OptionsColumn.ReadOnly = True
        Me.colApellidoMaterno.Visible = True
        Me.colApellidoMaterno.VisibleIndex = 2
        '
        'colNombres
        '
        Me.colNombres.Caption = "NOMBRES"
        Me.colNombres.FieldName = "NOMBRES"
        Me.colNombres.Name = "colNombres"
        Me.colNombres.OptionsColumn.AllowEdit = False
        Me.colNombres.OptionsColumn.ReadOnly = True
        Me.colNombres.Visible = True
        Me.colNombres.VisibleIndex = 3
        '
        'colEstamento
        '
        Me.colEstamento.Caption = "ESTAMENTO"
        Me.colEstamento.FieldName = "ESTAMENTO"
        Me.colEstamento.Name = "colEstamento"
        Me.colEstamento.OptionsColumn.AllowEdit = False
        Me.colEstamento.OptionsColumn.ReadOnly = True
        Me.colEstamento.Visible = True
        Me.colEstamento.VisibleIndex = 4
        '
        'colDepartamento
        '
        Me.colDepartamento.Caption = "DEPARTAMENTO"
        Me.colDepartamento.FieldName = "DEPARTAMENTO"
        Me.colDepartamento.Name = "colDepartamento"
        Me.colDepartamento.OptionsColumn.AllowEdit = False
        Me.colDepartamento.OptionsColumn.ReadOnly = True
        Me.colDepartamento.Visible = True
        Me.colDepartamento.VisibleIndex = 5
        '
        'colNombreCapacitacion
        '
        Me.colNombreCapacitacion.Caption = "NOMBRE CAPACITACIÓN"
        Me.colNombreCapacitacion.FieldName = "NOMBRE_CAPACITACION"
        Me.colNombreCapacitacion.Name = "colNombreCapacitacion"
        Me.colNombreCapacitacion.OptionsColumn.AllowEdit = False
        Me.colNombreCapacitacion.OptionsColumn.ReadOnly = True
        Me.colNombreCapacitacion.Visible = True
        Me.colNombreCapacitacion.VisibleIndex = 6
        '
        'colEstadoEvaluacionAprendizaje
        '
        Me.colEstadoEvaluacionAprendizaje.Caption = "ESTADO EVALUACIÓN APRENDIZAJE"
        Me.colEstadoEvaluacionAprendizaje.FieldName = "ESTADO_EVALUACION_APRENDIZAJE"
        Me.colEstadoEvaluacionAprendizaje.Name = "colEstadoEvaluacionAprendizaje"
        Me.colEstadoEvaluacionAprendizaje.OptionsColumn.AllowEdit = False
        Me.colEstadoEvaluacionAprendizaje.OptionsColumn.ReadOnly = True
        Me.colEstadoEvaluacionAprendizaje.Visible = True
        Me.colEstadoEvaluacionAprendizaje.VisibleIndex = 7
        '
        'colFechaInicio
        '
        Me.colFechaInicio.Caption = "FECHA_INICIO"
        Me.colFechaInicio.FieldName = "FECHA_INICIO"
        Me.colFechaInicio.Name = "colFechaInicio"
        Me.colFechaInicio.OptionsColumn.AllowEdit = False
        Me.colFechaInicio.OptionsColumn.ReadOnly = True
        Me.colFechaInicio.Visible = True
        Me.colFechaInicio.VisibleIndex = 8
        '
        'colCostoCapacitacion
        '
        Me.colCostoCapacitacion.Caption = "COSTO CAPACITACIÓN"
        Me.colCostoCapacitacion.FieldName = "COSTO_CAPACITACION"
        Me.colCostoCapacitacion.Name = "colCostoCapacitacion"
        Me.colCostoCapacitacion.OptionsColumn.AllowEdit = False
        Me.colCostoCapacitacion.OptionsColumn.ReadOnly = True
        Me.colCostoCapacitacion.Visible = True
        Me.colCostoCapacitacion.VisibleIndex = 9
        '
        'colCantidadParticipantes
        '
        Me.colCantidadParticipantes.Caption = "CANTIDAD PARTICIPANTES"
        Me.colCantidadParticipantes.FieldName = "CANTIDAD_PARTICIPANTES"
        Me.colCantidadParticipantes.Name = "colCantidadParticipantes"
        Me.colCantidadParticipantes.OptionsColumn.AllowEdit = False
        Me.colCantidadParticipantes.OptionsColumn.ReadOnly = True
        Me.colCantidadParticipantes.Visible = True
        Me.colCantidadParticipantes.VisibleIndex = 10
        '
        'colFechaTermino
        '
        Me.colFechaTermino.Caption = "FECHA TÉRMINO"
        Me.colFechaTermino.FieldName = "FECHA_TERMINO"
        Me.colFechaTermino.Name = "colFechaTermino"
        Me.colFechaTermino.OptionsColumn.AllowEdit = False
        Me.colFechaTermino.OptionsColumn.ReadOnly = True
        Me.colFechaTermino.Visible = True
        Me.colFechaTermino.VisibleIndex = 11
        '
        'colInsitucionImpartidora
        '
        Me.colInsitucionImpartidora.Caption = "NOMBRE INSTITUCIÓN"
        Me.colInsitucionImpartidora.FieldName = "INSTITUCION_IMPARTIDORA"
        Me.colInsitucionImpartidora.Name = "colInsitucionImpartidora"
        Me.colInsitucionImpartidora.OptionsColumn.AllowEdit = False
        Me.colInsitucionImpartidora.OptionsColumn.ReadOnly = True
        Me.colInsitucionImpartidora.Visible = True
        Me.colInsitucionImpartidora.VisibleIndex = 12
        '
        'colHorasEjecucion
        '
        Me.colHorasEjecucion.Caption = "CANT. HORAS"
        Me.colHorasEjecucion.FieldName = "CANTIDAD_HORAS_EJECUTADAS"
        Me.colHorasEjecucion.Name = "colHorasEjecucion"
        Me.colHorasEjecucion.OptionsColumn.AllowEdit = False
        Me.colHorasEjecucion.OptionsColumn.ReadOnly = True
        Me.colHorasEjecucion.Visible = True
        Me.colHorasEjecucion.VisibleIndex = 13
        '
        'colEmpleadoId
        '
        Me.colEmpleadoId.Caption = "EMPLEADO ID"
        Me.colEmpleadoId.FieldName = "EMPLEADO_ID"
        Me.colEmpleadoId.Name = "colEmpleadoId"
        Me.colEmpleadoId.OptionsColumn.AllowEdit = False
        Me.colEmpleadoId.OptionsColumn.ReadOnly = True
        Me.colEmpleadoId.Visible = True
        Me.colEmpleadoId.VisibleIndex = 14
        '
        'frmCapacitacionesPorAnoYEstamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 524)
        Me.Controls.Add(Me.gpcCapacitacionesPorAno)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmCapacitacionesPorAnoYEstamento"
        Me.Text = "Visualizar Capacitaciones por Año"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.rogTipoInforme.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIncluirEstamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueEstamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMesTermino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInicioMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgCapacitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciAno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciMesInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciTerminoMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEstamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciTipoInforme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcCapacitacionesPorAno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcCapacitacionesPorAno.ResumeLayout(False)
        CType(Me.gdcCapacitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvCapacitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents chkIncluirEstamento As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnVisualizarCapacitaciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lueEstamento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtMesTermino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInicioMes As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lcgCapacitaciones As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciAno As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciMesInicio As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciTerminoMes As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciEstamento As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gpcCapacitacionesPorAno As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gdcCapacitaciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvCapacitaciones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnExportarExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rogTipoInforme As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lciTipoInforme As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colRut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApellidoPaterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApellidoMaterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCapacitacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstadoEvaluacionAprendizaje As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaInicio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostoCapacitacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadParticipantes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaTermino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInsitucionImpartidora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHorasEjecucion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpleadoId As DevExpress.XtraGrid.Columns.GridColumn
End Class
