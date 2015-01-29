Namespace SQL
    Public Class INSTRUCCIONES_SQL
        Public Shared ReadOnly Property SELECT_BUSCADOR_EMPLEADO() As String
            Get
                Return ("SELECT EMPLEADO_ID, RUT, NOMBRES, APELLIDO_PATERNO, APELLIDO_MATERNO, RTRIM(APELLIDO_PATERNO) + ' '  + RTRIM(APELLIDO_MATERNO) + ',  ' + RTRIM(NOMBRES) AS NOMBRE_COMPLETO_EMPLEADO   FROM RH_PER_EMPLEADO ORDER BY RUT")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_PAISES() As String
            Get
                Return ("SELECT PAIS_ID, DESCRIPCION FROM GEN_PAIS ORDER BY DESCRIPCION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_CIUDADES() As String
            Get
                Return ("SELECT CIUDAD_ID, DESCRIPCION, REGION_ID FROM GEN_CIUDAD ORDER BY CIUDAD_ALIAS")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_COMUNAS() As String
            Get
                Return ("SELECT COMUNA_ID, DESCRIPCION, REGION_ID FROM GEN_COMUNA ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_SISTEMAPREVISIONAL() As String
            Get
                Return ("SELECT * FROM RH_REM_SISTEMA_PREVISIONAL WHERE (FILTRO_TABLA like 'AFP')  ORDER BY DESCRIPCION")
            End Get
        End Property


        Public Shared ReadOnly Property SELECT_REGIONES() As String
            Get
                Return ("SELECT REGION_ID, REGION_ALIAS, PAIS_ID, DESCRIPCION FROM GEN_REGION ORDER BY REGION_ALIAS")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_ANO() As String
            Get
                Return ("SELECT DISTINCT ANO FROM RH_REM_PERIODO")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_CALIDAD_JURIDICA() As String
            Get
                Return ("SELECT * FROM RH_REM_CALIDAD_JURIDICA ORDER BY CALIDAD_JURIDICA_ALIAS")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_ESTAMENTO() As String
            Get
                Return ("SELECT * FROM RH_PER_ESTAMENTO ORDER BY ESTAMENTO_ALIAS")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_GRADO() As String
            Get
                Return ("SELECT * FROM RH_REM_GRADO WHERE ESTADO_REGISTRO=1 ORDER BY ORDEN")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_ESCALAFON() As String
            Get
                Return ("SELECT * FROM RH_PER_ESCALAFON ORDER BY ESCALAFON_ALIAS")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_EMISOR_CHEQUE_ENCABEZADO() As String
            Get
                Return ("SELECT * FROM RH_PER_EMISOR_CHEQUE ORDER BY FECHA_CHEQUE DESC")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_SUB_DEPTO() As String
            Get
                Return ("SELECT * FROM RH_PER_SUB_DEPARTAMENTO ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_MOTIVO_RETIRO() As String
            Get
                Return ("SELECT * FROM RH_PER_MOTIVO_RETIRO ORDER BY MOTIVO_RETIRO_ALIAS")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_DIRECCION() As String
            Get
                Return ("SELECT * FROM RH_PER_DIRECCION ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_TIPO_UNIDAD() As String
            Get
                Return ("SELECT TIPO_UNIDAD_ID, TIPO_UNIDAD_ALIAS FROM RH_PER_TIPO_UNIDAD ORDER BY TIPO_UNIDAD_ID")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_TIPO_ITEM() As String
            Get
                Return ("SELECT TIPO_ITEM, DESCRIPCION FROM RH_REM_TIPO_ITEM ORDER BY TIPO_ITEM")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_ESTADO_EMPLEADO() As String
            Get
                Return ("SELECT * FROM RH_PER_ESTADO_EMPLEADO ORDER BY DESCRIPCION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_ESTADO_EMPLEADO_CAMBIO_SITUACION_LAB() As String
            Get
                Return ("SELECT * FROM RH_PER_ESTADO_EMPLEADO WHERE INCLUYE_CAMBIO_SITUACION_LABORAL = 1 ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_JEFE_DIRECTO() As String
            Get
                Return ("SELECT * FROM VW_JEFES_DPTO ORDER BY NOMBRE_JEFE")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_UBICACION_FISICA() As String
            Get
                Return ("SELECT * FROM RH_PER_UBICACION_FISICA ORDER BY UBICACION_ALIAS")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_HORARIO_TRABAJO() As String
            Get
                Return ("SELECT * FROM RH_PER_HORARIO ORDER BY HORARIO_ALIAS")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_HISTORICO_ANTECEDENTES_LABORALES() As String
            Get
                Return ("SELECT * FROM dbo.RH_PER_ANTECEDENTE_LABORAL WHERE (EMPLEADO_ID = 1) ORDER BY ANTECEDENTE_LABORAL_ID")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_ANTECEDENTES_CURRICULARES() As String
            Get
                Return ("SELECT * FROM RH_PER_ANTECEDENTE_CURRI ORDER BY ANTECEDENTE_CURRI_ID")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_TIPO_JORNADA() As String
            Get
                Return ("SELECT * FROM RH_PER_TIPO_JORNADA ORDER BY JORNADA_ID")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_EVENTO_ADMIN() As String
            Get
                Return ("SELECT * FROM RH_PER_EVENTO_ADMIN ORDER BY EVENTO_ADMINISTRATIVO_ID")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_EVENTO_ADMIN_DET() As String
            Get
                Return ("SELECT * FROM RH_PER_EVENTO_ADMIN_DET")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_ANTECEDENTES_LABORALES() As String
            Get
                Return ("SELECT * FROM RH_PER_ANTECEDENTE_LABORAL ORDER BY ANTECEDENTE_LABORAL_ID")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_EMPLEADO() As String
            Get
                Return ("SELECT * FROM RH_PER_EMPLEADO ORDER BY EMPLEADO_ID")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_ANTECEDENTES_PREVISIONALES() As String
            Get
                Return ("SELECT * FROM RH_PER_ANTECEDENTE_PREVIS ORDER BY ANTECEDENTE_PREVIS_ID")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_ANTECEDENTES_REMUN() As String
            Get
                Return ("SELECT * FROM RH_PER_ANTECEDENTE_REMUN ORDER BY ANTECEDENTE_REMUN_ID")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_ESTRUCTURA_CONTABLE() As String
            Get
                Return ("SELECT * FROM RH_PER_ESTRUCTURA_CONTABLE")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_ESTRUCTURA_ORGANICA() As String
            Get
                Return ("SELECT * FROM RH_PER_ESTRUCTURA_ORGANICA")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_ANTECEDENTES_ACADEMICOS() As String
            Get
                Return ("SELECT * FROM RH_PER_ANTECEDENTE_ACADEM ORDER BY ANTEC_ACADE_ID")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_FERIADO_LEGAL_SALDO_DIAS() As String
            Get
                Return ("SELECT * FROM VW_FERIADO_LEGAL_SALDO_DIAS WHERE (TIPO_EVENTO_ADMIN_ID = 1)")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_EVENTO_ADMIN_SALDO() As String
            Get
                Return ("SELECT * FROM RH_PER_EVENTO_ADMIN_SALDO")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_ANTECEDENTE_PRESUP_ANUAL_HONORARIO_DETALLE() As String
            Get
                Return ("SELECT * FROM RH_PER_ANTECEDENTE_HONORARIO_DETALLE ORDER BY ANTECEDENTE_HONORARIO_DETALLE_ID")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_ANTECEDENTE_APV() As String
            Get
                Return ("SELECT * FROM RH_PER_ANTECEDENTE_APV ORDER BY ANTECEDENTE_APV_ID")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_APV() As String
            Get
                Return ("SELECT APV_ID, DESCRIPCION FROM RH_REM_APV")
            End Get
        End Property

        'INSTRUCCIONES UTILIZADAS EN MÓDULO DE CARGAS FAMILIARES.
        Public Shared ReadOnly Property SELECT_TIPO_CARGA_FAM() As String
            Get
                Return ("SELECT TIPO_CARGA_FAM_ID, DESCRIPCION FROM RH_PER_TIPO_CARGA_FAM ORDER BY DESCRIPCION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_GRUPO_FAMILIAR(ByVal tipoGrupoFam As Integer) As String
            Get
                Dim cmdWhere As String
                If tipoGrupoFam = 1 Then
                    cmdWhere = " WHERE CARGA_FAM=1 "
                Else
                    cmdWhere = " WHERE GRUPO_FAM=1 "
                End If
                Return ("SELECT GRUPO_FAMILIAR_ID, GRUPO_FAM_ALIAS, DESCRIPCION FROM RH_PER_GRUPO_FAMILIAR" & cmdWhere & "ORDER BY DESCRIPCION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_ESTADO_CARGA_FAM() As String
            Get
                Return ("SELECT  ESTADO_CARGA_ID, ESTADO_CARGA_ALIAS, DESCRIPCION FROM RH_PER_ESTADO_CARGA_FAM ORDER BY DESCRIPCION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_CARGA_FAM() As String
            Get
                Return ("SELECT  * FROM RH_PER_CARGA_FAMILIAR")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_VIATICO() As String
            Get
                Return ("SELECT  * FROM RH_PER_VIATICO")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_DETALLE_VIATICO() As String
            Get
                Return ("SELECT  * FROM RH_PER_VIATICO_DETALLE")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_EMISOR_CHEQUE() As String
            Get
                Return ("SELECT  * FROM RH_PER_EMISOR_CHEQUE")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_EMISOR_CHEQUE_DETALLE() As String
            Get
                Return ("SELECT  * FROM RH_PER_EMISOR_CHEQUE_DETALLE")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_CENTRO_COSTO_CONTABLE() As String
            Get
                Return ("SELECT CENTRO_COSTO_CONTAB_ID, CENTRO_COSTO_ALIAS, DESCRIPCION FROM RH_REM_CENTRO_COSTO_CONTABLE WHERE ESTADO_REGISTRO=1 ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_CENTRO_COSTO_PRESUPUESTO() As String
            Get
                Return ("SELECT CENTRO_COSTO_PRESUP_ID, CENTRO_COSTO_ALIAS, DESCRIPCION FROM RH_REM_CENTRO_COSTO_PRESUPUESTO ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_DEPARTAMENTO() As String
            Get
                Return ("SELECT * FROM RH_PER_DEPARTAMENTO ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_SUB_DEPARTAMENTO() As String
            Get
                Return ("SELECT * FROM RH_PER_SUB_DEPARTAMENTO ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_NIVEL_ESTUDIOS() As String
            Get
                Return ("SELECT * FROM RH_PER_TIPO_NIVEL_ESTUDIO ORDER BY DESCRIPCION")
            End Get
        End Property


        Public Shared ReadOnly Property SELECT_ESTUDIOS() As String
            Get
                Return ("SELECT * FROM RH_PER_NIVEL_ESTUDIO ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_CARGA() As String
            Get
                Return ("SELECT * FROM RH_REM_TRAMO_ASIGNACION_FAMILIAR ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_APV_MANT() As String
            Get
                Return ("SELECT * FROM RH_REM_APV ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_GRADO_MANT() As String
            Get
                Return ("SELECT * FROM RH_REM_GRADO ORDER BY ORDEN")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_CALIDAD_MANT() As String
            Get
                Return ("SELECT * FROM RH_REM_CALIDAD_JURIDICA ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_CLASIFICACION_MANT() As String
            Get
                Return ("SELECT * FROM RH_REM_CLASIFICACION_EMPLEADO ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_CLASIFICACION_DETALLE_AFP() As String
            Get
                Return ("SELECT * FROM RH_REM_AFP_DETALLE ORDER BY AFP_ID")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_BANCOS() As String
            Get
                Return ("SELECT * FROM RH_PER_BANCO ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_UBICACION() As String
            Get
                Return ("SELECT * FROM RH_PER_UBICACION_FISICA ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_COSTOCONTABLE() As String
            Get
                Return ("SELECT * FROM RH_REM_CENTRO_COSTO_CONTABLE ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_COSTOPRESUPUESTO() As String
            Get
                Return ("SELECT * FROM RH_REM_CENTRO_COSTO_PRESUPUESTO ORDER BY DESCRIPCION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_ISAPRES() As String
            Get
                Return ("SELECT * FROM RH_REM_ISAPRE ORDER BY DESCRIPCION")
            End Get

        End Property

        Public Shared ReadOnly Property SELECT_DESCRIPCION_AFP() As String
            Get
                Return ("SELECT AFP_ID, DESCRIPCION FROM RH_REM_AFP ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_ENCABEZADO_AFP() As String
            Get
                Return ("SELECT * FROM RH_REM_AFP")
            End Get
        End Property


        Public Shared ReadOnly Property SELECT_RETIRO() As String
            Get
                Return ("SELECT * FROM RH_PER_MOTIVO_RETIRO ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_COMUNA() As String
            Get
                Return ("SELECT COMUNA_ID, DESCRIPCION FROM GEN_COMUNA ORDER BY DESCRIPCION")
            End Get
        End Property


        Public Shared ReadOnly Property SELECT_SISTEMA() As String
            Get
                Return ("SELECT SISTEMA_PREV_ID, DESCRIPCION FROM RH_REM_SISTEMA_PREVISIONAL WHERE (FILTRO_TABLA like '%ISA%')  ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_ORGANIZACION() As String
            Get
                Return ("SELECT ORGANIZACION_ID, ORGANIZACION_ALIAS, DESCRIPCION FROM GEN_ORGANIZACION ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_PROFESION() As String
            Get
                Return ("SELECT * FROM RH_PER_PROFESION_OFICIO ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_PARENTESCO_CARGA_FAM() As String
            Get
                Return ("SELECT PARENTESCO_ID, PARENTESCO_ALIAS, DESCRIPCION FROM RH_PER_PARENTESCO ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_CAUSA_TERMINO_ASIG_CARGA_FAM() As String
            Get
                Return ("SELECT CAUSA_TERMINO_ASIG_FAM_ID,CAUSA_TERMINO_ASIG_FAM_ALIAS,DESCRIPCION FROM RH_PER_CAUSA_TERMINO_ASIG_FAM ORDER BY DESCRIPCION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_NIVEL_ESTUDIO() As String
            Get
                Return ("SELECT NIVEL_ESTUDIO_ID,NIVEL_ESTUDIO_ALIAS,DESCRIPCION FROM RH_PER_NIVEL_ESTUDIO ORDER BY DESCRIPCION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_REGIMEN_ESTUDIO() As String
            Get
                Return ("SELECT REGIMEN_ESTUDIO_ID,DESCRIPCION FROM RH_PER_REGIMEN_ESTUDIO")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_RESPUESTA() As String
            Get
                Return ("SELECT * FROM GEN_RESPUESTA")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_BANCO() As String
            Get
                Return ("SELECT BANCO_ID,DESCRIPCION FROM RH_PER_BANCO WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & " ORDER BY DESCRIPCION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_ASOCIACION_GREMIAL() As String
            Get
                Return ("SELECT ASOCIACION_GREMIAL_ID,DESCRIPCION FROM RH_PER_ASOCIACION_GREMIAL WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & " ORDER BY DESCRIPCION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_TRAMO_ASIG_FAMILIAR() As String
            Get
                Return ("SELECT TRAMO_ASIGNACION_FAMILIAR_ID,DESCRIPCION, MONTO FROM RH_REM_TRAMO_ASIGNACION_FAMILIAR ORDER BY DESCRIPCION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_TIPO_CUENTA_BANCO() As String
            Get
                Return ("SELECT TIPO_CUENTA_BANCO_ID,DESCRIPCION FROM RH_PER_TIPO_CUENTA_BANCO WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & " ORDER BY DESCRIPCION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_TIPO_LICENCIA_MEDICA() As String
            Get
                Return ("SELECT TIPO_LICENCIA_MEDICA_ID, DESCRIPCION FROM RH_PER_TIPO_LICENCIA_MEDICA ORDER BY DESCRIPCION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_CAUSA_RECHAZO_LICENCIA_MEDICA() As String
            Get
                Return ("SELECT CAUSA_RECHAZO_ID, DESCRIPCION FROM RH_PER_CAUSA_RECHAZO_LICENCIA_MEDICA ORDER BY CAUSA_RECHAZO_ID")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_LICENCIA_MEDICA() As String
            Get
                Return ("SELECT * FROM RH_PER_LICENCIA_MEDICA ORDER BY PERIODO, FECHA_INICIO")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_PERIODO() As String
            Get
                Return ("SELECT * FROM RH_REM_PERIODO WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID)
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_ITEM() As String
            Get
                Return ("SELECT * FROM RH_REM_ITEM WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & " ORDER BY DESCRIPCION_LARGA")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_ITEM_HABER_DESCUENTO() As String
            Get
                Return ("SELECT * FROM RH_REM_ITEM WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & " ORDER BY DESCRIPCION_LARGA")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_ITEM_ENDEUDAMIENTO() As String
            Get
                Return ("SELECT * FROM RH_REM_TIPO_ITEM_ENDEUDAMIENTO")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_IMPUTACION() As String
            Get
                Return ("SELECT * FROM RH_REM_CENTRALIZACION_IMPUTACION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_CENTRALIZACION() As String
            Get
                Return ("SELECT * FROM RH_REM_CENTRALIZACION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_TIPO_TRABAJADOR_PREVIRED() As String
            Get
                Return ("SELECT * FROM RH_REM_TIPO_TRABAJADOR_PREVIRED")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_LIBRO_AUDITORIA() As String
            Get
                Return ("SELECT * FROM RH_REM_COLUMNA_LIBRO WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & " AND TIPO_LIBRO = 1")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_LIBRO_OFICIAL() As String
            Get
                Return ("SELECT * FROM RH_REM_COLUMNA_LIBRO WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & " AND TIPO_LIBRO = 2")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_PERIODO_GENERAL() As String
            Get
                Return ("SELECT * FROM dbo.RH_REM_PERIODO WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & "ORDER BY ANO DESC, MES DESC")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_PERIODO_FICHA_HISTORICA() As String
            Get
                Return ("SELECT PERIODO_ID, ANO, MES, DESCRIPCION_PERIODO, ESTADO_PERIODO FROM dbo.RH_REM_PERIODO WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & " AND ESTADO_PERIODO = 0 ORDER BY ANO DESC, MES DESC")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_PERIODO_AÑO() As String
            Get
                Return ("SELECT DISTINCT ANO FROM dbo.RH_REM_PERIODO WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & "ORDER BY ANO DESC")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_PERIODO_BONO() As String
            Get
                Return ("SELECT * FROM dbo.RH_REM_PERIODO WHERE PROCESO_BONO_MODERNIZACION = 1  AND ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & "ORDER BY ANO DESC, MES DESC")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_CLASIFICACION_EMPLEADO() As String
            Get
                Return ("SELECT * FROM RH_REM_CLASIFICACION_EMPLEADO WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID)
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_EUS() As String
            Get
                Return ("SELECT * FROM RH_REM_EUS WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID)
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_MOVIMIENTO_MENSUAL() As String
            Get
                Return ("SELECT * FROM RH_REM_MOVIMIENTO_MENSUAL")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_RH_PER_HORAS_EXTRAS() As String
            Get
                Return ("SELECT * FROM RH_PER_HORAS_EXTRAS ORDER BY HORAS_EXTRAS_ID")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_TXT_PREVIRED() As String
            Get
                Return ("SELECT * FROM RH_REM_TXT_PLANO_PREVIRED")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_BONO_MODERNIZACION() As String
            Get
                Return ("SELECT * FROM RH_REM_BONO_MODERNIZACION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_REAJUSTE(ByVal organizacionID As Integer) As String
            Get
                Return ("SELECT RH_REM_REAJUSTE.REAJUSTE_ID, RH_REM_REAJUSTE.PERIODO_ID, RH_REM_REAJUSTE.PORCENTAJE, RH_REM_PERIODO.DESCRIPCION_PERIODO" & _
                        " FROM RH_REM_PERIODO INNER JOIN RH_REM_REAJUSTE ON RH_REM_PERIODO.PERIODO_ID = RH_REM_REAJUSTE.PERIODO_ID" & _
                        " WHERE RH_REM_REAJUSTE.ORGANIZACION_ID=" & organizacionID & _
                        " ORDER BY RH_REM_PERIODO.DESCRIPCION_PERIODO DESC")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_TIPO_BENEFICIARIO() As String
            Get
                Return ("SELECT * FROM RH_PER_TIPO_BENEFICIARIO ORDER BY DESCRIPCION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_TIPO_BENEFICIO() As String
            Get
                Return ("SELECT * FROM RH_PER_TIPO_BENEFICIO ORDER BY DESCRIPCION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_TIPO_CAUSANTE() As String
            Get
                Return ("SELECT * FROM RH_PER_TIPO_CAUSANTE ORDER BY DESCRIPCION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_ASIENTO_CONTABLE() As String
            Get
                Return ("SELECT * FROM RH_REM_ASIENTO_CONTABLE")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_CONTROL_ASISTENCIA() As String
            Get
                Return ("SELECT * FROM RH_PER_CONTROL_ASISTENCIA")
            End Get
        End Property

    End Class

    Public Class VISTAS
        Public Shared ReadOnly Property SELECT_ANTECEDENTES_APV_VISTA(ByVal id As Integer) As String
            Get
                Return ("SELECT * FROM VW_ANTECEDENTE_APV WHERE EMPLEADO_ID = " & id & " AND ESTADO_REGISTRO=1")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_LICENCIA_MEDICA_VISTA(ByVal id As Integer) As String
            Get
                Return ("SELECT * FROM VW_LICENCIA_MEDICA WHERE EMPLEADO_ID = " & id)
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_ANTECEDENTES_REMUN_VISTA(ByVal id As Integer) As String
            Get
                Return ("SELECT * FROM VW_ANTECEDENTE_REMUN WHERE EMPLEADO_ID = " & id & " AND ESTADO_REGISTRO = 1 ORDER BY ANTECEDENTE_REMUN_ID")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_ISAPRE() As String
            Get
                Return ("SELECT * FROM VW_TABLA_ISAPRE WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & " ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_INSTITUCIONESEDU() As String
            Get
                Return ("SELECT * FROM VW_INSTITUCIONESEDU WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & " ORDER BY DESCRIPCION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_AFP() As String
            Get
                Return ("SELECT * FROM VW_TABLA_AFP WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & " ORDER BY DESCRIPCION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_EMPLEADOS_VISTA_ACTIVOS() As String
            Get
                Return ("SELECT * FROM VW_MAESTRO_EMPLEADO WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & "AND ESTADO_EMPLEADO_ID=1 AND INCLUYE_CALCULO_SUELDO=1 ORDER BY APELLIDO_PATERNO, APELLIDO_MATERNO, NOMBRES")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_EMPLEADOS_ACTIVOS_PLANTA_CONTRATA_HONORARIOS() As String
            Get
                Return ("SELECT * FROM VW_MAESTRO_EMPLEADO WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & "AND ESTADO_EMPLEADO_ID=1 ORDER BY APELLIDO_PATERNO, APELLIDO_MATERNO, NOMBRES")
            End Get
        End Property


        Public Shared ReadOnly Property SELECT_EMPLEADOS_VISTA_ACTIVOS_INACTIVOS() As String
            Get
                Return ("SELECT * FROM VW_MAESTRO_EMPLEADO WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & " AND INCLUYE_CALCULO_SUELDO=1 ORDER BY APELLIDO_PATERNO, APELLIDO_MATERNO, NOMBRES")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_EMPLEADOS_VISTA_ACTIVOS_INACTIVOS_HONORARIOS() As String
            Get
                Return ("SELECT * FROM VW_MAESTRO_EMPLEADO WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & " AND CALIDAD_JURIDICA_ID = 5 AND INCLUYE_CALCULO_SUELDO=2 ORDER BY APELLIDO_PATERNO, APELLIDO_MATERNO, NOMBRES")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_EMPLEADOS_VISTA() As String
            Get
                Return ("SELECT * FROM VW_MAESTRO_EMPLEADO WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & " ORDER BY APELLIDO_PATERNO, APELLIDO_MATERNO, NOMBRES")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_FICHA_EMPLEADOS_VISTA() As String
            Get
                Return ("SELECT * FROM VW_MAESTRO_EMPLEADO_FICHA WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & " ORDER BY APELLIDO_PATERNO, APELLIDO_MATERNO, NOMBRES")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_EMPLEADOS_TODOS_PLANTA_CONTRATA() As String
            Get
                Return ("SELECT * FROM VW_MAESTRO_EMPLEADO WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & " AND INCLUYE_CALCULO_SUELDO=1 ORDER BY APELLIDO_PATERNO, APELLIDO_MATERNO, NOMBRES")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_EMPLEADOS_MASCULINOS() As String
            Get
                Return ("SELECT * FROM VW_MAESTRO_EMPLEADO WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & " AND SEXO='M' ORDER BY APELLIDO_PATERNO, APELLIDO_MATERNO, NOMBRES")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_CARGAS_FAMILIARES(ByVal idEmpleado As Integer) As String
            Get
                Return ("SELECT * FROM VW_CARGAS_FAMILIARES WHERE EMPLEADO_ID= " & idEmpleado & " AND CARGA_FAM=1")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_CARGAS_FAMILIARES_ACTIVAS(ByVal idEmpleado As Integer) As String
            Get
                Return ("SELECT * FROM VW_CARGAS_FAMILIARES WHERE EMPLEADO_ID= " & idEmpleado & " AND CARGA_FAM=1 AND ESTADO_REGISTRO=1")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_CARGAS_FAMILIARES_SOLO_GRUPO_FAMILIAR(ByVal idEmpleado As Integer) As String
            Get
                Return ("SELECT * FROM VW_CARGAS_FAMILIARES WHERE EMPLEADO_ID= " & idEmpleado & " AND CONFORMA_GRUPO_FAM=1")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_CARGAS_FAMILIARES_SOLO_GRUPO_FAMILIAR_ACTIVAS(ByVal idEmpleado As Integer) As String
            Get
                Return ("SELECT * FROM VW_CARGAS_FAMILIARES WHERE EMPLEADO_ID= " & idEmpleado & " AND CONFORMA_GRUPO_FAM=1 AND ESTADO_REGISTRO=1")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_EUS() As String
            Get
                Return ("SELECT * FROM VW_EUS WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID)
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_PERIODOS_AÑOMES() As String
            Get
                Return ("SELECT PERIODO_ID,ANOMES,ESTADO_PERIODO FROM VW_RH_REM_PERIODO ORDER BY ANOMES DESC")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_PERIODO_GENERAL() As String
            Get
                Return ("SELECT * FROM VW_PERIODO_GENERAL WHERE ORGANIZACION_ID = " & Comun.ArgoConfiguracion.OrganizacionID & "ORDER BY ANO, MES")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_HOJA_VIDA_LABORAL() As String
            Get
                Return ("SELECT * FROM VW_HOJA_VIDA_LABORAL")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_LIQUIDO_A_PAGO() As String
            Get
                Return ("SELECT * FROM VW_LIQUIDO_A_PAGO ORDER BY NOMBRE_COMPLETO")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_EMPLEADOS_INACTIVOS_CON_LIQUIADCION() As String
            Get
                Return ("SELECT * FROM VW_VALIDA_EMPLEADOS_INACTIVOS ORDER BY NOMBRE_COMPLETO_EMPLEADO")
            End Get
        End Property
        '
        Public Shared ReadOnly Property SELECT_MAESTRO_EMPLEADO_COMPLETO_ACTIVOS() As String
            Get
                Return ("SELECT * FROM VW_MAESTRO_EMPLEADO_COMPLETO WHERE ESTADO_EMPLEADO='ACTIVO' ORDER BY NOMBRE_COMPLETO_EMPLEADO")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_MAESTRO_EMPLEADO_RELIQUIDADO() As String
            Get
                Return ("SELECT * FROM VW_MAESTRO_EMPLEADO_RELIQUIDADOS")
            End Get
        End Property


        Public Shared ReadOnly Property SELECT_RH_PER_DIRECCION() As String
            Get
                Return ("SELECT * FROM RH_PER_DIRECCION ORDER BY DESCRIPCION")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_CENTRALIZACION_CONTABLE() As String
            Get
                Return ("SELECT * FROM VW_CENTRALIZACION_CONTABLE")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_ANALISIS_LIQUIDACIONES() As String
            Get
                Return ("SELECT * FROM VW_ANALISIS_LIQUIDACIONES")
            End Get
        End Property

        Public Shared ReadOnly Property SELECT_MAESTRO_EMPLEADOS_DIPRES() As String
            Get
                Return ("SELECT * FROM VW_MAESTRO_EMPLEADO_DIPRES")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_ANALISIS_SALDO_DIAS_EVENTO_ADMIN() As String
            Get
                Return ("SELECT * FROM VW_EVENTOS_ADMINISTRATIVOS_SALDO_DIAS")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_ANALISIS_EVENTO_ADMIN() As String
            Get
                Return ("SELECT * FROM VW_EVENTOS_ADMIN_CONSOLIDADO")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_VIATICO_NUMERO_MEMORANDUM() As String
            Get
                Return ("SELECT * FROM VW_VIATICO_NUMERO_MEMORANDUM ORDER BY YEAR(FECHA_MEMORANDUM) DESC, NRO_MEMORANDUM_INTERNO DESC")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_VIATICO_NUMERO_RESOLUCION() As String
            Get
                Return ("SELECT * FROM VW_VIATICO_NUMERO_RESOLUCION ORDER BY YEAR(FECHA_RESOLUCION), CONVERT(INTEGER, NRO_RESOLUCION) DESC")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_DEPARTAMENTOS() As String
            Get
                Return ("SELECT DEPTO_ID, DESCRIPCION FROM RH_PER_DEPARTAMENTO ORDER BY DESCRIPCION")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_AUTORIZADOR_HORAS_EXTRAS() As String
            Get
                Return ("SELECT DISTINCT AUTORIZADOR_HORAS_EXTRAS_ID, NOMBRE_AUTORIZADOR FROM VW_AUTORIZADOR_HORAS_EXTRAS ORDER BY NOMBRE_AUTORIZADOR")
            End Get
        End Property
        Public Shared ReadOnly Property SELECT_EVALUADOR_DESEMPENO() As String
            Get
                Return ("SELECT DISTINCT EVALUADOR_DESEMPENO_ID, NOMBRE_EVALUADOR FROM VW_EVALUADOR_DESEMPENO ORDER BY NOMBRE_EVALUADOR")
            End Get
        End Property
    

    End Class

    Public Class STORE_PROCEDURES
        Public Shared ReadOnly Property INSERTA_EMPLEADO_DATOS_PERSONALES() As String
            Get
                Return ("sp_insertaDatosPersonales")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_EMPLEADO_DATOS_PREVISIONALES() As String
            Get
                Return ("sp_insertaDatosPrevisionales")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_EMPLEADO_DATOS_APV() As String
            Get
                Return ("sp_insertaDatosApv")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_EMPLEADO_DATOS_LABORALES() As String
            Get
                Return ("sp_insertaDatosLaborales")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_EMPLEADO_DATOS_REMUN() As String
            Get
                Return ("sp_insertaDatosRemun")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_EMPLEADO_EVENTO_ADMIN() As String
            Get
                Return ("sp_insertaDatosEventoAdmin")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_EMPLEADO_EVENTO_ADMIN_SALDO() As String
            Get
                Return ("sp_insertaDatosSaldoDiasEventoAdmin")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_EMPLEADO_DATOS_ESTRUC_ORGANICA() As String
            Get
                Return ("sp_insertaDatosEstructuraOrganica")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_EMPLEADO_DATOS_ESTRUC_CONTABLE() As String
            Get
                Return ("sp_insertaDatosEstructuraContable")
            End Get
        End Property

        Public Shared ReadOnly Property INSERTA_EMPLEADO_LICENCIA_MEDICA() As String
            Get
                Return ("sp_insertaDatosLicenciaMedica")
            End Get
        End Property

        Public Shared ReadOnly Property ACTUALIZA_PRESUPUESTO_ANUAL_HONORARIO() As String
            Get
                Return ("sp_ActualizaAntededentePresupuestoAnualHonorario")
            End Get
        End Property

        Public Shared ReadOnly Property ACTUALIZA_ANTECEDENTE_CURRICULAR() As String
            Get
                Return ("sp_insertaDatosAntecedenteCurricular")
            End Get
        End Property

        Public Shared ReadOnly Property ELIMINA_EMPLEADO() As String
            Get
                Return ("sp_eliminaEmpleado")
            End Get
        End Property
        Public Shared ReadOnly Property ELIMINA_EMPLEADO_APV() As String
            Get
                Return ("sp_eliminaEmpleadoApv")
            End Get
        End Property
        Public Shared ReadOnly Property ELIMINA_EMPLEADO_FICHA_INTRANET() As String
            Get
                Return ("sp_eliminaEmpleadoFichaIntranet")
            End Get
        End Property
        Public Shared ReadOnly Property ELIMINA_EMPLEADO_LICENCIA_MEDICA() As String
            Get
                Return ("sp_eliminaEmpleadoLicenciaMedica")
            End Get
        End Property
        Public Shared ReadOnly Property ELIMINA_CARGA_FAM() As String
            Get
                Return ("sp_eliminaCargaFamiliar")
            End Get
        End Property
        Public Shared ReadOnly Property ELIMINA_VIATICO_MAESTRO() As String
            Get
                Return ("sp_eliminaViaticoMaestro")
            End Get
        End Property
        Public Shared ReadOnly Property ELIMINA_VIATICO_DETALLE() As String
            Get
                Return ("sp_eliminaViaticoDetalle")
            End Get
        End Property
        Public Shared ReadOnly Property ELIMINA_DEFINICION_ITEM() As String
            Get
                Return ("sp_eliminaDefinicionItem")
            End Get
        End Property
        Public Shared ReadOnly Property ELIMINA_EMPLEADO_ESTRUC_ORGANICA() As String
            Get
                Return ("sp_eliminaEmpleadoEstructuraOrganica")
            End Get
        End Property
        Public Shared ReadOnly Property ELIMINA_EMPLEADO_ANTECEDENTE_CURRICULAR() As String
            Get
                Return ("sp_eliminaEmpleadoAntecedenteCurricular")
            End Get
        End Property
        Public Shared ReadOnly Property ELIMINA_REGISTRO_HORA_EXTRA() As String
            Get
                Return ("sp_eliminaRegistroHoraExtra")
            End Get
        End Property
        Public Shared ReadOnly Property ELIMINA_EMPLEADO_ANTECEDENTE_BINARIO() As String
            Get
                Return ("sp_eliminaEmpleadoAntecedenteBinario")
            End Get
        End Property
        Public Shared ReadOnly Property ELIMINA_EMPLEADO_ESTRUC_CONTABLE() As String
            Get
                Return ("sp_eliminaEmpleadoEstructuraContable")
            End Get
        End Property

        Public Shared ReadOnly Property INSERTA_DEFINICION_ITEM() As String
            Get
                Return ("sp_insertaDefinicionItem")
            End Get
        End Property
        Public Shared ReadOnly Property ACTUALIZAR_IPC_ACUMULADO() As String
            Get
                Return ("sp_actualizarIpcAcumulado")
            End Get
        End Property

        Public Shared ReadOnly Property INSERTA_ITEM_ENDEUDAMIENTO() As String
            Get
                Return ("sp_actualizarItemEndeudamiento")
            End Get
        End Property

        Public Shared ReadOnly Property CALCULAR_ENDEUDAMIENTO_EMPLEADO() As String
            Get
                Return ("sp_CalcularEndeudamientoEmpleado")
            End Get
        End Property
        Public Shared ReadOnly Property CAMBIA_ESTADO_CARGA_FAMILIAR() As String
            Get
                Return ("sp_cambia_estado_cargaFamiliar")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_REGISTRO_IMPOSICIONES_PREVIRED() As String
            Get
                Return ("sp_insertaRegistroImposicionesPrevired")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_EMPLEADO_RELIQUIDADO() As String
            Get
                Return ("sp_insertaReliquidacion")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_EMPLEADO_SUPLEMENTARIA() As String
            Get
                Return ("sp_insertaSuplementaria")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_EMPLEADO_SUPLEMENTARIA_HONORARIO() As String
            Get
                Return ("sp_insertaSuplementariaHonorario")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_EMPLEADO_RELIQUIDADO_BONO_MODERNIDAD() As String
            Get
                Return ("sp_insertaRecalculoBonoModernidad")
            End Get
        End Property

        Public Shared ReadOnly Property INSERTA_EGRESO_CABECERA() As String
            Get
                Return ("sp_InsertaEgresoCabecera")
            End Get
        End Property

        Public Shared ReadOnly Property CREA_ANTECEDENTE_LABORAL_PARA_BONO_MODERNIZACION() As String
            Get
                Return ("sp_creaAntecedenteLaboral")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_EMPLEADO_ITEM_RELIQUIDADO() As String
            Get
                Return ("sp_insertaItemsReliquidadosHaciaMovimientoMensual")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_RENTA_PROMEDIO_EMPLEADO_LIC_MEDICA() As String
            Get
                Return ("sp_licenciaMedicaRentaPromedio")
            End Get
        End Property

        Public Shared ReadOnly Property GENERA_FECHA_TERMINO_EVENTO_ADMINISTRATIVO() As String
            Get
                Return ("sp_calculoDiaTerminoEventoAdministrativo")
            End Get
        End Property
        Public Shared ReadOnly Property GENERA_FECHA_RETORNO_EVENTO_ADMINISTRATIVO() As String
            Get
                Return ("sp_calculaFechaRetornoEventoAdmin")
            End Get
        End Property
        Public Shared ReadOnly Property ELIMINA_LIQUIDACION_EMPELADO() As String
            Get
                Return ("sp_eliminaLiquidacionEmpleado")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_EMPLEADO_BONO_MODERNIZACION() As String
            Get
                Return ("sp_insertaEmpleadoBonoModernizacion")
            End Get
        End Property
        Public Shared ReadOnly Property BUSCA_FECHA_FESTIVO() As String
            Get
                Return ("sp_buscaFechaFestivo")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_VIATICO_ENCABEZADO() As String
            Get
                Return ("sp_insertaViaticoEncabezado")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_REGISTRO_CHEQUE_ENCABEZADO() As String
            Get
                Return ("sp_insertaRegistroChequeEncabezado")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_REGISTRO_CHEQUE_DETALLE() As String
            Get
                Return ("sp_insertaRegistroChequeDetalle")
            End Get
        End Property
        Public Shared ReadOnly Property ELIMINA_DETALLE_REGISTRO_CHEQUE() As String
            Get
                Return ("sp_eliminaRegistroDetalleCheque")
            End Get
        End Property
        Public Shared ReadOnly Property ELIMINA_ENCABEZADO_REGISTRO_CHEQUE() As String
            Get
                Return ("sp_eliminaRegistroEncabezadoCheque")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_VIATICO_DETALLE() As String
            Get
                Return ("sp_insertaViaticoDetalle")
            End Get
        End Property
        Public Shared ReadOnly Property VALIDA_RANGO_FECHA_VIATICO() As String
            Get
                Return ("sp_validaRangoFechaEventoAdministrativo")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_MARCA_ASSISCAD() As String
            Get
                Return ("sp_insertaMarcasAsissCAD")
            End Get
        End Property
        Public Shared ReadOnly Property ACTUALIZA_MARCA_VIGENTE_ASISSCAD() As String
            Get
                Return ("sp_actualizaMarcaVigenteAsissCAD")
            End Get
        End Property
        Public Shared ReadOnly Property VERIFICA_MARCA_ASSISCAD() As String
            Get
                Return ("sp_verificaMarcaAsissCAD")
            End Get
        End Property

        Public Shared ReadOnly Property TRASPASA_MARCAS_CONTROL_ACCESO() As String
            Get
                Return ("ICARO.ASSISCAD_PRESIDENCIA.DBO.sp_traspasa_marcas_desde_control_acceso")
            End Get
        End Property

        Public Shared ReadOnly Property GENERA_MARCAS_CONTROL_ACCESO() As String
            Get
                Return ("ICARO.ASSISCAD_PRESIDENCIA.DBO.sp_genera_marcas")
            End Get
        End Property

        Public Shared ReadOnly Property TRASPASA_CONTROL_ASISTENCIA_INTRANET() As String
            Get
                Return ("sp_traspasaControlAsistenciaHaciaIntranet")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_AFP_ENCABEZADO() As String
            Get
                Return ("sp_insertaAFPEncabezado")
            End Get
        End Property
        Public Shared ReadOnly Property INSERTA_ENCABEZADO_ASIENTO_CONTAB() As String
            Get
                Return ("sp_insertaEncabezadoAsientoContable")
            End Get
        End Property
        Public Shared ReadOnly Property ACTUALIZA_DETALLE_CONTROL_ASISTENCIA() As String
            Get
                Return ("sp_actualizaDetalleControlHorario")
            End Get
        End Property
        Public Shared ReadOnly Property ASIENTO_PRESUPUESTARIO_DEXON() As String
            Get
                Return ("sp_generaCentralizacionPresupuestariaHaciaDexon")
            End Get
        End Property
        Public Shared ReadOnly Property ENVIA_HONORARIO_DEXON() As String
            Get
                Return ("sp_EnviaEmpleadoHonorarioHaciaDexon")
            End Get
        End Property
        Public Shared ReadOnly Property SUMA_HORAS_DEPTARTAMENTO() As String
            Get
                Return ("sp_sumaHorasDepartamentoFecha")
            End Get
        End Property
        Public Shared ReadOnly Property SUMA_HORAS_EMPLEADO() As String
            Get
                Return ("sp_sumaHorasEmpleadoFecha")
            End Get
        End Property
        Public Shared ReadOnly Property GENERA_RESUMEN_HORAS_EXTRAS() As String
            Get
                Return ("sp_generaResumenHorasExtras")
            End Get
        End Property
        Public Shared ReadOnly Property GENERA_HORAS_EXTRAS_PAGADAS_VS_RATIFICADAS() As String
            Get
                Return ("sp_generaHorasExtrasPagadasVsRatificadas")
            End Get
        End Property

        Public Shared ReadOnly Property INSERTA_HORAS_EXTRAS_APROBADAS() As String
            Get
                Return ("sp_insertaHorasExtrasAprobadas")
            End Get
        End Property
        Public Shared ReadOnly Property ACTUALIZA_HORAS_EXTRAS_APROBADAS() As String
            Get
                Return ("sp_actualizaHorasExtrasAprobadas")
            End Get
        End Property
    End Class
End Namespace
