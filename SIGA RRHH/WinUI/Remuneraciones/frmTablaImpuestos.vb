Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.SqlClient

Public Class frmTablaImpuestos
    Inherits System.Windows.Forms.Form
    Dim empleado As empleado

    Private sw As Comun.EstadoEdicion = Comun.EstadoEdicion.NINGUNO


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
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcValoresMensuales As DevExpress.XtraGrid.GridControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositorioColumnas As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gcValoresMensuales = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.RepositorioColumnas = New System.Windows.Forms.ListBox
        CType(Me.gcValoresMensuales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcValoresMensuales
        '
        Me.gcValoresMensuales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'gcValoresMensuales.EmbeddedNavigator
        '
        Me.gcValoresMensuales.EmbeddedNavigator.Enabled = False
        Me.gcValoresMensuales.EmbeddedNavigator.Name = ""
        Me.gcValoresMensuales.EmbeddedNavigator.TextStringFormat = "Registros {0} de {1}"
        Me.gcValoresMensuales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcValoresMensuales.Location = New System.Drawing.Point(0, 0)
        Me.gcValoresMensuales.MainView = Me.GridView2
        Me.gcValoresMensuales.Name = "gcValoresMensuales"
        Me.gcValoresMensuales.Size = New System.Drawing.Size(712, 320)
        Me.gcValoresMensuales.TabIndex = 52
        Me.gcValoresMensuales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView1})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.gcValoresMensuales
        Me.GridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView2.Name = "GridView2"
        Me.GridView2.NewItemRowText = "Nuevo Registro"
        'Me.GridView2.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValesMode.Disabled
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gcValoresMensuales
        Me.GridView1.Name = "GridView1"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SimpleButton1.Location = New System.Drawing.Point(232, 328)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(184, 24)
        Me.SimpleButton1.TabIndex = 53
        Me.SimpleButton1.Text = "Insertar Nuevo Periodo"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SimpleButton2.Location = New System.Drawing.Point(32, 328)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(184, 23)
        Me.SimpleButton2.TabIndex = 54
        Me.SimpleButton2.Text = "Aceptar"
        '
        'RepositorioColumnas
        '
        Me.RepositorioColumnas.Location = New System.Drawing.Point(16, 192)
        Me.RepositorioColumnas.Name = "RepositorioColumnas"
        Me.RepositorioColumnas.Size = New System.Drawing.Size(120, 95)
        Me.RepositorioColumnas.TabIndex = 55
        Me.RepositorioColumnas.Visible = False
        '
        'frmTablaImpuestos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(712, 365)
        Me.Controls.Add(Me.RepositorioColumnas)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.gcValoresMensuales)
        Me.Name = "frmTablaImpuestos"
        Me.Text = "Tabla de Valores Mensuales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gcValoresMensuales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Funciones "
    Private Sub DesactivaPeriodosAnteriores()
        Dim strSQL As String = ""
        strSQL = strSQL & "UPDATE RH_REM_PERIODO SET ESTADO_PERIODO=0"
        EjecutarQuery(strSQL)
    End Sub
    Private Sub InsertaPeriodo(ByVal Organizacion As Integer)
        Dim strSQL As String = ""

        Dim UltimoRegistro As String = ""
        Dim numColumnas As Integer = GridView2.Columns.Count - 1
        Dim Columnas As String = ""
        Dim i As Integer

        GridView2.MoveLast()
        For i = 1 To numColumnas
            Columnas = Columnas & RepositorioColumnas.Items.Item(i) & ", "
            If i = 1 Or i = 2 Or i = 3 Or i = 6 Or i = 7 Then
                UltimoRegistro = UltimoRegistro & "'" & GridView2.GetRowCellValue(GridView2.FocusedRowHandle, GridView2.Columns(i)) & "', "
            Else
                UltimoRegistro = UltimoRegistro & Replace(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, GridView2.Columns(i)), ",", ".") & ", "
            End If

        Next
        UltimoRegistro = Replace(UltimoRegistro, "False", 0)
        UltimoRegistro = Replace(UltimoRegistro, "True", 1)
        UltimoRegistro = Mid(Trim(UltimoRegistro), 1, Len(Trim(UltimoRegistro)) - 1)
        Columnas = Mid(Trim(Columnas), 1, Len(Trim(Columnas)) - 1)
        strSQL = strSQL & "INSERT INTO RH_REM_PERIODO (" & Columnas & ")"
        strSQL = strSQL & "VALUES (" & UltimoRegistro & ")"
        EjecutarQuery(strSQL)

    End Sub
    Private Sub EjecutarQuery(ByVal sqlSTR As String)
        Dim objcommand As New SqlClient.SqlCommand(sqlSTR, New SqlClient.SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString))
        objcommand.Connection.Open()
        objcommand.ExecuteNonQuery()
        objcommand.Connection.Close()
        objcommand.Dispose()
        objcommand = Nothing
    End Sub
    Private Sub ActualizaUltimoRegistroInsertado()
        Dim UltimoIDInsertado As Integer
        Dim IDActual As Integer = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, GridView2.Columns(0))

        Dim strSQL As String = cl.presidencia.Argo.Comun.SQL.INSTRUCCIONES_SQL.SELECT_PERIODO_GENERAL

        Dim Usuario As String
        Dim FechaModificacion As Date
        Dim HoraModificacion As String
        Dim Ano As Integer
        Dim Mes As Integer
        Dim Dia As Integer
        Dim FechaInicioPeriodo As Date
        Dim DescripcionPeriodo As String
        Dim oConnection As New SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)
        Dim oCommand As New SqlCommand(strSQL, oConnection)
        oConnection.Open()
        Dim oReader As SqlDataReader = oCommand.ExecuteReader()
        Do
            While oReader.Read()
                Dia = CType(Format(CType(oReader("FECHA_PAGO_SUELDO"), Date), "dd"), Integer)
                Ano = oReader("ANO")
                Mes = CInt(oReader("MES")) + 1
                If Mes = 13 Then
                    Mes = 1
                    Ano = Ano + 1
                End If
            End While
        Loop While oReader.NextResult()
        oReader.Close()
        oConnection.Close()
        Usuario = "OTRO USUARIO"
        FechaModificacion = FormatDateTime(Now(), vbLongTime)
        HoraModificacion = FormatDateTime(Now(), vbShortTime)
        FechaInicioPeriodo = Dia & "/" & Mes & "/" & Ano
        DescripcionPeriodo = CStr(Ano) & "-" & CStr(Mes)
        If Len(Trim(Mes)) = 1 Then DescripcionPeriodo = CStr(Ano) & "-0" & CStr(Mes)
        GridView2.MoveLast()
        UltimoIDInsertado = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, GridView2.Columns(0))

        strSQL = "UPDATE RH_REM_PERIODO SET DESCRIPCION_PERIODO='" & DescripcionPeriodo & "', ESTADO_PERIODO=1, USUARIO='" & Usuario & "', FECHA_MODIFICACION='" & FechaModificacion & "', HORA_MODIFICACION='" & HoraModificacion & "', ANO=" & Ano & ", MES=" & Mes & ", FECHA_PAGO_SUELDO=Convert(datetime,'" & FechaInicioPeriodo & "',103) WHERE PERIODO_ID=" & UltimoIDInsertado
        EjecutarQuery(strSQL)
        refrescaGrillaValoresMensuales()
        GridView2.RefreshData()
    End Sub
    Private Sub refrescaGrillaValoresMensuales()
        Dim i As Integer

        Dim thisConnection As New SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)

        ' Sql Query
        Dim sql As String = cl.presidencia.Argo.Comun.SQL.INSTRUCCIONES_SQL.SELECT_PERIODO_GENERAL

        Try
            ' Create Data Adapter
            Dim da As New SqlDataAdapter
            da.SelectCommand = New SqlCommand(sql, thisConnection)

            ' Create and fill Dataset
            Dim ds As New DataSet
            da.Fill(ds, cl.presidencia.Argo.Comun.Tablas.RH_REM_PERIODO)

            ' Get The Data Table
            Dim dt As DataTable = ds.Tables(cl.presidencia.Argo.Comun.Tablas.RH_REM_PERIODO)

            ' Create Data View
            Dim dv As New DataView(dt)
            gcValoresMensuales.DataSource = dv
            For i = 0 To 6
                GridView2.Columns(i).Visible = False
            Next
        Catch ex As SqlException
            ' Display error
            Console.WriteLine("Error: " & ex.ToString())
        Finally
            ' Close Connection
            thisConnection.Close()
            Console.WriteLine("Connection Closed")
        End Try
        gcValoresMensuales.Refresh()
        RenombraColumnas()
    End Sub
    Private Sub RenombraColumnas()
        Dim i As Integer
        Dim numColumnas As Integer = GridView2.Columns.Count - 1
        For i = 0 To numColumnas
            RepositorioColumnas.Items.Add(GridView2.Columns(i).Caption)
        Next
        GridView2.Columns(0).Caption = "ID"
        GridView2.Columns(1).Caption = "Usuario BD"
        GridView2.Columns(2).Caption = "Fecha Modificación"
        GridView2.Columns(3).Caption = "Hora Modificación"
        GridView2.Columns(4).Caption = "Año"
        GridView2.Columns(5).Caption = "Mes"
        GridView2.Columns(6).Caption = "Descripción"
        GridView2.Columns(7).Caption = "Fecha De Pago"
        GridView2.Columns(8).Caption = "Estado"
        GridView2.Columns(9).Caption = "ID Organización"
        GridView2.Columns(10).Caption = "U.F."
        GridView2.Columns(11).Caption = "U.T.M."
        GridView2.Columns(12).Caption = "Cantidad Dias Mes"
        GridView2.Columns(13).Caption = "Edad Mínima"
        GridView2.Columns(14).Caption = "Año Nacimiento"
        GridView2.Columns(15).Caption = "Horas Diarias Trabajadas"
        GridView2.Columns(16).Caption = "Horas Extras Legal Diurnas"
        GridView2.Columns(17).Caption = "Horas Extras Legal Nocturnas"
        GridView2.Columns(18).Caption = "Recarga Hrs Extras Diurnas"
        GridView2.Columns(19).Caption = "Recarga Hrs Extras Nocturnas"
        GridView2.Columns(20).Caption = "% Viático"
        GridView2.Columns(21).Caption = "% Representación"
        GridView2.Columns(22).Caption = "% Tope Salud"
        GridView2.Columns(23).Caption = "Tope Imponible Previsión"
        GridView2.Columns(24).Caption = "Tope Imponible Retiro"
        GridView2.Columns(25).Caption = "Observaciones"
        GridView2.Columns(26).Caption = "Institución Seguridad"
        GridView2.Columns(27).Caption = "Código Previred"
        GridView2.Columns(28).Caption = "% Mensual Mutual Seg."
        GridView2.Columns(29).Caption = "Ítem Monto Mutual Seg."
        GridView2.Columns(30).Caption = "Nombre Institución Seguro"
        GridView2.Columns(31).Caption = "% Mensual Descuento Seguro 1"
        GridView2.Columns(32).Caption = "% Mensual Descuento Seguro 2"
        GridView2.Columns(33).Caption = "Ítem Seguro 1"
        GridView2.Columns(34).Caption = "Ítem Seguro 2"
        GridView2.Columns(35).Caption = "Ítem Dias Trabajados"
        GridView2.Columns(36).Caption = "Ítem Sueldo Base"
        GridView2.Columns(37).Caption = "Ítem Responsabilidad Superior"
        GridView2.Columns(38).Caption = "Ítem Asignación Familiar"
        GridView2.Columns(39).Caption = "Ítem Retención Judicial"
        GridView2.Columns(40).Caption = "Ítem Incremento Previsional"
        GridView2.Columns(41).Caption = "Ítem Ley 18.566 Salud"
        GridView2.Columns(42).Caption = "Ítem Ley 18.675 Art.10"
        GridView2.Columns(43).Caption = "Ítem Ley 18.675 Art.11"
        GridView2.Columns(44).Caption = "Ítem Ley 19.185 Art.18"
        GridView2.Columns(45).Caption = "Ítem Ley 19.185 Art.19"
        GridView2.Columns(46).Caption = "Ítem Gasto Representación"
        GridView2.Columns(47).Caption = "Ítem Ley 18.717"
        GridView2.Columns(48).Caption = "Ítem Monto Función Crítica"
        GridView2.Columns(49).Caption = "Ítem Monto Cotización Legal Previsional"
        GridView2.Columns(50).Caption = "Ítem Monto Cuenta Ahorro A.F.P."
        GridView2.Columns(51).Caption = "Ítem Monto Cotización Voluntaria A.F.P."
        GridView2.Columns(52).Caption = "Ítem Total Descuento Previsional"
        GridView2.Columns(53).Caption = "Ítem Monto Convenio Salud"
        GridView2.Columns(54).Caption = "Ítem Monto Plan Complementario Salud"
        GridView2.Columns(55).Caption = "Ítem Monto Plan A.U.G.E."
        GridView2.Columns(56).Caption = "Ítem Total Descuento ¨Salud"
        GridView2.Columns(57).Caption = "Ítem Monto A.P.V."
        GridView2.Columns(58).Caption = "Ítem Total Descuento A.P.V."
        GridView2.Columns(59).Caption = "Ítem Total Descuento Leyes Sociales"
        GridView2.Columns(60).Caption = "Ítem Total Trubitable"
        GridView2.Columns(61).Caption = "Ítem Impuesto Único"
        GridView2.Columns(62).Caption = "Ítem Retención 10%"
        GridView2.Columns(63).Caption = "Ítem Total Imponible 1"
        GridView2.Columns(64).Caption = "Ítem Total Imponible 2"
        GridView2.Columns(65).Caption = "Ítem Total Haberes"
        GridView2.Columns(66).Caption = "Ítem Total Deberes"
        GridView2.Columns(67).Caption = "Ítem Líquido Pago"

    End Sub
