Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO


Public Class DatoLista
    Implements IConvertible

    Public Sub New(ByVal descripcion As String, ByVal valor As Long)
        Me.descripcion = descripcion
        Me.valor = valor
    End Sub

    Public Overrides Function ToString() As String
        Return descripcion
    End Function

    Public descripcion As String
    Public valor As Long

    Public Function GetTypeCode() As System.TypeCode Implements System.IConvertible.GetTypeCode
        Throw New Exception("Este método u operación no ha sido definido")

    End Function

    Public Function ToBoolean(ByVal provider As System.IFormatProvider) As Boolean Implements System.IConvertible.ToBoolean
        Throw New Exception("Este método u operación no ha sido definido")
    End Function

    Public Function ToByte(ByVal provider As System.IFormatProvider) As Byte Implements System.IConvertible.ToByte
        Throw New Exception("Este método u operación no ha sido definido")
    End Function

    Public Function ToChar(ByVal provider As System.IFormatProvider) As Char Implements System.IConvertible.ToChar
        Throw New Exception("Este método u operación no ha sido definido")
    End Function

    Public Function ToDateTime(ByVal provider As System.IFormatProvider) As Date Implements System.IConvertible.ToDateTime
        Throw New Exception("Este método u operación no ha sido definido")
    End Function

    Public Function ToDecimal(ByVal provider As System.IFormatProvider) As Decimal Implements System.IConvertible.ToDecimal
        Return valor
    End Function

    Public Function ToDouble(ByVal provider As System.IFormatProvider) As Double Implements System.IConvertible.ToDouble
        Return valor
    End Function

    Public Function ToInt16(ByVal provider As System.IFormatProvider) As Short Implements System.IConvertible.ToInt16
        Return valor
    End Function

    Public Function ToInt32(ByVal provider As System.IFormatProvider) As Integer Implements System.IConvertible.ToInt32
        Return valor
    End Function

    Public Function ToInt64(ByVal provider As System.IFormatProvider) As Long Implements System.IConvertible.ToInt64
        Return valor
    End Function

    Public Function ToSByte(ByVal provider As System.IFormatProvider) As System.[SByte] Implements System.IConvertible.ToSByte
        Throw New Exception("Este método u operación no ha sido definido")
    End Function

    Public Function ToSingle(ByVal provider As System.IFormatProvider) As Single Implements System.IConvertible.ToSingle
        Return valor
    End Function

    Public Function ToString1(ByVal provider As System.IFormatProvider) As String Implements System.IConvertible.ToString
        Return Me.ToString
    End Function

    Public Function ToType(ByVal conversionType As System.Type, ByVal provider As System.IFormatProvider) As Object Implements System.IConvertible.ToType
        Throw New Exception("Este método u operación no ha sido definido")
    End Function

    Public Function ToUInt16(ByVal provider As System.IFormatProvider) As System.UInt16 Implements System.IConvertible.ToUInt16
        Throw New Exception("Este método u operación no ha sido definido")
    End Function

    Public Function ToUInt32(ByVal provider As System.IFormatProvider) As System.UInt32 Implements System.IConvertible.ToUInt32
        Throw New Exception("Este método u operación no ha sido definido")
    End Function

    Public Function ToUInt64(ByVal provider As System.IFormatProvider) As System.UInt64 Implements System.IConvertible.ToUInt64
        Throw New Exception("Este método u operación no ha sido definido")
    End Function
End Class

