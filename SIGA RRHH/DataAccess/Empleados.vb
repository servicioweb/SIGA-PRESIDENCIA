Imports System.ComponentModel
Imports System.Data.SqlClient
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.Comun.Funciones


'''<summary>
'''Empleados corresponde a la clase que permite administrar 
'''los datos de funcionarios con la Fuente de Datos
'''</summary>

Public Class Empleados
    Inherits DSEmpleado

    Private Const NOMBRE_TABLA As String = Tablas.RH_PER_EMPLEADO
    'Se crea el DataAdapter que rescata los datos de la tabla NOMBRE_TABLA
    Private da As New SqlDataAdapter("SELECT * FROM " & NOMBRE_TABLA, ArgoConfiguracion.ConnectionString)
    'Private daprevis As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ANTECEDENTES_PREVISIONALES, ArgoConfiguracion.ConnectionString)
    Private dalaboral As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ANTECEDENTES_LABORALES, ArgoConfiguracion.ConnectionString)


    Dim conn As SqlConnection

    Public Sub New()
        MyBase.New()
        If conn Is Nothing Then
            conn = New SqlConnection
        End If
        conn.ConnectionString = ArgoConfiguracion.ConnectionString
    End Sub

    Protected Overrides Sub Finalize()
        da = Nothing
        'daprevis = Nothing
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn = Nothing
        MyBase.Finalize()
    End Sub

