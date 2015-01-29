Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Reportes
Imports DevExpress.XtraEditors.Controls

Public Class frmEnviarTesoreria
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
    Friend WithEvents txtEstadoPeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents gpcBotones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnEnviarTesoreria As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gdcDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_COMPLETO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLIQUIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_FORMA_PAGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_DEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMontoLiquido As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents chkExpandirGrupos As DevExpress.XtraEditors.CheckEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpcFiltros = New DevExpress.XtraEditors.GroupControl
        Me.chkExpandirGrupos = New DevExpress.XtraEditors.CheckEdit
        Me.txtEstadoPeriodo = New DevExpress.XtraEditors.TextEdit
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.gpcBotones = New DevExpress.XtraEditors.GroupControl
        Me.btnEnviarTesoreria = New DevExpress.XtraEditors.SimpleButton
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.gdcDetalle = New DevExpress.XtraGrid.GridControl
        Me.gdvDetalle = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colEMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_COMPLETO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLIQUIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtMontoLiquido = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colNOMBRE_FORMA_PAGO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_DEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.gpcFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcFiltros.SuspendLayout()
        CType(Me.chkExpandirGrupos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstadoPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBotones.SuspendLayout()
        CType(Me.gdcDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoLiquido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcFiltros
        '
        Me.gpcFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcFiltros.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcFiltros.AppearanceCaption.Options.UseFont = True
        Me.gpcFiltros.Controls.Add(Me.chkExpandirGrupos)
        Me.gpcFiltros.Controls.Add(Me.txtEstadoPeriodo)
        Me.gpcFiltros.Controls.Add(Me.luePeriodo)
        Me.gpcFiltros.Controls.Add(Me.lblPeriodo)
        Me.gpcFiltros.Location = New System.Drawing.Point(0, 0)
        Me.gpcFiltros.Name = "gpcFiltros"
        Me.gpcFiltros.Size = New System.Drawing.Size(648, 88)
        Me.gpcFiltros.TabIndex = 0
        Me.gpcFiltros.Text = "Filtro Período"
        '
        'chkExpandirGrupos
        '
        Me.chkExpandirGrupos.Location = New System.Drawing.Point(488, 32)
        Me.chkExpandirGrupos.Name = "chkExpandirGrupos"
        '
        'chkExpandirGrupos.Properties
        '
        Me.chkExpandirGrupos.Properties.Caption = "Expandir Grupos"
        Me.chkExpandirGrupos.Size = New System.Drawing.Size(112, 19)
        Me.chkExpandirGrupos.TabIndex = 11
        '
        'txtEstadoPeriodo
        '
        Me.txtEstadoPeriodo.Enabled = False
        Me.txtEstadoPeriodo.Location = New System.Drawing.Point(360, 32)
        Me.txtEstadoPeriodo.Name = "txtEstadoPeriodo"
        '
        'txtEstadoPeriodo.Properties
        '
        Me.txtEstadoPeriodo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtEstadoPeriodo.Properties.Appearance.Options.UseFont = True
        Me.txtEstadoPeriodo.Size = New System.Drawing.Size(112, 20)
        Me.txtEstadoPeriodo.TabIndex = 10
        '
        'luePeriodo
        '
        Me.luePeriodo.EnterMoveNextControl = True
        Me.luePeriodo.Location = New System.Drawing.Point(232, 32)
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
        Me.lblPeriodo.Location = New System.Drawing.Point(176, 36)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 16)
        Me.lblPeriodo.TabIndex = 9
        Me.lblPeriodo.Text = "Período"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gpcBotones
        '
        Me.gpcBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcBotones.Controls.Add(Me.btnEnviarTesoreria)
        Me.gpcBotones.Controls.Add(Me.btnImprimir)
        Me.gpcBotones.Location = New System.Drawing.Point(0, 88)
        Me.gpcBotones.Name = "gpcBotones"
        Me.gpcBotones.ShowCaption = False
        Me.gpcBotones.Size = New System.Drawing.Size(656, 48)
        Me.gpcBotones.TabIndex = 1
        Me.gpcBotones.Text = "Botones"
        '
        'btnEnviarTesoreria
        '
        Me.btnEnviarTesoreria.Location = New System.Drawing.Point(276, 13)
        Me.btnEnviarTesoreria.Name = "btnEnviarTesoreria"
        Me.btnEnviarTesoreria.Size = New System.Drawing.Size(104, 23)
        Me.btnEnviarTesoreria.TabIndex = 1
        Me.btnEnviarTesoreria.Text = "Enviar a Tesoreria"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(160, 13)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(104, 23)
        Me.btnImprimir.TabIndex = 0
        Me.btnImprimir.Text = "Imprimir"
        '
        'gdcDetalle
        '
        Me.gdcDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'gdcDetalle.EmbeddedNavigator
        '
        Me.gdcDetalle.EmbeddedNavigator.Name = ""
        Me.gdcDetalle.Location = New System.Drawing.Point(0, 136)
        Me.gdcDetalle.MainView = Me.gdvDetalle
        Me.gdcDetalle.Name = "gdcDetalle"
        Me.gdcDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtMontoLiquido})
        Me.gdcDetalle.Size = New System.Drawing.Size(648, 232)
        Me.gdcDetalle.TabIndex = 2
        Me.gdcDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalle})
        '
        'gdvDetalle
        '
        Me.gdvDetalle.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvDetalle.Appearance.FooterPanel.Options.UseFont = True
        Me.gdvDetalle.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvDetalle.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Blue
        Me.gdvDetalle.Appearance.GroupFooter.Options.UseFont = True
        Me.gdvDetalle.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gdvDetalle.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvDetalle.Appearance.GroupRow.Options.UseFont = True
        Me.gdvDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEMPLEADO_ID, Me.colNOMBRE_COMPLETO, Me.colLIQUIDO, Me.colNOMBRE_FORMA_PAGO, Me.colNOMBRE_DEPARTAMENTO})
        Me.gdvDetalle.GridControl = Me.gdcDetalle
        Me.gdvDetalle.GroupCount = 1
        Me.gdvDetalle.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LIQUIDO", Me.colLIQUIDO, "Subtotal Departamento: {0:n0}", 1)})
        Me.gdvDetalle.Name = "gdvDetalle"
        Me.gdvDetalle.OptionsView.ColumnAutoWidth = False
        Me.gdvDetalle.OptionsView.ShowFooter = True
        Me.gdvDetalle.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNOMBRE_DEPARTAMENTO, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colEMPLEADO_ID
        '
        Me.colEMPLEADO_ID.Caption = "Empleado Id"
        Me.colEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.colEMPLEADO_ID.Name = "colEMPLEADO_ID"
        Me.colEMPLEADO_ID.OptionsColumn.AllowEdit = False
        Me.colEMPLEADO_ID.OptionsColumn.AllowMove = False
        Me.colEMPLEADO_ID.OptionsColumn.ReadOnly = True
        '
        'colNOMBRE_COMPLETO
        '
        Me.colNOMBRE_COMPLETO.Caption = "Nombre Funcionario"
        Me.colNOMBRE_COMPLETO.FieldName = "NOMBRE_COMPLETO"
        Me.colNOMBRE_COMPLETO.Name = "colNOMBRE_COMPLETO"
        Me.colNOMBRE_COMPLETO.OptionsColumn.AllowEdit = False
        Me.colNOMBRE_COMPLETO.OptionsColumn.AllowMove = False
        Me.colNOMBRE_COMPLETO.OptionsColumn.ReadOnly = True
        Me.colNOMBRE_COMPLETO.Visible = True
        Me.colNOMBRE_COMPLETO.VisibleIndex = 0
        Me.colNOMBRE_COMPLETO.Width = 360
        '
        'colLIQUIDO
        '
        Me.colLIQUIDO.Caption = "Monto"
        Me.colLIQUIDO.ColumnEdit = Me.txtMontoLiquido
        Me.colLIQUIDO.FieldName = "LIQUIDO"
        Me.colLIQUIDO.Name = "colLIQUIDO"
        Me.colLIQUIDO.OptionsColumn.AllowEdit = False
        Me.colLIQUIDO.OptionsColumn.AllowMove = False
        Me.colLIQUIDO.OptionsColumn.ReadOnly = True
        Me.colLIQUIDO.SummaryItem.DisplayFormat = "Total General: {0:n0}"
        Me.colLIQUIDO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colLIQUIDO.Visible = True
        Me.colLIQUIDO.VisibleIndex = 1
        Me.colLIQUIDO.Width = 268
        '
        'txtMontoLiquido
        '
        Me.txtMontoLiquido.AutoHeight = False
        Me.txtMontoLiquido.DisplayFormat.FormatString = "n0"
        Me.txtMontoLiquido.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoLiquido.EditFormat.FormatString = "n0"
        Me.txtMontoLiquido.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoLiquido.Name = "txtMontoLiquido"
        '
        'colNOMBRE_FORMA_PAGO
        '
        Me.colNOMBRE_FORMA_PAGO.Caption = "Forma Pago"
        Me.colNOMBRE_FORMA_PAGO.FieldName = "NOMBRE_FORMA_PAGO"
        Me.colNOMBRE_FORMA_PAGO.Name = "colNOMBRE_FORMA_PAGO"
        Me.colNOMBRE_FORMA_PAGO.OptionsColumn.AllowEdit = False
        Me.colNOMBRE_FORMA_PAGO.OptionsColumn.AllowMove = False
        Me.colNOMBRE_FORMA_PAGO.OptionsColumn.ReadOnly = True
        Me.colNOMBRE_FORMA_PAGO.Visible = True
        Me.colNOMBRE_FORMA_PAGO.VisibleIndex = 2
        Me.colNOMBRE_FORMA_PAGO.Width = 164
        '
        'colNOMBRE_DEPARTAMENTO
        '
        Me.colNOMBRE_DEPARTAMENTO.Caption = "Departamento"
        Me.colNOMBRE_DEPARTAMENTO.FieldName = "NOMBRE_DEPARTAMENTO"
        Me.colNOMBRE_DEPARTAMENTO.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value
        Me.colNOMBRE_DEPARTAMENTO.Name = "colNOMBRE_DEPARTAMENTO"
        Me.colNOMBRE_DEPARTAMENTO.OptionsColumn.AllowEdit = False
        Me.colNOMBRE_DEPARTAMENTO.OptionsColumn.AllowMove = False
        Me.colNOMBRE_DEPARTAMENTO.OptionsColumn.ReadOnly = True
        Me.colNOMBRE_DEPARTAMENTO.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colNOMBRE_DEPARTAMENTO.Visible = True
        Me.colNOMBRE_DEPARTAMENTO.VisibleIndex = 3
        Me.colNOMBRE_DEPARTAMENTO.Width = 317
        '
        'frmEnviarTesoreria
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 370)
        Me.Controls.Add(Me.gdcDetalle)
        Me.Controls.Add(Me.gpcBotones)
        Me.Controls.Add(Me.gpcFiltros)
        Me.Name = "frmEnviarTesoreria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enviar Información de Honorarios a Tesoreria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcFiltros.ResumeLayout(False)
        CType(Me.chkExpandirGrupos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstadoPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBotones.ResumeLayout(False)
        CType(Me.gdcDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoLiquido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Periodo As Periodo
    Private empleado As New empleado

    Private Enum tipoProceso
        PLATA_CONTRATA = 0
        HONORARIOS = 1
    End Enum

    Private Sub frmEnviarTesoreria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnImprimir.Enabled = False
        btnEnviarTesoreria.Enabled = False
        repositorio.RefreshDatos("Periodo")
        llenarPeriodos()
        chkExpandirGrupos.Checked = True
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
            refrescarDetalle()
            If Periodo.estadoPeriodo = False Then
                txtEstadoPeriodo.Text = "INACTIVO"
            Else
                txtEstadoPeriodo.Text = "ACTIVO"
            End If
        End If
    End Sub

    Private Sub refrescarDetalle()
        If Periodo.estadoPeriodo = True And Periodo.honorariosEnviadoTesoreria = False Then
            gdcDetalle.DataSource = empleado.recuperarHonorariosNoEnviadosTesoreria(Periodo.ID, tipoProceso.HONORARIOS)
            btnEnviarTesoreria.Enabled = True
        Else
            gdcDetalle.DataSource = empleado.recuperarHonorariosEnviadosTesoreria(Periodo.ID, tipoProceso.HONORARIOS)
            btnEnviarTesoreria.Enabled = False
        End If
        ExpadirColapsarGrupos()
        If gdvDetalle.RowCount > 0 Then
            btnImprimir.Enabled = True
        Else
            btnImprimir.Enabled = False
        End If
    End Sub

    Private Sub chkExpandirGrupos_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkExpandirGrupos.EditValueChanged
        ExpadirColapsarGrupos()
    End Sub

    Private Sub ExpadirColapsarGrupos()
        If Me.chkExpandirGrupos.Checked = True Then
            gdvDetalle.ExpandAllGroups()
        Else
            gdvDetalle.CollapseAllGroups()
        End If
    End Sub

    Private Sub btnEnviarTesoreria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarTesoreria.Click
        If MsgBox("Esta opción solo se puede realizar una vez para el período." & Chr(13) & "Por lo tanto, esta opción no estará desponible para volver a ejecutarse." & Chr(13) & Chr(13) & "¿Desea enviar esta información a Tesoreria?", MsgBoxStyle.OKCancel + MsgBoxStyle.Information) = MsgBoxResult.Cancel Then
            Exit Sub
        End If
        If empleado.enviarHonorariosTesoreria(Periodo.ID, tipoProceso.HONORARIOS) = True Then
            Dim idPeriodo As Integer = Periodo.ID
            Periodo = New Periodo(CType(idPeriodo, Integer))
            refrescarDetalle()
            MsgBox("Se envió correctamente la información a tesoreria", MsgBoxStyle.OKCancel + MsgBoxStyle.Information, Comun.ArgoConfiguracion.applicationName)
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If Me.gdvDetalle.RowCount > 0 Then
            Dim ventanaReporte1 As New ventanaReporte
            Dim reporte As New rptLiquidoPago
            Cursor.Current = Cursors.WaitCursor
            WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
            Dim strFormulaSeleccion As String = "{VW_LIQUIDO_A_PAGO.PERIODO_ID}=" & Me.luePeriodo.EditValue & " AND {VW_LIQUIDO_A_PAGO.CALIDAD_JURIDICA_ID}=5"
            'strFormulaSeleccion &= " AND {VW_RH_PER_HORAS_EXTRAS.TIPO_PROCESO}=""" & rdgTipoProceso.EditValue & """"
            reporte.SummaryInfo.ReportTitle = "Liquido a Pago"
            ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
            ventanaReporte1.rptVisor.ShowParameterPanelButton = False
            ventanaReporte1.rptVisor.ShowCloseButton = False
            ventanaReporte1.rptVisor.ShowGroupTreeButton = False
            ventanaReporte1.rptVisor.ReportSource = reporte
            Cursor.Current = Cursors.Default
            ventanaReporte1.Show()
        End If
    End Sub
End Class
