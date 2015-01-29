Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports cl.presidencia.Argo.BusinessRules

Public Class frmProfesiones
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
    Friend WithEvents gpcFiltroEdicion As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblProfesion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gpcDatos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueNivelEstudio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblNivelEstudio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gpcBotones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gleProfesionOficio As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents btnEditar As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gpcFiltroEdicion = New DevExpress.XtraEditors.GroupControl
        Me.btnEditar = New DevExpress.XtraEditors.SimpleButton
        Me.lblProfesion = New DevExpress.XtraEditors.LabelControl
        Me.gleProfesionOficio = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gpcDatos = New DevExpress.XtraEditors.GroupControl
        Me.lblNivelEstudio = New DevExpress.XtraEditors.LabelControl
        Me.lueNivelEstudio = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit
        Me.lblCodigo = New DevExpress.XtraEditors.LabelControl
        Me.gpcBotones = New DevExpress.XtraEditors.GroupControl
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton
        CType(Me.gpcFiltroEdicion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcFiltroEdicion.SuspendLayout()
        CType(Me.gleProfesionOficio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDatos.SuspendLayout()
        CType(Me.lueNivelEstudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpcFiltroEdicion
        '
        Me.gpcFiltroEdicion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcFiltroEdicion.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcFiltroEdicion.AppearanceCaption.Options.UseFont = True
        Me.gpcFiltroEdicion.Controls.Add(Me.btnEditar)
        Me.gpcFiltroEdicion.Controls.Add(Me.lblProfesion)
        Me.gpcFiltroEdicion.Controls.Add(Me.gleProfesionOficio)
        Me.gpcFiltroEdicion.Location = New System.Drawing.Point(0, 0)
        Me.gpcFiltroEdicion.Name = "gpcFiltroEdicion"
        Me.gpcFiltroEdicion.Size = New System.Drawing.Size(736, 80)
        Me.gpcFiltroEdicion.TabIndex = 0
        Me.gpcFiltroEdicion.Text = "Filtro Búsqueda de Profesión/Oficio"
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(576, 32)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.Text = "Editar"
        '
        'lblProfesion
        '
        Me.lblProfesion.Location = New System.Drawing.Point(32, 38)
        Me.lblProfesion.Name = "lblProfesion"
        Me.lblProfesion.Size = New System.Drawing.Size(80, 14)
        Me.lblProfesion.TabIndex = 1
        Me.lblProfesion.Text = "Profesión/Oficio"
        '
        'gleProfesionOficio
        '
        Me.gleProfesionOficio.Location = New System.Drawing.Point(112, 32)
        Me.gleProfesionOficio.Name = "gleProfesionOficio"
        '
        'gleProfesionOficio.Properties
        '
        Me.gleProfesionOficio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleProfesionOficio.Properties.View = Me.GridLookUpEdit1View
        Me.gleProfesionOficio.Size = New System.Drawing.Size(440, 20)
        Me.gleProfesionOficio.TabIndex = 0
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'gpcDatos
        '
        Me.gpcDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcDatos.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDatos.AppearanceCaption.Options.UseFont = True
        Me.gpcDatos.Controls.Add(Me.lblNivelEstudio)
        Me.gpcDatos.Controls.Add(Me.lueNivelEstudio)
        Me.gpcDatos.Controls.Add(Me.LabelControl1)
        Me.gpcDatos.Controls.Add(Me.txtDescripcion)
        Me.gpcDatos.Controls.Add(Me.txtCodigo)
        Me.gpcDatos.Controls.Add(Me.lblCodigo)
        Me.gpcDatos.Location = New System.Drawing.Point(0, 80)
        Me.gpcDatos.Name = "gpcDatos"
        Me.gpcDatos.Size = New System.Drawing.Size(736, 168)
        Me.gpcDatos.TabIndex = 1
        Me.gpcDatos.Text = "Profesión/Oficio"
        '
        'lblNivelEstudio
        '
        Me.lblNivelEstudio.Appearance.Options.UseTextOptions = True
        Me.lblNivelEstudio.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblNivelEstudio.Location = New System.Drawing.Point(32, 94)
        Me.lblNivelEstudio.Name = "lblNivelEstudio"
        Me.lblNivelEstudio.Size = New System.Drawing.Size(136, 14)
        Me.lblNivelEstudio.TabIndex = 7
        Me.lblNivelEstudio.Text = "Nivel de Estudio"
        '
        'lueNivelEstudio
        '
        Me.lueNivelEstudio.Location = New System.Drawing.Point(176, 88)
        Me.lueNivelEstudio.Name = "lueNivelEstudio"
        '
        'lueNivelEstudio.Properties
        '
        Me.lueNivelEstudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueNivelEstudio.Size = New System.Drawing.Size(360, 20)
        Me.lueNivelEstudio.TabIndex = 6
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Location = New System.Drawing.Point(32, 70)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(136, 14)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Descripción Profesión/Oficio"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(176, 64)
        Me.txtDescripcion.Name = "txtDescripcion"
        '
        'txtDescripcion.Properties
        '
        Me.txtDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Properties.MaxLength = 50
        Me.txtDescripcion.Size = New System.Drawing.Size(360, 20)
        Me.txtDescripcion.TabIndex = 4
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(176, 40)
        Me.txtCodigo.Name = "txtCodigo"
        '
        'txtCodigo.Properties
        '
        Me.txtCodigo.Properties.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(72, 20)
        Me.txtCodigo.TabIndex = 2
        '
        'lblCodigo
        '
        Me.lblCodigo.Appearance.ImageIndex = 32
        Me.lblCodigo.Appearance.Options.UseTextOptions = True
        Me.lblCodigo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblCodigo.Location = New System.Drawing.Point(96, 46)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "Código"
        '
        'gpcBotones
        '
        Me.gpcBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcBotones.Controls.Add(Me.btnCancelar)
        Me.gpcBotones.Controls.Add(Me.btnEliminar)
        Me.gpcBotones.Controls.Add(Me.btnGuardar)
        Me.gpcBotones.Controls.Add(Me.btnNuevo)
        Me.gpcBotones.Location = New System.Drawing.Point(0, 248)
        Me.gpcBotones.Name = "gpcBotones"
        Me.gpcBotones.ShowCaption = False
        Me.gpcBotones.Size = New System.Drawing.Size(736, 72)
        Me.gpcBotones.TabIndex = 2
        Me.gpcBotones.Text = "Botones"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(376, 24)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(288, 25)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(200, 24)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(112, 24)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        '
        'frmProfesiones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(744, 322)
        Me.Controls.Add(Me.gpcBotones)
        Me.Controls.Add(Me.gpcDatos)
        Me.Controls.Add(Me.gpcFiltroEdicion)
        Me.Name = "frmProfesiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Profesión/Oficio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcFiltroEdicion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcFiltroEdicion.ResumeLayout(False)
        CType(Me.gleProfesionOficio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatos.ResumeLayout(False)
        CType(Me.lueNivelEstudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mantenedor As New mantenedor

    Private Sub frmProfesiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarProfesionOficio()
        llenarNivelEstudio()
        Me.gpcDatos.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.btnEditar.Enabled = False
        Me.gleProfesionOficio.EditValue = -1
    End Sub

    Public Sub llenarProfesionOficio()
        'gleProfesionOficio.Properties.EditValueChangedFiringDelay = 1200
        gleProfesionOficio.Properties.View.Columns.Clear()
        gleProfesionOficio.Properties.EditValueChangedFiringMode = EditValueChangedFiringMode.Buffered
        'Dos segundos se espera antes de gatillar la búsqueda (EditValueChanged)

        gleProfesionOficio.Properties.ViewType = Repository.GridLookUpViewType.GridView
        gleProfesionOficio.Properties.View.OptionsBehavior.AutoPopulateColumns = False
        gleProfesionOficio.Properties.DisplayMember = "DESCRIPCION"

        Dim col1 As GridColumn = gleProfesionOficio.Properties.View.Columns.AddField("ORGANIZACION_ID")
        col1.VisibleIndex = 0
        col1.Caption = "Id Organización"
        col1.Visible = False

        Dim col2 As GridColumn = gleProfesionOficio.Properties.View.Columns.AddField("PROFESION_OFICIO_ID")
        col2.VisibleIndex = 1
        col2.Caption = "Id Profesión"
        col2.Visible = False

        Dim col3 As GridColumn = gleProfesionOficio.Properties.View.Columns.AddField("PROFESION_ALIAS")
        col3.VisibleIndex = 2
        col3.Caption = "Alias"
        col3.Visible = False

        Dim col4 As GridColumn = gleProfesionOficio.Properties.View.Columns.AddField("NIVEL_ESTUDIO_ID")
        col4.VisibleIndex = 3
        col4.Caption = "Id Nivel Estudio"
        col4.Visible = False

        Dim col5 As GridColumn = gleProfesionOficio.Properties.View.Columns.AddField("DESCRIPCION")
        col5.VisibleIndex = 4
        col5.Caption = "Descripción Profesión/Oficio"
        col5.Visible = True

        gleProfesionOficio.Properties.ValueMember = "PROFESION_OFICIO_ID"

        gleProfesionOficio.Properties.View.BestFitColumns()
        gleProfesionOficio.Properties.PopupFormWidth = 600
        Try
            gleProfesionOficio.Properties.DataSource = mantenedor.recuperarProfesionOficio
        Catch ex As Exception
            'Throw New Exception(ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "SIGA RRHH")
        End Try
    End Sub

    Private Sub llenarNivelEstudio()
        With lueNivelEstudio
            With .Properties.Columns
                .Add(New LookUpColumnInfo("NIVEL_ESTUDIO_ID", "ID Nivel Estudio", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueNivelEstudio.Properties.DataSource = mantenedor.recuperarNivelEstudiosCurricular
        lueNivelEstudio.Properties.DisplayMember = "DESCRIPCION"
        lueNivelEstudio.Properties.NullText = ""
        lueNivelEstudio.Properties.PopupWidth = 150
        lueNivelEstudio.Properties.ValueMember = "NIVEL_ESTUDIO_ID"
    End Sub

    Private Sub gleProfesionOficio_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gleProfesionOficio.EditValueChanged
        If Me.gleProfesionOficio.EditValue >= 0 Then
            Me.btnEditar.Enabled = True
        Else
            Me.btnEditar.Enabled = False
        End If
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Dim edit As DevExpress.XtraEditors.GridLookUpEdit = gleProfesionOficio
        Dim row As DataRow = edit.Properties.View.GetDataRow(edit.Properties.View.FocusedRowHandle)

        Me.txtCodigo.Text = row("PROFESION_OFICIO_ID")
        Me.txtDescripcion.Text = RTrim(row("DESCRIPCION"))
        Me.lueNivelEstudio.EditValue = row("NIVEL_ESTUDIO_ID")
        Me.gpcDatos.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.btnGuardar.Enabled = True
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        limpiarDatos()
        Me.gleProfesionOficio.EditValue = -1
        Me.gpcDatos.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.btnGuardar.Enabled = True
        Me.btnEditar.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim grabar As Boolean = True
        If Trim(Me.txtDescripcion.Text).ToString.Length = 0 Then
            Me.txtDescripcion.ErrorText = "Falta ingresar la profesión u oficio"
            grabar = False
        End If
        If Me.lueNivelEstudio.EditValue < 0 Then
            Me.lueNivelEstudio.ErrorText = "Falta seleccionar un item de la lista"
            grabar = False
        End If
        If grabar = True Then
            Dim mensaje As String
            If Me.txtCodigo.Text = "" Then
                'Insertar nuevo registro
                mensaje = "agregado"
                mantenedor.insertarProfesionOficio(Argo.Comun.ArgoConfiguracion.OrganizacionID, 0, Me.lueNivelEstudio.EditValue, Me.txtDescripcion.Text)
            Else
                'Actualizar registro
                mensaje = "actualizado"
                mantenedor.actualizarProfesionOficio(Argo.Comun.ArgoConfiguracion.OrganizacionID, txtCodigo.EditValue, 0, Me.lueNivelEstudio.EditValue, Me.txtDescripcion.Text)
            End If
            llenarProfesionOficio()
            limpiarDatos()
            Me.btnEliminar.Enabled = False
            Me.btnGuardar.Enabled = False
            Me.gpcDatos.Enabled = False
            Me.gleProfesionOficio.EditValue = -1
            MsgBox("Registro " + mensaje + " correctamente.", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "SIGA RRHH")
        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.txtCodigo.Text <> "" Then
            If MsgBox("¿Esta seguro de eliminar el registro actual?", MsgBoxStyle.OKCancel + MsgBoxStyle.Question, "SIGA RRHH") = MsgBoxResult.OK Then
                Try
                    mantenedor.eliminarProfesionOficio(Me.txtCodigo.Text)
                    llenarProfesionOficio()
                    limpiarDatos()
                    Me.btnEliminar.Enabled = False
                    Me.btnGuardar.Enabled = False
                    Me.gpcDatos.Enabled = False
                    Me.gleProfesionOficio.EditValue = -1
                    MsgBox("Registro eliminado correctamente.", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "SIGA RRHH")
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "SIGA RRHH")
                End Try
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        limpiarDatos()
        Me.gleProfesionOficio.EditValue = -1
        Me.gpcDatos.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.btnEditar.Enabled = False
    End Sub

    Private Sub limpiarDatos()
        Me.txtDescripcion.Text = ""
        Me.lueNivelEstudio.EditValue = -1
        Me.txtCodigo.Text = ""
    End Sub

End Class
