Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class CargarPictures

    ''' <summary>
    ''' Gets from the server a list of uploaded files into a dataSet
    ''' </summary>
    ''' <param name="ds">The dataset</param>
    ''' <param name="table">The table in the dataset</param>

    Public Shared Sub GetUploadedFiles(ByRef ds As DataSet, ByVal table As String)
        '
        ' The variables required for connecting to the server.
        '
        Dim conn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim da As SqlDataAdapter = Nothing
        ' ----------------------------------------------
        Try
            '
            ' If the table already exists, cleares its content. Else adds a new table.
            '
            If ds.Tables.Contains(table) Then
                ds.Tables(table).Clear()
            Else
                ds.Tables.Add(table)
            End If
            ' ----------------------------------------------
            '
            ' Creates a connection to the database and initilizes the command
            '
            conn = New SqlConnection(ConnectionString())
            cmd = New SqlCommand("sp_getUploadedFiles", conn)
            cmd.CommandType = CommandType.StoredProcedure
            ' ----------------------------------------------
            '
            ' Initializes the DataAdapter used for retrieving the data
            '
            da = New SqlDataAdapter(cmd)
            ' ----------------------------------------------
            '
            ' Opens the connection and populates the dataset
            '
            conn.Open()
            da.Fill(ds, table)
            conn.Close()
            ' ----------------------------------------------
        Catch e As Exception
            '
            ' If an error occurs, we assign null to the result and display the error to the user,
            ' with information about the StackTrace for debugging purposes.
            '
            Console.WriteLine(String.Format("{0} - {1}", e.Message, e.StackTrace))
        End Try
    End Sub

    ''' <summary>
    ''' Uploads a file to the database server.
    ''' </summary>
    ''' <param name="fileName">The filename of the picture to be uploaded</param>
    ''' <returns>The id of the file on the server.</returns>
    Public Function UploadFile(ByVal FileName As String, ByVal fs As Stream, ByVal empleadoId As Integer, ByVal antecedenteCurriId As Integer, ByVal tipoDocumentoId As Integer) As Long
        If (Not File.Exists(FileName)) Then
            Return -1
        End If

        Try
            Dim fi As FileInfo = New FileInfo(FileName)
            Dim temp As Long = fi.Length
            Dim lung As Integer = Convert.ToInt32(temp)
            Dim picture As Byte() = New Byte(lung - 1) {}
            fs.Read(picture, 0, lung)
            fs.Close()
            Dim result As Long = uploadFileToDatabase(picture, fi.Name, empleadoId, antecedenteCurriId, tipoDocumentoId)
            Return result
        Catch e As Exception
            Console.WriteLine(String.Format("{0} - {1}", e.Message, e.StackTrace))
            Return -1
        End Try
    End Function

    ''' <summary>
    ''' Wrapper for downloading a file from a database.
    ''' </summary>
    ''' <param name="kFileName">The Unique ID of the file in database</param>
    ''' <param name="fileName">The file name as it was stored in the database.</param>
    ''' <returns>The byte array required OR null if the ID is not found</returns>
    Public Function DownloadFile(ByVal kFileName As Long, ByRef fileName As String) As Byte()
        Dim result As Byte() = downloadFileFromDatabase(kFileName, fileName)
        Return result
    End Function

    ''' <summary>
    ''' Returns the connection string for connecting to the database
    ''' </summary>
    ''' <returns>The Connection string.</returns>
    Public Shared Function ConnectionString() As String
        Return Argo.Comun.ArgoConfiguracion.ConnectionString
    End Function
    ''' <summary>
    ''' Uploades a file to an SQL Server.
    ''' </summary>
    ''' <param name="picture">A byte array that contains the information to be uploaded.</param>
    ''' <param name="fileName">The file name asociated with that byte array.</param>
    ''' <returns>The unique ID of the file on the server OR -1 if an error occurs. </returns>
    Private Shared Function uploadFileToDatabase(ByVal picture As Byte(), ByVal fileName As String, ByVal empleadoId As Integer, ByVal antecedenteCurriId As Integer, ByVal tipoDocumentoId As Integer) As Long
        '
        ' Defining the variables required for accesing the database server.
        '
        Dim conn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim kFileName As SqlParameter = Nothing
        Dim FileName_Renamed As SqlParameter = Nothing
        Dim pic As SqlParameter = Nothing
        Dim idEmpleado As SqlParameter = Nothing
        Dim idAnteCurri As SqlParameter = Nothing
        Dim idTipoDocumento As SqlParameter = Nothing

        Dim result As Long = -1
        Try

            conn = New SqlConnection(ConnectionString())
            cmd = New SqlCommand("sp_UploadFile", conn) ' We assume there is a stored procedure called UploadFile
            cmd.CommandType = System.Data.CommandType.StoredProcedure

            idEmpleado = New SqlParameter("@EMPLEADO_ID", SqlDbType.Int, 4)
            idEmpleado.Value = empleadoId
            idAnteCurri = New SqlParameter("@ANTECEDENTE_CURRI_ID", SqlDbType.Int, 4)
            idAnteCurri.Value = antecedenteCurriId
            FileName_Renamed = New SqlParameter("@NOMBRE_ARCHIVO", SqlDbType.VarChar, 250)
            FileName_Renamed.Value = fileName
            idTipoDocumento = New SqlParameter("@TIPO_DOCUMENTO_ID", SqlDbType.Int, 4)
            idTipoDocumento.Value = tipoDocumentoId
            pic = New SqlParameter("@PICTURE", SqlDbType.Image)
            pic.Value = picture
            kFileName = New SqlParameter("@BINARIO_ID", System.Data.SqlDbType.BigInt, 4)
            kFileName.Direction = ParameterDirection.Output

            cmd.Parameters.Add(idEmpleado)
            cmd.Parameters.Add(idAnteCurri)
            cmd.Parameters.Add(FileName_Renamed)
            cmd.Parameters.Add(idTipoDocumento)
            cmd.Parameters.Add(pic)
            cmd.Parameters.Add(kFileName)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            result = CLng(kFileName.Value)

            conn.Dispose()
            cmd.Dispose()
        Catch e As Exception
            Console.WriteLine(String.Format("{0} - {1}", e.Message, e.StackTrace))
            result = -1
        End Try
        Return result
    End Function

    ''' <summary>
    ''' Downloades a file from a database according to the unique id in that database.
    ''' </summary>
    ''' <param name="kFile">The ID of the file in the database</param>
    ''' <param name="FileName">The filename of the file as it was stored in the database.</param>
    ''' <returns>A byte array containing the information required.</returns>
    Private Shared Function downloadFileFromDatabase(ByVal kFile As Long, ByRef FileName As String) As Byte()
        Dim conn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim kFileName As SqlParameter = Nothing
        'INSTANT VB NOTE: The local variable fileName was renamed since Visual Basic will not uniquely identify local variables when other local variables have the same name:
        Dim fileName_Renamed As SqlParameter = Nothing
        Dim dr As SqlDataReader = Nothing
        Dim result As Byte() = Nothing
        Try
          
            conn = New SqlConnection(ConnectionString())
            cmd = New SqlCommand("sp_DownloadFile", conn)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
           
            kFileName = New SqlParameter("@BINARIO_ID", System.Data.SqlDbType.BigInt, 8)
            kFileName.Value = kFile
            fileName_Renamed = New SqlParameter("@NOMBRE_ARCHIVO", SqlDbType.VarChar, 250)
            fileName_Renamed.Direction = ParameterDirection.Output
           
            cmd.Parameters.Add(kFileName)
            cmd.Parameters.Add(fileName_Renamed)
           
            conn.Open()
            dr = cmd.ExecuteReader()
            dr.Read()
            
            result = CType(dr.GetValue(0), Byte())
            FileName = CStr(dr.GetValue(1))
           
            dr.Close()
            conn.Close()
           
            conn.Dispose()
            cmd.Dispose()
        Catch e As Exception
            Console.WriteLine(String.Format("{0} - {1}", e.Message, e.StackTrace))
            result = Nothing
        End Try
        Return result
    End Function

End Class
