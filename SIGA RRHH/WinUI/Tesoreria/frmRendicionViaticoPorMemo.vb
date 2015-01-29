Imports cl.presidencia.Argo.Reportes
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun
Imports System.Data.SqlClient
Imports System.IO

Public Class frmRendicionViaticoPorMemo
    Inherits System.Windows.Forms.Form

    Private Enum tipoEstadoViatico
        PENDIENTE = 0
        PAGADO = 1
    End Enum

    Private empleado As New empleado
    Private connectionString As String = Comun.ArgoConfiguracion.ConnectionString
    Private viatico As New viatico
    Private arrayViatico() As Integer = New Integer() {}

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
    Friend WithEvents luePeriodos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents dvPeriodo As System.Data.DataView
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents prnListadoViaticos As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents txtMontoCheque As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents lblMonto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNombres As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblApellidos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtApellidos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFechaCheque As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dedFechaCheque As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNumeroCheque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGenerarCheque As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colVIATICO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVIATICO_DETALLE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAPELLIDO_PATERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAPELLIDO_MATERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_TERMINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCANTIDAD_DIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPAIS_DESTINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREGION_DESTINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTR_ESTADO_VIATICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNRO_MEMORANDUM_INTERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUMERO_DOCUMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO_VIATICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gpcCriteriosBusqueda As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gpcResultado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gdvViaticosAsociados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsViatico1 As cl.presidencia.Argo.DataAccess.DSViatico
    Friend WithEvents gdcMemorandums As DevExpress.XtraGrid.GridControl
    Friend WithEvents colVIATICO_ID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNRO_MEMORANDUM_INTERNO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_MEMORANDUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colANO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPTO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTR_ESTADO_VIATICO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO_VIATICO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSELECCIONAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkAceptar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents gdvMemoramdumsDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rdgTipoEstado As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents colDEPARTAMENTO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEGRESO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gdcViaticosAsociados As DevExpress.XtraGrid.GridControl
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents btnEmitirEgreso As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumCtaCte As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colNUMERO_DOCUMENTO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_DOCUMENTO As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRendicionViaticoPorMemo))
        Me.gpcCriteriosBusqueda = New DevExpress.XtraEditors.GroupControl()
        Me.rdgTipoEstado = New DevExpress.XtraEditors.RadioGroup()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.gdcMemorandums = New DevExpress.XtraGrid.GridControl()
        Me.DsViatico1 = New cl.presidencia.Argo.DataAccess.DSViatico()
        Me.gdvMemoramdumsDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colVIATICO_ID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNRO_MEMORANDUM_INTERNO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_MEMORANDUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colANO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPTO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTR_ESTADO_VIATICO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO_VIATICO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEGRESO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSELECCIONAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkAceptar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colNUMERO_DOCUMENTO2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_DOCUMENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luePeriodos = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dvPeriodo = New System.Data.DataView()
        Me.gpcResultado = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumCtaCte = New DevExpress.XtraEditors.TextEdit()
        Me.btnEmitirEgreso = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAnular = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGenerarCheque = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumeroCheque = New DevExpress.XtraEditors.TextEdit()
        Me.dedFechaCheque = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaCheque = New DevExpress.XtraEditors.LabelControl()
        Me.txtApellidos = New DevExpress.XtraEditors.TextEdit()
        Me.lblApellidos = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombres = New DevExpress.XtraEditors.TextEdit()
        Me.txtMonto = New DevExpress.XtraEditors.TextEdit()
        Me.lblNombres = New DevExpress.XtraEditors.LabelControl()
        Me.lblMonto = New DevExpress.XtraEditors.LabelControl()
        Me.gdcViaticosAsociados = New DevExpress.XtraGrid.GridControl()
        Me.gdvViaticosAsociados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colVIATICO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVIATICO_DETALLE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNRO_MEMORANDUM_INTERNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAPELLIDO_PATERNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAPELLIDO_MATERNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_INICIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_TERMINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCANTIDAD_DIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPAIS_DESTINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colREGION_DESTINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMontoCheque = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colSTR_ESTADO_VIATICO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNUMERO_DOCUMENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO_VIATICO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPARTAMENTO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.prnListadoViaticos = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        CType(Me.gpcCriteriosBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcCriteriosBusqueda.SuspendLayout()
        CType(Me.rdgTipoEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcMemorandums, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsViatico1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvMemoramdumsDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcResultado.SuspendLayout()
        CType(Me.txtNumCtaCte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroCheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaCheque.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaCheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcViaticosAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvViaticosAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prnListadoViaticos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcCriteriosBusqueda
        '
        Me.gpcCriteriosBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcCriteriosBusqueda.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcCriteriosBusqueda.AppearanceCaption.Options.UseFont = True
        Me.gpcCriteriosBusqueda.Controls.Add(Me.rdgTipoEstado)
        Me.gpcCriteriosBusqueda.Controls.Add(Me.btnBuscar)
        Me.gpcCriteriosBusqueda.Controls.Add(Me.gdcMemorandums)
        Me.gpcCriteriosBusqueda.Controls.Add(Me.luePeriodos)
        Me.gpcCriteriosBusqueda.Controls.Add(Me.lblPeriodo)
        Me.gpcCriteriosBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.gpcCriteriosBusqueda.Name = "gpcCriteriosBusqueda"
        Me.gpcCriteriosBusqueda.Size = New System.Drawing.Size(928, 208)
        Me.gpcCriteriosBusqueda.TabIndex = 49
        Me.gpcCriteriosBusqueda.Text = "Criterios de Búsqueda"
        '
        'rdgTipoEstado
        '
        Me.rdgTipoEstado.EditValue = 0
        Me.rdgTipoEstado.Location = New System.Drawing.Point(464, 24)
        Me.rdgTipoEstado.Name = "rdgTipoEstado"
        Me.rdgTipoEstado.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Pendientes"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Pagados")})
        Me.rdgTipoEstado.Size = New System.Drawing.Size(176, 32)
        Me.rdgTipoEstado.TabIndex = 102
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(240, 32)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(184, 23)
        Me.btnBuscar.TabIndex = 101
        Me.btnBuscar.Text = "Buscar Registros Seleccionados"
        '
        'gdcMemorandums
        '
        Me.gdcMemorandums.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcMemorandums.DataSource = Me.DsViatico1.VW_VIATICO_NUMERO_MEMORANDUM
        Me.gdcMemorandums.Location = New System.Drawing.Point(0, 64)
        Me.gdcMemorandums.MainView = Me.gdvMemoramdumsDetalle
        Me.gdcMemorandums.Name = "gdcMemorandums"
        Me.gdcMemorandums.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkAceptar})
        Me.gdcMemorandums.Size = New System.Drawing.Size(784, 128)
        Me.gdcMemorandums.TabIndex = 100
        Me.gdcMemorandums.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvMemoramdumsDetalle})
        '
        'DsViatico1
        '
        Me.DsViatico1.DataSetName = "DSViatico"
        Me.DsViatico1.Locale = New System.Globalization.CultureInfo("es-CL")
        Me.DsViatico1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gdvMemoramdumsDetalle
        '
        Me.gdvMemoramdumsDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVIATICO_ID1, Me.colNRO_MEMORANDUM_INTERNO1, Me.colFECHA_MEMORANDUM, Me.colANO, Me.colMES, Me.colDEPTO_ID, Me.colDEPARTAMENTO, Me.colSTR_ESTADO_VIATICO1, Me.colESTADO_VIATICO1, Me.colDESCRIPCION, Me.colEGRESO_ID, Me.colSELECCIONAR, Me.colNUMERO_DOCUMENTO2, Me.colFECHA_DOCUMENTO})
        Me.gdvMemoramdumsDetalle.GridControl = Me.gdcMemorandums
        Me.gdvMemoramdumsDetalle.Name = "gdvMemoramdumsDetalle"
        Me.gdvMemoramdumsDetalle.OptionsView.ShowGroupPanel = False
        '
        'colVIATICO_ID1
        '
        Me.colVIATICO_ID1.Caption = "VIATICO_ID"
        Me.colVIATICO_ID1.FieldName = "VIATICO_ID"
        Me.colVIATICO_ID1.Name = "colVIATICO_ID1"
        '
        'colNRO_MEMORANDUM_INTERNO1
        '
        Me.colNRO_MEMORANDUM_INTERNO1.Caption = "Memo Interno"
        Me.colNRO_MEMORANDUM_INTERNO1.FieldName = "NRO_MEMORANDUM_INTERNO"
        Me.colNRO_MEMORANDUM_INTERNO1.Name = "colNRO_MEMORANDUM_INTERNO1"
        Me.colNRO_MEMORANDUM_INTERNO1.OptionsColumn.AllowEdit = False
        Me.colNRO_MEMORANDUM_INTERNO1.OptionsColumn.ReadOnly = True
        Me.colNRO_MEMORANDUM_INTERNO1.Visible = True
        Me.colNRO_MEMORANDUM_INTERNO1.VisibleIndex = 0
        '
        'colFECHA_MEMORANDUM
        '
        Me.colFECHA_MEMORANDUM.Caption = "Fecha Memo"
        Me.colFECHA_MEMORANDUM.FieldName = "FECHA_MEMORANDUM"
        Me.colFECHA_MEMORANDUM.Name = "colFECHA_MEMORANDUM"
        Me.colFECHA_MEMORANDUM.OptionsColumn.AllowEdit = False
        Me.colFECHA_MEMORANDUM.OptionsColumn.ReadOnly = True
        Me.colFECHA_MEMORANDUM.Visible = True
        Me.colFECHA_MEMORANDUM.VisibleIndex = 1
        '
        'colANO
        '
        Me.colANO.Caption = "ANO"
        Me.colANO.FieldName = "ANO"
        Me.colANO.Name = "colANO"
        Me.colANO.OptionsColumn.AllowEdit = False
        Me.colANO.OptionsColumn.ReadOnly = True
        '
        'colMES
        '
        Me.colMES.Caption = "MES"
        Me.colMES.FieldName = "MES"
        Me.colMES.Name = "colMES"
        Me.colMES.OptionsColumn.AllowEdit = False
        Me.colMES.OptionsColumn.ReadOnly = True
        '
        'colDEPTO_ID
        '
        Me.colDEPTO_ID.Caption = "DEPTO_ID"
        Me.colDEPTO_ID.FieldName = "DEPTO_ID"
        Me.colDEPTO_ID.Name = "colDEPTO_ID"
        Me.colDEPTO_ID.OptionsColumn.AllowEdit = False
        Me.colDEPTO_ID.OptionsColumn.ReadOnly = True
        '
        'colDEPARTAMENTO
        '
        Me.colDEPARTAMENTO.Caption = "Departamento"
        Me.colDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.colDEPARTAMENTO.Name = "colDEPARTAMENTO"
        Me.colDEPARTAMENTO.OptionsColumn.AllowEdit = False
        Me.colDEPARTAMENTO.OptionsColumn.ReadOnly = True
        Me.colDEPARTAMENTO.Visible = True
        Me.colDEPARTAMENTO.VisibleIndex = 2
        '
        'colSTR_ESTADO_VIATICO1
        '
        Me.colSTR_ESTADO_VIATICO1.Caption = "Estado Viatico"
        Me.colSTR_ESTADO_VIATICO1.FieldName = "STR_ESTADO_VIATICO"
        Me.colSTR_ESTADO_VIATICO1.Name = "colSTR_ESTADO_VIATICO1"
        Me.colSTR_ESTADO_VIATICO1.OptionsColumn.AllowEdit = False
        Me.colSTR_ESTADO_VIATICO1.OptionsColumn.ReadOnly = True
        Me.colSTR_ESTADO_VIATICO1.Visible = True
        Me.colSTR_ESTADO_VIATICO1.VisibleIndex = 3
        '
        'colESTADO_VIATICO1
        '
        Me.colESTADO_VIATICO1.Caption = "ESTADO_VIATICO"
        Me.colESTADO_VIATICO1.FieldName = "ESTADO_VIATICO"
        Me.colESTADO_VIATICO1.Name = "colESTADO_VIATICO1"
        Me.colESTADO_VIATICO1.OptionsColumn.AllowEdit = False
        Me.colESTADO_VIATICO1.OptionsColumn.ReadOnly = True
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "DESCRIPCION"
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.OptionsColumn.AllowEdit = False
        Me.colDESCRIPCION.OptionsColumn.ReadOnly = True
        '
        'colEGRESO_ID
        '
        Me.colEGRESO_ID.Caption = "Nro.Egreso"
        Me.colEGRESO_ID.FieldName = "EGRESO_ID"
        Me.colEGRESO_ID.Name = "colEGRESO_ID"
        Me.colEGRESO_ID.OptionsColumn.AllowEdit = False
        Me.colEGRESO_ID.OptionsColumn.ReadOnly = True
        Me.colEGRESO_ID.Visible = True
        Me.colEGRESO_ID.VisibleIndex = 4
        '
        'colSELECCIONAR
        '
        Me.colSELECCIONAR.Caption = "Seleccionar"
        Me.colSELECCIONAR.ColumnEdit = Me.chkAceptar
        Me.colSELECCIONAR.FieldName = "SELECCIONAR"
        Me.colSELECCIONAR.Name = "colSELECCIONAR"
        Me.colSELECCIONAR.Visible = True
        Me.colSELECCIONAR.VisibleIndex = 5
        '
        'chkAceptar
        '
        Me.chkAceptar.AutoHeight = False
        Me.chkAceptar.Name = "chkAceptar"
        '
        'colNUMERO_DOCUMENTO2
        '
        Me.colNUMERO_DOCUMENTO2.Caption = "Num.Cheque"
        Me.colNUMERO_DOCUMENTO2.FieldName = "NUMERO_DOCUMENTO"
        Me.colNUMERO_DOCUMENTO2.Name = "colNUMERO_DOCUMENTO2"
        Me.colNUMERO_DOCUMENTO2.OptionsColumn.AllowEdit = False
        Me.colNUMERO_DOCUMENTO2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNUMERO_DOCUMENTO2.OptionsColumn.AllowMove = False
        Me.colNUMERO_DOCUMENTO2.OptionsColumn.ReadOnly = True
        Me.colNUMERO_DOCUMENTO2.Visible = True
        Me.colNUMERO_DOCUMENTO2.VisibleIndex = 6
        '
        'colFECHA_DOCUMENTO
        '
        Me.colFECHA_DOCUMENTO.Caption = "Fecha Cheque"
        Me.colFECHA_DOCUMENTO.FieldName = "FECHA_DOCUMENTO"
        Me.colFECHA_DOCUMENTO.Name = "colFECHA_DOCUMENTO"
        Me.colFECHA_DOCUMENTO.OptionsColumn.AllowEdit = False
        Me.colFECHA_DOCUMENTO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colFECHA_DOCUMENTO.OptionsColumn.AllowMove = False
        Me.colFECHA_DOCUMENTO.OptionsColumn.ReadOnly = True
        Me.colFECHA_DOCUMENTO.Visible = True
        Me.colFECHA_DOCUMENTO.VisibleIndex = 7
        '
        'luePeriodos
        '
        Me.luePeriodos.Location = New System.Drawing.Point(112, 32)
        Me.luePeriodos.Name = "luePeriodos"
        Me.luePeriodos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ANO", "Año", 20, DevExpress.Utils.FormatType.DateTime, "d", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Descending)})
        Me.luePeriodos.Size = New System.Drawing.Size(96, 20)
        Me.luePeriodos.TabIndex = 1
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(24, 32)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(24, 16)
        Me.lblPeriodo.TabIndex = 99
        Me.lblPeriodo.Text = "Año"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'gpcResultado
        '
        Me.gpcResultado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcResultado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcResultado.AppearanceCaption.Options.UseFont = True
        Me.gpcResultado.Controls.Add(Me.LabelControl2)
        Me.gpcResultado.Controls.Add(Me.txtNumCtaCte)
        Me.gpcResultado.Controls.Add(Me.btnEmitirEgreso)
        Me.gpcResultado.Controls.Add(Me.btnAnular)
        Me.gpcResultado.Controls.Add(Me.btnGenerarCheque)
        Me.gpcResultado.Controls.Add(Me.LabelControl1)
        Me.gpcResultado.Controls.Add(Me.txtNumeroCheque)
        Me.gpcResultado.Controls.Add(Me.dedFechaCheque)
        Me.gpcResultado.Controls.Add(Me.lblFechaCheque)
        Me.gpcResultado.Controls.Add(Me.txtApellidos)
        Me.gpcResultado.Controls.Add(Me.lblApellidos)
        Me.gpcResultado.Controls.Add(Me.txtNombres)
        Me.gpcResultado.Controls.Add(Me.txtMonto)
        Me.gpcResultado.Controls.Add(Me.lblNombres)
        Me.gpcResultado.Controls.Add(Me.lblMonto)
        Me.gpcResultado.Location = New System.Drawing.Point(0, 288)
        Me.gpcResultado.Name = "gpcResultado"
        Me.gpcResultado.Size = New System.Drawing.Size(928, 160)
        Me.gpcResultado.TabIndex = 50
        Me.gpcResultado.Text = "Datos del Cheque"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(64, 132)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl2.TabIndex = 26
        Me.LabelControl2.Text = "Num.Cta.Cte."
        '
        'txtNumCtaCte
        '
        Me.txtNumCtaCte.Location = New System.Drawing.Point(152, 128)
        Me.txtNumCtaCte.Name = "txtNumCtaCte"
        Me.txtNumCtaCte.Properties.Mask.EditMask = "n0"
        Me.txtNumCtaCte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumCtaCte.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNumCtaCte.Properties.MaxLength = 7
        Me.txtNumCtaCte.Size = New System.Drawing.Size(100, 20)
        Me.txtNumCtaCte.TabIndex = 25
        '
        'btnEmitirEgreso
        '
        Me.btnEmitirEgreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEmitirEgreso.Location = New System.Drawing.Point(768, 32)
        Me.btnEmitirEgreso.Name = "btnEmitirEgreso"
        Me.btnEmitirEgreso.Size = New System.Drawing.Size(112, 24)
        Me.btnEmitirEgreso.TabIndex = 24
        Me.btnEmitirEgreso.Text = "Emitir Egreso"
        Me.btnEmitirEgreso.ToolTip = "Generar cheques para registros pendientes de pago"
        '
        'btnAnular
        '
        Me.btnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAnular.Location = New System.Drawing.Point(632, 32)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(112, 23)
        Me.btnAnular.TabIndex = 23
        Me.btnAnular.Text = "Anular"
        '
        'btnGenerarCheque
        '
        Me.btnGenerarCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGenerarCheque.Location = New System.Drawing.Point(496, 32)
        Me.btnGenerarCheque.Name = "btnGenerarCheque"
        Me.btnGenerarCheque.Size = New System.Drawing.Size(112, 24)
        Me.btnGenerarCheque.TabIndex = 10
        Me.btnGenerarCheque.Text = "Generar Cheque"
        Me.btnGenerarCheque.ToolTip = "Generar cheques para registros pendientes de pago"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(64, 110)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Num.Cheque"
        '
        'txtNumeroCheque
        '
        Me.txtNumeroCheque.Location = New System.Drawing.Point(152, 104)
        Me.txtNumeroCheque.Name = "txtNumeroCheque"
        Me.txtNumeroCheque.Properties.Mask.EditMask = "n0"
        Me.txtNumeroCheque.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumeroCheque.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNumeroCheque.Properties.MaxLength = 7
        Me.txtNumeroCheque.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroCheque.TabIndex = 6
        '
        'dedFechaCheque
        '
        Me.dedFechaCheque.EditValue = Nothing
        Me.dedFechaCheque.Location = New System.Drawing.Point(333, 104)
        Me.dedFechaCheque.Name = "dedFechaCheque"
        Me.dedFechaCheque.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaCheque.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaCheque.Size = New System.Drawing.Size(100, 20)
        Me.dedFechaCheque.TabIndex = 7
        '
        'lblFechaCheque
        '
        Me.lblFechaCheque.Location = New System.Drawing.Point(261, 110)
        Me.lblFechaCheque.Name = "lblFechaCheque"
        Me.lblFechaCheque.Size = New System.Drawing.Size(69, 13)
        Me.lblFechaCheque.TabIndex = 6
        Me.lblFechaCheque.Text = "Fecha Cheque"
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(152, 80)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(280, 20)
        Me.txtApellidos.TabIndex = 5
        '
        'lblApellidos
        '
        Me.lblApellidos.Location = New System.Drawing.Point(64, 86)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(42, 13)
        Me.lblApellidos.TabIndex = 4
        Me.lblApellidos.Text = "Apellidos"
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(152, 56)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(280, 20)
        Me.txtNombres.TabIndex = 4
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(152, 32)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Properties.DisplayFormat.FormatString = "n0"
        Me.txtMonto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.Properties.EditFormat.FormatString = "n0"
        Me.txtMonto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.Properties.Mask.EditMask = "n0"
        Me.txtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMonto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMonto.Properties.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(100, 20)
        Me.txtMonto.TabIndex = 3
        '
        'lblNombres
        '
        Me.lblNombres.Location = New System.Drawing.Point(64, 62)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(42, 13)
        Me.lblNombres.TabIndex = 1
        Me.lblNombres.Text = "Nombres"
        '
        'lblMonto
        '
        Me.lblMonto.Location = New System.Drawing.Point(64, 38)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(30, 13)
        Me.lblMonto.TabIndex = 0
        Me.lblMonto.Text = "Monto"
        '
        'gdcViaticosAsociados
        '
        Me.gdcViaticosAsociados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcViaticosAsociados.Location = New System.Drawing.Point(0, 208)
        Me.gdcViaticosAsociados.MainView = Me.gdvViaticosAsociados
        Me.gdcViaticosAsociados.Name = "gdcViaticosAsociados"
        Me.gdcViaticosAsociados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtMontoCheque})
        Me.gdcViaticosAsociados.Size = New System.Drawing.Size(928, 80)
        Me.gdcViaticosAsociados.TabIndex = 0
        Me.gdcViaticosAsociados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvViaticosAsociados})
        '
        'gdvViaticosAsociados
        '
        Me.gdvViaticosAsociados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVIATICO_ID, Me.colVIATICO_DETALLE_ID, Me.colNRO_MEMORANDUM_INTERNO, Me.colAPELLIDO_PATERNO, Me.colAPELLIDO_MATERNO, Me.colNOMBRES, Me.colFECHA_INICIO, Me.colFECHA_TERMINO, Me.colCANTIDAD_DIAS, Me.colPAIS_DESTINO, Me.colREGION_DESTINO, Me.colMONTO, Me.colSTR_ESTADO_VIATICO, Me.colNUMERO_DOCUMENTO, Me.colESTADO_VIATICO, Me.colDEPARTAMENTO1})
        Me.gdvViaticosAsociados.GridControl = Me.gdcViaticosAsociados
        Me.gdvViaticosAsociados.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas"
        Me.gdvViaticosAsociados.Name = "gdvViaticosAsociados"
        Me.gdvViaticosAsociados.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gdvViaticosAsociados.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gdvViaticosAsociados.OptionsSelection.EnableAppearanceHideSelection = False
        Me.gdvViaticosAsociados.OptionsSelection.InvertSelection = True
        Me.gdvViaticosAsociados.OptionsSelection.MultiSelect = True
        Me.gdvViaticosAsociados.OptionsSelection.UseIndicatorForSelection = False
        Me.gdvViaticosAsociados.OptionsView.ShowGroupPanel = False
        '
        'colVIATICO_ID
        '
        Me.colVIATICO_ID.Caption = "VIATICO ID"
        Me.colVIATICO_ID.FieldName = "VIATICO_ID"
        Me.colVIATICO_ID.Name = "colVIATICO_ID"
        Me.colVIATICO_ID.OptionsColumn.AllowEdit = False
        Me.colVIATICO_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.colVIATICO_ID.Width = 73
        '
        'colVIATICO_DETALLE_ID
        '
        Me.colVIATICO_DETALLE_ID.Caption = "VIATICO_DETALLE_ID"
        Me.colVIATICO_DETALLE_ID.FieldName = "VIATICO_DETALLE_ID"
        Me.colVIATICO_DETALLE_ID.Name = "colVIATICO_DETALLE_ID"
        Me.colVIATICO_DETALLE_ID.OptionsColumn.AllowEdit = False
        Me.colVIATICO_DETALLE_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.colVIATICO_DETALLE_ID.Width = 95
        '
        'colNRO_MEMORANDUM_INTERNO
        '
        Me.colNRO_MEMORANDUM_INTERNO.Caption = "Nro.Memo"
        Me.colNRO_MEMORANDUM_INTERNO.FieldName = "NRO_MEMORANDUM_INTERNO"
        Me.colNRO_MEMORANDUM_INTERNO.Name = "colNRO_MEMORANDUM_INTERNO"
        Me.colNRO_MEMORANDUM_INTERNO.OptionsColumn.AllowEdit = False
        Me.colNRO_MEMORANDUM_INTERNO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.colNRO_MEMORANDUM_INTERNO.Visible = True
        Me.colNRO_MEMORANDUM_INTERNO.VisibleIndex = 0
        Me.colNRO_MEMORANDUM_INTERNO.Width = 63
        '
        'colAPELLIDO_PATERNO
        '
        Me.colAPELLIDO_PATERNO.Caption = "Apellido Paterno"
        Me.colAPELLIDO_PATERNO.FieldName = "APELLIDO_PATERNO"
        Me.colAPELLIDO_PATERNO.Name = "colAPELLIDO_PATERNO"
        Me.colAPELLIDO_PATERNO.OptionsColumn.AllowEdit = False
        Me.colAPELLIDO_PATERNO.OptionsColumn.ReadOnly = True
        Me.colAPELLIDO_PATERNO.Visible = True
        Me.colAPELLIDO_PATERNO.VisibleIndex = 1
        Me.colAPELLIDO_PATERNO.Width = 147
        '
        'colAPELLIDO_MATERNO
        '
        Me.colAPELLIDO_MATERNO.Caption = "Apellido Materno"
        Me.colAPELLIDO_MATERNO.FieldName = "APELLIDO_MATERNO"
        Me.colAPELLIDO_MATERNO.Name = "colAPELLIDO_MATERNO"
        Me.colAPELLIDO_MATERNO.OptionsColumn.AllowEdit = False
        Me.colAPELLIDO_MATERNO.OptionsColumn.ReadOnly = True
        Me.colAPELLIDO_MATERNO.Visible = True
        Me.colAPELLIDO_MATERNO.VisibleIndex = 2
        Me.colAPELLIDO_MATERNO.Width = 131
        '
        'colNOMBRES
        '
        Me.colNOMBRES.Caption = "Nombres"
        Me.colNOMBRES.FieldName = "NOMBRES"
        Me.colNOMBRES.Name = "colNOMBRES"
        Me.colNOMBRES.OptionsColumn.AllowEdit = False
        Me.colNOMBRES.OptionsColumn.ReadOnly = True
        Me.colNOMBRES.Visible = True
        Me.colNOMBRES.VisibleIndex = 3
        Me.colNOMBRES.Width = 90
        '
        'colFECHA_INICIO
        '
        Me.colFECHA_INICIO.Caption = "Desde"
        Me.colFECHA_INICIO.FieldName = "FECHA_INICIO"
        Me.colFECHA_INICIO.Name = "colFECHA_INICIO"
        Me.colFECHA_INICIO.OptionsColumn.AllowEdit = False
        Me.colFECHA_INICIO.OptionsColumn.ReadOnly = True
        Me.colFECHA_INICIO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
        Me.colFECHA_INICIO.Visible = True
        Me.colFECHA_INICIO.VisibleIndex = 5
        Me.colFECHA_INICIO.Width = 56
        '
        'colFECHA_TERMINO
        '
        Me.colFECHA_TERMINO.Caption = "Hasta"
        Me.colFECHA_TERMINO.FieldName = "FECHA_TERMINO"
        Me.colFECHA_TERMINO.Name = "colFECHA_TERMINO"
        Me.colFECHA_TERMINO.OptionsColumn.AllowEdit = False
        Me.colFECHA_TERMINO.OptionsColumn.ReadOnly = True
        Me.colFECHA_TERMINO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
        Me.colFECHA_TERMINO.Visible = True
        Me.colFECHA_TERMINO.VisibleIndex = 6
        Me.colFECHA_TERMINO.Width = 56
        '
        'colCANTIDAD_DIAS
        '
        Me.colCANTIDAD_DIAS.Caption = "Nº Días"
        Me.colCANTIDAD_DIAS.FieldName = "CANTIDAD_DIAS"
        Me.colCANTIDAD_DIAS.Name = "colCANTIDAD_DIAS"
        Me.colCANTIDAD_DIAS.OptionsColumn.AllowEdit = False
        Me.colCANTIDAD_DIAS.OptionsColumn.ReadOnly = True
        Me.colCANTIDAD_DIAS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
        Me.colCANTIDAD_DIAS.Visible = True
        Me.colCANTIDAD_DIAS.VisibleIndex = 4
        Me.colCANTIDAD_DIAS.Width = 72
        '
        'colPAIS_DESTINO
        '
        Me.colPAIS_DESTINO.Caption = "País"
        Me.colPAIS_DESTINO.FieldName = "PAIS_DESTINO"
        Me.colPAIS_DESTINO.Name = "colPAIS_DESTINO"
        Me.colPAIS_DESTINO.OptionsColumn.AllowEdit = False
        Me.colPAIS_DESTINO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.colPAIS_DESTINO.Visible = True
        Me.colPAIS_DESTINO.VisibleIndex = 7
        Me.colPAIS_DESTINO.Width = 76
        '
        'colREGION_DESTINO
        '
        Me.colREGION_DESTINO.Caption = "Región"
        Me.colREGION_DESTINO.FieldName = "REGION_DESTINO"
        Me.colREGION_DESTINO.Name = "colREGION_DESTINO"
        Me.colREGION_DESTINO.OptionsColumn.AllowEdit = False
        Me.colREGION_DESTINO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.colREGION_DESTINO.Visible = True
        Me.colREGION_DESTINO.VisibleIndex = 8
        Me.colREGION_DESTINO.Width = 125
        '
        'colMONTO
        '
        Me.colMONTO.Caption = "Monto"
        Me.colMONTO.ColumnEdit = Me.txtMontoCheque
        Me.colMONTO.FieldName = "MONTO"
        Me.colMONTO.Name = "colMONTO"
        Me.colMONTO.OptionsColumn.AllowEdit = False
        Me.colMONTO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.colMONTO.Visible = True
        Me.colMONTO.VisibleIndex = 9
        Me.colMONTO.Width = 66
        '
        'txtMontoCheque
        '
        Me.txtMontoCheque.AutoHeight = False
        Me.txtMontoCheque.Mask.EditMask = "n0"
        Me.txtMontoCheque.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoCheque.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoCheque.Name = "txtMontoCheque"
        '
        'colSTR_ESTADO_VIATICO
        '
        Me.colSTR_ESTADO_VIATICO.Caption = "Estado"
        Me.colSTR_ESTADO_VIATICO.FieldName = "STR_ESTADO_VIATICO"
        Me.colSTR_ESTADO_VIATICO.Name = "colSTR_ESTADO_VIATICO"
        Me.colSTR_ESTADO_VIATICO.OptionsColumn.AllowEdit = False
        Me.colSTR_ESTADO_VIATICO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.colSTR_ESTADO_VIATICO.Visible = True
        Me.colSTR_ESTADO_VIATICO.VisibleIndex = 10
        Me.colSTR_ESTADO_VIATICO.Width = 182
        '
        'colNUMERO_DOCUMENTO
        '
        Me.colNUMERO_DOCUMENTO.Caption = "Número Cheque"
        Me.colNUMERO_DOCUMENTO.FieldName = "NUMERO_DOCUMENTO"
        Me.colNUMERO_DOCUMENTO.Name = "colNUMERO_DOCUMENTO"
        Me.colNUMERO_DOCUMENTO.OptionsColumn.AllowEdit = False
        Me.colNUMERO_DOCUMENTO.Width = 87
        '
        'colESTADO_VIATICO
        '
        Me.colESTADO_VIATICO.Caption = "Tipo Estado Viatico"
        Me.colESTADO_VIATICO.FieldName = "ESTADO_VIATICO"
        Me.colESTADO_VIATICO.Name = "colESTADO_VIATICO"
        Me.colESTADO_VIATICO.OptionsColumn.AllowEdit = False
        '
        'colDEPARTAMENTO1
        '
        Me.colDEPARTAMENTO1.Caption = "Departamento"
        Me.colDEPARTAMENTO1.FieldName = "DEPARTAMENTO"
        Me.colDEPARTAMENTO1.Name = "colDEPARTAMENTO1"
        Me.colDEPARTAMENTO1.OptionsColumn.ReadOnly = True
        Me.colDEPARTAMENTO1.OptionsColumn.ShowInCustomizationForm = False
        '
        'prnListadoViaticos
        '
        Me.prnListadoViaticos.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcViaticosAsociados
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(40, 20, 20, 20)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Titulo1", "Titulo2", "Titulo3"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Pie1", "Pie2", "Pie3"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.prnListadoViaticos
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prnListadoViaticos
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "VW_VIATICO_NUMERO_MEMORANDUM", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("VIATICO_ID", "VIATICO_ID"), New System.Data.Common.DataColumnMapping("NRO_MEMORANDUM_INTERNO", "NRO_MEMORANDUM_INTERNO"), New System.Data.Common.DataColumnMapping("FECHA_MEMORANDUM", "FECHA_MEMORANDUM"), New System.Data.Common.DataColumnMapping("ANO", "ANO"), New System.Data.Common.DataColumnMapping("MES", "MES"), New System.Data.Common.DataColumnMapping("DEPTO_ID", "DEPTO_ID"), New System.Data.Common.DataColumnMapping("DEPARTAMENTO", "DEPARTAMENTO"), New System.Data.Common.DataColumnMapping("STR_ESTADO_VIATICO", "STR_ESTADO_VIATICO"), New System.Data.Common.DataColumnMapping("ESTADO_VIATICO", "ESTADO_VIATICO"), New System.Data.Common.DataColumnMapping("DESCRIPCION", "DESCRIPCION"), New System.Data.Common.DataColumnMapping("SELECCIONAR", "SELECCIONAR"), New System.Data.Common.DataColumnMapping("EGRESO_ID", "EGRESO_ID")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@VIATICO_ID", System.Data.SqlDbType.Int, 4, "VIATICO_ID"), New System.Data.SqlClient.SqlParameter("@NRO_MEMORANDUM_INTERNO", System.Data.SqlDbType.VarChar, 20, "NRO_MEMORANDUM_INTERNO"), New System.Data.SqlClient.SqlParameter("@FECHA_MEMORANDUM", System.Data.SqlDbType.DateTime, 8, "FECHA_MEMORANDUM"), New System.Data.SqlClient.SqlParameter("@ANO", System.Data.SqlDbType.SmallInt, 2, "ANO"), New System.Data.SqlClient.SqlParameter("@MES", System.Data.SqlDbType.TinyInt, 1, "MES"), New System.Data.SqlClient.SqlParameter("@DEPTO_ID", System.Data.SqlDbType.Int, 4, "DEPTO_ID"), New System.Data.SqlClient.SqlParameter("@DEPARTAMENTO", System.Data.SqlDbType.VarChar, 100, "DEPARTAMENTO"), New System.Data.SqlClient.SqlParameter("@STR_ESTADO_VIATICO", System.Data.SqlDbType.VarChar, 36, "STR_ESTADO_VIATICO"), New System.Data.SqlClient.SqlParameter("@ESTADO_VIATICO", System.Data.SqlDbType.TinyInt, 1, "ESTADO_VIATICO"), New System.Data.SqlClient.SqlParameter("@DESCRIPCION", System.Data.SqlDbType.VarChar, 129, "DESCRIPCION"), New System.Data.SqlClient.SqlParameter("@SELECCIONAR", System.Data.SqlDbType.Bit, 1, "SELECCIONAR"), New System.Data.SqlClient.SqlParameter("@EGRESO_ID", System.Data.SqlDbType.Int, 4, "EGRESO_ID")})
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "data source=;initial catalog="
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ANO", System.Data.SqlDbType.SmallInt, 2, "ANO"), New System.Data.SqlClient.SqlParameter("@ESTADO_VIATICO", System.Data.SqlDbType.TinyInt, 1, "ESTADO_VIATICO")})
        '
        'frmRendicionViaticoPorMemo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(928, 453)
        Me.Controls.Add(Me.gpcResultado)
        Me.Controls.Add(Me.gpcCriteriosBusqueda)
        Me.Controls.Add(Me.gdcViaticosAsociados)
        Me.Name = "frmRendicionViaticoPorMemo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Genera Cheque Viáticos por Nro.Memorandum "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcCriteriosBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcCriteriosBusqueda.ResumeLayout(False)
        CType(Me.rdgTipoEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcMemorandums, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsViatico1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvMemoramdumsDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcResultado.ResumeLayout(False)
        Me.gpcResultado.PerformLayout()
        CType(Me.txtNumCtaCte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroCheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaCheque.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaCheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcViaticosAsociados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvViaticosAsociados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prnListadoViaticos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmHistoriaViaticosPorMemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        repositorio.Show()
        InitPeriodos()
        dedFechaCheque.EditValue = Date.Now
        Me.btnBuscar.Enabled = False
        Me.btnAnular.Enabled = False
        Me.btnGenerarCheque.Enabled = False
        Me.btnEmitirEgreso.Enabled = False
    End Sub

    Private Sub luePeriodos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luePeriodos.EditValueChanged, rdgTipoEstado.EditValueChanged
        llenarMemos()
        If Me.rdgTipoEstado.EditValue = 0 Then
            Me.colEGRESO_ID.Visible = False
        Else
            Me.colEGRESO_ID.Visible = True
        End If
    End Sub

    Private Sub btnGenerarCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarCheque.Click
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = gdvViaticosAsociados
        If view.GetRowCellValue(0, "ESTADO_VIATICO") = 1 Or gdvViaticosAsociados.RowCount = 0 Then
            Return
        End If
        If Not validarDatosCheque() Then
            Return
        End If

        If MsgBox("¿La impresora tiene el formulario de cheque?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Return
        End If

        Dim Periodo As New Periodo
        Dim EmmpleadoId As Integer = 0
        Dim Apellidos As String = RTrim(Me.txtApellidos.Text)
        Dim Nombres As String = RTrim(Me.txtNombres.Text)
        Dim Rut As Integer = 0
        Dim Dv As String = ""
        Dim PeriodoId As Integer = Periodo.ID
        Dim Monto As Integer = Me.txtMonto.EditValue
        Dim TipoProceso As String = "RV"
        Dim NombreCalidadJuridica As String = ""
        Dim FormaPagoId As Integer = 0
        Dim NombreFormaPago As String = ""
        Dim NombreDepartamento As String = ""
        Dim GenerarCheque As Boolean = False
        Dim ChequeEmitido As Boolean = False
        Dim NumeroCheque As Integer = Me.txtNumeroCheque.EditValue
        Dim NumeroEgreso As Integer = 0
        Dim FechaCheque As Date = Me.dedFechaCheque.EditValue
        Dim CalidadJuridicaId As Integer = 0
        Dim ImpresionId As Integer = 0
        Dim EgresoId As Integer = 0
        Dim NumeroCuentaCorriente As Integer = Me.txtNumCtaCte.EditValue
        Dim NombreCompleto As String = Nombres + " " + Apellidos

        InsertarCheque(NumeroCheque, FechaCheque, EmmpleadoId, Monto)
        EgresoId = empleado.insertarEgresoCabecera(NumeroCheque, FechaCheque, CInt(Monto), NombreCompleto, 1, "RENDICIÓN VIÁTICO", Argo.Comun.ArgoConfiguracion.OrganizacionID)

        empleado.InsertaDatosTesoreria(EmmpleadoId, Apellidos, Nombres, Rut, Dv, PeriodoId, Monto, TipoProceso, NombreCalidadJuridica, FormaPagoId, NombreFormaPago, _
                NombreDepartamento, GenerarCheque, ChequeEmitido, NumeroCheque, NumeroEgreso, FechaCheque, CalidadJuridicaId, ImpresionId, EgresoId, NumeroCuentaCorriente)

        Dim NombreFuncionario As String
        Dim ViaticoDetalleId As Integer
        For i As Integer = 0 To gdvViaticosAsociados.RowCount - 1
            NombreFuncionario = RTrim(view.GetRowCellValue(i, "APELLIDO_PATERNO")) + " " + RTrim(view.GetRowCellValue(i, "APELLIDO_MATERNO")) + " " + RTrim(view.GetRowCellValue(i, "NOMBRES"))
            ViaticoDetalleId = CInt(view.GetRowCellValue(i, "VIATICO_DETALLE_ID"))
            Monto = CInt(view.GetRowCellValue(i, "MONTO"))
            NombreDepartamento = view.GetRowCellValue(i, "DEPARTAMENTO")

            ActualizarDetalleViatico(ViaticoDetalleId, NumeroCheque, 1, FechaCheque)
            InsertarEgresoDetalle(EgresoId, ViaticoDetalleId, Monto, NombreFuncionario, NombreDepartamento)
        Next

        'buscarDetalle(tipoEstadoViatico.PAGADO)
        llenarMemos()
        Me.btnGenerarCheque.Enabled = False
        Me.txtNumeroCheque.EditValue += 1
        ImprimirCheque(EgresoId)
    End Sub

    Private Sub ImprimirCheque(ByVal EgresoId As Integer)
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptChequeCarta
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        Dim strFormulaSeleccion As String = "{RH_REM_TESORERIA_LIQ_PAGO.EGRESO_ID}=" & EgresoId.ToString
        ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
        ventanaReporte1.rptVisor.ShowParameterPanelButton = False
        ventanaReporte1.rptVisor.ShowCloseButton = False
        ventanaReporte1.rptVisor.ShowGroupTreeButton = False
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.Show()
    End Sub

    Private Sub btnGenerarCheque_Click_Old(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = gdvViaticosAsociados
        If view.GetRowCellValue(0, "ESTADO_VIATICO") = 1 Or gdvViaticosAsociados.RowCount = 0 Then
            Return
        End If
        If Not validarDatosCheque() Then
            Return
        End If

        If MsgBox("¿La impresora tiene el formulario de cheque y que corresponde al nro." + txtNumeroCheque.Text.ToString + "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Return
        End If

        Dim Meses() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}

        Dim totalEgreso As String = ""
        Dim valorEnLetrasParte1 As String = ""
        Dim valorEnLetrasParte2 As String = ""
        Dim Dia As String = ""
        Dim Mes As String = ""
        Dim Ano As String = ""
        Dim app_PathFile As String = Path.GetFullPath("imprimec.txt")
        Dim app_PathFileBat As String = Path.GetFullPath("imprimec.bat")

        Dim FECHA_CHEQUE As String = dedFechaCheque.EditValue
        'Dim NUMERO_DOCUMENTO As Integer = Me.txtNumResolucion.Text
        Dim NUM_CHEQUE As Integer = Me.txtNumeroCheque.Text
        Dim NUM_CHEQUE_INICIAL As Integer = NUM_CHEQUE
        Dim NUM_CHEQUE_FINAL As Integer = NUM_CHEQUE_INICIAL
        Dim ID_EMPLEADO As Integer = 0
        Dim largoNombreCompleto, LargoApellidos, LargoNombres As Integer
        Dim apellidos As String = txtApellidos.Text
        Dim Nombres As String = txtNombres.Text
        Dim NombreCompleto As String = Nombres + " " + apellidos
        Dim Monto As Integer = txtMonto.Text
        Dim ChequesEmitidos As String = ""
        Dim FechaCheque, nombreComprobante, MontoEscrito, nombreCheque As String
        Try

            FileOpen(1, app_PathFile, OpenMode.Output)
            nombreCheque = Trim(NombreCompleto)
            NombreCompleto = Replace(Trim(NombreCompleto), "Ñ", "N")
            apellidos = Replace(Trim(apellidos), "Ñ", "N")
            Nombres = Replace(Trim(Nombres), "Ñ", "N")
            largoNombreCompleto = Len(NombreCompleto)
            LargoApellidos = Len(apellidos)
            LargoNombres = Len(Nombres)
            totalEgreso = Trim(Monto)
            MontoEscrito = ConvertirEnMontoEscrito(Monto)
            If Len(MontoEscrito) > 70 Then
                valorEnLetrasParte2 = DividirMontoEscrito(MontoEscrito)
                valorEnLetrasParte1 = MontoEscrito.Substring(0, Len(MontoEscrito) - Len(valorEnLetrasParte2))
            End If

            Dia = Trim(CDate(dedFechaCheque.EditValue).Day.ToString)
            Mes = Meses(CDate(dedFechaCheque.EditValue).Month - 1)
            Ano = Trim(CDate(dedFechaCheque.EditValue).Year.ToString)
            FechaCheque = Dia & " " & Mes & " " & Ano

            Dim nombreLinea1 As String = ""
            Dim nombreLinea2 As String = ""

            If Len(NombreCompleto) <= 20 Then
                nombreLinea1 = NombreCompleto
                nombreLinea2 = ""
                nombreComprobante = NombreCompleto
            Else
                nombreLinea1 = NombreCompleto.Substring(0, 20)
                nombreLinea2 = NombreCompleto.Substring(20, Math.Abs(Len(NombreCompleto) - Len(NombreCompleto.Substring(0, 20))))
                nombreComprobante = NombreCompleto.Substring(0, 20)
            End If

            'Crea archivo con información.
            PrintLine(1, " ")   ' Linea en blanco.
            PrintLine(1, TAB(102), (LTrim(Format(CInt(totalEgreso), "###,###,###")) + ".-")) 'Imprime monto del cheque.
            PrintLine(1)   ' Linea en blanco.
            PrintLine(1)   ' Linea en blanco.
            PrintLine(1)   ' Linea en blanco.
            PrintLine(1, TAB(10), FechaCheque, TAB(90), FechaCheque)  ' Imprime fecha.

            PrintLine(1)   ' Linea en blanco.
            PrintLine(1, TAB(50), NombreCompleto) ' Nombre completo de la persona en el cheque.
            PrintLine(1, TAB(1), nombreComprobante) ' Nombre de la persona para comprobante.
            If Len(MontoEscrito) > 70 Then
                PrintLine(1, TAB(50), valorEnLetrasParte1)   ' Si el texto de la cifra sobrepasa los 70 char.
                PrintLine(1, TAB(10), (LTrim(Format(CInt(totalEgreso), "###,###,###")) + ".-"), TAB(43), valorEnLetrasParte2)
            Else
                PrintLine(1, TAB(50), MontoEscrito)
                PrintLine(1, TAB(10), (LTrim(Format(CInt(totalEgreso), "###,###,###")) + ".-"))
            End If
            PrintLine(1)   ' Linea en blanco.
            PrintLine(1)   ' Linea en blanco.
            PrintLine(1)   ' Linea en blanco.
            PrintLine(1)   ' Linea en blanco.
            PrintLine(1)   ' Linea en blanco.
            PrintLine(1)   ' Linea en blanco.

            Dim egresoId, viaticoDetalleId, montoCheque As Integer
            Dim NombreFuncionario, departamento As String
            InsertarCheque(NUM_CHEQUE, FECHA_CHEQUE, ID_EMPLEADO, totalEgreso)
            egresoId = empleado.insertarEgresoCabecera(NUM_CHEQUE, FECHA_CHEQUE, CInt(totalEgreso), nombreCheque, 1, "RENDICIÓN VIÁTICO", Argo.Comun.ArgoConfiguracion.OrganizacionID)

            For i As Integer = 0 To gdvViaticosAsociados.RowCount - 1
                NombreFuncionario = RTrim(view.GetRowCellValue(i, "APELLIDO_PATERNO")) + " " + RTrim(view.GetRowCellValue(i, "APELLIDO_MATERNO")) + " " + RTrim(view.GetRowCellValue(i, "NOMBRES"))
                viaticoDetalleId = CInt(view.GetRowCellValue(i, "VIATICO_DETALLE_ID"))
                montoCheque = CInt(view.GetRowCellValue(i, "MONTO"))
                departamento = view.GetRowCellValue(i, "DEPARTAMENTO")

                ActualizarDetalleViatico(viaticoDetalleId, NUM_CHEQUE, 1, FECHA_CHEQUE)
                'ActualizarEncabezadoViatico(CInt(view.GetRowCellValue(i, "VIATICO_ID")), Me.txtNombres.Text, Me.txtApellidos.Text, NUM_CHEQUE, Me.txtMonto.EditValue, CDate(Me.dedFechaCheque.EditValue))
                InsertarEgresoDetalle(egresoId, viaticoDetalleId, montoCheque, NombreFuncionario, departamento)
            Next
            buscarDetalle(tipoEstadoViatico.PAGADO)
            Me.btnGenerarCheque.Enabled = False

            NUM_CHEQUE_FINAL = NUM_CHEQUE
            NUM_CHEQUE = NUM_CHEQUE + 1
            Me.txtNumeroCheque.EditValue = NUM_CHEQUE
            FileClose(1) ' Close file.
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try

        Dim frmChequesViatico As New frmChequesViatico
        If ChequesEmitidos <> "" Then
            MessageBox.Show("Los cheques, " & ChequesEmitidos & "se encuentran con estado Emitido o Anulado")
        End If
        If NUM_CHEQUE_FINAL < NUM_CHEQUE_INICIAL Then NUM_CHEQUE_FINAL = NUM_CHEQUE_FINAL
        frmChequesViatico.DefInstance.cheque_inicial_h = NUM_CHEQUE_INICIAL
        frmChequesViatico.DefInstance.cheque_final_h = NUM_CHEQUE_FINAL
        frmChequesViatico.DefInstance.Owner = Me
        If frmChequesViatico.DefInstance.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        End If

    End Sub

    Private Sub llenarMemos()
        If luePeriodos.EditValue > 0 Then
            Try
                ''Me.DsViatico1.Clear()
                'Me.gdcMemorandums.DataSource = Nothing
                'Me.SqlConnection1.ConnectionString = Argo.Comun.ArgoConfiguracion.ConnectionString
                'Me.SqlConnection1.Open()
                'Me.SqlDataAdapter1.SelectCommand.Parameters("@ANO").Value = luePeriodos.EditValue
                'Me.SqlDataAdapter1.SelectCommand.Parameters("@ESTADO_VIATICO").Value = rdgTipoEstado.EditValue
                'Me.SqlDataAdapter1.Fill(Me.DsViatico1, "VW_VIATICO_NUMERO_MEMORANDUM")
                'Me.SqlConnection1.Close()

                Me.gdcMemorandums.DataSource = empleado.recuperaRendicionViaticos(luePeriodos.EditValue, rdgTipoEstado.EditValue)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            End Try

        End If
        If Me.gdvMemoramdumsDetalle.RowCount > 0 Then
            Me.btnBuscar.Enabled = True
            Me.btnAnular.Enabled = True
            If Me.rdgTipoEstado.EditValue = 1 Then
                Me.btnGenerarCheque.Enabled = False
            Else
                Me.btnGenerarCheque.Enabled = True
            End If
        Else
            Me.btnBuscar.Enabled = False
            Me.btnAnular.Enabled = False
            Me.btnGenerarCheque.Enabled = False
        End If
    End Sub
    Private Function validarDatosCheque() As Boolean
        Dim validacionOK As Boolean = True
        If txtMonto.EditValue <= 0 Then
            txtMonto.ErrorText = "Monto del cheque debe ser mayor de cero"
            validacionOK = False
        End If
        If Len(RTrim(txtNombres.Text)) = 0 Then
            txtNombres.ErrorText = "Falta ingresar nombre"
            validacionOK = False
        End If
        If Len(RTrim(txtNumCtaCte.Text)) = 0 Then
            txtNumCtaCte.ErrorText = "Falta ingresar numero cuenta corriente"
            validacionOK = False
        End If
        If txtMonto.EditValue <= 0 Then
            txtMonto.ErrorText = "Monto del cheque debe ser mayor de cero"
            validacionOK = False
        End If
        If txtNumeroCheque.EditValue <= 0 Then
            txtNumeroCheque.ErrorText = "Numero del cheque debe ser mayor de cero"
            validacionOK = False
        Else
            If Len(validaNumeroCheque(Me.txtNumeroCheque.EditValue)) > 0 Then
                txtNumeroCheque.ErrorText = "Numero del cheque se encuentra pagado"
                validacionOK = False
            End If
        End If
        Return validacionOK
    End Function

    Private Function validaNumeroCheque(ByVal cheque As Integer) As String
        Dim conn As New SqlConnection(connectionString)
        Dim SQLStr As String = "SELECT * FROM RH_PER_CHEQUE WHERE NUMERO = " & cheque & " AND ESTADO = 0 "
        Dim da As New SqlDataAdapter(SQLStr, conn)
        Dim ds As New DataSet
        Dim res As String = ""
        da.Fill(ds, "RH_PER_CHEQUE")
        If ds.Tables(0).Rows.Count > 0 Then
            If (ds.Tables(0).Rows(0).Item("ESTADO")) = 0 Then
                res = "Pagado"
            ElseIf (ds.Tables(0).Rows(0).Item("ESTADO")) = 1 Then
                res = "Anulado"
            Else
                res = ""
            End If
        End If
        Return (res)
    End Function

    Private Function ConvertirEnMontoEscrito(ByVal monto As Integer) As String
        Dim montoEscrito As String
        montoEscrito = empleado.buscaString("SELECT dbo.NumeroEnLetra(" & monto.ToString & ") AS MONTO_ESCRITO")
        Return montoEscrito
    End Function

    Private Function DividirMontoEscrito(ByVal montoEscrito As String) As String
        Dim final As Integer = 69
        'Dim final As Integer = Len(montoEscrito) - 1
        Dim montoEscritoParte2 As String = ""
        For i As Integer = final To 1 Step -1
            If montoEscrito.Substring(i, 1) = " " Then
                montoEscritoParte2 = RTrim(montoEscrito.Substring(i, Len(montoEscrito) - i))
                Exit For
            End If
        Next
        Return montoEscritoParte2
    End Function

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = gdvViaticosAsociados
        Dim view1 As DevExpress.XtraGrid.Views.Base.ColumnView = gdvMemoramdumsDetalle
        If view.GetRowCellValue(0, "ESTADO_VIATICO") = 0 Or gdvViaticosAsociados.RowCount = 0 Then
            Return
        End If
        Try
            Dim soloUnaVez As Integer = 1
            Dim PrimerEgresoId As Integer
            Dim EgresosDistintos As Boolean = True
            For i As Integer = 0 To Me.gdvMemoramdumsDetalle.RowCount - 1
                If view1.GetRowCellValue(i, "SELECCIONAR") = True Then
                    If soloUnaVez = 1 Then
                        PrimerEgresoId = view1.GetRowCellValue(i, "EGRESO_ID")
                        soloUnaVez = 0
                    ElseIf PrimerEgresoId <> view1.GetRowCellValue(i, "EGRESO_ID") Then
                        EgresosDistintos = False
                        Exit For
                    End If
                End If
            Next
            If EgresosDistintos = False Then
                MessageBox.Show("No puede anular egreso, los registros selecionados deben corresponder al mismo numero de egreso.", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            If MessageBox.Show("¿Seguro desea anular el egreso numero " + PrimerEgresoId.ToString + " con todo el detalle asociado?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim numChequeIni As Integer = view.GetRowCellValue(0, "NUMERO_DOCUMENTO")
                Dim numChequeFin As Integer = view.GetRowCellValue((gdvViaticosAsociados.RowCount - 1), "NUMERO_DOCUMENTO")
                Dim strSQL As String = "exec sp_anular_viatico " & CStr(numChequeIni) & ", " & CStr(numChequeFin) & ", " & CStr(PrimerEgresoId)
                EjecutarQuery(strSQL)
                AnularCheque(numChequeIni)
                llenarMemos()
                Me.gdcViaticosAsociados.DataSource = Nothing
            End If
        Catch exp As Exception
            MessageBox.Show(exp.Message, "Rendición Viatico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub AnularCheque(ByVal numeroChequeIni As String)
        Dim SQLstr As String = "DELETE FROM RH_REM_TESORERIA_LIQ_PAGO WHERE NUMERO_CHEQUE = " & numeroChequeIni '& " AND NUMERO_CHEQUE <= " & numeroChequeFin
        'Dim SQLstr As String = "UPDATE RH_REM_TESORERIA_LIQ_PAGO SET IMPRESION_ID=0, NUMERO_CHEQUE=0, NUMERO_EGRESO = 0, FECHA_CHEQUE=CONVERT(DATETIME,'01-01-1900', 103) WHERE NUMERO_CHEQUE >= " & numeroChequeIni & " AND NUMERO_CHEQUE <= " & numeroChequeFin
        EjecutarQuery(SQLstr)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = Me.gdvMemoramdumsDetalle
        If Me.gdvMemoramdumsDetalle.RowCount > 0 Then
            arrayViatico = New Integer() {}
            For i As Integer = 0 To Me.gdvMemoramdumsDetalle.RowCount
                If view.GetRowCellValue(i, "SELECCIONAR") = True Then
                    'Comprueba nque el viatico no exista en el arreglo 
                    listaViaticos(view.GetRowCellValue(i, "VIATICO_ID"), arrayViatico.Length)
                End If
            Next
        End If
        buscarDetalle(rdgTipoEstado.EditValue)
    End Sub

    Private Sub listaViaticos(ByVal viaticoId As Integer, ByVal indice As Integer)
        Dim noExisteElemento As Boolean = True
        If arrayViatico.Length > 0 Then
            For i As Integer = 0 To (arrayViatico.Length - 1)
                If arrayViatico(i) = viaticoId Then
                    noExisteElemento = False
                    Exit For
                End If
            Next
        End If
        If noExisteElemento Then
            'Redimensiona arreglo
            ReDim Preserve arrayViatico(indice)
            arrayViatico(indice) = viaticoId
        End If
    End Sub

    Private Sub buscarDetalle(ByVal tipoEstado As Integer)
        Dim listaViatico As String = ""
        Dim j As Integer = 0
        If arrayViatico.Length = 1 Then
            listaViatico = "(" + arrayViatico(0).ToString + ")"
        Else
            For i As Integer = 0 To (arrayViatico.Length - 1)
                j += 1
                listaViatico = listaViatico + arrayViatico(i).ToString
                If j < arrayViatico.Length Then
                    listaViatico = listaViatico + ", "
                End If
            Next
            listaViatico = "(" + listaViatico + ")"
        End If
        gdcViaticosAsociados.DataSource = empleado.dvViaticosPorNumeroMemo(luePeriodos.EditValue, listaViatico, tipoEstado)
        gdcViaticosAsociados.Show()
        If gdvViaticosAsociados.RowCount > 0 Then
            Dim fila As Integer = gdvViaticosAsociados.RowCount
            Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = gdvViaticosAsociados
            txtMonto.EditValue = 0
            For i As Integer = 0 To fila
                txtMonto.EditValue += view.GetRowCellValue(i, "MONTO")
            Next
            Me.btnEmitirEgreso.Enabled = True
            If tipoEstado = tipoEstadoViatico.PAGADO Then
                Me.btnGenerarCheque.Enabled = False
            Else
                Me.btnGenerarCheque.Enabled = True
            End If
        Else
            Me.btnGenerarCheque.Enabled = False
            Me.btnEmitirEgreso.Enabled = False
        End If
    End Sub

    Private Sub InitDataEmpleado()
        Dim ds As New DataAccess.Empleados
        repositorio.dvEmpleados = repositorio.dvEmpleados
    End Sub

    Private Sub ActualizarDetalleViatico(ByVal idViaticoDetalle As Integer, ByVal numeroCheque As String, ByVal estado As Integer, ByVal fecha As String)
        Dim SQLstr As String = "UPDATE RH_PER_VIATICO_DETALLE SET ESTADO_VIATICO=" & estado & ", NUMERO_DOCUMENTO='" & numeroCheque & "', FECHA_DOCUMENTO=CONVERT(DATETIME,'" & fecha & "',103) WHERE VIATICO_DETALLE_ID = " & idViaticoDetalle.ToString
        EjecutarQuery(SQLstr)
    End Sub

    Private Sub ActualizarEncabezadoViatico(ByVal idViatico As Integer, ByVal nombres As String, ByVal apellidos As String, ByVal numeroCheque As Integer, ByVal monto As Integer, ByVal fecha As String)
        Dim SQLstr As String = "UPDATE RH_PER_VIATICO SET MONTO=" & monto & ", NOMBRES='" & RTrim(nombres) & "', APELLIDOS='" & RTrim(apellidos) & "', NUMERO_CHEQUE=" & numeroCheque.ToString & ", FECHA_CHEQUE=CONVERT(DATETIME,'" & fecha & "',103) WHERE VIATICO_ID = " & idViatico.ToString
        EjecutarQuery(SQLstr)
    End Sub

    Private Sub InsertarCheque(ByVal numCheque As Integer, ByVal fecha As String, ByVal empleadoid As Integer, ByVal monto As Long)
        Dim SQLstr As String = "INSERT INTO RH_PER_CHEQUE (NUMERO, FECHA, BANCO_ID, MONTO, EMPLEADO_ID, ESTADO, ORIGEN) VALUES "
        SQLstr = SQLstr & "(" & numCheque & ",convert(datetime,'" & fecha & "',103),3," & monto & ", " & empleadoid & ", 0, 0)"
        EjecutarQuery(SQLstr)
    End Sub

    Private Sub InsertarEgresoCabecera(ByVal numCheque As Integer, ByVal fecha As String, ByVal nombreCompleto As Integer, ByVal monto As Long)
        Dim SQLstr As String = "INSERT INTO RH_GEN_EGRESO_CABECERA (NUMERO_CHEQUE, FECHA_CHEQUE, MONTO_CHEQUE, NOMBRE, ORIGEN_EGRESO_ID, CONCEPTO, FECHA_ACTUALIZACION) VALUES "
        SQLstr = SQLstr & "(" & numCheque & ",convert(datetime,'" & fecha & "',103),3," & monto & ", " & nombreCompleto & ", 1, 'VIATICO')"
        EjecutarQuery(SQLstr)
    End Sub

    Private Sub InsertarEgresoDetalle(ByVal egresoId As Integer, ByVal viaticoDetalleId As Integer, ByVal montoDetalle As Integer, ByVal nombreDetalle As String, ByVal Departamento As String)
        Dim SQLstr As String = "INSERT INTO RH_GEN_EGRESO_DETALLE (EGRESO_ID, VIATICO_DETALLE_ID, MONTO_DETALLE, NOMBRE_DETALLE, DEPARTAMENTO) VALUES "
        SQLstr = SQLstr & "(" & egresoId & "," & viaticoDetalleId & ", " & montoDetalle & ", '" & nombreDetalle & "', '" & Departamento & "')"
        EjecutarQuery(SQLstr)
    End Sub

    Private Sub EjecutarQuery(ByVal sqlSTR As String)
        Dim objcommand As New SqlClient.SqlCommand(sqlSTR, New SqlClient.SqlConnection(connectionString))
        objcommand.Connection.Open()
        objcommand.ExecuteNonQuery()
        objcommand.Connection.Close()
        objcommand.Dispose()
        objcommand = Nothing
    End Sub

    Private Sub InitPeriodos()
        GeneraDataViews()
        luePeriodos.Properties.DataSource = dvPeriodo
        luePeriodos.Properties.DisplayMember = "ANO"
        luePeriodos.Properties.NullText = ""
        luePeriodos.Properties.ValueMember = "ANO"
    End Sub
    Private Sub GeneraDataViews()
        Dim dad As SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
        Dim ds2 As New DataSet

        dad = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT DISTINCT ANO FROM RH_REM_PERIODO ORDER BY ANO DESC", conn))
        dad.Fill(ds2, Tablas.RH_REM_PERIODO)
        Dim dvmPeriodo As New DataViewManager(ds2)
        dvPeriodo = dvmPeriodo.CreateDataView(ds2.Tables(Tablas.RH_REM_PERIODO))
    End Sub
    'Obtiene todos los viáticos asigandos al empleado consultado, como también al número de documento.
    Private Sub recuperaViaticos(ByVal idempleado As Integer, ByVal año As Integer, Optional ByVal numMemo As String = "")
        gdcViaticosAsociados.DataSource = empleado.dvViativosAsignados(idempleado, año, numMemo)
        gdcViaticosAsociados.Show()
    End Sub

    Private Sub btnEmitirEgreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmitirEgreso.Click
        Dim view1 As DevExpress.XtraGrid.Views.Base.ColumnView = gdvMemoramdumsDetalle
        Dim soloUnaVez As Integer = 1
        Dim PrimerEgresoId As Integer
        Dim EgresosDistintos As Boolean = True
        For i As Integer = 0 To Me.gdvMemoramdumsDetalle.RowCount - 1
            If view1.GetRowCellValue(i, "SELECCIONAR") = True Then
                If soloUnaVez = 1 Then
                    PrimerEgresoId = view1.GetRowCellValue(i, "EGRESO_ID")
                    soloUnaVez = 0
                ElseIf PrimerEgresoId <> view1.GetRowCellValue(i, "EGRESO_ID") Then
                    EgresosDistintos = False
                    Exit For
                End If
            End If
        Next
        If EgresosDistintos = False Then
            MessageBox.Show("No se puede emitir el egreso, los registros selecionados deben corresponder al mismo numero de egreso.", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptEgresos
        Cursor.Current = Cursors.WaitCursor
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        Dim strFormulaSeleccion As String = "{RH_GEN_EGRESO_CABECERA.EGRESO_ID}=" & PrimerEgresoId
        'strFormulaSeleccion &= " AND {VW_RH_PER_HORAS_EXTRAS.TIPO_PROCESO}=""" & rdgTipoProceso.EditValue & """"
        reporte.SummaryInfo.ReportTitle = "Egresos"
        ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
        ventanaReporte1.rptVisor.ShowParameterPanelButton = False
        ventanaReporte1.rptVisor.ShowCloseButton = False
        ventanaReporte1.rptVisor.ShowGroupTreeButton = False
        ventanaReporte1.rptVisor.ReportSource = reporte
        Cursor.Current = Cursors.Default
        ventanaReporte1.Show()
        'Me.Close()
    End Sub


End Class
