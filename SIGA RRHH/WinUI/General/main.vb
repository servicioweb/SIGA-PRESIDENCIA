Imports System.Threading
'Imports System.Configuration.AppSettingsReader
Imports cl.presidencia.Argo.Comun
Imports System.Runtime.InteropServices
Imports cl.presidencia.Argo.BusinessRules


Module main
    'La siguiente función tiene el propósito de permitir la ejecución de la applicación, siempre 
    'y cuando, no exista una instancia previa
    Public repositorio As frmrepositorio
    Private version As Version

    Public Sub Main()
        Cursor.Current = Cursors.WaitCursor
        Dim nueva As Boolean
        Dim mutex As New mutex(True, "SIGA", nueva)
        If Not nueva Then
            MessageBox.Show("La aplicación ya se está ejecutando", "SIGA-Presidencia de la República", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cursor.Current = Cursors.Default
            Exit Sub
        End If
        Version = New Version
        Dim ultimaVersion As String = obtieneVersionSIGA()
        Dim versionActual As String = Application.ProductVersion

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-ES")
            System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("es")
            'versionActual = "1.0.4248.16867"
            'ultimaVersion = "1.0.4248.16867"
            If establecerPermisos() Then
                'If ultimaVersion = versionActual Then
                If 1 = 1 Then
                    'El repositorio contiene estructuras de datos DataViews 
                    'para disminuir el tiempo de ejecución y acceso a los datos persistentes.
                    'Debe estar presente durante toda la ejecución del sistema.
                    repositorio = New frmrepositorio
                    repositorio.Show()
                    repositorio.Hide()

                    Dim frmBienvenida As New frmBienvenida
                    frmBienvenida.Show()

                    'Inicio de ventana principal del sistema. Esta ventana contiene el menú principal del sistema.
                    'Aqui también se establece el permiso de los usuarios a las distintas opciones.
                    Application.Run(New frmMain)
                    'Creación de conexión a BD
                    Cursor.Current = Cursors.Default
                    GC.KeepAlive(mutex)
                Else
                    MsgBox("La versión SIGA en su equipo (" & Application.ProductVersion & ") es distinta a la última versión liberada (" & ultimaVersion & ")" & Chr(13) & Chr(13) & "Por favor comuniquese con soporte técnico a usuario.", MsgBoxStyle.Information, "SIGA")
                    Application.Exit()
                End If
            Else
                MsgBox("Usted no tiene permiso para ejecutar SIGA." & Chr(13) & "Por favor comuníquese con el departamento de RRHH.", MsgBoxStyle.Information, "SIGA")
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Function establecerPermisos() As Boolean
        'Comprueba si tiene acceso como usuario a los siguientes grupos definidos en el dominio 
        Dim tieneAcceso As Boolean = False
        If ArgoConfiguracion.tieneActiveDirectory = "False" Then
            Return True
        End If
        If Seguridad.TienePermiso("REM-Acceso Total") Or _
            Seguridad.TienePermiso("PER-Licencias Medicas") Or _
            Seguridad.TienePermiso("PER-Acceso Total") Or _
            Seguridad.TienePermiso("REM-Definición Item") Or _
            Seguridad.TienePermiso("REM-Parámetros Mensuales") Or _
            Seguridad.TienePermiso("REM-Cálculo Remuneraciones") Or _
            Seguridad.TienePermiso("REM-Cierre Procesos") Or _
            Seguridad.TienePermiso("REM-Cierre Mensual") Or _
            Seguridad.TienePermiso("REM-Consulta Informes") Or _
            Seguridad.TienePermiso("REM-Escala Unica de Sueldos") Or _
            Seguridad.TienePermiso("PER-Ficha de Empleados") Or _
            Seguridad.TienePermiso("PER-Solo Lectura - Consulta Personal") Or _
            Seguridad.TienePermiso("PER-Cargas Familiares y Grupo") Or _
            Seguridad.TienePermiso("PER-Eventos Administrativos") Or _
            Seguridad.TienePermiso("PER-Control Horas Extras") Or _
            Seguridad.TienePermiso("REM-Horas Extras") Or _
            Seguridad.TienePermiso("PER-Horas Extras") Or _
            Seguridad.TienePermiso("REM-Generación de Archivos") Or _
            Seguridad.TienePermiso("PER-Control de Viaticos") Or _
            Seguridad.TienePermiso("PER-Hoja de Vida Laboral") Or _
            Seguridad.TienePermiso("PER-Cambio Situación Laboral") Or _
            Seguridad.TienePermiso("PER-Informes") Or _
            Seguridad.TienePermiso("PER-Informes Dinámicos") Or _
            Seguridad.TienePermiso("COM-Mantencion Tablas Maestras Personal") Or _
            Seguridad.TienePermiso("BIE-Acceso Total") Or _
            Seguridad.TienePermiso("PER-Ficha Empleados-Con Montos") Or _
            Seguridad.TienePermiso("PER-Seguridad") Or _
            Seguridad.TienePermiso("PER-Tesoreria") Or _
            Seguridad.TienePermiso("SIGA-Desarrollo") Or _
            Seguridad.TienePermiso("SIGA Personal") Or _
            Seguridad.TienePermiso("SIGA Remuneracion") Or _
            Seguridad.TienePermiso("SIGA Administrador") Or _
            Seguridad.TienePermiso("PER-Tesoreria") Or _
            Seguridad.TienePermiso("PER-Licencias Medicas (Solo Lectura)") Or _
            Seguridad.TienePermiso("PER-Licencias Medicas (Acceso Total)") Then
            tieneAcceso = True
        End If
        Return tieneAcceso
    End Function

    Private Function obtieneVersionSIGA() As String
        Return version.recuperaVersion()
    End Function
End Module
