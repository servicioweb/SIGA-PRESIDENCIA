Option Strict On
Imports System.ComponentModel
Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.Comun.TiposDeDatos
Imports System

'Las Definiciones de los tipos de datos de propósito 
'general se encuentran en namespace cl.presidencia.Argo.Comun.TipoDeDatos (Utiles.VB)

<Description("Persona")> _
Public Class Persona
    Protected _util As New DataAccess.Utiles
    Private varID As Long

    Public Sub setID(ByVal ID As Long)
        varID = ID
    End Sub

    Public ReadOnly Property ID() As Long
        Get
            Return (varID)
        End Get

    End Property

    Public Enum ESexo
        FEMENINO = 1
        MASCULINO = 2
    End Enum

    'Miembros del Objeto
    Public nombres As String
    Public apellidoPaterno As String
    Public apellidoMaterno As String
    Public rut As ERut
    Public fechaNacimiento As Date
    Public estadoCivil As TipoEstadoCivil
    Public direccion As EDireccion
    Public telefono As String
    Public celular As String
    Public nivelEducacional As Integer
    Public sexo As ESexo
    Public estadoEmpleadoID As Byte

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        _util = Nothing
    End Sub
End Class

<Description("CargaFamiliar")> _
Public Class CargaFamiliar

    Inherits Persona

#Region "Declaraciones"

    Private drCargaFam As DataRow
    Private EcargaFamiliar As ECargasFAM
    Private DScargaFamiliar As New DataAccess.DSCargaFamiliar
    Private empleado As New DataAccess.Empleados


#End Region

#Region "Contructores"
    'Constructor utilizado para el evento eliminar.
    Public Sub New(Optional ByVal EmpleadoID As Integer = 0, Optional ByVal CargaFAM_ID As Integer = 0)
        With EcargaFamiliar
            .EmpleadoID = EmpleadoID
            .ID = CargaFAM_ID
        End With
    End Sub
    'Constructor utilizado para el evento nuevo y actualizar.
    Public Sub New(ByVal EmpleadoID As Integer, _
        ByVal Fecha_Nacimiento As Date, _
        ByVal Fecha_Vigencia As Date, _
        ByVal Fecha_Vencimiento As Date, _
        ByVal Fecha_Modificacion As Date, _
        ByVal Hora_Modificacion As String, _
        ByVal Genero As Char, ByVal nombres As String, _
        ByVal apellido_Paterno As String, _
        ByVal apellido_Materno As String, _
        ByVal rut As Integer, _
        ByVal tipoBeneficioID As Integer, _
        ByVal tipoCausanteID As Integer, _
        Optional ByVal ID As Integer = 0, _
        Optional ByVal Nivel_Estudio_ID As Byte = CType(TipoNivelEducacional.SIN_ESTUDIOS, Byte), _
        Optional ByVal Tipo_Carga_Fam As Byte = CType(TipoCargaFamiliar.NO_APLICA, Byte), _
        Optional ByVal Parentesco_ID As Byte = CType(TipoParentesco.OTRO, Byte), _
        Optional ByVal Grupo_Familiar_ID As Byte = CType(TipoGrupoFamiliar.SOLO_PERTENECE_FAMILIA, Byte), _
        Optional ByVal Digito_Verificador As Char = CType("", Char), _
        Optional ByVal Estado As Byte = CType(TipoEstadoCargaFAM.NO_VIGENTE, Byte), _
        Optional ByVal Retension_Judicial As Char = CType("N", Char), _
        Optional ByVal Carga_Por_Estudios As Char = CType("N", Char), _
        Optional ByVal Causa_Termino_Asignacion As Byte = CType(TipoCausaTerminoAsignacion.SIN_CAUSA, Byte), _
        Optional ByVal Usuario As String = CType("", String), _
        Optional ByVal tipoEdicion As Int16 = 0, _
        Optional ByVal regimenEstudio As Integer = 0, _
        Optional ByVal fechaInicioReconocimiento As Date = #1/1/1900#, _
        Optional ByVal fechaFinReconocimiento As Date = #1/1/1900#, _
        Optional ByVal numeroResolucion As String = "", _
        Optional ByVal periodoId As Integer = 0)

        'Procedo a cargar los datos en una estructura de datos pública. comun.utils

        With EcargaFamiliar
            .ID = ID 'Identificador único de la carga familiar.
            .Fecha_Nacimiento = Fecha_Nacimiento
            .EmpleadoID = EmpleadoID
            .Fecha_Modificacion = Fecha_Modificacion
            .Hora_Modificacion = Hora_Modificacion
            .Parentesco_ID = Parentesco_ID
            .Nivel_Estudio_ID = Nivel_Estudio_ID
            .Grupo_Familiar_ID = Grupo_Familiar_ID
            .Rut = rut
            .Digito_Verificador = Digito_Verificador
            .Usuario = CType(Usuario, String)
            .Sexo = Genero
            .Apellido_Pat_Cargo = apellido_Paterno
            .Apellido_Mat_Cargo = apellido_Materno
            .Nombres = nombres
            .regimenEstudio = regimenEstudio

            If fechaInicioReconocimiento = Nothing Then
                .fechaInicioReconocimiento = CType("01-01-1900", Date)
            Else
                .fechaInicioReconocimiento = fechaInicioReconocimiento
            End If
            If fechaFinReconocimiento = Nothing Then
                .fechaFinReconocimiento = CType("01-01-1900", Date)
            Else
                .fechaFinReconocimiento = fechaFinReconocimiento
            End If
           
            .periodoId = periodoId
            .numeroResolucion = numeroResolucion

            'El tipo de edición está definido para identificar porque opción de menú ingreso
            'CARGAS FAMILIARES ó GRUPO FAMILIAR, todo esto porque ambas opciones hacen uso del
            'mismo formulario frmCargaFamiliar.

            If tipoEdicion = TipoEdicionCargaFAM.EDICION_COMO_CARGA_FAMILIAR Then
                'Traspaso la información de la carga familiar a la estrucura común definida.

                .Causa_Termino_Asignacion = Causa_Termino_Asignacion
                .Tipo_Carga_Fam = Tipo_Carga_Fam
                .Estado = Estado
                .Retension_Judicial = Retension_Judicial
                .Carga_Por_Estudios = Carga_Por_Estudios
                .Fecha_Vencimiento = Fecha_Vencimiento
                .Fecha_Vigencia = Fecha_Vigencia
                .tipoBeneficioId = tipoBeneficioID
                .tipoCausanteId = tipoCausanteID
            Else
                'Como se trata de una edición por GRUPO FAMILIAR, entrego valores por defectoa las opciones utilizadas
                'en la CARGAFAMILIAR.

                .Causa_Termino_Asignacion = CType(cl.presidencia.Argo.Comun.TiposDeDatos.TipoCausaTerminoAsignacion.SIN_CAUSA, Byte)
                .Tipo_Carga_Fam = CType(cl.presidencia.Argo.Comun.TiposDeDatos.TipoCargaFamiliar.SIMPLE_NORMAL, Byte)
                .Estado = CType(cl.presidencia.Argo.Comun.TiposDeDatos.TipoEstadoCargaFAM.NO_VIGENTE, Byte)
                .Retension_Judicial = CType("N", Char)
                .Carga_Por_Estudios = CType("N", Char)

                If .ID > 0 Then
                    .Fecha_Vencimiento = Fecha_Vencimiento
                    .Fecha_Vigencia = Fecha_Vigencia
                Else
                    .Fecha_Vencimiento = Nothing
                    .Fecha_Vigencia = Nothing
                End If
            End If
            'Acción.
            If .ID > 0 Then
                actualizarCargaFamiliar(EcargaFamiliar)
            Else
                CrearCargaFAM()
            End If
        End With
    End Sub


    'Fin de estructura carga familiar
#End Region
#Region "Propiedades"
    'Propiedad pública utilizada para recuperar la información de una carga familiar
    'determinada o en su defecto para agregar una carga familiar a un empleado.
#End Region
#Region "Asignaciones"
    Private Sub asignaCamposCargaFam(ByRef cargaFamiliarDR As DataAccess.DSCargaFamiliar.RH_PER_CARGA_FAMILIARRow)


        With cargaFamiliarDR
            'Paso los datos de la estructura (cargada en el constructor) al DATAROW cargaFamiliarDR.
            .EMPLEADO_ID = CType(EcargaFamiliar.EmpleadoID, Short)
            .APELLIDO_MAT_CARGA = CType(EcargaFamiliar.Apellido_Mat_Cargo, String)
            .APELLIDO_PAT_CARGA = CType(EcargaFamiliar.Apellido_Pat_Cargo, String)
            .CARGA_POR_ESTUDIO = EcargaFamiliar.Carga_Por_Estudios.ToString
            .CAUSA_TERMINO_ASIG_FAM_ID = CType(EcargaFamiliar.Causa_Termino_Asignacion, Byte)
            .DIGITO_VER_CARGA = EcargaFamiliar.Digito_Verificador.ToString
            .ESTADO_CARGA_ID = CType(EcargaFamiliar.Estado, Byte)
            .GRUPO_FAMILIAR_ID = CType(EcargaFamiliar.Grupo_Familiar_ID, Byte)
            .NIVEL_ESTUDIO_ID = CType(EcargaFamiliar.Nivel_Estudio_ID, Byte)
            .NOMBRES_CARGA = CType(EcargaFamiliar.Nombres, String)
            .PARENTESCO_ID = CType(EcargaFamiliar.Parentesco_ID, Byte)
            .RETENSION_JUDICIAL = EcargaFamiliar.Retension_Judicial.ToString
            .RUT_CARGA = CType(EcargaFamiliar.Rut, Integer)
            .SEXO_CARGA = CType(EcargaFamiliar.Sexo, Char)
            .TIPO_CARGA_FAM_ID = CType(EcargaFamiliar.Tipo_Carga_Fam, Byte)
            .ESTADO_REGISTRO = 1
            .USUARIO = EcargaFamiliar.Usuario.ToString
            .FECHA_NACIMIENTO = EcargaFamiliar.Fecha_Nacimiento
            .FECHA_MODIFICACION = EcargaFamiliar.Fecha_Modificacion
            .HORA_MODIFICACION = EcargaFamiliar.Hora_Modificacion
            .TIPO_BENEFICIO_ID = EcargaFamiliar.tipoBeneficioId
            .TIPO_CAUSANTE_ID = EcargaFamiliar.tipoCausanteId

            'Aprovecho el manejo de nulos que me da el DATASET DScargaFamiliar
            If EcargaFamiliar.Fecha_Vigencia = Nothing Then
                .SetFECHA_VIGENCIANull()
            Else
                .FECHA_VIGENCIA = EcargaFamiliar.Fecha_Vigencia
            End If

            If EcargaFamiliar.Fecha_Vencimiento = Nothing Then
                .SetFECHA_VENCIMIENTONull()
            Else
                .FECHA_VENCIMIENTO = EcargaFamiliar.Fecha_Vencimiento
            End If
            .REGIMEN_ESTUDIO = EcargaFamiliar.regimenEstudio
            .FECHA_INICIO_RECONOCIMIENTO = EcargaFamiliar.fechaInicioReconocimiento
            .FECHA_FIN_RECONOCIMIENTO = EcargaFamiliar.fechaFinReconocimiento
            .NUMERO_RESOLUCION = EcargaFamiliar.numeroResolucion
            .PERIODO_ID = EcargaFamiliar.periodoId
        End With
    End Sub
#End Region
#Region "Funciones"
    Public Function CrearCargaFAM() As Long
        Dim cargaFAMDR As DataAccess.DSCargaFamiliar.RH_PER_CARGA_FAMILIARRow
        Dim Indentity As Integer

        cargaFAMDR = CType(DScargaFamiliar.Tables(Tablas.RH_PER_CARGA_FAMILIAR).NewRow, _
                           DataAccess.DSCargaFamiliar.RH_PER_CARGA_FAMILIARRow)

        asignaCamposCargaFam(cargaFAMDR)

        Indentity = CType(empleado.Insertar(cargaFAMDR, _
                           DScargaFamiliar.Tables(Tablas.RH_PER_CARGA_FAMILIAR), _
                           DScargaFamiliar), Integer)
        Return (Indentity)

    End Function
    Public Function actualizarCargaFamiliar(ByVal datosCarga As ECargasFAM) As Boolean
        Dim cargaFAMDR As DataAccess.DSCargaFamiliar.RH_PER_CARGA_FAMILIARRow
        cargaFAMDR = CType(empleado.Busca(DScargaFamiliar, datosCarga.ID, Tablas.RH_PER_CARGA_FAMILIAR, "SELECT * FROM " & Tablas.RH_PER_CARGA_FAMILIAR), DataAccess.DSCargaFamiliar.RH_PER_CARGA_FAMILIARRow)
        Try
            asignaCamposCargaFam(cargaFAMDR)
            cargaFAMDR = CType(empleado.actualizarDatosCargaFAM(DScargaFamiliar, cargaFAMDR), DataAccess.DSCargaFamiliar.RH_PER_CARGA_FAMILIARRow)
            Return True
        Catch ex As Exception
            Return (False)
        End Try
    End Function
    Public Function recuperarDetalleCargaFamiliar(ByVal ID As Integer) As DataView
        'Se rescatan los datos de DETALLE de una carga Familiar
        Return (empleado.recuperaDetalleCargaFamiliar(ID))
    End Function
#End Region
    Public Function EliminarCargaFamiliar() As Boolean
        Try
            empleado.Elimina(SQL.STORE_PROCEDURES.ELIMINA_CARGA_FAM & " " & EcargaFamiliar.ID)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function
    Public Function CAMBIA_ESTADO_CARGA_FAMILIAR(ByVal CARGA_FAMILIAR_ID As Integer) As Boolean
        Try
            empleado.EjecutaSQL(SQL.STORE_PROCEDURES.CAMBIA_ESTADO_CARGA_FAMILIAR & " " & CARGA_FAMILIAR_ID)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function
End Class

<Description("EventoAdministrativo")> _
Public Class EventoAdministrativo
    Public nombre As String
End Class

<Description("Viatico")> _
Public Class ViaticoEmpleado

#Region "Declaraciones"
    Private empleado As New DataAccess.Empleados
    Private DSempleados As New DataAccess.DSEmpleado
    Private EViatico As EViatico
    Private EDetalleViatico As EDetalleViatico
    Dim viaticoDR As DataAccess.DSEmpleado.RH_PER_VIATICORow
    Dim ID As Integer



#End Region

#Region "Contructores"
    'Constructor utilizado para el evento eliminar un viático asignado.
    Public Sub New(ByVal idDetalleViatico As Integer, ByVal idViatico As Integer)
        With EDetalleViatico
            .detalleViaticoID = idDetalleViatico
            .viaticoID = idViatico
        End With
    End Sub
    'Constructor utilizado para el evento editar o buscar.
    Public Sub New(Optional ByVal VIATICO_ID As Integer = 0)
        With EViatico
            .viaticoID = VIATICO_ID
            If .viaticoID > 0 Then
                viaticoDR = CType(empleado.Busca(VIATICO_ID), DataAccess.DSEmpleado.RH_PER_VIATICORow)
            End If
        End With
    End Sub
    'Constructor utilizado para crear un ENCABEZADO (memo), el cual estará asociado a un grupo de viáticos.
    Public Sub New(ByVal viaticoID As Integer, ByVal EmpleadoID As Integer, ByVal estado As Byte, _
        ByVal tipo_Resolucion As Int16, _
        ByVal numero_Memorandum As String, _
        ByVal Fecha_Memorandum As Date, _
        ByVal periodo As String, _
        ByVal observacion As String, ByVal numero_Resolucion As String, ByVal usuario As String, _
        ByVal hora_Modificacion As String, ByVal fecha_Modificacion As Date, ByVal MOTIVO As String, _
        ByVal Fecha_Resolucion As Date)

        'Procedo a cargar los datos en una estructura de datos pública. comun.utils

        With EViatico
            .viaticoID = viaticoID
            .empleadoID = EmpleadoID
            .estado = estado
            .tipoResolucion = tipo_Resolucion
            .numeroMemorandum = numero_Memorandum
            .fechaMemorandum = Fecha_Memorandum
            .periodo = periodo
            .observacion = observacion
            .numeroResolucion = numero_Resolucion
            .usuario = usuario
            .horaModificacion = hora_Modificacion
            .fechaModificacion = fecha_Modificacion
            .motivo = MOTIVO

            If viaticoID > 0 Then
                actualizarViaticoMaestro(EViatico)
            Else
                CrearViaticoMaestro()
            End If

        End With
    End Sub
    'Constructor utilizado para crear o asignar viáticos a los funcionarios.
    Public Sub New(ByVal VIATICO_DETALLE_ID As Integer, _
        ByVal VIATICO_ID As Integer, _
        ByVal CANTIDAD_DIAS As Int16, _
        ByVal FECHA_INICIO As Date, _
        ByVal FECHA_TERMINO As Date, _
        ByVal OBSERVACION As String, _
        ByVal PAIS_ID As Integer, _
        ByVal COMUNA_ID As Integer, ByVal FECHA_MODIFICACION As Date, ByVal FECHA_DOCUMENTO As Date, Optional ByVal MONTO As Integer = 0, Optional ByVal USUARIO As String = "NoDefinido", _
        Optional ByVal HORA_MODIFICACION As String = "", Optional ByVal EMPLEADO_ID As Integer = -1, _
        Optional ByVal NUMERO_DOCUMENTO As String = "S/N", Optional ByVal REGION_ID As Int16 = -1, Optional ByVal DESTINO As Short = 0, Optional ByVal ESTADO As Int16 = 0, Optional ByVal GRADO_ID As Int16 = 0, Optional ByVal PATENTE_VEHICULO As String = "")

        With EDetalleViatico
            .detalleViaticoID = VIATICO_DETALLE_ID
            .viaticoID = VIATICO_ID
            .cantidadDias = CANTIDAD_DIAS
            .fechaInicio = FECHA_INICIO
            .fechaTermino = FECHA_TERMINO
            .motivo = OBSERVACION
            .paisID = PAIS_ID
            .comunaID = COMUNA_ID
            .regionID = REGION_ID
            .monto = MONTO
            .usuario = USUARIO
            .fechaModificacion = FECHA_MODIFICACION
            .horaModificacion = HORA_MODIFICACION
            .empleadoID = EMPLEADO_ID
            .numeroDocumento = NUMERO_DOCUMENTO
            .fechaDocumento = FECHA_DOCUMENTO
            .destino = DESTINO
            .estado = ESTADO
            .grado_id = GRADO_ID
            .patenteVehiculo = PATENTE_VEHICULO
        End With



        If VIATICO_DETALLE_ID > 0 Then
            actualizarViaticoDetalle(EDetalleViatico)
        Else
            CrearViaticoDetalle()
        End If
    End Sub


    'Fin de estructura carga familiar
#End Region
#Region "Propiedades"
    'Propiedad pública utilizada para recuperar la información de una carga familiar
    'determinada o en su defecto para agregar una carga familiar a un empleado.
#End Region
#Region "Asignaciones"
    Private Sub asignaCamposViatico(ByRef viaticoDR As DataAccess.DSEmpleado.RH_PER_VIATICORow)


        With viaticoDR
            'Paso los datos de la estructura (cargada en el constructor) al DATAROW viaticoDR.
            If EViatico.viaticoID = 0 Then
                .VIATICO_ID = EViatico.viaticoID
            End If

            .EMPLEADO_ID = CType(EViatico.empleadoID, Short)
            '.ESTADO_VIATICO = CType(EViatico.estado, Byte)
            .TIPO_RESOLUCION = CType(EViatico.tipoResolucion, Byte)
            .NRO_MEMORANDUM_INTERNO = EViatico.numeroMemorandum
            .FECHA_MEMORANDUM = EViatico.fechaMemorandum
            .PERIODO = EViatico.periodo
            .OBSERVACION = EViatico.observacion
            .NRO_RESOLUCION = EViatico.numeroResolucion
            .USUARIO = EViatico.usuario
            .HORA_MODIFICACION = EViatico.horaModificacion
            .FECHA_MODIFICACION = EViatico.fechaModificacion
            .MOTIVO = EViatico.motivo


        End With

    End Sub
    Private Sub asignaCamposViatico_Detalle(ByRef viaticoDetalleDR As DataAccess.DSEmpleado.RH_PER_VIATICO_DETALLERow)


        With viaticoDetalleDR
            'Paso los datos de la estructura (cargada en el constructor) al DATAROW viaticoDR.
            If EDetalleViatico.detalleViaticoID = 0 Then
                .VIATICO_DETALLE_ID = EDetalleViatico.detalleViaticoID
            End If

            .VIATICO_ID = EDetalleViatico.viaticoID
            .CANTIDAD_DIAS = CType(EDetalleViatico.cantidadDias, Byte)
            .FECHA_INICIO = EDetalleViatico.fechaInicio
            .FECHA_TERMINO = EDetalleViatico.fechaTermino
            .MOTIVO = EDetalleViatico.motivo
            .ESTADO_VIATICO = CType(EDetalleViatico.estado, Byte)
            .GRADO_ID = EDetalleViatico.grado_id

            If EDetalleViatico.paisID = 0 Then
                .SetPAIS_IDNull()
            Else
                .PAIS_ID = EDetalleViatico.paisID
            End If

            If EDetalleViatico.comunaID = 0 Then
                .SetCOMUNA_IDNull()
            Else
                .COMUNA_ID = EDetalleViatico.comunaID
            End If

            If EDetalleViatico.regionID = 0 Then
                .SetREGION_IDNull()
            Else
                .REGION_ID = EDetalleViatico.regionID
            End If

            .MONTO = EDetalleViatico.monto
            .USUARIO = EDetalleViatico.usuario
            .FECHA_MODIFICACION = EDetalleViatico.fechaModificacion
            .HORA_MODIFICACION = EDetalleViatico.horaModificacion
            .EMPLEADO_ID = EDetalleViatico.empleadoID
            .NUMERO_DOCUMENTO = EDetalleViatico.numeroDocumento
            .DESTINO = CType(EDetalleViatico.destino, Byte)

            'Aprovecho el manejo de nulos que me da el DATASET DScargaFamiliar
            If EDetalleViatico.fechaDocumento = Nothing Then
                .SetFECHA_DOCUMENTONull()
            Else
                .FECHA_DOCUMENTO = CType(EDetalleViatico.fechaDocumento, Date)
            End If
            .PATENTE_VEHICULO = EDetalleViatico.patenteVehiculo
        End With

    End Sub
#End Region
#Region "Funciones"
    Public Function CrearViaticoMaestro() As Long
        Dim viatico As DataAccess.DSEmpleado.RH_PER_VIATICORow
        Dim IDentity As Integer

        viatico = CType(empleado.Tables(Tablas.RH_PER_VIATICO).NewRow, _
                           DataAccess.DSEmpleado.RH_PER_VIATICORow)

        asignaCamposViatico(viatico)

        IDentity = CType(empleado.Insertar(viatico, empleado.Tables(Tablas.RH_PER_VIATICO), DSempleados), Integer)

        Return (IDentity)
    End Function
    Public Function CrearViaticoDetalle() As Long
        Dim detalleViatico As DataAccess.DSEmpleado.RH_PER_VIATICO_DETALLERow
        Dim Identity As Integer
        detalleViatico = CType(empleado.Tables(Tablas.RH_PER_VIATICO_DETALLE).NewRow, _
                           DataAccess.DSEmpleado.RH_PER_VIATICO_DETALLERow)

        asignaCamposViatico_Detalle(detalleViatico)

        Identity = CType(empleado.Insertar(detalleViatico, _
                           empleado.Tables(Tablas.RH_PER_VIATICO_DETALLE), _
                           DSempleados), Integer)
        Return (Identity)


    End Function
    Public Function actualizarViaticoMaestro(ByVal datosViatico As EViatico) As Boolean
        Dim viatico As DataAccess.DSEmpleado.RH_PER_VIATICORow
        viatico = CType(empleado.Busca(DSempleados, datosViatico.viaticoID, Tablas.RH_PER_VIATICO, "SELECT * FROM " & Tablas.RH_PER_VIATICO), DataAccess.DSEmpleado.RH_PER_VIATICORow)
        Try
            asignaCamposViatico(viatico)
            viatico = CType(empleado.actualizarDatosViatico(DSempleados, viatico), DataAccess.DSEmpleado.RH_PER_VIATICORow)
            Return True
        Catch ex As Exception
            Return (False)
        End Try
    End Function
    Public Function actualizarViaticoDetalle(ByVal datosViatico As EDetalleViatico) As Boolean
        Dim detalleViatico As DataAccess.DSEmpleado.RH_PER_VIATICO_DETALLERow
        detalleViatico = CType(empleado.Busca(DSempleados, datosViatico.detalleViaticoID, Tablas.RH_PER_VIATICO_DETALLE, "SELECT * FROM " & Tablas.RH_PER_VIATICO_DETALLE), DataAccess.DSEmpleado.RH_PER_VIATICO_DETALLERow)
        Try
            asignaCamposViatico_Detalle(detalleViatico)
            detalleViatico = CType(empleado.actualizarDatosDetalleViatico(DSempleados, detalleViatico), DataAccess.DSEmpleado.RH_PER_VIATICO_DETALLERow)
            Return True
        Catch ex As Exception
            Return (False)
        End Try
    End Function
    Public Function recuperarViaticoMaestro(ByVal ID As Integer) As DataRow
        'Se rescatan los datos de DETALLE de una carga Familiar
        Return (empleado.recuperarViaticoMaestro(ID))
    End Function
#End Region
    Public Function EliminaViaticoMaestro() As Boolean
        Try
            empleado.Elimina(SQL.STORE_PROCEDURES.ELIMINA_VIATICO_MAESTRO & " " & EDetalleViatico.viaticoID)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function
    Public Function EliminaViaticoDetalle() As Boolean
        Try
            empleado.Elimina(SQL.STORE_PROCEDURES.ELIMINA_VIATICO_DETALLE & " " & EDetalleViatico.detalleViaticoID)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function
End Class


Public Class ColeccionDatosCurriculares
    Inherits System.Collections.CollectionBase
    Public Overridable Function Add(ByVal value As DatoCurricular) As Integer
        MyBase.List.Add(value)
    End Function
    Default Public Overridable Property Item(ByVal index As Integer) As DatoCurricular
        Get
            Return DirectCast(MyBase.List.Item(index), DatoCurricular)
        End Get
        Set(ByVal value As DatoCurricular)
            MyBase.List.Item(index) = value
        End Set
    End Property
End Class
Public Class DatoCurricular
    Public nombreEmpresa As String
    Public cargofuncion As String
    Public pais As Integer
    Public comuna As Integer
    Public fechaInicio As Date
    Public fechaTermino As Date
    Public tiempopermanencia As String
    Public referenciaLaboral As String
    Public funcionesTareas As String
End Class
Public Class DatoAPV
    Public empleadoID As Integer
    Public tipoAhorroVoluntario As Integer
    Public estadoRegistro As Integer
    Public institucionID As Integer
    Public montoAhorroVoluntario As Decimal
    Public uniddadAhorroVoluntario As Integer
End Class

