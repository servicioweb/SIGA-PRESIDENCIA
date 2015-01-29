Imports cl.presidencia.Argo.Reportes

Public Class frmFiltroBonificacionRetiro
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
        Me.cboPeriodo.Location = New System.Drawing.Point(8, 24)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(284, 21)
        Me.cboPeriodo.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Período"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(8, 168)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(122, 23)
        Me.btnCancelar.TabIndex = 33
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(168, 168)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(122, 23)
        Me.btnVisualizar.TabIndex = 32
        Me.btnVisualizar.Text = "Visualizar"
        '
        'rdgTipoProceso
        '
        Me.rdgTipoProceso.EditValue = "N"
        Me.rdgTipoProceso.Location = New System.Drawing.Point(8, 63)
        Me.rdgTipoProceso.Name = "rdgTipoProceso"
        '
        'rdgTipoProceso.Properties
        '
        Me.rdgTipoProceso.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("N", "Normal"), New DevExpress.XtraEditors.Controls.RadioGroupItem("R", "Bono Modernización")})
        Me.rdgTipoProceso.Size = New System.Drawing.Size(280, 88)
        Me.rdgTipoProceso.TabIndex = 37
        Me.rdgTipoProceso.ToolTip = "Seleccione el tipo de proceso de cálculo"
        '
        'frmFiltroBonificacionRetiro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(304, 214)
        Me.Controls.Add(Me.rdgTipoProceso)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnVisualizar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFiltroBonificacionRetiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bonificación por Retiro"
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        'Dim ventanaReporte1 As New ventanaReporte
        'Dim reporte As New BonificacionRetiro
        'reporte.SummaryInfo.ReportTitle = "BONIFICACIÓN POR RETIRO"
        'WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        'Dim strFormulaSeleccion = "{RH_REM_LIQUIDACION_ENC.PERIODO_ID}=" & Me.cboPeriodo.SelectedValue
        'If (New cl.presidencia.Argo.BusinessRules.Periodo).ID = Me.cboPeriodo.SelectedValue Then 'Significa que se ha seleccionado el período actual
        '    strFormulaSeleccion &= " AND {RH_PER_ANTECEDENTE_LABORAL.ESTADO_REGISTRO}=1"
        'Else ' Se trata de un registro histórico, para un Periodo cerrado
        '    strFormulaSeleccion &= " AND {RH_PER_ANTECEDENTE_LABORAL.ESTADO_REGISTRO}=5"
        'End If
        'strFormulaSeleccion &= " AND {RH_REM_LIQUIDACION_ENC.MONTO_BONIF_RETIRO}>0"
        'strFormulaSeleccion &= " AND {RH_REM_LIQUIDACION_ENC.TIPO_CALCULO}=""N"""
        'ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
        'ventanaReporte1.rptVisor.DisplayGroupTree = True
        'ventanaReporte1.rptVisor.ReportSource = reporte
        'ventanaReporte1.Show()
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptBonificacionRetiro
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        reporte.SetParameterValue("tipoproceso", Me.rdgTipoProceso.EditValue)
        Dim strFormulaSeleccion As String = "{VW_IMPOSICIONES.PERIODO_ID}=" & Me.cboPeriodo.SelectedValue
        strFormulaSeleccion &= " AND {VW_IMPOSICIONES.TIPO_PROCESO}=""" & Me.rdgTipoProceso.EditValue & """"
        strFormulaSeleccion &= " AND {VW_IMPOSICIONES.MONTO_BONIF_RETIRO}>0"
        ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
        ventanaReporte1.rptVisor.ShowParameterPanelButton = False
        ventanaReporte1.rptVisor.ShowCloseButton = False
        ventanaReporte1.rptVisor.ShowGroupTreeButton = False
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.Show()

    End Sub

    Private Sub frmFiltroMutualDeSeguridad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboPeriodo.DisplayMember = "DESCRIPCION_PERIODO"
        cboPeriodo.ValueMember = "PERIODO_ID"
        cboPeriodo.DataSource = repositorio.dvPeriodo
        cboPeriodo.Refresh()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
