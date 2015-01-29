Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Reportes
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports System.IO
Imports Microsoft.Office.Interop
Imports word = Microsoft.Office.Interop.Word

Public Class frmViatico
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
    Friend WithEvents gpcInformacionGeneral As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtNumeroMemo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dedFechaMemorando As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtMotivoViatico As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumeroResolucion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dedFechaResolucion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblNroMemorandum As System.Windows.Forms.Label
    Friend WithEvents lblFechaMemorandum As System.Windows.Forms.Label
    Friend WithEvents lblMotivoViatico As System.Windows.Forms.Label
    Friend WithEvents lblNroResolucion As System.Windows.Forms.Label
    Friend WithEvents lblFecharesolucion As System.Windows.Forms.Label
    Friend WithEvents txtNombreEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gleEmpleado As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtGrado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblIngresoInstitucion As System.Windows.Forms.Label
    Friend WithEvents lblGrado As System.Windows.Forms.Label
    Friend WithEvents txtCalidadJuridica As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaIngresoInstitucion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCalidadJuridica As System.Windows.Forms.Label
    Friend WithEvents lblRutEmplado As System.Windows.Forms.Label
    Friend WithEvents gpcRegistrodelViatico As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gpcDatosEmpleado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gpcDestino As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdgDestino As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lueComuna As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents luePais As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueRegion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPais As System.Windows.Forms.Label
    Friend WithEvents lblComuna As System.Windows.Forms.Label
    Friend WithEvents lblRegion As System.Windows.Forms.Label
    Friend WithEvents gpcDatosdelViatico As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdgEstado As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents dedFechaTermino As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDiasSolicitados As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents lblCantidadDias As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents lblFechaTermino As System.Windows.Forms.Label
    Friend WithEvents txtPorcentajeaPagar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMonto100Porciento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMonto100Porciento As System.Windows.Forms.Label
    Friend WithEvents lblPagar As System.Windows.Forms.Label
    Friend WithEvents txtMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMontoaPagar As System.Windows.Forms.Label
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnCancelarMemorandum As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminarMemorandum As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevoMemorandum As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardarMemorandum As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gpcBotonesEncabezado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancelarDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardarDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminaDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevoDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gpcBotonesDetalle As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gdcViatico As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalleViatico As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents fieldVIATICO_DETALLE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldEMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldNOMBRE_EMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCALIDAD_JURIDICA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldGRADO_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCANTIDAD_DIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldFECHA_INICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldFECHA_TERMINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldPAIS_DESTINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldREGION_DESTINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCOMUNA_DESTINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldSTR_ESTADO_VIATICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldMONTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMontoViaticoRepositorio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents fieldDESTINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldPAIS_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldREGION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCOMUNA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldESTADO_VIATICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueNumeroMemorandum As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents fieldFECHA_DOCUMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueNumeroResolucion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents fieldNUMERO_DOCUMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dedFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnEmiteResolucion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents prsViatico As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents lueDepartamento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblDepartamento As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents luePeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtPatenteVehiculo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gdcResolucion As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvResolucion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombreDocumentoWord As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnBuscarDocumentoWord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colVIATICO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNRO_MEMORANDUM_INTERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_MEMORANDUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAÑO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldPATENTE_VEHICULO As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViatico))
        Me.gpcInformacionGeneral = New DevExpress.XtraEditors.GroupControl()
        Me.txtNombreDocumentoWord = New DevExpress.XtraEditors.TextEdit()
        Me.btnBuscarDocumentoWord = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.luePeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.lblDepartamento = New DevExpress.XtraEditors.LabelControl()
        Me.lueDepartamento = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueNumeroResolucion = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueNumeroMemorandum = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblFecharesolucion = New System.Windows.Forms.Label()
        Me.dedFechaResolucion = New DevExpress.XtraEditors.DateEdit()
        Me.lblNroResolucion = New System.Windows.Forms.Label()
        Me.txtNumeroResolucion = New DevExpress.XtraEditors.TextEdit()
        Me.lblMotivoViatico = New System.Windows.Forms.Label()
        Me.txtMotivoViatico = New DevExpress.XtraEditors.TextEdit()
        Me.lblFechaMemorandum = New System.Windows.Forms.Label()
        Me.dedFechaMemorando = New DevExpress.XtraEditors.DateEdit()
        Me.lblNroMemorandum = New System.Windows.Forms.Label()
        Me.txtNumeroMemo = New DevExpress.XtraEditors.TextEdit()
        Me.btnCancelarMemorandum = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardarMemorandum = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminarMemorandum = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevoMemorandum = New DevExpress.XtraEditors.SimpleButton()
        Me.gpcRegistrodelViatico = New DevExpress.XtraEditors.GroupControl()
        Me.gpcDestino = New DevExpress.XtraEditors.GroupControl()
        Me.lueComuna = New DevExpress.XtraEditors.LookUpEdit()
        Me.luePais = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.lblComuna = New System.Windows.Forms.Label()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.lueRegion = New DevExpress.XtraEditors.LookUpEdit()
        Me.rdgDestino = New DevExpress.XtraEditors.RadioGroup()
        Me.gpcDatosEmpleado = New DevExpress.XtraEditors.GroupControl()
        Me.txtNombreEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.lblRutEmplado = New System.Windows.Forms.Label()
        Me.gleEmpleado = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtCalidadJuridica = New DevExpress.XtraEditors.TextEdit()
        Me.lblCalidadJuridica = New System.Windows.Forms.Label()
        Me.lblIngresoInstitucion = New System.Windows.Forms.Label()
        Me.txtFechaIngresoInstitucion = New DevExpress.XtraEditors.TextEdit()
        Me.lblGrado = New System.Windows.Forms.Label()
        Me.txtGrado = New DevExpress.XtraEditors.TextEdit()
        Me.gpcDatosdelViatico = New DevExpress.XtraEditors.GroupControl()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtPatenteVehiculo = New DevExpress.XtraEditors.TextEdit()
        Me.dedFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.txtMonto = New DevExpress.XtraEditors.TextEdit()
        Me.lblMontoaPagar = New System.Windows.Forms.Label()
        Me.txtPorcentajeaPagar = New DevExpress.XtraEditors.TextEdit()
        Me.lblPagar = New System.Windows.Forms.Label()
        Me.txtMonto100Porciento = New DevExpress.XtraEditors.TextEdit()
        Me.lblMonto100Porciento = New System.Windows.Forms.Label()
        Me.rdgEstado = New DevExpress.XtraEditors.RadioGroup()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblCantidadDias = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblFechaTermino = New System.Windows.Forms.Label()
        Me.dedFechaTermino = New DevExpress.XtraEditors.DateEdit()
        Me.txtDiasSolicitados = New DevExpress.XtraEditors.SpinEdit()
        Me.btnCancelarDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardarDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminaDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevoDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.gdcViatico = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleViatico = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.fieldVIATICO_DETALLE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldEMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldNOMBRE_EMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldCALIDAD_JURIDICA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldGRADO_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldCANTIDAD_DIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldFECHA_INICIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldFECHA_TERMINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldMONTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMontoViaticoRepositorio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.fieldPAIS_DESTINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldREGION_DESTINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldCOMUNA_DESTINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldSTR_ESTADO_VIATICO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldDESTINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldPAIS_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldREGION_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldCOMUNA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldESTADO_VIATICO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldNUMERO_DOCUMENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldFECHA_DOCUMENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fieldPATENTE_VEHICULO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gpcBotonesEncabezado = New DevExpress.XtraEditors.GroupControl()
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEmiteResolucion = New DevExpress.XtraEditors.SimpleButton()
        Me.gpcBotonesDetalle = New DevExpress.XtraEditors.GroupControl()
        Me.prsViatico = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.gdcResolucion = New DevExpress.XtraGrid.GridControl()
        Me.gdvResolucion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colVIATICO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNRO_MEMORANDUM_INTERNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_MEMORANDUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAÑO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMES = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gpcInformacionGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcInformacionGeneral.SuspendLayout()
        CType(Me.txtNombreDocumentoWord.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueNumeroResolucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueNumeroMemorandum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaResolucion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaResolucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroResolucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMotivoViatico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaMemorando.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaMemorando.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroMemo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcRegistrodelViatico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcRegistrodelViatico.SuspendLayout()
        CType(Me.gpcDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDestino.SuspendLayout()
        CType(Me.lueComuna.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueRegion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDatosEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDatosEmpleado.SuspendLayout()
        CType(Me.txtNombreEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCalidadJuridica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIngresoInstitucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGrado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcDatosdelViatico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDatosdelViatico.SuspendLayout()
        CType(Me.txtPatenteVehiculo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentajeaPagar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto100Porciento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaTermino.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaTermino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiasSolicitados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcViatico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleViatico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoViaticoRepositorio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcBotonesEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBotonesEncabezado.SuspendLayout()
        CType(Me.gpcBotonesDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBotonesDetalle.SuspendLayout()
        CType(Me.prsViatico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcResolucion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvResolucion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcInformacionGeneral
        '
        Me.gpcInformacionGeneral.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcInformacionGeneral.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcInformacionGeneral.AppearanceCaption.Options.UseFont = True
        Me.gpcInformacionGeneral.Controls.Add(Me.txtNombreDocumentoWord)
        Me.gpcInformacionGeneral.Controls.Add(Me.btnBuscarDocumentoWord)
        Me.gpcInformacionGeneral.Controls.Add(Me.Label1)
        Me.gpcInformacionGeneral.Controls.Add(Me.luePeriodo)
        Me.gpcInformacionGeneral.Controls.Add(Me.lblPeriodo)
        Me.gpcInformacionGeneral.Controls.Add(Me.lblDepartamento)
        Me.gpcInformacionGeneral.Controls.Add(Me.lueDepartamento)
        Me.gpcInformacionGeneral.Controls.Add(Me.lueNumeroResolucion)
        Me.gpcInformacionGeneral.Controls.Add(Me.lueNumeroMemorandum)
        Me.gpcInformacionGeneral.Controls.Add(Me.lblFecharesolucion)
        Me.gpcInformacionGeneral.Controls.Add(Me.dedFechaResolucion)
        Me.gpcInformacionGeneral.Controls.Add(Me.lblNroResolucion)
        Me.gpcInformacionGeneral.Controls.Add(Me.txtNumeroResolucion)
        Me.gpcInformacionGeneral.Controls.Add(Me.lblMotivoViatico)
        Me.gpcInformacionGeneral.Controls.Add(Me.txtMotivoViatico)
        Me.gpcInformacionGeneral.Controls.Add(Me.lblFechaMemorandum)
        Me.gpcInformacionGeneral.Controls.Add(Me.dedFechaMemorando)
        Me.gpcInformacionGeneral.Controls.Add(Me.lblNroMemorandum)
        Me.gpcInformacionGeneral.Controls.Add(Me.txtNumeroMemo)
        Me.gpcInformacionGeneral.Location = New System.Drawing.Point(8, 8)
        Me.gpcInformacionGeneral.Name = "gpcInformacionGeneral"
        Me.gpcInformacionGeneral.Size = New System.Drawing.Size(992, 120)
        Me.gpcInformacionGeneral.TabIndex = 0
        Me.gpcInformacionGeneral.Text = "Información General"
        '
        'txtNombreDocumentoWord
        '
        Me.txtNombreDocumentoWord.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreDocumentoWord.Location = New System.Drawing.Point(857, 34)
        Me.txtNombreDocumentoWord.Name = "txtNombreDocumentoWord"
        Me.txtNombreDocumentoWord.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNombreDocumentoWord.Properties.Appearance.Options.UseFont = True
        Me.txtNombreDocumentoWord.Properties.ReadOnly = True
        Me.txtNombreDocumentoWord.Size = New System.Drawing.Size(93, 20)
        Me.txtNombreDocumentoWord.TabIndex = 78
        '
        'btnBuscarDocumentoWord
        '
        Me.btnBuscarDocumentoWord.Location = New System.Drawing.Point(824, 31)
        Me.btnBuscarDocumentoWord.Name = "btnBuscarDocumentoWord"
        Me.btnBuscarDocumentoWord.Size = New System.Drawing.Size(27, 23)
        Me.btnBuscarDocumentoWord.TabIndex = 77
        Me.btnBuscarDocumentoWord.Text = "..."
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(714, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Documento Word"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'luePeriodo
        '
        Me.luePeriodo.Location = New System.Drawing.Point(824, 59)
        Me.luePeriodo.Name = "luePeriodo"
        Me.luePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePeriodo.Properties.NullText = ""
        Me.luePeriodo.Size = New System.Drawing.Size(104, 20)
        Me.luePeriodo.TabIndex = 6
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.Location = New System.Drawing.Point(749, 60)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(69, 16)
        Me.lblPeriodo.TabIndex = 75
        Me.lblPeriodo.Text = "Periodo"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDepartamento
        '
        Me.lblDepartamento.Location = New System.Drawing.Point(56, 38)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(69, 13)
        Me.lblDepartamento.TabIndex = 74
        Me.lblDepartamento.Text = "Departamento"
        '
        'lueDepartamento
        '
        Me.lueDepartamento.Location = New System.Drawing.Point(136, 32)
        Me.lueDepartamento.Name = "lueDepartamento"
        Me.lueDepartamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDepartamento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3")})
        Me.lueDepartamento.Properties.NullText = ""
        Me.lueDepartamento.Size = New System.Drawing.Size(304, 20)
        Me.lueDepartamento.TabIndex = 0
        '
        'lueNumeroResolucion
        '
        Me.lueNumeroResolucion.Location = New System.Drawing.Point(600, 32)
        Me.lueNumeroResolucion.Name = "lueNumeroResolucion"
        Me.lueNumeroResolucion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueNumeroResolucion.Properties.NullText = ""
        Me.lueNumeroResolucion.Size = New System.Drawing.Size(104, 20)
        Me.lueNumeroResolucion.TabIndex = 3
        '
        'lueNumeroMemorandum
        '
        Me.lueNumeroMemorandum.Location = New System.Drawing.Point(136, 56)
        Me.lueNumeroMemorandum.Name = "lueNumeroMemorandum"
        Me.lueNumeroMemorandum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueNumeroMemorandum.Properties.NullText = ""
        Me.lueNumeroMemorandum.Size = New System.Drawing.Size(96, 20)
        Me.lueNumeroMemorandum.TabIndex = 1
        '
        'lblFecharesolucion
        '
        Me.lblFecharesolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecharesolucion.Location = New System.Drawing.Point(488, 60)
        Me.lblFecharesolucion.Name = "lblFecharesolucion"
        Me.lblFecharesolucion.Size = New System.Drawing.Size(104, 16)
        Me.lblFecharesolucion.TabIndex = 72
        Me.lblFecharesolucion.Text = "Fecha Resolución"
        Me.lblFecharesolucion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dedFechaResolucion
        '
        Me.dedFechaResolucion.EditValue = Nothing
        Me.dedFechaResolucion.EnterMoveNextControl = True
        Me.dedFechaResolucion.Location = New System.Drawing.Point(600, 59)
        Me.dedFechaResolucion.Name = "dedFechaResolucion"
        Me.dedFechaResolucion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaResolucion.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaResolucion.Size = New System.Drawing.Size(104, 20)
        Me.dedFechaResolucion.TabIndex = 4
        '
        'lblNroResolucion
        '
        Me.lblNroResolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroResolucion.Location = New System.Drawing.Point(496, 36)
        Me.lblNroResolucion.Name = "lblNroResolucion"
        Me.lblNroResolucion.Size = New System.Drawing.Size(96, 16)
        Me.lblNroResolucion.TabIndex = 70
        Me.lblNroResolucion.Text = "Nº Resolución"
        Me.lblNroResolucion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNumeroResolucion
        '
        Me.txtNumeroResolucion.EnterMoveNextControl = True
        Me.txtNumeroResolucion.Location = New System.Drawing.Point(600, 32)
        Me.txtNumeroResolucion.Name = "txtNumeroResolucion"
        Me.txtNumeroResolucion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroResolucion.Properties.DisplayFormat.FormatString = "n0"
        Me.txtNumeroResolucion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNumeroResolucion.Properties.EditFormat.FormatString = "n0"
        Me.txtNumeroResolucion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNumeroResolucion.Properties.Mask.EditMask = "n0"
        Me.txtNumeroResolucion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumeroResolucion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNumeroResolucion.Properties.MaxLength = 7
        Me.txtNumeroResolucion.Size = New System.Drawing.Size(104, 20)
        Me.txtNumeroResolucion.TabIndex = 3
        Me.txtNumeroResolucion.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'lblMotivoViatico
        '
        Me.lblMotivoViatico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivoViatico.Location = New System.Drawing.Point(544, 84)
        Me.lblMotivoViatico.Name = "lblMotivoViatico"
        Me.lblMotivoViatico.Size = New System.Drawing.Size(48, 16)
        Me.lblMotivoViatico.TabIndex = 68
        Me.lblMotivoViatico.Text = "Motivo"
        Me.lblMotivoViatico.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMotivoViatico
        '
        Me.txtMotivoViatico.EnterMoveNextControl = True
        Me.txtMotivoViatico.Location = New System.Drawing.Point(600, 82)
        Me.txtMotivoViatico.Name = "txtMotivoViatico"
        Me.txtMotivoViatico.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMotivoViatico.Properties.MaxLength = 200
        Me.txtMotivoViatico.Size = New System.Drawing.Size(328, 20)
        Me.txtMotivoViatico.TabIndex = 5
        '
        'lblFechaMemorandum
        '
        Me.lblFechaMemorandum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaMemorandum.Location = New System.Drawing.Point(8, 80)
        Me.lblFechaMemorandum.Name = "lblFechaMemorandum"
        Me.lblFechaMemorandum.Size = New System.Drawing.Size(120, 16)
        Me.lblFechaMemorandum.TabIndex = 66
        Me.lblFechaMemorandum.Text = "Fecha Memorandum"
        Me.lblFechaMemorandum.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dedFechaMemorando
        '
        Me.dedFechaMemorando.EditValue = Nothing
        Me.dedFechaMemorando.EnterMoveNextControl = True
        Me.dedFechaMemorando.Location = New System.Drawing.Point(136, 80)
        Me.dedFechaMemorando.Name = "dedFechaMemorando"
        Me.dedFechaMemorando.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaMemorando.Properties.Mask.EditMask = ""
        Me.dedFechaMemorando.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.dedFechaMemorando.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaMemorando.Size = New System.Drawing.Size(96, 20)
        Me.dedFechaMemorando.TabIndex = 2
        '
        'lblNroMemorandum
        '
        Me.lblNroMemorandum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroMemorandum.Location = New System.Drawing.Point(24, 56)
        Me.lblNroMemorandum.Name = "lblNroMemorandum"
        Me.lblNroMemorandum.Size = New System.Drawing.Size(104, 16)
        Me.lblNroMemorandum.TabIndex = 64
        Me.lblNroMemorandum.Text = "Nº Memorandum"
        Me.lblNroMemorandum.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNumeroMemo
        '
        Me.txtNumeroMemo.EnterMoveNextControl = True
        Me.txtNumeroMemo.Location = New System.Drawing.Point(136, 56)
        Me.txtNumeroMemo.Name = "txtNumeroMemo"
        Me.txtNumeroMemo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroMemo.Properties.DisplayFormat.FormatString = "n0"
        Me.txtNumeroMemo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNumeroMemo.Properties.EditFormat.FormatString = "n0"
        Me.txtNumeroMemo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNumeroMemo.Properties.Mask.EditMask = "[0-9-]*"
        Me.txtNumeroMemo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtNumeroMemo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNumeroMemo.Properties.MaxLength = 8
        Me.txtNumeroMemo.Size = New System.Drawing.Size(96, 20)
        Me.txtNumeroMemo.TabIndex = 1
        '
        'btnCancelarMemorandum
        '
        Me.btnCancelarMemorandum.Location = New System.Drawing.Point(496, 8)
        Me.btnCancelarMemorandum.Name = "btnCancelarMemorandum"
        Me.btnCancelarMemorandum.Size = New System.Drawing.Size(136, 23)
        Me.btnCancelarMemorandum.TabIndex = 9
        Me.btnCancelarMemorandum.Text = "Cancelar"
        '
        'btnGuardarMemorandum
        '
        Me.btnGuardarMemorandum.Location = New System.Drawing.Point(352, 8)
        Me.btnGuardarMemorandum.Name = "btnGuardarMemorandum"
        Me.btnGuardarMemorandum.Size = New System.Drawing.Size(136, 23)
        Me.btnGuardarMemorandum.TabIndex = 8
        Me.btnGuardarMemorandum.Text = "Guardar Memorandum"
        '
        'btnEliminarMemorandum
        '
        Me.btnEliminarMemorandum.Location = New System.Drawing.Point(208, 8)
        Me.btnEliminarMemorandum.Name = "btnEliminarMemorandum"
        Me.btnEliminarMemorandum.Size = New System.Drawing.Size(136, 23)
        Me.btnEliminarMemorandum.TabIndex = 7
        Me.btnEliminarMemorandum.Text = "Eliminar Memorandum"
        '
        'btnNuevoMemorandum
        '
        Me.btnNuevoMemorandum.Location = New System.Drawing.Point(64, 8)
        Me.btnNuevoMemorandum.Name = "btnNuevoMemorandum"
        Me.btnNuevoMemorandum.Size = New System.Drawing.Size(136, 23)
        Me.btnNuevoMemorandum.TabIndex = 6
        Me.btnNuevoMemorandum.Text = "Nuevo Memorandum"
        '
        'gpcRegistrodelViatico
        '
        Me.gpcRegistrodelViatico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcRegistrodelViatico.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcRegistrodelViatico.AppearanceCaption.Options.UseFont = True
        Me.gpcRegistrodelViatico.Controls.Add(Me.gpcDestino)
        Me.gpcRegistrodelViatico.Controls.Add(Me.gpcDatosEmpleado)
        Me.gpcRegistrodelViatico.Controls.Add(Me.gpcDatosdelViatico)
        Me.gpcRegistrodelViatico.Location = New System.Drawing.Point(8, 168)
        Me.gpcRegistrodelViatico.Name = "gpcRegistrodelViatico"
        Me.gpcRegistrodelViatico.Size = New System.Drawing.Size(992, 288)
        Me.gpcRegistrodelViatico.TabIndex = 1
        Me.gpcRegistrodelViatico.Text = "Registro del Viáitco"
        '
        'gpcDestino
        '
        Me.gpcDestino.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcDestino.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDestino.AppearanceCaption.Options.UseFont = True
        Me.gpcDestino.AppearanceCaption.Options.UseTextOptions = True
        Me.gpcDestino.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gpcDestino.Controls.Add(Me.lueComuna)
        Me.gpcDestino.Controls.Add(Me.luePais)
        Me.gpcDestino.Controls.Add(Me.lblPais)
        Me.gpcDestino.Controls.Add(Me.lblComuna)
        Me.gpcDestino.Controls.Add(Me.lblRegion)
        Me.gpcDestino.Controls.Add(Me.lueRegion)
        Me.gpcDestino.Controls.Add(Me.rdgDestino)
        Me.gpcDestino.Location = New System.Drawing.Point(576, 24)
        Me.gpcDestino.Name = "gpcDestino"
        Me.gpcDestino.Size = New System.Drawing.Size(408, 136)
        Me.gpcDestino.TabIndex = 23
        Me.gpcDestino.Text = "Datos del Destino"
        '
        'lueComuna
        '
        Me.lueComuna.EditValue = ""
        Me.lueComuna.EnterMoveNextControl = True
        Me.lueComuna.Location = New System.Drawing.Point(192, 80)
        Me.lueComuna.Name = "lueComuna"
        Me.lueComuna.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueComuna.Properties.NullText = ""
        Me.lueComuna.Size = New System.Drawing.Size(144, 20)
        Me.lueComuna.TabIndex = 16
        '
        'luePais
        '
        Me.luePais.EditValue = ""
        Me.luePais.EnterMoveNextControl = True
        Me.luePais.Location = New System.Drawing.Point(192, 30)
        Me.luePais.Name = "luePais"
        Me.luePais.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePais.Properties.NullText = ""
        Me.luePais.Size = New System.Drawing.Size(144, 20)
        Me.luePais.TabIndex = 14
        '
        'lblPais
        '
        Me.lblPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPais.Location = New System.Drawing.Point(136, 34)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(48, 16)
        Me.lblPais.TabIndex = 67
        Me.lblPais.Text = "País"
        Me.lblPais.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblComuna
        '
        Me.lblComuna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComuna.Location = New System.Drawing.Point(128, 84)
        Me.lblComuna.Name = "lblComuna"
        Me.lblComuna.Size = New System.Drawing.Size(56, 16)
        Me.lblComuna.TabIndex = 66
        Me.lblComuna.Text = "Comuna"
        Me.lblComuna.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRegion
        '
        Me.lblRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegion.Location = New System.Drawing.Point(136, 58)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(48, 16)
        Me.lblRegion.TabIndex = 65
        Me.lblRegion.Text = "Región"
        Me.lblRegion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lueRegion
        '
        Me.lueRegion.EditValue = ""
        Me.lueRegion.EnterMoveNextControl = True
        Me.lueRegion.Location = New System.Drawing.Point(192, 54)
        Me.lueRegion.Name = "lueRegion"
        Me.lueRegion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueRegion.Properties.NullText = ""
        Me.lueRegion.Size = New System.Drawing.Size(144, 20)
        Me.lueRegion.TabIndex = 15
        '
        'rdgDestino
        '
        Me.rdgDestino.EditValue = 0
        Me.rdgDestino.Location = New System.Drawing.Point(8, 32)
        Me.rdgDestino.Name = "rdgDestino"
        Me.rdgDestino.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Nacional"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Internacional")})
        Me.rdgDestino.Size = New System.Drawing.Size(104, 80)
        Me.rdgDestino.TabIndex = 13
        '
        'gpcDatosEmpleado
        '
        Me.gpcDatosEmpleado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDatosEmpleado.AppearanceCaption.Options.UseFont = True
        Me.gpcDatosEmpleado.AppearanceCaption.Options.UseTextOptions = True
        Me.gpcDatosEmpleado.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gpcDatosEmpleado.Controls.Add(Me.txtNombreEmpleado)
        Me.gpcDatosEmpleado.Controls.Add(Me.lblRutEmplado)
        Me.gpcDatosEmpleado.Controls.Add(Me.gleEmpleado)
        Me.gpcDatosEmpleado.Controls.Add(Me.txtCalidadJuridica)
        Me.gpcDatosEmpleado.Controls.Add(Me.lblCalidadJuridica)
        Me.gpcDatosEmpleado.Controls.Add(Me.lblIngresoInstitucion)
        Me.gpcDatosEmpleado.Controls.Add(Me.txtFechaIngresoInstitucion)
        Me.gpcDatosEmpleado.Controls.Add(Me.lblGrado)
        Me.gpcDatosEmpleado.Controls.Add(Me.txtGrado)
        Me.gpcDatosEmpleado.Location = New System.Drawing.Point(8, 24)
        Me.gpcDatosEmpleado.Name = "gpcDatosEmpleado"
        Me.gpcDatosEmpleado.Size = New System.Drawing.Size(568, 136)
        Me.gpcDatosEmpleado.TabIndex = 22
        Me.gpcDatosEmpleado.Text = "Datos del Empleado"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Enabled = False
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(216, 32)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNombreEmpleado.Properties.Appearance.Options.UseFont = True
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(344, 20)
        Me.txtNombreEmpleado.TabIndex = 10
        '
        'lblRutEmplado
        '
        Me.lblRutEmplado.Location = New System.Drawing.Point(8, 36)
        Me.lblRutEmplado.Name = "lblRutEmplado"
        Me.lblRutEmplado.Size = New System.Drawing.Size(80, 16)
        Me.lblRutEmplado.TabIndex = 21
        Me.lblRutEmplado.Text = "Rut Empleado"
        Me.lblRutEmplado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gleEmpleado
        '
        Me.gleEmpleado.EditValue = ""
        Me.gleEmpleado.EnterMoveNextControl = True
        Me.gleEmpleado.Location = New System.Drawing.Point(96, 32)
        Me.gleEmpleado.Name = "gleEmpleado"
        Me.gleEmpleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleEmpleado.Properties.View = Me.GridLookUpEdit1View
        Me.gleEmpleado.Size = New System.Drawing.Size(112, 20)
        Me.gleEmpleado.TabIndex = 9
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtCalidadJuridica
        '
        Me.txtCalidadJuridica.Enabled = False
        Me.txtCalidadJuridica.Location = New System.Drawing.Point(216, 56)
        Me.txtCalidadJuridica.Name = "txtCalidadJuridica"
        Me.txtCalidadJuridica.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCalidadJuridica.Properties.Appearance.Options.UseFont = True
        Me.txtCalidadJuridica.Properties.ReadOnly = True
        Me.txtCalidadJuridica.Size = New System.Drawing.Size(104, 20)
        Me.txtCalidadJuridica.TabIndex = 11
        '
        'lblCalidadJuridica
        '
        Me.lblCalidadJuridica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalidadJuridica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCalidadJuridica.Location = New System.Drawing.Point(112, 60)
        Me.lblCalidadJuridica.Name = "lblCalidadJuridica"
        Me.lblCalidadJuridica.Size = New System.Drawing.Size(96, 16)
        Me.lblCalidadJuridica.TabIndex = 17
        Me.lblCalidadJuridica.Text = "Calidad Jurídica"
        Me.lblCalidadJuridica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIngresoInstitucion
        '
        Me.lblIngresoInstitucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresoInstitucion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblIngresoInstitucion.Location = New System.Drawing.Point(80, 84)
        Me.lblIngresoInstitucion.Name = "lblIngresoInstitucion"
        Me.lblIngresoInstitucion.Size = New System.Drawing.Size(128, 16)
        Me.lblIngresoInstitucion.TabIndex = 15
        Me.lblIngresoInstitucion.Text = "Ingreso a la Institución"
        Me.lblIngresoInstitucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFechaIngresoInstitucion
        '
        Me.txtFechaIngresoInstitucion.Enabled = False
        Me.txtFechaIngresoInstitucion.Location = New System.Drawing.Point(216, 80)
        Me.txtFechaIngresoInstitucion.Name = "txtFechaIngresoInstitucion"
        Me.txtFechaIngresoInstitucion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtFechaIngresoInstitucion.Properties.Appearance.Options.UseFont = True
        Me.txtFechaIngresoInstitucion.Size = New System.Drawing.Size(104, 20)
        Me.txtFechaIngresoInstitucion.TabIndex = 12
        '
        'lblGrado
        '
        Me.lblGrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGrado.Location = New System.Drawing.Point(160, 108)
        Me.lblGrado.Name = "lblGrado"
        Me.lblGrado.Size = New System.Drawing.Size(40, 16)
        Me.lblGrado.TabIndex = 19
        Me.lblGrado.Text = "Grado"
        Me.lblGrado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGrado
        '
        Me.txtGrado.Enabled = False
        Me.txtGrado.Location = New System.Drawing.Point(216, 104)
        Me.txtGrado.Name = "txtGrado"
        Me.txtGrado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtGrado.Properties.Appearance.Options.UseFont = True
        Me.txtGrado.Properties.ReadOnly = True
        Me.txtGrado.Size = New System.Drawing.Size(48, 20)
        Me.txtGrado.TabIndex = 13
        '
        'gpcDatosdelViatico
        '
        Me.gpcDatosdelViatico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcDatosdelViatico.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDatosdelViatico.AppearanceCaption.Options.UseFont = True
        Me.gpcDatosdelViatico.AppearanceCaption.Options.UseTextOptions = True
        Me.gpcDatosdelViatico.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gpcDatosdelViatico.Controls.Add(Me.Label25)
        Me.gpcDatosdelViatico.Controls.Add(Me.txtPatenteVehiculo)
        Me.gpcDatosdelViatico.Controls.Add(Me.dedFechaInicio)
        Me.gpcDatosdelViatico.Controls.Add(Me.txtMonto)
        Me.gpcDatosdelViatico.Controls.Add(Me.lblMontoaPagar)
        Me.gpcDatosdelViatico.Controls.Add(Me.txtPorcentajeaPagar)
        Me.gpcDatosdelViatico.Controls.Add(Me.lblPagar)
        Me.gpcDatosdelViatico.Controls.Add(Me.txtMonto100Porciento)
        Me.gpcDatosdelViatico.Controls.Add(Me.lblMonto100Porciento)
        Me.gpcDatosdelViatico.Controls.Add(Me.rdgEstado)
        Me.gpcDatosdelViatico.Controls.Add(Me.lblEstado)
        Me.gpcDatosdelViatico.Controls.Add(Me.lblCantidadDias)
        Me.gpcDatosdelViatico.Controls.Add(Me.lblFechaInicio)
        Me.gpcDatosdelViatico.Controls.Add(Me.lblFechaTermino)
        Me.gpcDatosdelViatico.Controls.Add(Me.dedFechaTermino)
        Me.gpcDatosdelViatico.Controls.Add(Me.txtDiasSolicitados)
        Me.gpcDatosdelViatico.Location = New System.Drawing.Point(8, 160)
        Me.gpcDatosdelViatico.Name = "gpcDatosdelViatico"
        Me.gpcDatosdelViatico.Size = New System.Drawing.Size(976, 120)
        Me.gpcDatosdelViatico.TabIndex = 24
        Me.gpcDatosdelViatico.Text = "Datos del Viático"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(-8, 96)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(112, 16)
        Me.Label25.TabIndex = 101
        Me.Label25.Text = "Patente Vehículo"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPatenteVehiculo
        '
        Me.txtPatenteVehiculo.Location = New System.Drawing.Point(104, 96)
        Me.txtPatenteVehiculo.Name = "txtPatenteVehiculo"
        Me.txtPatenteVehiculo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPatenteVehiculo.Properties.MaxLength = 10
        Me.txtPatenteVehiculo.Size = New System.Drawing.Size(80, 20)
        Me.txtPatenteVehiculo.TabIndex = 100
        '
        'dedFechaInicio
        '
        Me.dedFechaInicio.EditValue = New Date(2007, 10, 31, 8, 52, 14, 326)
        Me.dedFechaInicio.EnterMoveNextControl = True
        Me.dedFechaInicio.Location = New System.Drawing.Point(224, 31)
        Me.dedFechaInicio.Name = "dedFechaInicio"
        Me.dedFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaInicio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dedFechaInicio.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaInicio.Size = New System.Drawing.Size(96, 20)
        Me.dedFechaInicio.TabIndex = 99
        '
        'txtMonto
        '
        Me.txtMonto.EditValue = 0
        Me.txtMonto.Enabled = False
        Me.txtMonto.Location = New System.Drawing.Point(840, 31)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMonto.Properties.Appearance.Options.UseFont = True
        Me.txtMonto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMonto.Properties.DisplayFormat.FormatString = "n0"
        Me.txtMonto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.Properties.EditFormat.FormatString = "n0"
        Me.txtMonto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.Properties.Mask.EditMask = "n0"
        Me.txtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMonto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMonto.Properties.MaxLength = 30
        Me.txtMonto.Properties.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(96, 20)
        Me.txtMonto.TabIndex = 97
        '
        'lblMontoaPagar
        '
        Me.lblMontoaPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoaPagar.Location = New System.Drawing.Point(736, 31)
        Me.lblMontoaPagar.Name = "lblMontoaPagar"
        Me.lblMontoaPagar.Size = New System.Drawing.Size(96, 16)
        Me.lblMontoaPagar.TabIndex = 98
        Me.lblMontoaPagar.Text = "Monto a Pagar $"
        Me.lblMontoaPagar.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPorcentajeaPagar
        '
        Me.txtPorcentajeaPagar.EditValue = 0
        Me.txtPorcentajeaPagar.Enabled = False
        Me.txtPorcentajeaPagar.Location = New System.Drawing.Point(664, 55)
        Me.txtPorcentajeaPagar.Name = "txtPorcentajeaPagar"
        Me.txtPorcentajeaPagar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtPorcentajeaPagar.Properties.Appearance.Options.UseFont = True
        Me.txtPorcentajeaPagar.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorcentajeaPagar.Properties.DisplayFormat.FormatString = "n0"
        Me.txtPorcentajeaPagar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorcentajeaPagar.Properties.EditFormat.FormatString = "n0"
        Me.txtPorcentajeaPagar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorcentajeaPagar.Properties.Mask.EditMask = "n0"
        Me.txtPorcentajeaPagar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPorcentajeaPagar.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPorcentajeaPagar.Properties.MaxLength = 30
        Me.txtPorcentajeaPagar.Properties.ReadOnly = True
        Me.txtPorcentajeaPagar.Size = New System.Drawing.Size(64, 20)
        Me.txtPorcentajeaPagar.TabIndex = 95
        '
        'lblPagar
        '
        Me.lblPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagar.Location = New System.Drawing.Point(536, 59)
        Me.lblPagar.Name = "lblPagar"
        Me.lblPagar.Size = New System.Drawing.Size(120, 16)
        Me.lblPagar.TabIndex = 96
        Me.lblPagar.Text = "% a Pagar"
        Me.lblPagar.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMonto100Porciento
        '
        Me.txtMonto100Porciento.EditValue = 0
        Me.txtMonto100Porciento.Enabled = False
        Me.txtMonto100Porciento.Location = New System.Drawing.Point(664, 31)
        Me.txtMonto100Porciento.Name = "txtMonto100Porciento"
        Me.txtMonto100Porciento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMonto100Porciento.Properties.Appearance.Options.UseFont = True
        Me.txtMonto100Porciento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMonto100Porciento.Properties.DisplayFormat.FormatString = "n0"
        Me.txtMonto100Porciento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto100Porciento.Properties.EditFormat.FormatString = "n0"
        Me.txtMonto100Porciento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto100Porciento.Properties.Mask.EditMask = "n0"
        Me.txtMonto100Porciento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMonto100Porciento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMonto100Porciento.Properties.MaxLength = 30
        Me.txtMonto100Porciento.Properties.ReadOnly = True
        Me.txtMonto100Porciento.Size = New System.Drawing.Size(64, 20)
        Me.txtMonto100Porciento.TabIndex = 93
        '
        'lblMonto100Porciento
        '
        Me.lblMonto100Porciento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto100Porciento.Location = New System.Drawing.Point(536, 31)
        Me.lblMonto100Porciento.Name = "lblMonto100Porciento"
        Me.lblMonto100Porciento.Size = New System.Drawing.Size(120, 16)
        Me.lblMonto100Porciento.TabIndex = 94
        Me.lblMonto100Porciento.Text = "Monto 100% Viático"
        Me.lblMonto100Porciento.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'rdgEstado
        '
        Me.rdgEstado.EditValue = 0
        Me.rdgEstado.Location = New System.Drawing.Point(104, 55)
        Me.rdgEstado.Name = "rdgEstado"
        Me.rdgEstado.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Pendiente"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Pagado con cheque"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Pagado y despositado en cta.cte")})
        Me.rdgEstado.Size = New System.Drawing.Size(384, 32)
        Me.rdgEstado.TabIndex = 12
        '
        'lblEstado
        '
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(48, 67)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(48, 16)
        Me.lblEstado.TabIndex = 92
        Me.lblEstado.Text = "Estado"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCantidadDias
        '
        Me.lblCantidadDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadDias.Location = New System.Drawing.Point(8, 35)
        Me.lblCantidadDias.Name = "lblCantidadDias"
        Me.lblCantidadDias.Size = New System.Drawing.Size(88, 16)
        Me.lblCantidadDias.TabIndex = 89
        Me.lblCantidadDias.Text = "Cantidad Días"
        Me.lblCantidadDias.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInicio.Location = New System.Drawing.Point(176, 35)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(40, 16)
        Me.lblFechaInicio.TabIndex = 91
        Me.lblFechaInicio.Text = "Inicio"
        Me.lblFechaInicio.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFechaTermino
        '
        Me.lblFechaTermino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaTermino.Location = New System.Drawing.Point(336, 35)
        Me.lblFechaTermino.Name = "lblFechaTermino"
        Me.lblFechaTermino.Size = New System.Drawing.Size(56, 16)
        Me.lblFechaTermino.TabIndex = 90
        Me.lblFechaTermino.Text = "Término"
        Me.lblFechaTermino.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dedFechaTermino
        '
        Me.dedFechaTermino.EditValue = New Date(2006, 11, 20, 0, 0, 0, 0)
        Me.dedFechaTermino.Enabled = False
        Me.dedFechaTermino.Location = New System.Drawing.Point(400, 31)
        Me.dedFechaTermino.Name = "dedFechaTermino"
        Me.dedFechaTermino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaTermino.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dedFechaTermino.Properties.ReadOnly = True
        Me.dedFechaTermino.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaTermino.Size = New System.Drawing.Size(88, 20)
        Me.dedFechaTermino.TabIndex = 87
        '
        'txtDiasSolicitados
        '
        Me.txtDiasSolicitados.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtDiasSolicitados.EnterMoveNextControl = True
        Me.txtDiasSolicitados.Location = New System.Drawing.Point(104, 31)
        Me.txtDiasSolicitados.Name = "txtDiasSolicitados"
        Me.txtDiasSolicitados.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDiasSolicitados.Properties.IsFloatValue = False
        Me.txtDiasSolicitados.Properties.Mask.EditMask = "N00"
        Me.txtDiasSolicitados.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtDiasSolicitados.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtDiasSolicitados.Size = New System.Drawing.Size(46, 20)
        Me.txtDiasSolicitados.TabIndex = 10
        '
        'btnCancelarDetalle
        '
        Me.btnCancelarDetalle.Location = New System.Drawing.Point(560, 8)
        Me.btnCancelarDetalle.Name = "btnCancelarDetalle"
        Me.btnCancelarDetalle.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarDetalle.TabIndex = 20
        Me.btnCancelarDetalle.Text = "Cancelar"
        '
        'btnGuardarDetalle
        '
        Me.btnGuardarDetalle.Location = New System.Drawing.Point(464, 8)
        Me.btnGuardarDetalle.Name = "btnGuardarDetalle"
        Me.btnGuardarDetalle.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarDetalle.TabIndex = 19
        Me.btnGuardarDetalle.Text = "Guardar"
        '
        'btnEliminaDetalle
        '
        Me.btnEliminaDetalle.Location = New System.Drawing.Point(360, 8)
        Me.btnEliminaDetalle.Name = "btnEliminaDetalle"
        Me.btnEliminaDetalle.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminaDetalle.TabIndex = 18
        Me.btnEliminaDetalle.Text = "Eliminar"
        '
        'btnNuevoDetalle
        '
        Me.btnNuevoDetalle.Location = New System.Drawing.Point(264, 8)
        Me.btnNuevoDetalle.Name = "btnNuevoDetalle"
        Me.btnNuevoDetalle.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevoDetalle.TabIndex = 17
        Me.btnNuevoDetalle.Text = "Nuevo"
        '
        'gdcViatico
        '
        Me.gdcViatico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcViatico.Location = New System.Drawing.Point(8, 504)
        Me.gdcViatico.MainView = Me.gdvDetalleViatico
        Me.gdcViatico.Name = "gdcViatico"
        Me.gdcViatico.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtMontoViaticoRepositorio})
        Me.gdcViatico.Size = New System.Drawing.Size(992, 224)
        Me.gdcViatico.TabIndex = 2
        Me.gdcViatico.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleViatico, Me.GridView1})
        '
        'gdvDetalleViatico
        '
        Me.gdvDetalleViatico.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gdvDetalleViatico.Appearance.FooterPanel.Options.UseFont = True
        Me.gdvDetalleViatico.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.fieldVIATICO_DETALLE_ID, Me.fieldEMPLEADO_ID, Me.fieldNOMBRE_EMPLEADO, Me.fieldCALIDAD_JURIDICA, Me.fieldGRADO_ALIAS, Me.fieldCANTIDAD_DIAS, Me.fieldFECHA_INICIO, Me.fieldFECHA_TERMINO, Me.fieldMONTO, Me.fieldPAIS_DESTINO, Me.fieldREGION_DESTINO, Me.fieldCOMUNA_DESTINO, Me.fieldSTR_ESTADO_VIATICO, Me.fieldDESTINO, Me.fieldPAIS_ID, Me.fieldREGION_ID, Me.fieldCOMUNA_ID, Me.fieldESTADO_VIATICO, Me.fieldNUMERO_DOCUMENTO, Me.fieldFECHA_DOCUMENTO, Me.fieldPATENTE_VEHICULO})
        Me.gdvDetalleViatico.GridControl = Me.gdcViatico
        Me.gdvDetalleViatico.Name = "gdvDetalleViatico"
        Me.gdvDetalleViatico.OptionsView.ColumnAutoWidth = False
        Me.gdvDetalleViatico.OptionsView.ShowFooter = True
        Me.gdvDetalleViatico.OptionsView.ShowGroupPanel = False
        '
        'fieldVIATICO_DETALLE_ID
        '
        Me.fieldVIATICO_DETALLE_ID.Caption = "Id Detalle Viático"
        Me.fieldVIATICO_DETALLE_ID.FieldName = "VIATICO_DETALLE_ID"
        Me.fieldVIATICO_DETALLE_ID.Name = "fieldVIATICO_DETALLE_ID"
        Me.fieldVIATICO_DETALLE_ID.OptionsColumn.AllowEdit = False
        '
        'fieldEMPLEADO_ID
        '
        Me.fieldEMPLEADO_ID.Caption = "ID Empleado"
        Me.fieldEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.fieldEMPLEADO_ID.Name = "fieldEMPLEADO_ID"
        Me.fieldEMPLEADO_ID.OptionsColumn.AllowEdit = False
        '
        'fieldNOMBRE_EMPLEADO
        '
        Me.fieldNOMBRE_EMPLEADO.Caption = "Empleado"
        Me.fieldNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.Name = "fieldNOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.OptionsColumn.AllowEdit = False
        Me.fieldNOMBRE_EMPLEADO.Visible = True
        Me.fieldNOMBRE_EMPLEADO.VisibleIndex = 0
        Me.fieldNOMBRE_EMPLEADO.Width = 232
        '
        'fieldCALIDAD_JURIDICA
        '
        Me.fieldCALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.fieldCALIDAD_JURIDICA.FieldName = "CALIDAD_JURIDICA"
        Me.fieldCALIDAD_JURIDICA.Name = "fieldCALIDAD_JURIDICA"
        Me.fieldCALIDAD_JURIDICA.OptionsColumn.AllowEdit = False
        Me.fieldCALIDAD_JURIDICA.Width = 140
        '
        'fieldGRADO_ALIAS
        '
        Me.fieldGRADO_ALIAS.Caption = "Grado"
        Me.fieldGRADO_ALIAS.FieldName = "GRADO_ALIAS"
        Me.fieldGRADO_ALIAS.Name = "fieldGRADO_ALIAS"
        Me.fieldGRADO_ALIAS.OptionsColumn.AllowEdit = False
        '
        'fieldCANTIDAD_DIAS
        '
        Me.fieldCANTIDAD_DIAS.Caption = "Cantidad Días"
        Me.fieldCANTIDAD_DIAS.FieldName = "CANTIDAD_DIAS"
        Me.fieldCANTIDAD_DIAS.Name = "fieldCANTIDAD_DIAS"
        Me.fieldCANTIDAD_DIAS.OptionsColumn.AllowEdit = False
        Me.fieldCANTIDAD_DIAS.Visible = True
        Me.fieldCANTIDAD_DIAS.VisibleIndex = 1
        '
        'fieldFECHA_INICIO
        '
        Me.fieldFECHA_INICIO.Caption = "Fecha Inicio"
        Me.fieldFECHA_INICIO.FieldName = "FECHA_INICIO"
        Me.fieldFECHA_INICIO.Name = "fieldFECHA_INICIO"
        Me.fieldFECHA_INICIO.OptionsColumn.AllowEdit = False
        Me.fieldFECHA_INICIO.Visible = True
        Me.fieldFECHA_INICIO.VisibleIndex = 2
        '
        'fieldFECHA_TERMINO
        '
        Me.fieldFECHA_TERMINO.Caption = "Fecha Término"
        Me.fieldFECHA_TERMINO.FieldName = "FECHA_TERMINO"
        Me.fieldFECHA_TERMINO.Name = "fieldFECHA_TERMINO"
        Me.fieldFECHA_TERMINO.OptionsColumn.AllowEdit = False
        Me.fieldFECHA_TERMINO.Visible = True
        Me.fieldFECHA_TERMINO.VisibleIndex = 3
        Me.fieldFECHA_TERMINO.Width = 91
        '
        'fieldMONTO
        '
        Me.fieldMONTO.Caption = "Monto a Pagar"
        Me.fieldMONTO.ColumnEdit = Me.txtMontoViaticoRepositorio
        Me.fieldMONTO.FieldName = "MONTO"
        Me.fieldMONTO.Name = "fieldMONTO"
        Me.fieldMONTO.OptionsColumn.AllowEdit = False
        Me.fieldMONTO.SummaryItem.DisplayFormat = "Total Viático: {0:n0}"
        Me.fieldMONTO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.fieldMONTO.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.fieldMONTO.Visible = True
        Me.fieldMONTO.VisibleIndex = 4
        Me.fieldMONTO.Width = 134
        '
        'txtMontoViaticoRepositorio
        '
        Me.txtMontoViaticoRepositorio.AutoHeight = False
        Me.txtMontoViaticoRepositorio.DisplayFormat.FormatString = "n0"
        Me.txtMontoViaticoRepositorio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoViaticoRepositorio.EditFormat.FormatString = "n0"
        Me.txtMontoViaticoRepositorio.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoViaticoRepositorio.Name = "txtMontoViaticoRepositorio"
        '
        'fieldPAIS_DESTINO
        '
        Me.fieldPAIS_DESTINO.Caption = "País Destino"
        Me.fieldPAIS_DESTINO.FieldName = "PAIS_DESTINO"
        Me.fieldPAIS_DESTINO.Name = "fieldPAIS_DESTINO"
        Me.fieldPAIS_DESTINO.OptionsColumn.AllowEdit = False
        Me.fieldPAIS_DESTINO.Width = 149
        '
        'fieldREGION_DESTINO
        '
        Me.fieldREGION_DESTINO.Caption = "Región Destino"
        Me.fieldREGION_DESTINO.FieldName = "REGION_DESTINO"
        Me.fieldREGION_DESTINO.Name = "fieldREGION_DESTINO"
        Me.fieldREGION_DESTINO.OptionsColumn.AllowEdit = False
        Me.fieldREGION_DESTINO.Visible = True
        Me.fieldREGION_DESTINO.VisibleIndex = 5
        Me.fieldREGION_DESTINO.Width = 139
        '
        'fieldCOMUNA_DESTINO
        '
        Me.fieldCOMUNA_DESTINO.Caption = "Comuna Destino"
        Me.fieldCOMUNA_DESTINO.FieldName = "COMUNA_DESTINO"
        Me.fieldCOMUNA_DESTINO.Name = "fieldCOMUNA_DESTINO"
        Me.fieldCOMUNA_DESTINO.OptionsColumn.AllowEdit = False
        Me.fieldCOMUNA_DESTINO.Width = 140
        '
        'fieldSTR_ESTADO_VIATICO
        '
        Me.fieldSTR_ESTADO_VIATICO.Caption = "Estado Viático"
        Me.fieldSTR_ESTADO_VIATICO.FieldName = "STR_ESTADO_VIATICO"
        Me.fieldSTR_ESTADO_VIATICO.Name = "fieldSTR_ESTADO_VIATICO"
        Me.fieldSTR_ESTADO_VIATICO.OptionsColumn.AllowEdit = False
        Me.fieldSTR_ESTADO_VIATICO.Visible = True
        Me.fieldSTR_ESTADO_VIATICO.VisibleIndex = 6
        Me.fieldSTR_ESTADO_VIATICO.Width = 107
        '
        'fieldDESTINO
        '
        Me.fieldDESTINO.Caption = "Destino"
        Me.fieldDESTINO.FieldName = "DESTINO"
        Me.fieldDESTINO.Name = "fieldDESTINO"
        Me.fieldDESTINO.OptionsColumn.AllowEdit = False
        '
        'fieldPAIS_ID
        '
        Me.fieldPAIS_ID.Caption = "ID País"
        Me.fieldPAIS_ID.FieldName = "PAIS_ID"
        Me.fieldPAIS_ID.Name = "fieldPAIS_ID"
        Me.fieldPAIS_ID.OptionsColumn.AllowEdit = False
        '
        'fieldREGION_ID
        '
        Me.fieldREGION_ID.Caption = "ID Región"
        Me.fieldREGION_ID.FieldName = "REGION_ID"
        Me.fieldREGION_ID.Name = "fieldREGION_ID"
        Me.fieldREGION_ID.OptionsColumn.AllowEdit = False
        '
        'fieldCOMUNA_ID
        '
        Me.fieldCOMUNA_ID.Caption = "ID Comuna"
        Me.fieldCOMUNA_ID.FieldName = "COMUNA_id"
        Me.fieldCOMUNA_ID.Name = "fieldCOMUNA_ID"
        Me.fieldCOMUNA_ID.OptionsColumn.AllowEdit = False
        '
        'fieldESTADO_VIATICO
        '
        Me.fieldESTADO_VIATICO.Caption = "Estado Viático"
        Me.fieldESTADO_VIATICO.FieldName = "ESTADO_VIATICO"
        Me.fieldESTADO_VIATICO.Name = "fieldESTADO_VIATICO"
        Me.fieldESTADO_VIATICO.OptionsColumn.AllowEdit = False
        '
        'fieldNUMERO_DOCUMENTO
        '
        Me.fieldNUMERO_DOCUMENTO.Caption = "Numero Cheque"
        Me.fieldNUMERO_DOCUMENTO.FieldName = "NUMERO_DOCUMENTO"
        Me.fieldNUMERO_DOCUMENTO.Name = "fieldNUMERO_DOCUMENTO"
        Me.fieldNUMERO_DOCUMENTO.OptionsColumn.AllowEdit = False
        Me.fieldNUMERO_DOCUMENTO.Visible = True
        Me.fieldNUMERO_DOCUMENTO.VisibleIndex = 7
        '
        'fieldFECHA_DOCUMENTO
        '
        Me.fieldFECHA_DOCUMENTO.Caption = "Fecha Docto."
        Me.fieldFECHA_DOCUMENTO.FieldName = "FECHA_DOCUMENTO"
        Me.fieldFECHA_DOCUMENTO.Name = "fieldFECHA_DOCUMENTO"
        Me.fieldFECHA_DOCUMENTO.OptionsColumn.AllowEdit = False
        Me.fieldFECHA_DOCUMENTO.Visible = True
        Me.fieldFECHA_DOCUMENTO.VisibleIndex = 8
        Me.fieldFECHA_DOCUMENTO.Width = 84
        '
        'fieldPATENTE_VEHICULO
        '
        Me.fieldPATENTE_VEHICULO.Caption = "Patente Vehículo"
        Me.fieldPATENTE_VEHICULO.FieldName = "PATENTE_VEHICULO"
        Me.fieldPATENTE_VEHICULO.Name = "fieldPATENTE_VEHICULO"
        Me.fieldPATENTE_VEHICULO.OptionsColumn.AllowEdit = False
        Me.fieldPATENTE_VEHICULO.OptionsColumn.ReadOnly = True
        Me.fieldPATENTE_VEHICULO.Visible = True
        Me.fieldPATENTE_VEHICULO.VisibleIndex = 9
        Me.fieldPATENTE_VEHICULO.Width = 103
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcViatico
        Me.GridView1.Name = "GridView1"
        '
        'gpcBotonesEncabezado
        '
        Me.gpcBotonesEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcBotonesEncabezado.Controls.Add(Me.btnVisualizar)
        Me.gpcBotonesEncabezado.Controls.Add(Me.btnEmiteResolucion)
        Me.gpcBotonesEncabezado.Controls.Add(Me.btnNuevoMemorandum)
        Me.gpcBotonesEncabezado.Controls.Add(Me.btnEliminarMemorandum)
        Me.gpcBotonesEncabezado.Controls.Add(Me.btnGuardarMemorandum)
        Me.gpcBotonesEncabezado.Controls.Add(Me.btnCancelarMemorandum)
        Me.gpcBotonesEncabezado.Location = New System.Drawing.Point(8, 128)
        Me.gpcBotonesEncabezado.Name = "gpcBotonesEncabezado"
        Me.gpcBotonesEncabezado.ShowCaption = False
        Me.gpcBotonesEncabezado.Size = New System.Drawing.Size(992, 40)
        Me.gpcBotonesEncabezado.TabIndex = 3
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(784, 8)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(136, 23)
        Me.btnVisualizar.TabIndex = 11
        Me.btnVisualizar.Text = "Visualizar"
        '
        'btnEmiteResolucion
        '
        Me.btnEmiteResolucion.Location = New System.Drawing.Point(640, 8)
        Me.btnEmiteResolucion.Name = "btnEmiteResolucion"
        Me.btnEmiteResolucion.Size = New System.Drawing.Size(136, 23)
        Me.btnEmiteResolucion.TabIndex = 10
        Me.btnEmiteResolucion.Text = "Emite Resolución"
        '
        'gpcBotonesDetalle
        '
        Me.gpcBotonesDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcBotonesDetalle.Controls.Add(Me.btnNuevoDetalle)
        Me.gpcBotonesDetalle.Controls.Add(Me.btnCancelarDetalle)
        Me.gpcBotonesDetalle.Controls.Add(Me.btnGuardarDetalle)
        Me.gpcBotonesDetalle.Controls.Add(Me.btnEliminaDetalle)
        Me.gpcBotonesDetalle.Location = New System.Drawing.Point(8, 464)
        Me.gpcBotonesDetalle.Name = "gpcBotonesDetalle"
        Me.gpcBotonesDetalle.ShowCaption = False
        Me.gpcBotonesDetalle.Size = New System.Drawing.Size(992, 40)
        Me.gpcBotonesDetalle.TabIndex = 4
        '
        'prsViatico
        '
        Me.prsViatico.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcViatico
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(10, 10, 50, 50)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de la República" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Depto. RRHH", "Detalle de Viático", "Fecha Emisiòn:[Date Printed]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Emitido Por:[User Name]"}, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"", "", "Página [Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.prsViatico
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prsViatico
        '
        'gdcResolucion
        '
        Me.gdcResolucion.Location = New System.Drawing.Point(72, 544)
        Me.gdcResolucion.MainView = Me.gdvResolucion
        Me.gdcResolucion.Name = "gdcResolucion"
        Me.gdcResolucion.Size = New System.Drawing.Size(400, 98)
        Me.gdcResolucion.TabIndex = 5
        Me.gdcResolucion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvResolucion})
        '
        'gdvResolucion
        '
        Me.gdvResolucion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVIATICO_ID, Me.colNRO_MEMORANDUM_INTERNO, Me.colDEPARTAMENTO, Me.colFECHA_MEMORANDUM, Me.colAÑO, Me.colMES})
        Me.gdvResolucion.GridControl = Me.gdcResolucion
        Me.gdvResolucion.Name = "gdvResolucion"
        '
        'colVIATICO_ID
        '
        Me.colVIATICO_ID.Caption = "VIATICO_ID"
        Me.colVIATICO_ID.FieldName = "VIATICO_ID"
        Me.colVIATICO_ID.Name = "colVIATICO_ID"
        Me.colVIATICO_ID.OptionsColumn.AllowEdit = False
        Me.colVIATICO_ID.OptionsColumn.AllowMove = False
        Me.colVIATICO_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colVIATICO_ID.OptionsColumn.ReadOnly = True
        Me.colVIATICO_ID.OptionsColumn.ShowInCustomizationForm = False
        Me.colVIATICO_ID.Visible = True
        Me.colVIATICO_ID.VisibleIndex = 0
        '
        'colNRO_MEMORANDUM_INTERNO
        '
        Me.colNRO_MEMORANDUM_INTERNO.Caption = "NRO_MEMORANDUM_INTERNO"
        Me.colNRO_MEMORANDUM_INTERNO.FieldName = "NRO_MEMORANDUM_INTERNO"
        Me.colNRO_MEMORANDUM_INTERNO.Name = "colNRO_MEMORANDUM_INTERNO"
        Me.colNRO_MEMORANDUM_INTERNO.OptionsColumn.AllowEdit = False
        Me.colNRO_MEMORANDUM_INTERNO.OptionsColumn.AllowMove = False
        Me.colNRO_MEMORANDUM_INTERNO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNRO_MEMORANDUM_INTERNO.OptionsColumn.ReadOnly = True
        Me.colNRO_MEMORANDUM_INTERNO.OptionsColumn.ShowInCustomizationForm = False
        Me.colNRO_MEMORANDUM_INTERNO.Visible = True
        Me.colNRO_MEMORANDUM_INTERNO.VisibleIndex = 1
        '
        'colDEPARTAMENTO
        '
        Me.colDEPARTAMENTO.Caption = "DEPARTAMENTO"
        Me.colDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.colDEPARTAMENTO.Name = "colDEPARTAMENTO"
        Me.colDEPARTAMENTO.OptionsColumn.AllowEdit = False
        Me.colDEPARTAMENTO.OptionsColumn.AllowMove = False
        Me.colDEPARTAMENTO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDEPARTAMENTO.OptionsColumn.ReadOnly = True
        Me.colDEPARTAMENTO.OptionsColumn.ShowInCustomizationForm = False
        Me.colDEPARTAMENTO.Visible = True
        Me.colDEPARTAMENTO.VisibleIndex = 2
        '
        'colFECHA_MEMORANDUM
        '
        Me.colFECHA_MEMORANDUM.Caption = "FECHA_MEMORANDUM"
        Me.colFECHA_MEMORANDUM.FieldName = "FECHA_MEMORANDUM"
        Me.colFECHA_MEMORANDUM.Name = "colFECHA_MEMORANDUM"
        Me.colFECHA_MEMORANDUM.OptionsColumn.AllowEdit = False
        Me.colFECHA_MEMORANDUM.OptionsColumn.AllowMove = False
        Me.colFECHA_MEMORANDUM.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colFECHA_MEMORANDUM.OptionsColumn.ReadOnly = True
        Me.colFECHA_MEMORANDUM.OptionsColumn.ShowInCustomizationForm = False
        Me.colFECHA_MEMORANDUM.Visible = True
        Me.colFECHA_MEMORANDUM.VisibleIndex = 3
        '
        'colAÑO
        '
        Me.colAÑO.Caption = "AÑO"
        Me.colAÑO.FieldName = "AÑO"
        Me.colAÑO.Name = "colAÑO"
        Me.colAÑO.OptionsColumn.AllowEdit = False
        Me.colAÑO.OptionsColumn.AllowMove = False
        Me.colAÑO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colAÑO.OptionsColumn.ReadOnly = True
        Me.colAÑO.OptionsColumn.ShowInCustomizationForm = False
        Me.colAÑO.Visible = True
        Me.colAÑO.VisibleIndex = 4
        '
        'colMES
        '
        Me.colMES.Caption = "MES"
        Me.colMES.FieldName = "MES"
        Me.colMES.Name = "colMES"
        Me.colMES.OptionsColumn.AllowEdit = False
        Me.colMES.OptionsColumn.AllowMove = False
        Me.colMES.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMES.OptionsColumn.ReadOnly = True
        Me.colMES.OptionsColumn.ShowInCustomizationForm = False
        Me.colMES.Visible = True
        Me.colMES.VisibleIndex = 5
        '
        'frmViatico
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1008, 734)
        Me.Controls.Add(Me.gdcResolucion)
        Me.Controls.Add(Me.gpcBotonesDetalle)
        Me.Controls.Add(Me.gpcBotonesEncabezado)
        Me.Controls.Add(Me.gdcViatico)
        Me.Controls.Add(Me.gpcRegistrodelViatico)
        Me.Controls.Add(Me.gpcInformacionGeneral)
        Me.Name = "frmViatico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Viático"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gpcInformacionGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcInformacionGeneral.ResumeLayout(False)
        Me.gpcInformacionGeneral.PerformLayout()
        CType(Me.txtNombreDocumentoWord.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueNumeroResolucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueNumeroMemorandum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaResolucion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaResolucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroResolucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMotivoViatico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaMemorando.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaMemorando.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroMemo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcRegistrodelViatico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcRegistrodelViatico.ResumeLayout(False)
        CType(Me.gpcDestino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDestino.ResumeLayout(False)
        CType(Me.lueComuna.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueRegion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDatosEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatosEmpleado.ResumeLayout(False)
        CType(Me.txtNombreEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCalidadJuridica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIngresoInstitucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGrado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcDatosdelViatico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatosdelViatico.ResumeLayout(False)
        CType(Me.txtPatenteVehiculo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentajeaPagar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto100Porciento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaTermino.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaTermino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiasSolicitados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcViatico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleViatico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoViaticoRepositorio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcBotonesEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBotonesEncabezado.ResumeLayout(False)
        CType(Me.gpcBotonesDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBotonesDetalle.ResumeLayout(False)
        CType(Me.prsViatico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcResolucion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvResolucion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents WordApplication As word.Application
    Private empleado As Empleado
    Private periodo As Periodo
    Private viatico As Viatico

    Private Sub frmViatico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gdcResolucion.Visible = False
        empleado = New Empleado
        gleEmpleado.EditValue = Nothing
        lueDepartamento.EditValue = Nothing
        viatico = New Viatico
        periodo = New Periodo
        repositorio.RefreshDatos("Localidad")
        repositorio.RefreshDatos("Departamentos")
        'repositorio.RefreshDatos("Viaticos")
        llenarEmpleado()
        llenarPais()
        llenarNumeroMemo()
        llenarNumeroResolucion()
        llenarDepto()
        llenarPeriodo()
        activarControlesIniciales()
        LeerArchivoTexto()
    End Sub
    Private Sub llenarEmpleado()
        gleEmpleado.Properties.EditValueChangedFiringDelay = 1200
        gleEmpleado.Properties.EditValueChangedFiringMode = EditValueChangedFiringMode.Buffered
        'Dos segundos se espera antes de gatillar la búsqueda (EditValueChanged)

        gleEmpleado.Properties.ViewType = Repository.GridLookUpViewType.GridView
        gleEmpleado.Properties.View.OptionsBehavior.AutoPopulateColumns = False
        gleEmpleado.Properties.DataSource = repositorio.dvEmpleadosPlantaContrataActivos
        gleEmpleado.Properties.DisplayMember = "RUT"

        Dim col1 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("RUT")
        col1.VisibleIndex = 0
        col1.Caption = "RUT"

        Dim col2 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("APELLIDO_PATERNO")
        col2.VisibleIndex = 1
        col2.Caption = "Apellido Paterno"

        Dim col3 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("APELLIDO_MATERNO")
        col3.VisibleIndex = 2
        col3.Caption = "Apellido Materno"

        Dim col4 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("NOMBRES")
        col4.VisibleIndex = 3
        col4.Caption = "Nombres"

        Dim col5 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("DESC_CALIDAD_JURIDICA")
        col5.VisibleIndex = 5
        col5.Caption = "Calidad Jurídica"
        col5.Visible = True

        Dim col6 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("DESC_ESTADO")
        col6.VisibleIndex = 4
        col6.Caption = "Estado"

        Dim col7 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("NOMBRE_COMPLETO")
        col7.VisibleIndex = 6
        col7.Caption = "Nombre Completo"
        col7.Visible = False

        gleEmpleado.Properties.ValueMember = "EMPLEADO_ID"

        gleEmpleado.Properties.View.BestFitColumns()
        gleEmpleado.Properties.PopupFormWidth = 600

        gleEmpleado.Text = ""
        gleEmpleado.EditValue = Nothing
    End Sub
    Private Sub llenarPais()
        With luePais
            With .Properties.Columns
                .Add(New LookUpColumnInfo("PAIS_ID", "ID País", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "País", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        luePais.Properties.DataSource = repositorio.dvPaises
        luePais.Properties.DisplayMember = "DESCRIPCION"
        luePais.Properties.NullText = ""
        luePais.Properties.PopupWidth = 200
        luePais.Properties.ValueMember = "PAIS_ID"
    End Sub
    Private Sub llenarRegion()
        lueRegion.Properties.Columns.Clear()
        With lueRegion
            With .Properties.Columns
                .Add(New LookUpColumnInfo("REGION_ID", "ID Región", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Región", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueRegion.Properties.DataSource = repositorio.dvRegiones
        lueRegion.Properties.DisplayMember = "DESCRIPCION"
        lueRegion.Properties.NullText = ""
        lueRegion.Properties.PopupWidth = 200
        lueRegion.Properties.ValueMember = "REGION_ID"
    End Sub
    Private Sub llenarComuna()
        lueComuna.Properties.Columns.Clear()
        With lueComuna
            With .Properties.Columns
                .Add(New LookUpColumnInfo("COMUNA_ID", "ID Comuna", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Comuna", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueComuna.Properties.DataSource = repositorio.dvComunas
        lueComuna.Properties.DisplayMember = "DESCRIPCION"
        lueComuna.Properties.NullText = ""
        lueComuna.Properties.PopupWidth = 200
        lueComuna.Properties.ValueMember = "COMUNA_ID"
    End Sub
    Private Sub llenarDepto()
        lueDepartamento.Properties.Columns.Clear()
        With lueDepartamento
            With .Properties.Columns
                .Add(New LookUpColumnInfo("DEPTO_ID", "ID Depto", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Departamento", 300, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueDepartamento.Properties.DataSource = repositorio.dvDepartamentos
        lueDepartamento.Properties.DisplayMember = "DESCRIPCION"
        lueDepartamento.Properties.NullText = ""
        lueDepartamento.Properties.PopupWidth = 200
        lueDepartamento.Properties.ValueMember = "DEPTO_ID"
    End Sub
    Private Sub llenarPeriodo()
        With luePeriodo
            With .Properties.Columns
                .Add(New LookUpColumnInfo("PERIODO_ID", "ID Periodo", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ANO", "Año", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("MES", "Mes", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ESTADO_PERIODO", "Estado Periodo", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION_PERIODO", "Periodo", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        luePeriodo.Properties.DataSource = repositorio.dvPeriodo
        luePeriodo.Properties.DisplayMember = "DESCRIPCION_PERIODO"
        luePeriodo.Properties.NullText = ""
        luePeriodo.Properties.PopupWidth = 150
        luePeriodo.Properties.ValueMember = "PERIODO_ID"
    End Sub
    Private Sub llenarNumeroResolucion()
        repositorio.RefreshDatos("Viaticos")
        lueNumeroResolucion.Properties.Columns.Clear()
        With lueNumeroResolucion
            With .Properties.Columns
                .Add(New LookUpColumnInfo("NRO_RESOLUCION", "Nro.Resolución", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("FECHA_RESOLUCION", "Fecha", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("VIATICO_ID", "ID Viático", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ANO", "Año", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("MES", "Mes", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ESTADO_VIATICO", "Estado Viatico", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueNumeroResolucion.Properties.DataSource = repositorio.dvViaticoNumeroResolucion
        lueNumeroResolucion.Properties.DisplayMember = "NRO_RESOLUCION"
        lueNumeroResolucion.Properties.NullText = ""
        lueNumeroResolucion.Properties.PopupWidth = 350
        lueNumeroResolucion.Properties.ValueMember = "VIATICO_ID"
    End Sub
    Private Sub llenarNumeroMemo()
        repositorio.RefreshDatos("Viaticos")
        lueNumeroMemorandum.Properties.Columns.Clear()
        With lueNumeroMemorandum
            With .Properties.Columns
                .Add(New LookUpColumnInfo("NRO_MEMORANDUM_INTERNO", "Nro.Memorandum", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DEPARTAMENTO", "Departamento", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("FECHA_MEMORANDUM", "Fecha", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("VIATICO_ID", "ID Viático", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                '.Add(New LookUpColumnInfo("ANO", "Año", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                '.Add(New LookUpColumnInfo("MES", "Mes", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ESTADO_VIATICO", "Estado Viatico", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueNumeroMemorandum.Properties.DataSource = repositorio.dvViaticoNumeroMemorandum
        lueNumeroMemorandum.Properties.DisplayMember = "NRO_MEMORANDUM_INTERNO"
        lueNumeroMemorandum.Properties.NullText = ""
        lueNumeroMemorandum.Properties.PopupWidth = 350
        lueNumeroMemorandum.Properties.ValueMember = "VIATICO_ID"
    End Sub

    Private Sub btnNuevoMemorandum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoMemorandum.Click
        viatico = New Viatico
        controlesAsociadosNuevoMemo()
    End Sub
    Private Sub btnGuardarMemorandum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarMemorandum.Click
        If validarDatosBasicosEncabezado() Then
            asignacionCampos()
            If viatico.datosEncabezado.viaticoID = 0 Then
                Try
                    viatico.datosEncabezado.viaticoID = viatico.CrearEncabezado()
                    controlesAsociadosGuardarMemo()
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al crear el encabezado de viático." & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
                End Try
            Else
                Try
                    viatico.ActualizarEncabezado()
                    controlesAsociadosGuardarMemo()
                    If gdvDetalleViatico.RowCount > 0 Then
                        gdcViatico.DataSource = viatico.recuperarViaticoDetalle(viatico.datosEncabezado.viaticoID)
                    End If
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al actualizar encabezado de viático." & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub
    Private Sub btnEliminarMemorandum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarMemorandum.Click
        If viatico.estadoViatico(viatico.datosEncabezado.viaticoID) <> viatico.tipoEstadoViatico.PENDIENTE Then
            MessageBox.Show("Imposible eliminar el memorandum número " & txtNumeroMemo.Text & " ya se han emitidos cheques", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If gdvDetalleViatico.RowCount > 0 And MessageBox.Show("¿Seguro que desea eliminar el memorandum número " & txtNumeroMemo.Text & " junto con su detalle?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Try
                    If viatico.EliminaViaticoMaestro Then
                        limpiaControlesDetalle()
                        controlesAsociadosCancelarMemorandum()
                        MessageBox.Show("Registro eliminado correctamente", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MsgBox("Se ha producido un error al intentar eliminar el registro actual." & Chr(13) & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub
    Private Sub btnCancelarMemorandum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarMemorandum.Click
        comprobarConsistenciaViatico()
        limpiaControlesDetalle()
        controlesAsociadosCancelarMemorandum()
    End Sub
    Private Sub btnEmiteResolucion_Click_old(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cursor.Current = Cursors.WaitCursor
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptResolucionViatico
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        reporte.SetParameterValue("quienFirma", periodo.quienFirmaResolucion)
        reporte.SetParameterValue("copiaResolucion", periodo.copiasResolucion + "/" + empleado.buscaString("SELECT REPLACE(USER,'PRCHILE\','') AS USUARIO_DOMNIO"))
        ventanaReporte1.rptVisor.SelectionFormula = "{VW_VIATICOS.NRO_MEMORANDUM_INTERNO}=" & """" & CType(CType(txtNumeroMemo.Text, String), String) & """ AND {VW_VIATICOS.ANO}= " & dedFechaMemorando.DateTime.Year() & " AND {VW_VIATICOS.DEPTO_VIATICO}= " & lueDepartamento.EditValue
        ventanaReporte1.rptVisor.ShowParameterPanelButton = False
        ventanaReporte1.rptVisor.ShowCloseButton = False
        ventanaReporte1.rptVisor.ShowGroupTreeButton = False
        ventanaReporte1.rptVisor.ReportSource = reporte
        Cursor.Current = Cursors.Default
        ventanaReporte1.Show()
    End Sub

    Private Sub btnEmiteResolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmiteResolucion.Click
        If RTrim(LTrim(txtNombreDocumentoWord.Text)).Length = 0 Then
            MsgBox("Falta seleccionar documento word", MsgBoxStyle.Information, "SIGA")
            Exit Sub
        End If
        If Not File.Exists(txtNombreDocumentoWord.Text) Then
            MsgBox("No existe archivo " + txtNombreDocumentoWord.Text + " en la ruta especificada.", MsgBoxStyle.Information, "SIGA")
            Exit Sub
        End If
        If gdvDetalleViatico.RowCount > 0 Then
            GenerarDocumentoWord()
        End If
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
    End Sub
    Private Sub btnNuevoDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoDetalle.Click
        controlesAsociadosNuevoDetalle()
    End Sub

    Private Sub btnEliminaDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminaDetalle.Click
        If MessageBox.Show("¿Seguro que desea eliminar el registro actual?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Try
                If viatico.EliminaViaticoDetalle Then
                    controlesAsociadosNuevoDetalle()
                    controlesAsociadosGuardarDetalle()
                    gdcViatico.DataSource = viatico.recuperarViaticoDetalle(viatico.datosEncabezado.viaticoID)
                    MessageBox.Show("Registro eliminado correctamente", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MsgBox("Se ha producido un error al intentar eliminar el registro actual." & Chr(13) & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub btnGuardarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarDetalle.Click
        Dim respuesta As Boolean = validarDatosBasicosDetalle()

        If respuesta Then
            Dim mensaje As String
            mensaje = viatico.validaRangoFechaViatico(dedFechaInicio.Text, gleEmpleado.EditValue, txtDiasSolicitados.EditValue, viatico.datosDetalle.IdDetalle, Comun.TiposDeDatos.TipoEventoAdmin.VIATICO)
            If Len(mensaje) > 0 Then
                If MessageBox.Show(mensaje & Chr(13) & Chr(13) & "¿Desea continuar?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                    respuesta = False
                End If
            End If
            If respuesta Then
                asignacionCamposDetalle()
                If viatico.datosDetalle.IdDetalle = 0 Then
                    Try
                        viatico.CrearDetalle()
                        gdcViatico.DataSource = viatico.recuperarViaticoDetalle(viatico.datosEncabezado.viaticoID)
                        controlesAsociadosNuevoDetalle()
                        controlesAsociadosGuardarDetalle()
                    Catch ex As Exception
                        MsgBox("Ha ocurrido un error al crear detalle de viático." & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
                    End Try
                Else
                    Try
                        viatico.ActualizarDetalle()
                        gdcViatico.DataSource = viatico.recuperarViaticoDetalle(viatico.datosEncabezado.viaticoID)
                        controlesAsociadosNuevoDetalle()
                        controlesAsociadosGuardarDetalle()
                    Catch ex As Exception
                        MsgBox("Ha ocurrido un error al actualizarr detalle de viático." & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub btnCancelarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarDetalle.Click
        gpcRegistrodelViatico.Enabled = False
        gpcBotonesDetalle.Enabled = False
        gpcInformacionGeneral.Enabled = True
        gpcBotonesEncabezado.Enabled = True
        btnGuardarMemorandum.Enabled = True
        btnEliminarMemorandum.Enabled = True
        btnCancelarMemorandum.Enabled = True
        btnNuevoMemorandum.Enabled = False
        If gdvDetalleViatico.RowCount > 0 Then
            btnVisualizar.Enabled = True
            btnEmiteResolucion.Enabled = True
        Else
            btnVisualizar.Enabled = False
            btnEmiteResolucion.Enabled = False
        End If
        limpiaControlesDetalle()
    End Sub
    Private Sub gleEmpleado_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gleEmpleado.EditValueChanged
        Cursor.Current = Cursors.WaitCursor
        If gleEmpleado.EditValue <> Nothing Then
            empleado = New Empleado(CType(gleEmpleado.EditValue, Long), True)
            txtNombreEmpleado.Text = empleado.nombreCompleto
            txtFechaIngresoInstitucion.Text = empleado.datosLaborales.fechaIngresoInstitucion
            txtCalidadJuridica.Text = DataAccess.Utiles.buscaID(Tablas.RH_REM_CALIDAD_JURIDICA, "NN", "CALIDAD_JURIDICA_ID", empleado.datosLaborales.calidadJuridicaID, "DESCRIPCION")
            txtGrado.Text = DataAccess.Utiles.buscaID(Tablas.RH_REM_GRADO, "NN", "GRADO_ID", empleado.datosLaborales.gradoID, "GRADO_ALIAS")
            txtMonto100Porciento.Text = viatico.recuperaMontoViatico(empleado.datosLaborales.gradoID, periodo.calculoViaticoMesAnterior)
            txtPorcentajeaPagar.Text = periodo.porcentajeViatico
            dedFechaInicio.EditValue = Date.Now
            calculaFechaFinal()
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub txtDiasSolicitados_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiasSolicitados.EditValueChanged
        calculaFechaFinal()
    End Sub

    Private Sub dedFechaInicio_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dedFechaInicio.EditValueChanged
        calculaFechaFinal()
    End Sub
    Private Sub calculaFechaFinal()
        If dedFechaInicio.EditValue <> dedFechaInicio.OldEditValue Or txtDiasSolicitados.EditValue <> txtDiasSolicitados.OldEditValue Then
            Dim respuesta As Boolean = True
            'mensaje = viatico.validaRangoFechaViatico(dedFechaInicio.Text, gleEmpleado.EditValue, txtDiasSolicitados.EditValue, viatico.datosDetalle.IdDetalle, Comun.TiposDeDatos.TipoEventoAdmin.VIATICO)
            'If Len(mensaje) > 0 Then
            '    If MessageBox.Show(mensaje & Chr(13) & Chr(13) & "¿Desea continuar?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
            '        respuesta = False
            '    End If
            'End If
            If respuesta Then
                Try
                    dedFechaTermino.EditValue = DateAdd(DateInterval.Day, (CType(txtDiasSolicitados.Text, Double) - 1), CType(dedFechaInicio.Text, Date))
                    If gleEmpleado.EditValue <> Nothing Then
                        txtMonto.Text = Math.Round(txtMonto100Porciento.Text * (txtPorcentajeaPagar.Text / 100), 0) * txtDiasSolicitados.Text
                    End If
                Catch ex As Exception
                    MsgBox("Error al calcular fecha término viático." & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub

    Private Sub frmViatico_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        comprobarConsistenciaViatico()
    End Sub
    Function comprobarConsistenciaViatico() As Boolean
        'Si viatico no tiene detalle procede a eliminar el encabezado
        If viatico.datosEncabezado.viaticoID > 0 And gdvDetalleViatico.RowCount = 0 Then
            Try
                viatico.EliminaViaticoMaestro()
            Catch ex As Exception
                MsgBox("Se ha producido un error al eliminar el viático sin detalle." & Chr(13) & "Error " & ex.Message, MsgBoxStyle.Critical)
            End Try
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub luePais_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePais.EditValueChanged
        If luePais.EditValue <> Nothing Then
            lueRegion.Properties.Columns.Clear()
            llenarRegion()
            repositorio.dvRegiones.RowFilter = " PAIS_ID=" & luePais.EditValue
            lueRegion.Properties.DataSource = repositorio.dvRegiones
        End If
    End Sub

    Private Sub lueRegion_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueRegion.EditValueChanged
        If lueRegion.EditValue <> Nothing Then
            lueComuna.Properties.Columns.Clear()
            llenarComuna()
            repositorio.dvComunas.RowFilter = " REGION_ID=" & lueRegion.EditValue
            lueComuna.Properties.DataSource = repositorio.dvComunas
        End If
    End Sub

    Private Sub gdvDetalleViatico_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gdvDetalleViatico.DoubleClick
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        If view.GetRowCellValue(view.FocusedRowHandle, "ESTADO_VIATICO") = viatico.tipoEstadoViatico.PENDIENTE Then
            gleEmpleado.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "EMPLEADO_ID")
            rdgDestino.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "DESTINO")
            If rdgDestino.EditValue = 0 Then
                rdgDestino.SelectedIndex = 0 'Destino Nacional
            Else
                rdgDestino.SelectedIndex = 1 'Destino Internacional
            End If
            luePais.EditValue = CType(view.GetRowCellValue(view.FocusedRowHandle, "PAIS_ID"), Integer)
            lueRegion.EditValue = CType(view.GetRowCellValue(view.FocusedRowHandle, "REGION_ID"), Integer)
            llenarRegion()
            repositorio.dvRegiones.RowFilter = " PAIS_ID=" & luePais.EditValue
            lueRegion.Properties.DataSource = repositorio.dvRegiones
            lueComuna.EditValue = CType(view.GetRowCellValue(view.FocusedRowHandle, "COMUNA_ID"), Integer)
            llenarComuna()
            repositorio.dvComunas.RowFilter = " REGION_ID=" & lueRegion.EditValue
            lueComuna.Properties.DataSource = repositorio.dvComunas
            txtDiasSolicitados.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "CANTIDAD_DIAS")
            dedFechaInicio.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_INICIO")
            dedFechaTermino.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_TERMINO")
            rdgEstado.EditValue = view.GetRowCellValue(view.FocusedRowHandle, "ESTADO_VIATICO")
            txtPatenteVehiculo.Text = view.GetRowCellValue(view.FocusedRowHandle, "PATENTE_VEHICULO")
            If rdgEstado.EditValue = 0 Then
                rdgEstado.SelectedIndex = 0         'Pendiente
            Else
                If rdgEstado.EditValue = 1 Then
                    rdgEstado.SelectedIndex = 1     'Pagado con cheque
                Else
                    rdgEstado.SelectedIndex = 2     'Pagado y depositado
                End If
            End If
            viatico.datosDetalle.IdDetalle = view.GetRowCellValue(view.FocusedRowHandle, "VIATICO_DETALLE_ID")
            viatico.datosDetalle.fechaDocumento = view.GetRowCellValue(view.FocusedRowHandle, "FECHA_DOCUMENTO")
            gpcRegistrodelViatico.Enabled = True
            gpcDatosEmpleado.Enabled = False
            gpcDestino.Enabled = True
            gpcDatosdelViatico.Enabled = True
            gpcBotonesDetalle.Enabled = True
            btnEliminaDetalle.Enabled = True
            btnGuardarDetalle.Enabled = True
            btnCancelarDetalle.Enabled = True
            btnNuevoDetalle.Enabled = False
        Else
            MsgBox("Registro no puede ser editado, ya se emitió cheque.", MsgBoxStyle.Information, "SIGA")
        End If
    End Sub
    Private Sub lueNumeroMemorandum_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueNumeroMemorandum.EditValueChanged
        If lueNumeroMemorandum.EditValue <> Nothing Then
            viatico = New Viatico(lueNumeroMemorandum.EditValue)
            llenarControlesEncabezado()
            validarEstadoViatico()
        End If
    End Sub

    Private Sub lueNumeroResolucion_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueNumeroResolucion.EditValueChanged
        If lueNumeroResolucion.EditValue <> Nothing Then
            viatico = New Viatico(lueNumeroResolucion.EditValue)
            llenarControlesEncabezado()
            validarEstadoViatico()
        End If
    End Sub
    Private Sub txtNumeroMemo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNumeroMemo.Validating
        If lueDepartamento.EditValue <> Nothing And CType(txtNumeroMemo.Text, String) <> CType(viatico.datosEncabezado.numeroMemorandum, String) And viatico.buscaIDNumeroMemorandum(txtNumeroMemo.Text, periodo.ano, lueDepartamento.EditValue) > 0 Then
            txtNumeroMemo.ErrorText = "Ya existe número de memorandum para el departamento"
            e.Cancel = True
        End If
    End Sub

    Private Sub txtNumeroResolucion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNumeroResolucion.Validating
        If CType(txtNumeroResolucion.Text, Integer) <> CType(viatico.datosEncabezado.numeroResolucion, Integer) And viatico.buscaIDNumeroResolucion(txtNumeroResolucion.Text, periodo.ano) And CType(txtNumeroResolucion.Text, Integer) > 0 Then
            txtNumeroResolucion.ErrorText = "Ya existe número de resolución"
            e.Cancel = True
        End If
    End Sub
    Private Sub inicializarControles()
        inicializarControlesEncabezado()
        inicializarControlesDetalle()
    End Sub
    Private Sub inicializarControlesEncabezado()
        txtNumeroMemo.Text = ""
        dedFechaInicio.Properties.NullDate = DBNull.Value
        dedFechaResolucion.Properties.NullDate = DBNull.Value
        lueDepartamento.EditValue = Nothing
        txtMotivoViatico.Text = ""
        txtNumeroResolucion.Text = 0
        dedFechaResolucion.EditValue = ""
        viatico.datosEncabezado.viaticoID = 0
        luePeriodo.EditValue = CType(periodo.ID, Integer)
    End Sub
    Private Sub inicializarControlesDetalle()
        txtDiasSolicitados.EditValue = 1
        gleEmpleado.EditValue = Nothing
        txtNombreEmpleado.Text = ""
        txtCalidadJuridica.Text = ""
        txtGrado.Text = ""
        luePais.EditValue = 1
        lueRegion.EditValue = Nothing
        lueComuna.EditValue = Nothing
    End Sub
    Private Sub controlesAsociadosNuevoMemo()
        btnGuardarMemorandum.Enabled = True
        btnEliminarMemorandum.Enabled = False
        btnCancelarMemorandum.Enabled = True
        btnNuevoMemorandum.Enabled = False
        gpcInformacionGeneral.Enabled = True
        dedFechaMemorando.Enabled = True
        txtMotivoViatico.Enabled = True
        dedFechaResolucion.Enabled = True
        txtNumeroResolucion.Enabled = True

        dedFechaMemorando.Properties.NullDate = DBNull.Value
        dedFechaResolucion.Properties.NullDate = DBNull.Value
        gleEmpleado.EditValue = Nothing
        lueDepartamento.EditValue = Nothing
        lueNumeroMemorandum.Visible = False
        lueNumeroMemorandum.Enabled = False
        txtNumeroMemo.Visible = True
        txtNumeroMemo.Enabled = True

        lueNumeroResolucion.Visible = False
        lueNumeroResolucion.Enabled = False
        txtNumeroResolucion.Visible = True
        txtNumeroResolucion.Enabled = True
        lueDepartamento.Enabled = True
        'txtNumeroMemo.Focus()
        lueDepartamento.Focus()
        inicializarControles()
        Refresh()
    End Sub
    Private Sub controlesAsociadosGuardarMemo()
        gpcInformacionGeneral.Enabled = False
        gpcBotonesEncabezado.Enabled = False
        gpcRegistrodelViatico.Enabled = False
        gpcBotonesDetalle.Enabled = True
        btnEliminaDetalle.Enabled = False
        btnGuardarDetalle.Enabled = False
        llenarNumeroMemo()
        llenarNumeroResolucion()
        luePais.EditValue = 1
        lueRegion.EditValue = Nothing
        lueComuna.EditValue = Nothing
        controlesAsociadosGuardarNuevoMemo()
    End Sub
    Private Sub controlesAsociadosGuardarDetalle()
        gpcRegistrodelViatico.Enabled = False
        gpcBotonesDetalle.Enabled = True
        btnEliminaDetalle.Enabled = False
        btnGuardarDetalle.Enabled = False
        btnCancelarDetalle.Enabled = True
        btnNuevoDetalle.Enabled = True
    End Sub
    Private Sub controlesAsociadosNuevoDetalle()
        gpcRegistrodelViatico.Enabled = True
        gpcDatosEmpleado.Enabled = True
        gpcDestino.Enabled = True
        gpcDatosdelViatico.Enabled = True
        btnNuevoDetalle.Enabled = False
        btnGuardarDetalle.Enabled = True
        btnCancelarDetalle.Enabled = True
        If gdvDetalleViatico.RowCount = 0 Then
            luePais.EditValue = 1
            lueRegion.EditValue = Nothing
            lueComuna.EditValue = Nothing
        End If
        limpiaControlesDetalle()
    End Sub
    Private Sub controlesAsociadosGuardarNuevoMemo()
        gpcRegistrodelViatico.Enabled = False
        gpcDatosEmpleado.Enabled = False
        gpcDestino.Enabled = False
        gpcDatosdelViatico.Enabled = False
        btnNuevoDetalle.Enabled = True
        btnGuardarDetalle.Enabled = False
        btnCancelarDetalle.Enabled = True
        If gdvDetalleViatico.RowCount = 0 Then
            luePais.EditValue = 1
            lueRegion.EditValue = Nothing
            lueComuna.EditValue = Nothing
        End If
        gleEmpleado.EditValue = Nothing
        txtMonto100Porciento.Text = ""
        txtPorcentajeaPagar.Text = ""
        txtMonto.Text = ""
        viatico.datosDetalle.IdDetalle = 0
        txtNombreEmpleado.Text = ""
        txtCalidadJuridica.Text = ""
        txtGrado.Text = ""
    End Sub
    Private Sub controlesAsociadosCancelarMemorandum()
        inicializarControles()
        gdcViatico.DataSource = viatico.recuperarViaticoDetalle(0)
        llenarNumeroMemo()
        llenarNumeroResolucion()
        activarControlesIniciales()
    End Sub
    Private Sub limpiaControlesDetalle()
        gleEmpleado.EditValue = Nothing
        txtMonto100Porciento.Text = ""
        txtPorcentajeaPagar.Text = ""
        txtMonto.Text = ""
        viatico.datosDetalle.IdDetalle = 0
        txtNombreEmpleado.Text = ""
        txtCalidadJuridica.Text = ""
        txtGrado.Text = ""
    End Sub
    Private Sub llenarControlesEncabezado()
        txtNumeroMemo.EditValue = viatico.datosEncabezado.numeroMemorandum
        dedFechaMemorando.EditValue = viatico.datosEncabezado.fechaMemorandum
        txtMotivoViatico.Text = viatico.datosEncabezado.motivo
        lueDepartamento.EditValue = viatico.datosEncabezado.departamento
        If viatico.datosEncabezado.fechaResolucion = CType("01-01-1900", Date) Then
            dedFechaResolucion.Properties.NullDate = DBNull.Value
        Else
            dedFechaResolucion.EditValue = viatico.datosEncabezado.fechaResolucion
        End If
        txtNumeroResolucion.EditValue = viatico.datosEncabezado.numeroResolucion
        txtNumeroMemo.Visible = True
        txtNumeroMemo.Enabled = True
        luePeriodo.EditValue = viatico.datosEncabezado.periodoID
        lueNumeroMemorandum.Visible = False
        lueNumeroMemorandum.Enabled = False
        txtNumeroResolucion.Visible = True
        txtNumeroResolucion.Enabled = True
        lueNumeroResolucion.Visible = False
        lueNumeroResolucion.Enabled = False
        dedFechaMemorando.Enabled = True
        txtMotivoViatico.Enabled = True
        dedFechaResolucion.Enabled = True
        btnNuevoMemorandum.Enabled = False
        btnEliminarMemorandum.Enabled = True
        btnGuardarMemorandum.Enabled = True
        btnCancelarMemorandum.Enabled = True
        lueDepartamento.Enabled = True
        luePeriodo.Enabled = True
        gdcViatico.DataSource = viatico.recuperarViaticoDetalle(viatico.datosEncabezado.viaticoID)
    End Sub
    Private Sub activarControlesIniciales()
        gpcRegistrodelViatico.Enabled = False
        lueDepartamento.Enabled = False
        txtNumeroMemo.Visible = False
        txtNumeroMemo.Enabled = False
        lueNumeroMemorandum.Visible = True
        lueNumeroMemorandum.Enabled = True

        txtNumeroResolucion.Visible = False
        txtNumeroResolucion.Enabled = False
        lueNumeroResolucion.Visible = True
        lueNumeroResolucion.Enabled = True

        dedFechaMemorando.Enabled = False
        txtMotivoViatico.Enabled = False
        dedFechaResolucion.Enabled = False

        btnGuardarMemorandum.Enabled = False
        btnEliminarMemorandum.Enabled = False
        btnCancelarMemorandum.Enabled = False
        btnNuevoMemorandum.Enabled = True
        btnEmiteResolucion.Enabled = False
        btnVisualizar.Enabled = False
        luePeriodo.Enabled = False
        gpcBotonesDetalle.Enabled = False
    End Sub
    Private Sub validarEstadoViatico()
        Dim tipoEstadoViatico As Integer = viatico.estadoViatico(viatico.datosEncabezado.viaticoID)
        If tipoEstadoViatico <> viatico.tipoEstadoViatico.PENDIENTE Then
            btnGuardarMemorandum.Enabled = False
            btnEliminarMemorandum.Enabled = False
            btnCancelarMemorandum.Enabled = True
            btnNuevoMemorandum.Enabled = True
            gpcRegistrodelViatico.Enabled = False
            gpcBotonesDetalle.Enabled = False
        Else
            If gdvDetalleViatico.RowCount > 0 And tipoEstadoViatico = viatico.tipoEstadoViatico.PENDIENTE Then
                gpcBotonesDetalle.Enabled = True
                gpcRegistrodelViatico.Enabled = False
                btnEliminaDetalle.Enabled = False
                btnGuardarDetalle.Enabled = False
                btnCancelarDetalle.Enabled = True
                btnNuevoDetalle.Enabled = True
            End If
        End If
        If gdvDetalleViatico.RowCount > 0 Then
            btnVisualizar.Enabled = True
            btnEmiteResolucion.Enabled = True
        Else
            btnVisualizar.Enabled = False
            btnEmiteResolucion.Enabled = False
        End If
    End Sub
    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "Nro.Memorandum: " & txtNumeroMemo.Text & " Fecha Memorandum: " & dedFechaMemorando.Text.ToString & Chr(13) & " Resolución: " & txtNumeroResolucion.Text & " Fecha Resolución: " & dedFechaResolucion.Text.ToString
        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)
    End Sub
    Private Function validarDatosBasicosEncabezado() As Boolean
        Dim respuesta As Boolean = True
        If CType(txtNumeroMemo.Text, String).Length = 0 Then
            txtNumeroMemo.ErrorText = "Falta ingresar número de memorandum"
            respuesta = False
        End If
        If dedFechaMemorando.EditValue Is Nothing Then
            dedFechaMemorando.ErrorText = "Fecha de memorandum es incorrecta"
            respuesta = False
        End If
        If lueDepartamento.EditValue Is Nothing Then
            lueDepartamento.ErrorText = "Falta ingresar departamento"
            respuesta = False
        End If
        If CType(txtNumeroResolucion.Text, Integer) > 0 And dedFechaResolucion.EditValue = Nothing Then
            dedFechaResolucion.ErrorText = "Falta ingresar fecha resolución"
            respuesta = False
        End If
        If CType(txtNumeroResolucion.Text, Integer) = 0 And dedFechaResolucion.EditValue <> Nothing Then
            txtNumeroResolucion.ErrorText = "Falta ingresar número resolución"
            respuesta = False
        End If
        Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(luePeriodo, DevExpress.XtraEditors.LookUpEdit)
        Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
        If row("ESTADO_PERIODO") = 0 Then
            luePeriodo.ErrorText = "No puede asignar periodo que se encuentra cerrado"
            respuesta = False
        End If
        Return respuesta
    End Function
    Private Function validarDatosBasicosDetalle() As Boolean
        Dim respuesta As Boolean = True
        If CType(gleEmpleado.EditValue, Integer) <= 0 Then
            gleEmpleado.ErrorText = "Falta ingresar empleado a otorgar viático"
            respuesta = False
        End If
        If txtDiasSolicitados.EditValue <= 0 Then
            txtDiasSolicitados.ErrorText = "Falta ingresar días que corresponden al viático"
            respuesta = False
        End If
        If luePais.EditValue = Nothing Then
            luePais.ErrorText = "Falta ingresar país de destino"
            respuesta = False
        End If
        If lueRegion.EditValue = Nothing Then
            lueRegion.ErrorText = "Falta ingresar región de destino"
            respuesta = False
        End If
        If lueComuna.EditValue = Nothing Then
            lueComuna.ErrorText = "Falta ingresar comuna de destino"
            respuesta = False
        End If
        Return respuesta
    End Function
    Private Sub asignacionCampos()
        viatico.datosEncabezado.numeroMemorandum = txtNumeroMemo.EditValue
        viatico.datosEncabezado.fechaMemorandum = CDate(dedFechaMemorando.EditValue).Date
        viatico.datosEncabezado.motivo = txtMotivoViatico.EditValue
        viatico.datosEncabezado.numeroResolucion = txtNumeroResolucion.EditValue
        If dedFechaResolucion.EditValue = Nothing Then
            viatico.datosEncabezado.fechaResolucion = CType("01-01-1900", Date)
        Else
            viatico.datosEncabezado.fechaResolucion = CDate(dedFechaResolucion.EditValue).Date
        End If
        viatico.datosEncabezado.periodoID = luePeriodo.EditValue
        viatico.datosEncabezado.tipoResolucion = 0
        If viatico.datosEncabezado.viaticoID = 0 Then
            viatico.datosEncabezado.estadoRegistroViatico = 1
        End If
        viatico.datosEncabezado.tipoEventoAdmininstrativo = Comun.TiposDeDatos.TipoEventoAdmin.VIATICO
        viatico.datosEncabezado.departamento = lueDepartamento.EditValue
    End Sub
    Private Sub asignacionCamposDetalle()
        viatico.datosDetalle.cantidadDias = txtDiasSolicitados.EditValue
        viatico.datosDetalle.fechaInicio = CDate(dedFechaInicio.EditValue).Date
        viatico.datosDetalle.fechaTermino = CDate(dedFechaTermino.EditValue).Date
        viatico.datosDetalle.motivo = txtMotivoViatico.Text
        viatico.datosDetalle.paisID = luePais.EditValue
        viatico.datosDetalle.comunaID = lueComuna.EditValue
        viatico.datosDetalle.monto = txtMonto.EditValue
        viatico.datosDetalle.empleadoID = gleEmpleado.EditValue
        If viatico.datosDetalle.IdDetalle = 0 Then
            viatico.datosDetalle.numeroDocumento = ""
            viatico.datosDetalle.fechaDocumento = CType("01-01-1900", Date)
            viatico.datosDetalle.numeroEgreso = ""
        End If
        viatico.datosDetalle.regionID = lueRegion.EditValue
        viatico.datosDetalle.destino = rdgDestino.EditValue
        viatico.datosDetalle.estadoViatico = rdgEstado.EditValue
        viatico.datosDetalle.patenteVehiculo = txtPatenteVehiculo.Text
    End Sub
    Private Sub lueDepartamento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lueDepartamento.Validating
        If lueDepartamento.EditValue <> Nothing And CType(txtNumeroMemo.Text, String) <> CType(viatico.datosEncabezado.numeroMemorandum, String) And viatico.buscaIDNumeroMemorandum(txtNumeroMemo.Text, periodo.ano, lueDepartamento.EditValue) > 0 Then
            lueDepartamento.ErrorText = "Ya existe número de memorandum para el departamento"
            e.Cancel = True
        End If
    End Sub

    Private Sub luePeriodo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles luePeriodo.Validating
        'Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
        'Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
        'If row("ESTADO_PERIODO") = 0 Then
        '    luePeriodo.ErrorText = "No puede asignar periodo que se encuentra cerrado"
        '    luePeriodo.Refresh()
        '    e.Cancel = True
        'End If
    End Sub


    Private Sub GenerarDocumentoWord()
        Cursor.Current = Cursors.WaitCursor
        Dim NombreArchivoXLSX As String = System.AppDomain.CurrentDomain.BaseDirectory() + "ResolucionViatico.xlsx"
        gdcResolucion.DataSource = viatico.recuperaResolucionViaticoCabecera(viatico.datosEncabezado.viaticoID)
        gdcResolucion.ExportToXlsx(NombreArchivoXLSX)
        CrearArchivoTexto(txtNombreDocumentoWord.Text)

        WordApplication = New Word.Application()
        Dim DocumentoWordPrincipal As word.Document = WordApplication.Documents.Open(txtNombreDocumentoWord.Text)


        Dim dt As New DataTable
        dt = viatico.recuperaResolucionViatico(viatico.datosEncabezado.viaticoID)
        DocumentoWordPrincipal = InsertarTablaWord(DocumentoWordPrincipal, dt)


        With (DocumentoWordPrincipal.MailMerge)
            .OpenDataSource(Name:=NombreArchivoXLSX, _
                            ConfirmConversions:=False, _
                            ReadOnly:=False,
                            LinkToSource:=True,
                            AddToRecentFiles:=False, _
                            PasswordDocument:="",
                            PasswordTemplate:="",
                            WritePasswordDocument:="", _
                            WritePasswordTemplate:="",
                            Revert:=False, _
                            Format:=word.WdOpenFormat.wdOpenFormatAuto, _
                            Connection:="", SQLStatement:="SELECT * FROM `Sheet$`")
            .Destination = word.WdMailMergeDestination.wdSendToNewDocument
            .Execute(Pause:=False)
            'SQLStatement:="SELECT * FROM `Sheet$`"
        End With
        DocumentoWordPrincipal.Close(False, False, False)
        Cursor.Current = Cursors.Default
        Try
            WordApplication.Visible = True
            WordApplication.ShowMe()
            WordApplication = Nothing
            'ActualizarEmpleado()
            'gdcEmpleados.DataSource = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
        Finally
            If File.Exists(NombreArchivoXLSX) Then
                File.Delete(NombreArchivoXLSX)
            End If
        End Try
    End Sub

    Function InsertarTablaWord(DocumentoWord As word.Document, dt As DataTable) As word.Document
        Dim doc As word.Document = Nothing
        Dim colsNumbers As Int32 = dt.Columns.Count
        Dim rowsNumbers As Int32 = dt.Rows.Count + 1

        doc = DocumentoWord

        Dim range As word.Range = doc.Range(0, 0)
        Dim table As word.Table = doc.Tables.Add(doc.Bookmarks.Item("TablaViaticos").Range, rowsNumbers, colsNumbers)
        table.Range.Font.Size = 7
        table.Range.Font.Bold = True
        ' Insertamos los encabezados de columna de la tabla, que
        ' se corresponderán con los nombres de los campos.
        '
        For col As Int32 = 1 To colsNumbers
            Dim cell As word.Cell = table.Rows(1).Cells(col)
            cell.Range.Text = dt.Columns(col - 1).ColumnName
        Next

        ' Insertamos las filas en la tabla, comenzando por la
        ' fila número 2, ya que la primera fila está ocupada
        ' por el nombre de las columnas.
        '
        table.Range.Font.Bold = False

        For row As Int32 = 2 To table.Rows.Count
            Dim c As Int32 = 0
            For Each cell As word.Cell In table.Rows(row).Cells
                ' Insertamos el valor de las celdas.
                cell.Range.Text = dt.Rows(row - 2).Item(c).ToString
                c += 1
            Next
        Next

        ' Formateamos la tabla para que se ajuste a su contenido.
        '
        table.AutoFitBehavior(word.WdAutoFitBehavior.wdAutoFitContent)
        table.Borders.InsideLineStyle = word.WdLineStyle.wdLineStyleSingle
        table.Borders.OutsideLineStyle = word.WdLineStyle.wdLineStyleSingle
        table.Borders.OutsideLineWidth = word.WdLineWidth.wdLineWidth100pt
        Return doc
    End Function

    Private Sub LeerArchivoTexto()
        Dim PathArchivo As String = System.AppDomain.CurrentDomain.BaseDirectory() + "ResolucionViatico.txt"
        If File.Exists(PathArchivo) Then
            Dim objReader As StreamReader
            objReader = File.OpenText(PathArchivo)
            txtNombreDocumentoWord.Text = objReader.ReadLine
            objReader.Close()
        End If
    End Sub

    Private Sub CrearArchivoTexto(NombreArchivo As String)
        Dim strStreamW As Stream = Nothing
        Dim strStreamWriter As StreamWriter = Nothing
        Dim PathArchivo As String

        Try
            PathArchivo = System.AppDomain.CurrentDomain.BaseDirectory() + "ResolucionViatico.txt"
            If File.Exists(PathArchivo) Then
                File.Delete(PathArchivo)
            End If
            strStreamW = File.Create(PathArchivo)
            strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default)
            strStreamWriter.WriteLine(NombreArchivo)
            strStreamWriter.Close()
        Catch ex As Exception
            MsgBox("Error al Guardar la informacion en el archivo. " & ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
            strStreamWriter.Close()
        End Try
    End Sub

    Private Sub btnBuscarDocumentoWord_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarDocumentoWord.Click
        Dim myStream As Stream = Nothing

        Using openFileDialog1 As New OpenFileDialog() With {.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), .Filter = "Archivos Word (*.doc,*.docx)|*.doc;*.docx", .FilterIndex = 2, .RestoreDirectory = True}
            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    myStream = openFileDialog1.OpenFile()
                    If (myStream IsNot Nothing) Then
                        txtNombreDocumentoWord.Text = openFileDialog1.FileName
                    End If
                Catch Ex As Exception
                    MessageBox.Show(String.Format("No se puede leer archivo: {0}", Ex.Message))
                Finally
                    If (myStream IsNot Nothing) Then
                        myStream.Close()
                    End If
                End Try
            End If
        End Using
    End Sub
End Class
