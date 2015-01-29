Public Class frmEnDesarrollo
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents btnMenuPrincipal As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents btnFirmaLiquidacion As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.btnMenuPrincipal = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.btnFirmaLiquidacion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(10, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 36)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Ficha Empleado"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(10, 48)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(184, 36)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "AntecedentesCurriculares"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(10, 88)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(184, 36)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Antecedentes Académicos"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(10, 128)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(184, 36)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Feriado Legal"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(10, 170)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(184, 36)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Cargas Familiares"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(10, 254)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(184, 36)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Permiso Paternal"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(10, 380)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(184, 36)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "Licencia Médica"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(10, 422)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(184, 36)
        Me.Button11.TabIndex = 10
        Me.Button11.Text = "Horas Extras"
        '
        'btnMenuPrincipal
        '
        Me.btnMenuPrincipal.Location = New System.Drawing.Point(10, 466)
        Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
        Me.btnMenuPrincipal.Size = New System.Drawing.Size(184, 30)
        Me.btnMenuPrincipal.TabIndex = 11
        Me.btnMenuPrincipal.Text = "Menú Principal"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(10, 212)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(184, 36)
        Me.Button12.TabIndex = 12
        Me.Button12.Text = "Grupo Familiar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(10, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 36)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Permiso Admin CGS"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(10, 338)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(184, 36)
        Me.Button9.TabIndex = 14
        Me.Button9.Text = "Permiso Admin SGS"
        '
        'Button13
        '
        Me.Button13.Enabled = False
        Me.Button13.Location = New System.Drawing.Point(8, 580)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(182, 18)
        Me.Button13.TabIndex = 16
        Me.Button13.Text = "Pruebas"
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(10, 504)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(184, 32)
        Me.Button14.TabIndex = 17
        Me.Button14.Text = "Control Viáticos"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(216, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(184, 38)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Mantención  por Item"
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(216, 46)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(184, 40)
        Me.Button15.TabIndex = 19
        Me.Button15.Text = "Saldo Dias"
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(218, 90)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(184, 40)
        Me.Button16.TabIndex = 20
        Me.Button16.Text = "Recalcula Bono"
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(220, 132)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(184, 40)
        Me.Button17.TabIndex = 21
        Me.Button17.Text = "Dif.Recalculo Bono"
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(222, 196)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(182, 54)
        Me.Button18.TabIndex = 22
        Me.Button18.Text = "Prueba WS Auententica"
        '
        'btnFirmaLiquidacion
        '
        Me.btnFirmaLiquidacion.Location = New System.Drawing.Point(222, 261)
        Me.btnFirmaLiquidacion.Name = "btnFirmaLiquidacion"
        Me.btnFirmaLiquidacion.Size = New System.Drawing.Size(182, 49)
        Me.btnFirmaLiquidacion.TabIndex = 23
        Me.btnFirmaLiquidacion.Text = "Firma Liquidacion"
        Me.btnFirmaLiquidacion.UseVisualStyleBackColor = True
        '
        'frmEnDesarrollo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(474, 536)
        Me.Controls.Add(Me.btnFirmaLiquidacion)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.btnMenuPrincipal)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Name = "frmEnDesarrollo"
        Me.Text = "frmEnDesarrollo"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmEnDesarrollo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        repositorio = New frmrepositorio
        repositorio.Show()
        repositorio.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim frm1 As New frmAntecedenteCurricular
        frm1.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim frm1 As New frmAntecedentesAcademicos
        frm1.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim frm1 As New frmFeriadoLegalEmpleado
        frm1.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim frm1 As New frmCargaFamiliar
        frm1.tipoEdicion = cl.presidencia.Argo.Comun.TiposDeDatos.TipoEdicionCargaFAM.EDICION_COMO_CARGA_FAMILIAR
        frm1.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim frm1 As New frmPermisoPaternal
        frm1.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim frm1 As New frmHorasExtrasEmpleado
        frm1.Show()
    End Sub

    Private Sub btnMenuPrincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuPrincipal.Click
        Dim ventanaPrincipal As New frmMain
        ventanaPrincipal.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim frm1 As New frmCargaFamiliar
        With frm1
            .tipoEdicion = cl.presidencia.Argo.Comun.TiposDeDatos.TipoEdicionCargaFAM.EDICION_COMO_MIEMBRO_GRUPO_FAMILIAR
            .Text = "Grupo Familiar"
            .pnlDatosCargaFAM.Visible = False
            .pnlDatosCargaFAM.Location = New System.Drawing.Point(376, 192)
            .pnlAcciones.Location = New System.Drawing.Point(272, 168)
            .GCEditorDatos.Text = "Datos Miembro del Grupo Familiar"
            .GCDetalle.Location = New System.Drawing.Point(8, 215)
            .GCDetalle.Text = "Pertenecen al Grupo Familiar"
            .Show()
        End With
    End Sub


    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim items() As Integer = {5, 6}
        Dim frm1 As New frmMantencionItemPeriodo(items)
        frm1.Show()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim frm1 As New frmSaldoDiasEventosAdministrativos
        frm1.Show()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim frm1 As New frmRecalcularEmpleadoBonoModernizacion
        frm1.Show()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Dim frm1 As New frmDiferenciaRecalculoBonoModernizacion
        frm1.Show()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        'Dim objWs As cl.presidencia.interop.Interoperable
        'objWs = New cl.presidencia.interop.Interoperable
        'Dim usuario As String = Configuration.ConfigurationSettings.AppSettings.Get("usuarioCargaSIAGF")
        'Dim password As String = Configuration.ConfigurationSettings.AppSettings.Get("passwordCargaSIAGF")
        'Dim codigoEntidad As String = Configuration.ConfigurationSettings.AppSettings.Get("codigoEntidadSIAGF")

        'objWs.autenticacionSIAGF(codigoEntidad, usuario, password)
    End Sub

    Private Sub btnFirmaLiquidacion_Click(sender As System.Object, e As System.EventArgs) Handles btnFirmaLiquidacion.Click
        Dim frm As New _frmFiltroLiquidaciones(True)
        frm.Show()
    End Sub
End Class
