Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Windows.Forms
Imports System.Drawing
Imports System

Public Class frmAnalisisHorasCompensadas
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
    Friend WithEvents gpcSeleccionAño As DevExpress.XtraEditors.GroupControl
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents pgcAnalisisAtrasos As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldEMPLEADO_ID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDEPARTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCALIDAD_JURIDICA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sfdHorasAtraso As System.Windows.Forms.SaveFileDialog
    Friend WithEvents fieldANO_REAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMES_REAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPROCESO_HORAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORAS_EXTRAS_MAXIMA_DIURNA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORAS_EXTRAS_MAXIMA_NOCTURNA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORAS_COMPENSADAS_DIURNA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORAS_COMPENSADAS_NOCTURNA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANO_PROCESO_REMUN As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMES_PROCESO_REMUN As DevExpress.XtraPivotGrid.PivotGridField
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.pgcAnalisisAtrasos = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.fieldANO_REAL = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMES_REAL = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldEMPLEADO_ID = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOMBRE_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldPROCESO_HORAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDEPARTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCALIDAD_JURIDICA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHORAS_COMPENSADAS_DIURNA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHORAS_COMPENSADAS_NOCTURNA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldESTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldRUT = New DevExpress.XtraPivotGrid.PivotGridField
        Me.gpcSeleccionAño = New DevExpress.XtraEditors.GroupControl
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton
        Me.sfdHorasAtraso = New System.Windows.Forms.SaveFileDialog
        Me.fieldANO_PROCESO_REMUN = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMES_PROCESO_REMUN = New DevExpress.XtraPivotGrid.PivotGridField
        CType(Me.pgcAnalisisAtrasos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionAño.SuspendLayout()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pgcAnalisisAtrasos
        '
        Me.pgcAnalisisAtrasos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgcAnalisisAtrasos.Cursor = System.Windows.Forms.Cursors.Default
        Me.pgcAnalisisAtrasos.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldANO_REAL, Me.fieldMES_REAL, Me.fieldEMPLEADO_ID, Me.fieldNOMBRE_EMPLEADO, Me.fieldPROCESO_HORAS, Me.fieldDEPARTAMENTO, Me.fieldCALIDAD_JURIDICA, Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA, Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA, Me.fieldHORAS_COMPENSADAS_DIURNA, Me.fieldHORAS_COMPENSADAS_NOCTURNA, Me.fieldESTAMENTO, Me.fieldRUT, Me.fieldANO_PROCESO_REMUN, Me.fieldMES_PROCESO_REMUN})
        Me.pgcAnalisisAtrasos.Location = New System.Drawing.Point(0, 80)
        Me.pgcAnalisisAtrasos.Name = "pgcAnalisisAtrasos"
        Me.pgcAnalisisAtrasos.Size = New System.Drawing.Size(768, 216)
        Me.pgcAnalisisAtrasos.TabIndex = 0
        '
        'fieldANO_REAL
        '
        Me.fieldANO_REAL.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldANO_REAL.AreaIndex = 0
        Me.fieldANO_REAL.Caption = "Año"
        Me.fieldANO_REAL.FieldName = "ANO_REAL"
        Me.fieldANO_REAL.Name = "fieldANO_REAL"
        '
        'fieldMES_REAL
        '
        Me.fieldMES_REAL.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldMES_REAL.AreaIndex = 1
        Me.fieldMES_REAL.Caption = "Mes"
        Me.fieldMES_REAL.FieldName = "MES_REAL"
        Me.fieldMES_REAL.Name = "fieldMES_REAL"
        '
        'fieldEMPLEADO_ID
        '
        Me.fieldEMPLEADO_ID.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldEMPLEADO_ID.AreaIndex = 1
        Me.fieldEMPLEADO_ID.Caption = "Empleado ID"
        Me.fieldEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.fieldEMPLEADO_ID.Name = "fieldEMPLEADO_ID"
        '
        'fieldNOMBRE_EMPLEADO
        '
        Me.fieldNOMBRE_EMPLEADO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNOMBRE_EMPLEADO.AreaIndex = 2
        Me.fieldNOMBRE_EMPLEADO.Caption = "Nombre Empleado"
        Me.fieldNOMBRE_EMPLEADO.FieldName = "NOMBRES"
        Me.fieldNOMBRE_EMPLEADO.Name = "fieldNOMBRE_EMPLEADO"
        '
        'fieldPROCESO_HORAS
        '
        Me.fieldPROCESO_HORAS.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldPROCESO_HORAS.AreaIndex = 3
        Me.fieldPROCESO_HORAS.Caption = "Tipo Proceso"
        Me.fieldPROCESO_HORAS.CellFormat.FormatString = "d"
        Me.fieldPROCESO_HORAS.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldPROCESO_HORAS.FieldName = "PROCESO_HORAS"
        Me.fieldPROCESO_HORAS.Name = "fieldPROCESO_HORAS"
        Me.fieldPROCESO_HORAS.ValueFormat.FormatString = "d"
        Me.fieldPROCESO_HORAS.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'fieldDEPARTAMENTO
        '
        Me.fieldDEPARTAMENTO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldDEPARTAMENTO.AreaIndex = 0
        Me.fieldDEPARTAMENTO.Caption = "Departamento"
        Me.fieldDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.fieldDEPARTAMENTO.Name = "fieldDEPARTAMENTO"
        '
        'fieldCALIDAD_JURIDICA
        '
        Me.fieldCALIDAD_JURIDICA.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldCALIDAD_JURIDICA.AreaIndex = 2
        Me.fieldCALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.fieldCALIDAD_JURIDICA.FieldName = "CALIDAD_JURIDICA"
        Me.fieldCALIDAD_JURIDICA.Name = "fieldCALIDAD_JURIDICA"
        '
        'fieldHORAS_EXTRAS_MAXIMA_DIURNA
        '
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.AreaIndex = 0
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.Caption = "Hora Ext.Diurna"
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.FieldName = "HORAS_EXTRAS_MAXIMA_DIURNA"
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.Name = "fieldHORAS_EXTRAS_MAXIMA_DIURNA"
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.TotalCellFormat.FormatString = "n0"
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.TotalValueFormat.FormatString = "n0"
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.ValueFormat.FormatString = "n0"
        Me.fieldHORAS_EXTRAS_MAXIMA_DIURNA.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldHORAS_EXTRAS_MAXIMA_NOCTURNA
        '
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.AreaIndex = 1
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.Caption = "Hora Ext. Nocturna"
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.FieldName = "HORAS_EXTRAS_MAXIMA_NOCTURNA"
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.Name = "fieldHORAS_EXTRAS_MAXIMA_NOCTURNA"
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.TotalCellFormat.FormatString = "n0"
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.TotalValueFormat.FormatString = "n0"
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.ValueFormat.FormatString = "n0"
        Me.fieldHORAS_EXTRAS_MAXIMA_NOCTURNA.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldHORAS_COMPENSADAS_DIURNA
        '
        Me.fieldHORAS_COMPENSADAS_DIURNA.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldHORAS_COMPENSADAS_DIURNA.AreaIndex = 2
        Me.fieldHORAS_COMPENSADAS_DIURNA.Caption = "Hrs.Compensada Diurna"
        Me.fieldHORAS_COMPENSADAS_DIURNA.FieldName = "HORAS_COMPENSADAS_DIURNA"
        Me.fieldHORAS_COMPENSADAS_DIURNA.Name = "fieldHORAS_COMPENSADAS_DIURNA"
        Me.fieldHORAS_COMPENSADAS_DIURNA.TotalCellFormat.FormatString = "n0"
        Me.fieldHORAS_COMPENSADAS_DIURNA.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldHORAS_COMPENSADAS_DIURNA.TotalValueFormat.FormatString = "n0"
        Me.fieldHORAS_COMPENSADAS_DIURNA.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldHORAS_COMPENSADAS_DIURNA.ValueFormat.FormatString = "n0"
        Me.fieldHORAS_COMPENSADAS_DIURNA.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldHORAS_COMPENSADAS_NOCTURNA
        '
        Me.fieldHORAS_COMPENSADAS_NOCTURNA.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldHORAS_COMPENSADAS_NOCTURNA.AreaIndex = 3
        Me.fieldHORAS_COMPENSADAS_NOCTURNA.Caption = "Hrs.Compensada Nocturna"
        Me.fieldHORAS_COMPENSADAS_NOCTURNA.FieldName = "HORAS_COMPENSADAS_NOCTURNA"
        Me.fieldHORAS_COMPENSADAS_NOCTURNA.Name = "fieldHORAS_COMPENSADAS_NOCTURNA"
        Me.fieldHORAS_COMPENSADAS_NOCTURNA.TotalCellFormat.FormatString = "n0"
        Me.fieldHORAS_COMPENSADAS_NOCTURNA.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldHORAS_COMPENSADAS_NOCTURNA.TotalValueFormat.FormatString = "n0"
        Me.fieldHORAS_COMPENSADAS_NOCTURNA.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldHORAS_COMPENSADAS_NOCTURNA.ValueFormat.FormatString = "n0"
        Me.fieldHORAS_COMPENSADAS_NOCTURNA.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldESTAMENTO
        '
        Me.fieldESTAMENTO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldESTAMENTO.AreaIndex = 3
        Me.fieldESTAMENTO.Caption = "Estamento"
        Me.fieldESTAMENTO.FieldName = "ESTAMENTO"
        Me.fieldESTAMENTO.Name = "fieldESTAMENTO"
        '
        'fieldRUT
        '
        Me.fieldRUT.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldRUT.AreaIndex = 4
        Me.fieldRUT.Caption = "Rut"
        Me.fieldRUT.FieldName = "RUT"
        Me.fieldRUT.Name = "fieldRUT"
        '
        'gpcSeleccionAño
        '
        Me.gpcSeleccionAño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionAño.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionAño.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionAño.Controls.Add(Me.luePeriodo)
        Me.gpcSeleccionAño.Controls.Add(Me.lblPeriodo)
        Me.gpcSeleccionAño.Location = New System.Drawing.Point(0, 0)
        Me.gpcSeleccionAño.Name = "gpcSeleccionAño"
        Me.gpcSeleccionAño.Size = New System.Drawing.Size(768, 80)
        Me.gpcSeleccionAño.TabIndex = 6
        Me.gpcSeleccionAño.Text = "Selección de Año"
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(128, 32)
        Me.luePeriodo.Name = "luePeriodo"
        '
        'luePeriodo.Properties
        '
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(144, 20)
        Me.luePeriodo.TabIndex = 4
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(64, 36)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 16)
        Me.lblPeriodo.TabIndex = 3
        Me.lblPeriodo.Text = "Año"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportExcel.Location = New System.Drawing.Point(616, 304)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(144, 23)
        Me.btnExportExcel.TabIndex = 8
        Me.btnExportExcel.Text = "Exportar a Excel"
        '
        'fieldANO_PROCESO_REMUN
        '
        Me.fieldANO_PROCESO_REMUN.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldANO_PROCESO_REMUN.AreaIndex = 5
        Me.fieldANO_PROCESO_REMUN.Caption = "Año Proceso Remun."
        Me.fieldANO_PROCESO_REMUN.FieldName = "ANO_PROCESO_REMUN"
        Me.fieldANO_PROCESO_REMUN.Name = "fieldANO_PROCESO_REMUN"
        '
        'fieldMES_PROCESO_REMUN
        '
        Me.fieldMES_PROCESO_REMUN.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldMES_PROCESO_REMUN.AreaIndex = 6
        Me.fieldMES_PROCESO_REMUN.Caption = "Mes Proceso Remun."
        Me.fieldMES_PROCESO_REMUN.FieldName = "MES_PROCESO_REMUN"
        Me.fieldMES_PROCESO_REMUN.Name = "fieldMES_PROCESO_REMUN"
        '
        'frmAnalisisHorasCompensadas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(768, 340)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.gpcSeleccionAño)
        Me.Controls.Add(Me.pgcAnalisisAtrasos)
        Me.Name = "frmAnalisisHorasCompensadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Análisis de Horas Extras y Compensadas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pgcAnalisisAtrasos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionAño.ResumeLayout(False)
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Private empleado As Empleado
    Private parametroMensual As Periodo
    Private asistencia As Asistencia

    Private Sub frmAnalisisHorasCompensadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        asistencia = New asistencia
        parametroMensual = New Periodo
        repositorio.RefreshDatos("PeriodoAño")
        llenarPeriodos()
    End Sub

    Private Sub llenarPeriodos()
        With luePeriodo
            With .Properties.Columns
                .Add(New LookUpColumnInfo("ANO", "Año Proceso", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        repositorio.Show()
        luePeriodo.Properties.DataSource = repositorio.dvPeriodoAño
        luePeriodo.Properties.DisplayMember = "ANO"
        luePeriodo.Properties.NullText = ""
        luePeriodo.Properties.PopupWidth = 100
        luePeriodo.Properties.ValueMember = "ANO"
    End Sub

    Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        If luePeriodo.EditValue <> Nothing Then
            refrescaDetalle()
        End If
    End Sub
    Private Sub refrescaDetalle()
        Cursor.Current = Cursors.WaitCursor
        If luePeriodo.EditValue <> Nothing Then
            Try
                pgcAnalisisAtrasos.DataSource = asistencia.dvHorasCompensadas(luePeriodo.EditValue)
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al leer datos horas atraso." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        Dim rutaPlanillaExcel As String
        Try
            With sfdHorasAtraso
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = sfdHorasAtraso.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                pgcAnalisisAtrasos.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
