<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformeAtrasos
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
        Me.gpcSeleccionAño = New DevExpress.XtraEditors.GroupControl()
        Me.dedFechaFinal = New DevExpress.XtraEditors.DateEdit()
        Me.dedFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.btnGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.lblMesFinal = New System.Windows.Forms.Label()
        Me.lblMesInicial = New System.Windows.Forms.Label()
        Me.pgcAtrasos = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.filedEMPLEADO_ID = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRE_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRUT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDV = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHORAS_ATRASO_HH = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDEPARTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCANTIDAD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionAño.SuspendLayout()
        CType(Me.dedFechaFinal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgcAtrasos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcSeleccionAño
        '
        Me.gpcSeleccionAño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionAño.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionAño.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionAño.Controls.Add(Me.dedFechaFinal)
        Me.gpcSeleccionAño.Controls.Add(Me.dedFechaInicio)
        Me.gpcSeleccionAño.Controls.Add(Me.btnGenerar)
        Me.gpcSeleccionAño.Controls.Add(Me.btnExportExcel)
        Me.gpcSeleccionAño.Controls.Add(Me.lblMesFinal)
        Me.gpcSeleccionAño.Controls.Add(Me.lblMesInicial)
        Me.gpcSeleccionAño.Location = New System.Drawing.Point(1, 3)
        Me.gpcSeleccionAño.Name = "gpcSeleccionAño"
        Me.gpcSeleccionAño.Size = New System.Drawing.Size(801, 117)
        Me.gpcSeleccionAño.TabIndex = 5
        Me.gpcSeleccionAño.Text = "Rango de Fecha"
        '
        'dedFechaFinal
        '
        Me.dedFechaFinal.EditValue = Nothing
        Me.dedFechaFinal.Location = New System.Drawing.Point(130, 73)
        Me.dedFechaFinal.Name = "dedFechaFinal"
        Me.dedFechaFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaFinal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaFinal.Size = New System.Drawing.Size(100, 20)
        Me.dedFechaFinal.TabIndex = 8
        '
        'dedFechaInicio
        '
        Me.dedFechaInicio.EditValue = Nothing
        Me.dedFechaInicio.Location = New System.Drawing.Point(130, 38)
        Me.dedFechaInicio.Name = "dedFechaInicio"
        Me.dedFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaInicio.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaInicio.Size = New System.Drawing.Size(100, 20)
        Me.dedFechaInicio.TabIndex = 7
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(300, 49)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(145, 23)
        Me.btnGenerar.TabIndex = 6
        Me.btnGenerar.Text = "Generar"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Location = New System.Drawing.Point(451, 49)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(144, 23)
        Me.btnExportExcel.TabIndex = 1
        Me.btnExportExcel.Text = "Exportar a Excel"
        '
        'lblMesFinal
        '
        Me.lblMesFinal.Location = New System.Drawing.Point(49, 76)
        Me.lblMesFinal.Name = "lblMesFinal"
        Me.lblMesFinal.Size = New System.Drawing.Size(63, 17)
        Me.lblMesFinal.TabIndex = 3
        Me.lblMesFinal.Text = "Mes Final"
        Me.lblMesFinal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMesInicial
        '
        Me.lblMesInicial.Location = New System.Drawing.Point(49, 43)
        Me.lblMesInicial.Name = "lblMesInicial"
        Me.lblMesInicial.Size = New System.Drawing.Size(63, 15)
        Me.lblMesInicial.TabIndex = 3
        Me.lblMesInicial.Text = "Mes Inicial"
        Me.lblMesInicial.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pgcAtrasos
        '
        Me.pgcAtrasos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgcAtrasos.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.filedEMPLEADO_ID, Me.fieldNOMBRE_EMPLEADO, Me.fieldRUT, Me.fieldDV, Me.fieldHORAS_ATRASO_HH, Me.fieldDEPARTAMENTO, Me.fieldCANTIDAD})
        Me.pgcAtrasos.Location = New System.Drawing.Point(1, 127)
        Me.pgcAtrasos.Name = "pgcAtrasos"
        Me.pgcAtrasos.Size = New System.Drawing.Size(801, 263)
        Me.pgcAtrasos.TabIndex = 6
        '
        'filedEMPLEADO_ID
        '
        Me.filedEMPLEADO_ID.AreaIndex = 0
        Me.filedEMPLEADO_ID.Caption = "Empleado ID"
        Me.filedEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.filedEMPLEADO_ID.Name = "filedEMPLEADO_ID"
        '
        'fieldNOMBRE_EMPLEADO
        '
        Me.fieldNOMBRE_EMPLEADO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNOMBRE_EMPLEADO.AreaIndex = 0
        Me.fieldNOMBRE_EMPLEADO.Caption = "Nombre Empleado"
        Me.fieldNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.Name = "fieldNOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.Width = 400
        '
        'fieldRUT
        '
        Me.fieldRUT.AreaIndex = 1
        Me.fieldRUT.Caption = "Rut"
        Me.fieldRUT.FieldName = "RUT"
        Me.fieldRUT.Name = "fieldRUT"
        '
        'fieldDV
        '
        Me.fieldDV.AreaIndex = 2
        Me.fieldDV.Caption = "Dv"
        Me.fieldDV.FieldName = "DV"
        Me.fieldDV.Name = "fieldDV"
        '
        'fieldHORAS_ATRASO_HH
        '
        Me.fieldHORAS_ATRASO_HH.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHORAS_ATRASO_HH.AreaIndex = 1
        Me.fieldHORAS_ATRASO_HH.Caption = "Horas Atraso"
        Me.fieldHORAS_ATRASO_HH.FieldName = "HORAS_ATRASO_HH"
        Me.fieldHORAS_ATRASO_HH.Name = "fieldHORAS_ATRASO_HH"
        '
        'fieldDEPARTAMENTO
        '
        Me.fieldDEPARTAMENTO.AreaIndex = 3
        Me.fieldDEPARTAMENTO.Caption = "Departamento"
        Me.fieldDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.fieldDEPARTAMENTO.Name = "fieldDEPARTAMENTO"
        Me.fieldDEPARTAMENTO.Width = 200
        '
        'fieldCANTIDAD
        '
        Me.fieldCANTIDAD.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCANTIDAD.AreaIndex = 0
        Me.fieldCANTIDAD.Caption = "Cantidad"
        Me.fieldCANTIDAD.FieldName = "CANTIDAD"
        Me.fieldCANTIDAD.Name = "fieldCANTIDAD"
        '
        'frmInformeAtrasos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 391)
        Me.Controls.Add(Me.pgcAtrasos)
        Me.Controls.Add(Me.gpcSeleccionAño)
        Me.Name = "frmInformeAtrasos"
        Me.Text = "Informe de atrasos por rango fecha"
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionAño.ResumeLayout(False)
        CType(Me.dedFechaFinal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgcAtrasos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpcSeleccionAño As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dedFechaFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dedFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblMesFinal As System.Windows.Forms.Label
    Friend WithEvents lblMesInicial As System.Windows.Forms.Label
    Friend WithEvents pgcAtrasos As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents filedEMPLEADO_ID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORAS_ATRASO_HH As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDEPARTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCANTIDAD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
