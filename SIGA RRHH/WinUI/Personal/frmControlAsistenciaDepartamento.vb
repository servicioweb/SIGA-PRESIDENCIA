Imports cl.presidencia.Argo.BusinessRules
Imports DevExpress.XtraGrid.Views.Grid
Imports cl.presidencia.Argo.Reportes

Public Class frmControlAsistenciaDepartamento
    Inherits System.Windows.Forms.Form

    Private asistencia As Asistencia
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
    Friend WithEvents gpcSeleccionDepartamento As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lueDepartamento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblDepartamento As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblfechaAsistencia As System.Windows.Forms.Label
    Friend WithEvents dedFechaAsistencia As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gdcControlAsistencia As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalleControlAsistencia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ASISTENCIA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOMBRE_EMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HORA_ENTRADA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HORA_SALIDA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HORAS_TRABAJADAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HORAS_EXTRAS_DIURNAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dedHoraEntrada As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dedHoraSalida As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dedHorasTrabajadas As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dedHorasExtrasDiurnas As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dedHorasExtrasNocturnas As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents HORAS_EXTRAS_NOCTURNAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HORAS_ATRASOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dedHoraAtraso As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents MEDIO_DIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkMedioDia As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents dedHorasExtrasDiurnasAutorizadas As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dedHorasExtrasNocturrnasAutorizadas As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents chkMedioDiaAutorizado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents dedHoraAtrasoAutorizado As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents HORAS_EXTRAS_DIURNAS_AUTORIZADAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HORAS_ATRASOS_AUTORIZADOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MEDIO_DIA_AUTORIZADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EVENTO_ADMINISTRATIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TIPO_EVENTO_ADMIN_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PERIODO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ANO_REAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MES_REAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OBSERVACIONES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents dedHorasCompensadasDiurnas As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dedHorasCompensadasNocturnas As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents HORAS_COMPENSADAS_DIURNAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HORAS_COMPENSADAS_NOCTURNAS As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpcSeleccionDepartamento = New DevExpress.XtraEditors.GroupControl
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton
        Me.lblfechaAsistencia = New System.Windows.Forms.Label
        Me.dedFechaAsistencia = New DevExpress.XtraEditors.DateEdit
        Me.lueDepartamento = New DevExpress.XtraEditors.LookUpEdit
        Me.lblDepartamento = New DevExpress.XtraEditors.LabelControl
        Me.gdcControlAsistencia = New DevExpress.XtraGrid.GridControl
        Me.gdvDetalleControlAsistencia = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ASISTENCIA_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.EMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NOMBRE_EMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.HORA_ENTRADA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dedHoraEntrada = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.HORA_SALIDA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dedHoraSalida = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.HORAS_TRABAJADAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dedHorasTrabajadas = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.HORAS_EXTRAS_DIURNAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dedHorasExtrasDiurnas = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.HORAS_EXTRAS_DIURNAS_AUTORIZADAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dedHorasExtrasDiurnasAutorizadas = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.HORAS_COMPENSADAS_DIURNAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dedHorasCompensadasDiurnas = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.HORAS_EXTRAS_NOCTURNAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dedHorasExtrasNocturnas = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dedHorasExtrasNocturrnasAutorizadas = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.HORAS_COMPENSADAS_NOCTURNAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dedHorasCompensadasNocturnas = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.HORAS_ATRASOS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dedHoraAtraso = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.MEDIO_DIA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkMedioDia = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.HORAS_ATRASOS_AUTORIZADOS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dedHoraAtrasoAutorizado = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.MEDIO_DIA_AUTORIZADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkMedioDiaAutorizado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.TIPO_EVENTO_ADMIN_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.EVENTO_ADMINISTRATIVO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PERIODO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ANO_REAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MES_REAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OBSERVACIONES = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtObservaciones = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.gpcSeleccionDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionDepartamento.SuspendLayout()
        CType(Me.dedFechaAsistencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcControlAsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleControlAsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedHoraEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedHoraSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedHorasTrabajadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedHorasExtrasDiurnas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedHorasExtrasDiurnasAutorizadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedHorasCompensadasDiurnas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedHorasExtrasNocturnas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedHorasExtrasNocturrnasAutorizadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedHorasCompensadasNocturnas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedHoraAtraso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMedioDia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedHoraAtrasoAutorizado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMedioDiaAutorizado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcSeleccionDepartamento
        '
        Me.gpcSeleccionDepartamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionDepartamento.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionDepartamento.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionDepartamento.Controls.Add(Me.btnVisualizar)
        Me.gpcSeleccionDepartamento.Controls.Add(Me.lblfechaAsistencia)
        Me.gpcSeleccionDepartamento.Controls.Add(Me.dedFechaAsistencia)
        Me.gpcSeleccionDepartamento.Controls.Add(Me.lueDepartamento)
        Me.gpcSeleccionDepartamento.Controls.Add(Me.lblDepartamento)
        Me.gpcSeleccionDepartamento.Location = New System.Drawing.Point(8, 8)
        Me.gpcSeleccionDepartamento.Name = "gpcSeleccionDepartamento"
        Me.gpcSeleccionDepartamento.Size = New System.Drawing.Size(968, 128)
        Me.gpcSeleccionDepartamento.TabIndex = 0
        Me.gpcSeleccionDepartamento.Text = "Selección de Departamento"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(384, 88)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(144, 23)
        Me.btnVisualizar.TabIndex = 78
        Me.btnVisualizar.Text = "Visualizar"
        '
        'lblfechaAsistencia
        '
        Me.lblfechaAsistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechaAsistencia.Location = New System.Drawing.Point(16, 64)
        Me.lblfechaAsistencia.Name = "lblfechaAsistencia"
        Me.lblfechaAsistencia.Size = New System.Drawing.Size(104, 16)
        Me.lblfechaAsistencia.TabIndex = 76
        Me.lblfechaAsistencia.Text = "Fecha Asistencia"
        Me.lblfechaAsistencia.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dedFechaAsistencia
        '
        Me.dedFechaAsistencia.EditValue = Nothing
        Me.dedFechaAsistencia.EnterMoveNextControl = True
        Me.dedFechaAsistencia.Location = New System.Drawing.Point(128, 64)
        Me.dedFechaAsistencia.Name = "dedFechaAsistencia"
        '
        'dedFechaAsistencia.Properties
        '
        Me.dedFechaAsistencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaAsistencia.Size = New System.Drawing.Size(104, 20)
        Me.dedFechaAsistencia.TabIndex = 77
        '
        'lueDepartamento
        '
        Me.lueDepartamento.EnterMoveNextControl = True
        Me.lueDepartamento.Location = New System.Drawing.Point(128, 32)
        Me.lueDepartamento.Name = "lueDepartamento"
        '
        'lueDepartamento.Properties
        '
        Me.lueDepartamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDepartamento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3")})
        Me.lueDepartamento.Size = New System.Drawing.Size(616, 20)
        Me.lueDepartamento.TabIndex = 7
        '
        'lblDepartamento
        '
        Me.lblDepartamento.Location = New System.Drawing.Point(48, 38)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.TabIndex = 6
        Me.lblDepartamento.Text = "Departamento"
        '
        'gdcControlAsistencia
        '
        Me.gdcControlAsistencia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'gdcControlAsistencia.EmbeddedNavigator
        '
        Me.gdcControlAsistencia.EmbeddedNavigator.Name = ""
        Me.gdcControlAsistencia.Location = New System.Drawing.Point(8, 136)
        Me.gdcControlAsistencia.MainView = Me.gdvDetalleControlAsistencia
        Me.gdcControlAsistencia.Name = "gdcControlAsistencia"
        Me.gdcControlAsistencia.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.dedHoraEntrada, Me.dedHoraSalida, Me.dedHorasTrabajadas, Me.dedHorasExtrasDiurnas, Me.dedHorasExtrasNocturnas, Me.dedHoraAtraso, Me.chkMedioDia, Me.dedHorasExtrasDiurnasAutorizadas, Me.dedHorasExtrasNocturrnasAutorizadas, Me.chkMedioDiaAutorizado, Me.dedHoraAtrasoAutorizado, Me.txtObservaciones, Me.dedHorasCompensadasDiurnas, Me.dedHorasCompensadasNocturnas})
        Me.gdcControlAsistencia.Size = New System.Drawing.Size(968, 272)
        Me.gdcControlAsistencia.TabIndex = 1
        Me.gdcControlAsistencia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleControlAsistencia, Me.GridView1})
        '
        'gdvDetalleControlAsistencia
        '
        Me.gdvDetalleControlAsistencia.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.gdvDetalleControlAsistencia.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gdvDetalleControlAsistencia.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ASISTENCIA_ID, Me.EMPLEADO_ID, Me.NOMBRE_EMPLEADO, Me.HORA_ENTRADA, Me.HORA_SALIDA, Me.HORAS_TRABAJADAS, Me.HORAS_EXTRAS_DIURNAS, Me.HORAS_EXTRAS_DIURNAS_AUTORIZADAS, Me.HORAS_COMPENSADAS_DIURNAS, Me.HORAS_EXTRAS_NOCTURNAS, Me.HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS, Me.HORAS_COMPENSADAS_NOCTURNAS, Me.HORAS_ATRASOS, Me.MEDIO_DIA, Me.HORAS_ATRASOS_AUTORIZADOS, Me.MEDIO_DIA_AUTORIZADO, Me.TIPO_EVENTO_ADMIN_ID, Me.EVENTO_ADMINISTRATIVO, Me.PERIODO_ID, Me.ANO_REAL, Me.MES_REAL, Me.OBSERVACIONES})
        Me.gdvDetalleControlAsistencia.GridControl = Me.gdcControlAsistencia
        Me.gdvDetalleControlAsistencia.Name = "gdvDetalleControlAsistencia"
        Me.gdvDetalleControlAsistencia.OptionsNavigation.EnterMoveNextColumn = True
        Me.gdvDetalleControlAsistencia.OptionsView.ColumnAutoWidth = False
        '
        'ASISTENCIA_ID
        '
        Me.ASISTENCIA_ID.Caption = "Asistencia ID"
        Me.ASISTENCIA_ID.FieldName = "ASISTENCIA_ID"
        Me.ASISTENCIA_ID.Name = "ASISTENCIA_ID"
        Me.ASISTENCIA_ID.OptionsColumn.ReadOnly = True
        '
        'EMPLEADO_ID
        '
        Me.EMPLEADO_ID.Caption = "Empleado ID"
        Me.EMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.EMPLEADO_ID.Name = "EMPLEADO_ID"
        Me.EMPLEADO_ID.OptionsColumn.ReadOnly = True
        '
        'NOMBRE_EMPLEADO
        '
        Me.NOMBRE_EMPLEADO.Caption = "Nombre Empleado"
        Me.NOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.NOMBRE_EMPLEADO.Name = "NOMBRE_EMPLEADO"
        Me.NOMBRE_EMPLEADO.OptionsColumn.ReadOnly = True
        Me.NOMBRE_EMPLEADO.Visible = True
        Me.NOMBRE_EMPLEADO.VisibleIndex = 0
        Me.NOMBRE_EMPLEADO.Width = 258
        '
        'HORA_ENTRADA
        '
        Me.HORA_ENTRADA.Caption = "Hora Entrada"
        Me.HORA_ENTRADA.ColumnEdit = Me.dedHoraEntrada
        Me.HORA_ENTRADA.FieldName = "HORA_ENTRADA"
        Me.HORA_ENTRADA.Name = "HORA_ENTRADA"
        Me.HORA_ENTRADA.OptionsColumn.ReadOnly = True
        Me.HORA_ENTRADA.ToolTip = "Hora de entrada del empleado según registro control de acceso"
        Me.HORA_ENTRADA.Visible = True
        Me.HORA_ENTRADA.VisibleIndex = 1
        Me.HORA_ENTRADA.Width = 86
        '
        'dedHoraEntrada
        '
        Me.dedHoraEntrada.AutoHeight = False
        Me.dedHoraEntrada.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.dedHoraEntrada.Mask.EditMask = "t"
        Me.dedHoraEntrada.Mask.UseMaskAsDisplayFormat = True
        Me.dedHoraEntrada.Name = "dedHoraEntrada"
        '
        'HORA_SALIDA
        '
        Me.HORA_SALIDA.Caption = "Hora Salida"
        Me.HORA_SALIDA.ColumnEdit = Me.dedHoraSalida
        Me.HORA_SALIDA.FieldName = "HORA_SALIDA"
        Me.HORA_SALIDA.Name = "HORA_SALIDA"
        Me.HORA_SALIDA.OptionsColumn.ReadOnly = True
        Me.HORA_SALIDA.ToolTip = "Hora de salida del empleado según registro control de acceso"
        Me.HORA_SALIDA.Visible = True
        Me.HORA_SALIDA.VisibleIndex = 2
        Me.HORA_SALIDA.Width = 76
        '
        'dedHoraSalida
        '
        Me.dedHoraSalida.AutoHeight = False
        Me.dedHoraSalida.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.dedHoraSalida.Mask.EditMask = "t"
        Me.dedHoraSalida.Mask.UseMaskAsDisplayFormat = True
        Me.dedHoraSalida.Name = "dedHoraSalida"
        '
        'HORAS_TRABAJADAS
        '
        Me.HORAS_TRABAJADAS.Caption = "Horas Trab."
        Me.HORAS_TRABAJADAS.ColumnEdit = Me.dedHorasTrabajadas
        Me.HORAS_TRABAJADAS.FieldName = "HORAS_TRABAJADAS"
        Me.HORAS_TRABAJADAS.Name = "HORAS_TRABAJADAS"
        Me.HORAS_TRABAJADAS.OptionsColumn.ReadOnly = True
        Me.HORAS_TRABAJADAS.Visible = True
        Me.HORAS_TRABAJADAS.VisibleIndex = 3
        Me.HORAS_TRABAJADAS.Width = 72
        '
        'dedHorasTrabajadas
        '
        Me.dedHorasTrabajadas.AutoHeight = False
        Me.dedHorasTrabajadas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedHorasTrabajadas.Mask.EditMask = "t"
        Me.dedHorasTrabajadas.Mask.UseMaskAsDisplayFormat = True
        Me.dedHorasTrabajadas.Name = "dedHorasTrabajadas"
        '
        'HORAS_EXTRAS_DIURNAS
        '
        Me.HORAS_EXTRAS_DIURNAS.Caption = "Hrs.Ext.Diurnas"
        Me.HORAS_EXTRAS_DIURNAS.ColumnEdit = Me.dedHorasExtrasDiurnas
        Me.HORAS_EXTRAS_DIURNAS.FieldName = "HORAS_EXTRAS_DIURNAS"
        Me.HORAS_EXTRAS_DIURNAS.Name = "HORAS_EXTRAS_DIURNAS"
        Me.HORAS_EXTRAS_DIURNAS.OptionsColumn.ReadOnly = True
        Me.HORAS_EXTRAS_DIURNAS.Visible = True
        Me.HORAS_EXTRAS_DIURNAS.VisibleIndex = 4
        Me.HORAS_EXTRAS_DIURNAS.Width = 104
        '
        'dedHorasExtrasDiurnas
        '
        Me.dedHorasExtrasDiurnas.AutoHeight = False
        Me.dedHorasExtrasDiurnas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.dedHorasExtrasDiurnas.Mask.EditMask = "t"
        Me.dedHorasExtrasDiurnas.Mask.UseMaskAsDisplayFormat = True
        Me.dedHorasExtrasDiurnas.Name = "dedHorasExtrasDiurnas"
        '
        'HORAS_EXTRAS_DIURNAS_AUTORIZADAS
        '
        Me.HORAS_EXTRAS_DIURNAS_AUTORIZADAS.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.HORAS_EXTRAS_DIURNAS_AUTORIZADAS.AppearanceCell.Options.UseForeColor = True
        Me.HORAS_EXTRAS_DIURNAS_AUTORIZADAS.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.HORAS_EXTRAS_DIURNAS_AUTORIZADAS.AppearanceHeader.Options.UseForeColor = True
        Me.HORAS_EXTRAS_DIURNAS_AUTORIZADAS.Caption = "Hrs Ext.Diurnas Aut."
        Me.HORAS_EXTRAS_DIURNAS_AUTORIZADAS.ColumnEdit = Me.dedHorasExtrasDiurnasAutorizadas
        Me.HORAS_EXTRAS_DIURNAS_AUTORIZADAS.FieldName = "HORAS_EXTRAS_DIURNAS_AUTORIZADAS"
        Me.HORAS_EXTRAS_DIURNAS_AUTORIZADAS.Name = "HORAS_EXTRAS_DIURNAS_AUTORIZADAS"
        Me.HORAS_EXTRAS_DIURNAS_AUTORIZADAS.OptionsColumn.ReadOnly = True
        Me.HORAS_EXTRAS_DIURNAS_AUTORIZADAS.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.HORAS_EXTRAS_DIURNAS_AUTORIZADAS.Visible = True
        Me.HORAS_EXTRAS_DIURNAS_AUTORIZADAS.VisibleIndex = 5
        Me.HORAS_EXTRAS_DIURNAS_AUTORIZADAS.Width = 121
        '
        'dedHorasExtrasDiurnasAutorizadas
        '
        Me.dedHorasExtrasDiurnasAutorizadas.AutoHeight = False
        Me.dedHorasExtrasDiurnasAutorizadas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.dedHorasExtrasDiurnasAutorizadas.DisplayFormat.FormatString = "t"
        Me.dedHorasExtrasDiurnasAutorizadas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dedHorasExtrasDiurnasAutorizadas.Mask.EditMask = "t"
        Me.dedHorasExtrasDiurnasAutorizadas.Mask.UseMaskAsDisplayFormat = True
        Me.dedHorasExtrasDiurnasAutorizadas.Name = "dedHorasExtrasDiurnasAutorizadas"
        Me.dedHorasExtrasDiurnasAutorizadas.NullDate = New Date(2008, 7, 17, 10, 59, 18, 432)
        '
        'HORAS_COMPENSADAS_DIURNAS
        '
        Me.HORAS_COMPENSADAS_DIURNAS.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.HORAS_COMPENSADAS_DIURNAS.AppearanceCell.Options.UseForeColor = True
        Me.HORAS_COMPENSADAS_DIURNAS.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.HORAS_COMPENSADAS_DIURNAS.AppearanceHeader.Options.UseForeColor = True
        Me.HORAS_COMPENSADAS_DIURNAS.Caption = "Hrs.Diurnas Comp."
        Me.HORAS_COMPENSADAS_DIURNAS.ColumnEdit = Me.dedHorasCompensadasDiurnas
        Me.HORAS_COMPENSADAS_DIURNAS.FieldName = "HORAS_COMPENSADAS_DIURNAS"
        Me.HORAS_COMPENSADAS_DIURNAS.Name = "HORAS_COMPENSADAS_DIURNAS"
        Me.HORAS_COMPENSADAS_DIURNAS.OptionsColumn.ReadOnly = True
        Me.HORAS_COMPENSADAS_DIURNAS.Visible = True
        Me.HORAS_COMPENSADAS_DIURNAS.VisibleIndex = 6
        Me.HORAS_COMPENSADAS_DIURNAS.Width = 113
        '
        'dedHorasCompensadasDiurnas
        '
        Me.dedHorasCompensadasDiurnas.AutoHeight = False
        Me.dedHorasCompensadasDiurnas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.dedHorasCompensadasDiurnas.DisplayFormat.FormatString = "t"
        Me.dedHorasCompensadasDiurnas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dedHorasCompensadasDiurnas.Mask.EditMask = "t"
        Me.dedHorasCompensadasDiurnas.Mask.UseMaskAsDisplayFormat = True
        Me.dedHorasCompensadasDiurnas.Name = "dedHorasCompensadasDiurnas"
        '
        'HORAS_EXTRAS_NOCTURNAS
        '
        Me.HORAS_EXTRAS_NOCTURNAS.Caption = "Hrs.Ext.Nocturnas"
        Me.HORAS_EXTRAS_NOCTURNAS.ColumnEdit = Me.dedHorasExtrasNocturnas
        Me.HORAS_EXTRAS_NOCTURNAS.FieldName = "HORAS_EXTRAS_NOCTURNAS"
        Me.HORAS_EXTRAS_NOCTURNAS.Name = "HORAS_EXTRAS_NOCTURNAS"
        Me.HORAS_EXTRAS_NOCTURNAS.OptionsColumn.ReadOnly = True
        Me.HORAS_EXTRAS_NOCTURNAS.Visible = True
        Me.HORAS_EXTRAS_NOCTURNAS.VisibleIndex = 7
        Me.HORAS_EXTRAS_NOCTURNAS.Width = 99
        '
        'dedHorasExtrasNocturnas
        '
        Me.dedHorasExtrasNocturnas.AutoHeight = False
        Me.dedHorasExtrasNocturnas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.dedHorasExtrasNocturnas.Mask.EditMask = "t"
        Me.dedHorasExtrasNocturnas.Mask.UseMaskAsDisplayFormat = True
        Me.dedHorasExtrasNocturnas.Name = "dedHorasExtrasNocturnas"
        '
        'HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS
        '
        Me.HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.AppearanceCell.Options.UseForeColor = True
        Me.HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.AppearanceHeader.Options.UseForeColor = True
        Me.HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.Caption = "Hrs. Ext.Nocturnas Aut."
        Me.HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.ColumnEdit = Me.dedHorasExtrasNocturrnasAutorizadas
        Me.HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.FieldName = "HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS"
        Me.HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.Name = "HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS"
        Me.HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.OptionsColumn.ReadOnly = True
        Me.HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.Visible = True
        Me.HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.VisibleIndex = 8
        Me.HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS.Width = 131
        '
        'dedHorasExtrasNocturrnasAutorizadas
        '
        Me.dedHorasExtrasNocturrnasAutorizadas.AutoHeight = False
        Me.dedHorasExtrasNocturrnasAutorizadas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.dedHorasExtrasNocturrnasAutorizadas.Mask.EditMask = "t"
        Me.dedHorasExtrasNocturrnasAutorizadas.Mask.UseMaskAsDisplayFormat = True
        Me.dedHorasExtrasNocturrnasAutorizadas.Name = "dedHorasExtrasNocturrnasAutorizadas"
        '
        'HORAS_COMPENSADAS_NOCTURNAS
        '
        Me.HORAS_COMPENSADAS_NOCTURNAS.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.HORAS_COMPENSADAS_NOCTURNAS.AppearanceCell.Options.UseForeColor = True
        Me.HORAS_COMPENSADAS_NOCTURNAS.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.HORAS_COMPENSADAS_NOCTURNAS.AppearanceHeader.Options.UseForeColor = True
        Me.HORAS_COMPENSADAS_NOCTURNAS.Caption = "Hrs.Noctur.Comp."
        Me.HORAS_COMPENSADAS_NOCTURNAS.ColumnEdit = Me.dedHorasCompensadasNocturnas
        Me.HORAS_COMPENSADAS_NOCTURNAS.FieldName = "HORAS_COMPENSADAS_NOCTURNAS"
        Me.HORAS_COMPENSADAS_NOCTURNAS.Name = "HORAS_COMPENSADAS_NOCTURNAS"
        Me.HORAS_COMPENSADAS_NOCTURNAS.OptionsColumn.ReadOnly = True
        Me.HORAS_COMPENSADAS_NOCTURNAS.Visible = True
        Me.HORAS_COMPENSADAS_NOCTURNAS.VisibleIndex = 9
        Me.HORAS_COMPENSADAS_NOCTURNAS.Width = 101
        '
        'dedHorasCompensadasNocturnas
        '
        Me.dedHorasCompensadasNocturnas.AutoHeight = False
        Me.dedHorasCompensadasNocturnas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.dedHorasCompensadasNocturnas.Mask.EditMask = "t"
        Me.dedHorasCompensadasNocturnas.Mask.UseMaskAsDisplayFormat = True
        Me.dedHorasCompensadasNocturnas.Name = "dedHorasCompensadasNocturnas"
        '
        'HORAS_ATRASOS
        '
        Me.HORAS_ATRASOS.Caption = "Hora Atraso"
        Me.HORAS_ATRASOS.ColumnEdit = Me.dedHoraAtraso
        Me.HORAS_ATRASOS.FieldName = "HORAS_ATRASOS"
        Me.HORAS_ATRASOS.Name = "HORAS_ATRASOS"
        Me.HORAS_ATRASOS.OptionsColumn.ReadOnly = True
        Me.HORAS_ATRASOS.Visible = True
        Me.HORAS_ATRASOS.VisibleIndex = 10
        '
        'dedHoraAtraso
        '
        Me.dedHoraAtraso.AutoHeight = False
        Me.dedHoraAtraso.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.dedHoraAtraso.Mask.EditMask = "t"
        Me.dedHoraAtraso.Mask.UseMaskAsDisplayFormat = True
        Me.dedHoraAtraso.Name = "dedHoraAtraso"
        '
        'MEDIO_DIA
        '
        Me.MEDIO_DIA.Caption = "Inasistencia 1/2 Día"
        Me.MEDIO_DIA.ColumnEdit = Me.chkMedioDia
        Me.MEDIO_DIA.FieldName = "MEDIO_DIA"
        Me.MEDIO_DIA.Name = "MEDIO_DIA"
        Me.MEDIO_DIA.OptionsColumn.ReadOnly = True
        Me.MEDIO_DIA.Visible = True
        Me.MEDIO_DIA.VisibleIndex = 11
        '
        'chkMedioDia
        '
        Me.chkMedioDia.AutoHeight = False
        Me.chkMedioDia.Name = "chkMedioDia"
        Me.chkMedioDia.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'HORAS_ATRASOS_AUTORIZADOS
        '
        Me.HORAS_ATRASOS_AUTORIZADOS.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.HORAS_ATRASOS_AUTORIZADOS.AppearanceHeader.Options.UseForeColor = True
        Me.HORAS_ATRASOS_AUTORIZADOS.Caption = "Hora Atraso Autoriz."
        Me.HORAS_ATRASOS_AUTORIZADOS.ColumnEdit = Me.dedHoraAtrasoAutorizado
        Me.HORAS_ATRASOS_AUTORIZADOS.FieldName = "HORAS_ATRASOS_AUTORIZADOS"
        Me.HORAS_ATRASOS_AUTORIZADOS.Name = "HORAS_ATRASOS_AUTORIZADOS"
        Me.HORAS_ATRASOS_AUTORIZADOS.OptionsColumn.ReadOnly = True
        Me.HORAS_ATRASOS_AUTORIZADOS.Visible = True
        Me.HORAS_ATRASOS_AUTORIZADOS.VisibleIndex = 12
        Me.HORAS_ATRASOS_AUTORIZADOS.Width = 111
        '
        'dedHoraAtrasoAutorizado
        '
        Me.dedHoraAtrasoAutorizado.AutoHeight = False
        Me.dedHoraAtrasoAutorizado.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.dedHoraAtrasoAutorizado.Mask.EditMask = "t"
        Me.dedHoraAtrasoAutorizado.Mask.UseMaskAsDisplayFormat = True
        Me.dedHoraAtrasoAutorizado.Name = "dedHoraAtrasoAutorizado"
        '
        'MEDIO_DIA_AUTORIZADO
        '
        Me.MEDIO_DIA_AUTORIZADO.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.MEDIO_DIA_AUTORIZADO.AppearanceHeader.Options.UseForeColor = True
        Me.MEDIO_DIA_AUTORIZADO.Caption = "Inasistencia 1/2 Día Autoriz."
        Me.MEDIO_DIA_AUTORIZADO.ColumnEdit = Me.chkMedioDiaAutorizado
        Me.MEDIO_DIA_AUTORIZADO.FieldName = "MEDIO_DIA_AUTORIZADO"
        Me.MEDIO_DIA_AUTORIZADO.Name = "MEDIO_DIA_AUTORIZADO"
        Me.MEDIO_DIA_AUTORIZADO.OptionsColumn.ReadOnly = True
        Me.MEDIO_DIA_AUTORIZADO.Visible = True
        Me.MEDIO_DIA_AUTORIZADO.VisibleIndex = 13
        Me.MEDIO_DIA_AUTORIZADO.Width = 158
        '
        'chkMedioDiaAutorizado
        '
        Me.chkMedioDiaAutorizado.AutoHeight = False
        Me.chkMedioDiaAutorizado.Name = "chkMedioDiaAutorizado"
        Me.chkMedioDiaAutorizado.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'TIPO_EVENTO_ADMIN_ID
        '
        Me.TIPO_EVENTO_ADMIN_ID.Caption = "Tipo Evento ID"
        Me.TIPO_EVENTO_ADMIN_ID.FieldName = "TIPO_EVENTO_ADMIN_ID"
        Me.TIPO_EVENTO_ADMIN_ID.Name = "TIPO_EVENTO_ADMIN_ID"
        Me.TIPO_EVENTO_ADMIN_ID.OptionsColumn.ReadOnly = True
        '
        'EVENTO_ADMINISTRATIVO
        '
        Me.EVENTO_ADMINISTRATIVO.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.EVENTO_ADMINISTRATIVO.AppearanceHeader.Options.UseForeColor = True
        Me.EVENTO_ADMINISTRATIVO.Caption = "Evento Administrativo"
        Me.EVENTO_ADMINISTRATIVO.FieldName = "EVENTO_ADMINISTRATIVO"
        Me.EVENTO_ADMINISTRATIVO.Name = "EVENTO_ADMINISTRATIVO"
        Me.EVENTO_ADMINISTRATIVO.OptionsColumn.ReadOnly = True
        Me.EVENTO_ADMINISTRATIVO.Visible = True
        Me.EVENTO_ADMINISTRATIVO.VisibleIndex = 14
        Me.EVENTO_ADMINISTRATIVO.Width = 218
        '
        'PERIODO_ID
        '
        Me.PERIODO_ID.Caption = "Periodo ID"
        Me.PERIODO_ID.FieldName = "PERIODO_ID"
        Me.PERIODO_ID.Name = "PERIODO_ID"
        Me.PERIODO_ID.OptionsColumn.ReadOnly = True
        '
        'ANO_REAL
        '
        Me.ANO_REAL.Caption = "Ano Real Marcada"
        Me.ANO_REAL.FieldName = "ANO_REAL"
        Me.ANO_REAL.Name = "ANO_REAL"
        Me.ANO_REAL.OptionsColumn.ReadOnly = True
        '
        'MES_REAL
        '
        Me.MES_REAL.Caption = "Mes Real Marcada"
        Me.MES_REAL.FieldName = "MES_REAL"
        Me.MES_REAL.Name = "MES_REAL"
        Me.MES_REAL.OptionsColumn.ReadOnly = True
        '
        'OBSERVACIONES
        '
        Me.OBSERVACIONES.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.OBSERVACIONES.AppearanceHeader.Options.UseForeColor = True
        Me.OBSERVACIONES.Caption = "Observaciones"
        Me.OBSERVACIONES.ColumnEdit = Me.txtObservaciones
        Me.OBSERVACIONES.FieldName = "OBSERVACIONES"
        Me.OBSERVACIONES.Name = "OBSERVACIONES"
        Me.OBSERVACIONES.OptionsColumn.ReadOnly = True
        Me.OBSERVACIONES.Visible = True
        Me.OBSERVACIONES.VisibleIndex = 15
        Me.OBSERVACIONES.Width = 141
        '
        'txtObservaciones
        '
        Me.txtObservaciones.AutoHeight = False
        Me.txtObservaciones.MaxLength = 200
        Me.txtObservaciones.Name = "txtObservaciones"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcControlAsistencia
        Me.GridView1.Name = "GridView1"
        '
        'frmControlAsistenciaDepartamento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(984, 414)
        Me.Controls.Add(Me.gdcControlAsistencia)
        Me.Controls.Add(Me.gpcSeleccionDepartamento)
        Me.Name = "frmControlAsistenciaDepartamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Asistencia por Departamento"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcSeleccionDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionDepartamento.ResumeLayout(False)
        CType(Me.dedFechaAsistencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcControlAsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleControlAsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedHoraEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedHoraSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedHorasTrabajadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedHorasExtrasDiurnas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedHorasExtrasDiurnasAutorizadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedHorasCompensadasDiurnas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedHorasExtrasNocturnas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedHorasExtrasNocturrnasAutorizadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedHorasCompensadasNocturnas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedHoraAtraso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMedioDia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedHoraAtrasoAutorizado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMedioDiaAutorizado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmControlAsistenciaDepartamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnVisualizar.Enabled = False
        llenarDepartamento()
        'MessageBox.Show(CType(cl.presidencia.Seguridad.NombreUsuario, String))
        asistencia = New asistencia
    End Sub

    Private Sub llenarDepartamento()
        Comun.Utiles.fillLookUpEdit(lueDepartamento, _
                                    (cl.presidencia.Argo.Comun.Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_DEPARTAMENTO, _
                                    Comun.Tablas.RH_PER_DEPARTAMENTO, "DESCRIPCION", "DEPTO_ID", _
                                    cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)), "DESCRIPCION", "DEPTO_ID")
    End Sub

    Private Sub lueDepartamento_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueDepartamento.EditValueChanged
        refrescarGrilla()
    End Sub

    Private Sub dedFechaAsistencia_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dedFechaAsistencia.EditValueChanged
        refrescarGrilla()
    End Sub

    Private Sub refrescarGrilla()
        If lueDepartamento.EditValue <> Nothing And dedFechaAsistencia.EditValue <> Nothing And dedFechaAsistencia.EditValue >= CType("01/01/2007", Date) Then
            gdcControlAsistencia.DataSource = asistencia.dvControlAsistenciaDepartamento(dedFechaAsistencia.EditValue, lueDepartamento.EditValue)
            If gdvDetalleControlAsistencia.RowCount > 0 Then
                btnVisualizar.Enabled = True
            Else
                btnVisualizar.Enabled = False
            End If
        Else
            btnVisualizar.Enabled = False
        End If
    End Sub

    Private Sub gdvDetalleControlAsistencia_ShowingEditor(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gdvDetalleControlAsistencia.ShowingEditor
        Dim View As GridView = sender

        If View.GetRowCellValue(View.FocusedRowHandle, View.Columns("TIPO_EVENTO_ADMIN_ID")) > 0 Then
            If View.FocusedColumn.FieldName() = "MEDIO_DIA_AUTORIZADO" Then
                '    MsgBox("No puede descontar inasistencia por 1/2 día ya que existe un evento administrativo asociado", MsgBoxStyle.Information)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub gdvDetalleControlAsistencia_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvDetalleControlAsistencia.RowUpdated
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            asignacionCampos(view, e)
            asistencia.actualizar(asistencia.datosDetalleControlAsistencia)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al intentar actualizar control de asistencia " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub asignacionCampos(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs)
        With asistencia.datosDetalleControlAsistencia
            .asistenciaID = view.GetRowCellValue(e.RowHandle, view.Columns("ASISTENCIA_ID"))
            .empleadoID = view.GetRowCellValue(e.RowHandle, view.Columns("EMPLEADO_ID"))
            .periodoID = view.GetRowCellValue(e.RowHandle, view.Columns("PERIODO_ID"))
            .fechaAsistencia = CType(dedFechaAsistencia.EditValue, Date)
            .horaEntrada = CType(view.GetRowCellValue(e.RowHandle, view.Columns("HORA_ENTRADA")), Date)
            .horaSalida = CType(view.GetRowCellValue(e.RowHandle, view.Columns("HORA_SALIDA")), Date)
            .horasTrabajadas = CType(view.GetRowCellValue(e.RowHandle, view.Columns("HORAS_TRABAJADAS")), Date)
            .horasExtrasDiurnas = CType(view.GetRowCellValue(e.RowHandle, view.Columns("HORAS_EXTRAS_DIURNAS")), Date)
            .horasExtrasNocturnas = CType(view.GetRowCellValue(e.RowHandle, view.Columns("HORAS_EXTRAS_NOCTURNAS")), Date)
            .medioDiaAsistencia = view.GetRowCellValue(e.RowHandle, view.Columns("MEDIO_DIA"))
            .horaAtraso = CType(view.GetRowCellValue(e.RowHandle, view.Columns("HORAS_ATRASOS")), Date)
            .horasExtrasDiurnasAutorizadas = CType(view.GetRowCellValue(e.RowHandle, view.Columns("HORAS_EXTRAS_DIURNAS_AUTORIZADAS")), Date)
            .horasExtrasNocturnasAutorizadas = CType(view.GetRowCellValue(e.RowHandle, view.Columns("HORAS_EXTRAS_NOCTURNAS_AUTORIZADAS")), Date)
            .autorizaDesctoMedioDia = view.GetRowCellValue(e.RowHandle, view.Columns("MEDIO_DIA_AUTORIZADO"))
            .tipoEventoAdminID = view.GetRowCellValue(e.RowHandle, view.Columns("TIPO_EVENTO_ADMIN_ID"))
            .horaAtrasoAutorizadas = CType(view.GetRowCellValue(e.RowHandle, view.Columns("HORAS_ATRASOS_AUTORIZADOS")), Date)
            .anoReal = view.GetRowCellValue(e.RowHandle, view.Columns("ANO_REAL"))
            .mesReal = view.GetRowCellValue(e.RowHandle, view.Columns("MES_REAL"))
            .observaciones = view.GetRowCellValue(e.RowHandle, view.Columns("OBSERVACIONES"))
            .horasCompensadasDiurnas = CType(view.GetRowCellValue(e.RowHandle, view.Columns("HORAS_COMPENSADAS_DIURNAS")), Date)
            .horasCompensadasNocturnas = CType(view.GetRowCellValue(e.RowHandle, view.Columns("HORAS_COMPENSADAS_NOCTURNAS")), Date)
        End With
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        Dim totalHrsExtDiurnas, totalHrsExtNocturnas, totalHrsAtraso, totalHrsExtDiurnasAutoriz, totalHrsExtNocturnasAutoriz, totalHrsAtrasoAutoriz As String
        asistencia.sumarHorasDeptofecha(dedFechaAsistencia.EditValue, lueDepartamento.EditValue, totalHrsExtDiurnas, totalHrsExtNocturnas, totalHrsAtraso, totalHrsExtDiurnasAutoriz, totalHrsExtNocturnasAutoriz, totalHrsAtrasoAutoriz)

        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptControlAsistenciaDepartamento
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        Dim strFormulaSeleccion As String = "{VW_CONTROL_ASISTENCIA.DEPTO_ID}=" & lueDepartamento.EditValue
        strFormulaSeleccion &= " AND {VW_CONTROL_ASISTENCIA.FECHA_ASISTENCIA} = date(" & "'" & CType(dedFechaAsistencia.EditValue, Date).Year.ToString & "," & CType(dedFechaAsistencia.EditValue, Date).Month.ToString & "," & CType(dedFechaAsistencia.EditValue, Date).Day.ToString & "')"
        ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
        reporte.SetParameterValue("totalHrsExtDiurnas", Format(CType(totalHrsExtDiurnas, Integer), "0000:00"))
        reporte.SetParameterValue("totalHrsExtNocturnas", Format(CType(totalHrsExtNocturnas, Integer), "0000:00"))
        reporte.SetParameterValue("totalHrsAtraso", Format(CType(totalHrsAtraso, Integer), "0000:00"))
        reporte.SetParameterValue("totalHrsExtDiurnasAutoriz", Format(CType(totalHrsExtDiurnasAutoriz, Integer), "0000:00"))
        reporte.SetParameterValue("totalHrsExtNocturnasAutoriz", Format(CType(totalHrsExtNocturnasAutoriz, Integer), "0000:00"))
        reporte.SetParameterValue("totalHrsAtrasoAutoriz", Format(CType(totalHrsAtrasoAutoriz, Integer), "0000:00"))
        ventanaReporte1.rptVisor.ShowParameterPanelButton = False
        ventanaReporte1.rptVisor.ShowCloseButton = False
        ventanaReporte1.rptVisor.ShowGroupTreeButton = False
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.Show()
    End Sub


End Class
