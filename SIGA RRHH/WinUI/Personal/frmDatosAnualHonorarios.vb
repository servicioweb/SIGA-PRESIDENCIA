Imports cl.presidencia.Argo.BusinessRules
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmDatosAnualHonorarios
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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblHistorialCambios As System.Windows.Forms.Label
    Friend WithEvents gdcHistoricoDetalleHonorarios As DevExpress.XtraGrid.GridControl
    Friend WithEvents colPeriodo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaModificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gdcHonorarioDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvHonorarioDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colANTECEDENTE_HONORARIO_DETALLE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO_REGISTRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_VIGENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents TxtMonto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colNRO_SOLUCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_RESOLUCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_CONTRATO_DESDE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_CONTRATO_HASTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_ENERO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_FEBRERO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_MARZO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_ABRIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_MAYO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_JUNIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_JULIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_AGOSTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_SEPTIEMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_OCTUBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_NOVIEMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_DICIEMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPERIODO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOBSERVACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAÑO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNroResolucion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colFECHA_MODIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSUARIO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colES_RETIRO_EMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkEsRetiroEmpleado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colMOTIVO_RETIRO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueMotivoRetiro As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gdcHistoricoDetalleHonorarios = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUsuario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPeriodo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaModificacion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblHistorialCambios = New System.Windows.Forms.Label
        Me.btnCerrar = New DevExpress.XtraEditors.SimpleButton
        Me.gdcHonorarioDetalle = New DevExpress.XtraGrid.GridControl
        Me.gdvHonorarioDetalle = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colANTECEDENTE_HONORARIO_DETALLE_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colESTADO_REGISTRO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAÑO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_VIGENTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TxtMonto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colES_RETIRO_EMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkEsRetiroEmpleado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colNRO_SOLUCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtNroResolucion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colFECHA_RESOLUCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_CONTRATO_DESDE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_CONTRATO_HASTA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_ENERO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_FEBRERO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_MARZO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_ABRIL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_MAYO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_JUNIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_JULIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_AGOSTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_SEPTIEMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_OCTUBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_NOVIEMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_DICIEMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPERIODO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOBSERVACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_MODIFICACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSUARIO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.colMOTIVO_RETIRO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueMotivoRetiro = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        CType(Me.gdcHistoricoDetalleHonorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcHonorarioDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvHonorarioDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEsRetiroEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroResolucion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueMotivoRetiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcHistoricoDetalleHonorarios
        '
        '
        'gdcHistoricoDetalleHonorarios.EmbeddedNavigator
        '
        Me.gdcHistoricoDetalleHonorarios.EmbeddedNavigator.Name = ""
        Me.gdcHistoricoDetalleHonorarios.Location = New System.Drawing.Point(8, 272)
        Me.gdcHistoricoDetalleHonorarios.MainView = Me.GridView1
        Me.gdcHistoricoDetalleHonorarios.Name = "gdcHistoricoDetalleHonorarios"
        Me.gdcHistoricoDetalleHonorarios.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.gdcHistoricoDetalleHonorarios.Size = New System.Drawing.Size(1000, 216)
        Me.gdcHistoricoDetalleHonorarios.TabIndex = 7
        Me.gdcHistoricoDetalleHonorarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn18, Me.GridColumn19, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.colUsuario, Me.colPeriodo, Me.colFechaModificacion})
        Me.GridView1.GridControl = Me.gdcHistoricoDetalleHonorarios
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID Antecedente Honorario"
        Me.GridColumn1.FieldName = "ANTECEDENTE_HONORARIO_ID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "ID Empleado"
        Me.GridColumn2.FieldName = "EMPLEADO_ID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Estado Registro"
        Me.GridColumn3.FieldName = "ESTADO_REGISTRO"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Año"
        Me.GridColumn4.FieldName = "AÑO"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 53
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Fecha Contrato Desde"
        Me.GridColumn18.FieldName = "FECHA_CONTRATO_DESDE"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.OptionsColumn.ReadOnly = True
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 1
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Fecha Contrato Hasta"
        Me.GridColumn19.FieldName = "FECHA_CONTRATO_HASTA"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.OptionsColumn.ReadOnly = True
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Enero"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn5.FieldName = "MONTO_ENERO"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 53
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatString = "n0"
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.EditFormat.FormatString = "n0"
        Me.RepositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Febrero"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn6.FieldName = "MONTO_FEBRERO"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 53
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Marzo"
        Me.GridColumn7.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn7.FieldName = "MONTO_MARZO"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        Me.GridColumn7.Width = 53
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Abril"
        Me.GridColumn8.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn8.FieldName = "MONTO_ABRIL"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        Me.GridColumn8.Width = 53
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Mayo"
        Me.GridColumn9.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn9.FieldName = "MONTO_MAYO"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        Me.GridColumn9.Width = 53
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Junio"
        Me.GridColumn10.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn10.CustomizationCaption = "Junio"
        Me.GridColumn10.FieldName = "MONTO_JUNIO"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 8
        Me.GridColumn10.Width = 53
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Julio"
        Me.GridColumn11.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn11.FieldName = "MONTO_JULIO"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 9
        Me.GridColumn11.Width = 53
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Agosto"
        Me.GridColumn12.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn12.FieldName = "MONTO_AGOSTO"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 10
        Me.GridColumn12.Width = 53
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Septiembre"
        Me.GridColumn13.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn13.FieldName = "MONTO_SEPTIEMBRE"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 11
        Me.GridColumn13.Width = 53
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Octubre"
        Me.GridColumn14.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn14.FieldName = "MONTO_OCTUBRE"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 12
        Me.GridColumn14.Width = 53
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Noviembre"
        Me.GridColumn15.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn15.FieldName = "MONTO_NOVIEMBRE"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 13
        Me.GridColumn15.Width = 53
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Diciembre"
        Me.GridColumn16.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn16.FieldName = "MONTO_DICIEMBRE"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 14
        Me.GridColumn16.Width = 53
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Periodo"
        Me.GridColumn17.FieldName = "PERIODO_ID"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Nro.Res.Solución"
        Me.GridColumn20.FieldName = "NRO_SOLUCION"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        Me.GridColumn20.OptionsColumn.ReadOnly = True
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Fecha Res."
        Me.GridColumn21.FieldName = "FECHA_RESOLUCION"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.OptionsColumn.ReadOnly = True
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Observación"
        Me.GridColumn22.FieldName = "OBSERVACION"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.AllowEdit = False
        Me.GridColumn22.OptionsColumn.ReadOnly = True
        '
        'colUsuario
        '
        Me.colUsuario.Caption = "Usuario"
        Me.colUsuario.FieldName = "Usuario"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.Visible = True
        Me.colUsuario.VisibleIndex = 16
        Me.colUsuario.Width = 100
        '
        'colPeriodo
        '
        Me.colPeriodo.Caption = "Período"
        Me.colPeriodo.FieldName = "PERIODO"
        Me.colPeriodo.Name = "colPeriodo"
        Me.colPeriodo.Width = 87
        '
        'colFechaModificacion
        '
        Me.colFechaModificacion.Caption = "Fecha Modificación"
        Me.colFechaModificacion.FieldName = "FECHA_MODIFICACION"
        Me.colFechaModificacion.Name = "colFechaModificacion"
        Me.colFechaModificacion.Visible = True
        Me.colFechaModificacion.VisibleIndex = 15
        Me.colFechaModificacion.Width = 100
        '
        'lblHistorialCambios
        '
        Me.lblHistorialCambios.Location = New System.Drawing.Point(8, 248)
        Me.lblHistorialCambios.Name = "lblHistorialCambios"
        Me.lblHistorialCambios.Size = New System.Drawing.Size(120, 23)
        Me.lblHistorialCambios.TabIndex = 8
        Me.lblHistorialCambios.Text = "Resumen Histórico"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(816, 8)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(168, 23)
        Me.btnCerrar.TabIndex = 9
        Me.btnCerrar.Text = "Cerrar"
        '
        'gdcHonorarioDetalle
        '
        '
        'gdcHonorarioDetalle.EmbeddedNavigator
        '
        Me.gdcHonorarioDetalle.EmbeddedNavigator.Name = ""
        Me.gdcHonorarioDetalle.Location = New System.Drawing.Point(8, 40)
        Me.gdcHonorarioDetalle.MainView = Me.gdvHonorarioDetalle
        Me.gdcHonorarioDetalle.Name = "gdcHonorarioDetalle"
        Me.gdcHonorarioDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.TxtMonto, Me.txtNroResolucion, Me.chkEsRetiroEmpleado, Me.lueMotivoRetiro})
        Me.gdcHonorarioDetalle.Size = New System.Drawing.Size(1000, 200)
        Me.gdcHonorarioDetalle.TabIndex = 10
        Me.gdcHonorarioDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvHonorarioDetalle})
        '
        'gdvHonorarioDetalle
        '
        Me.gdvHonorarioDetalle.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gdvHonorarioDetalle.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gdvHonorarioDetalle.ColumnPanelRowHeight = 40
        Me.gdvHonorarioDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colANTECEDENTE_HONORARIO_DETALLE_ID, Me.colEMPLEADO_ID, Me.colESTADO_REGISTRO, Me.colAÑO, Me.colMONTO_VIGENTE, Me.colES_RETIRO_EMPLEADO, Me.colMOTIVO_RETIRO_ID, Me.colNRO_SOLUCION, Me.colFECHA_RESOLUCION, Me.colFECHA_CONTRATO_DESDE, Me.colFECHA_CONTRATO_HASTA, Me.colMONTO_ENERO, Me.colMONTO_FEBRERO, Me.colMONTO_MARZO, Me.colMONTO_ABRIL, Me.colMONTO_MAYO, Me.colMONTO_JUNIO, Me.colMONTO_JULIO, Me.colMONTO_AGOSTO, Me.colMONTO_SEPTIEMBRE, Me.colMONTO_OCTUBRE, Me.colMONTO_NOVIEMBRE, Me.colMONTO_DICIEMBRE, Me.colPERIODO_ID, Me.colOBSERVACION, Me.colFECHA_MODIFICACION, Me.colUSUARIO1})
        Me.gdvHonorarioDetalle.GridControl = Me.gdcHonorarioDetalle
        Me.gdvHonorarioDetalle.Name = "gdvHonorarioDetalle"
        Me.gdvHonorarioDetalle.OptionsView.ColumnAutoWidth = False
        Me.gdvHonorarioDetalle.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gdvHonorarioDetalle.OptionsView.ShowGroupPanel = False
        '
        'colANTECEDENTE_HONORARIO_DETALLE_ID
        '
        Me.colANTECEDENTE_HONORARIO_DETALLE_ID.Caption = "ID Detalle"
        Me.colANTECEDENTE_HONORARIO_DETALLE_ID.FieldName = "ANTECEDENTE_HONORARIO_DETALLE_ID"
        Me.colANTECEDENTE_HONORARIO_DETALLE_ID.Name = "colANTECEDENTE_HONORARIO_DETALLE_ID"
        Me.colANTECEDENTE_HONORARIO_DETALLE_ID.OptionsColumn.AllowEdit = False
        Me.colANTECEDENTE_HONORARIO_DETALLE_ID.OptionsColumn.ReadOnly = True
        Me.colANTECEDENTE_HONORARIO_DETALLE_ID.OptionsColumn.ShowInCustomizationForm = False
        '
        'colEMPLEADO_ID
        '
        Me.colEMPLEADO_ID.Caption = "Empleado"
        Me.colEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.colEMPLEADO_ID.Name = "colEMPLEADO_ID"
        Me.colEMPLEADO_ID.OptionsColumn.AllowEdit = False
        Me.colEMPLEADO_ID.OptionsColumn.ReadOnly = True
        Me.colEMPLEADO_ID.OptionsColumn.ShowInCustomizationForm = False
        '
        'colESTADO_REGISTRO
        '
        Me.colESTADO_REGISTRO.Caption = "Estado Registro"
        Me.colESTADO_REGISTRO.FieldName = "ESTADO_REGISTRO"
        Me.colESTADO_REGISTRO.Name = "colESTADO_REGISTRO"
        Me.colESTADO_REGISTRO.OptionsColumn.AllowEdit = False
        Me.colESTADO_REGISTRO.OptionsColumn.ReadOnly = True
        Me.colESTADO_REGISTRO.OptionsColumn.ShowInCustomizationForm = False
        '
        'colAÑO
        '
        Me.colAÑO.Caption = "Año"
        Me.colAÑO.FieldName = "AÑO"
        Me.colAÑO.Name = "colAÑO"
        Me.colAÑO.Visible = True
        Me.colAÑO.VisibleIndex = 0
        '
        'colMONTO_VIGENTE
        '
        Me.colMONTO_VIGENTE.Caption = "Monto Vigente"
        Me.colMONTO_VIGENTE.ColumnEdit = Me.TxtMonto
        Me.colMONTO_VIGENTE.FieldName = "MONTO_VIGENTE"
        Me.colMONTO_VIGENTE.Name = "colMONTO_VIGENTE"
        Me.colMONTO_VIGENTE.Visible = True
        Me.colMONTO_VIGENTE.VisibleIndex = 1
        '
        'TxtMonto
        '
        Me.TxtMonto.AutoHeight = False
        Me.TxtMonto.DisplayFormat.FormatString = "n0"
        Me.TxtMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtMonto.EditFormat.FormatString = "n0"
        Me.TxtMonto.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtMonto.Mask.EditMask = "n0"
        Me.TxtMonto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtMonto.Mask.UseMaskAsDisplayFormat = True
        Me.TxtMonto.Name = "TxtMonto"
        '
        'colES_RETIRO_EMPLEADO
        '
        Me.colES_RETIRO_EMPLEADO.Caption = "Es Retiro Empleado"
        Me.colES_RETIRO_EMPLEADO.ColumnEdit = Me.chkEsRetiroEmpleado
        Me.colES_RETIRO_EMPLEADO.FieldName = "ES_RETIRO_EMPLEADO"
        Me.colES_RETIRO_EMPLEADO.Name = "colES_RETIRO_EMPLEADO"
        Me.colES_RETIRO_EMPLEADO.Visible = True
        Me.colES_RETIRO_EMPLEADO.VisibleIndex = 2
        '
        'chkEsRetiroEmpleado
        '
        Me.chkEsRetiroEmpleado.AutoHeight = False
        Me.chkEsRetiroEmpleado.Name = "chkEsRetiroEmpleado"
        '
        'colNRO_SOLUCION
        '
        Me.colNRO_SOLUCION.Caption = "Número Resolución"
        Me.colNRO_SOLUCION.ColumnEdit = Me.txtNroResolucion
        Me.colNRO_SOLUCION.FieldName = "NRO_SOLUCION"
        Me.colNRO_SOLUCION.Name = "colNRO_SOLUCION"
        Me.colNRO_SOLUCION.Visible = True
        Me.colNRO_SOLUCION.VisibleIndex = 4
        '
        'txtNroResolucion
        '
        Me.txtNroResolucion.AutoHeight = False
        Me.txtNroResolucion.DisplayFormat.FormatString = "n0"
        Me.txtNroResolucion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNroResolucion.EditFormat.FormatString = "n0"
        Me.txtNroResolucion.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNroResolucion.Mask.EditMask = "n0"
        Me.txtNroResolucion.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNroResolucion.Mask.UseMaskAsDisplayFormat = True
        Me.txtNroResolucion.MaxLength = 10
        Me.txtNroResolucion.Name = "txtNroResolucion"
        '
        'colFECHA_RESOLUCION
        '
        Me.colFECHA_RESOLUCION.Caption = "Fecha Resolución"
        Me.colFECHA_RESOLUCION.FieldName = "FECHA_RESOLUCION"
        Me.colFECHA_RESOLUCION.Name = "colFECHA_RESOLUCION"
        Me.colFECHA_RESOLUCION.Visible = True
        Me.colFECHA_RESOLUCION.VisibleIndex = 5
        '
        'colFECHA_CONTRATO_DESDE
        '
        Me.colFECHA_CONTRATO_DESDE.Caption = "Fecha Inicio Contrato"
        Me.colFECHA_CONTRATO_DESDE.FieldName = "FECHA_CONTRATO_DESDE"
        Me.colFECHA_CONTRATO_DESDE.Name = "colFECHA_CONTRATO_DESDE"
        Me.colFECHA_CONTRATO_DESDE.Visible = True
        Me.colFECHA_CONTRATO_DESDE.VisibleIndex = 6
        '
        'colFECHA_CONTRATO_HASTA
        '
        Me.colFECHA_CONTRATO_HASTA.Caption = "Fecha Termino Contrato"
        Me.colFECHA_CONTRATO_HASTA.FieldName = "FECHA_CONTRATO_HASTA"
        Me.colFECHA_CONTRATO_HASTA.Name = "colFECHA_CONTRATO_HASTA"
        Me.colFECHA_CONTRATO_HASTA.Visible = True
        Me.colFECHA_CONTRATO_HASTA.VisibleIndex = 7
        '
        'colMONTO_ENERO
        '
        Me.colMONTO_ENERO.Caption = "Enero"
        Me.colMONTO_ENERO.ColumnEdit = Me.TxtMonto
        Me.colMONTO_ENERO.FieldName = "MONTO_ENERO"
        Me.colMONTO_ENERO.Name = "colMONTO_ENERO"
        Me.colMONTO_ENERO.Visible = True
        Me.colMONTO_ENERO.VisibleIndex = 8
        '
        'colMONTO_FEBRERO
        '
        Me.colMONTO_FEBRERO.Caption = "Febrero"
        Me.colMONTO_FEBRERO.ColumnEdit = Me.TxtMonto
        Me.colMONTO_FEBRERO.FieldName = "MONTO_FEBRERO"
        Me.colMONTO_FEBRERO.Name = "colMONTO_FEBRERO"
        Me.colMONTO_FEBRERO.Visible = True
        Me.colMONTO_FEBRERO.VisibleIndex = 9
        '
        'colMONTO_MARZO
        '
        Me.colMONTO_MARZO.Caption = "Marzo"
        Me.colMONTO_MARZO.ColumnEdit = Me.TxtMonto
        Me.colMONTO_MARZO.FieldName = "MONTO_MARZO"
        Me.colMONTO_MARZO.Name = "colMONTO_MARZO"
        Me.colMONTO_MARZO.Visible = True
        Me.colMONTO_MARZO.VisibleIndex = 10
        '
        'colMONTO_ABRIL
        '
        Me.colMONTO_ABRIL.Caption = "Abril"
        Me.colMONTO_ABRIL.ColumnEdit = Me.TxtMonto
        Me.colMONTO_ABRIL.FieldName = "MONTO_ABRIL"
        Me.colMONTO_ABRIL.Name = "colMONTO_ABRIL"
        Me.colMONTO_ABRIL.Visible = True
        Me.colMONTO_ABRIL.VisibleIndex = 11
        '
        'colMONTO_MAYO
        '
        Me.colMONTO_MAYO.Caption = "Mayo"
        Me.colMONTO_MAYO.ColumnEdit = Me.TxtMonto
        Me.colMONTO_MAYO.FieldName = "MONTO_MAYO"
        Me.colMONTO_MAYO.Name = "colMONTO_MAYO"
        Me.colMONTO_MAYO.Visible = True
        Me.colMONTO_MAYO.VisibleIndex = 12
        '
        'colMONTO_JUNIO
        '
        Me.colMONTO_JUNIO.Caption = "Junio"
        Me.colMONTO_JUNIO.ColumnEdit = Me.TxtMonto
        Me.colMONTO_JUNIO.FieldName = "MONTO_JUNIO"
        Me.colMONTO_JUNIO.Name = "colMONTO_JUNIO"
        Me.colMONTO_JUNIO.Visible = True
        Me.colMONTO_JUNIO.VisibleIndex = 13
        '
        'colMONTO_JULIO
        '
        Me.colMONTO_JULIO.Caption = "Julio"
        Me.colMONTO_JULIO.ColumnEdit = Me.TxtMonto
        Me.colMONTO_JULIO.FieldName = "MONTO_JULIO"
        Me.colMONTO_JULIO.Name = "colMONTO_JULIO"
        Me.colMONTO_JULIO.Visible = True
        Me.colMONTO_JULIO.VisibleIndex = 14
        '
        'colMONTO_AGOSTO
        '
        Me.colMONTO_AGOSTO.Caption = "Agosto"
        Me.colMONTO_AGOSTO.ColumnEdit = Me.TxtMonto
        Me.colMONTO_AGOSTO.FieldName = "MONTO_AGOSTO"
        Me.colMONTO_AGOSTO.Name = "colMONTO_AGOSTO"
        Me.colMONTO_AGOSTO.Visible = True
        Me.colMONTO_AGOSTO.VisibleIndex = 15
        '
        'colMONTO_SEPTIEMBRE
        '
        Me.colMONTO_SEPTIEMBRE.Caption = "Septiembre"
        Me.colMONTO_SEPTIEMBRE.FieldName = "MONTO_SEPTIEMBRE"
        Me.colMONTO_SEPTIEMBRE.Name = "colMONTO_SEPTIEMBRE"
        Me.colMONTO_SEPTIEMBRE.Visible = True
        Me.colMONTO_SEPTIEMBRE.VisibleIndex = 16
        '
        'colMONTO_OCTUBRE
        '
        Me.colMONTO_OCTUBRE.Caption = "Octubre"
        Me.colMONTO_OCTUBRE.ColumnEdit = Me.TxtMonto
        Me.colMONTO_OCTUBRE.FieldName = "MONTO_OCTUBRE"
        Me.colMONTO_OCTUBRE.Name = "colMONTO_OCTUBRE"
        Me.colMONTO_OCTUBRE.Visible = True
        Me.colMONTO_OCTUBRE.VisibleIndex = 17
        '
        'colMONTO_NOVIEMBRE
        '
        Me.colMONTO_NOVIEMBRE.Caption = "Noviembre"
        Me.colMONTO_NOVIEMBRE.ColumnEdit = Me.TxtMonto
        Me.colMONTO_NOVIEMBRE.FieldName = "MONTO_NOVIEMBRE"
        Me.colMONTO_NOVIEMBRE.Name = "colMONTO_NOVIEMBRE"
        Me.colMONTO_NOVIEMBRE.Visible = True
        Me.colMONTO_NOVIEMBRE.VisibleIndex = 18
        '
        'colMONTO_DICIEMBRE
        '
        Me.colMONTO_DICIEMBRE.Caption = "Diciembre"
        Me.colMONTO_DICIEMBRE.ColumnEdit = Me.TxtMonto
        Me.colMONTO_DICIEMBRE.FieldName = "MONTO_DICIEMBRE"
        Me.colMONTO_DICIEMBRE.Name = "colMONTO_DICIEMBRE"
        Me.colMONTO_DICIEMBRE.Visible = True
        Me.colMONTO_DICIEMBRE.VisibleIndex = 19
        '
        'colPERIODO_ID
        '
        Me.colPERIODO_ID.Caption = "ID Periodo"
        Me.colPERIODO_ID.FieldName = "PERIODO_ID"
        Me.colPERIODO_ID.Name = "colPERIODO_ID"
        '
        'colOBSERVACION
        '
        Me.colOBSERVACION.Caption = "Observación"
        Me.colOBSERVACION.FieldName = "OBSERVACION"
        Me.colOBSERVACION.Name = "colOBSERVACION"
        '
        'colFECHA_MODIFICACION
        '
        Me.colFECHA_MODIFICACION.Caption = "Fecha Actualización"
        Me.colFECHA_MODIFICACION.FieldName = "FECHA_MODIFICACION"
        Me.colFECHA_MODIFICACION.Name = "colFECHA_MODIFICACION"
        Me.colFECHA_MODIFICACION.OptionsColumn.AllowEdit = False
        Me.colFECHA_MODIFICACION.OptionsColumn.ReadOnly = True
        Me.colFECHA_MODIFICACION.Visible = True
        Me.colFECHA_MODIFICACION.VisibleIndex = 20
        '
        'colUSUARIO1
        '
        Me.colUSUARIO1.Caption = "Usuario"
        Me.colUSUARIO1.FieldName = "USUARIO"
        Me.colUSUARIO1.Name = "colUSUARIO1"
        Me.colUSUARIO1.OptionsColumn.AllowEdit = False
        Me.colUSUARIO1.OptionsColumn.ReadOnly = True
        Me.colUSUARIO1.Visible = True
        Me.colUSUARIO1.VisibleIndex = 21
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'colMOTIVO_RETIRO_ID
        '
        Me.colMOTIVO_RETIRO_ID.Caption = "Motivo Retiro"
        Me.colMOTIVO_RETIRO_ID.ColumnEdit = Me.lueMotivoRetiro
        Me.colMOTIVO_RETIRO_ID.FieldName = "MOTIVO_RETIRO_ID"
        Me.colMOTIVO_RETIRO_ID.Name = "colMOTIVO_RETIRO_ID"
        Me.colMOTIVO_RETIRO_ID.Visible = True
        Me.colMOTIVO_RETIRO_ID.VisibleIndex = 3
        '
        'lueMotivoRetiro
        '
        Me.lueMotivoRetiro.AutoHeight = False
        Me.lueMotivoRetiro.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueMotivoRetiro.Name = "lueMotivoRetiro"
        '
        'frmDatosAnualHonorarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1000, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.gdcHonorarioDetalle)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblHistorialCambios)
        Me.Controls.Add(Me.gdcHistoricoDetalleHonorarios)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDatosAnualHonorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Presupuesto Anual Honorarios"
        CType(Me.gdcHistoricoDetalleHonorarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcHonorarioDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvHonorarioDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEsRetiroEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroResolucion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueMotivoRetiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Shared _Form As frmDatosAnualHonorarios = Nothing
    Private oldAntecedenteHonorarioId As Integer
    Public empleado As New empleado
    Private param As Periodo

    Public Shared Property DefInstance() As frmDatosAnualHonorarios
        Get
            If _Form Is Nothing OrElse _Form.IsDisposed Then
                _Form = New frmDatosAnualHonorarios
            Else
                _Form.BringToFront()
            End If
            Return _Form
        End Get

        Set(ByVal value As frmDatosAnualHonorarios)
            _Form = value
        End Set
    End Property


    Private Sub frmDatosAnualHonorarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oldAntecedenteHonorarioId = empleado.datosPresupuestoHonorario.antecedenteHonorarioDetalleId
        param = New Periodo
        llenarMotivoRetiro()
        llenarGrilla()
    End Sub

    Private Sub llenarGrilla()
        Dim idEmpleado As Integer = empleado.ID
        Me.gdcHonorarioDetalle.DataSource = Nothing
        Me.gdcHistoricoDetalleHonorarios.DataSource = Nothing

        Me.gdcHonorarioDetalle.DataSource = empleado.recuperarDetallePresupuestoAnualHonorario(idEmpleado)
        Me.gdcHistoricoDetalleHonorarios.DataSource = empleado.recuperaHistoricoCambiosDetallePresupuestoAnualHonorario(idEmpleado)
    End Sub

    Public Sub llenarMotivoRetiro()
        lueMotivoRetiro.Columns.Clear()
        With lueMotivoRetiro.Columns
            .Add(New LookUpColumnInfo("MOTIVO_RETIRO_ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
            .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
        End With
        lueMotivoRetiro.DataSource = repositorio.dvMotivoRetiro
        lueMotivoRetiro.DisplayMember = "DESCRIPCION"
        lueMotivoRetiro.NullText = ""
        lueMotivoRetiro.PopupWidth = 200
        lueMotivoRetiro.ValueMember = "MOTIVO_RETIRO_ID"
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        frmDatosAnualHonorarios.DefInstance.Close()
    End Sub

    Private Sub gdvHonorarioDetalle_ShowingEditor(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gdvHonorarioDetalle.ShowingEditor
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        If view.FocusedColumn.FieldName = "MONTO_ENERO" Or view.FocusedColumn.FieldName = "MONTO_FEBRERO" Or view.FocusedColumn.FieldName = "MONTO_MARZO" Or view.FocusedColumn.FieldName = "MONTO_ABRIL" _
           Or view.FocusedColumn.FieldName = "MONTO_MAYO" Or view.FocusedColumn.FieldName = "MONTO_JUNIO" Or view.FocusedColumn.FieldName = "MONTO_JULIO" Or view.FocusedColumn.FieldName = "MONTO_AGOSTO" _
           Or view.FocusedColumn.FieldName = "MONTO_SEPTIEMBRE" Or view.FocusedColumn.FieldName = "MONTO_OCTUBRE" Or view.FocusedColumn.FieldName = "MONTO_NOVIEMBRE" Or view.FocusedColumn.FieldName = "MONTO_DICIEMBRE" Then
            e.Cancel = ObtieneValorCelda(view, view.FocusedRowHandle)
        End If
    End Sub

    Function ObtieneValorCelda(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByVal row As Integer) As Boolean
        Dim mesInicial As Integer = CDate(view.GetRowCellValue(view.FocusedRowHandle, "FECHA_CONTRATO_DESDE")).Month
        Dim mesFinal As Integer = CDate(view.GetRowCellValue(view.FocusedRowHandle, "FECHA_CONTRATO_HASTA")).Month
        Dim esRetiroEmpleado As Boolean = CType(view.GetRowCellValue(view.FocusedRowHandle, "ES_RETIRO_EMPLEADO"), Boolean)
        Dim aceptaDatoCelda As Boolean = True
        Dim mes As Integer

        If esRetiroEmpleado = True Then
            Return False
        End If

        If view.FocusedColumn.FieldName = "MONTO_ENERO" Then
            mes = 1
        End If
        If view.FocusedColumn.FieldName = "MONTO_FEBRERO" Then
            mes = 2
        End If
        If view.FocusedColumn.FieldName = "MONTO_MARZO" Then
            mes = 3
        End If
        If view.FocusedColumn.FieldName = "MONTO_ABRIL" Then
            mes = 4
        End If
        If view.FocusedColumn.FieldName = "MONTO_MAYO" Then
            mes = 5
        End If
        If view.FocusedColumn.FieldName = "MONTO_JUNIO" Then
            mes = 6
        End If
        If view.FocusedColumn.FieldName = "MONTO_JULIO" Then
            mes = 7
        End If
        If view.FocusedColumn.FieldName = "MONTO_AGOSTO" Then
            mes = 8
        End If
        If view.FocusedColumn.FieldName = "MONTO_SEPTIEMBRE" Then
            mes = 9
        End If
        If view.FocusedColumn.FieldName = "MONTO_OCTUBRE" Then
            mes = 10
        End If
        If view.FocusedColumn.FieldName = "MONTO_NOVIEMBRE" Then
            mes = 11
        End If
        If view.FocusedColumn.FieldName = "MONTO_DICIEMBRE" Then
            mes = 12
        End If

        If mes >= mesInicial And mes <= mesFinal Then
            aceptaDatoCelda = False
        End If

        Return aceptaDatoCelda
    End Function

    Private Sub gdvHonorarioDetalle_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvHonorarioDetalle.InvalidRowException
        'Suprimir el mensaje de error al validar la fila
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gdvHonorarioDetalle_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvHonorarioDetalle.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        empleado.datosPresupuestoHonorario.antecedenteHonorarioDetalleId = 0
        view.SetRowCellValue(e.RowHandle, "ANTECEDENTE_HONORARIO_DETALLE_ID", 0)
        view.SetRowCellValue(e.RowHandle, "EMPLEADO_ID", CType(empleado.ID, Integer))
        view.SetRowCellValue(e.RowHandle, "ESTADO_REGISTRO", CType(Comun.TiposDeDatos.EstadoRegistro.ACTIVO, Integer))
        view.SetRowCellValue(e.RowHandle, "AÑO", CType(param.ano, Integer))
        view.SetRowCellValue(e.RowHandle, "NRO_SOLUCION", CType("0", String))
        view.SetRowCellValue(e.RowHandle, "FECHA_RESOLUCION", CType("01-01-" + CType(param.ano, String), Date))
        view.SetRowCellValue(e.RowHandle, "FECHA_CONTRATO_DESDE", CType("01-01-" + CType(param.ano, String), Date))
        view.SetRowCellValue(e.RowHandle, "FECHA_CONTRATO_HASTA", CType("01-01-" + CType(param.ano, String), Date))
        view.SetRowCellValue(e.RowHandle, "MONTO_ENERO", 0)
        view.SetRowCellValue(e.RowHandle, "MONTO_FEBRERO", 0)
        view.SetRowCellValue(e.RowHandle, "MONTO_MARZO", 0)
        view.SetRowCellValue(e.RowHandle, "MONTO_ABRIL", 0)
        view.SetRowCellValue(e.RowHandle, "MONTO_MAYO", 0)
        view.SetRowCellValue(e.RowHandle, "MONTO_JUNIO", 0)
        view.SetRowCellValue(e.RowHandle, "MONTO_JULIO", 0)
        view.SetRowCellValue(e.RowHandle, "MONTO_AGOSTO", 0)
        view.SetRowCellValue(e.RowHandle, "MONTO_SEPTIEMBRE", 0)
        view.SetRowCellValue(e.RowHandle, "MONTO_OCTUBRE", 0)
        view.SetRowCellValue(e.RowHandle, "MONTO_NOVIEMBRE", 0)
        view.SetRowCellValue(e.RowHandle, "MONTO_DICIEMBRE", 0)
        view.SetRowCellValue(e.RowHandle, "MONTO_VIGENTE", 0)
        view.SetRowCellValue(e.RowHandle, "ES_RETIRO_EMPLEADO", 0)
        view.SetRowCellValue(e.RowHandle, "PERIODO_ID", param.ID)
        view.SetRowCellValue(e.RowHandle, "OBSERVACION", "")
        view.SetRowCellValue(e.RowHandle, "MOTIVO_RETIRO_ID", 0)
        ''view.SetRowCellValue(e.RowHandle, "USUARIO", "")
        ''view.SetRowCellValue(e.RowHandle, "", Date.Now)
    End Sub

    Private Sub gdvHonorarioDetalle_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvHonorarioDetalle.RowUpdated
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        Dim mensaje As String
        If view.GetRowCellValue(view.FocusedRowHandle, "ANTECEDENTE_HONORARIO_DETALLE_ID") > 0 Then
            empleado.datosPresupuestoHonorario.antecedenteHonorarioDetalleId = view.GetRowCellValue(view.FocusedRowHandle, "ANTECEDENTE_HONORARIO_DETALLE_ID")
            'esRetiroEmpleado = empleado.buscaInteger("SELECT ES_RETIRO_EMPLEADO FROM RH_PER_ANTECEDENTE_HONORARIO_DETALLE WHERE ANTECEDENTE_HONORARIO_DETALLE_ID=" + CType(empleado.datosPresupuestoHonorario.antecedenteHonorarioDetalleId, String))
        Else
            empleado.datosPresupuestoHonorario.antecedenteHonorarioDetalleId = 0
            'esRetiroEmpleado = 0
        End If

        Dim esRetiroEmpleado As Integer = empleado.buscaInteger("SELECT ES_RETIRO_EMPLEADO FROM RH_PER_ANTECEDENTE_HONORARIO_DETALLE WHERE ANTECEDENTE_HONORARIO_DETALLE_ID=" + CType(empleado.datosPresupuestoHonorario.antecedenteHonorarioDetalleId, String))

        If view.GetRowCellValue(view.FocusedRowHandle, "ES_RETIRO_EMPLEADO") = True And empleado.datosPresupuestoHonorario.esRetiroEmpleado = False Then
            RetirarEmpleado(view)
        ElseIf view.GetRowCellValue(view.FocusedRowHandle, "ES_RETIRO_EMPLEADO") = False And empleado.datosPresupuestoHonorario.esRetiroEmpleado = True And esRetiroEmpleado > 0 Then
            ReactivarEmpleado(view)
        End If

        empleado.datosPresupuestoHonorario.estadoRegistro = Comun.TiposDeDatos.EstadoRegistro.ACTIVO
        empleado.datosPresupuestoHonorario.empleadoId = empleado.ID
        empleado.datosPresupuestoHonorario.año = view.GetRowCellValue(view.FocusedRowHandle, "AÑO")
        empleado.datosPresupuestoHonorario.fechaContratoDesde = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_CONTRATO_DESDE")
        empleado.datosPresupuestoHonorario.fechaContratoHasta = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_CONTRATO_HASTA")
        empleado.datosPresupuestoHonorario.nroResolucion = view.GetRowCellValue(view.FocusedRowHandle, "NRO_SOLUCION")
        empleado.datosPresupuestoHonorario.fechaResolucion = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_RESOLUCION")
        empleado.datosPresupuestoHonorario.periodoId = empleado.datosLaborales.periodoID
        empleado.datosPresupuestoHonorario.observacion = ""
        empleado.datosPresupuestoHonorario.montoVigente = view.GetRowCellValue(view.FocusedRowHandle, "MONTO_VIGENTE")
        empleado.datosPresupuestoHonorario.montoEnero = view.GetRowCellValue(view.FocusedRowHandle, "MONTO_ENERO")
        empleado.datosPresupuestoHonorario.montoFebrero = view.GetRowCellValue(view.FocusedRowHandle, "MONTO_FEBRERO")
        empleado.datosPresupuestoHonorario.montoMarzo = view.GetRowCellValue(view.FocusedRowHandle, "MONTO_MARZO")
        empleado.datosPresupuestoHonorario.montoAbril = view.GetRowCellValue(view.FocusedRowHandle, "MONTO_ABRIL")
        empleado.datosPresupuestoHonorario.montoMayo = view.GetRowCellValue(view.FocusedRowHandle, "MONTO_MAYO")
        empleado.datosPresupuestoHonorario.montoJunio = view.GetRowCellValue(view.FocusedRowHandle, "MONTO_JUNIO")
        empleado.datosPresupuestoHonorario.montoJulio = view.GetRowCellValue(view.FocusedRowHandle, "MONTO_JULIO")
        empleado.datosPresupuestoHonorario.montoAgosto = view.GetRowCellValue(view.FocusedRowHandle, "MONTO_AGOSTO")
        empleado.datosPresupuestoHonorario.montoSeptiembre = view.GetRowCellValue(view.FocusedRowHandle, "MONTO_SEPTIEMBRE")
        empleado.datosPresupuestoHonorario.montoOctubre = view.GetRowCellValue(view.FocusedRowHandle, "MONTO_OCTUBRE")
        empleado.datosPresupuestoHonorario.montoNoviembre = view.GetRowCellValue(view.FocusedRowHandle, "MONTO_NOVIEMBRE")
        empleado.datosPresupuestoHonorario.montoDiciembre = view.GetRowCellValue(view.FocusedRowHandle, "MONTO_DICIEMBRE")
        empleado.datosPresupuestoHonorario.esRetiroEmpleado = view.GetRowCellValue(view.FocusedRowHandle, "ES_RETIRO_EMPLEADO")
        empleado.datosPresupuestoHonorario.motivoRetiroId = view.GetRowCellValue(view.FocusedRowHandle, "MOTIVO_RETIRO_ID")
        If view.GetRowCellValue(view.FocusedRowHandle, "ANTECEDENTE_HONORARIO_DETALLE_ID") > 0 Then
            empleado.actualizarDatosPresupuestoAnualHonorario(empleado.datosPresupuestoHonorario)
            mensaje = "actualizado"
        Else
            empleado.datosPresupuestoHonorario.antecedenteHonorarioDetalleId = empleado.CrearEmpleadoPresupuentoAnualHonorario(empleado.datosPresupuestoHonorario.antecedenteHonorarioDetalleId)
            mensaje = "creado"
        End If
        llenarGrilla()
        MsgBox("El registro fue " + mensaje + " satisfactoriamente", MsgBoxStyle.Information)
    End Sub

    Private Sub gdvHonorarioDetalle_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gdvHonorarioDetalle.ValidateRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        Dim validacionCorrecta As Boolean = True

        If view.GetRowCellValue(view.FocusedRowHandle, "AÑO") <> param.ano Then
            MsgBox("Año presupuesto no puede ser distinto a " + param.ano.ToString + ".", MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "SIGA")
            validacionCorrecta = False
        End If
        If view.GetRowCellValue(view.FocusedRowHandle, "MONTO_VIGENTE") <= 0 Then
            MsgBox("Monto vigente debe ser mayor de cero.", MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "SIGA")
            validacionCorrecta = False
        End If
        If Year(view.GetRowCellValue(view.FocusedRowHandle, "FECHA_RESOLUCION")) <> Me.param.ano Then
            MsgBox("Fecha resolución no debe corresponder al año " + CType(param.ano, String) + ".", MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "SIGA")
            validacionCorrecta = False
        End If
        If view.GetRowCellValue(view.FocusedRowHandle, "NRO_SOLUCION") <= 0 Then
            MsgBox("Número resolución debe ser mayor de cero.", MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "SIGA")
            validacionCorrecta = False
        End If
        If view.GetRowCellValue(e.RowHandle, "ES_RETIRO_EMPLEADO") = True And empleado.datosPresupuestoHonorario.esRetiroEmpleado = False Then
            Dim Año As Integer = CType(view.GetRowCellValue(view.FocusedRowHandle, "FECHA_CONTRATO_HASTA"), Date).Year
            Dim Mes As Integer = CType(view.GetRowCellValue(view.FocusedRowHandle, "FECHA_CONTRATO_HASTA"), Date).Month
            If Año <> param.ano Or Mes <> param.mes Then
                MessageBox.Show("Fecha témino contrato esta no corresponde al periodo vigente (" + param.anoMes + ")", "Siga", MessageBoxButtons.OK, MessageBoxIcon.Error)
                validacionCorrecta = False
            ElseIf MessageBox.Show("¿Está seguro que desea ejecutar el proceso de retiro?", "Siga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                validacionCorrecta = False
            End If
        End If

        If view.GetRowCellValue(e.RowHandle, "ES_RETIRO_EMPLEADO") = False And empleado.datosPresupuestoHonorario.esRetiroEmpleado = True And view.GetRowCellValue(e.RowHandle, "PERIODO_ID") = param.ID Then
            If MessageBox.Show("¿Está seguro que desea reactivar el empleado?", "Siga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                validacionCorrecta = False
            End If
        End If
        If view.GetRowCellValue(e.RowHandle, "PERIODO_ID") <> param.ID Then
            If (MessageBox.Show("El registro fue ingresado en un periodo anterior al vigente. ¿Seguro que desea actualizarlo?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No) Then
                validacionCorrecta = False
            End If
        End If
        e.Valid = validacionCorrecta
    End Sub

    Private Sub gdvHonorarioDetalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvHonorarioDetalle.KeyDown
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = gdvHonorarioDetalle

        If (e.KeyCode = Keys.Delete) Then
            If view.GetRowCellValue(view.FocusedRowHandle, "PERIODO_ID") <> param.ID Then
                If (MessageBox.Show("El registro a eliminar fue ingresado en un periodo anterior al vigente. ¿Seguro que desea eliminar el registro seleccionado?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No) Then
                    Exit Sub
                End If
            End If
            Dim myview As DevExpress.XtraGrid.Views.Grid.GridView = sender
            If myview.IsNewItemRow(myview.FocusedRowHandle) Then
                MessageBox.Show("Para cancelar el nuevo registro debe presionar la tecla Esc (Escape)", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If param.ano <> view.GetRowCellValue(view.FocusedRowHandle, "AÑO") Then
                    MsgBox("Este registro no puede ser eliminado, corresponde a año cerrado", MsgBoxStyle.Information)
                Else
                    If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                        Dim idDetallePresupAnual As Integer = view.GetRowCellValue(view.FocusedRowHandle, "ANTECEDENTE_HONORARIO_DETALLE_ID")
                        view.DeleteRow(view.FocusedRowHandle)
                        Try
                            If view.GetRowCellValue(view.FocusedRowHandle, "ES_RETIRO_EMPLEADO") = True Then

                            End If
                            empleado.eliminarDetallePresupuestoAnual(idDetallePresupAnual)
                            llenarGrilla()
                            MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Information)
                        Catch ex As Exception
                            MsgBox("Ha ocurrido un error al intentar eliminar el registro " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                        End Try
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub RetirarEmpleado(ByVal view As DevExpress.XtraGrid.Views.Base.ColumnView)
        'Se actualiza el registro laboral vigente a INACTIVO
        empleado.datosLaborales.estadoRegistro = Comun.TiposDeDatos.EstadoRegistro.INACTIVO
        empleado.datosLaborales.motivoRetiroID = 0
        empleado.actualizarDatosLaboral(empleado.datosLaborales)

        'Se asignan los datos del retiro a empleado.datoslaborales y se crea un nuevo registro ACTIVO
        empleado.datosLaborales.estadoRegistro = Comun.TiposDeDatos.EstadoRegistro.ACTIVO
        empleado.datosLaborales.motivoRetiroID = view.GetRowCellValue(view.FocusedRowHandle, "MOTIVO_RETIRO_ID")
        empleado.datosLaborales.fechaRetiro = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_CONTRATO_HASTA")
        empleado.datosLaborales.resolucionRetiro = view.GetRowCellValue(view.FocusedRowHandle, "NRO_SOLUCION")
        empleado.datosLaborales.observacion = ""
        empleado.datosLaborales.descripcionMovimiento = "En Proceso de Retiro"
        empleado.datosLaborales.fechaMovimiento = Date.Today
        empleado.datosLaborales.antecedenteLaboralID = 0
        Try
            empleado.datosLaborales.antecedenteLaboralID = empleado.CrearEmpleadoLaboral()
            System.Windows.Forms.MessageBox.Show("Empleado incluido en el proceso de retiro.", "Siga", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al actualizar " & empleado.nombreCompleto & "." & Chr(13) & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ReactivarEmpleado(ByVal view As DevExpress.XtraGrid.Views.Base.ColumnView)
        'Se actualiza el registro laboral vigente a INACTIVO
        empleado.datosLaborales.estadoRegistro = Comun.TiposDeDatos.EstadoRegistro.INACTIVO
        empleado.datosLaborales.motivoRetiroID = 0
        empleado.actualizarDatosLaboral(empleado.datosLaborales)

        'Se asignan los datos del retiro a empleado.datoslaborales y se crea un nuevo registro ACTIVO
        empleado.datosLaborales.estadoRegistro = Comun.TiposDeDatos.EstadoRegistro.ACTIVO
        empleado.datosLaborales.motivoRetiroID = 0
        empleado.datosLaborales.fechaRetiro = CType("01-01-1900", Date)
        empleado.datosLaborales.resolucionRetiro = ""
        empleado.datosLaborales.observacion = ""
        empleado.datosLaborales.descripcionMovimiento = ""
        empleado.datosLaborales.fechaMovimiento = CType("01-01-1900", Date)
        empleado.datosLaborales.antecedenteLaboralID = 0
        Try
            empleado.datosLaborales.antecedenteLaboralID = empleado.CrearEmpleadoLaboral()
            System.Windows.Forms.MessageBox.Show("Empleado fue reactivado correctamente", "Siga", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al actualizar " & empleado.nombreCompleto & "." & Chr(13) & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class
