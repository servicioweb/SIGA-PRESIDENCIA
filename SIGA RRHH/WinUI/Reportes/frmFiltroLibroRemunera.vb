Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.Reportes

Public Class frmFiltroLibroRemunera
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboInstitucion As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCalidadJuridica As System.Windows.Forms.ComboBox
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dvInstitucion As System.Data.DataView
    Friend WithEvents dvEstadoEmpleado As System.Data.DataView
    Friend WithEvents dvCalidadJuridica As System.Data.DataView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents rbtCalculoNormal As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtCalculoSuplementario As System.Windows.Forms.RadioButton
    Friend WithEvents chkOmitirFiltroCalidadJuridica As DevExpress.XtraEditors.CheckEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboInstitucion = New System.Windows.Forms.ComboBox
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboCalidadJuridica = New System.Windows.Forms.ComboBox
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton
        Me.dvInstitucion = New System.Data.DataView
        Me.dvEstadoEmpleado = New System.Data.DataView
        Me.dvCalidadJuridica = New System.Data.DataView
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboPeriodo = New System.Windows.Forms.ComboBox
        Me.rbtCalculoNormal = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbtCalculoSuplementario = New System.Windows.Forms.RadioButton
        Me.chkOmitirFiltroCalidadJuridica = New DevExpress.XtraEditors.CheckEdit
        CType(Me.dvInstitucion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEstadoEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvCalidadJuridica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.chkOmitirFiltroCalidadJuridica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Institución"
        '
        'cboInstitucion
        '
        Me.cboInstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInstitucion.Location = New System.Drawing.Point(8, 24)
        Me.cboInstitucion.Name = "cboInstitucion"
        Me.cboInstitucion.Size = New System.Drawing.Size(284, 21)
        Me.cboInstitucion.TabIndex = 20
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(8, 256)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(122, 23)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cancelar"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Calidad Jurídica"
        '
        'cboCalidadJuridica
        '
        Me.cboCalidadJuridica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCalidadJuridica.Location = New System.Drawing.Point(8, 72)
        Me.cboCalidadJuridica.Name = "cboCalidadJuridica"
        Me.cboCalidadJuridica.Size = New System.Drawing.Size(284, 21)
        Me.cboCalidadJuridica.TabIndex = 15
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(168, 256)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(122, 23)
        Me.btnVisualizar.TabIndex = 14
        Me.btnVisualizar.Text = "Visualizar"
        '
        'dvCalidadJuridica
        '
        Me.dvCalidadJuridica.AllowDelete = False
        Me.dvCalidadJuridica.AllowEdit = False
        Me.dvCalidadJuridica.AllowNew = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Período"
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.Location = New System.Drawing.Point(8, 224)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(284, 21)
        Me.cboPeriodo.TabIndex = 23
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtCalculoSuplementario)
        Me.GroupBox1.Controls.Add(Me.rbtCalculoNormal)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 48)
        Me.GroupBox1.TabIndex = 25
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
        'chkOmitirFiltroCalidadJuridica
        '
        Me.chkOmitirFiltroCalidadJuridica.Location = New System.Drawing.Point(8, 104)
        Me.chkOmitirFiltroCalidadJuridica.Name = "chkOmitirFiltroCalidadJuridica"
        '
        'chkOmitirFiltroCalidadJuridica.Properties
        '
        Me.chkOmitirFiltroCalidadJuridica.Properties.Caption = "Mostrar todas las calidades Jurídicas"
        Me.chkOmitirFiltroCalidadJuridica.Size = New System.Drawing.Size(280, 19)
        Me.chkOmitirFiltroCalidadJuridica.TabIndex = 26
        '
        'frmFiltroLibroRemunera
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(304, 309)
        Me.Controls.Add(Me.chkOmitirFiltroCalidadJuridica)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboInstitucion)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCalidadJuridica)
        Me.Controls.Add(Me.btnVisualizar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFiltroLibroRemunera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libro de Remuneraciones / Filtro de Emisión"
        Me.TopMost = True
        CType(Me.dvInstitucion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEstadoEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvCalidadJuridica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.chkOmitirFiltroCalidadJuridica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub frmFiltroLibroRemunera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
        da = New System.Data.SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_CALIDAD_JURIDICA, conn))
        da.Fill(ds, "RH_REM_CALIDAD_JURIDICA")
        Dim dvmCalidadJuridica As New DataViewManager(ds)
        dvCalidadJuridica = dvmCalidadJuridica.CreateDataView(ds.Tables("RH_REM_CALIDAD_JURIDICA"))

        da = New System.Data.SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_ESTADO_EMPLEADO, conn))
        da.Fill(ds, "RH_PER_ESTADO_EMPLEADO")
        Dim dvmEstadoEmpleado As New DataViewManager(ds)
        dvEstadoEmpleado = dvmEstadoEmpleado.CreateDataView(ds.Tables("RH_PER_ESTADO_EMPLEADO"))

        da = New System.Data.SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_ORGANIZACION, conn))
        da.Fill(ds, "GEN_ORGANIZACION")
        Dim dvmInstitucion As New DataViewManager(ds)
        dvInstitucion = dvmInstitucion.CreateDataView(ds.Tables("GEN_ORGANIZACION"))

        'Carga de Combobox
        cboCalidadJuridica.DisplayMember = "DESCRIPCION"
        cboCalidadJuridica.ValueMember = "CALIDAD_JURIDICA_ID"
        cboCalidadJuridica.DataSource = dvCalidadJuridica
        cboCalidadJuridica.Refresh()


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

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptLibroRemuneraciones
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        Dim strFormulaSeleccion As String = "{RH_REM_PERIODO.PERIODO_ID}=" & Me.cboPeriodo.SelectedValue
        strFormulaSeleccion &= " AND {RH_PER_ANTECEDENTE_LABORAL.PERIODO_ID}=" & Me.cboPeriodo.SelectedValue
        strFormulaSeleccion &= " AND {RH_REM_LIQUIDACION_ENC.PERIODO_ID}=" & Me.cboPeriodo.SelectedValue
        strFormulaSeleccion &= " AND "
        strFormulaSeleccion &= "{RH_REM_PERIODO.ORGANIZACION_ID}=" & cboInstitucion.SelectedValue
        strFormulaSeleccion &= " AND "
        If rbtCalculoNormal.Checked Then
            strFormulaSeleccion &= "{RH_REM_LIQUIDACION_ENC.TIPO_CALCULO}=""N"""
        Else
            If rbtCalculoSuplementario.Checked Then
                strFormulaSeleccion &= "{RH_REM_LIQUIDACION_ENC.TIPO_CALCULO}=""S"""
            End If
        End If
        If chkOmitirFiltroCalidadJuridica.Checked = False Then
            strFormulaSeleccion &= " AND {RH_REM_CALIDAD_JURIDICA.CALIDAD_JURIDICA_ID}=" & cboCalidadJuridica.SelectedValue
            ventanaReporte1.rptVisor.ShowParameterPanelButton = False
            ventanaReporte1.rptVisor.ShowCloseButton = False
            ventanaReporte1.rptVisor.ShowGroupTreeButton = False
        Else
            ventanaReporte1.rptVisor.ShowParameterPanelButton = False
            ventanaReporte1.rptVisor.ShowCloseButton = False
            ventanaReporte1.rptVisor.ShowGroupTreeButton = True
        End If
        If (New cl.presidencia.Argo.BusinessRules.Periodo).ID = Me.cboPeriodo.SelectedValue Then 'Significa que se ha seleccionado el período actual
            strFormulaSeleccion &= " AND {RH_PER_ANTECEDENTE_LABORAL.ESTADO_REGISTRO}=1"
        Else ' Se trata de un registro histórico, para un Periodo cerrado
            strFormulaSeleccion &= " AND {RH_PER_ANTECEDENTE_LABORAL.ESTADO_REGISTRO}=5"
        End If
        ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.TopMost = True
        ventanaReporte1.Show()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
