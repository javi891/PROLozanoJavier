<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recambio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recambio))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.txtMarcR = New System.Windows.Forms.TextBox()
        Me.txtModeloR = New System.Windows.Forms.TextBox()
        Me.txtMatriR = New System.Windows.Forms.TextBox()
        Me.txtBastidorR = New System.Windows.Forms.TextBox()
        Me.txtMatricula = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodcoche = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataRecambios = New System.Windows.Forms.DataGridView()
        Me.CODPIEZADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREPIEZADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODCOCHEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIOPIEZADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDADPIEZADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecambiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Taller2DataSet1 = New PROLozanoJavier.Taller2DataSet1()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btnInsertarRe = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFiltroCodCoche = New System.Windows.Forms.TextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.txtFiltropiez = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RecambiosTableAdapter = New PROLozanoJavier.Taller2DataSet1TableAdapters.RecambiosTableAdapter()
        Me.Taller2DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtElimCodCoche = New System.Windows.Forms.TextBox()
        Me.txtEliminCodPieza = New System.Windows.Forms.TextBox()
        Me.rchBusNomPieza = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataRecambios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecambiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Taller2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Taller2DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.txtMarcR)
        Me.GroupBox1.Controls.Add(Me.txtModeloR)
        Me.GroupBox1.Controls.Add(Me.txtMatriR)
        Me.GroupBox1.Controls.Add(Me.txtBastidorR)
        Me.GroupBox1.Controls.Add(Me.txtMatricula)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCodcoche)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(55, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 169)
        Me.GroupBox1.TabIndex = 138
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DE COCHES:"
        '
        'Button9
        '
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(407, 60)
        Me.Button9.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(50, 49)
        Me.Button9.TabIndex = 139
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.Location = New System.Drawing.Point(352, 59)
        Me.Button10.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(49, 49)
        Me.Button10.TabIndex = 138
        Me.Button10.UseVisualStyleBackColor = True
        '
        'txtMarcR
        '
        Me.txtMarcR.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcR.Location = New System.Drawing.Point(102, 89)
        Me.txtMarcR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMarcR.MaxLength = 8
        Me.txtMarcR.Name = "txtMarcR"
        Me.txtMarcR.ReadOnly = True
        Me.txtMarcR.Size = New System.Drawing.Size(191, 21)
        Me.txtMarcR.TabIndex = 137
        '
        'txtModeloR
        '
        Me.txtModeloR.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModeloR.Location = New System.Drawing.Point(102, 116)
        Me.txtModeloR.Name = "txtModeloR"
        Me.txtModeloR.ReadOnly = True
        Me.txtModeloR.Size = New System.Drawing.Size(191, 21)
        Me.txtModeloR.TabIndex = 136
        '
        'txtMatriR
        '
        Me.txtMatriR.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatriR.Location = New System.Drawing.Point(102, 60)
        Me.txtMatriR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMatriR.MaxLength = 8
        Me.txtMatriR.Name = "txtMatriR"
        Me.txtMatriR.ReadOnly = True
        Me.txtMatriR.Size = New System.Drawing.Size(191, 21)
        Me.txtMatriR.TabIndex = 134
        '
        'txtBastidorR
        '
        Me.txtBastidorR.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBastidorR.Location = New System.Drawing.Point(125, 143)
        Me.txtBastidorR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBastidorR.MaxLength = 17
        Me.txtBastidorR.Name = "txtBastidorR"
        Me.txtBastidorR.ReadOnly = True
        Me.txtBastidorR.Size = New System.Drawing.Size(168, 21)
        Me.txtBastidorR.TabIndex = 133
        '
        'txtMatricula
        '
        Me.txtMatricula.AutoSize = True
        Me.txtMatricula.BackColor = System.Drawing.Color.Transparent
        Me.txtMatricula.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricula.ForeColor = System.Drawing.Color.Black
        Me.txtMatricula.Location = New System.Drawing.Point(13, 62)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(81, 18)
        Me.txtMatricula.TabIndex = 132
        Me.txtMatricula.Text = "MATRICULA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(13, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 18)
        Me.Label6.TabIndex = 131
        Me.Label6.Text = "MODELO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 18)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "MARCA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 18)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Nº DE BASTIDOR:"
        '
        'txtCodcoche
        '
        Me.txtCodcoche.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodcoche.Location = New System.Drawing.Point(102, 36)
        Me.txtCodcoche.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodcoche.MaxLength = 4
        Me.txtCodcoche.Name = "txtCodcoche"
        Me.txtCodcoche.ReadOnly = True
        Me.txtCodcoche.Size = New System.Drawing.Size(103, 21)
        Me.txtCodcoche.TabIndex = 126
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(13, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 18)
        Me.Label10.TabIndex = 125
        Me.Label10.Text = "COD COCHE:"
        '
        'DataRecambios
        '
        Me.DataRecambios.AutoGenerateColumns = False
        Me.DataRecambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataRecambios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODPIEZADataGridViewTextBoxColumn, Me.NOMBREPIEZADataGridViewTextBoxColumn, Me.CODCOCHEDataGridViewTextBoxColumn, Me.PRECIOPIEZADataGridViewTextBoxColumn, Me.CANTIDADPIEZADataGridViewTextBoxColumn})
        Me.DataRecambios.DataSource = Me.RecambiosBindingSource
        Me.DataRecambios.Location = New System.Drawing.Point(27, 263)
        Me.DataRecambios.Name = "DataRecambios"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataRecambios.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataRecambios.Size = New System.Drawing.Size(544, 180)
        Me.DataRecambios.TabIndex = 157
        '
        'CODPIEZADataGridViewTextBoxColumn
        '
        Me.CODPIEZADataGridViewTextBoxColumn.DataPropertyName = "COD_PIEZA"
        Me.CODPIEZADataGridViewTextBoxColumn.HeaderText = "COD_PIEZA"
        Me.CODPIEZADataGridViewTextBoxColumn.Name = "CODPIEZADataGridViewTextBoxColumn"
        '
        'NOMBREPIEZADataGridViewTextBoxColumn
        '
        Me.NOMBREPIEZADataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_PIEZA"
        Me.NOMBREPIEZADataGridViewTextBoxColumn.HeaderText = "NOMBRE_PIEZA"
        Me.NOMBREPIEZADataGridViewTextBoxColumn.Name = "NOMBREPIEZADataGridViewTextBoxColumn"
        '
        'CODCOCHEDataGridViewTextBoxColumn
        '
        Me.CODCOCHEDataGridViewTextBoxColumn.DataPropertyName = "COD_COCHE"
        Me.CODCOCHEDataGridViewTextBoxColumn.HeaderText = "COD_COCHE"
        Me.CODCOCHEDataGridViewTextBoxColumn.Name = "CODCOCHEDataGridViewTextBoxColumn"
        '
        'PRECIOPIEZADataGridViewTextBoxColumn
        '
        Me.PRECIOPIEZADataGridViewTextBoxColumn.DataPropertyName = "PRECIO_PIEZA"
        Me.PRECIOPIEZADataGridViewTextBoxColumn.HeaderText = "PRECIO_PIEZA"
        Me.PRECIOPIEZADataGridViewTextBoxColumn.Name = "PRECIOPIEZADataGridViewTextBoxColumn"
        '
        'CANTIDADPIEZADataGridViewTextBoxColumn
        '
        Me.CANTIDADPIEZADataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD_PIEZA"
        Me.CANTIDADPIEZADataGridViewTextBoxColumn.HeaderText = "CANTIDAD_PIEZA"
        Me.CANTIDADPIEZADataGridViewTextBoxColumn.Name = "CANTIDADPIEZADataGridViewTextBoxColumn"
        '
        'RecambiosBindingSource
        '
        Me.RecambiosBindingSource.DataMember = "Recambios"
        Me.RecambiosBindingSource.DataSource = Me.Taller2DataSet1
        '
        'Taller2DataSet1
        '
        Me.Taller2DataSet1.DataSetName = "Taller2DataSet1"
        Me.Taller2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(601, 298)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(183, 56)
        Me.Button8.TabIndex = 155
        Me.Button8.Text = "STOCK PIEZAS / AÑADIR A COCHE"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'btnInsertarRe
        '
        Me.btnInsertarRe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnInsertarRe.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertarRe.Location = New System.Drawing.Point(601, 360)
        Me.btnInsertarRe.Name = "btnInsertarRe"
        Me.btnInsertarRe.Size = New System.Drawing.Size(183, 49)
        Me.btnInsertarRe.TabIndex = 154
        Me.btnInsertarRe.Text = "INSERTAR RECAMBIOS NUEVOS"
        Me.btnInsertarRe.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(592, 140)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(162, 18)
        Me.Label14.TabIndex = 153
        Me.Label14.Text = "Busqueda por Nombre Pieza"
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(595, 159)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(72, 22)
        Me.Button14.TabIndex = 151
        Me.Button14.Text = "Buscar"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(592, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 18)
        Me.Label12.TabIndex = 150
        Me.Label12.Text = "Busqueda por Codigo Coche:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(592, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 18)
        Me.Label9.TabIndex = 149
        Me.Label9.Text = "Busqueda por Cod Pieza:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtFiltroCodCoche
        '
        Me.txtFiltroCodCoche.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroCodCoche.Location = New System.Drawing.Point(675, 111)
        Me.txtFiltroCodCoche.MaxLength = 4
        Me.txtFiltroCodCoche.Name = "txtFiltroCodCoche"
        Me.txtFiltroCodCoche.Size = New System.Drawing.Size(61, 21)
        Me.txtFiltroCodCoche.TabIndex = 148
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(595, 109)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(72, 22)
        Me.Button12.TabIndex = 147
        Me.Button12.Text = "Buscar"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'txtFiltropiez
        '
        Me.txtFiltropiez.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltropiez.Location = New System.Drawing.Point(675, 60)
        Me.txtFiltropiez.MaxLength = 4
        Me.txtFiltropiez.Name = "txtFiltropiez"
        Me.txtFiltropiez.Size = New System.Drawing.Size(61, 21)
        Me.txtFiltropiez.TabIndex = 146
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(595, 60)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(72, 22)
        Me.Button11.TabIndex = 145
        Me.Button11.Text = "Buscar"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 22)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "COCHES CON RECAMBIOS:"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.PowderBlue
        Me.Button7.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(282, 453)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(253, 31)
        Me.Button7.TabIndex = 160
        Me.Button7.Text = "ELIMINAR COCHE CON RECAMBIO RECAMBIO"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(601, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 56)
        Me.Button1.TabIndex = 158
        Me.Button1.Text = "CALCULAR PRESUPUESTO Y HACER FACTURA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RecambiosTableAdapter
        '
        Me.RecambiosTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(601, 261)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(189, 31)
        Me.Button3.TabIndex = 161
        Me.Button3.Text = "Eliminar Filtros"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 489)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 18)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Introduce Codigo Coche:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 463)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 18)
        Me.Label5.TabIndex = 166
        Me.Label5.Text = "Introduce Cod Pieza:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtElimCodCoche
        '
        Me.txtElimCodCoche.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtElimCodCoche.Location = New System.Drawing.Point(198, 490)
        Me.txtElimCodCoche.Name = "txtElimCodCoche"
        Me.txtElimCodCoche.Size = New System.Drawing.Size(62, 21)
        Me.txtElimCodCoche.TabIndex = 165
        '
        'txtEliminCodPieza
        '
        Me.txtEliminCodPieza.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEliminCodPieza.Location = New System.Drawing.Point(198, 461)
        Me.txtEliminCodPieza.Name = "txtEliminCodPieza"
        Me.txtEliminCodPieza.Size = New System.Drawing.Size(62, 21)
        Me.txtEliminCodPieza.TabIndex = 163
        '
        'rchBusNomPieza
        '
        Me.rchBusNomPieza.Location = New System.Drawing.Point(595, 187)
        Me.rchBusNomPieza.MaxLength = 30
        Me.rchBusNomPieza.Name = "rchBusNomPieza"
        Me.rchBusNomPieza.Size = New System.Drawing.Size(159, 58)
        Me.rchBusNomPieza.TabIndex = 168
        Me.rchBusNomPieza.Text = ""
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.PowderBlue
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(282, 490)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(253, 31)
        Me.Button2.TabIndex = 169
        Me.Button2.Text = "FORMULARIO ANTERIOR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Recambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(836, 543)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.rchBusNomPieza)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtElimCodCoche)
        Me.Controls.Add(Me.txtEliminCodPieza)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataRecambios)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.btnInsertarRe)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtFiltroCodCoche)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.txtFiltropiez)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Recambio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataRecambios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecambiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Taller2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Taller2DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents txtMarcR As System.Windows.Forms.TextBox
    Friend WithEvents txtModeloR As System.Windows.Forms.TextBox
    Friend WithEvents txtMatriR As System.Windows.Forms.TextBox
    Friend WithEvents txtBastidorR As System.Windows.Forms.TextBox
    Friend WithEvents txtMatricula As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodcoche As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataRecambios As System.Windows.Forms.DataGridView
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents btnInsertarRe As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFiltroCodCoche As System.Windows.Forms.TextBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents txtFiltropiez As System.Windows.Forms.TextBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Taller2DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Taller2DataSet1 As PROLozanoJavier.Taller2DataSet1
    Friend WithEvents RecambiosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecambiosTableAdapter As PROLozanoJavier.Taller2DataSet1TableAdapters.RecambiosTableAdapter
    Friend WithEvents CODPIEZADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREPIEZADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODCOCHEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIOPIEZADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDADPIEZADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtElimCodCoche As System.Windows.Forms.TextBox
    Friend WithEvents txtEliminCodPieza As System.Windows.Forms.TextBox
    Friend WithEvents rchBusNomPieza As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
