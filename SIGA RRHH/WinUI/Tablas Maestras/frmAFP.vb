Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo

Public Class frmAFP
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
    Friend WithEvents gdcAFP As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetelleAFP As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DET_AFP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AFP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_VIGENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ESTADO_REGISTRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TASA_DESCUENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCUENTO_LEY_19882 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TASA_EX_CAJA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gpcAFP As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dvDescripcion As System.Data.DataView
    Friend WithEvents dvPrevisional As System.Data.DataView
    Friend WithEvents dvComuna As System.Data.DataView
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRUT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDV As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCaja As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPREVIRED As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueDescripcion2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnGrabar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lueComuna2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lueSistPrevisional As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TASA_SEGURO_INVALIDEZ_SOBREVIVENCIA As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gdcAFP = New DevExpress.XtraGrid.GridControl
        Me.gdvDetelleAFP = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DET_AFP_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AFP_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FECHA_VIGENCIA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ESTADO_REGISTRO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TASA_DESCUENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TASA_SEGURO_INVALIDEZ_SOBREVIVENCIA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DESCUENTO_LEY_19882 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TASA_EX_CAJA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gpcAFP = New DevExpress.XtraEditors.GroupControl
        Me.lueSistPrevisional = New DevExpress.XtraEditors.LookUpEdit
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit
        Me.lueComuna2 = New DevExpress.XtraEditors.LookUpEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.btnGrabar = New DevExpress.XtraEditors.SimpleButton
        Me.lueDescripcion2 = New DevExpress.XtraEditors.LookUpEdit
        Me.txtPREVIRED = New DevExpress.XtraEditors.TextEdit
        Me.txtCaja = New DevExpress.XtraEditors.TextEdit
        Me.txtDireccion = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtDV = New DevExpress.XtraEditors.TextEdit
        Me.txtRUT = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtID = New DevExpress.XtraEditors.TextEdit
        Me.dvDescripcion = New System.Data.DataView
        Me.dvPrevisional = New System.Data.DataView
        Me.dvComuna = New System.Data.DataView
        CType(Me.gdcAFP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetelleAFP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcAFP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcAFP.SuspendLayout()
        CType(Me.lueSistPrevisional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueComuna2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.lueDescripcion2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPREVIRED.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRUT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPrevisional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvComuna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcAFP
        '
        Me.gdcAFP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'gdcAFP.EmbeddedNavigator
        '
        Me.gdcAFP.EmbeddedNavigator.Name = ""
        Me.gdcAFP.Location = New System.Drawing.Point(24, 264)
        Me.gdcAFP.MainView = Me.gdvDetelleAFP
        Me.gdcAFP.Name = "gdcAFP"
        Me.gdcAFP.Size = New System.Drawing.Size(808, 232)
        Me.gdcAFP.TabIndex = 0
        Me.gdcAFP.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetelleAFP})
        '
        'gdvDetelleAFP
        '
        Me.gdvDetelleAFP.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.DET_AFP_ID, Me.AFP_ID, Me.FECHA_VIGENCIA, Me.ESTADO_REGISTRO, Me.TASA_DESCUENTO, Me.TASA_SEGURO_INVALIDEZ_SOBREVIVENCIA, Me.DESCUENTO_LEY_19882, Me.TASA_EX_CAJA})
        Me.gdvDetelleAFP.GridControl = Me.gdcAFP
        Me.gdvDetelleAFP.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvDetelleAFP.Name = "gdvDetelleAFP"
        Me.gdvDetelleAFP.NewItemRowText = "Nuevo Registro"
        Me.gdvDetelleAFP.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'DET_AFP_ID
        '
        Me.DET_AFP_ID.Caption = "DET-AFP-ID"
        Me.DET_AFP_ID.FieldName = "DET_AFP_ID"
        Me.DET_AFP_ID.Name = "DET_AFP_ID"
        '
        'AFP_ID
        '
        Me.AFP_ID.Caption = "ID AFP"
        Me.AFP_ID.FieldName = "AFP_ID"
        Me.AFP_ID.Name = "AFP_ID"
        Me.AFP_ID.OptionsColumn.ReadOnly = True
        Me.AFP_ID.Width = 77
        '
        'FECHA_VIGENCIA
        '
        Me.FECHA_VIGENCIA.Caption = "Fecha Vigencia"
        Me.FECHA_VIGENCIA.FieldName = "FECHA_VIGENCIA"
        Me.FECHA_VIGENCIA.Name = "FECHA_VIGENCIA"
        Me.FECHA_VIGENCIA.Visible = True
        Me.FECHA_VIGENCIA.VisibleIndex = 0
        Me.FECHA_VIGENCIA.Width = 117
        '
        'ESTADO_REGISTRO
        '
        Me.ESTADO_REGISTRO.Caption = "Estado Registro"
        Me.ESTADO_REGISTRO.FieldName = "ESTADO_REGISTRO"
        Me.ESTADO_REGISTRO.Name = "ESTADO_REGISTRO"
        Me.ESTADO_REGISTRO.Visible = True
        Me.ESTADO_REGISTRO.VisibleIndex = 1
        Me.ESTADO_REGISTRO.Width = 124
        '
        'TASA_DESCUENTO
        '
        Me.TASA_DESCUENTO.Caption = "%Tasa de Descuento"
        Me.TASA_DESCUENTO.FieldName = "TASA_DESCUENTO"
        Me.TASA_DESCUENTO.Name = "TASA_DESCUENTO"
        Me.TASA_DESCUENTO.Visible = True
        Me.TASA_DESCUENTO.VisibleIndex = 2
        Me.TASA_DESCUENTO.Width = 154
        '
        'TASA_SEGURO_INVALIDEZ_SOBREVIVENCIA
        '
        Me.TASA_SEGURO_INVALIDEZ_SOBREVIVENCIA.Caption = "%Tasa SIS"
        Me.TASA_SEGURO_INVALIDEZ_SOBREVIVENCIA.FieldName = "TASA_SEGURO_INVALIDEZ_SOBREVIVENCIA"
        Me.TASA_SEGURO_INVALIDEZ_SOBREVIVENCIA.Name = "TASA_SEGURO_INVALIDEZ_SOBREVIVENCIA"
        Me.TASA_SEGURO_INVALIDEZ_SOBREVIVENCIA.Visible = True
        Me.TASA_SEGURO_INVALIDEZ_SOBREVIVENCIA.VisibleIndex = 3
        Me.TASA_SEGURO_INVALIDEZ_SOBREVIVENCIA.Width = 139
        '
        'DESCUENTO_LEY_19882
        '
        Me.DESCUENTO_LEY_19882.Caption = "%Descuento Ley 19882"
        Me.DESCUENTO_LEY_19882.FieldName = "DESCUENTO_LEY_19882"
        Me.DESCUENTO_LEY_19882.Name = "DESCUENTO_LEY_19882"
        Me.DESCUENTO_LEY_19882.Visible = True
        Me.DESCUENTO_LEY_19882.VisibleIndex = 4
        Me.DESCUENTO_LEY_19882.Width = 158
        '
        'TASA_EX_CAJA
        '
        Me.TASA_EX_CAJA.Caption = "%Tasa ex caja"
        Me.TASA_EX_CAJA.FieldName = "TASA_EX_CAJA"
        Me.TASA_EX_CAJA.Name = "TASA_EX_CAJA"
        Me.TASA_EX_CAJA.Visible = True
        Me.TASA_EX_CAJA.VisibleIndex = 5
        Me.TASA_EX_CAJA.Width = 396
        '
        'gpcAFP
        '
        Me.gpcAFP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcAFP.Controls.Add(Me.lueSistPrevisional)
        Me.gpcAFP.Controls.Add(Me.txtDescripcion)
        Me.gpcAFP.Controls.Add(Me.lueComuna2)
        Me.gpcAFP.Controls.Add(Me.PanelControl1)
        Me.gpcAFP.Controls.Add(Me.lueDescripcion2)
        Me.gpcAFP.Controls.Add(Me.txtPREVIRED)
        Me.gpcAFP.Controls.Add(Me.txtCaja)
        Me.gpcAFP.Controls.Add(Me.txtDireccion)
        Me.gpcAFP.Controls.Add(Me.LabelControl9)
        Me.gpcAFP.Controls.Add(Me.LabelControl8)
        Me.gpcAFP.Controls.Add(Me.LabelControl7)
        Me.gpcAFP.Controls.Add(Me.LabelControl6)
        Me.gpcAFP.Controls.Add(Me.LabelControl5)
        Me.gpcAFP.Controls.Add(Me.txtDV)
        Me.gpcAFP.Controls.Add(Me.txtRUT)
        Me.gpcAFP.Controls.Add(Me.LabelControl4)
        Me.gpcAFP.Controls.Add(Me.LabelControl3)
        Me.gpcAFP.Controls.Add(Me.LabelControl2)
        Me.gpcAFP.Controls.Add(Me.LabelControl1)
        Me.gpcAFP.Controls.Add(Me.txtID)
        Me.gpcAFP.Location = New System.Drawing.Point(24, 16)
        Me.gpcAFP.Name = "gpcAFP"
        Me.gpcAFP.Size = New System.Drawing.Size(808, 240)
        Me.gpcAFP.TabIndex = 1
        Me.gpcAFP.Text = "Encabezado AFP"
        '
        'lueSistPrevisional
        '
        Me.lueSistPrevisional.Location = New System.Drawing.Point(200, 136)
        Me.lueSistPrevisional.Name = "lueSistPrevisional"
        '
        'lueSistPrevisional.Properties
        '
        Me.lueSistPrevisional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueSistPrevisional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name2")})
        Me.lueSistPrevisional.Properties.NullText = ""
        Me.lueSistPrevisional.Size = New System.Drawing.Size(120, 20)
        Me.lueSistPrevisional.TabIndex = 24
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(200, 64)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(200, 20)
        Me.txtDescripcion.TabIndex = 23
        '
        'lueComuna2
        '
        Me.lueComuna2.Location = New System.Drawing.Point(586, 64)
        Me.lueComuna2.Name = "lueComuna2"
        '
        'lueComuna2.Properties
        '
        Me.lueComuna2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueComuna2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name2")})
        Me.lueComuna2.Properties.NullText = ""
        Me.lueComuna2.Size = New System.Drawing.Size(200, 20)
        Me.lueComuna2.TabIndex = 22
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnCancelar)
        Me.PanelControl1.Controls.Add(Me.btnNuevo)
        Me.PanelControl1.Controls.Add(Me.btnGrabar)
        Me.PanelControl1.Location = New System.Drawing.Point(288, 184)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(312, 40)
        Me.PanelControl1.TabIndex = 21
        Me.PanelControl1.Text = "PanelControl1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(120, 8)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(216, 8)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(24, 8)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.TabIndex = 0
        Me.btnGrabar.Text = "Guardar"
        '
        'lueDescripcion2
        '
        Me.lueDescripcion2.Location = New System.Drawing.Point(200, 64)
        Me.lueDescripcion2.Name = "lueDescripcion2"
        '
        'lueDescripcion2.Properties
        '
        Me.lueDescripcion2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDescripcion2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name2")})
        Me.lueDescripcion2.Properties.NullText = ""
        Me.lueDescripcion2.Size = New System.Drawing.Size(200, 20)
        Me.lueDescripcion2.TabIndex = 19
        '
        'txtPREVIRED
        '
        Me.txtPREVIRED.Location = New System.Drawing.Point(584, 128)
        Me.txtPREVIRED.Name = "txtPREVIRED"
        Me.txtPREVIRED.Size = New System.Drawing.Size(48, 20)
        Me.txtPREVIRED.TabIndex = 17
        '
        'txtCaja
        '
        Me.txtCaja.Location = New System.Drawing.Point(584, 96)
        Me.txtCaja.Name = "txtCaja"
        Me.txtCaja.Size = New System.Drawing.Size(48, 20)
        Me.txtCaja.TabIndex = 16
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(584, 32)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(208, 20)
        Me.txtDireccion.TabIndex = 14
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(464, 136)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(104, 14)
        Me.LabelControl9.TabIndex = 13
        Me.LabelControl9.Text = "Código PREVIRED"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(464, 104)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(88, 14)
        Me.LabelControl8.TabIndex = 12
        Me.LabelControl8.Text = "Código Ex Caja"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(464, 70)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(88, 14)
        Me.LabelControl7.TabIndex = 11
        Me.LabelControl7.Text = "Comuna"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(464, 40)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(88, 14)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Dirección"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(267, 107)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(8, 14)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = " - "
        '
        'txtDV
        '
        Me.txtDV.Location = New System.Drawing.Point(281, 104)
        Me.txtDV.Name = "txtDV"
        Me.txtDV.Size = New System.Drawing.Size(24, 20)
        Me.txtDV.TabIndex = 8
        '
        'txtRUT
        '
        Me.txtRUT.Location = New System.Drawing.Point(200, 104)
        Me.txtRUT.Name = "txtRUT"
        Me.txtRUT.Size = New System.Drawing.Size(64, 20)
        Me.txtRUT.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(61, 106)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(112, 14)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "RUT"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(58, 136)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(134, 14)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "ID Sistema Previsional"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(58, 72)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(88, 14)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Descripción"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(58, 36)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(88, 14)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "AFP ID"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(200, 32)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(48, 20)
        Me.txtID.TabIndex = 0
        '
        'frmAFP
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 517)
        Me.Controls.Add(Me.gpcAFP)
        Me.Controls.Add(Me.gdcAFP)
        Me.Name = "frmAFP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de AFP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcAFP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetelleAFP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcAFP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcAFP.ResumeLayout(False)
        CType(Me.lueSistPrevisional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueComuna2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.lueDescripcion2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPREVIRED.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRUT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvPrevisional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvComuna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim AFP As Mantenedor
    Dim Mantenedor As Mantenedor

    Private Sub frmAFP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AFP = New Mantenedor
        gdcAFP.DataSource = AFP.recuperarDetalleAFP(lueDescripcion2.EditValue)

        'Carga DESCRIPCION AFP
        Comun.Utiles.fillLookUpEdit(lueDescripcion2, _
                            (Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_DESCRIPCION_AFP, _
                            Comun.Tablas.RH_REM_AFP, "DESCRIPCION", "AFP_ID", _
                            ArgoConfiguracion.ConnectionString)), "DESCRIPCION", "AFP_ID")


        'Carga Sistema Previsional
        Comun.Utiles.fillLookUpEdit(lueSistPrevisional, _
                            (Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_SISTEMAPREVISIONAL, _
                            Comun.Tablas.RH_REM_SISTEMA_PREVISIONAL, "DESCRIPCION", "SISTEMA_PREV_ID", _
                            ArgoConfiguracion.ConnectionString)), "DESCRIPCION", "SISTEMA_PREV_ID")


        'Carga combobox COMUNA.
        Comun.Utiles.fillLookUpEdit(lueComuna2, _
                          (Utiles.fillDataview(Comun.SQL.INSTRUCCIONES_SQL.SELECT_COMUNAS, _
                          Comun.Tablas.GEN_COMUNA, "DESCRIPCION", "COMUNA_ID", _
                          ArgoConfiguracion.ConnectionString)), "DESCRIPCION", "COMUNA_ID")



        txtDescripcion.Visible = False

        btnGrabar.Enabled = False
        btnCancelar.Enabled = False



    End Sub



    Private Sub gdvDetelleAFP_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvDetelleAFP.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gdvDetelleAFP_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvDetelleAFP.RowUpdated
        If AFP.actualizarDetalleAFP Then
            gdcAFP.Refresh()
            repositorio.RefreshDatos("AFP")
        End If
    End Sub

    Private Sub gdvDetelleAFP_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvDetelleAFP.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                Try
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                    view.DeleteRow(view.FocusedRowHandle)
                    AFP.actualizarDetalleAFP()
                    gdcAFP.Refresh()
                    MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al intentar eliminar el registro " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If

            gdcAFP.DataSource = AFP.recuperarDetalleAFP(lueDescripcion2.EditValue)
        End If
    End Sub

    Private Sub gdvDetelleAFP_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvDetelleAFP.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        view.SetRowCellValue(e.RowHandle, "DET_AFP_ID", 0)
        view.SetRowCellValue(e.RowHandle, "AFP_ID", lueDescripcion2.EditValue)
        view.SetRowCellValue(e.RowHandle, "ESTADO_REGISTRO", 1)

    End Sub



    Private Sub lueDescripcion2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueDescripcion2.EditValueChanged
        If lueDescripcion2.EditValue <> Nothing Then
            gdcAFP.DataSource = AFP.recuperarDetalleAFP(lueDescripcion2.EditValue)
            Dim EncabezadoAFP_DR As DataRow

            'Se obtienen los datos del registro insertado o consultado.
            EncabezadoAFP_DR = AFP.recuperarEncabezadoAFP(lueDescripcion2.EditValue)


            If Not EncabezadoAFP_DR Is Nothing Then
                With Me
                    .txtID.Text = CType(EncabezadoAFP_DR("AFP_ID"), Integer)
                    .txtRUT.Text = CType(EncabezadoAFP_DR("AFP_RUT"), Integer)
                    .txtDV.Text = CType(EncabezadoAFP_DR("AFP_DV"), String)
                    .txtDireccion.Text = CType(EncabezadoAFP_DR("DIRECCION"), String)
                    .txtCaja.Text = CType(EncabezadoAFP_DR("CODIGO_EXCAJA"), String)
                    .txtPREVIRED.Text = CType(EncabezadoAFP_DR("CODIGO_PREVIRED"), String)
                    .lueComuna2.EditValue = CType(EncabezadoAFP_DR("COMUNA_ID"), Integer)
                    .lueSistPrevisional.EditValue = CType(EncabezadoAFP_DR("SISTEMA_PREV_ID"), Integer)

                End With

            End If

        End If



    End Sub
    ''' Pasa valores del formulario a la capa de la regla de negocios (BisinessRules/Mantenedor).

    Private Sub asignacionCampos()
        Mantenedor.datosOrganizacionafp.descripcion = txtDescripcion.EditValue
        Mantenedor.datosOrganizacionafp.afp_rut = txtRUT.EditValue
        Mantenedor.datosOrganizacionafp.afp_dv = txtDV.EditValue
        Mantenedor.datosOrganizacionafp.SISTEMA_PREV_ID = lueSistPrevisional.EditValue
        Mantenedor.datosOrganizacionafp.comuna = lueComuna2.EditValue
        Mantenedor.datosOrganizacionafp.direccion = txtDireccion.EditValue
        Mantenedor.datosOrganizacionafp.caja = txtCaja.EditValue
        Mantenedor.datosOrganizacionafp.previred = txtPREVIRED.EditValue
    End Sub

    ''' Valida el ingreso de datos del encabezado del formulario
    Private Function validarDatosEncabezado() As Boolean
        Dim respuesta As Boolean = True
        If CType(txtDescripcion.Text, String) = "" Then
            txtDescripcion.ErrorText = "Falta ingresar Descripción"
            respuesta = False
        End If

        If txtRUT.Text <> Nothing And txtRUT.Text = "" Then
            txtRUT.ErrorText = "Debe ingresar el RUT"
            respuesta = False
        End If

        If CType(txtDV.Text, String) = "" Then
            txtDV.ErrorText = "Debe ingresar el dígito verificador del RUT"
            respuesta = False
        End If

        If CType(txtDireccion.Text, String) = "" Then
            txtDireccion.ErrorText = "Debe ingresar el RUT"
            respuesta = False
        End If

        If lueSistPrevisional.EditValue Is Nothing Then
            lueSistPrevisional.ErrorText = "Debe ingresar Sistema Previsional"
            respuesta = False
        End If

        If lueComuna2.EditValue Is Nothing Then
            lueComuna2.ErrorText = "Debe ingresar Comuna"
            respuesta = False
        End If

        Return respuesta
    End Function

    ''' Deja los controles en blanco para ingresar un nuevo registro

    Private Sub inicializarControles()
        With Me
            btnGrabar.Enabled = True
            btnCancelar.Enabled = True
            lueDescripcion2.Visible = True
            txtDescripcion.Visible = True

            lueSistPrevisional.Visible = True
            .txtID.Text = ""
            .txtRUT.Text = ""
            .txtDV.Text = ""
            .txtDireccion.Text = ""
            .txtCaja.Text = ""
            .txtPREVIRED.Text = ""
            .txtDescripcion.Text = ""
            lueSistPrevisional.EditValue = -1
            lueDescripcion2.EditValue = -1
            lueComuna2.EditValue = -1
            gdcAFP.DataSource = Nothing
            gdcAFP.Refresh()
        End With

    End Sub

    ''' Evento clic del boton nuevo

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        inicializarControles()
        Mantenedor = New Mantenedor
    End Sub

    ''' Evento clic del botón guardar (encabezado)
    ''' Guarda o actualiza un registro
    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        If validarDatosEncabezado() Then
            asignacionCampos()
            If Mantenedor.datosOrganizacionafp.afp_id = 0 Then
                Try
                    Mantenedor.datosOrganizacionafp.afp_id = Mantenedor.CrearEncabezadoAFP()
                    txtID.Text = Mantenedor.datosOrganizacionafp.afp_id
                    gdcAFP.DataSource = AFP.recuperarDetalleAFP(CType(txtID.Text, Integer))
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al crear el encabezado." & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
                End Try
            Else
                Try
                    Mantenedor.ActualizarEncabezadoAFP()
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al actualizar encabezado." & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End If

    End Sub
End Class

