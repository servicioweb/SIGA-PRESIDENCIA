Imports cl.presidencia.Argo.Reportes
Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun

Public Class frmFiltroNominaFucnionarios
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboInstitucion = New System.Windows.Forms.ComboBox
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton
        Me.dvEstadoEmpleado = New System.Data.DataView
        Me.dvInstitucion = New System.Data.DataView
        CType(Me.dvEstadoEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvInstitucion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.Location = New System.Drawing.Point(26, 70)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(284, 21)
        Me.cboPeriodo.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(26, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Período"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Institución"
        '
        'cboInstitucion
        '
        Me.cboInstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInstitucion.Location = New System.Drawing.Point(24, 24)
        Me.cboInstitucion.Name = "cboInstitucion"
        Me.cboInstitucion.Size = New System.Drawing.Size(284, 21)
        Me.cboInstitucion.TabIndex = 36
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(24, 112)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(122, 23)
        Me.btnCancelar.TabIndex = 39
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(184, 112)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(122, 23)
        Me.btnVisualizar.TabIndex = 38
        Me.btnVisualizar.Text = "Visualizar"
        '
        'frmFiltroNominaFucnionarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(338, 147)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboInstitucion)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFiltroNominaFucnionarios"
        Me.Text = "Nómina de Funcionarios"
        CType(Me.dvEstadoEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvInstitucion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private da As SqlClient.SqlDataAdapter
    Private ds As New DataSet

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptNominaFuncionarios
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        Dim strFormulaSeleccion As String = "{RH_PER_ANTECEDENTE_LABORAL.PERIODO_ID}=" & Me.cboPeriodo.SelectedValue
        strFormulaSeleccion &= " AND "
        strFormulaSeleccion &= "{RH_PER_EMPLEADO.ORGANIZACION_ID}=" & cboInstitucion.SelectedValue
        If (New cl.presidencia.Argo.BusinessRules.Periodo).ID = Me.cboPeriodo.SelectedValue Then 'Significa que se ha seleccionado el período actual
            strFormulaSeleccion &= " AND {RH_PER_ANTECEDENTE_LABORAL.ESTADO_REGISTRO}=1"
        Else ' Se trata de un registro histórico, para un Periodo cerrado
            strFormulaSeleccion &= " AND {RH_PER_ANTECEDENTE_LABORAL.ESTADO_REGISTRO}=5"
        End If
        reporte.SummaryInfo.ReportTitle = "Nómina de Funcionarios / Período :" & cboPeriodo.Text
        ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
        ventanaReporte1.rptVisor.ShowParameterPanelButton = False
        ventanaReporte1.rptVisor.ShowCloseButton = False
        ventanaReporte1.rptVisor.ShowGroupTreeButton = True
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.Show()
        Me.Close()

    End Sub

    Private Sub frmFiltroNominaFucnionarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        repositorio.Show()
        cboPeriodo.DataSource = repositorio.dvPeriodo
        cboPeriodo.Refresh()
        da = Nothing
        conn.Close()
        conn = Nothing
    End Sub
End Class
