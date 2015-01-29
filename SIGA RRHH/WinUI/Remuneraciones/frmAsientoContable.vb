Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Reportes
Imports cl.presidencia.Argo.DataAccess
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Windows.Forms
Imports System.Drawing
Imports System
Public Class frmAsientoContable
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
    Friend WithEvents txtEstadoPeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents lblTipoProceso As System.Windows.Forms.Label
    Friend WithEvents btnGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gdcAsientoContable As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gdvDetalleAsientoContable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CENTRO_COSTO_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CENTRO_COSTO_CONTAB_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CUENTA_CONTABLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GLOSA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MONTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMonto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents chkSoloCosto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sfdAsientoContable As System.Windows.Forms.SaveFileDialog
    Friend WithEvents rdgTipoProceso As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents USUARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_MODIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ASIENTO_CONTABLE_ID As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpcPeriodo = New DevExpress.XtraEditors.GroupControl
        Me.rdgTipoProceso = New DevExpress.XtraEditors.RadioGroup
        Me.chkSoloCosto = New DevExpress.XtraEditors.CheckEdit
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.btnGenerar = New DevExpress.XtraEditors.SimpleButton
        Me.lblTipoProceso = New System.Windows.Forms.Label
        Me.txtEstadoPeriodo = New DevExpress.XtraEditors.TextEdit
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.gdcAsientoContable = New DevExpress.XtraGrid.GridControl
        Me.gdvDetalleAsientoContable = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.CENTRO_COSTO_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CENTRO_COSTO_CONTAB_DESC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CUENTA_CONTABLE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GLOSA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MONTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtMonto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.USUARIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FECHA_MODIFICACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ASIENTO_CONTABLE_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.sfdAsientoContable = New System.Windows.Forms.SaveFileDialog
        CType(Me.gpcPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcPeriodo.SuspendLayout()
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSoloCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstadoPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcAsientoContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleAsientoContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcPeriodo
        '
        Me.gpcPeriodo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcPeriodo.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcPeriodo.AppearanceCaption.Options.UseFont = True
        Me.gpcPeriodo.Controls.Add(Me.rdgTipoProceso)
        Me.gpcPeriodo.Controls.Add(Me.chkSoloCosto)
        Me.gpcPeriodo.Controls.Add(Me.btnImprimir)
        Me.gpcPeriodo.Controls.Add(Me.btnGenerar)
        Me.gpcPeriodo.Controls.Add(Me.lblTipoProceso)
        Me.gpcPeriodo.Controls.Add(Me.txtEstadoPeriodo)
        Me.gpcPeriodo.Controls.Add(Me.luePeriodo)
        Me.gpcPeriodo.Controls.Add(Me.lblPeriodo)
        Me.gpcPeriodo.Location = New System.Drawing.Point(8, 8)
        Me.gpcPeriodo.Name = "gpcPeriodo"
        Me.gpcPeriodo.Size = New System.Drawing.Size(680, 200)
        Me.gpcPeriodo.TabIndex = 0
        Me.gpcPeriodo.Text = "Periodo"
        '
        'rdgTipoProceso
        '
        Me.rdgTipoProceso.EditValue = "S"
        Me.rdgTipoProceso.Location = New System.Drawing.Point(176, 72)
        Me.rdgTipoProceso.Name = "rdgTipoProceso"
        '
        'rdgTipoProceso.Properties
        '
        Me.rdgTipoProceso.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Sueldos (Planta, Contrata y Honorarios)"), New DevExpress.XtraEditors.Controls.RadioGroupItem("V", "Viáticos")})
        Me.rdgTipoProceso.Size = New System.Drawing.Size(232, 56)
        Me.rdgTipoProceso.TabIndex = 1
        '
        'chkSoloCosto
        '
        Me.chkSoloCosto.EditValue = True
        Me.chkSoloCosto.Location = New System.Drawing.Point(176, 136)
        Me.chkSoloCosto.Name = "chkSoloCosto"
        '
        'chkSoloCosto.Properties
        '
        Me.chkSoloCosto.Properties.Caption = "Incluir Cuentas Solo Costos"
        Me.chkSoloCosto.Size = New System.Drawing.Size(160, 19)
        Me.chkSoloCosto.TabIndex = 2
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(360, 168)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(168, 23)
        Me.btnImprimir.TabIndex = 5
        Me.btnImprimir.Text = "&Visualizar"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(112, 168)
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
        '
        'txtEstadoPeriodo.Properties
        '
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
        '
        'luePeriodo.Properties
        '
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
        'gdcAsientoContable
        '
        Me.gdcAsientoContable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'gdcAsientoContable.EmbeddedNavigator
        '
        Me.gdcAsientoContable.EmbeddedNavigator.Name = ""
        Me.gdcAsientoContable.Location = New System.Drawing.Point(8, 208)
        Me.gdcAsientoContable.MainView = Me.gdvDetalleAsientoContable
        Me.gdcAsientoContable.Name = "gdcAsientoContable"
        Me.gdcAsientoContable.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtMonto})
        Me.gdcAsientoContable.Size = New System.Drawing.Size(680, 264)
        Me.gdcAsientoContable.TabIndex = 1
        Me.gdcAsientoContable.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleAsientoContable, Me.GridView1})
        '
        'gdvDetalleAsientoContable
        '
        Me.gdvDetalleAsientoContable.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvDetalleAsientoContable.Appearance.FooterPanel.Options.UseFont = True
        Me.gdvDetalleAsientoContable.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvDetalleAsientoContable.Appearance.GroupFooter.Options.UseFont = True
        Me.gdvDetalleAsientoContable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.CENTRO_COSTO_ALIAS, Me.CENTRO_COSTO_CONTAB_DESC, Me.CUENTA_CONTABLE, Me.GLOSA, Me.MONTO, Me.USUARIO, Me.FECHA_MODIFICACION, Me.ASIENTO_CONTABLE_ID})
        Me.gdvDetalleAsientoContable.GridControl = Me.gdcAsientoContable
        Me.gdvDetalleAsientoContable.GroupCount = 1
        Me.gdvDetalleAsientoContable.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MONTO", Me.MONTO, "Subtotal Centro Costo=          {0:n0}", 1)})
        Me.gdvDetalleAsientoContable.Name = "gdvDetalleAsientoContable"
        Me.gdvDetalleAsientoContable.OptionsView.ShowFooter = True
        Me.gdvDetalleAsientoContable.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.CENTRO_COSTO_CONTAB_DESC, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.CUENTA_CONTABLE, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'CENTRO_COSTO_ALIAS
        '
        Me.CENTRO_COSTO_ALIAS.Caption = "Código Centro Costo"
        Me.CENTRO_COSTO_ALIAS.FieldName = "CENTRO_COSTO_ALIAS"
        Me.CENTRO_COSTO_ALIAS.Name = "CENTRO_COSTO_ALIAS"
        Me.CENTRO_COSTO_ALIAS.OptionsColumn.ReadOnly = True
        Me.CENTRO_COSTO_ALIAS.Visible = True
        Me.CENTRO_COSTO_ALIAS.VisibleIndex = 0
        '
        'CENTRO_COSTO_CONTAB_DESC
        '
        Me.CENTRO_COSTO_CONTAB_DESC.Caption = "Centro Costo"
        Me.CENTRO_COSTO_CONTAB_DESC.FieldName = "CENTRO_COSTO_CONTAB_DESC"
        Me.CENTRO_COSTO_CONTAB_DESC.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value
        Me.CENTRO_COSTO_CONTAB_DESC.Name = "CENTRO_COSTO_CONTAB_DESC"
        Me.CENTRO_COSTO_CONTAB_DESC.OptionsColumn.ReadOnly = True
        Me.CENTRO_COSTO_CONTAB_DESC.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        '
        'CUENTA_CONTABLE
        '
        Me.CUENTA_CONTABLE.Caption = "Cuenta Contable"
        Me.CUENTA_CONTABLE.FieldName = "CUENTA_CONTABLE"
        Me.CUENTA_CONTABLE.Name = "CUENTA_CONTABLE"
        Me.CUENTA_CONTABLE.OptionsColumn.ReadOnly = True
        Me.CUENTA_CONTABLE.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.CUENTA_CONTABLE.Visible = True
        Me.CUENTA_CONTABLE.VisibleIndex = 1
        '
        'GLOSA
        '
        Me.GLOSA.Caption = "Glosa"
        Me.GLOSA.FieldName = "GLOSA"
        Me.GLOSA.Name = "GLOSA"
        Me.GLOSA.OptionsColumn.ReadOnly = True
        Me.GLOSA.Visible = True
        Me.GLOSA.VisibleIndex = 2
        '
        'MONTO
        '
        Me.MONTO.Caption = "Monto"
        Me.MONTO.ColumnEdit = Me.txtMonto
        Me.MONTO.DisplayFormat.FormatString = "0"
        Me.MONTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MONTO.FieldName = "MONTO"
        Me.MONTO.Name = "MONTO"
        Me.MONTO.OptionsColumn.ReadOnly = True
        Me.MONTO.SummaryItem.DisplayFormat = "Total General: {0:n0}"
        Me.MONTO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.MONTO.Visible = True
        Me.MONTO.VisibleIndex = 3
        '
        'txtMonto
        '
        Me.txtMonto.AutoHeight = False
        Me.txtMonto.DisplayFormat.FormatString = "n0"
        Me.txtMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.EditFormat.FormatString = "0"
        Me.txtMonto.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.Mask.EditMask = "n0"
        Me.txtMonto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMonto.Mask.UseMaskAsDisplayFormat = True
        Me.txtMonto.Name = "txtMonto"
        '
        'USUARIO
        '
        Me.USUARIO.Caption = "Usuario"
        Me.USUARIO.FieldName = "USUARIO"
        Me.USUARIO.Name = "USUARIO"
        Me.USUARIO.OptionsColumn.ReadOnly = True
        '
        'FECHA_MODIFICACION
        '
        Me.FECHA_MODIFICACION.Caption = "Fecha Creación"
        Me.FECHA_MODIFICACION.FieldName = "FECHA_MODIFICACION"
        Me.FECHA_MODIFICACION.Name = "FECHA_MODIFICACION"
        Me.FECHA_MODIFICACION.OptionsColumn.ReadOnly = True
        '
        'ASIENTO_CONTABLE_ID
        '
        Me.ASIENTO_CONTABLE_ID.Caption = "Asiento Contable ID"
        Me.ASIENTO_CONTABLE_ID.FieldName = "ASIENTO_CONTABLE_ID"
        Me.ASIENTO_CONTABLE_ID.Name = "ASIENTO_CONTABLE_ID"
        Me.ASIENTO_CONTABLE_ID.OptionsColumn.ReadOnly = True
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcAsientoContable
        Me.GridView1.Name = "GridView1"
        '
        'frmAsientoContable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(696, 478)
        Me.Controls.Add(Me.gdcAsientoContable)
        Me.Controls.Add(Me.gpcPeriodo)
        Me.Name = "frmAsientoContable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Genera Asiento Contable"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcPeriodo.ResumeLayout(False)
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSoloCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstadoPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcAsientoContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleAsientoContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private estadoPeriodo As Boolean
    Private Periodo As Periodo
    Private Centralizacion As Centralizacion
    Private asientoContableID As Integer

    Private Sub frmAsientoContable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Centralizacion = New Centralizacion
        repositorio.RefreshDatos("Periodo")
        llenarPeriodos()
        btnGenerar.Enabled = False
        btnImprimir.Enabled = False
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
        If Not IsNothing(row) Then
            Periodo = New Periodo(CType(row("PERIODO_ID"), Integer))
            estadoPeriodo = Periodo.estadoPeriodo
            'Si el estado del periodo es 0 (No Activo) deshabilita la grilla
            btnImprimir.Enabled = True
            refrescarDetalle()
            If estadoPeriodo = False Then
                txtEstadoPeriodo.Text = "INACTIVO"
                btnGenerar.Enabled = False
            Else
                txtEstadoPeriodo.Text = "ACTIVO"
                If gdvDetalleAsientoContable.RowCount > 0 And asientoContableID = 0 Then
                    btnGenerar.Enabled = True
                Else
                    btnGenerar.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Dim dsAsiento As New DSAsientoContable
        Dim respuesta As Boolean = False
        Dim msg As String
        If rdgTipoProceso.EditValue = "S" Then
            msg = Periodo.anoMes & " Sueldos."
        Else
            msg = Periodo.anoMes & " Viáticos."
        End If
        If MsgBox("Esta opción solo se puede realizar una vez para el período " & msg & Chr(13) & "Por lo tanto, esta opción no estará desponible para volver a ejecutarse." & Chr(13) & Chr(13) & "¿Continua con la generación del archivo difinitivo del asiento contable?", MsgBoxStyle.OKCancel + MsgBoxStyle.Information) = MsgBoxResult.OK Then
            respuesta = True
        End If

        If respuesta Then
            'Generación documento XML
            Dim XmlDocument As New Xml.XmlDocument
            Dim rutaCarpetaArchivoXML As String
            Try
                With sfdAsientoContable
                    .FileName = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\Asiento Contable Remuneraciones " & msg & ".xml"
                    .Filter = "Archivo XML (*.xml)|*.xml"
                    .DefaultExt = "xml"
                    rutaCarpetaArchivoXML = .FileName
                    If .ShowDialog(Me) = DialogResult.OK Then
                        If rutaCarpetaArchivoXML <> "" Then
                            Cursor.Current = Cursors.WaitCursor
                            'Crea encabezado asiento contable en tabla RH_REM_ASIENTO_CONTABLE
                            asignacionCampos()
                            Centralizacion.encabezadoAsientoContable.asientoContableID = Centralizacion.CrearEncabezado(asientoContableID)
                            'Crea detalle asiento contable en tabla RH_REM_ASIENTO_CONTABLE_DETALLE y posteriormente comienza
                            'a llenar el dataset de la tabla ASIENTO_CONTABLE para generar archivo XML
                            dsAsiento = Centralizacion.recuperarDetalleAsientoContable(Centralizacion.encabezadoAsientoContable.asientoContableID, Periodo.ano, Periodo.mes)
                            XmlDocument.LoadXml(generarXMLAsientoContable(dsAsiento.ASIENTO_CONTABLE))
                            XmlDocument.Save(rutaCarpetaArchivoXML)
                            btnGenerar.Enabled = False
                            Cursor.Current = Cursors.Default
                        End If
                    End If

                End With
            Catch exp As Exception
                MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            XmlDocument = Nothing
            'Fin generación documento XML
        End If
    End Sub
    Private Sub asignacionCampos()
        Centralizacion.encabezadoAsientoContable.periodoID = luePeriodo.EditValue
        Centralizacion.encabezadoAsientoContable.estadoRegistro = 1
        Centralizacion.encabezadoAsientoContable.tipoProceso = rdgTipoProceso.EditValue
        Centralizacion.encabezadoAsientoContable.esCosto = chkSoloCosto.Checked
    End Sub

    Private Function generarXMLAsientoContable(ByVal dt As DataAccess.DSAsientoContable.ASIENTO_CONTABLEDataTable) As String
        Dim ds As DataSet
        ds = New DataSet("AsientoContable")
        ds.Tables.Add(dt.Copy)
        'Las dos siguienes lineas generan la estructura de la tabla ASIENTO_CONTABLE
        'Dim miCarpeta As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal)
        'ds.WriteXmlSchema("c:\estructuraAsientoContable.xsd")
        Return ds.GetXml
    End Function
    Private Sub refrescarDetalle()
        If luePeriodo.EditValue <> Nothing Then
            Cursor.Current = Cursors.WaitCursor
            asientoContableID = 0
            gdcAsientoContable.DataSource = Centralizacion.recuperarAsientoContable(luePeriodo.EditValue, rdgTipoProceso.EditValue, chkSoloCosto.Checked, estadoPeriodo, asientoContableID)
            Cursor.Current = Cursors.Default
            If estadoPeriodo = False Then
                txtEstadoPeriodo.Text = "INACTIVO"
                btnGenerar.Enabled = False
            Else
                txtEstadoPeriodo.Text = "ACTIVO"
                If gdvDetalleAsientoContable.RowCount > 0 And asientoContableID = 0 Then
                    btnGenerar.Enabled = True
                Else
                    btnGenerar.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'PrintableComponentLink1.CreateDocument()
        'PrintableComponentLink1.ShowPreview()
        Dim ventanaReporte1 As New ventanaReporte
        Dim strFormulaSeleccion As String

        If txtEstadoPeriodo.Text = "INACTIVO" Then
            Dim reporte As New rptAsientoContableHistorico
            Try
                WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
                With ventanaReporte1
                    '.rptVisor.DisplayGroupTree = False
                    .rptVisor.ShowGroupTreeButton = False
                    strFormulaSeleccion = "{VW_ASIENTO_CONTABLE.ASIENTO_CONTABLE_ID}=" & asientoContableID
                    strFormulaSeleccion &= " AND {VW_ASIENTO_CONTABLE.TIPO_PROCESO}=" & """" & CType(rdgTipoProceso.EditValue, String).ToString & """"
                    .rptVisor.SelectionFormula = strFormulaSeleccion
                    .rptVisor.ReportSource = reporte
                    .Show()
                End With
            Catch ex As Exception
                MessageBox.Show("Ha ocurrido una excepción:" & ex.Message, "Problema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Dim reporte As New rptAsientoContableRevision
            Dim procesoRemun As String

            If rdgTipoProceso.EditValue = "S" Then
                procesoRemun = "SUELDOS"
            Else
                procesoRemun = "VIATICOS"
            End If

            Try
                WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
                With ventanaReporte1
                    '.rptVisor.DisplayGroupTree = False
                    .rptVisor.ShowGroupTreeButton = False
                    strFormulaSeleccion = "{VW_CENTRALIZACION_CONTABLE.PERIODO_ID}=" & luePeriodo.EditValue
                    strFormulaSeleccion &= " AND {VW_CENTRALIZACION_CONTABLE.PROCESO_REMUNERACION}=" & """" & CType(procesoRemun, String).ToString & """"

                    If chkSoloCosto.Checked Then
                        strFormulaSeleccion &= " AND {VW_CENTRALIZACION_CONTABLE.ES_COSTO}"
                    End If

                    .rptVisor.SelectionFormula = strFormulaSeleccion
                    .rptVisor.ReportSource = reporte
                    .Show()
                End With
            Catch ex As Exception
                MessageBox.Show("Ha ocurrido una excepción:" & ex.Message, "Problema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs)
        Dim reportHeader As String = "Período : " & Periodo.anoMes
        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)
    End Sub

    Private Sub rdgTipoProceso_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdgTipoProceso.EditValueChanged
        If rdgTipoProceso.EditValue <> Nothing Then
            refrescarDetalle()
        End If
    End Sub

    Private Sub chkSoloCosto_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSoloCosto.EditValueChanged
        If chkSoloCosto.Checked <> Nothing Then
            refrescarDetalle()
        End If
    End Sub
End Class
