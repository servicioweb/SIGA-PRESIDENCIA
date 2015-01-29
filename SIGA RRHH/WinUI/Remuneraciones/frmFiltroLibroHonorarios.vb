Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.Reportes

Public Class frmFiltroLibroHonorarios
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
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboInstitucion As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dvEstadoEmpleado As System.Data.DataView
    Friend WithEvents dvInstitucion As System.Data.DataView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtCalculoSuplementario As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCalculoNormal As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboInstitucion = New System.Windows.Forms.ComboBox
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton
        Me.dvEstadoEmpleado = New System.Data.DataView
        Me.dvInstitucion = New System.Data.DataView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbtCalculoSuplementario = New System.Windows.Forms.RadioButton
        Me.rbtCalculoNormal = New System.Windows.Forms.RadioButton
        CType(Me.dvEstadoEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvInstitucion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.Location = New System.Drawing.Point(24, 72)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(284, 21)
        Me.cboPeriodo.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Período"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Institución"
        '
        'cboInstitucion
        '
        Me.cboInstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInstitucion.Location = New System.Drawing.Point(24, 24)
        Me.cboInstitucion.Name = "cboInstitucion"
        Me.cboInstitucion.Size = New System.Drawing.Size(284, 21)
        Me.cboInstitucion.TabIndex = 30
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(24, 176)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(122, 23)
        Me.btnCancelar.TabIndex = 29
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(184, 176)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(122, 23)
        Me.btnVisualizar.TabIndex = 26
        Me.btnVisualizar.Text = "Visualizar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtCalculoSuplementario)
        Me.GroupBox1.Controls.Add(Me.rbtCalculoNormal)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 48)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo Cálculo"
        '
        'rbtCalculoSuplementario
        '
        Me.rbtCalculoSuplementario.Location = New System.Drawing.Point(152, 16)
        Me.rbtCalculoSuplementario.Name = "rbtCalculoSuplementario"
        Me.rbtCalculoSuplementario.Size = New System.Drawing.Size(112, 24)
        Me.rbtCalculoSuplementario.TabIndex = 25
        Me.rbtCalculoSuplementario.Text = "Suplementario"
        '
        'rbtCalculoNormal
        '
        Me.rbtCalculoNormal.Checked = True
        Me.rbtCalculoNormal.Location = New System.Drawing.Point(16, 16)
        Me.rbtCalculoNormal.Name = "rbtCalculoNormal"
        Me.rbtCalculoNormal.TabIndex = 24
        Me.rbtCalculoNormal.TabStop = True
        Me.rbtCalculoNormal.Text = "Normal"
        '
        'frmFiltroLibroHonorarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(320, 228)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboInstitucion)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnVisualizar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFiltroLibroHonorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libro de Honorarios"
        Me.TopMost = True
        CType(Me.dvEstadoEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvInstitucion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        Dim ventanaReporte1 As New ventanaReporte
        Dim strFormulaSeleccion As String
        
        If rbtCalculoNormal.Checked Then
            Dim reporte As New rptLibroHonorarios
            WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
            strFormulaSeleccion = "{RH_REM_LIQUIDACION_ENC.PERIODO_ID}=" & cboPeriodo.SelectedValue
            strFormulaSeleccion &= " AND "
            strFormulaSeleccion &= "{RH_REM_PERIODO.ORGANIZACION_ID}=" & cboInstitucion.SelectedValue
            strFormulaSeleccion &= " AND "
            strFormulaSeleccion &= "{RH_REM_LIQUIDACION_ENC.TIPO_CALCULO}=""H"""
            If (New cl.presidencia.Argo.BusinessRules.Periodo).ID = Me.cboPeriodo.SelectedValue Then 'Significa que se ha seleccionado el período actual
                strFormulaSeleccion &= " AND {RH_PER_ANTECEDENTE_LABORAL.ESTADO_REGISTRO}=1"
            Else ' Se trata de un registro histórico, para un Periodo cerrado
                strFormulaSeleccion &= " AND {RH_PER_ANTECEDENTE_LABORAL.ESTADO_REGISTRO}=5"
            End If
            ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
            ventanaReporte1.rptVisor.ShowParameterPanelButton = False
            ventanaReporte1.rptVisor.ShowCloseButton = False
            ventanaReporte1.rptVisor.ShowGroupTreeButton = False
            ventanaReporte1.rptVisor.ReportSource = reporte
            ventanaReporte1.Show()

        Else
            If rbtCalculoSuplementario.Checked Then
                Dim reporte As New rptLibroHonorariosSuplementaria
                WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
                strFormulaSeleccion = "{VW_LIBRO_REMUNERACION_HONORARIO_SUPLEMENTARIA.PERIODO_ID}=" & Me.cboPeriodo.SelectedValue
                ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
                ventanaReporte1.rptVisor.ShowParameterPanelButton = False
                ventanaReporte1.rptVisor.ShowCloseButton = False
                ventanaReporte1.rptVisor.ShowGroupTreeButton = False
                ventanaReporte1.rptVisor.ReportSource = reporte
                ventanaReporte1.Show()
            End If
        End If
        Me.Close()
    End Sub

    Private Sub frmFiltroLibroHonorarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
        da = New System.Data.SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_ESTADO_EMPLEADO, conn))
        da.Fill(ds, "RH_PER_ESTADO_EMPLEADO")
        Dim dvmEstadoEmpleado As New DataViewManager(ds)
        dvEstadoEmpleado = dvmEstadoEmpleado.CreateDataView(ds.Tables("RH_PER_ESTADO_EMPLEADO"))

        da = New System.Data.SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_ORGANIZACION, conn))
        da.Fill(ds, "GEN_ORGANIZACION")
        Dim dvmInstitucion As New DataViewManager(ds)
        dvInstitucion = dvmInstitucion.CreateDataView(ds.Tables("GEN_ORGANIZACION"))

        cboInstitucion.DisplayMember = "DESCRIPCION"
        cboInstitucion.ValueMember = "ORGANIZACION_ID"
        cboInstitucion.DataSource = dvInstitucion
        cboInstitucion.Refresh()

        cboPeriodo.DisplayMember = "DESCRIPCION_PERIODO"
        cboPeriodo.ValueMember = "PERIODO_ID"
        cboPeriodo.DataSource = repositorio.dvPeriodo
        cboPeriodo.Refresh()
        da = Nothing
        conn.Close()
        conn = Nothing
    End Sub

End Class