Public Class Utiles
    Public Shared Sub fillComboBoxEdit(ByRef cbb As ComboBoxEdit, ByVal dv As DataView, ByVal campoDescripcion As String, ByVal campoID As String)
        Dim drx As DataRow
        Dim Coll As ComboBoxItemCollection

        Try
            Coll = cbb.Properties.Items
        Catch ex As NullReferenceException
            Throw New NullReferenceException("El ComboBox es Nothing")
        End Try

        Try
            Coll.BeginUpdate()
            If Not dv.Table.Rows Is Nothing Then
                For Each drx In dv.Table.Rows
                    Coll.Add(New Comun.DatoLista(drx(campoDescripcion), drx(campoID)))
                Next
                Coll.EndUpdate()
            End If
        Finally

        End Try
    End Sub
    Public Shared Sub fillComboBoxEdit(ByRef cbb As Repository.RepositoryItemComboBox, ByVal dv As DataView, ByVal campoDescripcion As String, ByVal campoID As String)
        Dim drx As DataRow
        Dim Coll As ComboBoxItemCollection
        Try
            Coll = cbb.Items
        Catch ex As NullReferenceException
            Throw New NullReferenceException("El ComboBox es Nothing")
        End Try
        Coll.BeginUpdate()
        Try
            For Each drx In dv.Table.Rows
                Coll.Add(New Comun.DatoLista(drx(campoDescripcion), drx(campoID)))
            Next
        Finally
            Coll.EndUpdate()
        End Try
    End Sub
    Public Shared Sub fillLookUpEdit(ByRef cbb As DevExpress.XtraEditors.LookUpEdit, ByRef Dataview As DataView, ByVal campoDescripcion As String, ByVal campoID As String)
        With cbb
            With .Properties
                .DataSource = Dataview
                .DisplayMember = campoDescripcion
                .ValueMember = campoID
                .Columns.Item(0).FieldName = campoDescripcion
                .Columns.Item(0).Caption = campoDescripcion
            End With
            .EditValue = campoID
        End With
    End Sub

    Public Shared Sub fillLookUpEdit(ByRef cbb As DevExpress.XtraEditors.LookUpEdit, ByRef reader As SqlDataReader, ByVal campoDescripcion As String, ByVal campoID As String)
        With cbb
            With .Properties
                .DataSource = reader
                .DisplayMember = campoDescripcion
                .ValueMember = campoID
                .Columns.Item(0).FieldName = campoDescripcion
                .Columns.Item(0).Caption = campoDescripcion
            End With
            .EditValue = campoID
        End With
    End Sub
    Public Shared Function fillDataview(ByVal COMANDO_SQL As String, ByVal TABLA As String, ByVal campoDescripcion As String, ByVal campoID As String, ByRef StrConexion As String) As DataView
        Dim ds As New DataSet
        Dim conn As New SqlClient.SqlConnection(StrConexion)
        Dim datAdap As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(COMANDO_SQL, conn))
        datAdap.Fill(ds, TABLA)

        Dim dvmTipoCargasFamiliares As New DataViewManager(ds)
        Return (dvmTipoCargasFamiliares.CreateDataView(ds.Tables(TABLA)))
    End Function
    Public Shared Function Busca(ByVal SQL As String) As Integer
        Dim mySelectQuery As String = SQL
        Dim myConnection As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim myCommand As New SqlCommand(mySelectQuery, myConnection)
        Dim valorID As Integer

        Try
            myConnection.Open()
            Dim myReader As SqlDataReader
            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                valorID = myReader.GetValue(0)
            End While
            myReader.Close()
            myConnection.Close()
            Return valorID
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class

Public Enum EstadoEdicion
    NUEVO_REGISTRO = 1
    EDICION_REGISTRO = 2
    NINGUNO = 0
End Enum


