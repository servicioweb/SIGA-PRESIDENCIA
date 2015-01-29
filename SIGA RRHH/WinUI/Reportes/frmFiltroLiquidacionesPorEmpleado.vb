Imports cl.presidencia.Argo.Reportes
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports cl.presidencia.Argo.BusinessRules
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors

Public Class frmFiltroLiquidacionesPorEmpleado

    Private empleado As New Empleado
    Private parametroMensual As Periodo

    Private Sub frmFiltroLiquidacionesPorEmpleado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        empleado = New Empleado
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

    Private Sub LlenarListaLiquidaciones()
        With clbLiquidacionesEmpleado
            .DisplayMember = "DESCRIPCION_LIQUIDACION"
            .ValueMember = "ID_LIQUIDACION_ENC"
            .DataSource = empleado.recuperaEmpleadoLiquidacionPorPeriodo(lueEmpleado.EditValue)
            .CheckOnClick = True
            .Refresh()
        End With
    End Sub
    Private Sub lueEmpleado_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles lueEmpleado.EditValueChanged
        If lueEmpleado.EditValue = Nothing Then
            Exit Sub
        End If
        LlenarListaLiquidaciones()
    End Sub

    Private Sub btnVisualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnVisualizar.Click
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptLiquidacion
        Cursor.Current = Cursors.WaitCursor
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        Dim strFiltroLiquidaciones As String = LiquidacionesSeleccionadas()
        ventanaReporte1.rptVisor.SelectionFormula = "{RH_REM_LIQUIDACION_ENC.ID_LIQUIDACION_ENC} in [" & strFiltroLiquidaciones & "]"
        ventanaReporte1.rptVisor.ShowParameterPanelButton = False
        ventanaReporte1.rptVisor.ShowCloseButton = False
        ventanaReporte1.rptVisor.ShowGroupTreeButton = False
        reporte.SummaryInfo.ReportTitle = "LIQUIDACIÓN REMUNERACIÓN A " '& UCase(parametroMensual.nombrePeriodo)
        ventanaReporte1.rptVisor.ReportSource = reporte
        Cursor.Current = Cursors.Default
        ventanaReporte1.Show()
    End Sub

    Private Function LiquidacionesSeleccionadas() As String
        Dim strFiltro As String = ""
        Dim chkItem As System.Data.DataRowView
        For Each chkItem In clbLiquidacionesEmpleado.CheckedItems
            strFiltro = strFiltro + CType(chkItem("ID_LIQUIDACION_ENC"), String) + ","
        Next
        If strFiltro.Length > 0 Then
            strFiltro = strFiltro.Substring(0, strFiltro.Length - 1)
        End If
        Return (strFiltro)
    End Function
End Class