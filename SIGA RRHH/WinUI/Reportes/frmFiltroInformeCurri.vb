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
Public Class frmFiltroInformeCurri
    Inherits System.Windows.Forms.Form

    Private empleado As New Empleado
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
    Friend WithEvents gpcSeleccionAño As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblAño As System.Windows.Forms.Label
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sfdAntecedentesCurriculares As System.Windows.Forms.SaveFileDialog
    Friend WithEvents colNOMBRES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colEDUCACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colEXPERIENCIA_LABORAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDIRECCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDEPARTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colSUB_DEPTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colCANTIDAD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgcDetalle As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents colESTADO_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colAPELLIDO_PATERNO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colAPELLIDO_MATERNO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colNOMBRE As DevExpress.XtraPivotGrid.PivotGridField
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpcSeleccionAño = New DevExpress.XtraEditors.GroupControl
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.lblAño = New System.Windows.Forms.Label
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton
        Me.sfdAntecedentesCurriculares = New System.Windows.Forms.SaveFileDialog
        Me.pgcDetalle = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.colNOMBRES = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colRUT = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colDV = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colEDUCACION = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colEXPERIENCIA_LABORAL = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colDIRECCION = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colDEPARTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colSUB_DEPTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colCANTIDAD = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colESTADO_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colAPELLIDO_PATERNO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colAPELLIDO_MATERNO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colNOMBRE = New DevExpress.XtraPivotGrid.PivotGridField
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionAño.SuspendLayout()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgcDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcSeleccionAño
        '
        Me.gpcSeleccionAño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionAño.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionAño.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionAño.Controls.Add(Me.luePeriodo)
        Me.gpcSeleccionAño.Controls.Add(Me.lblAño)
        Me.gpcSeleccionAño.Location = New System.Drawing.Point(0, 0)
        Me.gpcSeleccionAño.Name = "gpcSeleccionAño"
        Me.gpcSeleccionAño.Size = New System.Drawing.Size(784, 88)
        Me.gpcSeleccionAño.TabIndex = 18
        Me.gpcSeleccionAño.Text = "Selección de Año"
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
        'lblAño
        '
        Me.lblAño.Location = New System.Drawing.Point(16, 36)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(32, 16)
        Me.lblAño.TabIndex = 3
        Me.lblAño.Text = "Año"
        Me.lblAño.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportExcel.Location = New System.Drawing.Point(640, 328)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(144, 23)
        Me.btnExportExcel.TabIndex = 19
        Me.btnExportExcel.Text = "Exportar a Excel"
        '
        'pgcDetalle
        '
        Me.pgcDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgcDetalle.Cursor = System.Windows.Forms.Cursors.Default
        Me.pgcDetalle.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.colNOMBRES, Me.colRUT, Me.colDV, Me.colEDUCACION, Me.colEXPERIENCIA_LABORAL, Me.colDIRECCION, Me.colDEPARTAMENTO, Me.colSUB_DEPTO, Me.colCANTIDAD, Me.colESTADO_EMPLEADO, Me.colAPELLIDO_PATERNO, Me.colAPELLIDO_MATERNO, Me.colNOMBRE})
        Me.pgcDetalle.Location = New System.Drawing.Point(0, 88)
        Me.pgcDetalle.Name = "pgcDetalle"
        Me.pgcDetalle.Size = New System.Drawing.Size(784, 232)
        Me.pgcDetalle.TabIndex = 20
        '
        'colNOMBRES
        '
        Me.colNOMBRES.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colNOMBRES.AreaIndex = 0
        Me.colNOMBRES.Caption = "Nombre Funcionario"
        Me.colNOMBRES.FieldName = "NOMBRES"
        Me.colNOMBRES.Name = "colNOMBRES"
        Me.colNOMBRES.Width = 250
        '
        'colRUT
        '
        Me.colRUT.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colRUT.AreaIndex = 1
        Me.colRUT.Caption = "Rut"
        Me.colRUT.FieldName = "RUT"
        Me.colRUT.Name = "colRUT"
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
        'colEDUCACION
        '
        Me.colEDUCACION.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colEDUCACION.AreaIndex = 4
        Me.colEDUCACION.Caption = "Educación"
        Me.colEDUCACION.FieldName = "EDUCACION"
        Me.colEDUCACION.Name = "colEDUCACION"
        Me.colEDUCACION.Width = 200
        '
        'colEXPERIENCIA_LABORAL
        '
        Me.colEXPERIENCIA_LABORAL.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colEXPERIENCIA_LABORAL.AreaIndex = 3
        Me.colEXPERIENCIA_LABORAL.Caption = "Experiencia Laboral"
        Me.colEXPERIENCIA_LABORAL.FieldName = "EXPERIENCIA_LABORAL"
        Me.colEXPERIENCIA_LABORAL.Name = "colEXPERIENCIA_LABORAL"
        Me.colEXPERIENCIA_LABORAL.Width = 200
        '
        'colDIRECCION
        '
        Me.colDIRECCION.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colDIRECCION.AreaIndex = 1
        Me.colDIRECCION.Caption = "Dirección"
        Me.colDIRECCION.FieldName = "DIRECCION"
        Me.colDIRECCION.Name = "colDIRECCION"
        '
        'colDEPARTAMENTO
        '
        Me.colDEPARTAMENTO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colDEPARTAMENTO.AreaIndex = 2
        Me.colDEPARTAMENTO.Caption = "Departamento"
        Me.colDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.colDEPARTAMENTO.Name = "colDEPARTAMENTO"
        '
        'colSUB_DEPTO
        '
        Me.colSUB_DEPTO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colSUB_DEPTO.AreaIndex = 0
        Me.colSUB_DEPTO.Caption = "Sub-Departamento"
        Me.colSUB_DEPTO.FieldName = "SUB_DEPTO"
        Me.colSUB_DEPTO.Name = "colSUB_DEPTO"
        '
        'colCANTIDAD
        '
        Me.colCANTIDAD.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colCANTIDAD.AreaIndex = 0
        Me.colCANTIDAD.Caption = "Cantidad"
        Me.colCANTIDAD.FieldName = "CANTIDAD"
        Me.colCANTIDAD.Name = "colCANTIDAD"
        '
        'colESTADO_EMPLEADO
        '
        Me.colESTADO_EMPLEADO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colESTADO_EMPLEADO.AreaIndex = 3
        Me.colESTADO_EMPLEADO.Caption = "Estado Empleado"
        Me.colESTADO_EMPLEADO.FieldName = "ESTADO_EMPLEADO"
        Me.colESTADO_EMPLEADO.Name = "colESTADO_EMPLEADO"
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
        'frmFiltroInformeCurri
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 356)
        Me.Controls.Add(Me.pgcDetalle)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.gpcSeleccionAño)
        Me.Name = "frmFiltroInformeCurri"
        Me.Text = "Informe Curricular"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionAño.ResumeLayout(False)
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgcDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

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
                Me.pgcDetalle.DataSource = empleado.recuperaAntecedentesCurricularesPorDepto(luePeriodo.EditValue)
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al leer datos personal fuera de dotación." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub frmFiltroInformeCurri_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        parametroMensual = New Periodo
        repositorio.RefreshDatos("PeriodoAño")
        llenarPeriodos()
    End Sub

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        Dim rutaPlanillaExcel As String
        Try
            With sfdAntecedentesCurriculares
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = sfdAntecedentesCurriculares.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                pgcDetalle.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        refrescaDetalle()
    End Sub
End Class