Namespace TiposDeDatos
    Public Enum TipoUnidad
        PESOS = 1
        UF = 2
        PORCENTAJE = 3
        UTM = 4
        SIN_UNIDAD = 5
    End Enum
    Public Enum TipoEstadoCivil
        SOLTERO = 1
        CASADO = 2
        VIUDO = 3
        DIVORCIADO = 4
    End Enum
    Public Enum TipoNivelEducacional
        SIN_ESTUDIOS = 0
        PRE_KINDER = 1
        KINDER = 2
        BASICA = 3
        MEDIA = 4
        TECNICA_COMPLETA = 5
        TECNICA_INCOMPLETA = 6
        UNIVERSITARIA_COMPLETA = 7
        UNIVERSITARIA_INCOMPLETA = 8
    End Enum
    Public Structure EDireccion
        Dim nombre As String
        Dim calle As String
        Dim comuna As String
        Dim region As String
        Dim ciudad As String
        Dim villaPoblacion As String
        Dim numero As String
        Dim pais As String
        Dim codigoPostal As String
    End Structure
    Public Structure ERut
        Dim rut As Integer
        Dim dv As String
    End Structure
    Public Enum TipoLicenciaMedica
        ENFERMEDAD_ACCIDENTE_COMUN = 1
        PRORROGA_MEDICINA_PREVENTIVA = 2
        MATERNAL_PREYPOST_NATAL = 3
        ENFERMEDAD_GRAVE_HIJOMENOR_UN_ANNO = 4
        ACCIDENTE_DEL_TRABAJO = 5
        ENFERMEDAD_PROFESIONAL = 6
        PATOLOGIA_DEL_EMBARAZO = 7
    End Enum
    Public Enum TipoReposo
        TOTAL = 1
        PARCIAL = 2
    End Enum
    Public Enum TipoLugarReposo
        DOMICILIO = 1
        HOSPITAL = 2
        OTRO_DOMICILIO = 3
    End Enum
    Public Enum TipoCalidadJuridica
        SIN_CALIDAD = 1
        PLANTA = 2
        CONTRATA = 3
        SUPLENCIA = 4
        HONORARIOS = 5
    End Enum
    Public Enum TipoEstamento
        NO_APLICA = 0
        DIRECTIVO = 1
        PROFESIONAL = 2
        TECNICO = 3
        ADMINISTRATIVO = 4
        AUXILIAR = 5
    End Enum
    Public Enum TipoEscalafon
        NO_APLICA = 0
        JEFE_SUPERIOR_DE_SERVICIO = 1
        JEFE_DEPARTAMENTO = 2
        JEFE_SECCION = 3
        JEFE_OFICINA = 4
        ADMINISTRATIVO = 5
        AUXILIAR = 6
    End Enum
    Public Enum TipoEstado
        ACTIVO = 1
        INACTIVO = 2
        EX_EMPLEADO = 3
        POR_ACTIVAR = 4
        COMISION_SERVICIO_EN_PRESIDENCIA = 5
        COMISION_SERVICIO_A_OTRA_INSTITUCION = 6
    End Enum
    Public Enum TipoRetiro
        JUBILACION = 1
        FALLECIMIENTO = 2
        RENUNCIA_VOLUNTARIA = 3
        OTRO_MOTIVO = 4
    End Enum
    Public Enum EstadoRegistro
        ACTIVO = 1
        INACTIVO = 2
        HISTORICO = 5
    End Enum
    Public Enum TipoOrigenItem
        BIENESTAR = 0
        REMUNERACIONES = 1
        FICHA_EMPLEADO = 2
        CAMBIO_SITUACION_LABORAL = 3
        BONO_MODERNIZACION = 4
        TRASPASO_BONO_MODERNIZACION = 5
        CAMBIO_GRADO_PORPORCIONAL = 9
    End Enum
    Public Enum TipoActualizacion
        GUARDAR_REGISTRO_ACTUAL_O_NUEVO = 1
        GUARDAR_Y_CONSERVAR_REGISTRO_ANTERIOR = 2
    End Enum
    Public Enum TipoCargaFamiliar
        SIMPLE_NORMAL = 1
        INVALIDEZ = 2
        MATERNAL_FUNCIONARIA = 3
        MATERNAL_CONYUGE = 4
        NO_APLICA = 5
    End Enum
    Public Enum TipoParentesco
        CONYUGE = 1
        HIJO_A = 2
        MADRE = 3
        PADRE = 4
        HERMANO_A = 5
        NIETO_A = 6
        CUÑADO_A = 7
        SUEGRA = 8
        OTRO = 9
    End Enum
    Public Enum TipoGrupoFamiliar
        ES_CARGA_Y_PERTENECE_FAMILIA = 1
        ES_CARGA_Y_NO_PERTENECE_FAMILIA = 2
        SOLO_PERTENECE_FAMILIA = 3
    End Enum
    Public Enum TipoEstadoCargaFAM
        NO_VIGENTE = 1
        VIGENTE = 2
        POR_REGULARIZAR = 3
    End Enum
    Public Enum TipoCausaTerminoAsignacion
        SIN_CAUSA = 1
        FALLECIMIENTO = 2
        TRABAJO = 3
        CAMB_BENEFICIARIO = 4
        MAYORIA_EDAD = 5
        MATRIMONIO = 6
    End Enum
    Public Enum TipoEdicionCargaFAM
        EDICION_COMO_CARGA_FAMILIAR = 1
        EDICION_COMO_MIEMBRO_GRUPO_FAMILIAR = 2
    End Enum
    Public Structure EPeriodo
        Public ano As Integer
        Public mes As Byte
    End Structure
    Public Enum TipoItem
        HABERES = 0
        DEBERES = 1
        OTROS = 2
        ENCABEZADO = 3
        BASE_CALCULO = 3
        TOTAL = 4
    End Enum
    Public Enum TipoJornada
        DIA_COMPLETO = 1
        MAÑANA = 2
        TARDE = 3
    End Enum
    Public Enum TipoHorasExtras
        DIURNA = 1
        NOCTURNA = 2
    End Enum
    Public Enum TipoEventoAdmin
        FERIADO_LEGAL = 1
        PERMISO_ADMINISTRATIVO = 2
        PERMISO_PATERNAL = 3
        PERMISO_SIN_GOCE_SUELDO = 4
        LICENCIA_MEDICA = 5
        PERMISO_POR_DUELO = 6
        VIATICO = 7
        PERMISO_GREMIAL = 8
        PERMISO_POR_COMPENSACION = 9
    End Enum
    Public Enum EstadoEventoAdmin
        INGRESADO = 1
        ENVIADO = 2
        APROBADO = 3
        RECHAZADO = 4
        ACTUALIZADO = 5
    End Enum
    Public Enum IncluyeCalculoRemuneracion
        SI_INCLUYE = 1
        NO_INCLUYE = 2
    End Enum
    Public Enum TipoMovimientoLaboral
        INGRESADO = 0
        CONTRATADO = 1
        CAMBIO_GRADO = 2
        CAMBIO_CALIDAD_JURIDICA = 3
        CAMBIO_ESTAMENTO = 4
        CAMBIO_ESCALAFON = 5
        CAMBIO_DEPTO = 6
    End Enum
    Public Enum TipoDiaSemana
        HABIL = 0
        FESTIVO = 1
        SABADO = 2
        DOMINGO = 3
    End Enum
    Public Structure EDatosLaborales
        Public antecedenteLaboralID As Integer
        Public estadoRegistro As Integer
        Public calidadJuridicaID As Integer
        Public estamentoID As Integer
        Public clasificacionEmpleadoID As Integer
        Public gradoID As Integer
        Public jefeID As Integer
        Public escalafonID As Integer
        Public ubicaconFisicaID As Integer
        Public numeroTarjetaMagnetica As Integer
        Public horarioID As Integer
        Public tipoMovimientoID As Integer
        Public resolucionContrato As String
        Public resolucionID As Integer
        Public resolucionFecha As Date
        Public fechaIngresoInstitucion As Date
        Public fechaIngresoAdministracionPublica As Date
        Public fechaIngresoCalidadJuridica As Date
        Public fechaIngresoEstamento As Date
        Public fechaIngresoGrado As Date
        Public fechaIngresoEscalafon As Date
        Public fechaIngresoDepartamento As Date
        Public fechaRetiro As Date
        Public motivoRetiroID As Integer
        Public observacion As String
        Public descripcionMovimiento As String
        Public fechaMovimiento As Date
        Public publicaDatosWeb As Boolean
        Public tituloProfesionalExpertiz As String
        Public funcionDesempeño As String
        Public estadoEmpleadoID As Integer
        Public periodoID As Integer
        Public periodoIDCambioSituacionLaboral As Integer
        Public diasGrado As Short
        Public resolucionRetiro As String
        Public tipoBeneficiarioID As Integer
        Public numeroAcceso As Short
        Public cargo As String
        Public jefeEvaluadorId As Integer
        Public incluirEvalDesempeno As Boolean
    End Structure
    Public Structure EDatosPrevisionales
        'Atributos que corresponden a la institución previsional (AFP o Régimen Antiguo)
        Public antecedentePrevisID As Integer
        Public varEstadoRegistro As EstadoRegistro
        Public institucion As String
        Public institucionID As Integer
        Public fechaAfiliacion As Date
        Public fechaIngresoSistemaPrevisional As Date
        Public fondoPensionA As Boolean
        Public fondoPensionB As Boolean
        Public fondoPensionC As Boolean
        Public fondoPensionD As Boolean
        Public fondoPensionE As Boolean
        Public montoCuentaAhorroAFP As Decimal
        Public unidadCuentaAhorroAFP As String
        Public unidadCuentaAhorroAFPId As Byte
        Public montoCotizacionVoluntaria As Decimal
        Public unidadCotizacionVoluntaria As String
        Public unidadCotizacionVoluntariaId As Byte
        Public periodoID As Integer
        Public tipoTrabajadorPrevidredID As Byte
        Public afpNroFun As String
        Public afpFechaFun As Date
    End Structure
    Public Structure EDatosAPV
        'Atributos que corresponden a la institución de ahorro previsional voluntario (APV)
        Public antecedenteApvID As Integer
        Public estadoregistro As Integer
        Public tipoAPV As Integer
        Public institucionAPV As String
        Public institucionAPVID As Integer
        Public montoCuentaAhorroAPV As Decimal
        Public unidadCuentaAhorroAPV As String
        Public unidadCuentaAhorroAPVId As Integer
        Public periodoID As Integer
    End Structure
    Public Structure EDatosSalud
        'Atributos que corresponden a Isapre o Fonsa
        Public institucion As String
        Public institucionID As Integer
        Public fechaAfiliacion As Date
        Public montoConvenio As Decimal
        Public unidadConvenio As String
        Public unidadConvenioId As Byte
        Public montoPlanComplementario As Decimal
        Public unidadPlanComplementario As String
        Public unidadPlanComplementarioId As Byte
        Public montoplanAuge As Decimal
        Public unidadPlanAuge As String
        Public unidadPlanAugeId As Byte
        Public saludprais As String
        Public periodoID As Integer
        Public isapreNroFun As String
        Public isapreFechaFun As Date
    End Structure
    Public Structure EDatosRemuneracion
        Public antecedenteRemunID As Integer
        Public estadoRegistroRemun As Byte
        Public asociacionGremialID As Byte
        Public asociacionGremial As String
        Public fechaAfiliacionGremial As Date
        Public afiliadoBienestar As Boolean
        Public fechaAfiliacionBienestar As Date
        Public formaPago As Byte
        Public bancoID As Byte
        Public banco As String
        Public tipoCuentaDestinoID As Byte
        Public tipoCuentaDestino As String
        Public numeroCuenta As String
        Public asignacionProfesional As Boolean
        Public aplicaLey3551 As Boolean
        Public rentaBase As Integer
        Public numeroBienios As Byte
        Public fechaCumplioBienios As Date
        Public tramoAsignacionFamiliarID As Byte
        Public tramoAsignacionFamiliar As String
        Public cargaFamiliarNormal As Byte
        Public cargaFamiliarInvalida As Byte
        Public cargaFamiliarPrenatal As Byte
        Public sueldoBase As Integer
        Public valorAsignacionProfesional As Integer
        Public valorAsignacionResposabilidad As Integer
        Public valorAsignacionLey19185Art18 As Integer
        Public clasificacionINE As Byte
        Public ultimoPeriodoLiquidacion As String
        Public asignaGastoRepresentacion As Boolean
        Public valorGastoRepresentacion As Integer
        Public valorFuncionCritica As Integer
        Public valorAsignacionLey18717 As Integer
        Public valorAsignacionLey18675Art10 As Integer
        Public valorAsignacionLey18675Art11 As Integer
        Public valorAsignacionLey18566 As Integer
        Public valorLey3551 As Integer
        Public valorIncrementoPrevisionalDL3501 As Integer
        Public periodo As Integer
        Public anno As String
        Public porcentajeLey19863 As Short
        Public entregoBoletaHonorario As Boolean
        Public autorizaPagoBienio As Boolean
        Public observacionAutorizaPago As String
        Public enviarHaciaDexon As Boolean
        Public numeroCompromisoDexon As Integer
        Public montoBienio As Integer
        Public zonaID As Integer
        Public montoAsignacionZona As Integer
        Public montoAsignacionProfesional As Integer
        Public AsignaLey18675Art11 As Boolean
            
    End Structure

    Public Structure EDatosPresupuestoAnualHonorario
        Public antecedenteHonorarioDetalleId As Integer
        Public empleadoId As Integer
        Public estadoRegistro As Integer
        Public año As Integer
        Public montoEnero As Integer
        Public montoFebrero As Integer
        Public montoMarzo As Integer
        Public montoAbril As Integer
        Public montoMayo As Integer
        Public montoJunio As Integer
        Public montoJulio As Integer
        Public montoAgosto As Integer
        Public montoSeptiembre As Integer
        Public montoOctubre As Integer
        Public montoNoviembre As Integer
        Public montoDiciembre As Integer
        Public periodoId As Integer
        Public fechaContratoDesde As Date
        Public fechaContratoHasta As Date
        Public nroResolucion As String
        Public fechaResolucion As Date
        Public observacion As String
        Public montoVigente As Integer
        Public esRetiroEmpleado As Boolean
        Public motivoRetiroId As Integer
    End Structure
    Public Structure ECargasFAM
        'Esctructura base de una carga familiar.
        Public ID As Integer
        Public EmpleadoID As Integer
        Public Nivel_Estudio_ID As Byte
        Public Tipo_Carga_Fam As Byte
        Public Parentesco_ID As Byte
        Public Grupo_Familiar_ID As Byte
        Public Rut As Integer
        Public Digito_Verificador As Char
        Public Apellido_Pat_Cargo As String
        Public Apellido_Mat_Cargo As String
        Public Nombres As String
        Public Sexo As Char
        Public Fecha_Nacimiento As Date
        Public Estado As Byte
        Public Fecha_Vigencia As Date
        Public Fecha_Vencimiento As Date
        Public Retension_Judicial As Char
        Public Carga_Por_Estudios As Char
        Public Causa_Termino_Asignacion As Byte
        Public Usuario As String 'Usuario utilizado para el registro de Log.
        Public Fecha_Modificacion As Date
        Public Hora_Modificacion As String
        Public tipoEdicion As TipoEdicionCargaFAM
        Public tipoBeneficioId As Integer
        Public tipoCausanteId As Integer
        Public regimenEstudio As Integer
        Public fechaInicioReconocimiento As Date
        Public fechaFinReconocimiento As Date
        Public numeroResolucion As String
        Public periodoId As Integer
        'Fin de estructura carga familiar
    End Structure
    Public Structure ESaldoDiasEventoAdmin
        Public eventoAdminSaldoID As Integer
        Public tipoEventoAdminID As Byte
        Public empleadoID As Integer
        Public diasPeriodo As Decimal
        Public diasPeriodoAnterior As Decimal
        Public diasAdicionales As Decimal
        Public totalDiasAnual As Decimal
        Public totalDiasSolicitados As Decimal
        Public diasPendiente As Decimal
        Public anoProceso As Integer
    End Structure

    Public Structure ELicenciaMedica
        Public licenciaMedicaID As Integer
        Public numeroLicencia As String
        Public tipoLicencia As String
        Public tipoLicenciaID As Integer
        Public estadoLicencia As Integer
        Public fechaRecepcion As Date
        Public diasLicencia As Integer
        Public fechaInicio As Date
        Public fechaTermino As Date
        Public tipoReposo As Byte
        Public lugarResposo As Integer
        Public fechaEnvioIsapre As Date
        Public continuidad As Byte
        Public numeroLicenciaContinuidad As String
        Public diasContinuidad As Integer
        Public fechaInicioContinuidad As Date
        Public fechaTerminoContinuidad As Date
        Public periodo As String
        Public fechaConcepcion As Date
        Public fechaEmision As Date
        Public fechaAccidente As Date
        Public nombreDoctor As String
        Public especialidad As String
        Public numeroCheque As String
        Public montoCheque As Integer
        Public momorandum As String
        Public observaciones As String
        Public fechaDigitacionPago As Date
        Public licenciaMedicaIDOld As Integer
        Public periodoID As Integer
        Public rentaPromedioID As Integer
        Public numeroFolio As String
        Public fechaRecepcionIsapre As Date
        Public clasificacion As Integer
        Public diasReduccion As Integer
        Public fechaEstimadaPago As Date
        Public causaRechaziId As Integer
        Public tipoProfesional As Integer
    End Structure
    Public Structure EViatico
        Public viaticoID As Integer
        Public empleadoID As Integer
        Public estado As Int16
        Public tipoResolucion As Int16
        Public numeroMemorandum As String
        Public fechaMemorandum As Date
        Public periodo As String
        Public observacion As String
        Public numeroResolucion As String
        Public usuario As String
        Public horaModificacion As String
        Public fechaModificacion As Date
        Public motivo As String
        Public FECHA_RESOLUCION As Date
    End Structure
    Public Structure EDetalleViatico
        Public detalleViaticoID As Integer
        Public viaticoID As Integer
        Public empleadoID As Integer
        Public cantidadDias As Integer
        Public fechaInicio As Date
        Public fechaTermino As Date
        Public motivo As String
        Public paisID As Integer
        Public regionID As Integer
        Public comunaID As Integer
        Public usuario As String
        Public horaModificacion As String
        Public fechaModificacion As Date
        Public monto As Integer
        Public numeroDocumento As String 'Cheque
        Public fechaDocumento As Date
        Public destino As Int16
        Public estado As Int16
        Public grado_id As Int16
        Public patenteVehiculo As String
    End Structure
    Public Structure EDatosEUS
        Public sueldoBase As Integer
        Public asigProfesionalLey19185Art19 As Integer
        Public asigResponsabilidadSuperior As Integer
        Public asigLey19185Art18 As Integer
        Public asigLey18717ConAsigProfesional As Integer
        Public asigLey18717SinAsigProfesional As Integer
        Public bonoLey18675Art10 As Integer
        Public bonoLey18675Art11 As Integer
        Public bonoLey18566 As Integer
        Public aplicaLey3551 As Boolean
        Public asigLey3551 As Integer
        Public aplicaGastoRepresentacion As Byte
        Public gastoRepresentacion As Integer
        Public esProfesional As Boolean
        Public anno As String
    End Structure
    Public Structure EEstructuraOrganica
        Public estructuraOrganicaId As Integer
        Public estadoRegistro As Integer
        Public empleadoID As Integer
        Public organizacionID As Integer
        Public direccionID As Integer
        Public deptoID As Integer
        Public subDeptoId As Integer
        Public periodoID As Integer
        Public evaluadorDesempenoID As Integer
        Public autorizadorHorasExtrasID As Integer
    End Structure
    Public Structure EEstructuraContable
        Public estructuraContableId As Integer
        Public estadoRegistro As Integer
        Public empleadoID As Integer
        Public centroCostoContab As Integer
        Public centroCostoPresup As Integer
        Public procentajeDistribucion As Integer
        Public periodoID As Integer
        Public organizacionID As Integer
    End Structure
    Public Structure EEventoAdmin
        'Esctructura base de un evento administrativo.
        Public Evento_Administrativo_ID As Integer
        Public Tipo_Evento_Admin_ID As Integer
        Public Empleado_ID As Integer
        Public Fecha_Digitacion As Date
        Public Estado_Evento_Administrativo_ID As Integer
        Public Dias_Solicitados As Decimal
        Public Motivo_Solicitud As String
        Public Año As Integer
        Public periodoId As Integer
        'Fin de estructura evento admin
    End Structure
    Public Structure EEventoAdminDetalle
        Public Evento_Administrativo_Detalle_ID As Integer
        Public Fecha_nacimiento_hijo As Date
        Public Jornada_Id As Integer
        Public Fecha_Digitacion As Date
        Public Resolucion As String
        Public Observacion As String
        Public Dias_Habiles As Decimal
        Public Periodo_Id As Integer
        Public Usuario As String
        Public Tipo_Fallecimiento_Id As Integer
    End Structure
    Public Structure EOrganizacion
        Public organizacionID As Integer
        Public organizacionAlias As String
        Public nombreFantasia As String
        Public rutEmpresa As Integer
        Public dvEmpresa As String
        Public razonSocial As String
        Public direccion As String
        Public paisID As Integer
        Public regionID As Integer
        Public comunaID As Integer
        Public apellidoPaternoRepLegal As String
        Public apellidoMaternoRepLegal As String
        Public nombresRepLegal As String
        Public rutRepLegal As Integer
        Public dvRepLegal As String
        Public cargoRepLegal As String
        Public telefono As String
        Public codigoActividadEconomica As String
        Public apellidoPaternoJefeSubrogante As String
        Public apellidoMaternoJefeSubrogante As String
        Public nombresJefeSubrogante As String
        Public rutRepJefeSubrogante As Integer
        Public dvRepJefeSubrogante As String
        Public cargoJefeSubrogante As String
    End Structure
    Public Structure EEncabezadoAsientoContable
        Public asientoContableID As Integer
        Public periodoID As Integer
        Public estadoRegistro As Integer
        Public tipoProceso As String
        Public esCosto As Boolean
    End Structure
    Public Structure EDetalleControlAsistencia
        Public asistenciaID As Integer
        Public empleadoID As Integer
        Public periodoID As Integer
        Public fechaAsistencia As Date
        Public horaEntrada As Date
        Public horaSalida As Date
        Public horasTrabajadas As Date
        Public horasExtrasDiurnas As Date
        Public horasExtrasNocturnas As Date
        Public medioDiaAsistencia As Boolean
        Public horaAtraso As Date
        Public horasExtrasDiurnasAutorizadas As Date
        Public horasExtrasNocturnasAutorizadas As Date
        Public autorizaDesctoMedioDia As Boolean
        Public horaAtrasoAutorizadas As Date
        Public tipoEventoAdminID As Integer
        Public anoReal As Integer
        Public mesReal As Integer
        Public observaciones As String
        Public horasCompensadasDiurnas As Date
        Public horasCompensadasNocturnas As Date
        Public estado As String
    End Structure

    Public Structure EHorasExtrasAprobadas
        Public Horas_Aprobadas_id As Integer
        Public Empleado_ID As Integer
        Public Año As Integer
        Public Mes As Integer
        Public Nro_Memo_Interno As Integer
        Public Fecha_Memo_Interno As DateTime
        Public Horas_Diurnas_Aprobadas As Integer
        Public Horas_Nocturnas_Aprobadas As Integer
        Public Depto_id As Integer
        Public Estado_registro As Integer
        Public Tipo_Proceso As Integer
    End Structure

    Public Structure EDatosCurriculumLaboral
        Public antecedenteCuirricularLaboralId As Integer
        Public empleadoId As Integer
        Public prefesionId As Integer
        Public otrosEstudios As String
        Public experienciaLaboral As String
        Public estadoRegistro As Integer
    End Structure


