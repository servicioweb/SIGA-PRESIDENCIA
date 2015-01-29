Public Class frmBienvenida
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblVersion As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBienvenida))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblVersion = New DevExpress.XtraEditors.LabelControl
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblVersion
        '
        Me.lblVersion.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblVersion.Appearance.Options.UseForeColor = True
        Me.lblVersion.Location = New System.Drawing.Point(480, 240)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(80, 16)
        Me.lblVersion.TabIndex = 0
        '
        'frmBienvenida
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(744, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblVersion)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBienvenida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBienvenida"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region


    'Función para cerrar la ventana
    Private Sub Cerrar_Ventana()
        'Dentro de esta función, podríamos realizar diferentes acciones
        'como escribir un evento en el log o cualquier otra que 
        'consideremos oportuna (chequeo de errores, etc)

        Me.Close()

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Utilizamos una variable estática que almacenará
        'su valor cada vez que entremos en este evento
        Static bteContador As Byte
        'Teniendo en cuenta que el intervalo es de 1000 ms (1 sg)
        'a los 2 segundos pasaremos a finalizar la ventana de inicio
        If bteContador = 10 Then
            'Paramos el control Timer
            Timer1.Stop()
            'Lo deshabilitamos para asegurarnos su parada
            Timer1.Enabled = False
            'Llamamos a la función encargada de cerrar la ventana de inicio
            Cerrar_Ventana()

        Else
            'Incrementamos en una unidad la variable estática
            bteContador = bteContador + 1
        End If
    End Sub


    Private Sub frmBienvenida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblVersion.Text = Application.ProductVersion
    End Sub

    Private Sub frmBienvenida_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Cerrar_Ventana()
    End Sub
End Class
