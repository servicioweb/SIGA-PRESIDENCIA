<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarCertificadoCapacitacion
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
        Me.gpcDatosParticipante = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombreParticipante = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreCapacitacion = New DevExpress.XtraEditors.TextEdit()
        Me.gpcCertificado = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPathCertificado = New DevExpress.XtraEditors.TextEdit()
        Me.btnExaminar = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lblEstadoCapacitacion = New DevExpress.XtraEditors.LabelControl()
        Me.btnGuardarCertificado = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gpcDatosParticipante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDatosParticipante.SuspendLayout()
        CType(Me.txtNombreParticipante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreCapacitacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcCertificado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcCertificado.SuspendLayout()
        CType(Me.txtPathCertificado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcDatosParticipante
        '
        Me.gpcDatosParticipante.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcDatosParticipante.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDatosParticipante.AppearanceCaption.Options.UseFont = True
        Me.gpcDatosParticipante.Controls.Add(Me.txtNombreCapacitacion)
        Me.gpcDatosParticipante.Controls.Add(Me.txtNombreParticipante)
        Me.gpcDatosParticipante.Controls.Add(Me.LabelControl2)
        Me.gpcDatosParticipante.Controls.Add(Me.LabelControl1)
        Me.gpcDatosParticipante.Location = New System.Drawing.Point(12, 12)
        Me.gpcDatosParticipante.Name = "gpcDatosParticipante"
        Me.gpcDatosParticipante.Size = New System.Drawing.Size(723, 79)
        Me.gpcDatosParticipante.TabIndex = 0
        Me.gpcDatosParticipante.Text = "Datos Participante"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 28)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nombre"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(5, 54)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Capacitación"
        '
        'txtNombreParticipante
        '
        Me.txtNombreParticipante.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreParticipante.Location = New System.Drawing.Point(72, 25)
        Me.txtNombreParticipante.Name = "txtNombreParticipante"
        Me.txtNombreParticipante.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNombreParticipante.Properties.Appearance.Options.UseBackColor = True
        Me.txtNombreParticipante.Properties.ReadOnly = True
        Me.txtNombreParticipante.Size = New System.Drawing.Size(646, 20)
        Me.txtNombreParticipante.TabIndex = 1
        '
        'txtNombreCapacitacion
        '
        Me.txtNombreCapacitacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreCapacitacion.Location = New System.Drawing.Point(72, 51)
        Me.txtNombreCapacitacion.Name = "txtNombreCapacitacion"
        Me.txtNombreCapacitacion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNombreCapacitacion.Properties.Appearance.Options.UseBackColor = True
        Me.txtNombreCapacitacion.Properties.ReadOnly = True
        Me.txtNombreCapacitacion.Size = New System.Drawing.Size(646, 20)
        Me.txtNombreCapacitacion.TabIndex = 1
        '
        'gpcCertificado
        '
        Me.gpcCertificado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcCertificado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcCertificado.AppearanceCaption.Options.UseFont = True
        Me.gpcCertificado.Controls.Add(Me.lblEstadoCapacitacion)
        Me.gpcCertificado.Controls.Add(Me.LabelControl4)
        Me.gpcCertificado.Controls.Add(Me.btnGuardarCertificado)
        Me.gpcCertificado.Controls.Add(Me.SimpleButton1)
        Me.gpcCertificado.Controls.Add(Me.btnExaminar)
        Me.gpcCertificado.Controls.Add(Me.txtPathCertificado)
        Me.gpcCertificado.Controls.Add(Me.LabelControl3)
        Me.gpcCertificado.Location = New System.Drawing.Point(12, 97)
        Me.gpcCertificado.Name = "gpcCertificado"
        Me.gpcCertificado.Size = New System.Drawing.Size(723, 116)
        Me.gpcCertificado.TabIndex = 1
        Me.gpcCertificado.Text = "Certificado"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(5, 31)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Capacitación"
        '
        'txtPathCertificado
        '
        Me.txtPathCertificado.Location = New System.Drawing.Point(72, 28)
        Me.txtPathCertificado.Name = "txtPathCertificado"
        Me.txtPathCertificado.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPathCertificado.Properties.Appearance.Options.UseBackColor = True
        Me.txtPathCertificado.Properties.ReadOnly = True
        Me.txtPathCertificado.Size = New System.Drawing.Size(525, 20)
        Me.txtPathCertificado.TabIndex = 1
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(603, 25)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(114, 23)
        Me.btnExaminar.TabIndex = 2
        Me.btnExaminar.Text = "Examinar..."
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(603, 83)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(114, 23)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "Ver Certificado"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(5, 64)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Estado Certificado:"
        '
        'lblEstadoCapacitacion
        '
        Me.lblEstadoCapacitacion.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEstadoCapacitacion.Appearance.Options.UseFont = True
        Me.lblEstadoCapacitacion.Location = New System.Drawing.Point(103, 64)
        Me.lblEstadoCapacitacion.Name = "lblEstadoCapacitacion"
        Me.lblEstadoCapacitacion.Size = New System.Drawing.Size(113, 13)
        Me.lblEstadoCapacitacion.TabIndex = 3
        Me.lblEstadoCapacitacion.Text = "Estado Capacitación"
        '
        'btnGuardarCertificado
        '
        Me.btnGuardarCertificado.Location = New System.Drawing.Point(602, 54)
        Me.btnGuardarCertificado.Name = "btnGuardarCertificado"
        Me.btnGuardarCertificado.Size = New System.Drawing.Size(115, 23)
        Me.btnGuardarCertificado.TabIndex = 2
        Me.btnGuardarCertificado.Text = "Guardar Certificado"
        '
        'frmAsignarCertificadoCapacitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 226)
        Me.Controls.Add(Me.gpcCertificado)
        Me.Controls.Add(Me.gpcDatosParticipante)
        Me.Name = "frmAsignarCertificadoCapacitacion"
        Me.Text = "Asignar Certificado Capacitación"
        CType(Me.gpcDatosParticipante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatosParticipante.ResumeLayout(False)
        Me.gpcDatosParticipante.PerformLayout()
        CType(Me.txtNombreParticipante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreCapacitacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcCertificado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcCertificado.ResumeLayout(False)
        Me.gpcCertificado.PerformLayout()
        CType(Me.txtPathCertificado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpcDatosParticipante As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtNombreCapacitacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreParticipante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gpcCertificado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExaminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPathCertificado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEstadoCapacitacion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGuardarCertificado As DevExpress.XtraEditors.SimpleButton
End Class
