Imports cl.presidencia.Argo.Reportes

Public Class frmFiltroResumenSalud
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
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rdgTipoProceso As DevExpress.XtraEditors.RadioGroup
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton
        Me.rdgTipoProceso = New DevExpress.XtraEditors.RadioGroup
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.Location = New System.Drawing.Point(14, 32)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(284, 21)
        Me.cboPeriodo.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(14, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Período"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 176)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(122, 23)
        Me.btnCancelar.TabIndex = 41
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(176, 176)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(122, 23)
        Me.btnVisualizar.TabIndex = 40
        Me.btnVisualizar.Text = "Visualizar"
        '
        'rdgTipoProceso
        '
        Me.rdgTipoProceso.EditValue = "N"
        Me.rdgTipoProceso.Location = New System.Drawing.Point(12, 64)
        Me.rdgTipoProceso.Name = "rdgTipoProceso"
        '
        'rdgTipoProceso.Properties
        '
        Me.rdgTipoProceso.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("N", "Normal"), New DevExpress.XtraEditors.Controls.RadioGroupItem("R", "Retroactivo"), New DevExpress.XtraEditors.Controls.RadioGroupItem("RH", "Reproceso Histórico")})
        Me.rdgTipoProceso.Size = New System.Drawing.Size(288, 104)
        Me.rdgTipoProceso.TabIndex = 44
        Me.rdgTipoProceso.ToolTip = "Seleccione el tipo de proceso de cálculo"
        '
        'frmFiltroResumenSalud
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(312, 214)
        Me.Controls.Add(Me.rdgTipoProceso)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnVisualizar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFiltroResumenSalud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen de Pagos Salud"
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptResumenSalud
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        Dim strFormulaSeleccion As String = "{VW_IMPOSICIONES.PERIODO_ID}=" & Me.cboPeriodo.SelectedValue
        strFormulaSeleccion &= " AND ({VW_IMPOSICIONES.REGIMEN_PREVISIONAL_SALUD}=""ISA"" OR {VW_IMPOSICIONES.REGIMEN_PREVISIONAL_SALUD}=""FON"") "
        strFormulaSeleccion &= " AND {VW_IMPOSICIONES.TIPO_PROCESO}= """ + rdgTipoProceso.EditValue + """"
        reporte.SummaryInfo.ReportTitle = "Resumen de Pagos de Salud"
        ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
        ventanaReporte1.rptVisor.ShowParameterPanelButton = False
        ventanaReporte1.rptVisor.ShowCloseButton = False
        ventanaReporte1.rptVisor.ShowGroupTreeButton = False
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.Show()
    End Sub

    Private Sub frmFiltroResumenSalud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboPeriodo.DisplayMember = "DESCRIPCION_PERIODO"
        cboPeriodo.ValueMember = "PERIODO_ID"
        cboPeriodo.DataSource = repositorio.dvPeriodo
        cboPeriodo.Refresh()
    End Sub
End Class
