Public Class frmResolucionViatico
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents gdcMemorandums As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvMemoramdumsDetalle As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents colEGRESO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSELECCIONAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkAceptar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colNUMERO_DOCUMENTO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_DOCUMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gpcResultado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gpcBotones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents luePeriodos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents lblDocumentoWord As System.Windows.Forms.Label
    Friend WithEvents btnBuscarDocumentoWord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDocumentoWord As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGenerarWord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAnularResolucion As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gdcMemorandums = New DevExpress.XtraGrid.GridControl
        Me.gdvMemoramdumsDetalle = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colVIATICO_ID1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNRO_MEMORANDUM_INTERNO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_MEMORANDUM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colANO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMES = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEPTO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSTR_ESTADO_VIATICO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colESTADO_VIATICO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEGRESO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSELECCIONAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkAceptar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colNUMERO_DOCUMENTO2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_DOCUMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gpcResultado = New DevExpress.XtraEditors.GroupControl
        Me.gpcBotones = New DevExpress.XtraEditors.GroupControl
        Me.txtDocumentoWord = New DevExpress.XtraEditors.TextEdit
        Me.btnBuscarDocumentoWord = New DevExpress.XtraEditors.SimpleButton
        Me.lblDocumentoWord = New System.Windows.Forms.Label
        Me.luePeriodos = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.btnAnularResolucion = New DevExpress.XtraEditors.SimpleButton
        Me.btnGenerarWord = New DevExpress.XtraEditors.SimpleButton
        CType(Me.gdcMemorandums, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvMemoramdumsDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcResultado.SuspendLayout()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBotones.SuspendLayout()
        CType(Me.txtDocumentoWord.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcMemorandums
        '
        '
        'gdcMemorandums.EmbeddedNavigator
        '
        Me.gdcMemorandums.EmbeddedNavigator.Name = ""
        Me.gdcMemorandums.Location = New System.Drawing.Point(8, 24)
        Me.gdcMemorandums.MainView = Me.gdvMemoramdumsDetalle
        Me.gdcMemorandums.Name = "gdcMemorandums"
        Me.gdcMemorandums.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkAceptar})
        Me.gdcMemorandums.Size = New System.Drawing.Size(776, 176)
        Me.gdcMemorandums.TabIndex = 101
        Me.gdcMemorandums.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvMemoramdumsDetalle})
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
        Me.colNUMERO_DOCUMENTO2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False
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
        Me.colFECHA_DOCUMENTO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False
        Me.colFECHA_DOCUMENTO.OptionsColumn.AllowMove = False
        Me.colFECHA_DOCUMENTO.OptionsColumn.ReadOnly = True
        Me.colFECHA_DOCUMENTO.Visible = True
        Me.colFECHA_DOCUMENTO.VisibleIndex = 7
        '
        'gpcResultado
        '
        Me.gpcResultado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcResultado.AppearanceCaption.Options.UseFont = True
        Me.gpcResultado.Controls.Add(Me.gdcMemorandums)
        Me.gpcResultado.Location = New System.Drawing.Point(8, 128)
        Me.gpcResultado.Name = "gpcResultado"
        Me.gpcResultado.Size = New System.Drawing.Size(800, 208)
        Me.gpcResultado.TabIndex = 102
        Me.gpcResultado.Text = "Datos de Viático"
        '
        'gpcBotones
        '
        Me.gpcBotones.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcBotones.AppearanceCaption.Options.UseFont = True
        Me.gpcBotones.Controls.Add(Me.txtDocumentoWord)
        Me.gpcBotones.Controls.Add(Me.btnBuscarDocumentoWord)
        Me.gpcBotones.Controls.Add(Me.lblDocumentoWord)
        Me.gpcBotones.Controls.Add(Me.luePeriodos)
        Me.gpcBotones.Controls.Add(Me.lblPeriodo)
        Me.gpcBotones.Controls.Add(Me.btnAnularResolucion)
        Me.gpcBotones.Controls.Add(Me.btnGenerarWord)
        Me.gpcBotones.Location = New System.Drawing.Point(8, 8)
        Me.gpcBotones.Name = "gpcBotones"
        Me.gpcBotones.ShowCaption = False
        Me.gpcBotones.Size = New System.Drawing.Size(800, 120)
        Me.gpcBotones.TabIndex = 103
        Me.gpcBotones.Text = "Datos del Cheque"
        '
        'txtDocumentoWord
        '
        Me.txtDocumentoWord.Enabled = False
        Me.txtDocumentoWord.Location = New System.Drawing.Point(152, 48)
        Me.txtDocumentoWord.Name = "txtDocumentoWord"
        '
        'txtDocumentoWord.Properties
        '
        Me.txtDocumentoWord.Properties.ReadOnly = True
        Me.txtDocumentoWord.Size = New System.Drawing.Size(376, 20)
        Me.txtDocumentoWord.TabIndex = 104
        '
        'btnBuscarDocumentoWord
        '
        Me.btnBuscarDocumentoWord.Location = New System.Drawing.Point(120, 48)
        Me.btnBuscarDocumentoWord.Name = "btnBuscarDocumentoWord"
        Me.btnBuscarDocumentoWord.Size = New System.Drawing.Size(24, 24)
        Me.btnBuscarDocumentoWord.TabIndex = 103
        Me.btnBuscarDocumentoWord.Text = "..."
        Me.btnBuscarDocumentoWord.ToolTip = "Generar cheques para registros pendientes de pago"
        '
        'lblDocumentoWord
        '
        Me.lblDocumentoWord.Location = New System.Drawing.Point(16, 52)
        Me.lblDocumentoWord.Name = "lblDocumentoWord"
        Me.lblDocumentoWord.Size = New System.Drawing.Size(96, 16)
        Me.lblDocumentoWord.TabIndex = 102
        Me.lblDocumentoWord.Text = "Documento Word"
        Me.lblDocumentoWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'luePeriodos
        '
        Me.luePeriodos.Location = New System.Drawing.Point(120, 24)
        Me.luePeriodos.Name = "luePeriodos"
        '
        'luePeriodos.Properties
        '
        Me.luePeriodos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ANO", "Año", 20, DevExpress.Utils.FormatType.DateTime, "d", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Descending)})
        Me.luePeriodos.Size = New System.Drawing.Size(96, 20)
        Me.luePeriodos.TabIndex = 100
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(16, 24)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(24, 16)
        Me.lblPeriodo.TabIndex = 101
        Me.lblPeriodo.Text = "Año"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnAnularResolucion
        '
        Me.btnAnularResolucion.Location = New System.Drawing.Point(280, 80)
        Me.btnAnularResolucion.Name = "btnAnularResolucion"
        Me.btnAnularResolucion.Size = New System.Drawing.Size(112, 23)
        Me.btnAnularResolucion.TabIndex = 23
        Me.btnAnularResolucion.Text = "Anular Resolución"
        '
        'btnGenerarWord
        '
        Me.btnGenerarWord.Location = New System.Drawing.Point(152, 80)
        Me.btnGenerarWord.Name = "btnGenerarWord"
        Me.btnGenerarWord.Size = New System.Drawing.Size(112, 24)
        Me.btnGenerarWord.TabIndex = 10
        Me.btnGenerarWord.Text = "Generar Documento"
        Me.btnGenerarWord.ToolTip = "Generar cheques para registros pendientes de pago"
        '
        'frmResolucionViatico
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(816, 345)
        Me.Controls.Add(Me.gpcBotones)
        Me.Controls.Add(Me.gpcResultado)
        Me.Name = "frmResolucionViatico"
        Me.Text = "frmResolucionViatico"
        CType(Me.gdcMemorandums, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvMemoramdumsDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcResultado.ResumeLayout(False)
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBotones.ResumeLayout(False)
        CType(Me.txtDocumentoWord.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmResolucionViatico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class
