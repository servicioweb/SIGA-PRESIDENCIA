Imports System.Drawing
Imports cl.presidencia.Argo.DataAccess
Imports DevExpress.XtraEditors.Controls
Imports cl.presidencia.Argo.BusinessRules

Public Class frmAnalisisEmpleadosDIPRES
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
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents fieldESTADO_REGISTRO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDESCRIPCION_PERIODO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTADO_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCALIDAD_JURIDICA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTAMENTO_DIPRES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTAMENTO_RRHH As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCLASIFICACION_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGRADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_ING_INSTITUCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSEXO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHA_RETIRO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMOTIVO_RETIRO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRETIRO_APLICA_DIPRES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEDAD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSISTEMA_PREVISIONAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSISTEMA_PREVISIONAL_SALUD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridmaestroEmpleadosDIPRES As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents fieldCANTIDAD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTIPO_MOVIMIENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents gpcSeleccionAño As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkSoloEmpleadosActivos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtMesFinal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMesInicial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMesFinal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMesInicial As DevExpress.XtraEditors.LabelControl
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblAno As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DsMaestroEmpleadosDIPRES1 As cl.presidencia.Argo.DataAccess.DsMaestroEmpleadosDIPRES
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalisisEmpleadosDIPRES))
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.gridmaestroEmpleadosDIPRES = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldESTADO_REGISTRO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDESCRIPCION_PERIODO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldESTADO_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRUT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRE_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCALIDAD_JURIDICA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldESTAMENTO_DIPRES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldESTAMENTO_RRHH = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCLASIFICACION_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldGRADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHA_ING_INSTITUCION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSEXO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHA_RETIRO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMOTIVO_RETIRO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRETIRO_APLICA_DIPRES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEDAD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSISTEMA_PREVISIONAL = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSISTEMA_PREVISIONAL_SALUD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCANTIDAD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTIPO_MOVIMIENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.DsMaestroEmpleadosDIPRES1 = New cl.presidencia.Argo.DataAccess.DsMaestroEmpleadosDIPRES()
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.gpcSeleccionAño = New DevExpress.XtraEditors.GroupControl()
        Me.btnGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.chkSoloEmpleadosActivos = New DevExpress.XtraEditors.CheckEdit()
        Me.txtMesFinal = New DevExpress.XtraEditors.TextEdit()
        Me.txtMesInicial = New DevExpress.XtraEditors.TextEdit()
        Me.lblMesFinal = New DevExpress.XtraEditors.LabelControl()
        Me.lblMesInicial = New DevExpress.XtraEditors.LabelControl()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblAno = New DevExpress.XtraEditors.LabelControl()
        CType(Me.gridmaestroEmpleadosDIPRES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaestroEmpleadosDIPRES1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionAño.SuspendLayout()
        CType(Me.chkSoloEmpleadosActivos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMesFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMesInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        '
        'gridmaestroEmpleadosDIPRES
        '
        Me.gridmaestroEmpleadosDIPRES.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridmaestroEmpleadosDIPRES.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridmaestroEmpleadosDIPRES.DataMember = Nothing
        Me.gridmaestroEmpleadosDIPRES.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldESTADO_REGISTRO, Me.fieldDESCRIPCION_PERIODO, Me.fieldESTADO_EMPLEADO, Me.fieldRUT, Me.fieldNOMBRE_EMPLEADO, Me.fieldCALIDAD_JURIDICA, Me.fieldESTAMENTO_DIPRES, Me.fieldESTAMENTO_RRHH, Me.fieldCLASIFICACION_EMPLEADO, Me.fieldGRADO, Me.fieldFECHA_ING_INSTITUCION, Me.fieldSEXO, Me.fieldFECHA_RETIRO, Me.fieldMOTIVO_RETIRO, Me.fieldRETIRO_APLICA_DIPRES, Me.fieldEDAD, Me.fieldSISTEMA_PREVISIONAL, Me.fieldSISTEMA_PREVISIONAL_SALUD, Me.fieldCANTIDAD, Me.fieldTIPO_MOVIMIENTO})
        Me.gridmaestroEmpleadosDIPRES.Location = New System.Drawing.Point(8, 149)
        Me.gridmaestroEmpleadosDIPRES.Name = "gridmaestroEmpleadosDIPRES"
        Me.gridmaestroEmpleadosDIPRES.Size = New System.Drawing.Size(632, 455)
        Me.gridmaestroEmpleadosDIPRES.TabIndex = 0
        '
        'fieldESTADO_REGISTRO
        '
        Me.fieldESTADO_REGISTRO.AreaIndex = 9
        Me.fieldESTADO_REGISTRO.Caption = "Estado"
        Me.fieldESTADO_REGISTRO.FieldName = "ESTADO_REGISTRO"
        Me.fieldESTADO_REGISTRO.Name = "fieldESTADO_REGISTRO"
        '
        'fieldDESCRIPCION_PERIODO
        '
        Me.fieldDESCRIPCION_PERIODO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldDESCRIPCION_PERIODO.AreaIndex = 0
        Me.fieldDESCRIPCION_PERIODO.Caption = "Período"
        Me.fieldDESCRIPCION_PERIODO.FieldName = "DESCRIPCION_PERIODO"
        Me.fieldDESCRIPCION_PERIODO.Name = "fieldDESCRIPCION_PERIODO"
        '
        'fieldESTADO_EMPLEADO
        '
        Me.fieldESTADO_EMPLEADO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldESTADO_EMPLEADO.AreaIndex = 1
        Me.fieldESTADO_EMPLEADO.Caption = "Estado Empleado"
        Me.fieldESTADO_EMPLEADO.FieldName = "ESTADO_EMPLEADO"
        Me.fieldESTADO_EMPLEADO.Name = "fieldESTADO_EMPLEADO"
        '
        'fieldRUT
        '
        Me.fieldRUT.AreaIndex = 0
        Me.fieldRUT.Caption = "RUT"
        Me.fieldRUT.FieldName = "RUT"
        Me.fieldRUT.Name = "fieldRUT"
        '
        'fieldNOMBRE_EMPLEADO
        '
        Me.fieldNOMBRE_EMPLEADO.AreaIndex = 10
        Me.fieldNOMBRE_EMPLEADO.Caption = "Empleado"
        Me.fieldNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.Name = "fieldNOMBRE_EMPLEADO"
        '
        'fieldCALIDAD_JURIDICA
        '
        Me.fieldCALIDAD_JURIDICA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCALIDAD_JURIDICA.AreaIndex = 2
        Me.fieldCALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.fieldCALIDAD_JURIDICA.FieldName = "CALIDAD_JURIDICA"
        Me.fieldCALIDAD_JURIDICA.Name = "fieldCALIDAD_JURIDICA"
        '
        'fieldESTAMENTO_DIPRES
        '
        Me.fieldESTAMENTO_DIPRES.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldESTAMENTO_DIPRES.AreaIndex = 3
        Me.fieldESTAMENTO_DIPRES.Caption = "Estamento (DIPRES)"
        Me.fieldESTAMENTO_DIPRES.FieldName = "ESTAMENTO_DIPRES"
        Me.fieldESTAMENTO_DIPRES.Name = "fieldESTAMENTO_DIPRES"
        '
        'fieldESTAMENTO_RRHH
        '
        Me.fieldESTAMENTO_RRHH.AreaIndex = 1
        Me.fieldESTAMENTO_RRHH.Caption = "Estamento (RRHH)"
        Me.fieldESTAMENTO_RRHH.FieldName = "ESTAMENTO_RRHH"
        Me.fieldESTAMENTO_RRHH.Name = "fieldESTAMENTO_RRHH"
        '
        'fieldCLASIFICACION_EMPLEADO
        '
        Me.fieldCLASIFICACION_EMPLEADO.AreaIndex = 2
        Me.fieldCLASIFICACION_EMPLEADO.Caption = "Clasificación"
        Me.fieldCLASIFICACION_EMPLEADO.FieldName = "CLASIFICACION_EMPLEADO"
        Me.fieldCLASIFICACION_EMPLEADO.Name = "fieldCLASIFICACION_EMPLEADO"
        '
        'fieldGRADO
        '
        Me.fieldGRADO.AreaIndex = 3
        Me.fieldGRADO.Caption = "Grado"
        Me.fieldGRADO.FieldName = "GRADO"
        Me.fieldGRADO.Name = "fieldGRADO"
        '
        'fieldFECHA_ING_INSTITUCION
        '
        Me.fieldFECHA_ING_INSTITUCION.AreaIndex = 4
        Me.fieldFECHA_ING_INSTITUCION.Caption = "Fecha Ingreso"
        Me.fieldFECHA_ING_INSTITUCION.FieldName = "FECHA_ING_INSTITUCION"
        Me.fieldFECHA_ING_INSTITUCION.Name = "fieldFECHA_ING_INSTITUCION"
        '
        'fieldSEXO
        '
        Me.fieldSEXO.AreaIndex = 11
        Me.fieldSEXO.Caption = "Sexo"
        Me.fieldSEXO.FieldName = "SEXO"
        Me.fieldSEXO.Name = "fieldSEXO"
        '
        'fieldFECHA_RETIRO
        '
        Me.fieldFECHA_RETIRO.AreaIndex = 5
        Me.fieldFECHA_RETIRO.Caption = "Fecha Retiro"
        Me.fieldFECHA_RETIRO.FieldName = "FECHA_RETIRO"
        Me.fieldFECHA_RETIRO.Name = "fieldFECHA_RETIRO"
        '
        'fieldMOTIVO_RETIRO
        '
        Me.fieldMOTIVO_RETIRO.AreaIndex = 6
        Me.fieldMOTIVO_RETIRO.Caption = "Motivo Retiro"
        Me.fieldMOTIVO_RETIRO.FieldName = "MOTIVO_RETIRO"
        Me.fieldMOTIVO_RETIRO.Name = "fieldMOTIVO_RETIRO"
        '
        'fieldRETIRO_APLICA_DIPRES
        '
        Me.fieldRETIRO_APLICA_DIPRES.AreaIndex = 7
        Me.fieldRETIRO_APLICA_DIPRES.Caption = "Retiro Aplica DIPRES"
        Me.fieldRETIRO_APLICA_DIPRES.FieldName = "RETIRO_APLICA_DIPRES"
        Me.fieldRETIRO_APLICA_DIPRES.Name = "fieldRETIRO_APLICA_DIPRES"
        '
        'fieldEDAD
        '
        Me.fieldEDAD.AreaIndex = 8
        Me.fieldEDAD.Caption = "Edad"
        Me.fieldEDAD.FieldName = "EDAD"
        Me.fieldEDAD.Name = "fieldEDAD"
        '
        'fieldSISTEMA_PREVISIONAL
        '
        Me.fieldSISTEMA_PREVISIONAL.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldSISTEMA_PREVISIONAL.AreaIndex = 0
        Me.fieldSISTEMA_PREVISIONAL.Caption = "Sistema Previsional"
        Me.fieldSISTEMA_PREVISIONAL.FieldName = "SISTEMA_PREVISIONAL"
        Me.fieldSISTEMA_PREVISIONAL.Name = "fieldSISTEMA_PREVISIONAL"
        '
        'fieldSISTEMA_PREVISIONAL_SALUD
        '
        Me.fieldSISTEMA_PREVISIONAL_SALUD.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldSISTEMA_PREVISIONAL_SALUD.AreaIndex = 1
        Me.fieldSISTEMA_PREVISIONAL_SALUD.Caption = "Sistema Salud"
        Me.fieldSISTEMA_PREVISIONAL_SALUD.FieldName = "SISTEMA_PREVISIONAL_SALUD"
        Me.fieldSISTEMA_PREVISIONAL_SALUD.Name = "fieldSISTEMA_PREVISIONAL_SALUD"
        '
        'fieldCANTIDAD
        '
        Me.fieldCANTIDAD.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCANTIDAD.AreaIndex = 0
        Me.fieldCANTIDAD.Caption = "Cantidad"
        Me.fieldCANTIDAD.FieldName = "CANTIDAD"
        Me.fieldCANTIDAD.Name = "fieldCANTIDAD"
        Me.fieldCANTIDAD.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldTIPO_MOVIMIENTO
        '
        Me.fieldTIPO_MOVIMIENTO.AreaIndex = 12
        Me.fieldTIPO_MOVIMIENTO.Caption = "Tipo Movimiento"
        Me.fieldTIPO_MOVIMIENTO.FieldName = "TIPO_MOVIMIENTO"
        Me.fieldTIPO_MOVIMIENTO.Name = "fieldTIPO_MOVIMIENTO"
        '
        'DsMaestroEmpleadosDIPRES1
        '
        Me.DsMaestroEmpleadosDIPRES1.DataSetName = "VW_MAESTRO_EMPLEADO_DIPRES"
        Me.DsMaestroEmpleadosDIPRES1.Locale = New System.Globalization.CultureInfo("es-CL")
        Me.DsMaestroEmpleadosDIPRES1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExportExcel.Location = New System.Drawing.Point(392, 44)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(144, 23)
        Me.btnExportExcel.TabIndex = 2
        Me.btnExportExcel.Text = "Exportar a Excel"
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "VW_MAESTRO_EMPLEADO_DIPRES", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ESTADO_REGISTRO", "ESTADO_REGISTRO"), New System.Data.Common.DataColumnMapping("DESCRIPCION_PERIODO", "DESCRIPCION_PERIODO"), New System.Data.Common.DataColumnMapping("ORGANIZACION_ID", "ORGANIZACION_ID"), New System.Data.Common.DataColumnMapping("ESTADO_EMPLEADO", "ESTADO_EMPLEADO"), New System.Data.Common.DataColumnMapping("EMPLEADO_ID", "EMPLEADO_ID"), New System.Data.Common.DataColumnMapping("RUT", "RUT"), New System.Data.Common.DataColumnMapping("DV", "DV"), New System.Data.Common.DataColumnMapping("NOMBRE_EMPLEADO", "NOMBRE_EMPLEADO"), New System.Data.Common.DataColumnMapping("CALIDAD_JURIDICA", "CALIDAD_JURIDICA"), New System.Data.Common.DataColumnMapping("ESTAMENTO_DIPRES", "ESTAMENTO_DIPRES"), New System.Data.Common.DataColumnMapping("ESTAMENTO_RRHH", "ESTAMENTO_RRHH"), New System.Data.Common.DataColumnMapping("CLASIFICACION_EMPLEADO", "CLASIFICACION_EMPLEADO"), New System.Data.Common.DataColumnMapping("GRADO", "GRADO"), New System.Data.Common.DataColumnMapping("FECHA_ING_INSTITUCION", "FECHA_ING_INSTITUCION"), New System.Data.Common.DataColumnMapping("SEXO", "SEXO"), New System.Data.Common.DataColumnMapping("FECHA_RETIRO", "FECHA_RETIRO"), New System.Data.Common.DataColumnMapping("MOTIVO_RETIRO", "MOTIVO_RETIRO"), New System.Data.Common.DataColumnMapping("RETIRO_APLICA_DIPRES", "RETIRO_APLICA_DIPRES"), New System.Data.Common.DataColumnMapping("EDAD", "EDAD"), New System.Data.Common.DataColumnMapping("SISTEMA_PREVISIONAL", "SISTEMA_PREVISIONAL"), New System.Data.Common.DataColumnMapping("SISTEMA_PREVISIONAL_SALUD", "SISTEMA_PREVISIONAL_SALUD"), New System.Data.Common.DataColumnMapping("CANTIDAD", "CANTIDAD")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = CType(configurationAppSettings.GetValue("ConnectionString", GetType(String)), String)
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'gpcSeleccionAño
        '
        Me.gpcSeleccionAño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionAño.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionAño.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionAño.Controls.Add(Me.btnGenerar)
        Me.gpcSeleccionAño.Controls.Add(Me.btnExportExcel)
        Me.gpcSeleccionAño.Controls.Add(Me.chkSoloEmpleadosActivos)
        Me.gpcSeleccionAño.Controls.Add(Me.txtMesFinal)
        Me.gpcSeleccionAño.Controls.Add(Me.txtMesInicial)
        Me.gpcSeleccionAño.Controls.Add(Me.lblMesFinal)
        Me.gpcSeleccionAño.Controls.Add(Me.lblMesInicial)
        Me.gpcSeleccionAño.Controls.Add(Me.luePeriodo)
        Me.gpcSeleccionAño.Controls.Add(Me.lblAno)
        Me.gpcSeleccionAño.Location = New System.Drawing.Point(12, 12)
        Me.gpcSeleccionAño.Name = "gpcSeleccionAño"
        Me.gpcSeleccionAño.Size = New System.Drawing.Size(628, 131)
        Me.gpcSeleccionAño.TabIndex = 3
        Me.gpcSeleccionAño.Text = "Selección de Año"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(262, 44)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(124, 23)
        Me.btnGenerar.TabIndex = 5
        Me.btnGenerar.Text = "Generar"
        '
        'chkSoloEmpleadosActivos
        '
        Me.chkSoloEmpleadosActivos.Location = New System.Drawing.Point(125, 104)
        Me.chkSoloEmpleadosActivos.Name = "chkSoloEmpleadosActivos"
        Me.chkSoloEmpleadosActivos.Properties.Caption = "Solo Empleados Activos"
        Me.chkSoloEmpleadosActivos.Size = New System.Drawing.Size(143, 19)
        Me.chkSoloEmpleadosActivos.TabIndex = 4
        '
        'txtMesFinal
        '
        Me.txtMesFinal.Location = New System.Drawing.Point(127, 78)
        Me.txtMesFinal.Name = "txtMesFinal"
        Me.txtMesFinal.Size = New System.Drawing.Size(53, 20)
        Me.txtMesFinal.TabIndex = 3
        '
        'txtMesInicial
        '
        Me.txtMesInicial.Location = New System.Drawing.Point(127, 52)
        Me.txtMesInicial.Name = "txtMesInicial"
        Me.txtMesInicial.Size = New System.Drawing.Size(53, 20)
        Me.txtMesInicial.TabIndex = 3
        '
        'lblMesFinal
        '
        Me.lblMesFinal.Location = New System.Drawing.Point(77, 81)
        Me.lblMesFinal.Name = "lblMesFinal"
        Me.lblMesFinal.Size = New System.Drawing.Size(44, 13)
        Me.lblMesFinal.TabIndex = 2
        Me.lblMesFinal.Text = "Mes Final"
        '
        'lblMesInicial
        '
        Me.lblMesInicial.Location = New System.Drawing.Point(72, 55)
        Me.lblMesInicial.Name = "lblMesInicial"
        Me.lblMesInicial.Size = New System.Drawing.Size(49, 13)
        Me.lblMesInicial.TabIndex = 2
        Me.lblMesInicial.Text = "Mes Inicial"
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(127, 26)
        Me.luePeriodo.Name = "luePeriodo"
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Size = New System.Drawing.Size(114, 20)
        Me.luePeriodo.TabIndex = 1
        '
        'lblAno
        '
        Me.lblAno.Location = New System.Drawing.Point(102, 29)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(19, 13)
        Me.lblAno.TabIndex = 0
        Me.lblAno.Text = "Año"
        '
        'frmAnalisisEmpleadosDIPRES
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 616)
        Me.Controls.Add(Me.gpcSeleccionAño)
        Me.Controls.Add(Me.gridmaestroEmpleadosDIPRES)
        Me.Name = "frmAnalisisEmpleadosDIPRES"
        Me.Text = "Análisis de Maestro de Empleados / DIPRES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridmaestroEmpleadosDIPRES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaestroEmpleadosDIPRES1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcSeleccionAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionAño.ResumeLayout(False)
        Me.gpcSeleccionAño.PerformLayout()
        CType(Me.chkSoloEmpleadosActivos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMesFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMesInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim empleado As Empleado

    Private Shared Function GetConn() As SqlClient.SqlConnection
        Dim conn As New SqlClient.SqlConnection
        Return conn
    End Function

    Private Sub frmAnalisisEmpleadosDIPRES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarPeriodos()
        chkSoloEmpleadosActivos.Checked = True
        'Dim conn As SqlClient.SqlConnection = GetConn()
        'conn.ConnectionString = Argo.Comun.ArgoConfiguracion.ConnectionString
        'conn.Open()
        'SqlDataAdapter1.SelectCommand = New SqlClient.SqlCommand(Argo.Comun.SQL.VISTAS.SELECT_MAESTRO_EMPLEADOS_DIPRES)
        'SqlDataAdapter1.SelectCommand.Connection = conn
        'Try
        '    SqlDataAdapter1.Fill(DsMaestroEmpleadosDIPRES1)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        '    Me.Close()
        'End Try
        'gridmaestroEmpleadosDIPRES.Refresh()
    End Sub

    Private Sub RefrescaDetalle()
        Cursor = Cursors.AppStarting
        empleado = New Empleado
        Try
            gridmaestroEmpleadosDIPRES.DataSource = empleado.recuperaMaestroEmpleadoDipres(luePeriodo.EditValue, txtMesInicial.EditValue, txtMesFinal.EditValue, chkSoloEmpleadosActivos.Checked)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al leer datos cargas familiares." & Chr(13) & "ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Cursor = Cursors.Default
        'recuperaMaestroEmpleadoDipres
        'Dim conn As SqlClient.SqlConnection = GetConn()
        'conn.ConnectionString = Argo.Comun.ArgoConfiguracion.ConnectionString
        'conn.Open()
        'SqlDataAdapter1.SelectCommand = New SqlClient.SqlCommand(Argo.Comun.SQL.VISTAS.SELECT_MAESTRO_EMPLEADOS_DIPRES)
        'SqlDataAdapter1.SelectCommand.Connection = conn
        'Try
        '    SqlDataAdapter1.Fill(DsMaestroEmpleadosDIPRES1)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        '    Me.Close()
        'End Try
        'gridmaestroEmpleadosDIPRES.Refresh()
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
            With SaveFileDialog1
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = SaveFileDialog1.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                gridmaestroEmpleadosDIPRES.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnGenerar_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerar.Click
        If luePeriodo.EditValue <> Nothing Then
            If ValidaMeses() Then
                If MsgBoxResult.Yes = MessageBox.Show("El siguiente informe podría tardar varios minutos, ¿desea continuar?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                    Cursor = Cursors.AppStarting
                    RefrescaDetalle()
                    Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub
End Class