#Region "Métodos Elementales"

    '''<param name="empleado">Recibe el tipo DataRow, correspondiente a una fila de la Entidad Empleado</param>
    Public Function Inserta(ByVal empleado As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_EMPLEADO, ArgoConfiguracion.ConnectionString)
        da.InsertCommand = Me.GetInsertCommand()
        da.InsertCommand.CommandTimeout = 30
        da.InsertCommand.Parameters("@ORGANIZACION_ID").Value = empleado("ORGANIZACION_ID")
        da.InsertCommand.Parameters("@ESTADO_EMPLEADO_ID").Value = empleado("ESTADO_EMPLEADO_ID")
        da.InsertCommand.Parameters("@RUT").Value = empleado("RUT")
        da.InsertCommand.Parameters("@DV").Value = empleado("DV")
        da.InsertCommand.Parameters("@APELLIDO_PATERNO").Value = empleado("APELLIDO_PATERNO")
        da.InsertCommand.Parameters("@APELLIDO_MATERNO").Value = empleado("APELLIDO_MATERNO")
        da.InsertCommand.Parameters("@NOMBRES").Value = empleado("NOMBRES")
        da.InsertCommand.Parameters("@FECHA_NACIMIENTO").Value = CType(empleado("FECHA_NACIMIENTO"), Date)
        da.InsertCommand.Parameters("@SEXO").Value = empleado("SEXO")
        da.InsertCommand.Parameters("@ESTADO_CIVIL").Value = empleado("ESTADO_CIVIL_ID")
        da.InsertCommand.Parameters("@VILLA_POBLACION").Value = empleado("VILLA_POBLACION")
        da.InsertCommand.Parameters("@NUMERO_DIRECCION").Value = empleado("NUMERO_DIRECCION")
        da.InsertCommand.Parameters("@CALLE_AVDA").Value = empleado("CALLE_AVDA")
        da.InsertCommand.Parameters("@TELEFONO_PARTICULAR").Value = empleado("TELEFONO_PARTICULAR")
        da.InsertCommand.Parameters("@CELULAR").Value = empleado("CELULAR")
        da.InsertCommand.Parameters("@PAIS_ID").Value = empleado("PAIS_ID")
        da.InsertCommand.Parameters("@REGION_ID").Value = empleado("REGION_ID")
        da.InsertCommand.Parameters("@COMUNA_ID").Value = empleado("COMUNA_ID")
        da.InsertCommand.Parameters("@CIUDAD_ID").Value = empleado("CIUDAD_ID")
        da.InsertCommand.Parameters("@ANEXO_TELEFONO_OFI").Value = empleado("ANEXO_TELEFONO_OFI")
        da.InsertCommand.Parameters("@CONTACTO_EMERGENCIA").Value = empleado("CONTACTO_EMERGENCIA")
        da.InsertCommand.Parameters("@SITUACION_MILITAR").Value = empleado("SITUACION_MILITAR")
        da.InsertCommand.Parameters("@NRO_MATRICULA_MILITAR").Value = empleado("NRO_MATRICULA_MILITAR")
        da.InsertCommand.Parameters("@GRUPO_SANGUINEO").Value = empleado("GRUPO_SANGUINEO")
        da.InsertCommand.Parameters("@ALERGICO").Value = empleado("ALERGICO")
        da.InsertCommand.Parameters("@SUFRE_ENFERMEDAD").Value = empleado("SUFRE_ENFERMEDAD")
        da.InsertCommand.Parameters("@MEDICAMENTOS").Value = empleado("MEDICAMENTOS")
        da.InsertCommand.Parameters("@NIVEL_ESTUDIO_ID").Value = empleado("NIVEL_ESTUDIO_ID")
        da.InsertCommand.Parameters("@CODIGO_POSTAL").Value = empleado("CODIGO_POSTAL")
        Me.Tables(Tablas.RH_PER_EMPLEADO).Rows.Add(empleado)
        Try
            da.Update(Me, Tablas.RH_PER_EMPLEADO)
            Return (empleado)
        Catch exSQL As SqlException
            Debug.WriteLine(exSQL.ToString)
            Throw New Exception(exSQL.Message)
            'Se destruye el objeto DataAdapter
        End Try



        ''Se agrega el nuevo DataRow (EmpleadoDR)
        'Me.Tables(NOMBRE_TABLA).Rows.Add(empleado)

        ''Se actualiza el DataTable con los datos incorporados en la linea anterior
        'Try
        '    da.Update(Me, NOMBRE_TABLA)
        '    Return (empleado)
        'Catch exSQL As SqlException
        '    Debug.WriteLine(exSQL.ToString)
        '    Throw New Exception(exSQL.Message)
        '    'Se destruye el objeto DataAdapter
        'End Try
    End Function
    Public Function InsertaEmpleadoLaboral(ByVal empleadolaboral As DataRow) As DataRow
        Dim dalaboral As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ANTECEDENTES_LABORALES, ArgoConfiguracion.ConnectionString)
        dalaboral.InsertCommand = Me.GetUpdateCmdDatosLaborales()
        dalaboral.InsertCommand.CommandTimeout = 30
        dalaboral.InsertCommand.Parameters("@EMPLEADO_ID").Value = empleadolaboral("EMPLEADO_ID")
        dalaboral.InsertCommand.Parameters("@ESTADO_REGISTRO").Value = empleadolaboral("ESTADO_REGISTRO")
        dalaboral.InsertCommand.Parameters("@CALIDAD_JURIDICA_ID").Value = empleadolaboral("CALIDAD_JURIDICA_ID")
        dalaboral.InsertCommand.Parameters("@ESTAMENTO_ID").Value = empleadolaboral("ESTAMENTO_ID")
        dalaboral.InsertCommand.Parameters("@CLASIFICACION_EMPLEADO_ID").Value = empleadolaboral("CLASIFICACION_EMPLEADO_ID")
        dalaboral.InsertCommand.Parameters("@GRADO_ID").Value = empleadolaboral("GRADO_ID")
        dalaboral.InsertCommand.Parameters("@JEFE_ID").Value = empleadolaboral("JEFE_ID")
        dalaboral.InsertCommand.Parameters("@ESCALAFON_ID").Value = empleadolaboral("ESCALAFON_ID")
        dalaboral.InsertCommand.Parameters("@UBICACION_FISICA_ID").Value = empleadolaboral("UBICACION_FISICA_ID")
        dalaboral.InsertCommand.Parameters("@HORARIO_ID").Value = empleadolaboral("HORARIO_ID")
        dalaboral.InsertCommand.Parameters("@NUMERO_TARJETA_MAGNETICA").Value = empleadolaboral("NUMERO_TARJETA_MAGNETICA")
        dalaboral.InsertCommand.Parameters("@TIPO_MOVIMIENTO_ID").Value = empleadolaboral("TIPO_MOVIMIENTO_ID")
        dalaboral.InsertCommand.Parameters("@RESOLUCION_CONTRATO").Value = empleadolaboral("RESOLUCION_CONTRATO")
        dalaboral.InsertCommand.Parameters("@FECHA_ING_ADMIN_PUBLICA").Value = empleadolaboral("FECHA_ING_ADMIN_PUBLICA")
        dalaboral.InsertCommand.Parameters("@FECHA_ING_INSTITUCION").Value = empleadolaboral("FECHA_ING_INSTITUCION")
        dalaboral.InsertCommand.Parameters("@FECHA_ING_CALIDAD_JURIDICA").Value = empleadolaboral("FECHA_ING_CALIDAD_JURIDICA")
        dalaboral.InsertCommand.Parameters("@FECHA_ING_ESTAMENTO").Value = empleadolaboral("FECHA_ING_ESTAMENTO")
        dalaboral.InsertCommand.Parameters("@FECHA_ING_GRADO").Value = empleadolaboral("FECHA_ING_GRADO")
        dalaboral.InsertCommand.Parameters("@FECHA_ING_ESCALAFON").Value = empleadolaboral("FECHA_ING_ESCALAFON")
        dalaboral.InsertCommand.Parameters("@FECHA_ING_DEPTO").Value = empleadolaboral("FECHA_ING_DEPTO")
        dalaboral.InsertCommand.Parameters("@MOTIVO_RETIRO_ID").Value = empleadolaboral("MOTIVO_RETIRO_ID")
        dalaboral.InsertCommand.Parameters("@FECHA_RETIRO").Value = empleadolaboral("FECHA_RETIRO")
        dalaboral.InsertCommand.Parameters("@OBSERVACIONES").Value = empleadolaboral("OBSERVACIONES")
        dalaboral.InsertCommand.Parameters("@DESCRIPCION_MOVIMIENTO").Value = empleadolaboral("DESCRIPCION_MOVIMIENTO")
        dalaboral.InsertCommand.Parameters("@FECHA_MOVIMIENTO").Value = empleadolaboral("FECHA_MOVIMIENTO")
        dalaboral.InsertCommand.Parameters("@PUBLICA_WEB").Value = empleadolaboral("PUBLICA_WEB")
        dalaboral.InsertCommand.Parameters("@FUNCIONES_DESEMPENADAS").Value = empleadolaboral("FUNCIONES_DESEMPENADAS")
        dalaboral.InsertCommand.Parameters("@TITULO_PROFESIONAL_EXPERTIZ").Value = empleadolaboral("TITULO_PROFESIONAL_EXPERTIZ")
        dalaboral.InsertCommand.Parameters("@ESTADO_EMPLEADO_ID").Value = empleadolaboral("ESTADO_EMPLEADO_ID")
        dalaboral.InsertCommand.Parameters("@PERIODO_ID").Value = empleadolaboral("PERIODO_ID")
        dalaboral.InsertCommand.Parameters("@PERIODO_ID_CAMBIO_SITUACION").Value = empleadolaboral("PERIODO_ID_CAMBIO_SITUACION")
        dalaboral.InsertCommand.Parameters("@DIAS_EN_GRADO").Value = empleadolaboral("DIAS_EN_GRADO")
        dalaboral.InsertCommand.Parameters("@RESOLUCION_RETIRO").Value = empleadolaboral("RESOLUCION_RETIRO")
        dalaboral.InsertCommand.Parameters("@TIPO_BENEFICIARIO_ID").Value = empleadolaboral("TIPO_BENEFICIARIO_ID")
        dalaboral.InsertCommand.Parameters("@NUMERO_ACCESO").Value = empleadolaboral("NUMERO_ACCESO")
        dalaboral.InsertCommand.Parameters("@CARGO_ACTUAL").Value = empleadolaboral("CARGO_ACTUAL")
        dalaboral.InsertCommand.Parameters("@JEFE_EVALUADOR_ID").Value = empleadolaboral("JEFE_EVALUADOR_ID")
        dalaboral.InsertCommand.Parameters("@ASIGNA_EVALUACION_DESEMPENO").Value = empleadolaboral("ASIGNA_EVALUACION_DESEMPENO")
        Me.Tables(Tablas.RH_PER_ANTECEDENTE_LABORAL).Rows.Add(empleadolaboral)
        Try
            dalaboral.Update(Me, Tablas.RH_PER_ANTECEDENTE_LABORAL)
            Return (empleadolaboral)
        Catch exSQL As SqlException
            Debug.WriteLine(exSQL.ToString)
            Throw New Exception(exSQL.Message)
            'Se destruye el objeto DataAdapter
        End Try
    End Function
    Public Function InsertaEmpleadoPrevis(ByVal empleadoprevis As DataRow, ByVal idPrevis As Integer) As DataRow
        Dim daprev As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ANTECEDENTES_PREVISIONALES, ArgoConfiguracion.ConnectionString)
        If idPrevis > 0 Then
            daprev.Fill(Me, Tablas.RH_PER_ANTECEDENTE_PREVIS)
        End If
        daprev.InsertCommand = Me.GetUpdateCmdDatosPrevisionales()
        daprev.InsertCommand.Parameters("@EMPLEADO_ID").Value = empleadoprevis("EMPLEADO_ID")
        daprev.InsertCommand.Parameters("@ESTADO_REGISTRO").Value = empleadoprevis("ESTADO_REGISTRO")
        daprev.InsertCommand.Parameters("@FECHA_ING_SISTEMA_PREVIS").Value = empleadoprevis("FECHA_ING_SISTEMA_PREVIS")
        daprev.InsertCommand.Parameters("@AFP_ID").Value = empleadoprevis("AFP_ID")
        daprev.InsertCommand.Parameters("@FECHA_AFILIACION_AFP").Value = empleadoprevis("FECHA_AFILIACION_AFP")
        daprev.InsertCommand.Parameters("@MONTO_AHORRO_AFP").Value = empleadoprevis("MONTO_AHORRO_AFP")
        daprev.InsertCommand.Parameters("@MONEDA_AHORRO_AFP_ID").Value = empleadoprevis("MONEDA_AHORRO_AFP_ID")
        daprev.InsertCommand.Parameters("@MONTO_COTIZACION_VOLUNTARIA_AFP").Value = empleadoprevis("MONTO_COTIZACION_VOLUNTARIA_AFP")
        daprev.InsertCommand.Parameters("@MONEDA_COTIZ_VOLUN_AFP_ID").Value = empleadoprevis("MONEDA_COTIZ_VOLUN_AFP_ID")
        daprev.InsertCommand.Parameters("@ISAPRE_ID").Value = empleadoprevis("ISAPRE_ID")
        daprev.InsertCommand.Parameters("@FECHA_AFILIACION_ISAPRE").Value = empleadoprevis("FECHA_AFILIACION_ISAPRE")
        daprev.InsertCommand.Parameters("@MONTO_ISAPRE").Value = empleadoprevis("MONTO_ISAPRE")
        daprev.InsertCommand.Parameters("@MONEDA_MONTO_ISAPRE_ID").Value = empleadoprevis("MONEDA_MONTO_ISAPRE_ID")
        daprev.InsertCommand.Parameters("@PLAN_COMPLEM_ISAPRE").Value = empleadoprevis("PLAN_COMPLEM_ISAPRE")
        daprev.InsertCommand.Parameters("@MONEDA_PLAN_COMPLEM_ISAPRE_ID").Value = empleadoprevis("MONEDA_PLAN_COMPLEM_ISAPRE_ID")
        daprev.InsertCommand.Parameters("@SALUD_PRAIS").Value = empleadoprevis("SALUD_PRAIS")
        daprev.InsertCommand.Parameters("@FONDO_A").Value = empleadoprevis("FONDO_A")
        daprev.InsertCommand.Parameters("@FONDO_B").Value = empleadoprevis("FONDO_B")
        daprev.InsertCommand.Parameters("@FONDO_C").Value = empleadoprevis("FONDO_C")
        daprev.InsertCommand.Parameters("@FONDO_D").Value = empleadoprevis("FONDO_D")
        daprev.InsertCommand.Parameters("@FONDO_E").Value = empleadoprevis("FONDO_E")
        daprev.InsertCommand.Parameters("@MONTO_PLAN_AUGE").Value = empleadoprevis("MONTO_PLAN_AUGE")
        daprev.InsertCommand.Parameters("@MONEDA_PLAN_AUGE_ID").Value = empleadoprevis("MONEDA_PLAN_AUGE_ID")
        daprev.InsertCommand.Parameters("@PERIODO_ID").Value = empleadoprevis("PERIODO_ID")
        daprev.InsertCommand.Parameters("@TIPO_TRABAJADOR_PREVIRED_ID").Value = empleadoprevis("TIPO_TRABAJADOR_PREVIRED_ID")
        daprev.InsertCommand.Parameters("@AFP_NRO_FUN").Value = empleadoprevis("AFP_NRO_FUN")
        daprev.InsertCommand.Parameters("@AFP_FECHA_FUN").Value = empleadoprevis("AFP_FECHA_FUN")
        daprev.InsertCommand.Parameters("@ISAPRE_NRO_FUN").Value = empleadoprevis("ISAPRE_NRO_FUN")
        daprev.InsertCommand.Parameters("@ISAPRE_FECHA_FUN").Value = empleadoprevis("ISAPRE_FECHA_FUN")
        Me.Tables(Tablas.RH_PER_ANTECEDENTE_PREVIS).Rows.Add(empleadoprevis)
        Try
            daprev.Update(Me, Tablas.RH_PER_ANTECEDENTE_PREVIS)
            Return (empleadoprevis)
        Catch exSQL As SqlException
            Debug.WriteLine(exSQL.ToString)
            Throw New Exception(exSQL.Message)
            'Se destruye el objeto DataAdapter
        End Try
    End Function

    Public Function ActualizaEmpleadoPresupuestoAnualHonorario(ByVal idDetalleHonorario As Integer, ByVal dr As DataRow) As DataRow
        Dim daDetatalleHonor As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ANTECEDENTE_PRESUP_ANUAL_HONORARIO_DETALLE, ArgoConfiguracion.ConnectionString)
        If idDetalleHonorario > 0 Then
            daDetatalleHonor.Fill(Me, Tablas.RH_PER_ANTECEDENTE_HONORARIO_DETALLE)
        End If
        daDetatalleHonor.InsertCommand = Me.GetUpdateCmdDatosPresupAnualHonorario()
        daDetatalleHonor.InsertCommand.Parameters("@EMPLEADO_ID").Value = dr("EMPLEADO_ID")
        daDetatalleHonor.InsertCommand.Parameters("@ESTADO_REGISTRO").Value = dr("ESTADO_REGISTRO")
        daDetatalleHonor.InsertCommand.Parameters("@AÑO").Value = dr("AÑO")
        daDetatalleHonor.InsertCommand.Parameters("@MONTO_ENERO").Value = dr("MONTO_ENERO")
        daDetatalleHonor.InsertCommand.Parameters("@MONTO_FEBRERO").Value = dr("MONTO_FEBRERO")
        daDetatalleHonor.InsertCommand.Parameters("@MONTO_MARZO").Value = dr("MONTO_MARZO")
        daDetatalleHonor.InsertCommand.Parameters("@MONTO_ABRIL").Value = dr("MONTO_ABRIL")
        daDetatalleHonor.InsertCommand.Parameters("@MONTO_MAYO").Value = dr("MONTO_MAYO")
        daDetatalleHonor.InsertCommand.Parameters("@MONTO_JUNIO").Value = dr("MONTO_JUNIO")
        daDetatalleHonor.InsertCommand.Parameters("@MONTO_JULIO").Value = dr("MONTO_JULIO")
        daDetatalleHonor.InsertCommand.Parameters("@MONTO_AGOSTO").Value = dr("MONTO_AGOSTO")
        daDetatalleHonor.InsertCommand.Parameters("@MONTO_SEPTIEMBRE").Value = dr("MONTO_SEPTIEMBRE")
        daDetatalleHonor.InsertCommand.Parameters("@MONTO_OCTUBRE").Value = dr("MONTO_OCTUBRE")
        daDetatalleHonor.InsertCommand.Parameters("@MONTO_NOVIEMBRE").Value = dr("MONTO_NOVIEMBRE")
        daDetatalleHonor.InsertCommand.Parameters("@MONTO_DICIEMBRE").Value = dr("MONTO_DICIEMBRE")
        daDetatalleHonor.InsertCommand.Parameters("@PERIODO_ID").Value = dr("PERIODO_ID")
        daDetatalleHonor.InsertCommand.Parameters("@FECHA_CONTRATO_DESDE").Value = dr("FECHA_CONTRATO_DESDE")
        daDetatalleHonor.InsertCommand.Parameters("@FECHA_CONTRATO_HASTA").Value = dr("FECHA_CONTRATO_HASTA")
        daDetatalleHonor.InsertCommand.Parameters("@NRO_SOLUCION").Value = dr("NRO_SOLUCION")
        daDetatalleHonor.InsertCommand.Parameters("@FECHA_RESOLUCION").Value = dr("FECHA_RESOLUCION")
        daDetatalleHonor.InsertCommand.Parameters("@OBSERVACION").Value = dr("OBSERVACION")
        daDetatalleHonor.InsertCommand.Parameters("@MONTO_VIGENTE").Value = dr("MONTO_VIGENTE")
        daDetatalleHonor.InsertCommand.Parameters("@ES_RETIRO_EMPLEADO").Value = dr("ES_RETIRO_EMPLEADO")
        daDetatalleHonor.InsertCommand.Parameters("@MOTIVO_RETIRO_ID").Value = dr("MOTIVO_RETIRO_ID")
        Try
            Me.Tables(Tablas.RH_PER_ANTECEDENTE_HONORARIO_DETALLE).Rows.Add(dr)
            daDetatalleHonor.Update(Me, Tablas.RH_PER_ANTECEDENTE_HONORARIO_DETALLE)
            Return (dr)
        Catch exSQL As SqlException
            Debug.WriteLine(exSQL.ToString)
            Throw New Exception(exSQL.Message)
            'Se destruye el objeto DataAdapter
        End Try
    End Function

    Public Function ActulizaEmpleadoCurriculumLaboral(ByVal dr As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ANTECEDENTES_CURRICULARES, ArgoConfiguracion.ConnectionString)
        da.Fill(Me, Tablas.RH_PER_ANTECEDENTE_CURRI)
        da.InsertCommand = Me.GetUpdateCmdDatosAntecedenteCurricular()
        da.InsertCommand.Parameters("@EMPLEADO_ID").Value = dr("EMPLEADO_ID")
        da.InsertCommand.Parameters("@ESTADO_REGISTRO").Value = dr("ESTADO_REGISTRO")
        da.InsertCommand.Parameters("@PROFESION_OFICIO_ID").Value = dr("PROFESION_OFICIO_ID")
        da.InsertCommand.Parameters("@OTROS_ESTUDIOS").Value = dr("OTROS_ESTUDIOS")
        da.InsertCommand.Parameters("@EXPERIENCIA_LABORAL").Value = dr("EXPERIENCIA_LABORAL")
        Me.Tables(Tablas.RH_PER_ANTECEDENTE_CURRI).Rows.Add(dr)
        Try
            da.Update(Me, Tablas.RH_PER_ANTECEDENTE_CURRI)
            Return (dr)
        Catch exSQL As SqlException
            Debug.WriteLine(exSQL.ToString)
            Throw New Exception(exSQL.Message)
            'Se destruye el objeto DataAdapter
        End Try
    End Function

    Public Function InsertaEmpleadoAPV(ByVal empleadoApv As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ANTECEDENTE_APV, ArgoConfiguracion.ConnectionString)
        da.Fill(Me, Tablas.RH_PER_ANTECEDENTE_APV)
        da.InsertCommand = Me.GetUpdateCmdDatosApv()
        da.InsertCommand.Parameters("@ESTADO_REGISTRO").Value = empleadoApv("ESTADO_REGISTRO")
        da.InsertCommand.Parameters("@EMPLEADO_ID").Value = empleadoApv("EMPLEADO_ID")
        da.InsertCommand.Parameters("@TIPO_AHORRO_PREVISIONAL").Value = empleadoApv("TIPO_AHORRO_PREVISIONAL")
        da.InsertCommand.Parameters("@APV_ID").Value = empleadoApv("APV_ID")
        da.InsertCommand.Parameters("@MONTO_AHORRO").Value = empleadoApv("MONTO_AHORRO")
        da.InsertCommand.Parameters("@MONEDA_AHORRO_APV_ID").Value = empleadoApv("MONEDA_AHORRO_APV_ID")
        da.InsertCommand.Parameters("@PERIODO_ID").Value = empleadoApv("PERIODO_ID")
        Me.Tables(Tablas.RH_PER_ANTECEDENTE_APV).Rows.Add(empleadoApv)
        Try
            da.Update(Me, Tablas.RH_PER_ANTECEDENTE_APV)
            Return (empleadoApv)
        Catch exSQL As SqlException
            Debug.WriteLine(exSQL.ToString)
            Throw New Exception(exSQL.Message)
            'Se destruye el objeto DataAdapter
        End Try
    End Function
    Public Function InsertaEmpleadoRemun(ByVal empleadoRemun As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ANTECEDENTES_REMUN, ArgoConfiguracion.ConnectionString)
        ''da.Fill(Me, Tablas.RH_PER_ANTECEDENTE_REMUN)
        da.InsertCommand = Me.GetUpdateCmdDatosRemun()
        da.InsertCommand.Parameters("@ESTADO_REGISTRO").Value = empleadoRemun("ESTADO_REGISTRO")
        da.InsertCommand.Parameters("@EMPLEADO_ID").Value = empleadoRemun("EMPLEADO_ID")
        da.InsertCommand.Parameters("@FONDO_BIENESTAR").Value = empleadoRemun("FONDO_BIENESTAR")
        da.InsertCommand.Parameters("@FECHA_ING_FONDO_BIENESTAR").Value = empleadoRemun("FECHA_ING_FONDO_BIENESTAR")
        da.InsertCommand.Parameters("@ASOCIACION_GREMIAL_ID").Value = empleadoRemun("ASOCIACION_GREMIAL_ID")
        da.InsertCommand.Parameters("@FECHA_ING_ASOC_GREMIAL").Value = empleadoRemun("FECHA_ING_ASOC_GREMIAL")
        da.InsertCommand.Parameters("@FORMA_PAGO").Value = empleadoRemun("FORMA_PAGO")
        da.InsertCommand.Parameters("@TIPO_CUENTA_BANCO_ID").Value = empleadoRemun("TIPO_CUENTA_BANCO_ID")
        da.InsertCommand.Parameters("@NRO_CUENTA_BANCO").Value = empleadoRemun("NRO_CUENTA_BANCO")
        da.InsertCommand.Parameters("@BANCO_ID").Value = empleadoRemun("BANCO_ID")
        da.InsertCommand.Parameters("@ASIGNACION_PROFESIONAL").Value = empleadoRemun("ASIGNACION_PROFESIONAL")
        da.InsertCommand.Parameters("@RENTA_BASE").Value = empleadoRemun("RENTA_BASE")
        da.InsertCommand.Parameters("@NUMERO_BIENIOS").Value = empleadoRemun("NUMERO_BIENIOS")
        da.InsertCommand.Parameters("@FECHA_CUMPLIO_BIENIOS").Value = empleadoRemun("FECHA_CUMPLIO_BIENIOS")
        da.InsertCommand.Parameters("@TRAMO_ASIGNACION_FAMILIAR_ID").Value = empleadoRemun("TRAMO_ASIGNACION_FAMILIAR_ID")
        da.InsertCommand.Parameters("@CARGAS_FAM_NORMALES").Value = empleadoRemun("CARGAS_FAM_NORMALES")
        da.InsertCommand.Parameters("@CARGAS_FAM_INVALIDAS").Value = empleadoRemun("CARGAS_FAM_INVALIDAS")
        da.InsertCommand.Parameters("@CARGAS_FAM_PRENATAL").Value = empleadoRemun("CARGAS_FAM_PRENATAL")
        da.InsertCommand.Parameters("@MONTO_SUELDO_BASE").Value = empleadoRemun("MONTO_SUELDO_BASE")
        da.InsertCommand.Parameters("@MONTO_ASIGNACION_PROFESIONAL").Value = empleadoRemun("MONTO_ASIGNACION_PROFESIONAL")
        da.InsertCommand.Parameters("@MONTO_ASIGNACION_RESPONSABILIDAD_SUPERIOR").Value = empleadoRemun("MONTO_ASIGNACION_RESPONSABILIDAD_SUPERIOR")
        da.InsertCommand.Parameters("@MONTO_ASIGNACION_LEY19185_ART18").Value = empleadoRemun("MONTO_ASIGNACION_LEY19185_ART18")
        da.InsertCommand.Parameters("@CLASIFICACION_INE").Value = empleadoRemun("CLASIFICACION_INE")
        da.InsertCommand.Parameters("@ULTIMO_PERIODO_REMUNERACION").Value = empleadoRemun("ULTIMO_PERIODO_REMUNERACION")
        da.InsertCommand.Parameters("@GASTO_REPRESENTACION").Value = empleadoRemun("GASTO_REPRESENTACION")
        da.InsertCommand.Parameters("@MONTO_GASTO_REPRESENTACION").Value = empleadoRemun("MONTO_GASTO_REPRESENTACION")
        da.InsertCommand.Parameters("@MONTO_FUNCION_CRITICA").Value = empleadoRemun("MONTO_FUNCION_CRITICA")
        da.InsertCommand.Parameters("@MONTO_ASIGNACION_LEY18717").Value = empleadoRemun("MONTO_ASIGNACION_LEY18717")
        da.InsertCommand.Parameters("@MONTO_LEY18675_ART10").Value = empleadoRemun("MONTO_LEY18675_ART10")
        da.InsertCommand.Parameters("@MONTO_LEY18675_ART11").Value = empleadoRemun("MONTO_LEY18675_ART11")
        da.InsertCommand.Parameters("@MONTO_LEY18566").Value = empleadoRemun("MONTO_LEY18566")
        da.InsertCommand.Parameters("@APLICA_LEY_3551").Value = empleadoRemun("APLICA_LEY_3551")
        da.InsertCommand.Parameters("@MONTO_ASIGNACION_LEY_3551").Value = empleadoRemun("MONTO_ASIGNACION_LEY_3551")
        da.InsertCommand.Parameters("@MONTO_INCREMENTO_PREVIS_DL3501").Value = empleadoRemun("MONTO_INCREMENTO_PREVIS_DL3501")
        da.InsertCommand.Parameters("@PERIODO_ID").Value = empleadoRemun("PERIODO_ID")
        da.InsertCommand.Parameters("@ANO").Value = empleadoRemun("ANO")
        da.InsertCommand.Parameters("@PORCENTAJE_LEY19863").Value = empleadoRemun("PORCENTAJE_LEY19863")
        da.InsertCommand.Parameters("@ENTREGO_BOLETA_HONORARIO").Value = empleadoRemun("ENTREGO_BOLETA_HONORARIO")
        da.InsertCommand.Parameters("@AUTORIZA_PAGO_BIENIO").Value = empleadoRemun("AUTORIZA_PAGO_BIENIO")
        da.InsertCommand.Parameters("@OBSERVACION_AUTORIZA").Value = empleadoRemun("OBSERVACION_AUTORIZA")
        da.InsertCommand.Parameters("@ENVIA_HACIA_DEXON").Value = empleadoRemun("ENVIA_HACIA_DEXON")
        da.InsertCommand.Parameters("@NUMERO_TICKET_DEXON").Value = empleadoRemun("NUMERO_TICKET_DEXON")
        Me.Tables(Tablas.RH_PER_ANTECEDENTE_REMUN).Rows.Add(empleadoRemun)
        Try
            da.Update(Me, Tablas.RH_PER_ANTECEDENTE_REMUN)
            Return (empleadoRemun)
        Catch exSQL As SqlException
            Debug.WriteLine(exSQL.ToString)
            Throw New Exception(exSQL.Message)
            'Se destruye el objeto DataAdapter
        End Try
    End Function
    Public Function InsertaEmpleadoEstructuraOrganica(ByVal empleadoEstruOrg As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ESTRUCTURA_ORGANICA, ArgoConfiguracion.ConnectionString)
        da.Fill(Me, Tablas.RH_PER_ESTRUCTURA_ORGANICA)
        da.InsertCommand = Me.GetUpdateCmdDatosEstrucOrganica()
        da.InsertCommand.Parameters("@ESTADO_REGISTRO").Value = empleadoEstruOrg("ESTADO_REGISTRO")
        da.InsertCommand.Parameters("@EMPLEADO_ID").Value = empleadoEstruOrg("EMPLEADO_ID")
        da.InsertCommand.Parameters("@ORGANIZACION_ID").Value = empleadoEstruOrg("ORGANIZACION_ID")
        da.InsertCommand.Parameters("@DIRECCION_ID").Value = empleadoEstruOrg("DIRECCION_ID")
        da.InsertCommand.Parameters("@DEPTO_ID").Value = empleadoEstruOrg("DEPTO_ID")
        da.InsertCommand.Parameters("@PERIODO_ID").Value = empleadoEstruOrg("PERIODO_ID")
        da.InsertCommand.Parameters("@EVALUADOR_DESEMPENO_ID").Value = empleadoEstruOrg("EVALUADOR_DESEMPENO_ID")
        da.InsertCommand.Parameters("@AUTORIZADOR_HORAS_EXTRAS_ID").Value = empleadoEstruOrg("AUTORIZADOR_HORAS_EXTRAS_ID")
        da.InsertCommand.Parameters("@SUB_DEPTO_ID").Value = empleadoEstruOrg("SUB_DEPTO_ID")
        Me.Tables(Tablas.RH_PER_ESTRUCTURA_ORGANICA).Rows.Add(empleadoEstruOrg)
        Try
            da.Update(Me, Tablas.RH_PER_ESTRUCTURA_ORGANICA)
            Return (empleadoEstruOrg)
        Catch exSQL As SqlException
            Debug.WriteLine(exSQL.ToString)
            Throw New Exception(exSQL.Message)
            'Se destruye el objeto DataAdapter
        End Try
    End Function
    Public Function InsertaEmpleadoEstructuraContable(ByVal empleadoEstruContab As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ESTRUCTURA_CONTABLE, ArgoConfiguracion.ConnectionString)
        da.Fill(Me, Tablas.RH_PER_ESTRUCTURA_CONTABLE)
        da.InsertCommand = Me.GetUpdateCmdDatosEstrucContable()
        da.InsertCommand.Parameters("@ESTADO_REGISTRO").Value = empleadoEstruContab("ESTADO_REGISTRO")
        da.InsertCommand.Parameters("@ORGANIZACION_ID").Value = empleadoEstruContab("ORGANIZACION_ID")
        da.InsertCommand.Parameters("@EMPLEADO_ID").Value = empleadoEstruContab("EMPLEADO_ID")
        da.InsertCommand.Parameters("@CENTRO_COSTO_CONTAB_ID").Value = empleadoEstruContab("CENTRO_COSTO_CONTAB_ID")
        da.InsertCommand.Parameters("@CENTRO_COSTO_PRESUP_ID").Value = empleadoEstruContab("CENTRO_COSTO_PRESUP_ID")
        da.InsertCommand.Parameters("@PORCENTAJE_DISTRIB").Value = empleadoEstruContab("PORCENTAJE_DISTRIB")
        da.InsertCommand.Parameters("@PERIODO_ID").Value = empleadoEstruContab("PERIODO_ID")
        Me.Tables(Tablas.RH_PER_ESTRUCTURA_CONTABLE).Rows.Add(empleadoEstruContab)
        Try
            da.Update(Me, Tablas.RH_PER_ESTRUCTURA_CONTABLE)
            Return (empleadoEstruContab)
        Catch exSQL As SqlException
            Debug.WriteLine(exSQL.ToString)
            Throw New Exception(exSQL.Message)
            'Se destruye el objeto DataAdapter
        End Try
    End Function
    Public Function InsertaEmpleadoEventoAdmin(ByVal empleadoEventoAdmin As DataRow, ByVal idTipoEventoAdmin As Integer) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_EVENTO_ADMIN, ArgoConfiguracion.ConnectionString)
        da.Fill(Me, Tablas.RH_PER_EVENTO_ADMIN)
        da.InsertCommand = Me.GetUpdateCmdDatosEventoAdmin()
        da.InsertCommand.Parameters("@TIPO_EVENTO_ADMIN_ID").Value = idTipoEventoAdmin
        da.InsertCommand.Parameters("@EMPLEADO_ID").Value = empleadoEventoAdmin("EMPLEADO_ID")
        da.InsertCommand.Parameters("@FECHA_DIGITACION").Value = empleadoEventoAdmin("FECHA_DIGITACION")
        da.InsertCommand.Parameters("@ESTADO_EVENTO_ADMIN_ID").Value = empleadoEventoAdmin("ESTADO_EVENTO_ADMIN_ID")
        da.InsertCommand.Parameters("@DIAS_SOLICITADOS").Value = empleadoEventoAdmin("DIAS_SOLICITADOS")
        da.InsertCommand.Parameters("@MOTIVO_SOLICITUD").Value = empleadoEventoAdmin("MOTIVO_SOLICITUD")
        da.InsertCommand.Parameters("@ANO").Value = empleadoEventoAdmin("ANO")
        da.InsertCommand.Parameters("@PERIODO_ID").Value = empleadoEventoAdmin("PERIODO_ID")
        Me.Tables(Tablas.RH_PER_EVENTO_ADMIN).Rows.Add(empleadoEventoAdmin)
        Try
            da.Update(Me, Tablas.RH_PER_EVENTO_ADMIN)
            Return (empleadoEventoAdmin)
        Catch exSQL As SqlException
            Debug.WriteLine(exSQL.ToString)
            Throw New Exception(exSQL.Message)
            'Se destruye el objeto DataAdapter
        End Try
    End Function
    Public Function InsertaEmpleadoSaldoDiasEventoAdmin(ByVal empleadoSaldoEventoAdmin As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_EVENTO_ADMIN_SALDO, ArgoConfiguracion.ConnectionString)
        da.Fill(Me, Tablas.RH_PER_EVENTO_ADMIN_SALDO)
        da.InsertCommand = Me.GetUpdateCmdDatosSaldoDiasEventoAdmin()
        da.InsertCommand.Parameters("@TIPO_EVENTO_ADMIN_ID").Value = empleadoSaldoEventoAdmin("TIPO_EVENTO_ADMIN_ID")
        da.InsertCommand.Parameters("@EMPLEADO_ID").Value = empleadoSaldoEventoAdmin("EMPLEADO_ID")
        da.InsertCommand.Parameters("@DIAS_PERIODO").Value = empleadoSaldoEventoAdmin("DIAS_PERIODO")
        da.InsertCommand.Parameters("@DIAS_PERIODO_ANT").Value = empleadoSaldoEventoAdmin("DIAS_PERIODO_ANT")
        da.InsertCommand.Parameters("@DIAS_ADICIONALES").Value = empleadoSaldoEventoAdmin("DIAS_ADICIONALES")
        da.InsertCommand.Parameters("@TOTAL_DIAS_ANUAL").Value = empleadoSaldoEventoAdmin("TOTAL_DIAS_ANUAL")
        da.InsertCommand.Parameters("@TOTAL_DIAS_SOLICITADOS").Value = empleadoSaldoEventoAdmin("TOTAL_DIAS_SOLICITADOS")
        da.InsertCommand.Parameters("@DIAS_PENDIENTE").Value = empleadoSaldoEventoAdmin("DIAS_PENDIENTE")
        da.InsertCommand.Parameters("@ANO").Value = empleadoSaldoEventoAdmin("ANO")
        Try
            Me.Tables(Tablas.RH_PER_EVENTO_ADMIN_SALDO).Rows.Add(empleadoSaldoEventoAdmin)
            da.Update(Me, Tablas.RH_PER_EVENTO_ADMIN_SALDO)
            Return (empleadoSaldoEventoAdmin)
        Catch exSQL As SqlException
            Debug.WriteLine(exSQL.ToString)
            Throw New Exception(exSQL.Message)
            'Se destruye el objeto DataAdapter
        End Try
    End Function

    Public Function InsertaEmpleadoLicenciaMedica(ByVal empleadoLicenciaMed As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_LICENCIA_MEDICA, ArgoConfiguracion.ConnectionString)
        'da.Fill(Me, Tablas.RH_PER_LICENCIA_MEDICA)
        da.InsertCommand = Me.GetUpdateCmdDatosLicenciaMedica()
        da.InsertCommand.Parameters("@EMPLEADO_ID").Value = empleadoLicenciaMed("EMPLEADO_ID")
        da.InsertCommand.Parameters("@NUMERO_LICENCIA").Value = empleadoLicenciaMed("NUMERO_LICENCIA")
        da.InsertCommand.Parameters("@TIPO_LICENCIA_MEDICA_ID").Value = empleadoLicenciaMed("TIPO_LICENCIA_MEDICA_ID")
        da.InsertCommand.Parameters("@ESTADO_LICENCIA").Value = empleadoLicenciaMed("ESTADO_LICENCIA")
        da.InsertCommand.Parameters("@FECHA_RECEPCION").Value = empleadoLicenciaMed("FECHA_RECEPCION")
        da.InsertCommand.Parameters("@DIAS_LICENCIA").Value = empleadoLicenciaMed("DIAS_LICENCIA")
        da.InsertCommand.Parameters("@FECHA_INICIO").Value = empleadoLicenciaMed("FECHA_INICIO")
        da.InsertCommand.Parameters("@FECHA_TERMINO").Value = empleadoLicenciaMed("FECHA_TERMINO")
        da.InsertCommand.Parameters("@FECHA_ACCIDENTE").Value = empleadoLicenciaMed("FECHA_ACCIDENTE")
        da.InsertCommand.Parameters("@FECHA_EMISION").Value = empleadoLicenciaMed("FECHA_EMISION")
        da.InsertCommand.Parameters("@TIPO_REPOSO").Value = empleadoLicenciaMed("TIPO_REPOSO")
        da.InsertCommand.Parameters("@LUGAR_REPOSO").Value = empleadoLicenciaMed("LUGAR_REPOSO")
        da.InsertCommand.Parameters("@FECHA_ENVIO_ISAPRE").Value = empleadoLicenciaMed("FECHA_ENVIO_ISAPRE")
        da.InsertCommand.Parameters("@CONTINUIDAD").Value = empleadoLicenciaMed("CONTINUIDAD")
        da.InsertCommand.Parameters("@NUMERO_LICENCIA_CONTINUIDAD").Value = empleadoLicenciaMed("NUMERO_LICENCIA_CONTINUIDAD")
        da.InsertCommand.Parameters("@FECHA_INICIO_CONTINUIDAD").Value = empleadoLicenciaMed("FECHA_INICIO_CONTINUIDAD")
        da.InsertCommand.Parameters("@DIAS_CONTINUIDAD").Value = empleadoLicenciaMed("DIAS_CONTINUIDAD")
        da.InsertCommand.Parameters("@FECHA_TERMINO_CONTINUIDAD").Value = empleadoLicenciaMed("FECHA_TERMINO_CONTINUIDAD")
        da.InsertCommand.Parameters("@PERIODO").Value = empleadoLicenciaMed("PERIODO")
        da.InsertCommand.Parameters("@FECHA_CONCEPCION").Value = empleadoLicenciaMed("FECHA_CONCEPCION")
        da.InsertCommand.Parameters("@NOMBRE_DOCTOR").Value = empleadoLicenciaMed("NOMBRE_DOCTOR")
        da.InsertCommand.Parameters("@ESPECIALIDAD").Value = empleadoLicenciaMed("ESPECIALIDAD")
        da.InsertCommand.Parameters("@TIPO_EVENTO_ADMIN_ID").Value = empleadoLicenciaMed("TIPO_EVENTO_ADMIN_ID")
        da.InsertCommand.Parameters("@NUMERO_CHEQUE").Value = empleadoLicenciaMed("NUMERO_CHEQUE")
        da.InsertCommand.Parameters("@MONTO_CHEQUE").Value = empleadoLicenciaMed("MONTO_CHEQUE")
        da.InsertCommand.Parameters("@MEMORANDUM").Value = empleadoLicenciaMed("MEMORANDUM")
        da.InsertCommand.Parameters("@OBSERVACIONES").Value = empleadoLicenciaMed("OBSERVACIONES")
        da.InsertCommand.Parameters("@FECHA_DIGITACION_PAGO").Value = empleadoLicenciaMed("FECHA_DIGITACION_PAGO")
        da.InsertCommand.Parameters("@PERIODO_ID").Value = empleadoLicenciaMed("PERIODO_ID")
        da.InsertCommand.Parameters("@RENTA_PROMEDIO_ID").Value = empleadoLicenciaMed("RENTA_PROMEDIO_ID")
        da.InsertCommand.Parameters("@FECHA_RECEPCION_ISAPRE").Value = empleadoLicenciaMed("FECHA_RECEPCION_ISAPRE")
        da.InsertCommand.Parameters("@NUMERO_FILIO").Value = empleadoLicenciaMed("NUMERO_FILIO")
        da.InsertCommand.Parameters("@CLASIFICACION").Value = empleadoLicenciaMed("CLASIFICACION")
        da.InsertCommand.Parameters("@DIAS_REDUCCION").Value = empleadoLicenciaMed("DIAS_REDUCCION")
        da.InsertCommand.Parameters("@FECHA_ESTIMADA_PAGO").Value = empleadoLicenciaMed("FECHA_ESTIMADA_PAGO")
        da.InsertCommand.Parameters("@CAUSA_RECHAZO_ID").Value = empleadoLicenciaMed("CAUSA_RECHAZO_ID")
        da.InsertCommand.Parameters("@TIPO_PROFESIONAL").Value = empleadoLicenciaMed("TIPO_PROFESIONAL")
        Me.Tables(Tablas.RH_PER_LICENCIA_MEDICA).Rows.Add(empleadoLicenciaMed)
        Try
            da.Update(Me, Tablas.RH_PER_LICENCIA_MEDICA)
            Return (empleadoLicenciaMed)
        Catch exSQL As SqlException
            Debug.WriteLine(exSQL.ToString)
            Throw New Exception(exSQL.Message)
            'Se destruye el objeto DataAdapter
        End Try
    End Function
    Public Function InsertaEmpleadoMovimientoMensual(ByVal idPeriodo As Integer, ByVal idItem As Integer, _
                                                     ByVal idEmpleado As Integer, ByVal cuotaIni As Short, _
                                                     ByVal cuotaFin As Short, ByVal origen As Integer, _
                                                     ByVal cantidad As Integer, ByVal tipoProceso As String) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand("INSERT INTO " & Tablas.RH_REM_MOVIMIENTO_MENSUAL & "(PERIODO_ID, ITEM_ID, EMPLEADO_ID, CUOTA_INICIAL,CUOTA_FINAL, ORIGEN, CANTIDAD, TIPO_PROCESO) VALUES (@PERIODO_ID, @ITEM_ID, @EMPLEADO_ID, @CUOTA_INICIAL, @CUOTA_FINAL, @ORIGEN, @CANTIDAD, @TIPO_PROCESO)")

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idPeriodo
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ITEM_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idItem
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idEmpleado
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@CUOTA_INICIAL"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.TinyInt
        prm.Value = cuotaIni
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@CUOTA_FINAL"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.TinyInt
        prm.Value = cuotaFin
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ORIGEN"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.TinyInt
        prm.Value = origen
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@CANTIDAD"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = cantidad
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_PROCESO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = tipoProceso
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Throw ex
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Function

    Public Function InsertaEmpleadoMovimientoMensual(ByVal idPeriodo As Integer, ByVal idItem As Integer, _
                                                     ByVal idEmeplado As Integer, ByVal cuotaIni As Short, _
                                                     ByVal cuotaFin As Short, ByVal origen As Integer, _
                                                     ByVal cantidad As Integer, ByVal tipoProceso As String, ByVal IDExterno As Integer, ByVal glosa As String) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand("INSERT INTO " & Tablas.RH_REM_MOVIMIENTO_MENSUAL & "(PERIODO_ID, ITEM_ID, EMPLEADO_ID, CUOTA_INICIAL,CUOTA_FINAL, ORIGEN, CANTIDAD, TIPO_PROCESO, ID_EXTERNO,GLOSA) VALUES (@PERIODO_ID, @ITEM_ID, @EMPLEADO_ID, @CUOTA_INICIAL, @CUOTA_FINAL, @ORIGEN, @CANTIDAD, @TIPO_PROCESO, @ID_EXTERNO,@GLOSA)")

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idPeriodo
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ITEM_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idItem
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idEmeplado
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@CUOTA_INICIAL"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.TinyInt
        prm.Value = cuotaIni
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@CUOTA_FINAL"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.TinyInt
        prm.Value = cuotaFin
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ORIGEN"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.TinyInt
        prm.Value = origen
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@CANTIDAD"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = cantidad
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_PROCESO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = tipoProceso
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ID_EXTERNO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = IDExterno
        cmd.Parameters.Add(prm)


        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@GLOSA"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = glosa
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Function
    Public Function InsertarEmpleadoReliquidado(ByVal idPeriodoVigente As Integer, ByVal idPeriodoHistorico As Integer, ByVal idEmpleado As Integer, ByVal tipoProceso As String) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand("EXEC " & SQL.STORE_PROCEDURES.INSERTA_EMPLEADO_RELIQUIDADO & " @PERIODO_VIGENTE_ID, @PERIODO_HISTORICO_ID, @EMPLEADO_ID, @TIPO_PROCESO")

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_VIGENTE_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idPeriodoVigente
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_HISTORICO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idPeriodoHistorico
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idEmpleado
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_PROCESO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = tipoProceso
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Function
    Public Function InsertarEmpleadoReliquidadoBonoModernidad(ByVal idPeriodoVigente As Integer, ByVal idPeriodoHistorico As Integer, ByVal idEmpleado As Integer, ByVal tipoProceso As String) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand("EXEC " & SQL.STORE_PROCEDURES.INSERTA_EMPLEADO_RELIQUIDADO_BONO_MODERNIDAD & " @PERIODO_VIGENTE_ID, @PERIODO_HISTORICO_ID, @EMPLEADO_ID, @TIPO_PROCESO")

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_VIGENTE_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idPeriodoVigente
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_HISTORICO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idPeriodoHistorico
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idEmpleado
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_PROCESO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = tipoProceso
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Function

    Public Function InsertarEmpleadoSuplementaria(ByVal idPeriodoVigente As Integer, ByVal idPeriodoHistorico As Integer, ByVal idEmpleado As Integer, ByVal tipoProceso As String) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand("EXEC " & SQL.STORE_PROCEDURES.INSERTA_EMPLEADO_SUPLEMENTARIA & " @PERIODO_VIGENTE_ID, @PERIODO_HISTORICO_ID, @EMPLEADO_ID, @TIPO_PROCESO")

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_VIGENTE_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idPeriodoVigente
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_HISTORICO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idPeriodoHistorico
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idEmpleado
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_PROCESO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = tipoProceso
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Function

    Public Function InsertarEmpleadoSuplementariaHonorario(ByVal idPeriodoVigente As Integer, ByVal idPeriodoHistorico As Integer, ByVal idEmpleado As Integer, ByVal tipoProceso As String) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand("EXEC " & SQL.STORE_PROCEDURES.INSERTA_EMPLEADO_SUPLEMENTARIA_HONORARIO & " @PERIODO_VIGENTE_ID, @PERIODO_HISTORICO_ID, @EMPLEADO_ID, @TIPO_PROCESO")

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_VIGENTE_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idPeriodoVigente
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_HISTORICO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idPeriodoHistorico
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idEmpleado
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_PROCESO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = tipoProceso
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Function

    Public Function InsertarItemReliquidado(ByVal idPeriodo As Integer, ByVal idEmpleado As Integer, ByVal tipoProceso As String) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand("EXEC " & SQL.STORE_PROCEDURES.INSERTA_EMPLEADO_ITEM_RELIQUIDADO & " @PERIODO_ID, @EMPLEADO_ID, @TIPO_PROCESO")

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idPeriodo
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idEmpleado
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_PROCESO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = tipoProceso
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Function
    Public Function InsertarRentaPromedioLicenciaMedica(ByVal idLicenciaMedica As Integer) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand("EXEC " & SQL.STORE_PROCEDURES.INSERTA_RENTA_PROMEDIO_EMPLEADO_LIC_MEDICA & " @LICENCIA_MEDICA_ID")

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@LICENCIA_MEDICA_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idLicenciaMedica
        cmd.Parameters.Add(prm)



        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Function

    Public Function crearEmpleadoLaboralParaProcesoBonoModenizacion(ByVal idPeriodo As Integer, ByVal idEmpleado As Integer) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand("EXEC " & SQL.STORE_PROCEDURES.CREA_ANTECEDENTE_LABORAL_PARA_BONO_MODERNIZACION & " @PERIODO_ID, @EMPLEADO_ID")

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idPeriodo
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idEmpleado
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Function
    Public Function crearEmpleadoBonoModernizacion(ByVal idEmpleado As Integer, ByVal anno As Integer, _
                                                   ByVal dias As Integer, ByVal baseBono As Decimal, _
                                                   ByVal institucional As Decimal, ByVal colectivo As Decimal, _
                                                   ByVal fechaIngreso As Date, ByVal total As Decimal) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand("EXEC " & SQL.STORE_PROCEDURES.INSERTA_EMPLEADO_BONO_MODERNIZACION & " @EMPLEADO_ID, @ANO, @DIAS, @BASE_BONO, @INSTITUCIONAL, @COLECTIVO, @FECHA_ING_INSTITUCION, @TOTAL")

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idEmpleado
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ANO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = anno
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@DIAS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = dias
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@BASE_BONO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Decimal
        prm.Value = baseBono
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@INSTITUCIONAL"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Decimal
        prm.Value = institucional
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@COLECTIVO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Decimal
        prm.Value = colectivo
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_ING_INSTITUCION"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = fechaIngreso
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TOTAL"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Decimal
        prm.Value = total
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Function

    Public Function eliminaLiquidacioneEmpleado(ByVal idPeriodo As Integer, ByVal idEmpleado As Integer, ByVal tipoProceso As String) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand("EXEC " & SQL.STORE_PROCEDURES.ELIMINA_LIQUIDACION_EMPELADO & " @PERIODO_ID, @EMPLEADO_ID, @TIPO_CALCULO")

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idPeriodo
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idEmpleado
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_CALCULO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = tipoProceso
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Function

    Public Function elimnaLiquidacionSinDetalle(ByVal idPeriodo As Integer) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand("EXEC sp_eliminaLiquidacionesSinDetalle @PERIODO_ID")

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idPeriodo
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Function

    Public Function calcularFechaTerminoEventoAdministrativo(ByVal diasSolicitados As Decimal, ByVal fechaInicio As Date) As Date
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        Dim fechaTermino As Date

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.GENERA_FECHA_TERMINO_EVENTO_ADMINISTRATIVO
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@DIAS_SOLICITADOS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Decimal
        prm.Value = diasSolicitados
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_INICIO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = fechaInicio
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_TERMINO"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.DateTime
        cmd.Parameters.Add(prm)

        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            fechaTermino = cmd.Parameters("@FECHA_TERMINO").Value()
            Return fechaTermino
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return Nothing
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Function
    Public Function calcularFechaRetornoEventoAdministrativo(ByVal fechaInicio As Date) As Date
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        Dim fechaTermino As Date

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.GENERA_FECHA_RETORNO_EVENTO_ADMINISTRATIVO
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_INICIO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = fechaInicio
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_TERMINO"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.DateTime
        cmd.Parameters.Add(prm)

        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            fechaTermino = cmd.Parameters("@FECHA_TERMINO").Value()
            Return fechaTermino
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return Nothing
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Function

    Public Function insertarEgresoCabecera(ByVal numeroCheque As Integer, ByVal fechaCheque As Date, ByVal montoCheque As Integer, ByVal nombreCheque As String, ByVal origenId As Integer, ByVal concepto As String, ByVal organizacionId As Integer) As Integer
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        Dim egresoId As Integer

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_EGRESO_CABECERA
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@NUMERO_CHEQUE"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = numeroCheque
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_CHEQUE"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = fechaCheque
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MONTO_CHEQUE"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = montoCheque
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@NOMBRE"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = nombreCheque
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ORIGEN_EGRESO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = origenId
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@CONCEPTO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = concepto
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ORGANIZACION_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = organizacionId
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EGRESO_ID"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.Int
        cmd.Parameters.Add(prm)

        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            egresoId = cmd.Parameters("@EGRESO_ID").Value()
            Return egresoId
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return Nothing
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Function

    Public Function insertarChequeTesoreria(ByVal numeroCheque As Integer, ByVal fechaCheque As Date, ByVal egresoId As Integer, ByVal tesoreriaId As Integer, ByVal ImpresionId As Integer) As Integer
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_EGRESO_CABECERA
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@NUMERO_CHEQUE"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = numeroCheque
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_CHEQUE"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = fechaCheque
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EGRESO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = egresoId
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TESORERIA_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = tesoreriaId
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@IMPRESION_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = ImpresionId
        cmd.Parameters.Add(prm)

        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return 0
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Function

    Public Function buscaFechaFestivo(ByVal fecha As Date, ByVal tipoMensaje As Integer) As Integer
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.BUSCA_FECHA_FESTIVO
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = fecha
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@RETORNO"
        prm.Direction = ParameterDirection.Output
        prm.SqlDbType = SqlDbType.Int
        cmd.Parameters.Add(prm)

        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            tipoMensaje = cmd.Parameters("@RETORNO").Value()
            Return tipoMensaje
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return Nothing
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try

    End Function
    Public Function Elimina(ByVal empleado As DataRow) As DataRow
        da.Fill(Me, NOMBRE_TABLA)
        Me.Tables(NOMBRE_TABLA).Rows.Remove(empleado)
        da.DeleteCommand = Me.GetDeleteCommand
        da.Update(Me, NOMBRE_TABLA)
        Return (empleado)
    End Function

    Public Sub Elimina(ByVal myExecuteQuery As String)
        Try
            Dim myConnection As New SqlConnection
            myConnection.ConnectionString = ArgoConfiguracion.ConnectionString
            Dim myCommand As New SqlCommand(myExecuteQuery, myConnection)
            myCommand.Connection.Open()
            myCommand.ExecuteNonQuery()
            myConnection.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub
    Public Sub EjecutaSQL(ByVal myExecuteQuery As String)
        Try
            Dim myConnection As New SqlConnection
            myConnection.ConnectionString = ArgoConfiguracion.ConnectionString
            Dim myCommand As New SqlCommand(myExecuteQuery, myConnection)
            myCommand.CommandTimeout = ArgoConfiguracion.CommandTimeout
            myCommand.Connection.Open()
            myCommand.ExecuteNonQuery()
            myConnection.Close()
        Catch exSQL As Exception
            Throw New Exception(exSQL.Message)
        End Try
    End Sub
    Public Function Actualiza(ByVal empleado As DataRow) As DataRow
        Me.Tables(NOMBRE_TABLA).LoadDataRow(empleado.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand
        da.Update(Me, NOMBRE_TABLA)
        Return (empleado)
    End Function
    Public Function Actualiza(ByVal empleado As DataRow, ByVal nombreTabla As String) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_EVENTO_ADMIN_SALDO, ArgoConfiguracion.ConnectionString)
        Me.Tables(nombreTabla).LoadDataRow(empleado.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand(da)
        da.Update(Me, nombreTabla)
        Return (empleado)
    End Function

    Public Function Busca(ByVal Rut As Integer) As DataRow
        da = New SqlDataAdapter("SELECT * FROM " & NOMBRE_TABLA & " WHERE RUT=" & Rut, ArgoConfiguracion.ConnectionString)
        da.Fill(Me, NOMBRE_TABLA)
        Try
            Return Me.Tables(NOMBRE_TABLA).Rows.Find(Busca("SELECT * FROM " & NOMBRE_TABLA & " WHERE RUT=" & Rut, 1))
            'Ojo, en la línea anterior se hace uso del ultimo parámetro de Busca() para que se informe la columna del ID
        Catch excepcion As Exception
            Return Nothing
        End Try
    End Function

    Public Function Busca(ByVal ID As Long) As DataRow
        da = New SqlDataAdapter("SELECT * FROM " & NOMBRE_TABLA & " WHERE EMPLEADO_ID=" & ID, ArgoConfiguracion.ConnectionString)
        da.Fill(Me, NOMBRE_TABLA)
        Try
            Return Me.Tables(NOMBRE_TABLA).Rows.Find(ID)
        Catch excepcion As Exception
            Return Nothing
        End Try
    End Function

    Public Function Busca(ByVal ID As Long, ByVal NOMBRE_TABLA As String) As DataRow
        da.Fill(Me, NOMBRE_TABLA)
        Try
            Return Me.Tables(NOMBRE_TABLA).Rows.Find(ID)
        Catch excepcion As Exception
            Return Nothing
        End Try
    End Function

    Public Function Busca(ByVal ID As Long, ByVal NOMBRE_TABLA As String, ByVal SQL As String) As DataRow
        Dim da As New SqlDataAdapter(SQL, ArgoConfiguracion.ConnectionString)
        da.Fill(Me, NOMBRE_TABLA)
        Try
            Return (Me.Tables(NOMBRE_TABLA).Rows.Find(ID))
        Catch excepcion As Exception
            Return Nothing
        End Try
    End Function
    Public Function Busca(ByVal DS As DataSet, ByVal ID As Long, ByVal NOMBRE_TABLA As String, ByVal SQL As String) As DataRow
        Dim da As New SqlDataAdapter(SQL, ArgoConfiguracion.ConnectionString)
        da.Fill(DS, NOMBRE_TABLA)
        Try
            Return DS.Tables(NOMBRE_TABLA).Rows.Find(ID)
        Catch excepcion As Exception
            Return Nothing
        End Try
    End Function
    Public Function Busca(ByVal SQL As String) As Integer
        Dim mySelectQuery As String = SQL
        Dim myConnection As New SqlConnection(conn.ConnectionString)
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
    Public Function BuscaDecimal(ByVal SQL As String) As Decimal
        Dim mySelectQuery As String = SQL
        Dim myConnection As New SqlConnection(conn.ConnectionString)
        Dim myCommand As New SqlCommand(mySelectQuery, myConnection)
        Dim valorID As Decimal

        Try
            myConnection.Open()
            Dim myReader As SqlDataReader
            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                valorID = myReader.GetDecimal(0)
            End While
            myReader.Close()
            myConnection.Close()
            Return valorID
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function Busca(ByVal SQL As String, ByVal indiceColumnaID As Integer) As Integer
        Dim mySelectQuery As String = SQL
        Dim myConnection As New SqlConnection(conn.ConnectionString)
        Dim myCommand As New SqlCommand(mySelectQuery, myConnection)
        Dim valorID As Integer

        Try
            myConnection.Open()
            Dim myReader As SqlDataReader
            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                valorID = myReader.GetValue(indiceColumnaID)
            End While
            myReader.Close()
            myConnection.Close()
            Return valorID
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function BuscaString(ByVal SQL As String) As String
        Dim mySelectQuery As String = SQL
        Dim myConnection As New SqlConnection(conn.ConnectionString)
        Dim myCommand As New SqlCommand(mySelectQuery, myConnection)
        Dim valorString As String = ""

        Try
            myConnection.Open()
            Dim myReader As SqlDataReader
            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                valorString = myReader.GetString(0)
            End While
            myReader.Close()
            myConnection.Close()
            Return valorString
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperaIdentificador(ByVal nombreTabla As String) As Integer
        Dim cmdGetIdentity As SqlClient.SqlCommand
        Dim conn As SqlConnection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        Dim Identity As Integer = 0
        Try
            conn.Open()
            cmdGetIdentity = New SqlCommand("SELECT IDENT_CURRENT('" & nombreTabla.ToString & "')", conn)

            Return cmdGetIdentity.ExecuteScalar()
            conn.Close()
            cmdGetIdentity.Dispose()
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Private Function GetInsertCommand() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_EMPLEADO_DATOS_PERSONALES

        sqlParam = New SqlClient.SqlParameter("@ORGANIZACION_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ESTADO_EMPLEADO_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@RUT", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@DV", SqlDbType.Char)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NOMBRES", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@APELLIDO_PATERNO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@APELLIDO_MATERNO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_NACIMIENTO", SqlDbType.DateTime, 8)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@SEXO", SqlDbType.Char)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ESTADO_CIVIL", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@VILLA_POBLACION", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NUMERO_DIRECCION", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CALLE_AVDA", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@TELEFONO_PARTICULAR", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CELULAR", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PAIS_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@REGION_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@COMUNA_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CIUDAD_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ANEXO_TELEFONO_OFI", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CONTACTO_EMERGENCIA", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@SITUACION_MILITAR", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NRO_MATRICULA_MILITAR", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@GRUPO_SANGUINEO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ALERGICO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@SUFRE_ENFERMEDAD", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MEDICAMENTOS", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NIVEL_ESTUDIO_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CODIGO_POSTAL", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@Identity", SqlDbType.BigInt, 0, "EMPLEADO_ID")
        sqlParam.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(sqlParam)

        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout
        Return (sqlCmd)
    End Function

    Private Function GetUpdateCommand() As SqlCommand
        Dim cb As New SqlCommandBuilder(da)
        Return (cb.GetUpdateCommand())
        cb = Nothing
    End Function
    Private Function GetUpdateCommand(ByVal da As SqlDataAdapter) As SqlCommand
        Dim cb As New SqlCommandBuilder(da)
        Return (cb.GetUpdateCommand())
        cb = Nothing
    End Function
    Private Function GetDeleteCommand() As SqlCommand
        Dim cb As New SqlCommandBuilder(da)
        Return (cb.GetDeleteCommand())
        cb = Nothing
    End Function
    Private Function GetDeleteCommandEmpleadoAPV() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.ELIMINA_EMPLEADO_APV
        sqlParam = New SqlClient.SqlParameter("@ANTECEDENTE_APV_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)
        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout
        Return (sqlCmd)
    End Function
#End Region

#Region "Métodos Complementarios"

    Private Sub getCommands(ByRef da As SqlDataAdapter, ByVal strSQL As String)
        Dim cb As New SqlCommandBuilder(da)
        Try
            da.SelectCommand = New SqlCommand(strSQL)
            da.SelectCommand.Connection = conn
        Catch ex As Exception
            Debug.WriteLine(EX.Message)
        End Try
        Try
            da.InsertCommand = cb.GetInsertCommand
            da.InsertCommand.Connection = conn
        Catch ex As Exception
            Debug.WriteLine(EX.Message)
        End Try
        Try
            da.DeleteCommand = cb.GetDeleteCommand
            da.DeleteCommand.Connection = conn
        Catch ex As Exception
            Debug.WriteLine(EX.Message)
        End Try
        Try
            da.UpdateCommand = cb.GetUpdateCommand
            da.UpdateCommand.Connection = conn
        Catch ex As Exception
            Debug.WriteLine(EX.Message)
        End Try
        cb = Nothing
    End Sub

    Public Function actualizarTablaImpuestos() As Boolean
        'Inicializacion del DataAdapter
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_PERIODO)
        Try
            da.Update(Me, Tablas.RH_REM_PERIODO)
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function actualizarDatosCurriculares() As Boolean
        'Inicializacion del DataAdapter
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_ANTECEDENTES_CURRICULARES)
        Try
            da.Update(Me, Tablas.RH_PER_ANTECEDENTE_CURRI)
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function
    Public Function actualizarDatosHorasExtras() As Boolean
        'Inicializacion del DataAdapter
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_RH_PER_HORAS_EXTRAS)
        Try
            da.Update(Me, Tablas.RH_PER_HORAS_EXTRAS)
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function
    Public Function actualizarDatosItemes() As Boolean
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_MOVIMIENTO_MENSUAL)
        Try
            da.Update(Me, Tablas.RH_REM_MOVIMIENTO_MENSUAL)
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function
    Public Function actualizarDatosEUS() As Boolean
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_EUS)
        Try
            da.Update(Me, Tablas.RH_REM_EUS)
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function actualizarDatosBonoModernizacion() As Boolean
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_BONO_MODERNIZACION)
        Try
            da.Update(Me, Tablas.RH_REM_BONO_MODERNIZACION)
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function actualizarDetalleEventoAdmin() As Boolean
        'Inicializacion del DataAdapter
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_EVENTO_ADMIN_DET)
        Try
            da.Update(Me, Tablas.RH_PER_EVENTO_ADMIN_DET)
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function
    Public Function actualizarSaldoDiasEventoAdmin() As Boolean
        'Inicializacion del DataAdapter
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_EVENTO_ADMIN_SALDO)
        Try
            da.Update(Me, Tablas.RH_PER_EVENTO_ADMIN_SALDO)
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function


    Public Function actualizarPermisoPaternal() As Boolean
        'Inicializacion del DataAdapter
        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_EVENTO_ADMIN)

        Try
            da.Update(Me, Tablas.RH_PER_EVENTO_ADMIN)
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function


    Public Function actualizarDatosAcademicos() As Boolean
        'Inicializacion del DataAdapter

        Dim da As New SqlDataAdapter
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_ANTECEDENTES_ACADEMICOS)
        Try
            da.Update(Me, Tablas.RH_PER_ANTECEDENTE_ACADEM)
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function actualizarDatosAPV() As Boolean
        'Inicializacion del DataAdapter

        Dim da As New SqlDataAdapter
        Dim cb As New SqlCommandBuilder(da)
        getCommands(da, SQL.INSTRUCCIONES_SQL.SELECT_ANTECEDENTE_APV)
        da.Fill(Me, "RH_PER_ANTECEDENTE_APV")
        Try
            da.Update(Me, Tablas.RH_PER_ANTECEDENTE_APV)
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function actualizarDatosPrevisionales(ByVal empleadoPrevisDR As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ANTECEDENTES_PREVISIONALES, ArgoConfiguracion.ConnectionString)
        Me.Tables(Tablas.RH_PER_ANTECEDENTE_PREVIS).LoadDataRow(empleadoPrevisDR.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand(da)
        da.Update(Me, Tablas.RH_PER_ANTECEDENTE_PREVIS)
        Return (empleadoPrevisDR)
    End Function
    Public Function actualizarDatosAPV(ByVal empleadoApvDR As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ANTECEDENTE_APV, ArgoConfiguracion.ConnectionString)
        Me.Tables(Tablas.RH_PER_ANTECEDENTE_APV).LoadDataRow(empleadoApvDR.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand(da)
        da.Update(Me, Tablas.RH_PER_ANTECEDENTE_APV)
        Return (empleadoApvDR)
    End Function
    Public Function actualizarDatosRemun(ByVal empleadoremunDR As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ANTECEDENTES_REMUN, ArgoConfiguracion.ConnectionString)
        Me.Tables(Tablas.RH_PER_ANTECEDENTE_REMUN).LoadDataRow(empleadoremunDR.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand(da)
        da.Update(Me, Tablas.RH_PER_ANTECEDENTE_REMUN)
        Return (empleadoremunDR)
    End Function
    Public Function actualizarDatosLaboral(ByVal empleadoLaboralDR As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ANTECEDENTES_LABORALES, ArgoConfiguracion.ConnectionString)
        Me.Tables(Tablas.RH_PER_ANTECEDENTE_LABORAL).LoadDataRow(empleadoLaboralDR.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand(da)
        da.Update(Me, Tablas.RH_PER_ANTECEDENTE_LABORAL)
        Return (empleadoLaboralDR)
    End Function
    Public Function actualizarDatosEstructuraOrganica(ByVal empleadoEstrucOrgDR As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ESTRUCTURA_ORGANICA, ArgoConfiguracion.ConnectionString)
        Me.Tables(Tablas.RH_PER_ESTRUCTURA_ORGANICA).LoadDataRow(empleadoEstrucOrgDR.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand(da)
        da.Update(Me, Tablas.RH_PER_ESTRUCTURA_ORGANICA)
        Return (empleadoEstrucOrgDR)
    End Function
    Public Function actualizarDatosEstructuraContable(ByVal empleadoEstrucContabDR As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ESTRUCTURA_CONTABLE, ArgoConfiguracion.ConnectionString)
        Me.Tables(Tablas.RH_PER_ESTRUCTURA_CONTABLE).LoadDataRow(empleadoEstrucContabDR.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand(da)
        da.Update(Me, Tablas.RH_PER_ESTRUCTURA_CONTABLE)
        Return (empleadoEstrucContabDR)
    End Function

    Public Function actualizarDatosLicenciaMedica(ByVal empleadoLicenciaMedDR As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_LICENCIA_MEDICA, ArgoConfiguracion.ConnectionString)
        Me.Tables(Tablas.RH_PER_LICENCIA_MEDICA).LoadDataRow(empleadoLicenciaMedDR.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand(da)
        da.Update(Me, Tablas.RH_PER_LICENCIA_MEDICA)
        Return (empleadoLicenciaMedDR)
    End Function

    Public Function actualizarEventoAdmin(ByVal empleadoremunDR As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_EVENTO_ADMIN, ArgoConfiguracion.ConnectionString)
        Me.Tables(Tablas.RH_PER_EVENTO_ADMIN).LoadDataRow(empleadoremunDR.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand(da)
        da.Update(Me, Tablas.RH_PER_EVENTO_ADMIN)
        Return (empleadoremunDR)
    End Function

    Public Function actualizaDatosPresupuestoAnualHonorario(ByVal dr As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ANTECEDENTE_PRESUP_ANUAL_HONORARIO_DETALLE, ArgoConfiguracion.ConnectionString)
        Me.Tables(Tablas.RH_PER_ANTECEDENTE_HONORARIO_DETALLE).LoadDataRow(dr.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand(da)
        da.Update(Me, Tablas.RH_PER_ANTECEDENTE_HONORARIO_DETALLE)
        Return (dr)
    End Function

    Public Function actualizaDatosAntecedenteCurricular(ByVal dr As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_ANTECEDENTES_CURRICULARES, ArgoConfiguracion.ConnectionString)
        Me.Tables(Tablas.RH_PER_ANTECEDENTE_CURRI).LoadDataRow(dr.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand(da)
        da.Update(Me, Tablas.RH_PER_ANTECEDENTE_CURRI)
        Return (dr)
    End Function

    Public Function actualizarDatosCargaFAM(ByVal DS As DataSet, ByVal cargaFAMDR As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_CARGA_FAM, ArgoConfiguracion.ConnectionString)
        DS.Tables(Tablas.RH_PER_CARGA_FAMILIAR).LoadDataRow(cargaFAMDR.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand(da)
        da.Update(DS, Tablas.RH_PER_CARGA_FAMILIAR)
        Return (cargaFAMDR)
    End Function
    Public Function actualizarDatosViatico(ByVal DS As DataSet, ByVal viaticoDR As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_VIATICO, ArgoConfiguracion.ConnectionString)
        DS.Tables(Tablas.RH_PER_VIATICO).LoadDataRow(viaticoDR.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand(da)
        da.Update(DS, Tablas.RH_PER_VIATICO)
        Return (viaticoDR)
    End Function
    Public Function actualizarDatosDetalleViatico(ByVal DS As DataSet, ByVal viaticoDR As DataRow) As DataRow
        Dim da As New SqlDataAdapter(SQL.INSTRUCCIONES_SQL.SELECT_DETALLE_VIATICO, ArgoConfiguracion.ConnectionString)
        DS.Tables(Tablas.RH_PER_VIATICO_DETALLE).LoadDataRow(viaticoDR.ItemArray, False)
        da.UpdateCommand = Me.GetUpdateCommand(da)
        da.Update(DS, Tablas.RH_PER_VIATICO_DETALLE)
        Return (viaticoDR)
    End Function

    Public Function actulizarAprobacionBienio(ByVal antecedenteRemunId As Integer, ByVal autorizaBienio As Boolean) As Integer
        Dim autoriza As Integer
        If autorizaBienio Then
            autoriza = 1
        Else
            autoriza = 0
        End If
        Dim mySelectQuery As String = " UPDATE RH_PER_ANTECEDENTE_REMUN SET AUTORIZA_PAGO_BIENIO = " + autoriza.ToString + ", OBSERVACION_AUTORIZA='APROBADO POR:' + USER + ' ' + CONVERT(VARCHAR(10),GETDATE(),103)+' '+CONVERT(VARCHAR(10),GETDATE(),108) WHERE ANTECEDENTE_REMUN_ID = " + antecedenteRemunId.ToString
        Dim myConnection As New SqlConnection(conn.ConnectionString)
        Dim myCommand As New SqlCommand(mySelectQuery, myConnection)

        Try
            myConnection.Open()
            myCommand.ExecuteReader()
            myConnection.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function recuperaAntecedentesCurriculares(ByVal IDEmpleado As Long) As DataRow
        Dim valorID As Integer
        valorID = Busca("SELECT ANTECEDENTE_CURRI_ID FROM " & Tablas.RH_PER_ANTECEDENTE_CURRI & " WHERE EMPLEADO_ID = " & IDEmpleado & " AND ESTADO_REGISTRO=1")

        Try
            Dim daHonorario As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_ANTECEDENTE_CURRI & " WHERE ANTECEDENTE_CURRI_ID=" & valorID, ArgoConfiguracion.ConnectionString)
            daHonorario.Fill(Me, Tablas.RH_PER_ANTECEDENTE_CURRI)
            Dim empleadoHonorDR As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_CURRIRow
            empleadoHonorDR = CType(RH_PER_ANTECEDENTE_CURRI.Rows.Find(valorID), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_CURRIRow)
            Return empleadoHonorDR
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperaEventoAdmin(ByVal ID As Long) As DataView
        Try
            da.Fill(Me, Tablas.RH_PER_EVENTO_ADMIN)
            Dim daEventoAdmin As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_EVENTO_ADMIN & " WHERE EMPLEADO_ID=" & ID, ArgoConfiguracion.ConnectionString)
            daEventoAdmin.Fill(Me, Tablas.RH_PER_EVENTO_ADMIN)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_PER_EVENTO_ADMIN))
            dv.RowFilter = "EMPLEADO_ID=" & ID
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperaDetalleEventoAdmin(ByVal ID As Long) As DataView
        Try
            Dim daDetalleEventoAdmin As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_EVENTO_ADMIN_DET & " WHERE EVENTO_ADMINISTRATIVO_ID=" & ID, ArgoConfiguracion.ConnectionString)
            daDetalleEventoAdmin.Fill(Me, Tablas.RH_PER_EVENTO_ADMIN_DET)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_PER_EVENTO_ADMIN_DET))
            dv.RowFilter = "EVENTO_ADMINISTRATIVO_ID=" & ID
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperaDetallePermisoPaternal(ByVal ID As Long) As DataView
        Try
            Dim daDetallePermisoPaternal As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_EVENTO_ADMIN_DET & " WHERE EVENTO_ADMINISTRATIVO_ID=" & ID, ArgoConfiguracion.ConnectionString)
            daDetallePermisoPaternal.Fill(Me, Tablas.RH_PER_EVENTO_ADMIN_DET)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_PER_EVENTO_ADMIN_DET))
            dv.RowFilter = "EVENTO_ADMINISTRATIVO_ID=" & ID
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperaDetalleItemes(ByVal iditem As Integer, ByVal idperiodo As Integer, ByVal tipoProceso As String) As DataView
        Dim ds As DataSet
        ds = Me
        Dim cmdProceso, cmdSQL As String
        cmdProceso = " AND TIPO_PROCESO=" + "'" + tipoProceso + "'"
        cmdSQL = "SELECT * FROM " & Tablas.RH_REM_MOVIMIENTO_MENSUAL & " WHERE ITEM_ID=" & iditem & " AND PERIODO_ID=" & idperiodo & cmdProceso

        Dim daDetalleItems As New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
        daDetalleItems.Fill(ds, Tablas.RH_REM_MOVIMIENTO_MENSUAL)

        Dim dv As New DataView
        Dim dvm As New DataViewManager(ds)
        dv = dvm.CreateDataView(ds.Tables(Tablas.RH_REM_MOVIMIENTO_MENSUAL))
        dv.RowFilter = "ITEM_ID=" & iditem & " AND " & "PERIODO_ID=" & idperiodo & cmdProceso
        Return (dv)
        ds = Nothing
    End Function

    Public Function recuperarEmpleadoLiquidacion() As DataView
        Dim cmdSQL As String = "SELECT DISTINCT EMPLEADO_ID, NOMBRE_EMPLEADO FROM VW_LIQUIDACIONES_ENC ORDER BY NOMBRE_EMPLEADO"
        Using da As New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
            Dim ds As DataSet = New DataSet(cmdSQL)
            da.Fill(ds, "VW_LIQUIDACIONES_ENC")
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables("VW_LIQUIDACIONES_ENC"))
            Return (dv)
        End Using
    End Function

    Public Function recuperarRegionesAsignacionZona(PeriodoId As Integer) As DataView
        Dim cmdSQL As String = "SELECT RH_REM_ZONA.ZONA_ID, RH_REM_ZONA.ALIAS_ZONA, RH_REM_ZONA.DESCRIPCION_ZONA, RH_REM_ZONA_PERIODO.PORCENTAJE_ZONA, " & _
                               "RH_REM_ZONA_PERIODO.PERIODO_ID FROM RH_REM_ZONA INNER JOIN " & _
                               "RH_REM_ZONA_PERIODO ON RH_REM_ZONA.ZONA_ID = RH_REM_ZONA_PERIODO.ZONA_ID " & _
                               "WHERE RH_REM_ZONA_PERIODO.PERIODO_ID = " & PeriodoId.ToString

        Using da As New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
            Dim ds As DataSet = New DataSet(cmdSQL)
            da.Fill(ds, "RH_REM_ZONA")
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables("RH_REM_ZONA"))
            Return (dv)
        End Using
    End Function

    Public Function recuperaEmpleadoLiquidacionPorPeriodo(EmpleadoId As Integer) As DataView
        Dim cmdSQL As String = "SELECT ID_LIQUIDACION_ENC, RTRIM(DESCRIPCION_PERIODO)+ '-' + TIPO_CALCULO AS DESCRIPCION_LIQUIDACION " & _
                                "FROM VW_LIQUIDACIONES_ENC WHERE EMPLEADO_ID = " & EmpleadoId.ToString & " ORDER BY NOMBRE_EMPLEADO, ANO DESC, MES DESC"
        Using da As New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
            Dim ds As DataSet = New DataSet(cmdSQL)
            da.Fill(ds, "VW_LIQUIDACIONES_ENC")
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables("VW_LIQUIDACIONES_ENC"))
            Return (dv)
        End Using
    End Function

    Public Function recuperaEmpleadoFichaHistorica(PeriodoId As Integer) As DataView
        'Dim cmdSQL As String = "SELECT * " & _
        '                       "FROM VW_MAESTRO_EMPLEADO_FICHA_HISTORICA WHERE PERIODO_ID = " & PeriodoId.ToString & " ORDER BY NOMBRE_COMPLETO"
        'Using da As New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
        '    Dim ds As DataSet = New DataSet(cmdSQL)
        '    da.Fill(ds, "VW_MAESTRO_EMPLEADO_FICHA_HISTORICA")
        '    Dim dv As DataView
        '    Dim dvm As New DataViewManager(ds)
        '    dv = dvm.CreateDataView(ds.Tables("VW_MAESTRO_EMPLEADO_FICHA_HISTORICA"))
        '    Return (dv)
        'End Using

        Dim cmdSQL As String = "SELECT * " & _
                               "FROM VW_MAESTRO_EMPLEADO_FICHA_HISTORICA WHERE PERIODO_ID = " & PeriodoId.ToString & " ORDER BY NOMBRE_COMPLETO"
        Dim ds As DataSet = New DataSet(cmdSQL)
        Dim dv As DataView
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(cmdSQL, conn))
        da.SelectCommand.CommandTimeout = 200
        da.Fill(ds, "VW_MAESTRO_EMPLEADO_FICHA")
        Dim dvmFichaEmpleado As New DataViewManager(ds)
        dv = dvmFichaEmpleado.CreateDataView(ds.Tables("VW_MAESTRO_EMPLEADO_FICHA"))
        Return (dv)
    End Function

    Public Function recuperaMaestroEmpleado() As DataView
        Dim cmdSQL As String = "SELECT ID_LIQUIDACION_ENC, RTRIM(DESCRIPCION_PERIODO)+ '-' + TIPO_CALCULO AS DESCRIPCION_LIQUIDACION " & _
                               "FROM VW_LIQUIDACIONES_ENC ORDER BY NOMBRE_EMPLEADO, ANO DESC, MES DESC"
        Using da As New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
            Dim ds As DataSet = New DataSet(cmdSQL)
            da.Fill(ds, "VW_LIQUIDACIONES_ENC")
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables("VW_LIQUIDACIONES_ENC"))
            Return (dv)
        End Using
    End Function

    Public Function recuperaDetalleItemesRelacionados(ByVal iditem As Integer) As DataView
        Dim ds As DataSet
        ds = Me
        Dim cmdSQL As String
        'cmdSQL = "SELECT RH_REM_ITEM_RELACIONADO_CABECERA.RELACION_CABECERA_ID, RH_REM_ITEM_RELACIONADO_CABECERA.ITEM_ID, " + _
        '        "RH_REM_ITEM_RELACIONADO_CABECERA.ITEM_ID, RH_REM_ITEM_RELACIONADO_CABECERA.USUARIO, RH_REM_ITEM_RELACIONADO_CABECERA.FECHA_ACTUALIZACION, " + _
        '        "RH_REM_TIPO_ITEM.DESCRIPCION, RH_REM_ITEM.ITEM_ALIAS, RH_REM_ITEM.DESCRIPCION_LARGA " + _
        '        "FROM RH_REM_TIPO_ITEM INNER JOIN RH_REM_ITEM ON RH_REM_TIPO_ITEM.TIPO_ITEM = RH_REM_ITEM.TIPO_ITEM INNER JOIN " + _
        '        "RH_REM_ITEM_RELACIONADO_CABECERA ON RH_REM_ITEM.ITEM_ID = RH_REM_ITEM_RELACIONADO_CABECERA.ITEM_ID " + _
        '        "WHERE RH_REM_ITEM.ITEM_ID = " + iditem.ToString + " ORDER BY RH_REM_ITEM.DESCRIPCION_LARGA"

        cmdSQL = "SELECT RH_REM_ITEM_RELACIONADO_DETALLE.RELACION_DETALLE_ID," + _
                 "RH_REM_ITEM_RELACIONADO_CABECERA.RELACION_CABECERA_ID, " + _
                 "RH_REM_ITEM_RELACIONADO_DETALLE.ITEM_ID, " + _
                 "RH_REM_ITEM_RELACIONADO_CABECERA.ITEM_ID ITEM_ID_CABECERA, " + _
                 "RH_REM_ITEM.ITEM_ALIAS, " + _
                 "RH_REM_ITEM.DESCRIPCION_LARGA, " + _
                 "(SELECT DESCRIPCION FROM RH_REM_TIPO_ITEM WHERE TIPO_ITEM=RH_REM_ITEM.TIPO_ITEM) TIPO_ITEM " + _
                 "FROM RH_REM_ITEM_RELACIONADO_DETALLE " + _
                 "  INNER JOIN RH_REM_ITEM_RELACIONADO_CABECERA ON RH_REM_ITEM_RELACIONADO_DETALLE.RELACION_CABECERA_ID=RH_REM_ITEM_RELACIONADO_CABECERA.RELACION_CABECERA_ID" + _
                 "  INNER JOIN RH_REM_ITEM ON RH_REM_ITEM_RELACIONADO_DETALLE.ITEM_ID=RH_REM_ITEM.ITEM_ID " + _
                 "WHERE(RH_REM_ITEM_RELACIONADO_CABECERA.ITEM_ID = " + iditem.ToString + ")" + _
                 "ORDER BY (SELECT DESCRIPCION FROM RH_REM_TIPO_ITEM WHERE TIPO_ITEM=RH_REM_ITEM.TIPO_ITEM) DESC, RH_REM_ITEM.DESCRIPCION_LARGA"

        Dim daDetalleItems As New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
        daDetalleItems.Fill(ds, "RH_REM_ITEM_RELACIONADO_CABECERA")

        Dim dv As New DataView
        Dim dvm As New DataViewManager(ds)
        dv = dvm.CreateDataView(ds.Tables("RH_REM_ITEM_RELACIONADO_CABECERA"))
        Return (dv)
        ds = Nothing
    End Function


    Public Function recuperaDetalleItemesEmpladoPeriodo(ByVal idEmpleado As Integer, ByVal idperiodo As Integer, ByVal tipoProceso As String) As DataView
        Try
            Dim cmdProceso As String
            cmdProceso = " AND TIPO_PROCESO=" + "'" + tipoProceso + "'"
            Dim daDetalleItems As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_REM_MOVIMIENTO_MENSUAL & " WHERE EMPLEADO_ID=" & idEmpleado & " AND PERIODO_ID=" & idperiodo & cmdProceso, ArgoConfiguracion.ConnectionString)
            daDetalleItems.Fill(Me, Tablas.RH_REM_MOVIMIENTO_MENSUAL)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_REM_MOVIMIENTO_MENSUAL))
            dv.RowFilter = "EMPLEADO_ID=" & idEmpleado & " AND " & "PERIODO_ID=" & idperiodo & cmdProceso
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperaDetalleItemesEmpladoPeriodo(ByVal idEmpleado As Integer, ByVal idperiodo As Integer, ByVal tipoProceso As String, ByVal itemsID As Array) As DataView
        Try
            Dim cmdProceso As String
            cmdProceso = " AND TIPO_PROCESO=" + "'" + tipoProceso + "'"
            Dim daDetalleItems As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_REM_MOVIMIENTO_MENSUAL & " WHERE EMPLEADO_ID=" & idEmpleado & " AND PERIODO_ID=" & idperiodo & cmdProceso, ArgoConfiguracion.ConnectionString)
            daDetalleItems.Fill(Me, Tablas.RH_REM_MOVIMIENTO_MENSUAL)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_REM_MOVIMIENTO_MENSUAL))
            dv.RowFilter = "EMPLEADO_ID=" & idEmpleado & " AND " & "PERIODO_ID=" & idperiodo & cmdProceso & " AND  ITEM_ID IN (" & ArrayToString(itemsID, ",") & ")"
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperaDetalleRemuneracionLiquida(ByVal idperiodo As Integer, ByVal tipoProceso As Integer) As DataView

        Dim cmdProceso, cmdSQL As String
        If tipoProceso = 0 Then
            cmdProceso = " AND TIPO_CALCULO='N' AND CALIDAD_JURIDICA_ID IN (2,3)"
        Else
            If tipoProceso = 1 Then
                cmdProceso = " AND TIPO_CALCULO='H' AND CALIDAD_JURIDICA_ID IN (5)"
            Else
                cmdProceso = " AND TIPO_CALCULO='S' AND CALIDAD_JURIDICA_ID IN (2,3)" '--> " AND (TIPO_CALCULO='H' OR TIPO_CALCULO='N') AND CALIDAD_JURIDICA_ID IN (2,3,5)"
            End If
        End If
        If tipoProceso = 0 Or tipoProceso = 1 Then
            cmdSQL = "SELECT CONVERT(VARCHAR(9),RUT)+DV AS RUT, REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(RTRIM(APELLIDO_PATERNO)+' '+RTRIM(APELLIDO_MATERNO)+' '+RTRIM(NOMBRES),'Ñ','N'),'Á','A'),'É','E'),'Í','I'),'Ó','O'),'Ú','U'),',',''),'.','') AS NOMBRE," & _
                    "'' AS EMAIL, CODIGO_ASOCIADO AS CODIGO_BANCO, CODIGO_CONVENIO AS FORMA_PAGO, REPLACE(REPLACE(NRO_CUENTA_BANCO,'-',''),'.','') AS CUENTA, LIQUIDO AS MONTO, " & _
                    " NOMBRE_CALIDAD_JURIDICA, NOMBRE_TIPO_CUENTA_BANCO, NOMBRE_BANCO " & _
                    " FROM VW_LIQUIDO_A_PAGO " & _
                    " WHERE PERIODO_ID = " & CType(idperiodo, String) & _
                    " AND FORMA_PAGO=2" & cmdProceso & _
                    " ORDER BY APELLIDO_PATERNO, APELLIDO_MATERNO, NOMBRES"
        Else
            cmdSQL = "SELECT CONVERT(VARCHAR(9),RUT)+DV AS RUT, REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(RTRIM(APELLIDO_PATERNO)+' '+RTRIM(APELLIDO_MATERNO)+' '+RTRIM(NOMBRES),'Ñ','N'),'Á','A'),'É','E'),'Í','I'),'Ó','O'),'Ú','U'),',',''),'.','') AS NOMBRE," & _
                     "'' AS EMAIL, CODIGO_ASOCIADO AS CODIGO_BANCO, CODIGO_CONVENIO AS FORMA_PAGO, REPLACE(REPLACE(NRO_CUENTA_BANCO,'-',''),'.','') AS CUENTA, LIQUIDO AS MONTO, " & _
                     " NOMBRE_CALIDAD_JURIDICA, NOMBRE_TIPO_CUENTA_BANCO, NOMBRE_BANCO " & _
                     " FROM VW_LIQUIDO_A_PAGO_SUPLEMENTARIA AS VW_LIQUIDO_A_PAGO" & _
                     " WHERE PERIODO_ID = " & CType(idperiodo, String) & _
                     " AND FORMA_PAGO=2" & cmdProceso & _
                     " ORDER BY APELLIDO_PATERNO, APELLIDO_MATERNO, NOMBRES"
        End If
        Dim da As New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
        Dim ds As DataSet
        ds = New DataSet(cmdSQL)
        da.Fill(ds, "VW_LIQUIDO_A_PAGO")
        Dim dv As DataView
        Dim dvm As New DataViewManager(ds)
        dv = dvm.CreateDataView(ds.Tables("VW_LIQUIDO_A_PAGO"))
        Return (dv)
    End Function
    Public Function recuperaDetalleArchivoPlanoRemuneracionLiquida(ByVal idperiodo As Integer, ByVal tipoProceso As Integer) As DataView

        Dim cmdProceso, cmdSQL As String
        If tipoProceso = 0 Then
            cmdProceso = " AND TIPO_CALCULO='N' AND CALIDAD_JURIDICA_ID IN (2,3)"
        Else
            If tipoProceso = 1 Then
                cmdProceso = " AND TIPO_CALCULO='H' AND CALIDAD_JURIDICA_ID IN (5)"
            Else
                cmdProceso = " AND TIPO_CALCULO='S' AND CALIDAD_JURIDICA_ID IN (2,3)" ' --> " AND (TIPO_CALCULO='H' OR TIPO_CALCULO='N') AND CALIDAD_JURIDICA_ID IN (2,3,5)"
            End If
        End If
        If tipoProceso = 0 Or tipoProceso = 1 Then
            cmdSQL = "SELECT RIGHT ('  ' + CONVERT (VARCHAR,RUT), 9)+DV + CHAR(9) + CONVERT(CHAR(50),REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(RTRIM(APELLIDO_PATERNO)+' '+RTRIM(APELLIDO_MATERNO)+' '+RTRIM(NOMBRES),'Ñ','N'),'Á','A'),'É','E'),'Í','I'),'Ó','O'),'Ú','U'),',',''),'.',''))+CHAR(9)+" & _
                     "'' + CHAR(9) + CODIGO_ASOCIADO + CHAR(9) +  CODIGO_CONVENIO + CHAR(9) + CONVERT(CHAR(20),REPLACE(REPLACE(NRO_CUENTA_BANCO,'-',''),'.','')) + CHAR(9) + RIGHT ('       ' + CONVERT (VARCHAR(8),LIQUIDO), 8) AS COLUMNA" & _
                     " FROM VW_LIQUIDO_A_PAGO " & _
                     " WHERE PERIODO_ID = " & CType(idperiodo, String) & _
                     " AND FORMA_PAGO=2" & cmdProceso & _
                     " ORDER BY APELLIDO_PATERNO, APELLIDO_MATERNO, NOMBRES"
        Else
            cmdSQL = "SELECT RIGHT ('  ' + CONVERT (VARCHAR,RUT), 9)+DV + CHAR(9) + CONVERT(CHAR(50),REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(RTRIM(APELLIDO_PATERNO)+' '+RTRIM(APELLIDO_MATERNO)+' '+RTRIM(NOMBRES),'Ñ','N'),'Á','A'),'É','E'),'Í','I'),'Ó','O'),'Ú','U'),',',''),'.',''))+CHAR(9)+" & _
                    "'' + CHAR(9) + CODIGO_ASOCIADO + CHAR(9) +  CODIGO_CONVENIO + CHAR(9) + CONVERT(CHAR(20),REPLACE(REPLACE(NRO_CUENTA_BANCO,'-',''),'.','')) + CHAR(9) + RIGHT ('       ' + CONVERT (VARCHAR(8),LIQUIDO), 8) AS COLUMNA" & _
                    " FROM VW_LIQUIDO_A_PAGO_SUPLEMENTARIA AS VW_LIQUIDO_A_PAGO " & _
                    " WHERE PERIODO_ID = " & CType(idperiodo, String) & _
                    " AND FORMA_PAGO=2" & cmdProceso & _
                    " ORDER BY APELLIDO_PATERNO, APELLIDO_MATERNO, NOMBRES"
        End If


        Dim da As New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
        Dim ds As DataSet
        ds = New DataSet(cmdSQL)
        da.Fill(ds, "VW_LIQUIDO_A_PAGO")
        Dim dv As DataView
        Dim dvm As New DataViewManager(ds)
        dv = dvm.CreateDataView(ds.Tables("VW_LIQUIDO_A_PAGO"))
        Return (dv)
    End Function

    Public Function recuperaMarcasControlAceeso(ByVal idEmpleado As Integer, ByVal fechaInical As Date, ByVal fechaFinal As Date) As DataView
        Try
            Dim personID As String
            Dim cmdSql As String

            personID = "1" + Replace(CType(idEmpleado, String).PadLeft(5), " ", "0")
            cmdSql = "SELECT marc_generada_id, marc_fecha, marc_hora, marc_cardno, marc_estado, usuario, " & _
                     " fecha_modificacion, marc_procesa FROM icaro.assiscad_presidencia.dbo.marcas_vigentes " & _
                     " WHERE (marc_cardno = " & personID & ")" & _
                     " AND (marc_fecha >= CONVERT(DATETIME, '" & fechaInical & "', 103))" & _
                     " AND (marc_fecha <= CONVERT(DATETIME, '" & fechaFinal & "', 103))" & _
                     " ORDER BY marc_fecha, marc_hora"


            Dim da As New SqlDataAdapter(cmdSql, ArgoConfiguracion.ConnectionString)
            Dim ds As DataSet
            ds = New DataSet(cmdSql)
            da.Fill(ds, "icaro.assiscad_presidencia.dbo.marcas_generadas")
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables("icaro.assiscad_presidencia.dbo.marcas_generadas"))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperaDetalleReliquidacionEmpleado(ByVal idEmpleado As Integer, ByVal idperiodo As Integer, ByVal tipoProceso As String) As DataView
        Try
            Dim cmdProceso As String
            cmdProceso = " AND TIPO_PROCESO=" + "'" + tipoProceso + "'"
            Dim ds As DataSet
            Dim daDetalleItems As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_REM_RELIQUIDACION & " WHERE EMPLEADO_ID=" & idEmpleado & " AND PERIODO_ID=" & idperiodo & cmdProceso & " ORDER BY ANO DESC, MES, SECUENCIA_IMPRESION", ArgoConfiguracion.ConnectionString)
            ds = New DataSet("SELECT * FROM " & Tablas.RH_REM_RELIQUIDACION & " WHERE EMPLEADO_ID=" & idEmpleado & " AND PERIODO_ID=" & idperiodo & cmdProceso & " ORDER BY ANO DESC, MES, SECUENCIA_IMPRESION")
            daDetalleItems.Fill(ds, Tablas.RH_REM_RELIQUIDACION)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Tablas.RH_REM_RELIQUIDACION))
            dv.RowFilter = "EMPLEADO_ID=" & idEmpleado & " AND " & "PERIODO_ID=" & idperiodo & cmdProceso
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperaCargasFamiliaresActualizaFichaEmpleado() As DataView
        Try

            Dim cmdSQL As String
            cmdSQL = "SELECT *, ABS((CARGA_SIMPLE+CARGA_INVALIDEZ+CARGA_PRENATAL)-(CARGAS_FAM_NORMALES+CARGAS_FAM_INVALIDAS+CARGAS_FAM_PRENATAL)) AS DIFER_CARGAS " & _
                     " FROM " & Vistas.VW_CARGAS_FAMILIARES_TRASPAZO_A_FICHA_EMPLEADO & _
                     " WHERE ABS((CARGA_SIMPLE+CARGA_INVALIDEZ+CARGA_PRENATAL)-(CARGAS_FAM_NORMALES+CARGAS_FAM_INVALIDAS+CARGAS_FAM_PRENATAL)) > 0"
            Dim ds As DataSet
            Dim daDetalleCargasFam As New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
            ds = New DataSet(cmdSQL)
            daDetalleCargasFam.Fill(ds, Vistas.VW_CARGAS_FAMILIARES_TRASPAZO_A_FICHA_EMPLEADO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_CARGAS_FAMILIARES_TRASPAZO_A_FICHA_EMPLEADO))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperaDatosFichaIntranet() As DataView
        Try
            Dim da As New SqlDataAdapter("SELECT * FROM " & Vistas.VW_FICHA_EMPLEADO_SIGA_VS_INTRANET & " ORDER BY APELLIDO_PATERNO, APELLIDO_MATERNO, NOMBRES, FICHA", ArgoConfiguracion.ConnectionString)
            da.Fill(Me, Vistas.VW_FICHA_EMPLEADO_SIGA_VS_INTRANET)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Vistas.VW_FICHA_EMPLEADO_SIGA_VS_INTRANET))
            Return (dv)
        Catch ex As Exception
            Throw ex
            Return Nothing
        End Try
    End Function

    Public Function recuperarMaestroEmpleados(ByVal fechaFinalIngreso As Date, ByVal periodo_id As Integer) As DataView
        Dim fechaString As String
        'fechaString = "'" + CType(fechaFinalIngreso, Date) + "'"
        fechaString = "'" + fechaFinalIngreso.Day.ToString + "-" + IIf(fechaFinalIngreso.Month.ToString.Length = 1, "0" + fechaFinalIngreso.Month.ToString, fechaFinalIngreso.Month.ToString) + "-" + fechaFinalIngreso.Year.ToString + "'"
        Try
            Dim daEmpleados As New SqlDataAdapter("SELECT * FROM VW_MAESTRO_EMPLEADO_CALCULO_REMUN" & _
                                                  " WHERE ((ESTADO_EMPLEADO_ID = 1) OR (ESTADO_EMPLEADO_ID = 6) OR (PROCESO_BONO_MODERNIZACION = 1))" & _
                                                  " AND ((INCLUYE_CALCULO_SUELDO = 1) AND (FECHA_ING_INSTITUCION <= CONVERT(DATETIME," + fechaString + ",103)))" & _
                                                 " ORDER BY APELLIDO_PATERNO, APELLIDO_MATERNO, NOMBRES", ArgoConfiguracion.ConnectionString)

            daEmpleados.Fill(Me, "VW_MAESTRO_EMPLEADO_CALCULO_REMUN")
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables("VW_MAESTRO_EMPLEADO_CALCULO_REMUN"))
            'dv.RowFilter = "INCLUYE_CALCULO_SUELDO=1 AND FECHA_ING_INSTITUCION <= " & fechaString
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperarMaestroEmpleadosSuplementario(ByVal fechaFinalIngreso As Date) As DataView
        Dim fechaString As String
        fechaString = "'" + CType(fechaFinalIngreso, Date) + "'"
        Try
            Dim daEmpleados As New SqlDataAdapter("SELECT DISTINCT * FROM " & Vistas.VW_MAESTRO_EMPLEADO_SUPLEMENTARIA & _
                                                  " WHERE (ESTADO_EMPLEADO_ID =1 OR ESTADO_EMPLEADO_ID=6) " & _
                                                  " ORDER BY APELLIDO_PATERNO, APELLIDO_MATERNO, NOMBRES", ArgoConfiguracion.ConnectionString)
            daEmpleados.Fill(Me, Vistas.VW_MAESTRO_EMPLEADO_SUPLEMENTARIA)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Vistas.VW_MAESTRO_EMPLEADO_SUPLEMENTARIA))
            dv.RowFilter = "INCLUYE_CALCULO_SUELDO=1 AND FECHA_ING_INSTITUCION <= " & fechaString
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperarMaestroEmpleadosSuplementarioHonorario(ByVal fechaFinalIngreso As Date) As DataView
        Dim fechaString As String
        fechaString = "'" + CType(fechaFinalIngreso, Date) + "'"
        Try
            Dim daEmpleados As New SqlDataAdapter("SELECT DISTINCT * FROM " & Vistas.VW_MAESTRO_EMPLEADO_SUPLEMENTARIA & _
                                                  " WHERE (ESTADO_EMPLEADO_ID =1 OR ESTADO_EMPLEADO_ID=6) " & _
                                                  " ORDER BY APELLIDO_PATERNO, APELLIDO_MATERNO, NOMBRES", ArgoConfiguracion.ConnectionString)
            daEmpleados.Fill(Me, Vistas.VW_MAESTRO_EMPLEADO_SUPLEMENTARIA)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Vistas.VW_MAESTRO_EMPLEADO_SUPLEMENTARIA))
            dv.RowFilter = "INCLUYE_CALCULO_SUELDO=2 AND FECHA_ING_INSTITUCION <= " & fechaString
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperarEndeudamientoEmpleado(ByVal EmpleadoId As Integer, ByVal PeriodoAnalisis As String, ByVal FiltroPorcentaje As Integer) As DataView
        Try
            Dim ds As DataSet
            Dim cmdWhere As String = ""
            Dim cmdPeriodo As String = " AND (PERIODO_ID IN " & "(" & PeriodoAnalisis & "))"
            If EmpleadoId > 0 Then  'Indica que es seleccionado un empleado
                cmdWhere = " WHERE PORCENTAJE_ENDEUDAMIENTO_ACTUAL >= " & FiltroPorcentaje.ToString & " AND EMPLEADO_ID = " & EmpleadoId.ToString & cmdPeriodo
            Else                    'Indica que son seleccionados todos los empleados
                cmdWhere = " WHERE PORCENTAJE_ENDEUDAMIENTO_ACTUAL >= " & FiltroPorcentaje.ToString & " AND (PERIODO_ID IN " & "(" & PeriodoAnalisis & "))"
            End If
            Dim cmdSelect As String = "SELECT * FROM VW_EMPLEADOS_ENDEUDAMIENTO " & cmdWhere & " ORDER BY NOMBRE_EMPLEADO, TIPO_ITEM_ENDEUDAMIENTO_ID, ITEM_ALIAS"
            Dim daLiquidInactivas As New SqlDataAdapter(cmdSelect, ArgoConfiguracion.ConnectionString)
            ds = New DataSet(cmdSelect)
            daLiquidInactivas.Fill(ds, "VW_EMPLEADOS_ENDEUDAMIENTO")
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables("VW_EMPLEADOS_ENDEUDAMIENTO"))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperarMaestroEmpleadosHonorarios(ByVal fechaFinalIngreso As Date) As DataView
        Dim fechaString As String
        fechaString = "'" + CType(fechaFinalIngreso, Date) + "'"

        Try
            Dim daEmpleados As New SqlDataAdapter("SELECT * FROM " & Vistas.VW_MAESTRO_EMPLEADO & _
                                                  " WHERE (ESTADO_EMPLEADO_ID =1 OR ESTADO_EMPLEADO_ID=6) " & _
                                                  " ORDER BY APELLIDO_PATERNO, APELLIDO_MATERNO, NOMBRES", ArgoConfiguracion.ConnectionString)
            daEmpleados.Fill(Me, Vistas.VW_MAESTRO_EMPLEADO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Vistas.VW_MAESTRO_EMPLEADO))
            dv.RowFilter = "INCLUYE_CALCULO_SUELDO=2 AND FECHA_ING_INSTITUCION <= " & fechaString & " AND ENTREGO_BOLETA_HONORARIO = 1"
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function recuperarEmpleadosInactivosconProcesoLiquidacion(ByVal idPeriodo As Integer, ByVal tipoProceso As String) As DataView
        Try
            Dim ds As DataSet
            Dim cmdProceso As String = ""
            Dim cmdSQL As String = ""
            cmdProceso = " AND TIPO_CALCULO" + "'" + tipoProceso + "'"

            Dim daLiquidInactivas As New SqlDataAdapter("SELECT * FROM " & Vistas.VW_VALIDA_EMPLEADOS_INACTIVOS & " WHERE PERIODO_ID=" & idPeriodo & cmdSQL & " ORDER BY NOMBRE_COMPLETO_EMPLEADO", ArgoConfiguracion.ConnectionString)
            ds = New DataSet(SQL.VISTAS.SELECT_EMPLEADOS_INACTIVOS_CON_LIQUIADCION)
            daLiquidInactivas.Fill(ds, Vistas.VW_VALIDA_EMPLEADOS_INACTIVOS)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_VALIDA_EMPLEADOS_INACTIVOS))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function recuperaCargasFamiliaresConEstado() As DataView
        Try
            Dim daEmpleados As New SqlDataAdapter("SELECT * FROM " & Vistas.VW_CARGAS_FAMILIARES_POR_VENCER, ArgoConfiguracion.ConnectionString)
            daEmpleados.Fill(Me, Vistas.VW_CARGAS_FAMILIARES_POR_VENCER)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Vistas.VW_CARGAS_FAMILIARES_POR_VENCER))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperaDetalleVidaLaboral(ByVal idEmpleado As Integer) As DataView
        Try
            Dim daVidaLaboral As New SqlDataAdapter("SELECT * FROM " & Vistas.VW_HOJA_VIDA_LABORAL & " WHERE EMPLEADO_ID=" & idEmpleado & " ORDER BY ANTECEDENTE_LABORAL_ID DESC", ArgoConfiguracion.ConnectionString)
            daVidaLaboral.Fill(Me, Vistas.VW_HOJA_VIDA_LABORAL)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Vistas.VW_HOJA_VIDA_LABORAL))
            dv.RowFilter = "EMPLEADO_ID=" & idEmpleado
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperaDatosLaborales(ByVal ID_Empleado As Long) As DataRow
        Dim valorID As Integer
        valorID = Busca("SELECT ANTECEDENTE_LABORAL_ID FROM " & Tablas.RH_PER_ANTECEDENTE_LABORAL & " WHERE EMPLEADO_ID = " & ID_Empleado & " AND ESTADO_REGISTRO=1")
        If valorID > 0 Then
            Try
                'da.Fill(Me, Tablas.RH_PER_ANTECEDENTE_LABORAL)
                Dim daLaboral As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_ANTECEDENTE_LABORAL & " WHERE EMPLEADO_ID = " & ID_Empleado & " AND ESTADO_REGISTRO = 1", ArgoConfiguracion.ConnectionString)
                daLaboral.Fill(Me, Tablas.RH_PER_ANTECEDENTE_LABORAL)
                Dim empleadoLaboralDR As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_LABORALRow
                empleadoLaboralDR = CType(RH_PER_ANTECEDENTE_LABORAL.Rows.Find(valorID), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_LABORALRow)

                Return empleadoLaboralDR
            Catch ex As Exception
                Return Nothing
            End Try
        Else
            Return Nothing
        End If
    End Function
    Public Function recuperaDatoLaboralHistorico(ByVal ID_Empleado As Long, ByVal idPeriodoHistorico As Integer) As DataRow
        Dim valorID As Integer
        valorID = Busca("SELECT ANTECEDENTE_LABORAL_ID FROM " & Tablas.RH_PER_ANTECEDENTE_LABORAL & " WHERE EMPLEADO_ID = " & ID_Empleado & " AND ESTADO_REGISTRO=5" & " AND PERIODO_ID=" & idPeriodoHistorico)

        Try
            'da.Fill(Me, Tablas.RH_PER_ANTECEDENTE_LABORAL)
            Dim daLaboral As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_ANTECEDENTE_LABORAL & " WHERE EMPLEADO_ID = " & ID_Empleado & " AND ESTADO_REGISTRO=5" & " AND PERIODO_ID=" & idPeriodoHistorico, ArgoConfiguracion.ConnectionString)
            daLaboral.Fill(Me, Tablas.RH_PER_ANTECEDENTE_LABORAL)
            Dim empleadoLaboralDR As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_LABORALRow
            empleadoLaboralDR = CType(RH_PER_ANTECEDENTE_LABORAL.Rows.Find(valorID), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_LABORALRow)

            Return empleadoLaboralDR
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function recuperaDatosAcademicos(ByVal ID As Long) As DataView
        Try
            Dim da As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_ANTECEDENTE_ACADEM & " WHERE EMPLEADO_ID=" & ID, ArgoConfiguracion.ConnectionString)
            da.Fill(Me, Tablas.RH_PER_ANTECEDENTE_ACADEM)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_PER_ANTECEDENTE_ACADEM))
            dv.RowFilter = "EMPLEADO_ID=" & ID
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function recuperaDetallePresupuestoAnualHonorarios(ByVal ID As Long) As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet

            sql = "SELECT * FROM " & Tablas.RH_PER_ANTECEDENTE_HONORARIO_DETALLE & " WHERE EMPLEADO_ID=" & CType(ID, String) & " ORDER BY FECHA_MODIFICACION DESC"


            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.Fill(ds, Tablas.RH_PER_ANTECEDENTE_HONORARIO_DETALLE)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Tablas.RH_PER_ANTECEDENTE_HONORARIO_DETALLE))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function recuperaHistoricoCambiosDetallePresupuestoAnualHonorario(ByVal ID As Long) As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet

            sql = "SELECT * FROM " & Tablas.RH_PER_ANTECEDENTE_HONORARIO & " WHERE EMPLEADO_ID=" & CType(ID, String)


            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.Fill(ds, Tablas.RH_PER_ANTECEDENTE_HONORARIO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Tablas.RH_PER_ANTECEDENTE_HONORARIO))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function recuperaAntecedentesAPV(ByVal ID As Long) As DataView
        Try
            Dim ds As DataSet
            Dim daApv As New SqlDataAdapter(SQL.VISTAS.SELECT_ANTECEDENTES_APV_VISTA(ID), ArgoConfiguracion.ConnectionString)
            ds = New DataSet(SQL.VISTAS.SELECT_ANTECEDENTES_APV_VISTA(ID))
            daApv.Fill(ds, "VW_ANTECEDENTE_APV")
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_ANTECEDENTE_APV))
            dv.RowFilter = "EMPLEADO_ID=" & ID
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperaAntecedentesAPVHistorico(ByVal idEmpleado As Long, ByVal idPeriodoHistorico As Integer) As DataView
        Try
            Dim ds As DataSet
            Dim daApv As New SqlDataAdapter("SELECT * FROM VW_ANTECEDENTE_APV WHERE EMPLEADO_ID = " & idEmpleado & " AND ESTADO_REGISTRO=5 AND PERIODO_ID=" & idPeriodoHistorico, ArgoConfiguracion.ConnectionString)
            ds = New DataSet("SELECT * FROM VW_ANTECEDENTE_APV WHERE EMPLEADO_ID = " & idEmpleado & " AND ESTADO_REGISTRO=5 AND PERIODO_ID=" & idPeriodoHistorico)
            daApv.Fill(ds, "VW_ANTECEDENTE_APV")
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_ANTECEDENTE_APV))
            dv.RowFilter = "EMPLEADO_ID=" & idEmpleado
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperaLicenciaMedica(ByVal idEmpleado As Long) As DataView
        Try
            Dim ds As DataSet
            Dim daLicMed As New SqlDataAdapter("SELECT * FROM VW_LICENCIAS_MEDICAS_DETALLE WHERE EMPLEADO_ID=" & idEmpleado & " ORDER BY FECHA_INICIO DESC", ArgoConfiguracion.ConnectionString)
            ds = New DataSet("SELECT * FROM VW_LICENCIAS_MEDICAS_DETALLE WHERE EMPLEADO_ID=" & idEmpleado & " ORDER BY FECHA_INICIO DESC")
            daLicMed.Fill(ds, Vistas.VW_LICENCIAS_MEDICAS_DETALLE)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_LICENCIAS_MEDICAS_DETALLE))
            dv.RowFilter = "EMPLEADO_ID=" & idEmpleado
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperarHonorariosNoEnviadosTesoreria(ByVal idPeriodo As Integer, ByVal tipoProceso As Integer) As DataView
        Try
            Dim cmdProceso As String = ""
            If tipoProceso = 0 Then
                cmdProceso = " AND TIPO_CALCULO='N' AND CALIDAD_JURIDICA_ID IN (2,3) "
            ElseIf tipoProceso = 1 Then
                cmdProceso = " AND TIPO_CALCULO='H' AND CALIDAD_JURIDICA_ID IN (5) "
            End If
            Dim ds As DataSet
            Dim da As New SqlDataAdapter("SELECT * FROM " & Vistas.VW_LIQUIDO_A_PAGO & " WHERE PERIODO_ID=" & idPeriodo & cmdProceso & " ORDER BY NOMBRE_COMPLETO", ArgoConfiguracion.ConnectionString)
            ds = New DataSet(SQL.VISTAS.SELECT_LIQUIDO_A_PAGO)
            da.Fill(ds, Vistas.VW_LIQUIDO_A_PAGO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_LIQUIDO_A_PAGO))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function recuperarHonorariosEnviadosTesoreria(ByVal idPeriodo As Integer, ByVal tipoProceso As Integer) As DataView
        Try
            Dim cmdProceso As String = ""
            If tipoProceso = 0 Then
                cmdProceso = " AND TIPO_CALCULO='N' AND CALIDAD_JURIDICA_ID IN (2,3) "
            ElseIf tipoProceso = 1 Then
                cmdProceso = " AND TIPO_CALCULO='H' AND CALIDAD_JURIDICA_ID IN (5) "
            End If
            Dim ds As DataSet
            Dim da As New SqlDataAdapter("SELECT * FROM RH_REM_TESORERIA_LIQ_PAGO WHERE PERIODO_ID=" & idPeriodo & cmdProceso & " ORDER BY NOMBRE_COMPLETO", ArgoConfiguracion.ConnectionString)
            ds = New DataSet("SELECT * FROM RH_REM_TESORERIA_LIQ_PAGO WHERE PERIODO_ID=" & idPeriodo & cmdProceso & " ORDER BY NOMBRE_COMPLETO")
            da.Fill(ds, Tablas.RH_REM_TESORERIA_LIQ_PAGO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Tablas.RH_REM_TESORERIA_LIQ_PAGO))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function recuperarRendicionViaticos(ByVal año As Integer, ByVal estadoCheque As Integer) As DataView
        Try
            Dim cmdSQL As String = "SELECT VIATICO_ID, NRO_MEMORANDUM_INTERNO, FECHA_MEMORANDUM, ANO, MES, DEPTO_ID, " & _
                                         "DEPARTAMENTO, STR_ESTADO_VIATICO, ESTADO_VIATICO, DESCRIPCION, SELECCIONAR, EGRESO_ID, " & _
                                         "NUMERO_DOCUMENTO, FECHA_DOCUMENTO " & _
                                         "FROM VW_VIATICO_NUMERO_MEMORANDUM " & _
                                         "WHERE ANO = " & año.ToString & _
                                         "AND ESTADO_VIATICO = " & estadoCheque.ToString & _
                                         " ORDER BY CONVERT(VARCHAR(20), NRO_MEMORANDUM_INTERNO)"
            Dim ds As DataSet
            Dim da As New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
            ds = New DataSet(cmdSQL)
            da.Fill(ds, "VW_VIATICO_NUMERO_MEMORANDUM")
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables("VW_VIATICO_NUMERO_MEMORANDUM"))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function recuperarHonorariosPagoCheque(ByVal idPeriodo As Integer, ByVal tipoProceso As Integer, ByVal incluirSoloCheques As Boolean) As DataView
        Try
            Dim cmdProceso As String = ""
            If tipoProceso = 0 Then
                cmdProceso = " AND TIPO_CALCULO='N' AND CALIDAD_JURIDICA_ID IN (2,3) "
            ElseIf tipoProceso = 1 Then
                cmdProceso = " AND TIPO_CALCULO='H' AND CALIDAD_JURIDICA_ID IN (5) "
            End If
            If incluirSoloCheques = True Then
                cmdProceso = cmdProceso + " AND (FORMA_PAGO = 0)"
            End If
            Dim cmdSQL As String = "SELECT * FROM RH_REM_TESORERIA_LIQ_PAGO WHERE PERIODO_ID=" & idPeriodo & cmdProceso & " ORDER BY NOMBRE_COMPLETO"
            Dim ds As DataSet
            Dim da As New SqlDataAdapter(cmdSQL, ArgoConfiguracion.ConnectionString)
            ds = New DataSet(cmdSQL)
            da.Fill(ds, Tablas.RH_REM_TESORERIA_LIQ_PAGO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Tablas.RH_REM_TESORERIA_LIQ_PAGO))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Public Function recuperaLicenciaMedicaInformeGestion(ByVal idEmpleado As Long) As DataView
        Try
            Dim ds As DataSet
            Dim daLicMed As New SqlDataAdapter("SELECT * FROM VW_LICENCIAS_MEDICAS WHERE EMPLEADO_ID=" & idEmpleado & " ORDER BY PERIODO, FECHA_INICIO", ArgoConfiguracion.ConnectionString)
            ds = New DataSet("SELECT * FROM VW_LICENCIAS_MEDICAS WHERE EMPLEADO_ID=" & idEmpleado & " ORDER BY PERIODO, FECHA_INICIO")
            daLicMed.Fill(ds, Vistas.VW_LICENCIAS_MEDICAS)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_LICENCIAS_MEDICAS))
            dv.RowFilter = "EMPLEADO_ID=" & idEmpleado
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperaLicenciaMedicaInformeGestionPeriodo(ByVal Ano As Integer) As DataView
        Try
            Dim ds As DataSet
            Dim daLicMed As New SqlDataAdapter("SELECT * FROM VW_LICENCIAS_MEDICAS WHERE ANO=" & Ano & " ORDER BY PERIODO, FECHA_INICIO", ArgoConfiguracion.ConnectionString)
            ds = New DataSet("SELECT * FROM VW_LICENCIAS_MEDICAS WHERE ANO=" & Ano & " ORDER BY PERIODO, FECHA_INICIO")
            daLicMed.Fill(ds, Vistas.VW_LICENCIAS_MEDICAS)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_LICENCIAS_MEDICAS))
            dv.RowFilter = "ANO=" & Ano
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperaDatosEstructuraOrganicaEmpleado(ByVal ID As Long) As DataView
        Try
            Dim ds As DataSet
            Dim daEstruOrg As New SqlDataAdapter("SELECT * FROM VW_ESTRUCTURA_ORGANICA_EMPLEADO WHERE ESTADO_REGISTRO=1 AND EMPLEADO_ID=" & ID & " ORDER BY PERIODO_ID DESC, ESTADO_REGISTRO", ArgoConfiguracion.ConnectionString)
            ds = New DataSet("SELECT * FROM VW_ESTRUCTURA_ORGANICA_EMPLEADO WHERE ESTADO_REGISTRO=1 AND EMPLEADO_ID=" & ID & " ORDER BY PERIODO_ID DESC, ESTADO_REGISTRO")
            daEstruOrg.Fill(ds, Vistas.VW_ESTRUCTURA_ORGANICA_EMPLEADO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_ESTRUCTURA_ORGANICA_EMPLEADO))
            dv.RowFilter = "EMPLEADO_ID=" & ID
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperaDatosEstructuraContableEmpleado(ByVal ID As Long) As DataView
        Try
            Dim ds As DataSet
            Dim daEstruConta As New SqlDataAdapter("SELECT * FROM VW_ESTRUCTURA_CONTABLE_EMPLEADO WHERE ESTADO_REGISTRO=1 AND EMPLEADO_ID=" & ID & " ORDER BY PERIODO_ID DESC, ESTADO_REGISTRO", ArgoConfiguracion.ConnectionString)
            ds = New DataSet("SELECT * FROM VW_ESTRUCTURA_CONTABLE_EMPLEADO WHERE EMPLEADO_ID=" & ID & " ORDER BY PERIODO_ID DESC, ESTADO_REGISTRO")
            daEstruConta.Fill(ds, Vistas.VW_ESTRUCTURA_CONTABLE_EMPLEADO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_ESTRUCTURA_CONTABLE_EMPLEADO))
            dv.RowFilter = "EMPLEADO_ID=" & ID
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperaHistoriaEventosAdminEmpleado(ByVal IDEmpleado As Long, ByVal Anno As String) As DataView
        Try
            Dim ds As DataSet
            Dim daEventoAdm As New SqlDataAdapter("SELECT * FROM VW_EVENTOS_ADMINISTRATIVOS_DETALLE WHERE EMPLEADO_ID=" & IDEmpleado & " AND ANO=" & Anno & " ORDER BY EMPLEADO_ID, FECHA_INICIO", ArgoConfiguracion.ConnectionString)
            ds = New DataSet("SELECT * FROM VW_EVENTOS_ADMINISTRATIVOS_DETALLE WHERE EMPLEADO_ID=" & IDEmpleado & " AND ANO=" & Anno & " ORDER BY EMPLEADO_ID, FECHA_INICIO")
            daEventoAdm.Fill(ds, Vistas.VW_EVENTOS_ADMINISTRATIVOS_DETALLE)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_EVENTOS_ADMINISTRATIVOS_DETALLE))
            dv.RowFilter = "EMPLEADO_ID=" & IDEmpleado & " AND " & "ANO=" & Anno
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperaAntecedentesPrevisionales(ByVal id As Long) As DataView
        Try
            Dim sql As String
            sql = "SELECT * FROM VW_ANTECEDENTE_PREVISIONAL" & _
                  " WHERE EMPLEADO_ID = " & id & _
                 " ORDER BY ESTADO_REGISTRO, ANTECEDENTE_PREVIS_ID"

            Dim ds As DataSet
            Dim daPrevision As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            ds = New DataSet(sql)
            daPrevision.Fill(ds, Vistas.VW_ANTECEDENTE_PREVISIONAL)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_ANTECEDENTE_PREVISIONAL))
            dv.RowFilter = "EMPLEADO_ID=" & id
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperaAntecedentePrevisional(ByVal IDEmpleado As Long) As DataRow
        Dim valorID As Integer
        valorID = Busca("SELECT ANTECEDENTE_PREVIS_ID FROM " & Tablas.RH_PER_ANTECEDENTE_PREVIS & " WHERE EMPLEADO_ID = " & IDEmpleado & " AND ESTADO_REGISTRO=1")

        Try
            If valorID = 0 Then
                da.Fill(Me, Tablas.RH_PER_ANTECEDENTE_PREVIS)
            End If
            Dim daPrev As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_ANTECEDENTE_PREVIS & " WHERE ANTECEDENTE_PREVIS_ID=" & valorID, ArgoConfiguracion.ConnectionString)
            daPrev.Fill(Me, Tablas.RH_PER_ANTECEDENTE_PREVIS)
            Dim empleadoPrevDR As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_PREVISRow
            empleadoPrevDR = CType(RH_PER_ANTECEDENTE_PREVIS.Rows.Find(valorID), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_PREVISRow)
            Return empleadoPrevDR
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperaAntecedentePresupuestoAnualHonorario(ByVal IDEmpleado As Long) As DataRow
        Dim valorID As Integer
        valorID = Busca("SELECT TOP 1 ANTECEDENTE_HONORARIO_DETALLE_ID FROM " & Tablas.RH_PER_ANTECEDENTE_HONORARIO_DETALLE & " WHERE EMPLEADO_ID = " & IDEmpleado & " AND ESTADO_REGISTRO=1 ORDER BY FECHA_MODIFICACION DESC")

        Try
            Dim daHonorario As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_ANTECEDENTE_HONORARIO_DETALLE & " WHERE ANTECEDENTE_HONORARIO_DETALLE_ID=" & valorID, ArgoConfiguracion.ConnectionString)
            daHonorario.Fill(Me, Tablas.RH_PER_ANTECEDENTE_HONORARIO_DETALLE)
            Dim empleadoHonorDR As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_HONORARIO_DETALLERow
            empleadoHonorDR = CType(RH_PER_ANTECEDENTE_HONORARIO_DETALLE.Rows.Find(valorID), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_HONORARIO_DETALLERow)
            Return empleadoHonorDR
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperaAntecedentePrevisionalHistorico(ByVal IDEmpleado As Long, ByVal idPeriodoHistorico As Integer) As DataRow
        Dim valorID As Integer
        valorID = Busca("SELECT ANTECEDENTE_PREVIS_ID FROM " & Tablas.RH_PER_ANTECEDENTE_PREVIS & " WHERE EMPLEADO_ID = " & IDEmpleado & " AND ESTADO_REGISTRO=5" & " AND PERIODO_ID=" & idPeriodoHistorico)

        Try
            If valorID = 0 Then
                da.Fill(Me, Tablas.RH_PER_ANTECEDENTE_PREVIS)
            End If
            Dim daPrev As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_ANTECEDENTE_PREVIS & " WHERE ANTECEDENTE_PREVIS_ID=" & valorID, ArgoConfiguracion.ConnectionString)
            daPrev.Fill(Me, Tablas.RH_PER_ANTECEDENTE_PREVIS)
            Dim empleadoPrevDR As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_PREVISRow
            empleadoPrevDR = CType(RH_PER_ANTECEDENTE_PREVIS.Rows.Find(valorID), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_PREVISRow)
            Return empleadoPrevDR
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperaEstructuraOrganica(ByVal IDEmpleado As Long) As DataRow
        Dim valorID As Integer
        valorID = Busca("SELECT ESTRUCTURA_ORGANICA_ID FROM " & Tablas.RH_PER_ESTRUCTURA_ORGANICA & " WHERE EMPLEADO_ID = " & IDEmpleado & " AND ESTADO_REGISTRO=1")
        Try
            Dim daEstrucOrganica As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_ESTRUCTURA_ORGANICA, ArgoConfiguracion.ConnectionString)
            daEstrucOrganica.Fill(Me, Tablas.RH_PER_ESTRUCTURA_ORGANICA)
            Dim empleadoEstrucOrganicaR As DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_ORGANICARow
            empleadoEstrucOrganicaR = CType(RH_PER_ESTRUCTURA_ORGANICA.Rows.Find(valorID), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_ORGANICARow)
            Return empleadoEstrucOrganicaR
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperaEstructuraOrganicaHistorico(ByVal IDEmpleado As Long, ByVal idPeriodoHistorico As Integer) As DataRow
        Dim valorID As Integer
        valorID = Busca("SELECT ESTRUCTURA_ORGANICA_ID FROM " & Tablas.RH_PER_ESTRUCTURA_ORGANICA & " WHERE EMPLEADO_ID = " & IDEmpleado & " AND ESTADO_REGISTRO=5" & " AND PERIODO_ID=" & idPeriodoHistorico)
        Try
            If valorID = 0 Then
                da.Fill(Me, Tablas.RH_PER_ESTRUCTURA_ORGANICA)
            End If
            Dim daEstrucOrganica As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_ESTRUCTURA_ORGANICA & " WHERE ESTRUCTURA_ORGANICA_ID=" & valorID.ToString, ArgoConfiguracion.ConnectionString)
            daEstrucOrganica.Fill(Me, Tablas.RH_PER_ESTRUCTURA_ORGANICA)
            Dim empleadoEstrucOrganicaR As DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_ORGANICARow
            empleadoEstrucOrganicaR = CType(RH_PER_ESTRUCTURA_ORGANICA.Rows.Find(valorID), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_ORGANICARow)
            Return empleadoEstrucOrganicaR
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperaEstructuraContable(ByVal IDEmpleado As Long) As DataRow
        Dim valorID As Integer
        valorID = Busca("SELECT ESTRUCTURA_CONTABLE_ID FROM " & Tablas.RH_PER_ESTRUCTURA_CONTABLE & " WHERE EMPLEADO_ID = " & IDEmpleado & " AND ESTADO_REGISTRO=1")
        Try
            'Dim daEstrucContable As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_ESTRUCTURA_CONTABLE & " WHERE EMPLEADO_ID = " & IDEmpleado & " AND ESTADO_REGISTRO = 1", ArgoConfiguracion.ConnectionString)
            Dim daEstrucContable As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_ESTRUCTURA_CONTABLE, ArgoConfiguracion.ConnectionString)
            daEstrucContable.Fill(Me, Tablas.RH_PER_ESTRUCTURA_CONTABLE)
            Dim empleadoEstrucContableDR As DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_CONTABLERow
            empleadoEstrucContableDR = CType(RH_PER_ESTRUCTURA_CONTABLE.Rows.Find(valorID), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_CONTABLERow)
            Return empleadoEstrucContableDR
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function
    Public Function recuperaEstructuraContableHistorico(ByVal IDEmpleado As Long, ByVal idPeriodoHistorico As Integer) As DataRow
        Dim valorID As Integer
        valorID = Busca("SELECT ESTRUCTURA_CONTABLE_ID FROM " & Tablas.RH_PER_ESTRUCTURA_CONTABLE & " WHERE EMPLEADO_ID = " & IDEmpleado & " AND ESTADO_REGISTRO=5" & " AND PERIODO_ID=" & idPeriodoHistorico)
        Try
            If valorID = 0 Then
                da.Fill(Me, Tablas.RH_PER_ESTRUCTURA_CONTABLE)
            End If
            Dim daEstrucContable As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_ESTRUCTURA_CONTABLE & " WHERE ESTRUCTURA_CONTABLE_ID=" & valorID.ToString, ArgoConfiguracion.ConnectionString)
            daEstrucContable.Fill(Me, Tablas.RH_PER_ESTRUCTURA_CONTABLE)
            Dim empleadoEstrucContableDR As DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_CONTABLERow
            empleadoEstrucContableDR = CType(RH_PER_ESTRUCTURA_CONTABLE.Rows.Find(valorID), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_CONTABLERow)
            Return empleadoEstrucContableDR
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function
    Public Function recuperaEstructuraOrganicaOriginal(ByVal IDEmpleado As Long) As DataRow
        Dim valorID As Integer
        valorID = Busca("SELECT ESTRUCTURA_ORGANICA_ID FROM " & Tablas.RH_PER_ESTRUCTURA_ORGANICA & " WHERE EMPLEADO_ID = " & IDEmpleado & " AND ESTADO_REGISTRO=1")

        Try
            Dim daEstrucOrg As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_ESTRUCTURA_ORGANICA & " WHERE ESTRUCTURA_ORGANICA_ID=" & valorID, ArgoConfiguracion.ConnectionString)
            daEstrucOrg.Fill(Me, Tablas.RH_PER_ESTRUCTURA_ORGANICA)
            Dim empleadoEstruOrgDR As DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_ORGANICARow
            If valorID > 0 Then
                empleadoEstruOrgDR = CType(RH_PER_ESTRUCTURA_ORGANICA.Rows.Find(valorID), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_ORGANICARow)
            Else
                empleadoEstruOrgDR = Nothing
            End If

            Return empleadoEstruOrgDR
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function
    Public Function recuperaEstructuraContableOriginal(ByVal IDEmpleado As Long) As DataRow
        Dim valorID As Integer
        valorID = Busca("SELECT ESTRUCTURA_CONTABLE_ID FROM " & Tablas.RH_PER_ESTRUCTURA_CONTABLE & " WHERE EMPLEADO_ID = " & IDEmpleado & " AND ESTADO_REGISTRO=1")

        Try
            Dim daEstrucConta As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_ESTRUCTURA_CONTABLE & " WHERE ESTRUCTURA_CONTABLE_ID=" & valorID, ArgoConfiguracion.ConnectionString)
            daEstrucConta.Fill(Me, Tablas.RH_PER_ESTRUCTURA_CONTABLE)
            Dim empleadoEstruContaDR As DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_CONTABLERow
            If valorID > 0 Then
                empleadoEstruContaDR = CType(RH_PER_ESTRUCTURA_CONTABLE.Rows.Find(valorID), DataAccess.DSEmpleado.RH_PER_ESTRUCTURA_CONTABLERow)
            Else
                empleadoEstruContaDR = Nothing
            End If

            Return empleadoEstruContaDR
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperaMontosAsignacionesZona(ByVal ZonaId As Integer, ByVal PeriodoId As Integer, sueldoBase As Integer) As Decimal
        Dim porcentajeZona As Decimal
        Dim SQL As String

        SQL = "SELECT PORCENTAJE_ZONA FROM RH_REM_ZONA_PERIODO " & _
              " WHERE ZONA_ID = " & ZonaId.ToString & _
              " AND PERIODO_ID = " & PeriodoId.ToString

        Try
            porcentajeZona = BuscaDecimal(SQL)
            Dim montoAsignacionZona As Decimal = Math.Round(sueldoBase * (porcentajeZona / 100), 0)

            Return montoAsignacionZona
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperarEmpleadosHorasExtrasAtraso(ByVal fechaInicial As Date, ByVal fechaFinal As Date) As DataTable
        Dim fechaIniString As String
        Dim fechaFinString As String
        fechaIniString = "'" + CType(fechaInicial, Date) + "'"
        fechaFinString = "'" + CType(fechaFinal, Date) + "'"
        Try
            Dim daEmpleados As New SqlDataAdapter("SELECT DISTINCT EMPLEADO_ID, NOMBRE_EMPLEADO " & _
                                    "FROM VW_CONTROL_ASISTENCIA " & _
                                    "WHERE FECHA_ASISTENCIA>=CONVERT(DATETIME, " & fechaIniString & " ,103)" & _
                                    "AND FECHA_ASISTENCIA<=CONVERT(DATETIME, " & fechaFinString & " ,103)" & _
                                    "ORDER BY NOMBRE_EMPLEADO", ArgoConfiguracion.ConnectionString)

            daEmpleados.Fill(Me, "VW_CONTROL_ASISTENCIA")
            Return (Me.Tables("VW_CONTROL_ASISTENCIA"))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function
    Public Function recuperaMontosAsignacionesEmpleado(ByVal idCalidadJuridica As Integer, ByVal idGrado As Integer, ByVal idClasificacionEmpleado As Integer) As DataTable
        Try
            Dim ds As New DataSet
            Dim mySelectQuery As String

            mySelectQuery = "SELECT * FROM " & Vistas.VW_EUS & _
                  " WHERE ORGANIZACION_ID = " & ArgoConfiguracion.OrganizacionID & _
                  " AND CALIDAD_JURIDICA_ID = " & idCalidadJuridica & _
                  " AND GRADO_ID=" & idGrado & _
                  " AND CLASIFICACION_EMPLEADO_ID=" & idClasificacionEmpleado & _
                  " AND ESTADO_REGISTRO = 1"

            Dim da As New SqlDataAdapter(mySelectQuery, ArgoConfiguracion.ConnectionString)
            da.Fill(ds, "VW_EUS")
            Return (ds.Tables("VW_EUS"))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperaNumeroLicencia(ByVal numeroLicenciaMedica As String) As DataRow
        Dim valor_ID As Integer
        Dim SQL As String

        SQL = "SELECT * FROM " & Tablas.RH_PER_LICENCIA_MEDICA & " WHERE NUMERO_LICENCIA = " & numeroLicenciaMedica

        Try
            valor_ID = Busca(SQL)
            Dim daLicMed As New SqlDataAdapter(SQL, ArgoConfiguracion.ConnectionString)
            daLicMed.Fill(Me, Tablas.RH_PER_LICENCIA_MEDICA)
            Dim licmedDR As DataAccess.DSEmpleado.RH_PER_LICENCIA_MEDICARow = Nothing
            If valor_ID > 0 Then
                licmedDR = CType(RH_PER_LICENCIA_MEDICA.Rows.Find(valor_ID), DataAccess.DSEmpleado.RH_PER_LICENCIA_MEDICARow)
            End If
            Return licmedDR
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperaAntecedenteRemun(ByVal ID_Empleado As Long) As DataRow
        Dim valorID As Integer
        valorID = Busca("SELECT ANTECEDENTE_REMUN_ID FROM " & Tablas.RH_PER_ANTECEDENTE_REMUN & " WHERE EMPLEADO_ID = " & ID_Empleado & " AND ESTADO_REGISTRO=1")

        Try
            'da.Fill(Me, Tablas.RH_PER_ANTECEDENTE_REMUN)
            Dim daRemun As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_ANTECEDENTE_REMUN & " WHERE EMPLEADO_ID = " & ID_Empleado & " AND ESTADO_REGISTRO = 1", ArgoConfiguracion.ConnectionString)
            daRemun.Fill(Me, Tablas.RH_PER_ANTECEDENTE_REMUN)
            Dim empleadoRemunDR As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_REMUNRow
            empleadoRemunDR = CType(RH_PER_ANTECEDENTE_REMUN.Rows.Find(valorID), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_REMUNRow)

            Return empleadoRemunDR
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function
    Public Function recuperaAntecedenteRemunHistorico(ByVal ID_Empleado As Long, ByVal idPeriodoHistorico As Integer) As DataRow
        Dim valorID As Integer
        valorID = Busca("SELECT ANTECEDENTE_REMUN_ID FROM " & Tablas.RH_PER_ANTECEDENTE_REMUN & " WHERE EMPLEADO_ID = " & ID_Empleado & " AND ESTADO_REGISTRO=5 AND PERIODO_ID=" & idPeriodoHistorico)

        Try
            Dim daRemun As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_ANTECEDENTE_REMUN & " WHERE EMPLEADO_ID = " & ID_Empleado & " AND ESTADO_REGISTRO=5 AND PERIODO_ID=" & idPeriodoHistorico, ArgoConfiguracion.ConnectionString)
            daRemun.Fill(Me, Tablas.RH_PER_ANTECEDENTE_REMUN)
            Dim empleadoRemunDR As DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_REMUNRow
            empleadoRemunDR = CType(RH_PER_ANTECEDENTE_REMUN.Rows.Find(valorID), DataAccess.DSEmpleado.RH_PER_ANTECEDENTE_REMUNRow)

            Return empleadoRemunDR
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function
    Public Function recuperaSaldoDiasEventoAdmin(ByVal idEmpleado As Long, ByVal tipoEvento As Integer, ByVal anoProceso As Integer) As DataView
        Try
            Dim sql As String
            sql = "SELECT * FROM " & Tablas.RH_PER_EVENTO_ADMIN_SALDO & _
                  " WHERE TIPO_EVENTO_ADMIN_ID = " & tipoEvento & _
                  " AND ANO = " & anoProceso & _
                  " AND EMPLEADO_ID=" & idEmpleado

            Dim ds As DataSet
            Dim daSaldoEventoAdmin As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            ds = New DataSet(sql)
            daSaldoEventoAdmin.Fill(ds, Tablas.RH_PER_EVENTO_ADMIN_SALDO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Tablas.RH_PER_EVENTO_ADMIN_SALDO))
            dv.RowFilter = "EMPLEADO_ID=" & idEmpleado & " AND ANO=" & anoProceso & " AND TIPO_EVENTO_ADMIN_ID = " & tipoEvento
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function
    Public Function recuperaSaldoDiasEmpleadoEventoAdmin(ByVal idEmpleado As Long, ByVal tipoEvento As Integer, ByVal anno As Integer) As DataView
        Try
            Dim da As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_EVENTO_ADMIN_SALDO & _
                                        " WHERE EMPLEADO_ID=" & idEmpleado & _
                                        " AND ANO = " & anno & _
                                        " AND TIPO_EVENTO_ADMIN_ID = " & tipoEvento, ArgoConfiguracion.ConnectionString)
            da.Fill(Me, Tablas.RH_PER_EVENTO_ADMIN_SALDO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_PER_EVENTO_ADMIN_SALDO))
            dv.RowFilter = "EMPLEADO_ID=" & idEmpleado & " AND ANO=" & anno & " AND TIPO_EVENTO_ADMIN_ID = " & tipoEvento
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try

    End Function
    Public Function recuperaSaldoPermisoPaternal(ByVal ID As Long) As DataView
        Try
            Dim daPermisoPaternal As New SqlDataAdapter("SELECT * FROM " & Vistas.VW_PERMISO_PATERNAL_SALDO_DIAS & " WHERE EMPLEADO_ID=" & ID, ArgoConfiguracion.ConnectionString)
            daPermisoPaternal.Fill(Me, Vistas.VW_PERMISO_PATERNAL_SALDO_DIAS)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Vistas.VW_PERMISO_PATERNAL_SALDO_DIAS))
            dv.RowFilter = "EMPLEADO_ID=" & ID
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function
    Public Function recuperaTipoSistemaPrevisional(ByVal sql As String) As String
        Dim tipoSistemaPrev As String = ""
        tipoSistemaPrev = BuscaString(sql)
        Return tipoSistemaPrev
    End Function
    Public Function recuperaLiquidacionEmpleadoItem(ByVal idEmpleado As Integer, ByVal idItem As Integer, ByVal idPeriodo As Integer, ByVal tipoProceso As String) As Integer
        Dim cmdSQL As String = ""
        Dim cmdString As String = ""
        cmdString = " AND TIPO_CALCULO=" + "'" + tipoProceso + "'"
        cmdSQL = " SELECT MONTO FROM RH_REM_LIQUIDACION " & _
                 " WHERE EMPLEADO_ID=" & idEmpleado & _
                 " AND PERIODO_ID=" & idPeriodo & _
                 " AND ITEM_ID=" & idItem & cmdString
        Return Busca(cmdSQL)
    End Function
    Public Function obtieneInstitucionPrevisionalActual(ByVal idEmpleado As Integer) As Integer
        Dim cmdSQL As String = ""
        Dim cmdString As String = ""
        cmdSQL = " SELECT AFP_ID FROM RH_PER_ANTECEDENTE_PREVIS " & _
                 " WHERE EMPLEADO_ID=" & idEmpleado & _
                 " AND ESTADO_REGISTRO=1"
        Return Busca(cmdSQL)
    End Function
    Public Function recuperaItemes() As Array
        Dim dtItems As DataTable
        Dim rowItem As Data.DataRow
        Dim cmdQuery As String = "SELECT ITEM_ID FROM " & Tablas.RH_REM_ITEM & _
                                      " WHERE ES_ITEM_BIENESTAR = 1"

        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cmdQuery, conn.ConnectionString)
            Dim i, indice As Integer
            da.Fill(ds, Tablas.RH_REM_ITEM)
            dtItems = ds.Tables(Tablas.RH_REM_ITEM)
            indice = dtItems.Rows.Count
            Dim itemID() As Integer = {0}

            For Each rowItem In dtItems.Rows
                If i = 0 Then
                    ReDim itemID(indice - 1)
                End If
                itemID.SetValue(rowItem("ITEM_ID"), i)
                i += 1
            Next
            Return itemID
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try

    End Function
    Public Function obtieneInstitucionSaludActual(ByVal idEmpleado As Integer) As Integer
        Dim cmdSQL As String = ""
        Dim cmdString As String = ""
        cmdSQL = " SELECT ISAPRE_ID FROM RH_PER_ANTECEDENTE_PREVIS " & _
                 " WHERE EMPLEADO_ID=" & idEmpleado & _
                 " AND ESTADO_REGISTRO=1"
        Return Busca(cmdSQL)
    End Function

    Public Function recuperarEventosAdministrativos(ByVal idEmpleado As Integer, ByVal tipoEvento As Integer, ByVal anoProceso As Integer) As DataView
        Try
            Dim sql As String = ""
            sql = "SELECT RH_PER_EVENTO_ADMIN_DET.* " & _
                  " FROM RH_PER_EVENTO_ADMIN INNER JOIN RH_PER_EVENTO_ADMIN_DET ON " & _
                  " RH_PER_EVENTO_ADMIN.EVENTO_ADMINISTRATIVO_ID = RH_PER_EVENTO_ADMIN_DET.EVENTO_ADMINISTRATIVO_ID " & _
                  " WHERE RH_PER_EVENTO_ADMIN.EMPLEADO_ID = " & idEmpleado & _
                  " AND RH_PER_EVENTO_ADMIN.ANO = " & anoProceso & _
                  " AND RH_PER_EVENTO_ADMIN.TIPO_EVENTO_ADMIN_ID = " & tipoEvento & _
                  " ORDER BY RH_PER_EVENTO_ADMIN_DET.FECHA_INICIO"

            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(Me, Tablas.RH_PER_EVENTO_ADMIN_DET)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_PER_EVENTO_ADMIN_DET))
            'dv.RowFilter = "EMPLEADO_ID=" & idEmpleado & " AND ANO=" & anoProceso & " AND TIPO_EVENTO_ADMIN_ID = " & tipoEvento
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperarEventosAdministrativosSaldoDias(ByVal anoProceso As Integer) As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet
            sql = "SELECT * FROM " & Vistas.VW_EVENTOS_ADMINISTRATIVOS_SALDO_DIAS & " WHERE ANO = " & anoProceso
            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(ds, Vistas.VW_EVENTOS_ADMINISTRATIVOS_SALDO_DIAS)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_EVENTOS_ADMINISTRATIVOS_SALDO_DIAS))
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function
    Public Function recuperarAnalisisDinamicoLiquidaciones(ByVal anoProceso As Integer, MesInicio As Integer, MesFinal As Integer) As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet

            'Consulta original
            sql = "SELECT RUT, NOMBRE_EMPLEADO, ANO, MES, CALIDAD_JURIDICA, GRADO, ESTAMENTO, DIRECCION, DEPARTAMENTO, SUB_DEPTO, " & _
                  "ITEM_ALIAS, MONTO, TIPO_CALCULO, NUMERO_HORAS_EXTRAS, TIPO_ITEM, FUNCIONES_DESEMPENADAS, EMPLEADO_ID, DV, APELLIDO_PATERNO, APELLIDO_MATERNO, NOMBRES, FORMA_PAGO, BANCO, NRO_CUENTA_BANCO, NUMERO_BIENIOS FROM " & Vistas.VW_ANALISIS_LIQUIDACIONES & _
                  " WHERE ANO = " & anoProceso & " AND (MES >= " & MesInicio.ToString & " AND MES <= " & MesFinal.ToString & ") ORDER BY NOMBRE_EMPLEADO, ANO, MES, ITEM_ALIAS, DIRECCION, DEPARTAMENTO, SUB_DEPTO"

            'Modificada para 2010
            'sql = "SELECT RUT, NOMBRE_EMPLEADO, ANO, MES, CALIDAD_JURIDICA, GRADO, ESTAMENTO, DEPARTAMENTO, " & _
            '      "ITEM_ALIAS, MONTO, TIPO_CALCULO, NUMERO_HORAS_EXTRAS, TIPO_ITEM, FUNCIONES_DESEMPENADAS, EMPLEADO_ID FROM " & Vistas.VW_ANALISIS_LIQUIDACIONES & _
            '      " WHERE ANO = " & anoProceso & " ORDER BY NOMBRE_EMPLEADO, ANO, MES, ITEM_ALIAS, DEPARTAMENTO"

            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.SelectCommand.CommandTimeout = 100000 'Evita error tiempo espera.
            da.Fill(ds, Vistas.VW_ANALISIS_LIQUIDACIONES)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_ANALISIS_LIQUIDACIONES))
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperarAnalisisDinamicoEventosAdministrativos(ByVal anoProceso As Integer, MesInicio As Integer, MesFinal As Integer, SoloActivos As Boolean) As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet
            sql = "SELECT * FROM " & Vistas.VW_EVENTOS_ADMIN_CONSOLIDADO & " WHERE ANO = " & anoProceso & " AND (MES >= " & MesInicio.ToString & " AND MES <= " & MesFinal.ToString & ")"
            If SoloActivos Then
                sql += " AND (ESTADO_EMPLEADO = 'ACTIVO')"
            End If
            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(ds, Vistas.VW_EVENTOS_ADMIN_CONSOLIDADO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_EVENTOS_ADMIN_CONSOLIDADO))
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperarAnalisisDinamicoViaticos(ByVal anoProceso As Integer) As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet
            sql = "SELECT * FROM " & Vistas.VW_VIATICOS_DETALLE & " WHERE ANO = " & anoProceso
            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.SelectCommand.CommandTimeout = 100000 'Evita error tiempo espera.
            da.Fill(ds, Vistas.VW_VIATICOS_DETALLE)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_VIATICOS_DETALLE))
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperaAprobacionHora(ByVal numeroMemorandum As Integer, ByVal año As Integer, ByVal mes As Integer, ByVal deptoId As Integer) As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet

            sql = "SELECT HORAS_APROBADAS_ID, EMPLEADO_ID, AÑO, MES, NRO_MEMO_INTERMO, FECHA_MEMO_INTERNO, " & _
                  "HORAS_DIURNAS_APROB, HORAS_NOCTURNAS_APROB,HORAS_DIURNAS_PLANIF,HORAS_NOCTURNAS_PLANIF, DEPTO_ID, ESTADO_REGISTRO, TIPO_PROCESO " & _
                  "FROM RH_PER_HORAS_EXTRAS_APROBADAS " & _
                  "WHERE (AÑO = " & CType(año, String) & ") AND (NRO_MEMO_INTERMO = " & CType(numeroMemorandum, String) & ") " & _
                  "AND (MES = " & CType(mes, String) & ")" & _
                  "AND (DEPTO_ID = " & CType(deptoId, String) & ")"

            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.Fill(ds, Tablas.RH_PER_HORAS_EXTRAS_APROBADAS)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Tablas.RH_PER_HORAS_EXTRAS_APROBADAS))
            Return (dv)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperarTipoDocumento() As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet
            sql = "SELECT * FROM RH_GEN_TIPO_DOCUMENTO ORDER BY DESCRIPCION"
            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(ds, "RH_GEN_TIPO_DOCUMENTO")
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables("RH_GEN_TIPO_DOCUMENTO"))
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperarAntecedenteBinario(ByVal empleadoId As Integer) As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet
            sql = "SELECT BINARIO_ID, EMPLEADO_ID, ANTECEDENTE_CURRI_ID, NOMBRE_ARCHIVO, " & _
                  "TIPO_DOCUMENTO, TIPO_DOCUMENTO_ID, USUARIO, FECHA_ACTUALIZACION " & _
                  "FROM VW_ANTECEDENTE_BINARIO " & _
                  "WHERE EMPLEADO_ID = " + empleadoId.ToString + " ORDER BY NOMBRE_ARCHIVO"
            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(ds, "VW_ANTECEDENTE_BINARIO")
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables("VW_ANTECEDENTE_BINARIO"))
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperarLicenciaMedicaPorFiltro(ByVal tipoFiltro As Integer, ByVal fechaInicio As Date, ByVal fechaFinal As Date, ByVal EmpleadoId As Integer, ByVal DeptoId As Integer, ByVal InstitucionSaludId As Integer) As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet

            If tipoFiltro = 1 Then 'Por un empleado y rango fecha
                sql = "SELECT LICENCIA_MEDICA_ID FROM VW_LICENCIAS_MEDICAS_INFORME_CALCULO " & _
                       " WHERE EMPLEADO_ID = " & EmpleadoId.ToString & " AND (FECHA_INICIO >= CONVERT(DATETIME,'" & fechaInicio.ToShortDateString & "',103) AND FECHA_INICIO <= CONVERT(DATETIME,'" & fechaFinal.ToShortDateString & "',103)) ORDER BY NOMBRE_COMPLETO, FECHA_INICIO"
            ElseIf tipoFiltro = 2 Then 'Todos los empleados por rango fecha
                sql = "SELECT LICENCIA_MEDICA_ID FROM VW_LICENCIAS_MEDICAS_INFORME_CALCULO " & _
                       " WHERE (FECHA_INICIO >= CONVERT(DATETIME,'" & fechaInicio.ToShortDateString & "',103) AND FECHA_INICIO <= CONVERT(DATETIME,'" & fechaFinal.ToShortDateString & "',103)) ORDER BY NOMBRE_COMPLETO, FECHA_INICIO"
            ElseIf tipoFiltro = 3 Then 'Todos los empleados, un departamento y por rango fecha 
                sql = "SELECT LICENCIA_MEDICA_ID FROM VW_LICENCIAS_MEDICAS_INFORME_CALCULO " & _
                       " WHERE (DEPTO_ID = " & DeptoId.ToString & ") AND (FECHA_INICIO >= CONVERT(DATETIME,'" & fechaInicio.ToShortDateString & "',103) AND FECHA_INICIO <= CONVERT(DATETIME,'" & fechaFinal.ToShortDateString & "',103)) ORDER BY NOMBRE_COMPLETO, FECHA_INICIO"
            ElseIf tipoFiltro = 4 Then 'Todos los empleados, todos los departamentos y por rango fecha
                sql = "SELECT LICENCIA_MEDICA_ID FROM VW_LICENCIAS_MEDICAS_INFORME_CALCULO " & _
                       " WHERE (ISAPRE_ID = " & InstitucionSaludId.ToString & ") AND (FECHA_INICIO >= CONVERT(DATETIME,'" & fechaInicio.ToShortDateString & "',103) AND FECHA_INICIO <= CONVERT(DATETIME,'" & fechaFinal.ToShortDateString & "',103)) ORDER BY NOMBRE_COMPLETO, FECHA_INICIO"
            ElseIf tipoFiltro = 5 Then 'Una isapre, un depto y por rango fecha
                sql = "SELECT LICENCIA_MEDICA_ID FROM VW_LICENCIAS_MEDICAS_INFORME_CALCULO " & _
                       " WHERE (DEPTO_ID = " & DeptoId.ToString & ") AND (ISAPRE_ID = " & InstitucionSaludId.ToString & ") AND (FECHA_INICIO >= CONVERT(DATETIME,'" & fechaInicio.ToShortDateString & "',103) AND FECHA_INICIO <= CONVERT(DATETIME,'" & fechaFinal.ToShortDateString & "',103)) ORDER BY NOMBRE_COMPLETO, FECHA_INICIO"
            End If


            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.SelectCommand.CommandTimeout = 100000 'Evita error tiempo espera.
            da.Fill(ds, "VW_LICENCIAS_MEDICAS_INFORME_CALCULO ")
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables("VW_LICENCIAS_MEDICAS_INFORME_CALCULO "))
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperaAprobacionHoraPorDepto(ByVal DeptoId As Integer, ByVal Año As Integer) As DataView
        Try

            Dim sql As String
            Dim ds As New DataSet
            sql = "SELECT  * " & _
                             "FROM " & Vistas.VW_HORAS_APROBADAS_MEMO_POR_DEPTO & _
                             " WHERE (ANO = " & CType(Año, String) & ") AND (DEPTO_ID = " & CType(DeptoId, String) & ")"
            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.Fill(ds, Vistas.VW_HORAS_APROBADAS_MEMO_POR_DEPTO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_HORAS_APROBADAS_MEMO_POR_DEPTO))
            Return (dv)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperaAprobacionHoraPorEmpleado(ByVal EmpleadoId As Integer, ByVal Año As Integer, ByVal Mes As Integer) As String
        Try

            Dim sql As String
            Dim ds As New DataSet
            Dim mensaje As String
            sql = "SELECT  'Memo : ' + CONVERT(VARCHAR(10), NRO_MEMO_INTERMO) + ' Departamento: ' + NOMBRE_DEPTO AS MemoDepto " + _
                             "FROM VW_HORAS_APROBADAS_POR_EMPLEADO" + _
                             " WHERE (ANO = " + CType(Año, String) + ") AND (MES = " + CType(Mes, String) + ") AND (EMPLEADO_ID = " + CType(EmpleadoId, String) + ")"
            mensaje = Me.BuscaString(sql)

            If mensaje = Nothing Then
                mensaje = ""
            End If
            Return mensaje
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperarHorasExtrasAprobadasPorAñoMes(ByVal Año As Integer, ByVal Mes As Integer) As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet
            sql = "SELECT EMPLEADO_ID, RUT, DV, NOMBRE_EMPLEADO, GRADO_ALIAS, CALIDAD_JURICA AS CALIDAD_JURIDICA,HORAS_DIURNAS_APROB, " + _
                  "HORAS_NOCTURNAS_APROB, UPPER(DEPARTAMENTO) AS DEPARTAMENTO " + _
                  "FROM VW_HORAS_EXTRAS_APROBADAS_RESOLUCION " + _
                  "WHERE (AÑO = " + CType(Año, String) + ") AND (MES = " + CType(Mes, String) + ") ORDER BY DEPARTAMENTO, NOMBRE_EMPLEADO"
            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(ds, "VW_HORAS_EXTRAS_APROBADAS_RESOLUCION")
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables("VW_HORAS_EXTRAS_APROBADAS_RESOLUCION"))
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperarHorasExtrasPagadasPorPeriodo(ByVal PeriodoId As Integer) As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet
            sql = "SELECT EMPLEADO_ID, RUT, DV, RTRIM(APELLIDO_PATERNO)+' '+RTRIM(APELLIDO_PATERNO)+' '+RTRIM(NOMBRES) AS NOMBRE_EMPLEADO, " + _
                  "GRADO_ALIAS, DESCRIPCION AS CALIDAD_JURIDICA, HORAS_DIURNAS, " + _
                  "HORAS_NOCTURNAS, UPPER(DEPARTAMENTO) AS DEPARTAMENTO " + _
                  "FROM VW_HORAS_EXTRAS_RESOLUCION " + _
                  "WHERE (PERIODO_ID = " + CType(PeriodoId, String) + ") ORDER BY DEPARTAMENTO, NOMBRE_EMPLEADO"
            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(ds, "VW_HORAS_EXTRAS_RESOLUCION")
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables("VW_HORAS_EXTRAS_RESOLUCION"))
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperarHorasExtrasCompensadasPorPeriodo(ByVal PeriodoId As Integer) As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet
            sql = "SELECT EMPLEADO_ID, RUT, DV, RTRIM(APELLIDO_PATERNO)+' '+RTRIM(APELLIDO_PATERNO)+' '+RTRIM(NOMBRES) AS NOMBRE_EMPLEADO, " + _
                  "GRADO_ALIAS, DESCRIPCION AS CALIDAD_JURIDICA, HORAS_COMPENSADAS_DIURNA AS HORAS_DIURNAS, " + _
                  "HORAS_COMPENSADAS_NOCTURNA AS HORAS_NOCTURNAS, UPPER(DEPARTAMENTO) AS DEPARTAMENTO " + _
                  "FROM VW_HORAS_EXTRAS_COMPENSADAS " + _
                  "WHERE (PERIODO_ID = " + CType(PeriodoId, String) + ") ORDER BY DEPARTAMENTO, NOMBRE_EMPLEADO"
            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(ds, "VW_HORAS_EXTRAS_COMPENSADAS")
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables("VW_HORAS_EXTRAS_COMPENSADAS"))
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperarAnalisisMovimientoMensual(ByVal anoProceso As Integer) As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet
            sql = "SELECT * FROM " & Vistas.VW_MOVIMIENTO_MENSUAL & " WHERE ANO = " & anoProceso
            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(ds, Vistas.VW_MOVIMIENTO_MENSUAL)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_MOVIMIENTO_MENSUAL))
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperarAnalisisMaestroEmpleadoDetallado(ByVal anoProceso As Integer, MesInicio As Integer, MesFinal As Integer, SoloActivos As Boolean) As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet
            If SoloActivos Then
                sql = "SELECT * FROM " + Vistas.VW_MAESTRO_EMPLEADO_DETALLADO + " WHERE ANO=" + anoProceso.ToString + " AND (MES >= " + MesInicio.ToString + " AND MES <= " + MesFinal.ToString + ") AND (ESTADO_EMPLEADO = 'ACTIVO')"
            Else
                sql = "SELECT * FROM " + Vistas.VW_MAESTRO_EMPLEADO_DETALLADO + " WHERE ANO=" + anoProceso.ToString + " AND (MES >= " + MesInicio.ToString + " AND MES <= " + MesFinal.ToString + ")"
            End If

            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(ds, Vistas.VW_MAESTRO_EMPLEADO_DETALLADO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_MAESTRO_EMPLEADO_DETALLADO))
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperaDetalleHorasRatificadas(ByVal Año As Integer, ByVal Mes As Integer) As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet
            sql = "SELECT * FROM VW_HORAS_EXTRAS_PAGADAS_VS_RATIFICADAS WHERE AÑO_PROCESO = " + Año.ToString + " AND MES_PROCESO = " + Mes.ToString + " ORDER BY DEPARTAMENTO, NOMBRE_EMPLEADO"
            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(ds, Vistas.VW_HORAS_EXTRAS_PAGADAS_VS_RATIFICADAS)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_HORAS_EXTRAS_PAGADAS_VS_RATIFICADAS))
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperaDetalleHorasRatificadas(ByVal Año As Integer) As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet
            sql = "SELECT * FROM VW_HORAS_EXTRAS_PAGADAS_VS_RATIFICADAS WHERE AÑO_PROCESO = " + Año.ToString + " ORDER BY MES_PROCESO, DEPARTAMENTO, NOMBRE_EMPLEADO"
            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(ds, Vistas.VW_HORAS_EXTRAS_PAGADAS_VS_RATIFICADAS)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_HORAS_EXTRAS_PAGADAS_VS_RATIFICADAS))
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function
    Public Function recuperarAnalisisCargasFamiliares(ByVal anoProceso As Integer, MesInicio As Integer, MesFinal As Integer, SoloActivos As Boolean) As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet
            sql = "SELECT * FROM " & Vistas.VW_CARGAS_FAMILIARES_DETALLADO + " WHERE ANO=" + anoProceso.ToString + " AND (MES >= " + MesInicio.ToString + " AND MES <= " + MesFinal.ToString + ")"
            If SoloActivos Then
                sql += " AND (ESTADO_EMPLEADO = 'ACTIVO')"
            End If
            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(ds, Vistas.VW_CARGAS_FAMILIARES_DETALLADO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_CARGAS_FAMILIARES_DETALLADO))
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function
    Public Function recuperaMaestroEmpleadoDipres(ByVal anoProceso As Integer, MesInicio As Integer, MesFinal As Integer, SoloActivos As Boolean) As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet
            sql = "SELECT * FROM " + Vistas.VW_MAESTRO_EMPLEADO_DIPRES + " WHERE ANO=" + anoProceso.ToString + " AND (MES >= " + MesInicio.ToString + " AND MES <= " + MesFinal.ToString + ")"
            If SoloActivos Then
                sql += " AND (ESTADO_EMPLEADO = 'ACTIVO')"
            End If
            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(ds, Vistas.VW_MAESTRO_EMPLEADO_DIPRES)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_MAESTRO_EMPLEADO_DIPRES))
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function
    Public Function recuperarCentralizacionContable(ByVal anoProceso As Integer, MesInicio As Integer, MesFinal As Integer) As DataView
        Try
            Dim sql As String
            Dim ds As New DataSet
            sql = "SELECT * FROM " & Vistas.VW_CENTRALIZACION_CONTABLE & " WHERE ANO=" & anoProceso & " AND (MES >= " & MesInicio.ToString & " AND MES <= " & MesFinal.ToString + ")"
            Dim da As New SqlDataAdapter(sql, ArgoConfiguracion.ConnectionString)
            da.SelectCommand.CommandTimeout = 100000
            da.Fill(ds, Vistas.VW_CENTRALIZACION_CONTABLE)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_CENTRALIZACION_CONTABLE))
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperaEventoAdministrativo(ByVal ID As Long) As DataSet
        Try
            Dim ds As New DataSet
            Dim daEventoAdmin As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_EVENTO_ADMIN & " WHERE EMPLEADO_ID=" & ID, ArgoConfiguracion.ConnectionString)
            daEventoAdmin.Fill(ds, Tablas.RH_PER_EVENTO_ADMIN)
            daEventoAdmin.Fill(ds, Tablas.RH_PER_EVENTO_ADMIN_DET)
            Return (ds)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function

    Public Function recuperaDetalleEventoAdministrativo(ByVal ID As Long) As DataView
        Try
            Dim daEventoAdminDetalle As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_EVENTO_ADMIN_DET & " WHERE EVENTO_ADMINISTRATIVO_ID=" & ID, ArgoConfiguracion.ConnectionString)
            daEventoAdminDetalle.Fill(Me, Tablas.RH_PER_EVENTO_ADMIN_DET)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_PER_EVENTO_ADMIN_DET))
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function
    Public Function recuperarCargasFamiliares(ByVal idEmpleado As Long) As DataView
        Try
            Dim ds As DataSet
            Dim da As New SqlDataAdapter(SQL.VISTAS.SELECT_CARGAS_FAMILIARES_ACTIVAS(idEmpleado), ArgoConfiguracion.ConnectionString)
            ds = New DataSet(SQL.VISTAS.SELECT_CARGAS_FAMILIARES_ACTIVAS(idEmpleado))
            da.Fill(ds, Vistas.VW_CARGA_FAMILIAR)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_CARGA_FAMILIAR))
            dv.RowFilter = "EMPLEADO_ID=" & idEmpleado
            Return (dv)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SIGA")
            Return Nothing
        End Try
    End Function
    Public Function recuperarCargasFamiliaresSoloGrupoFamiliar(ByVal idEmpleado As Long) As DataView
        Try
            Dim ds As DataSet
            Dim da As New SqlDataAdapter(SQL.VISTAS.SELECT_CARGAS_FAMILIARES_SOLO_GRUPO_FAMILIAR_ACTIVAS(idEmpleado), ArgoConfiguracion.ConnectionString)
            ds = New DataSet(SQL.VISTAS.SELECT_CARGAS_FAMILIARES_SOLO_GRUPO_FAMILIAR_ACTIVAS(idEmpleado))
            da.Fill(ds, Vistas.VW_CARGA_FAMILIAR)
            Dim dv As DataView
            Dim dvm As New DataViewManager(ds)
            dv = dvm.CreateDataView(ds.Tables(Vistas.VW_CARGA_FAMILIAR))
            dv.RowFilter = "EMPLEADO_ID=" & idEmpleado
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperaDetalleCargaFamiliar(ByVal ID As Long) As DataView
        Try
            Dim daEventoAdminDetalle As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_EVENTO_ADMIN_DET & " WHERE EVENTO_ADMINISTRATIVO_ID=" & ID, ArgoConfiguracion.ConnectionString)
            daEventoAdminDetalle.Fill(Me, Tablas.RH_PER_EVENTO_ADMIN_DET)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_PER_EVENTO_ADMIN_DET))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperarViaticoMaestro(ByVal ID As Long, Optional ByVal numMemorandum As String = "") As DataRow

        Dim strSql As String

        Try

            strSql = "SELECT * FROM " & Tablas.RH_PER_VIATICO & " WHERE NOT VIATICO_ID IS NULL"

            If ID > 0 Then
                strSql = strSql & " AND VIATICO_ID = " & ID
            End If
            ' If numMemorandum <> "" Then
            ' strSql = strSql & " AND NRO_MEMORANDUM_INTERNO = '" & CType(numMemorandum, String) & "'"
            ' End If

            Dim da As New SqlDataAdapter(strSql, ArgoConfiguracion.ConnectionString)

            da.Fill(Me, Tablas.RH_PER_VIATICO)

            Dim viaticoDR As DataAccess.DSEmpleado.RH_PER_VIATICORow

            'viaticoDR = CType(RH_PER_VIATICO.Rows.Find(numMemorandum), DataAccess.DSEmpleado.RH_PER_VIATICORow)


            viaticoDR = CType(RH_PER_VIATICO.Rows.Find(ID), DataAccess.DSEmpleado.RH_PER_VIATICORow)

            Return viaticoDR
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperarViaticosAsignados(ByVal ID As Long) As DataView
        Try
            Dim DS As New DataSet
            Dim daViaticosAsignados As New SqlDataAdapter("SELECT * FROM " & Vistas.VW_RH_PER_VIATICOS & " WHERE VIATICO_ID=" & ID, ArgoConfiguracion.ConnectionString)
            daViaticosAsignados.Fill(DS, Vistas.VW_RH_PER_VIATICOS)
            Dim dv As New DataView
            dv = New DataView(DS.Tables(0), "", "", DataViewRowState.OriginalRows)
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperarViaticos(ByVal IDEmpleado As Long, ByVal año As Integer, Optional ByVal numMemorandum As String = "") As DataView
        Try
            Dim DS As New DataSet
            Dim strSql As String

            strSql = "SELECT * FROM " & Vistas.VW_RH_PER_VIATICOS & " WHERE NOT VIATICO_ID IS NULL "

            'Concatenando string de SQL de acuerdo a los parámetros recibidos.
            If IDEmpleado > 0 Then
                strSql = strSql & " AND EMPLEADO_ID = " & IDEmpleado & ""
            End If
            If año > 0 Then
                strSql = strSql & " AND ANO = " & año & ""
            End If

            If numMemorandum <> "" Then
                strSql = strSql & " AND NRO_MEMORANDUM_INTERNO = '" & numMemorandum & "'"
            End If


            Dim daViaticosAsignados As New SqlDataAdapter(strSql, ArgoConfiguracion.ConnectionString)

            daViaticosAsignados.Fill(DS, Vistas.VW_RH_PER_VIATICOS)
            Dim dv As DataView
            dv = New DataView(DS.Tables(0), "", "", DataViewRowState.OriginalRows)
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperarViaticosResolucion(ByVal IDEmpleado As Long, ByVal año As Integer, Optional ByVal numResolucion As String = "") As DataView
        Try
            Dim DS As New DataSet
            Dim strSql As String

            strSql = "SELECT * FROM " & Vistas.VW_RH_PER_VIATICOS & " WHERE NOT VIATICO_ID IS NULL "

            'Concatenando string de SQL de acuerdo a los parámetros recibidos.
            If IDEmpleado > 0 Then
                strSql = strSql & " AND EMPLEADO_ID = " & IDEmpleado & ""
            End If
            If año > 0 Then
                strSql = strSql & " AND ANO = " & año & ""
            End If

            If numResolucion <> "" Then
                strSql = strSql & " AND NRO_RESOLUCION = '" & numResolucion & "'"
            End If


            Dim daViaticosAsignados As New SqlDataAdapter(strSql, ArgoConfiguracion.ConnectionString)

            daViaticosAsignados.Fill(DS, Vistas.VW_RH_PER_VIATICOS)
            Dim dv As DataView
            dv = New DataView(DS.Tables(0), "", "", DataViewRowState.OriginalRows)
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperarViaticosNumeroMemorandum(ByVal año As Integer, ByVal ListaViatico As String, ByVal estadoViatico As Integer) As DataView
        Try
            Dim DS As New DataSet
            Dim strSql As String

            'strSql = "SELECT * FROM " & Vistas.VW_RH_PER_VIATICOS & " WHERE NOT VIATICO_ID IS NULL AND ANO = " & año & " AND VIATICO_ID = " & ViaticoId.ToString
            strSql = "SELECT * FROM " & Vistas.VW_RH_PER_VIATICOS & " WHERE NOT VIATICO_ID IS NULL AND ANO = " & año & " AND (ESTADO_VIATICO = " & estadoViatico.ToString & ") AND (VIATICO_ID IN " & ListaViatico & ")"

            Dim daViaticosAsignados As New SqlDataAdapter(strSql, ArgoConfiguracion.ConnectionString)

            daViaticosAsignados.Fill(DS, Vistas.VW_RH_PER_VIATICOS)
            Dim dv As DataView
            dv = New DataView(DS.Tables(0), "", "", DataViewRowState.OriginalRows)
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperaDetalleEUS(ByVal IDEus As Integer) As DataView
        Try
            Dim daEUS As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_REM_EUS & " WHERE EUS_ID=" & IDEus & " ORDER BY GRADO_ID, CALIDAD_JURIDICA_ID", ArgoConfiguracion.ConnectionString)
            daEUS.Fill(Me, Tablas.RH_REM_EUS)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_REM_EUS))
            dv.RowFilter = "EUS_ID=" & IDEus
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperaDetalleReajusteEUS(ByVal IDEus As Integer) As DataView
        Try
            Dim ds As New DataSet
            Dim strSql As String
            strSql = "SELECT * FROM VW_EUS_REVISION WHERE EUS_ID=" & IDEus & " ORDER BY GRADO_ID, CALIDAD_JURIDICA_ID"
            Dim da As New SqlDataAdapter(strSql, ArgoConfiguracion.ConnectionString)
            da.Fill(ds, "VW_EUS_REVISION")
            Dim dv As DataView
            dv = New DataView(ds.Tables(0), "", "", DataViewRowState.OriginalRows)
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function recuperarViaticosAsignadosAlDocumento(ByVal numeroDocumento As String) As DataView
        Try
            Dim DS As New DataSet
            Dim daViaticosAsignados As New SqlDataAdapter("SELECT * FROM " & Vistas.VW_RH_PER_VIATICOS & " WHERE NRO_MEMORANDUM_INTERNO='" & RTrim(LTrim(numeroDocumento)) & "'", ArgoConfiguracion.ConnectionString)
            daViaticosAsignados.Fill(DS, Vistas.VW_RH_PER_VIATICOS)
            Dim dv As DataView
            dv = New DataView(DS.Tables(0), "", "", DataViewRowState.OriginalRows)
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function recuperarHorasExtrasPorPeriodo(ByVal idPeriodo As Integer, ByVal tipoProceso As String) As DataView
        Dim cmd As String
        cmd = " AND TIPO_PROCESO=" + "'" + tipoProceso + "'"
        Try
            Dim daDetalleHorasExtrasPeriodo As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_PER_HORAS_EXTRAS & " WHERE PERIODO_ID=" & idPeriodo & cmd, ArgoConfiguracion.ConnectionString)
            daDetalleHorasExtrasPeriodo.Fill(Me, Tablas.RH_PER_HORAS_EXTRAS)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_PER_HORAS_EXTRAS))
            dv.RowFilter = "PERIODO_ID=" & idPeriodo & cmd
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try



        'Dim cmd As String = " AND TIPO_PROCESO=" & "'" + tipoProceso & "'"
        'Dim mySelectQuery As String = "SELECT * FROM " & Tablas.RH_PER_HORAS_EXTRAS & " WHERE PERIODO_ID=" & idPeriodo & cmd
        'Try
        '    Dim ds As New DataSet
        '    Dim da As New SqlDataAdapter(mySelectQuery, conn.ConnectionString)
        '    da.Fill(ds, "RH_PER_HORAS_EXTRAS")
        '    Return (ds.Tables("RH_PER_HORAS_EXTRAS"))
        'Catch ex As Exception
        '    Return Nothing
        'End Try
    End Function

    Public Function recuperarEmpleadosHonorariosParaEnviarADexon() As DataView
        Try
            Dim da As New SqlDataAdapter("SELECT * FROM VW_MAESTRO_EMPLEADO_HACIA_DEXON ORDER BY NOMBRE_EMPLEADO", ArgoConfiguracion.ConnectionString)
            da.Fill(Me, "VW_MAESTRO_EMPLEADO_HACIA_DEXON")
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables("VW_MAESTRO_EMPLEADO_HACIA_DEXON"))
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperaMovimientosPeriodoEmpleado(ByVal idPeriodo As Integer, ByVal tipoItem As Integer, ByVal idEmpleado As Long, ByVal tipoProceso As String, ByVal incluyeCalculo As Integer) As DataTable
        'Tipo Proceso: C=Cambio de grado;N=Normal;S=Suplementario;B=Bono Modernización;R=Recalculo Bono Modernizacion
        Dim cmd As String = ""
        If tipoProceso = "S" Then
            cmd = " AND (TIPO_PROCESO='S' OR TIPO_PROCESO='C' OR TIPO_PROCESO='B' OR TIPO_PROCESO='N') "
        Else
            If tipoProceso = "N" Or tipoProceso = "RH" Then
                cmd = " AND (TIPO_PROCESO='N' OR TIPO_PROCESO='C' OR TIPO_PROCESO='B') "
            Else
                If tipoProceso = "R" Then
                    cmd = " AND (TIPO_PROCESO='R' OR TIPO_PROCESO='C' OR TIPO_PROCESO='N') "
                End If
            End If
        End If

        Dim mySelectQuery As String = "SELECT * FROM " & Vistas.VW_MOVIMIENTO_MENSUAL & _
                                      " WHERE PERIODO_ID = " & idPeriodo & _
                                      " AND TIPO_ITEM = " & tipoItem & _
                                      " AND EMPLEADO_ID = " & idEmpleado & cmd & _
                                      " AND INCLUYE_CALCULO_SUELDO = " & incluyeCalculo

        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(mySelectQuery, conn.ConnectionString)
            da.Fill(ds, "VW_MOVIMIENTO_MENSUAL")
            Return (ds.Tables("VW_MOVIMIENTO_MENSUAL"))
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function recuperarEmpleadosActivos() As DataTable
        Dim mySelectQuery As String = "SELECT * FROM VW_MAESTRO_EMPLEADO" & _
                                      " WHERE CALIDAD_JURIDICA_ID=2" & _
                                      " OR CALIDAD_JURIDICA_ID=3" & _
                                      " AND ESTADO_EMPLEADO_ID=1"
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(mySelectQuery, conn.ConnectionString)
            da.Fill(ds, "VW_MAESTRO_EMPLEADO")
            Return (ds.Tables("VW_MAESTRO_EMPLEADO"))
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function recuperarEmpleadosAutorizaBienios(ByVal periodoId As Integer, ByVal soloEmpleadoActivos As Boolean, ByVal soloRegistrosPendientes As Boolean) As DataTable
        Dim cmdAdicional As String = ""
        If soloRegistrosPendientes Then
            cmdAdicional += " AND NUMERO_BIENIOS > 0 AND AUTORIZA_PAGO_BIENIO = 0 "
        End If
        If soloEmpleadoActivos Then
            cmdAdicional += " AND ESTADO_EMPLEADO_ID = 1 "
        End If
        Dim mySelectQuery As String = "SELECT ESTADO_REGISTRO, EMPLEADO_ID, ANTECEDENTE_REMUN_ID, NUMERO_BIENIOS, FECHA_CUMPLIO_BIENIOS, " & _
                                    "PERIODO_ID, USUARIO, FECHA_MODIFICACION, AUTORIZA_PAGO_BIENIO, OBSERVACION_AUTORIZA, " & _
                                    "NOMBRE_EMPLEADO, DESCRIPCION_PERIODO, CALIDAD_JURIDICA_ID, CALIDAD_JURIDICA, ESTADO_EMPLEADO_ID, ESTADO_EMPLEADO " & _
                                    "FROM VW_EMPLEADOS_BIENIOS " & _
                                    "WHERE PERIODO_ID = " + CStr(periodoId) & _
                                    " AND (ESTADO_REGISTRO = 1 OR ESTADO_REGISTRO = 5)" & cmdAdicional

        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(mySelectQuery, conn.ConnectionString)
            da.Fill(ds, "VW_EMPLEADOS_BIENIOS")
            Return (ds.Tables("VW_EMPLEADOS_BIENIOS"))
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function recuperaDatosBonoModernizacion(ByVal anno As Integer) As DataView

        Try
            Dim daBono As New SqlDataAdapter("SELECT * FROM " & Tablas.RH_REM_BONO_MODERNIZACION & " WHERE ANO=" & anno, conn)
            daBono.Fill(Me, Tablas.RH_REM_BONO_MODERNIZACION)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Tablas.RH_REM_BONO_MODERNIZACION))
            dv.RowFilter = "ANO=" & anno
            Return (dv)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function recuperaDetallePersonalFueraDotacion(ByVal anno As Integer, ByVal unidad_tiempo As Integer) As DataView

        Try
            Dim daPersonalFueraDotacion As New SqlDataAdapter("SELECT GENERO, SUBTOTAL, dbo.fn_MesEnLetra(MES) MES,CONVERT(VARCHAR,ANO) ANO, NUMERO_TRIMESTRE FROM " & Vistas.VW_LIQUIDACIONES_HONORARIOS_UNIDAD_TIEMPO & " WHERE ANO=" & anno & " AND NUMERO_TRIMESTRE=" & unidad_tiempo & _
                                             " GROUP BY MES,ANO,GENERO,[SUBTOTAL],NUMERO_TRIMESTRE", conn)
            daPersonalFueraDotacion.Fill(Me, Vistas.VW_LIQUIDACIONES_HONORARIOS_UNIDAD_TIEMPO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Vistas.VW_LIQUIDACIONES_HONORARIOS_UNIDAD_TIEMPO))
            dv.RowFilter = "ANO=" & anno & "AND NUMERO_TRIMESTRE=" & unidad_tiempo
            Return (dv)

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function recuperaInformacionCurricularPorDepto(ByVal anno As Integer) As DataView

        Try
            Dim daInformesCurriculares As New SqlDataAdapter("SELECT [NOMBRES], [EDUCACION], [EXPERIENCIA_LABORAL], [CALIDAD_JURIDICA_ID],[DEPARTAMENTO], [depto_id], [ESTADO_EMPLEADO_ID], [ANO], [RUT], [DV], [DIRECCION], [SUB_DEPTO], [ESTADO_EMPLEADO], [CANTIDAD], [APELLIDO_PATERNO], [APELLIDO_MATERNO], [NOMBRE] FROM " & Vistas.VW_ANTECEDENTES_CURRI & " WHERE ANO=" & anno, conn)
            daInformesCurriculares.Fill(Me, Vistas.VW_ANTECEDENTES_CURRI)

            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Vistas.VW_ANTECEDENTES_CURRI))
            dv.RowFilter = "ANO=" & anno
            Return (dv)

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function recuperaCuadroComparativoHonorarios(ByVal anno As Integer) As DataView

        Try
            Dim daPersonalFueraDotacion As New SqlDataAdapter("SELECT [NOMBRES], [FECHA_CONTRATO_DESDE], [FECHA_CONTRATO_HASTA], [TITULO_PROFESIONAL_EXPERTIZ], [CARGO_ACTUAL], [FUNCIONES_DESEMPENADAS], [MONTO_BRUTO], [MONTO_LIQUIDO], [AÑO], [RUT], [DV], [DIRECCION], [DEPARTAMENTO], [SUB_DEPTO], [APELLIDO_PATERNO], [APELLIDO_MATERNO], [NOMBRE] FROM " & Vistas.VW_HONORARIOS_CUADRO_COMPARATIVO & "  WHERE AÑO=" & anno, conn)

            daPersonalFueraDotacion.Fill(Me, Vistas.VW_HONORARIOS_CUADRO_COMPARATIVO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Vistas.VW_HONORARIOS_CUADRO_COMPARATIVO))
            dv.RowFilter = "AÑO=" & anno
            Return (dv)

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function recuperaPresupuestoAnualHonorarios(ByVal anno As Integer) As DataView

        Try
            Dim daPersonalFueraDotacion As New SqlDataAdapter("SELECT [NOMBRES], [FECHA_CONTRATO_DESDE], [FECHA_CONTRATO_HASTA],  EMPLEADO_ID, ESTADO_REGISTRO, " & _
                      " AÑO, PERIODO_ID, NOMBRES,RUT, DV, FECHA_CONTRATO_DESDE, FECHA_CONTRATO_HASTA, MONTO_ENERO, MONTO_FEBRERO, " & _
                      " MONTO_MARZO, MONTO_ABRIL,MONTO_MAYO, MONTO_JUNIO, MONTO_JULIO, MONTO_AGOSTO, MONTO_SEPTIEMBRE, MONTO_OCTUBRE,MONTO_NOVIEMBRE,MONTO_DICIEMBRE, " & _
                      " (MONTO_ENERO+MONTO_FEBRERO+MONTO_MARZO+MONTO_ABRIL+MONTO_MAYO+MONTO_JUNIO+MONTO_JULIO+ " & _
                      " MONTO_AGOSTO+MONTO_SEPTIEMBRE+MONTO_OCTUBRE+MONTO_NOVIEMBRE+MONTO_DICIEMBRE) AS TOTAL_HONORARIOS, DIRECCION, DEPARTAMENTO, SUB_DEPTO, ESTADO_EMPLEADO, [APELLIDO_PATERNO], [APELLIDO_MATERNO], [NOMBRE] " & _
                      " FROM " & Vistas.VW_ANTECEDENTES_HONORARIOS_MENSUALES & "  WHERE AÑO=" & anno, conn)

            daPersonalFueraDotacion.Fill(Me, Vistas.VW_HONORARIOS_CUADRO_COMPARATIVO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Vistas.VW_HONORARIOS_CUADRO_COMPARATIVO))
            dv.RowFilter = "AÑO=" & anno
            Return (dv)

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function recuperaPresupuestoDetalladoHonorarios(ByVal anno As Integer) As DataView

        Try
            Dim daPersonalFueraDotacion As New SqlDataAdapter("SELECT AÑO, EMPLEADO_ID, RUT, DV, NOMBRE_EMPLEADO, MONTO_ENERO, MONTO_FEBRERO, MONTO_MARZO, MONTO_ABRIL, MONTO_MAYO, " & _
                      "MONTO_JUNIO, MONTO_JULIO, MONTO_AGOSTO, MONTO_SEPTIEMBRE, MONTO_OCTUBRE, MONTO_NOVIEMBRE, MONTO_DICIEMBRE, PERIODO_ID, " & _
                      "FECHA_CONTRATO_DESDE, FECHA_CONTRATO_HASTA, NRO_SOLUCION, FECHA_RESOLUCION, ES_RETIRO_EMPLEADO, MONTO_VIGENTE, DIRECCION, " & _
                      "DEPARTAMENTO, SUB_DEPTO, MOTIVO_RETIRO FROM " & Vistas.VW_ANTECEDENTES_HONORARIOS_DETALLADO & "  WHERE AÑO=" & anno, conn)

            daPersonalFueraDotacion.Fill(Me, Vistas.VW_ANTECEDENTES_HONORARIOS_DETALLADO)
            Dim dv As DataView
            Dim dvm As New DataViewManager(Me)
            dv = dvm.CreateDataView(Me.Tables(Vistas.VW_ANTECEDENTES_HONORARIOS_DETALLADO))
            dv.RowFilter = "AÑO=" & anno
            Return (dv)

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function generaArchivoPlanoImposiciones78Campos(ByVal tipoPago As String, ByVal idPeriodo As Integer, ByVal valorUF As Decimal) As Boolean
        Dim tipoCalculo, cmd As String
        EjecutaSQL("DELETE FROM RH_REM_TXT_PLANO_PREVIRED")

        If tipoPago = "01" Then
            tipoCalculo = "N"  'Proceso normal de remuneraciones
        Else
            If tipoPago = "02" Then
                tipoCalculo = "RH"  'Proceso de reliquidacion de sueldos historicos
            Else
                tipoCalculo = "R"  'Bono modernizacion
            End If
        End If

        Dim sql As String
        sql = " AND TIPO_CALCULO = " + "'" + tipoCalculo + "'" + " ORDER BY RUT"
        Dim queryVistaImposiciones As String = "SELECT * FROM " & Vistas.VW_IMPOSICIONES & _
                                               " WHERE PERIODO_ID = " & idPeriodo & _
                                               " AND ORGANIZACION_ID = " & ArgoConfiguracion.OrganizacionID & sql

        Try
            Dim dset As New DataSet
            Dim dtImposicion As DataTable
            Dim da As New SqlDataAdapter(queryVistaImposiciones, conn.ConnectionString)
            'da.Fill(dset, Vistas.VW_IMPOSICIONES)
            da.Fill(dset, queryVistaImposiciones)
            'dtImposicion = dset.Tables(Vistas.VW_IMPOSICIONES)
            dtImposicion = dset.Tables(queryVistaImposiciones)

            Dim myStr As String
            Dim linea As String
            Dim registro As Data.DataRow
            For Each registro In dtImposicion.Rows
                linea = ""
                '01
                myStr = CType(registro("RUT"), String)
                linea += myStr.PadLeft(11, "0"c)
                '02
                linea += registro("DV")
                '03
                myStr = CType(registro("APELLIDO_PATERNO"), String).Replace("Ñ", "N").Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "U")
                linea += myStr.PadRight(30, " "c)
                '04
                myStr = CType(registro("APELLIDO_MATERNO"), String).Replace("Ñ", "N").Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "U")
                linea += myStr.PadRight(30, " "c)
                '05
                myStr = CType(registro("NOMBRES"), String).Replace("Ñ", "N").Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "U")
                linea += myStr.PadRight(30, " "c)
                '06
                linea += registro("SEXO")
                '07
                linea += tipoPago
                '08
                linea += registro("REMUN_DESDE")
                '09
                linea += registro("REMUN_HASTA")
                '10
                myStr = CType(registro("IMPONIBLE"), String)
                linea += myStr.PadLeft(8, "0"c)
                '11
                linea += registro("REGIMEN_PREVISIONAL_AFP")
                '12
                myStr = CType(registro("TIPO_TRABAJADOR"), String)
                linea += myStr.PadLeft(1, "0"c)
                '13
                myStr = CType(registro("DIAS_TRABAJADOS"), String)
                linea += myStr.PadLeft(2, "0"c)
                '14
                linea += "0"
                '15
                linea += Space(10)
                '16
                linea += Space(10)
                '17
                linea += registro("TRAMO_ASIGNACION_FAMILIAR")
                myStr = CType(registro("NUM_CARGAS_SIMPLES"), String)
                '18
                linea += myStr.PadLeft(1, "0"c)
                '19
                myStr = CType(registro("NUM_CARGAS_MATERNALES"), String)
                linea += myStr.PadLeft(1, "0"c)
                '20
                myStr = CType(registro("NUM_CARGAS_INVALIDAS"), String)
                linea += myStr.PadLeft(1, "0"c)
                '21
                myStr = CType(registro("MONTO_ASIGNACION_FAMILIAR"), String)
                linea += myStr.PadLeft(6, "0"c)
                '22
                myStr = CType(registro("MONTO_ASIGNACION_FAMILIAR_RETROACTIVA"), String)
                linea += myStr.PadLeft(6, "0"c)
                '23
                myStr = CType(registro("MONTO_REINGRESO_CARGA_FAMILIAR"), String)
                linea += myStr.PadLeft(6, "0"c) 'Ok
                '24
                myStr = CType(registro("CODIGO_AFP"), String)
                linea += myStr.PadLeft(2, "0"c)
                '25
                If registro("REGIMEN_PREVISIONAL_AFP") = "AFP" Then
                    myStr = CType(registro("COTIZACION_OBLIGATORIA_AFP"), String)
                    linea += myStr.PadLeft(8, "0"c)
                Else
                    myStr = ""
                    linea += myStr.PadLeft(8, "0"c)
                End If
                '26
                If registro("REGIMEN_PREVISIONAL_AFP") = "AFP" Then
                    myStr = CType(Int(registro("CUENTA_AHORRO_VOLUNTARIO_AFP")), String)
                    linea += myStr.PadLeft(8, "0"c)
                Else
                    myStr = ""
                    linea += myStr.PadLeft(8, "0"c)
                End If
                '27
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
                '28
                linea += "00.00"
                '29
                myStr = ""
                linea += myStr.PadLeft(9, "0"c)
                '30
                myStr = ""
                linea += myStr.PadLeft(2, "0"c)
                '31
                linea += Space(10)
                '32
                linea += Space(10)
                '33
                linea += Space(40)
                '34
                linea += "00.00"
                '35
                myStr = ""
                linea += myStr.PadLeft(6, "0"c)
                '36
                myStr = CType(registro("AFP_RUT"), String)
                linea += myStr.PadLeft(11, "0"c)
                '37
                linea += CType(registro("AFP_DV"), String)
                '38
                If registro("REGIMEN_PREVISIONAL_AFP") = "INP" Then
                    linea += registro("CODIGO_EXCAJA")
                Else
                    linea += Format(registro("CODIGO_EXCAJA"), "0000")
                End If
                '39
                linea += Format(registro("TASA_EX_CAJA"), "00.00")
                '40
                myStr = CType(registro("COTIZACION_OBLIGATORIA_INP"), String)
                linea += myStr.PadLeft(8, "0"c)
                '41
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
                '42
                myStr = ""
                linea += myStr.PadLeft(4, "0"c)
                '43
                linea += "00.00"
                '44
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
                '45
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
                '46
                Dim totalPagadoINP As Integer = 0
                If registro("REGIMEN_PREVISIONAL_AFP") = "INP" Or registro("REGIMEN_PREVISIONAL_SALUD") = "FON" Then
                    totalPagadoINP = registro("COTIZACION_FONASA_INP") + registro("COTIZACION_OBLIGATORIA_INP")
                    myStr = CType(registro("COTIZACION_FONASA_INP"), String)
                    linea += myStr.PadLeft(8, "0"c)
                Else
                    myStr = ""
                    linea += myStr.PadLeft(8, "0"c)
                End If
                '47
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
                '48
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
                '49
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
                '50
                myStr = CType(totalPagadoINP, String)
                linea += myStr.PadLeft(8, "0"c)
                '51
                myStr = CType(registro("CODIGO_ISAPRE"), String)
                linea += myStr.PadLeft(2, "0"c)
                '52
                Dim tipoMoneda As Integer
                If registro("REGIMEN_PREVISIONAL_SALUD") = "FON" Then
                    tipoMoneda = 1
                Else
                    If registro("MONEDA_MONTO_ISAPRE_ID") = 1 Or registro("MONEDA_MONTO_ISAPRE_ID") = 2 Then
                        tipoMoneda = registro("MONEDA_MONTO_ISAPRE_ID")
                    Else
                        tipoMoneda = 1
                    End If
                End If
                myStr = CType(tipoMoneda, String)
                linea += myStr.PadLeft(1, "0"c)
                '53
                If registro("REGIMEN_PREVISIONAL_SALUD") = "ISA" Then
                    myStr = CType(registro("COT_LEGAL_SALUD"), String)
                    linea += myStr.PadLeft(8, "0"c)
                Else
                    myStr = ""
                    linea += myStr.PadLeft(8, "0"c)
                End If
                '54
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
                '55
                If registro("REGIMEN_PREVISIONAL_SALUD") = "ISA" Then
                    myStr = CType(registro("COT_ADICIONAL_VOLUNTARIO_SALUD"), String)
                    linea += myStr.PadLeft(8, "0"c)
                Else
                    myStr = ""
                    linea += myStr.PadLeft(8, "0"c)
                End If
                '56
                If registro("REGIMEN_PREVISIONAL_SALUD") = "ISA" And CType(registro("CODIGO_ISAPRE"), String) <> "18" Then
                    myStr = CType(registro("COT_PLAN_COMPLEMENTARIO_SALUD"), String)
                    linea += myStr.PadLeft(8, "0"c)
                Else
                    myStr = ""
                    linea += myStr.PadLeft(8, "0"c)
                End If
                '57
                Dim cotizPactadaPesos As Integer
                Dim cotizPactadaUF As Double
                If registro("REGIMEN_PREVISIONAL_SALUD") = "ISA" Then
                    If registro("MONEDA_MONTO_ISAPRE_ID") = 1 Then
                        cotizPactadaPesos = registro("MONTO_ISAPRE") + registro("MONTO_PLAN_AUGE")
                        myStr = Format(cotizPactadaPesos, "00000000")
                    Else
                        If registro("MONEDA_MONTO_ISAPRE_ID") = 2 Then
                            cotizPactadaUF = registro("MONTO_ISAPRE") + registro("MONTO_PLAN_AUGE")
                            Dim valorStr As String
                            valorStr = Format(cotizPactadaUF, "000.0000")
                            Mid(valorStr, 4, 1) = ","
                            myStr = valorStr
                        Else
                            myStr = "00000000"
                        End If
                    End If
                Else
                    myStr = "00000000"
                End If
                linea += myStr
                '58
                Dim totalPagadoIsapre As Integer = 0
                If registro("REGIMEN_PREVISIONAL_SALUD") = "ISA" Then
                    totalPagadoIsapre = registro("COT_LEGAL_SALUD") + registro("COT_ADICIONAL_VOLUNTARIO_SALUD") + registro("COT_PLAN_COMPLEMENTARIO_SALUD")
                End If
                myStr = CType(totalPagadoIsapre, Integer)
                linea += myStr.PadLeft(8, "0"c)
                '59
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)                     'OK
                '60
                myStr = ""
                linea += myStr.PadLeft(2, "0"c)
                '61
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
                '62
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
                '63
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
                '64
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
                '65
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
                '66
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
                '67
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
                '68
                myStr = registro("CODIGO_PREVIRED_INSTITUCION_SEGURIDAD")
                linea += myStr.PadLeft(2, "0"c)
                '69
                myStr = registro("MONTO_COTIZACION_MUTUAL")
                linea += myStr.PadLeft(8, "0"c)
                '70
                myStr = ""
                linea += myStr.PadLeft(3, "0"c)
                If registro("MONTO_APV") > 0 Then
                    Dim queryAPV As String = "SELECT * FROM " & Vistas.VW_ANTECEDENTE_APV & _
                                                     " WHERE EMPLEADO_ID = " & CType(registro("EMPLEADO_ID"), String) & _
                                                     " AND ESTADO_REGISTRO = 1"

                    Dim dsApv As New DataSet
                    Dim dtApv As DataTable
                    Dim daApv As New SqlDataAdapter(queryAPV, conn.ConnectionString)
                    daApv.Fill(dsApv, Vistas.VW_ANTECEDENTE_APV)
                    dtApv = dsApv.Tables(Vistas.VW_ANTECEDENTE_APV)
                    Dim registroApv As Data.DataRow
                    Dim numLinea As Integer = 1
                    For Each registroApv In dtApv.Rows
                        If numLinea = 1 Then
                            'Solamente se ejecuta una vez, cuando el empleado tenga una institución APV
                            '71
                            myStr = CType(registroApv("CODIGO_PREVIRED"), String)
                            linea += myStr.PadLeft(3, "0"c)
                            '72
                            linea += "1"
                            If registroApv("TIPO_AHORRO_PREVISIONAL") = 1 Then
                                If registroApv("MONEDA_AHORRO_APV_ID") = 1 Then
                                    myStr = Format(Math.Round(registroApv("MONTO_AHORRO"), 0), "00000000")
                                Else
                                    myStr = Format((Math.Round(registroApv("MONTO_AHORRO") * valorUF, 0)), "00000000")
                                End If
                                '73
                                linea += myStr.PadLeft(8, "0"c)
                                '74
                                myStr = ""
                                linea += myStr.PadLeft(8, "0"c)
                            Else
                                '73
                                myStr = ""
                                linea += myStr.PadLeft(8, "0"c)
                                If registroApv("MONEDA_AHORRO_APV_ID") = 1 Then
                                    myStr = Format(Math.Round(registroApv("MONTO_AHORRO"), 0), "00000000")
                                Else
                                    myStr = Format((Math.Round(registroApv("MONTO_AHORRO") * valorUF, 0)), "00000000")
                                End If
                                '74
                                linea += myStr.PadLeft(8, "0"c)
                            End If
                            '75
                            myStr = ""
                            linea += myStr.PadLeft(8, "0"c)
                            '76
                            myStr = ""
                            linea += myStr.PadLeft(8, "0"c)
                            '77
                            myStr = ""
                            linea += myStr.PadLeft(8, "0"c)
                            '78
                            linea += Space(3)
                            cmd = "sp_insertaRegistroImposicionesPrevired " + "'" + linea + "'"
                            EjecutaSQL(cmd)
                        Else
                            'Aca genera segunda linea en caso que el empleado tenga mas de una
                            'institución de APV
                            linea = Space(519)
                            '71
                            myStr = CType(registroApv("CODIGO_PREVIRED"), String)
                            linea += myStr.PadLeft(3, "0"c)
                            '72
                            linea += "1"
                            If registroApv("TIPO_AHORRO_PREVISIONAL") = 1 Then
                                If registroApv("MONEDA_AHORRO_APV_ID") = 1 Then
                                    myStr = Format(Math.Round(registroApv("MONTO_AHORRO"), 0), "00000000")
                                Else
                                    myStr = Format((Math.Round(registroApv("MONTO_AHORRO") * valorUF, 0)), "00000000")
                                End If
                                '73
                                linea += myStr.PadLeft(8, "0"c)
                                '74
                                myStr = ""
                                linea += myStr.PadLeft(8, "0"c)
                            Else
                                '73
                                myStr = ""
                                linea += myStr.PadLeft(8, "0"c)
                                If registroApv("MONEDA_AHORRO_APV_ID") = 1 Then
                                    myStr = Format(Math.Round(registroApv("MONTO_AHORRO"), 0), "00000000")
                                Else
                                    myStr = Format((Math.Round(registroApv("MONTO_AHORRO") * valorUF, 0)), "00000000")
                                End If
                                '74
                                linea += myStr.PadLeft(8, "0"c)
                            End If
                            linea += Space(27)
                            cmd = "sp_insertaRegistroImposicionesPrevired " + "'" + linea + "'"
                            EjecutaSQL(cmd)
                        End If
                        numLinea += 1
                    Next
                Else
                    '71
                    myStr = ""
                    linea += myStr.PadLeft(3, "0"c)
                    '72
                    linea += "0"
                    '73
                    myStr = ""
                    linea += myStr.PadLeft(8, "0"c)
                    '74
                    myStr = ""
                    linea += myStr.PadLeft(8, "0"c)
                    '75
                    myStr = ""
                    linea += myStr.PadLeft(8, "0"c)
                    '76
                    myStr = ""
                    linea += myStr.PadLeft(8, "0"c)
                    '77
                    myStr = ""
                    linea += myStr.PadLeft(8, "0"c)
                    '78
                    linea += Space(3)
                    cmd = "sp_insertaRegistroImposicionesPrevired " + "'" + linea + "'"
                    EjecutaSQL(cmd)
                End If
                'Len(linea)
            Next
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Public Function generaArchivoPlanoImposiciones105Campos(ByVal tipoPago As String, ByVal idPeriodo As Integer, ByVal valorUFMesActual As Decimal, ByVal valorUfMesAnterior As Decimal, ByVal topeImponible As Decimal) As Boolean
        Dim tipoCalculo, cmd As String
        EjecutaSQL("DELETE FROM RH_REM_TXT_PLANO_PREVIRED")

        If tipoPago = "01" Then
            tipoCalculo = "N"  'Proceso normal de remuneraciones
        Else
            If tipoPago = "02" Then
                tipoCalculo = "RH"  'Proceso de reliquidacion de sueldos historicos
            Else
                tipoCalculo = "R"  'Bono modernizacion
            End If
        End If

        Dim sql As String
        sql = " AND TIPO_CALCULO = " + "'" + tipoCalculo + "'" + " ORDER BY RUT"
        Dim queryVistaImposiciones As String = "SELECT * FROM " & Vistas.VW_IMPOSICIONES & _
                                               " WHERE PERIODO_ID = " & idPeriodo & _
                                               " AND ORGANIZACION_ID = " & ArgoConfiguracion.OrganizacionID & sql

        Try
            Dim dset As New DataSet
            Dim dtImposicion As DataTable
            Dim da As New SqlDataAdapter(queryVistaImposiciones, conn.ConnectionString)
            da.Fill(dset, queryVistaImposiciones)
            dtImposicion = dset.Tables(queryVistaImposiciones)

            Dim myStr As String = ""
            Dim linea As String = ""
            Dim registro As Data.DataRow

            For Each registro In dtImposicion.Rows
                Dim apvArray(9, 4) As Integer '= {{0, 0, 0, 0}, {0, 0, 0, 0}}
                Dim indice As Integer = 0
                Dim filaAPV As Integer = 0
                Dim esLineaBase As Boolean = True
                Dim idEmpleado As Integer = registro("EMPLEADO_ID")

                linea = ""
                linea += datosTrabajadorPrevired(registro, tipoPago, esLineaBase)
                linea += datosAFPPrevired(registro, esLineaBase)

                If registro("MONTO_APV") > 0 Then
                    Dim queryAPV As String = "SELECT * FROM " & Vistas.VW_ANTECEDENTE_APV & _
                                                     " WHERE EMPLEADO_ID = " & CType(registro("EMPLEADO_ID"), String) & _
                                                     " AND ESTADO_REGISTRO = 1"

                    Dim dsApv As New DataSet
                    Dim dtApv As DataTable
                    Dim daApv As New SqlDataAdapter(queryAPV, conn.ConnectionString)
                    daApv.Fill(dsApv, Vistas.VW_ANTECEDENTE_APV)
                    dtApv = dsApv.Tables(Vistas.VW_ANTECEDENTE_APV)

                    'If registro("RUT") = 9407927 Then
                    '    Dim a As Integer
                    '    a = 1
                    'End If

                    Dim registroApv As Data.DataRow
                    Dim i As Integer = -1
                    For Each registroApv In dtApv.Rows
                        apvArray(indice, 0) = registroApv("CODIGO_PREVIRED")
                        apvArray(indice, 1) = registroApv("TIPO_AHORRO_PREVISIONAL")
                        apvArray(indice, 2) = registroApv("MONTO_AHORRO")
                        apvArray(indice, 3) = registroApv("MONEDA_AHORRO_APV_ID")
                        apvArray(indice, 4) = registroApv("APV_ID")
                        indice = indice + 1
                    Next
                    linea += datosAPVPrevired(apvArray, valorUFMesActual, filaAPV, idEmpleado, idPeriodo)
                    indice = indice - 1
                Else
                    linea += datosAPVPrevired(apvArray, valorUFMesActual, filaAPV, idEmpleado, idPeriodo)
                End If
                linea += datosAPVColectivoPrevired()
                linea += datosAfiliadoVoluntarioPrevired()
                linea += datosIpsFonasaPrevired(registro, valorUFMesActual, valorUfMesAnterior, topeImponible, esLineaBase)
                linea += datosIsaprePrevired(registro, esLineaBase)
                linea += datosCCAFPrevired()
                linea += datosMutualPrevired(registro, esLineaBase)
                linea += datosSeguroCesantia()
                linea += datosPagadorSubsidioPrevired()
                linea += datosOtrosDatosEmpresa()

                cmd = "sp_insertaRegistroImposicionesPrevired " + "'" + linea + "'"
                EjecutaSQL(cmd)

                If indice > 0 Then
                    For i As Integer = 1 To indice
                        linea = ""
                        linea += datosTrabajadorPrevired(registro, tipoPago, False)
                        linea += datosAFPPrevired(registro, False)
                        linea += datosAPVPrevired(apvArray, valorUFMesActual, i, idEmpleado, idPeriodo)
                        linea += datosAPVColectivoPrevired()
                        linea += datosAfiliadoVoluntarioPrevired()
                        linea += datosIpsFonasaPrevired(registro, valorUFMesActual, valorUfMesAnterior, topeImponible, False)
                        linea += datosIsaprePrevired(registro, False)
                        linea += datosCCAFPrevired()
                        linea += datosMutualPrevired(registro, False)
                        linea += datosSeguroCesantia()
                        linea += datosPagadorSubsidioPrevired()
                        linea += datosOtrosDatosEmpresa()
                        cmd = "sp_insertaRegistroImposicionesPrevired " + "'" + linea + "'"
                        EjecutaSQL(cmd)
                    Next i
                End If
            Next
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Function datosTrabajadorPrevired(ByVal registro As Data.DataRow, ByVal tipoPago As String, ByVal esLineaBase As Boolean) As Object
        Dim myStr As String = ""
        Dim linea As String = ""
        Dim nacionalidad As String = "0"

        '01 rut trabajador
        myStr = CType(registro("RUT"), String)
        linea += myStr.PadLeft(11, "0"c)
        '02 digito verificador rut trabajador
        linea += registro("DV")
        '03 apellido paterno
        myStr = CType(registro("APELLIDO_PATERNO"), String).Replace("Ñ", "N").Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "U")
        linea += myStr.PadRight(30, " "c)
        '04 apellido materno
        myStr = CType(registro("APELLIDO_MATERNO"), String).Replace("Ñ", "N").Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "U")
        linea += myStr.PadRight(30, " "c)
        '05 nombres
        myStr = CType(registro("NOMBRES"), String).Replace("Ñ", "N").Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "U")
        linea += myStr.PadRight(30, " "c)
        '06 sexo
        linea += registro("SEXO")
        '07 nacionalidad
        linea += nacionalidad
        '08 tipo pago 01=remun.del mes;02=gratificaciones;03=bono ley modernizacion
        linea += tipoPago
        '09 periodo desde
        linea += registro("REMUN_DESDE")
        '10 periodo hasta
        linea += registro("REMUN_HASTA")
        '11 regimen previsional
        linea += registro("REGIMEN_PREVISIONAL_AFP")
        '12 tipo trabajador
        myStr = CType(registro("TIPO_TRABAJADOR"), String)
        linea += myStr.PadLeft(1, "0"c)
        '13 días trabajados
        If esLineaBase Then
            myStr = CType(registro("DIAS_TRABAJADOS"), String)
            linea += myStr.PadLeft(2, "0"c)
        Else
            myStr = CType(0, String)
            linea += myStr.PadLeft(2, "0"c)
        End If
        '14 tipo linea 00=linea principal o base 01=linea adicional;02=segundo contrato;03=movimiento de personal afiliado voluntario
        linea += "00"
        '15 codigo movimiento de personal
        linea += "00"
        '16 fecha desde
        linea += Space(10)
        '17 fecha hasta
        linea += Space(10)
        If esLineaBase Then
            '18 tramo asignacion familiar
            linea += registro("TRAMO_ASIGNACION_FAMILIAR")
            '19 numero cargas familiares simples
            myStr = CType(registro("NUM_CARGAS_SIMPLES"), String)
            linea += myStr.PadLeft(2, "0"c)
            '20 numero cargas familiares maternales
            myStr = CType(registro("NUM_CARGAS_MATERNALES"), String)
            linea += myStr.PadLeft(1, "0"c)
            '21 numero cargas familiares invalidas
            myStr = CType(registro("NUM_CARGAS_INVALIDAS"), String)
            linea += myStr.PadLeft(1, "0"c)
            '22 monto asignacion familiar
            myStr = CType(registro("MONTO_ASIGNACION_FAMILIAR"), String)
            linea += myStr.PadLeft(6, "0"c)
            '23 monto asignacion familiar retroactiva
            myStr = CType(registro("MONTO_ASIGNACION_FAMILIAR_RETROACTIVA"), String)
            linea += myStr.PadLeft(6, "0"c)
            '24 reintegro cargas familiares
            myStr = CType(registro("MONTO_REINGRESO_CARGA_FAMILIAR"), String)
            linea += myStr.PadLeft(6, "0"c)
            '25 subsidio trabajador joven
            linea += "N"
        Else
            '18 tramo asignacion familiar
            linea += " "
            '19 numero cargas familiares simples
            myStr = CType(0, String)
            linea += myStr.PadLeft(2, "0"c)
            '20 numero cargas familiares maternales
            myStr = CType(0, String)
            linea += myStr.PadLeft(1, "0"c)
            '21 numero cargas familiares invalidas
            myStr = CType(0, String)
            linea += myStr.PadLeft(1, "0"c)
            '22 monto asignacion familiar
            myStr = CType(0, String)
            linea += myStr.PadLeft(6, "0"c)
            '23 monto asignacion familiar retroactiva
            myStr = CType(0, String)
            linea += myStr.PadLeft(6, "0"c)
            '24 reintegro cargas familiares
            myStr = CType(0, String)
            linea += myStr.PadLeft(6, "0"c)
            '25 subsidio trabajador joven
            linea += " "
        End If
        Return linea
    End Function

    Private Function datosAFPPrevired(ByVal registro As Data.DataRow, ByVal esLineaBase As Boolean) As Object
        Dim myStr As String = ""
        Dim linea As String = ""

        If esLineaBase Then
            '26 codigo afp
            If registro("REGIMEN_PREVISIONAL_AFP") = "AFP" Then
                myStr = CType(registro("CODIGO_AFP"), String)
                linea += myStr.PadLeft(2, "0"c)
            Else
                myStr = CType(0, String)
                linea += myStr.PadLeft(2, "0"c)
            End If
            '27 monto imponible
            If registro("REGIMEN_PREVISIONAL_AFP") = "AFP" Then
                myStr = CType(registro("IMPONIBLE"), String)
                linea += myStr.PadLeft(8, "0"c)
            Else
                myStr = CType(0, String)
                linea += myStr.PadLeft(8, "0"c)
            End If
            '28 cotización obligatoria
            If registro("REGIMEN_PREVISIONAL_AFP") = "AFP" Then
                myStr = CType(registro("COTIZACION_OBLIGATORIA_AFP"), String)
                linea += myStr.PadLeft(8, "0"c)
            Else
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
            End If
            '29 seguro invalidez y sobrevivencia
            If registro("REGIMEN_PREVISIONAL_AFP") = "AFP" Then
                myStr = CType(registro("MONTO_SEGURO_INVALIDEZ_SOBR"), String)
                linea += myStr.PadLeft(8, "0"c)
            Else
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
            End If
            '30 cuenta ahorro voluntario
            If registro("REGIMEN_PREVISIONAL_AFP") = "AFP" Then
                myStr = CType(Int(registro("CUENTA_AHORRO_VOLUNTARIO_AFP")), String)
                linea += myStr.PadLeft(8, "0"c)
            Else
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
            End If
        Else
            '26 codigo afp
            myStr = CType(0, String)
            linea += myStr.PadLeft(2, "0"c)
            '27 monto imponible
            myStr = CType(0, String)
            linea += myStr.PadLeft(8, "0"c)
            '28 cotización obligatoria
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
            '29 seguro invalidez y sobrevivencia
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
            '30 cuenta ahorro voluntario
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
        End If
        '31 renta imponible sustitutiva
        myStr = ""
        linea += myStr.PadLeft(8, "0"c)
        '32 tasa pactada sustit.
        linea += "00.00"
        '33 aporte indemnizacion sustit.
        myStr = ""
        linea += myStr.PadLeft(9, "0"c)
        '34 numero periodos sustit.
        myStr = ""
        linea += myStr.PadLeft(2, "0"c)
        '35 periodo desde sustit.
        linea += Space(10)
        '36 periodo hasta sustit
        linea += Space(10)
        '37 puesto de trabajo pesado
        linea += Space(40)
        '38 % cotizacion trabajo pesado
        linea += "00.00"
        '39 monto cotizacion trabajo pesado
        myStr = ""
        linea += myStr.PadLeft(6, "0"c)
        Return linea
    End Function
    Private Function datosAPVPrevired(ByVal apvArray(,) As Integer, ByVal valorUF As Decimal, ByVal fila As Integer, ByVal idEmpleado As Integer, ByVal idPeriodo As Integer) As Object
        Dim myStr As String = ""
        Dim linea As String = ""
        Dim itemIdAPV As Integer = Busca("SELECT ITEM_MONTO_APV_ID FROM RH_REM_PERIODO WHERE PERIODO_ID = " & CType(idPeriodo, String))
        Dim montoAPV As Integer = Busca("SELECT MONTO FROM RH_REM_LIQUIDACION WHERE (ITEM_ID = " & CType(itemIdAPV, String) & ") AND (PERIODO_ID = " & CType(idPeriodo, String) & ") AND (EMPLEADO_ID = " & CType(idEmpleado, String) & ") AND (APV_ID = " & apvArray(fila, 4).ToString & ")")

        'Las columnas del arreglo apvArray son:
        '0 = codigo apv
        '1 = tipo ahorro previsional
        '2 = monto ahorro
        '3 = tipo moneda

        '40 codigo APV
        myStr = CType(apvArray(fila, 0), String)
        linea += myStr.PadLeft(3, "0"c)
        '41 numero contrato
        linea += Space(20)
        '42 forma pago 1=directa;2=indirecta
        If apvArray(fila, 0) = 0 Then
            linea += "0"
        Else
            linea += "1"
        End If
        If apvArray(fila, 1) = 1 Then 'Ahorro voluntario
            If apvArray(fila, 3) = 1 Then
                myStr = Format(Math.Round(apvArray(fila, 2), 0), "00000000")
            Else
                myStr = Format((Math.Round(apvArray(fila, 2) * valorUF, 0)), "00000000")
            End If
            '43 monto apv
            myStr = Format(montoAPV, "00000000")
            linea += myStr.PadLeft(8, "0"c)
            '44 monto deposito convenido
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
        Else
            If apvArray(fila, 1) = 2 Then 'deposito convenido
                '43 monto apv
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
                If apvArray(fila, 3) = 1 Then
                    myStr = Format(Math.Round(apvArray(fila, 2), 0), "00000000")
                Else
                    myStr = Format((Math.Round(apvArray(fila, 2) * valorUF, 0)), "00000000")
                End If
                '44 monto deposito convenido
                linea += myStr.PadLeft(8, "0"c)
            Else
                '43 monto apv
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
                '44 monto deposito convenido
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
            End If
        End If
        Return linea
    End Function

    Private Function datosAPVColectivoPrevired() As Object
        Dim myStr As String = ""
        Dim linea As String = ""

        '45 codigo APVC
        linea += myStr.PadLeft(3, "0"c)
        '46 numero contrato
        linea += Space(20)
        '47 forma pago 1=directa;2=indirecta
        linea += "1"
        '48 monto APVC
        myStr = ""
        linea += myStr.PadLeft(8, "0"c)
        '49 monto empleado APVC
        myStr = ""
        linea += myStr.PadLeft(8, "0"c)
        Return linea
    End Function

    Private Function datosAfiliadoVoluntarioPrevired() As Object
        Dim myStr As String = ""
        Dim linea As String = ""

        '50 rut afiliado
        myStr = CType(0, String)
        linea += myStr.PadLeft(11, "0"c)
        '51 dv afiliado
        linea += " "
        '52 apellido paterno
        linea += Space(30)
        '53 apellido materno
        linea += Space(30)
        '54 nombres
        linea += Space(30)
        '55 codigo movimiento
        linea += "00"
        '56 fecha desde
        linea += Space(10)
        '57 fecha hasta
        linea += Space(10)
        '58 codigo afp
        linea += "00"
        '59 monto capitalizacion voluntaria
        myStr = CType(0, String)
        linea += myStr.PadLeft(8, "0"c)
        '60 monto ahorro voluntario
        myStr = CType(0, String)
        linea += myStr.PadLeft(8, "0"c)
        '61 numero periodos de cotizacion
        linea += "00"
        Return linea
    End Function

    Private Function datosIpsFonasaPrevired(ByVal registro As Data.DataRow, ByVal valorUFMesActual As Decimal, ByVal valorUfMesAnterior As Decimal, ByVal topeImponible As Decimal, ByVal esLineaBase As Boolean) As Object
        Dim myStr As String = ""
        Dim linea As String = ""

        If esLineaBase Then
            '62 codigo ex-caja
            If registro("REGIMEN_PREVISIONAL_AFP") = "INP" Then
                linea += registro("CODIGO_EXCAJA")
            Else
                linea += Format(registro("CODIGO_EXCAJA"), "0000")
            End If
            '63 tasa cotizacion ex-caja
            If registro("REGIMEN_PREVISIONAL_AFP") = "INP" Then
                linea += Format(registro("TASA_EX_CAJA"), "00.00")
            Else
                linea += "00.00"
            End If
            '64 renta imponible
            If registro("REGIMEN_PREVISIONAL_AFP") = "INP" Then
                Dim imponible As Integer = Math.Round(topeImponible * valorUFMesActual, 0)
                If registro("IMPONIBLE") = imponible Then
                    myStr = CType(Math.Round(topeImponible * valorUfMesAnterior, 0), String)
                Else
                    myStr = CType(registro("IMPONIBLE"), String)
                End If
                linea += myStr.PadLeft(8, "0"c)
            Else
                If registro("REGIMEN_PREVISIONAL_AFP") = "AFP" And registro("REGIMEN_PREVISIONAL_SALUD") = "FON" Then
                    myStr = CType(registro("IMPONIBLE"), String)
                Else
                    myStr = CType(0, String)
                End If
                linea += myStr.PadLeft(8, "0"c)
            End If
            '65 cotizacion obligatoria
            If registro("REGIMEN_PREVISIONAL_AFP") = "INP" Then
                myStr = CType(registro("COTIZACION_OBLIGATORIA_INP"), String)
                linea += myStr.PadLeft(8, "0"c)
            Else
                myStr = CType(0, String)
                linea += myStr.PadLeft(8, "0"c)
            End If
            '66 renta imponible desahucio
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
            '67 codigo ex-caja desahucio
            myStr = ""
            linea += myStr.PadLeft(4, "0"c)
            '68 tasa cotizacion desahucio
            linea += "00.00"
            '69 cotizacion desahucio
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
            '70 cotizacion fonasa
            Dim totalPagadoINP As Integer = 0
            If registro("REGIMEN_PREVISIONAL_AFP") = "INP" And registro("REGIMEN_PREVISIONAL_SALUD") = "FON" Then
                'totalPagadoINP = registro("COTIZACION_FONASA_INP") + registro("COTIZACION_OBLIGATORIA_INP")
                myStr = CType(registro("COTIZACION_FONASA_INP"), String)
                linea += myStr.PadLeft(8, "0"c)
            Else
                If registro("REGIMEN_PREVISIONAL_AFP") = "AFP" And registro("REGIMEN_PREVISIONAL_SALUD") = "FON" Then
                    myStr = CType(registro("COTIZACION_FONASA_INP"), String)
                    linea += myStr.PadLeft(8, "0"c)
                Else
                    myStr = ""
                    linea += myStr.PadLeft(8, "0"c)
                End If
            End If
            '71
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
            '72
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
            '73
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
            '74
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
        Else
            '62 codigo ex-caja
            linea += "0000"
            '63 tasa cotizacion ex-caja
            linea += "00.00"
            '64 renta imponible
            myStr = CType(0, String)
            linea += myStr.PadLeft(8, "0"c)
            '65 cotizacion obligatoria
            myStr = CType(0, String)
            linea += myStr.PadLeft(8, "0"c)
            '66 renta imponible desahucio
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
            '67 codigo ex-caja desahucio
            myStr = ""
            linea += myStr.PadLeft(4, "0"c)
            '68 tasa cotizacion desahucio
            linea += "00.00"
            '69 cotizacion desahucio
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
            '70 cotizacion fonasa
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
            '71
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
            '72
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
            '73
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
            '74
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
        End If
        Return linea
    End Function

    Private Function datosIsaprePrevired(ByVal registro As Data.DataRow, ByVal esLineaBase As Boolean) As Object
        Dim myStr As String = ""
        Dim linea As String = ""

        If esLineaBase Then

            '75 codigo isapre
            myStr = CType(registro("CODIGO_ISAPRE"), String)
            linea += myStr.PadLeft(2, "0"c)
            '76 numero fun
            linea += Space(16)
            '77 monto imponible
            If registro("REGIMEN_PREVISIONAL_SALUD") = "ISA" Then
                myStr = CType(registro("IMPONIBLE"), String)
                linea += myStr.PadLeft(8, "0"c)
            Else
                myStr = CType(0, String)
                linea += myStr.PadLeft(8, "0"c)
            End If
            '78 moneda plan pactado
            Dim tipoMoneda As Integer
            If registro("REGIMEN_PREVISIONAL_SALUD") = "FON" Then
                tipoMoneda = 1
            Else
                If registro("MONEDA_MONTO_ISAPRE_ID") = 1 Or registro("MONEDA_MONTO_ISAPRE_ID") = 2 Then
                    tipoMoneda = registro("MONEDA_MONTO_ISAPRE_ID")
                Else
                    tipoMoneda = 1
                End If
            End If
            myStr = CType(tipoMoneda, String)
            linea += myStr.PadLeft(1, "0"c)
            '79 cotizacion pactada
            Dim cotizPactadaPesos As Integer
            Dim cotizPactadaUF As Double
            If registro("REGIMEN_PREVISIONAL_SALUD") = "ISA" Then
                If registro("MONEDA_MONTO_ISAPRE_ID") = 1 Then
                    cotizPactadaPesos = registro("MONTO_ISAPRE") + registro("MONTO_PLAN_AUGE")
                    myStr = Format(cotizPactadaPesos, "00000000")
                Else
                    If registro("MONEDA_MONTO_ISAPRE_ID") = 2 Then
                        cotizPactadaUF = registro("MONTO_ISAPRE") + registro("MONTO_PLAN_AUGE")
                        Dim valorStr As String
                        valorStr = Format(cotizPactadaUF, "000.0000")
                        Mid(valorStr, 4, 1) = ","
                        myStr = valorStr
                    Else
                        myStr = "00000000"
                    End If
                End If
            Else
                myStr = "00000000"
            End If
            linea += myStr
            '80 cotizacion obligatoria
            If registro("REGIMEN_PREVISIONAL_SALUD") = "ISA" Then
                myStr = CType(registro("COT_LEGAL_SALUD"), String)
                linea += myStr.PadLeft(8, "0"c)
            Else
                If registro("REGIMEN_PREVISIONAL_SALUD") = "XXX" Then 'antes era "FON"
                    myStr = CType(registro("COTIZACION_FONASA_INP"), String)
                    linea += myStr.PadLeft(8, "0"c)
                Else
                    myStr = ""
                    linea += myStr.PadLeft(8, "0"c)
                End If
            End If
            '81 cotizacion adicional voluntaria
            If registro("REGIMEN_PREVISIONAL_SALUD") = "ISA" Then
                myStr = CType(registro("COT_ADICIONAL_VOLUNTARIO_SALUD"), String)
                linea += myStr.PadLeft(8, "0"c)
            Else
                myStr = ""
                linea += myStr.PadLeft(8, "0"c)
            End If
            'If registro("REGIMEN_PREVISIONAL_SALUD") = "ISA" And CType(registro("CODIGO_ISAPRE"), String) <> "18" Then
            '    myStr = CType(registro("COT_PLAN_COMPLEMENTARIO_SALUD"), String)
            '    linea += myStr.PadLeft(8, "0"c)
            'Else
            '    myStr = ""
            '    linea += myStr.PadLeft(8, "0"c)
            'End If
            '82 monto GES
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
        Else
            '75 codigo isapre
            myStr = CType(0, String)
            linea += myStr.PadLeft(2, "0"c)
            '76 numero fun
            linea += Space(16)
            '77 monto imponible
            myStr = CType(0, String)
            linea += myStr.PadLeft(8, "0"c)
            '78 moneda plan pactado
            myStr = CType(0, String)
            linea += myStr.PadLeft(1, "0"c)
            '79 cotizacion pactada
            myStr = "00000000"
            linea += myStr
            '80 cotizacion obligatoria
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
            '81 cotizacion adicional voluntaria
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
            '82 monto GES
            myStr = ""
            linea += myStr.PadLeft(8, "0"c)
        End If
        Return linea
    End Function

    Private Function datosCCAFPrevired() As Object
        Dim myStr As String = ""
        Dim linea As String = ""

        '83 codigo ccaf
        myStr = ""
        linea += myStr.PadLeft(2, "0"c)
        '84 monto imponible
        myStr = ""
        linea += myStr.PadLeft(8, "0"c)
        '85 creditos personales
        myStr = ""
        linea += myStr.PadLeft(8, "0"c)
        '86 descuento dental ccaf
        myStr = ""
        linea += myStr.PadLeft(8, "0"c)
        '87 descuento por leasing
        myStr = ""
        linea += myStr.PadLeft(8, "0"c)
        '88 descuento seguro vida
        myStr = ""
        linea += myStr.PadLeft(8, "0"c)
        '89 otros descuentos ccaf
        myStr = ""
        linea += myStr.PadLeft(8, "0"c)
        '90 cotizacion ccaf no afiliados a isapre
        myStr = ""
        linea += myStr.PadLeft(8, "0"c)
        '91 descuento cargas familiares ccaf
        myStr = ""
        linea += myStr.PadLeft(8, "0"c)
        '92 otros descuentos ccaf 1
        myStr = ""
        linea += myStr.PadLeft(8, "0"c)
        '93 otros descuentos ccaf 2
        myStr = ""
        linea += myStr.PadLeft(8, "0"c)
        '94 bonos gobierno
        myStr = ""
        linea += myStr.PadLeft(8, "0"c)
        '95 codigo sucursal
        myStr = ""
        linea += Space(20)
        Return linea
    End Function

    Private Function datosMutualPrevired(ByVal registro As Data.DataRow, ByVal esLineaBase As Boolean) As Object
        Dim myStr As String = ""
        Dim linea As String = ""

        If esLineaBase Then
            '96 codigo previred
            myStr = registro("CODIGO_PREVIRED_INSTITUCION_SEGURIDAD")
            linea += myStr.PadLeft(2, "0"c)
            '97 monto imponible
            myStr = CType(registro("IMPONIBLE"), String)
            linea += myStr.PadLeft(8, "0"c)
            '98 monto cotizacion
            myStr = registro("MONTO_COTIZACION_MUTUAL")
            linea += myStr.PadLeft(8, "0"c)
            '99 sucursal pago
            myStr = ""
            linea += myStr.PadLeft(3, "0"c)
        Else
            '96 codigo previred
            linea += "00"
            '97 monto imponible
            myStr = CType(0, String)
            linea += myStr.PadLeft(8, "0"c)
            '98 monto cotizacion
            myStr = CType(0, String)
            linea += myStr.PadLeft(8, "0"c)
            '99 sucursal pago
            myStr = ""
            linea += myStr.PadLeft(3, "0"c)
        End If
        Return linea
    End Function

    Private Function datosSeguroCesantia() As Object
        Dim myStr As String = ""
        Dim linea As String = ""

        '100 renta imponible
        myStr = ""
        linea += myStr.PadLeft(8, "0"c)
        '101 aporte trabajador
        myStr = ""
        linea += myStr.PadLeft(8, "0"c)
        '102 aporte empleador
        myStr = ""
        linea += myStr.PadLeft(8, "0"c)
        Return linea
    End Function

    Private Function datosPagadorSubsidioPrevired() As Object
        Dim myStr As String = ""
        Dim linea As String = ""

        '103 rut pagadora subsidio
        myStr = ""
        linea += myStr.PadLeft(11, "0"c)
        '104 digito verificador pagadora
        linea += " "
        Return linea
    End Function

    Private Function datosOtrosDatosEmpresa() As Object
        Dim linea As String = ""

        linea = Space(20)
        Return linea
    End Function
    Public Function generaPorcentajesEmpleadoBonoModernizacion(ByVal annoActual As Integer, ByVal porcentajeBase As Decimal, ByVal porcentajeInstitucional As Decimal, ByVal porcentajeColectivo As Decimal) As Boolean
        Try
            'Elimina los bonos de modernizacion del año
            EjecutaSQL("DELETE FROM " & Tablas.RH_REM_BONO_MODERNIZACION & " WHERE ANO=" & annoActual)

            Dim queryVistaBono As String = "SELECT * FROM " & Vistas.VW_MAESTRO_EMPLEADO & _
                                                   " WHERE ESTADO_EMPLEADO_ID = 1 " & _
                                                   " AND INCLUYE_CALCULO_SUELDO = 1" & _
                                                   " ORDER BY APELLIDO_PATERNO, APELLIDO_MATERNO"
            Dim SQL As String
            Dim base As Decimal = 0
            Dim institucional As Decimal = 0
            Dim colectivo As Decimal = 0
            Dim difDias As Integer = 0
            Dim diasAnual As Integer = 365
            Dim anno As Integer = (annoActual - 1)

            Dim dset As New DataSet
            Dim dtBono As DataTable
            Dim da As New SqlDataAdapter(queryVistaBono, conn.ConnectionString)
            da.Fill(dset, queryVistaBono)
            dtBono = dset.Tables(queryVistaBono)

            Dim registro As Data.DataRow
            Dim fechaInicio1 As Date = CType("01-01-" + CType(anno, String), Date)
            Dim fechaInicio2 As Date = CType("02-12-" + CType(anno, String), Date)
            Dim fechaFinal As Date = CType("31-12-" + CType(anno, String), Date)

            For Each registro In dtBono.Rows
                'If registro("EMPLEADO_ID") = 1 Then 'Or registro("EMPLEADO_ID") = 627 Then
                '    Dim a As Integer
                '    a = 1
                'End If
                If registro("FECHA_ING_INSTITUCION") > fechaInicio2 Then
                    colectivo = 0
                Else
                    If registro("FECHA_ING_INSTITUCION") >= fechaInicio1 Then
                        difDias = DateDiff(DateInterval.Day, registro("FECHA_ING_INSTITUCION"), fechaFinal) + 1
                        If difDias >= 365 Then
                            colectivo = porcentajeColectivo
                        Else
                            colectivo = (difDias / diasAnual) * porcentajeColectivo
                        End If

                    Else
                        'Busca si el empleado tiene permiso sin goce sueldo
                        SQL = "SELECT ISNULL(SUM(DIAS),0) AS DIAS FROM " & Vistas.VW_EVENTOS_ADMINISTRATIVOS_DETALLE & _
                              " WHERE TIPO_EVENTO_ADMIN_ID = " & CType(Comun.TiposDeDatos.TipoEventoAdmin.PERMISO_SIN_GOCE_SUELDO, Integer) & _
                              " AND EMPLEADO_ID=" & registro("EMPLEADO_ID") & _
                              " AND ANO=" & anno
                        difDias = Busca(SQL)

                        If difDias > 0 Then
                            colectivo = ((diasAnual - difDias) / diasAnual) * porcentajeColectivo
                            difDias = diasAnual - difDias
                        Else
                            colectivo = porcentajeColectivo
                        End If
                    End If
                End If
                base = porcentajeBase
                institucional = porcentajeInstitucional
                Dim totalPorcentajeBono As Integer = base + institucional + colectivo
                actualizaDatosBonoModernizacion(registro("EMPLEADO_ID"), annoActual, difDias, base, institucional, colectivo, registro("FECHA_ING_INSTITUCION"))
                'Debug.WriteLine("ID Empleado = " & CType(registro("EMPLEADO_ID"), String))

            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
        Return True
    End Function
    Public Function generaEmpleadoPorcentajesBonoModernizacion(ByVal idEmpleado As Integer, ByVal annoActual As Integer, ByVal porcentajeBase As Decimal, ByVal porcentajeInstitucional As Decimal, ByVal porcentajeColectivo As Decimal, ByRef rtnDias As Integer, ByRef rtnBase As Decimal, ByRef rtnInstitucional As Decimal, ByRef rtnColectivo As Decimal) As Boolean

        Try
            'Elimina los bonos de modernizacion del empleado y año
            EjecutaSQL("DELETE FROM " & Tablas.RH_REM_BONO_MODERNIZACION & " WHERE ANO=" & annoActual & " AND EMPLEADO_ID=" & idEmpleado)

            Dim queryVistaBono As String = "SELECT * FROM " & Vistas.VW_MAESTRO_EMPLEADO & _
                                                   " WHERE ESTADO_EMPLEADO_ID = 1 " & _
                                                   " AND INCLUYE_CALCULO_SUELDO = 1" & _
                                                   " AND EMPLEADO_ID = " & idEmpleado & _
                                                   " ORDER BY APELLIDO_PATERNO, APELLIDO_MATERNO"
            Dim SQL As String
            Dim base As Decimal = 0
            Dim institucional As Decimal = 0
            Dim colectivo As Decimal = 0
            Dim difDias As Integer = 0
            Dim diasAnual As Integer = 365
            Dim anno As Integer = (annoActual - 1)

            Dim dset As New DataSet
            Dim dtBono As DataTable
            Dim da As New SqlDataAdapter(queryVistaBono, conn.ConnectionString)
            da.Fill(dset, queryVistaBono)
            dtBono = dset.Tables(queryVistaBono)

            Dim registro As Data.DataRow
            Dim fechaInicio1 As Date = CType("01-01-" + CType(anno, String), Date)
            Dim fechaInicio2 As Date = CType("02-12-" + CType(anno, String), Date)
            Dim fechaFinal As Date = CType("31-12-" + CType(anno, String), Date)

            For Each registro In dtBono.Rows
                If registro("FECHA_ING_INSTITUCION") > fechaInicio2 Then
                    colectivo = 0
                Else
                    If registro("FECHA_ING_INSTITUCION") >= fechaInicio1 Then
                        difDias = DateDiff(DateInterval.Day, registro("FECHA_ING_INSTITUCION"), fechaFinal) + 1
                        colectivo = (difDias / diasAnual) * porcentajeColectivo
                    Else
                        SQL = "SELECT ISNULL(SUM(DIAS),0) AS DIAS FROM " & Vistas.VW_EVENTOS_ADMINISTRATIVOS_DETALLE & _
                              " WHERE TIPO_EVENTO_ADMIN_ID = 4 " & _
                              " AND EMPLEADO_ID=" & registro("EMPLEADO_ID") & _
                              " AND ANO=" & anno
                        difDias = Busca(SQL)
                        If difDias > 0 Then
                            colectivo = ((diasAnual - difDias) / diasAnual) * porcentajeColectivo
                            difDias = diasAnual - difDias
                        Else
                            colectivo = porcentajeColectivo
                        End If
                    End If
                End If
                base = porcentajeBase
                institucional = porcentajeInstitucional
                Dim totalPorcentajeBono As Integer = base + institucional + colectivo
                'actualizaDatosBonoModernizacion(registro("EMPLEADO_ID"), annoActual, difDias, base, institucional, colectivo, registro("FECHA_ING_INSTITUCION"))
                rtnDias = difDias
                rtnBase = base
                rtnInstitucional = institucional
                rtnColectivo = colectivo
                Return True
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Private Function actualizaDatosBonoModernizacion(ByVal idEmpleado As Integer, ByVal anno As Integer, _
                                                     ByVal dias As Integer, ByVal baseBono As Decimal, _
                                                     ByVal institucionalBono As Decimal, ByVal colectivoBono As Decimal, _
                                                     ByVal fechaIngInstitucion As Date) As Object
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        Try
            cmd = New SqlClient.SqlCommand("INSERT INTO RH_REM_BONO_MODERNIZACION (EMPLEADO_ID, ANO, DIAS, BASE_BONO, INSTITUCIONAL, COLECTIVO, FECHA_ING_INSTITUCION, TOTAL) values (@EMPLEADO_ID, @ANO, @DIAS, @BASE_BONO, @INSTITUCIONAL, @COLECTIVO, @FECHA_ING_INSTITUCION, @TOTAL); SELECT @@IDENTITY")
            cmd.Connection = conn

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@EMPLEADO_ID"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.Int
            prm.Value = idEmpleado
            cmd.Parameters.Add(prm)

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@ANO"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.Int
            prm.Value = anno
            cmd.Parameters.Add(prm)

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@DIAS"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.SmallInt
            prm.Value = dias
            cmd.Parameters.Add(prm)

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@BASE_BONO"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.Decimal
            prm.Value = baseBono
            cmd.Parameters.Add(prm)

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@INSTITUCIONAL"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.Decimal
            prm.Value = institucionalBono
            cmd.Parameters.Add(prm)

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@COLECTIVO"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.Decimal
            prm.Value = colectivoBono
            cmd.Parameters.Add(prm)

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@FECHA_ING_INSTITUCION"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.DateTime
            prm.Value = fechaIngInstitucion
            cmd.Parameters.Add(prm)

            prm = New SqlClient.SqlParameter
            prm.ParameterName = "@TOTAL"
            prm.Direction = ParameterDirection.Input
            prm.SqlDbType = SqlDbType.Decimal
            prm.Value = baseBono + institucionalBono + colectivoBono
            cmd.Parameters.Add(prm)

            cmd.ExecuteScalar()
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            conn.Close()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function

    Public Function generarHorasAtraso(ByVal fechaInicio As Date, fechaFinal As Date) As DataTable
        Try
            Dim conn As SqlClient.SqlConnection
            conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
            conn.Open()

            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("sp_generaAtrasoPorRangoFecha", conn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@FECHA_INICIO", SqlDbType.DateTime)
            da.SelectCommand.Parameters("@FECHA_INICIO").Value = fechaInicio
            da.SelectCommand.Parameters.Add("@FECHA_FINAL", SqlDbType.DateTime)
            da.SelectCommand.Parameters("@FECHA_FINAL").Value = fechaFinal
            da.SelectCommand.ExecuteNonQuery()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return Nothing
        Finally
            conn.Close()
            conn = Nothing
        End Try
    End Function

    Public Function generarHorasExtrasNoRatificadas(ByVal fechaInicio As Date, fechaFinal As Date) As DataTable
        Try
            Dim conn As SqlClient.SqlConnection
            conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
            conn.Open()

            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("sp_generaHorasExtasNoRatificadas", conn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@FECHA_INICIO", SqlDbType.DateTime)
            da.SelectCommand.Parameters("@FECHA_INICIO").Value = fechaInicio
            da.SelectCommand.Parameters.Add("@FECHA_FINAL", SqlDbType.DateTime)
            da.SelectCommand.Parameters("@FECHA_FINAL").Value = fechaFinal
            da.SelectCommand.ExecuteNonQuery()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return Nothing
        Finally
            conn.Close()
            conn = Nothing
        End Try
    End Function

    'Public Function generaItemsBonoModernizacion(ByVal idEmpleado As Integer, ByVal idPeriodoActual As Integer, _
    '                                        ByVal IDitemBonoDesempeno As Integer, ByVal IDitemBonoLey19553Art8 As Integer, _
    '                                        ByVal IDafp As Integer, ByVal IDisapre As Integer, _
    '                                        ByVal porcentajeBase As Decimal, ByVal porcentajeInstitucional As Decimal, _
    '                                        ByVal porcentajeColectivo As Decimal, ByVal totalPorcentajeBono As Decimal, _
    '                                        ByVal topeImponible As Decimal, ByVal UF As Decimal, ByVal itemTotalImponible As Integer, _
    '                                        ByVal estadoPeriodo As Boolean, ByVal idPeriodoProceso As Integer, _
    '                                        ByVal idItemBonoDistBase As Integer, ByVal idItemBonoDistInstitucional As Integer, _
    '                                        ByVal idItembonoDistColectivo As Integer, _
    '                                        ByRef montoDistribuidoBase As Decimal, _
    '                                        ByRef montoDistribuidoInstitucional As Decimal, _
    '                                        ByRef montoDistribuidoColectivo As Decimal, _
    '                                        ByVal UFMesAnterior As Decimal, _
    '                                        ByVal tipoProceso As String, _
    '                                        ByVal tipoProcesoRemuneracionActual As String, _
    '                                        ByVal porcentajeLey19863 As Integer, _
    '                                        ByVal IDItemLey19863 As Integer) As Boolean

    Public Function generaItemsBonoModernizacion(ByVal idEmpleado As Integer, ByVal idPeriodoActual As Integer, _
                                            ByVal IDitemBonoDesempeno As Integer,
                                            ByVal IDitemBonoLey19553Art8 As Integer, _
                                            ByVal porcentajeBase As Decimal, _
                                            ByVal porcentajeInstitucional As Decimal, _
                                            ByVal porcentajeColectivo As Decimal, _
                                            ByVal topeImponible As Decimal, _
                                            ByVal UF As Decimal, ByVal itemTotalImponible As Integer, _
                                            ByVal idPeriodoProceso As Integer, _
                                            ByRef montoDistribuidoBase As Decimal, _
                                            ByRef montoDistribuidoInstitucional As Decimal, _
                                            ByRef montoDistribuidoColectivo As Decimal, _
                                            ByVal UFMesAnterior As Decimal, _
                                            ByVal tipoProceso As String, _
                                            ByVal tipoProcesoRemuneracionActual As String, _
                                            ByVal porcentajeLey19863 As Integer, _
                                            ByVal IDItemLey19863 As Integer,
                                            ByVal generaItemBase As Boolean, _
                                            ByRef montoBonoDesempeno As Integer, _
                                            ByRef montoBonoLey19553Art8 As Integer, _
                                            ByVal aplicaCalculoZonaExtrema As Boolean, _
                                            ByRef MontoZonaExtrema40 As Integer, _
                                            ByRef MontoZonaExtrema60 As Integer, _
                                            ByRef MontoBonoZonaExtrema As Integer) As Boolean

        Dim sql As String
        Dim sistemaPrevisional As String = ""
        Dim totalBase As Integer = 0
        Dim imponible As Integer = 0
        Dim tasaDesctoLey19882 As Decimal = 0
        Dim monto As Integer
        Dim origen As Integer = Comun.TiposDeDatos.TipoOrigenItem.BONO_MODERNIZACION
        Dim cmdHistorico, cmdImponible As String


        Try
            'Instrucción SQL para buscar itemes afectos a bono modernizacion
            If idPeriodoActual = idPeriodoProceso Then
                cmdHistorico = " AND TIPO_PROCESO=" + "'" + tipoProcesoRemuneracionActual + "'"
                cmdImponible = " AND TIPO_CALCULO=" + "'" + tipoProcesoRemuneracionActual + "'"
            Else
                cmdHistorico = " AND TIPO_PROCESO=" + "'" + Comun.TipoProceso.NORNAL_PLANTA_CONTRATA + "'"
                cmdImponible = " AND TIPO_CALCULO=" + "'" + Comun.TipoProceso.NORNAL_PLANTA_CONTRATA + "'"
            End If
            sql = "SELECT ISNULL(SUM(CANTIDAD),0) AS CANTIDAD" & _
                  " FROM VW_BONOS_ITEMES_HISTORICOS" & _
                  " WHERE EMPLEADO_ID=" & idEmpleado & _
                  " AND PERIODO_ID=" & idPeriodoProceso & cmdHistorico
            totalBase = Busca(sql)

            Dim diferencia As Integer = 0
            If totalBase > 0 Then
                'Selecciona desda tabla afp tasa descuento ley 19.882
                sql = "SELECT VW_TABLA_AFP.DESCUENTO_LEY_19882" & _
                      " FROM RH_PER_ANTECEDENTE_PREVIS INNER JOIN" & _
                      " VW_TABLA_AFP ON RH_PER_ANTECEDENTE_PREVIS.AFP_ID = VW_TABLA_AFP.AFP_ID" & _
                      " WHERE RH_PER_ANTECEDENTE_PREVIS.ESTADO_REGISTRO = 1 AND RH_PER_ANTECEDENTE_PREVIS.EMPLEADO_ID = " & idEmpleado
                tasaDesctoLey19882 = BuscaDecimal(sql)

                'Selecciona tipo sistema previsional
                sql = "SELECT VW_TABLA_AFP.SISTEMA_PREV_ALIAS" & _
                      " FROM RH_PER_ANTECEDENTE_PREVIS INNER JOIN" & _
                      " VW_TABLA_AFP ON RH_PER_ANTECEDENTE_PREVIS.AFP_ID = VW_TABLA_AFP.AFP_ID" & _
                      " WHERE RH_PER_ANTECEDENTE_PREVIS.ESTADO_REGISTRO = 1 AND RH_PER_ANTECEDENTE_PREVIS.EMPLEADO_ID = " & idEmpleado
                sistemaPrevisional = BuscaString(sql)

                'Se buscan los haberes para calcular nuevo imponible
                sql = "SELECT ISNULL(MONTO,0) AS IMPONIBLE" & _
                      " FROM VW_LIQUIDACIONES" & _
                      " WHERE EMPLEADO_ID=" & idEmpleado & _
                      " AND PERIODO_ID=" & idPeriodoProceso & _
                      " AND ITEM_ID=" & itemTotalImponible & cmdImponible
                imponible = Busca(sql)

                If sistemaPrevisional = "INP" Then
                    UF = UFMesAnterior
                End If

                'Distribuye asignacion desempeño según porcentaje colectivo
                If porcentajeColectivo > 0 Then
                    montoDistribuidoColectivo = Math.Round(totalBase * (porcentajeColectivo / 100), 0)
                End If

                'Distribuye asignacion desempeño según porcentaje institucional
                If porcentajeInstitucional > 0 Then
                    montoDistribuidoInstitucional = Math.Round(totalBase * (porcentajeInstitucional / 100), 0)
                End If

                'Distribuye asignacion desempeño según porcentaje base
                If porcentajeBase > 0 Then
                    montoDistribuidoBase = Math.Round(totalBase * (porcentajeBase / 100), 0)
                End If

                'Crea asignación desempeño
                monto = montoDistribuidoBase + montoDistribuidoInstitucional + montoDistribuidoColectivo
                If generaItemBase = False Then
                    InsertaEmpleadoMovimientoMensual(idPeriodoActual, IDitemBonoDesempeno, idEmpleado, 0, 0, origen, monto, tipoProceso)
                Else
                    montoBonoDesempeno = monto
                End If


                'Crea asignación ley 19.863. Solo afecta a los empleados que tengan ingresado un valor mayor a cero
                'en la ficha del empleado en el campo Porcentaje Ley 19.863
                If porcentajeLey19863 > 0 Then
                    Dim montoLey19863 As Integer = Math.Round(monto * (porcentajeLey19863 / 100), 0)
                    If generaItemBase = False Then
                        InsertaEmpleadoMovimientoMensual(idPeriodoActual, IDItemLey19863, idEmpleado, 0, 0, origen, montoLey19863, tipoProceso)
                    End If
                End If

                'Calcula si existe diferencia entre imponible mas bono desempeño y el tope imponible del mes
                If (monto + imponible) > Math.Round((topeImponible * UF), 0) Then
                    diferencia = Math.Round((topeImponible * UF), 0) - imponible
                Else
                    If (monto + imponible) < Math.Round((topeImponible * UF), 0) Then
                        diferencia = monto
                    Else
                        diferencia = 0
                    End If
                End If

            End If
            If diferencia > 0 Then
                monto = Math.Round(diferencia * (tasaDesctoLey19882 / 100), 0)
                If monto > 0 Then
                    If generaItemBase = False Then
                        InsertaEmpleadoMovimientoMensual(idPeriodoActual, IDitemBonoLey19553Art8, idEmpleado, 0, 0, origen, monto, tipoProceso)
                    Else
                        montoBonoLey19553Art8 = monto
                    End If
                End If
            End If

            If aplicaCalculoZonaExtrema = True Then

                'Selecciona dias trabajados
                sql = "SELECT DIAS_TRABAJADOS " & _
                      "FROM RH_REM_LIQUIDACION_ENC " & _
                      "WHERE (EMPLEADO_ID = " & idEmpleado.ToString & ") " & _
                      "And (PERIODO_ID = " & idPeriodoProceso.ToString & ")"
                Dim diasTrabajados As Integer = Busca(sql)

                'Selecciona monto zona extrema
                sql = "SELECT RH_REM_ZONA_PERIODO.MONTO_TRIMESTRAL FROM RH_REM_ZONA INNER JOIN " & _
                      "RH_REM_ZONA_PERIODO ON RH_REM_ZONA.ZONA_ID = RH_REM_ZONA_PERIODO.ZONA_ID INNER JOIN " & _
                      "RH_PER_ANTECEDENTE_REMUN ON RH_REM_ZONA.ZONA_ID = RH_PER_ANTECEDENTE_REMUN.ZONA_ID " & _
                      "WHERE (RH_PER_ANTECEDENTE_REMUN.EMPLEADO_ID = " & idEmpleado.ToString & ") " & _
                      "And (RH_PER_ANTECEDENTE_REMUN.PERIODO_ID = " & idPeriodoProceso.ToString & ") " & _
                      "And (RH_PER_ANTECEDENTE_REMUN.ESTADO_REGISTRO = 1 Or RH_PER_ANTECEDENTE_REMUN.ESTADO_REGISTRO = 5)"
                Dim MontoTotalZonaExtrema As Integer = Busca(sql)


                'Selecciona tasa descuento de la afp
                'TASA_SEGURO_INVALIDEZ_SOBREVIVENCIA
                If sistemaPrevisional = "INP" Then
                    sql = "SELECT VW_TABLA_AFP.TASA_DESCUENTO" & _
                                         " FROM RH_PER_ANTECEDENTE_PREVIS INNER JOIN" & _
                                         " VW_TABLA_AFP ON RH_PER_ANTECEDENTE_PREVIS.AFP_ID = VW_TABLA_AFP.AFP_ID" & _
                                         " WHERE RH_PER_ANTECEDENTE_PREVIS.ESTADO_REGISTRO = 1 AND RH_PER_ANTECEDENTE_PREVIS.EMPLEADO_ID = " & idEmpleado
                Else
                    sql = "SELECT VW_TABLA_AFP.TASA_SEGURO_INVALIDEZ_SOBREVIVENCIA" & _
                                         " FROM RH_PER_ANTECEDENTE_PREVIS INNER JOIN" & _
                                         " VW_TABLA_AFP ON RH_PER_ANTECEDENTE_PREVIS.AFP_ID = VW_TABLA_AFP.AFP_ID" & _
                                         " WHERE RH_PER_ANTECEDENTE_PREVIS.ESTADO_REGISTRO = 1 AND RH_PER_ANTECEDENTE_PREVIS.EMPLEADO_ID = " & idEmpleado
                End If
                Dim tasaDesctoAFP As Decimal = BuscaDecimal(sql)


                Dim PorcentajeZonaExtrema As Decimal = BuscaDecimal("SELECT PORCENTAJE_ZONA_EXTREMA_NO_IMPONIBLE FROM RH_REM_PERIODO WHERE PERIODO_ID =" & idPeriodoProceso.ToString)
                Dim PorcentajeBonoZonaExtrema As Decimal = BuscaDecimal("SELECT PORCENTAJE_BONO_ZONA_EXTREMA FROM RH_REM_PERIODO WHERE PERIODO_ID =" & idPeriodoProceso.ToString)
                Dim ItemZonaExtremaImponible As Decimal = Busca("SELECT ITEM_ZONA_EXTREMA_IMPONIBLE FROM RH_REM_PERIODO WHERE PERIODO_ID =" & idPeriodoProceso.ToString)
                Dim ItemZonaExtremaNoImponible As Decimal = Busca("SELECT ITEM_ZONA_EXTREMA_NO_IMPONIBLE FROM RH_REM_PERIODO WHERE PERIODO_ID =" & idPeriodoProceso.ToString)
                Dim ItemBonificacionZonaExtremaImponible As Decimal = Busca("SELECT ITEM_BONIFICACION_ZONA_EXTREMA_IMPONIBLE FROM RH_REM_PERIODO WHERE PERIODO_ID =" & idPeriodoProceso.ToString)

                If MontoTotalZonaExtrema > 0 And diasTrabajados > 0 Then
                    Dim MontoMensualZonaExtrema As Integer = Math.Round((MontoTotalZonaExtrema / 90) * diasTrabajados, 0)
                    MontoZonaExtrema40 = MontoMensualZonaExtrema * ((100 - PorcentajeZonaExtrema) / 100)
                    MontoZonaExtrema60 = MontoMensualZonaExtrema - MontoZonaExtrema40
                    MontoBonoZonaExtrema = 0

                    If (MontoZonaExtrema40 + imponible) < Math.Round((topeImponible * UF), 0) Then
                        MontoBonoZonaExtrema = Math.Round(MontoZonaExtrema40 * ((PorcentajeBonoZonaExtrema + tasaDesctoAFP) / 100), 0)
                    End If

                    If generaItemBase = False Then
                        If MontoZonaExtrema40 > 0 Then
                            InsertaEmpleadoMovimientoMensual(idPeriodoActual, ItemZonaExtremaImponible, idEmpleado, 0, 0, origen, MontoZonaExtrema40, tipoProceso)
                        End If
                        If MontoZonaExtrema60 > 0 Then
                            InsertaEmpleadoMovimientoMensual(idPeriodoActual, ItemZonaExtremaNoImponible, idEmpleado, 0, 0, origen, MontoZonaExtrema60, tipoProceso)
                        End If
                        If MontoBonoZonaExtrema > 0 Then
                            InsertaEmpleadoMovimientoMensual(idPeriodoActual, ItemBonificacionZonaExtremaImponible, idEmpleado, 0, 0, origen, MontoBonoZonaExtrema, tipoProceso)
                        End If
                    End If
                End If
            End If

            Return True
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function
    Public Function validaRangoFechaEventoAdministrativo(ByVal fechaInicio As Date, ByVal idEmpleado As Integer, ByVal cantidadDias As Integer) As String
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        Dim mensaje As String

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.VALIDA_RANGO_FECHA_VIATICO
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_INICIO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = fechaInicio
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idEmpleado
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@CANTIDAD_DIAS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = cantidadDias
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MENSAJE"
        prm.Direction = ParameterDirection.Output
        prm.Size = 200
        prm.SqlDbType = SqlDbType.VarChar
        cmd.Parameters.Add(prm)


        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            mensaje = cmd.Parameters("@MENSAJE").Value()
            Return mensaje
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return Nothing
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function
    Public Function insertaMarcaAssisCAD(ByVal idEmpleado As Integer, ByVal fechaMarca As Date, ByVal horaMarca As Date, ByVal valorRetorno As Integer) As Integer
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_MARCA_ASSISCAD
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idEmpleado
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MARC_FECHA"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = fechaMarca
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@HORA_MARCA"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = horaMarca
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@VALOR_RETORNO"
        prm.Direction = ParameterDirection.Output
        prm.Size = 200
        prm.SqlDbType = SqlDbType.Int
        cmd.Parameters.Add(prm)


        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            valorRetorno = cmd.Parameters("@VALOR_RETORNO").Value()
            Return valorRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return -1
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function
    Public Function actualizaMarcaAssisCAD(ByVal idAsistencia As Integer, ByVal procesaAsistencia As Integer, ByVal valorRetorno As Integer) As Integer
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.ACTUALIZA_MARCA_VIGENTE_ASISSCAD
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MARC_GENERADA_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idAsistencia
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MARC_PROCESA"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = procesaAsistencia
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@VALOR_RETORNO"
        prm.Direction = ParameterDirection.Output
        prm.Size = 200
        prm.SqlDbType = SqlDbType.Int
        cmd.Parameters.Add(prm)


        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            valorRetorno = cmd.Parameters("@VALOR_RETORNO").Value()
            Return valorRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return -1
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function

    Public Function verificaMarcaAssisCAD(ByVal empleadoID As Integer, ByVal horaMarca As Date, ByVal fechaMarca As Date, ByVal valorRetorno As Integer) As Integer
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.VERIFICA_MARCA_ASSISCAD
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = empleadoID
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@HORA_MARCA"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = horaMarca
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MARC_FECHA"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = fechaMarca
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@VALOR_RETORNO"
        prm.Direction = ParameterDirection.Output
        prm.Size = 200
        prm.SqlDbType = SqlDbType.Int
        cmd.Parameters.Add(prm)

        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            valorRetorno = cmd.Parameters("@VALOR_RETORNO").Value()
            Return valorRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return -1
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function
    Public Function traspasaMarcasControlAcceso(ByVal ano As Integer, ByVal mes As Integer) As Integer
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.TRASPASA_MARCAS_CONTROL_ACCESO
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 180

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ANO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = ano
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MES"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = mes
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@CANTIDAD_REGISTROS"
        prm.Direction = ParameterDirection.Output
        prm.Size = 200
        prm.SqlDbType = SqlDbType.Int
        cmd.Parameters.Add(prm)


        cmd.Connection = conn

        Try
            Dim valorRetorno As Integer
            cmd.ExecuteNonQuery()
            valorRetorno = cmd.Parameters("@CANTIDAD_REGISTROS").Value()
            Return valorRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return -1
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function
    Public Function traspasaControlAsistenciaIntranet(ByVal todosLosEmpleados As Integer, ByVal fechaInicio As Date, ByVal fechaFinal As Date, ByVal empleadoID As Integer) As Integer
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.TRASPASA_CONTROL_ASISTENCIA_INTRANET
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 3000

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TODOS_LOS_EMPLEADOS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = todosLosEmpleados
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_INICIO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = fechaInicio
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_FINAL"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = fechaFinal
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = empleadoID
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ERROR_PROCESO"
        prm.Direction = ParameterDirection.Output
        prm.Size = 200
        prm.SqlDbType = SqlDbType.Int
        cmd.Parameters.Add(prm)


        cmd.Connection = conn

        Try
            Dim valorRetorno As Integer
            cmd.ExecuteNonQuery()
            valorRetorno = cmd.Parameters("@ERROR_PROCESO").Value()
            Return valorRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return -1
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function
    Public Function generaMarcas(ByVal ano As Integer, ByVal mes As Integer, ByVal empleadoID As Integer) As Integer
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.GENERA_MARCAS_CONTROL_ACCESO
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 180

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ANO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = ano
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MES"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = mes
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.Value = empleadoID
        prm.SqlDbType = SqlDbType.Int
        cmd.Parameters.Add(prm)


        cmd.Connection = conn

        Try
            Dim valorRetorno As Integer = 0
            cmd.ExecuteNonQuery()
            'valorRetorno = cmd.Parameters("@CANTIDAD_REGISTROS").Value()
            Return valorRetorno
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return -1
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function

    Public Function generarResumenPagoHorasExtras(ByVal fechaInicio As Date, ByVal fechaFinal As Date, ByVal idEmpleado As Integer, ByVal tipoProceso As String) As String
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.GENERA_RESUMEN_HORAS_EXTRAS
        cmd.CommandType = CommandType.StoredProcedure

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_INICIAL"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = fechaInicio
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_FINAL"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = fechaFinal
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = idEmpleado
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_PROCESO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Precision = 1
        prm.Value = tipoProceso
        cmd.Parameters.Add(prm)

        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception("EMPLADO_ID = " + CStr(idEmpleado) + " " + ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function

    Public Function generarHorasExtrasPagadasVsRatificadas(ByVal PeriodoIdaProcesar As Integer, ByVal tipoCalculo As String) As String
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()


        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand

        cmd.CommandText = SQL.STORE_PROCEDURES.GENERA_HORAS_EXTRAS_PAGADAS_VS_RATIFICADAS
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 300

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID_A_PROCESAR"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = PeriodoIdaProcesar
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_CALCULO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Precision = 1
        prm.Value = tipoCalculo
        cmd.Parameters.Add(prm)

        cmd.Connection = conn

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function


    Private Function GetUpdateCmdDatosLaborales() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_EMPLEADO_DATOS_LABORALES

        sqlParam = New SqlClient.SqlParameter("@EMPLEADO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ESTADO_REGISTRO", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CALIDAD_JURIDICA_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ESTAMENTO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CLASIFICACION_EMPLEADO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@GRADO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@JEFE_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ESCALAFON_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@UBICACION_FISICA_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NUMERO_TARJETA_MAGNETICA", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@HORARIO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@TIPO_MOVIMIENTO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@RESOLUCION_CONTRATO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_ING_INSTITUCION", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_ING_ADMIN_PUBLICA", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_ING_CALIDAD_JURIDICA", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_ING_ESTAMENTO", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_ING_GRADO", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_ING_ESCALAFON", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_ING_DEPTO", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_RETIRO", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MOTIVO_RETIRO_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@OBSERVACIONES", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@DESCRIPCION_MOVIMIENTO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_MOVIMIENTO", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PUBLICA_WEB", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FUNCIONES_DESEMPENADAS", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@TITULO_PROFESIONAL_EXPERTIZ", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ESTADO_EMPLEADO_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PERIODO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PERIODO_ID_CAMBIO_SITUACION", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@DIAS_EN_GRADO", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@RESOLUCION_RETIRO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@TIPO_BENEFICIARIO_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NUMERO_ACCESO", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CARGO_ACTUAL", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@JEFE_EVALUADOR_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ASIGNA_EVALUACION_DESEMPENO", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@Identity", SqlDbType.BigInt, 0, "ANTECEDENTE_LABORAL_ID")
        sqlParam.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(sqlParam)

        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout
        Return (sqlCmd)

    End Function
    Private Function GetUpdateCmdDatosPrevisionales() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_EMPLEADO_DATOS_PREVISIONALES

        sqlParam = New SqlClient.SqlParameter("@EMPLEADO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ESTADO_REGISTRO", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_ING_SISTEMA_PREVIS", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@AFP_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_AFILIACION_AFP", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_AHORRO_AFP", SqlDbType.Decimal)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONEDA_AHORRO_AFP_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_COTIZACION_VOLUNTARIA_AFP", SqlDbType.Decimal)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONEDA_COTIZ_VOLUN_AFP_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ISAPRE_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_AFILIACION_ISAPRE", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_ISAPRE", SqlDbType.Decimal)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONEDA_MONTO_ISAPRE_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PLAN_COMPLEM_ISAPRE", SqlDbType.Decimal)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONEDA_PLAN_COMPLEM_ISAPRE_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@SALUD_PRAIS", SqlDbType.Char)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FONDO_A", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FONDO_B", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FONDO_C", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FONDO_D", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FONDO_E", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_PLAN_AUGE", SqlDbType.Decimal)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONEDA_PLAN_AUGE_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PERIODO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@TIPO_TRABAJADOR_PREVIRED_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ISAPRE_NRO_FUN", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ISAPRE_FECHA_FUN", SqlDbType.Date)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@AFP_NRO_FUN", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@AFP_FECHA_FUN", SqlDbType.Date)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@Identity", SqlDbType.BigInt, 0, "ANTECEDENTE_PREVIS_ID")
        sqlParam.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(sqlParam)

        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout
        Return (sqlCmd)
    End Function
    Private Function GetUpdateCmdDatosApv() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_EMPLEADO_DATOS_APV

        sqlParam = New SqlClient.SqlParameter("@EMPLEADO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ESTADO_REGISTRO", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@TIPO_AHORRO_PREVISIONAL", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@APV_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_AHORRO", SqlDbType.Decimal)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONEDA_AHORRO_APV_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PERIODO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout
        Return (sqlCmd)
    End Function
    Private Function GetUpdateCmdDatosPresupAnualHonorario() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.ACTUALIZA_PRESUPUESTO_ANUAL_HONORARIO

        sqlParam = New SqlClient.SqlParameter("@EMPLEADO_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ESTADO_REGISTRO", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@AÑO", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_ENERO", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_FEBRERO", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_MARZO", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_ABRIL", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_MAYO", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_JUNIO", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_JULIO", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_AGOSTO", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_SEPTIEMBRE", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_OCTUBRE", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_NOVIEMBRE", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_DICIEMBRE", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PERIODO_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_CONTRATO_DESDE", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_CONTRATO_HASTA", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NRO_SOLUCION", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_RESOLUCION", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@OBSERVACION", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_VIGENTE", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ES_RETIRO_EMPLEADO", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MOTIVO_RETIRO_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout

        sqlParam = New SqlClient.SqlParameter("@Identity", SqlDbType.BigInt, 0, "ANTECEDENTE_HONORARIO_DETALLE_ID")
        sqlParam.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(sqlParam)

        Return (sqlCmd)
    End Function

    Private Function GetUpdateCmdDatosAntecedenteCurricular() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.ACTUALIZA_ANTECEDENTE_CURRICULAR

        sqlParam = New SqlClient.SqlParameter("@EMPLEADO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ESTADO_REGISTRO", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PROFESION_OFICIO_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@OTROS_ESTUDIOS", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@EXPERIENCIA_LABORAL", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@Identity", SqlDbType.BigInt, 0, "ANTECEDENTE_CURRI_ID")
        sqlParam.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(sqlParam)

        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout
        Return (sqlCmd)
    End Function


    Private Function GetUpdateCmdDatosRemun() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_EMPLEADO_DATOS_REMUN

        sqlParam = New SqlClient.SqlParameter("@EMPLEADO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ESTADO_REGISTRO", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FONDO_BIENESTAR", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_ING_FONDO_BIENESTAR", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ASOCIACION_GREMIAL_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_ING_ASOC_GREMIAL", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FORMA_PAGO", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@TIPO_CUENTA_BANCO_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NRO_CUENTA_BANCO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@BANCO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ASIGNACION_PROFESIONAL", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@RENTA_BASE", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NUMERO_BIENIOS", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_CUMPLIO_BIENIOS", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@TRAMO_ASIGNACION_FAMILIAR_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CARGAS_FAM_NORMALES", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CARGAS_FAM_INVALIDAS", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CARGAS_FAM_PRENATAL", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_SUELDO_BASE", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_ASIGNACION_PROFESIONAL", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_ASIGNACION_RESPONSABILIDAD_SUPERIOR", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_ASIGNACION_LEY19185_ART18", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CLASIFICACION_INE", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ULTIMO_PERIODO_REMUNERACION", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@GASTO_REPRESENTACION", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_GASTO_REPRESENTACION", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_FUNCION_CRITICA", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_ASIGNACION_LEY18717", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_LEY18675_ART10", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_LEY18675_ART11", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_LEY18566", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@APLICA_LEY_3551", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_ASIGNACION_LEY_3551", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_INCREMENTO_PREVIS_DL3501", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PERIODO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ANO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PORCENTAJE_LEY19863", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ENTREGO_BOLETA_HONORARIO", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@AUTORIZA_PAGO_BIENIO", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@OBSERVACION_AUTORIZA", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ENVIA_HACIA_DEXON", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NUMERO_TICKET_DEXON", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@Identity", SqlDbType.BigInt, 0, "ANTECEDENTE_REMUN_ID")
        sqlParam.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(sqlParam)

        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout
        Return (sqlCmd)
    End Function
    Private Function GetUpdateCmdDatosEstrucOrganica() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_EMPLEADO_DATOS_ESTRUC_ORGANICA

        sqlParam = New SqlClient.SqlParameter("@ESTADO_REGISTRO", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@EMPLEADO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)


        sqlParam = New SqlClient.SqlParameter("@ORGANIZACION_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@DIRECCION_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@DEPTO_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PERIODO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@EVALUADOR_DESEMPENO_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@AUTORIZADOR_HORAS_EXTRAS_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@SUB_DEPTO_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@Identity", SqlDbType.BigInt, 0, "ESTRUCTURA_ORGANICA_ID")
        sqlParam.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(sqlParam)

        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout
        Return (sqlCmd)
    End Function
    Private Function GetUpdateCmdDatosEstrucContable() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_EMPLEADO_DATOS_ESTRUC_CONTABLE

        sqlParam = New SqlClient.SqlParameter("@ESTADO_REGISTRO", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ORGANIZACION_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@EMPLEADO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CENTRO_COSTO_CONTAB_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CENTRO_COSTO_PRESUP_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PORCENTAJE_DISTRIB", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PERIODO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@Identity", SqlDbType.BigInt, 0, "ESTRUCTURA_CONTABLE_ID")
        sqlParam.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(sqlParam)

        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout
        Return (sqlCmd)
    End Function
    Private Function GetUpdateCmdDatosEventoAdmin() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_EMPLEADO_EVENTO_ADMIN

        sqlParam = New SqlClient.SqlParameter("@TIPO_EVENTO_ADMIN_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@EMPLEADO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_DIGITACION", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ESTADO_EVENTO_ADMIN_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@DIAS_SOLICITADOS", SqlDbType.Decimal)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MOTIVO_SOLICITUD", SqlDbType.Char)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ANO", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PERIODO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@Identity", SqlDbType.BigInt, 0, "EVENTO_ADMINISTRATIVO_ID")
        sqlParam.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(sqlParam)

        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout
        Return (sqlCmd)
    End Function
    Private Function GetUpdateCmdDatosSaldoDiasEventoAdmin() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_EMPLEADO_EVENTO_ADMIN_SALDO

        sqlParam = New SqlClient.SqlParameter("@TIPO_EVENTO_ADMIN_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@EMPLEADO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@DIAS_PERIODO", SqlDbType.Decimal)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@DIAS_PERIODO_ANT", SqlDbType.Decimal)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@DIAS_ADICIONALES", SqlDbType.Decimal)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@TOTAL_DIAS_ANUAL", SqlDbType.Decimal)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@TOTAL_DIAS_SOLICITADOS", SqlDbType.Decimal)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@DIAS_PENDIENTE", SqlDbType.Decimal)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ANO", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@Identity", SqlDbType.BigInt, 0, "EVENTO_ADMIN_SALDO_ID")
        sqlParam.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(sqlParam)

        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout
        Return (sqlCmd)
    End Function

    Private Function GetUpdateCmdDatosLicenciaMedica() As SqlCommand
        Dim sqlCmd As New SqlCommand
        Dim sqlParam As SqlClient.SqlParameter
        sqlCmd.Connection = New SqlConnection(ArgoConfiguracion.ConnectionString)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = SQL.STORE_PROCEDURES.INSERTA_EMPLEADO_LICENCIA_MEDICA

        sqlParam = New SqlClient.SqlParameter("@EMPLEADO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NUMERO_LICENCIA", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@TIPO_LICENCIA_MEDICA_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ESTADO_LICENCIA", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_RECEPCION", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@DIAS_LICENCIA", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_INICIO", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_TERMINO", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_ACCIDENTE", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_EMISION", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@TIPO_REPOSO", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@LUGAR_REPOSO", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_ENVIO_ISAPRE", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CONTINUIDAD", SqlDbType.Bit)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NUMERO_LICENCIA_CONTINUIDAD", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_INICIO_CONTINUIDAD", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@DIAS_CONTINUIDAD", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_TERMINO_CONTINUIDAD", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PERIODO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_CONCEPCION", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NOMBRE_DOCTOR", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@ESPECIALIDAD", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@TIPO_EVENTO_ADMIN_ID", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NUMERO_CHEQUE", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MONTO_CHEQUE", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@MEMORANDUM", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@OBSERVACIONES", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_DIGITACION_PAGO", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@PERIODO_ID", SqlDbType.SmallInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@RENTA_PROMEDIO_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_RECEPCION_ISAPRE", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@NUMERO_FILIO", SqlDbType.VarChar)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CLASIFICACION", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@DIAS_REDUCCION", SqlDbType.TinyInt)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@FECHA_ESTIMADA_PAGO", SqlDbType.DateTime)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@CAUSA_RECHAZO_ID", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@TIPO_PROFESIONAL", SqlDbType.Int)
        sqlCmd.Parameters.Add(sqlParam)

        sqlParam = New SqlClient.SqlParameter("@Identity", SqlDbType.BigInt, 0, "LICENCIA_MEDICA_ID")
        sqlParam.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(sqlParam)

        sqlCmd.CommandTimeout = ArgoConfiguracion.CommandTimeout
        Return (sqlCmd)
    End Function

    Public Function insertaHorasExtrasAprobadas(ByVal empleado_id As Integer, ByVal año As Integer, _
                                      ByVal mes As Integer, ByVal nro_memo_interno As Integer, _
                                      ByVal fecha_memo_interno As DateTime, ByVal horas_diurnas_aprobadas As Integer, _
                                      ByVal horas_nocturnas_aprobadas As Integer, ByVal depto_id As Integer, ByVal estado_registro As Integer, ByVal tipo_proceso As String) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand("EXEC " & SQL.STORE_PROCEDURES.INSERTA_HORAS_EXTRAS_APROBADAS & " @EMPLEADO_ID, @ANO, @MES, @NRO_MEMO_INTERNO, @FECHA_MEMO_INTERNO, @HORAS_DIURNAS_APROBADAS, @HORAS_NOCTURNAS_APROBADAS, @DEPTO_ID, @ESTADO_REGISTRO, @TIPO_PROCESO")

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = empleado_id
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ANO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = año
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@MES"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = mes
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@NRO_MEMO_INTERNO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = nro_memo_interno
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_MEMO_INTERNO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = fecha_memo_interno
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@HORAS_DIURNAS_APROBADAS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = horas_diurnas_aprobadas
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@HORAS_NOCTURNAS_APROBADAS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = horas_nocturnas_aprobadas
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@DEPTO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = depto_id
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@ESTADO_REGISTRO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.TinyInt
        prm.Value = estado_registro
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@tipo_proceso"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = tipo_proceso
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function

    Public Function actualizaHorasExtrasAprobadas(ByVal horas_aprobadas_id As Integer, _
                                          ByVal horas_diurnas_aprobadas As Integer, _
                                          ByVal horas_nocturnas_aprobadas As Integer) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlClient.SqlConnection(ArgoConfiguracion.ConnectionString)
        conn.Open()

        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter

        cmd = New SqlClient.SqlCommand("EXEC " & SQL.STORE_PROCEDURES.ACTUALIZA_HORAS_EXTRAS_APROBADAS & " @HORAS_APROBADAS_ID, @HORAS_DIURNAS_APROB, @HORAS_NOCTURNAS_APROB")

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@HORAS_APROBADAS_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = horas_aprobadas_id
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@HORAS_DIURNAS_APROB"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = horas_diurnas_aprobadas
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@HORAS_NOCTURNAS_APROB"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = horas_nocturnas_aprobadas
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function

    Public Function EnviarHonorariosTesoreria(ByVal idperiodo As Integer, ByVal tipoProceso As Integer) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)

        Dim cmd As SqlClient.SqlCommand = New SqlCommand("sp_enviarHonorariosATesoreria", conn)
        Dim prm As SqlClient.SqlParameter

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 20

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.SmallInt
        prm.Value = idperiodo
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_PROCESO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = tipoProceso
        cmd.Parameters.Add(prm)

        cmd.Connection = conn
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function


    Public Function InsertarDatosTesoreria(ByVal EmpleadoId As Integer, ByVal Apellidos As String, ByVal Nombres As String, _
                    ByVal Rut As Integer, ByVal Dv As String, ByVal PeriodoId As Integer, ByVal Monto As Integer, ByVal TipoProceso As String, _
                    ByVal NombreCalidadJuridica As String, ByVal FormaPagoId As Integer, ByVal NombreFormaPago As String, _
                    ByVal NombreDepartamento As String, ByVal GenerarCheque As Boolean, ByVal ChequeEmitido As Boolean, ByVal NumeroCheque As Integer, ByVal NumeroEgreso As Integer, _
                    ByVal FechaCheque As Date, ByVal CalidadJuridicaId As Integer, ByVal ImpresionId As Integer, ByVal EgresoId As Integer, ByVal NumeroCuentaCorriente As Integer) As Boolean
        Dim conn As SqlClient.SqlConnection
        conn = New SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)

        Dim cmd As SqlClient.SqlCommand = New SqlCommand("sp_insertaDatosTesoreria", conn)
        Dim prm As SqlClient.SqlParameter

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 20

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EMPLEADO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = EmpleadoId
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@APELLIDOS"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = RTrim(Apellidos)
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@NOMBRES"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = RTrim(Nombres)
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@NOMBRE_COMPLETO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = RTrim(Apellidos) + " " + RTrim(Nombres)
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@RUT"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = Rut
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@DV"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = Dv
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@PERIODO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = PeriodoId
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@LIQUIDO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.BigInt
        prm.Value = Monto
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@TIPO_CALCULO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = TipoProceso
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@NOMBRE_CALIDAD_JURIDICA"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = NombreCalidadJuridica
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FORMA_PAGO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.TinyInt
        prm.Value = FormaPagoId
        cmd.Parameters.Add(prm)

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@NOMBRE_FORMA_PAGO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = NombreFormaPago
        cmd.Parameters.Add(prm)
        cmd.Connection = conn

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@NOMBRE_DEPARTAMENTO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.VarChar
        prm.Value = NombreDepartamento
        cmd.Parameters.Add(prm)
        cmd.Connection = conn

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@GENERAR_CHEQUE"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Bit
        prm.Value = GenerarCheque
        cmd.Parameters.Add(prm)
        cmd.Connection = conn

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_ENVIO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = FechaCheque
        cmd.Parameters.Add(prm)
        cmd.Connection = conn

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@CHEQUE_EMITIDO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Bit
        prm.Value = ChequeEmitido
        cmd.Parameters.Add(prm)
        cmd.Connection = conn

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@NUMERO_CHEQUE"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = NumeroCheque
        cmd.Parameters.Add(prm)
        cmd.Connection = conn

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@NUMERO_EGRESO"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = NumeroEgreso
        cmd.Parameters.Add(prm)
        cmd.Connection = conn

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@FECHA_CHEQUE"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.DateTime
        prm.Value = FechaCheque
        cmd.Parameters.Add(prm)
        cmd.Connection = conn

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@CALIDAD_JURIDICA_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = CalidadJuridicaId
        cmd.Parameters.Add(prm)
        cmd.Connection = conn


        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@IMPRESION_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = ImpresionId
        cmd.Parameters.Add(prm)
        cmd.Connection = conn


        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@EGRESO_ID"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = EgresoId
        cmd.Parameters.Add(prm)
        cmd.Connection = conn

        prm = New SqlClient.SqlParameter
        prm.ParameterName = "@NUMERO_CUENTA_CORRIENTE"
        prm.Direction = ParameterDirection.Input
        prm.SqlDbType = SqlDbType.Int
        prm.Value = NumeroCuentaCorriente
        cmd.Parameters.Add(prm)
        cmd.Connection = conn


        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function

#End Region
    Dim DAdap As New SqlDataAdapter

    Public Function Insertar(ByVal DRow As DataRow, _
                                 ByVal TablaMem As DataTable, _
                                 ByVal DSet As DataSet) As Integer


        Try


            'Instanciamos el adaptador.
            DAdap = New SqlDataAdapter("SELECT *  FROM " & TablaMem.TableName, ArgoConfiguracion.ConnectionString)

            'Inicio el llamado.
            TablaMem.BeginLoadData()

            'Agregamos o actualizamos la tabla destino con el DATAROW obtenido.
            DSet.Tables(CType(TablaMem.TableName, String)).LoadDataRow(DRow.ItemArray, False)

            'Método heredado de la clase empleado - Clase Padre.
            DAdap.UpdateCommand = GetUpdateCommand(DAdap)


            'Tamos....
            DAdap.Update(DSet, TablaMem.TableName)

            DSet.AcceptChanges()




            'Finalizo el llamado
            TablaMem.EndLoadData()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


        'Return (DRow)
    End Function

    Private Function ArrayToString(ByVal items As Array, ByVal separador As String) As String
        Dim i As Integer
        Dim rtnStr As String = ""
        While (i <= items.Length - 1)
            If i > 0 Then
                rtnStr = rtnStr + separador
            End If
            rtnStr = rtnStr + items(i).ToString

            i += 1
        End While
        Return rtnStr
    End Function


    Protected Overridable Overloads Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            conn.Close()
            conn = Nothing
        End If
    End Sub

End Class
