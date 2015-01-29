Imports System.Data.SqlClient

Public Class frmAsignarParticipantesCapacitacion

#Region "LLENA COMBOS"
    Private Sub LlenaComboCapacitaciones()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_obtener_capacitaciones", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)

            lueCapacitaciones.Properties.DataSource = dt
            lueCapacitaciones.Properties.ValueMember = "CAPACITACION_ID"
            lueCapacitaciones.Properties.DisplayMember = "NOMBRE"

            dt.Dispose()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LlenaComboUsuarios()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_obtener_usuarios_activos", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)

            lueUsuarios.Properties.DataSource = dt
            lueUsuarios.Properties.ValueMember = "EMPLEADO_ID"
            lueUsuarios.Properties.DisplayMember = "NOMBRES"

            dt.Dispose()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LlenaComboEstadoEvaluacionAprendizaje()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_obtener_estado_evaluacion_aprendizaje", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)

            lueEstadoEvaluacionAprendizaje.DataSource = dt
            lueEstadoEvaluacionAprendizaje.ValueMember = "ESTADO_EVALUACION_APRENDIZAJE_ID"
            lueEstadoEvaluacionAprendizaje.DisplayMember = "ESTADO_EVALUACION_APRENDIZAJE"

            dt.Dispose()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LlenaComboEvaluacionAplicabilidad()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_obtener_evaluacion_aplicabilidad", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)

            lueEvaluacionAplicabilidad.DataSource = dt
            lueEvaluacionAplicabilidad.ValueMember = "EVALUACION_APLICABILIDAD_ID"
            lueEvaluacionAplicabilidad.DisplayMember = "NOMBRE_EVALUACION_APLICABILIDAD"

            dt.Dispose()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub
#End Region

    Private Sub ActualizarGrilla(ByVal capacitacion_id As Integer)
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_obtener_participantes_capacitacion", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@capacitacion_id", capacitacion_id)
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)

            gdcFuncionariosParticipantes.DataSource = dt

            dt.Dispose()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub EliminarParticipanteCapacitacion(ByVal capacitacion_det_id As Integer)
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_elimina_participante_capacitacion", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@capacitacion_det_id", capacitacion_det_id)
            conn.Open()

            command.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmAsignarParticipantesCapacitacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LlenaComboCapacitaciones()
        LlenaComboUsuarios()
        LlenaComboEstadoEvaluacionAprendizaje()
        LlenaComboEvaluacionAplicabilidad()
    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()

    End Sub

    Private Sub LimpiarCampos()
        lueCapacitaciones.EditValue = Nothing
        lueUsuarios.EditValue = Nothing
        gdcFuncionariosParticipantes.DataSource = Nothing
        gdcFuncionariosParticipantes.RefreshDataSource()
    End Sub

    Private Sub btnAsignarParticipante_Click(sender As System.Object, e As System.EventArgs) Handles btnAsignarParticipante.Click
        If lueCapacitaciones.EditValue = Nothing Then
            MessageBox.Show("Debe seleccionar una Capacitación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lueCapacitaciones.Focus()
            Return
        End If

        If lueUsuarios.EditValue = Nothing Then
            MessageBox.Show("Debe seleccionar un Usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lueUsuarios.Focus()
            Return
        End If

        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_asignar_empleado_a_capacitacion", conn)
        Dim dr As SqlDataReader
        Try
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@capacitacion_id", lueCapacitaciones.EditValue)
            command.Parameters.AddWithValue("@empleado_id", lueUsuarios.EditValue)
            conn.Open()

            dr = command.ExecuteReader
            dr.Read()
            If dr("RESULTADO") = 1 Then
                MessageBox.Show("El usuario ya esta asignado a la capacitación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf dr("RESULTADO") = 2 Then
                MessageBox.Show("El usuario ha sido asignado a la capacitación satisfactoriamente", "¡Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf dr("RESULTADO") = 3 Then
                MessageBox.Show("No es posible asignar un participante mas porque los cupos estan completos para la Capacitación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            dr.Close()

            ActualizarGrilla(lueCapacitaciones.EditValue)
            lueUsuarios.EditValue = Nothing
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lueCapacitaciones_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles lueCapacitaciones.EditValueChanged
        If Not lueCapacitaciones.EditValue = Nothing Then
            ActualizarGrilla(lueCapacitaciones.EditValue)
        End If
    End Sub

    Private Sub gdvFuncionariosParticipantes_RowUpdated(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvFuncionariosParticipantes.RowUpdated
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvFuncionariosParticipantes
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_actualiza_asistente_capacitacion", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@capacitacion_det_id", view.GetRowCellValue(e.RowHandle, "CAPACITACION_DET_ID"))
            command.Parameters.AddWithValue("@estado_evaluacion_aprendizaje_id", view.GetRowCellValue(e.RowHandle, "ESTADO_EVALUACION_APRENDIZAJE_ID"))
            command.Parameters.AddWithValue("@evaluacion_aprendizaje", view.GetRowCellValue(e.RowHandle, "EVALUACION_APRENDIZAJE"))
            command.Parameters.AddWithValue("@evaluacion_aplicabilidad_id", view.GetRowCellValue(e.RowHandle, "EVALUACION_APLICABILIDAD_ID"))
            conn.Open()

            command.ExecuteNonQuery()

            ActualizarGrilla(lueCapacitaciones.EditValue)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub gdvFuncionariosParticipantes_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gdvFuncionariosParticipantes.KeyDown
        If e.KeyCode = Keys.Delete Then
            If MessageBox.Show("¿Está seguro de Eliminar al empleado seleccionado de la Capacitación?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                EliminarParticipanteCapacitacion(view.GetRowCellValue(view.FocusedRowHandle, "CAPACITACION_DET_ID"))
                ActualizarGrilla(lueCapacitaciones.EditValue)
                MessageBox.Show("El Empleado seleccionado ha sido eliminado satisfactoriamente de la Capacitación", "¡Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub gdvFuncionariosParticipantes_DoubleClick(sender As System.Object, e As System.EventArgs) Handles gdvFuncionariosParticipantes.DoubleClick
        If gdvFuncionariosParticipantes.RowCount > 0 Then
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
            Dim capacitacion_det_id = view.GetRowCellValue(view.FocusedRowHandle, "CAPACITACION_DET_ID")
            Dim frmAsignarCertificadoCapacitacion As New frmAsignarCertificadoCapacitacion(capacitacion_det_id, view.GetRowCellValue(view.FocusedRowHandle, "NOMBRE"), lueCapacitaciones.Text)
            frmAsignarCertificadoCapacitacion.ShowDialog()
        End If
    End Sub
End Class