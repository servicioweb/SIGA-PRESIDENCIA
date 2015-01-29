Option Strict On
Imports System.ComponentModel
Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.Comun.TiposDeDatos


Public Structure EEncabezadoAFP
    Dim afp_id As Integer
    Dim descripcion As String
    Dim afp_rut As Integer
    Dim afp_dv As String
    Dim SISTEMA_PREV_ID As Byte
    Dim direccion As String
    Dim comuna As Integer
    Dim caja As String
    Dim previred As String

End Structure
Public Class Mantenedor
    Dim dsMantenedor As New DataAccess.Mantenedores
    Public datosOrganizacion As EOrganizacion
    Public datosOrganizacionafp As EEncabezadoAFP


    Public Sub New()
        MyBase.new()
    End Sub
    Public Sub New(ByVal organizacionID As Integer, ByVal datarow As DataAccess.DSMantenedores.GEN_ORGANIZACIONRow)
        asignacionCamposOrganizacion(CType(recuperarOrganizacion(organizacionID), DataAccess.DSMantenedores.GEN_ORGANIZACIONRow))

    End Sub
    Private Sub asignacionCamposOrganizacion(ByVal dr As DataAccess.DSMantenedores.GEN_ORGANIZACIONRow)
        Me.datosOrganizacion.organizacionID = CType(dr("ORGANIZACION_ID"), Integer)
        Me.datosOrganizacion.organizacionAlias = CType(dr("ORGANIZACION_ALIAS"), String)
        Me.datosOrganizacion.nombreFantasia = CType(dr("DESCRIPCION"), String)
        Me.datosOrganizacion.rutEmpresa = CType(dr("RUT_ORG"), Integer)
        Me.datosOrganizacion.dvEmpresa = CType(dr("DV_ORG"), String)
        Me.datosOrganizacion.razonSocial = CType(dr("RAZON_SOCIAL"), String)
        Me.datosOrganizacion.direccion = CType(dr("DIRECCION"), String)
        Me.datosOrganizacion.paisID = CType(dr("PAIS_ID"), Integer)
        Me.datosOrganizacion.regionID = CType(dr("REGION_ID"), Integer)
        Me.datosOrganizacion.comunaID = CType(dr("COMUNA_ID"), Integer)
        Me.datosOrganizacion.apellidoPaternoRepLegal = CType(dr("APE_PAT_REP_LEGAL"), String)
        Me.datosOrganizacion.apellidoMaternoRepLegal = CType(dr("APE_MAT_LEGAL"), String)
        Me.datosOrganizacion.nombresRepLegal = CType(dr("NOMBRES_REP_LEGAL"), String)
        Me.datosOrganizacion.rutRepLegal = CType(dr("RUT_REP_LEGAL"), Integer)
        Me.datosOrganizacion.dvRepLegal = CType(dr("DV_REP_LEGAL"), String)
        Me.datosOrganizacion.cargoRepLegal = CType(dr("CARGO_REP_LEGAL"), String)
        Me.datosOrganizacion.telefono = CType(dr("TELEFONO"), String)
        Me.datosOrganizacion.codigoActividadEconomica = CType(dr("CODIGO_ACTIVIDAD_ECONOMICA"), String)
        Me.datosOrganizacion.apellidoPaternoJefeSubrogante = CType(dr("APE_PAT_REP_LEGAL_SUBROGANTE"), String)
        Me.datosOrganizacion.apellidoMaternoJefeSubrogante = CType(dr("APE_MAT_LEGAL_SUBROGANTE"), String)
        Me.datosOrganizacion.nombresJefeSubrogante = CType(dr("NOMBRES_REP_LEGAL_SUBROGANTE"), String)
        Me.datosOrganizacion.rutRepJefeSubrogante = CType(dr("RUT_REP_LEGAL_SUBROGANTE"), Integer)
        Me.datosOrganizacion.dvRepJefeSubrogante = CType(dr("DV_REP_LEGAL_SUBROGANTE"), String)
        Me.datosOrganizacion.cargoJefeSubrogante = CType(dr("CARGO_REP_LEGAL_SUBROGANTE"), String)
    End Sub



    Public Function recuperarDepartamentos() As DataView
        'Se rescatan los items asociados al periodoo
        Return (dsMantenedor.recuperaDepto)
    End Function

    Public Function recuperarIsapres() As DataView
        'Se rescatan los items asociados al periodoo
        Return (dsMantenedor.recuperaIsapres)
    End Function

    Public Function recuperarBancos() As DataView
        'Se rescatan los items asociados al periodoo
        Return (dsMantenedor.recuperaBancos)
    End Function

    Public Function recuperarUbicacion() As DataView
        'Se rescatan los items asociados al periodoo
        Return (dsMantenedor.recuperaUbicacion)
    End Function

    Public Function recuperarCostoContable(ByVal Ano As Integer) As DataView
        'Se rescatan los items asociados al periodoo
        Return (dsMantenedor.recuperaCostoContable(Ano))
    End Function

    Public Function recuperarCostoPresupuesto(ByVal Ano As Integer) As DataView
        'Se rescatan los items asociados al periodoo
        Return (dsMantenedor.recuperaCostoPresupuesto(Ano))
    End Function

    Public Function recuperarRetiro() As DataView
        'Se rescatan los items asociados al periodoo
        Return (dsMantenedor.recuperaRetiro)
    End Function

    Public Function recuperarEstudios() As DataView
        'Se rescatan los items asociados al periodoo
        Return (dsMantenedor.recuperaEstudios)
    End Function

    Public Function recuperarNivelEstudiosCurricular() As DataView
        Return (dsMantenedor.recuperaNivelEstudiosCurricular)
    End Function

    Public Function recuperarProfesionOficio() As DataView
        Return dsMantenedor.recuperaProfesionOficio
    End Function

    Public Function recuperarProfesionOficio(ByVal nivelEstudioId As Integer) As DataView
        Return dsMantenedor.recuperaProfesionOficio(nivelEstudioId)
    End Function

    Public Function recuperarCarga() As DataView
        'Se rescatan los items asociados al periodoo
        Return (dsMantenedor.recuperaCarga)
    End Function

    Public Function recuperarAPV() As DataView
        'Se rescatan los items asociados al periodoo
        Return (dsMantenedor.recuperaAPV)
    End Function

    Public Function recuperarGrado(ByVal Ano As Integer) As DataView
        'Se rescatan los items asociados al periodoo
        Return (dsMantenedor.recuperaGrado(Ano))
    End Function

    Public Function recuperarIpcAcumulado() As DataView
        'Se rescatan los items asociados al periodoo
        Return (dsMantenedor.recuperaIpcAumulado)
    End Function

    Public Function recuperarCalidad() As DataView
        'Se rescatan los items asociados al periodoo
        Return (dsMantenedor.recuperaCalidad)
    End Function

    Public Function recuperarClasificacion() As DataView
        'Se rescatan los items asociados al periodoo
        Return (dsMantenedor.recuperaClasificacion)
    End Function

    Public Function recuperarDetalleAFP(ByVal idAfp As Integer) As DataView
        'Se rescatan los items asociados al periodoo
        Return (dsMantenedor.recuperaDetalleAFP(idAfp))
    End Function
    Public ReadOnly Property recuperarEncabezadoAFP(ByVal idAfp As Integer) As DataRow
        Get
            'Obtiene los datos del encabezado MEMO.
            Return recuperaEncabezadoAFP(idAfp)
        End Get
    End Property

    Private Function recuperaEncabezadoAFP(ByVal idAfp As Integer) As DataRow
        'Se rescatan los datos del encabezado 
        Return (dsMantenedor.recuperarEncabezado(idAfp))
    End Function

    Public Function actualizarDatosDeptos() As Boolean
        Return (dsMantenedor.actualizarDatosDepto)
    End Function


    Public Function actualizarIsapres() As Boolean
        Return (dsMantenedor.actualizarDatosIsapres)
    End Function

    Public Function actualizarBancos() As Boolean
        Return (dsMantenedor.actualizarDatosBancos)
    End Function

    Public Function actualizarUbicacion() As Boolean
        Return (dsMantenedor.actualizarDatosUbicacion)
    End Function

    Public Function actualizarCostoContable() As Boolean
        Return (dsMantenedor.actualizarDatosCostoContable)
    End Function

    Public Function ActualizarIpcAcumulado(ByVal IpcId As Integer, ByVal Año As Integer, ByVal Mes As Integer, Valor As Decimal) As Integer
        Return dsMantenedor.ActualizarIpcAcumulado(IpcId, Año, Mes, Valor)
    End Function

    Public Function actualizarCostoPresupuesto() As Boolean
        Return (dsMantenedor.actualizarDatosCostoPresupuesto)
    End Function

    Public Function actualizarRetiros() As Boolean
        Return (dsMantenedor.actualizarDatosRetiros)
    End Function

    Public Function actualizarEstudios() As Boolean
        Return (dsMantenedor.actualizarDatosEstudios)
    End Function

    Public Function actualizarProfesionOficio(ByVal organizacionId As Integer, ByVal profesionOficioId As Integer, ByVal profesionAlias As Integer, ByVal nivelEstudioId As Integer, ByVal descripcion As String) As Boolean
        Return dsMantenedor.actualizarDatosProfesionOficio(organizacionId, profesionOficioId, profesionAlias, nivelEstudioId, descripcion)
    End Function

    Public Function insertarProfesionOficio(ByVal organizacionId As Integer, ByVal profesionAlias As Integer, ByVal nivelEstudioId As Integer, ByVal descripcion As String) As Boolean
        Return dsMantenedor.insertarDatosProfesionOficio(organizacionId, profesionAlias, nivelEstudioId, descripcion)
    End Function

    Public Function eliminarProfesionOficio(ByVal profesionOficioId As Integer) As Boolean

    End Function

    Public Function eliminarIpcAcumulado(IpcId As Integer) As Boolean
        Return dsMantenedor.eliminarIpcAcumulado(IpcId)
    End Function

    Public Function actualizarCarga() As Boolean
        Return (dsMantenedor.actualizarDatosCarga)
    End Function

    Public Function actualizarAPV() As Boolean
        Return (dsMantenedor.actualizarDatosAPV)
    End Function


    Public Function actualizarGrado() As Boolean
        Return (dsMantenedor.actualizarDatosGrado)
    End Function


    Public Function actualizarCalidad() As Boolean
        Return (dsMantenedor.actualizarDatosCalidad)
    End Function

    Public Function actualizarClasificacion() As Boolean
        Return (dsMantenedor.actualizarDatosClasificacion)
    End Function


    Public Function actualizarDetalleAFP() As Boolean
        Return (dsMantenedor.actualizarDatosDetalleAFP)
    End Function
    Private Function recuperarOrganizacion(ByVal organizacionID As Integer) As DataRow
        'Se rescatan los datos curriculares para el empleado
        Return (dsMantenedor.recuperaDatosOrganizacion(organizacionID))
    End Function
    Public Function ActualizarOrganizacion() As Boolean
        Dim dr As DataAccess.DSMantenedores.GEN_ORGANIZACIONRow
        Try
            dr = CType(dsMantenedor.Busca(Me.datosOrganizacion.organizacionID, Tablas.GEN_ORGANIZACION, "SELECT * FROM " & Tablas.GEN_ORGANIZACION), DataAccess.DSMantenedores.GEN_ORGANIZACIONRow)
            asignacionCampos(Me, dr)
            'dr = CType(dsViatico.ActualizarEncabezado(ViaticoDR), DataAccess.Viaticos.RH_PER_VIATICORow)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return (False)
        End Try
    End Function
    Private Sub asignacionCampos(ByVal organizacion As BusinessRules.Mantenedor, ByRef dr As DataAccess.DSMantenedores.GEN_ORGANIZACIONRow)
        With dr
            '.TIPO_RESOLUCION = CType(Viatico.datosEncabezado.tipoResolucion, Byte)
        End With
    End Sub

    Public Function CrearEncabezadoAFP() As Long
        Dim afpDR As DataAccess.Mantenedores.RH_REM_AFPRow
        Try
            afpDR = CType(dsMantenedor.Tables(Tablas.RH_REM_AFP).NewRow, DataAccess.DSMantenedores.RH_REM_AFPRow)
            asignacionCampos(Me, afpDR)
            afpDR = CType(dsMantenedor.InsertarEncabezadoAFP(afpDR), DataAccess.Mantenedores.RH_REM_AFPRow)
            Return (afpDR.AFP_ID)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
    Public Function ActualizarEncabezadoAFP() As Boolean
        Dim afpDR As DataAccess.Mantenedores.RH_REM_AFPRow
        Try
            afpDR = CType(dsMantenedor.Busca(Me.datosOrganizacionafp.afp_id, Tablas.RH_REM_AFP, "SELECT * FROM " & Tablas.RH_REM_AFP), DataAccess.Mantenedores.RH_REM_AFPRow)
            asignacionCampos(Me, afpDR)
            afpDR = CType(dsMantenedor.ActualizarEncabezadoAFP(afpDR), DataAccess.Mantenedores.RH_REM_AFPRow)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return (False)
        End Try
    End Function

    Private Sub asignacionCampos(ByVal afpEncabezado As BusinessRules.Mantenedor, ByRef afpDR As DataAccess.Mantenedores.RH_REM_AFPRow)
        With afpDR
            .ORGANIZACION_ID = CType(Comun.ArgoConfiguracion.OrganizacionID, Byte)
            .DESCRIPCION = afpEncabezado.datosOrganizacionafp.descripcion
            .AFP_RUT = afpEncabezado.datosOrganizacionafp.afp_rut
            .AFP_DV = afpEncabezado.datosOrganizacionafp.afp_dv
            .SISTEMA_PREV_ID = afpEncabezado.datosOrganizacionafp.SISTEMA_PREV_ID
            .DIRECCION = afpEncabezado.datosOrganizacionafp.direccion
            .COMUNA_ID = afpEncabezado.datosOrganizacionafp.comuna
            .CODIGO_EXCAJA = afpEncabezado.datosOrganizacionafp.caja
            .CODIGO_PREVIRED = afpEncabezado.datosOrganizacionafp.previred
        End With
    End Sub

End Class
