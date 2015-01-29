﻿Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Windows.Forms
Imports System.Drawing
Imports System

Public Class frmPermisoPaternal
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
    Friend WithEvents txtDiasPendientes As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDiasPendientes As System.Windows.Forms.Label
    Friend WithEvents txtTotalDiasSolicitados As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTotalDiasSoliciatdos As System.Windows.Forms.Label
    Friend WithEvents txtTotalDiasAnual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDiasTotalAnual As System.Windows.Forms.Label
    Friend WithEvents dvPeriodo As System.Data.DataView
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFechaIngreso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FECHA_DIGITACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EVENTO_ADMINISTRATIVO_DET_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dedFechaInicio As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents txtdiasHabiles As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PERIODO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtEstadoEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblEstadoEmpleado As System.Windows.Forms.Label
    Friend WithEvents USUARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents btnEmiteDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gpcSaldoDiasPermisoAdm As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSaldoDiasPermisoAdmin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gdcPermisoAdmin As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetallePermisoAdmin As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dvTipoJornada As System.Data.DataView
    Friend WithEvents lueTipoJornada As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents prsPermisoAdmin As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents txtNombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNombres As System.Windows.Forms.Label
    Friend WithEvents lblRut As System.Windows.Forms.Label
    Friend WithEvents glerut As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TIPO_FALLECIMIENTO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dedFechaNacimientoHijo As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPermisoPaternal))
        Me.gpcEncabezado = New DevExpress.XtraEditors.GroupControl()
        Me.txtNombres = New DevExpress.XtraEditors.TextEdit()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.glerut = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnEmiteDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.txtEstadoEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.lblEstadoEmpleado = New System.Windows.Forms.Label()
        Me.btnSaldoDiasPermisoAdmin = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFechaIngreso = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.gpcSaldoDiasPermisoAdm = New DevExpress.XtraEditors.GroupControl()
        Me.txtDiasPendientes = New DevExpress.XtraEditors.TextEdit()
        Me.lblDiasPendientes = New System.Windows.Forms.Label()
        Me.txtTotalDiasSolicitados = New DevExpress.XtraEditors.TextEdit()
        Me.lblTotalDiasSoliciatdos = New System.Windows.Forms.Label()
        Me.txtTotalDiasAnual = New DevExpress.XtraEditors.TextEdit()
        Me.lblDiasTotalAnual = New System.Windows.Forms.Label()
        Me.dvPeriodo = New System.Data.DataView()
        Me.gdcPermisoAdmin = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetallePermisoAdmin = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.EVENTO_ADMINISTRATIVO_DET_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EVENTO_ADMINISTRATIVO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIAS_HABILES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtdiasHabiles = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.FECHA_NACIMIENTO_HIJO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dedFechaNacimientoHijo = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.JORNADA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lueTipoJornada = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
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
        Me.prsPermisoAdmin = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.dvTipoJornada = New System.Data.DataView()
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcEncabezado.SuspendLayout()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glerut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstadoEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcSaldoDiasPermisoAdm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSaldoDiasPermisoAdm.SuspendLayout()
        CType(Me.txtDiasPendientes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDiasSolicitados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDiasAnual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcPermisoAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetallePermisoAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdiasHabiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaNacimientoHijo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaNacimientoHijo.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTipoJornada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaInicio.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prsPermisoAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvTipoJornada, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gpcEncabezado.Controls.Add(Me.glerut)
        Me.gpcEncabezado.Controls.Add(Me.btnEmiteDetalle)
        Me.gpcEncabezado.Controls.Add(Me.txtEstadoEmpleado)
        Me.gpcEncabezado.Controls.Add(Me.lblEstadoEmpleado)
        Me.gpcEncabezado.Controls.Add(Me.btnSaldoDiasPermisoAdmin)
        Me.gpcEncabezado.Controls.Add(Me.txtFechaIngreso)
        Me.gpcEncabezado.Controls.Add(Me.Label1)
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
        Me.txtNombres.Location = New System.Drawing.Point(120, 78)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombres.Properties.MaxLength = 30
        Me.txtNombres.Size = New System.Drawing.Size(328, 20)
        Me.txtNombres.TabIndex = 58
        '
        'lblNombres
        '
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.Location = New System.Drawing.Point(8, 78)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(96, 16)
        Me.lblNombres.TabIndex = 59
        Me.lblNombres.Text = "Nombres"
        Me.lblNombres.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRut
        '
        Me.lblRut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRut.Location = New System.Drawing.Point(8, 54)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(96, 16)
        Me.lblRut.TabIndex = 57
        Me.lblRut.Text = "Rut"
        Me.lblRut.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'glerut
        '
        Me.glerut.Cursor = System.Windows.Forms.Cursors.Default
        Me.glerut.EditValue = ""
        Me.glerut.Location = New System.Drawing.Point(120, 54)
        Me.glerut.Name = "glerut"
        Me.glerut.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.glerut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glerut.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.glerut.Properties.View = Me.GridView1
        Me.glerut.Size = New System.Drawing.Size(144, 20)
        Me.glerut.TabIndex = 56
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
        Me.btnEmiteDetalle.Location = New System.Drawing.Point(512, 64)
        Me.btnEmiteDetalle.Name = "btnEmiteDetalle"
        Me.btnEmiteDetalle.Size = New System.Drawing.Size(240, 23)
        Me.btnEmiteDetalle.TabIndex = 11
        Me.btnEmiteDetalle.Text = "Emite Detalle"
        '
        'txtEstadoEmpleado
        '
        Me.txtEstadoEmpleado.Enabled = False
        Me.txtEstadoEmpleado.Location = New System.Drawing.Point(344, 105)
        Me.txtEstadoEmpleado.Name = "txtEstadoEmpleado"
        Me.txtEstadoEmpleado.Size = New System.Drawing.Size(96, 20)
        Me.txtEstadoEmpleado.TabIndex = 10
        '
        'lblEstadoEmpleado
        '
        Me.lblEstadoEmpleado.Location = New System.Drawing.Point(232, 105)
        Me.lblEstadoEmpleado.Name = "lblEstadoEmpleado"
        Me.lblEstadoEmpleado.Size = New System.Drawing.Size(96, 16)
        Me.lblEstadoEmpleado.TabIndex = 9
        Me.lblEstadoEmpleado.Text = "Estado Empleado"
        Me.lblEstadoEmpleado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnSaldoDiasPermisoAdmin
        '
        Me.btnSaldoDiasPermisoAdmin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaldoDiasPermisoAdmin.Location = New System.Drawing.Point(512, 32)
        Me.btnSaldoDiasPermisoAdmin.Name = "btnSaldoDiasPermisoAdmin"
        Me.btnSaldoDiasPermisoAdmin.Size = New System.Drawing.Size(240, 23)
        Me.btnSaldoDiasPermisoAdmin.TabIndex = 8
        Me.btnSaldoDiasPermisoAdmin.Text = "Genera Saldo Dias Permiso Paternal"
        '
        'txtFechaIngreso
        '
        Me.txtFechaIngreso.Enabled = False
        Me.txtFechaIngreso.Location = New System.Drawing.Point(120, 105)
        Me.txtFechaIngreso.Name = "txtFechaIngreso"
        Me.txtFechaIngreso.Size = New System.Drawing.Size(96, 20)
        Me.txtFechaIngreso.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha Ingreso"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        'gpcSaldoDiasPermisoAdm
        '
        Me.gpcSaldoDiasPermisoAdm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSaldoDiasPermisoAdm.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSaldoDiasPermisoAdm.AppearanceCaption.Options.UseFont = True
        Me.gpcSaldoDiasPermisoAdm.Controls.Add(Me.txtDiasPendientes)
        Me.gpcSaldoDiasPermisoAdm.Controls.Add(Me.lblDiasPendientes)
        Me.gpcSaldoDiasPermisoAdm.Controls.Add(Me.txtTotalDiasSolicitados)
        Me.gpcSaldoDiasPermisoAdm.Controls.Add(Me.lblTotalDiasSoliciatdos)
        Me.gpcSaldoDiasPermisoAdm.Controls.Add(Me.txtTotalDiasAnual)
        Me.gpcSaldoDiasPermisoAdm.Controls.Add(Me.lblDiasTotalAnual)
        Me.gpcSaldoDiasPermisoAdm.Location = New System.Drawing.Point(8, 144)
        Me.gpcSaldoDiasPermisoAdm.Name = "gpcSaldoDiasPermisoAdm"
        Me.gpcSaldoDiasPermisoAdm.Size = New System.Drawing.Size(816, 104)
        Me.gpcSaldoDiasPermisoAdm.TabIndex = 54
        Me.gpcSaldoDiasPermisoAdm.Text = "Saldos Días Permiso Paternal"
        '
        'txtDiasPendientes
        '
        Me.txtDiasPendientes.Enabled = False
        Me.txtDiasPendientes.Location = New System.Drawing.Point(544, 56)
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
        Me.lblDiasPendientes.Location = New System.Drawing.Point(512, 32)
        Me.lblDiasPendientes.Name = "lblDiasPendientes"
        Me.lblDiasPendientes.Size = New System.Drawing.Size(96, 16)
        Me.lblDiasPendientes.TabIndex = 58
        Me.lblDiasPendientes.Text = "Días Pendientes"
        Me.lblDiasPendientes.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTotalDiasSolicitados
        '
        Me.txtTotalDiasSolicitados.Enabled = False
        Me.txtTotalDiasSolicitados.Location = New System.Drawing.Point(392, 56)
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
        Me.lblTotalDiasSoliciatdos.Location = New System.Drawing.Point(336, 32)
        Me.lblTotalDiasSoliciatdos.Name = "lblTotalDiasSoliciatdos"
        Me.lblTotalDiasSoliciatdos.Size = New System.Drawing.Size(128, 16)
        Me.lblTotalDiasSoliciatdos.TabIndex = 56
        Me.lblTotalDiasSoliciatdos.Text = "Total Días Solicitados"
        Me.lblTotalDiasSoliciatdos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTotalDiasAnual
        '
        Me.txtTotalDiasAnual.Enabled = False
        Me.txtTotalDiasAnual.Location = New System.Drawing.Point(216, 56)
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
        Me.lblDiasTotalAnual.Location = New System.Drawing.Point(176, 32)
        Me.lblDiasTotalAnual.Name = "lblDiasTotalAnual"
        Me.lblDiasTotalAnual.Size = New System.Drawing.Size(96, 16)
        Me.lblDiasTotalAnual.TabIndex = 54
        Me.lblDiasTotalAnual.Text = "Total Días Anual"
        Me.lblDiasTotalAnual.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gdcPermisoAdmin
        '
        Me.gdcPermisoAdmin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcPermisoAdmin.Location = New System.Drawing.Point(8, 248)
        Me.gdcPermisoAdmin.MainView = Me.gdvDetallePermisoAdmin
        Me.gdcPermisoAdmin.Name = "gdcPermisoAdmin"
        Me.gdcPermisoAdmin.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.dedFechaInicio, Me.txtdiasHabiles, Me.lueTipoJornada, Me.dedFechaNacimientoHijo})
        Me.gdcPermisoAdmin.Size = New System.Drawing.Size(816, 232)
        Me.gdcPermisoAdmin.TabIndex = 55
        Me.gdcPermisoAdmin.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetallePermisoAdmin})
        '
        'gdvDetallePermisoAdmin
        '
        Me.gdvDetallePermisoAdmin.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvDetallePermisoAdmin.Appearance.FooterPanel.Options.UseFont = True
        Me.gdvDetallePermisoAdmin.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.EVENTO_ADMINISTRATIVO_DET_ID, Me.EVENTO_ADMINISTRATIVO_ID, Me.DIAS_HABILES, Me.FECHA_NACIMIENTO_HIJO, Me.JORNADA_ID, Me.FECHA_INICIO, Me.FECHA_TERMINO, Me.DIAS_RECORRIDO, Me.FECHA_REGRESO, Me.RESOLUCION, Me.OBSERVACION, Me.FECHA_DIGITACION, Me.PERIODO_ID, Me.USUARIO, Me.TIPO_FALLECIMIENTO_ID})
        Me.gdvDetallePermisoAdmin.GridControl = Me.gdcPermisoAdmin
        Me.gdvDetallePermisoAdmin.Name = "gdvDetallePermisoAdmin"
        Me.gdvDetallePermisoAdmin.NewItemRowText = "Nuevo Registro"
        Me.gdvDetallePermisoAdmin.OptionsNavigation.EnterMoveNextColumn = True
        Me.gdvDetallePermisoAdmin.OptionsPrint.UsePrintStyles = True
        Me.gdvDetallePermisoAdmin.OptionsView.ColumnAutoWidth = False
        Me.gdvDetallePermisoAdmin.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gdvDetallePermisoAdmin.OptionsView.ShowFooter = True
        Me.gdvDetallePermisoAdmin.OptionsView.ShowGroupPanel = False
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
        'DIAS_HABILES
        '
        Me.DIAS_HABILES.Caption = "Días Hábiles"
        Me.DIAS_HABILES.ColumnEdit = Me.txtdiasHabiles
        Me.DIAS_HABILES.FieldName = "DIAS_HABILES"
        Me.DIAS_HABILES.Name = "DIAS_HABILES"
        Me.DIAS_HABILES.SummaryItem.DisplayFormat = "Total Días: {0:n1}"
        Me.DIAS_HABILES.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.DIAS_HABILES.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.DIAS_HABILES.Visible = True
        Me.DIAS_HABILES.VisibleIndex = 0
        Me.DIAS_HABILES.Width = 102
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
        'FECHA_NACIMIENTO_HIJO
        '
        Me.FECHA_NACIMIENTO_HIJO.Caption = "Fecha Nacimiento Hijo"
        Me.FECHA_NACIMIENTO_HIJO.ColumnEdit = Me.dedFechaNacimientoHijo
        Me.FECHA_NACIMIENTO_HIJO.FieldName = "FECHA_NACIMIENTO_HIJO"
        Me.FECHA_NACIMIENTO_HIJO.Name = "FECHA_NACIMIENTO_HIJO"
        Me.FECHA_NACIMIENTO_HIJO.Visible = True
        Me.FECHA_NACIMIENTO_HIJO.VisibleIndex = 1
        Me.FECHA_NACIMIENTO_HIJO.Width = 104
        '
        'dedFechaNacimientoHijo
        '
        Me.dedFechaNacimientoHijo.AutoHeight = False
        Me.dedFechaNacimientoHijo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaNacimientoHijo.Name = "dedFechaNacimientoHijo"
        Me.dedFechaNacimientoHijo.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'JORNADA_ID
        '
        Me.JORNADA_ID.Caption = "Jornada"
        Me.JORNADA_ID.ColumnEdit = Me.lueTipoJornada
        Me.JORNADA_ID.FieldName = "JORNADA_ID"
        Me.JORNADA_ID.Name = "JORNADA_ID"
        Me.JORNADA_ID.OptionsColumn.ReadOnly = True
        Me.JORNADA_ID.Width = 112
        '
        'lueTipoJornada
        '
        Me.lueTipoJornada.AutoHeight = False
        Me.lueTipoJornada.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTipoJornada.Name = "lueTipoJornada"
        '
        'FECHA_INICIO
        '
        Me.FECHA_INICIO.Caption = "Fecha Inicio"
        Me.FECHA_INICIO.ColumnEdit = Me.dedFechaInicio
        Me.FECHA_INICIO.FieldName = "FECHA_INICIO"
        Me.FECHA_INICIO.Name = "FECHA_INICIO"
        Me.FECHA_INICIO.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
        Me.FECHA_INICIO.Visible = True
        Me.FECHA_INICIO.VisibleIndex = 2
        Me.FECHA_INICIO.Width = 91
        '
        'dedFechaInicio
        '
        Me.dedFechaInicio.AutoHeight = False
        Me.dedFechaInicio.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaInicio.Mask.UseMaskAsDisplayFormat = True
        Me.dedFechaInicio.Name = "dedFechaInicio"
        Me.dedFechaInicio.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'FECHA_TERMINO
        '
        Me.FECHA_TERMINO.Caption = "Fecha Término"
        Me.FECHA_TERMINO.FieldName = "FECHA_TERMINO"
        Me.FECHA_TERMINO.Name = "FECHA_TERMINO"
        Me.FECHA_TERMINO.OptionsColumn.ReadOnly = True
        Me.FECHA_TERMINO.Visible = True
        Me.FECHA_TERMINO.VisibleIndex = 3
        Me.FECHA_TERMINO.Width = 105
        '
        'DIAS_RECORRIDO
        '
        Me.DIAS_RECORRIDO.Caption = "Días Recorrido"
        Me.DIAS_RECORRIDO.FieldName = "DIAS_RECORRIDO"
        Me.DIAS_RECORRIDO.Name = "DIAS_RECORRIDO"
        Me.DIAS_RECORRIDO.OptionsColumn.ReadOnly = True
        Me.DIAS_RECORRIDO.Visible = True
        Me.DIAS_RECORRIDO.VisibleIndex = 4
        Me.DIAS_RECORRIDO.Width = 99
        '
        'FECHA_REGRESO
        '
        Me.FECHA_REGRESO.Caption = "Fecha Regreso"
        Me.FECHA_REGRESO.FieldName = "FECHA_REGRESO"
        Me.FECHA_REGRESO.Name = "FECHA_REGRESO"
        Me.FECHA_REGRESO.OptionsColumn.ReadOnly = True
        Me.FECHA_REGRESO.Visible = True
        Me.FECHA_REGRESO.VisibleIndex = 5
        Me.FECHA_REGRESO.Width = 92
        '
        'RESOLUCION
        '
        Me.RESOLUCION.Caption = "Resolución"
        Me.RESOLUCION.FieldName = "RESOLUCION"
        Me.RESOLUCION.Name = "RESOLUCION"
        Me.RESOLUCION.Visible = True
        Me.RESOLUCION.VisibleIndex = 6
        Me.RESOLUCION.Width = 117
        '
        'OBSERVACION
        '
        Me.OBSERVACION.Caption = "Observación"
        Me.OBSERVACION.FieldName = "OBSERVACION"
        Me.OBSERVACION.Name = "OBSERVACION"
        Me.OBSERVACION.Visible = True
        Me.OBSERVACION.VisibleIndex = 7
        Me.OBSERVACION.Width = 197
        '
        'FECHA_DIGITACION
        '
        Me.FECHA_DIGITACION.Caption = "Fecha Digitación"
        Me.FECHA_DIGITACION.FieldName = "FECHA_DIGITACION"
        Me.FECHA_DIGITACION.Name = "FECHA_DIGITACION"
        Me.FECHA_DIGITACION.OptionsColumn.ReadOnly = True
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
        Me.USUARIO.Width = 86
        '
        'TIPO_FALLECIMIENTO_ID
        '
        Me.TIPO_FALLECIMIENTO_ID.Caption = "ID Tipo Fallecimiento"
        Me.TIPO_FALLECIMIENTO_ID.FieldName = "TIPO_FALLECIMIENTO_ID"
        Me.TIPO_FALLECIMIENTO_ID.Name = "TIPO_FALLECIMIENTO_ID"
        Me.TIPO_FALLECIMIENTO_ID.OptionsColumn.ReadOnly = True
        '
        'prsPermisoAdmin
        '
        Me.prsPermisoAdmin.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcPermisoAdmin
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(85, 100, 100, 100)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de La República" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10), "Detalle Permiso Paternal", "Fecha Emisiòn:[Date Printed]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Emitido Por:[User Name]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"", "", "Página [Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PaperName = "Carta (8,5 x 11 pulg.)"
        Me.PrintableComponentLink1.PrintingSystem = Me.prsPermisoAdmin
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prsPermisoAdmin
        '
        'frmPermisoPaternal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(832, 486)
        Me.Controls.Add(Me.gdcPermisoAdmin)
        Me.Controls.Add(Me.gpcSaldoDiasPermisoAdm)
        Me.Controls.Add(Me.gpcEncabezado)
        Me.Name = "frmPermisoPaternal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permiso Paternal Empleado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcEncabezado.ResumeLayout(False)
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glerut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstadoEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcSaldoDiasPermisoAdm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSaldoDiasPermisoAdm.ResumeLayout(False)
        CType(Me.txtDiasPendientes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDiasSolicitados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDiasAnual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcPermisoAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetallePermisoAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdiasHabiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaNacimientoHijo.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaNacimientoHijo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTipoJornada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaInicio.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prsPermisoAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvTipoJornada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim empleado As Empleado
    Dim parametroMensual As Periodo
    Dim estadoPeriodo As Boolean
    Dim sumaDiasHabiles As Integer = 0
    Dim mensajeDias As String = ""
    Dim eventoAdmin As Integer = Comun.TiposDeDatos.TipoEventoAdmin.PERMISO_PATERNAL

    Private Sub frmPermisoAdministrativo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        repositorio.Show()
        empleado = New Empleado
        parametroMensual = New Periodo
        GeneraDataViews()
        llenarEmpleado()
        llenarPeriodos()
        llenarTipoJornada()
        btnSaldoDiasPermisoAdmin.Enabled = False
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
    Private Sub llenarTipoJornada()
        With lueTipoJornada.Columns
            .Add(New LookUpColumnInfo("JORNADA_ID", "ID Jornada", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
            .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
        End With
        lueTipoJornada.DataSource = dvTipoJornada
        lueTipoJornada.DisplayMember = "DESCRIPCION"
        lueTipoJornada.NullText = ""
        lueTipoJornada.PopupWidth = 100
        lueTipoJornada.ValueMember = "JORNADA_ID"
    End Sub

    Public Sub llenarEmpleado()
        'glerut.Properties.EditValueChangedFiringDelay = 1200
        Repository.RepositoryItem.EditValueChangedFiringDelay = 1200
        glerut.Properties.EditValueChangedFiringMode = EditValueChangedFiringMode.Buffered
        'Dos segundos se espera antes de gatillar la búsqueda (EditValueChanged)

        glerut.Properties.ViewType = Repository.GridLookUpViewType.GridView
        glerut.Properties.View.OptionsBehavior.AutoPopulateColumns = False
        glerut.Properties.DataSource = repositorio.dvEmpleadosMasculinos
        glerut.Properties.DisplayMember = "RUT"

        Dim col1 As GridColumn = glerut.Properties.View.Columns.AddField("RUT")
        col1.VisibleIndex = 0
        col1.Caption = "RUT"

        Dim col2 As GridColumn = glerut.Properties.View.Columns.AddField("APELLIDO_PATERNO")
        col2.VisibleIndex = 1
        col2.Caption = "Apellido Paterno"

        Dim col3 As GridColumn = glerut.Properties.View.Columns.AddField("APELLIDO_MATERNO")
        col3.VisibleIndex = 2
        col3.Caption = "Apellido Materno"

        Dim col4 As GridColumn = glerut.Properties.View.Columns.AddField("NOMBRES")
        col4.VisibleIndex = 3
        col4.Caption = "Nombres"

        Dim col5 As GridColumn = glerut.Properties.View.Columns.AddField("DESC_ESTADO")
        col5.VisibleIndex = 4
        col5.Caption = "Estado"

        Dim col6 As GridColumn = glerut.Properties.View.Columns.AddField("DESC_CALIDAD_JURIDICA")
        col6.VisibleIndex = 5
        col6.Caption = "Calidad Jurídica"

        Dim col7 As GridColumn = glerut.Properties.View.Columns.AddField("EMPLEADO_ID")
        col7.VisibleIndex = 6
        col7.Caption = "ID Empleado"
        col7.Visible = False

        glerut.Properties.ValueMember = "EMPLEADO_ID"
        glerut.Properties.View.BestFitColumns()
        glerut.Properties.PopupFormWidth = 600
    End Sub
    Private Sub GeneraDataViews()
        Dim dad As SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
        Dim ds1 As New DataSet
        Dim ds2 As New DataSet

        dad = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT * FROM RH_PER_TIPO_JORNADA", conn))
        dad.Fill(ds1, Tablas.RH_PER_TIPO_JORNADA)
        Dim dvmTipoJornada As New DataViewManager(ds1)
        dvTipoJornada = dvmTipoJornada.CreateDataView(ds1.Tables(Tablas.RH_PER_TIPO_JORNADA))

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
        If luePeriodo.EditValue <> Nothing And glerut.EditValue <> Nothing Then
            Try
                empleado = New Empleado(CType(glerut.EditValue, Long))
                buscaSaldosDias()
                glerut.EditValue = empleado.ID
                txtNombres.Text = empleado.nombreCompleto
                txtFechaIngreso.Text = empleado.datosLaborales.fechaIngresoInstitucion
                txtEstadoEmpleado.Text = empleado.buscaString("SELECT DESCRIPCION FROM RH_PER_ESTADO_EMPLEADO WHERE ESTADO_EMPLEADO_ID=" & empleado.estadoEmpleadoID)
                gdcPermisoAdmin.DataSource = empleado.dvEventosAdministrativos(glerut.EditValue, eventoAdmin, luePeriodo.EditValue)

                If empleado.estadoEmpleadoID = Comun.TiposDeDatos.TipoEstado.INACTIVO Or empleado.estadoEmpleadoID = Comun.TiposDeDatos.TipoEstado.POR_ACTIVAR Then
                    gdcPermisoAdmin.Enabled = False
                Else
                    gdcPermisoAdmin.Enabled = True
                End If
                If CType(txtTotalDiasAnual.Text, Decimal) > 0 Then
                    btnSaldoDiasPermisoAdmin.Enabled = False
                Else
                    btnSaldoDiasPermisoAdmin.Enabled = True
                End If

                btnSaldoDiasPermisoAdmin.Enabled = True
                btnEmiteDetalle.Enabled = True
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al leer datos feriado legal. ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub
    Private Sub gleRut_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles glerut.EditValueChanged
        If luePeriodo.EditValue <> Nothing Then
            refrescaDetalle()
        End If
    End Sub
    Private Sub buscaSaldosDias()
        Dim dv As DataView
        Try
            dv = empleado.recuperaSaldoDiasEventoAdmin(glerut.EditValue, eventoAdmin, luePeriodo.EditValue)
        Finally
            If dv.Count > 0 Then
                'Asigna los datos de la tabla (BD) a las caja de texto
                txtTotalDiasAnual.Text = dv.Table.Rows(0).Item("TOTAL_DIAS_ANUAL")
                txtTotalDiasSolicitados.Text = dv.Table.Rows(0).Item("TOTAL_DIAS_SOLICITADOS")
                txtDiasPendientes.Text = dv.Table.Rows(0).Item("DIAS_PENDIENTE")
            Else
                'Asigna valores 0 al no encontrar información
                txtTotalDiasAnual.Text = 0
                txtTotalDiasSolicitados.Text = 0
                txtDiasPendientes.Text = 0
            End If
        End Try
    End Sub

    Private Sub gdvDetallePermisoAdmin_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvDetallePermisoAdmin.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        Dim nombreUsuario As String = empleado.buscaString("SELECT USER AS USUARIO")
        asignarCampos(Comun.TiposDeDatos.EstadoEventoAdmin.INGRESADO, 0)
        empleado.datosEventoAdmin.Evento_Administrativo_ID = empleado.CrearEmpleadoEventoAdmin(eventoAdmin)
        view.SetRowCellValue(e.RowHandle, "EVENTO_ADMINISTRATIVO_ID", empleado.datosEventoAdmin.Evento_Administrativo_ID)
        'view.SetRowCellValue(e.RowHandle, "FECHA_NACIMIENTO_HIJO", Date.Parse("01-01-1900"))
        view.SetRowCellValue(e.RowHandle, "FECHA_INICIO", Date.Now)
        view.SetRowCellValue(e.RowHandle, "JORNADA_ID", Comun.TiposDeDatos.TipoJornada.DIA_COMPLETO)
        view.SetRowCellValue(e.RowHandle, "FECHA_DIGITACION", Date.Now)
        view.SetRowCellValue(e.RowHandle, "RESOLUCION", "")
        view.SetRowCellValue(e.RowHandle, "OBSERVACION", "")
        view.SetRowCellValue(e.RowHandle, "DIAS_HABILES", 0)
        view.SetRowCellValue(e.RowHandle, "PERIODO_ID", parametroMensual.ID)
        view.SetRowCellValue(e.RowHandle, "USUARIO", nombreUsuario)
        view.SetRowCellValue(e.RowHandle, "TIPO_FALLECIMIENTO_ID", 0)
    End Sub

    Private Sub gdvDetallePermisoAdmin_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvDetallePermisoAdmin.RowUpdated
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetallePermisoAdmin
        If empleado.actualizarDetalleEventoAdmin() Then
            asignarCampos(Comun.TiposDeDatos.EstadoEventoAdmin.ACTUALIZADO, view.GetRowCellValue(view.FocusedRowHandle, "DIAS_HABILES"))
            empleado.actualizarEventoAdmin(empleado.datosEventoAdmin)
            gdcPermisoAdmin.DataSource = empleado.dvEventosAdministrativos(glerut.EditValue, eventoAdmin, luePeriodo.EditValue)
            'gdcPermisoAdmin.RefreshDataSource()
            'buscaSaldosDias()
            refrescaDetalle()
        End If
    End Sub

    Private Sub gdvDetallePermisoAdmin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvDetallePermisoAdmin.KeyDown
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
                            'empleado.actualizarDetalleEventoAdmin()
                            empleado.eliminarDetalleEventoAdmin(idEventoAdmin)
                            empleado.eliminarHeaderEventoAdmin(idEventoAdmin)
                            buscaSaldosDias()
                            gdcPermisoAdmin.DataSource = empleado.dvEventosAdministrativos(glerut.EditValue, eventoAdmin, luePeriodo.EditValue)
                            MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)
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

    Private Sub gdvDetallePermisoAdmin_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gdvDetallePermisoAdmin.ValidateRow
        Dim respuesta As Boolean = True
        If empleado.estadoEmpleadoID = 2 Or empleado.estadoEmpleadoID = 4 Then
            If (MessageBox.Show("El estado del empleado se encuentra inactivo o por activar. ¿Desea continuar?", "Atención", MessageBoxButtons.YesNo) = DialogResult.No) Then
                respuesta = False
                e.Valid = False
            End If
        End If

        If respuesta Then
            Dim View As DevExpress.XtraGrid.Views.Grid.GridView = sender
            Dim view1 As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetallePermisoAdmin
            Dim row As System.Data.DataRowView = e.Row
            Dim idEmpleado As Integer
            Dim FechaInicio As Date
            Dim FechaTermino As Date
            Dim diasHabiles As Decimal = row("DIAS_HABILES")
            Dim idEventoAdmin As Integer = row("EVENTO_ADMINISTRATIVO_ID")
            Dim fechaInicialProceso As Date = CType("01-01-" + CType(luePeriodo.EditValue, String), Date)
            Dim fechaFinalProceso As Date = CType("31-12-" + CType(luePeriodo.EditValue, String), Date)
            Dim FechaDateEditControl As Date = row("FECHA_INICIO")
            Dim FechaNacimiento As Date

            If row("FECHA_NACIMIENTO_HIJO").GetType.ToString = "System.DBNull" Then
                FechaNacimiento = Nothing
            Else
                FechaNacimiento = row("FECHA_NACIMIENTO_HIJO")
            End If

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

            If FechaNacimiento = Nothing Then
                MessageBox.Show("No ha ingresado fecha nacimiento hijo", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    Exit Sub
                End If
            End If
        End If
    End Sub
    Private Sub gdvDetallePermisoAdmin_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvDetallePermisoAdmin.InvalidRowException
        'Suprimir el mensaje de error al validar la fila
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub dedFechaInicio_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dedFechaInicio.Validating
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetallePermisoAdmin
        Dim editor As DevExpress.XtraEditors.DateEdit = sender
        Dim diasHabilesSolicitados As Decimal = view.GetRowCellValue(view.FocusedRowHandle, "DIAS_HABILES")
        Dim fechaNacimientoHijo As Date = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_NACIMIENTO_HIJO")
        Dim FechaDateEditControl As DevExpress.XtraEditors.DateEdit = sender
        Dim fechaFinalPermisoPaternal As Date = fechaNacimientoHijo.AddDays(30)
        Dim continua As Boolean = False
        If FechaDateEditControl.EditValue >= fechaNacimientoHijo And FechaDateEditControl.EditValue <= fechaFinalPermisoPaternal Then
            continua = True
        Else
            If MessageBox.Show("Fecha inicio permiso paternal esta fuera del rango de los 30 días permitidos legalmente. ¿Continua?", "Siga", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                continua = True
            Else
                continua = False
                e.Cancel = True
            End If
        End If
        If continua Then
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
                view.SetRowCellValue(view.FocusedRowHandle, "FECHA_INICIO", CDate(editor.EditValue).Date())
                view.SetRowCellValue(view.FocusedRowHandle, "FECHA_TERMINO", fechaFinalFeriado)
                view.SetRowCellValue(view.FocusedRowHandle, "FECHA_REGRESO", fechaRetornoFeriado)
                view.SetRowCellValue(view.FocusedRowHandle, "DIAS_RECORRIDO", DateDiff(DateInterval.Day, FechaDateEditControl.EditValue, fechaFinalFeriado.AddDays(1)))
            Else
                If tipoMensaje = Comun.TiposDeDatos.TipoDiaSemana.FESTIVO Then
                    e.Cancel = True
                    gdvDetallePermisoAdmin.SetColumnError(gdvDetallePermisoAdmin.Columns("FECHA_INICIO"), "Fecha incial no puede corresponder a día festivo")
                    MsgBox("Fecha incial no puede corresponder a día festivo.", MsgBoxStyle.Critical, "SIGA")
                Else
                    If tipoMensaje = Comun.TiposDeDatos.TipoDiaSemana.SABADO Then
                        e.Cancel = True
                        gdvDetallePermisoAdmin.SetColumnError(gdvDetallePermisoAdmin.Columns("FECHA_INICIO"), "Fecha incial no puede corresponder a día sábado")
                        MsgBox("Fecha incial no puede corresponder a día sábado.", MsgBoxStyle.Critical, "SIGA")
                    Else
                        If tipoMensaje = Comun.TiposDeDatos.TipoDiaSemana.DOMINGO Then
                            e.Cancel = True
                            gdvDetallePermisoAdmin.SetColumnError(gdvDetallePermisoAdmin.Columns("FECHA_INICIO"), "Fecha incial no puede corresponder a día domingo")
                            MsgBox("Fecha incial no puede corresponder a día domingo.", MsgBoxStyle.Critical, "SIGA")
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnSaldoDiasPermisoAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaldoDiasPermisoAdmin.Click
        Try
            frmSaldoDiasPermisoPaternal.DefInstance.empleado = empleado
            frmSaldoDiasPermisoPaternal.DefInstance.txtAnno.Text = luePeriodo.EditValue
            frmSaldoDiasPermisoPaternal.DefInstance.tipoEventoAdmin = eventoAdmin
            frmSaldoDiasPermisoPaternal.DefInstance.totalDiasAnual = CType(txtTotalDiasAnual.Text, Decimal)
            frmSaldoDiasPermisoPaternal.DefInstance.Owner = Me
            If frmSaldoDiasPermisoPaternal.DefInstance.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido al intentar cargar el formulario permiso paternal" & " " & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            buscaSaldosDias()
            If CType(txtTotalDiasAnual.Text, Decimal) > 0 Then
                btnSaldoDiasPermisoAdmin.Enabled = False
            Else
                btnSaldoDiasPermisoAdmin.Enabled = True
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

    Private Sub txtdiasHabiles_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtdiasHabiles.Validating
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetallePermisoAdmin
        Dim edicion As DevExpress.XtraEditors.BaseEdit = view.ActiveEditor
        Dim FechaDateEditControl As Date
        Dim diasHabilesSolicitados As Decimal = edicion.EditValue
        Dim idEventoAdmin As Integer = view.GetRowCellValue(view.FocusedRowHandle, "EVENTO_ADMINISTRATIVO_DET_ID")
        If diasHabilesSolicitados > 0 And Not view.IsNewItemRow(view.FocusedRowHandle) Then
            e.Cancel = True
            gdvDetallePermisoAdmin.SetColumnError(gdvDetallePermisoAdmin.Columns("DIAS_HABILES"), "Para modificar los días, debe eliminar el registro y volver a ingresarlo")
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

    Private Sub dedFechaNacimientoHijo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dedFechaNacimientoHijo.Validating
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetallePermisoAdmin
        Dim edicion As DevExpress.XtraEditors.BaseEdit = view.ActiveEditor
        If edicion.EditValue <= empleado.fechaNacimiento Then
            e.Cancel = True
            MessageBox.Show("Fecha nacimiento es anterior a fecha nacimiento empleado", "Permiso Paternal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
