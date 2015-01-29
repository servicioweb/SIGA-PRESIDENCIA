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

Public Class frmAnalisisAtrasos
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
    Friend WithEvents fieldANO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEMPLEADO_ID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_ASISTENCIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldATRASO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDEPARTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCALIDAD_JURIDICA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORA_ENTRADA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORA_SALIDA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORA_ENTRADA_HORARIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORA_SALIDA_HORARIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sfdHorasAtraso As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.pgcAnalisisAtrasos = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.fieldANO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMES = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldEMPLEADO_ID = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOMBRE_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFECHA_ASISTENCIA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDEPARTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCALIDAD_JURIDICA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHORA_ENTRADA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHORA_SALIDA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHORA_ENTRADA_HORARIO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHORA_SALIDA_HORARIO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldATRASO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldESTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldRUT = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDV = New DevExpress.XtraPivotGrid.PivotGridField
        Me.gpcSeleccionAño = New DevExpress.XtraEditors.GroupControl
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton
        Me.sfdHorasAtraso = New System.Windows.Forms.SaveFileDialog
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
        Me.pgcAnalisisAtrasos.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldANO, Me.fieldMES, Me.fieldEMPLEADO_ID, Me.fieldNOMBRE_EMPLEADO, Me.fieldFECHA_ASISTENCIA, Me.fieldDEPARTAMENTO, Me.fieldCALIDAD_JURIDICA, Me.fieldHORA_ENTRADA, Me.fieldHORA_SALIDA, Me.fieldHORA_ENTRADA_HORARIO, Me.fieldHORA_SALIDA_HORARIO, Me.fieldATRASO, Me.fieldESTAMENTO, Me.fieldRUT, Me.fieldDV})
        Me.pgcAnalisisAtrasos.Location = New System.Drawing.Point(0, 80)
        Me.pgcAnalisisAtrasos.Name = "pgcAnalisisAtrasos"
        Me.pgcAnalisisAtrasos.Size = New System.Drawing.Size(768, 216)
        Me.pgcAnalisisAtrasos.TabIndex = 0
        '
        'fieldANO
        '
        Me.fieldANO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldANO.AreaIndex = 0
        Me.fieldANO.Caption = "Año"
        Me.fieldANO.FieldName = "ANO"
        Me.fieldANO.Name = "fieldANO"
        '
        'fieldMES
        '
        Me.fieldMES.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldMES.AreaIndex = 1
        Me.fieldMES.Caption = "Mes"
        Me.fieldMES.FieldName = "MES"
        Me.fieldMES.Name = "fieldMES"
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
        Me.fieldNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.Name = "fieldNOMBRE_EMPLEADO"
        '
        'fieldFECHA_ASISTENCIA
        '
        Me.fieldFECHA_ASISTENCIA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldFECHA_ASISTENCIA.AreaIndex = 3
        Me.fieldFECHA_ASISTENCIA.Caption = "Fecha Asistencia"
        Me.fieldFECHA_ASISTENCIA.CellFormat.FormatString = "d"
        Me.fieldFECHA_ASISTENCIA.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldFECHA_ASISTENCIA.FieldName = "FECHA_ASISTENCIA"
        Me.fieldFECHA_ASISTENCIA.Name = "fieldFECHA_ASISTENCIA"
        Me.fieldFECHA_ASISTENCIA.ValueFormat.FormatString = "d"
        Me.fieldFECHA_ASISTENCIA.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
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
        'fieldHORA_ENTRADA
        '
        Me.fieldHORA_ENTRADA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHORA_ENTRADA.AreaIndex = 4
        Me.fieldHORA_ENTRADA.Caption = "Hora Entrada"
        Me.fieldHORA_ENTRADA.FieldName = "HORA_ENTRADA"
        Me.fieldHORA_ENTRADA.Name = "fieldHORA_ENTRADA"
        '
        'fieldHORA_SALIDA
        '
        Me.fieldHORA_SALIDA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHORA_SALIDA.AreaIndex = 5
        Me.fieldHORA_SALIDA.Caption = "Hora Salida"
        Me.fieldHORA_SALIDA.FieldName = "HORA_SALIDA"
        Me.fieldHORA_SALIDA.Name = "fieldHORA_SALIDA"
        '
        'fieldHORA_ENTRADA_HORARIO
        '
        Me.fieldHORA_ENTRADA_HORARIO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHORA_ENTRADA_HORARIO.AreaIndex = 6
        Me.fieldHORA_ENTRADA_HORARIO.Caption = "Turno Entrada"
        Me.fieldHORA_ENTRADA_HORARIO.FieldName = "HORA_ENTRADA_HORARIO"
        Me.fieldHORA_ENTRADA_HORARIO.Name = "fieldHORA_ENTRADA_HORARIO"
        '
        'fieldHORA_SALIDA_HORARIO
        '
        Me.fieldHORA_SALIDA_HORARIO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHORA_SALIDA_HORARIO.AreaIndex = 7
        Me.fieldHORA_SALIDA_HORARIO.Caption = "Turno Salida"
        Me.fieldHORA_SALIDA_HORARIO.FieldName = "HORA_SALIDA_HORARIO"
        Me.fieldHORA_SALIDA_HORARIO.Name = "fieldHORA_SALIDA_HORARIO"
        '
        'fieldATRASO
        '
        Me.fieldATRASO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldATRASO.AreaIndex = 8
        Me.fieldATRASO.Caption = "Hora Atraso"
        Me.fieldATRASO.FieldName = "ATRASO"
        Me.fieldATRASO.Name = "fieldATRASO"
        Me.fieldATRASO.ValueFormat.FormatString = "d"
        Me.fieldATRASO.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
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
        'fieldDV
        '
        Me.fieldDV.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldDV.AreaIndex = 5
        Me.fieldDV.Caption = "Digito Verificador"
        Me.fieldDV.FieldName = "DV"
        Me.fieldDV.Name = "fieldDV"
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
        'frmAnalisisAtrasos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(768, 340)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.gpcSeleccionAño)
        Me.Controls.Add(Me.pgcAnalisisAtrasos)
        Me.Name = "frmAnalisisAtrasos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Análisis de Atrasos"
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
    Private asistencia As asistencia

    Private Sub frmAnalisisAtrasos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                pgcAnalisisAtrasos.DataSource = asistencia.dvHorasAtraso(luePeriodo.EditValue)
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
