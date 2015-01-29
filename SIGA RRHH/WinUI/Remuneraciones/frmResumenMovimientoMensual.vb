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
Public Class frmResumenMovimientoMensual
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
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents fieldANO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldITEM_ALIAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDESCRIPCION_LARGA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCANTIDAD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCANTIDAD_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCALIDAD_JURIDICA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDESCRIPCION_TIPO_ITEM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_MOVIMIENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGRADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents fieldORIGEN_ITEM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldUSUARIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents btnEmiteDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents prsAnalisisMovimientoMensual As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents sfdAnalisisMovimientoMensual As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pgcMovimientoMensual As DevExpress.XtraPivotGrid.PivotGridControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResumenMovimientoMensual))
        Me.pgcMovimientoMensual = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldANO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldITEM_ALIAS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDESCRIPCION_LARGA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCANTIDAD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCANTIDAD_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCALIDAD_JURIDICA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDESCRIPCION_TIPO_ITEM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRE_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRE_MOVIMIENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldGRADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldORIGEN_ITEM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldUSUARIO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.gpcSeleccionAño = New DevExpress.XtraEditors.GroupControl()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.btnEmiteDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.prsAnalisisMovimientoMensual = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.sfdAnalisisMovimientoMensual = New System.Windows.Forms.SaveFileDialog()
        CType(Me.pgcMovimientoMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionAño.SuspendLayout()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prsAnalisisMovimientoMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pgcMovimientoMensual
        '
        Me.pgcMovimientoMensual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgcMovimientoMensual.Cursor = System.Windows.Forms.Cursors.Default
        Me.pgcMovimientoMensual.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldANO, Me.fieldMES, Me.fieldITEM_ALIAS, Me.fieldDESCRIPCION_LARGA, Me.fieldCANTIDAD, Me.fieldCANTIDAD_EMPLEADO, Me.fieldCALIDAD_JURIDICA, Me.fieldDESCRIPCION_TIPO_ITEM, Me.fieldNOMBRE_EMPLEADO, Me.fieldNOMBRE_MOVIMIENTO, Me.fieldGRADO, Me.fieldORIGEN_ITEM, Me.fieldUSUARIO})
        Me.pgcMovimientoMensual.Location = New System.Drawing.Point(8, 88)
        Me.pgcMovimientoMensual.Name = "pgcMovimientoMensual"
        Me.pgcMovimientoMensual.Size = New System.Drawing.Size(888, 288)
        Me.pgcMovimientoMensual.TabIndex = 0
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
        Me.fieldMES.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'fieldITEM_ALIAS
        '
        Me.fieldITEM_ALIAS.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldITEM_ALIAS.AreaIndex = 2
        Me.fieldITEM_ALIAS.Caption = "Código Item"
        Me.fieldITEM_ALIAS.FieldName = "ITEM_ALIAS"
        Me.fieldITEM_ALIAS.Name = "fieldITEM_ALIAS"
        '
        'fieldDESCRIPCION_LARGA
        '
        Me.fieldDESCRIPCION_LARGA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldDESCRIPCION_LARGA.AreaIndex = 3
        Me.fieldDESCRIPCION_LARGA.Caption = "Nombre Item"
        Me.fieldDESCRIPCION_LARGA.FieldName = "DESCRIPCION_LARGA"
        Me.fieldDESCRIPCION_LARGA.Name = "fieldDESCRIPCION_LARGA"
        '
        'fieldCANTIDAD
        '
        Me.fieldCANTIDAD.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCANTIDAD.AreaIndex = 0
        Me.fieldCANTIDAD.Caption = "Monto"
        Me.fieldCANTIDAD.FieldName = "CANTIDAD"
        Me.fieldCANTIDAD.Name = "fieldCANTIDAD"
        Me.fieldCANTIDAD.TotalCellFormat.FormatString = "n0"
        Me.fieldCANTIDAD.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCANTIDAD.TotalValueFormat.FormatString = "n0"
        Me.fieldCANTIDAD.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCANTIDAD.ValueFormat.FormatString = "n0"
        Me.fieldCANTIDAD.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldCANTIDAD_EMPLEADO
        '
        Me.fieldCANTIDAD_EMPLEADO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCANTIDAD_EMPLEADO.AreaIndex = 1
        Me.fieldCANTIDAD_EMPLEADO.Caption = "Número Personas"
        Me.fieldCANTIDAD_EMPLEADO.FieldName = "CANTIDAD_EMPLEADO"
        Me.fieldCANTIDAD_EMPLEADO.Name = "fieldCANTIDAD_EMPLEADO"
        '
        'fieldCALIDAD_JURIDICA
        '
        Me.fieldCALIDAD_JURIDICA.AreaIndex = 1
        Me.fieldCALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.fieldCALIDAD_JURIDICA.FieldName = "CALIDAD_JURIDICA"
        Me.fieldCALIDAD_JURIDICA.Name = "fieldCALIDAD_JURIDICA"
        '
        'fieldDESCRIPCION_TIPO_ITEM
        '
        Me.fieldDESCRIPCION_TIPO_ITEM.AreaIndex = 0
        Me.fieldDESCRIPCION_TIPO_ITEM.Caption = "Tipo Item"
        Me.fieldDESCRIPCION_TIPO_ITEM.FieldName = "DESCRIPCION_TIPO_ITEM"
        Me.fieldDESCRIPCION_TIPO_ITEM.Name = "fieldDESCRIPCION_TIPO_ITEM"
        '
        'fieldNOMBRE_EMPLEADO
        '
        Me.fieldNOMBRE_EMPLEADO.AreaIndex = 2
        Me.fieldNOMBRE_EMPLEADO.Caption = "Nombre Empleado"
        Me.fieldNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.Name = "fieldNOMBRE_EMPLEADO"
        '
        'fieldNOMBRE_MOVIMIENTO
        '
        Me.fieldNOMBRE_MOVIMIENTO.AreaIndex = 3
        Me.fieldNOMBRE_MOVIMIENTO.Caption = "Tipo Proceso"
        Me.fieldNOMBRE_MOVIMIENTO.FieldName = "NOMBRE_MOVIMIENTO"
        Me.fieldNOMBRE_MOVIMIENTO.Name = "fieldNOMBRE_MOVIMIENTO"
        '
        'fieldGRADO
        '
        Me.fieldGRADO.AreaIndex = 4
        Me.fieldGRADO.Caption = "Grado"
        Me.fieldGRADO.FieldName = "GRADO"
        Me.fieldGRADO.Name = "fieldGRADO"
        '
        'fieldORIGEN_ITEM
        '
        Me.fieldORIGEN_ITEM.AreaIndex = 5
        Me.fieldORIGEN_ITEM.Caption = "Origen Item"
        Me.fieldORIGEN_ITEM.FieldName = "ORIGEN_ITEM"
        Me.fieldORIGEN_ITEM.Name = "fieldORIGEN_ITEM"
        '
        'fieldUSUARIO
        '
        Me.fieldUSUARIO.AreaIndex = 6
        Me.fieldUSUARIO.Caption = "Id Usuario"
        Me.fieldUSUARIO.FieldName = "USUARIO"
        Me.fieldUSUARIO.Name = "fieldUSUARIO"
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
        Me.gpcSeleccionAño.Size = New System.Drawing.Size(888, 80)
        Me.gpcSeleccionAño.TabIndex = 2
        Me.gpcSeleccionAño.Text = "Selección de Año"
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(120, 32)
        Me.luePeriodo.Name = "luePeriodo"
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(100, 20)
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
        'btnEmiteDetalle
        '
        Me.btnEmiteDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEmiteDetalle.Location = New System.Drawing.Point(568, 384)
        Me.btnEmiteDetalle.Name = "btnEmiteDetalle"
        Me.btnEmiteDetalle.Size = New System.Drawing.Size(160, 23)
        Me.btnEmiteDetalle.TabIndex = 7
        Me.btnEmiteDetalle.Text = "Visualizar"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportExcel.Location = New System.Drawing.Point(752, 384)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(144, 23)
        Me.btnExportExcel.TabIndex = 6
        Me.btnExportExcel.Text = "Exportar a Excel"
        '
        'prsAnalisisMovimientoMensual
        '
        Me.prsAnalisisMovimientoMensual.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.pgcMovimientoMensual
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(10, 10, 100, 100)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de La República", "Análisis de Movimiento Mensual de Items", "Fecha Emisión:[Date Printed]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Emitido por:[User Name]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"", "", "Página:[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.prsAnalisisMovimientoMensual
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prsAnalisisMovimientoMensual
        '
        'frmResumenMovimientoMensual
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(904, 422)
        Me.Controls.Add(Me.gpcSeleccionAño)
        Me.Controls.Add(Me.pgcMovimientoMensual)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.btnEmiteDetalle)
        Me.Name = "frmResumenMovimientoMensual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Análisis Movimiento Mensual"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pgcMovimientoMensual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionAño.ResumeLayout(False)
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prsAnalisisMovimientoMensual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim empleado As Empleado
    Dim parametroMensual As Periodo

    Private Sub frmResumenMovimientoMensual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnExportExcel.Enabled = False
        btnEmiteDetalle.Enabled = False
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
    Private Sub refrescaDetalle()
        Cursor.Current = Cursors.WaitCursor
        If luePeriodo.EditValue <> Nothing Then
            Try
                pgcMovimientoMensual.DataSource = empleado.recuperaAnalisisMovimientoMensual(luePeriodo.EditValue)
                btnExportExcel.Enabled = True
                btnEmiteDetalle.Enabled = True
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al leer datos movimientos mensual." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        If luePeriodo.EditValue <> Nothing Then
            refrescaDetalle()
        End If
    End Sub

    Private Sub btnEmiteDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmiteDetalle.Click
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
    End Sub
    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "AÑO PROCESO : " & luePeriodo.EditValue
        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)
    End Sub

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        Dim rutaPlanillaExcel As String
        Try
            With sfdAnalisisMovimientoMensual
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = sfdAnalisisMovimientoMensual.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                pgcMovimientoMensual.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
