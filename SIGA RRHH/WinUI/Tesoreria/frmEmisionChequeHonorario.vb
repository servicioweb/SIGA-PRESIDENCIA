Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Reportes
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns


Public Class frmEmisionChequeHonorario
    Inherits System.Windows.Forms.Form

    Private empleado As New empleado
    Private periodo As New Periodo
    Private connectionString As String = Comun.ArgoConfiguracion.ConnectionString

    Private Enum tipoProceso
        PLATA_CONTRATA = 0
        HONORARIOS = 1
    End Enum

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
    Friend WithEvents gpcFiltros As DevExpress.XtraEditors.GroupControl
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents chkIncluirSoloCheques As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colTESORERIA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAPELLIDOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLIQUIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_COMPLETO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gdcDetalleHonorarios As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalleHonorarios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNOMBRE_FORMA_PAGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_DEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtChequeInicial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dedFechaChequeInicial As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblChequeInicial As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFechaCheque As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnImprimirCheque As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gpcBotones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents colEGRESO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUMERO_CHEQUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFORMA_PAGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkEmiteCheque As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colCHEQUE_EMITIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblChequeFinal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtChequeFinal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumeroCtaCte As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpcFiltros = New DevExpress.XtraEditors.GroupControl
        Me.chkIncluirSoloCheques = New DevExpress.XtraEditors.CheckEdit
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.btnImprimirCheque = New DevExpress.XtraEditors.SimpleButton
        Me.btnAnular = New DevExpress.XtraEditors.SimpleButton
        Me.gdcDetalleHonorarios = New DevExpress.XtraGrid.GridControl
        Me.gdvDetalleHonorarios = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colTESORERIA_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_COMPLETO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAPELLIDOS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRES = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRUT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDV = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLIQUIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_FORMA_PAGO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCHEQUE_EMITIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkEmiteCheque = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colNOMBRE_DEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEGRESO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNUMERO_CHEQUE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFORMA_PAGO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gpcBotones = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtNumeroCtaCte = New DevExpress.XtraEditors.TextEdit
        Me.lblChequeFinal = New DevExpress.XtraEditors.LabelControl
        Me.txtChequeFinal = New DevExpress.XtraEditors.TextEdit
        Me.lblFechaCheque = New DevExpress.XtraEditors.LabelControl
        Me.lblChequeInicial = New DevExpress.XtraEditors.LabelControl
        Me.dedFechaChequeInicial = New DevExpress.XtraEditors.DateEdit
        Me.txtChequeInicial = New DevExpress.XtraEditors.TextEdit
        CType(Me.gpcFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcFiltros.SuspendLayout()
        CType(Me.chkIncluirSoloCheques.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcDetalleHonorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleHonorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEmiteCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBotones.SuspendLayout()
        CType(Me.txtNumeroCtaCte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChequeFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaChequeInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChequeInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcFiltros
        '
        Me.gpcFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcFiltros.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcFiltros.AppearanceCaption.Options.UseFont = True
        Me.gpcFiltros.Controls.Add(Me.chkIncluirSoloCheques)
        Me.gpcFiltros.Controls.Add(Me.luePeriodo)
        Me.gpcFiltros.Controls.Add(Me.lblPeriodo)
        Me.gpcFiltros.Controls.Add(Me.btnImprimirCheque)
        Me.gpcFiltros.Controls.Add(Me.btnAnular)
        Me.gpcFiltros.Location = New System.Drawing.Point(0, 0)
        Me.gpcFiltros.Name = "gpcFiltros"
        Me.gpcFiltros.Size = New System.Drawing.Size(840, 88)
        Me.gpcFiltros.TabIndex = 1
        Me.gpcFiltros.Text = "Filtro Período"
        '
        'chkIncluirSoloCheques
        '
        Me.chkIncluirSoloCheques.EditValue = True
        Me.chkIncluirSoloCheques.Location = New System.Drawing.Point(264, 32)
        Me.chkIncluirSoloCheques.Name = "chkIncluirSoloCheques"
        '
        'chkIncluirSoloCheques.Properties
        '
        Me.chkIncluirSoloCheques.Properties.Caption = "Incluir Solo Cheques"
        Me.chkIncluirSoloCheques.Size = New System.Drawing.Size(136, 19)
        Me.chkIncluirSoloCheques.TabIndex = 11
        '
        'luePeriodo
        '
        Me.luePeriodo.EnterMoveNextControl = True
        Me.luePeriodo.Location = New System.Drawing.Point(128, 32)
        Me.luePeriodo.Name = "luePeriodo"
        '
        'luePeriodo.Properties
        '
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(112, 20)
        Me.luePeriodo.TabIndex = 8
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(72, 36)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 16)
        Me.lblPeriodo.TabIndex = 9
        Me.lblPeriodo.Text = "Período"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnImprimirCheque
        '
        Me.btnImprimirCheque.Location = New System.Drawing.Point(424, 32)
        Me.btnImprimirCheque.Name = "btnImprimirCheque"
        Me.btnImprimirCheque.Size = New System.Drawing.Size(104, 23)
        Me.btnImprimirCheque.TabIndex = 0
        Me.btnImprimirCheque.Text = "Imprimir Cheque"
        '
        'btnAnular
        '
        Me.btnAnular.Location = New System.Drawing.Point(544, 32)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(104, 23)
        Me.btnAnular.TabIndex = 6
        Me.btnAnular.Text = "Anular"
        '
        'gdcDetalleHonorarios
        '
        Me.gdcDetalleHonorarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'gdcDetalleHonorarios.EmbeddedNavigator
        '
        Me.gdcDetalleHonorarios.EmbeddedNavigator.Name = ""
        Me.gdcDetalleHonorarios.Location = New System.Drawing.Point(0, 160)
        Me.gdcDetalleHonorarios.MainView = Me.gdvDetalleHonorarios
        Me.gdcDetalleHonorarios.Name = "gdcDetalleHonorarios"
        Me.gdcDetalleHonorarios.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkEmiteCheque})
        Me.gdcDetalleHonorarios.Size = New System.Drawing.Size(840, 336)
        Me.gdcDetalleHonorarios.TabIndex = 3
        Me.gdcDetalleHonorarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleHonorarios})
        '
        'gdvDetalleHonorarios
        '
        Me.gdvDetalleHonorarios.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTESORERIA_ID, Me.colNOMBRE_COMPLETO, Me.colAPELLIDOS, Me.colNOMBRES, Me.colRUT, Me.colDV, Me.colLIQUIDO, Me.colNOMBRE_FORMA_PAGO, Me.colCHEQUE_EMITIDO, Me.colNOMBRE_DEPARTAMENTO, Me.colEGRESO_ID, Me.colNUMERO_CHEQUE, Me.colFORMA_PAGO})
        Me.gdvDetalleHonorarios.GridControl = Me.gdcDetalleHonorarios
        Me.gdvDetalleHonorarios.Name = "gdvDetalleHonorarios"
        Me.gdvDetalleHonorarios.OptionsView.ColumnAutoWidth = False
        Me.gdvDetalleHonorarios.OptionsView.ShowGroupPanel = False
        '
        'colTESORERIA_ID
        '
        Me.colTESORERIA_ID.Caption = "GridColumn1"
        Me.colTESORERIA_ID.FieldName = "TESORERIA_ID"
        Me.colTESORERIA_ID.Name = "colTESORERIA_ID"
        Me.colTESORERIA_ID.OptionsColumn.AllowEdit = False
        Me.colTESORERIA_ID.OptionsColumn.ReadOnly = True
        '
        'colNOMBRE_COMPLETO
        '
        Me.colNOMBRE_COMPLETO.Caption = "Nombre Completo"
        Me.colNOMBRE_COMPLETO.FieldName = "NOMBRE_COMPLETO"
        Me.colNOMBRE_COMPLETO.Name = "colNOMBRE_COMPLETO"
        Me.colNOMBRE_COMPLETO.OptionsColumn.AllowEdit = False
        Me.colNOMBRE_COMPLETO.OptionsColumn.ReadOnly = True
        Me.colNOMBRE_COMPLETO.Visible = True
        Me.colNOMBRE_COMPLETO.VisibleIndex = 0
        Me.colNOMBRE_COMPLETO.Width = 332
        '
        'colAPELLIDOS
        '
        Me.colAPELLIDOS.Caption = "Apellidos"
        Me.colAPELLIDOS.FieldName = "APELLIDOS"
        Me.colAPELLIDOS.Name = "colAPELLIDOS"
        Me.colAPELLIDOS.OptionsColumn.AllowEdit = False
        Me.colAPELLIDOS.OptionsColumn.ReadOnly = True
        '
        'colNOMBRES
        '
        Me.colNOMBRES.Caption = "Nombres"
        Me.colNOMBRES.FieldName = "NOMBRES"
        Me.colNOMBRES.Name = "colNOMBRES"
        Me.colNOMBRES.OptionsColumn.AllowEdit = False
        Me.colNOMBRES.OptionsColumn.ReadOnly = True
        '
        'colRUT
        '
        Me.colRUT.Caption = "Rut"
        Me.colRUT.FieldName = "RUT"
        Me.colRUT.Name = "colRUT"
        Me.colRUT.OptionsColumn.AllowEdit = False
        Me.colRUT.OptionsColumn.ReadOnly = True
        Me.colRUT.Visible = True
        Me.colRUT.VisibleIndex = 1
        Me.colRUT.Width = 100
        '
        'colDV
        '
        Me.colDV.Caption = "Dv"
        Me.colDV.FieldName = "DV"
        Me.colDV.Name = "colDV"
        Me.colDV.OptionsColumn.AllowEdit = False
        Me.colDV.OptionsColumn.ReadOnly = True
        Me.colDV.Visible = True
        Me.colDV.VisibleIndex = 2
        Me.colDV.Width = 45
        '
        'colLIQUIDO
        '
        Me.colLIQUIDO.Caption = "Monto"
        Me.colLIQUIDO.DisplayFormat.FormatString = "n0"
        Me.colLIQUIDO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLIQUIDO.FieldName = "LIQUIDO"
        Me.colLIQUIDO.Name = "colLIQUIDO"
        Me.colLIQUIDO.OptionsColumn.AllowEdit = False
        Me.colLIQUIDO.OptionsColumn.ReadOnly = True
        Me.colLIQUIDO.Visible = True
        Me.colLIQUIDO.VisibleIndex = 3
        '
        'colNOMBRE_FORMA_PAGO
        '
        Me.colNOMBRE_FORMA_PAGO.Caption = "Forma de Pago"
        Me.colNOMBRE_FORMA_PAGO.FieldName = "NOMBRE_FORMA_PAGO"
        Me.colNOMBRE_FORMA_PAGO.Name = "colNOMBRE_FORMA_PAGO"
        Me.colNOMBRE_FORMA_PAGO.OptionsColumn.AllowEdit = False
        Me.colNOMBRE_FORMA_PAGO.OptionsColumn.ReadOnly = True
        Me.colNOMBRE_FORMA_PAGO.Visible = True
        Me.colNOMBRE_FORMA_PAGO.VisibleIndex = 4
        Me.colNOMBRE_FORMA_PAGO.Width = 110
        '
        'colCHEQUE_EMITIDO
        '
        Me.colCHEQUE_EMITIDO.Caption = "Emitir Cheque"
        Me.colCHEQUE_EMITIDO.ColumnEdit = Me.chkEmiteCheque
        Me.colCHEQUE_EMITIDO.FieldName = "CHEQUE_EMITIDO"
        Me.colCHEQUE_EMITIDO.Name = "colCHEQUE_EMITIDO"
        Me.colCHEQUE_EMITIDO.Visible = True
        Me.colCHEQUE_EMITIDO.VisibleIndex = 5
        '
        'chkEmiteCheque
        '
        Me.chkEmiteCheque.AutoHeight = False
        Me.chkEmiteCheque.Name = "chkEmiteCheque"
        '
        'colNOMBRE_DEPARTAMENTO
        '
        Me.colNOMBRE_DEPARTAMENTO.Caption = "Departamento"
        Me.colNOMBRE_DEPARTAMENTO.FieldName = "NOMBRE_DEPARTAMENTO"
        Me.colNOMBRE_DEPARTAMENTO.Name = "colNOMBRE_DEPARTAMENTO"
        Me.colNOMBRE_DEPARTAMENTO.OptionsColumn.AllowEdit = False
        Me.colNOMBRE_DEPARTAMENTO.OptionsColumn.ReadOnly = True
        Me.colNOMBRE_DEPARTAMENTO.Visible = True
        Me.colNOMBRE_DEPARTAMENTO.VisibleIndex = 6
        Me.colNOMBRE_DEPARTAMENTO.Width = 268
        '
        'colEGRESO_ID
        '
        Me.colEGRESO_ID.Caption = "Nro.Egreso"
        Me.colEGRESO_ID.FieldName = "EGRESO_ID"
        Me.colEGRESO_ID.Name = "colEGRESO_ID"
        Me.colEGRESO_ID.OptionsColumn.AllowEdit = False
        Me.colEGRESO_ID.OptionsColumn.ReadOnly = True
        Me.colEGRESO_ID.Width = 90
        '
        'colNUMERO_CHEQUE
        '
        Me.colNUMERO_CHEQUE.Caption = "NroCheque"
        Me.colNUMERO_CHEQUE.FieldName = "NUMERO_CHEQUE"
        Me.colNUMERO_CHEQUE.Name = "colNUMERO_CHEQUE"
        Me.colNUMERO_CHEQUE.OptionsColumn.AllowEdit = False
        Me.colNUMERO_CHEQUE.OptionsColumn.ReadOnly = True
        Me.colNUMERO_CHEQUE.Visible = True
        Me.colNUMERO_CHEQUE.VisibleIndex = 7
        Me.colNUMERO_CHEQUE.Width = 90
        '
        'colFORMA_PAGO
        '
        Me.colFORMA_PAGO.Caption = "Forma Pago ID"
        Me.colFORMA_PAGO.FieldName = "FORMA_PAGO"
        Me.colFORMA_PAGO.Name = "colFORMA_PAGO"
        Me.colFORMA_PAGO.OptionsColumn.AllowEdit = False
        Me.colFORMA_PAGO.OptionsColumn.ReadOnly = True
        Me.colFORMA_PAGO.OptionsColumn.ShowInCustomizationForm = False
        '
        'gpcBotones
        '
        Me.gpcBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcBotones.Controls.Add(Me.LabelControl1)
        Me.gpcBotones.Controls.Add(Me.txtNumeroCtaCte)
        Me.gpcBotones.Controls.Add(Me.lblChequeFinal)
        Me.gpcBotones.Controls.Add(Me.txtChequeFinal)
        Me.gpcBotones.Controls.Add(Me.lblFechaCheque)
        Me.gpcBotones.Controls.Add(Me.lblChequeInicial)
        Me.gpcBotones.Controls.Add(Me.dedFechaChequeInicial)
        Me.gpcBotones.Controls.Add(Me.txtChequeInicial)
        Me.gpcBotones.Location = New System.Drawing.Point(0, 88)
        Me.gpcBotones.Name = "gpcBotones"
        Me.gpcBotones.ShowCaption = False
        Me.gpcBotones.Size = New System.Drawing.Size(840, 72)
        Me.gpcBotones.TabIndex = 4
        Me.gpcBotones.Text = "Botones"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(248, 48)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(80, 14)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Nro.Cuenta Cte."
        '
        'txtNumeroCtaCte
        '
        Me.txtNumeroCtaCte.Location = New System.Drawing.Point(328, 40)
        Me.txtNumeroCtaCte.Name = "txtNumeroCtaCte"
        '
        'txtNumeroCtaCte.Properties
        '
        Me.txtNumeroCtaCte.Properties.DisplayFormat.FormatString = "n0"
        Me.txtNumeroCtaCte.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNumeroCtaCte.Properties.EditFormat.FormatString = "n0"
        Me.txtNumeroCtaCte.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNumeroCtaCte.Properties.Mask.EditMask = "n0"
        Me.txtNumeroCtaCte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumeroCtaCte.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNumeroCtaCte.TabIndex = 8
        '
        'lblChequeFinal
        '
        Me.lblChequeFinal.Location = New System.Drawing.Point(24, 48)
        Me.lblChequeFinal.Name = "lblChequeFinal"
        Me.lblChequeFinal.Size = New System.Drawing.Size(88, 14)
        Me.lblChequeFinal.TabIndex = 7
        Me.lblChequeFinal.Text = "Nro.Cheque Final"
        '
        'txtChequeFinal
        '
        Me.txtChequeFinal.Location = New System.Drawing.Point(120, 40)
        Me.txtChequeFinal.Name = "txtChequeFinal"
        '
        'txtChequeFinal.Properties
        '
        Me.txtChequeFinal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtChequeFinal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtChequeFinal.Properties.Mask.EditMask = "n0"
        Me.txtChequeFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtChequeFinal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtChequeFinal.TabIndex = 6
        '
        'lblFechaCheque
        '
        Me.lblFechaCheque.Location = New System.Drawing.Point(256, 22)
        Me.lblFechaCheque.Name = "lblFechaCheque"
        Me.lblFechaCheque.Size = New System.Drawing.Size(72, 14)
        Me.lblFechaCheque.TabIndex = 5
        Me.lblFechaCheque.Text = "Fecha Cheque"
        '
        'lblChequeInicial
        '
        Me.lblChequeInicial.Location = New System.Drawing.Point(24, 22)
        Me.lblChequeInicial.Name = "lblChequeInicial"
        Me.lblChequeInicial.Size = New System.Drawing.Size(88, 14)
        Me.lblChequeInicial.TabIndex = 4
        Me.lblChequeInicial.Text = "Nro.Cheque Inicial"
        '
        'dedFechaChequeInicial
        '
        Me.dedFechaChequeInicial.EditValue = Nothing
        Me.dedFechaChequeInicial.Location = New System.Drawing.Point(328, 16)
        Me.dedFechaChequeInicial.Name = "dedFechaChequeInicial"
        '
        'dedFechaChequeInicial.Properties
        '
        Me.dedFechaChequeInicial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaChequeInicial.TabIndex = 3
        '
        'txtChequeInicial
        '
        Me.txtChequeInicial.Location = New System.Drawing.Point(120, 16)
        Me.txtChequeInicial.Name = "txtChequeInicial"
        '
        'txtChequeInicial.Properties
        '
        Me.txtChequeInicial.Properties.DisplayFormat.FormatString = "n0"
        Me.txtChequeInicial.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtChequeInicial.Properties.EditFormat.FormatString = "n0"
        Me.txtChequeInicial.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtChequeInicial.Properties.Mask.EditMask = "n0"
        Me.txtChequeInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtChequeInicial.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtChequeInicial.TabIndex = 2
        '
        'frmEmisionChequeHonorario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(840, 498)
        Me.Controls.Add(Me.gpcBotones)
        Me.Controls.Add(Me.gdcDetalleHonorarios)
        Me.Controls.Add(Me.gpcFiltros)
        Me.Name = "frmEmisionChequeHonorario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmisionChequeHonorario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcFiltros.ResumeLayout(False)
        CType(Me.chkIncluirSoloCheques.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcDetalleHonorarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleHonorarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEmiteCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBotones.ResumeLayout(False)
        CType(Me.txtNumeroCtaCte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChequeFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaChequeInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChequeInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmEmisionChequeHonorario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarPeriodos()
        chkIncluirSoloCheques.Checked = True
        Me.dedFechaChequeInicial.EditValue = Date.Now
        Me.txtNumeroCtaCte.Text = 0
    End Sub


    Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged, chkIncluirSoloCheques.EditValueChanged
        If luePeriodo.EditValue <= 0 Then
            Exit Sub
        End If
        Try
            llenarGrilla()
            periodo = New periodo(CType(luePeriodo.EditValue, Integer))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, Comun.ArgoConfiguracion.applicationName)
        End Try

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

    Private Sub btnImprimirCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirCheque.Click
        Dim view As GridView = gdvDetalleHonorarios
        Dim contadorRegistrosNoCheque As Integer = 0
        Dim conradorRegistrosMarcados As Integer = 0
        Dim generarCheques As Boolean = True

        If Me.txtChequeInicial.EditValue <= 0 Then
            Me.txtChequeInicial.ErrorText = "Debe ingresar numero de cheque inicial"
            Exit Sub
        End If

        If Me.txtNumeroCtaCte.EditValue <= 0 Then
            Me.txtNumeroCtaCte.ErrorText = "Debe ingresar numero de cuenta corriente"
            Exit Sub
        End If

        For i As Integer = 0 To gdvDetalleHonorarios.RowCount - 1
            If view.GetRowCellValue(i, "CHEQUE_EMITIDO") = True Then
                conradorRegistrosMarcados += 1
            End If
        Next

        If conradorRegistrosMarcados = 0 Then
            MessageBox.Show("No existen registros seleccioandos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Contar si existen registros seleccioandos que no sean cheques
        For i As Integer = 0 To gdvDetalleHonorarios.RowCount - 1
            If view.GetRowCellValue(i, "FORMA_PAGO") <> 0 And view.GetRowCellValue(i, "CHEQUE_EMITIDO") = True Then
                contadorRegistrosNoCheque += 1
            End If
        Next

        If (contadorRegistrosNoCheque > 0) Then
            If MessageBox.Show("Existen " + contadorRegistrosNoCheque.ToString + " registro(s) seleccioando(s) que no son cheques." + Chr(13) + Chr(13) + "¿Seguro que incluye estos registros para emitir cheque?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.Cancel Then
                generarCheques = False
            End If
        End If

        Dim numeroCheque As Integer = txtChequeInicial.EditValue
        For i As Integer = 0 To gdvDetalleHonorarios.RowCount - 1
            If view.GetRowCellValue(i, "CHEQUE_EMITIDO") = True Then
                If empleado.buscaInteger("SELECT TESORERIA_ID FROM RH_REM_TESORERIA_LIQ_PAGO WHERE NUMERO_CHEQUE = " & numeroCheque.ToString) > 0 Then
                    MessageBox.Show("No se puede generar el cheque, ya existe registrado el cheque nro." + numeroCheque.ToString, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    generarCheques = False
                End If
                numeroCheque += 1
            End If
        Next

        If generarCheques = False Then
            'mensaje de prueba
            Exit Sub
        End If

        Dim impresionId As Integer = empleado.buscaInteger("SELECT TOP 1 IMPRESION_ID FROM RH_REM_TESORERIA_LIQ_PAGO ORDER BY IMPRESION_ID DESC") + 1
        numeroCheque = txtChequeInicial.EditValue
        Dim numeroEgreso As Integer = txtChequeInicial.EditValue
        For i As Integer = 0 To gdvDetalleHonorarios.RowCount - 1
            If view.GetRowCellValue(i, "CHEQUE_EMITIDO") = True Then
                ActualizarCheque(impresionId, view.GetRowCellValue(i, "TESORERIA_ID"), numeroCheque.ToString, numeroEgreso.ToString, CDate(Me.dedFechaChequeInicial.EditValue).ToShortDateString)
                numeroCheque += 1
                numeroEgreso += 1
            End If
        Next
        txtChequeInicial.EditValue = numeroCheque
        llenarGrilla()
        ImprimirCheque(impresionId)

    End Sub

    Private Sub gdvDetalleHonorarios_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gdvDetalleHonorarios.ShowingEditor
        Dim view As GridView = sender
        If view.FocusedColumn.FieldName = "CHEQUE_EMITIDO" And periodo.estadoPeriodo = False Then
            e.Cancel = True
        ElseIf view.FocusedColumn.FieldName = "CHEQUE_EMITIDO" And periodo.estadoPeriodo = True Then
            e.Cancel = ObtieneValorCelda(view, view.FocusedRowHandle)
        End If
    End Sub

    Private Sub ImprimirCheque(ByVal impresionId As Integer)
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptChequeCarta
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        Dim strFormulaSeleccion As String = "{RH_REM_TESORERIA_LIQ_PAGO.IMPRESION_ID}=" & impresionId.ToString
        ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
        ventanaReporte1.rptVisor.ShowParameterPanelButton = False
        ventanaReporte1.rptVisor.ShowCloseButton = False
        ventanaReporte1.rptVisor.ShowGroupTreeButton = False
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.Show()
    End Sub

    Private Sub ActualizarCheque(ByVal ImpresionId As Integer, ByVal TesoreriaId As Integer, ByVal numeroCheque As String, ByVal numeroEgreso As String, ByVal fechaCheque As String)
        Dim SQLstr As String = "UPDATE RH_REM_TESORERIA_LIQ_PAGO SET IMPRESION_ID=" & ImpresionId & ", NUMERO_CHEQUE=" & numeroCheque & ", NUMERO_EGRESO = " & numeroEgreso & ", FECHA_CHEQUE=CONVERT(DATETIME,'" & fechaCheque & "', 103) ,NUMERO_CUENTA_CORRIENTE = " & Me.txtNumeroCtaCte.EditValue & " WHERE TESORERIA_ID = " & TesoreriaId.ToString
        EjecutarQuery(SQLstr)
    End Sub

    Private Shared Function ObtieneValorCelda(ByVal view As GridView, ByVal row As Integer) As Boolean
        Dim celda As GridColumn = view.Columns("NUMERO_CHEQUE")
        'Dim celda1 As GridColumn = view.Columns("NUMERO_CHEQUE")
        Dim valorNumeroCheque As Integer = view.GetRowCellValue(row, celda)
        Dim bloqueaEdicionCelda As Boolean
        If valorNumeroCheque = 0 Then
            bloqueaEdicionCelda = False
        Else
            bloqueaEdicionCelda = True
        End If
        Return bloqueaEdicionCelda
    End Function

    Private Sub llenarGrilla()
        Me.gdcDetalleHonorarios.DataSource = empleado.recuperaHonorariosPagoCheque(luePeriodo.EditValue, tipoProceso.HONORARIOS, Me.chkIncluirSoloCheques.Checked)
    End Sub

    Private Sub EjecutarQuery(ByVal sqlSTR As String)
        Try
            Dim objcommand As New SqlClient.SqlCommand(sqlSTR, New SqlClient.SqlConnection(connectionString))
            objcommand.Connection.Open()
            objcommand.ExecuteNonQuery()
            objcommand.Connection.Close()
            objcommand.Dispose()
            objcommand = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        If Me.txtChequeInicial.EditValue <= 0 Then
            Me.txtChequeInicial.ErrorText = "Debe ingresar numero de cheque inicial"
            Exit Sub
        End If
        If Me.txtChequeFinal.EditValue <= 0 Then
            Me.txtChequeFinal.ErrorText = "Debe ingresar numero de cheque final"
            Exit Sub
        End If
        If Me.txtChequeInicial.EditValue > Me.txtChequeFinal.EditValue Then
            Me.txtChequeInicial.ErrorText = "Cheque inicial no puede ser mayor al final"
            Exit Sub
        End If
        If (MessageBox.Show("¿Seguro desea eliminar el cheque?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            AnularCheque(CStr(Me.txtChequeInicial.EditValue), CStr(Me.txtChequeFinal.EditValue))
            llenarGrilla()
        End If

    End Sub

    Private Sub AnularCheque(ByVal numeroChequeIni As String, ByVal numeroChequeFin As String)
        'Dim SQLstr As String = "DELETE FROM RH_REM_TESORERIA_LIQ_PAGO WHERE NUMERO_CHEQUE >= " & numeroChequeIni & " AND NUMERO_CHEQUE <= " & numeroChequeFin
        Dim SQLstr As String = "UPDATE RH_REM_TESORERIA_LIQ_PAGO SET IMPRESION_ID=0, NUMERO_CHEQUE=0, NUMERO_EGRESO = 0, FECHA_CHEQUE=CONVERT(DATETIME,'01-01-1900', 103) WHERE NUMERO_CHEQUE >= " & numeroChequeIni & " AND NUMERO_CHEQUE <= " & numeroChequeFin
        EjecutarQuery(SQLstr)
    End Sub

  
End Class
