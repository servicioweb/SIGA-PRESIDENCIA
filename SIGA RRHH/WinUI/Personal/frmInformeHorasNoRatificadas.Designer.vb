<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformeHorasNoRatificadas
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
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.pgcHorasExtrasNoRatificadas = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldEMPLEADO_ID = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRE_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHA_ASISTENCIA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHORAS_EXTRAS_DIURNAS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHORAS_EXTRAS_NOCTURNAS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHORAS_EXTRAS_DIURNAS_RATIF = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHORAS_EXTRAS_NOCTURNAS_RATIF = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDEPARTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRUT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDV = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHORA_ENTRADA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHORA_SALIDA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRE_AUTORIZADOR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCANTIDAD = New DevExpress.XtraPivotGrid.PivotGridField()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionAño.SuspendLayout()
        CType(Me.dedFechaFinal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgcHorasExtrasNoRatificadas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gpcSeleccionAño.Location = New System.Drawing.Point(1, 2)
        Me.gpcSeleccionAño.Name = "gpcSeleccionAño"
        Me.gpcSeleccionAño.Size = New System.Drawing.Size(826, 117)
        Me.gpcSeleccionAño.TabIndex = 6
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
        'pgcHorasExtrasNoRatificadas
        '
        Me.pgcHorasExtrasNoRatificadas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgcHorasExtrasNoRatificadas.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldEMPLEADO_ID, Me.fieldNOMBRE_EMPLEADO, Me.fieldFECHA_ASISTENCIA, Me.fieldHORAS_EXTRAS_DIURNAS, Me.fieldHORAS_EXTRAS_NOCTURNAS, Me.fieldHORAS_EXTRAS_DIURNAS_RATIF, Me.fieldHORAS_EXTRAS_NOCTURNAS_RATIF, Me.fieldDEPARTAMENTO, Me.fieldRUT, Me.fieldDV, Me.fieldHORA_ENTRADA, Me.fieldHORA_SALIDA, Me.fieldNOMBRE_AUTORIZADOR, Me.fieldCANTIDAD})
        Me.pgcHorasExtrasNoRatificadas.Location = New System.Drawing.Point(1, 126)
        Me.pgcHorasExtrasNoRatificadas.Name = "pgcHorasExtrasNoRatificadas"
        Me.pgcHorasExtrasNoRatificadas.Size = New System.Drawing.Size(826, 240)
        Me.pgcHorasExtrasNoRatificadas.TabIndex = 7
        '
        'fieldEMPLEADO_ID
        '
        Me.fieldEMPLEADO_ID.AreaIndex = 0
        Me.fieldEMPLEADO_ID.Caption = "Empleado Id"
        Me.fieldEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.fieldEMPLEADO_ID.Name = "fieldEMPLEADO_ID"
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
        'fieldFECHA_ASISTENCIA
        '
        Me.fieldFECHA_ASISTENCIA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldFECHA_ASISTENCIA.AreaIndex = 1
        Me.fieldFECHA_ASISTENCIA.Caption = "Fecha Asistencia"
        Me.fieldFECHA_ASISTENCIA.FieldName = "FECHA_ASISTENCIA"
        Me.fieldFECHA_ASISTENCIA.Name = "fieldFECHA_ASISTENCIA"
        Me.fieldFECHA_ASISTENCIA.Width = 120
        '
        'fieldHORAS_EXTRAS_DIURNAS
        '
        Me.fieldHORAS_EXTRAS_DIURNAS.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHORAS_EXTRAS_DIURNAS.AreaIndex = 2
        Me.fieldHORAS_EXTRAS_DIURNAS.Caption = "Hrs.Ext.Diurnas"
        Me.fieldHORAS_EXTRAS_DIURNAS.FieldName = "HORAS_EXTRAS_DIURNAS"
        Me.fieldHORAS_EXTRAS_DIURNAS.Name = "fieldHORAS_EXTRAS_DIURNAS"
        Me.fieldHORAS_EXTRAS_DIURNAS.Width = 150
        '
        'fieldHORAS_EXTRAS_NOCTURNAS
        '
        Me.fieldHORAS_EXTRAS_NOCTURNAS.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHORAS_EXTRAS_NOCTURNAS.AreaIndex = 4
        Me.fieldHORAS_EXTRAS_NOCTURNAS.Caption = "Hrs.Ext.Nocturnas"
        Me.fieldHORAS_EXTRAS_NOCTURNAS.FieldName = "HORAS_EXTRAS_NOCTURNAS"
        Me.fieldHORAS_EXTRAS_NOCTURNAS.Name = "fieldHORAS_EXTRAS_NOCTURNAS"
        Me.fieldHORAS_EXTRAS_NOCTURNAS.Width = 150
        '
        'fieldHORAS_EXTRAS_DIURNAS_RATIF
        '
        Me.fieldHORAS_EXTRAS_DIURNAS_RATIF.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHORAS_EXTRAS_DIURNAS_RATIF.AreaIndex = 3
        Me.fieldHORAS_EXTRAS_DIURNAS_RATIF.Caption = "Hrs.Ext.Diurnas Ratif."
        Me.fieldHORAS_EXTRAS_DIURNAS_RATIF.FieldName = "HORAS_EXTRAS_DIURNAS_RATIF"
        Me.fieldHORAS_EXTRAS_DIURNAS_RATIF.Name = "fieldHORAS_EXTRAS_DIURNAS_RATIF"
        Me.fieldHORAS_EXTRAS_DIURNAS_RATIF.Width = 150
        '
        'fieldHORAS_EXTRAS_NOCTURNAS_RATIF
        '
        Me.fieldHORAS_EXTRAS_NOCTURNAS_RATIF.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHORAS_EXTRAS_NOCTURNAS_RATIF.AreaIndex = 5
        Me.fieldHORAS_EXTRAS_NOCTURNAS_RATIF.Caption = "Hrs.Ext.Nocturnas Ratif."
        Me.fieldHORAS_EXTRAS_NOCTURNAS_RATIF.FieldName = "HORAS_EXTRAS_NOCTURNAS_RATIF"
        Me.fieldHORAS_EXTRAS_NOCTURNAS_RATIF.Name = "fieldHORAS_EXTRAS_NOCTURNAS_RATIF"
        Me.fieldHORAS_EXTRAS_NOCTURNAS_RATIF.Width = 150
        '
        'fieldDEPARTAMENTO
        '
        Me.fieldDEPARTAMENTO.AreaIndex = 1
        Me.fieldDEPARTAMENTO.Caption = "Departamento"
        Me.fieldDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.fieldDEPARTAMENTO.Name = "fieldDEPARTAMENTO"
        Me.fieldDEPARTAMENTO.Width = 250
        '
        'fieldRUT
        '
        Me.fieldRUT.AreaIndex = 2
        Me.fieldRUT.Caption = "Rut"
        Me.fieldRUT.FieldName = "RUT"
        Me.fieldRUT.Name = "fieldRUT"
        '
        'fieldDV
        '
        Me.fieldDV.AreaIndex = 3
        Me.fieldDV.Caption = "Dv"
        Me.fieldDV.FieldName = "DV"
        Me.fieldDV.Name = "fieldDV"
        '
        'fieldHORA_ENTRADA
        '
        Me.fieldHORA_ENTRADA.AreaIndex = 4
        Me.fieldHORA_ENTRADA.Caption = "Hra.Entrada"
        Me.fieldHORA_ENTRADA.FieldName = "HORA_ENTRADA"
        Me.fieldHORA_ENTRADA.Name = "fieldHORA_ENTRADA"
        '
        'fieldHORA_SALIDA
        '
        Me.fieldHORA_SALIDA.AreaIndex = 5
        Me.fieldHORA_SALIDA.Caption = "Hra.Salida"
        Me.fieldHORA_SALIDA.FieldName = "HORA_SALIDA"
        Me.fieldHORA_SALIDA.Name = "fieldHORA_SALIDA"
        '
        'fieldNOMBRE_AUTORIZADOR
        '
        Me.fieldNOMBRE_AUTORIZADOR.AreaIndex = 6
        Me.fieldNOMBRE_AUTORIZADOR.Caption = "Autorizador Hra.Extra"
        Me.fieldNOMBRE_AUTORIZADOR.FieldName = "NOMBRE_AUTORIZADOR"
        Me.fieldNOMBRE_AUTORIZADOR.Name = "fieldNOMBRE_AUTORIZADOR"
        Me.fieldNOMBRE_AUTORIZADOR.Width = 300
        '
        'fieldCANTIDAD
        '
        Me.fieldCANTIDAD.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCANTIDAD.AreaIndex = 0
        Me.fieldCANTIDAD.Caption = "Cantidad"
        Me.fieldCANTIDAD.FieldName = "CANTIDAD"
        Me.fieldCANTIDAD.Name = "fieldCANTIDAD"
        '
        'frmInformeHorasNoRatificadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 369)
        Me.Controls.Add(Me.pgcHorasExtrasNoRatificadas)
        Me.Controls.Add(Me.gpcSeleccionAño)
        Me.Name = "frmInformeHorasNoRatificadas"
        Me.Text = "Informe Horas Extras No Ratificadas"
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionAño.ResumeLayout(False)
        CType(Me.dedFechaFinal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgcHorasExtrasNoRatificadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpcSeleccionAño As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dedFechaFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dedFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblMesFinal As System.Windows.Forms.Label
    Friend WithEvents lblMesInicial As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pgcHorasExtrasNoRatificadas As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldEMPLEADO_ID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_ASISTENCIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORAS_EXTRAS_DIURNAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORAS_EXTRAS_NOCTURNAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORAS_EXTRAS_DIURNAS_RATIF As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORAS_EXTRAS_NOCTURNAS_RATIF As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDEPARTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORA_ENTRADA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORA_SALIDA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_AUTORIZADOR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCANTIDAD As DevExpress.XtraPivotGrid.PivotGridField
End Class
