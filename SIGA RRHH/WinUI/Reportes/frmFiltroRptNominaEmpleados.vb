Imports cl.presidencia.Argo.Reportes
Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun

Public Class frmFiltroRptNominaEmpleados
    Inherits System.Windows.Forms.Form
    Private Shared _Form As frmFiltroRptNominaEmpleados = Nothing
    Public Shared Property DefInstance() As frmFiltroRptNominaEmpleados
        Get
            If _Form Is Nothing OrElse _Form.IsDisposed Then
                _Form = New frmFiltroRptNominaEmpleados
            Else
                _Form.BringToFront()
            End If
            Return _Form
        End Get
        Set(ByVal value As frmFiltroRptNominaEmpleados)
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
    Friend WithEvents dvCalidadJuridica As System.Data.DataView
    Friend WithEvents cboCalidadJuridica As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dvEstadoEmpleado As System.Data.DataView
    Friend WithEvents cboEstadoEmpleado As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dvCalidadJuridica = New System.Data.DataView
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton
        Me.cboCalidadJuridica = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboEstadoEmpleado = New System.Windows.Forms.ComboBox
        Me.dvEstadoEmpleado = New System.Data.DataView
        CType(Me.dvCalidadJuridica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEstadoEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvCalidadJuridica
        '
        Me.dvCalidadJuridica.AllowDelete = False
        Me.dvCalidadJuridica.AllowEdit = False
        Me.dvCalidadJuridica.AllowNew = False
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(194, 128)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(122, 23)
        Me.btnVisualizar.TabIndex = 0
        Me.btnVisualizar.Text = "Visualizar"
        '
        'cboCalidadJuridica
        '
        Me.cboCalidadJuridica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCalidadJuridica.Location = New System.Drawing.Point(34, 44)
        Me.cboCalidadJuridica.Name = "cboCalidadJuridica"
        Me.cboCalidadJuridica.Size = New System.Drawing.Size(284, 21)
        Me.cboCalidadJuridica.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(36, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Calidad Jurídica"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(28, 128)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(122, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(35, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Estado"
        '
        'cboEstadoEmpleado
        '
        Me.cboEstadoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstadoEmpleado.Location = New System.Drawing.Point(33, 91)
        Me.cboEstadoEmpleado.Name = "cboEstadoEmpleado"
        Me.cboEstadoEmpleado.Size = New System.Drawing.Size(284, 21)
        Me.cboEstadoEmpleado.TabIndex = 4
        '
        'frmFiltroRptNominaEmpleados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(350, 168)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboEstadoEmpleado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCalidadJuridica)
        Me.Controls.Add(Me.btnVisualizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmFiltroRptNominaEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selección de Calidad Jurídica"
        Me.TopMost = True
        CType(Me.dvCalidadJuridica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEstadoEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Private Sub frmFiltroRptNominaEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        'Carga de Combobox
        cboCalidadJuridica.DisplayMember = "DESCRIPCION"
        cboCalidadJuridica.ValueMember = "CALIDAD_JURIDICA_ID"
        cboCalidadJuridica.DataSource = dvCalidadJuridica
        cboCalidadJuridica.Refresh()

        cboEstadoEmpleado.DisplayMember = "DESCRIPCION"
        cboEstadoEmpleado.ValueMember = "ESTADO_EMPLEADO_ID"
        cboEstadoEmpleado.DataSource = dvEstadoEmpleado
        cboEstadoEmpleado.Refresh()
        da = Nothing
        conn.Close()
        conn = Nothing
    End Sub


    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptNominaEmpleados
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        reporte.RecordSelectionFormula = "{RH_PER_ANTECEDENTE_LABORAL.CALIDAD_JURIDICA_ID}= " & cboCalidadJuridica.SelectedValue & " And {RH_PER_EMPLEADO.ESTADO_EMPLEADO_ID}= " & cboEstadoEmpleado.SelectedValue
        reporte.RecordSelectionFormula += " AND {RH_PER_ANTECEDENTE_LABORAL.ESTADO_REGISTRO}=1"
        reporte.SummaryInfo.ReportTitle = "NÓMINA DE EMPLEADOS / CALIDAD JURIDICA : " & cboCalidadJuridica.Text.Trim & " / ESTADO : " & cboEstadoEmpleado.Text.Trim
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.Show()
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
