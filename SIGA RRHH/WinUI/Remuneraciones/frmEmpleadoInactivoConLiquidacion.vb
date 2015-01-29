Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data.SqlClient
Imports System.Xml

Public Class frmEmpleadoInactivoConLiquidacion
    Inherits System.Windows.Forms.Form
    Private Shared _Form As frmEmpleadoInactivoConLiquidacion = Nothing

    Public Shared Property DefInstance() As frmEmpleadoInactivoConLiquidacion
        Get
            If _Form Is Nothing OrElse _Form.IsDisposed Then
                _Form = New frmEmpleadoInactivoConLiquidacion
            Else
                _Form.BringToFront()
            End If
            Return _Form
        End Get

        Set(ByVal value As frmEmpleadoInactivoConLiquidacion)
            _Form = value
        End Set
    End Property

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
    Friend WithEvents gdcEmpleadoInactivo As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvEmpleadoInactivo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dvEmpleadosInactivosconLiquidacion As System.Data.DataView
    Friend WithEvents EMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOMBRE_COMPLETO_EMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESC_ESTADO_EMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnElimina As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gdcEmpleadoInactivo = New DevExpress.XtraGrid.GridControl
        Me.gdvEmpleadoInactivo = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.EMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NOMBRE_COMPLETO_EMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DESC_ESTADO_EMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.dvEmpleadosInactivosconLiquidacion = New System.Data.DataView
        Me.btnElimina = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        CType(Me.gdcEmpleadoInactivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvEmpleadoInactivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEmpleadosInactivosconLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gdcEmpleadoInactivo
        '
        '
        'gdcEmpleadoInactivo.EmbeddedNavigator
        '
        Me.gdcEmpleadoInactivo.EmbeddedNavigator.Name = ""
        Me.gdcEmpleadoInactivo.Location = New System.Drawing.Point(8, 8)
        Me.gdcEmpleadoInactivo.MainView = Me.gdvEmpleadoInactivo
        Me.gdcEmpleadoInactivo.Name = "gdcEmpleadoInactivo"
        Me.gdcEmpleadoInactivo.Size = New System.Drawing.Size(656, 248)
        Me.gdcEmpleadoInactivo.TabIndex = 0
        Me.gdcEmpleadoInactivo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvEmpleadoInactivo, Me.GridView1})
        '
        'gdvEmpleadoInactivo
        '
        Me.gdvEmpleadoInactivo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.EMPLEADO_ID, Me.NOMBRE_COMPLETO_EMPLEADO, Me.DESC_ESTADO_EMPLEADO})
        Me.gdvEmpleadoInactivo.GridControl = Me.gdcEmpleadoInactivo
        Me.gdvEmpleadoInactivo.Name = "gdvEmpleadoInactivo"
        Me.gdvEmpleadoInactivo.OptionsSelection.MultiSelect = True
        Me.gdvEmpleadoInactivo.OptionsView.ShowGroupPanel = False
        '
        'EMPLEADO_ID
        '
        Me.EMPLEADO_ID.Caption = "ID Empleado"
        Me.EMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.EMPLEADO_ID.Name = "EMPLEADO_ID"
        Me.EMPLEADO_ID.OptionsColumn.AllowEdit = False
        Me.EMPLEADO_ID.OptionsColumn.ReadOnly = True
        Me.EMPLEADO_ID.Visible = True
        Me.EMPLEADO_ID.VisibleIndex = 0
        Me.EMPLEADO_ID.Width = 91
        '
        'NOMBRE_COMPLETO_EMPLEADO
        '
        Me.NOMBRE_COMPLETO_EMPLEADO.Caption = "Nombre Empleado"
        Me.NOMBRE_COMPLETO_EMPLEADO.FieldName = "NOMBRE_COMPLETO_EMPLEADO"
        Me.NOMBRE_COMPLETO_EMPLEADO.Name = "NOMBRE_COMPLETO_EMPLEADO"
        Me.NOMBRE_COMPLETO_EMPLEADO.OptionsColumn.AllowEdit = False
        Me.NOMBRE_COMPLETO_EMPLEADO.OptionsColumn.ReadOnly = True
        Me.NOMBRE_COMPLETO_EMPLEADO.Visible = True
        Me.NOMBRE_COMPLETO_EMPLEADO.VisibleIndex = 1
        Me.NOMBRE_COMPLETO_EMPLEADO.Width = 368
        '
        'DESC_ESTADO_EMPLEADO
        '
        Me.DESC_ESTADO_EMPLEADO.Caption = "Estado"
        Me.DESC_ESTADO_EMPLEADO.FieldName = "DESC_ESTADO_EMPLEADO"
        Me.DESC_ESTADO_EMPLEADO.Name = "DESC_ESTADO_EMPLEADO"
        Me.DESC_ESTADO_EMPLEADO.OptionsColumn.AllowEdit = False
        Me.DESC_ESTADO_EMPLEADO.OptionsColumn.ReadOnly = True
        Me.DESC_ESTADO_EMPLEADO.Visible = True
        Me.DESC_ESTADO_EMPLEADO.VisibleIndex = 2
        Me.DESC_ESTADO_EMPLEADO.Width = 373
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcEmpleadoInactivo
        Me.GridView1.Name = "GridView1"
        '
        'btnElimina
        '
        Me.btnElimina.Location = New System.Drawing.Point(200, 48)
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.Size = New System.Drawing.Size(248, 23)
        Me.btnElimina.TabIndex = 1
        Me.btnElimina.Text = "Eliminar"
        Me.btnElimina.ToolTip = "Para eliminar debe seleccionar el o los registros"
        Me.btnElimina.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.btnElimina)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 256)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(656, 96)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "Opciones"
        '
        'frmEmpleadoInactivoConLiquidacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(672, 358)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gdcEmpleadoInactivo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmpleadoInactivoConLiquidacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Empleados Inactivos con Liquidación"
        CType(Me.gdcEmpleadoInactivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvEmpleadoInactivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEmpleadosInactivosconLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public tipoProceso As String
    Public idPeriodo As Integer
    Public empleado As empleado

    Private Sub frmEmpleadoInactivoConLiquidacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refrescarDetalle()
    End Sub

    Private Sub btnElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElimina.Click
        Dim numRegistros As Integer = gdvEmpleadoInactivo.GetSelectedRows().Length
        Dim mensaje As String
        If numRegistros <= 0 Then
            MessageBox.Show("Debe seleccionar a lo menos una fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If numRegistros = 1 Then
            mensaje = " un registro "
        Else
            mensaje = " los registros seleccionados"
        End If

        If System.Windows.Forms.MessageBox.Show("¿Está seguro que desea eliminar " & mensaje & "?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim filas() As Integer = gdvEmpleadoInactivo.GetSelectedRows
                Dim i, cantidadRegistros As Integer
                For i = 0 To filas.Length - 1
                    Dim row As DataRow = gdvEmpleadoInactivo.GetDataRow(filas(i))
                    cantidadRegistros += 1
                    empleado.eliminarLiquidacionEmpleado(idPeriodo, row("EMPLEADO_ID"), tipoProceso)
                Next i
                refrescarDetalle()
                If numRegistros = 1 Then
                    mensaje = " ha eliminado un registro"
                Else
                    mensaje = " han eliminado " & cantidadRegistros
                End If
                System.Windows.Forms.MessageBox.Show("Proceso finalizada. Se" & mensaje, "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox("Error al ejecutar procedimiento almacenado " & Chr(13) & Chr(13) & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub
    Private Sub refrescarDetalle()
        gdcEmpleadoInactivo.DataSource = empleado.recuperaEmpleadosInactivosconProcesoLiquidacion(idPeriodo, tipoProceso)
        If gdvEmpleadoInactivo.RowCount > 0 Then
            btnElimina.Enabled = True
        Else
            btnElimina.Enabled = False
        End If
    End Sub
End Class
