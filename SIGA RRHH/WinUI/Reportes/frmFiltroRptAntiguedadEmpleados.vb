Imports cl.presidencia.Argo.Reportes
Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun

Public Class frmFiltroRptAntiguedadEmpleados
    Inherits System.Windows.Forms.Form
    Private Shared _Form As frmFiltroRptAntiguedadEmpleados = Nothing
    Public Shared Property DefInstance() As frmFiltroRptAntiguedadEmpleados
        Get
            If _Form Is Nothing OrElse _Form.IsDisposed Then
                _Form = New frmFiltroRptAntiguedadEmpleados
            Else
                _Form.BringToFront()
            End If
            Return _Form
        End Get
        Set(ByVal value As frmFiltroRptAntiguedadEmpleados)
            _Form = value
        End Set
    End Property

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboEstadoEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCalidadJuridica As System.Windows.Forms.ComboBox
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dvEstadoEmpleado As System.Data.DataView
    Friend WithEvents dvCalidadJuridica As System.Data.DataView
    Friend WithEvents dvInstitucion As System.Data.DataView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboInstitucion As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboEstadoEmpleado = New System.Windows.Forms.ComboBox
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboCalidadJuridica = New System.Windows.Forms.ComboBox
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton
        Me.dvEstadoEmpleado = New System.Data.DataView
        Me.dvCalidadJuridica = New System.Data.DataView
        Me.dvInstitucion = New System.Data.DataView
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboInstitucion = New System.Windows.Forms.ComboBox
        CType(Me.dvEstadoEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvCalidadJuridica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvInstitucion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(14, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Estado"
        '
        'cboEstadoEmpleado
        '
        Me.cboEstadoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstadoEmpleado.Location = New System.Drawing.Point(14, 122)
        Me.cboEstadoEmpleado.Name = "cboEstadoEmpleado"
        Me.cboEstadoEmpleado.Size = New System.Drawing.Size(284, 21)
        Me.cboEstadoEmpleado.TabIndex = 10
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(14, 148)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(122, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Calidad Jurídica"
        '
        'cboCalidadJuridica
        '
        Me.cboCalidadJuridica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCalidadJuridica.Location = New System.Drawing.Point(14, 74)
        Me.cboCalidadJuridica.Name = "cboCalidadJuridica"
        Me.cboCalidadJuridica.Size = New System.Drawing.Size(284, 21)
        Me.cboCalidadJuridica.TabIndex = 7
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(176, 148)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(122, 23)
        Me.btnVisualizar.TabIndex = 6
        Me.btnVisualizar.Text = "Visualizar"
        '
        'dvCalidadJuridica
        '
        Me.dvCalidadJuridica.AllowDelete = False
        Me.dvCalidadJuridica.AllowEdit = False
        Me.dvCalidadJuridica.AllowNew = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(14, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Institución"
        '
        'cboInstitucion
        '
        Me.cboInstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInstitucion.Location = New System.Drawing.Point(14, 24)
        Me.cboInstitucion.Name = "cboInstitucion"
        Me.cboInstitucion.Size = New System.Drawing.Size(284, 21)
        Me.cboInstitucion.TabIndex = 12
        '
        'frmFiltroRptAntiguedadEmpleados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(328, 195)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboInstitucion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboEstadoEmpleado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCalidadJuridica)
        Me.Controls.Add(Me.btnVisualizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmFiltroRptAntiguedadEmpleados"
        Me.Text = "Selección de Criterios"
        CType(Me.dvEstadoEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvCalidadJuridica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvInstitucion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private da As SqlClient.SqlDataAdapter
    Private ds As New DataSet

    Private Sub frmFiltroRptAntiguedadEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        cboEstadoEmpleado.DisplayMember = "DESCRIPCION"
        cboEstadoEmpleado.ValueMember = "ESTADO_EMPLEADO_ID"
        cboEstadoEmpleado.DataSource = dvEstadoEmpleado
        cboEstadoEmpleado.Refresh()

        cboInstitucion.DisplayMember = "DESCRIPCION"
        cboInstitucion.ValueMember = "ORGANIZACION_ID"
        cboInstitucion.DataSource = dvInstitucion
        cboInstitucion.Refresh()

        da = Nothing
        conn.Close()
        conn = Nothing
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptAntiguedadEmpleados
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        reporte.RecordSelectionFormula = "{vwAnnosEmpleados.CALIDAD_JURIDICA_ID}= " & cboCalidadJuridica.SelectedValue & " And {vwAnnosEmpleados.ESTADO_EMPLEADO_ID}= " & cboEstadoEmpleado.SelectedValue & " And {vwAnnosEmpleados.ORGANIZACION_ID}= " & cboInstitucion.SelectedValue
        reporte.SummaryInfo.ReportTitle = "NÓMINA DE EMPLEADOS / CALIDAD JURIDICA : " & cboCalidadJuridica.Text.Trim & " / ESTADO : " & cboEstadoEmpleado.Text.Trim
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.Show()
        Me.Close()
    End Sub
End Class
