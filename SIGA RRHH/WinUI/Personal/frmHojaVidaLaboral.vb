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

Public Class frmHojaVidaLaboral
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
    Friend WithEvents lblfechaIngAdminPublica As System.Windows.Forms.Label
    Friend WithEvents gdcHojaVidaLaboral As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gdvDetalleHojaLaboral As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dvHojaVidaLaboral As System.Data.DataView
    Friend WithEvents DESCRIPCION_MOVIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ANTECEDENTE_LABORAL_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION_CALIDAD_JURIDICA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION_GRADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION_ESTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION_ESCALAFON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION_DEPTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_ING_CALIDAD_JURIDICA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_MOVIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_ING_GRADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_ING_ESTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_ING_ESCALAFON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_ING_DEPTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents prsHojaVidaLaboral As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHojaVidaLaboral))
        Me.txtDV = New DevExpress.XtraEditors.TextEdit()
        Me.gleRut = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gevRut = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gpcNombreEmpleado = New DevExpress.XtraEditors.GroupControl()
        Me.txtFechaIngAdmPublica = New DevExpress.XtraEditors.TextEdit()
        Me.lblfechaIngAdminPublica = New System.Windows.Forms.Label()
        Me.txtFechaIngresoInstitucion = New DevExpress.XtraEditors.TextEdit()
        Me.lblIngresoInstitucion = New System.Windows.Forms.Label()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.txtNombres = New DevExpress.XtraEditors.TextEdit()
        Me.gpcSituacionActual = New DevExpress.XtraEditors.GroupControl()
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton()
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
        Me.gdcHojaVidaLaboral = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleHojaLaboral = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ANTECEDENTE_LABORAL_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_MOVIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION_MOVIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION_CALIDAD_JURIDICA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION_GRADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION_ESTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION_ESCALAFON = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION_DEPTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_ING_CALIDAD_JURIDICA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_ING_GRADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_ING_ESTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_ING_ESCALAFON = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_ING_DEPTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dvHojaVidaLaboral = New System.Data.DataView()
        Me.prsHojaVidaLaboral = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.txtDV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gevRut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcNombreEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcNombreEmpleado.SuspendLayout()
        CType(Me.txtFechaIngAdmPublica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIngresoInstitucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcSituacionActual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSituacionActual.SuspendLayout()
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
        CType(Me.gdcHojaVidaLaboral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleHojaLaboral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvHojaVidaLaboral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prsHojaVidaLaboral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gpcNombreEmpleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcNombreEmpleado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcNombreEmpleado.AppearanceCaption.Options.UseFont = True
        Me.gpcNombreEmpleado.Controls.Add(Me.txtFechaIngAdmPublica)
        Me.gpcNombreEmpleado.Controls.Add(Me.lblfechaIngAdminPublica)
        Me.gpcNombreEmpleado.Controls.Add(Me.txtFechaIngresoInstitucion)
        Me.gpcNombreEmpleado.Controls.Add(Me.lblIngresoInstitucion)
        Me.gpcNombreEmpleado.Controls.Add(Me.lblRut)
        Me.gpcNombreEmpleado.Controls.Add(Me.txtNombres)
        Me.gpcNombreEmpleado.Controls.Add(Me.txtDV)
        Me.gpcNombreEmpleado.Location = New System.Drawing.Point(16, 8)
        Me.gpcNombreEmpleado.Name = "gpcNombreEmpleado"
        Me.gpcNombreEmpleado.Size = New System.Drawing.Size(760, 80)
        Me.gpcNombreEmpleado.TabIndex = 64
        Me.gpcNombreEmpleado.Text = "Nombre Empleado"
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
        Me.gpcSituacionActual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSituacionActual.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSituacionActual.AppearanceCaption.Options.UseFont = True
        Me.gpcSituacionActual.Controls.Add(Me.btnVisualizar)
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
        Me.gpcSituacionActual.Location = New System.Drawing.Point(16, 88)
        Me.gpcSituacionActual.Name = "gpcSituacionActual"
        Me.gpcSituacionActual.Size = New System.Drawing.Size(760, 216)
        Me.gpcSituacionActual.TabIndex = 65
        Me.gpcSituacionActual.Text = "Situación Actual"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(448, 32)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(232, 23)
        Me.btnVisualizar.TabIndex = 31
        Me.btnVisualizar.Text = "Visualizar"
        '
        'txtFechaIngDepto
        '
        Me.txtFechaIngDepto.Enabled = False
        Me.txtFechaIngDepto.Location = New System.Drawing.Point(576, 168)
        Me.txtFechaIngDepto.Name = "txtFechaIngDepto"
        Me.txtFechaIngDepto.Properties.ReadOnly = True
        Me.txtFechaIngDepto.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaIngDepto.TabIndex = 30
        '
        'txtFechaIngEscalafon
        '
        Me.txtFechaIngEscalafon.Enabled = False
        Me.txtFechaIngEscalafon.Location = New System.Drawing.Point(576, 144)
        Me.txtFechaIngEscalafon.Name = "txtFechaIngEscalafon"
        Me.txtFechaIngEscalafon.Properties.ReadOnly = True
        Me.txtFechaIngEscalafon.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaIngEscalafon.TabIndex = 28
        '
        'txtFechaIngEstamento
        '
        Me.txtFechaIngEstamento.Enabled = False
        Me.txtFechaIngEstamento.Location = New System.Drawing.Point(576, 120)
        Me.txtFechaIngEstamento.Name = "txtFechaIngEstamento"
        Me.txtFechaIngEstamento.Properties.ReadOnly = True
        Me.txtFechaIngEstamento.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaIngEstamento.TabIndex = 26
        '
        'txtFechaIngGrado
        '
        Me.txtFechaIngGrado.Enabled = False
        Me.txtFechaIngGrado.Location = New System.Drawing.Point(576, 96)
        Me.txtFechaIngGrado.Name = "txtFechaIngGrado"
        Me.txtFechaIngGrado.Properties.ReadOnly = True
        Me.txtFechaIngGrado.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaIngGrado.TabIndex = 24
        '
        'txtFechaIngCalidadJuridica
        '
        Me.txtFechaIngCalidadJuridica.Enabled = False
        Me.txtFechaIngCalidadJuridica.Location = New System.Drawing.Point(576, 72)
        Me.txtFechaIngCalidadJuridica.Name = "txtFechaIngCalidadJuridica"
        Me.txtFechaIngCalidadJuridica.Properties.ReadOnly = True
        Me.txtFechaIngCalidadJuridica.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaIngCalidadJuridica.TabIndex = 22
        '
        'lblFechaIngDepartamento
        '
        Me.lblFechaIngDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngDepartamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaIngDepartamento.Location = New System.Drawing.Point(416, 168)
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
        Me.lblFechaIngEscalafon.Location = New System.Drawing.Point(448, 144)
        Me.lblFechaIngEscalafon.Name = "lblFechaIngEscalafon"
        Me.lblFechaIngEscalafon.Size = New System.Drawing.Size(120, 16)
        Me.lblFechaIngEscalafon.TabIndex = 27
        Me.lblFechaIngEscalafon.Text = "Fecha Ing.Escalafon"
        Me.lblFechaIngEscalafon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaIngEstamento
        '
        Me.lblFechaIngEstamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngEstamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaIngEstamento.Location = New System.Drawing.Point(424, 120)
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
        Me.lblFechaIngGrado.Location = New System.Drawing.Point(456, 96)
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
        Me.lblFechaIngCalidadJuridica.Location = New System.Drawing.Point(408, 72)
        Me.lblFechaIngCalidadJuridica.Name = "lblFechaIngCalidadJuridica"
        Me.lblFechaIngCalidadJuridica.Size = New System.Drawing.Size(160, 16)
        Me.lblFechaIngCalidadJuridica.TabIndex = 21
        Me.lblFechaIngCalidadJuridica.Text = "Fecha Ing.Calidad Jurídica"
        Me.lblFechaIngCalidadJuridica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Enabled = False
        Me.txtDepartamento.Location = New System.Drawing.Point(144, 168)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Properties.ReadOnly = True
        Me.txtDepartamento.Size = New System.Drawing.Size(232, 20)
        Me.txtDepartamento.TabIndex = 20
        '
        'txtEscalafon
        '
        Me.txtEscalafon.Enabled = False
        Me.txtEscalafon.Location = New System.Drawing.Point(144, 144)
        Me.txtEscalafon.Name = "txtEscalafon"
        Me.txtEscalafon.Properties.ReadOnly = True
        Me.txtEscalafon.Size = New System.Drawing.Size(232, 20)
        Me.txtEscalafon.TabIndex = 18
        '
        'txtEstamento
        '
        Me.txtEstamento.Enabled = False
        Me.txtEstamento.Location = New System.Drawing.Point(144, 120)
        Me.txtEstamento.Name = "txtEstamento"
        Me.txtEstamento.Properties.ReadOnly = True
        Me.txtEstamento.Size = New System.Drawing.Size(232, 20)
        Me.txtEstamento.TabIndex = 16
        '
        'txtGrado
        '
        Me.txtGrado.Enabled = False
        Me.txtGrado.Location = New System.Drawing.Point(144, 96)
        Me.txtGrado.Name = "txtGrado"
        Me.txtGrado.Properties.ReadOnly = True
        Me.txtGrado.Size = New System.Drawing.Size(232, 20)
        Me.txtGrado.TabIndex = 14
        '
        'lblDepto
        '
        Me.lblDepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDepto.Location = New System.Drawing.Point(24, 168)
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
        Me.lblEscalafon.Location = New System.Drawing.Point(24, 144)
        Me.lblEscalafon.Name = "lblEscalafon"
        Me.lblEscalafon.Size = New System.Drawing.Size(112, 16)
        Me.lblEscalafon.TabIndex = 17
        Me.lblEscalafon.Text = "Escalafon"
        Me.lblEscalafon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEstamento
        '
        Me.lblEstamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEstamento.Location = New System.Drawing.Point(24, 120)
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
        Me.lblGrado.Location = New System.Drawing.Point(24, 96)
        Me.lblGrado.Name = "lblGrado"
        Me.lblGrado.Size = New System.Drawing.Size(112, 16)
        Me.lblGrado.TabIndex = 13
        Me.lblGrado.Text = "Grado"
        Me.lblGrado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCalidadJuridica
        '
        Me.txtCalidadJuridica.Enabled = False
        Me.txtCalidadJuridica.Location = New System.Drawing.Point(144, 72)
        Me.txtCalidadJuridica.Name = "txtCalidadJuridica"
        Me.txtCalidadJuridica.Properties.ReadOnly = True
        Me.txtCalidadJuridica.Size = New System.Drawing.Size(232, 20)
        Me.txtCalidadJuridica.TabIndex = 12
        '
        'txtEstadoEmpleado
        '
        Me.txtEstadoEmpleado.Enabled = False
        Me.txtEstadoEmpleado.Location = New System.Drawing.Point(144, 48)
        Me.txtEstadoEmpleado.Name = "txtEstadoEmpleado"
        Me.txtEstadoEmpleado.Properties.ReadOnly = True
        Me.txtEstadoEmpleado.Size = New System.Drawing.Size(232, 20)
        Me.txtEstadoEmpleado.TabIndex = 10
        '
        'lblCalidadJuridica
        '
        Me.lblCalidadJuridica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalidadJuridica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCalidadJuridica.Location = New System.Drawing.Point(24, 72)
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
        Me.lblEstadoEmpleado.Location = New System.Drawing.Point(24, 48)
        Me.lblEstadoEmpleado.Name = "lblEstadoEmpleado"
        Me.lblEstadoEmpleado.Size = New System.Drawing.Size(112, 16)
        Me.lblEstadoEmpleado.TabIndex = 9
        Me.lblEstadoEmpleado.Text = "Estado Empleado"
        Me.lblEstadoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gdcHojaVidaLaboral
        '
        Me.gdcHojaVidaLaboral.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcHojaVidaLaboral.Location = New System.Drawing.Point(16, 304)
        Me.gdcHojaVidaLaboral.MainView = Me.gdvDetalleHojaLaboral
        Me.gdcHojaVidaLaboral.Name = "gdcHojaVidaLaboral"
        Me.gdcHojaVidaLaboral.Size = New System.Drawing.Size(760, 256)
        Me.gdcHojaVidaLaboral.TabIndex = 66
        Me.gdcHojaVidaLaboral.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleHojaLaboral, Me.GridView1})
        '
        'gdvDetalleHojaLaboral
        '
        Me.gdvDetalleHojaLaboral.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ANTECEDENTE_LABORAL_ID, Me.FECHA_MOVIMIENTO, Me.DESCRIPCION_MOVIMIENTO, Me.DESCRIPCION_CALIDAD_JURIDICA, Me.DESCRIPCION_GRADO, Me.DESCRIPCION_ESTAMENTO, Me.DESCRIPCION_ESCALAFON, Me.DESCRIPCION_DEPTO, Me.FECHA_ING_CALIDAD_JURIDICA, Me.FECHA_ING_GRADO, Me.FECHA_ING_ESTAMENTO, Me.FECHA_ING_ESCALAFON, Me.FECHA_ING_DEPTO})
        Me.gdvDetalleHojaLaboral.GridControl = Me.gdcHojaVidaLaboral
        Me.gdvDetalleHojaLaboral.Name = "gdvDetalleHojaLaboral"
        Me.gdvDetalleHojaLaboral.OptionsView.ColumnAutoWidth = False
        Me.gdvDetalleHojaLaboral.OptionsView.ShowGroupPanel = False
        '
        'ANTECEDENTE_LABORAL_ID
        '
        Me.ANTECEDENTE_LABORAL_ID.Caption = "Id Antec.Laboral"
        Me.ANTECEDENTE_LABORAL_ID.FieldName = "ANTECEDENTE_LABORAL_ID"
        Me.ANTECEDENTE_LABORAL_ID.Name = "ANTECEDENTE_LABORAL_ID"
        '
        'FECHA_MOVIMIENTO
        '
        Me.FECHA_MOVIMIENTO.Caption = "Fecha Movimiento"
        Me.FECHA_MOVIMIENTO.FieldName = "FECHA_MOVIMIENTO"
        Me.FECHA_MOVIMIENTO.Name = "FECHA_MOVIMIENTO"
        Me.FECHA_MOVIMIENTO.Visible = True
        Me.FECHA_MOVIMIENTO.VisibleIndex = 1
        Me.FECHA_MOVIMIENTO.Width = 106
        '
        'DESCRIPCION_MOVIMIENTO
        '
        Me.DESCRIPCION_MOVIMIENTO.Caption = "Movimiento"
        Me.DESCRIPCION_MOVIMIENTO.FieldName = "DESCRIPCION_MOVIMIENTO"
        Me.DESCRIPCION_MOVIMIENTO.Name = "DESCRIPCION_MOVIMIENTO"
        Me.DESCRIPCION_MOVIMIENTO.Visible = True
        Me.DESCRIPCION_MOVIMIENTO.VisibleIndex = 0
        Me.DESCRIPCION_MOVIMIENTO.Width = 208
        '
        'DESCRIPCION_CALIDAD_JURIDICA
        '
        Me.DESCRIPCION_CALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.DESCRIPCION_CALIDAD_JURIDICA.FieldName = "DESCRIPCION_CALIDAD_JURIDICA"
        Me.DESCRIPCION_CALIDAD_JURIDICA.Name = "DESCRIPCION_CALIDAD_JURIDICA"
        Me.DESCRIPCION_CALIDAD_JURIDICA.Visible = True
        Me.DESCRIPCION_CALIDAD_JURIDICA.VisibleIndex = 2
        Me.DESCRIPCION_CALIDAD_JURIDICA.Width = 119
        '
        'DESCRIPCION_GRADO
        '
        Me.DESCRIPCION_GRADO.Caption = "Grado"
        Me.DESCRIPCION_GRADO.FieldName = "DESCRIPCION_GRADO"
        Me.DESCRIPCION_GRADO.Name = "DESCRIPCION_GRADO"
        Me.DESCRIPCION_GRADO.Visible = True
        Me.DESCRIPCION_GRADO.VisibleIndex = 3
        '
        'DESCRIPCION_ESTAMENTO
        '
        Me.DESCRIPCION_ESTAMENTO.Caption = "Estamento"
        Me.DESCRIPCION_ESTAMENTO.FieldName = "DESCRIPCION_ESTAMENTO"
        Me.DESCRIPCION_ESTAMENTO.Name = "DESCRIPCION_ESTAMENTO"
        Me.DESCRIPCION_ESTAMENTO.Visible = True
        Me.DESCRIPCION_ESTAMENTO.VisibleIndex = 4
        Me.DESCRIPCION_ESTAMENTO.Width = 126
        '
        'DESCRIPCION_ESCALAFON
        '
        Me.DESCRIPCION_ESCALAFON.Caption = "Escalafón"
        Me.DESCRIPCION_ESCALAFON.FieldName = "DESCRIPCION_ESCALAFON"
        Me.DESCRIPCION_ESCALAFON.Name = "DESCRIPCION_ESCALAFON"
        Me.DESCRIPCION_ESCALAFON.Visible = True
        Me.DESCRIPCION_ESCALAFON.VisibleIndex = 5
        Me.DESCRIPCION_ESCALAFON.Width = 120
        '
        'DESCRIPCION_DEPTO
        '
        Me.DESCRIPCION_DEPTO.Caption = "Departamento"
        Me.DESCRIPCION_DEPTO.FieldName = "DESCRIPCION_DEPTO"
        Me.DESCRIPCION_DEPTO.Name = "DESCRIPCION_DEPTO"
        Me.DESCRIPCION_DEPTO.Visible = True
        Me.DESCRIPCION_DEPTO.VisibleIndex = 6
        Me.DESCRIPCION_DEPTO.Width = 176
        '
        'FECHA_ING_CALIDAD_JURIDICA
        '
        Me.FECHA_ING_CALIDAD_JURIDICA.Caption = "Fecha Ing.Cal.Jurídica"
        Me.FECHA_ING_CALIDAD_JURIDICA.FieldName = "FECHA_ING_CALIDAD_JURIDICA"
        Me.FECHA_ING_CALIDAD_JURIDICA.Name = "FECHA_ING_CALIDAD_JURIDICA"
        Me.FECHA_ING_CALIDAD_JURIDICA.Visible = True
        Me.FECHA_ING_CALIDAD_JURIDICA.VisibleIndex = 7
        Me.FECHA_ING_CALIDAD_JURIDICA.Width = 108
        '
        'FECHA_ING_GRADO
        '
        Me.FECHA_ING_GRADO.Caption = "Fecha Ing.Grado"
        Me.FECHA_ING_GRADO.FieldName = "FECHA_ING_GRADO"
        Me.FECHA_ING_GRADO.Name = "FECHA_ING_GRADO"
        Me.FECHA_ING_GRADO.Visible = True
        Me.FECHA_ING_GRADO.VisibleIndex = 8
        Me.FECHA_ING_GRADO.Width = 106
        '
        'FECHA_ING_ESTAMENTO
        '
        Me.FECHA_ING_ESTAMENTO.Caption = "Fecha Ing.Estamento"
        Me.FECHA_ING_ESTAMENTO.FieldName = "FECHA_ING_ESTAMENTO"
        Me.FECHA_ING_ESTAMENTO.Name = "FECHA_ING_ESTAMENTO"
        Me.FECHA_ING_ESTAMENTO.Visible = True
        Me.FECHA_ING_ESTAMENTO.VisibleIndex = 9
        Me.FECHA_ING_ESTAMENTO.Width = 127
        '
        'FECHA_ING_ESCALAFON
        '
        Me.FECHA_ING_ESCALAFON.Caption = "Fecha Ing.Escalafón"
        Me.FECHA_ING_ESCALAFON.FieldName = "FECHA_ING_ESCALAFON"
        Me.FECHA_ING_ESCALAFON.Name = "FECHA_ING_ESCALAFON"
        Me.FECHA_ING_ESCALAFON.Visible = True
        Me.FECHA_ING_ESCALAFON.VisibleIndex = 10
        Me.FECHA_ING_ESCALAFON.Width = 127
        '
        'FECHA_ING_DEPTO
        '
        Me.FECHA_ING_DEPTO.Caption = "Fecha Ing.Depto."
        Me.FECHA_ING_DEPTO.FieldName = "FECHA_ING_DEPTO"
        Me.FECHA_ING_DEPTO.Name = "FECHA_ING_DEPTO"
        Me.FECHA_ING_DEPTO.Visible = True
        Me.FECHA_ING_DEPTO.VisibleIndex = 11
        Me.FECHA_ING_DEPTO.Width = 108
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcHojaVidaLaboral
        Me.GridView1.Name = "GridView1"
        '
        'prsHojaVidaLaboral
        '
        Me.prsHojaVidaLaboral.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcHojaVidaLaboral
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(5, 5, 100, 100)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de la República", "Hoja de Vida Laboral", "Fecha Emisión:[Date Printed]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Emitido por:[User Name]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"", "", "Página:[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.prsHojaVidaLaboral
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prsHojaVidaLaboral
        '
        'frmHojaVidaLaboral
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 574)
        Me.Controls.Add(Me.gdcHojaVidaLaboral)
        Me.Controls.Add(Me.gpcSituacionActual)
        Me.Controls.Add(Me.gleRut)
        Me.Controls.Add(Me.gpcNombreEmpleado)
        Me.Name = "frmHojaVidaLaboral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hoja de Vida Laboral"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txtDV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gevRut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcNombreEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcNombreEmpleado.ResumeLayout(False)
        CType(Me.txtFechaIngAdmPublica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIngresoInstitucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcSituacionActual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSituacionActual.ResumeLayout(False)
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
        CType(Me.gdcHojaVidaLaboral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleHojaLaboral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvHojaVidaLaboral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prsHojaVidaLaboral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim empleado As empleado
    Dim movimiento As String

    Private Sub frmHojaVidaLaboral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        repositorio.Show()
        btnVisualizar.Enabled = False
        llenarRutEmpleado()
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

        gleRut.Properties.ValueMember = "EMPLEADO_ID"

        gleRut.Properties.View.BestFitColumns()
        gleRut.Properties.PopupFormWidth = 600

        gleRut.Text = ""
    End Sub
    Private Sub gleRut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gleRut.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                empleado = New empleado(CType(gleRut.EditValue, Long))
                gdcHojaVidaLaboral.DataSource = empleado.dvHojaVidaLaboral(empleado.ID)
                btnVisualizar.Enabled = True
                refrescarControles()
            Catch exp As Exception
                MessageBox.Show("Atención: " & exp.Message, "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
        txtFechaIngCalidadJuridica.Text = empleado.datosLaborales.fechaIngresoCalidadJuridica
        txtFechaIngGrado.Text = empleado.datosLaborales.fechaIngresoGrado
        txtFechaIngEstamento.Text = empleado.datosLaborales.fechaIngresoEstamento
        txtFechaIngEscalafon.Text = empleado.datosLaborales.fechaIngresoEscalafon
        txtFechaIngDepto.Text = empleado.datosLaborales.fechaIngresoDepartamento
    End Sub
    Private Sub GeneraDataViews()
        Dim da As SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
        Dim ds1 As New DataSet
        Dim ds2 As New DataSet

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.VISTAS.SELECT_HOJA_VIDA_LABORAL, conn))
        da.Fill(ds1, Comun.Vistas.VW_HOJA_VIDA_LABORAL)
        Dim dvmHojaVidaLaboral As New DataViewManager(ds1)
        dvHojaVidaLaboral = dvmHojaVidaLaboral.CreateDataView(ds1.Tables(Comun.Vistas.VW_HOJA_VIDA_LABORAL))
    End Sub
    Private Sub limpiarControles()
        txtDV.Text = ""
        gleRut.EditValue = 0
        txtNombres.Text = ""
        txtFechaIngresoInstitucion.Text = ""
        txtFechaIngAdmPublica.Text = ""
        txtEstadoEmpleado.Text = ""
        txtCalidadJuridica.Text = ""
        txtGrado.Text = ""
        txtEstamento.Text = ""
        txtEscalafon.Text = ""
        txtDepartamento.Text = ""
        txtFechaIngCalidadJuridica.Text = ""
        txtFechaIngGrado.Text = ""
        txtFechaIngEstamento.Text = ""
        txtFechaIngEscalafon.Text = ""
        txtFechaIngDepto.Text = ""
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
    End Sub
    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        empleado = New empleado(CType(gleRut.EditValue, Long))
        Dim reportHeader As String = "EMPLEADO : " & empleado.nombreCompleto
        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)
    End Sub

    Private Sub PrintableComponentLink1_CreateDetailArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateDetailArea
        e.Graph.Font = New Font("Comic Sans MS", 5)
        Me.PrintableComponentLink1.Component = Me.gdcHojaVidaLaboral
    End Sub
End Class
