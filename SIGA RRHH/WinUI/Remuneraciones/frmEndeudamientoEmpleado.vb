Imports cl.presidencia.Argo.Reportes
Imports cl.presidencia.Argo.BusinessRules
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns

Public Class frmEndeudamientoEmpleado
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
    Friend WithEvents gpcSeleccionEmpleado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkTodosLosEmpleados As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents gleRut As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gpcBotones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExoportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pgcDetalleEndeudamiento As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents colEMPLEADO_ID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colNOMBRE_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDESCRIPCION_ITEM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colITEM_ALIAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_ITEM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_LEGAL_ENDEUDAMIENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colPORCENTAJE_ENDEUDAMIENTO_LEGAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colPORCENTAJE_ENDEUDAMIENTO_ACTUAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colPERIODO_ANALISIS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents gdcEmpleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvEmpleados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APELLIDO_PATERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APELLIDO_MATERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOMBRES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtNombreEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colTIPO_ITEM_ENDEUDAMIENTO_ID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents txtPorcentajeEndeu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFiltroPor As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents colMONTO_DISPONIBLE_PARA_ENDEUDAMIENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colANO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents clbPeriodo As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents colMONTO_LEGAL_ENDEUDAMIENTO_25P As DevExpress.XtraPivotGrid.PivotGridField
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpcSeleccionEmpleado = New DevExpress.XtraEditors.GroupControl
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.lblFiltroPor = New System.Windows.Forms.Label
        Me.txtPorcentajeEndeu = New DevExpress.XtraEditors.TextEdit
        Me.chkTodosLosEmpleados = New DevExpress.XtraEditors.CheckEdit
        Me.gleRut = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.lblEmpleado = New System.Windows.Forms.Label
        Me.txtNombreEmpleado = New DevExpress.XtraEditors.TextEdit
        Me.clbPeriodo = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.gpcBotones = New DevExpress.XtraEditors.GroupControl
        Me.btnExoportar = New DevExpress.XtraEditors.SimpleButton
        Me.btnGenerar = New DevExpress.XtraEditors.SimpleButton
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton
        Me.pgcDetalleEndeudamiento = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.colEMPLEADO_ID = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colNOMBRE_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colRUT = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colDV = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colDESCRIPCION_ITEM = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colITEM_ALIAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_ITEM = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_LEGAL_ENDEUDAMIENTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_LEGAL_ENDEUDAMIENTO_25P = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colPORCENTAJE_ENDEUDAMIENTO_LEGAL = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colPORCENTAJE_ENDEUDAMIENTO_ACTUAL = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMONTO_DISPONIBLE_PARA_ENDEUDAMIENTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colPERIODO_ANALISIS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colTIPO_ITEM_ENDEUDAMIENTO_ID = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colANO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colMES = New DevExpress.XtraPivotGrid.PivotGridField
        Me.gdcEmpleados = New DevExpress.XtraGrid.GridControl
        Me.gdvEmpleados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.EMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.APELLIDO_PATERNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.APELLIDO_MATERNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NOMBRES = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.gpcSeleccionEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionEmpleado.SuspendLayout()
        CType(Me.txtPorcentajeEndeu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTodosLosEmpleados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clbPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBotones.SuspendLayout()
        CType(Me.pgcDetalleEndeudamiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcSeleccionEmpleado
        '
        Me.gpcSeleccionEmpleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionEmpleado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionEmpleado.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionEmpleado.Controls.Add(Me.lblPeriodo)
        Me.gpcSeleccionEmpleado.Controls.Add(Me.lblFiltroPor)
        Me.gpcSeleccionEmpleado.Controls.Add(Me.txtPorcentajeEndeu)
        Me.gpcSeleccionEmpleado.Controls.Add(Me.chkTodosLosEmpleados)
        Me.gpcSeleccionEmpleado.Controls.Add(Me.gleRut)
        Me.gpcSeleccionEmpleado.Controls.Add(Me.lblEmpleado)
        Me.gpcSeleccionEmpleado.Controls.Add(Me.txtNombreEmpleado)
        Me.gpcSeleccionEmpleado.Controls.Add(Me.clbPeriodo)
        Me.gpcSeleccionEmpleado.Location = New System.Drawing.Point(0, 0)
        Me.gpcSeleccionEmpleado.Name = "gpcSeleccionEmpleado"
        Me.gpcSeleccionEmpleado.Size = New System.Drawing.Size(864, 112)
        Me.gpcSeleccionEmpleado.TabIndex = 21
        Me.gpcSeleccionEmpleado.Text = "Selección de Empleado"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(16, 32)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 16)
        Me.lblPeriodo.TabIndex = 25
        Me.lblPeriodo.Text = "Periodo"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFiltroPor
        '
        Me.lblFiltroPor.Location = New System.Drawing.Point(384, 24)
        Me.lblFiltroPor.Name = "lblFiltroPor"
        Me.lblFiltroPor.Size = New System.Drawing.Size(152, 16)
        Me.lblFiltroPor.TabIndex = 22
        Me.lblFiltroPor.Text = "Filtro % endeu.mayor igual a"
        Me.lblFiltroPor.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPorcentajeEndeu
        '
        Me.txtPorcentajeEndeu.Location = New System.Drawing.Point(544, 24)
        Me.txtPorcentajeEndeu.Name = "txtPorcentajeEndeu"
        '
        'txtPorcentajeEndeu.Properties
        '
        Me.txtPorcentajeEndeu.Properties.DisplayFormat.FormatString = "n0"
        Me.txtPorcentajeEndeu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorcentajeEndeu.Properties.EditFormat.FormatString = "n0"
        Me.txtPorcentajeEndeu.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorcentajeEndeu.Properties.Mask.EditMask = "n0"
        Me.txtPorcentajeEndeu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPorcentajeEndeu.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPorcentajeEndeu.Properties.MaxLength = 2
        Me.txtPorcentajeEndeu.Size = New System.Drawing.Size(48, 20)
        Me.txtPorcentajeEndeu.TabIndex = 21
        '
        'chkTodosLosEmpleados
        '
        Me.chkTodosLosEmpleados.Location = New System.Drawing.Point(208, 24)
        Me.chkTodosLosEmpleados.Name = "chkTodosLosEmpleados"
        '
        'chkTodosLosEmpleados.Properties
        '
        Me.chkTodosLosEmpleados.Properties.Caption = "Todos los Empleados"
        Me.chkTodosLosEmpleados.Size = New System.Drawing.Size(136, 19)
        Me.chkTodosLosEmpleados.TabIndex = 0
        '
        'gleRut
        '
        Me.gleRut.EnterMoveNextControl = True
        Me.gleRut.Location = New System.Drawing.Point(288, 56)
        Me.gleRut.Name = "gleRut"
        '
        'gleRut.Properties
        '
        Me.gleRut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleRut.Properties.View = Me.GridLookUpEdit1View
        Me.gleRut.Size = New System.Drawing.Size(96, 20)
        Me.gleRut.TabIndex = 18
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'lblEmpleado
        '
        Me.lblEmpleado.Location = New System.Drawing.Point(200, 56)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(80, 16)
        Me.lblEmpleado.TabIndex = 17
        Me.lblEmpleado.Text = "Rut Empleado"
        Me.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreEmpleado.Enabled = False
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(392, 56)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        '
        'txtNombreEmpleado.Properties
        '
        Me.txtNombreEmpleado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNombreEmpleado.Properties.Appearance.Options.UseFont = True
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(224, 20)
        Me.txtNombreEmpleado.TabIndex = 19
        '
        'clbPeriodo
        '
        Me.clbPeriodo.Location = New System.Drawing.Point(72, 32)
        Me.clbPeriodo.Name = "clbPeriodo"
        Me.clbPeriodo.Size = New System.Drawing.Size(96, 72)
        Me.clbPeriodo.TabIndex = 27
        '
        'gpcBotones
        '
        Me.gpcBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcBotones.Controls.Add(Me.btnExoportar)
        Me.gpcBotones.Controls.Add(Me.btnGenerar)
        Me.gpcBotones.Controls.Add(Me.btnVisualizar)
        Me.gpcBotones.Location = New System.Drawing.Point(0, 112)
        Me.gpcBotones.Name = "gpcBotones"
        Me.gpcBotones.ShowCaption = False
        Me.gpcBotones.Size = New System.Drawing.Size(864, 40)
        Me.gpcBotones.TabIndex = 22
        Me.gpcBotones.Text = "GroupControl1"
        '
        'btnExoportar
        '
        Me.btnExoportar.Location = New System.Drawing.Point(416, 8)
        Me.btnExoportar.Name = "btnExoportar"
        Me.btnExoportar.Size = New System.Drawing.Size(112, 23)
        Me.btnExoportar.TabIndex = 24
        Me.btnExoportar.Text = "Exportar"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(128, 8)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(112, 23)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "&Generar"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(272, 8)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(112, 23)
        Me.btnVisualizar.TabIndex = 23
        Me.btnVisualizar.Text = "&Visualizar"
        '
        'pgcDetalleEndeudamiento
        '
        Me.pgcDetalleEndeudamiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgcDetalleEndeudamiento.Cursor = System.Windows.Forms.Cursors.Default
        Me.pgcDetalleEndeudamiento.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.colEMPLEADO_ID, Me.colNOMBRE_EMPLEADO, Me.colRUT, Me.colDV, Me.colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO, Me.colDESCRIPCION_ITEM, Me.colITEM_ALIAS, Me.colMONTO_ITEM, Me.colMONTO_LEGAL_ENDEUDAMIENTO, Me.colMONTO_LEGAL_ENDEUDAMIENTO_25P, Me.colPORCENTAJE_ENDEUDAMIENTO_LEGAL, Me.colPORCENTAJE_ENDEUDAMIENTO_ACTUAL, Me.colMONTO_DISPONIBLE_PARA_ENDEUDAMIENTO, Me.colPERIODO_ANALISIS, Me.colTIPO_ITEM_ENDEUDAMIENTO_ID, Me.colANO, Me.colMES})
        Me.pgcDetalleEndeudamiento.Location = New System.Drawing.Point(0, 152)
        Me.pgcDetalleEndeudamiento.Name = "pgcDetalleEndeudamiento"
        Me.pgcDetalleEndeudamiento.Size = New System.Drawing.Size(864, 224)
        Me.pgcDetalleEndeudamiento.TabIndex = 23
        '
        'colEMPLEADO_ID
        '
        Me.colEMPLEADO_ID.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colEMPLEADO_ID.AreaIndex = 2
        Me.colEMPLEADO_ID.Caption = "Id Empleado"
        Me.colEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.colEMPLEADO_ID.Name = "colEMPLEADO_ID"
        '
        'colNOMBRE_EMPLEADO
        '
        Me.colNOMBRE_EMPLEADO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colNOMBRE_EMPLEADO.AreaIndex = 2
        Me.colNOMBRE_EMPLEADO.Caption = "Nombre Empleado"
        Me.colNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.colNOMBRE_EMPLEADO.Name = "colNOMBRE_EMPLEADO"
        Me.colNOMBRE_EMPLEADO.Width = 250
        '
        'colRUT
        '
        Me.colRUT.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colRUT.AreaIndex = 0
        Me.colRUT.Caption = "Rut"
        Me.colRUT.FieldName = "RUT"
        Me.colRUT.Name = "colRUT"
        '
        'colDV
        '
        Me.colDV.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colDV.AreaIndex = 1
        Me.colDV.Caption = "Dv"
        Me.colDV.FieldName = "DV"
        Me.colDV.Name = "colDV"
        '
        'colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO
        '
        Me.colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO.AreaIndex = 4
        Me.colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO.Caption = "Tipo Item Endeudamiento"
        Me.colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO.FieldName = "DESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO"
        Me.colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO.Name = "colDESCRIPCION_TIPO_ITEM_ENDEUDAMIENTO"
        '
        'colDESCRIPCION_ITEM
        '
        Me.colDESCRIPCION_ITEM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colDESCRIPCION_ITEM.AreaIndex = 5
        Me.colDESCRIPCION_ITEM.Caption = "Descripción Item"
        Me.colDESCRIPCION_ITEM.FieldName = "DESCRIPCION_ITEM"
        Me.colDESCRIPCION_ITEM.Name = "colDESCRIPCION_ITEM"
        Me.colDESCRIPCION_ITEM.Width = 250
        '
        'colITEM_ALIAS
        '
        Me.colITEM_ALIAS.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colITEM_ALIAS.AreaIndex = 6
        Me.colITEM_ALIAS.Caption = "Código Item"
        Me.colITEM_ALIAS.FieldName = "ITEM_ALIAS"
        Me.colITEM_ALIAS.Name = "colITEM_ALIAS"
        '
        'colMONTO_ITEM
        '
        Me.colMONTO_ITEM.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colMONTO_ITEM.AreaIndex = 0
        Me.colMONTO_ITEM.Caption = "Monto Item"
        Me.colMONTO_ITEM.CellFormat.FormatString = "n0"
        Me.colMONTO_ITEM.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_ITEM.FieldName = "MONTO_ITEM"
        Me.colMONTO_ITEM.Name = "colMONTO_ITEM"
        '
        'colMONTO_LEGAL_ENDEUDAMIENTO
        '
        Me.colMONTO_LEGAL_ENDEUDAMIENTO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colMONTO_LEGAL_ENDEUDAMIENTO.AreaIndex = 7
        Me.colMONTO_LEGAL_ENDEUDAMIENTO.Caption = "15% Monto Legal Endeud."
        Me.colMONTO_LEGAL_ENDEUDAMIENTO.CellFormat.FormatString = "n0"
        Me.colMONTO_LEGAL_ENDEUDAMIENTO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_LEGAL_ENDEUDAMIENTO.FieldName = "MONTO_LEGAL_ENDEUDAMIENTO"
        Me.colMONTO_LEGAL_ENDEUDAMIENTO.Name = "colMONTO_LEGAL_ENDEUDAMIENTO"
        Me.colMONTO_LEGAL_ENDEUDAMIENTO.ValueFormat.FormatString = "n0"
        Me.colMONTO_LEGAL_ENDEUDAMIENTO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'colMONTO_LEGAL_ENDEUDAMIENTO_25P
        '
        Me.colMONTO_LEGAL_ENDEUDAMIENTO_25P.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colMONTO_LEGAL_ENDEUDAMIENTO_25P.AreaIndex = 8
        Me.colMONTO_LEGAL_ENDEUDAMIENTO_25P.Caption = "25% Monto Legal Endeud."
        Me.colMONTO_LEGAL_ENDEUDAMIENTO_25P.CellFormat.FormatString = "n0"
        Me.colMONTO_LEGAL_ENDEUDAMIENTO_25P.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_LEGAL_ENDEUDAMIENTO_25P.FieldName = "MONTO_LEGAL_ENDEUDAMIENTO_25P"
        Me.colMONTO_LEGAL_ENDEUDAMIENTO_25P.Name = "colMONTO_LEGAL_ENDEUDAMIENTO_25P"
        Me.colMONTO_LEGAL_ENDEUDAMIENTO_25P.ValueFormat.FormatString = "n0"
        Me.colMONTO_LEGAL_ENDEUDAMIENTO_25P.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'colPORCENTAJE_ENDEUDAMIENTO_LEGAL
        '
        Me.colPORCENTAJE_ENDEUDAMIENTO_LEGAL.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colPORCENTAJE_ENDEUDAMIENTO_LEGAL.AreaIndex = 3
        Me.colPORCENTAJE_ENDEUDAMIENTO_LEGAL.Caption = "%Legal Endeud."
        Me.colPORCENTAJE_ENDEUDAMIENTO_LEGAL.CellFormat.FormatString = "n2"
        Me.colPORCENTAJE_ENDEUDAMIENTO_LEGAL.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPORCENTAJE_ENDEUDAMIENTO_LEGAL.FieldName = "PORCENTAJE_ENDEUDAMIENTO_LEGAL"
        Me.colPORCENTAJE_ENDEUDAMIENTO_LEGAL.Name = "colPORCENTAJE_ENDEUDAMIENTO_LEGAL"
        Me.colPORCENTAJE_ENDEUDAMIENTO_LEGAL.ValueFormat.FormatString = "n2"
        Me.colPORCENTAJE_ENDEUDAMIENTO_LEGAL.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'colPORCENTAJE_ENDEUDAMIENTO_ACTUAL
        '
        Me.colPORCENTAJE_ENDEUDAMIENTO_ACTUAL.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colPORCENTAJE_ENDEUDAMIENTO_ACTUAL.AreaIndex = 9
        Me.colPORCENTAJE_ENDEUDAMIENTO_ACTUAL.Caption = "%Endeud.Actual"
        Me.colPORCENTAJE_ENDEUDAMIENTO_ACTUAL.CellFormat.FormatString = "n2"
        Me.colPORCENTAJE_ENDEUDAMIENTO_ACTUAL.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPORCENTAJE_ENDEUDAMIENTO_ACTUAL.FieldName = "PORCENTAJE_ENDEUDAMIENTO_ACTUAL"
        Me.colPORCENTAJE_ENDEUDAMIENTO_ACTUAL.Name = "colPORCENTAJE_ENDEUDAMIENTO_ACTUAL"
        Me.colPORCENTAJE_ENDEUDAMIENTO_ACTUAL.ValueFormat.FormatString = "n0"
        Me.colPORCENTAJE_ENDEUDAMIENTO_ACTUAL.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'colMONTO_DISPONIBLE_PARA_ENDEUDAMIENTO
        '
        Me.colMONTO_DISPONIBLE_PARA_ENDEUDAMIENTO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colMONTO_DISPONIBLE_PARA_ENDEUDAMIENTO.AreaIndex = 10
        Me.colMONTO_DISPONIBLE_PARA_ENDEUDAMIENTO.Caption = "Monto Disp.Endeud."
        Me.colMONTO_DISPONIBLE_PARA_ENDEUDAMIENTO.CellFormat.FormatString = "n0"
        Me.colMONTO_DISPONIBLE_PARA_ENDEUDAMIENTO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO_DISPONIBLE_PARA_ENDEUDAMIENTO.FieldName = "MONTO_DISPONIBLE_PARA_ENDEUDAMIENTO"
        Me.colMONTO_DISPONIBLE_PARA_ENDEUDAMIENTO.Name = "colMONTO_DISPONIBLE_PARA_ENDEUDAMIENTO"
        Me.colMONTO_DISPONIBLE_PARA_ENDEUDAMIENTO.ValueFormat.FormatString = "n0"
        Me.colMONTO_DISPONIBLE_PARA_ENDEUDAMIENTO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'colPERIODO_ANALISIS
        '
        Me.colPERIODO_ANALISIS.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colPERIODO_ANALISIS.AreaIndex = 4
        Me.colPERIODO_ANALISIS.Caption = "Período Análisis"
        Me.colPERIODO_ANALISIS.FieldName = "PERIODO_ANALISIS"
        Me.colPERIODO_ANALISIS.Name = "colPERIODO_ANALISIS"
        '
        'colTIPO_ITEM_ENDEUDAMIENTO_ID
        '
        Me.colTIPO_ITEM_ENDEUDAMIENTO_ID.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colTIPO_ITEM_ENDEUDAMIENTO_ID.AreaIndex = 3
        Me.colTIPO_ITEM_ENDEUDAMIENTO_ID.Caption = "Código Tipo Endeu."
        Me.colTIPO_ITEM_ENDEUDAMIENTO_ID.FieldName = "TIPO_ITEM_ENDEUDAMIENTO_ID"
        Me.colTIPO_ITEM_ENDEUDAMIENTO_ID.Name = "colTIPO_ITEM_ENDEUDAMIENTO_ID"
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
        'gdcEmpleados
        '
        Me.gdcEmpleados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'gdcEmpleados.EmbeddedNavigator
        '
        Me.gdcEmpleados.EmbeddedNavigator.Name = ""
        Me.gdcEmpleados.Location = New System.Drawing.Point(616, 64)
        Me.gdcEmpleados.MainView = Me.gdvEmpleados
        Me.gdcEmpleados.Name = "gdcEmpleados"
        Me.gdcEmpleados.Size = New System.Drawing.Size(232, 72)
        Me.gdcEmpleados.TabIndex = 24
        Me.gdcEmpleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvEmpleados, Me.GridView1})
        '
        'gdvEmpleados
        '
        Me.gdvEmpleados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.EMPLEADO_ID, Me.APELLIDO_PATERNO, Me.APELLIDO_MATERNO, Me.NOMBRES})
        Me.gdvEmpleados.GridControl = Me.gdcEmpleados
        Me.gdvEmpleados.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvEmpleados.Name = "gdvEmpleados"
        Me.gdvEmpleados.OptionsNavigation.EnterMoveNextColumn = True
        Me.gdvEmpleados.OptionsSelection.InvertSelection = True
        Me.gdvEmpleados.OptionsSelection.MultiSelect = True
        Me.gdvEmpleados.OptionsView.ColumnAutoWidth = False
        Me.gdvEmpleados.OptionsView.ShowGroupPanel = False
        Me.gdvEmpleados.SynchronizeClones = False
        '
        'EMPLEADO_ID
        '
        Me.EMPLEADO_ID.Caption = "ID Empleado"
        Me.EMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.EMPLEADO_ID.Name = "EMPLEADO_ID"
        Me.EMPLEADO_ID.OptionsColumn.ReadOnly = True
        '
        'APELLIDO_PATERNO
        '
        Me.APELLIDO_PATERNO.Caption = "Apellido Paterno"
        Me.APELLIDO_PATERNO.FieldName = "APELLIDO_PATERNO"
        Me.APELLIDO_PATERNO.Name = "APELLIDO_PATERNO"
        Me.APELLIDO_PATERNO.OptionsColumn.ReadOnly = True
        Me.APELLIDO_PATERNO.Visible = True
        Me.APELLIDO_PATERNO.VisibleIndex = 0
        Me.APELLIDO_PATERNO.Width = 159
        '
        'APELLIDO_MATERNO
        '
        Me.APELLIDO_MATERNO.Caption = "Apellido Materno"
        Me.APELLIDO_MATERNO.FieldName = "APELLIDO_MATERNO"
        Me.APELLIDO_MATERNO.Name = "APELLIDO_MATERNO"
        Me.APELLIDO_MATERNO.OptionsColumn.ReadOnly = True
        Me.APELLIDO_MATERNO.Visible = True
        Me.APELLIDO_MATERNO.VisibleIndex = 1
        Me.APELLIDO_MATERNO.Width = 143
        '
        'NOMBRES
        '
        Me.NOMBRES.Caption = "Nombre"
        Me.NOMBRES.FieldName = "NOMBRES"
        Me.NOMBRES.Name = "NOMBRES"
        Me.NOMBRES.Visible = True
        Me.NOMBRES.VisibleIndex = 2
        Me.NOMBRES.Width = 190
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcEmpleados
        Me.GridView1.Name = "GridView1"
        '
        'frmEndeudamientoEmpleado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(872, 378)
        Me.Controls.Add(Me.gdcEmpleados)
        Me.Controls.Add(Me.pgcDetalleEndeudamiento)
        Me.Controls.Add(Me.gpcBotones)
        Me.Controls.Add(Me.gpcSeleccionEmpleado)
        Me.Name = "frmEndeudamientoEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEndeudamientoEmpleado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcSeleccionEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionEmpleado.ResumeLayout(False)
        CType(Me.txtPorcentajeEndeu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTodosLosEmpleados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clbPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBotones.ResumeLayout(False)
        CType(Me.pgcDetalleEndeudamiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private empleado As New empleado
    Private PeriodoVigente As New Periodo
    'Private PeriodoAnterior As Periodo
    'Private PeriodoId As Integer
    Private PeriodoAnalisis As String = ""

    Private Sub frmEndeudamientoEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empleado = New empleado
        activarControlesEmpleado()
        llenarEmpleado()
        llenarPeriodos()
        Dim fechaFinalIngreso As Date
        Dim diasMes As Integer = fechaFinalIngreso.DaysInMonth(PeriodoVigente.ano, PeriodoVigente.mes)
        fechaFinalIngreso = New Date(CInt(PeriodoVigente.ano), PeriodoVigente.mes, diasMes)
        gdcEmpleados.DataSource = empleado.recuperaMaestroEmpleado(fechaFinalIngreso, PeriodoVigente.ID)
        gdcEmpleados.Visible = False
        Me.pgcDetalleEndeudamiento.DataSource = Nothing
        Me.txtPorcentajeEndeu.EditValue = 0
        gleRut.EditValue = -1
        If pgcDetalleEndeudamiento.DataSource = Nothing Then
            Me.btnVisualizar.Enabled = False
            Me.btnExoportar.Enabled = False
        End If
    End Sub

    Public Sub llenarEmpleado()
        gleRut.Properties.EditValueChangedFiringDelay = 1200
        gleRut.Properties.EditValueChangedFiringMode = EditValueChangedFiringMode.Buffered
        'Dos segundos se espera antes de gatillar la búsqueda (EditValueChanged)

        gleRut.Properties.ViewType = Repository.GridLookUpViewType.GridView
        gleRut.Properties.View.OptionsBehavior.AutoPopulateColumns = False
        gleRut.Properties.DataSource = repositorio.dvEmpleadosPlantaContrataActivosInactivos
        gleRut.Properties.DisplayMember = "RUT"

        Dim col1 As GridColumn = gleRut.Properties.View.Columns.AddField("RUT")
        col1.VisibleIndex = 0
        col1.Caption = "RUT"

        Dim col2 As GridColumn = gleRut.Properties.View.Columns.AddField("APELLIDO_PATERNO")
        col2.VisibleIndex = 1
        col2.Caption = "Apellido Paterno"

        Dim col3 As GridColumn = gleRut.Properties.View.Columns.AddField("APELLIDO_MATERNO")
        col3.VisibleIndex = 2
        col3.Caption = "Apellido Materno"

        Dim col4 As GridColumn = gleRut.Properties.View.Columns.AddField("NOMBRES")
        col4.VisibleIndex = 3
        col4.Caption = "Nombres"

        Dim col5 As GridColumn = gleRut.Properties.View.Columns.AddField("DESC_CALIDAD_JURIDICA")
        col5.VisibleIndex = 5
        col5.Caption = "Calidad Jurídica"
        col5.Visible = True

        Dim col6 As GridColumn = gleRut.Properties.View.Columns.AddField("DESC_ESTADO")
        col6.VisibleIndex = 4
        col6.Caption = "Estado"

        Dim col7 As GridColumn = gleRut.Properties.View.Columns.AddField("NOMBRE_COMPLETO")
        col7.VisibleIndex = 6
        col7.Caption = "Nombre Completo"
        col7.Visible = False

        gleRut.Properties.ValueMember = "EMPLEADO_ID"

        gleRut.Properties.View.BestFitColumns()
        gleRut.Properties.PopupFormWidth = 600

        gleRut.Text = ""
    End Sub

    Private Sub llenarPeriodos()
        Me.clbPeriodo.DataSource = repositorio.dvPeriodo
        Me.clbPeriodo.DisplayMember = "DESCRIPCION_PERIODO"
        Me.clbPeriodo.ValueMember = "PERIODO_ID"
    End Sub

    Private Sub gleRut_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gleRut.EditValueChanged
        If Me.gleRut.EditValue = Nothing Then
            Exit Sub
        End If
        If Me.gleRut.EditValue <= 0 Then
            Exit Sub
        End If
        Cursor.Current = Cursors.WaitCursor
        If IsNumeric(gleRut.EditValue) Then
            Me.pgcDetalleEndeudamiento.DataSource = Nothing
            empleado = New empleado(CType(gleRut.EditValue, Long))
            txtNombreEmpleado.Text = empleado.nombreCompleto
            If pgcDetalleEndeudamiento.DataSource = Nothing Then
                Me.btnVisualizar.Enabled = False
                Me.btnExoportar.Enabled = False
            End If
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub activarControlesEmpleado()
        If chkTodosLosEmpleados.Checked Then
            lblEmpleado.Visible = False
            gleRut.Visible = False
            txtNombreEmpleado.Visible = False
        Else
            lblEmpleado.Visible = True
            gleRut.Visible = True
            txtNombreEmpleado.Visible = True
        End If
    End Sub

    Private Sub chkTodosLosEmpleados_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTodosLosEmpleados.CheckedChanged
        activarControlesEmpleado()
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Dim j As Integer = 0
        PeriodoAnalisis = ""
        If Me.chkTodosLosEmpleados.Checked Then
            For i As Integer = 0 To clbPeriodo.ItemCount - 1
                Dim Chequeado As Boolean = Me.clbPeriodo.GetItemCheckState(i)
                If Chequeado Then
                    Dim PeriodoId As Integer = Me.clbPeriodo.GetItemValue(i)
                    GenereTodosLosEmpleados(PeriodoId)
                    PeriodoAnalisis = PeriodoAnalisis + IIf(j = 1, ",", "") + PeriodoId.ToString
                    j = 1
                End If
            Next
            llenarPivot(0)
        Else
            If Me.gleRut.EditValue <= 0 Then
                Me.gleRut.ErrorText = "Debe ingressar un rut o escojer un empleado de la lista"
            Else
                Me.gleRut.ErrorText = ""
                For i As Integer = 0 To clbPeriodo.ItemCount - 1
                    Dim Chequeado As Boolean = Me.clbPeriodo.GetItemCheckState(i)
                    If Chequeado Then
                        Dim PeriodoId As Integer = Me.clbPeriodo.GetItemValue(i)
                        GeneraUnEmpleado(PeriodoId)
                        PeriodoAnalisis = PeriodoAnalisis + IIf(j = 1, ",", "") + PeriodoId.ToString
                        j = 1
                    End If
                Next
                llenarPivot(Me.gleRut.EditValue)
            End If
        End If
        If Not pgcDetalleEndeudamiento.DataSource Is Nothing Then
            Me.btnVisualizar.Enabled = True
            Me.btnExoportar.Enabled = True
        Else
            Me.btnVisualizar.Enabled = False
            Me.btnExoportar.Enabled = False
        End If
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        Cursor.Current = Cursors.WaitCursor
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptEndeudamientoEmpleado
        Dim strFormulaSeleccion As String = "{VW_EMPLEADOS_ENDEUDAMIENTO.PORCENTAJE_ENDEUDAMIENTO_ACTUAL}>=" & Me.txtPorcentajeEndeu.EditValue.ToString & " AND "
        Dim cmdPeriodo As String = ""
        'If Me.chkVerSoloPeriodoSeleccionado.Checked Then
        'cmdPeriodo = " AND {VW_EMPLEADOS_ENDEUDAMIENTO.PERIODO_ID} IN " & "(" & Trim(PeriodoAnalisis) & ")"
        'End If
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        If chkTodosLosEmpleados.Checked = True Then
            strFormulaSeleccion = strFormulaSeleccion & "{VW_EMPLEADOS_ENDEUDAMIENTO.PERIODO_ID} IN " & "[" & Trim(PeriodoAnalisis) & "]"
        Else
            strFormulaSeleccion = strFormulaSeleccion & "{VW_EMPLEADOS_ENDEUDAMIENTO.EMPLEADO_ID}=" & CType(Me.gleRut.EditValue, String) & " AND {VW_EMPLEADOS_ENDEUDAMIENTO.PERIODO_ID} IN " & "[" & Trim(PeriodoAnalisis) & "]"
        End If
        ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
        ventanaReporte1.rptVisor.ShowParameterPanelButton = False
        ventanaReporte1.rptVisor.ShowCloseButton = False
        ventanaReporte1.rptVisor.ShowGroupTreeButton = False
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnExoportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExoportar.Click
        Dim rutaPlanillaExcel As String
        Try
            With SaveFileDialog1
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = SaveFileDialog1.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                Me.pgcDetalleEndeudamiento.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False
                Me.pgcDetalleEndeudamiento.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.False
                Me.pgcDetalleEndeudamiento.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GenereTodosLosEmpleados(ByVal PeriodoId As Integer)
        Cursor.Current = Cursors.WaitCursor
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvEmpleados
        For i As Integer = 0 To gdvEmpleados.RowCount - 1
            Dim EmpleadoId As Integer = view.GetRowCellValue(i, view.Columns("EMPLEADO_ID"))
            empleado.CalcularEndeudamientoEmpleado(EmpleadoId, PeriodoId)
        Next
        'llenarPivot(0)
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub GeneraUnEmpleado(ByVal PeriodoId As Integer)
        empleado.CalcularEndeudamientoEmpleado(Me.gleRut.EditValue, PeriodoId)
        'llenarPivot(Me.gleRut.EditValue)
    End Sub

    Private Sub llenarPivot(ByVal EmpleadoId As Integer)
        Me.pgcDetalleEndeudamiento.DataSource = empleado.recuperaEndeudamientoEmpleado(EmpleadoId, PeriodoAnalisis, Me.txtPorcentajeEndeu.EditValue)
    End Sub

End Class
