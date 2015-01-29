<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiltroLiquidacionesPorEmpleado
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
        Me.lueEmpleado = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblNombreEmpleado = New DevExpress.XtraEditors.LabelControl()
        Me.clbLiquidacionesEmpleado = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.lblLiquidaciones = New DevExpress.XtraEditors.LabelControl()
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.lueEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clbLiquidacionesEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lueEmpleado
        '
        Me.lueEmpleado.Location = New System.Drawing.Point(8, 27)
        Me.lueEmpleado.Name = "lueEmpleado"
        Me.lueEmpleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueEmpleado.Size = New System.Drawing.Size(376, 20)
        Me.lueEmpleado.TabIndex = 0
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(8, 10)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(86, 13)
        Me.lblNombreEmpleado.TabIndex = 1
        Me.lblNombreEmpleado.Text = "Nombre Empleado"
        '
        'clbLiquidacionesEmpleado
        '
        Me.clbLiquidacionesEmpleado.Location = New System.Drawing.Point(8, 77)
        Me.clbLiquidacionesEmpleado.Name = "clbLiquidacionesEmpleado"
        Me.clbLiquidacionesEmpleado.Size = New System.Drawing.Size(376, 195)
        Me.clbLiquidacionesEmpleado.TabIndex = 33
        '
        'lblLiquidaciones
        '
        Me.lblLiquidaciones.Location = New System.Drawing.Point(8, 60)
        Me.lblLiquidaciones.Name = "lblLiquidaciones"
        Me.lblLiquidaciones.Size = New System.Drawing.Size(63, 13)
        Me.lblLiquidaciones.TabIndex = 34
        Me.lblLiquidaciones.Text = "Liquidaciones"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(8, 291)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(376, 23)
        Me.btnVisualizar.TabIndex = 35
        Me.btnVisualizar.Text = "Visualizar"
        '
        'frmFiltroLiquidacionesPorEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 332)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.lblLiquidaciones)
        Me.Controls.Add(Me.clbLiquidacionesEmpleado)
        Me.Controls.Add(Me.lblNombreEmpleado)
        Me.Controls.Add(Me.lueEmpleado)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFiltroLiquidacionesPorEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidaciones por Empleado"
        CType(Me.lueEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clbLiquidacionesEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lueEmpleado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblNombreEmpleado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents clbLiquidacionesEmpleado As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents lblLiquidaciones As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
End Class
