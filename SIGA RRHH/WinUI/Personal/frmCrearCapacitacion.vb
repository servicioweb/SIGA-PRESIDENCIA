Imports System.Data.SqlClient

Public Class frmCrearCapacitacion

#Region "LLENA COMBOS"

    Private Sub LlenaComboPresupuesto()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_obtener_presupuesto", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)

            luePresupuesto.Properties.DataSource = dt
            luePresupuesto.Properties.ValueMember = "PRESUPUESTO_ID"
            luePresupuesto.Properties.DisplayMember = "NOMBRE_PRESUPUESTO"
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LlenaComboModalidadCompra()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_obtener_modalidad_compra", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)

            lueModalidadCompra.Properties.DataSource = dt
            lueModalidadCompra.Properties.ValueMember = "MODALIDAD_COMPRA_ID"
            lueModalidadCompra.Properties.DisplayMember = "NOMBRE_MODALIDAD_COMPRA"
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LlenaComboMetodologiaAprendizaje()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_obtener_metodologia_aprendizaje", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)

            lueMetodologiaAprendizaje.Properties.DataSource = dt
            lueMetodologiaAprendizaje.Properties.ValueMember = "METODOLOGIA_APRENDIZAJE_ID"
            lueMetodologiaAprendizaje.Properties.DisplayMember = "NOMBRE_METODOLOGIA"
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LlenaComboEstadoCapacitacion()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_obtener_estado_capacitacion", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)

            lueEstadoCapacitacion.Properties.DataSource = dt
            lueEstadoCapacitacion.Properties.ValueMember = "ESTADO_ID"
            lueEstadoCapacitacion.Properties.DisplayMember = "NOMBRE_ESTADO"
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LlenaComboTipoActividad()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_obtener_tipo_actividad", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)

            lueTipoActividad.Properties.DataSource = dt
            lueTipoActividad.Properties.ValueMember = "TIPO_ACTIVIDAD_ID"
            lueTipoActividad.Properties.DisplayMember = "NOMBRE_TIPO_ACTIVIDAD"
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LlenaComboJornada()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_obtener_jornada", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)

            lueJornada.Properties.DataSource = dt
            lueJornada.Properties.ValueMember = "JORNADA_ID"
            lueJornada.Properties.DisplayMember = "NOMBRE_JORNADA"
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LlenaComboCapacitaciones()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_obtener_capacitaciones", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)

            lueCapacitaciones.Properties.DataSource = Nothing
            lueCapacitaciones.Refresh()

            lueCapacitaciones.Properties.DataSource = dt
            lueCapacitaciones.Properties.ValueMember = "CAPACITACION_ID"
            lueCapacitaciones.Properties.DisplayMember = "NOMBRE"
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

