Imports cl.presidencia.Argo.Reportes
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports cl.presidencia.Argo.BusinessRules
Imports System.IO
Imports System.Data.SqlClient
Imports Sign

Public Class frmFiltroLiquidaciones
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()
        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rdgTipoProceso As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents btnPDF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pbPDF As System.Windows.Forms.ProgressBar
    Friend WithEvents chklstDepartamento As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents lblDepartamentos As System.Windows.Forms.Label
    Friend WithEvents lblTipoProceso As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton
        Me.rdgTipoProceso = New DevExpress.XtraEditors.RadioGroup
        Me.btnPDF = New DevExpress.XtraEditors.SimpleButton
        Me.pbPDF = New System.Windows.Forms.ProgressBar
        Me.chklstDepartamento = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.lblDepartamentos = New System.Windows.Forms.Label
        Me.lblTipoProceso = New System.Windows.Forms.Label
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chklstDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.Location = New System.Drawing.Point(8, 24)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(280, 21)
        Me.cboPeriodo.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Período"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(8, 344)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(280, 23)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(8, 256)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(280, 23)
        Me.btnVisualizar.TabIndex = 24
        Me.btnVisualizar.Text = "Visualizar"
        '
        'rdgTipoProceso
        '
        Me.rdgTipoProceso.EditValue = "N"
        Me.rdgTipoProceso.Location = New System.Drawing.Point(8, 208)
        Me.rdgTipoProceso.Name = "rdgTipoProceso"
        '
        'rdgTipoProceso.Properties
        '
        Me.rdgTipoProceso.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("N", "Normal"), New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Suplementario")})
        Me.rdgTipoProceso.Size = New System.Drawing.Size(280, 40)
        Me.rdgTipoProceso.TabIndex = 28
        Me.rdgTipoProceso.ToolTip = "Seleccione Tipo de Cálculo"
        '
        'btnPDF
        '
        Me.btnPDF.Location = New System.Drawing.Point(8, 288)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(282, 23)
        Me.btnPDF.TabIndex = 29
        Me.btnPDF.Text = "Generar Liquidaciones PDF"
        '
        'pbPDF
        '
        Me.pbPDF.Location = New System.Drawing.Point(8, 320)
        Me.pbPDF.Name = "pbPDF"
        Me.pbPDF.Size = New System.Drawing.Size(280, 16)
        Me.pbPDF.TabIndex = 30
        Me.pbPDF.Visible = False
        '
        'chklstDepartamento
        '
        Me.chklstDepartamento.Location = New System.Drawing.Point(8, 64)
        Me.chklstDepartamento.Name = "chklstDepartamento"
        Me.chklstDepartamento.Size = New System.Drawing.Size(280, 120)
        Me.chklstDepartamento.TabIndex = 31
        '
        'lblDepartamentos
        '
        Me.lblDepartamentos.Location = New System.Drawing.Point(8, 48)
        Me.lblDepartamentos.Name = "lblDepartamentos"
        Me.lblDepartamentos.Size = New System.Drawing.Size(100, 16)
        Me.lblDepartamentos.TabIndex = 32
        Me.lblDepartamentos.Text = "Departamentos"
        '
        'lblTipoProceso
        '
        Me.lblTipoProceso.Location = New System.Drawing.Point(8, 192)
        Me.lblTipoProceso.Name = "lblTipoProceso"
        Me.lblTipoProceso.Size = New System.Drawing.Size(100, 16)
        Me.lblTipoProceso.TabIndex = 33
        Me.lblTipoProceso.Text = "Tipo Proceso"
        '
        'frmFiltroLiquidaciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(296, 374)
        Me.Controls.Add(Me.lblTipoProceso)
        Me.Controls.Add(Me.lblDepartamentos)
        Me.Controls.Add(Me.chklstDepartamento)
        Me.Controls.Add(Me.pbPDF)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(Me.rdgTipoProceso)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnVisualizar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFiltroLiquidaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidaciones"
        CType(Me.rdgTipoProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chklstDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private parametroMensual As Periodo

    Private Sub EjecutarQuery(ByVal sqlSTR As String)
        Dim connectionString As String = Comun.ArgoConfiguracion.ConnectionString
        Dim objcommand As New SqlClient.SqlCommand(sqlSTR, New SqlClient.SqlConnection(connectionString))
        objcommand.Connection.Open()
        objcommand.ExecuteNonQuery()
        objcommand.Connection.Close()
        objcommand.Dispose()
        objcommand = Nothing
    End Sub

    Private Sub GenerarReportes(ByVal Empleado As Integer, ByVal Periodo As Integer, ByVal Calculo As String, ByVal Folder As String, ByVal nArchivo As String, ByVal idEmpleado As String, ByVal Mes As String, ByVal Anno As String)

        Try
            Dim cryRpt As New rptLiquidacion
            Dim fileNamePDF As String = Folder & nArchivo
            UtilCrystalReports.UtilReport.setConnection(cryRpt)
            cryRpt.SummaryInfo.ReportTitle = "LIQUIDACIÓN REMUNERACIÓN A " & UCase(parametroMensual.nombrePeriodo)
            cryRpt.RecordSelectionFormula = "{RH_REM_PERIODO.PERIODO_ID}=" & Periodo & " AND {RH_REM_LIQUIDACION_ENC.EMPLEADO_ID}=" & Empleado & " AND {RH_REM_LIQUIDACION_ENC.TIPO_CALCULO}=" & """" & Calculo & """"
            cryRpt.ExportToDisk(ExportFormatType.PortableDocFormat, fileNamePDF)
            cryRpt.Close()
            Dim up As TransferPictures = New TransferPictures
            Dim id As Long = up.UploadFile(fileNamePDF)
            InsertaRMA(id, idEmpleado, Mes, Anno)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub



    Private Sub InsertaRMA(ByVal id As Integer, ByVal idEmpleado As String, ByVal Mes As String, ByVal Anno As String)
        Dim SQLstr As String = "UPDATE ArchivosPDF set rut=" & idEmpleado & ", Mes=" & Mes & ", Anno=" & Anno & " WHERE kFileName=" & id
        EjecutarQuery(SQLstr)
    End Sub

    Function CheckFolderExists(ByVal sFolderName)
        Dim FileSystemObject
        FileSystemObject = CreateObject("Scripting.FileSystemObject")
        If (FileSystemObject.FolderExists(sFolderName)) Then
            CheckFolderExists = True
        Else
            CheckFolderExists = False
        End If
        FileSystemObject = Nothing
    End Function
    Public Function FileExists(ByVal FileFullPath As String) As Boolean
        Dim f As New IO.FileInfo(FileFullPath)
        Return f.Exists
    End Function

    Private Sub frmFiltroLiquidaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        repositorio.Show()
        With chklstDepartamento
            .DisplayMember = "DESCRIPCION"
            .ValueMember = "DEPTO_ID"
            .DataSource = repositorio.dvDepartamentos
            .CheckOnClick = True
            .Refresh()
        End With
        With cboPeriodo
            .DisplayMember = "DESCRIPCION_PERIODO"
            .ValueMember = "PERIODO_ID"
            .DataSource = repositorio.dvPeriodo
            .Refresh()
        End With

    End Sub
    'Función: departamentosSeleccionados
    'Retorna una lista en formato texto y separada por coma
    'de los Ids de departamento almacenados en el sistema.
    Private Function departemantosSeleccionados() As String
        Dim strFiltro As String = ""
        Dim chkItem As System.Data.DataRowView
        For Each chkItem In chklstDepartamento.CheckedItems
            strFiltro = strFiltro + CType(chkItem("DEPTO_ID"), String) + ","
        Next
        If strFiltro.Length > 0 Then
            strFiltro = strFiltro.Substring(0, strFiltro.Length - 1)
        End If
        Return (strFiltro)
    End Function

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        parametroMensual = New Periodo(CType(Me.cboPeriodo.SelectedValue, Integer))
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptLiquidacion
        'Se establece conexión con base de datos.
        WinUI.UtilCrystalReports.UtilReport.setConnection(reporte)
        Dim strFiltroDepartamentos As String = departemantosSeleccionados()
        ventanaReporte1.rptVisor.SelectionFormula = "{RH_REM_PERIODO.PERIODO_ID}=" & Me.cboPeriodo.SelectedValue & " AND {RH_REM_LIQUIDACION_ENC.TIPO_CALCULO}=" & """" & CType(rdgTipoProceso.EditValue, String) & """"
        If departemantosSeleccionados().Length > 0 Then
            ventanaReporte1.rptVisor.SelectionFormula += " AND {VW_PER_ANTECEDENTE_LABORAL_ACTIVOS.DEPTO_ID} in [" & strFiltroDepartamentos & "]"
        End If

        ventanaReporte1.rptVisor.ShowParameterPanelButton = False
        ventanaReporte1.rptVisor.ShowCloseButton = False
        ventanaReporte1.rptVisor.ShowGroupTreeButton = False
        reporte.SummaryInfo.ReportTitle = "LIQUIDACIÓN REMUNERACIÓN A " & UCase(parametroMensual.nombrePeriodo)
        ventanaReporte1.rptVisor.ReportSource = reporte
        ventanaReporte1.Show()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPDF.Click
        parametroMensual = New Periodo(CType(Me.cboPeriodo.SelectedValue, Integer))
        Dim ventanaReporte1 As New ventanaReporte
        Dim reporte As New rptLiquidacion
        Dim EmpleadoID As Integer
        Dim PeriodoID As Integer
        Dim TipoCalculo As String
        Dim rc As Integer = 0
        Dim NombreArchivo As String
        'Dim DiskOpts As CrystalDecisions.Shared.DiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
        Dim folder As String = System.IO.Path.GetTempPath()
        folder = folder & "\Documentos PDF\"
        If CheckFolderExists(folder) = False Then
            System.IO.Directory.CreateDirectory(folder)
        End If

        If MsgBox("Este proceso puede tardar varios minutos. ¿Desea continuar?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim myConnection As SqlConnection
            Dim myCommand As SqlCommand
            Dim dr As SqlDataReader
            Dim Errores As Integer = 0
            Dim RecordCount As Integer = 0
            Dim CurrentRecord As Integer = 0
            Dim Porcentaje As Integer = 0
            Try
                btnPDF.Enabled = False
                pbPDF.Visible = True
                myConnection = New SqlConnection(cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString)
                myConnection.Open()
                myCommand = New SqlCommand("SELECT * FROM VW_LIQUIDACIONES_INTRANET WHERE PERIODO_ID=" & Me.cboPeriodo.SelectedValue & " AND TIPO_CALCULO='" & CType(rdgTipoProceso.EditValue, String) & "'", myConnection) ' AND EMPLEADO_ID IN (1, 8, 15) AND EMPLEADO_ID IN (1, 8, 15, 19, 31)

                dr = myCommand.ExecuteReader
                Do
                    While dr.Read()
                        RecordCount = RecordCount + 1
                    End While
                    Me.pbPDF.Maximum = RecordCount
                    Me.pbPDF.Minimum = 0

                Loop While dr.NextResult()
                dr.Close()
                dr = myCommand.ExecuteReader
                Do
                    While dr.Read()

                        EmpleadoID = dr("EMPLEADO_ID")
                        PeriodoID = dr("PERIODO_ID")
                        TipoCalculo = dr("TIPO_CALCULO")
                        NombreArchivo = "R" & dr("RUT") & "M" & dr("MES") & "A" & dr("ANO") & "T" & TipoCalculo & ".PDF"
                        GenerarReportes(EmpleadoID, PeriodoID, TipoCalculo, folder, NombreArchivo, dr("RUT"), dr("MES"), dr("ANO"))
                        If System.IO.File.Exists(folder & NombreArchivo) Then
                            System.IO.File.Delete(folder & NombreArchivo)
                        End If
                        CurrentRecord = CurrentRecord + 1
                        Me.pbPDF.Value = CurrentRecord
                        Porcentaje = ((pbPDF.Value / pbPDF.Maximum) * 100)
                        Me.Text = "Liquidaciones [" & Porcentaje & "% Completado]"
                    End While
                Loop While dr.NextResult()

                btnPDF.Enabled = True
                pbPDF.Visible = False
                Me.Text = "Liquidaciones"
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            dr.Close()
            myConnection.Close()



        End If


    End Sub
End Class

Public Class TransferPictures
    ''' <summary>
    ''' Gets from the server a list of uploaded files into a dataSet
    ''' </summary>
    ''' <param name="ds">The dataset</param>
    ''' <param name="table">The table in the dataset</param>

    Public Sub GetUploadedFiles(ByRef ds As DataSet, ByVal table As String)
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
            cmd = New SqlCommand("getUploadedFiles", conn)
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
            Console.WriteLine(e.Message & " - " & e.StackTrace)
        End Try
    End Sub
    ''' <summary>
    ''' Uploads a file to the database server.
    ''' </summary>
    ''' <param name="fileName">The filename of the picture to be uploaded</param>
    ''' <returns>The id of the file on the server.</returns>
    Public Function UploadFile(ByVal FileName As String) As Long
        If (Not File.Exists(FileName)) Then
            Return -1
        End If
        Dim fs As FileStream = Nothing
        Try


            '#Region "Reading file"
            fs = New FileStream(FileName, FileMode.Open)
            '
            ' Finding out the size of the file to be uploaded
            '
            Dim fi As FileInfo = New FileInfo(FileName)
            Dim temp As Long = fi.Length
            Dim lung As Integer = Convert.ToInt32(temp)
            ' ------------------------------------------
            '
            ' Reading the content of the file into an array of bytes.
            '
            Dim picture As Byte() = New Byte(lung - 1) {}
            fs.Read(picture, 0, lung)
            fs.Close()
            ' ------------------------------------------
            '#End Region
            Dim result As Long = uploadFileToDatabase(picture, fi.Name)
            Return result
        Catch e As Exception
            Console.WriteLine(e.Message & " - " & e.StackTrace)
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
        '
        ' We consider that the database is situated on the same computer that runs the program.
        ' To connect to a remote server, replace 'Data Source' with the name of that server.
        '
        Return cl.presidencia.Argo.Comun.ArgoConfiguracion.ConnectionString
        '.........You can also use........
        'Dim Conn As String = "Server=.;uid=sa;pwd=;database=Pictures"
        'Return Conn
    End Function
    ''' <summary>
    ''' Uploades a file to an SQL Server.
    ''' </summary>
    ''' <param name="picture">A byte array that contains the information to be uploaded.</param>
    ''' <param name="fileName">The file name asociated with that byte array.</param>
    ''' <returns>The unique ID of the file on the server OR -1 if an error occurs. </returns>
    Private Function uploadFileToDatabase(ByVal picture As Byte(), ByVal fileName As String) As Long
        '
        ' Defining the variables required for accesing the database server.
        '
        Dim conn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim kFileName As SqlParameter = Nothing
        'INSTANT VB NOTE: The local variable FileName was renamed since Visual Basic will not uniquely identify local variables when other local variables have the same name:
        Dim FileName_Renamed As SqlParameter = Nothing
        Dim pic As SqlParameter = Nothing
        ' By default, we assume we have an error. If we succed in uploading the file, we'll change this 
        ' to the unique id of the file
        Dim result As Long = -1
        Try
            '
            ' Connecting to database.
            '
            conn = New SqlConnection(ConnectionString())
            cmd = New SqlCommand("UploadFile", conn) ' We assume there is a stored procedure called UploadFile
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            ' ----------------------------------------------
            '
            ' Initializing parameters and assigning the values to be sent to the server
            '
            kFileName = New SqlParameter("@kFileName", System.Data.SqlDbType.BigInt, 4)
            kFileName.Direction = ParameterDirection.Output
            ' This parameter does not have a size because we do not know what the size is going to be.
            pic = New SqlParameter("@picture", SqlDbType.Image)
            pic.Value = picture
            FileName_Renamed = New SqlParameter("@FileName", SqlDbType.VarChar, 250)
            FileName_Renamed.Value = fileName
            ' ----------------------------------------------
            '
            ' Adding the parameters to the database. Remember that the order in which the parameters 
            ' are added is VERY important!
            '
            cmd.Parameters.Add(pic)
            cmd.Parameters.Add(FileName_Renamed)
            cmd.Parameters.Add(kFileName)
            ' ----------------------------------------------
            '
            ' Opening the connection and executing the command.
            '
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            ' ----------------------------------------------
            '
            ' The result is the unique identifier created on the database.
            '
            result = CLng(kFileName.Value)
            ' ----------------------------------------------
            '
            ' Disposing of the objects so we don't occupy memory.
            '
            conn.Dispose()
            cmd.Dispose()
            ' ----------------------------------------------
        Catch e As Exception
            '
            ' If an error occurs, we report it to the user, with StackTrace for debugging purposes
            '
            Console.WriteLine(e.Message & " - " & e.StackTrace)
            result = -1
            ' ----------------------------------------------
        End Try
        Return result
    End Function

    ''' <summary>
    ''' Downloades a file from a database according to the unique id in that database.
    ''' </summary>
    ''' <param name="kFile">The ID of the file in the database</param>
    ''' <param name="FileName">The filename of the file as it was stored in the database.</param>
    ''' <returns>A byte array containing the information required.</returns>
    Private Function downloadFileFromDatabase(ByVal kFile As Long, ByRef FileName As String) As Byte()
        Dim conn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim kFileName As SqlParameter = Nothing
        'INSTANT VB NOTE: The local variable fileName was renamed since Visual Basic will not uniquely identify local variables when other local variables have the same name:
        Dim fileName_Renamed As SqlParameter = Nothing
        Dim dr As SqlDataReader = Nothing
        Dim result As Byte() = Nothing
        Try
            '
            ' Connecting to database.
            '
            conn = New SqlConnection(ConnectionString())
            cmd = New SqlCommand("DownloadFile", conn)
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            ' ----------------------------------------------
            '
            ' Initializing parameters and assigning the values to be sent to the server
            '
            kFileName = New SqlParameter("@kFileName", System.Data.SqlDbType.BigInt, 8)
            kFileName.Value = kFile
            fileName_Renamed = New SqlParameter("@FileName", SqlDbType.VarChar, 250)
            fileName_Renamed.Direction = ParameterDirection.Output
            ' ----------------------------------------------
            '
            ' Adding the parameters to the database. Remember that the order in which the parameters 
            ' are added is VERY important!
            '
            cmd.Parameters.Add(kFileName)
            cmd.Parameters.Add(fileName_Renamed)
            ' ----------------------------------------------
            '
            ' Opening the connection and executing the command.
            ' The idea behind using a dataReader is that, on the SQL Server, we cannot assign to a
            ' variable the value of an image field. So, we use a querry to select the record we want 
            ' and we use a datareader to read that query.
            ' Because we are returnig information based on a primary key, we are always returning
            ' only one row of data.
            '
            conn.Open()
            dr = cmd.ExecuteReader()
            dr.Read()
            '
            ' We are casting the value returned by the datareader to the byte[] data type.
            '
            result = CType(dr.GetValue(0), Byte())
            '
            ' We are also returning the filename associated with the byte array.
            '
            FileName = CStr(dr.GetValue(1))
            '
            ' Closing the datareader and the connection
            '
            dr.Close()
            conn.Close()
            ' ------------------------------------------
            '
            ' Disposing of the objects so we don't occupy memory.
            '
            conn.Dispose()
            cmd.Dispose()
            ' ------------------------------------------
        Catch e As Exception
            '
            ' If an error occurs, we assign null to the result and display the error to the user,
            ' with information about the StackTrace for debugging purposes.
            '
            Console.WriteLine(e.Message & " - " & e.StackTrace)
            result = Nothing
        End Try
        Return result
    End Function


End Class
