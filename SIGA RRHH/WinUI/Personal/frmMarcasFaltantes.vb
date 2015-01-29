Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports cl.presidencia.Seguridad

Public Class frmMarcasFaltantes
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
    Friend WithEvents txtNombreEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gleRut As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblFechaInicial As System.Windows.Forms.Label
    Friend WithEvents lblFechaFinal As System.Windows.Forms.Label
    Friend WithEvents dedFechaInicial As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dedFechaFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gdcDetalleMarcas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gdvMarcas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents fieldmarc_generada_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldmarc_fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldmarc_hora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldmarc_estado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldusuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldfecha_modificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dedHoraMarca As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dedFechaActualizacionRegistro As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents cbbOrigen As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents gpcNuevoRegistro As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblFechaMarca As System.Windows.Forms.Label
    Friend WithEvents lblHoraMarca As System.Windows.Forms.Label
    Friend WithEvents dedFechaMarca As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dedHoraMarcaAsistencia As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents fieldmarc_procesa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkIncluyeAsistencia As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpcEncabezado = New DevExpress.XtraEditors.GroupControl
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.dedFechaFinal = New DevExpress.XtraEditors.DateEdit
        Me.dedFechaInicial = New DevExpress.XtraEditors.DateEdit
        Me.lblFechaFinal = New System.Windows.Forms.Label
        Me.lblFechaInicial = New System.Windows.Forms.Label
        Me.txtNombreEmpleado = New DevExpress.XtraEditors.TextEdit
        Me.gleRut = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.lblEmpleado = New System.Windows.Forms.Label
        Me.gdcDetalleMarcas = New DevExpress.XtraGrid.GridControl
        Me.gdvMarcas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.fieldmarc_generada_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldmarc_fecha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldmarc_hora = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dedHoraMarca = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.fieldmarc_estado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cbbOrigen = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.fieldmarc_procesa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkIncluyeAsistencia = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.fieldusuario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldfecha_modificacion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dedFechaActualizacionRegistro = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gpcNuevoRegistro = New DevExpress.XtraEditors.GroupControl
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.dedHoraMarcaAsistencia = New DevExpress.XtraEditors.DateEdit
        Me.lblHoraMarca = New System.Windows.Forms.Label
        Me.dedFechaMarca = New DevExpress.XtraEditors.DateEdit
        Me.lblFechaMarca = New System.Windows.Forms.Label
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcEncabezado.SuspendLayout()
        CType(Me.dedFechaFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcDetalleMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedHoraMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIncluyeAsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaActualizacionRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcNuevoRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcNuevoRegistro.SuspendLayout()
        CType(Me.dedHoraMarcaAsistencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaMarca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcEncabezado
        '
        Me.gpcEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcEncabezado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcEncabezado.AppearanceCaption.Options.UseFont = True
        Me.gpcEncabezado.Controls.Add(Me.btnNuevo)
        Me.gpcEncabezado.Controls.Add(Me.btnBuscar)
        Me.gpcEncabezado.Controls.Add(Me.dedFechaFinal)
        Me.gpcEncabezado.Controls.Add(Me.dedFechaInicial)
        Me.gpcEncabezado.Controls.Add(Me.lblFechaFinal)
        Me.gpcEncabezado.Controls.Add(Me.lblFechaInicial)
        Me.gpcEncabezado.Controls.Add(Me.txtNombreEmpleado)
        Me.gpcEncabezado.Controls.Add(Me.gleRut)
        Me.gpcEncabezado.Controls.Add(Me.lblEmpleado)
        Me.gpcEncabezado.Location = New System.Drawing.Point(8, 8)
        Me.gpcEncabezado.Name = "gpcEncabezado"
        Me.gpcEncabezado.Size = New System.Drawing.Size(664, 112)
        Me.gpcEncabezado.TabIndex = 1
        Me.gpcEncabezado.Text = "Empleado"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(408, 72)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(104, 23)
        Me.btnNuevo.TabIndex = 14
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(280, 72)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(104, 23)
        Me.btnBuscar.TabIndex = 13
        Me.btnBuscar.Text = "Buscar"
        '
        'dedFechaFinal
        '
        Me.dedFechaFinal.EditValue = Nothing
        Me.dedFechaFinal.Location = New System.Drawing.Point(120, 80)
        Me.dedFechaFinal.Name = "dedFechaFinal"
        '
        'dedFechaFinal.Properties
        '
        Me.dedFechaFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaFinal.Size = New System.Drawing.Size(112, 20)
        Me.dedFechaFinal.TabIndex = 12
        '
        'dedFechaInicial
        '
        Me.dedFechaInicial.EditValue = Nothing
        Me.dedFechaInicial.Location = New System.Drawing.Point(120, 56)
        Me.dedFechaInicial.Name = "dedFechaInicial"
        '
        'dedFechaInicial.Properties
        '
        Me.dedFechaInicial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaInicial.Size = New System.Drawing.Size(112, 20)
        Me.dedFechaInicial.TabIndex = 11
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(32, 84)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(80, 16)
        Me.lblFechaFinal.TabIndex = 10
        Me.lblFechaFinal.Text = "Fecha Final"
        Me.lblFechaFinal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(32, 60)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(80, 16)
        Me.lblFechaInicial.TabIndex = 9
        Me.lblFechaInicial.Text = "Fecha Inicial"
        Me.lblFechaInicial.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreEmpleado.Enabled = False
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(240, 32)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        '
        'txtNombreEmpleado.Properties
        '
        Me.txtNombreEmpleado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNombreEmpleado.Properties.Appearance.Options.UseFont = True
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(408, 20)
        Me.txtNombreEmpleado.TabIndex = 8
        '
        'gleRut
        '
        Me.gleRut.EditValue = ""
        Me.gleRut.EnterMoveNextControl = True
        Me.gleRut.Location = New System.Drawing.Point(120, 32)
        Me.gleRut.Name = "gleRut"
        '
        'gleRut.Properties
        '
        Me.gleRut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleRut.Properties.View = Me.GridLookUpEdit1View
        Me.gleRut.Size = New System.Drawing.Size(112, 20)
        Me.gleRut.TabIndex = 1
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
        Me.lblEmpleado.Location = New System.Drawing.Point(32, 36)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(80, 16)
        Me.lblEmpleado.TabIndex = 1
        Me.lblEmpleado.Text = "Rut Empleado"
        Me.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gdcDetalleMarcas
        '
        Me.gdcDetalleMarcas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'gdcDetalleMarcas.EmbeddedNavigator
        '
        Me.gdcDetalleMarcas.EmbeddedNavigator.Name = ""
        Me.gdcDetalleMarcas.Location = New System.Drawing.Point(8, 208)
        Me.gdcDetalleMarcas.MainView = Me.gdvMarcas
        Me.gdcDetalleMarcas.Name = "gdcDetalleMarcas"
        Me.gdcDetalleMarcas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.dedHoraMarca, Me.dedFechaActualizacionRegistro, Me.cbbOrigen, Me.chkIncluyeAsistencia})
        Me.gdcDetalleMarcas.Size = New System.Drawing.Size(664, 264)
        Me.gdcDetalleMarcas.TabIndex = 2
        Me.gdcDetalleMarcas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvMarcas, Me.GridView1})
        '
        'gdvMarcas
        '
        Me.gdvMarcas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.fieldmarc_generada_id, Me.fieldmarc_fecha, Me.fieldmarc_hora, Me.fieldmarc_estado, Me.fieldmarc_procesa, Me.fieldusuario, Me.fieldfecha_modificacion})
        Me.gdvMarcas.GridControl = Me.gdcDetalleMarcas
        Me.gdvMarcas.Name = "gdvMarcas"
        Me.gdvMarcas.OptionsNavigation.EnterMoveNextColumn = True
        Me.gdvMarcas.OptionsView.ShowGroupPanel = False
        '
        'fieldmarc_generada_id
        '
        Me.fieldmarc_generada_id.Caption = "ID Marca"
        Me.fieldmarc_generada_id.FieldName = "marc_generada_id"
        Me.fieldmarc_generada_id.Name = "fieldmarc_generada_id"
        Me.fieldmarc_generada_id.OptionsColumn.AllowEdit = False
        Me.fieldmarc_generada_id.OptionsColumn.ReadOnly = True
        Me.fieldmarc_generada_id.UnboundType = DevExpress.Data.UnboundColumnType.Integer
        '
        'fieldmarc_fecha
        '
        Me.fieldmarc_fecha.Caption = "Fecha"
        Me.fieldmarc_fecha.DisplayFormat.FormatString = "d"
        Me.fieldmarc_fecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldmarc_fecha.FieldName = "marc_fecha"
        Me.fieldmarc_fecha.Name = "fieldmarc_fecha"
        Me.fieldmarc_fecha.OptionsColumn.AllowEdit = False
        Me.fieldmarc_fecha.OptionsColumn.ReadOnly = True
        Me.fieldmarc_fecha.Visible = True
        Me.fieldmarc_fecha.VisibleIndex = 0
        Me.fieldmarc_fecha.Width = 141
        '
        'fieldmarc_hora
        '
        Me.fieldmarc_hora.Caption = "Hora Marca"
        Me.fieldmarc_hora.ColumnEdit = Me.dedHoraMarca
        Me.fieldmarc_hora.FieldName = "marc_hora"
        Me.fieldmarc_hora.Name = "fieldmarc_hora"
        Me.fieldmarc_hora.OptionsColumn.AllowEdit = False
        Me.fieldmarc_hora.OptionsColumn.ReadOnly = True
        Me.fieldmarc_hora.Visible = True
        Me.fieldmarc_hora.VisibleIndex = 1
        Me.fieldmarc_hora.Width = 137
        '
        'dedHoraMarca
        '
        Me.dedHoraMarca.AutoHeight = False
        Me.dedHoraMarca.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedHoraMarca.Mask.EditMask = "t"
        Me.dedHoraMarca.Mask.UseMaskAsDisplayFormat = True
        Me.dedHoraMarca.Name = "dedHoraMarca"
        '
        'fieldmarc_estado
        '
        Me.fieldmarc_estado.Caption = "Origen"
        Me.fieldmarc_estado.ColumnEdit = Me.cbbOrigen
        Me.fieldmarc_estado.FieldName = "marc_estado"
        Me.fieldmarc_estado.Name = "fieldmarc_estado"
        Me.fieldmarc_estado.OptionsColumn.AllowEdit = False
        Me.fieldmarc_estado.OptionsColumn.ReadOnly = True
        '
        'cbbOrigen
        '
        Me.cbbOrigen.AutoHeight = False
        Me.cbbOrigen.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbOrigen.Items.AddRange(New Object() {"CONTROL ACCESO", "INGRESO MANUAL"})
        Me.cbbOrigen.Name = "cbbOrigen"
        '
        'fieldmarc_procesa
        '
        Me.fieldmarc_procesa.Caption = "Procesa Asistencia"
        Me.fieldmarc_procesa.ColumnEdit = Me.chkIncluyeAsistencia
        Me.fieldmarc_procesa.FieldName = "marc_procesa"
        Me.fieldmarc_procesa.Name = "fieldmarc_procesa"
        Me.fieldmarc_procesa.Visible = True
        Me.fieldmarc_procesa.VisibleIndex = 2
        Me.fieldmarc_procesa.Width = 126
        '
        'chkIncluyeAsistencia
        '
        Me.chkIncluyeAsistencia.AutoHeight = False
        Me.chkIncluyeAsistencia.Name = "chkIncluyeAsistencia"
        '
        'fieldusuario
        '
        Me.fieldusuario.Caption = "Usuario"
        Me.fieldusuario.FieldName = "usuario"
        Me.fieldusuario.Name = "fieldusuario"
        Me.fieldusuario.OptionsColumn.AllowEdit = False
        Me.fieldusuario.OptionsColumn.ReadOnly = True
        Me.fieldusuario.Visible = True
        Me.fieldusuario.VisibleIndex = 3
        Me.fieldusuario.Width = 173
        '
        'fieldfecha_modificacion
        '
        Me.fieldfecha_modificacion.Caption = "Fecha Actualización"
        Me.fieldfecha_modificacion.ColumnEdit = Me.dedFechaActualizacionRegistro
        Me.fieldfecha_modificacion.FieldName = "fecha_modificacion"
        Me.fieldfecha_modificacion.Name = "fieldfecha_modificacion"
        Me.fieldfecha_modificacion.OptionsColumn.AllowEdit = False
        Me.fieldfecha_modificacion.OptionsColumn.ReadOnly = True
        Me.fieldfecha_modificacion.Visible = True
        Me.fieldfecha_modificacion.VisibleIndex = 4
        Me.fieldfecha_modificacion.Width = 511
        '
        'dedFechaActualizacionRegistro
        '
        Me.dedFechaActualizacionRegistro.AutoHeight = False
        Me.dedFechaActualizacionRegistro.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaActualizacionRegistro.Mask.EditMask = "G"
        Me.dedFechaActualizacionRegistro.Mask.UseMaskAsDisplayFormat = True
        Me.dedFechaActualizacionRegistro.Name = "dedFechaActualizacionRegistro"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcDetalleMarcas
        Me.GridView1.Name = "GridView1"
        '
        'gpcNuevoRegistro
        '
        Me.gpcNuevoRegistro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcNuevoRegistro.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcNuevoRegistro.AppearanceCaption.Options.UseFont = True
        Me.gpcNuevoRegistro.Controls.Add(Me.btnCancelar)
        Me.gpcNuevoRegistro.Controls.Add(Me.btnGuardar)
        Me.gpcNuevoRegistro.Controls.Add(Me.dedHoraMarcaAsistencia)
        Me.gpcNuevoRegistro.Controls.Add(Me.lblHoraMarca)
        Me.gpcNuevoRegistro.Controls.Add(Me.dedFechaMarca)
        Me.gpcNuevoRegistro.Controls.Add(Me.lblFechaMarca)
        Me.gpcNuevoRegistro.Location = New System.Drawing.Point(8, 120)
        Me.gpcNuevoRegistro.Name = "gpcNuevoRegistro"
        Me.gpcNuevoRegistro.Size = New System.Drawing.Size(664, 88)
        Me.gpcNuevoRegistro.TabIndex = 3
        Me.gpcNuevoRegistro.Text = "Ingreso Registro"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(408, 48)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(104, 23)
        Me.btnCancelar.TabIndex = 16
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(280, 48)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(104, 23)
        Me.btnGuardar.TabIndex = 15
        Me.btnGuardar.Text = "Guardar"
        '
        'dedHoraMarcaAsistencia
        '
        Me.dedHoraMarcaAsistencia.EditValue = Nothing
        Me.dedHoraMarcaAsistencia.Location = New System.Drawing.Point(120, 56)
        Me.dedHoraMarcaAsistencia.Name = "dedHoraMarcaAsistencia"
        '
        'dedHoraMarcaAsistencia.Properties
        '
        Me.dedHoraMarcaAsistencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinRight, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.dedHoraMarcaAsistencia.Properties.DisplayFormat.FormatString = "t"
        Me.dedHoraMarcaAsistencia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dedHoraMarcaAsistencia.Properties.Mask.EditMask = "t"
        Me.dedHoraMarcaAsistencia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dedHoraMarcaAsistencia.Size = New System.Drawing.Size(112, 20)
        Me.dedHoraMarcaAsistencia.TabIndex = 14
        '
        'lblHoraMarca
        '
        Me.lblHoraMarca.Location = New System.Drawing.Point(32, 60)
        Me.lblHoraMarca.Name = "lblHoraMarca"
        Me.lblHoraMarca.Size = New System.Drawing.Size(80, 16)
        Me.lblHoraMarca.TabIndex = 13
        Me.lblHoraMarca.Text = "Hora Marca"
        Me.lblHoraMarca.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dedFechaMarca
        '
        Me.dedFechaMarca.EditValue = Nothing
        Me.dedFechaMarca.Location = New System.Drawing.Point(120, 32)
        Me.dedFechaMarca.Name = "dedFechaMarca"
        '
        'dedFechaMarca.Properties
        '
        Me.dedFechaMarca.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaMarca.Size = New System.Drawing.Size(112, 20)
        Me.dedFechaMarca.TabIndex = 12
        '
        'lblFechaMarca
        '
        Me.lblFechaMarca.Location = New System.Drawing.Point(32, 36)
        Me.lblFechaMarca.Name = "lblFechaMarca"
        Me.lblFechaMarca.Size = New System.Drawing.Size(80, 16)
        Me.lblFechaMarca.TabIndex = 10
        Me.lblFechaMarca.Text = "Fecha"
        Me.lblFechaMarca.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmMarcasFaltantes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(680, 484)
        Me.Controls.Add(Me.gpcNuevoRegistro)
        Me.Controls.Add(Me.gdcDetalleMarcas)
        Me.Controls.Add(Me.gpcEncabezado)
        Me.Name = "frmMarcasFaltantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar/Consultar Marcas Asistencia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcEncabezado.ResumeLayout(False)
        CType(Me.dedFechaFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcDetalleMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedHoraMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIncluyeAsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaActualizacionRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcNuevoRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcNuevoRegistro.ResumeLayout(False)
        CType(Me.dedHoraMarcaAsistencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaMarca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private empleado As empleado

    Private Sub frmMarcasFaltantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empleado = New empleado
        btnNuevo.Enabled = False
        'btnGuardar.Enabled = False
        'btnCancelar.Enabled = False
        gpcNuevoRegistro.Enabled = False
        llenarEmpleado()
    End Sub

    Public Sub llenarEmpleado()
        gleRut.Properties.EditValueChangedFiringDelay = 1200
        gleRut.Properties.EditValueChangedFiringMode = EditValueChangedFiringMode.Buffered
        'Dos segundos se espera antes de gatillar la búsqueda (EditValueChanged)

        gleRut.Properties.ViewType = Repository.GridLookUpViewType.GridView
        gleRut.Properties.View.OptionsBehavior.AutoPopulateColumns = False
        gleRut.Properties.DataSource = repositorio.dvEmpleadosPlantaContrataActivosInactivos
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
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        refrescaDetalle()
    End Sub

    Private Sub gleRut_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gleRut.EditValueChanged
        Cursor.Current = Cursors.WaitCursor
        If IsNumeric(gleRut.EditValue) Then
            empleado = New empleado(CType(gleRut.EditValue, Long))
            txtNombreEmpleado.Text = empleado.nombreCompleto
            refrescaDetalle()
        End If
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub refrescaDetalle()
        If gleRut.EditValue <> Nothing And dedFechaInicial.EditValue <> Nothing And dedFechaFinal.EditValue <> Nothing Then
            gdcDetalleMarcas.DataSource = empleado.dvMarcasControlAcceso(CType(gleRut.EditValue, Integer), dedFechaInicial.EditValue, dedFechaFinal.EditValue)
        End If
        If gleRut.EditValue <> Nothing Then
            btnNuevo.Enabled = Seguridad.TienePermiso("PER-Control Asistencia-Registrar Consultar Marcas (Acceso Total)")
        Else
            btnNuevo.Enabled = False
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        If gleRut.EditValue <> Nothing Then
            gpcNuevoRegistro.Enabled = Seguridad.TienePermiso("PER-Control Asistencia-Registrar Consultar Marcas (Acceso Total)")
        Else
            gpcNuevoRegistro.Enabled = False
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        gpcNuevoRegistro.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim seguir As Boolean = True
        If dedFechaMarca.EditValue = Nothing Then
            seguir = False
            dedFechaMarca.ErrorText = "Falta ingresar fecha asistencia"
        End If
        If dedHoraMarcaAsistencia.EditValue = Nothing Then
            seguir = False
            dedHoraMarcaAsistencia.ErrorText = "Falta ingresar hora asistencia"
        End If

        If seguir Then
            Dim valorRetorno, valorGenerado As Integer
            Dim grabar As Boolean = True
            valorRetorno = empleado.verificarMarcaAssisCAD(gleRut.EditValue, dedHoraMarcaAsistencia.EditValue, dedFechaMarca.EditValue, valorRetorno)
            If valorRetorno = 1 Then
                If MessageBox.Show("Ya existe marca para el empleado. ¿Desea guardarlo?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes Then
                    grabar = True
                Else
                    grabar = False
                End If
            End If
            If grabar Then
                If MessageBox.Show("¿Está seguro(a) de guardar el registro?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes Then
                    valorRetorno = empleado.insertarMarcaAssisCAD(gleRut.EditValue, dedFechaMarca.EditValue, dedHoraMarcaAsistencia.EditValue, valorRetorno)
                    valorGenerado = empleado.generaMarcaAssisCAD(gleRut.EditValue, CType(dedFechaMarca.EditValue, Date).Year, CType(dedFechaMarca.EditValue, Date).Month, valorRetorno)
                    If valorRetorno = 0 Then
                        refrescaDetalle()
                        MsgBox("Registro fue guardado satisfactoriamente.", MsgBoxStyle.Information, "SIGA")
                    Else
                        If valorRetorno = 1 Then
                            MsgBox("Ya existe un registro similar para el empleado.", MsgBoxStyle.Information, "SIGA")
                        Else
                            If valorRetorno = 2 Then
                                MsgBox("Error al intentar gurdar los datos.", MsgBoxStyle.Information, "SIGA")
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub gdvMarcas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvMarcas.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            Dim myview As DevExpress.XtraGrid.Views.Grid.GridView = sender
            Dim OrigenDato As String = myview.GetRowCellValue(myview.FocusedRowHandle, myview.Columns("marc_estado"))
            Dim idMarca As Integer = myview.GetRowCellValue(myview.FocusedRowHandle, myview.Columns("marc_generada_id"))
            Dim marcFecha As Date = myview.GetRowCellValue(myview.FocusedRowHandle, myview.Columns("marc_fecha"))
            If Seguridad.TienePermiso("PER-Control Asistencia-Registrar Consultar Marcas (Acceso Total)") Then
                If OrigenDato = "C" Then
                    MsgBox("Este registro no puede ser eliminado, su origen corresponde a control de acceso", MsgBoxStyle.Information)
                Else
                    If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                        view.DeleteRow(view.FocusedRowHandle)
                        Try
                            Dim valorGenerado As Integer
                            empleado.EliminarMarcaAssissCAD(idMarca)
                            valorGenerado = empleado.generaMarcaAssisCAD(gleRut.EditValue, CType(marcFecha, Date).Year, CType(marcFecha, Date).Month, valorGenerado)
                            refrescaDetalle()
                            MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)
                        Catch ex As Exception
                            MsgBox("Ha ocurrido un error al intentar eliminar el registro " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                        End Try
                    End If
                End If
            Else
                MsgBox("Su cuenta no tiene los permisos necesarios para eliminar registros.", MsgBoxStyle.Information)
            End If

        End If
    End Sub

    Private Sub gdvMarcas_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvMarcas.RowUpdated
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvMarcas
        Dim marcaGeneradaId As Integer = view.GetRowCellValue(view.FocusedRowHandle, "marc_generada_id")
        Dim procesaAsistencia As Integer = view.GetRowCellValue(view.FocusedRowHandle, "marc_procesa")
        Dim fechaMarca As Date = view.GetRowCellValue(view.FocusedRowHandle, "marc_fecha")
        Dim valorRetorno, valorGenerado As Integer
        valorRetorno = empleado.actualizaMarcaAssisCAD(marcaGeneradaId, procesaAsistencia, valorRetorno)
        valorGenerado = empleado.generaMarcaAssisCAD(gleRut.EditValue, CType(fechaMarca, Date).Year, CType(fechaMarca, Date).Month, valorRetorno)

    End Sub
End Class
