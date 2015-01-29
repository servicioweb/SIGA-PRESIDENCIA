Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Office.Interop

Public Class frmCapacitacionesPorEmpleado

    Private Sub LlenaComboUsuarios()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_obtener_usuarios_activos", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)

            lueUsuarios.Properties.DataSource = dt
            lueUsuarios.Properties.ValueMember = "EMPLEADO_ID"
            lueUsuarios.Properties.DisplayMember = "NOMBRES"

            dt.Dispose()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LlenaComboEvaluacionAplicabilidad()
        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_obtener_evaluacion_aplicabilidad", conn)
        Try
            command.CommandType = CommandType.StoredProcedure
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)

            lueEvaluacionAplicabilidad.DataSource = dt
            lueEvaluacionAplicabilidad.ValueMember = "EVALUACION_APLICABILIDAD_ID"
            lueEvaluacionAplicabilidad.DisplayMember = "NOMBRE_EVALUACION_APLICABILIDAD"

            dt.Dispose()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnVerEmpleado_Click(sender As System.Object, e As System.EventArgs) Handles btnVerEmpleado.Click
        If lueUsuarios.EditValue = Nothing Then
            MessageBox.Show("Debe seleccionar un Empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Cursor = Cursors.AppStarting
        Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
        Dim command As New SqlCommand("sp_cap_rpt_obtener_capacitaciones_byEmpleadoID", conn)
        Dim dr As SqlDataReader
        Try
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@empleado_id", lueUsuarios.EditValue)
            conn.Open()

            Dim dt As New DataTable
            dt.Load(command.ExecuteReader)

            gdcCapacitaciones.DataSource = dt

            dt.Dispose()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Dispose()
            command.Dispose()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmCapacitacionesPorEmpleado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LlenaComboUsuarios()
        LlenaComboEvaluacionAplicabilidad()
    End Sub

    Private Sub btnExportarExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarExcel.Click
        Try
            If gdvCapacitaciones.RowCount > 0 Then
                Dim sfd As New SaveFileDialog
                Dim nuevoExcel As String
                sfd.Filter = "Libro de Excel (*.xlsx)|*.xlsx|Libro de Excel 97-2003 (*.xls)|*.xls"
                If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    nuevoExcel = sfd.FileName
                    If Path.GetExtension(nuevoExcel) = ".xls" Then
                        gdcCapacitaciones.ExportToXls(nuevoExcel)
                    ElseIf Path.GetExtension(nuevoExcel) = ".xlsx" Then
                        gdcCapacitaciones.ExportToXlsx(nuevoExcel)
                        'ElseIf Path.GetExtension(nuevoExcel) = ".rtf" Then
                        '    Cursor = Cursors.AppStarting
                        '    Dim conn As New SqlConnection(Comun.ArgoConfiguracion.ConnectionString)
                        '    Dim command As New SqlCommand("sp_cap_rpt_obtener_capacitaciones_byEmpleadoID", conn)
                        '    Try
                        '        command.CommandType = CommandType.StoredProcedure
                        '        command.Parameters.AddWithValue("@empleado_id", lueUsuarios.EditValue)
                        '        conn.Open()

                        '        Dim dt As New DataTable
                        '        dt.Load(command.ExecuteReader)

                        '        Dim app As New Word.Application
                        '        Dim doc As Word.Document = CreateTableWord(app, dt)

                        '        If (Not doc Is Nothing) Then
                        '            With doc
                        '                .SaveAs("C:\Users\ataucare\Documents\Documento1.docx")
                        '                .Close()
                        '            End With
                        '        End If

                        '        ' Cerramos Word y liberamos los recursos asociados.
                        '        '
                        '        app.Quit()
                        '        app = Nothing
                        '    Catch ex As Exception
                        '        MessageBox.Show(ex.Message)
                        '    Finally
                        '        conn.Dispose()
                        '        command.Dispose()
                        '        Cursor = Cursors.Default
                        '    End Try
                        'gdcCapacitaciones.ExportToRtf(nuevoExcel)
                    End If

                    MessageBox.Show("El archivo fue exportado exitosamente", "¡Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function CreateTableWord(ByVal app As Word.Application, _
                                ByVal dt As DataTable) As Word.Document

        '*******************************************************************
        ' Nombre: CreateTableWord
        ' por Enrique Martínez Montejo - 11/02/2007
        '
        ' Versión: 1.0
        '
        ' Finalidad: Crear una tabla en un documento de Word con los datos
        '            existentes en un objeto DataTable.
        ' Entradas:
        '     app:     Word.Application. Referencia al objeto Application que
        '                                se utilizará para crear el documento.
        '
        '     dt:      DataTable. Referencia al objeto DataTable que contiene
        '                         los datos.
        ' Resultados:
        '     Word.Document: Referencia al documento Word creado. Si se
        '                    ha producido una excepción, la función
        '                    devolverá el valor Nothing.
        '*******************************************************************

        ' Si alguno de los parámetros no se encuentra
        ' referenciado, abandonamos la función.
        '
        If ((app Is Nothing) OrElse (dt Is Nothing)) Then Return Nothing

        Dim doc As Word.Document = Nothing

        Try
            ' Número de columnas que tendrá la tabla.
            '
            Dim colsNumbers As Int32 = dt.Columns.Count

            ' Número de filas que tendrá la tabla, que será una
            ' fila más que las existentes en el objeto DataTable,
            ' porque la primera fila la utilizaremos para escribir
            ' el nombre de las columnas.
            '
            Dim rowsNumbers As Int32 = dt.Rows.Count + 1

            Dim oPara1 As Word.Paragraph, oPara2 As Word.Paragraph
            Dim oPara3 As Word.Paragraph, oPara4 As Word.Paragraph

            ' Referenciamos el documento de Word, añadiendo un
            ' nuevo documento a la colección Documents.
            '
            doc = app.Documents.Add()

            'Insert a paragraph at the beginning of the document.
            oPara1 = doc.Content.Paragraphs.Add
            oPara1.Range.Text = "ALGÚN TITULO"
            oPara1.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            oPara1.Range.Font.Bold = True
            oPara1.Range.Font.Size = 24
            oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter()

            'Insert a paragraph at the end of the document.
            '** \endofdoc is a predefined bookmark.
            oPara2 = doc.Content.Paragraphs.Add(doc.Bookmarks.Item("\endofdoc").Range)
            oPara2.Range.Text = "Algún subtitulo que se necesite"
            oPara1.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            oPara1.Range.Font.Size = 11
            oPara2.Format.SpaceAfter = 6
            oPara2.Range.InsertParagraphAfter()

            'Insert another paragraph.
            oPara3 = doc.Content.Paragraphs.Add(doc.Bookmarks.Item("\endofdoc").Range)
            oPara3.Range.Text = "Aquí podría ir alguna descripción de la tabla que se mostrará a continuación. Now here is a table:"
            oPara3.Range.Font.Bold = False
            oPara3.Format.SpaceAfter = 24
            oPara3.Range.InsertParagraphAfter()

            ' Definimos el área del documento de Word, donde crearemos
            ' la tabla. Al no existir todavía carácter alguno, tanto la
            ' posición de los caracteres inicial y final será cero.
            '

            Dim range As Word.Range = doc.Range(0, 0)
            Dim table As Word.Table = doc.Tables.Add(doc.Bookmarks.Item("\endofdoc").Range, rowsNumbers, colsNumbers)
            table.Range.Font.Size = 7
            table.Range.Font.Bold = True
            ' Insertamos los encabezados de columna de la tabla, que
            ' se corresponderán con los nombres de los campos.
            '
            For col As Int32 = 1 To colsNumbers
                Dim cell As Word.Cell = table.Rows(1).Cells(col)
                cell.Range.Text = dt.Columns(col - 1).ColumnName
            Next

            ' Insertamos las filas en la tabla, comenzando por la
            ' fila número 2, ya que la primera fila está ocupada
            ' por el nombre de las columnas.
            '
            table.Range.Font.Bold = False

            For row As Int32 = 2 To table.Rows.Count
                Dim c As Int32 = 0
                For Each cell As Word.Cell In table.Rows(row).Cells
                    ' Insertamos el valor de las celdas.
                    cell.Range.Text = dt.Rows(row - 2).Item(c).ToString
                    c += 1
                Next
            Next

            ' Formateamos la tabla para que se ajuste a su contenido.
            '
            table.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitContent)
            table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
            table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
            table.Borders.OutsideLineWidth = Word.WdLineWidth.wdLineWidth100pt

            ' Devolvemos la referencia al documento que se ha creado.
            '
            Return doc

        Catch ex As Exception
            MessageBox.Show(ex.Message)

            If (Not doc Is Nothing) Then
                ' Indicamos que el documento ya ha sido guardado,
                ' y lo cerramos
                '
                doc.Saved = True
                doc.Close()
            End If

            Return Nothing

        End Try

    End Function
End Class