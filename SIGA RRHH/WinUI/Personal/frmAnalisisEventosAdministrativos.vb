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

Public Class frmAnalisisEventosAdministrativos
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
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sfdAnalisisDinamicoEventosAdmin As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pgcAnalisisDinamicoEventosAdmin As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEVENTO_ADMINISTRATIVO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDEPARTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCALIDAD_JURIDICA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCLASIFICACION_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldANO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGRADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMOTIVO_SOLICITUD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCANTIDAD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents prsAnalisisDinamicoEventosAdmin As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents btnEmiteDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents fieldSEXO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDIRECCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSUB_DEPTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colRUT_E As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAPELLIDO_PATERNO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAPELLIDO_MATERNO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents chkSoloEmpleadosActivos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtMesFinal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMesInicial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMesFinal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMesInicial As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents fieldNOMBRES As DevExpress.XtraPivotGrid.PivotGridField
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalisisEventosAdministrativos))
        Me.pgcAnalisisDinamicoEventosAdmin = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldRUT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRE_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEVENTO_ADMINISTRATIVO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDEPARTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCALIDAD_JURIDICA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCLASIFICACION_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldGRADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldESTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldANO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMOTIVO_SOLICITUD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCANTIDAD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSEXO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDIRECCION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSUB_DEPTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colRUT_E = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colDV = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAPELLIDO_PATERNO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAPELLIDO_MATERNO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.gpcSeleccionAño = New DevExpress.XtraEditors.GroupControl()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.sfdAnalisisDinamicoEventosAdmin = New System.Windows.Forms.SaveFileDialog()
        Me.prsAnalisisDinamicoEventosAdmin = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.btnEmiteDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.lblMesInicial = New DevExpress.XtraEditors.LabelControl()
        Me.lblMesFinal = New DevExpress.XtraEditors.LabelControl()
        Me.txtMesInicial = New DevExpress.XtraEditors.TextEdit()
        Me.txtMesFinal = New DevExpress.XtraEditors.TextEdit()
        Me.chkSoloEmpleadosActivos = New DevExpress.XtraEditors.CheckEdit()
        Me.btnGenerar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.pgcAnalisisDinamicoEventosAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionAño.SuspendLayout()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prsAnalisisDinamicoEventosAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMesInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMesFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSoloEmpleadosActivos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pgcAnalisisDinamicoEventosAdmin
        '
        Me.pgcAnalisisDinamicoEventosAdmin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgcAnalisisDinamicoEventosAdmin.Cursor = System.Windows.Forms.Cursors.Default
        Me.pgcAnalisisDinamicoEventosAdmin.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldRUT, Me.fieldNOMBRE_EMPLEADO, Me.fieldEVENTO_ADMINISTRATIVO, Me.fieldDEPARTAMENTO, Me.fieldCALIDAD_JURIDICA, Me.fieldCLASIFICACION_EMPLEADO, Me.fieldGRADO, Me.fieldESTAMENTO, Me.fieldANO, Me.fieldMES, Me.fieldMOTIVO_SOLICITUD, Me.fieldCANTIDAD, Me.fieldSEXO, Me.fieldDIRECCION, Me.fieldSUB_DEPTO, Me.colRUT_E, Me.colDV, Me.fieldAPELLIDO_PATERNO, Me.fieldAPELLIDO_MATERNO, Me.fieldNOMBRES})
        Me.pgcAnalisisDinamicoEventosAdmin.Location = New System.Drawing.Point(8, 152)
        Me.pgcAnalisisDinamicoEventosAdmin.Name = "pgcAnalisisDinamicoEventosAdmin"
        Me.pgcAnalisisDinamicoEventosAdmin.Size = New System.Drawing.Size(840, 372)
        Me.pgcAnalisisDinamicoEventosAdmin.TabIndex = 0
        '
        'fieldRUT
        '
        Me.fieldRUT.AreaIndex = 0
        Me.fieldRUT.Caption = "Rut Empleado"
        Me.fieldRUT.FieldName = "RUT"
        Me.fieldRUT.Name = "fieldRUT"
        '
        'fieldNOMBRE_EMPLEADO
        '
        Me.fieldNOMBRE_EMPLEADO.AreaIndex = 1
        Me.fieldNOMBRE_EMPLEADO.Caption = "Nombre Empleado"
        Me.fieldNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.Name = "fieldNOMBRE_EMPLEADO"
        '
        'fieldEVENTO_ADMINISTRATIVO
        '
        Me.fieldEVENTO_ADMINISTRATIVO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldEVENTO_ADMINISTRATIVO.AreaIndex = 0
        Me.fieldEVENTO_ADMINISTRATIVO.Caption = "Evento Administrativo"
        Me.fieldEVENTO_ADMINISTRATIVO.FieldName = "EVENTO_ADMINISTRATIVO"
        Me.fieldEVENTO_ADMINISTRATIVO.Name = "fieldEVENTO_ADMINISTRATIVO"
        '
        'fieldDEPARTAMENTO
        '
        Me.fieldDEPARTAMENTO.AreaIndex = 3
        Me.fieldDEPARTAMENTO.Caption = "Departamento"
        Me.fieldDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.fieldDEPARTAMENTO.Name = "fieldDEPARTAMENTO"
        '
        'fieldCALIDAD_JURIDICA
        '
        Me.fieldCALIDAD_JURIDICA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCALIDAD_JURIDICA.AreaIndex = 2
        Me.fieldCALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.fieldCALIDAD_JURIDICA.FieldName = "CALIDAD_JURIDICA"
        Me.fieldCALIDAD_JURIDICA.Name = "fieldCALIDAD_JURIDICA"
        '
        'fieldCLASIFICACION_EMPLEADO
        '
        Me.fieldCLASIFICACION_EMPLEADO.AreaIndex = 5
        Me.fieldCLASIFICACION_EMPLEADO.Caption = "Clasificación Empleado"
        Me.fieldCLASIFICACION_EMPLEADO.FieldName = "CLASIFICACION_EMPLEADO"
        Me.fieldCLASIFICACION_EMPLEADO.Name = "fieldCLASIFICACION_EMPLEADO"
        '
        'fieldGRADO
        '
        Me.fieldGRADO.AreaIndex = 6
        Me.fieldGRADO.Caption = "Grado"
        Me.fieldGRADO.FieldName = "GRADO"
        Me.fieldGRADO.Name = "fieldGRADO"
        '
        'fieldESTAMENTO
        '
        Me.fieldESTAMENTO.AreaIndex = 7
        Me.fieldESTAMENTO.Caption = "Estamento"
        Me.fieldESTAMENTO.FieldName = "ESTAMENTO"
        Me.fieldESTAMENTO.Name = "fieldESTAMENTO"
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
        'fieldMOTIVO_SOLICITUD
        '
        Me.fieldMOTIVO_SOLICITUD.AreaIndex = 8
        Me.fieldMOTIVO_SOLICITUD.Caption = "Tipo Movimiento"
        Me.fieldMOTIVO_SOLICITUD.FieldName = "MOTIVO_SOLICITUD"
        Me.fieldMOTIVO_SOLICITUD.Name = "fieldMOTIVO_SOLICITUD"
        '
        'fieldCANTIDAD
        '
        Me.fieldCANTIDAD.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCANTIDAD.AreaIndex = 0
        Me.fieldCANTIDAD.Caption = "Cantidad"
        Me.fieldCANTIDAD.CellFormat.FormatString = "n1"
        Me.fieldCANTIDAD.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCANTIDAD.FieldName = "CANTIDAD"
        Me.fieldCANTIDAD.Name = "fieldCANTIDAD"
        '
        'fieldSEXO
        '
        Me.fieldSEXO.AreaIndex = 9
        Me.fieldSEXO.Caption = "Sexo"
        Me.fieldSEXO.FieldName = "SEXO"
        Me.fieldSEXO.Name = "fieldSEXO"
        '
        'fieldDIRECCION
        '
        Me.fieldDIRECCION.AreaIndex = 2
        Me.fieldDIRECCION.Caption = "Dirección"
        Me.fieldDIRECCION.FieldName = "DIRECCION"
        Me.fieldDIRECCION.Name = "fieldDIRECCION"
        '
        'fieldSUB_DEPTO
        '
        Me.fieldSUB_DEPTO.AreaIndex = 4
        Me.fieldSUB_DEPTO.Caption = "Sub Departamento"
        Me.fieldSUB_DEPTO.FieldName = "SUB_DEPTO"
        Me.fieldSUB_DEPTO.Name = "fieldSUB_DEPTO"
        '
        'colRUT_E
        '
        Me.colRUT_E.AreaIndex = 10
        Me.colRUT_E.Caption = "Rut"
        Me.colRUT_E.FieldName = "RUT_E"
        Me.colRUT_E.Name = "colRUT_E"
        '
        'colDV
        '
        Me.colDV.AreaIndex = 11
        Me.colDV.Caption = "Dv"
        Me.colDV.FieldName = "DV"
        Me.colDV.Name = "colDV"
        '
        'fieldAPELLIDO_PATERNO
        '
        Me.fieldAPELLIDO_PATERNO.AreaIndex = 12
        Me.fieldAPELLIDO_PATERNO.Caption = "Apellido Paterno"
        Me.fieldAPELLIDO_PATERNO.FieldName = "APELLIDO_PATERNO"
        Me.fieldAPELLIDO_PATERNO.Name = "fieldAPELLIDO_PATERNO"
        '
        'fieldAPELLIDO_MATERNO
        '
        Me.fieldAPELLIDO_MATERNO.AreaIndex = 13
        Me.fieldAPELLIDO_MATERNO.Caption = "Apellido Materno"
        Me.fieldAPELLIDO_MATERNO.FieldName = "APELLIDO_MATERNO"
        Me.fieldAPELLIDO_MATERNO.Name = "fieldAPELLIDO_MATERNO"
        '
        'fieldNOMBRES
        '
        Me.fieldNOMBRES.AreaIndex = 14
        Me.fieldNOMBRES.Caption = "Nombres"
        Me.fieldNOMBRES.FieldName = "NOMBRES"
        Me.fieldNOMBRES.Name = "fieldNOMBRES"
        '
        'gpcSeleccionAño
        '
        Me.gpcSeleccionAño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionAño.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionAño.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionAño.Controls.Add(Me.btnEmiteDetalle)
        Me.gpcSeleccionAño.Controls.Add(Me.btnExportExcel)
        Me.gpcSeleccionAño.Controls.Add(Me.btnGenerar)
        Me.gpcSeleccionAño.Controls.Add(Me.chkSoloEmpleadosActivos)
        Me.gpcSeleccionAño.Controls.Add(Me.txtMesFinal)
        Me.gpcSeleccionAño.Controls.Add(Me.txtMesInicial)
        Me.gpcSeleccionAño.Controls.Add(Me.lblMesFinal)
        Me.gpcSeleccionAño.Controls.Add(Me.lblMesInicial)
        Me.gpcSeleccionAño.Controls.Add(Me.luePeriodo)
        Me.gpcSeleccionAño.Controls.Add(Me.lblPeriodo)
        Me.gpcSeleccionAño.Location = New System.Drawing.Point(8, 8)
        Me.gpcSeleccionAño.Name = "gpcSeleccionAño"
        Me.gpcSeleccionAño.Size = New System.Drawing.Size(840, 138)
        Me.gpcSeleccionAño.TabIndex = 1
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
        'btnExportExcel
        '
        Me.btnExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExportExcel.Location = New System.Drawing.Point(671, 62)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(144, 23)
        Me.btnExportExcel.TabIndex = 4
        Me.btnExportExcel.Text = "Exportar a Excel"
        '
        'prsAnalisisDinamicoEventosAdmin
        '
        Me.prsAnalisisDinamicoEventosAdmin.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.pgcAnalisisDinamicoEventosAdmin
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(5, 5, 100, 100)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de La República", "Análisis Movimientos Eventos Administrativos", "Fecha Emisión:[Date Printed]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Emitido por:[User Name]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"", "", "Página:[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.prsAnalisisDinamicoEventosAdmin
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prsAnalisisDinamicoEventosAdmin
        '
        'btnEmiteDetalle
        '
        Me.btnEmiteDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEmiteDetalle.Location = New System.Drawing.Point(487, 62)
        Me.btnEmiteDetalle.Name = "btnEmiteDetalle"
        Me.btnEmiteDetalle.Size = New System.Drawing.Size(160, 23)
        Me.btnEmiteDetalle.TabIndex = 5
        Me.btnEmiteDetalle.Text = "Visualizar"
        '
        'lblMesInicial
        '
        Me.lblMesInicial.Location = New System.Drawing.Point(63, 62)
        Me.lblMesInicial.Name = "lblMesInicial"
        Me.lblMesInicial.Size = New System.Drawing.Size(49, 13)
        Me.lblMesInicial.TabIndex = 5
        Me.lblMesInicial.Text = "Mes Inicial"
        '
        'lblMesFinal
        '
        Me.lblMesFinal.Location = New System.Drawing.Point(68, 88)
        Me.lblMesFinal.Name = "lblMesFinal"
        Me.lblMesFinal.Size = New System.Drawing.Size(44, 13)
        Me.lblMesFinal.TabIndex = 5
        Me.lblMesFinal.Text = "Mes Final"
        '
        'txtMesInicial
        '
        Me.txtMesInicial.Location = New System.Drawing.Point(128, 59)
        Me.txtMesInicial.Name = "txtMesInicial"
        Me.txtMesInicial.Size = New System.Drawing.Size(53, 20)
        Me.txtMesInicial.TabIndex = 6
        '
        'txtMesFinal
        '
        Me.txtMesFinal.Location = New System.Drawing.Point(128, 85)
        Me.txtMesFinal.Name = "txtMesFinal"
        Me.txtMesFinal.Size = New System.Drawing.Size(53, 20)
        Me.txtMesFinal.TabIndex = 6
        '
        'chkSoloEmpleadosActivos
        '
        Me.chkSoloEmpleadosActivos.Location = New System.Drawing.Point(126, 111)
        Me.chkSoloEmpleadosActivos.Name = "chkSoloEmpleadosActivos"
        Me.chkSoloEmpleadosActivos.Properties.Caption = "Solo Empleados Activos"
        Me.chkSoloEmpleadosActivos.Size = New System.Drawing.Size(144, 19)
        Me.chkSoloEmpleadosActivos.TabIndex = 7
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(291, 62)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(174, 23)
        Me.btnGenerar.TabIndex = 8
        Me.btnGenerar.Text = "Generar"
        '
        'frmAnalisisEventosAdministrativos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 562)
        Me.Controls.Add(Me.gpcSeleccionAño)
        Me.Controls.Add(Me.pgcAnalisisDinamicoEventosAdmin)
        Me.Name = "frmAnalisisEventosAdministrativos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Análisis Dinámico Eventos Administrativos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pgcAnalisisDinamicoEventosAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionAño.ResumeLayout(False)
        Me.gpcSeleccionAño.PerformLayout()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prsAnalisisDinamicoEventosAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMesInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMesFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSoloEmpleadosActivos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim empleado As Empleado
    Dim parametroMensual As Periodo

    Private Sub frmAnalisisEventosAdministrativos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkSoloEmpleadosActivos.Checked = True
        empleado = New Empleado
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
            With sfdAnalisisDinamicoEventosAdmin
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = sfdAnalisisDinamicoEventosAdmin.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                pgcAnalisisDinamicoEventosAdmin.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged

    End Sub

    Private Function ValidaMeses() As Boolean
        Dim ValidacionMeses As Boolean = True
        If txtMesInicial.EditValue <= 0 Then
            txtMesInicial.ErrorText = "Mes inicial debe estar entre 1 y 12"
            ValidacionMeses = False
        End If
        If txtMesFinal.EditValue <= 0 Then
            txtMesFinal.ErrorText = "Mes final debe estar entre 1 y 12"
            ValidacionMeses = False
        End If
        If (txtMesInicial.EditValue > 0 And txtMesFinal.EditValue > 0) And (txtMesFinal.EditValue < txtMesInicial.EditValue) Then
            txtMesFinal.ErrorText = "Mes final no puede ser anterior al mes inicial"
            ValidacionMeses = False
        End If
        Return ValidacionMeses
    End Function

    Private Sub refrescaDetalle()
        Cursor.Current = Cursors.WaitCursor
        If luePeriodo.EditValue <> Nothing Then
            Try
                pgcAnalisisDinamicoEventosAdmin.DataSource = empleado.recuperaAnalisisDinamicoEventosAdministrativos(luePeriodo.EditValue, txtMesInicial.EditValue, txtMesFinal.EditValue, chkSoloEmpleadosActivos.Checked)
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al leer datos saldo días de eventos administrativos." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
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

    Private Sub btnGenerar_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerar.Click
        If luePeriodo.EditValue <> Nothing Then
            If ValidaMeses() Then
                If MsgBoxResult.Yes = MessageBox.Show("El siguiente informe podría tardar varios minutos, ¿desea continuar?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                    refrescaDetalle()
                End If
            End If

        End If
    End Sub
End Class
