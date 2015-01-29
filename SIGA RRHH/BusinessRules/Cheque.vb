Option Strict On
Imports System.ComponentModel
Imports cl.presidencia.Argo
Imports cl.presidencia.Argo.Comun
Imports cl.presidencia.Argo.Comun.TiposDeDatos

Public Structure Encabezado
    Dim chequeID As Integer
    Dim motivo As String
    Dim razonSocial As String
    Dim numeroCheque As Integer
    Dim fechaCheque As Date
    Dim numeroEgreso As Integer
    Dim estadoRegistroCheque As Byte
    Dim periodoId As Integer
    Dim OrganizacionId As Integer
    Dim totalCheque As Integer
End Structure

Public Structure Detalle
    Dim detalleChequeID As Integer
    Dim chequeID As Integer
    Dim concepto As String
    Dim monto As Integer
End Structure

Public Class Cheque

    Dim dsCheque As New DataAccess.Cheques
    Public datosEncabezado As Encabezado
    Public datosDetalle As Detalle
    Public tipoEstadoViatico As tipoEstadoViatico

    Public Sub New()
        MyBase.new()
    End Sub

    Public Sub New(ByVal idCheque As Integer)
        MyBase.new()

        Dim dr As DataAccess.DSRegistroCheques.RH_PER_EMISOR_CHEQUERow
        Me.datosEncabezado.chequeID = CType(idCheque, Integer)

        dr = CType(dsCheque.Busca(Me.datosEncabezado.chequeID, Tablas.RH_PER_EMISOR_CHEQUE, "SELECT * FROM " & Tablas.RH_PER_EMISOR_CHEQUE), DataAccess.DSRegistroCheques.RH_PER_EMISOR_CHEQUERow)
        asignacionCampos(dr)
    End Sub

    Public Sub New(ByVal NumeroCheque As Decimal)
        MyBase.new()

        Dim dr As DataAccess.DSRegistroCheques.RH_PER_EMISOR_CHEQUERow

        dr = CType(dsCheque.Busca(CType(NumeroCheque, Integer)), DataAccess.DSRegistroCheques.RH_PER_EMISOR_CHEQUERow)
        asignacionCampos(dr)
    End Sub

    Public Sub New(ByVal idDetalleCheque As Long)
        MyBase.new()

        Dim dr As DataAccess.DSRegistroCheques.RH_PER_EMISOR_CHEQUE_DETALLERow
        Me.datosDetalle.detalleChequeID = CType(idDetalleCheque, Integer)

        dr = CType(dsCheque.Busca(Me.datosDetalle.detalleChequeID, Tablas.RH_PER_EMISOR_CHEQUE_DETALLE, "SELECT * FROM " & Tablas.RH_PER_EMISOR_CHEQUE_DETALLE), DataAccess.DSRegistroCheques.RH_PER_EMISOR_CHEQUE_DETALLERow)
        asignacionCampos(dr)
    End Sub

    Public Function CrearEncabezado() As Long
        Dim dr As DataAccess.DSRegistroCheques.RH_PER_EMISOR_CHEQUERow
        Try
            dr = CType(dsCheque.Tables(Tablas.RH_PER_EMISOR_CHEQUE).NewRow, DataAccess.DSRegistroCheques.RH_PER_EMISOR_CHEQUERow)
            asignacionCampos(Me, dr)
            dr = CType(dsCheque.InsertarEncabezado(dr), DataAccess.Cheques.RH_PER_EMISOR_CHEQUERow)
            Return (dr.EMISOR_CHEQUE_ID)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Function ActualizarEncabezado() As Boolean
        Dim dr As DataAccess.Cheques.RH_PER_EMISOR_CHEQUERow
        Try
            dr = CType(dsCheque.Busca(Me.datosEncabezado.chequeID, Tablas.RH_PER_EMISOR_CHEQUE, "SELECT * FROM " & Tablas.RH_PER_EMISOR_CHEQUE), DataAccess.Cheques.RH_PER_EMISOR_CHEQUERow)
            asignacionCampos(Me, dr)
            dr = CType(dsCheque.ActualizarEncabezado(dr), DataAccess.Cheques.RH_PER_EMISOR_CHEQUERow)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return (False)
        End Try
    End Function

    Public Function CrearDetalle() As Long
        Dim dr As DataAccess.Cheques.RH_PER_EMISOR_CHEQUE_DETALLERow
        Try
            dr = CType(dsCheque.Tables(Tablas.RH_PER_EMISOR_CHEQUE_DETALLE).NewRow, DataAccess.DSRegistroCheques.RH_PER_EMISOR_CHEQUE_DETALLERow)
            asignacionCampos(Me, dr)
            dr = CType(dsCheque.InsertarDetalle(dr), DataAccess.Cheques.RH_PER_EMISOR_CHEQUE_DETALLERow)
            Return (dr.DETALLE_EMISOR_CHEQUE_ID)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function ActualizarDetalle() As Boolean
        Dim dr As DataAccess.Cheques.RH_PER_EMISOR_CHEQUE_DETALLERow
        Try
            dr = CType(dsCheque.Busca(Me.datosDetalle.detalleChequeID, Tablas.RH_PER_EMISOR_CHEQUE_DETALLE, "SELECT * FROM " & Tablas.RH_PER_EMISOR_CHEQUE_DETALLE), DataAccess.Cheques.RH_PER_EMISOR_CHEQUE_DETALLERow)
            asignacionCampos(Me, dr)
            dr = CType(dsCheque.Actualizardetalle(dr), DataAccess.Cheques.RH_PER_EMISOR_CHEQUE_DETALLERow)
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return (False)
        End Try
    End Function
    Public Function EliminaEncabezado() As Boolean
        Try
            Return dsCheque.eliminaEncabezado(Me.datosEncabezado.chequeID)
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function
    Public Function EliminaDetalle() As Boolean
        Try
            Return dsCheque.eliminaDetalle(Me.datosDetalle.detalleChequeID)
        Catch excepcion As Exception
            Throw excepcion
            Return (False)
        End Try
    End Function
    Private Sub asignacionCampos(ByVal dr As DataAccess.Cheques.RH_PER_EMISOR_CHEQUERow)
        If Not dr Is Nothing Then
            Me.datosEncabezado.chequeID = CType(dr("EMISOR_CHEQUE_ID"), Integer)
            Me.datosEncabezado.motivo = CType(dr("MOTIVO"), String)
            Me.datosEncabezado.razonSocial = CType(dr("NOMBRE_RAZON_SOCIAL"), String)
            Me.datosEncabezado.numeroCheque = CType(dr("NUMERO_CHEQUE"), Integer)
            Me.datosEncabezado.fechaCheque = CType(dr("FECHA_CHEQUE"), Date)
            Me.datosEncabezado.numeroEgreso = CType(dr("NUMERO_EGRESO"), Integer)
            Me.datosEncabezado.estadoRegistroCheque = CType(dr("ESTADO_REGISTRO"), Byte)
            Me.datosEncabezado.periodoId = CType(dr("PERIODO_ID"), Integer)
            Me.datosEncabezado.OrganizacionId = CType(dr("ORGANIZACION_ID"), Integer)
            Me.datosEncabezado.totalCheque = CType(dr("TOTAL_CHEQUE"), Integer)
        End If
    End Sub
    Private Sub asignacionCampos(ByVal dr As DataAccess.Cheques.RH_PER_EMISOR_CHEQUE_DETALLERow)
        If Not dr Is Nothing Then
            Me.datosDetalle.detalleChequeID = CType(dr("DETALLE_EMISOR_CHEQUE_ID"), Integer)
            Me.datosDetalle.chequeID = CType(dr("EMISOR_CHEQUE_ID"), Integer)
            Me.datosDetalle.concepto = CType(dr("CONCEPTO"), String)
            Me.datosDetalle.monto = CType(dr("MONTO"), Integer)
        End If
    End Sub
    Private Sub asignacionCampos(ByVal cheque As BusinessRules.Cheque, ByRef dr As DataAccess.Cheques.RH_PER_EMISOR_CHEQUERow)
        With dr
            .MOTIVO = CType(cheque.datosEncabezado.motivo, String)
            .NOMBRE_RAZON_SOCIAL = CType(cheque.datosEncabezado.razonSocial, String)
            .NUMERO_CHEQUE = CType(cheque.datosEncabezado.numeroCheque, Integer)
            .FECHA_CHEQUE = CType(cheque.datosEncabezado.fechaCheque, Date)
            .NUMERO_EGRESO = CType(cheque.datosEncabezado.numeroEgreso, Integer)
            .ESTADO_REGISTRO = CType(cheque.datosEncabezado.estadoRegistroCheque, Byte)
            .PERIODO_ID = CType(cheque.datosEncabezado.periodoId, Integer)
            .ORGANIZACION_ID = CType(cheque.datosEncabezado.OrganizacionId, Integer)
            .TOTAL_CHEQUE = CType(cheque.datosEncabezado.totalCheque, Integer)
        End With
    End Sub
    Private Sub asignacionCampos(ByVal cheque As BusinessRules.Cheque, ByRef dr As DataAccess.Cheques.RH_PER_EMISOR_CHEQUE_DETALLERow)
        With dr
            .CONCEPTO = cheque.datosDetalle.concepto
            .EMISOR_CHEQUE_ID = cheque.datosEncabezado.chequeID
            .MONTO = cheque.datosDetalle.monto
        End With
    End Sub
    Public Function recuperarDetalleCheque(ByVal idCheque As Integer) As DataView
        Return dsCheque.recuperarDetalleCheque(idCheque)
    End Function
    Public Function recuperarChequesAEmitir(ByVal numeroFolio As Integer) As DataView
        Return dsCheque.recuperarChequesAEmitir(numeroFolio)
    End Function
    Public Function buscarNumeroCheque(ByVal numeroCheque As Integer) As String
        Return dsCheque.buscarNumeroCheque(numeroCheque)
    End Function
End Class
