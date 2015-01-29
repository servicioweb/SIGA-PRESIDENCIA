<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFestivos
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
        Me.gpcAno = New DevExpress.XtraEditors.GroupControl()
        Me.cboAno = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblSeleccioneAno = New DevExpress.XtraEditors.LabelControl()
        Me.gpcListaFeriados = New DevExpress.XtraEditors.GroupControl()
        Me.gdcListaFeriados = New DevExpress.XtraGrid.GridControl()
        Me.gdvListaFeriados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFestivoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaFestivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gpcAgregarFeriado = New DevExpress.XtraEditors.GroupControl()
        Me.btnGuardarFeriado = New DevExpress.XtraEditors.SimpleButton()
        Me.lblFecha = New DevExpress.XtraEditors.LabelControl()
        Me.detFechaFeriado = New DevExpress.XtraEditors.DateEdit()
        Me.txtNombreFeriado = New DevExpress.XtraEditors.TextEdit()
        Me.lblNombreFeriado = New DevExpress.XtraEditors.LabelControl()
        CType(Me.gpcAno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcAno.SuspendLayout()
        CType(Me.cboAno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcListaFeriados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcListaFeriados.SuspendLayout()
        CType(Me.gdcListaFeriados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvListaFeriados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcAgregarFeriado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcAgregarFeriado.SuspendLayout()
        CType(Me.detFechaFeriado.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detFechaFeriado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreFeriado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcAno
        '
        Me.gpcAno.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcAno.AppearanceCaption.Options.UseFont = True
        Me.gpcAno.Controls.Add(Me.cboAno)
        Me.gpcAno.Controls.Add(Me.lblSeleccioneAno)
        Me.gpcAno.Location = New System.Drawing.Point(12, 12)
        Me.gpcAno.Name = "gpcAno"
        Me.gpcAno.Size = New System.Drawing.Size(192, 71)
        Me.gpcAno.TabIndex = 0
        Me.gpcAno.Text = "Año Festivo"
        '
        'cboAno
        '
        Me.cboAno.Location = New System.Drawing.Point(98, 31)
        Me.cboAno.Name = "cboAno"
        Me.cboAno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAno.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboAno.Size = New System.Drawing.Size(83, 20)
        Me.cboAno.TabIndex = 1
        '
        'lblSeleccioneAno
        '
        Me.lblSeleccioneAno.Location = New System.Drawing.Point(5, 34)
        Me.lblSeleccioneAno.Name = "lblSeleccioneAno"
        Me.lblSeleccioneAno.Size = New System.Drawing.Size(87, 13)
        Me.lblSeleccioneAno.TabIndex = 0
        Me.lblSeleccioneAno.Text = "Seleccione un Año"
        '
        'gpcListaFeriados
        '
        Me.gpcListaFeriados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcListaFeriados.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcListaFeriados.AppearanceCaption.Options.UseFont = True
        Me.gpcListaFeriados.Controls.Add(Me.gdcListaFeriados)
        Me.gpcListaFeriados.Location = New System.Drawing.Point(12, 89)
        Me.gpcListaFeriados.Name = "gpcListaFeriados"
        Me.gpcListaFeriados.Size = New System.Drawing.Size(780, 451)
        Me.gpcListaFeriados.TabIndex = 1
        Me.gpcListaFeriados.Text = "Lista de Feriados"
        '
        'gdcListaFeriados
        '
        Me.gdcListaFeriados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gdcListaFeriados.Location = New System.Drawing.Point(2, 22)
        Me.gdcListaFeriados.MainView = Me.gdvListaFeriados
        Me.gdcListaFeriados.Name = "gdcListaFeriados"
        Me.gdcListaFeriados.Size = New System.Drawing.Size(776, 427)
        Me.gdcListaFeriados.TabIndex = 0
        Me.gdcListaFeriados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvListaFeriados})
        '
        'gdvListaFeriados
        '
        Me.gdvListaFeriados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFestivoID, Me.colFechaFestivo, Me.colDescripcion})
        Me.gdvListaFeriados.GridControl = Me.gdcListaFeriados
        Me.gdvListaFeriados.Name = "gdvListaFeriados"
        Me.gdvListaFeriados.OptionsView.ShowGroupPanel = False
        '
        'colFestivoID
        '
        Me.colFestivoID.Caption = "Festivo ID"
        Me.colFestivoID.FieldName = "FESTIVO_ID"
        Me.colFestivoID.Name = "colFestivoID"
        '
        'colFechaFestivo
        '
        Me.colFechaFestivo.Caption = "Fecha"
        Me.colFechaFestivo.FieldName = "FESTIVO"
        Me.colFechaFestivo.Name = "colFechaFestivo"
        Me.colFechaFestivo.Visible = True
        Me.colFechaFestivo.VisibleIndex = 0
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Nombre Festivo"
        Me.colDescripcion.FieldName = "DESCRIPCION"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        '
        'gpcAgregarFeriado
        '
        Me.gpcAgregarFeriado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcAgregarFeriado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcAgregarFeriado.AppearanceCaption.Options.UseFont = True
        Me.gpcAgregarFeriado.Controls.Add(Me.btnGuardarFeriado)
        Me.gpcAgregarFeriado.Controls.Add(Me.lblFecha)
        Me.gpcAgregarFeriado.Controls.Add(Me.detFechaFeriado)
        Me.gpcAgregarFeriado.Controls.Add(Me.txtNombreFeriado)
        Me.gpcAgregarFeriado.Controls.Add(Me.lblNombreFeriado)
        Me.gpcAgregarFeriado.Location = New System.Drawing.Point(210, 12)
        Me.gpcAgregarFeriado.Name = "gpcAgregarFeriado"
        Me.gpcAgregarFeriado.Size = New System.Drawing.Size(582, 71)
        Me.gpcAgregarFeriado.TabIndex = 2
        Me.gpcAgregarFeriado.Text = "Agregar Feriado"
        '
        'btnGuardarFeriado
        '
        Me.btnGuardarFeriado.Location = New System.Drawing.Point(472, 28)
        Me.btnGuardarFeriado.Name = "btnGuardarFeriado"
        Me.btnGuardarFeriado.Size = New System.Drawing.Size(98, 23)
        Me.btnGuardarFeriado.TabIndex = 4
        Me.btnGuardarFeriado.Text = "Guardar Feriado"
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(322, 34)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(29, 13)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "Fecha"
        '
        'detFechaFeriado
        '
        Me.detFechaFeriado.EditValue = Nothing
        Me.detFechaFeriado.Location = New System.Drawing.Point(357, 31)
        Me.detFechaFeriado.Name = "detFechaFeriado"
        Me.detFechaFeriado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.detFechaFeriado.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.detFechaFeriado.Size = New System.Drawing.Size(100, 20)
        Me.detFechaFeriado.TabIndex = 2
        '
        'txtNombreFeriado
        '
        Me.txtNombreFeriado.Location = New System.Drawing.Point(87, 31)
        Me.txtNombreFeriado.Name = "txtNombreFeriado"
        Me.txtNombreFeriado.Size = New System.Drawing.Size(215, 20)
        Me.txtNombreFeriado.TabIndex = 1
        '
        'lblNombreFeriado
        '
        Me.lblNombreFeriado.Location = New System.Drawing.Point(5, 34)
        Me.lblNombreFeriado.Name = "lblNombreFeriado"
        Me.lblNombreFeriado.Size = New System.Drawing.Size(76, 13)
        Me.lblNombreFeriado.TabIndex = 0
        Me.lblNombreFeriado.Text = "Nombre Feriado"
        '
        'frmFestivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 552)
        Me.Controls.Add(Me.gpcAgregarFeriado)
        Me.Controls.Add(Me.gpcListaFeriados)
        Me.Controls.Add(Me.gpcAno)
        Me.MinimumSize = New System.Drawing.Size(820, 39)
        Me.Name = "frmFestivos"
        Me.Text = "Mantenedor Festivos"
        CType(Me.gpcAno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcAno.ResumeLayout(False)
        Me.gpcAno.PerformLayout()
        CType(Me.cboAno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcListaFeriados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcListaFeriados.ResumeLayout(False)
        CType(Me.gdcListaFeriados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvListaFeriados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcAgregarFeriado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcAgregarFeriado.ResumeLayout(False)
        Me.gpcAgregarFeriado.PerformLayout()
        CType(Me.detFechaFeriado.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detFechaFeriado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreFeriado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpcAno As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboAno As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblSeleccioneAno As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gpcListaFeriados As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gpcAgregarFeriado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblNombreFeriado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGuardarFeriado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblFecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents detFechaFeriado As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNombreFeriado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gdcListaFeriados As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvListaFeriados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFestivoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaFestivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
End Class
