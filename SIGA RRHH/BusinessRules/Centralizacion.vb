Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.Comun.TiposDeDatos

Public Class Centralizacion

    Private dsCentralizacion As New DataAccess.Centralizaciones
    Public encabezadoAsientoContable As EEncabezadoAsientoContable

    Public Sub New()
        MyBase.new()
    End Sub

    Public Function CrearEncabezado(ByVal asientoContableID As Integer) As Long
        Dim dr As DataAccess.Centralizaciones.RH_REM_ASIENTO_CONTABLERow
        Try
            dr = CType(dsCentralizacion.Tables(Tablas.RH_REM_ASIENTO_CONTABLE).NewRow, DataAccess.DSAsientoContable.RH_REM_ASIENTO_CONTABLERow)
            asignacionCampos(encabezadoAsientoContable, dr)
            dr = CType(dsCentralizacion.InsertarEncabezado(dr, asientoContableID), DataAccess.Centralizaciones.RH_REM_ASIENTO_CONTABLERow)
            Return (dr.ASIENTO_CONTABLE_ID)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
    Private Shared Sub asignacionCampos(ByVal asiento As Comun.TiposDeDatos.EEncabezadoAsientoContable, ByRef dr As DataAccess.DSAsientoContable.RH_REM_ASIENTO_CONTABLERow)
        With dr
            .PERIODO_ID = asiento.periodoID
            .ESTADO_REGISTRO = asiento.estadoRegistro
            .TIPO_PROCESO = asiento.tipoProceso
            .ES_COSTO = asiento.esCosto
        End With
    End Sub
    Public Shared Function recuperarAsientoContable(ByVal periodoID As Integer, ByVal tipoProceso As String, ByVal cuentasSoloCosto As Boolean, ByVal estadoPeriodo As Boolean, ByRef asientoContabelID As Integer) As DataView
        Return DataAccess.Centralizaciones.recuperaAsientoContable(periodoID, tipoProceso, cuentasSoloCosto, estadoPeriodo, asientoContabelID)
    End Function
    Public Shared Function recuperarAsientoPresupuesto(ByVal periodoID As Integer, ByVal tipoCalculo As String, ByVal estadoPeriodo As Boolean, ByRef asientoContableID As Integer) As DataView
        Return DataAccess.Centralizaciones.recuperaAsientoPresupuesto(periodoID, tipoCalculo, estadoPeriodo, asientoContableID)
    End Function
    Public Shared Function recuperarDetalleAsientoContable(ByVal asientoContableID As Integer, ByVal ano As Integer, ByVal mes As Integer) As DataSet
        Dim ds As DataSet
        ds = DataAccess.Centralizaciones.recuperarDetalleAsientoContable(asientoContableID, ano, mes)
        Return ds
    End Function
    Public Shared Function procesarAsientoPresupuesto(ByVal periodoID As Integer, ByVal tipoCalculo As String, ByVal estadoPeriodo As Boolean, ByVal usuario As String) As Object
        Return DataAccess.Centralizaciones.procesarAsientoPresupuesto(periodoID, tipoCalculo, estadoPeriodo, usuario)
    End Function
    Public Shared Function generarAsientoPresupuestoHaciaDexon(ByVal periodoID As Integer, ByVal tipoCalculo As String, ByVal mensajeDevuelto As String) As Object
        Return DataAccess.Centralizaciones.generarAsientoPresupuestoHaciaDexon(periodoID, tipoCalculo, mensajeDevuelto)
    End Function
    Public Shared Function enviaHonorarioDexon(ByVal empleadoId As Integer, ByVal año As Integer) As Object
        Return DataAccess.Centralizaciones.enviaHonorarioDexon(empleadoId, año)
    End Function
    Public Shared Function ActualizarTicketDexon(ByVal periodoID As Integer, ByVal tipoCalculo As String, ByVal NroTicketDexon As String) As Object
        Return DataAccess.Centralizaciones.ActualizarTicketDexon(periodoID, tipoCalculo, NroTicketDexon)
    End Function
    Public Shared Function ValidarNumeroCompromisoDexon(ByVal periodoID As Integer, ByVal tipoCalculo As String) As String
        Return DataAccess.Centralizaciones.ValidarNumeroCompromisoDexon(periodoID, tipoCalculo)
    End Function
    Public Shared Function BuscarTicketDexon(ByVal periodoID As Integer, ByVal tipoCalculo As String) As Object
        Return DataAccess.Centralizaciones.BuscarTicketDexon(periodoID, tipoCalculo)
    End Function
End Class






