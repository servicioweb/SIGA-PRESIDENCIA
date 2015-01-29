Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmReajusteEUS
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
    Friend WithEvents lblAno As System.Windows.Forms.Label
    Friend WithEvents dvPeriodo As System.Data.DataView
    Friend WithEvents gpcPeriodo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblPorcentajeReajuste As System.Windows.Forms.Label
    Friend WithEvents txtPorcentajeReajuste As DevExpress.XtraEditors.TextEdit
    Friend WithEvents fieldCALIDAD_JURIDICA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGRADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCLASIFICACION_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSUELDO_BASE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pgcReajusteEUS As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldSUELDO_BASE_NEW As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldASIG_RESPONSABILIDAD_SUPERIOR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldASIG_RESPONSABILIDAD_SUPERIOR_NEW As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldASIG_PROFESIONAL_LEY19185_ART19 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldASIG_PROFESIONAL_LEY19185_ART19_NEW As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents brnRevisionReajusteEUS As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents fieldASIG_LEY19185_ART18 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldASIG_LEY19185_ART18_NEW As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldASIG_LEY18717_CON_ASIG_PROFESIONAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldASIG_LEY18717_CON_ASIG_PROFESIONAL_NEW As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL_NEW As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBONO_LEY18675_ART10 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBONO_LEY18675_ART10_NEW As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBONO_LEY18675_ART11 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBONO_LEY18675_ART11_NEW As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBONO_LEY18566 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBONO_LEY18566_NEW As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldASIG_LEY3551 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldASIG_LEY3551_NEW As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGASTO_REPRESENTACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGASTO_REPRESENTACION_NEW As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents sfdReajusteEUS As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtPeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnPeriodoAnteriores As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpcPeriodo = New DevExpress.XtraEditors.GroupControl
        Me.btnPeriodoAnteriores = New DevExpress.XtraEditors.SimpleButton
        Me.txtPeriodo = New DevExpress.XtraEditors.TextEdit
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton
        Me.brnRevisionReajusteEUS = New DevExpress.XtraEditors.SimpleButton
        Me.lblPorcentajeReajuste = New System.Windows.Forms.Label
        Me.txtPorcentajeReajuste = New DevExpress.XtraEditors.TextEdit
        Me.lblAno = New System.Windows.Forms.Label
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.dvPeriodo = New System.Data.DataView
        Me.pgcReajusteEUS = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.fieldCALIDAD_JURIDICA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldGRADO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCLASIFICACION_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSUELDO_BASE = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSUELDO_BASE_NEW = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldASIG_PROFESIONAL_LEY19185_ART19 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldASIG_PROFESIONAL_LEY19185_ART19_NEW = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldASIG_RESPONSABILIDAD_SUPERIOR = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldASIG_RESPONSABILIDAD_SUPERIOR_NEW = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldASIG_LEY19185_ART18 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldASIG_LEY19185_ART18_NEW = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldASIG_LEY18717_CON_ASIG_PROFESIONAL = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldASIG_LEY18717_CON_ASIG_PROFESIONAL_NEW = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL_NEW = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBONO_LEY18675_ART10 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBONO_LEY18675_ART10_NEW = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBONO_LEY18675_ART11 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBONO_LEY18675_ART11_NEW = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBONO_LEY18566 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBONO_LEY18566_NEW = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldASIG_LEY3551 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldASIG_LEY3551_NEW = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldGASTO_REPRESENTACION = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldGASTO_REPRESENTACION_NEW = New DevExpress.XtraPivotGrid.PivotGridField
        Me.sfdReajusteEUS = New System.Windows.Forms.SaveFileDialog
        CType(Me.gpcPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcPeriodo.SuspendLayout()
        CType(Me.txtPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentajeReajuste.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgcReajusteEUS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcPeriodo
        '
        Me.gpcPeriodo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcPeriodo.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcPeriodo.AppearanceCaption.Options.UseFont = True
        Me.gpcPeriodo.Controls.Add(Me.btnPeriodoAnteriores)
        Me.gpcPeriodo.Controls.Add(Me.txtPeriodo)
        Me.gpcPeriodo.Controls.Add(Me.btnExcel)
        Me.gpcPeriodo.Controls.Add(Me.brnRevisionReajusteEUS)
        Me.gpcPeriodo.Controls.Add(Me.lblPorcentajeReajuste)
        Me.gpcPeriodo.Controls.Add(Me.txtPorcentajeReajuste)
        Me.gpcPeriodo.Controls.Add(Me.lblAno)
        Me.gpcPeriodo.Controls.Add(Me.luePeriodo)
        Me.gpcPeriodo.Location = New System.Drawing.Point(8, 8)
        Me.gpcPeriodo.Name = "gpcPeriodo"
        Me.gpcPeriodo.Size = New System.Drawing.Size(856, 104)
        Me.gpcPeriodo.TabIndex = 4
        Me.gpcPeriodo.Text = "Periodo"
        '
        'btnPeriodoAnteriores
        '
        Me.btnPeriodoAnteriores.Location = New System.Drawing.Point(448, 32)
        Me.btnPeriodoAnteriores.Name = "btnPeriodoAnteriores"
        Me.btnPeriodoAnteriores.Size = New System.Drawing.Size(104, 23)
        Me.btnPeriodoAnteriores.TabIndex = 4
        Me.btnPeriodoAnteriores.Text = "Periodos Anteriores"
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Location = New System.Drawing.Point(136, 32)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.TabIndex = 8
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(688, 32)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(104, 23)
        Me.btnExcel.TabIndex = 6
        Me.btnExcel.Text = "Exportar Excel"
        '
        'brnRevisionReajusteEUS
        '
        Me.brnRevisionReajusteEUS.Location = New System.Drawing.Point(568, 32)
        Me.brnRevisionReajusteEUS.Name = "brnRevisionReajusteEUS"
        Me.brnRevisionReajusteEUS.Size = New System.Drawing.Size(104, 23)
        Me.brnRevisionReajusteEUS.TabIndex = 5
        Me.brnRevisionReajusteEUS.Text = "Revisión Reajuste"
        '
        'lblPorcentajeReajuste
        '
        Me.lblPorcentajeReajuste.Location = New System.Drawing.Point(16, 68)
        Me.lblPorcentajeReajuste.Name = "lblPorcentajeReajuste"
        Me.lblPorcentajeReajuste.Size = New System.Drawing.Size(112, 16)
        Me.lblPorcentajeReajuste.TabIndex = 7
        Me.lblPorcentajeReajuste.Text = "Porcentaje Reajuste"
        Me.lblPorcentajeReajuste.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPorcentajeReajuste
        '
        Me.txtPorcentajeReajuste.EnterMoveNextControl = True
        Me.txtPorcentajeReajuste.Location = New System.Drawing.Point(136, 64)
        Me.txtPorcentajeReajuste.Name = "txtPorcentajeReajuste"
        '
        'txtPorcentajeReajuste.Properties
        '
        Me.txtPorcentajeReajuste.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorcentajeReajuste.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorcentajeReajuste.Properties.Mask.EditMask = "n2"
        Me.txtPorcentajeReajuste.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPorcentajeReajuste.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPorcentajeReajuste.Properties.MaxLength = 5
        Me.txtPorcentajeReajuste.TabIndex = 1
        '
        'lblAno
        '
        Me.lblAno.Location = New System.Drawing.Point(80, 36)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(48, 16)
        Me.lblAno.TabIndex = 3
        Me.lblAno.Text = "Año"
        Me.lblAno.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(136, 32)
        Me.luePeriodo.Name = "luePeriodo"
        '
        'luePeriodo.Properties
        '
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.TabIndex = 0
        '
        'pgcReajusteEUS
        '
        Me.pgcReajusteEUS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgcReajusteEUS.Cursor = System.Windows.Forms.Cursors.Default
        Me.pgcReajusteEUS.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCALIDAD_JURIDICA, Me.fieldGRADO, Me.fieldCLASIFICACION_EMPLEADO, Me.fieldSUELDO_BASE, Me.fieldSUELDO_BASE_NEW, Me.fieldASIG_PROFESIONAL_LEY19185_ART19, Me.fieldASIG_PROFESIONAL_LEY19185_ART19_NEW, Me.fieldASIG_RESPONSABILIDAD_SUPERIOR, Me.fieldASIG_RESPONSABILIDAD_SUPERIOR_NEW, Me.fieldASIG_LEY19185_ART18, Me.fieldASIG_LEY19185_ART18_NEW, Me.fieldASIG_LEY18717_CON_ASIG_PROFESIONAL, Me.fieldASIG_LEY18717_CON_ASIG_PROFESIONAL_NEW, Me.fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL, Me.fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL_NEW, Me.fieldBONO_LEY18675_ART10, Me.fieldBONO_LEY18675_ART10_NEW, Me.fieldBONO_LEY18675_ART11, Me.fieldBONO_LEY18675_ART11_NEW, Me.fieldBONO_LEY18566, Me.fieldBONO_LEY18566_NEW, Me.fieldASIG_LEY3551, Me.fieldASIG_LEY3551_NEW, Me.fieldGASTO_REPRESENTACION, Me.fieldGASTO_REPRESENTACION_NEW})
        Me.pgcReajusteEUS.Location = New System.Drawing.Point(8, 112)
        Me.pgcReajusteEUS.Name = "pgcReajusteEUS"
        Me.pgcReajusteEUS.OptionsView.ShowColumnGrandTotals = False
        Me.pgcReajusteEUS.OptionsView.ShowColumnTotals = False
        Me.pgcReajusteEUS.OptionsView.ShowRowGrandTotals = False
        Me.pgcReajusteEUS.OptionsView.ShowRowTotals = False
        Me.pgcReajusteEUS.Size = New System.Drawing.Size(856, 320)
        Me.pgcReajusteEUS.TabIndex = 2
        '
        'fieldCALIDAD_JURIDICA
        '
        Me.fieldCALIDAD_JURIDICA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCALIDAD_JURIDICA.AreaIndex = 0
        Me.fieldCALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.fieldCALIDAD_JURIDICA.FieldName = "CALIDAD_JURIDICA"
        Me.fieldCALIDAD_JURIDICA.Name = "fieldCALIDAD_JURIDICA"
        '
        'fieldGRADO
        '
        Me.fieldGRADO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldGRADO.AreaIndex = 1
        Me.fieldGRADO.Caption = "Grado"
        Me.fieldGRADO.FieldName = "GRADO"
        Me.fieldGRADO.Name = "fieldGRADO"
        '
        'fieldCLASIFICACION_EMPLEADO
        '
        Me.fieldCLASIFICACION_EMPLEADO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCLASIFICACION_EMPLEADO.AreaIndex = 2
        Me.fieldCLASIFICACION_EMPLEADO.Caption = "Clasificación Empleado"
        Me.fieldCLASIFICACION_EMPLEADO.FieldName = "CLASIFICACION_EMPLEADO"
        Me.fieldCLASIFICACION_EMPLEADO.Name = "fieldCLASIFICACION_EMPLEADO"
        '
        'fieldSUELDO_BASE
        '
        Me.fieldSUELDO_BASE.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldSUELDO_BASE.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldSUELDO_BASE.AreaIndex = 0
        Me.fieldSUELDO_BASE.Caption = "Sueldo Base Actual"
        Me.fieldSUELDO_BASE.CellFormat.FormatString = "n0"
        Me.fieldSUELDO_BASE.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldSUELDO_BASE.FieldName = "SUELDO_BASE"
        Me.fieldSUELDO_BASE.Name = "fieldSUELDO_BASE"
        '
        'fieldSUELDO_BASE_NEW
        '
        Me.fieldSUELDO_BASE_NEW.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldSUELDO_BASE_NEW.AreaIndex = 1
        Me.fieldSUELDO_BASE_NEW.Caption = "Sueldo Base Nuevo"
        Me.fieldSUELDO_BASE_NEW.CellFormat.FormatString = "n0"
        Me.fieldSUELDO_BASE_NEW.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldSUELDO_BASE_NEW.FieldName = "SUELDO_BASE_NEW"
        Me.fieldSUELDO_BASE_NEW.Name = "fieldSUELDO_BASE_NEW"
        '
        'fieldASIG_PROFESIONAL_LEY19185_ART19
        '
        Me.fieldASIG_PROFESIONAL_LEY19185_ART19.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldASIG_PROFESIONAL_LEY19185_ART19.AreaIndex = 2
        Me.fieldASIG_PROFESIONAL_LEY19185_ART19.Caption = "Ley 19.185 Art.19 Actual"
        Me.fieldASIG_PROFESIONAL_LEY19185_ART19.CellFormat.FormatString = "n0"
        Me.fieldASIG_PROFESIONAL_LEY19185_ART19.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldASIG_PROFESIONAL_LEY19185_ART19.FieldName = "ASIG_PROFESIONAL_LEY19185_ART19"
        Me.fieldASIG_PROFESIONAL_LEY19185_ART19.Name = "fieldASIG_PROFESIONAL_LEY19185_ART19"
        '
        'fieldASIG_PROFESIONAL_LEY19185_ART19_NEW
        '
        Me.fieldASIG_PROFESIONAL_LEY19185_ART19_NEW.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldASIG_PROFESIONAL_LEY19185_ART19_NEW.AreaIndex = 3
        Me.fieldASIG_PROFESIONAL_LEY19185_ART19_NEW.Caption = "Ley 19.185 Art.19 Nuevo"
        Me.fieldASIG_PROFESIONAL_LEY19185_ART19_NEW.CellFormat.FormatString = "n0"
        Me.fieldASIG_PROFESIONAL_LEY19185_ART19_NEW.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldASIG_PROFESIONAL_LEY19185_ART19_NEW.FieldName = "ASIG_PROFESIONAL_LEY19185_ART19_NEW"
        Me.fieldASIG_PROFESIONAL_LEY19185_ART19_NEW.Name = "fieldASIG_PROFESIONAL_LEY19185_ART19_NEW"
        '
        'fieldASIG_RESPONSABILIDAD_SUPERIOR
        '
        Me.fieldASIG_RESPONSABILIDAD_SUPERIOR.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldASIG_RESPONSABILIDAD_SUPERIOR.AreaIndex = 4
        Me.fieldASIG_RESPONSABILIDAD_SUPERIOR.Caption = "Asig.Respon.Superior Actual"
        Me.fieldASIG_RESPONSABILIDAD_SUPERIOR.CellFormat.FormatString = "n0"
        Me.fieldASIG_RESPONSABILIDAD_SUPERIOR.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldASIG_RESPONSABILIDAD_SUPERIOR.FieldName = "ASIG_RESPONSABILIDAD_SUPERIOR"
        Me.fieldASIG_RESPONSABILIDAD_SUPERIOR.Name = "fieldASIG_RESPONSABILIDAD_SUPERIOR"
        '
        'fieldASIG_RESPONSABILIDAD_SUPERIOR_NEW
        '
        Me.fieldASIG_RESPONSABILIDAD_SUPERIOR_NEW.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldASIG_RESPONSABILIDAD_SUPERIOR_NEW.AreaIndex = 5
        Me.fieldASIG_RESPONSABILIDAD_SUPERIOR_NEW.Caption = "Asig.Respon.Superior Nuevo"
        Me.fieldASIG_RESPONSABILIDAD_SUPERIOR_NEW.CellFormat.FormatString = "n0"
        Me.fieldASIG_RESPONSABILIDAD_SUPERIOR_NEW.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldASIG_RESPONSABILIDAD_SUPERIOR_NEW.FieldName = "ASIG_RESPONSABILIDAD_SUPERIOR_NEW"
        Me.fieldASIG_RESPONSABILIDAD_SUPERIOR_NEW.Name = "fieldASIG_RESPONSABILIDAD_SUPERIOR_NEW"
        '
        'fieldASIG_LEY19185_ART18
        '
        Me.fieldASIG_LEY19185_ART18.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldASIG_LEY19185_ART18.AreaIndex = 6
        Me.fieldASIG_LEY19185_ART18.Caption = "Ley 19.185 Art.18 Actual"
        Me.fieldASIG_LEY19185_ART18.CellFormat.FormatString = "n0"
        Me.fieldASIG_LEY19185_ART18.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldASIG_LEY19185_ART18.FieldName = "ASIG_LEY19185_ART18"
        Me.fieldASIG_LEY19185_ART18.Name = "fieldASIG_LEY19185_ART18"
        '
        'fieldASIG_LEY19185_ART18_NEW
        '
        Me.fieldASIG_LEY19185_ART18_NEW.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldASIG_LEY19185_ART18_NEW.AreaIndex = 7
        Me.fieldASIG_LEY19185_ART18_NEW.Caption = "Ley 19.185 Art.18 Nuevo"
        Me.fieldASIG_LEY19185_ART18_NEW.CellFormat.FormatString = "n0"
        Me.fieldASIG_LEY19185_ART18_NEW.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldASIG_LEY19185_ART18_NEW.FieldName = "ASIG_LEY19185_ART18_NEW"
        Me.fieldASIG_LEY19185_ART18_NEW.Name = "fieldASIG_LEY19185_ART18_NEW"
        '
        'fieldASIG_LEY18717_CON_ASIG_PROFESIONAL
        '
        Me.fieldASIG_LEY18717_CON_ASIG_PROFESIONAL.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldASIG_LEY18717_CON_ASIG_PROFESIONAL.AreaIndex = 8
        Me.fieldASIG_LEY18717_CON_ASIG_PROFESIONAL.Caption = "Ley 18.717 Profesional Actual"
        Me.fieldASIG_LEY18717_CON_ASIG_PROFESIONAL.CellFormat.FormatString = "n0"
        Me.fieldASIG_LEY18717_CON_ASIG_PROFESIONAL.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldASIG_LEY18717_CON_ASIG_PROFESIONAL.FieldName = "ASIG_LEY18717_CON_ASIG_PROFESIONAL"
        Me.fieldASIG_LEY18717_CON_ASIG_PROFESIONAL.Name = "fieldASIG_LEY18717_CON_ASIG_PROFESIONAL"
        '
        'fieldASIG_LEY18717_CON_ASIG_PROFESIONAL_NEW
        '
        Me.fieldASIG_LEY18717_CON_ASIG_PROFESIONAL_NEW.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldASIG_LEY18717_CON_ASIG_PROFESIONAL_NEW.AreaIndex = 9
        Me.fieldASIG_LEY18717_CON_ASIG_PROFESIONAL_NEW.Caption = "Ley 18.717 Profesional Nuevo"
        Me.fieldASIG_LEY18717_CON_ASIG_PROFESIONAL_NEW.CellFormat.FormatString = "n0"
        Me.fieldASIG_LEY18717_CON_ASIG_PROFESIONAL_NEW.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldASIG_LEY18717_CON_ASIG_PROFESIONAL_NEW.FieldName = "ASIG_LEY18717_CON_ASIG_PROFESIONAL_NEW"
        Me.fieldASIG_LEY18717_CON_ASIG_PROFESIONAL_NEW.Name = "fieldASIG_LEY18717_CON_ASIG_PROFESIONAL_NEW"
        '
        'fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL
        '
        Me.fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL.AreaIndex = 10
        Me.fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL.Caption = "Ley 18.717 No Profesional Actual"
        Me.fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL.CellFormat.FormatString = "n0"
        Me.fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL.FieldName = "ASIG_LEY18717_SIN_ASIG_PROFESIONAL"
        Me.fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL.Name = "fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL"
        '
        'fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL_NEW
        '
        Me.fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL_NEW.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL_NEW.AreaIndex = 11
        Me.fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL_NEW.Caption = "Ley 18.717 No Profesional Nuevo"
        Me.fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL_NEW.CellFormat.FormatString = "n0"
        Me.fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL_NEW.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL_NEW.FieldName = "ASIG_LEY18717_SIN_ASIG_PROFESIONAL_NEW"
        Me.fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL_NEW.Name = "fieldASIG_LEY18717_SIN_ASIG_PROFESIONAL_NEW"
        '
        'fieldBONO_LEY18675_ART10
        '
        Me.fieldBONO_LEY18675_ART10.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldBONO_LEY18675_ART10.AreaIndex = 12
        Me.fieldBONO_LEY18675_ART10.Caption = "Ley 18.675 Art.10 Actual"
        Me.fieldBONO_LEY18675_ART10.CellFormat.FormatString = "n0"
        Me.fieldBONO_LEY18675_ART10.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldBONO_LEY18675_ART10.FieldName = "BONO_LEY18675_ART10"
        Me.fieldBONO_LEY18675_ART10.Name = "fieldBONO_LEY18675_ART10"
        '
        'fieldBONO_LEY18675_ART10_NEW
        '
        Me.fieldBONO_LEY18675_ART10_NEW.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldBONO_LEY18675_ART10_NEW.AreaIndex = 13
        Me.fieldBONO_LEY18675_ART10_NEW.Caption = "Ley 18.675 Art.10 Nuevo"
        Me.fieldBONO_LEY18675_ART10_NEW.CellFormat.FormatString = "n0"
        Me.fieldBONO_LEY18675_ART10_NEW.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldBONO_LEY18675_ART10_NEW.FieldName = "BONO_LEY18675_ART10_NEW"
        Me.fieldBONO_LEY18675_ART10_NEW.Name = "fieldBONO_LEY18675_ART10_NEW"
        '
        'fieldBONO_LEY18675_ART11
        '
        Me.fieldBONO_LEY18675_ART11.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldBONO_LEY18675_ART11.AreaIndex = 14
        Me.fieldBONO_LEY18675_ART11.Caption = "Ley 18.675 Art.11 Actual"
        Me.fieldBONO_LEY18675_ART11.CellFormat.FormatString = "n0"
        Me.fieldBONO_LEY18675_ART11.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldBONO_LEY18675_ART11.FieldName = "BONO_LEY18675_ART11"
        Me.fieldBONO_LEY18675_ART11.Name = "fieldBONO_LEY18675_ART11"
        '
        'fieldBONO_LEY18675_ART11_NEW
        '
        Me.fieldBONO_LEY18675_ART11_NEW.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldBONO_LEY18675_ART11_NEW.AreaIndex = 15
        Me.fieldBONO_LEY18675_ART11_NEW.Caption = "Ley 18.675 Art.11 Nuevo"
        Me.fieldBONO_LEY18675_ART11_NEW.CellFormat.FormatString = "n0"
        Me.fieldBONO_LEY18675_ART11_NEW.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldBONO_LEY18675_ART11_NEW.FieldName = "BONO_LEY18675_ART11_NEW"
        Me.fieldBONO_LEY18675_ART11_NEW.Name = "fieldBONO_LEY18675_ART11_NEW"
        '
        'fieldBONO_LEY18566
        '
        Me.fieldBONO_LEY18566.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldBONO_LEY18566.AreaIndex = 17
        Me.fieldBONO_LEY18566.Caption = "Ley 18.566 Actual"
        Me.fieldBONO_LEY18566.CellFormat.FormatString = "n0"
        Me.fieldBONO_LEY18566.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldBONO_LEY18566.FieldName = "BONO_LEY18566"
        Me.fieldBONO_LEY18566.Name = "fieldBONO_LEY18566"
        '
        'fieldBONO_LEY18566_NEW
        '
        Me.fieldBONO_LEY18566_NEW.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldBONO_LEY18566_NEW.AreaIndex = 16
        Me.fieldBONO_LEY18566_NEW.Caption = "Ley 18.566 Nuevo"
        Me.fieldBONO_LEY18566_NEW.CellFormat.FormatString = "n0"
        Me.fieldBONO_LEY18566_NEW.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldBONO_LEY18566_NEW.FieldName = "BONO_LEY18566_NEW"
        Me.fieldBONO_LEY18566_NEW.Name = "fieldBONO_LEY18566_NEW"
        '
        'fieldASIG_LEY3551
        '
        Me.fieldASIG_LEY3551.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldASIG_LEY3551.AreaIndex = 18
        Me.fieldASIG_LEY3551.Caption = "Ley 3551 Actual"
        Me.fieldASIG_LEY3551.CellFormat.FormatString = "n0"
        Me.fieldASIG_LEY3551.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldASIG_LEY3551.FieldName = "ASIG_LEY3551"
        Me.fieldASIG_LEY3551.Name = "fieldASIG_LEY3551"
        '
        'fieldASIG_LEY3551_NEW
        '
        Me.fieldASIG_LEY3551_NEW.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldASIG_LEY3551_NEW.AreaIndex = 19
        Me.fieldASIG_LEY3551_NEW.Caption = "Ley 3551 Nuevo"
        Me.fieldASIG_LEY3551_NEW.CellFormat.FormatString = "n0"
        Me.fieldASIG_LEY3551_NEW.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldASIG_LEY3551_NEW.FieldName = "ASIG_LEY3551_NEW"
        Me.fieldASIG_LEY3551_NEW.Name = "fieldASIG_LEY3551_NEW"
        '
        'fieldGASTO_REPRESENTACION
        '
        Me.fieldGASTO_REPRESENTACION.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldGASTO_REPRESENTACION.AreaIndex = 20
        Me.fieldGASTO_REPRESENTACION.Caption = "Gasto Repres. Actual"
        Me.fieldGASTO_REPRESENTACION.CellFormat.FormatString = "n0"
        Me.fieldGASTO_REPRESENTACION.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldGASTO_REPRESENTACION.FieldName = "GASTO_REPRESENTACION"
        Me.fieldGASTO_REPRESENTACION.Name = "fieldGASTO_REPRESENTACION"
        '
        'fieldGASTO_REPRESENTACION_NEW
        '
        Me.fieldGASTO_REPRESENTACION_NEW.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldGASTO_REPRESENTACION_NEW.AreaIndex = 21
        Me.fieldGASTO_REPRESENTACION_NEW.Caption = "Gasto Repres. Actual"
        Me.fieldGASTO_REPRESENTACION_NEW.CellFormat.FormatString = "n0"
        Me.fieldGASTO_REPRESENTACION_NEW.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldGASTO_REPRESENTACION_NEW.FieldName = "GASTO_REPRESENTACION_NEW"
        Me.fieldGASTO_REPRESENTACION_NEW.Name = "fieldGASTO_REPRESENTACION_NEW"
        '
        'frmReajusteEUS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(872, 446)
        Me.Controls.Add(Me.pgcReajusteEUS)
        Me.Controls.Add(Me.gpcPeriodo)
        Me.Name = "frmReajusteEUS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Revisión Reajuste de Escala Única de Sueldos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcPeriodo.ResumeLayout(False)
        CType(Me.txtPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentajeReajuste.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgcReajusteEUS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim empleado As empleado
    Dim parametroMensual As Periodo
    Dim IDEus As Integer

    Private Sub frmEUS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPeriodo.Visible = True
        txtPeriodo.Enabled = False
        luePeriodo.Visible = False

        repositorio.Show()
        llenarPeriodos()
        empleado = New empleado
        parametroMensual = New Periodo
        txtPeriodo.Text = UCase(parametroMensual.nombrePeriodo)
    End Sub
    Private Sub llenarPeriodos()
        Dim da As SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
        Dim ds As New DataSet

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT * FROM RH_REM_EUS_ENC_REVISION ORDER BY ANO DESC, MES DESC", conn))
        da.Fill(ds, "RH_REM_EUS_ENC_REVISION")
        Dim dvmPeriodo As New DataViewManager(ds)
        dvPeriodo = dvmPeriodo.CreateDataView(ds.Tables("RH_REM_EUS_ENC_REVISION"))

        luePeriodo.Properties.Columns.Clear()
        With luePeriodo
            With .Properties.Columns
                .Add(New LookUpColumnInfo("ANO", "Año", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("MES", "Mes", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Periodo", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("EUS_ID", "ID EUS", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("PORCENTAJE_REAJUSTE", "%Reajuste", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        luePeriodo.Properties.DataSource = dvPeriodo
        luePeriodo.Properties.DisplayMember = "DESCRIPCION"
        luePeriodo.Properties.NullText = ""
        luePeriodo.Properties.PopupWidth = 150
        luePeriodo.Properties.ValueMember = "EUS_ID"
    End Sub

    Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
        Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
        If luePeriodo.EditValue <> Nothing Then
            'pgcReajusteEUS.DataSource = empleado.dvReajusteEUS(luePeriodo.EditValue)
            txtPorcentajeReajuste.EditValue = row("PORCENTAJE_REAJUSTE")
            IDEus = row("EUS_ID")
            pgcReajusteEUS.DataSource = empleado.dvReajusteEUS(IDEus)
        End If
    End Sub


    Private Sub brnRevisionReajusteEUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnRevisionReajusteEUS.Click
        txtPorcentajeReajuste.Enabled = True
        txtPeriodo.Visible = True
        luePeriodo.Visible = False
        If txtPorcentajeReajuste.EditValue = Nothing Or txtPorcentajeReajuste.EditValue <= 0 Then
            txtPorcentajeReajuste.ErrorText = "Porcentaje reajuste debe ser mayor a cero"
        Else
            Dim eusId As Integer = Procesos.reajusteRevisionEUS(parametroMensual.ID, txtPorcentajeReajuste.EditValue)
            pgcReajusteEUS.DataSource = empleado.dvReajusteEUS(eusId)
            'pgcReajusteEUS.RefreshData()
            llenarPeriodos()
            'brnRevisionReajusteEUS.Enabled = False
            MessageBox.Show("Revisión planilla de E.U.S terminada correctamente", "Remuneraciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Dim rutaPlanillaExcel As String
        Try
            With sfdReajusteEUS
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = sfdReajusteEUS.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                pgcReajusteEUS.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

  
    Private Sub btnPeriodoAnteriores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPeriodoAnteriores.Click
        txtPeriodo.Visible = False
        luePeriodo.Visible = True
        txtPorcentajeReajuste.Enabled = False
    End Sub
End Class
