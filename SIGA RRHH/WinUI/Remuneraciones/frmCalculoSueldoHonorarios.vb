Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Reportes
Imports cl.presidencia.Argo


Public Class frmCalculoSueldoHonorarios
    Inherits System.Windows.Forms.Form

    Dim empleado As Empleado
    Friend WithEvents gpcBotones As DevExpress.XtraEditors.GroupControl
    Dim parametroMensual As Periodo

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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gdvEmpleados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APELLIDO_PATERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APELLIDO_MATERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CALIDAD_JURIDICA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCalculo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents lblFechaPago As System.Windows.Forms.Label
    Friend WithEvents lblUF As System.Windows.Forms.Label
    Friend WithEvents lblUTM As System.Windows.Forms.Label
    Friend WithEvents txtnombrePeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaPago As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUTM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpcParametroMensual As DevExpress.XtraEditors.GroupControl
    Friend WithEvents progreso As System.Windows.Forms.ProgressBar
    Friend WithEvents lblHoraTerminoEstimada As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblHoraInicio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gdcEmpleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents btnVerLibroremuneraciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NOMBRES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_ING_INSTITUCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEliminaProcesoEmpleadoInactivo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnVerLiquidacion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnVerLiquidaciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTipoCalculo As System.Windows.Forms.Label
    Friend WithEvents rdgTipoProceso As DevExpress.XtraEditors.RadioGroup
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gdcEmpleados = New DevExpress.XtraGrid.GridControl()
        Me.gdvEmpleados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.EMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.APELLIDO_PATERNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.APELLIDO_MATERNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NOMBRES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RUT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CALIDAD_JURIDICA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_ING_INSTITUCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnCalculo = New DevExpress.XtraEditors.SimpleButton()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.lblFechaPago = New System.Windows.Forms.Label()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.lblUTM = New System.Windows.Forms.Label()
        Me.txtnombrePeriodo = New DevExpress.XtraEditors.TextEdit()
        Me.txtFechaPago = New DevExpress.XtraEditors.TextEdit()
        Me.txtUF = New DevExpress.XtraEditors.TextEdit()
        Me.txtUTM = New DevExpress.XtraEditors.TextEdit()
        Me.gpcParametroMensual = New DevExpress.XtraEditors.GroupControl()
        Me.lblTipoCalculo = New System.Windows.Forms.Label()
        Me.rdgTipoProceso = New DevExpress.XtraEditors.RadioGroup()
        Me.progreso = New System.Windows.Forms.ProgressBar()
        Me.lblHoraTerminoEstimada = New DevExpress.XtraEditors.LabelControl()
        Me.lblHoraInicio = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVerLibroremuneraciones = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminaProcesoEmpleadoInactivo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnVerLiquidacion = New DevExpress.XtraEditors.SimpleButton()
        Me.btnVerLiquidaciones = New DevExpress.XtraEditors.SimpleButton()
        Me.gpcBotones = New DevExpress.XtraEditors.GroupControl()
        CType(Me.gdcEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnombrePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUTM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcParametroMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcParametroMensual.SuspendLayout()
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gdcEmpleados
        '
        Me.gdcEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcEmpleados.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gdcEmpleados.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gdcEmpleados.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gdcEmpleados.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gdcEmpleados.EmbeddedNavigator.Buttons.First.Visible = False
        Me.gdcEmpleados.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.gdcEmpleados.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.gdcEmpleados.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.gdcEmpleados.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.gdcEmpleados.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.gdcEmpleados.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gdcEmpleados.Location = New System.Drawing.Point(0, 112)
        Me.gdcEmpleados.MainView = Me.gdvEmpleados
        Me.gdcEmpleados.Name = "gdcEmpleados"
        Me.gdcEmpleados.Size = New System.Drawing.Size(856, 303)
        Me.gdcEmpleados.TabIndex = 0
        Me.gdcEmpleados.UseEmbeddedNavigator = True
        Me.gdcEmpleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvEmpleados, Me.GridView1})
        '
        'gdvEmpleados
        '
        Me.gdvEmpleados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.EMPLEADO_ID, Me.APELLIDO_PATERNO, Me.APELLIDO_MATERNO, Me.NOMBRES, Me.RUT, Me.DV, Me.CALIDAD_JURIDICA_ID, Me.FECHA_ING_INSTITUCION})
        Me.gdvEmpleados.CustomizationFormBounds = New System.Drawing.Rectangle(677, 405, 208, 170)
        Me.gdvEmpleados.GridControl = Me.gdcEmpleados
        Me.gdvEmpleados.GroupPanelText = "Maestro de empleados a honorarios activos"
        Me.gdvEmpleados.Name = "gdvEmpleados"
        Me.gdvEmpleados.OptionsNavigation.EnterMoveNextColumn = True
        Me.gdvEmpleados.OptionsSelection.InvertSelection = True
        Me.gdvEmpleados.OptionsSelection.MultiSelect = True
        Me.gdvEmpleados.OptionsView.ColumnAutoWidth = False
        Me.gdvEmpleados.OptionsView.ShowGroupPanel = False
        Me.gdvEmpleados.SynchronizeClones = False
        '
        'EMPLEADO_ID
        '
        Me.EMPLEADO_ID.Caption = "ID Empleado"
        Me.EMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.EMPLEADO_ID.Name = "EMPLEADO_ID"
        Me.EMPLEADO_ID.OptionsColumn.ReadOnly = True
        '
        'APELLIDO_PATERNO
        '
        Me.APELLIDO_PATERNO.Caption = "Apellido Paterno"
        Me.APELLIDO_PATERNO.FieldName = "APELLIDO_PATERNO"
        Me.APELLIDO_PATERNO.Name = "APELLIDO_PATERNO"
        Me.APELLIDO_PATERNO.OptionsColumn.ReadOnly = True
        Me.APELLIDO_PATERNO.Visible = True
        Me.APELLIDO_PATERNO.VisibleIndex = 0
        Me.APELLIDO_PATERNO.Width = 196
        '
        'APELLIDO_MATERNO
        '
        Me.APELLIDO_MATERNO.Caption = "Apellido Materno"
        Me.APELLIDO_MATERNO.FieldName = "APELLIDO_MATERNO"
        Me.APELLIDO_MATERNO.Name = "APELLIDO_MATERNO"
        Me.APELLIDO_MATERNO.OptionsColumn.ReadOnly = True
        Me.APELLIDO_MATERNO.Visible = True
        Me.APELLIDO_MATERNO.VisibleIndex = 1
        Me.APELLIDO_MATERNO.Width = 213
        '
        'NOMBRES
        '
        Me.NOMBRES.Caption = "Nombre"
        Me.NOMBRES.FieldName = "NOMBRES"
        Me.NOMBRES.Name = "NOMBRES"
        Me.NOMBRES.Visible = True
        Me.NOMBRES.VisibleIndex = 2
        Me.NOMBRES.Width = 169
        '
        'RUT
        '
        Me.RUT.Caption = "Rut"
        Me.RUT.FieldName = "RUT"
        Me.RUT.Name = "RUT"
        Me.RUT.OptionsColumn.ReadOnly = True
        Me.RUT.Visible = True
        Me.RUT.VisibleIndex = 3
        Me.RUT.Width = 120
        '
        'DV
        '
        Me.DV.Caption = "DV"
        Me.DV.FieldName = "DV"
        Me.DV.Name = "DV"
        Me.DV.OptionsColumn.ReadOnly = True
        Me.DV.Visible = True
        Me.DV.VisibleIndex = 4
        Me.DV.Width = 43
        '
        'CALIDAD_JURIDICA_ID
        '
        Me.CALIDAD_JURIDICA_ID.Caption = "ID Calidad Juridica"
        Me.CALIDAD_JURIDICA_ID.FieldName = "CALIDAD_JURIDICA_ID"
        Me.CALIDAD_JURIDICA_ID.Name = "CALIDAD_JURIDICA_ID"
        Me.CALIDAD_JURIDICA_ID.OptionsColumn.ReadOnly = True
        '
        'FECHA_ING_INSTITUCION
        '
        Me.FECHA_ING_INSTITUCION.Caption = "Fecha Ing.Institución"
        Me.FECHA_ING_INSTITUCION.FieldName = "FECHA_ING_INSTITUCION"
        Me.FECHA_ING_INSTITUCION.Name = "FECHA_ING_INSTITUCION"
        Me.FECHA_ING_INSTITUCION.OptionsColumn.ReadOnly = True
        Me.FECHA_ING_INSTITUCION.Visible = True
        Me.FECHA_ING_INSTITUCION.VisibleIndex = 5
        Me.FECHA_ING_INSTITUCION.Width = 116
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcEmpleados
        Me.GridView1.Name = "GridView1"
        '
        'btnCalculo
        '
        Me.btnCalculo.Location = New System.Drawing.Point(11, 60)
        Me.btnCalculo.Name = "btnCalculo"
        Me.btnCalculo.Size = New System.Drawing.Size(240, 23)
        Me.btnCalculo.TabIndex = 1
        Me.btnCalculo.Text = "Procesar a Empleados seleccionados"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPeriodo.Location = New System.Drawing.Point(80, 44)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 16)
        Me.lblPeriodo.TabIndex = 2
        Me.lblPeriodo.Text = "Período"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFechaPago
        '
        Me.lblFechaPago.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblFechaPago.Location = New System.Drawing.Point(48, 76)
        Me.lblFechaPago.Name = "lblFechaPago"
        Me.lblFechaPago.Size = New System.Drawing.Size(80, 16)
        Me.lblFechaPago.TabIndex = 3
        Me.lblFechaPago.Text = "Fecha Pago"
        Me.lblFechaPago.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblUF
        '
        Me.lblUF.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblUF.Location = New System.Drawing.Point(315, 44)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(80, 16)
        Me.lblUF.TabIndex = 4
        Me.lblUF.Text = "Valor U.F."
        Me.lblUF.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblUTM
        '
        Me.lblUTM.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblUTM.Location = New System.Drawing.Point(315, 76)
        Me.lblUTM.Name = "lblUTM"
        Me.lblUTM.Size = New System.Drawing.Size(80, 16)
        Me.lblUTM.TabIndex = 5
        Me.lblUTM.Text = "Valor U.T.M."
        Me.lblUTM.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtnombrePeriodo
        '
        Me.txtnombrePeriodo.Location = New System.Drawing.Point(136, 40)
        Me.txtnombrePeriodo.Name = "txtnombrePeriodo"
        Me.txtnombrePeriodo.Properties.ReadOnly = True
        Me.txtnombrePeriodo.Size = New System.Drawing.Size(100, 20)
        Me.txtnombrePeriodo.TabIndex = 6
        '
        'txtFechaPago
        '
        Me.txtFechaPago.Location = New System.Drawing.Point(136, 72)
        Me.txtFechaPago.Name = "txtFechaPago"
        Me.txtFechaPago.Properties.Mask.EditMask = "d"
        Me.txtFechaPago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.txtFechaPago.Properties.ReadOnly = True
        Me.txtFechaPago.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaPago.TabIndex = 7
        '
        'txtUF
        '
        Me.txtUF.Location = New System.Drawing.Point(400, 32)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Properties.Mask.EditMask = "n2"
        Me.txtUF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtUF.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtUF.Properties.ReadOnly = True
        Me.txtUF.Size = New System.Drawing.Size(100, 20)
        Me.txtUF.TabIndex = 8
        '
        'txtUTM
        '
        Me.txtUTM.Location = New System.Drawing.Point(400, 64)
        Me.txtUTM.Name = "txtUTM"
        Me.txtUTM.Properties.Mask.EditMask = "n0"
        Me.txtUTM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtUTM.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtUTM.Properties.ReadOnly = True
        Me.txtUTM.Size = New System.Drawing.Size(100, 20)
        Me.txtUTM.TabIndex = 9
        '
        'gpcParametroMensual
        '
        Me.gpcParametroMensual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcParametroMensual.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcParametroMensual.AppearanceCaption.Options.UseFont = True
        Me.gpcParametroMensual.Controls.Add(Me.lblTipoCalculo)
        Me.gpcParametroMensual.Controls.Add(Me.txtUTM)
        Me.gpcParametroMensual.Controls.Add(Me.rdgTipoProceso)
        Me.gpcParametroMensual.Controls.Add(Me.txtUF)
        Me.gpcParametroMensual.Location = New System.Drawing.Point(0, 8)
        Me.gpcParametroMensual.Name = "gpcParametroMensual"
        Me.gpcParametroMensual.Size = New System.Drawing.Size(856, 96)
        Me.gpcParametroMensual.TabIndex = 10
        Me.gpcParametroMensual.Text = "Parámetro Mensual"
        '
        'lblTipoCalculo
        '
        Me.lblTipoCalculo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTipoCalculo.Location = New System.Drawing.Point(568, 40)
        Me.lblTipoCalculo.Name = "lblTipoCalculo"
        Me.lblTipoCalculo.Size = New System.Drawing.Size(80, 16)
        Me.lblTipoCalculo.TabIndex = 10
        Me.lblTipoCalculo.Text = "Tipo Cálculo"
        Me.lblTipoCalculo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'rdgTipoProceso
        '
        Me.rdgTipoProceso.EditValue = "H"
        Me.rdgTipoProceso.Enabled = False
        Me.rdgTipoProceso.Location = New System.Drawing.Point(656, 32)
        Me.rdgTipoProceso.Name = "rdgTipoProceso"
        Me.rdgTipoProceso.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("H", "Honorario Suma Alzada")})
        Me.rdgTipoProceso.Size = New System.Drawing.Size(144, 32)
        Me.rdgTipoProceso.TabIndex = 9
        '
        'progreso
        '
        Me.progreso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progreso.Location = New System.Drawing.Point(11, 28)
        Me.progreso.Name = "progreso"
        Me.progreso.Size = New System.Drawing.Size(837, 24)
        Me.progreso.TabIndex = 11
        '
        'lblHoraTerminoEstimada
        '
        Me.lblHoraTerminoEstimada.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.lblHoraTerminoEstimada.Location = New System.Drawing.Point(459, 84)
        Me.lblHoraTerminoEstimada.Name = "lblHoraTerminoEstimada"
        Me.lblHoraTerminoEstimada.Size = New System.Drawing.Size(4, 17)
        Me.lblHoraTerminoEstimada.TabIndex = 12
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.lblHoraInicio.Location = New System.Drawing.Point(275, 84)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(4, 17)
        Me.lblHoraInicio.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(275, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Hora Inicio"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(459, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Hora Término Estimada"
        '
        'btnVerLibroremuneraciones
        '
        Me.btnVerLibroremuneraciones.Location = New System.Drawing.Point(11, 84)
        Me.btnVerLibroremuneraciones.Name = "btnVerLibroremuneraciones"
        Me.btnVerLibroremuneraciones.Size = New System.Drawing.Size(240, 23)
        Me.btnVerLibroremuneraciones.TabIndex = 17
        Me.btnVerLibroremuneraciones.Text = "Ver Libro de Honorarios"
        '
        'btnEliminaProcesoEmpleadoInactivo
        '
        Me.btnEliminaProcesoEmpleadoInactivo.Location = New System.Drawing.Point(11, 132)
        Me.btnEliminaProcesoEmpleadoInactivo.Name = "btnEliminaProcesoEmpleadoInactivo"
        Me.btnEliminaProcesoEmpleadoInactivo.Size = New System.Drawing.Size(240, 23)
        Me.btnEliminaProcesoEmpleadoInactivo.TabIndex = 18
        Me.btnEliminaProcesoEmpleadoInactivo.Text = "Elimina Proceso Empleado Inactivo"
        '
        'btnVerLiquidacion
        '
        Me.btnVerLiquidacion.Location = New System.Drawing.Point(131, 108)
        Me.btnVerLiquidacion.Name = "btnVerLiquidacion"
        Me.btnVerLiquidacion.Size = New System.Drawing.Size(120, 23)
        Me.btnVerLiquidacion.TabIndex = 20
        Me.btnVerLiquidacion.Text = "Ver Liquidación (SEL)"
        '
        'btnVerLiquidaciones
        '
        Me.btnVerLiquidaciones.Location = New System.Drawing.Point(11, 108)
        Me.btnVerLiquidaciones.Name = "btnVerLiquidaciones"
        Me.btnVerLiquidaciones.Size = New System.Drawing.Size(120, 23)
        Me.btnVerLiquidaciones.TabIndex = 19
        Me.btnVerLiquidaciones.Text = "Ver Liquidaciones"
        '
        'gpcBotones
        '
        Me.gpcBotones.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcBotones.AppearanceCaption.Options.UseFont = True
        Me.gpcBotones.Controls.Add(Me.Label2)
        Me.gpcBotones.Controls.Add(Me.btnVerLiquidacion)
        Me.gpcBotones.Controls.Add(Me.btnCalculo)
        Me.gpcBotones.Controls.Add(Me.btnVerLiquidaciones)
        Me.gpcBotones.Controls.Add(Me.progreso)
        Me.gpcBotones.Controls.Add(Me.btnEliminaProcesoEmpleadoInactivo)
        Me.gpcBotones.Controls.Add(Me.lblHoraTerminoEstimada)
        Me.gpcBotones.Controls.Add(Me.btnVerLibroremuneraciones)
        Me.gpcBotones.Controls.Add(Me.lblHoraInicio)
        Me.gpcBotones.Controls.Add(Me.Label1)
        Me.gpcBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gpcBotones.Location = New System.Drawing.Point(0, 421)
        Me.gpcBotones.Name = "gpcBotones"
        Me.gpcBotones.Size = New System.Drawing.Size(856, 167)
        Me.gpcBotones.TabIndex = 21
        Me.gpcBotones.Text = "Opciones a Procesar"
        '
        'frmCalculoSueldoHonorarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 588)
        Me.Controls.Add(Me.gpcBotones)
        Me.Controls.Add(Me.txtFechaPago)
        Me.Controls.Add(Me.txtnombrePeriodo)
        Me.Controls.Add(Me.lblUTM)
        Me.Controls.Add(Me.lblUF)
        Me.Controls.Add(Me.lblFechaPago)
        Me.Controls.Add(Me.lblPeriodo)
        Me.Controls.Add(Me.gdcEmpleados)
        Me.Controls.Add(Me.gpcParametroMensual)
        Me.Name = "frmCalculoSueldoHonorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cálculo Remuneraciones / Honorarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnombrePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUTM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcParametroMensual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcParametroMensual.ResumeLayout(False)
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBotones.ResumeLayout(False)
        Me.gpcBotones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCalculoSueldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empleado = New Empleado
        parametroMensual = New Periodo
        Dim fechaFinalIngreso As Date
        Dim diasMes As Integer = fechaFinalIngreso.DaysInMonth(parametroMensual.ano, parametroMensual.mes)
        fechaFinalIngreso = New Date(CInt(parametroMensual.ano), parametroMensual.mes, diasMes)
        gdcEmpleados.DataSource = empleado.recuperaMaestroEmpleadoHonorarios(fechaFinalIngreso)
        txtnombrePeriodo.Text = UCase(parametroMensual.nombrePeriodo)
        txtFechaPago.Text = CType(parametroMensual.fechaPagoSueldo, Date)
        txtUF.text = parametroMensual.UF
        txtUTM.text = parametroMensual.UTM
    End Sub


    Private Sub btnCalculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculo.Click
        
        Dim numRegistros As Integer = gdvEmpleados.GetSelectedRows().Length
        If numRegistros <= 0 Then
            MessageBox.Show("Debe seleccionar a lo menos una fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If System.Windows.Forms.MessageBox.Show("¿Está seguro que desea iniciar el proceso?", "Remuneraciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            btnCalculo.Enabled = False
            progreso.Minimum = 0

            'filas() representa una lista de los  rowHandle seleccionados
            Dim filas() As Integer = gdvEmpleados.GetSelectedRows()
            progreso.Maximum = filas.Length - 1
            Dim empleado As Empleado
            Dim i, cantidadRegistros As Integer
            lblHoraInicio.Text = (New Date().Now).ToLongTimeString
            Dim segundosDiferencia As Integer
            For i = 0 To filas.Length - 1
                Dim inicio As New Date
                inicio = Now
                Debug.WriteLine("HORA INICIO: " & Now)
                Dim row As DataRow = gdvEmpleados.GetDataRow(filas(i))
                Debug.WriteLine(row("APELLIDO_PATERNO") & " " & row("APELLIDO_MATERNO"))
                empleado = New Empleado(row("EMPLEADO_ID"), True)
                Remuneracion.calculoHonorario(empleado, parametroMensual, Comun.TipoProceso.NORMAL_HONORARIOS)
                cantidadRegistros += 1
                Debug.WriteLine("HORA TERMINO: " & Now)
                Windows.Forms.Application.DoEvents()
                progreso.Value = i
                Dim termino As New Date
                termino = Now
                segundosDiferencia = termino.Subtract(inicio).Seconds
                Dim horaTerminoEstimado As Date
                horaTerminoEstimado = termino.AddSeconds(segundosDiferencia * (filas.Length - (i + 1)))
                lblHoraTerminoEstimada.Text = horaTerminoEstimado.ToLongTimeString
            Next i
            System.Windows.Forms.MessageBox.Show("Cálculo Finalizado. Se han procesado " & cantidadRegistros & " de remuneraciones.", "Sistema de Remuneraciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnCalculo.Enabled = True
        End If

    End Sub

    Private Sub btnVerLibroremuneraciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerLibroremuneraciones.Click
        Dim frmfiltroLibroHonorarios As New frmFiltroLibroHonorarios
        frmfiltroLibroHonorarios.Show()
    End Sub

    Private Sub btnEliminaProcesoEmpleadoInactivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminaProcesoEmpleadoInactivo.Click
        Try
            frmEmpleadoInactivoConLiquidacion.DefInstance.idPeriodo = parametroMensual.ID
            frmEmpleadoInactivoConLiquidacion.DefInstance.empleado = empleado
            frmEmpleadoInactivoConLiquidacion.DefInstance.tipoProceso = Comun.TipoProceso.NORMAL_HONORARIOS
            frmEmpleadoInactivoConLiquidacion.DefInstance.Owner = Me
            If frmEmpleadoInactivoConLiquidacion.DefInstance.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido al intentar carga el formulario. " & ex.Message, MsgBoxStyle.Exclamation)
        Finally

        End Try

    End Sub

    Private Sub btnVerLiquidaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerLiquidaciones.Click
        If Not empleado Is Nothing Then
            Dim ventanaReporte1 As New ventanaReporte
            Dim reporte As New rptLiquidacion
            WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
            ventanaReporte1.rptVisor.SelectionFormula = "{RH_REM_PERIODO.PERIODO_ID}=" & (New Periodo().ID) & " AND {RH_REM_LIQUIDACION_ENC.TIPO_CALCULO}=" & """" & CType(rdgTipoProceso.EditValue, String) & """"
            ventanaReporte1.rptVisor.ShowParameterPanelButton = False
            ventanaReporte1.rptVisor.ShowCloseButton = False
            ventanaReporte1.rptVisor.ShowGroupTreeButton = False
            ventanaReporte1.rptVisor.ReportSource = reporte
            reporte.SummaryInfo.ReportTitle = "LIQUIDACIÓN HONORARIO SUMA ALZADA A " & UCase(parametroMensual.nombrePeriodo)
            ventanaReporte1.Show()
        End If
    End Sub

    Private Sub btnVerLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerLiquidacion.Click
        Dim row As DataRow
        Dim filas() As Integer = gdvEmpleados.GetSelectedRows()
        If filas.Length > 0 Then
            row = gdvEmpleados.GetDataRow(filas(0))
            If Not empleado Is Nothing Then
                Dim ventanaReporte1 As New ventanaReporte
                Dim reporte As New rptLiquidacion
                WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
                ventanaReporte1.rptVisor.SelectionFormula = "{RH_REM_PERIODO.PERIODO_ID}=" & (New Periodo().ID) & " AND {RH_PER_EMPLEADO.EMPLEADO_ID}=" & row("EMPLEADO_ID") & " AND {RH_REM_LIQUIDACION_ENC.TIPO_CALCULO}=" & """" & CType(rdgTipoProceso.EditValue, String) & """"
                reporte.SummaryInfo.ReportTitle = "LIQUIDACIÓN HONORARIO SUMA ALZADA A " & UCase(parametroMensual.nombrePeriodo)
                ventanaReporte1.rptVisor.ShowParameterPanelButton = False
                ventanaReporte1.rptVisor.ShowCloseButton = False
                ventanaReporte1.rptVisor.ShowGroupTreeButton = False
                ventanaReporte1.rptVisor.ReportSource = reporte
                ventanaReporte1.Show()
            End If
        End If
        row = Nothing
    End Sub
End Class
