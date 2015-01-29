Imports System.Data.SqlClient
Imports System.IO

Public Class frmAsignarCertificadoCapacitacion

    Private capacitacion_det_id As Integer
    Private nombre_empleado As String
    Private nombre_capacitacion As String

    Private Sub ComprobarExistenciaCertificado()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_comprueba_existencia_certificado_capacitacion", conn)
        Try
            Cursor = Cursors.AppStarting
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@capacitacion_det_id", capacitacion_det_id)
            conn.Open()

            lblEstadoCapacitacion.Text = command.ExecuteScalar
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub GuardarCertificado()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_guardar_certificado_capacitacion", conn)
        Try
            Dim ms As New MemoryStream()
            Dim fs As New FileStream(txtPathCertificado.EditValue.ToString.Trim, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)

            ms.SetLength(fs.Length)
            fs.Read(ms.GetBuffer(), 0, fs.Length)

            Dim arrCertificado() As Byte = ms.GetBuffer()
            ms.Flush()
            fs.Close()

            Cursor = Cursors.AppStarting
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@capacitacion_det_id", capacitacion_det_id)
            command.Parameters.AddWithValue("@certificado", arrCertificado)
            command.Parameters.AddWithValue("@nombre_certificado", Path.GetFileName(txtPathCertificado.EditValue))
            command.Parameters.AddWithValue("@mime_certificado", "application/pdf")
            command.Parameters.AddWithValue("@extension_certificado", Path.GetExtension(txtPathCertificado.EditValue))
            conn.Open()

            command.ExecuteNonQuery()

            MessageBox.Show("El certificado fue ingresado correctamente", "¡Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Function CheckFolderExists(ByVal sFolderName)
        Dim FileSystemObject
        FileSystemObject = CreateObject("Scripting.FileSystemObject")
        If (FileSystemObject.FolderExists(sFolderName)) Then
            CheckFolderExists = True
        Else
            CheckFolderExists = False
        End If
        FileSystemObject = Nothing
    End Function

    Public Sub New(ByVal capacitacion_det_id As Integer, ByVal nombre_empleado As String, ByVal nombre_capacitacion As String)
        InitializeComponent()
        Me.capacitacion_det_id = capacitacion_det_id
        Me.nombre_empleado = nombre_empleado
        Me.nombre_capacitacion = nombre_capacitacion
    End Sub

    Private Sub frmAsignarCertificadoCapacitacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtNombreParticipante.EditValue = nombre_empleado
        txtNombreCapacitacion.EditValue = nombre_capacitacion
        ComprobarExistenciaCertificado()
    End Sub

    Private Sub btnExaminar_Click(sender As System.Object, e As System.EventArgs) Handles btnExaminar.Click
        Dim examinar As New OpenFileDialog()
        examinar.Title = "Seleccione un Certificado"
        examinar.Filter = "Archivo PDF (*.pdf)|*pdf"
        If examinar.ShowDialog = DialogResult.OK Then
            txtPathCertificado.EditValue = examinar.FileName

        End If
    End Sub

    Private Sub btnGuardarCertificado_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarCertificado.Click
        If Not txtPathCertificado.EditValue = Nothing Then
            If MessageBox.Show("¿Está seguro de asignar Certificado a """ + nombre_empleado + """?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                GuardarCertificado()
                txtPathCertificado.EditValue = Nothing
                ComprobarExistenciaCertificado()
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        If lblEstadoCapacitacion.Text = "POSEE CERTIFICADO" Then
            Dim folder As String = Path.GetTempPath()
            folder = folder & "\Certificado PDF\"
            If CheckFolderExists(folder) = False Then
                System.IO.Directory.CreateDirectory(folder)
            End If

            Cursor = Cursors.AppStarting
            Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
            Dim command As New SqlCommand("sp_cap_obtener_certificado_capacitacion", conn)
            Dim dr As SqlDataReader
            Try
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@capacitacion_det_id", capacitacion_det_id)
                conn.Open()

                dr = command.ExecuteReader

                Do
                    While dr.Read
                        If File.Exists(folder & dr("NOMBRE_CERTIFICADO")) Then
                            File.Delete(folder & dr("NOMBRE_CERTIFICADO"))
                        End If

                        Dim certificado() As Byte = Nothing
                        Dim fs As FileStream
                        certificado = CType(dr("CERTIFICADO"), Byte())
                        fs = New FileStream(folder + dr("NOMBRE_CERTIFICADO"), FileMode.CreateNew, FileAccess.Write)
                        fs.Write(certificado, 0, certificado.Length)
                        fs.Close()

                        Dim psi As New ProcessStartInfo
                        Dim proceso As New Process
                        psi.FileName = folder + dr("NOMBRE_CERTIFICADO")
                        proceso = Process.Start(psi)

                    End While
                Loop While dr.NextResult

                dr.Dispose()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                conn.Dispose()
                command.Dispose()
                Cursor = Cursors.Default
            End Try

        End If
    End Sub
End Class