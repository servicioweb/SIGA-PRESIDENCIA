Imports cl.presidencia.Argo.BusinessRules
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmImpuestoAcumulado

    Private IpcAcumulado As New Mantenedor

    Private Sub frmImpuestoAcumulado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtAño.EditValue = 0
        txtMes.EditValue = 0
        txtIPC.EditValue = 0
        HabilitarControles(False)
        btnGuardar.Enabled = False
        btnEliminar.Enabled = False
        LlenarIpcAcumulado()
    End Sub

    Private Sub LlenarIpcAcumulado()
        lueIpcAcumulado.Properties.Columns.Clear()
        With lueIpcAcumulado
            With .Properties.Columns
                .Add(New LookUpColumnInfo("IPC_ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("AÑO", "Año", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("MES", "Mes", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("VALOR", "Ipc Acumulado", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueIpcAcumulado.Properties.DisplayMember = "VALOR"
        lueIpcAcumulado.Properties.NullText = ""
        lueIpcAcumulado.Properties.PopupWidth = 300
        lueIpcAcumulado.Properties.ValueMember = "IPC_ID"
        lueIpcAcumulado.Properties.DataSource = IpcAcumulado.recuperarIpcAcumulado
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        InicializaControles()
    End Sub

    Private Sub Guardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim Id As Integer = IpcAcumulado.ActualizarIpcAcumulado(txtID.EditValue, txtAño.EditValue, txtMes.EditValue, txtIPC.EditValue)
        If Id < 0 Then
            MsgBox("Ya existe IPC acumulado para el año y mes", MsgBoxStyle.Exclamation, "SIGA")
            Exit Sub
        End If
        txtID.EditValue = Id
        LlenarIpcAcumulado()
        lueIpcAcumulado.EditValue = txtID.EditValue
    End Sub

    Private Sub btnEmilinar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If txtID.EditValue > 0 Then
            If (MessageBox.Show("¿Seguro desea eliminar el registro actual?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                IpcAcumulado.eliminarIpcAcumulado(txtID.EditValue)
                InicializaControles()
                LlenarIpcAcumulado()
            End If
        End If
    End Sub

    Private Sub HabilitarControles(habilita As Boolean)
        txtAño.Enabled = habilita
        txtMes.Enabled = habilita
        txtIPC.Enabled = habilita
    End Sub

    Private Sub InicializaControles()
        IpcAcumulado = New Mantenedor
        HabilitarControles(True)
        txtAño.EditValue = Date.Now.Year
        txtMes.EditValue = 0
        txtIPC.EditValue = 0
        txtID.EditValue = 0
        lueIpcAcumulado.EditValue = -1
        btnGuardar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub txtAño_EditValueChanged(sender As Object, e As System.EventArgs) Handles txtAño.EditValueChanged, txtMes.EditValueChanged, txtIPC.EditValueChanged
        If txtAño.EditValue > 0 And txtMes.EditValue > 0 And txtIPC.EditValue > 0 Then
            btnGuardar.Enabled = True
        End If
    End Sub

    Private Sub lueIpcAcumulado_EditValueChanged(sender As Object, e As System.EventArgs) Handles lueIpcAcumulado.EditValueChanged
        If lueIpcAcumulado.EditValue < 0 Then
            Exit Sub
        End If
        Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
        Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
        txtID.EditValue = row("IPC_ID")
        txtAño.EditValue = row("AÑO")
        txtMes.EditValue = row("MES")
        txtIPC.EditValue = row("VALOR")
        btnGuardar.Enabled = True
        btnEliminar.Enabled = True
        HabilitarControles(True)
        txtAño.Enabled = False
        txtMes.Enabled = False
    End Sub

   
End Class