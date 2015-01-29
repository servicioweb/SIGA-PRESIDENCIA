Imports System
Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class frmChequesViatico
    Inherits System.Windows.Forms.Form
    Dim connectionString As String = Comun.ArgoConfiguracion.ConnectionString
    Private Shared _Form As frmChequesViatico = Nothing

    Public Shared Property DefInstance() As frmChequesViatico
        Get
            If _Form Is Nothing OrElse _Form.IsDisposed Then
                _Form = New frmChequesViatico
            Else
                _Form.BringToFront()
            End If
            Return _Form
        End Get

        Set(ByVal value As frmChequesViatico)
            _Form = value
        End Set
    End Property

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
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtChequeDesde As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtChequeHasta As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.txtChequeDesde = New DevExpress.XtraEditors.TextEdit
        Me.txtChequeHasta = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.btnAnular = New DevExpress.XtraEditors.SimpleButton
        CType(Me.txtChequeDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChequeHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Location = New System.Drawing.Point(272, 297)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(184, 23)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "Imprmir"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(8, 8)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(712, 273)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = ""
        '
        'txtChequeDesde
        '
        Me.txtChequeDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtChequeDesde.Location = New System.Drawing.Point(128, 329)
        Me.txtChequeDesde.Name = "txtChequeDesde"
        Me.txtChequeDesde.TabIndex = 13
        Me.txtChequeDesde.Visible = False
        '
        'txtChequeHasta
        '
        Me.txtChequeHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtChequeHasta.Location = New System.Drawing.Point(256, 329)
        Me.txtChequeHasta.Name = "txtChequeHasta"
        Me.txtChequeHasta.TabIndex = 14
        Me.txtChequeHasta.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Location = New System.Drawing.Point(8, 329)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(112, 14)
        Me.LabelControl1.TabIndex = 15
        Me.LabelControl1.Text = "Anular cheques entre:"
        Me.LabelControl1.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Location = New System.Drawing.Point(240, 329)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(8, 14)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "y"
        Me.LabelControl2.Visible = False
        '
        'btnAnular
        '
        Me.btnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAnular.Location = New System.Drawing.Point(368, 329)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.TabIndex = 17
        Me.btnAnular.Text = "Anular"
        Me.btnAnular.Visible = False
        '
        'frmChequesViatico
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 358)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtChequeHasta)
        Me.Controls.Add(Me.txtChequeDesde)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "frmChequesViatico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresión de Cheques "
        CType(Me.txtChequeDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChequeHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public cheque_inicial_h As Integer
    Public cheque_final_h As Integer

    Private Sub EjecutarQuery(ByVal sqlSTR As String)
        Dim objcommand As New SqlClient.SqlCommand(sqlSTR, New SqlClient.SqlConnection(connectionString))
        objcommand.Connection.Open()
        objcommand.ExecuteNonQuery()
        objcommand.Connection.Close()
        objcommand.Dispose()
        objcommand = Nothing
    End Sub

    Private Sub previsualizaArchivo()
        Try
            OpenFileDialog1.FileName = Path.GetFullPath("imprimec.txt")
            RichTextBox1.LoadFile(OpenFileDialog1.FileName, _
               RichTextBoxStreamType.PlainText)
        Catch E As Exception
            MsgBox(E.Message)
        End Try
    End Sub

    Private Sub frmChequesViatico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        previsualizaArchivo()
        Me.txtChequeDesde.Text = cheque_inicial_h
        Me.txtChequeHasta.Text = cheque_final_h
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If MessageBox.Show("¿La impresora tiene el formualrio continuo de cheques?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Dim app_PathFile As String = Path.GetFullPath("imprimec.txt")
            Dim app_PathFileBat As String = Path.GetFullPath("imprimec.bat")
            ''Crea archivo .bat
            Dim nombre_txt As String = """" + app_PathFile + """"
            FileOpen(1, app_PathFileBat, OpenMode.Output)  ' Open file for output.
            PrintLine(1, "@echo off")   ' Print text to file.
            PrintLine(1, "type " & nombre_txt & " > lpt1")   ' Print in two print zones.
            FileClose(1)   ' Close file.
            Dim imprime As String
            imprime = Shell(app_PathFileBat)
            MessageBox.Show("Finalizó la emisión de cheques", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        If Me.txtChequeDesde.Text <= Me.txtChequeHasta.Text Then
            Dim strSQL As String = "exec sp_anular_cheque " & Me.txtChequeDesde.Text & ", " & Me.txtChequeHasta.Text
            EjecutarQuery(strSQL)
        Else
            MsgBox("El número del cheque inicial tiene que ser menor o igual al numero de cheque final")
        End If
    End Sub

End Class
