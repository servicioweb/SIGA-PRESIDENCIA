<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpuestoAcumulado
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gpcFiltoAño = New DevExpress.XtraEditors.GroupControl()
        Me.lueIpcAcumulado = New DevExpress.XtraEditors.LookUpEdit()
        Me.gpcDatos = New DevExpress.XtraEditors.GroupControl()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.txtMes = New DevExpress.XtraEditors.SpinEdit()
        Me.txtAño = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIPC = New DevExpress.XtraEditors.TextEdit()
        Me.gpcBotones = New DevExpress.XtraEditors.GroupControl()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gpcFiltoAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcFiltoAño.SuspendLayout()
        CType(Me.lueIpcAcumulado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDatos.SuspendLayout()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAño.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIPC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpcFiltoAño
        '
        Me.gpcFiltoAño.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcFiltoAño.AppearanceCaption.Options.UseFont = True
        Me.gpcFiltoAño.Controls.Add(Me.lueIpcAcumulado)
        Me.gpcFiltoAño.Location = New System.Drawing.Point(1, 2)
        Me.gpcFiltoAño.Name = "gpcFiltoAño"
        Me.gpcFiltoAño.Size = New System.Drawing.Size(569, 64)
        Me.gpcFiltoAño.TabIndex = 0
        Me.gpcFiltoAño.Text = "Filtro Año"
        '
        'lueIpcAcumulado
        '
        Me.lueIpcAcumulado.Location = New System.Drawing.Point(216, 33)
        Me.lueIpcAcumulado.Name = "lueIpcAcumulado"
        Me.lueIpcAcumulado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueIpcAcumulado.Size = New System.Drawing.Size(100, 20)
        Me.lueIpcAcumulado.TabIndex = 0
        '
        'gpcDatos
        '
        Me.gpcDatos.Controls.Add(Me.txtID)
        Me.gpcDatos.Controls.Add(Me.txtMes)
        Me.gpcDatos.Controls.Add(Me.txtAño)
        Me.gpcDatos.Controls.Add(Me.LabelControl3)
        Me.gpcDatos.Controls.Add(Me.LabelControl2)
        Me.gpcDatos.Controls.Add(Me.LabelControl1)
        Me.gpcDatos.Controls.Add(Me.txtIPC)
        Me.gpcDatos.Location = New System.Drawing.Point(1, 73)
        Me.gpcDatos.Name = "gpcDatos"
        Me.gpcDatos.ShowCaption = False
        Me.gpcDatos.Size = New System.Drawing.Size(569, 148)
        Me.gpcDatos.TabIndex = 1
        Me.gpcDatos.Text = "GroupControl1"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(216, 118)
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.DisplayFormat.FormatString = "n6"
        Me.txtID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtID.Properties.EditFormat.FormatString = "n6"
        Me.txtID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtID.Properties.Mask.EditMask = "n6"
        Me.txtID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtID.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtID.Properties.MaxLength = 10
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 6
        Me.txtID.Visible = False
        '
        'txtMes
        '
        Me.txtMes.EditValue = New Decimal(New Integer() {12, 0, 0, 0})
        Me.txtMes.Location = New System.Drawing.Point(216, 56)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtMes.Properties.DisplayFormat.FormatString = "n0"
        Me.txtMes.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMes.Properties.EditFormat.FormatString = "n0"
        Me.txtMes.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMes.Properties.Mask.EditMask = "n0"
        Me.txtMes.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMes.Properties.MaxLength = 2
        Me.txtMes.Properties.MaxValue = New Decimal(New Integer() {12, 0, 0, 0})
        Me.txtMes.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtMes.Size = New System.Drawing.Size(100, 20)
        Me.txtMes.TabIndex = 2
        '
        'txtAño
        '
        Me.txtAño.EditValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.txtAño.Location = New System.Drawing.Point(216, 23)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtAño.Properties.DisplayFormat.FormatString = "n0"
        Me.txtAño.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAño.Properties.EditFormat.FormatString = "n0"
        Me.txtAño.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAño.Properties.Mask.EditMask = "n0"
        Me.txtAño.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAño.Properties.MaxLength = 4
        Me.txtAño.Properties.MaxValue = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.txtAño.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.txtAño.Size = New System.Drawing.Size(100, 20)
        Me.txtAño.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(150, 95)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "IPC"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(150, 59)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Mes"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(150, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Año"
        '
        'txtIPC
        '
        Me.txtIPC.Location = New System.Drawing.Point(216, 92)
        Me.txtIPC.Name = "txtIPC"
        Me.txtIPC.Properties.DisplayFormat.FormatString = "n6"
        Me.txtIPC.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIPC.Properties.EditFormat.FormatString = "n6"
        Me.txtIPC.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIPC.Properties.MaxLength = 10
        Me.txtIPC.Size = New System.Drawing.Size(100, 20)
        Me.txtIPC.TabIndex = 3
        '
        'gpcBotones
        '
        Me.gpcBotones.Controls.Add(Me.btnEliminar)
        Me.gpcBotones.Controls.Add(Me.btnGuardar)
        Me.gpcBotones.Controls.Add(Me.btnNuevo)
        Me.gpcBotones.Location = New System.Drawing.Point(1, 228)
        Me.gpcBotones.Name = "gpcBotones"
        Me.gpcBotones.ShowCaption = False
        Me.gpcBotones.Size = New System.Drawing.Size(569, 92)
        Me.gpcBotones.TabIndex = 2
        Me.gpcBotones.Text = "GroupControl1"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(316, 31)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(204, 31)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(92, 31)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        '
        'frmImpuestoAcumulado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 321)
        Me.Controls.Add(Me.gpcBotones)
        Me.Controls.Add(Me.gpcDatos)
        Me.Controls.Add(Me.gpcFiltoAño)
        Me.Name = "frmImpuestoAcumulado"
        Me.Text = "frmImpuestoAcumulado"
        CType(Me.gpcFiltoAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcFiltoAño.ResumeLayout(False)
        CType(Me.lueIpcAcumulado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatos.ResumeLayout(False)
        Me.gpcDatos.PerformLayout()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAño.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIPC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpcFiltoAño As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gpcDatos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIPC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpcBotones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtAño As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtMes As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lueIpcAcumulado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
End Class
