Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmAsignacionFamiliar
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
    Friend WithEvents gdvDetalleCarga As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TRAMO_ASIGNACION_FAMILIAR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MONTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CODIGO_PREVIRED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents gdcCarga As DevExpress.XtraGrid.GridControl
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents btnActualizarHaciaMovimientoMensual As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Progreso As System.Windows.Forms.ProgressBar
    Friend WithEvents txtMonto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignacionFamiliar))
        Me.gdcCarga = New DevExpress.XtraGrid.GridControl()
        Me.gdvDetalleCarga = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TRAMO_ASIGNACION_FAMILIAR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.MONTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMonto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.CODIGO_PREVIRED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCodigo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.btnActualizarHaciaMovimientoMensual = New DevExpress.XtraEditors.SimpleButton()
        Me.Progreso = New System.Windows.Forms.ProgressBar()
        CType(Me.gdcCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcCarga
        '
        Me.gdcCarga.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcCarga.Location = New System.Drawing.Point(24, 80)
        Me.gdcCarga.MainView = Me.gdvDetalleCarga
        Me.gdcCarga.Name = "gdcCarga"
        Me.gdcCarga.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtDescripcion, Me.txtCodigo, Me.txtMonto})
        Me.gdcCarga.Size = New System.Drawing.Size(808, 408)
        Me.gdcCarga.TabIndex = 0
        Me.gdcCarga.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleCarga})
        '
        'gdvDetalleCarga
        '
        Me.gdvDetalleCarga.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TRAMO_ASIGNACION_FAMILIAR_ID, Me.DESCRIPCION, Me.MONTO, Me.CODIGO_PREVIRED})
        Me.gdvDetalleCarga.GridControl = Me.gdcCarga
        Me.gdvDetalleCarga.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvDetalleCarga.Name = "gdvDetalleCarga"
        Me.gdvDetalleCarga.NewItemRowText = "Nuevo Registro"
        Me.gdvDetalleCarga.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'TRAMO_ASIGNACION_FAMILIAR_ID
        '
        Me.TRAMO_ASIGNACION_FAMILIAR_ID.Caption = "Id TRAMO ASIGNACION FAMILIAR"
        Me.TRAMO_ASIGNACION_FAMILIAR_ID.FieldName = "TRAMO_ASIGNACION_FAMILIAR_ID"
        Me.TRAMO_ASIGNACION_FAMILIAR_ID.Name = "TRAMO_ASIGNACION_FAMILIAR_ID"
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.Caption = "Descripción"
        Me.DESCRIPCION.ColumnEdit = Me.txtDescripcion
        Me.DESCRIPCION.FieldName = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.Visible = True
        Me.DESCRIPCION.VisibleIndex = 0
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoHeight = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Name = "txtDescripcion"
        '
        'MONTO
        '
        Me.MONTO.Caption = "Monto"
        Me.MONTO.ColumnEdit = Me.txtMonto
        Me.MONTO.FieldName = "MONTO"
        Me.MONTO.Name = "MONTO"
        Me.MONTO.Visible = True
        Me.MONTO.VisibleIndex = 1
        '
        'txtMonto
        '
        Me.txtMonto.AutoHeight = False
        Me.txtMonto.DisplayFormat.FormatString = "n0"
        Me.txtMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.EditFormat.FormatString = "n0"
        Me.txtMonto.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.Mask.EditMask = "n0"
        Me.txtMonto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMonto.Mask.UseMaskAsDisplayFormat = True
        Me.txtMonto.Name = "txtMonto"
        '
        'CODIGO_PREVIRED
        '
        Me.CODIGO_PREVIRED.Caption = "Código PREVIRED"
        Me.CODIGO_PREVIRED.ColumnEdit = Me.txtCodigo
        Me.CODIGO_PREVIRED.FieldName = "CODIGO_PREVIRED"
        Me.CODIGO_PREVIRED.Name = "CODIGO_PREVIRED"
        Me.CODIGO_PREVIRED.Visible = True
        Me.CODIGO_PREVIRED.VisibleIndex = 2
        '
        'txtCodigo
        '
        Me.txtCodigo.AutoHeight = False
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Name = "txtCodigo"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Location = New System.Drawing.Point(632, 8)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(200, 23)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir Reporte"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcCarga
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de La República", "", "[Date Printed]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Sistema Integral de Gestión Administrativa (SIGA)", "", "Página Número  [Page #]"}, New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'btnActualizarHaciaMovimientoMensual
        '
        Me.btnActualizarHaciaMovimientoMensual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizarHaciaMovimientoMensual.Location = New System.Drawing.Point(632, 40)
        Me.btnActualizarHaciaMovimientoMensual.Name = "btnActualizarHaciaMovimientoMensual"
        Me.btnActualizarHaciaMovimientoMensual.Size = New System.Drawing.Size(200, 23)
        Me.btnActualizarHaciaMovimientoMensual.TabIndex = 2
        Me.btnActualizarHaciaMovimientoMensual.Text = "Actualizar Hacia Movimiento Mensual"
        '
        'Progreso
        '
        Me.Progreso.Location = New System.Drawing.Point(24, 40)
        Me.Progreso.Name = "Progreso"
        Me.Progreso.Size = New System.Drawing.Size(600, 23)
        Me.Progreso.TabIndex = 3
        '
        'frmAsignacionFamiliar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 517)
        Me.Controls.Add(Me.Progreso)
        Me.Controls.Add(Me.btnActualizarHaciaMovimientoMensual)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.gdcCarga)
        Me.Name = "frmAsignacionFamiliar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Asignacion Familiar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Carga As Mantenedor
    Dim empleado As empleado
    Dim periodo As Periodo


    Private Sub frmAsignacionFamiliar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Carga = New Mantenedor
        gdcCarga.DataSource = Carga.recuperarCarga
        Progreso.Visible = False
        If gdvDetalleCarga.RowCount = 0 Then
            btnActualizarHaciaMovimientoMensual.Enabled = False
        End If
    End Sub


    Private Sub gdvDetalleCarga_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvDetalleCarga.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gdvDetalleCarga_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvDetalleCarga.RowUpdated
        If Carga.actualizarCarga Then
            gdcCarga.Refresh()
            repositorio.RefreshDatos("TramoAsignacionFamiliar")
            If gdvDetalleCarga.RowCount = 0 Then
                btnActualizarHaciaMovimientoMensual.Enabled = False
            End If
        End If
    End Sub

    Private Sub gdvDetalleCarga_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvDetalleCarga.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                Try
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                    view.DeleteRow(view.FocusedRowHandle)
                    Carga.actualizarCarga()
                    gdcCarga.Refresh()
                    MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)
                    repositorio.RefreshDatos("TramoAsignacionFamiliar")
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al intentar eliminar el registro." & Chr(13) & Chr(13) & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
            gdcCarga.DataSource = Carga.recuperarCarga
            repositorio.RefreshDatos("TramoAsignacionFamiliar")
            If gdvDetalleCarga.RowCount = 0 Then
                btnActualizarHaciaMovimientoMensual.Enabled = False
            End If
        End If
    End Sub

    Private Sub gdvDetalleCarga_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvDetalleCarga.InitNewRow
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = ""
        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 14, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub btnActualizarHaciaMovimientoMensual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarHaciaMovimientoMensual.Click
        If MessageBox.Show("¿Está seguro de actualizar hacia movimiento mensual los montos de la" + Chr(13) + "asignación familiar según los tramos definidos en la ficha del empleado?", "Tablas Maestras", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            btnActualizarHaciaMovimientoMensual.Enabled = False
            Progreso.Visible = True
            empleado = New empleado
            Dim dtEmpleados As DataTable
            Dim fila As Data.DataRow
            Dim reg_actualizados As Integer = 0
            Dim numero_registros As Integer = 0
            Dim origen As Integer = 2
            Dim tipoProceso As String = "N"

            periodo = New periodo
            Progreso.Minimum = 0
            dtEmpleados = empleado.recuperaEmpleadosActivos
            Progreso.Maximum = dtEmpleados.Rows.Count - 1
            Try
                empleado.EliminarEmpleadoMovimientoMensual(periodo.ID, periodo.itemAsignacionFamiliar, origen, tipoProceso)
                Try
                    For Each fila In dtEmpleados.Rows
                        empleado = New empleado(fila("EMPLEADO_ID"), True)
                        If (empleado.datosRemuneracion.cargaFamiliarNormal > 0 Or empleado.datosRemuneracion.cargaFamiliarPrenatal > 0 Or empleado.datosRemuneracion.cargaFamiliarInvalida > 0) And (empleado.estadoEmpleadoID <> Comun.TiposDeDatos.TipoEstado.INACTIVO) And (empleado.datosLaborales.calidadJuridicaID = Comun.TiposDeDatos.TipoCalidadJuridica.CONTRATA Or empleado.datosLaborales.calidadJuridicaID = Comun.TiposDeDatos.TipoCalidadJuridica.PLANTA) Then
                            reg_actualizados += 1
                            empleado.generaAsignacionFamiliarEmpleado(empleado, periodo, origen, tipoProceso)
                        End If
                        Progreso.Value = numero_registros
                        numero_registros += 1
                    Next
                    System.Windows.Forms.MessageBox.Show("Se han leído " & numero_registros & " del maestro de empleados." & Chr(13) & "Se han guardado " & reg_actualizados & " registros de asignación familiar en movimiento mensual.", "Sistema de Remuneraciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Progreso.Visible = False
                    btnActualizarHaciaMovimientoMensual.Enabled = True
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al crear itemes de asignación familiar " & empleado.nombreCompleto & Chr(13) & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            Catch ex As Exception
                MsgBox("Ha ocurrido un error al eliminar itemes de asignación familiar." & Chr(13) & ex.Message, MsgBoxStyle.Exclamation)
                Progreso.Visible = False
                btnActualizarHaciaMovimientoMensual.Enabled = True
            End Try
        End If
    End Sub
End Class
