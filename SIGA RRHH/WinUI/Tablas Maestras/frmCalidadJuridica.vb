Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmCalidadJuridica
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
    Friend WithEvents gdcCalidad As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvdetalleCalidad As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents colCALIDAD_JURIDICA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCALIDAD_JURIDICA_ALIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPERTENECE_EUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINCLUYE_CALCULO_SUELDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_DOTACION As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalidadJuridica))
        Me.gdcCalidad = New DevExpress.XtraGrid.GridControl()
        Me.gdvdetalleCalidad = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCALIDAD_JURIDICA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCALIDAD_JURIDICA_ALIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPERTENECE_EUS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colINCLUYE_CALCULO_SUELDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPO_DOTACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.gdcCalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvdetalleCalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcCalidad
        '
        Me.gdcCalidad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gdcCalidad.Location = New System.Drawing.Point(24, 64)
        Me.gdcCalidad.MainView = Me.gdvdetalleCalidad
        Me.gdcCalidad.Name = "gdcCalidad"
        Me.gdcCalidad.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtDescripcion})
        Me.gdcCalidad.Size = New System.Drawing.Size(808, 424)
        Me.gdcCalidad.TabIndex = 0
        Me.gdcCalidad.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvdetalleCalidad})
        '
        'gdvdetalleCalidad
        '
        Me.gdvdetalleCalidad.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCALIDAD_JURIDICA_ID, Me.colCALIDAD_JURIDICA_ALIAS, Me.colDESCRIPCION, Me.colPERTENECE_EUS, Me.colINCLUYE_CALCULO_SUELDO, Me.colTIPO_DOTACION})
        Me.gdvdetalleCalidad.GridControl = Me.gdcCalidad
        Me.gdvdetalleCalidad.GroupPanelText = "Arrastre aquí el encabezado de una columna para agrupar las filas."
        Me.gdvdetalleCalidad.Name = "gdvdetalleCalidad"
        Me.gdvdetalleCalidad.NewItemRowText = "Nuevo Registro"
        Me.gdvdetalleCalidad.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'colCALIDAD_JURIDICA_ID
        '
        Me.colCALIDAD_JURIDICA_ID.Caption = "Id CALIDAD_JURIDICA"
        Me.colCALIDAD_JURIDICA_ID.FieldName = "CALIDAD_JURIDICA_ID"
        Me.colCALIDAD_JURIDICA_ID.Name = "colCALIDAD_JURIDICA_ID"
        '
        'colCALIDAD_JURIDICA_ALIAS
        '
        Me.colCALIDAD_JURIDICA_ALIAS.Caption = "Alias Calidad  Jurídica"
        Me.colCALIDAD_JURIDICA_ALIAS.FieldName = "CALIDAD_JURIDICA_ALIAS"
        Me.colCALIDAD_JURIDICA_ALIAS.Name = "colCALIDAD_JURIDICA_ALIAS"
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "Descripción"
        Me.colDESCRIPCION.ColumnEdit = Me.txtDescripcion
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 0
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoHeight = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Name = "txtDescripcion"
        '
        'colPERTENECE_EUS
        '
        Me.colPERTENECE_EUS.Caption = "Pertenece EUS"
        Me.colPERTENECE_EUS.FieldName = "PERTENECE_EUS"
        Me.colPERTENECE_EUS.Name = "colPERTENECE_EUS"
        Me.colPERTENECE_EUS.Visible = True
        Me.colPERTENECE_EUS.VisibleIndex = 1
        '
        'colINCLUYE_CALCULO_SUELDO
        '
        Me.colINCLUYE_CALCULO_SUELDO.Caption = "Incluye Cálculo Sueldo"
        Me.colINCLUYE_CALCULO_SUELDO.FieldName = "INCLUYE_CALCULO_SUELDO"
        Me.colINCLUYE_CALCULO_SUELDO.Name = "colINCLUYE_CALCULO_SUELDO"
        Me.colINCLUYE_CALCULO_SUELDO.Visible = True
        Me.colINCLUYE_CALCULO_SUELDO.VisibleIndex = 2
        '
        'colTIPO_DOTACION
        '
        Me.colTIPO_DOTACION.Caption = "Tipo Dotación"
        Me.colTIPO_DOTACION.FieldName = "TIPO_DOTACION"
        Me.colTIPO_DOTACION.Name = "colTIPO_DOTACION"
        Me.colTIPO_DOTACION.Visible = True
        Me.colTIPO_DOTACION.VisibleIndex = 3
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Location = New System.Drawing.Point(720, 16)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(112, 23)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir Reporte"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gdcCalidad
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Presidencia de La República", "", "[Date Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Sistema Integral de Gestión Administrativa (SIGA)", "", "Página Número  [Page #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'frmCalidadJuridica
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 517)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.gdcCalidad)
        Me.Name = "frmCalidadJuridica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Calidad Jurídica"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcCalidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvdetalleCalidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Calidad As Mantenedor

    Private Sub frmCalidadJuridica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Calidad = New Mantenedor
        gdcCalidad.DataSource = Calidad.recuperarCalidad
    End Sub

    Private Sub gdvdetalleCalidad_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvdetalleCalidad.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gdvdetalleCalidad_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvdetalleCalidad.RowUpdated
        If Calidad.actualizarCalidad Then
            gdcCalidad.Refresh()
            repositorio.RefreshDatos("CalidadJuridica")
        End If
    End Sub

    Private Sub gdvdetalleCalidad_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdvdetalleCalidad.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                Try
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                    view.DeleteRow(view.FocusedRowHandle)
                    Calidad.actualizarCalidad()
                    gdcCalidad.Refresh()
                    MsgBox("Registro fue eliminado correctamente", MsgBoxStyle.Exclamation)
                    repositorio.RefreshDatos("CalidadJuridica")
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error al intentar eliminar el registro " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If

            gdcCalidad.DataSource = Calidad.recuperarCalidad
        End If
    End Sub

    Private Sub gdvdetalleCalidad_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvdetalleCalidad.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = sender
        'view.SetRowCellValue(e.RowHandle, "ORGANIZACION_ID", Comun.ArgoConfiguracion.OrganizacionID)
        view.SetRowCellValue(e.RowHandle, "CALIDAD_JURIDICA_ALIAS", 0)

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
End Class
