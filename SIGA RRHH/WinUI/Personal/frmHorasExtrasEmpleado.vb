Imports cl.presidencia.Argo.Reportes
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns

Public Class frmHorasExtrasEmpleado
    Inherits System.Windows.Forms.Form

    Dim parametroMensual As periodo
    Dim empleado As empleado
    Dim connectionString As String = Comun.ArgoConfiguracion.ConnectionString
    Dim periodo As periodo
    Dim permisoActualizacion As Boolean

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
    Friend WithEvents HORAS_EXTRAS_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_DIGITACIÓN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PERIODO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HORAS_EXTRAS_REAL_DIURNA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HORAS_EXTRAS_REAL_NOCTURNA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TOTAL_HRS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents grdHorasExtras As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvHorasExtras As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents luePeriodos As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents leRUT As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents repositorioEmpleados As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents txtEstadoPeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpcEncabezado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rdgTipoProceso As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lblTipoProceso As System.Windows.Forms.Label
    Friend WithEvents fieldEMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldHORAS_EXTRAS_MAXIMA_DIURNA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldHORAS_EXTRAS_MAXIMA_NOCTURNA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldTOTAL_DIAS_INASISTENCIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldTOTAL_MEDIO_DIAS_INASISTENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldHORAS_ATRASADAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldFECHA_DIGITACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldESTADO_REGISTRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldTIPO_PROCESO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldPERIODO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTotalMedioDiasInasistencia As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtTotalDiasInasistencia As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents fieldHORAS_EXTRAS_DIURNA_REAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldHORAS_EXTRAS_NOCTURNA_REAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldHORAS_ATRASADAS_REAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldHORAS_COMPENSADAS_DIURNA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldHORAS_COMPENSADAS_NOCTURNA As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grdHorasExtras = New DevExpress.XtraGrid.GridControl()
        Me.grvHorasExtras = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.fieldEMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repositorioEmpleados = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldHORAS_COMPENSADAS_DIURNA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldHORAS_COMPENSADAS_NOCTURNA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldHORAS_ATRASADAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldTOTAL_DIAS_INASISTENCIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtTotalDiasInasistencia = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.fieldTOTAL_MEDIO_DIAS_INASISTENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtTotalMedioDiasInasistencia = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.fieldFECHA_DIGITACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldESTADO_REGISTRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldTIPO_PROCESO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldPERIODO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldHORAS_EXTRAS_DIURNA_REAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldHORAS_EXTRAS_NOCTURNA_REAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldHORAS_ATRASADAS_REAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.leRUT = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.luePeriodos = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.HORAS_EXTRAS_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_DIGITACIÓN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PERIODO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.HORAS_EXTRAS_REAL_DIURNA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.HORAS_EXTRAS_REAL_NOCTURNA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TOTAL_HRS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtEstadoPeriodo = New DevExpress.XtraEditors.TextEdit()
        Me.gpcEncabezado = New DevExpress.XtraEditors.GroupControl()
        Me.lblTipoProceso = New System.Windows.Forms.Label()
        Me.rdgTipoProceso = New DevExpress.XtraEditors.RadioGroup()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grdHorasExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvHorasExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositorioEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDiasInasistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalMedioDiasInasistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leRUT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstadoPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcEncabezado.SuspendLayout()
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdHorasExtras
        '
        Me.grdHorasExtras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdHorasExtras.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.grdHorasExtras.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdHorasExtras.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdHorasExtras.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdHorasExtras.EmbeddedNavigator.Buttons.First.Visible = False
        Me.grdHorasExtras.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.grdHorasExtras.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.grdHorasExtras.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.grdHorasExtras.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.grdHorasExtras.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.grdHorasExtras.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.grdHorasExtras.Location = New System.Drawing.Point(8, 104)
        Me.grdHorasExtras.MainView = Me.grvHorasExtras
        Me.grdHorasExtras.Name = "grdHorasExtras"
        Me.grdHorasExtras.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.leRUT, Me.luePeriodos, Me.repositorioEmpleados, Me.txtTotalMedioDiasInasistencia, Me.txtTotalDiasInasistencia})
        Me.grdHorasExtras.Size = New System.Drawing.Size(928, 512)
        Me.grdHorasExtras.TabIndex = 5
        Me.grdHorasExtras.UseEmbeddedNavigator = True
        Me.grdHorasExtras.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvHorasExtras})
        '
        'grvHorasExtras
        '
        Me.grvHorasExtras.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grvHorasExtras.Appearance.FooterPanel.Options.UseFont = True
        Me.grvHorasExtras.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.fieldEMPLEADO_ID, Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA, Me.fieldHORAS_COMPENSADAS_DIURNA, Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA, Me.fieldHORAS_COMPENSADAS_NOCTURNA, Me.fieldHORAS_ATRASADAS, Me.fieldTOTAL_DIAS_INASISTENCIAS, Me.fieldTOTAL_MEDIO_DIAS_INASISTENCIA, Me.fieldFECHA_DIGITACION, Me.fieldESTADO_REGISTRO, Me.fieldTIPO_PROCESO, Me.fieldPERIODO_ID, Me.fieldHORAS_EXTRAS_DIURNA_REAL, Me.fieldHORAS_EXTRAS_NOCTURNA_REAL, Me.fieldHORAS_ATRASADAS_REAL})
        Me.grvHorasExtras.GridControl = Me.grdHorasExtras
        Me.grvHorasExtras.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.grvHorasExtras.Name = "grvHorasExtras"
        Me.grvHorasExtras.NewItemRowText = "Nuevo Registro"
        Me.grvHorasExtras.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.grvHorasExtras.OptionsView.ShowFooter = True
        '
        'fieldEMPLEADO_ID
        '
        Me.fieldEMPLEADO_ID.Caption = "Nombre Empleado"
        Me.fieldEMPLEADO_ID.ColumnEdit = Me.repositorioEmpleados
        Me.fieldEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.fieldEMPLEADO_ID.Name = "fieldEMPLEADO_ID"
        Me.fieldEMPLEADO_ID.Visible = True
        Me.fieldEMPLEADO_ID.VisibleIndex = 0
        Me.fieldEMPLEADO_ID.Width = 325
        '
        'repositorioEmpleados
        '
        Me.repositorioEmpleados.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.repositorioEmpleados.AutoHeight = False
        Me.repositorioEmpleados.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositorioEmpleados.Name = "repositorioEmpleados"
        Me.repositorioEmpleados.NullText = ""
        Me.repositorioEmpleados.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'fieldHORAS_EXTRAS_MAXIMA_DIURNA
        '
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.Caption = "H.Diurnas"
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.FieldName = "HORAS_EXTRAS_MAXIMA_DIURNA"
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.Name = "fieldHORAS_EXTRAS_MAXIMA_DIURNA"
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.SummaryItem.DisplayFormat = "{0:n0}"
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.Visible = True
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.VisibleIndex = 1
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.Width = 69
        '
        'fieldHORAS_COMPENSADAS_DIURNA
        '
        Me.fieldHORAS_COMPENSADAS_DIURNA.Caption = "H.Comp.Diurna"
        Me.fieldHORAS_COMPENSADAS_DIURNA.FieldName = "HORAS_COMPENSADAS_DIURNA"
        Me.fieldHORAS_COMPENSADAS_DIURNA.Name = "fieldHORAS_COMPENSADAS_DIURNA"
        Me.fieldHORAS_COMPENSADAS_DIURNA.Visible = True
        Me.fieldHORAS_COMPENSADAS_DIURNA.VisibleIndex = 2
        Me.fieldHORAS_COMPENSADAS_DIURNA.Width = 91
        '
        'fieldHORAS_EXTRAS_MAXIMA_NOCTURNA
        '
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.Caption = "H.Nocturnas"
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.FieldName = "HORAS_EXTRAS_MAXIMA_NOCTURNA"
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.Name = "fieldHORAS_EXTRAS_MAXIMA_NOCTURNA"
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.SummaryItem.DisplayFormat = "{0:n0}"
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.Visible = True
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.VisibleIndex = 3
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.Width = 84
        '
        'fieldHORAS_COMPENSADAS_NOCTURNA
        '
        Me.fieldHORAS_COMPENSADAS_NOCTURNA.Caption = "H.Comp.Nocturnas"
        Me.fieldHORAS_COMPENSADAS_NOCTURNA.FieldName = "HORAS_COMPENSADAS_NOCTURNA"
        Me.fieldHORAS_COMPENSADAS_NOCTURNA.Name = "fieldHORAS_COMPENSADAS_NOCTURNA"
        Me.fieldHORAS_COMPENSADAS_NOCTURNA.Visible = True
        Me.fieldHORAS_COMPENSADAS_NOCTURNA.VisibleIndex = 4
        Me.fieldHORAS_COMPENSADAS_NOCTURNA.Width = 113
        '
        'fieldHORAS_ATRASADAS
        '
        Me.fieldHORAS_ATRASADAS.Caption = "Hrs.Atraso"
        Me.fieldHORAS_ATRASADAS.FieldName = "HORAS_ATRASADAS"
        Me.fieldHORAS_ATRASADAS.Name = "fieldHORAS_ATRASADAS"
        Me.fieldHORAS_ATRASADAS.Visible = True
        Me.fieldHORAS_ATRASADAS.VisibleIndex = 5
        Me.fieldHORAS_ATRASADAS.Width = 83
        '
        'fieldTOTAL_DIAS_INASISTENCIAS
        '
        Me.fieldTOTAL_DIAS_INASISTENCIAS.Caption = "Total Días Inasistencia"
        Me.fieldTOTAL_DIAS_INASISTENCIAS.ColumnEdit = Me.txtTotalDiasInasistencia
        Me.fieldTOTAL_DIAS_INASISTENCIAS.FieldName = "TOTAL_DIAS_INASISTENCIAS"
        Me.fieldTOTAL_DIAS_INASISTENCIAS.Name = "fieldTOTAL_DIAS_INASISTENCIAS"
        Me.fieldTOTAL_DIAS_INASISTENCIAS.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.fieldTOTAL_DIAS_INASISTENCIAS.Width = 99
        '
        'txtTotalDiasInasistencia
        '
        Me.txtTotalDiasInasistencia.AutoHeight = False
        Me.txtTotalDiasInasistencia.Mask.EditMask = "n0"
        Me.txtTotalDiasInasistencia.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalDiasInasistencia.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalDiasInasistencia.MaxLength = 2
        Me.txtTotalDiasInasistencia.Name = "txtTotalDiasInasistencia"
        '
        'fieldTOTAL_MEDIO_DIAS_INASISTENCIA
        '
        Me.fieldTOTAL_MEDIO_DIAS_INASISTENCIA.Caption = "Total 1/2 Días Inasistencia"
        Me.fieldTOTAL_MEDIO_DIAS_INASISTENCIA.ColumnEdit = Me.txtTotalMedioDiasInasistencia
        Me.fieldTOTAL_MEDIO_DIAS_INASISTENCIA.FieldName = "TOTAL_MEDIO_DIAS_INASISTENCIA"
        Me.fieldTOTAL_MEDIO_DIAS_INASISTENCIA.Name = "fieldTOTAL_MEDIO_DIAS_INASISTENCIA"
        Me.fieldTOTAL_MEDIO_DIAS_INASISTENCIA.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.fieldTOTAL_MEDIO_DIAS_INASISTENCIA.Visible = True
        Me.fieldTOTAL_MEDIO_DIAS_INASISTENCIA.VisibleIndex = 6
        Me.fieldTOTAL_MEDIO_DIAS_INASISTENCIA.Width = 323
        '
        'txtTotalMedioDiasInasistencia
        '
        Me.txtTotalMedioDiasInasistencia.AutoHeight = False
        Me.txtTotalMedioDiasInasistencia.Mask.EditMask = "n1"
        Me.txtTotalMedioDiasInasistencia.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalMedioDiasInasistencia.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalMedioDiasInasistencia.MaxLength = 2
        Me.txtTotalMedioDiasInasistencia.Name = "txtTotalMedioDiasInasistencia"
        '
        'fieldFECHA_DIGITACION
        '
        Me.fieldFECHA_DIGITACION.Caption = "Fecha Digitación"
        Me.fieldFECHA_DIGITACION.FieldName = "FECHA_DIGITACION"
        Me.fieldFECHA_DIGITACION.Name = "fieldFECHA_DIGITACION"
        Me.fieldFECHA_DIGITACION.OptionsColumn.ReadOnly = True
        '
        'fieldESTADO_REGISTRO
        '
        Me.fieldESTADO_REGISTRO.Caption = "Estado Reg."
        Me.fieldESTADO_REGISTRO.FieldName = "ESTADO_REGISTRO"
        Me.fieldESTADO_REGISTRO.Name = "fieldESTADO_REGISTRO"
        Me.fieldESTADO_REGISTRO.OptionsColumn.ReadOnly = True
        '
        'fieldTIPO_PROCESO
        '
        Me.fieldTIPO_PROCESO.Caption = "Tipo Proceso"
        Me.fieldTIPO_PROCESO.FieldName = "TIPO_PROCESO"
        Me.fieldTIPO_PROCESO.Name = "fieldTIPO_PROCESO"
        Me.fieldTIPO_PROCESO.OptionsColumn.ReadOnly = True
        '
        'fieldPERIODO_ID
        '
        Me.fieldPERIODO_ID.Caption = "Periodo ID"
        Me.fieldPERIODO_ID.FieldName = "PERIODO_ID"
        Me.fieldPERIODO_ID.Name = "fieldPERIODO_ID"
        Me.fieldPERIODO_ID.OptionsColumn.ReadOnly = True
        '
        'fieldHORAS_EXTRAS_DIURNA_REAL
        '
        Me.fieldHORAS_EXTRAS_DIURNA_REAL.Caption = "H.Ext.Diurnas Real"
        Me.fieldHORAS_EXTRAS_DIURNA_REAL.FieldName = "HORAS_EXTRAS_DIURNA_REAL"
        Me.fieldHORAS_EXTRAS_DIURNA_REAL.Name = "fieldHORAS_EXTRAS_DIURNA_REAL"
        '
        'fieldHORAS_EXTRAS_NOCTURNA_REAL
        '
        Me.fieldHORAS_EXTRAS_NOCTURNA_REAL.Caption = "H.Ext.Noct.Real"
        Me.fieldHORAS_EXTRAS_NOCTURNA_REAL.FieldName = "HORAS_EXTRAS_NOCTURNA_REAL"
        Me.fieldHORAS_EXTRAS_NOCTURNA_REAL.Name = "fieldHORAS_EXTRAS_NOCTURNA_REAL"
        '
        'fieldHORAS_ATRASADAS_REAL
        '
        Me.fieldHORAS_ATRASADAS_REAL.Caption = "H.Atraso Real"
        Me.fieldHORAS_ATRASADAS_REAL.FieldName = "HORAS_ATRASADAS_REAL"
        Me.fieldHORAS_ATRASADAS_REAL.Name = "fieldHORAS_ATRASADAS_REAL"
        '
        'leRUT
        '
        Me.leRUT.AutoHeight = False
        Me.leRUT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leRUT.Name = "leRUT"
        '
        'luePeriodos
        '
        Me.luePeriodos.AutoHeight = False
        Me.luePeriodos.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodos.Name = "luePeriodos"
        '
        'HORAS_EXTRAS_ID
        '
        Me.HORAS_EXTRAS_ID.Caption = "ID Horas Extras"
        Me.HORAS_EXTRAS_ID.FieldName = "HORAS_EXTRAS_ID"
        Me.HORAS_EXTRAS_ID.Name = "HORAS_EXTRAS_ID"
        '
        'FECHA_DIGITACIÓN
        '
        Me.FECHA_DIGITACIÓN.Caption = "Fecha Digitación"
        Me.FECHA_DIGITACIÓN.FieldName = "FECHA_DIGITACIÓN"
        Me.FECHA_DIGITACIÓN.Name = "FECHA_DIGITACIÓN"
        '
        'PERIODO_ID
        '
        Me.PERIODO_ID.Caption = "Periodo"
        Me.PERIODO_ID.ColumnEdit = Me.luePeriodos
        Me.PERIODO_ID.FieldName = "PERIODO_ID"
        Me.PERIODO_ID.Name = "PERIODO_ID"
        Me.PERIODO_ID.Visible = True
        Me.PERIODO_ID.VisibleIndex = 1
        Me.PERIODO_ID.Width = 89
        '
        'HORAS_EXTRAS_REAL_DIURNA
        '
        Me.HORAS_EXTRAS_REAL_DIURNA.Caption = "Hrs.Extras Diurnas"
        Me.HORAS_EXTRAS_REAL_DIURNA.FieldName = "HORAS_EXTRAS_REAL_DIURNA"
        Me.HORAS_EXTRAS_REAL_DIURNA.Name = "HORAS_EXTRAS_REAL_DIURNA"
        Me.HORAS_EXTRAS_REAL_DIURNA.Visible = True
        Me.HORAS_EXTRAS_REAL_DIURNA.VisibleIndex = 2
        Me.HORAS_EXTRAS_REAL_DIURNA.Width = 89
        '
        'HORAS_EXTRAS_REAL_NOCTURNA
        '
        Me.HORAS_EXTRAS_REAL_NOCTURNA.Caption = "Hrs.Extras Nocturnas"
        Me.HORAS_EXTRAS_REAL_NOCTURNA.FieldName = "HORAS_EXTRAS_REAL_NOCTURNA"
        Me.HORAS_EXTRAS_REAL_NOCTURNA.Name = "HORAS_EXTRAS_REAL_NOCTURNA"
        Me.HORAS_EXTRAS_REAL_NOCTURNA.Visible = True
        Me.HORAS_EXTRAS_REAL_NOCTURNA.VisibleIndex = 3
        Me.HORAS_EXTRAS_REAL_NOCTURNA.Width = 89
        '
        'TOTAL_HRS
        '
        Me.TOTAL_HRS.Caption = "Total Horas"
        Me.TOTAL_HRS.FieldName = "TOTAL_HRS"
        Me.TOTAL_HRS.Name = "TOTAL_HRS"
        Me.TOTAL_HRS.Visible = True
        Me.TOTAL_HRS.VisibleIndex = 4
        Me.TOTAL_HRS.Width = 94
        '
        'luePeriodo
        '
        Me.luePeriodo.EditValue = ""
        Me.luePeriodo.Location = New System.Drawing.Point(168, 30)
        Me.luePeriodo.Name = "luePeriodo"
        Me.luePeriodo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("(None)", "(None)")})
        Me.luePeriodo.Properties.NullText = ""
        Me.luePeriodo.Size = New System.Drawing.Size(104, 20)
        Me.luePeriodo.TabIndex = 16
        '
        'txtEstadoPeriodo
        '
        Me.txtEstadoPeriodo.Enabled = False
        Me.txtEstadoPeriodo.Location = New System.Drawing.Point(280, 29)
        Me.txtEstadoPeriodo.Name = "txtEstadoPeriodo"
        Me.txtEstadoPeriodo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtEstadoPeriodo.Properties.Appearance.Options.UseFont = True
        Me.txtEstadoPeriodo.Size = New System.Drawing.Size(112, 20)
        Me.txtEstadoPeriodo.TabIndex = 17
        '
        'gpcEncabezado
        '
        Me.gpcEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcEncabezado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcEncabezado.AppearanceCaption.Options.UseFont = True
        Me.gpcEncabezado.Controls.Add(Me.lblTipoProceso)
        Me.gpcEncabezado.Controls.Add(Me.rdgTipoProceso)
        Me.gpcEncabezado.Controls.Add(Me.btnImprimir)
        Me.gpcEncabezado.Controls.Add(Me.Label1)
        Me.gpcEncabezado.Controls.Add(Me.txtEstadoPeriodo)
        Me.gpcEncabezado.Controls.Add(Me.luePeriodo)
        Me.gpcEncabezado.Location = New System.Drawing.Point(9, 4)
        Me.gpcEncabezado.Name = "gpcEncabezado"
        Me.gpcEncabezado.Size = New System.Drawing.Size(927, 100)
        Me.gpcEncabezado.TabIndex = 18
        Me.gpcEncabezado.Text = "Período"
        '
        'lblTipoProceso
        '
        Me.lblTipoProceso.Location = New System.Drawing.Point(88, 64)
        Me.lblTipoProceso.Name = "lblTipoProceso"
        Me.lblTipoProceso.Size = New System.Drawing.Size(72, 16)
        Me.lblTipoProceso.TabIndex = 51
        Me.lblTipoProceso.Text = "Tipo Proceso"
        Me.lblTipoProceso.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'rdgTipoProceso
        '
        Me.rdgTipoProceso.Location = New System.Drawing.Point(168, 56)
        Me.rdgTipoProceso.Name = "rdgTipoProceso"
        Me.rdgTipoProceso.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("N", "Normal"), New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Suplemetaria")})
        Me.rdgTipoProceso.Size = New System.Drawing.Size(224, 32)
        Me.rdgTipoProceso.TabIndex = 50
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.Location = New System.Drawing.Point(712, 48)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(152, 23)
        Me.btnImprimir.TabIndex = 49
        Me.btnImprimir.Text = "&Imprimir"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(112, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Período"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmHorasExtrasEmpleado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(944, 622)
        Me.Controls.Add(Me.gpcEncabezado)
        Me.Controls.Add(Me.grdHorasExtras)
        Me.Name = "frmHorasExtrasEmpleado"
        Me.Text = "Horas Extras Empleados"
        CType(Me.grdHorasExtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvHorasExtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositorioEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDiasInasistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalMedioDiasInasistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leRUT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstadoPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcEncabezado.ResumeLayout(False)
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Funciones"
    Private Sub initCampoRut()

        repositorioEmpleados.ViewType = Repository.GridLookUpViewType.GridView
        repositorioEmpleados.View.OptionsBehavior.AutoPopulateColumns = False
        'repositorioEmpleados.DataSource = repositorio.dvEmpleadosPlantaContrataActivos
        repositorioEmpleados.DataSource = repositorio.dvEmpleadoVista
        repositorioEmpleados.DisplayMember = "NOMBRE_COMPLETO"

        Dim col2 As GridColumn = repositorioEmpleados.View.Columns.AddField("RUT")
        col2.VisibleIndex = 0
        col2.Caption = "RUT"

        Dim col1 As GridColumn = repositorioEmpleados.View.Columns.AddField("APELLIDO_PATERNO")
        col1.VisibleIndex = 1
        col1.Caption = "Apellido Paterno"

        Dim col3 As GridColumn = repositorioEmpleados.View.Columns.AddField("APELLIDO_MATERNO")
        col3.VisibleIndex = 2
        col3.Caption = "Apellido Materno"

        Dim col4 As GridColumn = repositorioEmpleados.View.Columns.AddField("NOMBRES")
        col4.VisibleIndex = 3
        col4.Caption = "Nombres"

        Dim col5 As GridColumn = repositorioEmpleados.View.Columns.AddField("DESC_ESTADO")
        col5.VisibleIndex = 4
        col5.Caption = "Estado"

        Dim col6 As GridColumn = repositorioEmpleados.View.Columns.AddField("DESC_CALIDAD_JURIDICA")
        col6.VisibleIndex = 5
        col6.Caption = "Calidad Jurídica"

        Dim col7 As GridColumn = repositorioEmpleados.View.Columns.AddField("EMPLEADO_ID")
        col7.VisibleIndex = 6
        col7.Caption = "ID Empleado"
        col7.Visible = False

        repositorioEmpleados.ValueMember = "EMPLEADO_ID"
        repositorioEmpleados.View.BestFitColumns()
        repositorioEmpleados.PopupFormWidth = 600


    End Sub
#End Region

    Private Sub frmHorasExtrasEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empleado = New Empleado
        parametroMensual = New periodo

        'Habilia la funcionalidad para agregar, modificar o eliminar registros de horas extras a pagar
        permisoActualizacion = Seguridad.TienePermiso("REM-Cálculo Remuneraciones") Or Seguridad.TienePermiso("REM-Acceso Total")

        repositorio.Show()
        initCampoRut()
        With Me
            Comun.Utiles.fillLookUpEdit(luePeriodo, _
                               (Utiles.fillDataview(Comun.SQL.VISTAS.SELECT_PERIODOS_AÑOMES, _
                               Comun.Tablas.RH_REM_PERIODO, "ANOMES", "PERIODO_ID", _
                               connectionString)), "ANOMES", "PERIODO_ID")
        End With
        grvHorasExtras.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None

    End Sub

    Private Sub grvHorasExtras_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grvHorasExtras.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("¿Desea Eliminar?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
            Dim idHoraExtra As Integer = view.GetRowCellValue(view.FocusedRowHandle, "HORAS_EXTRAS_ID")
            empleado.EliminarRegistroHoraExtra(idHoraExtra)
            refrescarDetalle()
        End If
    End Sub

    Private Sub luePeriodo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
        Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
        If Not IsNothing(row) Then
            periodo = New periodo(CType(row("PERIODO_ID"), Integer))
            If luePeriodo.EditValue <> Nothing Then
                refrescarDetalle()
            End If

            'Si el estado del periodo es 0 (No Activo) deshabilita la grilla
            If periodo.estadoPeriodo = False Then
                'grdHorasExtras.Enabled = False
                txtEstadoPeriodo.Text = "INACTIVO"
            Else
                'grdHorasExtras.Enabled = True
                txtEstadoPeriodo.Text = "ACTIVO"
            End If
            btnImprimir.Enabled = True
        Else
            btnImprimir.Enabled = False
        End If
    End Sub
    Private Sub grdHorasExtras_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles grvHorasExtras.RowUpdated
        empleado.actualizarDatosHorasExtras()
        refrescarDetalle()
    End Sub
    Private Sub grdHorasExtras_InitNewRow1(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles grvHorasExtras.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        view.SetRowCellValue(e.RowHandle, "PERIODO_ID", luePeriodo.EditValue)
        view.SetRowCellValue(e.RowHandle, "FECHA_DIGITACION", Date.Now)
        view.SetRowCellValue(e.RowHandle, "ESTADO_REGISTRO", 2)
        view.SetRowCellValue(e.RowHandle, "TIPO_PROCESO", rdgTipoProceso.EditValue)
        view.SetRowCellValue(e.RowHandle, "HORAS_EXTRAS_MAXIMA_DIURNA", 0)
        view.SetRowCellValue(e.RowHandle, "HORAS_EXTRAS_MAXIMA_NOCTURNA", 0)
        view.SetRowCellValue(e.RowHandle, "HORAS_ATRASADAS", 0)
        view.SetRowCellValue(e.RowHandle, "TOTAL_DIAS_INASISTENCIAS", 0)
        view.SetRowCellValue(e.RowHandle, "TOTAL_MEDIO_DIAS_INASISTENCIA", 0)
        view.SetRowCellValue(e.RowHandle, "HORAS_EXTRAS_DIURNA_REAL", 0)
        view.SetRowCellValue(e.RowHandle, "HORAS_EXTRAS_NOCTURNA_REAL", 0)
        view.SetRowCellValue(e.RowHandle, "HORAS_ATRASADAS_REAL", 0)
        view.SetRowCellValue(e.RowHandle, "HORAS_COMPENSADAS_DIURNA", 0)
        view.SetRowCellValue(e.RowHandle, "HORAS_COMPENSADAS_NOCTURNA", 0)
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptHorasExtrasPeriodo
        Dim tipoProceso As String
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        If rdgTipoProceso.EditValue = "N" Then
            tipoProceso = "NORMAL"
        Else
            tipoProceso = "SUPLEMENTARIA"
        End If
        reporte.RecordSelectionFormula = "{VW_RH_PER_HORAS_EXTRAS.PERIODO_ID}= " & luePeriodo.EditValue
        reporte.RecordSelectionFormula &= " AND {VW_RH_PER_HORAS_EXTRAS.TIPO_PROCESO}= """ + rdgTipoProceso.EditValue + """"
        reporte.SummaryInfo.ReportTitle = "INFORME MENSUAL DE HORAS EXTRAS, ATRASOS E INASISTENCIA (PROCESO " & tipoProceso & ")"
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.rptVisor.ShowParameterPanelButton = False
        ventanaReporte1.rptVisor.ShowCloseButton = False
        ventanaReporte1.rptVisor.ShowGroupTreeButton = False
        ventanaReporte1.Show()
    End Sub
    Private Sub rdgTipoProceso_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdgTipoProceso.EditValueChanged
        refrescarDetalle()
    End Sub
    Private Sub refrescarDetalle()
        If luePeriodo.EditValue <> Nothing Then
            empleado = New Empleado
            habilitaGrilla()
            grdHorasExtras.DataSource = empleado.dvHorasExtrasPorPeriodo(luePeriodo.EditValue, rdgTipoProceso.EditValue)

        End If
    End Sub

    Private Sub grvHorasExtras_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles grvHorasExtras.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub grvHorasExtras_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles grvHorasExtras.ValidateRow
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        e.Valid = True
        If view.GetRowCellValue(view.FocusedRowHandle, view.Columns("EMPLEADO_ID")) = 0 Then
            MsgBox("Falta ingresar empleado", MsgBoxStyle.Information)
            e.Valid = False
        End If
        If view.GetRowCellValue(view.FocusedRowHandle, view.Columns("HORAS_EXTRAS_MAXIMA_DIURNA")) + view.GetRowCellValue(view.FocusedRowHandle, view.Columns("HORAS_EXTRAS_MAXIMA_NOCTURNA")) + view.GetRowCellValue(view.FocusedRowHandle, view.Columns("TOTAL_DIAS_INASISTENCIAS")) + view.GetRowCellValue(view.FocusedRowHandle, view.Columns("HORAS_ATRASADAS")) = 0 Then
             MsgBox("Horas diurnas o nocturnas deben ser mayor a cero", MsgBoxStyle.Information)
            e.Valid = False
        End If
        If view.GetRowCellValue(view.FocusedRowHandle, view.Columns("HORAS_EXTRAS_MAXIMA_DIURNA")) > parametroMensual.numHrsExtrasLegalDiurnas Then
            MsgBox("Horas diurnas no debe ser superior a " & CType(parametroMensual.numHrsExtrasLegalDiurnas, String), MsgBoxStyle.Information)
            e.Valid = False
        End If

    End Sub

    Private Sub repositorioEmpleados_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles repositorioEmpleados.Validating
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = grvHorasExtras
        Dim edicion As DevExpress.XtraEditors.BaseEdit = view.ActiveEditor
        Dim idEmple As Integer = empleado.recuperaIdentificador(comandosSQL(edicion.EditValue))
        If idEmple > 0 Then
            MsgBox("Ya existe registro para el empleado especificado", MsgBoxStyle.Information)
            e.Cancel = True
        End If
    End Sub
    Private Function comandosSQL(ByVal idEmpleado As Integer) As String
        Dim cmdProceso, cmdSQL As String
        cmdProceso = " AND TIPO_PROCESO=" + "'" + rdgTipoProceso.EditValue + "'"
        cmdSQL = "SELECT HORAS_EXTRAS_ID FROM " & Tablas.RH_PER_HORAS_EXTRAS & " WHERE EMPLEADO_ID=" & idEmpleado & " AND PERIODO_ID=" & luePeriodo.EditValue & cmdProceso
        Return cmdSQL
    End Function

    Private Sub rdgTipoProceso_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdgTipoProceso.SelectedIndexChanged
        habilitaGrilla()
    End Sub

    Private Sub habilitaGrilla()
        Dim habilitaGrilla As Boolean

        If periodo.estadoPeriodo Then
            If periodo.procesoSuplementarioCerrado And rdgTipoProceso.EditValue = "S" Then
                habilitaGrilla = False
            Else
                habilitaGrilla = True
            End If
        Else
            habilitaGrilla = False
        End If

        If permisoActualizacion And habilitaGrilla Then
            Me.fieldEMPLEADO_ID.OptionsColumn.ReadOnly = False
            Me.fieldESTADO_REGISTRO.OptionsColumn.ReadOnly = True
            Me.fieldFECHA_DIGITACION.OptionsColumn.ReadOnly = True
            Me.fieldHORAS_ATRASADAS.OptionsColumn.ReadOnly = False
            Me.fieldHORAS_ATRASADAS_REAL.OptionsColumn.ReadOnly = True
            Me.fieldHORAS_COMPENSADAS_DIURNA.OptionsColumn.ReadOnly = True
            Me.fieldHORAS_COMPENSADAS_NOCTURNA.OptionsColumn.ReadOnly = True
            Me.fieldHORAS_EXTRAS_DIURNA_REAL.OptionsColumn.ReadOnly = True
            Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.OptionsColumn.ReadOnly = False
            Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.OptionsColumn.ReadOnly = False
            Me.fieldHORAS_EXTRAS_NOCTURNA_REAL.OptionsColumn.ReadOnly = True
            Me.fieldPERIODO_ID.OptionsColumn.ReadOnly = True
            Me.fieldTIPO_PROCESO.OptionsColumn.ReadOnly = True
            Me.fieldTOTAL_DIAS_INASISTENCIAS.OptionsColumn.ReadOnly = True
            Me.fieldTOTAL_MEDIO_DIAS_INASISTENCIA.OptionsColumn.ReadOnly = False
            grvHorasExtras.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Else
            Me.fieldEMPLEADO_ID.OptionsColumn.ReadOnly = True
            Me.fieldESTADO_REGISTRO.OptionsColumn.ReadOnly = True
            Me.fieldFECHA_DIGITACION.OptionsColumn.ReadOnly = True
            Me.fieldHORAS_ATRASADAS.OptionsColumn.ReadOnly = False
            Me.fieldHORAS_ATRASADAS_REAL.OptionsColumn.ReadOnly = True
            Me.fieldHORAS_COMPENSADAS_DIURNA.OptionsColumn.ReadOnly = True
            Me.fieldHORAS_COMPENSADAS_NOCTURNA.OptionsColumn.ReadOnly = True
            Me.fieldHORAS_EXTRAS_DIURNA_REAL.OptionsColumn.ReadOnly = True
            Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.OptionsColumn.ReadOnly = True
            Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.OptionsColumn.ReadOnly = True
            Me.fieldHORAS_EXTRAS_NOCTURNA_REAL.OptionsColumn.ReadOnly = True
            Me.fieldPERIODO_ID.OptionsColumn.ReadOnly = True
            Me.fieldTIPO_PROCESO.OptionsColumn.ReadOnly = True
            Me.fieldTOTAL_DIAS_INASISTENCIAS.OptionsColumn.ReadOnly = True
            Me.fieldTOTAL_MEDIO_DIAS_INASISTENCIA.OptionsColumn.ReadOnly = False
            grvHorasExtras.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        End If
    End Sub
End Class
