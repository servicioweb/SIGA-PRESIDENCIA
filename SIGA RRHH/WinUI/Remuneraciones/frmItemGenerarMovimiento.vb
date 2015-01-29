Imports cl.presidencia.Argo.BusinessRules
Imports System.Collections.Generic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient

Public Class frmItemGenerarMovimiento

    Private Item As Item
    Private Periodo As Periodo

    Private Sub frmItemGenerarMovimiento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Item = New Item
        LlenarItem()
        LlenarPeriodos()
        LlenarEmpleadoGrilla()
        btnCalcular.Enabled = False
        btnExcel.Enabled = False
        btnIncluirProcesoRemun.Enabled = False


    End Sub

    Private Sub LlenarItem()
        gleItems.Properties.DataSource = Item.recuperaItemRelacionado
        gleItems.Properties.DisplayMember = "DESCRIPCION_LARGA"
        gleItems.Properties.ValueMember = "RELACION_CABECERA_ID"
        gleItems.Properties.View.BestFitColumns()
        gleItems.Properties.PopupFormWidth = 460
        gleItems.Text = ""
    End Sub

    Private Sub LlenarPeriodos()
        With luePeriodo
            With .Properties.Columns
                .Add(New LookUpColumnInfo("PERIODO_ID", "ID Periodo", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ANO", "Año", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("MES", "Mes", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("ESTADO_PERIODO", "Estado Periodo", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION_PERIODO", "Periodo", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        luePeriodo.Properties.DataSource = repositorio.dvPeriodo
        luePeriodo.Properties.DisplayMember = "DESCRIPCION_PERIODO"
        luePeriodo.Properties.NullText = ""
        luePeriodo.Properties.PopupWidth = 150
        luePeriodo.Properties.ValueMember = "PERIODO_ID"
    End Sub

    Public Sub LlenarEmpleadoGrilla()
        gleRut.ViewType = Repository.GridLookUpViewType.GridView
        gleRut.View.OptionsBehavior.AutoPopulateColumns = False
        gleRut.DataSource = repositorio.dvEmpleadoVista
        gleRut.DisplayMember = "NOMBRE_COMPLETO"

        Dim col1 As GridColumn = gleRut.View.Columns.AddField("RUT")
        col1.VisibleIndex = 0
        col1.Caption = "RUT"

        Dim col2 As GridColumn = gleRut.View.Columns.AddField("APELLIDO_PATERNO")
        col2.VisibleIndex = 1
        col2.Caption = "Apellido Paterno"

        Dim col3 As GridColumn = gleRut.View.Columns.AddField("APELLIDO_MATERNO")
        col3.VisibleIndex = 2
        col3.Caption = "Apellido Materno"

        Dim col4 As GridColumn = gleRut.View.Columns.AddField("NOMBRES")
        col4.VisibleIndex = 3
        col4.Caption = "Nombres"

        Dim col5 As GridColumn = gleRut.View.Columns.AddField("EMPLEADO_ID")
        col5.VisibleIndex = 4
        col5.Caption = "ID"
        col5.Visible = False

        Dim col6 As GridColumn = gleRut.View.Columns.AddField("NOMBRE_COMPLETO")
        col6.VisibleIndex = 5
        col6.Caption = "Nombre Completo"
        col6.Visible = False

        Dim col7 As GridColumn = gleRut.View.Columns.AddField("DESC_CALIDAD_JURIDICA")
        col7.VisibleIndex = 5
        col7.Caption = "Calidad Jurídica"
        col7.Visible = True

        Dim col8 As GridColumn = gleRut.View.Columns.AddField("DESC_ESTADO")
        col8.VisibleIndex = 5
        col8.Caption = "Estado"
        col8.Visible = True

        gleRut.ValueMember = "EMPLEADO_ID"
        gleRut.View.BestFitColumns()
        gleRut.PopupFormWidth = 600
    End Sub

    Private Sub gleItems_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles gleItems.EditValueChanged, luePeriodo.EditValueChanged
        If gleItems.EditValue = Nothing Or luePeriodo.EditValue = Nothing Then
            Exit Sub
        End If
        RefrescarTramos()
    End Sub

    Private Sub gdvTramos_InitNewRow(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gdvTramos.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        view.SetRowCellValue(e.RowHandle, "RELACION_CABECERA_ID", gleItems.EditValue)
        view.SetRowCellValue(e.RowHandle, "PERIODO_ID", luePeriodo.EditValue)
        view.SetRowCellValue(e.RowHandle, "NOMBRE_TRAMO", Space(50))
        view.SetRowCellValue(e.RowHandle, "MONTO_DESDE", 0)
        view.SetRowCellValue(e.RowHandle, "MONTO_HASTA", 0)
        view.SetRowCellValue(e.RowHandle, "MONTO_PARA_ASIGNAR", 0)
        view.SetRowCellValue(e.RowHandle, "RELACION_TRAMO_ID", 0)
    End Sub

    Private Sub gdvTramos_InvalidRowException(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gdvTramos.InvalidRowException
        e.ExceptionMode = ExceptionMode.DisplayError
    End Sub

    Private Sub gdvTramos_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles gdvTramos.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim myview As DevExpress.XtraGrid.Views.Grid.GridView = sender
            If myview.IsNewItemRow(myview.FocusedRowHandle) Then
                MessageBox.Show("Para cancelar el nuevo registro debe presionar la tecla Esc (Escape)", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("¿Desea eliminar el registro seleccionado?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Cursor = Cursors.AppStarting
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                    Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
                    Dim command As New SqlCommand("sp_eliminaTramoItemGenerado", conn)
                    Try
                        command.CommandType = CommandType.StoredProcedure
                        command.Parameters.AddWithValue("@RELACION_TRAMO_ID", view.GetRowCellValue(view.FocusedRowHandle, "RELACION_TRAMO_ID"))
                        conn.Open()
                        command.ExecuteNonQuery()
                        RefrescarTramos()
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

    Private Sub gdvTramos_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gdvTramos.RowUpdated
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        Dim IdRelacionTramo As Integer = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("RELACION_TRAMO_ID"))
        Dim idPeriodo As Integer = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("PERIODO_ID"))
        Dim idRelacionCabecera As Integer = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("RELACION_CABECERA_ID"))
        Dim NombreTramo As String = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("NOMBRE_TRAMO"))
        Dim MontoDesde As Integer = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("MONTO_DESDE"))
        Dim MontoHasta As Integer = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("MONTO_HASTA"))
        Dim MontoAsignado As Integer = view.GetRowCellValue(view.FocusedRowHandle, view.Columns("MONTO_PARA_ASIGNAR"))

        If Item.ActualizarItemTramos(idRelacionCabecera, idPeriodo, NombreTramo, MontoDesde, MontoHasta, MontoAsignado, IdRelacionTramo) Then
            RefrescarTramos()
        End If
    End Sub

    Private Sub RefrescarTramos()
        gdcTramos.DataSource = Item.recuperaItemsTramosRelacionado(gleItems.EditValue, luePeriodo.EditValue)
        gdcEmpleados.DataSource = Item.recuperaMontosAsignadosSegunTramos(gleItems.EditValue, luePeriodo.EditValue)
        RefrescarBotones()
    End Sub

    Private Sub RefrescarBotones()
        Periodo = New Periodo(luePeriodo.EditValue)
        If gdvTramos.RowCount > 0 And Periodo.estadoPeriodo = True Then
            btnCalcular.Enabled = True
        Else
            btnCalcular.Enabled = False
        End If
        If gdvEmpleados.RowCount > 0 And Periodo.estadoPeriodo = True Then
            btnExcel.Enabled = True
            btnIncluirProcesoRemun.Enabled = True
        ElseIf gdvEmpleados.RowCount > 0 And Periodo.estadoPeriodo = False Then
            btnExcel.Enabled = True
            btnIncluirProcesoRemun.Enabled = False
        Else
            btnExcel.Enabled = False
            btnIncluirProcesoRemun.Enabled = False
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcular.Click
        If gdvTramos.RowCount > 0 Then
            If MessageBox.Show("¿Seguro desea asignar los montos a los empleados según los tramos?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Cursor = Cursors.AppStarting
                Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
                Dim command As New SqlCommand("sp_generaMontosSegunTramos", conn)
                Try
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@RELACION_CABECERA_ID", gleItems.EditValue.ToString)
                    command.Parameters.AddWithValue("@PERIODO_ID", luePeriodo.EditValue.ToString)
                    conn.Open()
                    command.ExecuteNonQuery()
                    RefrescarTramos()
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

    Private Sub btnExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExcel.Click
        If gdvEmpleados.RowCount > 0 Then
            Dim rutaPlanillaExcel As String
            Try
                With SaveFileDialog1
                    .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                    .DefaultExt = "xls"
                    .ShowDialog(Me)
                    rutaPlanillaExcel = SaveFileDialog1.FileName
                End With
                If rutaPlanillaExcel <> "" Then
                    colEMPLEADO_ID1.Visible = True
                    gdcEmpleados.ExportToXls(rutaPlanillaExcel)
                    colEMPLEADO_ID1.Visible = False
                End If
            Catch exp As Exception
                MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnIncluirProcesoRemun_Click(sender As System.Object, e As System.EventArgs) Handles btnIncluirProcesoRemun.Click
        If gdvEmpleados.RowCount > 0 Then
            If MessageBox.Show("¿Seguro desea incluir los montos asignados hacia el movimiento mensual?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
                Dim command As New SqlCommand("sp_generaMontosAsignadosTramosHaciaMovimientoMensual", conn)
                Try
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@RELACION_CABECERA_ID", gleItems.EditValue.ToString)
                    command.Parameters.AddWithValue("@PERIODO_ID", luePeriodo.EditValue.ToString)
                    conn.Open()
                    command.ExecuteNonQuery()
                    RefrescarTramos()
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
End Class