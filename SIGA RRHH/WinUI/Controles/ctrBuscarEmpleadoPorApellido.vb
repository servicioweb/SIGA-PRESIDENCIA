Imports cl.presidencia.Argo.BusinessRules
Imports DevExpress.XtraEditors.Controls

Public Class ctrBuscarEmpleadoPorApellido

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Property VerSoloEmpleadoHistoricos As Boolean
    Private empleado As New Empleado

    Private Sub ctrBuscarEmpleadoPorApellido_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LlenarEmpleados()
    End Sub

    Private Sub LlenarEmpleados()
        lueEmpleado.Properties.Columns.Clear()
        With lueEmpleado
            With .Properties.Columns
                .Add(New LookUpColumnInfo("EMPLEADO_ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("NOMBRE_EMPLEADO", "Nombre Empleado", 400, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueEmpleado.Properties.DataSource = empleado.recuperarEmpleadoLiquidacion
        lueEmpleado.Properties.DisplayMember = "NOMBRE_EMPLEADO"
        lueEmpleado.Properties.NullText = ""
        lueEmpleado.Properties.PopupWidth = 600
        lueEmpleado.Properties.ValueMember = "EMPLEADO_ID"
    End Sub

 
End Class
