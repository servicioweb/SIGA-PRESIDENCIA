<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantencionItemPeriodo_ImportarPlanilla
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gpcSeleccionePlanillaASubir = New DevExpress.XtraEditors.GroupControl()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnProcesarPlanilla = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExaminar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtRutaPlanilla = New DevExpress.XtraEditors.TextEdit()
        Me.lblPathPlanilla = New DevExpress.XtraEditors.LabelControl()
        Me.gpcResultados = New DevExpress.XtraEditors.GroupControl()
        Me.moeResultados = New DevExpress.XtraEditors.MemoEdit()
        Me.btnProcesarInformacion = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gpcSeleccionePlanillaASubir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionePlanillaASubir.SuspendLayout()
        CType(Me.txtRutaPlanilla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcResultados.SuspendLayout()
        CType(Me.moeResultados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcSeleccionePlanillaASubir
        '
        Me.gpcSeleccionePlanillaASubir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionePlanillaASubir.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionePlanillaASubir.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionePlanillaASubir.Controls.Add(Me.btnLimpiar)
        Me.gpcSeleccionePlanillaASubir.Controls.Add(Me.btnProcesarPlanilla)
        Me.gpcSeleccionePlanillaASubir.Controls.Add(Me.btnExaminar)
        Me.gpcSeleccionePlanillaASubir.Controls.Add(Me.txtRutaPlanilla)
        Me.gpcSeleccionePlanillaASubir.Controls.Add(Me.lblPathPlanilla)
        Me.gpcSeleccionePlanillaASubir.Location = New System.Drawing.Point(13, 13)
        Me.gpcSeleccionePlanillaASubir.Name = "gpcSeleccionePlanillaASubir"
        Me.gpcSeleccionePlanillaASubir.Size = New System.Drawing.Size(785, 121)
        Me.gpcSeleccionePlanillaASubir.TabIndex = 0
        Me.gpcSeleccionePlanillaASubir.Text = "Seleccione planilla a subir"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(655, 54)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(125, 23)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnProcesarPlanilla
        '
        Me.btnProcesarPlanilla.Location = New System.Drawing.Point(655, 83)
        Me.btnProcesarPlanilla.Name = "btnProcesarPlanilla"
        Me.btnProcesarPlanilla.Size = New System.Drawing.Size(125, 23)
        Me.btnProcesarPlanilla.TabIndex = 3
        Me.btnProcesarPlanilla.Text = "Validar Planilla"
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(655, 25)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(125, 23)
        Me.btnExaminar.TabIndex = 2
        Me.btnExaminar.Text = "Examinar..."
        '
        'txtRutaPlanilla
        '
        Me.txtRutaPlanilla.Location = New System.Drawing.Point(89, 25)
        Me.txtRutaPlanilla.Name = "txtRutaPlanilla"
        Me.txtRutaPlanilla.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtRutaPlanilla.Properties.Appearance.Options.UseBackColor = True
        Me.txtRutaPlanilla.Properties.ReadOnly = True
        Me.txtRutaPlanilla.Size = New System.Drawing.Size(560, 20)
        Me.txtRutaPlanilla.TabIndex = 1
        '
        'lblPathPlanilla
        '
        Me.lblPathPlanilla.Location = New System.Drawing.Point(25, 28)
        Me.lblPathPlanilla.Name = "lblPathPlanilla"
        Me.lblPathPlanilla.Size = New System.Drawing.Size(58, 13)
        Me.lblPathPlanilla.TabIndex = 0
        Me.lblPathPlanilla.Text = "Ruta Planilla"
        '
        'gpcResultados
        '
        Me.gpcResultados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcResultados.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcResultados.AppearanceCaption.Options.UseFont = True
        Me.gpcResultados.Controls.Add(Me.moeResultados)
        Me.gpcResultados.Location = New System.Drawing.Point(13, 140)
        Me.gpcResultados.Name = "gpcResultados"
        Me.gpcResultados.Size = New System.Drawing.Size(785, 320)
        Me.gpcResultados.TabIndex = 1
        Me.gpcResultados.Text = "Resultados Importación"
        '
        'moeResultados
        '
        Me.moeResultados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.moeResultados.Location = New System.Drawing.Point(5, 25)
        Me.moeResultados.Name = "moeResultados"
        Me.moeResultados.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.moeResultados.Properties.Appearance.Options.UseBackColor = True
        Me.moeResultados.Properties.ReadOnly = True
        Me.moeResultados.Size = New System.Drawing.Size(775, 290)
        Me.moeResultados.TabIndex = 0
        '
        'btnProcesarInformacion
        '
        Me.btnProcesarInformacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcesarInformacion.Enabled = False
        Me.btnProcesarInformacion.Location = New System.Drawing.Point(610, 466)
        Me.btnProcesarInformacion.Name = "btnProcesarInformacion"
        Me.btnProcesarInformacion.Size = New System.Drawing.Size(188, 23)
        Me.btnProcesarInformacion.TabIndex = 1
        Me.btnProcesarInformacion.Text = "Procesar Información"
        '
        'frmMantencionItemPeriodo_ImportarPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 501)
        Me.Controls.Add(Me.btnProcesarInformacion)
        Me.Controls.Add(Me.gpcResultados)
        Me.Controls.Add(Me.gpcSeleccionePlanillaASubir)
        Me.MinimizeBox = False
        Me.Name = "frmMantencionItemPeriodo_ImportarPlanilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Planilla"
        CType(Me.gpcSeleccionePlanillaASubir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionePlanillaASubir.ResumeLayout(False)
        Me.gpcSeleccionePlanillaASubir.PerformLayout()
        CType(Me.txtRutaPlanilla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcResultados.ResumeLayout(False)
        CType(Me.moeResultados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpcSeleccionePlanillaASubir As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnProcesarPlanilla As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExaminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRutaPlanilla As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPathPlanilla As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gpcResultados As DevExpress.XtraEditors.GroupControl
    Friend WithEvents moeResultados As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnProcesarInformacion As DevExpress.XtraEditors.SimpleButton
End Class
