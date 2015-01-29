Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Windows.Forms
Imports System.Drawing

Public Class frmAntecedentesAcademicos
    Inherits System.Windows.Forms.Form
    Dim empleado As Empleado

    Dim nivelEstudio As Integer

    Private Sub InitData()
        Dim ds As New DataAccess.Empleados
        Dim connectionString As String = Comun.ArgoConfiguracion.ConnectionString
        repositorio.dvEmpleados = repositorio.dvEmpleados
    End Sub

    Private Sub initPaises()
        glePais.ViewType = Repository.GridLookUpViewType.GridView
        glePais.View.OptionsBehavior.AutoPopulateColumns = False
        glePais.DataSource = repositorio.dvPaises
        glePais.DisplayMember = "DESCRIPCION"

        Dim col1 As GridColumn = glePais.View.Columns.AddField("PAIS_ID")
        col1.VisibleIndex = 0
        col1.Caption = "ID Inst.Estudio"
        col1.Visible = False

        Dim col2 As GridColumn = glePais.View.Columns.AddField("DESCRIPCION")
        col2.VisibleIndex = 1
        col2.Caption = "Descripción"

        glePais.ValueMember = "PAIS_ID"
        glePais.View.BestFitColumns()
        glePais.PopupFormWidth = 200
    End Sub

    Private Sub initCampoRut()
        'leRut.DataBindings.Add("EditValue", repositorio.dvEmpleadoVista, "EMPLEADO_ID")
        leRut.Properties.ViewType = Repository.GridLookUpViewType.GridView
        leRut.Properties.View.OptionsBehavior.AutoPopulateColumns = False
        leRut.Properties.DataSource = repositorio.dvEmpleadoVista
        leRut.Properties.DisplayMember = "RUT"

        Dim col1 As GridColumn = leRut.Properties.View.Columns.AddField("RUT")
        col1.VisibleIndex = 0
        col1.Caption = "RUT"

        Dim col2 As GridColumn = leRut.Properties.View.Columns.AddField("APELLIDO_PATERNO")
        col2.VisibleIndex = 1
        col2.Caption = "Apellido Paterno"

        Dim col3 As GridColumn = leRut.Properties.View.Columns.AddField("APELLIDO_MATERNO")
        col3.VisibleIndex = 2
        col3.Caption = "Apellido Materno"

        Dim col4 As GridColumn = leRut.Properties.View.Columns.AddField("NOMBRES")
        col4.VisibleIndex = 3
        col4.Caption = "Nombres"

        Dim col5 As GridColumn = leRut.Properties.View.Columns.AddField("DESC_ESTADO")
        col5.VisibleIndex = 4
        col5.Caption = "Estado"

        Dim col6 As GridColumn = leRut.Properties.View.Columns.AddField("DESC_CALIDAD_JURIDICA")
        col6.VisibleIndex = 5
        col6.Caption = "Calidad Jurídica"

        Dim col7 As GridColumn = leRut.Properties.View.Columns.AddField("NOMBRE_COMPLETO")
        col7.VisibleIndex = 6
        col7.Caption = "Nombre Completo"
        col7.Visible = False

        leRut.Properties.ValueMember = "EMPLEADO_ID"
        leRut.Properties.View.BestFitColumns()
        leRut.Properties.PopupFormWidth = 600

        leRut.Text = ""
    End Sub

    Sub initLeIntitucionesEdu()
        Dim conn As New SqlClient.SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim da As SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT DESCRIPCION,INSTITUCION_ESTUDIO_ID, TIPO_NIVEL_ESTUDIO_ID FROM RH_PER_INSTITUCION_ESTUDIO ORDER BY TIPO_NIVEL_ESTUDIO_ID,DESCRIPCION", conn))
        da.Fill(ds, "RH_PER_INSTITUCION_ESTUDIO")
        Dim dvm As New DataViewManager(ds)
        dvInstitucionesEdu = dvm.CreateDataView(ds.Tables(0))

        gleInstitucionEstudio.ViewType = Repository.GridLookUpViewType.GridView
        gleInstitucionEstudio.View.OptionsBehavior.AutoPopulateColumns = False
        gleInstitucionEstudio.DataSource = dvInstitucionesEdu
        gleInstitucionEstudio.DisplayMember = "DESCRIPCION"

        Dim col1 As GridColumn = gleInstitucionEstudio.View.Columns.AddField("INSTITUCION_ESTUDIO_ID")
        col1.VisibleIndex = 0
        col1.Caption = "ID Inst.Estudio"
        col1.Visible = False

        Dim col2 As GridColumn = gleInstitucionEstudio.View.Columns.AddField("DESCRIPCION")
        col2.VisibleIndex = 1
        col2.Caption = "Descripción"

        Dim col3 As GridColumn = gleInstitucionEstudio.View.Columns.AddField("TIPO_NIVEL_ESTUDIO_ID")
        col3.VisibleIndex = 2
        col3.Caption = "ID Tipo Nivel Estudio"
        col3.Visible = False

        gleInstitucionEstudio.ValueMember = "INSTITUCION_ESTUDIO_ID"
        gleInstitucionEstudio.View.BestFitColumns()
        gleInstitucionEstudio.PopupFormWidth = 400

        'GridView3.Columns("TIPO_NIVEL_ESTUDIO_ID").FilterInfo = New ColumnFilterInfo("5")
    End Sub

    Sub initLeNivelEstudios()
        Dim conn As New SqlClient.SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim da As SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT DESCRIPCION, NIVEL_ESTUDIO_ID,TIPO_NIVEL_ESTUDIO_ID FROM RH_PER_NIVEL_ESTUDIO WHERE APLICA_ANTECEDENTE_CURRICULAR=1 ORDER BY TIPO_NIVEL_ESTUDIO_ID, DESCRIPCION", conn))
        da.Fill(ds, "RH_PER_TIPO_NIVEL_ESTUDIO")
        Dim dvm As New DataViewManager(ds)
        dvNivelEstudios = dvm.CreateDataView(ds.Tables(0))

        gleNivelEstudio.ViewType = Repository.GridLookUpViewType.GridView
        gleNivelEstudio.View.OptionsBehavior.AutoPopulateColumns = False
        gleNivelEstudio.DataSource = dvNivelEstudios
        gleNivelEstudio.DisplayMember = "DESCRIPCION"

        Dim col1 As GridColumn = gleNivelEstudio.View.Columns.AddField("NIVEL_ESTUDIO_ID")
        col1.VisibleIndex = 0
        col1.Caption = "ID Nivel Estudio"
        col1.Visible = False

        Dim col2 As GridColumn = gleNivelEstudio.View.Columns.AddField("DESCRIPCION")
        col2.VisibleIndex = 1
        col2.Caption = "Descripción"

        Dim col3 As GridColumn = gleNivelEstudio.View.Columns.AddField("TIPO_NIVEL_ESTUDIO_ID")
        col3.VisibleIndex = 2
        col3.Caption = "ID Tipo Nivel Estudio"
        col3.Visible = False

        gleNivelEstudio.ValueMember = "NIVEL_ESTUDIO_ID"
        gleNivelEstudio.View.BestFitColumns()
        gleNivelEstudio.PopupFormWidth = 200
    End Sub

    Private Sub leRut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles leRut.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                empleado = New Empleado(CType(leRut.EditValue, Long))
                refrescarControles()
                dgDatosAcademicos.Enabled = True
            Catch exp As Exception
                MessageBox.Show("Atención: " & exp.Message, "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Sub refrescarControles()
        txtDV.Text = empleado.rut.dv
        txtNombres.Text = empleado.nombreCompleto
        dgDatosAcademicos.DataSource = empleado.dvDatosAcademicos
    End Sub

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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtNombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNombres As System.Windows.Forms.Label
    Friend WithEvents lblRut As System.Windows.Forms.Label
    Friend WithEvents leRut As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents txtDV As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgDatosAcademicos As DevExpress.XtraGrid.GridControl
    Friend WithEvents EMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvNivelEstudios As System.Data.DataView
    Friend WithEvents dvInstitucionesEdu As System.Data.DataView
    Friend WithEvents PERIODO_INI_ANO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PERIODO_FIN_ANO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NIVEL_ESTUDIO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents INSTITUCION_ESTUDIO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TITULO_OBTENIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NUM_ANOS_ESTUDIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OBSERVACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gleNivelEstudio As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gleInstitucionEstudio As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PAIS_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents glePais As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtTituloObtenido As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtMencion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtPeriodoEstudio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cbbPeriodo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents PERIODO_INI_MES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PERIODO_FIN_MES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvDetalleDatosAcademicos As DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgDatosAcademicos = New DevExpress.XtraGrid.GridControl
        Me.gvDetalleDatosAcademicos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.NIVEL_ESTUDIO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gleNivelEstudio = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PERIODO_INI_ANO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PERIODO_FIN_ANO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.INSTITUCION_ESTUDIO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gleInstitucionEstudio = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.TITULO_OBTENIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtTituloObtenido = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.NUM_ANOS_ESTUDIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cbbPeriodo = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.PAIS_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.glePais = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.OBSERVACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtMencion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.EMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PERIODO_INI_MES = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PERIODO_FIN_MES = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtPeriodoEstudio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtNombres = New DevExpress.XtraEditors.TextEdit
        Me.lblNombres = New System.Windows.Forms.Label
        Me.lblRut = New System.Windows.Forms.Label
        Me.leRut = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.txtDV = New DevExpress.XtraEditors.TextEdit
        Me.dvNivelEstudios = New System.Data.DataView
        Me.dvInstitucionesEdu = New System.Data.DataView
        CType(Me.dgDatosAcademicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalleDatosAcademicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleNivelEstudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleInstitucionEstudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTituloObtenido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glePais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMencion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodoEstudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leRut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvNivelEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvInstitucionesEdu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDatosAcademicos
        '
        Me.dgDatosAcademicos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'dgDatosAcademicos.EmbeddedNavigator
        '
        Me.dgDatosAcademicos.EmbeddedNavigator.Enabled = False
        Me.dgDatosAcademicos.EmbeddedNavigator.Name = ""
        Me.dgDatosAcademicos.EmbeddedNavigator.TextStringFormat = "Registros {0} de {1}"
        Me.dgDatosAcademicos.Location = New System.Drawing.Point(10, 122)
        Me.dgDatosAcademicos.MainView = Me.gvDetalleDatosAcademicos
        Me.dgDatosAcademicos.Name = "dgDatosAcademicos"
        Me.dgDatosAcademicos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.gleNivelEstudio, Me.gleInstitucionEstudio, Me.glePais, Me.txtTituloObtenido, Me.txtMencion, Me.txtPeriodoEstudio, Me.cbbPeriodo})
        Me.dgDatosAcademicos.Size = New System.Drawing.Size(720, 344)
        Me.dgDatosAcademicos.TabIndex = 53
        Me.dgDatosAcademicos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetalleDatosAcademicos, Me.GridView1})
        '
        'gvDetalleDatosAcademicos
        '
        Me.gvDetalleDatosAcademicos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NIVEL_ESTUDIO_ID, Me.PERIODO_INI_ANO, Me.PERIODO_FIN_ANO, Me.INSTITUCION_ESTUDIO_ID, Me.TITULO_OBTENIDO, Me.NUM_ANOS_ESTUDIO, Me.PAIS_ID, Me.OBSERVACION, Me.EMPLEADO_ID, Me.PERIODO_INI_MES, Me.PERIODO_FIN_MES})
        Me.gvDetalleDatosAcademicos.GridControl = Me.dgDatosAcademicos
        Me.gvDetalleDatosAcademicos.Name = "gvDetalleDatosAcademicos"
        Me.gvDetalleDatosAcademicos.NewItemRowText = "Nuevo Registro"
        'Me.gvDetalleDatosAcademicos.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValesMode.Disabled
        Me.gvDetalleDatosAcademicos.OptionsCustomization.AllowGroup = False
        Me.gvDetalleDatosAcademicos.OptionsView.ColumnAutoWidth = False
        Me.gvDetalleDatosAcademicos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gvDetalleDatosAcademicos.OptionsView.ShowGroupPanel = False
        '
        'NIVEL_ESTUDIO_ID
        '
        Me.NIVEL_ESTUDIO_ID.Caption = "Nivel de Estudios"
        Me.NIVEL_ESTUDIO_ID.ColumnEdit = Me.gleNivelEstudio
        Me.NIVEL_ESTUDIO_ID.FieldName = "NIVEL_ESTUDIO_ID"
        Me.NIVEL_ESTUDIO_ID.Name = "NIVEL_ESTUDIO_ID"
        Me.NIVEL_ESTUDIO_ID.ToolTip = "Escoger nivel de estudio"
        Me.NIVEL_ESTUDIO_ID.Visible = True
        Me.NIVEL_ESTUDIO_ID.VisibleIndex = 0
        Me.NIVEL_ESTUDIO_ID.Width = 142
        '
        'gleNivelEstudio
        '
        Me.gleNivelEstudio.AutoHeight = False
        Me.gleNivelEstudio.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleNivelEstudio.Name = "gleNivelEstudio"
        Me.gleNivelEstudio.NullText = ""
        Me.gleNivelEstudio.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'PERIODO_INI_ANO
        '
        Me.PERIODO_INI_ANO.Caption = "Año Inicio"
        Me.PERIODO_INI_ANO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PERIODO_INI_ANO.FieldName = "PERIODO_INI_ANO"
        Me.PERIODO_INI_ANO.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PERIODO_INI_ANO.Name = "PERIODO_INI_ANO"
        Me.PERIODO_INI_ANO.ToolTip = "Año inicial el cual comenzó el curso"
        Me.PERIODO_INI_ANO.Visible = True
        Me.PERIODO_INI_ANO.VisibleIndex = 1
        Me.PERIODO_INI_ANO.Width = 77
        '
        'PERIODO_FIN_ANO
        '
        Me.PERIODO_FIN_ANO.Caption = "Año Término"
        Me.PERIODO_FIN_ANO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PERIODO_FIN_ANO.FieldName = "PERIODO_FIN_ANO"
        Me.PERIODO_FIN_ANO.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PERIODO_FIN_ANO.Name = "PERIODO_FIN_ANO"
        Me.PERIODO_FIN_ANO.ToolTip = "Año final el cual comenzó el curso"
        Me.PERIODO_FIN_ANO.Visible = True
        Me.PERIODO_FIN_ANO.VisibleIndex = 2
        Me.PERIODO_FIN_ANO.Width = 100
        '
        'INSTITUCION_ESTUDIO_ID
        '
        Me.INSTITUCION_ESTUDIO_ID.Caption = "Institución"
        Me.INSTITUCION_ESTUDIO_ID.ColumnEdit = Me.gleInstitucionEstudio
        Me.INSTITUCION_ESTUDIO_ID.FieldName = "INSTITUCION_ESTUDIO_ID"
        Me.INSTITUCION_ESTUDIO_ID.Name = "INSTITUCION_ESTUDIO_ID"
        Me.INSTITUCION_ESTUDIO_ID.ToolTip = "Elegir institución de estudio"
        Me.INSTITUCION_ESTUDIO_ID.Visible = True
        Me.INSTITUCION_ESTUDIO_ID.VisibleIndex = 3
        Me.INSTITUCION_ESTUDIO_ID.Width = 225
        '
        'gleInstitucionEstudio
        '
        Me.gleInstitucionEstudio.AutoHeight = False
        Me.gleInstitucionEstudio.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleInstitucionEstudio.Name = "gleInstitucionEstudio"
        Me.gleInstitucionEstudio.NullText = ""
        Me.gleInstitucionEstudio.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'TITULO_OBTENIDO
        '
        Me.TITULO_OBTENIDO.Caption = "Título Obtenido"
        Me.TITULO_OBTENIDO.ColumnEdit = Me.txtTituloObtenido
        Me.TITULO_OBTENIDO.FieldName = "TITULO_OBTENIDO"
        Me.TITULO_OBTENIDO.Name = "TITULO_OBTENIDO"
        Me.TITULO_OBTENIDO.ToolTip = "Descripción titulo obtenido"
        Me.TITULO_OBTENIDO.Visible = True
        Me.TITULO_OBTENIDO.VisibleIndex = 4
        Me.TITULO_OBTENIDO.Width = 193
        '
        'txtTituloObtenido
        '
        Me.txtTituloObtenido.AutoHeight = False
        Me.txtTituloObtenido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTituloObtenido.MaxLength = 100
        Me.txtTituloObtenido.Name = "txtTituloObtenido"
        '
        'NUM_ANOS_ESTUDIO
        '
        Me.NUM_ANOS_ESTUDIO.Caption = "Periodo Estudio"
        Me.NUM_ANOS_ESTUDIO.ColumnEdit = Me.cbbPeriodo
        Me.NUM_ANOS_ESTUDIO.FieldName = "NUM_ANOS_ESTUDIO"
        Me.NUM_ANOS_ESTUDIO.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NUM_ANOS_ESTUDIO.Name = "NUM_ANOS_ESTUDIO"
        Me.NUM_ANOS_ESTUDIO.ToolTip = "Escriba en palabras los años o semestres de estudios"
        Me.NUM_ANOS_ESTUDIO.Visible = True
        Me.NUM_ANOS_ESTUDIO.VisibleIndex = 5
        Me.NUM_ANOS_ESTUDIO.Width = 107
        '
        'cbbPeriodo
        '
        Me.cbbPeriodo.AutoHeight = False
        Me.cbbPeriodo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbPeriodo.Items.AddRange(New Object() {"1 SEMESTRE", "2 SEMESTRES", "3 SEMESTRES", "4 SEMESTRES", "5 SEMESTRES", "6 SEMESTRES", "7 SEMESTRES", "8 SEMESTRES"})
        Me.cbbPeriodo.Name = "cbbPeriodo"
        '
        'PAIS_ID
        '
        Me.PAIS_ID.Caption = "País"
        Me.PAIS_ID.ColumnEdit = Me.glePais
        Me.PAIS_ID.FieldName = "PAIS_ID"
        Me.PAIS_ID.Name = "PAIS_ID"
        Me.PAIS_ID.ToolTip = "Elegir país"
        Me.PAIS_ID.Visible = True
        Me.PAIS_ID.VisibleIndex = 6
        '
        'glePais
        '
        Me.glePais.AutoHeight = False
        Me.glePais.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glePais.Name = "glePais"
        Me.glePais.NullText = ""
        Me.glePais.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'OBSERVACION
        '
        Me.OBSERVACION.Caption = "Mención"
        Me.OBSERVACION.ColumnEdit = Me.txtMencion
        Me.OBSERVACION.FieldName = "OBSERVACION"
        Me.OBSERVACION.Name = "OBSERVACION"
        Me.OBSERVACION.ToolTip = "Descripción adicional al título obtenido"
        Me.OBSERVACION.Visible = True
        Me.OBSERVACION.VisibleIndex = 7
        Me.OBSERVACION.Width = 165
        '
        'txtMencion
        '
        Me.txtMencion.AutoHeight = False
        Me.txtMencion.Name = "txtMencion"
        '
        'EMPLEADO_ID
        '
        Me.EMPLEADO_ID.Caption = "ID Empleado"
        Me.EMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.EMPLEADO_ID.Name = "EMPLEADO_ID"
        '
        'PERIODO_INI_MES
        '
        Me.PERIODO_INI_MES.Caption = "Mes inicial"
        Me.PERIODO_INI_MES.FieldName = "PERIODO_INI_MES"
        Me.PERIODO_INI_MES.Name = "PERIODO_INI_MES"
        '
        'PERIODO_FIN_MES
        '
        Me.PERIODO_FIN_MES.Caption = "Mes final"
        Me.PERIODO_FIN_MES.FieldName = "PERIODO_FIN_MES"
        Me.PERIODO_FIN_MES.Name = "PERIODO_FIN_MES"
        '
        'txtPeriodoEstudio
        '
        Me.txtPeriodoEstudio.AutoHeight = False
        Me.txtPeriodoEstudio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPeriodoEstudio.Name = "txtPeriodoEstudio"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.dgDatosAcademicos
        Me.GridView1.Name = "GridView1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.txtNombres)
        Me.GroupControl1.Controls.Add(Me.lblNombres)
        Me.GroupControl1.Controls.Add(Me.lblRut)
        Me.GroupControl1.Controls.Add(Me.leRut)
        Me.GroupControl1.Controls.Add(Me.txtDV)
        Me.GroupControl1.Location = New System.Drawing.Point(10, 10)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(720, 112)
        Me.GroupControl1.TabIndex = 52
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
        Me.txtNombres.Properties.ReadOnly = True
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
        'leRut
        '
        Me.leRut.Cursor = System.Windows.Forms.Cursors.Default
        Me.leRut.EditValue = ""
        Me.leRut.Location = New System.Drawing.Point(112, 40)
        Me.leRut.Name = "leRut"
        '
        'leRut.Properties
        '
        Me.leRut.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        Me.leRut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leRut.Properties.Mask.EditMask = "n0"
        Me.leRut.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.leRut.Properties.View = Me.GridLookUpEdit1View
        Me.leRut.Size = New System.Drawing.Size(144, 20)
        Me.leRut.TabIndex = 46
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
        Me.txtDV.Properties.ReadOnly = True
        Me.txtDV.Size = New System.Drawing.Size(32, 20)
        Me.txtDV.TabIndex = 2
        Me.txtDV.ToolTip = "Por favor registre el  dígito verificador"
        Me.txtDV.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'frmAntecedentesAcademicos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(752, 473)
        Me.Controls.Add(Me.dgDatosAcademicos)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frmAntecedentesAcademicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Antecedentes Académicos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgDatosAcademicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalleDatosAcademicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleNivelEstudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleInstitucionEstudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTituloObtenido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glePais, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMencion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodoEstudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leRut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvNivelEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvInstitucionesEdu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAntecedentesAcademicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        repositorio.Show()
        InitData()
        initCampoRut()
        initPaises()
        initLeNivelEstudios()
        initLeIntitucionesEdu()
        dgDatosAcademicos.Enabled = False
    End Sub

    Private Sub GridView2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gvDetalleDatosAcademicos.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("¿Desea Eliminar?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
            view.DeleteRow(view.FocusedRowHandle)
            empleado.actualizarDatosAcademicos()
        End If
    End Sub

    Private Sub GridView2_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvDetalleDatosAcademicos.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        view.SetRowCellValue(e.RowHandle, "EMPLEADO_ID", empleado.ID)
        view.SetRowCellValue(e.RowHandle, "PERIODO_INI_MES", 0)
        view.SetRowCellValue(e.RowHandle, "PERIODO_FIN_MES", 0)
    End Sub

    Private Sub GridView2_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvDetalleDatosAcademicos.RowUpdated
        empleado.actualizarDatosAcademicos()
    End Sub

    Private Sub gleNivelEstudio_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gleNivelEstudio.EditValueChanged
        Dim edit As DevExpress.XtraEditors.GridLookUpEdit = sender
        If Not edit.EditValue Is Nothing Then
            Dim rowHandle As Integer = edit.Properties.View.LocateByValue(0, edit.Properties.View.Columns(edit.Properties.ValueMember), edit.EditValue)
            nivelEstudio = edit.Properties.View.GetRowCellDisplayText(rowHandle, "TIPO_NIVEL_ESTUDIO_ID")
        End If
    End Sub

    Private Sub leRut_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leRut.EditValueChanged

    End Sub
End Class
