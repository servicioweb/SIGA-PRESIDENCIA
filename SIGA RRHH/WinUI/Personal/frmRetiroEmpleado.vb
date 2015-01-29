Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmRetiroEmpleado
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
    Friend WithEvents gpcSituacionActual As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblClasifEmpleado As System.Windows.Forms.Label
    Friend WithEvents txtFechaIngDepto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaIngEscalafon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaIngEstamento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaIngGrado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaIngCalidadJuridica As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFechaIngDepartamento As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngEscalafon As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngEstamento As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngGrado As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngCalidadJuridica As System.Windows.Forms.Label
    Friend WithEvents txtDepartamento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEscalafon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEstamento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGrado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDepto As System.Windows.Forms.Label
    Friend WithEvents lblEscalafon As System.Windows.Forms.Label
    Friend WithEvents lblEstamento As System.Windows.Forms.Label
    Friend WithEvents lblGrado As System.Windows.Forms.Label
    Friend WithEvents txtCalidadJuridica As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCalidadJuridica As System.Windows.Forms.Label
    Friend WithEvents gpcNombreEmpleado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtFechaIngAdmPublica As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblfechaIngAdminPublica As System.Windows.Forms.Label
    Friend WithEvents txtFechaIngresoInstitucion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblIngresoInstitucion As System.Windows.Forms.Label
    Friend WithEvents lblRut As System.Windows.Forms.Label
    Friend WithEvents txtNombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gleRut As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gleRutGrid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gpcDatosMotivoRetiro As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dedFechaRetiro As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblMotivoRetiro As System.Windows.Forms.Label
    Friend WithEvents lblFechaRetiro As System.Windows.Forms.Label
    Friend WithEvents lblResolucion As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lueMotivoRetiro As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtResolucionRetiro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMotivoRetiro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaRetiro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMotivoRetiroSituacionActual As System.Windows.Forms.Label
    Friend WithEvents lblFechaRetiroSituacionActual As System.Windows.Forms.Label
    Friend WithEvents txtClasificacionEmpleado As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpcSituacionActual = New DevExpress.XtraEditors.GroupControl
        Me.txtClasificacionEmpleado = New DevExpress.XtraEditors.TextEdit
        Me.txtFechaRetiro = New DevExpress.XtraEditors.TextEdit
        Me.lblFechaRetiroSituacionActual = New System.Windows.Forms.Label
        Me.txtMotivoRetiro = New DevExpress.XtraEditors.TextEdit
        Me.lblMotivoRetiroSituacionActual = New System.Windows.Forms.Label
        Me.lblClasifEmpleado = New System.Windows.Forms.Label
        Me.txtFechaIngDepto = New DevExpress.XtraEditors.TextEdit
        Me.txtFechaIngEscalafon = New DevExpress.XtraEditors.TextEdit
        Me.txtFechaIngEstamento = New DevExpress.XtraEditors.TextEdit
        Me.txtFechaIngGrado = New DevExpress.XtraEditors.TextEdit
        Me.txtFechaIngCalidadJuridica = New DevExpress.XtraEditors.TextEdit
        Me.lblFechaIngDepartamento = New System.Windows.Forms.Label
        Me.lblFechaIngEscalafon = New System.Windows.Forms.Label
        Me.lblFechaIngEstamento = New System.Windows.Forms.Label
        Me.lblFechaIngGrado = New System.Windows.Forms.Label
        Me.lblFechaIngCalidadJuridica = New System.Windows.Forms.Label
        Me.txtDepartamento = New DevExpress.XtraEditors.TextEdit
        Me.txtEscalafon = New DevExpress.XtraEditors.TextEdit
        Me.txtEstamento = New DevExpress.XtraEditors.TextEdit
        Me.txtGrado = New DevExpress.XtraEditors.TextEdit
        Me.lblDepto = New System.Windows.Forms.Label
        Me.lblEscalafon = New System.Windows.Forms.Label
        Me.lblEstamento = New System.Windows.Forms.Label
        Me.lblGrado = New System.Windows.Forms.Label
        Me.txtCalidadJuridica = New DevExpress.XtraEditors.TextEdit
        Me.lblCalidadJuridica = New System.Windows.Forms.Label
        Me.gpcNombreEmpleado = New DevExpress.XtraEditors.GroupControl
        Me.gleRut = New DevExpress.XtraEditors.GridLookUpEdit
        Me.gleRutGrid = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.txtFechaIngAdmPublica = New DevExpress.XtraEditors.TextEdit
        Me.lblfechaIngAdminPublica = New System.Windows.Forms.Label
        Me.txtFechaIngresoInstitucion = New DevExpress.XtraEditors.TextEdit
        Me.lblIngresoInstitucion = New System.Windows.Forms.Label
        Me.lblRut = New System.Windows.Forms.Label
        Me.txtNombres = New DevExpress.XtraEditors.TextEdit
        Me.gpcDatosMotivoRetiro = New DevExpress.XtraEditors.GroupControl
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.lblObservaciones = New System.Windows.Forms.Label
        Me.txtObservaciones = New DevExpress.XtraEditors.TextEdit
        Me.lblResolucion = New System.Windows.Forms.Label
        Me.txtResolucionRetiro = New DevExpress.XtraEditors.TextEdit
        Me.lueMotivoRetiro = New DevExpress.XtraEditors.LookUpEdit
        Me.dedFechaRetiro = New DevExpress.XtraEditors.DateEdit
        Me.lblMotivoRetiro = New System.Windows.Forms.Label
        Me.lblFechaRetiro = New System.Windows.Forms.Label
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.gpcSituacionActual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSituacionActual.SuspendLayout()
        CType(Me.txtClasificacionEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaRetiro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMotivoRetiro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.gpcNombreEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcNombreEmpleado.SuspendLayout()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleRutGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIngAdmPublica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIngresoInstitucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDatosMotivoRetiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDatosMotivoRetiro.SuspendLayout()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResolucionRetiro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueMotivoRetiro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaRetiro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcSituacionActual
        '
        Me.gpcSituacionActual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSituacionActual.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSituacionActual.AppearanceCaption.Options.UseFont = True
        Me.gpcSituacionActual.Controls.Add(Me.txtClasificacionEmpleado)
        Me.gpcSituacionActual.Controls.Add(Me.txtFechaRetiro)
        Me.gpcSituacionActual.Controls.Add(Me.lblFechaRetiroSituacionActual)
        Me.gpcSituacionActual.Controls.Add(Me.txtMotivoRetiro)
        Me.gpcSituacionActual.Controls.Add(Me.lblMotivoRetiroSituacionActual)
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
        Me.gpcSituacionActual.Controls.Add(Me.lblCalidadJuridica)
        Me.gpcSituacionActual.Location = New System.Drawing.Point(8, 88)
        Me.gpcSituacionActual.Name = "gpcSituacionActual"
        Me.gpcSituacionActual.Size = New System.Drawing.Size(760, 216)
        Me.gpcSituacionActual.TabIndex = 67
        Me.gpcSituacionActual.Text = "Situación Actual"
        '
        'txtClasificacionEmpleado
        '
        Me.txtClasificacionEmpleado.Enabled = False
        Me.txtClasificacionEmpleado.Location = New System.Drawing.Point(144, 152)
        Me.txtClasificacionEmpleado.Name = "txtClasificacionEmpleado"
        '
        'txtClasificacionEmpleado.Properties
        '
        Me.txtClasificacionEmpleado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtClasificacionEmpleado.Properties.Appearance.Options.UseFont = True
        Me.txtClasificacionEmpleado.Properties.ReadOnly = True
        Me.txtClasificacionEmpleado.Size = New System.Drawing.Size(232, 20)
        Me.txtClasificacionEmpleado.TabIndex = 37
        '
        'txtFechaRetiro
        '
        Me.txtFechaRetiro.Enabled = False
        Me.txtFechaRetiro.Location = New System.Drawing.Point(576, 176)
        Me.txtFechaRetiro.Name = "txtFechaRetiro"
        '
        'txtFechaRetiro.Properties
        '
        Me.txtFechaRetiro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtFechaRetiro.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtFechaRetiro.Properties.Appearance.Options.UseFont = True
        Me.txtFechaRetiro.Properties.Appearance.Options.UseForeColor = True
        Me.txtFechaRetiro.Properties.ReadOnly = True
        Me.txtFechaRetiro.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaRetiro.TabIndex = 36
        '
        'lblFechaRetiroSituacionActual
        '
        Me.lblFechaRetiroSituacionActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaRetiroSituacionActual.ForeColor = System.Drawing.Color.Red
        Me.lblFechaRetiroSituacionActual.Location = New System.Drawing.Point(416, 176)
        Me.lblFechaRetiroSituacionActual.Name = "lblFechaRetiroSituacionActual"
        Me.lblFechaRetiroSituacionActual.Size = New System.Drawing.Size(152, 16)
        Me.lblFechaRetiroSituacionActual.TabIndex = 35
        Me.lblFechaRetiroSituacionActual.Text = "Fecha Retiro"
        Me.lblFechaRetiroSituacionActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMotivoRetiro
        '
        Me.txtMotivoRetiro.Enabled = False
        Me.txtMotivoRetiro.Location = New System.Drawing.Point(144, 176)
        Me.txtMotivoRetiro.Name = "txtMotivoRetiro"
        '
        'txtMotivoRetiro.Properties
        '
        Me.txtMotivoRetiro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMotivoRetiro.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtMotivoRetiro.Properties.Appearance.Options.UseFont = True
        Me.txtMotivoRetiro.Properties.Appearance.Options.UseForeColor = True
        Me.txtMotivoRetiro.Properties.ReadOnly = True
        Me.txtMotivoRetiro.Size = New System.Drawing.Size(232, 20)
        Me.txtMotivoRetiro.TabIndex = 34
        '
        'lblMotivoRetiroSituacionActual
        '
        Me.lblMotivoRetiroSituacionActual.BackColor = System.Drawing.Color.Transparent
        Me.lblMotivoRetiroSituacionActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivoRetiroSituacionActual.ForeColor = System.Drawing.Color.Red
        Me.lblMotivoRetiroSituacionActual.Location = New System.Drawing.Point(48, 180)
        Me.lblMotivoRetiroSituacionActual.Name = "lblMotivoRetiroSituacionActual"
        Me.lblMotivoRetiroSituacionActual.Size = New System.Drawing.Size(88, 16)
        Me.lblMotivoRetiroSituacionActual.TabIndex = 33
        Me.lblMotivoRetiroSituacionActual.Text = "Motivo Retiro"
        Me.lblMotivoRetiroSituacionActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblClasifEmpleado
        '
        Me.lblClasifEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClasifEmpleado.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblClasifEmpleado.Location = New System.Drawing.Point(0, 152)
        Me.lblClasifEmpleado.Name = "lblClasifEmpleado"
        Me.lblClasifEmpleado.Size = New System.Drawing.Size(136, 16)
        Me.lblClasifEmpleado.TabIndex = 31
        Me.lblClasifEmpleado.Text = "Clasificación Empleado"
        Me.lblClasifEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFechaIngDepto
        '
        Me.txtFechaIngDepto.Enabled = False
        Me.txtFechaIngDepto.Location = New System.Drawing.Point(576, 128)
        Me.txtFechaIngDepto.Name = "txtFechaIngDepto"
        '
        'txtFechaIngDepto.Properties
        '
        Me.txtFechaIngDepto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtFechaIngDepto.Properties.Appearance.Options.UseFont = True
        Me.txtFechaIngDepto.Properties.ReadOnly = True
        Me.txtFechaIngDepto.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaIngDepto.TabIndex = 30
        '
        'txtFechaIngEscalafon
        '
        Me.txtFechaIngEscalafon.Enabled = False
        Me.txtFechaIngEscalafon.Location = New System.Drawing.Point(576, 104)
        Me.txtFechaIngEscalafon.Name = "txtFechaIngEscalafon"
        '
        'txtFechaIngEscalafon.Properties
        '
        Me.txtFechaIngEscalafon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtFechaIngEscalafon.Properties.Appearance.Options.UseFont = True
        Me.txtFechaIngEscalafon.Properties.ReadOnly = True
        Me.txtFechaIngEscalafon.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaIngEscalafon.TabIndex = 28
        '
        'txtFechaIngEstamento
        '
        Me.txtFechaIngEstamento.Enabled = False
        Me.txtFechaIngEstamento.Location = New System.Drawing.Point(576, 80)
        Me.txtFechaIngEstamento.Name = "txtFechaIngEstamento"
        '
        'txtFechaIngEstamento.Properties
        '
        Me.txtFechaIngEstamento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtFechaIngEstamento.Properties.Appearance.Options.UseFont = True
        Me.txtFechaIngEstamento.Properties.ReadOnly = True
        Me.txtFechaIngEstamento.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaIngEstamento.TabIndex = 26
        '
        'txtFechaIngGrado
        '
        Me.txtFechaIngGrado.Enabled = False
        Me.txtFechaIngGrado.Location = New System.Drawing.Point(576, 56)
        Me.txtFechaIngGrado.Name = "txtFechaIngGrado"
        '
        'txtFechaIngGrado.Properties
        '
        Me.txtFechaIngGrado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtFechaIngGrado.Properties.Appearance.Options.UseFont = True
        Me.txtFechaIngGrado.Properties.ReadOnly = True
        Me.txtFechaIngGrado.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaIngGrado.TabIndex = 24
        '
        'txtFechaIngCalidadJuridica
        '
        Me.txtFechaIngCalidadJuridica.Enabled = False
        Me.txtFechaIngCalidadJuridica.Location = New System.Drawing.Point(576, 32)
        Me.txtFechaIngCalidadJuridica.Name = "txtFechaIngCalidadJuridica"
        '
        'txtFechaIngCalidadJuridica.Properties
        '
        Me.txtFechaIngCalidadJuridica.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtFechaIngCalidadJuridica.Properties.Appearance.Options.UseFont = True
        Me.txtFechaIngCalidadJuridica.Properties.ReadOnly = True
        Me.txtFechaIngCalidadJuridica.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaIngCalidadJuridica.TabIndex = 22
        '
        'lblFechaIngDepartamento
        '
        Me.lblFechaIngDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngDepartamento.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblFechaIngDepartamento.Location = New System.Drawing.Point(416, 128)
        Me.lblFechaIngDepartamento.Name = "lblFechaIngDepartamento"
        Me.lblFechaIngDepartamento.Size = New System.Drawing.Size(152, 16)
        Me.lblFechaIngDepartamento.TabIndex = 29
        Me.lblFechaIngDepartamento.Text = "Fecha Ing.Departamento"
        Me.lblFechaIngDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaIngEscalafon
        '
        Me.lblFechaIngEscalafon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngEscalafon.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblFechaIngEscalafon.Location = New System.Drawing.Point(448, 104)
        Me.lblFechaIngEscalafon.Name = "lblFechaIngEscalafon"
        Me.lblFechaIngEscalafon.Size = New System.Drawing.Size(120, 16)
        Me.lblFechaIngEscalafon.TabIndex = 27
        Me.lblFechaIngEscalafon.Text = "Fecha Ing.Escalafón"
        Me.lblFechaIngEscalafon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaIngEstamento
        '
        Me.lblFechaIngEstamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngEstamento.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblFechaIngEstamento.Location = New System.Drawing.Point(424, 80)
        Me.lblFechaIngEstamento.Name = "lblFechaIngEstamento"
        Me.lblFechaIngEstamento.Size = New System.Drawing.Size(144, 16)
        Me.lblFechaIngEstamento.TabIndex = 25
        Me.lblFechaIngEstamento.Text = "Fecha Ing.Estamento"
        Me.lblFechaIngEstamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaIngGrado
        '
        Me.lblFechaIngGrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngGrado.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblFechaIngGrado.Location = New System.Drawing.Point(456, 56)
        Me.lblFechaIngGrado.Name = "lblFechaIngGrado"
        Me.lblFechaIngGrado.Size = New System.Drawing.Size(112, 16)
        Me.lblFechaIngGrado.TabIndex = 23
        Me.lblFechaIngGrado.Text = "Fecha Ing.Grado"
        Me.lblFechaIngGrado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaIngCalidadJuridica
        '
        Me.lblFechaIngCalidadJuridica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngCalidadJuridica.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblFechaIngCalidadJuridica.Location = New System.Drawing.Point(408, 32)
        Me.lblFechaIngCalidadJuridica.Name = "lblFechaIngCalidadJuridica"
        Me.lblFechaIngCalidadJuridica.Size = New System.Drawing.Size(160, 16)
        Me.lblFechaIngCalidadJuridica.TabIndex = 21
        Me.lblFechaIngCalidadJuridica.Text = "Fecha Ing.Calidad Jurídica"
        Me.lblFechaIngCalidadJuridica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Enabled = False
        Me.txtDepartamento.Location = New System.Drawing.Point(144, 128)
        Me.txtDepartamento.Name = "txtDepartamento"
        '
        'txtDepartamento.Properties
        '
        Me.txtDepartamento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDepartamento.Properties.Appearance.Options.UseFont = True
        Me.txtDepartamento.Properties.ReadOnly = True
        Me.txtDepartamento.Size = New System.Drawing.Size(232, 20)
        Me.txtDepartamento.TabIndex = 20
        '
        'txtEscalafon
        '
        Me.txtEscalafon.Enabled = False
        Me.txtEscalafon.Location = New System.Drawing.Point(144, 104)
        Me.txtEscalafon.Name = "txtEscalafon"
        '
        'txtEscalafon.Properties
        '
        Me.txtEscalafon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtEscalafon.Properties.Appearance.Options.UseFont = True
        Me.txtEscalafon.Properties.ReadOnly = True
        Me.txtEscalafon.Size = New System.Drawing.Size(232, 20)
        Me.txtEscalafon.TabIndex = 18
        '
        'txtEstamento
        '
        Me.txtEstamento.Enabled = False
        Me.txtEstamento.Location = New System.Drawing.Point(144, 80)
        Me.txtEstamento.Name = "txtEstamento"
        '
        'txtEstamento.Properties
        '
        Me.txtEstamento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtEstamento.Properties.Appearance.Options.UseFont = True
        Me.txtEstamento.Properties.ReadOnly = True
        Me.txtEstamento.Size = New System.Drawing.Size(232, 20)
        Me.txtEstamento.TabIndex = 16
        '
        'txtGrado
        '
        Me.txtGrado.Enabled = False
        Me.txtGrado.Location = New System.Drawing.Point(144, 56)
        Me.txtGrado.Name = "txtGrado"
        '
        'txtGrado.Properties
        '
        Me.txtGrado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtGrado.Properties.Appearance.Options.UseFont = True
        Me.txtGrado.Properties.ReadOnly = True
        Me.txtGrado.Size = New System.Drawing.Size(232, 20)
        Me.txtGrado.TabIndex = 14
        '
        'lblDepto
        '
        Me.lblDepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepto.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblDepto.Location = New System.Drawing.Point(24, 128)
        Me.lblDepto.Name = "lblDepto"
        Me.lblDepto.Size = New System.Drawing.Size(112, 16)
        Me.lblDepto.TabIndex = 19
        Me.lblDepto.Text = "Departamento"
        Me.lblDepto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEscalafon
        '
        Me.lblEscalafon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEscalafon.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblEscalafon.Location = New System.Drawing.Point(24, 104)
        Me.lblEscalafon.Name = "lblEscalafon"
        Me.lblEscalafon.Size = New System.Drawing.Size(112, 16)
        Me.lblEscalafon.TabIndex = 17
        Me.lblEscalafon.Text = "Escalafón"
        Me.lblEscalafon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEstamento
        '
        Me.lblEstamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstamento.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblEstamento.Location = New System.Drawing.Point(24, 80)
        Me.lblEstamento.Name = "lblEstamento"
        Me.lblEstamento.Size = New System.Drawing.Size(112, 16)
        Me.lblEstamento.TabIndex = 15
        Me.lblEstamento.Text = "Estamento"
        Me.lblEstamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGrado
        '
        Me.lblGrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrado.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblGrado.Location = New System.Drawing.Point(24, 56)
        Me.lblGrado.Name = "lblGrado"
        Me.lblGrado.Size = New System.Drawing.Size(112, 16)
        Me.lblGrado.TabIndex = 13
        Me.lblGrado.Text = "Grado"
        Me.lblGrado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCalidadJuridica
        '
        Me.txtCalidadJuridica.Enabled = False
        Me.txtCalidadJuridica.Location = New System.Drawing.Point(144, 32)
        Me.txtCalidadJuridica.Name = "txtCalidadJuridica"
        '
        'txtCalidadJuridica.Properties
        '
        Me.txtCalidadJuridica.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCalidadJuridica.Properties.Appearance.Options.UseFont = True
        Me.txtCalidadJuridica.Properties.ReadOnly = True
        Me.txtCalidadJuridica.Size = New System.Drawing.Size(232, 20)
        Me.txtCalidadJuridica.TabIndex = 12
        '
        'lblCalidadJuridica
        '
        Me.lblCalidadJuridica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalidadJuridica.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblCalidadJuridica.Location = New System.Drawing.Point(24, 32)
        Me.lblCalidadJuridica.Name = "lblCalidadJuridica"
        Me.lblCalidadJuridica.Size = New System.Drawing.Size(112, 16)
        Me.lblCalidadJuridica.TabIndex = 11
        Me.lblCalidadJuridica.Text = "Calidad Jurídica"
        Me.lblCalidadJuridica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gpcNombreEmpleado
        '
        Me.gpcNombreEmpleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcNombreEmpleado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcNombreEmpleado.AppearanceCaption.Options.UseFont = True
        Me.gpcNombreEmpleado.Controls.Add(Me.gleRut)
        Me.gpcNombreEmpleado.Controls.Add(Me.txtFechaIngAdmPublica)
        Me.gpcNombreEmpleado.Controls.Add(Me.lblfechaIngAdminPublica)
        Me.gpcNombreEmpleado.Controls.Add(Me.txtFechaIngresoInstitucion)
        Me.gpcNombreEmpleado.Controls.Add(Me.lblIngresoInstitucion)
        Me.gpcNombreEmpleado.Controls.Add(Me.lblRut)
        Me.gpcNombreEmpleado.Controls.Add(Me.txtNombres)
        Me.gpcNombreEmpleado.Location = New System.Drawing.Point(8, 8)
        Me.gpcNombreEmpleado.Name = "gpcNombreEmpleado"
        Me.gpcNombreEmpleado.Size = New System.Drawing.Size(760, 80)
        Me.gpcNombreEmpleado.TabIndex = 66
        Me.gpcNombreEmpleado.Text = "Nombre Empleado"
        '
        'gleRut
        '
        Me.gleRut.Cursor = System.Windows.Forms.Cursors.Default
        Me.gleRut.EditValue = ""
        Me.gleRut.EnterMoveNextControl = True
        Me.gleRut.Location = New System.Drawing.Point(152, 24)
        Me.gleRut.Name = "gleRut"
        '
        'gleRut.Properties
        '
        Me.gleRut.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        Me.gleRut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleRut.Properties.HideSelection = False
        Me.gleRut.Properties.NullText = ""
        Me.gleRut.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.gleRut.Properties.ValidateOnEnterKey = True
        Me.gleRut.Properties.View = Me.gleRutGrid
        Me.gleRut.Size = New System.Drawing.Size(120, 20)
        Me.gleRut.TabIndex = 1
        '
        'gleRutGrid
        '
        Me.gleRutGrid.AppearancePrint.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.gleRutGrid.AppearancePrint.OddRow.BackColor2 = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.gleRutGrid.AppearancePrint.OddRow.Options.UseBackColor = True
        Me.gleRutGrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gleRutGrid.Name = "gleRutGrid"
        Me.gleRutGrid.OptionsBehavior.Editable = False
        Me.gleRutGrid.OptionsCustomization.AllowFilter = False
        Me.gleRutGrid.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gleRutGrid.OptionsView.ShowGroupPanel = False
        '
        'txtFechaIngAdmPublica
        '
        Me.txtFechaIngAdmPublica.Enabled = False
        Me.txtFechaIngAdmPublica.Location = New System.Drawing.Point(576, 48)
        Me.txtFechaIngAdmPublica.Name = "txtFechaIngAdmPublica"
        '
        'txtFechaIngAdmPublica.Properties
        '
        Me.txtFechaIngAdmPublica.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtFechaIngAdmPublica.Properties.Appearance.Options.UseFont = True
        Me.txtFechaIngAdmPublica.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaIngAdmPublica.TabIndex = 8
        '
        'lblfechaIngAdminPublica
        '
        Me.lblfechaIngAdminPublica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechaIngAdminPublica.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
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
        '
        'txtFechaIngresoInstitucion.Properties
        '
        Me.txtFechaIngresoInstitucion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtFechaIngresoInstitucion.Properties.Appearance.Options.UseFont = True
        Me.txtFechaIngresoInstitucion.Size = New System.Drawing.Size(120, 20)
        Me.txtFechaIngresoInstitucion.TabIndex = 6
        '
        'lblIngresoInstitucion
        '
        Me.lblIngresoInstitucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresoInstitucion.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblIngresoInstitucion.Location = New System.Drawing.Point(8, 52)
        Me.lblIngresoInstitucion.Name = "lblIngresoInstitucion"
        Me.lblIngresoInstitucion.Size = New System.Drawing.Size(128, 16)
        Me.lblIngresoInstitucion.TabIndex = 5
        Me.lblIngresoInstitucion.Text = "Ingreso a la Institución"
        Me.lblIngresoInstitucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRut
        '
        Me.lblRut.Location = New System.Drawing.Point(56, 32)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(80, 16)
        Me.lblRut.TabIndex = 0
        Me.lblRut.Text = "Rut Empleado"
        Me.lblRut.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(288, 24)
        Me.txtNombres.Name = "txtNombres"
        '
        'txtNombres.Properties
        '
        Me.txtNombres.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombres.Properties.MaxLength = 30
        Me.txtNombres.Properties.ReadOnly = True
        Me.txtNombres.Size = New System.Drawing.Size(392, 20)
        Me.txtNombres.TabIndex = 4
        '
        'gpcDatosMotivoRetiro
        '
        Me.gpcDatosMotivoRetiro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcDatosMotivoRetiro.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDatosMotivoRetiro.AppearanceCaption.Options.UseFont = True
        Me.gpcDatosMotivoRetiro.Controls.Add(Me.btnCancelar)
        Me.gpcDatosMotivoRetiro.Controls.Add(Me.lblObservaciones)
        Me.gpcDatosMotivoRetiro.Controls.Add(Me.txtObservaciones)
        Me.gpcDatosMotivoRetiro.Controls.Add(Me.lblResolucion)
        Me.gpcDatosMotivoRetiro.Controls.Add(Me.txtResolucionRetiro)
        Me.gpcDatosMotivoRetiro.Controls.Add(Me.lueMotivoRetiro)
        Me.gpcDatosMotivoRetiro.Controls.Add(Me.dedFechaRetiro)
        Me.gpcDatosMotivoRetiro.Controls.Add(Me.lblMotivoRetiro)
        Me.gpcDatosMotivoRetiro.Controls.Add(Me.lblFechaRetiro)
        Me.gpcDatosMotivoRetiro.Controls.Add(Me.btnGuardar)
        Me.gpcDatosMotivoRetiro.Location = New System.Drawing.Point(8, 304)
        Me.gpcDatosMotivoRetiro.Name = "gpcDatosMotivoRetiro"
        Me.gpcDatosMotivoRetiro.Size = New System.Drawing.Size(760, 208)
        Me.gpcDatosMotivoRetiro.TabIndex = 68
        Me.gpcDatosMotivoRetiro.Text = "Información Retiro Empleado"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(384, 160)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(104, 23)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "&Cancelar"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(24, 108)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(112, 16)
        Me.lblObservaciones.TabIndex = 88
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtObservaciones
        '
        Me.txtObservaciones.EnterMoveNextControl = True
        Me.txtObservaciones.Location = New System.Drawing.Point(144, 104)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(536, 20)
        Me.txtObservaciones.TabIndex = 13
        '
        'lblResolucion
        '
        Me.lblResolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResolucion.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblResolucion.Location = New System.Drawing.Point(56, 84)
        Me.lblResolucion.Name = "lblResolucion"
        Me.lblResolucion.Size = New System.Drawing.Size(72, 16)
        Me.lblResolucion.TabIndex = 85
        Me.lblResolucion.Text = "Resolución"
        Me.lblResolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtResolucionRetiro
        '
        Me.txtResolucionRetiro.EnterMoveNextControl = True
        Me.txtResolucionRetiro.Location = New System.Drawing.Point(144, 80)
        Me.txtResolucionRetiro.Name = "txtResolucionRetiro"
        Me.txtResolucionRetiro.Size = New System.Drawing.Size(208, 20)
        Me.txtResolucionRetiro.TabIndex = 12
        '
        'lueMotivoRetiro
        '
        Me.lueMotivoRetiro.EnterMoveNextControl = True
        Me.lueMotivoRetiro.Location = New System.Drawing.Point(144, 32)
        Me.lueMotivoRetiro.Name = "lueMotivoRetiro"
        '
        'lueMotivoRetiro.Properties
        '
        Me.lueMotivoRetiro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueMotivoRetiro.Properties.NullText = ""
        Me.lueMotivoRetiro.Size = New System.Drawing.Size(206, 20)
        Me.lueMotivoRetiro.TabIndex = 10
        '
        'dedFechaRetiro
        '
        Me.dedFechaRetiro.EditValue = Nothing
        Me.dedFechaRetiro.EnterMoveNextControl = True
        Me.dedFechaRetiro.Location = New System.Drawing.Point(144, 56)
        Me.dedFechaRetiro.Name = "dedFechaRetiro"
        '
        'dedFechaRetiro.Properties
        '
        Me.dedFechaRetiro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaRetiro.Size = New System.Drawing.Size(206, 20)
        Me.dedFechaRetiro.TabIndex = 11
        '
        'lblMotivoRetiro
        '
        Me.lblMotivoRetiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivoRetiro.Location = New System.Drawing.Point(56, 36)
        Me.lblMotivoRetiro.Name = "lblMotivoRetiro"
        Me.lblMotivoRetiro.Size = New System.Drawing.Size(80, 16)
        Me.lblMotivoRetiro.TabIndex = 82
        Me.lblMotivoRetiro.Text = "Motivo Retiro"
        '
        'lblFechaRetiro
        '
        Me.lblFechaRetiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaRetiro.Location = New System.Drawing.Point(56, 60)
        Me.lblFechaRetiro.Name = "lblFechaRetiro"
        Me.lblFechaRetiro.Size = New System.Drawing.Size(80, 16)
        Me.lblFechaRetiro.TabIndex = 81
        Me.lblFechaRetiro.Text = "Fecha Retiro"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(216, 160)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(104, 23)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        '
        'frmRetiroEmpleado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(776, 518)
        Me.Controls.Add(Me.gpcDatosMotivoRetiro)
        Me.Controls.Add(Me.gpcSituacionActual)
        Me.Controls.Add(Me.gpcNombreEmpleado)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmRetiroEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retiro de Empleado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcSituacionActual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSituacionActual.ResumeLayout(False)
        CType(Me.txtClasificacionEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaRetiro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMotivoRetiro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.gpcNombreEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcNombreEmpleado.ResumeLayout(False)
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleRutGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIngAdmPublica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIngresoInstitucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDatosMotivoRetiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatosMotivoRetiro.ResumeLayout(False)
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResolucionRetiro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueMotivoRetiro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaRetiro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim empleado As Empleado
    Dim parametroMensual As Periodo

    Private Sub frmRetiroEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        parametroMensual = New Periodo
        llenarRutEmpleado()
        llenarMotivoRetiro()
        deshabilitarControlesRetiro()
        deshabilitarRetiroSituacionActual()
    End Sub
    Public Sub llenarRutEmpleado()
        'gleRut.Properties.EditValueChangedFiringDelay = 1200
        Repository.RepositoryItem.EditValueChangedFiringDelay = 1200
        gleRut.Properties.EditValueChangedFiringMode = EditValueChangedFiringMode.Buffered
        gleRut.Properties.ViewType = Repository.GridLookUpViewType.GridView
        gleRut.Properties.View.OptionsBehavior.AutoPopulateColumns = False
        gleRut.Properties.DataSource = repositorio.dvEmpleadosActivosPlantaContrataHonorario
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

        gleRut.Properties.ValueMember = "EMPLEADO_ID"

        gleRut.Properties.View.BestFitColumns()
        gleRut.Properties.PopupFormWidth = 600

        gleRut.Text = ""
    End Sub
    Public Sub llenarMotivoRetiro()
        With lueMotivoRetiro
            With .Properties.Columns
                .Add(New LookUpColumnInfo("MOTIVO_RETIRO_ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueMotivoRetiro.Properties.DataSource = repositorio.dvMotivoRetiro
        lueMotivoRetiro.Properties.DisplayMember = "DESCRIPCION"
        lueMotivoRetiro.Properties.NullText = ""
        lueMotivoRetiro.Properties.PopupWidth = 200
        lueMotivoRetiro.Properties.ValueMember = "MOTIVO_RETIRO_ID"
    End Sub

    Private Sub gleRut_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gleRut.EditValueChanged
        Try
            If IsNumeric(gleRut.EditValue) Then
                empleado = New empleado(CType(gleRut.EditValue, Long))
                refrescarControles()
                inicializaControlesRetiro()
                habilitarControlesRetiro()
                If empleado.datosLaborales.motivoRetiroID > 0 Then
                    habilitarRetiroSituacionActual()
                Else
                    deshabilitarRetiroSituacionActual()
                End If
            End If
        Catch exp As Exception
            MessageBox.Show(exp.Message, "Cambio Estado Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub refrescarControles()
        txtNombres.Text = empleado.nombreCompleto
        txtFechaIngresoInstitucion.Text = empleado.datosLaborales.fechaIngresoInstitucion
        txtFechaIngAdmPublica.Text = empleado.datosLaborales.fechaIngresoAdministracionPublica
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
        If empleado.datosLaborales.motivoRetiroID > 0 Then
            txtMotivoRetiro.Text = DataAccess.Utiles.buscaID(Tablas.RH_PER_MOTIVO_RETIRO, "NN", "MOTIVO_RETIRO_ID", empleado.datosLaborales.motivoRetiroID, "DESCRIPCION")
            txtFechaRetiro.Text = empleado.datosLaborales.fechaRetiro
        End If
    End Sub
    Public Sub inicializaControles()
        txtNombres.Text = ""
        txtFechaIngresoInstitucion.Text = ""
        txtFechaIngAdmPublica.Text = ""
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
    End Sub
    Public Sub inicializaControlesRetiro()
        lueMotivoRetiro.EditValue = -1
        dedFechaRetiro.EditValue = Date.Today
        txtResolucionRetiro.Text = ""
        txtObservaciones.Text = ""
    End Sub
    Public Sub habilitarControlesRetiro()
        lueMotivoRetiro.Enabled = True
        dedFechaRetiro.Enabled = True
        txtResolucionRetiro.Enabled = True
        txtObservaciones.Enabled = True
    End Sub
    Public Sub habilitarRetiroSituacionActual()
        lblMotivoRetiroSituacionActual.Visible = True
        txtMotivoRetiro.Visible = True
        lblFechaRetiroSituacionActual.Visible = True
        txtFechaRetiro.Visible = True
    End Sub
    Public Sub deshabilitarControlesRetiro()
        lueMotivoRetiro.Enabled = False
        dedFechaRetiro.Enabled = False
        txtResolucionRetiro.Enabled = False
        txtObservaciones.Enabled = False
    End Sub
    Public Sub deshabilitarRetiroSituacionActual()
        lblMotivoRetiroSituacionActual.Visible = False
        txtMotivoRetiro.Visible = False
        lblFechaRetiroSituacionActual.Visible = False
        txtFechaRetiro.Visible = False
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If validaDatosRetiro() Then
            If MessageBox.Show("¿Está seguro que desea ejecutar el proceso de retiro?", "Siga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'Se actualiza el registro laboral vigente a INACTIVO
                empleado.datosLaborales.estadoRegistro = Comun.TiposDeDatos.EstadoRegistro.INACTIVO
                empleado.datosLaborales.motivoRetiroID = 0
                empleado.actualizarDatosLaboral(empleado.datosLaborales)

                'Se asignan los datos del retiro a empleado.datoslaborales y se crea un nuevo registro ACTIVO
                empleado.datosLaborales.estadoRegistro = Comun.TiposDeDatos.EstadoRegistro.ACTIVO
                empleado.datosLaborales.motivoRetiroID = lueMotivoRetiro.EditValue
                empleado.datosLaborales.fechaRetiro = dedFechaRetiro.EditValue
                empleado.datosLaborales.resolucionRetiro = txtResolucionRetiro.Text
                empleado.datosLaborales.observacion = txtObservaciones.Text
                empleado.datosLaborales.descripcionMovimiento = "En Proceso de Retiro"
                empleado.datosLaborales.fechaMovimiento = Date.Today
                empleado.datosLaborales.antecedenteLaboralID = 0
                Try
                    empleado.CrearEmpleadoLaboral()
                    System.Windows.Forms.MessageBox.Show("Los datos han sido actualizados correctamente", "Siga", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    inicializaControles()
                    inicializaControlesRetiro()
                    dedFechaRetiro.EditValue = ""
                    deshabilitarControlesRetiro()
                    deshabilitarRetiroSituacionActual()
                    empleado = New empleado
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al actualizar " & empleado.nombreCompleto & "." & Chr(13) & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
        End If
    End Sub
    Private Function validaDatosRetiro() As Boolean
        Dim respuesta As Boolean = True
        If lueMotivoRetiro.EditValue = Nothing Or CType(lueMotivoRetiro.EditValue, Integer) <= 0 Then
            lueMotivoRetiro.ErrorText = "Falta ingresar motivo de retiro"
            respuesta = False
        End If
        If dedFechaRetiro.EditValue = Nothing Then
            dedFechaRetiro.ErrorText = "Falta ingresar fecha de retiro"
            respuesta = False
        End If
        If dedFechaRetiro.EditValue < empleado.datosLaborales.fechaIngresoInstitucion Then
            dedFechaRetiro.ErrorText = "Fecha de retiro es anterior a fecha de ingreso a la institución"
            respuesta = False
        End If

        If txtResolucionRetiro.Text = Nothing Or txtResolucionRetiro.Text = "" Then
            txtResolucionRetiro.ErrorText = "Falta ingresar resolución"
            respuesta = False
        End If
        Return respuesta
    End Function
    Private Sub dedFechaRetiro_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dedFechaRetiro.Validating
        If dedFechaRetiro.EditValue <> Nothing And dedFechaRetiro.EditValue < empleado.datosLaborales.fechaIngresoInstitucion Then
            dedFechaRetiro.ErrorText = "Fecha de retiro es anterior a fecha de ingreso a la institución"
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub
End Class
