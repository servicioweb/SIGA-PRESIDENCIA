Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports cl.presidencia.Argo.Reportes


Public Class frmCargaFamiliar
    Inherits System.Windows.Forms.Form

    Private empleado As empleado
    Private IDCARGA As Integer
    Private oldRutCargaFam As Integer

    Private nuevoRegistro As Boolean = False
    Public tipoEdicion As Int16
    Private connectionString As String = Comun.ArgoConfiguracion.ConnectionString
    Private periodo As New Periodo

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
    Friend WithEvents lblTipoCargaFamiliar As System.Windows.Forms.Label
    Friend WithEvents lblEstadoCargaFamiliar As System.Windows.Forms.Label
    Friend WithEvents lblParentesco As System.Windows.Forms.Label
    Friend WithEvents lblGrupoFamiliar As System.Windows.Forms.Label
    Friend WithEvents lblApellidoPaterno As System.Windows.Forms.Label
    Friend WithEvents lblApellidoMaterno As System.Windows.Forms.Label
    Friend WithEvents lblNombres As System.Windows.Forms.Label
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicioVigencia As System.Windows.Forms.Label
    Friend WithEvents lblFechaTerminoVigencia As System.Windows.Forms.Label
    Friend WithEvents lblCausaTerminoAsignacion As System.Windows.Forms.Label
    Friend WithEvents lblNivelEstudios As System.Windows.Forms.Label
    Friend WithEvents leRut As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents rdgSexo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lueTipoCargaFamiliar As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueGrupoFamiliar As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueParentesco As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueCausaTerminoAsig As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueNivelEstudio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dedFechaNacimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dedFechaTerminoVigencia As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dedFechaInicioVigencia As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtApellidoPaterno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtApellidoMaterno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreCarga As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRut As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gvCargasFamiliares As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ID_Carga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APELLIDO_PAT_CARGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APELLIDO_MAT_CARGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOMBRES_CARGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GRUPO_FAMILIAR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ESTADO_CARGA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PARENTESCO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NIVEL_ESTUDIO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CAUSA_TERMINO_ASIG_FAM_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_VIGENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_VENCIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_NACIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RUT_CARGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIGITO_VER_CARGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dgcCargasFamiliares As DevExpress.XtraGrid.GridControl
    Friend WithEvents SEXO_CARGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION_TIPO_CARGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GCEditorDatos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GCDetalle As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pnlAcciones As System.Windows.Forms.Panel
    Friend WithEvents pnlDatosCargaFAM As System.Windows.Forms.Panel
    Friend WithEvents lblRetension As System.Windows.Forms.Label
    Friend WithEvents rgRetensionJudicial As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents rgCargaPorEstudios As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents CARGA_POR_ESTUDIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RETENSION_JUDICIAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lueEstadoCargaFamiliar As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DESCRIPCION_PARENTESCO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION_GRUPO_FAM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GRUPO_FAM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CARGA_FAM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDV As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblRutEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblRutCarga As System.Windows.Forms.Label
    Friend WithEvents lblCargaPorEstudio As System.Windows.Forms.Label
    Friend WithEvents lblTipoBeneficiario As System.Windows.Forms.Label
    Friend WithEvents txtNombreEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pnlDatosPersonalesCargaFAM As System.Windows.Forms.Panel
    Friend WithEvents gpcEmpleado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblTipoBeneficio As System.Windows.Forms.Label
    Friend WithEvents lueTipoBeneficio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueTipoCausante As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblTipoCausante As System.Windows.Forms.Label
    Friend WithEvents TIPO_CARGA_FAM_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOMBRE_CARGA_FAM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TIPO_BENEFICIO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TIPO_CAUSANTE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtRutCarga As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents lueTipoBeneficiario As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDV_CargaFAM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueRegimenEstudio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblRegimenEstudio As System.Windows.Forms.Label
    Friend WithEvents txtNumeroResolucion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNumeroResolucion As System.Windows.Forms.Label
    Friend WithEvents dedFechaInicioReconocimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFechaInicioReconocimiento As System.Windows.Forms.Label
    Friend WithEvents dedFechaFinReconocimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFechaFinReconocimiento As System.Windows.Forms.Label
    Friend WithEvents colREGIMEN_ESTUDIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INICIO_RECONOCIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_FIN_RECONOCIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUMERO_RESOLUCION As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblApellidoMaterno = New System.Windows.Forms.Label()
        Me.lblApellidoPaterno = New System.Windows.Forms.Label()
        Me.lblGrupoFamiliar = New System.Windows.Forms.Label()
        Me.lblParentesco = New System.Windows.Forms.Label()
        Me.lblEstadoCargaFamiliar = New System.Windows.Forms.Label()
        Me.lblTipoCargaFamiliar = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblFechaInicioVigencia = New System.Windows.Forms.Label()
        Me.lblFechaTerminoVigencia = New System.Windows.Forms.Label()
        Me.lblCausaTerminoAsignacion = New System.Windows.Forms.Label()
        Me.lblNivelEstudios = New System.Windows.Forms.Label()
        Me.gpcEmpleado = New DevExpress.XtraEditors.GroupControl()
        Me.lueTipoBeneficiario = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtNombreEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.lblTipoBeneficiario = New System.Windows.Forms.Label()
        Me.txtDV = New DevExpress.XtraEditors.TextEdit()
        Me.lblRutEmpleado = New System.Windows.Forms.Label()
        Me.leRut = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCEditorDatos = New DevExpress.XtraEditors.GroupControl()
        Me.pnlDatosPersonalesCargaFAM = New System.Windows.Forms.Panel()
        Me.txtApellidoPaterno = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreCarga = New DevExpress.XtraEditors.TextEdit()
        Me.txtApellidoMaterno = New DevExpress.XtraEditors.TextEdit()
        Me.lblRutCarga = New System.Windows.Forms.Label()
        Me.txtRut = New DevExpress.XtraEditors.TextEdit()
        Me.lueGrupoFamiliar = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueParentesco = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.rdgSexo = New DevExpress.XtraEditors.RadioGroup()
        Me.lueNivelEstudio = New DevExpress.XtraEditors.LookUpEdit()
        Me.dedFechaNacimiento = New DevExpress.XtraEditors.DateEdit()
        Me.lueTipoBeneficio = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblTipoBeneficio = New System.Windows.Forms.Label()
        Me.txtDV_CargaFAM = New DevExpress.XtraEditors.TextEdit()
        Me.pnlAcciones = New System.Windows.Forms.Panel()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.pnlDatosCargaFAM = New System.Windows.Forms.Panel()
        Me.dedFechaFinReconocimiento = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaFinReconocimiento = New System.Windows.Forms.Label()
        Me.dedFechaInicioReconocimiento = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaInicioReconocimiento = New System.Windows.Forms.Label()
        Me.lblNumeroResolucion = New System.Windows.Forms.Label()
        Me.txtNumeroResolucion = New DevExpress.XtraEditors.TextEdit()
        Me.lblRegimenEstudio = New System.Windows.Forms.Label()
        Me.lueRegimenEstudio = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblTipoCausante = New System.Windows.Forms.Label()
        Me.lueTipoCausante = New DevExpress.XtraEditors.LookUpEdit()
        Me.dedFechaInicioVigencia = New DevExpress.XtraEditors.DateEdit()
        Me.dedFechaTerminoVigencia = New DevExpress.XtraEditors.DateEdit()
        Me.lueEstadoCargaFamiliar = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueTipoCargaFamiliar = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueCausaTerminoAsig = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblRetension = New System.Windows.Forms.Label()
        Me.rgRetensionJudicial = New DevExpress.XtraEditors.RadioGroup()
        Me.rgCargaPorEstudios = New DevExpress.XtraEditors.RadioGroup()
        Me.lblCargaPorEstudio = New System.Windows.Forms.Label()
        Me.GCDetalle = New DevExpress.XtraEditors.GroupControl()
        Me.dgcCargasFamiliares = New DevExpress.XtraGrid.GridControl()
        Me.gvCargasFamiliares = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NOMBRE_CARGA_FAM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.APELLIDO_PAT_CARGA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.APELLIDO_MAT_CARGA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION_PARENTESCO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION_TIPO_CARGA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION_GRUPO_FAM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NOMBRES_CARGA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ID_Carga = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TIPO_CARGA_FAM_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GRUPO_FAMILIAR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ESTADO_CARGA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PARENTESCO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NIVEL_ESTUDIO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CAUSA_TERMINO_ASIG_FAM_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_VIGENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_VENCIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA_NACIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RUT_CARGA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtRutCarga = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DIGITO_VER_CARGA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SEXO_CARGA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CARGA_POR_ESTUDIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RETENSION_JUDICIAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GRUPO_FAM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CARGA_FAM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TIPO_BENEFICIO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TIPO_CAUSANTE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colREGIMEN_ESTUDIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_INICIO_RECONOCIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_FIN_RECONOCIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNUMERO_RESOLUCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.gpcEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcEmpleado.SuspendLayout()
        CType(Me.lueTipoBeneficiario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leRut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCEditorDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCEditorDatos.SuspendLayout()
        Me.pnlDatosPersonalesCargaFAM.SuspendLayout()
        CType(Me.txtApellidoPaterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreCarga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoMaterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueGrupoFamiliar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueParentesco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgSexo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueNivelEstudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaNacimiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaNacimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTipoBeneficio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDV_CargaFAM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAcciones.SuspendLayout()
        Me.pnlDatosCargaFAM.SuspendLayout()
        CType(Me.dedFechaFinReconocimiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaFinReconocimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaInicioReconocimiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaInicioReconocimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroResolucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueRegimenEstudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTipoCausante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaInicioVigencia.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaInicioVigencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaTerminoVigencia.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaTerminoVigencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueEstadoCargaFamiliar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTipoCargaFamiliar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCausaTerminoAsig.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgRetensionJudicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgCargaPorEstudios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCDetalle.SuspendLayout()
        CType(Me.dgcCargasFamiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCargasFamiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRutCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(8, 84)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(104, 16)
        Me.lblFechaNacimiento.TabIndex = 9
        Me.lblFechaNacimiento.Text = "Fecha Nacimiento"
        Me.lblFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblApellidoMaterno
        '
        Me.lblApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoMaterno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblApellidoMaterno.Location = New System.Drawing.Point(11, 36)
        Me.lblApellidoMaterno.Name = "lblApellidoMaterno"
        Me.lblApellidoMaterno.Size = New System.Drawing.Size(104, 16)
        Me.lblApellidoMaterno.TabIndex = 5
        Me.lblApellidoMaterno.Text = "Apellido Materno"
        Me.lblApellidoMaterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblApellidoPaterno
        '
        Me.lblApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoPaterno.ForeColor = System.Drawing.Color.Black
        Me.lblApellidoPaterno.Location = New System.Drawing.Point(8, 12)
        Me.lblApellidoPaterno.Name = "lblApellidoPaterno"
        Me.lblApellidoPaterno.Size = New System.Drawing.Size(104, 16)
        Me.lblApellidoPaterno.TabIndex = 4
        Me.lblApellidoPaterno.Text = "Apellido Paterno"
        Me.lblApellidoPaterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGrupoFamiliar
        '
        Me.lblGrupoFamiliar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupoFamiliar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGrupoFamiliar.Location = New System.Drawing.Point(25, 60)
        Me.lblGrupoFamiliar.Name = "lblGrupoFamiliar"
        Me.lblGrupoFamiliar.Size = New System.Drawing.Size(88, 16)
        Me.lblGrupoFamiliar.TabIndex = 3
        Me.lblGrupoFamiliar.Text = "Grupo Familiar"
        Me.lblGrupoFamiliar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblParentesco
        '
        Me.lblParentesco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParentesco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblParentesco.Location = New System.Drawing.Point(424, 60)
        Me.lblParentesco.Name = "lblParentesco"
        Me.lblParentesco.Size = New System.Drawing.Size(72, 16)
        Me.lblParentesco.TabIndex = 2
        Me.lblParentesco.Text = "Parentesco"
        Me.lblParentesco.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEstadoCargaFamiliar
        '
        Me.lblEstadoCargaFamiliar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCargaFamiliar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEstadoCargaFamiliar.Location = New System.Drawing.Point(176, 8)
        Me.lblEstadoCargaFamiliar.Name = "lblEstadoCargaFamiliar"
        Me.lblEstadoCargaFamiliar.Size = New System.Drawing.Size(48, 16)
        Me.lblEstadoCargaFamiliar.TabIndex = 1
        Me.lblEstadoCargaFamiliar.Text = "Estado"
        Me.lblEstadoCargaFamiliar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoCargaFamiliar
        '
        Me.lblTipoCargaFamiliar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoCargaFamiliar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTipoCargaFamiliar.Location = New System.Drawing.Point(168, 48)
        Me.lblTipoCargaFamiliar.Name = "lblTipoCargaFamiliar"
        Me.lblTipoCargaFamiliar.Size = New System.Drawing.Size(120, 16)
        Me.lblTipoCargaFamiliar.TabIndex = 0
        Me.lblTipoCargaFamiliar.Text = "Tipo Carga Familiar"
        Me.lblTipoCargaFamiliar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombres
        '
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNombres.Location = New System.Drawing.Point(440, 8)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(56, 20)
        Me.lblNombres.TabIndex = 6
        Me.lblNombres.Text = "Nombres"
        Me.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaInicioVigencia
        '
        Me.lblFechaInicioVigencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInicioVigencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaInicioVigencia.Location = New System.Drawing.Point(8, 8)
        Me.lblFechaInicioVigencia.Name = "lblFechaInicioVigencia"
        Me.lblFechaInicioVigencia.Size = New System.Drawing.Size(128, 16)
        Me.lblFechaInicioVigencia.TabIndex = 10
        Me.lblFechaInicioVigencia.Text = "Fecha Inicio Vigencia"
        Me.lblFechaInicioVigencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaTerminoVigencia
        '
        Me.lblFechaTerminoVigencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaTerminoVigencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaTerminoVigencia.Location = New System.Drawing.Point(8, 48)
        Me.lblFechaTerminoVigencia.Name = "lblFechaTerminoVigencia"
        Me.lblFechaTerminoVigencia.Size = New System.Drawing.Size(144, 16)
        Me.lblFechaTerminoVigencia.TabIndex = 11
        Me.lblFechaTerminoVigencia.Text = "Fecha Término Vigencia"
        Me.lblFechaTerminoVigencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCausaTerminoAsignacion
        '
        Me.lblCausaTerminoAsignacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCausaTerminoAsignacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCausaTerminoAsignacion.Location = New System.Drawing.Point(368, 8)
        Me.lblCausaTerminoAsignacion.Name = "lblCausaTerminoAsignacion"
        Me.lblCausaTerminoAsignacion.Size = New System.Drawing.Size(144, 16)
        Me.lblCausaTerminoAsignacion.TabIndex = 12
        Me.lblCausaTerminoAsignacion.Text = "Causa Término Asig.Fam."
        Me.lblCausaTerminoAsignacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNivelEstudios
        '
        Me.lblNivelEstudios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNivelEstudios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNivelEstudios.Location = New System.Drawing.Point(8, 108)
        Me.lblNivelEstudios.Name = "lblNivelEstudios"
        Me.lblNivelEstudios.Size = New System.Drawing.Size(104, 16)
        Me.lblNivelEstudios.TabIndex = 15
        Me.lblNivelEstudios.Text = "Nivel de Estudios"
        Me.lblNivelEstudios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gpcEmpleado
        '
        Me.gpcEmpleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcEmpleado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcEmpleado.AppearanceCaption.Options.UseFont = True
        Me.gpcEmpleado.Controls.Add(Me.lueTipoBeneficiario)
        Me.gpcEmpleado.Controls.Add(Me.txtNombreEmpleado)
        Me.gpcEmpleado.Controls.Add(Me.lblTipoBeneficiario)
        Me.gpcEmpleado.Controls.Add(Me.txtDV)
        Me.gpcEmpleado.Controls.Add(Me.lblRutEmpleado)
        Me.gpcEmpleado.Controls.Add(Me.leRut)
        Me.gpcEmpleado.Location = New System.Drawing.Point(0, 0)
        Me.gpcEmpleado.Name = "gpcEmpleado"
        Me.gpcEmpleado.Size = New System.Drawing.Size(864, 96)
        Me.gpcEmpleado.TabIndex = 46
        Me.gpcEmpleado.Text = "Empleado"
        '
        'lueTipoBeneficiario
        '
        Me.lueTipoBeneficiario.Enabled = False
        Me.lueTipoBeneficiario.Location = New System.Drawing.Point(128, 64)
        Me.lueTipoBeneficiario.Name = "lueTipoBeneficiario"
        Me.lueTipoBeneficiario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, False)})
        Me.lueTipoBeneficiario.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name6", "Name6")})
        Me.lueTipoBeneficiario.Properties.NullText = ""
        Me.lueTipoBeneficiario.Size = New System.Drawing.Size(328, 20)
        Me.lueTipoBeneficiario.TabIndex = 53
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Enabled = False
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(288, 40)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNombreEmpleado.Properties.Appearance.Options.UseFont = True
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(352, 20)
        Me.txtNombreEmpleado.TabIndex = 2
        '
        'lblTipoBeneficiario
        '
        Me.lblTipoBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoBeneficiario.Location = New System.Drawing.Point(16, 68)
        Me.lblTipoBeneficiario.Name = "lblTipoBeneficiario"
        Me.lblTipoBeneficiario.Size = New System.Drawing.Size(104, 16)
        Me.lblTipoBeneficiario.TabIndex = 52
        Me.lblTipoBeneficiario.Text = "Tipo Beneficiario"
        Me.lblTipoBeneficiario.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDV
        '
        Me.txtDV.Enabled = False
        Me.txtDV.Location = New System.Drawing.Point(248, 40)
        Me.txtDV.Name = "txtDV"
        Me.txtDV.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDV.Properties.MaxLength = 1
        Me.txtDV.Size = New System.Drawing.Size(32, 20)
        Me.txtDV.TabIndex = 1
        Me.txtDV.ToolTip = "Por favor registre el  dígito verificador"
        Me.txtDV.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'lblRutEmpleado
        '
        Me.lblRutEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRutEmpleado.Location = New System.Drawing.Point(8, 44)
        Me.lblRutEmpleado.Name = "lblRutEmpleado"
        Me.lblRutEmpleado.Size = New System.Drawing.Size(112, 16)
        Me.lblRutEmpleado.TabIndex = 49
        Me.lblRutEmpleado.Text = "Rut Empleado"
        Me.lblRutEmpleado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'leRut
        '
        Me.leRut.Cursor = System.Windows.Forms.Cursors.Default
        Me.leRut.EditValue = ""
        Me.leRut.Location = New System.Drawing.Point(128, 40)
        Me.leRut.Name = "leRut"
        Me.leRut.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.leRut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leRut.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.leRut.Properties.View = Me.GridLookUpEdit1View
        Me.leRut.Size = New System.Drawing.Size(112, 20)
        Me.leRut.TabIndex = 0
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.AppearancePrint.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridLookUpEdit1View.AppearancePrint.OddRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridLookUpEdit1View.AppearancePrint.OddRow.Options.UseBackColor = True
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GCEditorDatos
        '
        Me.GCEditorDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCEditorDatos.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GCEditorDatos.AppearanceCaption.Options.UseFont = True
        Me.GCEditorDatos.Controls.Add(Me.pnlDatosPersonalesCargaFAM)
        Me.GCEditorDatos.Controls.Add(Me.pnlAcciones)
        Me.GCEditorDatos.Controls.Add(Me.pnlDatosCargaFAM)
        Me.GCEditorDatos.Controls.Add(Me.GCDetalle)
        Me.GCEditorDatos.Location = New System.Drawing.Point(0, 96)
        Me.GCEditorDatos.Name = "GCEditorDatos"
        Me.GCEditorDatos.Size = New System.Drawing.Size(864, 520)
        Me.GCEditorDatos.TabIndex = 47
        Me.GCEditorDatos.Text = "Carga Familiar"
        '
        'pnlDatosPersonalesCargaFAM
        '
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.lblApellidoPaterno)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.txtApellidoPaterno)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.lblNombres)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.txtNombreCarga)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.txtApellidoMaterno)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.lblApellidoMaterno)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.lblRutCarga)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.txtRut)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.lblGrupoFamiliar)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.lueGrupoFamiliar)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.lblParentesco)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.lueParentesco)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.lblSexo)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.rdgSexo)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.lblNivelEstudios)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.lueNivelEstudio)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.lblFechaNacimiento)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.dedFechaNacimiento)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.lueTipoBeneficio)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.lblTipoBeneficio)
        Me.pnlDatosPersonalesCargaFAM.Controls.Add(Me.txtDV_CargaFAM)
        Me.pnlDatosPersonalesCargaFAM.Location = New System.Drawing.Point(8, 24)
        Me.pnlDatosPersonalesCargaFAM.Name = "pnlDatosPersonalesCargaFAM"
        Me.pnlDatosPersonalesCargaFAM.Size = New System.Drawing.Size(824, 128)
        Me.pnlDatosPersonalesCargaFAM.TabIndex = 95
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.EnterMoveNextControl = True
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(122, 8)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoPaterno.Properties.MaxLength = 30
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(294, 20)
        Me.txtApellidoPaterno.TabIndex = 4
        '
        'txtNombreCarga
        '
        Me.txtNombreCarga.EnterMoveNextControl = True
        Me.txtNombreCarga.Location = New System.Drawing.Point(504, 8)
        Me.txtNombreCarga.Name = "txtNombreCarga"
        Me.txtNombreCarga.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreCarga.Properties.MaxLength = 30
        Me.txtNombreCarga.Size = New System.Drawing.Size(262, 20)
        Me.txtNombreCarga.TabIndex = 5
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.EnterMoveNextControl = True
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(122, 32)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoMaterno.Properties.MaxLength = 30
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(294, 20)
        Me.txtApellidoMaterno.TabIndex = 6
        '
        'lblRutCarga
        '
        Me.lblRutCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRutCarga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRutCarga.Location = New System.Drawing.Point(456, 36)
        Me.lblRutCarga.Name = "lblRutCarga"
        Me.lblRutCarga.Size = New System.Drawing.Size(40, 16)
        Me.lblRutCarga.TabIndex = 60
        Me.lblRutCarga.Text = "Rut"
        Me.lblRutCarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRut
        '
        Me.txtRut.EnterMoveNextControl = True
        Me.txtRut.Location = New System.Drawing.Point(504, 32)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRut.Properties.MaxLength = 30
        Me.txtRut.Size = New System.Drawing.Size(127, 20)
        Me.txtRut.TabIndex = 7
        '
        'lueGrupoFamiliar
        '
        Me.lueGrupoFamiliar.EditValue = "1"
        Me.lueGrupoFamiliar.Location = New System.Drawing.Point(122, 56)
        Me.lueGrupoFamiliar.Name = "lueGrupoFamiliar"
        Me.lueGrupoFamiliar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueGrupoFamiliar.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("(None)", "(None)")})
        Me.lueGrupoFamiliar.Size = New System.Drawing.Size(294, 20)
        Me.lueGrupoFamiliar.TabIndex = 9
        '
        'lueParentesco
        '
        Me.lueParentesco.EditValue = ""
        Me.lueParentesco.Location = New System.Drawing.Point(504, 56)
        Me.lueParentesco.Name = "lueParentesco"
        Me.lueParentesco.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueParentesco.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("(None)", "(None)")})
        Me.lueParentesco.Size = New System.Drawing.Size(168, 20)
        Me.lueParentesco.TabIndex = 10
        '
        'lblSexo
        '
        Me.lblSexo.Location = New System.Drawing.Point(464, 88)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblSexo.Size = New System.Drawing.Size(32, 16)
        Me.lblSexo.TabIndex = 64
        Me.lblSexo.Text = "Sexo"
        Me.lblSexo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'rdgSexo
        '
        Me.rdgSexo.Location = New System.Drawing.Point(504, 80)
        Me.rdgSexo.Name = "rdgSexo"
        Me.rdgSexo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rdgSexo.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.rdgSexo.Properties.Appearance.Options.UseBackColor = True
        Me.rdgSexo.Properties.Appearance.Options.UseFont = True
        Me.rdgSexo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rdgSexo.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.rdgSexo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("M", "Masculino"), New DevExpress.XtraEditors.Controls.RadioGroupItem("F", "Femenino")})
        Me.rdgSexo.Size = New System.Drawing.Size(184, 24)
        Me.rdgSexo.TabIndex = 12
        '
        'lueNivelEstudio
        '
        Me.lueNivelEstudio.EditValue = ""
        Me.lueNivelEstudio.Location = New System.Drawing.Point(122, 104)
        Me.lueNivelEstudio.Name = "lueNivelEstudio"
        Me.lueNivelEstudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueNivelEstudio.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("(None)", "(None)")})
        Me.lueNivelEstudio.Size = New System.Drawing.Size(168, 20)
        Me.lueNivelEstudio.TabIndex = 13
        '
        'dedFechaNacimiento
        '
        Me.dedFechaNacimiento.EditValue = New Date(2006, 11, 20, 15, 12, 2, 900)
        Me.dedFechaNacimiento.Location = New System.Drawing.Point(122, 80)
        Me.dedFechaNacimiento.Name = "dedFechaNacimiento"
        Me.dedFechaNacimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaNacimiento.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaNacimiento.Size = New System.Drawing.Size(168, 20)
        Me.dedFechaNacimiento.TabIndex = 11
        '
        'lueTipoBeneficio
        '
        Me.lueTipoBeneficio.EditValue = ""
        Me.lueTipoBeneficio.Location = New System.Drawing.Point(504, 104)
        Me.lueTipoBeneficio.Name = "lueTipoBeneficio"
        Me.lueTipoBeneficio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTipoBeneficio.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("(None)", "(None)")})
        Me.lueTipoBeneficio.Size = New System.Drawing.Size(168, 20)
        Me.lueTipoBeneficio.TabIndex = 14
        '
        'lblTipoBeneficio
        '
        Me.lblTipoBeneficio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoBeneficio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTipoBeneficio.Location = New System.Drawing.Point(408, 108)
        Me.lblTipoBeneficio.Name = "lblTipoBeneficio"
        Me.lblTipoBeneficio.Size = New System.Drawing.Size(88, 16)
        Me.lblTipoBeneficio.TabIndex = 55
        Me.lblTipoBeneficio.Text = "Tipo Beneficio"
        Me.lblTipoBeneficio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDV_CargaFAM
        '
        Me.txtDV_CargaFAM.EnterMoveNextControl = True
        Me.txtDV_CargaFAM.Location = New System.Drawing.Point(640, 32)
        Me.txtDV_CargaFAM.Name = "txtDV_CargaFAM"
        Me.txtDV_CargaFAM.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDV_CargaFAM.Properties.MaxLength = 1
        Me.txtDV_CargaFAM.Size = New System.Drawing.Size(32, 20)
        Me.txtDV_CargaFAM.TabIndex = 8
        Me.txtDV_CargaFAM.ToolTip = "Por favor registre el  dígito verificador"
        Me.txtDV_CargaFAM.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'pnlAcciones
        '
        Me.pnlAcciones.Controls.Add(Me.btnNuevo)
        Me.pnlAcciones.Controls.Add(Me.btnAgregar)
        Me.pnlAcciones.Location = New System.Drawing.Point(272, 288)
        Me.pnlAcciones.Name = "pnlAcciones"
        Me.pnlAcciones.Size = New System.Drawing.Size(256, 32)
        Me.pnlAcciones.TabIndex = 94
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(160, 8)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 24
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(16, 8)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 23
        Me.btnAgregar.Text = "Guardar"
        '
        'pnlDatosCargaFAM
        '
        Me.pnlDatosCargaFAM.Controls.Add(Me.dedFechaFinReconocimiento)
        Me.pnlDatosCargaFAM.Controls.Add(Me.lblFechaFinReconocimiento)
        Me.pnlDatosCargaFAM.Controls.Add(Me.dedFechaInicioReconocimiento)
        Me.pnlDatosCargaFAM.Controls.Add(Me.lblFechaInicioReconocimiento)
        Me.pnlDatosCargaFAM.Controls.Add(Me.lblNumeroResolucion)
        Me.pnlDatosCargaFAM.Controls.Add(Me.txtNumeroResolucion)
        Me.pnlDatosCargaFAM.Controls.Add(Me.lblRegimenEstudio)
        Me.pnlDatosCargaFAM.Controls.Add(Me.lueRegimenEstudio)
        Me.pnlDatosCargaFAM.Controls.Add(Me.lblTipoCausante)
        Me.pnlDatosCargaFAM.Controls.Add(Me.lueTipoCausante)
        Me.pnlDatosCargaFAM.Controls.Add(Me.dedFechaInicioVigencia)
        Me.pnlDatosCargaFAM.Controls.Add(Me.lblFechaInicioVigencia)
        Me.pnlDatosCargaFAM.Controls.Add(Me.lblFechaTerminoVigencia)
        Me.pnlDatosCargaFAM.Controls.Add(Me.dedFechaTerminoVigencia)
        Me.pnlDatosCargaFAM.Controls.Add(Me.lueEstadoCargaFamiliar)
        Me.pnlDatosCargaFAM.Controls.Add(Me.lblEstadoCargaFamiliar)
        Me.pnlDatosCargaFAM.Controls.Add(Me.lblTipoCargaFamiliar)
        Me.pnlDatosCargaFAM.Controls.Add(Me.lueTipoCargaFamiliar)
        Me.pnlDatosCargaFAM.Controls.Add(Me.lblCausaTerminoAsignacion)
        Me.pnlDatosCargaFAM.Controls.Add(Me.lueCausaTerminoAsig)
        Me.pnlDatosCargaFAM.Controls.Add(Me.lblRetension)
        Me.pnlDatosCargaFAM.Controls.Add(Me.rgRetensionJudicial)
        Me.pnlDatosCargaFAM.Controls.Add(Me.rgCargaPorEstudios)
        Me.pnlDatosCargaFAM.Controls.Add(Me.lblCargaPorEstudio)
        Me.pnlDatosCargaFAM.Location = New System.Drawing.Point(8, 152)
        Me.pnlDatosCargaFAM.Name = "pnlDatosCargaFAM"
        Me.pnlDatosCargaFAM.Size = New System.Drawing.Size(824, 128)
        Me.pnlDatosCargaFAM.TabIndex = 93
        '
        'dedFechaFinReconocimiento
        '
        Me.dedFechaFinReconocimiento.EditValue = New Date(2006, 11, 20, 15, 12, 2, 900)
        Me.dedFechaFinReconocimiento.Location = New System.Drawing.Point(504, 104)
        Me.dedFechaFinReconocimiento.Name = "dedFechaFinReconocimiento"
        Me.dedFechaFinReconocimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaFinReconocimiento.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaFinReconocimiento.Size = New System.Drawing.Size(120, 20)
        Me.dedFechaFinReconocimiento.TabIndex = 74
        '
        'lblFechaFinReconocimiento
        '
        Me.lblFechaFinReconocimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFinReconocimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaFinReconocimiento.Location = New System.Drawing.Point(504, 88)
        Me.lblFechaFinReconocimiento.Name = "lblFechaFinReconocimiento"
        Me.lblFechaFinReconocimiento.Size = New System.Drawing.Size(112, 16)
        Me.lblFechaFinReconocimiento.TabIndex = 73
        Me.lblFechaFinReconocimiento.Text = "Fecha Fin Reconoc."
        Me.lblFechaFinReconocimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dedFechaInicioReconocimiento
        '
        Me.dedFechaInicioReconocimiento.EditValue = New Date(2006, 11, 20, 15, 12, 2, 900)
        Me.dedFechaInicioReconocimiento.Location = New System.Drawing.Point(368, 104)
        Me.dedFechaInicioReconocimiento.Name = "dedFechaInicioReconocimiento"
        Me.dedFechaInicioReconocimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaInicioReconocimiento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dedFechaInicioReconocimiento.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaInicioReconocimiento.Size = New System.Drawing.Size(120, 20)
        Me.dedFechaInicioReconocimiento.TabIndex = 72
        '
        'lblFechaInicioReconocimiento
        '
        Me.lblFechaInicioReconocimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInicioReconocimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaInicioReconocimiento.Location = New System.Drawing.Point(368, 88)
        Me.lblFechaInicioReconocimiento.Name = "lblFechaInicioReconocimiento"
        Me.lblFechaInicioReconocimiento.Size = New System.Drawing.Size(128, 16)
        Me.lblFechaInicioReconocimiento.TabIndex = 71
        Me.lblFechaInicioReconocimiento.Text = "Fecha Inicio Reconoc."
        Me.lblFechaInicioReconocimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumeroResolucion
        '
        Me.lblNumeroResolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroResolucion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNumeroResolucion.Location = New System.Drawing.Point(176, 88)
        Me.lblNumeroResolucion.Name = "lblNumeroResolucion"
        Me.lblNumeroResolucion.Size = New System.Drawing.Size(128, 16)
        Me.lblNumeroResolucion.TabIndex = 70
        Me.lblNumeroResolucion.Text = "Número Resolución"
        Me.lblNumeroResolucion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNumeroResolucion
        '
        Me.txtNumeroResolucion.EnterMoveNextControl = True
        Me.txtNumeroResolucion.Location = New System.Drawing.Point(176, 104)
        Me.txtNumeroResolucion.Name = "txtNumeroResolucion"
        Me.txtNumeroResolucion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroResolucion.Properties.MaxLength = 30
        Me.txtNumeroResolucion.Size = New System.Drawing.Size(168, 20)
        Me.txtNumeroResolucion.TabIndex = 69
        '
        'lblRegimenEstudio
        '
        Me.lblRegimenEstudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegimenEstudio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRegimenEstudio.Location = New System.Drawing.Point(16, 88)
        Me.lblRegimenEstudio.Name = "lblRegimenEstudio"
        Me.lblRegimenEstudio.Size = New System.Drawing.Size(104, 16)
        Me.lblRegimenEstudio.TabIndex = 68
        Me.lblRegimenEstudio.Text = "Regimen Estudio"
        Me.lblRegimenEstudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueRegimenEstudio
        '
        Me.lueRegimenEstudio.EditValue = ""
        Me.lueRegimenEstudio.Location = New System.Drawing.Point(16, 104)
        Me.lueRegimenEstudio.Name = "lueRegimenEstudio"
        Me.lueRegimenEstudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueRegimenEstudio.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("(None)", "(None)")})
        Me.lueRegimenEstudio.Size = New System.Drawing.Size(120, 20)
        Me.lueRegimenEstudio.TabIndex = 67
        '
        'lblTipoCausante
        '
        Me.lblTipoCausante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoCausante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTipoCausante.Location = New System.Drawing.Point(368, 48)
        Me.lblTipoCausante.Name = "lblTipoCausante"
        Me.lblTipoCausante.Size = New System.Drawing.Size(88, 16)
        Me.lblTipoCausante.TabIndex = 66
        Me.lblTipoCausante.Text = "Tipo Causante"
        Me.lblTipoCausante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueTipoCausante
        '
        Me.lueTipoCausante.EditValue = ""
        Me.lueTipoCausante.Location = New System.Drawing.Point(368, 64)
        Me.lueTipoCausante.Name = "lueTipoCausante"
        Me.lueTipoCausante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTipoCausante.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("(None)", "(None)")})
        Me.lueTipoCausante.Size = New System.Drawing.Size(408, 20)
        Me.lueTipoCausante.TabIndex = 22
        '
        'dedFechaInicioVigencia
        '
        Me.dedFechaInicioVigencia.EditValue = New Date(2006, 11, 20, 15, 12, 2, 900)
        Me.dedFechaInicioVigencia.Location = New System.Drawing.Point(16, 24)
        Me.dedFechaInicioVigencia.Name = "dedFechaInicioVigencia"
        Me.dedFechaInicioVigencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaInicioVigencia.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaInicioVigencia.Size = New System.Drawing.Size(120, 20)
        Me.dedFechaInicioVigencia.TabIndex = 15
        '
        'dedFechaTerminoVigencia
        '
        Me.dedFechaTerminoVigencia.EditValue = New Date(2006, 11, 20, 15, 12, 2, 900)
        Me.dedFechaTerminoVigencia.Location = New System.Drawing.Point(16, 64)
        Me.dedFechaTerminoVigencia.Name = "dedFechaTerminoVigencia"
        Me.dedFechaTerminoVigencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaTerminoVigencia.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaTerminoVigencia.Size = New System.Drawing.Size(120, 20)
        Me.dedFechaTerminoVigencia.TabIndex = 20
        '
        'lueEstadoCargaFamiliar
        '
        Me.lueEstadoCargaFamiliar.EditValue = "1"
        Me.lueEstadoCargaFamiliar.Location = New System.Drawing.Point(176, 24)
        Me.lueEstadoCargaFamiliar.Name = "lueEstadoCargaFamiliar"
        Me.lueEstadoCargaFamiliar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueEstadoCargaFamiliar.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("(None)", "(None)")})
        Me.lueEstadoCargaFamiliar.Size = New System.Drawing.Size(168, 20)
        Me.lueEstadoCargaFamiliar.TabIndex = 16
        '
        'lueTipoCargaFamiliar
        '
        Me.lueTipoCargaFamiliar.EditValue = ""
        Me.lueTipoCargaFamiliar.Location = New System.Drawing.Point(176, 64)
        Me.lueTipoCargaFamiliar.Name = "lueTipoCargaFamiliar"
        Me.lueTipoCargaFamiliar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTipoCargaFamiliar.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("(None)", "(None)")})
        Me.lueTipoCargaFamiliar.Size = New System.Drawing.Size(168, 20)
        Me.lueTipoCargaFamiliar.TabIndex = 21
        '
        'lueCausaTerminoAsig
        '
        Me.lueCausaTerminoAsig.EditValue = "1"
        Me.lueCausaTerminoAsig.Location = New System.Drawing.Point(368, 25)
        Me.lueCausaTerminoAsig.Name = "lueCausaTerminoAsig"
        Me.lueCausaTerminoAsig.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCausaTerminoAsig.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("(None)", "(None)")})
        Me.lueCausaTerminoAsig.Size = New System.Drawing.Size(168, 20)
        Me.lueCausaTerminoAsig.TabIndex = 17
        '
        'lblRetension
        '
        Me.lblRetension.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetension.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRetension.Location = New System.Drawing.Point(544, 8)
        Me.lblRetension.Name = "lblRetension"
        Me.lblRetension.Size = New System.Drawing.Size(112, 16)
        Me.lblRetension.TabIndex = 65
        Me.lblRetension.Text = "Retención Judicial"
        Me.lblRetension.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rgRetensionJudicial
        '
        Me.rgRetensionJudicial.EditValue = "N"
        Me.rgRetensionJudicial.Location = New System.Drawing.Point(568, 24)
        Me.rgRetensionJudicial.Name = "rgRetensionJudicial"
        Me.rgRetensionJudicial.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgRetensionJudicial.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.rgRetensionJudicial.Properties.Appearance.Options.UseBackColor = True
        Me.rgRetensionJudicial.Properties.Appearance.Options.UseFont = True
        Me.rgRetensionJudicial.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rgRetensionJudicial.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.rgRetensionJudicial.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Si"), New DevExpress.XtraEditors.Controls.RadioGroupItem("N", "No")})
        Me.rgRetensionJudicial.Size = New System.Drawing.Size(80, 24)
        Me.rgRetensionJudicial.TabIndex = 18
        '
        'rgCargaPorEstudios
        '
        Me.rgCargaPorEstudios.EditValue = "N"
        Me.rgCargaPorEstudios.Location = New System.Drawing.Point(696, 24)
        Me.rgCargaPorEstudios.Name = "rgCargaPorEstudios"
        Me.rgCargaPorEstudios.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgCargaPorEstudios.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.rgCargaPorEstudios.Properties.Appearance.Options.UseBackColor = True
        Me.rgCargaPorEstudios.Properties.Appearance.Options.UseFont = True
        Me.rgCargaPorEstudios.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rgCargaPorEstudios.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.rgCargaPorEstudios.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Si"), New DevExpress.XtraEditors.Controls.RadioGroupItem("N", "No")})
        Me.rgCargaPorEstudios.Size = New System.Drawing.Size(79, 25)
        Me.rgCargaPorEstudios.TabIndex = 19
        '
        'lblCargaPorEstudio
        '
        Me.lblCargaPorEstudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargaPorEstudio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCargaPorEstudio.Location = New System.Drawing.Point(688, 8)
        Me.lblCargaPorEstudio.Name = "lblCargaPorEstudio"
        Me.lblCargaPorEstudio.Size = New System.Drawing.Size(104, 16)
        Me.lblCargaPorEstudio.TabIndex = 22
        Me.lblCargaPorEstudio.Text = "Carga por Estudios"
        Me.lblCargaPorEstudio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GCDetalle
        '
        Me.GCDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GCDetalle.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GCDetalle.AppearanceCaption.Options.UseFont = True
        Me.GCDetalle.Controls.Add(Me.dgcCargasFamiliares)
        Me.GCDetalle.Location = New System.Drawing.Point(8, 328)
        Me.GCDetalle.Name = "GCDetalle"
        Me.GCDetalle.Size = New System.Drawing.Size(824, 184)
        Me.GCDetalle.TabIndex = 91
        Me.GCDetalle.Text = "Detalle Cargas Familiares"
        '
        'dgcCargasFamiliares
        '
        Me.dgcCargasFamiliares.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgcCargasFamiliares.EmbeddedNavigator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgcCargasFamiliares.Location = New System.Drawing.Point(8, 24)
        Me.dgcCargasFamiliares.MainView = Me.gvCargasFamiliares
        Me.dgcCargasFamiliares.Name = "dgcCargasFamiliares"
        Me.dgcCargasFamiliares.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtRutCarga})
        Me.dgcCargasFamiliares.Size = New System.Drawing.Size(808, 152)
        Me.dgcCargasFamiliares.TabIndex = 33
        Me.dgcCargasFamiliares.Tag = "74"
        Me.dgcCargasFamiliares.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCargasFamiliares, Me.GridView8})
        '
        'gvCargasFamiliares
        '
        Me.gvCargasFamiliares.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NOMBRE_CARGA_FAM, Me.APELLIDO_PAT_CARGA, Me.APELLIDO_MAT_CARGA, Me.DESCRIPCION_PARENTESCO, Me.DESCRIPCION_TIPO_CARGA, Me.DESCRIPCION_GRUPO_FAM, Me.NOMBRES_CARGA, Me.ID_Carga, Me.TIPO_CARGA_FAM_ID, Me.GRUPO_FAMILIAR_ID, Me.ESTADO_CARGA_ID, Me.PARENTESCO_ID, Me.NIVEL_ESTUDIO_ID, Me.CAUSA_TERMINO_ASIG_FAM_ID, Me.FECHA_VIGENCIA, Me.FECHA_VENCIMIENTO, Me.FECHA_NACIMIENTO, Me.EDAD, Me.RUT_CARGA, Me.DIGITO_VER_CARGA, Me.SEXO_CARGA, Me.CARGA_POR_ESTUDIO, Me.RETENSION_JUDICIAL, Me.GRUPO_FAM, Me.CARGA_FAM, Me.TIPO_BENEFICIO_ID, Me.TIPO_CAUSANTE_ID, Me.colREGIMEN_ESTUDIO, Me.colFECHA_INICIO_RECONOCIMIENTO, Me.colFECHA_FIN_RECONOCIMIENTO, Me.colNUMERO_RESOLUCION})
        Me.gvCargasFamiliares.GridControl = Me.dgcCargasFamiliares
        Me.gvCargasFamiliares.GroupPanelText = "Historia y Detalle Previsional"
        Me.gvCargasFamiliares.Name = "gvCargasFamiliares"
        Me.gvCargasFamiliares.OptionsBehavior.Editable = False
        Me.gvCargasFamiliares.OptionsFilter.AllowColumnMRUFilterList = False
        Me.gvCargasFamiliares.OptionsFilter.AllowFilterEditor = False
        Me.gvCargasFamiliares.OptionsFilter.AllowMRUFilterList = False
        Me.gvCargasFamiliares.OptionsView.ColumnAutoWidth = False
        Me.gvCargasFamiliares.OptionsView.ShowGroupPanel = False
        '
        'NOMBRE_CARGA_FAM
        '
        Me.NOMBRE_CARGA_FAM.Caption = "Nombre Carga"
        Me.NOMBRE_CARGA_FAM.FieldName = "NOMBRE_CARGA_FAM"
        Me.NOMBRE_CARGA_FAM.Name = "NOMBRE_CARGA_FAM"
        Me.NOMBRE_CARGA_FAM.OptionsColumn.AllowFocus = False
        Me.NOMBRE_CARGA_FAM.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.NOMBRE_CARGA_FAM.OptionsColumn.ReadOnly = True
        Me.NOMBRE_CARGA_FAM.Visible = True
        Me.NOMBRE_CARGA_FAM.VisibleIndex = 0
        Me.NOMBRE_CARGA_FAM.Width = 228
        '
        'APELLIDO_PAT_CARGA
        '
        Me.APELLIDO_PAT_CARGA.Caption = "Apellido Paterno"
        Me.APELLIDO_PAT_CARGA.FieldName = "APELLIDO_PAT_CARGA"
        Me.APELLIDO_PAT_CARGA.Name = "APELLIDO_PAT_CARGA"
        Me.APELLIDO_PAT_CARGA.OptionsColumn.AllowEdit = False
        Me.APELLIDO_PAT_CARGA.OptionsColumn.AllowFocus = False
        Me.APELLIDO_PAT_CARGA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.APELLIDO_PAT_CARGA.OptionsColumn.ReadOnly = True
        Me.APELLIDO_PAT_CARGA.Width = 104
        '
        'APELLIDO_MAT_CARGA
        '
        Me.APELLIDO_MAT_CARGA.Caption = "Apellido Materno"
        Me.APELLIDO_MAT_CARGA.FieldName = "APELLIDO_MAT_CARGA"
        Me.APELLIDO_MAT_CARGA.Name = "APELLIDO_MAT_CARGA"
        Me.APELLIDO_MAT_CARGA.OptionsColumn.AllowFocus = False
        Me.APELLIDO_MAT_CARGA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.APELLIDO_MAT_CARGA.OptionsColumn.ReadOnly = True
        Me.APELLIDO_MAT_CARGA.Width = 108
        '
        'DESCRIPCION_PARENTESCO
        '
        Me.DESCRIPCION_PARENTESCO.Caption = "Parentesco"
        Me.DESCRIPCION_PARENTESCO.FieldName = "DESCRIPCION_PARENTESCO"
        Me.DESCRIPCION_PARENTESCO.Name = "DESCRIPCION_PARENTESCO"
        Me.DESCRIPCION_PARENTESCO.OptionsColumn.AllowFocus = False
        Me.DESCRIPCION_PARENTESCO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.DESCRIPCION_PARENTESCO.OptionsColumn.ReadOnly = True
        Me.DESCRIPCION_PARENTESCO.Visible = True
        Me.DESCRIPCION_PARENTESCO.VisibleIndex = 1
        Me.DESCRIPCION_PARENTESCO.Width = 89
        '
        'DESCRIPCION_TIPO_CARGA
        '
        Me.DESCRIPCION_TIPO_CARGA.Caption = "Tipo Carga"
        Me.DESCRIPCION_TIPO_CARGA.FieldName = "DESCRIPCION_TIPO_CARGA"
        Me.DESCRIPCION_TIPO_CARGA.Name = "DESCRIPCION_TIPO_CARGA"
        Me.DESCRIPCION_TIPO_CARGA.OptionsColumn.AllowFocus = False
        Me.DESCRIPCION_TIPO_CARGA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.DESCRIPCION_TIPO_CARGA.OptionsColumn.ReadOnly = True
        Me.DESCRIPCION_TIPO_CARGA.Visible = True
        Me.DESCRIPCION_TIPO_CARGA.VisibleIndex = 2
        Me.DESCRIPCION_TIPO_CARGA.Width = 107
        '
        'DESCRIPCION_GRUPO_FAM
        '
        Me.DESCRIPCION_GRUPO_FAM.Caption = "Definición Grupo Familiar"
        Me.DESCRIPCION_GRUPO_FAM.FieldName = "DESCRIPCION_GRUPO_FAM"
        Me.DESCRIPCION_GRUPO_FAM.Name = "DESCRIPCION_GRUPO_FAM"
        Me.DESCRIPCION_GRUPO_FAM.OptionsColumn.AllowFocus = False
        Me.DESCRIPCION_GRUPO_FAM.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.DESCRIPCION_GRUPO_FAM.OptionsColumn.ReadOnly = True
        Me.DESCRIPCION_GRUPO_FAM.Visible = True
        Me.DESCRIPCION_GRUPO_FAM.VisibleIndex = 3
        Me.DESCRIPCION_GRUPO_FAM.Width = 144
        '
        'NOMBRES_CARGA
        '
        Me.NOMBRES_CARGA.Caption = "Nombres"
        Me.NOMBRES_CARGA.FieldName = "NOMBRES_CARGA"
        Me.NOMBRES_CARGA.Name = "NOMBRES_CARGA"
        Me.NOMBRES_CARGA.OptionsColumn.AllowFocus = False
        Me.NOMBRES_CARGA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.NOMBRES_CARGA.OptionsColumn.ReadOnly = True
        Me.NOMBRES_CARGA.Width = 122
        '
        'ID_Carga
        '
        Me.ID_Carga.Caption = "ID"
        Me.ID_Carga.FieldName = "CARGA_FAMILIAR_ID"
        Me.ID_Carga.Name = "ID_Carga"
        Me.ID_Carga.OptionsColumn.AllowFocus = False
        Me.ID_Carga.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.ID_Carga.OptionsColumn.ReadOnly = True
        Me.ID_Carga.Width = 56
        '
        'TIPO_CARGA_FAM_ID
        '
        Me.TIPO_CARGA_FAM_ID.Caption = "ID Tipo Carga Fam."
        Me.TIPO_CARGA_FAM_ID.FieldName = "TIPO_CARGA_FAM_ID"
        Me.TIPO_CARGA_FAM_ID.Name = "TIPO_CARGA_FAM_ID"
        Me.TIPO_CARGA_FAM_ID.OptionsColumn.AllowFocus = False
        Me.TIPO_CARGA_FAM_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.TIPO_CARGA_FAM_ID.OptionsColumn.ReadOnly = True
        Me.TIPO_CARGA_FAM_ID.Width = 56
        '
        'GRUPO_FAMILIAR_ID
        '
        Me.GRUPO_FAMILIAR_ID.Caption = "ID Grupo Fam."
        Me.GRUPO_FAMILIAR_ID.FieldName = "GRUPO_FAMILIAR_ID"
        Me.GRUPO_FAMILIAR_ID.Name = "GRUPO_FAMILIAR_ID"
        Me.GRUPO_FAMILIAR_ID.OptionsColumn.AllowFocus = False
        Me.GRUPO_FAMILIAR_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GRUPO_FAMILIAR_ID.OptionsColumn.ReadOnly = True
        Me.GRUPO_FAMILIAR_ID.Width = 56
        '
        'ESTADO_CARGA_ID
        '
        Me.ESTADO_CARGA_ID.Caption = "ID Estado Carga"
        Me.ESTADO_CARGA_ID.FieldName = "ESTADO_CARGA_ID"
        Me.ESTADO_CARGA_ID.Name = "ESTADO_CARGA_ID"
        Me.ESTADO_CARGA_ID.OptionsColumn.AllowFocus = False
        Me.ESTADO_CARGA_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.ESTADO_CARGA_ID.OptionsColumn.ReadOnly = True
        Me.ESTADO_CARGA_ID.Width = 65
        '
        'PARENTESCO_ID
        '
        Me.PARENTESCO_ID.Caption = "ID Parentesco"
        Me.PARENTESCO_ID.FieldName = "PARENTESCO_ID"
        Me.PARENTESCO_ID.Name = "PARENTESCO_ID"
        Me.PARENTESCO_ID.OptionsColumn.AllowFocus = False
        Me.PARENTESCO_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PARENTESCO_ID.OptionsColumn.ReadOnly = True
        Me.PARENTESCO_ID.Width = 54
        '
        'NIVEL_ESTUDIO_ID
        '
        Me.NIVEL_ESTUDIO_ID.Caption = "ID Nivel Estudio"
        Me.NIVEL_ESTUDIO_ID.FieldName = "NIVEL_ESTUDIO_ID"
        Me.NIVEL_ESTUDIO_ID.Name = "NIVEL_ESTUDIO_ID"
        Me.NIVEL_ESTUDIO_ID.OptionsColumn.AllowFocus = False
        Me.NIVEL_ESTUDIO_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.NIVEL_ESTUDIO_ID.OptionsColumn.ReadOnly = True
        Me.NIVEL_ESTUDIO_ID.Width = 54
        '
        'CAUSA_TERMINO_ASIG_FAM_ID
        '
        Me.CAUSA_TERMINO_ASIG_FAM_ID.Caption = "ID Causa Término Asig.Fam."
        Me.CAUSA_TERMINO_ASIG_FAM_ID.FieldName = "CAUSA_TERMINO_ASIG_FAM_ID"
        Me.CAUSA_TERMINO_ASIG_FAM_ID.Name = "CAUSA_TERMINO_ASIG_FAM_ID"
        Me.CAUSA_TERMINO_ASIG_FAM_ID.OptionsColumn.AllowFocus = False
        Me.CAUSA_TERMINO_ASIG_FAM_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.CAUSA_TERMINO_ASIG_FAM_ID.OptionsColumn.ReadOnly = True
        Me.CAUSA_TERMINO_ASIG_FAM_ID.Width = 54
        '
        'FECHA_VIGENCIA
        '
        Me.FECHA_VIGENCIA.Caption = "Fecha Vigencia"
        Me.FECHA_VIGENCIA.FieldName = "FECHA_VIGENCIA"
        Me.FECHA_VIGENCIA.Name = "FECHA_VIGENCIA"
        Me.FECHA_VIGENCIA.OptionsColumn.AllowFocus = False
        Me.FECHA_VIGENCIA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.FECHA_VIGENCIA.OptionsColumn.ReadOnly = True
        Me.FECHA_VIGENCIA.Visible = True
        Me.FECHA_VIGENCIA.VisibleIndex = 4
        Me.FECHA_VIGENCIA.Width = 83
        '
        'FECHA_VENCIMIENTO
        '
        Me.FECHA_VENCIMIENTO.Caption = "Fecha Vecto."
        Me.FECHA_VENCIMIENTO.FieldName = "FECHA_VENCIMIENTO"
        Me.FECHA_VENCIMIENTO.Name = "FECHA_VENCIMIENTO"
        Me.FECHA_VENCIMIENTO.OptionsColumn.AllowFocus = False
        Me.FECHA_VENCIMIENTO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.FECHA_VENCIMIENTO.OptionsColumn.ReadOnly = True
        Me.FECHA_VENCIMIENTO.Visible = True
        Me.FECHA_VENCIMIENTO.VisibleIndex = 5
        '
        'FECHA_NACIMIENTO
        '
        Me.FECHA_NACIMIENTO.Caption = "Fecha Nacimiento"
        Me.FECHA_NACIMIENTO.FieldName = "FECHA_NACIMIENTO"
        Me.FECHA_NACIMIENTO.Name = "FECHA_NACIMIENTO"
        Me.FECHA_NACIMIENTO.OptionsColumn.AllowFocus = False
        Me.FECHA_NACIMIENTO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.FECHA_NACIMIENTO.OptionsColumn.ReadOnly = True
        Me.FECHA_NACIMIENTO.Visible = True
        Me.FECHA_NACIMIENTO.VisibleIndex = 6
        Me.FECHA_NACIMIENTO.Width = 96
        '
        'EDAD
        '
        Me.EDAD.Caption = "Edad"
        Me.EDAD.FieldName = "EDAD"
        Me.EDAD.Name = "EDAD"
        Me.EDAD.OptionsColumn.AllowFocus = False
        Me.EDAD.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.EDAD.OptionsColumn.ReadOnly = True
        Me.EDAD.Visible = True
        Me.EDAD.VisibleIndex = 7
        Me.EDAD.Width = 49
        '
        'RUT_CARGA
        '
        Me.RUT_CARGA.Caption = "Rut"
        Me.RUT_CARGA.ColumnEdit = Me.txtRutCarga
        Me.RUT_CARGA.FieldName = "RUT_CARGA"
        Me.RUT_CARGA.Name = "RUT_CARGA"
        Me.RUT_CARGA.OptionsColumn.AllowFocus = False
        Me.RUT_CARGA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.RUT_CARGA.OptionsColumn.ReadOnly = True
        Me.RUT_CARGA.Visible = True
        Me.RUT_CARGA.VisibleIndex = 8
        Me.RUT_CARGA.Width = 71
        '
        'txtRutCarga
        '
        Me.txtRutCarga.AutoHeight = False
        Me.txtRutCarga.DisplayFormat.FormatString = "n0"
        Me.txtRutCarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRutCarga.EditFormat.FormatString = "n0"
        Me.txtRutCarga.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRutCarga.Mask.EditMask = "n0"
        Me.txtRutCarga.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRutCarga.Mask.UseMaskAsDisplayFormat = True
        Me.txtRutCarga.Name = "txtRutCarga"
        '
        'DIGITO_VER_CARGA
        '
        Me.DIGITO_VER_CARGA.Caption = "Dv"
        Me.DIGITO_VER_CARGA.FieldName = "DIGITO_VER_CARGA"
        Me.DIGITO_VER_CARGA.Name = "DIGITO_VER_CARGA"
        Me.DIGITO_VER_CARGA.OptionsColumn.AllowFocus = False
        Me.DIGITO_VER_CARGA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.DIGITO_VER_CARGA.OptionsColumn.ReadOnly = True
        Me.DIGITO_VER_CARGA.Visible = True
        Me.DIGITO_VER_CARGA.VisibleIndex = 9
        Me.DIGITO_VER_CARGA.Width = 33
        '
        'SEXO_CARGA
        '
        Me.SEXO_CARGA.Caption = "Sexo"
        Me.SEXO_CARGA.FieldName = "SEXO_CARGA"
        Me.SEXO_CARGA.Name = "SEXO_CARGA"
        Me.SEXO_CARGA.OptionsColumn.AllowFocus = False
        Me.SEXO_CARGA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.SEXO_CARGA.OptionsColumn.ReadOnly = True
        '
        'CARGA_POR_ESTUDIO
        '
        Me.CARGA_POR_ESTUDIO.Caption = "Carga por Estudio"
        Me.CARGA_POR_ESTUDIO.FieldName = "CARGA_POR_ESTUDIO"
        Me.CARGA_POR_ESTUDIO.Name = "CARGA_POR_ESTUDIO"
        Me.CARGA_POR_ESTUDIO.OptionsColumn.AllowFocus = False
        Me.CARGA_POR_ESTUDIO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.CARGA_POR_ESTUDIO.OptionsColumn.ReadOnly = True
        Me.CARGA_POR_ESTUDIO.Width = 105
        '
        'RETENSION_JUDICIAL
        '
        Me.RETENSION_JUDICIAL.Caption = "Retención Judicial"
        Me.RETENSION_JUDICIAL.FieldName = "RETENSION_JUDICIAL"
        Me.RETENSION_JUDICIAL.Name = "RETENSION_JUDICIAL"
        Me.RETENSION_JUDICIAL.OptionsColumn.AllowFocus = False
        Me.RETENSION_JUDICIAL.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.RETENSION_JUDICIAL.OptionsColumn.ReadOnly = True
        '
        'GRUPO_FAM
        '
        Me.GRUPO_FAM.Caption = "Es Grupo Fam"
        Me.GRUPO_FAM.FieldName = "GRUPO_FAM"
        Me.GRUPO_FAM.Name = "GRUPO_FAM"
        Me.GRUPO_FAM.OptionsColumn.AllowFocus = False
        Me.GRUPO_FAM.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GRUPO_FAM.OptionsColumn.ReadOnly = True
        '
        'CARGA_FAM
        '
        Me.CARGA_FAM.Caption = "Es Carga Fam"
        Me.CARGA_FAM.FieldName = "CARGA_FAM"
        Me.CARGA_FAM.Name = "CARGA_FAM"
        Me.CARGA_FAM.OptionsColumn.AllowFocus = False
        Me.CARGA_FAM.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.CARGA_FAM.OptionsColumn.ReadOnly = True
        '
        'TIPO_BENEFICIO_ID
        '
        Me.TIPO_BENEFICIO_ID.Caption = "ID Tipo Beneficio"
        Me.TIPO_BENEFICIO_ID.FieldName = "TIPO_BENEFICIO_ID"
        Me.TIPO_BENEFICIO_ID.Name = "TIPO_BENEFICIO_ID"
        Me.TIPO_BENEFICIO_ID.OptionsColumn.AllowFocus = False
        Me.TIPO_BENEFICIO_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.TIPO_BENEFICIO_ID.OptionsColumn.ReadOnly = True
        '
        'TIPO_CAUSANTE_ID
        '
        Me.TIPO_CAUSANTE_ID.Caption = "ID Tipo Causante"
        Me.TIPO_CAUSANTE_ID.FieldName = "TIPO_CAUSANTE_ID"
        Me.TIPO_CAUSANTE_ID.Name = "TIPO_CAUSANTE_ID"
        Me.TIPO_CAUSANTE_ID.OptionsColumn.AllowFocus = False
        Me.TIPO_CAUSANTE_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.TIPO_CAUSANTE_ID.OptionsColumn.ReadOnly = True
        '
        'colREGIMEN_ESTUDIO
        '
        Me.colREGIMEN_ESTUDIO.Caption = "Regimen Estudio"
        Me.colREGIMEN_ESTUDIO.FieldName = "REGIMEN_ESTUDIO"
        Me.colREGIMEN_ESTUDIO.Name = "colREGIMEN_ESTUDIO"
        '
        'colFECHA_INICIO_RECONOCIMIENTO
        '
        Me.colFECHA_INICIO_RECONOCIMIENTO.Caption = "Fecha Ini.Reconocim."
        Me.colFECHA_INICIO_RECONOCIMIENTO.FieldName = "FECHA_INICIO_RECONOCIMIENTO"
        Me.colFECHA_INICIO_RECONOCIMIENTO.Name = "colFECHA_INICIO_RECONOCIMIENTO"
        '
        'colFECHA_FIN_RECONOCIMIENTO
        '
        Me.colFECHA_FIN_RECONOCIMIENTO.Caption = "Fecha Fin Reconocim."
        Me.colFECHA_FIN_RECONOCIMIENTO.FieldName = "FECHA_FIN_RECONOCIMIENTO"
        Me.colFECHA_FIN_RECONOCIMIENTO.Name = "colFECHA_FIN_RECONOCIMIENTO"
        '
        'colNUMERO_RESOLUCION
        '
        Me.colNUMERO_RESOLUCION.Caption = "Numero Resolucion"
        Me.colNUMERO_RESOLUCION.FieldName = "NUMERO_RESOLUCION"
        Me.colNUMERO_RESOLUCION.Name = "colNUMERO_RESOLUCION"
        '
        'GridView8
        '
        Me.GridView8.GridControl = Me.dgcCargasFamiliares
        Me.GridView8.Name = "GridView8"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmCargaFamiliar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(864, 622)
        Me.Controls.Add(Me.GCEditorDatos)
        Me.Controls.Add(Me.gpcEmpleado)
        Me.Name = "frmCargaFamiliar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga Familiar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcEmpleado.ResumeLayout(False)
        CType(Me.lueTipoBeneficiario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leRut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCEditorDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCEditorDatos.ResumeLayout(False)
        Me.pnlDatosPersonalesCargaFAM.ResumeLayout(False)
        CType(Me.txtApellidoPaterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreCarga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoMaterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueGrupoFamiliar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueParentesco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgSexo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueNivelEstudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaNacimiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaNacimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTipoBeneficio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDV_CargaFAM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAcciones.ResumeLayout(False)
        Me.pnlDatosCargaFAM.ResumeLayout(False)
        CType(Me.dedFechaFinReconocimiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaFinReconocimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaInicioReconocimiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaInicioReconocimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroResolucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueRegimenEstudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTipoCausante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaInicioVigencia.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaInicioVigencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaTerminoVigencia.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaTerminoVigencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueEstadoCargaFamiliar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTipoCargaFamiliar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCausaTerminoAsig.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgRetensionJudicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgCargaPorEstudios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCDetalle.ResumeLayout(False)
        CType(Me.dgcCargasFamiliares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCargasFamiliares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRutCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCargaFamiliar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LLamado a dataview comunes ubicados en el repositorio central del sistema
        btnNuevo.Enabled = False
        HabilitarControles(False)
        repositorio.Show()
        InitDataEmpleado()
        initCampoRut()

        'Carga combobox tipos de carga familiar.
        Comun.Utiles.fillLookUpEdit(lueTipoCargaFamiliar, _
                            (Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_TIPO_CARGA_FAM, _
                            Comun.Tablas.RH_PER_TIPO_CARGA_FAM, "DESCRIPCION", "TIPO_CARGA_FAM_ID", _
                            connectionString)), "DESCRIPCION", "TIPO_CARGA_FAM_ID")

        'Carga combobox estado carga familiar.
        Comun.Utiles.fillLookUpEdit(lueEstadoCargaFamiliar, _
                            (Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_ESTADO_CARGA_FAM, _
                            Comun.Tablas.RH_PER_ESTADO_CARGA_FAM, "DESCRIPCION", "ESTADO_CARGA_ID", _
                            connectionString)), "DESCRIPCION", "ESTADO_CARGA_ID")

        'Carga combobox grupo familiar.
        If tipoEdicion = Comun.TiposDeDatos.TipoEdicionCargaFAM.EDICION_COMO_CARGA_FAMILIAR Then
            Comun.Utiles.fillLookUpEdit(lueGrupoFamiliar, _
                                (Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_GRUPO_FAMILIAR(1), _
                                Comun.Tablas.RH_PER_GRUPO_FAMILIAR, "DESCRIPCION", "GRUPO_FAMILIAR_ID", _
                                connectionString)), "DESCRIPCION", "GRUPO_FAMILIAR_ID")

            'Carga combobox con tipo beneficio.
            Comun.Utiles.fillLookUpEdit(lueTipoBeneficio, _
                                (Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_TIPO_BENEFICIO, _
                                Comun.Tablas.RH_PER_TIPO_BENEFICIO, "DESCRIPCION", "TIPO_BENEFICIO_ID", _
                                connectionString)), "DESCRIPCION", "TIPO_BENEFICIO_ID")

            'Carga combobox con tipo causante.
            Comun.Utiles.fillLookUpEdit(lueTipoCausante, _
                                (Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_TIPO_CAUSANTE, _
                                Comun.Tablas.RH_PER_TIPO_CAUSANTE, "DESCRIPCION", "TIPO_CAUSANTE_ID", _
                                connectionString)), "DESCRIPCION", "TIPO_CAUSANTE_ID")

            'Carga combobox con tipo beneficiario.
            Comun.Utiles.fillLookUpEdit(lueTipoBeneficiario, _
                                (Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_TIPO_BENEFICIARIO, _
                                Comun.Tablas.RH_PER_TIPO_BENEFICIARIO, "DESCRIPCION", "TIPO_BENEFICIARIO_ID", _
                                connectionString)), "DESCRIPCION", "TIPO_BENEFICIARIO_ID")

        Else
            Comun.Utiles.fillLookUpEdit(lueGrupoFamiliar, _
                    (Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_GRUPO_FAMILIAR(2), _
                    Comun.Tablas.RH_PER_GRUPO_FAMILIAR, "DESCRIPCION", "GRUPO_FAMILIAR_ID", _
                    connectionString)), "DESCRIPCION", "GRUPO_FAMILIAR_ID")
        End If

        'Carga combobox parentesco.
        Comun.Utiles.fillLookUpEdit(lueParentesco, _
                            (Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_PARENTESCO_CARGA_FAM, _
                            Comun.Tablas.RH_PER_PARENTESCO, "DESCRIPCION", "PARENTESCO_ID", _
                            connectionString)), "DESCRIPCION", "PARENTESCO_ID")

        'Carga Asignación Familiar
        Comun.Utiles.fillLookUpEdit(lueCausaTerminoAsig, _
                            (Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_CAUSA_TERMINO_ASIG_CARGA_FAM, _
                            Comun.Tablas.RH_PER_CAUSA_TERMINO_ASIG_FAM, "DESCRIPCION", "CAUSA_TERMINO_ASIG_FAM_ID", _
                            connectionString)), "DESCRIPCION", "CAUSA_TERMINO_ASIG_FAM_ID")

        'Carga combobox con los niveles de estudio.
        Comun.Utiles.fillLookUpEdit(lueNivelEstudio, _
                            (Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_NIVEL_ESTUDIO, _
                            Comun.Tablas.RH_PER_NIVEL_ESTUDIO, "DESCRIPCION", "NIVEL_ESTUDIO_ID", _
                            connectionString)), "DESCRIPCION", "NIVEL_ESTUDIO_ID")

        'Carga combobox regimen estudio.
        Comun.Utiles.fillLookUpEdit(lueRegimenEstudio, _
                            (Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_REGIMEN_ESTUDIO, _
                            Comun.Tablas.RH_PER_REGIMEN_ESTUDIO, "DESCRIPCION", "REGIMEN_ESTUDIO_ID", _
                            connectionString)), "DESCRIPCION", "REGIMEN_ESTUDIO_ID")
    End Sub

    Private Sub HabilitarControles(ByVal Estado As Boolean)
        txtApellidoPaterno.Enabled = Estado
        lblApellidoPaterno.Enabled = Estado
        lblNombres.Enabled = Estado
        txtNombreCarga.Enabled = Estado
        lblApellidoMaterno.Enabled = Estado
        txtApellidoMaterno.Enabled = Estado
        lblRutCarga.Enabled = Estado
        txtRut.Enabled = Estado
        txtDV_CargaFAM.Enabled = Estado
        lblGrupoFamiliar.Enabled = Estado
        lueGrupoFamiliar.Enabled = Estado
        lblParentesco.Enabled = Estado
        lueParentesco.Enabled = Estado
        lblFechaNacimiento.Enabled = Estado
        dedFechaNacimiento.Enabled = Estado
        lblSexo.Enabled = Estado
        rdgSexo.Enabled = Estado
        lblNivelEstudios.Enabled = Estado
        lueNivelEstudio.Enabled = Estado
        lblFechaInicioVigencia.Enabled = Estado
        dedFechaInicioVigencia.Enabled = Estado
        lblEstadoCargaFamiliar.Enabled = Estado
        lueEstadoCargaFamiliar.Enabled = Estado
        lblCausaTerminoAsignacion.Enabled = Estado
        lueCausaTerminoAsig.Enabled = Estado
        lblRetension.Enabled = Estado
        rgRetensionJudicial.Enabled = Estado
        lblCargaPorEstudio.Enabled = Estado
        rgCargaPorEstudios.Enabled = Estado
        lblFechaTerminoVigencia.Enabled = Estado
        dedFechaTerminoVigencia.Enabled = Estado
        lblTipoCargaFamiliar.Enabled = Estado
        lueTipoCargaFamiliar.Enabled = Estado
        btnAgregar.Enabled = Estado
        lueTipoCausante.Enabled = Estado
        lueTipoBeneficio.Enabled = Estado
        lueRegimenEstudio.Enabled = Estado
        txtNumeroResolucion.Enabled = Estado
        dedFechaInicioReconocimiento.Enabled = Estado
        dedFechaFinReconocimiento.Enabled = Estado
    End Sub
    Private Sub eliminarRegistro(ByVal IDCARGA As Integer)

        If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then

            Try
                If IDCARGA > 0 Then
                    Dim cargaFamiliar As New CargaFamiliar(0, IDCARGA)
                    If cargaFamiliar.EliminarCargaFamiliar = True Then
                        dgcCargasFamiliares.Show()
                        MsgBox("El registro ha sido eliminado", MsgBoxStyle.OkOnly, "Módulo de Cargas Familiares")
                    Else
                        dgcCargasFamiliares.DataSource = empleado.dvCargasFamiliares()
                        dgcCargasFamiliares.Show()
                    End If
                End If
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al intentar eliminar el registro " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
            dgcCargasFamiliares.DataSource = empleado.dvCargasFamiliares()
            dgcCargasFamiliares.Show()
            inicializarControles()
        End If
    End Sub
    Private Sub InitDataEmpleado()
        Dim ds As New DataAccess.Empleados
        repositorio.dvEmpleados = repositorio.dvEmpleados
    End Sub

    Private Sub initCampoRut()
        leRut.Properties.EditValueChangedFiringDelay = 1200
        leRut.Properties.EditValueChangedFiringMode = EditValueChangedFiringMode.Buffered
        'Dos segundos se espera antes de gatillar la búsqueda (EditValueChanged)

        leRut.Properties.ViewType = Repository.GridLookUpViewType.GridView
        leRut.Properties.View.OptionsBehavior.AutoPopulateColumns = False
        leRut.Properties.DataSource = repositorio.dvEmpleadoVista
        leRut.Properties.DisplayMember = "RUT"
        'leRut.Properties.DisplayMember = "NOMBRE_COMPLETO"

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
    Private Sub leRut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles leRut.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Cursor.Current = Cursors.WaitCursor
                empleado = New empleado(CType(leRut.EditValue, Long))
                Me.HabilitarControles(False)
                If Not empleado Is Nothing Then
                    btnNuevo.Enabled = True
                    refrescarControles()
                Else
                    btnNuevo.Enabled = False
                End If
                Cursor.Current = Cursors.Default
            Catch exp As Exception
                MessageBox.Show("Atención: " & exp.Message, "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub
    Private Sub refrescarControles()
        leRut.EditValue = empleado.ID
        txtDV.Text = empleado.rut.dv
        txtNombreEmpleado.Text = empleado.nombreCompleto
        lueTipoBeneficiario.EditValue = empleado.datosLaborales.tipoBeneficiarioID

        'Obtengo las cargas familiares asociadas al empleado.
        If tipoEdicion = Comun.TiposDeDatos.TipoEdicionCargaFAM.EDICION_COMO_CARGA_FAMILIAR Then
            dgcCargasFamiliares.DataSource = empleado.dvCargasFamiliares()
        Else
            dgcCargasFamiliares.DataSource = empleado.dvCargasFamiliaresSoloGrupoFamiliar()
        End If

        dgcCargasFamiliares.Show()
        ' Cursor.Current = Cursors.Default
    End Sub
    Private Sub inicializarControles()
        With Me
            .lueCausaTerminoAsig.EditValue = 0
            .btnAgregar.Text = "Agregar"
            .dedFechaInicioVigencia.EditValue = Now.Date
            .dedFechaNacimiento.EditValue = Now.Date
            .dedFechaTerminoVigencia.EditValue = Now.Date

            .IDCARGA = 0
            .lueCausaTerminoAsig.EditValue = 2
            .lueEstadoCargaFamiliar.EditValue = 2
            .lueGrupoFamiliar.EditValue = 2
            .lueNivelEstudio.EditValue = 1
            .lueParentesco.EditValue = 2
            .lueTipoCargaFamiliar.EditValue = 5
            .rdgSexo.SelectedIndex = -1
            .rgCargaPorEstudios.SelectedIndex = 1
            .rgRetensionJudicial.SelectedIndex = 1
            .txtApellidoMaterno.Text = ""
            .txtApellidoPaterno.Text = ""
            .txtDV_CargaFAM.Text = ""
            .txtNombreCarga.Text = ""
            .txtRut.Text = ""
            .lueTipoBeneficio.EditValue = 0
            .lueTipoCausante.EditValue = 0
            .lueRegimenEstudio.EditValue = 0
            .txtNumeroResolucion.Text = ""
            .dedFechaInicioReconocimiento.EditValue = Nothing
            .dedFechaFinReconocimiento.EditValue = Nothing
            If tipoEdicion = Comun.TiposDeDatos.TipoEdicionCargaFAM.EDICION_COMO_CARGA_FAMILIAR Then
                dgcCargasFamiliares.DataSource = empleado.dvCargasFamiliares()
            Else
                dgcCargasFamiliares.DataSource = empleado.dvCargasFamiliaresSoloGrupoFamiliar()
            End If
            dgcCargasFamiliares.Show()

        End With

    End Sub
    Private Sub Guardar(ByVal accion As String)
        Dim FechaInicioVigencia, FechaTerminoVigencia As Date
        Dim Hora As String = (CType(Now.Hour(), String) & ":" _
                              & CType(Now.Minute(), String) & ":" _
                              & CType(Now.Second(), String))

        If accion = Comun.TiposDeDatos.TipoActualizacion.GUARDAR_REGISTRO_ACTUAL_O_NUEVO Then
            Try
                If dedFechaInicioVigencia.Text = "" Then FechaInicioVigencia = Nothing Else FechaInicioVigencia = dedFechaInicioVigencia.Text
                If dedFechaTerminoVigencia.Text = "" Then FechaTerminoVigencia = Nothing Else FechaTerminoVigencia = dedFechaTerminoVigencia.Text
                With Me
                    Dim objCargaFamiliar As New CargaFamiliar(empleado.ID, _
                        .dedFechaNacimiento.Text, _
                        FechaInicioVigencia, _
                        FechaTerminoVigencia, _
                        Now.Date, _
                        Hora, _
                        CType(.rdgSexo.EditValue, Char), _
                        txtNombreCarga.Text, _
                        txtApellidoPaterno.Text, _
                        txtApellidoMaterno.Text, _
                        CType(txtRut.Text, Integer), _
                        lueTipoBeneficio.EditValue, _
                        lueTipoCausante.EditValue, _
                        IDCARGA, _
                        .lueNivelEstudio.EditValue, _
                        .lueTipoCargaFamiliar.EditValue, _
                        .lueParentesco.EditValue, _
                        .lueGrupoFamiliar.EditValue, _
                        .txtDV_CargaFAM.Text, _
                        .lueEstadoCargaFamiliar.EditValue, _
                        CType(.rgRetensionJudicial.EditValue, Char), _
                        CType(.rgCargaPorEstudios.EditValue, Char), _
                        .lueCausaTerminoAsig.EditValue, _
                        "NoDefinido", _
                        tipoEdicion, _
                        .lueRegimenEstudio.EditValue, _
                        .dedFechaInicioReconocimiento.EditValue, _
                        .dedFechaFinReconocimiento.EditValue, _
                        .txtNumeroResolucion.Text, _
                        .periodo.ID)

                    'El siguiente código obtine el usuario windows
                    '(System.Security.Principal.WindowsIdentity.GetCurrent().Name)

                    objCargaFamiliar = Nothing

                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub


    Private Sub gvCargasFamiliares_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvCargasFamiliares.DoubleClick
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender

        'Traspasa información de la carga a los cuadros de texto.
        'No realizo una nueva consulta a la Base de Datos.
        Cursor.Current = Cursors.WaitCursor
        Dim continua As Boolean = True
        If tipoEdicion = Comun.TiposDeDatos.TipoEdicionCargaFAM.EDICION_COMO_MIEMBRO_GRUPO_FAMILIAR Then
            If view.GetRowCellValue(view.FocusedRowHandle, "CARGA_FAM") = True Then
                MessageBox.Show("El registro seleccionado solo puede ser editado en cargas familiares", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                continua = False
            End If
        End If
        If continua Then
            With Me
                .txtApellidoPaterno.Text = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("APELLIDO_PAT_CARGA"))
                .txtApellidoMaterno.Text = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("APELLIDO_MAT_CARGA"))
                .txtNombreCarga.Text = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("NOMBRES_CARGA"))
                IDCARGA = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("CARGA_FAMILIAR_ID"))
                .lueTipoCargaFamiliar.EditValue = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("TIPO_CARGA_FAM_ID"))
                .lueGrupoFamiliar.EditValue = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("GRUPO_FAMILIAR_ID"))
                .lueEstadoCargaFamiliar.EditValue = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("ESTADO_CARGA_ID"))
                .lueParentesco.EditValue = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("PARENTESCO_ID"))
                .lueNivelEstudio.EditValue = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("NIVEL_ESTUDIO_ID"))
                .lueCausaTerminoAsig.EditValue = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("CAUSA_TERMINO_ASIG_FAM_ID"))
                .dedFechaInicioVigencia.EditValue = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("FECHA_VIGENCIA"))
                .dedFechaTerminoVigencia.EditValue = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("FECHA_VENCIMIENTO"))
                .dedFechaNacimiento.EditValue = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("FECHA_NACIMIENTO"))
                .txtRut.EditValue = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("RUT_CARGA"))
                oldRutCargaFam = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("RUT_CARGA"))
                .txtDV_CargaFAM.Text = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("DIGITO_VER_CARGA"))
                .lueTipoCausante.EditValue = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("TIPO_CAUSANTE_ID"))
                .lueTipoBeneficio.EditValue = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("TIPO_BENEFICIO_ID"))
                .lueRegimenEstudio.EditValue = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("REGIMEN_ESTUDIO"))
                Try
                    .txtNumeroResolucion.Text = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("NUMERO_RESOLUCION"))
                Catch ex As Exception
                    .txtNumeroResolucion.Text = ""
                End Try

                Dim fechaIni As Date = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("FECHA_INICIO_RECONOCIMIENTO"))
                If fechaIni.Year <= 1900 Then
                    .dedFechaInicioReconocimiento.EditValue = Nothing
                Else
                    .dedFechaInicioReconocimiento.EditValue = fechaIni
                End If
                Dim fechaFin As Date = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("FECHA_FIN_RECONOCIMIENTO"))
                If fechaFin.Year <= 1900 Then
                    .dedFechaFinReconocimiento.EditValue = Nothing
                Else
                    .dedFechaFinReconocimiento.EditValue = fechaFin
                End If
                If IDCARGA > 0 Then
                    HabilitarControles(True)
                    .btnAgregar.Text = "Actualizar"
                End If

                If view.GetRowCellValue(view.FocusedRowHandle, view.Columns("SEXO_CARGA")) = CargaFamiliar.ESexo.FEMENINO Then
                    .rdgSexo.SelectedIndex = 1
                Else
                    .rdgSexo.SelectedIndex = 0
                End If
                'Selecciona ticket de carga por estudio. Si o No
                If view.GetRowCellValue(view.FocusedRowHandle, view.Columns("CARGA_POR_ESTUDIO")) = "S" Then
                    .rgCargaPorEstudios.SelectedIndex = 0
                Else
                    .rgCargaPorEstudios.SelectedIndex = 1
                End If
                'Selecciona ticket retensión judicial por estudio. Si o No
                If view.GetRowCellValue(view.FocusedRowHandle, view.Columns("RETENSION_JUDICIAL")) = "S" Then
                    .rgRetensionJudicial.SelectedIndex = 0
                Else
                    .rgRetensionJudicial.SelectedIndex = 1
                End If
            End With

        End If
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub gvCargasFamiliares_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gvCargasFamiliares.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
            Dim continua As Boolean = True
            If tipoEdicion = Comun.TiposDeDatos.TipoEdicionCargaFAM.EDICION_COMO_MIEMBRO_GRUPO_FAMILIAR Then
                If view.GetRowCellValue(view.FocusedRowHandle, "CARGA_FAM") = True Then
                    MessageBox.Show("El registro seleccionado solo puede ser eliminado en cargas familiares", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    continua = False
                End If
            End If
            If continua Then
                eliminarRegistro(view.GetRowCellValue(view.FocusedRowHandle, view.Columns("CARGA_FAMILIAR_ID")))
            End If
        End If
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IDCARGA > 0 Then
            eliminarRegistro(IDCARGA)
        End If
    End Sub
    Private Sub gvCargasFamiliares_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvCargasFamiliares.Click
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        With Me
            If (view.GetRowCellValue(view.FocusedRowHandle, view.Columns("CARGA_FAMILIAR_ID")) > 0) Then
                IDCARGA = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("CARGA_FAMILIAR_ID"))
            End If
        End With

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim ErrorProv As Integer
        ErrorProv = 0
        If txtApellidoPaterno.Text = "" Then
            ErrorProvider1.SetError(txtApellidoPaterno, "Debe ingresar el apellido paterno de la carga.")
            ErrorProv = 1
        Else
            ErrorProvider1.SetError(txtApellidoPaterno, "")
        End If
        If txtNombreCarga.Text = "" Then
            ErrorProvider1.SetError(txtNombreCarga, "Debe ingresar el nombre de la carga.")
            ErrorProv = 1
        Else
            ErrorProvider1.SetError(txtNombreCarga, "")
        End If
        If txtApellidoMaterno.Text = "" Then
            ErrorProvider1.SetError(txtApellidoMaterno, "Debe ingresar el apellido materno de la carga.")
            ErrorProv = 1
        Else
            ErrorProvider1.SetError(txtApellidoMaterno, "")
        End If
        If txtRut.Text = "" Or txtDV_CargaFAM.Text = "" Then
            ErrorProvider1.SetError(txtDV_CargaFAM, "Debe ingresar el rut de la carga.")
            ErrorProv = 1
        Else
            ErrorProvider1.SetError(txtDV_CargaFAM, "")
        End If
        If Not IsNumeric(txtRut.Text) And (txtRut.Text <> "") Then
            ErrorProvider1.SetError(txtRut, "Rut incorrecto.")
            ErrorProv = 1
        Else
            ErrorProvider1.SetError(txtRut, "")
        End If

        If rdgSexo.EditValue = Nothing Or (rdgSexo.EditValue <> "M" And rdgSexo.EditValue <> "F") Then
            ErrorProvider1.SetError(rdgSexo, "Falta definir sexo.")
            ErrorProv = 1
        Else
            ErrorProvider1.SetError(rdgSexo, "")
        End If
        If ErrorProv = 0 Then
            If empleado.ID > 0 Then
                'La función guardar, actualiza o guarda un registro.
                Guardar(Comun.TiposDeDatos.TipoActualizacion.GUARDAR_REGISTRO_ACTUAL_O_NUEVO)
                If tipoEdicion = Comun.TiposDeDatos.TipoEdicionCargaFAM.EDICION_COMO_CARGA_FAMILIAR Then
                    dgcCargasFamiliares.DataSource = empleado.dvCargasFamiliares()
                Else
                    dgcCargasFamiliares.DataSource = empleado.dvCargasFamiliaresSoloGrupoFamiliar()
                End If
                HabilitarControles(False)
                dgcCargasFamiliares.Show()
                inicializarControles()
                oldRutCargaFam = 0
            End If
        End If

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        inicializarControles()
        Me.HabilitarControles(True)
        nuevoRegistro = True
    End Sub

    Private Sub btnImprimirInforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptInfCargasFamiliaresVenc
        reporte.RecordSelectionFormula = ""
        reporte.SummaryInfo.ReportTitle = "NÓMINA DE CARGAS FAMILIARES POR VENCER"
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.Show()
    End Sub

    Private Sub dedFechaNacimiento_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dedFechaNacimiento.EditValueChanged
        If dedFechaNacimiento.EditValue <> Nothing Then
            If tipoEdicion = Comun.TiposDeDatos.TipoEdicionCargaFAM.EDICION_COMO_CARGA_FAMILIAR And nuevoRegistro Then
                'Suma 18 años al año de nacimiento para determinar fecha termino vigencia
                dedFechaTerminoVigencia.EditValue = CType("31-12-" + CType(dedFechaNacimiento.DateTime.Year + 18, String), DateTime)
            End If

        End If
    End Sub

    Private Sub leRut_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leRut.EditValueChanged
        Try

            Cursor.Current = Cursors.WaitCursor

            If Len(leRut.EditValue) > 1 Then
                empleado = New empleado(CType(leRut.EditValue, Long))
                HabilitarControles(False)
                If Not empleado Is Nothing Then
                    btnNuevo.Enabled = True
                    refrescarControles()
                Else
                    btnNuevo.Enabled = False
                End If
            End If
            Cursor.Current = Cursors.Default
        Catch exp As Exception
            MessageBox.Show("Atención: " & exp.Message, "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
    Private Sub txtRut_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRut.Validating
        If txtRut.Text <> Nothing And txtRut.Text <> "" Then
            Dim nombreEmpleado As String = empleado.buscaRutCargaFamiliar(txtRut.EditValue)
            'Aplica cuando es un nuevo registro de carga familiar
            If IDCARGA = 0 And nombreEmpleado <> "" And nombreEmpleado <> Nothing Then
                MessageBox.Show("El rut " & CType(txtRut.Text, String) & " de carga familiar se encuentra asociado al empleado " & nombreEmpleado, "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
            Else
                'Aplica solo cuando se actualiza un registro y el rut es distinto
                If IDCARGA > 0 And CType(txtRut.EditValue, Integer) <> CType(oldRutCargaFam, Integer) Then
                    MessageBox.Show("El rut " & CType(txtRut.Text, String) & " de carga familiar se encuentra asociado al empleado " & nombreEmpleado, "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    e.Cancel = True
                Else
                    e.Cancel = False
                End If
            End If
        End If
    End Sub

    Private Sub txtDV_CargaFAM_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDV_CargaFAM.Validating
        If txtDV_CargaFAM.Text <> "" Then
            If (txtDV_CargaFAM.Text) <> Comun.Funciones.Rut.Valida(txtRut.Text) Then
                txtDV_CargaFAM.Text = ""
                MessageBox.Show("El rut de carga familiar es incorrecto", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
            End If
        End If
    End Sub

 
End Class
