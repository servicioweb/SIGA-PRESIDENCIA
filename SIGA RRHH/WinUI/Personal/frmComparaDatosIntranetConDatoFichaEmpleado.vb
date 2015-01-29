Imports cl.presidencia.Argo.BusinessRules
Imports DevExpress.XtraGrid.Views.Grid


Public Class frmComparaDatosIntranetConDatoFichaEmpleado
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
    Friend WithEvents gdcEmpleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gdvDetalleEmpleados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sfdComparaDatos As System.Windows.Forms.SaveFileDialog
    Friend WithEvents progreso As System.Windows.Forms.ProgressBar
    Friend WithEvents fieldID_INTRANET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldEMPLEADO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldFICHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldNOMBRE_EMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCALLE_AVDA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldNUMERO_DIRECCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldVILLA_POBLACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldPAIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldREGION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCIUDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCOMUNA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldTELEFONO_PARTICULAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCELULAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCODIGO_POSTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldFECHA_NACIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldSEXO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldPAIS_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldREGION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCOMUNA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldESTADO_CIVIL_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldESTADO_CIVIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCONTACTO_EMERGENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldANEXO_TELEFONO_OFI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldSITUACION_MILITAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldNRO_MATRICULA_MILITAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldGRUPO_SANGUINEO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldALERGICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldSUFRE_ENFERMEDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldMEDICAMENTOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldEMAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCALLE_AVDA_DISTINTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldNUMERO_DIRECCION_DISTINTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldVILLA_POBLACION_DISTINTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldTELEFONO_PARTICULAR_DISTINTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCODIGO_POSTAL_DISTINTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldREGION_DISTINTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCOMUNA_DISTINTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCIUDAD_DISTINTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldPAIS_DISTINTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldFECHA_NACIMIENTO_DISTINTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldSEXO_DISTINTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldNIVEL_ESTUDIO_DISTINTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldESTADO_CIVIL_DISTINTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCONTACTO_EMERGENCIA_DISTINTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldANEXO_TELEFONO_OFI_DISTINTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldSITUACION_MILITAR_DISTINTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldNRO_MATRICULA_MILITAR_DISTINTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldGRUPO_SANGUINEO_DISTINTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldALERGICO_DISTINTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldSUFRE_ENFERMEDAD_DISTINTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldMEDICAMENTOS_DISTINTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCIUDAD_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCELULAR_DISTINTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldEMAIL_DISTINTO As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.gdcEmpleados = New DevExpress.XtraGrid.GridControl
        Me.gdvDetalleEmpleados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.fieldID_INTRANET = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldEMPLEADO_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldFICHA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldNOMBRE_EMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldFECHA_NACIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldSEXO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldESTADO_CIVIL_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldESTADO_CIVIL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldEMAIL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldCALLE_AVDA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldNUMERO_DIRECCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldVILLA_POBLACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldPAIS_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldPAIS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldREGION_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldREGION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldCIUDAD_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldCIUDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldCOMUNA_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldCOMUNA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldTELEFONO_PARTICULAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldCELULAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldCODIGO_POSTAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldCONTACTO_EMERGENCIA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldANEXO_TELEFONO_OFI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldSITUACION_MILITAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldNRO_MATRICULA_MILITAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldGRUPO_SANGUINEO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldALERGICO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldSUFRE_ENFERMEDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldMEDICAMENTOS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldCALLE_AVDA_DISTINTA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldNUMERO_DIRECCION_DISTINTA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldVILLA_POBLACION_DISTINTA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldTELEFONO_PARTICULAR_DISTINTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldCODIGO_POSTAL_DISTINTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldCELULAR_DISTINTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldREGION_DISTINTA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldCOMUNA_DISTINTA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldCIUDAD_DISTINTA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldPAIS_DISTINTA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldFECHA_NACIMIENTO_DISTINTA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldSEXO_DISTINTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldNIVEL_ESTUDIO_DISTINTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldESTADO_CIVIL_DISTINTA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldCONTACTO_EMERGENCIA_DISTINTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldANEXO_TELEFONO_OFI_DISTINTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldSITUACION_MILITAR_DISTINTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldNRO_MATRICULA_MILITAR_DISTINTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldGRUPO_SANGUINEO_DISTINTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldALERGICO_DISTINTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldSUFRE_ENFERMEDAD_DISTINTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fieldMEDICAMENTOS_DISTINTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton
        Me.btnActualizar = New DevExpress.XtraEditors.SimpleButton
        Me.sfdComparaDatos = New System.Windows.Forms.SaveFileDialog
        Me.progreso = New System.Windows.Forms.ProgressBar
        Me.fieldEMAIL_DISTINTO = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.gdcEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvDetalleEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdcEmpleados
        '
        Me.gdcEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'gdcEmpleados.EmbeddedNavigator
        '
        Me.gdcEmpleados.EmbeddedNavigator.Name = ""
        Me.gdcEmpleados.Location = New System.Drawing.Point(8, 48)
        Me.gdcEmpleados.MainView = Me.gdvDetalleEmpleados
        Me.gdcEmpleados.Name = "gdcEmpleados"
        Me.gdcEmpleados.Size = New System.Drawing.Size(800, 288)
        Me.gdcEmpleados.TabIndex = 0
        Me.gdcEmpleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdvDetalleEmpleados, Me.GridView1})
        '
        'gdvDetalleEmpleados
        '
        Me.gdvDetalleEmpleados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.fieldID_INTRANET, Me.fieldEMPLEADO_ID, Me.fieldFICHA, Me.fieldNOMBRE_EMPLEADO, Me.fieldFECHA_NACIMIENTO, Me.fieldSEXO, Me.fieldESTADO_CIVIL_ID, Me.fieldESTADO_CIVIL, Me.fieldEMAIL, Me.fieldCALLE_AVDA, Me.fieldNUMERO_DIRECCION, Me.fieldVILLA_POBLACION, Me.fieldPAIS_ID, Me.fieldPAIS, Me.fieldREGION_ID, Me.fieldREGION, Me.fieldCIUDAD_ID, Me.fieldCIUDAD, Me.fieldCOMUNA_ID, Me.fieldCOMUNA, Me.fieldTELEFONO_PARTICULAR, Me.fieldCELULAR, Me.fieldCODIGO_POSTAL, Me.fieldCONTACTO_EMERGENCIA, Me.fieldANEXO_TELEFONO_OFI, Me.fieldSITUACION_MILITAR, Me.fieldNRO_MATRICULA_MILITAR, Me.fieldGRUPO_SANGUINEO, Me.fieldALERGICO, Me.fieldSUFRE_ENFERMEDAD, Me.fieldMEDICAMENTOS, Me.fieldCALLE_AVDA_DISTINTA, Me.fieldNUMERO_DIRECCION_DISTINTA, Me.fieldVILLA_POBLACION_DISTINTA, Me.fieldTELEFONO_PARTICULAR_DISTINTO, Me.fieldCODIGO_POSTAL_DISTINTO, Me.fieldCELULAR_DISTINTO, Me.fieldREGION_DISTINTA, Me.fieldCOMUNA_DISTINTA, Me.fieldCIUDAD_DISTINTA, Me.fieldPAIS_DISTINTA, Me.fieldFECHA_NACIMIENTO_DISTINTA, Me.fieldSEXO_DISTINTO, Me.fieldNIVEL_ESTUDIO_DISTINTO, Me.fieldESTADO_CIVIL_DISTINTA, Me.fieldCONTACTO_EMERGENCIA_DISTINTO, Me.fieldANEXO_TELEFONO_OFI_DISTINTO, Me.fieldSITUACION_MILITAR_DISTINTO, Me.fieldNRO_MATRICULA_MILITAR_DISTINTO, Me.fieldGRUPO_SANGUINEO_DISTINTO, Me.fieldALERGICO_DISTINTO, Me.fieldSUFRE_ENFERMEDAD_DISTINTO, Me.fieldMEDICAMENTOS_DISTINTO, Me.fieldEMAIL_DISTINTO})
        Me.gdvDetalleEmpleados.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.gdvDetalleEmpleados.GridControl = Me.gdcEmpleados
        Me.gdvDetalleEmpleados.Name = "gdvDetalleEmpleados"
        Me.gdvDetalleEmpleados.OptionsView.ColumnAutoWidth = False
        '
        'fieldID_INTRANET
        '
        Me.fieldID_INTRANET.Caption = "ID Ficha Intranet"
        Me.fieldID_INTRANET.FieldName = "ID_INTRANET"
        Me.fieldID_INTRANET.Name = "fieldID_INTRANET"
        Me.fieldID_INTRANET.OptionsColumn.AllowEdit = False
        Me.fieldID_INTRANET.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Me.fieldID_INTRANET.OptionsColumn.ReadOnly = True
        '
        'fieldEMPLEADO_ID
        '
        Me.fieldEMPLEADO_ID.Caption = "ID Empleado"
        Me.fieldEMPLEADO_ID.FieldName = "EMPLEADO_ID"
        Me.fieldEMPLEADO_ID.Name = "fieldEMPLEADO_ID"
        Me.fieldEMPLEADO_ID.OptionsColumn.AllowEdit = False
        Me.fieldEMPLEADO_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Me.fieldEMPLEADO_ID.OptionsColumn.ReadOnly = True
        '
        'fieldFICHA
        '
        Me.fieldFICHA.Caption = "Origen"
        Me.fieldFICHA.FieldName = "FICHA"
        Me.fieldFICHA.Name = "fieldFICHA"
        Me.fieldFICHA.OptionsColumn.AllowEdit = False
        Me.fieldFICHA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Me.fieldFICHA.OptionsColumn.ReadOnly = True
        Me.fieldFICHA.Visible = True
        Me.fieldFICHA.VisibleIndex = 0
        Me.fieldFICHA.Width = 76
        '
        'fieldNOMBRE_EMPLEADO
        '
        Me.fieldNOMBRE_EMPLEADO.Caption = "Empleado"
        Me.fieldNOMBRE_EMPLEADO.FieldName = "NOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.Name = "fieldNOMBRE_EMPLEADO"
        Me.fieldNOMBRE_EMPLEADO.OptionsColumn.ReadOnly = True
        Me.fieldNOMBRE_EMPLEADO.Visible = True
        Me.fieldNOMBRE_EMPLEADO.VisibleIndex = 1
        Me.fieldNOMBRE_EMPLEADO.Width = 183
        '
        'fieldFECHA_NACIMIENTO
        '
        Me.fieldFECHA_NACIMIENTO.Caption = "Fecha Nacimiento"
        Me.fieldFECHA_NACIMIENTO.FieldName = "FECHA_NACIMIENTO"
        Me.fieldFECHA_NACIMIENTO.Name = "fieldFECHA_NACIMIENTO"
        Me.fieldFECHA_NACIMIENTO.OptionsColumn.ReadOnly = True
        Me.fieldFECHA_NACIMIENTO.Visible = True
        Me.fieldFECHA_NACIMIENTO.VisibleIndex = 13
        Me.fieldFECHA_NACIMIENTO.Width = 136
        '
        'fieldSEXO
        '
        Me.fieldSEXO.Caption = "Sexo"
        Me.fieldSEXO.FieldName = "SEXO"
        Me.fieldSEXO.Name = "fieldSEXO"
        Me.fieldSEXO.OptionsColumn.ReadOnly = True
        Me.fieldSEXO.Visible = True
        Me.fieldSEXO.VisibleIndex = 14
        Me.fieldSEXO.Width = 49
        '
        'fieldESTADO_CIVIL_ID
        '
        Me.fieldESTADO_CIVIL_ID.Caption = "Estado Civil ID"
        Me.fieldESTADO_CIVIL_ID.FieldName = " ESTADO_CIVIL_ID"
        Me.fieldESTADO_CIVIL_ID.Name = "fieldESTADO_CIVIL_ID"
        Me.fieldESTADO_CIVIL_ID.OptionsColumn.ReadOnly = True
        '
        'fieldESTADO_CIVIL
        '
        Me.fieldESTADO_CIVIL.Caption = "Estado Civil"
        Me.fieldESTADO_CIVIL.FieldName = "ESTADO_CIVIL"
        Me.fieldESTADO_CIVIL.Name = "fieldESTADO_CIVIL"
        Me.fieldESTADO_CIVIL.OptionsColumn.ReadOnly = True
        Me.fieldESTADO_CIVIL.Visible = True
        Me.fieldESTADO_CIVIL.VisibleIndex = 9
        Me.fieldESTADO_CIVIL.Width = 128
        '
        'fieldEMAIL
        '
        Me.fieldEMAIL.Caption = "EMail"
        Me.fieldEMAIL.FieldName = "EMAIL"
        Me.fieldEMAIL.Name = "fieldEMAIL"
        Me.fieldEMAIL.OptionsColumn.ReadOnly = True
        Me.fieldEMAIL.Visible = True
        Me.fieldEMAIL.VisibleIndex = 23
        '
        'fieldCALLE_AVDA
        '
        Me.fieldCALLE_AVDA.Caption = "Calle o Avda."
        Me.fieldCALLE_AVDA.FieldName = "CALLE_AVDA"
        Me.fieldCALLE_AVDA.Name = "fieldCALLE_AVDA"
        Me.fieldCALLE_AVDA.OptionsColumn.ReadOnly = True
        Me.fieldCALLE_AVDA.Visible = True
        Me.fieldCALLE_AVDA.VisibleIndex = 2
        Me.fieldCALLE_AVDA.Width = 127
        '
        'fieldNUMERO_DIRECCION
        '
        Me.fieldNUMERO_DIRECCION.Caption = "#Dirección"
        Me.fieldNUMERO_DIRECCION.FieldName = "NUMERO_DIRECCION"
        Me.fieldNUMERO_DIRECCION.Name = "fieldNUMERO_DIRECCION"
        Me.fieldNUMERO_DIRECCION.OptionsColumn.ReadOnly = True
        Me.fieldNUMERO_DIRECCION.Visible = True
        Me.fieldNUMERO_DIRECCION.VisibleIndex = 3
        Me.fieldNUMERO_DIRECCION.Width = 124
        '
        'fieldVILLA_POBLACION
        '
        Me.fieldVILLA_POBLACION.Caption = "Villa, Población o Condominio"
        Me.fieldVILLA_POBLACION.FieldName = "VILLA_POBLACION"
        Me.fieldVILLA_POBLACION.Name = "fieldVILLA_POBLACION"
        Me.fieldVILLA_POBLACION.OptionsColumn.ReadOnly = True
        Me.fieldVILLA_POBLACION.Visible = True
        Me.fieldVILLA_POBLACION.VisibleIndex = 4
        Me.fieldVILLA_POBLACION.Width = 215
        '
        'fieldPAIS_ID
        '
        Me.fieldPAIS_ID.Caption = "Pías ID"
        Me.fieldPAIS_ID.FieldName = "PAIS_ID"
        Me.fieldPAIS_ID.Name = "fieldPAIS_ID"
        Me.fieldPAIS_ID.OptionsColumn.ReadOnly = True
        '
        'fieldPAIS
        '
        Me.fieldPAIS.Caption = "País"
        Me.fieldPAIS.FieldName = "PAIS"
        Me.fieldPAIS.Name = "fieldPAIS"
        Me.fieldPAIS.OptionsColumn.ReadOnly = True
        Me.fieldPAIS.Visible = True
        Me.fieldPAIS.VisibleIndex = 5
        Me.fieldPAIS.Width = 109
        '
        'fieldREGION_ID
        '
        Me.fieldREGION_ID.Caption = "Región ID"
        Me.fieldREGION_ID.FieldName = "REGION_ID"
        Me.fieldREGION_ID.Name = "fieldREGION_ID"
        Me.fieldREGION_ID.OptionsColumn.ReadOnly = True
        '
        'fieldREGION
        '
        Me.fieldREGION.Caption = "Región"
        Me.fieldREGION.FieldName = "REGION"
        Me.fieldREGION.Name = "fieldREGION"
        Me.fieldREGION.OptionsColumn.ReadOnly = True
        Me.fieldREGION.Visible = True
        Me.fieldREGION.VisibleIndex = 6
        '
        'fieldCIUDAD_ID
        '
        Me.fieldCIUDAD_ID.Caption = "Ciudad ID"
        Me.fieldCIUDAD_ID.FieldName = "CIUDAD_ID"
        Me.fieldCIUDAD_ID.Name = "fieldCIUDAD_ID"
        Me.fieldCIUDAD_ID.OptionsColumn.ReadOnly = True
        '
        'fieldCIUDAD
        '
        Me.fieldCIUDAD.Caption = "Ciudad"
        Me.fieldCIUDAD.FieldName = "CIUDAD"
        Me.fieldCIUDAD.Name = "fieldCIUDAD"
        Me.fieldCIUDAD.OptionsColumn.ReadOnly = True
        Me.fieldCIUDAD.Visible = True
        Me.fieldCIUDAD.VisibleIndex = 7
        '
        'fieldCOMUNA_ID
        '
        Me.fieldCOMUNA_ID.Caption = "Comuna ID"
        Me.fieldCOMUNA_ID.FieldName = "COMUNA_ID"
        Me.fieldCOMUNA_ID.Name = "fieldCOMUNA_ID"
        Me.fieldCOMUNA_ID.OptionsColumn.ReadOnly = True
        '
        'fieldCOMUNA
        '
        Me.fieldCOMUNA.Caption = "Comuna"
        Me.fieldCOMUNA.FieldName = "COMUNA"
        Me.fieldCOMUNA.Name = "fieldCOMUNA"
        Me.fieldCOMUNA.OptionsColumn.ReadOnly = True
        Me.fieldCOMUNA.Visible = True
        Me.fieldCOMUNA.VisibleIndex = 8
        '
        'fieldTELEFONO_PARTICULAR
        '
        Me.fieldTELEFONO_PARTICULAR.Caption = "Fono Particular"
        Me.fieldTELEFONO_PARTICULAR.FieldName = "TELEFONO_PARTICULAR"
        Me.fieldTELEFONO_PARTICULAR.Name = "fieldTELEFONO_PARTICULAR"
        Me.fieldTELEFONO_PARTICULAR.OptionsColumn.ReadOnly = True
        Me.fieldTELEFONO_PARTICULAR.Visible = True
        Me.fieldTELEFONO_PARTICULAR.VisibleIndex = 10
        Me.fieldTELEFONO_PARTICULAR.Width = 202
        '
        'fieldCELULAR
        '
        Me.fieldCELULAR.Caption = "#Móvil"
        Me.fieldCELULAR.FieldName = "CELULAR"
        Me.fieldCELULAR.Name = "fieldCELULAR"
        Me.fieldCELULAR.OptionsColumn.ReadOnly = True
        Me.fieldCELULAR.Visible = True
        Me.fieldCELULAR.VisibleIndex = 11
        Me.fieldCELULAR.Width = 174
        '
        'fieldCODIGO_POSTAL
        '
        Me.fieldCODIGO_POSTAL.Caption = "Código Postal"
        Me.fieldCODIGO_POSTAL.FieldName = "CODIGO_POSTAL"
        Me.fieldCODIGO_POSTAL.Name = "fieldCODIGO_POSTAL"
        Me.fieldCODIGO_POSTAL.OptionsColumn.ReadOnly = True
        Me.fieldCODIGO_POSTAL.Visible = True
        Me.fieldCODIGO_POSTAL.VisibleIndex = 12
        Me.fieldCODIGO_POSTAL.Width = 120
        '
        'fieldCONTACTO_EMERGENCIA
        '
        Me.fieldCONTACTO_EMERGENCIA.Caption = "Nombre y Fono Contacto Emergencia"
        Me.fieldCONTACTO_EMERGENCIA.FieldName = "CONTACTO_EMERGENCIA"
        Me.fieldCONTACTO_EMERGENCIA.Name = "fieldCONTACTO_EMERGENCIA"
        Me.fieldCONTACTO_EMERGENCIA.OptionsColumn.ReadOnly = True
        Me.fieldCONTACTO_EMERGENCIA.Visible = True
        Me.fieldCONTACTO_EMERGENCIA.VisibleIndex = 15
        Me.fieldCONTACTO_EMERGENCIA.Width = 185
        '
        'fieldANEXO_TELEFONO_OFI
        '
        Me.fieldANEXO_TELEFONO_OFI.Caption = "Anexo o Fono Oficina"
        Me.fieldANEXO_TELEFONO_OFI.FieldName = "ANEXO_TELEFONO_OFI"
        Me.fieldANEXO_TELEFONO_OFI.Name = "fieldANEXO_TELEFONO_OFI"
        Me.fieldANEXO_TELEFONO_OFI.OptionsColumn.ReadOnly = True
        Me.fieldANEXO_TELEFONO_OFI.Visible = True
        Me.fieldANEXO_TELEFONO_OFI.VisibleIndex = 16
        Me.fieldANEXO_TELEFONO_OFI.Width = 182
        '
        'fieldSITUACION_MILITAR
        '
        Me.fieldSITUACION_MILITAR.Caption = "Situación Militar"
        Me.fieldSITUACION_MILITAR.FieldName = "SITUACION_MILITAR"
        Me.fieldSITUACION_MILITAR.Name = "fieldSITUACION_MILITAR"
        Me.fieldSITUACION_MILITAR.OptionsColumn.ReadOnly = True
        Me.fieldSITUACION_MILITAR.Visible = True
        Me.fieldSITUACION_MILITAR.VisibleIndex = 17
        Me.fieldSITUACION_MILITAR.Width = 162
        '
        'fieldNRO_MATRICULA_MILITAR
        '
        Me.fieldNRO_MATRICULA_MILITAR.Caption = "#Matricula Militar"
        Me.fieldNRO_MATRICULA_MILITAR.FieldName = "NRO_MATRICULA_MILITAR"
        Me.fieldNRO_MATRICULA_MILITAR.Name = "fieldNRO_MATRICULA_MILITAR"
        Me.fieldNRO_MATRICULA_MILITAR.OptionsColumn.ReadOnly = True
        Me.fieldNRO_MATRICULA_MILITAR.Visible = True
        Me.fieldNRO_MATRICULA_MILITAR.VisibleIndex = 18
        Me.fieldNRO_MATRICULA_MILITAR.Width = 192
        '
        'fieldGRUPO_SANGUINEO
        '
        Me.fieldGRUPO_SANGUINEO.Caption = "Grupo Sanguíneo"
        Me.fieldGRUPO_SANGUINEO.FieldName = "GRUPO_SANGUINEO"
        Me.fieldGRUPO_SANGUINEO.Name = "fieldGRUPO_SANGUINEO"
        Me.fieldGRUPO_SANGUINEO.OptionsColumn.ReadOnly = True
        Me.fieldGRUPO_SANGUINEO.Visible = True
        Me.fieldGRUPO_SANGUINEO.VisibleIndex = 19
        Me.fieldGRUPO_SANGUINEO.Width = 199
        '
        'fieldALERGICO
        '
        Me.fieldALERGICO.Caption = "Alergia"
        Me.fieldALERGICO.FieldName = "ALERGICO"
        Me.fieldALERGICO.Name = "fieldALERGICO"
        Me.fieldALERGICO.OptionsColumn.ReadOnly = True
        Me.fieldALERGICO.Visible = True
        Me.fieldALERGICO.VisibleIndex = 20
        Me.fieldALERGICO.Width = 136
        '
        'fieldSUFRE_ENFERMEDAD
        '
        Me.fieldSUFRE_ENFERMEDAD.Caption = "Enfermedad Crónica"
        Me.fieldSUFRE_ENFERMEDAD.FieldName = "SUFRE_ENFERMEDAD"
        Me.fieldSUFRE_ENFERMEDAD.Name = "fieldSUFRE_ENFERMEDAD"
        Me.fieldSUFRE_ENFERMEDAD.OptionsColumn.ReadOnly = True
        Me.fieldSUFRE_ENFERMEDAD.Visible = True
        Me.fieldSUFRE_ENFERMEDAD.VisibleIndex = 21
        Me.fieldSUFRE_ENFERMEDAD.Width = 166
        '
        'fieldMEDICAMENTOS
        '
        Me.fieldMEDICAMENTOS.Caption = "Medicamentos Contraindicados"
        Me.fieldMEDICAMENTOS.FieldName = "MEDICAMENTOS"
        Me.fieldMEDICAMENTOS.Name = "fieldMEDICAMENTOS"
        Me.fieldMEDICAMENTOS.OptionsColumn.ReadOnly = True
        Me.fieldMEDICAMENTOS.Visible = True
        Me.fieldMEDICAMENTOS.VisibleIndex = 22
        Me.fieldMEDICAMENTOS.Width = 151
        '
        'fieldCALLE_AVDA_DISTINTA
        '
        Me.fieldCALLE_AVDA_DISTINTA.Caption = "Calle Dist."
        Me.fieldCALLE_AVDA_DISTINTA.FieldName = "CALLE_AVDA_DISTINTA"
        Me.fieldCALLE_AVDA_DISTINTA.Name = "fieldCALLE_AVDA_DISTINTA"
        Me.fieldCALLE_AVDA_DISTINTA.OptionsColumn.ReadOnly = True
        '
        'fieldNUMERO_DIRECCION_DISTINTA
        '
        Me.fieldNUMERO_DIRECCION_DISTINTA.Caption = "Numero Dist."
        Me.fieldNUMERO_DIRECCION_DISTINTA.FieldName = "NUMERO_DIRECCION_DISTINTA"
        Me.fieldNUMERO_DIRECCION_DISTINTA.Name = "fieldNUMERO_DIRECCION_DISTINTA"
        Me.fieldNUMERO_DIRECCION_DISTINTA.OptionsColumn.ReadOnly = True
        '
        'fieldVILLA_POBLACION_DISTINTA
        '
        Me.fieldVILLA_POBLACION_DISTINTA.Caption = "Villa o Pob. Dist."
        Me.fieldVILLA_POBLACION_DISTINTA.FieldName = "VILLA_POBLACION_DISTINTA"
        Me.fieldVILLA_POBLACION_DISTINTA.Name = "fieldVILLA_POBLACION_DISTINTA"
        Me.fieldVILLA_POBLACION_DISTINTA.OptionsColumn.ReadOnly = True
        '
        'fieldTELEFONO_PARTICULAR_DISTINTO
        '
        Me.fieldTELEFONO_PARTICULAR_DISTINTO.Caption = "Fono Partic.Dist."
        Me.fieldTELEFONO_PARTICULAR_DISTINTO.FieldName = "TELEFONO_PARTICULAR_DISTINTO"
        Me.fieldTELEFONO_PARTICULAR_DISTINTO.Name = "fieldTELEFONO_PARTICULAR_DISTINTO"
        Me.fieldTELEFONO_PARTICULAR_DISTINTO.OptionsColumn.ReadOnly = True
        '
        'fieldCODIGO_POSTAL_DISTINTO
        '
        Me.fieldCODIGO_POSTAL_DISTINTO.Caption = "Codigo Postal Dist."
        Me.fieldCODIGO_POSTAL_DISTINTO.FieldName = "CODIGO_POSTAL_DISTINTO"
        Me.fieldCODIGO_POSTAL_DISTINTO.Name = "fieldCODIGO_POSTAL_DISTINTO"
        Me.fieldCODIGO_POSTAL_DISTINTO.OptionsColumn.ReadOnly = True
        '
        'fieldCELULAR_DISTINTO
        '
        Me.fieldCELULAR_DISTINTO.Caption = "Móvil Dist."
        Me.fieldCELULAR_DISTINTO.FieldName = "CELULAR_DISTINTO"
        Me.fieldCELULAR_DISTINTO.Name = "fieldCELULAR_DISTINTO"
        Me.fieldCELULAR_DISTINTO.OptionsColumn.ReadOnly = True
        '
        'fieldREGION_DISTINTA
        '
        Me.fieldREGION_DISTINTA.Caption = "Región Dist."
        Me.fieldREGION_DISTINTA.FieldName = "REGION_DISTINTA"
        Me.fieldREGION_DISTINTA.Name = "fieldREGION_DISTINTA"
        Me.fieldREGION_DISTINTA.OptionsColumn.ReadOnly = True
        '
        'fieldCOMUNA_DISTINTA
        '
        Me.fieldCOMUNA_DISTINTA.Caption = "Comuna Dist."
        Me.fieldCOMUNA_DISTINTA.FieldName = "COMUNA_DISTINTA"
        Me.fieldCOMUNA_DISTINTA.Name = "fieldCOMUNA_DISTINTA"
        Me.fieldCOMUNA_DISTINTA.OptionsColumn.ReadOnly = True
        '
        'fieldCIUDAD_DISTINTA
        '
        Me.fieldCIUDAD_DISTINTA.Caption = "Ciudad Dist."
        Me.fieldCIUDAD_DISTINTA.FieldName = "CIUDAD_DISTINTA"
        Me.fieldCIUDAD_DISTINTA.Name = "fieldCIUDAD_DISTINTA"
        Me.fieldCIUDAD_DISTINTA.OptionsColumn.ReadOnly = True
        '
        'fieldPAIS_DISTINTA
        '
        Me.fieldPAIS_DISTINTA.Caption = "País Dist."
        Me.fieldPAIS_DISTINTA.FieldName = "PAIS_DISTINTA"
        Me.fieldPAIS_DISTINTA.Name = "fieldPAIS_DISTINTA"
        Me.fieldPAIS_DISTINTA.OptionsColumn.ReadOnly = True
        '
        'fieldFECHA_NACIMIENTO_DISTINTA
        '
        Me.fieldFECHA_NACIMIENTO_DISTINTA.Caption = "Fecha Nac.Dist."
        Me.fieldFECHA_NACIMIENTO_DISTINTA.FieldName = "FECHA_NACIMIENTO_DISTINTA"
        Me.fieldFECHA_NACIMIENTO_DISTINTA.Name = "fieldFECHA_NACIMIENTO_DISTINTA"
        Me.fieldFECHA_NACIMIENTO_DISTINTA.OptionsColumn.ReadOnly = True
        '
        'fieldSEXO_DISTINTO
        '
        Me.fieldSEXO_DISTINTO.Caption = "Sexo Dist."
        Me.fieldSEXO_DISTINTO.FieldName = "SEXO_DISTINTO"
        Me.fieldSEXO_DISTINTO.Name = "fieldSEXO_DISTINTO"
        Me.fieldSEXO_DISTINTO.OptionsColumn.ReadOnly = True
        '
        'fieldNIVEL_ESTUDIO_DISTINTO
        '
        Me.fieldNIVEL_ESTUDIO_DISTINTO.Caption = "Nivel estudio Dist."
        Me.fieldNIVEL_ESTUDIO_DISTINTO.FieldName = "NIVEL_ESTUDIO_DISTINTO"
        Me.fieldNIVEL_ESTUDIO_DISTINTO.Name = "fieldNIVEL_ESTUDIO_DISTINTO"
        Me.fieldNIVEL_ESTUDIO_DISTINTO.OptionsColumn.ReadOnly = True
        '
        'fieldESTADO_CIVIL_DISTINTA
        '
        Me.fieldESTADO_CIVIL_DISTINTA.Caption = "Estado Civil Dist."
        Me.fieldESTADO_CIVIL_DISTINTA.FieldName = "ESTADO_CIVIL_DISTINTA"
        Me.fieldESTADO_CIVIL_DISTINTA.Name = "fieldESTADO_CIVIL_DISTINTA"
        Me.fieldESTADO_CIVIL_DISTINTA.OptionsColumn.ReadOnly = True
        '
        'fieldCONTACTO_EMERGENCIA_DISTINTO
        '
        Me.fieldCONTACTO_EMERGENCIA_DISTINTO.Caption = "Contacto Emerg.Dist."
        Me.fieldCONTACTO_EMERGENCIA_DISTINTO.FieldName = "CONTACTO_EMERGENCIA_DISTINTO"
        Me.fieldCONTACTO_EMERGENCIA_DISTINTO.Name = "fieldCONTACTO_EMERGENCIA_DISTINTO"
        Me.fieldCONTACTO_EMERGENCIA_DISTINTO.OptionsColumn.ReadOnly = True
        '
        'fieldANEXO_TELEFONO_OFI_DISTINTO
        '
        Me.fieldANEXO_TELEFONO_OFI_DISTINTO.Caption = "Anexo o Fono Ofi.Dist."
        Me.fieldANEXO_TELEFONO_OFI_DISTINTO.FieldName = "ANEXO_TELEFONO_OFI_DISTINTO"
        Me.fieldANEXO_TELEFONO_OFI_DISTINTO.Name = "fieldANEXO_TELEFONO_OFI_DISTINTO"
        Me.fieldANEXO_TELEFONO_OFI_DISTINTO.OptionsColumn.ReadOnly = True
        '
        'fieldSITUACION_MILITAR_DISTINTO
        '
        Me.fieldSITUACION_MILITAR_DISTINTO.Caption = "Situación Mili.Dist."
        Me.fieldSITUACION_MILITAR_DISTINTO.FieldName = "SITUACION_MILITAR_DISTINTO"
        Me.fieldSITUACION_MILITAR_DISTINTO.Name = "fieldSITUACION_MILITAR_DISTINTO"
        Me.fieldSITUACION_MILITAR_DISTINTO.OptionsColumn.ReadOnly = True
        '
        'fieldNRO_MATRICULA_MILITAR_DISTINTO
        '
        Me.fieldNRO_MATRICULA_MILITAR_DISTINTO.Caption = "Nro.Mattricula Mil.Dist."
        Me.fieldNRO_MATRICULA_MILITAR_DISTINTO.FieldName = "NRO_MATRICULA_MILITAR_DISTINTO"
        Me.fieldNRO_MATRICULA_MILITAR_DISTINTO.Name = "fieldNRO_MATRICULA_MILITAR_DISTINTO"
        Me.fieldNRO_MATRICULA_MILITAR_DISTINTO.OptionsColumn.ReadOnly = True
        '
        'fieldGRUPO_SANGUINEO_DISTINTO
        '
        Me.fieldGRUPO_SANGUINEO_DISTINTO.Caption = "Grupo Sang.Dist."
        Me.fieldGRUPO_SANGUINEO_DISTINTO.FieldName = "GRUPO_SANGUINEO_DISTINTO"
        Me.fieldGRUPO_SANGUINEO_DISTINTO.Name = "fieldGRUPO_SANGUINEO_DISTINTO"
        Me.fieldGRUPO_SANGUINEO_DISTINTO.OptionsColumn.ReadOnly = True
        '
        'fieldALERGICO_DISTINTO
        '
        Me.fieldALERGICO_DISTINTO.Caption = "Alergico Dist."
        Me.fieldALERGICO_DISTINTO.FieldName = "ALERGICO_DISTINTO"
        Me.fieldALERGICO_DISTINTO.Name = "fieldALERGICO_DISTINTO"
        Me.fieldALERGICO_DISTINTO.OptionsColumn.ReadOnly = True
        '
        'fieldSUFRE_ENFERMEDAD_DISTINTO
        '
        Me.fieldSUFRE_ENFERMEDAD_DISTINTO.Caption = "Sufre Enferm.Dist."
        Me.fieldSUFRE_ENFERMEDAD_DISTINTO.FieldName = "SUFRE_ENFERMEDAD_DISTINTO"
        Me.fieldSUFRE_ENFERMEDAD_DISTINTO.Name = "fieldSUFRE_ENFERMEDAD_DISTINTO"
        Me.fieldSUFRE_ENFERMEDAD_DISTINTO.OptionsColumn.ReadOnly = True
        '
        'fieldMEDICAMENTOS_DISTINTO
        '
        Me.fieldMEDICAMENTOS_DISTINTO.Caption = "Medicamentos Dist."
        Me.fieldMEDICAMENTOS_DISTINTO.FieldName = "MEDICAMENTOS_DISTINTO"
        Me.fieldMEDICAMENTOS_DISTINTO.Name = "fieldMEDICAMENTOS_DISTINTO"
        Me.fieldMEDICAMENTOS_DISTINTO.OptionsColumn.ReadOnly = True
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gdcEmpleados
        Me.GridView1.Name = "GridView1"
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(8, 16)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(184, 23)
        Me.btnExcel.TabIndex = 1
        Me.btnExcel.Text = "Exportar a Excel"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(224, 16)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(184, 23)
        Me.btnActualizar.TabIndex = 2
        Me.btnActualizar.Text = "Actualizar Hacia Ficha Empleado"
        '
        'progreso
        '
        Me.progreso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progreso.Location = New System.Drawing.Point(424, 16)
        Me.progreso.Name = "progreso"
        Me.progreso.Size = New System.Drawing.Size(384, 23)
        Me.progreso.TabIndex = 3
        '
        'fieldEMAIL_DISTINTO
        '
        Me.fieldEMAIL_DISTINTO.Caption = "Email Distinto"
        Me.fieldEMAIL_DISTINTO.FieldName = "EMAIL_DISTINTO"
        Me.fieldEMAIL_DISTINTO.Name = "fieldEMAIL_DISTINTO"
        '
        'frmComparaDatosIntranetConDatoFichaEmpleado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(816, 350)
        Me.Controls.Add(Me.progreso)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.gdcEmpleados)
        Me.Name = "frmComparaDatosIntranetConDatoFichaEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compara Datos Intranet v/s Datos Ficha Empleado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gdcEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvDetalleEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim empleado As Empleado

    Private Sub frmComparaDatosIntranetConDatoFichaEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        progreso.Visible = False
        empleado = New empleado
        refrescar()
    End Sub

    Private Sub refrescar()
        Try
            gdcEmpleados.DataSource = empleado.dvDatosFichaIntranet()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al intentar leer datos ficha intranet." & Chr(13) & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub gdvDetalleEmpleados_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gdvDetalleEmpleados.RowCellStyle
        Dim View As GridView = sender
        If e.Column.FieldName = "CALLE_AVDA" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("CALLE_AVDA_DISTINTA"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "NUMERO_DIRECCION" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("NUMERO_DIRECCION_DISTINTA"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "VILLA_POBLACION" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("VILLA_POBLACION_DISTINTA"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "TELEFONO_PARTICULAR" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("TELEFONO_PARTICULAR_DISTINTO"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "CODIGO_POSTAL" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("CODIGO_POSTAL_DISTINTO"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "CELULAR" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("CELULAR_DISTINTO"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "REGION" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("REGION_DISTINTA"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "COMUNA" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("COMUNA_DISTINTA"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "CIUDAD" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("CIUDAD_DISTINTA"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "PAIS" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("PAIS_DISTINTA"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "FECHA_NACIMIENTO" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("FECHA_NACIMIENTO_DISTINTA"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "SEXO" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("SEXO_DISTINTO"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "ESTADO_CIVIL" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("ESTADO_CIVIL_DISTINTA"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "CONTACTO_EMERGENCIA" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("CONTACTO_EMERGENCIA_DISTINTO"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "ANEXO_TELEFONO_OFI" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("ANEXO_TELEFONO_OFI_DISTINTO"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "SITUACION_MILITAR" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("SITUACION_MILITAR_DISTINTO"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "NRO_MATRICULA_MILITAR" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("NRO_MATRICULA_MILITAR_DISTINTO"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "GRUPO_SANGUINEO" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("GRUPO_SANGUINEO_DISTINTO"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "ALERGICO" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("ALERGICO_DISTINTO"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "SUFRE_ENFERMEDAD" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("SUFRE_ENFERMEDAD_DISTINTO"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        If e.Column.FieldName = "MEDICAMENTOS" Then
            Dim valorColumna As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("MEDICAMENTOS_DISTINTO"))
            If valorColumna = 1 Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Dim rutaPlanillaExcel As String
        Try
            With sfdComparaDatos
                .Filter = "Planilla electrónica excel (*.xls)|*.xls"
                .DefaultExt = "xls"
                .ShowDialog(Me)
                rutaPlanillaExcel = sfdComparaDatos.FileName
            End With
            If rutaPlanillaExcel <> "" Then
                gdcEmpleados.ExportToXls(rutaPlanillaExcel)
            End If
        Catch exp As Exception
            MessageBox.Show("Ha ocurrido un problema al intentar exportar los datos", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim numRegistros As Integer = gdvDetalleEmpleados.GetSelectedRows().Length
        Dim textoEspecial As String
        If numRegistros <= 0 Then
            MessageBox.Show("Debe seleccionar a lo menos una fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If numRegistros = 1 Then
            textoEspecial = " el registro seleccionado "
        Else
            textoEspecial = " los registros seleccionados "
        End If
        If MessageBox.Show("¿Está seguro de sobre escribir" & textoEspecial & "desde la ficha intranet hacia SIGA?", "SIGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                btnExcel.Enabled = False
                btnActualizar.Enabled = False
                progreso.Visible = True
                progreso.Minimum = 0
                Dim filas() As Integer = gdvDetalleEmpleados.GetSelectedRows()
                progreso.Maximum = filas.Length - 1
                Dim i As Integer
                Dim cantidadRegistros As Integer
                Dim sigue As Boolean = False
                For i = 0 To filas.Length - 1
                    Dim row As DataRow = gdvDetalleEmpleados.GetDataRow(filas(i))
                    If row("FICHA") = "INTRANET" Then
                        validaRegistro(row)
                        cantidadRegistros += 1
                        sigue = True
                    Else
                        MessageBox.Show("¿Debe estar ubicado sobre la fila que dice INTRANET", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit For
                    End If
                    progreso.Value = i
                Next i
                If sigue Then
                    refrescar()
                End If
                btnExcel.Enabled = True
                btnActualizar.Enabled = True
                progreso.Visible = False
            Catch ex As Exception
                MsgBox("Ha ocurrido un error en el proceso de actualización." & Chr(13) & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Function validaRegistro(ByVal row As DataRow) As Boolean
        Dim respuesta As Boolean = False
        Try
            empleado = New Empleado(row("EMPLEADO_ID"), True)
            If row("CALLE_AVDA_DISTINTA") = 1 Then
                empleado.direccion.calle = row("CALLE_AVDA")
                respuesta = True
            End If
            If row("NUMERO_DIRECCION_DISTINTA") = 1 Then
                empleado.direccion.numero = row("NUMERO_DIRECCION")
                respuesta = True
            End If
            If row("VILLA_POBLACION_DISTINTA") = 1 Then
                empleado.direccion.villaPoblacion = row("VILLA_POBLACION")
                respuesta = True
            End If
            If row("TELEFONO_PARTICULAR_DISTINTO") = 1 Then
                empleado.telefono = row("TELEFONO_PARTICULAR")
                respuesta = True
            End If
            If row("CODIGO_POSTAL_DISTINTO") = 1 Then
                empleado.direccion.codigoPostal = row("CODIGO_POSTAL")
                respuesta = True
            End If
            If row("CELULAR_DISTINTO") = 1 Then
                empleado.celular = row("CELULAR")
                respuesta = True
            End If
            If row("REGION_DISTINTA") = 1 Then
                empleado.direccion.region = row("REGION")
                respuesta = True
            End If
            If row("COMUNA_DISTINTA") = 1 Then
                empleado.direccion.comuna = row("COMUNA")
                respuesta = True
            End If
            If row("CIUDAD_DISTINTA") = 1 Then
                empleado.direccion.ciudad = row("CIUDAD")
                respuesta = True
            End If
            If row("PAIS_DISTINTA") = 1 Then
                empleado.direccion.pais = row("PAIS")
                respuesta = True
            End If
            If row("FECHA_NACIMIENTO_DISTINTA") = 1 Then
                empleado.fechaNacimiento = row("FECHA_NACIMIENTO")
                respuesta = True
            End If
            If row("SEXO_DISTINTO") = 1 Then
                Dim sexo As Integer
                If row("SEXO") = "F" Then
                    sexo = 1
                Else
                    sexo = 2
                End If
                empleado.sexo = sexo
                respuesta = True
            End If
            'If row("NIVEL_ESTUDIO_DISTINTO") = 1 Then
            '    empleado.nivelEducacional = row("NIVEL_ESTUDIO_ID")
            '    respuesta = True
            'End If
            If row("ESTADO_CIVIL_DISTINTA") = 1 Then
                empleado.estadoCivil = row("ESTADO_CIVIL_ID")
                respuesta = True
            End If
            If row("CONTACTO_EMERGENCIA_DISTINTO") = 1 Then
                empleado.ContactoEmergencia = row("CONTACTO_EMERGENCIA")
                respuesta = True
            End If
            If row("ANEXO_TELEFONO_OFI_DISTINTO") = 1 Then
                empleado.FonoAnexo = row("ANEXO_TELEFONO_OFI")
                respuesta = True
            End If
            If row("SITUACION_MILITAR_DISTINTO") = 1 Then
                empleado.servicioMilitar = row("SITUACION_MILITAR")
                respuesta = True
            End If
            If row("NRO_MATRICULA_MILITAR_DISTINTO") = 1 Then
                empleado.matriculaMilitar = row("NRO_MATRICULA_MILITAR")
                respuesta = True
            End If
            If row("GRUPO_SANGUINEO_DISTINTO") = 1 Then
                empleado.grupoSanguineo = row("GRUPO_SANGUINEO")
                respuesta = True
            End If
            If row("ALERGICO_DISTINTO") = 1 Then
                empleado.alergias = row("ALERGICO")
                respuesta = True
            End If
            If row("SUFRE_ENFERMEDAD_DISTINTO") = 1 Then
                empleado.enfermedadCronica = row("SUFRE_ENFERMEDAD")
                respuesta = True
            End If
            If row("MEDICAMENTOS_DISTINTO") = 1 Then
                empleado.medicamentosContraindicados = row("MEDICAMENTOS")
                respuesta = True
            End If
            If row("EMAIL_DISTINTO") = 1 Then
                empleado.email = row("EMAIL")
                respuesta = True
            End If
            If respuesta Then
                empleado.Actualizar()
                empleado.EliminarFichaIntranet(row("EMPLEADO_ID"))
                System.Windows.Forms.MessageBox.Show("Actualización Finalizada", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                System.Windows.Forms.MessageBox.Show("No existe diferencia de datos entre ficha intranet y ficha SIGA", "SIGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al procesoar al empleado " & empleado.nombreCompleto & "." & Chr(13) & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Function
    'Private Sub gdvDetalleEmpleados_ShowingEditor(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gdvDetalleEmpleados.ShowingEditor
    '    Dim View As GridView = sender
    '    If View.GetRowCellValue(View.FocusedRowHandle, View.Columns("FICHA")) = "INTRANET" Then
    '        btnActualizar.Enabled = True
    '    Else
    '        btnActualizar.Enabled = False
    '    End If
    'End Sub
End Class
