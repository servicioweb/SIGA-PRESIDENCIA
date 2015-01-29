Option Strict On
Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun.TiposDeDatos

Public Class Asistencia

    Private dsAsistencia As New DataAccess.Asistencias
    Public datosDetalleControlAsistencia As EDetalleControlAsistencia

    Public Sub New()
        MyBase.new()
    End Sub
    Public Function actualizar(ByVal datosDetalleControlAsistencia As EDetalleControlAsistencia) As Boolean
        Try
            Return dsAsistencia.actualizar(datosDetalleControlAsistencia)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return (False)
        End Try
    End Function
    Public ReadOnly Property dvControlAsistenciaDepartamento(ByVal fechaAsistencia As DateTime, ByVal deptoID As Integer) As DataView
        Get
            Return recuperaControlAsistenciaDepartamento(fechaAsistencia, deptoID)
        End Get
    End Property
    Public ReadOnly Property dvControlAsistenciaEmpleado(ByVal fechaAsistenciaInicial As DateTime, ByVal fechaAsistenciaFinal As DateTime, ByVal empleadoID As Integer) As DataView
        Get
            Return recuperaControlAsistenciaEmpleado(fechaAsistenciaInicial, fechaAsistenciaFinal, empleadoID)
        End Get
    End Property
    Public ReadOnly Property dvRatificacionHorasExtras(ByVal ano As Integer) As DataView
        Get
            Return recuperaRatificacionHorasExtras(ano)
        End Get
    End Property
    Public ReadOnly Property dvHorasAtraso(ByVal ano As Integer) As DataView
        Get
            Return recuperaHorasAtraso(ano)
        End Get
    End Property
    Public ReadOnly Property dvHorasCompensadas(ByVal ano As Integer) As DataView
        Get
            Return recuperaHorasCompensadas(ano)
        End Get
    End Property
    Private Function recuperaControlAsistenciaDepartamento(ByVal fechaAsistencia As DateTime, ByVal deptoID As Integer) As DataView
        Return (dsAsistencia.recuperarAsistenciaDepartamento(fechaAsistencia, deptoID))
    End Function
    Private Function recuperaControlAsistenciaEmpleado(ByVal fechaAsistenciaInicial As DateTime, ByVal fechaAsistenciaFinal As DateTime, ByVal empleadoID As Integer) As DataView
        Return (dsAsistencia.recuperarAsistenciaEmpleado(fechaAsistenciaInicial, fechaAsistenciaFinal, empleadoID))
    End Function
    Private Function recuperaRatificacionHorasExtras(ByVal ano As Integer) As DataView
        Return (dsAsistencia.recuperarRatificacionHorasExtras(ano))
    End Function
    Private Function recuperaHorasAtraso(ByVal ano As Integer) As DataView
        Return (dsAsistencia.recuperarHorasAtraso(ano))
    End Function
    Private Function recuperaHorasCompensadas(ByVal ano As Integer) As DataView
        Return (dsAsistencia.recuperarHorasCompensadas(ano))
    End Function
    Public Function sumarHorasDeptofecha(ByVal fechaAsistencia As DateTime, ByVal deptoID As Integer, _
                     ByRef totalHrsExtDiurnas As String, ByRef totalHrsExtNocturnas As String, ByRef totalHrsAtraso As String, _
                     ByRef totalHrsExtDiurnasAutoriz As String, ByRef totalHrsExtNocturnasAutoriz As String, ByRef totalHrsAtrasoAutoriz As String) As Boolean
        Return (dsAsistencia.sumarHorasDeptoFecha(fechaAsistencia, deptoID, totalHrsExtDiurnas, totalHrsExtNocturnas, totalHrsAtraso, totalHrsExtDiurnasAutoriz, totalHrsExtNocturnasAutoriz, totalHrsAtrasoAutoriz))
    End Function

    Public Function sumarHorasEmpleadoFecha(ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime, ByVal empleadoID As Integer, _
                     ByRef totalHrsExtDiurnas As String, ByRef totalHrsExtNocturnas As String, ByRef totalHrsAtraso As String, _
                     ByRef totalHrsExtDiurnasAutoriz As String, ByRef totalHrsExtNocturnasAutoriz As String, ByRef totalHrsAtrasoAutoriz As String) As Boolean
        Return (dsAsistencia.sumarHorasEmpleadoFecha(fechaInicial, fechaFinal, empleadoID, totalHrsExtDiurnas, totalHrsExtNocturnas, totalHrsAtraso, totalHrsExtDiurnasAutoriz, totalHrsExtNocturnasAutoriz, totalHrsAtrasoAutoriz))
    End Function
End Class
