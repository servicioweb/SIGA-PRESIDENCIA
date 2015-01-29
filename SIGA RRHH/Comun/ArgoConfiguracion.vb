'----------------------------------------------------------------
' Copyright (C) 200 Presidencia de la República de Chile
' Dirección de Informática
' División de Desarrollo Tecnológico
' All rights reserved.
' 
'----------------------------------------------------------------
Public Class ArgoConfiguracion
    Private Shared _userName As String
    Private Shared _password As String
    Private Shared _hostName As String
    Private Shared _databaseName As String
    Private Shared _DomainName1 As String
    Private Shared _DomainName2 As String
    Private Shared _OrganizationalUnit As String
    Private Shared _DomainServer As String
    Private Shared _applicationName As String
    Private Shared _tieneActiveDirectory As String
    Private Shared ReadOnly fieldOrganizacionID As Short = 1 'ID de la Institucion
    Public Shared ConnectionTimeout As Short = 15
    Public Shared CommandTimeout As Short = 15

    Public Shared ReadOnly Property ConnectionString() As String
        Get
            _userName = Configuration.ConfigurationManager.AppSettings.Get("username")
            _password = Configuration.ConfigurationManager.AppSettings.Get("password")
            _hostName = Configuration.ConfigurationManager.AppSettings.Get("hostname")
            _databaseName = Configuration.ConfigurationManager.AppSettings.Get("databaseName")
            _DomainName1 = Configuration.ConfigurationManager.AppSettings.Get("Windows Domain 1")
            _DomainName2 = Configuration.ConfigurationManager.AppSettings.Get("Windows Domain 2")
            _OrganizationalUnit = Configuration.ConfigurationManager.AppSettings.Get("Organizational Unit")
            _DomainServer = Configuration.ConfigurationManager.AppSettings.Get("Domain Server")
            _applicationName = "SIGA RRHH"
            _tieneActiveDirectory = Configuration.ConfigurationManager.AppSettings.Get("TieneActiveDirectory")
            ConnectionString = IIf(Configuration.ConfigurationManager.AppSettings.Get("integratedSecurity") = "True", "Application Name=" & _applicationName & ";Integrated Security=SSPI;Connect Timeout=2000;Initial Catalog=" & _databaseName & ";Data Source=" & _hostName & ";", "Initial Catalog=" & _databaseName & ";Data Source=" & _hostName & ";")
        End Get
    End Property

    Public Shared ReadOnly Property DomainServer() As String
        Get
            Return (_DomainServer)
        End Get
    End Property

    Public Shared ReadOnly Property OrganizationalUnit() As String
        Get
            Return (_OrganizationalUnit)
        End Get
    End Property

    Public Shared ReadOnly Property WindowsDomain1() As String
        Get
            Return (_DomainName1)
        End Get
    End Property

    Public Shared ReadOnly Property WindowsDomain2() As String
        Get
            Return (_DomainName2)
        End Get
    End Property

    Public Shared ReadOnly Property OrganizacionID() As Integer
        Get
            Return (fieldOrganizacionID)
        End Get
    End Property

    Public Shared ReadOnly Property UserName() As String
        Get
            Return _userName
        End Get
    End Property

    Public Shared ReadOnly Property Password() As String
        Get
            Return _password
        End Get
    End Property

    Public Shared ReadOnly Property hostName() As String
        Get
            Return _hostName
        End Get
    End Property

    Public Shared ReadOnly Property databaseName() As String
        Get
            Return _databaseName
        End Get
    End Property
    Public Shared ReadOnly Property applicationName() As String
        Get
            Return _applicationName
        End Get
    End Property
    Public Shared ReadOnly Property tieneActiveDirectory() As String
        Get
            Return _tieneActiveDirectory
        End Get
    End Property

End Class
