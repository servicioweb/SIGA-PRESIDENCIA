'1.- Importar los namespaces con las reglas 
'de negocio y las clases más generales del sistema (facade)
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Windows.Forms
Imports System.Drawing
Imports System

Public Class frmAntecedenteCurricular
    Inherits System.Windows.Forms.Form
    Private empleado As New empleado
    Private mantenedor As New Mantenedor

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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDV As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblRut As System.Windows.Forms.Label
    Friend WithEvents txtNombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNombres As System.Windows.Forms.Label
    Friend WithEvents gleRut As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents lycDatosCurriculumLaboral As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents lcgDatosCurriculumLaboral As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lueEducacion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lciEducacion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents memOtrosEstudios As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lciOtroEstudios As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents memExperienciaLaboral As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lciExperienciaLaboral As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gpcBotones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lueNivelEstudio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lciNivelEstudio As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnAdjuntos As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtNombres = New DevExpress.XtraEditors.TextEdit
        Me.lblNombres = New System.Windows.Forms.Label
        Me.lblRut = New System.Windows.Forms.Label
        Me.gleRut = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.txtDV = New DevExpress.XtraEditors.TextEdit
        Me.lycDatosCurriculumLaboral = New DevExpress.XtraLayout.LayoutControl
        Me.lueNivelEstudio = New DevExpress.XtraEditors.LookUpEdit
        Me.memExperienciaLaboral = New DevExpress.XtraEditors.MemoEdit
        Me.memOtrosEstudios = New DevExpress.XtraEditors.MemoEdit
        Me.lueEducacion = New DevExpress.XtraEditors.LookUpEdit
        Me.lcgDatosCurriculumLaboral = New DevExpress.XtraLayout.LayoutControlGroup
        Me.lciEducacion = New DevExpress.XtraLayout.LayoutControlItem
        Me.lciOtroEstudios = New DevExpress.XtraLayout.LayoutControlItem
        Me.lciExperienciaLaboral = New DevExpress.XtraLayout.LayoutControlItem
        Me.lciNivelEstudio = New DevExpress.XtraLayout.LayoutControlItem
        Me.gpcBotones = New DevExpress.XtraEditors.GroupControl
        Me.btnAdjuntos = New DevExpress.XtraEditors.SimpleButton
        Me.btnCerrar = New DevExpress.XtraEditors.SimpleButton
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycDatosCurriculumLaboral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycDatosCurriculumLaboral.SuspendLayout()
        CType(Me.lueNivelEstudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memExperienciaLaboral.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memOtrosEstudios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueEducacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgDatosCurriculumLaboral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEducacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciOtroEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciExperienciaLaboral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciNivelEstudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.txtNombres)
        Me.GroupControl1.Controls.Add(Me.lblNombres)
        Me.GroupControl1.Controls.Add(Me.lblRut)
        Me.GroupControl1.Controls.Add(Me.gleRut)
        Me.GroupControl1.Controls.Add(Me.txtDV)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(736, 112)
        Me.GroupControl1.TabIndex = 45
        Me.GroupControl1.Text = "Empleado"
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(112, 72)
        Me.txtNombres.Name = "txtNombres"
        '
        'txtNombres.Properties
        '
        Me.txtNombres.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombres.Properties.MaxLength = 30
        Me.txtNombres.Size = New System.Drawing.Size(456, 20)
        Me.txtNombres.TabIndex = 48
        '
        'lblNombres
        '
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.Location = New System.Drawing.Point(8, 72)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(96, 16)
        Me.lblNombres.TabIndex = 49
        Me.lblNombres.Text = "Nombres"
        Me.lblNombres.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRut
        '
        Me.lblRut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRut.Location = New System.Drawing.Point(8, 40)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(96, 16)
        Me.lblRut.TabIndex = 47
        Me.lblRut.Text = "Rut"
        Me.lblRut.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gleRut
        '
        Me.gleRut.Cursor = System.Windows.Forms.Cursors.Default
        Me.gleRut.EditValue = -1
        Me.gleRut.Location = New System.Drawing.Point(112, 40)
        Me.gleRut.Name = "gleRut"
        '
        'gleRut.Properties
        '
        Me.gleRut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleRut.Properties.View = Me.GridLookUpEdit1View
        Me.gleRut.Size = New System.Drawing.Size(144, 20)
        Me.gleRut.TabIndex = 46
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.AppearancePrint.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.GridLookUpEdit1View.AppearancePrint.OddRow.BackColor2 = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.GridLookUpEdit1View.AppearancePrint.OddRow.Options.UseBackColor = True
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtDV
        '
        Me.txtDV.Enabled = False
        Me.txtDV.Location = New System.Drawing.Point(264, 40)
        Me.txtDV.Name = "txtDV"
        '
        'txtDV.Properties
        '
        Me.txtDV.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDV.Properties.MaxLength = 1
        Me.txtDV.Size = New System.Drawing.Size(32, 20)
        Me.txtDV.TabIndex = 2
        Me.txtDV.ToolTip = "Por favor registre el  dígito verificador"
        Me.txtDV.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'lycDatosCurriculumLaboral
        '
        Me.lycDatosCurriculumLaboral.Controls.Add(Me.lueNivelEstudio)
        Me.lycDatosCurriculumLaboral.Controls.Add(Me.memExperienciaLaboral)
        Me.lycDatosCurriculumLaboral.Controls.Add(Me.memOtrosEstudios)
        Me.lycDatosCurriculumLaboral.Controls.Add(Me.lueEducacion)
        Me.lycDatosCurriculumLaboral.Location = New System.Drawing.Point(0, 112)
        Me.lycDatosCurriculumLaboral.Name = "lycDatosCurriculumLaboral"
        Me.lycDatosCurriculumLaboral.OptionsView.AllowHotTrack = True
        Me.lycDatosCurriculumLaboral.OptionsView.DrawItemBorders = True
        Me.lycDatosCurriculumLaboral.Root = Me.lcgDatosCurriculumLaboral
        Me.lycDatosCurriculumLaboral.Size = New System.Drawing.Size(736, 312)
        Me.lycDatosCurriculumLaboral.TabIndex = 46
        Me.lycDatosCurriculumLaboral.Text = "Datos Curriculum Laboral"
        '
        'lueNivelEstudio
        '
        Me.lueNivelEstudio.Enabled = False
        Me.lueNivelEstudio.Location = New System.Drawing.Point(152, 25)
        Me.lueNivelEstudio.Name = "lueNivelEstudio"
        '
        'lueNivelEstudio.Properties
        '
        Me.lueNivelEstudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueNivelEstudio.Properties.ReadOnly = True
        Me.lueNivelEstudio.Size = New System.Drawing.Size(578, 20)
        Me.lueNivelEstudio.StyleController = Me.lycDatosCurriculumLaboral
        Me.lueNivelEstudio.TabIndex = 7
        '
        'memExperienciaLaboral
        '
        Me.memExperienciaLaboral.Location = New System.Drawing.Point(152, 188)
        Me.memExperienciaLaboral.Name = "memExperienciaLaboral"
        Me.memExperienciaLaboral.Size = New System.Drawing.Size(578, 118)
        Me.memExperienciaLaboral.StyleController = Me.lycDatosCurriculumLaboral
        Me.memExperienciaLaboral.TabIndex = 6
        '
        'memOtrosEstudios
        '
        Me.memOtrosEstudios.Location = New System.Drawing.Point(152, 87)
        Me.memOtrosEstudios.Name = "memOtrosEstudios"
        Me.memOtrosEstudios.Size = New System.Drawing.Size(578, 90)
        Me.memOtrosEstudios.StyleController = Me.lycDatosCurriculumLaboral
        Me.memOtrosEstudios.TabIndex = 5
        '
        'lueEducacion
        '
        Me.lueEducacion.Location = New System.Drawing.Point(152, 56)
        Me.lueEducacion.Name = "lueEducacion"
        '
        'lueEducacion.Properties
        '
        Me.lueEducacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueEducacion.Size = New System.Drawing.Size(578, 20)
        Me.lueEducacion.StyleController = Me.lycDatosCurriculumLaboral
        Me.lueEducacion.TabIndex = 4
        '
        'lcgDatosCurriculumLaboral
        '
        Me.lcgDatosCurriculumLaboral.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lcgDatosCurriculumLaboral.AppearanceGroup.Options.UseFont = True
        Me.lcgDatosCurriculumLaboral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciEducacion, Me.lciOtroEstudios, Me.lciExperienciaLaboral, Me.lciNivelEstudio})
        Me.lcgDatosCurriculumLaboral.Location = New System.Drawing.Point(0, 0)
        Me.lcgDatosCurriculumLaboral.Name = "lcgDatosCurriculumLaboral"
        Me.lcgDatosCurriculumLaboral.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lcgDatosCurriculumLaboral.Size = New System.Drawing.Size(736, 312)
        Me.lcgDatosCurriculumLaboral.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lcgDatosCurriculumLaboral.Text = "Datos Curriculum Laboral"
        Me.lcgDatosCurriculumLaboral.TextVisible = True
        '
        'lciEducacion
        '
        Me.lciEducacion.Control = Me.lueEducacion
        Me.lciEducacion.Location = New System.Drawing.Point(0, 31)
        Me.lciEducacion.Name = "lciEducacion"
        Me.lciEducacion.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciEducacion.Size = New System.Drawing.Size(734, 31)
        Me.lciEducacion.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lciEducacion.Text = "Título Profesional / Educación"
        Me.lciEducacion.TextSize = New System.Drawing.Size(140, 20)
        Me.lciEducacion.TextVisible = True
        '
        'lciOtroEstudios
        '
        Me.lciOtroEstudios.Control = Me.memOtrosEstudios
        Me.lciOtroEstudios.Location = New System.Drawing.Point(0, 62)
        Me.lciOtroEstudios.Name = "lciOtroEstudios"
        Me.lciOtroEstudios.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciOtroEstudios.Size = New System.Drawing.Size(734, 101)
        Me.lciOtroEstudios.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lciOtroEstudios.Text = "Otros Estudios"
        Me.lciOtroEstudios.TextSize = New System.Drawing.Size(140, 20)
        Me.lciOtroEstudios.TextVisible = True
        '
        'lciExperienciaLaboral
        '
        Me.lciExperienciaLaboral.Control = Me.memExperienciaLaboral
        Me.lciExperienciaLaboral.Location = New System.Drawing.Point(0, 163)
        Me.lciExperienciaLaboral.Name = "lciExperienciaLaboral"
        Me.lciExperienciaLaboral.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciExperienciaLaboral.Size = New System.Drawing.Size(734, 129)
        Me.lciExperienciaLaboral.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lciExperienciaLaboral.Text = "Experiencia Laboral"
        Me.lciExperienciaLaboral.TextSize = New System.Drawing.Size(140, 20)
        Me.lciExperienciaLaboral.TextVisible = True
        '
        'lciNivelEstudio
        '
        Me.lciNivelEstudio.Control = Me.lueNivelEstudio
        Me.lciNivelEstudio.Location = New System.Drawing.Point(0, 0)
        Me.lciNivelEstudio.Name = "lciNivelEstudio"
        Me.lciNivelEstudio.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciNivelEstudio.Size = New System.Drawing.Size(734, 31)
        Me.lciNivelEstudio.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lciNivelEstudio.Text = "Nivel de Estdudio"
        Me.lciNivelEstudio.TextSize = New System.Drawing.Size(140, 20)
        Me.lciNivelEstudio.TextVisible = True
        '
        'gpcBotones
        '
        Me.gpcBotones.Controls.Add(Me.btnAdjuntos)
        Me.gpcBotones.Controls.Add(Me.btnCerrar)
        Me.gpcBotones.Controls.Add(Me.btnEliminar)
        Me.gpcBotones.Controls.Add(Me.btnGuardar)
        Me.gpcBotones.Location = New System.Drawing.Point(0, 424)
        Me.gpcBotones.Name = "gpcBotones"
        Me.gpcBotones.ShowCaption = False
        Me.gpcBotones.Size = New System.Drawing.Size(736, 64)
        Me.gpcBotones.TabIndex = 47
        Me.gpcBotones.Text = "GroupControl2"
        '
        'btnAdjuntos
        '
        Me.btnAdjuntos.Location = New System.Drawing.Point(576, 24)
        Me.btnAdjuntos.Name = "btnAdjuntos"
        Me.btnAdjuntos.Size = New System.Drawing.Size(136, 23)
        Me.btnAdjuntos.TabIndex = 3
        Me.btnAdjuntos.Text = "Documentos Adjuntos"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(400, 24)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(136, 23)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(224, 24)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(136, 23)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(56, 24)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(136, 23)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        '
        'frmAntecedenteCurricular
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(736, 492)
        Me.Controls.Add(Me.gpcBotones)
        Me.Controls.Add(Me.lycDatosCurriculumLaboral)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frmAntecedenteCurricular"
        Me.Text = "Antecedentes Curriculares"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycDatosCurriculumLaboral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycDatosCurriculumLaboral.ResumeLayout(False)
        CType(Me.lueNivelEstudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memExperienciaLaboral.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memOtrosEstudios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueEducacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgDatosCurriculumLaboral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEducacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciOtroEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciExperienciaLaboral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciNivelEstudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmAntecedenteCurricular_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initCampoRut()
        llenarNivelEstudio()
        llenarProfesion()
        Me.lycDatosCurriculumLaboral.Enabled = False
        Me.lueNivelEstudio.EditValue = -1
        Me.btnAdjuntos.Enabled = False
    End Sub

    Private Sub initCampoRut()
        gleRut.Properties.ViewType = Repository.GridLookUpViewType.GridView
        gleRut.Properties.View.OptionsBehavior.AutoPopulateColumns = False
        gleRut.Properties.DataSource = repositorio.dvEmpleadoVista
        gleRut.Properties.DisplayMember = "RUT"

        Dim col1 As GridColumn = gleRut.Properties.View.Columns.AddField("RUT")
        col1.VisibleIndex = 0
        col1.Caption = "RUT"

        Dim col2 As GridColumn = gleRut.Properties.View.Columns.AddField("APELLIDO_PATERNO")
        col2.VisibleIndex = 1
        col2.Caption = "Apellido Paterno"

        Dim col3 As GridColumn = gleRut.Properties.View.Columns.AddField("APELLIDO_MATERNO")
        col3.VisibleIndex = 2
        col3.Caption = "Apellido Materno"

        Dim col4 As GridColumn = gleRut.Properties.View.Columns.AddField("NOMBRES")
        col4.VisibleIndex = 3
        col4.Caption = "Nombres"

        Dim col5 As GridColumn = gleRut.Properties.View.Columns.AddField("DESC_ESTADO")
        col5.VisibleIndex = 4
        col5.Caption = "Estado"

        Dim col6 As GridColumn = gleRut.Properties.View.Columns.AddField("DESC_CALIDAD_JURIDICA")
        col6.VisibleIndex = 5
        col6.Caption = "Calidad Jurídica"

        Dim col7 As GridColumn = gleRut.Properties.View.Columns.AddField("NOMBRE_COMPLETO")
        col7.VisibleIndex = 6
        col7.Caption = "Nombre Completo"
        col7.Visible = False

        gleRut.Properties.ValueMember = "EMPLEADO_ID"
        gleRut.Properties.View.BestFitColumns()
        gleRut.Properties.PopupFormWidth = 600

        gleRut.EditValue = -1
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

    Public Sub llenarProfesion()
        lueEducacion.Properties.Columns.Clear()
        With lueEducacion
            With .Properties.Columns
                .Add(New LookUpColumnInfo("PROFESION_OFICIO_ID", "ID Profesion", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción.", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueEducacion.Properties.DataSource = mantenedor.recuperarProfesionOficio(empleado.nivelEducacional)
        lueEducacion.Properties.DisplayMember = "DESCRIPCION"
        lueEducacion.Properties.NullText = ""
        lueEducacion.Properties.PopupWidth = 400
        lueEducacion.Properties.ValueMember = "PROFESION_OFICIO_ID"
        lueEducacion.EditValue = "PROFESION_OFICIO_ID"
    End Sub

    Private Sub refrescarControles()
        llenarProfesion()
        txtDV.Text = empleado.rut.dv
        txtNombres.Text = empleado.nombreCompleto
        Me.lueNivelEstudio.EditValue = empleado.nivelEducacional
        Me.lueEducacion.EditValue = empleado.datosCurriculumLaboral.prefesionId
        Me.memOtrosEstudios.Text = empleado.datosCurriculumLaboral.otrosEstudios
        Me.memExperienciaLaboral.Text = empleado.datosCurriculumLaboral.experienciaLaboral
        If Me.lueEducacion.EditValue >= 0 Then
            Me.btnAdjuntos.Enabled = True
        Else
            Me.btnAdjuntos.Enabled = False
        End If
    End Sub

    Private Sub gleRut_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gleRut.EditValueChanged
        Cursor.Current = Cursors.WaitCursor
        If Me.gleRut.EditValue > 0 Then
            Try
                empleado = New empleado(CType(gleRut.EditValue, Long))
                refrescarControles()
                gleRut.EditValue = empleado.ID
                txtDV.Text = empleado.rut.dv
                txtNombres.Text = empleado.nombreCompleto
                Me.lycDatosCurriculumLaboral.Enabled = True
            Catch exp As Exception
                MessageBox.Show("Atención: " & exp.Message, "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim guardar As Boolean = True
        Dim mensaje As String
        If Me.gleRut.EditValue <= 0 Then
            Exit Sub
        End If
        If Len(Me.memExperienciaLaboral.Text) = 0 Then
            memExperienciaLaboral.ErrorText = "Debe ingresar experiencia laboral"
            guardar = False
        End If
        If Me.lueEducacion.EditValue <= 0 Then
            memExperienciaLaboral.ErrorText = "Debe seleccionar de la lista una profesión u oficio"
            guardar = False
        End If
        If guardar Then
            Me.btnAdjuntos.Enabled = True
            If empleado.datosCurriculumLaboral.antecedenteCuirricularLaboralId = 0 Then
                asignarCampos()
                empleado.datosCurriculumLaboral.antecedenteCuirricularLaboralId = empleado.CrearEmpleadoAntecedenteCurricular()
                mensaje = "creado"
            Else
                empleado.datosCurriculumLaboral.estadoRegistro = Comun.TiposDeDatos.EstadoRegistro.INACTIVO
                empleado.actualizarDatosCurriculumLaboral(empleado.datosCurriculumLaboral)
                asignarCampos()
                empleado.datosCurriculumLaboral.antecedenteCuirricularLaboralId = empleado.CrearEmpleadoAntecedenteCurricular()
                mensaje = "actualizado"
            End If
            MsgBox("El registro fue " + mensaje + " satisfactoriamente", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub asignarCampos()
        empleado.datosCurriculumLaboral.empleadoId = empleado.ID
        empleado.datosCurriculumLaboral.estadoRegistro = Comun.TiposDeDatos.EstadoRegistro.ACTIVO
        empleado.datosCurriculumLaboral.prefesionId = Me.lueEducacion.EditValue
        empleado.datosCurriculumLaboral.otrosEstudios = Me.memOtrosEstudios.Text
        empleado.datosCurriculumLaboral.experienciaLaboral = Me.memExperienciaLaboral.Text
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.gleRut.EditValue <= 0 Then
            Exit Sub
        End If
        If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
            Try
                empleado.EliminarEmpleadoAntecedenteCurricular(empleado.datosCurriculumLaboral.antecedenteCuirricularLaboralId)
                limpiarControles()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub limpiarControles()
        txtNombres.Text = ""
        gleRut.EditValue = -1
        txtDV.Text = ""
        memOtrosEstudios.Text = ""
        memExperienciaLaboral.Text = ""
        lueEducacion.EditValue = -1
        lueNivelEstudio.EditValue = -1
        Me.lycDatosCurriculumLaboral.Enabled = False
        Me.btnAdjuntos.Enabled = False
    End Sub

    Private Sub btnAdjuntos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntos.Click
        Try
            frmBinario.DefInstance.empleadoBinario = empleado
            frmBinario.DefInstance.antecedenteCurricularId = empleado.datosCurriculumLaboral.antecedenteCuirricularLaboralId
            frmBinario.DefInstance.Owner = Me
            If frmBinario.DefInstance.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido al intentar carga el formulario." & " " & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            If frmBinario.DefInstance.retorno Then
                'gdcLicenciasMedicas.DataSource = empleado.dvDatosLicenciaMedica(empleado.ID)
                'limpiarControles()
            End If
        End Try
    End Sub
End Class