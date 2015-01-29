Option Strict On
Imports System.ComponentModel
Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.Comun.TiposDeDatos

Public Structure EEncabezado
    Dim viaticoID As Integer
    Dim tipoResolucion As Short
    Dim numeroMemorandum As String
    Dim fechaMemorandum As Date
    Dim motivo As String
    Dim numeroResolucion As Integer
    Dim fechaResolucion As Date
    Dim periodoID As Integer
    Dim estadoRegistroViatico As Byte
    Dim departamento As Integer
    Dim tipoEventoAdmininstrativo As Integer
End Structure

Public Structure EDetalle
    Dim IdDetalle As Integer
    Dim cantidadDias As Integer
    Dim fechaInicio As Date
    Dim fechaTermino As Date
    Dim motivo As String
    Dim paisID As Integer
    Dim comunaID As Integer
    Dim monto As Integer
    Dim empleadoID As Integer
    Dim numeroDocumento As String
    Dim fechaDocumento As Date
    Dim regionID As Integer
    Dim destino As Byte
    Dim estadoViatico As Byte
    Dim gradoId As Short
    Dim numeroEgreso As String
    Dim patenteVehiculo As String
End Structure
Public Enum tipoEstadoViatico
    PENDIENTE = 0
    PAGADO_CON_CHEQUE = 1
    PAGADO_DEPOSITADO_CUENTA_BANCO = 2
