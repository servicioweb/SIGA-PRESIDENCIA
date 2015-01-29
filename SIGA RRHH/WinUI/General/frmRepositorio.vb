Imports cl.presidencia.Argo.Comun.SQL
Imports cl.presidencia.Argo.Comun

Public Class frmrepositorio
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
    Public WithEvents dvPaises As System.Data.DataView
    Friend WithEvents dvCiudades As System.Data.DataView
    Friend WithEvents dvComunas As System.Data.DataView
    Friend WithEvents dvRegiones As System.Data.DataView
    Public WithEvents dvEmpleados As System.Data.DataView
    Friend WithEvents dvCalidadJuridica As System.Data.DataView
    Friend WithEvents dvEstamento As System.Data.DataView
    Friend WithEvents dvGrado As System.Data.DataView
    Friend WithEvents dvEscalafon As System.Data.DataView
    Friend WithEvents dvMotivoRetiro As System.Data.DataView
    Public WithEvents DvTipoUnidad As System.Data.DataView
    Public WithEvents dvEstadoEmpleados As System.Data.DataView
    Friend WithEvents dvJefesDepto As System.Data.DataView
    Friend WithEvents dvUbicacionFisica As System.Data.DataView
    Friend WithEvents dvHorario As System.Data.DataView
    Friend WithEvents dvHistoricoAntecedentesLaborales As System.Data.DataView
    Friend WithEvents dvAfp As System.Data.DataView
    Friend WithEvents dvInstitucionesEdu As System.Data.DataView
    Friend WithEvents dvIsapre As System.Data.DataView
    Friend WithEvents dvApv As System.Data.DataView
    Friend WithEvents dvAsocGremial As System.Data.DataView
    Friend WithEvents dvTipoCuentaBanco As System.Data.DataView
    Friend WithEvents dvBanco As System.Data.DataView
    Friend WithEvents dvTramoCargaFam As System.Data.DataView
    Friend WithEvents dvEmpleadoVista As System.Data.DataView
    Friend WithEvents dvTipoLicencia As System.Data.DataView
    Friend WithEvents dvPeriodo As System.Data.DataView
    Friend WithEvents dvClasificacionEmpleado As System.Data.DataView
    Friend WithEvents dvRespuesta As System.Data.DataView
    Friend WithEvents dvNivelEstudio As System.Data.DataView
    Friend WithEvents dvTipoTrabPrevired As System.Data.DataView
    Friend WithEvents dvEmpleadosPlantaContrataActivos As System.Data.DataView
    Friend WithEvents dvEmpleadosPlantaContrataActivosInactivos As System.Data.DataView
    Friend WithEvents dvPeriodoAño As System.Data.DataView
    Friend WithEvents dvDireccion As System.Data.DataView
    Friend WithEvents dvItem As System.Data.DataView
    Friend WithEvents dvPeriodoBono As System.Data.DataView
    Friend WithEvents dvEmpleadosMasculinos As System.Data.DataView
    Friend WithEvents dvEmpleadosReliquidados As System.Data.DataView
    Friend WithEvents dvViaticoNumeroMemorandum As System.Data.DataView
    Friend WithEvents dvViaticoNumeroResolucion As System.Data.DataView
    Friend WithEvents dvDepartamentos As System.Data.DataView
    Friend WithEvents dvTipoBeneficiario As System.Data.DataView
    Friend WithEvents dvEstadoEmpleadoCambioSituacionLab As System.Data.DataView
    Friend WithEvents dvEmpleadosActivosPlantaContrataHonorario As System.Data.DataView
    Friend WithEvents dvOrganizacion As System.Data.DataView
    Friend WithEvents dvEvaluadorDesempeno As System.Data.DataView
    Friend WithEvents dvAutorizadorHorasExtras As System.Data.DataView
    Friend WithEvents dvEmisorCheques As System.Data.DataView
    Friend WithEvents dvProfesion As System.Data.DataView
    Friend WithEvents dvEmpleadosActivosInactivosSoloHonorario As System.Data.DataView
    Friend WithEvents dvSubDepto As System.Data.DataView
    Friend WithEvents dvCausaRechazoLicencia As System.Data.DataView
    Friend WithEvents dvEmpleadoFichaHistorica As System.Data.DataView
    Friend WithEvents dvPeriodoFichaHistorica As System.Data.DataView
    Friend WithEvents dvZonas As System.Data.DataView
    Friend WithEvents dvTipoItemEndeudamiento As System.Data.DataView

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dvPaises = New System.Data.DataView()
        Me.dvCiudades = New System.Data.DataView()
        Me.dvComunas = New System.Data.DataView()
        Me.dvRegiones = New System.Data.DataView()
        Me.dvEmpleados = New System.Data.DataView()
        Me.dvCalidadJuridica = New System.Data.DataView()
        Me.dvEstamento = New System.Data.DataView()
        Me.dvGrado = New System.Data.DataView()
        Me.dvEscalafon = New System.Data.DataView()
        Me.dvMotivoRetiro = New System.Data.DataView()
        Me.DvTipoUnidad = New System.Data.DataView()
        Me.dvEstadoEmpleados = New System.Data.DataView()
        Me.dvJefesDepto = New System.Data.DataView()
        Me.dvUbicacionFisica = New System.Data.DataView()
        Me.dvHorario = New System.Data.DataView()
        Me.dvHistoricoAntecedentesLaborales = New System.Data.DataView()
        Me.dvAfp = New System.Data.DataView()
        Me.dvInstitucionesEdu = New System.Data.DataView()
        Me.dvIsapre = New System.Data.DataView()
        Me.dvApv = New System.Data.DataView()
        Me.dvAsocGremial = New System.Data.DataView()
        Me.dvTipoCuentaBanco = New System.Data.DataView()
        Me.dvBanco = New System.Data.DataView()
        Me.dvTramoCargaFam = New System.Data.DataView()
        Me.dvEmpleadoVista = New System.Data.DataView()
        Me.dvTipoLicencia = New System.Data.DataView()
        Me.dvPeriodo = New System.Data.DataView()
        Me.dvClasificacionEmpleado = New System.Data.DataView()
        Me.dvRespuesta = New System.Data.DataView()
        Me.dvNivelEstudio = New System.Data.DataView()
        Me.dvTipoTrabPrevired = New System.Data.DataView()
        Me.dvEmpleadosPlantaContrataActivos = New System.Data.DataView()
        Me.dvEmpleadosPlantaContrataActivosInactivos = New System.Data.DataView()
        Me.dvPeriodoAño = New System.Data.DataView()
        Me.dvDireccion = New System.Data.DataView()
        Me.dvItem = New System.Data.DataView()
        Me.dvPeriodoBono = New System.Data.DataView()
        Me.dvEmpleadosMasculinos = New System.Data.DataView()
        Me.dvEmpleadosReliquidados = New System.Data.DataView()
        Me.dvViaticoNumeroMemorandum = New System.Data.DataView()
        Me.dvViaticoNumeroResolucion = New System.Data.DataView()
        Me.dvDepartamentos = New System.Data.DataView()
        Me.dvTipoBeneficiario = New System.Data.DataView()
        Me.dvEstadoEmpleadoCambioSituacionLab = New System.Data.DataView()
        Me.dvEmpleadosActivosPlantaContrataHonorario = New System.Data.DataView()
        Me.dvOrganizacion = New System.Data.DataView()
        Me.dvEvaluadorDesempeno = New System.Data.DataView()
        Me.dvAutorizadorHorasExtras = New System.Data.DataView()
        Me.dvEmisorCheques = New System.Data.DataView()
        Me.dvProfesion = New System.Data.DataView()
        Me.dvEmpleadosActivosInactivosSoloHonorario = New System.Data.DataView()
        Me.dvSubDepto = New System.Data.DataView()
        Me.dvCausaRechazoLicencia = New System.Data.DataView()
        Me.dvTipoItemEndeudamiento = New System.Data.DataView()
        Me.dvEmpleadoFichaHistorica = New System.Data.DataView()
        Me.dvPeriodoFichaHistorica = New System.Data.DataView()
        Me.dvZonas = New System.Data.DataView()
        CType(Me.dvPaises, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvCiudades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvComunas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvRegiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvCalidadJuridica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEstamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvGrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEscalafon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvMotivoRetiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvTipoUnidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEstadoEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvJefesDepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvUbicacionFisica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvHistoricoAntecedentesLaborales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvAfp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvInstitucionesEdu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvIsapre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvApv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvAsocGremial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvTipoCuentaBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvTramoCargaFam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEmpleadoVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvTipoLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvClasificacionEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvRespuesta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvNivelEstudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvTipoTrabPrevired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEmpleadosPlantaContrataActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEmpleadosPlantaContrataActivosInactivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPeriodoAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPeriodoBono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEmpleadosMasculinos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEmpleadosReliquidados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvViaticoNumeroMemorandum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvViaticoNumeroResolucion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvTipoBeneficiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEstadoEmpleadoCambioSituacionLab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEmpleadosActivosPlantaContrataHonorario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvOrganizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEvaluadorDesempeno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvAutorizadorHorasExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEmisorCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvProfesion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEmpleadosActivosInactivosSoloHonorario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvSubDepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvCausaRechazoLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvTipoItemEndeudamiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvEmpleadoFichaHistorica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvPeriodoFichaHistorica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frmrepositorio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(286, 37)
        Me.Name = "frmrepositorio"
        Me.Opacity = 0.0R
        Me.ShowInTaskbar = False
        Me.Text = "Repositorio"
        CType(Me.dvPaises, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvCiudades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvComunas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvRegiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvCalidadJuridica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEstamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvGrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEscalafon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvMotivoRetiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvTipoUnidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEstadoEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvJefesDepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvUbicacionFisica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvHorario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvHistoricoAntecedentesLaborales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvAfp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvInstitucionesEdu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvIsapre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvApv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvAsocGremial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvTipoCuentaBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvTramoCargaFam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEmpleadoVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvTipoLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvClasificacionEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvRespuesta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvNivelEstudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvTipoTrabPrevired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEmpleadosPlantaContrataActivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEmpleadosPlantaContrataActivosInactivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvPeriodoAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvPeriodoBono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEmpleadosMasculinos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEmpleadosReliquidados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvViaticoNumeroMemorandum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvViaticoNumeroResolucion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvTipoBeneficiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEstadoEmpleadoCambioSituacionLab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEmpleadosActivosPlantaContrataHonorario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvOrganizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEvaluadorDesempeno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvAutorizadorHorasExtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEmisorCheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvProfesion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEmpleadosActivosInactivosSoloHonorario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvSubDepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvCausaRechazoLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvTipoItemEndeudamiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvEmpleadoFichaHistorica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvPeriodoFichaHistorica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvZonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private da As SqlClient.SqlDataAdapter

    Private Shared Function GetDs() As DataSet
        Dim ds As New DataSet
        Return ds
    End Function

    Private Sub frmrepositorio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshDatos()
    End Sub

    Public Sub RefreshDatos()
        Try
            RefreshDatos("Pais")
            RefreshDatos("Localidad")
            RefreshDatos("Empleado")
            RefreshDatos("CalidadJuridica")
            RefreshDatos("Estamento")
            RefreshDatos("Grado")
            RefreshDatos("Escalafon")
            RefreshDatos("MotivoRetiro")
            RefreshDatos("TipoUnidad")
            RefreshDatos("EstadoEmpleado")
            RefreshDatos("JefeDepartamento")
            RefreshDatos("UbicacionFisica")
            RefreshDatos("HorarioTrabajo")
            RefreshDatos("AntecedenteLaboral")
            RefreshDatos("AFP")
            RefreshDatos("ISAPRE")
            RefreshDatos("APV")
            RefreshDatos("Banco")
            RefreshDatos("AsociacionGremial")
            RefreshDatos("TramoAsignacionFamiliar")
            RefreshDatos("TipoLicenciaMedica")
            RefreshDatos("CausaRechazoLicenciaMedica")
            RefreshDatos("Periodo")
            RefreshDatos("PeriodoAño")
            RefreshDatos("PeriodoBono")
            RefreshDatos("PeriodoFichaHistorica")
            RefreshDatos("ClasificacionEmpleado")
            RefreshDatos("Respuesta")
            RefreshDatos("NivelEstudio")
            RefreshDatos("TipoTrabajadorPrevired")
            RefreshDatos("Item")
            RefreshDatos("Viaticos")
            RefreshDatos("Departamentos")
            RefreshDatos("TipoBeneficiario")
            RefreshDatos("Organizacion")
            RefreshDatos("EmisorCheques")
            RefreshDatos("Profesion")
            'RefreshDatos("Zona")
        Catch exp As Exception
            Throw New Exception(exp.Message, exp)
        Finally

        End Try
    End Sub

    Public Sub RefreshDatos(ByVal conjuntoDeDatos As String)
        Dim conn As New SqlClient.SqlConnection

        Try
            conn.ConnectionString = ArgoConfiguracion.ConnectionString
            Dim ds As DataSet = GetDs()

            If conjuntoDeDatos = "Pais" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_PAISES, conn))
                da.Fill(ds, "GEN_PAIS")
                Dim dvmPaises As New DataViewManager(ds)
                dvPaises = dvmPaises.CreateDataView(ds.Tables("GEN_PAIS"))
            End If
            If conjuntoDeDatos = "Localidad" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_REGIONES, conn))
                da.Fill(ds, "GEN_REGION")
                Dim dvmRegiones As New DataViewManager(ds)
                dvRegiones = dvmRegiones.CreateDataView(ds.Tables("GEN_REGION"))
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_COMUNAS, conn))
                da.Fill(ds, "GEN_COMUNA")
                Dim dvmComunas As New DataViewManager(ds)
                dvComunas = dvmRegiones.CreateDataView(ds.Tables("GEN_COMUNA"))
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_CIUDADES, conn))
                da.Fill(ds, "GEN_CIUDAD")
                Dim dvmCiudades As New DataViewManager(ds)
                dvCiudades = dvmRegiones.CreateDataView(ds.Tables("GEN_CIUDAD"))
            End If
            If conjuntoDeDatos = "Empleado" Then
                da = New System.Data.SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_BUSCADOR_EMPLEADO, conn))
                'da.SelectCommand.CommandTimeout = 2000
                da.Fill(ds, Tablas.RH_PER_EMPLEADO)
                Dim dvmEmpleados As New DataViewManager(ds)
                dvEmpleados = dvmEmpleados.CreateDataView(ds.Tables(Tablas.RH_PER_EMPLEADO))
                'Vista de Empleados
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.VISTAS.SELECT_EMPLEADOS_VISTA, conn))
                da.SelectCommand.CommandTimeout = 200
                da.Fill(ds, "VW_MAESTRO_EMPLEADO")
                Dim dvmEmpleadosVista As New DataViewManager(ds)
                dvEmpleadoVista = dvmEmpleadosVista.CreateDataView(ds.Tables("VW_MAESTRO_EMPLEADO"))

                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.VISTAS.SELECT_FICHA_EMPLEADOS_VISTA, conn))
                da.SelectCommand.CommandTimeout = 200
                da.Fill(ds, "VW_MAESTRO_EMPLEADO_FICHA")
                Dim dvmFichaEmpleado As New DataViewManager(ds)
                dvEmpleadoFichaHistorica = dvmFichaEmpleado.CreateDataView(ds.Tables("VW_MAESTRO_EMPLEADO_FICHA"))

                'Vista Empleados Activos Planta y Contrata
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.VISTAS.SELECT_EMPLEADOS_VISTA_ACTIVOS, conn))
                'da.SelectCommand.CommandTimeout = 2000
                da.Fill(ds, SQL.VISTAS.SELECT_EMPLEADOS_VISTA_ACTIVOS)
                Dim dvmEmpleadosPlantaContrataActivos As New DataViewManager(ds)
                dvEmpleadosPlantaContrataActivos = dvmEmpleadosPlantaContrataActivos.CreateDataView(ds.Tables(SQL.VISTAS.SELECT_EMPLEADOS_VISTA_ACTIVOS))
                'Vista Empleados Inactivos
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.VISTAS.SELECT_EMPLEADOS_VISTA_ACTIVOS_INACTIVOS, conn))
                'da.SelectCommand.CommandTimeout = 2000
                da.Fill(ds, SQL.VISTAS.SELECT_EMPLEADOS_VISTA_ACTIVOS_INACTIVOS)
                Dim dvmEmpleadosPlantaContrataActivosInactivos As New DataViewManager(ds)
                dvEmpleadosPlantaContrataActivosInactivos = dvmEmpleadosPlantaContrataActivosInactivos.CreateDataView(ds.Tables(SQL.VISTAS.SELECT_EMPLEADOS_VISTA_ACTIVOS_INACTIVOS))
                'Vista Empleados Activos e Inactivos solo honorarios
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.VISTAS.SELECT_EMPLEADOS_VISTA_ACTIVOS_INACTIVOS_HONORARIOS, conn))
                'da.SelectCommand.CommandTimeout = 2000
                da.Fill(ds, SQL.VISTAS.SELECT_EMPLEADOS_VISTA_ACTIVOS_INACTIVOS_HONORARIOS)
                Dim dvmEmpleadosActivosInactivosSoloHonorario As New DataViewManager(ds)
                dvEmpleadosActivosInactivosSoloHonorario = dvmEmpleadosActivosInactivosSoloHonorario.CreateDataView(ds.Tables(SQL.VISTAS.SELECT_EMPLEADOS_VISTA_ACTIVOS_INACTIVOS_HONORARIOS))
                'Vista Empleados Masculinos
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.VISTAS.SELECT_EMPLEADOS_MASCULINOS, conn))
                'da.SelectCommand.CommandTimeout = 2000
                da.Fill(ds, SQL.VISTAS.SELECT_EMPLEADOS_MASCULINOS)
                Dim dvmEmpleadosMasculinos As New DataViewManager(ds)
                dvEmpleadosMasculinos = dvmEmpleadosMasculinos.CreateDataView(ds.Tables(SQL.VISTAS.SELECT_EMPLEADOS_MASCULINOS))
                'Vista Empleados Reliquidados
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.VISTAS.SELECT_MAESTRO_EMPLEADO_RELIQUIDADO, conn))
                'da.SelectCommand.CommandTimeout = 2000
                da.Fill(ds, SQL.VISTAS.SELECT_MAESTRO_EMPLEADO_RELIQUIDADO)
                Dim dvmEmpleadosReliquidados As New DataViewManager(ds)
                dvEmpleadosReliquidados = dvmEmpleadosReliquidados.CreateDataView(ds.Tables(SQL.VISTAS.SELECT_MAESTRO_EMPLEADO_RELIQUIDADO))
                'Vista Empleados Activos Planta, Contrata y Honorario
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.VISTAS.SELECT_EMPLEADOS_ACTIVOS_PLANTA_CONTRATA_HONORARIOS, conn))
                ' da.SelectCommand.CommandTimeout = 2000
                da.Fill(ds, SQL.VISTAS.SELECT_EMPLEADOS_ACTIVOS_PLANTA_CONTRATA_HONORARIOS)
                Dim dvmEmpleadosActivosPlantaContrataHonorario As New DataViewManager(ds)
                dvEmpleadosActivosPlantaContrataHonorario = dvmEmpleadosActivosPlantaContrataHonorario.CreateDataView(ds.Tables(SQL.VISTAS.SELECT_EMPLEADOS_ACTIVOS_PLANTA_CONTRATA_HONORARIOS))
            End If
            If conjuntoDeDatos = "CalidadJuridica" Then
                da = New System.Data.SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_CALIDAD_JURIDICA, conn))
                da.Fill(ds, "RH_REM_CALIDAD_JURIDICA")
                Dim dvmCalidadJuridica As New DataViewManager(ds)
                dvCalidadJuridica = dvmCalidadJuridica.CreateDataView(ds.Tables("RH_REM_CALIDAD_JURIDICA"))
            End If
            If conjuntoDeDatos = "Estamento" Then
                da = New System.Data.SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_ESTAMENTO, conn))
                da.Fill(ds, "RH_PER_ESTAMENTO")
                Dim dvmEstamento As New DataViewManager(ds)
                dvEstamento = dvmEstamento.CreateDataView(ds.Tables("RH_PER_ESTAMENTO"))
            End If
            If conjuntoDeDatos = "Grado" Then
                da = New System.Data.SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_GRADO, conn))
                da.Fill(ds, "RH_REM_GRADO")
                Dim dvmGrado As New DataViewManager(ds)
                dvGrado = dvmGrado.CreateDataView(ds.Tables("RH_REM_GRADO"))
            End If
            If conjuntoDeDatos = "Escalafon" Then
                da = New System.Data.SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_ESCALAFON, conn))
                da.Fill(ds, "RH_PER_ESCALAFON")
                Dim dvmEscalafon As New DataViewManager(ds)
                dvEscalafon = dvmEscalafon.CreateDataView(ds.Tables("RH_PER_ESCALAFON"))
            End If
            If conjuntoDeDatos = "MotivoRetiro" Then
                da = New System.Data.SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_MOTIVO_RETIRO, conn))
                da.Fill(ds, "RH_PER_MOTIVO_RETIRO")
                Dim dvmMotivoRetiro As New DataViewManager(ds)
                dvMotivoRetiro = dvmMotivoRetiro.CreateDataView(ds.Tables("RH_PER_MOTIVO_RETIRO"))
            End If
            If conjuntoDeDatos = "TipoUnidad" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_TIPO_UNIDAD, conn))
                da.Fill(ds, "RH_PER_TIPO_UNIDAD")
                Dim dvmTipoUnidad As New DataViewManager(ds)
                DvTipoUnidad = dvmTipoUnidad.CreateDataView(ds.Tables("RH_PER_TIPO_UNIDAD"))
            End If
            If conjuntoDeDatos = "EstadoEmpleado" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_ESTADO_EMPLEADO, conn))
                da.Fill(ds, "RH_PER_ESTADO_EMPLEADO")
                Dim dvmEstadoEmpleado As New DataViewManager(ds)
                dvEstadoEmpleados = dvmEstadoEmpleado.CreateDataView(ds.Tables("RH_PER_ESTADO_EMPLEADO"))

                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_ESTADO_EMPLEADO_CAMBIO_SITUACION_LAB, conn))
                da.Fill(ds, SQL.INSTRUCCIONES_SQL.SELECT_ESTADO_EMPLEADO_CAMBIO_SITUACION_LAB)
                Dim dvmEstadoEmpleadoCambioSituacionLab As New DataViewManager(ds)
                dvEstadoEmpleadoCambioSituacionLab = dvmEstadoEmpleadoCambioSituacionLab.CreateDataView(ds.Tables(SQL.INSTRUCCIONES_SQL.SELECT_ESTADO_EMPLEADO_CAMBIO_SITUACION_LAB))
            End If
            If conjuntoDeDatos = "JefeDepartamento" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_JEFE_DIRECTO, conn))
                da.Fill(ds, "VW_JEFES_DPTO")
                Dim dvmJefeDirecto As New DataViewManager(ds)
                dvJefesDepto = dvmJefeDirecto.CreateDataView(ds.Tables("VW_JEFES_DPTO"))
            End If
            If conjuntoDeDatos = "UbicacionFisica" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_UBICACION_FISICA, conn))
                da.Fill(ds, "RH_PER_UBICACION_FISICA")
                Dim dvmUbicacionFisica As New DataViewManager(ds)
                dvUbicacionFisica = dvmUbicacionFisica.CreateDataView(ds.Tables("RH_PER_UBICACION_FISICA"))
            End If
            If conjuntoDeDatos = "HorarioTrabajo" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_HORARIO_TRABAJO, conn))
                da.Fill(ds, "RH_PER_HORARIO")
                Dim dvmHorario As New DataViewManager(ds)
                dvHorario = dvmHorario.CreateDataView(ds.Tables("RH_PER_HORARIO"))
            End If
            If conjuntoDeDatos = "AntecedenteLaboral" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_HISTORICO_ANTECEDENTES_LABORALES(), conn))
                da.Fill(ds, "RH_PER_ANTECEDENTE_LABORAL")
                Dim dvmHistoricoAntecedenteLaboral As New DataViewManager(ds)
                dvHistoricoAntecedentesLaborales = dvmHistoricoAntecedenteLaboral.CreateDataView(ds.Tables("RH_PER_ANTECEDENTE_LABORAL"))
            End If
            If conjuntoDeDatos = "AFP" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.VISTAS.SELECT_AFP(), conn))
                da.Fill(ds, "VW_TABLA_AFP")
                Dim dvmAfp As New DataViewManager(ds)
                dvAfp = dvmAfp.CreateDataView(ds.Tables("VW_TABLA_AFP"))
            End If
            If conjuntoDeDatos = "ISAPRE" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.VISTAS.SELECT_ISAPRE, conn))
                da.Fill(ds, "VW_TABLA_ISAPRE")
                Dim dvmIsapre As New DataViewManager(ds)
                dvIsapre = dvmIsapre.CreateDataView(ds.Tables("VW_TABLA_ISAPRE"))
            End If
            If conjuntoDeDatos = "APV" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.INSTRUCCIONES_SQL.SELECT_APV, conn))
                da.Fill(ds, SQL.INSTRUCCIONES_SQL.SELECT_APV)
                Dim dvmApv As New DataViewManager(ds)
                dvApv = dvmApv.CreateDataView(ds.Tables(SQL.INSTRUCCIONES_SQL.SELECT_APV))
            End If
            If conjuntoDeDatos = "InstitucionEducacional" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.VISTAS.SELECT_INSTITUCIONESEDU, conn))
                da.Fill(ds, SQL.VISTAS.SELECT_INSTITUCIONESEDU)
                Dim dvmInstitucionesEdu As New DataViewManager(ds)
                dvInstitucionesEdu = dvmInstitucionesEdu.CreateDataView(ds.Tables(SQL.VISTAS.SELECT_INSTITUCIONESEDU))
            End If
            If conjuntoDeDatos = "Banco" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_BANCO, conn))
                da.Fill(ds, "RH_PER_BANCO")
                Dim dvmBanco As New DataViewManager(ds)
                dvBanco = dvmBanco.CreateDataView(ds.Tables("RH_PER_BANCO"))
                'Tipo Cuenta Bancaria
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_TIPO_CUENTA_BANCO, conn))
                da.Fill(ds, "RH_PER_TIPO_CUENTA_BANCO")
                Dim dvmTipoCuentaBanco As New DataViewManager(ds)
                dvTipoCuentaBanco = dvmTipoCuentaBanco.CreateDataView(ds.Tables("RH_PER_TIPO_CUENTA_BANCO"))
            End If
            If conjuntoDeDatos = "AsociacionGremial" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_ASOCIACION_GREMIAL, conn))
                da.Fill(ds, "RH_PER_ASOCIACION_GREMIAL")
                Dim dvmAsocGremial As New DataViewManager(ds)
                dvAsocGremial = dvmAsocGremial.CreateDataView(ds.Tables("RH_PER_ASOCIACION_GREMIAL"))
            End If
            If conjuntoDeDatos = "TramoAsignacionFamiliar" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_TRAMO_ASIG_FAMILIAR, conn))
                da.Fill(ds, "RH_REM_TRAMO_ASIGNACION_FAMILIAR")
                Dim dvmTramoCargaFam As New DataViewManager(ds)
                dvTramoCargaFam = dvmTramoCargaFam.CreateDataView(ds.Tables("RH_REM_TRAMO_ASIGNACION_FAMILIAR"))
            End If
            If conjuntoDeDatos = "TipoLicenciaMedica" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.INSTRUCCIONES_SQL.SELECT_TIPO_LICENCIA_MEDICA, conn))
                da.Fill(ds, Tablas.RH_PER_TIPO_LICENCIA_MEDICA)
                Dim dvmTipoLicencia As New DataViewManager(ds)
                dvTipoLicencia = dvmTipoLicencia.CreateDataView(ds.Tables(Tablas.RH_PER_TIPO_LICENCIA_MEDICA))
            End If
            If conjuntoDeDatos = "CausaRechazoLicenciaMedica" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.INSTRUCCIONES_SQL.SELECT_CAUSA_RECHAZO_LICENCIA_MEDICA, conn))
                da.Fill(ds, Tablas.RH_PER_CAUSA_RECHAZO_LICENCIA_MEDICA)
                Dim dvmCausaRechazoLicencia As New DataViewManager(ds)
                dvCausaRechazoLicencia = dvmCausaRechazoLicencia.CreateDataView(ds.Tables(Tablas.RH_PER_CAUSA_RECHAZO_LICENCIA_MEDICA))
            End If
            If conjuntoDeDatos = "Periodo" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.INSTRUCCIONES_SQL.SELECT_PERIODO_GENERAL, conn))
                da.Fill(ds, Tablas.RH_REM_PERIODO)
                Dim dvmPeriodo As New DataViewManager(ds)
                dvPeriodo = dvmPeriodo.CreateDataView(ds.Tables(Tablas.RH_REM_PERIODO))
            End If
            If conjuntoDeDatos = "PeriodoAño" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.INSTRUCCIONES_SQL.SELECT_PERIODO_AÑO, conn))
                da.Fill(ds, Tablas.RH_REM_PERIODO)
                Dim dvmPeriodoAño As New DataViewManager(ds)
                dvPeriodoAño = dvmPeriodoAño.CreateDataView(ds.Tables(Tablas.RH_REM_PERIODO))
            End If
            If conjuntoDeDatos = "PeriodoFichaHistorica" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.INSTRUCCIONES_SQL.SELECT_PERIODO_FICHA_HISTORICA, conn))
                da.Fill(ds, Tablas.RH_REM_PERIODO)
                Dim dvmPeriodoFichaHistorica As New DataViewManager(ds)
                dvPeriodoFichaHistorica = dvmPeriodoFichaHistorica.CreateDataView(ds.Tables(Tablas.RH_REM_PERIODO))
            End If
            If conjuntoDeDatos = "PeriodoBono" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.INSTRUCCIONES_SQL.SELECT_PERIODO_BONO, conn))
                da.Fill(ds, Tablas.RH_REM_PERIODO)
                Dim dvmPeriodoBono As New DataViewManager(ds)
                dvPeriodoBono = dvmPeriodoBono.CreateDataView(ds.Tables(Tablas.RH_REM_PERIODO))
            End If
            If conjuntoDeDatos = "ClasificacionEmpleado" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.INSTRUCCIONES_SQL.SELECT_CLASIFICACION_EMPLEADO, conn))
                da.Fill(ds, Tablas.RH_REM_CLASIFICACION_EMPLEADO)
                Dim dvmClasificacionEmpleado As New DataViewManager(ds)
                dvClasificacionEmpleado = dvmClasificacionEmpleado.CreateDataView(ds.Tables(Tablas.RH_REM_CLASIFICACION_EMPLEADO))
            End If
            If conjuntoDeDatos = "Respuesta" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.INSTRUCCIONES_SQL.SELECT_RESPUESTA, conn))
                da.Fill(ds, Tablas.GEN_RESPUESTA)
                Dim dvmRespuesta As New DataViewManager(ds)
                dvRespuesta = dvmRespuesta.CreateDataView(ds.Tables(Tablas.GEN_RESPUESTA))
            End If
            If conjuntoDeDatos = "NivelEstudio" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.INSTRUCCIONES_SQL.SELECT_NIVEL_ESTUDIO, conn))
                da.Fill(ds, Tablas.RH_PER_NIVEL_ESTUDIO)
                Dim dvmNivelEstudio As New DataViewManager(ds)
                dvNivelEstudio = dvmNivelEstudio.CreateDataView(ds.Tables(Tablas.RH_PER_NIVEL_ESTUDIO))
            End If
            If conjuntoDeDatos = "TipoTrabajadorPrevired" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.INSTRUCCIONES_SQL.SELECT_TIPO_TRABAJADOR_PREVIRED, conn))
                da.Fill(ds, Tablas.RH_REM_TIPO_TRABAJADOR_PREVIRED)
                Dim dvmTipoTrabPrevired As New DataViewManager(ds)
                dvTipoTrabPrevired = dvmTipoTrabPrevired.CreateDataView(ds.Tables(Tablas.RH_REM_TIPO_TRABAJADOR_PREVIRED))
            End If
            If conjuntoDeDatos = "Item" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.INSTRUCCIONES_SQL.SELECT_ITEM, conn))
                da.Fill(ds, Tablas.RH_REM_ITEM)
                Dim dvmItem As New DataViewManager(ds)
                dvItem = dvmItem.CreateDataView(ds.Tables(Tablas.RH_REM_ITEM))

                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.INSTRUCCIONES_SQL.SELECT_ITEM_ENDEUDAMIENTO, conn))
                da.Fill(ds, Tablas.RH_REM_TIPO_ITEM_ENDEUDAMIENTO)
                Dim dvmTipoItemEndeudamiento As New DataViewManager(ds)
                dvTipoItemEndeudamiento = dvmTipoItemEndeudamiento.CreateDataView(ds.Tables(Tablas.RH_REM_TIPO_ITEM_ENDEUDAMIENTO))
            End If
            If conjuntoDeDatos = "Direccion" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_DIRECCION, conn))
                da.Fill(ds, Tablas.RH_PER_DIRECCION)
                Dim dvmDireccion As New DataViewManager(ds)
                dvDireccion = dvmDireccion.CreateDataView(ds.Tables(Tablas.RH_PER_DIRECCION))
            End If
            If conjuntoDeDatos = "Viaticos" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.VISTAS.SELECT_VIATICO_NUMERO_MEMORANDUM, conn))
                da.Fill(ds, "VW_VIATICO_NUMERO_MEMORANDUM")
                Dim dvmViaticoNumeroMemorandum As New DataViewManager(ds)
                dvViaticoNumeroMemorandum = dvmViaticoNumeroMemorandum.CreateDataView(ds.Tables("VW_VIATICO_NUMERO_MEMORANDUM"))

                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.VISTAS.SELECT_VIATICO_NUMERO_RESOLUCION, conn))
                da.Fill(ds, "VW_VIATICO_NUMERO_RESOLUCION")
                Dim dvmViaticoNumeroResolucion As New DataViewManager(ds)
                dvViaticoNumeroResolucion = dvmViaticoNumeroResolucion.CreateDataView(ds.Tables("VW_VIATICO_NUMERO_RESOLUCION"))
            End If
            If conjuntoDeDatos = "EmisorCheques" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_EMISOR_CHEQUE_ENCABEZADO, conn))
                da.Fill(ds, Tablas.RH_PER_EMISOR_CHEQUE)
                Dim dvmEmisorCheques As New DataViewManager(ds)
                dvEmisorCheques = dvmEmisorCheques.CreateDataView(ds.Tables(Tablas.RH_PER_EMISOR_CHEQUE))
            End If
            If conjuntoDeDatos = "Departamentos" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.VISTAS.SELECT_DEPARTAMENTOS, conn))
                da.Fill(ds, "DEPARTAMENTOS")
                Dim dvmDepartamentos As New DataViewManager(ds)
                dvDepartamentos = dvmDepartamentos.CreateDataView(ds.Tables("DEPARTAMENTOS"))

                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_SUB_DEPTO, conn))
                da.Fill(ds, "RH_PER_SUB_DEPARTAMENTO")
                Dim dvmSubDepartamentos As New DataViewManager(ds)
                dvSubDepto = dvmSubDepartamentos.CreateDataView(ds.Tables("RH_PER_SUB_DEPARTAMENTO"))

                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.VISTAS.SELECT_AUTORIZADOR_HORAS_EXTRAS, conn))
                da.Fill(ds, Comun.Vistas.VW_AUTORIZADOR_HORAS_EXTRAS)
                Dim dvmAutorizadorHrsExtras As New DataViewManager(ds)
                dvAutorizadorHorasExtras = dvmAutorizadorHrsExtras.CreateDataView(ds.Tables(Comun.Vistas.VW_AUTORIZADOR_HORAS_EXTRAS))

                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(SQL.VISTAS.SELECT_EVALUADOR_DESEMPENO, conn))
                da.Fill(ds, Comun.Vistas.VW_EVALUADOR_DESEMPENO)
                Dim dvmEvaluadorDesempeno As New DataViewManager(ds)
                dvEvaluadorDesempeno = dvmEvaluadorDesempeno.CreateDataView(ds.Tables(Comun.Vistas.VW_EVALUADOR_DESEMPENO))


            End If
            If conjuntoDeDatos = "TipoBeneficiario" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_TIPO_BENEFICIARIO, conn))
                da.Fill(ds, Tablas.RH_PER_TIPO_BENEFICIARIO)
                Dim dvmTipoBeneficiario As New DataViewManager(ds)
                dvTipoBeneficiario = dvmTipoBeneficiario.CreateDataView(ds.Tables(Tablas.RH_PER_TIPO_BENEFICIARIO))
            End If
            If conjuntoDeDatos = "Organizacion" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_ORGANIZACION, conn))
                da.Fill(ds, "GEN_ORGANIZACION")
                Dim dvmOrganizacion As New DataViewManager(ds)
                dvOrganizacion = dvmOrganizacion.CreateDataView(ds.Tables("GEN_ORGANIZACION"))
            End If
            If conjuntoDeDatos = "Profesion" Then
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(INSTRUCCIONES_SQL.SELECT_PROFESION, conn))
                da.Fill(ds, "RH_PER_PROFESION_OFICIO")
                Dim dvmProfesion As New DataViewManager(ds)
                dvProfesion = dvmProfesion.CreateDataView(ds.Tables("RH_PER_PROFESION_OFICIO"))
            End If

        Catch ex As Exception
            Throw New Exception("", ex)
        Finally
            conn.Close()
            conn = Nothing
        End Try
    End Sub

End Class
