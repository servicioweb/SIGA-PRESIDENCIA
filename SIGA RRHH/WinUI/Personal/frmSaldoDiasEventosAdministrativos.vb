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

Public Class frmSaldoDiasEventosAdministrativos
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
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents dvPeriodo As System.Data.DataView
    Friend WithEvents fieldNOMBRE_EVENTO_ADMIN As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDIAS_PERIODO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDIAS_PERIODO_ANT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents filedDIAS_ADICIONALES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTOTAL_DIAS_ANUAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTOTAL_DIAS_SOLICITADOS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDIAS_PENDIENTE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_CALIDAD_JURIDICA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_DEPTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents gpcSeleccionAño As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sfdSaldoDiasEventosAdministrativos As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pgcSaldoDiasEventoAdmin As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldDIRECCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSUB_DEPTO As DevExpress.XtraPivotGrid.PivotGridField
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim PivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup
        Me.fieldNOMBRE_EVENTO_ADMIN = New DevExpress.XtraPivotGrid.PivotGridField
        Me.gpcSeleccionAño = New DevExpress.XtraEditors.GroupControl
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.dvPeriodo = New System.Data.DataView
        Me.pgcSaldoDiasEventoAdmin = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.fieldNOMBRE_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDIAS_PERIODO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDIAS_PERIODO_ANT = New DevExpress.XtraPivotGrid.PivotGridField
        Me.filedDIAS_ADICIONALES = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldTOTAL_DIAS_ANUAL = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldTOTAL_DIAS_SOLICITADOS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDIAS_PENDIENTE = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOMBRE_CALIDAD_JURIDICA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOMBRE_DEPTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldRUT = New DevExpress.XtraPivotGrid.PivotGridField
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton
        Me.sfdSaldoDiasEventosAdministrativos = New System.Windows.Forms.SaveFileDialog
        Me.fieldDIRECCION = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSUB_DEPTO = New DevExpress.XtraPivotGrid.PivotGridField
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionAño.SuspendLayout()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgcSaldoDiasEventoAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fieldNOMBRE_EVENTO_ADMIN
        '
        Me.fieldNOMBRE_EVENTO_ADMIN.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNOMBRE_EVENTO_ADMIN.AreaIndex = 0
        Me.fieldNOMBRE_EVENTO_ADMIN.Caption = "Evento Administrativo"
        Me.fieldNOMBRE_EVENTO_ADMIN.FieldName = "NOMBRE_EVENTO_ADMIN"
        Me.fieldNOMBRE_EVENTO_ADMIN.Name = "fieldNOMBRE_EVENTO_ADMIN"
        '
        'gpcSeleccionAño
        '
        Me.gpcSeleccionAño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionAño.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionAño.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionAño.Controls.Add(Me.luePeriodo)
        Me.gpcSeleccionAño.Controls.Add(Me.lblPeriodo)
        Me.gpcSeleccionAño.Location = New System.Drawing.Point(8, 8)
        Me.gpcSeleccionAño.Name = "gpcSeleccionAño"
        Me.gpcSeleccionAño.Size = New System.Drawing.Size(840, 80)
        Me.gpcSeleccionAño.TabIndex = 0
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
        'pgcSaldoDiasEventoAdmin
        '
        Me.pgcSaldoDiasEventoAdmin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgcSaldoDiasEventoAdmin.Cursor = System.Windows.Forms.Cursors.Default
        Me.pgcSaldoDiasEventoAdmin.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldNOMBRE_EVENTO_ADMIN, Me.fieldNOMBRE_EMPLEADO, Me.fieldDIAS_PERIODO, Me.fieldDIAS_PERIODO_ANT, Me.filedDIAS_ADICIONALES, Me.fieldTOTAL_DIAS_ANUAL, Me.fieldTOTAL_DIAS_SOLICITADOS, Me.fieldDIAS_PENDIENTE, Me.fieldNOMBRE_CALIDAD_JURIDICA, Me.fieldNOMBRE_DEPTO, Me.fieldRUT, Me.fieldDIRECCION, Me.fieldSUB_DEPTO})
        PivotGridGroup1.Fields.Add(Me.fieldNOMBRE_EVENTO_ADMIN)
        Me.pgcSaldoDiasEventoAdmin.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {PivotGridGroup1})
        Me.pgcSaldoDiasEventoAdmin.Location = New System.Drawing.Point(8, 96)
        Me.pgcSaldoDiasEventoAdmin.Name = "pgcSaldoDiasEventoAdmin"
        Me.pgcSaldoDiasEventoAdmin.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
        Me.pgcSaldoDiasEventoAdmin.OptionsView.ShowColumnGrandTotals = False
        Me.pgcSaldoDiasEventoAdmin.Size = New System.Drawing.Size(840, 272)
        Me.pgcSaldoDiasEventoAdmin.TabIndex = 1
        '
        'fieldNOMBRE_EMPLEADO
        '
        Me.fieldNOMBRE_EMPLEADO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNOMBRE_EMPLEADO.AreaIndex = 1
        Me.fieldNOMBRE_EMPLEADO.Caption = "Nombre Empleado"
        Me.fieldNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.Name = "fieldNOMBRE_EMPLEADO"
        '
        'fieldDIAS_PERIODO
        '
        Me.fieldDIAS_PERIODO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldDIAS_PERIODO.AreaIndex = 2
        Me.fieldDIAS_PERIODO.Caption = "Días del Periodo"
        Me.fieldDIAS_PERIODO.FieldName = "DIAS_PERIODO"
        Me.fieldDIAS_PERIODO.Name = "fieldDIAS_PERIODO"
        '
        'fieldDIAS_PERIODO_ANT
        '
        Me.fieldDIAS_PERIODO_ANT.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldDIAS_PERIODO_ANT.AreaIndex = 3
        Me.fieldDIAS_PERIODO_ANT.Caption = "Días Periodo Anterior"
        Me.fieldDIAS_PERIODO_ANT.FieldName = "DIAS_PERIODO_ANT"
        Me.fieldDIAS_PERIODO_ANT.Name = "fieldDIAS_PERIODO_ANT"
        '
        'filedDIAS_ADICIONALES
        '
        Me.filedDIAS_ADICIONALES.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.filedDIAS_ADICIONALES.AreaIndex = 4
        Me.filedDIAS_ADICIONALES.Caption = "Días Adicionales"
        Me.filedDIAS_ADICIONALES.FieldName = "DIAS_ADICIONALES"
        Me.filedDIAS_ADICIONALES.Name = "filedDIAS_ADICIONALES"
        '
        'fieldTOTAL_DIAS_ANUAL
        '
        Me.fieldTOTAL_DIAS_ANUAL.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldTOTAL_DIAS_ANUAL.AreaIndex = 5
        Me.fieldTOTAL_DIAS_ANUAL.Caption = "Total Días Anual"
        Me.fieldTOTAL_DIAS_ANUAL.FieldName = "TOTAL_DIAS_ANUAL"
        Me.fieldTOTAL_DIAS_ANUAL.Name = "fieldTOTAL_DIAS_ANUAL"
        '
        'fieldTOTAL_DIAS_SOLICITADOS
        '
        Me.fieldTOTAL_DIAS_SOLICITADOS.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldTOTAL_DIAS_SOLICITADOS.AreaIndex = 6
        Me.fieldTOTAL_DIAS_SOLICITADOS.Caption = "Total Días Solicitados"
        Me.fieldTOTAL_DIAS_SOLICITADOS.FieldName = "TOTAL_DIAS_SOLICITADOS"
        Me.fieldTOTAL_DIAS_SOLICITADOS.Name = "fieldTOTAL_DIAS_SOLICITADOS"
        '
        'fieldDIAS_PENDIENTE
        '
        Me.fieldDIAS_PENDIENTE.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldDIAS_PENDIENTE.AreaIndex = 7
        Me.fieldDIAS_PENDIENTE.Caption = "Días Pendientes"
        Me.fieldDIAS_PENDIENTE.FieldName = "DIAS_PENDIENTE"
        Me.fieldDIAS_PENDIENTE.Name = "fieldDIAS_PENDIENTE"
        '
        'fieldNOMBRE_CALIDAD_JURIDICA
        '
        Me.fieldNOMBRE_CALIDAD_JURIDICA.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldNOMBRE_CALIDAD_JURIDICA.AreaIndex = 0
        Me.fieldNOMBRE_CALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.fieldNOMBRE_CALIDAD_JURIDICA.FieldName = "NOMBRE_CALIDAD_JURIDICA"
        Me.fieldNOMBRE_CALIDAD_JURIDICA.Name = "fieldNOMBRE_CALIDAD_JURIDICA"
        '
        'fieldNOMBRE_DEPTO
        '
        Me.fieldNOMBRE_DEPTO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldNOMBRE_DEPTO.AreaIndex = 4
        Me.fieldNOMBRE_DEPTO.Caption = "Departamento"
        Me.fieldNOMBRE_DEPTO.FieldName = "NOMBRE_DEPTO"
        Me.fieldNOMBRE_DEPTO.Name = "fieldNOMBRE_DEPTO"
        '
        'fieldRUT
        '
        Me.fieldRUT.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldRUT.AreaIndex = 1
        Me.fieldRUT.Caption = "RUT"
        Me.fieldRUT.FieldName = "RUT"
        Me.fieldRUT.Name = "fieldRUT"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportExcel.Location = New System.Drawing.Point(704, 376)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(144, 23)
        Me.btnExportExcel.TabIndex = 3
        Me.btnExportExcel.Text = "Exportar a Excel"
        '
        'fieldDIRECCION
        '
        Me.fieldDIRECCION.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldDIRECCION.AreaIndex = 2
        Me.fieldDIRECCION.Caption = "Dirección"
        Me.fieldDIRECCION.FieldName = "DIRECCION"
        Me.fieldDIRECCION.Name = "fieldDIRECCION"
        '
        'fieldSUB_DEPTO
        '
        Me.fieldSUB_DEPTO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldSUB_DEPTO.AreaIndex = 3
        Me.fieldSUB_DEPTO.Caption = "Sub-Departamento"
        Me.fieldSUB_DEPTO.FieldName = "SUB_DEPTO"
        Me.fieldSUB_DEPTO.Name = "fieldSUB_DEPTO"
        '
        'frmSaldoDiasEventosAdministrativos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 406)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.pgcSaldoDiasEventoAdmin)
        Me.Controls.Add(Me.gpcSeleccionAño)
        Me.Name = "frmSaldoDiasEventosAdministrativos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analisis Dinámico Saldo Dias Eventos Administrativos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionAño.ResumeLayout(False)
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgcSaldoDiasEventoAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim empleado As Empleado
    Dim parametroMensual As Periodo

    Private Sub frmSaldoDiasEventosAdministrativos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empleado = New empleado
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


    Private Sub luePeriodo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        If luePeriodo.EditValue <> Nothing Then
            refrescaDetalle()
        End If
    End Sub
    Private Sub refrescaDetalle()
        If luePeriodo.EditValue <> Nothing Then
            Try
                pgcSaldoDiasEventoAdmin.DataSource = empleado.recuperaEventosAdministrativosSaldoDias(luePeriodo.EditValue)
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al leer datos saldo días de eventos administrativos." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        Dim rutaPlanillaExcel As String
        Try
            With sfdSaldoDiasEventosAdministrativos
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = sfdSaldoDiasEventosAdministrativos.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                pgcSaldoDiasEventoAdmin.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
