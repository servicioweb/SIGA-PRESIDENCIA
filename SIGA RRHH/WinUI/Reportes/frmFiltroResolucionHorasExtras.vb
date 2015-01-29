Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Reportes

Public Class frmFiltroResolucionHorasExtras
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
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExcelHorasExtras As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gdcDetalleHorasExtras As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalleHorasExtras As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNOMBRE_EMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGRADO_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCALIDAD_JURIDICA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHORAS_DIURNAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHORAS_NOCTURNAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnExcelHorasCompensadas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExcelHorasExtras = New DevExpress.XtraEditors.SimpleButton()
        Me.gdcDetalleHorasExtras = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleHorasExtras = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNOMBRE_EMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGRADO_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCALIDAD_JURIDICA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHORAS_DIURNAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHORAS_NOCTURNAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnExcelHorasCompensadas = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gdcDetalleHorasExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleHorasExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.Location = New System.Drawing.Point(20, 28)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(284, 21)
        Me.cboPeriodo.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(20, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Período"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 72)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(122, 23)
        Me.btnCancelar.TabIndex = 37
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(176, 72)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(122, 23)
        Me.btnVisualizar.TabIndex = 36
        Me.btnVisualizar.Text = "Visualizar"
        '
        'btnExcelHorasExtras
        '
        Me.btnExcelHorasExtras.Location = New System.Drawing.Point(16, 111)
        Me.btnExcelHorasExtras.Name = "btnExcelHorasExtras"
        Me.btnExcelHorasExtras.Size = New System.Drawing.Size(282, 23)
        Me.btnExcelHorasExtras.TabIndex = 45
        Me.btnExcelHorasExtras.Text = "Genera Detalle hacia Excel Horas Extras"
        '
        'gdcDetalleHorasExtras
        '
        Me.gdcDetalleHorasExtras.Location = New System.Drawing.Point(-1, 5)
        Me.gdcDetalleHorasExtras.MainView = Me.gdvDetalleHorasExtras
        Me.gdcDetalleHorasExtras.Name = "gdcDetalleHorasExtras"
        Me.gdcDetalleHorasExtras.Size = New System.Drawing.Size(110, 90)
        Me.gdcDetalleHorasExtras.TabIndex = 46
        Me.gdcDetalleHorasExtras.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleHorasExtras})
        Me.gdcDetalleHorasExtras.Visible = False
        '
        'gdvDetalleHorasExtras
        '
        Me.gdvDetalleHorasExtras.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNOMBRE_EMPLEADO, Me.colGRADO_ALIAS, Me.colCALIDAD_JURIDICA, Me.colHORAS_DIURNAS, Me.colHORAS_NOCTURNAS, Me.colDEPARTAMENTO})
        Me.gdvDetalleHorasExtras.GridControl = Me.gdcDetalleHorasExtras
        Me.gdvDetalleHorasExtras.Name = "gdvDetalleHorasExtras"
        Me.gdvDetalleHorasExtras.OptionsView.ColumnAutoWidth = False
        Me.gdvDetalleHorasExtras.OptionsView.ShowGroupPanel = False
        '
        'colNOMBRE_EMPLEADO
        '
        Me.colNOMBRE_EMPLEADO.Caption = "NOMBRE"
        Me.colNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.colNOMBRE_EMPLEADO.Name = "colNOMBRE_EMPLEADO"
        Me.colNOMBRE_EMPLEADO.OptionsColumn.AllowEdit = False
        Me.colNOMBRE_EMPLEADO.OptionsColumn.ReadOnly = True
        Me.colNOMBRE_EMPLEADO.Visible = True
        Me.colNOMBRE_EMPLEADO.VisibleIndex = 0
        Me.colNOMBRE_EMPLEADO.Width = 274
        '
        'colGRADO_ALIAS
        '
        Me.colGRADO_ALIAS.Caption = "GRADO"
        Me.colGRADO_ALIAS.FieldName = "GRADO_ALIAS"
        Me.colGRADO_ALIAS.Name = "colGRADO_ALIAS"
        Me.colGRADO_ALIAS.OptionsColumn.AllowEdit = False
        Me.colGRADO_ALIAS.OptionsColumn.ReadOnly = True
        Me.colGRADO_ALIAS.Visible = True
        Me.colGRADO_ALIAS.VisibleIndex = 1
        Me.colGRADO_ALIAS.Width = 63
        '
        'colCALIDAD_JURIDICA
        '
        Me.colCALIDAD_JURIDICA.Caption = "CALIDAD JURÍDICA"
        Me.colCALIDAD_JURIDICA.FieldName = "CALIDAD_JURIDICA"
        Me.colCALIDAD_JURIDICA.Name = "colCALIDAD_JURIDICA"
        Me.colCALIDAD_JURIDICA.OptionsColumn.AllowEdit = False
        Me.colCALIDAD_JURIDICA.OptionsColumn.ReadOnly = True
        Me.colCALIDAD_JURIDICA.Visible = True
        Me.colCALIDAD_JURIDICA.VisibleIndex = 2
        Me.colCALIDAD_JURIDICA.Width = 109
        '
        'colHORAS_DIURNAS
        '
        Me.colHORAS_DIURNAS.Caption = "HRS.DIURNAS"
        Me.colHORAS_DIURNAS.FieldName = "HORAS_DIURNAS"
        Me.colHORAS_DIURNAS.Name = "colHORAS_DIURNAS"
        Me.colHORAS_DIURNAS.OptionsColumn.AllowEdit = False
        Me.colHORAS_DIURNAS.OptionsColumn.ReadOnly = True
        Me.colHORAS_DIURNAS.Visible = True
        Me.colHORAS_DIURNAS.VisibleIndex = 3
        Me.colHORAS_DIURNAS.Width = 124
        '
        'colHORAS_NOCTURNAS
        '
        Me.colHORAS_NOCTURNAS.Caption = "HRS.NOCTURNAS"
        Me.colHORAS_NOCTURNAS.FieldName = "HORAS_NOCTURNAS"
        Me.colHORAS_NOCTURNAS.Name = "colHORAS_NOCTURNAS"
        Me.colHORAS_NOCTURNAS.OptionsColumn.AllowEdit = False
        Me.colHORAS_NOCTURNAS.OptionsColumn.ReadOnly = True
        Me.colHORAS_NOCTURNAS.Visible = True
        Me.colHORAS_NOCTURNAS.VisibleIndex = 4
        Me.colHORAS_NOCTURNAS.Width = 148
        '
        'colDEPARTAMENTO
        '
        Me.colDEPARTAMENTO.Caption = "DEPARTAMENTO"
        Me.colDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.colDEPARTAMENTO.Name = "colDEPARTAMENTO"
        Me.colDEPARTAMENTO.OptionsColumn.AllowEdit = False
        Me.colDEPARTAMENTO.OptionsColumn.ReadOnly = True
        Me.colDEPARTAMENTO.Visible = True
        Me.colDEPARTAMENTO.VisibleIndex = 5
        Me.colDEPARTAMENTO.Width = 361
        '
        'btnExcelHorasCompensadas
        '
        Me.btnExcelHorasCompensadas.Location = New System.Drawing.Point(16, 140)
        Me.btnExcelHorasCompensadas.Name = "btnExcelHorasCompensadas"
        Me.btnExcelHorasCompensadas.Size = New System.Drawing.Size(282, 23)
        Me.btnExcelHorasCompensadas.TabIndex = 47
        Me.btnExcelHorasCompensadas.Text = "Genera Detalle hacia Excel Horas Compensadas"
        '
        'frmFiltroResolucionHorasExtras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(320, 181)
        Me.Controls.Add(Me.btnExcelHorasCompensadas)
        Me.Controls.Add(Me.gdcDetalleHorasExtras)
        Me.Controls.Add(Me.btnExcelHorasExtras)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnVisualizar)
        Me.MaximizeBox = False
        Me.Name = "frmFiltroResolucionHorasExtras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resolución Horas Extras"
        CType(Me.gdcDetalleHorasExtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleHorasExtras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private empleado As Empleado
    Private periodo As Periodo

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptResolucionHorasExtras
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        Dim strFormulaSeleccion As String = "{VW_HORAS_EXTRAS_RESOLUCION.PERIODO_ID}=" & Me.cboPeriodo.SelectedValue
        reporte.SetParameterValue("quienFirma", periodo.quienFirmaResolucion)
        reporte.SetParameterValue("copiasResolucion", periodo.copiasResolucion + "/" + empleado.buscaString("SELECT USER AS USUARIO_DOMNIO"))
        ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
        ventanaReporte1.rptVisor.ShowParameterPanelButton = False
        ventanaReporte1.rptVisor.ShowCloseButton = False
        ventanaReporte1.rptVisor.ShowGroupTreeButton = False
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.Show()
    End Sub

    Private Sub frmFiltroResolucionHorasExtras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empleado = New Empleado
        periodo = New Periodo
        cboPeriodo.DisplayMember = "DESCRIPCION_PERIODO"
        cboPeriodo.ValueMember = "PERIODO_ID"

        cboPeriodo.DataSource = repositorio.dvPeriodo
        cboPeriodo.Refresh()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnExcelHorasExtras_Click(sender As System.Object, e As System.EventArgs) Handles btnExcelHorasExtras.Click
        If cboPeriodo.SelectedValue = Nothing Then
            Return
        End If
        Dim rutaPlanillaExcel As String
        Try
            gdcDetalleHorasExtras.DataSource = empleado.recuperaHorasExtrasPagadasPorPeriodo(cboPeriodo.SelectedValue)
            With SaveFileDialog1
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = SaveFileDialog1.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                gdcDetalleHorasExtras.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExcelHorasCompensadas_Click(sender As System.Object, e As System.EventArgs) Handles btnExcelHorasCompensadas.Click
        If cboPeriodo.SelectedValue = Nothing Then
            Return
        End If
        Dim rutaPlanillaExcel As String
        Try
            gdcDetalleHorasExtras.DataSource = empleado.recuperaHorasExtrasCompensadasPorPeriodo(cboPeriodo.SelectedValue)
            With SaveFileDialog1
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = SaveFileDialog1.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                gdcDetalleHorasExtras.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
