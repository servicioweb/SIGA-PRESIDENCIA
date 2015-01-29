Imports System.Data.SqlClient

Public Class frmFestivos

    Private Sub frmFestivos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LLenaComboAnos()
    End Sub

    Private Sub LLenaComboAnos()

        Dim mesActual = Month(Now)
        Dim anoActual = Year(Now)
        Dim cuentaAtras = 3
        'mesActual = 11
        If mesActual >= 11 Then
            anoActual = anoActual + 1
            cuentaAtras = cuentaAtras + 1
        End If

        For i As Integer = anoActual To anoActual - cuentaAtras Step -1
            cboAno.Properties.Items.Add(i)
        Next
    End Sub


    Private Sub RefrescarGrilla()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_tabla_maestra_obtener_festivos_by_ano", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@ano", cboAno.EditValue)
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)
            gdcListaFeriados.DataSource = dt

        Catch ex As Exception
            Throw New Exception(ex.ToString)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub cboAno_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cboAno.EditValueChanged

        RefrescarGrilla()
    End Sub

    Private Sub btnGuardarFeriado_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarFeriado.Click
        If cboAno.EditValue = Nothing Then
            MessageBox.Show("Debe seleccionar un Año", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If txtNombreFeriado.EditValue = Nothing Then
            MessageBox.Show("Debe ingresar Nombre Feriado", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNombreFeriado.Focus()
            Exit Sub
        End If

        If detFechaFeriado.EditValue = Nothing Then
            MessageBox.Show("Debe seleccionar Fecha de Feriado", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        For i As Integer = 0 To gdvListaFeriados.RowCount - 1
            If detFechaFeriado.EditValue = gdvListaFeriados.GetRowCellValue(i, "FESTIVO") Then
                MessageBox.Show("Ya existe un Feriado para la fecha " + detFechaFeriado.EditValue, "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next

        If MessageBox.Show("¿Esta seguro de agregar un nuevo Feriado?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            GuardarActualizarFestivo(0, txtNombreFeriado.EditValue.ToString.Trim, detFechaFeriado.EditValue)
        End If

    End Sub

    Private Sub GuardarActualizarFestivo(ByVal festivoId As Integer, ByVal nombreFestivo As String, ByVal fechaFestivo As Date)
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_tabla_maestra_guarda_festivo", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@festivo_id", festivoId)
            command.Parameters.AddWithValue("@nombre_festivo", nombreFestivo)
            command.Parameters.AddWithValue("@fecha_festivo", fechaFestivo)
            conn.Open()

            command.ExecuteNonQuery()

            RefrescarGrilla()

            MessageBox.Show("Festivo guardado satisfactoriamente", "¡Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txtNombreFeriado_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtNombreFeriado.EditValueChanged
        txtNombreFeriado.Text = sender.EditValue.ToString.ToUpper
    End Sub

    Private Sub gdvListaFeriados_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gdvListaFeriados.KeyDown
        If e.KeyCode = Keys.Delete Then
            If MessageBox.Show("¿Desea eliminar el registro seleccionado?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Cursor = Cursors.AppStarting
                Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
                Dim command As New SqlCommand("sp_tabla_maestra_eliminar_festivo", conn)
                Try
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@id_festivo", gdvListaFeriados.GetRowCellValue(gdvListaFeriados.FocusedRowHandle, "FESTIVO_ID"))
                    conn.Open()

                    command.ExecuteNonQuery()

                    RefrescarGrilla()

                    MessageBox.Show("Festivo eliminado satisfactoriamente", "¡Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    Throw New Exception(ex.ToString)
                Finally
                    conn.Dispose()
                    command.Dispose()
                    Cursor = Cursors.Default
                End Try
            End If
        End If
    End Sub

    Private Sub gdvListaFeriados_RowUpdated(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvListaFeriados.RowUpdated
        If MessageBox.Show("¿Esta seguro de actualizar feriado seleccionado?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim feriadoID = gdvListaFeriados.GetRowCellValue(e.RowHandle, "FESTIVO_ID")
            Dim nombreFestivo = gdvListaFeriados.GetRowCellValue(e.RowHandle, "DESCRIPCION")
            Dim fechaFestivo = gdvListaFeriados.GetRowCellValue(e.RowHandle, "FESTIVO")

            GuardarActualizarFestivo(feriadoID, nombreFestivo.ToString.Trim, fechaFestivo)
        End If
    End Sub

    Private Sub detFechaFeriado_Spin(sender As System.Object, e As DevExpress.XtraEditors.Controls.SpinEventArgs) Handles detFechaFeriado.Spin
        e.Handled = True
    End Sub
End Class