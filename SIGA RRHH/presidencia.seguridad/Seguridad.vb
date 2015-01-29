Imports System
Imports System.Security.Principal
Imports System.Threading
Imports System.Data
Imports System.DirectoryServices
Imports System.Collections

''' <summary>
'''  Esta clase provee métodos estáticos (que no requieren instancia) 
'''  para conocer los datos del contexto de seguridad donde se ejecuta la aplicación.
''' </summary>
Public Class Seguridad

    ''' <summary>
    ''' Obtiene el nombre del usuario actualmente conectado al dominio.
    ''' 
    ''' </summary>
    Public Shared Function NombreUsuario() As String
        Try
            AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal)
            Dim wp As WindowsPrincipal
            wp = Thread.CurrentPrincipal
            Return wp.Identity.Name()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Retorna valor verdadero o falso para indicar si el usuario activo 
    ''' pertenece a un grupo de usuarios de SIGA, definido en el dominio.
    ''' <example>
    ''' <code> El siguiente ejemplo presenta como es utilizada la función 
    ''' para validar si una cuenta de usuario activa pertenece a un grupo del dominio
    ''' If Not Seguridad.tienePermiso("COM-Mantencion Tablas Maestras Personal") Then
    '''        mnuDepto.Enabled = False
    '''        mnuUbicacion.Enabled = False
    '''        mnuRetiro.Enabled = False
    '''        mnuEstudio.Enabled = False
    ''' 
    '''    Else
    '''        mnuDepto.Enabled = True
    '''        mnuUbicacion.Enabled = True
    '''        mnuRetiro.Enabled = True
    '''        mnuEstudio.Enabled = True
    '''    End If
    '''    mnuMantenedor.Enabled = (mnuDepto.Enabled Or mnuUbicacion.Enabled Or mnuRetiro.Enabled Or mnuEstudio.Enabled)
    ''' </code>
    ''' </example>
    ''' </summary>
    Public Shared Function TienePermiso(ByVal nombreModulo As String) As Boolean
        'Las siguientes linea es para no consdierar el active directory
        If cl.presidencia.Argo.Comun.ArgoConfiguracion.tieneActiveDirectory = "False" Then
            Return True
        End If
        AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal)
        Dim wp As WindowsPrincipal
        wp = Thread.CurrentPrincipal
        Dim userName As String = wp.Identity.Name()
        userName = userName.Substring(userName.LastIndexOf("\") + 1, (userName.Length - 1) - userName.LastIndexOf("\"))
        'userName = "fvega"
        If EsMiembroDelGrupoNT(userName, _
                                                cl.presidencia.Argo.Comun.ArgoConfiguracion.DomainServer, _
                                                cl.presidencia.Argo.Comun.ArgoConfiguracion.WindowsDomain1, _
                                                cl.presidencia.Argo.Comun.ArgoConfiguracion.WindowsDomain2, _
                                                cl.presidencia.Argo.Comun.ArgoConfiguracion.OrganizationalUnit, _
                                                nombreModulo) _
        Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Permite obtener el valor de un atributo definido para una cuenta de Dominio.
    ''' <param name="atributo">Es utilizado para indicar el nombre del atributo</param>
    ''' <returns>Retorna un Object</returns>
    ''' </summary>
    Public Shared Function AtributoCuentaDominio(ByVal atributo As String) As Object
        AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal)
        Dim wp As WindowsPrincipal
        wp = Thread.CurrentPrincipal
        Dim userName As String = wp.Identity.Name()
        userName = userName.Substring(userName.LastIndexOf("\") + 1, (userName.Length - 1) - userName.LastIndexOf("\"))
        Try
            Return AtributoDominioNT(userName, _
                                                            cl.presidencia.Argo.Comun.ArgoConfiguracion.DomainServer, _
                                                            cl.presidencia.Argo.Comun.ArgoConfiguracion.WindowsDomain1, _
                                                            cl.presidencia.Argo.Comun.ArgoConfiguracion.WindowsDomain2, _
                                                            cl.presidencia.Argo.Comun.ArgoConfiguracion.OrganizationalUnit, _
                                                            atributo)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Shared Function EsMiembroDelGrupoNT(ByVal SAMAccountName As String, ByVal Domainserver As String, ByVal Dominio1 As String, ByVal Dominio2 As String, ByVal UnidadOrganizacional As String, ByVal Grupo As String) As Boolean

        'Dim oRoot As New DirectoryEntry("LDAP://" + Domainserver + "/ou=" + UnidadOrganizacional + ", dc=" + Dominio2 + ",dc=" + Dominio1)
        Dim oRoot As New DirectoryEntry("LDAP://dc=" + Dominio2 + ",dc=" + Dominio1)
        Dim oSearcher As DirectorySearcher = New DirectorySearcher(oRoot)
        Dim oResults As SearchResultCollection
        Dim oResult As SearchResult
        Dim RetArray() As Object

        Try

            oSearcher.PropertiesToLoad.Add("uidNumber")
            oSearcher.PropertiesToLoad.Add("givenname")
            oSearcher.PropertiesToLoad.Add("cn")
            oSearcher.PropertiesToLoad.Add("MemberOf")
            oSearcher.Filter = "sAMAccountName=" & SAMAccountName
            oResults = oSearcher.FindAll
            Dim i As Integer = 0
            Dim j As Integer = 0
            For Each oResult In oResults
                If Not oResult.GetDirectoryEntry().Properties("cn").Value = "" Then
                    i = i + 1
                    RetArray = oResult.GetDirectoryEntry().Properties("MemberOf").Value
                End If
            Next
            For i = 0 To RetArray.Length - 1
                If CType(RetArray.GetValue(i), String).IndexOf("CN=" & Grupo) >= 0 Then
                    Return True
                End If
            Next
        Catch ex As Exception
            Throw New Exception("Error de Acceso a Dominio", ex)
        End Try
    End Function

    Private Shared Function AtributoDominioNT(ByVal SAMAccountName As String, ByVal Domainserver As String, ByVal Dominio1 As String, ByVal Dominio2 As String, ByVal UnidadOrganizacional As String, ByVal Atributo As String) As Boolean

        Dim oRoot As New DirectoryEntry("LDAP://" + Domainserver + "/ou=" + UnidadOrganizacional + ", dc=" + Dominio2 + ",dc=" + Dominio1)
        Dim oSearcher As DirectorySearcher = New DirectorySearcher(oRoot)
        Dim oResults As SearchResultCollection
        Dim oResult As SearchResult
        Try
            oSearcher.PropertiesToLoad.Add(Atributo)
            oSearcher.PropertiesToLoad.Add("cn")
            oSearcher.PropertiesToLoad.Add("MemberOf")
            oSearcher.Filter = "sAMAccountName=" & SAMAccountName
            oResults = oSearcher.FindAll
            For Each oResult In oResults
                If Not oResult.GetDirectoryEntry().Properties("cn").Value = "" Then
                    Return oResult.GetDirectoryEntry().Properties(Atributo).Value
                End If
            Next
        Catch ex As Exception
            Throw New Exception("Error de Acceso a Dominio", ex)
        End Try
    End Function

End Class