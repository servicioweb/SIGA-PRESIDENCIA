Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Module UtilCrystalReports
''' ----------------------------------------------------------
''' Proyect : SIGA
''' Class: UtilCrystalReports
''' 
''' ----------------------------------------------------------
    ''' <summary>    
    '''     ''' La clase UtilReport provee los métodos para confgiurar correcta generación de reportes generados con Crsytal Reports. 
    ''' </summary>
    ''' <history>
    '''                 [ssepulveda]     10/06/2007  Creada
    '''                 [ssepulveda]     04/08/2008  Modificado
    ''' </history>

    Public Class UtilReport
    ''' <summary>    
        ''' Establece la conexión a la fuente de datos de origen de los datos.
    ''' </summary>
        Public Shared Sub setConnection(ByRef reporte As CrystalDecisions.CrystalReports.Engine.ReportClass)
            Dim crTable As CrystalDecisions.CrystalReports.Engine.Table
            Dim crConnInfo As New CrystalDecisions.Shared.ConnectionInfo
            Dim crLogOnInfo As CrystalDecisions.Shared.TableLogOnInfo
            Dim databaseName As String = cl.presidencia.Argo.Comun.ArgoConfiguracion.databaseName
            Dim serverName As String = cl.presidencia.Argo.Comun.ArgoConfiguracion.hostName

            For Each crTable In reporte.Database.Tables

                crConnInfo.ServerName = serverName
                crConnInfo.DatabaseName = databaseName
                'crConnInfo.UserID = Usuario
                'crConnInfo.Password = Contraseña
                crConnInfo.IntegratedSecurity = True
                crLogOnInfo = crTable.LogOnInfo
                crLogOnInfo.ConnectionInfo = crConnInfo
                crTable.ApplyLogOnInfo(crLogOnInfo)
                'crTable.LogOnInfo.ConnectionInfo.Password = Contraseña
                crTable.LogOnInfo.ConnectionInfo.IntegratedSecurity = True
                If crTable.Location.LastIndexOf(".") > 0 Then
                    crTable.Location = databaseName + ".dbo." + crTable.Location.Substring(crTable.Location.LastIndexOf(".") + 1)
                Else
                    crTable.Location = databaseName & ".dbo." & crTable.Name
                End If

            Next


        End Sub

        Public Shared Sub setConnectionOLD(ByRef reporte As CrystalDecisions.CrystalReports.Engine.ReportClass)
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table

            Dim baseDeDatos As String = cl.presidencia.Argo.Comun.ArgoConfiguracion.databaseName
            Dim hostName As String = cl.presidencia.Argo.Comun.ArgoConfiguracion.hostName
            CrTables = reporte.Database.Tables
            For Each CrTable In CrTables

                crtableLogoninfo = CrTable.LogOnInfo

                'Lee NombredeMáquina\NombreDeInstamncia,detalles de base de datos desde la interfaz de usuario
                'y carga estos en el objeto crConnectionInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                'CrTable.ApplyLogOnInfo(crtableLogoninfo)
                'Se establecen los datos de conexión a la conexión global de reporte
                crConnectionInfo.ServerName = hostName
                crConnectionInfo.DatabaseName = baseDeDatos
                crConnectionInfo.IntegratedSecurity = True
                'Se establecen los datos de conexión a la tabla
                crtableLogoninfo.ConnectionInfo.DatabaseName = baseDeDatos
                crtableLogoninfo.ConnectionInfo.ServerName = hostName
                'Se aplican los cambios.
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
                Try
                    'Si existe un punto "." entonces se ha especificado nombre calificado.
                    If CrTable.Location.LastIndexOf(".") > 0 Then
                        CrTable.Location = baseDeDatos + ".dbo." + CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
                    Else
                        CrTable.Location = baseDeDatos & ".dbo." & CrTable.Name
                    End If
                Catch ex As Exception
                    Debug.WriteLine("Error al intentar establecer la localización del objeto " + ex.Message)
                End Try
                'Try
                '    MsgBox(CrTable.Name + CrTable.TestConnectivity())
                'Catch ex As Exception

                'End Try
            Next CrTable
        End Sub

    End Class

    Public Class CrystalToPDFConverter
        Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim oRDoc As New ReportDocument
        Dim expo As New ExportOptions
        Dim sRecSelFormula As String
        Dim oDfDopt As New DiskFileDestinationOptions
        Dim strCrystalReportFilePath As String
        Dim strPdfFileDestinationPath As String

        Public Sub SetCrystalReportFilePath(ByVal CrystalReportFileNameFullPath As String)
            strCrystalReportFilePath = CrystalReportFileNameFullPath
        End Sub

        Public Sub SetPdfDestinationFilePath(ByVal pdfFileNameFullPath As String)
            strPdfFileDestinationPath = pdfFileNameFullPath
        End Sub

        Public Sub SetRecordSelectionFormula(ByVal recSelFormula As String)
            sRecSelFormula = recSelFormula
        End Sub

        Public Sub Transfer()
            oRDoc.Load(strCrystalReportFilePath) 'loads the crystalreports in to the memory
            oRDoc.RecordSelectionFormula = sRecSelFormula 'used if u want pass the query to u r crystal form
            oDfDopt.DiskFileName = strPdfFileDestinationPath 'path of file where u want to locate ur PDF
            expo = oRDoc.ExportOptions
            expo.ExportDestinationType = ExportDestinationType.DiskFile
            expo.ExportFormatType = ExportFormatType.PortableDocFormat
            expo.DestinationOptions = oDfDopt
            oRDoc.SetDatabaseLogon("PaySquare", "paysquare") 'login for your DataBase
            oRDoc.Export()
        End Sub
    End Class


End Module


