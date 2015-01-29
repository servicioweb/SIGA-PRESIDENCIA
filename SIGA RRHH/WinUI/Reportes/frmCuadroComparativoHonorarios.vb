Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraPivotGrid
Imports DevExpress

Imports System.Windows.Forms
Imports System.Drawing
Imports System
Public Class frmCuadroComparativoHonorarios
    Inherits System.Windows.Forms.Form

    Private empleado As New empleado
    Private parametroMensual As Periodo

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
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sfdCuadroComparativo As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pgcDetalleHonorarrio As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents colRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_BRUTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colTITULO_PROFESIONAL_EXPERTIZ As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colFECHA_CONTRATO_DESDE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colFECHA_CONTRATO_HASTA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colCARGO_ACTUAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colFUNCIONES_DESEMPENADAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDIRECCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDEPARTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colSUB_DEPTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colNOMBRES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents gpcSeleccionAño As DevExpress.XtraEditors.GroupControl
    Friend WithEvents colAPELLIDO_PATERNO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colAPELLIDO_MATERNO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colNOMBRE As DevExpress.XtraPivotGrid.PivotGridField
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton
        Me.sfdCuadroComparativo = New System.Windows.Forms.SaveFileDialog
        Me.pgcDetalleHonorarrio = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.colNOMBRES = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colRUT = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colDV = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_BRUTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colTITULO_PROFESIONAL_EXPERTIZ = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colFECHA_CONTRATO_DESDE = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colFECHA_CONTRATO_HASTA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colCARGO_ACTUAL = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colFUNCIONES_DESEMPENADAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colDIRECCION = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colDEPARTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colSUB_DEPTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.gpcSeleccionAño = New DevExpress.XtraEditors.GroupControl
        Me.colAPELLIDO_PATERNO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colAPELLIDO_MATERNO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colNOMBRE = New DevExpress.XtraPivotGrid.PivotGridField
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgcDetalleHonorarrio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionAño.SuspendLayout()
        Me.SuspendLayout()
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(56, 32)
        Me.luePeriodo.Name = "luePeriodo"
        '
        'luePeriodo.Properties
        '
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(144, 20)
        Me.luePeriodo.TabIndex = 9
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(16, 36)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(32, 16)
        Me.lblPeriodo.TabIndex = 8
        Me.lblPeriodo.Text = "Año"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportExcel.Location = New System.Drawing.Point(856, 440)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(144, 23)
        Me.btnExportExcel.TabIndex = 12
        Me.btnExportExcel.Text = "Exportar a Excel"
        '
        'pgcDetalleHonorarrio
        '
        Me.pgcDetalleHonorarrio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgcDetalleHonorarrio.Cursor = System.Windows.Forms.Cursors.Default
        Me.pgcDetalleHonorarrio.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.colNOMBRES, Me.colRUT, Me.colDV, Me.colMONTO_BRUTO, Me.colTITULO_PROFESIONAL_EXPERTIZ, Me.colFECHA_CONTRATO_DESDE, Me.colFECHA_CONTRATO_HASTA, Me.colCARGO_ACTUAL, Me.colFUNCIONES_DESEMPENADAS, Me.colDIRECCION, Me.colDEPARTAMENTO, Me.colSUB_DEPTO, Me.colAPELLIDO_PATERNO, Me.colAPELLIDO_MATERNO, Me.colNOMBRE})
        Me.pgcDetalleHonorarrio.Location = New System.Drawing.Point(0, 88)
        Me.pgcDetalleHonorarrio.Name = "pgcDetalleHonorarrio"
        Me.pgcDetalleHonorarrio.Size = New System.Drawing.Size(1008, 344)
        Me.pgcDetalleHonorarrio.TabIndex = 13
        '
        'colNOMBRES
        '
        Me.colNOMBRES.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colNOMBRES.AreaIndex = 0
        Me.colNOMBRES.Caption = "Nombre Funcionario"
        Me.colNOMBRES.FieldName = "NOMBRES"
        Me.colNOMBRES.Name = "colNOMBRES"
        Me.colNOMBRES.Width = 200
        '
        'colRUT
        '
        Me.colRUT.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colRUT.AreaIndex = 1
        Me.colRUT.Caption = "Rut"
        Me.colRUT.FieldName = "RUT"
        Me.colRUT.Name = "colRUT"
        Me.colRUT.Width = 90
        '
        'colDV
        '
        Me.colDV.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colDV.AreaIndex = 2
        Me.colDV.Caption = "Dv"
        Me.colDV.FieldName = "DV"
        Me.colDV.Name = "colDV"
        Me.colDV.Width = 60
        '
        'colMONTO_BRUTO
        '
        Me.colMONTO_BRUTO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_BRUTO.AreaIndex = 0
        Me.colMONTO_BRUTO.Caption = "Renta Actual"
        Me.colMONTO_BRUTO.CellFormat.FormatString = "n0"
        Me.colMONTO_BRUTO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_BRUTO.FieldName = "MONTO_BRUTO"
        Me.colMONTO_BRUTO.Name = "colMONTO_BRUTO"
        '
        'colTITULO_PROFESIONAL_EXPERTIZ
        '
        Me.colTITULO_PROFESIONAL_EXPERTIZ.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colTITULO_PROFESIONAL_EXPERTIZ.AreaIndex = 6
        Me.colTITULO_PROFESIONAL_EXPERTIZ.Caption = "Educación"
        Me.colTITULO_PROFESIONAL_EXPERTIZ.FieldName = "TITULO_PROFESIONAL_EXPERTIZ"
        Me.colTITULO_PROFESIONAL_EXPERTIZ.Name = "colTITULO_PROFESIONAL_EXPERTIZ"
        Me.colTITULO_PROFESIONAL_EXPERTIZ.Width = 150
        '
        'colFECHA_CONTRATO_DESDE
        '
        Me.colFECHA_CONTRATO_DESDE.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colFECHA_CONTRATO_DESDE.AreaIndex = 4
        Me.colFECHA_CONTRATO_DESDE.Caption = "Fecha Inicio"
        Me.colFECHA_CONTRATO_DESDE.CellFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_DESDE.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFECHA_CONTRATO_DESDE.FieldName = "FECHA_CONTRATO_DESDE"
        Me.colFECHA_CONTRATO_DESDE.GrandTotalCellFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_DESDE.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFECHA_CONTRATO_DESDE.Name = "colFECHA_CONTRATO_DESDE"
        Me.colFECHA_CONTRATO_DESDE.TotalCellFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_DESDE.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFECHA_CONTRATO_DESDE.TotalValueFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_DESDE.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFECHA_CONTRATO_DESDE.ValueFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_DESDE.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'colFECHA_CONTRATO_HASTA
        '
        Me.colFECHA_CONTRATO_HASTA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colFECHA_CONTRATO_HASTA.AreaIndex = 3
        Me.colFECHA_CONTRATO_HASTA.Caption = "Fecha Término"
        Me.colFECHA_CONTRATO_HASTA.CellFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_HASTA.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFECHA_CONTRATO_HASTA.FieldName = "FECHA_CONTRATO_HASTA"
        Me.colFECHA_CONTRATO_HASTA.GrandTotalCellFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_HASTA.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFECHA_CONTRATO_HASTA.Name = "colFECHA_CONTRATO_HASTA"
        Me.colFECHA_CONTRATO_HASTA.TotalCellFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_HASTA.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFECHA_CONTRATO_HASTA.TotalValueFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_HASTA.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFECHA_CONTRATO_HASTA.ValueFormat.FormatString = "d"
        Me.colFECHA_CONTRATO_HASTA.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'colCARGO_ACTUAL
        '
        Me.colCARGO_ACTUAL.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colCARGO_ACTUAL.AreaIndex = 3
        Me.colCARGO_ACTUAL.Caption = "Cargo Actual"
        Me.colCARGO_ACTUAL.FieldName = "CARGO_ACTUAL"
        Me.colCARGO_ACTUAL.Name = "colCARGO_ACTUAL"
        Me.colCARGO_ACTUAL.Width = 200
        '
        'colFUNCIONES_DESEMPENADAS
        '
        Me.colFUNCIONES_DESEMPENADAS.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colFUNCIONES_DESEMPENADAS.AreaIndex = 5
        Me.colFUNCIONES_DESEMPENADAS.Caption = "Funciones Según Contrato"
        Me.colFUNCIONES_DESEMPENADAS.FieldName = "FUNCIONES_DESEMPENADAS"
        Me.colFUNCIONES_DESEMPENADAS.Name = "colFUNCIONES_DESEMPENADAS"
        Me.colFUNCIONES_DESEMPENADAS.Width = 150
        '
        'colDIRECCION
        '
        Me.colDIRECCION.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colDIRECCION.AreaIndex = 0
        Me.colDIRECCION.Caption = "Dirección"
        Me.colDIRECCION.FieldName = "DIRECCION"
        Me.colDIRECCION.Name = "colDIRECCION"
        '
        'colDEPARTAMENTO
        '
        Me.colDEPARTAMENTO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colDEPARTAMENTO.AreaIndex = 1
        Me.colDEPARTAMENTO.Caption = "Departamento"
        Me.colDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.colDEPARTAMENTO.Name = "colDEPARTAMENTO"
        '
        'colSUB_DEPTO
        '
        Me.colSUB_DEPTO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colSUB_DEPTO.AreaIndex = 2
        Me.colSUB_DEPTO.Caption = "Sub-Departamento"
        Me.colSUB_DEPTO.FieldName = "SUB_DEPTO"
        Me.colSUB_DEPTO.Name = "colSUB_DEPTO"
        '
        'gpcSeleccionAño
        '
        Me.gpcSeleccionAño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionAño.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionAño.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionAño.Controls.Add(Me.lblPeriodo)
        Me.gpcSeleccionAño.Controls.Add(Me.luePeriodo)
        Me.gpcSeleccionAño.Location = New System.Drawing.Point(0, 0)
        Me.gpcSeleccionAño.Name = "gpcSeleccionAño"
        Me.gpcSeleccionAño.Size = New System.Drawing.Size(1008, 88)
        Me.gpcSeleccionAño.TabIndex = 14
        Me.gpcSeleccionAño.Text = "Selección de Año"
        '
        'colAPELLIDO_PATERNO
        '
        Me.colAPELLIDO_PATERNO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colAPELLIDO_PATERNO.AreaIndex = 4
        Me.colAPELLIDO_PATERNO.Caption = "Apellido Paterno"
        Me.colAPELLIDO_PATERNO.FieldName = "APELLIDO_PATERNO"
        Me.colAPELLIDO_PATERNO.Name = "colAPELLIDO_PATERNO"
        '
        'colAPELLIDO_MATERNO
        '
        Me.colAPELLIDO_MATERNO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colAPELLIDO_MATERNO.AreaIndex = 5
        Me.colAPELLIDO_MATERNO.Caption = "Apellido Materno"
        Me.colAPELLIDO_MATERNO.FieldName = "APELLIDO_MATERNO"
        Me.colAPELLIDO_MATERNO.Name = "colAPELLIDO_MATERNO"
        '
        'colNOMBRE
        '
        Me.colNOMBRE.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colNOMBRE.AreaIndex = 6
        Me.colNOMBRE.Caption = "Nombres"
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        '
        'frmCuadroComparativoHonorarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1008, 468)
        Me.Controls.Add(Me.gpcSeleccionAño)
        Me.Controls.Add(Me.pgcDetalleHonorarrio)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Name = "frmCuadroComparativoHonorarios"
        Me.Text = "Cuadro Comparativo Honorarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgcDetalleHonorarrio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionAño.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub refrescaDetalle()
        Cursor.Current = Cursors.WaitCursor
        If luePeriodo.EditValue <> Nothing Then
            Try
                pgcDetalleHonorarrio.DataSource = Nothing
                pgcDetalleHonorarrio.DataSource = empleado.recuperaCuadroComparativoHonorarios(luePeriodo.EditValue)

            Catch ex As Exception
                MsgBox("Ha ocurrido un error al leer datos personal fuera de dotación." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
        Cursor.Current = Cursors.Default
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
    Private Sub frmCuadroComparativoHonorarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        parametroMensual = New Periodo
        repositorio.RefreshDatos("PeriodoAño")
        llenarPeriodos()
    End Sub

    Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        refrescaDetalle()
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        refrescaDetalle()
    End Sub

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        Dim rutaPlanillaExcel As String
        Try
            With sfdCuadroComparativo
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = sfdCuadroComparativo.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                pgcDetalleHonorarrio.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
