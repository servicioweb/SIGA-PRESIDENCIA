Imports System.Data.SqlClient
Imports cl.presidencia.Argo.Comun

Public Class Versiones

    Public Function recuperarVersion() As String
        Dim conn As New SqlConnection
        conn.ConnectionString = ArgoConfiguracion.ConnectionString

        Dim mySelectQuery As String = "SELECT CONVERT(VARCHAR(2),MAYOR)+'.'+CONVERT(VARCHAR(2),MINOR)+'.'+CONVERT(VARCHAR(10),BUILD)+'.'+CONVERT(VARCHAR(10),REVISION) AS VERSION FROM RH_GEN_VERSION WHERE(ESTADO = 1)"
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
            'valorString = "1.0.4127.14049"
            'valorString = "1.0.4038.26153"
            'valorString = "1.0.3985.16847"
            Return valorString
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