<Description("PersonaLaboral")> _
Public Class PersonaLaboral
    Inherits Persona
    Public empleado_id As Integer
    Public calidadJuridica_id As Integer
    Public escalafon_id As Integer
    Public estadoRegistro As Integer
    Public estamento_id As Integer
    Public fechaIngresoInstitucion As Date
    Public fechaRetiro As Date
    Public grado_ID As Integer
    Public jefe_ID As Integer
    Public motivoRetiro_ID As Integer
    Public resolucion_ID As Integer
    Public ubicacionFisica_ID As Integer
    Public HorarioDeTrabajo As Integer
    Public calidadJuridica As TipoCalidadJuridica
    Public estamento As TipoEstamento
    Public escalafon As TipoEscalafon
    Public horario As String
    Public lugarDeTrabajo As EDireccion
    Public jefeDirecto As String
    Public numeroResolucion As String
    Public fechaResolucionContrato As Date
    Public fechaIngresoAdministracionPublica As Date
    Public FonoAnexo As String
    Public ContactoEmergencia As String
    Public servicioMilitar As String
    Public matriculaMilitar As String
    Public grupoSanguineo As String
    Public alergias As String
    Public email As String
    Public enfermedadCronica As String
    Public medicamentosContraindicados As String
    Public grado As String
    Private _datosCurriculares As ColeccionDatosCurriculares
    Private varSituacion As TipoEstado
    Private varRetiro As TipoRetiro


    Public Property datosCurriculares() As ColeccionDatosCurriculares
        Get
            Return _datosCurriculares
        End Get
        Set(ByVal value As ColeccionDatosCurriculares)
            _datosCurriculares = value
        End Set
    End Property

    Public ReadOnly Property estado() As TipoEstado
        Get
            Return (varSituacion)
        End Get
    End Property

    Public Sub setEstado(ByVal varEstado As TipoEstado)
        varSituacion = varEstado
    End Sub

    Public Property retiro() As TipoRetiro
        Get
            Return (varRetiro)
        End Get
        Set(ByVal Value As TipoRetiro)
            varRetiro = Value
        End Set
    End Property
End Class

<Description("PersonaSalud")> _
Public Class PersonaSalud
    Inherits Persona

    Public Enum TipoMoneda
        PESOS_CL = 1
        PESOS_AR = 2
        UF_CL = 3
        DOLARES_US = 4
        EUROS_UE = 5
    End Enum
End Class

<Description("PersonaRemuneracion")> _
Public Class PersonaRemuneracion
    Inherits PersonaLaboral

    Public Enum TipoFormaPago
        CHEQUE = 0
        EFECTIVO = 1
        DEPOSITO_CUENTA = 2
    End Enum

    Public Enum TipoCuentaBancaria
        CUENTA_AHORRO = 1
        CUENTA_CORRIENTE = 2
        CHEQUERA_ELECTRONICA = 3
        CUENTA_VISTA = 4
    End Enum
    Public datosLaborales As EDatosLaborales
    Public datosPrevisionales As EDatosPrevisionales
    Public datosSalud As EDatosSalud
    Public datosAPV As EDatosAPV
    Public datosCargasFamiliares As ECargasFAM
    Public datosRemuneracion As EDatosRemuneracion
    Public datosLicenciaMedica As ELicenciaMedica
    Public datosEventoAdmin As EEventoAdmin
    Public datosEventoAdminDetalle As EEventoAdminDetalle
    Public datosEUS As EDatosEUS
    Public datosSaldoDiasEventoAdmin As ESaldoDiasEventoAdmin
    Public datosEstructuraOrganica As EEstructuraOrganica
    Public datosEstructuraContable As EEstructuraContable
    Public datosPresupuestoHonorario As EDatosPresupuestoAnualHonorario
    Public datosCurriculumLaboral As EDatosCurriculumLaboral
End Class
Public Class EmpleadoContableyOrganica
    Inherits Empleado

    Public Sub New(ByVal ID As Long)
        'MyBase.New(ID)
        asignacionCampos(CType(recuperarEstructuraOrganica(), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_ORGANICARow))
        asignacionCampos(CType(recuperarEstructuraContable(), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_CONTABLERow))
    End Sub
End Class

