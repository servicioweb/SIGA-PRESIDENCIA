Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.BusinessFacade
Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.SqlClient
Imports System.IO

Public Class frmGeneraArchivoPlanoImposiciones
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
    Friend WithEvents lbcRegistro As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents dvTxt As System.Data.DataView
    Friend WithEvents btnGenera As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gpcParametroMensual As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblTipoPago As System.Windows.Forms.Label
    Friend WithEvents rdgTipoPago As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lbcRegistro = New DevExpress.XtraEditors.ListBoxControl
        Me.dvTxt = New System.Data.DataView
        Me.btnGenera = New DevExpress.XtraEditors.SimpleButton
        Me.gpcParametroMensual = New DevExpress.XtraEditors.GroupControl
        Me.cboPeriodo = New System.Windows.Forms.ComboBox
        Me.lblTipoPago = New System.Windows.Forms.Label
        Me.rdgTipoPago = New DevExpress.XtraEditors.RadioGroup
        Me.lblPeriodo = New System.Windows.Forms.Label
        CType(Me.lbcRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcParametroMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcParametroMensual.SuspendLayout()
        CType(Me.rdgTipoPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbcRegistro
        '
        Me.lbcRegistro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbcRegistro.Appearance.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.lbcRegistro.Appearance.Options.UseFont = True
        Me.lbcRegistro.DisplayMember = "FILA"
        Me.lbcRegistro.Location = New System.Drawing.Point(8, 232)
        Me.lbcRegistro.Name = "lbcRegistro"
        Me.lbcRegistro.Size = New System.Drawing.Size(440, 208)
        Me.lbcRegistro.TabIndex = 14
        '
        'btnGenera
        '
        Me.btnGenera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenera.Location = New System.Drawing.Point(128, 184)
        Me.btnGenera.Name = "btnGenera"
        Me.btnGenera.Size = New System.Drawing.Size(168, 23)
        Me.btnGenera.TabIndex = 16
        Me.btnGenera.Text = "&Genera Archivo Plano"
        '
        'gpcParametroMensual
        '
        Me.gpcParametroMensual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpcParametroMensual.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcParametroMensual.AppearanceCaption.Options.UseFont = True
        Me.gpcParametroMensual.Controls.Add(Me.cboPeriodo)
        Me.gpcParametroMensual.Controls.Add(Me.lblTipoPago)
        Me.gpcParametroMensual.Controls.Add(Me.rdgTipoPago)
        Me.gpcParametroMensual.Controls.Add(Me.lblPeriodo)
        Me.gpcParametroMensual.Controls.Add(Me.btnGenera)
        Me.gpcParametroMensual.Location = New System.Drawing.Point(8, 8)
        Me.gpcParametroMensual.Name = "gpcParametroMensual"
        Me.gpcParametroMensual.Size = New System.Drawing.Size(440, 224)
        Me.gpcParametroMensual.TabIndex = 15
        Me.gpcParametroMensual.Text = "Periodo Actual"
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.Location = New System.Drawing.Point(136, 40)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(96, 21)
        Me.cboPeriodo.TabIndex = 28
        '
        'lblTipoPago
        '
        Me.lblTipoPago.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTipoPago.Location = New System.Drawing.Point(64, 72)
        Me.lblTipoPago.Name = "lblTipoPago"
        Me.lblTipoPago.Size = New System.Drawing.Size(64, 16)
        Me.lblTipoPago.TabIndex = 11
        Me.lblTipoPago.Text = "Tipo Pago"
        Me.lblTipoPago.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'rdgTipoPago
        '
        Me.rdgTipoPago.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdgTipoPago.EditValue = "01"
        Me.rdgTipoPago.Location = New System.Drawing.Point(136, 72)
        Me.rdgTipoPago.Name = "rdgTipoPago"
        '
        'rdgTipoPago.Properties
        '
        Me.rdgTipoPago.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("01", "Remuneraciones del mes"), New DevExpress.XtraEditors.Controls.RadioGroupItem("02", "Reproceso Histórico"), New DevExpress.XtraEditors.Controls.RadioGroupItem("03", "Bono Modernización")})
        Me.rdgTipoPago.Size = New System.Drawing.Size(160, 96)
        Me.rdgTipoPago.TabIndex = 10
        '
        'lblPeriodo
        '
        Me.lblPeriodo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPeriodo.Location = New System.Drawing.Point(80, 45)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 16)
        Me.lblPeriodo.TabIndex = 7
        Me.lblPeriodo.Text = "Período"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmGeneraArchivoPlanoImposiciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(456, 446)
        Me.Controls.Add(Me.gpcParametroMensual)
        Me.Controls.Add(Me.lbcRegistro)
        Me.Name = "frmGeneraArchivoPlanoImposiciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Genera Archivo Plano Imposiciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.lbcRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcParametroMensual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcParametroMensual.ResumeLayout(False)
        CType(Me.rdgTipoPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim parametroMensual As Periodo
    Dim empleado As Empleado
    Private Sub frmGeneraArchivoPlanoImposiciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empleado = New empleado
        cboPeriodo.DisplayMember = "DESCRIPCION_PERIODO"
        cboPeriodo.ValueMember = "PERIODO_ID"
        cboPeriodo.DataSource = repositorio.dvPeriodo
    End Sub

    Private Sub btnGenera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenera.Click
        Cursor.Current = Cursors.WaitCursor
        parametroMensual = New Periodo(Me.cboPeriodo.SelectedValue)
        Dim contador As Integer
        If empleado.generarArchivoPlanoImposiciones(rdgTipoPago.EditValue, parametroMensual.ID, parametroMensual.UF, parametroMensual.ufMesAnterior, parametroMensual.topeImponible1) Then
            lbcRegistro.Items.Clear()

            Dim mySelectQuery As String = "SELECT FILA FROM RH_REM_TXT_PLANO_PREVIRED ORDER BY TXT_PLANO_ID"
            Dim myConnection As New SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)
            Dim myCommand As New SqlCommand(mySelectQuery, myConnection)

            Try
                myConnection.Open()
                Dim myReader As SqlDataReader
                myReader = myCommand.ExecuteReader()
                While myReader.Read()
                    contador += 1
                    lbcRegistro.Items.Add(myReader("FILA"))
                End While
                myReader.Close()
                myConnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
        Cursor.Current = Cursors.Default

        Dim nombreArchivoProceso As String
        If rdgTipoPago.EditValue = "01" Then
            nombreArchivoProceso = "_NORMAL_"
        Else
            If rdgTipoPago.EditValue = "02" Then
                nombreArchivoProceso = "_REPROCESO_HISTORICO_"
            Else
                If rdgTipoPago.EditValue = "03" Then
                    nombreArchivoProceso = "_BONO_MODERNIZACION_"
                End If
            End If
        End If
        Dim FileName As String = "PREVIRED" & nombreArchivoProceso + CType(parametroMensual.ano, String) + Format(parametroMensual.mes, "00") + ".TXT"
        Dim strStreamW As Stream = Nothing
        Dim objReader As StreamWriter
        Dim dialogoGrabaTXT As New SaveFileDialog

        Dim i As Integer
        Try
            With dialogoGrabaTXT
                .FileName = FileName
                .Filter = "Archivos de Texto (*.txt)|*.txt"
                If .ShowDialog() = DialogResult.OK Then
                    FileName = .FileName
                End If
            End With
            strStreamW = File.Create(FileName)
            objReader = New StreamWriter(strStreamW, System.Text.Encoding.Default)
            For i = 0 To (lbcRegistro.Items.Count - 1)
                objReader.WriteLine(lbcRegistro.Items.Item(i))
            Next
            objReader.Close()
            System.Windows.Forms.MessageBox.Show("Se han generado " & contador & " al archivo plano.", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch es As Exception
            MessageBox.Show(es.Message)
        End Try

    End Sub
End Class