End Namespace

Namespace Funciones
    Public Class Rut
        Public Shared Function Valida(ByVal Rut As Integer) As String
            Dim cuenta, Suma, resto, Digito As Integer
            Dim dig As String

            Suma = 0
            cuenta = 2
            Do
                dig = Rut Mod 10
                Rut = Int(Rut / 10)
                Suma = Suma + (dig * cuenta)
                cuenta = cuenta + 1
                If cuenta = 8 Then cuenta = 2
            Loop Until Rut = 0
            resto = Suma Mod 11
            Digito = 11 - resto
            Select Case Digito
                Case 10
                    Return ("K")
                Case 11
                    Return ("0")
                Case Else
                    Return (Trim(Str(Digito)))
            End Select
        End Function
    End Class
    Public Class FechaFinal
        Public Shared Function ValidaFechaDisponible(ByVal idFuncionario As Integer, ByVal fechaInicial As Date, ByVal FechaFinal As Date) As String
            'Valida que el rango de fechas solicitadas no este en uso por otro evento administrativo
            'Devuelve un entero: 0 si la fecha no esta siendo utilizada, si la fecha esta siendo utilizada
            Dim strSQL As String = ""
            Dim Resultado As String = ""
            strSQL = "SELECT dbo.fn_valida_dias_solicitados(" & idFuncionario & ",convert(datetime,'" & fechaInicial & "',103),convert(datetime,'" & FechaFinal & "',103)) AS RESULTADO"

            Dim oConnection As New SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)
            Dim oCommand As New SqlCommand(strSQL, oConnection)
            oConnection.Open()
            Dim oReader As SqlDataReader = oCommand.ExecuteReader()
            Do
                While oReader.Read
                    Resultado = oReader("RESULTADO")
                End While
            Loop While oReader.NextResult
            oReader.Close()
            oConnection.Close()
            If Resultado = "" Then
                Resultado = "OK"
            End If
            Return Resultado
        End Function

        Public Shared Function Valida(ByVal fechaInicial As Date, ByVal dias As Integer) As Date
            'Función que calcula el día final recorrido sin considerar dias festivos, sabados o domingos
            Dim fechaFinal As Date = CType(fechaInicial, Date).AddDays(dias - 1)
            Return fechaFinal
        End Function
        Public Shared Function Edad(ByVal FechaNacimiento As DateTime) As Double
            Dim dblEdad As Double = DateTime.Now.Subtract(FechaNacimiento).TotalDays / 365.25
            Return dblEdad
        End Function
    End Class

    Public Class Imagenes
        Public Shared Function Image2Bytes(ByVal img As Image) As Byte()
            Dim sTemp As String = Path.GetTempFileName()
            Dim fs As New FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite)
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png)
            fs.Position = 0
            '
            Dim imgLength As Integer = CInt(fs.Length)
            Dim bytes(imgLength - 1) As Byte
            fs.Read(bytes, 0, imgLength)
            fs.Close()
            Return bytes
        End Function

        Public Shared Function Bytes2Image(ByVal bytes() As Byte) As Image
            If bytes Is Nothing Then Return Nothing
            '
            Dim ms As New MemoryStream(bytes)
            Dim bm As Bitmap = Nothing
            Try
                bm = New Bitmap(ms)
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine(ex.Message)
            End Try
            Return bm
        End Function

    End Class
    Public Class Math
        Public Shared Function Round(ByVal valorDecimal As Decimal, ByVal redondeo As Integer) As Decimal
            Dim resultado, valorDevuelto As Decimal
            resultado = (valorDecimal - Int(valorDecimal)) * 10000
            If resultado >= 5000 Then
                valorDevuelto = Int(valorDecimal) + 1
            Else
                valorDevuelto = Int(valorDecimal)
            End If
            Return valorDevuelto
        End Function
    End Class
End Namespace



