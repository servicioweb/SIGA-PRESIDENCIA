<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpuestoSegundaCategoria
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
        Me.lblPeriodo = New DevExpress.XtraEditors.LabelControl()
        Me.lblUtm = New DevExpress.XtraEditors.LabelControl()
        Me.txtPeriodo = New DevExpress.XtraEditors.TextEdit()
        Me.txtUtm = New DevExpress.XtraEditors.TextEdit()
        Me.gpcPeriodo = New DevExpress.XtraEditors.GroupControl()
        Me.gpcTramos = New DevExpress.XtraEditors.GroupControl()
        Me.gdcTramos = New DevExpress.XtraGrid.GridControl()
        Me.gdvTramos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colImpuestoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTramo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesde = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesdeMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHastaUTM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHastaMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFactor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRebajaUTM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRebajaMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.txtPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUtm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcPeriodo.SuspendLayout()
        CType(Me.gpcTramos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcTramos.SuspendLayout()
        CType(Me.gdcTramos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvTramos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPeriodo.Appearance.Options.UseFont = True
        Me.lblPeriodo.Location = New System.Drawing.Point(19, 44)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(43, 13)
        Me.lblPeriodo.TabIndex = 0
        Me.lblPeriodo.Text = "Período"
        '
        'lblUtm
        '
        Me.lblUtm.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblUtm.Appearance.Options.UseFont = True
        Me.lblUtm.Location = New System.Drawing.Point(257, 44)
        Me.lblUtm.Name = "lblUtm"
        Me.lblUtm.Size = New System.Drawing.Size(25, 13)
        Me.lblUtm.TabIndex = 0
        Me.lblUtm.Text = "UTM"
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Location = New System.Drawing.Point(68, 41)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPeriodo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPeriodo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtPeriodo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtPeriodo.Properties.ReadOnly = True
        Me.txtPeriodo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPeriodo.Size = New System.Drawing.Size(100, 20)
        Me.txtPeriodo.TabIndex = 1
        '
        'txtUtm
        '
        Me.txtUtm.Location = New System.Drawing.Point(288, 41)
        Me.txtUtm.Name = "txtUtm"
        Me.txtUtm.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUtm.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtUtm.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtUtm.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtUtm.Properties.ReadOnly = True
        Me.txtUtm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUtm.Size = New System.Drawing.Size(100, 20)
        Me.txtUtm.TabIndex = 1
        '
        'gpcPeriodo
        '
        Me.gpcPeriodo.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcPeriodo.AppearanceCaption.Options.UseFont = True
        Me.gpcPeriodo.Controls.Add(Me.lblPeriodo)
        Me.gpcPeriodo.Controls.Add(Me.txtUtm)
        Me.gpcPeriodo.Controls.Add(Me.lblUtm)
        Me.gpcPeriodo.Controls.Add(Me.txtPeriodo)
        Me.gpcPeriodo.Location = New System.Drawing.Point(12, 12)
        Me.gpcPeriodo.Name = "gpcPeriodo"
        Me.gpcPeriodo.Size = New System.Drawing.Size(489, 94)
        Me.gpcPeriodo.TabIndex = 2
        Me.gpcPeriodo.Text = "Período"
        '
        'gpcTramos
        '
        Me.gpcTramos.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcTramos.AppearanceCaption.Options.UseFont = True
        Me.gpcTramos.Controls.Add(Me.gdcTramos)
        Me.gpcTramos.Location = New System.Drawing.Point(12, 112)
        Me.gpcTramos.Name = "gpcTramos"
        Me.gpcTramos.Size = New System.Drawing.Size(967, 366)
        Me.gpcTramos.TabIndex = 3
        Me.gpcTramos.Text = "Tramos"
        '
        'gdcTramos
        '
        Me.gdcTramos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gdcTramos.Location = New System.Drawing.Point(2, 22)
        Me.gdcTramos.MainView = Me.gdvTramos
        Me.gdcTramos.Name = "gdcTramos"
        Me.gdcTramos.Size = New System.Drawing.Size(963, 342)
        Me.gdcTramos.TabIndex = 0
        Me.gdcTramos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvTramos})
        '
        'gdvTramos
        '
        Me.gdvTramos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colImpuestoID, Me.colTramo, Me.colDesde, Me.colDesdeMonto, Me.colHastaUTM, Me.colHastaMonto, Me.colFactor, Me.colRebajaUTM, Me.colRebajaMonto})
        Me.gdvTramos.GridControl = Me.gdcTramos
        Me.gdvTramos.Name = "gdvTramos"
        Me.gdvTramos.OptionsView.ShowGroupPanel = False
        '
        'colImpuestoID
        '
        Me.colImpuestoID.Caption = "Impuesto ID"
        Me.colImpuestoID.FieldName = "IMPUESTO_ID"
        Me.colImpuestoID.Name = "colImpuestoID"
        Me.colImpuestoID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colImpuestoID.OptionsColumn.AllowMove = False
        '
        'colTramo
        '
        Me.colTramo.Caption = "Tramo"
        Me.colTramo.FieldName = "TRAMO"
        Me.colTramo.Name = "colTramo"
        Me.colTramo.OptionsColumn.AllowEdit = False
        Me.colTramo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colTramo.OptionsColumn.AllowMove = False
        Me.colTramo.OptionsColumn.ReadOnly = True
        Me.colTramo.Visible = True
        Me.colTramo.VisibleIndex = 0
        '
        'colDesde
        '
        Me.colDesde.Caption = "Desde UTM"
        Me.colDesde.FieldName = "DESDE"
        Me.colDesde.Name = "colDesde"
        Me.colDesde.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDesde.OptionsColumn.AllowMove = False
        Me.colDesde.Visible = True
        Me.colDesde.VisibleIndex = 1
        '
        'colDesdeMonto
        '
        Me.colDesdeMonto.Caption = "Desde Monto"
        Me.colDesdeMonto.FieldName = "DESDE_MONTO"
        Me.colDesdeMonto.Name = "colDesdeMonto"
        Me.colDesdeMonto.OptionsColumn.AllowEdit = False
        Me.colDesdeMonto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDesdeMonto.OptionsColumn.AllowMove = False
        Me.colDesdeMonto.OptionsColumn.ReadOnly = True
        Me.colDesdeMonto.Visible = True
        Me.colDesdeMonto.VisibleIndex = 2
        '
        'colHastaUTM
        '
        Me.colHastaUTM.Caption = "Hasta UTM"
        Me.colHastaUTM.FieldName = "HASTA"
        Me.colHastaUTM.Name = "colHastaUTM"
        Me.colHastaUTM.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colHastaUTM.OptionsColumn.AllowMove = False
        Me.colHastaUTM.Visible = True
        Me.colHastaUTM.VisibleIndex = 3
        '
        'colHastaMonto
        '
        Me.colHastaMonto.Caption = "Hasta Monto"
        Me.colHastaMonto.FieldName = "HASTA_MONTO"
        Me.colHastaMonto.Name = "colHastaMonto"
        Me.colHastaMonto.OptionsColumn.AllowEdit = False
        Me.colHastaMonto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colHastaMonto.OptionsColumn.AllowMove = False
        Me.colHastaMonto.OptionsColumn.ReadOnly = True
        Me.colHastaMonto.Visible = True
        Me.colHastaMonto.VisibleIndex = 4
        '
        'colFactor
        '
        Me.colFactor.Caption = "Factor"
        Me.colFactor.FieldName = "FACTOR"
        Me.colFactor.Name = "colFactor"
        Me.colFactor.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colFactor.OptionsColumn.AllowMove = False
        Me.colFactor.Visible = True
        Me.colFactor.VisibleIndex = 5
        '
        'colRebajaUTM
        '
        Me.colRebajaUTM.Caption = "Rebaja UTM"
        Me.colRebajaUTM.FieldName = "REBAJA"
        Me.colRebajaUTM.Name = "colRebajaUTM"
        Me.colRebajaUTM.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colRebajaUTM.OptionsColumn.AllowMove = False
        Me.colRebajaUTM.Visible = True
        Me.colRebajaUTM.VisibleIndex = 6
        '
        'colRebajaMonto
        '
        Me.colRebajaMonto.Caption = "Rebaja Monto"
        Me.colRebajaMonto.FieldName = "REBAJA_MONTO"
        Me.colRebajaMonto.Name = "colRebajaMonto"
        Me.colRebajaMonto.OptionsColumn.AllowEdit = False
        Me.colRebajaMonto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colRebajaMonto.OptionsColumn.AllowMove = False
        Me.colRebajaMonto.OptionsColumn.ReadOnly = True
        Me.colRebajaMonto.Visible = True
        Me.colRebajaMonto.VisibleIndex = 7
        '
        'frmImpuestoSegundaCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 490)
        Me.Controls.Add(Me.gpcTramos)
        Me.Controls.Add(Me.gpcPeriodo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImpuestoSegundaCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impuesto 2da Categoría"
        CType(Me.txtPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUtm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcPeriodo.ResumeLayout(False)
        Me.gpcPeriodo.PerformLayout()
        CType(Me.gpcTramos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcTramos.ResumeLayout(False)
        CType(Me.gdcTramos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvTramos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPeriodo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUtm As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUtm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpcPeriodo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gpcTramos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gdcTramos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvTramos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colImpuestoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTramo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesdeMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHastaUTM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHastaMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFactor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRebajaUTM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRebajaMonto As DevExpress.XtraGrid.Columns.GridColumn
End Class
