Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmTraspasaMarcasyHorasExtras
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents tcpTrapasaMarcas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tcpTraspasaHorasExtrasyAtraso As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents memMensaje As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnTraspasarMarcas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dedFechaFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dedFechaInicial As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFechaFinal As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicial As System.Windows.Forms.Label
    Friend WithEvents txtNombreEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gleRut As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents gpcSeleccionEmpleado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkTodosLosEmpleados As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents gpcRangoFechas As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gpcBoton As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnTraspasarHaciaIntranet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tbcMain As DevExpress.XtraTab.XtraTabControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tbcMain = New DevExpress.XtraTab.XtraTabControl
        Me.tcpTrapasaMarcas = New DevExpress.XtraTab.XtraTabPage
        Me.btnTraspasarMarcas = New DevExpress.XtraEditors.SimpleButton
        Me.memMensaje = New DevExpress.XtraEditors.MemoEdit
        Me.tcpTraspasaHorasExtrasyAtraso = New DevExpress.XtraTab.XtraTabPage
        Me.gpcBoton = New DevExpress.XtraEditors.GroupControl
        Me.btnTraspasarHaciaIntranet = New DevExpress.XtraEditors.SimpleButton
        Me.gpcRangoFechas = New DevExpress.XtraEditors.GroupControl
        Me.dedFechaFinal = New DevExpress.XtraEditors.DateEdit
        Me.dedFechaInicial = New DevExpress.XtraEditors.DateEdit
        Me.lblFechaFinal = New System.Windows.Forms.Label
        Me.lblFechaInicial = New System.Windows.Forms.Label
        Me.gpcSeleccionEmpleado = New DevExpress.XtraEditors.GroupControl
        Me.chkTodosLosEmpleados = New DevExpress.XtraEditors.CheckEdit
        Me.gleRut = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.lblEmpleado = New System.Windows.Forms.Label
        Me.txtNombreEmpleado = New DevExpress.XtraEditors.TextEdit
        CType(Me.tbcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcMain.SuspendLayout()
        Me.tcpTrapasaMarcas.SuspendLayout()
        CType(Me.memMensaje.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcpTraspasaHorasExtrasyAtraso.SuspendLayout()
        CType(Me.gpcBoton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcBoton.SuspendLayout()
        CType(Me.gpcRangoFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcRangoFechas.SuspendLayout()
        CType(Me.dedFechaFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcSeleccionEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcSeleccionEmpleado.SuspendLayout()
        CType(Me.chkTodosLosEmpleados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcMain
        '
        Me.tbcMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcMain.Location = New System.Drawing.Point(0, 0)
        Me.tbcMain.Name = "tbcMain"
        Me.tbcMain.SelectedTabPage = Me.tcpTrapasaMarcas
        Me.tbcMain.Size = New System.Drawing.Size(576, 312)
        Me.tbcMain.TabIndex = 0
        Me.tbcMain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tcpTrapasaMarcas, Me.tcpTraspasaHorasExtrasyAtraso})
        Me.tbcMain.Text = "tbcTraspasosMain"
        '
        'tcpTrapasaMarcas
        '
        Me.tcpTrapasaMarcas.Controls.Add(Me.btnTraspasarMarcas)
        Me.tcpTrapasaMarcas.Controls.Add(Me.memMensaje)
        Me.tcpTrapasaMarcas.Name = "tcpTrapasaMarcas"
        Me.tcpTrapasaMarcas.PageVisible = False
        Me.tcpTrapasaMarcas.Size = New System.Drawing.Size(567, 281)
        Me.tcpTrapasaMarcas.Text = "Transferir Marcas Desde Control Acceso"
        '
        'btnTraspasarMarcas
        '
        Me.btnTraspasarMarcas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTraspasarMarcas.Location = New System.Drawing.Point(200, 192)
        Me.btnTraspasarMarcas.Name = "btnTraspasarMarcas"
        Me.btnTraspasarMarcas.Size = New System.Drawing.Size(136, 23)
        Me.btnTraspasarMarcas.TabIndex = 2
        Me.btnTraspasarMarcas.Text = "Transferir Marcas"
        '
        'memMensaje
        '
        Me.memMensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.memMensaje.EditValue = "Esta opción trasfiere los registros pendientes desde control de acceso, los cuale" & _
        "s posteriormente deberán ser procesados en la aplicación AsissCAD. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Si el bot" & _
        "ón esta deshabilitado indica que no hay registros pendientes a trasferir."
        Me.memMensaje.Enabled = False
        Me.memMensaje.Location = New System.Drawing.Point(104, 48)
        Me.memMensaje.Name = "memMensaje"
        '
        'memMensaje.Properties
        '
        Me.memMensaje.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.memMensaje.Properties.Appearance.Options.UseFont = True
        Me.memMensaje.Size = New System.Drawing.Size(336, 96)
        Me.memMensaje.TabIndex = 1
        '
        'tcpTraspasaHorasExtrasyAtraso
        '
        Me.tcpTraspasaHorasExtrasyAtraso.Controls.Add(Me.gpcBoton)
        Me.tcpTraspasaHorasExtrasyAtraso.Controls.Add(Me.gpcRangoFechas)
        Me.tcpTraspasaHorasExtrasyAtraso.Controls.Add(Me.gpcSeleccionEmpleado)
        Me.tcpTraspasaHorasExtrasyAtraso.Name = "tcpTraspasaHorasExtrasyAtraso"
        Me.tcpTraspasaHorasExtrasyAtraso.Size = New System.Drawing.Size(567, 281)
        Me.tcpTraspasaHorasExtrasyAtraso.Text = "Transfiere Horas Extras y Atraso Hacia Intranet"
        '
        'gpcBoton
        '
        Me.gpcBoton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcBoton.Controls.Add(Me.btnTraspasarHaciaIntranet)
        Me.gpcBoton.Location = New System.Drawing.Point(8, 208)
        Me.gpcBoton.Name = "gpcBoton"
        Me.gpcBoton.ShowCaption = False
        Me.gpcBoton.Size = New System.Drawing.Size(552, 64)
        Me.gpcBoton.TabIndex = 22
        Me.gpcBoton.Text = "GroupControl1"
        '
        'btnTraspasarHaciaIntranet
        '
        Me.btnTraspasarHaciaIntranet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTraspasarHaciaIntranet.Location = New System.Drawing.Point(176, 16)
        Me.btnTraspasarHaciaIntranet.Name = "btnTraspasarHaciaIntranet"
        Me.btnTraspasarHaciaIntranet.Size = New System.Drawing.Size(152, 23)
        Me.btnTraspasarHaciaIntranet.TabIndex = 0
        Me.btnTraspasarHaciaIntranet.Text = "Transferir a Intranet"
        '
        'gpcRangoFechas
        '
        Me.gpcRangoFechas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcRangoFechas.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcRangoFechas.AppearanceCaption.Options.UseFont = True
        Me.gpcRangoFechas.Controls.Add(Me.dedFechaFinal)
        Me.gpcRangoFechas.Controls.Add(Me.dedFechaInicial)
        Me.gpcRangoFechas.Controls.Add(Me.lblFechaFinal)
        Me.gpcRangoFechas.Controls.Add(Me.lblFechaInicial)
        Me.gpcRangoFechas.Location = New System.Drawing.Point(8, 96)
        Me.gpcRangoFechas.Name = "gpcRangoFechas"
        Me.gpcRangoFechas.Size = New System.Drawing.Size(552, 112)
        Me.gpcRangoFechas.TabIndex = 21
        Me.gpcRangoFechas.Text = "Rango de Fechas"
        '
        'dedFechaFinal
        '
        Me.dedFechaFinal.EditValue = Nothing
        Me.dedFechaFinal.Location = New System.Drawing.Point(240, 64)
        Me.dedFechaFinal.Name = "dedFechaFinal"
        '
        'dedFechaFinal.Properties
        '
        Me.dedFechaFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaFinal.Size = New System.Drawing.Size(112, 20)
        Me.dedFechaFinal.TabIndex = 16
        '
        'dedFechaInicial
        '
        Me.dedFechaInicial.EditValue = Nothing
        Me.dedFechaInicial.Location = New System.Drawing.Point(240, 40)
        Me.dedFechaInicial.Name = "dedFechaInicial"
        '
        'dedFechaInicial.Properties
        '
        Me.dedFechaInicial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaInicial.Size = New System.Drawing.Size(112, 20)
        Me.dedFechaInicial.TabIndex = 15
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(152, 68)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(80, 16)
        Me.lblFechaFinal.TabIndex = 14
        Me.lblFechaFinal.Text = "Fecha Final"
        Me.lblFechaFinal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(152, 44)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(80, 16)
        Me.lblFechaInicial.TabIndex = 13
        Me.lblFechaInicial.Text = "Fecha Inicial"
        Me.lblFechaInicial.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gpcSeleccionEmpleado
        '
        Me.gpcSeleccionEmpleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcSeleccionEmpleado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcSeleccionEmpleado.AppearanceCaption.Options.UseFont = True
        Me.gpcSeleccionEmpleado.Controls.Add(Me.chkTodosLosEmpleados)
        Me.gpcSeleccionEmpleado.Controls.Add(Me.gleRut)
        Me.gpcSeleccionEmpleado.Controls.Add(Me.lblEmpleado)
        Me.gpcSeleccionEmpleado.Controls.Add(Me.txtNombreEmpleado)
        Me.gpcSeleccionEmpleado.Location = New System.Drawing.Point(8, 8)
        Me.gpcSeleccionEmpleado.Name = "gpcSeleccionEmpleado"
        Me.gpcSeleccionEmpleado.Size = New System.Drawing.Size(552, 88)
        Me.gpcSeleccionEmpleado.TabIndex = 20
        Me.gpcSeleccionEmpleado.Text = "Selección de Empleado"
        '
        'chkTodosLosEmpleados
        '
        Me.chkTodosLosEmpleados.EditValue = True
        Me.chkTodosLosEmpleados.Location = New System.Drawing.Point(24, 24)
        Me.chkTodosLosEmpleados.Name = "chkTodosLosEmpleados"
        '
        'chkTodosLosEmpleados.Properties
        '
        Me.chkTodosLosEmpleados.Properties.Caption = "Todos los Empleados"
        Me.chkTodosLosEmpleados.Size = New System.Drawing.Size(136, 19)
        Me.chkTodosLosEmpleados.TabIndex = 0
        '
        'gleRut
        '
        Me.gleRut.EditValue = ""
        Me.gleRut.EnterMoveNextControl = True
        Me.gleRut.Location = New System.Drawing.Point(104, 56)
        Me.gleRut.Name = "gleRut"
        '
        'gleRut.Properties
        '
        Me.gleRut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleRut.Properties.View = Me.GridLookUpEdit1View
        Me.gleRut.Size = New System.Drawing.Size(96, 20)
        Me.gleRut.TabIndex = 18
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'lblEmpleado
        '
        Me.lblEmpleado.Location = New System.Drawing.Point(16, 60)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(80, 16)
        Me.lblEmpleado.TabIndex = 17
        Me.lblEmpleado.Text = "Rut Empleado"
        Me.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreEmpleado.Enabled = False
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(208, 56)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        '
        'txtNombreEmpleado.Properties
        '
        Me.txtNombreEmpleado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNombreEmpleado.Properties.Appearance.Options.UseFont = True
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(328, 20)
        Me.txtNombreEmpleado.TabIndex = 19
        '
        'frmTraspasaMarcasyHorasExtras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(576, 316)
        Me.Controls.Add(Me.tbcMain)
        Me.Name = "frmTraspasaMarcasyHorasExtras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferir Marcas y Horas Extras"
        CType(Me.tbcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcMain.ResumeLayout(False)
        Me.tcpTrapasaMarcas.ResumeLayout(False)
        CType(Me.memMensaje.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcpTraspasaHorasExtrasyAtraso.ResumeLayout(False)
        CType(Me.gpcBoton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcBoton.ResumeLayout(False)
        CType(Me.gpcRangoFechas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcRangoFechas.ResumeLayout(False)
        CType(Me.dedFechaFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcSeleccionEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcSeleccionEmpleado.ResumeLayout(False)
        CType(Me.chkTodosLosEmpleados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleRut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private empleado As empleado

    Private Sub frmTraspasaMarcasyHorasExtras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empleado = New empleado
        'buscarRegistros()
        activarControlesEmpleado()
        llenarEmpleado()
    End Sub

    Public Sub llenarEmpleado()
        gleRut.Properties.EditValueChangedFiringDelay = 1200
        gleRut.Properties.EditValueChangedFiringMode = EditValueChangedFiringMode.Buffered
        'Dos segundos se espera antes de gatillar la búsqueda (EditValueChanged)

        gleRut.Properties.ViewType = Repository.GridLookUpViewType.GridView
        gleRut.Properties.View.OptionsBehavior.AutoPopulateColumns = False
        gleRut.Properties.DataSource = repositorio.dvEmpleadosPlantaContrataActivosInactivos
        gleRut.Properties.DisplayMember = "RUT"

        Dim col1 As GridColumn = gleRut.Properties.View.Columns.AddField("RUT")
        col1.VisibleIndex = 0
        col1.Caption = "RUT"

        Dim col2 As GridColumn = gleRut.Properties.View.Columns.AddField("APELLIDO_PATERNO")
        col2.VisibleIndex = 1
        col2.Caption = "Apellido Paterno"

        Dim col3 As GridColumn = gleRut.Properties.View.Columns.AddField("APELLIDO_MATERNO")
        col3.VisibleIndex = 2
        col3.Caption = "Apellido Materno"

        Dim col4 As GridColumn = gleRut.Properties.View.Columns.AddField("NOMBRES")
        col4.VisibleIndex = 3
        col4.Caption = "Nombres"

        Dim col5 As GridColumn = gleRut.Properties.View.Columns.AddField("DESC_CALIDAD_JURIDICA")
        col5.VisibleIndex = 5
        col5.Caption = "Calidad Jurídica"
        col5.Visible = True

        Dim col6 As GridColumn = gleRut.Properties.View.Columns.AddField("DESC_ESTADO")
        col6.VisibleIndex = 4
        col6.Caption = "Estado"

        Dim col7 As GridColumn = gleRut.Properties.View.Columns.AddField("NOMBRE_COMPLETO")
        col7.VisibleIndex = 6
        col7.Caption = "Nombre Completo"
        col7.Visible = False

        gleRut.Properties.ValueMember = "EMPLEADO_ID"

        gleRut.Properties.View.BestFitColumns()
        gleRut.Properties.PopupFormWidth = 600

        gleRut.Text = ""
    End Sub

    Private Sub buscarRegistros()
        Dim numeroRegistros As Integer
        Cursor.Current = Cursors.WaitCursor
        numeroRegistros = empleado.buscaInteger("SELECT count(cardno) as registros FROM capresidencia.dual_pro_II_acs.dbo.t_cardevent WHERE (cast(cardno as int) >= 100001) and (cast(cardno as int) <= 199999) AND cardeventdate>=20080901 AND cardeventdate<>85200804 AND estado='P'")
        If numeroRegistros = 0 Then
            btnTraspasarMarcas.Enabled = False
        Else
            btnTraspasarMarcas.Enabled = True
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnTraspasarMarcas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTraspasarMarcas.Click
        If MessageBox.Show("¿Está seguro de proceder con el traspaso de los registros desde control de acceso?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes Then
            Dim cantidadRegistrosTraspasados As Integer
            btnTraspasarMarcas.Enabled = False
            Cursor.Current = Cursors.WaitCursor
            cantidadRegistrosTraspasados = empleado.traspasarMarcasControlAcceso(Date.Now.Year, Date.Now.Month)
            empleado.generaMarcaAssisCAD(0, Date.Now.Year, Date.Now.Month, 0)
            MessageBox.Show("Se han traspasado " & CType(cantidadRegistrosTraspasados, String) & " registros desde control de acceso." & Chr(13) & "Recuerde en calcular las horas extras y atraso en AsissCAD.", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            btnTraspasarMarcas.Enabled = True
            buscarRegistros()
            Cursor.Current = Cursors.Default
        End If
    End Sub
    Private Sub activarControlesEmpleado()
        If chkTodosLosEmpleados.Checked Then
            lblEmpleado.Visible = False
            gleRut.Visible = False
            txtNombreEmpleado.Visible = False
        Else
            lblEmpleado.Visible = True
            gleRut.Visible = True
            txtNombreEmpleado.Visible = True
        End If
    End Sub

    Private Sub chkTodosLosEmpleados_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTodosLosEmpleados.CheckedChanged
        activarControlesEmpleado()
    End Sub

    Private Sub btnTraspasarHaciaIntranet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTraspasarHaciaIntranet.Click
        Dim continuar As Boolean = True
        If dedFechaInicial.EditValue = Nothing Then
            continuar = False
            dedFechaInicial.ErrorText = "Debe especificar fecha inicial"
        End If
        If dedFechaFinal.EditValue = Nothing Then
            continuar = False
            dedFechaFinal.ErrorText = "Debe especificar fecha final"
        End If
        If dedFechaFinal.EditValue < dedFechaInicial.EditValue Then
            continuar = False
            dedFechaFinal.ErrorText = "Fecha final no puede ser anterior a fecha incial"
        End If
        If Not chkTodosLosEmpleados.Checked Then
            If gleRut.EditValue = Nothing Then
                continuar = False
                gleRut.ErrorText = "Falta especificar empleado"
            End If
        End If
        If continuar Then
            If MessageBox.Show("¿Está seguro de traspasas los registros desde AsissCAD hacia Intranet?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes Then
                Dim todosLosEmpleados, valorRetorno, empleadoID As Integer
                If chkTodosLosEmpleados.Checked Then
                    todosLosEmpleados = 1
                Else
                    todosLosEmpleados = 0
                    empleadoID = gleRut.EditValue
                End If
                btnTraspasarHaciaIntranet.Enabled = False
                Cursor.Current = Cursors.WaitCursor
                valorRetorno = CType(empleado.traspasarControlAsistenciaIntranet(todosLosEmpleados, dedFechaInicial.EditValue, dedFechaFinal.EditValue, empleadoID), Integer)
                Cursor.Current = Cursors.Default
                btnTraspasarHaciaIntranet.Enabled = True
                If valorRetorno = 0 Then
                    MessageBox.Show("Proceso de transferencia terminado correctamente", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    If valorRetorno = 1 Then
                        MessageBox.Show("El Proceso de transferencia no se ejecutó. No se transfirió ningún registro.", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Else
                        MessageBox.Show("El Proceso termino anormalmente. No se transfirió ningún registro.", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub gleRut_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gleRut.EditValueChanged
        Cursor.Current = Cursors.WaitCursor
        If IsNumeric(gleRut.EditValue) Then
            empleado = New empleado(CType(gleRut.EditValue, Long))
            txtNombreEmpleado.Text = empleado.nombreCompleto
        End If
        Cursor.Current = Cursors.Default
    End Sub

End Class
