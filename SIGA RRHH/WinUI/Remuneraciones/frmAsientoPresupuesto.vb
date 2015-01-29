Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.DataAccess
Imports cl.presidencia.Seguridad
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Windows.Forms
Imports System.Drawing
Imports System

Public Class frmAsientoPresupuesto
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
    Friend WithEvents gpcPeriodo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdgTipoProceso As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents btnGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTipoProceso As System.Windows.Forms.Label
    Friend WithEvents txtEstadoPeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents pgcDetalleAsientoPresup As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents colAÑO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colCALIDAD_JURIDICA_DESC As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colCUENTA_PRESUPUESTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents btnExportarExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents colCENTRO_COSTO_CONTAB_DESC As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents prsAsientoPresup As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCENTRO_COSTO_ALIAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents txtTicketDexon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTicketDexon As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsientoPresupuesto))
        Me.gpcPeriodo = New DevExpress.XtraEditors.GroupControl()
        Me.lblTicketDexon = New System.Windows.Forms.Label()
        Me.txtTicketDexon = New DevExpress.XtraEditors.TextEdit()
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.rdgTipoProceso = New DevExpress.XtraEditors.RadioGroup()
        Me.btnExportarExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTipoProceso = New System.Windows.Forms.Label()
        Me.txtEstadoPeriodo = New DevExpress.XtraEditors.TextEdit()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.pgcDetalleAsientoPresup = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.colAÑO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colMES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colCALIDAD_JURIDICA_DESC = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colCENTRO_COSTO_ALIAS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colCENTRO_COSTO_CONTAB_DESC = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colCUENTA_PRESUPUESTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colMONTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.prsAsientoPresup = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.gpcPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcPeriodo.SuspendLayout()
        CType(Me.txtTicketDexon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstadoPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgcDetalleAsientoPresup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prsAsientoPresup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcPeriodo
        '
        Me.gpcPeriodo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcPeriodo.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcPeriodo.AppearanceCaption.Options.UseFont = True
        Me.gpcPeriodo.Controls.Add(Me.lblTicketDexon)
        Me.gpcPeriodo.Controls.Add(Me.txtTicketDexon)
        Me.gpcPeriodo.Controls.Add(Me.btnVisualizar)
        Me.gpcPeriodo.Controls.Add(Me.rdgTipoProceso)
        Me.gpcPeriodo.Controls.Add(Me.btnExportarExcel)
        Me.gpcPeriodo.Controls.Add(Me.btnGenerar)
        Me.gpcPeriodo.Controls.Add(Me.lblTipoProceso)
        Me.gpcPeriodo.Controls.Add(Me.txtEstadoPeriodo)
        Me.gpcPeriodo.Controls.Add(Me.luePeriodo)
        Me.gpcPeriodo.Controls.Add(Me.lblPeriodo)
        Me.gpcPeriodo.Location = New System.Drawing.Point(0, 0)
        Me.gpcPeriodo.Name = "gpcPeriodo"
        Me.gpcPeriodo.Size = New System.Drawing.Size(720, 232)
        Me.gpcPeriodo.TabIndex = 1
        Me.gpcPeriodo.Text = "Periodo"
        '
        'lblTicketDexon
        '
        Me.lblTicketDexon.Location = New System.Drawing.Point(72, 148)
        Me.lblTicketDexon.Name = "lblTicketDexon"
        Me.lblTicketDexon.Size = New System.Drawing.Size(96, 16)
        Me.lblTicketDexon.TabIndex = 12
        Me.lblTicketDexon.Text = "Nro.Ticket Dexon"
        Me.lblTicketDexon.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTicketDexon
        '
        Me.txtTicketDexon.Location = New System.Drawing.Point(176, 144)
        Me.txtTicketDexon.Name = "txtTicketDexon"
        Me.txtTicketDexon.Size = New System.Drawing.Size(232, 20)
        Me.txtTicketDexon.TabIndex = 11
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(416, 192)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(168, 23)
        Me.btnVisualizar.TabIndex = 10
        Me.btnVisualizar.Text = "&Visualizar"
        '
        'rdgTipoProceso
        '
        Me.rdgTipoProceso.EditValue = "N"
        Me.rdgTipoProceso.Location = New System.Drawing.Point(176, 72)
        Me.rdgTipoProceso.Name = "rdgTipoProceso"
        Me.rdgTipoProceso.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("N", "Planta y Contrata"), New DevExpress.XtraEditors.Controls.RadioGroupItem("V", "Viáticos"), New DevExpress.XtraEditors.Controls.RadioGroupItem("H", "Honorarios")})
        Me.rdgTipoProceso.Size = New System.Drawing.Size(232, 64)
        Me.rdgTipoProceso.TabIndex = 1
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Location = New System.Drawing.Point(232, 192)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(168, 23)
        Me.btnExportarExcel.TabIndex = 5
        Me.btnExportarExcel.Text = "&Exportar Excel"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(48, 192)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(168, 23)
        Me.btnGenerar.TabIndex = 4
        Me.btnGenerar.Text = "&Generar Archivo Definitivo"
        '
        'lblTipoProceso
        '
        Me.lblTipoProceso.Location = New System.Drawing.Point(96, 72)
        Me.lblTipoProceso.Name = "lblTipoProceso"
        Me.lblTipoProceso.Size = New System.Drawing.Size(72, 16)
        Me.lblTipoProceso.TabIndex = 9
        Me.lblTipoProceso.Text = "Tipo Proceso"
        Me.lblTipoProceso.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtEstadoPeriodo
        '
        Me.txtEstadoPeriodo.Enabled = False
        Me.txtEstadoPeriodo.Location = New System.Drawing.Point(296, 40)
        Me.txtEstadoPeriodo.Name = "txtEstadoPeriodo"
        Me.txtEstadoPeriodo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtEstadoPeriodo.Properties.Appearance.Options.UseFont = True
        Me.txtEstadoPeriodo.Size = New System.Drawing.Size(112, 20)
        Me.txtEstadoPeriodo.TabIndex = 7
        '
        'luePeriodo
        '
        Me.luePeriodo.EnterMoveNextControl = True
        Me.luePeriodo.Location = New System.Drawing.Point(176, 40)
        Me.luePeriodo.Name = "luePeriodo"
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(112, 20)
        Me.luePeriodo.TabIndex = 0
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(112, 44)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 16)
        Me.lblPeriodo.TabIndex = 5
        Me.lblPeriodo.Text = "Período"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pgcDetalleAsientoPresup
        '
        Me.pgcDetalleAsientoPresup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgcDetalleAsientoPresup.AppearancePrint.FieldHeader.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(4, Byte), True)
        Me.pgcDetalleAsientoPresup.AppearancePrint.FieldHeader.Options.UseFont = True
        Me.pgcDetalleAsientoPresup.Cursor = System.Windows.Forms.Cursors.Default
        Me.pgcDetalleAsientoPresup.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.colAÑO, Me.colMES, Me.colCALIDAD_JURIDICA_DESC, Me.colCENTRO_COSTO_ALIAS, Me.colCENTRO_COSTO_CONTAB_DESC, Me.colCUENTA_PRESUPUESTO, Me.colMONTO})
        Me.pgcDetalleAsientoPresup.Location = New System.Drawing.Point(0, 232)
        Me.pgcDetalleAsientoPresup.Name = "pgcDetalleAsientoPresup"
        Me.pgcDetalleAsientoPresup.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.pgcDetalleAsientoPresup.OptionsPrint.UsePrintAppearance = True
        Me.pgcDetalleAsientoPresup.OptionsView.ShowColumnHeaders = False
        Me.pgcDetalleAsientoPresup.OptionsView.ShowDataHeaders = False
        Me.pgcDetalleAsientoPresup.OptionsView.ShowFilterHeaders = False
        Me.pgcDetalleAsientoPresup.Size = New System.Drawing.Size(720, 256)
        Me.pgcDetalleAsientoPresup.TabIndex = 2
        '
        'colAÑO
        '
        Me.colAÑO.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.colAÑO.Appearance.Header.Options.UseFont = True
        Me.colAÑO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colAÑO.AreaIndex = 0
        Me.colAÑO.Caption = "Año"
        Me.colAÑO.FieldName = "ANO"
        Me.colAÑO.Name = "colAÑO"
        Me.colAÑO.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[False]
        Me.colAÑO.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colAÑO.Width = 50
        '
        'colMES
        '
        Me.colMES.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMES.Appearance.Header.Options.UseFont = True
        Me.colMES.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colMES.AreaIndex = 1
        Me.colMES.Caption = "Mes"
        Me.colMES.FieldName = "MES"
        Me.colMES.Name = "colMES"
        Me.colMES.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMES.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMES.Width = 50
        '
        'colCALIDAD_JURIDICA_DESC
        '
        Me.colCALIDAD_JURIDICA_DESC.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCALIDAD_JURIDICA_DESC.Appearance.Header.Options.UseFont = True
        Me.colCALIDAD_JURIDICA_DESC.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colCALIDAD_JURIDICA_DESC.AreaIndex = 2
        Me.colCALIDAD_JURIDICA_DESC.Caption = "Cal.Jurídica"
        Me.colCALIDAD_JURIDICA_DESC.FieldName = "CALIDAD_JURIDICA_DESC"
        Me.colCALIDAD_JURIDICA_DESC.Name = "colCALIDAD_JURIDICA_DESC"
        Me.colCALIDAD_JURIDICA_DESC.Width = 200
        '
        'colCENTRO_COSTO_ALIAS
        '
        Me.colCENTRO_COSTO_ALIAS.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCENTRO_COSTO_ALIAS.Appearance.Header.Options.UseFont = True
        Me.colCENTRO_COSTO_ALIAS.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colCENTRO_COSTO_ALIAS.AreaIndex = 3
        Me.colCENTRO_COSTO_ALIAS.Caption = "Codigo"
        Me.colCENTRO_COSTO_ALIAS.FieldName = "CENTRO_COSTO_ALIAS"
        Me.colCENTRO_COSTO_ALIAS.Name = "colCENTRO_COSTO_ALIAS"
        Me.colCENTRO_COSTO_ALIAS.Width = 75
        '
        'colCENTRO_COSTO_CONTAB_DESC
        '
        Me.colCENTRO_COSTO_CONTAB_DESC.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCENTRO_COSTO_CONTAB_DESC.Appearance.Header.Options.UseFont = True
        Me.colCENTRO_COSTO_CONTAB_DESC.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colCENTRO_COSTO_CONTAB_DESC.AreaIndex = 4
        Me.colCENTRO_COSTO_CONTAB_DESC.Caption = "Centro Costo"
        Me.colCENTRO_COSTO_CONTAB_DESC.FieldName = "CENTRO_COSTO_CONTAB_DESC"
        Me.colCENTRO_COSTO_CONTAB_DESC.Name = "colCENTRO_COSTO_CONTAB_DESC"
        Me.colCENTRO_COSTO_CONTAB_DESC.Width = 500
        '
        'colCUENTA_PRESUPUESTO
        '
        Me.colCUENTA_PRESUPUESTO.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCUENTA_PRESUPUESTO.Appearance.Header.Options.UseFont = True
        Me.colCUENTA_PRESUPUESTO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colCUENTA_PRESUPUESTO.AreaIndex = 5
        Me.colCUENTA_PRESUPUESTO.Caption = "Cuenta"
        Me.colCUENTA_PRESUPUESTO.FieldName = "CUENTA_PRESUPUESTO"
        Me.colCUENTA_PRESUPUESTO.Name = "colCUENTA_PRESUPUESTO"
        '
        'colMONTO
        '
        Me.colMONTO.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMONTO.Appearance.Header.Options.UseFont = True
        Me.colMONTO.Appearance.ValueTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMONTO.Appearance.ValueTotal.ForeColor = System.Drawing.Color.Red
        Me.colMONTO.Appearance.ValueTotal.Options.UseFont = True
        Me.colMONTO.Appearance.ValueTotal.Options.UseForeColor = True
        Me.colMONTO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO.AreaIndex = 0
        Me.colMONTO.Caption = "Monto"
        Me.colMONTO.CellFormat.FormatString = "n0"
        Me.colMONTO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO.FieldName = "MONTO"
        Me.colMONTO.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO.Name = "colMONTO"
        Me.colMONTO.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMONTO.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMONTO.TotalCellFormat.FormatString = "n0"
        Me.colMONTO.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO.TotalValueFormat.FormatString = "n0"
        Me.colMONTO.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO.ValueFormat.FormatString = "n0"
        Me.colMONTO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO.Width = 70
        '
        'prsAsientoPresup
        '
        Me.prsAsientoPresup.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.pgcDetalleAsientoPresup
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 100, 100)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Departamento RRHH", "ASIENTO PRESUPUESTO", "Fecha Emisión:[Date Printed]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Página:[Page # of Pages #]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Emitido por:[User Name]" & _
                    ""}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), Nothing)
        Me.PrintableComponentLink1.PrintingSystem = Me.prsAsientoPresup
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prsAsientoPresup
        '
        'frmAsientoPresupuesto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 490)
        Me.Controls.Add(Me.pgcDetalleAsientoPresup)
        Me.Controls.Add(Me.gpcPeriodo)
        Me.Name = "frmAsientoPresupuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAsientoPresupuesto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcPeriodo.ResumeLayout(False)
        CType(Me.txtTicketDexon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstadoPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgcDetalleAsientoPresup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prsAsientoPresup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private asientoContableID As Integer
    Private estadoPeriodo As Boolean
    Private periodo As Periodo

    Private Sub frmAsientoPresupuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarPeriodos()
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
        luePeriodo.EditValue = -1
    End Sub

    Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged, rdgTipoProceso.EditValueChanged
        If luePeriodo.EditValue < 0 Or luePeriodo.EditValue = Nothing Then
            Exit Sub
        End If
        periodo = New periodo(CType(luePeriodo.EditValue, Integer))
        periodo.estadoPeriodo = True
        RefrescarDetalle()
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        If MsgBox("Esta opción solo se puede realizar una vez para el período, por lo tanto, no estará disponible para volver a ejecutarse." & Chr(13) & Chr(13) & "¿Continua con la generación del asiento presupuestario?", MsgBoxStyle.OKCancel + MsgBoxStyle.Information) = MsgBoxResult.No Then
            Exit Sub
        End If
        Cursor.Current = Cursors.WaitCursor

        If rdgTipoProceso.EditValue = "H" Then
            Dim mensaje As String = Centralizacion.ValidarNumeroCompromisoDexon(luePeriodo.EditValue, rdgTipoProceso.EditValue)
            If mensaje.Length > 0 Then
                MsgBox(mensaje & "." & Chr(13) & Chr(13) & "Debe corregir el número de compromiso en la ficha del empleado para generar la centralización presupuestaria.", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If

        Centralizacion.procesarAsientoPresupuesto(luePeriodo.EditValue, rdgTipoProceso.EditValue, estadoPeriodo, cl.presidencia.Seguridad.NombreUsuario)
        Dim mensajeDevuelto As String = Centralizacion.generarAsientoPresupuestoHaciaDexon(luePeriodo.EditValue, rdgTipoProceso.EditValue, mensajeDevuelto)
        Dim mensajeDexon As String = ""
        Cursor.Current = Cursors.Default
        If mensajeDevuelto.Length > 0 And mensajeDevuelto.Substring(0, 2) <> "XX" Then
            MsgBox(mensajeDevuelto & "." & Chr(13) & "Debe corregir las cuentas o centros de costos para generar la centralización", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical)
            Exit Sub
        Else
            mensajeDexon = mensajeDevuelto.Substring(2, mensajeDevuelto.Length - 2)
        End If
        Dim tipoAsiento As String
        If rdgTipoProceso.EditValue = "N" Then
            tipoAsiento = "Se generó correctamente el asiento de remuneraciones PLANTA Y CONTRATA del periodo " + periodo.anoMes + ". " + Chr(13) + Chr(13) + mensajeDexon
        ElseIf rdgTipoProceso.EditValue = "H" Then
            tipoAsiento = "Se generó correctamente el asiento de remuneraciones HONORARIOS del periodo " + periodo.anoMes + ". " + Chr(13) + Chr(13) + mensajeDexon
        ElseIf rdgTipoProceso.EditValue = "V" Then
            tipoAsiento = "Se generó correctamente el asiento de VIATICOS del periodo " + periodo.anoMes + ". " + Chr(13) + Chr(13) + mensajeDexon
        End If
        btnGenerar.Enabled = False
        asientoContableID = 500
        MsgBox(tipoAsiento, MsgBoxStyle.OKOnly + MsgBoxStyle.Information)
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Dim rutaPlanillaExcel As String
        Try
            With SaveFileDialog1
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = SaveFileDialog1.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                pgcDetalleAsientoPresup.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RefrescarDetalle()
        estadoPeriodo = Periodo.estadoPeriodo
        'Si el estado del periodo es 0 (No Activo) deshabilita boton generar
        btnExportarExcel.Enabled = True
        Dim dv As DataView = Centralizacion.recuperarAsientoPresupuesto(luePeriodo.EditValue, rdgTipoProceso.EditValue, estadoPeriodo, asientoContableID)
        pgcDetalleAsientoPresup.DataSource = Centralizacion.recuperarAsientoPresupuesto(luePeriodo.EditValue, rdgTipoProceso.EditValue, estadoPeriodo, asientoContableID)
        If estadoPeriodo = False Then
            txtEstadoPeriodo.Text = "INACTIVO"
            btnGenerar.Enabled = True 'FALSE
        Else
            txtEstadoPeriodo.Text = "ACTIVO"
            If asientoContableID = 0 Then
                btnGenerar.Enabled = True
            Else
                btnGenerar.Enabled = False
            End If
        End If
        If Not dv Is Nothing Then
            If dv.Count <= 0 Then
                txtTicketDexon.Text = ""
                txtTicketDexon.Enabled = False
            Else
                txtTicketDexon.Enabled = True
            End If
            txtTicketDexon.Text = Centralizacion.BuscarTicketDexon(luePeriodo.EditValue, rdgTipoProceso.EditValue)
        End If
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim tck As String = IIf(txtTicketDexon.Text.Length > 0 And asientoContableID > 0, " Ticket Dexon: " & txtTicketDexon.Text, "")
        Dim SuBTitulo As String = IIf(rdgTipoProceso.EditValue = "H", " HONORARIOS", IIf(rdgTipoProceso.EditValue = "N", " PLANTA Y CONTRATA", " VIATICOS"))
        Dim reportHeader As String = "PERIODO : " & periodo.nombrePeriodo & SuBTitulo & IIf(asientoContableID > 0, tck & " (Definitivo)", " (Borrador)")
        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        If RTrim(txtTicketDexon.Text).Length > 0 Then
            Centralizacion.ActualizarTicketDexon(luePeriodo.EditValue, rdgTipoProceso.EditValue, txtTicketDexon.Text)
        End If
        If rdgTipoProceso.EditValue = "H" Then
            colAÑO.Visible = False
            colMES.Visible = False
            colCALIDAD_JURIDICA_DESC.Visible = False
            colCENTRO_COSTO_CONTAB_DESC.Width = 500
            colCUENTA_PRESUPUESTO.Width = 70
            colCENTRO_COSTO_ALIAS.Width = 50
            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
            colAÑO.Visible = True
            colMES.Visible = True
            colCALIDAD_JURIDICA_DESC.Width = 200
            colCENTRO_COSTO_CONTAB_DESC.Width = 500
            colCUENTA_PRESUPUESTO.Width = 200
            colCENTRO_COSTO_ALIAS.Width = 80
        Else
            colAÑO.Visible = False
            colMES.Visible = False
            colCALIDAD_JURIDICA_DESC.Width = 80
            colCENTRO_COSTO_CONTAB_DESC.Width = 300
            colCUENTA_PRESUPUESTO.Width = 80
            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
            colAÑO.Visible = True
            colMES.Visible = True
            colCALIDAD_JURIDICA_DESC.Width = 200
            colCENTRO_COSTO_CONTAB_DESC.Width = 500
            colCUENTA_PRESUPUESTO.Width = 200
        End If

    End Sub
End Class
