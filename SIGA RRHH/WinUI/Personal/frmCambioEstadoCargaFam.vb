Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.SqlClient
Public Class frmCambioEstadoCargaFam
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
    Friend WithEvents gdcCambioEstadoCargaFam As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvCambioEstadoCargaFam As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NOMBRE_EMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CARGA_FAMILIAR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOMBRE_COMPLETO_CARGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHA_NACIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCalculo As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gdcCambioEstadoCargaFam = New DevExpress.XtraGrid.GridControl
        Me.gdvCambioEstadoCargaFam = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.NOMBRE_EMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CARGA_FAMILIAR_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NOMBRE_COMPLETO_CARGA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.EDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FECHA_NACIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnCalculo = New DevExpress.XtraEditors.SimpleButton
        CType(Me.gdcCambioEstadoCargaFam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvCambioEstadoCargaFam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcCambioEstadoCargaFam
        '
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.gdcCambioEstadoCargaFam.EmbeddedNavigator.Name = ""
        Me.gdcCambioEstadoCargaFam.Location = New System.Drawing.Point(8, 16)
        Me.gdcCambioEstadoCargaFam.MainView = Me.gdvCambioEstadoCargaFam
        Me.gdcCambioEstadoCargaFam.Name = "gdcCambioEstadoCargaFam"
        Me.gdcCambioEstadoCargaFam.Size = New System.Drawing.Size(664, 312)
        Me.gdcCambioEstadoCargaFam.TabIndex = 0
        Me.gdcCambioEstadoCargaFam.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvCambioEstadoCargaFam})
        '
        'gdvCambioEstadoCargaFam
        '
        Me.gdvCambioEstadoCargaFam.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NOMBRE_EMPLEADO, Me.NOMBRE_COMPLETO_CARGA, Me.FECHA_NACIMIENTO, Me.EDAD, Me.CARGA_FAMILIAR_ID})
        Me.gdvCambioEstadoCargaFam.GridControl = Me.gdcCambioEstadoCargaFam
        Me.gdvCambioEstadoCargaFam.Name = "gdvCambioEstadoCargaFam"
        Me.gdvCambioEstadoCargaFam.OptionsSelection.MultiSelect = True
        '
        'NOMBRE_EMPLEADO
        '
        Me.NOMBRE_EMPLEADO.Caption = "NOMBRE EMPLEADO"
        Me.NOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.NOMBRE_EMPLEADO.Name = "NOMBRE_EMPLEADO"
        Me.NOMBRE_EMPLEADO.OptionsColumn.AllowEdit = False
        Me.NOMBRE_EMPLEADO.OptionsColumn.ReadOnly = True
        Me.NOMBRE_EMPLEADO.Visible = True
        Me.NOMBRE_EMPLEADO.VisibleIndex = 0
        Me.NOMBRE_EMPLEADO.Width = 182
        '
        'CARGA_FAMILIAR_ID
        '
        Me.CARGA_FAMILIAR_ID.Caption = "CARGA_FAMILIAR_ID"
        Me.CARGA_FAMILIAR_ID.FieldName = "CARGA_FAMILIAR_ID"
        Me.CARGA_FAMILIAR_ID.Name = "CARGA_FAMILIAR_ID"
        '
        'NOMBRE_COMPLETO_CARGA
        '
        Me.NOMBRE_COMPLETO_CARGA.Caption = "NOMBRE CARGA FAMILIAR"
        Me.NOMBRE_COMPLETO_CARGA.FieldName = "NOMBRE_COMPLETO_CARGA"
        Me.NOMBRE_COMPLETO_CARGA.Name = "NOMBRE_COMPLETO_CARGA"
        Me.NOMBRE_COMPLETO_CARGA.OptionsColumn.AllowEdit = False
        Me.NOMBRE_COMPLETO_CARGA.Visible = True
        Me.NOMBRE_COMPLETO_CARGA.VisibleIndex = 1
        Me.NOMBRE_COMPLETO_CARGA.Width = 233
        '
        'EDAD
        '
        Me.EDAD.Caption = "EDAD"
        Me.EDAD.FieldName = "EDAD"
        Me.EDAD.Name = "EDAD"
        Me.EDAD.OptionsColumn.AllowEdit = False
        Me.EDAD.OptionsColumn.ReadOnly = True
        Me.EDAD.Visible = True
        Me.EDAD.VisibleIndex = 2
        Me.EDAD.Width = 40
        '
        'FECHA_NACIMIENTO
        '
        Me.FECHA_NACIMIENTO.Caption = "FECHA NACIMIENTO"
        Me.FECHA_NACIMIENTO.FieldName = "FECHA_NACIMIENTO"
        Me.FECHA_NACIMIENTO.Name = "FECHA_NACIMIENTO"
        Me.FECHA_NACIMIENTO.OptionsColumn.AllowEdit = False
        Me.FECHA_NACIMIENTO.OptionsColumn.ReadOnly = True
        Me.FECHA_NACIMIENTO.Visible = True
        Me.FECHA_NACIMIENTO.VisibleIndex = 3
        Me.FECHA_NACIMIENTO.Width = 108
        '
        'btnCalculo
        '
        Me.btnCalculo.Location = New System.Drawing.Point(8, 344)
        Me.btnCalculo.Name = "btnCalculo"
        Me.btnCalculo.Size = New System.Drawing.Size(296, 23)
        Me.btnCalculo.TabIndex = 2
        Me.btnCalculo.Text = "Marcar como NO VIGENTE"
        '
        'frmCambioEstadoCargaFam
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(680, 414)
        Me.Controls.Add(Me.btnCalculo)
        Me.Controls.Add(Me.gdcCambioEstadoCargaFam)
        Me.Name = "frmCambioEstadoCargaFam"
        Me.Text = "Cambio de Estado / Carga Familiar"
        CType(Me.gdcCambioEstadoCargaFam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvCambioEstadoCargaFam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim empleado As New empleado
    Private Sub initGrid()
        gdcCambioEstadoCargaFam.DataSource = empleado.recuperaCargasFamiliaresConEstado
        gdcCambioEstadoCargaFam.Show()
    End Sub
    Private Sub frmCambioEstadoCargaFam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gdcCambioEstadoCargaFam.DataSource = empleado.recuperaCargasFamiliaresConEstado

    End Sub

    Private Sub btnCalculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculo.Click
        Dim cantidadRegistros As Integer = gdvCambioEstadoCargaFam.GetSelectedRows().Length
        If cantidadRegistros <= 0 Then
            MessageBox.Show("Debe seleccionar a lo menos una fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Try
            If MessageBox.Show("¿Está seguro que desea marcar como NO VIGENTE las cargas seleccionadas?", "Remuneraciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                btnCalculo.Enabled = False
                'filas() representa una lista de los  rowHandle seleccionados
                Dim filas() As Integer = gdvCambioEstadoCargaFam.GetSelectedRows()
                Dim cargaFamiliar As New CargaFamiliar

                Dim i As Integer
                For i = 0 To filas.Length - 1
                    Dim row As DataRow = gdvCambioEstadoCargaFam.GetDataRow(filas(i))
                    cargaFamiliar.CAMBIA_ESTADO_CARGA_FAMILIAR(row.Item("CARGA_FAMILIAR_ID"))

                Next i
                gdcCambioEstadoCargaFam.DataSource = empleado.recuperaCargasFamiliaresConEstado
                gdcCambioEstadoCargaFam.Show()
                initGrid()
                System.Windows.Forms.MessageBox.Show("Proceso Finalizado. Se han marcado " & cantidadRegistros & " cargas familiares.", "Sistema de Remuneraciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnCalculo.Enabled = True
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

    End Sub
End Class
