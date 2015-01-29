Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmCierreMensual
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
    Friend WithEvents gpcParametroMensual As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtnombrePeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents btnCierreMensual As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEstadoPeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dvConexiones As System.Data.DataView
    Friend WithEvents gleUsuariosConectados As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblUsuarios As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpcParametroMensual = New DevExpress.XtraEditors.GroupControl
        Me.lblUsuarios = New System.Windows.Forms.Label
        Me.gleUsuariosConectados = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.txtEstadoPeriodo = New DevExpress.XtraEditors.TextEdit
        Me.txtnombrePeriodo = New DevExpress.XtraEditors.TextEdit
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.btnCierreMensual = New DevExpress.XtraEditors.SimpleButton
        Me.dvConexiones = New System.Data.DataView
        CType(Me.gpcParametroMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcParametroMensual.SuspendLayout()
        CType(Me.gleUsuariosConectados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstadoPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnombrePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvConexiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcParametroMensual
        '
        Me.gpcParametroMensual.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcParametroMensual.AppearanceCaption.Options.UseFont = True
        Me.gpcParametroMensual.Controls.Add(Me.lblUsuarios)
        Me.gpcParametroMensual.Controls.Add(Me.gleUsuariosConectados)
        Me.gpcParametroMensual.Controls.Add(Me.txtEstadoPeriodo)
        Me.gpcParametroMensual.Controls.Add(Me.txtnombrePeriodo)
        Me.gpcParametroMensual.Controls.Add(Me.lblPeriodo)
        Me.gpcParametroMensual.Location = New System.Drawing.Point(16, 16)
        Me.gpcParametroMensual.Name = "gpcParametroMensual"
        Me.gpcParametroMensual.Size = New System.Drawing.Size(336, 192)
        Me.gpcParametroMensual.TabIndex = 11
        Me.gpcParametroMensual.Text = "Periodo Actual"
        '
        'lblUsuarios
        '
        Me.lblUsuarios.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblUsuarios.Location = New System.Drawing.Point(16, 124)
        Me.lblUsuarios.Name = "lblUsuarios"
        Me.lblUsuarios.Size = New System.Drawing.Size(112, 16)
        Me.lblUsuarios.TabIndex = 11
        Me.lblUsuarios.Text = "Usuarios Conectados"
        Me.lblUsuarios.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gleUsuariosConectados
        '
        Me.gleUsuariosConectados.EditValue = ""
        Me.gleUsuariosConectados.EnterMoveNextControl = True
        Me.gleUsuariosConectados.Location = New System.Drawing.Point(136, 120)
        Me.gleUsuariosConectados.Name = "gleUsuariosConectados"
        '
        'gleUsuariosConectados.Properties
        '
        Me.gleUsuariosConectados.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleUsuariosConectados.Properties.View = Me.GridLookUpEdit1View
        Me.gleUsuariosConectados.Size = New System.Drawing.Size(128, 20)
        Me.gleUsuariosConectados.TabIndex = 10
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.DetailHeight = 100
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtEstadoPeriodo
        '
        Me.txtEstadoPeriodo.Enabled = False
        Me.txtEstadoPeriodo.Location = New System.Drawing.Point(136, 88)
        Me.txtEstadoPeriodo.Name = "txtEstadoPeriodo"
        '
        'txtEstadoPeriodo.Properties
        '
        Me.txtEstadoPeriodo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtEstadoPeriodo.Properties.Appearance.Options.UseFont = True
        Me.txtEstadoPeriodo.Size = New System.Drawing.Size(128, 20)
        Me.txtEstadoPeriodo.TabIndex = 9
        '
        'txtnombrePeriodo
        '
        Me.txtnombrePeriodo.Location = New System.Drawing.Point(136, 56)
        Me.txtnombrePeriodo.Name = "txtnombrePeriodo"
        '
        'txtnombrePeriodo.Properties
        '
        Me.txtnombrePeriodo.Properties.ReadOnly = True
        Me.txtnombrePeriodo.Size = New System.Drawing.Size(128, 20)
        Me.txtnombrePeriodo.TabIndex = 8
        '
        'lblPeriodo
        '
        Me.lblPeriodo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPeriodo.Location = New System.Drawing.Point(80, 60)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 16)
        Me.lblPeriodo.TabIndex = 7
        Me.lblPeriodo.Text = "Período"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCierreMensual
        '
        Me.btnCierreMensual.Location = New System.Drawing.Point(64, 224)
        Me.btnCierreMensual.Name = "btnCierreMensual"
        Me.btnCierreMensual.Size = New System.Drawing.Size(224, 23)
        Me.btnCierreMensual.TabIndex = 12
        Me.btnCierreMensual.Text = "&Procede a cierre mensual"
        '
        'frmCierreMensual
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(368, 254)
        Me.Controls.Add(Me.btnCierreMensual)
        Me.Controls.Add(Me.gpcParametroMensual)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCierreMensual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proceso de Cierre Mensual"
        CType(Me.gpcParametroMensual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcParametroMensual.ResumeLayout(False)
        CType(Me.gleUsuariosConectados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstadoPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnombrePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvConexiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim parametroMensual As Periodo

    Private Sub frmCierreMensual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        parametroMensual = New Periodo
        txtnombrePeriodo.Text = UCase(parametroMensual.nombrePeriodo)
        llenarUsuariosConectados()
        If parametroMensual.estadoPeriodo = False Then
            txtEstadoPeriodo.Text = "INACTIVO"
        Else
            txtEstadoPeriodo.Text = "ACTIVO"
        End If
        lblUsuarios.Visible = False
        gleUsuariosConectados.Visible = False

        dvConexiones = Procesos.coneccionesActivasBaseDatos()
        If dvConexiones.Count > 0 Then
            lblUsuarios.Visible = True
            gleUsuariosConectados.Visible = True
            gleUsuariosConectados.Properties.DataSource = dvConexiones
        End If
    End Sub

    Private Sub btnCierreMensual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierreMensual.Click
        Try
            If MessageBox.Show("¿Está seguro que desea proceder al cierre del mes?", "Remuneraciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If MessageBox.Show("¿Emitió las planillas de imposiciones y envió el archivo a PREVIRED?", "Remuneraciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Cursor.Current = Cursors.WaitCursor
                    Dim continua As Boolean = False
                    dvConexiones = Procesos.coneccionesActivasBaseDatos()
                    If dvConexiones.Count > 0 Then
                        lblUsuarios.Visible = True
                        gleUsuariosConectados.Visible = True
                        gleUsuariosConectados.Properties.DataSource = dvConexiones
                        If MessageBox.Show("Hay usuarios que están conectados a la base de datos. ¿Continua?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                            continua = True
                        Else
                            continua = False
                        End If
                    End If
                    If continua Then
                        If Procesos.CierreMensual(parametroMensual.ID) Then
                            txtEstadoPeriodo.Text = "INACTIVO"
                            btnCierreMensual.Enabled = False
                            Cursor.Current = Cursors.Default
                            MessageBox.Show("Proceso terminado satisfactoriamente, el sistema se cerrará.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Application.Exit()
                        Else
                            Cursor.Current = Cursors.Default
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al intentar cerrar el mes " & Chr(13) & Chr(13) & ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub
    Public Sub llenarUsuariosConectados()
        gleUsuariosConectados.Properties.ViewType = Repository.GridLookUpViewType.GridView
        gleUsuariosConectados.Properties.View.OptionsBehavior.AutoPopulateColumns = False
        gleUsuariosConectados.Properties.DataSource = dvConexiones
        gleUsuariosConectados.Properties.DisplayMember = "LOGINAME"

        Dim col1 As GridColumn = gleUsuariosConectados.Properties.View.Columns.AddField("LOGINAME")
        col1.VisibleIndex = 0
        col1.Caption = "Usuario"
        col1.Width = 100

        Dim col2 As GridColumn = gleUsuariosConectados.Properties.View.Columns.AddField("HOSTNAME")
        col2.VisibleIndex = 1
        col2.Caption = "Nombre Host"
        col2.Visible = True
        col2.Width = 100

        gleUsuariosConectados.Properties.ValueMember = "LOGINAME"
        gleUsuariosConectados.Properties.View.BestFitColumns()
        gleUsuariosConectados.Properties.PopupFormWidth = 250
        gleUsuariosConectados.Text = ""
    End Sub
End Class
