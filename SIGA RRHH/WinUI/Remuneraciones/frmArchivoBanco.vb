Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.SqlClient
Imports System.IO

Public Class frmArchivoBanco
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
    Friend WithEvents gcArchivoBanco As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbcArchivoPlano As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnHonorarios As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPlantaContrata As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gcArchivoBanco = New DevExpress.XtraEditors.GroupControl
        Me.btnHonorarios = New DevExpress.XtraEditors.SimpleButton
        Me.btnPlantaContrata = New DevExpress.XtraEditors.SimpleButton
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.lbcArchivoPlano = New DevExpress.XtraEditors.ListBoxControl
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.gcArchivoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcArchivoBanco.SuspendLayout()
        CType(Me.lbcArchivoPlano, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcArchivoBanco
        '
        Me.gcArchivoBanco.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcArchivoBanco.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gcArchivoBanco.AppearanceCaption.Options.UseFont = True
        Me.gcArchivoBanco.Controls.Add(Me.btnHonorarios)
        Me.gcArchivoBanco.Controls.Add(Me.btnPlantaContrata)
        Me.gcArchivoBanco.Controls.Add(Me.btnGuardar)
        Me.gcArchivoBanco.Controls.Add(Me.lbcArchivoPlano)
        Me.gcArchivoBanco.Location = New System.Drawing.Point(0, 0)
        Me.gcArchivoBanco.Name = "gcArchivoBanco"
        Me.gcArchivoBanco.Size = New System.Drawing.Size(608, 360)
        Me.gcArchivoBanco.TabIndex = 0
        Me.gcArchivoBanco.Text = "Generación de archivo de banco"
        '
        'btnHonorarios
        '
        Me.btnHonorarios.Location = New System.Drawing.Point(144, 24)
        Me.btnHonorarios.Name = "btnHonorarios"
        Me.btnHonorarios.Size = New System.Drawing.Size(128, 23)
        Me.btnHonorarios.TabIndex = 5
        Me.btnHonorarios.Text = "Honorarios"
        '
        'btnPlantaContrata
        '
        Me.btnPlantaContrata.Location = New System.Drawing.Point(8, 24)
        Me.btnPlantaContrata.Name = "btnPlantaContrata"
        Me.btnPlantaContrata.Size = New System.Drawing.Size(128, 23)
        Me.btnPlantaContrata.TabIndex = 4
        Me.btnPlantaContrata.Text = "Planta y Contrata"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGuardar.Location = New System.Drawing.Point(120, 320)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(328, 23)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar Archivo Banco"
        '
        'lbcArchivoPlano
        '
        Me.lbcArchivoPlano.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbcArchivoPlano.Appearance.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.lbcArchivoPlano.Appearance.Options.UseFont = True
        Me.lbcArchivoPlano.Location = New System.Drawing.Point(8, 48)
        Me.lbcArchivoPlano.Name = "lbcArchivoPlano"
        Me.lbcArchivoPlano.Size = New System.Drawing.Size(592, 256)
        Me.lbcArchivoPlano.TabIndex = 1
        '
        'frmArchivoBanco
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 357)
        Me.Controls.Add(Me.gcArchivoBanco)
        Me.Name = "frmArchivoBanco"
        Me.Text = "Archivo Banco"
        CType(Me.gcArchivoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcArchivoBanco.ResumeLayout(False)
        CType(Me.lbcArchivoPlano, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Shared _Form As frmArchivoBanco = Nothing
    Public Shared Property DefInstance() As frmArchivoBanco
        Get
            If _Form Is Nothing OrElse _Form.IsDisposed Then
                _Form = New frmArchivoBanco
            Else
                _Form.BringToFront()
            End If
            Return _Form
        End Get
        Set(ByVal value As frmArchivoBanco)
            _Form = value
        End Set
    End Property
    Private Sub CargaArchivoBanco(ByVal CalidadJuridicaID As Integer)
        Dim PeriodoID As Integer

        Dim strSQL As String = "SELECT PERIODO_ID AS PERIODO_ID FROM RH_REM_PERIODO WHERE (ESTADO_PERIODO = 1)"
        Dim oConnectionPeriodo As New SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)
        Dim oCommand As New SqlCommand(strSQL, oConnectionPeriodo)
        oConnectionPeriodo.Open()
        Dim oReader As SqlDataReader = oCommand.ExecuteReader()
        Do
            While oReader.Read()
                PeriodoID = oReader("PERIODO_ID")
            End While
        Loop While oReader.NextResult()
        oReader.Close()
        oConnectionPeriodo.Close()



        Dim CalidadJuridica As Integer
        Dim FiltroDetalles As String = ""
        If CalidadJuridicaID < 1 Then
            CalidadJuridica = -1
            FiltroDetalles = ""
        Else
            CalidadJuridica = CalidadJuridicaID
            If CalidadJuridicaID = 1 Then
                FiltroDetalles = " AND (CALIDAD_JURIDICA_ID = 2 OR CALIDAD_JURIDICA_ID=3)"
            End If
            If CalidadJuridicaID = 2 Then
                FiltroDetalles = " AND (CALIDAD_JURIDICA_ID = 5)"
            End If
            End If
        lbcArchivoPlano.Items.Clear()
        Dim strSQL1 As String = ""
        strSQL1 = strSQL1 + " SELECT TIPO_REG + RUT_EMPRESA + DIGITO_VERIFICADOR + CODIGO_CONVENIO + FILLER1 + FECHA_GENERACION + FECHA_PROCESO + HORA_GENERACION + FILLER2 + FILLER3 + FILLER4 AS LINEA1 FROM dbo.VW_ARCHIVO_PLANO_ENCABEZADO_BRUTO WHERE (PERIODO_ID = " & PeriodoID & ")"
        strSQL1 = strSQL1 + " UNION ALL"
        strSQL1 = strSQL1 + " SELECT TIPO_REG+RUT_CLIENTE+DIGITO_VERIFICADOR+NOMBRE_FUNCIONARIO+FILLER1+INDICADOR_DE_CUENTA+NUMERO_DE_CUENTA_OTROS_BANCOS+NUMERO_DE_FACTURA+TIPO_DE_MOVIMIENTO+CODIGO+CUENTA_SECTOR_FINANCIERO+MONTO+CODIGO_PROPIO_EMPRESA+NUMERO_CUENTA_CARGO+FILLER2 AS LINEA1 FROM dbo.VW_ARCHIVO_PLANO_DETALLE_BRUTO WHERE (PERIODO_ID = " & PeriodoID & ")" & FiltroDetalles
        strSQL1 = strSQL1 + " UNION ALL"
        strSQL1 = strSQL1 + " SELECT     TIPO_REG+RIGHT('0000000000000' + CONVERT(VARCHAR, SUM(CONVERT(Bigint, MONTO_A_PROCESAR))), 15)+CONVERT(VARCHAR,SUM(CONVERT(Integer, CANTIDAD_DE_REG)))+FILLER1 AS LINEA1 FROM dbo.VW_ARCHIVO_PLANO_PIE_BRUTO_FINAL WHERE (PERIODO_ID = " & PeriodoID & ")" & FiltroDetalles & " GROUP BY TIPO_REG, FILLER1 "
        Dim oConnection As New SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)
        Dim oCommand1 As New SqlCommand(strSQL1, oConnection)
        oConnection.Open()
        Dim oReader1 As SqlDataReader = oCommand1.ExecuteReader()
        Do
            While oReader1.Read()
                lbcArchivoPlano.Items.Add(oReader1("LINEA1"))
            End While
        Loop While oReader1.NextResult()
        oReader1.Close()
        oConnection.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim FileName As String = "banco.txt"
        Dim objReader As StreamWriter
        Dim i As Integer
        Try
            With SaveFileDialog1
                .FileName = FileName
                .Filter = "Text files (*.txt)|*.txt|" & "All files|*.*"
                If .ShowDialog() = DialogResult.OK Then
                    FileName = .FileName
                End If
            End With
            objReader = New StreamWriter(FileName)
            For i = 0 To (lbcArchivoPlano.Items.Count - 1)
                objReader.WriteLine(lbcArchivoPlano.Items.Item(i))
            Next
            objReader.Close()
        Catch es As Exception
            MessageBox.Show(es.Message)
        End Try
    End Sub

    Private Sub btnPlantaContrata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlantaContrata.Click
        Cursor.Current = Cursors.WaitCursor

        Dim CalidadJuridicaID As Integer
        CalidadJuridicaID = 1 '0 para mostrar todos los funcionarios sin discriminar por calidad juridica'
        CargaArchivoBanco(CalidadJuridicaID)

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnHonorarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHonorarios.Click
        Cursor.Current = Cursors.WaitCursor

        Dim CalidadJuridicaID As Integer
        CalidadJuridicaID = 2 '0 para mostrar todos los funcionarios sin discriminar por calidad juridica'
        CargaArchivoBanco(CalidadJuridicaID)

        Cursor.Current = Cursors.Default
    End Sub
End Class
