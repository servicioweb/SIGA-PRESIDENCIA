Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmChequeRegistro
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
    Friend WithEvents gpcBotonesEncabezado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevoCheque As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminarCheque As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardarCheque As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gpcInformacionGeneral As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblDepartamento As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMotivoViatico As System.Windows.Forms.Label
    Friend WithEvents lblFechaCheque As System.Windows.Forms.Label
    Friend WithEvents lblRazonSocial As System.Windows.Forms.Label
    Friend WithEvents gdcDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDETALLE_EMISOR_CHEQUE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMISOR_CHEQUE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONCEPTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMonto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtRazonSocial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpcDetalle As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblConcepto As System.Windows.Forms.Label
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents txtMontoCheque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnNuevoDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelarDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardarDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lueCheques As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtMotivoCheque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dedFechaCheque As DevExpress.XtraEditors.DateEdit
    Friend WithEvents gpcBotonesDetalle As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancelarCheque As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNumeroFolio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumeroCheque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNumeroCheque As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnEliminarDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents prsCheque As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequeRegistro))
        Me.gpcBotonesEncabezado = New DevExpress.XtraEditors.GroupControl()
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevoCheque = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminarCheque = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardarCheque = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelarCheque = New DevExpress.XtraEditors.SimpleButton()
        Me.gpcInformacionGeneral = New DevExpress.XtraEditors.GroupControl()
        Me.lblNumeroCheque = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumeroCheque = New DevExpress.XtraEditors.TextEdit()
        Me.txtRazonSocial = New DevExpress.XtraEditors.TextEdit()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.txtNumeroFolio = New DevExpress.XtraEditors.TextEdit()
        Me.lblDepartamento = New DevExpress.XtraEditors.LabelControl()
        Me.lueCheques = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblMotivoViatico = New System.Windows.Forms.Label()
        Me.txtMotivoCheque = New DevExpress.XtraEditors.TextEdit()
        Me.lblFechaCheque = New System.Windows.Forms.Label()
        Me.dedFechaCheque = New DevExpress.XtraEditors.DateEdit()
        Me.gdcDetalle = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDETALLE_EMISOR_CHEQUE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEMISOR_CHEQUE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONCEPTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMonto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.gpcDetalle = New DevExpress.XtraEditors.GroupControl()
        Me.txtMontoCheque = New DevExpress.XtraEditors.TextEdit()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.txtConcepto = New DevExpress.XtraEditors.TextEdit()
        Me.btnNuevoDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelarDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardarDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminarDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.gpcBotonesDetalle = New DevExpress.XtraEditors.GroupControl()
        Me.prsCheque = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.gpcBotonesEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBotonesEncabezado.SuspendLayout()
        CType(Me.gpcInformacionGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcInformacionGeneral.SuspendLayout()
        CType(Me.txtNumeroCheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRazonSocial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroFolio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCheques.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMotivoCheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaCheque.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaCheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDetalle.SuspendLayout()
        CType(Me.txtMontoCheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcBotonesDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBotonesDetalle.SuspendLayout()
        CType(Me.prsCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcBotonesEncabezado
        '
        Me.gpcBotonesEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcBotonesEncabezado.Controls.Add(Me.btnVisualizar)
        Me.gpcBotonesEncabezado.Controls.Add(Me.btnNuevoCheque)
        Me.gpcBotonesEncabezado.Controls.Add(Me.btnEliminarCheque)
        Me.gpcBotonesEncabezado.Controls.Add(Me.btnGuardarCheque)
        Me.gpcBotonesEncabezado.Controls.Add(Me.btnCancelarCheque)
        Me.gpcBotonesEncabezado.Location = New System.Drawing.Point(0, 120)
        Me.gpcBotonesEncabezado.Name = "gpcBotonesEncabezado"
        Me.gpcBotonesEncabezado.ShowCaption = False
        Me.gpcBotonesEncabezado.Size = New System.Drawing.Size(792, 40)
        Me.gpcBotonesEncabezado.TabIndex = 2
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(592, 8)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(96, 23)
        Me.btnVisualizar.TabIndex = 4
        Me.btnVisualizar.Text = "Visualizar"
        '
        'btnNuevoCheque
        '
        Me.btnNuevoCheque.Location = New System.Drawing.Point(64, 8)
        Me.btnNuevoCheque.Name = "btnNuevoCheque"
        Me.btnNuevoCheque.Size = New System.Drawing.Size(96, 23)
        Me.btnNuevoCheque.TabIndex = 0
        Me.btnNuevoCheque.Text = "Nuevo Cheque"
        '
        'btnEliminarCheque
        '
        Me.btnEliminarCheque.Location = New System.Drawing.Point(192, 8)
        Me.btnEliminarCheque.Name = "btnEliminarCheque"
        Me.btnEliminarCheque.Size = New System.Drawing.Size(96, 23)
        Me.btnEliminarCheque.TabIndex = 1
        Me.btnEliminarCheque.Text = "Eliminar Cheque"
        '
        'btnGuardarCheque
        '
        Me.btnGuardarCheque.Location = New System.Drawing.Point(320, 8)
        Me.btnGuardarCheque.Name = "btnGuardarCheque"
        Me.btnGuardarCheque.Size = New System.Drawing.Size(96, 23)
        Me.btnGuardarCheque.TabIndex = 2
        Me.btnGuardarCheque.Text = "Guardar Cheque"
        '
        'btnCancelarCheque
        '
        Me.btnCancelarCheque.Location = New System.Drawing.Point(456, 8)
        Me.btnCancelarCheque.Name = "btnCancelarCheque"
        Me.btnCancelarCheque.Size = New System.Drawing.Size(96, 23)
        Me.btnCancelarCheque.TabIndex = 3
        Me.btnCancelarCheque.Text = "Cancelar"
        '
        'gpcInformacionGeneral
        '
        Me.gpcInformacionGeneral.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcInformacionGeneral.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcInformacionGeneral.AppearanceCaption.Options.UseFont = True
        Me.gpcInformacionGeneral.Controls.Add(Me.lblNumeroCheque)
        Me.gpcInformacionGeneral.Controls.Add(Me.txtNumeroCheque)
        Me.gpcInformacionGeneral.Controls.Add(Me.txtRazonSocial)
        Me.gpcInformacionGeneral.Controls.Add(Me.lblRazonSocial)
        Me.gpcInformacionGeneral.Controls.Add(Me.txtNumeroFolio)
        Me.gpcInformacionGeneral.Controls.Add(Me.lblDepartamento)
        Me.gpcInformacionGeneral.Controls.Add(Me.lueCheques)
        Me.gpcInformacionGeneral.Controls.Add(Me.lblMotivoViatico)
        Me.gpcInformacionGeneral.Controls.Add(Me.txtMotivoCheque)
        Me.gpcInformacionGeneral.Controls.Add(Me.lblFechaCheque)
        Me.gpcInformacionGeneral.Controls.Add(Me.dedFechaCheque)
        Me.gpcInformacionGeneral.Location = New System.Drawing.Point(0, 0)
        Me.gpcInformacionGeneral.Name = "gpcInformacionGeneral"
        Me.gpcInformacionGeneral.Size = New System.Drawing.Size(792, 120)
        Me.gpcInformacionGeneral.TabIndex = 1
        Me.gpcInformacionGeneral.Text = "Información General"
        '
        'lblNumeroCheque
        '
        Me.lblNumeroCheque.Location = New System.Drawing.Point(48, 86)
        Me.lblNumeroCheque.Name = "lblNumeroCheque"
        Me.lblNumeroCheque.Size = New System.Drawing.Size(77, 13)
        Me.lblNumeroCheque.TabIndex = 4
        Me.lblNumeroCheque.Text = "Numero Cheque"
        '
        'txtNumeroCheque
        '
        Me.txtNumeroCheque.Enabled = False
        Me.txtNumeroCheque.Location = New System.Drawing.Point(136, 80)
        Me.txtNumeroCheque.Name = "txtNumeroCheque"
        Me.txtNumeroCheque.Size = New System.Drawing.Size(96, 20)
        Me.txtNumeroCheque.TabIndex = 5
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.EnterMoveNextControl = True
        Me.txtRazonSocial.Location = New System.Drawing.Point(448, 56)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazonSocial.Properties.MaxLength = 45
        Me.txtRazonSocial.Size = New System.Drawing.Size(328, 20)
        Me.txtRazonSocial.TabIndex = 9
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonSocial.Location = New System.Drawing.Point(280, 60)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(152, 16)
        Me.lblRazonSocial.TabIndex = 8
        Me.lblRazonSocial.Text = "Nombre o Razón Social"
        Me.lblRazonSocial.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNumeroFolio
        '
        Me.txtNumeroFolio.Enabled = False
        Me.txtNumeroFolio.Location = New System.Drawing.Point(136, 32)
        Me.txtNumeroFolio.Name = "txtNumeroFolio"
        Me.txtNumeroFolio.Size = New System.Drawing.Size(96, 20)
        Me.txtNumeroFolio.TabIndex = 1
        '
        'lblDepartamento
        '
        Me.lblDepartamento.Location = New System.Drawing.Point(48, 40)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(62, 13)
        Me.lblDepartamento.TabIndex = 0
        Me.lblDepartamento.Text = "Numero Folio"
        '
        'lueCheques
        '
        Me.lueCheques.Location = New System.Drawing.Point(136, 32)
        Me.lueCheques.Name = "lueCheques"
        Me.lueCheques.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCheques.Properties.NullText = ""
        Me.lueCheques.Size = New System.Drawing.Size(96, 20)
        Me.lueCheques.TabIndex = 1
        '
        'lblMotivoViatico
        '
        Me.lblMotivoViatico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivoViatico.Location = New System.Drawing.Point(384, 36)
        Me.lblMotivoViatico.Name = "lblMotivoViatico"
        Me.lblMotivoViatico.Size = New System.Drawing.Size(48, 16)
        Me.lblMotivoViatico.TabIndex = 6
        Me.lblMotivoViatico.Text = "Motivo"
        Me.lblMotivoViatico.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMotivoCheque
        '
        Me.txtMotivoCheque.EnterMoveNextControl = True
        Me.txtMotivoCheque.Location = New System.Drawing.Point(448, 32)
        Me.txtMotivoCheque.Name = "txtMotivoCheque"
        Me.txtMotivoCheque.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMotivoCheque.Properties.MaxLength = 200
        Me.txtMotivoCheque.Size = New System.Drawing.Size(328, 20)
        Me.txtMotivoCheque.TabIndex = 7
        '
        'lblFechaCheque
        '
        Me.lblFechaCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaCheque.Location = New System.Drawing.Point(8, 60)
        Me.lblFechaCheque.Name = "lblFechaCheque"
        Me.lblFechaCheque.Size = New System.Drawing.Size(120, 16)
        Me.lblFechaCheque.TabIndex = 2
        Me.lblFechaCheque.Text = "Fecha Cheque"
        Me.lblFechaCheque.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dedFechaCheque
        '
        Me.dedFechaCheque.EditValue = Nothing
        Me.dedFechaCheque.EnterMoveNextControl = True
        Me.dedFechaCheque.Location = New System.Drawing.Point(136, 56)
        Me.dedFechaCheque.Name = "dedFechaCheque"
        Me.dedFechaCheque.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaCheque.Properties.Mask.EditMask = ""
        Me.dedFechaCheque.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.dedFechaCheque.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaCheque.Size = New System.Drawing.Size(96, 20)
        Me.dedFechaCheque.TabIndex = 3
        '
        'gdcDetalle
        '
        Me.gdcDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcDetalle.Location = New System.Drawing.Point(0, 288)
        Me.gdcDetalle.MainView = Me.gdvDetalle
        Me.gdcDetalle.Name = "gdcDetalle"
        Me.gdcDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtMonto})
        Me.gdcDetalle.Size = New System.Drawing.Size(792, 184)
        Me.gdcDetalle.TabIndex = 0
        Me.gdcDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalle})
        '
        'gdvDetalle
        '
        Me.gdvDetalle.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvDetalle.Appearance.FooterPanel.Options.UseFont = True
        Me.gdvDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDETALLE_EMISOR_CHEQUE_ID, Me.colEMISOR_CHEQUE_ID, Me.colCONCEPTO, Me.colMONTO})
        Me.gdvDetalle.GridControl = Me.gdcDetalle
        Me.gdvDetalle.Name = "gdvDetalle"
        Me.gdvDetalle.OptionsView.ShowFooter = True
        Me.gdvDetalle.OptionsView.ShowGroupPanel = False
        '
        'colDETALLE_EMISOR_CHEQUE_ID
        '
        Me.colDETALLE_EMISOR_CHEQUE_ID.Caption = "Emisor Detalle Id"
        Me.colDETALLE_EMISOR_CHEQUE_ID.FieldName = "DETALLE_EMISOR_CHEQUE_ID"
        Me.colDETALLE_EMISOR_CHEQUE_ID.Name = "colDETALLE_EMISOR_CHEQUE_ID"
        Me.colDETALLE_EMISOR_CHEQUE_ID.OptionsColumn.ReadOnly = True
        Me.colDETALLE_EMISOR_CHEQUE_ID.OptionsColumn.ShowInCustomizationForm = False
        '
        'colEMISOR_CHEQUE_ID
        '
        Me.colEMISOR_CHEQUE_ID.Caption = "Emisor ID"
        Me.colEMISOR_CHEQUE_ID.FieldName = "EMISOR_CHEQUE_ID"
        Me.colEMISOR_CHEQUE_ID.Name = "colEMISOR_CHEQUE_ID"
        Me.colEMISOR_CHEQUE_ID.OptionsColumn.ReadOnly = True
        Me.colEMISOR_CHEQUE_ID.OptionsColumn.ShowInCustomizationForm = False
        '
        'colCONCEPTO
        '
        Me.colCONCEPTO.Caption = "Concepto"
        Me.colCONCEPTO.FieldName = "CONCEPTO"
        Me.colCONCEPTO.Name = "colCONCEPTO"
        Me.colCONCEPTO.OptionsColumn.ReadOnly = True
        Me.colCONCEPTO.Visible = True
        Me.colCONCEPTO.VisibleIndex = 0
        '
        'colMONTO
        '
        Me.colMONTO.Caption = "Monto"
        Me.colMONTO.ColumnEdit = Me.txtMonto
        Me.colMONTO.FieldName = "MONTO"
        Me.colMONTO.Name = "colMONTO"
        Me.colMONTO.OptionsColumn.ReadOnly = True
        Me.colMONTO.SummaryItem.DisplayFormat = "Total Cheque: {0:n0}"
        Me.colMONTO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colMONTO.Visible = True
        Me.colMONTO.VisibleIndex = 1
        '
        'txtMonto
        '
        Me.txtMonto.AutoHeight = False
        Me.txtMonto.DisplayFormat.FormatString = "n0"
        Me.txtMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.EditFormat.FormatString = "n0"
        Me.txtMonto.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.Mask.EditMask = "n0"
        Me.txtMonto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMonto.Name = "txtMonto"
        '
        'gpcDetalle
        '
        Me.gpcDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcDetalle.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDetalle.AppearanceCaption.Options.UseFont = True
        Me.gpcDetalle.Controls.Add(Me.txtMontoCheque)
        Me.gpcDetalle.Controls.Add(Me.lblMonto)
        Me.gpcDetalle.Controls.Add(Me.lblConcepto)
        Me.gpcDetalle.Controls.Add(Me.txtConcepto)
        Me.gpcDetalle.Location = New System.Drawing.Point(0, 160)
        Me.gpcDetalle.Name = "gpcDetalle"
        Me.gpcDetalle.Size = New System.Drawing.Size(792, 72)
        Me.gpcDetalle.TabIndex = 3
        Me.gpcDetalle.Text = "Detalle del Cheque"
        '
        'txtMontoCheque
        '
        Me.txtMontoCheque.EnterMoveNextControl = True
        Me.txtMontoCheque.Location = New System.Drawing.Point(528, 32)
        Me.txtMontoCheque.Name = "txtMontoCheque"
        Me.txtMontoCheque.Properties.DisplayFormat.FormatString = "n0"
        Me.txtMontoCheque.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoCheque.Properties.EditFormat.FormatString = "n0"
        Me.txtMontoCheque.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoCheque.Properties.Mask.EditMask = "n0"
        Me.txtMontoCheque.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoCheque.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoCheque.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoCheque.TabIndex = 3
        '
        'lblMonto
        '
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(456, 36)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(64, 16)
        Me.lblMonto.TabIndex = 2
        Me.lblMonto.Text = "Monto"
        Me.lblMonto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblConcepto
        '
        Me.lblConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcepto.Location = New System.Drawing.Point(24, 36)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(64, 16)
        Me.lblConcepto.TabIndex = 0
        Me.lblConcepto.Text = "Concepto"
        Me.lblConcepto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtConcepto
        '
        Me.txtConcepto.EnterMoveNextControl = True
        Me.txtConcepto.Location = New System.Drawing.Point(104, 32)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConcepto.Properties.MaxLength = 200
        Me.txtConcepto.Size = New System.Drawing.Size(328, 20)
        Me.txtConcepto.TabIndex = 1
        '
        'btnNuevoDetalle
        '
        Me.btnNuevoDetalle.Location = New System.Drawing.Point(176, 16)
        Me.btnNuevoDetalle.Name = "btnNuevoDetalle"
        Me.btnNuevoDetalle.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevoDetalle.TabIndex = 0
        Me.btnNuevoDetalle.Text = "Nuevo"
        '
        'btnCancelarDetalle
        '
        Me.btnCancelarDetalle.Location = New System.Drawing.Point(472, 16)
        Me.btnCancelarDetalle.Name = "btnCancelarDetalle"
        Me.btnCancelarDetalle.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarDetalle.TabIndex = 3
        Me.btnCancelarDetalle.Text = "Cancelar"
        '
        'btnGuardarDetalle
        '
        Me.btnGuardarDetalle.Location = New System.Drawing.Point(376, 16)
        Me.btnGuardarDetalle.Name = "btnGuardarDetalle"
        Me.btnGuardarDetalle.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarDetalle.TabIndex = 2
        Me.btnGuardarDetalle.Text = "Guardar"
        '
        'btnEliminarDetalle
        '
        Me.btnEliminarDetalle.Location = New System.Drawing.Point(272, 16)
        Me.btnEliminarDetalle.Name = "btnEliminarDetalle"
        Me.btnEliminarDetalle.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarDetalle.TabIndex = 1
        Me.btnEliminarDetalle.Text = "Eliminar"
        '
        'gpcBotonesDetalle
        '
        Me.gpcBotonesDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcBotonesDetalle.Controls.Add(Me.btnEliminarDetalle)
        Me.gpcBotonesDetalle.Controls.Add(Me.btnNuevoDetalle)
        Me.gpcBotonesDetalle.Controls.Add(Me.btnCancelarDetalle)
        Me.gpcBotonesDetalle.Controls.Add(Me.btnGuardarDetalle)
        Me.gpcBotonesDetalle.Location = New System.Drawing.Point(0, 232)
        Me.gpcBotonesDetalle.Name = "gpcBotonesDetalle"
        Me.gpcBotonesDetalle.ShowCaption = False
        Me.gpcBotonesDetalle.Size = New System.Drawing.Size(792, 56)
        Me.gpcBotonesDetalle.TabIndex = 4
        Me.gpcBotonesDetalle.Text = "GroupControl1"
        '
        'prsCheque
        '
        Me.prsCheque.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcDetalle
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de República" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Departamento RRHH", "Detalle de Cheque", "Fecha Emisiòn:[Date Printed]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Emitido Por:[User Name"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), Nothing)
        Me.PrintableComponentLink1.PrintingSystem = Me.prsCheque
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prsCheque
        '
        'frmChequeRegistro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(800, 476)
        Me.Controls.Add(Me.gpcBotonesDetalle)
        Me.Controls.Add(Me.gpcDetalle)
        Me.Controls.Add(Me.gdcDetalle)
        Me.Controls.Add(Me.gpcBotonesEncabezado)
        Me.Controls.Add(Me.gpcInformacionGeneral)
        Me.Name = "frmChequeRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Cheque"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcBotonesEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBotonesEncabezado.ResumeLayout(False)
        CType(Me.gpcInformacionGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcInformacionGeneral.ResumeLayout(False)
        Me.gpcInformacionGeneral.PerformLayout()
        CType(Me.txtNumeroCheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRazonSocial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroFolio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCheques.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMotivoCheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaCheque.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaCheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDetalle.ResumeLayout(False)
        CType(Me.txtMontoCheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcBotonesDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBotonesDetalle.ResumeLayout(False)
        CType(Me.prsCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim cheque As New cheque
    Dim periodo As Periodo

    Private Sub frmChequeRegistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        periodo = New periodo
        llenarCheques()
        activarControlesEncabezado(False)
        activarControlDetalle(False)
        btnVisualizar.Enabled = False
        btnEliminarCheque.Enabled = False
        btnGuardarCheque.Enabled = False
        btnNuevoDetalle.Enabled = False
        btnEliminarDetalle.Enabled = False
        btnGuardarDetalle.Enabled = False
        btnCancelarDetalle.Enabled = False
    End Sub

    Private Sub llenarCheques()
        repositorio.RefreshDatos("EmisorCheques")
        lueCheques.Properties.Columns.Clear()
        With lueCheques
            With .Properties.Columns
                .Add(New LookUpColumnInfo("EMISOR_CHEQUE_ID", "Nro.Folio", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("NOMBRE_RAZON_SOCIAL", "Razón Solial", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("NUMERO_CHEQUE", "Nro.Cheque", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("FECHA_CHEQUE", "Fecha Cheque", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ESTADO_VIATICO", "Estado Viatico", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueCheques.Properties.DataSource = repositorio.dvEmisorCheques
        lueCheques.Properties.DisplayMember = "EMISOR_CHEQUE_ID"
        lueCheques.Properties.NullText = ""
        lueCheques.Properties.PopupWidth = 350
        lueCheques.Properties.ValueMember = "EMISOR_CHEQUE_ID"
    End Sub

    Private Sub btnNuevoCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoCheque.Click
        botones("Nuevo")
        cheque = New cheque
        gdcDetalle.DataSource = cheque.recuperarDetalleCheque(CInt(txtNumeroFolio.Text))
    End Sub

    Private Sub btnEliminarCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarCheque.Click
        If cheque.datosEncabezado.estadoRegistroCheque <> 1 Then
            MessageBox.Show("Imposible eliminar el cheque número " & txtNumeroCheque.Text & " ya fue emitido", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("¿Seguro que desea eliminar el folio " & txtNumeroFolio.Text & " y todo el detalle?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Try
                    If cheque.EliminaEncabezado Then
                        llenarCheques()
                        inicializaControlesEncabezado()
                        inicializaControlesDetalle()
                        activarControlesEncabezado(False)
                        activarControlDetalle(False)
                        btnVisualizar.Enabled = False
                        btnEliminarCheque.Enabled = False
                        btnGuardarCheque.Enabled = False
                        btnNuevoDetalle.Enabled = False
                        btnEliminarDetalle.Enabled = False
                        btnGuardarDetalle.Enabled = False
                        btnCancelarDetalle.Enabled = False
                        gdcDetalle.DataSource = cheque.recuperarDetalleCheque(CInt(txtNumeroFolio.Text))
                        MessageBox.Show("Registro eliminado correctamente", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MsgBox("Se ha producido un error al intentar eliminar el registro actual." & Chr(13) & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
            End If

    End Sub

    Private Sub btnGuardarCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCheque.Click
        asignacionCampos()
        If cheque.datosEncabezado.chequeID = 0 Then
            Try
                cheque.datosEncabezado.chequeID = cheque.CrearEncabezado()
                txtNumeroFolio.Text = cheque.datosEncabezado.chequeID
                btnNuevoDetalle.Enabled = True
                btnGuardarDetalle.Enabled = False
                btnEliminarDetalle.Enabled = False
                btnVisualizar.Enabled = True
                btnEliminarCheque.Enabled = True
                btnNuevoCheque.Enabled = True
                llenarCheques()
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al crear el encabezado de viático." & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            Try
                cheque.ActualizarEncabezado()
                btnNuevoDetalle.Enabled = True
                btnGuardarDetalle.Enabled = False
                btnEliminarDetalle.Enabled = False
                btnVisualizar.Enabled = True
                btnEliminarCheque.Enabled = True
                btnNuevoCheque.Enabled = True
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al actualizar encabezado de viático." & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub btnCancelarCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarCheque.Click
        botones("Cancelar")
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub activarControlesEncabezado(ByVal habilita As Boolean)
        lueCheques.Enabled = Not habilita
        txtNumeroCheque.Enabled = habilita
        txtNumeroFolio.Visible = habilita
        dedFechaCheque.Enabled = habilita
        txtRazonSocial.Enabled = habilita
        txtMotivoCheque.Enabled = habilita
    End Sub

    Private Sub activarControlDetalle(ByVal habilita As Boolean)
        txtConcepto.Enabled = habilita
        txtMontoCheque.Enabled = habilita
    End Sub

    Private Sub inicializaControlesEncabezado()
        lueCheques.EditValue = -1
        txtNumeroCheque.Text = 0
        txtNumeroFolio.Text = 0
        dedFechaCheque.EditValue = Date.Now.Date
        txtRazonSocial.Text = ""
        txtMotivoCheque.Text = ""
    End Sub

    Private Sub inicializaControlesDetalle()
        txtConcepto.Text = ""
        txtMontoCheque.Text = ""
    End Sub

    Private Sub asignacionCampos()
        cheque.datosEncabezado.fechaCheque = dedFechaCheque.EditValue
        cheque.datosEncabezado.numeroCheque = txtNumeroCheque.EditValue
        cheque.datosEncabezado.motivo = txtMotivoCheque.Text
        cheque.datosEncabezado.razonSocial = txtRazonSocial.Text
        cheque.datosEncabezado.numeroEgreso = txtNumeroCheque.EditValue
        If cheque.datosEncabezado.chequeID = 0 Then
            cheque.datosEncabezado.totalCheque = 0
            cheque.datosEncabezado.estadoRegistroCheque = 1
            cheque.datosEncabezado.periodoId = periodo.ID
            cheque.datosEncabezado.OrganizacionId = Comun.ArgoConfiguracion.OrganizacionID
        End If
    End Sub
    Private Sub asignacionCamposDetalle()
        cheque.datosDetalle.chequeID = cheque.datosEncabezado.chequeID
        cheque.datosDetalle.concepto = txtConcepto.Text
        cheque.datosDetalle.monto = txtMontoCheque.Text
    End Sub
    Private Sub botones(ByVal accion As String)
        Select Case accion
            Case "Nuevo"
                inicializaControlesEncabezado()
                inicializaControlesDetalle()
                lueCheques.Visible = False
                txtNumeroFolio.Visible = True
                txtNumeroFolio.Enabled = False
                txtNumeroCheque.Enabled = False
                dedFechaCheque.Enabled = True
                txtRazonSocial.Enabled = True
                txtMotivoCheque.Enabled = True
                btnEliminarCheque.Enabled = False
                btnVisualizar.Enabled = False
                btnNuevoCheque.Enabled = False
                btnGuardarCheque.Enabled = False
            Case "Cancelar"
                lueCheques.Visible = True
                lueCheques.Enabled = True
                activarControlesEncabezado(False)
                activarControlDetalle(False)
                inicializaControlesEncabezado()
                btnEliminarCheque.Enabled = False
                btnVisualizar.Enabled = False
                btnNuevoCheque.Enabled = True
                btnGuardarCheque.Enabled = False
                btnCancelarCheque.Enabled = True
        End Select

    End Sub

    Private Sub dedFechaCheque_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dedFechaCheque.Leave, txtMotivoCheque.Leave, txtRazonSocial.Leave
        If dedFechaCheque.DateTime.Date >= CType("01-01-2009", Date) And LTrim(txtMotivoCheque.Text).Length > 0 And LTrim(txtRazonSocial.Text).Length > 0 Then
            btnGuardarCheque.Enabled = True
        Else
            btnGuardarCheque.Enabled = False
        End If

    End Sub

    Private Sub lueCheques_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueCheques.EditValueChanged
        If lueCheques.EditValue <> Nothing Then
            cheque = New cheque(CInt(lueCheques.EditValue))
            llenarControlesEncabezado()
            txtNumeroFolio.Text = cheque.datosEncabezado.chequeID
            If cheque.datosEncabezado.estadoRegistroCheque = 1 Then
                dedFechaCheque.Enabled = True
                txtRazonSocial.Enabled = True
                txtMotivoCheque.Enabled = True
                btnEliminarCheque.Enabled = True

                btnVisualizar.Enabled = True
                btnNuevoCheque.Enabled = False
                btnGuardarCheque.Enabled = True

                btnNuevoDetalle.Enabled = True
                btnEliminarDetalle.Enabled = False
                btnGuardarDetalle.Enabled = False
                btnCancelarDetalle.Enabled = True
                inicializaControlesDetalle()
                gdcDetalle.Enabled = True
            Else
                gdcDetalle.Enabled = False
                btnEliminarCheque.Enabled = False
                btnVisualizar.Enabled = True
                btnNuevoCheque.Enabled = False
                btnGuardarCheque.Enabled = False
                btnNuevoDetalle.Enabled = False
                btnEliminarDetalle.Enabled = False
                btnGuardarDetalle.Enabled = False
                btnCancelarDetalle.Enabled = False
            End If
        End If
    End Sub

    Private Sub llenarControlesEncabezado()
        dedFechaCheque.EditValue = cheque.datosEncabezado.fechaCheque
        txtNumeroCheque.EditValue = cheque.datosEncabezado.numeroCheque
        txtMotivoCheque.Text = cheque.datosEncabezado.motivo
        txtRazonSocial.Text = cheque.datosEncabezado.razonSocial
        txtNumeroCheque.EditValue = cheque.datosEncabezado.numeroEgreso
        gdcDetalle.DataSource = cheque.recuperarDetalleCheque(cheque.datosEncabezado.chequeID)
    End Sub

    Private Sub btnNuevoDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoDetalle.Click
        activarControlDetalle(True)
        cheque.datosDetalle.detalleChequeID = 0
        btnNuevoDetalle.Enabled = False
        btnEliminarDetalle.Enabled = False
        btnGuardarDetalle.Enabled = False
        btnCancelarDetalle.Enabled = True
        txtConcepto.Focus()
    End Sub

    Private Sub btnEliminarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarDetalle.Click
        If MessageBox.Show("¿Seguro que desea eliminar el registro del detalle actual?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Try
                If cheque.EliminaDetalle Then
                    inicializaControlesDetalle()
                    gdcDetalle.DataSource = cheque.recuperarDetalleCheque(CInt(txtNumeroFolio.Text))
                    totalCheque()
                    btnNuevoDetalle.Enabled = True
                    btnGuardarDetalle.Enabled = False
                    btnEliminarDetalle.Enabled = False
                    activarControlDetalle(False)
                    MessageBox.Show("Registro eliminado correctamente", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MsgBox("Se ha producido un error al intentar eliminar el registro actual." & Chr(13) & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If

    End Sub

    Private Sub btnGuardarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarDetalle.Click
        asignacionCamposDetalle()
        If cheque.datosDetalle.detalleChequeID = 0 Then
            Try
                cheque.datosDetalle.detalleChequeID = cheque.CrearDetalle()
                gdcDetalle.DataSource = cheque.recuperarDetalleCheque(CInt(txtNumeroFolio.Text))
                totalCheque()
                btnNuevoDetalle.Enabled = True
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al crear el encabezado" & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            Try
                cheque.ActualizarDetalle()
                gdcDetalle.DataSource = cheque.recuperarDetalleCheque(CInt(txtNumeroFolio.Text))
                totalCheque()
                btnNuevoDetalle.Enabled = True
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al actualizar encabezado" & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub btnCancelarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarDetalle.Click
        inicializaControlesDetalle()
        btnNuevoDetalle.Enabled = True
        btnGuardarDetalle.Enabled = False
        btnEliminarDetalle.Enabled = False
        activarControlDetalle(False)
    End Sub

    Private Sub txtConcepto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConcepto.Leave, txtMontoCheque.Leave
        If LTrim(txtConcepto.Text).Length > 0 And txtMontoCheque.Text > 0 Then
            btnGuardarDetalle.Enabled = True
        End If
    End Sub

    Private Sub gdvDetalle_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gdvDetalle.DoubleClick
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        cheque.datosDetalle.detalleChequeID = view.GetRowCellValue(view.FocusedRowHandle, "DETALLE_EMISOR_CHEQUE_ID")
        txtConcepto.Text = view.GetRowCellValue(view.FocusedRowHandle, "CONCEPTO")
        txtMontoCheque.Text = view.GetRowCellValue(view.FocusedRowHandle, "MONTO")
        btnNuevoDetalle.Enabled = True
        btnGuardarDetalle.Enabled = True
        btnEliminarDetalle.Enabled = True
        activarControlDetalle(True)
    End Sub
    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "Nro.Folio: " & txtNumeroFolio.Text & " Numero Cheque: " & dedFechaCheque.Text.ToString & Chr(13) & " Nombre o Razón Social: " & txtRazonSocial.Text & " Motivo: " & txtMotivoCheque.Text
        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)
    End Sub

    Private Sub txtRazonSocial_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRazonSocial.Validated
        btnGuardarCheque.Focus()
    End Sub

    Private Sub txtMontoCheque_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMontoCheque.Validated
        btnGuardarDetalle.Focus()
    End Sub

    Private Sub totalCheque()
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetalle
        Dim total As Integer = 0
        Try
            For i As Integer = 0 To (gdvDetalle.RowCount - 1)
                total = total + view.GetRowCellValue(i, "MONTO")
            Next
            cheque.datosEncabezado.totalCheque = total
            cheque.ActualizarEncabezado()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al actualizar encabezado" & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
End Class
