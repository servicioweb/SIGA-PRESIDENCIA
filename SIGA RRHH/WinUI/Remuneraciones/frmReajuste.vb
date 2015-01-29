Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessRules
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmReajuste
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
    Friend WithEvents txtPeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents txtPorcentajeReajuste As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPorcentajeReajuste As System.Windows.Forms.Label
    Friend WithEvents gpcPeriodo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gpcBotones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnDefinitivo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRevision As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dvPeriodo As System.Data.DataView
    Friend WithEvents pgcReajuste As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldANO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE_COMPLETO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldITEM_ALIAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDESCRIPCION_LARGA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMONTO_ACTUAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMONTO_REAJUSTADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCALIDAD_JURIDICA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGRADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCLASIFICACION_EMPLEADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents sfdReajuste As System.Windows.Forms.SaveFileDialog
    Friend WithEvents fieldEMPLEADO_ID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents Progreso As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpcPeriodo = New DevExpress.XtraEditors.GroupControl
        Me.lblPorcentajeReajuste = New System.Windows.Forms.Label
        Me.txtPorcentajeReajuste = New DevExpress.XtraEditors.TextEdit
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit
        Me.txtPeriodo = New DevExpress.XtraEditors.TextEdit
        Me.gpcBotones = New DevExpress.XtraEditors.GroupControl
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton
        Me.btnDefinitivo = New DevExpress.XtraEditors.SimpleButton
        Me.btnRevision = New DevExpress.XtraEditors.SimpleButton
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.pgcReajuste = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.fieldANO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMES = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldRUT = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOMBRE_COMPLETO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldITEM_ALIAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDESCRIPCION_LARGA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMONTO_ACTUAL = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMONTO_REAJUSTADO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCALIDAD_JURIDICA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldGRADO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCLASIFICACION_EMPLEADO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.dvPeriodo = New System.Data.DataView
        Me.sfdReajuste = New System.Windows.Forms.SaveFileDialog
        Me.fieldEMPLEADO_ID = New DevExpress.XtraPivotGrid.PivotGridField
        Me.Progreso = New System.Windows.Forms.ProgressBar
        CType(Me.gpcPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcPeriodo.SuspendLayout()
        CType(Me.txtPorcentajeReajuste.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBotones.SuspendLayout()
        CType(Me.pgcReajuste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcPeriodo
        '
        Me.gpcPeriodo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcPeriodo.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcPeriodo.AppearanceCaption.Options.UseFont = True
        Me.gpcPeriodo.Controls.Add(Me.Progreso)
        Me.gpcPeriodo.Controls.Add(Me.lblPorcentajeReajuste)
        Me.gpcPeriodo.Controls.Add(Me.txtPorcentajeReajuste)
        Me.gpcPeriodo.Controls.Add(Me.lblPeriodo)
        Me.gpcPeriodo.Controls.Add(Me.luePeriodo)
        Me.gpcPeriodo.Controls.Add(Me.txtPeriodo)
        Me.gpcPeriodo.Location = New System.Drawing.Point(8, 8)
        Me.gpcPeriodo.Name = "gpcPeriodo"
        Me.gpcPeriodo.Size = New System.Drawing.Size(832, 88)
        Me.gpcPeriodo.TabIndex = 0
        Me.gpcPeriodo.Text = "Información del Período"
        '
        'lblPorcentajeReajuste
        '
        Me.lblPorcentajeReajuste.Location = New System.Drawing.Point(16, 62)
        Me.lblPorcentajeReajuste.Name = "lblPorcentajeReajuste"
        Me.lblPorcentajeReajuste.Size = New System.Drawing.Size(112, 16)
        Me.lblPorcentajeReajuste.TabIndex = 4
        Me.lblPorcentajeReajuste.Text = "Porcentaje Reajuste"
        Me.lblPorcentajeReajuste.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPorcentajeReajuste
        '
        Me.txtPorcentajeReajuste.EnterMoveNextControl = True
        Me.txtPorcentajeReajuste.Location = New System.Drawing.Point(136, 58)
        Me.txtPorcentajeReajuste.Name = "txtPorcentajeReajuste"
        '
        'txtPorcentajeReajuste.Properties
        '
        Me.txtPorcentajeReajuste.Properties.DisplayFormat.FormatString = "n2"
        Me.txtPorcentajeReajuste.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorcentajeReajuste.Properties.EditFormat.FormatString = "n2"
        Me.txtPorcentajeReajuste.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorcentajeReajuste.Properties.Mask.EditMask = "n2"
        Me.txtPorcentajeReajuste.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPorcentajeReajuste.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPorcentajeReajuste.Properties.MaxLength = 5
        Me.txtPorcentajeReajuste.TabIndex = 1
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(28, 36)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(100, 16)
        Me.lblPeriodo.TabIndex = 2
        Me.lblPeriodo.Text = "Periodo"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        'txtPeriodo
        '
        Me.txtPeriodo.Location = New System.Drawing.Point(136, 32)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.TabIndex = 0
        '
        'gpcBotones
        '
        Me.gpcBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcBotones.Controls.Add(Me.btnExcel)
        Me.gpcBotones.Controls.Add(Me.btnDefinitivo)
        Me.gpcBotones.Controls.Add(Me.btnRevision)
        Me.gpcBotones.Controls.Add(Me.btnEliminar)
        Me.gpcBotones.Controls.Add(Me.btnNuevo)
        Me.gpcBotones.Location = New System.Drawing.Point(8, 96)
        Me.gpcBotones.Name = "gpcBotones"
        Me.gpcBotones.ShowCaption = False
        Me.gpcBotones.Size = New System.Drawing.Size(832, 56)
        Me.gpcBotones.TabIndex = 1
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(536, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.TabIndex = 4
        Me.btnExcel.Text = "E&xcel"
        '
        'btnDefinitivo
        '
        Me.btnDefinitivo.Location = New System.Drawing.Point(456, 17)
        Me.btnDefinitivo.Name = "btnDefinitivo"
        Me.btnDefinitivo.TabIndex = 3
        Me.btnDefinitivo.Text = "&Definitivo"
        '
        'btnRevision
        '
        Me.btnRevision.Location = New System.Drawing.Point(376, 17)
        Me.btnRevision.Name = "btnRevision"
        Me.btnRevision.TabIndex = 2
        Me.btnRevision.Text = "&Revisión"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(296, 16)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "&Eliminar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(216, 16)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "&Nuevo"
        '
        'pgcReajuste
        '
        Me.pgcReajuste.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgcReajuste.Cursor = System.Windows.Forms.Cursors.Default
        Me.pgcReajuste.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldANO, Me.fieldMES, Me.fieldRUT, Me.fieldNOMBRE_COMPLETO, Me.fieldITEM_ALIAS, Me.fieldDESCRIPCION_LARGA, Me.fieldMONTO_ACTUAL, Me.fieldMONTO_REAJUSTADO, Me.fieldCALIDAD_JURIDICA, Me.fieldGRADO, Me.fieldCLASIFICACION_EMPLEADO, Me.fieldEMPLEADO_ID})
        Me.pgcReajuste.Location = New System.Drawing.Point(8, 152)
        Me.pgcReajuste.Name = "pgcReajuste"
        Me.pgcReajuste.Size = New System.Drawing.Size(832, 304)
        Me.pgcReajuste.TabIndex = 2
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
        'fieldRUT
        '
        Me.fieldRUT.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldRUT.AreaIndex = 3
        Me.fieldRUT.Caption = "Rut"
        Me.fieldRUT.FieldName = "RUT"
        Me.fieldRUT.Name = "fieldRUT"
        '
        'fieldNOMBRE_COMPLETO
        '
        Me.fieldNOMBRE_COMPLETO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNOMBRE_COMPLETO.AreaIndex = 4
        Me.fieldNOMBRE_COMPLETO.Caption = "Nombre Empleado"
        Me.fieldNOMBRE_COMPLETO.FieldName = "NOMBRE_COMPLETO"
        Me.fieldNOMBRE_COMPLETO.Name = "fieldNOMBRE_COMPLETO"
        '
        'fieldITEM_ALIAS
        '
        Me.fieldITEM_ALIAS.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldITEM_ALIAS.AreaIndex = 0
        Me.fieldITEM_ALIAS.Caption = "Ítem"
        Me.fieldITEM_ALIAS.FieldName = "ITEM_ALIAS"
        Me.fieldITEM_ALIAS.Name = "fieldITEM_ALIAS"
        '
        'fieldDESCRIPCION_LARGA
        '
        Me.fieldDESCRIPCION_LARGA.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldDESCRIPCION_LARGA.AreaIndex = 0
        Me.fieldDESCRIPCION_LARGA.Caption = "Descripción Ítem"
        Me.fieldDESCRIPCION_LARGA.FieldName = "DESCRIPCION_LARGA"
        Me.fieldDESCRIPCION_LARGA.Name = "fieldDESCRIPCION_LARGA"
        '
        'fieldMONTO_ACTUAL
        '
        Me.fieldMONTO_ACTUAL.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldMONTO_ACTUAL.AreaIndex = 0
        Me.fieldMONTO_ACTUAL.Caption = "Monto Actual"
        Me.fieldMONTO_ACTUAL.CellFormat.FormatString = "n0"
        Me.fieldMONTO_ACTUAL.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldMONTO_ACTUAL.FieldName = "MONTO_ACTUAL"
        Me.fieldMONTO_ACTUAL.Name = "fieldMONTO_ACTUAL"
        '
        'fieldMONTO_REAJUSTADO
        '
        Me.fieldMONTO_REAJUSTADO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldMONTO_REAJUSTADO.AreaIndex = 1
        Me.fieldMONTO_REAJUSTADO.Caption = "Monto Reajustado"
        Me.fieldMONTO_REAJUSTADO.CellFormat.FormatString = "n0"
        Me.fieldMONTO_REAJUSTADO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldMONTO_REAJUSTADO.FieldName = "MONTO_REAJUSTADO"
        Me.fieldMONTO_REAJUSTADO.Name = "fieldMONTO_REAJUSTADO"
        '
        'fieldCALIDAD_JURIDICA
        '
        Me.fieldCALIDAD_JURIDICA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCALIDAD_JURIDICA.AreaIndex = 2
        Me.fieldCALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.fieldCALIDAD_JURIDICA.FieldName = "CALIDAD_JURIDICA"
        Me.fieldCALIDAD_JURIDICA.Name = "fieldCALIDAD_JURIDICA"
        '
        'fieldGRADO
        '
        Me.fieldGRADO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldGRADO.AreaIndex = 2
        Me.fieldGRADO.Caption = "Grado"
        Me.fieldGRADO.FieldName = "GRADO"
        Me.fieldGRADO.Name = "fieldGRADO"
        '
        'fieldCLASIFICACION_EMPLEADO
        '
        Me.fieldCLASIFICACION_EMPLEADO.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldCLASIFICACION_EMPLEADO.AreaIndex = 1
        Me.fieldCLASIFICACION_EMPLEADO.Caption = "Clasificación Empleado"
        Me.fieldCLASIFICACION_EMPLEADO.FieldName = "CLASIFICACION_EMPLEADO"
        Me.fieldCLASIFICACION_EMPLEADO.Name = "fieldCLASIFICACION_EMPLEADO"
        '
        'fieldEMPLEADO_ID
        '
        Me.fieldEMPLEADO_ID.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldEMPLEADO_ID.AreaIndex = 3
        Me.fieldEMPLEADO_ID.Caption = "ID Empleado"
        Me.fieldEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.fieldEMPLEADO_ID.Name = "fieldEMPLEADO_ID"
        Me.fieldEMPLEADO_ID.Visible = False
        '
        'Progreso
        '
        Me.Progreso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Progreso.Location = New System.Drawing.Point(272, 40)
        Me.Progreso.Name = "Progreso"
        Me.Progreso.Size = New System.Drawing.Size(536, 23)
        Me.Progreso.TabIndex = 5
        '
        'frmReajuste
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(848, 462)
        Me.Controls.Add(Me.pgcReajuste)
        Me.Controls.Add(Me.gpcBotones)
        Me.Controls.Add(Me.gpcPeriodo)
        Me.Name = "frmReajuste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proceso de Reajuste"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcPeriodo.ResumeLayout(False)
        CType(Me.txtPorcentajeReajuste.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBotones.ResumeLayout(False)
        CType(Me.pgcReajuste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim empleado As empleado
    Dim periodo As periodo
    Dim parametroMensual As periodo
    Dim reajusteID As Integer

    Private Sub frmReajuste_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        periodo = New periodo
        btnNuevo.Enabled = True
        btnEliminar.Enabled = False
        btnRevision.Enabled = False
        btnDefinitivo.Enabled = False
        btnExcel.Enabled = False
        txtPeriodo.Visible = False
        luePeriodo.Visible = True
        txtPorcentajeReajuste.Enabled = False
        Progreso.Visible = False
        generarVista()
        llenarPeriodo()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        txtPeriodo.Visible = True
        txtPeriodo.Enabled = False
        luePeriodo.Visible = False
        txtPorcentajeReajuste.Enabled = True
        txtPeriodo.Text = UCase(periodo.nombrePeriodo)
        txtPorcentajeReajuste.Focus()
    End Sub
    Private Sub llenarPeriodo()
        With luePeriodo
            With .Properties.Columns
                .Add(New LookUpColumnInfo("DESCRIPCION_PERIODO", "Período", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("PERIODO_ID", "ID Período", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("PORCENTAJE", "Porcentaje", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("REAJUSTE_ID", "ID Reajuste", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        luePeriodo.Properties.DataSource = dvPeriodo
        luePeriodo.Properties.DisplayMember = "DESCRIPCION_PERIODO"
        luePeriodo.Properties.NullText = ""
        luePeriodo.Properties.PopupWidth = 100
        luePeriodo.Properties.ValueMember = "PERIODO_ID"
    End Sub
    Private Sub generarVista()
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString

        Dim da As SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.INSTRUCCIONES_SQL.SELECT_REAJUSTE(ArgoConfiguracion.OrganizacionID), conn))
        da.Fill(ds, Tablas.RH_REM_REAJUSTE)
        Dim dvmPeriodo As New DataViewManager(ds)
        dvPeriodo = dvmPeriodo.CreateDataView(ds.Tables(Tablas.RH_REM_REAJUSTE))
    End Sub

    Private Sub txtPorcentajeReajuste_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPorcentajeReajuste.Validating
        If txtPorcentajeReajuste.EditValue = Nothing Or txtPorcentajeReajuste.EditValue <= 0 Then
            txtPorcentajeReajuste.ErrorText = "Porcentaje reajuste debe ser mayor a cero"
            e.Cancel = True
        Else
            btnRevision.Enabled = True
            btnDefinitivo.Enabled = True
        End If
    End Sub

    Private Sub btnRevision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRevision.Click
        If MessageBox.Show("Este proceso genera los registros para ser revisados. ¿Desea continuar?", "Remuneraciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Cursor.Current = Cursors.WaitCursor
                Dim reajusteID As Integer
                reajusteID = Procesos.reajusteRevisionMovimientos(ArgoConfiguracion.OrganizacionID, periodo.ID, txtPorcentajeReajuste.EditValue, 0)
                pgcReajuste.DataSource = Procesos.reajusteRecuperarDetalle(ArgoConfiguracion.OrganizacionID, periodo.ID)
                btnNuevo.Enabled = False
                btnExcel.Enabled = True
                btnEliminar.Enabled = True
                btnRevision.Enabled = False
                btnDefinitivo.Enabled = True
                Cursor.Current = Cursors.Default
            Catch ex As Exception
                MsgBox("Ha ocurrido un error en proceso de revisión." & Chr(13) & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
            End Try

        End If
    End Sub

    Private Sub luePeriodo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePeriodo.EditValueChanged
        Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
        Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
        If luePeriodo.EditValue <> Nothing Then
            pgcReajuste.DataSource = Procesos.reajusteRecuperarDetalle(ArgoConfiguracion.OrganizacionID, luePeriodo.EditValue)
            btnNuevo.Enabled = False
            btnExcel.Enabled = True
            btnEliminar.Enabled = True
            btnRevision.Enabled = False
            btnDefinitivo.Enabled = True
            txtPorcentajeReajuste.Text = row("PORCENTAJE")
            txtPorcentajeReajuste.Enabled = True
            reajusteID = row("REAJUSTE_ID")
        End If
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Dim rutaPlanillaExcel As String
        Try
            With sfdReajuste
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = sfdReajuste.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                pgcReajuste.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If luePeriodo.EditValue <> Nothing Then
            If MessageBox.Show("¿Seguro desea eliminar el proceso de revisión reajuste?", "Remuneraciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If Procesos.reajusteEliminaRegistros(reajusteID) Then
                    Cursor.Current = Cursors.WaitCursor
                    luePeriodo.Properties.Columns.Clear()
                    generarVista()
                    llenarPeriodo()
                    luePeriodo.Properties.DataSource = dvPeriodo
                    btnNuevo.Enabled = True
                    btnEliminar.Enabled = False
                    btnRevision.Enabled = False
                    btnDefinitivo.Enabled = False
                    btnExcel.Enabled = False
                    txtPeriodo.Visible = False
                    luePeriodo.Visible = True
                    txtPorcentajeReajuste.Enabled = False
                    pgcReajuste.DataSource = Procesos.reajusteRecuperarDetalle(ArgoConfiguracion.OrganizacionID, luePeriodo.EditValue)
                    Cursor.Current = Cursors.Default
                Else
                    MessageBox.Show("No se pudieron eliminar los registros de revisión", "Remuneraciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub btnDefinitivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefinitivo.Click
        If MessageBox.Show("¿Está seguro que desea generar las asignaciones a los empleados?", "Remuneraciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim reajusteID As Integer
                parametroMensual = New periodo
                Try
                    Cursor.Current = Cursors.WaitCursor
                    btnNuevo.Enabled = False
                    btnExcel.Enabled = False
                    btnEliminar.Enabled = False
                    btnRevision.Enabled = False
                    btnDefinitivo.Enabled = False
                    reajusteID = Procesos.reajusteDefinitivo(txtPorcentajeReajuste.EditValue, CType(parametroMensual.ano, String), CType(parametroMensual.mes, String))
                    Cursor.Current = Cursors.Default
                    generarAsignaciones()
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error en proceso de reajuste definitivo." & Chr(13) & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
                End Try

            Catch ex As Exception
                MsgBox("Ha ocurrido un error en proceso de reajuste definitivo." & Chr(13) & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
            End Try

        End If
    End Sub
    Private Sub generarAsignaciones()
        Dim dtEmpleados As DataTable
        Dim fila As Data.DataRow
        Dim contador As Integer = 0
        Dim tipoProcesoRemun As String = "N"

        Progreso.Visible = True
        Progreso.Enabled = True
        Progreso.Minimum = 0
        dtEmpleados = Procesos.reajusteRecuperarEmpleados(ArgoConfiguracion.OrganizacionID, parametroMensual.ID)
        Progreso.Maximum = dtEmpleados.Rows.Count - 1
        For Each fila In dtEmpleados.Rows
            empleado = New empleado(fila("EMPLEADO_ID"), True)
            generaMontosAsignaciones(Comun.TiposDeDatos.TipoOrigenItem.FICHA_EMPLEADO, "N", tipoProcesoRemun)
            Progreso.Value = contador
            contador += 1
        Next
        System.Windows.Forms.MessageBox.Show("Proceso Finalizado. Se han actualizado " & dtEmpleados.Rows.Count & " registros de empleados." & Chr(13) & Chr(13) & "Acontinuación la aplicación se cerrará", "Sistema de Remuneraciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
    Private Sub generaMontosAsignaciones(ByVal origen As Integer, ByVal tipoProceso As String, ByVal procesoRemun As String)
        Dim idCalJuridica, idGrado, idClasEmpleado, idAfp, idIsapre, numBienios As Integer

        idCalJuridica = empleado.datosLaborales.calidadJuridicaID
        idGrado = empleado.datosLaborales.gradoID
        idClasEmpleado = empleado.datosLaborales.clasificacionEmpleadoID
        idAfp = empleado.datosPrevisionales.institucionID
        idIsapre = empleado.datosSalud.institucionID
        numBienios = empleado.datosRemuneracion.numeroBienios
        'Genera los montos para las asignaciones
        empleado.recuperarDatosEUSEmpleado(empleado, idCalJuridica, idGrado, _
                                              idClasEmpleado, numBienios, idAfp, idIsapre, parametroMensual)
        'Crea los movimientos mensual para asignación
        empleado.EliminarMovimientoMensualEmpleado(parametroMensual.ID, CType(empleado.ID, Integer), Comun.TiposDeDatos.TipoOrigenItem.FICHA_EMPLEADO, procesoRemun)
        empleado.CrearItemEmpleado(empleado, parametroMensual, origen, tipoProceso)
        'Actualizar montos en registro de remuneración
        empleado.actualizarDatosRemun(empleado.datosRemuneracion)
    End Sub

End Class
