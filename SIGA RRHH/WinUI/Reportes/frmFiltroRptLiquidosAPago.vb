Imports cl.presidencia.Argo.Reportes

Public Class frmFiltroRptLiquidosAPago
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton
        Me.SuspendLayout()
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.Location = New System.Drawing.Point(16, 32)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(284, 21)
        Me.cboPeriodo.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Período"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 80)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(122, 23)
        Me.btnCancelar.TabIndex = 43
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(176, 80)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(122, 23)
        Me.btnVisualizar.TabIndex = 42
        Me.btnVisualizar.Text = "Visualizar"
        '
        'frmRptLiquidosAPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(320, 133)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptLiquidosAPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidos a Pago"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmRptLiquidosAPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboPeriodo.DisplayMember = "DESCRIPCION_PERIODO"
        cboPeriodo.ValueMember = "PERIODO_ID"
        cboPeriodo.DataSource = repositorio.dvPeriodo
        cboPeriodo.Refresh()
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptLiquidosAPago
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        Dim strFormulaSeleccion As String = "{VW_LIQUIDO_A_PAGO.PERIODO_ID}=" & Me.cboPeriodo.SelectedValue
        strFormulaSeleccion &= " AND ({VW_LIQUIDO_A_PAGO.TIPO_CALCULO}=""N"" OR {VW_LIQUIDO_A_PAGO.TIPO_CALCULO}=""H"")"
        reporte.SummaryInfo.ReportTitle = "Informe de Líquidos a Pago"
        ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
        ventanaReporte1.rptVisor.ShowParameterPanelButton = False
        ventanaReporte1.rptVisor.ShowCloseButton = False
        ventanaReporte1.rptVisor.ShowGroupTreeButton = False
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.Show()
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
