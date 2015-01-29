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
Public Class frmAnalisisPersonalFueraDotacion
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
    Friend WithEvents fieldANO_REAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMES_REAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgcAnalisisPersonalFueraDontacion As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldGENERO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents gpcSeleccionAño As DevExpress.XtraEditors.GroupControl
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents cmdUnidadTiempo As System.Windows.Forms.ComboBox
    Friend WithEvents fieldSUBTOTAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sfdPersonalFueraDotacion As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim PivotGridCustomTotal1 As DevExpress.XtraPivotGrid.PivotGridCustomTotal = New DevExpress.XtraPivotGrid.PivotGridCustomTotal
        Dim PivotGridCustomTotal2 As DevExpress.XtraPivotGrid.PivotGridCustomTotal = New DevExpress.XtraPivotGrid.PivotGridCustomTotal
        Me.pgcAnalisisPersonalFueraDontacion = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.fieldANO_REAL = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMES_REAL = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldGENERO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSUBTOTAL = New DevExpress.XtraPivotGrid.PivotGridField
        Me.gpcSeleccionAño = New DevExpress.XtraEditors.GroupControl
        Me.cmdUnidadTiempo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton
        Me.sfdPersonalFueraDotacion = New System.Windows.Forms.SaveFileDialog
        CType(Me.pgcAnalisisPersonalFueraDontacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionAño.SuspendLayout()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pgcAnalisisPersonalFueraDontacion
        '
        Me.pgcAnalisisPersonalFueraDontacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgcAnalisisPersonalFueraDontacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.pgcAnalisisPersonalFueraDontacion.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldANO_REAL, Me.fieldMES_REAL, Me.fieldGENERO, Me.fieldSUBTOTAL})
        Me.pgcAnalisisPersonalFueraDontacion.Location = New System.Drawing.Point(8, 88)
        Me.pgcAnalisisPersonalFueraDontacion.Name = "pgcAnalisisPersonalFueraDontacion"
        Me.pgcAnalisisPersonalFueraDontacion.Size = New System.Drawing.Size(768, 264)
        Me.pgcAnalisisPersonalFueraDontacion.TabIndex = 1
        '
        'fieldANO_REAL
        '
        Me.fieldANO_REAL.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldANO_REAL.AreaIndex = 0
        Me.fieldANO_REAL.Caption = "Año"
        Me.fieldANO_REAL.FieldName = "ANO"
        Me.fieldANO_REAL.Name = "fieldANO_REAL"
        Me.fieldANO_REAL.TotalCellFormat.FormatString = "n0"
        Me.fieldANO_REAL.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldMES_REAL
        '
        Me.fieldMES_REAL.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldMES_REAL.AreaIndex = 0
        Me.fieldMES_REAL.Caption = "Mes"
        Me.fieldMES_REAL.FieldName = "MES"
        Me.fieldMES_REAL.Name = "fieldMES_REAL"
        '
        'fieldGENERO
        '
        Me.fieldGENERO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldGENERO.AreaIndex = 1
        Me.fieldGENERO.Caption = "Genero"
        PivotGridCustomTotal1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        Me.fieldGENERO.CustomTotals.AddRange(New DevExpress.XtraPivotGrid.PivotGridCustomTotal() {PivotGridCustomTotal1})
        Me.fieldGENERO.FieldName = "GENERO"
        Me.fieldGENERO.Name = "fieldGENERO"
        Me.fieldGENERO.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.CustomTotals
        Me.fieldGENERO.UnboundType = DevExpress.Data.UnboundColumnType.Integer
        '
        'fieldSUBTOTAL
        '
        Me.fieldSUBTOTAL.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldSUBTOTAL.AreaIndex = 0
        Me.fieldSUBTOTAL.Caption = "SUBTOTAL"
        Me.fieldSUBTOTAL.CustomTotals.AddRange(New DevExpress.XtraPivotGrid.PivotGridCustomTotal() {PivotGridCustomTotal2})
        Me.fieldSUBTOTAL.FieldName = "SUBTOTAL"
        Me.fieldSUBTOTAL.Name = "fieldSUBTOTAL"
        '
        'gpcSeleccionAño
        '
        Me.gpcSeleccionAño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionAño.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionAño.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionAño.Controls.Add(Me.cmdUnidadTiempo)
        Me.gpcSeleccionAño.Controls.Add(Me.Label1)
        Me.gpcSeleccionAño.Controls.Add(Me.luePeriodo)
        Me.gpcSeleccionAño.Controls.Add(Me.lblPeriodo)
        Me.gpcSeleccionAño.Controls.Add(Me.btnConsultar)
        Me.gpcSeleccionAño.Location = New System.Drawing.Point(8, 8)
        Me.gpcSeleccionAño.Name = "gpcSeleccionAño"
        Me.gpcSeleccionAño.Size = New System.Drawing.Size(768, 80)
        Me.gpcSeleccionAño.TabIndex = 6
        Me.gpcSeleccionAño.Text = "Selección de Año"
        '
        'cmdUnidadTiempo
        '
        Me.cmdUnidadTiempo.Items.AddRange(New Object() {"Seleccione Aquí", "Enero-Marzo", "Abril-Junio", "Julio-Sept", "Octubre-Dic"})
        Me.cmdUnidadTiempo.Location = New System.Drawing.Point(360, 32)
        Me.cmdUnidadTiempo.Name = "cmdUnidadTiempo"
        Me.cmdUnidadTiempo.Size = New System.Drawing.Size(121, 21)
        Me.cmdUnidadTiempo.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(296, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Trimestre:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.luePeriodo.TabIndex = 4
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(16, 36)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(32, 16)
        Me.lblPeriodo.TabIndex = 3
        Me.lblPeriodo.Text = "Año"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(544, 32)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.TabIndex = 7
        Me.btnConsultar.Text = "Consultar"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportExcel.Location = New System.Drawing.Point(632, 368)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(144, 23)
        Me.btnExportExcel.TabIndex = 8
        Me.btnExportExcel.Text = "Exportar a Excel"
        '
        'frmAnalisisPersonalFueraDotacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(784, 404)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.gpcSeleccionAño)
        Me.Controls.Add(Me.pgcAnalisisPersonalFueraDontacion)
        Me.Name = "frmAnalisisPersonalFueraDotacion"
        Me.Text = "Personal Fuera de Dotación"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pgcAnalisisPersonalFueraDontacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionAño.ResumeLayout(False)
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private empleado As New empleado
    Private parametroMensual As Periodo

#Region "Funciones"
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
    Private Sub refrescaDetalle()
        Cursor.Current = Cursors.WaitCursor
        If luePeriodo.EditValue <> Nothing Then
            Try
                If cmdUnidadTiempo.SelectedIndex > 0 Then

                    pgcAnalisisPersonalFueraDontacion.DataSource = empleado.recuperaDetallePersonalFueraDotacion(luePeriodo.EditValue, cmdUnidadTiempo.SelectedIndex)

                Else
                    MsgBox("Debe seleccionar el trimestre a consultar", MsgBoxStyle.Exclamation)
                End If

            Catch ex As Exception
                MsgBox("Ha ocurrido un error al leer datos personal fuera de dotación." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
        Cursor.Current = Cursors.Default
    End Sub
#End Region

    Private Sub frmAnalisisPersonalFueraDotacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        parametroMensual = New Periodo
        repositorio.RefreshDatos("PeriodoAño")
        llenarPeriodos()
        cmdUnidadTiempo.SelectedIndex = 0
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        refrescaDetalle()
    End Sub

    Private Sub gpcSeleccionAño_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles gpcSeleccionAño.Paint

    End Sub

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        Dim rutaPlanillaExcel As String
        Try
            With sfdPersonalFueraDotacion
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = sfdPersonalFueraDotacion.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                pgcAnalisisPersonalFueraDontacion.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pgcAnalisisPersonalFueraDontacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pgcAnalisisPersonalFueraDontacion.Click

    End Sub

    Private Sub pgcAnalisisPersonalFueraDontacion_CustomSummary(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs) Handles pgcAnalisisPersonalFueraDontacion.CustomSummary
       
    End Sub
End Class
