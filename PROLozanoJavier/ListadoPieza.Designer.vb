<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoPieza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoPieza))
        Me.DataListaPiezas = New System.Windows.Forms.DataGridView()
        Me.CODPIEZADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRERECAMBIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PiezaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Taller2DataSet1 = New PROLozanoJavier.Taller2DataSet1()
        Me.btnModificarRe = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxCodC = New System.Windows.Forms.ComboBox()
        Me.txtCanti = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.richNom = New System.Windows.Forms.RichTextBox()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecioP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbusPieza = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Taller2DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PiezaTableAdapter = New PROLozanoJavier.Taller2DataSet1TableAdapters.PiezaTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataListaPiezas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PiezaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Taller2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Taller2DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataListaPiezas
        '
        Me.DataListaPiezas.AllowUserToOrderColumns = True
        Me.DataListaPiezas.AutoGenerateColumns = False
        Me.DataListaPiezas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListaPiezas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODPIEZADataGridViewTextBoxColumn, Me.NOMBRERECAMBIODataGridViewTextBoxColumn, Me.PRECIODataGridViewTextBoxColumn, Me.Cantidad})
        Me.DataListaPiezas.DataSource = Me.PiezaBindingSource
        Me.DataListaPiezas.Location = New System.Drawing.Point(43, 289)
        Me.DataListaPiezas.Name = "DataListaPiezas"
        Me.DataListaPiezas.Size = New System.Drawing.Size(446, 247)
        Me.DataListaPiezas.TabIndex = 126
        '
        'CODPIEZADataGridViewTextBoxColumn
        '
        Me.CODPIEZADataGridViewTextBoxColumn.DataPropertyName = "COD_PIEZA"
        Me.CODPIEZADataGridViewTextBoxColumn.HeaderText = "COD_PIEZA"
        Me.CODPIEZADataGridViewTextBoxColumn.Name = "CODPIEZADataGridViewTextBoxColumn"
        '
        'NOMBRERECAMBIODataGridViewTextBoxColumn
        '
        Me.NOMBRERECAMBIODataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_RECAMBIO"
        Me.NOMBRERECAMBIODataGridViewTextBoxColumn.HeaderText = "NOMBRE_RECAMBIO"
        Me.NOMBRERECAMBIODataGridViewTextBoxColumn.Name = "NOMBRERECAMBIODataGridViewTextBoxColumn"
        '
        'PRECIODataGridViewTextBoxColumn
        '
        Me.PRECIODataGridViewTextBoxColumn.DataPropertyName = "PRECIO"
        Me.PRECIODataGridViewTextBoxColumn.HeaderText = "PRECIO"
        Me.PRECIODataGridViewTextBoxColumn.Name = "PRECIODataGridViewTextBoxColumn"
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "CANTIDAD"
        Me.Cantidad.HeaderText = "CANTIDAD"
        Me.Cantidad.Name = "Cantidad"
        '
        'PiezaBindingSource
        '
        Me.PiezaBindingSource.DataMember = "Pieza"
        Me.PiezaBindingSource.DataSource = Me.Taller2DataSet1
        '
        'Taller2DataSet1
        '
        Me.Taller2DataSet1.DataSetName = "Taller2DataSet1"
        Me.Taller2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnModificarRe
        '
        Me.btnModificarRe.BackColor = System.Drawing.Color.PowderBlue
        Me.btnModificarRe.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarRe.Location = New System.Drawing.Point(66, 549)
        Me.btnModificarRe.Name = "btnModificarRe"
        Me.btnModificarRe.Size = New System.Drawing.Size(381, 36)
        Me.btnModificarRe.TabIndex = 130
        Me.btnModificarRe.Text = "MODIFICAR / ELIMINAR RECAMBIOS"
        Me.btnModificarRe.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbxCodC)
        Me.GroupBox1.Controls.Add(Me.txtCanti)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.richNom)
        Me.GroupBox1.Controls.Add(Me.txtCant)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPrecioP)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCodP)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 211)
        Me.GroupBox1.TabIndex = 176
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'cbxCodC
        '
        Me.cbxCodC.FormattingEnabled = True
        Me.cbxCodC.Location = New System.Drawing.Point(146, 28)
        Me.cbxCodC.Name = "cbxCodC"
        Me.cbxCodC.Size = New System.Drawing.Size(71, 21)
        Me.cbxCodC.TabIndex = 176
        '
        'txtCanti
        '
        Me.txtCanti.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCanti.Location = New System.Drawing.Point(265, 181)
        Me.txtCanti.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCanti.MaxLength = 4
        Me.txtCanti.Name = "txtCanti"
        Me.txtCanti.ReadOnly = True
        Me.txtCanti.Size = New System.Drawing.Size(79, 20)
        Me.txtCanti.TabIndex = 175
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(190, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 18)
        Me.Label6.TabIndex = 174
        Me.Label6.Text = "CANTIDAD:"
        '
        'richNom
        '
        Me.richNom.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richNom.Location = New System.Drawing.Point(146, 88)
        Me.richNom.MaxLength = 30
        Me.richNom.Name = "richNom"
        Me.richNom.ReadOnly = True
        Me.richNom.Size = New System.Drawing.Size(173, 77)
        Me.richNom.TabIndex = 173
        Me.richNom.Text = ""
        '
        'txtCant
        '
        Me.txtCant.Location = New System.Drawing.Point(103, 213)
        Me.txtCant.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCant.MaxLength = 4
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(71, 20)
        Me.txtCant.TabIndex = 164
        '
        'Button8
        '
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(337, 60)
        Me.Button8.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(49, 49)
        Me.Button8.TabIndex = 167
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(321, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 25)
        Me.Button1.TabIndex = 150
        Me.Button1.Text = "AÑADIR A COCHE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(392, 60)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(50, 49)
        Me.Button7.TabIndex = 168
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(19, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 18)
        Me.Label10.TabIndex = 155
        Me.Label10.Text = "COD COCHE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(22, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 18)
        Me.Label5.TabIndex = 163
        Me.Label5.Text = "CANTIDAD:"
        '
        'txtPrecioP
        '
        Me.txtPrecioP.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioP.Location = New System.Drawing.Point(75, 181)
        Me.txtPrecioP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrecioP.MaxLength = 9
        Me.txtPrecioP.Name = "txtPrecioP"
        Me.txtPrecioP.ReadOnly = True
        Me.txtPrecioP.Size = New System.Drawing.Size(79, 20)
        Me.txtPrecioP.TabIndex = 162
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(19, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 18)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "PRECIO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(19, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 18)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "NOMBRE PIEZA:"
        '
        'txtCodP
        '
        Me.txtCodP.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodP.Location = New System.Drawing.Point(146, 58)
        Me.txtCodP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodP.MaxLength = 4
        Me.txtCodP.Name = "txtCodP"
        Me.txtCodP.ReadOnly = True
        Me.txtCodP.Size = New System.Drawing.Size(71, 20)
        Me.txtCodP.TabIndex = 158
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "COD PIEZA:"
        '
        'txtbusPieza
        '
        Me.txtbusPieza.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusPieza.Location = New System.Drawing.Point(166, 257)
        Me.txtbusPieza.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbusPieza.MaxLength = 4
        Me.txtbusPieza.Name = "txtbusPieza"
        Me.txtbusPieza.Size = New System.Drawing.Size(74, 20)
        Me.txtbusPieza.TabIndex = 175
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(24, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 18)
        Me.Label1.TabIndex = 174
        Me.Label1.Text = "Busqueda codigo pieza:"
        '
        'PiezaTableAdapter
        '
        Me.PiezaTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(246, 253)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 28)
        Me.Button2.TabIndex = 177
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(364, 253)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(146, 28)
        Me.Button4.TabIndex = 178
        Me.Button4.Text = "Eliminar Filtro"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ListadoPieza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(537, 597)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtbusPieza)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnModificarRe)
        Me.Controls.Add(Me.DataListaPiezas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ListadoPieza"
        Me.Text = "ListadoPieza"
        CType(Me.DataListaPiezas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PiezaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Taller2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Taller2DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataListaPiezas As System.Windows.Forms.DataGridView
    Friend WithEvents btnModificarRe As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents richNom As System.Windows.Forms.RichTextBox
    Friend WithEvents txtCant As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioP As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodP As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbusPieza As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Taller2DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Taller2DataSet1 As PROLozanoJavier.Taller2DataSet1
    Friend WithEvents PiezaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PiezaTableAdapter As PROLozanoJavier.Taller2DataSet1TableAdapters.PiezaTableAdapter
    Friend WithEvents txtCanti As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents CODPIEZADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRERECAMBIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbxCodC As System.Windows.Forms.ComboBox
End Class
