Imports cl.presidencia.Argo.BusinessRules
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmInformeHorasNoRatificadas

    Private empleado As Empleado

    Private Sub frmInformeHorasNoRatificadas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnGenerar.Enabled = False
        btnExportExcel.Enabled = False
    End Sub

    Private Sub btnGenerar_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerar.Click
        LlenarGrilla()
    End Sub

    Private Sub btnExportExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExportExcel.Click
        Dim rutaPlanillaExcel As String
        Try
            With SaveFileDialog1
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = SaveFileDialog1.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                pgcHorasExtrasNoRatificadas.OptionsView.ShowRowTotals = False
                pgcHorasExtrasNoRatificadas.OptionsPrint.PrintFilterHeaders = DefaultBoolean.False
                pgcHorasExtrasNoRatificadas.OptionsPrint.PrintDataHeaders = DefaultBoolean.False
                pgcHorasExtrasNoRatificadas.ExportToXls(rutaPlanillaExcel)
                pgcHorasExtrasNoRatificadas.OptionsView.ShowRowTotals = True
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dedFechaInicio_EditValueChanged(sender As Object, e As System.EventArgs) Handles dedFechaInicio.EditValueChanged, dedFechaFinal.EditValueChanged
        If dedFechaInicio.EditValue = Nothing Or dedFechaFinal.EditValue = Nothing Then
            Exit Sub
        End If
        If dedFechaFinal.EditValue < dedFechaInicio.EditValue Then
            btnGenerar.Enabled = False
            btnExportExcel.Enabled = False
        Else
            btnGenerar.Enabled = True
            btnExportExcel.Enabled = True
        End If
    End Sub

    Private Sub LlenarGrilla()
        Try
            Cursor.Current = Cursors.WaitCursor
            empleado = New Empleado
            pgcHorasExtrasNoRatificadas.DataSource = Nothing
            pgcHorasExtrasNoRatificadas.DataSource = empleado.generaHorasExtrasNoRatificadas(dedFechaInicio.EditValue, dedFechaFinal.EditValue)
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

    End Sub

   
End Class