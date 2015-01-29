Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmCargaFamiliarActualizaFichaEmpleado
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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gdcCargasFamiliaresActualizarFicha As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvDetalleCargasFamiliaresActualizarFicha As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnEmiteDetalleCargasporActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents prsCargasFamActualizaFichaEmpleado As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents btnActualizarFichaEmpleado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCARGAS_FAM_NORMALES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCARGAS_FAM_INVALIDAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCARGAS_FAM_PRENATAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCARGA_SIMPLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCARGA_INVALIDEZ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCARGA_PRENATAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_COMPLETO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION_TRAMO_ASIG_FAM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION_CALIDAD_JURIDICA As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition6 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargaFamiliarActualizaFichaEmpleado))
        Me.colCARGAS_FAM_NORMALES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCARGAS_FAM_INVALIDAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCARGAS_FAM_PRENATAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCARGA_SIMPLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCARGA_INVALIDEZ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCARGA_PRENATAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gdcCargasFamiliaresActualizarFicha = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleCargasFamiliaresActualizarFicha = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_COMPLETO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION_TRAMO_ASIG_FAM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION_CALIDAD_JURIDICA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnEmiteDetalleCargasporActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.prsCargasFamActualizaFichaEmpleado = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.btnActualizarFichaEmpleado = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gdcCargasFamiliaresActualizarFicha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleCargasFamiliaresActualizarFicha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prsCargasFamActualizaFichaEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colCARGAS_FAM_NORMALES
        '
        Me.colCARGAS_FAM_NORMALES.Caption = "Carga Simple "
        Me.colCARGAS_FAM_NORMALES.FieldName = "CARGAS_FAM_NORMALES"
        Me.colCARGAS_FAM_NORMALES.Name = "colCARGAS_FAM_NORMALES"
        Me.colCARGAS_FAM_NORMALES.OptionsColumn.ReadOnly = True
        Me.colCARGAS_FAM_NORMALES.Visible = True
        Me.colCARGAS_FAM_NORMALES.VisibleIndex = 4
        Me.colCARGAS_FAM_NORMALES.Width = 131
        '
        'colCARGAS_FAM_INVALIDAS
        '
        Me.colCARGAS_FAM_INVALIDAS.Caption = "Carga Invalidez"
        Me.colCARGAS_FAM_INVALIDAS.FieldName = "CARGAS_FAM_INVALIDAS"
        Me.colCARGAS_FAM_INVALIDAS.Name = "colCARGAS_FAM_INVALIDAS"
        Me.colCARGAS_FAM_INVALIDAS.OptionsColumn.ReadOnly = True
        Me.colCARGAS_FAM_INVALIDAS.Visible = True
        Me.colCARGAS_FAM_INVALIDAS.VisibleIndex = 5
        Me.colCARGAS_FAM_INVALIDAS.Width = 121
        '
        'colCARGAS_FAM_PRENATAL
        '
        Me.colCARGAS_FAM_PRENATAL.Caption = "Carga Prenatal "
        Me.colCARGAS_FAM_PRENATAL.FieldName = "CARGAS_FAM_PRENATAL"
        Me.colCARGAS_FAM_PRENATAL.Name = "colCARGAS_FAM_PRENATAL"
        Me.colCARGAS_FAM_PRENATAL.OptionsColumn.ReadOnly = True
        Me.colCARGAS_FAM_PRENATAL.Visible = True
        Me.colCARGAS_FAM_PRENATAL.VisibleIndex = 6
        Me.colCARGAS_FAM_PRENATAL.Width = 112
        '
        'colCARGA_SIMPLE
        '
        Me.colCARGA_SIMPLE.Caption = "Carga Simple Personal"
        Me.colCARGA_SIMPLE.FieldName = "CARGA_SIMPLE"
        Me.colCARGA_SIMPLE.Name = "colCARGA_SIMPLE"
        Me.colCARGA_SIMPLE.OptionsColumn.ReadOnly = True
        Me.colCARGA_SIMPLE.Visible = True
        Me.colCARGA_SIMPLE.VisibleIndex = 1
        Me.colCARGA_SIMPLE.Width = 117
        '
        'colCARGA_INVALIDEZ
        '
        Me.colCARGA_INVALIDEZ.Caption = "Carga Invalidez Personal"
        Me.colCARGA_INVALIDEZ.FieldName = "CARGA_INVALIDEZ"
        Me.colCARGA_INVALIDEZ.Name = "colCARGA_INVALIDEZ"
        Me.colCARGA_INVALIDEZ.OptionsColumn.ReadOnly = True
        Me.colCARGA_INVALIDEZ.Visible = True
        Me.colCARGA_INVALIDEZ.VisibleIndex = 2
        Me.colCARGA_INVALIDEZ.Width = 116
        '
        'colCARGA_PRENATAL
        '
        Me.colCARGA_PRENATAL.Caption = "Carga Prenatal Personal"
        Me.colCARGA_PRENATAL.FieldName = "CARGA_PRENATAL"
        Me.colCARGA_PRENATAL.Name = "colCARGA_PRENATAL"
        Me.colCARGA_PRENATAL.OptionsColumn.ReadOnly = True
        Me.colCARGA_PRENATAL.Visible = True
        Me.colCARGA_PRENATAL.VisibleIndex = 3
        Me.colCARGA_PRENATAL.Width = 118
        '
        'gdcCargasFamiliaresActualizarFicha
        '
        Me.gdcCargasFamiliaresActualizarFicha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcCargasFamiliaresActualizarFicha.Location = New System.Drawing.Point(8, 48)
        Me.gdcCargasFamiliaresActualizarFicha.MainView = Me.gdvDetalleCargasFamiliaresActualizarFicha
        Me.gdcCargasFamiliaresActualizarFicha.Name = "gdcCargasFamiliaresActualizarFicha"
        Me.gdcCargasFamiliaresActualizarFicha.Size = New System.Drawing.Size(856, 424)
        Me.gdcCargasFamiliaresActualizarFicha.TabIndex = 0
        Me.gdcCargasFamiliaresActualizarFicha.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleCargasFamiliaresActualizarFicha, Me.GridView1})
        '
        'gdvDetalleCargasFamiliaresActualizarFicha
        '
        Me.gdvDetalleCargasFamiliaresActualizarFicha.ColumnPanelRowHeight = 3
        Me.gdvDetalleCargasFamiliaresActualizarFicha.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEMPLEADO_ID, Me.colNOMBRE_COMPLETO, Me.colCARGA_SIMPLE, Me.colCARGA_INVALIDEZ, Me.colCARGA_PRENATAL, Me.colCARGAS_FAM_NORMALES, Me.colCARGAS_FAM_INVALIDAS, Me.colCARGAS_FAM_PRENATAL, Me.colDESCRIPCION_TRAMO_ASIG_FAM, Me.colMONTO, Me.colDESCRIPCION_CALIDAD_JURIDICA})
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.colCARGAS_FAM_NORMALES
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition1.Value1 = 0
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.colCARGAS_FAM_INVALIDAS
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition2.Value1 = 0
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.Column = Me.colCARGAS_FAM_PRENATAL
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition3.Value1 = 0
        StyleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition4.Appearance.Options.UseForeColor = True
        StyleFormatCondition4.Column = Me.colCARGA_SIMPLE
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition4.Value1 = 0
        StyleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition5.Appearance.Options.UseForeColor = True
        StyleFormatCondition5.Column = Me.colCARGA_INVALIDEZ
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition5.Value1 = 0
        StyleFormatCondition6.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition6.Appearance.Options.UseForeColor = True
        StyleFormatCondition6.Column = Me.colCARGA_PRENATAL
        StyleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition6.Value1 = 0
        Me.gdvDetalleCargasFamiliaresActualizarFicha.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4, StyleFormatCondition5, StyleFormatCondition6})
        Me.gdvDetalleCargasFamiliaresActualizarFicha.GridControl = Me.gdcCargasFamiliaresActualizarFicha
        Me.gdvDetalleCargasFamiliaresActualizarFicha.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvDetalleCargasFamiliaresActualizarFicha.Name = "gdvDetalleCargasFamiliaresActualizarFicha"
        Me.gdvDetalleCargasFamiliaresActualizarFicha.OptionsSelection.InvertSelection = True
        Me.gdvDetalleCargasFamiliaresActualizarFicha.OptionsSelection.MultiSelect = True
        Me.gdvDetalleCargasFamiliaresActualizarFicha.OptionsView.ColumnAutoWidth = False
        Me.gdvDetalleCargasFamiliaresActualizarFicha.OptionsView.ShowDetailButtons = False
        '
        'colEMPLEADO_ID
        '
        Me.colEMPLEADO_ID.Caption = "Id Empleado"
        Me.colEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.colEMPLEADO_ID.Name = "colEMPLEADO_ID"
        Me.colEMPLEADO_ID.OptionsColumn.ReadOnly = True
        '
        'colNOMBRE_COMPLETO
        '
        Me.colNOMBRE_COMPLETO.Caption = "Nombre Empleado"
        Me.colNOMBRE_COMPLETO.FieldName = "NOMBRE_COMPLETO"
        Me.colNOMBRE_COMPLETO.Name = "colNOMBRE_COMPLETO"
        Me.colNOMBRE_COMPLETO.OptionsColumn.ReadOnly = True
        Me.colNOMBRE_COMPLETO.Visible = True
        Me.colNOMBRE_COMPLETO.VisibleIndex = 0
        Me.colNOMBRE_COMPLETO.Width = 250
        '
        'colDESCRIPCION_TRAMO_ASIG_FAM
        '
        Me.colDESCRIPCION_TRAMO_ASIG_FAM.Caption = "Tramo Asig.Familiar"
        Me.colDESCRIPCION_TRAMO_ASIG_FAM.FieldName = "DESCRIPCION_TRAMO_ASIG_FAM"
        Me.colDESCRIPCION_TRAMO_ASIG_FAM.Name = "colDESCRIPCION_TRAMO_ASIG_FAM"
        Me.colDESCRIPCION_TRAMO_ASIG_FAM.OptionsColumn.ReadOnly = True
        Me.colDESCRIPCION_TRAMO_ASIG_FAM.Visible = True
        Me.colDESCRIPCION_TRAMO_ASIG_FAM.VisibleIndex = 7
        Me.colDESCRIPCION_TRAMO_ASIG_FAM.Width = 148
        '
        'colMONTO
        '
        Me.colMONTO.Caption = "Monto Tramo"
        Me.colMONTO.FieldName = "MONTO"
        Me.colMONTO.Name = "colMONTO"
        Me.colMONTO.OptionsColumn.ReadOnly = True
        Me.colMONTO.Visible = True
        Me.colMONTO.VisibleIndex = 8
        Me.colMONTO.Width = 163
        '
        'colDESCRIPCION_CALIDAD_JURIDICA
        '
        Me.colDESCRIPCION_CALIDAD_JURIDICA.Caption = "Calidad Jurídica"
        Me.colDESCRIPCION_CALIDAD_JURIDICA.FieldName = "DESCRIPCION_CALIDAD_JURIDICA"
        Me.colDESCRIPCION_CALIDAD_JURIDICA.Name = "colDESCRIPCION_CALIDAD_JURIDICA"
        Me.colDESCRIPCION_CALIDAD_JURIDICA.OptionsColumn.ReadOnly = True
        Me.colDESCRIPCION_CALIDAD_JURIDICA.Visible = True
        Me.colDESCRIPCION_CALIDAD_JURIDICA.VisibleIndex = 9
        Me.colDESCRIPCION_CALIDAD_JURIDICA.Width = 182
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcCargasFamiliaresActualizarFicha
        Me.GridView1.Name = "GridView1"
        '
        'btnEmiteDetalleCargasporActualizar
        '
        Me.btnEmiteDetalleCargasporActualizar.Location = New System.Drawing.Point(112, 16)
        Me.btnEmiteDetalleCargasporActualizar.Name = "btnEmiteDetalleCargasporActualizar"
        Me.btnEmiteDetalleCargasporActualizar.Size = New System.Drawing.Size(248, 23)
        Me.btnEmiteDetalleCargasporActualizar.TabIndex = 1
        Me.btnEmiteDetalleCargasporActualizar.Text = "Emite Detalle Cargas por Actualizar"
        '
        'prsCargasFamActualizaFichaEmpleado
        '
        Me.prsCargasFamActualizaFichaEmpleado.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcCargasFamiliaresActualizarFicha
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(57, 34, 100, 100)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de la República", "", "Fecha Emisión:[Date Printed]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pagina :[Page # of Pages #]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"", "", "Emitido por:[User Name]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center))
        Me.PrintableComponentLink1.PrintingSystem = Me.prsCargasFamActualizaFichaEmpleado
        Me.PrintableComponentLink1.PrintingSystemBase = Me.prsCargasFamActualizaFichaEmpleado
        '
        'btnActualizarFichaEmpleado
        '
        Me.btnActualizarFichaEmpleado.Location = New System.Drawing.Point(464, 16)
        Me.btnActualizarFichaEmpleado.Name = "btnActualizarFichaEmpleado"
        Me.btnActualizarFichaEmpleado.Size = New System.Drawing.Size(248, 23)
        Me.btnActualizarFichaEmpleado.TabIndex = 2
        Me.btnActualizarFichaEmpleado.Text = "Transferir a Remuneraciones"
        '
        'frmCargaFamiliarActualizaFichaEmpleado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(880, 478)
        Me.Controls.Add(Me.btnActualizarFichaEmpleado)
        Me.Controls.Add(Me.btnEmiteDetalleCargasporActualizar)
        Me.Controls.Add(Me.gdcCargasFamiliaresActualizarFicha)
        Me.Name = "frmCargaFamiliarActualizaFichaEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualiza Carga Familiar Hacia Ficha Empleado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcCargasFamiliaresActualizarFicha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleCargasFamiliaresActualizarFicha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prsCargasFamActualizaFichaEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private empleado As empleado
    Private parametroMensual As Periodo

    Private Sub frmCargaFamiliarActualizaFichaEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empleado = New empleado
        parametroMensual = New Periodo
        cargaGrilla()
    End Sub
    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "Detalle Cargas Familiar para Actualizar hacia Ficha Empleado "
        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)
    End Sub
    Private Sub btnEmiteDetalleCargasporActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmiteDetalleCargasporActualizar.Click
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub btnActualizarFichaEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarFichaEmpleado.Click
        Dim numRegistros As Integer = gdvDetalleCargasFamiliaresActualizarFicha.GetSelectedRows().Length
        If numRegistros <= 0 Then
            MessageBox.Show("Debe seleccionar a lo menos una fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If MessageBox.Show("¿Está seguro que desea actualizar carga familiar hacia la ficha del empleado?", "Remuneraciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim filas() As Integer = gdvDetalleCargasFamiliaresActualizarFicha.GetSelectedRows()
            Dim i, cantidadRegistros As Integer
            Dim validaUpdate As Boolean = False
            Cursor.Current = Cursors.WaitCursor
            For i = 0 To filas.Length - 1
                Dim row As DataRow = gdvDetalleCargasFamiliaresActualizarFicha.GetDataRow(filas(i))
                empleado = New empleado(CType(row("EMPLEADO_ID"), Long))
                empleado.datosRemuneracion.cargaFamiliarNormal = row("CARGA_SIMPLE")
                empleado.datosRemuneracion.cargaFamiliarInvalida = row("CARGA_INVALIDEZ")
                empleado.datosRemuneracion.cargaFamiliarPrenatal = row("CARGA_PRENATAL")
                validaUpdate = False
                Try
                    'Actualizar un registro
                    empleado.actualizarDatosRemun(empleado.datosRemuneracion)
                    validaUpdate = True
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al actualizar " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                End Try

                If validaUpdate Then
                    Dim origen As Integer = 2
                    Dim tipoProceso As String = "N"
                    Try
                        empleado.CrearItemEmpleado(empleado, parametroMensual, origen, tipoProceso)
                    Catch ex As Exception
                        MsgBox("Ha ocurrido un error al intentar crear el items para el empleado " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                End If
                cantidadRegistros += 1
            Next i
            System.Windows.Forms.MessageBox.Show("Actualización Finalizada. Se han actualizado " & cantidadRegistros & " ficha de empleado.", "Sistema de Remuneraciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cargaGrilla()
            Cursor.Current = Cursors.Default
        End If
    End Sub
    Private Sub cargaGrilla()
        gdcCargasFamiliaresActualizarFicha.DataSource = empleado.dvCargasFamiliaresActualizaFichaEmpleado
        If empleado.dvCargasFamiliaresActualizaFichaEmpleado.Count > 0 Then
            btnActualizarFichaEmpleado.Enabled = True
            btnEmiteDetalleCargasporActualizar.Enabled = True
        Else
            btnActualizarFichaEmpleado.Enabled = True
            btnEmiteDetalleCargasporActualizar.Enabled = True
        End If
    End Sub
End Class