#End Region
    Private Sub frmTablaImpuestos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        repositorio.Show()
        refrescaGrillaValoresMensuales()
    End Sub

    Private Sub GridView2_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView2.RowUpdated
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        Dim i As Integer
        Dim numColumnas As Integer = GridView2.Columns.Count - 1
        Dim campos As String = ""
        Dim valores As String = ""
        Dim strSQL As String = ""
        For i = 7 To numColumnas
            If i = 7 Then
                campos = campos & RepositorioColumnas.Items.Item(i) & " = Convert(datetime,'" & view.GetRowCellValue(view.FocusedRowHandle, view.Columns(i)) & "',103), "
            Else
                campos = campos & RepositorioColumnas.Items.Item(i) & " = " & Replace(view.GetRowCellValue(view.FocusedRowHandle, view.Columns(i)), ",", ".") & ", "
            End If
        Next
        campos = Replace(campos, "False", 0)
        campos = Replace(campos, "True", 1)
        strSQL = Mid(Trim(campos), 1, Len(Trim(campos)) - 1)
        strSQL = "UPDATE RH_REM_PERIODO SET " & strSQL & " WHERE ESTADO_PERIODO = 1 AND PERIODO_ID=" & view.GetRowCellValue(view.FocusedRowHandle, view.Columns(0))
        EjecutarQuery(strSQL)
        'empleado.actualizarTablaImpuestos()
        refrescaGrillaValoresMensuales()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        InsertaPeriodo(1)
        refrescaGrillaValoresMensuales()
        GridView2.RefreshData()
        DesactivaPeriodosAnteriores()
        ActualizaUltimoRegistroInsertado()

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        refrescaGrillaValoresMensuales()
    End Sub
End Class
