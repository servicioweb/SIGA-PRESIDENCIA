Imports System.Data.SqlClient

Public Class frmImpuestoSegundaCategoria

    Private periodoID As Integer

    Public Sub New(ByVal periodoID As Integer)
        InitializeComponent()

        Me.periodoID = periodoID
    End Sub

    Private Sub RefrescaGrillaTramos()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_remuneracion_obtener_impuesto_segunda_categoria", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@periodo_id", periodoID)
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)
            gdcTramos.DataSource = dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ObtenerDescripcionPeriodoValorUTM_ByPeriodoID()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_remuneracion_obtener_descPeriodo_valorUTM", conn)
        Dim dr As SqlDataReader
        Try
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@periodo_id", periodoID)
            conn.Open()

            dr = command.ExecuteReader

            Do
                While dr.Read()
                    txtPeriodo.Text = dr("DESCRIPCION_PERIODO")
                    txtUtm.Text = dr("VALOR_UTM")
                End While
            Loop While dr.NextResult

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmImpuestoSegundaCategoria_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ObtenerDescripcionPeriodoValorUTM_ByPeriodoID()
        RefrescaGrillaTramos()
    End Sub

    Private Sub gdvTramos_RowUpdated(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvTramos.RowUpdated
        If MessageBox.Show("¿Esta seguro de modificar el tramo seleccionado?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim impuestoID = gdvTramos.GetRowCellValue(e.RowHandle, "IMPUESTO_ID")
            Dim desdeUTM = gdvTramos.GetRowCellValue(e.RowHandle, "DESDE")
            Dim hastaUTM = gdvTramos.GetRowCellValue(e.RowHandle, "HASTA")
            Dim factor = gdvTramos.GetRowCellValue(e.RowHandle, "FACTOR")
            Dim rebajaUTM = gdvTramos.GetRowCellValue(e.RowHandle, "REBAJA")

            Cursor = Cursors.AppStarting
            Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
            Dim command As New SqlCommand("sp_remuneracion_actualiza_impuesto_tramo", conn)
            Try
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@periodo_id", periodoID)
                command.Parameters.AddWithValue("@impuesto_id", impuestoID)
                command.Parameters.AddWithValue("@desde", desdeUTM)
                command.Parameters.AddWithValue("@hasta", hastaUTM)
                command.Parameters.AddWithValue("@factor", factor)
                command.Parameters.AddWithValue("@rebaja", rebajaUTM)
                conn.Open()

                command.ExecuteNonQuery()

                MessageBox.Show("Tramo actualizado correctamente", "¡Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                RefrescaGrillaTramos()
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