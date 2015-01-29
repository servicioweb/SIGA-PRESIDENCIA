Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.SqlClient
Public Class frmCambioEstadoCargaFamiliar
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
    Friend WithEvents gdcCargasFamiliares As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvCargasFamiliares As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gdcCargasFamiliares = New DevExpress.XtraGrid.GridControl
        Me.gdvCargasFamiliares = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.gdcCargasFamiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvCargasFamiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcCargasFamiliares
        '
        '
        'gdcCargasFamiliares.EmbeddedNavigator
        '
        Me.gdcCargasFamiliares.EmbeddedNavigator.Name = ""
        Me.gdcCargasFamiliares.Location = New System.Drawing.Point(8, 8)
        Me.gdcCargasFamiliares.MainView = Me.gdvCargasFamiliares
        Me.gdcCargasFamiliares.Name = "gdcCargasFamiliares"
        Me.gdcCargasFamiliares.Size = New System.Drawing.Size(768, 408)
        Me.gdcCargasFamiliares.TabIndex = 1
        Me.gdcCargasFamiliares.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvCargasFamiliares, Me.GridView1})
        '
        'gdvCargasFamiliares
        '
        Me.gdvCargasFamiliares.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.gdvCargasFamiliares.GridControl = Me.gdcCargasFamiliares
        Me.gdvCargasFamiliares.Name = "gdvCargasFamiliares"
        Me.gdvCargasFamiliares.OptionsNavigation.EnterMoveNextColumn = True
        Me.gdvCargasFamiliares.OptionsSelection.InvertSelection = True
        Me.gdvCargasFamiliares.OptionsSelection.MultiSelect = True
        Me.gdvCargasFamiliares.OptionsView.ColumnAutoWidth = False
        Me.gdvCargasFamiliares.SynchronizeClones = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "EMPLEADO"
        Me.GridColumn1.FieldName = "EMPLEADO"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "CARGA FAMILIAR"
        Me.GridColumn2.FieldName = "NOMBRE_COMPLETO_CARGA"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "FECHA NACIMIENTO"
        Me.GridColumn3.FieldName = "FECHA_NACIMIENTO"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "EDAD"
        Me.GridColumn4.FieldName = "EDAD"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "CARGA_FAMILIAR_ID"
        Me.GridColumn5.FieldName = "CARGA_FAMILIAR_ID"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcCargasFamiliares
        Me.GridView1.Name = "GridView1"
        '
        'frmCambioEstadoCargaFamiliar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(784, 510)
        Me.Controls.Add(Me.gdcCargasFamiliares)
        Me.Name = "frmCambioEstadoCargaFamiliar"
        Me.Text = "Estado de Carga Familiar"
        CType(Me.gdcCargasFamiliares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvCargasFamiliares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim empleado As empleado
    Private Sub frmCambioEstadoCargaFamiliar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        gdcCargasFamiliares.DataSource = empleado.recuperaCargasFamiliaresConEstado

    End Sub
End Class
