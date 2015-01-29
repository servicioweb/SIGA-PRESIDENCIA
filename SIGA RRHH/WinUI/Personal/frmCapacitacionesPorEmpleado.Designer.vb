<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapacitacionesPorEmpleado
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
        Me.gpcEmpleados = New DevExpress.XtraEditors.GroupControl()
        Me.btnExportarExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.lueUsuarios = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnVerEmpleado = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.gpcCapacitaciones = New DevExpress.XtraEditors.GroupControl()
        Me.gdcCapacitaciones = New DevExpress.XtraGrid.GridControl()
        Me.gdvCapacitaciones = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombreCapacitacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoActividad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidadHorasEjecutadas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreJornada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstadoEvaluacionAprendizaje = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaInicio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaTermino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEvaluacionAprendizaje = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEvaluacionAplicabilidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lueEvaluacionAplicabilidad = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        CType(Me.gpcEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcEmpleados.SuspendLayout()
        CType(Me.lueUsuarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcCapacitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcCapacitaciones.SuspendLayout()
        CType(Me.gdcCapacitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvCapacitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueEvaluacionAplicabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcEmpleados
        '
        Me.gpcEmpleados.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcEmpleados.AppearanceCaption.Options.UseFont = True
        Me.gpcEmpleados.Controls.Add(Me.btnExportarExcel)
        Me.gpcEmpleados.Controls.Add(Me.lueUsuarios)
        Me.gpcEmpleados.Controls.Add(Me.btnVerEmpleado)
        Me.gpcEmpleados.Controls.Add(Me.LabelControl1)
        Me.gpcEmpleados.Location = New System.Drawing.Point(12, 12)
        Me.gpcEmpleados.Name = "gpcEmpleados"
        Me.gpcEmpleados.Size = New System.Drawing.Size(563, 62)
        Me.gpcEmpleados.TabIndex = 0
        Me.gpcEmpleados.Text = "Empleados"
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Location = New System.Drawing.Point(460, 25)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(89, 23)
        Me.btnExportarExcel.TabIndex = 6
        Me.btnExportarExcel.Text = "Exportar Excel"
        '
        'lueUsuarios
        '
        Me.lueUsuarios.Location = New System.Drawing.Point(126, 25)
        Me.lueUsuarios.Name = "lueUsuarios"
        Me.lueUsuarios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueUsuarios.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMPLEADO_ID", "Empleado ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("APELLIDO_PATERNO", "APELLIDO PATERNO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("APELLIDO_MATERNO", "APELLIDO MATERNO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRES", "NOMBRES"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CALIDAD_JURIDICA", "CALIDAD JURÍDICA"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ESTAMENTO", "ESTAMENTO")})
        Me.lueUsuarios.Properties.DropDownRows = 15
        Me.lueUsuarios.Properties.NullText = ""
        Me.lueUsuarios.Properties.PopupWidth = 600
        Me.lueUsuarios.Size = New System.Drawing.Size(247, 20)
        Me.lueUsuarios.TabIndex = 5
        '
        'btnVerEmpleado
        '
        Me.btnVerEmpleado.Location = New System.Drawing.Point(379, 25)
        Me.btnVerEmpleado.Name = "btnVerEmpleado"
        Me.btnVerEmpleado.Size = New System.Drawing.Size(75, 23)
        Me.btnVerEmpleado.TabIndex = 2
        Me.btnVerEmpleado.Text = "Visualizar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(6, 28)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(114, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Seleccione un Empleado"
        '
        'gpcCapacitaciones
        '
        Me.gpcCapacitaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcCapacitaciones.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcCapacitaciones.AppearanceCaption.Options.UseFont = True
        Me.gpcCapacitaciones.Controls.Add(Me.gdcCapacitaciones)
        Me.gpcCapacitaciones.Location = New System.Drawing.Point(12, 80)
        Me.gpcCapacitaciones.Name = "gpcCapacitaciones"
        Me.gpcCapacitaciones.Size = New System.Drawing.Size(1071, 414)
        Me.gpcCapacitaciones.TabIndex = 1
        Me.gpcCapacitaciones.Text = "Capacitaciones"
        '
        'gdcCapacitaciones
        '
        Me.gdcCapacitaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gdcCapacitaciones.Location = New System.Drawing.Point(2, 22)
        Me.gdcCapacitaciones.MainView = Me.gdvCapacitaciones
        Me.gdcCapacitaciones.Name = "gdcCapacitaciones"
        Me.gdcCapacitaciones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lueEvaluacionAplicabilidad})
        Me.gdcCapacitaciones.Size = New System.Drawing.Size(1067, 390)
        Me.gdcCapacitaciones.TabIndex = 0
        Me.gdcCapacitaciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvCapacitaciones})
        '
        'gdvCapacitaciones
        '
        Me.gdvCapacitaciones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNombreCapacitacion, Me.colTipoActividad, Me.colCantidadHorasEjecutadas, Me.colNombreJornada, Me.colEstadoEvaluacionAprendizaje, Me.colFechaInicio, Me.colFechaTermino, Me.colEvaluacionAprendizaje, Me.colEvaluacionAplicabilidad})
        Me.gdvCapacitaciones.GridControl = Me.gdcCapacitaciones
        Me.gdvCapacitaciones.Name = "gdvCapacitaciones"
        Me.gdvCapacitaciones.OptionsView.ShowGroupPanel = False
        '
        'colNombreCapacitacion
        '
        Me.colNombreCapacitacion.Caption = "NOMBRE CAPACITACIÓN"
        Me.colNombreCapacitacion.FieldName = "NOMBRE_CAPACITACION"
        Me.colNombreCapacitacion.Name = "colNombreCapacitacion"
        Me.colNombreCapacitacion.OptionsColumn.AllowEdit = False
        Me.colNombreCapacitacion.OptionsColumn.ReadOnly = True
        Me.colNombreCapacitacion.Visible = True
        Me.colNombreCapacitacion.VisibleIndex = 0
        Me.colNombreCapacitacion.Width = 143
        '
        'colTipoActividad
        '
        Me.colTipoActividad.Caption = "TIPO ACTIVIDAD"
        Me.colTipoActividad.FieldName = "TIPO_ACTIVIDAD"
        Me.colTipoActividad.Name = "colTipoActividad"
        Me.colTipoActividad.Visible = True
        Me.colTipoActividad.VisibleIndex = 1
        Me.colTipoActividad.Width = 104
        '
        'colCantidadHorasEjecutadas
        '
        Me.colCantidadHorasEjecutadas.AppearanceCell.Options.UseTextOptions = True
        Me.colCantidadHorasEjecutadas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCantidadHorasEjecutadas.Caption = "HORAS EJECUTADAS"
        Me.colCantidadHorasEjecutadas.FieldName = "CANTIDAD_HORAS_EJECUTADAS"
        Me.colCantidadHorasEjecutadas.Name = "colCantidadHorasEjecutadas"
        Me.colCantidadHorasEjecutadas.Visible = True
        Me.colCantidadHorasEjecutadas.VisibleIndex = 2
        Me.colCantidadHorasEjecutadas.Width = 124
        '
        'colNombreJornada
        '
        Me.colNombreJornada.Caption = "JORNADA"
        Me.colNombreJornada.FieldName = "NOMBRE_JORNADA"
        Me.colNombreJornada.Name = "colNombreJornada"
        Me.colNombreJornada.Visible = True
        Me.colNombreJornada.VisibleIndex = 3
        Me.colNombreJornada.Width = 78
        '
        'colEstadoEvaluacionAprendizaje
        '
        Me.colEstadoEvaluacionAprendizaje.Caption = "ESTADO"
        Me.colEstadoEvaluacionAprendizaje.FieldName = "ESTADO_EVALUACION_APRENDIZAJE"
        Me.colEstadoEvaluacionAprendizaje.Name = "colEstadoEvaluacionAprendizaje"
        Me.colEstadoEvaluacionAprendizaje.OptionsColumn.AllowEdit = False
        Me.colEstadoEvaluacionAprendizaje.OptionsColumn.ReadOnly = True
        Me.colEstadoEvaluacionAprendizaje.Visible = True
        Me.colEstadoEvaluacionAprendizaje.VisibleIndex = 4
        Me.colEstadoEvaluacionAprendizaje.Width = 85
        '
        'colFechaInicio
        '
        Me.colFechaInicio.Caption = "FECHA INICIO"
        Me.colFechaInicio.FieldName = "FECHA_INICIO"
        Me.colFechaInicio.Name = "colFechaInicio"
        Me.colFechaInicio.OptionsColumn.AllowEdit = False
        Me.colFechaInicio.OptionsColumn.ReadOnly = True
        Me.colFechaInicio.Visible = True
        Me.colFechaInicio.VisibleIndex = 5
        Me.colFechaInicio.Width = 94
        '
        'colFechaTermino
        '
        Me.colFechaTermino.Caption = "FECHA TÉRMINO"
        Me.colFechaTermino.FieldName = "FECHA_TERMINO"
        Me.colFechaTermino.Name = "colFechaTermino"
        Me.colFechaTermino.OptionsColumn.AllowEdit = False
        Me.colFechaTermino.OptionsColumn.ReadOnly = True
        Me.colFechaTermino.Visible = True
        Me.colFechaTermino.VisibleIndex = 6
        Me.colFechaTermino.Width = 107
        '
        'colEvaluacionAprendizaje
        '
        Me.colEvaluacionAprendizaje.Caption = "EVALUACIÓN APRENDIZAJE"
        Me.colEvaluacionAprendizaje.FieldName = "EVALUACION_APRENDIZAJE"
        Me.colEvaluacionAprendizaje.Name = "colEvaluacionAprendizaje"
        Me.colEvaluacionAprendizaje.OptionsColumn.AllowEdit = False
        Me.colEvaluacionAprendizaje.OptionsColumn.ReadOnly = True
        Me.colEvaluacionAprendizaje.Visible = True
        Me.colEvaluacionAprendizaje.VisibleIndex = 7
        Me.colEvaluacionAprendizaje.Width = 147
        '
        'colEvaluacionAplicabilidad
        '
        Me.colEvaluacionAplicabilidad.Caption = "EVALUACIÓN APLICABILIDAD"
        Me.colEvaluacionAplicabilidad.ColumnEdit = Me.lueEvaluacionAplicabilidad
        Me.colEvaluacionAplicabilidad.FieldName = "EVALUACION_APLICABILIDAD_ID"
        Me.colEvaluacionAplicabilidad.Name = "colEvaluacionAplicabilidad"
        Me.colEvaluacionAplicabilidad.OptionsColumn.AllowEdit = False
        Me.colEvaluacionAplicabilidad.OptionsColumn.ReadOnly = True
        Me.colEvaluacionAplicabilidad.Visible = True
        Me.colEvaluacionAplicabilidad.VisibleIndex = 8
        Me.colEvaluacionAplicabilidad.Width = 164
        '
        'lueEvaluacionAplicabilidad
        '
        Me.lueEvaluacionAplicabilidad.AutoHeight = False
        Me.lueEvaluacionAplicabilidad.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueEvaluacionAplicabilidad.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EVALUACION_APLICABILIDAD_ID", "Evaluacion Aplicabilidad ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE_EVALUACION_APLICABILIDAD", "EVALUACIÓN APLICABILIDAD")})
        Me.lueEvaluacionAplicabilidad.Name = "lueEvaluacionAplicabilidad"
        '
        'frmCapacitacionesPorEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 506)
        Me.Controls.Add(Me.gpcCapacitaciones)
        Me.Controls.Add(Me.gpcEmpleados)
        Me.Name = "frmCapacitacionesPorEmpleado"
        Me.Text = "Capacitaciones Por Empleado"
        CType(Me.gpcEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcEmpleados.ResumeLayout(False)
        Me.gpcEmpleados.PerformLayout()
        CType(Me.lueUsuarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcCapacitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcCapacitaciones.ResumeLayout(False)
        CType(Me.gdcCapacitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvCapacitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueEvaluacionAplicabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpcEmpleados As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnVerEmpleado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gpcCapacitaciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gdcCapacitaciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvCapacitaciones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNombreCapacitacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstadoEvaluacionAprendizaje As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaInicio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaTermino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEvaluacionAprendizaje As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEvaluacionAplicabilidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueUsuarios As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colTipoActividad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadHorasEjecutadas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreJornada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExportarExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lueEvaluacionAplicabilidad As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
