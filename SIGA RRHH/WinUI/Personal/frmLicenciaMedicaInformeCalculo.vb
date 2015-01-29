Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Reportes
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns

Public Class frmLicenciaMedicaInformeCalculo

    Private empleado As New Empleado

    Private Sub frmLicenciaMedicaInformeCalculo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        gdcLicenciaMedica.Visible = False
        LlenarEmpleado()
        LlenarDepartamento()
        LlenarIsapre()
        dedFechaInicio.EditValue = Date.Now.Date
        dedFechaFinal.EditValue = Date.Now.Date
        gleEmpleado.EditValue = -1
        lueDepartamento.EditValue = -1
        lueIsapre.EditValue = -1
    End Sub

    Private Sub LlenarEmpleado()
        Repository.RepositoryItem.EditValueChangedFiringDelay = 1200
        gleEmpleado.Properties.View.Columns.Clear()
        gleEmpleado.Properties.EditValueChangedFiringMode = EditValueChangedFiringMode.Buffered
        'Dos segundos se espera antes de gatillar la búsqueda (EditValueChanged)

        gleEmpleado.Properties.ViewType = Repository.GridLookUpViewType.GridView
        gleEmpleado.Properties.View.OptionsBehavior.AutoPopulateColumns = False

        gleEmpleado.Properties.DataSource = repositorio.dvEmpleadoFichaHistorica 'repositorio.dvEmpleadoVista

        gleEmpleado.Properties.DisplayMember = "RUT"

        Dim col1 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("RUT")
        col1.VisibleIndex = 0
        col1.Caption = "RUT"

        Dim col2 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("APELLIDO_PATERNO")
        col2.VisibleIndex = 1
        col2.Caption = "Apellido Paterno"

        Dim col3 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("APELLIDO_MATERNO")
        col3.VisibleIndex = 2
        col3.Caption = "Apellido Materno"

        Dim col4 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("NOMBRES")
        col4.VisibleIndex = 3
        col4.Caption = "Nombres"

        Dim col5 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("DESC_ESTADO")
        col5.VisibleIndex = 4
        col5.Caption = "Estado"

        Dim col6 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("DESC_CALIDAD_JURIDICA")
        col6.VisibleIndex = 5
        col6.Caption = "Calidad Jurídica"

        Dim col7 As GridColumn = gleEmpleado.Properties.View.Columns.AddField("EMPLEADO_ID")
        col7.VisibleIndex = 6
        col7.Caption = "ID Empleado"
        col7.Visible = False

        gleEmpleado.Properties.ValueMember = "EMPLEADO_ID"
        gleEmpleado.Properties.View.BestFitColumns()
        gleEmpleado.Properties.PopupFormWidth = 600
    End Sub

    Public Sub LlenarIsapre()
        With lueIsapre
            With .Properties.Columns
                .Add(New LookUpColumnInfo("ISAPRE_ID", "ID Isapre", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Nombre Isapre", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueIsapre.Properties.DataSource = repositorio.dvIsapre
        lueIsapre.Properties.DisplayMember = "DESCRIPCION"
        lueIsapre.Properties.NullText = ""
        lueIsapre.Properties.PopupWidth = 400
        lueIsapre.Properties.ValueMember = "ISAPRE_ID"
    End Sub
    Private Sub LlenarDepartamento()
        With lueDepartamento
            With .Properties.Columns
                .Add(New LookUpColumnInfo("DEPTO_ID", "ID Depto", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Nombre Departamento", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueDepartamento.Properties.DataSource = repositorio.dvDepartamentos
        lueDepartamento.Properties.DisplayMember = "DESCRIPCION"
        lueDepartamento.Properties.NullText = ""
        lueDepartamento.Properties.PopupWidth = 400
        lueDepartamento.Properties.ValueMember = "DEPTO_ID"
    End Sub

    Private Sub btnGenerar_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerar.Click
        GenerarInforme()
    End Sub

    Private Sub gleEmpleado_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles gleEmpleado.EditValueChanged
        If gleEmpleado.EditValue > 0 Then
            chkTodosLosEmpleados.Checked = False
        End If
    End Sub

    Private Sub lueIsapre_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles lueIsapre.EditValueChanged
        If lueIsapre.EditValue > 0 Then
            chkTodasLasInstitucionesSalud.Checked = False
        End If
    End Sub

    Private Sub lueDepartamento_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles lueDepartamento.EditValueChanged
        If lueDepartamento.EditValue > 0 Then
            chkTodosLosDeptos.Checked = False
        End If
    End Sub

    Private Sub GenerarInforme()
        Dim tipoFiltro As Integer = 0
        If Not gleEmpleado.EditValue Is Nothing And chkTodosLosEmpleados.Checked = False And lueDepartamento.EditValue < 0 And lueIsapre.EditValue < 0 And dedFechaFinal.EditValue >= dedFechaInicio.EditValue Then
            tipoFiltro = 1 'Por un empleado y rango fecha
        ElseIf chkTodosLosEmpleados.Checked = True And lueDepartamento.EditValue < 0 And lueIsapre.EditValue < 0 And dedFechaFinal.EditValue >= dedFechaInicio.EditValue Then
            tipoFiltro = 2 'Todos los empleados por rango fecha
        ElseIf chkTodosLosEmpleados.Checked = True And lueDepartamento.EditValue > 0 And lueIsapre.EditValue < 0 And dedFechaFinal.EditValue >= dedFechaInicio.EditValue Then
            tipoFiltro = 3 'Todos los empleados, un departamento y por rango fecha
        ElseIf chkTodosLosEmpleados.Checked = True And chkTodosLosDeptos.Checked = True And lueIsapre.EditValue < 0 And dedFechaFinal.EditValue >= dedFechaInicio.EditValue Then
            tipoFiltro = 1 'Todos los empleados, todos los departamentos y por rango fecha
        ElseIf chkTodosLosEmpleados.Checked = True And chkTodosLosDeptos.Checked = True < 0 And lueIsapre.EditValue > 0 And dedFechaFinal.EditValue >= dedFechaInicio.EditValue Then
            tipoFiltro = 4 'Todos los empleados, una isaapre y por rango fecha
        ElseIf chkTodosLosEmpleados.Checked = True And lueDepartamento.EditValue < 0 And chkTodasLasInstitucionesSalud.Checked = True And dedFechaFinal.EditValue >= dedFechaInicio.EditValue Then
            tipoFiltro = 1 'Todos los empleados, todas las isaapre y por rango fecha
        ElseIf lueIsapre.EditValue > 0 And lueDepartamento.EditValue > 0 And dedFechaFinal.EditValue >= dedFechaInicio.EditValue Then
            tipoFiltro = 5 'Una isapre, un depto y por rango fecha
        End If

        If tipoFiltro = 0 Then
            MessageBox.Show("Los filtros de selección son incorrectos, reviselos.", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Cursor.Current = Cursors.WaitCursor
        gdcLicenciaMedica.DataSource = empleado.recuperaLicenciaMedicaPorFiltro(tipoFiltro, dedFechaInicio.EditValue, dedFechaFinal.EditValue, gleEmpleado.EditValue, lueDepartamento.EditValue, lueIsapre.EditValue)
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvLicenciaMedica
        Dim licenciaMedicaID As Integer
        Dim strFormulaSeleccion As String = ""
        If gdvLicenciaMedica.RowCount > 0 Then
            For i As Integer = 0 To gdvLicenciaMedica.RowCount - 1
                licenciaMedicaID = view.GetRowCellValue(i, "LICENCIA_MEDICA_ID")
                empleado.CrearRentaPromedioEmpleadoLicMedica(licenciaMedicaID)
                If i = 0 Then
                    strFormulaSeleccion = "{VW_RENTA_PROMEDIO_LICENCIA_MEDICA_DETALLE.LICENCIA_MEDICA_ID}=" & licenciaMedicaID.ToString
                Else
                    strFormulaSeleccion = strFormulaSeleccion + " OR {VW_RENTA_PROMEDIO_LICENCIA_MEDICA_DETALLE.LICENCIA_MEDICA_ID}=" & licenciaMedicaID.ToString
                End If
            Next

            Dim ventanaReporte1 As New ventanaReporte
            Dim reporte As New rptInformeCalculoLicenciaMedica
            WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
            ventanaReporte1.rptVisor.SelectionFormula = strFormulaSeleccion
            ventanaReporte1.rptVisor.ShowParameterPanelButton = False
            ventanaReporte1.rptVisor.ShowCloseButton = False
            ventanaReporte1.rptVisor.ShowGroupTreeButton = False
            ventanaReporte1.rptVisor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            ventanaReporte1.rptVisor.ReportSource = reporte
            ventanaReporte1.Show()
            Cursor.Current = Cursors.Default
        End If
    End Sub

    Private Sub chkTodosLosEmpleados_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTodosLosEmpleados.CheckedChanged
        If chkTodosLosEmpleados.Checked = True Then
            gleEmpleado.EditValue = -1
        End If
    End Sub

    Private Sub chkTodasLasInstitucionesSalud_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTodasLasInstitucionesSalud.CheckedChanged
        If chkTodasLasInstitucionesSalud.Checked = True Then
            lueIsapre.EditValue = -1
        End If
    End Sub

    Private Sub chkTodosLosDeptos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTodosLosDeptos.CheckedChanged
        If chkTodosLosDeptos.Checked = True Then
            lueDepartamento.EditValue = -1
        End If
    End Sub
End Class