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
Imports DevExpress.XtraPrinting

Public Class frmGeneraArchivoPlanoBancoRemuneracion
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
    Friend WithEvents lblTipoProceso As System.Windows.Forms.Label
    Friend WithEvents rdgTipoProceso As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtEstadoPeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents gpcBotones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gdcSueldosLiquidos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents fieldRUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldEMAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCODIGO_BANCO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldFORMA_PAGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCUENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldMONTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMonto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGeneraArchivoPlano As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents gdcArchivoPlano As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents fieldCOLUMNA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldNOMBRE_CALIDAD_JURIDICA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldNOMBRE_TIPO_CUENTA_BANCO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldNOMBRE_BANCO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents prsRemunLiquida As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGeneraArchivoPlanoBancoRemuneracion))
        Me.gpcEncabezado = New DevExpress.XtraEditors.GroupControl()
        Me.lblTipoProceso = New System.Windows.Forms.Label()
        Me.rdgTipoProceso = New DevExpress.XtraEditors.RadioGroup()
        Me.txtEstadoPeriodo = New DevExpress.XtraEditors.TextEdit()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.gpcBotones = New DevExpress.XtraEditors.GroupControl()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGeneraArchivoPlano = New DevExpress.XtraEditors.SimpleButton()
        Me.gdcSueldosLiquidos = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.fieldNOMBRE_CALIDAD_JURIDICA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldRUT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldEMAIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldCODIGO_BANCO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldNOMBRE_BANCO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldFORMA_PAGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldNOMBRE_TIPO_CUENTA_BANCO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldCUENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldMONTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMonto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.gdcArchivoPlano = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.fieldCOLUMNA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.prsRemunLiquida = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcEncabezado.SuspendLayout()
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstadoPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBotones.SuspendLayout()
        CType(Me.gdcSueldosLiquidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcArchivoPlano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prsRemunLiquida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcEncabezado
        '
        Me.gpcEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcEncabezado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcEncabezado.AppearanceCaption.Options.UseFont = True
        Me.gpcEncabezado.Controls.Add(Me.lblTipoProceso)
        Me.gpcEncabezado.Controls.Add(Me.rdgTipoProceso)
        Me.gpcEncabezado.Controls.Add(Me.txtEstadoPeriodo)
        Me.gpcEncabezado.Controls.Add(Me.luePeriodo)
        Me.gpcEncabezado.Controls.Add(Me.lblPeriodo)
        Me.gpcEncabezado.Location = New System.Drawing.Point(8, 8)
        Me.gpcEncabezado.Name = "gpcEncabezado"
        Me.gpcEncabezado.Size = New System.Drawing.Size(720, 120)
        Me.gpcEncabezado.TabIndex = 1
        Me.gpcEncabezado.Text = "Período"
        '
        'lblTipoProceso
        '
        Me.lblTipoProceso.Location = New System.Drawing.Point(32, 72)
        Me.lblTipoProceso.Name = "lblTipoProceso"
        Me.lblTipoProceso.Size = New System.Drawing.Size(72, 16)
        Me.lblTipoProceso.TabIndex = 9
        Me.lblTipoProceso.Text = "Tipo Proceso"
        Me.lblTipoProceso.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'rdgTipoProceso
        '
        Me.rdgTipoProceso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdgTipoProceso.EditValue = 0
        Me.rdgTipoProceso.Location = New System.Drawing.Point(120, 56)
        Me.rdgTipoProceso.Name = "rdgTipoProceso"
        Me.rdgTipoProceso.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Planta y Contrata"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Honorarios"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Suplementaria")})
        Me.rdgTipoProceso.Size = New System.Drawing.Size(440, 32)
        Me.rdgTipoProceso.TabIndex = 2
        '
        'txtEstadoPeriodo
        '
        Me.txtEstadoPeriodo.Enabled = False
        Me.txtEstadoPeriodo.Location = New System.Drawing.Point(296, 32)
        Me.txtEstadoPeriodo.Name = "txtEstadoPeriodo"
        Me.txtEstadoPeriodo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtEstadoPeriodo.Properties.Appearance.Options.UseFont = True
        Me.txtEstadoPeriodo.Size = New System.Drawing.Size(176, 20)
        Me.txtEstadoPeriodo.TabIndex = 4
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(120, 32)
        Me.luePeriodo.Name = "luePeriodo"
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(160, 20)
        Me.luePeriodo.TabIndex = 0
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(56, 36)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 16)
        Me.lblPeriodo.TabIndex = 0
        Me.lblPeriodo.Text = "Período"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gpcBotones
        '
        Me.gpcBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcBotones.Controls.Add(Me.btnImprimir)
        Me.gpcBotones.Controls.Add(Me.btnGeneraArchivoPlano)
        Me.gpcBotones.Location = New System.Drawing.Point(8, 128)
        Me.gpcBotones.Name = "gpcBotones"
        Me.gpcBotones.ShowCaption = False
        Me.gpcBotones.Size = New System.Drawing.Size(720, 40)
        Me.gpcBotones.TabIndex = 2
        Me.gpcBotones.Text = "GroupControl1"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(360, 8)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(96, 23)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnGeneraArchivoPlano
        '
        Me.btnGeneraArchivoPlano.Location = New System.Drawing.Point(192, 8)
        Me.btnGeneraArchivoPlano.Name = "btnGeneraArchivoPlano"
        Me.btnGeneraArchivoPlano.Size = New System.Drawing.Size(136, 23)
        Me.btnGeneraArchivoPlano.TabIndex = 0
        Me.btnGeneraArchivoPlano.Text = "Generar Archivo Plano"
        '
        'gdcSueldosLiquidos
        '
        Me.gdcSueldosLiquidos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcSueldosLiquidos.Location = New System.Drawing.Point(8, 168)
        Me.gdcSueldosLiquidos.MainView = Me.GridView2
        Me.gdcSueldosLiquidos.Name = "gdcSueldosLiquidos"
        Me.gdcSueldosLiquidos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtMonto})
        Me.gdcSueldosLiquidos.Size = New System.Drawing.Size(720, 272)
        Me.gdcSueldosLiquidos.TabIndex = 3
        Me.gdcSueldosLiquidos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView1})
        '
        'GridView2
        '
        Me.GridView2.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.fieldNOMBRE_CALIDAD_JURIDICA, Me.fieldRUT, Me.fieldNOMBRE, Me.fieldEMAIL, Me.fieldCODIGO_BANCO, Me.fieldNOMBRE_BANCO, Me.fieldFORMA_PAGO, Me.fieldNOMBRE_TIPO_CUENTA_BANCO, Me.fieldCUENTA, Me.fieldMONTO})
        Me.GridView2.GridControl = Me.gdcSueldosLiquidos
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'fieldNOMBRE_CALIDAD_JURIDICA
        '
        Me.fieldNOMBRE_CALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.fieldNOMBRE_CALIDAD_JURIDICA.FieldName = "NOMBRE_CALIDAD_JURIDICA"
        Me.fieldNOMBRE_CALIDAD_JURIDICA.Name = "fieldNOMBRE_CALIDAD_JURIDICA"
        Me.fieldNOMBRE_CALIDAD_JURIDICA.OptionsColumn.ReadOnly = True
        Me.fieldNOMBRE_CALIDAD_JURIDICA.Visible = True
        Me.fieldNOMBRE_CALIDAD_JURIDICA.VisibleIndex = 0
        Me.fieldNOMBRE_CALIDAD_JURIDICA.Width = 131
        '
        'fieldRUT
        '
        Me.fieldRUT.Caption = "Rut"
        Me.fieldRUT.FieldName = "RUT"
        Me.fieldRUT.Name = "fieldRUT"
        Me.fieldRUT.OptionsColumn.ReadOnly = True
        Me.fieldRUT.Visible = True
        Me.fieldRUT.VisibleIndex = 1
        Me.fieldRUT.Width = 99
        '
        'fieldNOMBRE
        '
        Me.fieldNOMBRE.Caption = "Nombre Empleado"
        Me.fieldNOMBRE.FieldName = "NOMBRE"
        Me.fieldNOMBRE.Name = "fieldNOMBRE"
        Me.fieldNOMBRE.OptionsColumn.ReadOnly = True
        Me.fieldNOMBRE.Visible = True
        Me.fieldNOMBRE.VisibleIndex = 2
        Me.fieldNOMBRE.Width = 298
        '
        'fieldEMAIL
        '
        Me.fieldEMAIL.Caption = "eMail"
        Me.fieldEMAIL.FieldName = "EMAIL"
        Me.fieldEMAIL.Name = "fieldEMAIL"
        Me.fieldEMAIL.OptionsColumn.ReadOnly = True
        Me.fieldEMAIL.Width = 137
        '
        'fieldCODIGO_BANCO
        '
        Me.fieldCODIGO_BANCO.Caption = "Código Banco"
        Me.fieldCODIGO_BANCO.FieldName = "CODIGO_BANCO"
        Me.fieldCODIGO_BANCO.Name = "fieldCODIGO_BANCO"
        Me.fieldCODIGO_BANCO.OptionsColumn.ReadOnly = True
        Me.fieldCODIGO_BANCO.Visible = True
        Me.fieldCODIGO_BANCO.VisibleIndex = 3
        Me.fieldCODIGO_BANCO.Width = 80
        '
        'fieldNOMBRE_BANCO
        '
        Me.fieldNOMBRE_BANCO.Caption = "Banco"
        Me.fieldNOMBRE_BANCO.FieldName = "NOMBRE_BANCO"
        Me.fieldNOMBRE_BANCO.Name = "fieldNOMBRE_BANCO"
        Me.fieldNOMBRE_BANCO.OptionsColumn.ReadOnly = True
        Me.fieldNOMBRE_BANCO.Visible = True
        Me.fieldNOMBRE_BANCO.VisibleIndex = 4
        Me.fieldNOMBRE_BANCO.Width = 143
        '
        'fieldFORMA_PAGO
        '
        Me.fieldFORMA_PAGO.Caption = "Forma de Pago"
        Me.fieldFORMA_PAGO.FieldName = "FORMA_PAGO"
        Me.fieldFORMA_PAGO.Name = "fieldFORMA_PAGO"
        Me.fieldFORMA_PAGO.OptionsColumn.ReadOnly = True
        Me.fieldFORMA_PAGO.Visible = True
        Me.fieldFORMA_PAGO.VisibleIndex = 5
        Me.fieldFORMA_PAGO.Width = 155
        '
        'fieldNOMBRE_TIPO_CUENTA_BANCO
        '
        Me.fieldNOMBRE_TIPO_CUENTA_BANCO.Caption = "Tipo Cuenta"
        Me.fieldNOMBRE_TIPO_CUENTA_BANCO.FieldName = "NOMBRE_TIPO_CUENTA_BANCO"
        Me.fieldNOMBRE_TIPO_CUENTA_BANCO.Name = "fieldNOMBRE_TIPO_CUENTA_BANCO"
        Me.fieldNOMBRE_TIPO_CUENTA_BANCO.OptionsColumn.ReadOnly = True
        Me.fieldNOMBRE_TIPO_CUENTA_BANCO.Visible = True
        Me.fieldNOMBRE_TIPO_CUENTA_BANCO.VisibleIndex = 6
        Me.fieldNOMBRE_TIPO_CUENTA_BANCO.Width = 169
        '
        'fieldCUENTA
        '
        Me.fieldCUENTA.Caption = "Cuenta Banco"
        Me.fieldCUENTA.FieldName = "CUENTA"
        Me.fieldCUENTA.Name = "fieldCUENTA"
        Me.fieldCUENTA.OptionsColumn.ReadOnly = True
        Me.fieldCUENTA.Visible = True
        Me.fieldCUENTA.VisibleIndex = 7
        Me.fieldCUENTA.Width = 132
        '
        'fieldMONTO
        '
        Me.fieldMONTO.Caption = "Monto"
        Me.fieldMONTO.ColumnEdit = Me.txtMonto
        Me.fieldMONTO.FieldName = "MONTO"
        Me.fieldMONTO.Name = "fieldMONTO"
        Me.fieldMONTO.OptionsColumn.ReadOnly = True
        Me.fieldMONTO.SummaryItem.DisplayFormat = "Total General: {0:n0}"
        Me.fieldMONTO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.fieldMONTO.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.fieldMONTO.Visible = True
        Me.fieldMONTO.VisibleIndex = 8
        Me.fieldMONTO.Width = 265
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
        Me.txtMonto.Mask.UseMaskAsDisplayFormat = True
        Me.txtMonto.Name = "txtMonto"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcSueldosLiquidos
        Me.GridView1.Name = "GridView1"
        '
        'gdcArchivoPlano
        '
        Me.gdcArchivoPlano.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcArchivoPlano.Location = New System.Drawing.Point(8, 440)
        Me.gdcArchivoPlano.MainView = Me.GridView4
        Me.gdcArchivoPlano.Name = "gdcArchivoPlano"
        Me.gdcArchivoPlano.Size = New System.Drawing.Size(720, 216)
        Me.gdcArchivoPlano.TabIndex = 4
        Me.gdcArchivoPlano.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4, Me.GridView3})
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.fieldCOLUMNA})
        Me.GridView4.GridControl = Me.gdcArchivoPlano
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsCustomization.AllowSort = False
        Me.GridView4.OptionsPrint.PrintHeader = False
        Me.GridView4.OptionsView.ShowColumnHeaders = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'fieldCOLUMNA
        '
        Me.fieldCOLUMNA.AppearanceCell.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fieldCOLUMNA.AppearanceCell.Options.UseFont = True
        Me.fieldCOLUMNA.FieldName = "COLUMNA"
        Me.fieldCOLUMNA.Name = "fieldCOLUMNA"
        Me.fieldCOLUMNA.OptionsColumn.ReadOnly = True
        Me.fieldCOLUMNA.Visible = True
        Me.fieldCOLUMNA.VisibleIndex = 0
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.gdcArchivoPlano
        Me.GridView3.Name = "GridView3"
        '
        'prsRemunLiquida
        '
        Me.prsRemunLiquida.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcSueldosLiquidos
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(20, 20, 100, 100)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de la República", "Remuneraciones Líquidas", "Fecha Emisión:[Date Printed]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Emitido por:[User Name]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"", "", "Página:[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.prsRemunLiquida
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prsRemunLiquida
        '
        'frmGeneraArchivoPlanoBancoRemuneracion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(736, 660)
        Me.Controls.Add(Me.gdcSueldosLiquidos)
        Me.Controls.Add(Me.gpcBotones)
        Me.Controls.Add(Me.gpcEncabezado)
        Me.Controls.Add(Me.gdcArchivoPlano)
        Me.Name = "frmGeneraArchivoPlanoBancoRemuneracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Genera Archivo Plano Banco"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcEncabezado.ResumeLayout(False)
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstadoPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBotones.ResumeLayout(False)
        CType(Me.gdcSueldosLiquidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcArchivoPlano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prsRemunLiquida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private empleado As empleado
    Private estadoPeriodo As Boolean
    Private Periodo As Periodo

    Private Sub frmGeneraArchivoPlanoBancoRemuneracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empleado = New empleado
        llenarPeriodos()
        btnImprimir.Enabled = False
        btnGeneraArchivoPlano.Enabled = False
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

    Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
        Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
        refrescarDetalle()
        If Not IsNothing(row) Then
            Periodo = New Periodo(CType(row("PERIODO_ID"), Integer))
            estadoPeriodo = Periodo.estadoPeriodo
            'Si el estado del periodo es 0 (No Activo) deshabilita la grilla
            btnImprimir.Enabled = True
            If Not estadoPeriodo Then
                btnGeneraArchivoPlano.Enabled = False
                txtEstadoPeriodo.Text = "INACTIVO"
            Else
                btnGeneraArchivoPlano.Enabled = True
                txtEstadoPeriodo.Text = "ACTIVO"
            End If
        End If
    End Sub
    Private Sub refrescarDetalle()
        If luePeriodo.EditValue <> Nothing Then
            gdcSueldosLiquidos.DataSource = empleado.dvRemuneracionLiquida(CType(luePeriodo.EditValue, Integer), rdgTipoProceso.EditValue)
            gdcArchivoPlano.DataSource = empleado.dvArchivoPlanoRemuneracionLiquida(CType(luePeriodo.EditValue, Integer), rdgTipoProceso.EditValue)
        End If
    End Sub

    Private Sub rdgTipoProceso_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdgTipoProceso.EditValueChanged
        refrescarDetalle()
    End Sub

    Private Sub btnGeneraArchivoPlano_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneraArchivoPlano.Click
        Dim rutaPlanillaExcel As String
        If rdgTipoProceso.SelectedIndex = 0 Then
            rutaPlanillaExcel = "Remuneración Liquida Proceso Normal Planta y Contrata " & Periodo.anoMes
        Else
            If rdgTipoProceso.SelectedIndex = 1 Then
                rutaPlanillaExcel = "Remuneración Liquida Honorarios " & Periodo.anoMes
            Else
                rutaPlanillaExcel = "Remuneración Liquida Proceso Suplementaria Planta y Contrata " & Periodo.anoMes
            End If
        End If
        Try
            Dim FileName As String = rutaPlanillaExcel & ".txt"
            With SaveFileDialog1
                .Filter = "Archivo de Texto (*.txt)|*.txt"
                .DefaultExt = "txt"
                .FileName = rutaPlanillaExcel & ".txt"
                rutaPlanillaExcel = SaveFileDialog1.FileName
                If .ShowDialog(Me) = DialogResult.OK Then
                    FileName = .FileName
                    If rutaPlanillaExcel <> "" Then
                        gdcArchivoPlano.ExportToText(FileName)
                    End If
                End If
            End With
            If rutaPlanillaExcel <> "" Then
                System.Windows.Forms.MessageBox.Show("Se han generado archivo plano para el banco.", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
 
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
    End Sub
    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim subtitulo As String
        If rdgTipoProceso.SelectedIndex = 0 Then
            subtitulo = " (Remuneración Liquida Planta y Contrata)"
        Else
            If rdgTipoProceso.SelectedIndex = 1 Then
                subtitulo = " (Remuneración Liquida Honorarios)"
            Else
                subtitulo = " (Remuneración Liquida Planta, Contrata y Honorarios)"
            End If
        End If
        Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(luePeriodo, DevExpress.XtraEditors.LookUpEdit)
        Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
        Dim reportHeader As String = "PERIODO : " & row("DESCRIPCION_PERIODO") & subtitulo
        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)
    End Sub
End Class
