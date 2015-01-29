Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository

Public Class frmEnviarHonorariosADexon
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
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnProcesar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gpcBotones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gdcDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_EMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION_CENTRO_COSTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUENTA_PRESUPUESTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_CENTRO_COSTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents prsDexon As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents progreso As System.Windows.Forms.ProgressBar
    Friend WithEvents colMONTO_ANUAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMontoAnual As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnviarHonorariosADexon))
        Me.gpcBotones = New DevExpress.XtraEditors.GroupControl()
        Me.progreso = New System.Windows.Forms.ProgressBar()
        Me.btnProcesar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.gdcDetalle = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_EMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_ANUAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMontoAnual = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODIGO_CENTRO_COSTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION_CENTRO_COSTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUENTA_PRESUPUESTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.prsDexon = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBotones.SuspendLayout()
        CType(Me.gdcDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoAnual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prsDexon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcBotones
        '
        Me.gpcBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcBotones.Controls.Add(Me.progreso)
        Me.gpcBotones.Controls.Add(Me.btnProcesar)
        Me.gpcBotones.Controls.Add(Me.btnVisualizar)
        Me.gpcBotones.Location = New System.Drawing.Point(0, 0)
        Me.gpcBotones.Name = "gpcBotones"
        Me.gpcBotones.ShowCaption = False
        Me.gpcBotones.Size = New System.Drawing.Size(712, 88)
        Me.gpcBotones.TabIndex = 0
        Me.gpcBotones.Text = "GroupControl1"
        '
        'progreso
        '
        Me.progreso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progreso.Location = New System.Drawing.Point(240, 40)
        Me.progreso.Name = "progreso"
        Me.progreso.Size = New System.Drawing.Size(448, 24)
        Me.progreso.TabIndex = 12
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(144, 40)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 1
        Me.btnProcesar.Text = "Procesar"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(48, 40)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnVisualizar.TabIndex = 0
        Me.btnVisualizar.Text = "Vizualizar"
        '
        'gdcDetalle
        '
        Me.gdcDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcDetalle.Location = New System.Drawing.Point(0, 88)
        Me.gdcDetalle.MainView = Me.gdvDetalle
        Me.gdcDetalle.Name = "gdcDetalle"
        Me.gdcDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtMontoAnual})
        Me.gdcDetalle.Size = New System.Drawing.Size(712, 200)
        Me.gdcDetalle.TabIndex = 1
        Me.gdcDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalle})
        '
        'gdvDetalle
        '
        Me.gdvDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEMPLEADO_ID, Me.colNOMBRE_EMPLEADO, Me.colMONTO_ANUAL, Me.colDESCRIPCION, Me.colCODIGO_CENTRO_COSTO, Me.colDESCRIPCION_CENTRO_COSTO, Me.colCUENTA_PRESUPUESTO})
        Me.gdvDetalle.GridControl = Me.gdcDetalle
        Me.gdvDetalle.Name = "gdvDetalle"
        Me.gdvDetalle.OptionsView.ColumnAutoWidth = False
        Me.gdvDetalle.OptionsView.ShowGroupPanel = False
        '
        'colEMPLEADO_ID
        '
        Me.colEMPLEADO_ID.Caption = "Id Empleado"
        Me.colEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.colEMPLEADO_ID.Name = "colEMPLEADO_ID"
        Me.colEMPLEADO_ID.OptionsColumn.AllowEdit = False
        Me.colEMPLEADO_ID.OptionsColumn.AllowMove = False
        Me.colEMPLEADO_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colEMPLEADO_ID.OptionsColumn.ReadOnly = True
        '
        'colNOMBRE_EMPLEADO
        '
        Me.colNOMBRE_EMPLEADO.Caption = "Nombre Empleado"
        Me.colNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.colNOMBRE_EMPLEADO.Name = "colNOMBRE_EMPLEADO"
        Me.colNOMBRE_EMPLEADO.OptionsColumn.AllowEdit = False
        Me.colNOMBRE_EMPLEADO.OptionsColumn.AllowMove = False
        Me.colNOMBRE_EMPLEADO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colNOMBRE_EMPLEADO.OptionsColumn.ReadOnly = True
        Me.colNOMBRE_EMPLEADO.Visible = True
        Me.colNOMBRE_EMPLEADO.VisibleIndex = 0
        Me.colNOMBRE_EMPLEADO.Width = 394
        '
        'colMONTO_ANUAL
        '
        Me.colMONTO_ANUAL.Caption = "Monto Anual"
        Me.colMONTO_ANUAL.ColumnEdit = Me.txtMontoAnual
        Me.colMONTO_ANUAL.DisplayFormat.FormatString = "n0"
        Me.colMONTO_ANUAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_ANUAL.FieldName = "MONTO_ANUAL"
        Me.colMONTO_ANUAL.Name = "colMONTO_ANUAL"
        Me.colMONTO_ANUAL.OptionsColumn.AllowEdit = False
        Me.colMONTO_ANUAL.OptionsColumn.AllowMove = False
        Me.colMONTO_ANUAL.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMONTO_ANUAL.OptionsColumn.ReadOnly = True
        Me.colMONTO_ANUAL.Visible = True
        Me.colMONTO_ANUAL.VisibleIndex = 1
        Me.colMONTO_ANUAL.Width = 118
        '
        'txtMontoAnual
        '
        Me.txtMontoAnual.AutoHeight = False
        Me.txtMontoAnual.DisplayFormat.FormatString = "n0"
        Me.txtMontoAnual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoAnual.EditFormat.FormatString = "n0"
        Me.txtMontoAnual.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoAnual.Mask.EditMask = "n0"
        Me.txtMontoAnual.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoAnual.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoAnual.Name = "txtMontoAnual"
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "Calidad Juridica"
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.OptionsColumn.AllowEdit = False
        Me.colDESCRIPCION.OptionsColumn.AllowMove = False
        Me.colDESCRIPCION.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colDESCRIPCION.OptionsColumn.ReadOnly = True
        Me.colDESCRIPCION.Width = 138
        '
        'colCODIGO_CENTRO_COSTO
        '
        Me.colCODIGO_CENTRO_COSTO.Caption = "Cod.Centro Costo"
        Me.colCODIGO_CENTRO_COSTO.FieldName = "CODIGO_CENTRO_COSTO"
        Me.colCODIGO_CENTRO_COSTO.Name = "colCODIGO_CENTRO_COSTO"
        Me.colCODIGO_CENTRO_COSTO.OptionsColumn.AllowEdit = False
        Me.colCODIGO_CENTRO_COSTO.OptionsColumn.AllowMove = False
        Me.colCODIGO_CENTRO_COSTO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colCODIGO_CENTRO_COSTO.OptionsColumn.ReadOnly = True
        Me.colCODIGO_CENTRO_COSTO.Visible = True
        Me.colCODIGO_CENTRO_COSTO.VisibleIndex = 2
        Me.colCODIGO_CENTRO_COSTO.Width = 103
        '
        'colDESCRIPCION_CENTRO_COSTO
        '
        Me.colDESCRIPCION_CENTRO_COSTO.Caption = "Código Cen.Costo"
        Me.colDESCRIPCION_CENTRO_COSTO.FieldName = "DESCRIPCION_CENTRO_COSTO"
        Me.colDESCRIPCION_CENTRO_COSTO.Name = "colDESCRIPCION_CENTRO_COSTO"
        Me.colDESCRIPCION_CENTRO_COSTO.OptionsColumn.AllowEdit = False
        Me.colDESCRIPCION_CENTRO_COSTO.OptionsColumn.AllowMove = False
        Me.colDESCRIPCION_CENTRO_COSTO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colDESCRIPCION_CENTRO_COSTO.OptionsColumn.ReadOnly = True
        Me.colDESCRIPCION_CENTRO_COSTO.Visible = True
        Me.colDESCRIPCION_CENTRO_COSTO.VisibleIndex = 3
        Me.colDESCRIPCION_CENTRO_COSTO.Width = 434
        '
        'colCUENTA_PRESUPUESTO
        '
        Me.colCUENTA_PRESUPUESTO.Caption = "Cta.Presupuesto"
        Me.colCUENTA_PRESUPUESTO.FieldName = "CUENTA_PRESUPUESTO"
        Me.colCUENTA_PRESUPUESTO.Name = "colCUENTA_PRESUPUESTO"
        Me.colCUENTA_PRESUPUESTO.OptionsColumn.AllowEdit = False
        Me.colCUENTA_PRESUPUESTO.OptionsColumn.AllowMove = False
        Me.colCUENTA_PRESUPUESTO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colCUENTA_PRESUPUESTO.OptionsColumn.ReadOnly = True
        Me.colCUENTA_PRESUPUESTO.Visible = True
        Me.colCUENTA_PRESUPUESTO.VisibleIndex = 4
        Me.colCUENTA_PRESUPUESTO.Width = 227
        '
        'prsDexon
        '
        Me.prsDexon.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcDetalle
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(2, 2, 100, 100)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Depto. RRHH", "EMPLEADOS HONORARIOS A ENVIAR A DEXON", "Fecha Emisiòn:[Date Printed]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Emitido Por:[User Name]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"", "", "Página [Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.prsDexon
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prsDexon
        '
        'frmEnviarHonorariosADexon
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(712, 290)
        Me.Controls.Add(Me.gdcDetalle)
        Me.Controls.Add(Me.gpcBotones)
        Me.Name = "frmEnviarHonorariosADexon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enviar Empleado Honorario a Dexon"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBotones.ResumeLayout(False)
        CType(Me.gdcDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoAnual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prsDexon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim parametroMensual As periodo
    Dim empleado As New empleado

    Private Sub frmEnviarHonorariosADexon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gdcDetalle.DataSource = empleado.dvEmpleadoEnviadosADexon
        parametroMensual = New Periodo
        progreso.Visible = False
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        If MessageBox.Show("¿Está seguro que enviar los registros a Dexon?", "Remuneraciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            GenerarHaciaDexon()
        End If
    End Sub

    Private Sub GenerarHaciaDexon()
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetalle
        progreso.Visible = True
        progreso.Minimum = 0
        progreso.Maximum = gdvDetalle.RowCount - 1
        For i As Integer = 0 To gdvDetalle.RowCount - 1
            Centralizacion.enviaHonorarioDexon(view.GetRowCellValue(i, "EMPLEADO_ID"), parametroMensual.ano)
            progreso.Value = i
        Next
        gdcDetalle.DataSource = Nothing
        gdcDetalle.Refresh()
        progreso.Visible = False
    End Sub
End Class
