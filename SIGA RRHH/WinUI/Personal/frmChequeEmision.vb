Imports cl.presidencia.Argo.Reportes
Imports cl.presidencia.Argo.BusinessRules
Imports System.IO
Imports System.Drawing.Printing

Public Class frmChequeEmision
    Inherits System.Windows.Forms.Form

    Private cheque As New cheque
    Private empleado As New Empleado
    Private printFont As Font
    Private streamToPrint As StreamReader
    Private connectionString As String = Comun.ArgoConfiguracion.ConnectionString
    Private Shared filePath As String

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
    Friend WithEvents GC1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents dvPeriodo As System.Data.DataView
    Friend WithEvents gcResultado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnGeneraCheque As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumCheque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtChequeHasta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtChequeDesde As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents prnListadoViaticos As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMontoCheque As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnBuscarFolio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNumeroFolio As System.Windows.Forms.TextBox
    Friend WithEvents colEMISOR_CHEQUE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_RAZON_SOCIAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUMERO_CHEQUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_CHEQUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO_REGISTRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gdvCheques As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gdcCheques As DevExpress.XtraGrid.GridControl
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEmitirVoucher As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAnularCheque As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colMONTO_EN_LETRAS_PART1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_EN_LETRAS_PART2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnImprimirListado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVoucherFinal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVoucherInicial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblVoucherEntre As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumCtaCte As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colMOTIVO As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequeEmision))
        Me.GC1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnBuscarFolio = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumeroFolio = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dvPeriodo = New System.Data.DataView()
        Me.gcResultado = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumCtaCte = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtVoucherFinal = New DevExpress.XtraEditors.TextEdit()
        Me.txtVoucherInicial = New DevExpress.XtraEditors.TextEdit()
        Me.lblVoucherEntre = New DevExpress.XtraEditors.LabelControl()
        Me.btnImprimirListado = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAnularCheque = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtChequeHasta = New DevExpress.XtraEditors.TextEdit()
        Me.txtChequeDesde = New DevExpress.XtraEditors.TextEdit()
        Me.btnEmitirVoucher = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumCheque = New DevExpress.XtraEditors.TextEdit()
        Me.btnGeneraCheque = New DevExpress.XtraEditors.SimpleButton()
        Me.gdcCheques = New DevExpress.XtraGrid.GridControl()
        Me.gdvCheques = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEMISOR_CHEQUE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_RAZON_SOCIAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMontoCheque = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colNUMERO_CHEQUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_CHEQUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO_REGISTRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_EN_LETRAS_PART1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_EN_LETRAS_PART2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMOTIVO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.prnListadoViaticos = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GC1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcResultado.SuspendLayout()
        CType(Me.txtNumCtaCte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoucherFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoucherInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChequeHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChequeDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumCheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prnListadoViaticos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GC1
        '
        Me.GC1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GC1.AppearanceCaption.Options.UseFont = True
        Me.GC1.Controls.Add(Me.btnBuscarFolio)
        Me.GC1.Controls.Add(Me.Label1)
        Me.GC1.Controls.Add(Me.txtNumeroFolio)
        Me.GC1.Location = New System.Drawing.Point(0, 0)
        Me.GC1.Name = "GC1"
        Me.GC1.Size = New System.Drawing.Size(928, 80)
        Me.GC1.TabIndex = 49
        Me.GC1.Text = "Criterios de Búsqueda"
        '
        'btnBuscarFolio
        '
        Me.btnBuscarFolio.Location = New System.Drawing.Point(232, 32)
        Me.btnBuscarFolio.Name = "btnBuscarFolio"
        Me.btnBuscarFolio.Size = New System.Drawing.Size(96, 23)
        Me.btnBuscarFolio.TabIndex = 4
        Me.btnBuscarFolio.Text = "Buscar Folio"
        Me.btnBuscarFolio.ToolTip = "Búsca todos los viáticos asociados al Memorandum"
        Me.btnBuscarFolio.ToolTipTitle = "Buscar"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Numero de Folio"
        '
        'txtNumeroFolio
        '
        Me.txtNumeroFolio.Location = New System.Drawing.Point(112, 32)
        Me.txtNumeroFolio.Name = "txtNumeroFolio"
        Me.txtNumeroFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroFolio.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'gcResultado
        '
        Me.gcResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcResultado.Controls.Add(Me.LabelControl1)
        Me.gcResultado.Controls.Add(Me.txtNumCtaCte)
        Me.gcResultado.Controls.Add(Me.LabelControl5)
        Me.gcResultado.Controls.Add(Me.txtVoucherFinal)
        Me.gcResultado.Controls.Add(Me.txtVoucherInicial)
        Me.gcResultado.Controls.Add(Me.lblVoucherEntre)
        Me.gcResultado.Controls.Add(Me.btnImprimirListado)
        Me.gcResultado.Controls.Add(Me.btnAnularCheque)
        Me.gcResultado.Controls.Add(Me.LabelControl3)
        Me.gcResultado.Controls.Add(Me.LabelControl4)
        Me.gcResultado.Controls.Add(Me.txtChequeHasta)
        Me.gcResultado.Controls.Add(Me.txtChequeDesde)
        Me.gcResultado.Controls.Add(Me.btnEmitirVoucher)
        Me.gcResultado.Controls.Add(Me.LabelControl2)
        Me.gcResultado.Controls.Add(Me.txtNumCheque)
        Me.gcResultado.Controls.Add(Me.btnGeneraCheque)
        Me.gcResultado.Controls.Add(Me.gdcCheques)
        Me.gcResultado.Location = New System.Drawing.Point(0, 79)
        Me.gcResultado.Name = "gcResultado"
        Me.gcResultado.Size = New System.Drawing.Size(928, 393)
        Me.gcResultado.TabIndex = 50
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Location = New System.Drawing.Point(448, 272)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl1.TabIndex = 29
        Me.LabelControl1.Text = "Num.Cta.Cte."
        '
        'txtNumCtaCte
        '
        Me.txtNumCtaCte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNumCtaCte.Location = New System.Drawing.Point(527, 270)
        Me.txtNumCtaCte.Name = "txtNumCtaCte"
        Me.txtNumCtaCte.Properties.Mask.EditMask = "n0"
        Me.txtNumCtaCte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumCtaCte.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNumCtaCte.Properties.MaxLength = 7
        Me.txtNumCtaCte.Size = New System.Drawing.Size(100, 20)
        Me.txtNumCtaCte.TabIndex = 7
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Location = New System.Drawing.Point(512, 363)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl5.TabIndex = 27
        Me.LabelControl5.Text = "y"
        '
        'txtVoucherFinal
        '
        Me.txtVoucherFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtVoucherFinal.Location = New System.Drawing.Point(528, 363)
        Me.txtVoucherFinal.Name = "txtVoucherFinal"
        Me.txtVoucherFinal.Size = New System.Drawing.Size(100, 20)
        Me.txtVoucherFinal.TabIndex = 18
        '
        'txtVoucherInicial
        '
        Me.txtVoucherInicial.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtVoucherInicial.Location = New System.Drawing.Point(400, 363)
        Me.txtVoucherInicial.Name = "txtVoucherInicial"
        Me.txtVoucherInicial.Size = New System.Drawing.Size(100, 20)
        Me.txtVoucherInicial.TabIndex = 16
        '
        'lblVoucherEntre
        '
        Me.lblVoucherEntre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblVoucherEntre.Location = New System.Drawing.Point(312, 369)
        Me.lblVoucherEntre.Name = "lblVoucherEntre"
        Me.lblVoucherEntre.Size = New System.Drawing.Size(72, 13)
        Me.lblVoucherEntre.TabIndex = 24
        Me.lblVoucherEntre.Text = "Voucher entre:"
        '
        'btnImprimirListado
        '
        Me.btnImprimirListado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirListado.Location = New System.Drawing.Point(784, 283)
        Me.btnImprimirListado.Name = "btnImprimirListado"
        Me.btnImprimirListado.Size = New System.Drawing.Size(112, 23)
        Me.btnImprimirListado.TabIndex = 22
        Me.btnImprimirListado.Text = "Imprimir Listado"
        Me.btnImprimirListado.ToolTip = "Emite voucher en estado pendiente"
        '
        'btnAnularCheque
        '
        Me.btnAnularCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAnularCheque.Location = New System.Drawing.Point(656, 315)
        Me.btnAnularCheque.Name = "btnAnularCheque"
        Me.btnAnularCheque.Size = New System.Drawing.Size(112, 23)
        Me.btnAnularCheque.TabIndex = 24
        Me.btnAnularCheque.Text = "Anular Cheque"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Location = New System.Drawing.Point(512, 337)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl3.TabIndex = 21
        Me.LabelControl3.Text = "y"
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Location = New System.Drawing.Point(280, 339)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl4.TabIndex = 20
        Me.LabelControl4.Text = "Anular cheques entre:"
        '
        'txtChequeHasta
        '
        Me.txtChequeHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtChequeHasta.Location = New System.Drawing.Point(528, 331)
        Me.txtChequeHasta.Name = "txtChequeHasta"
        Me.txtChequeHasta.Size = New System.Drawing.Size(100, 20)
        Me.txtChequeHasta.TabIndex = 14
        '
        'txtChequeDesde
        '
        Me.txtChequeDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtChequeDesde.Location = New System.Drawing.Point(400, 331)
        Me.txtChequeDesde.Name = "txtChequeDesde"
        Me.txtChequeDesde.Size = New System.Drawing.Size(100, 20)
        Me.txtChequeDesde.TabIndex = 12
        '
        'btnEmitirVoucher
        '
        Me.btnEmitirVoucher.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEmitirVoucher.Enabled = False
        Me.btnEmitirVoucher.Location = New System.Drawing.Point(656, 347)
        Me.btnEmitirVoucher.Name = "btnEmitirVoucher"
        Me.btnEmitirVoucher.Size = New System.Drawing.Size(112, 23)
        Me.btnEmitirVoucher.TabIndex = 26
        Me.btnEmitirVoucher.Text = "Emitir Voucher"
        Me.btnEmitirVoucher.ToolTip = "Emite voucher de egreso según el rango ingresado"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Location = New System.Drawing.Point(400, 306)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Número de cheque inicial"
        '
        'txtNumCheque
        '
        Me.txtNumCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNumCheque.Location = New System.Drawing.Point(528, 299)
        Me.txtNumCheque.Name = "txtNumCheque"
        Me.txtNumCheque.Size = New System.Drawing.Size(100, 20)
        Me.txtNumCheque.TabIndex = 10
        '
        'btnGeneraCheque
        '
        Me.btnGeneraCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGeneraCheque.Location = New System.Drawing.Point(656, 283)
        Me.btnGeneraCheque.Name = "btnGeneraCheque"
        Me.btnGeneraCheque.Size = New System.Drawing.Size(112, 24)
        Me.btnGeneraCheque.TabIndex = 20
        Me.btnGeneraCheque.Text = "Generar Cheques"
        Me.btnGeneraCheque.ToolTip = "Generar cheques para registros pendientes de pago"
        '
        'gdcCheques
        '
        Me.gdcCheques.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcCheques.Location = New System.Drawing.Point(0, 16)
        Me.gdcCheques.MainView = Me.gdvCheques
        Me.gdcCheques.Name = "gdcCheques"
        Me.gdcCheques.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtMontoCheque})
        Me.gdcCheques.Size = New System.Drawing.Size(912, 248)
        Me.gdcCheques.TabIndex = 40
        Me.gdcCheques.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvCheques, Me.GridView1})
        '
        'gdvCheques
        '
        Me.gdvCheques.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEMISOR_CHEQUE_ID, Me.colNOMBRE_RAZON_SOCIAL, Me.colMONTO, Me.colNUMERO_CHEQUE, Me.colFECHA_CHEQUE, Me.colESTADO_REGISTRO, Me.colDESCRIPCION, Me.colMONTO_EN_LETRAS_PART1, Me.colMONTO_EN_LETRAS_PART2, Me.colMES, Me.colMOTIVO})
        Me.gdvCheques.GridControl = Me.gdcCheques
        Me.gdvCheques.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas"
        Me.gdvCheques.Name = "gdvCheques"
        Me.gdvCheques.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gdvCheques.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gdvCheques.OptionsSelection.EnableAppearanceHideSelection = False
        Me.gdvCheques.OptionsSelection.InvertSelection = True
        Me.gdvCheques.OptionsSelection.MultiSelect = True
        Me.gdvCheques.OptionsSelection.UseIndicatorForSelection = False
        Me.gdvCheques.OptionsView.ColumnAutoWidth = False
        '
        'colEMISOR_CHEQUE_ID
        '
        Me.colEMISOR_CHEQUE_ID.Caption = "Número Folio"
        Me.colEMISOR_CHEQUE_ID.FieldName = "EMISOR_CHEQUE_ID"
        Me.colEMISOR_CHEQUE_ID.Name = "colEMISOR_CHEQUE_ID"
        Me.colEMISOR_CHEQUE_ID.OptionsColumn.ReadOnly = True
        Me.colEMISOR_CHEQUE_ID.Visible = True
        Me.colEMISOR_CHEQUE_ID.VisibleIndex = 0
        '
        'colNOMBRE_RAZON_SOCIAL
        '
        Me.colNOMBRE_RAZON_SOCIAL.Caption = "Nombre o Razón Social"
        Me.colNOMBRE_RAZON_SOCIAL.FieldName = "NOMBRE_RAZON_SOCIAL"
        Me.colNOMBRE_RAZON_SOCIAL.Name = "colNOMBRE_RAZON_SOCIAL"
        Me.colNOMBRE_RAZON_SOCIAL.OptionsColumn.ReadOnly = True
        Me.colNOMBRE_RAZON_SOCIAL.Visible = True
        Me.colNOMBRE_RAZON_SOCIAL.VisibleIndex = 1
        Me.colNOMBRE_RAZON_SOCIAL.Width = 326
        '
        'colMONTO
        '
        Me.colMONTO.Caption = "Monto"
        Me.colMONTO.ColumnEdit = Me.txtMontoCheque
        Me.colMONTO.FieldName = "MONTO"
        Me.colMONTO.Name = "colMONTO"
        Me.colMONTO.OptionsColumn.ReadOnly = True
        Me.colMONTO.Visible = True
        Me.colMONTO.VisibleIndex = 2
        '
        'txtMontoCheque
        '
        Me.txtMontoCheque.AutoHeight = False
        Me.txtMontoCheque.DisplayFormat.FormatString = "n0"
        Me.txtMontoCheque.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoCheque.EditFormat.FormatString = "n0"
        Me.txtMontoCheque.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoCheque.Mask.EditMask = "n0"
        Me.txtMontoCheque.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoCheque.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoCheque.Name = "txtMontoCheque"
        '
        'colNUMERO_CHEQUE
        '
        Me.colNUMERO_CHEQUE.Caption = "Número Cheque"
        Me.colNUMERO_CHEQUE.ColumnEdit = Me.txtMontoCheque
        Me.colNUMERO_CHEQUE.FieldName = "NUMERO_CHEQUE"
        Me.colNUMERO_CHEQUE.Name = "colNUMERO_CHEQUE"
        Me.colNUMERO_CHEQUE.OptionsColumn.ReadOnly = True
        Me.colNUMERO_CHEQUE.Visible = True
        Me.colNUMERO_CHEQUE.VisibleIndex = 3
        Me.colNUMERO_CHEQUE.Width = 118
        '
        'colFECHA_CHEQUE
        '
        Me.colFECHA_CHEQUE.Caption = "Fecha Cheque"
        Me.colFECHA_CHEQUE.FieldName = "FECHA_CHEQUE"
        Me.colFECHA_CHEQUE.Name = "colFECHA_CHEQUE"
        Me.colFECHA_CHEQUE.OptionsColumn.ReadOnly = True
        Me.colFECHA_CHEQUE.Visible = True
        Me.colFECHA_CHEQUE.VisibleIndex = 4
        Me.colFECHA_CHEQUE.Width = 107
        '
        'colESTADO_REGISTRO
        '
        Me.colESTADO_REGISTRO.Caption = "Estado Registro"
        Me.colESTADO_REGISTRO.FieldName = "ESTADO_REGISTRO"
        Me.colESTADO_REGISTRO.Name = "colESTADO_REGISTRO"
        Me.colESTADO_REGISTRO.OptionsColumn.ReadOnly = True
        Me.colESTADO_REGISTRO.Width = 442
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "Estado Cheque"
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.OptionsColumn.ReadOnly = True
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 5
        Me.colDESCRIPCION.Width = 110
        '
        'colMONTO_EN_LETRAS_PART1
        '
        Me.colMONTO_EN_LETRAS_PART1.Caption = "Monto Escrito 1"
        Me.colMONTO_EN_LETRAS_PART1.FieldName = "MONTO_EN_LETRAS_PART1"
        Me.colMONTO_EN_LETRAS_PART1.Name = "colMONTO_EN_LETRAS_PART1"
        Me.colMONTO_EN_LETRAS_PART1.OptionsColumn.ShowInCustomizationForm = False
        '
        'colMONTO_EN_LETRAS_PART2
        '
        Me.colMONTO_EN_LETRAS_PART2.Caption = "Monto Escrito 2"
        Me.colMONTO_EN_LETRAS_PART2.FieldName = "MONTO_EN_LETRAS_PART2"
        Me.colMONTO_EN_LETRAS_PART2.Name = "colMONTO_EN_LETRAS_PART2"
        Me.colMONTO_EN_LETRAS_PART2.OptionsColumn.ShowInCustomizationForm = False
        '
        'colMES
        '
        Me.colMES.Caption = "Mes"
        Me.colMES.FieldName = "MES"
        Me.colMES.Name = "colMES"
        Me.colMES.OptionsColumn.ShowInCustomizationForm = False
        '
        'colMOTIVO
        '
        Me.colMOTIVO.Caption = "Concepto"
        Me.colMOTIVO.FieldName = "MOTIVO"
        Me.colMOTIVO.Name = "colMOTIVO"
        Me.colMOTIVO.OptionsColumn.AllowEdit = False
        Me.colMOTIVO.OptionsColumn.AllowMove = False
        Me.colMOTIVO.OptionsColumn.ReadOnly = True
        Me.colMOTIVO.Visible = True
        Me.colMOTIVO.VisibleIndex = 6
        Me.colMOTIVO.Width = 270
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcCheques
        Me.GridView1.Name = "GridView1"
        '
        'prnListadoViaticos
        '
        Me.prnListadoViaticos.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcCheques
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
        'frmChequeEmision
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(928, 481)
        Me.Controls.Add(Me.gcResultado)
        Me.Controls.Add(Me.GC1)
        Me.Name = "frmChequeEmision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emisión de Cheques"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GC1.ResumeLayout(False)
        Me.GC1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcResultado.ResumeLayout(False)
        Me.gcResultado.PerformLayout()
        CType(Me.txtNumCtaCte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoucherFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoucherInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChequeHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChequeDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumCheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcCheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvCheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prnListadoViaticos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmChequeEmision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNumeroFolio.Text = 0
        txtNumCheque.Text = 0
        txtChequeDesde.Text = 0
        txtChequeHasta.Text = 0
        txtVoucherInicial.Text = 0
        txtVoucherFinal.Text = 0
        activarBotones(False)

        ''----
        'FileOpen(1, "c:\temp\trash.txt", OpenMode.Output)   ' Open file for output.
        'Print(1, "This is a test.")   ' Print text to file.
        'PrintLine(1)   ' Print blank line to file.
        'PrintLine(1, "Zone 1", TAB(), "Zone 2")   ' Print in two print zones.
        'PrintLine(1, "Hello", "World")   ' Separate strings with a tab.
        'PrintLine(1, SPC(5), "5 leading spaces ")   ' Print five leading spaces.
        'PrintLine(1, TAB(10), "Hello")   ' Print word at column 10.

        '' Assign Boolean, Date, and Error values.
        'Dim aBool As Boolean
        'Dim aDate As DateTime
        'aBool = False
        'aDate = DateTime.Parse("February 12, 1969")

        '' Dates and booleans are translated using locale settings of your system.
        'PrintLine(1, aBool, " is a Boolean value")
        'PrintLine(1, aDate, " is a date")
        'FileClose(1)   ' Close file.
        ''----
    End Sub


    Private Sub btnBuscarFolio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarFolio.Click
        If CType(txtNumeroFolio.Text, Integer) = 0 Then
            gdcCheques.DataSource = cheque.recuperarChequesAEmitir(0)
        Else
            gdcCheques.DataSource = cheque.recuperarChequesAEmitir(CType(txtNumeroFolio.Text, Integer))
        End If
        If gdvCheques.RowCount > 0 Then
            activarBotones(True)
        Else
            activarBotones(False)
        End If
    End Sub

    Private Sub btnGeneraCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneraCheque.Click
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvCheques

        If CType(txtNumCheque.Text, Integer) = 0 Then
            txtNumCheque.ErrorText = "Falta ingresar número de cheque inicial"
            Exit Sub
        End If

        If CType(txtNumCtaCte.Text, Integer) = 0 Then
            txtNumCtaCte.ErrorText = "Falta ingresar número de cuenta corriente"
            Exit Sub
        End If

        If LTrim(validarNumeroCheque.Length) > 0 Then
            MessageBox.Show("Ya fue emitido el o los números de cheque, ver el detalle:" & Chr(13) & validarNumeroCheque(), "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("¿La impresora tiene formulario de cheque?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
            Exit Sub
        End If

        Dim Periodo As New Periodo
        Dim EgresoId As Integer = 0
        Dim ImpresionId As Integer = empleado.buscaInteger("SELECT TOP 1 IMPRESION_ID FROM RH_REM_TESORERIA_LIQ_PAGO ORDER BY IMPRESION_ID DESC") + 1
        For i As Integer = 0 To (gdvCheques.RowCount - 1)
            Dim EmmpleadoId As Integer = 0
            Dim Apellidos As String = view.GetRowCellValue(i, view.Columns("NOMBRE_RAZON_SOCIAL"))
            Dim Nombres As String = ""
            Dim Rut As Integer = 0
            Dim Dv As String = ""
            Dim PeriodoId As Integer = Periodo.ID
            Dim Monto As Integer = view.GetRowCellValue(i, view.Columns("MONTO"))
            Dim TipoProceso As String = "RC"
            Dim NombreCalidadJuridica As String = view.GetRowCellValue(i, view.Columns("MOTIVO"))
            Dim FormaPagoId As Integer = 0
            Dim NombreFormaPago As String = ""
            Dim NombreDepartamento As String = ""
            Dim GenerarCheque As Boolean = False
            Dim ChequeEmitido As Boolean = False
            Dim NumeroCheque As Integer = Me.txtNumCheque.EditValue
            Dim NumeroEgreso As Integer = 0
            Dim FechaCheque As Date = view.GetRowCellValue(i, view.Columns("FECHA_CHEQUE"))
            Dim CalidadJuridicaId As Integer = 0
            Dim NumeroCuentaCorriente As Integer = Me.txtNumCtaCte.EditValue
            Dim NombreCompleto As String = view.GetRowCellValue(i, view.Columns("NOMBRE_RAZON_SOCIAL"))

            Try
                InsertarCheque(NumeroCheque, FechaCheque, EmmpleadoId, Monto)
                EgresoId = empleado.insertarEgresoCabecera(NumeroCheque, FechaCheque, CInt(Monto), NombreCompleto, 1, "REGISTRO CHEQUE", Argo.Comun.ArgoConfiguracion.OrganizacionID)
                InsertarEgresoDetalle(EgresoId, 0, Monto, NombreCompleto, "")

                empleado.InsertaDatosTesoreria(EmmpleadoId, Apellidos, Nombres, Rut, Dv, PeriodoId, Monto, TipoProceso, NombreCalidadJuridica, FormaPagoId, NombreFormaPago, _
                        NombreDepartamento, GenerarCheque, ChequeEmitido, NumeroCheque, NumeroEgreso, FechaCheque, CalidadJuridicaId, ImpresionId, EgresoId, NumeroCuentaCorriente)

                ActualizarCheque(view.GetRowCellValue(i, view.Columns("EMISOR_CHEQUE_ID")), NumeroCheque)
                txtNumCheque.EditValue += 1
            Catch ex As Exception
                MsgBox("Ha ocurrido el siguiente erro al generar cheque " & Chr(13) & ex.Message, MsgBoxStyle.Critical)
            End Try
        Next
        If EgresoId > 0 Then
            gdcCheques.DataSource = cheque.recuperarChequesAEmitir(-1)
            ImprimirCheque(ImpresionId)
        End If

    End Sub

    Private Sub btnGeneraChequeBKP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles btnGeneraCheque.Click
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvCheques

        If CType(txtNumCheque.Text, Integer) = 0 Then
            txtNumCheque.ErrorText = "Falta ingresar núimero de cheque inicial"
            Exit Sub
        End If

        If LTrim(validarNumeroCheque.Length) > 0 Then
            MessageBox.Show("Ya fue emitido el o los números de cheque, ver el detalle:" & Chr(13) & validarNumeroCheque(), "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("¿La impresora tiene formulario continuo de cheque?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
            Exit Sub
        End If

        'Impresion()

        Dim app_PathFile As String = Path.GetFullPath("imprimec.txt")
        Dim app_PathFileBat As String = Path.GetFullPath("imprimec.bat")
        Dim nombreComprobante, nombreCompleto, totalEgreso, valorEnLetrasParte1, valorEnLetrasParte2, Dia, Mes, Ano As String
        Dim largoNombreCompleto As Integer
        Dim numeroCheque As Integer = Me.txtNumCheque.Text
        Dim numeroChequeInicial As Integer = numeroCheque
        Dim numeroChequeFinal As Integer
        Dim contador As Integer = 0
        Dim FechaCheque As String
        Dim MontoEscrito, MontoString As String

        FileOpen(1, app_PathFile, OpenMode.Output)
        'FileOpen(1, "c:\imprimec.txt", OpenMode.Output)
        For i As Integer = 0 To (gdvCheques.RowCount - 1)
            Try
                contador = contador + 1
                nombreCompleto = Replace(view.GetRowCellValue(i, view.Columns("NOMBRE_RAZON_SOCIAL")), "Ñ", "N")
                largoNombreCompleto = Len(nombreCompleto)
                totalEgreso = CType(view.GetRowCellValue(i, view.Columns("MONTO")), String)
                valorEnLetrasParte1 = LTrim(CType(RTrim(view.GetRowCellValue(i, view.Columns("MONTO_EN_LETRAS_PART1"))), String))
                valorEnLetrasParte2 = LTrim(CType(RTrim(view.GetRowCellValue(i, view.Columns("MONTO_EN_LETRAS_PART2"))), String))
                MontoEscrito = valorEnLetrasParte1 + " " + valorEnLetrasParte2
                Dia = Trim(CDate(view.GetRowCellValue(i, view.Columns("FECHA_CHEQUE"))).Day.ToString)
                Mes = Trim(view.GetRowCellValue(i, view.Columns("MES")))
                Ano = Trim(CDate(view.GetRowCellValue(i, view.Columns("FECHA_CHEQUE"))).Year.ToString)
                FechaCheque = Dia & " " & Mes & " " & Ano
                MontoString = LTrim(Format(CInt(totalEgreso), "###,###,###")) + ".-"

                Dim nombreLinea1 As String = ""
                Dim nombreLinea2 As String = ""

                If Len(nombreCompleto) <= 20 Then
                    nombreLinea1 = nombreCompleto
                    nombreLinea2 = ""
                    nombreComprobante = nombreCompleto
                Else
                    nombreLinea1 = nombreCompleto.Substring(0, 20)
                    nombreLinea2 = nombreCompleto.Substring(20, Math.Abs(Len(nombreCompleto) - Len(nombreCompleto.Substring(0, 20))))
                    nombreComprobante = nombreCompleto.Substring(0, 20)
                End If

                'Crea archivo con información.

                PrintLine(1, " ")  ' Linea en blanco.
                PrintLine(1, TAB(102), (LTrim(Format(CInt(totalEgreso), "###,###,###")) + ".-")) 'Imprime monto del cheque.
                PrintLine(1)   ' Linea en blanco.
                PrintLine(1)   ' Linea en blanco.
                PrintLine(1)   ' Linea en blanco.
                PrintLine(1, TAB(10), FechaCheque, TAB(90), FechaCheque) ' Imprime fecha.
                PrintLine(1)   ' Linea en blanco.
                PrintLine(1, TAB(50), nombreCompleto) ' Nombre completo de la persona en el cheque.
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

                'Actualiza registro encabezado de cheque
                ActualizarCheque(view.GetRowCellValue(i, view.Columns("EMISOR_CHEQUE_ID")), numeroCheque)
                numeroChequeFinal = numeroCheque
                numeroCheque = numeroCheque + 1
            Catch ex As Exception
                MsgBox("Ha ocurrido el siguiente erro al generar cheque " & Chr(13) & ex.Message, MsgBoxStyle.Critical)
            End Try
        Next
        FileClose(1) ' Close file.
        txtVoucherInicial.Text = numeroChequeInicial
        txtVoucherFinal.Text = numeroChequeFinal

        Dim frmChequesViatico As New frmChequesViatico

        If contador > 0 Then
            txtNumCheque.Text = numeroCheque
            gdcCheques.DataSource = cheque.recuperarChequesAEmitir(0)
            frmChequesViatico.DefInstance.cheque_inicial_h = numeroChequeInicial
            frmChequesViatico.DefInstance.cheque_final_h = numeroChequeFinal
            frmChequesViatico.DefInstance.Owner = Me
            If frmChequesViatico.DefInstance.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            End If
        End If
    End Sub

    Private Sub ImprimirCheque(ByVal ImpresionId As Integer)
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptChequeCarta
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        Dim strFormulaSeleccion As String = "{RH_REM_TESORERIA_LIQ_PAGO.IMPRESION_ID}=" & ImpresionId.ToString
        ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
        ventanaReporte.rptVisor.ShowParameterPanelButton = False
        ventanaReporte.rptVisor.ShowCloseButton = False
        ventanaReporte.rptVisor.ShowGroupTreeButton = False
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.Show()
    End Sub

    Private Sub Impresion()

        Try
            streamToPrint = New StreamReader(filePath)
            Try
                printFont = New Font("Curier", 17)
                Dim pd As New PrintDocument
                AddHandler pd.PrintPage, AddressOf pd_PrintPage
                ' Print the document.
                pd.Print()
            Finally
                streamToPrint.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' The PrintPage event is raised for each page to be printed.
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim count As Integer = 0
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim line As String = Nothing

        'Dim printFont = New Font("Curier", 17)
        'Dim streamToPrint As StreamReader
        'Dim filePath As String

        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)

        ' Iterate over the file, printing each line.
        While count < linesPerPage
            line = streamToPrint.ReadLine()
            If line Is Nothing Then
                Exit While
            End If
            yPos = topMargin + count * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, _
                yPos, New StringFormat)
            count += 1
        End While

        ' If more lines exist, print another page.
        If Not (line Is Nothing) Then
            ev.HasMorePages = True
        Else
            ev.HasMorePages = False
        End If
    End Sub

    Private Sub InsertarCheque(ByVal numCheque As Integer, ByVal fecha As String, ByVal empleadoid As Integer, ByVal monto As Long)
        Dim SQLstr As String = "INSERT INTO RH_PER_CHEQUE (NUMERO, FECHA, BANCO_ID, MONTO, EMPLEADO_ID, ESTADO, ORIGEN) VALUES "
        SQLstr = SQLstr & "(" & numCheque & ",convert(datetime,'" & fecha & "',103),3," & monto & ", " & empleadoid & ", 0, 0)"
        EjecutarQuery(SQLstr)
    End Sub

    Private Sub ActualizarCheque(ByVal idCheque As Integer, ByVal numeroCheque As Integer)
        cheque = New cheque(idCheque)
        cheque.datosEncabezado.numeroCheque = numeroCheque
        cheque.datosEncabezado.numeroEgreso = numeroCheque
        cheque.datosEncabezado.estadoRegistroCheque = 2
        cheque.ActualizarEncabezado()
    End Sub

    Private Function validarNumeroCheque() As String
        Dim numeroCheque As Integer = CType(txtNumCheque.Text, Integer)
        Dim mensaje As String = ""
        Dim mensajeCheques As String = ""

        For i As Integer = 0 To (gdvCheques.RowCount - 1)
            mensaje = cheque.buscarNumeroCheque(numeroCheque)
            If LTrim(mensaje.Length) > 0 Then
                If LTrim(mensajeCheques.Length) > 0 Then
                    mensajeCheques = mensajeCheques & Chr(13) & mensaje
                Else
                    mensajeCheques = mensajeCheques & mensaje
                End If
            End If
            numeroCheque = numeroCheque + 1
        Next
        Return mensajeCheques
    End Function

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

    Private Sub activarBotones(ByVal habilitar As Boolean)
        btnEmitirVoucher.Enabled = True
        btnAnularCheque.Enabled = True
        btnGeneraCheque.Enabled = habilitar
    End Sub

    Private Sub btnAnularCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularCheque.Click
        Dim cancelar As Boolean = False

        If CType(txtChequeHasta.Text, Integer) <= 0 Then
            txtChequeHasta.ErrorText = "Cheque inicial debe mayor de cero"
            cancelar = True
        End If
        If CType(txtChequeDesde.Text, Integer) <= 0 Then
            txtChequeDesde.ErrorText = "Cheque final debe mayor de cero"
            cancelar = True
        End If
        If CType(txtChequeHasta.Text, Integer) > 0 And CType(txtChequeDesde.Text, Integer) > CType(txtChequeHasta.Text, Integer) Then
            txtChequeDesde.ErrorText = "Cheque inicial a anular no puede ser mayor al cheque final"
            cancelar = True
        End If

        If Not cancelar Then
            If MessageBox.Show("¿Seguro que se desa anular cheques para volver a emitirlo?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                Exit Sub
            End If

            Dim numeroChequeInicial As Integer = CType(txtChequeDesde.Text, Integer)
            Dim numeroChequeFinal As Integer = CType(txtChequeHasta.Text, Integer)
            Dim totalChequesAnulados As Integer = (numeroChequeFinal - numeroChequeInicial) + 1

            For i As Integer = 1 To totalChequesAnulados
                cheque = New cheque(CType(numeroChequeInicial, Decimal))
                cheque.datosEncabezado.numeroCheque = 0
                cheque.datosEncabezado.numeroEgreso = 0
                cheque.datosEncabezado.estadoRegistroCheque = 1
                If cheque.datosEncabezado.chequeID > 0 Then
                    cheque.ActualizarEncabezado()
                End If
                numeroChequeInicial = numeroChequeInicial + 1
            Next
            AnularCheque(CType(txtChequeDesde.Text, String), CType(txtChequeHasta.Text, String))
            txtChequeDesde.Text = ""
            txtChequeHasta.Text = ""
            gdcCheques.DataSource = cheque.recuperarChequesAEmitir(0)
            activarBotones(True)
        End If

    End Sub

    Private Sub btnImprimirListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirListado.Click
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptEgresoCheque
        Cursor.Current = Cursors.WaitCursor
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        Dim strFormulaSeleccion As String = "{VW_REGISTRO_CHEQUES_EGRESO.ESTADO_REGISTRO}=1"
        ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
        ventanaReporte1.rptVisor.ShowParameterPanelButton = False
        ventanaReporte1.rptVisor.ShowCloseButton = False
        ventanaReporte1.rptVisor.ShowGroupTreeButton = False
        ventanaReporte1.rptVisor.ReportSource = reporte
        Cursor.Current = Cursors.Default
        ventanaReporte1.Show()
    End Sub

    Private Sub btnEmitirVoucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmitirVoucher.Click
        Dim cancelar As Boolean = False

        If CType(txtVoucherInicial.Text, Integer) <= 0 Then
            txtVoucherInicial.ErrorText = "Voucher inicial debe mayor de cero"
            cancelar = True
        End If
        If CType(txtVoucherFinal.Text, Integer) <= 0 Then
            txtVoucherFinal.ErrorText = "Voucher final debe mayor de cero"
            cancelar = True
        End If
        If CType(txtVoucherFinal.Text, Integer) > 0 And CType(txtVoucherInicial.Text, Integer) > CType(txtVoucherFinal.Text, Integer) Then
            txtVoucherInicial.ErrorText = "Voucher inicial no puede ser mayor al final"
            cancelar = True
        End If

        If Not cancelar Then
            Dim ventanaReporte1 As New ventanaReporte
            Dim reporte As New rptEgresoCheque
            Cursor.Current = Cursors.WaitCursor
            WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
            Dim strFormulaSeleccion As String = "{VW_REGISTRO_CHEQUES_EGRESO.NUMERO_EGRESO}>=" & Me.txtVoucherInicial.Text
            'strFormulaSeleccion &= " AND {VW_REGISTRO_CHEQUES_EGRESO.NUMERO_EGRESO}<=""" & Me.txtVoucherFinal.Text & """"
            strFormulaSeleccion &= " AND {VW_REGISTRO_CHEQUES_EGRESO.NUMERO_EGRESO}<=" & Me.txtVoucherFinal.Text & ""
            ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
            ventanaReporte1.rptVisor.ShowParameterPanelButton = False
            ventanaReporte1.rptVisor.ShowCloseButton = False
            ventanaReporte1.rptVisor.ShowGroupTreeButton = False
            ventanaReporte1.rptVisor.ReportSource = reporte
            Cursor.Current = Cursors.Default
            ventanaReporte1.Show()
        End If
    End Sub

    Private Sub AnularCheque(ByVal numeroChequeIni As String, ByVal numeroChequeFin As String)
        Dim SQLstr As String = "DELETE FROM RH_REM_TESORERIA_LIQ_PAGO WHERE NUMERO_CHEQUE = " & numeroChequeIni & " AND NUMERO_CHEQUE <= " & numeroChequeFin
        EjecutarQuery(SQLstr)
        Dim strSQL As String = "exec sp_anular_egreso " & CStr(numeroChequeIni) & ", " & CStr(numeroChequeFin)
        EjecutarQuery(strSQL)
    End Sub

    Private Sub AnularEgresos(ByVal numeroChequeIni As String, ByVal numeroChequeFin As String)
        Dim SQLstr As String = "DELETE FROM RH_REM_TESORERIA_LIQ_PAGO WHERE NUMERO_CHEQUE = " & numeroChequeIni & " AND NUMERO_CHEQUE <= " & numeroChequeFin
        EjecutarQuery(SQLstr)
    End Sub
End Class
