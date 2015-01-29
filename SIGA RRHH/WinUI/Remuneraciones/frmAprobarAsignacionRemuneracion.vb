Imports cl.presidencia.Argo.DataAccess
Imports cl.presidencia.Argo.BusinessRules
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmAprobarAsignacionRemuneracion
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
    Friend WithEvents gdcAprobacionPagoRemun As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gdvDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colANTECEDENTE_REMUN_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO_REGISTRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUMERO_BIENIOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_CUMPLIO_BIENIOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSUARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_MODIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAUTORIZA_PAGO_BIENIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOBSERVACION_AUTORIZA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rglEmpleados As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents rgvEmpleado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEMPLEADO_ID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_COMPLETO_EMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkAutoriza As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents rglPeriodo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPERIODO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO_PERIODO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblPeriodo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colNOMBRE_EMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION_PERIODO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gpcFiltro As DevExpress.XtraEditors.GroupControl
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dvPeriodo As System.Data.DataView
    Friend WithEvents chkSoloEmpleadosActivos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colESTADO_EMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkSoloRegistrosPendientes As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnActualizar As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gdcAprobacionPagoRemun = New DevExpress.XtraGrid.GridControl
        Me.gdvDetalle = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colANTECEDENTE_REMUN_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colESTADO_REGISTRO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDESCRIPCION_PERIODO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_EMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNUMERO_BIENIOS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_CUMPLIO_BIENIOS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAUTORIZA_PAGO_BIENIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkAutoriza = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colOBSERVACION_AUTORIZA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colESTADO_EMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSUARIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_MODIFICACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rglEmpleados = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.rgvEmpleado = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colEMPLEADO_ID1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_COMPLETO_EMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rglPeriodo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPERIODO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colESTADO_PERIODO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gpcFiltro = New DevExpress.XtraEditors.GroupControl
        Me.btnActualizar = New DevExpress.XtraEditors.SimpleButton
        Me.chkSoloRegistrosPendientes = New DevExpress.XtraEditors.CheckEdit
        Me.chkSoloEmpleadosActivos = New DevExpress.XtraEditors.CheckEdit
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPeriodo = New DevExpress.XtraEditors.LabelControl
        Me.dvPeriodo = New System.Data.DataView
        CType(Me.gdcAprobacionPagoRemun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAutoriza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rglEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rglPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcFiltro.SuspendLayout()
        CType(Me.chkSoloRegistrosPendientes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSoloEmpleadosActivos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcAprobacionPagoRemun
        '
        Me.gdcAprobacionPagoRemun.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'gdcAprobacionPagoRemun.EmbeddedNavigator
        '
        Me.gdcAprobacionPagoRemun.EmbeddedNavigator.Name = ""
        Me.gdcAprobacionPagoRemun.Location = New System.Drawing.Point(0, 80)
        Me.gdcAprobacionPagoRemun.MainView = Me.gdvDetalle
        Me.gdcAprobacionPagoRemun.Name = "gdcAprobacionPagoRemun"
        Me.gdcAprobacionPagoRemun.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rglEmpleados, Me.chkAutoriza, Me.rglPeriodo})
        Me.gdcAprobacionPagoRemun.Size = New System.Drawing.Size(832, 272)
        Me.gdcAprobacionPagoRemun.TabIndex = 0
        Me.gdcAprobacionPagoRemun.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalle, Me.GridView1})
        '
        'gdvDetalle
        '
        Me.gdvDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colANTECEDENTE_REMUN_ID, Me.colESTADO_REGISTRO, Me.colEMPLEADO_ID, Me.colDESCRIPCION_PERIODO, Me.colNOMBRE_EMPLEADO, Me.colNUMERO_BIENIOS, Me.colFECHA_CUMPLIO_BIENIOS, Me.colAUTORIZA_PAGO_BIENIO, Me.colOBSERVACION_AUTORIZA, Me.colESTADO_EMPLEADO, Me.colUSUARIO, Me.colFECHA_MODIFICACION})
        Me.gdvDetalle.GridControl = Me.gdcAprobacionPagoRemun
        Me.gdvDetalle.Name = "gdvDetalle"
        Me.gdvDetalle.OptionsView.ColumnAutoWidth = False
        Me.gdvDetalle.OptionsView.ShowGroupPanel = False
        '
        'colANTECEDENTE_REMUN_ID
        '
        Me.colANTECEDENTE_REMUN_ID.Caption = "ANTECEDENTE_REMUN_ID"
        Me.colANTECEDENTE_REMUN_ID.FieldName = "ANTECEDENTE_REMUN_ID"
        Me.colANTECEDENTE_REMUN_ID.Name = "colANTECEDENTE_REMUN_ID"
        Me.colANTECEDENTE_REMUN_ID.OptionsColumn.AllowEdit = False
        Me.colANTECEDENTE_REMUN_ID.OptionsColumn.AllowMove = False
        Me.colANTECEDENTE_REMUN_ID.OptionsColumn.ReadOnly = True
        '
        'colESTADO_REGISTRO
        '
        Me.colESTADO_REGISTRO.Caption = "ESTADO_REGISTRO"
        Me.colESTADO_REGISTRO.FieldName = "ESTADO_REGISTRO"
        Me.colESTADO_REGISTRO.Name = "colESTADO_REGISTRO"
        Me.colESTADO_REGISTRO.OptionsColumn.AllowEdit = False
        Me.colESTADO_REGISTRO.OptionsColumn.AllowMove = False
        Me.colESTADO_REGISTRO.OptionsColumn.ReadOnly = True
        '
        'colEMPLEADO_ID
        '
        Me.colEMPLEADO_ID.Caption = "Nombre Empleado"
        Me.colEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.colEMPLEADO_ID.Name = "colEMPLEADO_ID"
        Me.colEMPLEADO_ID.OptionsColumn.AllowEdit = False
        Me.colEMPLEADO_ID.OptionsColumn.AllowMove = False
        Me.colEMPLEADO_ID.OptionsColumn.ReadOnly = True
        Me.colEMPLEADO_ID.OptionsColumn.ShowInCustomizationForm = False
        Me.colEMPLEADO_ID.Width = 331
        '
        'colDESCRIPCION_PERIODO
        '
        Me.colDESCRIPCION_PERIODO.Caption = "Periodo"
        Me.colDESCRIPCION_PERIODO.FieldName = "DESCRIPCION_PERIODO"
        Me.colDESCRIPCION_PERIODO.Name = "colDESCRIPCION_PERIODO"
        Me.colDESCRIPCION_PERIODO.OptionsColumn.AllowEdit = False
        Me.colDESCRIPCION_PERIODO.OptionsColumn.ReadOnly = True
        Me.colDESCRIPCION_PERIODO.Width = 58
        '
        'colNOMBRE_EMPLEADO
        '
        Me.colNOMBRE_EMPLEADO.Caption = "Nombre Empleado"
        Me.colNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.colNOMBRE_EMPLEADO.Name = "colNOMBRE_EMPLEADO"
        Me.colNOMBRE_EMPLEADO.OptionsColumn.AllowEdit = False
        Me.colNOMBRE_EMPLEADO.OptionsColumn.ReadOnly = True
        Me.colNOMBRE_EMPLEADO.Visible = True
        Me.colNOMBRE_EMPLEADO.VisibleIndex = 0
        Me.colNOMBRE_EMPLEADO.Width = 285
        '
        'colNUMERO_BIENIOS
        '
        Me.colNUMERO_BIENIOS.Caption = "# Bienios"
        Me.colNUMERO_BIENIOS.FieldName = "NUMERO_BIENIOS"
        Me.colNUMERO_BIENIOS.Name = "colNUMERO_BIENIOS"
        Me.colNUMERO_BIENIOS.OptionsColumn.AllowEdit = False
        Me.colNUMERO_BIENIOS.OptionsColumn.AllowMove = False
        Me.colNUMERO_BIENIOS.OptionsColumn.ReadOnly = True
        Me.colNUMERO_BIENIOS.Visible = True
        Me.colNUMERO_BIENIOS.VisibleIndex = 1
        Me.colNUMERO_BIENIOS.Width = 76
        '
        'colFECHA_CUMPLIO_BIENIOS
        '
        Me.colFECHA_CUMPLIO_BIENIOS.Caption = "Fecha Bienio"
        Me.colFECHA_CUMPLIO_BIENIOS.FieldName = "FECHA_CUMPLIO_BIENIOS"
        Me.colFECHA_CUMPLIO_BIENIOS.Name = "colFECHA_CUMPLIO_BIENIOS"
        Me.colFECHA_CUMPLIO_BIENIOS.OptionsColumn.AllowEdit = False
        Me.colFECHA_CUMPLIO_BIENIOS.OptionsColumn.AllowMove = False
        Me.colFECHA_CUMPLIO_BIENIOS.OptionsColumn.ReadOnly = True
        Me.colFECHA_CUMPLIO_BIENIOS.Visible = True
        Me.colFECHA_CUMPLIO_BIENIOS.VisibleIndex = 2
        Me.colFECHA_CUMPLIO_BIENIOS.Width = 105
        '
        'colAUTORIZA_PAGO_BIENIO
        '
        Me.colAUTORIZA_PAGO_BIENIO.Caption = "Autorizar"
        Me.colAUTORIZA_PAGO_BIENIO.ColumnEdit = Me.chkAutoriza
        Me.colAUTORIZA_PAGO_BIENIO.FieldName = "AUTORIZA_PAGO_BIENIO"
        Me.colAUTORIZA_PAGO_BIENIO.Name = "colAUTORIZA_PAGO_BIENIO"
        Me.colAUTORIZA_PAGO_BIENIO.OptionsColumn.AllowMove = False
        Me.colAUTORIZA_PAGO_BIENIO.Visible = True
        Me.colAUTORIZA_PAGO_BIENIO.VisibleIndex = 3
        Me.colAUTORIZA_PAGO_BIENIO.Width = 70
        '
        'chkAutoriza
        '
        Me.chkAutoriza.AutoHeight = False
        Me.chkAutoriza.Name = "chkAutoriza"
        '
        'colOBSERVACION_AUTORIZA
        '
        Me.colOBSERVACION_AUTORIZA.Caption = "Observaciones"
        Me.colOBSERVACION_AUTORIZA.FieldName = "OBSERVACION_AUTORIZA"
        Me.colOBSERVACION_AUTORIZA.Name = "colOBSERVACION_AUTORIZA"
        Me.colOBSERVACION_AUTORIZA.OptionsColumn.AllowEdit = False
        Me.colOBSERVACION_AUTORIZA.OptionsColumn.AllowMove = False
        Me.colOBSERVACION_AUTORIZA.OptionsColumn.ReadOnly = True
        Me.colOBSERVACION_AUTORIZA.Visible = True
        Me.colOBSERVACION_AUTORIZA.VisibleIndex = 4
        Me.colOBSERVACION_AUTORIZA.Width = 316
        '
        'colESTADO_EMPLEADO
        '
        Me.colESTADO_EMPLEADO.Caption = "Estado Empleado"
        Me.colESTADO_EMPLEADO.FieldName = "ESTADO_EMPLEADO"
        Me.colESTADO_EMPLEADO.Name = "colESTADO_EMPLEADO"
        Me.colESTADO_EMPLEADO.OptionsColumn.AllowEdit = False
        Me.colESTADO_EMPLEADO.OptionsColumn.ReadOnly = True
        Me.colESTADO_EMPLEADO.Visible = True
        Me.colESTADO_EMPLEADO.VisibleIndex = 5
        Me.colESTADO_EMPLEADO.Width = 117
        '
        'colUSUARIO
        '
        Me.colUSUARIO.Caption = "Usuario"
        Me.colUSUARIO.FieldName = "USUARIO"
        Me.colUSUARIO.Name = "colUSUARIO"
        Me.colUSUARIO.OptionsColumn.AllowEdit = False
        Me.colUSUARIO.OptionsColumn.AllowMove = False
        Me.colUSUARIO.OptionsColumn.ReadOnly = True
        Me.colUSUARIO.Visible = True
        Me.colUSUARIO.VisibleIndex = 6
        Me.colUSUARIO.Width = 99
        '
        'colFECHA_MODIFICACION
        '
        Me.colFECHA_MODIFICACION.Caption = "Fecha Actualización"
        Me.colFECHA_MODIFICACION.FieldName = "FECHA_MODIFICACION"
        Me.colFECHA_MODIFICACION.Name = "colFECHA_MODIFICACION"
        Me.colFECHA_MODIFICACION.OptionsColumn.AllowEdit = False
        Me.colFECHA_MODIFICACION.OptionsColumn.AllowMove = False
        Me.colFECHA_MODIFICACION.OptionsColumn.ReadOnly = True
        Me.colFECHA_MODIFICACION.Visible = True
        Me.colFECHA_MODIFICACION.VisibleIndex = 7
        Me.colFECHA_MODIFICACION.Width = 116
        '
        'rglEmpleados
        '
        Me.rglEmpleados.AutoHeight = False
        Me.rglEmpleados.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rglEmpleados.DisplayMember = "EMPLEADO_ID"
        Me.rglEmpleados.Name = "rglEmpleados"
        Me.rglEmpleados.View = Me.rgvEmpleado
        '
        'rgvEmpleado
        '
        Me.rgvEmpleado.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEMPLEADO_ID1, Me.colNOMBRE_COMPLETO_EMPLEADO})
        Me.rgvEmpleado.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.rgvEmpleado.Name = "rgvEmpleado"
        Me.rgvEmpleado.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.rgvEmpleado.OptionsView.ShowGroupPanel = False
        '
        'colEMPLEADO_ID1
        '
        Me.colEMPLEADO_ID1.Caption = "EMPLEADO_ID"
        Me.colEMPLEADO_ID1.FieldName = "EMPLEADO_ID"
        Me.colEMPLEADO_ID1.Name = "colEMPLEADO_ID1"
        Me.colEMPLEADO_ID1.OptionsColumn.ReadOnly = True
        '
        'colNOMBRE_COMPLETO_EMPLEADO
        '
        Me.colNOMBRE_COMPLETO_EMPLEADO.Caption = "Nombre Empleado"
        Me.colNOMBRE_COMPLETO_EMPLEADO.FieldName = "NOMBRE_COMPLETO_EMPLEADO"
        Me.colNOMBRE_COMPLETO_EMPLEADO.Name = "colNOMBRE_COMPLETO_EMPLEADO"
        Me.colNOMBRE_COMPLETO_EMPLEADO.OptionsColumn.AllowEdit = False
        Me.colNOMBRE_COMPLETO_EMPLEADO.OptionsColumn.ReadOnly = True
        Me.colNOMBRE_COMPLETO_EMPLEADO.Visible = True
        Me.colNOMBRE_COMPLETO_EMPLEADO.VisibleIndex = 0
        '
        'rglPeriodo
        '
        Me.rglPeriodo.AutoHeight = False
        Me.rglPeriodo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rglPeriodo.DisplayMember = "DESCRIPCION_PERIODO"
        Me.rglPeriodo.Name = "rglPeriodo"
        Me.rglPeriodo.ValueMember = "PERIODO_ID"
        Me.rglPeriodo.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPERIODO_ID, Me.colESTADO_PERIODO})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colPERIODO_ID
        '
        Me.colPERIODO_ID.Caption = "PERIODO_ID"
        Me.colPERIODO_ID.FieldName = "PERIODO_ID"
        Me.colPERIODO_ID.Name = "colPERIODO_ID"
        Me.colPERIODO_ID.OptionsColumn.AllowEdit = False
        Me.colPERIODO_ID.OptionsColumn.ReadOnly = True
        '
        'colESTADO_PERIODO
        '
        Me.colESTADO_PERIODO.Caption = "Periodo"
        Me.colESTADO_PERIODO.FieldName = "ESTADO_PERIODO"
        Me.colESTADO_PERIODO.Name = "colESTADO_PERIODO"
        Me.colESTADO_PERIODO.OptionsColumn.AllowEdit = False
        Me.colESTADO_PERIODO.OptionsColumn.ReadOnly = True
        Me.colESTADO_PERIODO.Visible = True
        Me.colESTADO_PERIODO.VisibleIndex = 0
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcAprobacionPagoRemun
        Me.GridView1.Name = "GridView1"
        '
        'gpcFiltro
        '
        Me.gpcFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcFiltro.Controls.Add(Me.btnActualizar)
        Me.gpcFiltro.Controls.Add(Me.chkSoloRegistrosPendientes)
        Me.gpcFiltro.Controls.Add(Me.chkSoloEmpleadosActivos)
        Me.gpcFiltro.Controls.Add(Me.luePeriodo)
        Me.gpcFiltro.Controls.Add(Me.lblPeriodo)
        Me.gpcFiltro.Location = New System.Drawing.Point(0, 0)
        Me.gpcFiltro.Name = "gpcFiltro"
        Me.gpcFiltro.Size = New System.Drawing.Size(832, 80)
        Me.gpcFiltro.TabIndex = 1
        Me.gpcFiltro.Text = "Filtro Periodo"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(272, 36)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(200, 23)
        Me.btnActualizar.TabIndex = 6
        Me.btnActualizar.Text = "Actualizar Registros Seleccionados"
        '
        'chkSoloRegistrosPendientes
        '
        Me.chkSoloRegistrosPendientes.Location = New System.Drawing.Point(504, 40)
        Me.chkSoloRegistrosPendientes.Name = "chkSoloRegistrosPendientes"
        '
        'chkSoloRegistrosPendientes.Properties
        '
        Me.chkSoloRegistrosPendientes.Properties.Caption = "Solo registros pendientes"
        Me.chkSoloRegistrosPendientes.Size = New System.Drawing.Size(152, 19)
        Me.chkSoloRegistrosPendientes.TabIndex = 5
        '
        'chkSoloEmpleadosActivos
        '
        Me.chkSoloEmpleadosActivos.Location = New System.Drawing.Point(664, 40)
        Me.chkSoloEmpleadosActivos.Name = "chkSoloEmpleadosActivos"
        '
        'chkSoloEmpleadosActivos.Properties
        '
        Me.chkSoloEmpleadosActivos.Properties.Caption = "Solo empleados activos"
        Me.chkSoloEmpleadosActivos.Size = New System.Drawing.Size(152, 19)
        Me.chkSoloEmpleadosActivos.TabIndex = 4
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(104, 39)
        Me.luePeriodo.Name = "luePeriodo"
        '
        'luePeriodo.Properties
        '
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(144, 20)
        Me.luePeriodo.TabIndex = 3
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(56, 40)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 14)
        Me.lblPeriodo.TabIndex = 1
        Me.lblPeriodo.Text = "Periodo"
        '
        'frmAprobarAsignacionRemuneracion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(832, 354)
        Me.Controls.Add(Me.gpcFiltro)
        Me.Controls.Add(Me.gdcAprobacionPagoRemun)
        Me.Name = "frmAprobarAsignacionRemuneracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aprobar Pago Bienio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcAprobacionPagoRemun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAutoriza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rglEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rglPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcFiltro.ResumeLayout(False)
        CType(Me.chkSoloRegistrosPendientes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSoloEmpleadosActivos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private empleado As empleado
    Private periodo As Periodo

    Private Sub frmAprobarAsignacionRemuneracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarPeriodos()
        luePeriodo.EditValue = -1
        chkSoloEmpleadosActivos.Checked = True
        chkSoloRegistrosPendientes.Checked = True
    End Sub

    Private Sub llenarPeriodos()
        With luePeriodo
            With .Properties.Columns
                .Add(New LookUpColumnInfo("PERIODO_ID", "ID Periodo", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ANO", "Año", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("MES", "Mes", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ESTADO_PERIODO", "Estado Periodo", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION_PERIODO", "Periodo", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        luePeriodo.Properties.DataSource = repositorio.dvPeriodo
        luePeriodo.Properties.DisplayMember = "DESCRIPCION_PERIODO"
        luePeriodo.Properties.NullText = ""
        luePeriodo.Properties.PopupWidth = 150
        luePeriodo.Properties.ValueMember = "PERIODO_ID"
    End Sub

    Private Sub luePeriodo_EditValueChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged, chkSoloEmpleadosActivos.EditValueChanged, chkSoloRegistrosPendientes.EditValueChanged
        If luePeriodo.EditValue > 0 Then
            periodo = New periodo(CType(luePeriodo.EditValue, Integer))
            If periodo.estadoPeriodo = True Then
                Me.btnActualizar.Enabled = True
            Else
                Me.btnActualizar.Enabled = False
            End If
            empleado = New empleado
            llenarGrilla()
            If chkSoloEmpleadosActivos.Checked Then
                Me.colESTADO_EMPLEADO.Visible = False
            Else
                Me.colESTADO_EMPLEADO.Visible = True
            End If
        End If
    End Sub

    Private Sub gdvDetalle_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gdvDetalle.ShowingEditor
        Dim view As GridView = sender
        If view.FocusedColumn.FieldName = "AUTORIZA_PAGO_BIENIO" Then
            e.Cancel = ObtieneValorCelda(view, view.FocusedRowHandle)
        End If
    End Sub

    Private Shared Function ObtieneValorCelda(ByVal view As GridView, ByVal row As Integer) As Boolean
        Dim cellAutorizaPago As GridColumn = view.Columns("AUTORIZA_PAGO_BIENIO")
        Dim Autoriza As Boolean = view.GetRowCellValue(row, cellAutorizaPago)
        Dim cancelaIngreso As Boolean
        If Autoriza = True Then
            cancelaIngreso = True
        Else
            cancelaIngreso = False
        End If
        Return cancelaIngreso
    End Function

    Private Function ActivarBotonActualizar() As Boolean
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = Me.gdvDetalle
        Dim siActualiza As Boolean = False
        For i As Integer = 0 To Me.gdvDetalle.RowCount - 1
            If view.GetRowCellValue(i, "AUTORIZA_PAGO_BIENIO") = True Then
                siActualiza = True
                Exit For
            End If
        Next
        Return siActualiza
    End Function

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        If Not ActivarBotonActualizar() Then
            MsgBox("No existen registros seleccionados para ser actualizados", MsgBoxStyle.Information, "SIGA")
            Exit Sub
        End If
        If MsgBox("¿Está seguro de actualizar los registros seleccionados?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim origen As Integer = Comun.TiposDeDatos.TipoOrigenItem.FICHA_EMPLEADO
        Dim tipoProceso As String = "N"
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = Me.gdvDetalle
        Dim registrosActualizados As Integer
        Dim parametroMensual As Periodo
        parametroMensual = New Periodo()
        For i As Integer = 0 To Me.gdvDetalle.RowCount - 1
            If view.GetRowCellValue(i, "AUTORIZA_PAGO_BIENIO") = True Then
                empleado.actulizarAprobacionBienio(view.GetRowCellValue(i, "ANTECEDENTE_REMUN_ID"), view.GetRowCellValue(i, "AUTORIZA_PAGO_BIENIO"))
                'empleado.CrearEmpleadoMovimientoMensual(periodo.ID, periodo.itemAsignacionAntiguedad, CType(view.GetRowCellValue(i, "EMPLEADO_ID"), Integer), 0, 0, origen, 1, tipoProceso)
                empleado = New Empleado(CType(view.GetRowCellValue(i, "EMPLEADO_ID"), Long))
                If empleado.recuperarDatosEUSEmpleado(empleado, empleado.datosLaborales.calidadJuridicaID, empleado.datosLaborales.gradoID, empleado.datosLaborales.clasificacionEmpleadoID, empleado.datosRemuneracion.numeroBienios, empleado.datosPrevisionales.institucionID, empleado.datosSalud.institucionID, parametroMensual) Then
                    empleado.actualizarDatosRemun(empleado.datosRemuneracion)
                    empleado.CrearEmpleadoMovimientoMensual(periodo.ID, periodo.itemAsignacionAntiguedad, CType(view.GetRowCellValue(i, "EMPLEADO_ID"), Integer), 0, 0, origen, empleado.datosRemuneracion.montoBienio, tipoProceso)
                End If
                registrosActualizados += 1
            End If
        Next
        llenarGrilla()
        MsgBox("Se actualizaron " + registrosActualizados.ToString + " registro(s)", MsgBoxStyle.Information, "SIGA")
    End Sub
    Private Sub llenarGrilla()
        Me.gdcAprobacionPagoRemun.DataSource = empleado.recuperaEmpleadosAutorizarBienios(luePeriodo.EditValue, chkSoloEmpleadosActivos.Checked, chkSoloRegistrosPendientes.Checked)
    End Sub
End Class
