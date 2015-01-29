<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLicenciaMedicaInformeCalculo
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gpcDatosFilto = New DevExpress.XtraEditors.GroupControl()
        Me.gdcLicenciaMedica = New DevExpress.XtraGrid.GridControl()
        Me.gdvLicenciaMedica = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLICENCIA_MEDICA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gleEmpleado = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.chkTodasLasInstitucionesSalud = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTodosLosDeptos = New DevExpress.XtraEditors.CheckEdit()
        Me.lueDepartamento = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lueIsapre = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dedFechaFinal = New DevExpress.XtraEditors.DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dedFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.chkTodosLosEmpleados = New DevExpress.XtraEditors.CheckEdit()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.gcpBotones = New DevExpress.XtraEditors.GroupControl()
        Me.btnGenerar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gpcDatosFilto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcDatosFilto.SuspendLayout()
        CType(Me.gdcLicenciaMedica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvLicenciaMedica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTodasLasInstitucionesSalud.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTodosLosDeptos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueIsapre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaFinal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTodosLosEmpleados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcpBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcpBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpcDatosFilto
        '
        Me.gpcDatosFilto.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gpcDatosFilto.AppearanceCaption.Options.UseFont = True
        Me.gpcDatosFilto.Controls.Add(Me.gdcLicenciaMedica)
        Me.gpcDatosFilto.Controls.Add(Me.gleEmpleado)
        Me.gpcDatosFilto.Controls.Add(Me.chkTodasLasInstitucionesSalud)
        Me.gpcDatosFilto.Controls.Add(Me.chkTodosLosDeptos)
        Me.gpcDatosFilto.Controls.Add(Me.lueDepartamento)
        Me.gpcDatosFilto.Controls.Add(Me.Label4)
        Me.gpcDatosFilto.Controls.Add(Me.Label3)
        Me.gpcDatosFilto.Controls.Add(Me.lueIsapre)
        Me.gpcDatosFilto.Controls.Add(Me.Label2)
        Me.gpcDatosFilto.Controls.Add(Me.dedFechaFinal)
        Me.gpcDatosFilto.Controls.Add(Me.Label1)
        Me.gpcDatosFilto.Controls.Add(Me.dedFechaInicio)
        Me.gpcDatosFilto.Controls.Add(Me.chkTodosLosEmpleados)
        Me.gpcDatosFilto.Controls.Add(Me.lblRut)
        Me.gpcDatosFilto.Location = New System.Drawing.Point(3, 2)
        Me.gpcDatosFilto.Name = "gpcDatosFilto"
        Me.gpcDatosFilto.Size = New System.Drawing.Size(734, 172)
        Me.gpcDatosFilto.TabIndex = 0
        Me.gpcDatosFilto.Text = "Filtros de selección"
        '
        'gdcLicenciaMedica
        '
        Me.gdcLicenciaMedica.Location = New System.Drawing.Point(451, 37)
        Me.gdcLicenciaMedica.MainView = Me.gdvLicenciaMedica
        Me.gdcLicenciaMedica.Name = "gdcLicenciaMedica"
        Me.gdcLicenciaMedica.Size = New System.Drawing.Size(264, 100)
        Me.gdcLicenciaMedica.TabIndex = 46
        Me.gdcLicenciaMedica.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvLicenciaMedica})
        '
        'gdvLicenciaMedica
        '
        Me.gdvLicenciaMedica.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLICENCIA_MEDICA_ID})
        Me.gdvLicenciaMedica.GridControl = Me.gdcLicenciaMedica
        Me.gdvLicenciaMedica.Name = "gdvLicenciaMedica"
        '
        'colLICENCIA_MEDICA_ID
        '
        Me.colLICENCIA_MEDICA_ID.Caption = "ID Licencia Medica"
        Me.colLICENCIA_MEDICA_ID.FieldName = "LICENCIA_MEDICA_ID"
        Me.colLICENCIA_MEDICA_ID.Name = "colLICENCIA_MEDICA_ID"
        Me.colLICENCIA_MEDICA_ID.Visible = True
        Me.colLICENCIA_MEDICA_ID.VisibleIndex = 0
        '
        'gleEmpleado
        '
        Me.gleEmpleado.Location = New System.Drawing.Point(107, 34)
        Me.gleEmpleado.Name = "gleEmpleado"
        Me.gleEmpleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleEmpleado.Properties.View = Me.GridLookUpEdit1View
        Me.gleEmpleado.Size = New System.Drawing.Size(143, 20)
        Me.gleEmpleado.TabIndex = 10
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'chkTodasLasInstitucionesSalud
        '
        Me.chkTodasLasInstitucionesSalud.Location = New System.Drawing.Point(261, 118)
        Me.chkTodasLasInstitucionesSalud.Name = "chkTodasLasInstitucionesSalud"
        Me.chkTodasLasInstitucionesSalud.Properties.Caption = "Todas las instituciones de salud"
        Me.chkTodasLasInstitucionesSalud.Size = New System.Drawing.Size(194, 19)
        Me.chkTodasLasInstitucionesSalud.TabIndex = 35
        '
        'chkTodosLosDeptos
        '
        Me.chkTodosLosDeptos.Location = New System.Drawing.Point(376, 143)
        Me.chkTodosLosDeptos.Name = "chkTodosLosDeptos"
        Me.chkTodosLosDeptos.Properties.Caption = "Todos los departamentos"
        Me.chkTodosLosDeptos.Size = New System.Drawing.Size(161, 19)
        Me.chkTodosLosDeptos.TabIndex = 45
        '
        'lueDepartamento
        '
        Me.lueDepartamento.EnterMoveNextControl = True
        Me.lueDepartamento.Location = New System.Drawing.Point(106, 142)
        Me.lueDepartamento.Name = "lueDepartamento"
        Me.lueDepartamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDepartamento.Properties.NullText = ""
        Me.lueDepartamento.Properties.PopupWidth = 400
        Me.lueDepartamento.Size = New System.Drawing.Size(264, 20)
        Me.lueDepartamento.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Departamento"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Inst.Salud"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lueIsapre
        '
        Me.lueIsapre.EnterMoveNextControl = True
        Me.lueIsapre.Location = New System.Drawing.Point(106, 114)
        Me.lueIsapre.Name = "lueIsapre"
        Me.lueIsapre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueIsapre.Properties.NullText = ""
        Me.lueIsapre.Properties.PopupWidth = 400
        Me.lueIsapre.Size = New System.Drawing.Size(144, 20)
        Me.lueIsapre.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Fecha final"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dedFechaFinal
        '
        Me.dedFechaFinal.EditValue = Nothing
        Me.dedFechaFinal.Location = New System.Drawing.Point(106, 88)
        Me.dedFechaFinal.Name = "dedFechaFinal"
        Me.dedFechaFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaFinal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaFinal.Size = New System.Drawing.Size(144, 20)
        Me.dedFechaFinal.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Fecha inicio"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dedFechaInicio
        '
        Me.dedFechaInicio.EditValue = Nothing
        Me.dedFechaInicio.Location = New System.Drawing.Point(106, 62)
        Me.dedFechaInicio.Name = "dedFechaInicio"
        Me.dedFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedFechaInicio.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dedFechaInicio.Size = New System.Drawing.Size(144, 20)
        Me.dedFechaInicio.TabIndex = 20
        '
        'chkTodosLosEmpleados
        '
        Me.chkTodosLosEmpleados.Location = New System.Drawing.Point(259, 35)
        Me.chkTodosLosEmpleados.Name = "chkTodosLosEmpleados"
        Me.chkTodosLosEmpleados.Properties.Caption = "Todos los empleados"
        Me.chkTodosLosEmpleados.Size = New System.Drawing.Size(144, 19)
        Me.chkTodosLosEmpleados.TabIndex = 15
        '
        'lblRut
        '
        Me.lblRut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRut.Location = New System.Drawing.Point(47, 39)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(53, 16)
        Me.lblRut.TabIndex = 14
        Me.lblRut.Text = "Rut"
        Me.lblRut.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gcpBotones
        '
        Me.gcpBotones.Controls.Add(Me.btnGenerar)
        Me.gcpBotones.Location = New System.Drawing.Point(3, 181)
        Me.gcpBotones.Name = "gcpBotones"
        Me.gcpBotones.ShowCaption = False
        Me.gcpBotones.Size = New System.Drawing.Size(734, 66)
        Me.gcpBotones.TabIndex = 1
        Me.gcpBotones.Text = "GroupControl1"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(295, 13)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(94, 23)
        Me.btnGenerar.TabIndex = 50
        Me.btnGenerar.Text = "Generar"
        '
        'frmLicenciaMedicaInformeCalculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 250)
        Me.Controls.Add(Me.gcpBotones)
        Me.Controls.Add(Me.gpcDatosFilto)
        Me.Name = "frmLicenciaMedicaInformeCalculo"
        Me.Text = "Informe Cálculo Licencia Médica"
        CType(Me.gpcDatosFilto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcDatosFilto.ResumeLayout(False)
        CType(Me.gdcLicenciaMedica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvLicenciaMedica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTodasLasInstitucionesSalud.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTodosLosDeptos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueIsapre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaFinal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTodosLosEmpleados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcpBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcpBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpcDatosFilto As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblRut As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dedFechaFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dedFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkTodosLosEmpleados As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lueIsapre As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lueDepartamento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkTodasLasInstitucionesSalud As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTodosLosDeptos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents gcpBotones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gleEmpleado As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gdcLicenciaMedica As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdvLicenciaMedica As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colLICENCIA_MEDICA_ID As DevExpress.XtraGrid.Columns.GridColumn
End Class
