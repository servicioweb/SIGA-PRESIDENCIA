Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data.SqlClient

Public Class frmPagoLicenciaMedica
    Inherits System.Windows.Forms.Form
    Private Shared _Form As frmPagoLicenciaMedica = Nothing

    Public Shared Property DefInstance() As frmPagoLicenciaMedica
        Get
            If _Form Is Nothing OrElse _Form.IsDisposed Then
                _Form = New frmPagoLicenciaMedica
            Else
                _Form.BringToFront()
            End If
            Return _Form
        End Get

        Set(ByVal value As frmPagoLicenciaMedica)
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
    Friend WithEvents txtNumeroLicenciaMedica As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblNumeroLicenciaMedica As System.Windows.Forms.Label
    Friend WithEvents txtTipoLicenciaMedica As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDias As System.Windows.Forms.Label
    Friend WithEvents lblFechaTermino As System.Windows.Forms.Label
    Friend WithEvents txtDias As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpcDetallePago As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtMontoPagado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumeroCheque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dteFechaDigitacion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFechaDigitacion As System.Windows.Forms.Label
    Friend WithEvents lblMemorandum As System.Windows.Forms.Label
    Friend WithEvents lblNumeroCheque As System.Windows.Forms.Label
    Friend WithEvents lblMontoPagado As System.Windows.Forms.Label
    Friend WithEvents txtMemorandum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rdgEstadoLicencia As DevExpress.XtraEditors.RadioGroup
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtNumeroLicenciaMedica = New DevExpress.XtraEditors.TextEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.rdgEstadoLicencia = New DevExpress.XtraEditors.RadioGroup
        Me.lblDias = New System.Windows.Forms.Label
        Me.lblNumeroLicenciaMedica = New System.Windows.Forms.Label
        Me.txtTipoLicenciaMedica = New DevExpress.XtraEditors.TextEdit
        Me.txtDias = New DevExpress.XtraEditors.TextEdit
        Me.txtMemorandum = New DevExpress.XtraEditors.TextEdit
        Me.txtMontoPagado = New DevExpress.XtraEditors.TextEdit
        Me.txtNumeroCheque = New DevExpress.XtraEditors.TextEdit
        Me.txtObservaciones = New DevExpress.XtraEditors.TextEdit
        Me.dteFechaDigitacion = New DevExpress.XtraEditors.DateEdit
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.gpcDetallePago = New DevExpress.XtraEditors.GroupControl
        Me.lblMontoPagado = New System.Windows.Forms.Label
        Me.lblNumeroCheque = New System.Windows.Forms.Label
        Me.lblFechaDigitacion = New System.Windows.Forms.Label
        Me.lblMemorandum = New System.Windows.Forms.Label
        Me.lblFechaTermino = New System.Windows.Forms.Label
        CType(Me.txtNumeroLicenciaMedica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.rdgEstadoLicencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoLicenciaMedica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMemorandum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoPagado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroCheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaDigitacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDetallePago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDetallePago.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNumeroLicenciaMedica
        '
        Me.txtNumeroLicenciaMedica.Location = New System.Drawing.Point(176, 32)
        Me.txtNumeroLicenciaMedica.Name = "txtNumeroLicenciaMedica"
        '
        'txtNumeroLicenciaMedica.Properties
        '
        Me.txtNumeroLicenciaMedica.Properties.ReadOnly = True
        Me.txtNumeroLicenciaMedica.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.rdgEstadoLicencia)
        Me.GroupControl1.Controls.Add(Me.lblDias)
        Me.GroupControl1.Controls.Add(Me.lblNumeroLicenciaMedica)
        Me.GroupControl1.Controls.Add(Me.txtNumeroLicenciaMedica)
        Me.GroupControl1.Controls.Add(Me.txtTipoLicenciaMedica)
        Me.GroupControl1.Controls.Add(Me.txtDias)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 16)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(664, 96)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Datos Licencia Médica"
        '
        'rdgEstadoLicencia
        '
        Me.rdgEstadoLicencia.Location = New System.Drawing.Point(296, 56)
        Me.rdgEstadoLicencia.Name = "rdgEstadoLicencia"
        '
        'rdgEstadoLicencia.Properties
        '
        Me.rdgEstadoLicencia.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Pendiente"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Pagada"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Rechazada"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Sin Pago")})
        Me.rdgEstadoLicencia.Size = New System.Drawing.Size(304, 32)
        Me.rdgEstadoLicencia.TabIndex = 7
        '
        'lblDias
        '
        Me.lblDias.Location = New System.Drawing.Point(72, 56)
        Me.lblDias.Name = "lblDias"
        Me.lblDias.Size = New System.Drawing.Size(96, 16)
        Me.lblDias.TabIndex = 4
        Me.lblDias.Text = "Días de Licencia"
        Me.lblDias.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNumeroLicenciaMedica
        '
        Me.lblNumeroLicenciaMedica.Location = New System.Drawing.Point(32, 32)
        Me.lblNumeroLicenciaMedica.Name = "lblNumeroLicenciaMedica"
        Me.lblNumeroLicenciaMedica.Size = New System.Drawing.Size(136, 16)
        Me.lblNumeroLicenciaMedica.TabIndex = 0
        Me.lblNumeroLicenciaMedica.Text = "Número Licencia Médica"
        Me.lblNumeroLicenciaMedica.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTipoLicenciaMedica
        '
        Me.txtTipoLicenciaMedica.Location = New System.Drawing.Point(296, 32)
        Me.txtTipoLicenciaMedica.Name = "txtTipoLicenciaMedica"
        '
        'txtTipoLicenciaMedica.Properties
        '
        Me.txtTipoLicenciaMedica.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTipoLicenciaMedica.Properties.Appearance.Options.UseFont = True
        Me.txtTipoLicenciaMedica.Properties.ReadOnly = True
        Me.txtTipoLicenciaMedica.Size = New System.Drawing.Size(336, 20)
        Me.txtTipoLicenciaMedica.TabIndex = 2
        '
        'txtDias
        '
        Me.txtDias.Location = New System.Drawing.Point(176, 56)
        Me.txtDias.Name = "txtDias"
        '
        'txtDias.Properties
        '
        Me.txtDias.Properties.ReadOnly = True
        Me.txtDias.TabIndex = 5
        '
        'txtMemorandum
        '
        Me.txtMemorandum.Location = New System.Drawing.Point(176, 104)
        Me.txtMemorandum.Name = "txtMemorandum"
        '
        'txtMemorandum.Properties
        '
        Me.txtMemorandum.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemorandum.Properties.MaxLength = 100
        Me.txtMemorandum.Size = New System.Drawing.Size(456, 20)
        Me.txtMemorandum.TabIndex = 14
        '
        'txtMontoPagado
        '
        Me.txtMontoPagado.Location = New System.Drawing.Point(176, 80)
        Me.txtMontoPagado.Name = "txtMontoPagado"
        '
        'txtMontoPagado.Properties
        '
        Me.txtMontoPagado.Properties.Mask.EditMask = "n0"
        Me.txtMontoPagado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoPagado.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoPagado.TabIndex = 12
        '
        'txtNumeroCheque
        '
        Me.txtNumeroCheque.Location = New System.Drawing.Point(176, 56)
        Me.txtNumeroCheque.Name = "txtNumeroCheque"
        Me.txtNumeroCheque.TabIndex = 10
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(176, 128)
        Me.txtObservaciones.Name = "txtObservaciones"
        '
        'txtObservaciones.Properties
        '
        Me.txtObservaciones.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Properties.MaxLength = 100
        Me.txtObservaciones.Size = New System.Drawing.Size(456, 20)
        Me.txtObservaciones.TabIndex = 16
        '
        'dteFechaDigitacion
        '
        Me.dteFechaDigitacion.EditValue = New Date(2007, 2, 8, 17, 46, 24, 0)
        Me.dteFechaDigitacion.Enabled = False
        Me.dteFechaDigitacion.Location = New System.Drawing.Point(176, 32)
        Me.dteFechaDigitacion.Name = "dteFechaDigitacion"
        '
        'dteFechaDigitacion.Properties
        '
        Me.dteFechaDigitacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaDigitacion.Properties.ReadOnly = True
        Me.dteFechaDigitacion.TabIndex = 8
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(240, 304)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "&Guardar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(336, 304)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "&Eliminar"
        '
        'gpcDetallePago
        '
        Me.gpcDetallePago.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDetallePago.AppearanceCaption.Options.UseFont = True
        Me.gpcDetallePago.Controls.Add(Me.lblMontoPagado)
        Me.gpcDetallePago.Controls.Add(Me.lblNumeroCheque)
        Me.gpcDetallePago.Controls.Add(Me.lblFechaDigitacion)
        Me.gpcDetallePago.Controls.Add(Me.txtMontoPagado)
        Me.gpcDetallePago.Controls.Add(Me.txtNumeroCheque)
        Me.gpcDetallePago.Controls.Add(Me.dteFechaDigitacion)
        Me.gpcDetallePago.Controls.Add(Me.txtObservaciones)
        Me.gpcDetallePago.Controls.Add(Me.txtMemorandum)
        Me.gpcDetallePago.Controls.Add(Me.lblMemorandum)
        Me.gpcDetallePago.Controls.Add(Me.lblFechaTermino)
        Me.gpcDetallePago.Location = New System.Drawing.Point(8, 120)
        Me.gpcDetallePago.Name = "gpcDetallePago"
        Me.gpcDetallePago.Size = New System.Drawing.Size(664, 168)
        Me.gpcDetallePago.TabIndex = 13
        Me.gpcDetallePago.Text = "Detalle del Pago"
        '
        'lblMontoPagado
        '
        Me.lblMontoPagado.Location = New System.Drawing.Point(48, 84)
        Me.lblMontoPagado.Name = "lblMontoPagado"
        Me.lblMontoPagado.Size = New System.Drawing.Size(120, 16)
        Me.lblMontoPagado.TabIndex = 11
        Me.lblMontoPagado.Text = "Monto Pagado"
        Me.lblMontoPagado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNumeroCheque
        '
        Me.lblNumeroCheque.Location = New System.Drawing.Point(48, 60)
        Me.lblNumeroCheque.Name = "lblNumeroCheque"
        Me.lblNumeroCheque.Size = New System.Drawing.Size(120, 16)
        Me.lblNumeroCheque.TabIndex = 9
        Me.lblNumeroCheque.Text = "Número de Cheque"
        Me.lblNumeroCheque.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFechaDigitacion
        '
        Me.lblFechaDigitacion.Location = New System.Drawing.Point(72, 36)
        Me.lblFechaDigitacion.Name = "lblFechaDigitacion"
        Me.lblFechaDigitacion.Size = New System.Drawing.Size(96, 16)
        Me.lblFechaDigitacion.TabIndex = 7
        Me.lblFechaDigitacion.Text = "Fecha Digitacion"
        Me.lblFechaDigitacion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMemorandum
        '
        Me.lblMemorandum.Location = New System.Drawing.Point(88, 108)
        Me.lblMemorandum.Name = "lblMemorandum"
        Me.lblMemorandum.Size = New System.Drawing.Size(80, 16)
        Me.lblMemorandum.TabIndex = 13
        Me.lblMemorandum.Text = "Memorandum "
        Me.lblMemorandum.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFechaTermino
        '
        Me.lblFechaTermino.Location = New System.Drawing.Point(80, 132)
        Me.lblFechaTermino.Name = "lblFechaTermino"
        Me.lblFechaTermino.Size = New System.Drawing.Size(88, 16)
        Me.lblFechaTermino.TabIndex = 15
        Me.lblFechaTermino.Text = "Observaciones"
        Me.lblFechaTermino.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmPagoLicenciaMedica
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 342)
        Me.Controls.Add(Me.gpcDetallePago)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frmPagoLicenciaMedica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Pago Licencia Médica"
        CType(Me.txtNumeroLicenciaMedica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.rdgEstadoLicencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoLicenciaMedica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMemorandum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoPagado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroCheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaDigitacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDetallePago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDetallePago.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    
    Public tipoLicencia As String
    Public empleadoLicMed As New Empleado
    Public retorno As Boolean = False

    Private Sub frmPagoLicenciaMedica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNumeroLicenciaMedica.Text = empleadoLicMed.datosLicenciaMedica.numeroLicencia
        txtTipoLicenciaMedica.Text = tipoLicencia
        txtDias.Text = empleadoLicMed.datosLicenciaMedica.diasLicencia
        rdgEstadoLicencia.EditValue = empleadoLicMed.datosLicenciaMedica.estadoLicencia
        If empleadoLicMed.datosLicenciaMedica.fechaDigitacionPago = "01-01-1900" Then
            dteFechaDigitacion.EditValue = Date.Today
        Else
            dteFechaDigitacion.EditValue = empleadoLicMed.datosLicenciaMedica.fechaDigitacionPago
        End If
        'If empleadoLicMed.datosLicenciaMedica.estadoLicencia = 0 Then
        '    txtEstadoLicenciaMedica.Text = "PENDIENTE"
        'Else
        '    txtEstadoLicenciaMedica.Text = "PAGADA"
        'End If
        If txtNumeroCheque.Text = "" And txtMontoPagado.Text = "" Then
            btnEliminar.Enabled = True
        Else
            btnEliminar.Enabled = False
        End If
        txtNumeroCheque.Text = empleadoLicMed.datosLicenciaMedica.numeroCheque
        txtMontoPagado.Text = empleadoLicMed.datosLicenciaMedica.montoCheque
        txtMemorandum.Text = empleadoLicMed.datosLicenciaMedica.momorandum
        txtObservaciones.Text = empleadoLicMed.datosLicenciaMedica.observaciones
        txtNumeroCheque.Focus()
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If txtNumeroCheque.Text = "" Or txtMontoPagado.Text = "" Then
            If rdgEstadoLicencia.SelectedIndex = 0 Then
                empleadoLicMed.datosLicenciaMedica.numeroCheque = ""
                empleadoLicMed.datosLicenciaMedica.montoCheque = 0
                empleadoLicMed.datosLicenciaMedica.momorandum = ""
                empleadoLicMed.datosLicenciaMedica.observaciones = ""
                empleadoLicMed.datosLicenciaMedica.fechaDigitacionPago = CType("01-01-1900", Date)
                empleadoLicMed.datosLicenciaMedica.estadoLicencia = 0
                'txtEstadoLicenciaMedica.Text = "PENDIENTE"
            End If
            Try
                empleadoLicMed.actualizarDatosLicenciaMedica(empleadoLicMed.datosLicenciaMedica)
                'btnGuardar.Enabled = False
                'btnEliminar.Enabled = False
                retorno = True
                MsgBox("El registro fue actualizado satisfactoriamente", MsgBoxStyle.Information)
                frmPagoLicenciaMedica.DefInstance.Close()
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al actualizar el registro" & " " & ex.Message, MsgBoxStyle.Exclamation)
                retorno = False
            End Try
            'MsgBox("No ha ingresado número cheque o monto pagado", MsgBoxStyle.Exclamation)
        Else
            If (MessageBox.Show("Al guardar, el estado del registro será cambiado a pagado. ¿Continua?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                empleadoLicMed.datosLicenciaMedica.numeroCheque = txtNumeroCheque.Text
                empleadoLicMed.datosLicenciaMedica.montoCheque = CType(txtMontoPagado.Text, Integer)
                empleadoLicMed.datosLicenciaMedica.momorandum = txtMemorandum.Text
                empleadoLicMed.datosLicenciaMedica.observaciones = txtObservaciones.Text
                empleadoLicMed.datosLicenciaMedica.fechaDigitacionPago = dteFechaDigitacion.EditValue
                empleadoLicMed.datosLicenciaMedica.estadoLicencia = 1
                'txtEstadoLicenciaMedica.Text = "PAGADA"
                Try
                    empleadoLicMed.actualizarDatosLicenciaMedica(empleadoLicMed.datosLicenciaMedica)
                    'btnGuardar.Enabled = False
                    'btnEliminar.Enabled = False
                    retorno = True
                    MsgBox("El registro fue actualizado satisfactoriamente", MsgBoxStyle.Information)
                    frmPagoLicenciaMedica.DefInstance.Close()
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al actualizar el registro" & " " & ex.Message, MsgBoxStyle.Exclamation)
                    retorno = False
                End Try
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If (MessageBox.Show("Si elimina el registro quedará pendiente de pago. ¿Continua?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
            empleadoLicMed.datosLicenciaMedica.numeroCheque = ""
            empleadoLicMed.datosLicenciaMedica.montoCheque = CType(0, Integer)
            empleadoLicMed.datosLicenciaMedica.momorandum = ""
            empleadoLicMed.datosLicenciaMedica.observaciones = ""
            empleadoLicMed.datosLicenciaMedica.fechaDigitacionPago = CType("01-01-1900", Date)
            empleadoLicMed.datosLicenciaMedica.estadoLicencia = 0
            'txtEstadoLicenciaMedica.Text = "PENDIENTE"
            Try
                empleadoLicMed.actualizarDatosLicenciaMedica(empleadoLicMed.datosLicenciaMedica)
                btnGuardar.Enabled = False
                btnEliminar.Enabled = False
                retorno = True
                MsgBox("El registro fue eliminado satisfactoriamente", MsgBoxStyle.Information)
                frmPagoLicenciaMedica.DefInstance.Close()
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al eliminar el registro" & " " & ex.Message, MsgBoxStyle.Exclamation)
                retorno = False
            End Try
        End If
    End Sub

    Private Sub rdgEstadoLicencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgEstadoLicencia.SelectedIndexChanged

    End Sub

    Private Sub rdgEstadoLicencia_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdgEstadoLicencia.EditValueChanged
        If rdgEstadoLicencia.SelectedIndex = 0 Then
            Me.dteFechaDigitacion.EditValue = ""
            Me.txtNumeroCheque.Text = ""
            Me.txtMontoPagado.Text = ""
            Me.txtMemorandum.Text = ""
            Me.txtObservaciones.Text = ""

        End If
        'If rdgEstadoLicencia.SelectedIndex = 1 Then
        '    empleadoLicMed.datosLicenciaMedica.numeroCheque = txtNumeroCheque.Text
        '    empleadoLicMed.datosLicenciaMedica.montoCheque = CType(txtMontoPagado.Text, Integer)
        '    empleadoLicMed.datosLicenciaMedica.momorandum = txtMemorandum.Text
        '    empleadoLicMed.datosLicenciaMedica.observaciones = txtObservaciones.Text
        '    empleadoLicMed.datosLicenciaMedica.fechaDigitacionPago = dteFechaDigitacion.EditValue
        '    empleadoLicMed.datosLicenciaMedica.estadoLicencia = 1
        '    txtEstadoLicenciaMedica.Text = "PAGADA"
        'End If
    End Sub
End Class
