Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo

Public Class frmGenerarResumenMensualHrsExtrasAtraso
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
    Friend WithEvents lblFechaInicial As System.Windows.Forms.Label
    Friend WithEvents dedFechaInicial As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dedFechaFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFechaFinal As System.Windows.Forms.Label
    Friend WithEvents txtnombrePeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpcBotones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblPeriodoPago As System.Windows.Forms.Label
    Friend WithEvents prbProgreso As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpcEncabezado = New DevExpress.XtraEditors.GroupControl
        Me.prbProgreso = New System.Windows.Forms.ProgressBar
        Me.txtnombrePeriodo = New DevExpress.XtraEditors.TextEdit
        Me.lblFechaFinal = New System.Windows.Forms.Label
        Me.dedFechaFinal = New DevExpress.XtraEditors.DateEdit
        Me.dedFechaInicial = New DevExpress.XtraEditors.DateEdit
        Me.lblFechaInicial = New System.Windows.Forms.Label
        Me.lblPeriodoPago = New System.Windows.Forms.Label
        Me.gpcBotones = New DevExpress.XtraEditors.GroupControl
        Me.btnGenerar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcEncabezado.SuspendLayout()
        CType(Me.txtnombrePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpcEncabezado
        '
        Me.gpcEncabezado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcEncabezado.AppearanceCaption.Options.UseFont = True
        Me.gpcEncabezado.Controls.Add(Me.prbProgreso)
        Me.gpcEncabezado.Controls.Add(Me.txtnombrePeriodo)
        Me.gpcEncabezado.Controls.Add(Me.lblFechaFinal)
        Me.gpcEncabezado.Controls.Add(Me.dedFechaFinal)
        Me.gpcEncabezado.Controls.Add(Me.dedFechaInicial)
        Me.gpcEncabezado.Controls.Add(Me.lblFechaInicial)
        Me.gpcEncabezado.Controls.Add(Me.lblPeriodoPago)
        Me.gpcEncabezado.Location = New System.Drawing.Point(8, 8)
        Me.gpcEncabezado.Name = "gpcEncabezado"
        Me.gpcEncabezado.Size = New System.Drawing.Size(408, 176)
        Me.gpcEncabezado.TabIndex = 19
        Me.gpcEncabezado.Text = "Parámetros"
        '
        'prbProgreso
        '
        Me.prbProgreso.Location = New System.Drawing.Point(16, 136)
        Me.prbProgreso.Name = "prbProgreso"
        Me.prbProgreso.Size = New System.Drawing.Size(376, 16)
        Me.prbProgreso.TabIndex = 56
        '
        'txtnombrePeriodo
        '
        Me.txtnombrePeriodo.Enabled = False
        Me.txtnombrePeriodo.Location = New System.Drawing.Point(168, 32)
        Me.txtnombrePeriodo.Name = "txtnombrePeriodo"
        '
        'txtnombrePeriodo.Properties
        '
        Me.txtnombrePeriodo.Properties.ReadOnly = True
        Me.txtnombrePeriodo.Size = New System.Drawing.Size(104, 20)
        Me.txtnombrePeriodo.TabIndex = 55
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(88, 100)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(72, 16)
        Me.lblFechaFinal.TabIndex = 54
        Me.lblFechaFinal.Text = "Fecha Final"
        Me.lblFechaFinal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dedFechaFinal
        '
        Me.dedFechaFinal.EditValue = Nothing
        Me.dedFechaFinal.Location = New System.Drawing.Point(168, 96)
        Me.dedFechaFinal.Name = "dedFechaFinal"
        '
        'dedFechaFinal.Properties
        '
        Me.dedFechaFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.dedFechaFinal.TabIndex = 53
        '
        'dedFechaInicial
        '
        Me.dedFechaInicial.EditValue = Nothing
        Me.dedFechaInicial.Location = New System.Drawing.Point(168, 64)
        Me.dedFechaInicial.Name = "dedFechaInicial"
        '
        'dedFechaInicial.Properties
        '
        Me.dedFechaInicial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaInicial.Size = New System.Drawing.Size(104, 20)
        Me.dedFechaInicial.TabIndex = 52
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(88, 68)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(72, 16)
        Me.lblFechaInicial.TabIndex = 51
        Me.lblFechaInicial.Text = "Fecha Inicial"
        Me.lblFechaInicial.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPeriodoPago
        '
        Me.lblPeriodoPago.Location = New System.Drawing.Point(32, 36)
        Me.lblPeriodoPago.Name = "lblPeriodoPago"
        Me.lblPeriodoPago.Size = New System.Drawing.Size(128, 16)
        Me.lblPeriodoPago.TabIndex = 0
        Me.lblPeriodoPago.Text = "Período Pago Hs.Extras"
        Me.lblPeriodoPago.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gpcBotones
        '
        Me.gpcBotones.Controls.Add(Me.btnGenerar)
        Me.gpcBotones.Location = New System.Drawing.Point(8, 184)
        Me.gpcBotones.Name = "gpcBotones"
        Me.gpcBotones.ShowCaption = False
        Me.gpcBotones.Size = New System.Drawing.Size(408, 64)
        Me.gpcBotones.TabIndex = 20
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(120, 24)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(168, 23)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar Resumen Mensual"
        '
        'frmGenerarResumenMensualHrsExtrasAtraso
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 252)
        Me.Controls.Add(Me.gpcBotones)
        Me.Controls.Add(Me.gpcEncabezado)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGenerarResumenMensualHrsExtrasAtraso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Genera Resumen Pago Mensual Horas Extras y Atraso"
        CType(Me.gpcEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcEncabezado.ResumeLayout(False)
        CType(Me.txtnombrePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private empleado As empleado
    Private connectionString As String = Comun.ArgoConfiguracion.ConnectionString
    Private periodo As periodo
    Private parametroMensual As periodo

    Private Sub frmGenerarResumenMensualHrsExtrasAtraso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empleado = New empleado
        parametroMensual = New periodo
        txtnombrePeriodo.Text = UCase(parametroMensual.nombrePeriodo)
        validaFechas()
        prbProgreso.Visible = False
    End Sub

    Private Sub dedFechaInicial_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dedFechaInicial.EditValueChanged
        validaFechas()
    End Sub

    Private Sub dedFechaFinal_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dedFechaFinal.EditValueChanged
        validaFechas()
    End Sub
    Private Sub validaFechas()
        If dedFechaInicial.EditValue = Nothing Or dedFechaFinal.EditValue = Nothing Then
            btnGenerar.Enabled = False
        Else
            If dedFechaInicial.EditValue <> Nothing And dedFechaFinal.EditValue = Nothing Then
                btnGenerar.Enabled = False
            Else
                If dedFechaInicial.EditValue = Nothing And dedFechaFinal.EditValue <> Nothing Then
                    btnGenerar.Enabled = False
                Else
                    If dedFechaFinal.EditValue >= dedFechaInicial.EditValue Then
                        btnGenerar.Enabled = True
                    Else
                        btnGenerar.Enabled = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Dim empleadosHrsExtras As DataTable
        Dim fila As Data.DataRow
        Dim i As Integer
        empleadosHrsExtras = empleado.recuperaEmpleadosHorasExtrasAtraso(dedFechaInicial.EditValue, dedFechaFinal.EditValue)
        If empleadosHrsExtras.Rows.Count > 0 Then
            If MessageBox.Show("¿Esta usted seguro de generar el resumen mensual por empleado de horas extras y atraso?" & Chr(13) & Chr(13) & "Cualquier registro anterior existente de los parametros indicados serán eliminado." & Chr(13) & Chr(13) & "¿Desea continuar?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                i = 0
                prbProgreso.Minimum = 0
                prbProgreso.Maximum = empleadosHrsExtras.Rows.Count
                prbProgreso.Visible = True
                For Each fila In empleadosHrsExtras.Rows
                    empleado.generaResumenPagoHorasExtras(dedFechaInicial.EditValue, dedFechaFinal.EditValue, fila("EMPLEADO_ID"), "N")
                    i = i + 1
                    prbProgreso.Value = i
                Next
                System.Windows.Forms.MessageBox.Show("Se generaron " & CType(i, String) & " registros de empleados.", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                prbProgreso.Visible = False
            End If
        End If

    End Sub
End Class
