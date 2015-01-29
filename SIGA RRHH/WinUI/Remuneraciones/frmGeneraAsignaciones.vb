Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.SqlClient

Public Class frmGeneraAsignaciones
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
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents btnGenera As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gpcMensaje As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Progreso As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnGenera = New DevExpress.XtraEditors.SimpleButton()
        Me.gpcMensaje = New DevExpress.XtraEditors.GroupControl()
        Me.Progreso = New System.Windows.Forms.ProgressBar()
        CType(Me.gpcMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(56, 47)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(280, 89)
        Me.lblMensaje.TabIndex = 0
        Me.lblMensaje.Text = "INFORMACION: Este formulario genera las respectivas asignaciones a los empleados " & _
    "dependiendo de la calidad jurídica, grado y clasificación del empleado"
        '
        'btnGenera
        '
        Me.btnGenera.Location = New System.Drawing.Point(128, 264)
        Me.btnGenera.Name = "btnGenera"
        Me.btnGenera.Size = New System.Drawing.Size(128, 23)
        Me.btnGenera.TabIndex = 1
        Me.btnGenera.Text = "&Genera Asignaciones"
        '
        'gpcMensaje
        '
        Me.gpcMensaje.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcMensaje.AppearanceCaption.Options.UseFont = True
        Me.gpcMensaje.Location = New System.Drawing.Point(16, 16)
        Me.gpcMensaje.Name = "gpcMensaje"
        Me.gpcMensaje.Size = New System.Drawing.Size(376, 131)
        Me.gpcMensaje.TabIndex = 2
        Me.gpcMensaje.Text = "Mensaje"
        '
        'Progreso
        '
        Me.Progreso.Location = New System.Drawing.Point(16, 168)
        Me.Progreso.Name = "Progreso"
        Me.Progreso.Size = New System.Drawing.Size(376, 23)
        Me.Progreso.TabIndex = 3
        '
        'frmGeneraAsignaciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 310)
        Me.Controls.Add(Me.Progreso)
        Me.Controls.Add(Me.btnGenera)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.gpcMensaje)
        Me.Name = "frmGeneraAsignaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Genera Asignaciones"
        CType(Me.gpcMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim empleado As empleado
    Dim parametroMensual As Periodo

    Private Sub frmGeneraAsignaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empleado = New Empleado
        parametroMensual = New Periodo
    End Sub

    Private Sub btnGenera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenera.Click
        If MessageBox.Show("¿Está seguro que desea generar las asignaciones a los empleados?", "Remuneraciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            btnGenera.Enabled = False
            Dim dtEmpleados As DataTable
            Dim fila As Data.DataRow
            Dim contador As Integer = 0
            Dim procesoError As Boolean = False
            Progreso.Minimum = 0
            dtEmpleados = empleado.recuperaEmpleadosActivos
            Progreso.Maximum = dtEmpleados.Rows.Count - 1
            For Each fila In dtEmpleados.Rows
                Try
                    empleado = New Empleado(fila("EMPLEADO_ID"), True)
                    generaMontosAsignaciones()
                Catch ex As Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message + Chr(13) + "Error en el empleado ID :" + fila("EMPLEADO_ID").ToString + Chr(13) + "El proceso se cancelara", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    procesoError = True
                    Exit For
                End Try
                Progreso.Value = contador
                contador += 1
            Next
            btnGenera.Enabled = True
            If Not procesoError Then
                System.Windows.Forms.MessageBox.Show("Proceso Finalizado. Se han procesado " & dtEmpleados.Rows.Count & " registros de empleados.", "Sistema de Remuneraciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub generaMontosAsignaciones()
        Dim idCalJuridica, idGrado, idClasEmpleado, idAfp, idIsapre, numBienios As Integer

        idCalJuridica = empleado.datosLaborales.calidadJuridicaID
        idGrado = empleado.datosLaborales.gradoID
        idClasEmpleado = empleado.datosLaborales.clasificacionEmpleadoID
        idAfp = empleado.datosPrevisionales.institucionID
        idIsapre = empleado.datosSalud.institucionID
        numBienios = empleado.datosRemuneracion.numeroBienios
        'Genera los montos para las asignaciones
        empleado.recuperarDatosEUSEmpleado(empleado, idCalJuridica, idGrado, _
                                              idClasEmpleado, numBienios, idAfp, idIsapre, parametroMensual)
        generaMontoAsignacionZona()

        'Crea los movimientos mensual para asignación
        Dim origen As Integer = 2
        Dim tipoProceso As String = "N"
        Try
            empleado.CrearItemEmpleado(empleado, parametroMensual, origen, tipoProceso)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al crear los itemes " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
        End Try

        'Actualizar montos en registro de remuneración
        Try
            empleado.actualizarDatosRemun(empleado.datosRemuneracion)
            'MsgBox("Los datos han sido actualizados correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al actualizar " & empleado.nombreCompleto & " " & ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub generaMontoAsignacionZona()
        Dim MontoAsignacionZona As Integer = 0
        If parametroMensual.aplicaAsignacionZona = False Then
            empleado.datosRemuneracion.montoAsignacionZona = 0
        Else
            empleado.datosRemuneracion.montoAsignacionZona = empleado.recuperarMontosAsignacionesZona(empleado.datosRemuneracion.zonaID, parametroMensual.ID, empleado.datosRemuneracion.sueldoBase)
        End If
    End Sub
End Class
