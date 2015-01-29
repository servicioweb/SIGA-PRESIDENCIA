Imports cl.presidencia.Argo.BusinessRules
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class frmItemRelacionado

    Private empleado As New Empleado
    Private itemIDPadre, itemIDHijo As Integer

    Private Sub CargaHaberesDescuentos()
        gleHaberDescuento.Properties.DataSource = repositorio.dvItem
        gleHaberDescuento.Properties.DisplayMember = "DESCRIPCION_LARGA"
        gleHaberDescuento.Properties.ValueMember = "ITEM_ID"
        gleHaberDescuento.Properties.View.BestFitColumns()
        gleHaberDescuento.Properties.PopupFormWidth = 600
        gleHaberDescuento.Text = ""
    End Sub

    Private Sub frmItemRelacionado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LlenarItem()
        'llenarItemGrilla()

        CargaHaberesDescuentos()

    End Sub

    Private Sub LlenarItem()
        gleItems.Properties.DataSource = repositorio.dvItem
        gleItems.Properties.DisplayMember = "DESCRIPCION_LARGA"
        gleItems.Properties.ValueMember = "ITEM_ID"
        gleItems.Properties.View.BestFitColumns()
        gleItems.Properties.PopupFormWidth = 460
        gleItems.Text = ""
    End Sub

    Public Sub llenarItemGrilla()
        gleItemes.ViewType = Repository.GridLookUpViewType.GridView
        gleItemes.View.OptionsBehavior.AutoPopulateColumns = False
        gleItemes.DataSource = repositorio.dvItem
        gleItemes.DisplayMember = "DESCRIPCION_LARGA"

        Dim col1 As GridColumn = gleItemes.View.Columns.AddField("ITEM_ID")
        col1.VisibleIndex = 0
        col1.Caption = "RUT"
        col1.Visible = False

        Dim col2 As GridColumn = gleItemes.View.Columns.AddField("ITEM_ALIAS")
        col2.VisibleIndex = 1
        col2.Caption = "Código"

        Dim col3 As GridColumn = gleItemes.View.Columns.AddField("DESCRIPCION_LARGA")
        col3.VisibleIndex = 2
        col3.Caption = "Descripción"

        Dim col4 As GridColumn = gleItemes.View.Columns.AddField("ES_CALCULABLE")
        col4.VisibleIndex = 3
        col4.Caption = "Es Calculable"
        col4.Visible = False

        gleItemes.ValueMember = "ITEM_ID"
        gleItemes.View.BestFitColumns()
        gleItemes.PopupFormWidth = 600

    End Sub

    Private Sub RefrescaGrillla()
        empleado = New Empleado
        gdcDetalle.DataSource = Nothing
        gdcDetalle.DataSource = empleado.recuperarDatosItemesRelacionados(gleItems.EditValue)
    End Sub

    Private Sub gleItems_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles gleItems.EditValueChanged
        If gleItems.EditValue <> Nothing Then
            itemIDPadre = glvItems.GetFocusedRowCellValue("ITEM_ID")
            RefrescaGrillla()
        End If
    End Sub

    Private Sub gdvDetalle_InitNewRow(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvDetalle.InitNewRow
        Dim view As ColumnView = sender

        'view.SetRowCellValue(e.RowHandle, "ITEM_ID", gleItems.EditValue)
        'view.SetRowCellValue(e.RowHandle, "ITEM_ID_RELACION", 0)
    End Sub

    Private Sub gdvDetalle_InvalidRowException(sender As Object, e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvDetalle.InvalidRowException
        e.ExceptionMode = ExceptionMode.DisplayError
    End Sub

    Private Sub gdvDetalle_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvDetalle.RowUpdated
        If gdvDetalle.RowCount = 0 Then
            Exit Sub
        End If
        Dim rows As System.Data.DataRowView = e.Row
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetalle

        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_remuneracion_guarda_item_relacionado_detalle", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@item_id_padre", itemIDPadre)
            command.Parameters.AddWithValue("@item_id_hijo", itemIDHijo)
            conn.Open()
            command.ExecuteNonQuery()

            RefrescaGrillla()

            MessageBox.Show("El item ha sido asignado exitosamente", "¡Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            Throw New Exception(ex.ToString)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub gdvDetalle_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gdvDetalle.ValidateRow
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        If gleItems.EditValue = 0 Then
            e.ErrorText = "Falta escoger el item en la cabecera."
            e.Valid = False
        End If
        If view.GetRowCellValue(e.RowHandle, "ITEM_ID") <= 0 Then
            e.ErrorText = "Debe elegir un item de la lista en el detalle."
            e.Valid = False
        Else
            itemIDHijo = view.GetRowCellValue(e.RowHandle, "ITEM_ID")
            For i As Integer = 0 To view.RowCount - 1
                If itemIDPadre = view.GetRowCellValue(i, "ITEM_ID_CABECERA") And itemIDHijo = view.GetRowCellValue(i, "ITEM_ID") Then
                    'MessageBox.Show("El item seleccionado ya se encuentra relacionado.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.ErrorText = "El item seleccionado ya se encuentra relacionado."
                    e.Valid = False
                End If
            Next
        End If
    End Sub

    Private Sub gdvDetalle_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gdvDetalle.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim myview As DevExpress.XtraGrid.Views.Grid.GridView = sender
            If myview.IsNewItemRow(myview.FocusedRowHandle) Then
                MessageBox.Show("Para cancelar el nuevo registro debe presionar la tecla Esc (Escape)", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("¿Desea eliminar el registro seleccionado?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Cursor = Cursors.AppStarting
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                    Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
                    Dim command As New SqlCommand("sp_remuneracion_elimina_item_relacionado", conn)
                    Try
                        command.CommandType = CommandType.StoredProcedure
                        command.Parameters.AddWithValue("@relacion_cabecera_id", view.GetRowCellValue(view.FocusedRowHandle, "RELACION_CABECERA_ID"))
                        command.Parameters.AddWithValue("@item_id_hijo", view.GetRowCellValue(view.FocusedRowHandle, "ITEM_ID"))
                        conn.Open()
                        command.ExecuteNonQuery()

                        RefrescaGrillla()

                        MessageBox.Show("El item ha sido asignado exitosamente", "¡Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Catch ex As Exception
                        Throw New Exception(ex.ToString)
                    Finally
                        conn.Dispose()
                        command.Dispose()
                        Cursor = Cursors.Default
                    End Try
                End If

            End If
        End If
    End Sub

    Private Sub EstadoNuevo()
        'gleItems.Enabled = True
        gleHaberDescuento.Enabled = True
        btnCancelar.Enabled = True
        btnNuevo.Enabled = False
        btnAsignarHaberDescuentoAItem.Enabled = True
    End Sub
    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        EstadoNuevo()
    End Sub

    Private Sub EstadoCancelar()
        'gleItems.Enabled = False
        gleHaberDescuento.Enabled = False
        btnCancelar.Enabled = False
        btnNuevo.Enabled = True
        btnAsignarHaberDescuentoAItem.Enabled = False
    End Sub
    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        EstadoCancelar()
    End Sub

    Private Sub btnAsignarHaberDescuentoAItem_Click(sender As System.Object, e As System.EventArgs) Handles btnAsignarHaberDescuentoAItem.Click
        If gleHaberDescuento.EditValue = Nothing Then
            MessageBox.Show("Debe seleccionar un Haber-Descuento", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If
        itemIDHijo = gleHaberDescuento.EditValue
        For i As Integer = 0 To gdvDetalle.RowCount - 1
            If itemIDPadre = gdvDetalle.GetRowCellValue(i, "ITEM_ID_CABECERA") And itemIDHijo = gdvDetalle.GetRowCellValue(i, "ITEM_ID") Then
                MessageBox.Show("El item seleccionado ya se encuentra relacionado.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Next

        If itemIDPadre = itemIDHijo Then
            MessageBox.Show("No puede asignar el Item como Haber-Descuento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_remuneracion_guarda_item_relacionado_detalle", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@item_id_padre", itemIDPadre)
            command.Parameters.AddWithValue("@item_id_hijo", itemIDHijo)
            conn.Open()
            command.ExecuteNonQuery()

            RefrescaGrillla()
            CargaHaberesDescuentos()
            MessageBox.Show("El item ha sido asignado exitosamente", "¡Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            Throw New Exception(ex.ToString)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try

    End Sub
End Class