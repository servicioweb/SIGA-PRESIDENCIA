<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarParticipantesCapacitacion
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
        Me.lycCapacitaciones = New DevExpress.XtraLayout.LayoutControl()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.lueCapacitaciones = New DevExpress.XtraEditors.LookUpEdit()
        Me.lcgCapacitaciones = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciCapacitaciones = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycListaUsuarios = New DevExpress.XtraLayout.LayoutControl()
        Me.btnAsignarParticipante = New DevExpress.XtraEditors.SimpleButton()
        Me.lueUsuarios = New DevExpress.XtraEditors.LookUpEdit()
        Me.lcgUsuarios = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciUsuarios = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.gpcFuncionariosParticipantes = New DevExpress.XtraEditors.GroupControl()
        Me.gdcFuncionariosParticipantes = New DevExpress.XtraGrid.GridControl()
        Me.gdvFuncionariosParticipantes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCapacitacionParticipanteId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpleadoId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreParticipante = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCaludadJuridica = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstamento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstadoEvaluacionAprendizaje = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lueEstadoEvaluacionAprendizaje = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colEvaluacionAprendizaje = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtEvaluacionAprendizaje = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colEvaluacionAplicabilidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lueEvaluacionAplicabilidad = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        CType(Me.lycCapacitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycCapacitaciones.SuspendLayout()
        CType(Me.lueCapacitaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgCapacitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciCapacitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycListaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycListaUsuarios.SuspendLayout()
        CType(Me.lueUsuarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcFuncionariosParticipantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcFuncionariosParticipantes.SuspendLayout()
        CType(Me.gdcFuncionariosParticipantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvFuncionariosParticipantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueEstadoEvaluacionAprendizaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEvaluacionAprendizaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueEvaluacionAplicabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycCapacitaciones
        '
        Me.lycCapacitaciones.Controls.Add(Me.btnLimpiar)
        Me.lycCapacitaciones.Controls.Add(Me.lueCapacitaciones)
        Me.lycCapacitaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lycCapacitaciones.Location = New System.Drawing.Point(12, 12)
        Me.lycCapacitaciones.Name = "lycCapacitaciones"
        Me.lycCapacitaciones.Root = Me.lcgCapacitaciones
        Me.lycCapacitaciones.Size = New System.Drawing.Size(435, 66)
        Me.lycCapacitaciones.TabIndex = 1
        Me.lycCapacitaciones.Text = "LayoutControl1"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(379, 32)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(44, 22)
        Me.btnLimpiar.StyleController = Me.lycCapacitaciones
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        '
        'lueCapacitaciones
        '
        Me.lueCapacitaciones.Location = New System.Drawing.Point(87, 32)
        Me.lueCapacitaciones.Name = "lueCapacitaciones"
        Me.lueCapacitaciones.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCapacitaciones.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CAPACITACION_ID", "Capacitacion ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "NOMBRE CAPACITACIÓN"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("INSTITUCION_IMPARTIDORA", "INSTITUCIÓN IMPARTIDORA"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FECHA_INICIO", "FECHA INICIO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FECHA_TERMINO", "FECHA TÉRMINO")})
        Me.lueCapacitaciones.Properties.NullText = ""
        Me.lueCapacitaciones.Properties.PopupWidth = 600
        Me.lueCapacitaciones.Size = New System.Drawing.Size(288, 20)
        Me.lueCapacitaciones.StyleController = Me.lycCapacitaciones
        Me.lueCapacitaciones.TabIndex = 4
        '
        'lcgCapacitaciones
        '
        Me.lcgCapacitaciones.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lcgCapacitaciones.AppearanceGroup.Options.UseFont = True
        Me.lcgCapacitaciones.CustomizationFormText = "Capacitaciones"
        Me.lcgCapacitaciones.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.lcgCapacitaciones.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciCapacitaciones, Me.LayoutControlItem2})
        Me.lcgCapacitaciones.Location = New System.Drawing.Point(0, 0)
        Me.lcgCapacitaciones.Name = "lcgCapacitaciones"
        Me.lcgCapacitaciones.Size = New System.Drawing.Size(435, 66)
        Me.lcgCapacitaciones.Text = "Capacitaciones"
        '
        'lciCapacitaciones
        '
        Me.lciCapacitaciones.Control = Me.lueCapacitaciones
        Me.lciCapacitaciones.CustomizationFormText = "Capacitaciones"
        Me.lciCapacitaciones.Location = New System.Drawing.Point(0, 0)
        Me.lciCapacitaciones.Name = "lciCapacitaciones"
        Me.lciCapacitaciones.Size = New System.Drawing.Size(367, 26)
        Me.lciCapacitaciones.Text = "Capacitaciones"
        Me.lciCapacitaciones.TextSize = New System.Drawing.Size(72, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnLimpiar
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(367, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(48, 26)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'lycListaUsuarios
        '
        Me.lycListaUsuarios.Controls.Add(Me.btnAsignarParticipante)
        Me.lycListaUsuarios.Controls.Add(Me.lueUsuarios)
        Me.lycListaUsuarios.Location = New System.Drawing.Point(453, 12)
        Me.lycListaUsuarios.Name = "lycListaUsuarios"
        Me.lycListaUsuarios.Root = Me.lcgUsuarios
        Me.lycListaUsuarios.Size = New System.Drawing.Size(414, 66)
        Me.lycListaUsuarios.TabIndex = 2
        Me.lycListaUsuarios.Text = "LayoutControl2"
        '
        'btnAsignarParticipante
        '
        Me.btnAsignarParticipante.Location = New System.Drawing.Point(286, 32)
        Me.btnAsignarParticipante.Name = "btnAsignarParticipante"
        Me.btnAsignarParticipante.Size = New System.Drawing.Size(116, 22)
        Me.btnAsignarParticipante.StyleController = Me.lycListaUsuarios
        Me.btnAsignarParticipante.TabIndex = 3
        Me.btnAsignarParticipante.Text = "Asignar Participante"
        '
        'lueUsuarios
        '
        Me.lueUsuarios.Location = New System.Drawing.Point(56, 32)
        Me.lueUsuarios.Name = "lueUsuarios"
        Me.lueUsuarios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueUsuarios.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMPLEADO_ID", "Empleado ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("APELLIDO_PATERNO", "APELLIDO PATERNO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("APELLIDO_MATERNO", "APELLIDO MATERNO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRES", "NOMBRES"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CALIDAD_JURIDICA", "CALIDAD JURÍDICA"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ESTAMENTO", "ESTAMENTO")})
        Me.lueUsuarios.Properties.DropDownRows = 15
        Me.lueUsuarios.Properties.NullText = ""
        Me.lueUsuarios.Properties.PopupWidth = 600
        Me.lueUsuarios.Size = New System.Drawing.Size(226, 20)
        Me.lueUsuarios.StyleController = Me.lycListaUsuarios
        Me.lueUsuarios.TabIndex = 4
        '
        'lcgUsuarios
        '
        Me.lcgUsuarios.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lcgUsuarios.AppearanceGroup.Options.UseFont = True
        Me.lcgUsuarios.CustomizationFormText = "Lista de Usuarios"
        Me.lcgUsuarios.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.lcgUsuarios.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciUsuarios, Me.LayoutControlItem1})
        Me.lcgUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.lcgUsuarios.Name = "lcgUsuarios"
        Me.lcgUsuarios.Size = New System.Drawing.Size(414, 66)
        Me.lcgUsuarios.Text = "Lista de Usuarios"
        '
        'lciUsuarios
        '
        Me.lciUsuarios.Control = Me.lueUsuarios
        Me.lciUsuarios.CustomizationFormText = "Usuarios"
        Me.lciUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.lciUsuarios.Name = "lciUsuarios"
        Me.lciUsuarios.Size = New System.Drawing.Size(274, 26)
        Me.lciUsuarios.Text = "Usuarios"
        Me.lciUsuarios.TextSize = New System.Drawing.Size(41, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnAsignarParticipante
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(274, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(120, 26)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'gpcFuncionariosParticipantes
        '
        Me.gpcFuncionariosParticipantes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcFuncionariosParticipantes.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcFuncionariosParticipantes.AppearanceCaption.Options.UseFont = True
        Me.gpcFuncionariosParticipantes.Controls.Add(Me.gdcFuncionariosParticipantes)
        Me.gpcFuncionariosParticipantes.Location = New System.Drawing.Point(12, 84)
        Me.gpcFuncionariosParticipantes.Name = "gpcFuncionariosParticipantes"
        Me.gpcFuncionariosParticipantes.Size = New System.Drawing.Size(989, 443)
        Me.gpcFuncionariosParticipantes.TabIndex = 3
        Me.gpcFuncionariosParticipantes.Text = "Funcionarios Participantes"
        '
        'gdcFuncionariosParticipantes
        '
        Me.gdcFuncionariosParticipantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gdcFuncionariosParticipantes.Location = New System.Drawing.Point(2, 22)
        Me.gdcFuncionariosParticipantes.MainView = Me.gdvFuncionariosParticipantes
        Me.gdcFuncionariosParticipantes.Name = "gdcFuncionariosParticipantes"
        Me.gdcFuncionariosParticipantes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lueEstadoEvaluacionAprendizaje, Me.txtEvaluacionAprendizaje, Me.lueEvaluacionAplicabilidad})
        Me.gdcFuncionariosParticipantes.Size = New System.Drawing.Size(985, 419)
        Me.gdcFuncionariosParticipantes.TabIndex = 0
        Me.gdcFuncionariosParticipantes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvFuncionariosParticipantes})
        '
        'gdvFuncionariosParticipantes
        '
        Me.gdvFuncionariosParticipantes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCapacitacionParticipanteId, Me.colEmpleadoId, Me.colRut, Me.colNombreParticipante, Me.colCaludadJuridica, Me.colEstamento, Me.colEstadoEvaluacionAprendizaje, Me.colEvaluacionAprendizaje, Me.colEvaluacionAplicabilidad})
        Me.gdvFuncionariosParticipantes.GridControl = Me.gdcFuncionariosParticipantes
        Me.gdvFuncionariosParticipantes.Name = "gdvFuncionariosParticipantes"
        Me.gdvFuncionariosParticipantes.OptionsView.ShowGroupPanel = False
        '
        'colCapacitacionParticipanteId
        '
        Me.colCapacitacionParticipanteId.Caption = "ID Capacitacion Participante"
        Me.colCapacitacionParticipanteId.FieldName = "CAPACITACION_DET_ID"
        Me.colCapacitacionParticipanteId.Name = "colCapacitacionParticipanteId"
        '
        'colEmpleadoId
        '
        Me.colEmpleadoId.Caption = "Empleado ID"
        Me.colEmpleadoId.FieldName = "EMPLEADO_ID"
        Me.colEmpleadoId.Name = "colEmpleadoId"
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
        Me.colRut.Width = 81
        '
        'colNombreParticipante
        '
        Me.colNombreParticipante.Caption = "NOMBRE PARTICIPANTE"
        Me.colNombreParticipante.FieldName = "NOMBRE"
        Me.colNombreParticipante.Name = "colNombreParticipante"
        Me.colNombreParticipante.OptionsColumn.AllowEdit = False
        Me.colNombreParticipante.OptionsColumn.ReadOnly = True
        Me.colNombreParticipante.Visible = True
        Me.colNombreParticipante.VisibleIndex = 1
        Me.colNombreParticipante.Width = 166
        '
        'colCaludadJuridica
        '
        Me.colCaludadJuridica.Caption = "CALIDAD JURÍDICA"
        Me.colCaludadJuridica.FieldName = "CALIDAD_JURIDICA"
        Me.colCaludadJuridica.Name = "colCaludadJuridica"
        Me.colCaludadJuridica.OptionsColumn.AllowEdit = False
        Me.colCaludadJuridica.OptionsColumn.ReadOnly = True
        Me.colCaludadJuridica.Visible = True
        Me.colCaludadJuridica.VisibleIndex = 2
        Me.colCaludadJuridica.Width = 129
        '
        'colEstamento
        '
        Me.colEstamento.Caption = "ESTAMENTO"
        Me.colEstamento.FieldName = "ESTAMENTO"
        Me.colEstamento.Name = "colEstamento"
        Me.colEstamento.OptionsColumn.AllowEdit = False
        Me.colEstamento.OptionsColumn.ReadOnly = True
        Me.colEstamento.Visible = True
        Me.colEstamento.VisibleIndex = 3
        Me.colEstamento.Width = 102
        '
        'colEstadoEvaluacionAprendizaje
        '
        Me.colEstadoEvaluacionAprendizaje.Caption = "ESTADO EVALUACIÓN APRENDIZAJE"
        Me.colEstadoEvaluacionAprendizaje.ColumnEdit = Me.lueEstadoEvaluacionAprendizaje
        Me.colEstadoEvaluacionAprendizaje.FieldName = "ESTADO_EVALUACION_APRENDIZAJE_ID"
        Me.colEstadoEvaluacionAprendizaje.Name = "colEstadoEvaluacionAprendizaje"
        Me.colEstadoEvaluacionAprendizaje.Visible = True
        Me.colEstadoEvaluacionAprendizaje.VisibleIndex = 4
        Me.colEstadoEvaluacionAprendizaje.Width = 161
        '
        'lueEstadoEvaluacionAprendizaje
        '
        Me.lueEstadoEvaluacionAprendizaje.AutoHeight = False
        Me.lueEstadoEvaluacionAprendizaje.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueEstadoEvaluacionAprendizaje.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ESTADO_EVALUACION_APRENDIZAJE", "Estado Evaluacion Aprendizaje ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ESTADO_EVALUACION_APRENDIZAJE", "Estado Evaluacion de Aprendizaje")})
        Me.lueEstadoEvaluacionAprendizaje.Name = "lueEstadoEvaluacionAprendizaje"
        Me.lueEstadoEvaluacionAprendizaje.NullText = ""
        '
        'colEvaluacionAprendizaje
        '
        Me.colEvaluacionAprendizaje.Caption = "EVALUACIÓN APRENDIZAJE"
        Me.colEvaluacionAprendizaje.ColumnEdit = Me.txtEvaluacionAprendizaje
        Me.colEvaluacionAprendizaje.FieldName = "EVALUACION_APRENDIZAJE"
        Me.colEvaluacionAprendizaje.Name = "colEvaluacionAprendizaje"
        Me.colEvaluacionAprendizaje.Visible = True
        Me.colEvaluacionAprendizaje.VisibleIndex = 5
        Me.colEvaluacionAprendizaje.Width = 150
        '
        'txtEvaluacionAprendizaje
        '
        Me.txtEvaluacionAprendizaje.AutoHeight = False
        Me.txtEvaluacionAprendizaje.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtEvaluacionAprendizaje.MaxLength = 3
        Me.txtEvaluacionAprendizaje.Name = "txtEvaluacionAprendizaje"
        '
        'colEvaluacionAplicabilidad
        '
        Me.colEvaluacionAplicabilidad.Caption = "EVALUACIÓN APLICABILIDAD"
        Me.colEvaluacionAplicabilidad.ColumnEdit = Me.lueEvaluacionAplicabilidad
        Me.colEvaluacionAplicabilidad.FieldName = "EVALUACION_APLICABILIDAD_ID"
        Me.colEvaluacionAplicabilidad.Name = "colEvaluacionAplicabilidad"
        Me.colEvaluacionAplicabilidad.Visible = True
        Me.colEvaluacionAplicabilidad.VisibleIndex = 6
        Me.colEvaluacionAplicabilidad.Width = 175
        '
        'lueEvaluacionAplicabilidad
        '
        Me.lueEvaluacionAplicabilidad.AutoHeight = False
        Me.lueEvaluacionAplicabilidad.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueEvaluacionAplicabilidad.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EVALUACION_APLICABILIDAD_ID", "Evaluacion Aplicabilidad ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE_EVALUACION_APLICABILIDAD", "EVALUACIÓN APLICABILIDAD")})
        Me.lueEvaluacionAplicabilidad.Name = "lueEvaluacionAplicabilidad"
        Me.lueEvaluacionAplicabilidad.NullText = ""
        '
        'frmAsignarParticipantesCapacitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 539)
        Me.Controls.Add(Me.gpcFuncionariosParticipantes)
        Me.Controls.Add(Me.lycListaUsuarios)
        Me.Controls.Add(Me.lycCapacitaciones)
        Me.Name = "frmAsignarParticipantesCapacitacion"
        Me.Text = "Asignar Participantes a Capacitación"
        CType(Me.lycCapacitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycCapacitaciones.ResumeLayout(False)
        CType(Me.lueCapacitaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgCapacitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciCapacitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycListaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycListaUsuarios.ResumeLayout(False)
        CType(Me.lueUsuarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcFuncionariosParticipantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcFuncionariosParticipantes.ResumeLayout(False)
        CType(Me.gdcFuncionariosParticipantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvFuncionariosParticipantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueEstadoEvaluacionAprendizaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEvaluacionAprendizaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueEvaluacionAplicabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lycCapacitaciones As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents lcgCapacitaciones As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lycListaUsuarios As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents btnAsignarParticipante As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lueUsuarios As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lcgUsuarios As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciUsuarios As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gpcFuncionariosParticipantes As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gdcFuncionariosParticipantes As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvFuncionariosParticipantes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCapacitacionParticipanteId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreParticipante As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCaludadJuridica As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstadoEvaluacionAprendizaje As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEvaluacionAprendizaje As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEvaluacionAplicabilidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueCapacitaciones As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lciCapacitaciones As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colEmpleadoId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueEstadoEvaluacionAprendizaje As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtEvaluacionAprendizaje As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents lueEvaluacionAplicabilidad As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
