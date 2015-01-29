Imports cl.presidencia.Argo.DataAccess

Public Class Version
    Dim versionDS As New DataAccess.Versiones

    Public Sub New()
        MyBase.new()
    End Sub

    Public Function recuperaVersion() As String
        Return versionDS.recuperarVersion()
    End Function
End Class
