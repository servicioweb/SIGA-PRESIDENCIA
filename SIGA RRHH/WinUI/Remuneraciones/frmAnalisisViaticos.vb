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

Public Class frmAnalisisViaticos
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
    Friend WithEvents btnEmiteDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents prsAnalisisViaticos As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents sfdAnalisisViaticos As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pgcAnalisisDinamicoViaticos As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents colRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents colDV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colNOMBRE_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colANO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colNUMERO_CHEQUE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colFECHA_CHEQUE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colCALIDAD_JURIDICA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colESTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDEPARTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colFECHA_INICIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colFECHA_TERMINO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDIAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colGRADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colCLASIFICACION_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colNRO_RESOLUCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colFECHA_RESOLUCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colPAIS_DESTINO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colREGION_DESTINO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colCOMUNA_DESTINO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDESCRIPCION_ESTADO_VIATICO As DevExpress.XtraPivotGrid.PivotGridField
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalisisViaticos))
        Me.pgcAnalisisDinamicoViaticos = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.colANO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colMES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colRUT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colDV = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colNOMBRE_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colMONTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colNUMERO_CHEQUE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colFECHA_CHEQUE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colCALIDAD_JURIDICA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colESTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colDEPARTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colFECHA_INICIO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colFECHA_TERMINO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colDIAS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colGRADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colCLASIFICACION_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colNRO_RESOLUCION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colFECHA_RESOLUCION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colPAIS_DESTINO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colREGION_DESTINO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colCOMUNA_DESTINO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colDESCRIPCION_ESTADO_VIATICO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.gpcSeleccionAño = New DevExpress.XtraEditors.GroupControl()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.btnEmiteDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.prsAnalisisViaticos = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.sfdAnalisisViaticos = New System.Windows.Forms.SaveFileDialog()
        CType(Me.pgcAnalisisDinamicoViaticos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionAño.SuspendLayout()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prsAnalisisViaticos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pgcAnalisisDinamicoViaticos
        '
        Me.pgcAnalisisDinamicoViaticos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgcAnalisisDinamicoViaticos.Appearance.ColumnHeaderArea.Options.UseTextOptions = True
        Me.pgcAnalisisDinamicoViaticos.Appearance.ColumnHeaderArea.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.pgcAnalisisDinamicoViaticos.Appearance.DataHeaderArea.Options.UseTextOptions = True
        Me.pgcAnalisisDinamicoViaticos.Appearance.DataHeaderArea.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.pgcAnalisisDinamicoViaticos.Appearance.HeaderArea.Options.UseTextOptions = True
        Me.pgcAnalisisDinamicoViaticos.Appearance.HeaderArea.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.pgcAnalisisDinamicoViaticos.Appearance.RowHeaderArea.Options.UseTextOptions = True
        Me.pgcAnalisisDinamicoViaticos.Appearance.RowHeaderArea.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.pgcAnalisisDinamicoViaticos.Cursor = System.Windows.Forms.Cursors.Default
        Me.pgcAnalisisDinamicoViaticos.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.colANO, Me.colMES, Me.colRUT, Me.colDV, Me.colNOMBRE_EMPLEADO, Me.colMONTO, Me.colNUMERO_CHEQUE, Me.colFECHA_CHEQUE, Me.colCALIDAD_JURIDICA, Me.colESTAMENTO, Me.colDEPARTAMENTO, Me.colFECHA_INICIO, Me.colFECHA_TERMINO, Me.colDIAS, Me.colGRADO, Me.colCLASIFICACION_EMPLEADO, Me.colNRO_RESOLUCION, Me.colFECHA_RESOLUCION, Me.colPAIS_DESTINO, Me.colREGION_DESTINO, Me.colCOMUNA_DESTINO, Me.colDESCRIPCION_ESTADO_VIATICO})
        Me.pgcAnalisisDinamicoViaticos.Location = New System.Drawing.Point(0, 88)
        Me.pgcAnalisisDinamicoViaticos.Name = "pgcAnalisisDinamicoViaticos"
        Me.pgcAnalisisDinamicoViaticos.Size = New System.Drawing.Size(840, 296)
        Me.pgcAnalisisDinamicoViaticos.TabIndex = 0
        '
        'colANO
        '
        Me.colANO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colANO.AreaIndex = 0
        Me.colANO.Caption = "Año"
        Me.colANO.FieldName = "ANO"
        Me.colANO.Name = "colANO"
        '
        'colMES
        '
        Me.colMES.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colMES.AreaIndex = 1
        Me.colMES.Caption = "Mes"
        Me.colMES.FieldName = "MES"
        Me.colMES.Name = "colMES"
        '
        'colRUT
        '
        Me.colRUT.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colRUT.AreaIndex = 2
        Me.colRUT.Caption = "Rut"
        Me.colRUT.FieldName = "RUT"
        Me.colRUT.Name = "colRUT"
        '
        'colDV
        '
        Me.colDV.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colDV.AreaIndex = 3
        Me.colDV.Caption = "Digito Ver."
        Me.colDV.FieldName = "DV"
        Me.colDV.Name = "colDV"
        '
        'colNOMBRE_EMPLEADO
        '
        Me.colNOMBRE_EMPLEADO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colNOMBRE_EMPLEADO.AreaIndex = 4
        Me.colNOMBRE_EMPLEADO.Caption = "Nombre Empleado"
        Me.colNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.colNOMBRE_EMPLEADO.Name = "colNOMBRE_EMPLEADO"
        '
        'colMONTO
        '
        Me.colMONTO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO.AreaIndex = 0
        Me.colMONTO.Caption = "Monto"
        Me.colMONTO.CellFormat.FormatString = "n0"
        Me.colMONTO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO.FieldName = "MONTO"
        Me.colMONTO.GrandTotalCellFormat.FormatString = "n0"
        Me.colMONTO.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO.Name = "colMONTO"
        '
        'colNUMERO_CHEQUE
        '
        Me.colNUMERO_CHEQUE.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colNUMERO_CHEQUE.AreaIndex = 5
        Me.colNUMERO_CHEQUE.Caption = "Número Cheque"
        Me.colNUMERO_CHEQUE.FieldName = "NUMERO_CHEQUE"
        Me.colNUMERO_CHEQUE.Name = "colNUMERO_CHEQUE"
        '
        'colFECHA_CHEQUE
        '
        Me.colFECHA_CHEQUE.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colFECHA_CHEQUE.AreaIndex = 6
        Me.colFECHA_CHEQUE.Caption = "Fecha Cheque"
        Me.colFECHA_CHEQUE.FieldName = "FECHA_CHEQUE"
        Me.colFECHA_CHEQUE.Name = "colFECHA_CHEQUE"
        '
        'colCALIDAD_JURIDICA
        '
        Me.colCALIDAD_JURIDICA.AreaIndex = 0
        Me.colCALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.colCALIDAD_JURIDICA.FieldName = "CALIDAD_JURIDICA"
        Me.colCALIDAD_JURIDICA.Name = "colCALIDAD_JURIDICA"
        '
        'colESTAMENTO
        '
        Me.colESTAMENTO.AreaIndex = 2
        Me.colESTAMENTO.Caption = "Estamento"
        Me.colESTAMENTO.FieldName = "ESTAMENTO"
        Me.colESTAMENTO.Name = "colESTAMENTO"
        '
        'colDEPARTAMENTO
        '
        Me.colDEPARTAMENTO.AreaIndex = 3
        Me.colDEPARTAMENTO.Caption = "Departamento"
        Me.colDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.colDEPARTAMENTO.Name = "colDEPARTAMENTO"
        '
        'colFECHA_INICIO
        '
        Me.colFECHA_INICIO.AreaIndex = 4
        Me.colFECHA_INICIO.Caption = "Fecha Inicio Viático"
        Me.colFECHA_INICIO.FieldName = "FECHA_INICIO"
        Me.colFECHA_INICIO.Name = "colFECHA_INICIO"
        '
        'colFECHA_TERMINO
        '
        Me.colFECHA_TERMINO.AreaIndex = 5
        Me.colFECHA_TERMINO.Caption = "Fecha Término Viático"
        Me.colFECHA_TERMINO.FieldName = "FECHA_TERMINO"
        Me.colFECHA_TERMINO.Name = "colFECHA_TERMINO"
        '
        'colDIAS
        '
        Me.colDIAS.AreaIndex = 6
        Me.colDIAS.Caption = "Días Viático"
        Me.colDIAS.FieldName = "DIAS"
        Me.colDIAS.Name = "colDIAS"
        '
        'colGRADO
        '
        Me.colGRADO.AreaIndex = 7
        Me.colGRADO.Caption = "Grado"
        Me.colGRADO.FieldName = "GRADO"
        Me.colGRADO.Name = "colGRADO"
        '
        'colCLASIFICACION_EMPLEADO
        '
        Me.colCLASIFICACION_EMPLEADO.AreaIndex = 1
        Me.colCLASIFICACION_EMPLEADO.Caption = "Clasificación Empleado"
        Me.colCLASIFICACION_EMPLEADO.FieldName = "CLASIFICACION_EMPLEADO"
        Me.colCLASIFICACION_EMPLEADO.Name = "colCLASIFICACION_EMPLEADO"
        '
        'colNRO_RESOLUCION
        '
        Me.colNRO_RESOLUCION.AreaIndex = 8
        Me.colNRO_RESOLUCION.Caption = "Nro.Resolución"
        Me.colNRO_RESOLUCION.FieldName = "NRO_RESOLUCION"
        Me.colNRO_RESOLUCION.Name = "colNRO_RESOLUCION"
        '
        'colFECHA_RESOLUCION
        '
        Me.colFECHA_RESOLUCION.AreaIndex = 9
        Me.colFECHA_RESOLUCION.Caption = "Fecha Resolución"
        Me.colFECHA_RESOLUCION.FieldName = "FECHA_RESOLUCION"
        Me.colFECHA_RESOLUCION.Name = "colFECHA_RESOLUCION"
        '
        'colPAIS_DESTINO
        '
        Me.colPAIS_DESTINO.AreaIndex = 10
        Me.colPAIS_DESTINO.Caption = "País Destino"
        Me.colPAIS_DESTINO.FieldName = "PAIS_DESTINO"
        Me.colPAIS_DESTINO.Name = "colPAIS_DESTINO"
        '
        'colREGION_DESTINO
        '
        Me.colREGION_DESTINO.AreaIndex = 11
        Me.colREGION_DESTINO.Caption = "Región Destino"
        Me.colREGION_DESTINO.FieldName = "REGION_DESTINO"
        Me.colREGION_DESTINO.Name = "colREGION_DESTINO"
        '
        'colCOMUNA_DESTINO
        '
        Me.colCOMUNA_DESTINO.AreaIndex = 12
        Me.colCOMUNA_DESTINO.Caption = "Comuna Destino"
        Me.colCOMUNA_DESTINO.FieldName = "COMUNA_DESTINO"
        Me.colCOMUNA_DESTINO.Name = "colCOMUNA_DESTINO"
        '
        'colDESCRIPCION_ESTADO_VIATICO
        '
        Me.colDESCRIPCION_ESTADO_VIATICO.AreaIndex = 13
        Me.colDESCRIPCION_ESTADO_VIATICO.Caption = "Estado Viático"
        Me.colDESCRIPCION_ESTADO_VIATICO.FieldName = "DESCRIPCION_ESTADO_VIATICO"
        Me.colDESCRIPCION_ESTADO_VIATICO.Name = "colDESCRIPCION_ESTADO_VIATICO"
        '
        'gpcSeleccionAño
        '
        Me.gpcSeleccionAño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionAño.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionAño.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionAño.Controls.Add(Me.luePeriodo)
        Me.gpcSeleccionAño.Controls.Add(Me.lblPeriodo)
        Me.gpcSeleccionAño.Location = New System.Drawing.Point(0, 8)
        Me.gpcSeleccionAño.Name = "gpcSeleccionAño"
        Me.gpcSeleccionAño.Size = New System.Drawing.Size(840, 80)
        Me.gpcSeleccionAño.TabIndex = 2
        Me.gpcSeleccionAño.Text = "Selección de Año"
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(128, 32)
        Me.luePeriodo.Name = "luePeriodo"
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
        'btnEmiteDetalle
        '
        Me.btnEmiteDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEmiteDetalle.Location = New System.Drawing.Point(512, 392)
        Me.btnEmiteDetalle.Name = "btnEmiteDetalle"
        Me.btnEmiteDetalle.Size = New System.Drawing.Size(160, 23)
        Me.btnEmiteDetalle.TabIndex = 7
        Me.btnEmiteDetalle.Text = "Visualizar"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportExcel.Location = New System.Drawing.Point(696, 392)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(144, 23)
        Me.btnExportExcel.TabIndex = 6
        Me.btnExportExcel.Text = "Exportar a Excel"
        '
        'prsAnalisisViaticos
        '
        Me.prsAnalisisViaticos.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.pgcAnalisisDinamicoViaticos
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(5, 5, 100, 100)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de la República", "Informe Dinámico de Viáticos", "Fecha Emisión:[Date Printed]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Emitido por:[User Name]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"", "", "[Página # de Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.prsAnalisisViaticos
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prsAnalisisViaticos
        '
        'frmAnalisisViaticos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(848, 420)
        Me.Controls.Add(Me.btnEmiteDetalle)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.gpcSeleccionAño)
        Me.Controls.Add(Me.pgcAnalisisDinamicoViaticos)
        Me.Name = "frmAnalisisViaticos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analisis Dinámico de Viaticos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pgcAnalisisDinamicoViaticos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionAño.ResumeLayout(False)
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prsAnalisisViaticos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim empleado As empleado
    Dim parametroMensual As Periodo

    Private Sub frmAnalisisViaticos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        Dim rutaPlanillaExcel As String
        Try
            With sfdAnalisisViaticos
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = sfdAnalisisViaticos.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                pgcAnalisisDinamicoViaticos.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
                pgcAnalisisDinamicoViaticos.DataSource = empleado.recuperaAnalisisDinamicoViaticos(luePeriodo.EditValue)
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al leer datos de viáticos." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnEmiteDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmiteDetalle.Click
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
    End Sub
    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "Período : " & luePeriodo.EditValue
        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)
    End Sub

End Class
