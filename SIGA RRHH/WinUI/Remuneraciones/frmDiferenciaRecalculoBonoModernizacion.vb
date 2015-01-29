Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Windows.Forms
Imports System.Drawing
Imports System

Public Class frmDiferenciaRecalculoBonoModernizacion
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
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents dvItem As System.Data.DataView
    Friend WithEvents dvPeriodo As System.Data.DataView
    Friend WithEvents gdcDetalleItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvitems As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueItems As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtEstadoPeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents gleRut As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dvEmpleadosBono As System.Data.DataView
    Friend WithEvents btnTraspasaDiferencias As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RELIQUIDACION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ITEM_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MONTO_HISTORICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MONTO_RELIQUIDADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIFERENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PERIODO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ITEM_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TRASPASA_DIFERENCIA_MOVTO_MENSUAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ANO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CANTIDAD_HISTORICA As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents CANTIDAD_RELIQUIDADA As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents CANTIDAD_DIFERENCIA As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnTraspasaTodosEmpleados As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.DIFERENCIA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CANTIDAD_DIFERENCIA = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.TRASPASA_DIFERENCIA_MOVTO_MENSUAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gpcEncabezado = New DevExpress.XtraEditors.GroupControl
        Me.btnTraspasaDiferencias = New DevExpress.XtraEditors.SimpleButton
        Me.gleRut = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.txtEstadoPeriodo = New DevExpress.XtraEditors.TextEdit
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.lblEmpleado = New System.Windows.Forms.Label
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.dvItem = New System.Data.DataView
        Me.dvPeriodo = New System.Data.DataView
        Me.gdcDetalleItems = New DevExpress.XtraGrid.GridControl
        Me.gdvitems = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RELIQUIDACION_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ANO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MES = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ITEM_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ITEM_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.EMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MONTO_HISTORICO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CANTIDAD_HISTORICA = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.MONTO_RELIQUIDADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CANTIDAD_RELIQUIDADA = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.PERIODO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dvEmpleadosBono = New System.Data.DataView
        Me.btnTraspasaTodosEmpleados = New DevExpress.XtraEditors.SimpleButton
        CType(Me.CANTIDAD_DIFERENCIA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcEncabezado.SuspendLayout()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstadoPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcDetalleItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvitems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANTIDAD_HISTORICA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANTIDAD_RELIQUIDADA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEmpleadosBono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DIFERENCIA
        '
        Me.DIFERENCIA.Caption = "Diferencia"
        Me.DIFERENCIA.ColumnEdit = Me.CANTIDAD_DIFERENCIA
        Me.DIFERENCIA.FieldName = "DIFERENCIA"
        Me.DIFERENCIA.Name = "DIFERENCIA"
        Me.DIFERENCIA.OptionsColumn.ReadOnly = True
        Me.DIFERENCIA.Visible = True
        Me.DIFERENCIA.VisibleIndex = 6
        Me.DIFERENCIA.Width = 96
        '
        'CANTIDAD_DIFERENCIA
        '
        Me.CANTIDAD_DIFERENCIA.AutoHeight = False
        Me.CANTIDAD_DIFERENCIA.DisplayFormat.FormatString = "n0"
        Me.CANTIDAD_DIFERENCIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CANTIDAD_DIFERENCIA.Name = "CANTIDAD_DIFERENCIA"
        '
        'TRASPASA_DIFERENCIA_MOVTO_MENSUAL
        '
        Me.TRASPASA_DIFERENCIA_MOVTO_MENSUAL.Caption = "Traspasa a Movto.Mensual"
        Me.TRASPASA_DIFERENCIA_MOVTO_MENSUAL.FieldName = "TRASPASA_DIFERENCIA_MOVTO_MENSUAL"
        Me.TRASPASA_DIFERENCIA_MOVTO_MENSUAL.Name = "TRASPASA_DIFERENCIA_MOVTO_MENSUAL"
        Me.TRASPASA_DIFERENCIA_MOVTO_MENSUAL.OptionsColumn.ReadOnly = True
        Me.TRASPASA_DIFERENCIA_MOVTO_MENSUAL.Width = 70
        '
        'gpcEncabezado
        '
        Me.gpcEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcEncabezado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcEncabezado.AppearanceCaption.Options.UseFont = True
        Me.gpcEncabezado.Controls.Add(Me.btnTraspasaTodosEmpleados)
        Me.gpcEncabezado.Controls.Add(Me.btnTraspasaDiferencias)
        Me.gpcEncabezado.Controls.Add(Me.gleRut)
        Me.gpcEncabezado.Controls.Add(Me.txtEstadoPeriodo)
        Me.gpcEncabezado.Controls.Add(Me.luePeriodo)
        Me.gpcEncabezado.Controls.Add(Me.lblEmpleado)
        Me.gpcEncabezado.Controls.Add(Me.lblPeriodo)
        Me.gpcEncabezado.Location = New System.Drawing.Point(16, 16)
        Me.gpcEncabezado.Name = "gpcEncabezado"
        Me.gpcEncabezado.Size = New System.Drawing.Size(768, 104)
        Me.gpcEncabezado.TabIndex = 0
        Me.gpcEncabezado.Text = "Período"
        '
        'btnTraspasaDiferencias
        '
        Me.btnTraspasaDiferencias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTraspasaDiferencias.Location = New System.Drawing.Point(488, 32)
        Me.btnTraspasaDiferencias.Name = "btnTraspasaDiferencias"
        Me.btnTraspasaDiferencias.Size = New System.Drawing.Size(248, 23)
        Me.btnTraspasaDiferencias.TabIndex = 10
        Me.btnTraspasaDiferencias.Text = "&Traspasa Diferencias Empleado Actual"
        '
        'gleRut
        '
        Me.gleRut.EditValue = ""
        Me.gleRut.Location = New System.Drawing.Point(120, 64)
        Me.gleRut.Name = "gleRut"
        '
        'gleRut.Properties
        '
        Me.gleRut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleRut.Properties.NullText = ""
        Me.gleRut.Properties.View = Me.GridLookUpEdit1View
        Me.gleRut.Size = New System.Drawing.Size(352, 20)
        Me.gleRut.TabIndex = 5
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtEstadoPeriodo
        '
        Me.txtEstadoPeriodo.Enabled = False
        Me.txtEstadoPeriodo.Location = New System.Drawing.Point(296, 32)
        Me.txtEstadoPeriodo.Name = "txtEstadoPeriodo"
        '
        'txtEstadoPeriodo.Properties
        '
        Me.txtEstadoPeriodo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtEstadoPeriodo.Properties.Appearance.Options.UseFont = True
        Me.txtEstadoPeriodo.Size = New System.Drawing.Size(176, 20)
        Me.txtEstadoPeriodo.TabIndex = 4
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(120, 32)
        Me.luePeriodo.Name = "luePeriodo"
        '
        'luePeriodo.Properties
        '
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(160, 20)
        Me.luePeriodo.TabIndex = 2
        '
        'lblEmpleado
        '
        Me.lblEmpleado.Location = New System.Drawing.Point(40, 64)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(64, 16)
        Me.lblEmpleado.TabIndex = 1
        Me.lblEmpleado.Text = "Empleado"
        Me.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(56, 32)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 16)
        Me.lblPeriodo.TabIndex = 0
        Me.lblPeriodo.Text = "Período"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gdcDetalleItems
        '
        Me.gdcDetalleItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'gdcDetalleItems.EmbeddedNavigator
        '
        Me.gdcDetalleItems.EmbeddedNavigator.Name = ""
        Me.gdcDetalleItems.Location = New System.Drawing.Point(16, 128)
        Me.gdcDetalleItems.MainView = Me.gdvitems
        Me.gdcDetalleItems.Name = "gdcDetalleItems"
        Me.gdcDetalleItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CANTIDAD_HISTORICA, Me.CANTIDAD_RELIQUIDADA, Me.CANTIDAD_DIFERENCIA})
        Me.gdcDetalleItems.Size = New System.Drawing.Size(768, 424)
        Me.gdcDetalleItems.TabIndex = 1
        Me.gdcDetalleItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvitems})
        '
        'gdvitems
        '
        Me.gdvitems.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvitems.Appearance.FooterPanel.Options.UseFont = True
        Me.gdvitems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.RELIQUIDACION_ID, Me.ANO, Me.MES, Me.ITEM_ID, Me.ITEM_ALIAS, Me.EMPLEADO_ID, Me.DESCRIPCION, Me.MONTO_HISTORICO, Me.MONTO_RELIQUIDADO, Me.DIFERENCIA, Me.PERIODO_ID, Me.TRASPASA_DIFERENCIA_MOVTO_MENSUAL})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.DIFERENCIA
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Blue
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.TRASPASA_DIFERENCIA_MOVTO_MENSUAL
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = True
        Me.gdvitems.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.gdvitems.GridControl = Me.gdcDetalleItems
        Me.gdvitems.Name = "gdvitems"
        'Me.gdvitems.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValesMode.Disabled
        Me.gdvitems.OptionsNavigation.EnterMoveNextColumn = True
        Me.gdvitems.OptionsSelection.MultiSelect = True
        Me.gdvitems.OptionsView.ColumnAutoWidth = False
        Me.gdvitems.OptionsView.ShowFooter = True
        Me.gdvitems.OptionsView.ShowGroupPanel = False
        '
        'RELIQUIDACION_ID
        '
        Me.RELIQUIDACION_ID.Caption = "ID Reliquidación"
        Me.RELIQUIDACION_ID.FieldName = "RELIQUIDACION_ID"
        Me.RELIQUIDACION_ID.Name = "RELIQUIDACION_ID"
        Me.RELIQUIDACION_ID.OptionsColumn.ReadOnly = True
        '
        'ANO
        '
        Me.ANO.Caption = "Año"
        Me.ANO.FieldName = "ANO"
        Me.ANO.Name = "ANO"
        Me.ANO.OptionsColumn.ReadOnly = True
        Me.ANO.Visible = True
        Me.ANO.VisibleIndex = 0
        '
        'MES
        '
        Me.MES.Caption = "Mes"
        Me.MES.FieldName = "MES"
        Me.MES.Name = "MES"
        Me.MES.OptionsColumn.ReadOnly = True
        Me.MES.Visible = True
        Me.MES.VisibleIndex = 1
        Me.MES.Width = 50
        '
        'ITEM_ID
        '
        Me.ITEM_ID.Caption = "ID Item"
        Me.ITEM_ID.FieldName = "ITEM_ID"
        Me.ITEM_ID.Name = "ITEM_ID"
        Me.ITEM_ID.OptionsColumn.ReadOnly = True
        Me.ITEM_ID.Width = 82
        '
        'ITEM_ALIAS
        '
        Me.ITEM_ALIAS.Caption = "Ítem"
        Me.ITEM_ALIAS.FieldName = "ITEM_ALIAS"
        Me.ITEM_ALIAS.Name = "ITEM_ALIAS"
        Me.ITEM_ALIAS.OptionsColumn.ReadOnly = True
        Me.ITEM_ALIAS.Visible = True
        Me.ITEM_ALIAS.VisibleIndex = 2
        Me.ITEM_ALIAS.Width = 116
        '
        'EMPLEADO_ID
        '
        Me.EMPLEADO_ID.Caption = "Empleado"
        Me.EMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.EMPLEADO_ID.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.EMPLEADO_ID.Name = "EMPLEADO_ID"
        Me.EMPLEADO_ID.OptionsColumn.ReadOnly = True
        Me.EMPLEADO_ID.Width = 100
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.Caption = "Descripción"
        Me.DESCRIPCION.FieldName = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.OptionsColumn.ReadOnly = True
        Me.DESCRIPCION.Visible = True
        Me.DESCRIPCION.VisibleIndex = 3
        Me.DESCRIPCION.Width = 247
        '
        'MONTO_HISTORICO
        '
        Me.MONTO_HISTORICO.Caption = "Monto Histórico"
        Me.MONTO_HISTORICO.ColumnEdit = Me.CANTIDAD_HISTORICA
        Me.MONTO_HISTORICO.FieldName = "MONTO_HISTORICO"
        Me.MONTO_HISTORICO.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.MONTO_HISTORICO.Name = "MONTO_HISTORICO"
        Me.MONTO_HISTORICO.OptionsColumn.ReadOnly = True
        Me.MONTO_HISTORICO.UnboundType = DevExpress.Data.UnboundColumnType.Integer
        Me.MONTO_HISTORICO.Visible = True
        Me.MONTO_HISTORICO.VisibleIndex = 4
        Me.MONTO_HISTORICO.Width = 107
        '
        'CANTIDAD_HISTORICA
        '
        Me.CANTIDAD_HISTORICA.AutoHeight = False
        Me.CANTIDAD_HISTORICA.DisplayFormat.FormatString = "n0"
        Me.CANTIDAD_HISTORICA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CANTIDAD_HISTORICA.Name = "CANTIDAD_HISTORICA"
        '
        'MONTO_RELIQUIDADO
        '
        Me.MONTO_RELIQUIDADO.Caption = "Monto Reliq."
        Me.MONTO_RELIQUIDADO.ColumnEdit = Me.CANTIDAD_RELIQUIDADA
        Me.MONTO_RELIQUIDADO.FieldName = "MONTO_RELIQUIDADO"
        Me.MONTO_RELIQUIDADO.Name = "MONTO_RELIQUIDADO"
        Me.MONTO_RELIQUIDADO.OptionsColumn.ReadOnly = True
        Me.MONTO_RELIQUIDADO.Visible = True
        Me.MONTO_RELIQUIDADO.VisibleIndex = 5
        Me.MONTO_RELIQUIDADO.Width = 111
        '
        'CANTIDAD_RELIQUIDADA
        '
        Me.CANTIDAD_RELIQUIDADA.AutoHeight = False
        Me.CANTIDAD_RELIQUIDADA.DisplayFormat.FormatString = "n0"
        Me.CANTIDAD_RELIQUIDADA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CANTIDAD_RELIQUIDADA.Name = "CANTIDAD_RELIQUIDADA"
        '
        'PERIODO_ID
        '
        Me.PERIODO_ID.Caption = "ID Periodo"
        Me.PERIODO_ID.FieldName = "PERIODO_ID"
        Me.PERIODO_ID.Name = "PERIODO_ID"
        Me.PERIODO_ID.OptionsColumn.ReadOnly = True
        Me.PERIODO_ID.Width = 42
        '
        'btnTraspasaTodosEmpleados
        '
        Me.btnTraspasaTodosEmpleados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTraspasaTodosEmpleados.Location = New System.Drawing.Point(488, 64)
        Me.btnTraspasaTodosEmpleados.Name = "btnTraspasaTodosEmpleados"
        Me.btnTraspasaTodosEmpleados.Size = New System.Drawing.Size(248, 23)
        Me.btnTraspasaTodosEmpleados.TabIndex = 11
        Me.btnTraspasaTodosEmpleados.Text = "Traspasa &Diferencias de Todos los Empleados"
        '
        'frmBonoModernizacionDetalle
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 558)
        Me.Controls.Add(Me.gdcDetalleItems)
        Me.Controls.Add(Me.gpcEncabezado)
        Me.Name = "frmBonoModernizacionDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reliquidación Bono Modernidad"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CANTIDAD_DIFERENCIA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcEncabezado.ResumeLayout(False)
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstadoPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcDetalleItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvitems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANTIDAD_HISTORICA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANTIDAD_RELIQUIDADA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEmpleadosBono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim empleado As Empleado
    Dim parametroMensual, periodoActual As Periodo

    Private Sub frmMantencionItemPeriodo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        parametroMensual = New Periodo
        periodoActual = parametroMensual
        empleado = New Empleado
        GeneraDataViews()
        llenarPeriodos()
        gdcDetalleItems.Enabled = False
        btnTraspasaDiferencias.Enabled = False
        btnTraspasaTodosEmpleados.Enabled = False
    End Sub
    Public Sub llenarEmpleado()
        If luePeriodo.EditValue = Nothing Then
            Exit Sub
        End If
        Dim da As SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
        Dim ds1 As New DataSet
        Dim sql As String = "SELECT DISTINCT EMPLEADO_ID,RUT, DV, NOMBRE_EMPLEADO" & _
                            " FROM " & Tablas.RH_REM_RELIQUIDACION & " WHERE TIPO_PROCESO='R' AND PERIODO_ID=" & luePeriodo.EditValue & _
                            " ORDER BY NOMBRE_EMPLEADO"

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(sql, conn))
        da.Fill(ds1, Tablas.RH_REM_RELIQUIDACION)
        Dim dvmEmpleadosBono As New DataViewManager(ds1)
        dvEmpleadosBono = dvmEmpleadosBono.CreateDataView(ds1.Tables(Tablas.RH_REM_RELIQUIDACION))

        gleRut.Properties.ViewType = Repository.GridLookUpViewType.GridView
        gleRut.Properties.View.OptionsBehavior.AutoPopulateColumns = False
        gleRut.Properties.DataSource = dvEmpleadosBono
        gleRut.Properties.DisplayMember = "NOMBRE_EMPLEADO"

        Dim col1 As GridColumn = gleRut.Properties.View.Columns.AddField("NOMBRE_EMPLEADO")
        col1.VisibleIndex = 0
        col1.Caption = "Nombre Completo"

        Dim col2 As GridColumn = gleRut.Properties.View.Columns.AddField("RUT")
        col2.VisibleIndex = 1
        col2.Caption = "RUT"

        Dim col3 As GridColumn = gleRut.Properties.View.Columns.AddField("DV")
        col3.VisibleIndex = 2
        col3.Caption = "DV"

        gleRut.Properties.ValueMember = "EMPLEADO_ID"

        gleRut.Properties.View.BestFitColumns()
        gleRut.Properties.PopupFormWidth = 600

        'gleRut.Text = ""
        'gleRut.EditValue = 0
    End Sub
    Private Sub llenarPeriodos()
        With luePeriodo
            With .Properties.Columns
                .Add(New LookUpColumnInfo("PERIODO_ID", "ID Periodo", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ANO", "Año", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("MES", "Mes", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ESTADO_PERIODO", "Estado Periodo", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ANOMES", "Periodo", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        luePeriodo.Properties.DataSource = dvPeriodo
        luePeriodo.Properties.DisplayMember = "ANOMES"
        luePeriodo.Properties.NullText = ""
        luePeriodo.Properties.PopupWidth = 150
        luePeriodo.Properties.ValueMember = "PERIODO_ID"
    End Sub
    Private Sub GeneraDataViews()
        Dim da As SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
        Dim ds1 As New DataSet
        Dim ds2 As New DataSet

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT * FROM VW_PERIODO_GENERAL WHERE PROCESO_BONO_MODERNIZACION=1", conn))
        da.Fill(ds2, "VW_PERIODO_GENERAL")
        Dim dvmPeriodo As New DataViewManager(ds2)
        dvPeriodo = dvmPeriodo.CreateDataView(ds2.Tables("VW_PERIODO_GENERAL"))
    End Sub
    Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
        Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
        If luePeriodo.EditValue <> Nothing Then
            llenarEmpleado()
            refrescaDetalle()
        End If
        If Not IsNothing(row) Then
            Dim value As Object = row("ESTADO_PERIODO")
            'Si el estado del periodo es 0 (No Activo) deshabilita la grilla
            If value = False Or gleRut.EditValue <> Nothing Then
                gdcDetalleItems.Enabled = False
                btnTraspasaDiferencias.Enabled = False
                btnTraspasaTodosEmpleados.Enabled = False
                txtEstadoPeriodo.Text = "INACTIVO"
            Else
                gdcDetalleItems.Enabled = True
                txtEstadoPeriodo.Text = "ACTIVO"
                If gleRut.EditValue <> Nothing Or gleRut.EditValue = "" Then
                    btnTraspasaDiferencias.Enabled = False
                    btnTraspasaTodosEmpleados.Enabled = False
                Else
                    btnTraspasaDiferencias.Enabled = True
                    btnTraspasaTodosEmpleados.Enabled = True
                End If
            End If
        End If
    End Sub
    Private Sub gleRut_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gleRut.EditValueChanged
        If gleRut.EditValue <> Nothing Then
            refrescaDetalle()
        End If
    End Sub
    Private Sub refrescaDetalle()
        If gleRut.EditValue <> Nothing And luePeriodo.EditValue <> Nothing Then
            gdcDetalleItems.DataSource = empleado.dvReliquidacionEmpleado(CType(gleRut.EditValue, Integer), CType(luePeriodo.EditValue, Integer), "R")
            If txtEstadoPeriodo.Text = "INACTIVO" Then
                btnTraspasaDiferencias.Enabled = False
                btnTraspasaTodosEmpleados.Enabled = False
            Else
                btnTraspasaDiferencias.Enabled = True
                btnTraspasaTodosEmpleados.Enabled = True
            End If
            gdcDetalleItems.Enabled = True
        Else
            gdcDetalleItems.Enabled = False
            btnTraspasaDiferencias.Enabled = False
            btnTraspasaTodosEmpleados.Enabled = False
        End If
    End Sub
    Private Sub btnTraspasaDiferencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTraspasaDiferencias.Click
        If MessageBox.Show("¿Está seguro que desa traspasar las diferencias al movimiento mensual?", "Remuneraciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Cursor.Current = Cursors.WaitCursor
                If empleado.CrearItemReliquidado(CType(luePeriodo.EditValue, Integer), CType(gleRut.EditValue, Integer), "B") Then
                    MsgBox("Proceso de traspaso terminado satisfactoriamente", MsgBoxStyle.Exclamation)
                End If
                Cursor.Current = Cursors.Default
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al intentar grabar ítem reliquidado." & Chr(13) & "ERROR : " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub btnTraspasaTodosEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTraspasaTodosEmpleados.Click
        If MessageBox.Show("¿Está seguro que desa traspasar las diferencias al movimiento mensual de todos los empelados?", "Remuneraciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Cursor.Current = Cursors.WaitCursor
                If empleado.CrearItemReliquidado(CType(luePeriodo.EditValue, Integer), 0, "B") Then
                    MsgBox("Proceso de traspaso terminado satisfactoriamente", MsgBoxStyle.Exclamation)
                End If
                Cursor.Current = Cursors.Default
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al intentar grabar ítem reliquidado. ERROR : " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub
End Class
