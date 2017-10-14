<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComprasRecambios
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalpiez = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtComCodCoche = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCantiP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtPrecioIva = New System.Windows.Forms.TextBox()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.txtPrecioUni = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataCompras = New System.Windows.Forms.DataGridView()
        Me.RecambiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Taller2DataSet1 = New PROLozanoJavier.Taller2DataSet1()
        Me.RecambiosTableAdapter = New PROLozanoJavier.Taller2DataSet1TableAdapters.RecambiosTableAdapter()
        Me.lblFact = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preciopieza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadPieza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecambiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Taller2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtTotalpiez)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.txtComCodCoche)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.txtConcepto)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtCantiP)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.txtPrecioIva)
        Me.GroupBox2.Controls.Add(Me.txtIVA)
        Me.GroupBox2.Controls.Add(Me.txtPrecioUni)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 322)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(546, 199)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Costos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(282, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(246, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Precio total  por unidad de todas piezas:"
        '
        'txtTotalpiez
        '
        Me.txtTotalpiez.Location = New System.Drawing.Point(325, 166)
        Me.txtTotalpiez.Name = "txtTotalpiez"
        Me.txtTotalpiez.ReadOnly = True
        Me.txtTotalpiez.Size = New System.Drawing.Size(138, 20)
        Me.txtTotalpiez.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(322, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Cod Coche:"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(373, 88)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(129, 29)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Quitar Filtro"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'txtComCodCoche
        '
        Me.txtComCodCoche.Location = New System.Drawing.Point(402, 21)
        Me.txtComCodCoche.Name = "txtComCodCoche"
        Me.txtComCodCoche.Size = New System.Drawing.Size(100, 20)
        Me.txtComCodCoche.TabIndex = 13
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(373, 54)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(129, 28)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Filtrar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'txtConcepto
        '
        Me.txtConcepto.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcepto.Location = New System.Drawing.Point(133, 15)
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.ReadOnly = True
        Me.txtConcepto.Size = New System.Drawing.Size(117, 33)
        Me.txtConcepto.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Concepto:"
        '
        'txtCantiP
        '
        Me.txtCantiP.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantiP.Location = New System.Drawing.Point(133, 54)
        Me.txtCantiP.Name = "txtCantiP"
        Me.txtCantiP.ReadOnly = True
        Me.txtCantiP.Size = New System.Drawing.Size(59, 21)
        Me.txtCantiP.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cantidad:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Precio con IVA:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "IVA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TOTAL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Precio Unidad:"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(133, 166)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(106, 21)
        Me.txtTotal.TabIndex = 3
        '
        'txtPrecioIva
        '
        Me.txtPrecioIva.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioIva.Location = New System.Drawing.Point(133, 138)
        Me.txtPrecioIva.Name = "txtPrecioIva"
        Me.txtPrecioIva.ReadOnly = True
        Me.txtPrecioIva.Size = New System.Drawing.Size(96, 21)
        Me.txtPrecioIva.TabIndex = 2
        '
        'txtIVA
        '
        Me.txtIVA.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVA.Location = New System.Drawing.Point(133, 111)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(75, 21)
        Me.txtIVA.TabIndex = 1
        Me.txtIVA.Text = "21%"
        '
        'txtPrecioUni
        '
        Me.txtPrecioUni.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioUni.Location = New System.Drawing.Point(133, 84)
        Me.txtPrecioUni.Name = "txtPrecioUni"
        Me.txtPrecioUni.ReadOnly = True
        Me.txtPrecioUni.Size = New System.Drawing.Size(75, 21)
        Me.txtPrecioUni.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.PowderBlue
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(29, 537)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(245, 34)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "CANCELAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PowderBlue
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(331, 537)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(244, 34)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "COMPRAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataCompras
        '
        Me.DataCompras.AutoGenerateColumns = False
        Me.DataCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Preciopieza, Me.CantidadPieza})
        Me.DataCompras.DataSource = Me.RecambiosBindingSource
        Me.DataCompras.Location = New System.Drawing.Point(29, 64)
        Me.DataCompras.Name = "DataCompras"
        Me.DataCompras.Size = New System.Drawing.Size(546, 237)
        Me.DataCompras.TabIndex = 14
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
        'RecambiosTableAdapter
        '
        Me.RecambiosTableAdapter.ClearBeforeFill = True
        '
        'lblFact
        '
        Me.lblFact.AutoSize = True
        Me.lblFact.BackColor = System.Drawing.Color.Transparent
        Me.lblFact.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFact.Location = New System.Drawing.Point(25, 26)
        Me.lblFact.Name = "lblFact"
        Me.lblFact.Size = New System.Drawing.Size(263, 24)
        Me.lblFact.TabIndex = 16
        Me.lblFact.Text = "LISTADO DE PRESUPUESTOS:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(214, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "€"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(235, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 18)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "€"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(245, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 18)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "€"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(469, 166)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 18)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "€"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "COD_PIEZA"
        Me.DataGridViewTextBoxColumn1.HeaderText = "COD_PIEZA"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE_PIEZA"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRE_PIEZA"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "COD_COCHE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "COD_COCHE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Preciopieza
        '
        Me.Preciopieza.DataPropertyName = "PRECIO_PIEZA"
        Me.Preciopieza.HeaderText = "PRECIO_PIEZA"
        Me.Preciopieza.Name = "Preciopieza"
        '
        'CantidadPieza
        '
        Me.CantidadPieza.DataPropertyName = "CANTIDAD_PIEZA"
        Me.CantidadPieza.HeaderText = "CANTIDAD_PIEZA"
        Me.CantidadPieza.Name = "CantidadPieza"
        '
        'ComprasRecambios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROLozanoJavier.My.Resources.Resources.grey_triangles_background_23_2147494297
        Me.ClientSize = New System.Drawing.Size(620, 590)
        Me.Controls.Add(Me.lblFact)
        Me.Controls.Add(Me.DataCompras)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ComprasRecambios"
        Me.Text = "ComprasRecambios"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecambiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Taller2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataCompras As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CODPIEZADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREPIEZADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODCOCHEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Taller2DataSet1 As PROLozanoJavier.Taller2DataSet1
    Friend WithEvents RecambiosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecambiosTableAdapter As PROLozanoJavier.Taller2DataSet1TableAdapters.RecambiosTableAdapter
    Friend WithEvents txtCantiP As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioIva As System.Windows.Forms.TextBox
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioUni As System.Windows.Forms.TextBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFact As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtComCodCoche As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtTotalpiez As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Preciopieza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadPieza As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
