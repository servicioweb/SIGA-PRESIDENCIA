Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessRules
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Windows.Forms
Imports System.IO
Imports System.Data.SqlClient


Public Class frmOrganizacion
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
    Friend WithEvents lcgDatosEmpresa As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtAlias As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciAlias As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtRazonSocial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreFantasia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRutEmpresa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciRutEmpresa As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDvEmpresa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciDvEmpresa As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueRegion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueComuna As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciTelefono As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciDireccion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciRegion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciComuna As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciNombreFantasia As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciRazonSocial As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycDatosEmpresa As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents lciCodigoActEconomica As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtApellidoPaternoRepLegal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciApellidoPatRepLegal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtApellidoMaternoRepLegal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciApellidoMatRepLegal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycDatosRepLegal As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtNombresRepLegal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciNombresRepLegal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtRutRepresentanteLegal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciRutRepLegal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDvRepLegal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciDvRepLegal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciCargoRepLegal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCodigoActividadEconomica As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lcgDatosRepresenatLegal As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtNombresJefeSubrogante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtApellidoMaternoJefeSubrogante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtApellidoPaternoJefeSubrogante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lcgDatosJefeSubrogante As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciApellidoPaternoJefeSubrogante As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciApellidoMaternoJefeSubrogante As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciNombresJefeSubrogante As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCargoJefeSubrogante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDvJefeSubrogante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRutJefeSubrogante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lcitRutJefeSubrogante As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciDvJefeSubrogante As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciCargoJefeSubrogante As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lueOrganizaciones As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lciOrganizaciones As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents luePais As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lciPais As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lycDatosJefeSubrogante As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents gpcOpciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCargoRepLegal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gpcLogoOrganizacion As DevExpress.XtraEditors.GroupControl
    Friend WithEvents imgLogoOrganizacion As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents gpbLogoActual As System.Windows.Forms.GroupBox
    Friend WithEvents btnExaminarNuevoLogo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPathNuevoLogo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNuevoLogo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lycDatosEmpresa = New DevExpress.XtraLayout.LayoutControl()
        Me.luePais = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueOrganizaciones = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtCodigoActividadEconomica = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.lueComuna = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueRegion = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDireccion = New DevExpress.XtraEditors.TextEdit()
        Me.txtDvEmpresa = New DevExpress.XtraEditors.TextEdit()
        Me.txtRutEmpresa = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreFantasia = New DevExpress.XtraEditors.TextEdit()
        Me.txtRazonSocial = New DevExpress.XtraEditors.TextEdit()
        Me.txtAlias = New DevExpress.XtraEditors.TextEdit()
        Me.lcgDatosEmpresa = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciAlias = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciRutEmpresa = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciDvEmpresa = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciTelefono = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciDireccion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciCodigoActEconomica = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciRegion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciComuna = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciNombreFantasia = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciRazonSocial = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciOrganizaciones = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciPais = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycDatosRepLegal = New DevExpress.XtraLayout.LayoutControl()
        Me.txtCargoRepLegal = New DevExpress.XtraEditors.TextEdit()
        Me.txtDvRepLegal = New DevExpress.XtraEditors.TextEdit()
        Me.txtRutRepresentanteLegal = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombresRepLegal = New DevExpress.XtraEditors.TextEdit()
        Me.txtApellidoMaternoRepLegal = New DevExpress.XtraEditors.TextEdit()
        Me.txtApellidoPaternoRepLegal = New DevExpress.XtraEditors.TextEdit()
        Me.lcgDatosRepresenatLegal = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciApellidoPatRepLegal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciApellidoMatRepLegal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciNombresRepLegal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciRutRepLegal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciDvRepLegal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciCargoRepLegal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lycDatosJefeSubrogante = New DevExpress.XtraLayout.LayoutControl()
        Me.txtCargoJefeSubrogante = New DevExpress.XtraEditors.TextEdit()
        Me.txtDvJefeSubrogante = New DevExpress.XtraEditors.TextEdit()
        Me.txtRutJefeSubrogante = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombresJefeSubrogante = New DevExpress.XtraEditors.TextEdit()
        Me.txtApellidoMaternoJefeSubrogante = New DevExpress.XtraEditors.TextEdit()
        Me.txtApellidoPaternoJefeSubrogante = New DevExpress.XtraEditors.TextEdit()
        Me.lcgDatosJefeSubrogante = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciApellidoPaternoJefeSubrogante = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciApellidoMaternoJefeSubrogante = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciNombresJefeSubrogante = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcitRutJefeSubrogante = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciDvJefeSubrogante = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciCargoJefeSubrogante = New DevExpress.XtraLayout.LayoutControlItem()
        Me.gpcOpciones = New DevExpress.XtraEditors.GroupControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.gpcLogoOrganizacion = New DevExpress.XtraEditors.GroupControl()
        Me.btnExaminarNuevoLogo = New DevExpress.XtraEditors.SimpleButton()
        Me.txtPathNuevoLogo = New DevExpress.XtraEditors.TextEdit()
        Me.lblNuevoLogo = New DevExpress.XtraEditors.LabelControl()
        Me.gpbLogoActual = New System.Windows.Forms.GroupBox()
        Me.imgLogoOrganizacion = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.lycDatosEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycDatosEmpresa.SuspendLayout()
        CType(Me.luePais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueOrganizaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoActividadEconomica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueComuna.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueRegion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDvEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRutEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreFantasia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRazonSocial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgDatosEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciAlias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciRutEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciDvEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciCodigoActEconomica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciRegion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciComuna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciNombreFantasia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciRazonSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciOrganizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciPais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycDatosRepLegal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycDatosRepLegal.SuspendLayout()
        CType(Me.txtCargoRepLegal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDvRepLegal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRutRepresentanteLegal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombresRepLegal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoMaternoRepLegal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoPaternoRepLegal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgDatosRepresenatLegal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciApellidoPatRepLegal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciApellidoMatRepLegal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciNombresRepLegal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciRutRepLegal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciDvRepLegal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciCargoRepLegal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lycDatosJefeSubrogante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lycDatosJefeSubrogante.SuspendLayout()
        CType(Me.txtCargoJefeSubrogante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDvJefeSubrogante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRutJefeSubrogante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombresJefeSubrogante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoMaternoJefeSubrogante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoPaternoJefeSubrogante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgDatosJefeSubrogante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciApellidoPaternoJefeSubrogante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciApellidoMaternoJefeSubrogante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciNombresJefeSubrogante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcitRutJefeSubrogante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciDvJefeSubrogante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciCargoJefeSubrogante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcOpciones.SuspendLayout()
        CType(Me.gpcLogoOrganizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcLogoOrganizacion.SuspendLayout()
        CType(Me.txtPathNuevoLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbLogoActual.SuspendLayout()
        CType(Me.imgLogoOrganizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lycDatosEmpresa
        '
        Me.lycDatosEmpresa.Controls.Add(Me.luePais)
        Me.lycDatosEmpresa.Controls.Add(Me.lueOrganizaciones)
        Me.lycDatosEmpresa.Controls.Add(Me.txtCodigoActividadEconomica)
        Me.lycDatosEmpresa.Controls.Add(Me.txtTelefono)
        Me.lycDatosEmpresa.Controls.Add(Me.lueComuna)
        Me.lycDatosEmpresa.Controls.Add(Me.lueRegion)
        Me.lycDatosEmpresa.Controls.Add(Me.txtDireccion)
        Me.lycDatosEmpresa.Controls.Add(Me.txtDvEmpresa)
        Me.lycDatosEmpresa.Controls.Add(Me.txtRutEmpresa)
        Me.lycDatosEmpresa.Controls.Add(Me.txtNombreFantasia)
        Me.lycDatosEmpresa.Controls.Add(Me.txtRazonSocial)
        Me.lycDatosEmpresa.Controls.Add(Me.txtAlias)
        Me.lycDatosEmpresa.Location = New System.Drawing.Point(8, 8)
        Me.lycDatosEmpresa.Name = "lycDatosEmpresa"
        Me.lycDatosEmpresa.OptionsView.AllowHotTrack = True
        Me.lycDatosEmpresa.Root = Me.lcgDatosEmpresa
        Me.lycDatosEmpresa.Size = New System.Drawing.Size(624, 272)
        Me.lycDatosEmpresa.TabIndex = 0
        Me.lycDatosEmpresa.Text = "LayoutControl1"
        '
        'luePais
        '
        Me.luePais.Location = New System.Drawing.Point(134, 177)
        Me.luePais.Name = "luePais"
        Me.luePais.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePais.Size = New System.Drawing.Size(484, 20)
        Me.luePais.StyleController = Me.lycDatosEmpresa
        Me.luePais.TabIndex = 12
        '
        'lueOrganizaciones
        '
        Me.lueOrganizaciones.Location = New System.Drawing.Point(134, 26)
        Me.lueOrganizaciones.Name = "lueOrganizaciones"
        Me.lueOrganizaciones.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueOrganizaciones.Size = New System.Drawing.Size(484, 20)
        Me.lueOrganizaciones.StyleController = Me.lycDatosEmpresa
        Me.lueOrganizaciones.TabIndex = 0
        '
        'txtCodigoActividadEconomica
        '
        Me.txtCodigoActividadEconomica.Location = New System.Drawing.Point(516, 86)
        Me.txtCodigoActividadEconomica.Name = "txtCodigoActividadEconomica"
        Me.txtCodigoActividadEconomica.Size = New System.Drawing.Size(102, 20)
        Me.txtCodigoActividadEconomica.StyleController = Me.lycDatosEmpresa
        Me.txtCodigoActividadEconomica.TabIndex = 7
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(516, 116)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(102, 20)
        Me.txtTelefono.StyleController = Me.lycDatosEmpresa
        Me.txtTelefono.TabIndex = 8
        '
        'lueComuna
        '
        Me.lueComuna.Location = New System.Drawing.Point(134, 237)
        Me.lueComuna.Name = "lueComuna"
        Me.lueComuna.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueComuna.Size = New System.Drawing.Size(484, 20)
        Me.lueComuna.StyleController = Me.lycDatosEmpresa
        Me.lueComuna.TabIndex = 11
        '
        'lueRegion
        '
        Me.lueRegion.Location = New System.Drawing.Point(134, 207)
        Me.lueRegion.Name = "lueRegion"
        Me.lueRegion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueRegion.Size = New System.Drawing.Size(484, 20)
        Me.lueRegion.StyleController = Me.lycDatosEmpresa
        Me.lueRegion.TabIndex = 10
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(134, 147)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Properties.MaxLength = 50
        Me.txtDireccion.Size = New System.Drawing.Size(484, 20)
        Me.txtDireccion.StyleController = Me.lycDatosEmpresa
        Me.txtDireccion.TabIndex = 9
        '
        'txtDvEmpresa
        '
        Me.txtDvEmpresa.Location = New System.Drawing.Point(292, 116)
        Me.txtDvEmpresa.Name = "txtDvEmpresa"
        Me.txtDvEmpresa.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDvEmpresa.Properties.MaxLength = 1
        Me.txtDvEmpresa.Size = New System.Drawing.Size(86, 20)
        Me.txtDvEmpresa.StyleController = Me.lycDatosEmpresa
        Me.txtDvEmpresa.TabIndex = 5
        '
        'txtRutEmpresa
        '
        Me.txtRutEmpresa.Location = New System.Drawing.Point(134, 116)
        Me.txtRutEmpresa.Name = "txtRutEmpresa"
        Me.txtRutEmpresa.Properties.DisplayFormat.FormatString = "n0"
        Me.txtRutEmpresa.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRutEmpresa.Properties.EditFormat.FormatString = "n0"
        Me.txtRutEmpresa.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRutEmpresa.Properties.Mask.EditMask = "n0"
        Me.txtRutEmpresa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRutEmpresa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtRutEmpresa.Properties.MaxLength = 8
        Me.txtRutEmpresa.Size = New System.Drawing.Size(138, 20)
        Me.txtRutEmpresa.StyleController = Me.lycDatosEmpresa
        Me.txtRutEmpresa.TabIndex = 4
        '
        'txtNombreFantasia
        '
        Me.txtNombreFantasia.Location = New System.Drawing.Point(516, 56)
        Me.txtNombreFantasia.Name = "txtNombreFantasia"
        Me.txtNombreFantasia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreFantasia.Properties.MaxLength = 50
        Me.txtNombreFantasia.Size = New System.Drawing.Size(102, 20)
        Me.txtNombreFantasia.StyleController = Me.lycDatosEmpresa
        Me.txtNombreFantasia.TabIndex = 6
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(134, 86)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazonSocial.Properties.MaxLength = 50
        Me.txtRazonSocial.Size = New System.Drawing.Size(244, 20)
        Me.txtRazonSocial.StyleController = Me.lycDatosEmpresa
        Me.txtRazonSocial.TabIndex = 2
        '
        'txtAlias
        '
        Me.txtAlias.Location = New System.Drawing.Point(134, 56)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAlias.Properties.MaxLength = 5
        Me.txtAlias.Size = New System.Drawing.Size(244, 20)
        Me.txtAlias.StyleController = Me.lycDatosEmpresa
        Me.txtAlias.TabIndex = 1
        '
        'lcgDatosEmpresa
        '
        Me.lcgDatosEmpresa.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lcgDatosEmpresa.AppearanceGroup.Options.UseFont = True
        Me.lcgDatosEmpresa.CustomizationFormText = "Datos Empresa"
        Me.lcgDatosEmpresa.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciAlias, Me.lciRutEmpresa, Me.lciDvEmpresa, Me.lciTelefono, Me.lciDireccion, Me.lciCodigoActEconomica, Me.lciRegion, Me.lciComuna, Me.lciNombreFantasia, Me.lciRazonSocial, Me.lciOrganizaciones, Me.lciPais})
        Me.lcgDatosEmpresa.Location = New System.Drawing.Point(0, 0)
        Me.lcgDatosEmpresa.Name = "lcgDatosEmpresa"
        Me.lcgDatosEmpresa.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lcgDatosEmpresa.Size = New System.Drawing.Size(624, 272)
        Me.lcgDatosEmpresa.Text = "Datos Empresa"
        '
        'lciAlias
        '
        Me.lciAlias.Control = Me.txtAlias
        Me.lciAlias.CustomizationFormText = "Alias"
        Me.lciAlias.Location = New System.Drawing.Point(0, 30)
        Me.lciAlias.Name = "lciAlias"
        Me.lciAlias.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciAlias.Size = New System.Drawing.Size(382, 30)
        Me.lciAlias.Text = "Alias"
        Me.lciAlias.TextSize = New System.Drawing.Size(125, 13)
        '
        'lciRutEmpresa
        '
        Me.lciRutEmpresa.Control = Me.txtRutEmpresa
        Me.lciRutEmpresa.CustomizationFormText = "Rut Empresa"
        Me.lciRutEmpresa.Location = New System.Drawing.Point(0, 90)
        Me.lciRutEmpresa.MaxSize = New System.Drawing.Size(0, 31)
        Me.lciRutEmpresa.MinSize = New System.Drawing.Size(147, 31)
        Me.lciRutEmpresa.Name = "lciRutEmpresa"
        Me.lciRutEmpresa.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciRutEmpresa.Size = New System.Drawing.Size(276, 31)
        Me.lciRutEmpresa.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lciRutEmpresa.Text = "Rut Empresa"
        Me.lciRutEmpresa.TextSize = New System.Drawing.Size(125, 13)
        '
        'lciDvEmpresa
        '
        Me.lciDvEmpresa.Control = Me.txtDvEmpresa
        Me.lciDvEmpresa.CustomizationFormText = "-"
        Me.lciDvEmpresa.Location = New System.Drawing.Point(276, 90)
        Me.lciDvEmpresa.Name = "lciDvEmpresa"
        Me.lciDvEmpresa.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciDvEmpresa.Size = New System.Drawing.Size(106, 31)
        Me.lciDvEmpresa.Text = "-"
        Me.lciDvEmpresa.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.lciDvEmpresa.TextSize = New System.Drawing.Size(10, 20)
        Me.lciDvEmpresa.TextToControlDistance = 0
        '
        'lciTelefono
        '
        Me.lciTelefono.Control = Me.txtTelefono
        Me.lciTelefono.CustomizationFormText = "Teléfono"
        Me.lciTelefono.Location = New System.Drawing.Point(382, 90)
        Me.lciTelefono.Name = "lciTelefono"
        Me.lciTelefono.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciTelefono.Size = New System.Drawing.Size(240, 31)
        Me.lciTelefono.Text = "Teléfono"
        Me.lciTelefono.TextSize = New System.Drawing.Size(125, 13)
        '
        'lciDireccion
        '
        Me.lciDireccion.Control = Me.txtDireccion
        Me.lciDireccion.CustomizationFormText = "Dirección"
        Me.lciDireccion.Location = New System.Drawing.Point(0, 121)
        Me.lciDireccion.Name = "lciDireccion"
        Me.lciDireccion.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciDireccion.Size = New System.Drawing.Size(622, 30)
        Me.lciDireccion.Text = "Dirección"
        Me.lciDireccion.TextSize = New System.Drawing.Size(125, 13)
        '
        'lciCodigoActEconomica
        '
        Me.lciCodigoActEconomica.Control = Me.txtCodigoActividadEconomica
        Me.lciCodigoActEconomica.CustomizationFormText = "Código Actidad Económica"
        Me.lciCodigoActEconomica.Location = New System.Drawing.Point(382, 60)
        Me.lciCodigoActEconomica.Name = "lciCodigoActEconomica"
        Me.lciCodigoActEconomica.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciCodigoActEconomica.Size = New System.Drawing.Size(240, 30)
        Me.lciCodigoActEconomica.Text = "Código Actidad Económica"
        Me.lciCodigoActEconomica.TextSize = New System.Drawing.Size(125, 13)
        '
        'lciRegion
        '
        Me.lciRegion.Control = Me.lueRegion
        Me.lciRegion.CustomizationFormText = "Región"
        Me.lciRegion.Location = New System.Drawing.Point(0, 181)
        Me.lciRegion.Name = "lciRegion"
        Me.lciRegion.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciRegion.Size = New System.Drawing.Size(622, 30)
        Me.lciRegion.Text = "Región"
        Me.lciRegion.TextSize = New System.Drawing.Size(125, 13)
        '
        'lciComuna
        '
        Me.lciComuna.Control = Me.lueComuna
        Me.lciComuna.CustomizationFormText = "Comuna"
        Me.lciComuna.Location = New System.Drawing.Point(0, 211)
        Me.lciComuna.Name = "lciComuna"
        Me.lciComuna.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciComuna.Size = New System.Drawing.Size(622, 39)
        Me.lciComuna.Text = "Comuna"
        Me.lciComuna.TextSize = New System.Drawing.Size(125, 13)
        '
        'lciNombreFantasia
        '
        Me.lciNombreFantasia.Control = Me.txtNombreFantasia
        Me.lciNombreFantasia.CustomizationFormText = "Nombre Fantasia"
        Me.lciNombreFantasia.Location = New System.Drawing.Point(382, 30)
        Me.lciNombreFantasia.Name = "lciNombreFantasia"
        Me.lciNombreFantasia.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciNombreFantasia.Size = New System.Drawing.Size(240, 30)
        Me.lciNombreFantasia.Text = "Nombre Fantasia"
        Me.lciNombreFantasia.TextSize = New System.Drawing.Size(125, 13)
        '
        'lciRazonSocial
        '
        Me.lciRazonSocial.Control = Me.txtRazonSocial
        Me.lciRazonSocial.CustomizationFormText = "Razón Social"
        Me.lciRazonSocial.Location = New System.Drawing.Point(0, 60)
        Me.lciRazonSocial.Name = "lciRazonSocial"
        Me.lciRazonSocial.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciRazonSocial.Size = New System.Drawing.Size(382, 30)
        Me.lciRazonSocial.Text = "Razón Social"
        Me.lciRazonSocial.TextSize = New System.Drawing.Size(125, 13)
        '
        'lciOrganizaciones
        '
        Me.lciOrganizaciones.Control = Me.lueOrganizaciones
        Me.lciOrganizaciones.CustomizationFormText = "Organizaciones"
        Me.lciOrganizaciones.Location = New System.Drawing.Point(0, 0)
        Me.lciOrganizaciones.Name = "lciOrganizaciones"
        Me.lciOrganizaciones.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciOrganizaciones.Size = New System.Drawing.Size(622, 30)
        Me.lciOrganizaciones.Text = "Organizaciones"
        Me.lciOrganizaciones.TextSize = New System.Drawing.Size(125, 13)
        '
        'lciPais
        '
        Me.lciPais.Control = Me.luePais
        Me.lciPais.CustomizationFormText = "País"
        Me.lciPais.Location = New System.Drawing.Point(0, 151)
        Me.lciPais.Name = "lciPais"
        Me.lciPais.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciPais.Size = New System.Drawing.Size(622, 30)
        Me.lciPais.Text = "País"
        Me.lciPais.TextSize = New System.Drawing.Size(125, 13)
        '
        'lycDatosRepLegal
        '
        Me.lycDatosRepLegal.Controls.Add(Me.txtCargoRepLegal)
        Me.lycDatosRepLegal.Controls.Add(Me.txtDvRepLegal)
        Me.lycDatosRepLegal.Controls.Add(Me.txtRutRepresentanteLegal)
        Me.lycDatosRepLegal.Controls.Add(Me.txtNombresRepLegal)
        Me.lycDatosRepLegal.Controls.Add(Me.txtApellidoMaternoRepLegal)
        Me.lycDatosRepLegal.Controls.Add(Me.txtApellidoPaternoRepLegal)
        Me.lycDatosRepLegal.Location = New System.Drawing.Point(8, 280)
        Me.lycDatosRepLegal.Name = "lycDatosRepLegal"
        Me.lycDatosRepLegal.OptionsView.AllowHotTrack = True
        Me.lycDatosRepLegal.Root = Me.lcgDatosRepresenatLegal
        Me.lycDatosRepLegal.Size = New System.Drawing.Size(624, 176)
        Me.lycDatosRepLegal.TabIndex = 1
        Me.lycDatosRepLegal.Text = "LayoutControl2"
        '
        'txtCargoRepLegal
        '
        Me.txtCargoRepLegal.Location = New System.Drawing.Point(89, 146)
        Me.txtCargoRepLegal.Name = "txtCargoRepLegal"
        Me.txtCargoRepLegal.Properties.MaxLength = 50
        Me.txtCargoRepLegal.Size = New System.Drawing.Size(529, 20)
        Me.txtCargoRepLegal.StyleController = Me.lycDatosRepLegal
        Me.txtCargoRepLegal.TabIndex = 17
        '
        'txtDvRepLegal
        '
        Me.txtDvRepLegal.Location = New System.Drawing.Point(491, 116)
        Me.txtDvRepLegal.Name = "txtDvRepLegal"
        Me.txtDvRepLegal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDvRepLegal.Properties.MaxLength = 1
        Me.txtDvRepLegal.Size = New System.Drawing.Size(127, 20)
        Me.txtDvRepLegal.StyleController = Me.lycDatosRepLegal
        Me.txtDvRepLegal.TabIndex = 16
        '
        'txtRutRepresentanteLegal
        '
        Me.txtRutRepresentanteLegal.Location = New System.Drawing.Point(89, 116)
        Me.txtRutRepresentanteLegal.Name = "txtRutRepresentanteLegal"
        Me.txtRutRepresentanteLegal.Properties.DisplayFormat.FormatString = "n0"
        Me.txtRutRepresentanteLegal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRutRepresentanteLegal.Properties.EditFormat.FormatString = "n0"
        Me.txtRutRepresentanteLegal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRutRepresentanteLegal.Properties.Mask.EditMask = "n0"
        Me.txtRutRepresentanteLegal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRutRepresentanteLegal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtRutRepresentanteLegal.Properties.MaxLength = 8
        Me.txtRutRepresentanteLegal.Size = New System.Drawing.Size(367, 20)
        Me.txtRutRepresentanteLegal.StyleController = Me.lycDatosRepLegal
        Me.txtRutRepresentanteLegal.TabIndex = 15
        '
        'txtNombresRepLegal
        '
        Me.txtNombresRepLegal.Location = New System.Drawing.Point(89, 86)
        Me.txtNombresRepLegal.Name = "txtNombresRepLegal"
        Me.txtNombresRepLegal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombresRepLegal.Properties.MaxLength = 50
        Me.txtNombresRepLegal.Size = New System.Drawing.Size(529, 20)
        Me.txtNombresRepLegal.StyleController = Me.lycDatosRepLegal
        Me.txtNombresRepLegal.TabIndex = 14
        '
        'txtApellidoMaternoRepLegal
        '
        Me.txtApellidoMaternoRepLegal.Location = New System.Drawing.Point(89, 56)
        Me.txtApellidoMaternoRepLegal.Name = "txtApellidoMaternoRepLegal"
        Me.txtApellidoMaternoRepLegal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoMaternoRepLegal.Properties.MaxLength = 50
        Me.txtApellidoMaternoRepLegal.Size = New System.Drawing.Size(529, 20)
        Me.txtApellidoMaternoRepLegal.StyleController = Me.lycDatosRepLegal
        Me.txtApellidoMaternoRepLegal.TabIndex = 13
        '
        'txtApellidoPaternoRepLegal
        '
        Me.txtApellidoPaternoRepLegal.Location = New System.Drawing.Point(89, 26)
        Me.txtApellidoPaternoRepLegal.Name = "txtApellidoPaternoRepLegal"
        Me.txtApellidoPaternoRepLegal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoPaternoRepLegal.Properties.MaxLength = 50
        Me.txtApellidoPaternoRepLegal.Size = New System.Drawing.Size(529, 20)
        Me.txtApellidoPaternoRepLegal.StyleController = Me.lycDatosRepLegal
        Me.txtApellidoPaternoRepLegal.TabIndex = 12
        '
        'lcgDatosRepresenatLegal
        '
        Me.lcgDatosRepresenatLegal.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lcgDatosRepresenatLegal.AppearanceGroup.Options.UseFont = True
        Me.lcgDatosRepresenatLegal.CustomizationFormText = "Datos Representate Legal"
        Me.lcgDatosRepresenatLegal.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciApellidoPatRepLegal, Me.lciApellidoMatRepLegal, Me.lciNombresRepLegal, Me.lciRutRepLegal, Me.lciDvRepLegal, Me.lciCargoRepLegal})
        Me.lcgDatosRepresenatLegal.Location = New System.Drawing.Point(0, 0)
        Me.lcgDatosRepresenatLegal.Name = "lcgDatosRepresenatLegal"
        Me.lcgDatosRepresenatLegal.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lcgDatosRepresenatLegal.Size = New System.Drawing.Size(624, 176)
        Me.lcgDatosRepresenatLegal.Text = "Datos Representate Legal"
        '
        'lciApellidoPatRepLegal
        '
        Me.lciApellidoPatRepLegal.Control = Me.txtApellidoPaternoRepLegal
        Me.lciApellidoPatRepLegal.CustomizationFormText = "Apellido Paterno"
        Me.lciApellidoPatRepLegal.Location = New System.Drawing.Point(0, 0)
        Me.lciApellidoPatRepLegal.Name = "lciApellidoPatRepLegal"
        Me.lciApellidoPatRepLegal.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciApellidoPatRepLegal.Size = New System.Drawing.Size(622, 30)
        Me.lciApellidoPatRepLegal.Text = "Apellido Paterno"
        Me.lciApellidoPatRepLegal.TextSize = New System.Drawing.Size(80, 13)
        '
        'lciApellidoMatRepLegal
        '
        Me.lciApellidoMatRepLegal.Control = Me.txtApellidoMaternoRepLegal
        Me.lciApellidoMatRepLegal.CustomizationFormText = "Apellido Materno"
        Me.lciApellidoMatRepLegal.Location = New System.Drawing.Point(0, 30)
        Me.lciApellidoMatRepLegal.Name = "lciApellidoMatRepLegal"
        Me.lciApellidoMatRepLegal.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciApellidoMatRepLegal.Size = New System.Drawing.Size(622, 30)
        Me.lciApellidoMatRepLegal.Text = "Apellido Materno"
        Me.lciApellidoMatRepLegal.TextSize = New System.Drawing.Size(80, 13)
        '
        'lciNombresRepLegal
        '
        Me.lciNombresRepLegal.Control = Me.txtNombresRepLegal
        Me.lciNombresRepLegal.CustomizationFormText = "Nombres"
        Me.lciNombresRepLegal.Location = New System.Drawing.Point(0, 60)
        Me.lciNombresRepLegal.Name = "lciNombresRepLegal"
        Me.lciNombresRepLegal.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciNombresRepLegal.Size = New System.Drawing.Size(622, 30)
        Me.lciNombresRepLegal.Text = "Nombres"
        Me.lciNombresRepLegal.TextSize = New System.Drawing.Size(80, 13)
        '
        'lciRutRepLegal
        '
        Me.lciRutRepLegal.Control = Me.txtRutRepresentanteLegal
        Me.lciRutRepLegal.CustomizationFormText = "Rut"
        Me.lciRutRepLegal.Location = New System.Drawing.Point(0, 90)
        Me.lciRutRepLegal.Name = "lciRutRepLegal"
        Me.lciRutRepLegal.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciRutRepLegal.Size = New System.Drawing.Size(460, 30)
        Me.lciRutRepLegal.Text = "Rut"
        Me.lciRutRepLegal.TextSize = New System.Drawing.Size(80, 13)
        '
        'lciDvRepLegal
        '
        Me.lciDvRepLegal.Control = Me.txtDvRepLegal
        Me.lciDvRepLegal.CustomizationFormText = "-"
        Me.lciDvRepLegal.Location = New System.Drawing.Point(460, 90)
        Me.lciDvRepLegal.Name = "lciDvRepLegal"
        Me.lciDvRepLegal.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciDvRepLegal.Size = New System.Drawing.Size(162, 30)
        Me.lciDvRepLegal.Text = "-"
        Me.lciDvRepLegal.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.lciDvRepLegal.TextSize = New System.Drawing.Size(20, 20)
        Me.lciDvRepLegal.TextToControlDistance = 5
        '
        'lciCargoRepLegal
        '
        Me.lciCargoRepLegal.Control = Me.txtCargoRepLegal
        Me.lciCargoRepLegal.CustomizationFormText = "Cargo"
        Me.lciCargoRepLegal.Location = New System.Drawing.Point(0, 120)
        Me.lciCargoRepLegal.Name = "lciCargoRepLegal"
        Me.lciCargoRepLegal.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciCargoRepLegal.Size = New System.Drawing.Size(622, 34)
        Me.lciCargoRepLegal.Text = "Cargo"
        Me.lciCargoRepLegal.TextSize = New System.Drawing.Size(80, 13)
        '
        'lycDatosJefeSubrogante
        '
        Me.lycDatosJefeSubrogante.Controls.Add(Me.txtCargoJefeSubrogante)
        Me.lycDatosJefeSubrogante.Controls.Add(Me.txtDvJefeSubrogante)
        Me.lycDatosJefeSubrogante.Controls.Add(Me.txtRutJefeSubrogante)
        Me.lycDatosJefeSubrogante.Controls.Add(Me.txtNombresJefeSubrogante)
        Me.lycDatosJefeSubrogante.Controls.Add(Me.txtApellidoMaternoJefeSubrogante)
        Me.lycDatosJefeSubrogante.Controls.Add(Me.txtApellidoPaternoJefeSubrogante)
        Me.lycDatosJefeSubrogante.Location = New System.Drawing.Point(8, 456)
        Me.lycDatosJefeSubrogante.Name = "lycDatosJefeSubrogante"
        Me.lycDatosJefeSubrogante.OptionsView.AllowHotTrack = True
        Me.lycDatosJefeSubrogante.Root = Me.lcgDatosJefeSubrogante
        Me.lycDatosJefeSubrogante.Size = New System.Drawing.Size(624, 176)
        Me.lycDatosJefeSubrogante.TabIndex = 2
        Me.lycDatosJefeSubrogante.Text = "LayoutControl2"
        '
        'txtCargoJefeSubrogante
        '
        Me.txtCargoJefeSubrogante.Location = New System.Drawing.Point(89, 146)
        Me.txtCargoJefeSubrogante.Name = "txtCargoJefeSubrogante"
        Me.txtCargoJefeSubrogante.Properties.MaxLength = 50
        Me.txtCargoJefeSubrogante.Size = New System.Drawing.Size(529, 20)
        Me.txtCargoJefeSubrogante.StyleController = Me.lycDatosJefeSubrogante
        Me.txtCargoJefeSubrogante.TabIndex = 23
        '
        'txtDvJefeSubrogante
        '
        Me.txtDvJefeSubrogante.Location = New System.Drawing.Point(491, 116)
        Me.txtDvJefeSubrogante.Name = "txtDvJefeSubrogante"
        Me.txtDvJefeSubrogante.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDvJefeSubrogante.Properties.MaxLength = 1
        Me.txtDvJefeSubrogante.Size = New System.Drawing.Size(127, 20)
        Me.txtDvJefeSubrogante.StyleController = Me.lycDatosJefeSubrogante
        Me.txtDvJefeSubrogante.TabIndex = 22
        '
        'txtRutJefeSubrogante
        '
        Me.txtRutJefeSubrogante.Location = New System.Drawing.Point(89, 116)
        Me.txtRutJefeSubrogante.Name = "txtRutJefeSubrogante"
        Me.txtRutJefeSubrogante.Properties.DisplayFormat.FormatString = "n0"
        Me.txtRutJefeSubrogante.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRutJefeSubrogante.Properties.EditFormat.FormatString = "n0"
        Me.txtRutJefeSubrogante.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRutJefeSubrogante.Properties.Mask.EditMask = "n0"
        Me.txtRutJefeSubrogante.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRutJefeSubrogante.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtRutJefeSubrogante.Properties.MaxLength = 8
        Me.txtRutJefeSubrogante.Size = New System.Drawing.Size(367, 20)
        Me.txtRutJefeSubrogante.StyleController = Me.lycDatosJefeSubrogante
        Me.txtRutJefeSubrogante.TabIndex = 21
        '
        'txtNombresJefeSubrogante
        '
        Me.txtNombresJefeSubrogante.Location = New System.Drawing.Point(89, 86)
        Me.txtNombresJefeSubrogante.Name = "txtNombresJefeSubrogante"
        Me.txtNombresJefeSubrogante.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombresJefeSubrogante.Properties.MaxLength = 50
        Me.txtNombresJefeSubrogante.Size = New System.Drawing.Size(529, 20)
        Me.txtNombresJefeSubrogante.StyleController = Me.lycDatosJefeSubrogante
        Me.txtNombresJefeSubrogante.TabIndex = 20
        '
        'txtApellidoMaternoJefeSubrogante
        '
        Me.txtApellidoMaternoJefeSubrogante.Location = New System.Drawing.Point(89, 56)
        Me.txtApellidoMaternoJefeSubrogante.Name = "txtApellidoMaternoJefeSubrogante"
        Me.txtApellidoMaternoJefeSubrogante.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoMaternoJefeSubrogante.Properties.MaxLength = 50
        Me.txtApellidoMaternoJefeSubrogante.Size = New System.Drawing.Size(529, 20)
        Me.txtApellidoMaternoJefeSubrogante.StyleController = Me.lycDatosJefeSubrogante
        Me.txtApellidoMaternoJefeSubrogante.TabIndex = 19
        '
        'txtApellidoPaternoJefeSubrogante
        '
        Me.txtApellidoPaternoJefeSubrogante.Location = New System.Drawing.Point(89, 26)
        Me.txtApellidoPaternoJefeSubrogante.Name = "txtApellidoPaternoJefeSubrogante"
        Me.txtApellidoPaternoJefeSubrogante.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoPaternoJefeSubrogante.Properties.MaxLength = 50
        Me.txtApellidoPaternoJefeSubrogante.Size = New System.Drawing.Size(529, 20)
        Me.txtApellidoPaternoJefeSubrogante.StyleController = Me.lycDatosJefeSubrogante
        Me.txtApellidoPaternoJefeSubrogante.TabIndex = 18
        '
        'lcgDatosJefeSubrogante
        '
        Me.lcgDatosJefeSubrogante.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lcgDatosJefeSubrogante.AppearanceGroup.Options.UseFont = True
        Me.lcgDatosJefeSubrogante.CustomizationFormText = "Datos Jefe Subrogante"
        Me.lcgDatosJefeSubrogante.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciApellidoPaternoJefeSubrogante, Me.lciApellidoMaternoJefeSubrogante, Me.lciNombresJefeSubrogante, Me.lcitRutJefeSubrogante, Me.lciDvJefeSubrogante, Me.lciCargoJefeSubrogante})
        Me.lcgDatosJefeSubrogante.Location = New System.Drawing.Point(0, 0)
        Me.lcgDatosJefeSubrogante.Name = "lcgDatosJefeSubrogante"
        Me.lcgDatosJefeSubrogante.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lcgDatosJefeSubrogante.Size = New System.Drawing.Size(624, 176)
        Me.lcgDatosJefeSubrogante.Text = "Datos Jefe Subrogante"
        '
        'lciApellidoPaternoJefeSubrogante
        '
        Me.lciApellidoPaternoJefeSubrogante.Control = Me.txtApellidoPaternoJefeSubrogante
        Me.lciApellidoPaternoJefeSubrogante.CustomizationFormText = "Apellido Paterno"
        Me.lciApellidoPaternoJefeSubrogante.Location = New System.Drawing.Point(0, 0)
        Me.lciApellidoPaternoJefeSubrogante.Name = "lciApellidoPaternoJefeSubrogante"
        Me.lciApellidoPaternoJefeSubrogante.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciApellidoPaternoJefeSubrogante.Size = New System.Drawing.Size(622, 30)
        Me.lciApellidoPaternoJefeSubrogante.Text = "Apellido Paterno"
        Me.lciApellidoPaternoJefeSubrogante.TextSize = New System.Drawing.Size(80, 13)
        '
        'lciApellidoMaternoJefeSubrogante
        '
        Me.lciApellidoMaternoJefeSubrogante.Control = Me.txtApellidoMaternoJefeSubrogante
        Me.lciApellidoMaternoJefeSubrogante.CustomizationFormText = "Apellido Materno"
        Me.lciApellidoMaternoJefeSubrogante.Location = New System.Drawing.Point(0, 30)
        Me.lciApellidoMaternoJefeSubrogante.Name = "lciApellidoMaternoJefeSubrogante"
        Me.lciApellidoMaternoJefeSubrogante.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciApellidoMaternoJefeSubrogante.Size = New System.Drawing.Size(622, 30)
        Me.lciApellidoMaternoJefeSubrogante.Text = "Apellido Materno"
        Me.lciApellidoMaternoJefeSubrogante.TextSize = New System.Drawing.Size(80, 13)
        '
        'lciNombresJefeSubrogante
        '
        Me.lciNombresJefeSubrogante.Control = Me.txtNombresJefeSubrogante
        Me.lciNombresJefeSubrogante.CustomizationFormText = "Nombres"
        Me.lciNombresJefeSubrogante.Location = New System.Drawing.Point(0, 60)
        Me.lciNombresJefeSubrogante.Name = "lciNombresJefeSubrogante"
        Me.lciNombresJefeSubrogante.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciNombresJefeSubrogante.Size = New System.Drawing.Size(622, 30)
        Me.lciNombresJefeSubrogante.Text = "Nombres"
        Me.lciNombresJefeSubrogante.TextSize = New System.Drawing.Size(80, 13)
        '
        'lcitRutJefeSubrogante
        '
        Me.lcitRutJefeSubrogante.Control = Me.txtRutJefeSubrogante
        Me.lcitRutJefeSubrogante.CustomizationFormText = "Rut"
        Me.lcitRutJefeSubrogante.Location = New System.Drawing.Point(0, 90)
        Me.lcitRutJefeSubrogante.Name = "lcitRutJefeSubrogante"
        Me.lcitRutJefeSubrogante.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lcitRutJefeSubrogante.Size = New System.Drawing.Size(460, 30)
        Me.lcitRutJefeSubrogante.Text = "Rut"
        Me.lcitRutJefeSubrogante.TextSize = New System.Drawing.Size(80, 13)
        '
        'lciDvJefeSubrogante
        '
        Me.lciDvJefeSubrogante.Control = Me.txtDvJefeSubrogante
        Me.lciDvJefeSubrogante.CustomizationFormText = "-"
        Me.lciDvJefeSubrogante.Location = New System.Drawing.Point(460, 90)
        Me.lciDvJefeSubrogante.Name = "lciDvJefeSubrogante"
        Me.lciDvJefeSubrogante.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciDvJefeSubrogante.Size = New System.Drawing.Size(162, 30)
        Me.lciDvJefeSubrogante.Text = "-"
        Me.lciDvJefeSubrogante.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.lciDvJefeSubrogante.TextSize = New System.Drawing.Size(20, 20)
        Me.lciDvJefeSubrogante.TextToControlDistance = 5
        '
        'lciCargoJefeSubrogante
        '
        Me.lciCargoJefeSubrogante.Control = Me.txtCargoJefeSubrogante
        Me.lciCargoJefeSubrogante.CustomizationFormText = "Cargo"
        Me.lciCargoJefeSubrogante.Location = New System.Drawing.Point(0, 120)
        Me.lciCargoJefeSubrogante.Name = "lciCargoJefeSubrogante"
        Me.lciCargoJefeSubrogante.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lciCargoJefeSubrogante.Size = New System.Drawing.Size(622, 34)
        Me.lciCargoJefeSubrogante.Text = "Cargo"
        Me.lciCargoJefeSubrogante.TextSize = New System.Drawing.Size(80, 13)
        '
        'gpcOpciones
        '
        Me.gpcOpciones.Controls.Add(Me.btnCancelar)
        Me.gpcOpciones.Controls.Add(Me.btnEliminar)
        Me.gpcOpciones.Controls.Add(Me.btnGuardar)
        Me.gpcOpciones.Controls.Add(Me.btnNuevo)
        Me.gpcOpciones.Location = New System.Drawing.Point(8, 632)
        Me.gpcOpciones.Name = "gpcOpciones"
        Me.gpcOpciones.ShowCaption = False
        Me.gpcOpciones.Size = New System.Drawing.Size(624, 40)
        Me.gpcOpciones.TabIndex = 3
        Me.gpcOpciones.Text = "Opciones"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(424, 8)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(320, 8)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(216, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(112, 8)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        '
        'gpcLogoOrganizacion
        '
        Me.gpcLogoOrganizacion.Controls.Add(Me.btnExaminarNuevoLogo)
        Me.gpcLogoOrganizacion.Controls.Add(Me.txtPathNuevoLogo)
        Me.gpcLogoOrganizacion.Controls.Add(Me.lblNuevoLogo)
        Me.gpcLogoOrganizacion.Controls.Add(Me.gpbLogoActual)
        Me.gpcLogoOrganizacion.Location = New System.Drawing.Point(638, 8)
        Me.gpcLogoOrganizacion.Name = "gpcLogoOrganizacion"
        Me.gpcLogoOrganizacion.Size = New System.Drawing.Size(372, 272)
        Me.gpcLogoOrganizacion.TabIndex = 4
        Me.gpcLogoOrganizacion.Text = "Logo Organización"
        '
        'btnExaminarNuevoLogo
        '
        Me.btnExaminarNuevoLogo.Location = New System.Drawing.Point(292, 224)
        Me.btnExaminarNuevoLogo.Name = "btnExaminarNuevoLogo"
        Me.btnExaminarNuevoLogo.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminarNuevoLogo.TabIndex = 5
        Me.btnExaminarNuevoLogo.Text = "Examinar..."
        '
        'txtPathNuevoLogo
        '
        Me.txtPathNuevoLogo.Location = New System.Drawing.Point(69, 227)
        Me.txtPathNuevoLogo.Name = "txtPathNuevoLogo"
        Me.txtPathNuevoLogo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtPathNuevoLogo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtPathNuevoLogo.Properties.ReadOnly = True
        Me.txtPathNuevoLogo.Size = New System.Drawing.Size(213, 20)
        Me.txtPathNuevoLogo.TabIndex = 3
        '
        'lblNuevoLogo
        '
        Me.lblNuevoLogo.Location = New System.Drawing.Point(6, 230)
        Me.lblNuevoLogo.Name = "lblNuevoLogo"
        Me.lblNuevoLogo.Size = New System.Drawing.Size(57, 13)
        Me.lblNuevoLogo.TabIndex = 2
        Me.lblNuevoLogo.Text = "Nuevo Logo"
        '
        'gpbLogoActual
        '
        Me.gpbLogoActual.Controls.Add(Me.imgLogoOrganizacion)
        Me.gpbLogoActual.Location = New System.Drawing.Point(107, 29)
        Me.gpbLogoActual.Name = "gpbLogoActual"
        Me.gpbLogoActual.Size = New System.Drawing.Size(163, 180)
        Me.gpbLogoActual.TabIndex = 1
        Me.gpbLogoActual.TabStop = False
        Me.gpbLogoActual.Text = "Logo Actual"
        '
        'imgLogoOrganizacion
        '
        Me.imgLogoOrganizacion.Location = New System.Drawing.Point(14, 19)
        Me.imgLogoOrganizacion.Name = "imgLogoOrganizacion"
        Me.imgLogoOrganizacion.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.imgLogoOrganizacion.Size = New System.Drawing.Size(143, 155)
        Me.imgLogoOrganizacion.TabIndex = 0
        '
        'frmOrganizacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1017, 678)
        Me.Controls.Add(Me.gpcLogoOrganizacion)
        Me.Controls.Add(Me.gpcOpciones)
        Me.Controls.Add(Me.lycDatosJefeSubrogante)
        Me.Controls.Add(Me.lycDatosRepLegal)
        Me.Controls.Add(Me.lycDatosEmpresa)
        Me.Name = "frmOrganizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor Organización"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.lycDatosEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycDatosEmpresa.ResumeLayout(False)
        CType(Me.luePais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueOrganizaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoActividadEconomica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueComuna.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueRegion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDvEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRutEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreFantasia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRazonSocial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgDatosEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciAlias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciRutEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciDvEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciCodigoActEconomica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciRegion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciComuna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciNombreFantasia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciRazonSocial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciOrganizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciPais, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycDatosRepLegal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycDatosRepLegal.ResumeLayout(False)
        CType(Me.txtCargoRepLegal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDvRepLegal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRutRepresentanteLegal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombresRepLegal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoMaternoRepLegal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoPaternoRepLegal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgDatosRepresenatLegal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciApellidoPatRepLegal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciApellidoMatRepLegal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciNombresRepLegal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciRutRepLegal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciDvRepLegal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciCargoRepLegal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lycDatosJefeSubrogante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lycDatosJefeSubrogante.ResumeLayout(False)
        CType(Me.txtCargoJefeSubrogante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDvJefeSubrogante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRutJefeSubrogante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombresJefeSubrogante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoMaternoJefeSubrogante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoPaternoJefeSubrogante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgDatosJefeSubrogante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciApellidoPaternoJefeSubrogante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciApellidoMaternoJefeSubrogante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciNombresJefeSubrogante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcitRutJefeSubrogante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciDvJefeSubrogante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciCargoJefeSubrogante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcOpciones.ResumeLayout(False)
        CType(Me.gpcLogoOrganizacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcLogoOrganizacion.ResumeLayout(False)
        Me.gpcLogoOrganizacion.PerformLayout()
        CType(Me.txtPathNuevoLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbLogoActual.ResumeLayout(False)
        CType(Me.imgLogoOrganizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim mantenedor As Mantenedor

    Private Sub frmOrganizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        repositorio.RefreshDatos("Organizacion")
        repositorio.RefreshDatos("Localidad")
        llenarOrganizacion()
        llenarPais()
        llenarRegion()
        llenarComuna()
        botonesInicio()

    End Sub
    Private Sub llenarOrganizacion()
        With lueOrganizaciones
            With .Properties.Columns
                .Add(New LookUpColumnInfo("ORGANIZACION_ID", "ID Organización", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueOrganizaciones.Properties.DataSource = repositorio.dvOrganizacion
        lueOrganizaciones.Properties.DisplayMember = "DESCRIPCION"
        lueOrganizaciones.Properties.NullText = ""
        lueOrganizaciones.Properties.PopupWidth = 200
        lueOrganizaciones.Properties.ValueMember = "ORGANIZACION_ID"
    End Sub
    Private Sub llenarPais()
        With luePais
            With .Properties.Columns
                .Add(New LookUpColumnInfo("PAIS_ID", "ID País", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        luePais.Properties.DataSource = repositorio.dvPaises
        luePais.Properties.DisplayMember = "DESCRIPCION"
        luePais.Properties.NullText = ""
        luePais.Properties.PopupWidth = 200
        luePais.Properties.ValueMember = "PAIS_ID"
    End Sub

    Private Sub llenarRegion()
        With lueRegion
            With .Properties.Columns
                .Add(New LookUpColumnInfo("REGION_ID", "ID Región", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueRegion.Properties.DataSource = repositorio.dvRegiones
        lueRegion.Properties.DisplayMember = "DESCRIPCION"
        lueRegion.Properties.NullText = ""
        lueRegion.Properties.PopupWidth = 200
        lueRegion.Properties.ValueMember = "REGION_ID"
    End Sub
    Private Sub llenarComuna()
        With lueComuna
            With .Properties.Columns
                .Add(New LookUpColumnInfo("COMUNA_ID", "ID Comuna", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueComuna.Properties.DataSource = repositorio.dvComunas
        lueComuna.Properties.DisplayMember = "DESCRIPCION"
        lueComuna.Properties.NullText = ""
        lueComuna.Properties.PopupWidth = 200
        lueComuna.Properties.ValueMember = "COMUNA_ID"
    End Sub

    Private Sub lueOrganizaciones_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueOrganizaciones.EditValueChanged
        If lueOrganizaciones.EditValue > 0 Then
            Dim mydr As DataAccess.DSMantenedores.GEN_ORGANIZACIONRow = Nothing
            mantenedor = New Mantenedor(lueOrganizaciones.EditValue, mydr)
            asignarControles()
            botonesEdicion()
            imgLogoOrganizacion.Image = ObtenerLogoOrganizacion(mantenedor.datosOrganizacion.organizacionID)
            imgLogoOrganizacion.Refresh()
        End If
    End Sub
    Private Sub asignarControles()
        txtAlias.Text = mantenedor.datosOrganizacion.organizacionAlias.Trim
        txtRazonSocial.Text = mantenedor.datosOrganizacion.razonSocial.Trim
        txtRutEmpresa.Text = mantenedor.datosOrganizacion.rutEmpresa
        txtDvEmpresa.Text = mantenedor.datosOrganizacion.dvEmpresa
        txtDireccion.Text = mantenedor.datosOrganizacion.direccion.Trim
        txtTelefono.Text = mantenedor.datosOrganizacion.telefono
        txtCodigoActividadEconomica.Text = mantenedor.datosOrganizacion.codigoActividadEconomica
        luePais.EditValue = mantenedor.datosOrganizacion.paisID
        lueRegion.EditValue = mantenedor.datosOrganizacion.regionID
        lueComuna.EditValue = mantenedor.datosOrganizacion.comunaID
        txtApellidoPaternoRepLegal.Text = mantenedor.datosOrganizacion.apellidoPaternoRepLegal.Trim
        txtApellidoMaternoRepLegal.Text = mantenedor.datosOrganizacion.apellidoMaternoRepLegal
        txtNombresRepLegal.Text = mantenedor.datosOrganizacion.nombresRepLegal
        txtRutRepresentanteLegal.Text = mantenedor.datosOrganizacion.rutRepLegal
        txtDvRepLegal.Text = mantenedor.datosOrganizacion.dvRepLegal
        txtCargoRepLegal.Text = mantenedor.datosOrganizacion.cargoRepLegal.Trim
        txtApellidoPaternoJefeSubrogante.Text = mantenedor.datosOrganizacion.apellidoPaternoJefeSubrogante
        txtApellidoMaternoJefeSubrogante.Text = mantenedor.datosOrganizacion.apellidoMaternoJefeSubrogante
        txtNombresJefeSubrogante.Text = mantenedor.datosOrganizacion.nombresJefeSubrogante
        txtRutJefeSubrogante.Text = mantenedor.datosOrganizacion.rutRepJefeSubrogante
        txtDvJefeSubrogante.Text = mantenedor.datosOrganizacion.dvRepJefeSubrogante.Trim
        txtCargoJefeSubrogante.Text = mantenedor.datosOrganizacion.cargoJefeSubrogante
        txtNombreFantasia.Text = mantenedor.datosOrganizacion.nombreFantasia.Trim
    End Sub
    Private Sub botonesInicio()
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
    End Sub
    Private Sub botonesEdicion()
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnEliminar.Enabled = True
        btnCancelar.Enabled = True
    End Sub
    Private Sub botonesNuevo()
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        inicializarControles()
        botonesNuevo()
        lueOrganizaciones.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If validarControles() Then
            asignacionCampos()
            If mantenedor.datosOrganizacion.organizacionID = 0 Then
            Else
                Try
                    'Viatico.ActualizarEncabezado()
                    'controlesAsociadosGuardarMemo()
                    GuardaLogoOrganizacion(mantenedor.datosOrganizacion.organizacionID)
                    ActualizarOrganizacion()
                    mantenedor.ActualizarOrganizacion()
                    imgLogoOrganizacion.Image = ObtenerLogoOrganizacion(lueOrganizaciones.EditValue)
                    imgLogoOrganizacion.Refresh()
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al actualizar encabezado de viático." & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub

    Private Sub ActualizarOrganizacion()
        asignacionCampos()
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_tabla_maestra_actualiza_organizacion", conn)
        Try
            Cursor = Cursors.AppStarting
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@organizacion_id", mantenedor.datosOrganizacion.organizacionID)
            command.Parameters.AddWithValue("@organizacion_alias", mantenedor.datosOrganizacion.organizacionAlias)
            command.Parameters.AddWithValue("@descripcion", mantenedor.datosOrganizacion.nombreFantasia)
            command.Parameters.AddWithValue("@rut_org", mantenedor.datosOrganizacion.rutEmpresa)
            command.Parameters.AddWithValue("@dv_org", mantenedor.datosOrganizacion.dvEmpresa)
            command.Parameters.AddWithValue("@razon_social", mantenedor.datosOrganizacion.razonSocial)
            command.Parameters.AddWithValue("@direccion", mantenedor.datosOrganizacion.direccion)
            command.Parameters.AddWithValue("@pais_id", mantenedor.datosOrganizacion.paisID)
            command.Parameters.AddWithValue("@region_id", mantenedor.datosOrganizacion.regionID)
            command.Parameters.AddWithValue("@comuna_id", mantenedor.datosOrganizacion.comunaID)
            command.Parameters.AddWithValue("@ape_pat_rep_leg", mantenedor.datosOrganizacion.apellidoPaternoRepLegal)
            command.Parameters.AddWithValue("@ape_mat_rep_leg", mantenedor.datosOrganizacion.apellidoMaternoRepLegal)
            command.Parameters.AddWithValue("@nombres_rep_legal", mantenedor.datosOrganizacion.nombresRepLegal)
            command.Parameters.AddWithValue("@rut_rep_legal", mantenedor.datosOrganizacion.rutRepLegal)
            command.Parameters.AddWithValue("@dv_rep_legal", mantenedor.datosOrganizacion.dvRepLegal)
            command.Parameters.AddWithValue("@cargo_rep_legal", mantenedor.datosOrganizacion.cargoRepLegal)
            command.Parameters.AddWithValue("@telefono", mantenedor.datosOrganizacion.telefono)
            command.Parameters.AddWithValue("@codigo_actividad_economica", mantenedor.datosOrganizacion.codigoActividadEconomica)
            command.Parameters.AddWithValue("@ape_pat_rep_legal_subrogante", mantenedor.datosOrganizacion.apellidoPaternoJefeSubrogante)
            command.Parameters.AddWithValue("@ape_mat_rep_legal_subrogante", mantenedor.datosOrganizacion.apellidoMaternoJefeSubrogante)
            command.Parameters.AddWithValue("@nombres_rep_legal_subrogante", mantenedor.datosOrganizacion.nombresJefeSubrogante)
            command.Parameters.AddWithValue("@rut_rep_legal_subrogante", mantenedor.datosOrganizacion.rutRepLegal)
            command.Parameters.AddWithValue("@dv_rep_legal_subrogante", mantenedor.datosOrganizacion.dvRepJefeSubrogante)
            command.Parameters.AddWithValue("@cargo_rep_legal_subrogante", mantenedor.datosOrganizacion.cargoJefeSubrogante)
            conn.Open()

            command.ExecuteNonQuery()

            Dim mydr As DataAccess.DSMantenedores.GEN_ORGANIZACIONRow = Nothing
            mantenedor = New Mantenedor(lueOrganizaciones.EditValue, mydr)
            MessageBox.Show("Organización """ + lueOrganizaciones.Text + """ ha sido actualizada correctamente", "¡Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub GuardaLogoOrganizacion(ByVal id_organizacion As Integer)
        If Not lueOrganizaciones.EditValue = Nothing Then
            If Not txtPathNuevoLogo.EditValue = Nothing Then
                Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
                Dim command As New SqlCommand("sp_tabla_maestra_guardar_logo_foto", conn)
                Try
                    Dim ms As New MemoryStream()
                    Dim fs As New FileStream(txtPathNuevoLogo.EditValue.ToString.Trim, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)

                    ms.SetLength(fs.Length)
                    fs.Read(ms.GetBuffer(), 0, fs.Length)

                    Dim arrImg() As Byte = ms.GetBuffer()
                    ms.Flush()
                    fs.Close()

                    Cursor = Cursors.AppStarting
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@organizacion_id", id_organizacion)
                    command.Parameters.AddWithValue("@foto_logo", arrImg)
                    conn.Open()

                    command.ExecuteNonQuery()

                    txtPathNuevoLogo.Text = String.Empty
                Catch ex As Exception
                    Throw New Exception(ex.ToString)
                Finally
                    conn.Dispose()
                    command.Dispose()
                    Cursor = Cursors.Default
                End Try

            End If
        Else
            MessageBox.Show("Debe seleccionar una Organización", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ObtenerLogoOrganizacion(ByVal id_organizacion As Integer) As Image
        If mantenedor.datosOrganizacion.organizacionID > 0 Then

            'sp_tabla_maestra_obtener_logo_organizacion
            Dim retornoImagen As Image
            Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
            Dim command As New SqlCommand("sp_tabla_maestra_obtener_logo_organizacion", conn)
            Try
                Cursor = Cursors.AppStarting
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@organizacion_id", id_organizacion)
                conn.Open()

                If Not TypeOf command.ExecuteScalar() Is DBNull Then
                    retornoImagen = Comun.Funciones.Imagenes.Bytes2Image(command.ExecuteScalar())
                Else
                    Dim bm As Bitmap = Nothing
                    bm = New Bitmap(117, 115, Imaging.PixelFormat.Format24bppRgb)
                    Dim graphicImage As Graphics = Graphics.FromImage(bm)
                    graphicImage.Clear(System.Drawing.Color.White)
                    graphicImage.DrawString("No Disponible", New Font("Arial", 8, FontStyle.Regular), SystemBrushes.ControlText, 17, 50)
                    retornoImagen = bm
                End If

                Return retornoImagen
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                conn.Dispose()
                command.Dispose()
                Cursor = Cursors.Default
            End Try

        End If
    End Function

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        ' DO NOTHING
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        inicializarControles()
        botonesInicio()
        lueOrganizaciones.Enabled = True
    End Sub
    Private Sub inicializarControles()
        txtAlias.Text = ""
        txtRazonSocial.Text = ""
        txtRutEmpresa.Text = ""
        txtDvEmpresa.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtCodigoActividadEconomica.Text = ""
        luePais.EditValue = -1
        lueRegion.EditValue = -1
        lueComuna.EditValue = -1
        txtApellidoPaternoRepLegal.Text = ""
        txtApellidoMaternoRepLegal.Text = ""
        txtNombresRepLegal.Text = ""
        txtRutRepresentanteLegal.Text = ""
        txtDvRepLegal.Text = ""
        txtCargoRepLegal.Text = ""
        txtApellidoPaternoJefeSubrogante.Text = ""
        txtApellidoMaternoJefeSubrogante.Text = ""
        txtNombresJefeSubrogante.Text = ""
        txtRutJefeSubrogante.Text = ""
        txtDvJefeSubrogante.Text = ""
        txtCargoJefeSubrogante.Text = ""
        txtNombreFantasia.Text = ""
    End Sub
    Private Function validarControles() As Boolean
        Dim respuesta As Boolean = True
        If txtAlias.Text = Nothing Then
            txtAlias.ErrorText = "Falta ingresar alias (código alfanumérico)"
            respuesta = False
        End If
        If txtNombreFantasia.Text = Nothing Then
            txtNombreFantasia.ErrorText = "Falta ingresar nombre fantasia de la empresa"
            respuesta = False
        End If
        If txtRazonSocial.Text = Nothing Then
            txtRazonSocial.ErrorText = "Falta ingresar razón social de la empresa"
            respuesta = False
        End If
        If txtRutEmpresa.Text = Nothing Or txtRutEmpresa.Text = 0 Then
            txtRutEmpresa.ErrorText = "Falta ingresar rut de la empresa"
            respuesta = False
        End If
        If txtDvEmpresa.Text = Nothing Then
            txtDvEmpresa.ErrorText = "Falta ingresar digito verificador de la empresa"
            respuesta = False
        End If
        If txtDireccion.Text = Nothing Then
            txtDireccion.ErrorText = "Falta ingresar dirección comercial de la empresa"
            respuesta = False
        End If
        If txtTelefono.Text = Nothing Then
            txtTelefono.ErrorText = "Falta ingresar telefóno de la empresa"
            respuesta = False
        End If
        If txtCodigoActividadEconomica.Text = Nothing Then
            txtCodigoActividadEconomica.ErrorText = "Falta ingresar código actividad económica de la empresa (según codificación SII)"
            respuesta = False
        End If
        If luePais.EditValue = Nothing Or luePais.EditValue < 0 Then
            luePais.ErrorText = "Falta ingresar país"
            respuesta = False
        End If
        If lueRegion.EditValue = Nothing Or lueRegion.EditValue < 0 Then
            lueRegion.ErrorText = "Falta ingresar región"
            respuesta = False
        End If
        If lueComuna.EditValue = Nothing Or lueComuna.EditValue < 0 Then
            lueComuna.ErrorText = "Falta ingresar comuna"
            respuesta = False
        End If
        If txtApellidoPaternoRepLegal.Text = Nothing Then
            txtApellidoPaternoRepLegal.ErrorText = "Falta ingresar apellido paterno representante legal"
            respuesta = False
        End If
        If txtApellidoMaternoRepLegal.Text = Nothing Then
            txtApellidoMaternoRepLegal.ErrorText = "Falta ingresar apellido materno representante legal"
            respuesta = False
        End If
        If txtNombresRepLegal.Text = Nothing Then
            txtNombresRepLegal.ErrorText = "Falta ingresar nombres del representante legal"
            respuesta = False
        End If
        If txtRutRepresentanteLegal.Text = Nothing Or txtRutRepresentanteLegal.Text = 0 Then
            txtRutRepresentanteLegal.ErrorText = "Falta ingresar rut del representante legal"
            respuesta = False
        End If
        If txtDvRepLegal.Text = Nothing Then
            txtDvRepLegal.ErrorText = "Falta ingresar digito verificador del representante legal"
            respuesta = False
        End If
        If txtCargoRepLegal.Text = Nothing Then
            txtCargoRepLegal.ErrorText = "Falta ingresar cargo del representante legal"
            respuesta = False
        End If
        If txtApellidoPaternoJefeSubrogante.Text = Nothing Then
            txtApellidoPaternoJefeSubrogante.ErrorText = "Falta ingresar apellido jefe subrogante"
            respuesta = False
        End If
        If txtApellidoMaternoJefeSubrogante.Text = Nothing Then
            txtApellidoMaternoJefeSubrogante.ErrorText = "Falta ingresar apellido materno jefe subrogante"
            respuesta = False
        End If
        If txtNombresJefeSubrogante.Text = Nothing Then
            txtNombresJefeSubrogante.ErrorText = "Falta ingresar nombres del jefe subrogante"
            respuesta = False
        End If
        If txtRutJefeSubrogante.Text = Nothing Or txtRutJefeSubrogante.Text = 0 Then
            txtRutJefeSubrogante.ErrorText = "Falta ingresar rut del jefe subrogante"
            respuesta = False
        End If
        If txtDvJefeSubrogante.Text = Nothing Then
            txtDvJefeSubrogante.ErrorText = "Falta ingresar digito verificador del jefe subrogante"
            respuesta = False
        End If
        If txtCargoJefeSubrogante.Text = Nothing Then
            txtCargoJefeSubrogante.ErrorText = "Falta ingresar cargo del jefe subrogante"
            respuesta = False
        End If
        Return respuesta
    End Function
    Private Sub asignacionCampos()
        mantenedor.datosOrganizacion.organizacionAlias = txtAlias.Text
        mantenedor.datosOrganizacion.razonSocial = txtRazonSocial.Text
        mantenedor.datosOrganizacion.rutEmpresa = txtRutEmpresa.Text
        mantenedor.datosOrganizacion.dvEmpresa = txtDvEmpresa.Text
        mantenedor.datosOrganizacion.direccion = txtDireccion.Text
        mantenedor.datosOrganizacion.telefono = txtTelefono.Text
        mantenedor.datosOrganizacion.codigoActividadEconomica = txtCodigoActividadEconomica.Text
        mantenedor.datosOrganizacion.paisID = luePais.EditValue
        mantenedor.datosOrganizacion.regionID = lueRegion.EditValue
        mantenedor.datosOrganizacion.comunaID = lueComuna.EditValue
        mantenedor.datosOrganizacion.apellidoPaternoRepLegal = txtApellidoPaternoRepLegal.Text
        mantenedor.datosOrganizacion.apellidoMaternoRepLegal = txtApellidoMaternoRepLegal.Text
        mantenedor.datosOrganizacion.nombresRepLegal = txtNombresRepLegal.Text
        mantenedor.datosOrganizacion.rutRepLegal = txtRutRepresentanteLegal.Text
        mantenedor.datosOrganizacion.dvRepLegal = txtDvRepLegal.Text
        mantenedor.datosOrganizacion.cargoRepLegal = txtCargoRepLegal.Text
        mantenedor.datosOrganizacion.apellidoPaternoJefeSubrogante = txtApellidoPaternoJefeSubrogante.Text
        mantenedor.datosOrganizacion.apellidoMaternoJefeSubrogante = txtApellidoMaternoJefeSubrogante.Text
        mantenedor.datosOrganizacion.nombresJefeSubrogante = txtNombresJefeSubrogante.Text
        mantenedor.datosOrganizacion.rutRepJefeSubrogante = txtRutJefeSubrogante.Text
        mantenedor.datosOrganizacion.dvRepJefeSubrogante = txtDvJefeSubrogante.Text
        mantenedor.datosOrganizacion.cargoJefeSubrogante = txtCargoJefeSubrogante.Text
        mantenedor.datosOrganizacion.nombreFantasia = txtNombreFantasia.Text.Trim
    End Sub

    Private Sub btnExaminarNuevoLogo_Click(sender As System.Object, e As System.EventArgs) Handles btnExaminarNuevoLogo.Click
        Try
            Dim examinar As New OpenFileDialog
            examinar.Title = "Seleccione el logo de la Organización"
            If examinar.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtPathNuevoLogo.Text = examinar.FileName
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
