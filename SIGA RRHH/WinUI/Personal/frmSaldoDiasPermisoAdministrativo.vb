Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data.Common.DbDataAdapter

Public Class frmSaldoDiasPermisoAdministrativo
    Inherits System.Windows.Forms.Form
    Private Shared _Form As frmSaldoDiasPermisoAdministrativo = Nothing

    Public Shared Property DefInstance() As frmSaldoDiasPermisoAdministrativo
        Get
            If _Form Is Nothing OrElse _Form.IsDisposed Then
                _Form = New frmSaldoDiasPermisoAdministrativo
            Else
                _Form.BringToFront()
            End If
            Return _Form
        End Get

        Set(ByVal value As frmSaldoDiasPermisoAdministrativo)
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
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents txtNombreEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAnno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpcDatosEmpleado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gpcInformacionDias As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblDiasPendiente As System.Windows.Forms.Label
    Friend WithEvents lblTotalDiasSolicitados As System.Windows.Forms.Label
    Friend WithEvents lblDiasHabiles As System.Windows.Forms.Label
    Friend WithEvents txtSaldoDiasHabiles As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldoDiasPendiente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldoTotalDiasSolicitados As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpcDatosEmpleado = New DevExpress.XtraEditors.GroupControl
        Me.txtNombreEmpleado = New DevExpress.XtraEditors.TextEdit
        Me.txtAnno = New DevExpress.XtraEditors.TextEdit
        Me.lblEmpleado = New System.Windows.Forms.Label
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.gpcInformacionDias = New DevExpress.XtraEditors.GroupControl
        Me.lblDiasPendiente = New System.Windows.Forms.Label
        Me.txtSaldoDiasPendiente = New DevExpress.XtraEditors.TextEdit
        Me.lblTotalDiasSolicitados = New System.Windows.Forms.Label
        Me.txtSaldoTotalDiasSolicitados = New DevExpress.XtraEditors.TextEdit
        Me.lblDiasHabiles = New System.Windows.Forms.Label
        Me.txtSaldoDiasHabiles = New DevExpress.XtraEditors.TextEdit
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.gpcDatosEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDatosEmpleado.SuspendLayout()
        CType(Me.txtNombreEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcInformacionDias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcInformacionDias.SuspendLayout()
        CType(Me.txtSaldoDiasPendiente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoTotalDiasSolicitados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoDiasHabiles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcDatosEmpleado
        '
        Me.gpcDatosEmpleado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDatosEmpleado.AppearanceCaption.Options.UseFont = True
        Me.gpcDatosEmpleado.Controls.Add(Me.txtNombreEmpleado)
        Me.gpcDatosEmpleado.Controls.Add(Me.txtAnno)
        Me.gpcDatosEmpleado.Controls.Add(Me.lblEmpleado)
        Me.gpcDatosEmpleado.Controls.Add(Me.lblPeriodo)
        Me.gpcDatosEmpleado.Location = New System.Drawing.Point(8, 8)
        Me.gpcDatosEmpleado.Name = "gpcDatosEmpleado"
        Me.gpcDatosEmpleado.Size = New System.Drawing.Size(792, 104)
        Me.gpcDatosEmpleado.TabIndex = 0
        Me.gpcDatosEmpleado.Text = "Datos Empleado"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreEmpleado.Enabled = False
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(112, 64)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(488, 20)
        Me.txtNombreEmpleado.TabIndex = 9
        '
        'txtAnno
        '
        Me.txtAnno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAnno.Enabled = False
        Me.txtAnno.Location = New System.Drawing.Point(112, 32)
        Me.txtAnno.Name = "txtAnno"
        Me.txtAnno.Size = New System.Drawing.Size(88, 20)
        Me.txtAnno.TabIndex = 2
        '
        'lblEmpleado
        '
        Me.lblEmpleado.Location = New System.Drawing.Point(32, 68)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(64, 16)
        Me.lblEmpleado.TabIndex = 3
        Me.lblEmpleado.Text = "Empleado"
        Me.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(48, 36)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 16)
        Me.lblPeriodo.TabIndex = 1
        Me.lblPeriodo.Text = "Año"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gpcInformacionDias
        '
        Me.gpcInformacionDias.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcInformacionDias.AppearanceCaption.Options.UseFont = True
        Me.gpcInformacionDias.Controls.Add(Me.lblDiasPendiente)
        Me.gpcInformacionDias.Controls.Add(Me.txtSaldoDiasPendiente)
        Me.gpcInformacionDias.Controls.Add(Me.lblTotalDiasSolicitados)
        Me.gpcInformacionDias.Controls.Add(Me.txtSaldoTotalDiasSolicitados)
        Me.gpcInformacionDias.Controls.Add(Me.lblDiasHabiles)
        Me.gpcInformacionDias.Controls.Add(Me.txtSaldoDiasHabiles)
        Me.gpcInformacionDias.Controls.Add(Me.btnGuardar)
        Me.gpcInformacionDias.Controls.Add(Me.btnCancelar)
        Me.gpcInformacionDias.Location = New System.Drawing.Point(8, 112)
        Me.gpcInformacionDias.Name = "gpcInformacionDias"
        Me.gpcInformacionDias.Size = New System.Drawing.Size(792, 160)
        Me.gpcInformacionDias.TabIndex = 2
        Me.gpcInformacionDias.Text = "Información de Días"
        '
        'lblDiasPendiente
        '
        Me.lblDiasPendiente.Location = New System.Drawing.Point(200, 86)
        Me.lblDiasPendiente.Name = "lblDiasPendiente"
        Me.lblDiasPendiente.Size = New System.Drawing.Size(136, 16)
        Me.lblDiasPendiente.TabIndex = 14
        Me.lblDiasPendiente.Text = "Días Pendientes"
        Me.lblDiasPendiente.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSaldoDiasPendiente
        '
        Me.txtSaldoDiasPendiente.Enabled = False
        Me.txtSaldoDiasPendiente.Location = New System.Drawing.Point(352, 82)
        Me.txtSaldoDiasPendiente.Name = "txtSaldoDiasPendiente"
        '
        'txtSaldoDiasPendiente.Properties
        '
        Me.txtSaldoDiasPendiente.Properties.ReadOnly = True
        Me.txtSaldoDiasPendiente.TabIndex = 13
        '
        'lblTotalDiasSolicitados
        '
        Me.lblTotalDiasSolicitados.Location = New System.Drawing.Point(200, 62)
        Me.lblTotalDiasSolicitados.Name = "lblTotalDiasSolicitados"
        Me.lblTotalDiasSolicitados.Size = New System.Drawing.Size(136, 16)
        Me.lblTotalDiasSolicitados.TabIndex = 12
        Me.lblTotalDiasSolicitados.Text = "Total Días Solicitados"
        Me.lblTotalDiasSolicitados.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSaldoTotalDiasSolicitados
        '
        Me.txtSaldoTotalDiasSolicitados.Enabled = False
        Me.txtSaldoTotalDiasSolicitados.Location = New System.Drawing.Point(352, 58)
        Me.txtSaldoTotalDiasSolicitados.Name = "txtSaldoTotalDiasSolicitados"
        '
        'txtSaldoTotalDiasSolicitados.Properties
        '
        Me.txtSaldoTotalDiasSolicitados.Properties.ReadOnly = True
        Me.txtSaldoTotalDiasSolicitados.TabIndex = 11
        '
        'lblDiasHabiles
        '
        Me.lblDiasHabiles.Location = New System.Drawing.Point(104, 36)
        Me.lblDiasHabiles.Name = "lblDiasHabiles"
        Me.lblDiasHabiles.Size = New System.Drawing.Size(224, 16)
        Me.lblDiasHabiles.TabIndex = 4
        Me.lblDiasHabiles.Text = "Días Anual Permiso Admininistrativo"
        Me.lblDiasHabiles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSaldoDiasHabiles
        '
        Me.txtSaldoDiasHabiles.EnterMoveNextControl = True
        Me.txtSaldoDiasHabiles.Location = New System.Drawing.Point(352, 32)
        Me.txtSaldoDiasHabiles.Name = "txtSaldoDiasHabiles"
        '
        'txtSaldoDiasHabiles.Properties
        '
        Me.txtSaldoDiasHabiles.Properties.DisplayFormat.FormatString = "0"
        Me.txtSaldoDiasHabiles.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoDiasHabiles.Properties.EditFormat.FormatString = "n0"
        Me.txtSaldoDiasHabiles.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoDiasHabiles.Properties.Mask.EditMask = "n0"
        Me.txtSaldoDiasHabiles.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSaldoDiasHabiles.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSaldoDiasHabiles.Properties.MaxLength = 2
        Me.txtSaldoDiasHabiles.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(232, 120)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(112, 23)
        Me.btnGuardar.TabIndex = 15
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(384, 120)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(112, 23)
        Me.btnCancelar.TabIndex = 16
        Me.btnCancelar.Text = "Cancelar"
        '
        'frmSaldoDiasPermisoAdministrativo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(808, 278)
        Me.Controls.Add(Me.gpcInformacionDias)
        Me.Controls.Add(Me.gpcDatosEmpleado)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSaldoDiasPermisoAdministrativo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saldo de Dias Permiso Administrativo"
        Me.TopMost = True
        CType(Me.gpcDatosEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatosEmpleado.ResumeLayout(False)
        CType(Me.txtNombreEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcInformacionDias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcInformacionDias.ResumeLayout(False)
        CType(Me.txtSaldoDiasPendiente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoTotalDiasSolicitados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoDiasHabiles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public empleado As New empleado
    Public tipoEventoAdmin As Integer
    Public totalDiasAnual As Integer

    Private Sub frmSaldoDiasFeriadoLegal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNombreEmpleado.Text = empleado.nombreCompleto
        If empleado.recuperaSaldoDiasEmpleadoEventoAdmin(empleado.ID, tipoEventoAdmin, CType(txtAnno.Text, Integer)) Then
            asignaControles()
            gpcInformacionDias.Enabled = False
        Else
            inicializaControles()
            gpcInformacionDias.Enabled = True
        End If
    End Sub
    Private Sub txtDiasHabiles_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSaldoDiasHabiles.EditValueChanged
        calculaSaldoDias()
    End Sub

    Private Sub txtDiasAdicionales_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        calculaSaldoDias()
    End Sub

    Private Sub txtDiasPeriodoAnterior_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        calculaSaldoDias()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If MsgBox("¿Está usted seguro de guardar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            asignaEstructura()
            Dim idEventoSaldoDias As Integer
            idEventoSaldoDias = empleado.CrearEmpleadoSaldoDiasEventoAdmin()
            If idEventoSaldoDias > 0 Then
                MsgBox("El registro fue guardadado correctamente", MsgBoxStyle.Information, "Siga")
                gpcInformacionDias.Enabled = False
            End If
        End If
    End Sub
    Private Sub asignaEstructura()
        empleado.datosSaldoDiasEventoAdmin.diasPeriodo = CType(txtSaldoDiasHabiles.Text, Decimal)
        empleado.datosSaldoDiasEventoAdmin.diasPeriodoAnterior = 0
        empleado.datosSaldoDiasEventoAdmin.diasAdicionales = 0
        empleado.datosSaldoDiasEventoAdmin.totalDiasAnual = CType(txtSaldoDiasHabiles.Text, Decimal)
        empleado.datosSaldoDiasEventoAdmin.totalDiasSolicitados = 0
        empleado.datosSaldoDiasEventoAdmin.diasPendiente = CType(txtSaldoDiasPendiente.Text, Decimal)
        empleado.datosSaldoDiasEventoAdmin.empleadoID = empleado.ID
        empleado.datosSaldoDiasEventoAdmin.anoProceso = CType(txtAnno.Text, Integer)
        empleado.datosSaldoDiasEventoAdmin.tipoEventoAdminID = tipoEventoAdmin
    End Sub
    Private Sub asignaControles()
        txtSaldoDiasHabiles.Text = CType(empleado.datosSaldoDiasEventoAdmin.diasPeriodo, Decimal)
        txtSaldoTotalDiasSolicitados.Text = CType(empleado.datosSaldoDiasEventoAdmin.totalDiasSolicitados, Decimal)
        txtSaldoDiasPendiente.Text = CType(empleado.datosSaldoDiasEventoAdmin.diasPendiente, Decimal)
    End Sub
    Private Sub inicializaControles()
        Me.txtSaldoDiasHabiles.EditValue = totalDiasAnual
        Me.txtSaldoTotalDiasSolicitados.EditValue = 0
        Me.txtSaldoDiasPendiente.EditValue = 0
    End Sub
    Private Sub calculaSaldoDias()     
        txtSaldoDiasPendiente.Text = CType(txtSaldoDiasHabiles.EditValue, Decimal) - CType(txtSaldoTotalDiasSolicitados.EditValue, Decimal)
        If CType(txtSaldoDiasPendiente.Text, Decimal) > 0 Then
            btnGuardar.Enabled = True
        Else
            btnGuardar.Enabled = False
        End If
    End Sub
End Class
