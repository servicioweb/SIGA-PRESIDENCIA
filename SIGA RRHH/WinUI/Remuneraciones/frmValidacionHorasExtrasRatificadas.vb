Public Class frmValidacionHorasExtrasRatificadas
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
    Friend WithEvents lblDepartamento As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueDepartamento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gpcInformacionMemoInterno As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblAño As System.Windows.Forms.Label
    Friend WithEvents txtAño As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMes As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents gdcDetalleAprobHorasExtras As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalleAprobHorasExtras As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colHORAS_APROBADAS_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPTO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO_REGISTRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHORAS_DIURNAS_APROB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHORAS_NOCTURNAS_APROB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtHrsAprobadasDiurnas As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtHrsAprobadasNocturnas As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnIncluirProcesoRemun As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colHORAS_DIURNAS_RATIF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHORAS_NOCTURNAS_RATIF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHORAS_DIURNAS_DIFER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHORAS_NOCTURNAS_DIFER As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpcBotonesEncabezado = New DevExpress.XtraEditors.GroupControl
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton
        Me.btnIncluirProcesoRemun = New DevExpress.XtraEditors.SimpleButton
        Me.gpcInformacionMemoInterno = New DevExpress.XtraEditors.GroupControl
        Me.lblMes = New System.Windows.Forms.Label
        Me.txtMes = New DevExpress.XtraEditors.TextEdit
        Me.lblDepartamento = New DevExpress.XtraEditors.LabelControl
        Me.lueDepartamento = New DevExpress.XtraEditors.LookUpEdit
        Me.txtAño = New DevExpress.XtraEditors.TextEdit
        Me.lblAño = New System.Windows.Forms.Label
        Me.gdcDetalleAprobHorasExtras = New DevExpress.XtraGrid.GridControl
        Me.gdvDetalleAprobHorasExtras = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colHORAS_APROBADAS_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEPTO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colESTADO_REGISTRO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHORAS_DIURNAS_APROB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtHrsAprobadasDiurnas = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colHORAS_NOCTURNAS_APROB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtHrsAprobadasNocturnas = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colHORAS_DIURNAS_RATIF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHORAS_NOCTURNAS_RATIF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHORAS_DIURNAS_DIFER = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHORAS_NOCTURNAS_DIFER = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.gpcBotonesEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBotonesEncabezado.SuspendLayout()
        CType(Me.gpcInformacionMemoInterno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcInformacionMemoInterno.SuspendLayout()
        CType(Me.txtMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAño.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcDetalleAprobHorasExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleAprobHorasExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHrsAprobadasDiurnas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHrsAprobadasNocturnas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcBotonesEncabezado
        '
        Me.gpcBotonesEncabezado.Controls.Add(Me.btnVisualizar)
        Me.gpcBotonesEncabezado.Controls.Add(Me.btnIncluirProcesoRemun)
        Me.gpcBotonesEncabezado.Location = New System.Drawing.Point(8, 128)
        Me.gpcBotonesEncabezado.Name = "gpcBotonesEncabezado"
        Me.gpcBotonesEncabezado.ShowCaption = False
        Me.gpcBotonesEncabezado.Size = New System.Drawing.Size(992, 40)
        Me.gpcBotonesEncabezado.TabIndex = 5
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(504, 8)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(192, 23)
        Me.btnVisualizar.TabIndex = 11
        Me.btnVisualizar.Text = "Visualizar"
        '
        'btnIncluirProcesoRemun
        '
        Me.btnIncluirProcesoRemun.Location = New System.Drawing.Point(208, 8)
        Me.btnIncluirProcesoRemun.Name = "btnIncluirProcesoRemun"
        Me.btnIncluirProcesoRemun.Size = New System.Drawing.Size(192, 23)
        Me.btnIncluirProcesoRemun.TabIndex = 6
        Me.btnIncluirProcesoRemun.Text = "Incluir en Proceso Remuneración"
        '
        'gpcInformacionMemoInterno
        '
        Me.gpcInformacionMemoInterno.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcInformacionMemoInterno.AppearanceCaption.Options.UseFont = True
        Me.gpcInformacionMemoInterno.Controls.Add(Me.lblMes)
        Me.gpcInformacionMemoInterno.Controls.Add(Me.txtMes)
        Me.gpcInformacionMemoInterno.Controls.Add(Me.lblDepartamento)
        Me.gpcInformacionMemoInterno.Controls.Add(Me.lueDepartamento)
        Me.gpcInformacionMemoInterno.Controls.Add(Me.txtAño)
        Me.gpcInformacionMemoInterno.Controls.Add(Me.lblAño)
        Me.gpcInformacionMemoInterno.Location = New System.Drawing.Point(8, 8)
        Me.gpcInformacionMemoInterno.Name = "gpcInformacionMemoInterno"
        Me.gpcInformacionMemoInterno.Size = New System.Drawing.Size(992, 120)
        Me.gpcInformacionMemoInterno.TabIndex = 4
        Me.gpcInformacionMemoInterno.Text = "Filtro de Selección"
        '
        'lblMes
        '
        Me.lblMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.Location = New System.Drawing.Point(40, 60)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(48, 16)
        Me.lblMes.TabIndex = 77
        Me.lblMes.Text = "Mes"
        Me.lblMes.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMes
        '
        Me.txtMes.EnterMoveNextControl = True
        Me.txtMes.Location = New System.Drawing.Point(96, 56)
        Me.txtMes.Name = "txtMes"
        '
        'txtMes.Properties
        '
        Me.txtMes.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMes.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMes.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMes.Properties.Mask.EditMask = "n0"
        Me.txtMes.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMes.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMes.Properties.MaxLength = 7
        Me.txtMes.Size = New System.Drawing.Size(64, 20)
        Me.txtMes.TabIndex = 76
        Me.txtMes.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'lblDepartamento
        '
        Me.lblDepartamento.Location = New System.Drawing.Point(16, 86)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.TabIndex = 74
        Me.lblDepartamento.Text = "Departamento"
        '
        'lueDepartamento
        '
        Me.lueDepartamento.Location = New System.Drawing.Point(96, 80)
        Me.lueDepartamento.Name = "lueDepartamento"
        '
        'lueDepartamento.Properties
        '
        Me.lueDepartamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDepartamento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3")})
        Me.lueDepartamento.Properties.NullText = ""
        Me.lueDepartamento.Size = New System.Drawing.Size(304, 20)
        Me.lueDepartamento.TabIndex = 0
        '
        'txtAño
        '
        Me.txtAño.EnterMoveNextControl = True
        Me.txtAño.Location = New System.Drawing.Point(96, 32)
        Me.txtAño.Name = "txtAño"
        '
        'txtAño.Properties
        '
        Me.txtAño.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAño.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAño.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAño.Properties.Mask.EditMask = "n0"
        Me.txtAño.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAño.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAño.Properties.MaxLength = 7
        Me.txtAño.Size = New System.Drawing.Size(64, 20)
        Me.txtAño.TabIndex = 3
        Me.txtAño.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'lblAño
        '
        Me.lblAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAño.Location = New System.Drawing.Point(40, 36)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(48, 16)
        Me.lblAño.TabIndex = 75
        Me.lblAño.Text = "Año"
        Me.lblAño.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gdcDetalleAprobHorasExtras
        '
        Me.gdcDetalleAprobHorasExtras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        'gdcDetalleAprobHorasExtras.EmbeddedNavigator
        '
        Me.gdcDetalleAprobHorasExtras.EmbeddedNavigator.Name = ""
        Me.gdcDetalleAprobHorasExtras.Location = New System.Drawing.Point(8, 168)
        Me.gdcDetalleAprobHorasExtras.MainView = Me.gdvDetalleAprobHorasExtras
        Me.gdcDetalleAprobHorasExtras.Name = "gdcDetalleAprobHorasExtras"
        Me.gdcDetalleAprobHorasExtras.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtHrsAprobadasDiurnas, Me.txtHrsAprobadasNocturnas})
        Me.gdcDetalleAprobHorasExtras.Size = New System.Drawing.Size(992, 248)
        Me.gdcDetalleAprobHorasExtras.TabIndex = 6
        Me.gdcDetalleAprobHorasExtras.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleAprobHorasExtras, Me.GridView2})
        '
        'gdvDetalleAprobHorasExtras
        '
        Me.gdvDetalleAprobHorasExtras.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gdvDetalleAprobHorasExtras.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gdvDetalleAprobHorasExtras.ColumnPanelRowHeight = 40
        Me.gdvDetalleAprobHorasExtras.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHORAS_APROBADAS_ID, Me.colEMPLEADO_ID, Me.colDEPTO_ID, Me.colESTADO_REGISTRO, Me.colHORAS_DIURNAS_APROB, Me.colHORAS_DIURNAS_RATIF, Me.colHORAS_DIURNAS_DIFER, Me.colHORAS_NOCTURNAS_APROB, Me.colHORAS_NOCTURNAS_RATIF, Me.colHORAS_NOCTURNAS_DIFER})
        Me.gdvDetalleAprobHorasExtras.GridControl = Me.gdcDetalleAprobHorasExtras
        Me.gdvDetalleAprobHorasExtras.Name = "gdvDetalleAprobHorasExtras"
        Me.gdvDetalleAprobHorasExtras.OptionsView.RowAutoHeight = True
        Me.gdvDetalleAprobHorasExtras.OptionsView.ShowGroupPanel = False
        '
        'colHORAS_APROBADAS_ID
        '
        Me.colHORAS_APROBADAS_ID.Caption = "ID Horas Aprobadas"
        Me.colHORAS_APROBADAS_ID.FieldName = "HORAS_APROBADAS_ID"
        Me.colHORAS_APROBADAS_ID.Name = "colHORAS_APROBADAS_ID"
        Me.colHORAS_APROBADAS_ID.OptionsColumn.AllowEdit = False
        Me.colHORAS_APROBADAS_ID.OptionsColumn.ReadOnly = True
        Me.colHORAS_APROBADAS_ID.OptionsColumn.ShowInCustomizationForm = False
        '
        'colEMPLEADO_ID
        '
        Me.colEMPLEADO_ID.Caption = "Empleado"
        Me.colEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.colEMPLEADO_ID.Name = "colEMPLEADO_ID"
        Me.colEMPLEADO_ID.Visible = True
        Me.colEMPLEADO_ID.VisibleIndex = 0
        Me.colEMPLEADO_ID.Width = 250
        '
        'colDEPTO_ID
        '
        Me.colDEPTO_ID.Caption = "Depto"
        Me.colDEPTO_ID.FieldName = "DEPTO_ID"
        Me.colDEPTO_ID.Name = "colDEPTO_ID"
        Me.colDEPTO_ID.OptionsColumn.AllowEdit = False
        Me.colDEPTO_ID.OptionsColumn.ReadOnly = True
        Me.colDEPTO_ID.OptionsColumn.ShowInCustomizationForm = False
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
        'colHORAS_DIURNAS_APROB
        '
        Me.colHORAS_DIURNAS_APROB.Caption = "Hrs.Diurnas Aprobadas"
        Me.colHORAS_DIURNAS_APROB.ColumnEdit = Me.txtHrsAprobadasDiurnas
        Me.colHORAS_DIURNAS_APROB.FieldName = "HORAS_DIURNAS_APROB"
        Me.colHORAS_DIURNAS_APROB.Name = "colHORAS_DIURNAS_APROB"
        Me.colHORAS_DIURNAS_APROB.Visible = True
        Me.colHORAS_DIURNAS_APROB.VisibleIndex = 1
        Me.colHORAS_DIURNAS_APROB.Width = 110
        '
        'txtHrsAprobadasDiurnas
        '
        Me.txtHrsAprobadasDiurnas.AutoHeight = False
        Me.txtHrsAprobadasDiurnas.DisplayFormat.FormatString = "n0"
        Me.txtHrsAprobadasDiurnas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHrsAprobadasDiurnas.EditFormat.FormatString = "n0"
        Me.txtHrsAprobadasDiurnas.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHrsAprobadasDiurnas.Mask.EditMask = "n0"
        Me.txtHrsAprobadasDiurnas.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtHrsAprobadasDiurnas.Mask.UseMaskAsDisplayFormat = True
        Me.txtHrsAprobadasDiurnas.Name = "txtHrsAprobadasDiurnas"
        '
        'colHORAS_NOCTURNAS_APROB
        '
        Me.colHORAS_NOCTURNAS_APROB.Caption = "Hrs.Nocturnas Aprobadas"
        Me.colHORAS_NOCTURNAS_APROB.ColumnEdit = Me.txtHrsAprobadasNocturnas
        Me.colHORAS_NOCTURNAS_APROB.FieldName = "HORAS_NOCTURNAS_APROB"
        Me.colHORAS_NOCTURNAS_APROB.Name = "colHORAS_NOCTURNAS_APROB"
        Me.colHORAS_NOCTURNAS_APROB.Visible = True
        Me.colHORAS_NOCTURNAS_APROB.VisibleIndex = 4
        Me.colHORAS_NOCTURNAS_APROB.Width = 110
        '
        'txtHrsAprobadasNocturnas
        '
        Me.txtHrsAprobadasNocturnas.AutoHeight = False
        Me.txtHrsAprobadasNocturnas.DisplayFormat.FormatString = "n0"
        Me.txtHrsAprobadasNocturnas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHrsAprobadasNocturnas.EditFormat.FormatString = "n0"
        Me.txtHrsAprobadasNocturnas.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHrsAprobadasNocturnas.Mask.UseMaskAsDisplayFormat = True
        Me.txtHrsAprobadasNocturnas.Name = "txtHrsAprobadasNocturnas"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.gdcDetalleAprobHorasExtras
        Me.GridView2.Name = "GridView2"
        '
        'colHORAS_DIURNAS_RATIF
        '
        Me.colHORAS_DIURNAS_RATIF.Caption = "Hrs.Diurnas Ratificadas"
        Me.colHORAS_DIURNAS_RATIF.FieldName = "HORAS_DIURNAS_RATIF"
        Me.colHORAS_DIURNAS_RATIF.Name = "colHORAS_DIURNAS_RATIF"
        Me.colHORAS_DIURNAS_RATIF.Visible = True
        Me.colHORAS_DIURNAS_RATIF.VisibleIndex = 2
        Me.colHORAS_DIURNAS_RATIF.Width = 110
        '
        'colHORAS_NOCTURNAS_RATIF
        '
        Me.colHORAS_NOCTURNAS_RATIF.Caption = "Hrs.Nocturnas Ratificadas"
        Me.colHORAS_NOCTURNAS_RATIF.FieldName = "HORAS_NOCTURNAS_RATIF"
        Me.colHORAS_NOCTURNAS_RATIF.Name = "colHORAS_NOCTURNAS_RATIF"
        Me.colHORAS_NOCTURNAS_RATIF.Visible = True
        Me.colHORAS_NOCTURNAS_RATIF.VisibleIndex = 5
        Me.colHORAS_NOCTURNAS_RATIF.Width = 110
        '
        'colHORAS_DIURNAS_DIFER
        '
        Me.colHORAS_DIURNAS_DIFER.Caption = "Hrs.Diurnas Diferencias"
        Me.colHORAS_DIURNAS_DIFER.FieldName = "HORAS_DIURNAS_DIFER"
        Me.colHORAS_DIURNAS_DIFER.Name = "colHORAS_DIURNAS_DIFER"
        Me.colHORAS_DIURNAS_DIFER.Visible = True
        Me.colHORAS_DIURNAS_DIFER.VisibleIndex = 3
        Me.colHORAS_DIURNAS_DIFER.Width = 110
        '
        'colHORAS_NOCTURNAS_DIFER
        '
        Me.colHORAS_NOCTURNAS_DIFER.Caption = "Hrs.Nocturnas Difrencias"
        Me.colHORAS_NOCTURNAS_DIFER.FieldName = "HORAS_NOCTURNAS_DIFER"
        Me.colHORAS_NOCTURNAS_DIFER.Name = "colHORAS_NOCTURNAS_DIFER"
        Me.colHORAS_NOCTURNAS_DIFER.Visible = True
        Me.colHORAS_NOCTURNAS_DIFER.VisibleIndex = 6
        Me.colHORAS_NOCTURNAS_DIFER.Width = 110
        '
        'frmValidacionHorasExtrasRatificadas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1008, 420)
        Me.Controls.Add(Me.gdcDetalleAprobHorasExtras)
        Me.Controls.Add(Me.gpcBotonesEncabezado)
        Me.Controls.Add(Me.gpcInformacionMemoInterno)
        Me.Name = "frmValidacionHorasExtrasRatificadas"
        Me.Text = "Validación Horas Extras Ratificadas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcBotonesEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBotonesEncabezado.ResumeLayout(False)
        CType(Me.gpcInformacionMemoInterno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcInformacionMemoInterno.ResumeLayout(False)
        CType(Me.txtMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAño.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcDetalleAprobHorasExtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleAprobHorasExtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHrsAprobadasDiurnas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHrsAprobadasNocturnas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


End Class