End Enum
Public Class Viatico
    Dim dsViatico As New DataAccess.Viaticos
    Public datosEncabezado As EEncabezado
    Public datosDetalle As EDetalle
    Public tipoEstadoViatico As tipoEstadoViatico

    Public Sub New()
        MyBase.new()
    End Sub
    Public Sub New(ByVal idViatico As Integer)
        MyBase.new()

        Dim ViaticoDR As DataAccess.DSViatico.RH_PER_VIATICORow
        Me.datosEncabezado.viaticoID = CType(idViatico, Integer)

        ViaticoDR = CType(dsViatico.Busca(Me.datosEncabezado.viaticoID, Tablas.RH_PER_VIATICO, "SELECT * FROM " & Tablas.RH_PER_VIATICO), DataAccess.DSViatico.RH_PER_VIATICORow)
        asignacionCampos(ViaticoDR)
    End Sub
    Public Function CrearEncabezado() As Long
        Dim ViaticoDR As DataAccess.Viaticos.RH_PER_VIATICORow
        Try
            ViaticoDR = CType(dsViatico.Tables(Tablas.RH_PER_VIATICO).NewRow, DataAccess.DSViatico.RH_PER_VIATICORow)
            asignacionCampos(Me, ViaticoDR)
            ViaticoDR = CType(dsViatico.InsertarEncabezado(ViaticoDR), DataAccess.Viaticos.RH_PER_VIATICORow)
            Return (ViaticoDR.VIATICO_ID)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
    Public Function ActualizarEncabezado() As Boolean
        Dim ViaticoDR As DataAccess.Viaticos.RH_PER_VIATICORow
        Try
            ViaticoDR = CType(dsViatico.Busca(Me.datosEncabezado.viaticoID, Tablas.RH_PER_VIATICO, "SELECT * FROM " & Tablas.RH_PER_VIATICO), DataAccess.Viaticos.RH_PER_VIATICORow)
            asignacionCampos(Me, ViaticoDR)
            ViaticoDR = CType(dsViatico.ActualizarEncabezado(ViaticoDR), DataAccess.Viaticos.RH_PER_VIATICORow)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return (False)
        End Try
    End Function
    Public Function EliminaViaticoMaestro() As Boolean
        Try
            Return dsViatico.eliminaViaticoMaestro(Me.datosEncabezado.viaticoID)
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function
    Public Function EliminaViaticoDetalle() As Boolean
        Try
            Return dsViatico.eliminaDetalle(Me.datosDetalle.IdDetalle)
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function

    Public Function CrearDetalle() As Long
        Dim DetViaticoDR As DataAccess.Viaticos.RH_PER_VIATICO_DETALLERow
        Try
            DetViaticoDR = CType(dsViatico.Tables(Tablas.RH_PER_VIATICO_DETALLE).NewRow, DataAccess.DSViatico.RH_PER_VIATICO_DETALLERow)
            asignacionCampos(Me, DetViaticoDR)
            DetViaticoDR = CType(dsViatico.InsertarDetalle(DetViaticoDR), DataAccess.Viaticos.RH_PER_VIATICO_DETALLERow)
            Return (DetViaticoDR.VIATICO_DETALLE_ID)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function ActualizarDetalle() As Boolean
        Dim ViaticoDetDR As DataAccess.Viaticos.RH_PER_VIATICO_DETALLERow
        Try
            ViaticoDetDR = CType(dsViatico.Busca(Me.datosDetalle.IdDetalle, Tablas.RH_PER_VIATICO_DETALLE, "SELECT * FROM " & Tablas.RH_PER_VIATICO_DETALLE), DataAccess.Viaticos.RH_PER_VIATICO_DETALLERow)
            asignacionCampos(Me, ViaticoDetDR)
            ViaticoDetDR = CType(dsViatico.ActualizarDetalle(ViaticoDetDR), DataAccess.Viaticos.RH_PER_VIATICO_DETALLERow)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return (False)
        End Try
    End Function
    Private Sub asignacionCampos(ByVal dr As DataAccess.Viaticos.RH_PER_VIATICORow)
        If Not dr Is Nothing Then
            Me.datosEncabezado.tipoResolucion = CType(dr("TIPO_RESOLUCION"), Short)
            Me.datosEncabezado.numeroMemorandum = CType(dr("NRO_MEMORANDUM_INTERNO"), String)
            Me.datosEncabezado.fechaMemorandum = CType(dr("FECHA_MEMORANDUM"), Date)
            Me.datosEncabezado.motivo = CType(dr("MOTIVO"), String)
            Me.datosEncabezado.numeroResolucion = CType(dr("NRO_RESOLUCION"), Integer)
            Me.datosEncabezado.fechaResolucion = CType(dr("FECHA_RESOLUCION"), Date)
            Me.datosEncabezado.periodoID = CType(dr("PERIODO_ID"), Integer)
            Me.datosEncabezado.estadoRegistroViatico = CType(dr("ESTADO_REGISTRO"), Byte)
            Me.datosEncabezado.departamento = CType(dr("DEPTO_ID"), Integer)
        End If
    End Sub
    Private Sub asignacionCampos(ByVal viatico As BusinessRules.Viatico, ByRef ViaticoDR As DataAccess.Viaticos.RH_PER_VIATICORow)
        With ViaticoDR
            .TIPO_RESOLUCION = CType(viatico.datosEncabezado.tipoResolucion, Byte)
            .NRO_MEMORANDUM_INTERNO = CType(viatico.datosEncabezado.numeroMemorandum, String)
            .FECHA_MEMORANDUM = CType(viatico.datosEncabezado.fechaMemorandum, Date)
            .MOTIVO = viatico.datosEncabezado.motivo
            .NRO_RESOLUCION = CType(viatico.datosEncabezado.numeroResolucion, String)
            .FECHA_RESOLUCION = CType(viatico.datosEncabezado.fechaResolucion, Date)
            .PERIODO_ID = viatico.datosEncabezado.periodoID
            .ESTADO_REGISTRO = viatico.datosEncabezado.estadoRegistroViatico
            .TIPO_EVENTO_ADMIN_ID = CType(viatico.datosEncabezado.tipoEventoAdmininstrativo, Byte)
            .DEPTO_ID = viatico.datosEncabezado.departamento
        End With
    End Sub
    Private Sub asignacionCampos(ByVal viatico As BusinessRules.Viatico, ByRef DetViaticoDR As DataAccess.Viaticos.RH_PER_VIATICO_DETALLERow)
        With DetViaticoDR
            .VIATICO_ID = CType(viatico.datosEncabezado.viaticoID, Integer)
            .CANTIDAD_DIAS = CType(viatico.datosDetalle.cantidadDias, Byte)
            .FECHA_INICIO = CType(viatico.datosDetalle.fechaInicio, Date)
            .FECHA_TERMINO = CType(viatico.datosDetalle.fechaTermino, Date)
            .MOTIVO = ""
            .PAIS_ID = viatico.datosDetalle.paisID
            .COMUNA_ID = viatico.datosDetalle.comunaID
            .MONTO = viatico.datosDetalle.monto
            .EMPLEADO_ID = viatico.datosDetalle.empleadoID
            .NUMERO_DOCUMENTO = viatico.datosDetalle.numeroDocumento
            .FECHA_DOCUMENTO = CType(viatico.datosDetalle.fechaDocumento, Date)
            .REGION_ID = viatico.datosDetalle.regionID
            .DESTINO = viatico.datosDetalle.destino
            .ESTADO_VIATICO = viatico.datosDetalle.estadoViatico
            .NUMERO_EGRESO = viatico.datosDetalle.numeroEgreso
            .PATENTE_VEHICULO = viatico.datosDetalle.patenteVehiculo
        End With
    End Sub
    Public Function recuperaMontoViatico(ByVal gradoID As Integer, ByVal calculaViativoMesAnterior As Boolean) As Integer
        Return dsViatico.Busca(gradoID, calculaViativoMesAnterior)
    End Function
    Public Function recuperarViaticoDetalle(ByVal viaticoID As Long) As DataView
        Return (dsViatico.recuperarViaticoDetalle(viaticoID))
    End Function
    Public Function recuperarViaticoPorMemo(ByVal año As Integer, ByVal soloPendientes As Boolean) As DataView
        Return (dsViatico.recuperarViaticoPorMemo(año, soloPendientes))
    End Function
    Public Function buscaIDNumeroMemorandum(ByVal numeroMemorandum As String, ByVal anoProceso As Integer, ByVal deptoID As Integer) As Integer
        Return (dsViatico.buscaIDNumeroMemorandum(numeroMemorandum, anoProceso, deptoID))
    End Function
    Public Function buscaIDNumeroResolucion(ByVal numeroResolucion As String, ByVal anoProceso As Integer) As Integer
        Return (dsViatico.buscaIDNumeroResolucion(numeroResolucion, anoProceso))
    End Function
    Public Function estadoViatico(ByVal viaticoID As Integer) As Integer
        Return dsViatico.estadoViatico(viaticoID)
    End Function
    Public Function validaRangoFechaViatico(ByVal fechaInicio As Date, ByVal idEmpleado As Integer, ByVal cantidadDias As Integer, ByVal idDetalleViatico As Integer, ByVal idTipoEventoAdmin As Integer) As String
        Return dsViatico.validaRangoFechaViatico(fechaInicio, idEmpleado, cantidadDias, idDetalleViatico, idTipoEventoAdmin)
    End Function
    Public Function recuperaResolucionViatico(ViaticoId As Integer) As DataTable
        Return (dsViatico.recuperarResolucionViatico(ViaticoId))
    End Function
    Public Function recuperaResolucionViaticoCabecera(ViaticoId As Integer) As DataView
        Return (dsViatico.recuperarResolucionViaticoCabecera(ViaticoId))
    End Function
End Class
