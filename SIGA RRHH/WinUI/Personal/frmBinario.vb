Imports cl.presidencia.Argo.BusinessRules
Imports cl.presidencia.Argo.Comun
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.IO

Public Class frmBinario
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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtNombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNombres As System.Windows.Forms.Label
    Friend WithEvents gdcBinario As DevExpress.XtraGrid.GridControl
    Friend WithEvents colBINARIO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colANTECEDENTE_CURRI_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_ARCHIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSUARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_ACTUALIZACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDescargar As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colDESCARGAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colELIMINAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblNombreArchivo As System.Windows.Forms.Label
    Friend WithEvents txtNombreArchivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnBuscarArchivo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lueTipoDocumento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblTipoDocumento As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnRegresar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gdvDetalleBinario As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTIPO_DOCUMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnRegresar = New DevExpress.XtraEditors.SimpleButton
        Me.lblTipoDocumento = New System.Windows.Forms.Label
        Me.lueTipoDocumento = New DevExpress.XtraEditors.LookUpEdit
        Me.btnBuscarArchivo = New DevExpress.XtraEditors.SimpleButton
        Me.txtNombreArchivo = New DevExpress.XtraEditors.TextEdit
        Me.lblNombreArchivo = New System.Windows.Forms.Label
        Me.txtNombres = New DevExpress.XtraEditors.TextEdit
        Me.lblNombres = New System.Windows.Forms.Label
        Me.gdcBinario = New DevExpress.XtraGrid.GridControl
        Me.gdvDetalleBinario = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colBINARIO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colANTECEDENTE_CURRI_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDESCARGAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnDescargar = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.colELIMINAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnEliminar = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.colNOMBRE_ARCHIVO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTIPO_DOCUMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSUARIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_ACTUALIZACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.lueTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreArchivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdcBinario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleBinario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDescargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.btnRegresar)
        Me.GroupControl1.Controls.Add(Me.lblTipoDocumento)
        Me.GroupControl1.Controls.Add(Me.lueTipoDocumento)
        Me.GroupControl1.Controls.Add(Me.btnBuscarArchivo)
        Me.GroupControl1.Controls.Add(Me.txtNombreArchivo)
        Me.GroupControl1.Controls.Add(Me.lblNombreArchivo)
        Me.GroupControl1.Controls.Add(Me.txtNombres)
        Me.GroupControl1.Controls.Add(Me.lblNombres)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(888, 136)
        Me.GroupControl1.TabIndex = 46
        Me.GroupControl1.Text = "Empleado"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(592, 96)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(88, 23)
        Me.btnRegresar.TabIndex = 56
        Me.btnRegresar.Text = "Volver"
        '
        'lblTipoDocumento
        '
        Me.lblTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDocumento.Location = New System.Drawing.Point(24, 100)
        Me.lblTipoDocumento.Name = "lblTipoDocumento"
        Me.lblTipoDocumento.Size = New System.Drawing.Size(96, 16)
        Me.lblTipoDocumento.TabIndex = 54
        Me.lblTipoDocumento.Text = "Tipo Documento"
        Me.lblTipoDocumento.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lueTipoDocumento
        '
        Me.lueTipoDocumento.Location = New System.Drawing.Point(128, 96)
        Me.lueTipoDocumento.Name = "lueTipoDocumento"
        '
        'lueTipoDocumento.Properties
        '
        Me.lueTipoDocumento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTipoDocumento.Size = New System.Drawing.Size(456, 20)
        Me.lueTipoDocumento.TabIndex = 53
        '
        'btnBuscarArchivo
        '
        Me.btnBuscarArchivo.Location = New System.Drawing.Point(592, 61)
        Me.btnBuscarArchivo.Name = "btnBuscarArchivo"
        Me.btnBuscarArchivo.Size = New System.Drawing.Size(32, 23)
        Me.btnBuscarArchivo.TabIndex = 52
        Me.btnBuscarArchivo.Text = "..."
        '
        'txtNombreArchivo
        '
        Me.txtNombreArchivo.Location = New System.Drawing.Point(128, 64)
        Me.txtNombreArchivo.Name = "txtNombreArchivo"
        '
        'txtNombreArchivo.Properties
        '
        Me.txtNombreArchivo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreArchivo.Properties.MaxLength = 30
        Me.txtNombreArchivo.Size = New System.Drawing.Size(456, 20)
        Me.txtNombreArchivo.TabIndex = 51
        '
        'lblNombreArchivo
        '
        Me.lblNombreArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreArchivo.Location = New System.Drawing.Point(24, 68)
        Me.lblNombreArchivo.Name = "lblNombreArchivo"
        Me.lblNombreArchivo.Size = New System.Drawing.Size(96, 16)
        Me.lblNombreArchivo.TabIndex = 50
        Me.lblNombreArchivo.Text = "Nombre Archivo"
        Me.lblNombreArchivo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(128, 36)
        Me.txtNombres.Name = "txtNombres"
        '
        'txtNombres.Properties
        '
        Me.txtNombres.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombres.Properties.MaxLength = 30
        Me.txtNombres.Size = New System.Drawing.Size(456, 20)
        Me.txtNombres.TabIndex = 48
        '
        'lblNombres
        '
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.Location = New System.Drawing.Point(24, 40)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(96, 16)
        Me.lblNombres.TabIndex = 49
        Me.lblNombres.Text = "Nombres"
        Me.lblNombres.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gdcBinario
        '
        '
        'gdcBinario.EmbeddedNavigator
        '
        Me.gdcBinario.EmbeddedNavigator.Name = ""
        Me.gdcBinario.Location = New System.Drawing.Point(0, 136)
        Me.gdcBinario.MainView = Me.gdvDetalleBinario
        Me.gdcBinario.Name = "gdcBinario"
        Me.gdcBinario.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnDescargar, Me.btnEliminar})
        Me.gdcBinario.Size = New System.Drawing.Size(888, 280)
        Me.gdcBinario.TabIndex = 47
        Me.gdcBinario.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleBinario})
        '
        'gdvDetalleBinario
        '
        Me.gdvDetalleBinario.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBINARIO_ID, Me.colEMPLEADO_ID, Me.colANTECEDENTE_CURRI_ID, Me.colDESCARGAR, Me.colELIMINAR, Me.colNOMBRE_ARCHIVO, Me.colTIPO_DOCUMENTO, Me.colUSUARIO, Me.colFECHA_ACTUALIZACION})
        Me.gdvDetalleBinario.GridControl = Me.gdcBinario
        Me.gdvDetalleBinario.Name = "gdvDetalleBinario"
        Me.gdvDetalleBinario.OptionsView.ColumnAutoWidth = False
        Me.gdvDetalleBinario.OptionsView.ShowGroupPanel = False
        '
        'colBINARIO_ID
        '
        Me.colBINARIO_ID.Caption = "Binario ID"
        Me.colBINARIO_ID.FieldName = "BINARIO_ID"
        Me.colBINARIO_ID.Name = "colBINARIO_ID"
        Me.colBINARIO_ID.OptionsColumn.AllowEdit = False
        Me.colBINARIO_ID.OptionsColumn.AllowMove = False
        Me.colBINARIO_ID.OptionsColumn.ReadOnly = True
        '
        'colEMPLEADO_ID
        '
        Me.colEMPLEADO_ID.Caption = "Emplado ID"
        Me.colEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.colEMPLEADO_ID.Name = "colEMPLEADO_ID"
        Me.colEMPLEADO_ID.OptionsColumn.AllowEdit = False
        Me.colEMPLEADO_ID.OptionsColumn.AllowMove = False
        Me.colEMPLEADO_ID.OptionsColumn.ReadOnly = True
        '
        'colANTECEDENTE_CURRI_ID
        '
        Me.colANTECEDENTE_CURRI_ID.Caption = "Antecedente Curr.ID"
        Me.colANTECEDENTE_CURRI_ID.FieldName = "ANTECEDENTE_CURRI_ID"
        Me.colANTECEDENTE_CURRI_ID.Name = "colANTECEDENTE_CURRI_ID"
        Me.colANTECEDENTE_CURRI_ID.OptionsColumn.AllowEdit = False
        Me.colANTECEDENTE_CURRI_ID.OptionsColumn.AllowMove = False
        Me.colANTECEDENTE_CURRI_ID.OptionsColumn.ReadOnly = True
        '
        'colDESCARGAR
        '
        Me.colDESCARGAR.Caption = "Descargar"
        Me.colDESCARGAR.ColumnEdit = Me.btnDescargar
        Me.colDESCARGAR.FieldName = "DESCARGAR"
        Me.colDESCARGAR.Name = "colDESCARGAR"
        Me.colDESCARGAR.Visible = True
        Me.colDESCARGAR.VisibleIndex = 0
        '
        'btnDescargar
        '
        Me.btnDescargar.AutoHeight = False
        Me.btnDescargar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Descargar", -1, True, True, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.btnDescargar.Name = "btnDescargar"
        Me.btnDescargar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colELIMINAR
        '
        Me.colELIMINAR.Caption = "Eliminar"
        Me.colELIMINAR.ColumnEdit = Me.btnEliminar
        Me.colELIMINAR.FieldName = "ELIMINAR"
        Me.colELIMINAR.Name = "colELIMINAR"
        Me.colELIMINAR.Visible = True
        Me.colELIMINAR.VisibleIndex = 1
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoHeight = False
        Me.btnEliminar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Eliminar", -1, True, True, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colNOMBRE_ARCHIVO
        '
        Me.colNOMBRE_ARCHIVO.Caption = "Nombre Archivo"
        Me.colNOMBRE_ARCHIVO.FieldName = "NOMBRE_ARCHIVO"
        Me.colNOMBRE_ARCHIVO.Name = "colNOMBRE_ARCHIVO"
        Me.colNOMBRE_ARCHIVO.OptionsColumn.AllowEdit = False
        Me.colNOMBRE_ARCHIVO.OptionsColumn.ReadOnly = True
        Me.colNOMBRE_ARCHIVO.Visible = True
        Me.colNOMBRE_ARCHIVO.VisibleIndex = 2
        Me.colNOMBRE_ARCHIVO.Width = 318
        '
        'colTIPO_DOCUMENTO
        '
        Me.colTIPO_DOCUMENTO.Caption = "Tipo Documento"
        Me.colTIPO_DOCUMENTO.FieldName = "TIPO_DOCUMENTO"
        Me.colTIPO_DOCUMENTO.Name = "colTIPO_DOCUMENTO"
        Me.colTIPO_DOCUMENTO.OptionsColumn.AllowEdit = False
        Me.colTIPO_DOCUMENTO.OptionsColumn.ReadOnly = True
        Me.colTIPO_DOCUMENTO.Visible = True
        Me.colTIPO_DOCUMENTO.VisibleIndex = 3
        Me.colTIPO_DOCUMENTO.Width = 192
        '
        'colUSUARIO
        '
        Me.colUSUARIO.Caption = "Usuario"
        Me.colUSUARIO.FieldName = "USUARIO"
        Me.colUSUARIO.Name = "colUSUARIO"
        Me.colUSUARIO.OptionsColumn.AllowEdit = False
        Me.colUSUARIO.OptionsColumn.AllowMove = False
        Me.colUSUARIO.OptionsColumn.ReadOnly = True
        Me.colUSUARIO.Visible = True
        Me.colUSUARIO.VisibleIndex = 4
        Me.colUSUARIO.Width = 95
        '
        'colFECHA_ACTUALIZACION
        '
        Me.colFECHA_ACTUALIZACION.Caption = "Fecha Actualización"
        Me.colFECHA_ACTUALIZACION.FieldName = "FECHA_ACTUALIZACION"
        Me.colFECHA_ACTUALIZACION.Name = "colFECHA_ACTUALIZACION"
        Me.colFECHA_ACTUALIZACION.OptionsColumn.AllowEdit = False
        Me.colFECHA_ACTUALIZACION.OptionsColumn.AllowMove = False
        Me.colFECHA_ACTUALIZACION.OptionsColumn.ReadOnly = True
        Me.colFECHA_ACTUALIZACION.Visible = True
        Me.colFECHA_ACTUALIZACION.VisibleIndex = 5
        Me.colFECHA_ACTUALIZACION.Width = 123
        '
        'frmBinario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(888, 418)
        Me.ControlBox = False
        Me.Controls.Add(Me.gdcBinario)
        Me.Controls.Add(Me.GroupControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBinario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adjuntar Archivos"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.lueTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreArchivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdcBinario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleBinario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDescargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Shared _Form As frmBinario = Nothing

    Public Shared Property DefInstance() As frmBinario
        Get
            If _Form Is Nothing OrElse _Form.IsDisposed Then
                _Form = New frmBinario
            Else
                _Form.BringToFront()
            End If
            Return _Form
        End Get

        Set(ByVal value As frmBinario)
            _Form = value
        End Set
    End Property

    Public empleadoBinario As New Empleado
    Public retorno As Boolean = False
    Public antecedenteCurricularId As Integer

    Private Sub frmBinario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtNombres.Text = empleadoBinario.nombreCompleto
        llenarTipoDocumento()
        llenarGrillaAdjuntos()
    End Sub

    Public Sub llenarTipoDocumento()
        lueTipoDocumento.Properties.Columns.Clear()
        With lueTipoDocumento
            With .Properties.Columns
                .Add(New LookUpColumnInfo("TIPO_DOCUMENTO_ID", "ID Profesion", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near))
                .Add(New LookUpColumnInfo("DESCRIPCION", "Descripción", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near))
            End With
        End With
        lueTipoDocumento.Properties.DataSource = empleadoBinario.recuperarTipoDocumento
        lueTipoDocumento.Properties.DisplayMember = "DESCRIPCION"
        lueTipoDocumento.Properties.NullText = ""
        lueTipoDocumento.Properties.PopupWidth = 400
        lueTipoDocumento.Properties.ValueMember = "TIPO_DOCUMENTO_ID"
        lueTipoDocumento.EditValue = "TIPO_DOCUMENTO_ID"
    End Sub

    Private Sub btnBuscarArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarArchivo.Click
        Dim CamposIncompletos As Boolean = False
        If lueTipoDocumento.EditValue <= 0 Then
            lueTipoDocumento.ErrorText = "Debe seleccionar un elemento de la lista"
            CamposIncompletos = True
        End If

        If CamposIncompletos Then
            Exit Sub
        End If

        Dim myStream As Stream = Nothing
        Dim nombreArchivo As String
        Dim openFileDialog1 As New OpenFileDialog

        openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal)
        openFileDialog1.Filter = "Archivos Word (*.doc,*.docx)|*.doc;*.docx|Archivos Excel (*.xls,*.xlsm)|*.xls;*.xlsx|Archivos PDF (*.pdf)|*.pdf|Imagenes (*.jpg)|*.jpg"
        openFileDialog1.FilterIndex = 3
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFileDialog1.OpenFile()
                If (Not myStream Is Nothing) Then
                    nombreArchivo = openFileDialog1.FileName
                    Me.txtNombreArchivo.Text = nombreArchivo
                    AdjuntarArchivo(nombreArchivo, myStream, empleadoBinario.ID, antecedenteCurricularId, lueTipoDocumento.EditValue)
                    llenarGrillaAdjuntos()

                End If
            Catch Ex As Exception
                MessageBox.Show(String.Format("No se puede leer archivo: {0}", Ex.Message))
            Finally
                If (Not myStream Is Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        retorno = True
        frmBinario.DefInstance.Close()
    End Sub

    Private Sub AdjuntarArchivo(ByVal nombreArchivo As String, ByVal myStream As Stream, ByVal empleadoId As Integer, ByVal antecedenteCurriId As Integer, ByVal tipoDocumentoId As Integer)
        Dim fileName As String = nombreArchivo
        Dim up As CargarPictures = New CargarPictures
        Dim id As Long = up.UploadFile(fileName, myStream, empleadoId, antecedenteCurriId, tipoDocumentoId)
        Dim fi As FileInfo = New FileInfo(fileName)
    End Sub

    Private Sub llenarGrillaAdjuntos()
        Me.gdcBinario.DataSource = empleadoBinario.recuperaDatosAntecedenteBinario(empleadoBinario.ID)
    End Sub

    Private Sub lueTipoDocumento_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueTipoDocumento.EditValueChanged
        Me.lueTipoDocumento.ErrorText = ""
    End Sub

    Private Sub btnDescargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDescargar.Click
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetalleBinario
        Dim down As CargarPictures = New CargarPictures
        Dim resultado As Byte()
        Dim NombreArchivo As String = ""
        With SaveFileDialog1
            resultado = down.DownloadFile(view.GetRowCellValue(view.FocusedRowHandle, "BINARIO_ID"), NombreArchivo)
            .FileName = NombreArchivo
            If Not SaveFileDialog1.ShowDialog = DialogResult.Cancel Then
                Dim fs As FileStream
                fs = New FileStream(.FileName, FileMode.Create)
                fs.Write(resultado, 0, Convert.ToInt32(resultado.Length))
                fs.Close()
                MsgBox(String.Format("Se descargó archivo exitosamente en la siguiente carpeta {0}{1}", Chr(13), .FileName), MsgBoxStyle.Information, "SIGA")
            End If
        End With
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gdvDetalleBinario
            Try
                empleadoBinario.EliminarEmpleadoAntecedenteBinario(view.GetRowCellValue(view.FocusedRowHandle, "BINARIO_ID"))
                llenarGrillaAdjuntos()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
End Class
