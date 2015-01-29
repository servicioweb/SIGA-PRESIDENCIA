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
Imports System.Data.SqlClient

Public Class frmGeneraItem
    Inherits System.Windows.Forms.Form

    Dim empleado As Empleado
    Dim parametroMensual As Periodo

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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dvEmpleados As System.Data.DataView
    Friend WithEvents gdvEmpleados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APELLIDO_PATERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APELLIDO_MATERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESC_CALIDAD_JURIDICA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CALIDAD_JURIDICA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GRADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GRADO_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLASIFICACION_EMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION_CLASIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gpcParametroMensual As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gdcEmpleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents lblitem As System.Windows.Forms.Label
    Friend WithEvents lueItems As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtNombrePeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents txtMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents btnGenera As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dvItems As System.Data.DataView
    Friend WithEvents rdgTipoProceso As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lblTipoProceso As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gdcEmpleados = New DevExpress.XtraGrid.GridControl
        Me.gdvEmpleados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.EMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.APELLIDO_PATERNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.APELLIDO_MATERNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RUT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DV = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CALIDAD_JURIDICA_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DESC_CALIDAD_JURIDICA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GRADO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GRADO_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CLASIFICACION_EMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DESCRIPCION_CLASIFICACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.dvEmpleados = New System.Data.DataView
        Me.lblitem = New System.Windows.Forms.Label
        Me.gpcParametroMensual = New DevExpress.XtraEditors.GroupControl
        Me.lblTipoProceso = New System.Windows.Forms.Label
        Me.rdgTipoProceso = New DevExpress.XtraEditors.RadioGroup
        Me.txtMonto = New DevExpress.XtraEditors.TextEdit
        Me.lblMonto = New System.Windows.Forms.Label
        Me.txtNombrePeriodo = New DevExpress.XtraEditors.TextEdit
        Me.lueItems = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.btnGenera = New DevExpress.XtraEditors.SimpleButton
        Me.dvItems = New System.Data.DataView
        CType(Me.gdcEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcParametroMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcParametroMensual.SuspendLayout()
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombrePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueItems.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcEmpleados
        '
        Me.gdcEmpleados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'gdcEmpleados.EmbeddedNavigator
        '
        Me.gdcEmpleados.EmbeddedNavigator.Name = ""
        Me.gdcEmpleados.Location = New System.Drawing.Point(24, 136)
        Me.gdcEmpleados.MainView = Me.gdvEmpleados
        Me.gdcEmpleados.Name = "gdcEmpleados"
        Me.gdcEmpleados.Size = New System.Drawing.Size(752, 360)
        Me.gdcEmpleados.TabIndex = 0
        Me.gdcEmpleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvEmpleados, Me.GridView1})
        '
        'gdvEmpleados
        '
        Me.gdvEmpleados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.EMPLEADO_ID, Me.APELLIDO_PATERNO, Me.APELLIDO_MATERNO, Me.RUT, Me.DV, Me.CALIDAD_JURIDICA_ID, Me.DESC_CALIDAD_JURIDICA, Me.GRADO_ID, Me.GRADO_ALIAS, Me.CLASIFICACION_EMPLEADO_ID, Me.DESCRIPCION_CLASIFICACION})
        Me.gdvEmpleados.GridControl = Me.gdcEmpleados
        Me.gdvEmpleados.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvEmpleados.Name = "gdvEmpleados"
        Me.gdvEmpleados.OptionsNavigation.EnterMoveNextColumn = True
        Me.gdvEmpleados.OptionsSelection.InvertSelection = True
        Me.gdvEmpleados.OptionsSelection.MultiSelect = True
        Me.gdvEmpleados.OptionsView.ColumnAutoWidth = False
        Me.gdvEmpleados.SynchronizeClones = False
        '
        'EMPLEADO_ID
        '
        Me.EMPLEADO_ID.Caption = "ID Empleado"
        Me.EMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.EMPLEADO_ID.Name = "EMPLEADO_ID"
        Me.EMPLEADO_ID.OptionsColumn.ReadOnly = True
        '
        'APELLIDO_PATERNO
        '
        Me.APELLIDO_PATERNO.Caption = "Apellido Paterno"
        Me.APELLIDO_PATERNO.FieldName = "APELLIDO_PATERNO"
        Me.APELLIDO_PATERNO.Name = "APELLIDO_PATERNO"
        Me.APELLIDO_PATERNO.OptionsColumn.ReadOnly = True
        Me.APELLIDO_PATERNO.Visible = True
        Me.APELLIDO_PATERNO.VisibleIndex = 0
        Me.APELLIDO_PATERNO.Width = 120
        '
        'APELLIDO_MATERNO
        '
        Me.APELLIDO_MATERNO.Caption = "Apellido Materno"
        Me.APELLIDO_MATERNO.FieldName = "APELLIDO_MATERNO"
        Me.APELLIDO_MATERNO.Name = "APELLIDO_MATERNO"
        Me.APELLIDO_MATERNO.OptionsColumn.ReadOnly = True
        Me.APELLIDO_MATERNO.Visible = True
        Me.APELLIDO_MATERNO.VisibleIndex = 1
        Me.APELLIDO_MATERNO.Width = 125
        '
        'RUT
        '
        Me.RUT.Caption = "Rut"
        Me.RUT.FieldName = "RUT"
        Me.RUT.Name = "RUT"
        Me.RUT.OptionsColumn.ReadOnly = True
        Me.RUT.Visible = True
        Me.RUT.VisibleIndex = 2
        Me.RUT.Width = 63
        '
        'DV
        '
        Me.DV.Caption = "DV"
        Me.DV.FieldName = "DV"
        Me.DV.Name = "DV"
        Me.DV.OptionsColumn.ReadOnly = True
        Me.DV.Visible = True
        Me.DV.VisibleIndex = 3
        Me.DV.Width = 65
        '
        'CALIDAD_JURIDICA_ID
        '
        Me.CALIDAD_JURIDICA_ID.Caption = "ID Calidad Juridica"
        Me.CALIDAD_JURIDICA_ID.FieldName = "CALIDAD_JURIDICA_ID"
        Me.CALIDAD_JURIDICA_ID.Name = "CALIDAD_JURIDICA_ID"
        Me.CALIDAD_JURIDICA_ID.OptionsColumn.ReadOnly = True
        '
        'DESC_CALIDAD_JURIDICA
        '
        Me.DESC_CALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.DESC_CALIDAD_JURIDICA.FieldName = "DESC_CALIDAD_JURIDICA"
        Me.DESC_CALIDAD_JURIDICA.Name = "DESC_CALIDAD_JURIDICA"
        Me.DESC_CALIDAD_JURIDICA.OptionsColumn.ReadOnly = True
        Me.DESC_CALIDAD_JURIDICA.Visible = True
        Me.DESC_CALIDAD_JURIDICA.VisibleIndex = 4
        Me.DESC_CALIDAD_JURIDICA.Width = 112
        '
        'GRADO_ID
        '
        Me.GRADO_ID.Caption = "ID Grado"
        Me.GRADO_ID.FieldName = "GRADO_ID"
        Me.GRADO_ID.Name = "GRADO_ID"
        Me.GRADO_ID.OptionsColumn.ReadOnly = True
        '
        'GRADO_ALIAS
        '
        Me.GRADO_ALIAS.Caption = "Grado"
        Me.GRADO_ALIAS.FieldName = "GRADO_ALIAS"
        Me.GRADO_ALIAS.Name = "GRADO_ALIAS"
        Me.GRADO_ALIAS.OptionsColumn.ReadOnly = True
        Me.GRADO_ALIAS.Visible = True
        Me.GRADO_ALIAS.VisibleIndex = 5
        Me.GRADO_ALIAS.Width = 85
        '
        'CLASIFICACION_EMPLEADO_ID
        '
        Me.CLASIFICACION_EMPLEADO_ID.Caption = "ID Clasificación"
        Me.CLASIFICACION_EMPLEADO_ID.FieldName = "CLASIFICACION_EMPLEADO_ID"
        Me.CLASIFICACION_EMPLEADO_ID.Name = "CLASIFICACION_EMPLEADO_ID"
        Me.CLASIFICACION_EMPLEADO_ID.OptionsColumn.ReadOnly = True
        '
        'DESCRIPCION_CLASIFICACION
        '
        Me.DESCRIPCION_CLASIFICACION.Caption = "Clasificación Empleado"
        Me.DESCRIPCION_CLASIFICACION.FieldName = "DESCRIPCION_CLASIFICACION"
        Me.DESCRIPCION_CLASIFICACION.Name = "DESCRIPCION_CLASIFICACION"
        Me.DESCRIPCION_CLASIFICACION.OptionsColumn.ReadOnly = True
        Me.DESCRIPCION_CLASIFICACION.Visible = True
        Me.DESCRIPCION_CLASIFICACION.VisibleIndex = 6
        Me.DESCRIPCION_CLASIFICACION.Width = 154
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcEmpleados
        Me.GridView1.Name = "GridView1"
        '
        'lblitem
        '
        Me.lblitem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblitem.Location = New System.Drawing.Point(240, 36)
        Me.lblitem.Name = "lblitem"
        Me.lblitem.Size = New System.Drawing.Size(32, 16)
        Me.lblitem.TabIndex = 3
        Me.lblitem.Text = "Ítem"
        Me.lblitem.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gpcParametroMensual
        '
        Me.gpcParametroMensual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcParametroMensual.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcParametroMensual.AppearanceCaption.Options.UseFont = True
        Me.gpcParametroMensual.Controls.Add(Me.lblTipoProceso)
        Me.gpcParametroMensual.Controls.Add(Me.rdgTipoProceso)
        Me.gpcParametroMensual.Controls.Add(Me.txtMonto)
        Me.gpcParametroMensual.Controls.Add(Me.lblMonto)
        Me.gpcParametroMensual.Controls.Add(Me.txtNombrePeriodo)
        Me.gpcParametroMensual.Controls.Add(Me.lueItems)
        Me.gpcParametroMensual.Controls.Add(Me.lblitem)
        Me.gpcParametroMensual.Location = New System.Drawing.Point(24, 8)
        Me.gpcParametroMensual.Name = "gpcParametroMensual"
        Me.gpcParametroMensual.Size = New System.Drawing.Size(752, 120)
        Me.gpcParametroMensual.TabIndex = 10
        Me.gpcParametroMensual.Text = "Datos a generar"
        '
        'lblTipoProceso
        '
        Me.lblTipoProceso.Location = New System.Drawing.Point(8, 64)
        Me.lblTipoProceso.Name = "lblTipoProceso"
        Me.lblTipoProceso.Size = New System.Drawing.Size(72, 16)
        Me.lblTipoProceso.TabIndex = 10
        Me.lblTipoProceso.Text = "Tipo Proceso"
        Me.lblTipoProceso.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'rdgTipoProceso
        '
        Me.rdgTipoProceso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdgTipoProceso.EditValue = "N"
        Me.rdgTipoProceso.Enabled = False
        Me.rdgTipoProceso.Location = New System.Drawing.Point(88, 64)
        Me.rdgTipoProceso.Name = "rdgTipoProceso"
        '
        'rdgTipoProceso.Properties
        '
        Me.rdgTipoProceso.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Cambio de Grado"), New DevExpress.XtraEditors.Controls.RadioGroupItem("N", "Normal"), New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Suplementario"), New DevExpress.XtraEditors.Controls.RadioGroupItem("B", "Bono Modernización")})
        Me.rdgTipoProceso.Size = New System.Drawing.Size(464, 32)
        Me.rdgTipoProceso.TabIndex = 9
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(624, 32)
        Me.txtMonto.Name = "txtMonto"
        '
        'txtMonto.Properties
        '
        Me.txtMonto.Properties.Mask.EditMask = "n2"
        Me.txtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMonto.Size = New System.Drawing.Size(96, 20)
        Me.txtMonto.TabIndex = 7
        '
        'lblMonto
        '
        Me.lblMonto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblMonto.Location = New System.Drawing.Point(560, 36)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(48, 16)
        Me.lblMonto.TabIndex = 6
        Me.lblMonto.Text = "Monto"
        Me.lblMonto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNombrePeriodo
        '
        Me.txtNombrePeriodo.Location = New System.Drawing.Point(88, 32)
        Me.txtNombrePeriodo.Name = "txtNombrePeriodo"
        '
        'txtNombrePeriodo.Properties
        '
        Me.txtNombrePeriodo.Properties.ReadOnly = True
        Me.txtNombrePeriodo.Size = New System.Drawing.Size(96, 20)
        Me.txtNombrePeriodo.TabIndex = 5
        '
        'lueItems
        '
        Me.lueItems.Location = New System.Drawing.Point(288, 32)
        Me.lueItems.Name = "lueItems"
        '
        'lueItems.Properties
        '
        Me.lueItems.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueItems.Properties.PopupWidth = 550
        Me.lueItems.Size = New System.Drawing.Size(264, 20)
        Me.lueItems.TabIndex = 4
        '
        'lblPeriodo
        '
        Me.lblPeriodo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPeriodo.Location = New System.Drawing.Point(56, 40)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 16)
        Me.lblPeriodo.TabIndex = 2
        Me.lblPeriodo.Text = "Período"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnGenera
        '
        Me.btnGenera.Location = New System.Drawing.Point(336, 520)
        Me.btnGenera.Name = "btnGenera"
        Me.btnGenera.Size = New System.Drawing.Size(144, 23)
        Me.btnGenera.TabIndex = 11
        Me.btnGenera.Text = "&Genera"
        '
        'frmGeneraItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(800, 558)
        Me.Controls.Add(Me.btnGenera)
        Me.Controls.Add(Me.lblPeriodo)
        Me.Controls.Add(Me.gdcEmpleados)
        Me.Controls.Add(Me.gpcParametroMensual)
        Me.Name = "frmGeneraItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Genera Ítem"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcParametroMensual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcParametroMensual.ResumeLayout(False)
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombrePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueItems.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCalculoSueldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empleado = New Empleado
        parametroMensual = New Periodo
        rdgTipoProceso.SelectedIndex = 1
        lueItems.EditValue = Nothing
        txtMonto.EditValue = 0
        llenarItems()
        Dim fechaFinalIngreso As Date
        Dim diasMes As Integer = fechaFinalIngreso.DaysInMonth(parametroMensual.ano, parametroMensual.mes)
        fechaFinalIngreso = CType(CType(diasMes, String) + "-" + CType(parametroMensual.mes, String) + "-" + CType(parametroMensual.ano, String), Date)

        gdcEmpleados.DataSource = empleado.recuperaMaestroEmpleado(fechaFinalIngreso, 0)
        txtNombrePeriodo.Text = UCase(parametroMensual.nombrePeriodo)

    End Sub

    Private Sub btnGenera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenera.Click
        Dim filas() As Integer = gdvEmpleados.GetSelectedRows()
        Dim prosigue As Boolean = True

        If txtMonto.EditValue = 0 Then
            txtMonto.ErrorText = "Debe ingresar monto del ítem a generar"
            prosigue = False
        End If
        If lueItems.EditValue = Nothing Then
            lueItems.ErrorText = "Falta ingresar ítem a generar"
            prosigue = False
        End If
        If prosigue Then
            If filas.Length > 0 Then
                If txtMonto.EditValue = 0 Or lueItems.EditValue = Nothing Then
                    MsgBox("Falta ingresar ítem o monto", MsgBoxStyle.Information)
                Else
                    Dim condicion As String = CType(parametroMensual.ID, String) + " AND ITEM_ID=" + CType(lueItems.EditValue, String) + " AND ORIGEN=1"
                    Dim idMovto As Integer = DataAccess.Utiles.buscaID(Tablas.RH_REM_MOVIMIENTO_MENSUAL, "NN", "PERIODO_ID", condicion, "MOVIMIENTO_MENSUAL_ID")
                    Dim respuesta As Boolean = False

                    If idMovto > 0 Then
                        If System.Windows.Forms.MessageBox.Show("¿Ya existen registros para el ítem/periodo. Si continua se borrarán los registros y se generaran nuevamente. ¿Continua?", "Ítemes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            respuesta = True
                        End If
                    Else
                        respuesta = True
                    End If
                    If respuesta Then
                        If System.Windows.Forms.MessageBox.Show("¿Desea generar el item para los registros seleccionados?", "Ítemes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            btnGenera.Enabled = False
                            empleado.EliminarEmpleadoMovimientoMensual(parametroMensual.ID, CType(lueItems.EditValue, Integer), 1, rdgTipoProceso.EditValue)
                            'Dim filas() As Integer = gdvEmpleados.GetSelectedRows()
                            Dim i As Integer
                            For i = 0 To filas.Length - 1
                                Dim row As DataRow = gdvEmpleados.GetDataRow(filas(i))
                                Dim idEmpleado As Integer = row("EMPLEADO_ID")
                                'CType(lueItems.EditValue, Integer)
                                empleado.CrearEmpleadoMovimientoMensual(parametroMensual.ID, CType(lueItems.EditValue, Integer), idEmpleado, 0, 0, 1, CType(txtMonto.Text, Integer), rdgTipoProceso.EditValue)
                            Next i
                            System.Windows.Forms.MessageBox.Show("Proceso Finalizado. Se generaron " + CType(i, String) + " registros")
                            btnGenera.Enabled = True
                        End If
                    End If
                End If
            Else
                MsgBox("No hay registros seleccionados para generar", MsgBoxStyle.Information)
            End If
        End If
    End Sub
    Public Sub llenarItems()
        Dim da As SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
        Dim ds1 As New DataSet

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_ITEM, conn))
        da.Fill(ds1, Tablas.RH_REM_ITEM)
        Dim dvmItem As New DataViewManager(ds1)
        dvItems = dvmItem.CreateDataView(ds1.Tables(Tablas.RH_REM_ITEM))

        With lueItems
            With .Properties.Columns
                .Add(New LookUpColumnInfo("ITEM_ID", "ID Item", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ITEM_ALIAS", "Item", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION_LARGA", "Descripción", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ES_CALCULABLE", "Es Calculable", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueItems.Properties.DataSource = dvItems
        lueItems.Properties.DisplayMember = "DESCRIPCION_LARGA"
        lueItems.Properties.NullText = ""
        lueItems.Properties.PopupWidth = 300
        lueItems.Properties.ValueMember = "ITEM_ID"
    End Sub
End Class
