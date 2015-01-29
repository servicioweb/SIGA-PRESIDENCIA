Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data.SqlClient

Public Class frmCambioSituacionLaboral
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
    Friend WithEvents txtDV As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gleRut As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gevRut As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblRut As System.Windows.Forms.Label
    Friend WithEvents txtNombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblIngresoInstitucion As System.Windows.Forms.Label
    Friend WithEvents txtFechaIngresoInstitucion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaIngAdmPublica As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpcNombreEmpleado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gpcSituacionActual As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblEstadoEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblCalidadJuridica As System.Windows.Forms.Label
    Friend WithEvents txtEstadoEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCalidadJuridica As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblGrado As System.Windows.Forms.Label
    Friend WithEvents lblEstamento As System.Windows.Forms.Label
    Friend WithEvents lblEscalafon As System.Windows.Forms.Label
    Friend WithEvents lblDepto As System.Windows.Forms.Label
    Friend WithEvents txtGrado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEstamento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEscalafon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDepartamento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFechaIngDepartamento As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngEscalafon As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngEstamento As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngGrado As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngCalidadJuridica As System.Windows.Forms.Label
    Friend WithEvents txtFechaIngCalidadJuridica As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaIngGrado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaIngEstamento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaIngEscalafon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaIngDepto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpcSituacionNueva As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkEstadoEmpleado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblTipoMovimiento As System.Windows.Forms.Label
    Friend WithEvents chkCalidadJuridica As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkGrado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEscalafon As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lueEstadoEmpleado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueCalidadJuridica As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueGrado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueEscalafon As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblfechaIngAdminPublica As System.Windows.Forms.Label
    Friend WithEvents lblEscalafonNew As System.Windows.Forms.Label
    Friend WithEvents lblEstamentoNew As System.Windows.Forms.Label
    Friend WithEvents lblGradoNew As System.Windows.Forms.Label
    Friend WithEvents lblCalidadJuridicaNew As System.Windows.Forms.Label
    Friend WithEvents lblEstadoEmpleadoNew As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngEscalafonNew As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngEstamentoNew As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngGradoNew As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngCalidadJuridicaNew As System.Windows.Forms.Label
    Friend WithEvents dteFechaCalidadJuridica As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteFechaGrado As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteFechaEscalafon As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtResolucion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblResolucion As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents lueClasEmpleado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkClasEmpleado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dteFechaClasifEmpleado As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblClasifEmpleado As System.Windows.Forms.Label
    Friend WithEvents txtClasificacionEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblEstamentoNuevo As System.Windows.Forms.Label
    Friend WithEvents lueEstamento As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtDV = New DevExpress.XtraEditors.TextEdit()
        Me.gleRut = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gevRut = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gpcNombreEmpleado = New DevExpress.XtraEditors.GroupControl()
        Me.txtPeriodo = New DevExpress.XtraEditors.TextEdit()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.txtFechaIngAdmPublica = New DevExpress.XtraEditors.TextEdit()
        Me.lblfechaIngAdminPublica = New System.Windows.Forms.Label()
        Me.txtFechaIngresoInstitucion = New DevExpress.XtraEditors.TextEdit()
        Me.lblIngresoInstitucion = New System.Windows.Forms.Label()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.txtNombres = New DevExpress.XtraEditors.TextEdit()
        Me.gpcSituacionActual = New DevExpress.XtraEditors.GroupControl()
        Me.txtClasificacionEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.lblClasifEmpleado = New System.Windows.Forms.Label()
        Me.txtFechaIngDepto = New DevExpress.XtraEditors.TextEdit()
        Me.txtFechaIngEscalafon = New DevExpress.XtraEditors.TextEdit()
        Me.txtFechaIngEstamento = New DevExpress.XtraEditors.TextEdit()
        Me.txtFechaIngGrado = New DevExpress.XtraEditors.TextEdit()
        Me.txtFechaIngCalidadJuridica = New DevExpress.XtraEditors.TextEdit()
        Me.lblFechaIngDepartamento = New System.Windows.Forms.Label()
        Me.lblFechaIngEscalafon = New System.Windows.Forms.Label()
        Me.lblFechaIngEstamento = New System.Windows.Forms.Label()
        Me.lblFechaIngGrado = New System.Windows.Forms.Label()
        Me.lblFechaIngCalidadJuridica = New System.Windows.Forms.Label()
        Me.txtDepartamento = New DevExpress.XtraEditors.TextEdit()
        Me.txtEscalafon = New DevExpress.XtraEditors.TextEdit()
        Me.txtEstamento = New DevExpress.XtraEditors.TextEdit()
        Me.txtGrado = New DevExpress.XtraEditors.TextEdit()
        Me.lblDepto = New System.Windows.Forms.Label()
        Me.lblEscalafon = New System.Windows.Forms.Label()
        Me.lblEstamento = New System.Windows.Forms.Label()
        Me.lblGrado = New System.Windows.Forms.Label()
        Me.txtCalidadJuridica = New DevExpress.XtraEditors.TextEdit()
        Me.txtEstadoEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.lblCalidadJuridica = New System.Windows.Forms.Label()
        Me.lblEstadoEmpleado = New System.Windows.Forms.Label()
        Me.gpcSituacionNueva = New DevExpress.XtraEditors.GroupControl()
        Me.lueEstamento = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblEstamentoNuevo = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.txtObservaciones = New DevExpress.XtraEditors.TextEdit()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.lblResolucion = New System.Windows.Forms.Label()
        Me.txtResolucion = New DevExpress.XtraEditors.TextEdit()
        Me.dteFechaEscalafon = New DevExpress.XtraEditors.DateEdit()
        Me.dteFechaClasifEmpleado = New DevExpress.XtraEditors.DateEdit()
        Me.dteFechaGrado = New DevExpress.XtraEditors.DateEdit()
        Me.dteFechaCalidadJuridica = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaIngEscalafonNew = New System.Windows.Forms.Label()
        Me.lblFechaIngEstamentoNew = New System.Windows.Forms.Label()
        Me.lblFechaIngGradoNew = New System.Windows.Forms.Label()
        Me.lblFechaIngCalidadJuridicaNew = New System.Windows.Forms.Label()
        Me.lueEscalafon = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueClasEmpleado = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueGrado = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueCalidadJuridica = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueEstadoEmpleado = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblEscalafonNew = New System.Windows.Forms.Label()
        Me.lblEstamentoNew = New System.Windows.Forms.Label()
        Me.lblGradoNew = New System.Windows.Forms.Label()
        Me.lblCalidadJuridicaNew = New System.Windows.Forms.Label()
        Me.lblEstadoEmpleadoNew = New System.Windows.Forms.Label()
        Me.chkEscalafon = New DevExpress.XtraEditors.CheckEdit()
        Me.chkClasEmpleado = New DevExpress.XtraEditors.CheckEdit()
        Me.chkGrado = New DevExpress.XtraEditors.CheckEdit()
        Me.chkCalidadJuridica = New DevExpress.XtraEditors.CheckEdit()
        Me.lblTipoMovimiento = New System.Windows.Forms.Label()
        Me.chkEstadoEmpleado = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.txtDV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gevRut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcNombreEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcNombreEmpleado.SuspendLayout()
        CType(Me.txtPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIngAdmPublica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIngresoInstitucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcSituacionActual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSituacionActual.SuspendLayout()
        CType(Me.txtClasificacionEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIngDepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIngEscalafon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIngEstamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIngGrado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIngCalidadJuridica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEscalafon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGrado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCalidadJuridica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstadoEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcSituacionNueva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSituacionNueva.SuspendLayout()
        CType(Me.lueEstamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResolucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaEscalafon.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaEscalafon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaClasifEmpleado.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaClasifEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaGrado.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaGrado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaCalidadJuridica.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaCalidadJuridica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueEscalafon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueClasEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueGrado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCalidadJuridica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueEstadoEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEscalafon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkClasEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGrado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCalidadJuridica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEstadoEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDV
        '
        Me.txtDV.Location = New System.Drawing.Point(288, 24)
        Me.txtDV.Name = "txtDV"
        Me.txtDV.Properties.ReadOnly = True
        Me.txtDV.Size = New System.Drawing.Size(24, 20)
        Me.txtDV.TabIndex = 3
        '
        'gleRut
        '
        Me.gleRut.EditValue = ""
        Me.gleRut.EnterMoveNextControl = True
        Me.gleRut.Location = New System.Drawing.Point(168, 32)
        Me.gleRut.Name = "gleRut"
        Me.gleRut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleRut.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.gleRut.Properties.View = Me.gevRut
        Me.gleRut.Size = New System.Drawing.Size(104, 20)
        Me.gleRut.TabIndex = 2
        '
        'gevRut
        '
        Me.gevRut.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gevRut.Name = "gevRut"
        Me.gevRut.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gevRut.OptionsView.ShowGroupPanel = False
        '
        'gpcNombreEmpleado
        '
        Me.gpcNombreEmpleado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcNombreEmpleado.AppearanceCaption.Options.UseFont = True
        Me.gpcNombreEmpleado.Controls.Add(Me.txtPeriodo)
        Me.gpcNombreEmpleado.Controls.Add(Me.lblPeriodo)
        Me.gpcNombreEmpleado.Controls.Add(Me.txtFechaIngAdmPublica)
        Me.gpcNombreEmpleado.Controls.Add(Me.lblfechaIngAdminPublica)
        Me.gpcNombreEmpleado.Controls.Add(Me.txtFechaIngresoInstitucion)
        Me.gpcNombreEmpleado.Controls.Add(Me.lblIngresoInstitucion)
        Me.gpcNombreEmpleado.Controls.Add(Me.lblRut)
        Me.gpcNombreEmpleado.Controls.Add(Me.txtNombres)
        Me.gpcNombreEmpleado.Controls.Add(Me.txtDV)
        Me.gpcNombreEmpleado.Location = New System.Drawing.Point(16, 8)
        Me.gpcNombreEmpleado.Name = "gpcNombreEmpleado"
        Me.gpcNombreEmpleado.Size = New System.Drawing.Size(760, 104)
        Me.gpcNombreEmpleado.TabIndex = 64
        Me.gpcNombreEmpleado.Text = "Nombre Empleado"
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Enabled = False
        Me.txtPeriodo.Location = New System.Drawing.Point(152, 72)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Size = New System.Drawing.Size(104, 20)
        Me.txtPeriodo.TabIndex = 10
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPeriodo.Location = New System.Drawing.Point(8, 76)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(128, 16)
        Me.lblPeriodo.TabIndex = 9
        Me.lblPeriodo.Text = "Período"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFechaIngAdmPublica
        '
        Me.txtFechaIngAdmPublica.Enabled = False
        Me.txtFechaIngAdmPublica.Location = New System.Drawing.Point(576, 48)
        Me.txtFechaIngAdmPublica.Name = "txtFechaIngAdmPublica"
        Me.txtFechaIngAdmPublica.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaIngAdmPublica.TabIndex = 8
        '
        'lblfechaIngAdminPublica
        '
        Me.lblfechaIngAdminPublica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechaIngAdminPublica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblfechaIngAdminPublica.Location = New System.Drawing.Point(376, 52)
        Me.lblfechaIngAdminPublica.Name = "lblfechaIngAdminPublica"
        Me.lblfechaIngAdminPublica.Size = New System.Drawing.Size(184, 16)
        Me.lblfechaIngAdminPublica.TabIndex = 7
        Me.lblfechaIngAdminPublica.Text = "Ingreso a Administración Pública"
        Me.lblfechaIngAdminPublica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFechaIngresoInstitucion
        '
        Me.txtFechaIngresoInstitucion.Enabled = False
        Me.txtFechaIngresoInstitucion.Location = New System.Drawing.Point(152, 48)
        Me.txtFechaIngresoInstitucion.Name = "txtFechaIngresoInstitucion"
        Me.txtFechaIngresoInstitucion.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaIngresoInstitucion.TabIndex = 6
        '
        'lblIngresoInstitucion
        '
        Me.lblIngresoInstitucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresoInstitucion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblIngresoInstitucion.Location = New System.Drawing.Point(8, 52)
        Me.lblIngresoInstitucion.Name = "lblIngresoInstitucion"
        Me.lblIngresoInstitucion.Size = New System.Drawing.Size(128, 16)
        Me.lblIngresoInstitucion.TabIndex = 5
        Me.lblIngresoInstitucion.Text = "Ingreso a la Institución"
        Me.lblIngresoInstitucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRut
        '
        Me.lblRut.Location = New System.Drawing.Point(112, 32)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(24, 16)
        Me.lblRut.TabIndex = 1
        Me.lblRut.Text = "Rut"
        Me.lblRut.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(320, 24)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombres.Properties.MaxLength = 30
        Me.txtNombres.Properties.ReadOnly = True
        Me.txtNombres.Size = New System.Drawing.Size(360, 20)
        Me.txtNombres.TabIndex = 4
        '
        'gpcSituacionActual
        '
        Me.gpcSituacionActual.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSituacionActual.AppearanceCaption.Options.UseFont = True
        Me.gpcSituacionActual.Controls.Add(Me.txtClasificacionEmpleado)
        Me.gpcSituacionActual.Controls.Add(Me.lblClasifEmpleado)
        Me.gpcSituacionActual.Controls.Add(Me.txtFechaIngDepto)
        Me.gpcSituacionActual.Controls.Add(Me.txtFechaIngEscalafon)
        Me.gpcSituacionActual.Controls.Add(Me.txtFechaIngEstamento)
        Me.gpcSituacionActual.Controls.Add(Me.txtFechaIngGrado)
        Me.gpcSituacionActual.Controls.Add(Me.txtFechaIngCalidadJuridica)
        Me.gpcSituacionActual.Controls.Add(Me.lblFechaIngDepartamento)
        Me.gpcSituacionActual.Controls.Add(Me.lblFechaIngEscalafon)
        Me.gpcSituacionActual.Controls.Add(Me.lblFechaIngEstamento)
        Me.gpcSituacionActual.Controls.Add(Me.lblFechaIngGrado)
        Me.gpcSituacionActual.Controls.Add(Me.lblFechaIngCalidadJuridica)
        Me.gpcSituacionActual.Controls.Add(Me.txtDepartamento)
        Me.gpcSituacionActual.Controls.Add(Me.txtEscalafon)
        Me.gpcSituacionActual.Controls.Add(Me.txtEstamento)
        Me.gpcSituacionActual.Controls.Add(Me.txtGrado)
        Me.gpcSituacionActual.Controls.Add(Me.lblDepto)
        Me.gpcSituacionActual.Controls.Add(Me.lblEscalafon)
        Me.gpcSituacionActual.Controls.Add(Me.lblEstamento)
        Me.gpcSituacionActual.Controls.Add(Me.lblGrado)
        Me.gpcSituacionActual.Controls.Add(Me.txtCalidadJuridica)
        Me.gpcSituacionActual.Controls.Add(Me.txtEstadoEmpleado)
        Me.gpcSituacionActual.Controls.Add(Me.lblCalidadJuridica)
        Me.gpcSituacionActual.Controls.Add(Me.lblEstadoEmpleado)
        Me.gpcSituacionActual.Location = New System.Drawing.Point(16, 112)
        Me.gpcSituacionActual.Name = "gpcSituacionActual"
        Me.gpcSituacionActual.Size = New System.Drawing.Size(760, 208)
        Me.gpcSituacionActual.TabIndex = 65
        Me.gpcSituacionActual.Text = "Situación Actual"
        '
        'txtClasificacionEmpleado
        '
        Me.txtClasificacionEmpleado.Enabled = False
        Me.txtClasificacionEmpleado.Location = New System.Drawing.Point(144, 176)
        Me.txtClasificacionEmpleado.Name = "txtClasificacionEmpleado"
        Me.txtClasificacionEmpleado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtClasificacionEmpleado.Properties.Appearance.Options.UseFont = True
        Me.txtClasificacionEmpleado.Properties.ReadOnly = True
        Me.txtClasificacionEmpleado.Size = New System.Drawing.Size(232, 20)
        Me.txtClasificacionEmpleado.TabIndex = 32
        '
        'lblClasifEmpleado
        '
        Me.lblClasifEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClasifEmpleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblClasifEmpleado.Location = New System.Drawing.Point(0, 176)
        Me.lblClasifEmpleado.Name = "lblClasifEmpleado"
        Me.lblClasifEmpleado.Size = New System.Drawing.Size(136, 16)
        Me.lblClasifEmpleado.TabIndex = 31
        Me.lblClasifEmpleado.Text = "Clasificación Empleado"
        Me.lblClasifEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFechaIngDepto
        '
        Me.txtFechaIngDepto.Enabled = False
        Me.txtFechaIngDepto.Location = New System.Drawing.Point(576, 152)
        Me.txtFechaIngDepto.Name = "txtFechaIngDepto"
        Me.txtFechaIngDepto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtFechaIngDepto.Properties.Appearance.Options.UseFont = True
        Me.txtFechaIngDepto.Properties.ReadOnly = True
        Me.txtFechaIngDepto.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaIngDepto.TabIndex = 30
        '
        'txtFechaIngEscalafon
        '
        Me.txtFechaIngEscalafon.Enabled = False
        Me.txtFechaIngEscalafon.Location = New System.Drawing.Point(576, 128)
        Me.txtFechaIngEscalafon.Name = "txtFechaIngEscalafon"
        Me.txtFechaIngEscalafon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtFechaIngEscalafon.Properties.Appearance.Options.UseFont = True
        Me.txtFechaIngEscalafon.Properties.ReadOnly = True
        Me.txtFechaIngEscalafon.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaIngEscalafon.TabIndex = 28
        '
        'txtFechaIngEstamento
        '
        Me.txtFechaIngEstamento.Enabled = False
        Me.txtFechaIngEstamento.Location = New System.Drawing.Point(576, 104)
        Me.txtFechaIngEstamento.Name = "txtFechaIngEstamento"
        Me.txtFechaIngEstamento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtFechaIngEstamento.Properties.Appearance.Options.UseFont = True
        Me.txtFechaIngEstamento.Properties.ReadOnly = True
        Me.txtFechaIngEstamento.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaIngEstamento.TabIndex = 26
        '
        'txtFechaIngGrado
        '
        Me.txtFechaIngGrado.Enabled = False
        Me.txtFechaIngGrado.Location = New System.Drawing.Point(576, 80)
        Me.txtFechaIngGrado.Name = "txtFechaIngGrado"
        Me.txtFechaIngGrado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtFechaIngGrado.Properties.Appearance.Options.UseFont = True
        Me.txtFechaIngGrado.Properties.ReadOnly = True
        Me.txtFechaIngGrado.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaIngGrado.TabIndex = 24
        '
        'txtFechaIngCalidadJuridica
        '
        Me.txtFechaIngCalidadJuridica.Enabled = False
        Me.txtFechaIngCalidadJuridica.Location = New System.Drawing.Point(576, 56)
        Me.txtFechaIngCalidadJuridica.Name = "txtFechaIngCalidadJuridica"
        Me.txtFechaIngCalidadJuridica.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtFechaIngCalidadJuridica.Properties.Appearance.Options.UseFont = True
        Me.txtFechaIngCalidadJuridica.Properties.ReadOnly = True
        Me.txtFechaIngCalidadJuridica.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaIngCalidadJuridica.TabIndex = 22
        '
        'lblFechaIngDepartamento
        '
        Me.lblFechaIngDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngDepartamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaIngDepartamento.Location = New System.Drawing.Point(416, 152)
        Me.lblFechaIngDepartamento.Name = "lblFechaIngDepartamento"
        Me.lblFechaIngDepartamento.Size = New System.Drawing.Size(152, 16)
        Me.lblFechaIngDepartamento.TabIndex = 29
        Me.lblFechaIngDepartamento.Text = "Fecha Ing.Departamento"
        Me.lblFechaIngDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaIngEscalafon
        '
        Me.lblFechaIngEscalafon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngEscalafon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaIngEscalafon.Location = New System.Drawing.Point(448, 128)
        Me.lblFechaIngEscalafon.Name = "lblFechaIngEscalafon"
        Me.lblFechaIngEscalafon.Size = New System.Drawing.Size(120, 16)
        Me.lblFechaIngEscalafon.TabIndex = 27
        Me.lblFechaIngEscalafon.Text = "Fecha Ing.Escalafón"
        Me.lblFechaIngEscalafon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaIngEstamento
        '
        Me.lblFechaIngEstamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngEstamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaIngEstamento.Location = New System.Drawing.Point(424, 104)
        Me.lblFechaIngEstamento.Name = "lblFechaIngEstamento"
        Me.lblFechaIngEstamento.Size = New System.Drawing.Size(144, 16)
        Me.lblFechaIngEstamento.TabIndex = 25
        Me.lblFechaIngEstamento.Text = "Fecha Ing.Estamento"
        Me.lblFechaIngEstamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaIngGrado
        '
        Me.lblFechaIngGrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngGrado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaIngGrado.Location = New System.Drawing.Point(456, 80)
        Me.lblFechaIngGrado.Name = "lblFechaIngGrado"
        Me.lblFechaIngGrado.Size = New System.Drawing.Size(112, 16)
        Me.lblFechaIngGrado.TabIndex = 23
        Me.lblFechaIngGrado.Text = "Fecha Ing.Grado"
        Me.lblFechaIngGrado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaIngCalidadJuridica
        '
        Me.lblFechaIngCalidadJuridica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngCalidadJuridica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaIngCalidadJuridica.Location = New System.Drawing.Point(408, 56)
        Me.lblFechaIngCalidadJuridica.Name = "lblFechaIngCalidadJuridica"
        Me.lblFechaIngCalidadJuridica.Size = New System.Drawing.Size(160, 16)
        Me.lblFechaIngCalidadJuridica.TabIndex = 21
        Me.lblFechaIngCalidadJuridica.Text = "Fecha Ing.Calidad Jurídica"
        Me.lblFechaIngCalidadJuridica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Enabled = False
        Me.txtDepartamento.Location = New System.Drawing.Point(144, 152)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDepartamento.Properties.Appearance.Options.UseFont = True
        Me.txtDepartamento.Properties.ReadOnly = True
        Me.txtDepartamento.Size = New System.Drawing.Size(232, 20)
        Me.txtDepartamento.TabIndex = 20
        '
        'txtEscalafon
        '
        Me.txtEscalafon.Enabled = False
        Me.txtEscalafon.Location = New System.Drawing.Point(144, 128)
        Me.txtEscalafon.Name = "txtEscalafon"
        Me.txtEscalafon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtEscalafon.Properties.Appearance.Options.UseFont = True
        Me.txtEscalafon.Properties.ReadOnly = True
        Me.txtEscalafon.Size = New System.Drawing.Size(232, 20)
        Me.txtEscalafon.TabIndex = 18
        '
        'txtEstamento
        '
        Me.txtEstamento.Enabled = False
        Me.txtEstamento.Location = New System.Drawing.Point(144, 104)
        Me.txtEstamento.Name = "txtEstamento"
        Me.txtEstamento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtEstamento.Properties.Appearance.Options.UseFont = True
        Me.txtEstamento.Properties.ReadOnly = True
        Me.txtEstamento.Size = New System.Drawing.Size(232, 20)
        Me.txtEstamento.TabIndex = 16
        '
        'txtGrado
        '
        Me.txtGrado.Enabled = False
        Me.txtGrado.Location = New System.Drawing.Point(144, 80)
        Me.txtGrado.Name = "txtGrado"
        Me.txtGrado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtGrado.Properties.Appearance.Options.UseFont = True
        Me.txtGrado.Properties.ReadOnly = True
        Me.txtGrado.Size = New System.Drawing.Size(232, 20)
        Me.txtGrado.TabIndex = 14
        '
        'lblDepto
        '
        Me.lblDepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDepto.Location = New System.Drawing.Point(24, 152)
        Me.lblDepto.Name = "lblDepto"
        Me.lblDepto.Size = New System.Drawing.Size(112, 16)
        Me.lblDepto.TabIndex = 19
        Me.lblDepto.Text = "Departamento"
        Me.lblDepto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEscalafon
        '
        Me.lblEscalafon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEscalafon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEscalafon.Location = New System.Drawing.Point(24, 128)
        Me.lblEscalafon.Name = "lblEscalafon"
        Me.lblEscalafon.Size = New System.Drawing.Size(112, 16)
        Me.lblEscalafon.TabIndex = 17
        Me.lblEscalafon.Text = "Escalafón"
        Me.lblEscalafon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEstamento
        '
        Me.lblEstamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEstamento.Location = New System.Drawing.Point(24, 104)
        Me.lblEstamento.Name = "lblEstamento"
        Me.lblEstamento.Size = New System.Drawing.Size(112, 16)
        Me.lblEstamento.TabIndex = 15
        Me.lblEstamento.Text = "Estamento"
        Me.lblEstamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGrado
        '
        Me.lblGrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGrado.Location = New System.Drawing.Point(24, 80)
        Me.lblGrado.Name = "lblGrado"
        Me.lblGrado.Size = New System.Drawing.Size(112, 16)
        Me.lblGrado.TabIndex = 13
        Me.lblGrado.Text = "Grado"
        Me.lblGrado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCalidadJuridica
        '
        Me.txtCalidadJuridica.Enabled = False
        Me.txtCalidadJuridica.Location = New System.Drawing.Point(144, 56)
        Me.txtCalidadJuridica.Name = "txtCalidadJuridica"
        Me.txtCalidadJuridica.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCalidadJuridica.Properties.Appearance.Options.UseFont = True
        Me.txtCalidadJuridica.Properties.ReadOnly = True
        Me.txtCalidadJuridica.Size = New System.Drawing.Size(232, 20)
        Me.txtCalidadJuridica.TabIndex = 12
        '
        'txtEstadoEmpleado
        '
        Me.txtEstadoEmpleado.Enabled = False
        Me.txtEstadoEmpleado.Location = New System.Drawing.Point(144, 32)
        Me.txtEstadoEmpleado.Name = "txtEstadoEmpleado"
        Me.txtEstadoEmpleado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtEstadoEmpleado.Properties.Appearance.Options.UseFont = True
        Me.txtEstadoEmpleado.Properties.ReadOnly = True
        Me.txtEstadoEmpleado.Size = New System.Drawing.Size(232, 20)
        Me.txtEstadoEmpleado.TabIndex = 10
        '
        'lblCalidadJuridica
        '
        Me.lblCalidadJuridica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalidadJuridica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCalidadJuridica.Location = New System.Drawing.Point(24, 56)
        Me.lblCalidadJuridica.Name = "lblCalidadJuridica"
        Me.lblCalidadJuridica.Size = New System.Drawing.Size(112, 16)
        Me.lblCalidadJuridica.TabIndex = 11
        Me.lblCalidadJuridica.Text = "Calidad Jurídica"
        Me.lblCalidadJuridica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEstadoEmpleado
        '
        Me.lblEstadoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoEmpleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEstadoEmpleado.Location = New System.Drawing.Point(24, 32)
        Me.lblEstadoEmpleado.Name = "lblEstadoEmpleado"
        Me.lblEstadoEmpleado.Size = New System.Drawing.Size(112, 16)
        Me.lblEstadoEmpleado.TabIndex = 9
        Me.lblEstadoEmpleado.Text = "Estado Empleado"
        Me.lblEstadoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gpcSituacionNueva
        '
        Me.gpcSituacionNueva.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSituacionNueva.AppearanceCaption.Options.UseFont = True
        Me.gpcSituacionNueva.Controls.Add(Me.lueEstamento)
        Me.gpcSituacionNueva.Controls.Add(Me.lblEstamentoNuevo)
        Me.gpcSituacionNueva.Controls.Add(Me.lblObservaciones)
        Me.gpcSituacionNueva.Controls.Add(Me.txtObservaciones)
        Me.gpcSituacionNueva.Controls.Add(Me.btnGuardar)
        Me.gpcSituacionNueva.Controls.Add(Me.lblResolucion)
        Me.gpcSituacionNueva.Controls.Add(Me.txtResolucion)
        Me.gpcSituacionNueva.Controls.Add(Me.dteFechaEscalafon)
        Me.gpcSituacionNueva.Controls.Add(Me.dteFechaClasifEmpleado)
        Me.gpcSituacionNueva.Controls.Add(Me.dteFechaGrado)
        Me.gpcSituacionNueva.Controls.Add(Me.dteFechaCalidadJuridica)
        Me.gpcSituacionNueva.Controls.Add(Me.lblFechaIngEscalafonNew)
        Me.gpcSituacionNueva.Controls.Add(Me.lblFechaIngEstamentoNew)
        Me.gpcSituacionNueva.Controls.Add(Me.lblFechaIngGradoNew)
        Me.gpcSituacionNueva.Controls.Add(Me.lblFechaIngCalidadJuridicaNew)
        Me.gpcSituacionNueva.Controls.Add(Me.lueEscalafon)
        Me.gpcSituacionNueva.Controls.Add(Me.lueClasEmpleado)
        Me.gpcSituacionNueva.Controls.Add(Me.lueGrado)
        Me.gpcSituacionNueva.Controls.Add(Me.lueCalidadJuridica)
        Me.gpcSituacionNueva.Controls.Add(Me.lueEstadoEmpleado)
        Me.gpcSituacionNueva.Controls.Add(Me.lblEscalafonNew)
        Me.gpcSituacionNueva.Controls.Add(Me.lblEstamentoNew)
        Me.gpcSituacionNueva.Controls.Add(Me.lblGradoNew)
        Me.gpcSituacionNueva.Controls.Add(Me.lblCalidadJuridicaNew)
        Me.gpcSituacionNueva.Controls.Add(Me.lblEstadoEmpleadoNew)
        Me.gpcSituacionNueva.Controls.Add(Me.chkEscalafon)
        Me.gpcSituacionNueva.Controls.Add(Me.chkClasEmpleado)
        Me.gpcSituacionNueva.Controls.Add(Me.chkGrado)
        Me.gpcSituacionNueva.Controls.Add(Me.chkCalidadJuridica)
        Me.gpcSituacionNueva.Controls.Add(Me.lblTipoMovimiento)
        Me.gpcSituacionNueva.Controls.Add(Me.chkEstadoEmpleado)
        Me.gpcSituacionNueva.Location = New System.Drawing.Point(16, 320)
        Me.gpcSituacionNueva.Name = "gpcSituacionNueva"
        Me.gpcSituacionNueva.Size = New System.Drawing.Size(760, 320)
        Me.gpcSituacionNueva.TabIndex = 66
        Me.gpcSituacionNueva.Text = "Situacion Nueva"
        '
        'lueEstamento
        '
        Me.lueEstamento.Location = New System.Drawing.Point(144, 185)
        Me.lueEstamento.Name = "lueEstamento"
        Me.lueEstamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueEstamento.Properties.NullText = ""
        Me.lueEstamento.Size = New System.Drawing.Size(232, 20)
        Me.lueEstamento.TabIndex = 66
        '
        'lblEstamentoNuevo
        '
        Me.lblEstamentoNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstamentoNuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEstamentoNuevo.Location = New System.Drawing.Point(24, 185)
        Me.lblEstamentoNuevo.Name = "lblEstamentoNuevo"
        Me.lblEstamentoNuevo.Size = New System.Drawing.Size(112, 16)
        Me.lblEstamentoNuevo.TabIndex = 65
        Me.lblEstamentoNuevo.Text = "Estamento"
        Me.lblEstamentoNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblObservaciones.Location = New System.Drawing.Point(24, 233)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(112, 16)
        Me.lblObservaciones.TabIndex = 52
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(144, 233)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(536, 20)
        Me.txtObservaciones.TabIndex = 53
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(336, 288)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 64
        Me.btnGuardar.Text = "&Guardar"
        '
        'lblResolucion
        '
        Me.lblResolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResolucion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblResolucion.Location = New System.Drawing.Point(24, 209)
        Me.lblResolucion.Name = "lblResolucion"
        Me.lblResolucion.Size = New System.Drawing.Size(112, 16)
        Me.lblResolucion.TabIndex = 50
        Me.lblResolucion.Text = "Resolución"
        Me.lblResolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtResolucion
        '
        Me.txtResolucion.Location = New System.Drawing.Point(144, 209)
        Me.txtResolucion.Name = "txtResolucion"
        Me.txtResolucion.Size = New System.Drawing.Size(232, 20)
        Me.txtResolucion.TabIndex = 51
        '
        'dteFechaEscalafon
        '
        Me.dteFechaEscalafon.EditValue = Nothing
        Me.dteFechaEscalafon.Location = New System.Drawing.Point(576, 160)
        Me.dteFechaEscalafon.Name = "dteFechaEscalafon"
        Me.dteFechaEscalafon.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaEscalafon.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteFechaEscalafon.Size = New System.Drawing.Size(104, 20)
        Me.dteFechaEscalafon.TabIndex = 61
        '
        'dteFechaClasifEmpleado
        '
        Me.dteFechaClasifEmpleado.EditValue = Nothing
        Me.dteFechaClasifEmpleado.Location = New System.Drawing.Point(576, 136)
        Me.dteFechaClasifEmpleado.Name = "dteFechaClasifEmpleado"
        Me.dteFechaClasifEmpleado.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.dteFechaClasifEmpleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaClasifEmpleado.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteFechaClasifEmpleado.Size = New System.Drawing.Size(104, 20)
        Me.dteFechaClasifEmpleado.TabIndex = 59
        '
        'dteFechaGrado
        '
        Me.dteFechaGrado.EditValue = Nothing
        Me.dteFechaGrado.Location = New System.Drawing.Point(576, 112)
        Me.dteFechaGrado.Name = "dteFechaGrado"
        Me.dteFechaGrado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaGrado.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteFechaGrado.Size = New System.Drawing.Size(104, 20)
        Me.dteFechaGrado.TabIndex = 57
        '
        'dteFechaCalidadJuridica
        '
        Me.dteFechaCalidadJuridica.EditValue = Nothing
        Me.dteFechaCalidadJuridica.Location = New System.Drawing.Point(576, 88)
        Me.dteFechaCalidadJuridica.Name = "dteFechaCalidadJuridica"
        Me.dteFechaCalidadJuridica.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaCalidadJuridica.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteFechaCalidadJuridica.Size = New System.Drawing.Size(104, 20)
        Me.dteFechaCalidadJuridica.TabIndex = 55
        '
        'lblFechaIngEscalafonNew
        '
        Me.lblFechaIngEscalafonNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngEscalafonNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaIngEscalafonNew.Location = New System.Drawing.Point(448, 160)
        Me.lblFechaIngEscalafonNew.Name = "lblFechaIngEscalafonNew"
        Me.lblFechaIngEscalafonNew.Size = New System.Drawing.Size(120, 16)
        Me.lblFechaIngEscalafonNew.TabIndex = 60
        Me.lblFechaIngEscalafonNew.Text = "Fecha Ing.Escalafón"
        Me.lblFechaIngEscalafonNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaIngEstamentoNew
        '
        Me.lblFechaIngEstamentoNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngEstamentoNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaIngEstamentoNew.Location = New System.Drawing.Point(408, 136)
        Me.lblFechaIngEstamentoNew.Name = "lblFechaIngEstamentoNew"
        Me.lblFechaIngEstamentoNew.Size = New System.Drawing.Size(160, 16)
        Me.lblFechaIngEstamentoNew.TabIndex = 58
        Me.lblFechaIngEstamentoNew.Text = "Fecha Ing.Clasif.Empleado"
        Me.lblFechaIngEstamentoNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaIngGradoNew
        '
        Me.lblFechaIngGradoNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngGradoNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaIngGradoNew.Location = New System.Drawing.Point(456, 112)
        Me.lblFechaIngGradoNew.Name = "lblFechaIngGradoNew"
        Me.lblFechaIngGradoNew.Size = New System.Drawing.Size(112, 16)
        Me.lblFechaIngGradoNew.TabIndex = 56
        Me.lblFechaIngGradoNew.Text = "Fecha Ing.Grado"
        Me.lblFechaIngGradoNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaIngCalidadJuridicaNew
        '
        Me.lblFechaIngCalidadJuridicaNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngCalidadJuridicaNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaIngCalidadJuridicaNew.Location = New System.Drawing.Point(408, 88)
        Me.lblFechaIngCalidadJuridicaNew.Name = "lblFechaIngCalidadJuridicaNew"
        Me.lblFechaIngCalidadJuridicaNew.Size = New System.Drawing.Size(160, 16)
        Me.lblFechaIngCalidadJuridicaNew.TabIndex = 54
        Me.lblFechaIngCalidadJuridicaNew.Text = "Fecha Ing.Calidad Jurídica"
        Me.lblFechaIngCalidadJuridicaNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lueEscalafon
        '
        Me.lueEscalafon.Location = New System.Drawing.Point(144, 160)
        Me.lueEscalafon.Name = "lueEscalafon"
        Me.lueEscalafon.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueEscalafon.Properties.NullText = ""
        Me.lueEscalafon.Size = New System.Drawing.Size(232, 20)
        Me.lueEscalafon.TabIndex = 47
        '
        'lueClasEmpleado
        '
        Me.lueClasEmpleado.Location = New System.Drawing.Point(144, 136)
        Me.lueClasEmpleado.Name = "lueClasEmpleado"
        Me.lueClasEmpleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueClasEmpleado.Properties.NullText = ""
        Me.lueClasEmpleado.Size = New System.Drawing.Size(232, 20)
        Me.lueClasEmpleado.TabIndex = 45
        '
        'lueGrado
        '
        Me.lueGrado.Location = New System.Drawing.Point(144, 112)
        Me.lueGrado.Name = "lueGrado"
        Me.lueGrado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueGrado.Properties.NullText = ""
        Me.lueGrado.Size = New System.Drawing.Size(232, 20)
        Me.lueGrado.TabIndex = 43
        '
        'lueCalidadJuridica
        '
        Me.lueCalidadJuridica.Location = New System.Drawing.Point(144, 88)
        Me.lueCalidadJuridica.Name = "lueCalidadJuridica"
        Me.lueCalidadJuridica.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCalidadJuridica.Properties.NullText = ""
        Me.lueCalidadJuridica.Size = New System.Drawing.Size(232, 20)
        Me.lueCalidadJuridica.TabIndex = 41
        '
        'lueEstadoEmpleado
        '
        Me.lueEstadoEmpleado.Location = New System.Drawing.Point(144, 64)
        Me.lueEstadoEmpleado.Name = "lueEstadoEmpleado"
        Me.lueEstadoEmpleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueEstadoEmpleado.Properties.NullText = ""
        Me.lueEstadoEmpleado.Size = New System.Drawing.Size(232, 20)
        Me.lueEstadoEmpleado.TabIndex = 39
        '
        'lblEscalafonNew
        '
        Me.lblEscalafonNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEscalafonNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEscalafonNew.Location = New System.Drawing.Point(24, 160)
        Me.lblEscalafonNew.Name = "lblEscalafonNew"
        Me.lblEscalafonNew.Size = New System.Drawing.Size(112, 16)
        Me.lblEscalafonNew.TabIndex = 46
        Me.lblEscalafonNew.Text = "Escalafón"
        Me.lblEscalafonNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEstamentoNew
        '
        Me.lblEstamentoNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstamentoNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEstamentoNew.Location = New System.Drawing.Point(0, 136)
        Me.lblEstamentoNew.Name = "lblEstamentoNew"
        Me.lblEstamentoNew.Size = New System.Drawing.Size(136, 16)
        Me.lblEstamentoNew.TabIndex = 44
        Me.lblEstamentoNew.Text = "Clasificación Empleado"
        Me.lblEstamentoNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGradoNew
        '
        Me.lblGradoNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradoNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGradoNew.Location = New System.Drawing.Point(24, 112)
        Me.lblGradoNew.Name = "lblGradoNew"
        Me.lblGradoNew.Size = New System.Drawing.Size(112, 16)
        Me.lblGradoNew.TabIndex = 42
        Me.lblGradoNew.Text = "Grado"
        Me.lblGradoNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCalidadJuridicaNew
        '
        Me.lblCalidadJuridicaNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalidadJuridicaNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCalidadJuridicaNew.Location = New System.Drawing.Point(24, 88)
        Me.lblCalidadJuridicaNew.Name = "lblCalidadJuridicaNew"
        Me.lblCalidadJuridicaNew.Size = New System.Drawing.Size(112, 16)
        Me.lblCalidadJuridicaNew.TabIndex = 40
        Me.lblCalidadJuridicaNew.Text = "Calidad Jurídica"
        Me.lblCalidadJuridicaNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEstadoEmpleadoNew
        '
        Me.lblEstadoEmpleadoNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoEmpleadoNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEstadoEmpleadoNew.Location = New System.Drawing.Point(24, 64)
        Me.lblEstadoEmpleadoNew.Name = "lblEstadoEmpleadoNew"
        Me.lblEstadoEmpleadoNew.Size = New System.Drawing.Size(112, 16)
        Me.lblEstadoEmpleadoNew.TabIndex = 38
        Me.lblEstadoEmpleadoNew.Text = "Estado Empleado"
        Me.lblEstadoEmpleadoNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkEscalafon
        '
        Me.chkEscalafon.Location = New System.Drawing.Point(528, 32)
        Me.chkEscalafon.Name = "chkEscalafon"
        Me.chkEscalafon.Properties.Caption = "Escalafón"
        Me.chkEscalafon.Size = New System.Drawing.Size(72, 19)
        Me.chkEscalafon.TabIndex = 36
        '
        'chkClasEmpleado
        '
        Me.chkClasEmpleado.Location = New System.Drawing.Point(424, 32)
        Me.chkClasEmpleado.Name = "chkClasEmpleado"
        Me.chkClasEmpleado.Properties.Caption = "Clasif.Empleado"
        Me.chkClasEmpleado.Size = New System.Drawing.Size(104, 19)
        Me.chkClasEmpleado.TabIndex = 35
        '
        'chkGrado
        '
        Me.chkGrado.Location = New System.Drawing.Point(360, 32)
        Me.chkGrado.Name = "chkGrado"
        Me.chkGrado.Properties.Caption = "Grado"
        Me.chkGrado.Size = New System.Drawing.Size(64, 19)
        Me.chkGrado.TabIndex = 34
        '
        'chkCalidadJuridica
        '
        Me.chkCalidadJuridica.Location = New System.Drawing.Point(256, 32)
        Me.chkCalidadJuridica.Name = "chkCalidadJuridica"
        Me.chkCalidadJuridica.Properties.Caption = "Calidad Jurídica"
        Me.chkCalidadJuridica.Size = New System.Drawing.Size(96, 19)
        Me.chkCalidadJuridica.TabIndex = 33
        '
        'lblTipoMovimiento
        '
        Me.lblTipoMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoMovimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTipoMovimiento.Location = New System.Drawing.Point(24, 32)
        Me.lblTipoMovimiento.Name = "lblTipoMovimiento"
        Me.lblTipoMovimiento.Size = New System.Drawing.Size(112, 16)
        Me.lblTipoMovimiento.TabIndex = 31
        Me.lblTipoMovimiento.Text = "Tipo Movimiento"
        Me.lblTipoMovimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkEstadoEmpleado
        '
        Me.chkEstadoEmpleado.Location = New System.Drawing.Point(144, 32)
        Me.chkEstadoEmpleado.Name = "chkEstadoEmpleado"
        Me.chkEstadoEmpleado.Properties.Caption = "Estado Empleado"
        Me.chkEstadoEmpleado.Size = New System.Drawing.Size(104, 19)
        Me.chkEstadoEmpleado.TabIndex = 32
        '
        'frmCambioSituacionLaboral
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(784, 646)
        Me.Controls.Add(Me.gpcSituacionNueva)
        Me.Controls.Add(Me.gpcSituacionActual)
        Me.Controls.Add(Me.gleRut)
        Me.Controls.Add(Me.gpcNombreEmpleado)
        Me.Name = "frmCambioSituacionLaboral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio Situacion Laboral del Empleado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txtDV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gevRut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcNombreEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcNombreEmpleado.ResumeLayout(False)
        CType(Me.txtPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIngAdmPublica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIngresoInstitucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcSituacionActual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSituacionActual.ResumeLayout(False)
        CType(Me.txtClasificacionEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIngDepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIngEscalafon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIngEstamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIngGrado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIngCalidadJuridica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEscalafon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGrado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCalidadJuridica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstadoEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcSituacionNueva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSituacionNueva.ResumeLayout(False)
        CType(Me.lueEstamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResolucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaEscalafon.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaEscalafon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaClasifEmpleado.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaClasifEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaGrado.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaGrado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaCalidadJuridica.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaCalidadJuridica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueEscalafon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueClasEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueGrado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCalidadJuridica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueEstadoEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEscalafon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkClasEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGrado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCalidadJuridica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEstadoEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Dim empleado As Empleado
    Dim parametroMensual As Periodo
    Dim movimiento As String
    Dim diasMes As Integer = 30
    Dim montoSueldoBase As Integer = 0
    Dim montoAsignacionProfesional As Integer = 0
    Dim montoAsignacionResposabilidad As Integer = 0
    Dim montoAsignacionLey19185Art18 As Integer = 0
    Dim montoGastoRepresentacion As Integer = 0
    Dim montoFuncionCritica As Integer = 0
    Dim montoAsignacionLey18717 As Integer = 0
    Dim montoAsignacionLey18675Art10 As Integer = 0
    Dim montoAsignacionLey18675Art11 As Integer = 0
    Dim montoAsignacionLey18566 As Integer = 0
    Dim montoLey3551 As Integer = 0
    Dim montoIncrementoPrevisionalDL3551 As Integer = 0


    Private Sub frmCambioSituacionLaboral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        parametroMensual = New Periodo
        repositorio.Show()
        habilitaCheckControl(True)
        llenarRutEmpleado()
        llenarEstadoEmpleado()
        llenarCalidadJuridica()
        llenarGrado()
        llenarClasEmpleado()
        llenarEscalafon()
        llenarEstamento()
        limpiarControles()
    End Sub

    Public Sub llenarRutEmpleado()
        'gleRut.DataBindings.Add("EditValue", repositorio.dvEmpleadoVista, "EMPLEADO_ID")
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

        Dim col7 As GridColumn = gleRut.Properties.View.Columns.AddField("NOMBRE_COMPLETO")
        col7.VisibleIndex = 6
        col7.Caption = "Nombre Completo"
        col7.Visible = False

        'gleRut.Properties.ValueMember = "EMPLEADO_ID"
        gleRut.Properties.ValueMember = "RUT"

        gleRut.Properties.View.BestFitColumns()
        gleRut.Properties.PopupFormWidth = 600

        gleRut.Text = ""
    End Sub
    Private Sub gleRut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gleRut.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If IsNumeric(gleRut.EditValue) Then
                    empleado = New Empleado(CType(gleRut.EditValue, Integer))
                End If
            Catch exp As Exception
                MessageBox.Show(exp.Message, "Cambio Estado Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                refrescarControles()
            End Try
        End If
    End Sub
    Private Sub refrescarControles()
        txtDV.Text = empleado.rut.dv
        txtNombres.Text = empleado.nombreCompleto
        txtFechaIngresoInstitucion.Text = empleado.datosLaborales.fechaIngresoInstitucion
        txtFechaIngAdmPublica.Text = empleado.datosLaborales.fechaIngresoAdministracionPublica
        txtEstadoEmpleado.Text = DataAccess.Utiles.buscaID(Tablas.RH_PER_ESTADO_EMPLEADO, "NN", "ESTADO_EMPLEADO_ID", empleado.estado, "DESCRIPCION")
        txtCalidadJuridica.Text = DataAccess.Utiles.buscaID(Tablas.RH_REM_CALIDAD_JURIDICA, "NN", "CALIDAD_JURIDICA_ID", empleado.datosLaborales.calidadJuridicaID, "DESCRIPCION")
        txtGrado.Text = DataAccess.Utiles.buscaID(Tablas.RH_REM_GRADO, "NN", "GRADO_ID", empleado.datosLaborales.gradoID, "GRADO_ALIAS")
        txtEstamento.Text = DataAccess.Utiles.buscaID(Tablas.RH_PER_ESTAMENTO, "NN", "ESTAMENTO_ID", empleado.datosLaborales.estamentoID, "DESCRIPCION")
        txtEscalafon.Text = DataAccess.Utiles.buscaID(Tablas.RH_PER_ESCALAFON, "NN", "ESCALAFON_ID", empleado.datosLaborales.escalafonID, "DESCRIPCION")
        txtDepartamento.Text = DataAccess.Utiles.buscaID(Tablas.RH_PER_DEPARTAMENTO, "NN", "DEPTO_ID", empleado.datosLaborales.jefeID, "DESCRIPCION")
        txtClasificacionEmpleado.Text = DataAccess.Utiles.buscaID(Tablas.RH_REM_CLASIFICACION_EMPLEADO, "NN", "CLASIFICACION_EMPLEADO_ID", empleado.datosLaborales.clasificacionEmpleadoID, "DESCRIPCION")
        txtFechaIngCalidadJuridica.Text = empleado.datosLaborales.fechaIngresoCalidadJuridica
        txtFechaIngGrado.Text = empleado.datosLaborales.fechaIngresoGrado
        txtFechaIngEstamento.Text = empleado.datosLaborales.fechaIngresoEstamento
        txtFechaIngEscalafon.Text = empleado.datosLaborales.fechaIngresoEscalafon
        txtFechaIngDepto.Text = empleado.datosLaborales.fechaIngresoDepartamento
        txtPeriodo.Text = parametroMensual.anoMes
        lueEstadoEmpleado.Properties.ReadOnly = True
        lueCalidadJuridica.Properties.ReadOnly = True
        lueGrado.Properties.ReadOnly = True
        lueClasEmpleado.Properties.ReadOnly = True
        lueEscalafon.Properties.ReadOnly = True
        dteFechaCalidadJuridica.Properties.ReadOnly = True
        dteFechaGrado.Properties.ReadOnly = True
        dteFechaClasifEmpleado.Properties.ReadOnly = True
        dteFechaEscalafon.Properties.ReadOnly = True
        movimiento = ""
        habilitaCheckControl(False)

    End Sub
    Public Sub llenarEstadoEmpleado()
        With lueEstadoEmpleado
            With .Properties.Columns
                .Add(New LookUpColumnInfo("ESTADO_EMPLEADO_ID", "ID Estado", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueEstadoEmpleado.Properties.DataSource = repositorio.dvEstadoEmpleadoCambioSituacionLab
        lueEstadoEmpleado.Properties.DisplayMember = "DESCRIPCION"
        lueEstadoEmpleado.Properties.NullText = ""
        lueEstadoEmpleado.Properties.PopupWidth = 200
        lueEstadoEmpleado.Properties.ValueMember = "ESTADO_EMPLEADO_ID"
    End Sub
    Public Sub llenarCalidadJuridica()
        With lueCalidadJuridica
            With .Properties.Columns
                .Add(New LookUpColumnInfo("CALIDAD_JURIDICA_ID", "ID Calidad Juridica", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueCalidadJuridica.Properties.DataSource = repositorio.dvCalidadJuridica
        lueCalidadJuridica.Properties.DisplayMember = "DESCRIPCION"
        lueCalidadJuridica.Properties.NullText = ""
        lueCalidadJuridica.Properties.PopupWidth = 200
        lueCalidadJuridica.Properties.ValueMember = "CALIDAD_JURIDICA_ID"
    End Sub
    Public Sub llenarGrado()
        With lueGrado
            With .Properties.Columns
                .Add(New LookUpColumnInfo("GRADO_ID", "ID Grado", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("GRADO_ALIAS", "Grado", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueGrado.Properties.DataSource = repositorio.dvGrado
        lueGrado.Properties.DisplayMember = "GRADO_ALIAS"
        lueGrado.Properties.NullText = ""
        lueGrado.Properties.PopupWidth = 200
        lueGrado.Properties.ValueMember = "GRADO_ID"
    End Sub
    Public Sub llenarClasEmpleado()
        With lueClasEmpleado
            With .Properties.Columns
                .Add(New LookUpColumnInfo("CLASIFICACION_EMPLEADO_ID", "ID Clas.Empleado", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ESTAMENTO_ID", "ID Estamento", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueClasEmpleado.Properties.DataSource = repositorio.dvClasificacionEmpleado
        lueClasEmpleado.Properties.DisplayMember = "DESCRIPCION"
        lueClasEmpleado.Properties.NullText = ""
        lueClasEmpleado.Properties.PopupWidth = 200
        lueClasEmpleado.Properties.ValueMember = "CLASIFICACION_EMPLEADO_ID"
    End Sub
    Public Sub llenarEscalafon()
        With lueEscalafon
            With .Properties.Columns
                .Add(New LookUpColumnInfo("ESCALAFON_ID", "ID Escalafon", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueEscalafon.Properties.DataSource = repositorio.dvEscalafon
        lueEscalafon.Properties.DisplayMember = "DESCRIPCION"
        lueEscalafon.Properties.NullText = ""
        lueEscalafon.Properties.PopupWidth = 200
        lueEscalafon.Properties.ValueMember = "ESCALAFON_ID"
    End Sub
    Public Sub llenarEstamento()
        With lueEstamento
            With .Properties.Columns
                .Add(New LookUpColumnInfo("ESTAMENTO_ID", "ID Estamento", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueEstamento.Properties.DataSource = repositorio.dvEstamento
        lueEstamento.Properties.DisplayMember = "DESCRIPCION"
        lueEstamento.Properties.NullText = ""
        lueEstamento.Properties.PopupWidth = 200
        lueEstamento.Properties.ValueMember = "ESTAMENTO_ID"
    End Sub

  
    Private Sub chkEstadoEmpleado_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkEstadoEmpleado.CheckStateChanged
        If chkEstadoEmpleado.Checked Then
            lueEstadoEmpleado.Properties.ReadOnly = False
        Else
            lueEstadoEmpleado.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub chkCalidadJuridica_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCalidadJuridica.CheckedChanged
        If chkCalidadJuridica.Checked Then
            lueCalidadJuridica.Properties.ReadOnly = False
            dteFechaCalidadJuridica.Properties.ReadOnly = False
        Else
            lueCalidadJuridica.Properties.ReadOnly = True
            dteFechaCalidadJuridica.Properties.ReadOnly = True
        End If
    End Sub
    Private Sub chkGrado_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkGrado.CheckedChanged
        If chkGrado.Checked Then
            lueGrado.Properties.ReadOnly = False
            dteFechaGrado.Properties.ReadOnly = False
        Else
            lueGrado.Properties.ReadOnly = True
            dteFechaGrado.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub chkClasEmpleado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkClasEmpleado.CheckedChanged
        If chkClasEmpleado.Checked Then
            lueClasEmpleado.Properties.ReadOnly = False
            dteFechaClasifEmpleado.Properties.ReadOnly = False
            lueEstamento.Properties.ReadOnly = False
        Else
            lueClasEmpleado.Properties.ReadOnly = True
            dteFechaClasifEmpleado.Properties.ReadOnly = True
            lueEstamento.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub chkEscalafon_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkEscalafon.CheckedChanged
        If chkEscalafon.Checked Then
            lueEscalafon.Properties.ReadOnly = False
            dteFechaEscalafon.Properties.ReadOnly = False
        Else
            lueEscalafon.Properties.ReadOnly = True
            dteFechaEscalafon.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub habilitaCheckControl(ByVal valorBoolean As Boolean)
        chkEstadoEmpleado.Properties.ReadOnly = valorBoolean
        chkCalidadJuridica.Properties.ReadOnly = valorBoolean
        chkClasEmpleado.Properties.ReadOnly = valorBoolean
        chkEscalafon.Properties.ReadOnly = valorBoolean
        btnGuardar.Enabled = Not valorBoolean
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim oldEstado As Integer
        Dim oldCalidadJuridica As Integer
        Dim oldFechaIngGrado As Date
        Dim continuar As Boolean = True
        Dim tipoProcesoRemun As String = ""
        Dim newCalidadJuridida As Integer = lueCalidadJuridica.EditValue
        oldEstado = empleado.estadoEmpleadoID
        oldCalidadJuridica = empleado.datosLaborales.calidadJuridicaID
        If validarChecks() Then
            If chkCalidadJuridica.Checked And oldCalidadJuridica = Comun.TiposDeDatos.TipoCalidadJuridica.HONORARIOS And lueCalidadJuridica.EditValue <> Comun.TiposDeDatos.TipoCalidadJuridica.HONORARIOS Then
                If MsgBox("Usted procederá a cambiar la calidad jurídica del empleado." & Chr(13) & "¿Esta seguro que actualizó los datos previsionales del empleado " & empleado.nombreCompleto & "?" & Chr(13) & Chr(13) & "¿Desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                    continuar = True
                Else
                    continuar = False
                End If
            End If
            If chkClasEmpleado.Checked And Not chkEscalafon.Checked Then
                If MsgBox("Usted elegió actualizar clasificación del empleado, pero no así el escalafón." & Chr(13) & "Se sugiere verificar relación entre clasificación empleado, estamento y escalafón." & Chr(13) & Chr(13) & "¿Desea continuar sin actualizar escalafón?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
                    continuar = True
                Else
                    continuar = False
                End If
            End If
            If continuar Then
                If MsgBox("Al guardar se cambiará el estado del registro actual y se generará un nuevo registro con los cambios realizados." & Chr(13) & Chr(13) & "¿Desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    Try
                        If chkEstadoEmpleado.Checked Or chkCalidadJuridica.Checked Or chkGrado.Checked Or chkClasEmpleado.Checked Or chkEscalafon.Checked Then
                            'El registro actual activo en RH_PER_ANTECEDENTE_LABORAL se cambia a inactivo
                            If chkGrado.Checked Then
                                'Si la fecha ingreso al grado es mayor a primer día se debe distribuir los días
                                'para asignar los montos de asignación según los días en el grado
                                oldFechaIngGrado = dteFechaGrado.EditValue
                                If dteFechaGrado.DateTime.Day > 1 And dteFechaGrado.DateTime.Month = parametroMensual.mes Then
                                    If empleado.datosLaborales.fechaIngresoGrado.Month = dteFechaGrado.DateTime.Date.Month And empleado.datosLaborales.fechaIngresoGrado.Year = dteFechaGrado.DateTime.Month Then
                                        empleado.datosLaborales.diasGrado = dteFechaGrado.DateTime.Day - empleado.datosLaborales.fechaIngresoGrado.Month
                                    Else
                                        empleado.datosLaborales.diasGrado = dteFechaGrado.DateTime.Day - 1
                                    End If
                                    empleado.datosLaborales.periodoIDCambioSituacionLaboral = parametroMensual.ID
                                    inicializaAsignaciones()
                                    sumatoriaAsignaciones(empleado.datosLaborales.diasGrado)
                                Else
                                    empleado.datosLaborales.diasGrado = 0
                                End If
                            End If
                            empleado.datosLaborales.estadoRegistro = Comun.TiposDeDatos.EstadoRegistro.INACTIVO
                            empleado.actualizarDatosLaboral(empleado.datosLaborales)
                        End If
                    Catch ex As Exception
                        MsgBox("Ha ocurrido un error al intentar cambiar el estado de " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                    Try
                        If chkEstadoEmpleado.Checked Then
                            'Si se escoje cambiar el estado de empleado, debe actualizar el estado en RH_PER_EMPLEADO
                            empleado.estadoEmpleadoID = lueEstadoEmpleado.EditValue
                            'Si el estado anterior del empleado es POR ACTIVAR y es cambiado por ACTIVO
                            'significa que es contratado
                            If oldEstado = 4 And lueEstadoEmpleado.EditValue = 1 Then
                                movimiento = IIf(Len(movimiento) > 0, movimiento + ", Contratado", "Contratado")
                            Else
                                'Si el estado anterior del empleado es ACTIVO y es cambiado a POR ACTIVAR
                                'significa que es ingresado
                                If oldEstado = 1 And lueEstadoEmpleado.EditValue = 4 Then
                                    movimiento = IIf(Len(movimiento) > 0, movimiento + ", Ingresado", "Ingresado")
                                Else
                                    movimiento = IIf(Len(movimiento) > 0, movimiento + ", Cambio Estado Empleado", "Cambio Estado Empleado")
                                End If
                            End If
                            empleado.Actualizar()
                        End If
                        If asignaCampos() Then
                            'Se crea el nuevo registro con el estado ACTIVO
                            empleado.datosLaborales.estadoRegistro = Comun.TiposDeDatos.EstadoRegistro.ACTIVO
                            empleado.datosLaborales.estadoEmpleadoID = empleado.estadoEmpleadoID
                            empleado.datosLaborales.periodoID = parametroMensual.ID
                            empleado.datosLaborales.periodoIDCambioSituacionLaboral = parametroMensual.ID
                            empleado.datosLaborales.antecedenteLaboralID = 0
                            If empleado.datosLaborales.diasGrado > 0 Then
                                empleado.datosLaborales.diasGrado = diasMes - empleado.datosLaborales.diasGrado
                            End If
                            'Genera los montos para las asignaciones, según calidad juridica, grado y clasificación
                            'del empleado con tipo proceso I (inactivo), cuando se realice el cierre de mes 
                            'debe ser cambiado a origen 2 y tipo proceso a N (normal)
                            If chkCalidadJuridica.Checked Then
                                'Aplica aquellos empleado que eran PLANTA/CONTRATA y pasan a HONORARIOS
                                If oldCalidadJuridica <> Comun.TiposDeDatos.TipoCalidadJuridica.HONORARIOS And newCalidadJuridida = Comun.TiposDeDatos.TipoCalidadJuridica.HONORARIOS Then
                                    empleado.datosRemuneracion.rentaBase = 0
                                    empleado.datosRemuneracion.sueldoBase = 0
                                    empleado.datosRemuneracion.valorAsignacionProfesional = 0
                                    empleado.datosRemuneracion.valorAsignacionResposabilidad = 0
                                    empleado.datosRemuneracion.valorAsignacionLey19185Art18 = 0
                                    empleado.datosRemuneracion.valorFuncionCritica = 0
                                    empleado.datosRemuneracion.valorGastoRepresentacion = 0
                                    empleado.datosRemuneracion.valorAsignacionLey18717 = 0
                                    empleado.datosRemuneracion.valorAsignacionLey18675Art10 = 0
                                    empleado.datosRemuneracion.valorAsignacionLey18675Art11 = 0
                                    empleado.datosRemuneracion.valorAsignacionLey18566 = 0
                                    empleado.datosRemuneracion.valorLey3551 = 0
                                    empleado.datosRemuneracion.valorIncrementoPrevisionalDL3501 = 0
                                    empleado.datosRemuneracion.numeroBienios = 0
                                    empleado.datosRemuneracion.periodo = parametroMensual.ID
                                    tipoProcesoRemun = "H"
                                Else
                                    'Aplica aquellos empleado que eran HONORARIOS y pasan PLANTA/CONTRATA
                                    If oldCalidadJuridica = Comun.TiposDeDatos.TipoCalidadJuridica.HONORARIOS And (newCalidadJuridida = Comun.TiposDeDatos.TipoCalidadJuridica.PLANTA Or newCalidadJuridida = Comun.TiposDeDatos.TipoCalidadJuridica.CONTRATA) Then
                                        empleado.datosRemuneracion.rentaBase = 0
                                        empleado.datosRemuneracion.periodo = parametroMensual.ID
                                        tipoProcesoRemun = "N"
                                    End If
                                End If
                            Else
                                If oldCalidadJuridica = Comun.TiposDeDatos.TipoCalidadJuridica.HONORARIOS Then
                                    tipoProcesoRemun = "H"
                                Else
                                    tipoProcesoRemun = "N"
                                End If
                            End If

                            If empleado.datosLaborales.diasGrado > 0 Then
                                generaMontosAsignaciones(Comun.TiposDeDatos.TipoOrigenItem.CAMBIO_GRADO_PORPORCIONAL, "I", tipoProcesoRemun)
                            Else
                                generaMontosAsignaciones(Comun.TiposDeDatos.TipoOrigenItem.FICHA_EMPLEADO, "N", tipoProcesoRemun)
                            End If
                            'Crea registro empleado con nuevo valores
                            empleado.CrearEmpleadoLaboral()
                            Try
                                'Actualizar montos en registro de remuneración
                                empleado.actualizarDatosRemun(empleado.datosRemuneracion)
                                If empleado.datosLaborales.diasGrado > 0 Then
                                    empleado = New empleado(CType(gleRut.EditValue, Integer))
                                    sumatoriaAsignaciones(empleado.datosLaborales.diasGrado)
                                    generaItemsCambioGrado()
                                End If

                                empleado.ActualizaPeriodoMaestrosEmpleado(parametroMensual.ID, empleado.ID)
                                System.Windows.Forms.MessageBox.Show("Los datos han sido actualizados correctamente", "Siga", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                'MsgBox("Los datos han sido actualizados correctamente", MsgBoxStyle.Information)
                            Catch ex As Exception
                                MsgBox("Ha ocurrido un error al actualizar " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                            End Try
                            limpiarControles()
                        End If
                        'MsgBox("El registro fue creado satisfactoriamente", MsgBoxStyle.Information)
                    Catch ex As Exception
                        MsgBox("Ha ocurrido un error al crear el registro " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                End If
            End If
        End If
    End Sub
    Function asignaCampos() As Boolean
        Dim respuesta As Boolean = False
        If chkEstadoEmpleado.Checked Then
            respuesta = True
        End If
        If chkCalidadJuridica.Checked Then
            empleado.datosLaborales.calidadJuridicaID = lueCalidadJuridica.EditValue
            empleado.datosLaborales.fechaIngresoCalidadJuridica = dteFechaCalidadJuridica.EditValue
            movimiento = IIf(Len(movimiento) > 0, movimiento + ", Cambio Calidad Jurídica", "Cambio Calidad Jurídica")
            respuesta = True
        End If
        If chkGrado.Checked Then
            empleado.datosLaborales.gradoID = lueGrado.EditValue
            empleado.datosLaborales.fechaIngresoGrado = dteFechaGrado.EditValue
            If dteFechaGrado.DateTime.Day > 1 Then
                empleado.datosLaborales.periodoIDCambioSituacionLaboral = parametroMensual.ID
            End If
            movimiento = IIf(Len(movimiento) > 0, movimiento + ", Cambio Grado", "Cambio Grado")
            respuesta = True
        End If
        If chkClasEmpleado.Checked Then
            empleado.datosLaborales.clasificacionEmpleadoID = lueClasEmpleado.EditValue
            empleado.datosLaborales.fechaIngresoEstamento = dteFechaClasifEmpleado.EditValue
            empleado.datosLaborales.estamentoID = lueEstamento.EditValue
            movimiento = IIf(Len(movimiento) > 0, movimiento + ", Cambio Clasif.Empleado", "Cambio Clasif.Empleado")
            respuesta = True
        End If
        If chkEscalafon.Checked Then
            empleado.datosLaborales.escalafonID = lueEscalafon.EditValue
            empleado.datosLaborales.fechaIngresoEscalafon = dteFechaEscalafon.EditValue
            movimiento = IIf(Len(movimiento) > 0, movimiento + ", Cambio Escalafón", "Cambio Escalafón")
            respuesta = True
        End If
        
        empleado.datosLaborales.observacion = txtObservaciones.Text
        empleado.datosLaborales.resolucionContrato = txtResolucion.Text
        empleado.datosLaborales.descripcionMovimiento = movimiento
        empleado.datosLaborales.fechaMovimiento = Date.Today
        Return respuesta
    End Function
    Function validarChecks() As Boolean
        Dim respuesta As Boolean = True
        If chkEstadoEmpleado.Checked Then
            If lueEstadoEmpleado.EditValue = Nothing Then
                lueEstadoEmpleado.ErrorText = "Falta seleccionar estado empleado"
                respuesta = False
            Else
                If empleado.estadoEmpleadoID = lueEstadoEmpleado.EditValue Then
                    lueEstadoEmpleado.ErrorText = "El nuevo estado empleado es igual a la situación actual, registro no será grabado"
                    respuesta = False
                End If
            End If
        End If
        If chkCalidadJuridica.Checked Then
            If lueCalidadJuridica.EditValue = Nothing Then
                lueCalidadJuridica.ErrorText = "Falta seleccionar calidad jurídica"
                respuesta = False
            Else
                If empleado.datosLaborales.calidadJuridicaID = lueCalidadJuridica.EditValue Then
                    lueCalidadJuridica.ErrorText = "La nueva calidad jurídica es igual a la situación actual, registro no será grabado"
                    respuesta = False
                End If
            End If
            If dteFechaCalidadJuridica.EditValue Is Nothing Then
                dteFechaCalidadJuridica.ErrorText = "Falta indicar fecha de ingreso a la nueva calidad jurídica"
                respuesta = False
            End If
        End If
        If chkGrado.Checked Then
            If lueGrado.EditValue = Nothing Then
                lueGrado.ErrorText = "Falta seleccionar grado"
                respuesta = False
            Else
                If empleado.datosLaborales.gradoID = lueGrado.EditValue Then
                    lueGrado.ErrorText = "El nuevo grado es igual a la situación actual, registro no será grabado"
                    respuesta = False
                End If
            End If
            If dteFechaGrado.EditValue Is Nothing Then
                dteFechaGrado.ErrorText = "Falta indicar fecha de ingreso al nuevo grado"
                respuesta = False
            End If
        End If
        If chkClasEmpleado.Checked Then
            If lueClasEmpleado.EditValue = Nothing Then
                lueClasEmpleado.ErrorText = "Falta seleccionar clasificación empleado"
                respuesta = False
            Else
                If empleado.datosLaborales.clasificacionEmpleadoID = lueClasEmpleado.EditValue Then
                    lueClasEmpleado.ErrorText = "La nueva clasificación empleado es igual a la situación actual, registro no será grabado"
                    respuesta = False
                End If
            End If
            If dteFechaClasifEmpleado.EditValue Is Nothing Then
                dteFechaClasifEmpleado.ErrorText = "Falta indicar fecha de ingreso a la nueva clasificación del empleado"
                respuesta = False
            End If
            If lueEstamento.EditValue Is Nothing Then
                lueEstamento.ErrorText = "Falta indicar estamento"
                respuesta = False
            End If
        End If
        If chkEscalafon.Checked Then
            If lueEscalafon.EditValue = Nothing Then
                lueEscalafon.ErrorText = "Falta seleccionar escalafón"
                respuesta = False
            Else
                If empleado.datosLaborales.escalafonID = lueEscalafon.EditValue Then
                    lueEscalafon.ErrorText = "El nuevo escalafón es igual a la situación actual, registro no será grabado"
                    respuesta = False
                End If
            End If
            If dteFechaEscalafon.EditValue Is Nothing Then
                dteFechaEscalafon.ErrorText = "Falta indicar fecha de ingreso al nuevo escalafón"
                respuesta = False
            End If
        End If
        Return respuesta
    End Function
    Private Sub generaMontosAsignaciones(ByVal origen As Integer, ByVal tipoProceso As String, ByVal procesoRemun As String)
        Dim idCalJuridica, idGrado, idClasEmpleado, idAfp, idIsapre, numBienios As Integer

        idCalJuridica = empleado.datosLaborales.calidadJuridicaID
        idGrado = empleado.datosLaborales.gradoID
        idClasEmpleado = empleado.datosLaborales.clasificacionEmpleadoID
        idAfp = empleado.datosPrevisionales.institucionID
        idIsapre = empleado.datosSalud.institucionID
        numBienios = empleado.datosRemuneracion.numeroBienios
        'Genera los montos para las asignaciones
        empleado.recuperarDatosEUSEmpleado(empleado, idCalJuridica, idGrado, _
                                              idClasEmpleado, numBienios, idAfp, idIsapre, parametroMensual)
        'Crea los movimientos mensual para asignación
        empleado.EliminarMovimientoMensualEmpleado(parametroMensual.ID, CType(empleado.ID, Integer), Comun.TiposDeDatos.TipoOrigenItem.FICHA_EMPLEADO, procesoRemun)
        empleado.CrearItemEmpleado(empleado, parametroMensual, origen, tipoProceso)

    End Sub
    Private Sub limpiarControles()
        txtDV.Text = ""
        gleRut.EditValue = Nothing
        gleRut.Text = ""
        txtNombres.Text = ""
        txtFechaIngresoInstitucion.Text = ""
        txtFechaIngAdmPublica.Text = ""
        txtEstadoEmpleado.Text = ""
        txtCalidadJuridica.Text = ""
        txtGrado.Text = ""
        txtEstamento.Text = ""
        txtEscalafon.Text = ""
        txtDepartamento.Text = ""
        txtClasificacionEmpleado.Text = ""
        txtFechaIngCalidadJuridica.Text = ""
        txtFechaIngGrado.Text = ""
        txtFechaIngEstamento.Text = ""
        txtFechaIngEscalafon.Text = ""
        txtFechaIngDepto.Text = ""
        txtPeriodo.Text = ""
        lueEstadoEmpleado.EditValue = Nothing
        lueCalidadJuridica.EditValue = Nothing
        lueGrado.EditValue = Nothing
        lueClasEmpleado.EditValue = Nothing
        lueEscalafon.EditValue = Nothing
        lueEstamento.EditValue = Nothing
        lueEstadoEmpleado.Properties.ReadOnly = True
        lueCalidadJuridica.Properties.ReadOnly = True
        lueGrado.Properties.ReadOnly = True
        lueClasEmpleado.Properties.ReadOnly = True
        lueEscalafon.Properties.ReadOnly = True
        lueEstamento.Properties.ReadOnly = True
        'dteFechaCalidadJuridica.DateTime.ToString()
        dteFechaCalidadJuridica.Properties.NullDate = DBNull.Value
        'dteFechaGrado.DateTime.ToString()
        dteFechaGrado.Properties.NullDate = DBNull.Value
        'dteFechaClasifEmpleado.DateTime.ToString()
        dteFechaClasifEmpleado.Properties.NullDate = DBNull.Value
        'dteFechaEscalafon.DateTime.ToString()
        dteFechaEscalafon.Properties.NullDate = DBNull.Value
        'dteFechaDepto.DateTime.ToString()
        dteFechaCalidadJuridica.Properties.ReadOnly = True
        dteFechaGrado.Properties.ReadOnly = True
        dteFechaClasifEmpleado.Properties.ReadOnly = True
        dteFechaEscalafon.Properties.ReadOnly = True
        movimiento = ""
        chkEstadoEmpleado.Checked = False
        chkCalidadJuridica.Checked = False
        chkGrado.Checked = False
        chkClasEmpleado.Checked = False
        chkEscalafon.Checked = False

        habilitaCheckControl(False)
    End Sub
    Private Sub dteFechaGrado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dteFechaGrado.Validating
        If dteFechaGrado.EditValue <> Nothing Then
            If dteFechaGrado.EditValue <= empleado.datosLaborales.fechaIngresoGrado Then
                MsgBox("Nueva fecha ingreso al grado debe ser superior a la fecha actual del grado", MsgBoxStyle.Exclamation)
                e.Cancel = True
                dteFechaGrado.Focus()
            End If
        End If
    End Sub
    Private Sub inicializaAsignaciones()
        montoSueldoBase = 0
        montoAsignacionProfesional = 0
        montoAsignacionResposabilidad = 0
        montoAsignacionLey19185Art18 = 0
        montoGastoRepresentacion = 0
        montoFuncionCritica = 0
        montoAsignacionLey18717 = 0
        montoAsignacionLey18675Art10 = 0
        montoAsignacionLey18675Art11 = 0
        montoAsignacionLey18566 = 0
        montoLey3551 = 0
        montoIncrementoPrevisionalDL3551 = 0
    End Sub
    Private Sub sumatoriaAsignaciones(ByVal diasEnGrado As Integer)
        montoSueldoBase += Math.Round((empleado.datosRemuneracion.sueldoBase / diasMes) * diasEnGrado, 0)
        montoAsignacionProfesional += Math.Round((empleado.datosRemuneracion.valorAsignacionProfesional / diasMes) * diasEnGrado, 0)
        montoAsignacionResposabilidad += Math.Round((empleado.datosRemuneracion.valorAsignacionResposabilidad / diasMes) * diasEnGrado, 0)
        montoAsignacionLey19185Art18 += Math.Round((empleado.datosRemuneracion.valorAsignacionLey19185Art18 / diasMes) * diasEnGrado, 0)
        montoGastoRepresentacion += Math.Round((empleado.datosRemuneracion.valorGastoRepresentacion / diasMes) * diasEnGrado, 0)
        montoFuncionCritica += Math.Round((empleado.datosRemuneracion.valorFuncionCritica / diasMes) * diasEnGrado, 0)
        montoAsignacionLey18717 += Math.Round((empleado.datosRemuneracion.valorAsignacionLey18717 / diasMes) * diasEnGrado, 0)
        montoAsignacionLey18675Art10 += Math.Round((empleado.datosRemuneracion.valorAsignacionLey18675Art10 / diasMes) * diasEnGrado, 0)
        montoAsignacionLey18675Art11 += Math.Round((empleado.datosRemuneracion.valorAsignacionLey18675Art11 / diasMes) * diasEnGrado, 0)
        montoAsignacionLey18566 += Math.Round((empleado.datosRemuneracion.valorAsignacionLey18566 / diasMes) * diasEnGrado, 0)
        montoLey3551 += Math.Round((empleado.datosRemuneracion.valorLey3551 / diasMes) * diasEnGrado, 0)
        montoIncrementoPrevisionalDL3551 += Math.Round((empleado.datosRemuneracion.valorIncrementoPrevisionalDL3501 / diasMes) * diasEnGrado, 0)
    End Sub
    Private Sub generaItemsCambioGrado()
        empleado.datosRemuneracion.sueldoBase = montoSueldoBase
        empleado.datosRemuneracion.valorAsignacionProfesional = montoAsignacionProfesional
        empleado.datosRemuneracion.valorAsignacionResposabilidad = montoAsignacionResposabilidad
        empleado.datosRemuneracion.valorAsignacionLey19185Art18 = montoAsignacionLey19185Art18
        empleado.datosRemuneracion.valorGastoRepresentacion = montoGastoRepresentacion
        empleado.datosRemuneracion.valorFuncionCritica = montoFuncionCritica
        empleado.datosRemuneracion.valorAsignacionLey18717 = montoAsignacionLey18717
        empleado.datosRemuneracion.valorAsignacionLey18675Art10 = montoAsignacionLey18675Art10
        empleado.datosRemuneracion.valorAsignacionLey18675Art11 = montoAsignacionLey18675Art11
        empleado.datosRemuneracion.valorAsignacionLey18566 = montoAsignacionLey18566
        empleado.datosRemuneracion.valorLey3551 = montoLey3551
        empleado.datosRemuneracion.valorIncrementoPrevisionalDL3501 = montoIncrementoPrevisionalDL3551
        'empleado.datosRemuneracion.periodo = parametroMensual.ID
        Try
            'Actualizar montos en registro de remuneración
            empleado.actualizarDatosRemun(empleado.datosRemuneracion)
            'Crea los movimientos mensual para asignación
            empleado.CrearItemEmpleado(empleado, parametroMensual, 2, "C")
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al crear items cambio de grado " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub dteFechaClasifEmpleado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dteFechaClasifEmpleado.Validating
        If dteFechaClasifEmpleado.EditValue <> Nothing Then
            If dteFechaClasifEmpleado.EditValue <= empleado.datosLaborales.fechaIngresoEstamento Then
                MsgBox("Nueva fecha ingreso clasificación empleado debe ser superior a la clasificación actual", MsgBoxStyle.Exclamation)
                e.Cancel = True
                dteFechaGrado.Focus()
            End If
        End If

    End Sub
End Class
