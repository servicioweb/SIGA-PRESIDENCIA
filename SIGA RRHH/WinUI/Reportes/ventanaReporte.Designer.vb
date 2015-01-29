<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventanaReporte
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
        Me.rptVisor = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'rptVisor
        '
        Me.rptVisor.ActiveViewIndex = -1
        Me.rptVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptVisor.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptVisor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptVisor.Location = New System.Drawing.Point(0, 0)
        Me.rptVisor.Name = "rptVisor"
        Me.rptVisor.Size = New System.Drawing.Size(619, 478)
        Me.rptVisor.TabIndex = 0
        '
        'ventanaReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 478)
        Me.Controls.Add(Me.rptVisor)
        Me.Name = "ventanaReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ventanaReporte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rptVisor As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
