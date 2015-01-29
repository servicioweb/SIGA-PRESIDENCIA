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

Public Class frmSaldoDiasFeriadoLegal
    Inherits System.Windows.Forms.Form
    Private Shared _Form As frmSaldoDiasFeriadoLegal = Nothing

    Public Shared Property DefInstance() As frmSaldoDiasFeriadoLegal
        Get
            If _Form Is Nothing OrElse _Form.IsDisposed Then
                _Form = New frmSaldoDiasFeriadoLegal
            Else
                _Form.BringToFront()
            End If
            Return _Form
        End Get

        Set(ByVal value As frmSaldoDiasFeriadoLegal)
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
    Friend WithEvents lblTotalDiasAnual As System.Windows.Forms.Label
    Friend WithEvents lblDiasAdicionales As System.Windows.Forms.Label
    Friend WithEvents lblDiasPeriodoAnterior As System.Windows.Forms.Label
    Friend WithEvents lblDiasHabiles As System.Windows.Forms.Label
    Friend WithEvents txtSaldoDiasHabiles As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldoDiasAdicionales As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldoDiasPeriodoAnterior As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldoDiasPendiente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldoTotalDiasSolicitados As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldoTotalDiasAnual As DevExpress.XtraEditors.TextEdit
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
        Me.lblTotalDiasAnual = New System.Windows.Forms.Label
        Me.txtSaldoTotalDiasAnual = New DevExpress.XtraEditors.TextEdit
        Me.lblDiasAdicionales = New System.Windows.Forms.Label
        Me.txtSaldoDiasAdicionales = New DevExpress.XtraEditors.TextEdit
        Me.lblDiasPeriodoAnterior = New System.Windows.Forms.Label
        Me.txtSaldoDiasPeriodoAnterior = New DevExpress.XtraEditors.TextEdit
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
        CType(Me.txtSaldoTotalDiasAnual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoDiasAdicionales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoDiasPeriodoAnterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gpcInformacionDias.Controls.Add(Me.lblTotalDiasAnual)
        Me.gpcInformacionDias.Controls.Add(Me.txtSaldoTotalDiasAnual)
        Me.gpcInformacionDias.Controls.Add(Me.lblDiasAdicionales)
        Me.gpcInformacionDias.Controls.Add(Me.txtSaldoDiasAdicionales)
        Me.gpcInformacionDias.Controls.Add(Me.lblDiasPeriodoAnterior)
        Me.gpcInformacionDias.Controls.Add(Me.txtSaldoDiasPeriodoAnterior)
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
        Me.lblDiasPendiente.Location = New System.Drawing.Point(352, 86)
        Me.lblDiasPendiente.Name = "lblDiasPendiente"
        Me.lblDiasPendiente.Size = New System.Drawing.Size(136, 16)
        Me.lblDiasPendiente.TabIndex = 14
        Me.lblDiasPendiente.Text = "Días Pendientes"
        Me.lblDiasPendiente.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSaldoDiasPendiente
        '
        Me.txtSaldoDiasPendiente.Enabled = False
        Me.txtSaldoDiasPendiente.Location = New System.Drawing.Point(504, 82)
        Me.txtSaldoDiasPendiente.Name = "txtSaldoDiasPendiente"
        '
        'txtSaldoDiasPendiente.Properties
        '
        Me.txtSaldoDiasPendiente.Properties.ReadOnly = True
        Me.txtSaldoDiasPendiente.TabIndex = 13
        '
        'lblTotalDiasSolicitados
        '
        Me.lblTotalDiasSolicitados.Location = New System.Drawing.Point(352, 62)
        Me.lblTotalDiasSolicitados.Name = "lblTotalDiasSolicitados"
        Me.lblTotalDiasSolicitados.Size = New System.Drawing.Size(136, 16)
        Me.lblTotalDiasSolicitados.TabIndex = 12
        Me.lblTotalDiasSolicitados.Text = "Total Días Solicitados"
        Me.lblTotalDiasSolicitados.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSaldoTotalDiasSolicitados
        '
        Me.txtSaldoTotalDiasSolicitados.Enabled = False
        Me.txtSaldoTotalDiasSolicitados.Location = New System.Drawing.Point(504, 58)
        Me.txtSaldoTotalDiasSolicitados.Name = "txtSaldoTotalDiasSolicitados"
        '
        'txtSaldoTotalDiasSolicitados.Properties
        '
        Me.txtSaldoTotalDiasSolicitados.Properties.ReadOnly = True
        Me.txtSaldoTotalDiasSolicitados.TabIndex = 11
        '
        'lblTotalDiasAnual
        '
        Me.lblTotalDiasAnual.Location = New System.Drawing.Point(352, 38)
        Me.lblTotalDiasAnual.Name = "lblTotalDiasAnual"
        Me.lblTotalDiasAnual.Size = New System.Drawing.Size(136, 16)
        Me.lblTotalDiasAnual.TabIndex = 10
        Me.lblTotalDiasAnual.Text = "Total Anual Feriado Legal"
        Me.lblTotalDiasAnual.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSaldoTotalDiasAnual
        '
        Me.txtSaldoTotalDiasAnual.Enabled = False
        Me.txtSaldoTotalDiasAnual.Location = New System.Drawing.Point(504, 34)
        Me.txtSaldoTotalDiasAnual.Name = "txtSaldoTotalDiasAnual"
        '
        'txtSaldoTotalDiasAnual.Properties
        '
        Me.txtSaldoTotalDiasAnual.Properties.ReadOnly = True
        Me.txtSaldoTotalDiasAnual.TabIndex = 9
        '
        'lblDiasAdicionales
        '
        Me.lblDiasAdicionales.Location = New System.Drawing.Point(16, 84)
        Me.lblDiasAdicionales.Name = "lblDiasAdicionales"
        Me.lblDiasAdicionales.Size = New System.Drawing.Size(136, 16)
        Me.lblDiasAdicionales.TabIndex = 8
        Me.lblDiasAdicionales.Text = "Días Adicionales"
        Me.lblDiasAdicionales.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSaldoDiasAdicionales
        '
        Me.txtSaldoDiasAdicionales.EnterMoveNextControl = True
        Me.txtSaldoDiasAdicionales.Location = New System.Drawing.Point(168, 80)
        Me.txtSaldoDiasAdicionales.Name = "txtSaldoDiasAdicionales"
        Me.txtSaldoDiasAdicionales.TabIndex = 7
        '
        'lblDiasPeriodoAnterior
        '
        Me.lblDiasPeriodoAnterior.Location = New System.Drawing.Point(16, 60)
        Me.lblDiasPeriodoAnterior.Name = "lblDiasPeriodoAnterior"
        Me.lblDiasPeriodoAnterior.Size = New System.Drawing.Size(136, 16)
        Me.lblDiasPeriodoAnterior.TabIndex = 6
        Me.lblDiasPeriodoAnterior.Text = "Días Período Anterior"
        Me.lblDiasPeriodoAnterior.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSaldoDiasPeriodoAnterior
        '
        Me.txtSaldoDiasPeriodoAnterior.EnterMoveNextControl = True
        Me.txtSaldoDiasPeriodoAnterior.Location = New System.Drawing.Point(168, 56)
        Me.txtSaldoDiasPeriodoAnterior.Name = "txtSaldoDiasPeriodoAnterior"
        Me.txtSaldoDiasPeriodoAnterior.TabIndex = 5
        '
        'lblDiasHabiles
        '
        Me.lblDiasHabiles.Location = New System.Drawing.Point(16, 36)
        Me.lblDiasHabiles.Name = "lblDiasHabiles"
        Me.lblDiasHabiles.Size = New System.Drawing.Size(136, 16)
        Me.lblDiasHabiles.TabIndex = 4
        Me.lblDiasHabiles.Text = "Días Anual Feriado Legal"
        Me.lblDiasHabiles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSaldoDiasHabiles
        '
        Me.txtSaldoDiasHabiles.EnterMoveNextControl = True
        Me.txtSaldoDiasHabiles.Location = New System.Drawing.Point(168, 32)
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
        'frmSaldoDiasFeriadoLegal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(808, 278)
        Me.Controls.Add(Me.gpcInformacionDias)
        Me.Controls.Add(Me.gpcDatosEmpleado)
        Me.MaximizeBox = False
        Me.Name = "frmSaldoDiasFeriadoLegal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saldo de Dias Feriado Legal"
        CType(Me.gpcDatosEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatosEmpleado.ResumeLayout(False)
        CType(Me.txtNombreEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcInformacionDias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcInformacionDias.ResumeLayout(False)
        CType(Me.txtSaldoDiasPendiente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoTotalDiasSolicitados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoTotalDiasAnual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoDiasAdicionales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoDiasPeriodoAnterior.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoDiasHabiles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public empleado As New empleado
    Public tipoEventoAdmin As Integer
    Public totalDiasAnual As Integer

    Private Sub frmSaldoDiasFeriadoLegal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNombreEmpleado.Text = empleado.nombreCompleto
        empleado.datosSaldoDiasEventoAdmin.eventoAdminSaldoID = 0
        If empleado.recuperaSaldoDiasEmpleadoEventoAdmin(empleado.ID, tipoEventoAdmin, CType(txtAnno.Text, Integer)) Then
            asignaControles()
            gpcInformacionDias.Enabled = True
        Else
            inicializaControles()
            gpcInformacionDias.Enabled = True
        End If
    End Sub
    Private Sub txtDiasHabiles_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSaldoDiasHabiles.EditValueChanged
        calculaSaldoDias()
    End Sub

    Private Sub txtDiasAdicionales_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSaldoDiasAdicionales.EditValueChanged
        calculaSaldoDias()
    End Sub

    Private Sub txtDiasPeriodoAnterior_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSaldoDiasPeriodoAnterior.EditValueChanged
        calculaSaldoDias()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If MsgBox("¿Está usted seguro de guardar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            asignaEstructura()
            If empleado.datosSaldoDiasEventoAdmin.eventoAdminSaldoID = 0 Then
                empleado.datosSaldoDiasEventoAdmin.eventoAdminSaldoID = empleado.CrearEmpleadoSaldoDiasEventoAdmin()
                MsgBox("El registro fue guardado correctamente", MsgBoxStyle.Information, "Siga")
            Else
                Try
                    empleado.actualizarSaldoDiasEventoAdmin()
                    MsgBox("Registro fue actualizado correctamente", MsgBoxStyle.Information, "Siga")
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al intentar actualizar el registro. " & Chr(13) & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
        End If
    End Sub
    Private Sub asignaEstructura()
        empleado.datosSaldoDiasEventoAdmin.diasPeriodo = CType(txtSaldoDiasHabiles.Text, Decimal)
        empleado.datosSaldoDiasEventoAdmin.diasPeriodoAnterior = CType(txtSaldoDiasPeriodoAnterior.Text, Decimal)
        empleado.datosSaldoDiasEventoAdmin.diasAdicionales = CType(txtSaldoDiasAdicionales.Text, Decimal)
        empleado.datosSaldoDiasEventoAdmin.totalDiasAnual = CType(txtSaldoTotalDiasAnual.Text, Decimal)
        empleado.datosSaldoDiasEventoAdmin.totalDiasSolicitados = CType(txtSaldoTotalDiasSolicitados.Text, Decimal)
        empleado.datosSaldoDiasEventoAdmin.diasPendiente = CType(txtSaldoDiasPendiente.Text, Decimal)
        empleado.datosSaldoDiasEventoAdmin.empleadoID = empleado.ID
        empleado.datosSaldoDiasEventoAdmin.anoProceso = CType(txtAnno.Text, Integer)
        empleado.datosSaldoDiasEventoAdmin.tipoEventoAdminID = tipoEventoAdmin
    End Sub
    Private Sub asignaControles()
        txtSaldoDiasHabiles.EditValue = CType(empleado.datosSaldoDiasEventoAdmin.diasPeriodo, Decimal)
        txtSaldoDiasPeriodoAnterior.EditValue = CType(empleado.datosSaldoDiasEventoAdmin.diasPeriodoAnterior, Decimal)
        txtSaldoDiasAdicionales.EditValue = CType(empleado.datosSaldoDiasEventoAdmin.diasAdicionales, Decimal)
        txtSaldoTotalDiasAnual.EditValue = CType(empleado.datosSaldoDiasEventoAdmin.totalDiasAnual, Decimal)
        txtSaldoTotalDiasSolicitados.EditValue = CType(empleado.datosSaldoDiasEventoAdmin.totalDiasSolicitados, Decimal)
        txtSaldoDiasPendiente.EditValue = CType(empleado.datosSaldoDiasEventoAdmin.diasPendiente, Decimal)
    End Sub
    Private Sub inicializaControles()
        Me.txtSaldoDiasHabiles.EditValue = totalDiasAnual
        Me.txtSaldoDiasPeriodoAnterior.EditValue = 0
        Me.txtSaldoDiasAdicionales.EditValue = 0
        Me.txtSaldoTotalDiasSolicitados.EditValue = 0
        Me.txtSaldoDiasPendiente.EditValue = 0
    End Sub
    Private Sub calculaSaldoDias()
        txtSaldoTotalDiasAnual.Text = CType(txtSaldoDiasHabiles.EditValue, Decimal) + CType(txtSaldoDiasAdicionales.EditValue, Decimal) + CType(txtSaldoDiasPeriodoAnterior.EditValue, Decimal)
        txtSaldoDiasPendiente.Text = CType(txtSaldoTotalDiasAnual.EditValue, Decimal) - CType(txtSaldoTotalDiasSolicitados.EditValue, Decimal)
        If CType(txtSaldoTotalDiasAnual.Text, Decimal) > 0 Then
            btnGuardar.Enabled = True
        Else
            btnGuardar.Enabled = False
        End If
    End Sub
End Class
