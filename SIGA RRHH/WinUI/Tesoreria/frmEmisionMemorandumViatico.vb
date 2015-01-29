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

Public Class frmEmisionMemorandumViatico
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
    Friend WithEvents gpcFiltros As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblNroMemorandum As System.Windows.Forms.Label
    Friend WithEvents gdcViatico As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalleViatico As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents fieldVIATICO_DETALLE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldEMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldNOMBRE_EMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCALIDAD_JURIDICA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldGRADO_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCANTIDAD_DIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldFECHA_INICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldFECHA_TERMINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldMONTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMontoViaticoRepositorio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents fieldPAIS_DESTINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldREGION_DESTINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCOMUNA_DESTINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldSTR_ESTADO_VIATICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldDESTINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldPAIS_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldREGION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCOMUNA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldESTADO_VIATICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldNUMERO_DOCUMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldFECHA_DOCUMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents prsViatico As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents gleNumeroMemo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents fieldFIRMA As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmisionMemorandumViatico))
        Me.gpcFiltros = New DevExpress.XtraEditors.GroupControl()
        Me.gleNumeroMemo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.lblNroMemorandum = New System.Windows.Forms.Label()
        Me.gdcViatico = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleViatico = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.fieldVIATICO_DETALLE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldEMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldNOMBRE_EMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldCALIDAD_JURIDICA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldGRADO_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldCANTIDAD_DIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldFECHA_INICIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldFECHA_TERMINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldMONTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMontoViaticoRepositorio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.fieldPAIS_DESTINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldREGION_DESTINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldCOMUNA_DESTINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldSTR_ESTADO_VIATICO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldDESTINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldPAIS_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldREGION_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldCOMUNA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldESTADO_VIATICO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldNUMERO_DOCUMENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldFECHA_DOCUMENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldFIRMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.prsViatico = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.gpcFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcFiltros.SuspendLayout()
        CType(Me.gleNumeroMemo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcViatico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleViatico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoViaticoRepositorio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prsViatico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcFiltros
        '
        Me.gpcFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcFiltros.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcFiltros.AppearanceCaption.Options.UseFont = True
        Me.gpcFiltros.Controls.Add(Me.gleNumeroMemo)
        Me.gpcFiltros.Controls.Add(Me.lblPeriodo)
        Me.gpcFiltros.Controls.Add(Me.luePeriodo)
        Me.gpcFiltros.Controls.Add(Me.btnVisualizar)
        Me.gpcFiltros.Controls.Add(Me.lblNroMemorandum)
        Me.gpcFiltros.Location = New System.Drawing.Point(0, 8)
        Me.gpcFiltros.Name = "gpcFiltros"
        Me.gpcFiltros.Size = New System.Drawing.Size(984, 104)
        Me.gpcFiltros.TabIndex = 3
        Me.gpcFiltros.Text = "Filtros"
        '
        'gleNumeroMemo
        '
        Me.gleNumeroMemo.Location = New System.Drawing.Point(136, 56)
        Me.gleNumeroMemo.Name = "gleNumeroMemo"
        Me.gleNumeroMemo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleNumeroMemo.Properties.View = Me.GridLookUpEdit1View
        Me.gleNumeroMemo.Size = New System.Drawing.Size(288, 20)
        Me.gleNumeroMemo.TabIndex = 101
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(32, 36)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(24, 16)
        Me.lblPeriodo.TabIndex = 100
        Me.lblPeriodo.Text = "Año"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(136, 32)
        Me.luePeriodo.Name = "luePeriodo"
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ANO", "Año", 20, DevExpress.Utils.FormatType.DateTime, "d", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Descending)})
        Me.luePeriodo.Size = New System.Drawing.Size(96, 20)
        Me.luePeriodo.TabIndex = 67
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(448, 56)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(136, 23)
        Me.btnVisualizar.TabIndex = 66
        Me.btnVisualizar.Text = "Visualizar"
        '
        'lblNroMemorandum
        '
        Me.lblNroMemorandum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroMemorandum.Location = New System.Drawing.Point(24, 56)
        Me.lblNroMemorandum.Name = "lblNroMemorandum"
        Me.lblNroMemorandum.Size = New System.Drawing.Size(104, 16)
        Me.lblNroMemorandum.TabIndex = 65
        Me.lblNroMemorandum.Text = "Nº Memorandum"
        Me.lblNroMemorandum.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gdcViatico
        '
        Me.gdcViatico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcViatico.Location = New System.Drawing.Point(0, 112)
        Me.gdcViatico.MainView = Me.gdvDetalleViatico
        Me.gdcViatico.Name = "gdcViatico"
        Me.gdcViatico.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtMontoViaticoRepositorio})
        Me.gdcViatico.Size = New System.Drawing.Size(984, 264)
        Me.gdcViatico.TabIndex = 4
        Me.gdcViatico.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleViatico, Me.GridView1})
        '
        'gdvDetalleViatico
        '
        Me.gdvDetalleViatico.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvDetalleViatico.Appearance.FooterPanel.Options.UseFont = True
        Me.gdvDetalleViatico.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.fieldVIATICO_DETALLE_ID, Me.fieldEMPLEADO_ID, Me.fieldNOMBRE_EMPLEADO, Me.fieldCALIDAD_JURIDICA, Me.fieldGRADO_ALIAS, Me.fieldCANTIDAD_DIAS, Me.fieldFECHA_INICIO, Me.fieldFECHA_TERMINO, Me.fieldMONTO, Me.fieldPAIS_DESTINO, Me.fieldREGION_DESTINO, Me.fieldCOMUNA_DESTINO, Me.fieldSTR_ESTADO_VIATICO, Me.fieldDESTINO, Me.fieldPAIS_ID, Me.fieldREGION_ID, Me.fieldCOMUNA_ID, Me.fieldESTADO_VIATICO, Me.fieldNUMERO_DOCUMENTO, Me.fieldFECHA_DOCUMENTO, Me.fieldFIRMA})
        Me.gdvDetalleViatico.GridControl = Me.gdcViatico
        Me.gdvDetalleViatico.Name = "gdvDetalleViatico"
        Me.gdvDetalleViatico.OptionsView.ColumnAutoWidth = False
        Me.gdvDetalleViatico.OptionsView.ShowFooter = True
        Me.gdvDetalleViatico.OptionsView.ShowGroupPanel = False
        '
        'fieldVIATICO_DETALLE_ID
        '
        Me.fieldVIATICO_DETALLE_ID.Caption = "Id Detalle Viático"
        Me.fieldVIATICO_DETALLE_ID.FieldName = "VIATICO_DETALLE_ID"
        Me.fieldVIATICO_DETALLE_ID.Name = "fieldVIATICO_DETALLE_ID"
        Me.fieldVIATICO_DETALLE_ID.OptionsColumn.AllowEdit = False
        Me.fieldVIATICO_DETALLE_ID.OptionsColumn.ReadOnly = True
        '
        'fieldEMPLEADO_ID
        '
        Me.fieldEMPLEADO_ID.Caption = "ID Empleado"
        Me.fieldEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.fieldEMPLEADO_ID.Name = "fieldEMPLEADO_ID"
        Me.fieldEMPLEADO_ID.OptionsColumn.AllowEdit = False
        Me.fieldEMPLEADO_ID.OptionsColumn.ReadOnly = True
        '
        'fieldNOMBRE_EMPLEADO
        '
        Me.fieldNOMBRE_EMPLEADO.Caption = "Empleado"
        Me.fieldNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.Name = "fieldNOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.OptionsColumn.AllowEdit = False
        Me.fieldNOMBRE_EMPLEADO.OptionsColumn.ReadOnly = True
        Me.fieldNOMBRE_EMPLEADO.Visible = True
        Me.fieldNOMBRE_EMPLEADO.VisibleIndex = 0
        Me.fieldNOMBRE_EMPLEADO.Width = 261
        '
        'fieldCALIDAD_JURIDICA
        '
        Me.fieldCALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.fieldCALIDAD_JURIDICA.FieldName = "CALIDAD_JURIDICA"
        Me.fieldCALIDAD_JURIDICA.Name = "fieldCALIDAD_JURIDICA"
        Me.fieldCALIDAD_JURIDICA.OptionsColumn.AllowEdit = False
        Me.fieldCALIDAD_JURIDICA.OptionsColumn.ReadOnly = True
        Me.fieldCALIDAD_JURIDICA.Visible = True
        Me.fieldCALIDAD_JURIDICA.VisibleIndex = 1
        Me.fieldCALIDAD_JURIDICA.Width = 140
        '
        'fieldGRADO_ALIAS
        '
        Me.fieldGRADO_ALIAS.Caption = "Grado"
        Me.fieldGRADO_ALIAS.FieldName = "GRADO_ALIAS"
        Me.fieldGRADO_ALIAS.Name = "fieldGRADO_ALIAS"
        Me.fieldGRADO_ALIAS.OptionsColumn.AllowEdit = False
        Me.fieldGRADO_ALIAS.OptionsColumn.ReadOnly = True
        Me.fieldGRADO_ALIAS.Visible = True
        Me.fieldGRADO_ALIAS.VisibleIndex = 2
        Me.fieldGRADO_ALIAS.Width = 60
        '
        'fieldCANTIDAD_DIAS
        '
        Me.fieldCANTIDAD_DIAS.Caption = "Días"
        Me.fieldCANTIDAD_DIAS.FieldName = "CANTIDAD_DIAS"
        Me.fieldCANTIDAD_DIAS.Name = "fieldCANTIDAD_DIAS"
        Me.fieldCANTIDAD_DIAS.OptionsColumn.AllowEdit = False
        Me.fieldCANTIDAD_DIAS.OptionsColumn.ReadOnly = True
        Me.fieldCANTIDAD_DIAS.Visible = True
        Me.fieldCANTIDAD_DIAS.VisibleIndex = 3
        Me.fieldCANTIDAD_DIAS.Width = 45
        '
        'fieldFECHA_INICIO
        '
        Me.fieldFECHA_INICIO.Caption = "Desde"
        Me.fieldFECHA_INICIO.FieldName = "FECHA_INICIO"
        Me.fieldFECHA_INICIO.Name = "fieldFECHA_INICIO"
        Me.fieldFECHA_INICIO.OptionsColumn.AllowEdit = False
        Me.fieldFECHA_INICIO.OptionsColumn.ReadOnly = True
        Me.fieldFECHA_INICIO.Visible = True
        Me.fieldFECHA_INICIO.VisibleIndex = 4
        Me.fieldFECHA_INICIO.Width = 82
        '
        'fieldFECHA_TERMINO
        '
        Me.fieldFECHA_TERMINO.Caption = "Hasta"
        Me.fieldFECHA_TERMINO.FieldName = "FECHA_TERMINO"
        Me.fieldFECHA_TERMINO.Name = "fieldFECHA_TERMINO"
        Me.fieldFECHA_TERMINO.OptionsColumn.AllowEdit = False
        Me.fieldFECHA_TERMINO.OptionsColumn.ReadOnly = True
        Me.fieldFECHA_TERMINO.Visible = True
        Me.fieldFECHA_TERMINO.VisibleIndex = 5
        Me.fieldFECHA_TERMINO.Width = 91
        '
        'fieldMONTO
        '
        Me.fieldMONTO.Caption = "A Pagar"
        Me.fieldMONTO.ColumnEdit = Me.txtMontoViaticoRepositorio
        Me.fieldMONTO.FieldName = "MONTO"
        Me.fieldMONTO.Name = "fieldMONTO"
        Me.fieldMONTO.OptionsColumn.AllowEdit = False
        Me.fieldMONTO.OptionsColumn.ReadOnly = True
        Me.fieldMONTO.SummaryItem.DisplayFormat = "Total : {0:n0}"
        Me.fieldMONTO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.fieldMONTO.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.fieldMONTO.Visible = True
        Me.fieldMONTO.VisibleIndex = 6
        Me.fieldMONTO.Width = 84
        '
        'txtMontoViaticoRepositorio
        '
        Me.txtMontoViaticoRepositorio.AutoHeight = False
        Me.txtMontoViaticoRepositorio.DisplayFormat.FormatString = "n0"
        Me.txtMontoViaticoRepositorio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoViaticoRepositorio.EditFormat.FormatString = "n0"
        Me.txtMontoViaticoRepositorio.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoViaticoRepositorio.Name = "txtMontoViaticoRepositorio"
        '
        'fieldPAIS_DESTINO
        '
        Me.fieldPAIS_DESTINO.Caption = "País Destino"
        Me.fieldPAIS_DESTINO.FieldName = "PAIS_DESTINO"
        Me.fieldPAIS_DESTINO.Name = "fieldPAIS_DESTINO"
        Me.fieldPAIS_DESTINO.OptionsColumn.AllowEdit = False
        Me.fieldPAIS_DESTINO.OptionsColumn.ReadOnly = True
        Me.fieldPAIS_DESTINO.Width = 149
        '
        'fieldREGION_DESTINO
        '
        Me.fieldREGION_DESTINO.Caption = "Región Destino"
        Me.fieldREGION_DESTINO.FieldName = "REGION_DESTINO"
        Me.fieldREGION_DESTINO.Name = "fieldREGION_DESTINO"
        Me.fieldREGION_DESTINO.OptionsColumn.AllowEdit = False
        Me.fieldREGION_DESTINO.OptionsColumn.ReadOnly = True
        Me.fieldREGION_DESTINO.Width = 139
        '
        'fieldCOMUNA_DESTINO
        '
        Me.fieldCOMUNA_DESTINO.Caption = "Comuna Destino"
        Me.fieldCOMUNA_DESTINO.FieldName = "COMUNA_DESTINO"
        Me.fieldCOMUNA_DESTINO.Name = "fieldCOMUNA_DESTINO"
        Me.fieldCOMUNA_DESTINO.OptionsColumn.AllowEdit = False
        Me.fieldCOMUNA_DESTINO.OptionsColumn.ReadOnly = True
        Me.fieldCOMUNA_DESTINO.Visible = True
        Me.fieldCOMUNA_DESTINO.VisibleIndex = 7
        Me.fieldCOMUNA_DESTINO.Width = 124
        '
        'fieldSTR_ESTADO_VIATICO
        '
        Me.fieldSTR_ESTADO_VIATICO.Caption = "Estado Viático"
        Me.fieldSTR_ESTADO_VIATICO.FieldName = "STR_ESTADO_VIATICO"
        Me.fieldSTR_ESTADO_VIATICO.Name = "fieldSTR_ESTADO_VIATICO"
        Me.fieldSTR_ESTADO_VIATICO.OptionsColumn.AllowEdit = False
        Me.fieldSTR_ESTADO_VIATICO.OptionsColumn.ReadOnly = True
        '
        'fieldDESTINO
        '
        Me.fieldDESTINO.Caption = "Destino"
        Me.fieldDESTINO.FieldName = "DESTINO"
        Me.fieldDESTINO.Name = "fieldDESTINO"
        Me.fieldDESTINO.OptionsColumn.AllowEdit = False
        Me.fieldDESTINO.OptionsColumn.ReadOnly = True
        '
        'fieldPAIS_ID
        '
        Me.fieldPAIS_ID.Caption = "ID País"
        Me.fieldPAIS_ID.FieldName = "PAIS_ID"
        Me.fieldPAIS_ID.Name = "fieldPAIS_ID"
        Me.fieldPAIS_ID.OptionsColumn.AllowEdit = False
        Me.fieldPAIS_ID.OptionsColumn.ReadOnly = True
        '
        'fieldREGION_ID
        '
        Me.fieldREGION_ID.Caption = "ID Región"
        Me.fieldREGION_ID.FieldName = "REGION_ID"
        Me.fieldREGION_ID.Name = "fieldREGION_ID"
        Me.fieldREGION_ID.OptionsColumn.AllowEdit = False
        Me.fieldREGION_ID.OptionsColumn.ReadOnly = True
        '
        'fieldCOMUNA_ID
        '
        Me.fieldCOMUNA_ID.Caption = "ID Comuna"
        Me.fieldCOMUNA_ID.FieldName = "COMUNA_id"
        Me.fieldCOMUNA_ID.Name = "fieldCOMUNA_ID"
        Me.fieldCOMUNA_ID.OptionsColumn.AllowEdit = False
        Me.fieldCOMUNA_ID.OptionsColumn.ReadOnly = True
        '
        'fieldESTADO_VIATICO
        '
        Me.fieldESTADO_VIATICO.Caption = "Estado Viático"
        Me.fieldESTADO_VIATICO.FieldName = "ESTADO_VIATICO"
        Me.fieldESTADO_VIATICO.Name = "fieldESTADO_VIATICO"
        Me.fieldESTADO_VIATICO.OptionsColumn.AllowEdit = False
        Me.fieldESTADO_VIATICO.OptionsColumn.ReadOnly = True
        '
        'fieldNUMERO_DOCUMENTO
        '
        Me.fieldNUMERO_DOCUMENTO.Caption = "Numero Cheque"
        Me.fieldNUMERO_DOCUMENTO.FieldName = "NUMERO_DOCUMENTO"
        Me.fieldNUMERO_DOCUMENTO.Name = "fieldNUMERO_DOCUMENTO"
        Me.fieldNUMERO_DOCUMENTO.OptionsColumn.AllowEdit = False
        Me.fieldNUMERO_DOCUMENTO.OptionsColumn.ReadOnly = True
        '
        'fieldFECHA_DOCUMENTO
        '
        Me.fieldFECHA_DOCUMENTO.Caption = "Fecha Docto."
        Me.fieldFECHA_DOCUMENTO.FieldName = "FECHA_DOCUMENTO"
        Me.fieldFECHA_DOCUMENTO.Name = "fieldFECHA_DOCUMENTO"
        Me.fieldFECHA_DOCUMENTO.OptionsColumn.AllowEdit = False
        Me.fieldFECHA_DOCUMENTO.OptionsColumn.ReadOnly = True
        '
        'fieldFIRMA
        '
        Me.fieldFIRMA.Caption = "Recibí Conforme"
        Me.fieldFIRMA.FieldName = "FIRMA"
        Me.fieldFIRMA.Name = "fieldFIRMA"
        Me.fieldFIRMA.OptionsColumn.AllowEdit = False
        Me.fieldFIRMA.OptionsColumn.ReadOnly = True
        Me.fieldFIRMA.Visible = True
        Me.fieldFIRMA.VisibleIndex = 8
        Me.fieldFIRMA.Width = 188
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcViatico
        Me.GridView1.Name = "GridView1"
        '
        'prsViatico
        '
        Me.prsViatico.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcViatico
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(10, 10, 50, 50)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de la República" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Depto. Tesorería", "Detalle de Viático", "Fecha Emisiòn:[Date Printed]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Emitido Por:[User Name]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"", "", "Página [Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.prsViatico
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prsViatico
        '
        'frmEmisionMemorandumViatico
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(992, 380)
        Me.Controls.Add(Me.gdcViatico)
        Me.Controls.Add(Me.gpcFiltros)
        Me.Name = "frmEmisionMemorandumViatico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emisión Memorandum Viático"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcFiltros.ResumeLayout(False)
        CType(Me.gleNumeroMemo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcViatico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleViatico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoViaticoRepositorio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prsViatico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private viatico As New viatico

    Private Sub frmEmisionMemorandumViatico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarPeriodo()
    End Sub

    Private Sub llenarPeriodo()
        With luePeriodo
            With .Properties.Columns
                .Add(New LookUpColumnInfo("ANO", "Año", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        repositorio.Show()
        luePeriodo.Properties.DataSource = repositorio.dvPeriodoAño
        luePeriodo.Properties.DisplayMember = "ANO"
        luePeriodo.Properties.NullText = ""
        luePeriodo.Properties.PopupWidth = 100
        luePeriodo.Properties.ValueMember = "ANO"
    End Sub

    Private Sub llenarNumeroMemo()
        gleNumeroMemo.Properties.View.Columns.Clear()
        'gleNumeroMemo.Properties.EditValueChangedFiringDelay = 600
        Repository.RepositoryItem.EditValueChangedFiringDelay = 600
        gleNumeroMemo.Properties.EditValueChangedFiringMode = EditValueChangedFiringMode.Buffered
        'Dos segundos se espera antes de gatillar la búsqueda (EditValueChanged)

        gleNumeroMemo.Properties.ViewType = Repository.GridLookUpViewType.GridView
        gleNumeroMemo.Properties.View.OptionsBehavior.AutoPopulateColumns = False
        'gleNumeroMemo.Properties.DataSource = repositorio.dvViaticoNumeroMemorandum
        gleNumeroMemo.Properties.DataSource = viatico.recuperarViaticoPorMemo(Me.luePeriodo.EditValue, False)
        gleNumeroMemo.Properties.DisplayMember = "DESCRIPCION"

        Dim col1 As GridColumn = gleNumeroMemo.Properties.View.Columns.AddField("NRO_MEMORANDUM_INTERNO")
        col1.VisibleIndex = 0
        col1.Caption = "Nro.Memorandum"

        Dim col2 As GridColumn = gleNumeroMemo.Properties.View.Columns.AddField("DEPARTAMENTO")
        col2.VisibleIndex = 1
        col2.Caption = "Departamento"

        Dim col3 As GridColumn = gleNumeroMemo.Properties.View.Columns.AddField("FECHA_MEMORANDUM")
        col3.VisibleIndex = 2
        col3.Caption = "Fecha Memo"

        Dim col4 As GridColumn = gleNumeroMemo.Properties.View.Columns.AddField("VIATICO_ID")
        col4.VisibleIndex = 3
        col4.Caption = "Viatico ID"
        col4.Visible = False

        Dim col5 As GridColumn = gleNumeroMemo.Properties.View.Columns.AddField("STR_ESTADO_VIATICO")
        col5.VisibleIndex = 4
        col5.Caption = "Estado Viático"

        gleNumeroMemo.Properties.ValueMember = "VIATICO_ID"
        gleNumeroMemo.Properties.View.BestFitColumns()
        gleNumeroMemo.Properties.PopupFormWidth = 600
    End Sub

    Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        llenarNumeroMemo()
    End Sub

    Private Sub gleNumeroMemo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gleNumeroMemo.EditValueChanged
        If Me.gleNumeroMemo.EditValue <> Nothing Then
            viatico = New viatico(gleNumeroMemo.EditValue)
            llenarGrilla()
        End If
    End Sub

    Private Sub llenarGrilla()
        gdcViatico.DataSource = viatico.recuperarViaticoDetalle(viatico.datosEncabezado.viaticoID)
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "Nro.Memorandum: " & viatico.datosEncabezado.numeroMemorandum.ToString & " Fecha Memorandum: " & viatico.datosEncabezado.fechaMemorandum.Date.ToShortDateString
        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)
    End Sub



End Class
