Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports NPOI
Imports NPOI.HSSF.UserModel
Imports NPOI.HSSF.Record
Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices

Public Class frmMantencionItemPeriodo_ImportarPlanilla
    Private periodo, item, tipo_proceso, resultado_validacion, usuario As String

    Public Sub New(ByVal periodo As String, ByVal item As String, ByVal tipo_proceso As String)
        InitializeComponent()
        Me.periodo = periodo
        Me.item = item
        Me.tipo_proceso = tipo_proceso
        usuario = presidencia.Seguridad.NombreUsuario
    End Sub

    Private Sub btnExaminar_Click(sender As System.Object, e As System.EventArgs) Handles btnExaminar.Click
        Dim examinar As New OpenFileDialog()
        examinar.Title = "Seleccione una Planilla"
        examinar.Filter = "Libro de Excel (*.xlsx)|*.xlsx|Libro de Excel 97-2003 (*.xls)|*.xls"
        examinar.FilterIndex = 2
        If examinar.ShowDialog = DialogResult.OK Then
            txtRutaPlanilla.Text = examinar.FileName
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        txtRutaPlanilla.Text = String.Empty
        moeResultados.Text = String.Empty
        btnProcesarInformacion.Enabled = False
    End Sub

    Private Sub btnProcesarPlanilla_Click(sender As System.Object, e As System.EventArgs) Handles btnProcesarPlanilla.Click
        Try
            If txtRutaPlanilla.Text.Trim.Length > 0 Then
                btnProcesarInformacion.Enabled = False

                Dim i As Integer
                
                Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtRutaPlanilla.Text.Trim + ";Mode=ReadWrite;Extended Properties=""Excel 12.0 Xml;HDR=NO;IMEX=1""")
                con.Open()
                Dim dset As DataSet = New DataSet
                Dim dadp As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM [Hoja1$]", con)
                dadp.TableMappings.Add("tbl", "Table")
                dadp.Fill(dset)
                Dim table As System.Data.DataTable = dset.Tables(0)
                Dim salida, fila As String
                moeResultados.Text = String.Empty
                Cursor = Cursors.AppStarting
                For i = 0 To table.Rows.Count - 1
                    fila = ""
                    For j As Integer = 0 To table.Columns.Count - 1
                        If j > 0 Then
                            fila += "," + If(table.Rows(i)(j).ToString.Trim.Length > 0, table.Rows(i)(j).ToString.Trim, "-1")
                        Else
                            fila += "(" + If(table.Rows(i)(j).ToString.Trim.Length > 0, table.Rows(i)(j).ToString.Trim, "-1")
                        End If
                        'salida += table.Rows(i)(j).ToString + vbTab
                    Next
                    If i > 0 Then
                        salida += ", " + fila + ", USER, GETDATE())"
                    Else
                        salida += fila + ", USER, GETDATE())"
                    End If
                Next

                dadp.Dispose()
                con.Close()

                Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
                Dim command As New SqlCommand("sp_remuneracion_guarda_planilla", conn)
                Try
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@usuario", usuario)
                    command.Parameters.AddWithValue("@values", salida)
                    conn.Open()
                    command.ExecuteNonQuery()

                    command = New SqlCommand("sp_remuneracion_validar_planilla", conn)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@periodo", periodo)
                    command.Parameters.AddWithValue("@item", item)
                    command.Parameters.AddWithValue("@tipo_proceso", tipo_proceso)
                    command.ExecuteNonQuery()

                    resultado_validacion = String.Empty
                    moeResultados.Text = String.Empty
                    Dim activar As Boolean = True
                    If Not ImprimeResultadoValidacion(1) Then
                        activar = False
                    End If
                    If Not ImprimeResultadoValidacion(2) Then
                        activar = False
                    End If
                    If Not ImprimeResultadoValidacion(3) Then
                        activar = False
                    End If
                    If Not ImprimeResultadoValidacion(4) Then
                        activar = False
                    End If
                    If Not ImprimeResultadoValidacion(5) Then
                        activar = False
                    End If
                    If Not ImprimeResultadoValidacion(6) Then
                        activar = False
                    End If

                    moeResultados.Text = If(activar, "¡Felicitaciones!" + vbNewLine + "La planilla no posee errores.", resultado_validacion)

                    btnProcesarInformacion.Enabled = activar
                    'moeResultados.Text = resultado_validacion

                Catch ex As Exception
                    moeResultados.Text = String.Empty
                    moeResultados.Text = ex.ToString
                Finally
                    conn.Dispose()
                    command.Dispose()
                End Try


                Cursor = Cursors.Default
            Else
                MessageBox.Show("Debe seleccionar una Planilla", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnExaminar.Focus()
            End If
        Catch ex As Exception
            moeResultados.Text = ex.ToString
        End Try

    End Sub

    Private Function ImprimeResultadoValidacion(ByVal tipo As Integer) As Boolean
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_remuneracion_obtener_resultado_validacion", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@tipo", tipo)
            conn.Open()

            Dim reader As SqlDataReader = command.ExecuteReader
            If reader.HasRows Then
                If tipo = 1 Then
                    resultado_validacion += "========================" + vbNewLine
                    resultado_validacion += "Existe "
                    Do While reader.Read
                        resultado_validacion += reader.GetValue(0).ToString
                    Loop
                    resultado_validacion += " celdas de RUT vacias." + vbNewLine
                    resultado_validacion += "========================" + vbNewLine
                    resultado_validacion += vbNewLine + vbNewLine
                ElseIf tipo = 2 Then
                    resultado_validacion += "========================" + vbNewLine
                    resultado_validacion += "Los siguientes RUT's no existen: " + vbNewLine
                    Do While reader.Read
                        resultado_validacion += reader.GetValue(0).ToString + vbNewLine
                    Loop
                    resultado_validacion += "========================" + vbNewLine
                    resultado_validacion += vbNewLine + vbNewLine
                ElseIf tipo = 3 Then
                    resultado_validacion += "========================" + vbNewLine
                    resultado_validacion += "Los siguientes RUT's no poseen un monto asignado: " + vbNewLine
                    Do While reader.Read
                        resultado_validacion += reader.GetValue(0).ToString + vbNewLine
                    Loop
                    resultado_validacion += "========================" + vbNewLine
                    resultado_validacion += vbNewLine + vbNewLine
                ElseIf tipo = 4 Then
                    resultado_validacion += "========================" + vbNewLine
                    resultado_validacion += "Los siguientes RUT's poseen Calidad Jurídica HONORARIO: " + vbNewLine
                    Do While reader.Read
                        resultado_validacion += reader.GetValue(0).ToString + vbNewLine
                    Loop
                    resultado_validacion += "========================" + vbNewLine
                    resultado_validacion += vbNewLine + vbNewLine
                ElseIf tipo = 5 Then
                    resultado_validacion += "========================" + vbNewLine
                    resultado_validacion += "Los siguientes RUT's poseen Calidad Jurídica PLANTA o CONTRATA y no estan ACTIVOS: " + vbNewLine
                    Do While reader.Read
                        resultado_validacion += reader.GetValue(0).ToString + vbNewLine
                    Loop
                    resultado_validacion += "========================" + vbNewLine
                    resultado_validacion += vbNewLine + vbNewLine
                ElseIf tipo = 6 Then
                    resultado_validacion += "========================" + vbNewLine
                    resultado_validacion += "Los siguientes RUT's ya han sido INGRESADOS en el MOVIMIENTO MENSUAL: " + vbNewLine
                    Do While reader.Read
                        resultado_validacion += reader.GetValue(0).ToString + vbNewLine
                    Loop
                    resultado_validacion += "========================" + vbNewLine
                    resultado_validacion += vbNewLine + vbNewLine
                End If

                conn.Dispose()
                command.Dispose()

                Return False
            Else
                'resultado_validacion += "========================" + vbNewLine
                'If tipo = 1 Then
                '    resultado_validacion += "NO POSEE RUT'S VACIOS" + vbNewLine
                'ElseIf tipo = 2 Then
                '    resultado_validacion += "TODOS LOS RUT EXISTEN" + vbNewLine
                'ElseIf tipo = 3 Then
                '    resultado_validacion += "TODOS LOS RUT'S TIENEN UN MONTO ASIGNADO" + vbNewLine
                'ElseIf tipo = 4 Then
                '    resultado_validacion += "NINGÚN RUT PERTENECE A LA CALIDAD JURÍDICA HONORARIO" + vbNewLine
                'ElseIf tipo = 5 Then
                '    resultado_validacion += "TODOS LOS RUT'S POSEEN CALIDAD JURÍDICA PLANTA O CONTRATA Y SE ENCUENTRAN ACTIVOS" + vbNewLine
                'ElseIf tipo = 6 Then
                '    resultado_validacion += "NINGÚN RUT HA SIDO INGRESADO EN EL MOVIMIENTO MENSUAL" + vbNewLine
                'End If
                'resultado_validacion += "========================" + vbNewLine
                'resultado_validacion += vbNewLine + vbNewLine

                Return True
            End If

        Catch ex As Exception
            moeResultados.Text = String.Empty
            moeResultados.Text = ex.ToString
        Finally
            conn.Dispose()
            command.Dispose()
        End Try
    End Function

    Private Sub frmMantencionItemPeriodo_ImportarPlanilla_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Cursor = Cursors.AppStarting

        'Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        'Dim command As New SqlCommand("sp_remuneracion_elimina_tablas_de_paso", conn)
        'Try
        '    command.CommandType = CommandType.StoredProcedure
        '    command.Parameters.AddWithValue("@token", token)
        '    conn.Open()
        '    command.ExecuteNonQuery()
        'Catch ex As Exception
        '    moeResultados.Text = String.Empty
        '    moeResultados.Text = ex.ToString
        'Finally
        '    conn.Dispose()
        '    command.Dispose()
        'End Try

        'Cursor = Cursors.Default
    End Sub

    Private Sub btnProcesarInformacion_Click(sender As System.Object, e As System.EventArgs) Handles btnProcesarInformacion.Click

        If MessageBox.Show("¿Usted esta seguro con guardar la Información contenida en el EXCEL?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Cursor = Cursors.AppStarting
            Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
            Dim command As New SqlCommand("sp_remuneracion_guarda_planilla_validada", conn)
            Try
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@periodo", periodo)
                command.Parameters.AddWithValue("@item", item)
                command.Parameters.AddWithValue("@tipo_proceso", tipo_proceso)
                conn.Open()
                command.ExecuteNonQuery()

                MessageBox.Show("La planilla ha sido ingresada con éxito", "¡Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnLimpiar_Click(sender, e)
            Catch ex As Exception
                moeResultados.Text = String.Empty
                moeResultados.Text = ex.ToString
            Finally
                conn.Dispose()
                command.Dispose()
                Cursor = Cursors.Default
            End Try
        End If

    End Sub
End Class