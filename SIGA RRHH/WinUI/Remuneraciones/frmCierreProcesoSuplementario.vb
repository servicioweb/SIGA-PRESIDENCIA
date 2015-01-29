Imports cl.presidencia.Argo.BusinessRules
Public Class frmCierreProcesoSuplementario
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
    Friend WithEvents btnSi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnSi = New DevExpress.XtraEditors.SimpleButton
        Me.btnNo = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.SuspendLayout()
        '
        'btnSi
        '
        Me.btnSi.Location = New System.Drawing.Point(64, 96)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(112, 23)
        Me.btnSi.TabIndex = 1
        Me.btnSi.Text = "Sí"
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(192, 96)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(112, 23)
        Me.btnNo.TabIndex = 0
        Me.btnNo.Text = "No"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(24, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(352, 80)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Para proceder a cerrar el Proceso de ingreso de movimientos suplementario presion" & _
        "e Sí, en caso contrario No.                        ¿Está seguro(a) que desea pro" & _
        "ceder al cierre del proceso suplementario?                                      " & _
        "                                                NO PODRÁ REVERTIR LA OPERACIÓN E" & _
        " INGRESAR NUEVOS MOVIMIENTOS SUPLEMENTARIOS"
        '
        'frmCierreProcesoSuplementario
        '
        Me.AcceptButton = Me.btnNo
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(392, 141)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnSi)
        Me.Name = "frmCierreProcesoSuplementario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cierre Proceso Suplementario"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCierreProcesoSuplementario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (New Periodo).procesoSuplementarioCerrado Then
            btnSi.Visible = False
            btnNo.Text = "Salir"
        End If
        Beep()
        Beep()
    End Sub

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        Me.Close()
    End Sub

    Private Sub btnSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSi.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            Procesos.CierreProcesoSuplementario((New Periodo).ID)
            Cursor.Current = Cursors.Default
            MessageBox.Show("Se ha cerrado el proceso suplementario en forma satisfactoria", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch exp As Exception
            MessageBox.Show(exp.Message, "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