#End Region

    Private Sub rogTipoPago_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles rogTipoPago.EditValueChanged
        If rogTipoPago.EditValue = 1 Then
            txtCostoMonetario.Enabled = True
        ElseIf rogTipoPago.EditValue = 2 Then
            txtCostoMonetario.Enabled = False
            txtCostoMonetario.Text = String.Empty
        End If
    End Sub

    Private Sub btnCrearNuevaCapacitacion_Click(sender As System.Object, e As System.EventArgs) Handles btnCrearNuevaCapacitacion.Click
        If btnCrearNuevaCapacitacion.Text = "Nuevo" Then
            lueCapacitaciones.Enabled = False
            btnCrearNuevaCapacitacion.Text = "Cancelar"
            btnEliminarCapacitacion.Enabled = False
            LimpiarCampos()
        ElseIf btnCrearNuevaCapacitacion.Text = "Cancelar" Then
            lueCapacitaciones.Enabled = True
            btnEliminarCapacitacion.Enabled = True
            btnCrearNuevaCapacitacion.Text = "Nuevo"
        End If
    End Sub

    Private Sub btnGuardarCambios_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarCambios.Click
        If btnCrearNuevaCapacitacion.Text = "Nuevo" Then
            ' CUANDO EL USUARIO ESTA MODIFICANDO UNA CAPACITACION
            If CompruebaCampos() Then
                Dim capacitacion_id = lueCapacitaciones.EditValue
                GuardaCapacitacion(capacitacion_id)
                lueCapacitaciones.Properties.DataSource = Nothing
                LlenaComboCapacitaciones()
                lueCapacitaciones.EditValue = capacitacion_id
            End If

        ElseIf btnCrearNuevaCapacitacion.Text = "Cancelar" Then
            ' CUANDO EL USUARIO CREA UNA NUEVA CAPACITACION

            If CompruebaCampos() Then
                GuardaCapacitacion(0)

                lueCapacitaciones.Properties.DataSource = Nothing
                LlenaComboCapacitaciones()
                lueCapacitaciones.Enabled = True
                btnEliminarCapacitacion.Enabled = True
                btnCrearNuevaCapacitacion.Text = "Nuevo"
                LimpiarCampos()
            End If

        End If
    End Sub

    Private Sub LimpiarCampos()
        lueCapacitaciones.EditValue = Nothing
        txtNombreCapacitacion.EditValue = Nothing
        txtInstitucionImpartidora.EditValue = Nothing
        luePresupuesto.EditValue = Nothing
        txtObjectivoCapacitacion.Text = String.Empty
        txtPrograma.Text = String.Empty
        lueModalidadCompra.EditValue = Nothing
        lueMetodologiaAprendizaje.EditValue = Nothing
        lueEstadoCapacitacion.EditValue = Nothing

        txtCantidadHorasEjecutadas.Text = String.Empty
        txtNroParticipantes.Text = String.Empty
        lueTipoActividad.EditValue = Nothing
        rogTipoPago.EditValue = 0
        txtCostoMonetario.Text = String.Empty
        txtCostoMonetario.Enabled = False

        moeObservaciones.Text = String.Empty

        lueJornada.EditValue = Nothing
        deeFechaInicio.EditValue = Nothing
        deeFechaTermino.EditValue = Nothing
        teeHoraInicio.EditValue = "00:00"
        teeHoraTermino.EditValue = "00:00"
    End Sub

    Private Sub btnEliminarCapacitacion_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarCapacitacion.Click
        'lueCapacitaciones.EditValue = 1
        If Not lueCapacitaciones.EditValue = Nothing Then
            If MessageBox.Show("¿Esta seguro de eliminar la capacitación seleccionada?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ' SE PROCEDE A ELIMINAR LA CAPACITACION SELECCIONADA.

                Cursor = Cursors.AppStarting
                Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
                Dim command As New SqlCommand("sp_cap_eliminar_capacitacion", conn)
                'Dim dr As SqlDataReader
                Try
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@capacitacion_id", lueCapacitaciones.EditValue)
                    conn.Open()

                    Dim resultado = command.ExecuteScalar
                    If resultado = 1 Then
                        MessageBox.Show("No es posible eliminar la capacitación, porque posee participantes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf resultado = 2 Then
                        MessageBox.Show("Capacitación eliminada satisfactoriamente", "¡Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LlenaComboCapacitaciones()
                        LimpiarCampos()
                    End If
                Catch ex As Exception
                    Throw New Exception(ex.Message)
                Finally
                    conn.Dispose()
                    command.Dispose()
                    Cursor = Cursors.Default
                End Try

            End If
        Else
            MessageBox.Show("Debe seleccionar una capacitación para elimiar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lueCapacitaciones.Focus()
        End If
    End Sub

    Private Sub frmCrearCapacitacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LlenaComboCapacitaciones()
        LlenaComboPresupuesto()
        LlenaComboModalidadCompra()
        LlenaComboMetodologiaAprendizaje()
        LlenaComboEstadoCapacitacion()
        LlenaComboTipoActividad()
        LlenaComboJornada()
    End Sub


    Private Sub lueCapacitaciones_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles lueCapacitaciones.EditValueChanged
        If IsNumeric(lueCapacitaciones.EditValue) Then
            Cursor = Cursors.AppStarting
            Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
            Dim command As New SqlCommand("sp_cap_obtener_info_capacitacion_byCapacitacionID", conn)
            Dim dr As SqlDataReader
            Try
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@capacitacion_id", lueCapacitaciones.EditValue)
                conn.Open()

                dr = command.ExecuteReader

                Do
                    While dr.Read
                        txtNombreCapacitacion.EditValue = dr("NOMBRE")
                        txtInstitucionImpartidora.EditValue = dr("INSTITUCION_IMPARTIDORA")
                        luePresupuesto.EditValue = dr("PRESUPUESTO_ID")
                        txtObjectivoCapacitacion.EditValue = dr("OBJETIVO_CAPACITACION")
                        txtPrograma.EditValue = dr("PROGRAMA")
                        lueModalidadCompra.EditValue = dr("MODALIDAD_COMPRA_ID")
                        lueMetodologiaAprendizaje.EditValue = dr("METODOLOGIA_APRENDIZAJE_ID")
                        lueEstadoCapacitacion.EditValue = dr("ESTADO_ID")
                        txtCantidadHorasEjecutadas.EditValue = dr("CANTIDAD_HORAS_EJECUTADAS")
                        txtNroParticipantes.EditValue = dr("NRO_PARTICIPANTES")
                        lueTipoActividad.EditValue = dr("TIPO_ACTIVIDAD_ID")
                        rogTipoPago.EditValue = dr("TIPO_PAGO")
                        txtCostoMonetario.EditValue = dr("COSTO_MONETARIO")
                        lueJornada.EditValue = dr("JORNADA_ID")
                        deeFechaInicio.EditValue = dr("FECHA_INICIO")
                        deeFechaTermino.EditValue = dr("FECHA_TERMINO")
                        teeHoraInicio.EditValue = dr("HORA_INICIO")
                        teeHoraInicio.EditValue = teeHoraInicio.EditValue.ToString.Split(":")(0) + ":" + teeHoraInicio.EditValue.ToString.Split(":")(1)
                        teeHoraTermino.EditValue = dr("HORA_TERMINO")
                        teeHoraTermino.EditValue = teeHoraTermino.EditValue.ToString.Split(":")(0) + ":" + teeHoraTermino.EditValue.ToString.Split(":")(1)
                        moeObservaciones.EditValue = dr("OBSERVACION")
                    End While
                Loop While dr.NextResult
                dr.Close()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                conn.Dispose()
                command.Dispose()
                Cursor = Cursors.Default
            End Try
        End If
    End Sub

    Public Sub GuardaCapacitacion(ByVal capacitacion_id As Integer)
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_guarda_capacitacion", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@capacitacion_id", capacitacion_id)
            command.Parameters.AddWithValue("@nombre_capacitacion", txtNombreCapacitacion.EditValue.ToString.Trim)
            command.Parameters.AddWithValue("@nombre_institucion_impartidora", txtInstitucionImpartidora.EditValue.ToString.Trim)
            command.Parameters.AddWithValue("@presupuesto_id", luePresupuesto.EditValue)
            command.Parameters.AddWithValue("@objetivo_capacitacion", txtObjectivoCapacitacion.EditValue.ToString.Trim)
            command.Parameters.AddWithValue("@programa", txtPrograma.EditValue.ToString.Trim)
            command.Parameters.AddWithValue("@modalidad_compra_id", lueModalidadCompra.EditValue)
            command.Parameters.AddWithValue("@metodologia_aprendizaje_id", lueMetodologiaAprendizaje.EditValue)
            command.Parameters.AddWithValue("@estado_id", lueEstadoCapacitacion.EditValue)
            command.Parameters.AddWithValue("@cantidad_horas_ejecutadas", txtCantidadHorasEjecutadas.EditValue.ToString.Trim)
            command.Parameters.AddWithValue("@nro_participantes", txtNroParticipantes.EditValue.ToString.Trim)
            command.Parameters.AddWithValue("@tipo_actividad_id", lueTipoActividad.EditValue)
            command.Parameters.AddWithValue("@tipo_pago", rogTipoPago.EditValue)
            command.Parameters.AddWithValue("@costo_monetario", txtCostoMonetario.EditValue.ToString.Trim)
            command.Parameters.AddWithValue("@jornada_id", lueJornada.EditValue)
            command.Parameters.AddWithValue("@fecha_inicio", deeFechaInicio.EditValue)
            command.Parameters.AddWithValue("@fecha_termino", deeFechaTermino.EditValue)
            command.Parameters.AddWithValue("@hora_inicio", teeHoraInicio.EditValue)
            command.Parameters.AddWithValue("@hora_termino", teeHoraTermino.EditValue)
            command.Parameters.AddWithValue("@observacion", moeObservaciones.EditValue)
            conn.Open()

            command.ExecuteNonQuery()
            If capacitacion_id > 0 Then
                MessageBox.Show("La capacitación ha sido actualizada con éxito", "¡Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("La capacitación ha sido ingresada con éxito", "¡Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Public Function CompruebaCampos()
        If txtNombreCapacitacion.EditValue = Nothing Then
            MessageBox.Show("Debe ingresar Nombre Capacitación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If txtInstitucionImpartidora.EditValue = Nothing Then
            MessageBox.Show("Debe ingresar Institución Impartidora", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If luePresupuesto.EditValue = Nothing Then
            MessageBox.Show("Debe seleccionar Presupuesto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If txtObjectivoCapacitacion.EditValue = Nothing Then
            MessageBox.Show("Debe ingresar Objetivo Capacitación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If txtPrograma.EditValue = Nothing Then
            MessageBox.Show("Debe ingresar Programa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If lueModalidadCompra.EditValue = Nothing Then
            MessageBox.Show("Debe seleccionar Modalidad de Compra", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If lueMetodologiaAprendizaje.EditValue = Nothing Then
            MessageBox.Show("Debe seleccionar Metodología de Aprendizaje", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If lueEstadoCapacitacion.EditValue = Nothing Then
            MessageBox.Show("Debe seleccionar Estado Capacitación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If txtCantidadHorasEjecutadas.EditValue = Nothing Then
            MessageBox.Show("Debe ingresar Cantidad Horas Ejecutadas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If txtNroParticipantes.EditValue = Nothing Then
            MessageBox.Show("Debe ingresar Números de Participantes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If lueTipoActividad.EditValue = Nothing Then
            MessageBox.Show("Debe seleccionar Tipo Actividad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If rogTipoPago.EditValue = Nothing Then
            MessageBox.Show("Debe seleccionar Tipo Pago", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If rogTipoPago.EditValue = 1 And txtCostoMonetario.EditValue = Nothing Then
            MessageBox.Show("Debe ingresar Costo Monetario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        'If txtCostoMonetario.EditValue = Nothing Then
        '    MessageBox.Show("Debe ingresar Costo Monetario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return False
        'End If
        If lueJornada.EditValue = Nothing Then
            MessageBox.Show("Debe seleccionar Jornada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If deeFechaInicio.EditValue = Nothing Then
            MessageBox.Show("Debe seleccionar Fecha Inicio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If deeFechaTermino.EditValue = Nothing Then
            MessageBox.Show("Debe seleccionar Fecha Término", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If teeHoraInicio.EditValue = Nothing Then
            MessageBox.Show("Debe seleccionar Hora Inicio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If teeHoraTermino.EditValue = Nothing Then
            MessageBox.Show("Debe seleccionar Hora Término", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub
End Class