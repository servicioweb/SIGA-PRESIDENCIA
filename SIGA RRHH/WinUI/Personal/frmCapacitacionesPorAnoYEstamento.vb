Imports System.Data.SqlClient
Imports System.IO

Public Class frmCapacitacionesPorAnoYEstamento

    Private Sub CargaComboEstamentos(ByVal organizacion_id As Integer)
        ' HOLA
        ' HI
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_obtener_estamento", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@organizacion_id", organizacion_id)
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)

            lueEstamento.Properties.DataSource = Nothing
            lueEstamento.Refresh()

            lueEstamento.Properties.DataSource = dt
            lueEstamento.Properties.ValueMember = "ESTAMENTO_ID"
            lueEstamento.Properties.DisplayMember = "DESCRIPCION"
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LimpiarCampos()
        txtAno.EditValue = Nothing
        txtInicioMes.EditValue = Nothing
        txtMesTermino.EditValue = Nothing
        rogTipoInforme.EditValue = Nothing
        'lueEstamento.EditValue = Nothing
        chkIncluirEstamento.EditValue = False
        chkIncluirEstamento.Enabled = False
        gdcCapacitaciones.DataSource = Nothing
        gdcCapacitaciones.RefreshDataSource()
        EsconderTodasLasColumnas()
    End Sub

    Private Sub ActualizarGrillaPorAno()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_rpt_obtener_capacitaciones_por_ano", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@ano", txtAno.EditValue)
            command.Parameters.AddWithValue("@mes_inicial", txtInicioMes.EditValue)
            command.Parameters.AddWithValue("@mes_final", txtMesTermino.EditValue)
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)

            gdcCapacitaciones.DataSource = dt

            dt.Dispose()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ActualizarGrillaPorEmpleado()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_rpt_obtener_participantes_por_ano_estamento", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@ano", txtAno.EditValue)
            command.Parameters.AddWithValue("@mes_inicial", txtInicioMes.EditValue)
            command.Parameters.AddWithValue("@mes_final", txtMesTermino.EditValue)
            command.Parameters.AddWithValue("@incluir_estamento", chkIncluirEstamento.EditValue)
            command.Parameters.AddWithValue("@estamento_id", lueEstamento.EditValue)
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)

            gdcCapacitaciones.DataSource = dt

            dt.Dispose()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub EsconderTodasLasColumnas()
        colRut.Visible = False
        colApellidoPaterno.Visible = False
        colApellidoMaterno.Visible = False
        colNombres.Visible = False
        colEstamento.Visible = False
        colDepartamento.Visible = False
        colNombreCapacitacion.Visible = False
        colEstadoEvaluacionAprendizaje.Visible = False
        colFechaInicio.Visible = False
        colCostoCapacitacion.Visible = False
        colCantidadParticipantes.Visible = False
        colFechaTermino.Visible = False
        colInsitucionImpartidora.Visible = False
        colHorasEjecucion.Visible = False
        colEmpleadoId.Visible = False
    End Sub

    Private Sub MostrarColumnasPorAno()
        colEmpleadoId.Visible = False
        colRut.Visible = False
        colApellidoPaterno.Visible = False
        colApellidoMaterno.Visible = False
        colNombres.Visible = False
        colEstamento.Visible = False
        colDepartamento.Visible = False
        colNombreCapacitacion.Visible = True
        colEstadoEvaluacionAprendizaje.Visible = False
        colFechaInicio.Visible = True
        colCostoCapacitacion.Visible = True
        colCantidadParticipantes.Visible = True
        colFechaTermino.Visible = True
        colInsitucionImpartidora.Visible = True
        colHorasEjecucion.Visible = True

        colNombreCapacitacion.VisibleIndex = 0
        colInsitucionImpartidora.VisibleIndex = 1
        colHorasEjecucion.VisibleIndex = 2
        colCantidadParticipantes.VisibleIndex = 3
        colFechaInicio.VisibleIndex = 4
        colFechaTermino.VisibleIndex = 5
        colCostoCapacitacion.VisibleIndex = 6
    End Sub

    Private Sub MostrarColumnasPorEmpleado()
        colEmpleadoId.Visible = True
        colRut.Visible = True
        colApellidoPaterno.Visible = True
        colApellidoMaterno.Visible = True
        colNombres.Visible = True
        colEstamento.Visible = True
        colDepartamento.Visible = True
        colNombreCapacitacion.Visible = True
        colEstadoEvaluacionAprendizaje.Visible = True
        colFechaInicio.Visible = False
        colCostoCapacitacion.Visible = False
        colCantidadParticipantes.Visible = False
        colFechaTermino.Visible = False
        colInsitucionImpartidora.Visible = False
        colHorasEjecucion.Visible = False

        colEmpleadoId.VisibleIndex = 0
        colRut.VisibleIndex = 1
        colApellidoPaterno.VisibleIndex = 2
        colApellidoMaterno.VisibleIndex = 3
        colNombres.VisibleIndex = 4
        colEstamento.VisibleIndex = 5
        colDepartamento.VisibleIndex = 6
        colNombreCapacitacion.VisibleIndex = 7
        colEstadoEvaluacionAprendizaje.VisibleIndex = 8
    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub chkIncluirEstamento_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkIncluirEstamento.CheckedChanged
        lueEstamento.Enabled = chkIncluirEstamento.EditValue
        If chkIncluirEstamento.EditValue = False Then
            lueEstamento.EditValue = Nothing
        End If
    End Sub

    Private Sub frmCapacitacionesPorAnoYEstamento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargaComboEstamentos(1)
        EsconderTodasLasColumnas()
    End Sub

    Private Sub btnExportarExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarExcel.Click
        If gdvCapacitaciones.RowCount > 0 Then
            Dim sfd As New SaveFileDialog
            Dim nuevoExcel As String
            sfd.Filter = "Libro de Excel (*.xlsx)|*.xlsx|Libro de Excel 97-2003 (*.xls)|*.xls"
            If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                nuevoExcel = sfd.FileName
                If Path.GetExtension(nuevoExcel) = ".xls" Then
                    gdcCapacitaciones.ExportToXls(nuevoExcel)
                ElseIf Path.GetExtension(nuevoExcel) = ".xlsx" Then
                    gdcCapacitaciones.ExportToXlsx(nuevoExcel)
                End If
                MessageBox.Show("El archivo fue exportado exitosamente", "¡Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnVisualizarCapacitaciones_Click(sender As System.Object, e As System.EventArgs) Handles btnVisualizarCapacitaciones.Click
        If txtAno.EditValue = Nothing Then
            MessageBox.Show("Debe ingresar Año", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAno.Focus()
            Exit Sub
        End If

        If txtInicioMes.EditValue = Nothing Then
            MessageBox.Show("Debe ingresar Mes Inicial", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtInicioMes.Focus()
            Exit Sub
        End If

        If txtMesTermino.EditValue = Nothing Then
            MessageBox.Show("Debe ingresar Mes Final", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMesTermino.Focus()
            Exit Sub
        End If

        If rogTipoInforme.EditValue = Nothing Then
            MessageBox.Show("Debe seleccionar Tipo de Informe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rogTipoInforme.Focus()
            Exit Sub
        End If

        If rogTipoInforme.EditValue = 2 And chkIncluirEstamento.EditValue = True And lueEstamento.EditValue = Nothing Then
            MessageBox.Show("Debe seleccionar Estamento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lueEstamento.Focus()
            Exit Sub
        End If

        gdcCapacitaciones.DataSource = Nothing
        gdcCapacitaciones.RefreshDataSource()

        If rogTipoInforme.EditValue = 1 Then
            MostrarColumnasPorAno()
            ActualizarGrillaPorAno()
        ElseIf rogTipoInforme.EditValue = 2 Then
            MostrarColumnasPorEmpleado()
            ActualizarGrillaPorEmpleado()
        End If

    End Sub

    Private Sub rogTipoInforme_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles rogTipoInforme.EditValueChanged
        If rogTipoInforme.EditValue = 2 Then
            chkIncluirEstamento.Enabled = True
        ElseIf rogTipoInforme.EditValue = 1 Then
            chkIncluirEstamento.EditValue = False
            chkIncluirEstamento.Enabled = False
        End If
    End Sub
End Class