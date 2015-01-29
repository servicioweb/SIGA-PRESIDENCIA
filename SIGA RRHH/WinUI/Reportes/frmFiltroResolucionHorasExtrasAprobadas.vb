Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Reportes

Public Class frmFiltroResolucionHorasExtrasAprobadas
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
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gdcDetalleHorasExtras As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalleHorasExtras As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtAño As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMes As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colNOMBRE_EMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGRADO_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCALIDAD_JURIDICA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHORAS_DIURNAS_APROB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHORAS_NOCTURNAS_APROB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.gdcDetalleHorasExtras = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleHorasExtras = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNOMBRE_EMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGRADO_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCALIDAD_JURIDICA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHORAS_DIURNAS_APROB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHORAS_NOCTURNAS_APROB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtAño = New DevExpress.XtraEditors.TextEdit()
        Me.txtMes = New DevExpress.XtraEditors.TextEdit()
        CType(Me.gdcDetalleHorasExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleHorasExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAño.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(200, 80)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(122, 23)
        Me.btnCancelar.TabIndex = 39
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(40, 80)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(122, 23)
        Me.btnVisualizar.TabIndex = 38
        Me.btnVisualizar.Text = "Visualizar"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(176, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Mes"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(48, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Año"
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(40, 119)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(282, 23)
        Me.btnExcel.TabIndex = 44
        Me.btnExcel.Text = "Genera Detalle hacia Excel"
        '
        'gdcDetalleHorasExtras
        '
        Me.gdcDetalleHorasExtras.Location = New System.Drawing.Point(3, 12)
        Me.gdcDetalleHorasExtras.MainView = Me.gdvDetalleHorasExtras
        Me.gdcDetalleHorasExtras.Name = "gdcDetalleHorasExtras"
        Me.gdcDetalleHorasExtras.Size = New System.Drawing.Size(110, 90)
        Me.gdcDetalleHorasExtras.TabIndex = 45
        Me.gdcDetalleHorasExtras.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleHorasExtras})
        Me.gdcDetalleHorasExtras.Visible = False
        '
        'gdvDetalleHorasExtras
        '
        Me.gdvDetalleHorasExtras.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNOMBRE_EMPLEADO, Me.colGRADO_ALIAS, Me.colCALIDAD_JURIDICA, Me.colHORAS_DIURNAS_APROB, Me.colHORAS_NOCTURNAS_APROB, Me.colDEPARTAMENTO})
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
        'colHORAS_DIURNAS_APROB
        '
        Me.colHORAS_DIURNAS_APROB.Caption = "HRS.DIURNAS PLANIF."
        Me.colHORAS_DIURNAS_APROB.FieldName = "HORAS_DIURNAS_APROB"
        Me.colHORAS_DIURNAS_APROB.Name = "colHORAS_DIURNAS_APROB"
        Me.colHORAS_DIURNAS_APROB.OptionsColumn.AllowEdit = False
        Me.colHORAS_DIURNAS_APROB.OptionsColumn.ReadOnly = True
        Me.colHORAS_DIURNAS_APROB.Visible = True
        Me.colHORAS_DIURNAS_APROB.VisibleIndex = 3
        Me.colHORAS_DIURNAS_APROB.Width = 124
        '
        'colHORAS_NOCTURNAS_APROB
        '
        Me.colHORAS_NOCTURNAS_APROB.Caption = "HRS.NOCTURNAS PLANIF."
        Me.colHORAS_NOCTURNAS_APROB.FieldName = "HORAS_NOCTURNAS_APROB"
        Me.colHORAS_NOCTURNAS_APROB.Name = "colHORAS_NOCTURNAS_APROB"
        Me.colHORAS_NOCTURNAS_APROB.OptionsColumn.AllowEdit = False
        Me.colHORAS_NOCTURNAS_APROB.OptionsColumn.ReadOnly = True
        Me.colHORAS_NOCTURNAS_APROB.Visible = True
        Me.colHORAS_NOCTURNAS_APROB.VisibleIndex = 4
        Me.colHORAS_NOCTURNAS_APROB.Width = 148
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
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(78, 32)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Properties.Mask.EditMask = "n0"
        Me.txtAño.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAño.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAño.Properties.MaxLength = 4
        Me.txtAño.Size = New System.Drawing.Size(84, 20)
        Me.txtAño.TabIndex = 46
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(214, 32)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Properties.Mask.EditMask = "n0"
        Me.txtMes.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMes.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMes.Properties.MaxLength = 4
        Me.txtMes.Size = New System.Drawing.Size(84, 20)
        Me.txtMes.TabIndex = 47
        '
        'frmFiltroResolucionHorasExtrasAprobadas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(344, 164)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.gdcDetalleHorasExtras)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Name = "frmFiltroResolucionHorasExtrasAprobadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resolución Horas Extras Aprobadas"
        CType(Me.gdcDetalleHorasExtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleHorasExtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAño.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private empleado As New Empleado

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        If txtAño.EditValue = Nothing Or txtMes.EditValue = Nothing Then
            Return
        End If
        Cursor.Current = Cursors.WaitCursor
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptResolucionHorasExtrasPlanificadas
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        Dim strFormulaSeleccion As String = "{VW_HORAS_EXTRAS_APROBADAS_RESOLUCION.AÑO}=" & Me.txtAño.Text & " AND  {VW_HORAS_EXTRAS_APROBADAS_RESOLUCION.MES}=" & Me.txtMes.Text
        reporte.SetParameterValue("quienFirma", 1)
        reporte.SetParameterValue("copiasResolucion", "/" + empleado.buscaString("SELECT USER AS USUARIO_DOMNIO"))
        ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
        ventanaReporte1.rptVisor.ShowParameterPanelButton = False
        ventanaReporte1.rptVisor.ShowCloseButton = False
        ventanaReporte1.rptVisor.ShowGroupTreeButton = False
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExcel.Click
        If txtAño.EditValue = Nothing Or txtMes.EditValue = Nothing Then
            Return
        End If
        Dim rutaPlanillaExcel As String
        Try
            gdcDetalleHorasExtras.DataSource = empleado.recuperaHorasExtrasAprobadasPorAñoMes(txtAño.Text, txtMes.Text)
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