<Description("Empleado")> _
Public Class Empleado
    Inherits PersonaRemuneracion

    Private varOrganizacionID As Short

    Public Property organizacion() As Short
        Get
            Return (varOrganizacionID)
        End Get
        Set(ByVal Value As Short)
            varOrganizacionID = Value
        End Set
    End Property

    Public ReadOnly Property nombreCompleto() As String
        Get
            Return (RTrim(apellidoPaterno) & " " & RTrim(apellidoMaterno) & ", " & RTrim(nombres))
        End Get
    End Property
    Private Const NOMBRE_TABLA As String = Tablas.RH_PER_EMPLEADO


    Dim empleadosDS As New DataAccess.Empleados


    Public Sub New()
        MyBase.new()
        Me.setID(0)
    End Sub

    Public Sub New(ByVal Rut As Integer)
        MyBase.new()
        Dim empleadoDR As DataAccess.DSEmpleado.RH_PER_EMPLEADORow
        empleadoDR = CType(empleadosDS.Busca(Rut), DataAccess.DSEmpleado.RH_PER_EMPLEADORow)
        If Not empleadoDR Is Nothing Then
            Me.setID(CType(empleadoDR("EMPLEADO_ID"), Long))
            asignacionCampos(empleadoDR)
            asignacionCamposDatosLaborales(CType(recuperarDatosLaborales(), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_LABORALRow))
            asignacionCampos(CType(recuperarAntecedentesCurriculares(), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_CURRIRow))
            asignacionCampos(CType(recuperarAntecedentePrevisional(), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_PREVISRow))
            recuperarAntecedentesAPV()
            asignacionCampos(CType(recuperarAntecedenteRemun(), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_REMUNRow))
            asignacionCampos(CType(recuperarEstructuraOrganica(), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_ORGANICARow))
            asignacionCampos(CType(recuperarEstructuraContable(), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_CONTABLERow))
        Else
            Throw (New Exception("Rut inexistente"))
        End If
        MyBase.Finalize()
    End Sub
    Public Sub New(ByVal ID As Long)
        MyBase.new()
        Me.setID(ID)
        Dim empleadoDR As DataAccess.DSEmpleado.RH_PER_EMPLEADORow
        empleadoDR = CType(empleadosDS.Busca(Me.ID), DataAccess.DSEmpleado.RH_PER_EMPLEADORow)
        If Not empleadoDR Is Nothing Then
            asignacionCampos(empleadoDR)
            'Se rescatan los datos laborales. 
            'Si la persona ha sido creada recientemente, éstos datos no están disponibles.
            Dim drDatosLaborales As DataRow
            drDatosLaborales = recuperarDatosLaborales()
            If Not drDatosLaborales Is Nothing Then
                asignacionCamposDatosLaborales(CType(recuperarDatosLaborales(), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_LABORALRow))
            End If
            drDatosLaborales = Nothing

            'Datos curriculares.
            Dim drAntecedentesCurriculares As DataRow
            drAntecedentesCurriculares = recuperarAntecedentesCurriculares()
            If Not drAntecedentesCurriculares Is Nothing Then
                asignacionCampos(CType(recuperarAntecedentesCurriculares(), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_CURRIRow))
            End If
            drAntecedentesCurriculares = Nothing

            'Antecedentes Previsionales
            Dim drAntecedentesPrevisionales As DataRow
            drAntecedentesPrevisionales = recuperarAntecedentePrevisional()
            If Not drAntecedentesPrevisionales Is Nothing Then
                asignacionCampos(CType(drAntecedentesPrevisionales, DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_PREVISRow))
            End If
            drAntecedentesPrevisionales = Nothing

            'Antecedente presupuesto anual honorario
            Dim drAntecedentePresupuestoAnualHonorario As DataRow
            drAntecedentePresupuestoAnualHonorario = recuperarAntecedentePresupuestoAnualHonorario()
            If Not drAntecedentePresupuestoAnualHonorario Is Nothing Then
                asignacionCampos(CType(drAntecedentePresupuestoAnualHonorario, DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_HONORARIO_DETALLERow))
            End If
            drAntecedentePresupuestoAnualHonorario = Nothing

            recuperarAntecedentesAPV()
            asignacionCampos(CType(recuperarAntecedenteRemun(), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_REMUNRow))
            asignacionCampos(CType(recuperarEstructuraOrganica(), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_ORGANICARow))
            asignacionCampos(CType(recuperarEstructuraContable(), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_CONTABLERow))
        Else
            Throw (New Exception("ID inexistente"))
        End If
        MyBase.Finalize()
    End Sub
    Public Sub New(ByVal ID As Long, ByVal CalculoRemuneracion As Boolean, Optional ByVal honorario As Boolean = False)
        MyBase.new()
        Me.setID(ID)
        Dim empleadoDR As DataAccess.DSEmpleado.RH_PER_EMPLEADORow
        empleadoDR = CType(empleadosDS.Busca(Me.ID), DataAccess.DSEmpleado.RH_PER_EMPLEADORow)
        If Not empleadoDR Is Nothing Then
            asignacionCampos(empleadoDR)

            Dim drDatosLaborales As DataRow
            drDatosLaborales = recuperarDatosLaborales()
            If Not drDatosLaborales Is Nothing Then
                asignacionCamposDatosLaborales(CType(recuperarDatosLaborales(), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_LABORALRow))
            End If
            drDatosLaborales = Nothing
            asignacionCampos(CType(recuperarAntecedenteRemun(), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_REMUNRow))

            'Se verifica si es honorarios.
            If Not honorario Then
                'Antecedentes Previsionales
                Dim drAntecedentesPrevisionales As DataRow
                drAntecedentesPrevisionales = recuperarAntecedentePrevisional()
                If Not drAntecedentesPrevisionales Is Nothing Then
                    asignacionCampos(CType(drAntecedentesPrevisionales, DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_PREVISRow))
                End If
                drAntecedentesPrevisionales = Nothing

                recuperarAntecedentesAPV()

            End If

        Else
            Throw (New Exception("ID inexistente"))
        End If
    End Sub
    Public Sub New(ByVal ID As Long, ByVal IdperiodoHistorico As Integer)
        MyBase.new()
        Me.setID(ID)
        Dim empleadoDR As DataAccess.DSEmpleado.RH_PER_EMPLEADORow
        empleadoDR = CType(empleadosDS.Busca(Me.ID), DataAccess.DSEmpleado.RH_PER_EMPLEADORow)

        If Not empleadoDR Is Nothing Then
            asignacionCampos(empleadoDR)

            Dim drDatosLaborales As DataRow
            drDatosLaborales = recuperarDatoLaboralHistorico(IdperiodoHistorico)
            If Not drDatosLaborales Is Nothing Then
                'asignacionCamposDatosLaborales(CType(recuperarDatosLaborales(), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_LABORALRow))
                asignacionCamposDatosLaborales(CType(recuperarDatoLaboralHistorico(IdperiodoHistorico), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_LABORALRow))
            End If
            drDatosLaborales = Nothing
            asignacionCampos(CType(recuperarAntecedentePrevisionalHistorico(IdperiodoHistorico), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_PREVISRow))
            recuperarAntecedentesAPVHistorico(IdperiodoHistorico)
            asignacionCampos(CType(recuperarAntecedenteRemunHistorico(IdperiodoHistorico), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_REMUNRow))


            '---------

            'Antecedente presupuesto anual honorario
            Dim drAntecedentePresupuestoAnualHonorario As DataRow
            drAntecedentePresupuestoAnualHonorario = recuperarAntecedentePresupuestoAnualHonorario()
            If Not drAntecedentePresupuestoAnualHonorario Is Nothing Then
                asignacionCampos(CType(drAntecedentePresupuestoAnualHonorario, DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_HONORARIO_DETALLERow))
            End If
            drAntecedentePresupuestoAnualHonorario = Nothing
            asignacionCampos(CType(recuperarEstructuraOrganicaHistorico(IdperiodoHistorico), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_ORGANICARow))
            asignacionCampos(CType(recuperarEstructuraContableHistorico(IdperiodoHistorico), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_CONTABLERow))

            '---------
        End If

    End Sub

    Public ReadOnly Property dvDatosPrevisionales() As DataView
        Get
            Return (recuperarAntecedentesPrevisionales())
        End Get
    End Property
    Public ReadOnly Property dvDatosAPV() As DataView
        Get
            Return recuperarAntecedentesAPV()
        End Get
    End Property
    'Public ReadOnly Property dvDatosCurriculares() As DataView
    '    Get
    '        Return recuperarAntecedentesCurriculares()
    '    End Get
    'End Property

    Public ReadOnly Property dvDetalleEventoAdmin(ByVal ID As Integer) As DataView
        Get
            Return recuperarDetalleEventoAdmin(ID)
        End Get
    End Property

    Public ReadOnly Property dvEventosAdministrativos(ByVal idEmpleado As Integer, ByVal tipoEvento As Integer, ByVal anoProceso As Integer) As DataView
        Get
            Return recuperaEventosAdministrativos(idEmpleado, tipoEvento, anoProceso)
        End Get
    End Property

    Public ReadOnly Property dsEventoAdministrativo() As DataSet
        Get
            Return recuperarEventoAdministrativo()
        End Get
    End Property

    Public ReadOnly Property dvDetalleEventoAdministrativo(ByVal ID As Integer) As DataView
        Get
            Return recuperarDetalleEventoAdministrativo(ID)
        End Get
    End Property
    Public ReadOnly Property dvDatosAcademicos() As DataView
        Get
            Return recuperarDatosAcademicos()
        End Get
    End Property
    Public ReadOnly Property dvDatosLicenciaMedica(ByVal idEmpleado As Integer) As DataView
        Get
            Return recuperarDatosLicenciaMedica(idEmpleado)
        End Get
    End Property
    Public ReadOnly Property dvHistoriaEventosAdminEmpleado(ByVal idEmpleado As Integer, ByVal anno As String) As DataView
        Get
            Return recuperarHistoriaEventosAdminEmpleado(idEmpleado, anno)
        End Get
    End Property
    Public ReadOnly Property dvCargasFamiliares() As DataView
        Get
            Return (recuperarCargasFamiliares())
        End Get
    End Property

    Public ReadOnly Property dvCargasFamiliaresSoloGrupoFamiliar() As DataView
        Get
            Return (recuperarCargasFamiliaresSoloGrupoFamiliar())
        End Get
    End Property
    Public ReadOnly Property dvItemes(ByVal iditem As Integer, ByVal idperiodo As Short, ByVal tipProceso As String) As DataView
        Get
            Return recuperarDatosItemes(iditem, idperiodo, tipProceso)
        End Get
    End Property
    Public ReadOnly Property dvRemuneracionLiquida(ByVal idperiodo As Short, ByVal tipProceso As Integer) As DataView
        Get
            Return recuperarDatosRemuneracionLiquida(idperiodo, tipProceso)
        End Get
    End Property
    Public ReadOnly Property dvArchivoPlanoRemuneracionLiquida(ByVal idperiodo As Short, ByVal tipProceso As Integer) As DataView
        Get
            Return recuperarDatosArchivoPlanoRemuneracionLiquida(idperiodo, tipProceso)
        End Get
    End Property

    Public ReadOnly Property dvCargasFamiliaresActualizaFichaEmpleado() As DataView
        Get
            Return recuperarDatosCargasFamiliaresActualizaFichaEmpleado()
        End Get
    End Property

    Public ReadOnly Property dvItemesEmpleadoPeriodo(ByVal idEmpleado As Integer, ByVal idperiodo As Short, ByVal tipoProceso As String) As DataView
        Get
            Return recuperarDatosItemesEmpleadoPeriodo(idEmpleado, idperiodo, tipoProceso)
        End Get
    End Property

    Public ReadOnly Property dvItemesEmpleadoPeriodo(ByVal idEmpleado As Integer, ByVal idperiodo As Short, ByVal tipoProceso As String, ByVal itemsID As Array) As DataView
        Get
            Return recuperarDatosItemesEmpleadoPeriodo(idEmpleado, idperiodo, tipoProceso, itemsID)
        End Get
    End Property

    Public ReadOnly Property dvMarcasControlAcceso(ByVal idEmpleado As Integer, ByVal fechaInicial As Date, ByVal fechaFinal As Date) As DataView
        Get
            Return recuperarMarcasControlAcceso(idEmpleado, fechaInicial, fechaFinal)
        End Get
    End Property

    Public ReadOnly Property dvReliquidacionEmpleado(ByVal idEmpleado As Integer, ByVal idperiodo As Short, ByVal tipoProceso As String) As DataView
        Get
            Return recuperarReliquidacionEmpleado(idEmpleado, idperiodo, tipoProceso)
        End Get
    End Property

    Public ReadOnly Property dvHojaVidaLaboral(ByVal idEmpleado As Integer) As DataView
        Get
            Return recuperarDatosVidaLaboral(idEmpleado)
        End Get
    End Property
    Public ReadOnly Property dvMaestroViatico(ByVal ID As Integer, Optional ByVal numMemorandum As String = "") As DataRow
        Get
            'Obtiene los datos del encabezado MEMO.
            Return recuperarViaticoMaestro(ID, numMemorandum)
        End Get
    End Property
    Public ReadOnly Property dvDetalleViatico(ByVal ID As Integer) As DataView
        Get
            'Es utilizado en el formulario de mantenimiento de viaticos.
            'Obtiene todos los viaticos asociados a un documento ej: MEMO
            Return recuperarViaticosAsignados(ID)
        End Get
    End Property
    Public ReadOnly Property dvViativosAsignados(ByVal idempleado As Integer, ByVal año As Integer, Optional ByVal numMemorandum As String = "") As DataView
        Get
            'Es utilizado en el formulario historia de viáticos.
            Return recuperarViaticos(idempleado, año, numMemorandum)
        End Get
    End Property
    Public ReadOnly Property dvViativosAsignadosResolucion(ByVal idempleado As Integer, ByVal año As Integer, Optional ByVal numResolucion As String = "") As DataView
        Get
            'Es utilizado en el formulario historia de viáticos.
            Return recuperarViaticosResolucion(idempleado, año, numResolucion)
        End Get
    End Property

    Public ReadOnly Property dvViaticosPorNumeroMemo(ByVal año As Integer, ByVal listaViatico As String, ByVal estadoViatico As Integer) As DataView
        Get
            Return empleadosDS.recuperarViaticosNumeroMemorandum(año, listaViatico, estadoViatico)
        End Get
    End Property

    Public ReadOnly Property dvHorasExtrasPorPeriodo(ByVal idPeriodo As Integer, ByVal tipoProceso As String) As DataView
        Get
            'Obtiene todas las horas extras relacionadas a un periodo.
            Return recuperarHorasExtrasPorPeriodo(idPeriodo, tipoProceso)
        End Get
    End Property
    Public ReadOnly Property dvEUS(ByVal idEus As Integer) As DataView
        Get
            Return recuperarDatosEUS(idEus)
        End Get
    End Property
    Public ReadOnly Property dvEmpleadoEnviadosADexon() As DataView
        Get
            Return recuperarEmpleadoEnviadosADexon()
        End Get
    End Property
    Public ReadOnly Property dvReajusteEUS(ByVal idEus As Integer) As DataView
        Get
            Return recuperarDatosReajusteEUS(idEus)
        End Get
    End Property

    Public ReadOnly Property dvBonoModernizacion(ByVal anno As Short) As DataView
        Get
            Return recuperarDatosBonoModernizacion(anno)
        End Get
    End Property
    Public ReadOnly Property dvEstructuraOrganicaEmpleado() As DataView
        Get
            Return recuperarDatosEstructuraOrganicaEmpleado()
        End Get
    End Property
    Public ReadOnly Property dvEstructuraContableEmpleado() As DataView
        Get
            Return recuperarDatosEstructuraContableEmpleado()
        End Get
    End Property
    Public ReadOnly Property dvDatosFichaIntranet() As DataView
        Get
            Return recuperarDatosFichaIntranet()
        End Get
    End Property
    Public Sub asignacionCampos(ByVal dr As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_PREVISRow)
        If Not dr Is Nothing Then
            Me.datosPrevisionales.antecedentePrevisID = CType(dr("ANTECEDENTE_PREVIS_ID"), Integer)
            Me.datosPrevisionales.varEstadoRegistro = CType(dr("ESTADO_REGISTRO"), estadoRegistro)
            Me.datosPrevisionales.institucionID = CType(dr("AFP_ID"), Integer)
            Me.datosPrevisionales.institucion = CType(_util.buscaID_(Comun.Tablas.RH_REM_AFP, "NA", "AFP_ID", CType(CType(dr("AFP_ID"), Integer), String), "DESCRIPCION"), String)
            Me.datosPrevisionales.fechaIngresoSistemaPrevisional = CType(dr("FECHA_ING_SISTEMA_PREVIS"), Date)
            Me.datosPrevisionales.fechaAfiliacion = CType(dr("FECHA_AFILIACION_AFP"), Date)
            Me.datosPrevisionales.montoCuentaAhorroAFP = CType(dr("MONTO_AHORRO_AFP"), Decimal)
            Me.datosPrevisionales.unidadCuentaAhorroAFPId = CType(dr("MONEDA_AHORRO_AFP_ID"), Byte)
            Me.datosPrevisionales.unidadCuentaAhorroAFP = CType(_util.buscaID_(Comun.Tablas.RH_PER_TIPO_UNIDAD, "TIPO_UNIDAD_ALIAS", "TIPO_UNIDAD_ID", CType(CType(dr("MONEDA_AHORRO_AFP_ID"), Byte), String), "TIPO_UNIDAD_ALIAS"), String)
            Me.datosPrevisionales.montoCotizacionVoluntaria = CType(dr("MONTO_COTIZACION_VOLUNTARIA_AFP"), Decimal)
            Me.datosPrevisionales.unidadCotizacionVoluntaria = CType(_util.buscaID_(Comun.Tablas.RH_PER_TIPO_UNIDAD, "TIPO_UNIDAD_ALIAS", "TIPO_UNIDAD_ID", CType(CType(dr("MONEDA_COTIZ_VOLUN_AFP_ID"), Byte), String), "TIPO_UNIDAD_ALIAS"), String)
            Me.datosPrevisionales.unidadCotizacionVoluntariaId = CType(dr("MONEDA_COTIZ_VOLUN_AFP_ID"), Byte)
            Me.datosPrevisionales.fondoPensionA = CType(dr("FONDO_A"), Boolean)
            Me.datosPrevisionales.fondoPensionB = CType(dr("FONDO_B"), Boolean)
            Me.datosPrevisionales.fondoPensionC = CType(dr("FONDO_C"), Boolean)
            Me.datosPrevisionales.fondoPensionD = CType(dr("FONDO_D"), Boolean)
            Me.datosPrevisionales.fondoPensionE = CType(dr("FONDO_E"), Boolean)
            Me.datosPrevisionales.periodoID = CType(dr("PERIODO_ID"), Integer)
            Me.datosPrevisionales.tipoTrabajadorPrevidredID = CType(dr("TIPO_TRABAJADOR_PREVIRED_ID"), Byte)
            Me.datosPrevisionales.afpNroFun = If(IsDBNull(dr("AFP_NRO_FUN")), String.Empty, CType(dr("AFP_NRO_FUN"), String))
            Me.datosPrevisionales.afpFechaFun = If(IsDBNull(dr("AFP_FECHA_FUN")), Nothing, CType(dr("AFP_FECHA_FUN"), Date))
            Me.datosSalud.institucionID = CType(dr("ISAPRE_ID"), Integer)
            Me.datosSalud.institucion = CType(_util.buscaID_(Comun.Tablas.RH_REM_ISAPRE, "NA", "ISAPRE_ID", CType(CType(dr("ISAPRE_ID"), Integer), String), "DESCRIPCION"), String)
            Me.datosSalud.fechaAfiliacion = CType(dr("FECHA_AFILIACION_ISAPRE"), Date)
            Me.datosSalud.montoConvenio = CType(dr("MONTO_ISAPRE"), Decimal)
            Me.datosSalud.unidadConvenio = CType(_util.buscaID_(Comun.Tablas.RH_PER_TIPO_UNIDAD, "TIPO_UNIDAD_ALIAS", "TIPO_UNIDAD_ID", CType(CType(dr("MONEDA_MONTO_ISAPRE_ID"), Byte), String), "TIPO_UNIDAD_ALIAS"), String)
            Me.datosSalud.unidadConvenioId = CType(dr("MONEDA_MONTO_ISAPRE_ID"), Byte)
            Me.datosSalud.montoPlanComplementario = CType(dr("PLAN_COMPLEM_ISAPRE"), Decimal)
            Me.datosSalud.unidadPlanComplementario = CType(_util.buscaID_(Comun.Tablas.RH_PER_TIPO_UNIDAD, "TIPO_UNIDAD_ALIAS", "TIPO_UNIDAD_ID", CType(CType(dr("MONEDA_PLAN_COMPLEM_ISAPRE_ID"), Byte), String), "TIPO_UNIDAD_ALIAS"), String)
            Me.datosSalud.unidadPlanComplementarioId = CType(dr("MONEDA_PLAN_COMPLEM_ISAPRE_ID"), Byte)
            Me.datosSalud.saludprais = "N"
            Me.datosSalud.montoplanAuge = CType(dr("MONTO_PLAN_AUGE"), Decimal)
            Me.datosSalud.unidadPlanAuge = CType(_util.buscaID_(Comun.Tablas.RH_PER_TIPO_UNIDAD, "TIPO_UNIDAD_ALIAS", "TIPO_UNIDAD_ID", CType(CType(dr("MONEDA_PLAN_AUGE_ID"), Byte), String), "TIPO_UNIDAD_ALIAS"), String)
            Me.datosSalud.unidadPlanAugeId = CType(dr("MONEDA_PLAN_AUGE_ID"), Byte)
            Me.datosSalud.periodoID = CType(dr("PERIODO_ID"), Byte)
            Me.datosSalud.isapreNroFun = If(IsDBNull(dr("ISAPRE_NRO_FUN")), String.Empty, CType(dr("ISAPRE_NRO_FUN"), String))
            Me.datosSalud.isapreFechaFun = If(IsDBNull(dr("ISAPRE_FECHA_FUN")), Nothing, CType(dr("ISAPRE_FECHA_FUN"), Date))
        End If
    End Sub
    Public Sub asignacionCampos(ByVal dr As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_HONORARIO_DETALLERow)
        If Not dr Is Nothing Then
            Me.datosPresupuestoHonorario.antecedenteHonorarioDetalleId = CType(dr("ANTECEDENTE_HONORARIO_DETALLE_ID"), Integer)
            Me.datosPresupuestoHonorario.empleadoId = CType(dr("EMPLEADO_ID"), Integer)
            Me.datosPresupuestoHonorario.estadoRegistro = CType(dr("ESTADO_REGISTRO"), Integer)
            Me.datosPresupuestoHonorario.año = CType(dr("AÑO"), Integer)
            Me.datosPresupuestoHonorario.montoEnero = CType(dr("MONTO_ENERO"), Integer)
            Me.datosPresupuestoHonorario.montoFebrero = CType(dr("MONTO_FEBRERO"), Integer)
            Me.datosPresupuestoHonorario.montoMarzo = CType(dr("MONTO_MARZO"), Integer)
            Me.datosPresupuestoHonorario.montoAbril = CType(dr("MONTO_ABRIL"), Integer)
            Me.datosPresupuestoHonorario.montoMayo = CType(dr("MONTO_MAYO"), Integer)
            Me.datosPresupuestoHonorario.montoJunio = CType(dr("MONTO_JUNIO"), Integer)
            Me.datosPresupuestoHonorario.montoJulio = CType(dr("MONTO_JULIO"), Integer)
            Me.datosPresupuestoHonorario.montoAgosto = CType(dr("MONTO_AGOSTO"), Integer)
            Me.datosPresupuestoHonorario.montoSeptiembre = CType(dr("MONTO_SEPTIEMBRE"), Integer)
            Me.datosPresupuestoHonorario.montoOctubre = CType(dr("MONTO_OCTUBRE"), Integer)
            Me.datosPresupuestoHonorario.montoNoviembre = CType(dr("MONTO_NOVIEMBRE"), Integer)
            Me.datosPresupuestoHonorario.montoDiciembre = CType(dr("MONTO_DICIEMBRE"), Integer)
            Me.datosPresupuestoHonorario.periodoId = CType(dr("PERIODO_ID"), Integer)
            Me.datosPresupuestoHonorario.fechaContratoDesde = CType(dr("FECHA_CONTRATO_DESDE"), Date)
            Me.datosPresupuestoHonorario.fechaContratoHasta = CType(dr("FECHA_CONTRATO_HASTA"), Date)
            Me.datosPresupuestoHonorario.nroResolucion = CType(dr("NRO_SOLUCION"), String)
            Me.datosPresupuestoHonorario.fechaResolucion = CType(dr("FECHA_RESOLUCION"), Date)
            Me.datosPresupuestoHonorario.observacion = CType(dr("OBSERVACION"), String)
            Me.datosPresupuestoHonorario.montoVigente = CType(dr("MONTO_VIGENTE"), Integer)
            Me.datosPresupuestoHonorario.esRetiroEmpleado = CType(dr("ES_RETIRO_EMPLEADO"), Boolean)
            Me.datosPresupuestoHonorario.motivoRetiroId = CType(dr("MOTIVO_RETIRO_ID"), Integer)
        End If
    End Sub
    Public Sub asignacionCampos(ByVal dr As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_REMUNRow)
        If Not dr Is Nothing Then
            Me.datosRemuneracion.antecedenteRemunID = CType(dr("ANTECEDENTE_REMUN_ID"), Integer)
            Me.datosRemuneracion.estadoRegistroRemun = CType(dr("ESTADO_REGISTRO"), Byte)
            Me.datosRemuneracion.asociacionGremialID = CType(dr("ASOCIACION_GREMIAL_ID"), Byte)
            Me.datosRemuneracion.asociacionGremial = CType(_util.buscaID_(Comun.Tablas.RH_PER_ASOCIACION_GREMIAL, "NA", "ASOCIACION_GREMIAL_ID", CType(CType(dr("ASOCIACION_GREMIAL_ID"), Integer), String), "DESCRIPCION"), String)
            Me.datosRemuneracion.fechaAfiliacionGremial = CType(dr("FECHA_ING_ASOC_GREMIAL"), Date)
            Me.datosRemuneracion.afiliadoBienestar = CType(dr("FONDO_BIENESTAR"), Boolean)
            Me.datosRemuneracion.fechaAfiliacionBienestar = CType(dr("FECHA_ING_FONDO_BIENESTAR"), Date)
            Me.datosRemuneracion.formaPago = CType(dr("FORMA_PAGO"), Byte)
            Me.datosRemuneracion.bancoID = CType(dr("BANCO_ID"), Byte)
            Me.datosRemuneracion.banco = CType(_util.buscaID_(Comun.Tablas.RH_PER_BANCO, "NA", "BANCO_ID", CType(CType(dr("BANCO_ID"), Integer), String), "DESCRIPCION"), String)
            Me.datosRemuneracion.tipoCuentaDestinoID = CType(dr("TIPO_CUENTA_BANCO_ID"), Byte)
            Me.datosRemuneracion.tipoCuentaDestino = CType(_util.buscaID_(Comun.Tablas.RH_PER_TIPO_CUENTA_BANCO, "NA", "TIPO_CUENTA_BANCO_ID", CType(CType(dr("TIPO_CUENTA_BANCO_ID"), Integer), String), "DESCRIPCION"), String)
            Me.datosRemuneracion.numeroCuenta = CType(dr("NRO_CUENTA_BANCO"), String)
            Me.datosRemuneracion.asignacionProfesional = CType(dr("ASIGNACION_PROFESIONAL"), Boolean)
            Me.datosRemuneracion.aplicaLey3551 = CType(dr("APLICA_LEY_3551"), Boolean)
            Me.datosRemuneracion.rentaBase = CType(dr("RENTA_BASE"), Integer)
            Me.datosRemuneracion.numeroBienios = CType(dr("NUMERO_BIENIOS"), Byte)
            Me.datosRemuneracion.fechaCumplioBienios = CType(dr("FECHA_CUMPLIO_BIENIOS"), Date)
            Me.datosRemuneracion.tramoAsignacionFamiliarID = CType(dr("TRAMO_ASIGNACION_FAMILIAR_ID"), Byte)
            Me.datosRemuneracion.tramoAsignacionFamiliar = CType(_util.buscaID_(Comun.Tablas.RH_REM_TRAMO_ASIGNACION_FAMILIAR, "NA", "TRAMO_ASIGNACION_FAMILIAR_ID", CType(CType(dr("TRAMO_ASIGNACION_FAMILIAR_ID"), Integer), String), "DESCRIPCION"), String)
            Me.datosRemuneracion.cargaFamiliarNormal = CType(dr("CARGAS_FAM_NORMALES"), Byte)
            Me.datosRemuneracion.cargaFamiliarInvalida = CType(dr("CARGAS_FAM_INVALIDAS"), Byte)
            Me.datosRemuneracion.cargaFamiliarPrenatal = CType(dr("CARGAS_FAM_PRENATAL"), Byte)
            Me.datosRemuneracion.sueldoBase = CType(dr("MONTO_SUELDO_BASE"), Integer)
            Me.datosRemuneracion.numeroBienios = CType(dr("NUMERO_BIENIOS"), Byte)
            Me.datosRemuneracion.valorAsignacionProfesional = CType(dr("MONTO_ASIGNACION_PROFESIONAL"), Integer)
            Me.datosRemuneracion.valorAsignacionResposabilidad = CType(dr("MONTO_ASIGNACION_RESPONSABILIDAD_SUPERIOR"), Integer)
            Me.datosRemuneracion.valorAsignacionLey19185Art18 = CType(dr("MONTO_ASIGNACION_LEY19185_ART18"), Integer)
            Me.datosRemuneracion.clasificacionINE = CType(dr("CLASIFICACION_INE"), Byte)
            Me.datosRemuneracion.ultimoPeriodoLiquidacion = CType(dr("ULTIMO_PERIODO_REMUNERACION"), String)
            Me.datosRemuneracion.asignaGastoRepresentacion = CType(dr("GASTO_REPRESENTACION"), Boolean)
            Me.datosRemuneracion.valorGastoRepresentacion = CType(dr("MONTO_GASTO_REPRESENTACION"), Integer)
            Me.datosRemuneracion.valorFuncionCritica = CType(dr("MONTO_FUNCION_CRITICA"), Integer)
            Me.datosRemuneracion.valorAsignacionLey18717 = CType(dr("MONTO_ASIGNACION_LEY18717"), Integer)
            Me.datosRemuneracion.valorAsignacionLey18675Art10 = CType(dr("MONTO_LEY18675_ART10"), Integer)
            Me.datosRemuneracion.valorAsignacionLey18675Art11 = CType(dr("MONTO_LEY18675_ART11"), Integer)
            Me.datosRemuneracion.valorAsignacionLey18566 = CType(dr("MONTO_LEY18566"), Integer)
            Me.datosRemuneracion.valorLey3551 = CType(dr("MONTO_ASIGNACION_LEY_3551"), Integer)
            Me.datosRemuneracion.valorIncrementoPrevisionalDL3501 = CType(dr("MONTO_INCREMENTO_PREVIS_DL3501"), Integer)
            Me.datosRemuneracion.periodo = CType(dr("PERIODO_ID"), Integer)
            Try
                Me.datosRemuneracion.anno = CType(dr("ANO"), String)
            Catch ex As Exception
                Me.datosRemuneracion.anno = "0"
            End Try
            Me.datosRemuneracion.porcentajeLey19863 = CType(dr("PORCENTAJE_LEY19863"), Short)
            Try
                Me.datosRemuneracion.entregoBoletaHonorario = CType(dr("ENTREGO_BOLETA_HONORARIO"), Boolean)
            Catch ex As Exception
                Me.datosRemuneracion.entregoBoletaHonorario = False
            End Try
            Try
                Me.datosRemuneracion.autorizaPagoBienio = CType(dr("AUTORIZA_PAGO_BIENIO"), Boolean)
            Catch ex As Exception
                Me.datosRemuneracion.autorizaPagoBienio = False
            End Try
            Try
                Me.datosRemuneracion.observacionAutorizaPago = CType(dr("OBSERVACION_AUTORIZA"), String)
            Catch ex As Exception
                Me.datosRemuneracion.observacionAutorizaPago = ""
            End Try
            Try
                Me.datosRemuneracion.enviarHaciaDexon = CType(dr("ENVIA_HACIA_DEXON"), Boolean)
            Catch ex As Exception
                Me.datosRemuneracion.enviarHaciaDexon = False
            End Try
            Try
                Me.datosRemuneracion.numeroCompromisoDexon = CType(dr("NUMERO_TICKET_DEXON"), Integer)
            Catch ex As Exception
                Me.datosRemuneracion.numeroCompromisoDexon = 0
            End Try

            'AGREGADO SEGEGOB
            Try
                Me.datosRemuneracion.montoAsignacionProfesional = CType(dr("MONTO_ASIGNACION_PROFESIONAL"), Integer)
            Catch ex As Exception
                Me.datosRemuneracion.montoAsignacionProfesional = 0
            End Try

            Try
                Me.datosRemuneracion.zonaID = CType(dr("ZONA_ID"), Integer)
            Catch ex As Exception
                Me.datosRemuneracion.zonaID = 0
            End Try

            Try
                Me.datosRemuneracion.AsignaLey18675Art11 = CType(dr("ASIGNA_LEY18675_ART11"), Boolean)
            Catch ex As Exception
                Me.datosRemuneracion.AsignaLey18675Art11 = False
            End Try

        End If
    End Sub
    Public Sub asignacionCampos(ByVal dr As DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_ORGANICARow)
        If Not dr Is Nothing Then
            Me.datosEstructuraOrganica.estructuraOrganicaId = CType(dr("ESTRUCTURA_ORGANICA_ID"), Integer)
            Me.datosEstructuraOrganica.estadoRegistro = CType(dr("ESTADO_REGISTRO"), Integer)
            Me.datosEstructuraOrganica.empleadoID = CType(dr("EMPLEADO_ID"), Integer)
            Me.datosEstructuraOrganica.organizacionID = CType(dr("ORGANIZACION_ID"), Integer)
            Me.datosEstructuraOrganica.direccionID = CType(dr("DIRECCION_ID"), Integer)
            Me.datosEstructuraOrganica.deptoID = CType(dr("DEPTO_ID"), Integer)
            Me.datosEstructuraOrganica.periodoID = CType(dr("PERIODO_ID"), Integer)
            Try
                Me.datosEstructuraOrganica.autorizadorHorasExtrasID = CType(dr("AUTORIZADOR_HORAS_EXTRAS_ID"), Integer)
            Catch ex As Exception
                Me.datosEstructuraOrganica.autorizadorHorasExtrasID = -1
            End Try
            Try
                Me.datosEstructuraOrganica.evaluadorDesempenoID = CType(dr("EVALUADOR_DESEMPENO_ID"), Integer)
            Catch ex As Exception
                Me.datosEstructuraOrganica.evaluadorDesempenoID = -1
            End Try
            Me.datosEstructuraOrganica.subDeptoId = CType(dr("SUB_DEPTO_ID"), Integer)
        End If
    End Sub
    Public Sub asignacionCampos(ByVal dr As DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_CONTABLERow)
        If Not dr Is Nothing Then
            Me.datosEstructuraContable.estructuraContableId = CType(dr("ESTRUCTURA_CONTABLE_ID"), Integer)
            Me.datosEstructuraContable.estadoRegistro = CType(dr("ESTADO_REGISTRO"), Integer)
            Me.datosEstructuraContable.empleadoID = CType(dr("EMPLEADO_ID"), Integer)
            Me.datosEstructuraContable.centroCostoContab = CType(dr("CENTRO_COSTO_CONTAB_ID"), Integer)
            Me.datosEstructuraContable.centroCostoPresup = CType(dr("CENTRO_COSTO_PRESUP_ID"), Integer)
            Me.datosEstructuraContable.procentajeDistribucion = CType(dr("PORCENTAJE_DISTRIB"), Integer)
            Me.datosEstructuraOrganica.periodoID = CType(dr("PERIODO_ID"), Integer)
        End If
    End Sub

    Public Sub asignacionCampos(ByVal dr As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_CURRIRow)
        If Not dr Is Nothing Then
            Me.datosCurriculumLaboral.antecedenteCuirricularLaboralId = CType(dr("ANTECEDENTE_CURRI_ID"), Integer)
            Me.datosCurriculumLaboral.empleadoId = CType(dr("EMPLEADO_ID"), Integer)
            Me.datosCurriculumLaboral.estadoRegistro = CType(dr("ESTADO_REGISTRO"), Integer)
            Me.datosCurriculumLaboral.prefesionId = CType(dr("PROFESION_OFICIO_ID"), Integer)
            Me.datosCurriculumLaboral.otrosEstudios = CType(dr("OTROS_ESTUDIOS"), String)
            Me.datosCurriculumLaboral.experienciaLaboral = CType(dr("EXPERIENCIA_LABORAL"), String)
        End If
    End Sub

    Public Sub asignacionCampos(ByVal dv As DataView)
        If Not dv Is Nothing Then
            Dim dc As DatoAPV
            Dim i As Integer
            For i = 0 To dv.Count - 1
                dc = New DatoAPV
                dc.tipoAhorroVoluntario = CType(dv.Table.Rows(i).Item("ESTADO_REGISTRO"), Integer)
                dc.empleadoID = CType(dv.Table.Rows(i).Item("EMPLEADO_ID"), Integer)
                dc.tipoAhorroVoluntario = CType(dv.Table.Rows(i).Item("TIPO_AHORRO_PREVISIONAL"), Integer)
                dc.institucionID = CType(dv.Table.Rows(i).Item("APV_ID"), Integer)
                dc.montoAhorroVoluntario = CType(dv.Table.Rows(i).Item("MONTO_AHORRO"), Decimal)
                dc.uniddadAhorroVoluntario = CType(dv.Table.Rows(i).Item("MONEDA_AHORRO_APV_ID"), Integer)
            Next
        End If
    End Sub

    Private Sub asignacionCampos(ByVal dr As DataAccess.DSEmpleado.RH_PER_EMPLEADORow)

        If Not dr Is Nothing Then
            Me.organizacion = CType(dr("ORGANIZACION_ID"), Byte)
            Me.rut.dv = CType(dr("DV"), String)
            Me.rut.rut = CType(dr("RUT"), Integer)
            Me.nombres = CType(dr("NOMBRES"), String)
            Me.apellidoPaterno = CType(dr("APELLIDO_PATERNO"), String)
            Me.apellidoMaterno = CType(dr("APELLIDO_MATERNO"), String)
            Me.fechaNacimiento = CType(dr("FECHA_NACIMIENTO"), Date)
            Me.estadoCivil = CType(dr("ESTADO_CIVIL_ID"), TipoEstadoCivil)
            Me.estadoEmpleadoID = CType(dr("ESTADO_EMPLEADO_ID"), Byte)
            If CType(dr("SEXO"), String) = "F" Then
                Me.sexo = Persona.ESexo.FEMENINO
            Else
                Me.sexo = Persona.ESexo.MASCULINO
            End If
            Me.direccion.calle = CType(dr("CALLE_AVDA"), String)
            Me.direccion.numero = CType(dr("NUMERO_DIRECCION"), String)
            Me.direccion.villaPoblacion = CType(dr("VILLA_POBLACION"), String)

            Me.direccion.pais = CType(_util.buscaID_(Comun.Tablas.GEN_PAIS, "DESCRIPCION", "PAIS_ID", CType(CType(dr("PAIS_ID"), Byte), String), "DESCRIPCION"), String)
            Me.direccion.region = CType(_util.buscaID_(Comun.Tablas.GEN_REGION, "DESCRIPCION", "REGION_ID", CType(CType(dr("REGION_ID"), Integer), String), "DESCRIPCION"), String)
            Me.direccion.comuna = CType(_util.buscaID_(Comun.Tablas.GEN_COMUNA, "DESCRIPCION", "COMUNA_ID", CType(CType(dr("COMUNA_ID"), Integer), String), "DESCRIPCION"), String)
            Me.direccion.ciudad = CType(_util.buscaID_(Comun.Tablas.GEN_CIUDAD, "DESCRIPCION", "CIUDAD_ID", CType(CType(dr("CIUDAD_ID"), Integer), String), "DESCRIPCION"), String)
            Me.setEstado(CType(dr("ESTADO_EMPLEADO_ID"), TipoEstado))
            Try
                Me.celular = CType(dr("CELULAR"), String)
            Catch invalidcastE As System.InvalidCastException
                Me.celular = ""
            End Try
            Try
                Me.direccion.codigoPostal = CType(dr("CODIGO_POSTAL"), String)
            Catch invalidcastE As System.InvalidCastException
                Me.direccion.codigoPostal = ""
            End Try
            Try
                Me.telefono = CType(dr("TELEFONO_PARTICULAR"), String)
            Catch invalidcastE As System.InvalidCastException
                Me.telefono = ""
            End Try
            Try
                Me.nivelEducacional = CType(dr("NIVEL_ESTUDIO_ID"), Integer)
            Catch invalidcastE As System.InvalidCastException
                Me.nivelEducacional = 1
            End Try

            Try
                Me.FonoAnexo = CType(dr("ANEXO_TELEFONO_OFI"), String)
            Catch invalidcastE As System.InvalidCastException
                Me.FonoAnexo = ""
            End Try
            Try
                Me.ContactoEmergencia = CType(dr("CONTACTO_EMERGENCIA"), String)
            Catch invalidcastE As System.InvalidCastException
                Me.ContactoEmergencia = ""
            End Try
            Try
                Me.servicioMilitar = CType(dr("SITUACION_MILITAR"), String)
            Catch invalidcastE As System.InvalidCastException
                Me.servicioMilitar = ""
            End Try
            Try
                Me.matriculaMilitar = CType(dr("NRO_MATRICULA_MILITAR"), String)
            Catch invalidcastE As System.InvalidCastException
                Me.matriculaMilitar = ""
            End Try
            Try
                Me.grupoSanguineo = CType(dr("GRUPO_SANGUINEO"), String)
            Catch invalidcastE As System.InvalidCastException
                Me.grupoSanguineo = ""
            End Try
            Try
                Me.alergias = CType(dr("ALERGICO"), String)
            Catch invalidcastE As System.InvalidCastException
                Me.alergias = ""
            End Try
            Try
                Me.enfermedadCronica = CType(dr("SUFRE_ENFERMEDAD"), String)
            Catch invalidcastE As System.InvalidCastException
                Me.enfermedadCronica = ""
            End Try
            Try
                Me.medicamentosContraindicados = CType(dr("MEDICAMENTOS"), String)
            Catch invalidcastE As System.InvalidCastException
                Me.medicamentosContraindicados = ""
            End Try
            Try
                Me.email = CType(dr("EMAIL"), String)
            Catch invalidcastE As System.InvalidCastException
                Me.email = ""
            End Try
        End If

    End Sub

    Private Sub asignacionCampos(ByVal empleado As BusinessRules.Empleado, ByRef empleadoDR As DataAccess.DSEmpleado.RH_PER_EMPLEADORow)

        With empleadoDR
            .ORGANIZACION_ID = CType(empleado.organizacion, Byte)
            .ESTADO_EMPLEADO_ID = CType(empleado.estadoEmpleadoID, Byte)
            .RUT = empleado.rut.rut
            .DV = empleado.rut.dv
            .NOMBRES = empleado.nombres
            .APELLIDO_PATERNO = empleado.apellidoPaterno
            .APELLIDO_MATERNO = empleado.apellidoMaterno
            .FECHA_NACIMIENTO = empleado.fechaNacimiento
            .ESTADO_CIVIL_ID = CType(empleado.estadoCivil, Byte)
            If empleado.sexo = Persona.ESexo.FEMENINO Then
                .SEXO = "F"
            Else
                .SEXO = "M"
            End If
            .NIVEL_ESTUDIO_ID = empleado.nivelEducacional
            .VILLA_POBLACION = empleado.direccion.villaPoblacion
            .NUMERO_DIRECCION = empleado.direccion.numero
            .CALLE_AVDA = empleado.direccion.calle
            .CODIGO_POSTAL = empleado.direccion.codigoPostal

            .PAIS_ID = CType(empleado.buscaInteger("SELECT PAIS_ID FROM GEN_PAIS WHERE DESCRIPCION=" & "'" & empleado.direccion.pais & "'"), Short)
            .REGION_ID = CType(empleado.buscaInteger("SELECT REGION_ID FROM GEN_REGION WHERE DESCRIPCION=" & "'" & empleado.direccion.region & "'"), Short)
            .COMUNA_ID = CType(empleado.buscaInteger("SELECT COMUNA_ID FROM GEN_COMUNA WHERE DESCRIPCION=" & "'" & empleado.direccion.comuna & "'"), Short)
            .CIUDAD_ID = CType(empleado.buscaInteger("SELECT CIUDAD_ID FROM GEN_CIUDAD WHERE DESCRIPCION=" & "'" & empleado.direccion.ciudad & "'"), Short)

            .TELEFONO_PARTICULAR = empleado.telefono
            .CELULAR = empleado.celular

            .ANEXO_TELEFONO_OFI = empleado.FonoAnexo
            .CONTACTO_EMERGENCIA = empleado.ContactoEmergencia
            .SITUACION_MILITAR = empleado.servicioMilitar
            .NRO_MATRICULA_MILITAR = empleado.matriculaMilitar
            .GRUPO_SANGUINEO = empleado.grupoSanguineo
            .ALERGICO = empleado.alergias
            .SUFRE_ENFERMEDAD = empleado.enfermedadCronica
            .MEDICAMENTOS = empleado.medicamentosContraindicados
            .EMAIL = empleado.email
        End With
    End Sub
    Private Sub asignacionCampos(ByVal empleado As BusinessRules.Empleado, ByRef empleadoPrevisDR As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_PREVISRow)
        With empleadoPrevisDR
            .EMPLEADO_ID = CType(empleado.ID, Short)
            .ESTADO_REGISTRO = CType(empleado.datosPrevisionales.varEstadoRegistro, Byte)
            .FECHA_ING_SISTEMA_PREVIS = CType(empleado.datosPrevisionales.fechaIngresoSistemaPrevisional, Date)
            .AFP_ID = CType(empleado.datosPrevisionales.institucionID, Byte)
            .FECHA_AFILIACION_AFP = CType(empleado.datosPrevisionales.fechaAfiliacion, Date)
            .MONTO_AHORRO_AFP = CType(empleado.datosPrevisionales.montoCuentaAhorroAFP, Decimal)
            .MONEDA_AHORRO_AFP_ID = CType(empleado.datosPrevisionales.unidadCuentaAhorroAFPId, Byte)
            .MONTO_COTIZACION_VOLUNTARIA_AFP = CType(empleado.datosPrevisionales.montoCotizacionVoluntaria, Decimal)
            .MONEDA_COTIZ_VOLUN_AFP_ID = CType(empleado.datosPrevisionales.unidadCotizacionVoluntariaId, Byte)
            .ISAPRE_ID = CType(empleado.datosSalud.institucionID, Byte)
            .FECHA_AFILIACION_ISAPRE = CType(empleado.datosSalud.fechaAfiliacion, Date)
            .MONTO_ISAPRE = CType(empleado.datosSalud.montoConvenio, Decimal)
            .MONEDA_MONTO_ISAPRE_ID = CType(empleado.datosSalud.unidadConvenioId, Byte)
            .PLAN_COMPLEM_ISAPRE = CType(empleado.datosSalud.montoPlanComplementario, Decimal)
            .MONEDA_PLAN_COMPLEM_ISAPRE_ID = CType(empleado.datosSalud.unidadPlanComplementarioId, Byte)
            .SALUD_PRAIS = "N"
            .FONDO_A = empleado.datosPrevisionales.fondoPensionA
            .FONDO_B = empleado.datosPrevisionales.fondoPensionB
            .FONDO_C = empleado.datosPrevisionales.fondoPensionC
            .FONDO_D = empleado.datosPrevisionales.fondoPensionD
            .FONDO_E = empleado.datosPrevisionales.fondoPensionE
            .MONTO_PLAN_AUGE = CType(empleado.datosSalud.montoplanAuge, Decimal)
            .MONEDA_PLAN_AUGE_ID = CType(empleado.datosSalud.unidadPlanAugeId, Byte)
            .PERIODO_ID = CType(empleado.datosPrevisionales.periodoID, Byte)
            .TIPO_TRABAJADOR_PREVIRED_ID = CType(empleado.datosPrevisionales.tipoTrabajadorPrevidredID, Byte)
            .AFP_NRO_FUN = CType(empleado.datosPrevisionales.afpNroFun, String)
            .AFP_FECHA_FUN = CType(empleado.datosPrevisionales.afpFechaFun, Date)
            .ISAPRE_NRO_FUN = CType(empleado.datosSalud.isapreNroFun, String)
            .ISAPRE_FECHA_FUN = CType(empleado.datosSalud.isapreFechaFun, Date)
        End With
    End Sub

    Private Sub asignacionCampos(ByVal empleado As BusinessRules.Empleado, ByVal dr As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_HONORARIO_DETALLERow)
        With dr
            .EMPLEADO_ID = CType(empleado.datosPresupuestoHonorario.empleadoId, Integer)
            .ESTADO_REGISTRO = CType(empleado.datosPresupuestoHonorario.estadoRegistro, Integer)
            .AÑO = CType(empleado.datosPresupuestoHonorario.año, Integer)
            .MONTO_ENERO = CType(empleado.datosPresupuestoHonorario.montoEnero, Integer)
            .MONTO_FEBRERO = CType(empleado.datosPresupuestoHonorario.montoFebrero, Integer)
            .MONTO_MARZO = CType(empleado.datosPresupuestoHonorario.montoMarzo, Integer)
            .MONTO_ABRIL = CType(empleado.datosPresupuestoHonorario.montoAbril, Integer)
            .MONTO_MAYO = CType(empleado.datosPresupuestoHonorario.montoMayo, Integer)
            .MONTO_JUNIO = CType(empleado.datosPresupuestoHonorario.montoJunio, Integer)
            .MONTO_JULIO = CType(empleado.datosPresupuestoHonorario.montoJulio, Integer)
            .MONTO_AGOSTO = CType(empleado.datosPresupuestoHonorario.montoAgosto, Integer)
            .MONTO_SEPTIEMBRE = CType(empleado.datosPresupuestoHonorario.montoSeptiembre, Integer)
            .MONTO_OCTUBRE = CType(empleado.datosPresupuestoHonorario.montoOctubre, Integer)
            .MONTO_NOVIEMBRE = CType(empleado.datosPresupuestoHonorario.montoNoviembre, Integer)
            .MONTO_DICIEMBRE = CType(empleado.datosPresupuestoHonorario.montoDiciembre, Integer)
            .PERIODO_ID = CType(empleado.datosPresupuestoHonorario.periodoId, Integer)
            .FECHA_CONTRATO_DESDE = CType(empleado.datosPresupuestoHonorario.fechaContratoDesde, Date)
            .FECHA_CONTRATO_HASTA = CType(empleado.datosPresupuestoHonorario.fechaContratoHasta, Date)
            .NRO_SOLUCION = CType(empleado.datosPresupuestoHonorario.nroResolucion, String)
            .FECHA_RESOLUCION = CType(empleado.datosPresupuestoHonorario.fechaResolucion, Date)
            .OBSERVACION = CType(empleado.datosPresupuestoHonorario.observacion, String)
            .MONTO_VIGENTE = CType(empleado.datosPresupuestoHonorario.montoVigente, Integer)
            .ES_RETIRO_EMPLEADO = CType(empleado.datosPresupuestoHonorario.esRetiroEmpleado, Boolean)
            .MOTIVO_RETIRO_ID = CType(empleado.datosPresupuestoHonorario.motivoRetiroId, Integer)
        End With
    End Sub

    Private Sub asignacionCampos(ByVal empleado As BusinessRules.Empleado, ByVal dr As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_CURRIRow)
        With dr
            .EMPLEADO_ID = CType(empleado.datosCurriculumLaboral.empleadoId, Short)
            .ESTADO_REGISTRO = CType(empleado.datosCurriculumLaboral.estadoRegistro, Integer)
            .PROFESION_OFICIO_ID = CType(empleado.datosCurriculumLaboral.prefesionId, Integer)
            .OTROS_ESTUDIOS = CType(empleado.datosCurriculumLaboral.otrosEstudios, String)
            .EXPERIENCIA_LABORAL = CType(empleado.datosCurriculumLaboral.experienciaLaboral, String)
        End With
    End Sub
    Private Sub asignacionCampos(ByVal empleado As BusinessRules.Empleado, ByRef empleadoEventoAdminDR As DataAccess.DSEmpleado.RH_PER_EVENTO_ADMINRow)
        With empleadoEventoAdminDR
            .TIPO_EVENTO_ADMIN_ID = CType(empleado.datosEventoAdmin.Tipo_Evento_Admin_ID, Byte)
            .EMPLEADO_ID = CType(empleado.ID, Short)
            .FECHA_DIGITACION = CType(empleado.datosEventoAdmin.Fecha_Digitacion, Date)
            .ESTADO_EVENTO_ADMIN_ID = CType(empleado.datosEventoAdmin.Estado_Evento_Administrativo_ID, Byte)
            .DIAS_SOLICITADOS = CType(empleado.datosEventoAdmin.Dias_Solicitados, Decimal)
            .MOTIVO_SOLICITUD = CType(empleado.datosEventoAdmin.Motivo_Solicitud, String)
            .ANO = CType(empleado.datosEventoAdmin.Año, Short)
            .PERIODO_ID = CType(empleado.datosEventoAdmin.periodoId, Short)
        End With
    End Sub

    Private Sub asignacionCampos(ByVal empleado As BusinessRules.Empleado, ByRef empleadoApvDR As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_APVRow)
        With empleadoApvDR
            .ESTADO_REGISTRO = CType(empleado.datosAPV.estadoregistro, Byte)
            .EMPLEADO_ID = CType(empleado.ID, Short)
            .TIPO_AHORRO_PREVISIONAL = CType(empleado.datosAPV.tipoAPV, Byte)
            .APV_ID = CType(empleado.datosAPV.institucionAPVID, Byte)
            .MONTO_AHORRO = CType(empleado.datosAPV.montoCuentaAhorroAPV, Decimal)
            .MONEDA_AHORRO_APV_ID = CType(empleado.datosAPV.unidadCuentaAhorroAPVId, Byte)
            .PERIODO_ID = CType(empleado.datosAPV.periodoID, Byte)
        End With
    End Sub

    Private Sub asignacionCampos(ByVal empleado As BusinessRules.Empleado, ByRef empleadoRemunDR As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_REMUNRow)
        With empleadoRemunDR
            .ESTADO_REGISTRO = CType(empleado.datosRemuneracion.estadoRegistroRemun, Byte)
            .EMPLEADO_ID = CType(empleado.ID, Short)
            .FONDO_BIENESTAR = empleado.datosRemuneracion.afiliadoBienestar
            .FECHA_ING_FONDO_BIENESTAR = empleado.datosRemuneracion.fechaAfiliacionBienestar
            .ASOCIACION_GREMIAL_ID = empleado.datosRemuneracion.asociacionGremialID
            .FECHA_ING_ASOC_GREMIAL = empleado.datosRemuneracion.fechaAfiliacionGremial
            .FORMA_PAGO = empleado.datosRemuneracion.formaPago
            .TIPO_CUENTA_BANCO_ID = empleado.datosRemuneracion.tipoCuentaDestinoID
            .NRO_CUENTA_BANCO = empleado.datosRemuneracion.numeroCuenta
            .BANCO_ID = empleado.datosRemuneracion.bancoID
            .ASIGNACION_PROFESIONAL = empleado.datosRemuneracion.asignacionProfesional
            .APLICA_LEY_3551 = empleado.datosRemuneracion.aplicaLey3551
            .RENTA_BASE = empleado.datosRemuneracion.rentaBase
            .NUMERO_BIENIOS = empleado.datosRemuneracion.numeroBienios
            .FECHA_CUMPLIO_BIENIOS = empleado.datosRemuneracion.fechaCumplioBienios
            .TRAMO_ASIGNACION_FAMILIAR_ID = empleado.datosRemuneracion.tramoAsignacionFamiliarID
            .CARGAS_FAM_NORMALES = empleado.datosRemuneracion.cargaFamiliarNormal
            .CARGAS_FAM_INVALIDAS = empleado.datosRemuneracion.cargaFamiliarInvalida
            .CARGAS_FAM_PRENATAL = empleado.datosRemuneracion.cargaFamiliarPrenatal
            .MONTO_SUELDO_BASE = empleado.datosRemuneracion.sueldoBase
            .MONTO_ASIGNACION_PROFESIONAL = empleado.datosRemuneracion.valorAsignacionProfesional
            .MONTO_ASIGNACION_LEY19185_ART18 = empleado.datosRemuneracion.valorAsignacionLey19185Art18
            .MONTO_ASIGNACION_RESPONSABILIDAD_SUPERIOR = empleado.datosRemuneracion.valorAsignacionResposabilidad
            .CLASIFICACION_INE = empleado.datosRemuneracion.clasificacionINE
            .ULTIMO_PERIODO_REMUNERACION = empleado.datosRemuneracion.ultimoPeriodoLiquidacion
            .GASTO_REPRESENTACION = empleado.datosRemuneracion.asignaGastoRepresentacion
            .MONTO_FUNCION_CRITICA = empleado.datosRemuneracion.valorFuncionCritica
            .MONTO_GASTO_REPRESENTACION = empleado.datosRemuneracion.valorGastoRepresentacion
            .MONTO_ASIGNACION_LEY18717 = empleado.datosRemuneracion.valorAsignacionLey18717
            .MONTO_LEY18675_ART10 = empleado.datosRemuneracion.valorAsignacionLey18675Art10
            .MONTO_LEY18675_ART11 = empleado.datosRemuneracion.valorAsignacionLey18675Art11
            .MONTO_LEY18566 = empleado.datosRemuneracion.valorAsignacionLey18566
            .MONTO_ASIGNACION_LEY_3551 = empleado.datosRemuneracion.valorLey3551
            .PERIODO_ID = CType(empleado.datosRemuneracion.periodo, Short)
            .MONTO_INCREMENTO_PREVIS_DL3501 = CType(empleado.datosRemuneracion.valorIncrementoPrevisionalDL3501, Integer)
            .ANO = CType(empleado.datosRemuneracion.anno, String)
            .PORCENTAJE_LEY19863 = CType(empleado.datosRemuneracion.porcentajeLey19863, Byte)
            .ENTREGO_BOLETA_HONORARIO = empleado.datosRemuneracion.entregoBoletaHonorario
            .AUTORIZA_PAGO_BIENIO = empleado.datosRemuneracion.autorizaPagoBienio
            .OBSERVACION_AUTORIZA = empleado.datosRemuneracion.observacionAutorizaPago
            .ENVIA_HACIA_DEXON = empleado.datosRemuneracion.enviarHaciaDexon
            .NUMERO_TICKET_DEXON = empleado.datosRemuneracion.numeroCompromisoDexon
            .MONTO_ASIGNACION_ZONA = empleado.datosRemuneracion.montoAsignacionZona
            .ZONA_ID = empleado.datosRemuneracion.zonaID
            .ASIGNA_LEY18675_ART11 = empleado.datosRemuneracion.AsignaLey18675Art11
        End With
    End Sub

    Private Sub asignacionCampos(ByVal empleado As BusinessRules.Empleado, ByRef empleadoLaboralDR As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_LABORALRow)
        With empleadoLaboralDR
            .EMPLEADO_ID = CType(empleado.ID, Short)
            .ESTADO_REGISTRO = CType(empleado.datosLaborales.estadoRegistro, Byte)
            .CALIDAD_JURIDICA_ID = CType(empleado.datosLaborales.calidadJuridicaID, Byte)
            .ESTAMENTO_ID = CType(empleado.datosLaborales.estamentoID, Short)
            .CLASIFICACION_EMPLEADO_ID = CType(empleado.datosLaborales.clasificacionEmpleadoID, Short)
            .GRADO_ID = CType(empleado.datosLaborales.gradoID, Short)
            .JEFE_ID = CType(empleado.datosLaborales.jefeID, Short)
            .ESCALAFON_ID = CType(empleado.datosLaborales.escalafonID, Short)
            .UBICACION_FISICA_ID = CType(empleado.datosLaborales.ubicaconFisicaID, Short)
            .HORARIO_ID = CType(empleado.datosLaborales.horarioID, Short)
            .NUMERO_TARJETA_MAGNETICA = CType(empleado.datosLaborales.numeroTarjetaMagnetica, Short)
            .TIPO_MOVIMIENTO_ID = CType(empleado.datosLaborales.tipoMovimientoID, Short)
            .RESOLUCION_CONTRATO = CType(empleado.datosLaborales.resolucionContrato, String)
            .RESOLUCION_RETIRO = CType(empleado.datosLaborales.resolucionRetiro, String)
            .RESOLUCION_ID = CType(empleado.datosLaborales.resolucionID, Short)
            If empleado.datosLaborales.resolucionFecha.Year = 1 Then
                .RESOLUCION_FECHA = CType("01-01-1990", Date)
            Else
                .RESOLUCION_FECHA = CType(empleado.datosLaborales.resolucionFecha, Date)
            End If
            .FECHA_ING_ADMIN_PUBLICA = CType(empleado.datosLaborales.fechaIngresoAdministracionPublica, Date)
            .FECHA_ING_INSTITUCION = CType(empleado.datosLaborales.fechaIngresoInstitucion, Date)
            .FECHA_ING_CALIDAD_JURIDICA = CType(empleado.datosLaborales.fechaIngresoCalidadJuridica, Date)
            .FECHA_ING_ESTAMENTO = CType(empleado.datosLaborales.fechaIngresoEstamento, Date)
            .FECHA_ING_GRADO = CType(empleado.datosLaborales.fechaIngresoGrado, Date)
            .FECHA_ING_ESCALAFON = CType(empleado.datosLaborales.fechaIngresoEscalafon, Date)
            .FECHA_ING_DEPTO = CType(empleado.datosLaborales.fechaIngresoDepartamento, Date)
            .MOTIVO_RETIRO_ID = CType(empleado.datosLaborales.motivoRetiroID, Byte)
            If empleado.datosLaborales.fechaRetiro.Year = 1 Then
                .FECHA_RETIRO = CType("01-01-1900", Date)
            Else
                .FECHA_RETIRO = CType(empleado.datosLaborales.fechaRetiro, Date)
            End If
            .OBSERVACIONES = CType(empleado.datosLaborales.observacion, String)
            .DESCRIPCION_MOVIMIENTO = empleado.datosLaborales.descripcionMovimiento
            .FECHA_MOVIMIENTO = empleado.datosLaborales.fechaMovimiento
            .PUBLICA_WEB = empleado.datosLaborales.publicaDatosWeb
            .FUNCIONES_DESEMPENADAS = empleado.datosLaborales.funcionDesempeño
            .TITULO_PROFESIONAL_EXPERTIZ = empleado.datosLaborales.tituloProfesionalExpertiz
            .ESTADO_EMPLEADO_ID = CType(empleado.datosLaborales.estadoEmpleadoID, Byte)
            .PERIODO_ID = CType(empleado.datosLaborales.periodoID, Short)
            .PERIODO_ID_CAMBIO_SITUACION = CType(empleado.datosLaborales.periodoIDCambioSituacionLaboral, Short)
            .DIAS_EN_GRADO = CType(empleado.datosLaborales.diasGrado, Byte)
            .TIPO_BENEFICIARIO_ID = empleado.datosLaborales.tipoBeneficiarioID
            .NUMERO_ACCESO = empleado.datosLaborales.numeroAcceso
            .CARGO_ACTUAL = empleado.datosLaborales.cargo
            .JEFE_EVALUADOR_ID = empleado.datosLaborales.jefeEvaluadorId
            .ASIGNA_EVALUACION_DESEMPENO = empleado.datosLaborales.incluirEvalDesempeno
        End With
    End Sub

    Private Sub asignacionCampos(ByVal empleado As BusinessRules.Empleado, ByRef licenciamedDR As DataAccess.DSEmpleado.RH_PER_LICENCIA_MEDICARow)
        With licenciamedDR
            .EMPLEADO_ID = CType(empleado.ID, Short)
            .NUMERO_LICENCIA = empleado.datosLicenciaMedica.numeroLicencia
            .TIPO_LICENCIA_MEDICA_ID = CType(empleado.datosLicenciaMedica.tipoLicenciaID, Byte)
            .ESTADO_LICENCIA = CType(empleado.datosLicenciaMedica.estadoLicencia, Byte)
            .FECHA_RECEPCION = empleado.datosLicenciaMedica.fechaRecepcion
            .DIAS_LICENCIA = CType(empleado.datosLicenciaMedica.diasLicencia, Byte)
            .FECHA_INICIO = empleado.datosLicenciaMedica.fechaInicio
            .FECHA_TERMINO = empleado.datosLicenciaMedica.fechaTermino
            .FECHA_ACCIDENTE = empleado.datosLicenciaMedica.fechaAccidente
            .FECHA_EMISION = empleado.datosLicenciaMedica.fechaEmision
            If empleado.datosLicenciaMedica.tipoReposo = 0 Then
                .TIPO_REPOSO = False
            Else
                .TIPO_REPOSO = True
            End If
            .LUGAR_REPOSO = CType(empleado.datosLicenciaMedica.lugarResposo, Byte)
            .FECHA_ENVIO_ISAPRE = empleado.datosLicenciaMedica.fechaEnvioIsapre
            If empleado.datosLicenciaMedica.continuidad = 0 Then
                .CONTINUIDAD = False
            Else
                .CONTINUIDAD = True
            End If
            .NUMERO_LICENCIA_CONTINUIDAD = empleado.datosLicenciaMedica.numeroLicenciaContinuidad
            .FECHA_INICIO_CONTINUIDAD = empleado.datosLicenciaMedica.fechaInicioContinuidad
            .DIAS_CONTINUIDAD = CType(empleado.datosLicenciaMedica.diasContinuidad, Byte)
            .FECHA_TERMINO_CONTINUIDAD = empleado.datosLicenciaMedica.fechaTerminoContinuidad
            .PERIODO = empleado.datosLicenciaMedica.periodo
            .FECHA_CONCEPCION = empleado.datosLicenciaMedica.fechaConcepcion
            .NOMBRE_DOCTOR = empleado.datosLicenciaMedica.nombreDoctor
            .ESPECIALIDAD = empleado.datosLicenciaMedica.especialidad
            .TIPO_EVENTO_ADMIN_ID = CType(Comun.TiposDeDatos.TipoEventoAdmin.LICENCIA_MEDICA, Byte)
            .NUMERO_CHEQUE = empleado.datosLicenciaMedica.numeroCheque
            .MONTO_CHEQUE = empleado.datosLicenciaMedica.montoCheque
            .MEMORANDUM = empleado.datosLicenciaMedica.momorandum
            .OBSERVACIONES = empleado.datosLicenciaMedica.observaciones
            .FECHA_DIGITACION_PAGO = empleado.datosLicenciaMedica.fechaDigitacionPago
            .PERIODO_ID = CType(empleado.datosLicenciaMedica.periodoID, Short)
            .RENTA_PROMEDIO_ID = empleado.datosLicenciaMedica.rentaPromedioID
            .CLASIFICACION = empleado.datosLicenciaMedica.clasificacion
            .FECHA_RECEPCION_ISAPRE = empleado.datosLicenciaMedica.fechaRecepcionIsapre
            .NUMERO_FILIO = empleado.datosLicenciaMedica.numeroFolio
            .DIAS_REDUCCION = CType(empleado.datosLicenciaMedica.diasReduccion, Byte)
            .FECHA_ESTIMADA_PAGO = empleado.datosLicenciaMedica.fechaEstimadaPago
            .CAUSA_RECHAZO_ID = empleado.datosLicenciaMedica.causaRechaziId
            .TIPO_PROFESIONAL = empleado.datosLicenciaMedica.tipoProfesional
        End With
    End Sub

    Private Sub asignacionCamposDatosLaborales(ByVal emplelabDR As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_LABORALRow)
        Me.datosLaborales.antecedenteLaboralID = CType(emplelabDR("ANTECEDENTE_LABORAL_ID"), Integer)
        Try
            Me.datosLaborales.estadoRegistro = CType(emplelabDR("ESTADO_REGISTRO"), Integer)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.estadoRegistro = 0
        End Try
        Try
            Me.datosLaborales.calidadJuridicaID = CType(emplelabDR("CALIDAD_JURIDICA_ID"), Integer)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.calidadJuridicaID = 0
        End Try
        Try
            Me.datosLaborales.estamentoID = CType(emplelabDR("ESTAMENTO_ID"), Integer)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.estamentoID = 0
        End Try
        Try
            Me.datosLaborales.clasificacionEmpleadoID = CType(emplelabDR("CLASIFICACION_EMPLEADO_ID"), Integer)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.clasificacionEmpleadoID = 0
        End Try
        Try
            Me.datosLaborales.gradoID = CType(emplelabDR("GRADO_ID"), Integer)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.gradoID = 0
        End Try
        Try
            Me.datosLaborales.jefeID = CType(emplelabDR("JEFE_ID"), Integer)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.jefeID = 0
        End Try
        Try
            Me.datosLaborales.escalafonID = CType(emplelabDR("ESCALAFON_ID"), Integer)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.escalafonID = 0
        End Try
        Try
            Me.datosLaborales.ubicaconFisicaID = CType(emplelabDR("UBICACION_FISICA_ID"), Integer)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.ubicaconFisicaID = 0
        End Try
        Try
            Me.datosLaborales.numeroTarjetaMagnetica = CType(emplelabDR("NUMERO_TARJETA_MAGNETICA"), Integer)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.numeroTarjetaMagnetica = 0
        End Try
        Try
            Me.datosLaborales.horarioID = CType(emplelabDR("HORARIO_ID"), Integer)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.horarioID = 0
        End Try
        Try
            Me.datosLaborales.tipoMovimientoID = CType(emplelabDR("TIPO_MOVIMIENTO_ID"), Integer)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.tipoMovimientoID = 0
        End Try
        Try
            Me.datosLaborales.resolucionContrato = CType(emplelabDR("RESOLUCION_CONTRATO"), String)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.resolucionContrato = ""
        End Try
        Try
            Me.datosLaborales.resolucionRetiro = CType(emplelabDR("RESOLUCION_RETIRO"), String)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.resolucionRetiro = ""
        End Try

        Try
            Me.datosLaborales.resolucionID = CType(emplelabDR("RESOLUCION_ID"), Integer)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.resolucionID = 0
        End Try
        Try
            Me.datosLaborales.resolucionFecha = CType(emplelabDR("RESOLUCION_FECHA"), Date)
        Catch invalidcastE As System.InvalidCastException
        End Try
        Try
            Me.datosLaborales.fechaIngresoInstitucion = CType(emplelabDR("FECHA_ING_INSTITUCION"), Date)
        Catch invalidcastE As System.InvalidCastException
        End Try
        Try
            Me.datosLaborales.fechaIngresoAdministracionPublica = CType(emplelabDR("FECHA_ING_ADMIN_PUBLICA"), Date)
        Catch invalidcastE As System.InvalidCastException
        End Try
        Try
            Me.datosLaborales.fechaIngresoCalidadJuridica = CType(emplelabDR("FECHA_ING_CALIDAD_JURIDICA"), Date)
        Catch invalidcastE As System.InvalidCastException
        End Try
        Try
            Me.datosLaborales.fechaIngresoEstamento = CType(emplelabDR("FECHA_ING_ESTAMENTO"), Date)
        Catch invalidcastE As System.InvalidCastException
        End Try
        Try
            Me.datosLaborales.fechaIngresoGrado = CType(emplelabDR("FECHA_ING_GRADO"), Date)
        Catch invalidcastE As System.InvalidCastException
        End Try
        Try
            Me.datosLaborales.fechaIngresoEscalafon = CType(emplelabDR("FECHA_ING_ESCALAFON"), Date)
        Catch invalidcastE As System.InvalidCastException
        End Try
        Try
            Me.datosLaborales.fechaIngresoDepartamento = CType(emplelabDR("FECHA_ING_DEPTO"), Date)
        Catch invalidcastE As System.InvalidCastException
        End Try
        Try
            Me.datosLaborales.motivoRetiroID = CType(emplelabDR("MOTIVO_RETIRO_ID"), Integer)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.motivoRetiroID = 0
        End Try
        Try
            Me.datosLaborales.fechaRetiro = CType(emplelabDR("FECHA_RETIRO"), Date)
        Catch invalidcastE As System.InvalidCastException
        End Try
        Try
            Me.datosLaborales.observacion = CType(emplelabDR("OBSERVACIONES"), String)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.observacion = ""
        End Try
        Try
            Me.datosLaborales.descripcionMovimiento = CType(emplelabDR("DESCRIPCION_MOVIMIENTO"), String)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.descripcionMovimiento = ""
        End Try
        Try
            Me.datosLaborales.fechaMovimiento = CType(emplelabDR("FECHA_MOVIMIENTO"), Date)
        Catch invalidcastE As System.InvalidCastException
        End Try
        Try
            Me.datosLaborales.publicaDatosWeb = CType(emplelabDR("PUBLICA_WEB"), Boolean)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.publicaDatosWeb = False
        End Try
        Try
            Me.datosLaborales.funcionDesempeño = CType(emplelabDR("FUNCIONES_DESEMPENADAS"), String)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.funcionDesempeño = ""
        End Try
        Try
            Me.datosLaborales.tituloProfesionalExpertiz = CType(emplelabDR("TITULO_PROFESIONAL_EXPERTIZ"), String)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.tituloProfesionalExpertiz = ""
        End Try
        Try
            Me.datosLaborales.estadoEmpleadoID = CType(emplelabDR("ESTADO_EMPLEADO_ID"), Integer)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.estadoEmpleadoID = 0
        End Try
        Try
            Me.datosLaborales.periodoID = CType(emplelabDR("PERIODO_ID"), Integer)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.periodoID = 0
        End Try
        Try
            Me.datosLaborales.periodoIDCambioSituacionLaboral = CType(emplelabDR("PERIODO_ID_CAMBIO_SITUACION"), Integer)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.periodoIDCambioSituacionLaboral = 0
        End Try
        Try
            Me.datosLaborales.diasGrado = CType(emplelabDR("DIAS_EN_GRADO"), Byte)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.diasGrado = 0
        End Try
        Try
            Me.datosLaborales.tipoBeneficiarioID = CType(emplelabDR("TIPO_BENEFICIARIO_ID"), Integer)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.tipoBeneficiarioID = 0
        End Try
        Try
            Me.datosLaborales.numeroAcceso = CType(emplelabDR("NUMERO_ACCESO"), Short)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.numeroAcceso = 0
        End Try
        Try
            Me.datosLaborales.cargo = CType(emplelabDR("CARGO_ACTUAL"), String)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.cargo = ""
        End Try
        Try
            Me.datosLaborales.jefeEvaluadorId = CType(emplelabDR("JEFE_EVALUADOR_ID"), Integer)
        Catch invalidcastE As System.InvalidCastException
            Me.datosLaborales.jefeEvaluadorId = 0
        End Try
        Me.datosLaborales.incluirEvalDesempeno = CType(emplelabDR("ASIGNA_EVALUACION_DESEMPENO"), Boolean)

    End Sub
    Private Sub asignacionCampos(ByVal empleado As BusinessRules.Empleado, ByRef empleadoEstrucOrgDR As DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_ORGANICARow)
        With empleadoEstrucOrgDR
            .ESTADO_REGISTRO = CType(empleado.datosEstructuraOrganica.estadoRegistro, Byte)
            .EMPLEADO_ID = CType(empleado.ID, Short)
            .ORGANIZACION_ID = CType(empleado.datosEstructuraOrganica.organizacionID, Short)
            .DIRECCION_ID = CType(empleado.datosEstructuraOrganica.direccionID, Short)
            .DEPTO_ID = CType(empleado.datosEstructuraOrganica.deptoID, Short)
            .PERIODO_ID = CType(empleado.datosEstructuraOrganica.periodoID, Short)
            .AUTORIZADOR_HORAS_EXTRAS_ID = empleado.datosEstructuraOrganica.autorizadorHorasExtrasID
            .EVALUADOR_DESEMPENO_ID = empleado.datosEstructuraOrganica.evaluadorDesempenoID
            .SUB_DEPTO_ID = empleado.datosEstructuraOrganica.subDeptoId
        End With
    End Sub

    Private Sub asignacionCampos(ByVal empleado As BusinessRules.Empleado, ByRef empleadoEstrucContabDR As DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_CONTABLERow)
        With empleadoEstrucContabDR
            .ESTADO_REGISTRO = CType(empleado.datosEstructuraContable.estadoRegistro, Byte)
            .EMPLEADO_ID = CType(empleado.ID, Short)
            .ORGANIZACION_ID = CType(empleado.datosEstructuraContable.organizacionID, Short)
            .CENTRO_COSTO_CONTAB_ID = CType(empleado.datosEstructuraContable.centroCostoContab, Short)
            .CENTRO_COSTO_PRESUP_ID = CType(empleado.datosEstructuraContable.centroCostoPresup, Short)
            .PORCENTAJE_DISTRIB = CType(empleado.datosEstructuraContable.procentajeDistribucion, Byte)
            .PERIODO_ID = CType(empleado.datosEstructuraContable.periodoID, Short)
        End With
    End Sub
    Private Sub asignacionCampos(ByVal empleado As BusinessRules.Empleado, ByRef saldoDiasEventoAdminDR As DataAccess.DSEmpleado.RH_PER_EVENTO_ADMIN_SALDORow)
        With saldoDiasEventoAdminDR
            .TIPO_EVENTO_ADMIN_ID = empleado.datosSaldoDiasEventoAdmin.tipoEventoAdminID
            .EMPLEADO_ID = CType(empleado.datosSaldoDiasEventoAdmin.empleadoID, Short)
            .DIAS_PERIODO = empleado.datosSaldoDiasEventoAdmin.diasPeriodo
            .DIAS_PERIODO_ANT = empleado.datosSaldoDiasEventoAdmin.diasPeriodoAnterior
            .DIAS_ADICIONALES = empleado.datosSaldoDiasEventoAdmin.diasAdicionales
            .TOTAL_DIAS_ANUAL = empleado.datosSaldoDiasEventoAdmin.totalDiasAnual
            .TOTAL_DIAS_SOLICITADOS = empleado.datosSaldoDiasEventoAdmin.totalDiasSolicitados
            .DIAS_PENDIENTE = empleado.datosSaldoDiasEventoAdmin.diasPendiente
            .ANO = CType(empleado.datosSaldoDiasEventoAdmin.anoProceso, Short)
        End With
    End Sub
    Public Function Crear() As Object
        Dim empleadoDR As DataAccess.DSEmpleado.RH_PER_EMPLEADORow
        empleadoDR = CType(empleadosDS.Tables(NOMBRE_TABLA).NewRow, DataAccess.DSEmpleado.RH_PER_EMPLEADORow)
        asignacionCampos(Me, empleadoDR)
        empleadoDR = CType(empleadosDS.Inserta(empleadoDR), DataAccess.DSEmpleado.RH_PER_EMPLEADORow)
        Me.setID(empleadoDR.EMPLEADO_ID)
        Return (Me)
    End Function

    Public Function CrearEmpleadoLaboral() As Long
        Dim empleadoLaboralDR As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_LABORALRow
        empleadoLaboralDR = CType(empleadosDS.Tables(Tablas.RH_PER_ANTECEDENTE_LABORAL).NewRow, DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_LABORALRow)
        asignacionCampos(Me, empleadoLaboralDR)
        empleadoLaboralDR = CType(empleadosDS.InsertaEmpleadoLaboral(empleadoLaboralDR), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_LABORALRow)
        Return (empleadoLaboralDR.ANTECEDENTE_LABORAL_ID)
    End Function

    Public Function CrearEmpleadoPrevisional(ByVal idPrev As Integer) As Long
        Dim empleadoprevisDR As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_PREVISRow
        empleadoprevisDR = CType(empleadosDS.Tables(Tablas.RH_PER_ANTECEDENTE_PREVIS).NewRow, DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_PREVISRow)
        asignacionCampos(Me, empleadoprevisDR)
        empleadoprevisDR = CType(empleadosDS.InsertaEmpleadoPrevis(empleadoprevisDR, idPrev), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_PREVISRow)
        Return (empleadoprevisDR.ANTECEDENTE_PREVIS_ID)
    End Function

    Public Function CrearEmpleadoPresupuentoAnualHonorario(ByVal idPresupAnual As Integer) As Long
        Dim dr As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_HONORARIO_DETALLERow
        dr = CType(empleadosDS.Tables(Tablas.RH_PER_ANTECEDENTE_HONORARIO_DETALLE).NewRow, DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_HONORARIO_DETALLERow)
        asignacionCampos(Me, dr)
        dr = CType(empleadosDS.ActualizaEmpleadoPresupuestoAnualHonorario(idPresupAnual, dr), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_HONORARIO_DETALLERow)
        Return (dr.ANTECEDENTE_HONORARIO_DETALLE_ID)
    End Function

    Public Function CrearEmpleadoAntecedenteCurricular() As Long
        Dim dr As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_CURRIRow
        dr = CType(empleadosDS.Tables(Tablas.RH_PER_ANTECEDENTE_CURRI).NewRow, DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_CURRIRow)
        asignacionCampos(Me, dr)
        dr = CType(empleadosDS.ActulizaEmpleadoCurriculumLaboral(dr), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_CURRIRow)
        Return (dr.ANTECEDENTE_CURRI_ID)
    End Function

    Public Function CrearEmpleadoAPV() As Long
        Dim empleadoApvDR As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_APVRow
        empleadoApvDR = CType(empleadosDS.Tables(Tablas.RH_PER_ANTECEDENTE_APV).NewRow, DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_APVRow)
        asignacionCampos(Me, empleadoApvDR)
        empleadoApvDR = CType(empleadosDS.InsertaEmpleadoAPV(empleadoApvDR), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_APVRow)
    End Function

    Public Function CrearEmpleadoRemun() As Long
        Dim empleadoRemunDR As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_REMUNRow
        empleadoRemunDR = CType(empleadosDS.Tables(Tablas.RH_PER_ANTECEDENTE_REMUN).NewRow, DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_REMUNRow)
        asignacionCampos(Me, empleadoRemunDR)
        empleadoRemunDR = CType(empleadosDS.InsertaEmpleadoRemun(empleadoRemunDR), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_REMUNRow)
        Return (empleadoRemunDR.ANTECEDENTE_REMUN_ID)
    End Function

    Public Function CrearEmpleadoLicenciaMedica() As Long
        Dim licenciaMedicaDR As DataAccess.DSEmpleado.RH_PER_LICENCIA_MEDICARow
        licenciaMedicaDR = CType(empleadosDS.Tables(Tablas.RH_PER_LICENCIA_MEDICA).NewRow, DataAccess.DSEmpleado.RH_PER_LICENCIA_MEDICARow)
        asignacionCampos(Me, licenciaMedicaDR)
        licenciaMedicaDR = CType(empleadosDS.InsertaEmpleadoLicenciaMedica(licenciaMedicaDR), DataAccess.DSEmpleado.RH_PER_LICENCIA_MEDICARow)
        Return (licenciaMedicaDR.LICENCIA_MEDICA_ID)
    End Function
    Public Function CrearEmpleadoEstructuraOrganica() As Long
        Dim empleadoEstruOrg As DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_ORGANICARow
        empleadoEstruOrg = CType(empleadosDS.Tables(Tablas.RH_PER_ESTRUCTURA_ORGANICA).NewRow, DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_ORGANICARow)
        asignacionCampos(Me, empleadoEstruOrg)
        empleadoEstruOrg = CType(empleadosDS.InsertaEmpleadoEstructuraOrganica(empleadoEstruOrg), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_ORGANICARow)
        Return (empleadoEstruOrg.ESTRUCTURA_ORGANICA_ID)
    End Function
    Public Function CrearEmpleadoEstructuraContable() As Long
        Dim empleadoEstruContab As DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_CONTABLERow
        empleadoEstruContab = CType(empleadosDS.Tables(Tablas.RH_PER_ESTRUCTURA_CONTABLE).NewRow, DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_CONTABLERow)
        asignacionCampos(Me, empleadoEstruContab)
        empleadoEstruContab = CType(empleadosDS.InsertaEmpleadoEstructuraContable(empleadoEstruContab), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_CONTABLERow)
        Return (empleadoEstruContab.ESTRUCTURA_CONTABLE_ID)
    End Function
    Public Function CrearItemEmpleado(ByVal emple As BusinessRules.Empleado, ByVal parametroMensual As BusinessRules.Periodo, ByVal origen As Integer, ByVal tipoProceso As String) As Boolean
        Try
            emple.EliminarMovimientoMensualEmpleado(parametroMensual.ID, CType(emple.ID, Integer), origen, tipoProceso)
            If CType(emple.datosRemuneracion.rentaBase, Integer) > 0 Then
                emple.CrearEmpleadoMovimientoMensual(parametroMensual.ID, parametroMensual.itemSueldoBase, CType(emple.ID, Integer), 0, 0, origen, CType(emple.datosRemuneracion.rentaBase, Integer), tipoProceso)
            End If
            If CType(emple.datosRemuneracion.sueldoBase, Integer) > 0 Then
                emple.CrearEmpleadoMovimientoMensual(parametroMensual.ID, parametroMensual.itemSueldoBase, CType(emple.ID, Integer), 0, 0, origen, CType(emple.datosRemuneracion.sueldoBase, Integer), tipoProceso)
            End If
            If CType(emple.datosRemuneracion.valorAsignacionProfesional, Integer) > 0 Then
                emple.CrearEmpleadoMovimientoMensual(parametroMensual.ID, parametroMensual.itemLey19185Art19, CType(emple.ID, Integer), 0, 0, origen, CType(emple.datosRemuneracion.valorAsignacionProfesional, Integer), tipoProceso)
            End If
            If CType(emple.datosRemuneracion.valorAsignacionResposabilidad, Integer) > 0 Then
                emple.CrearEmpleadoMovimientoMensual(parametroMensual.ID, parametroMensual.itemResponsabilidadSuperior, CType(emple.ID, Integer), 0, 0, origen, CType(emple.datosRemuneracion.valorAsignacionResposabilidad, Integer), tipoProceso)
            End If
            If CType(emple.datosRemuneracion.valorAsignacionLey19185Art18, Integer) > 0 Then
                emple.CrearEmpleadoMovimientoMensual(parametroMensual.ID, parametroMensual.itemLey19185Art18, CType(emple.ID, Integer), 0, 0, origen, CType(emple.datosRemuneracion.valorAsignacionLey19185Art18, Integer), tipoProceso)
            End If
            If CType(emple.datosRemuneracion.valorGastoRepresentacion, Integer) > 0 Then
                emple.CrearEmpleadoMovimientoMensual(parametroMensual.ID, parametroMensual.itemGastoRepresentacion, CType(emple.ID, Integer), 0, 0, origen, CType(emple.datosRemuneracion.valorGastoRepresentacion, Integer), tipoProceso)
            End If
            If CType(emple.datosRemuneracion.valorAsignacionLey18717, Integer) > 0 Then
                emple.CrearEmpleadoMovimientoMensual(parametroMensual.ID, parametroMensual.itemLey18717, CType(emple.ID, Integer), 0, 0, origen, CType(emple.datosRemuneracion.valorAsignacionLey18717, Integer), tipoProceso)
            End If
            If CType(emple.datosRemuneracion.valorAsignacionLey18675Art10, Integer) > 0 And CType(emple.datosPrevisionales.tipoTrabajadorPrevidredID, Integer) <> 3 Then
                emple.CrearEmpleadoMovimientoMensual(parametroMensual.ID, parametroMensual.itemLey18675Art10, CType(emple.ID, Integer), 0, 0, origen, CType(emple.datosRemuneracion.valorAsignacionLey18675Art10, Integer), tipoProceso)
            End If
            If CType(emple.datosRemuneracion.valorAsignacionLey18675Art11, Integer) > 0 Then
                emple.CrearEmpleadoMovimientoMensual(parametroMensual.ID, parametroMensual.itemLey18675Art11, CType(emple.ID, Integer), 0, 0, origen, CType(emple.datosRemuneracion.valorAsignacionLey18675Art11, Integer), tipoProceso)
            End If
            If CType(emple.datosRemuneracion.valorAsignacionLey18566, Integer) > 0 Then
                emple.CrearEmpleadoMovimientoMensual(parametroMensual.ID, parametroMensual.itemLey18566Salud, CType(emple.ID, Integer), 0, 0, origen, CType(emple.datosRemuneracion.valorAsignacionLey18566, Integer), tipoProceso)
            End If
            If CType(emple.datosRemuneracion.valorLey3551, Integer) > 0 Then
                emple.CrearEmpleadoMovimientoMensual(parametroMensual.ID, parametroMensual.itemLey3551, CType(emple.ID, Integer), 0, 0, 2, CType(emple.datosRemuneracion.valorLey3551, Integer), tipoProceso)
            End If
            If CType(emple.datosRemuneracion.numeroBienios, Integer) > 0 And emple.datosRemuneracion.autorizaPagoBienio = True Then
                'Calculo asignacion antiguedad, solo para efecto calculo incremento previsional
                'Dim montoAsigAntiguedad As Integer
                'montoAsigAntiguedad = CType(Math.Round(emple.datosRemuneracion.sueldoBase * (2 / 100) * emple.datosRemuneracion.numeroBienios, 0), Integer)
                emple.CrearEmpleadoMovimientoMensual(parametroMensual.ID, parametroMensual.itemAsignacionAntiguedad, CType(emple.ID, Integer), 0, 0, origen, emple.datosRemuneracion.montoBienio, tipoProceso)
            End If
            If emple.datosRemuneracion.afiliadoBienestar Then
                emple.CrearEmpleadoMovimientoMensual(parametroMensual.ID, parametroMensual.itemFondoBienestar, CType(emple.ID, Integer), 0, 0, origen, 1, tipoProceso)
            End If
            If CType(emple.datosRemuneracion.valorIncrementoPrevisionalDL3501, Integer) > 0 Then
                emple.CrearEmpleadoMovimientoMensual(parametroMensual.ID, parametroMensual.itemIncrementoPrevisional, CType(emple.ID, Integer), 0, 0, origen, CType(emple.datosRemuneracion.valorIncrementoPrevisionalDL3501, Integer), tipoProceso)
            End If
            If emple.datosRemuneracion.cargaFamiliarNormal > 0 Or emple.datosRemuneracion.cargaFamiliarPrenatal > 0 Or emple.datosRemuneracion.cargaFamiliarInvalida > 0 Then
                generaAsignacionFamiliarEmpleado(emple, parametroMensual, origen, tipoProceso)
            End If
            If CType(emple.datosRemuneracion.valorFuncionCritica, Integer) > 0 Then
                emple.CrearEmpleadoMovimientoMensual(parametroMensual.ID, parametroMensual.itemMontoFuncionCritica, CType(emple.ID, Integer), 0, 0, origen, CType(emple.datosRemuneracion.valorFuncionCritica, Integer), tipoProceso)
            End If
            If parametroMensual.aplicaAsignacionZona = True And CType(emple.datosRemuneracion.montoAsignacionZona, Integer) > 0 Then
                emple.CrearEmpleadoMovimientoMensual(parametroMensual.ID, parametroMensual.itemAsignacionZona, CType(emple.ID, Integer), 0, 0, origen, CType(emple.datosRemuneracion.montoAsignacionZona, Integer), tipoProceso)
            End If
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function

    Public Function generaAsignacionFamiliarEmpleado(ByVal emple As BusinessRules.Empleado, ByVal parametroMensual As BusinessRules.Periodo, ByVal origen As Integer, ByVal tipoProceso As String) As Boolean
        'Dim montoAsigFamiliar As Integer = CType(_util.buscaID_(Comun.Tablas.RH_REM_TRAMO_ASIGNACION_FAMILIAR, "NA", "TRAMO_ASIGNACION_FAMILIAR_ID", CType(emple.datosRemuneracion.tramoAsignacionFamiliarID, String), "MONTO"), Integer)
        Dim montoAsigFamiliar As Integer = emple.buscaInteger("SELECT MONTO FROM " & Comun.Tablas.RH_REM_TRAMO_ASIGNACION_FAMILIAR & " WHERE TRAMO_ASIGNACION_FAMILIAR_ID=" & CType(emple.datosRemuneracion.tramoAsignacionFamiliarID, String))
        Dim TotalAsigFamiliar As Integer = 0

        Try
            If montoAsigFamiliar > 0 Then
                If emple.datosRemuneracion.cargaFamiliarNormal > 0 Then
                    TotalAsigFamiliar += CType(emple.datosRemuneracion.cargaFamiliarNormal, Integer) * montoAsigFamiliar
                End If
                If emple.datosRemuneracion.cargaFamiliarInvalida > 0 Then
                    TotalAsigFamiliar += (CType(emple.datosRemuneracion.cargaFamiliarInvalida, Integer) * montoAsigFamiliar) * 2
                End If
                If emple.datosRemuneracion.cargaFamiliarPrenatal > 0 Then
                    TotalAsigFamiliar += CType(emple.datosRemuneracion.cargaFamiliarPrenatal, Integer) * montoAsigFamiliar
                End If
                If TotalAsigFamiliar > 0 Then
                    emple.CrearEmpleadoMovimientoMensual(parametroMensual.ID, parametroMensual.itemAsignacionFamiliar, CType(emple.ID, Integer), 0, 0, origen, CType(TotalAsigFamiliar, Integer), tipoProceso)
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return (False)
        End Try
    End Function

    Public Function CrearEmpleadoMovimientoMensual(ByVal idPeriodo As Integer, ByVal idItem As Integer, _
                                                   ByVal idEmpleado As Integer, ByVal cuotaIni As Short, _
                                                   ByVal cuotaFin As Short, ByVal origen As Integer, _
                                                   ByVal cantidad As Integer, ByVal tipoProceso As String) As Boolean
        Try
            Return empleadosDS.InsertaEmpleadoMovimientoMensual(idPeriodo, idItem, idEmpleado, cuotaIni, cuotaFin, origen, cantidad, tipoProceso)
        Catch excepcion As Exception
            Throw excepcion
            Return False
        End Try
    End Function

    Public Function CrearEmpleadoMovimientoMensual(ByVal idPeriodo As Integer, ByVal idItem As Integer, _
                                               ByVal idEmpleado As Integer, ByVal cuotaIni As Short, _
                                               ByVal cuotaFin As Short, ByVal origen As Integer, _
                                               ByVal cantidad As Integer, ByVal tipoProceso As String, ByVal codigo_externo As Integer, ByVal glosa As String) As Boolean
        Return (empleadosDS.InsertaEmpleadoMovimientoMensual(idPeriodo, idItem, idEmpleado, cuotaIni, cuotaFin, origen, cantidad, tipoProceso, codigo_externo, glosa))
    End Function
    Public Function CrearEmpleadoReliquidado(ByVal idPeriodoVigente As Integer, ByVal idPeriodoHistorico As Integer, ByVal idEmpleado As Integer, ByVal tipoProceso As String) As Boolean
        Return empleadosDS.InsertarEmpleadoReliquidado(idPeriodoVigente, idPeriodoHistorico, idEmpleado, tipoProceso)
    End Function
    Public Function CrearEmpleadoSuplementaria(ByVal idPeriodoVigente As Integer, ByVal idPeriodoHistorico As Integer, ByVal idEmpleado As Integer, ByVal tipoProceso As String) As Boolean
        Return empleadosDS.InsertarEmpleadoSuplementaria(idPeriodoVigente, idPeriodoHistorico, idEmpleado, tipoProceso)
    End Function
    Public Function CrearEmpleadoSuplementariaHonorario(ByVal idPeriodoVigente As Integer, ByVal idPeriodoHistorico As Integer, ByVal idEmpleado As Integer, ByVal tipoProceso As String) As Boolean
        Return empleadosDS.InsertarEmpleadoSuplementariaHonorario(idPeriodoVigente, idPeriodoHistorico, idEmpleado, tipoProceso)
    End Function
    Public Function CrearEmpleadoReliquidadoBonoModernidad(ByVal idPeriodoVigente As Integer, ByVal idPeriodoHistorico As Integer, ByVal idEmpleado As Integer, ByVal tipoProceso As String) As Boolean
        Return empleadosDS.InsertarEmpleadoReliquidadoBonoModernidad(idPeriodoVigente, idPeriodoHistorico, idEmpleado, tipoProceso)
    End Function
    Public Function CrearItemReliquidado(ByVal idPeriodo As Integer, ByVal idEmpleado As Integer, ByVal tipoProceso As String) As Boolean
        Try
            Return empleadosDS.InsertarItemReliquidado(idPeriodo, idEmpleado, tipoProceso)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
    End Function
    Public Function CrearRentaPromedioEmpleadoLicMedica(ByVal idLicecniaMedica As Integer) As Boolean
        Try
            Return empleadosDS.InsertarRentaPromedioLicenciaMedica(idLicecniaMedica)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
    End Function

    Public Function CrearEmpleadoEventoAdmin(ByVal IDTipoEventoAdmin As Integer) As Long
        Dim EventoAdminDR As DataAccess.DSEmpleado.RH_PER_EVENTO_ADMINRow
        EventoAdminDR = CType(empleadosDS.Tables(Tablas.RH_PER_EVENTO_ADMIN).NewRow, DataAccess.DSEmpleado.RH_PER_EVENTO_ADMINRow)
        asignacionCampos(Me, EventoAdminDR)
        EventoAdminDR = CType(empleadosDS.InsertaEmpleadoEventoAdmin(EventoAdminDR, IDTipoEventoAdmin), DataAccess.DSEmpleado.RH_PER_EVENTO_ADMINRow)
        Return (EventoAdminDR.EVENTO_ADMINISTRATIVO_ID)
    End Function
    Public Function CrearEmpleadoSaldoDiasEventoAdmin() As Long
        Dim SaldoEventoAdminDR As DataAccess.DSEmpleado.RH_PER_EVENTO_ADMIN_SALDORow
        SaldoEventoAdminDR = CType(empleadosDS.Tables(Tablas.RH_PER_EVENTO_ADMIN_SALDO).NewRow, DataAccess.DSEmpleado.RH_PER_EVENTO_ADMIN_SALDORow)
        asignacionCampos(Me, SaldoEventoAdminDR)
        SaldoEventoAdminDR = CType(empleadosDS.InsertaEmpleadoSaldoDiasEventoAdmin(SaldoEventoAdminDR), DataAccess.DSEmpleado.RH_PER_EVENTO_ADMIN_SALDORow)
        Return (SaldoEventoAdminDR.EVENTO_ADMIN_SALDO_ID)
    End Function
    Public Function generaResumenPagoHorasExtras(ByVal fechaInicio As Date, ByVal fechaFinal As Date, ByVal idEmpleado As Integer, ByVal tipoProceso As String) As String
        Return empleadosDS.generarResumenPagoHorasExtras(fechaInicio, fechaFinal, idEmpleado, tipoProceso)
    End Function
    Public Function generaHorasExtrasPagadasVsRatificadas(ByVal PeriodoIdaProcesar As Integer, ByVal tipoCalculo As String) As String
        Return empleadosDS.generarHorasExtrasPagadasVsRatificadas(PeriodoIdaProcesar, tipoCalculo)
    End Function
    Public Function Actualizar() As Object
        Dim empleadoDR As DataAccess.DSEmpleado.RH_PER_EMPLEADORow
        empleadoDR = CType(empleadosDS.Busca(Me.ID), DataAccess.DSEmpleado.RH_PER_EMPLEADORow)
        Dim empleado As BusinessRules.Empleado = Me
        asignacionCampos(Me, empleadoDR)
        empleadoDR = CType(empleadosDS.Actualiza(empleadoDR), DataAccess.DSEmpleado.RH_PER_EMPLEADORow)
        Return (empleado)
    End Function

    Public Function CalcularEndeudamientoEmpleado(ByVal EmpleadoId As Integer, ByVal PeriodoId As Integer) As Boolean
        Try
            empleadosDS.EjecutaSQL("EXEC " & SQL.STORE_PROCEDURES.CALCULAR_ENDEUDAMIENTO_EMPLEADO & " " & EmpleadoId.ToString & "," & PeriodoId.ToString)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function

    Public Function Eliminar() As Boolean
        Try
            empleadosDS.Elimina(SQL.STORE_PROCEDURES.ELIMINA_EMPLEADO & " " & Me.ID)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function

    Public Function EliminarEmpleadoAPV(ByVal IDApvEmpleado As Integer) As Boolean
        Try
            empleadosDS.Elimina(SQL.STORE_PROCEDURES.ELIMINA_EMPLEADO_APV & " " & IDApvEmpleado)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function
    Public Function EliminarEmpleadoLicenciaMedica(ByVal IDLicenciaMedica As Integer) As Boolean
        Try
            empleadosDS.Elimina(SQL.STORE_PROCEDURES.ELIMINA_EMPLEADO_LICENCIA_MEDICA & " " & IDLicenciaMedica)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function
    Public Function EliminarEmpleadoEstructuraOrganica(ByVal IDEstructuraOrganica As Integer) As Boolean
        Try
            empleadosDS.Elimina(SQL.STORE_PROCEDURES.ELIMINA_EMPLEADO_ESTRUC_ORGANICA & " " & IDEstructuraOrganica)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function
    Public Function EliminarRegistroHoraExtra(ByVal IDHoraExtra As Integer) As Boolean
        Try
            empleadosDS.Elimina(SQL.STORE_PROCEDURES.ELIMINA_REGISTRO_HORA_EXTRA & " " & IDHoraExtra.ToString)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function
    Public Function EliminarEmpleadoAntecedenteCurricular(ByVal AntecedenteCurricilarId As Integer) As Boolean
        Try
            empleadosDS.Elimina(SQL.STORE_PROCEDURES.ELIMINA_EMPLEADO_ANTECEDENTE_CURRICULAR & " " & AntecedenteCurricilarId)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function
    Public Function EliminarEmpleadoAntecedenteBinario(ByVal binarioId As Integer) As Boolean
        Try
            empleadosDS.Elimina(SQL.STORE_PROCEDURES.ELIMINA_EMPLEADO_ANTECEDENTE_BINARIO & " " & binarioId)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function
    Public Function EliminarEmpleadoEstructuraContable(ByVal IDEstructuraContable As Integer) As Boolean
        Try
            empleadosDS.Elimina(SQL.STORE_PROCEDURES.ELIMINA_EMPLEADO_ESTRUC_CONTABLE & " " & IDEstructuraContable)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function

    Public Function EliminarMovimientoMensualEmpleado(ByVal idPeriodo As Integer, ByVal idEmpleado As Integer, ByVal tipoOrigen As Integer, ByVal tipoProceso As String) As Boolean
        Dim SQL, cmd As String
        cmd = " AND TIPO_PROCESO=" + "'" + tipoProceso + "'"
        'Existen tipo de origen para indentificar la procedencia de los datos: 0=Bienestar;1=Digitado por remuneraciones;2=Ficha del empleado
        SQL = "DELETE FROM " & Tablas.RH_REM_MOVIMIENTO_MENSUAL & " WHERE EMPLEADO_ID=" & idEmpleado & " AND ORIGEN=" & tipoOrigen & " AND PERIODO_ID=" & idPeriodo & cmd
        Try
            empleadosDS.Elimina(SQL)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function
    Public Function EliminarEmpleadoMovimientoMensual(ByVal idPeriodo As Integer, ByVal idItem As Integer, ByVal origen As Integer, ByVal tipoProceso As String) As Boolean
        Dim SQL, cmd As String
        cmd = " AND TIPO_PROCESO=" + "'" + tipoProceso + "'"
        SQL = "DELETE FROM " & Tablas.RH_REM_MOVIMIENTO_MENSUAL & " WHERE ITEM_ID=" & idItem & " AND ORIGEN=" & origen & " AND PERIODO_ID=" & idPeriodo & cmd
        Try
            empleadosDS.Elimina(SQL)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function

    Public Function EliminarMovimientoMensualItemEmpleado(ByVal idPeriodo As Integer, ByVal idEmpleado As Integer, ByVal tipoOrigen As Integer, ByVal tipoProceso As String, ByVal idItem As Integer) As Boolean
        Dim SQL, cmd As String
        cmd = " AND TIPO_PROCESO=" + "'" + tipoProceso + "'"
        'Existen tipo de origen para indentificar la procedencia de los datos: 0=Bienestar;1=Digitado por remuneraciones;2=Ficha del empleado
        SQL = "DELETE FROM " & Tablas.RH_REM_MOVIMIENTO_MENSUAL & " WHERE EMPLEADO_ID=" & idEmpleado & " AND ORIGEN=" & tipoOrigen & " AND ITEM_ID=" & idItem & " AND PERIODO_ID=" & idPeriodo & cmd
        Try
            empleadosDS.Elimina(SQL)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function

    Public Function EliminarMarcaAssissCAD(ByVal idmarca As Integer) As Boolean
        Dim SQL As String = ""
        Dim cmd As String = ""
        'Existen tipo de origen para indentificar la procedencia de los datos: 0=Bienestar;1=Digitado por remuneraciones;2=Ficha del empleado
        SQL = "DELETE FROM ICARO.ASSISCAD_PRESIDENCIA.DBO.MARCAS_VIGENTES " & " WHERE MARC_GENERADA_ID=" & idmarca
        Try
            empleadosDS.Elimina(SQL)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function

    Public Function eliminarHeaderEventoAdmin(ByVal idEventoAdmin As Integer) As Boolean
        Dim SQL As String = ""
        Dim cmd As String = ""
        SQL = "DELETE FROM " & Tablas.RH_PER_EVENTO_ADMIN & " WHERE EVENTO_ADMINISTRATIVO_ID=" & idEventoAdmin
        Try
            empleadosDS.Elimina(SQL)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try

    End Function
    Public Function eliminarDetalleEventoAdmin(ByVal idEventoAdmin As Integer) As Boolean
        Dim SQL As String = ""
        Dim cmd As String = ""
        SQL = "DELETE FROM " & Tablas.RH_PER_EVENTO_ADMIN_DET & " WHERE EVENTO_ADMINISTRATIVO_ID=" & idEventoAdmin
        Try
            empleadosDS.Elimina(SQL)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function

    Public Function eliminarDetallePresupuestoAnual(ByVal idDetallePresupuestoAnual As Integer) As Boolean
        Dim SQL As String = ""
        Dim cmd As String = ""
        SQL = "DELETE FROM " & Tablas.RH_PER_ANTECEDENTE_HONORARIO_DETALLE & " WHERE ANTECEDENTE_HONORARIO_DETALLE_ID=" & idDetallePresupuestoAnual
        Try
            empleadosDS.Elimina(SQL)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function
    Public Function EliminarFichaIntranet(ByVal empleadoID As Integer) As Boolean
        Try
            empleadosDS.Elimina(SQL.STORE_PROCEDURES.ELIMINA_EMPLEADO_FICHA_INTRANET & " " & empleadoID)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function

    Public Function eliminarDetalleHorasAprobadas(ByVal idHorasAprobadas As Integer) As Boolean
        Dim SQL As String = ""
        Dim cmd As String = ""
        SQL = "DELETE FROM RH_PER_HORAS_EXTRAS_APROBADAS WHERE HORAS_APROBADAS_ID=" & idHorasAprobadas
        Try
            empleadosDS.Elimina(SQL)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function

    Public Function eliminarHorasAprobadas(ByVal Año As Integer, ByVal Mes As Integer, ByVal NumeroMemo As Integer) As Boolean
        Dim SQL As String = ""
        Dim cmd As String = ""
        SQL = "DELETE FROM RH_PER_HORAS_EXTRAS_APROBADAS WHERE AÑO = " + Año.ToString + " AND MES = " + Mes.ToString + " AND NRO_MEMO_INTERMO = " + NumeroMemo.ToString
        Try
            empleadosDS.Elimina(SQL)
            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function

    Public Function ActualizaPeriodoMaestrosEmpleado(ByVal idPeriodo As Integer, ByVal idEmpleado As Integer) As Boolean
        Dim SQL As String
        Try
            SQL = "UPDATE RH_PER_ANTECEDENTE_LABORAL SET PERIODO_ID = " & idPeriodo.ToString & " WHERE EMPLEADO_ID = " & idEmpleado & " AND ESTADO_REGISTRO = 1"
            empleadosDS.Elimina(SQL)

            SQL = "UPDATE RH_PER_ANTECEDENTE_PREVIS SET PERIODO_ID = " & idPeriodo.ToString & " WHERE EMPLEADO_ID = " & idEmpleado & " AND ESTADO_REGISTRO = 1"
            empleadosDS.Elimina(SQL)

            SQL = "UPDATE RH_PER_ANTECEDENTE_REMUN SET PERIODO_ID = " & idPeriodo.ToString & " WHERE EMPLEADO_ID = " & idEmpleado & " AND ESTADO_REGISTRO = 1"
            empleadosDS.Elimina(SQL)

            SQL = "UPDATE RH_PER_ESTRUCTURA_CONTABLE SET PERIODO_ID = " & idPeriodo.ToString & " WHERE EMPLEADO_ID = " & idEmpleado & " AND ESTADO_REGISTRO = 1"
            empleadosDS.Elimina(SQL)

            SQL = "UPDATE RH_PER_ESTRUCTURA_ORGANICA SET PERIODO_ID = " & idPeriodo.ToString & " WHERE EMPLEADO_ID = " & idEmpleado & " AND ESTADO_REGISTRO = 1"
            empleadosDS.Elimina(SQL)

            SQL = "UPDATE RH_PER_ANTECEDENTE_APV SET PERIODO_ID = " & idPeriodo.ToString & " WHERE EMPLEADO_ID = " & idEmpleado & " AND ESTADO_REGISTRO = 1"
            empleadosDS.Elimina(SQL)

            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function

    Private Function recuperarAntecedentesCurriculares() As DataRow
        'Se rescatan los datos curriculares para el empleado
        Return (empleadosDS.recuperaAntecedentesCurriculares(Me.ID))
    End Function

    Private Function recuperarDetalleEventoAdmin(ByVal ID As Integer) As DataView
        'Se rescatan los datos curriculares para el empleado
        Return (empleadosDS.recuperaDetalleEventoAdmin(ID))
    End Function

    Private Function recuperarDatosLaborales() As DataRow
        'Se rescatan los datos curriculares para el empleado
        Return (empleadosDS.recuperaDatosLaborales(Me.ID))
    End Function
    Private Function recuperarDatoLaboralHistorico(ByVal idPeriodoHistorico As Integer) As DataRow
        'Se rescatan los datos curriculares para el empleado
        Return (empleadosDS.recuperaDatoLaboralHistorico(Me.ID, idPeriodoHistorico))
    End Function

    Private Function recuperarDatosAcademicos() As DataView
        'Se rescatan los datos curriculares para el empleado
        Return (empleadosDS.recuperaDatosAcademicos(Me.ID))
    End Function

    Public Function recuperaDatosAntecedenteBinario(ByVal empleadoId As Integer) As DataView
        Return empleadosDS.recuperarAntecedenteBinario(empleadoId)
    End Function

    Private Function recuperarDatosItemes(ByVal idItem As Integer, ByVal idPeriodo As Integer, ByVal tipoProceso As String) As DataView
        'Se rescatan los items asociados al periodoo
        Return (empleadosDS.recuperaDetalleItemes(idItem, idPeriodo, tipoProceso))
    End Function
    Public Function recuperarDatosItemesRelacionados(ByVal idItem As Integer) As DataView
        'Se rescatan los items asociados al periodoo
        Return (empleadosDS.recuperaDetalleItemesRelacionados(idItem))
    End Function
    Private Function recuperarDatosArchivoPlanoRemuneracionLiquida(ByVal idPeriodo As Integer, ByVal tipoProceso As Integer) As DataView
        Return (empleadosDS.recuperaDetalleArchivoPlanoRemuneracionLiquida(idPeriodo, tipoProceso))
    End Function
    Private Function recuperarDatosRemuneracionLiquida(ByVal idPeriodo As Integer, ByVal tipoProceso As Integer) As DataView
        Return (empleadosDS.recuperaDetalleRemuneracionLiquida(idPeriodo, tipoProceso))
    End Function
    Private Function recuperarDatosCargasFamiliaresActualizaFichaEmpleado() As DataView
        'Se rescatan los items asociados al periodoo
        Return (empleadosDS.recuperaCargasFamiliaresActualizaFichaEmpleado())
    End Function

    Private Function recuperarDatosItemesEmpleadoPeriodo(ByVal idEmpleado As Integer, ByVal idPeriodo As Integer, ByVal tipoProceso As String) As DataView
        'Se rescatan los items asociados al periodoo
        Return (empleadosDS.recuperaDetalleItemesEmpladoPeriodo(idEmpleado, idPeriodo, tipoProceso))
    End Function
    Private Function recuperarDatosItemesEmpleadoPeriodo(ByVal idEmpleado As Integer, ByVal idPeriodo As Integer, ByVal tipoProceso As String, ByVal itemsID As Array) As DataView
        'Se rescatan los items asociados al periodoo
        Return (empleadosDS.recuperaDetalleItemesEmpladoPeriodo(idEmpleado, idPeriodo, tipoProceso, itemsID))
    End Function
    Private Function recuperarMarcasControlAcceso(ByVal idEmpleado As Integer, ByVal fechaInicial As Date, ByVal fechaFinal As Date) As DataView
        'Se rescatan los items asociados al periodoo
        Return (empleadosDS.recuperaMarcasControlAceeso(idEmpleado, fechaInicial, fechaFinal))
    End Function
    Private Function recuperarReliquidacionEmpleado(ByVal idEmpleado As Integer, ByVal idPeriodo As Integer, ByVal tipoProceso As String) As DataView
        'Se rescatan los items asociados al periodo
        Return (empleadosDS.recuperaDetalleReliquidacionEmpleado(idEmpleado, idPeriodo, tipoProceso))
    End Function

    Private Function recuperarDatosVidaLaboral(ByVal idEmpleado As Integer) As DataView
        'Se rescatan la hoja de vida laboral
        Return (empleadosDS.recuperaDetalleVidaLaboral(idEmpleado))
    End Function
    Private Function recuperarDatosEUS(ByVal idEus As Integer) As DataView
        'Se rescatan todos los registros de escala unica de sueldos
        Return (empleadosDS.recuperaDetalleEUS(idEus))
    End Function
    Private Function recuperarEmpleadoEnviadosADexon() As DataView
        'Se rescatan todos los registros de escala unica de sueldos
        Return (empleadosDS.recuperarEmpleadosHonorariosParaEnviarADexon)
    End Function
    Private Function recuperarDatosReajusteEUS(ByVal idEus As Integer) As DataView
        'Se rescatan todos los registros de escala unica de sueldos
        Return (empleadosDS.recuperaDetalleReajusteEUS(idEus))
    End Function
    Private Function recuperarDatosFichaIntranet() As DataView
        'Se rescatan los items asociados al periodoo
        Return (empleadosDS.recuperaDatosFichaIntranet())
    End Function
    Public Function eliminarLiquidacionEmpleado(ByVal idPeriodo As Integer, ByVal idEmpleado As Integer, ByVal tipoProceso As String) As Boolean
        Try
            Return empleadosDS.eliminaLiquidacioneEmpleado(idPeriodo, idEmpleado, tipoProceso)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function recuperarDatosEUSEmpleado(ByVal empleado As BusinessRules.Empleado, _
                                          ByVal idCalJuridica As Integer, _
                                          ByVal idGrado As Integer, _
                                          ByVal idClasifEmpleado As Integer, _
                                          ByVal numeroBienios As Integer, _
                                          ByVal idAfp As Integer, _
                                          ByVal idIsapre As Integer, _
                                          ByVal parametros As Periodo) As Boolean
        'Dim parametros As Periodo
        'parametros = New Periodo

        If recuperarMontoAsignacionEmpleado(idCalJuridica, idGrado, idClasifEmpleado) Then
            'Monto sueldo base
            empleado.datosRemuneracion.sueldoBase = empleado.datosEUS.sueldoBase
            'Monto resposabilidad superior
            empleado.datosRemuneracion.valorAsignacionResposabilidad = empleado.datosEUS.asigResponsabilidadSuperior
            'Monto por concepto según función desempeñada
            empleado.datosRemuneracion.valorAsignacionLey19185Art18 = empleado.datosEUS.asigLey19185Art18
            empleado.datosRemuneracion.anno = empleado.datosEUS.anno

            'Comprueba si corresponde valores por concepto de asignacion profesional
            If empleado.datosEUS.esProfesional Then
                'Monto ley 18.717 para profesional
                empleado.datosRemuneracion.valorAsignacionLey18717 = empleado.datosEUS.asigLey18717ConAsigProfesional
                'Monto asignación para profesional ley 19.185 art.19
                empleado.datosRemuneracion.valorAsignacionProfesional = empleado.datosEUS.asigProfesionalLey19185Art19
            Else
                'Monto ley 18.717 para NO profesional
                empleado.datosRemuneracion.valorAsignacionLey18717 = 0
                'Monto asignación para NO profesional ley 19.185 art.19
                empleado.datosRemuneracion.valorAsignacionProfesional = 0
            End If

            'Comprueba el tipo de institución previsional
            Dim tipoSistemaPrev As String = ""
            tipoSistemaPrev = empleadosDS.recuperaTipoSistemaPrevisional("SELECT SISTEMA_PREV_ALIAS FROM " & Vistas.VW_TABLA_AFP & " WHERE AFP_ID = " & idAfp)
            If tipoSistemaPrev = "AFP" Then
                'Monto bonificación ley 18.675 art.10 compensatoria pensiones AFP
                empleado.datosRemuneracion.valorAsignacionLey18675Art10 = empleado.datosEUS.bonoLey18675Art10
                empleado.datosRemuneracion.valorAsignacionLey18675Art11 = 0
            Else
                If tipoSistemaPrev = "INP" Then
                    'Monto bonificación ley 18.675 art.11 compensatoria pensiones INP
                    empleado.datosRemuneracion.valorAsignacionLey18675Art11 = empleado.datosEUS.bonoLey18675Art11
                    empleado.datosRemuneracion.valorAsignacionLey18675Art10 = empleado.datosEUS.bonoLey18675Art10
                Else
                    empleado.datosRemuneracion.valorAsignacionLey18675Art10 = 0
                    empleado.datosRemuneracion.valorAsignacionLey18675Art11 = 0
                End If
            End If

            'Comprueba el tipo institución de salud
            tipoSistemaPrev = ""
            tipoSistemaPrev = empleadosDS.recuperaTipoSistemaPrevisional("SELECT SISTEMA_PREV_ALIAS FROM " & Vistas.VW_TABLA_ISAPRE & " WHERE ISAPRE_ID = " & idIsapre)
            If tipoSistemaPrev = "ISA" Or tipoSistemaPrev = "FON" Then
                'Monto bonificación ley 18.566 compensatria salud
                empleado.datosRemuneracion.valorAsignacionLey18566 = empleado.datosEUS.bonoLey18566
            Else
                empleado.datosRemuneracion.valorAsignacionLey18566 = 0
            End If

            'Correspionde aplicar Ley 3.551
            If empleado.datosEUS.aplicaLey3551 Then
                empleado.datosRemuneracion.valorLey3551 = empleado.datosEUS.asigLey3551
            Else
                empleado.datosRemuneracion.valorLey3551 = 0
            End If

            'Calcula gasto representación
            If empleado.datosEUS.aplicaGastoRepresentacion = 1 Then
                empleado.datosRemuneracion.valorGastoRepresentacion = empleado.datosEUS.gastoRepresentacion
            Else
                empleado.datosRemuneracion.valorGastoRepresentacion = 0
            End If

            'Calculo asignacion antiguedad, solo para efecto calculo incremento previsional
            Dim montoAsigAntiguedad As Integer
            montoAsigAntiguedad = CType(Math.Round(empleado.datosRemuneracion.sueldoBase * (2 / 100) * numeroBienios, 0), Integer)
            empleado.datosRemuneracion.montoBienio = montoAsigAntiguedad

            'Calculo incremento previsional DL 3501 año 1980
            Dim factor As Decimal = parametros.porcentajeIncrementoPrevDL3501 / 100
            Dim total As Decimal = (empleado.datosRemuneracion.sueldoBase + montoAsigAntiguedad)
            empleado.datosRemuneracion.valorIncrementoPrevisionalDL3501 = CType(Math.Round(total * factor, 0), Integer)

            'Calculo asignacion zona
            If parametros.aplicaAsignacionZona = True Then
                empleado.datosRemuneracion.montoAsignacionZona = CInt(empleado.recuperarMontosAsignacionesZona(empleado.datosRemuneracion.zonaID, parametros.ID, empleado.datosRemuneracion.sueldoBase))
            End If

            Return True
        End If
        Return False
    End Function
    Public Function recuperarTipoDocumento() As DataView
        Return empleadosDS.recuperarTipoDocumento
    End Function
    Public Function recuperarTipoSistemaPrevisional(ByVal sql As String) As String
        Dim tipoSisPrevisional As String
        tipoSisPrevisional = empleadosDS.recuperaTipoSistemaPrevisional(sql)
        Return tipoSisPrevisional
    End Function
    Public Function recuperarLiquidacionEmpleadoItem(ByVal idEmpleado As Integer, ByVal idItem As Integer, ByVal idPeriodo As Integer, ByVal tipoProceso As String) As Integer
        Return empleadosDS.recuperaLiquidacionEmpleadoItem(idEmpleado, idItem, idPeriodo, tipoProceso)
    End Function
    Public Function recuperarItemes() As Array
        Dim itemID As Array
        itemID = empleadosDS.recuperaItemes()
        Return itemID
    End Function
    Public Function obtenerInstitucionPrevisionalActual(ByVal idEmpleado As Integer) As Integer
        Return empleadosDS.obtieneInstitucionPrevisionalActual(idEmpleado)
    End Function
    Public Function obtenerInstitucionSaludActual(ByVal idEmpleado As Integer) As Integer
        Return empleadosDS.obtieneInstitucionSaludActual(idEmpleado)
    End Function

    Public Function recuperarHorasAprobadas(ByVal numeroMemorandum As Integer, ByVal Año As Integer, ByVal Mes As Integer, ByVal DeptoId As Integer) As DataView
        Return empleadosDS.recuperaAprobacionHora(numeroMemorandum, Año, Mes, DeptoId)
    End Function

    Public Function recuperarHorasAprobadasPorDepto(ByVal DeptoId As Integer, ByVal Año As Integer) As DataView
        Return empleadosDS.recuperaAprobacionHoraPorDepto(DeptoId, Año)
    End Function

    Public Function recuperarHorasAprobadasPorEmpleado(ByVal EmpleadoId As Integer, ByVal Año As Integer, ByVal Mes As Integer) As String
        Return empleadosDS.recuperaAprobacionHoraPorEmpleado(EmpleadoId, Año, Mes)
    End Function
    Public Function recuperarMontosAsignacionesZona(ByVal ZonaId As Integer, ByVal PeriodoId As Integer, sueldoBase As Integer) As Decimal
        Return empleadosDS.recuperaMontosAsignacionesZona(ZonaId, PeriodoId, sueldoBase)
    End Function

    Public Function recuperarMontoAsignacionEmpleado(ByVal calidadJuridicaID As Integer, ByVal gradoID As Integer, ByVal clasificacionEmpleadoID As Integer) As Boolean
        'Se rescatan los montos que estan asociados al empleado
        'según calidad juridica, grado y clasificacion del empleado
        Dim eusDR As DataRow
        Dim eusDT As DataTable
        eusDT = empleadosDS.recuperaMontosAsignacionesEmpleado(calidadJuridicaID, gradoID, clasificacionEmpleadoID)
        If eusDT Is Nothing Then
            Return False
        Else
            For Each eusDR In eusDT.Rows
                Me.datosEUS.sueldoBase = CType(eusDR("SUELDO_BASE"), Integer)
                Me.datosEUS.asigProfesionalLey19185Art19 = CType(eusDR("ASIG_PROFESIONAL_LEY19185_ART19"), Integer)
                Me.datosEUS.asigResponsabilidadSuperior = CType(eusDR("ASIG_RESPONSABILIDAD_SUPERIOR"), Integer)
                Me.datosEUS.asigLey19185Art18 = CType(eusDR("ASIG_LEY19185_ART18"), Integer)
                Me.datosEUS.asigLey18717ConAsigProfesional = CType(eusDR("ASIG_LEY18717_CON_ASIG_PROFESIONAL"), Integer)
                Me.datosEUS.asigLey18717SinAsigProfesional = CType(eusDR("ASIG_LEY18717_SIN_ASIG_PROFESIONAL"), Integer)
                Me.datosEUS.bonoLey18675Art10 = CType(eusDR("BONO_LEY18675_ART10"), Integer)
                Me.datosEUS.bonoLey18675Art11 = CType(eusDR("BONO_LEY18675_ART11"), Integer)
                Me.datosEUS.bonoLey18566 = CType(eusDR("BONO_LEY18566"), Integer)
                Me.datosEUS.aplicaLey3551 = CType(eusDR("APLICA_LEY3551"), Boolean)
                Me.datosEUS.asigLey3551 = CType(eusDR("ASIG_LEY3551"), Integer)
                Me.datosEUS.aplicaGastoRepresentacion = CType(eusDR("APLICA_GASTO_REPRESENTACION"), Byte)
                Me.datosEUS.gastoRepresentacion = CType(eusDR("GASTO_REPRESENTACION"), Integer)
                Me.datosEUS.esProfesional = CType(eusDR("ES_PROFESIONAL"), Boolean)
                Me.datosEUS.anno = CType(eusDR("ANO"), String)
            Next
            Return True
        End If
    End Function
    Private Function recuperarDatosBonoModernizacion(ByVal anno As Integer) As DataView
        'Se rescatan los items asociados al periodoo
        Return (empleadosDS.recuperaDatosBonoModernizacion(anno))
    End Function
    Public Function calculaFechaTerminoEventoAdministrativo(ByVal diasSolicitados As Decimal, ByVal fechaInicio As Date) As Date
        Try
            Return empleadosDS.calcularFechaTerminoEventoAdministrativo(diasSolicitados, fechaInicio)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function calculaFechaRetornoEventoAdministrativo(ByVal fechaInicio As Date) As Date
        Try
            Return empleadosDS.calcularFechaRetornoEventoAdministrativo(fechaInicio)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function buscaFechaFestivo(ByVal fecha As Date) As Integer
        Try
            Return empleadosDS.buscaFechaFestivo(fecha, 0)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function generarArchivoPlanoImposiciones(ByVal tipoPago As String, ByVal idPeriodo As Integer, ByVal valorUFMesActual As Decimal, ByVal valorUfMesAnterior As Decimal, ByVal topeImponible As Decimal) As Boolean
        Return (empleadosDS.generaArchivoPlanoImposiciones105Campos(tipoPago, idPeriodo, valorUFMesActual, valorUfMesAnterior, topeImponible))
    End Function
    Public Function crearAntecedenteLaboralParaBonoModernizacion(ByVal idPeriodo As Integer, ByVal idEmpleado As Integer) As Boolean
        Try
            Return empleadosDS.crearEmpleadoLaboralParaProcesoBonoModenizacion(idPeriodo, idEmpleado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function elimnaLiquidacionSinDetalle(ByVal idPeriodo As Integer) As Boolean
        Try
            Return empleadosDS.elimnaLiquidacionSinDetalle(idPeriodo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function crearEmpleadoBonoModernizacion(ByVal idEmpleado As Integer, ByVal anno As Integer, _
                                                   ByVal dias As Integer, ByVal baseBono As Decimal, _
                                                   ByVal institucional As Decimal, ByVal colectivo As Decimal, _
                                                   ByVal fechaIngreso As Date, ByVal total As Decimal) As Boolean
        Try
            Return empleadosDS.crearEmpleadoBonoModernizacion(idEmpleado, anno, dias, baseBono, institucional, colectivo, fechaIngreso, total)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function generarPorcentajesBonoModernizacion(ByVal anno As Integer, ByVal porcentajeBase As Decimal, ByVal porcentajeInstitucional As Decimal, ByVal porcentajeColectivo As Decimal) As Boolean
        Try
            empleadosDS.generaPorcentajesEmpleadoBonoModernizacion(anno, porcentajeBase, porcentajeInstitucional, porcentajeColectivo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
        Return True
    End Function
    Public Function generarEmpleadoPorcentajesBonoModernizacion(ByVal idEmpleado As Integer, ByVal anno As Integer, ByVal porcentajeBase As Decimal, ByVal porcentajeInstitucional As Decimal, ByVal porcentajeColectivo As Decimal, ByRef rtnDias As Integer, ByRef rtnBase As Decimal, ByRef rtnInstitucional As Decimal, ByRef rtnColectivo As Decimal) As Boolean
        Try
            empleadosDS.generaEmpleadoPorcentajesBonoModernizacion(idEmpleado, anno, porcentajeBase, porcentajeInstitucional, porcentajeColectivo, rtnDias, rtnBase, rtnInstitucional, rtnColectivo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Public Function generarItemsBonoModernizacion(ByVal idEmpleado As Integer, ByVal idPeriodoActual As Integer, _
                                                  ByVal anoProceso As Integer, ByVal mesProceso As Integer, _
                                                  ByVal IDitemBonoDesempenoMesActual As Integer, ByVal IDitemBonoDesempenoMes1 As Integer, _
                                                  ByVal IDitemBonoDesempenoMes2 As Integer, ByVal IDitemBonoLey19553Art8MesActual As Integer, _
                                                  ByVal IDitemBonoLey19553Art8Mes1 As Integer, ByVal IDitemBonoLey19553Art8Mes2 As Integer, _
                                                  ByVal IDitemBonoDsctoBienestarMes1 As Integer, ByVal IDitemBonoDsctoBienestarMes2 As Integer, _
                                                  ByVal porcentajeDesctoBienestar As Decimal, ByVal IDafp As Integer, ByVal IDisapre As Integer, _
                                                  ByVal porcentajeBase As Decimal, ByVal porcentajeInstitucional As Decimal, _
                                                  ByVal porcentajeColectivo As Decimal, ByVal porcentajeTotal As Decimal, _
                                                  ByVal idItemBonoDistBase As Integer, ByVal idItemBonoDistInstitucional As Integer, _
                                                  ByVal idItembonoDistColectivo As Integer, ByVal empleado As Empleado, _
                                                  ByVal tipoProceso As String, ByVal tipoProcesoRemuneacionActual As String, _
                                                  ByVal IDItemAsigLey19863Mes1 As Integer, ByVal IDItemAsigLey19863Mes2 As Integer, _
                                                  ByVal IDItemAsigLey19863MesActual As Integer, ByVal generaItemBase As Boolean, _
                                                  ByRef montoBonoDesempeno As Integer, ByRef montoBonoLey19553Art8 As Integer, _
                                                  ByVal aplicaAsignacionZona As Boolean, ByRef MontoZonaExtrema40 As Integer, _
                                                  ByRef MontoZonaExtrema60 As Integer, ByRef MontoBonoZonaExtrema As Integer) As Boolean

        Try
            Dim origen As Integer = Comun.TiposDeDatos.TipoOrigenItem.BONO_MODERNIZACION
            Dim sql As String
            Dim idPeriodoAnterior As Integer
            Dim mesOld As Integer = mesProceso
            Dim items(,) As Integer = {{IDitemBonoDesempenoMes1, IDitemBonoLey19553Art8Mes1, IDItemAsigLey19863Mes1}, _
                                       {IDitemBonoDesempenoMes2, IDitemBonoLey19553Art8Mes2, IDItemAsigLey19863Mes2}, _
                                       {IDitemBonoDesempenoMesActual, IDitemBonoLey19553Art8MesActual, IDItemAsigLey19863MesActual}}


            'Elimina las asignaciones correspondiente a los dos procesos anteriores
            Dim i As Integer
            For i = 1 To 2
                mesOld -= 1
                sql = "SELECT PERIODO_ID" & _
                      " FROM RH_REM_PERIODO" & _
                      " WHERE ANO=" & anoProceso & _
                      " AND MES=" & mesOld
                idPeriodoAnterior = empleadosDS.Busca(sql)
                EliminarMovimientoMensualEmpleado(idPeriodoAnterior, idEmpleado, origen, tipoProceso)
            Next i


            mesOld = mesProceso - 2
            Dim paramMensual As Periodo
            Dim periodoDT As DataTable = Nothing
            Dim filaPeriodo As Data.DataRow = Nothing
            Dim montoDistribuidoBase, montoDistribuidoInstitucional, montoDistribuidoColectivo As Decimal
            Dim totalMontoDistribuidoColectivo, totalMontoDistribuidoInstitucional, TotalMontoDistribuidoBase As Decimal

            'Genera items correspondiente a los dos meses historicos mas el actual y los asignados el periodo vigente
            For i = 0 To 2
                paramMensual = New Periodo(anoProceso, mesOld)
                montoDistribuidoBase = 0
                montoDistribuidoInstitucional = 0
                montoDistribuidoColectivo = 0
                If validaEstadoEmpleadoBonoModernizacion(empleado, paramMensual) Then
                    empleadosDS.generaItemsBonoModernizacion(idEmpleado, idPeriodoActual, items(i, 0), items(i, 1), _
                                                            porcentajeBase, porcentajeInstitucional, porcentajeColectivo, _
                                                            paramMensual.topeImponible1, paramMensual.UF, _
                                                            paramMensual.itemTotalImponible1, paramMensual.ID, _
                                                            montoDistribuidoBase, montoDistribuidoInstitucional, montoDistribuidoColectivo, _
                                                            paramMensual.ufMesAnterior, tipoProceso, tipoProcesoRemuneacionActual, _
                                                            empleado.datosRemuneracion.porcentajeLey19863, items(i, 2), generaItemBase, montoBonoDesempeno, _
                                                            montoBonoLey19553Art8, aplicaAsignacionZona, MontoZonaExtrema40, MontoZonaExtrema60, MontoBonoZonaExtrema)
                End If
                mesOld += 1
                TotalMontoDistribuidoBase += montoDistribuidoBase
                totalMontoDistribuidoInstitucional += montoDistribuidoInstitucional
                totalMontoDistribuidoColectivo += montoDistribuidoColectivo
            Next i


            'Distribuye asignacion desempeño según porcentaje colectivo
            If totalMontoDistribuidoColectivo > 0 Then
                empleadosDS.InsertaEmpleadoMovimientoMensual(idPeriodoActual, idItembonoDistColectivo, idEmpleado, 0, 0, origen, CInt(totalMontoDistribuidoColectivo), tipoProceso)
            End If

            'Distribuye asignacion desempeño según porcentaje institucional
            If totalMontoDistribuidoInstitucional > 0 Then
                empleadosDS.InsertaEmpleadoMovimientoMensual(idPeriodoActual, idItemBonoDistInstitucional, idEmpleado, 0, 0, origen, CInt(totalMontoDistribuidoInstitucional), tipoProceso)
            End If

            'Distribuye asignacion desempeño según porcentaje base
            If TotalMontoDistribuidoBase > 0 Then
                empleadosDS.InsertaEmpleadoMovimientoMensual(idPeriodoActual, idItemBonoDistBase, idEmpleado, 0, 0, origen, CInt(TotalMontoDistribuidoBase), tipoProceso)
            End If


            'Genera items correspondiente a los dos proecsos historicos y los asigna a los respectivos meses históricos
            mesOld = mesProceso - 2
            For i = 0 To 1
                paramMensual = New Periodo(anoProceso, mesOld)
                If validaEstadoEmpleadoBonoModernizacion(empleado, paramMensual) Then
                    empleadosDS.generaItemsBonoModernizacion(idEmpleado, paramMensual.ID, items(i, 0), items(i, 1), _
                                                            porcentajeBase, porcentajeInstitucional, porcentajeColectivo, _
                                                            paramMensual.topeImponible1, paramMensual.UF, _
                                                            paramMensual.itemTotalImponible1, paramMensual.ID, _
                                                             0, 0, 0, _
                                                            paramMensual.ufMesAnterior, tipoProceso, Comun.TipoProceso.NORNAL_PLANTA_CONTRATA, empleado.datosRemuneracion.porcentajeLey19863, _
                                                            items(i, 2), generaItemBase, montoBonoDesempeno, montoBonoLey19553Art8, aplicaAsignacionZona, MontoZonaExtrema40, MontoZonaExtrema60, MontoBonoZonaExtrema)
                End If
                mesOld += 1
            Next i


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Public Function generaItemsBonoModernizacion(ByVal idEmpleado As Integer, ByVal idPeriodoActual As Integer, _
                                             ByVal IDitemBonoDesempeno As Integer,
                                             ByVal IDitemBonoLey19553Art8 As Integer, _
                                             ByVal porcentajeBase As Decimal, _
                                             ByVal porcentajeInstitucional As Decimal, _
                                             ByVal porcentajeColectivo As Decimal, _
                                             ByVal topeImponible As Decimal, _
                                             ByVal UF As Decimal, ByVal itemTotalImponible As Integer, _
                                             ByVal idPeriodoProceso As Integer, _
                                             ByVal montoDistribuidoBase As Decimal, _
                                             ByVal montoDistribuidoInstitucional As Decimal, _
                                             ByVal montoDistribuidoColectivo As Decimal, _
                                             ByVal UFMesAnterior As Decimal, _
                                             ByVal tipoProceso As String, _
                                             ByVal tipoProcesoRemuneracionActual As String, _
                                             ByVal porcentajeLey19863 As Integer, _
                                             ByVal IDItemLey19863 As Integer,
                                             ByVal empleado As Empleado, _
                                             ByVal paramMensual As Periodo, _
                                             ByVal generaItemBase As Boolean, _
                                             ByRef montoBonoDesempeno As Integer, _
                                             ByRef montoBonoLey19553Art8 As Integer, _
                                             ByVal aplicaAsignacionZona As Boolean, _
                                             ByRef MontoZonaExtrema40 As Integer, _
                                             ByRef MontoZonaExtrema60 As Integer, _
                                             ByRef MontoBonoZonaExtrema As Integer) As Boolean


        If validaEstadoEmpleadoBonoModernizacion(empleado, paramMensual) Then
            Return empleadosDS.generaItemsBonoModernizacion(idEmpleado, idPeriodoActual, IDitemBonoDesempeno, IDitemBonoLey19553Art8, _
                                                    porcentajeBase, porcentajeInstitucional, porcentajeColectivo, _
                                                    topeImponible, UF, _
                                                    itemTotalImponible, idPeriodoProceso, _
                                                    0, 0, 0, _
                                                    UFMesAnterior, tipoProceso, tipoProcesoRemuneracionActual, porcentajeLey19863, IDItemLey19863, generaItemBase, _
                                                    montoBonoDesempeno, montoBonoLey19553Art8, aplicaAsignacionZona, _
                                                    MontoZonaExtrema40, MontoZonaExtrema60, MontoBonoZonaExtrema)

        End If

    End Function



    Public Function validaEstadoEmpleadoBonoModernizacion(ByVal empleado As Empleado, ByVal paramMensual As Periodo) As Boolean
        Dim procesar As Boolean = True
        Dim fechaMesInicio, fechaMesFinal As Date
        Dim diasMes As Integer = Date.DaysInMonth(paramMensual.ano, paramMensual.mes)
        fechaMesInicio = New Date(CInt(paramMensual.ano), paramMensual.mes, 1)
        fechaMesFinal = New Date(CInt(paramMensual.ano), paramMensual.mes, diasMes)
        If empleado.datosLaborales.motivoRetiroID > 0 Then
            If empleado.estado = TipoEstado.INACTIVO And (empleado.datosLaborales.fechaRetiro >= fechaMesInicio And empleado.datosLaborales.fechaRetiro <= fechaMesFinal) And empleado.datosLaborales.fechaRetiro < fechaMesFinal Then
                procesar = False
            Else
                If empleado.estado = TipoEstado.ACTIVO And (empleado.datosLaborales.fechaRetiro >= fechaMesInicio And empleado.datosLaborales.fechaRetiro <= fechaMesFinal) And empleado.datosLaborales.fechaRetiro < fechaMesFinal Then
                    procesar = False
                End If
            End If
        ElseIf empleado.datosLaborales.antecedenteLaboralID = 0 Then
            procesar = False
        End If
        'If empleado.estado = TipoEstado.INACTIVO And (empleado.datosLaborales.motivoRetiroID > 0) And (empleado.datosLaborales.fechaRetiro >= fechaMesInicio And empleado.datosLaborales.fechaRetiro <= fechaMesFinal) And empleado.datosLaborales.fechaRetiro < fechaMesFinal Then
        'procesar = False
        'End If
        Return procesar
    End Function
    Public Function diasTrabajados(ByVal periodo As Periodo, ByVal tipoProceso As String) As Integer
        Dim conn As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        Dim cantidadDiasTrabajados As Integer = periodo.cantidadDiasMes

        conn.ConnectionString = Comun.ArgoConfiguracion.ConnectionString
        Try
            conn.Open()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        Try
            cmd.Connection = conn
            cmd.CommandText = "SELECT TOP 1 ISNULL(CANTIDAD,0) AS CANTIDAD FROM RH_REM_MOVIMIENTO_MENSUAL WHERE EMPLEADO_ID=@EMPLEADO_ID AND PERIODO_ID=@PERIODO_ID AND ITEM_ID=@ITEM_ID AND TIPO_PROCESO=@TIPO_PROCESO"

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@EMPLEADO_ID"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.Int
            prm.Value = Me.ID
            cmd.Parameters.Add(prm)

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@PERIODO_ID"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.Int
            prm.Value = periodo.ID
            cmd.Parameters.Add(prm)

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@ITEM_ID"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.Int
            prm.Value = periodo.itemDiasTrabajados
            cmd.Parameters.Add(prm)

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@TIPO_PROCESO"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.VarChar
            prm.Value = tipoProceso
            cmd.Parameters.Add(prm)

            Dim dr As SqlClient.SqlDataReader = cmd.ExecuteReader()
            While dr.Read
                cantidadDiasTrabajados = CType(dr("CANTIDAD"), Integer)
            End While
            Return (cantidadDiasTrabajados)
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            conn.Close()
            cmd = Nothing
            conn = Nothing
        End Try

    End Function

    Public Function diasTrabajadosSegunLiquidacion(ByVal periodo As Periodo, ByVal tipoProceso As String) As Integer
        Dim conn As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        Dim cantidadDiasTrabajados As Integer = periodo.cantidadDiasMes

        conn.ConnectionString = Comun.ArgoConfiguracion.ConnectionString
        Try
            conn.Open()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        Try
            cmd.Connection = conn
            cmd.CommandText = "SELECT TOP 1 ISNULL(DIAS_TRABAJADOS,0) AS CANTIDAD FROM RH_REM_LIQUIDACION_ENC WHERE EMPLEADO_ID=@EMPLEADO_ID AND PERIODO_ID=@PERIODO_ID AND TIPO_CALCULO=@TIPO_PROCESO"

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@EMPLEADO_ID"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.Int
            prm.Value = Me.ID
            cmd.Parameters.Add(prm)

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@PERIODO_ID"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.Int
            prm.Value = periodo.ID
            cmd.Parameters.Add(prm)

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@TIPO_PROCESO"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.VarChar
            prm.Value = tipoProceso
            cmd.Parameters.Add(prm)

            Dim dr As SqlClient.SqlDataReader = cmd.ExecuteReader()
            While dr.Read
                cantidadDiasTrabajados = CType(dr("CANTIDAD"), Integer)
            End While
            Return (cantidadDiasTrabajados)
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            conn.Close()
            cmd = Nothing
            conn = Nothing
        End Try

    End Function

    Public Function movimientosDelPeriodo(ByVal idPeriodo As Integer, ByVal tipoItem As Comun.TiposDeDatos.TipoItem, ByVal tipoProceso As String, ByVal incluyeCalculo As Integer) As DataTable
        Return (empleadosDS.recuperaMovimientosPeriodoEmpleado(idPeriodo, tipoItem, Me.ID, tipoProceso, incluyeCalculo))
    End Function

    Public Function recuperarAntecedentesPrevisionales() As DataView
        'Se rescatan los datos previsionales del empleado
        Return (empleadosDS.recuperaAntecedentesPrevisionales(Me.ID))
    End Function

    Public Function recuperarAntecedentePrevisional() As DataRow
        'Se rescatan los datos previsionales del empleado
        Return (empleadosDS.recuperaAntecedentePrevisional(Me.ID))
    End Function

    Public Function recuperarAntecedentePresupuestoAnualHonorario() As DataRow
        'Se rescatan los datos presupuesto anual honorario del empleado
        Return (empleadosDS.recuperaAntecedentePresupuestoAnualHonorario(Me.ID))
    End Function

    Public Function recuperarAntecedenteRemun() As DataRow
        'Se rescatan los datos previsionales del empleado
        Return (empleadosDS.recuperaAntecedenteRemun(Me.ID))
    End Function
    Public Function recuperarAntecedenteRemunHistorico(ByVal idPeriodoHistorico As Integer) As DataRow
        'Se rescatan los datos previsionales del empleado
        Return (empleadosDS.recuperaAntecedenteRemunHistorico(Me.ID, idPeriodoHistorico))
    End Function

    Private Function recuperarAntecedentesAPV() As DataView
        'Se rescatan los datos curriculares para el empleado
        Return (empleadosDS.recuperaAntecedentesAPV(Me.ID))
    End Function
    Public Function recuperarDetallePresupuestoAnualHonorario(ByVal idEmpleado As Integer) As DataView
        'Se rescatan los datos previsionales del empleado
        Return (empleadosDS.recuperaDetallePresupuestoAnualHonorarios(idEmpleado))
    End Function
    Public Function recuperaHistoricoCambiosDetallePresupuestoAnualHonorario(ByVal idEmpleado As Integer) As DataView
        'Se rescatan los ajustes que han sido realizados al presupuesto de un empleado en honorario
        Return (empleadosDS.recuperaHistoricoCambiosDetallePresupuestoAnualHonorario(idEmpleado))
    End Function
    Private Function recuperarAntecedentesAPVHistorico(ByVal idPeriodoHistorico As Integer) As DataView
        'Se rescatan los datos curriculares para el empleado
        Return (empleadosDS.recuperaAntecedentesAPVHistorico(Me.ID, idPeriodoHistorico))
    End Function
    Public Function recuperarAntecedentePrevisionalHistorico(ByVal idPeriodoHistorico As Integer) As DataRow
        'Se rescatan los datos previsionales del empleado
        Return (empleadosDS.recuperaAntecedentePrevisionalHistorico(Me.ID, idPeriodoHistorico))
    End Function
    Public Function recuperarEstructuraOrganicaHistorico(ByVal idPeriodoHistorico As Integer) As DataRow
        'Se rescatan los datos previsionales del empleado
        Return (empleadosDS.recuperaEstructuraOrganicaHistorico(Me.ID, idPeriodoHistorico))
    End Function
    Public Function recuperarEstructuraContableHistorico(ByVal idPeriodoHistorico As Integer) As DataRow
        'Se rescatan los datos previsionales del empleado
        Return (empleadosDS.recuperaEstructuraContableHistorico(Me.ID, idPeriodoHistorico))
    End Function


    Public Function recuperarEstructuraOrganica() As DataRow
        'Se rescatan los datos previsionales del empleado
        Return (empleadosDS.recuperaEstructuraOrganica(Me.ID))
    End Function
    Public Function recuperarEstructuraContable() As DataRow
        'Se rescatan los datos previsionales del empleado
        Return (empleadosDS.recuperaEstructuraContable(Me.ID))
    End Function

    Public Function recuperaSaldoDiasEventoAdmin(ByVal idEmpleado As Integer, ByVal tipoEvento As Integer, ByVal anoProceso As Integer) As DataView
        'Se rescatan los días pendientes del empleado
        Return (empleadosDS.recuperaSaldoDiasEventoAdmin(idEmpleado, tipoEvento, anoProceso))
    End Function
    Public Function recuperaSaldoDiasEmpleadoEventoAdmin(ByVal idEmpleado As Integer, ByVal tipoEvento As Integer, ByVal anoProceso As Integer) As Boolean
        'Se rescatan los días pendientes del empleado
        Dim dv As DataView = empleadosDS.recuperaSaldoDiasEmpleadoEventoAdmin(idEmpleado, tipoEvento, anoProceso)
        If dv.Count > 0 Then
            Me.datosSaldoDiasEventoAdmin.tipoEventoAdminID = CType(dv.Table.Rows(0).Item("TIPO_EVENTO_ADMIN_ID"), Byte)
            Me.datosSaldoDiasEventoAdmin.empleadoID = CType(dv.Table.Rows(0).Item("EMPLEADO_ID"), Integer)
            Me.datosSaldoDiasEventoAdmin.diasPeriodo = CType(dv.Table.Rows(0).Item("DIAS_PERIODO"), Decimal)
            Me.datosSaldoDiasEventoAdmin.diasPeriodoAnterior = CType(dv.Table.Rows(0).Item("DIAS_PERIODO_ANT"), Decimal)
            Me.datosSaldoDiasEventoAdmin.diasAdicionales = CType(dv.Table.Rows(0).Item("DIAS_ADICIONALES"), Decimal)
            Me.datosSaldoDiasEventoAdmin.totalDiasAnual = CType(dv.Table.Rows(0).Item("TOTAL_DIAS_ANUAL"), Decimal)
            Me.datosSaldoDiasEventoAdmin.totalDiasSolicitados = CType(dv.Table.Rows(0).Item("TOTAL_DIAS_SOLICITADOS"), Decimal)
            Me.datosSaldoDiasEventoAdmin.diasPendiente = CType(dv.Table.Rows(0).Item("DIAS_PENDIENTE"), Decimal)
            Me.datosSaldoDiasEventoAdmin.anoProceso = CType(dv.Table.Rows(0).Item("ANO"), Short)
            Me.datosSaldoDiasEventoAdmin.eventoAdminSaldoID = CType(dv.Table.Rows(0).Item("EVENTO_ADMIN_SALDO_ID"), Integer)
            Return True
        End If
        Return False
    End Function
    Public Function recuperaEventosAdministrativos(ByVal idEmpleado As Integer, ByVal tipoEvento As Integer, ByVal anoProceso As Integer) As DataView
        'Se rescatan los días pendientes del empleado
        Return (empleadosDS.recuperarEventosAdministrativos(idEmpleado, tipoEvento, anoProceso))
    End Function
    Public Function recuperaEventosAdministrativosSaldoDias(ByVal anoProceso As Integer) As DataView
        'Se rescatan los días pendientes del empleado
        Return (empleadosDS.recuperarEventosAdministrativosSaldoDias(anoProceso))
    End Function
    Public Function recuperaAnalisisDinamicoLiquidaciones(ByVal anoProceso As Integer, MesInicio As Integer, MesFinal As Integer) As DataView
        'Se rescatan los días pendientes del empleado
        Return (empleadosDS.recuperarAnalisisDinamicoLiquidaciones(anoProceso, MesInicio, MesFinal))
    End Function
    Public Function generaHorasAtraso(ByVal fechaInicio As Date, fechaFinal As Date) As DataTable
        Return (empleadosDS.generarHorasAtraso(fechaInicio, fechaFinal))
    End Function
    Public Function generaHorasExtrasNoRatificadas(ByVal fechaInicio As Date, fechaFinal As Date) As DataTable
        Return (empleadosDS.generarHorasExtrasNoRatificadas(fechaInicio, fechaFinal))
    End Function
    Public Function recuperaAnalisisDinamicoEventosAdministrativos(ByVal anoProceso As Integer, MesInicio As Integer, MesFinal As Integer, SoloActivos As Boolean) As DataView
        'Se rescatan los días pendientes del empleado
        Return (empleadosDS.recuperarAnalisisDinamicoEventosAdministrativos(anoProceso, MesInicio, MesFinal, SoloActivos))
    End Function

    Public Function recuperaAnalisisDinamicoViaticos(ByVal anoProceso As Integer) As DataView
        'Se rescatan los días pendientes del empleado
        Return (empleadosDS.recuperarAnalisisDinamicoViaticos(anoProceso))
    End Function

    Public Function recuperaAnalisisMaestroEmpleadoDetallado(ByVal anoProceso As Integer, MesInicio As Integer, MesFinal As Integer, SoloActivos As Boolean) As DataView
        'Se rescatan los días pendientes del empleado
        Return (empleadosDS.recuperarAnalisisMaestroEmpleadoDetallado(anoProceso, MesInicio, MesFinal, SoloActivos))
    End Function

    Public Function recuperaPeriodoHorasRatificadasVsPagadas(ByVal Año As Integer, ByVal Mes As Integer) As DataView
        'Se rescatan los días pendientes del empleado
        Return (empleadosDS.recuperaDetalleHorasRatificadas(Año, Mes))
    End Function

    Public Function recuperaLicenciaMedicaPorFiltro(ByVal tipoFiltro As Integer, ByVal fechaInicio As Date, ByVal fechaFinal As Date, ByVal EmpleadoId As Integer, ByVal DeptoId As Integer, ByVal InstitucionSalud As Integer) As DataView
        'Se rescatan los días pendientes del empleado
        Return (empleadosDS.recuperarLicenciaMedicaPorFiltro(tipoFiltro, fechaInicio, fechaFinal, EmpleadoId, DeptoId, InstitucionSalud))
    End Function

    Public Function recuperaPeriodoHorasRatificadasVsPagadas(ByVal Año As Integer) As DataView
        'Se rescatan los días pendientes del empleado
        Return (empleadosDS.recuperaDetalleHorasRatificadas(Año))
    End Function
    Public Function recuperaAnalisisCargasFamiliares(ByVal anoProceso As Integer, MesInicio As Integer, MesFinal As Integer, SoloActivos As Boolean) As DataView
        'Se rescatan los días pendientes del empleado
        Return (empleadosDS.recuperarAnalisisCargasFamiliares(anoProceso, MesInicio, MesFinal, SoloActivos))
    End Function
    Public Function recuperaAnalisisMovimientoMensual(ByVal anoProceso As Integer) As DataView
        'Se rescatan los días pendientes del empleado
        Return (empleadosDS.recuperarAnalisisMovimientoMensual(anoProceso))
    End Function
    Public Function recuperaHorasExtrasAprobadasPorAñoMes(ByVal anoProceso As Integer, ByVal mesProceso As Integer) As DataView
        Return (empleadosDS.recuperarHorasExtrasAprobadasPorAñoMes(anoProceso, mesProceso))
    End Function
    Public Function recuperaHorasExtrasPagadasPorPeriodo(ByVal PeriodId As Integer) As DataView
        Return (empleadosDS.recuperarHorasExtrasPagadasPorPeriodo(PeriodId))
    End Function
    Public Function recuperaHorasExtrasCompensadasPorPeriodo(ByVal PeriodId As Integer) As DataView
        Return (empleadosDS.recuperarHorasExtrasCompensadasPorPeriodo(PeriodId))
    End Function
    Public Function recuperaCentralizacionContable(ByVal anoProceso As Integer, MesInicio As Integer, MesFinal As Integer) As DataView
        'Se rescatan los días pendientes del empleado
        Return (empleadosDS.recuperarCentralizacionContable(anoProceso, MesInicio, MesFinal))
    End Function

    Private Function recuperarDatosLicenciaMedica(ByVal idEmpleado As Integer) As DataView
        'Se rescatan los datos licencia medica para el empleado
        Return (empleadosDS.recuperaLicenciaMedica(idEmpleado))
    End Function
    Public Function recuperarLicenciaMedicaInformeGestion(ByVal idEmpleado As Integer) As DataView
        'Se rescatan los datos licencia medica para el empleado
        Return (empleadosDS.recuperaLicenciaMedicaInformeGestion(idEmpleado))
    End Function
    Public Function recuperarLicenciaMedicaInformeGestionPeriodo(ByVal Ano As Integer) As DataView
        'Se rescatan los datos licencia medica para el perido
        Return (empleadosDS.recuperaLicenciaMedicaInformeGestionPeriodo(Ano))
    End Function

    Public Function recuperaMaestroEmpleadoDipres(ByVal anoProceso As Integer, MesInicio As Integer, MesFinal As Integer, SoloActivos As Boolean) As DataView
        Return empleadosDS.recuperaMaestroEmpleadoDipres(anoProceso, MesInicio, MesFinal, SoloActivos)
    End Function


    Private Function recuperarHistoriaEventosAdminEmpleado(ByVal idEmpleado As Integer, ByVal anno As String) As DataView
        'Se rescatan los datos licencia medica para el empleado
        Return (empleadosDS.recuperaHistoriaEventosAdminEmpleado(idEmpleado, anno))
    End Function
    Public Function recuperarSaldoPermisoPaternal() As DataView
        'Se rescatan los datos previsionales del empleado
        Return (empleadosDS.recuperaSaldoPermisoPaternal(Me.ID))
    End Function
    Public Function recuperaEmpleadosActivos() As DataTable
        Return (empleadosDS.recuperarEmpleadosActivos())
    End Function
    Public Function recuperaEmpleadosAutorizarBienios(ByVal periodoId As Integer, ByVal soloEmpleadosActivos As Boolean, ByVal soloRegistrosPendientes As Boolean) As DataTable
        Return (empleadosDS.recuperarEmpleadosAutorizaBienios(periodoId, soloEmpleadosActivos, soloRegistrosPendientes))
    End Function
    Private Function recuperarDatosEstructuraOrganicaEmpleado() As DataView
        'Se rescatan los datos licencia medica para el empleado
        Return (empleadosDS.recuperaDatosEstructuraOrganicaEmpleado(Me.ID))
    End Function
    Private Function recuperarDatosEstructuraContableEmpleado() As DataView
        'Se rescatan los datos licencia medica para el empleado
        Return (empleadosDS.recuperaDatosEstructuraContableEmpleado(Me.ID))
    End Function

    Public Function recuperarEventoAdministrativo() As DataSet
        'Se rescatan los datos del ENCABEZADO del Evento Administrativo
        Return (empleadosDS.recuperaEventoAdministrativo(Me.ID))
    End Function

    Public Function recuperarDetalleEventoAdministrativo(ByVal ID As Integer) As DataView
        'Se rescatan los datos de DETALLE del Evento Administrativo
        Return (empleadosDS.recuperaDetalleEventoAdministrativo(ID))
    End Function
    'Unidad Tiempo: Semestre, Trimestre, etc
    Public Function recuperaDetallePersonalFueraDotacion(ByVal anoProceso As Integer, ByVal unidad_tiempo As Integer) As DataView
        'Se rescatan los días pendientes del empleado
        Return (empleadosDS.recuperaDetallePersonalFueraDotacion(anoProceso, unidad_tiempo))
    End Function

    'Obtiene antecedentes curriculares por departamento
    Public Function recuperaAntecedentesCurricularesPorDepto(ByVal anoProceso As Integer) As DataView
        'Obtiene antecedentes curriculares por departamento
        Return (empleadosDS.recuperaInformacionCurricularPorDepto(anoProceso))
    End Function

    Public Function recuperaCuadroComparativoHonorarios(ByVal anoProceso As Integer) As DataView
        'Se un breve cuadro comparativo de la información laboral y remuneraciones de los honorarios
        Return (empleadosDS.recuperaCuadroComparativoHonorarios(anoProceso))
    End Function

    Public Function recuperaPresupuestoAnualHonorarios(ByVal anoProceso As Integer) As DataView
        'Se obtiene el presupuesto anual de por honorario
        Return (empleadosDS.recuperaPresupuestoAnualHonorarios(anoProceso))
    End Function

    Public Function recuperaPresupuestoDetalladoHonorarios(ByVal anoProceso As Integer) As DataView
        'Se obtiene el presupuesto anual de por honorario
        Return (empleadosDS.recuperaPresupuestoDetalladoHonorarios(anoProceso))
    End Function

    Public Function recuperarNumeroLicenciaEmpleado(ByVal numeroLicencia As String) As Boolean
        'Se rescatan los datos relacioandos al numero de licencia medica continuidad
        Dim licmedDR As DataRow
        licmedDR = empleadosDS.recuperaNumeroLicencia(numeroLicencia)
        If Not licmedDR Is Nothing Then
            Me.datosLicenciaMedica.fechaInicioContinuidad = CType(licmedDR("FECHA_INICIO"), Date)
            Me.datosLicenciaMedica.diasContinuidad = CType(licmedDR("DIAS_LICENCIA"), Integer)
            Me.datosLicenciaMedica.fechaTerminoContinuidad = CType(licmedDR("FECHA_TERMINO"), Date)
            Me.datosLicenciaMedica.licenciaMedicaIDOld = CType(licmedDR("LICENCIA_MEDICA_ID"), Integer)
            Return True
        End If
        Return False
    End Function
    Public Function buscaRutCargaFamiliar(ByVal rutCargaFam As Integer) As String
        Return buscarRutCargaFamiliar(rutCargaFam)
    End Function
    Public Function buscaIdentificadorLiquidacion(ByVal idEmpleado As Integer) As Integer
        Dim sql As String = "SELECT TOP 5 * FROM " & Tablas.RH_REM_LIQUIDACION & " WHERE EMPLEADO_ID=" & idEmpleado & " ORDER BY PERIODO_ID DESC"
        Return (empleadosDS.Busca(sql))
    End Function
    Public Function buscaString(ByVal cmdSQL As String) As String
        Return (empleadosDS.BuscaString(cmdSQL))
    End Function
    Public Function buscaInteger(ByVal cmdSQL As String) As Integer
        Return (empleadosDS.Busca(cmdSQL))
    End Function
    Public Function actualizarTablaImpuestos() As Boolean
        Return (empleadosDS.actualizarTablaImpuestos())
    End Function

    Public Function actualizarDatosCurriculares() As Boolean
        Return (empleadosDS.actualizarDatosCurriculares())
    End Function

    Public Function actualizarDatosHorasExtras() As Boolean
        Return (empleadosDS.actualizarDatosHorasExtras())
    End Function

    Public Function insertarDatoMovimientoMensual(ByVal idPeriodo As Integer, ByVal idItem As Integer, _
                                          ByVal idEmpleado As Integer, ByVal cuotaIni As Short, _
                                          ByVal cuotaFin As Short, ByVal origen As Integer, _
                                          ByVal cantidad As Integer, ByVal tipoProceso As String) As Boolean
        Return empleadosDS.InsertaEmpleadoMovimientoMensual(idPeriodo, idItem, idEmpleado, cuotaIni, cuotaFin, origen, cantidad, tipoProceso)
    End Function

    Public Function insertarEgresoCabecera(ByVal numeroCheque As Integer, ByVal fechaCheque As Date, _
                                        ByVal montoCheque As Integer, ByVal nombreCheque As String, _
                                        ByVal origenEgresoId As Integer, ByVal concepto As String, ByVal organizacionId As Integer) As Integer
        Try
            Return empleadosDS.insertarEgresoCabecera(numeroCheque, fechaCheque, montoCheque, nombreCheque, origenEgresoId, concepto, organizacionId)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function insertarMarcaAssisCAD(ByVal idempleado As Integer, ByVal fechaMarca As Date, _
                                          ByVal horaMarca As Date, _
                                          ByVal valorRetorno As Short) As Integer
        Return empleadosDS.insertaMarcaAssisCAD(idempleado, fechaMarca, horaMarca, valorRetorno)
    End Function
    Public Function actualizaMarcaAssisCAD(ByVal idAsistencia As Integer, ByVal procesaAsistencia As Integer, ByVal valorRetorno As Short) As Integer
        Return empleadosDS.actualizaMarcaAssisCAD(idAsistencia, procesaAsistencia, valorRetorno)
    End Function

    Public Function verificarMarcaAssisCAD(ByVal empleadoID As Integer, ByVal horaMarca As Date, ByVal fechaMarca As Date, ByVal valorRetorno As Short) As Integer
        Return empleadosDS.verificaMarcaAssisCAD(empleadoID, horaMarca, fechaMarca, valorRetorno)
    End Function
    Public Function generaMarcaAssisCAD(ByVal empleadoID As Integer, ByVal ano As Integer, ByVal mes As Integer, ByVal valorRetorno As Short) As Integer
        Return empleadosDS.generaMarcas(ano, mes, empleadoID)
    End Function

    Public Function traspasarMarcasControlAcceso(ByVal ano As Integer, ByVal mes As Integer) As Integer
        Return empleadosDS.traspasaMarcasControlAcceso(ano, mes)
    End Function

    Public Function traspasarControlAsistenciaIntranet(ByVal todosLosEmpleados As Integer, ByVal fechaInicio As Date, ByVal fechaFinal As Date, ByVal empleadoID As Integer) As Integer
        Return empleadosDS.traspasaControlAsistenciaIntranet(todosLosEmpleados, fechaInicio, fechaFinal, empleadoID)
    End Function

    Public Function actualizarMovimientoMensual() As Boolean
        Return (empleadosDS.actualizarDatosItemes())
    End Function

    Public Function actualizarEUS() As Boolean
        Return (empleadosDS.actualizarDatosEUS())
    End Function
    Public Function actualizarDatosBonoModernizacion() As Boolean
        Return (empleadosDS.actualizarDatosBonoModernizacion())
    End Function
    Public Function validaRangoFechaEventoAdministrativo(ByVal fechaInicio As Date, ByVal idEmpleado As Integer, ByVal cantidadDias As Integer) As String
        Return empleadosDS.validaRangoFechaEventoAdministrativo(fechaInicio, idEmpleado, cantidadDias)
    End Function

    Private Function recuperarCargasFamiliares() As DataView
        'Se rescatan los datos previsionales del empleado
        Return (empleadosDS.recuperarCargasFamiliares(Me.ID))
    End Function

    Private Function recuperarCargasFamiliaresSoloGrupoFamiliar() As DataView
        Return (empleadosDS.recuperarCargasFamiliaresSoloGrupoFamiliar(Me.ID))
    End Function

    Private Function recuperarViaticoMaestro(ByVal ID As Integer, Optional ByVal numMemorandum As String = "") As DataRow
        'Se rescatan los datos del encabezado (MEMO)
        Return (empleadosDS.recuperarViaticoMaestro(ID, numMemorandum))
    End Function

    Private Function recuperarViaticosAsignados(ByVal ID As Integer) As DataView
        'Se rescatan llos viáticos asociados un encabezado (MEMO)
        Return (empleadosDS.recuperarViaticosAsignados(ID))
    End Function

    Private Function recuperarViaticos(ByVal idempleado As Integer, ByVal año As Integer, Optional ByVal numMemorandum As String = "") As DataView
        'Se rescatan viáticos asociados a un empleado
        Return (empleadosDS.recuperarViaticos(idempleado, año, numMemorandum))
    End Function
    Private Function buscarRutCargaFamiliar(ByVal rutCargaFam As Integer) As String
        Dim cmdSQL As String = "SELECT RTRIM(RH_PER_EMPLEADO.APELLIDO_PATERNO) " & _
                       " + ' ' + RTRIM(RH_PER_EMPLEADO.APELLIDO_MATERNO) + ' ' + RTRIM(RH_PER_EMPLEADO.NOMBRES) AS NOMBRE_COMPLETO " & _
                       "FROM RH_PER_CARGA_FAMILIAR INNER JOIN " & _
                       "RH_PER_EMPLEADO ON RH_PER_CARGA_FAMILIAR.EMPLEADO_ID = RH_PER_EMPLEADO.EMPLEADO_ID WHERE RH_PER_CARGA_FAMILIAR.RUT_CARGA = " & rutCargaFam & " AND ESTADO_REGISTRO = 1"
        Return empleadosDS.BuscaString(cmdSQL)
    End Function
    Private Function recuperarViaticosResolucion(ByVal idempleado As Integer, ByVal año As Integer, Optional ByVal numResolucion As String = "") As DataView
        'Se rescatan viáticos asociados a un empleado
        Return (empleadosDS.recuperarViaticosResolucion(idempleado, año, numResolucion))
    End Function

    Private Function recuperarHorasExtrasPorPeriodo(ByVal idPeriodo As Integer, ByVal tipoProceso As String) As DataView
        'Se rescatan viáticos asociados a un empleado
        Return (empleadosDS.recuperarHorasExtrasPorPeriodo(idPeriodo, tipoProceso))
    End Function
    Public Function recuperaIdentificadorInsertado(ByVal nombreTabla As String) As Integer
        'Obtiene el IDENTIFICADOR del ultimo registro insertado, se debe identificar la tabla
        'que será consultada.
        Return (empleadosDS.recuperaIdentificador(nombreTabla))
    End Function
    Public Function recuperaIdentificador(ByVal cmdSQL As String) As Integer
        Return CInt((empleadosDS.Busca(cmdSQL)))
    End Function
    Public Function recuperaMaestroEmpleado(ByVal fechaFinalIngreso As Date, ByVal periodoID As Integer) As DataView
        Return (empleadosDS.recuperarMaestroEmpleados(fechaFinalIngreso, periodoID))
    End Function
    Public Function recuperaEndeudamientoEmpleado(ByVal EmpleadoId As Integer, ByVal PeriodoAnalisis As String, ByVal FiltroPorcentaje As Integer) As DataView
        Return empleadosDS.recuperarEndeudamientoEmpleado(EmpleadoId, PeriodoAnalisis, FiltroPorcentaje)
    End Function
    Public Function recuperarHonorariosNoEnviadosTesoreria(ByVal idPeriodo As Integer, ByVal tipoProceso As Integer) As DataView
        Return empleadosDS.recuperarHonorariosNoEnviadosTesoreria(idPeriodo, tipoProceso)
    End Function
    Public Function recuperarHonorariosEnviadosTesoreria(ByVal idPeriodo As Integer, ByVal tipoProceso As Integer) As DataView
        Return empleadosDS.recuperarHonorariosEnviadosTesoreria(idPeriodo, tipoProceso)
    End Function
    Public Function recuperarEmpleadoLiquidacion() As DataView
        Return empleadosDS.recuperarEmpleadoLiquidacion
    End Function
    Public Function recuperaEmpleadoLiquidacionPorPeriodo(EmpleadoId As Integer) As DataView
        Return empleadosDS.recuperaEmpleadoLiquidacionPorPeriodo(EmpleadoId)
    End Function
    Public Function recuperaEmpleadoFichaHistorica(PeriodoId As Integer) As DataView
        Return empleadosDS.recuperaEmpleadoFichaHistorica(PeriodoId)
    End Function
    Public Function recuperaRendicionViaticos(ByVal año As Integer, ByVal estadoCheque As Integer) As DataView
        Return empleadosDS.recuperarRendicionViaticos(año, estadoCheque)
    End Function
    Public Function recuperarRegionesAsigcacionZonas(ByVal PeriodoId As Integer) As DataView
        Return empleadosDS.recuperarRegionesAsignacionZona(PeriodoId)
    End Function
    Public Function enviarHonorariosTesoreria(ByVal idPeriodo As Integer, ByVal tipoProceso As Integer) As Boolean
        Return empleadosDS.EnviarHonorariosTesoreria(idPeriodo, tipoProceso)
    End Function
    Public Function InsertaDatosTesoreria(ByVal EmpleadoId As Integer, ByVal Apellidos As String, ByVal Nombres As String, _
                    ByVal Rut As Integer, ByVal Dv As String, ByVal PeriodoId As Integer, ByVal Monto As Integer, ByVal TipoProceso As String, _
                    ByVal NombreCalidadJuridica As String, ByVal FormaPagoId As Integer, ByVal NombreFormaPago As String, _
                    ByVal NombreDepartamento As String, ByVal GenerarCheque As Boolean, ByVal ChequeEmitido As Boolean, ByVal NumeroCheque As Integer, ByVal NumeroEgreso As Integer, _
                    ByVal FechaCheque As Date, ByVal CalidadJuridicaId As Integer, ByVal ImpresionId As Integer, ByVal EgresoId As Integer, ByVal NumeroCuentaCorriente As Integer) As Boolean
        Return empleadosDS.InsertarDatosTesoreria(EmpleadoId, Apellidos, Nombres, Rut, Dv, PeriodoId, Monto, TipoProceso, NombreCalidadJuridica, FormaPagoId, NombreFormaPago, NombreDepartamento, GenerarCheque, ChequeEmitido, NumeroCheque, NumeroEgreso, FechaCheque, CalidadJuridicaId, ImpresionId, EgresoId, NumeroCuentaCorriente)

    End Function
    Public Function recuperaHonorariosPagoCheque(ByVal idPeriodo As Integer, ByVal tipoProceso As Integer, ByVal incluirSoloCheques As Boolean) As DataView
        Return empleadosDS.recuperarHonorariosPagoCheque(idPeriodo, tipoProceso, incluirSoloCheques)
    End Function
    Public Function recuperaMaestroEmpleadoSuplementarioHonorario(ByVal fechaFinalIngreso As Date) As DataView
        Return (empleadosDS.recuperarMaestroEmpleadosSuplementarioHonorario(fechaFinalIngreso))
    End Function
    Public Function recuperaMaestroEmpleadoSuplementario(ByVal fechaFinalIngreso As Date) As DataView
        Return (empleadosDS.recuperarMaestroEmpleadosSuplementario(fechaFinalIngreso))
    End Function
    Public Function recuperaMaestroEmpleadoHonorarios(ByVal fechaFinalIngreso As Date) As DataView
        Return (empleadosDS.recuperarMaestroEmpleadosHonorarios(fechaFinalIngreso))
    End Function
    Public Function recuperaEmpleadosInactivosconProcesoLiquidacion(ByVal idPeriodo As Integer, ByVal tipoproceso As String) As DataView
        Return (empleadosDS.recuperarEmpleadosInactivosconProcesoLiquidacion(idPeriodo, tipoproceso))
    End Function
    Public Function recuperaCargasFamiliaresConEstado() As DataView
        Return (empleadosDS.recuperaCargasFamiliaresConEstado())
    End Function
    Public Function recuperaValorNumerico(ByVal cmdSQL As String) As Integer
        Return empleadosDS.Busca(cmdSQL)
    End Function
    Public Function recuperaEmpleadosHorasExtrasAtraso(ByVal fechaInicial As Date, ByVal fechaFinal As Date) As DataTable
        Return (empleadosDS.recuperarEmpleadosHorasExtrasAtraso(fechaInicial, fechaFinal))
    End Function
    Public Function actualizarDetalleEventoAdmin() As Boolean
        Return (empleadosDS.actualizarDetalleEventoAdmin())
    End Function
    Public Function actualizarSaldoDiasEventoAdmin() As Boolean
        Dim SaldoDiaDR As DataAccess.DSEmpleado.RH_PER_EVENTO_ADMIN_SALDORow
        Try
            SaldoDiaDR = CType(empleadosDS.Busca(Me.datosSaldoDiasEventoAdmin.eventoAdminSaldoID, Tablas.RH_PER_EVENTO_ADMIN_SALDO, "SELECT * FROM " & Tablas.RH_PER_EVENTO_ADMIN_SALDO), DataAccess.DSEmpleado.RH_PER_EVENTO_ADMIN_SALDORow)
            'Dim empleado As BusinessRules.Empleado = Me
            asignacionCampos(Me, SaldoDiaDR)
            SaldoDiaDR = CType(empleadosDS.Actualiza(SaldoDiaDR, Tablas.RH_PER_EVENTO_ADMIN_SALDO), DataAccess.DSEmpleado.RH_PER_EVENTO_ADMIN_SALDORow)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
        'Return (empleadosDS.actualizarSaldoDiasEventoAdmin())
    End Function

    Public Function actualizarPermisoPaternal() As Boolean
        Return (empleadosDS.actualizarPermisoPaternal())
    End Function

    Public Function actualizarDatosAcademicos() As Boolean
        Return (empleadosDS.actualizarDatosAcademicos())
    End Function
    Public Function actualizarEventoAdmin(ByVal datosEventoAdmin As EEventoAdmin) As Boolean
        Dim EventoAdminDR As DataAccess.Empleados.RH_PER_EVENTO_ADMINRow
        EventoAdminDR = CType(empleadosDS.Busca(datosEventoAdmin.Evento_Administrativo_ID, Tablas.RH_PER_EVENTO_ADMIN, "SELECT * FROM " & Tablas.RH_PER_EVENTO_ADMIN), DataAccess.DSEmpleado.RH_PER_EVENTO_ADMINRow)
        Try
            asignacionCampos(Me, EventoAdminDR)
            EventoAdminDR = CType(empleadosDS.actualizarEventoAdmin(EventoAdminDR), DataAccess.DSEmpleado.RH_PER_EVENTO_ADMINRow)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return (False)
        End Try
    End Function

    Public Function actualizarDatosPrevisionales(ByVal datosPrevisionales As EDatosPrevisionales) As Boolean
        Dim empleadoPrevisDR As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_PREVISRow
        empleadoPrevisDR = CType(empleadosDS.Busca(datosPrevisionales.antecedentePrevisID, Tablas.RH_PER_ANTECEDENTE_PREVIS, "SELECT * FROM " & Tablas.RH_PER_ANTECEDENTE_PREVIS & " WHERE ANTECEDENTE_PREVIS_ID=" & datosPrevisionales.antecedentePrevisID), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_PREVISRow)
        Try
            asignacionCampos(Me, empleadoPrevisDR)
            empleadoPrevisDR = CType(empleadosDS.actualizarDatosPrevisionales(empleadoPrevisDR), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_PREVISRow)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return (False)
        End Try
    End Function
    Public Function actualizarDatosAPV(ByVal datosAPV As EDatosAPV) As Boolean
        Dim empleadoApvDR As DataAccess.Empleados.RH_PER_ANTECEDENTE_APVRow
        empleadoApvDR = CType(empleadosDS.Busca(datosAPV.antecedenteApvID, Tablas.RH_PER_ANTECEDENTE_APV, "SELECT * FROM " & Tablas.RH_PER_ANTECEDENTE_APV & " WHERE ANTECEDENTE_APV_ID=" & datosAPV.antecedenteApvID), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_APVRow)
        Try
            asignacionCampos(Me, empleadoApvDR)
            empleadoApvDR = CType(empleadosDS.actualizarDatosAPV(empleadoApvDR), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_APVRow)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return (False)
        End Try
    End Function
    Public Function actualizarDatosRemun(ByVal datosRemuneracion As EDatosRemuneracion) As Boolean
        Dim empleadoRemunDR As DataAccess.Empleados.RH_PER_ANTECEDENTE_REMUNRow
        empleadoRemunDR = CType(empleadosDS.Busca(datosRemuneracion.antecedenteRemunID, Tablas.RH_PER_ANTECEDENTE_REMUN, "SELECT * FROM " & Tablas.RH_PER_ANTECEDENTE_REMUN & " WHERE ANTECEDENTE_REMUN_ID=" & datosRemuneracion.antecedenteRemunID), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_REMUNRow)
        Try
            asignacionCampos(Me, empleadoRemunDR)
            empleadoRemunDR = CType(empleadosDS.actualizarDatosRemun(empleadoRemunDR), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_REMUNRow)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return (False)
        End Try
    End Function
    Public Function actualizarDatosLaboral(ByVal datosLaboral As EDatosLaborales) As Boolean
        Dim empleadoLaboralDR As DataAccess.Empleados.RH_PER_ANTECEDENTE_LABORALRow
        empleadoLaboralDR = CType(empleadosDS.Busca(datosLaboral.antecedenteLaboralID, Tablas.RH_PER_ANTECEDENTE_LABORAL, "SELECT * FROM " & Tablas.RH_PER_ANTECEDENTE_LABORAL & " WHERE ANTECEDENTE_LABORAL_ID=" & datosLaboral.antecedenteLaboralID), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_LABORALRow)
        Try
            asignacionCampos(Me, empleadoLaboralDR)
            empleadoLaboralDR = CType(empleadosDS.actualizarDatosLaboral(empleadoLaboralDR), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_LABORALRow)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return (False)
        End Try
    End Function
    Public Function actualizarDatosEstructuraOrganica(ByVal datosEstrucOrg As EEstructuraOrganica) As Boolean
        Dim empleadoEstrucOrgDR As DataAccess.Empleados.RH_PER_ESTRUCTURA_ORGANICARow
        empleadoEstrucOrgDR = CType(empleadosDS.Busca(datosEstrucOrg.estructuraOrganicaId, Tablas.RH_PER_ESTRUCTURA_ORGANICA, "SELECT * FROM " & Tablas.RH_PER_ESTRUCTURA_ORGANICA & " WHERE ESTRUCTURA_ORGANICA_ID=" & datosEstrucOrg.estructuraOrganicaId), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_ORGANICARow)
        Try
            asignacionCampos(Me, empleadoEstrucOrgDR)
            empleadoEstrucOrgDR = CType(empleadosDS.actualizarDatosEstructuraOrganica(empleadoEstrucOrgDR), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_ORGANICARow)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return (False)
        End Try
    End Function
    Public Function actualizarDatosEstructuraContable(ByVal datosEstrucContab As EEstructuraContable) As Boolean
        Dim empleadoEstrucContabDR As DataAccess.Empleados.RH_PER_ESTRUCTURA_CONTABLERow
        empleadoEstrucContabDR = CType(empleadosDS.Busca(datosEstrucContab.estructuraContableId, Tablas.RH_PER_ESTRUCTURA_CONTABLE, "SELECT * FROM " & Tablas.RH_PER_ESTRUCTURA_CONTABLE & " WHERE ESTRUCTURA_CONTABLE_ID=" & datosEstrucContab.estructuraContableId), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_CONTABLERow)
        Try
            asignacionCampos(Me, empleadoEstrucContabDR)
            empleadoEstrucContabDR = CType(empleadosDS.actualizarDatosEstructuraContable(empleadoEstrucContabDR), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_CONTABLERow)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return (False)
        End Try
    End Function

    Public Function actualizarDatosLicenciaMedica(ByVal datosLicMedica As ELicenciaMedica) As Boolean
        Dim empleadoLicMedDR As DataAccess.DSEmpleado.RH_PER_LICENCIA_MEDICARow
        empleadoLicMedDR = CType(empleadosDS.Busca(datosLicMedica.licenciaMedicaID, Tablas.RH_PER_LICENCIA_MEDICA, "SELECT * FROM " & Tablas.RH_PER_LICENCIA_MEDICA & " WHERE LICENCIA_MEDICA_ID=" & datosLicMedica.licenciaMedicaID), DataAccess.DSEmpleado.RH_PER_LICENCIA_MEDICARow)
        Try
            asignacionCampos(Me, empleadoLicMedDR)
            empleadoLicMedDR = CType(empleadosDS.actualizarDatosLicenciaMedica(empleadoLicMedDR), DataAccess.DSEmpleado.RH_PER_LICENCIA_MEDICARow)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return (False)
        End Try
    End Function

    Public Function actualizarDatosPresupuestoAnualHonorario(ByVal datosPrsupuestoAnualHonorario As EDatosPresupuestoAnualHonorario) As Boolean
        Dim dr As DataAccess.Empleados.RH_PER_ANTECEDENTE_HONORARIO_DETALLERow
        dr = CType(empleadosDS.Busca(datosPrsupuestoAnualHonorario.antecedenteHonorarioDetalleId, Tablas.RH_PER_ANTECEDENTE_HONORARIO_DETALLE, "SELECT * FROM " & Tablas.RH_PER_ANTECEDENTE_HONORARIO_DETALLE), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_HONORARIO_DETALLERow)
        Try
            asignacionCampos(Me, dr)
            dr = CType(empleadosDS.actualizaDatosPresupuestoAnualHonorario(dr), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_HONORARIO_DETALLERow)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return (False)
        End Try
    End Function

    Public Function actualizarDatosCurriculumLaboral(ByVal datosCurriculumLaboral As EDatosCurriculumLaboral) As Boolean
        Dim dr As DataAccess.Empleados.RH_PER_ANTECEDENTE_CURRIRow
        dr = CType(empleadosDS.Busca(datosCurriculumLaboral.antecedenteCuirricularLaboralId, Tablas.RH_PER_ANTECEDENTE_CURRI, "SELECT * FROM " & Tablas.RH_PER_ANTECEDENTE_CURRI), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_CURRIRow)
        Try
            asignacionCampos(Me, dr)
            dr = CType(empleadosDS.actualizaDatosAntecedenteCurricular(dr), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_CURRIRow)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return (False)
        End Try
    End Function
    Public Function actulizarAprobacionBienio(ByVal antecedenteRemunId As Integer, ByVal autorizaBienio As Boolean) As Boolean
        empleadosDS.actulizarAprobacionBienio(antecedenteRemunId, autorizaBienio)
    End Function
    Public Function insertaHorasExtrasAprobadas(ByVal empleado_id As Integer, ByVal año As Integer, _
                                      ByVal mes As Integer, ByVal nro_memo_interno As Integer, _
                                      ByVal fecha_memo_interno As DateTime, ByVal horas_diurnas_aprobadas As Integer, _
                                      ByVal horas_nocturnas_aprobadas As Integer, ByVal depto_id As Integer, ByVal estado_registro As Integer, ByVal tipo_proceso As String) As Boolean
        Return empleadosDS.insertaHorasExtrasAprobadas(empleado_id, año, mes, nro_memo_interno, fecha_memo_interno, horas_diurnas_aprobadas, horas_nocturnas_aprobadas, depto_id, estado_registro, tipo_proceso)
    End Function
    Public Function actualizaHorasExtrasAprobadas(ByVal horas_aprobadas_id As Integer, _
                                         ByVal horas_diurnas_aprobadas As Integer, _
                                         ByVal horas_nocturnas_aprobadas As Integer) As Boolean
        Return empleadosDS.actualizaHorasExtrasAprobadas(horas_aprobadas_id, horas_diurnas_aprobadas, horas_nocturnas_aprobadas)
    End Function
    'Actualizando la información de un a carga Familiar


    'agregado segegob
    'Public Function buscaPorcentajeAsignacionZona(ByVal zonaId As Integer) As Integer
    '    'Dim periodoDS As New DataAccess.ParametrosMensuales
    '    'periodoDS.AplicaAsignacionZona()

    'End Function
End Class


